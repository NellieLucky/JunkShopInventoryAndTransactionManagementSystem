using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

/*  CODE FOR TABLE CREATION

-- TABLE CREATION
CREATE TABLE Category (
    categoryId INT IDENTITY(1,1) PRIMARY KEY,
    categoryName VARCHAR(50) NOT NULL,
    categoryDescription NVARCHAR(250) NULL,
    isArchived BIT NOT NULL DEFAULT 0  -- Soft delete flag
);

SELECT * FROM Category
*/

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud
{
    // THIS ISNT OPTIMIZED YET
    // Represents a category row in the database
    public class CategoryItem
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; } = string.Empty;
        // initialized to empty string to avoid null reference issues since this can be NULL
        public string? categoryDescription { get; set; }
        // Soft delete flag to indicate if the category is archived
        public bool isArchived { get; set; } = false;

        public CategoryItem() { }

        public CategoryItem(string name, string description, bool archived = false)
        {
            categoryName = name;
            categoryDescription = description;
            isArchived = archived;
        }

        public CategoryItem(int id, string name, string description, bool archived = false)
        {
            categoryId = id;
            categoryName = name;
            categoryDescription = description;
            isArchived = archived;
        }
    } // constructors or something idk

    // INPUT STRING HERE FOR LOCAL DB CONNECTION
    public abstract class BaseRepository
    {
        // Centralized connection string
        // remo string
        //protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //Arnel's connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        //Dara's connection string
        protected readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sandara Fillartos\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf"";Integrated Security = True";

        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    // Class for reading category data
    public class CategoryRead : BaseRepository
    {
        // get all unarchived categories
        public List<CategoryItem> GetAllCategories()
        {
            List<CategoryItem> categories = new List<CategoryItem>();

            using ( SqlConnection conn = GetConnection() )
            {
                string query = @"SELECT categoryId, categoryName, categoryDescription, isArchived 
                                 FROM Category 
                                 WHERE isArchived = 0";  // Only non-archived

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CategoryItem category = new CategoryItem
                                {
                                    categoryId = Convert.ToInt32(reader["categoryId"]),
                                    categoryName = reader["categoryName"].ToString() ?? string.Empty,
                                    categoryDescription = reader["categoryDescription"]?.ToString() ?? string.Empty,
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };
                                categories.Add(category);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading Category table: " + ex.Message);
                        throw new Exception("Failed to retrieve category data.", ex);
                    }
                }
            }

            return categories;
        } // end of get all cats

        // get all archived categories
        public List<CategoryItem> GetAllArchivedCategories()
        {
            List<CategoryItem> categories = new List<CategoryItem>();

            using (SqlConnection conn = GetConnection())
            {
                string query = @"SELECT categoryId, categoryName, categoryDescription, isArchived 
                                 FROM Category 
                                 WHERE isArchived = 1";  // Archived only

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CategoryItem category = new CategoryItem
                                {
                                    categoryId = Convert.ToInt32(reader["categoryId"]),
                                    categoryName = reader["categoryName"]?.ToString() ?? string.Empty,
                                    categoryDescription = reader["categoryDescription"]?.ToString() ?? string.Empty,
                                    isArchived = Convert.ToBoolean(reader["isArchived"])
                                };
                                categories.Add(category);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading archived Category data: " + ex.Message);
                        throw new Exception("Failed to retrieve archived categories.", ex);
                    }
                }
            }

            return categories;
        }   // end of get all archived cats

        public CategoryItem? GetOneCategory(int categoryId)
        {
            CategoryItem? category = null;

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT categoryId, categoryName, categoryDescription FROM Category WHERE categoryId = @categoryId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                category = new CategoryItem
                                {
                                    categoryId = Convert.ToInt32(reader["categoryId"]),
                                    categoryName = reader["categoryName"].ToString() ?? string.Empty,
                                    categoryDescription = reader["categoryDescription"]?.ToString() ?? string.Empty
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading single Category: " + ex.Message);
                        throw;
                    }
                }
            }

            return category;
        } // end of get one cat

        /*
        // get cat by catname // used for add / edit items in inventory
        public int? GetCategoryIdByName(string categoryName)
        {
            int? categoryId = null;

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT categoryId FROM Category WHERE categoryName = @categoryName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryName", categoryName);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                categoryId = Convert.ToInt32(reader["categoryId"]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error fetching categoryId by name: " + ex.Message);
                        throw;
                    }
                }
            }

            return categoryId;
        }   // 
        */

    } // end of cat reads //all n one

    // Class for adding new category
    public class CategoryAdd : BaseRepository
    {
        public void AddCategory(CategoryItem category)
        {
            string query = "INSERT INTO Category (categoryName, categoryDescription) VALUES (@categoryName, @categoryDescription)";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryName", category.categoryName);
                    cmd.Parameters.AddWithValue("@categoryDescription", category.categoryDescription);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error during AddCategory: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

    } // end of cat add

    // Class for updating existing category
    public class CategoryEdit : BaseRepository
    {
        public void EditCategory(CategoryItem category)
        {
            string query = @"
                UPDATE Category SET
                    categoryName = @categoryName,
                    categoryDescription = @categoryDescription
                WHERE categoryId = @categoryId;
            ";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", category.categoryId);
                    cmd.Parameters.AddWithValue("@categoryName", category.categoryName);
                    cmd.Parameters.AddWithValue("@categoryDescription", category.categoryDescription);

                    // debugging
                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error during UpdateItemInInventory: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("An error occurred while updating the item in the database.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }   // end of second using
            }   // end of the first using
        }   // end of method EditCategory
    } // end of cat edit

    // soft delete category class
    public class CategorySoftDelete : BaseRepository
    {
        public void SoftDeleteCategory(int categoryId)
        {
            string query = "UPDATE Category SET isArchived = 1 WHERE categoryId = @categoryId";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            $"{rowsAffected} category marked as archived.",
                            "Soft Delete Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during SoftDeleteCategory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while archiving the category in the database.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        }
    }   // end of soft delete category

    // unarchiving it back
    public class CategoryRestore : BaseRepository
    {
        public void RestoreCategory(int categoryId)
        {
            string query = "UPDATE Category SET isArchived = 0 WHERE categoryId = @categoryId;";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            $"{rowsAffected} category(ies) restored from archive.",
                            "Restore Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during RestoreCategory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while restoring the category.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        }
    }   // unarchiving it back

    // Class for deleting category
    public class CategoryDelete : BaseRepository
    {

        public void DeleteCategory(int categoryId)
        {
            string query = "DELETE FROM Category WHERE categoryId = @categoryId";

            using ( SqlConnection conn = GetConnection() )
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Inform the user via MessageBox
                        MessageBox.Show(
                            $"{rowsAffected} row(s) deleted successfully.",
                            "Deletion Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(
                            "Database error during DeleteCategory:\n" + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw new Exception("An error occurred while deleting the category from the database.", ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "An unexpected error occurred:\n" + ex.Message,
                            "Unexpected Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        throw;
                    }
                }
            }
        }

    }// end of cat delete
}
