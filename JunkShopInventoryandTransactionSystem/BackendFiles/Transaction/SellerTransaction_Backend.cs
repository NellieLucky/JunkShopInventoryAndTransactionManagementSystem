
using JunkShopInventoryandTransactionSystem.BackendFiles.Customer.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Employee.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
// access the constructor model for transaction cart
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.ConstructorModel;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.SellerLogic
{
    public class SellerTransaction_Backend
    {
        // adds an item to the cart for seller transaction
        public static bool HandleSellerTransaction(
            int passedItemId,
            string passeditemQty,
            DataGridView targetDataGridView,
            List<CartItem> tempCart
            ) 
        {
            //Get itemId
            //Get Quantity

            //validation of itemId and itemQty
            int itemId = passedItemId;

            string StrItemQty = passeditemQty.Trim();
            int parsedItemQty;

            // --- Validation ---
            bool isValidInput = true;
            string errorMessage = "";

            if (itemId <= 0)
            {
                errorMessage += "Please select an Item to add.\n";
                isValidInput = false;
            }

            // Integer validations using single TryParse
            bool parsedQty = int.TryParse(StrItemQty, out parsedItemQty);
            if (!parsedQty || parsedItemQty <= 0)
            {
                errorMessage += !parsedQty
                    ? "Invalid quantity entered. Please enter a whole number.\n"
                    : "Quantity must be greater than zero.\n";
                isValidInput = false;
            }
            else if (parsedItemQty > 9999) // Prevents more than 4 digits
            {
                errorMessage += "Quantity cannot exceed 6 digits (max: 9999).\n";
                isValidInput = false;
            }

            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Backend read if itemId exists and quantity check
            //<decrement or increment> //depends if buyer or seller
            // buyer backend for now

            // --- Backend read if itemId exists and quantity check ---

            // possible error here if multiple employees are using the system at the same time
            // but yea idk if we need to worry about that for now

            InventoryRead invReader = new InventoryRead();
            InventoryItem? checkItem = invReader.GetOneInventoryItem(itemId);

            if (checkItem == null)
            {
                MessageBox.Show("Selected item no longer exists in inventory.", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //COMMENTED THIS TO REMOVE QUANTITY VALIDATION WHEN SELLING 

            /*
            //so compare parsedQty with backend quantity of the selected itemId
            // validation must not be greater than itemId's quantity
            if (parsedItemQty > checkItem.itemQuantity)
            {
                MessageBox.Show($"Insufficient stock. Only {checkItem.itemQuantity} item(s) available.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            */

            //removed update quality here and moved it to FinalizeTransaction method

            // adds it to cart
            var existingCartItem = tempCart.FirstOrDefault(i => i.ItemId == itemId);
            if (existingCartItem != null)
            {
                // If exists, increase the quantity
                existingCartItem.Quantity += parsedItemQty;
            }
            else
            {
                // Else, add new item
                tempCart.Add(new CartItem
                {
                    ItemId = itemId,
                    Quantity = parsedItemQty
                });
            }

            // updates changes to the DataGridView of transaction
            InventoryRead reader = new InventoryRead();
            InventoryItem? item = reader.GetItemForSeller(itemId); // Fetch only buying price

            if (item != null)
            {
                int exchangeQty = parsedItemQty;
                decimal exchangeAmount = exchangeQty * item.itemBuyingPrice;

                targetDataGridView.Rows.Add(
                    item.itemId,
                    item.itemName,
                    item.itemQtyType,
                    item.itemBuyingPrice,   // Seller sees Buying Price
                    exchangeQty,
                    exchangeAmount
                );
            }
            else
            {
                MessageBox.Show("Item not found for Seller Transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true; // Return true if buyer transaction was successful
        }

        //finalizes the transaction for seller
        public static bool FinalizeTransaction(
            List<CartItem> tempCart,
            string sellerName,
            string sellerContact,    // what do we do with this?
            DataGridView targetDataGridView
            )
        {
            // --- Validation ---
            bool isValidInput = true;
            string errorMessage = "";

            // Check if cart is empty
            if (tempCart == null || tempCart.Count == 0)
            {
                MessageBox.Show("Cart is empty. Please add items before finalizing the transaction.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // --- Validation: Buyer Name is required ---
            if (string.IsNullOrWhiteSpace(sellerName))
            {
                errorMessage += "Buyer name is required.\n";
                isValidInput = false;
            }

            // make the customer NAME be lowered case and each first initial be capitalized

            /* shorter ver but only for the first letter <DOESNT WORK IF FOR EXAMPLE = PRINCE REMO>
            sellerName = sellerName.Trim();
            sellerName = sellerName.ToLower();
            // Step 3: Capitalize first letter
            sellerName = char.ToUpper(sellerName[0]) + sellerName.Substring(1); 
            */

            // longer ver but works for all names
            // <LIKE IF INPUT IS = PRINCE REMO> then it will be = Prince Remo
            sellerName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sellerName.Trim().ToLower());

            /*
            // --- Validation: Buyer Contact (optional, uncomment if needed) ---
            if (string.IsNullOrWhiteSpace(sellerContact))
            {
                errorMessage += "Buyer contact is required.\n";
                isValidInput = false;
            }
            */

            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // end of validation for widgets

            // If all updates were successful, we can proceed to finalize the transaction and save it to the database

            // Get customer ID by name
            CustomerRead reader = new CustomerRead();
            int? customerId = reader.GetCustomerIdByName(sellerName);

            if (customerId == null)
            {
                CustomerInsert addCustomer = new CustomerInsert();
                bool insertSuccess = addCustomer.InsertCustomer(sellerName, sellerContact, "Seller");

                if (insertSuccess)
                {
                    MessageBox.Show("✅ New customer added as Seller.", "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recheck ID after insert
                    customerId = reader.GetCustomerIdByName(sellerName);

                    if (customerId == null)
                    {
                        MessageBox.Show("❌ Failed to retrieve the new customer ID after insert.", "Customer ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // stop further processing
                    }
                }
                else
                {
                    MessageBox.Show("❌ Failed to insert new customer.", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            int nonNullCustomerId = customerId.Value;

            // get employee Id next
            int empId = ForUser.UserSession.EmployeeId;

            if (empId <= 0)
            {
                MessageBox.Show("❌ Employee not found.", "Lookup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // calculate total items, total quantity, and total amount
            int totalItems = tempCart.Count;
            int totalQuantity = tempCart.Sum(item => item.Quantity);

            decimal totalAmount = 0;
            // Loop through all rows and sum the Exchange Amount column (assumed to be at index 5)
            foreach (DataGridViewRow row in targetDataGridView.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells[5].Value);
                }
            }

            // Updates the quantity for each item in the cart
            InventoryUpdate updater = new InventoryUpdate();
            foreach (var cartItem in tempCart)
            {
                bool success = updater.UpdateItemQuantityForSeller(cartItem.ItemId, cartItem.Quantity);
                if (!success)
                {
                    MessageBox.Show($"Failed to update quantity for Item ID {cartItem.ItemId}", "Finalize Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // If any update fails, we stop the transaction finalization
                }
            }

            TransactionCreate writer = new TransactionCreate();
            bool isSuccess = writer.AddNewTransaction(
                nonNullCustomerId,
                empId,     //skips transacDate since it defaults to GETDATE()
                totalItems,
                totalQuantity,
                totalAmount,
                "Seller"  // pass this for transacType "Buyer" or "Seller" as a string
            );

            if (isSuccess)
            {
                MessageBox.Show("Transaction finalized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true; // Return true if transaction was successful
            }
            else
            {
                MessageBox.Show("❌ Failed to finalize transaction. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false if transaction failed
            }
        }   // end of FinalizeTransaction method

    }
}
