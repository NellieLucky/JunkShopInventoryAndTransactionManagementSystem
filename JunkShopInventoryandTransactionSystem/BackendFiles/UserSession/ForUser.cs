using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


/*

CREATE TABLE [dbo].[Employees] (
    [empId]             INT           IDENTITY (2, 1) NOT NULL,
    [empName]           NVARCHAR (50) NULL,
    [empPassword]       NVARCHAR (70) NOT NULL,
    [empEmail]          NVARCHAR (50) NOT NULL,
    [token]             NVARCHAR (50) NULL,
    [empContact]        NVARCHAR (50) NULL,
    [empAddress]        NVARCHAR (50) NULL,
    [empRole]           NVARCHAR (50) NOT NULL,
    [empDateRegistered] DATETIME      DEFAULT (getdate()) NOT NULL,
    [IsRemoved]         BIT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([empId] ASC)
);

*/

namespace JunkShopInventoryandTransactionSystem.BackendFiles.UserSession
{
    internal class ForUser
    {
        //Abalos' connection string
        //private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        //arnel's connstring
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //remo string just added static to my string
        //private static readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        //private static readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //Sandara's connection string
        //private static readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sandara Fillartos\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf"";Integrated Security = True";

        //nicole's connection string
        //private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //Ethan's connection string
        //private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //Sandara's connection string
        //private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sandara Fillartos\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf"";Integrated Security=True";

        public static class UserSession
        {
            public static int UserId { get; set; }
        }

        //Class to hold user details(UserInformationPage.cs)
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

        //Function to update information of employee in edit mode(AddEditEmployee.cs)
        public static bool UpdateEmployee(string email, string name, string contact, string address, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Employees
                               SET empName = @name, empContact = @contact, empAddress = @address, empPassword = @Password
                               WHERE empEmail = @originalEmail AND empId > 1 AND IsRemoved = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@originalEmail", email);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        //Funtion Used to insert employee data into the database (AddEditEmployee.cs)
        public static bool InsertEmployee(string email, string password, string address, string name, string contactNo)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // SQL query to insert data into the Employee table
                    string query = @"
                                INSERT INTO Employees (empEmail, empPassword, empAddress, empName, empContact, empRole)
                                VALUES (@Email, @Password, @Address, @Name, @ContactNo, @Role)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                        cmd.Parameters.AddWithValue("@Role", "Employee");

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

        //Function for DataGrid Information into columns(EmployeeManagementPage).
        public static DataTable GetAllEmployees()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    
                    string query = "SELECT empId, empDateRegistered, empEmail, empPassword, empName, empContact, empAddress FROM Employees WHERE IsRemoved = 0 AND empId > 1";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        //Funtion used to soft-delete users from Admin view(EmployeeManagementPage.cs)
        public static bool SoftDeleteEmployee(string? email)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "UPDATE Employees SET IsRemoved = 1 WHERE empEmail = @Email AND empId > 1";

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

        //Function to retrieve whether the Management table is empty or not (MainForm.cs)
        public static bool IsManagementTableEmpty()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Employees WHERE empId = 1 OR empRole = 'Admin'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int count = (int)command.ExecuteScalar();
                        return count == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false if there's an error
            }
        }

        // Function to get user information (name and role) based on userId (MainNavigationPage.cs)
        public static (string Name, string Role) GetUserInfo(int userId)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Query to fetch employee or admin name and role based on userId
                    string query = @"SELECT empName, empRole FROM Employees WHERE empId = @UserId";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader.GetString(0);  // First column: Name
                                string role = reader.GetString(1);  // Second column: Role
                                return (name, role);  // Return both name and role
                            }
                            else
                            {
                                return (string.Empty, string.Empty); // Return empty if no user found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (string.Empty, string.Empty);
            }
        }

        //Function to get user details based on userId(UserInfromationPage.cs)
        public static UserDetails GetDetailedUserInfo(int userId)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string query = @"
                            SELECT empEmail, empName, empRole, empContact, empAddress, empDateRegistered
                            FROM Employees 
                            WHERE empId = @UserId";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserDetails
                                {
                                    Email = reader.GetString(0),
                                    Name = reader.GetString(1),
                                    Role = reader.GetString(2),
                                    Contact = reader.GetString(3),
                                    Address = reader.GetString(4),
                                    DateRegistered = reader.GetDateTime(5),
                                    UserId = userId
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new UserDetails();  // default/fallback
        }

        //Function to update user information in the database(UserInformationPage.cs)
        public static bool UpdateUserInfoInDatabase(UserDetails userInfo)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = @"
                            UPDATE Employees
                            SET empEmail = @Email, empName = @Name, empContact = @Contact, empAddress = @Address
                            WHERE empId = @UserId";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", userInfo.Email);
                        cmd.Parameters.AddWithValue("@Name", userInfo.Name);
                        cmd.Parameters.AddWithValue("@Contact", userInfo.Contact);
                        cmd.Parameters.AddWithValue("@Address", userInfo.Address);
                        cmd.Parameters.AddWithValue("@UserId", userInfo.UserId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Function to sign up a admin(AdminSignUpPage.cs)
        public static bool RegisterAdmin(string email, string password, string name, string contact, string address, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "Invalid email format. Please enter a valid email (e.g., name@example.com).";
                return false;
            }
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Check if email already exists
                    string selectQuery = "SELECT COUNT(*) FROM Employees WHERE empEmail = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(selectQuery, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            errorMessage = "Email already exists. Please use a different email.";
                            return false;
                        }
                    }

                    // Enable IDENTITY_INSERT ON to manually insert empId = 1
                    using (SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Employees ON", connect))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Hash the password
                    string hashedPassword = HashPassword(password);

                    // Insert new admin
                    string insertQuery = @"
                            INSERT INTO Employees (empId, empEmail, empPassword, empName, empContact, empAddress, empRole)
                            VALUES (1, @Email, @Password, @Name, @Contact, @Address, @Role)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connect))
                    {
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@Password", hashedPassword);
                        insertCmd.Parameters.AddWithValue("@Name", name);
                        insertCmd.Parameters.AddWithValue("@Contact", contact);
                        insertCmd.Parameters.AddWithValue("@Address", address);
                        insertCmd.Parameters.AddWithValue("@Role", "Admin");
                        insertCmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Employees OFF", connect))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "SQL Error: " + ex.Message;
                return false;
            }
        }

        //Function to check if the user exists in employees Table(LogInPage.cs)
        public static int? AuthenticateEmployee(string email, string password)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT empId FROM Employees WHERE empEmail = @Email AND empPassword = @Password AND empId > 1";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                return reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return null;
        }
        //Function to check if the user exists in Management Tables(LogInPage.cs)
        public static int? AuthenticateAdmin(string email, string password)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT empId, empPassword FROM Employees WHERE empEmail = @Email AND empRole = 'Admin'";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {   //Get the stored hashed password from the database
                                string storedHash = reader.GetString(1);

                                //Verify the entered password against the stored hash using bcrypt
                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    //Password matches, return the empId of the admin
                                    return reader.GetInt32(0);
                                }
                                else
                                {
                                    //Password doesn't match, return null
                                    return null;
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return null;
        }

        //Function to check if the email is registered in either Employees or Management Tables(ForgotPasswordPage.cs)
        public static bool IsEmailRegistered(string email)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string query = "SELECT TOP 1 empEmail FROM Employees WHERE empEmail = @Email AND empId = 1";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    return cmd.ExecuteScalar() != null;
                }
            }
        }

        //Function to update the password and token to be used in the database(NewPasswordPage.cs)
        public static void StoreToken(string email, string token)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string employeeCheck = "SELECT COUNT(*) FROM Employees WHERE empEmail = @Email AND empId = 1";
                using (SqlCommand checkCmd = new SqlCommand(employeeCheck, connect))
                {
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        string updateEmp = "UPDATE Employees SET token = @Token WHERE empEmail = @Email AND empId = 1";
                        using (SqlCommand cmd = new SqlCommand(updateEmp, connect))
                        {
                            cmd.Parameters.AddWithValue("@Token", token);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.ExecuteNonQuery();
                            return;
                        }
                    }
                }
            }
        }

        //Function to verify where the token is valid and retrieve the email associated with it (NewPasswordPage.cs)
        public static string? GetEmailByToken(string token, out string userType)
        {
            userType = null;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string query = "SELECT empEmail FROM Employees WHERE token = @Token AND empId = 1";
                using (SqlCommand empCmd = new SqlCommand(query, connect))
                {
                    empCmd.Parameters.AddWithValue("@Token", token);
                    object result = empCmd.ExecuteScalar();

                    if (result != null)
                    {
                        userType = "Admin";
                        return result.ToString();
                    }
                }
                return null;
            }
        }

        //Function to update the password in the database if the token is valid (NewPasswordPage.cs)
        public static bool UpdatePassword(string email, string newPassword, string userType)
        {
            try
            {
                //Hashing the new password using bcrypt before storing it in the database
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword, workFactor: 12);

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string updateQuery = "UPDATE Employees SET empPassword = @Password, token = NULL WHERE empEmail = @Email";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Email", email);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Optionally log the exception or handle it based on your app's requirements
                throw new Exception("Error updating password: " + ex.Message);
            }
        }

        // Helper method to hash the password using bcrypt
        private static string HashPassword(string password)
        {
            // Hash the password using bcrypt and a default work factor (12 rounds)
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12);
            return hashedPassword;
        }
    }
}
