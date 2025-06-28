using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunkShopInventoryandTransactionSystem.BackendFiles.FinancialRecordsPageFolder;

namespace JunkShopInventoryandTransactionSystem.View.FinancialReportsPageFolder
{
    public partial class FinancialReportsPage : UserControl
    {
        private readonly FinancialReportRepository _repository;

        public FinancialReportsPage()
        {
            InitializeComponent();
            _repository = new FinancialReportRepository();

            // Populate Periodicity ComboBox
            Periodicity.Items.Clear();
            Periodicity.Items.AddRange(new object[] { "Daily", "Monthly", "Quarterly", "Yearly" });
            Periodicity.SelectedIndex = 0; // Default to Daily
            Periodicity.OnSelectedIndexChanged += Periodicity_SelectedIndexChanged;

            LoadFinancialReports();
            FinancialRecordsTable.CellFormatting += FinancialRecordsTable_CellFormatting;
        }

        private void LoadFinancialReports()
        {
            var reportRows = _repository.GetFinancialReportRows();

            string periodicity = Periodicity.SelectedItem?.ToString() ?? "Daily";
            IEnumerable<dynamic> grouped;

            switch (periodicity)
            {
                case "Monthly":
                    grouped = reportRows
                        .GroupBy(r => new { r.Date.Year, r.Date.Month })
                        .Select(g => new
                        {
                            Date = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MM/yyyy"),
                            CostOfGoodsSold = g.Sum(x => x.CostOfGoodsSold),
                            Revenue = g.Sum(x => x.Revenue),
                            Profit = g.Sum(x => x.Profit)
                        });
                    break;
                case "Quarterly":
                    grouped = reportRows
                        .GroupBy(r => new { r.Date.Year, Quarter = (r.Date.Month - 1) / 3 + 1 })
                        .Select(g => new
                        {
                            Date = $"Q{g.Key.Quarter} {g.Key.Year}",
                            CostOfGoodsSold = g.Sum(x => x.CostOfGoodsSold),
                            Revenue = g.Sum(x => x.Revenue),
                            Profit = g.Sum(x => x.Profit)
                        });
                    break;
                case "Yearly":
                    grouped = reportRows
                        .GroupBy(r => r.Date.Year)
                        .Select(g => new
                        {
                            Date = g.Key.ToString(),
                            CostOfGoodsSold = g.Sum(x => x.CostOfGoodsSold),
                            Revenue = g.Sum(x => x.Revenue),
                            Profit = g.Sum(x => x.Profit)
                        });
                    break;
                default: // Daily
                    grouped = reportRows
                        .GroupBy(r => r.Date.Date)
                        .Select(g => new
                        {
                            Date = g.Key.ToShortDateString(),
                            CostOfGoodsSold = g.Sum(x => x.CostOfGoodsSold),
                            Revenue = g.Sum(x => x.Revenue),
                            Profit = g.Sum(x => x.Profit)
                        });
                    break;
            }

            FinancialRecordsTable.Rows.Clear();
            foreach (var row in grouped)
            {
                FinancialRecordsTable.Rows.Add(
                    row.Date,
                    row.CostOfGoodsSold,
                    row.Revenue,
                    row.Profit
                );
            }
        }

        private void Periodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFinancialReports();
        }

        private void FinancialReportsPage_Load(object sender, EventArgs e)
        {

        }

        private void codeeloDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FinancialRecordsTable_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnName = FinancialRecordsTable.Columns[e.ColumnIndex].Name;
            if (columnName == "CostOfGoodSolds" || columnName == "Revenue" || columnName == "Profit")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal amount))
                {
                    e.Value = string.Format(new System.Globalization.CultureInfo("en-PH"), "{0:C2}", amount);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}