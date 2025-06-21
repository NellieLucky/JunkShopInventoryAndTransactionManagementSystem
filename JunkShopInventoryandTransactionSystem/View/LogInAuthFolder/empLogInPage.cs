using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;

namespace JunkShopInventoryandTransactionSystem.View.LogInAuthFolder
{
    public partial class empLogInPage : Form
    {
        public empLogInPage()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // Get the email and password entered by the user
            string email = EmailTextBox.Content;
            string password = PasswordTextBox.Content;

            // Check if either field is empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int? employeeId = ForUser.AuthenticateEmployee(email, password);

                if (employeeId.HasValue)
                {
                    // Set session user as employee
                    ForUser.UserSession.SetUser(employeeId.Value, true);

                    MessageBox.Show("Login successful as Employee!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load your main page here
                    MainNavigationPage dashboardPage = new MainNavigationPage();
                    dashboardPage.Dock = DockStyle.Fill;
                    dashboardPage.TopLevel = false;
                    MainForm.MainPanel.Controls.Clear();
                    MainForm.MainPanel.Controls.Add(dashboardPage);
                    dashboardPage.Show();
                    return;
                }
                else
                {
                    // If login fails, show an error message and clear the password field
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    PasswordTextBox.Content = string.Empty;
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong (e.g., database connection issue)
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
