//remo authentication backend test

// 6/6/25 4:50pm //my laptop time is advanced a bit, idk like 3mnts ig
/*
recallable ms sql calls test
yea it isnt working on me, idk why yet
*/

using System;
using System.Data.SqlClient;

class MSql_call //renamed class
{
    static void Main()
    {
        string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=authTest;Integrated Security=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("✅ Connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Connection failed: " + ex.Message);
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}