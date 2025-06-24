using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JunkShopInventoryandTransactionSystem.BackendFiles.FinancialRecordsPageFolder
{
    public class FinancialReportRow
    {
        public DateTime Date { get; set; }
        public decimal CostOfGoodsSold { get; set; }
        public decimal Revenue { get; set; }
        public decimal Profit => Revenue - CostOfGoodsSold;
    }
}