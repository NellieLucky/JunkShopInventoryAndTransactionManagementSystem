
// imports backend file of category for the category combobox
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Add;
//imports the backend file AddToInventory.cs
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Edit;
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
        // Modified constructor to accept the DataGridView
        public AddEditInventoryItem(string value, DataGridView dgv)
        {
            InitializeComponent();
            LoadCategoryComboBox();

            this.value = value;
            // Store the passed DataGridView instance
            _targetDataGridView = dgv;

            // checks the value
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
            // Declare shared values
            string itemName = TextBox_ofItemNameLabel.Content;
            int itemCatId = Convert.ToInt32(CategoryComboBox.SelectedValue);
            string itemQtyType = QtyTypeComboBox.SelectedItem as string ?? string.Empty;
            string STRitemQuantity = TextBox_ofQtyLabel.Content;
            string STRitemBuyingPrice = TextBox_ofBuyingPriceLabel.Content;
            string STRitemSellingPrice = TextBox_ofSellingPriceLabel.Content;

            if (AddEditButton.Content == "Add Item")
            {
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
            else if (AddEditButton.Content == "Edit Item")
            {
                if (itemId.HasValue)
                {
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

        private void LoadCategoryComboBox()
        {
            CategoryRead reader = new CategoryRead();
            var categories = reader.GetAllCategories().ToList();

            CategoryComboBox.DataSource = categories;
            CategoryComboBox.DisplayMember = "categoryName";
            CategoryComboBox.ValueMember = "categoryId";
            CategoryComboBox.SelectedIndex = -1;
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

            TextBox_ofItemNameLabel.Content = item.itemName;

            CategoryComboBox.SelectedIndex = item.itemCategoryId;

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
