using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class Dashboard : Form
    {
        private readonly int userId;

        public Dashboard() : this(0) { }

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
            btnSelectSeat.Click += ComingSoon_Click;
            btnPayment.Click += ComingSoon_Click;
            btnConfirmation.Click += ComingSoon_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string from = cmbFrom.SelectedItem?.ToString();
            string to = cmbTo.SelectedItem?.ToString();
            DateTime date = dateTimePicker1.Value.Date;

            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Please select both From and To cities.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (from == to)
            {
                MessageBox.Show("From and To cities cannot be the same.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AvailableJourney journey = new AvailableJourney(from, to, date, userId);
            journey.Show();
            this.Hide();
        }

        private void btnAvailableJourney_Click(object sender, EventArgs e)
        {
            AvailableJourney journey = new AvailableJourney(userId);
            journey.Show();
            this.Hide();
        }

        private void ComingSoon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page isn't built yet - coming in a later phase.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {

        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}