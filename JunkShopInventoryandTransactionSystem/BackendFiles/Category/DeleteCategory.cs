
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// imports crud
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Delete
{
    public class DeleteCategory
    {
        public static bool HandleDeleteCategory(
            int categoryId,
            DataGridView targetDataGridView
            )
        {
            // --- If validation passes, proceed with adding the item ---
            CategoryDelete delete = new CategoryDelete();
            delete.DeleteCategory(categoryId);

            //MessageBox.Show("Category deleted successfully!", "Category Deleting Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reload cat dashboard here
            if (targetDataGridView != null)
            {
                Reload.ReloadCategory.LoadCategoryData(targetDataGridView);
            }

            return true; // Indicate that the operation was successful

        }
    }
}
