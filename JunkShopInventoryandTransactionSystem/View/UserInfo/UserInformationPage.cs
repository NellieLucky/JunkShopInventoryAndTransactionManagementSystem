using CuoreUI.Controls;
using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JunkShopInventoryandTransactionSystem.View.UserInfo
{
    public partial class UserInformationPage : UserControl
    {
        // Add event for user info updates
        public event EventHandler<string>? UserInfoUpdated;

        // To track if the user is editing or not
        private bool isEditing = false;

        

        int userId = UserSession.UserId;

        public UserInformationPage()
        {
            InitializeComponent();
            // Fetch user information based on userId
            var userInfo = GetDetailedUserInfo(userId);

            // Set textboxes to the values from the database
            cuiTextBox1.Content = userInfo.Email;   // Set email to TextBox1
            cuiTextBox2.Content = userInfo.Name;    // Set Name to TextBox2
            cuiTextBox3.Content = userInfo.Contact; // Set Contact to TextBox3
            cuiTextBox4.Content = userInfo.Address; // Set Address to TextBox4

            label5.Text = userInfo.Role.ToUpper(); // Set Role to Label5
            label6.Text = userInfo.Name.ToUpper(); // Set Name in Label6

            label5.TextAlign = ContentAlignment.TopCenter; // Center the text in label5
            label6.TextAlign = ContentAlignment.TopCenter; // Center the text in label6

            label7.Text = userInfo.DateRegistered.ToString("MM/dd/yyyy");  // Set DateRegistered in label7

            // Set textboxes to disabled by default
            cuiTextBox1.Enabled = false;
            cuiTextBox2.Enabled = false;
            cuiTextBox3.Enabled = false;
            cuiTextBox4.Enabled = false;

            if (userInfo.Role.Equals("Employee", StringComparison.OrdinalIgnoreCase))
            {
                cuiTextBox1.Visible = false;
                label8.Visible = false; // if label1 is the label for Email
            }
        }
        private void cuiButton2_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Change button text to 'Edit' and disable textboxes
                cuiButton2.Content = "Edit";
                cuiTextBox1.Enabled = false;
                cuiTextBox2.Enabled = false;
                cuiTextBox3.Enabled = false;
                cuiTextBox4.Enabled = false;

                SaveUserInfo();
            }
            else
            {
                // Change button text to 'Save' and enable textboxes
                cuiButton2.Content = "Save";
                cuiTextBox1.Enabled = true;
                cuiTextBox2.Enabled = true;
                cuiTextBox3.Enabled = true;
                cuiTextBox4.Enabled = true;
            }

            // Toggle the editing mode flag
            isEditing = !isEditing;
        }

        private void SaveUserInfo()
        {
            string email = cuiTextBox1.Content?.Trim();

            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address (e.g., user@example.com).", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserDetails updatedUserInfo = new UserDetails
            {
                UserId = UserSession.UserId,
                Email = cuiTextBox1.Content,
                Name = cuiTextBox2.Content,
                Contact = cuiTextBox3.Content,
                Address = cuiTextBox4.Content
            };

            bool success = ForUser.UpdateUserInfoInDatabase(updatedUserInfo);

            if (success)
            {
                MessageBox.Show("User information updated successfully!");

                // Trigger the event with the updated name
                UserInfoUpdated?.Invoke(this, cuiTextBox2.Content);
        }
            else
            {
                MessageBox.Show("Failed to update user information.");
            }
        }

        private void cuiTextBox2_ContentChanged(object sender, EventArgs e)
        {
            label6.Text = cuiTextBox2.Content.ToUpper();
        }

    }
}