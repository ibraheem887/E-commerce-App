using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace E_Commerce.DAL
{
    public class ProductDAL
    {
        private string connectionString;

        public ProductDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetProducts()
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PRODUCTID, NAME, PRICE, CATEGORYID, STOCKQUANTITY, IMAGEURL FROM PRODUCT";
                using (var da = new OracleDataAdapter(query, connection))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void InsertProduct(string name, string description, decimal price, string categoryId, int stockQuantity, string imageUrl)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO PRODUCT (NAME, DESCRIPTION, PRICE, CATEGORYID, STOCKQUANTITY, IMAGEURL) 
                                 VALUES (:Name, :Description, :Price, :CategoryID, :StockQuantity, :ImageURL)";
                using (var cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(new OracleParameter("Name", name));
                    cmd.Parameters.Add(new OracleParameter("Description", description));
                    cmd.Parameters.Add(new OracleParameter("Price", price));
                    cmd.Parameters.Add(new OracleParameter("CategoryID", categoryId));
                    cmd.Parameters.Add(new OracleParameter("StockQuantity", stockQuantity));
                    cmd.Parameters.Add(new OracleParameter("ImageURL", imageUrl));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int productId)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM PRODUCT WHERE PRODUCTID = :ProductID";
                using (var cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(new OracleParameter("ProductID", productId));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(int productId, string name, decimal price, int stockQuantity, string categoryId)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE PRODUCT SET NAME = :Name, PRICE = :Price, 
                                 STOCKQUANTITY = :StockQuantity, CATEGORYID = :CategoryID
                                 WHERE PRODUCTID = :ProductID";
                using (var cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(new OracleParameter("Name", name));
                    cmd.Parameters.Add(new OracleParameter("Price", price));
                    cmd.Parameters.Add(new OracleParameter("StockQuantity", stockQuantity));
                    cmd.Parameters.Add(new OracleParameter("CategoryID", categoryId));
                    cmd.Parameters.Add(new OracleParameter("ProductID", productId));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetCategories()
        {
            using (var connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CATEGORYID, CATEGORYNAME FROM CATEGORY";
                using (var cmd = new OracleCommand(query, connection))
                {
                    var da = new OracleDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
