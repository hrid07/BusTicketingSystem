namespace BusTicketingSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelSub = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.labelSign = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.AutoSize = true;
            this.panelLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.panelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogin.BackgroundImage")));
            this.panelLogin.Controls.Add(this.labelSign);
            this.panelLogin.Controls.Add(this.buttonSign);
            this.panelLogin.Controls.Add(this.textPass);
            this.panelLogin.Controls.Add(this.textName);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.labelSub);
            this.panelLogin.Controls.Add(this.labelTitle);
            this.panelLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogin.Location = new System.Drawing.Point(730, 58);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(440, 583);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.BackColor = System.Drawing.Color.Transparent;
            this.labelSub.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSub.Location = new System.Drawing.Point(130, 73);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(199, 31);
            this.labelSub.TabIndex = 1;
            this.labelSub.Text = "Log in to continue";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTitle.Location = new System.Drawing.Point(69, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(321, 54);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Welcome Back !";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Transparent;
            this.labelUsername.Location = new System.Drawing.Point(120, 131);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(104, 28);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Transparent;
            this.labelPassword.Location = new System.Drawing.Point(120, 224);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 28);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(148, 347);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(174, 38);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(177, 176);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(185, 34);
            this.textName.TabIndex = 5;
            // 
            // textPass
            // 
            this.textPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.Location = new System.Drawing.Point(177, 265);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(185, 34);
            this.textPass.TabIndex = 6;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // buttonSign
            // 
            this.buttonSign.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonSign.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSign.Location = new System.Drawing.Point(148, 496);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(174, 38);
            this.buttonSign.TabIndex = 7;
            this.buttonSign.Text = "Sign Up";
            this.buttonSign.UseVisualStyleBackColor = false;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.BackColor = System.Drawing.Color.Transparent;
            this.labelSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSign.ForeColor = System.Drawing.Color.Transparent;
            this.labelSign.Location = new System.Drawing.Point(131, 423);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(216, 28);
            this.labelSign.TabIndex = 8;
            this.labelSign.Text = "Don\'t have an account?";
            this.labelSign.Click += new System.EventHandler(this.labelSign_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Ticketing System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.TextBox textPass;
    }
}

