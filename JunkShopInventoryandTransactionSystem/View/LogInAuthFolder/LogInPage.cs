using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using JunkShopInventoryandTransactionSystem.View;
using JunkShopInventoryandTransactionSystem.View.LogInAuthFolder;
using Microsoft.Data.SqlClient;
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;

namespace JunkShopInventoryandTransactionSystem.View.LogInAuthFolder
{
    public partial class LogInPage : Form
    {

        private bool isPasswordVisible = false;

        public LogInPage()
        {

            InitializeComponent();
            PasswordTextBox.PasswordChar = true;
            PasswordToggle.BackgroundImage = Properties.Resources.hide;
            PasswordToggle.Click += PasswordToggle_Click;
            // Make sure the cursor is not a wait cursor for the email textbox
        }

        // This method is called when the Log In button is clicked
        private void LogInButton_Click_1(object sender, EventArgs e)
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
                int? userId = AuthenticateAdmin(email, password);

                if (userId.HasValue)
                {
                    UserSession.UserId = userId.Value;

                    MessageBox.Show("Login successful as Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainNavigationPage dashboardPage = new MainNavigationPage();
                    dashboardPage.Dock = DockStyle.Fill;
                    dashboardPage.TopLevel = false;
                    MainForm.MainPanel.Controls.Clear();
                    MainForm.MainPanel.Controls.Add(dashboardPage);
                    dashboardPage.Show();
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


        private void PasswordToggle_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            // Try PasswordChar property
            PasswordTextBox.PasswordChar = !isPasswordVisible;
            // Try BackgroundImage property
            PasswordToggle.BackgroundImage = isPasswordVisible
                ? Properties.Resources.view
                : Properties.Resources.hide;
        }


        private void ForgotPasswordButton_Click(object sender, EventArgs e)
        {
            ForgotPasswordPage forgotPasswordPage = new ForgotPasswordPage();
            forgotPasswordPage.Dock = DockStyle.Fill;
            forgotPasswordPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(forgotPasswordPage);
            forgotPasswordPage.Show();
        }

        private void ForgotPasswordButton_MouseEnter(object sender, EventArgs e)
        {
            ForgotPasswordButton.ForeColor = Color.FromArgb(13, 158, 169);
        }

        private void ForgotPasswordButton_MouseLeave(object sender, EventArgs e)
        {
            ForgotPasswordButton.ForeColor = Color.FromArgb(7, 96, 14);
        }





        private void EmailTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            EmployeeOrAdmin employeeOrAdmin = new EmployeeOrAdmin();
            employeeOrAdmin.Dock = DockStyle.Fill;
            employeeOrAdmin.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(employeeOrAdmin);
            employeeOrAdmin.Show();
        }
    }
}
