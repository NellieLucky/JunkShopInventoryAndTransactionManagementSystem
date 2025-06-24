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
        // method to load unarchived inventory data into the DataGridView
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
        }   // end of LoadCategoryData method

        // method to load archived inventory data into the DataGridView
        // not yet used
        public static void LoadArchivedCategoryData(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();

            CategoryRead read = new CategoryRead();
            List<CategoryItem> categories = read.GetAllArchivedCategories();

            foreach (var cat in categories)
            {
                dataGridView1.Rows.Add(
                    cat.categoryId,
                    cat.categoryName,
                    cat.categoryDescription
                );
            }
        }   // end of LoadArchivedCategoryData method

    }
}
