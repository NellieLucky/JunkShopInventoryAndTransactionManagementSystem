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
        private readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkshopDB.mdf;Integrated Security = True";

        private static int attemptCount = 0; // Track the number of attempts

        public NewPasswordPage()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            attemptCount = 0;
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

                string query = @"SELECT TOP 1 empEmail FROM Employees WHERE token = @Token";
                string? email = null;

                using (SqlCommand selectCmd = new SqlCommand(query, connect))
                {
                    selectCmd.Parameters.AddWithValue("@Token", token);

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            email = reader["empEmail"].ToString();
                        }
                    }
                }

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Invalid or expired token. Please request a new password reset.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string update = "UPDATE Employees SET empPassword = @Password, token = NULL WHERE empEmail = @Email";
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
