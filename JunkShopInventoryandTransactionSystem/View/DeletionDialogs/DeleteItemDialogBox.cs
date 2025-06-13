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
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Delete;

namespace JunkShopInventoryandTransactionSystem.View.DeletionDialogs
{
    public partial class DeleteItemDialogBox : Form
    {
        private DataGridView _targetDataGridView;
        private int? itemId;

        public DeleteItemDialogBox(int itemId, DataGridView dgv)
        {
            InitializeComponent();

            this.itemId = itemId;
            _targetDataGridView = dgv;

            if (itemId <= 0)
            {
                MessageBox.Show("Invalid item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //gets the details from the database itself and not from the DataGridView
            InventoryItem? item = new InventoryRead().GetOneInventoryItem(itemId);

            if (item == null)
            {
                MessageBox.Show("Item not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //puts the values in the widgets
            ItemIDTextHolder.Text = item.itemId.ToString();
            ItemNameTextHolder.Text = item.itemName;
            ItemcatTextHolder.Text = item.itemCategory;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            bool itemDeleteSuccess = DeleteItemInInventory.HandleDeleteItem(itemId.Value, _targetDataGridView);

            if (itemDeleteSuccess)
            {
                // Closes the form
                Close();
            }
            else
            {
                // Handle validation errors inside HandleDeleteItem
                MessageBox.Show("Failed to delete the item.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
