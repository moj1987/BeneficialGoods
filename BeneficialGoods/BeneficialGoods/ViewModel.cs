using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BeneficialGoods.Utilities;
using BeneficialGoods.Model;

namespace BeneficialGoods
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private List<ReportDataModel> products = new List<ReportDataModel>();

        #region Properties

        public BindingList<ReportDataModel> Products
        {
            get; set;
        } = new BindingList<ReportDataModel>();

        private ReportDataModel selectedProduct;

        public ReportDataModel SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                propertyChanged();
            }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private decimal _contractPrice;

        public decimal ContractPrice
        {
            get { return _contractPrice; }
            set { _contractPrice = value; }
        }

        private decimal _fees;

        public decimal Fees
        {
            get { return _fees; }
            set { _fees = value; propertyChanged(); }
        }

        private decimal _netPrice;

        public decimal NetPrice
        {
            get { return _netPrice; }
            set { _netPrice = value; }
        }

        private decimal _quantitySold;

        public decimal QuantitySold
        {
            get { return _quantitySold; }
            set { _quantitySold = value; }
        }

        private decimal _payoutPerItem;

        public decimal PayoutPerItem
        {
            get { return _payoutPerItem; }
            set { _payoutPerItem = value; }
        }

        #endregion Properties

        internal void LoadData()
        {
            SampleReportData sampleReport = new SampleReportData();
            var sampleReports = sampleReport.GetSampleReportData();
            foreach (ReportDataModel r in sampleReports)
            {
                Products.Add(r);
            }
        }

        internal void Calculate()
        {
            if (SelectedProduct == null)
            {
                return;
            }
            if (SelectedProduct.Fees == 0)
            {
                return;
            }
            SelectedProduct.NetPrice = SelectedProduct.CalculateNetPrice(SelectedProduct.Fees);
            SelectedProduct.PayoutPerItem = SelectedProduct.CalculatePayoutPerItem(SelectedProduct.NetPrice);
            this.Products.ResetBindings();
        }

        #region Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        private void propertyChanged([CallerMemberName] string porpertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(porpertyName));
        }

        #endregion Property Changed
    }
}