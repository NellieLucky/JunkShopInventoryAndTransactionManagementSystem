
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Unarchive
{
    public class UnarchivingCategory
    {
        public static bool HandleUnarchivingCategory(
            int categoryId,
            DataGridView targetDataGridView)
        {
            // restore the items first
            InventoryRestore unarchivingItemByCatId = new InventoryRestore();
            unarchivingItemByCatId.RestoreItemsByCategory(categoryId);

            // --- Restore the category from archive ---
            CategoryRestore restore = new CategoryRestore();
            restore.RestoreCategory(categoryId);

            // --- Reload the active category list ---
            if (targetDataGridView != null)
            {
                Reload.ReloadCategory.LoadArchivedCategoryData(targetDataGridView);
            }

            return true;
        }
    }
}
