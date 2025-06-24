using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;

namespace JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage
{
    public partial class BuyerRecordsPage : UserControl
    {
        public BuyerRecordsPage()
        {
            InitializeComponent();

            var userInfo = ForUser.GetUserInfo(UserSession.UserId);
            if (userInfo.Role == "Employee")
            {
                dataGridView1.Columns["CustomerDelete"].Visible = false; //Change dataGridView1 to actual name of grid view
            }
        }

        private void DashboardTitlePage_Click(object sender, EventArgs e)
        {

        }
    }
}
