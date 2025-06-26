using JunkShopInventoryandTransactionSystem.BackendFiles.IndInvoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View.TransactionRecordsPageFolder
{
    public partial class HistoricalReceipt : Form
    {
        public int TransacId { get; }
        public string CustomerName { get; }

        public HistoricalReceipt(int transacId, string customerName)
        {
            InitializeComponent();

            TransacId = transacId;
            CustomerName = customerName;

            string customerId = DataHelper.GetCustomerIdByName(CustomerName);

            ReceiptCustName.Text = CustomerName;
            ReceiptCustNo.Text = DataHelper.GetCustomerContactById(customerId);

            // Load and display the receipt items
            DataHelper.LoadReceiptItems(TransacId, InvoiceReceiptTable, TotalItemHolder, TotalPriceHolder);
            TransacId = transacId;
            CustomerName = customerName;
        }
    }
}
