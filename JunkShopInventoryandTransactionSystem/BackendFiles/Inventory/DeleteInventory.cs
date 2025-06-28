using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Delete
{
    public class DeleteItemInInventory
    {
        public static bool HandleDeleteItem(
            int itemId,
            DataGridView targetDataGridView)
        {
            // passes the id to find it in the database and delete it
            InventoryDelete delete = new InventoryDelete();
            delete.DeleteItemFromInventory(itemId);

            // --- Reload DataGridView ---
            if (targetDataGridView != null)
            {

                //reload it before returning
                Reload.ReloadInventory.LoadArchivedInventoryData(targetDataGridView);
            }

            return true;
        }
    }

}
