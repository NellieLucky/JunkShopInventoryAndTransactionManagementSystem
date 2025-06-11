
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//imports the backend file AddToInventory.cs
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Add;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Edit;

namespace JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel
{
    public partial class AddEditInventoryItem : Form
    {
        // will hold the value passed to the constructor
        private string value;
        private DataGridView _targetDataGridView;

        private int itemId; // This will hold the item ID if editing

        // Modified constructor to accept the DataGridView
        public AddEditInventoryItem(string value, DataGridView dgv)
        {
            InitializeComponent();
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;

            this.value = value;

            // checks the value
            if (this.value == "Add")
            {
                //replaces the dashboard title and button with "Add Item"
                DashboardTitlePage.Text = "Add Item";
                AddEditButton.Content = "Add Item";
            }

            if (this.value == "Edit")
            {
                //replaces the dashboard title and button with "Edit Item" 
                DashboardTitlePage.Text = "Edit Item";
                AddEditButton.Content = "Edit Item";
            }
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            //stores the values of the widgets in variables
            string itemName = TextBox_ofItemNameLabel.Content;
            string itemCategory = ComboBox_ofCategoryLabel.SelectedItem as string;
            string itemQtyType = ComboBox_ofQtyTypeLabel.SelectedItem as string;

            string STRitemQuantity = TextBox_ofQtyLabel.Content;
            string STRitemBuyingPrice = TextBox_ofBuyingPriceLabel.Content;
            string STRitemSellingPrice = TextBox_ofSellingPriceLabel.Content;

            if (AddEditButton.Content == "Add Item")
            {
                // passes the values of the widgets to the AddToInventoryHandler 
                bool success = AddToInventory.HandleAddItem(
                    itemName,
                    itemCategory,
                    itemQtyType,
                    STRitemQuantity,
                    STRitemBuyingPrice,
                    STRitemSellingPrice,
                    _targetDataGridView // Pass the stored DataGridView
                );

                //clear the input fields after adding and close the window
                if (success) // Only clear and close if the item was added successfully
                {
                    TextBox_ofItemNameLabel.Content = string.Empty;
                    ComboBox_ofCategoryLabel.Text = string.Empty;
                    ComboBox_ofQtyTypeLabel.Text = string.Empty;    //this isnt working
                    TextBox_ofQtyLabel.Content = string.Empty;      //this isnt working too
                    TextBox_ofBuyingPriceLabel.Content = string.Empty;
                    TextBox_ofSellingPriceLabel.Content = string.Empty;

                    //Closes the form
                    this.Close();
                }
            }
            /*
            else if (AddEditButton.Content == "Edit Item")
            {
                // 
                // For editing, you'll typically need an ID of the item being edited.
                // This ID would usually be passed to this dialog when it's opened in "Edit" mode,
                // or stored in a private field of the AddEditInventoryItem form.
                int itemIdToEdit = GetItemIdFromForm(); // Placeholder: You need to implement this

                if (itemIdToEdit == 0) // Basic check: Ensure you have an ID to edit
                {
                    MessageBox.Show("Cannot edit item: Item ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assuming you have an InventoryCrud class with an UpdateItem method
                InventoryEdit edit = new InventoryEdit();

                // Call the UpdateItem method, passing the ID and all six variables
                edit.UpdateItem(itemIdToEdit, itemName, itemCategory, itemQtyType, itemQuantity, itemBuyingPrice, itemSellingPrice);

                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
            else
            {
                MessageBox.Show("Unknown button state: " + AddEditButton.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
