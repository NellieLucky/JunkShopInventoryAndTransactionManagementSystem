﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*  RUN THIS QUERY IN YOUR MS SQL SERVER MANAGEMENT STUDIO (SSMS) TO CREATE THE TABLE

CREATE TABLE Customer (
    customerId INT IDENTITY(1,1) PRIMARY KEY,
    customerName NVARCHAR(100) NOT NULL,
    customerType VARCHAR(10) NOT NULL CHECK (customerType IN ('Buyer', 'Seller', 'Both')),
    customerContact NVARCHAR(50) NULL,
    customerAddress NVARCHAR(200) NULL,
    IsArchived BIT NOT NULL DEFAULT(0)
); 

SELECT * FROM Customer;

*/

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Customer.Crud
{
    // constructor
    public class CustomerItem
    {
        public int customerId { get; set; } // Auto-incremented by DB

        public string customerName { get; set; } = string.Empty;
        public string customerType { get; set; } = string.Empty; // 'Buyer', 'Seller', or 'Both'
        public string customerContact { get; set; } = string.Empty;
        public string customerAddress { get; set; } = string.Empty;

        // Parameterless constructor
        public CustomerItem() { }

        // Constructor for add (no ID)
        public CustomerItem(string name, string type, string contact, string address)
        {
            customerName = name;
            customerType = type;
            customerContact = contact;
            customerAddress = address;
        }

        // Constructor for edit (with ID)
        public CustomerItem(int id, string name, string type, string contact, string address)
        {
            customerId = id;
            customerName = name;
            customerType = type;
            customerContact = contact;
            customerAddress = address;
        }
    }

    public abstract class BaseRepository
    {
        // Centralized connection string
        // remo string
        //protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //nicole's connection string
        //protected readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security = True";

        //Arnel's connection string
        protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //Abalo's connection string
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

    //CRUD STARTS HERE
    public class CustomerRead : BaseRepository
    {
        // READ and get customer Id by using passed customers name
        // used in transaction<buyer/seller>.cs
        public int? GetCustomerIdByNameandType(string customerName, string customerType)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                SELECT customerId 
                FROM Customer 
                WHERE customerName = @customerName AND customerType = @customerType";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerName", customerName.Trim());
                    cmd.Parameters.AddWithValue("@customerType", customerType);


                    try
                    {
                        conn.Open();
                        object? result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int customerId))
                        {
                            return customerId;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error fetching customer ID: " + ex.Message);
                        throw new Exception("Failed to retrieve customer ID.", ex);
                    }
                }
            }

            return null; // Customer not found
        }
    }
    // end of read

    //start of insertion / insert
    public class CustomerInsert : BaseRepository
    {
        // READ and get customer Id by using passed customers name
        // used in transaction<buyer/seller>.cs
        public bool InsertCustomer(string customerName, string? customerContact, string customerType)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
            INSERT INTO Customer (customerName, customerType, customerContact)
            VALUES (@customerName, @customerType, @customerContact);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerName", customerName.Trim());
                    cmd.Parameters.AddWithValue("@customerType", customerType);
                    cmd.Parameters.AddWithValue("@customerContact", string.IsNullOrWhiteSpace(customerContact) ? (object)DBNull.Value : customerContact);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error inserting customer: " + ex.Message);
                        throw new Exception("Failed to insert new customer.", ex);
                    }
                }
            }
        }

    }
    // end of insertion / insert

    public class CustomerDelete : BaseRepository
    {
        // Soft delete (archive) a customer by ID
        public bool ArchiveCustomer(int customerId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE Customer SET isArchived = 1 WHERE customerId = @customerId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error archiving customer: " + ex.Message);
                        throw new Exception("Failed to archive customer.", ex);
                    }
                }
            }
        }
    }
    // end of soft delete

}

