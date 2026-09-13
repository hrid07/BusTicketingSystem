namespace BusTicketingSystem
{
    partial class Payment
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
            this.Paymentlabel1 = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PaymentButton4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PaymentButton3 = new System.Windows.Forms.RadioButton();
            this.PaymentButton2 = new System.Windows.Forms.RadioButton();
            this.PaymentButton1 = new System.Windows.Forms.RadioButton();
            this.Paymentlabel10 = new System.Windows.Forms.Label();
            this.Paymentlabel9 = new System.Windows.Forms.Label();
            this.Paymentlabel7 = new System.Windows.Forms.Label();
            this.Paymentlabel8 = new System.Windows.Forms.Label();
            this.pnlSideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paymentlabel1
            // 
            this.Paymentlabel1.AutoSize = true;
            this.Paymentlabel1.BackColor = System.Drawing.Color.AliceBlue;
            this.Paymentlabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymentlabel1.Location = new System.Drawing.Point(537, 37);
            this.Paymentlabel1.Name = "Paymentlabel1";
            this.Paymentlabel1.Size = new System.Drawing.Size(406, 41);
            this.Paymentlabel1.TabIndex = 0;
            this.Paymentlabel1.Text = "SELECT PAYMENT METHOD";
            this.Paymentlabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlSideBar.Controls.Add(this.buttonLogout);
            this.pnlSideBar.Location = new System.Drawing.Point(1, 2);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(267, 655);
            this.pnlSideBar.TabIndex = 37;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Location = new System.Drawing.Point(23, 270);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(200, 50);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.PaymentButton4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.PaymentButton3);
            this.panel2.Controls.Add(this.PaymentButton2);
            this.panel2.Controls.Add(this.PaymentButton1);
            this.panel2.Controls.Add(this.Paymentlabel10);
            this.panel2.Controls.Add(this.Paymentlabel9);
            this.panel2.Controls.Add(this.Paymentlabel7);
            this.panel2.Controls.Add(this.Paymentlabel8);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(544, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 476);
            this.panel2.TabIndex = 28;
            // 
            // PaymentButton4
            // 
            this.PaymentButton4.Location = new System.Drawing.Point(106, 376);
            this.PaymentButton4.Name = "PaymentButton4";
            this.PaymentButton4.Size = new System.Drawing.Size(172, 35);
            this.PaymentButton4.TabIndex = 12;
            this.PaymentButton4.Text = "PAY CONFIRM";
            this.PaymentButton4.UseVisualStyleBackColor = true;
            this.PaymentButton4.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 27);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 27);
            this.textBox1.TabIndex = 8;
            // 
            // PaymentButton3
            // 
            this.PaymentButton3.AutoSize = true;
            this.PaymentButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton3.Location = new System.Drawing.Point(51, 160);
            this.PaymentButton3.Name = "PaymentButton3";
            this.PaymentButton3.Size = new System.Drawing.Size(57, 21);
            this.PaymentButton3.TabIndex = 10;
            this.PaymentButton3.TabStop = true;
            this.PaymentButton3.Text = "Card";
            this.PaymentButton3.UseVisualStyleBackColor = true;
            // 
            // PaymentButton2
            // 
            this.PaymentButton2.AutoSize = true;
            this.PaymentButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton2.Location = new System.Drawing.Point(51, 134);
            this.PaymentButton2.Name = "PaymentButton2";
            this.PaymentButton2.Size = new System.Drawing.Size(69, 21);
            this.PaymentButton2.TabIndex = 9;
            this.PaymentButton2.TabStop = true;
            this.PaymentButton2.Text = "Nagad";
            this.PaymentButton2.UseVisualStyleBackColor = true;
            // 
            // PaymentButton1
            // 
            this.PaymentButton1.AutoSize = true;
            this.PaymentButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton1.Location = new System.Drawing.Point(51, 108);
            this.PaymentButton1.Name = "PaymentButton1";
            this.PaymentButton1.Size = new System.Drawing.Size(66, 21);
            this.PaymentButton1.TabIndex = 8;
            this.PaymentButton1.TabStop = true;
            this.PaymentButton1.Text = "bKash";
            this.PaymentButton1.UseVisualStyleBackColor = true;
            this.PaymentButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Paymentlabel10
            // 
            this.Paymentlabel10.AutoSize = true;
            this.Paymentlabel10.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymentlabel10.Location = new System.Drawing.Point(49, 274);
            this.Paymentlabel10.Name = "Paymentlabel10";
            this.Paymentlabel10.Size = new System.Drawing.Size(150, 23);
            this.Paymentlabel10.TabIndex = 6;
            this.Paymentlabel10.Text = "Transaction PIN:";
            // 
            // Paymentlabel9
            // 
            this.Paymentlabel9.AutoSize = true;
            this.Paymentlabel9.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymentlabel9.Location = new System.Drawing.Point(48, 218);
            this.Paymentlabel9.Name = "Paymentlabel9";
            this.Paymentlabel9.Size = new System.Drawing.Size(158, 23);
            this.Paymentlabel9.TabIndex = 5;
            this.Paymentlabel9.Text = "Account Number:";
            // 
            // Paymentlabel7
            // 
            this.Paymentlabel7.AutoSize = true;
            this.Paymentlabel7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymentlabel7.Location = new System.Drawing.Point(85, 5);
            this.Paymentlabel7.Name = "Paymentlabel7";
            this.Paymentlabel7.Size = new System.Drawing.Size(214, 31);
            this.Paymentlabel7.TabIndex = 3;
            this.Paymentlabel7.Text = "PAYMENT DETAILS";
            // 
            // Paymentlabel8
            // 
            this.Paymentlabel8.AutoSize = true;
            this.Paymentlabel8.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymentlabel8.Location = new System.Drawing.Point(47, 70);
            this.Paymentlabel8.Name = "Paymentlabel8";
            this.Paymentlabel8.Size = new System.Drawing.Size(211, 23);
            this.Paymentlabel8.TabIndex = 4;
            this.Paymentlabel8.Text = "Local Payment Gateway";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.Paymentlabel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.pnlSideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Paymentlabel1;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Paymentlabel10;
        private System.Windows.Forms.Label Paymentlabel9;
        private System.Windows.Forms.Label Paymentlabel7;
        private System.Windows.Forms.Label Paymentlabel8;
        private System.Windows.Forms.RadioButton PaymentButton3;
        private System.Windows.Forms.RadioButton PaymentButton2;
        private System.Windows.Forms.RadioButton PaymentButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PaymentButton4;
    }
}