using JunkShopInventoryandTransactionSystem.View.Inventory_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View.GenerateTransactionPageFolder
{
    public partial class GenerateTransactionPage : UserControl
    {
        public GenerateTransactionPage()
        {
            InitializeComponent();

            SellerBuyerPanel.Controls.Clear();
            var BuyerPage = new BuyerTransaction();
            BuyerPage.Dock = DockStyle.Fill;
            SellerBuyerPanel.Controls.Add(BuyerPage);
        }

        private void BuyerNavButton_Click(object sender, EventArgs e)
        {
            SellerBuyerPanel.Controls.Clear();
            var BuyerPage = new BuyerTransaction();
            BuyerPage.Dock = DockStyle.Fill;
            SellerBuyerPanel.Controls.Add(BuyerPage);
        }

        private void SellerNavButton_Click(object sender, EventArgs e)
        {
            SellerBuyerPanel.Controls.Clear();
            var SellerPage = new SellerTransaction();
            SellerPage.Dock = DockStyle.Fill;
            SellerBuyerPanel.Controls.Add(SellerPage);
        }
    }
}
