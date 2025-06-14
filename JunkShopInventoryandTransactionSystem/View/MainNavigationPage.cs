using JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage;
using JunkShopInventoryandTransactionSystem.View.EmployeeManagementPageFolder;
using JunkShopInventoryandTransactionSystem.View.FinancialReportsPageFolder;
using JunkShopInventoryandTransactionSystem.View.Inventory_Pages;
using JunkShopInventoryandTransactionSystem.View.LogInAuthFolder;
using System;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class MainNavigationPage : Form
    {

        // This is the main navigation page that contains all the navigation buttons and panels for different pages.
        public MainNavigationPage()
        {
            InitializeComponent();

            SetNavButtonChecked(dashBoardNavButton1);
            navControlPanel.Controls.Clear();
            var dashboardPage = new DashBoardPageFolder.DashboardPage();
            dashboardPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(dashboardPage);
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
            navControlPanel.Controls.Clear();
            var userInfoPage = new UserInfo.UserInformationPage();
            userInfoPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(userInfoPage);

        }

        /// <summary>
        /// For UI lang yung code na nasa baba, para ma-set yung background color ng mga navigation buttons if they are checked or not.
        /// </summary>
        /// <param name="checkedButton"></param>
        private void SetNavButtonChecked(CuoreUI.Controls.cuiButton checkedButton)
        {
            var activeColor = System.Drawing.Color.FromArgb(25, 219, 138); // active color
            var inactiveColor = System.Drawing.Color.Transparent; // inactive color

            dashBoardNavButton1.Checked = checkedButton == dashBoardNavButton1;
            dashBoardNavButton1.BackColor = dashBoardNavButton1.Checked ? activeColor : inactiveColor;

            InventoryNavButton.Checked = checkedButton == InventoryNavButton;
            InventoryNavButton.BackColor = InventoryNavButton.Checked ? activeColor : inactiveColor;

            TransactionNavButton.Checked = checkedButton == TransactionNavButton;
            TransactionNavButton.BackColor = TransactionNavButton.Checked ? activeColor : inactiveColor;

            TransacRecordsNavButton.Checked = checkedButton == TransacRecordsNavButton;
            TransacRecordsNavButton.BackColor = TransacRecordsNavButton.Checked ? activeColor : inactiveColor;

            CustRecordsNavButton.Checked = checkedButton == CustRecordsNavButton;
            CustRecordsNavButton.BackColor = CustRecordsNavButton.Checked ? activeColor : inactiveColor;

            FinancialRecNavButton.Checked = checkedButton == FinancialRecNavButton;
            FinancialRecNavButton.BackColor = FinancialRecNavButton.Checked ? activeColor : inactiveColor;

            EmployeeManagementNavButton.Checked = checkedButton == EmployeeManagementNavButton;
            EmployeeManagementNavButton.BackColor = EmployeeManagementNavButton.Checked ? activeColor : inactiveColor;
        }

        //Pang logout button, this will clear the main panel and show the login page again.
        private void LogOutButton1_Click(object sender, EventArgs e)
        {
            LogInPage loginPage = new LogInAuthFolder.LogInPage();
            loginPage.Dock = DockStyle.Fill;
            loginPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(loginPage);
            loginPage.Show();
        }

        
    }
}