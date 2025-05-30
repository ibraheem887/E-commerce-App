using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace E_Commerce
{
    public partial class OrderSummary : Form
    {
        private int orderId;
        private int userId;
        private decimal totalAmount;

        public OrderSummary(int orderId, int userId, decimal totalAmount)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.userId = userId;
            this.totalAmount = totalAmount;
            LoadCartItems();
        }

        // Loading cart items into the DataGridView
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

        // This event will show the total, tax, and the final amount on form load


        // When the user confirms the payment
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            OracleConnection connection = null;
            OracleTransaction transaction = null;
            try
            {
                // Connect to the database
                connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;");
                connection.Open();
                transaction = connection.BeginTransaction();

                // Insert into the PAYMENT table
                string paymentQuery = @"
            INSERT INTO PAYMENT (PAYMENTDATE, AMOUNT, PAYMENTMETHOD, ORDERID)
            VALUES (SYSDATE, :Amount, :PaymentMethod, :OrderId)";

                using (OracleCommand cmd = new OracleCommand(paymentQuery, connection))
                {
                    // Bind parameters
                    decimal finalAmount = totalAmount + (totalAmount * 0.1m) - (totalAmount * 0.05m); // Tax and discount applied
                    cmd.Parameters.Add("Amount", OracleDbType.Decimal).Value = finalAmount;
                    cmd.Parameters.Add("PaymentMethod", OracleDbType.Varchar2).Value = cmbpaymnet.SelectedItem.ToString();
                    cmd.Parameters.Add("OrderId", OracleDbType.Int32).Value = orderId;

                    cmd.ExecuteNonQuery();
                }

                // Remove cart items for the user after payment (if no foreign key prevents deletion)
                string removeCartItemsQuery = @"
            DELETE FROM CARTITEM WHERE CARTID = (SELECT CARTID FROM SHOPPINGCART WHERE USERID = :UserId)";
                using (OracleCommand cmd = new OracleCommand(removeCartItemsQuery, connection))
                {
                    cmd.Parameters.Add("UserId", OracleDbType.Int32).Value = userId;
                    cmd.ExecuteNonQuery();
                }

                // Commit the transaction
                transaction.Commit();

                MessageBox.Show("Payment confirmed! Cart items removed.");

                // Close the current form and possibly open another form or navigate to the next step
                
            }
            catch (OracleException ex)
            {
                // Handle specific Oracle exceptions
                if (ex.Number == 2292) // ORA-02292: integrity constraint violated - child record found
                {
                    MessageBox.Show("Cannot delete cart items because of a foreign key constraint violation.");
                }
                else
                {
                    MessageBox.Show("Error processing the payment: " + ex.Message);
                }

                // Rollback the transaction in case of an error
                if (transaction != null)
                    transaction.Rollback();
            }
            finally
            {
                // Ensure the connection is closed
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            // Create an instance of the ProductCatalogForm and pass the userId
            ProductCatalogForm productCatalog = new ProductCatalogForm(userId);

            // Show the ProductCatalogForm
            productCatalog.Show();

            // Optionally, you can close the current form if needed
            this.Close();
        }

       
    }
}
