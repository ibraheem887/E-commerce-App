using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace E_Commerce
{
    public partial class OrderTrackingForm : Form
    {
        private int userId; // We'll set this from the previous form when navigating here

        // Constructor to receive the userId from previous form
        public OrderTrackingForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;  // Store the userId
            LoadOrderData();       // Load orders for the specific user
        }

        // Method to load orders for the given user
        private void LoadOrderData()
        {
            try
            {
                string query = @"
                    SELECT o.ORDERID, o.ORDERDATE, o.TOTALAMOUNT, p.STATUS
                    FROM ORDERS o
                    JOIN PAYMENT p ON o.ORDERID = p.ORDERID
                    WHERE o.USERID = :UserId";

                using (OracleConnection connection = new OracleConnection("User Id=project;Password=project;Data Source=//localhost:1521/XE;"))
                {
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add("UserId", OracleDbType.Int32).Value = userId;

                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            DataTable ordersTable = new DataTable();
                            adapter.Fill(ordersTable);
                            // Bind the data to the DataGridView
                            myorders.DataSource = ordersTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        // Handle the Home button click event to navigate to the Product Catalog page
        private void home_Click(object sender, EventArgs e)
        {
            // You can show the Product Catalog Form here
            // Assuming you have a ProductCatalogForm, you can instantiate and show it like this:
            ProductCatalogForm productCatalog = new ProductCatalogForm(userId); // Passing userId if needed
            productCatalog.Show();
            this.Close();  // Close the OrderTrackingForm
        }

     
    }
}
