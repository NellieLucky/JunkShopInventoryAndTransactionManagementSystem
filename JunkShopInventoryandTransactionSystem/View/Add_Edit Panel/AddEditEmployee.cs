using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;
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
using static JunkShopInventoryandTransactionSystem.BackendFiles.UserSession.ForUser;

namespace JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel
{
    public partial class AddEditEmployee : Form
    {

        public event EventHandler EmployeeAdded;

        private readonly bool isEditMode;
        private readonly string originalEmail;

        public AddEditEmployee()
        {
            InitializeComponent();
            isEditMode = false;
        }

        public AddEditEmployee(string name, string email, string contact, string password, string address, string dateRegistered = "")
        {
            InitializeComponent();
            isEditMode = true;
            originalEmail = email;

            // Populate the fields
            NameTextBox.Content = name;
            EmailAccTextBox.Content = email;
            ContactNoTextBox.Content = contact;
            PaaswordTextBox.Content = password;
            AddressTextBox.Content = address;
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            string email = EmailAccTextBox.Content;
            string password = PaaswordTextBox.Content;
            string address = AddressTextBox.Content;
            string name = NameTextBox.Content;
            string contactNo = ContactNoTextBox.Content;

            if (string.IsNullOrEmpty(email) || 
                string.IsNullOrEmpty(name) || 
                string.IsNullOrEmpty(contactNo) || 
                string.IsNullOrEmpty(address) || 
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            bool success;
            if (isEditMode)
            {
                // Function call to update method
                success = ForUser.UpdateEmployee(originalEmail, name, contactNo, address, password);
                if (success)
                {
                    MessageBox.Show("Employee info updated successfully!");
                    EmployeeAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update employee. Please try again.");
                }
            }
            else
            {
                // Require password in add mode
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is required when adding an employee.");
                    return;
                }

                success = ForUser.InsertEmployee(email, password, address, name, contactNo);
                if (success)
                {
                    MessageBox.Show("Employee added successfully!");
                    EmployeeAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add employee. Please try again.");
                }
            }
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmailAccTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void PaaswordTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_ContentChanged(object sender, EventArgs e)
        {

        }

        private void ContactNoTextBox_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
