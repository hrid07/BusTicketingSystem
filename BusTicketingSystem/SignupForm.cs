using System;
using System.Data;
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

            // =========================
            // REQUIRED FIELD VALIDATION
            // =========================

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Please enter your full name.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox3.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter a username.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show(
                    "Please enter your phone number.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox5.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter a password.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox4.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox4.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox1.Focus();
                return;
            }

            // =========================
            // PHONE VALIDATION
            // =========================

            if (phone.Length != 11 ||
                !long.TryParse(phone, out _))
            {
                MessageBox.Show(
                    "Please enter a valid 11 digit phone number.",
                    "Signup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox5.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Check username
                    string checkQuery =
                        "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                    using (SqlCommand checkCommand =
                           new SqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.Add(
                            "@Username",
                            SqlDbType.VarChar,
                            50).Value = username;

                        int count =
                            Convert.ToInt32(
                                checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show(
                                "Username already exists.",
                                "Signup Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            textBox2.Focus();
                            return;
                        }
                    }

                    string insertQuery = @"
                        INSERT INTO Users
                        (
                            FullName,
                            Username,
                            Phone,
                            Password
                        )
                        VALUES
                        (
                            @FullName,
                            @Username,
                            @Phone,
                            @Password
                        )";

                    using (SqlCommand command =
                           new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.Add(
                            "@FullName",
                            SqlDbType.VarChar,
                            100).Value = fullName;

                        command.Parameters.Add(
                            "@Username",
                            SqlDbType.VarChar,
                            50).Value = username;

                        command.Parameters.Add(
                            "@Phone",
                            SqlDbType.VarChar,
                            20).Value = phone;

                        command.Parameters.Add(
                            "@Password",
                            SqlDbType.VarChar,
                            100).Value = password;

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
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unexpected error:\n" + ex.Message,
                    "Error",
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