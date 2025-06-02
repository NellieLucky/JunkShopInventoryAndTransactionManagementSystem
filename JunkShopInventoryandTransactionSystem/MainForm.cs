using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunkShopInventoryandTransactionSystem.View;

namespace JunkShopInventoryandTransactionSystem
{
    public partial class MainForm : Form
    {
        public static Panel MainPanel;
        public MainForm()
        {
            InitializeComponent();
            MainPanel = panel1; // Assign the panel to a static variable for easy access
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogInPage loginPage = new LogInPage();
            loginPage.Dock = DockStyle.Fill;
            loginPage.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(loginPage);
            loginPage.Show();
        }
    }
}
