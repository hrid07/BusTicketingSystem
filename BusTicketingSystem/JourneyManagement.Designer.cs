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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.dtDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.JMlabel1 = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.Label();
            this.JMlabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.JMlabel3 = new System.Windows.Forms.Label();
            this.JMpanel1 = new System.Windows.Forms.Panel();
            this.JMlabel4 = new System.Windows.Forms.Label();
            this.JMlabel5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.JMpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 24);
            this.comboBox1.TabIndex = 0;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(908, 206);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 5;
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
            // JMlabel1
            // 
            this.JMlabel1.AutoSize = true;
            this.JMlabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMlabel1.Location = new System.Drawing.Point(99, 37);
            this.JMlabel1.Name = "JMlabel1";
            this.JMlabel1.Size = new System.Drawing.Size(137, 25);
            this.JMlabel1.TabIndex = 11;
            this.JMlabel1.Text = "Departure City";
            this.JMlabel1.Click += new System.EventHandler(this.JMlabel1_Click);
            // 
            // cmbDestination
            // 
            this.cmbDestination.AutoSize = true;
            this.cmbDestination.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestination.Location = new System.Drawing.Point(334, 37);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(110, 25);
            this.cmbDestination.TabIndex = 12;
            this.cmbDestination.Text = "Destination";
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(297, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // JMlabel3
            // 
            this.JMlabel3.AutoSize = true;
            this.JMlabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMlabel3.Location = new System.Drawing.Point(584, 40);
            this.JMlabel3.Name = "JMlabel3";
            this.JMlabel3.Size = new System.Drawing.Size(47, 25);
            this.JMlabel3.TabIndex = 15;
            this.JMlabel3.Text = "BUS";
            this.JMlabel3.Click += new System.EventHandler(this.label1_Click);
            // 
            // JMpanel1
            // 
            this.JMpanel1.Controls.Add(this.label1);
            this.JMpanel1.Controls.Add(this.btnDelete);
            this.JMpanel1.Controls.Add(this.JMlabel5);
            this.JMpanel1.Controls.Add(this.numericUpDown1);
            this.JMpanel1.Controls.Add(this.btnUpdate);
            this.JMpanel1.Controls.Add(this.JMlabel4);
            this.JMpanel1.Controls.Add(this.JMlabel3);
            this.JMpanel1.Controls.Add(this.comboBox2);
            this.JMpanel1.Controls.Add(this.cmbDestination);
            this.JMpanel1.Controls.Add(this.btnAdd);
            this.JMpanel1.Controls.Add(this.JMlabel1);
            this.JMpanel1.Controls.Add(this.cmbBus);
            this.JMpanel1.Controls.Add(this.comboBox1);
            this.JMpanel1.Controls.Add(this.dtArrival);
            this.JMpanel1.Controls.Add(this.dtDeparture);
            this.JMpanel1.Location = new System.Drawing.Point(23, 87);
            this.JMpanel1.Name = "JMpanel1";
            this.JMpanel1.Size = new System.Drawing.Size(1128, 264);
            this.JMpanel1.TabIndex = 16;
            this.JMpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.JMpanel1_Paint);
            // 
            // JMlabel4
            // 
            this.JMlabel4.AutoSize = true;
            this.JMlabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMlabel4.Location = new System.Drawing.Point(929, 38);
            this.JMlabel4.Name = "JMlabel4";
            this.JMlabel4.Size = new System.Drawing.Size(99, 25);
            this.JMlabel4.TabIndex = 16;
            this.JMlabel4.Text = "Departure";
            // 
            // JMlabel5
            // 
            this.JMlabel5.AutoSize = true;
            this.JMlabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMlabel5.Location = new System.Drawing.Point(930, 106);
            this.JMlabel5.Name = "JMlabel5";
            this.JMlabel5.Size = new System.Drawing.Size(69, 25);
            this.JMlabel5.TabIndex = 17;
            this.JMlabel5.Text = "Arrival";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(937, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "FARE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 408);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 233);
            this.dataGridView1.TabIndex = 10;
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
            this.Controls.Add(this.JMpanel1);
            this.Controls.Add(this.JMlabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JourneyManagement";
            this.Text = "JourneyManagement";
            this.Load += new System.EventHandler(this.JourneyManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.JMpanel1.ResumeLayout(false);
            this.JMpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.DateTimePicker dtDeparture;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label JMlabel1;
        private System.Windows.Forms.Label cmbDestination;
        private System.Windows.Forms.Label JMlabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label JMlabel3;
        private System.Windows.Forms.Panel JMpanel1;
        private System.Windows.Forms.Label JMlabel4;
        private System.Windows.Forms.Label JMlabel5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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