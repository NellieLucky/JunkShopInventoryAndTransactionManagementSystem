using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using JunkShopInventoryandTransactionSystem.BackendFiles.Transaction.Crud;

public class DashboardSummary
{
    public decimal COGS { get; set; }
    public decimal Revenue { get; set; }
    public decimal Profit { get; set; }
    public List<ChartPoint> ChartPoints { get; set; } = new();
}

public class ChartPoint
{
    public string Label { get; set; }
    public decimal Value { get; set; }
}

public static class DashboardDataRepository
{
    public static DashboardSummary GetSummary(
        string summaryType,
        string periodicity)
    {
        var transactions = new TransactionRead().GetAllTransactions();

        // COGS: sum of all seller transactions
        decimal cogs = transactions
            .Where(t => t.customerType.Equals("Seller", StringComparison.OrdinalIgnoreCase))
            .Sum(t => t.totalAmount);

        // Revenue: sum of all buyer transactions
        decimal revenue = transactions
            .Where(t => t.customerType.Equals("Buyer", StringComparison.OrdinalIgnoreCase))
            .Sum(t => t.totalAmount);

        // Profit: Revenue - COGS
        decimal profit = revenue - cogs;

        var summary = new DashboardSummary
        {
            COGS = cogs,
            Revenue = revenue,
            Profit = profit
        };

        // Group for chart display
        var grouped = periodicity switch
        {
            "Yearly" => transactions.GroupBy(t => t.transacDate.Year.ToString()),
            "Quarterly" => transactions.GroupBy(t => $"{t.transacDate.Year}-Q{((t.transacDate.Month - 1) / 3) + 1}"),
            "Monthly" => transactions.GroupBy(t => t.transacDate.ToString("yyyy-MM")),
            _ => transactions.GroupBy(t => t.transacDate.Year.ToString())
        };

        foreach (var group in grouped)
        {
            decimal groupCogs = group
                .Where(t => t.customerType.Equals("Seller", StringComparison.OrdinalIgnoreCase))
                .Sum(t => t.totalAmount);

            decimal groupRevenue = group
                .Where(t => t.customerType.Equals("Buyer", StringComparison.OrdinalIgnoreCase))
                .Sum(t => t.totalAmount);

            decimal groupProfit = groupRevenue - groupCogs;

            string label = group.Key;

            decimal value = summaryType switch
            {
                "COGS Summary" => groupCogs,
                "Revenue Summary" => groupRevenue,
                "Profit Summary" => groupProfit,
                _ => 0
            };

            summary.ChartPoints.Add(new ChartPoint { Label = label, Value = value });
        }

        return summary;
    }
}

public class TransactionRead : BaseRepository
{
    public List<TransactionItem> GetAllTransactions()
    {
        using (var connection = GetConnection())
        {
            var transactions = new List<TransactionItem>();
            // Explicitly specify columns and their order
            var query = @"
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
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(new TransactionItem
                        {
                            transacId = reader.GetInt32(0),
                            customerId = reader.GetInt32(1),
                            customerName = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            employeeId = reader.GetInt32(3),
                            employeeName = reader.IsDBNull(4) ? "" : reader.GetString(4),
                            transacDate = reader.GetDateTime(5),
                            totalNumOfItems = reader.GetInt32(6),
                            totalNumOfQty = reader.GetDecimal(7),
                            totalAmount = reader.GetDecimal(8),
                            customerType = reader.IsDBNull(9) ? "" : reader.GetString(9),
                            isArchived = reader.GetBoolean(10)
                        });
                    }
                }
            }
            return transactions;
        }
    }
}