using System;
using System.Windows.Forms;

namespace E_Commerce
{
    partial class ProductCatalogForm
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
            this.components = new System.ComponentModel.Container();
            this.ProductCatalog = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dbdata = new System.Windows.Forms.DataGridView();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product = new E_Commerce.product();
            this.pRODUCTTableAdapter = new E_Commerce.productTableAdapters.PRODUCTTableAdapter();
            this.grpPriceRange = new System.Windows.Forms.GroupBox();
            this.Minprice = new System.Windows.Forms.Label();
            this.Maxprice = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.viewcart = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.grpPriceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCatalog
            // 
            this.ProductCatalog.AutoSize = true;
            this.ProductCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCatalog.Location = new System.Drawing.Point(453, 21);
            this.ProductCatalog.Name = "ProductCatalog";
            this.ProductCatalog.Size = new System.Drawing.Size(392, 40);
            this.ProductCatalog.TabIndex = 0;
            this.ProductCatalog.Text = "PRODUCT CATALOG";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(949, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(233, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 20;
            this.cmbCategory.Location = new System.Drawing.Point(411, 112);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(158, 28);
            this.cmbCategory.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1182, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dbdata
            // 
            this.dbdata.AllowUserToAddRows = false;
            this.dbdata.AllowUserToDeleteRows = false;
            this.dbdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbdata.AutoGenerateColumns = true;
            this.dbdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbdata.DataSource = this.pRODUCTBindingSource;
            this.dbdata.Location = new System.Drawing.Point(49, 171);
            this.dbdata.Name = "dbdata";
            this.dbdata.RowHeadersWidth = 62;
            this.dbdata.RowTemplate.Height = 80;
            this.dbdata.Size = new System.Drawing.Size(1173, 413);
            this.dbdata.TabIndex = 6;
            this.dbdata.CellContentClick += new DataGridViewCellEventHandler(this.dbdata_CellContentClick);
            // product
            // 
            this.product.DataSetName = "product";
            this.product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // grpPriceRange
            // 
            this.grpPriceRange.Controls.Add(this.Minprice);
            this.grpPriceRange.Controls.Add(this.Maxprice);
            this.grpPriceRange.Controls.Add(this.max);
            this.grpPriceRange.Controls.Add(this.min);
            this.grpPriceRange.Location = new System.Drawing.Point(21, 92);
            this.grpPriceRange.Name = "grpPriceRange";
            this.grpPriceRange.Size = new System.Drawing.Size(369, 56);
            this.grpPriceRange.TabIndex = 7;
            this.grpPriceRange.TabStop = false;
            this.grpPriceRange.Text = "Price Range";
            // 
            // Minprice
            // 
            this.Minprice.Location = new System.Drawing.Point(204, 22);
            this.Minprice.Name = "Minprice";
            this.Minprice.Size = new System.Drawing.Size(36, 26);
            this.Minprice.TabIndex = 0;
            this.Minprice.Text = "min";
            this.Minprice.Click += new System.EventHandler(this.Minprice_Click);
            // 
            // Maxprice
            // 
            this.Maxprice.Location = new System.Drawing.Point(15, 28);
            this.Maxprice.Name = "Maxprice";
            this.Maxprice.Size = new System.Drawing.Size(66, 20);
            this.Maxprice.TabIndex = 1;
            this.Maxprice.Text = "max";
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(243, 21);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(120, 26);
            this.max.TabIndex = 2;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(78, 24);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(120, 26);
            this.min.TabIndex = 3;
            // 
            // viewcart
            // 
            this.viewcart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewcart.Location = new System.Drawing.Point(1128, 21);
            this.viewcart.Name = "viewcart";
            this.viewcart.Size = new System.Drawing.Size(129, 40);
            this.viewcart.TabIndex = 8;
            this.viewcart.Text = "View Cart";
            this.viewcart.UseVisualStyleBackColor = true;
            this.viewcart.Click += new System.EventHandler(this.viewcart_Click);
            // 
            // orders
            // 
            this.orders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orders.Location = new System.Drawing.Point(983, 21);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(129, 40);
            this.orders.TabIndex = 9;
            this.orders.Text = "Orders";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // ProductCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1270, 596);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.viewcart);
            this.Controls.Add(this.grpPriceRange);
            this.Controls.Add(this.dbdata);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ProductCatalog);
            this.Name = "ProductCatalogForm";
            this.Text = "ProductCatalogForm";
            this.Load += new System.EventHandler(this.ProductCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.grpPriceRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Label ProductCatalog;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dbdata;
        private product product;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private productTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.GroupBox grpPriceRange;
        private System.Windows.Forms.NumericUpDown max;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.Label Maxprice;
        private System.Windows.Forms.Label Minprice;
        private Button viewcart;
        private Button orders;
    }
}