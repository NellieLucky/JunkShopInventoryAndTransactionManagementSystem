
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Archiving
{
    public class ArchivingItemInInventory
    {
        public static bool HandleArchivingItem(
            int itemId,
            DataGridView targetDataGridView)
        {
            // --- If validation passes, proceed with soft deleting the item ---
            InventorySoftDelete softDelete = new InventorySoftDelete();
            softDelete.SoftDeleteItemFromInventory(itemId);  // Replaced hard delete

            // --- Reload DataGridView to reflect updated state ---
            if (targetDataGridView != null)
            {
                Reload.ReloadInventory.LoadInventoryData(targetDataGridView);
            }

            return true;
        }
    }
}
