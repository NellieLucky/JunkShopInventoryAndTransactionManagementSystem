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
            LoadLowStockItems();

            // Populate Summary ComboBox
            SummaryofRevenueCogsOrTotalProfit.Items.Clear();
            SummaryofRevenueCogsOrTotalProfit.Items.AddRange(new object[] {
                "COGS Summary",
                "Revenue Summary",
                "Profit Summary"
            });
            SummaryofRevenueCogsOrTotalProfit.SelectedIndex = 0; // Default

            // Populate Periodicity ComboBox
            Periodicity.Items.Clear();
            Periodicity.Items.AddRange(new object[] {
                "Yearly",
                "Quarterly",
                "Monthly"
            });
            Periodicity.SelectedIndex = 0; // Default

            SummaryofRevenueCogsOrTotalProfit.OnSelectedIndexChanged += FilterChanged;
            Periodicity.OnSelectedIndexChanged += FilterChanged;

            // Load default dashboard data
            LoadDashboardSummary();
        }

        private void LoadDashboardCounts()
        {
            try
            {
                var (items, categories, employees, buyers, sellers, transactions) = DashboardCounts.GetDashboardCounts();

                // Update the labels with the counts
                NumOfItems.Text = items.ToString();
                NumofCategories.Text = categories.ToString();
                NumOfEmployees.Text = employees.ToString();
                NumOfBuyers.Text = buyers.ToString();
                NumOfSellers.Text = sellers.ToString();
                NumOfTransactions.Text = transactions.ToString();
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

        private void LoadLowStockItems()
        {
            try
            {
                var repo = new InventoryRepository();
                var lowStockItems = repo.GetLowStockItems();

                LowStocksTable.Rows.Clear();
                foreach (var item in lowStockItems)
                {
                    LowStocksTable.Rows.Add(item.itemName, item.itemQuantity.ToString("F2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading low stock items: {ex.Message}",
                    "Low Stock Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardSummary()
        {
            // Get filter values
            string summaryType = SummaryofRevenueCogsOrTotalProfit.SelectedItem?.ToString() ?? "COGS Summary";
            string periodicity = Periodicity.SelectedItem?.ToString() ?? "Yearly";
 

            var summary = DashboardDataRepository.GetSummary(summaryType, periodicity);

            CostOfGoodSoldsLabel.Text = $"₱ {summary.COGS:N2}";
            TotalRevenueLabel.Text = $"₱ {summary.Revenue:N2}";
            TotalProfitLabel.Text = $"₱ {summary.Profit:N2}";

            // Defensive: Ensure at least two data points for the chart
            if (summary.ChartPoints.Count < 2)
            {
                // Add a default second point if only one exists, or two zero points if none
                if (summary.ChartPoints.Count == 1)
                {
                    summary.ChartPoints.Add(new ChartPoint
                    {
                        Label = summary.ChartPoints[0].Label + " (copy)",
                        Value = summary.ChartPoints[0].Value
                    });
                }
                else if (summary.ChartPoints.Count == 0)
                {
                    summary.ChartPoints.Add(new ChartPoint { Label = "N/A", Value = 0 });
                    summary.ChartPoints.Add(new ChartPoint { Label = "N/A", Value = 0 });
                }
            }

            ChartLine.DataPoints = summary.ChartPoints.Select(p => (float)p.Value).ToArray();
            ChartLine.CustomXAxis = summary.ChartPoints.Select(p => p.Label).ToArray();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            LoadDashboardSummary();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadDashboardSummary();
        }

    }
}
