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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SigInLabel_Click(object sender, EventArgs e)
        {

        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            LogInPage loginpage = new LogInPage();
            loginpage.Dock = DockStyle.Fill;
            loginpage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(loginpage);
            loginpage.Show();

        }

        private void GoBack_MouseEnter(object sender, EventArgs e)
        {
            GoBack.ForeColor = Color.FromArgb(13, 158, 169);
        }

        private void GoBack_MouseLeave(object sender, EventArgs e)
        {
            GoBack.ForeColor = Color.FromArgb(7, 96, 14);
        }
    }
}
