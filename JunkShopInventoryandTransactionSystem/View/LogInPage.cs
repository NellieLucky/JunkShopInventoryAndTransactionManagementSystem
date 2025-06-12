using JunkShopInventoryandTransactionSystem.View;
using Microsoft.Data.SqlClient;

namespace JunkShopInventoryandTransactionSystem
{
    public partial class LogInPage : Form
    {
        // Connection string to connect to the local SQL Server database
        //private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\source\repos\JunkShopInventoryandTransactionSystem\Users.mdf;Integrated Security=True";

        //arnel's connstring
        private readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkshopDB.mdf;Integrated Security = True";


        public LogInPage()
        {
            InitializeComponent();
            // Make sure the cursor is not a wait cursor for the email textbox
        }

        // Validates login credentials against Employee and Management tables
        private bool LoginValidation(string email, string password)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                // Combine Employee and Management tables for authentication
                string query = @"
                    SELECT TOP 1 empEmail FROM Employees 
                    WHERE empEmail = @Email AND empPassword = @Password
                    UNION ALL   
                    SELECT TOP 1 admEmail FROM Management 
                    WHERE admEmail = @Email AND admPassword = @Password";
                //TOP 1 is used to limit the result to one record, as we only need to check if a match exists.
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
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
                if (LoginValidation(email, password))
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
