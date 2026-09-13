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

        private decimal farePerSeat;

        private readonly List<string> selectedSeats =
            new List<string>();

        private readonly Dictionary<string, Button> seatButtons =
            new Dictionary<string, Button>(
                StringComparer.OrdinalIgnoreCase);

        private static readonly Color AvailableColor =
            Color.DarkSeaGreen;

        private static readonly Color BookedColor =
            Color.DimGray;

        private static readonly Color SelectedColor =
            Color.MidnightBlue;


        public SelectSeat(int scheduleId)
            : this(scheduleId, 0)
        {
        }


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
        }


        // =========================================
        // FORM LOAD
        // =========================================

        private void SelectSeat_Load(
            object sender,
            EventArgs e)
        {
            LoadSchedule();
            LoadSeats();
        }


        // =========================================
        // FIND SEAT BUTTONS
        // =========================================

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

                if (string.IsNullOrEmpty(seat))
                    continue;

                seatButtons[seat] = button;

                button.Click -= SeatButton_Click;
                button.Click += SeatButton_Click;
            }
        }


        // =========================================
        // LOAD JOURNEY
        // =========================================

        private void LoadSchedule()
        {
            try
            {
                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand(
                           "sp_GetAllSchedules",
                           con))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    DataTable table =
                        new DataTable();

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }

                    DataRow[] rows =
                        table.Select(
                            "ScheduleID = " +
                            scheduleId);

                    if (rows.Length == 0)
                    {
                        MessageBox.Show(
                            "The selected journey could not be found.",
                            "Journey Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        Close();
                        return;
                    }

                    DataRow row = rows[0];

                    farePerSeat =
                        Convert.ToDecimal(
                            row["Fare"]);

                    labelBus.Text =
                        row["BusName"] +
                        " (" +
                        row["BusType"] +
                        ")";

                    labelRoute.Text =
                        row["Source"] +
                        " → " +
                        row["Destination"];

                    DateTime departure =
                        Convert.ToDateTime(
                            row["DepartureTime"]);

                    labelDataTime.Text =
                        departure.ToString(
                            "dd MMM yyyy, hh:mm tt");

                    labelFare.Text =
                        "Base Fare: " +
                        farePerSeat.ToString("0") +
                        " BDT";

                    UpdateTotal();
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
        }


        // =========================================
        // LOAD SEATS
        // =========================================

        private void LoadSeats()
        {
            selectedSeats.Clear();

            try
            {
                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand(
                           "sp_GetSeatsForSchedule",
                           con))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.Add(
                        "@ScheduleID",
                        SqlDbType.Int).Value =
                        scheduleId;

                    con.Open();

                    Dictionary<string, string>
                        statuses =
                        new Dictionary<string, string>(
                            StringComparer.OrdinalIgnoreCase);

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

                            statuses[seat] = status;
                        }
                    }

                    foreach (var item in seatButtons)
                    {
                        string seat = item.Key;
                        Button button = item.Value;

                        bool booked =
                            statuses.ContainsKey(seat) &&
                            statuses[seat].Equals(
                                "Booked",
                                StringComparison.OrdinalIgnoreCase);

                        if (booked)
                        {
                            button.BackColor =
                                BookedColor;

                            button.ForeColor =
                                Color.White;

                            button.Enabled = false;
                        }
                        else
                        {
                            button.BackColor =
                                AvailableColor;

                            button.ForeColor =
                                Color.Black;

                            button.Enabled = true;
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


        // =========================================
        // SELECT / UNSELECT SEAT
        // =========================================

        private void SeatButton_Click(
            object sender,
            EventArgs e)
        {
            Button button =
                sender as Button;

            if (button == null ||
                !button.Enabled)
            {
                return;
            }

            string seat =
                button.Text.Trim().ToUpper();

            if (selectedSeats.Contains(seat))
            {
                // UNSELECT
                selectedSeats.Remove(seat);

                button.BackColor =
                    AvailableColor;

                button.ForeColor =
                    Color.Black;
            }
            else
            {
                // SELECT
                selectedSeats.Add(seat);

                button.BackColor =
                    SelectedColor;

                button.ForeColor =
                    Color.White;
            }

            UpdateTotal();
        }


        // =========================================
        // TOTAL PRICE
        // =========================================

        private void UpdateTotal()
        {
            decimal total =
                selectedSeats.Count *
                farePerSeat;

            string seatText =
                selectedSeats.Count == 1
                ? "seat"
                : "seats";

            labelTotalPrice.Text =
                "TOTAL PRICE: " +
                total.ToString("0") +
                " BDT (" +
                selectedSeats.Count +
                " " +
                seatText +
                ")";
        }


      

        private void buttonConfirmbooking_Click(
            object sender,
            EventArgs e)
        {
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
                        userId == 0
                        ? (object)DBNull.Value
                        : userId;

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
                            "One or more selected seats are no longer available.",
                            "Booking Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        LoadSeats();
                        return;
                    }

                    int id =
                        Convert.ToInt32(
                            bookingId.Value);

                    decimal total =
                        selectedSeats.Count *
                        farePerSeat;

                    Payment payment =
                        new Payment(
                            id,
                            userId,
                            total);

                    payment.Show();

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


       

        private void labelTotalPrice_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}