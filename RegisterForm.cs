using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class RegisterForm : Form
    {
        private AuthLogic authLogic; // Use AuthLogic for registration

        public RegisterForm()
        {
            InitializeComponent();
            authLogic = new AuthLogic(); // Initialize AuthLogic instance

            // Add roles to the combo box
            cmbrole.Items.Add("Admin");
            cmbrole.Items.Add("Customer");
            cmbrole.Items.Add("Cashier");
            cmbrole.Items.Add("Manager");
            cmbrole.Items.Add("Delivery Person");
            cmbrole.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) // Front-end validation
            {
                // Collect form data
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string email = textEmail.Text;
                string phone = textPhone.Text;
                string role = cmbrole.SelectedItem?.ToString() ?? "Customer";

                // Pass data to AuthLogic for validation and insertion
                bool isRegistered = authLogic.RegisterUser(username, password, email, phone, role);

                if (isRegistered)
                {
                    MessageBox.Show("Registration Successful!");
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields correctly.");
            }
        }

        // Front-end validation logic
        private bool ValidateForm()
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(textEmail.Text) ||
              
                string.IsNullOrWhiteSpace(txtname.Text) ||
                cmbrole.SelectedItem == null)
            {
                return false;
            }

            // Validate email format (example for Gmail)
            if (!IsValidEmail(textEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            // Ensure phone number contains only digits
            if (!IsDigitsOnly(textPhone.Text))
            {
                MessageBox.Show("Phone number must contain digits only.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@gmail\.com$"; // Adjust domain as necessary
            return Regex.IsMatch(email, pattern);
        }

        private bool IsDigitsOnly(string str)
        {
            return Regex.IsMatch(str, @"^\d+$");
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            textEmail.Clear();
            textPhone.Clear();
            txtname.Clear();
            cmbrole.SelectedIndex = 0;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
