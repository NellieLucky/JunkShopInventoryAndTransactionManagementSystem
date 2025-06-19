using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*  RUN THIS QUERY IN YOUR MS SQL SERVER MANAGEMENT STUDIO (SSMS) TO CREATE THE TABLE

-- TABLE CREATION
CREATE TABLE Transactions (
    transacId INT IDENTITY(1,1) PRIMARY KEY,
    customerId INT NOT NULL,
    employeeId INT NOT NULL,
    transacDate DATETIME NOT NULL DEFAULT GETDATE(),
    totalNumOfItems INT NOT NULL,
    totalNumOfQty INT NOT NULL,
    totalAmount DECIMAL(18, 2) NOT NULL,
    transacType VARCHAR(10) NOT NULL CHECK (transacType IN ('Buyer', 'Seller')),
    isArchived BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (customerId) REFERENCES Customer(customerId),  -- FK reference
    FOREIGN KEY (employeeId) REFERENCES Employees(empId)  -- FK reference
);

SELECT * FROM Transaction;

*/

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud
{
    //constructor here
    public class TransactionItem
    {
        public int transacId { get; set; }
        public int customerId { get; set; }
        public string customerName { get; set; } = string.Empty; // ✅ Add this property
        public int employeeId { get; set; }
        public DateTime transacDate { get; set; }
        public int totalNumOfItems { get; set; }
        public int totalNumOfQty { get; set; }
        public decimal totalAmount { get; set; }
        public string transacType { get; set; } = string.Empty;
        public bool isArchived { get; set; } = false;

        // ✅ Parameterless constructor
        public TransactionItem() { }

        // ✅ Constructor for adding (no ID)
        public TransactionItem(
            int customerId,
            string customerName,
            int employeeId,
            DateTime transacDate,
            int totalNumOfItems,
            int totalNumOfQty,
            decimal totalAmount,
            string transacType,
            bool isArchived = false)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.employeeId = employeeId;
            this.transacDate = transacDate;
            this.totalNumOfItems = totalNumOfItems;
            this.totalNumOfQty = totalNumOfQty;
            this.totalAmount = totalAmount;
            this.transacType = transacType;
            this.isArchived = isArchived;
        }

        // ✅ Constructor with ID (e.g., for editing/viewing)
        public TransactionItem(
            int transacId,
            int customerId,
            string customerName,
            int employeeId,
            DateTime transacDate,
            int totalNumOfItems,
            int totalNumOfQty,
            decimal totalAmount,
            string transacType,
            bool isArchived = false)
        {
            this.transacId = transacId;
            this.customerId = customerId;
            this.customerName = customerName;
            this.employeeId = employeeId;
            this.transacDate = transacDate;
            this.totalNumOfItems = totalNumOfItems;
            this.totalNumOfQty = totalNumOfQty;
            this.totalAmount = totalAmount;
            this.transacType = transacType;
            this.isArchived = isArchived;
        }
    }

    // for db
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

    //CRUD STARTS HERE

    public class TransactionRead : BaseRepository
    {
        // Read all UNARCHIVED transactions with Customer Name
        public List<TransactionItem> GetAllTransactions()
        {
            List<TransactionItem> transactions = new List<TransactionItem>();

            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT 
                        t.transacId,
                        t.customerId,
                        c.customerName,
                        t.employeeId,
                        t.transacDate,
                        t.totalNumOfItems,
                        t.totalNumOfQty,
                        t.totalAmount,
                        t.transacType,
                        t.isArchived
                    FROM Transactions t
                    INNER JOIN Customer c ON t.customerId = c.customerId
                    WHERE t.isArchived = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransactionItem transaction = new TransactionItem
                                {
                                    transacId = Convert.ToInt32(reader["transacId"]),
                                    customerId = Convert.ToInt32(reader["customerId"]),
                                    customerName = reader["customerName"]?.ToString() ?? string.Empty,
                                    employeeId = Convert.ToInt32(reader["employeeId"]),
                                    transacDate = Convert.ToDateTime(reader["transacDate"]),
                                    totalNumOfItems = Convert.ToInt32(reader["totalNumOfItems"]),
                                    totalNumOfQty = Convert.ToInt32(reader["totalNumOfQty"]),
                                    totalAmount = Convert.ToDecimal(reader["totalAmount"]),
                                    transacType = reader["transacType"]?.ToString() ?? string.Empty,
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };

                                transactions.Add(transaction);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading Transactions table: " + ex.Message);
                        throw new Exception("Failed to retrieve transactions from the database.", ex);
                    }
                }
            }

            return transactions;
        }

        // Read all ARCHIVED transactions with Customer Name
        public List<TransactionItem> GetAllArchivedTransactions()
        {
            List<TransactionItem> transactions = new List<TransactionItem>();

            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT 
                        t.transacId,
                        t.customerId,
                        c.customerName,
                        t.employeeId,
                        t.transacDate,
                        t.totalNumOfItems,
                        t.totalNumOfQty,
                        t.totalAmount,
                        t.transacType,
                        t.isArchived
                    FROM Transactions t
                    INNER JOIN Customer c ON t.customerId = c.customerId
                    WHERE t.isArchived = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransactionItem transaction = new TransactionItem
                                {
                                    transacId = Convert.ToInt32(reader["transacId"]),
                                    customerId = Convert.ToInt32(reader["customerId"]),
                                    customerName = reader["customerName"]?.ToString() ?? string.Empty,
                                    employeeId = Convert.ToInt32(reader["employeeId"]),
                                    transacDate = Convert.ToDateTime(reader["transacDate"]),
                                    totalNumOfItems = Convert.ToInt32(reader["totalNumOfItems"]),
                                    totalNumOfQty = Convert.ToInt32(reader["totalNumOfQty"]),
                                    totalAmount = Convert.ToDecimal(reader["totalAmount"]),
                                    transacType = reader["transacType"]?.ToString() ?? string.Empty,
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };

                                transactions.Add(transaction);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading archived Transactions: " + ex.Message);
                        throw new Exception("Failed to retrieve archived transactions from the database.", ex);
                    }
                }
            }

            return transactions;
        }
    } // end of read for archived
    // end of reads

}
