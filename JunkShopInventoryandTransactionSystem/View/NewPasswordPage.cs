using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class NewPasswordPage : Form
    {
        public NewPasswordPage()
        {
            InitializeComponent();
        }

        private void UpdatePass_Button_Click(object sender, EventArgs e)
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
