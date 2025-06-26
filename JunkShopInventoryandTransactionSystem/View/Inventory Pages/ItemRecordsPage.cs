
// imports for functions

// imports for inventory actions
// specific backend files consisting of actions
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Archiving;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Unarchive;
// for refreshing of values for the table grid view
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Reload;
// for frontend
using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel;
using JunkShopInventoryandTransactionSystem.View.DeletionDialogs;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;

namespace JunkShopInventoryandTransactionSystem.View.Inventory_Pages
{
    public partial class ItemRecordsPage : UserControl
    {
        private AddEditInventoryItem addEditInventoryItemDialogBox = null!; // Initialize with null-forgiving operator 
        private DeleteItemDialogBox deleteItemDialogBox = null!;

        //placed that in a backend file named as ReloadInventory.cs

        public ItemRecordsPage()
        {
            InitializeComponent();

            archiveState.SelectedIndexChanged += ArchiveState_SelectedIndexChanged;
            archiveState.SelectedIndex = 0; // triggers default load

            // Add these lines after InitializeComponent()
            SearchButton.Click += SearchButton_Click;
            SearchTextBox.ContentChanged += SearchTextBox_TextChanged; // Use ContentChanged instead of KeyPress

                /*
                //Pangtest lang to if msgkakalaman
                dataGridView1.Rows.Add("1", "Copper A", "Tanso", "PerWeight", "10", "100", "1");
                dataGridView1.Rows.Add("1", "3F", "Batteries", "PerPiece", "10", "100", "1");
                dataGridView1.Rows.Add("1", "Copper A", "Tanso", "PerWeight", "10", "100", "1");
                dataGridView1.Rows.Add("1", "3F", "Batteries", "PerPiece", "10", "100", "1");
                dataGridView1.Rows.Add("1", "Copper A", "Tanso", "PerWeight", "10", "100", "1");
                dataGridView1.Rows.Add("1", "3F", "Batteries", "PerPiece", "10", "100", "1");
                dataGridView1.Rows.Add("1", "Copper A", "Tanso", "PerWeight", "10", "100", "1");
                dataGridView1.Rows.Add("1", "3F", "Batteries", "PerPiece", "10", "100", "1");
                dataGridView1.Rows.Add("1", "Copper A", "Tanso", "PerWeight", "10", "100", "1");
                dataGridView1.Rows.Add("1", "3F", "Batteries", "PerPiece", "10", "100", "1");
                dataGridView1.Rows.Add("1", "Copper A", "Tanso", "PerWeight", "10", "100", "1");
                dataGridView1.Rows.Add("1", "3F", "Batteries", "PerPiece", "10", "100", "1");
                dataGridView1.Rows.Add("1", "Copper A", "Tanso", "PerWeight", "10", "100", "1");
                dataGridView1.Rows.Add("1", "3F", "Batteries", "PerPiece", "10", "100", "1");
                */

            ItemRecordsTable.Columns["Edit"].HeaderText = ""; 
            ItemRecordsTable.Columns["Delete"].HeaderText = ""; // Set header text for Edit and Delete columns to empty
            ItemRecordsTable.Paint += DataGridView1_Paint; // Attach the Paint event handler to the DataGridView

            // Hide Add/Delete/Edit column if user is Employee
            var userInfo = ForUser.GetUserInfo(UserSession.UserId);
            if (userInfo.Role == "Employee")
            {
                ItemRecordsTable.Columns["Edit"].Visible = false;
                ItemRecordsTable.Columns["Delete"].Visible = false;


                AddItemButton.Visible = false;
            }
        }

        private void ArchiveState_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (archiveState.SelectedIndex == 0)
            {
                // if archived state is 0
                // we are in non-archived options
                // were gonna see non-archived items
                ReloadInventory.LoadInventoryData(ItemRecordsTable);
            }
            else
            {
                // if archived state is 1
                // we are in archived options
                // were gonna see archived items
                ReloadInventory.LoadArchivedInventoryData(ItemRecordsTable);
            }
        }

        private void DataGridView1_Paint(object? sender, PaintEventArgs e)
        {
            // Get the rectangles for the Edit and Delete header cells  
            var editRect = ItemRecordsTable.GetCellDisplayRectangle(ItemRecordsTable.Columns["Edit"].Index, -1, true);
            var deleteRect = ItemRecordsTable.GetCellDisplayRectangle(ItemRecordsTable.Columns["Delete"].Index, -1, true);

            // Calculate the merged rectangle  
            Rectangle mergedRect = new Rectangle(
                editRect.Left,
                editRect.Top,
                deleteRect.Right - editRect.Left,
                editRect.Height
            );

            // Draw the merged header background  
            using (SolidBrush backColorBrush = new SolidBrush(ItemRecordsTable.ColumnHeadersDefaultCellStyle.BackColor))
            {
                e.Graphics.FillRectangle(backColorBrush, mergedRect);
            }

            // Draw the header text centered  
            using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (SolidBrush foreColorBrush = new SolidBrush(ItemRecordsTable.ColumnHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString("Actions", ItemRecordsTable.ColumnHeadersDefaultCellStyle.Font, foreColorBrush, mergedRect, format);
            }
        }

        // add checked

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // this .IsDisposed is causing the combobox error - have to do something with this
            if (addEditInventoryItemDialogBox == null || addEditInventoryItemDialogBox.IsDisposed) // Check if it's already open  
            {
                string value = "Add"; // Set the mode to "Add"
                //pass the data grid view to allow refreshing of inventory after adding/editing an item
                addEditInventoryItemDialogBox = new AddEditInventoryItem(value, ItemRecordsTable);
                addEditInventoryItemDialogBox.Show();
            }
            else
            {
                addEditInventoryItemDialogBox.Focus(); // Bring existing form to front 
            }
        }

        // Eto yung para sa Edit Delete naka img siya, bale eto yung lalagyan ng logic for edit and delete
        private void ItemRecordsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only process if it's a valid row
            if (e.RowIndex < 0) return;

            // Only process clicks on image columns
            if (!(ItemRecordsTable.Columns[e.ColumnIndex] is DataGridViewImageColumn)) return;

            string clickedColumnName = ItemRecordsTable.Columns[e.ColumnIndex].Name;
            DataGridViewRow selectedRow = ItemRecordsTable.Rows[e.RowIndex];
            int itemId = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);

            if (clickedColumnName == "Edit")
            {
                // check first if the archiveState is 0 or 1, if 0 then edit, if 1 then unarchive
                if (archiveState.SelectedIndex == 0)
                {
                    if (addEditInventoryItemDialogBox == null || addEditInventoryItemDialogBox.IsDisposed)
                    {
                        string value = "Edit";
                        addEditInventoryItemDialogBox = new AddEditInventoryItem(value, ItemRecordsTable, itemId);
                        addEditInventoryItemDialogBox.Show();
                    }
                    else
                    {
                        addEditInventoryItemDialogBox.Focus();
                    }
                }
                else
                {
                    // Confirmation message box with item ID
                    DialogResult confirmResult = MessageBox.Show(
                        $"Are you sure you want to unarchive this item?\n\nItem ID: {itemId}",
                        "Unarchiving of Item",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        // calls the unarchiving backend
                        bool unarchivingSuccess = UnarchivingItemInInventory.HandleUnarchivingItem(itemId, ItemRecordsTable);

                        if (unarchivingSuccess)
                        {
                            MessageBox.Show("Item successfully unarchived.", "Successful Unarchiving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to unarchive item. Please try again.", "Unarchive Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            else if (clickedColumnName == "Delete")
            {
                // check first if the archiveState is 0 or 1, if 0 then delete, if 1 then perma delete
                if (archiveState.SelectedIndex == 0)
                {
                    // Confirmation message box with item ID
                    DialogResult confirmResult = MessageBox.Show(
                        $"Are you sure you want to archive this item?\n\nItem ID: {itemId}",
                        "Archiving of Item",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        bool itemArchivingSuccess = ArchivingItemInInventory.HandleArchivingItem(itemId, ItemRecordsTable);

                        if (itemArchivingSuccess)
                        {
                            MessageBox.Show("Successfully archived the item.", "Successful Archiving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to archive the item.", "Archiving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    if (deleteItemDialogBox == null || deleteItemDialogBox.IsDisposed)
                    {
                        deleteItemDialogBox = new DeleteItemDialogBox(itemId, ItemRecordsTable);
                        deleteItemDialogBox.Show();
                    }
                    else
                    {
                        deleteItemDialogBox.Focus();
                    }

                }

            }
        }

        // Update the event handler methods to explicitly allow nullable sender parameters
        private void SearchButton_Click(object? sender, EventArgs e)
        {
            FilterItemRecords(SearchTextBox.Content);
        }

        private void SearchTextBox_TextChanged(object? sender, EventArgs e)
        {
            FilterItemRecords(SearchTextBox.Content);
        }

        // Modify FilterItemRecords to be more efficient
        private void FilterItemRecords(string searchText)
        {
            if (ItemRecordsTable.DataSource is DataTable dataTable)
            {
                try
                {
                    dataTable.DefaultView.RowFilter = string.IsNullOrWhiteSpace(searchText) ? "" :
                        $"Convert(ItemID, 'System.String') LIKE '%{searchText}%' OR " +  // Added ID search
                        $"itemName LIKE '%{searchText}%' OR " +
                        $"itemCategoryName LIKE '%{searchText}%' OR " +
                        $"itemQtyType LIKE '%{searchText}%' OR " +
                        $"Convert(itemQuantity, 'System.String') LIKE '%{searchText}%' OR " +
                        $"Convert(itemBuyingPrice, 'System.String') LIKE '%{searchText}%' OR " +
                        $"Convert(itemSellingPrice, 'System.String') LIKE '%{searchText}%'";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering data: {ex.Message}", "Search Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (DataGridViewRow row in ItemRecordsTable.Rows)
                {
                    bool visible = string.IsNullOrWhiteSpace(searchText);
                    if (!visible)
                    {
                        searchText = searchText.ToLower();
                        visible = row.Cells["ItemID"]?.Value?.ToString()?.Contains(searchText) == true ||  // Added ID search
                                 row.Cells["ItemName"]?.Value?.ToString()?.ToLower().Contains(searchText) == true ||
                                 row.Cells["ItemCategoryName"]?.Value?.ToString()?.ToLower().Contains(searchText) == true ||
                                 row.Cells["ItemQtyType"]?.Value?.ToString()?.ToLower().Contains(searchText) == true ||
                                 row.Cells["ItemQuantity"]?.Value?.ToString()?.Contains(searchText) == true ||
                                 row.Cells["ItemBuyingPrice"]?.Value?.ToString()?.Contains(searchText) == true ||
                                 row.Cells["ItemSellingPrice"]?.Value?.ToString()?.Contains(searchText) == true;
                    }
                    row.Visible = visible;
                }
            }

            // Refresh the view
            ItemRecordsTable.Refresh();
        }
    }
}
