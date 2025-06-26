using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Unarchive
{
    public class UnarchivingItemInInventory
    {
        public static bool HandleUnarchivingItem(
            int itemId,
            DataGridView targetDataGridView)
        {
            // --- Restore item by setting isArchived = 0
            // UNARCHIVING THE ITEM BACK---
            InventoryRestore restore = new InventoryRestore();
            restore.RestoreItemToInventory(itemId);

            // --- reloading the archived datas ---
            if (targetDataGridView != null)
            {
                Reload.ReloadInventory.LoadArchivedInventoryData(targetDataGridView);
            }

            return true;
        }
    }
}
