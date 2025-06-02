using JunkShopInventoryandTransactionSystem.View;

namespace JunkShopInventoryandTransactionSystem
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }


        private void ForgotPasswordPageClick_Click(object sender, EventArgs e)
        {
            ForgotPasswordPage forgotPasswordPage = new ForgotPasswordPage();
            forgotPasswordPage.Dock = DockStyle.Fill;
            forgotPasswordPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(forgotPasswordPage);
            forgotPasswordPage.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            MainNavigationPage dashboardPage = new MainNavigationPage();
            dashboardPage.Dock = DockStyle.Fill;
            dashboardPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(dashboardPage);
            dashboardPage.Show();
        }

        private void SigInLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
