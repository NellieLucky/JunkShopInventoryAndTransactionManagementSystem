using JunkShopInventoryandTransactionSystem.View.InvoiceReceipt;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.BuyerLogic;
// access the constructor model for transaction cart
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.ConstructorModel;
using JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel;
using JunkShopInventoryandTransactionSystem.View.DeletionDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View.GenerateTransactionPageFolder
{
    public partial class BuyerTransaction : UserControl
    {
        // constructor for the cart item
        private List<CartItem> tempCart = new List<CartItem>();
        private int _totalItems;
        private decimal _totalPrice;

        public BuyerTransaction()
        {
            InitializeComponent();

            // Loads item name instead of itemId in the combobox
            LoadItemIdDetails();

            // defaul zero value of the two labels below
            UpdateTransactionSummaryLabels();

            BuyersOrderTable.CellFormatting += TransactionTable_CellFormatting;
        }

        private void BuyerAddTransacBtn_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(BuyerItemComboBox.SelectedValue);
            string itemQty = BuyerQtyTextBox.Content;

            // Check if item is already added in the gridview
            bool alreadyInCart = tempCart.Any(item => item.ItemId == itemId);
            if (alreadyInCart)
            {
                MessageBox.Show("This item is already added to the cart.", "Item Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool addSuccess = BuyerTransaction_Backend.HandleBuyerTransaction(
                itemId,
                itemQty,
                BuyersOrderTable,
                tempCart
            );

            if (addSuccess)
            {
                //clears the two widget
                BuyerItemComboBox.SelectedIndex = -1;
                BuyerQtyTextBox.Content = string.Empty;
                UpdateTransactionSummaryLabels(); // Update the transaction summary labels after adding an item
            }
            else
            {
                MessageBox.Show("Failed to add item to cart. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // is responsible for the values of item combo box
        private void LoadItemIdDetails()
        {
            // get the items from the inventory crud read all and put it in this combobox
            InventoryRead inventoryReader = new InventoryRead();
            var inventoryItems = inventoryReader.GetAllInventoryItems();  // Access the method

            // BuyerItemComboBox is the combobox for itemId, but instead of displaying itemId, we will display itemName
            BuyerItemComboBox.DataSource = null; // Clear previous data source
            BuyerItemComboBox.DataSource = inventoryItems;
            BuyerItemComboBox.DisplayMember = "itemName";  // What to show
            BuyerItemComboBox.ValueMember = "itemId";      // What value is bound internally
            BuyerItemComboBox.SelectedIndex = -1;          // Optional: no selection by default

        }

        // is responsible for the values of total items and total price labels
        private void UpdateTransactionSummaryLabels()
        {
            // TotalItemsCounterLabel: counts the number of unique items (rows) in the grid
            _totalItems = BuyersOrderTable.Rows.Count;
            TotalItemsCounterLabel.Text = _totalItems.ToString();

            _totalPrice = 0;
            foreach (DataGridViewRow row in BuyersOrderTable.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    _totalPrice += Convert.ToDecimal(row.Cells[5].Value);
                }
            }

            // Formats the total price with commas and no decimals for better readability.
            // Example: 12500 becomes "₱12,500"
            TotalPriceAmntCounterLabel.Text = "₱ " + _totalPrice.ToString("N2");
        }
        // end of the code for updating the transaction summary labels

        private void BuyerClearBtn_Click(object sender, EventArgs e)
        {
            // the two widgets above will be cleared
            BuyerItemComboBox.SelectedIndex = -1;
            BuyerQtyTextBox.Content = string.Empty;

            // clear the gridview
            // Clears the DataGridView
            //BuyersOrderTable.DataSource = null;   //this wasnt working for some reason
            BuyersOrderTable.Rows.Clear();
            // clears the temporary cart
            tempCart.Clear();

            // clears the two widgets below
            BuyerNameTextBox.Content = string.Empty;
            BuyerContactTextBox.Content = string.Empty;

            // resets the value of total items n price since cart and grid is emptied
            UpdateTransactionSummaryLabels();
        }

        private void SaveBuyerTransaction_Button_Click(object sender, EventArgs e)
        {
            // trims white spaces before passing them to the backend
            string buyerName = BuyerNameTextBox.Content.Trim();
            string buyerContact = BuyerContactTextBox.Content.Trim();

            bool finalized = BuyerTransaction_Backend.FinalizeTransaction(
                tempCart,
                buyerName,
                buyerContact,
                BuyersOrderTable
            );

            if (finalized)
            {
                //call receipt.cs here
                var receiptForm = new receiptlogo(
                    BuyersOrderTable, // <-- the actual DataGridView where items were added
                    buyerName,
                    buyerContact,
                     _totalItems,
                     _totalPrice
                );
                receiptForm.Show();

                // the two widgets above will be cleared
                BuyerItemComboBox.SelectedIndex = -1;
                BuyerQtyTextBox.Content = string.Empty;

                // clear the gridview
                BuyersOrderTable.Rows.Clear();
                // clears the temporary cart
                tempCart.Clear();

                // clears the two widgets below
                BuyerNameTextBox.Content = string.Empty;
                BuyerContactTextBox.Content = string.Empty;

                TotalItemsCounterLabel.Text = string.Empty;
                TotalPriceAmntCounterLabel.Text = string.Empty;

                MessageBox.Show("Transaction finalized successfully.");
            }
            else
            {
                MessageBox.Show("Something went wrong finalizing the transaction.");
            }

        }

        private void BuyersOrderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(BuyersOrderTable.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = BuyersOrderTable.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = BuyersOrderTable.Rows[e.RowIndex];
            int itemId = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);

            if (clickedColumnName == "Remove")
            {
                // Show confirmation message with the itemId
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to remove item with ID: {itemId}?",
                    "Confirm Item Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // 1. Remove from cart
                    tempCart.RemoveAll(item => item.ItemId == itemId);

                    // 2. Remove from grid view
                    BuyersOrderTable.Rows.RemoveAt(e.RowIndex);

                    // 3. Refresh totals
                    UpdateTransactionSummaryLabels();
                }

            }

        }

        private void TransactionTable_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = BuyersOrderTable.Columns[e.ColumnIndex].Name;
            if (columnName == "SellingPrice" || columnName == "ExchangeAmount")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal amount))
                {
                    e.Value = string.Format(new System.Globalization.CultureInfo("en-PH"), "{0:C2}", amount);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
