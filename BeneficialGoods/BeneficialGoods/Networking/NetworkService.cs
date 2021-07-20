using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeneficialGoods.Model;

namespace BeneficialGoods.Networking
{
    internal interface NetworkService
    {
        ShopifyResponseDataModel GetOrdersData(DateTime startDate, DateTime endDate);

        ShopifyResponseDataModel GetProductsData();
    }
}