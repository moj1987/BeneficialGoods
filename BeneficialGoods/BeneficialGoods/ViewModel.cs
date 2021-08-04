using BeneficialGoods.Adapter;
using BeneficialGoods.Model;
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
        private const string TAG_ALL = "All";
        private const string TAG_BENEFICIAL_GOODS = "*BG";
        private const string TAG_TIP = "Tip";

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
            set { _fees = value; }
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
            set { _selectedTag = value; FilterOrdersOnSelectedTag(); }
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

        internal void LoadProducts()
        {
            ProductsConverter productConverter = new ProductsConverter();
            products = productConverter.GetProducts();
        }

        internal void ShowReports()
        {
            var reports = LoadReports();
            var mergedReports = MergeOrders(reports);
            var sortedReports = SortReports(mergedReports);

            AddReportsToInteralOrdersList(sortedReports);
            ShowAllOrders();
            CalculateTotalPayout(orders);
        }

        private void FilterOrdersOnSelectedTag()
        {
            if (SelectedTag.Equals(TAG_ALL))
            {
                ShowAllOrders();
                CalculateTotalPayout(orders);
                return;
            }

            var productsWithSelectedTag = FindProductsWithSelectedTag();
            var idsWithSelectedTag = FindProductIdsWithSelectedTag(productsWithSelectedTag);
            var ordersWithSelectedTag = FindOrdersWithSelectedTag(idsWithSelectedTag);
            ShowFilteredOrders(ordersWithSelectedTag);
            CalculateTotalPayout(Orders.ToList());
        }

        private List<ReportDataModel> LoadReports()
        {
            OrdersConverter ordersConverter = new OrdersConverter();
            var fromDateString = FromDate.ToString("yyyy-MM-ddTHH:mm:ss");
            var toDateString = ToDate.ToString("yyyy-MM-ddTHH:mm:ss");

            var reports = ordersConverter.GetOrder(fromDateString, toDateString);
            return reports;
        }

        private Dictionary<string, ReportDataModel> MergeOrders(List<ReportDataModel> reports)
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

            mergedProductsList.Add(TAG_TIP, new ReportDataModel(null, TAG_TIP, tips, 1));

            return mergedProductsList;
        }

        private List<ReportDataModel> SortReports(Dictionary<string, ReportDataModel> mergedReports)
        {
            var sortedReports = mergedReports.Values.OrderBy(c => c.ProductName).ToList();
            return sortedReports;
        }

        private void AddReportsToInteralOrdersList(List<ReportDataModel> sortedReports)
        {
            foreach (ReportDataModel r in sortedReports)
            {
                orders.Add(r);
            }
        }

        internal void ShowAllTags()
        {
            Dictionary<string, ProductDataModel> productsDictionary = new Dictionary<string, ProductDataModel>();

            foreach (ProductDataModel p in products)
            {
                if (!productsDictionary.ContainsKey(p.Tag))
                {
                    productsDictionary.Add(p.Tag, p);
                }
            }

            ProductTags.Add(TAG_ALL);
            foreach (string t in productsDictionary.Keys)
            {
                ProductTags.Add(t);
            }
        }

        private List<ProductDataModel> FindProductsWithSelectedTag()
        {
            List<ProductDataModel> productsWithSelectedTag = new List<ProductDataModel>();
            productsWithSelectedTag = products.Where(p => p.Tag == SelectedTag).ToList();
            return productsWithSelectedTag;
        }

        private List<long?> FindProductIdsWithSelectedTag(List<ProductDataModel> productsWithSelectedTag)
        {
            List<long?> idsWithSelectedTag = new List<long?>();

            foreach (ProductDataModel p in productsWithSelectedTag)
            {
                idsWithSelectedTag.Add(p.Id);
            }
            return idsWithSelectedTag;
        }

        private List<ReportDataModel> FindOrdersWithSelectedTag(List<long?> idsWithSelectedTag)
        {
            List<ReportDataModel> ordersWithSelectedTag = new List<ReportDataModel>();

            foreach (ReportDataModel o in orders)
            {
                if (idsWithSelectedTag.Contains(o.ProductId))
                {
                    ordersWithSelectedTag.Add(o);
                }
            }

            if (SelectedTag.Equals(TAG_BENEFICIAL_GOODS))
            {
                var tips = orders.Find(o => o.ProductName.Equals(TAG_TIP));
                ordersWithSelectedTag.Add(tips);
            }

            return ordersWithSelectedTag;
        }

        private void ShowAllOrders()
        {
            Orders.Clear();
            foreach (ReportDataModel r in orders)
                Orders.Add(r);
        }

        private void ShowFilteredOrders(List<ReportDataModel> filteredOrders)
        {
            Orders.Clear();
            foreach (ReportDataModel r in filteredOrders)
                Orders.Add(r);
        }

        internal void CalculatePayoutPerItem()
        {
            foreach (ReportDataModel r in orders)
            {
                if (r.ProductName.Equals(TAG_TIP))
                {
                    r.PayoutPerItem = r.ContractPrice;
                    continue;
                }

                if (r.Fees <= 0 || r.Fees >= r.ContractPrice)
                {
                    continue;
                }

                r.NetPrice = r.CalculateNetPrice(r.Fees);
                r.PayoutPerItem = r.CalculatePayoutPerItem(r.NetPrice);
            }

            this.Orders.ResetBindings();
            CalculateTotalPayout(Orders.ToList());
        }

        private void CalculateTotalPayout(List<ReportDataModel> orders)
        {
            TotalPayout = 0;
            foreach (var i in orders)
            {
                TotalPayout += i.PayoutPerItem;
            }
        }

        internal StringBuilder GetOrdersData()
        {
            StringBuilder sbData = new StringBuilder();
            sbData.AppendLine($"FromDate, {FromDate}");
            sbData.AppendLine($"ToDate, {ToDate}");
            sbData.AppendLine("ProductName, ContractPrice, Fees, NetPrice, QuantitySold, PayoutPerItem");
            List<ReportDataModel> list = Orders.ToList();
            list.ForEach(o =>
            {
                if (o != null)
                {
                    sbData.AppendLine(string.Format("{0}, {1}, {2}, {3}, {4}, {5}", o.ProductName, o.ContractPrice.ToString("N2"), o.Fees.ToString("N2"), o.NetPrice.ToString("N2"), o.QuantitySold, o.PayoutPerItem.ToString("N2")));
                }
            });
            sbData.AppendLine($"Total, {TotalPayout}");
            return sbData;
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