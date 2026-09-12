using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textName.Text.Trim();
            string password = textPass.Text;

            // ADMIN LOGIN
            if (username.Equals("admin",
                StringComparison.OrdinalIgnoreCase)
                && password == "admin123")
            {
                BusManagement adminPanel =
                    new BusManagement();

                adminPanel.Show();

                this.Hide();

                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textPass.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand("sp_LoginUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(
                        "@Username",
                        SqlDbType.VarChar,
                        50).Value = username;

                    cmd.Parameters.Add(
                        "@Password",
                        SqlDbType.VarChar,
                        100).Value = password;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            textPass.Clear();
                            textPass.Focus();

                            return;
                        }

                        int userId =
     Convert.ToInt32(reader["UserID"]);

                        AvailableJourney journey =
                            new AvailableJourney(userId);

                        journey.FormClosed += (s, args) =>
                        {
                            this.Show();
                        };

                        journey.Show();

                        this.Hide();
                    }
                }
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

        private void buttonSign_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();

            signup.Show();

            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textName.Focus();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
        }

        private void labelSign_Click(object sender, EventArgs e)
        {
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}