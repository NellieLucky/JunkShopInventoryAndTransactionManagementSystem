using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Reload
{
    public class ReloadTransactions
    {
        // Load all unarchived transactions into the DataGridView
        public static void LoadTransactionData(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear(); // Clear previous rows

            TransactionRead reader = new TransactionRead();
            List<TransactionItem> transactions = reader.GetAllTransactions();

            foreach (var transaction in transactions)
            {
                dataGridView1.Rows.Add(
                    transaction.transacId,
                    transaction.transacDate.ToString("yyyy-MM-dd"),
                    transaction.customerType,
                    //transaction.transacDate.ToString("yyyy-MM-dd HH:mm"),
                    transaction.customerName,
                    transaction.employeeName,
                    transaction.totalNumOfItems,
                    transaction.totalNumOfQty,
                    transaction.totalAmount
                );
            }
        }

    }

}
