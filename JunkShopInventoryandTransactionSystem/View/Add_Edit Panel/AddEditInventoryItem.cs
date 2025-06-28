
// imports for functions

// imports the whole query of category but only calls the necessary query for the category combobox
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
// imports for INVENTORY ACTIONS
// mainly for BACKEND LOGIC, validation checking of values, also calls specific queries inside them
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Add;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Edit;
// CRUD mainly for QUERY
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel
{
    public partial class AddEditInventoryItem : Form
    {
        private string value;
        private DataGridView _targetDataGridView;
        private int? itemId;

        public class Category
        {
            public int categoryId { get; set; }
            public string categoryName { get; set; } = string.Empty;

            public Category() { }

            // override ToString so it displays properly in the ComboBox
            public override string ToString()
            {
                return categoryName;
            }
        }

        // constructor for Add function only
        public AddEditInventoryItem(string value, DataGridView dgv)
        {
            InitializeComponent();
            LoadCategoryComboBox();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;

            // checks the value and updates the label widgets accordingly for ADD FUNCTION
            if (this.value == "Add")
            {
                //replaces the dashboard title and button with "Add Item"
                DashboardTitlePage.Text = "Add Item";
                AddEditButton.Content = "Add Item";
                this.Text = "Add Item";
                this.Icon = Icon.FromHandle(Properties.Resources.add.GetHicon());
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
            LoadCategoryComboBox();

            this.value = value;     //receives "Edit"
            _targetDataGridView = dgv;  // receives the grid view to allow refresh after editing
            this.itemId = itemId;   //receives the item ID to edit

            // checks the value and updates the label widgets accordingly for EDIT / UPDATE FUNCTION
            if (this.value == "Edit")
            {
                //replaces the dashboard title and button with "Edit Item" 
                DashboardTitlePage.Text = "Edit Item";
                AddEditButton.Content = "Edit Item";
                this.Text = "Edit Item";
                this.Icon = Icon.FromHandle(Properties.Resources.pen.GetHicon());
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
            // Declare variables to store values inside widgets
            string itemName = TextBox_ofItemNameLabel.Content;
            int itemCatId = Convert.ToInt32(CategoryComboBox.SelectedValue);
            string itemQtyType = QtyTypeComboBox.SelectedItem as string ?? string.Empty;
            string STRitemQuantity = TextBox_ofQtyLabel.Content;
            string STRitemBuyingPrice = TextBox_ofBuyingPriceLabel.Content;
            string STRitemSellingPrice = TextBox_ofSellingPriceLabel.Content;

            // checks if its content is ADD to do ADD BACKEND LOGIC
            if (AddEditButton.Content == "Add Item")
            {
                // goes to BACKEND FILE will return TRUE if successful
                bool addSuccess = AddToInventory.HandleAddItem(
                    itemName,
                    itemCatId,
                    itemQtyType,
                    STRitemQuantity,
                    STRitemBuyingPrice,
                    STRitemSellingPrice,
                    _targetDataGridView
                );

                if (addSuccess)
                {
                    // Clear fields
                    TextBox_ofItemNameLabel.Content = string.Empty;
                    QtyTypeComboBox.Text = string.Empty;
                    TextBox_ofQtyLabel.Content = string.Empty;
                    TextBox_ofBuyingPriceLabel.Content = string.Empty;
                    TextBox_ofSellingPriceLabel.Content = string.Empty;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot add item: Unknown Error.", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // checks if its content is EDIT to do EDIT/UPDATE BACKEND LOGIC
            else if (AddEditButton.Content == "Edit Item")
            {
                if (itemId.HasValue)
                {
                    // goes to BACKEND FILE will return TRUE if successful
                    bool editSuccess = EditInventory.HandleEditItem(
                        itemId.Value,
                        itemName,
                        itemCatId,
                        itemQtyType,
                        STRitemQuantity,
                        STRitemBuyingPrice,
                        STRitemSellingPrice,
                        _targetDataGridView
                    );

                    if (editSuccess)
                    {
                        TextBox_ofItemNameLabel.Content = string.Empty;
                        QtyTypeComboBox.Text = string.Empty;
                        TextBox_ofQtyLabel.Content = string.Empty;
                        TextBox_ofBuyingPriceLabel.Content = string.Empty;
                        TextBox_ofSellingPriceLabel.Content = string.Empty;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cannot edit item: Unknown Error.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // checks if its content is EITHER ADD OR EDIT
                else
                {
                    MessageBox.Show("Item ID is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Unknown button state: " + AddEditButton.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // loads values on category combo box
        // is a reference to the category database
        private void LoadCategoryComboBox()
        {
            try
            {
                CategoryRead reader = new CategoryRead();
                var categories = reader.GetAllCategories().ToList();

                if (categories == null || categories.Count == 0)
                {
                    MessageBox.Show("No categories found. Please add categories first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CategoryComboBox.DataSource = null; // Clear previous data source
                CategoryComboBox.DataSource = categories;
                CategoryComboBox.DisplayMember = "categoryName";
                CategoryComboBox.ValueMember = "categoryId";
                CategoryComboBox.SelectedIndex = -1; // No selection by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // gets the item details using PASSED ITEM ID to get its value and place it in the widgets
        // when EDITING / UDPATING
        private void LoadItemDetails()
        {
            if (!itemId.HasValue) return;
            
            // Get the item details
            InventoryItem? item = new InventoryRead().GetOneInventoryItem(itemId.Value);

            if (item == null)
            {
                MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Set item name
            TextBox_ofItemNameLabel.Content = item.itemName;

            // Load categories and select the correct one
            CategoryRead categoryReader = new CategoryRead();
            var categories = categoryReader.GetAllCategories().ToList();
            
            // Set the categories as the data source
            CategoryComboBox.DataSource = null; // Clear previous data source
            CategoryComboBox.DataSource = categories;
            CategoryComboBox.DisplayMember = "categoryName";
            CategoryComboBox.ValueMember = "categoryId";

            // Set the selected category
            CategoryComboBox.SelectedValue = item.itemCategoryId;

            // Set other values
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
