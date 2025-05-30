using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace E_Commerce
{
    public class AuthDataAccess
    {
        private string connectionString = "User Id=project;Password=project;Data Source=//localhost:1521/XE;";

        /// <summary>
        /// Registers a new user in the database.
        /// </summary>
        public bool RegisterUser(string username, string hashedPassword, string email, string phone, string role)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
INSERT INTO USERS (USERNAME, PASSWORD, EMAIL, PHONENUMBER, ROLE)
VALUES (:username, :password, :email, :phone, :role)";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = hashedPassword;
                        command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone;
                        command.Parameters.Add(":role", OracleDbType.Varchar2).Value = role;

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if the user was registered successfully
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during registration: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Validates a user's credentials and role.
        /// </summary>
        public bool ValidateUser(string username, string hashedPassword, string role)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
SELECT COUNT(*) 
FROM USERS 
WHERE USERNAME = :username 
  AND PASSWORD = :password 
  AND ROLE = :role";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add(":password", OracleDbType.Varchar2).Value = hashedPassword;
                        command.Parameters.Add(":role", OracleDbType.Varchar2).Value = role;

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during validation: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Retrieves the user's role based on their username.
        /// </summary>
        public string GetUserRole(string username)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT ROLE FROM USERS WHERE USERNAME = :username";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                        object result = command.ExecuteScalar();
                        return result?.ToString() ?? string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving user role: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Retrieves the user's ID based on their username.
        /// </summary>
        public int GetUserId(string username)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT USERID FROM USERS WHERE USERNAME = :username";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving user ID: " + ex.Message);
                    return 0;
                }
            }
        }
    }
}
