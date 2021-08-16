using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Model
{
    public class ProductDataModel
    {
        public ProductDataModel(long? id, string vendor, string tag)
        {
            Id = id;
            Vendor = vendor;
            Tag = tag;
        }

        public long? Id
        {
            get; set;
        }

        public string Vendor
        {
            get;
            set;
        }

        public string Tag
        {
            get;
            set;
        }
    }
}