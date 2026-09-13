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
        private readonly int userId;
        private decimal farePerSeat;

        private readonly List<string> selectedSeats =
            new List<string>();

        private readonly Dictionary<string, Button> seatButtons =
            new Dictionary<string, Button>();

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

            buttonConfirmbooking.Click +=
                buttonConfirmbooking_Click;

            buttonBack.Click +=
                buttonBack_Click;
        }

        // =========================
        // FORM LOAD
        // =========================

        private void SelectSeat_Load(object sender, EventArgs e)
        {
            LoadSchedule();
            LoadSeats();
        }

        // =========================
        // FIND SEAT BUTTONS
        // =========================

        private void FindSeatButtons()
        {
            Regex pattern =
                new Regex(@"^[A-H][1-3]$");

            foreach (Control control in GetControls(this))
            {
                if (control is Button button &&
                    pattern.IsMatch(button.Text))
                {
                    seatButtons[button.Text] = button;

                    button.Click += SeatButton_Click;
                }
            }
        }

        private IEnumerable<Control> GetControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;

                foreach (Control child in GetControls(control))
                    yield return child;
            }
        }

        // =========================
        // LOAD SCHEDULE
        // =========================

        private void LoadSchedule()
        {
            try
            {
                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand("sp_GetAllSchedules", con))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    DataTable table = new DataTable();

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }

                    DataRow[] rows =
                        table.Select(
                            "ScheduleID = " + scheduleId);

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
                        Convert.ToDecimal(row["Fare"]);

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

        // =========================
        // LOAD SEATS
        // =========================

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

                    Dictionary<string, string> statuses =
                        new Dictionary<string, string>();

                    using (SqlDataReader reader =
                           cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string seat =
                                reader["SeatNumber"].ToString();

                            string status =
                                reader["Status"].ToString();

                            statuses[seat] = status;
                        }
                    }

                    foreach (var item in seatButtons)
                    {
                        string seat = item.Key;
                        Button button = item.Value;

                        bool booked =
                            statuses.ContainsKey(seat) &&
                            statuses[seat]
                                .Equals(
                                    "Booked",
                                    StringComparison.OrdinalIgnoreCase);

                        button.BackColor =
                            booked
                            ? BookedColor
                            : AvailableColor;

                        button.Enabled = !booked;
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

        // =========================
        // SELECT / UNSELECT SEAT
        // =========================

        private void SeatButton_Click(
            object sender,
            EventArgs e)
        {
            Button button = (Button)sender;

            string seat = button.Text;

            if (selectedSeats.Contains(seat))
            {
                selectedSeats.Remove(seat);

                button.BackColor =
                    AvailableColor;
            }
            else
            {
                selectedSeats.Add(seat);

                button.BackColor =
                    SelectedColor;
            }

            UpdateTotal();
        }

        // =========================
        // TOTAL FARE
        // =========================

        private void UpdateTotal()
        {
            decimal total =
                selectedSeats.Count * farePerSeat;

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

        // =========================
        // CONFIRM BOOKING
        // =========================

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
                        SqlDbType.VarChar,
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

        // =========================
        // BACK
        // =========================

        private void buttonBack_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        // =========================
        // DESIGNER EVENT
        // =========================

        private void labelTotalPrice_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}