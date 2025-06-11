using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.Data.SqlClient;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class ForgotPasswordPage : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Beetoy\source\repos\JunkShopInventoryandTransactionSystem\Users.mdf;Integrated Security=True";
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void GoBack_MouseEnter_1(object sender, EventArgs e)
        {
            GoBack.ForeColor = Color.FromArgb(13, 158, 169);
        }

        private void GoBack_MouseLeave_1(object sender, EventArgs e)
        {
            GoBack.ForeColor = Color.FromArgb(7, 96, 14);
        }

        private void GoBack_Click_1(object sender, EventArgs e)
        {
            LogInPage loginpage = new LogInPage();
            loginpage.Dock = DockStyle.Fill;
            loginpage.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(loginpage);
            loginpage.Show();
        }

        private bool IsEmailRegistered(string email)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                string query = @"SELECT TOP 1 empEmail FROM Employees WHERE empEmail = @Email";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
        }

        private void SendLinkButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Content.ToLower();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (IsEmailRegistered(email))
                {
                    string token = Guid.NewGuid().ToString();
                    StoreToken(email, token);

                    MailMessage mail = new MailMessage("junkshopinventorysystem@gmail.com", email);
                    mail.Subject = "Junk Shop Inventory and Transaction System: Password Reset Token";
                    mail.Body = $"Your password reset token is:\n\n{token}\n\nEnter this token while setting up your new password to reset your password.";

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("junkshopinventorysystem@gmail.com", "wazb rivy ncad fdxq"),
                        EnableSsl = true,
                    };
                    client.Send(mail);
                    MessageBox.Show("Password reset token has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    NewPasswordPage newPasswordPage = new NewPasswordPage();
                    newPasswordPage.Dock = DockStyle.Fill;
                    newPasswordPage.TopLevel = false;
                    MainForm.MainPanel.Controls.Clear();
                    MainForm.MainPanel.Controls.Add(newPasswordPage);
                    newPasswordPage.Show();
                }
                else
                {
                    MessageBox.Show("This email is not registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StoreToken(string email, string token)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string query = "UPDATE Employees SET token = @Token WHERE empEmail = @Email";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Token", token);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void EmailTextBox_ContentChanged(object sender, EventArgs e)
        {
        }
    }
}
