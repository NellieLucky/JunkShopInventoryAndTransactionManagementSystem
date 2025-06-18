using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunkShopInventoryandTransactionSystem.BackendFiles.Dashboard;

namespace JunkShopInventoryandTransactionSystem.View.DashBoardPageFolder
{
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
            LoadDashboardCounts();
        }

        private void LoadDashboardCounts()
        {
            try
            {
                var (items, categories, employees) = DashboardCounts.GetDashboardCounts();

                // Update the labels with the counts
                NumOfItems.Text = items.ToString();
                NumofCategories.Text = categories.ToString();
                NumOfEmployees.Text = employees.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading dashboard counts: {ex.Message}",
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
