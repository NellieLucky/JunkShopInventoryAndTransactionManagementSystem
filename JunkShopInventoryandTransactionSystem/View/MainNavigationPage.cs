using System;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class MainNavigationPage : Form
    {
        public MainNavigationPage()
        {
            InitializeComponent();
            SetNavButtonChecked(dashboardNavButton);
            navControlPanel.Controls.Clear();
            var dashboardPage = new DashboardPage();
            dashboardPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(dashboardPage);
        }

        private void dashboardNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(dashboardNavButton);
            navControlPanel.Controls.Clear();
            var dashboardPage = new DashboardPage();
            dashboardPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(dashboardPage);
        }

        private void inventoryNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(inventoryNavButton);
            navControlPanel.Controls.Clear();
            var inventoryPage = new InventoryPage();
            inventoryPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(inventoryPage);
        }

        private void transactionNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(transactionNavButton);
            navControlPanel.Controls.Clear();
            var transactionPage = new GenerateTransactionPage();
            transactionPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(transactionPage);
        }

        private void transacRecordsNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(transacRecordsNavButton);
            navControlPanel.Controls.Clear();
            var transacRecordsPage = new TransactionRecordsPage();
            transacRecordsPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(transacRecordsPage);
        }

        private void custRecNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(custRecNavButton);
            navControlPanel.Controls.Clear();
            var customerRecordsPage = new CustomerRecordsPage();
            customerRecordsPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(customerRecordsPage);
        }

        private void financeRecNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(financeRecNavButton);
            navControlPanel.Controls.Clear();
            var financialReportsPage = new FinancialReportsPage();
            financialReportsPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(financialReportsPage);
        }

        private void empManageNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(empManageNavButton);
            navControlPanel.Controls.Clear();
            var employeeManagementPage = new EmployeeManagementPage();
            employeeManagementPage.Dock = DockStyle.Fill;
            navControlPanel.Controls.Add(employeeManagementPage);
        }

        /// <summary>
        /// Helper to set only the selected nav button as checked.
        /// </summary>
        /// <param name="checkedButton"></param>
        private void SetNavButtonChecked(Guna.UI2.WinForms.Guna2Button checkedButton)
        {
            dashboardNavButton.Checked = checkedButton == dashboardNavButton;
            inventoryNavButton.Checked = checkedButton == inventoryNavButton;
            transactionNavButton.Checked = checkedButton == transactionNavButton;
            transacRecordsNavButton.Checked = checkedButton == transacRecordsNavButton;
            custRecNavButton.Checked = checkedButton == custRecNavButton;
            financeRecNavButton.Checked = checkedButton == financeRecNavButton;
            empManageNavButton.Checked = checkedButton == empManageNavButton;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LogInPage loginPage = new LogInPage();
            loginPage.Dock = DockStyle.Fill;
            loginPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(loginPage);
            loginPage.Show();
        }
    }
}