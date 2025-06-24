using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
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

namespace JunkShopInventoryandTransactionSystem.View.CustomerRecordsPage
{
    public partial class SellerRecordsPage : UserControl
    {
        public SellerRecordsPage()
        {
            InitializeComponent();
            LoadSellerRecords();
            searchTextBox.ContentChanged += SearchTextBox_ContentChanged;
            searchButton.Click += searchButton_Click;

            var userInfo = ForUser.GetUserInfo(UserSession.UserId);
            if (userInfo.Role == "Employee")
            {
                dataGridView2.Columns["Delete"].Visible = false; //Change dataGridView1 to actual name of grid view
            }
        }

        private void LoadSellerRecords()
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

        private void FilterRows(string searchText)
        {
            string lowerSearch = searchText?.Trim().ToLower() ?? string.Empty;

            foreach (DataGridViewRow row in sellerRecordsTable.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = string.IsNullOrEmpty(lowerSearch);

                if (!visible)
                {
                    foreach (DataGridViewColumn col in sellerRecordsTable.Columns)
                    {
                        if (!col.Visible || col.Name == "DeleteColumn") continue;

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

        private void SearchTextBox_ContentChanged(object sender, EventArgs e)
        {
            FilterRows(searchTextBox.Content);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FilterRows(searchTextBox.Content);
        }

        private void sellerRecordsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
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

                    LoadSellerRecords();
                }
            }
        }
    }
}
