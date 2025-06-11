
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
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Add;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Edit;

namespace JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel
{
    public partial class AddEditInventoryItem : Form
    {
        // will hold the value passed to the constructor
        private string value;
        private DataGridView _targetDataGridView;
        private int? itemId; // This will hold the item ID if editing
        //added ? to make it nullable, useful for edit mode as per gpt

        // constructor for Add function only
        // Modified constructor to accept the DataGridView
        public AddEditInventoryItem(string value, DataGridView dgv)
        {
            InitializeComponent();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;

            // checks the value
            if (this.value == "Add")
            {
                //replaces the dashboard title and button with "Add Item"
                DashboardTitlePage.Text = "Add Item";
                AddEditButton.Content = "Add Item";
            }
            else
            {
                // for checking
                DashboardTitlePage.Text = "ADD ERROR DO NOT PROCEED";
                AddEditButton.Content = "ERROR DO NOT CLICK-INFORM BACK-ENDERS IMMEDIATELY";
            }
            
        }

        // constructor for Edit function only
        public AddEditInventoryItem(string value, DataGridView dgv, int itemId)
        {
            InitializeComponent();

            this.value = value;     //receives "Edit"
            _targetDataGridView = dgv;  // receives the grid view to allow refresh after editing
            this.itemId = itemId;   //receives the item ID to edit

            if (this.value == "Edit")
            {
                //replaces the dashboard title and button with "Edit Item" 
                DashboardTitlePage.Text = "Edit Item";
                AddEditButton.Content = "Edit Item";
            }
            else
            {
                // for checking
                DashboardTitlePage.Text = "EDIT ERROR DO NOT PROCEED";
                AddEditButton.Content = "ERROR DO NOT CLICK-INFORM BACK-ENDERS IMMEDIATELY";
            }

            LoadItemDetails();
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            if (AddEditButton.Content == "Add Item")
            {
                //moved them here to ensure they are only executed when adding an item
                //stores the values of the widgets in variables
                string itemName = TextBox_ofItemNameLabel.Content;

                string itemCategory = CategoryComboBox.SelectedItem as string ?? string.Empty;
                string itemQtyType = QtyTypeComboBox.SelectedItem as string ?? string.Empty;

                string STRitemQuantity = TextBox_ofQtyLabel.Content;
                string STRitemBuyingPrice = TextBox_ofBuyingPriceLabel.Content;
                string STRitemSellingPrice = TextBox_ofSellingPriceLabel.Content;

                // passes the values of the widgets to the AddToInventoryHandler 
                bool addSuccess = AddToInventory.HandleAddItem(
                    itemName,
                    itemCategory,
                    itemQtyType,
                    STRitemQuantity,
                    STRitemBuyingPrice,
                    STRitemSellingPrice,
                    _targetDataGridView // Pass the stored DataGridView
                );

                //clear the input fields after adding and close the window
                if (addSuccess) // Only clear and close if the item was added successfully
                {
                    TextBox_ofItemNameLabel.Content = string.Empty;
                    // WILL CHECK IF THIS IS WORKING LATER
                    QtyTypeComboBox.Text = string.Empty;    //this isnt working
                    QtyTypeComboBox.Text = string.Empty;    //this isnt working too
                    TextBox_ofQtyLabel.Content = string.Empty;      
                    TextBox_ofBuyingPriceLabel.Content = string.Empty;
                    TextBox_ofSellingPriceLabel.Content = string.Empty;

                    //Closes the form
                    this.Close();
                }
                else
                {
                    // added this for checking incase of error
                    MessageBox.Show("Cannot add item: Unknown Error.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (AddEditButton.Content == "Edit Item")
            {
                if (itemId.HasValue)
                {
                    string upName = TextBox_ofItemNameLabel.Content;
                    string upCat = CategoryComboBox.Text;
                    string upQtyT = QtyTypeComboBox.Text;
                    string upQty = TextBox_ofQtyLabel.Content;
                    string upBuy = TextBox_ofBuyingPriceLabel.Content;
                    string upSell = TextBox_ofSellingPriceLabel.Content;

                    bool success = EditInventory.HandleEditItem(
                        itemId.Value, upName, upCat, upQtyT, upQty, upBuy, upSell, _targetDataGridView
                    );

                    if (success)
                    {
                        //closes the form
                        Close();
                    }
                    else
                    {
                        // Handle validation errors inside HandleEditItem
                    }
                }
            }
            else
            {
                MessageBox.Show("Unknown button state: " + AddEditButton.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadItemDetails()
        {
            if (!itemId.HasValue) return;
            InventoryItem? item = new InventoryRead().GetOneInventoryItem(itemId.Value);

            if (item == null)
            {
                MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Populate widgets using .Text, not .Content
            TextBox_ofItemNameLabel.Content = item.itemName;
            CategoryComboBox.Text = item.itemCategory;
            QtyTypeComboBox.Text = item.itemQtyType;
            TextBox_ofQtyLabel.Content = item.itemQuantity.ToString();
            TextBox_ofBuyingPriceLabel.Content = item.itemBuyingPrice.ToString();
            TextBox_ofSellingPriceLabel.Content = item.itemSellingPrice.ToString();
        }

        // Close Button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
