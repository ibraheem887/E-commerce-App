namespace E_Commerce
{
    partial class OrderProcessingForm
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
            this.cart = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShippingDetails = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.orderp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ShippingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cart
            // 
            this.cart.AutoSize = true;
            this.cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart.Location = new System.Drawing.Point(588, 153);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(111, 25);
            this.cart.TabIndex = 0;
            this.cart.Text = "Cart Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(593, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(665, 326);
            this.dataGridView1.TabIndex = 1;
           
           
            // 
            // ShippingDetails
            // 
            this.ShippingDetails.Controls.Add(this.textBox3);
            this.ShippingDetails.Controls.Add(this.textBox2);
            this.ShippingDetails.Controls.Add(this.textBox1);
            this.ShippingDetails.Controls.Add(this.contact);
            this.ShippingDetails.Controls.Add(this.Adress);
            this.ShippingDetails.Controls.Add(this.name);
            this.ShippingDetails.Location = new System.Drawing.Point(70, 260);
            this.ShippingDetails.Name = "ShippingDetails";
            this.ShippingDetails.Size = new System.Drawing.Size(486, 131);
            this.ShippingDetails.TabIndex = 2;
            this.ShippingDetails.TabStop = false;
            this.ShippingDetails.Text = "Shipping Details";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(347, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 26);
            this.textBox1.TabIndex = 3;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(15, 97);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(93, 20);
            this.contact.TabIndex = 2;
            this.contact.Text = "Contact No.";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(15, 64);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(68, 20);
            this.Adress.TabIndex = 1;
            this.Adress.Text = "Address";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(15, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(51, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.LawnGreen;
            this.order.Location = new System.Drawing.Point(214, 440);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(202, 43);
            this.order.TabIndex = 7;
            this.order.Text = "Place Order";
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // orderp
            // 
            this.orderp.AutoSize = true;
            this.orderp.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderp.Location = new System.Drawing.Point(398, 22);
            this.orderp.Name = "orderp";
            this.orderp.Size = new System.Drawing.Size(441, 52);
            this.orderp.TabIndex = 9;
            this.orderp.Text = "ORDER PROCESSING";
            // 
            // OrderProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.orderp);
            this.Controls.Add(this.order);
            this.Controls.Add(this.ShippingDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cart);
            this.Name = "OrderProcessingForm";
            this.Text = "OrderProcessingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ShippingDetails.ResumeLayout(false);
            this.ShippingDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ShippingDetails;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label orderp;
    }
}