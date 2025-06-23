using JunkShopInventoryandTransactionSystem.BackendFiles.Customer;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Reload;
using System;
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
    public partial class BuyerRecordsPage : UserControl
    {
        public BuyerRecordsPage()
        {
            InitializeComponent();
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            searchButton.Click += SearchButton_Click;
            LoadBuyerRecords();
        }

        private void LoadBuyerRecords()
        {
            BuyerRecordsTable.Rows.Clear();
            var buyerRead = new BuyerRead();
            var buyers = buyerRead.GetBuyerSummaries();
            foreach (var buyer in buyers)
            {
                BuyerRecordsTable.Rows.Add(
                    buyer.CustomerID,
                    buyer.Name,
                    buyer.customerContact,
                    buyer.TotalPurchases,
                    buyer.TotalPurchasePrice,
                    buyer.TotalPurchaseQty
                );
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FilterRows(searchTextBox.Text);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterRows(searchTextBox.Text);
        }

        private void FilterRows(string searchText)
        {
            string lowerSearch = searchText?.Trim().ToLower() ?? string.Empty;

            foreach (DataGridViewRow row in BuyerRecordsTable.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = string.IsNullOrEmpty(lowerSearch);

                if (!visible)
                {
                    foreach (DataGridViewColumn col in BuyerRecordsTable.Columns)
                    {
                        if (!col.Visible) continue;
                        var cellValue = row.Cells[col.Index].Value?.ToString();
                        if (!string.IsNullOrEmpty(cellValue) && cellValue.ToLower().Contains(lowerSearch))
                        {
                            visible = true;
                            break;
                        }
                    }
                }

                row.Visible = visible;
            }
        }

        private void DashboardTitlePage_Click(object sender, EventArgs e)
        {

        }

        private void BuyerRecordsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(BuyerRecordsTable.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = BuyerRecordsTable.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = BuyerRecordsTable.Rows[e.RowIndex];
            int customerId = Convert.ToInt32(selectedRow.Cells["CustID"].Value);

            if (clickedColumnName == "CustomerDelete")
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete records of buyer ID: {customerId}?",
                    "Confirm Buyer Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    var deleter = new JunkShopInventoryandTransactionSystem.BackendFiles.Customer.Crud.CustomerDelete();
                    bool wasArchived = deleter.ArchiveCustomer(customerId);

                    if (wasArchived)
                    {
                        MessageBox.Show("✅ Buyer archived (soft deleted) successfully.");
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Buyer not found or already archived.");
                    }

                    // Reload the buyer records table
                    LoadBuyerRecords();
                }
            }
        }
    }
}
