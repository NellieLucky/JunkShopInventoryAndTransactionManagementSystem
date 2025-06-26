using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;


namespace JunkShopInventoryandTransactionSystem.BackendFiles.IndInvoice
{
    internal class DataHelper
    {
        // Centralized connection string
        // remo string
        // public static string ConnectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //nicole's connection string
        // public static string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security = True";

        //Arnel's connection string
        //public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //Abalos' connection string
        //public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        //Dara's connection string
        // public static string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sandara Fillartos\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf"";Integrated Security = True";

        //Ethan's connection string
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        public static DataTable GetReceiptItems(int transacId)
        {
            var dt = new DataTable();
            string query = @"
                SELECT 
                    ti.itemId AS ItemID,
                    i.itemName AS ItemName,
                    i.itemQtyType AS QtyType,
                    i.itemSellingPrice AS SellingPrice,
                    ti.quantity AS ExchangeQuantity,
                    (ti.quantity * ti.price) AS ExchangeAmount
                FROM TransactionItems ti
                INNER JOIN Inventory i ON ti.itemId = i.itemId
                WHERE ti.transactionId = @transacId";

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@transacId", transacId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public static void LoadReceiptItems(int transacId, DataGridView InvoiceReceiptTable, Label TotalItemHolder, Label TotalPriceHolder)
        {
            try
            {
                DataTable receipttable = GetReceiptItems(transacId);
                InvoiceReceiptTable.AutoGenerateColumns = false;
                InvoiceReceiptTable.DataSource = receipttable;

                // Optionally, set column headers for better readability
                InvoiceReceiptTable.Columns["ItemID"].DataPropertyName = "ItemID";
                InvoiceReceiptTable.Columns["ItemName"].DataPropertyName = "ItemName";
                InvoiceReceiptTable.Columns["QtyType"].DataPropertyName = "QtyType";
                InvoiceReceiptTable.Columns["Price"].DataPropertyName = "Price";
                InvoiceReceiptTable.Columns["TransacQuantity"].DataPropertyName = "ExchangeQuantity";
                InvoiceReceiptTable.Columns["TransacAmount"].DataPropertyName = "ExchangeAmount";

                // Calculate totals
                int totalQuantity = 0;
                decimal totalPrice = 0;

                foreach (DataRow row in receipttable.Rows)
                {
                    if (row["ExchangeQuantity"] != DBNull.Value)
                        totalQuantity += Convert.ToInt32(row["ExchangeQuantity"]);
                    if (row["ExchangeAmount"] != DBNull.Value)
                        totalPrice += Convert.ToDecimal(row["ExchangeAmount"]);
                }

                // Set the labels
                TotalItemHolder.Text = totalQuantity.ToString();
                TotalPriceHolder.Text = "₱ " + totalPrice.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading receipt items: " + ex.Message);
            }
        }

        public static string GetCustomerIdByName(string CustName)
        {
            string? customerId = "Unknown";
            string? query = "SELECT customerId FROM Customer WHERE customerName = @customerName";

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@customerName", CustName);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customerId = reader["customerId"].ToString();
                    }
                }
            }
            return customerId;
        }

        public static string GetCustomerContactById(string customerId)
        {
            string? contact = "Unknown";
            string? query = "SELECT customerContact FROM Customer WHERE customerId = @customerId";

            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@customerId", customerId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contact = reader["customerContact"].ToString();
                    }
                }
            }
            return contact;
        }
    }
}
