using System;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class Login : Form
    {
        private AuthLogic authLogic; // Use AuthLogic for authentication

        public Login()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string selectedRole = cmbrole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error");
                return;
            }

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role.", "Error");
                return;
            }

            bool loginSuccessful = authLogic.AuthenticateUser(username, password, selectedRole);

            if (loginSuccessful)
            {
                int userId = authLogic.GetUserId(username); // Retrieve userId
                MessageBox.Show("Login Successful!", "Success");

                string role = authLogic.GetUserRole(username);
                OpenRolePage(role, userId); // Pass userId to the next form

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.", "Error");
            }
        }

        private void OpenRolePage(string role, int userId)
        {
            Form rolePage = null;

            switch (role)
            {
                case "Admin":
                    rolePage = new InventoryManagementForm(); // Pass userId
                    break;

                case "Customer":
                    rolePage = new ProductCatalogForm(userId); // Pass userId
                    break;

                case "Cashier":
                    //rolePage = new OrderProcessingForm(); // Pass userId
                    break;

                case "Manager":
                    rolePage = new InventoryManagementForm(); // Pass userId
                    break;

                case "Delivery Person":
                    // rolePage = new DeliveryPersonDashboard(userId); // Implement this form
                    break;

                default:
                    MessageBox.Show("Role not found.", "Error");
                    return;
            }

            if (rolePage != null)
            {
                rolePage.Show();
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }
    }
}
