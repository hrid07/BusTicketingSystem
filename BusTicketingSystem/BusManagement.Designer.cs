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
            this.btnAddNewBus = new System.Windows.Forms.Button();
            this.dgvBuses = new System.Windows.Forms.DataGridView();
            this.colBusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBusManagement = new System.Windows.Forms.Label();
            this.pnlAddEditBus = new System.Windows.Forms.Panel();
            this.nudRouteNumber = new System.Windows.Forms.NumericUpDown();
            this.pnlBusHeader = new System.Windows.Forms.Panel();
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTransactionPIN = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.nudFare = new System.Windows.Forms.NumericUpDown();
            this.txtBusName = new System.Windows.Forms.TextBox();
            this.lblFare = new System.Windows.Forms.Label();
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
            this.btnDownloads = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAddEditBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRouteNumber)).BeginInit();
            this.pnlBusHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFare)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.btnAddNewBus);
            this.pnlMainContent.Controls.Add(this.dgvBuses);
            this.pnlMainContent.Location = new System.Drawing.Point(232, 144);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(35, 30, 35, 30);
            this.pnlMainContent.Size = new System.Drawing.Size(598, 428);
            this.pnlMainContent.TabIndex = 8;
            // 
            // btnAddNewBus
            // 
            this.btnAddNewBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(59)))), ((int)(((byte)(8)))));
            this.btnAddNewBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewBus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(45)))), ((int)(((byte)(5)))));
            this.btnAddNewBus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(74)))), ((int)(((byte)(18)))));
            this.btnAddNewBus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBus.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBus.Location = new System.Drawing.Point(456, 1);
            this.btnAddNewBus.Name = "btnAddNewBus";
            this.btnAddNewBus.Size = new System.Drawing.Size(136, 34);
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
            this.dgvBuses.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(59)))), ((int)(((byte)(8)))));
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
            this.dgvBuses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBuses.Location = new System.Drawing.Point(0, 30);
            this.dgvBuses.MultiSelect = false;
            this.dgvBuses.Name = "dgvBuses";
            this.dgvBuses.ReadOnly = true;
            this.dgvBuses.RowHeadersVisible = false;
            this.dgvBuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuses.Size = new System.Drawing.Size(580, 300);
            this.dgvBuses.TabIndex = 0;
            // 
            // colBusID
            // 
            this.colBusID.HeaderText = "BUS ID";
            this.colBusID.Name = "colBusID";
            this.colBusID.ReadOnly = true;
            // 
            // colBusName
            // 
            this.colBusName.HeaderText = "BUS NAME";
            this.colBusName.Name = "colBusName";
            this.colBusName.ReadOnly = true;
            // 
            // colFare
            // 
            this.colFare.HeaderText = "FARE";
            this.colFare.Name = "colFare";
            this.colFare.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "EDIT";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "EDIT";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "DELETE";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "DELETE";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlPagination
            // 
            this.pnlPagination.BackColor = System.Drawing.Color.Transparent;
            this.pnlPagination.Controls.Add(this.lblPageNumber);
            this.pnlPagination.Controls.Add(this.btnNext);
            this.pnlPagination.Controls.Add(this.btnPrevious);
            this.pnlPagination.Location = new System.Drawing.Point(232, 570);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(592, 24);
            this.pnlPagination.TabIndex = 6;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(59)))), ((int)(((byte)(8)))));
            this.lblPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.ForeColor = System.Drawing.Color.White;
            this.lblPageNumber.Location = new System.Drawing.Point(246, 5);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(14, 15);
            this.lblPageNumber.TabIndex = 2;
            this.lblPageNumber.Text = "1";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(173)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(59)))), ((int)(((byte)(8)))));
            this.btnNext.Location = new System.Drawing.Point(325, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = " >";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(193)))), ((int)(((byte)(173)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(59)))), ((int)(((byte)(8)))));
            this.btnPrevious.Location = new System.Drawing.Point(118, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(8)))));
            this.pnlTopBar.Controls.Add(this.pictureBox2);
            this.pnlTopBar.Controls.Add(this.pictureBox1);
            this.pnlTopBar.Controls.Add(this.lblBusManagement);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.ForeColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.Location = new System.Drawing.Point(200, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(984, 100);
            this.pnlTopBar.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1072, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(659, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblBusManagement
            // 
            this.lblBusManagement.AutoSize = true;
            this.lblBusManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblBusManagement.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusManagement.ForeColor = System.Drawing.Color.White;
            this.lblBusManagement.Location = new System.Drawing.Point(25, 25);
            this.lblBusManagement.Name = "lblBusManagement";
            this.lblBusManagement.Size = new System.Drawing.Size(271, 37);
            this.lblBusManagement.TabIndex = 6;
            this.lblBusManagement.Text = "BUS MANAGEMENT";
            // 
            // pnlAddEditBus
            // 
            this.pnlAddEditBus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddEditBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.pnlAddEditBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEditBus.Controls.Add(this.nudRouteNumber);
            this.pnlAddEditBus.Controls.Add(this.pnlBusHeader);
            this.pnlAddEditBus.Controls.Add(this.txtTransactionPIN);
            this.pnlAddEditBus.Controls.Add(this.txtAccountNumber);
            this.pnlAddEditBus.Controls.Add(this.cmbRoute);
            this.pnlAddEditBus.Controls.Add(this.nudFare);
            this.pnlAddEditBus.Controls.Add(this.txtBusName);
            this.pnlAddEditBus.Controls.Add(this.lblFare);
            this.pnlAddEditBus.Controls.Add(this.lblRoute);
            this.pnlAddEditBus.Controls.Add(this.lblAccountNumber);
            this.pnlAddEditBus.Controls.Add(this.lblTransactionPIN);
            this.pnlAddEditBus.Controls.Add(this.lblRouteNumber);
            this.pnlAddEditBus.Controls.Add(this.btnSave);
            this.pnlAddEditBus.Controls.Add(this.btnCancel);
            this.pnlAddEditBus.Controls.Add(this.lblBusName);
            this.pnlAddEditBus.Location = new System.Drawing.Point(858, 144);
            this.pnlAddEditBus.Name = "pnlAddEditBus";
            this.pnlAddEditBus.Size = new System.Drawing.Size(300, 450);
            this.pnlAddEditBus.TabIndex = 5;
            // 
            // nudRouteNumber
            // 
            this.nudRouteNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudRouteNumber.Location = new System.Drawing.Point(16, 304);
            this.nudRouteNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRouteNumber.Name = "nudRouteNumber";
            this.nudRouteNumber.Size = new System.Drawing.Size(180, 25);
            this.nudRouteNumber.TabIndex = 12;
            // 
            // pnlBusHeader
            // 
            this.pnlBusHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(59)))), ((int)(((byte)(8)))));
            this.pnlBusHeader.Controls.Add(this.lblAddEditTitle);
            this.pnlBusHeader.Controls.Add(this.btnClose);
            this.pnlBusHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlBusHeader.Name = "pnlBusHeader";
            this.pnlBusHeader.Size = new System.Drawing.Size(298, 50);
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
            this.lblAddEditTitle.ForeColor = System.Drawing.Color.White;
            this.lblAddEditTitle.Location = new System.Drawing.Point(0, -1);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(138, 30);
            this.lblAddEditTitle.TabIndex = 11;
            this.lblAddEditTitle.Text = "Add/Edit Bus";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(220, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtTransactionPIN
            // 
            this.txtTransactionPIN.BackColor = System.Drawing.Color.White;
            this.txtTransactionPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransactionPIN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTransactionPIN.Location = new System.Drawing.Point(16, 372);
            this.txtTransactionPIN.Name = "txtTransactionPIN";
            this.txtTransactionPIN.Size = new System.Drawing.Size(200, 25);
            this.txtTransactionPIN.TabIndex = 19;
            this.txtTransactionPIN.UseSystemPasswordChar = true;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.White;
            this.txtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAccountNumber.Location = new System.Drawing.Point(16, 249);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(200, 25);
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
            this.cmbRoute.Location = new System.Drawing.Point(16, 176);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(125, 25);
            this.cmbRoute.TabIndex = 16;
            // 
            // nudFare
            // 
            this.nudFare.BackColor = System.Drawing.Color.White;
            this.nudFare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.nudFare.Location = new System.Drawing.Point(105, 109);
            this.nudFare.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFare.Name = "nudFare";
            this.nudFare.Size = new System.Drawing.Size(120, 20);
            this.nudFare.TabIndex = 15;
            this.nudFare.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // txtBusName
            // 
            this.txtBusName.BackColor = System.Drawing.Color.White;
            this.txtBusName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtBusName.Location = new System.Drawing.Point(16, 78);
            this.txtBusName.Name = "txtBusName";
            this.txtBusName.Size = new System.Drawing.Size(200, 25);
            this.txtBusName.TabIndex = 14;
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblFare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblFare.Location = new System.Drawing.Point(13, 112);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(39, 20);
            this.lblFare.TabIndex = 13;
            this.lblFare.Text = "Fare";
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblRoute.Location = new System.Drawing.Point(13, 150);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(51, 20);
            this.lblRoute.TabIndex = 12;
            this.lblRoute.Text = "Route";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(14, 229);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(84, 17);
            this.lblAccountNumber.TabIndex = 10;
            this.lblAccountNumber.Text = "Account No.";
            // 
            // lblTransactionPIN
            // 
            this.lblTransactionPIN.AutoSize = true;
            this.lblTransactionPIN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblTransactionPIN.Location = new System.Drawing.Point(13, 345);
            this.lblTransactionPIN.Name = "lblTransactionPIN";
            this.lblTransactionPIN.Size = new System.Drawing.Size(105, 17);
            this.lblTransactionPIN.TabIndex = 9;
            this.lblTransactionPIN.Text = "Transaction PIN";
            // 
            // lblRouteNumber
            // 
            this.lblRouteNumber.AutoSize = true;
            this.lblRouteNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblRouteNumber.Location = new System.Drawing.Point(13, 284);
            this.lblRouteNumber.Name = "lblRouteNumber";
            this.lblRouteNumber.Size = new System.Drawing.Size(70, 17);
            this.lblRouteNumber.TabIndex = 8;
            this.lblRouteNumber.Text = "Route No.";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(59)))), ((int)(((byte)(8)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(16, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
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
            this.btnCancel.Location = new System.Drawing.Point(214, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblBusName
            // 
            this.lblBusName.AutoSize = true;
            this.lblBusName.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblBusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblBusName.Location = new System.Drawing.Point(13, 52);
            this.lblBusName.Name = "lblBusName";
            this.lblBusName.Size = new System.Drawing.Size(81, 20);
            this.lblBusName.TabIndex = 5;
            this.lblBusName.Text = "Bus Name";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(8)))));
            this.pnlSidebar.Controls.Add(this.btnBuses);
            this.pnlSidebar.Controls.Add(this.btnRoutes);
            this.pnlSidebar.Controls.Add(this.btnBookings);
            this.pnlSidebar.Controls.Add(this.btnDownloads);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 661);
            this.pnlSidebar.TabIndex = 7;
            // 
            // btnBuses
            // 
            this.btnBuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(50)))), ((int)(((byte)(7)))));
            this.btnBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuses.ForeColor = System.Drawing.Color.Black;
            this.btnBuses.Location = new System.Drawing.Point(3, 121);
            this.btnBuses.Name = "btnBuses";
            this.btnBuses.Size = new System.Drawing.Size(200, 60);
            this.btnBuses.TabIndex = 0;
            this.btnBuses.Text = "BUSES";
            this.btnBuses.UseVisualStyleBackColor = false;
            // 
            // btnRoutes
            // 
            this.btnRoutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.btnRoutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoutes.ForeColor = System.Drawing.Color.Black;
            this.btnRoutes.Location = new System.Drawing.Point(0, 223);
            this.btnRoutes.Name = "btnRoutes";
            this.btnRoutes.Size = new System.Drawing.Size(200, 60);
            this.btnRoutes.TabIndex = 1;
            this.btnRoutes.Text = "ROUTES";
            this.btnRoutes.UseVisualStyleBackColor = false;
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBookings.Location = new System.Drawing.Point(0, 353);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(200, 60);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "BOOKINGS";
            this.btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnDownloads
            // 
            this.btnDownloads.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDownloads.Location = new System.Drawing.Point(0, 469);
            this.btnDownloads.Name = "btnDownloads";
            this.btnDownloads.Size = new System.Drawing.Size(200, 60);
            this.btnDownloads.TabIndex = 3;
            this.btnDownloads.Text = "DOWNLOADS";
            this.btnDownloads.UseVisualStyleBackColor = true;
            // 
            // BusManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlPagination);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlAddEditBus);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "BusManagement";
            this.Text = "BusManagement";
            this.pnlMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuses)).EndInit();
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAddEditBus.ResumeLayout(false);
            this.pnlAddEditBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRouteNumber)).EndInit();
            this.pnlBusHeader.ResumeLayout(false);
            this.pnlBusHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFare)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnAddNewBus;
        private System.Windows.Forms.DataGridView dgvBuses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBusManagement;
        private System.Windows.Forms.Panel pnlAddEditBus;
        private System.Windows.Forms.NumericUpDown nudRouteNumber;
        private System.Windows.Forms.Panel pnlBusHeader;
        private System.Windows.Forms.Label lblAddEditTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTransactionPIN;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.NumericUpDown nudFare;
        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.Label lblFare;
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
        private System.Windows.Forms.Button btnDownloads;
    }
}