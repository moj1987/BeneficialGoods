using BeneficialGoods.Model;
using BeneficialGoods.Networking;
using System.Collections.Generic;
using System.Text.Json;

namespace BeneficialGoods.Adapter
{
    internal static class ProductsConverter
    {
        private static NetworkServiceImpl networkServiceImpl = new NetworkServiceImpl();
        private static List<ProductDataModel> reportProducts = new List<ProductDataModel>();

        public static List<ProductDataModel> GetProducts()
        {
            var jsonString = networkServiceImpl.GetProductsData();

            ProductsListModel productsList = JsonSerializer.Deserialize<ProductsListModel>(jsonString);

            var allProducts = productsList.products;

            foreach (ProductsItemModel p in allProducts)
            {
                string firstTag = p.tags.Split(',')[0];

                ProductDataModel products = new ProductDataModel(p.id, p.vendor, firstTag);
                reportProducts.Add(products);
            }
            return reportProducts;
        }
    }
}