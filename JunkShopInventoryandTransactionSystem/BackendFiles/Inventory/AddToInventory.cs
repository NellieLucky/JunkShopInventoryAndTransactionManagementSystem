
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
            string strItemQuantity,
            string strItemBuyingPrice,
            string strItemSellingPrice,
            DataGridView targetDataGridView) // Pass the DataGridView to refresh
        {
            // --- Retrieve String Values ---
            // (These are now parameters to the method)
            string itemName = itemNameContent;
            string itemCategory = itemCategorySelectedItem;
            string itemQtyType = itemQtyTypeSelectedItem;

            string STRitemQuantity = strItemQuantity;
            string STRitemBuyingPrice = strItemBuyingPrice;
            string STRitemSellingPrice = strItemSellingPrice;

            // --- Parse to correct types ---
            int itemQuantity;
            int itemBuyingPrice;
            int itemSellingPrice;

            // --- Validation ---
            bool isValidInput = true;
            string errorMessage = "";

            //validation for strings
            if (string.IsNullOrWhiteSpace(itemName))
            {
                errorMessage += "Item Name cannot be empty.\n";
                isValidInput = false;
            }
            if (string.IsNullOrWhiteSpace(itemCategory) || itemCategory == "None")
            {
                errorMessage += "Item Category cannot be empty or 'None'.\n";
                isValidInput = false;
            }
            if (string.IsNullOrWhiteSpace(itemQtyType))
            {
                errorMessage += "Quantity Type cannot be empty.\n";
                isValidInput = false;
            }
            //end of validation for strings

            //validation for integers
            if (!int.TryParse(STRitemQuantity, out itemQuantity) || itemQuantity <= 0)
            {
                if (!int.TryParse(STRitemQuantity, out itemQuantity))
                {
                    errorMessage += "Invalid quantity entered. Please enter a whole number.\n";
                }
                else
                {
                    errorMessage += "Quantity must be greater than zero.\n";
                }
                isValidInput = false;
            }

            if (!int.TryParse(STRitemBuyingPrice, out itemBuyingPrice) || itemBuyingPrice < 0)
            {
                if (!int.TryParse(STRitemBuyingPrice, out itemBuyingPrice))
                {
                    errorMessage += "Invalid buying price entered. Please enter a whole number.\n";
                }
                else
                {
                    errorMessage += "Buying price cannot be negative.\n";
                }
                isValidInput = false;
            }

            if (!int.TryParse(STRitemSellingPrice, out itemSellingPrice) || itemSellingPrice < 0)
            {
                if (!int.TryParse(STRitemSellingPrice, out itemSellingPrice))
                {
                    errorMessage += "Invalid selling price entered. Please enter a whole number.\n";
                }
                else
                {
                    errorMessage += "Selling price cannot be negative.\n";
                }
                isValidInput = false;
            }
            //end of validation for integers

            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // returns immediately if any of the validation fails
            }

            // --- If validation passes, proceed with adding the item ---
            InventoryItem newItem = new InventoryItem(
                itemName,
                itemCategory,
                itemQtyType,
                itemQuantity,
                itemBuyingPrice,
                itemSellingPrice
            );

            InventoryAdd add = new InventoryAdd();
            add.AddItemToInventory(newItem);

            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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