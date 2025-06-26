using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.ConstructorModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JunkShopInventoryandTransactionSystem.View.InvoiceReceipt
{
    public partial class receiptlogo : Form
    {
        private DataGridView _cartTable; // Holds the cart DataGridView directly
        private string _customerName;
        private string _customerContact;
        private int _totalItems;
        private decimal _totalPrice;

        public receiptlogo(
            DataGridView cartTable,
            string customerName,
            string customerContact,
            int totalItems,
            decimal totalPrice)
        {
            InitializeComponent();

            _cartTable = cartTable;
            _customerName = customerName;
            _customerContact = customerContact;
            _totalItems = totalItems;
            _totalPrice = totalPrice;

            // Attach the CellFormatting event handler
            InvoiceReceiptTable.CellFormatting += InvoiceReceiptTable_CellFormatting;

            loadDetails_toInvoiceReceipt();
        }

        private void loadDetails_toInvoiceReceipt()
        {
            // Assign customer details
            ReceiptCustName.Text = _customerName;
            ReceiptCustNo.Text = _customerContact;

            // Clear InvoiceReceiptTable just in case
            InvoiceReceiptTable.Rows.Clear();

            // Copy each row from cart table
            foreach (DataGridViewRow row in _cartTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    object id = row.Cells[0].Value;
                    object name = row.Cells[1].Value;
                    object qtyType = row.Cells[2].Value;
                    object price = row.Cells[3].Value;
                    object quantity = row.Cells[4].Value;
                    object amount = row.Cells[5].Value;

                    InvoiceReceiptTable.Rows.Add(id, name, qtyType, price, quantity, amount);
                }
            }

            // Display totals
            TotalItemHolder.Text = _totalItems.ToString();
            TotalPriceHolder.Text = "₱ " + _totalPrice.ToString("N2");
        }

        private void InvoiceReceiptTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Replace "Price" and "ExchangeAmount" with your actual column names if different
            string colName = InvoiceReceiptTable.Columns[e.ColumnIndex].Name;
            if ((colName == "Price" || colName == "TransacAmount") && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal amount))
                {
                    e.Value = $"₱{amount:N2}";
                    e.FormattingApplied = true;
                }
            }
        }

    }
}
