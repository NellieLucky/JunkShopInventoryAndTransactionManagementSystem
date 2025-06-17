using JunkShopInventoryandTransactionSystem.View.Add_Edit_Panel;
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
using JunkShopInventoryandTransactionSystem.BackendFiles.UserSession;

namespace JunkShopInventoryandTransactionSystem.View.EmployeeManagementPageFolder
{
    public partial class EmployeeManagementPage : UserControl
    {
        private AddEditEmployee addEditEmployeeDialogBox = null!; // Initialize with null-forgiving operator  

        public EmployeeManagementPage()
        {
            InitializeComponent();

            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                DataTable dataTable = ForUser.GetAllEmployees();

                //It auto creates new columns idunno why
                dataGridView1.AutoGenerateColumns = false;

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["DateRegisteredColumn"].DataPropertyName = "empDateRegistered";
                dataGridView1.Columns["EmailColumn"].DataPropertyName = "empEmail";
                dataGridView1.Columns["NameColumn"].DataPropertyName = "empName";
                dataGridView1.Columns["PasswordColumn"].DataPropertyName = "empPassword";
                dataGridView1.Columns["ContactColumn"].DataPropertyName = "empContact";
                dataGridView1.Columns["AddressColumn"].DataPropertyName = "empAddress";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the column index
                int columnIndex = e.ColumnIndex;

                // Handle the Edit button click
                if (columnIndex == dataGridView1.Columns["EditColumn"].Index)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    string? name = row.Cells["NameColumn"].Value?.ToString();
                    string? email = row.Cells["EmailColumn"].Value?.ToString();
                    string? password = row.Cells["PasswordColumn"].Value?.ToString();
                    string? contact = row.Cells["ContactColumn"].Value?.ToString();
                    string? address = row.Cells["AddressColumn"].Value?.ToString();
                    string? dateRegistered = row.Cells["DateRegisteredColumn"].Value?.ToString();

                    if (addEditEmployeeDialogBox == null || addEditEmployeeDialogBox.IsDisposed)
                    {
                        addEditEmployeeDialogBox = new AddEditEmployee(name!, email!, contact!, password!, address!, dateRegistered!);
                        addEditEmployeeDialogBox.EmployeeAdded += (s, args) =>
                        {
                            LoadEmployeeData(); // Refresh after editing
                        };
                        addEditEmployeeDialogBox.Show();
                    }
                    else
                    {
                        addEditEmployeeDialogBox.Focus();
                    }
                }

                // Handle the Delete button click
                else if (columnIndex == dataGridView1.Columns["RemoveColumn"].Index)
                {
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        string? employeeEmail = row.Cells["EmailColumn"].Value.ToString(); // Get employee email

                        DialogResult result = MessageBox.Show($"Are you sure you want to delete the employee with email {employeeEmail}?", "Delete Confirmation", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            // Call SoftDeleteEmployee from LoggedInUser class
                            bool success = ForUser.SoftDeleteEmployee(employeeEmail);
                            if (success)
                            {
                                MessageBox.Show("Employee deleted successfully!");
                                LoadEmployeeData(); // Reload employee data after deletion
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete employee.");
                            }
                        }
                    }
                }
            }
        }

        private void RegisterEmployeeButton_Click(object sender, EventArgs e)
        {
            if (addEditEmployeeDialogBox == null || addEditEmployeeDialogBox.IsDisposed) // Check if it's already open  
            {
                //pass the data grid view to allow refreshing of inventory after adding/editing an item  
                addEditEmployeeDialogBox = new AddEditEmployee();
                addEditEmployeeDialogBox.EmployeeAdded += (s, args) =>
                {
                    LoadEmployeeData(); // Refresh after adding
                };
                addEditEmployeeDialogBox.Show();
            }
            else
            {
                addEditEmployeeDialogBox.Focus(); // Bring existing form to front  
            }
        }
    }
}
