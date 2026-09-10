namespace BusTicketingSystem
{
    partial class JourneyManagement
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
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.dtDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.nudFare = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelDeperture = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.JMlabel = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.labelBus = new System.Windows.Forms.Label();
            this.JMPanel = new System.Windows.Forms.Panel();
            this.labelFare = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelArrivaldt = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelDepdt = new System.Windows.Forms.Label();
            this.dgvJourneys = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudFare)).BeginInit();
            this.JMPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourneys)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(75, 68);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(186, 24);
            this.cmbSource.TabIndex = 0;
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(526, 68);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(174, 24);
            this.cmbBus.TabIndex = 2;
            // 
            // dtDeparture
            // 
            this.dtDeparture.Location = new System.Drawing.Point(868, 66);
            this.dtDeparture.Name = "dtDeparture";
            this.dtDeparture.Size = new System.Drawing.Size(200, 22);
            this.dtDeparture.TabIndex = 3;
            // 
            // dtArrival
            // 
            this.dtArrival.Location = new System.Drawing.Point(868, 134);
            this.dtArrival.Name = "dtArrival";
            this.dtArrival.Size = new System.Drawing.Size(200, 22);
            this.dtArrival.TabIndex = 4;
            // 
            // nudFare
            // 
            this.nudFare.Location = new System.Drawing.Point(908, 206);
            this.nudFare.Name = "nudFare";
            this.nudFare.Size = new System.Drawing.Size(120, 22);
            this.nudFare.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(124, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // labelDeperture
            // 
            this.labelDeperture.AutoSize = true;
            this.labelDeperture.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeperture.Location = new System.Drawing.Point(99, 37);
            this.labelDeperture.Name = "labelDeperture";
            this.labelDeperture.Size = new System.Drawing.Size(137, 25);
            this.labelDeperture.TabIndex = 11;
            this.labelDeperture.Text = "Departure City";
            this.labelDeperture.Click += new System.EventHandler(this.JMlabel1_Click);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(334, 37);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(110, 25);
            this.labelDestination.TabIndex = 12;
            this.labelDestination.Text = "Destination";
            // 
            // JMlabel
            // 
            this.JMlabel.AutoSize = true;
            this.JMlabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMlabel.Location = new System.Drawing.Point(412, 14);
            this.JMlabel.Name = "JMlabel";
            this.JMlabel.Size = new System.Drawing.Size(354, 38);
            this.JMlabel.TabIndex = 13;
            this.JMlabel.Text = "JOURNEY MANAGEMENT";
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(297, 68);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(186, 24);
            this.cmbDestination.TabIndex = 14;
            // 
            // labelBus
            // 
            this.labelBus.AutoSize = true;
            this.labelBus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBus.Location = new System.Drawing.Point(584, 40);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(47, 25);
            this.labelBus.TabIndex = 15;
            this.labelBus.Text = "BUS";
            this.labelBus.Click += new System.EventHandler(this.label1_Click);
            // 
            // JMPanel
            // 
            this.JMPanel.Controls.Add(this.labelFare);
            this.JMPanel.Controls.Add(this.btnDelete);
            this.JMPanel.Controls.Add(this.labelArrivaldt);
            this.JMPanel.Controls.Add(this.nudFare);
            this.JMPanel.Controls.Add(this.btnUpdate);
            this.JMPanel.Controls.Add(this.labelDepdt);
            this.JMPanel.Controls.Add(this.labelBus);
            this.JMPanel.Controls.Add(this.cmbDestination);
            this.JMPanel.Controls.Add(this.labelDestination);
            this.JMPanel.Controls.Add(this.btnAdd);
            this.JMPanel.Controls.Add(this.labelDeperture);
            this.JMPanel.Controls.Add(this.cmbBus);
            this.JMPanel.Controls.Add(this.cmbSource);
            this.JMPanel.Controls.Add(this.dtArrival);
            this.JMPanel.Controls.Add(this.dtDeparture);
            this.JMPanel.Location = new System.Drawing.Point(23, 87);
            this.JMPanel.Name = "JMPanel";
            this.JMPanel.Size = new System.Drawing.Size(1128, 264);
            this.JMPanel.TabIndex = 16;
            this.JMPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.JMpanel1_Paint);
            // 
            // labelFare
            // 
            this.labelFare.AutoSize = true;
            this.labelFare.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFare.Location = new System.Drawing.Point(937, 178);
            this.labelFare.Name = "labelFare";
            this.labelFare.Size = new System.Drawing.Size(55, 25);
            this.labelFare.TabIndex = 19;
            this.labelFare.Text = "FARE";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(589, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 30);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // labelArrivaldt
            // 
            this.labelArrivaldt.AutoSize = true;
            this.labelArrivaldt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrivaldt.Location = new System.Drawing.Point(930, 106);
            this.labelArrivaldt.Name = "labelArrivaldt";
            this.labelArrivaldt.Size = new System.Drawing.Size(69, 25);
            this.labelArrivaldt.TabIndex = 17;
            this.labelArrivaldt.Text = "Arrival";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(365, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 30);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // labelDepdt
            // 
            this.labelDepdt.AutoSize = true;
            this.labelDepdt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepdt.Location = new System.Drawing.Point(929, 38);
            this.labelDepdt.Name = "labelDepdt";
            this.labelDepdt.Size = new System.Drawing.Size(99, 25);
            this.labelDepdt.TabIndex = 16;
            this.labelDepdt.Text = "Departure";
            // 
            // dgvJourneys
            // 
            this.dgvJourneys.AllowUserToAddRows = false;
            this.dgvJourneys.AllowUserToDeleteRows = false;
            this.dgvJourneys.AllowUserToResizeColumns = false;
            this.dgvJourneys.AllowUserToResizeRows = false;
            this.dgvJourneys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJourneys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJourneys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvJourneys.Location = new System.Drawing.Point(-3, 408);
            this.dgvJourneys.MultiSelect = false;
            this.dgvJourneys.Name = "dgvJourneys";
            this.dgvJourneys.ReadOnly = true;
            this.dgvJourneys.RowHeadersVisible = false;
            this.dgvJourneys.RowHeadersWidth = 51;
            this.dgvJourneys.RowTemplate.Height = 24;
            this.dgvJourneys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJourneys.Size = new System.Drawing.Size(1173, 233);
            this.dgvJourneys.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bus Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bus Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "From";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "To";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Departure";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Arrival";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Fare";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Available Seats";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // JourneyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.JMPanel);
            this.Controls.Add(this.JMlabel);
            this.Controls.Add(this.dgvJourneys);
            this.Name = "JourneyManagement";
            this.Text = "JourneyManagement";
            this.Load += new System.EventHandler(this.JourneyManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFare)).EndInit();
            this.JMPanel.ResumeLayout(false);
            this.JMPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJourneys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.DateTimePicker dtDeparture;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.NumericUpDown nudFare;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelDeperture;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label JMlabel;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Panel JMPanel;
        private System.Windows.Forms.Label labelDepdt;
        private System.Windows.Forms.Label labelArrivaldt;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelFare;
        private System.Windows.Forms.DataGridView dgvJourneys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}