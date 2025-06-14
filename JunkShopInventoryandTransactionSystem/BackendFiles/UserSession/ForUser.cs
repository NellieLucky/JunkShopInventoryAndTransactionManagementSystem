using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace JunkShopInventoryandTransactionSystem.BackendFiles.UserSession
{
    internal class ForUser
    {
        //private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        //arnel's connstring
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        public static class UserSession
        {
            public static int UserId { get; set; }
        }
        public class UserDetails
        {
            public int UserId { get; set; }
            public string? Name { get; set; }
            public string? Contact { get; set; }
            public string? Address { get; set; }
            public string? Email { get; set; }
            public string? Role { get; set; }
            public DateTime DateRegistered { get; set; }
            public string? Password { get; set; }
        }
        
        //Funtion Used to insert employee data into the database (EmployeeManagementPage.cs)
        public static bool InsertEmployee(string email, string password, string address, string name, string contactNo)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // SQL query to insert data into the Employee table
                    string query = @"
                        INSERT INTO Employees (empEmail, empPassword, empAddress, empName, empContact)
                        VALUES (@Email, @Password, @Address, @Name, @ContactNo)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@ContactNo", contactNo);

                        // Execute the query and return whether the insertion was successful
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if a row was inserted
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; // Return false if there was an error
            }
        }

        //Funtion used to retrieve employee details based on email (AddEditEmployee.cs)
        public static bool SoftDeleteEmployee(string? email)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "UPDATE Employees SET IsRemoved = 1 WHERE empEmail = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error soft-deleting employee: " + ex.Message);
                return false;
            }
        }
    }
}
