using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Dashboard
{
    public class DashboardCounts
    {

        // Centralized connection string
        // remo string
        private static readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //arnel string
        //private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        public static (int Items, int Categories, int Employees) GetDashboardCounts()
        {
            int items = 0, categories = 0, employees = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get Items Count (non-archived)
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Inventory WHERE isArchived = 0", conn))
                    {
                        items = (int)cmd.ExecuteScalar();
                    }

                    // Get Categories Count (non-archived)
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Category WHERE isArchived = 0", conn))
                    {
                        categories = (int)cmd.ExecuteScalar();
                    }

                    // Get Employees Count (non-removed)
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Employees WHERE IsRemoved = 0", conn))
                    {
                        employees = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error getting dashboard counts: {ex.Message}",
                    "Dashboard Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }

            return (items, categories, employees);
        }
    }
}