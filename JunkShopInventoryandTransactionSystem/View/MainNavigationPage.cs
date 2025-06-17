using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage;
using JunkShopInventoryandTransactionSystem.View.EmployeeManagementPageFolder;
using JunkShopInventoryandTransactionSystem.View.FinancialReportsPageFolder;
using JunkShopInventoryandTransactionSystem.View.Inventory_Pages;
using JunkShopInventoryandTransactionSystem.View.LogInAuthFolder;
using System;
using System.Windows.Forms;
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class MainNavigationPage : Form
    {
        // This is the main navigation page that contains all the navigation buttons and panels for different pages.
        public MainNavigationPage()
        {
            InitializeComponent();
            int userId = UserSession.UserId;

            // Fetch user info based on userId
            var userInfo = ForUser.GetUserInfo(userId);

            // Set labels
            label2.Text = userInfo.Name;  // Set name to label2
            label1.Text = userInfo.Role;  // Set role to label1

            SetNavButtonChecked(dashBoardNavButton1);
            navControlPanel.Controls.Clear();
            var dashboardPage = new DashBoardPageFolder.DashboardPage();
            dashboardPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(dashboardPage);

            if (userInfo.Role.ToLower() == "employee")
            {
                EmployeeManagementNavButton.Enabled = false;
                EmployeeManagementNavButton.Visible = false;
            }
        }

        private void dashBoardNavButton1_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(dashBoardNavButton1);
            navControlPanel.Controls.Clear();
            var dashboardPage = new DashBoardPageFolder.DashboardPage();
            dashboardPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(dashboardPage);
        }

        private void InventoryNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(InventoryNavButton);
            navControlPanel.Controls.Clear();
            var inventoryPage = new Inventory_Pages.MainInventoryPage();
            inventoryPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(inventoryPage);
        }
        private void TransactionNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(TransactionNavButton);
            navControlPanel.Controls.Clear();
            var generateTransactionPage = new GenerateTransactionPageFolder.GenerateTransactionPage();
            generateTransactionPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(generateTransactionPage);
        }

        private void TransacRecordsNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(TransacRecordsNavButton);
            navControlPanel.Controls.Clear();
            var transactionRecordsPage = new TransactionRecordsPageFolder.TransactionRecordsPage();
            transactionRecordsPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(transactionRecordsPage);
        }

        private void CustRecordsNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(CustRecordsNavButton);
            navControlPanel.Controls.Clear();
            var customerRecordsPage = new CustomerRecordsPage.CustomerRecordsPage();
            customerRecordsPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(customerRecordsPage);
        }

        private void FinancialRecNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(FinancialRecNavButton);
            navControlPanel.Controls.Clear();
            var financialRecordsPage = new FinancialReportsPageFolder.FinancialReportsPage();
            financialRecordsPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(financialRecordsPage);
        }

        private void EmployeeManagementNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(EmployeeManagementNavButton);
            navControlPanel.Controls.Clear();
            var employeeManagementPage = new EmployeeManagementPageFolder.EmployeeManagementPage();
            employeeManagementPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(employeeManagementPage);
        }

        private void cuiPictureBox1_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(cuiPictureBox1);
            navControlPanel.Controls.Clear();
            var userInfoPage = new UserInfo.UserInformationPage();

            // Subscribe to the UserInfoUpdated event
            userInfoPage.UserInfoUpdated += (s, updatedName) =>
            {
                // Update the label2 text when user info is updated
                label2.Text = updatedName;
            };

            userInfoPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(userInfoPage);
        }

        /// <summary>
        /// For UI lang yung code na nasa baba, para ma-set yung background color ng mga navigation buttons if they are checked or not.
        /// </summary>
        /// <param name="checkedControl"></param>
        private void SetNavButtonChecked(Control checkedControl)
        {
            var activeColor = Color.FromArgb(25, 219, 138); // active color
            var inactiveColor = Color.Transparent; // inactive color

            dashBoardNavButton1.Checked = checkedControl == dashBoardNavButton1;
            dashBoardNavButton1.BackColor = dashBoardNavButton1.Checked ? activeColor : inactiveColor;

            InventoryNavButton.Checked = checkedControl == InventoryNavButton;
            InventoryNavButton.BackColor = InventoryNavButton.Checked ? activeColor : inactiveColor;

            TransactionNavButton.Checked = checkedControl == TransactionNavButton;
            TransactionNavButton.BackColor = TransactionNavButton.Checked ? activeColor : inactiveColor;

            TransacRecordsNavButton.Checked = checkedControl == TransacRecordsNavButton;
            TransacRecordsNavButton.BackColor = TransacRecordsNavButton.Checked ? activeColor : inactiveColor;

            CustRecordsNavButton.Checked = checkedControl == CustRecordsNavButton;
            CustRecordsNavButton.BackColor = CustRecordsNavButton.Checked ? activeColor : inactiveColor;

            FinancialRecNavButton.Checked = checkedControl == FinancialRecNavButton;
            FinancialRecNavButton.BackColor = FinancialRecNavButton.Checked ? activeColor : inactiveColor;

            EmployeeManagementNavButton.Checked = checkedControl == EmployeeManagementNavButton;
            EmployeeManagementNavButton.BackColor = EmployeeManagementNavButton.Checked ? activeColor : inactiveColor;

        }

        private void LogOutButton1_Click(object sender, EventArgs e)
        {
            UserSession.UserId = 0;  //To reset the logged-in user id

            LogInPage loginPage = new LogInAuthFolder.LogInPage();
            loginPage.Dock = DockStyle.Fill;
            loginPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(loginPage);
            loginPage.Show();
        }
    }
}