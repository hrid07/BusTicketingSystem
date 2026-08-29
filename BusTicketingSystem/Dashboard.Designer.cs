namespace BusTicketingSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.picArrowD = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblSearchTittle = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSelectSeat = new System.Windows.Forms.Button();
            this.btnAvailableJourney = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picNotification = new System.Windows.Forms.PictureBox();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowD)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.picArrowD);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.dateTimePicker1);
            this.pnlSearch.Controls.Add(this.lblDate);
            this.pnlSearch.Controls.Add(this.cmbTo);
            this.pnlSearch.Controls.Add(this.cmbFrom);
            this.pnlSearch.Controls.Add(this.lblTo);
            this.pnlSearch.Controls.Add(this.lblFrom);
            this.pnlSearch.Controls.Add(this.lblSearchTittle);
            this.pnlSearch.Location = new System.Drawing.Point(334, 283);
            this.pnlSearch.MaximumSize = new System.Drawing.Size(750, 280);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(662, 280);
            this.pnlSearch.TabIndex = 1;
            // 
            // picArrowD
            // 
            this.picArrowD.Image = ((System.Drawing.Image)(resources.GetObject("picArrowD.Image")));
            this.picArrowD.Location = new System.Drawing.Point(263, 89);
            this.picArrowD.Name = "picArrowD";
            this.picArrowD.Size = new System.Drawing.Size(100, 22);
            this.picArrowD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowD.TabIndex = 15;
            this.picArrowD.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(477, 201);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "SEARCH TICKET";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 175);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Items.AddRange(new object[] {
            "DHAKA",
            "CHITTAGONG",
            "COX\'S BAZAR",
            "SITAKUNDO",
            "SAJEK",
            "RANGAMATI",
            "SYLHET",
            "RAJSHAHI",
            "BARISHAL",
            "BHOLA",
            "CHADPUR",
            "BOGURA",
            "RANGPUR"});
            this.cmbTo.Location = new System.Drawing.Point(464, 89);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(177, 21);
            this.cmbTo.TabIndex = 10;
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Items.AddRange(new object[] {
            "DHAKA",
            "CHITTAGONG",
            "COX\'S BAZAR",
            "SITAKUNDO",
            "SAJEK",
            "RANGAMATI",
            "SYLHET",
            "RAJSHAHI",
            "BARISHAL",
            "BHOLA",
            "CHADPUR",
            "BOGURA",
            "RANGPUR"});
            this.cmbFrom.Location = new System.Drawing.Point(29, 89);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(153, 21);
            this.cmbFrom.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(474, 61);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "TO";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(42, 61);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 13);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "FROM";
            // 
            // lblSearchTittle
            // 
            this.lblSearchTittle.AutoSize = true;
            this.lblSearchTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.lblSearchTittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTittle.ForeColor = System.Drawing.Color.White;
            this.lblSearchTittle.Location = new System.Drawing.Point(15, 19);
            this.lblSearchTittle.Name = "lblSearchTittle";
            this.lblSearchTittle.Size = new System.Drawing.Size(158, 17);
            this.lblSearchTittle.TabIndex = 0;
            this.lblSearchTittle.Text = "SEARCH YOUR JOURNEY";
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlSideBar.Controls.Add(this.btnConfirmation);
            this.pnlSideBar.Controls.Add(this.btnLogout);
            this.pnlSideBar.Controls.Add(this.btnPayment);
            this.pnlSideBar.Controls.Add(this.btnSelectSeat);
            this.pnlSideBar.Controls.Add(this.btnAvailableJourney);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Controls.Add(this.pnlHeader);
            this.pnlSideBar.Location = new System.Drawing.Point(1, 2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 677);
            this.pnlSideBar.TabIndex = 14;
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmation.Location = new System.Drawing.Point(12, 514);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(122, 23);
            this.btnConfirmation.TabIndex = 7;
            this.btnConfirmation.Text = "CONFIRMATION";
            this.btnConfirmation.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(24, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(24, 421);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(92, 23);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnSelectSeat
            // 
            this.btnSelectSeat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSeat.ForeColor = System.Drawing.Color.White;
            this.btnSelectSeat.Location = new System.Drawing.Point(11, 307);
            this.btnSelectSeat.Name = "btnSelectSeat";
            this.btnSelectSeat.Size = new System.Drawing.Size(122, 23);
            this.btnSelectSeat.TabIndex = 4;
            this.btnSelectSeat.Text = "SELECT SEAT";
            this.btnSelectSeat.UseVisualStyleBackColor = false;
            // 
            // btnAvailableJourney
            // 
            this.btnAvailableJourney.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableJourney.ForeColor = System.Drawing.Color.White;
            this.btnAvailableJourney.Location = new System.Drawing.Point(0, 171);
            this.btnAvailableJourney.MaximumSize = new System.Drawing.Size(180, 45);
            this.btnAvailableJourney.Name = "btnAvailableJourney";
            this.btnAvailableJourney.Size = new System.Drawing.Size(176, 23);
            this.btnAvailableJourney.TabIndex = 2;
            this.btnAvailableJourney.Text = "AVAILABLE JOURNEY";
            this.btnAvailableJourney.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Gold;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.btnDashboard.Location = new System.Drawing.Point(24, 88);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(109, 32);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.picNotification);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1497, 57);
            this.pnlHeader.TabIndex = 0;
            // 
            // picNotification
            // 
            this.picNotification.Image = ((System.Drawing.Image)(resources.GetObject("picNotification.Image")));
            this.picNotification.Location = new System.Drawing.Point(1067, 7);
            this.picNotification.Name = "picNotification";
            this.picNotification.Size = new System.Drawing.Size(40, 50);
            this.picNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNotification.TabIndex = 16;
            this.picNotification.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlSearch);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowD)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNotification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox picArrowD;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblSearchTittle;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSelectSeat;
        private System.Windows.Forms.Button btnAvailableJourney;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picNotification;
    }
}