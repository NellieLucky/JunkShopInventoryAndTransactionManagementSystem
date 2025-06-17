using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;

namespace JunkShopInventoryandTransactionSystem.View.LogInAuthFolder
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
            string confirmPassword = ConfirmPasswordTextBox.Content;
            string name = NameTextBox.Content;
            string contact = ContactNumberTextBox.Content;
            string address = AddressTextBox.Content;

            // Autogenerate admin position

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
            try
            {
                bool success = ForUser.RegisterAdmin(email, password, name, contact, address, out string errorMessage);

                if (success)
                {
                    MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //redirect to login page
                    LogInPage loginPage = new LogInPage();
                    loginPage.Dock = DockStyle.Fill;
                    loginPage.TopLevel = false;
                    MainForm.MainPanel.Controls.Clear();
                    MainForm.MainPanel.Controls.Add(loginPage);
                    loginPage.Show();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTextBox_ContentChanged(object sender, EventArgs e)
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
        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
