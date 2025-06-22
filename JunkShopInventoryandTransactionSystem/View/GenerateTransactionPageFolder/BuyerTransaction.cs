
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.BuyerLogic;
// access the constructor model for transaction cart
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.ConstructorModel;

namespace JunkShopInventoryandTransactionSystem.View.GenerateTransactionPageFolder
{
    public partial class BuyerTransaction : UserControl
    {
        // constructor for the cart item
        private List<CartItem> tempCart = new List<CartItem>();

        public BuyerTransaction()
        {
            InitializeComponent();

            // Loads item name instead of itemId in the combobox
            LoadItemIdDetails();

            // defaul zero value of the two labels below
            UpdateTransactionSummaryLabels();
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
            int totalItems = BuyersOrderTable.Rows.Count;
            TotalItemsCounterLabel.Text = totalItems.ToString();

            decimal totalPrice = 0;
            foreach (DataGridViewRow row in BuyersOrderTable.Rows)
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
                tempCart.Clear();
                BuyersOrderTable.Rows.Clear();
                MessageBox.Show("Transaction finalized successfully.");
            }
            else
            {
                MessageBox.Show("Something went wrong finalizing the transaction.");
            }

        }

        private void BuyerQtyTextBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
