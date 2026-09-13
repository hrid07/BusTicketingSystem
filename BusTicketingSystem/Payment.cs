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

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            PaymentButton1.Checked = true;
            textBox2.UseSystemPasswordChar = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (PaymentButton1.Checked)
                Paymentlabel9.Text = "bKash Number:";
            else if (PaymentButton2.Checked)
                Paymentlabel9.Text = "Nagad Number:";
            else
                Paymentlabel9.Text = "Card Number:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox1.Text.Trim();
            string pin = textBox2.Text.Trim();

            string paymentMethod = GetPaymentMethod();

            if (string.IsNullOrEmpty(accountNumber) ||
                string.IsNullOrEmpty(pin))
            {
                MessageBox.Show(
                    "Please enter all payment information.",
                    "Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidatePayment(paymentMethod, accountNumber, pin))
                return;

            try
            {
                ProcessPayment(paymentMethod, accountNumber);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error:\n\n" + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Payment failed:\n\n" + ex.Message,
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

        private bool ValidatePayment(
            string method,
            string accountNumber,
            string pin)
        {
            if (method == "bKash" || method == "Nagad")
            {
                if (!IsDigits(accountNumber) ||
                    accountNumber.Length != 11)
                {
                    MessageBox.Show(
                        "Enter a valid 11 digit mobile number.",
                        "Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                if (!IsDigits(pin) || pin.Length != 5)
                {
                    MessageBox.Show(
                        "Enter a valid 5 digit PIN.",
                        "Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }
            }
            else if (method == "Card")
            {
                if (!IsDigits(accountNumber) ||
                    (accountNumber.Length != 15 &&
                     accountNumber.Length != 16))
                {
                    MessageBox.Show(
                        "Enter a valid card number.",
                        "Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                if (!IsDigits(pin) || pin.Length != 4)
                {
                    MessageBox.Show(
                        "Enter a valid 4 digit PIN.",
                        "Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }
            }

            return true;
        }

        private bool IsDigits(string value)
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

                using (SqlTransaction transaction =
                       con.BeginTransaction())
                {
                    try
                    {
                        string checkBooking = @"
                    SELECT Status, TotalFare
                    FROM Bookings WITH (UPDLOCK, HOLDLOCK)
                    WHERE BookingID = @BookingID
                      AND (@UserID = 0 OR UserID = @UserID)";

                        decimal bookingAmount;

                        using (SqlCommand cmd =
                               new SqlCommand(
                                   checkBooking,
                                   con,
                                   transaction))
                        {
                            cmd.Parameters.Add(
                                "@BookingID",
                                SqlDbType.Int).Value = bookingId;

                            cmd.Parameters.Add(
                                "@UserID",
                                SqlDbType.Int).Value = userId;

                            using (SqlDataReader reader =
                                   cmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    throw new Exception(
                                        "Booking was not found.");
                                }

                                string status =
                                    reader["Status"].ToString();

                                if (!status.Equals(
                                    "Pending",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    throw new Exception(
                                        "This booking is no longer pending.");
                                }

                                bookingAmount =
                                    Convert.ToDecimal(
                                        reader["TotalFare"]);
                            }
                        }

                        if (bookingAmount != totalAmount)
                        {
                            throw new Exception(
                                "Payment amount does not match the booking.");
                        }

                        string transactionRef =
                            "TXN" +
                            DateTime.Now.ToString(
                                "yyyyMMddHHmmssfff");

                        string insertPayment = @"
                    INSERT INTO Payments
                    (
                        BookingID,
                        Amount,
                        Method,
                        TransactionRef,
                        Status,
                        PaidAt
                    )
                    VALUES
                    (
                        @BookingID,
                        @Amount,
                        @Method,
                        @TransactionRef,
                        'Paid',
                        GETDATE()
                    )";

                        using (SqlCommand cmd =
                               new SqlCommand(
                                   insertPayment,
                                   con,
                                   transaction))
                        {
                            cmd.Parameters.Add(
                                "@BookingID",
                                SqlDbType.Int).Value = bookingId;

                            SqlParameter amount =
                                cmd.Parameters.Add(
                                    "@Amount",
                                    SqlDbType.Decimal);

                            amount.Precision = 10;
                            amount.Scale = 2;
                            amount.Value = totalAmount;

                            cmd.Parameters.Add(
                                "@Method",
                                SqlDbType.VarChar, 20).Value =
                                paymentMethod;

                            cmd.Parameters.Add(
                                "@TransactionRef",
                                SqlDbType.VarChar, 50).Value =
                                transactionRef;

                            cmd.ExecuteNonQuery();
                        }

                        string updateBooking = @"
                    UPDATE Bookings
                    SET Status = 'Confirmed'
                    WHERE BookingID = @BookingID
                      AND Status = 'Pending'";

                        using (SqlCommand cmd =
                               new SqlCommand(
                                   updateBooking,
                                   con,
                                   transaction))
                        {
                            cmd.Parameters.Add(
                                "@BookingID",
                                SqlDbType.Int).Value = bookingId;

                            if (cmd.ExecuteNonQuery() != 1)
                            {
                                throw new Exception(
                                    "Booking could not be confirmed.");
                            }
                        }

                        transaction.Commit();

                        MessageBox.Show(
                            "Payment successful!\n\n" +
                            "Method: " + paymentMethod +
                            "\nAmount: " +
                            totalAmount.ToString("0.00") +
                            " BDT" +
                            "\nTransaction: " +
                            transactionRef,
                            "Payment Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        TicketConfirmation ticket =
                            new TicketConfirmation(
                                bookingId,
                                userId);

                        ticket.Show();

                        Close();
                    }
                    catch
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch
                        {
                        }

                        throw;
                    }
                }
            }
        }

        private string MaskNumber(string number)
        {
            if (number.Length <= 4)
                return number;

            return new string(
                       '*',
                       number.Length - 4)
                   + number.Substring(
                       number.Length - 4);
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void PaymentPanel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}