using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;

namespace E_Commerce
{
    public class AuthLogic
    {
        private AuthDataAccess authDataAccess;

        public AuthLogic()
        {
            authDataAccess = new AuthDataAccess(); // Initialize the Data Access Layer
        }

        /// <summary>
        /// Registers a new user after performing validation.
        /// </summary>
        public bool RegisterUser(string username, string password, string email, string phone, string role)
        {
            // Validate password strength
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long, contain uppercase, lowercase, digits, and special characters.");
                return false;
            }

            // Hash the password before storing it
            string hashedPassword = HashPassword(password);

            // Insert user into the database
            return authDataAccess.RegisterUser(username, hashedPassword, email, phone, role);
        }

        /// <summary>
        /// Authenticates a user based on their username, hashed password, and role.
        /// </summary>
        public bool AuthenticateUser(string username, string password, string role)
        {
            string hashedPassword = HashPassword(password); // Hash the provided password
            return authDataAccess.ValidateUser(username, hashedPassword, role); // Validate against the database
        }

        /// <summary>
        /// Retrieves the user's role based on their username.
        /// </summary>
        public string GetUserRole(string username)
        {
            return authDataAccess.GetUserRole(username);
        }

        /// <summary>
        /// Retrieves the user's ID based on their username.
        /// </summary>
        public int GetUserId(string username)
        {
            return authDataAccess.GetUserId(username);
        }

        /// <summary>
        /// Validates if the password meets the required complexity criteria.
        /// </summary>
        private bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;
            if (!Regex.IsMatch(password, @"[A-Z]")) return false; // At least one uppercase letter
            if (!Regex.IsMatch(password, @"[a-z]")) return false; // At least one lowercase letter
            if (!Regex.IsMatch(password, @"\d")) return false; // At least one digit
            if (!Regex.IsMatch(password, @"[\W_]")) return false; // At least one special character
            return true;
        }

        /// <summary>
        /// Hashes the password using SHA-256.
        /// </summary>
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
