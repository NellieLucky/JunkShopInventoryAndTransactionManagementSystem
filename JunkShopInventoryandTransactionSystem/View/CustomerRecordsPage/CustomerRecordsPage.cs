﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage
{
    public partial class CustomerRecordsPage : UserControl
    {
        public CustomerRecordsPage()
        {
            InitializeComponent();
            CustomerPanel.Controls.Clear();
            var BuyerRecordsPage = new BuyerRecordsPage();
            BuyerRecordsPage.Dock = DockStyle.Fill;
            CustomerPanel.Controls.Add(BuyerRecordsPage);
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            CustomerPanel.Controls.Clear();
            var SupplierRecordsPage = new SellerRecordsPage();
            SupplierRecordsPage.Dock = DockStyle.Fill;
            CustomerPanel.Controls.Add(SupplierRecordsPage);

        }

        private void BuyerButton_Click(object sender, EventArgs e)
        {
            CustomerPanel.Controls.Clear();
            var BuyerRecordsPage = new BuyerRecordsPage();
            BuyerRecordsPage.Dock = DockStyle.Fill;
            CustomerPanel.Controls.Add(BuyerRecordsPage);
        }
    }
}
