
// imports for functions

// imports for category actions
// specific backend files consisting of actions
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Archiving;
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Unarchive;
// for refreshing of values for the table grid view
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Reload;
// for frontend
using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
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
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;
using static System.Windows.Forms.DataFormats;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.ConstructorModel;

namespace JunkShopInventoryandTransactionSystem.View.Inventory_Pages
{
    public partial class CategoryPage : UserControl
    {
        private AddEditCategoryDialogBox addEditCategoryDialogBox = null!; // Initialize with null-forgiving operator  
        private DeleteCategoryDialogBox deleteCategoryDialogBox = null!;

        public CategoryPage()
        {
            InitializeComponent();

            archiveState.SelectedIndexChanged += ArchiveState_SelectedIndexChanged;
            archiveState.SelectedIndex = 0; // triggers default load

            // Add search event handlers
            SearchButton.Click += SearchButton_Click;
            SearchTextBox.ContentChanged += SearchTextBox_TextChanged;

            // Set header text for Edit and Delete columns to empty  
            CategoryRecordsTable.Columns["Edit"].HeaderText = "";
            CategoryRecordsTable.Columns["Delete"].HeaderText = "";
            CategoryRecordsTable.Paint += DataGridView1_Paint;
            
            CategoryRecordsTable.CellFormatting += CategoryRecordsTable_CellFormatting;


            // Hide Add/Delete/Edit column if user is Employee
            var userInfo = ForUser.GetUserInfo(UserSession.UserId);
            if (userInfo.Role == "Employee")
            {
                CategoryRecordsTable.Columns["Edit"].Visible = false;
                CategoryRecordsTable.Columns["Delete"].Visible = false;

                AddCategoryButton.Visible = false;
            }
        }

        private void ArchiveState_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (archiveState.SelectedIndex == 0)
            {
                // if archived state is 0
                // we are in non-archived options
                // were gonna see non-archived categories
                ReloadCategory.LoadCategoryData(CategoryRecordsTable);
            }
            else
            {
                // if archived state is 1
                // we are in archived options
                // were gonna see archived categories
                ReloadCategory.LoadArchivedCategoryData(CategoryRecordsTable);
            }
        }

        //Para to sa pag-merge ng Edit at Delete header cells kasi walang built-in support sa DataGridView para here  
        private void DataGridView1_Paint(object? sender, PaintEventArgs e)
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string clickedColumnName = CategoryRecordsTable.Columns[e.ColumnIndex].Name;

                DataGridViewRow selectedRow = CategoryRecordsTable.Rows[e.RowIndex];
                int categoryId = Convert.ToInt32(selectedRow.Cells["CategoryID"].Value);

                if (clickedColumnName == "Edit")
                {
                    //MessageBox.Show($"Edit clicked\nCategoryID: {categoryId}", "Action");

                    //calls the add edit window
                    // check first if the archiveState is 0 or 1, if 0 then edit, if 1 then unarchive
                    if (archiveState.SelectedIndex == 0)
                    {
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
                    else
                    {
                        // Confirmation message box with item ID
                        DialogResult confirmResult = MessageBox.Show(
                            $"Are you sure you want to unarchive this category?\n\nCategory ID: {categoryId}",
                            "Unarchiving of Category",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (confirmResult == DialogResult.Yes)
                        {
                            //calls the unarchiving backend
                            bool unarchivingSuccess = UnarchivingCategory.HandleUnarchivingCategory(categoryId, CategoryRecordsTable);

                            if (unarchivingSuccess)
                            {
                                MessageBox.Show("Categoary successfully unarchived.", "Successful Unarchiving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to unarchive category. Please try again.", "Unarchive Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }

                }
                else if (clickedColumnName == "Delete")
                {
                    //MessageBox.Show($"Delete clicked\nCategoryID: {categoryId}", "Action");

                    // check first if the archiveState is 0 or 1, if 0 then delete, if 1 then perma delete
                    if (archiveState.SelectedIndex == 0)
                    {
                        // Confirmation message box with item ID
                        DialogResult confirmResult = MessageBox.Show(
                            $"Are you sure you want to archive this category?\n\nCategory ID: {categoryId}",
                            "Confirm Archiving",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (confirmResult == DialogResult.Yes)
                        {
                            //calls the unarchiving backend
                            // fix misreferenced perma delete instead of soft delete
                            bool deletingSuccess = ArchivingCategory.HandleArchivingCategory(categoryId, CategoryRecordsTable);

                            if (deletingSuccess)
                            {
                                MessageBox.Show("Successfully archived the category.", "Successful Archiving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to archive Category. Please try again.", "Archiving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        // calls the del window
                        if (deleteCategoryDialogBox == null || deleteCategoryDialogBox.IsDisposed)
                        {
                            deleteCategoryDialogBox = new DeleteCategoryDialogBox(categoryId, CategoryRecordsTable);
                            deleteCategoryDialogBox.Show();
                        }
                        else
                        {
                            deleteCategoryDialogBox.Focus(); // Bring to front if it's already open
                        }

                    }

                }
                else
                {
                    MessageBox.Show("An error occurred during the action.", "Action Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchButton_Click(object? sender, EventArgs e)
        {
            FilterCategories(SearchTextBox.Content);
        }

        private void SearchTextBox_TextChanged(object? sender, EventArgs e)
        {
            FilterCategories(SearchTextBox.Content);
        }

        private void FilterCategories(string searchText)
        {
            if (CategoryRecordsTable.DataSource is DataTable dataTable)
            {
                // Using DataTable filtering
                try
                {
                    dataTable.DefaultView.RowFilter = string.IsNullOrWhiteSpace(searchText) ? "" :
                        $"Convert(CategoryID, 'System.String') LIKE '%{searchText}%' OR " +  // Added ID search
                        $"CategoryName LIKE '%{searchText}%' OR " +
                        $"CategoryDescription LIKE '%{searchText}%'";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering data: {ex.Message}", "Search Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Fallback to row visibility approach
                foreach (DataGridViewRow row in CategoryRecordsTable.Rows)
                {
                    bool visible = string.IsNullOrWhiteSpace(searchText);
                    if (!visible)
                    {
                        searchText = searchText.ToLower();
                        visible = (row.Cells["CategoryID"].Value?.ToString()?.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true) ||  // Added ID search
                                  (row.Cells["CategoryName"].Value?.ToString()?.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true) ||
                                  (row.Cells["CategoryDescription"].Value?.ToString()?.Contains(searchText, StringComparison.OrdinalIgnoreCase) == true);
                    }
                    row.Visible = visible;
                }
            }
        }

        private void CategoryRecordsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is CategoryID and format it as a string
            if (CategoryRecordsTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (archiveState.SelectedIndex == 0)
                {
                    // Non-archived: normal delete icon
                    e.Value = Properties.Resources.green_edit; // Replace with your resource name
                }
                else
                {
                    // Archived: permanent delete icon
                    e.Value = Properties.Resources.restore; // Replace with your resource name
                }
                e.FormattingApplied = true;
            }
        }
    }
}
