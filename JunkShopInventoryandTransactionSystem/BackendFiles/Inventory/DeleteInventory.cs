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
        public static bool HandleDeleteItem(int itemId, DataGridView targetDataGridView)
        {
            if (itemId <= 0) return false;

            //gets the details from the database itself and not from the DataGridView
            InventoryItem? item = new InventoryRead().GetOneInventoryItem(itemId);

            if (item == null)
            {
                MessageBox.Show("Item not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Build the message string with item details
            string itemDetails = $"Item ID: {item.itemId}\n" +
                                 $"Item Name: {item.itemName}\n" +
                                 $"Category: {item.itemCategory}\n" +
                                 $"Quantity Type: {item.itemQtyType}\n" +
                                 $"Quantity: {item.itemQuantity}\n" +
                                 $"Buying Price: {item.itemBuyingPrice}\n" +
                                 $"Selling Price: {item.itemSellingPrice}";

            // Show confirmation MessageBox with item details

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the following item?\n\n{itemDetails}",
                "Confirm Item Deletion?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Handle result
            if (result == DialogResult.Yes)
            {
                // --- If validation passes, proceed with editing the item ---
                // passes the id to find it in the database and delete it
                InventoryDelete delete = new InventoryDelete();
                delete.DeleteItemFromInventory(itemId);

                // --- Reload DataGridView ---
                if (targetDataGridView != null)
                {
                    //namespace.class.method since theyre both on the same folder
                    Reload.ReloadInventory.LoadInventoryData(targetDataGridView);
                    //<skip namespace>.class.method if not on the same folder
                }

                //reload it before returning
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
