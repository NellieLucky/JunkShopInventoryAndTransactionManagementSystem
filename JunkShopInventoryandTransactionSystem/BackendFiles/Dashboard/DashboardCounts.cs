using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Dashboard
{
    public class DashboardCounts
    {
        // remo string
        //private static readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //nicole's connection string
        //private static readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security = True";

        //Arnel's connection string
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //Abalos's connection string
        //private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        //Dara's connection string
        //private static readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sandara Fillartos\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf"";Integrated Security = True";


        public static (int Items, int Categories, int Employees, int Buyers, int Sellers) GetDashboardCounts()
        {
            int items = 0, categories = 0, employees = 0, buyers = 0, sellers = 0;

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

                    // Get Buyers Count (where customerType is 'Buyer' and not archived)
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Customer WHERE customerType = 'Buyer'", conn))
                    {
                        buyers = (int)cmd.ExecuteScalar();
                    }

                    // Get Suppliers Count (where customerType is 'Seller' and not archived)
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Customer WHERE customerType = 'Seller'", conn))
                    {
                        sellers = (int)cmd.ExecuteScalar();
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

            return (items, categories, employees, buyers, sellers);
        }
    }
}