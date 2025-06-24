using System.Collections.Generic;
using System.Windows.Forms;

// imports the backend file InventoryCrud.cs
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Reload
{
    public class ReloadInventory
    {
        // method to load unarchived inventory data into the DataGridView
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
                    item.itemCategoryName,
                    item.itemQtyType,
                    item.itemQuantity.ToString("N2"),
                    item.itemBuyingPrice.ToString("N2"),
                    item.itemSellingPrice.ToString("N2")
                );
            }
        }   // end of LoadInventoryData method

        // method to load archived inventory data into the DataGridView
        // not yet used
        public static void LoadArchivedInventoryData(DataGridView dataGridView1)
        {
            // Clear previous rows
            dataGridView1.Rows.Clear();

            InventoryRead read = new InventoryRead();
            List<InventoryItem> items = read.GetAllArchivedInventoryItems();

            foreach (var item in items)
            {
                dataGridView1.Rows.Add(
                    item.itemId,
                    item.itemName,
                    item.itemCategoryName,
                    item.itemQtyType,
                    item.itemQuantity.ToString("N2"),
                    item.itemBuyingPrice.ToString("N2"),
                    item.itemSellingPrice.ToString("N2")
                );
            }
        }   // end of LoadArchivedInventoryData method

    }

}