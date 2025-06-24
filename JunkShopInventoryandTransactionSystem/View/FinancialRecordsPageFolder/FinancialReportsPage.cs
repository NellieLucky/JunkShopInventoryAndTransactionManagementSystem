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
    }
}
