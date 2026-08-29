using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class AvailableJourney : Form
    {
        private readonly string searchFrom;
        private readonly string searchTo;
        private readonly DateTime searchDate;
        private readonly bool hasSearch;

        public AvailableJourney()
        {
            InitializeComponent();
            hasSearch = false;
            WireEvents();
        }

        public AvailableJourney(string from, string to, DateTime date)
        {
            InitializeComponent();
            searchFrom = from;
            searchTo = to;
            searchDate = date;
            hasSearch = true;
            WireEvents();
        }

        private void WireEvents()
        {
            this.Load += AvailableJourney_Load;

            btnSelect1.Click += btnSelect_Click;
            btnSelect2.Click += btnSelect_Click;
            btnSelect3.Click += btnSelect_Click;

            buttonDashboard.Click += GoToDashboard_Click;
            buttonBack.Click += GoToDashboard_Click;
            butotnAvailableJourney.Click += (s, e) => LoadJourneys();

            buttonSelectSeat.Click += ComingSoon_Click;
            buttonPayment.Click += ComingSoon_Click;
            buttonConfirmation.Click += ComingSoon_Click;

            buttonLogout.Click += btnLogout_Click;
        }

        private void AvailableJourney_Load(object sender, EventArgs e)
        {
            LoadJourneys();
        }

        private void LoadJourneys()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (hasSearch)
                    {
                        cmd.CommandText = "sp_SearchSchedules";
                        cmd.Parameters.AddWithValue("@Source", searchFrom);
                        cmd.Parameters.AddWithValue("@Destination", searchTo);
                        cmd.Parameters.AddWithValue("@TravelDate", searchDate.Date);
                    }
                    else
                    {
                        cmd.CommandText = "sp_GetAllSchedules";
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading journeys:\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labelFromCity.Text = hasSearch ? searchFrom : "ALL";
            labelToCity.Text = hasSearch ? searchTo : "ALL";
            labelDate.Text = (hasSearch ? searchDate : DateTime.Today).ToString("dd MMM yyyy");
            labelTotalJourneys.Text = dt.Rows.Count.ToString();

            Panel[] cardPanels = { pnlJourney1, pnlJourney2, pnlJourney3 };
            Label[] busName = { lblBusName1, lblBusName2, lblBusName3 };
            Label[] busType = { lblBusType1, lblBusType2, lblBusType3 };
            Label[] price = { lblPrice1, lblPrice2, lblPrice3 };
            Label[] seats = { lblSeats1, lblSeats2, lblSeats3 };
            Label[] departureLoc = { lblDepartureLocation1, lblDepartureLocation2, lblDepartureLocation3 };
            Label[] departureTime = { lblDeparture1, lblDeparture2, lblDeparture3 };
            Label[] arrivalTime = { lblArrival1, lblArrival2, lblArrival3 };
            Label[] duration = { lblDuration1, lblDuration2, lblDuration3 };
            Button[] selectBtn = { btnSelect1, btnSelect2, btnSelect3 };

            for (int i = 0; i < cardPanels.Length; i++)
            {
                if (i < dt.Rows.Count)
                {
                    DataRow row = dt.Rows[i];
                    cardPanels[i].Visible = true;

                    busName[i].Text = row["BusName"].ToString();
                    busType[i].Text = row["BusType"].ToString();
                    price[i].Text = "TK " + Convert.ToDecimal(row["Fare"]).ToString("0");
                    seats[i].Text = row["AvailableSeats"].ToString() + " seats left";
                    departureLoc[i].Text = row["Source"].ToString();

                    DateTime dep = Convert.ToDateTime(row["DepartureTime"]);
                    DateTime arr = Convert.ToDateTime(row["ArrivalTime"]);
                    departureTime[i].Text = dep.ToString("hh:mm tt");
                    arrivalTime[i].Text = arr.ToString("hh:mm tt");

                    TimeSpan dur = arr - dep;
                    duration[i].Text = (int)dur.TotalHours + "h " + dur.Minutes + "m";

                    selectBtn[i].Tag = row["ScheduleID"];
                }
                else
                {
                    cardPanels[i].Visible = false;
                }
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No journeys found for this route and date.", "Available Journey",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int scheduleId = Convert.ToInt32(btn.Tag);
            SelectSeat selectSeat = new SelectSeat(scheduleId);
            selectSeat.ShowDialog();
            LoadJourneys(); // refresh seat counts after returning
        }

        private void GoToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
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

        private void lblSeatsTitle2_Click(object sender, EventArgs e)
        {

        }

        private void lblSeats2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void lblDeparture1_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartureLocation1_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartureTitle1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectSeat_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

        private void AvailableJourney_Load_1(object sender, EventArgs e)
        {

        }

        private void lblSeats3_Click(object sender, EventArgs e)
        {

        }
    }
}