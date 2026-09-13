using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class BusManagement : Form
    {
        private int selectedBusId = 0;

        public BusManagement()
        {
            InitializeComponent();

            WireEvents();
        }

        private void WireEvents()
        {
            btnAddNewBus.Click += btnAddNewBus_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnClose.Click += btnClose_Click;

            dgvBuses.CellContentClick +=
                dgvBuses_CellContentClick;

            btnBuses.Click += btnBuses_Click;

           
            btnRoutes.Text = "JOURNEYS";
            btnRoutes.Click += btnRoutes_Click;

            btnBookings.Click += btnBookings_Click;
            
        }

        private void BusManagement_Load(
            object sender,
            EventArgs e)
        {
            LoadBuses();
            HideEditor();
        }

       

        private void LoadBuses()
        {
            try
            {
                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand(
                           "SELECT BusID, BusName, BusType, " +
                           "SeatCapacity " +
                           "FROM Buses " +
                           "ORDER BY BusID",
                           con))
                {
                    con.Open();

                    using (SqlDataReader reader =
                           cmd.ExecuteReader())
                    {
                        dgvBuses.Rows.Clear();

                        while (reader.Read())
                        {
                            int row =
                                dgvBuses.Rows.Add();

                            dgvBuses.Rows[row]
                                .Cells["colBusID"]
                                .Value =
                                reader["BusID"];

                            dgvBuses.Rows[row]
                                .Cells["colBusName"]
                                .Value =
                                reader["BusName"];

                            dgvBuses.Rows[row]
                                .Cells["colFare"]
                                .Value =
                                reader["SeatCapacity"];

                            dgvBuses.Rows[row]
                                .Cells["colStatus"]
                                .Value =
                                reader["BusType"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load buses.\n\n" +
                    ex.Message,
                    "Bus Management",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnAddNewBus_Click(
            object sender,
            EventArgs e)
        {
            selectedBusId = 0;

            txtBusName.Clear();
            
            cmbRoute.SelectedIndex = -1;
            nudRouteNumber.Value = 24;

            txtAccountNumber.Clear();
            txtTransactionPIN.Clear();

            lblAddEditTitle.Text = "ADD BUS";

            ShowEditor();
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            string busName =
                txtBusName.Text.Trim();

            string busType =
                cmbRoute.Text.Trim();

            int seatCapacity =
                Convert.ToInt32(nudRouteNumber.Value);

            if (string.IsNullOrWhiteSpace(busName))
            {
                MessageBox.Show(
                    "Enter bus name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBusName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(busType))
            {
                MessageBox.Show(
                    "Select bus type.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (seatCapacity <= 0)
            {
                MessageBox.Show(
                    "Seat capacity must be greater than 0.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection con =
                       DBConnection.GetConnection())
                {
                    con.Open();

                    if (selectedBusId == 0)
                    {
                        string sql = @"
                            INSERT INTO Buses
                            (
                                BusNumber,
                                BusName,
                                BusType,
                                SeatCapacity
                            )
                            VALUES
                            (
                                @BusNumber,
                                @BusName,
                                @BusType,
                                @SeatCapacity
                            )";

                        using (SqlCommand cmd =
                               new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add(
                                "@BusNumber",
                                SqlDbType.VarChar,
                                50).Value =
                                "BUS-" +
                                DateTime.Now.ToString(
                                    "yyyyMMddHHmmss");

                            cmd.Parameters.Add(
                                "@BusName",
                                SqlDbType.VarChar,
                                100).Value =
                                busName;

                            cmd.Parameters.Add(
                                "@BusType",
                                SqlDbType.VarChar,
                                50).Value =
                                busType;

                            cmd.Parameters.Add(
                                "@SeatCapacity",
                                SqlDbType.Int).Value =
                                seatCapacity;

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            "Bus added successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        string sql = @"
                            UPDATE Buses
                            SET
                                BusName = @BusName,
                                BusType = @BusType,
                                SeatCapacity = @SeatCapacity
                            WHERE BusID = @BusID";

                        using (SqlCommand cmd =
                               new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add(
                                "@BusID",
                                SqlDbType.Int).Value =
                                selectedBusId;

                            cmd.Parameters.Add(
                                "@BusName",
                                SqlDbType.VarChar,
                                100).Value =
                                busName;

                            cmd.Parameters.Add(
                                "@BusType",
                                SqlDbType.VarChar,
                                50).Value =
                                busType;

                            cmd.Parameters.Add(
                                "@SeatCapacity",
                                SqlDbType.Int).Value =
                                seatCapacity;

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            "Bus updated successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    LoadBuses();
                    HideEditor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save bus.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void dgvBuses_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int busId =
                Convert.ToInt32(
                    dgvBuses.Rows[e.RowIndex]
                    .Cells["colBusID"]
                    .Value);

            if (e.ColumnIndex ==
                dgvBuses.Columns["colEdit"].Index)
            {
                EditBus(busId);
            }

            if (e.ColumnIndex ==
                dgvBuses.Columns["colDelete"].Index)
            {
                DeleteBus(busId);
            }
        }

        private void EditBus(int busId)
        {
            try
            {
                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand(
                           "SELECT BusName, BusType, " +
                           "SeatCapacity " +
                           "FROM Buses " +
                           "WHERE BusID = @BusID",
                           con))
                {
                    cmd.Parameters.Add(
                        "@BusID",
                        SqlDbType.Int).Value = busId;

                    con.Open();

                    using (SqlDataReader reader =
                           cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return;

                        selectedBusId = busId;

                        txtBusName.Text =
                            reader["BusName"].ToString();

                        cmbRoute.Text =
                            reader["BusType"].ToString();

                        nudRouteNumber.Value =
                            Convert.ToDecimal(
                                reader["SeatCapacity"]);

                        lblAddEditTitle.Text =
                            "EDIT BUS";

                        ShowEditor();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteBus(int busId)
        {
            DialogResult result =
                MessageBox.Show(
                    "Delete this bus?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection con =
                       DBConnection.GetConnection())
                using (SqlCommand cmd =
                       new SqlCommand(
                           "DELETE FROM Buses " +
                           "WHERE BusID = @BusID",
                           con))
                {
                    cmd.Parameters.Add(
                        "@BusID",
                        SqlDbType.Int).Value = busId;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadBuses();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "This bus cannot be deleted because " +
                    "it is already used by a journey.",
                    "Cannot Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void btnRoutes_Click(
            object sender,
            EventArgs e)
        {
            JourneyManagement form =
                new JourneyManagement();

            form.ShowDialog();

            LoadBuses();
        }

     
        private void btnBuses_Click(
            object sender,
            EventArgs e)
        {
            LoadBuses();
        }

        private void btnBookings_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Booking management can be added after " +
                "the journey system is complete.",
                "Bookings",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnDownloads_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Download/report feature is optional.",
                "Reports",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        

        private void ShowEditor()
        {
            pnlAddEditBus.Visible = true;
        }

        private void HideEditor()
        {
            pnlAddEditBus.Visible = false;
            selectedBusId = 0;
        }

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            HideEditor();
        }

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            HideEditor();
        }

        private void pnlAddEditBus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRoutes_Click_1(object sender, EventArgs e)
        {

        }
    }
}