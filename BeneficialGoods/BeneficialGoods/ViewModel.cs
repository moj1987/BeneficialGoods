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
        private const string ALL_TAG = "All";

        #region Properties

        private List<ReportDataModel> orders = new List<ReportDataModel>();

        public BindingList<ReportDataModel> Orders
        {
            get; set;
        } = new BindingList<ReportDataModel>();

        public BindingList<string> ProductTags
        {
            get; set;
        } = new BindingList<string>();

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

        private string _selectedTag;

        public string SelectedTag
        {
            get { return _selectedTag; }
            set { _selectedTag = value; FilterOrders(); }
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

        internal void FilterOrders()
        {
            //Show all if "All" is selected
            if (SelectedTag.Equals(ALL_TAG))
            {
                ShowAllOrders();
                return;
            }

            SampleProductData sampleProducts = new SampleProductData();
            var products = sampleProducts.GetSampleReportData();

            var productsWithSelectedTag = products.Where(p => p.Tags == SelectedTag);
            List<long?> idTags = new List<long?>();
            foreach (ProductDataModel p in productsWithSelectedTag)
            {
                idTags.Add(p.ProductId);
            }

            List<ReportDataModel> ordersWithTheTag = new List<ReportDataModel>();
            foreach (ReportDataModel o in orders)
            {
                if (idTags.Contains(o.ProductId))
                {
                    ordersWithTheTag.Add(o);
                }
            }

            Orders.Clear();
            foreach (ReportDataModel r in ordersWithTheTag)
            {
                Orders.Add(r);
            }
        }

        internal void LoadProducts()
        {
            SampleProductData sampleProducts = new SampleProductData();
            var products = sampleProducts.GetSampleReportData();
            Dictionary<string, ProductDataModel> productsDictionary = new Dictionary<string, ProductDataModel>();

            foreach (ProductDataModel p in products)
            {
                if (!productsDictionary.ContainsKey(p.Tags))
                {
                    productsDictionary.Add(p.Tags, p);
                }
            }

            ProductTags.Add(ALL_TAG);
            foreach (string t in productsDictionary.Keys)
            {
                ProductTags.Add(t);
            }
        }

        internal void LoadReports()
        {
            SampleReportData sampleReport = new SampleReportData();
            var sampleReports = sampleReport.GetSampleReportData2();
            var sortedReports = sampleReports.OrderBy(c => c.ProductName);
            foreach (ReportDataModel r in sortedReports)
            {
                orders.Add(r);
            }
            ShowAllOrders();
        }

        internal void Calculate()
        {
            foreach (ReportDataModel r in orders)
            {
                if (r.Fees <= 0)
                {
                    continue;
                }
                r.NetPrice = r.CalculateNetPrice(r.Fees);
                r.PayoutPerItem = r.CalculatePayoutPerItem(r.NetPrice);
            }

            this.Orders.ResetBindings();
        }

        internal void ShowAllOrders()
        {
            Orders.Clear();
            foreach (ReportDataModel r in orders)
                Orders.Add(r);
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