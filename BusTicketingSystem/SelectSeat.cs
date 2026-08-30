using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class SelectSeat : Form
    {
        private readonly int scheduleId;
        private readonly int userId; // 0 = not logged in / not passed through yet
        private decimal farePerSeat;

        // Match the legend swatches already on the form (buttonFalse1/2/3)
        private static readonly Color AvailableColor = Color.DarkSeaGreen;
        private static readonly Color BookedColor = Color.SaddleBrown;
        private static readonly Color SelectedColor = Color.DimGray;

        private readonly Dictionary<string, Button> seatButtons = new Dictionary<string, Button>();
        private readonly List<string> selectedSeats = new List<string>();

        public SelectSeat(int scheduleId) : this(scheduleId, 0) { }

        public SelectSeat(int scheduleId, int userId)
        {
            InitializeComponent();
            this.scheduleId = scheduleId;
            this.userId = userId;
            CollectSeatButtons();
            WireEvents();
        }

        // Finds every button on the form whose Text looks like a seat code (A1, B2, H3, ...)
        // and wires it up. This works regardless of which designer field name it has,
        // so buttonFalse1/2/3 (the legend swatches, which have no seat text) are skipped automatically.
        private void CollectSeatButtons()
        {
            Regex seatPattern = new Regex(@"^[A-H][1-3]$");
            foreach (Control c in GetAllControls(this))
            {
                if (c is Button btn && seatPattern.IsMatch(btn.Text))
                {
                    seatButtons[btn.Text] = btn;
                    btn.Click += SeatButton_Click;
                }
            }
        }

        private IEnumerable<Control> GetAllControls(Control root)
        {
            foreach (Control child in root.Controls)
            {
                yield return child;
                foreach (Control grandchild in GetAllControls(child))
                    yield return grandchild;
            }
        }

        private void WireEvents()
        {
            // NOTE: SelectSeat.Designer.cs already wires this.Load to SelectSeat_Load,
            // so it is NOT re-wired here (that would run it twice on every open).
            buttonConfirmbooking.Click += buttonConfirmbooking_Click;
            buttonBack.Click += buttonBack_Click;
        }

        private void SelectSeat_Load(object sender, EventArgs e)
        {
            LoadScheduleDetails();
            LoadSeatMap();
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

                        labelBus.Text = row["BusName"].ToString() + " (" + row["BusType"].ToString() + ")";
                        labelRoute.Text = row["Source"].ToString() + " -> " + row["Destination"].ToString();

                        DateTime dep = Convert.ToDateTime(row["DepartureTime"]);
                        labelDataTime.Text = dep.ToString("dd MMM yyyy, hh:mm tt");

                        labelFare.Text = "Base Fare: " + farePerSeat.ToString("0") + " BDT";

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

        private void LoadSeatMap()
        {
            selectedSeats.Clear();

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand("sp_GetSeatsForSchedule", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var statusBySeat = new Dictionary<string, string>();
                        while (reader.Read())
                        {
                            statusBySeat[reader["SeatNumber"].ToString()] = reader["Status"].ToString();
                        }

                        foreach (var kvp in seatButtons)
                        {
                            string seatNumber = kvp.Key;
                            Button btn = kvp.Value;

                            bool isBooked = statusBySeat.TryGetValue(seatNumber, out string status)
                                            && status == "Booked";

                            btn.BackColor = isBooked ? BookedColor : AvailableColor;
                            btn.Enabled = !isBooked;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading seat map:\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateTotal();
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string seatNumber = btn.Text;

            if (selectedSeats.Contains(seatNumber))
            {
                selectedSeats.Remove(seatNumber);
                btn.BackColor = AvailableColor;
            }
            else
            {
                selectedSeats.Add(seatNumber);
                btn.BackColor = SelectedColor;
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = selectedSeats.Count * farePerSeat;
            labelTotalPrice.Text = "TOTAL PRICE: " + total.ToString("0") + " BDT ("
                + selectedSeats.Count + (selectedSeats.Count == 1 ? " seat)" : " seats)");
        }

        private void buttonConfirmbooking_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select at least one seat first.", "No Seats Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand("sp_ConfirmBooking", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
                    cmd.Parameters.AddWithValue("@UserID", userId == 0 ? (object)DBNull.Value : userId);
                    cmd.Parameters.AddWithValue("@SeatNumbers", string.Join(",", selectedSeats));

                    SqlParameter bookingIdParam = new SqlParameter("@BookingID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    SqlParameter pnrParam = new SqlParameter("@PNR", SqlDbType.VarChar, 20) { Direction = ParameterDirection.Output };
                    SqlParameter successParam = new SqlParameter("@Success", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(bookingIdParam);
                    cmd.Parameters.Add(pnrParam);
                    cmd.Parameters.Add(successParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    bool success = Convert.ToBoolean(successParam.Value);

                    if (success)
                    {
                        string pnr = pnrParam.Value.ToString();
                        MessageBox.Show(
                            "Seats booked: " + string.Join(", ", selectedSeats) +
                            "\nPNR: " + pnr +
                            "\nStatus: Pending payment." +
                            "\n\n(Payment page comes next — this booking is saved as Pending.)",
                            "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "One or more of your selected seats were just booked by someone else. " +
                            "The seat map has been refreshed — please choose again.",
                            "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadSeatMap();
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