using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JunkShopInventoryandTransactionSystem.View.LogInAuthFolder
{
    public partial class ForgotPasswordPage : Form
    {
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
        private void SendLinkButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Content.Trim().ToLower();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var validEmail = new MailAddress(email);

                if (ForUser.IsEmailRegistered(email))
                {
                    string token = new Random().Next(100000, 1000000).ToString();
                    ForUser.StoreToken(email, token);

                    MailMessage mail = new MailMessage("junkshopinventorysystem@gmail.com", email);
                    mail.Subject = "Junk Shop Inventory and Transaction System: Password Reset Token";
                    mail.Body = $"Your password reset token is:\n\n{token}\n\nEnter this token while setting up your new password to reset your password.";

                    SmtpClient client = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        Credentials = new NetworkCredential("junkshopinventorysystem@gmail.com", "xsec ztzz gkcq sytw"),
                        EnableSsl = true,
                        UseDefaultCredentials = false
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
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"SMTP Error: {smtpEx.StatusCode} - {smtpEx.Message}", "SMTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.GetType().Name} - {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EmailTextBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
