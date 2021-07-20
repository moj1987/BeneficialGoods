using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Model
{
    internal class ProductDataModel
    {
        public ProductDataModel(long? productId, string vendor, string tags)
        {
            ProductId = productId;
            Vendor = vendor;
            Tags = tags;
        }

        public long? ProductId
        {
            get; set;
        }

        public string Vendor
        {
            get;
            set;
        }

        public string Tags
        {
            get;
            set;
        }
    }
}