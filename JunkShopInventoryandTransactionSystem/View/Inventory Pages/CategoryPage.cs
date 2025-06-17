
//imports the backend file ReloadCategory.cs
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Reload;
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
using static System.Windows.Forms.DataFormats;

namespace JunkShopInventoryandTransactionSystem.View.Inventory_Pages
{
    public partial class CategoryPage : UserControl
    {
        private AddEditCategoryDialogBox addEditCategoryDialogBox = null!; // Initialize with null-forgiving operator  
        private DeleteItemDialogBox deleteItemDialogBox = null!;

        public CategoryPage()
        {
            InitializeComponent();

            // Call the static LoadInventoryData method from ReloadInventory
            // reads unarchived category data from the database and loads it into the DataGridView
            ReloadCategory.LoadCategoryData(CategoryRecordsTable);

            /*
            //Pangtest lang to if msgkakalaman  
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("1", "Metal", "All types of scrap metal", Properties.Resources.pen, Properties.Resources.delete);
            dataGridView1.Rows.Add("2", "Plastic", "Bottles, containers, and more", Properties.Resources.pen, Properties.Resources.delete);
            */

            // Set header text for Edit and Delete columns to empty  
            CategoryRecordsTable.Columns["Edit"].HeaderText = "";
            CategoryRecordsTable.Columns["Delete"].HeaderText = "";

            CategoryRecordsTable.Paint += DataGridView1_Paint;
        }

        //Para to sa pag-merge ng Edit at Delete header cells kasi walang built-in support sa DataGridView para here  
        private void DataGridView1_Paint(object sender, PaintEventArgs e)
        {
            // Get the rectangles for the Edit and Delete header cells  
            var editRect = CategoryRecordsTable.GetCellDisplayRectangle(CategoryRecordsTable.Columns["Edit"].Index, -1, true);
            var deleteRect = CategoryRecordsTable.GetCellDisplayRectangle(CategoryRecordsTable.Columns["Delete"].Index, -1, true);

            // Calculate the merged rectangle  
            Rectangle mergedRect = new Rectangle(
                editRect.Left,
                editRect.Top,
                deleteRect.Right - editRect.Left,
                editRect.Height
            );

            // Draw the merged header background  
            using (SolidBrush backColorBrush = new SolidBrush(CategoryRecordsTable.ColumnHeadersDefaultCellStyle.BackColor))
            {
                e.Graphics.FillRectangle(backColorBrush, mergedRect);
            }

            // Draw the header text centered  
            using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (SolidBrush foreColorBrush = new SolidBrush(CategoryRecordsTable.ColumnHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString("Actions", CategoryRecordsTable.ColumnHeadersDefaultCellStyle.Font, foreColorBrush, mergedRect, format);
            }
        }

        //add button

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (addEditCategoryDialogBox == null || addEditCategoryDialogBox.IsDisposed) // Check if it's already open  
            {
                string value = "Add"; // Set the mode to "Add"
                addEditCategoryDialogBox = new AddEditCategoryDialogBox(value, CategoryRecordsTable);
                addEditCategoryDialogBox.Show();
            }
            else
            {
                addEditCategoryDialogBox.Focus(); // Bring existing form to front  
            }
        }

        private void CategoryRecordsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is an image column
            // if e.ColumnIndex value is 5 then its Delete
            // if e.ColumnIndex value is 4 then its Edit
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                string clickedColumnName = CategoryRecordsTable.Columns[e.ColumnIndex].Name;

                DataGridViewRow selectedRow = CategoryRecordsTable.Rows[e.RowIndex];
                int categoryId = Convert.ToInt32(selectedRow.Cells["CategoryID"].Value);

                if (clickedColumnName == "Edit")
                {
                    //MessageBox.Show($"Edit clicked\nCategoryID: {categoryId}", "Action");

                    //calls the add edit window
                    if (addEditCategoryDialogBox == null || addEditCategoryDialogBox.IsDisposed) // Check if it's already open  
                    {
                        string value = "Edit"; // Set the mode to "Edit"

                        //pass the data grid view to allow refreshing of inventory after adding/editing an item
                        addEditCategoryDialogBox = new AddEditCategoryDialogBox(value, CategoryRecordsTable, categoryId);
                        addEditCategoryDialogBox.Show();
                    }
                    else
                    {
                        addEditCategoryDialogBox.Focus(); // Bring existing form to front 
                    }

                }
                else if (clickedColumnName == "Delete")
                {
                    //MessageBox.Show($"Delete clicked\nCategoryID: {categoryId}", "Action");
                    
                    // calls the del window
                    if (deleteItemDialogBox == null || deleteItemDialogBox.IsDisposed)
                    {
                        deleteItemDialogBox = new DeleteItemDialogBox(categoryId, CategoryRecordsTable);
                        deleteItemDialogBox.Show();
                    }
                    else
                    {
                        deleteItemDialogBox.Focus(); // Bring to front if it's already open
                    }

                }
                else
                {
                    MessageBox.Show("An error occurred during the action.", "Action Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
