namespace E_Commerce
{
    partial class RegisterForm
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
            this.head = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.ROLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.BackColor = System.Drawing.Color.Transparent;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(783, 121);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(345, 32);
            this.head.TabIndex = 19;
            this.head.Text = "USER REGISTERATION";
            this.head.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.Color.Transparent;
            this.Heading.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(716, 43);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(495, 58);
            this.Heading.TabIndex = 18;
            this.Heading.Text = "E-COMMERCE STORE\r\n";
            this.Heading.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(967, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Already have an account ,";
            this.label2.Anchor =  System.Windows.Forms.AnchorStyles.Right;
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLogin.Location = new System.Drawing.Point(1165, 567);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(87, 20);
            this.linkLogin.TabIndex = 16;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login Here";
            this.linkLogin.Anchor =  System.Windows.Forms.AnchorStyles.Right;
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(882, 402);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegister.Size = new System.Drawing.Size(154, 38);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(696, 295);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 26);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Anchor =  System.Windows.Forms.AnchorStyles.Right;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password.Location = new System.Drawing.Point(692, 269);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 13;
            this.Password.Text = "Password";
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(695, 232);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 26);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Username.Location = new System.Drawing.Point(692, 205);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 11;
            this.Username.Text = "Username";
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(696, 357);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(233, 26);
            this.textEmail.TabIndex = 23;
            this.textEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Phone.Location = new System.Drawing.Point(969, 334);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(55, 20);
            this.Phone.TabIndex = 20;
            this.Phone.Text = "Phone";
            this.Phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(971, 357);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(233, 26);
            this.textPhone.TabIndex = 27;
            this.textPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(693, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email";
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(971, 232);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(234, 26);
            this.txtname.TabIndex = 29;
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.Location = new System.Drawing.Point(967, 209);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 30;
            this.name.Text = "Name";
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(971, 295);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(234, 28);
            this.cmbrole.TabIndex = 31;
            this.cmbrole.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // ROLE
            // 
            this.ROLE.AutoSize = true;
            this.ROLE.BackColor = System.Drawing.Color.Transparent;
            this.ROLE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ROLE.Location = new System.Drawing.Point(967, 272);
            this.ROLE.Name = "ROLE";
            this.ROLE.Size = new System.Drawing.Size(42, 20);
            this.ROLE.TabIndex = 32;
            this.ROLE.Text = "Role";
            this.ROLE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Commerce.Properties.Resources._233;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.ROLE);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.head);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Username);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label ROLE;
    }
}
