using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Model
{
    internal class ReportDataModel
    {
        public ReportDataModel(long productId, string productName, decimal contractPrice, decimal quantitySold)
        {
        }

        public long ProductId
        {
            get; set;
        }

        public string ProductName
        {
            get;
            set;
        }

        private decimal _contractPrice;

        public decimal ContractPrice
        {
            get { return _contractPrice; }
            set { _contractPrice = value; }
        }

        private int QuantitySold;

        public int _quantitySold
        {
            get { return _quantitySold; }
            set { _quantitySold = value; }
        }

        public decimal calculateNetPrice(decimal fees)
        {
            decimal netPrice = ContractPrice - fees;
            return netPrice;
        }

        public decimal calculatePayoutPerItem(decimal netPrice)
        {
            decimal payoutPerItem = netPrice * QuantitySold;
            return payoutPerItem;
        }
    }
}