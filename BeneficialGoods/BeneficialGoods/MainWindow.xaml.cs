using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BeneficialGoods.Model;

namespace BeneficialGoods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new ViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
            viewModel.LoadProducts();
            // new ShopifyResponseDataModel();
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            viewModel.LoadReports();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            viewModel.Calculate();
        }
    }
}