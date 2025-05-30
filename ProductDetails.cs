using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace E_Commerce
{
    public partial class ProductDetails : Form
    {
        private int productId;
        private OracleConnection connection;

        // Assuming that we have a CartID that will be passed, or we get it from the session or a global variable
        private int cartId = 1; // For example, assuming CartID 1 is used for simplicity
        private string currentUsername;

        // Constructor to receive productId
        public ProductDetails(int productId)
        {
            this.productId = productId;
            InitializeComponent();
            string connectionString = "User Id=project;Password=project;Data Source=//localhost:1521/XE;";
            connection = new OracleConnection(connectionString);
        }

        // This method is called when the form loads
        private void ProductDetails_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
        }

        // Method to load product details
        private void LoadProductDetails()
        {
            try
            {
                // Open the connection if it's not open
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                // SQL query to fetch product details based on productId
                string query = @"
            SELECT p.NAME, p.DESCRIPTION, p.PRICE, p.IMAGEURL
            FROM PRODUCT p
            WHERE p.PRODUCTID = :ProductID";

                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add("ProductID", OracleDbType.Int32).Value = this.productId;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable productDetails = new DataTable();
                        adapter.Fill(productDetails);

                        // If the product is found
                        if (productDetails.Rows.Count > 0)
                        {
                            DataRow row = productDetails.Rows[0];

                            // Display product details in the labels
                            lblProductName.Text = row["NAME"].ToString();
                            lblProductPrice.Text = $"${row["PRICE"]}";

                            // Format the description to show 5 words per line
                            string description = row["DESCRIPTION"].ToString();
                            lblProductDescription.Text = FormatDescription(description);

                            // Display the image
                            string imageUrl = row["IMAGEURL"].ToString();
                            if (System.IO.File.Exists(imageUrl))
                            {
                                pictureBox1.Image = Image.FromFile(imageUrl); // Set the image
                            }
                            else
                            {
                                pictureBox1.Image = null; // Set image to null if not found
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product details: " + ex.Message);
            }
            finally
            {
                // Close the connection if it was opened
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Method to format the description with 5 words per line
        private string FormatDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                return string.Empty;
            }

            // Split the description into words
            string[] words = description.Split(' ');
            StringBuilder formattedDescription = new StringBuilder();
            int wordsPerLine = 5;
            int wordCount = 0;

            // Loop through words and add them to the formatted description
            foreach (string word in words)
            {
                formattedDescription.Append(word + " ");
                wordCount++;

                // After 5 words, add a newline character
                if (wordCount == wordsPerLine)
                {
                    formattedDescription.AppendLine();
                    wordCount = 0;
                }
            }

            // Return the formatted description
            return formattedDescription.ToString().TrimEnd();
        }


        // Add to Cart button click event
        // Add to Cart button click event
        private void addtocart_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Show the dialog to enter the username
                string username = PromptForUsername();
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Username is required to proceed.");
                    return;
                }

                // Step 2: Retrieve userId from the entered username
                int userId = GetUserIdFromUsername(username);
                if (userId == -1)
                {
                    MessageBox.Show("Invalid username. Please try again.");
                    return;
                }

                // Step 3: Get or create the shopping cart for the user
                int cartId = GetOrCreateShoppingCart(userId);
                if (cartId == -1)
                {
                    MessageBox.Show("Unable to create or retrieve shopping cart. Please try again.");
                    return;
                }

                // Step 4: Retrieve the quantity from the txtQuantity TextBox
                if (!int.TryParse(txtquantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                // Step 5: Check the available stock for the product
                int availableStock = GetProductStock();
                if (quantity > availableStock)
                {
                    MessageBox.Show($"Only {availableStock} item(s) are available in stock.");
                    return;
                }

                // Step 6: Insert the product into the CARTITEM table
                string query = @"
        INSERT INTO CARTITEM (CARTID, PRODUCTID, QUANTITY)
        VALUES (:CartID, :ProductID, :Quantity)";

                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add("CartID", OracleDbType.Int32).Value = cartId; // Use the valid cart ID
                    cmd.Parameters.Add("ProductID", OracleDbType.Int32).Value = this.productId;
                    cmd.Parameters.Add("Quantity", OracleDbType.Int32).Value = quantity;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                // Step 7: Deduct the product quantity from the PRODUCT table
                string updateStockQuery = @"
        UPDATE PRODUCT
        SET STOCKQUANTITY = STOCKQUANTITY - :Quantity
        WHERE PRODUCTID = :ProductID AND STOCKQUANTITY >= :Quantity";

                using (OracleCommand cmd = new OracleCommand(updateStockQuery, connection))
                {
                    cmd.Parameters.Add("Quantity", OracleDbType.Int32).Value = quantity; // Subtract specified quantity
                    cmd.Parameters.Add("ProductID", OracleDbType.Int32).Value = this.productId;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added to cart!");
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock available.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product to cart: " + ex.Message);
            }
            finally
            {
                // Close the connection if it was opened
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        // Method to get the current stock of the product
        // Method to get the current stock of the product
        private int GetProductStock()
        {
            int stock = 0;
            try
            {
                string query = "SELECT STOCKQUANTITY FROM PRODUCT WHERE PRODUCTID = :ProductID";

                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add("ProductID", OracleDbType.Int32).Value = this.productId;

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        stock = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving product stock: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return stock;
        }



        // Method to prompt the user to enter their username
        private string PromptForUsername()
        {
            using (var usernameForm = new UsernameDialog())
            {
                if (usernameForm.ShowDialog() == DialogResult.OK)
                {
                    return usernameForm.Username;
                }
                else
                {
                    return null;
                }
            }
        }

        // Method to retrieve the userId from the database using the entered username
        private int GetUserIdFromUsername(string username)
        {
            int userId = -1;
            try
            {
                string query = "SELECT USERID FROM USERS WHERE USERNAME = :Username";

                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add("Username", OracleDbType.Varchar2).Value = username;

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Username not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user ID: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return userId;
        }

        // Method to get or create a shopping cart for the given userId
        // Method to get or create a shopping cart for the given userId
        private int GetOrCreateShoppingCart(int userId)
        {
            int cartId = -1;
            try
            {
                // Check if the shopping cart already exists for the user
                string checkQuery = "SELECT CARTID FROM SHOPPINGCART WHERE USERID = :UserID";

                using (OracleCommand cmd = new OracleCommand(checkQuery, connection))
                {
                    cmd.Parameters.Add("UserID", OracleDbType.Int32).Value = userId;

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Check if the result is of type OracleDecimal
                        if (result is OracleDecimal)
                        {
                            // Convert OracleDecimal to int
                            cartId = ((OracleDecimal)result).ToInt32();
                        }
                        else
                        {
                            cartId = Convert.ToInt32(result);
                        }
                    }
                    else
                    {
                        // If no cart exists, create a new shopping cart
                        string insertCartQuery = "INSERT INTO SHOPPINGCART (USERID) VALUES (:UserID) RETURNING CARTID INTO :CartID";

                        using (OracleCommand insertCmd = new OracleCommand(insertCartQuery, connection))
                        {
                            insertCmd.Parameters.Add("UserID", OracleDbType.Int32).Value = userId;
                            OracleParameter cartIdParam = new OracleParameter("CartID", OracleDbType.Int32)
                            {
                                Direction = ParameterDirection.Output
                            };
                            insertCmd.Parameters.Add(cartIdParam);

                            insertCmd.ExecuteNonQuery();
                            cartId = Convert.ToInt32(cartIdParam.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving or creating shopping cart: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return cartId;
        }

     



        // Method to get or create a shopping cart for the current user


        // Method to retrieve the current user's ID


        // Back button click event

    }
}
