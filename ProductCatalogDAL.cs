using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace E_Commerce
{
    public class ProductCatalogDAL
    {
        private readonly OracleConnection connection;

        public ProductCatalogDAL()
        {
            DBConnection dbConnection = new DBConnection();
            connection = dbConnection.GetConnection();
        }

        // Get Categories from Database
        public DataTable GetCategories()
        {
            DataTable categories = new DataTable();
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = "SELECT CATEGORYID, CATEGORYNAME FROM CATEGORY";
                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        categories.Columns.Add("CategoryName", typeof(string));
                        categories.Columns.Add("CategoryId", typeof(string));  // Use string for handling "All" case

                        // Add an "All" option for no filtering
                        DataRow allRow = categories.NewRow();
                        allRow["CategoryName"] = "All";
                        allRow["CategoryId"] = "All";  // Store "All" as a string
                        categories.Rows.Add(allRow);

                        // Load categories from the database
                        while (reader.Read())
                        {
                            DataRow row = categories.NewRow();
                            row["CategoryName"] = reader["CATEGORYNAME"].ToString();
                            row["CategoryId"] = reader["CATEGORYID"].ToString();  // Store as string
                            categories.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading categories: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return categories;
        }

        // Get Products from Database
        public DataTable GetProducts(string searchQuery, string categoryId = "")
        {
            DataTable products = new DataTable();
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"
                SELECT p.PRODUCTID, p.NAME AS ProductName, p.DESCRIPTION AS Description, 
                       p.PRICE AS Price, p.IMAGEURL AS ImagePath, p.STOCKQUANTITY AS Quantity, c.CATEGORYNAME
                FROM PRODUCT p
                JOIN CATEGORY c ON p.CATEGORYID = c.CATEGORYID
                WHERE LOWER(p.NAME) LIKE :SearchQuery
                AND (:CategoryId IS NULL OR p.CATEGORYID = :CategoryId)";

                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add("SearchQuery", OracleDbType.Varchar2).Value =
                        string.IsNullOrWhiteSpace(searchQuery) ? "%" : $"%{searchQuery.ToLower()}%";

                    if (string.IsNullOrWhiteSpace(categoryId) || categoryId == "All")
                    {
                        cmd.Parameters.Add("CategoryId", OracleDbType.Int32).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("CategoryId", OracleDbType.Int32).Value = Convert.ToInt32(categoryId);
                    }

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(products);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading products: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return products;
        }
    }
}
