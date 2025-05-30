using System;
using System.Windows.Forms;

namespace E_Commerce
{
    public partial class UsernameDialog : Form
    {
        // Public property to get the entered username
        public string Username { get; private set; }

        public UsernameDialog()
        {
            InitializeComponent();
        }

        // OK button click handler
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Get the value from the textbox and set the Username property
            Username = txtUsername.Text;

            // Set dialog result to OK and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cancel button click handler
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // If the user cancels, set dialog result to Cancel and close the form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
