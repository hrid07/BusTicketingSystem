namespace BusTicketingSystem
{
    partial class SignupForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelSignup = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.labelSphone = new System.Windows.Forms.Label();
            this.labelSuser = new System.Windows.Forms.Label();
            this.labelSpass = new System.Windows.Forms.Label();
            this.labelScpass = new System.Windows.Forms.Label();
            this.buttonSign = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 326);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 185);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 137);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(70, 278);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(237, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(70, 230);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(237, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // labelSignup
            // 
            this.labelSignup.AutoSize = true;
            this.labelSignup.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignup.Location = new System.Drawing.Point(69, 11);
            this.labelSignup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(248, 45);
            this.labelSignup.TabIndex = 5;
            this.labelSignup.Text = "Create Account";
            this.labelSignup.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.Location = new System.Drawing.Point(58, 56);
            this.labelSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(253, 30);
            this.labelSub.TabIndex = 6;
            this.labelSub.Text = "   Sign up to get started  ";
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSname.Location = new System.Drawing.Point(72, 109);
            this.labelSname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(121, 25);
            this.labelSname.TabIndex = 7;
            this.labelSname.Text = " Full Name    ";
            // 
            // labelSphone
            // 
            this.labelSphone.AutoSize = true;
            this.labelSphone.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSphone.Location = new System.Drawing.Point(72, 205);
            this.labelSphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSphone.Name = "labelSphone";
            this.labelSphone.Size = new System.Drawing.Size(65, 25);
            this.labelSphone.TabIndex = 8;
            this.labelSphone.Text = "Phone";
            // 
            // labelSuser
            // 
            this.labelSuser.AutoSize = true;
            this.labelSuser.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuser.Location = new System.Drawing.Point(72, 156);
            this.labelSuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSuser.Name = "labelSuser";
            this.labelSuser.Size = new System.Drawing.Size(96, 25);
            this.labelSuser.TabIndex = 9;
            this.labelSuser.Text = "Username";
            this.labelSuser.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelSpass
            // 
            this.labelSpass.AutoSize = true;
            this.labelSpass.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpass.Location = new System.Drawing.Point(72, 251);
            this.labelSpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpass.Name = "labelSpass";
            this.labelSpass.Size = new System.Drawing.Size(90, 25);
            this.labelSpass.TabIndex = 11;
            this.labelSpass.Text = "Password";
            // 
            // labelScpass
            // 
            this.labelScpass.AutoSize = true;
            this.labelScpass.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScpass.Location = new System.Drawing.Point(72, 299);
            this.labelScpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScpass.Name = "labelScpass";
            this.labelScpass.Size = new System.Drawing.Size(162, 25);
            this.labelScpass.TabIndex = 12;
            this.labelScpass.Text = "Confirm Password";
            // 
            // buttonSign
            // 
            this.buttonSign.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSign.Location = new System.Drawing.Point(131, 385);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(123, 37);
            this.buttonSign.TabIndex = 13;
            this.buttonSign.Text = "SIGN UP";
            this.buttonSign.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.labelSignup);
            this.panel1.Controls.Add(this.labelSub);
            this.panel1.Controls.Add(this.labelSname);
            this.panel1.Controls.Add(this.buttonSign);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.labelScpass);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelSuser);
            this.panel1.Controls.Add(this.labelSpass);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.labelSphone);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Location = new System.Drawing.Point(242, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 475);
            this.panel1.TabIndex = 14;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignupForm";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelSignup;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelSname;
        private System.Windows.Forms.Label labelSphone;
        private System.Windows.Forms.Label labelSuser;
        private System.Windows.Forms.Label labelSpass;
        private System.Windows.Forms.Label labelScpass;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Panel panel1;
    }
}