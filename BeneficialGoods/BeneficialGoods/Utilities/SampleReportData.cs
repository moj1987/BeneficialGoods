using BeneficialGoods.Model;
using System;
using System.Collections.Generic;

namespace BeneficialGoods.Utilities
{
    public static class SampleReportData
    {
        public static List<ReportDataModel> GetSampleReportData()
        {
            ReportDataModel SampleReportData1 = new ReportDataModel(7051160649891, "Tree Campaign", 15, 7);
            ReportDataModel SampleReportData3 = new ReportDataModel(7051160649891, "Tree Campaign", 15, 3);
            ReportDataModel SampleReportData2 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);

            List<ReportDataModel> SampleReportData = new List<ReportDataModel>
            {
                SampleReportData1,
                SampleReportData2,
                SampleReportData3
            };

            return SampleReportData;
        }

        public static List<ReportDataModel> GetSampleReportData2()
        {
            var products = CreateProducts();
            var mergedProductsList = MergeRepetitiveProducts(products);
            var SampleReportData = new List<ReportDataModel>(mergedProductsList.Values);

            return SampleReportData;
        }

        private static List<ReportDataModel> CreateProducts()
        {
            //4
            ReportDataModel sampleReportData1 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);

            //65
            ReportDataModel sampleReportData2 = new ReportDataModel(6546251940003, "Stratford Jigsaw Puzzle - Festival Theatre in Spring", 20, 1);

            //126
            ReportDataModel sampleReportData3 = new ReportDataModel(5979993931939, "Feel The Love Greeting Card", 6, 2);

            //183
            ReportDataModel sampleReportData4 = new ReportDataModel(5977949438115, "Raw Organic Shea Butter - 30 g / 1.058 oz Glass Jar", 6.36m, 2);
            ReportDataModel sampleReportData5 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 2);

            //302
            ReportDataModel sampleReportData6 = new ReportDataModel(null, "Tip", 5, 1);
            ReportDataModel sampleReportData7 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);

            //418
            ReportDataModel sampleReportData8 = new ReportDataModel(5987061596323, "Fair Trade Coffee - Dark Roast - Paper Filter / 0.5 lb bag", 10, 2);

            //472
            ReportDataModel sampleReportData9 = new ReportDataModel(6546251940003, "Stratford Jigsaw Puzzle - Courthouse in Winter", 20, 1);

            //535
            ReportDataModel sampleReportData10 = new ReportDataModel(null, "Tip", 12, 1);
            ReportDataModel sampleReportData11 = new ReportDataModel(6546251940003, "Stratford Jigsaw Puzzle - Festival Theatre in Spring", 20, 3);

            //650
            ReportDataModel sampleReportData12 = new ReportDataModel(5977949438115, "Raw Organic Shea Butter - 30 g / 1.058 oz Glass Jar", 6.36m, 1);
            ReportDataModel sampleReportData13 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);
            ReportDataModel sampleReportData14 = new ReportDataModel(5987061596323, "Fair Trade Coffee - Dark Roast - Whole Beans / 1 lb bag", 20, 2);

            //827
            ReportDataModel sampleReportData15 = new ReportDataModel(5977657180323, "Solar LED Lantern", 35, 1);
            ReportDataModel sampleReportData16 = new ReportDataModel(5977949438115, "Raw Organic Shea Butter - 30 g / 1.058 oz Glass Jar", 6.36m, 2);

            //1005
            ReportDataModel sampleReportData17 = new ReportDataModel(5979993931939, "Feel The Love Greeting Card", 6, 1);
            ReportDataModel sampleReportData18 = new ReportDataModel(5977625854115, "Natural Beehive Candles - 3 Candle Giftbox", 20, 1);

            //1104
            ReportDataModel sampleReportData19 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);

            //1167
            ReportDataModel sampleReportData20 = new ReportDataModel(null, "Tip", 3.77m, 1);
            ReportDataModel sampleReportData21 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 3.77m, 2);

            //1304
            ReportDataModel sampleReportData22 = new ReportDataModel(null, "Tip", 2, 1);
            ReportDataModel sampleReportData23 = new ReportDataModel(6546251940003, "Fair Trade Coffee - Medium Roast - Whole Beans / 1 lb bag", 20, 1);

            //1456
            ReportDataModel sampleReportData24 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);
            ReportDataModel sampleReportData25 = new ReportDataModel(6090118758563, "Larimar Earrings - Teardrop", 28, 1);

            //1576
            ReportDataModel sampleReportData26 = new ReportDataModel(null, "Tip", 9, 1);
            ReportDataModel sampleReportData27 = new ReportDataModel(5987059990691, "Fair Trade Coffee - Medium Roast - Whole Beans / 1 lb bag", 20, 1);
            ReportDataModel sampleReportData28 = new ReportDataModel(6834464882851, "End Polio Now Tulip Bulbs", 25, 1);

            //1749
            ReportDataModel sampleReportData29 = new ReportDataModel(6090103357603, "Leather Wrist Strap - Kindness / 7.5\"", 25, 1);

            //1802
            ReportDataModel sampleReportData30 = new ReportDataModel(6546251940003, "Stratford Jigsaw Puzzle - Courthouse in Winter", 20, 2);

            //1855
            ReportDataModel sampleReportData31 = new ReportDataModel(6546251940003, "Stratford Jigsaw Puzzle - Courthouse in Winter", 20, 2);
            ReportDataModel sampleReportData32 = new ReportDataModel(6546251940003, "Stratford Jigsaw Puzzle - Festival Theatre in Spring", 20, 1);

            //1965
            ReportDataModel sampleReportData33 = new ReportDataModel(6546251940003, "Stratford Jigsaw Puzzle - Courthouse in Winter", 20, 2);

            //2028
            ReportDataModel sampleReportData34 = new ReportDataModel(6546251940003, "Stratford Jigsaw Puzzle - Courthouse in Winter", 20, 1);

            Dictionary<string, ReportDataModel> productsDictionary = new Dictionary<string, ReportDataModel>();

            productsDictionary.Add(sampleReportData1.ProductName, sampleReportData1);

            var products = new List<ReportDataModel>();
            products.Add(sampleReportData1);
            products.Add(sampleReportData2);
            products.Add(sampleReportData3);
            products.Add(sampleReportData4);
            products.Add(sampleReportData5);
            products.Add(sampleReportData6);
            products.Add(sampleReportData7);
            products.Add(sampleReportData8);
            products.Add(sampleReportData9);
            products.Add(sampleReportData10);
            products.Add(sampleReportData11);
            products.Add(sampleReportData12);
            products.Add(sampleReportData13);
            products.Add(sampleReportData14);
            products.Add(sampleReportData15);
            products.Add(sampleReportData16);
            products.Add(sampleReportData17);
            products.Add(sampleReportData18);
            products.Add(sampleReportData19);
            products.Add(sampleReportData20);
            products.Add(sampleReportData21);
            products.Add(sampleReportData22);
            products.Add(sampleReportData23);
            products.Add(sampleReportData24);
            products.Add(sampleReportData25);
            products.Add(sampleReportData26);
            products.Add(sampleReportData27);
            products.Add(sampleReportData28);
            products.Add(sampleReportData29);
            products.Add(sampleReportData30);
            products.Add(sampleReportData31);
            products.Add(sampleReportData32);
            products.Add(sampleReportData33);
            products.Add(sampleReportData34);

            return products;
        }

        private static Dictionary<string, ReportDataModel> MergeRepetitiveProducts(List<ReportDataModel> products)
        {
            var mergedProductsList = new Dictionary<String, ReportDataModel>();
            decimal tips = 0;

            foreach (ReportDataModel c in products)
            {
                if (c.ProductId == null)
                {
                    tips += c.ContractPrice;
                    continue;
                }

                if (mergedProductsList.ContainsKey(c.ProductName))
                {
                    mergedProductsList[c.ProductName].QuantitySold += c.QuantitySold;
                }
                else
                {
                    mergedProductsList.Add(c.ProductName, c);
                }
            }

            mergedProductsList.Add("Tip", new ReportDataModel(null, "Tip", tips, 1));

            return mergedProductsList;
        }

        private static void FindRepetitiveProduct()
        {
            throw new NotImplementedException();
        }
    }
}