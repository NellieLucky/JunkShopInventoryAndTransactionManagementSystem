using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

/*

CREATE TABLE Employees (
    empId INT IDENTITY(1, 1) PRIMARY KEY,
    empName NVARCHAR(50) NULL,
    empPassword NVARCHAR(50) NOT NULL,
    empEmail NVARCHAR(50) NOT NULL,
    token NVARCHAR(50) NULL,
    empContact NVARCHAR(50) NULL,
    empAddress NVARCHAR(50) NULL,
    empRole NVARCHAR(50) NOT NULL DEFAULT('Employee'),
    empDateRegistered DATETIME NOT NULL DEFAULT(GETDATE()),
    IsRemoved BIT NOT NULL DEFAULT(0)
);

*/

namespace JunkShopInventoryandTransactionSystem.BackendFiles.Employee.Crud
{
    // constructor here


    // db connection here
    public abstract class BaseRepository
    {
        // Centralized connection string
        // remo string
        protected readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        //Arnel's connection string
        //protected readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        // Shared method to open a new connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    //crud starts here
    public class EmployeeRead : BaseRepository
    {
        // READ and get employee Id by using idk yet? // temporary email
        // used in transaction<buyer/seller>.cs
        public int? GetEmployeeIdByEmail(string empEmail)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                SELECT empId 
                FROM Employees 
                WHERE empEmail = @empEmail";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@empEmail", empEmail.Trim());

                    try
                    {
                        conn.Open();
                        object? result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int empId))
                        {
                            return empId;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("❌ Error fetching employee ID: " + ex.Message);
                        throw new Exception("Failed to retrieve employee ID.", ex);
                    }
                }
            }

            return null; // Employee not found
        }
    }
}
