//imports the backend file InventoryCrud.cs
using JunkShopInventoryandTransactionSystem.BackendFiles.ReloadInventory;

using JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class ItemRecordsPage : UserControl
    {
        private AddEditInventoryItem addEditInventoryItemDialogBox = null!; // Initialize with null-forgiving operator 

        //placed that in a backend file named as ReloadInventory.cs

        public ItemRecordsPage()
        {
            InitializeComponent();

            // Call the static LoadInventoryData method from ReloadInventory
            ReloadInventory.LoadInventoryData(dataGridView1);

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
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if ( addEditInventoryItemDialogBox == null || addEditInventoryItemDialogBox.IsDisposed ) // Check if it's already open  
            {
                string value = "Add"; // Set the mode to "Add"
                //pass the data grid view to allow refreshing of inventory after adding/editing an item
                addEditInventoryItemDialogBox = new AddEditInventoryItem(value, dataGridView1);
                addEditInventoryItemDialogBox.Show();
            }
            else
            {
                addEditInventoryItemDialogBox.Focus(); // Bring existing form to front 
            }
        }
    }
}
