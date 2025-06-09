using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace JunkShopInventoryandTransactionSystem.Backend_Files.SQL
{
    public class MSql_Calls
    {
        // This class is intended to handle all SQL calls related to the Junk Shop Inventory and Transaction System.
        // It will include methods for connecting to the database, executing queries, and handling results.
        // Example method for connecting to the database

        public void InitializeTables()
        {
            //initialize database
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Trust Server Certificate=True");

            // for employees table only
            // Table creation query for employees only
            string createTableQuery = @"
            IF NOT EXISTS (
                SELECT * FROM sys.tables WHERE name = 'Employees'
            )
            BEGIN
                CREATE TABLE Employees (
                    empId INT IDENTITY(1,1) PRIMARY KEY,
                    empName NVARCHAR(50),
                    empUsername NVARCHAR(50) NOT NULL,
                    empPassword NVARCHAR(50) NOT NULL,
                    empPosition INT CHECK (empPosition BETWEEN 0 AND 9),
                    empEmail NVARCHAR(50)
                );
            END";

            // emp position is " zero " if non admin, " one " if admin 
            // between zero to nine is checker to not exceed

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(createTableQuery, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("✅ Employees table created or already exists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error creating table: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            // for employees table only

            // for other tables only
            // for other tables only

        }

        public void ConnectToEmployeeTable()
        {
            // Implementation for connecting to the 
            string connectionString = "Data Source=LAPTOP-M4LNTBNL\\SQLEXPRESS;Initial Catalog=Employees;User ID=yourUsername;Password=yourPassword;TrustServerCertificate=True;";

            //checks if properly connected to the test database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //opens the database
                    connection.Open();
                    Console.WriteLine("✅ Connection successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Connection failed: " + ex.Message);
                }
            }
        }

        // Example method for executing a query
        public class Employee
        {
            public int empId { get; set; }   // PK
            public string empUsername { get; set; }
            public string empEmail { get; set; }
            public string empPassword { get; set; }
            public int empPosition { get; set; }
        }

        public List<Employee> GetAllEmployees()
        {
            // Connection string to your SQL Server database
            string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Trust Server Certificate=True";

            List<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL query to fetch all employees
                string query = "SELECT * FROM Employees";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Read each row from the result
                    while (reader.Read())
                    {
                        Employee emp = new Employee
                        {
                            empId = Convert.ToInt32(reader["empId"]),
                            empUsername = reader["empUsername"].ToString(),
                            empEmail = reader["empEmail"].ToString(),
                            empPassword = reader["empPassword"].ToString(),
                            empPosition = Convert.ToInt32(reader["empPosition"])
                            // empId not set here — you can include it if the column exists
                        };

                        employees.Add(emp);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error fetching data: " + ex.Message);
                }
            }

            return employees;
        }

    }   //end of class
}
