using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using E_Commerce.BLL;

namespace E_Commerce
{
    public partial class ProductCatalogForm : Form
    {
        private readonly ProductCatalogBLL productBLL;
        private int userId;

        public ProductCatalogForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            productBLL = new ProductCatalogBLL();
        }

        // Load categories into the combo box
        private void LoadCategories()
        {
            try
            {
                DataTable categories = productBLL.GetCategories();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.SelectedIndex = 0; // Default to "All"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        // Load products with optional search query and category filter
        private void LoadProducts(string searchQuery, string categoryId = "")
        {
            try
            {
                DataTable products = productBLL.GetProducts(searchQuery, categoryId);

                // Check if ImagePath column exists
                if (!products.Columns.Contains("ImagePath"))
                {
                    MessageBox.Show("Error: ImagePath column is missing!");
                    return;
                }

                // Populate DataGridView
                dbdata.DataSource = products;

                // Add Image column
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                {
                    Name = "Image",
                    HeaderText = "Product Image",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dbdata.Columns.Add(imageColumn);

                // Loop through rows to set images
                foreach (DataGridViewRow row in dbdata.Rows)
                {
                    string imagePath = row.Cells["ImagePath"]?.Value?.ToString();
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        string fullPath = Path.Combine(Application.StartupPath, imagePath);
                        if (File.Exists(fullPath))
                        {
                            row.Cells["Image"].Value = Image.FromFile(fullPath);
                        }
                    }
                }

                // Set column display order
                dbdata.Columns["PRODUCTID"].DisplayIndex = 0;
                dbdata.Columns["ProductName"].DisplayIndex = 1;
                dbdata.Columns["CATEGORYNAME"].DisplayIndex = 2;
                dbdata.Columns["Description"].DisplayIndex = 3;
                dbdata.Columns["Price"].DisplayIndex = 4;
                dbdata.Columns["Image"].DisplayIndex = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        // Form Load event
        private void ProductCatalogForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts(""); // Load all products initially
        }

        // Filter products by category
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategoryId = cmbCategory.SelectedValue?.ToString();
            LoadProducts(txtSearch.Text.Trim(), selectedCategoryId);
        }

        // Search button click handler
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategoryId = cmbCategory.SelectedValue?.ToString();
            LoadProducts(txtSearch.Text.Trim(), selectedCategoryId);
        }

        // Real-time search handler
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string selectedCategoryId = cmbCategory.SelectedValue?.ToString();
            LoadProducts(txtSearch.Text.Trim(), selectedCategoryId);
        }

        // Open ProductDetails form
        private void dbdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dbdata.Rows[e.RowIndex].Cells["PRODUCTID"].Value != null)
            {
                int productId = Convert.ToInt32(dbdata.Rows[e.RowIndex].Cells["PRODUCTID"].Value);
                ProductDetails productDetails = new ProductDetails(productId);
                productDetails.Show();
            }
        }

        // View cart event
        private void viewcart_Click(object sender, EventArgs e)
        {
            ShoppingCartForm cartForm = new ShoppingCartForm(userId);
            cartForm.ShowDialog();
        }

        // Orders event
        private void orders_Click(object sender, EventArgs e)
        {
            OrderTrackingForm orderTrackingForm = new OrderTrackingForm(userId);
            orderTrackingForm.Show();
            this.Close();
        }

        private void Minprice_Click(object sender, EventArgs e)
        {

        }
    }
}
