using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
using JunkShopInventoryandTransactionSystem.View.LogInAuthFolder;
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

namespace JunkShopInventoryandTransactionSystem.View.LogInAuthFolder
{
    public partial class NewPasswordPage : Form
    {

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

            string userType;
            string? email = ForUser.GetEmailByToken(token, out userType);
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Invalid or expired token. Please request a new password reset.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = ForUser.UpdatePassword(email, newPassword, userType);
            if (success)
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogInPage loginpage = new LogInPage();
                loginpage.Dock = DockStyle.Fill;
                loginpage.TopLevel = false;
                MainForm.MainPanel.Controls.Clear();
                MainForm.MainPanel.Controls.Add(loginpage);
                loginpage.Show();
            }
            else
            {
                MessageBox.Show("An error occurred while updating the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
