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

        public AvailableJourney(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            WireEvents();
        }

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

        private void WireEvents()
        {
            
            buttonLogout.Click += buttonLogout_Click;

            dataGridView1.CellContentClick +=
                dataGridView1_CellContentClick;

            comboBox1.SelectedIndexChanged +=
                SearchChanged;

            comboBox2.SelectedIndexChanged +=
                SearchChanged;

            dateTimePicker1.ValueChanged +=
                SearchChanged;
        }



        private void AvailableJourney_Load_1(
            object sender,
            EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;

            if (isSearch)
            {
                dateTimePicker1.Value = searchDate;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Today;
            }

            LoadRoutes();

            if (isSearch)
            {
                comboBox1.Text = searchFrom;
                comboBox2.Text = searchTo;
            }

            LoadJourneys();
        }


        private void LoadRoutes()
        {
            try
            {
                using (SqlConnection con =
                    DBConnection.GetConnection())
                using (SqlCommand cmd =
                    new SqlCommand(
                        @"SELECT DISTINCT Source, Destination
                          FROM Routes
                          ORDER BY Source, Destination",
                        con))
                {
                    con.Open();

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear();
                        comboBox2.Items.Clear();

                        while (reader.Read())
                        {
                            string source =
                                reader["Source"].ToString();

                            string destination =
                                reader["Destination"].ToString();

                            if (!comboBox1.Items.Contains(source))
                            {
                                comboBox1.Items.Add(source);
                            }

                            if (!comboBox2.Items.Contains(destination))
                            {
                                comboBox2.Items.Add(destination);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load routes:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

      

        private void SearchChanged(
            object sender,
            EventArgs e)
        {
            if (!IsHandleCreated)
                return;

            if (comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1)
            {
                return;
            }

            LoadJourneys();
        }

        private void LoadJourneys()
        {
            try
            {
                DataTable table = new DataTable();

                using (SqlConnection con =
                    DBConnection.GetConnection())
                using (SqlCommand cmd =
                    new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    string from =
                        comboBox1.Text.Trim();

                    string to =
                        comboBox2.Text.Trim();

                    if (!string.IsNullOrWhiteSpace(from) &&
                        !string.IsNullOrWhiteSpace(to))
                    {
                        cmd.CommandText =
                            "sp_SearchSchedules";

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
                            dateTimePicker1.Value.Date;
                    }
                    else
                    {
                        cmd.CommandText =
                            "sp_GetAllSchedules";
                    }

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

        private void DisplayJourneys(DataTable table)
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
                    row["Source"];

                dataGridView1.Rows[index]
                    .Cells["Column5"].Value =
                    row["Destination"];

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

                dataGridView1.Rows[index].Tag =
                    Convert.ToInt32(
                        row["ScheduleID"]);
            }

            if (table.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No journeys found for the selected search.",
                    "Available Journeys",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

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

           
            LoadJourneys();
        }



        private void buttonBack_Click(
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

            LoginForm login =
                new LoginForm();

            login.Show();

            Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}