
// imports crud
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;
using JunkShopInventoryandTransactionSystem.View.Inventory_Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Add
{
    public class AddToCategory
    {
        public static bool HandleAddCategory(
            string categoryNameContent,
            string categoryDescriptionContent,
            DataGridView targetDataGridView
            )
        {
            //validation of values
            string categoryName = categoryNameContent.Trim();
            string categoryDescription = categoryDescriptionContent.Trim();

            // --- Validation ---
            bool isValidInput = true;
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                errorMessage += "Category Name cannot be empty.\n";
                isValidInput = false;
            }
            if (string.IsNullOrWhiteSpace(categoryDescription))
            {
                errorMessage += "Category Description cannot be empty.\n";
                isValidInput = false;
            }

            if (!isValidInput)
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // --- If validation passes, proceed with adding the item ---
            CategoryItem newCat = new CategoryItem(
                categoryName,
                categoryDescription
            );

            CategoryAdd add = new CategoryAdd();
            add.AddCategory(newCat);

            //MessageBox.Show("Category added successfully!", "Category Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reload cat dashboard here
            if ( targetDataGridView != null )
            {
                Reload.ReloadCategory.LoadCategoryData(targetDataGridView);
            }

            return true; // Indicate that the operation was successful
            
        }
    }
}
