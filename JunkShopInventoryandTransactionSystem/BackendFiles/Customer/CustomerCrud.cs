using System;
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
    customerContact NVARCHAR(50) NOT NULL,
    customerAddress NVARCHAR(200) NOT NULL
);

INSERT INTO Customer (customerName, customerType, customerContact, customerAddress)
VALUES 
('Remo', 'Buyer', '09123456789', 'TEST1 Street'),
('Abalos', 'Seller', '09998887766', 'TEST2 Avenue'),
('Arnel', 'Both', '08881234567', 'TEST3 Boulevard');

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
        protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //Arnel's connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }


}
