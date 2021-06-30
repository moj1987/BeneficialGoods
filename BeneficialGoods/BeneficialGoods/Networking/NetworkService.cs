using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Networking
{
    internal interface NetworkService
    {
        ShopifyResponseDataModel GetData();
    }
}