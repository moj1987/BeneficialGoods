using BeneficialGoods.Adapter;
using BeneficialGoods.Model;
using BeneficialGoods.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BeneficialGoods
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private const string ALL_TAG = "All";

        #region Properties

        private List<ReportDataModel> orders = new List<ReportDataModel>();
        private List<ProductDataModel> products = new List<ProductDataModel>();

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

        private decimal _totalPayout;

        public decimal TotalPayout
        {
            get { return _totalPayout; }
            set { _totalPayout = value; propertyChanged(); }
        }

        private string _selectedTag;

        public string SelectedTag
        {
            get { return _selectedTag; }
            set { _selectedTag = value; FilterOrders(); }
        }

        private DateTime _fromDate = DateTime.Now;

        public DateTime FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        private DateTime _toDate = DateTime.Now;

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
                CalculateTotalPayout(orders);
                return;
            }

            SampleProductData sampleProducts = new SampleProductData();
            //var products = sampleProducts.GetSampleReportData();

            var productsWithSelectedTag = products.Where(p => p.Tag == SelectedTag);
            List<long?> idTags = new List<long?>();
            foreach (ProductDataModel p in productsWithSelectedTag)
            {
                idTags.Add(p.Id);
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
            CalculateTotalPayout(Orders.ToList());
        }

        internal void LoadProducts()
        {
            ProductsConverter pc = new ProductsConverter();
            products = pc.GetProduct();

            //SampleProductData sampleProducts = new SampleProductData();
            //var products = sampleProducts.GetSampleReportData();

            Dictionary<string, ProductDataModel> productsDictionary = new Dictionary<string, ProductDataModel>();

            foreach (ProductDataModel p in products)
            {
                if (!productsDictionary.ContainsKey(p.Tag))
                {
                    productsDictionary.Add(p.Tag, p);
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
            /*SampleReportData sampleReport = new SampleReportData();
            var sampleReports = sampleReport.GetSampleReportData2();
            */

            OrdersConverter ordersConverter = new OrdersConverter();

            //var reports = ordersConverter.GetOrder(FromDate.ToString("yyyy-MM-ddTHH:mm:ss"), ToDate.ToString("yyyy-MM-ddTHH:mm:ss"));

            var x = new DateTime(2021, 05, 1);
            var y = new DateTime(2021, 05, 31);

            var a = FromDate.ToString("yyyy-MM-ddTHH:mm:ss");
            var b = ToDate.ToString("yyyy-MM-ddTHH:mm:ss");

            var reports = ordersConverter.GetOrder(a, b);
            var mergedReports = MergeRepetitiveOrders(reports);

            var sortedReports = mergedReports.Values.OrderBy(c => c.ProductName);
            foreach (ReportDataModel r in sortedReports)
            {
                orders.Add(r);
            }
            ShowAllOrders();
            CalculateTotalPayout(orders);
        }

        private Dictionary<string, ReportDataModel> MergeRepetitiveOrders(List<ReportDataModel> reports)
        {
            var mergedProductsList = new Dictionary<String, ReportDataModel>();
            decimal tips = 0;

            foreach (ReportDataModel c in reports)
            {
                if (c.ProductId == null)
                {
                    tips += c.ContractPrice;
                    continue;
                }

                if (mergedProductsList.ContainsKey(c.ProductName))
                {
                    mergedProductsList[c.ProductName].QuantitySold += c.QuantitySold;
                }
                else
                {
                    mergedProductsList.Add(c.ProductName, c);
                }
            }

            mergedProductsList.Add("Tip", new ReportDataModel(null, "Tip", tips, 1));

            return mergedProductsList;
        }

        internal void ShowAllOrders()
        {
            Orders.Clear();
            foreach (ReportDataModel r in orders)
                Orders.Add(r);
        }

        public StringBuilder GetOrdersData()
        {
            StringBuilder sbData = new StringBuilder();
            sbData.AppendLine("ProductName, ContractPrice, Fees, NetPrice, QuantitySold, PayoutPerItem");
            List<ReportDataModel> list = Orders.ToList();
            list.ForEach(o =>
               {
                   if (o != null)
                   {
                       sbData.AppendLine(string.Format("{0}, {1}, {2}, {3}, {4}, {5}", o.ProductName, o.ContractPrice, o.Fees, o.NetPrice, o.QuantitySold, o.PayoutPerItem));
                   }
               });
            return sbData;
        }

        internal void CalculatePayoutPerItem()
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
            CalculateTotalPayout(Orders.ToList());
        }

        internal void CalculateTotalPayout(List<ReportDataModel> orders)
        {
            TotalPayout = 0;
            foreach (var i in orders)
            {
                TotalPayout += i.PayoutPerItem;
            }
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