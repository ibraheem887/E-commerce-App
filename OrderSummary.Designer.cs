namespace E_Commerce
{
    partial class OrderSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbpaymnet = new System.Windows.Forms.ComboBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Summary";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(911, 287);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payment method";
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // cmbpaymnet
            // 
            this.cmbpaymnet.FormattingEnabled = true;
            this.cmbpaymnet.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card"});
            this.cmbpaymnet.Location = new System.Drawing.Point(1006, 268);
            this.cmbpaymnet.Name = "cmbpaymnet";
            this.cmbpaymnet.Size = new System.Drawing.Size(189, 28);
            this.cmbpaymnet.TabIndex = 6;
            this.cmbpaymnet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.Chartreuse;
            this.btnconfirm.Location = new System.Drawing.Point(1006, 437);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(210, 48);
            this.btnconfirm.TabIndex = 9;
            this.btnconfirm.Text = "Confirm Payment";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            this.btnconfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Orange;
            this.home.Location = new System.Drawing.Point(27, 28);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(129, 48);
            this.home.TabIndex = 10;
            this.home.Text = "home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            this.home.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.cmbpaymnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.home);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "OrderSummary";
            this.Text = "OrderSummary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbpaymnet;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button home;
    }
}
