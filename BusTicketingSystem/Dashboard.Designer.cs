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
            this.pnlSearch.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Bisque;
            this.pnlSearch.BackgroundImage = global::BusTicketingSystem.Properties.Resources._2cec0fbe_212d_4597_a7b5_15f2085ac243;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.dateTimePicker1);
            this.pnlSearch.Controls.Add(this.lblDate);
            this.pnlSearch.Controls.Add(this.cmbTo);
            this.pnlSearch.Controls.Add(this.cmbFrom);
            this.pnlSearch.Controls.Add(this.lblTo);
            this.pnlSearch.Controls.Add(this.lblFrom);
            this.pnlSearch.Controls.Add(this.lblSearchTittle);
            this.pnlSearch.Location = new System.Drawing.Point(307, 203);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearch.MaximumSize = new System.Drawing.Size(1000, 345);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(826, 345);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(352, 250);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 28);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "SEARCH TICKET";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 112);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(412, 77);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
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
            this.cmbTo.Location = new System.Drawing.Point(39, 193);
            this.cmbTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(203, 24);
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
            this.cmbFrom.Location = new System.Drawing.Point(39, 110);
            this.cmbFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(203, 24);
            this.cmbFrom.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Location = new System.Drawing.Point(43, 166);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 16);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "TO";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Location = new System.Drawing.Point(41, 77);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 16);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "FROM";
            // 
            // lblSearchTittle
            // 
            this.lblSearchTittle.AutoSize = true;
            this.lblSearchTittle.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchTittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTittle.ForeColor = System.Drawing.Color.White;
            this.lblSearchTittle.Location = new System.Drawing.Point(20, 23);
            this.lblSearchTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchTittle.Name = "lblSearchTittle";
            this.lblSearchTittle.Size = new System.Drawing.Size(208, 23);
            this.lblSearchTittle.TabIndex = 0;
            this.lblSearchTittle.Text = "SEARCH YOUR JOURNEY";
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlSideBar.Controls.Add(this.btnConfirmation);
            this.pnlSideBar.Controls.Add(this.btnLogout);
            this.pnlSideBar.Controls.Add(this.btnPayment);
            this.pnlSideBar.Controls.Add(this.btnSelectSeat);
            this.pnlSideBar.Controls.Add(this.btnAvailableJourney);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Location = new System.Drawing.Point(1, 2);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(267, 833);
            this.pnlSideBar.TabIndex = 14;
            this.pnlSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSideBar_Paint);
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmation.Location = new System.Drawing.Point(39, 442);
            this.btnConfirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(163, 46);
            this.btnConfirmation.TabIndex = 7;
            this.btnConfirmation.Text = "CONFIRMATION";
            this.btnConfirmation.UseVisualStyleBackColor = false;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(69, 518);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 46);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.Location = new System.Drawing.Point(57, 371);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(123, 47);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnSelectSeat
            // 
            this.btnSelectSeat.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectSeat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSeat.ForeColor = System.Drawing.Color.Black;
            this.btnSelectSeat.Location = new System.Drawing.Point(39, 293);
            this.btnSelectSeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectSeat.Name = "btnSelectSeat";
            this.btnSelectSeat.Size = new System.Drawing.Size(163, 45);
            this.btnSelectSeat.TabIndex = 4;
            this.btnSelectSeat.Text = "SELECT SEAT";
            this.btnSelectSeat.UseVisualStyleBackColor = false;
            // 
            // btnAvailableJourney
            // 
            this.btnAvailableJourney.BackColor = System.Drawing.Color.Transparent;
            this.btnAvailableJourney.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableJourney.ForeColor = System.Drawing.Color.Black;
            this.btnAvailableJourney.Location = new System.Drawing.Point(16, 186);
            this.btnAvailableJourney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvailableJourney.MaximumSize = new System.Drawing.Size(240, 55);
            this.btnAvailableJourney.Name = "btnAvailableJourney";
            this.btnAvailableJourney.Size = new System.Drawing.Size(235, 55);
            this.btnAvailableJourney.TabIndex = 2;
            this.btnAvailableJourney.Text = "AVAILABLE JOURNEY";
            this.btnAvailableJourney.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(91)))));
            this.btnDashboard.Location = new System.Drawing.Point(57, 94);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(145, 39);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
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
    }
}