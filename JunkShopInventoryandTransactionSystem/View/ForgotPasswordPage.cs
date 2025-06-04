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
    public partial class ForgotPasswordPage : Form
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void GoBack_MouseEnter_1(object sender, EventArgs e)
        {
            GoBack.ForeColor = Color.FromArgb(13, 158, 169);
        }

        private void GoBack_MouseLeave_1(object sender, EventArgs e)
        {
            GoBack.ForeColor = Color.FromArgb(7, 96, 14);
        }

        private void GoBack_Click_1(object sender, EventArgs e)
        {
            LogInPage loginpage = new LogInPage();
            loginpage.Dock = DockStyle.Fill;
            loginpage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(loginpage);
            loginpage.Show();
        }
    }
}
