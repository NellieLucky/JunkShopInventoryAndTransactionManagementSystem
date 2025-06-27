using JunkShopInventoryandTransactionSystem.BackendFiles.Customer;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Reload;
﻿using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
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
    public partial class BuyerRecordsPage : UserControl
    {
        public BuyerRecordsPage()
        {
            InitializeComponent();
            searchTextBox.ContentChanged += SearchTextBox_ContentChanged;
            searchButton.Click += SearchButton_Click;
            LoadBuyerRecords();

            BuyerRecordsTable.CellFormatting += BuyerRecordsTable_CellFormatting;


            var userInfo = ForUser.GetUserInfo(UserSession.UserId);
            if (userInfo.Role == "Employee")
            {
                BuyerRecordsTable.Columns["CustomerDelete"].Visible = false; //Change dataGridView1 to actual name of grid view
            }
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
            FilterRows(searchTextBox.Content); // custom control property
        }

        private void SearchTextBox_ContentChanged(object sender, EventArgs e)
        {
            FilterRows(searchTextBox.Content); // custom control property
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

        private void BuyerRecordsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
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

                    LoadBuyerRecords();
                }
            }
        }

        private void BuyerRecordsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Replace "TotalPurchasePrice" with your actual column name if different
            if (BuyerRecordsTable.Columns[e.ColumnIndex].Name == "TotalPricePurchases" && e.Value != null)
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
