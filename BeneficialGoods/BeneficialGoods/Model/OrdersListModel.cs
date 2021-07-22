using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Model
{
    class OrdersListModel
    {
        public long? id
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
