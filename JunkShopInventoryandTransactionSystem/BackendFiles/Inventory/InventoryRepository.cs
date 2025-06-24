using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using Microsoft.Data.SqlClient;

public class InventoryRepository : BaseRepository
{
    public List<InventoryItem> GetLowStockItems(int threshold = 20)
    {
        var items = new List<InventoryItem>();
        using (var conn = GetConnection())
        {
            string sql = "SELECT itemId, itemName, itemQuantity FROM Inventory WHERE itemQuantity < @threshold AND isArchived = 0";
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@threshold", threshold);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new InventoryItem
                        {
                            itemId = reader.GetInt32(0),
                            itemName = reader.GetString(1),
                            itemQuantity = reader.GetInt32(2)
                        });
                    }
                }
            }
        }
        return items;
    }
}