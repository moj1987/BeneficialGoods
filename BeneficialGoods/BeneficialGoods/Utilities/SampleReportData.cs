using BeneficialGoods.Model;
using System.Collections.Generic;

namespace BeneficialGoods.Utilities
{
    internal class SampleReportData
    {
        public List<ReportDataModel> GetSampleReportData()
        {
            ReportDataModel SampleReportData1 = new ReportDataModel(7051160649891, "Tree Campaign", 15, 7);
            decimal netPrice1 = SampleReportData1.CalculateNetPrice(1);
            decimal payoutPerItem1 = SampleReportData1.CalculatePayoutPerItem(netPrice1);

            ReportDataModel SampleReportData2 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);
            decimal netPrice2 = SampleReportData2.CalculateNetPrice(1.50m);
            decimal payoutPerItem2 = SampleReportData2.CalculatePayoutPerItem(netPrice2);

            List<ReportDataModel> SampleReportData = new List<ReportDataModel>
            {
                SampleReportData1,
                SampleReportData2
            };

            return SampleReportData;
        }
    }
}