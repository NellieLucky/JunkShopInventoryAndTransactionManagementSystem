using JunkShopInventoryandTransactionSystem.BackendFiles.IndInvoice;
using Microsoft.Data.SqlClient;
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
    public partial class receiptlogo : Form
    {
        public int TransacId { get; }
        public string CustomerName { get; }

        public receiptlogo(int transacId, string customerName)
        {
            InitializeComponent();
            TransacId = transacId;
            CustomerName = customerName;

            string customerId = DataHelper.GetCustomerIdByName(CustomerName);

            ReceiptCustName.Text = CustomerName;
            ReceiptCustNo.Text = DataHelper.GetCustomerContactById(customerId);

            // Load and display the receipt items
            DataHelper.LoadReceiptItems(TransacId, BuyersOrderTable, label1, label2);
        }
        private void BuyersOrderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdItem_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptTotalItem_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
