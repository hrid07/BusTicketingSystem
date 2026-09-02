using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class Payment : Form
    {
        private readonly int bookingId;
        private readonly int userId;
        private readonly decimal totalAmount;

        public Payment(int bookingId, int userId, decimal totalAmount)
        {
            InitializeComponent();

            this.bookingId = bookingId;
            this.userId = userId;
            this.totalAmount = totalAmount;

            Paymentlabel6.Text = "Amount: " + totalAmount.ToString("0.00") + " BDT";
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            PaymentButton1.Checked = true;
            textBox2.UseSystemPasswordChar = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (PaymentButton1.Checked)
            {
                Paymentlabel9.Text = "bKash Number:";
            }
            else if (PaymentButton2.Checked)
            {
                Paymentlabel9.Text = "Nagad Number:";
            }
            else if (PaymentButton3.Checked)
            {
                Paymentlabel9.Text = "Card Number:";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox1.Text.Trim();
            string pin = textBox2.Text.Trim();

            string paymentMethod = GetPaymentMethod();

            if (paymentMethod == "")
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (accountNumber == "" || pin == "")
            {
                MessageBox.Show(
                    "Please enter all payment information.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!IsValidPaymentInformation(paymentMethod, accountNumber, pin))
            {
                return;
            }

            try
            {
                ProcessPayment(paymentMethod, accountNumber);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error while processing payment.\n\n" + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Payment failed.\n\n" + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string GetPaymentMethod()
        {
            if (PaymentButton1.Checked)
                return "bKash";

            if (PaymentButton2.Checked)
                return "Nagad";

            if (PaymentButton3.Checked)
                return "Card";

            return "";
        }

        private bool IsValidPaymentInformation(
            string paymentMethod,
            string accountNumber,
            string pin)
        {
            if (paymentMethod == "bKash" || paymentMethod == "Nagad")
            {
                if (!IsDigitsOnly(accountNumber) || accountNumber.Length != 11)
                {
                    MessageBox.Show(
                        "Please enter a valid 11 digit mobile number.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                if (!IsDigitsOnly(pin) || pin.Length != 5)
                {
                    MessageBox.Show(
                        "Please enter a valid 5 digit PIN.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }
            }

            if (paymentMethod == "Card")
            {
                if (!IsDigitsOnly(accountNumber) ||
                    (accountNumber.Length != 16 &&
                     accountNumber.Length != 15))
                {
                    MessageBox.Show(
                        "Please enter a valid card number.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                if (!IsDigitsOnly(pin) || pin.Length != 4)
                {
                    MessageBox.Show(
                        "Please enter a valid 4 digit PIN.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }
            }

            return true;
        }

        private bool IsDigitsOnly(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        private void ProcessPayment(
            string paymentMethod,
            string accountNumber)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // 1. Make sure the booking exists.
                        string bookingQuery = @"
                            SELECT COUNT(*)
                            FROM Bookings
                            WHERE BookingID = @BookingID";

                        using (SqlCommand bookingCmd =
                            new SqlCommand(bookingQuery, con, transaction))
                        {
                            bookingCmd.Parameters.Add(
                                "@BookingID",
                                SqlDbType.Int).Value = bookingId;

                            int bookingExists =
                                Convert.ToInt32(bookingCmd.ExecuteScalar());

                            if (bookingExists == 0)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "The booking could not be found.",
                                    "Payment Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                return;
                            }
                        }

                        // 2. Prevent duplicate payment.
                        string paymentCheckQuery = @"
                            SELECT COUNT(*)
                            FROM Payments
                            WHERE BookingID = @BookingID";

                        using (SqlCommand checkCmd =
                            new SqlCommand(paymentCheckQuery, con, transaction))
                        {
                            checkCmd.Parameters.Add(
                                "@BookingID",
                                SqlDbType.Int).Value = bookingId;

                            int paymentExists =
                                Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (paymentExists > 0)
                            {
                                transaction.Rollback();

                                MessageBox.Show(
                                    "This booking has already been paid.",
                                    "Payment Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }
                        }

                        // 3. Generate transaction ID.
                        string transactionId =
                            "TXN" +
                            DateTime.Now.ToString("yyyyMMddHHmmssfff");

                        // 4. Mask account/card number.
                        string maskedNumber =
                            MaskAccountNumber(accountNumber);

                        // 5. Insert payment.
                        string insertQuery = @"
                            INSERT INTO Payments
                            (
                                BookingID,
                                UserID,
                                PaymentMethod,
                                AccountNumber,
                                Amount,
                                PaymentDate,
                                TransactionID
                            )
                            VALUES
                            (
                                @BookingID,
                                @UserID,
                                @PaymentMethod,
                                @AccountNumber,
                                @Amount,
                                GETDATE(),
                                @TransactionID
                            )";

                        using (SqlCommand insertCmd =
                            new SqlCommand(insertQuery, con, transaction))
                        {
                            insertCmd.Parameters.Add(
                                "@BookingID",
                                SqlDbType.Int).Value = bookingId;

                            if (userId == 0)
                            {
                                insertCmd.Parameters.Add(
                                    "@UserID",
                                    SqlDbType.Int).Value = DBNull.Value;
                            }
                            else
                            {
                                insertCmd.Parameters.Add(
                                    "@UserID",
                                    SqlDbType.Int).Value = userId;
                            }

                            insertCmd.Parameters.Add(
                                "@PaymentMethod",
                                SqlDbType.VarChar, 20).Value =
                                paymentMethod;

                            insertCmd.Parameters.Add(
                                "@AccountNumber",
                                SqlDbType.VarChar, 50).Value =
                                maskedNumber;

                            SqlParameter amountParameter =
                                insertCmd.Parameters.Add(
                                    "@Amount",
                                    SqlDbType.Decimal);

                            amountParameter.Precision = 10;
                            amountParameter.Scale = 2;
                            amountParameter.Value = totalAmount;

                            insertCmd.Parameters.Add(
                                "@TransactionID",
                                SqlDbType.VarChar, 50).Value =
                                transactionId;

                            insertCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show(
                            "Payment successful!\n\n" +
                            "Payment Method: " + paymentMethod +
                            "\nAmount: " +
                            totalAmount.ToString("0.00") +
                            " BDT" +
                            "\nTransaction ID: " +
                            transactionId,
                            "Payment Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        ClearFields();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch
                        {
                            // Ignore rollback errors.
                        }

                        throw;
                    }
                }
            }
        }

        private string MaskAccountNumber(string accountNumber)
        {
            if (accountNumber.Length <= 4)
                return accountNumber;

            return new string(
                       '*',
                       accountNumber.Length - 4)
                   + accountNumber.Substring(
                       accountNumber.Length - 4);
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void PaymentPanel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}