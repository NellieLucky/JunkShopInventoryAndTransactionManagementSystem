
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Archiving;
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Delete;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Delete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkShopInventoryandTransactionSystem.View.DeletionDialogs
{
    public partial class DeleteCategoryDialogBox : Form
    {
        private DataGridView _targetDataGridView;
        private int? categoryId;

        public DeleteCategoryDialogBox(int categoryId, DataGridView dgv)
        {
            InitializeComponent();

            this.categoryId = categoryId;
            _targetDataGridView = dgv;

            if (categoryId <= 0)
            {
                MessageBox.Show("Invalid category ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //gets the details from the database itself and not from the DataGridView
            CategoryItem? cat = new CategoryRead().GetOneCategory(categoryId);

            if (cat == null)
            {
                MessageBox.Show("Category not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            //puts the values in the widgets
            CatIDTextHolder.Text = cat.categoryId.ToString();
            CatNameTextHolder.Text = cat.categoryName;
        }

        private void ContinueDelButton_Click(object sender, EventArgs e)
        {
            if (!categoryId.HasValue)
            {
                MessageBox.Show("Category ID is missing. Cannot proceed with deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //calls the unarchiving backend
            bool deletingSuccess = DeleteCategory.HandleDeleteCategory(categoryId.Value, _targetDataGridView);

            // add archiving of items that used the category

            if (deletingSuccess)
            {
                MessageBox.Show("Category successfully deleted.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Closes the form
                Close();
            }
            else
            {
                MessageBox.Show("Failed to delete the Category. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
