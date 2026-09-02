using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class AvailableJourney : Form
    {
        private readonly int userId;
        private readonly string from;
        private readonly string to;
        private readonly DateTime date;
        private readonly bool isSearch;

        public AvailableJourney(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            ConnectButtons();
        }

        public AvailableJourney(string from, string to, DateTime date, int userId)
        {
            InitializeComponent();

            this.from = from;
            this.to = to;
            this.date = date.Date;
            this.userId = userId;
            isSearch = true;

            ConnectButtons();
        }

        private void ConnectButtons()
        {
            // Remove first so there is never a duplicate event
            btnSelect1.Click -= btnSelect_Click;
            btnSelect2.Click -= btnSelect_Click;
            btnSelect3.Click -= btnSelect_Click;

            buttonDashboard.Click -= buttonDashboard_Click;
            buttonBack.Click -= buttonBack_Click;

            buttonSelectSeat.Click -= buttonSelectSeat_Click;
            buttonPayment.Click -= buttonPayment_Click;
            buttonConfirmation.Click -= buttonConfirmation_Click;

            buttonLogout.Click -= buttonLogout_Click;

            // Connect buttons
            btnSelect1.Click += btnSelect_Click;
            btnSelect2.Click += btnSelect_Click;
            btnSelect3.Click += btnSelect_Click;

            buttonDashboard.Click += buttonDashboard_Click;
            buttonBack.Click += buttonBack_Click;

            buttonSelectSeat.Click += buttonSelectSeat_Click;
            buttonPayment.Click += buttonPayment_Click;
            buttonConfirmation.Click += buttonConfirmation_Click;

            buttonLogout.Click += buttonLogout_Click;
        }

        private void AvailableJourney_Load(object sender, EventArgs e)
        {
            LoadJourneys();
        }

        private void LoadJourneys()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection con = DBConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (isSearch)
                    {
                        cmd.CommandText = "sp_SearchSchedules";

                        cmd.Parameters.Add("@Source", SqlDbType.VarChar, 100).Value = from;
                        cmd.Parameters.Add("@Destination", SqlDbType.VarChar, 100).Value = to;
                        cmd.Parameters.Add("@TravelDate", SqlDbType.Date).Value = date;
                    }
                    else
                    {
                        cmd.CommandText = "sp_GetAllSchedules";
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        da.Fill(dt);
                }

                labelTotalJourneys.Text = dt.Rows.Count.ToString();

                Panel[] panels = { pnlJourney1, pnlJourney2, pnlJourney3 };
                Button[] buttons = { btnSelect1, btnSelect2, btnSelect3 };

                Label[] names = { lblBusName1, lblBusName2, lblBusName3 };
                Label[] types = { lblBusType1, lblBusType2, lblBusType3 };
                Label[] prices = { lblPrice1, lblPrice2, lblPrice3 };
                Label[] seats = { lblSeats1, lblSeats2, lblSeats3 };
                Label[] locations =
                {
                    lblDepartureLocation1,
                    lblDepartureLocation2,
                    lblDepartureLocation3
                };
                Label[] departures =
                {
                    lblDeparture1,
                    lblDeparture2,
                    lblDeparture3
                };
                Label[] arrivals =
                {
                    lblArrival1,
                    lblArrival2,
                    lblArrival3
                };
                Label[] durations =
                {
                    lblDuration1,
                    lblDuration2,
                    lblDuration3
                };

                for (int i = 0; i < 3; i++)
                {
                    if (i >= dt.Rows.Count)
                    {
                        panels[i].Visible = false;
                        continue;
                    }

                    DataRow r = dt.Rows[i];

                    panels[i].Visible = true;

                    names[i].Text = r["BusName"].ToString();
                    types[i].Text = r["BusType"].ToString();
                    prices[i].Text = "TK " + Convert.ToDecimal(r["Fare"]).ToString("0");
                    seats[i].Text = r["AvailableSeats"] + " seats left";
                    locations[i].Text = r["Source"].ToString();

                    DateTime departure = Convert.ToDateTime(r["DepartureTime"]);
                    DateTime arrival = Convert.ToDateTime(r["ArrivalTime"]);

                    departures[i].Text = departure.ToString("hh:mm tt");
                    arrivals[i].Text = arrival.ToString("hh:mm tt");

                    TimeSpan duration = arrival - departure;

                    if (duration.TotalMinutes < 0)
                        duration = duration.Add(TimeSpan.FromDays(1));

                    durations[i].Text =
                        $"{(int)duration.TotalHours}h {duration.Minutes}m";

                    buttons[i].Tag = Convert.ToInt32(r["ScheduleID"]);
                    buttons[i].Enabled =
                        Convert.ToInt32(r["AvailableSeats"]) > 0;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No journeys found.",
                        "Available Journey",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading journeys:\n" + ex.Message,
                    "Error",

                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int scheduleId = Convert.ToInt32(btn.Tag);

            SelectSeat seat = new SelectSeat(scheduleId, userId);
            seat.ShowDialog();

            LoadJourneys();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            new Dashboard(userId).Show();
            Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            new Dashboard(userId).Show();
            Hide();
        }

        private void buttonSelectSeat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a journey first.");
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment is available after booking a seat.");
        }

        private void buttonConfirmation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmation is available after successful payment.");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new LoginForm().Show();
                Hide();
            }
        }
    
            private void pnlJourney1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlJourney2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlJourney3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
        }

        private void lblSeats2_Click(object sender, EventArgs e)
        {
        }

        private void lblSeats3_Click(object sender, EventArgs e)
        {
        }

        private void lblSeatsTitle2_Click(object sender, EventArgs e)
        {
        }

        private void lblDepartureLocation1_Click(object sender, EventArgs e)
        {
        }

        private void lblDeparture1_Click(object sender, EventArgs e)
        {
        }

        private void lblDepartureTitle1_Click(object sender, EventArgs e)
        {
        }

        private void AvailableJourney_Load_1(object sender, EventArgs e)
        {
        }
    }
}
