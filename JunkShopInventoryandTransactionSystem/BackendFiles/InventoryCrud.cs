using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using Microsoft.Data.SqlClient; // Use Microsoft.Data.SqlClient for .NET Core and .NET 5+

namespace JunkShopInventoryandTransactionSystem.BackendFiles
{
    public class InventoryItem
    {
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemCategory { get; set; }
        public int itemQtyType { get; set; }
        public int itemQuantity { get; set; }
        public int itemBuyingPrice { get; set; }
        public int itemSellingPrice { get; set; }
    }

    public class InventoryCrud
    {
        // Connection string (adjust as needed)
        private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        /*  RUN THIS QUERY IN YOUR MS SQL SERVER MANAGEMENT STUDIO (SSMS) TO CREATE THE TABLE
         *  
            -- TABLE CREATION
            CREATE TABLE Inventory (
                itemId INT IDENTITY(1,1) PRIMARY KEY,
                itemName VARCHAR(50) NOT NULL,
                itemCategory VARCHAR(50) NOT NULL,
                itemQtyType INT NOT NULL,
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

        // Method to get a connection object
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to SELECT all rows from the Inventory table
        public List<InventoryItem> GetAllInventoryItems()
        {
            //initialization of the list to hold InventoryItem objects
            List<InventoryItem> items = new List<InventoryItem>();

            using ( SqlConnection conn = GetConnection() )
            {
                string query = "SELECT * FROM Inventory";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        InventoryItem item = new InventoryItem
                        {
                            itemId = Convert.ToInt32(reader["itemId"]),
                            itemName = reader["itemName"].ToString(),
                            itemCategory = reader["itemCategory"].ToString(),
                            itemQtyType = Convert.ToInt32(reader["itemQtyType"]),
                            itemQuantity = Convert.ToInt32(reader["itemQuantity"]),
                            itemBuyingPrice = Convert.ToInt32(reader["itemBuyingPrice"]),
                            itemSellingPrice = Convert.ToInt32(reader["itemSellingPrice"])
                        };

                        //adds the content per row to item
                        items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error reading Inventory table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return items;
        }
    }
}