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
    public partial class SellerRecordsPage : UserControl
    {
        public SellerRecordsPage()
        {
            InitializeComponent();
            LoadSellerREcords();
        }

        private void LoadSellerREcords()
        {
            sellerRecordsTable.Rows.Clear();
            var sellerRead = new BackendFiles.Customer.SellerRead();
            var sellers = sellerRead.GetSellerSummaries();
            foreach (var seller in sellers)
            {
                sellerRecordsTable.Rows.Add(
                    seller.CustomerID,
                    seller.Name,
                    seller.customerContact,
                    seller.TotalSalesTransaction,
                    seller.TotalAmountSold,
                    seller.TotalQuantitySold
                );
            }
        }

        private void BuyerRec_Click(object sender, EventArgs e)
        {

        }

        private void sellerRecordsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(sellerRecordsTable.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = sellerRecordsTable.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = sellerRecordsTable.Rows[e.RowIndex];
            int customerId = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);

            if (clickedColumnName == "DeleteColumn")
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete records of seller ID: {customerId}?",
                    "Confirm Seller Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    var deleter = new JunkShopInventoryandTransactionSystem.BackendFiles.Customer.Crud.CustomerDelete();
                    bool wasArchived = deleter.ArchiveCustomer(customerId);

                    if (wasArchived)
                    {
                        MessageBox.Show("✅ Seller archived (soft deleted) successfully.");
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Seller not found or already archived.");
                    }

                    // Reload the seller records table
                    LoadSellerREcords();
                }
            }
        }
    }
}
