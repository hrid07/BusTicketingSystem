using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class SelectSeat : Form
    {
        private readonly int scheduleId;
        private decimal farePerSeat;
        private int availableSeats;

        public SelectSeat(int scheduleId)
        {
            InitializeComponent();
            this.scheduleId = scheduleId;
            WireEvents();
        }

        private void WireEvents()
        {
            this.Load += SelectSeat_Load;
            numberSeats.ValueChanged += numberSeats_ValueChanged;
            buttonConfirmbooking.Click += buttonConfirmbooking_Click;
            buttonBack.Click += buttonBack_Click;
        }

        private void SelectSeat_Load(object sender, EventArgs e)
        {
            LoadScheduleDetails();
        }

        private void LoadScheduleDetails()
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand("sp_GetAllSchedules", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        DataRow[] rows = dt.Select("ScheduleID = " + scheduleId);
                        if (rows.Length == 0)
                        {
                            MessageBox.Show("Schedule not found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            return;
                        }

                        DataRow row = rows[0];
                        farePerSeat = Convert.ToDecimal(row["Fare"]);
                        availableSeats = Convert.ToInt32(row["AvailableSeats"]);

                        labelBus.Text = row["BusName"].ToString() + " (" + row["BusType"].ToString() + ")";
                        labelRoute.Text = row["Source"].ToString() + " -> " + row["Destination"].ToString();

                        DateTime dep = Convert.ToDateTime(row["DepartureTime"]);
                        labelDataTime.Text = dep.ToString("dd MMM yyyy, hh:mm tt");

                        labelFare.Text = "TK " + farePerSeat.ToString("0") + " per seat";

                        numberSeats.Minimum = 1;
                        numberSeats.Maximum = availableSeats > 0 ? availableSeats : 1;

                        UpdateTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedule:\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numberSeats_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = farePerSeat * numberSeats.Value;
            labelTotalPrice.Text = "Total: TK " + total.ToString("0");
        }

        private void buttonConfirmbooking_Click(object sender, EventArgs e)
        {
            int seatsRequested = (int)numberSeats.Value;

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand("sp_BookSeats", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
                    cmd.Parameters.AddWithValue("@SeatsRequested", seatsRequested);

                    SqlParameter successParam = new SqlParameter("@Success", SqlDbType.Bit);
                    successParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(successParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    bool success = Convert.ToBoolean(successParam.Value);

                    if (success)
                    {
                        MessageBox.Show("Seats booked successfully! (Booking record + Payment page come next.)",
                            "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Not enough seats available. Please choose a lower seat count.",
                            "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadScheduleDetails();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error confirming booking:\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}