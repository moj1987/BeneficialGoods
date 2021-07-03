using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Model
{
    internal class ReportDataModel
    {
        public ReportDataModel(long productId, string productName, decimal contractPrice, int quantitySold)
        {
            ProductId = productId;
            ProductName = productName;
            ContractPrice = contractPrice;
            QuantitySold = quantitySold;
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

        private int _quantitySold;

        public int QuantitySold
        {
            get { return _quantitySold; }
            set { _quantitySold = value; }
        }

        public decimal Fees
        {
            get; set;
        }

        public decimal NetPrice
        {
            get; set;
        }

        public decimal PayoutPerItem
        {
            get; set;
        }

        public decimal CalculateNetPrice(decimal fees)
        {
            NetPrice = ContractPrice - fees;
            return NetPrice;
        }

        public decimal CalculatePayoutPerItem(decimal netPrice)
        {
            PayoutPerItem = netPrice * QuantitySold;
            return PayoutPerItem;
        }
    }
}