using System.Collections.Generic;
using System.Windows.Forms;

// imports the backend file InventoryCrud.cs
using JunkShopInventoryandTransactionSystem.BackendFiles.InventoryCrudToDatabase;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.ReloadInventory
{
    public class ReloadInventory
    {
        // Make the method public and static if you don't need to instantiate ReloadInventory
        // or just public if you plan to create an instance of ReloadInventory
        public static void LoadInventoryData(DataGridView dataGridView1)
        {
            // Clear existing rows before loading new data to prevent duplicates
            dataGridView1.Rows.Clear();

            InventoryRead read = new InventoryRead();
            List<InventoryItem> items = read.GetAllInventoryItems();

            foreach (var item in items)
            {
                dataGridView1.Rows.Add(
                    item.itemId,
                    item.itemName,
                    item.itemCategory,
                    item.itemQtyType,
                    item.itemQuantity,
                    item.itemBuyingPrice,
                    item.itemSellingPrice
                );
            }
        }
    }
}