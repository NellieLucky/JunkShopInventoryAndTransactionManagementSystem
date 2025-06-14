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

namespace JunkShopInventoryandTransactionSystem.View.LogInAuthFolder
{
    public partial class AdminSignUpPage : Form
    {
        //Connection string to connect to the local SQL Server database
        //private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\Database1.mdf;Integrated Security=True";

        //arnel's connstring
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Source\Repos\JunkShopInventoryAndTransactionManagementSystem\JunkShopInventoryandTransactionSystem\JunkShopDB.mdf;Integrated Security=True";

        //remo string
        //private readonly string connectionString = @"Data Source=LAPTOP-M4LNTBNL\SQLEXPRESS;Initial Catalog=Junkshop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public AdminSignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            string email = EmailTextBox.Content;
            string password = PasswordTextBox.Content;
            string confirmPassword = ConfirmPasswordTextBox.Content;
            string name = NameTextBox.Content;
            string contact = ContactNumberTextBox.Content;
            string address = AddressTextBox.Content;

            // Autogenerate admin position

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrWhiteSpace(contact) ||
                string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if contact number contains only digits
            if (!contact.All(char.IsDigit))
            {
                MessageBox.Show("Contact number must contain only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if email looks valid (very basic check)
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string selectquery = "SELECT TOP 1 admEmail FROM Management WHERE admEmail = @Email";
                    using (SqlCommand cmd = new SqlCommand(selectquery, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        //if result is null, it returns 0
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    string insertquery = "INSERT INTO Management (admEmail, admPassword, admName, admContact, admAddress, admPosition) VALUES (@Email, @Password, @Name, @Contact, @Address, @Position)";
                    using (SqlCommand cmd = new SqlCommand(insertquery, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Contact", contact);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Position", 1); // Autogenerate admin position
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally: redirect to login page
                LogInPage loginPage = new LogInPage();
                loginPage.Dock = DockStyle.Fill;
                loginPage.TopLevel = false;
                MainForm.MainPanel.Controls.Clear();
                MainForm.MainPanel.Controls.Add(loginPage);
                loginPage.Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while signing up. Please try again later.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void ContactNumberTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_ContentChanged(object sender, EventArgs e)
        {

        }
        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
