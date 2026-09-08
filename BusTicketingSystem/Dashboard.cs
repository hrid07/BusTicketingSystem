using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class Dashboard : Form
    {
        private readonly int userId;

        public Dashboard(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            WireEvents();
        }

        private void WireEvents()
        {
            btnSearch.Click += btnSearch_Click;
            btnAvailableJourney.Click += btnAvailableJourney_Click;

            btnSelectSeat.Click += btnSelectSeat_Click;
            btnPayment.Click += btnPayment_Click;
            btnConfirmation.Click += btnConfirmation_Click;

            btnLogout.Click += btnLogout_Click;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;

            LoadRoutes();
        }

        // SEARCH JOURNEY
    

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string from = cmbFrom.SelectedItem?.ToString();
            string to = cmbTo.SelectedItem?.ToString();
            DateTime date = dateTimePicker1.Value.Date;

            if (string.IsNullOrWhiteSpace(from) ||
                string.IsNullOrWhiteSpace(to))
            {
                MessageBox.Show(
                    "Please select both From and To cities.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (from.Equals(to, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "From and To cities cannot be the same.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (date < DateTime.Today)
            {
                MessageBox.Show(
                    "Please select today or a future date.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            AvailableJourney journey =
                new AvailableJourney(from, to, date, userId);

            journey.Show();

            this.Hide();
        }

        // =========================
        // ALL AVAILABLE JOURNEYS
        // =========================

        private void btnAvailableJourney_Click(object sender, EventArgs e)
        {
            AvailableJourney journey =
                new AvailableJourney(userId);

            journey.Show();

            this.Hide();
        }

        // =========================
        // SELECT SEAT
        // =========================

        private void btnSelectSeat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please select a journey first, then choose your seat.",
                "Select Seat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // PAYMENT
        // =========================

        private void btnPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Payment becomes available after you select your seat and create a booking.",
                "Payment",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // CONFIRMATION
        // =========================

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Your booking confirmation will appear after successful payment.",
                "Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // LOGOUT
        // =========================

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            LoginForm login = new LoginForm();

            login.Show();

            this.Hide();
        }

        // =========================
        // UNUSED DESIGNER EVENTS
        // =========================

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void LoadRoutes()
        {
            try
            {
                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand(
                           "SELECT DISTINCT Source, Destination " +
                           "FROM Routes " +
                           "ORDER BY Source",
                           con))
                {
                    con.Open();

                    using (SqlDataReader reader =
                           cmd.ExecuteReader())
                    {
                        cmbFrom.Items.Clear();
                        cmbTo.Items.Clear();

                        while (reader.Read())
                        {
                            string source =
                                reader["Source"].ToString();

                            string destination =
                                reader["Destination"].ToString();

                            if (!cmbFrom.Items.Contains(source))
                                cmbFrom.Items.Add(source);

                            if (!cmbTo.Items.Contains(destination))
                                cmbTo.Items.Add(destination);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load routes:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}