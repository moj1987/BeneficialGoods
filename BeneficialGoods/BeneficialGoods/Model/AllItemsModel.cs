using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Model
{
    class AllItemsModel
    {
        public string created_at { get; set; }
        public string financial_status { get; set; }
        public IList<ReportDataModel> line_items { get; set; }
    }
}
