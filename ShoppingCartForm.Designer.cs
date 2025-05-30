namespace E_Commerce
{
    partial class ShoppingCartForm
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
            this.ShoppingCart = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.removeitem = new System.Windows.Forms.Button();
            this.checkout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.AutoSize = true;
            this.ShoppingCart.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCart.Location = new System.Drawing.Point(458, 18);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Size = new System.Drawing.Size(364, 52);
            this.ShoppingCart.TabIndex = 0;
            this.ShoppingCart.Text = "SHOPPING CART";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(812, 334);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // removeitem
            // 
            this.removeitem.BackColor = System.Drawing.Color.Red;
            this.removeitem.Location = new System.Drawing.Point(939, 301);
            this.removeitem.Name = "removeitem";
            this.removeitem.Size = new System.Drawing.Size(274, 40);
            this.removeitem.TabIndex = 3;
            this.removeitem.Text = "Remove Item";
            this.removeitem.UseVisualStyleBackColor = false;
            this.removeitem.Click += new System.EventHandler(this.removeitem_Click);
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.Color.OliveDrab;
            this.checkout.Location = new System.Drawing.Point(939, 367);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(274, 34);
            this.checkout.TabIndex = 5;
            this.checkout.Text = "Proceed to Checkout";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.removeitem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShoppingCart);
            this.Name = "ShoppingCartForm";
            this.Text = "ShoppingCartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShoppingCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeitem;
        private System.Windows.Forms.Button checkout;
    }
}