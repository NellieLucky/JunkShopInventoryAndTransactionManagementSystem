
// used inventory crud too
// since i needed to unarchive the items that used the archived category that were gonna unarchive back here
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
            // restore the items first / UNARCHIVING IT BACK
            InventoryRestore unarchivingItemByCatId = new InventoryRestore();
            unarchivingItemByCatId.RestoreItemsByCategory(categoryId);

            // --- Restore the category from archive / UNARCHIVING IT BACK ---
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
