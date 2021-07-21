using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data;
using Newtonsoft.Json.Linq;
using BeneficialGoods.Model;
using BeneficialGoods.Utilities;

namespace BeneficialGoods.Adapter
{
    internal class OrdersConverter
    {  
        public List<ReportDataModel> GetOrder()
        {
            OrderItemsListModel order = JsonSerializer.Deserialize<OrderItemsListModel>(SampleReportString.GetSampleData());
            var allOrders = order.orders.ToList();
            List<ReportDataModel> reportOrders = new List<ReportDataModel>();
            foreach (AllItemsModel a in allOrders)
            {
                foreach (ReportDataModel l in a.line_items)
                {
                    ReportDataModel reportDataModel = new ReportDataModel(l.ProductId, l.ProductName, l.ContractPrice, l.QuantitySold);
                    reportOrders.Add(reportDataModel);
                    
                }
            }
            return reportOrders;
        }
    }
}