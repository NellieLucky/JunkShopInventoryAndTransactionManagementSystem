
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//import backend file InventoryItem.cs
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Add
{
    public class AddToInventory
    {
        // This method will encapsulate the logic for adding an item, including validation
        // It takes the raw input values (strings) and the DataGridView to refresh
        public static bool HandleAddItem(
            string itemNameContent,
            string itemCategorySelectedItem,
            string itemQtyTypeSelectedItem,
            string itemQuantity,
            string itemBuyingPrice,
            string itemSellingPrice,
            DataGridView targetDataGridView) // Pass the DataGridView to refresh
        {
            //updated the validation for cleaner version
            // --- Retrieve and Trim the Values to remove the spaces ---
            string itemName = itemNameContent.Trim();
            string itemCategory = itemCategorySelectedItem.Trim();
            string itemQtyType = itemQtyTypeSelectedItem.Trim();

            string STRitemQuantity = itemQuantity.Trim();
            string STRitemBuyingPrice = itemBuyingPrice.Trim();
            string STRitemSellingPrice = itemSellingPrice.Trim();

            // where to store them after converting them
            // Declare converted integer variables with different names
            int parsedItemQuantity;
            int parsedItemBuyingPrice;
            int parsedItemSellingPrice;

            // --- Validation ---
            bool isValidInput = true;
            string errorMessage = "";

            // String validations
            if (string.IsNullOrWhiteSpace(itemName))
            {
                errorMessage += "Item Name cannot be empty.\n";
                isValidInput = false;
            }
            if (string.IsNullOrWhiteSpace(itemCategory) || itemCategory.Equals("None", StringComparison.OrdinalIgnoreCase))
            {
                errorMessage += "Item Category cannot be empty or 'None'.\n";
                isValidInput = false;
            }
            if (string.IsNullOrWhiteSpace(itemQtyType))
            {
                errorMessage += "Quantity Type cannot be empty.\n";
                isValidInput = false;
            }

            // Integer validations using single TryParse
            bool parsedQty = int.TryParse(STRitemQuantity, out parsedItemQuantity);
            if (!parsedQty || parsedItemQuantity <= 0)
            {
                errorMessage += !parsedQty
                    ? "Invalid quantity entered. Please enter a whole number.\n"
                    : "Quantity must be greater than zero.\n";
                isValidInput = false;
            }

            bool parsedBuying = int.TryParse(STRitemBuyingPrice, out parsedItemBuyingPrice);
            if (!parsedBuying || parsedItemBuyingPrice < 0)
            {
                errorMessage += !parsedBuying
                    ? "Invalid buying price entered. Please enter a whole number.\n"
                    : "Buying price cannot be negative.\n";
                isValidInput = false;
            }

            bool parsedSelling = int.TryParse(STRitemSellingPrice, out parsedItemSellingPrice);
            if (!parsedSelling || parsedItemSellingPrice < 0)
            {
                errorMessage += !parsedSelling
                    ? "Invalid selling price entered. Please enter a whole number.\n"
                    : "Selling price cannot be negative.\n";
                isValidInput = false;
            }

            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // --- If validation passes, proceed with adding the item ---
            InventoryItem newItem = new InventoryItem(
                itemName,
                itemCategory,
                itemQtyType,
                parsedItemQuantity,
                parsedItemBuyingPrice,
                parsedItemSellingPrice
            );

            InventoryAdd add = new InventoryAdd();
            add.AddItemToInventory(newItem);

            //MessageBox.Show("Item added successfully!", "Item Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // --- Reload DataGridView ---
            if (targetDataGridView != null)
            {
                //namespace.class.method since theyre both on the same folder
                Reload.ReloadInventory.LoadInventoryData(targetDataGridView);
                //<skip namespace>.class.method if not on the same folder
            }

            return true; // Indicate that the operation was successful
        }
    }
}