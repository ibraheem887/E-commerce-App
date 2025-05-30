using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace E_Commerce
{
    public partial class OrderProcessingForm : Form
    {
        private int userId;
        private decimal totalAmount;

        public OrderProcessingForm(int userId, decimal totalAmount)
        {
            InitializeComponent();
            this.userId = userId; // Store the userId passed from the ShoppingCartForm
            this.totalAmount = totalAmount;
            LoadCartItems();
        }
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

        private void order_Click(object sender, EventArgs e)
        {
            OracleTransaction transaction = null;
            OracleConnection connection = null;
            int orderId = 0;  // Declare orderId outside the using block so it can be accessed later
            try
            {
                connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;");
                connection.Open();  // Ensure the connection is open before starting the transaction
                transaction = connection.BeginTransaction(); // Start the transaction

                // Step 1: Insert the order into the ORDERS table (using sequence for ORDERID)
                string orderQuery = @"
        INSERT INTO ORDERS (ORDERID, USERID, ORDERDATE, TOTALAMOUNT)
        VALUES (order_seq.NEXTVAL, :UserId, SYSDATE, :TotalAmount) RETURNING ORDERID INTO :OrderId";

                using (OracleCommand cmd = new OracleCommand(orderQuery, connection))
                {
                    // Bind parameters
                    cmd.Parameters.Add("UserId", OracleDbType.Int32).Value = userId;
                    cmd.Parameters.Add("TotalAmount", OracleDbType.Decimal).Value = totalAmount;

                    // Add an output parameter to get the generated ORDERID
                    OracleParameter orderIdParam = new OracleParameter("OrderId", OracleDbType.Int32);
                    orderIdParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(orderIdParam);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Retrieve the orderId from the output parameter
                    orderId = Convert.ToInt32(orderIdParam.Value.ToString()); // Ensure proper conversion
                }

                // Commit the transaction
                transaction.Commit();

                MessageBox.Show("Order placed successfully!");

                // Open the OrderSummaryForm and pass the orderId and userId
                OrderSummary orderSummary = new OrderSummary(orderId, userId, totalAmount);
                orderSummary.Show();

                // Close the current form
                this.Close();
            }
            catch (Exception ex)
            {
                // Rollback the transaction if an error occurs
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show("Error processing the order: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is properly closed
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


    }
}
