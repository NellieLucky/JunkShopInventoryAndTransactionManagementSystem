using MaterialSkin;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  RUN THIS QUERY IN YOUR MS SQL SERVER MANAGEMENT STUDIO (SSMS) TO CREATE THE TABLE

-- TABLE CREATION
CREATE TABLE Transactions (
    transacId INT IDENTITY(1,1) PRIMARY KEY,
    customerId INT NOT NULL,
    employeeId INT NOT NULL,
    transacDate DATETIME NOT NULL DEFAULT GETDATE(),
    totalNumOfItems INT NOT NULL,
    totalNumOfQty DECIMAL(18, 2) NOT NULL,
    totalAmount DECIMAL(18, 2) NOT NULL,
    customerType VARCHAR(10) NOT NULL CHECK (customerType IN ('Buyer', 'Seller')),
    isArchived BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (customerId) REFERENCES Customer(customerId),  -- FK reference
    FOREIGN KEY (employeeId) REFERENCES Employees(empId)  -- FK reference
);

ALTER TABLE Transactions
ALTER COLUMN totalNumOfQty DECIMAL(18, 2);

CREATE TABLE TransactionItems (
    transactionId INT NOT NULL,
    itemId INT NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(18, 2) NOT NULL,
    PRIMARY KEY (transactionId, itemId),
    FOREIGN KEY (transactionId) REFERENCES Transactions(transacId),
    FOREIGN KEY (itemId) REFERENCES Inventory(itemId)
);

SELECT * FROM Transactions;
SELECT * FROM TransactionItems;

*/

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud
{
    public class TransactionItem
    {
        public int transacId { get; set; }
        public int customerId { get; set; }
        public string customerName { get; set; } = string.Empty;
        public int employeeId { get; set; }
        public string employeeName { get; set; } = string.Empty;
        public DateTime transacDate { get; set; }
        public int totalNumOfItems { get; set; }
        public decimal totalNumOfQty { get; set; }
        public decimal totalAmount { get; set; }
        public string customerType { get; set; } = string.Empty;
        public bool isArchived { get; set; } = false;

        public TransactionItem() { }

        public TransactionItem(
            int customerId,
            string customerName,
            int employeeId,
            string employeeName,
            DateTime transacDate,
            int totalNumOfItems,
            decimal totalNumOfQty, // ← changed here
            decimal totalAmount,
            string customerType,
            bool isArchived = false)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.transacDate = transacDate;
            this.totalNumOfItems = totalNumOfItems;
            this.totalNumOfQty = totalNumOfQty; // ← updated type
            this.totalAmount = totalAmount;
            this.customerType = customerType;
            this.isArchived = isArchived;
        }

        public TransactionItem(
            int transacId,
            int customerId,
            string customerName,
            int employeeId,
            string employeeName,
            DateTime transacDate,
            int totalNumOfItems,
            decimal totalNumOfQty, // ← changed here
            decimal totalAmount,
            string customerType,
            bool isArchived = false)
        {
            this.transacId = transacId;
            this.customerId = customerId;
            this.customerName = customerName;
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.transacDate = transacDate;
            this.totalNumOfItems = totalNumOfItems;
            this.totalNumOfQty = totalNumOfQty; // ← updated type
            this.totalAmount = totalAmount;
            this.customerType = customerType;
            this.isArchived = isArchived;
        }
    }

    public abstract class BaseRepository
    {
        // Centralized connection string
        // arnels string?
        protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        // Sandara's string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sandara Fillartos\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf"";Integrated Security=True";

        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        //remo string
        //protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //ethan's connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //nicole's connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";
        
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    public class TransactionRead : BaseRepository
    {
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
                e.empName AS employeeName,
                t.transacDate,
                t.totalNumOfItems,
                t.totalNumOfQty,
                t.totalAmount,
                t.customerType,
                t.isArchived
            FROM Transactions t
            INNER JOIN Customer c ON t.customerId = c.customerId
            INNER JOIN Employees e ON t.employeeId = e.empId
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
                                    employeeName = reader["employeeName"]?.ToString() ?? string.Empty,
                                    transacDate = Convert.ToDateTime(reader["transacDate"]),
                                    totalNumOfItems = Convert.ToInt32(reader["totalNumOfItems"]),
                                    totalNumOfQty = Convert.ToDecimal(reader["totalNumOfQty"]),
                                    totalAmount = Convert.ToDecimal(reader["totalAmount"]),
                                    customerType = reader["customerType"]?.ToString() ?? string.Empty
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
    }

    public class TransactionCreate : BaseRepository
    {
        // Original method (still available)
        
        

        // New: Insert and return the new transaction's ID
        public int AddNewTransactionAndReturnId(
            int customerId,
            int employeeId,
            int totalItems,
            decimal totalQty,
            decimal totalAmount,
            string customerType
        )
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                INSERT INTO Transactions (
                    customerId,
                    employeeId,
                    transacDate,
                    totalNumOfItems,
                    totalNumOfQty,
                    totalAmount,
                    customerType
                )
                OUTPUT INSERTED.transacId
                VALUES (
                    @customerId,
                    @employeeId,
                    GETDATE(),
                    @totalNumOfItems,
                    @totalNumOfQty,
                    @totalAmount,
                    @customerType
                )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@totalNumOfItems", totalItems);
                    cmd.Parameters.AddWithValue("@totalNumOfQty", totalQty);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@customerType", customerType);

                    try
                    {
                        conn.Open();
                        object? result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error inserting new transaction: " + ex.Message);
                        throw new Exception("Failed to insert new transaction.", ex);
                    }
                }
            }
        }

        // New: Insert a single item into TransactionItems
        public bool AddTransactionItem(int transactionId, int itemId, decimal quantity, decimal price)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                INSERT INTO TransactionItems (transactionId, itemId, quantity, price)
                VALUES (@transactionId, @itemId, @quantity, @price)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@transactionId", transactionId);
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error inserting transaction item: " + ex.Message);
                        throw new Exception("Failed to insert transaction item.", ex);
                    }
                }
            }
        }
    }

    public class TransactionDelete : BaseRepository
    {
        public bool ArchiveTransaction(int transacId)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Archive the transaction only (no inventory reversion)
                        string archiveQuery = "UPDATE Transactions SET isArchived = 1 WHERE transacId = @transacId";
                        using (var cmd = new SqlCommand(archiveQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@transacId", transacId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("❌ Error archiving transaction: " + ex.Message);
                        throw new Exception("Failed to archive transaction.", ex);
                    }
                }
            }
        }

        public bool UnarchiveTransaction(int transacId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "UPDATE Transactions SET isArchived = 0 WHERE transacId = @transacId";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@transacId", transacId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        //public bool DeleteTransaction(int transacId)
        //{
        //    using (SqlConnection conn = GetConnection())
        //    {
        //        string deleteItemsQuery = @"DELETE FROM TransactionItems WHERE transactionId = @transacId";
        //        string deleteTransactionQuery = @"DELETE FROM Transactions WHERE transacId = @transacId";

        //        using (SqlCommand cmd = new SqlCommand(deleteItemsQuery, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@transacId", transacId);

        //            try
        //            {
        //                conn.Open();
        //                cmd.ExecuteNonQuery();

        //                cmd.CommandText = deleteTransactionQuery;
        //                int rowsAffected = cmd.ExecuteNonQuery();
        //                return rowsAffected > 0;
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine("❌ Error deleting transaction: " + ex.Message);
        //                throw new Exception("Failed to delete transaction.", ex);
        //            }
        //        }
        //    }
        //}

        // Uncomment this method if you want to revert inventory changes when archiving a transaction
        // Note: This method is commented out because it may not be needed in the current context.

        //public bool ArchiveTransaction(int transacId)
        //{
        //    using (SqlConnection conn = GetConnection())
        //    {
        //        conn.Open();
        //        using (var transaction = conn.BeginTransaction())
        //        {
        //            try
        //            {
        //                // 1. Get transaction type (Buyer/Seller)
        //                string getTypeQuery = "SELECT customerType FROM Transactions WHERE transacId = @transacId";
        //                string customerType = "";
        //                using (var cmd = new SqlCommand(getTypeQuery, conn, transaction))
        //                {
        //                    cmd.Parameters.AddWithValue("@transacId", transacId);
        //                    var result = cmd.ExecuteScalar();
        //                    if (result == null)
        //                        throw new Exception("Transaction not found.");
        //                    customerType = result?.ToString() ?? string.Empty;
        //                }

        //                // 2. Get all items in the transaction
        //                string getItemsQuery = "SELECT itemId, quantity FROM TransactionItems WHERE transactionId = @transacId";
        //                var items = new List<(int itemId, int quantity)>();
        //                using (var cmd = new SqlCommand(getItemsQuery, conn, transaction))
        //                {
        //                    cmd.Parameters.AddWithValue("@transacId", transacId);
        //                    using (var reader = cmd.ExecuteReader())
        //                    {
        //                        while (reader.Read())
        //                        {
        //                            items.Add((reader.GetInt32(0), reader.GetInt32(1)));
        //                        }
        //                    }
        //                }

        //                // 3. Revert inventory changes
        //                foreach (var (itemId, quantity) in items)
        //                {
        //                    string updateInventoryQuery = @"
        //                UPDATE Inventory
        //                SET itemQuantity = itemQuantity " +
        //                        (customerType == "Buyer" ? "+" : "-") + " @quantity " +
        //                        "WHERE itemId = @itemId";
        //                    using (var cmd = new SqlCommand(updateInventoryQuery, conn, transaction))
        //                    {
        //                        cmd.Parameters.AddWithValue("@quantity", quantity);
        //                        cmd.Parameters.AddWithValue("@itemId", itemId);
        //                        cmd.ExecuteNonQuery();
        //                    }
        //                }

        //                // 4. Archive the transaction
        //                string archiveQuery = "UPDATE Transactions SET isArchived = 1 WHERE transacId = @transacId";
        //                using (var cmd = new SqlCommand(archiveQuery, conn, transaction))
        //                {
        //                    cmd.Parameters.AddWithValue("@transacId", transacId);
        //                    cmd.ExecuteNonQuery();
        //                }

        //                transaction.Commit();
        //                return true;
        //            }
        //            catch (Exception ex)
        //            {
        //                transaction.Rollback();
        //                Console.WriteLine("❌ Error archiving transaction: " + ex.Message);
        //                throw new Exception("Failed to archive transaction and revert inventory.", ex);
        //            }
        //        }
        //    }
        //}
    }
}