using JunkShopInventoryandTransactionSystem.View;
using Microsoft.Data.SqlClient;

namespace JunkShopInventoryandTransactionSystem
{
    public partial class LogInPage : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database.mdf;Integrated Security=True";
        public LogInPage()
        {
            InitializeComponent();
            EmailTextBox.UseWaitCursor = false;
        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            string email = EmailTextBox.Content;
            string password = PasswordTextBox.Content;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email = @Email AND Password = @Password", connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
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
                            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            PasswordTextBox.Content = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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
