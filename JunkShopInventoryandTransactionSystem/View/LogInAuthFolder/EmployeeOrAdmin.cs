using JunkShopInventoryandTransactionSystem.View.DashBoardPageFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View.LogInAuthFolder
{
    public partial class EmployeeOrAdmin : Form
    {
        public EmployeeOrAdmin()
        {
            InitializeComponent();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            empLogInPage empLogInPage = new empLogInPage();
            empLogInPage.Dock = DockStyle.Fill;
            empLogInPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(empLogInPage);
            empLogInPage.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            LogInPage LogInPage = new LogInPage();
            LogInPage.Dock = DockStyle.Fill;
            LogInPage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(LogInPage);
            LogInPage.Show();
        }
    }
}
