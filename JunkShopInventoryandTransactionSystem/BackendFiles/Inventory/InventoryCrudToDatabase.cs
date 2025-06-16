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
        // added " = string.Empty; " to remove warning about nullability
        // incase it receives a NULL value from the database
        public string itemName { get; set; } = string.Empty;
        public string itemCategory { get; set; } = string.Empty;
        public string itemQtyType { get; set; } = string.Empty;
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
        
        //remostring
        private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        
        //private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";
        //arnels string

        // Method to get a connection object
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to SELECT all rows from the Inventory table
        // get all inventory items method
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
        // end of read all

        // just get one
        public InventoryItem? GetOneInventoryItem(int itemId)
        {
            InventoryItem? item = null; // Will remain null if no match is found

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT itemId, itemName, itemCategory, itemQtyType, itemQuantity, itemBuyingPrice, itemSellingPrice " +
                               "FROM Inventory WHERE itemId = @itemId";

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
                                    itemName = reader["itemName"].ToString() ?? string.Empty,
                                    itemCategory = reader["itemCategory"]?.ToString() ?? string.Empty,
                                    itemQtyType = reader["itemQtyType"].ToString() ?? string.Empty,
                                    itemQuantity = Convert.ToInt32(reader["itemQuantity"]),
                                    itemBuyingPrice = Convert.ToInt32(reader["itemBuyingPrice"]),
                                    itemSellingPrice = Convert.ToInt32(reader["itemSellingPrice"])
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

    }
    // End of inventory Read

    // inventory add aaa
    public class InventoryAdd
    {
        //remos string
        private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        
        //arnels string
        //private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";
        

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
    }
    // end of InventoryAdd

    //inventory edit
    public class InventoryEdit
    {
        // remos string
        private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        
        // arnels string
        //private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Add your UpdateItemToInventory method here
        public void EditItemInInventory(InventoryItem item)
        {
            string query = @"
                UPDATE Inventory SET 
                    itemName = @itemName, 
                    itemCategory = @itemCategory, 
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
                    cmd.Parameters.AddWithValue("@itemCategory", item.itemCategory);
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

    // inventory delete
    public class InventoryDelete
    {
        // remos string
        private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        // arnels string
        //private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void DeleteItemFromInventory(int itemId)
        {
            string query = "DELETE FROM Inventory WHERE itemId = @itemId;";
            using (SqlConnection conn = GetConnection())
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
        }
    }
    //end of inventory delete
}