
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Archiving;

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
                MessageBox.Show("Invalid item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //gets the details from the database itself and not from the DataGridView
            CategoryItem? cat = new CategoryRead().GetOneCategory(categoryId);

            if (cat == null)
            {
                MessageBox.Show("Item not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Item ID is missing. Cannot proceed with deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool catArchivingSuccess = ArchivingCategory.HandleArchivingCategory(categoryId.Value, _targetDataGridView);

            // add archiving of items that used the category

            if (catArchivingSuccess)
            {
                // Closes the form
                Close();
            }
            else
            {
                // Handle validation errors inside HandleDeleteCategory
                MessageBox.Show("Failed to archive the category.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
