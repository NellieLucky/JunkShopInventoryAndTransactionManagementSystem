using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Controls;

namespace JunkShopInventoryandTransactionSystem.View
{
    public partial class MainInventoryPage : UserControl
    {
        public MainInventoryPage()
        {
            InitializeComponent();

            SetNavButtonChecked(ItemNavButton);  // Set the clicked button as checked
            InventoryPanel.Controls.Clear();
            var ItemInventoryPage = new ItemRecordsPage();
            ItemInventoryPage.Dock = DockStyle.Fill;
            InventoryPanel.Controls.Add(ItemInventoryPage);

            // Initialize the inventory page with the inventory user control

        }

        private void ItemNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(ItemNavButton);  // Set the clicked button as checked
            InventoryPanel.Controls.Clear();
            var ItemInventoryPage = new ItemRecordsPage();
            ItemInventoryPage.Dock = DockStyle.Fill;
            InventoryPanel.Controls.Add(ItemInventoryPage);
        }

        private void CategoryNavButton_Click(object sender, EventArgs e)
        {
            SetNavButtonChecked(CategoryNavButton);  // Set the clicked button as checked
            InventoryPanel.Controls.Clear();
            var CategoryInventoryPage = new CategoryPage();
            CategoryInventoryPage.Dock = DockStyle.Fill;
            InventoryPanel.Controls.Add(CategoryInventoryPage);
        }

        private void SetNavButtonChecked(CuoreUI.Controls.cuiButton checkedButton)
        {
            var activeColor = System.Drawing.Color.FromArgb(25, 219, 138); // active color
            var inactiveColor = System.Drawing.Color.Transparent; // inactive color


        }

        
    }
}
