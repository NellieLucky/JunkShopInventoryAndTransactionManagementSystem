using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using Microsoft.Data.SqlClient;

/*  RUN THIS QUERY IN YOUR MS SQL SERVER MANAGEMENT STUDIO (SSMS) TO CREATE THE TABLE
         *  
            -- TABLE CREATION
            CREATE TABLE Inventory (
                itemId INT IDENTITY(1,1) PRIMARY KEY,
                itemName VARCHAR(50) NOT NULL,
                itemCategory VARCHAR(50) NOT NULL,
                itemQtyType VARCHAR(50) NOT NULL,
                itemQuantity INT NOT NULL,
                itemBuyingPrice INT NOT NULL,
                itemSellingPrice INT NOT NULL
            );
            -- AFTER TABLE CREATION, REFRESH DATA CONNECTIONS HERE IN VISUAL STUDIO AND CONNECT THE DB

            -- Example of inserting a row into the Inventory table
            -- <TEXT> = put any TEXT VALUE you want here , DO NOT FORGET TO ENCLOSE THEM IN SINGLE QUOTES
            -- <INT> = put any INTEGER VALUE you want here

            INSERT INTO Inventory (itemName, itemCategory, itemQtyType, itemQuantity, itemBuyingPrice, itemSellingPrice)
            VALUES ('<TEXT>', '<TEXT>', <INT>, <INT>, <INT>, <INT>);

            -- to view datas directly on MS SQL SERVER 
            SELECT * FROM Inventory
        */

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud
{
    //is referencing to the data/holds the data
    public class InventoryItem
    {
        public int itemId { get; set; } // Database generates this for new items
        public string itemName { get; set; }
        public string itemCategory { get; set; }
        public string itemQtyType { get; set; } // is string for now
        public int itemQuantity { get; set; }
        public int itemBuyingPrice { get; set; }
        public int itemSellingPrice { get; set; }

        // Parameterless constructor: Needed by InventoryRead when creating an empty object from DB reader
        // i actually dont know what this does, but is needed for the InventoryRead class to work properly 
        public InventoryItem() { }

        // withoutID
        public InventoryItem(string name, string category, string qtyType, int quantity, int buyingPrice, int sellingPrice)
        {
            itemName = name;
            itemCategory = category;
            itemQtyType = qtyType;
            itemQuantity = quantity;
            itemBuyingPrice = buyingPrice;
            itemSellingPrice = sellingPrice;
        }

        // with ID
        public InventoryItem(int id, string name, string category, string qtyType, int quantity, int buyingPrice, int sellingPrice)
        {
            itemId = id;
            itemName = name;
            itemCategory = category;
            itemQtyType = qtyType;
            itemQuantity = quantity;
            itemBuyingPrice = buyingPrice;
            itemSellingPrice = sellingPrice;
        }
    }
    // eND of InventoryItem CLASS

    // InventoryRead Class
    public class InventoryRead
    {
        //copy this to other classes that will use this connection string

        //comms ko muna
        //private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkshopDB.mdf;Integrated Security=True";


        // Method to get a connection object
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to SELECT all rows from the Inventory table
        public List<InventoryItem> GetAllInventoryItems()
        {
            List<InventoryItem> items = new List<InventoryItem>(); // Initialize an empty list

            using (SqlConnection conn = GetConnection()) // Ensures connection is closed
            {
                string query = "SELECT itemId, itemName, itemCategory, itemQtyType, itemQuantity, itemBuyingPrice, itemSellingPrice FROM Inventory";
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
                                    // Fix for CS8601: Possible null reference assignment.
                                    // The issue occurs because the `reader["itemCategory"].ToString()` might return null.
                                    // To fix this, we can use the null-coalescing operator (`??`) to provide a default value.

                                    
                                    itemName = reader["itemName"].ToString() ?? string.Empty,
                                    itemCategory = reader["itemCategory"]?.ToString() ?? string.Empty,
                                    //itemCategory = reader["itemCategory"].ToString(),
                                    itemQtyType = reader["itemQtyType"].ToString() ?? string.Empty,
                                    itemQuantity = Convert.ToInt32(reader["itemQuantity"]),
                                    itemBuyingPrice = Convert.ToInt32(reader["itemBuyingPrice"]),
                                    itemSellingPrice = Convert.ToInt32(reader["itemSellingPrice"])
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
    }
    // End of inventory Read

    // inventory add aaa
    public class InventoryAdd
    {
        //comms ko muna
        //private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkshopDB.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void AddItemToInventory(InventoryItem item)
        {
            string query = "INSERT INTO Inventory (itemName, itemCategory, itemQtyType, itemQuantity, itemBuyingPrice, itemSellingPrice) " +
                           "VALUES (@itemName, @itemCategory, @itemQtyType, @itemQuantity, @itemBuyingPrice, @itemSellingPrice);";

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to prevent SQL Injection and handle data types correctly
                    cmd.Parameters.AddWithValue("@itemName", item.itemName);
                    cmd.Parameters.AddWithValue("@itemCategory", item.itemCategory);
                    cmd.Parameters.AddWithValue("@itemQtyType", item.itemQtyType);
                    cmd.Parameters.AddWithValue("@itemQuantity", item.itemQuantity);
                    cmd.Parameters.AddWithValue("@itemBuyingPrice", item.itemBuyingPrice);
                    cmd.Parameters.AddWithValue("@itemSellingPrice", item.itemSellingPrice);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        Console.WriteLine($"{rowsAffected} row(s) inserted successfully."); // For debugging/confirmation
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Database error during AddItemToInventory: " + ex.Message);
                        // IMPORTANT: Throw the exception so the calling code can handle it.
                        throw new Exception("An error occurred while adding the item to the database.", ex);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An unexpected error occurred: " + ex.Message);
                        throw;
                    }
                }
            }
        }
    }
    // end of InventoryAdd

    //inventory edit
    /* commented for now base gpt code not yet debugged
    public class InventoryEdit
    {
        private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Add your UpdateItemToInventory method here
        public void UpdateItemInInventory(InventoryItem item)
        {
            // Example:
            string query = "UPDATE Inventory SET " +
                           "itemName = @itemName, " +
                           "itemCategory = @itemCategory, " +
                           "itemQtyType = @itemQtyType, " +
                           "itemQuantity = @itemQuantity, " +
                           "itemBuyingPrice = @itemBuyingPrice, " +
                           "itemSellingPrice = @itemSellingPrice " +
                           "WHERE itemId = @itemId;"; // Don't forget the WHERE clause!

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemId", item.itemId); // Crucial for update
                    cmd.Parameters.AddWithValue("@itemName", item.itemName);
                    cmd.Parameters.AddWithValue("@itemCategory", item.itemCategory);
                    cmd.Parameters.AddWithValue("@itemQtyType", item.itemQtyType);
                    cmd.Parameters.AddWithValue("@itemQuantity", item.itemQuantity);
                    cmd.Parameters.AddWithValue("@itemBuyingPrice", item.itemBuyingPrice);
                    cmd.Parameters.AddWithValue("@itemSellingPrice", item.itemSellingPrice);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) updated successfully.");
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Database error during UpdateItemInInventory: " + ex.Message);
                        throw new Exception("An error occurred while updating the item in the database.", ex);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An unexpected error occurred: " + ex.Message);
                        throw;
                    }
                }
            }
        }
    }
    */
    // end of InventoryEdit

}