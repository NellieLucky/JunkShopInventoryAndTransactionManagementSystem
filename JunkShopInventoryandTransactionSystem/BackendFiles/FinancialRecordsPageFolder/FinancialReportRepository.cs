using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.FinancialRecordsPageFolder
{
    public class FinancialReportRepository
    {
        private readonly string _connectionString;

        public FinancialReportRepository()
        {
            _connectionString = FinancialReportConfig.ConnectionString;
        }

        public List<FinancialReportRow> GetFinancialReportRows()
        {
            var reportRows = new List<FinancialReportRow>();
            string sql = @"
                SELECT
                    CAST(t.transacDate AS DATE) AS [Date],
                    SUM(CASE WHEN c.customerType = 'Seller' THEN t.totalAmount ELSE 0 END) AS CostOfGoodsSold,
                    SUM(CASE WHEN c.customerType = 'Buyer' THEN t.totalAmount ELSE 0 END) AS Revenue
                FROM
                    Transactions t
                    INNER JOIN Customer c ON t.customerId = c.customerId
                WHERE
                    t.isArchived = 0
                GROUP BY
                    CAST(t.transacDate AS DATE)
                ORDER BY
                    [Date]
            ";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reportRows.Add(new FinancialReportRow
                        {
                            Date = reader.GetDateTime(0),
                            CostOfGoodsSold = reader.GetDecimal(1),
                            Revenue = reader.GetDecimal(2)
                        });
                    }
                }
            }
            return reportRows;
        }
    }
}