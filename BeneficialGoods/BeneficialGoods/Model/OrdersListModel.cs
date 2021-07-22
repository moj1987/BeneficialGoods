using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Model
{
    internal class OrdersListModel
    {
        public long? product_id
        {
            get; set;
        }

        public string name
        {
            get;
            set;
        }

        public string price
        {
            get;
            set;
        }

        public int quantity
        {
            get;
            set;
        }
    }
}