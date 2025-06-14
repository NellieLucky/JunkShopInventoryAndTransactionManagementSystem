using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;

namespace JunkShopInventoryandTransactionSystem.View.UserInfo
{
    public partial class UserInformationPage : UserControl
    {
        //private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";
        
        //arnel's connstring
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        // To track if the user is editing or not
        private bool isEditing = false;

        int userId = UserSession.UserId;

        public UserInformationPage()
        {
            InitializeComponent();
            // Fetch user information based on userId
            var userInfo = GetUserInfo(userId);

            // Set textboxes to the values from the database
            cuiTextBox2.Content = userInfo.Name;    // Set Name to TextBox1
            cuiTextBox3.Content = userInfo.Contact; // Set Contact to TextBox2
            cuiTextBox4.Content = userInfo.Address; // Set Address to TextBox3

            label5.Text = userInfo.Role.ToUpper();            // Set Role to Label5
            label6.Text = userInfo.Name.ToUpper();            // Set Name in Label6

            label5.TextAlign = ContentAlignment.TopCenter; // Center the text in label5
            label6.TextAlign = ContentAlignment.TopCenter; // Center the text in label6

            label7.Text = userInfo.DateRegistered.ToString("MM/dd/yyyy");  // Set DateRegistered in label7

            // Set textboxes to disabled by default
            cuiTextBox2.Enabled = false;
            cuiTextBox3.Enabled = false;
            cuiTextBox4.Enabled = false;
        }
        private (string Name, string Role, string Contact, string Address, DateTime DateRegistered) GetUserInfo(int userId)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                // Query to fetch user info from Employees or Management based on UserId
                string query = @"
                    SELECT empName, 'Employee' AS Role, empContact, empAddress, empDateRegistered
                    FROM Employees WHERE empId = @UserId
                    UNION ALL
                    SELECT admName, 'Admin' AS Role, admContact, admAddress, admDateRegistered
                    FROM Management WHERE admId = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader.GetString(0);   // Name
                            string role = reader.GetString(1);   // Role
                            string contact = reader.GetString(2); // Contact
                            string address = reader.GetString(3); // Address
                            DateTime dateRegistered = reader.GetDateTime(4);

                            return (name, role, contact, address, dateRegistered);  // Return all details
                        }
                        else
                        {
                            return (string.Empty, string.Empty, string.Empty, string.Empty, DateTime.MinValue); // Return empty if no user found
                        }
                    }
                }
            }
        }
        private void cuiButton2_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Change button text to 'Edit' and disable textboxes
                cuiButton2.Content = "Edit";
                cuiTextBox2.Enabled = false;
                cuiTextBox3.Enabled = false;
                cuiTextBox4.Enabled = false;

                SaveUserInfo();
            }
            else
            {
                // Change button text to 'Save' and enable textboxes
                cuiButton2.Content = "Save";
                cuiTextBox2.Enabled = true;
                cuiTextBox3.Enabled = true;
                cuiTextBox4.Enabled = true;
            }

            // Toggle the editing mode flag
            isEditing = !isEditing;
        }

        private void SaveUserInfo()
        {
            UserDetails updatedUserInfo = new UserDetails
            {
                UserId = UserSession.UserId,
                Name = cuiTextBox2.Content,
                Contact = cuiTextBox3.Content,
                Address = cuiTextBox4.Content
            };

            bool success = UpdateUserInfoInDatabase(updatedUserInfo);

            if (success)
            {
                MessageBox.Show("User information updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update user information.");
            }
        }
        private bool UpdateUserInfoInDatabase(UserDetails userInfo)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                string query = @"
                    UPDATE Employees
                    SET empName = @Name, empContact = @Contact, empAddress = @Address
                    WHERE empId = @UserId;
                    UPDATE Management
                    SET admName = @Name, admContact = @Contact, admAddress = @Address
                    WHERE admId = @UserId;";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Name", userInfo.Name);
                    cmd.Parameters.AddWithValue("@Contact", userInfo.Contact);
                    cmd.Parameters.AddWithValue("@Address", userInfo.Address);
                    cmd.Parameters.AddWithValue("@UserId", userInfo.UserId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;  // Return true if rows were updated
                }
            }
        }

        private void cuiTextBox2_ContentChanged(object sender, EventArgs e)
        {
            label6.Text = cuiTextBox2.Content.ToUpper();
        }

        private void cuiTextBox3_ContentChanged(object sender, EventArgs e)
        {

        }

        private void cuiTextBox4_ContentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}