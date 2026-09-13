
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class AvailableJourney : Form
    {
        private readonly int userId;

        private readonly string searchFrom;
        private readonly string searchTo;
        private readonly DateTime searchDate;

        private readonly bool isSearch;

        private bool isLoading = false;

        // Normal constructor
        public AvailableJourney(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            WireEvents();
        }

        // Constructor when coming from another search form
        public AvailableJourney(
            string from,
            string to,
            DateTime date,
            int userId)
        {
            InitializeComponent();

            this.userId = userId;

            searchFrom = from;
            searchTo = to;
            searchDate = date.Date;

            isSearch = true;

            WireEvents();
        }

        // Connect form controls
        private void WireEvents()
        {
            buttonLogout.Click -= buttonLogout_Click;
            buttonLogout.Click += buttonLogout_Click;

            dataGridView1.CellContentClick -=
                dataGridView1_CellContentClick;

            dataGridView1.CellContentClick +=
                dataGridView1_CellContentClick;

            comboBox1.SelectedIndexChanged -=
                comboBox1_SelectedIndexChanged;

            comboBox1.SelectedIndexChanged +=
                comboBox1_SelectedIndexChanged;

            comboBox2.SelectedIndexChanged -=
                SearchChanged;

            comboBox2.SelectedIndexChanged +=
                SearchChanged;

            dateTimePicker1.ValueChanged -=
                SearchChanged;

            dateTimePicker1.ValueChanged +=
                SearchChanged;
        }

        // FORM LOAD
        private void AvailableJourney_Load_1(
            object sender,
            EventArgs e)
        {
            isLoading = true;

            try
            {
                // Allow booking from today up to 3 days
                dateTimePicker1.MinDate =
                    DateTime.Today;

                dateTimePicker1.MaxDate =
                    DateTime.Today.AddDays(3);

                if (isSearch)
                {
                    DateTime selectedDate =
                        searchDate;

                    if (selectedDate < DateTime.Today)
                        selectedDate = DateTime.Today;

                    if (selectedDate >
                        DateTime.Today.AddDays(3))
                    {
                        selectedDate =
                            DateTime.Today.AddDays(3);
                    }

                    dateTimePicker1.Value =
                        selectedDate;
                }
                else
                {
                    dateTimePicker1.Value =
                        DateTime.Today;
                }

                LoadRoutes();

                if (isSearch)
                {
                    SetComboBoxValue(
                        comboBox1,
                        searchFrom);

                    LoadDestinations();

                    SetComboBoxValue(
                        comboBox2,
                        searchTo);
                }
            }
            finally
            {
                isLoading = false;
            }

            // Search only if both locations selected
            if (comboBox1.SelectedIndex != -1 &&
                comboBox2.SelectedIndex != -1)
            {
                LoadJourneys();
            }
        }

        // LOAD ROUTES
        private void LoadRoutes()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            // Only these locations are allowed
            comboBox1.Items.Add("Dhaka");
            comboBox1.Items.Add("Chittagong");
            comboBox1.Items.Add("Sylhet");
            comboBox1.Items.Add("Cox's Bazar");

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            comboBox2.Enabled = false;
        }

        // WHEN FROM CHANGES
        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (isLoading)
                return;

            LoadDestinations();
        }

        // LOAD VALID DESTINATIONS
        private void LoadDestinations()
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedIndex == -1)
            {
                comboBox2.Enabled = false;
                return;
            }

            string from =
                comboBox1.Text.Trim();

            if (from.Equals(
                    "Dhaka",
                    StringComparison.OrdinalIgnoreCase))
            {
                comboBox2.Items.Add("Chittagong");
                comboBox2.Items.Add("Sylhet");
                comboBox2.Items.Add("Cox's Bazar");
            }
            else if (
                from.Equals(
                    "Chittagong",
                    StringComparison.OrdinalIgnoreCase) ||

                from.Equals(
                    "Sylhet",
                    StringComparison.OrdinalIgnoreCase) ||

                from.Equals(
                    "Cox's Bazar",
                    StringComparison.OrdinalIgnoreCase))
            {
                comboBox2.Items.Add("Dhaka");
            }

            comboBox2.SelectedIndex = -1;
            comboBox2.Enabled = true;

            dataGridView1.Rows.Clear();
        }

        // SET COMBOBOX VALUE
        private void SetComboBoxValue(
            ComboBox comboBox,
            string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return;

            int index =
                comboBox.FindStringExact(value);

            if (index >= 0)
            {
                comboBox.SelectedIndex = index;
            }
        }

        // SEARCH WHEN TO OR DATE CHANGES
        private void SearchChanged(
            object sender,
            EventArgs e)
        {
            if (isLoading)
                return;

            if (!IsHandleCreated)
                return;

            if (comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1)
            {
                dataGridView1.Rows.Clear();
                return;
            }

            LoadJourneys();
        }

        // LOAD JOURNEYS FROM DATABASE
        private void LoadJourneys()
        {
            if (isLoading)
                return;

            try
            {
                if (comboBox1.SelectedIndex == -1 ||
                    comboBox2.SelectedIndex == -1)
                {
                    return;
                }

                DateTime travelDate =
                    dateTimePicker1.Value.Date;

                // Booking date validation
                if (travelDate < DateTime.Today ||
                    travelDate > DateTime.Today.AddDays(3))
                {
                    MessageBox.Show(
                        "Advance booking is allowed only " +
                        "from today up to the next 3 days.",
                        "Invalid Travel Date",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string from =
                    comboBox1.Text.Trim();

                string to =
                    comboBox2.Text.Trim();

                // Validate allowed routes
                bool validRoute = false;

                if (from.Equals(
                        "Dhaka",
                        StringComparison.OrdinalIgnoreCase))
                {
                    validRoute =
                        to.Equals(
                            "Chittagong",
                            StringComparison.OrdinalIgnoreCase) ||

                        to.Equals(
                            "Sylhet",
                            StringComparison.OrdinalIgnoreCase) ||

                        to.Equals(
                            "Cox's Bazar",
                            StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    validRoute =
                        to.Equals(
                            "Dhaka",
                            StringComparison.OrdinalIgnoreCase);
                }

                if (!validRoute)
                {
                    MessageBox.Show(
                        "This route is not available.",
                        "Invalid Route",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DataTable table =
                    new DataTable();

                using (SqlConnection con =
                    DBConnection.GetConnection())

                using (SqlCommand cmd =
                    new SqlCommand(
                        "sp_SearchSchedules",
                        con))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.Parameters.Add(
                        "@Source",
                        SqlDbType.VarChar,
                        50).Value = from;

                    cmd.Parameters.Add(
                        "@Destination",
                        SqlDbType.VarChar,
                        50).Value = to;

                    cmd.Parameters.Add(
                        "@TravelDate",
                        SqlDbType.Date).Value =
                        travelDate;

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }

                DisplayJourneys(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load journeys:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // DISPLAY JOURNEYS IN DATAGRIDVIEW
        private void DisplayJourneys(
            DataTable table)
        {
            dataGridView1.Rows.Clear();

            foreach (DataRow row in table.Rows)
            {
                int index =
                    dataGridView1.Rows.Add();

                dataGridView1.Rows[index]
                    .Cells["Column1"].Value =
                    row["ScheduleID"];

                dataGridView1.Rows[index]
                    .Cells["Column2"].Value =
                    row["BusName"];

                dataGridView1.Rows[index]
                    .Cells["Column3"].Value =
                    row["BusType"];

                dataGridView1.Rows[index]
                    .Cells["Column4"].Value =
                    FormatLocation(
                        row["Source"].ToString());

                dataGridView1.Rows[index]
                    .Cells["Column5"].Value =
                    FormatLocation(
                        row["Destination"].ToString());

                DateTime departure =
                    Convert.ToDateTime(
                        row["DepartureTime"]);

                DateTime arrival =
                    Convert.ToDateTime(
                        row["ArrivalTime"]);

                dataGridView1.Rows[index]
                    .Cells["Column6"].Value =
                    departure.ToString("hh:mm tt");

                dataGridView1.Rows[index]
                    .Cells["Column7"].Value =
                    arrival.ToString("hh:mm tt");

                dataGridView1.Rows[index]
                    .Cells["Column8"].Value =
                    row["AvailableSeats"];

                dataGridView1.Rows[index]
                    .Cells["Column9"].Value =
                    "৳" +
                    Convert.ToDecimal(
                        row["Fare"]).ToString("0");

                dataGridView1.Rows[index]
                    .Cells["Column10"].Value =
                    "SELECT";

                // Store ScheduleID for seat selection
                dataGridView1.Rows[index].Tag =
                    Convert.ToInt32(
                        row["ScheduleID"]);
            }

            if (table.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No journeys found for the selected " +
                    "route and date.",
                    "Available Journeys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // FORMAT LOCATION NAMES
        private string FormatLocation(
            string location)
        {
            if (string.IsNullOrWhiteSpace(location))
                return location;

            if (location.Equals(
                    "DHAKA",
                    StringComparison.OrdinalIgnoreCase))
                return "Dhaka";

            if (location.Equals(
                    "CHITTAGONG",
                    StringComparison.OrdinalIgnoreCase))
                return "Chittagong";

            if (location.Equals(
                    "SYLHET",
                    StringComparison.OrdinalIgnoreCase))
                return "Sylhet";

            if (location.Equals(
                    "COX'S BAZAR",
                    StringComparison.OrdinalIgnoreCase))
                return "Cox's Bazar";

            return location;
        }

        // SELECT SEAT BUTTON
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex !=
                dataGridView1.Columns["Column10"].Index)
            {
                return;
            }

            DataGridViewRow row =
                dataGridView1.Rows[e.RowIndex];

            if (row.Tag == null)
                return;

            int scheduleId =
                Convert.ToInt32(row.Tag);

            int availableSeats =
                Convert.ToInt32(
                    row.Cells["Column8"].Value);

            if (availableSeats <= 0)
            {
                MessageBox.Show(
                    "No seats are available for this journey.",
                    "Journey Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            SelectSeat seat =
                new SelectSeat(
                    scheduleId,
                    userId);

            seat.ShowDialog();

            // Refresh available seats after booking
            LoadJourneys();
        }

        // BACK BUTTON
        private void buttonBack_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        // LOGOUT BUTTON
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

            LoginForm login =
                new LoginForm();

            login.Show();

            Hide();
        }

        private void panel3_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}