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
                b.SeatCount,
                b.TotalFare,
                b.Status,
                u.FullName AS PassengerName,
                bss.SeatNumbers,
                s.BusName,
                r.Source,
                r.Destination,
                s.DepartureTime,
                s.Fare
            FROM Bookings b
            LEFT JOIN Users u
                ON b.UserID = u.UserID
            INNER JOIN Schedules s
                ON b.ScheduleID = s.ScheduleID
            INNER JOIN Routes r
                ON s.RouteID = r.RouteID
            LEFT JOIN
            (
                SELECT
                    BookingID,
                    STRING_AGG(SeatNumber, ', ') AS SeatNumbers
                FROM BookingSeats
                GROUP BY BookingID
            ) bss
                ON b.BookingID = bss.BookingID
            WHERE b.BookingID = @BookingID
              AND (@UserID = 0 OR b.UserID = @UserID)
              AND b.Status = 'Confirmed'";

                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand(query, con))
                {
                    cmd.Parameters.Add(
                        "@BookingID",
                        SqlDbType.Int).Value = bookingId;

                    cmd.Parameters.Add(
                        "@UserID",
                        SqlDbType.Int).Value = userId;

                    con.Open();

                    using (SqlDataReader reader =
                           cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show(
                                "Confirmed ticket information could not be found.",
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
                            reader["SeatNumbers"] == DBNull.Value
                            ? ""
                            : reader["SeatNumbers"].ToString();

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
                                reader["TotalFare"]);

                        int seatCount =
                            Convert.ToInt32(
                                reader["SeatCount"]);

                        label1.Text =
                            "Passenger Name: " +
                            passengerName;

                        label2.Text =
                            "Trip Details: " +
                            source +
                            " → " +
                            destination;

                        label3.Text =
                            "Time: " +
                            departure.ToString("hh:mm tt");

                        label4.Text =
                            "Route: " +
                            source +
                            " → " +
                            destination;

                        label5.Text =
                            "Date: " +
                            departure.ToString("dd MMM yyyy");

                        label6.Text =
                            "Seat NO: " +
                            seats;

                        label7.Text =
                            "Bus Name: " +
                            busName;

                        label8.Text =
                            "NO of seats: " +
                            seatCount;

                        label9.Text =
                            "Fare: " +
                            fare.ToString("0") +
                            " BDT";

                        label10.Text =
                            "Cost: " +
                            total.ToString("0") +
                            " BDT";

                        label11.Text =
                            "Total: " +
                            total.ToString("0.00") +
                            " BDT";

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
            Close();
        }

        private void label12_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}