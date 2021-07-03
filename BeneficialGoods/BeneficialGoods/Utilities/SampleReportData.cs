using BeneficialGoods.Model;
using System.Collections.Generic;

namespace BeneficialGoods.Utilities
{
    internal class SampleReportData
    {
        public List<ReportDataModel> GetSampleReportData()
        {
            ReportDataModel SampleReportData1 = new ReportDataModel(7051160649891, "Tree Campaign", 15, 7);
            ReportDataModel SampleReportData2 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);

            List<ReportDataModel> SampleReportData = new List<ReportDataModel>
            {
                SampleReportData1,
                SampleReportData2
            };

            return SampleReportData;
        }
    }
}