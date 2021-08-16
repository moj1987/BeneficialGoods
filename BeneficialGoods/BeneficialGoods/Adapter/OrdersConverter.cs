using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data;
using Newtonsoft.Json.Linq;
using BeneficialGoods.Model;
using BeneficialGoods.Utilities;
using BeneficialGoods.Networking;

namespace BeneficialGoods.Adapter
{
    internal static class OrdersConverter
    {
        private static NetworkServiceImpl networkServiceImpl = new NetworkServiceImpl();
        private static List<ReportDataModel> reportOrders = new List<ReportDataModel>();

        public static List<ReportDataModel> GetOrder(string startDate, string endDate)
        {
            var jsonString = networkServiceImpl.GetOrdersData(startDate, endDate);

            OrderItemsListModel order = JsonSerializer.Deserialize<OrderItemsListModel>(jsonString);

            var allOrders = order.orders.ToList();

            foreach (AllItemsModel a in allOrders)
            {
                foreach (OrdersListModel l in a.line_items)
                {
                    ReportDataModel reportDataModel = new ReportDataModel(l.product_id, l.name, Decimal.Parse(l.price), l.quantity);
                    reportOrders.Add(reportDataModel);
                }
            }
            return reportOrders;
        }
    }
}