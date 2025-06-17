using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

/*  CODE FOR TABLE CREATION

CREATE TABLE Category (
    categoryId INT IDENTITY(1,1) PRIMARY KEY,
    categoryName VARCHAR(50) NOT NULL,
    categoryDescription NVARCHAR(250) NULL
);
-- AFTER TABLE CREATION, REFRESH DATA CONNECTIONS HERE IN VISUAL STUDIO AND CONNECT THE DB

-- Example of inserting a row into the Category table
-- <TEXT> = put any TEXT VALUE you want here , DO NOT FORGET TO ENCLOSE THEM IN SINGLE QUOTES

INSERT INTO Category (categoryName, categoryDescription)
VALUES ('<TEXT>', '<TEXT>');

-- to view datas directly on MS SQL SERVER 
SELECT * FROM Category
*/

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Category.Crud
{
    // Represents a category row in the database
    public class CategoryItem
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; } = string.Empty;
        public string? categoryDescription { get; set; }

        public CategoryItem() { }

        public CategoryItem(string name, string description)
        {
            categoryName = name;
            categoryDescription = description;
        }

        public CategoryItem(int id, string name, string description)
        {
            categoryId = id;
            categoryName = name;
            categoryDescription = description;
        }
    } // constructors or something idk

    // Class for reading category data
    public class CategoryRead
    {
        //private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //Arnel's connection string
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public List<CategoryItem> GetAllCategories()
        {
            List<CategoryItem> categories = new List<CategoryItem>();

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT categoryId, categoryName, categoryDescription FROM Category";
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
                                    categoryDescription = reader["categoryDescription"]?.ToString() ?? string.Empty
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

    } // end of cat reads //all n one

    // Class for adding new category
    public class CategoryAdd
    {
        //private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //Arnel's connection string
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void AddCategory(CategoryItem category)
        {
            string query = "INSERT INTO Category (categoryName, categoryDescription) VALUES (@categoryName, @categoryDescription)";

            using (SqlConnection conn = GetConnection())
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
    public class CategoryEdit
    {
        //private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //Arnel's connection string
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void EditCategory(CategoryItem category)
        {
            string query = @"
                UPDATE Category SET
                    categoryName = @categoryName,
                    categoryDescription = @categoryDescription
                WHERE categoryId = @categoryId;
            ";

            using (SqlConnection conn = GetConnection())
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

    // Class for deleting category
    public class CategoryDelete
    {
        //private string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //Arnel's connection string
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void DeleteCategory(int categoryId)
        {
            string query = "DELETE FROM Category WHERE categoryId = @categoryId";

            using (SqlConnection conn = GetConnection())
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
