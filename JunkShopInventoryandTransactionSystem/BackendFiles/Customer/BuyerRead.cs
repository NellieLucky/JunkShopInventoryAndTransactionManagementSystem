using System.Collections.Generic;
using JunkShopInventoryandTransactionSystem.BackendFiles.Customer.Crud;
using Microsoft.Data.SqlClient;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Customer
{
    

    public class BuyerSummary
    {
        public int CustomerID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string customerContact { get; set; } = string.Empty;
        public int TotalPurchases { get; set; }
        public decimal TotalPurchasePrice { get; set; }
        public decimal TotalPurchaseQty { get; set; }
    }

    public class BuyerRead : BaseRepository
    {
        public List<BuyerSummary> GetBuyerSummaries()
        {
            var buyers = new List<BuyerSummary>();
            string query = @"
                SELECT
                    c.customerId,
                    c.customerName,
                    ISNULL(c.customerContact, '') AS customerContact,
                    COUNT(t.transacId) AS TotalPurchases,
                    ISNULL(SUM(t.totalAmount), 0) AS TotalPurchasePrice,
                    ISNULL(SUM(t.totalNumOfQty), 0) AS TotalPurchaseQty
                FROM
                    Customer c
                LEFT JOIN
                    Transactions t ON c.customerId = t.customerId AND t.isArchived = 0
                WHERE
                    c.customerType = 'Buyer' AND c.isArchived = 0
                GROUP BY
                    c.customerId, c.customerName, c.customerContact
                ORDER BY
                    c.customerName
            ";

            using (var conn = GetConnection())
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buyers.Add(new BuyerSummary
                            {
                                CustomerID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                customerContact = reader.GetString(2),
                                TotalPurchases = reader.GetInt32(3),
                                TotalPurchaseQty = reader.GetDecimal(4),
                                TotalPurchasePrice = reader.GetDecimal(5)
                                
                            });
                        }
                    }
                }
            }
            return buyers;
        }
    }
}