using BeneficialGoods.Adapter;
using System;
using System.IO;
using System.Text;
using System.Windows;

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
            /*
                        Networking.NetworkServiceImpl ordersConverter = new Networking.NetworkServiceImpl();

                        var y = new DateTime(2021, 05, 01).ToString("yyyy-MM-ddTHH:mm:ss");
                        var z = new DateTime(2021, 05, 30);
                        var a = new DateTime(2021, 05, 30).ToString("yyyy-MM-ddTHH:mm:ss");
                        var reports = ordersConverter.GetOrdersData(y, a);
                        Console.WriteLine(reports.ToString());*/
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            viewModel.LoadReports();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            viewModel.CalculatePayoutPerItem();
        }

        private async void ExportToCSV(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "PayoutReport",
                DefaultExt = ".csv",
                Filter = "CSV | *.csv"
            };
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                FileStream stream = new FileStream(dialog.FileName, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(stream, Encoding.UTF8))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(viewModel.GetOrdersData());
                    await sw.WriteAsync(sb.ToString());
                    MessageBox.Show("Your data has been saved successfully.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}