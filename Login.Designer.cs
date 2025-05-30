namespace E_Commerce
{
    partial class Login
    {
      
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


        private void InitializeComponent()
        {
            this.Username = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Username.Location = new System.Drawing.Point(827, 253);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(830, 277);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(262, 26);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password.Location = new System.Drawing.Point(827, 315);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(830, 342);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(262, 26);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(885, 462);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(154, 38);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.BackColor = System.Drawing.Color.Transparent;
            this.linkRegister.Location = new System.Drawing.Point(1154, 567);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(108, 20);
            this.linkRegister.TabIndex = 7;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register Here";
            this.linkRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(976, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Don't have an account ,";
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.Color.Transparent;
            this.Heading.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(719, 65);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(495, 58);
            this.Heading.TabIndex = 9;
            this.Heading.Text = "E-COMMERCE STORE\r\n";
            this.Heading.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.BackColor = System.Drawing.Color.Transparent;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(856, 170);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(196, 32);
            this.head.TabIndex = 10;
            this.head.Text = "USER LOGIN";
            this.head.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(831, 411);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(258, 28);
            this.cmbrole.TabIndex = 11;
            this.cmbrole.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(827, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Role";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Commerce.Properties.Resources._233;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.head);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Username);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion


        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label label1;
    }
}

