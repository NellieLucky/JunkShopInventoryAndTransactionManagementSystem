
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Archiving
{
    public class ArchivingCategory
    {
        public static bool HandleArchivingCategory(
            int categoryId,
            DataGridView targetDataGridView)
        {
            // Soft delete all items first
            InventorySoftDelete softDel_byCatId = new InventorySoftDelete();
            softDel_byCatId.SoftDeleteItemsByCategory(categoryId);

            // Then soft delete the category
            CategorySoftDelete softDelete = new CategorySoftDelete();
            softDelete.SoftDeleteCategory(categoryId);

            // --- Reload DataGridView with active (unarchived) categories ---
            if (targetDataGridView != null)
            {
                Reload.ReloadCategory.LoadCategoryData(targetDataGridView);
            }

            return true;
        }
    }
}
