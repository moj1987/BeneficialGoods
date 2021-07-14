using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BeneficialGoods.Utilities;
using BeneficialGoods.Model;
using System.Collections.ObjectModel;

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

        private ObservableCollection<string> BeneficiaryName { get; set; } = new ObservableCollection<string>();

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

        private DateTime _fromDate = DateTime.Now.Date;

        public DateTime FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        private DateTime _toDate = DateTime.Now.Date;

        public DateTime ToDate
        {
            get { return _toDate; }
            set { _toDate = value; }
        }

        #endregion Properties

        internal void LoadData()
        {
            SampleReportData sampleReport = new SampleReportData();
            var sampleReports = sampleReport.GetSampleReportData2();
            var sortedReports = sampleReports.OrderBy(c => c.ProductName);
            foreach (ReportDataModel r in sortedReports)
            {
                Products.Add(r);
                BeneficiaryName.Add(r.ProductName);
            }
        }

        internal void Calculate()
        {
            foreach (ReportDataModel r in Products)
            {
                if (r.Fees == 0)
                {
                    continue;
                }
                r.NetPrice = r.CalculateNetPrice(r.Fees);
                r.PayoutPerItem = r.CalculatePayoutPerItem(r.NetPrice);
            }

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