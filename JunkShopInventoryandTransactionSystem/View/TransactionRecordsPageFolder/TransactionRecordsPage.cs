
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Reload;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud;

namespace JunkShopInventoryandTransactionSystem.View.TransactionRecordsPageFolder
{
    public partial class TransactionRecordsPage : UserControl
    {
        public TransactionRecordsPage()
        {
            InitializeComponent();

            ReloadTransactions.LoadTransactionData(TransactionRecordsTable);
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
                    bool wasDeleted = deleter.DeleteTransaction(transacId);

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

        }
    }
}
