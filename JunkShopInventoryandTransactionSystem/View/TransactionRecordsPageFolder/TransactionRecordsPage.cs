using JunkShopInventoryandTransactionSystem.BackendFiles.IndInvoice;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Reload;
using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using JunkShopInventoryandTransactionSystem.View.InvoiceReceipt;
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

namespace JunkShopInventoryandTransactionSystem.View.TransactionRecordsPageFolder
{
    public partial class TransactionRecordsPage : UserControl
    {
        public TransactionRecordsPage()
        {
            InitializeComponent();
            ReloadTransactions.LoadTransactionData(TransactionRecordsTable);

            SearchTextBox.ContentChanged += SearchTextBox_TextChange;

            var userInfo = ForUser.GetUserInfo(UserSession.UserId);
            if (userInfo.Role == "Employee")
            {
                TransactionRecordsTable.Columns["Delete"].Visible = false;
            }
        }

        private void TransactionRecordsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(TransactionRecordsTable.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = TransactionRecordsTable.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = TransactionRecordsTable.Rows[e.RowIndex];
            int transacId = Convert.ToInt32(selectedRow.Cells["TransactionID"].Value);

            if (clickedColumnName == "Delete")
            {
                // Show confirmation message with the itemId
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete records of transaction ID: {transacId}?",
                    "Confirm Transaction Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    TransactionDelete deleter = new TransactionDelete();
                    bool wasDeleted = deleter.ArchiveTransaction(transacId);

                    if (wasDeleted)
                    {
                        Console.WriteLine("✅ Transaction deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Transaction not found or already deleted.");
                    }

                    // and then reload the transaction records
                    ReloadTransactions.LoadTransactionData(TransactionRecordsTable);
                }

            }
            if (clickedColumnName == "Receipt") 
            {
                // Show the receipt for the selected transaction
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to view receipt of transaction ID: {transacId}?",
                    "Confirm Viewing of receipt",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    string customerName = selectedRow.Cells["customerName"].Value?.ToString() ?? "";

                    HistoricalReceipt historicalreceipt = new HistoricalReceipt(transacId, customerName);
                    historicalreceipt.ShowDialog(); // Show the receipt form as a dialog
                }
                else
                {
                    Console.WriteLine("⚠️ Transaction not found or already deleted.");
                }
            }
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            FilterCategories(SearchTextBox.Content);
        }

        private void SearchTextBox_TextChange(object? sender, EventArgs e)
        {
            FilterCategories(SearchTextBox.Content);
        }

        private void FilterCategories(string searchText)
        {
            string lowerSearch = searchText?.Trim().ToLower() ?? string.Empty;

            foreach (DataGridViewRow row in TransactionRecordsTable.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                bool visible = string.IsNullOrEmpty(lowerSearch);

                if (!visible)
                {
                    foreach (DataGridViewColumn col in TransactionRecordsTable.Columns)
                    {
                        if (!col.Visible || col.Name == "Remove") continue; // Skip invisible and Remove columns

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
    }
}