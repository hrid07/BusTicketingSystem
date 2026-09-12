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

        private readonly PrintDocument printDocument =
            new PrintDocument();

        public TicketConfirmation(int bookingId, int userId)
        {
            InitializeComponent();

            this.bookingId = bookingId;
            this.userId = userId;

            printDocument.PrintPage +=
                printDocument_PrintPage;

            LoadTicket();
        }

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

                        bus.BusName AS BusName,

                        r.Source AS Source,
                        r.Destination AS Destination,

                        s.DepartureTime AS DepartureTime,
                        s.Fare AS Fare

                    FROM Bookings b

                    LEFT JOIN Users u
                        ON b.UserID = u.UserID

                    INNER JOIN Schedules s
                        ON b.ScheduleID = s.ScheduleID

                    INNER JOIN Buses bus
                        ON s.BusID = bus.BusID

                    INNER JOIN Routes r
                        ON s.RouteID = r.RouteID

                    LEFT JOIN
                    (
                        SELECT
                            BookingID,
                            STRING_AGG(
                                CONVERT(varchar(max), SeatNumber),
                                ', '
                            ) AS SeatNumbers
                        FROM BookingSeats
                        GROUP BY BookingID
                    ) bss
                        ON b.BookingID = bss.BookingID

                    WHERE b.BookingID = @BookingID
                      AND (@UserID = 0 OR b.UserID = @UserID)
                      AND b.Status = 'Confirmed';
                ";

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

                            return;
                        }

                        string passengerName =
                            GetString(reader, "PassengerName", "Guest");

                        string pnr =
                            GetString(reader, "PNR", "");

                        string seats =
                            GetString(reader, "SeatNumbers", "Not assigned");

                        string busName =
                            GetString(reader, "BusName", "Unknown");

                        string source =
                            GetString(reader, "Source", "");

                        string destination =
                            GetString(reader, "Destination", "");

                        DateTime departure =
                            GetDateTime(reader, "DepartureTime");

                        decimal fare =
                            GetDecimal(reader, "Fare");

                        decimal total =
                            GetDecimal(reader, "TotalFare");

                        int seatCount =
                            GetInt(reader, "SeatCount");

                        label1.Text =
                            "Passenger Name: " + passengerName;

                        label2.Text =
                            "Trip Details: " +
                            source + " → " + destination;

                        label3.Text =
                            "Time: " +
                            departure.ToString("hh:mm tt");

                        label4.Text =
                            "Route: " +
                            source + " → " + destination;

                        label5.Text =
                            "Date: " +
                            departure.ToString("dd MMM yyyy");

                        label6.Text =
                            "Seat NO: " + seats;

                        label7.Text =
                            "Bus Name: " + busName;

                        label8.Text =
                            "NO of seats: " + seatCount;

                        label9.Text =
                            "Fare: " +
                            fare.ToString("0.00") +
                            " BDT";

                        label10.Text =
                            "Cost: " +
                            total.ToString("0.00") +
                            " BDT";

                        label11.Text =
                            "Total: " +
                            total.ToString("0.00") +
                            " BDT";

                        label13.Text =
                            "INVOICE   |   PNR: " + pnr;
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

        private string GetString(
            SqlDataReader reader,
            string columnName,
            string defaultValue)
        {
            if (reader[columnName] == DBNull.Value)
            {
                return defaultValue;
            }

            return reader[columnName].ToString();
        }

        private DateTime GetDateTime(
            SqlDataReader reader,
            string columnName)
        {
            if (reader[columnName] == DBNull.Value)
            {
                return DateTime.MinValue;
            }

            return Convert.ToDateTime(
                reader[columnName]);
        }

        private decimal GetDecimal(
            SqlDataReader reader,
            string columnName)
        {
            if (reader[columnName] == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToDecimal(
                reader[columnName]);
        }

        private int GetInt(
            SqlDataReader reader,
            string columnName)
        {
            if (reader[columnName] == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(
                reader[columnName]);
        }

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                using (PrintDialog printDialog =
                    new PrintDialog())
                {
                    printDialog.Document =
                        printDocument;

                    if (printDialog.ShowDialog() ==
                        DialogResult.OK)
                    {
                        printDocument.Print();
                    }
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

        private void printDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            using (Bitmap ticketImage =
                new Bitmap(
                    panel1.Width,
                    panel1.Height))
            {
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
                    new Rectangle(
                        x,
                        y,
                        width,
                        height));
            }
        }

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