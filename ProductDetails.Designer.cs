namespace E_Commerce
{
    partial class ProductDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.ProductD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addtocart = new System.Windows.Forms.Button();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.Location = new System.Drawing.Point(289, 232);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(100, 20);
            this.lblProductDescription.TabIndex = 2;
            this.lblProductDescription.Text = "Description";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(289, 190);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(131, 20);
            this.lblProductPrice.TabIndex = 3;
            this.lblProductPrice.Text = "Product Price : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(288, 154);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(132, 20);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name :";
            // 
            // ProductD
            // 
            this.ProductD.AutoSize = true;
            this.ProductD.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductD.Location = new System.Drawing.Point(448, 20);
            this.ProductD.Name = "ProductD";
            this.ProductD.Size = new System.Drawing.Size(405, 52);
            this.ProductD.TabIndex = 5;
            this.ProductD.Text = "PRODUCT DETAILS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(716, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 361);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // addtocart
            // 
            this.addtocart.BackColor = System.Drawing.Color.Orange;
            this.addtocart.Location = new System.Drawing.Point(293, 468);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(121, 30);
            this.addtocart.TabIndex = 7;
            this.addtocart.Text = "Add to Cart";
            this.addtocart.UseVisualStyleBackColor = false;
            this.addtocart.Click += new System.EventHandler(this.addtocart_Click_1);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(293, 375);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(140, 26);
            this.txtquantity.TabIndex = 8;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Quantity";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.addtocart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductD);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.label2);
            this.Name = "ProductDetails";
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label ProductD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addtocart;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label1;
    }
}