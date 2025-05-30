using E_Commerce.BLL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class InventoryManagementForm : Form
    {
        private ProductBLL productBLL;
        private string selectedImagePath;

        public InventoryManagementForm()
        {
            InitializeComponent();
            string connectionString = "DATA SOURCE=//localhost:1521/XE;USER ID=project;PASSWORD=project"; // Use actual connection string
            productBLL = new ProductBLL(connectionString);
            LoadCategories(); // Load categories into ComboBox
            LoadProducts();   // Load products into DataGridView
        }

        private void image_url_(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                image_txt.Text = selectedImagePath; // Display the file path in the TextBox
            }
        }

        private void LoadProducts()
        {
            try
            {
                DataTable dt = productBLL.GetProducts();
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("No products found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            try
            {
                DataTable dt = productBLL.GetCategories();
                cmbcategory.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbcategory.Items.Add(new ComboBoxItem
                    {
                        Text = row["CATEGORYNAME"].ToString(),
                        Value = row["CATEGORYID"].ToString()
                    });

                    if (cmbcategory.Items.Count > 0)
                    {
                        cmbcategory.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = name.Text;
            string description = des_txt.Text;
            decimal price;
            int stockQuantity;

            if (!decimal.TryParse(textprice.Text, out price) || !int.TryParse(txtquantity.Text, out stockQuantity))
            {
                MessageBox.Show("Invalid price or stock quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string categoryID = ((ComboBoxItem)cmbcategory.SelectedItem)?.Value;

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(categoryID) || string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please fill all required fields and select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imageFileName = Path.GetFileName(selectedImagePath);
            string imageDestinationPath = Path.Combine(@"C:\ECommerceImages", imageFileName);
            if (!Directory.Exists(@"C:\ECommerceImages"))
            {
                Directory.CreateDirectory(@"C:\ECommerceImages");
            }
            File.Copy(selectedImagePath, imageDestinationPath, true);

            productBLL.AddProduct(productName, description, price, categoryID, stockQuantity, imageDestinationPath);
            MessageBox.Show("Product added successfully!");
            LoadProducts();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PRODUCTID"].Value);
            productBLL.RemoveProduct(productId);
            MessageBox.Show("Product deleted successfully!");
            LoadProducts();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["PRODUCTID"].Value);
                string productName = row.Cells["NAME"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["PRICE"].Value);
                int stockQuantity = Convert.ToInt32(row.Cells["STOCKQUANTITY"].Value);
                string categoryId = row.Cells["CATEGORYID"].Value.ToString();

                productBLL.UpdateProduct(productId, productName, price, stockQuantity, categoryId);
                MessageBox.Show("Product updated successfully!");
                LoadProducts();
            }
        }

        private void homme_Click(object sender, EventArgs e)
        {

        }
    }
}
