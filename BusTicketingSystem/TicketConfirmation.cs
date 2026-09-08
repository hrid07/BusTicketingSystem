using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class TicketConfirmation : Form
    {
        private readonly int bookingId;
        private readonly int userId;

        private PrintDocument printDocument =
            new PrintDocument();

        public TicketConfirmation(int bookingId, int userId)
        {
            InitializeComponent();

            this.bookingId = bookingId;
            this.userId = userId;

            button1.Click += button1_Click;
            button2.Click += button2_Click;

            printDocument.PrintPage +=
                printDocument_PrintPage;

            LoadTicket();
        }

        // =========================
        // LOAD TICKET
        // =========================

        private void LoadTicket()
        {
            try
            {
                string query = @"
                    SELECT
                        b.BookingID,
                        b.PNR,
                        b.SeatNumbers,
                        b.TotalAmount,
                        u.FullName AS PassengerName,
                        s.BusName,
                        s.Source,
                        s.Destination,
                        s.DepartureTime,
                        s.Fare
                    FROM Bookings b
                    LEFT JOIN Users u
                        ON b.UserID = u.UserID
                    INNER JOIN Schedules s
                        ON b.ScheduleID = s.ScheduleID
                    WHERE b.BookingID = @BookingID";

                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand(query, con))
                {
                    cmd.Parameters.Add(
                        "@BookingID",
                        SqlDbType.Int).Value =
                        bookingId;

                    con.Open();

                    using (SqlDataReader reader =
                           cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show(
                                "Ticket information could not be found.",
                                "Ticket Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            Close();
                            return;
                        }

                        string passengerName =
                            reader["PassengerName"] == DBNull.Value
                            ? "Guest"
                            : reader["PassengerName"].ToString();

                        string pnr =
                            reader["PNR"].ToString();

                        string seats =
                            reader["SeatNumbers"].ToString();

                        string busName =
                            reader["BusName"].ToString();

                        string source =
                            reader["Source"].ToString();

                        string destination =
                            reader["Destination"].ToString();

                        DateTime departure =
                            Convert.ToDateTime(
                                reader["DepartureTime"]);

                        decimal fare =
                            Convert.ToDecimal(
                                reader["Fare"]);

                        decimal total =
                            Convert.ToDecimal(
                                reader["TotalAmount"]);

                        int seatCount = 0;

                        if (!string.IsNullOrWhiteSpace(seats))
                        {
                            seatCount =
                                seats.Split(
                                    new char[] { ',' },
                                    StringSplitOptions.RemoveEmptyEntries
                                ).Length;
                        }

                        // Passenger
                        label1.Text =
                            "Passenger Name: " +
                            passengerName;

                        // Trip
                        label2.Text =
                            "Trip Details: " +
                            source +
                            " → " +
                            destination;

                        // Time
                        label3.Text =
                            "Time: " +
                            departure.ToString("hh:mm tt");

                        // Route
                        label4.Text =
                            "Route: " +
                            source +
                            " → " +
                            destination;

                        // Date
                        label5.Text =
                            "Date: " +
                            departure.ToString("dd MMM yyyy");

                        // Seats
                        label6.Text =
                            "Seat NO: " +
                            seats;

                        // Bus
                        label7.Text =
                            "Bus Name: " +
                            busName;

                        // Number of seats
                        label8.Text =
                            "NO of seats: " +
                            seatCount;

                        // Fare per seat
                        label9.Text =
                            "Fare: " +
                            fare.ToString("0") +
                            " BDT";

                        // Cost
                        label10.Text =
                            "Cost: " +
                            (fare * seatCount).ToString("0") +
                            " BDT";

                        // Total
                        label11.Text =
                            "Total: " +
                            total.ToString("0.00") +
                            " BDT";

                        // Show PNR in the title area
                        label13.Text =
                            "INVOICE   |   PNR: " +
                            pnr;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error while loading ticket:\n\n" +
                    ex.Message,
                    "Ticket Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load ticket:\n\n" +
                    ex.Message,
                    "Ticket Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // PRINT TICKET
        // =========================

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                PrintDialog printDialog =
                    new PrintDialog();

                printDialog.Document =
                    printDocument;

                if (printDialog.ShowDialog() ==
                    DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to print ticket:\n\n" +
                    ex.Message,
                    "Print Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // PRINT PAGE
        // =========================

        private void printDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            Bitmap ticketImage =
                new Bitmap(
                    panel1.Width,
                    panel1.Height);

            panel1.DrawToBitmap(
                ticketImage,
                new Rectangle(
                    0,
                    0,
                    panel1.Width,
                    panel1.Height));

            float pageWidth =
                e.PageBounds.Width;

            float pageHeight =
                e.PageBounds.Height;

            float scaleX =
                pageWidth / ticketImage.Width;

            float scaleY =
                pageHeight / ticketImage.Height;

            float scale =
                Math.Min(scaleX, scaleY) * 0.85f;

            int width =
                (int)(ticketImage.Width * scale);

            int height =
                (int)(ticketImage.Height * scale);

            int x =
                (e.PageBounds.Width - width) / 2;

            int y =
                (e.PageBounds.Height - height) / 2;

            e.Graphics.DrawImage(
                ticketImage,
                new Rectangle(x, y, width, height));

            ticketImage.Dispose();
        }

        // =========================
        // BACK TO DASHBOARD
        // =========================

        private void button2_Click(
            object sender,
            EventArgs e)
        {
            Dashboard dashboard =
                new Dashboard(userId);

            dashboard.Show();

            Close();
        }

        private void label12_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}