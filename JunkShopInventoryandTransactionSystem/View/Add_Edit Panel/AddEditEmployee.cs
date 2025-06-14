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

        public AddEditEmployee()
        {
            InitializeComponent();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            string email = EmailAccTextBox.Content;
            string password = PaaswordTextBox.Content;
            string address = AddressTextBox.Content;
            string name = NameTextBox.Content;
            string contactNo = ContactNoTextBox.Content;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contactNo))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Call the method to insert the data into the database
            bool success = ForUser.InsertEmployee(email, password, address, name, contactNo);

            if (success)
            {
                MessageBox.Show("Employee added successfully!");
                EmployeeAdded?.Invoke(this, EventArgs.Empty); // Trigger the event after adding
                this.Close(); // Close the AddEditEmployee form
            }
            else
            {
                MessageBox.Show("Failed to add employee. Please try again.");
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
