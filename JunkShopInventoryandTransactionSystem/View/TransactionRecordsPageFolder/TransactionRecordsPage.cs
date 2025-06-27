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

            // Ensure ComboBox items are set up before using SelectedIndex
            archiveState.Items.Clear();
            archiveState.Items.Add("Non-archived");
            archiveState.Items.Add("Archived");

            // Set default selection to the first item ("Non-archived")
            archiveState.SelectedIndex = 0;

            // Attach event handler AFTER setting default to avoid double loading
            archiveState.SelectedIndexChanged += ArchiveState_SelectedIndexChanged;


            ReloadTransactions.LoadTransactionData(TransactionRecordsTable, false);

            TransactionRecordsTable.CellFormatting += TransactionRecordsTable_CellFormatting;
            SearchTextBox.ContentChanged += SearchTextBox_TextChange;
            archiveState.SelectedIndexChanged += ArchiveState_SelectedIndexChanged;

            var userInfo = ForUser.GetUserInfo(UserSession.UserId);
            if (userInfo.Role == "Employee")
            {
                TransactionRecordsTable.Columns["Delete"].Visible = false;
            }
        }

        private void TransactionRecordsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!(TransactionRecordsTable.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = TransactionRecordsTable.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = TransactionRecordsTable.Rows[e.RowIndex];
            int transacId = Convert.ToInt32(selectedRow.Cells["TransactionID"].Value);

            bool showArchived = archiveState.SelectedItem?.ToString() == "Archived";

            if (clickedColumnName == "Delete")
            {
                if (showArchived)
                {
                    // Restore (Unarchive)
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to restore transaction ID: {transacId}?",
                        "Confirm Restore",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        TransactionDelete deleter = new TransactionDelete();
                        bool wasRestored = deleter.UnarchiveTransaction(transacId); // Implement this method

                        if (wasRestored)
                        {
                            Console.WriteLine("✅ Transaction restored successfully.");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Transaction not found or already active.");
                        }

                        ReloadTransactions.LoadTransactionData(TransactionRecordsTable, showArchived);
                    }
                }
                else
                {
                    // Delete (Archive)
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

                        ReloadTransactions.LoadTransactionData(TransactionRecordsTable, showArchived);
                    }
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

        private void TransactionRecordsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Replace "TotalAmount" with the actual column name if different
            if (TransactionRecordsTable.Columns[e.ColumnIndex].Name == "TotalAmount" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal amount))
                {
                    e.Value = $"₱{amount:N2}";
                    e.FormattingApplied = true;
                }
            }
        }

        private void ArchiveState_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool showArchived = archiveState.SelectedItem?.ToString() == "Archived";
            ReloadTransactions.LoadTransactionData(TransactionRecordsTable, showArchived);

            // Update Delete/Restore column
            var deleteCol = TransactionRecordsTable.Columns["Delete"] as DataGridViewImageColumn;
            if (deleteCol != null)
            {
                if (showArchived)
                {
                    deleteCol.HeaderText = "Restore";
                    deleteCol.Image = Properties.Resources.restore; // Use your restore icon resource
                }
                else
                {
                    deleteCol.HeaderText = "Delete";
                    deleteCol.Image = Properties.Resources.delete; // Use your delete icon resource
                }
            }
        }
    }

    public static class ReloadTransactions
    {
        public static void LoadTransactionData(DataGridView dataGridView1, bool showArchived = false)
        {
            dataGridView1.Rows.Clear();
            TransactionRead reader = new TransactionRead();
            List<TransactionItem> transactions = reader.GetAllTransactions(showArchived);

            foreach (var transaction in transactions)
            {
                dataGridView1.Rows.Add(
                    transaction.transacId,
                    transaction.transacDate.ToString("yyyy-MM-dd"),
                    transaction.customerType,
                    transaction.customerName,
                    transaction.employeeName,
                    transaction.totalNumOfItems,
                    transaction.totalNumOfQty.ToString("N2"),
                    transaction.totalAmount.ToString("N2")
                );
            }
        }
    }


}