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

namespace JunkShopInventoryandTransactionSystem.View.EmployeeManagementPageFolder
{
    public partial class EmployeeManagementPage : UserControl
    {
        private AddEditEmployee addEditEmployeeDialogBox = null!; // Initialize with null-forgiving operator  

        public EmployeeManagementPage()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegisterEmployeeButton_Click(object sender, EventArgs e)
        {
            if (addEditEmployeeDialogBox == null || addEditEmployeeDialogBox.IsDisposed) // Check if it's already open  
            {
                //pass the data grid view to allow refreshing of inventory after adding/editing an item  
                addEditEmployeeDialogBox = new AddEditEmployee();
                addEditEmployeeDialogBox.Show();
            }
            else
            {
                addEditEmployeeDialogBox.Focus(); // Bring existing form to front  
            }
        }
    }
}
