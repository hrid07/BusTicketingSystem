using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class Payment : Form
    {
        private int bookingId;
        private int userId;
        private decimal totalAmount;

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

            string paymentMethod = "";

            if (PaymentButton1.Checked)
            {
                paymentMethod = "bKash";
            }
            else if (PaymentButton2.Checked)
            {
                paymentMethod = "Nagad";
            }
            else if (PaymentButton3.Checked)
            {
                paymentMethod = "Card";
            }

            if (accountNumber == "" || pin == "")
            {
                MessageBox.Show(
                    "Please enter payment information.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (paymentMethod == "bKash" || paymentMethod == "Nagad")
            {
                if (accountNumber.Length != 11)
                {
                    MessageBox.Show(
                        "Please enter a valid 11 digit mobile number.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            if (paymentMethod == "Card")
            {
                if (accountNumber.Length < 12)
                {
                    MessageBox.Show(
                        "Please enter a valid card number.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    string checkQuery = "SELECT COUNT(*) FROM Payments WHERE BookingID = @BookingID";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                    checkCmd.Parameters.AddWithValue("@BookingID", this.bookingId);

                    con.Open();

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show(
                            "This booking has already been paid.",
                            "Payment Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    string transactionId =
                        "TXN" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

                    string maskedNumber = accountNumber;

                    if (accountNumber.Length > 4)
                    {
                        maskedNumber =
                            new string('*', accountNumber.Length - 4) +
                            accountNumber.Substring(accountNumber.Length - 4);
                    }

                    string query = @"INSERT INTO Payments
                                     (BookingID, UserID, PaymentMethod,
                                      AccountNumber, Amount, PaymentDate,
                                      TransactionID)
                                     VALUES
                                     (@BookingID, @UserID, @PaymentMethod,
                                      @AccountNumber, @Amount, GETDATE(),
                                      @TransactionID)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BookingID", this.bookingId);

                    if (this.userId == 0)
                    {
                        cmd.Parameters.AddWithValue("@UserID", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@UserID", this.userId);
                    }

                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmd.Parameters.AddWithValue("@AccountNumber", maskedNumber);
                    cmd.Parameters.AddWithValue("@Amount", this.totalAmount);
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Payment successful!\n\n" +
                        "Payment Method: " + paymentMethod +
                        "\nAmount: " + this.totalAmount.ToString("0.00") + " BDT" +
                        "\nTransaction ID: " + transactionId,
                        "Payment Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Payment failed.\n" + ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void PaymentPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}