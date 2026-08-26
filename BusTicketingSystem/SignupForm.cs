using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            string fullName = textBox3.Text.Trim();
            string username = textBox2.Text.Trim();
            string phone = textBox5.Text.Trim();
            string password = textBox4.Text;
            string confirmPassword = textBox1.Text;

            if (fullName == "" || username == "" || phone == "" ||
                password == "" || confirmPassword == "")
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery =
                        "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                    using (SqlCommand checkCommand =
                           new SqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue(
                            "@Username", username);

                        int count = Convert.ToInt32(
                            checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show(
                                "Username already exists.",
                                "Signup Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    string insertQuery =
                        "INSERT INTO Users " +
                        "(FullName, Username, Phone, Password) " +
                        "VALUES " +
                        "(@FullName, @Username, @Phone, @Password)";

                    using (SqlCommand command =
                           new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue(
                            "@FullName", fullName);

                        command.Parameters.AddWithValue(
                            "@Username", username);

                        command.Parameters.AddWithValue(
                            "@Phone", phone);

                        command.Parameters.AddWithValue(
                            "@Password", password);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Account created successfully!",
                    "Signup Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error connecting to database:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}