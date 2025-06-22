
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
// access the constructor model for transaction cart
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.ConstructorModel;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.SellerLogic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace JunkShopInventoryandTransactionSystem.View.GenerateTransactionPageFolder
{
    public partial class SellerTransaction : UserControl
    {
        // constructor for the cart item
        private List<CartItem> tempCart = new List<CartItem>();

        public SellerTransaction()
        {
            InitializeComponent();

            // Loads item name instead of itemId in the combobox
            LoadItemIdDetails();

            // defaul zero value of the two labels below
            UpdateTransactionSummaryLabels();
        }

        private void SellerAddTransacBtn_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(SellerItemComboBox.SelectedValue);
            string itemQty = SellerQtyTextBox.Content;

            // Check if item is already added in the gridview
            bool alreadyInCart = tempCart.Any(item => item.ItemId == itemId);
            if (alreadyInCart)
            {
                MessageBox.Show("This item is already added to the cart.", "Item Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool addSuccess = SellerTransaction_Backend.HandleSellerTransaction(
                itemId,
                itemQty,
                SellerOrdersTable,
                tempCart
            );

            if (addSuccess)
            {
                //clears the two widget
                SellerItemComboBox.SelectedIndex = -1;
                SellerQtyTextBox.Content = string.Empty;
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
            SellerItemComboBox.DataSource = null; // Clear previous data source
            SellerItemComboBox.DataSource = inventoryItems;
            SellerItemComboBox.DisplayMember = "itemName";  // What to show
            SellerItemComboBox.ValueMember = "itemId";      // What value is bound internally
            SellerItemComboBox.SelectedIndex = -1;          // Optional: no selection by default

        }

        // is responsible for the values of total items and total price labels
        private void UpdateTransactionSummaryLabels()
        {
            // TotalItemsCounterLabel: counts the number of unique items (rows) in the grid
            int totalItems = SellerOrdersTable.Rows.Count;
            TotalItemsCounterLabel.Text = totalItems.ToString();

            decimal totalPrice = 0;
            foreach (DataGridViewRow row in SellerOrdersTable.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    totalPrice += Convert.ToDecimal(row.Cells[5].Value);
                }
            }

            // Formats the total price with commas and no decimals for better readability.
            // Example: 12500 becomes "₱12,500"
            TotalPriceAmntCounterLabel.Text = "₱ " + totalPrice.ToString("N0");
        }
        // end of the code for updating the transaction summary labels

        private void SellerClearBtn_Click(object sender, EventArgs e)
        {
            // the two widgets above will be cleared
            SellerItemComboBox.SelectedIndex = -1;
            SellerQtyTextBox.Content = string.Empty;

            // clear the gridview
            // Clear the DataGridView
            //SellerOrdersTable.DataSource = null;  //this wasnt working for some reason
            SellerOrdersTable.Rows.Clear();
            // clears the temporary cart
            tempCart.Clear();

            // clears the two widgets below
            SellerNameTextBox.Content = string.Empty;
            SellerContactTextBox.Content = string.Empty;

            // resets the value of total items n price since cart and grid is emptied
            UpdateTransactionSummaryLabels();
        }

        private void SaveSellerTransaction_Button_Click(object sender, EventArgs e)
        {
            // trims white spaces before passing them to the backend
            string sellerName = SellerNameTextBox.Content.Trim();
            string sellerContact = SellerContactTextBox.Content.Trim();

            bool finalized = SellerTransaction_Backend.FinalizeTransaction(
                tempCart,
                sellerName,
                sellerContact,
                SellerOrdersTable
            );

            if (finalized)
            {
                // the two widgets above will be cleared
                SellerItemComboBox.SelectedIndex = -1;
                SellerQtyTextBox.Content = string.Empty;

                // clear the gridview
                // Clear the DataGridView
                //SellerOrdersTable.DataSource = null;  //this wasnt working for some reason
                SellerOrdersTable.Rows.Clear();
                // clears the temporary cart
                tempCart.Clear();

                // clears the two widgets below
                SellerNameTextBox.Content = string.Empty;
                SellerContactTextBox.Content = string.Empty;

                MessageBox.Show("Transaction finalized successfully.");
            }
            else
            {
                MessageBox.Show("Something went wrong finalizing the transaction.");
            }

        }

        private void SellerOrdersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(SellerOrdersTable.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = SellerOrdersTable.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = SellerOrdersTable.Rows[e.RowIndex];
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
                    tempCart.RemoveAll(item => item.ItemId == itemId);
                    SellerOrdersTable.Rows.RemoveAt(e.RowIndex);
                    UpdateTransactionSummaryLabels();
                }

            }

        }
    }
}
