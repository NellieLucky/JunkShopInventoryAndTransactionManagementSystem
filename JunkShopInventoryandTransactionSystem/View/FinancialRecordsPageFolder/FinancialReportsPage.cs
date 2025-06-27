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
            LoadFinancialReports();
            FinancialRecordsTable.CellFormatting += FinancialRecordsTable_CellFormatting;
        }

        private void LoadFinancialReports()
        {
            var reportRows = _repository.GetFinancialReportRows();

            FinancialRecordsTable.Rows.Clear();
            foreach (var row in reportRows)
            {
                FinancialRecordsTable.Rows.Add(
                    row.Date.ToShortDateString(),
                    row.CostOfGoodsSold,
                    row.Revenue,
                    row.Profit
                );
            }
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
