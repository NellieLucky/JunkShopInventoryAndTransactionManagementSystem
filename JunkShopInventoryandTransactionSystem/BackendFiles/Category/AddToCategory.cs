
// imports crud
using JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud;

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

            //validation for to see if same cat name
            CategoryRead categoryReader = new CategoryRead();
            var allCategories = categoryReader.GetAllCategories();

            // Look for duplicate names (case-insensitive and trimmed)
            bool isDuplicateCategory = allCategories.Any(c =>
                string.Equals(c.categoryName.Trim(), categoryName, StringComparison.OrdinalIgnoreCase)
            );

            if (isDuplicateCategory)
            {
                errorMessage += "A category with the same name already exists.\n";
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
            // END OF VALIDATIONS

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
