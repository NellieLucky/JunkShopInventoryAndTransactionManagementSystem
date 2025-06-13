using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class NewPasswordPage : Form
    {
        //private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\source\repos\JunkShopInventoryandTransactionSystem\Users.mdf;Integrated Security=True";
        //arnel's connstring

        //private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShop.mdf;Integrated Security=True";

        //remo string
        private readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public NewPasswordPage()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
        private void UpdatePass_Button_Click(object sender, EventArgs e)
        {
            string token = VerifyTokenTextBox.Content.Trim();
            string newPassword = PasswordTextBox.Content.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Content.Trim();

            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string? email = null;
                string? userType = null; // "Employee" or "Admin"

                // Check Employees table
                string empQuery = @"SELECT TOP 1 empEmail FROM Employees WHERE token = @Token";
                using (SqlCommand empCmd = new SqlCommand(empQuery, connect))
                {
                    empCmd.Parameters.AddWithValue("@Token", token);
                    using (SqlDataReader reader = empCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            email = reader["empEmail"].ToString();
                            userType = "Employee";
                        }
                    }
                }

                // If not found in Employees, check Management
                if (string.IsNullOrEmpty(email))
                {
                    string admQuery = @"SELECT TOP 1 admEmail FROM Management WHERE admToken = @Token";
                    using (SqlCommand admCmd = new SqlCommand(admQuery, connect))
                    {
                        admCmd.Parameters.AddWithValue("@Token", token);
                        using (SqlDataReader reader = admCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                email = reader["admEmail"].ToString();
                                userType = "Admin";
                            }
                        }
                    }
                }

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Invalid or expired token. Please request a new password reset.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the appropriate table
                string update = userType == "Employee"
                    ? "UPDATE Employees SET empPassword = @Password, token = NULL WHERE empEmail = @Email"
                    : "UPDATE Management SET admPassword = @Password, admToken = NULL WHERE admEmail = @Email";

                using (SqlCommand cmd = new SqlCommand(update, connect))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogInPage loginpage = new LogInPage();
                loginpage.Dock = DockStyle.Fill;
                loginpage.TopLevel = false;
                MainForm.MainPanel.Controls.Clear();
                MainForm.MainPanel.Controls.Add(loginpage);
                loginpage.Show();
            }
        }

        private void VerifyTokenTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
