
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// imports crud of ITEM and CATEGORY
// since i needed to DELETE the items that used the archived category that were gonna DELETE here
using JunkShopInventoryandTransactionSystem.BackendFiles.Inventory.Crud;
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Delete
{
    public class DeleteCategory
    {
        public static bool HandleDeleteCategory(
            int categoryId,
            DataGridView targetDataGridView
            )
        {
            // delete the items first before the actual category deletion
            InventoryDelete deleteItems = new InventoryDelete();
            deleteItems.DeleteItemsByCategory(categoryId);

            // proceed with DELETING the CATEGORY ---
            CategoryDelete delete = new CategoryDelete();
            delete.DeleteCategory(categoryId);

            //MessageBox.Show("Category deleted successfully!", "Category Deleting Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reload cat dashboard here
            if (targetDataGridView != null)
            {
                Reload.ReloadCategory.LoadArchivedCategoryData(targetDataGridView);
            }

            return true; // Indicate that the operation was successful

        }
    }
}
