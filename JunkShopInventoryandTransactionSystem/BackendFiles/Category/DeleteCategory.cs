using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// imports crud
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Delete
{
    public class DeleteCategory
    {
        public static bool HandleDeleteCategory(
            int catId, // category id to be deleted
            DataGridView targetDataGridView
            )
        {
            //validation of values

            // --- If validation passes, proceed with adding the item ---
            CategoryItem newCat = new CategoryItem("Metal", "Scrap metal category");

            CategoryDelete delete = new CategoryDelete();
            delete.DeleteCategory(catId);

            MessageBox.Show("Category edited successfully!", "Category Editing Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*
            // reload cat dashboard here
            if ( cat grid view != null )
            {
                //namespace.class.method since theyre both on the same folder
                //Reload.ReloadInventory.LoadInventoryData(targetDataGridView);
                //<skip namespace>.class.method if not on the same folder
            }
            */

            return true; // Indicate that the operation was successful

        }
    }
}
