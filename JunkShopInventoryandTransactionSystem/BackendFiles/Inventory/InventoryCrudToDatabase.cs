﻿
// removed unused imports

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  RUN THIS QUERY IN YOUR MS SQL SERVER MANAGEMENT STUDIO (SSMS) TO CREATE THE TABLE

-- TABLE CREATION
CREATE TABLE Inventory (
    itemId INT IDENTITY(1,1) PRIMARY KEY,
    itemName VARCHAR(50) NOT NULL,
    itemCategoryId INT NOT NULL,  -- CHANGED from VARCHAR to INT
    itemQtyType VARCHAR(50) NOT NULL,
    itemQuantity INT NOT NULL,
    itemBuyingPrice INT NOT NULL,
    itemSellingPrice INT NOT NULL,
    isArchived BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (itemCategoryId) REFERENCES Category(categoryId)  -- FK reference
);

ALTER TABLE Inventory
ALTER COLUMN itemQuantity DECIMAL(18, 2);

ALTER TABLE Inventory
ALTER COLUMN itemBuyingPrice DECIMAL(18, 2);

ALTER TABLE Inventory
ALTER COLUMN itemSellingPrice DECIMAL(18, 2);

CREATE TABLE Inventory (
    itemId INT IDENTITY(1,1) PRIMARY KEY,
    itemName VARCHAR(50) NOT NULL,
    itemCategoryId INT NOT NULL,  -- FK to Category table
    itemQtyType VARCHAR(50) NOT NULL,
    itemQuantity DECIMAL(18, 2) NOT NULL,
    itemBuyingPrice DECIMAL(18, 2) NOT NULL,
    itemSellingPrice DECIMAL(18, 2) NOT NULL,
    isArchived BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (itemCategoryId) REFERENCES Category(categoryId)
);

SELECT * FROM Inventory

*/

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud
{
    // constructors depending on what will be used
    // Optimized and updated to support decimal quantities and prices
    public class InventoryItem
    {
        public int itemId { get; set; } // Database-generated ID for new items

        public string itemName { get; set; } = string.Empty;
        public int itemCategoryId { get; set; }
        public string itemCategoryName { get; set; } = string.Empty; // Populated via JOIN
        public string itemQtyType { get; set; } = string.Empty;

        public decimal itemQuantity { get; set; }           // CHANGED from int to decimal
        public decimal itemBuyingPrice { get; set; }        // CHANGED from int to decimal
        public decimal itemSellingPrice { get; set; }       // CHANGED from int to decimal

        public bool isArchived { get; set; } = false; // Soft delete flag

        // Parameterless constructor — required for DB mapping (e.g., SqlDataReader)
        public InventoryItem() { }

        // Constructor for Add (no itemId yet)
        public InventoryItem(string name, int category, string qtyType, decimal quantity, decimal buyingPrice, decimal sellingPrice, bool archived = false)
        {
            itemName = name;
            itemCategoryId = category;
            itemQtyType = qtyType;
            itemQuantity = quantity;
            itemBuyingPrice = buyingPrice;
            itemSellingPrice = sellingPrice;
            isArchived = archived;
        }

        // Constructor for Edit/View (includes itemId)
        public InventoryItem(int id, string name, int categoryId, string qtyType, decimal quantity, decimal buyingPrice, decimal sellingPrice, bool archived = false)
        {
            itemId = id;
            itemName = name;
            itemCategoryId = categoryId;
            itemQtyType = qtyType;
            itemQuantity = quantity;
            itemBuyingPrice = buyingPrice;
            itemSellingPrice = sellingPrice;
            isArchived = archived;
        }
    }
    // eND of InventoryItem CLASS

    // INPUT STRING HERE FOR LOCAL DB CONNECTION
    public abstract class BaseRepository
    {
        // Centralized connection string
        // remo string
        //protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //nicole's connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //Arnel's connection string
        protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //Abalos' connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        //Dara's connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sandara Fillartos\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf"";Integrated Security=True";

        //Ethan's connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    // InventoryRead Class
    // includes everything related to READING
    public class InventoryRead : BaseRepository
    {
        // read all unarchived items
        // get all inventory items method with isArchived filter = 0 (not archived)
        public List<InventoryItem> GetAllInventoryItems()
        {
            List<InventoryItem> items = new List<InventoryItem>(); // Initialize an empty list

            using ( SqlConnection conn = GetConnection() ) // Ensures connection is closed
            {
                // updated to read only non-archived items < isArchived = 0/FALSE >
                string query = @"
                    SELECT 
                        i.itemId,
                        i.itemName,
                        i.itemCategoryId,
                        c.categoryName AS itemCategoryName,
                        i.itemQtyType,
                        i.itemQuantity,
                        i.itemBuyingPrice,
                        i.itemSellingPrice,
                        i.isArchived
                    FROM Inventory i
                    INNER JOIN Category c ON i.itemCategoryId = c.categoryId
                    WHERE i.isArchived = 0 AND c.isArchived = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) // Ensures reader is disposed
                        {
                            while (reader.Read())
                            {
                                InventoryItem item = new InventoryItem
                                {
                                    itemId = Convert.ToInt32(reader["itemId"]),
                                    itemName = reader["itemName"].ToString() ?? string.Empty,
                                    itemCategoryId = Convert.ToInt32(reader["itemCategoryId"]),
                                    itemCategoryName = reader["itemCategoryName"].ToString() ?? string.Empty,
                                    itemQtyType = reader["itemQtyType"].ToString() ?? string.Empty,
                                    itemQuantity = Convert.ToDecimal(reader["itemQuantity"]),
                                    itemBuyingPrice = Convert.ToDecimal(reader["itemBuyingPrice"]),
                                    itemSellingPrice = Convert.ToDecimal(reader["itemSellingPrice"]),
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };

                                //adds the content per row to item
                                items.Add(item);
                            }
                        } // automatically closes the reader
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading Inventory table: " + ex.Message);
                        throw new Exception("Failed to retrieve inventory items from the database.", ex); 
                    }
                }
            }
            return items;
        }
        // end of read all unarchived items

        // read all archived items
        public List<InventoryItem> GetAllArchivedInventoryItems()
        {
            List<InventoryItem> items = new List<InventoryItem>();

            using ( SqlConnection conn = GetConnection() )
            {
                string query = @"
                    SELECT 
                        i.itemId,
                        i.itemName,
                        i.itemCategoryId,
                        c.categoryName AS itemCategoryName,
                        i.itemQtyType,
                        i.itemQuantity,
                        i.itemBuyingPrice,
                        i.itemSellingPrice,
                        i.isArchived
                    FROM Inventory i
                    INNER JOIN Category c ON i.itemCategoryId = c.categoryId
                    WHERE i.isArchived = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                InventoryItem item = new InventoryItem
                                {
                                    itemId = Convert.ToInt32(reader["itemId"]),
                                    itemName = reader["itemName"]?.ToString() ?? string.Empty,
                                    itemCategoryId = Convert.ToInt32(reader["itemCategoryId"]),
                                    itemCategoryName = reader["itemCategoryName"]?.ToString() ?? string.Empty,
                                    itemQtyType = reader["itemQtyType"]?.ToString() ?? string.Empty,
                                    itemQuantity = Convert.ToDecimal(reader["itemQuantity"]),
                                    itemBuyingPrice = Convert.ToDecimal(reader["itemBuyingPrice"]),
                                    itemSellingPrice = Convert.ToDecimal(reader["itemSellingPrice"]),
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };

                                items.Add(item);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading archived inventory items: " + ex.Message);
                        throw new Exception("Failed to retrieve archived inventory items.", ex);
                    }
                }
            }

            return items;
        }
        // end of read all archived items

        // just get one ITEM with category name
        public InventoryItem? GetOneInventoryItem(int itemId)
        {
            InventoryItem? item = null; // Will remain null if no match is found

            using ( SqlConnection conn = GetConnection() )
            {
                string query = @"
                    SELECT 
                        i.itemId,
                        i.itemName,
                        i.itemCategoryId,
                        c.categoryName AS itemCategoryName,
                        i.itemQtyType,
                        i.itemQuantity,
                        i.itemBuyingPrice,
                        i.itemSellingPrice,
                        i.isArchived
                    FROM Inventory i
                    INNER JOIN Category c ON i.itemCategoryId = c.categoryId
                    WHERE i.itemId = @itemId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId); // Add the parameter safely

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Read just one row
                            {
                                item = new InventoryItem
                                {
                                    itemId = Convert.ToInt32(reader["itemId"]),
                                    itemName = reader["itemName"]?.ToString() ?? string.Empty,
                                    itemCategoryId = Convert.ToInt32(reader["itemCategoryId"]),
                                    itemCategoryName = reader["itemCategoryName"]?.ToString() ?? string.Empty,
                                    itemQtyType = reader["itemQtyType"]?.ToString() ?? string.Empty,
                                    itemQuantity = Convert.ToDecimal(reader["itemQuantity"]),
                                    itemBuyingPrice = Convert.ToDecimal(reader["itemBuyingPrice"]),
                                    itemSellingPrice = Convert.ToDecimal(reader["itemSellingPrice"]),
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error reading Inventory item: " + ex.Message);
                        throw new Exception("Failed to retrieve the inventory item from the database.", ex);
                    }
                }
            }

            return item; // Could be null if not found
        }
        //end of fetchone()

        //read queries for transaction pages
        public InventoryItem? GetItemForBuyer(int itemId)
        {
            InventoryItem? item = null;

            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT 
                        itemId,
                        itemName,
                        itemQtyType,
                        itemQuantity,
                        itemSellingPrice,
                        isArchived
                    FROM Inventory
                    WHERE itemId = @itemId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                item = new InventoryItem
                                {
                                    itemId = Convert.ToInt32(reader["itemId"]),
                                    itemName = reader["itemName"]?.ToString() ?? string.Empty,
                                    itemQtyType = reader["itemQtyType"]?.ToString() ?? string.Empty,
                                    itemQuantity = Convert.ToDecimal(reader["itemQuantity"]),
                                    itemSellingPrice = Convert.ToDecimal(reader["itemSellingPrice"]),
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error reading Inventory item for Buyer: " + ex.Message);
                        throw new Exception("Failed to retrieve the buyer inventory item from the database.", ex);
                    }
                }
            }

            return item;
        }
        // end of get item for buyer

        // Get one inventory item for Seller transactions (removes categoryName)
        public InventoryItem? GetItemForSeller(int itemId)
        {
            InventoryItem? item = null;

            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT 
                        itemId,
                        itemName,
                        itemQtyType,
                        itemQuantity,
                        itemBuyingPrice,
                        isArchived
                    FROM Inventory
                    WHERE itemId = @itemId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                item = new InventoryItem
                                {
                                    itemId = Convert.ToInt32(reader["itemId"]),
                                    itemName = reader["itemName"]?.ToString() ?? string.Empty,
                                    itemQtyType = reader["itemQtyType"]?.ToString() ?? string.Empty,
                                    itemQuantity = Convert.ToDecimal(reader["itemQuantity"]),
                                    itemBuyingPrice = Convert.ToDecimal(reader["itemBuyingPrice"]),
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error reading Inventory item for Seller: " + ex.Message);
                        throw new Exception("Failed to retrieve the seller inventory item from the database.", ex);
                    }
                }
            }

            return item;
        }
        // end of get item for seller

    }
    // End of inventory Read

    // inventory add aaa
    // includes everything related to ADDING / INSERTION
    public class InventoryAdd : BaseRepository
    {
        public void AddItemToInventory(InventoryItem item)
        {
            string query = @"INSERT INTO Inventory 
                            (itemName, itemCategoryId, itemQtyType, itemQuantity, itemBuyingPrice, itemSellingPrice) 
                            VALUES 
                            (@itemName, @itemCategoryId, @itemQtyType, @itemQuantity, @itemBuyingPrice, @itemSellingPrice);";


            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to prevent SQL Injection and handle data types correctly
                    cmd.Parameters.AddWithValue("@itemName", item.itemName);
                    cmd.Parameters.AddWithValue("@itemCategoryId", item.itemCategoryId);
                    cmd.Parameters.AddWithValue("@itemQtyType", item.itemQtyType);
                    cmd.Parameters.AddWithValue("@itemQuantity", item.itemQuantity);
                    cmd.Parameters.AddWithValue("@itemBuyingPrice", item.itemBuyingPrice);
                    cmd.Parameters.AddWithValue("@itemSellingPrice", item.itemSellingPrice);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error during AddItemToInventory: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("An error occurred while adding the item to the database.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }
        // end of item add one
    }
    // end of InventoryAdd

    //inventory edit / update
    public class InventoryEdit : BaseRepository
    {
        // for item inventory editing
        public void EditItemInInventory(InventoryItem item)
        {
            string query = @"
                UPDATE Inventory SET 
                    itemName = @itemName, 
                    itemCategoryId = @itemCategoryId, 
                    itemQtyType = @itemQtyType, 
                    itemQuantity = @itemQuantity, 
                    itemBuyingPrice = @itemBuyingPrice, 
                    itemSellingPrice = @itemSellingPrice 
                WHERE itemId = @itemId;
            ";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", item.itemId);
                    cmd.Parameters.AddWithValue("@itemName", item.itemName);
                    cmd.Parameters.AddWithValue("@itemCategoryId", item.itemCategoryId);
                    cmd.Parameters.AddWithValue("@itemQtyType", item.itemQtyType);
                    cmd.Parameters.AddWithValue("@itemQuantity", item.itemQuantity);
                    cmd.Parameters.AddWithValue("@itemBuyingPrice", item.itemBuyingPrice);
                    cmd.Parameters.AddWithValue("@itemSellingPrice", item.itemSellingPrice);

                    // for debugging
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error during UpdateItemInInventory: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("An error occurred while updating the item in the database.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }   // end of the second using in the nested using stuff
            }   //end of the first using

        }   //end of method EditItemInInventory

    }
    // end of InventoryEdit

    // inventory update for Buyer/Seller Transaction
    // for item inventory updating of itemQuantity
    // - BuyerTransaction_Backend.cs to DECREMENT itemQuantity (customer buys from us)
    // - SellerTransaction_Backend.cs to INCREMENT itemQuantity (we buy from seller)
    public class InventoryUpdate : BaseRepository
    {
        // For Buyer transactions: subtracts stock (cannot go negative)
        public bool UpdateItemQuantityForBuyer(int itemId, decimal quantityToSubtract)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                UPDATE Inventory
                SET itemQuantity = itemQuantity - @qty
                WHERE itemId = @itemId AND (itemQuantity - @qty) >= 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qty", quantityToSubtract);
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    try
                    {
                        conn.Open();
                        int affectedRows = cmd.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error updating quantity for buyer: " + ex.Message);
                        throw new Exception("Buyer stock update failed.", ex);
                    }
                }
            }
        }   // end of buyer update

        // For Seller transactions: adds stock
        public bool UpdateItemQuantityForSeller(int itemId, decimal quantityToAdd)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                UPDATE Inventory
                SET itemQuantity = itemQuantity + @qty
                WHERE itemId = @itemId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@qty", quantityToAdd);
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    try
                    {
                        conn.Open();
                        int affectedRows = cmd.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error updating quantity for seller: " + ex.Message);
                        throw new Exception("Seller stock update failed.", ex);
                    }
                }
            }
        }   // end of seller update

    }   // end of inventory item update for transaction

    // inventory soft delete
    public class InventorySoftDelete : BaseRepository
    {
        public void SoftDeleteItemFromInventory(int itemId)
        {
            string query = "UPDATE Inventory SET isArchived = 1 WHERE itemId = @itemId;";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            $"{rowsAffected} item(s) marked as archived.",
                            "Soft Delete Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during SoftDeleteItemFromInventory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while archiving the inventory item.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        }

        // soft deletion based on category Id
        public void SoftDeleteItemsByCategory(int categoryId)
        {
            string query = "UPDATE Inventory SET isArchived = 1 WHERE itemCategoryId = @categoryId;";

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            $"{rowsAffected} item(s) under Category ID {categoryId} marked as archived.",
                            "Category Soft Delete Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during SoftDeleteItemsByCategory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while archiving items by category.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        } // soft deletion based on cat Id

    } // end of InventorySoftDelete

    // unarchiving it back to inventory
    public class InventoryRestore : BaseRepository
    {
        public void RestoreItemToInventory(int itemId)
        {
            string query = "UPDATE Inventory SET isArchived = 0 WHERE itemId = @itemId;";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            $"{rowsAffected} item(s) restored from archive.",
                            "Restore Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during RestoreItemToInventory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while restoring the inventory item.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        }   // by item ID

        // by cat ID
        public void RestoreItemsByCategory(int categoryId)
        {
            string query = "UPDATE Inventory SET isArchived = 0 WHERE itemCategoryId = @categoryId;";

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            $"{rowsAffected} item(s) from the selected category restored from archive.",
                            "Restore Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during RestoreItemsByCategory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while restoring inventory items by category.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        }   // end of restoring by Cat ID

    }   // unarchiving it back

    // inventory delete
    public class InventoryDelete : BaseRepository
    {
        public void DeleteItemFromInventory(int itemId)
        {
            string query = "DELETE FROM Inventory WHERE itemId = @itemId;";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Inform the user via MessageBox
                        MessageBox.Show(
                            $"{rowsAffected} row(s) deleted successfully.",
                            "Deletion Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during DeleteItemFromInventory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while deleting the item from the database.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        }   // end of delete item by ID

        // deletion by cat ID
        public void DeleteItemsByCategory(int categoryId)
        {
            string query = "DELETE FROM Inventory WHERE itemCategoryId = @categoryId;";

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Inform the user via MessageBox
                        MessageBox.Show(
                            $"{rowsAffected} row(s) deleted successfully for category ID {categoryId}.",
                            "Deletion Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during DeleteItemsByCategory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while deleting items from the database by category.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        }   // end of delete by CAT ID

    }
    //end of inventory delete
}