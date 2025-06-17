using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Reload
{
    public class ReloadCategory
    {
        // Make the method public and static if you don't need to instantiate ReloadInventory
        // or just public if you plan to create an instance of ReloadInventory
        public static void LoadCategoryData(DataGridView dataGridView1)
        {
            // Clear existing rows before loading new data to prevent duplicates
            dataGridView1.Rows.Clear();

            CategoryRead read = new CategoryRead();
            List<CategoryItem> items = read.GetAllCategories();

            foreach (var item in items)
            {
                dataGridView1.Rows.Add(
                    item.categoryId,
                    item.categoryName,
                    item.categoryDescription
                );
            }
        }
    }
}
