using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace BusTicketingSystem
{
    public partial class JourneyManagement : Form
    {
        int scheduleID = 0;

        string connectionString =
            ConfigurationManager.ConnectionStrings["BusDB"].ConnectionString;

        public JourneyManagement()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;

            dgvJourneys.CellClick += dgvJourneys_CellClick;
        }

        private void JourneyManagement_Load(object sender, EventArgs e)
        {
            LoadBuses();
            LoadRoutes();
            LoadJourneys();

            dtDeparture.Format = DateTimePickerFormat.Custom;
            dtDeparture.CustomFormat = "dd/MM/yyyy hh:mm tt";

            dtArrival.Format = DateTimePickerFormat.Custom;
            dtArrival.CustomFormat = "dd/MM/yyyy hh:mm tt";
        }

        // =========================
        // LOAD BUSES
        // =========================
        private void LoadBuses()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query = "SELECT BusID, BusName FROM Buses";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbBus.DataSource = dt;
                cmbBus.DisplayMember = "BusName";
                cmbBus.ValueMember = "BusID";
                cmbBus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading buses: " + ex.Message);
            }
        }

        // =========================
        // LOAD ROUTES
        // =========================
        private void LoadRoutes()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query = "SELECT RouteID, Source, Destination FROM Routes";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSource.DataSource = dt.Copy();
                cmbSource.DisplayMember = "Source";
                cmbSource.ValueMember = "RouteID";
                cmbSource.SelectedIndex = -1;

                cmbDestination.DataSource = dt.Copy();
                cmbDestination.DisplayMember = "Destination";
                cmbDestination.ValueMember = "RouteID";
                cmbDestination.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading routes: " + ex.Message);
            }
        }

        // =========================
        // LOAD JOURNEYS
        // =========================
        private void LoadJourneys()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                string query = @"
                    SELECT 
                        s.ScheduleID,
                        b.BusName,
                        b.BusType,
                        r.Source,
                        r.Destination,
                        s.DepartureTime,
                        s.ArrivalTime,
                        s.Fare,
                        s.AvailableSeats
                    FROM Schedules s
                    INNER JOIN Buses b ON s.BusID = b.BusID
                    INNER JOIN Routes r ON s.RouteID = r.RouteID
                    ORDER BY s.DepartureTime";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvJourneys.DataSource = dt;

                if (dgvJourneys.Columns.Contains("ScheduleID"))
                    dgvJourneys.Columns["ScheduleID"].HeaderText = "ID";

                if (dgvJourneys.Columns.Contains("BusName"))
                    dgvJourneys.Columns["BusName"].HeaderText = "Bus Name";

                if (dgvJourneys.Columns.Contains("BusType"))
                    dgvJourneys.Columns["BusType"].HeaderText = "Bus Type";

                if (dgvJourneys.Columns.Contains("Source"))
                    dgvJourneys.Columns["Source"].HeaderText = "From";

                if (dgvJourneys.Columns.Contains("Destination"))
                    dgvJourneys.Columns["Destination"].HeaderText = "To";

                if (dgvJourneys.Columns.Contains("DepartureTime"))
                    dgvJourneys.Columns["DepartureTime"].HeaderText = "Departure";

                if (dgvJourneys.Columns.Contains("ArrivalTime"))
                    dgvJourneys.Columns["ArrivalTime"].HeaderText = "Arrival";

                if (dgvJourneys.Columns.Contains("Fare"))
                    dgvJourneys.Columns["Fare"].HeaderText = "Fare";

                if (dgvJourneys.Columns.Contains("AvailableSeats"))
                    dgvJourneys.Columns["AvailableSeats"].HeaderText = "Available Seats";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading journeys: " + ex.Message);
            }
        }

        // =========================
        // ADD JOURNEY
        // =========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBus.SelectedIndex == -1 ||
                    cmbSource.SelectedIndex == -1 ||
                    cmbDestination.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select bus, source and destination.");
                    return;
                }

                if (cmbSource.Text == cmbDestination.Text)
                {
                    MessageBox.Show("Source and destination cannot be the same.");
                    return;
                }

                if (dtArrival.Value <= dtDeparture.Value)
                {
                    MessageBox.Show("Arrival time must be after departure time.");
                    return;
                }

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                // Find RouteID
                string routeQuery = @"
                    SELECT RouteID 
                    FROM Routes 
                    WHERE Source = @Source AND Destination = @Destination";

                SqlCommand routeCmd = new SqlCommand(routeQuery, con);

                routeCmd.Parameters.AddWithValue("@Source", cmbSource.Text);
                routeCmd.Parameters.AddWithValue("@Destination", cmbDestination.Text);

                object routeResult = routeCmd.ExecuteScalar();

                if (routeResult == null)
                {
                    MessageBox.Show("Route not found.");
                    con.Close();
                    return;
                }

                int routeID = Convert.ToInt32(routeResult);

                // Get bus seat capacity
                string seatQuery =
                    "SELECT SeatCapacity FROM Buses WHERE BusID = @BusID";

                SqlCommand seatCmd = new SqlCommand(seatQuery, con);
                seatCmd.Parameters.AddWithValue("@BusID", cmbBus.SelectedValue);

                int seatCapacity = Convert.ToInt32(seatCmd.ExecuteScalar());

                // Add journey
                string insertQuery = @"
                    INSERT INTO Schedules
                    (BusID, RouteID, DepartureTime, ArrivalTime, Fare, AvailableSeats)
                    VALUES
                    (@BusID, @RouteID, @DepartureTime, @ArrivalTime, @Fare, @AvailableSeats);

                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@BusID", cmbBus.SelectedValue);
                cmd.Parameters.AddWithValue("@RouteID", routeID);
                cmd.Parameters.AddWithValue("@DepartureTime", dtDeparture.Value);
                cmd.Parameters.AddWithValue("@ArrivalTime", dtArrival.Value);
                cmd.Parameters.AddWithValue("@Fare", nudFare.Value);
                cmd.Parameters.AddWithValue("@AvailableSeats", seatCapacity);

                int newScheduleID = Convert.ToInt32(cmd.ExecuteScalar());

                // Generate seats for the new journey
                SqlCommand seatGenerate =
                    new SqlCommand("sp_GenerateSeatsForSchedule", con);

                seatGenerate.CommandType = CommandType.StoredProcedure;
                seatGenerate.Parameters.AddWithValue("@ScheduleID", newScheduleID);

                seatGenerate.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Journey added successfully.");

                LoadJourneys();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding journey: " + ex.Message);
            }
        }

        // =========================
        // UPDATE JOURNEY
        // =========================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (scheduleID == 0)
                {
                    MessageBox.Show("Please select a journey first.");
                    return;
                }

                if (cmbBus.SelectedIndex == -1 ||
                    cmbSource.SelectedIndex == -1 ||
                    cmbDestination.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (dtArrival.Value <= dtDeparture.Value)
                {
                    MessageBox.Show("Arrival time must be after departure time.");
                    return;
                }

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string routeQuery = @"
                    SELECT RouteID 
                    FROM Routes
                    WHERE Source = @Source AND Destination = @Destination";

                SqlCommand routeCmd = new SqlCommand(routeQuery, con);

                routeCmd.Parameters.AddWithValue("@Source", cmbSource.Text);
                routeCmd.Parameters.AddWithValue("@Destination", cmbDestination.Text);

                object result = routeCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Route not found.");
                    con.Close();
                    return;
                }

                int routeID = Convert.ToInt32(result);

                string updateQuery = @"
                    UPDATE Schedules
                    SET BusID = @BusID,
                        RouteID = @RouteID,
                        DepartureTime = @DepartureTime,
                        ArrivalTime = @ArrivalTime,
                        Fare = @Fare
                    WHERE ScheduleID = @ScheduleID";

                SqlCommand cmd = new SqlCommand(updateQuery, con);

                cmd.Parameters.AddWithValue("@BusID", cmbBus.SelectedValue);
                cmd.Parameters.AddWithValue("@RouteID", routeID);
                cmd.Parameters.AddWithValue("@DepartureTime", dtDeparture.Value);
                cmd.Parameters.AddWithValue("@ArrivalTime", dtArrival.Value);
                cmd.Parameters.AddWithValue("@Fare", nudFare.Value);
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Journey updated successfully.");

                LoadJourneys();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating journey: " + ex.Message);
            }
        }

        // =========================
        // DELETE JOURNEY
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (scheduleID == 0)
                {
                    MessageBox.Show("Please select a journey first.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this journey?",
                    "Delete Journey",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                // Check bookings first
                string bookingQuery =
                    "SELECT COUNT(*) FROM Bookings WHERE ScheduleID = @ScheduleID";

                SqlCommand bookingCmd = new SqlCommand(bookingQuery, con);
                bookingCmd.Parameters.AddWithValue("@ScheduleID", scheduleID);

                int bookingCount = Convert.ToInt32(bookingCmd.ExecuteScalar());

                if (bookingCount > 0)
                {
                    MessageBox.Show(
                        "This journey has bookings and cannot be deleted.");

                    con.Close();
                    return;
                }

                // Delete seats first
                string deleteSeats =
                    "DELETE FROM ScheduleSeats WHERE ScheduleID = @ScheduleID";

                SqlCommand seatCmd = new SqlCommand(deleteSeats, con);
                seatCmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
                seatCmd.ExecuteNonQuery();

                // Delete journey
                string deleteJourney =
                    "DELETE FROM Schedules WHERE ScheduleID = @ScheduleID";

                SqlCommand cmd = new SqlCommand(deleteJourney, con);
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Journey deleted successfully.");

                LoadJourneys();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting journey: " + ex.Message);
            }
        }

        // =========================
        // SELECT ROW
        // =========================
        private void dgvJourneys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvJourneys.Rows[e.RowIndex];

            scheduleID = Convert.ToInt32(row.Cells["ScheduleID"].Value);

            string busName = row.Cells["BusName"].Value.ToString();
            string source = row.Cells["Source"].Value.ToString();
            string destination = row.Cells["Destination"].Value.ToString();

            cmbBus.Text = busName;
            cmbSource.Text = source;
            cmbDestination.Text = destination;

            dtDeparture.Value =
                Convert.ToDateTime(row.Cells["DepartureTime"].Value);

            dtArrival.Value =
                Convert.ToDateTime(row.Cells["ArrivalTime"].Value);

            nudFare.Value =
                Convert.ToDecimal(row.Cells["Fare"].Value);
        }

        // =========================
        // CLEAR
        // =========================
        private void ClearFields()
        {
            scheduleID = 0;

            cmbBus.SelectedIndex = -1;
            cmbSource.SelectedIndex = -1;
            cmbDestination.SelectedIndex = -1;

            nudFare.Value = 0;

            dtDeparture.Value = DateTime.Now;
            dtArrival.Value = DateTime.Now.AddHours(2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Keep your automatically generated event methods
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void JMlabel1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void JMpanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}