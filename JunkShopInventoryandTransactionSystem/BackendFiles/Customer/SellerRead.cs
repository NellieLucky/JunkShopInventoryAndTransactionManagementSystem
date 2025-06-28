using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using JunkShopInventoryandTransactionSystem.BackendFiles.Customer.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Customer
{

    public class SellerSummary
    {
        public int CustomerID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string customerContact { get; set; } = string.Empty;
        public int TotalSalesTransaction { get; set; }
        public decimal TotalAmountSold { get; set; }
        public decimal TotalQuantitySold { get; set; }
    }

    public class SellerRead: BaseRepository
    {
        public List<SellerSummary> GetSellerSummaries()
        {
            var sellers = new List<SellerSummary>();
            string query = @"
                SELECT
                    c.customerId,
                    c.customerName,
                    ISNULL(c.customerContact, '') AS customerContact,
                    COUNT(t.transacId) AS TotalSalesTransaction,
                    ISNULL(SUM(t.totalAmount), 0) AS TotalAmountSold,
                    ISNULL(SUM(t.totalNumOfQty), 0) AS TotalQuantitySold
                FROM
                    Customer c
                LEFT JOIN
                    Transactions t ON c.customerId = t.customerId AND t.isArchived = 0
                WHERE
                    c.customerType = 'Seller' AND c.isArchived = 0
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
                            sellers.Add(new SellerSummary
                            {
                                CustomerID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                customerContact = reader.GetString(2),
                                TotalSalesTransaction = reader.GetInt32(3),
                                TotalQuantitySold = reader.GetDecimal(4),
                                TotalAmountSold = reader.GetDecimal(5)
                                
                            });
                        }
                    }
                }
            }
            return sellers;
        }
    } // end of class SellerRead
}
