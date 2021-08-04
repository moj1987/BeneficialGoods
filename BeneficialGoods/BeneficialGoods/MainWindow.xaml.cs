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
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            viewModel.ShowReports();
            viewModel.ShowAllTags();
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
                DefaultExt = ".xls",
                Filter = "csv | *.csv"
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