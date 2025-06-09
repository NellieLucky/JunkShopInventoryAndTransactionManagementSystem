
using JunkShopInventoryandTransactionSystem.View;
using static JunkShopInventoryandTransactionSystem.Backend_Files.SQL.MSql_Calls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

//imports the namespace using the syntax " using "
using JunkShopInventoryandTransactionSystem.Backend_Files.SQL;

namespace JunkShopInventoryandTransactionSystem
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private bool ValidateLogin(string emailInput, string passwordInput)
        {
            var sqlHandler = new MSql_Calls();
            List<MSql_Calls.Employee> employees = sqlHandler.GetAllEmployees();

            foreach (var emp in employees)
            {
                if (emp.empEmail == emailInput && emp.empPassword == passwordInput)
                {
                    return true;
                }
            }

            return false;
        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            string emailInput = EmailTextBox.Content;
            string pwInput = PasswordTextBox.Content;

            bool loginSuccess = ValidateLogin(emailInput, pwInput);

            if (loginSuccess) {
                MainNavigationPage dashboardPage = new MainNavigationPage();
                dashboardPage.Dock = DockStyle.Fill;
                dashboardPage.TopLevel = false;
                MainForm.MainPanel.Controls.Clear();
                MainForm.MainPanel.Controls.Add(dashboardPage);
                dashboardPage.Show();
            }
            else {
                //MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //for checking
                MessageBox.Show($"Email input : '{emailInput}' , Pw Input : '{pwInput}' ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
