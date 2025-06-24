
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud; 

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Edit
{
    public class EditInventory
    {
        public static bool HandleEditItem(
            int itemId,
            string itemNameContent,
            int itemCategoryId,
            string itemQtyTypeSelectedItem,
            string itemQuantity,
            string itemBuyingPrice,
            string itemSellingPrice,
            DataGridView targetDataGridView) // Pass the DataGridView to refresh
        {
            // --- Retrieve and Trim the Values to remove the spaces ---
            string itemName = itemNameContent.Trim();
            string itemQtyType = itemQtyTypeSelectedItem.Trim();

            string STRitemQuantity = itemQuantity.Trim();
            string STRitemBuyingPrice = itemBuyingPrice.Trim();
            string STRitemSellingPrice = itemSellingPrice.Trim();

            // Declare converted decimal variables
            decimal parsedItemQuantity;
            decimal parsedItemBuyingPrice;
            decimal parsedItemSellingPrice;

            // --- Validation ---
            bool isValidInput = true;
            string errorMessage = "";

            // String validations
            if (string.IsNullOrWhiteSpace(itemName))
            {
                errorMessage += "Item Name cannot be empty.\n";
                isValidInput = false;
            }

            // Check for duplicate item name in the database
            InventoryRead reader = new InventoryRead();
            var allItems = reader.GetAllInventoryItems();

            // Look for duplicate names (case-insensitive), excluding the item with the same ID
            bool isDuplicate = allItems.Any(i =>
                string.Equals(i.itemName, itemName, StringComparison.OrdinalIgnoreCase)
                && i.itemId != itemId // <-- exclude the item being edited
            );

            if (isDuplicate)
            {
                errorMessage += "An item with the same name already exists.\n";
                isValidInput = false;
            }

            // validation for cat id
            //MessageBox.Show($"Category ID from ComboBox: _{itemCategoryId}_", "Debug - Category ID", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bool isValidCategoryId = true;
            string categoryErrorMessage = "";

            if (itemCategoryId <= 0)
            {
                categoryErrorMessage += "Invalid Category: No category selected.\n";
                isValidCategoryId = false;
            }
            else
            {
                //Checks if it exists in the DB
                CategoryRead categoryReader = new CategoryRead();
                var categoryList = categoryReader.GetAllCategories();

                bool exists = categoryList.Any(cat => cat.categoryId == itemCategoryId);

                if (!exists)
                {
                    categoryErrorMessage += $"Category ID {itemCategoryId} does not exist in the database.\n";
                    isValidCategoryId = false;
                }
            }

            // Show error if invalid
            if (!isValidCategoryId)
            {
                MessageBox.Show(categoryErrorMessage, "Category Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(itemQtyType))
            {
                errorMessage += "Quantity Type cannot be empty.\n";
                isValidInput = false;
            }

            // Decimal validations using TryParse
            bool parsedQty = decimal.TryParse(STRitemQuantity, out parsedItemQuantity);
            if (!parsedQty || parsedItemQuantity <= 0)
            {
                errorMessage += !parsedQty
                    ? "Invalid quantity entered. Please enter a number.\n"
                    : "Quantity must be greater than zero.\n";
                isValidInput = false;
            }

            bool parsedBuying = decimal.TryParse(STRitemBuyingPrice, out parsedItemBuyingPrice);
            if (!parsedBuying || parsedItemBuyingPrice < 0)
            {
                errorMessage += !parsedBuying
                    ? "Invalid buying price entered. Please enter a number.\n"
                    : "Buying price cannot be negative.\n";
                isValidInput = false;
            }

            bool parsedSelling = decimal.TryParse(STRitemSellingPrice, out parsedItemSellingPrice);
            if (!parsedSelling || parsedItemSellingPrice < 0)
            {
                errorMessage += !parsedSelling
                    ? "Invalid selling price entered. Please enter a number.\n"
                    : "Selling price cannot be negative.\n";
                isValidInput = false;
            }

            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // --- If validation passes, proceed with editing the item ---
            InventoryItem itemToEdit = new InventoryItem(
                itemId, // Use the passed itemId
                itemName,
                itemCategoryId,
                itemQtyType,
                parsedItemQuantity,
                parsedItemBuyingPrice,
                parsedItemSellingPrice
            );

            InventoryEdit edit = new InventoryEdit();
            edit.EditItemInInventory(itemToEdit);

            //MessageBox.Show("Item edited successfully!", "Item Editing Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // --- Reload DataGridView ---
            if (targetDataGridView != null)
            {
                //namespace.class.method since theyre both on the same folder
                Reload.ReloadInventory.LoadInventoryData(targetDataGridView);
                //<skip namespace>.class.method if not on the same folder
            }

            return true; // Indicate that the operation was successful
        }

    } // end of method edit inventory
}
