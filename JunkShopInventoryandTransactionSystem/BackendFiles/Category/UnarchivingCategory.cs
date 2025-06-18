
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category
{
    public class UnarchivingCategory
    {
        public static bool HandleUnarchivingCategory(
            int categoryId,
            DataGridView targetDataGridView)
        {
            // --- Restore the category from archive ---
            CategoryRestore restore = new CategoryRestore();
            restore.RestoreCategory(categoryId);

            // --- Reload the active category list ---
            if (targetDataGridView != null)
            {
                Reload.ReloadCategory.LoadCategoryData(targetDataGridView);
            }

            return true;
        }
    }
}
