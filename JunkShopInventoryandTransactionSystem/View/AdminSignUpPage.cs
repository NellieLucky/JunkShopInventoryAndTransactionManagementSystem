using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class AdminSignUpPage : Form
    {
        public AdminSignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Content;
            string password = PasswordTextBox.Content;
            string confirmPassword = ConfirmPassworrdTextBox.Content;
            string name = NameTextBox.Content;
            string contact = ContactNumberTextBox.Content;
            string address = AddressTextBox.Content;

            // Autogenerate admin position
            bool isAdmin = true;

            if (string.IsNullOrWhiteSpace(email) || 
                string.IsNullOrWhiteSpace(password) || 
                string.IsNullOrWhiteSpace(confirmPassword) || 
                string.IsNullOrEmpty(name) || 
                string.IsNullOrWhiteSpace(contact) || 
                string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if contact number contains only digits
            if (!contact.All(char.IsDigit))
            {
                MessageBox.Show("Contact number must contain only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if email looks valid (very basic check)
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if password is at least 6 characters
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // If all checks pass, show a success message
            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Save the data to a database or perform further actions (save isAdmin to admPosition)
        }

        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmailTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPassworrdTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void ContactNumberTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
