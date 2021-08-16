using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeneficialGoods.Model;

namespace BeneficialGoods.Utilities
{
    public static class SampleProductData
    {
        public static List<ProductDataModel> GetSampleReportData()
        {
            ProductDataModel SampleProductData1 = new ProductDataModel(5987061596323, "Oromia Coffee Union", "End Polio Now");
            ProductDataModel SampleProductData2 = new ProductDataModel(6081524695203, "Oromia Coffee Union", "End Polio Now");
            ProductDataModel SampleProductData3 = new ProductDataModel(5987062284451, "Oromia Coffee Union", "End Polio Now");
            ProductDataModel SampleProductData4 = new ProductDataModel(5987059990691, "Oromia Coffee Union", "End Polio Now");
            ProductDataModel SampleProductData5 = new ProductDataModel(5979993931939, "Beneficial Goods", "");
            ProductDataModel SampleProductData6 = new ProductDataModel(6090118758563, "Cabarete Sostenible", "Cabarete Sostenible");
            ProductDataModel SampleProductData7 = new ProductDataModel(5977625854115, "10,000 Beekeepers", "Rotary Festival City");
            ProductDataModel SampleProductData8 = new ProductDataModel(5977949438115, "Ghanaian Women", "Rotary Festival City");
            ProductDataModel SampleProductData9 = new ProductDataModel(5977657180323, "ShelterBox", "LuminAID");
            ProductDataModel SampleProductData10 = new ProductDataModel(6546251940003, "Rotary Club of Festival City", "Rotary Festival City");
            ProductDataModel SampleProductData11 = new ProductDataModel(6834464882851, "Rotary Club of Festival City", "End Polio Now");

            List<ProductDataModel> SampleProductData = new List<ProductDataModel>
            {
                SampleProductData1,
                SampleProductData2,
                SampleProductData3,
                SampleProductData4,
                SampleProductData5,
                SampleProductData6,
                SampleProductData7,
                SampleProductData8,
                SampleProductData9,
                SampleProductData10,
                SampleProductData11
            };

            return SampleProductData;
        }
    }
}