
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
            // ARCHIVING THE ITEM
            InventorySoftDelete softDelete = new InventorySoftDelete();
            softDelete.SoftDeleteItemFromInventory(itemId);

            // --- Reload DataGridView to reflect updated state ---
            if (targetDataGridView != null)
            {
                Reload.ReloadInventory.LoadInventoryData(targetDataGridView);
            }

            return true;
        }
    }
}
