using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace E_Commerce
{
    public partial class ShoppingCartForm : Form
    {
        private int userId; // Assume this is passed when the form is initialized

        public ShoppingCartForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadCartItems();
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            LoadCartItems();
        }

        // Load items into the DataGridView
        private void LoadCartItems()
        {
            try
            {
                string query = @"
                    SELECT ci.CARTITEMID, p.NAME AS ProductName, ci.QUANTITY, p.PRICE,
                           (ci.QUANTITY * p.PRICE) AS TotalPrice
                    FROM CARTITEM ci
                    JOIN PRODUCT p ON ci.PRODUCTID = p.PRODUCTID
                    WHERE ci.CARTID = (SELECT CARTID FROM SHOPPINGCART WHERE USERID = :UserId)";

                using (OracleConnection connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;"))
                {
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add("UserId", OracleDbType.Int32).Value = userId;

                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            DataTable cartTable = new DataTable();
                            adapter.Fill(cartTable);
                            dataGridView1.DataSource = cartTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cart items: " + ex.Message);
            }
        }

        // Method to add a new item to the shopping cart
        private void AddItemToCart(int productId, int quantity)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;"))
                {
                    connection.Open();

                    // Insert the new ShoppingCart record
                    string insertQuery = @"
                        INSERT INTO ShoppingCart (USERID, CARTID)
                        VALUES (:UserId, NULL)"; // CARTID will be set by the trigger

                    using (OracleCommand insertCmd = new OracleCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.Add("UserId", OracleDbType.Int32).Value = userId;
                        insertCmd.ExecuteNonQuery();
                    }

                    // Now insert into CARTITEM to associate the product with the cart
                    string cartItemInsertQuery = @"
                        INSERT INTO CARTITEM (CARTID, PRODUCTID, QUANTITY)
                        VALUES ((SELECT CARTID FROM ShoppingCart WHERE USERID = :UserId), :ProductId, :Quantity)";

                    using (OracleCommand cartItemCmd = new OracleCommand(cartItemInsertQuery, connection))
                    {
                        cartItemCmd.Parameters.Add("UserId", OracleDbType.Int32).Value = userId;
                        cartItemCmd.Parameters.Add("ProductId", OracleDbType.Int32).Value = productId;
                        cartItemCmd.Parameters.Add("Quantity", OracleDbType.Int32).Value = quantity;
                        cartItemCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Item added to cart successfully!");
                    LoadCartItems(); // Refresh the cart items
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item to cart: " + ex.Message);
            }
        }

        // Remove an item from the cart
        private void removeitem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int cartItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CARTITEMID"].Value);
                    int quantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["QUANTITY"].Value);
                    int productId = GetProductIdFromCartItem(cartItemId);

                    if (productId == -1)
                    {
                        MessageBox.Show("Unable to retrieve product information.");
                        return;
                    }

                    using (OracleConnection connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;"))
                    {
                        connection.Open();

                        // Step 1: Delete the item from the CARTITEM table
                        string deleteQuery = "DELETE FROM CARTITEM WHERE CARTITEMID = :CartItemId";

                        using (OracleCommand deleteCmd = new OracleCommand(deleteQuery, connection))
                        {
                            deleteCmd.Parameters.Add("CartItemId", OracleDbType.Int32).Value = cartItemId;
                            deleteCmd.ExecuteNonQuery();
                        }

                        // Step 2: Update the STOCKQUANTITY in the PRODUCT table
                        string updateStockQuery = @"
                            UPDATE PRODUCT
                            SET STOCKQUANTITY = STOCKQUANTITY + :Quantity
                            WHERE PRODUCTID = :ProductId";

                        using (OracleCommand updateCmd = new OracleCommand(updateStockQuery, connection))
                        {
                            updateCmd.Parameters.Add("Quantity", OracleDbType.Int32).Value = quantity;
                            updateCmd.Parameters.Add("ProductId", OracleDbType.Int32).Value = productId;
                            updateCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Item removed and stock updated successfully!");
                        LoadCartItems();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing item: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private int GetProductIdFromCartItem(int cartItemId)
        {
            int productId = -1;
            try
            {
                string query = "SELECT PRODUCTID FROM CARTITEM WHERE CARTITEMID = :CartItemId";

                using (OracleConnection connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;"))
                {
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add("CartItemId", OracleDbType.Int32).Value = cartItemId;
                        connection.Open();

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            productId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving Product ID: " + ex.Message);
            }
            return productId;
        }

        // Update cart quantities
        private void Updatecart_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["QUANTITY"].Value != null)
                    {
                        int cartItemId = Convert.ToInt32(row.Cells["CARTITEMID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["QUANTITY"].Value);

                        string updateQuery = @"
                            UPDATE CARTITEM 
                            SET QUANTITY = :Quantity
                            WHERE CARTITEMID = :CartItemId";

                        using (OracleConnection connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;"))
                        {
                            using (OracleCommand cmd = new OracleCommand(updateQuery, connection))
                            {
                                cmd.Parameters.Add("Quantity", OracleDbType.Int32).Value = quantity;
                                cmd.Parameters.Add("CartItemId", OracleDbType.Int32).Value = cartItemId;

                                connection.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Cart updated successfully!");
                LoadCartItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating cart: " + ex.Message);
            }
        }

        // Proceed to checkout
        private void checkout_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalAmount = GetTotalAmountFromCart();
                OrderProcessingForm orderForm = new OrderProcessingForm(userId, totalAmount);
                orderForm.Show();
                this.Close(); // Close the current form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error proceeding to checkout: " + ex.Message);
            }
        }

        // Helper method to calculate the total amount from the cart
        private decimal GetTotalAmountFromCart()
        {
            decimal totalAmount = 0.0m;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["PRICE"].Value != null && row.Cells["QUANTITY"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["PRICE"].Value);
                    int quantity = Convert.ToInt32(row.Cells["QUANTITY"].Value);
                    totalAmount += price * quantity;
                }
            }

            return totalAmount;
        }

        // Handle cell edits (e.g., quantity changes)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "QUANTITY" && e.RowIndex >= 0)
            {
                try
                {
                    int cartItemId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CARTITEMID"].Value);
                    int newQuantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["QUANTITY"].Value);

                    // Update the cart quantity
                    string updateCartQuery = @"
                        UPDATE CARTITEM
                        SET QUANTITY = :Quantity
                        WHERE CARTITEMID = :CartItemId";

                    using (OracleConnection connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;"))
                    {
                        using (OracleCommand cmd = new OracleCommand(updateCartQuery, connection))
                        {
                            cmd.Parameters.Add("Quantity", OracleDbType.Int32).Value = newQuantity;
                            cmd.Parameters.Add("CartItemId", OracleDbType.Int32).Value = cartItemId;

                            connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Quantity updated successfully!");
                    LoadCartItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating quantity: " + ex.Message);
                }
            }
        }

        // Example button click to add an item to the cart (you may need to create a button for this)
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Example productId and quantity, replace these with actual values from your UI
            int productId = 1; // Replace with actual product ID
            int quantity = 1;  // Replace with actual quantity

            AddItemToCart(productId, quantity);
        }
    }
}