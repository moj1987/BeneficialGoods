using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BeneficialGoods;
using BeneficialGoods.Utilities;
using BeneficialGoods.Model;

namespace Test.ViewModelTest
{
    public class ViewModelMethodTests
    {
        private ViewModel viewModel = new ViewModel();

        [Fact]
        public void MergeOrdersTest_ListOfOrders_MergedDicitonaryOfOrders()
        {
            //Arrange
            var sampleOrders = SampleReportData.GetSampleReportData();

            var expected = new Dictionary<string, ReportDataModel>
            {
                ["Tree Campaign"] = new ReportDataModel(7051160649891, "Tree Campaign", 15, 10),
                ["End Polio Now Tulip Bulbs"] = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1),
                ["Tip"] = new ReportDataModel(null, "Tip", 0, 1)
            };

            //Act
            var actual = viewModel.MergeOrders(sampleOrders);

            //Assert
            Assert.Equal(actual.Keys, expected.Keys);
        }
    }
}