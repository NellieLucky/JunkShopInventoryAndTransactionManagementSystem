
//imports the backend file ReloadInventory.cs
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Reload;
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

            // Call the static LoadInventoryData method from ReloadInventory
            ReloadInventory.LoadInventoryData(ItemRecordsTable);

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
        }

        private void DataGridView1_Paint(object sender, PaintEventArgs e)
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
            // Check if the clicked cell is an image column
            // if e.ColumnIndex value is 8 then its Delete
            // if e.ColumnIndex value is 7 then its Edit
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the itemID from the appropriate cell (e.g., column 0)
                // Get the current row using e.RowIndex
                DataGridViewRow selectedRow = ItemRecordsTable.Rows[e.RowIndex];
                int itemId = Convert.ToInt32(selectedRow.Cells["itemID"].Value);

                if (ItemRecordsTable.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    if (e.ColumnIndex == 7)
                    {
                        //calls the add edit window
                        if (addEditInventoryItemDialogBox == null || addEditInventoryItemDialogBox.IsDisposed) // Check if it's already open  
                        {
                            string value = "Edit"; // Set the mode to "Edit"

                            //pass the data grid view to allow refreshing of inventory after adding/editing an item
                            addEditInventoryItemDialogBox = new AddEditInventoryItem(value, ItemRecordsTable, itemId);
                            addEditInventoryItemDialogBox.Show();
                        }
                        else
                        {
                            addEditInventoryItemDialogBox.Focus(); // Bring existing form to front 
                        }
                    }   // shows a temporary messagebox.show for delete confirmation
                    else if (e.ColumnIndex == 8)
                    {
                        //calls the add edit window
                        if (deleteItemDialogBox == null || deleteItemDialogBox.IsDisposed)
                        {
                            deleteItemDialogBox = new DeleteItemDialogBox(itemId, ItemRecordsTable);
                            deleteItemDialogBox.Show();
                        }
                        else
                        {
                            deleteItemDialogBox.Focus(); // Bring to front if it's already open
                        }
                        
                    }
                }
                else
                {
                    //empty for now
                }
            }
        }
    }
}
