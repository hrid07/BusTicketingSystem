using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class SelectSeat : Form
    {
        private readonly int scheduleId;
        private readonly int userId;

        private decimal farePerSeat = 0;

        private readonly List<string> selectedSeats =
            new List<string>();

        private readonly Dictionary<string, Button> seatButtons =
            new Dictionary<string, Button>(
                StringComparer.OrdinalIgnoreCase);

        public SelectSeat(int scheduleId, int userId)
        {
            InitializeComponent();

            this.scheduleId = scheduleId;
            this.userId = userId;

            FindSeatButtons();

            buttonConfirmbooking.Click -=
                buttonConfirmbooking_Click;

            buttonConfirmbooking.Click +=
                buttonConfirmbooking_Click;

            buttonBack.Click -=
                buttonBack_Click;

            buttonBack.Click +=
                buttonBack_Click;

            butotnAvailableJourney.Click -=
                butotnAvailableJourney_Click;

            butotnAvailableJourney.Click +=
                butotnAvailableJourney_Click;

            buttonLogout.Click -=
                buttonLogout_Click;

            buttonLogout.Click +=
                buttonLogout_Click;
        }

        private void SelectSeat_Load(
            object sender,
            EventArgs e)
        {
            LoadSchedule();
            LoadSeats();
        }

        private void FindSeatButtons()
        {
            seatButtons.Clear();

            Button[] buttons =
            {
                button2, button3, button4,
                button5, button6, button7,
                button8, button9, button10,
                button11, button12, button13,
                button14, button15, button16,
                button17, button18, button19,
                button20, button21, button22,
                button23, button24, button25
            };

            foreach (Button button in buttons)
            {
                string seat =
                    button.Text.Trim().ToUpper();

                if (string.IsNullOrWhiteSpace(seat))
                    continue;

                seatButtons[seat] = button;

                button.Click -= SeatButton_Click;
                button.Click += SeatButton_Click;
            }
        }

        private void LoadSchedule()
        {
            try
            {
                string query = @"
                    SELECT
                        s.Fare,
                        b.BusName,
                        b.BusType,
                        r.Source,
                        r.Destination,
                        s.DepartureTime
                    FROM Schedules s
                    INNER JOIN Buses b
                        ON s.BusID = b.BusID
                    INNER JOIN Routes r
                        ON s.RouteID = r.RouteID
                    WHERE s.ScheduleID = @ScheduleID";

                using (SqlConnection con =
                    DBConnection.GetConnection())
                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.Add(
                        "@ScheduleID",
                        SqlDbType.Int).Value =
                        scheduleId;

                    con.Open();

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show(
                                "Journey not found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            Close();
                            return;
                        }

                        farePerSeat =
                            Convert.ToDecimal(
                                reader["Fare"]);

                        labelBus.Text =
                            reader["BusName"].ToString() +
                            " (" +
                            reader["BusType"].ToString() +
                            ")";

                        labelRoute.Text =
                            reader["Source"].ToString() +
                            " → " +
                            reader["Destination"].ToString();

                        DateTime departure =
                            Convert.ToDateTime(
                                reader["DepartureTime"]);

                        labelDataTime.Text =
                            departure.ToString(
                                "dd MMM yyyy, hh:mm tt");

                        labelFare.Text =
                            "Base Fare: " +
                            farePerSeat.ToString("0") +
                            " BDT";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load journey:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            UpdateTotal();
        }

        private void LoadSeats()
        {
            selectedSeats.Clear();

            foreach (Button button in seatButtons.Values)
            {
                button.Enabled = true;
                button.BackColor = Color.DarkSeaGreen;
                button.ForeColor = Color.Black;
            }

            try
            {
                string query = @"
                    SELECT
                        SeatNumber,
                        Status
                    FROM ScheduleSeats
                    WHERE ScheduleID = @ScheduleID
                    ORDER BY SeatNumber";

                using (SqlConnection con =
                    DBConnection.GetConnection())
                using (SqlCommand cmd =
                    new SqlCommand(query, con))
                {
                    cmd.Parameters.Add(
                        "@ScheduleID",
                        SqlDbType.Int).Value =
                        scheduleId;

                    con.Open();

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string seat =
                                reader["SeatNumber"]
                                .ToString()
                                .Trim()
                                .ToUpper();

                            string status =
                                reader["Status"]
                                .ToString()
                                .Trim();

                            if (!seatButtons.ContainsKey(seat))
                                continue;

                            Button button =
                                seatButtons[seat];

                            if (status.Equals(
                                "Booked",
                                StringComparison.OrdinalIgnoreCase))
                            {
                                button.BackColor =
                                    Color.DimGray;

                                button.ForeColor =
                                    Color.White;

                                button.Enabled = false;
                            }
                            else
                            {
                                button.BackColor =
                                    Color.DarkSeaGreen;

                                button.ForeColor =
                                    Color.Black;

                                button.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load seats:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            UpdateTotal();
        }

        private void SeatButton_Click(
            object sender,
            EventArgs e)
        {
            Button button =
                sender as Button;

            if (button == null ||
                !button.Enabled)
                return;

            string seat =
                button.Text.Trim().ToUpper();

            if (selectedSeats.Contains(seat))
            {
                selectedSeats.Remove(seat);

                button.BackColor =
                    Color.DarkSeaGreen;

                button.ForeColor =
                    Color.Black;
            }
            else
            {
                selectedSeats.Add(seat);

                button.BackColor =
                    Color.MidnightBlue;

                button.ForeColor =
                    Color.White;
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total =
                selectedSeats.Count *
                farePerSeat;

            labelTotalPrice.Text =
                "TOTAL PRICE: " +
                total.ToString("0") +
                " BDT (" +
                selectedSeats.Count +
                " seats)";
        }

        private void buttonConfirmbooking_Click(
            object sender,
            EventArgs e)
        {
            if (userId <= 0)
            {
                MessageBox.Show(
                    "Please login first.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (selectedSeats.Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one seat.",
                    "No Seat Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection con =
                    DBConnection.GetConnection())
                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_ConfirmBooking",
                        con))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.Add(
                        "@ScheduleID",
                        SqlDbType.Int).Value =
                        scheduleId;

                    cmd.Parameters.Add(
                        "@UserID",
                        SqlDbType.Int).Value =
                        userId;

                    cmd.Parameters.Add(
                        "@SeatNumbers",
                        SqlDbType.NVarChar,
                        200).Value =
                        string.Join(
                            ",",
                            selectedSeats);

                    SqlParameter bookingId =
                        cmd.Parameters.Add(
                            "@BookingID",
                            SqlDbType.Int);

                    bookingId.Direction =
                        ParameterDirection.Output;

                    SqlParameter pnr =
                        cmd.Parameters.Add(
                            "@PNR",
                            SqlDbType.VarChar,
                            20);

                    pnr.Direction =
                        ParameterDirection.Output;

                    SqlParameter success =
                        cmd.Parameters.Add(
                            "@Success",
                            SqlDbType.Bit);

                    success.Direction =
                        ParameterDirection.Output;

                    con.Open();

                    cmd.ExecuteNonQuery();

                    bool isSuccess =
                        success.Value != DBNull.Value &&
                        Convert.ToBoolean(
                            success.Value);

                    if (!isSuccess)
                    {
                        MessageBox.Show(
                            "The selected seat is not available.",
                            "Booking Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        LoadSeats();
                        return;
                    }

                    int bookingIdValue =
                        Convert.ToInt32(
                            bookingId.Value);

                    decimal total =
                        selectedSeats.Count *
                        farePerSeat;

                    Payment payment =
                        new Payment(
                            bookingIdValue,
                            userId,
                            total);

                    payment.ShowDialog();

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to create booking:\n\n" +
                    ex.Message,
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void butotnAvailableJourney_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void buttonLogout_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            for (int i =
                Application.OpenForms.Count - 1;
                i >= 0;
                i--)
            {
                Form form =
                    Application.OpenForms[i];

                if (form is AvailableJourney)
                {
                    form.Close();
                }
            }

            LoginForm login =
                new LoginForm();

            login.Show();

            Close();
        }

        private void labelTotalPrice_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}