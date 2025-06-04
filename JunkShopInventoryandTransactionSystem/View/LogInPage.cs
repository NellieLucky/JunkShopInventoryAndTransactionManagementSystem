using JunkShopInventoryandTransactionSystem.View;

namespace JunkShopInventoryandTransactionSystem
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            MainNavigationPage dashboardPage = new MainNavigationPage();
            dashboardPage.Dock = DockStyle.Fill;
            dashboardPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(dashboardPage);
            dashboardPage.Show();
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
    }
}
