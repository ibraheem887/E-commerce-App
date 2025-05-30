namespace E_Commerce
{
    partial class InventoryManagementForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.des_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.image_txt = new System.Windows.Forms.TextBox();
            this.image_url = new System.Windows.Forms.Button();
            this.textprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.homme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management";
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top; // Anchor center horizontally

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(812, 408);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);

            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(938, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(252, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right; // Anchor to the bottom

            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Red;
            this.btndel.Location = new System.Drawing.Point(938, 510);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(252, 33);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Delete Prodcut";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            this.btndel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbcategory);
            this.groupBox1.Controls.Add(this.des_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.image_txt);
            this.groupBox1.Controls.Add(this.image_url);
            this.groupBox1.Controls.Add(this.textprice);
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(867, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 273);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right; // Anchor to the right

            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(124, 79);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(234, 28);
            this.cmbcategory.TabIndex = 13;
            // 
            // des_txt
            // 
            this.des_txt.Location = new System.Drawing.Point(124, 233);
            this.des_txt.Name = "des_txt";
            this.des_txt.Size = new System.Drawing.Size(234, 26);
            this.des_txt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Image_url";
            // 
            // image_txt
            // 
            this.image_txt.Location = new System.Drawing.Point(124, 195);
            this.image_txt.Name = "image_txt";
            this.image_txt.Size = new System.Drawing.Size(193, 26);
            this.image_txt.TabIndex = 9;
            // 
            // image_url
            // 
            this.image_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.image_url.Location = new System.Drawing.Point(319, 190);
            this.image_url.Name = "image_url";
            this.image_url.Size = new System.Drawing.Size(45, 34);
            this.image_url.TabIndex = 8;
            this.image_url.Text = "Image";
            this.image_url.UseVisualStyleBackColor = false;
            this.image_url.Click += new System.EventHandler(this.image_url_);
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(124, 116);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(234, 26);
            this.textprice.TabIndex = 7;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(124, 155);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(234, 26);
            this.txtquantity.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(125, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(234, 26);
            this.name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // homme
            // 
            this.homme.BackColor = System.Drawing.Color.Orange;
            this.homme.Location = new System.Drawing.Point(27, 22);
            this.homme.Name = "homme";
            this.homme.Size = new System.Drawing.Size(139, 34);
            this.homme.TabIndex = 7;
            this.homme.Text = "Home";
            this.homme.UseVisualStyleBackColor = false;
            this.homme.Click += new System.EventHandler(this.homme_Click);
            this.homme.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left; // Anchor to top-left corner
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.homme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "InventoryManagementForm";
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button homme;
        private System.Windows.Forms.Button image_url;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox image_txt;
        private System.Windows.Forms.TextBox des_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcategory;
    }
}