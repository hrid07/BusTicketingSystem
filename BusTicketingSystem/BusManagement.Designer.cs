namespace BusTicketingSystem
{
    partial class BusManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBarBuses = new System.Windows.Forms.VScrollBar();
            this.hScrollBarBuses = new System.Windows.Forms.HScrollBar();
            this.btnAddNewBus = new System.Windows.Forms.Button();
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            this.colBusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblBusManagement = new System.Windows.Forms.Label();
            this.pnlAddEditBus = new System.Windows.Forms.Panel();
            this.nudRouteNumber = new System.Windows.Forms.NumericUpDown();
            this.pnlBusHeader = new System.Windows.Forms.Panel();
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTransactionPIN = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.txtBusName = new System.Windows.Forms.TextBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblTransactionPIN = new System.Windows.Forms.Label();
            this.lblRouteNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBusName = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnBuses = new System.Windows.Forms.Button();
            this.btnRoutes = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.pnlAddEditBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRouteNumber)).BeginInit();
            this.pnlBusHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.vScrollBar2);
            this.pnlMainContent.Controls.Add(this.vScrollBarBuses);
            this.pnlMainContent.Controls.Add(this.hScrollBarBuses);
            this.pnlMainContent.Controls.Add(this.btnAddNewBus);
            this.pnlMainContent.Controls.Add(this.dgvBuses);
            this.pnlMainContent.Location = new System.Drawing.Point(265, 104);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(47, 37, 47, 37);
            this.pnlMainContent.Size = new System.Drawing.Size(548, 336);
            this.pnlMainContent.TabIndex = 8;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(13, 57);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(8, 10);
            this.vScrollBar2.TabIndex = 7;
            // 
            // vScrollBarBuses
            // 
            this.vScrollBarBuses.Location = new System.Drawing.Point(767, 37);
            this.vScrollBarBuses.Name = "vScrollBarBuses";
            this.vScrollBarBuses.Size = new System.Drawing.Size(17, 453);
            this.vScrollBarBuses.TabIndex = 6;
            // 
            // hScrollBarBuses
            // 
            this.hScrollBarBuses.Location = new System.Drawing.Point(0, 502);
            this.hScrollBarBuses.Name = "hScrollBarBuses";
            this.hScrollBarBuses.Size = new System.Drawing.Size(763, 17);
            this.hScrollBarBuses.TabIndex = 5;
            // 
            // btnAddNewBus
            // 
            this.btnAddNewBus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddNewBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(45)))), ((int)(((byte)(5)))));
            this.btnAddNewBus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(74)))), ((int)(((byte)(18)))));
            this.btnAddNewBus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBus.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBus.Location = new System.Drawing.Point(2, 273);
            this.btnAddNewBus.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewBus.Name = "btnAddNewBus";
            this.btnAddNewBus.Size = new System.Drawing.Size(163, 41);
            this.btnAddNewBus.TabIndex = 4;
            this.btnAddNewBus.Text = "+ ADD NEW BUS";
            this.btnAddNewBus.UseVisualStyleBackColor = false;
            // 
            // dgvBuses
            // 
            this.dgvBuses.AllowUserToAddRows = false;
            this.dgvBuses.AllowUserToDeleteRows = false;
            this.dgvBuses.AllowUserToResizeColumns = false;
            this.dgvBuses.AllowUserToResizeRows = false;
            this.dgvBuses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuses.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBuses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuses.ColumnHeadersHeight = 55;
            this.dgvBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBusID,
            this.colBusName,
            this.colFare,
            this.colStatus,
            this.colEdit,
            this.colDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuses.EnableHeadersVisualStyles = false;
            this.dgvBuses.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvBuses.Location = new System.Drawing.Point(2, 8);
            this.dgvBuses.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBuses.MultiSelect = false;
            this.dgvBuses.Name = "dgvBuses";
            this.dgvBuses.ReadOnly = true;
            this.dgvBuses.RowHeadersVisible = false;
            this.dgvBuses.RowHeadersWidth = 51;
            this.dgvBuses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuses.Size = new System.Drawing.Size(548, 264);
            this.dgvBuses.TabIndex = 0;
            // 
            // colBusID
            // 
            this.colBusID.HeaderText = "BUS ID";
            this.colBusID.MinimumWidth = 6;
            this.colBusID.Name = "colBusID";
            this.colBusID.ReadOnly = true;
            // 
            // colBusName
            // 
            this.colBusName.HeaderText = "BUS NAME";
            this.colBusName.MinimumWidth = 6;
            this.colBusName.Name = "colBusName";
            this.colBusName.ReadOnly = true;
            // 
            // colFare
            // 
            this.colFare.HeaderText = "FARE";
            this.colFare.MinimumWidth = 6;
            this.colFare.Name = "colFare";
            this.colFare.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "EDIT";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "EDIT";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "DELETE";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "DELETE";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTopBar.Controls.Add(this.lblBusManagement);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.ForeColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.Location = new System.Drawing.Point(259, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(923, 102);
            this.pnlTopBar.TabIndex = 4;
            // 
            // lblBusManagement
            // 
            this.lblBusManagement.AutoSize = true;
            this.lblBusManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblBusManagement.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusManagement.ForeColor = System.Drawing.Color.Black;
            this.lblBusManagement.Location = new System.Drawing.Point(30, 20);
            this.lblBusManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusManagement.Name = "lblBusManagement";
            this.lblBusManagement.Size = new System.Drawing.Size(343, 46);
            this.lblBusManagement.TabIndex = 6;
            this.lblBusManagement.Text = "BUS MANAGEMENT";
            // 
            // pnlAddEditBus
            // 
            this.pnlAddEditBus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddEditBus.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlAddEditBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEditBus.Controls.Add(this.nudRouteNumber);
            this.pnlAddEditBus.Controls.Add(this.pnlBusHeader);
            this.pnlAddEditBus.Controls.Add(this.txtTransactionPIN);
            this.pnlAddEditBus.Controls.Add(this.txtAccountNumber);
            this.pnlAddEditBus.Controls.Add(this.cmbRoute);
            this.pnlAddEditBus.Controls.Add(this.txtBusName);
            this.pnlAddEditBus.Controls.Add(this.lblRoute);
            this.pnlAddEditBus.Controls.Add(this.lblAccountNumber);
            this.pnlAddEditBus.Controls.Add(this.lblTransactionPIN);
            this.pnlAddEditBus.Controls.Add(this.lblRouteNumber);
            this.pnlAddEditBus.Controls.Add(this.btnSave);
            this.pnlAddEditBus.Controls.Add(this.btnCancel);
            this.pnlAddEditBus.Controls.Add(this.lblBusName);
            this.pnlAddEditBus.Location = new System.Drawing.Point(821, 105);
            this.pnlAddEditBus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddEditBus.Name = "pnlAddEditBus";
            this.pnlAddEditBus.Size = new System.Drawing.Size(361, 548);
            this.pnlAddEditBus.TabIndex = 5;
            this.pnlAddEditBus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddEditBus_Paint);
            // 
            // nudRouteNumber
            // 
            this.nudRouteNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudRouteNumber.Location = new System.Drawing.Point(21, 367);
            this.nudRouteNumber.Margin = new System.Windows.Forms.Padding(4);
            this.nudRouteNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRouteNumber.Name = "nudRouteNumber";
            this.nudRouteNumber.Size = new System.Drawing.Size(240, 30);
            this.nudRouteNumber.TabIndex = 12;
            // 
            // pnlBusHeader
            // 
            this.pnlBusHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBusHeader.Controls.Add(this.lblAddEditTitle);
            this.pnlBusHeader.Controls.Add(this.btnClose);
            this.pnlBusHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlBusHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBusHeader.Name = "pnlBusHeader";
            this.pnlBusHeader.Size = new System.Drawing.Size(359, 62);
            this.pnlBusHeader.TabIndex = 12;
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEditTitle.AutoSize = true;
            this.lblAddEditTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEditTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblAddEditTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAddEditTitle.Location = new System.Drawing.Point(0, -1);
            this.lblAddEditTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(170, 37);
            this.lblAddEditTitle.TabIndex = 11;
            this.lblAddEditTitle.Text = "Add/Edit Bus";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(255, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtTransactionPIN
            // 
            this.txtTransactionPIN.BackColor = System.Drawing.Color.White;
            this.txtTransactionPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransactionPIN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTransactionPIN.Location = new System.Drawing.Point(21, 458);
            this.txtTransactionPIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransactionPIN.Name = "txtTransactionPIN";
            this.txtTransactionPIN.Size = new System.Drawing.Size(266, 30);
            this.txtTransactionPIN.TabIndex = 19;
            this.txtTransactionPIN.UseSystemPasswordChar = true;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.White;
            this.txtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAccountNumber.Location = new System.Drawing.Point(22, 282);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(266, 30);
            this.txtAccountNumber.TabIndex = 17;
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Items.AddRange(new object[] {
            "Dhaka",
            "",
            "Chittagong",
            "",
            "Sylhet",
            "",
            "Khulna",
            "Rajshahi",
            "Barishal",
            "Bhola",
            "Dinajpur",
            "Sirajgang",
            "Kushtia",
            "Bandarban",
            "Cox\'s Bazar"});
            this.cmbRoute.Location = new System.Drawing.Point(96, 183);
            this.cmbRoute.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(165, 31);
            this.cmbRoute.TabIndex = 16;
            // 
            // txtBusName
            // 
            this.txtBusName.BackColor = System.Drawing.Color.White;
            this.txtBusName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtBusName.Location = new System.Drawing.Point(21, 95);
            this.txtBusName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusName.Name = "txtBusName";
            this.txtBusName.Size = new System.Drawing.Size(265, 30);
            this.txtBusName.TabIndex = 14;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblRoute.Location = new System.Drawing.Point(17, 183);
            this.lblRoute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(63, 25);
            this.lblRoute.TabIndex = 12;
            this.lblRoute.Text = "Route";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(17, 247);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(108, 23);
            this.lblAccountNumber.TabIndex = 10;
            this.lblAccountNumber.Text = "Account No.";
            // 
            // lblTransactionPIN
            // 
            this.lblTransactionPIN.AutoSize = true;
            this.lblTransactionPIN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblTransactionPIN.Location = new System.Drawing.Point(18, 415);
            this.lblTransactionPIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionPIN.Name = "lblTransactionPIN";
            this.lblTransactionPIN.Size = new System.Drawing.Size(134, 23);
            this.lblTransactionPIN.TabIndex = 9;
            this.lblTransactionPIN.Text = "Transaction PIN";
            // 
            // lblRouteNumber
            // 
            this.lblRouteNumber.AutoSize = true;
            this.lblRouteNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblRouteNumber.Location = new System.Drawing.Point(18, 329);
            this.lblRouteNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRouteNumber.Name = "lblRouteNumber";
            this.lblRouteNumber.Size = new System.Drawing.Size(43, 23);
            this.lblRouteNumber.TabIndex = 8;
            this.lblRouteNumber.Text = "Fare";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(21, 501);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(36)))), ((int)(((byte)(21)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCancel.Location = new System.Drawing.Point(200, 500);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblBusName
            // 
            this.lblBusName.AutoSize = true;
            this.lblBusName.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblBusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblBusName.Location = new System.Drawing.Point(23, 66);
            this.lblBusName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusName.Name = "lblBusName";
            this.lblBusName.Size = new System.Drawing.Size(98, 25);
            this.lblBusName.TabIndex = 5;
            this.lblBusName.Text = "Bus Name";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlSidebar.Controls.Add(this.btnBuses);
            this.pnlSidebar.Controls.Add(this.btnRoutes);
            this.pnlSidebar.Controls.Add(this.btnBookings);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(259, 653);
            this.pnlSidebar.TabIndex = 7;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
            // 
            // btnBuses
            // 
            this.btnBuses.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuses.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuses.Location = new System.Drawing.Point(29, 141);
            this.btnBuses.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuses.Name = "btnBuses";
            this.btnBuses.Size = new System.Drawing.Size(200, 50);
            this.btnBuses.TabIndex = 0;
            this.btnBuses.Text = "BUSES";
            this.btnBuses.UseVisualStyleBackColor = false;
            // 
            // btnRoutes
            // 
            this.btnRoutes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRoutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutes.ForeColor = System.Drawing.Color.Transparent;
            this.btnRoutes.Location = new System.Drawing.Point(29, 248);
            this.btnRoutes.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(200, 50);
            this.btnRoutes.TabIndex = 1;
            this.btnRoutes.Text = "ROUTES";
            this.btnRoutes.UseVisualStyleBackColor = false;
            this.btnRoutes.Click += new System.EventHandler(this.btnRoutes_Click_1);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBookings.ForeColor = System.Drawing.Color.Transparent;
            this.btnBookings.Location = new System.Drawing.Point(29, 353);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(200, 50);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "BOOKINGS";
            this.btnBookings.UseVisualStyleBackColor = false;
            // 
            // BusManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlAddEditBus);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusManagement";
            this.Text = "BusManagement";
            this.pnlMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlAddEditBus.ResumeLayout(false);
            this.pnlAddEditBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRouteNumber)).EndInit();
            this.pnlBusHeader.ResumeLayout(false);
            this.pnlBusHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnAddNewBus;
        private System.Windows.Forms.DataGridView dgvBuses;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblBusManagement;
        private System.Windows.Forms.Panel pnlAddEditBus;
        private System.Windows.Forms.NumericUpDown nudRouteNumber;
        private System.Windows.Forms.Panel pnlBusHeader;
        private System.Windows.Forms.Label lblAddEditTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTransactionPIN;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblTransactionPIN;
        private System.Windows.Forms.Label lblRouteNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBusName;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnBuses;
        private System.Windows.Forms.Button btnRoutes;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBarBuses;
        private System.Windows.Forms.HScrollBar hScrollBarBuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}