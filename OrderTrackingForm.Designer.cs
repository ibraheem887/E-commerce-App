namespace E_Commerce
{
    partial class OrderTrackingForm
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
            this.myorders = new System.Windows.Forms.DataGridView();
            this.home = new System.Windows.Forms.Button();
            this.tracking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myorders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Orders";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            // 
            // myorders
            // 
            this.myorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myorders.Location = new System.Drawing.Point(88, 233);
            this.myorders.Name = "myorders";
            this.myorders.RowHeadersWidth = 62;
            this.myorders.RowTemplate.Height = 28;
            this.myorders.Size = new System.Drawing.Size(663, 330);
            this.myorders.TabIndex = 2;
            this.myorders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Orange;
            this.home.Location = new System.Drawing.Point(24, 30);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(98, 35);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            this.home.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            // 
            // tracking
            // 
            this.tracking.AutoSize = true;
            this.tracking.BackColor = System.Drawing.Color.Gold;
            this.tracking.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracking.Location = new System.Drawing.Point(435, 13);
            this.tracking.Name = "tracking";
            this.tracking.Size = new System.Drawing.Size(394, 52);
            this.tracking.TabIndex = 4;
            this.tracking.Text = "ORDER TRACKING";
            this.tracking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // OrderTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.tracking);
            this.Controls.Add(this.home);
            this.Controls.Add(this.myorders);
            this.Controls.Add(this.label1);
            this.Name = "OrderTrackingForm";
            this.Text = "Order Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.myorders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView myorders;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label tracking;
    }
}
