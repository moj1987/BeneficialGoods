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
    internal class OrdersConverter
    {
        private NetworkServiceImpl networkServiceImpl = new NetworkServiceImpl();
        private List<ReportDataModel> reportOrders = new List<ReportDataModel>();
        public List<ReportDataModel> GetOrder(DateTime startDate, DateTime endDate)
        {
            var jsonString = networkServiceImpl.GetOrdersData(startDate, endDate);

            OrderItemsListModel order = JsonSerializer.Deserialize<OrderItemsListModel>(jsonString);

            var allOrders = order.orders.ToList();

            foreach (AllItemsModel a in allOrders)
            {
                foreach (OrdersListModel l in a.line_items)
                {
                    ReportDataModel reportDataModel = new ReportDataModel(l.id, l.name,Decimal.Parse( l.price), l.quantity);
                    reportOrders.Add(reportDataModel);
                    
                }
            }
            return reportOrders;
        }
    }
}