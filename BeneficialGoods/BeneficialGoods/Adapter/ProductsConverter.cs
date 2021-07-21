using BeneficialGoods.Model;
using BeneficialGoods.Networking;
using System.Collections.Generic;
using System.Text.Json;

namespace BeneficialGoods.Adapter
{
    internal class ProductsConverter
    {
        private NetworkServiceImpl networkServiceImpl = new NetworkServiceImpl();
        private List<ProductDataModel> reportProducts = new List<ProductDataModel>();

        public List<ProductDataModel> GetProduct()
        {
            var jsonString = networkServiceImpl.GetProductsData();

            ProductsListModel productsList = JsonSerializer.Deserialize<ProductsListModel>(jsonString);

            var allProducts = productsList.products;

            ///////////////////////////
            ///TODO: Take the first tag
            //////////////////////////

            foreach (ProductsItemModel p in allProducts)
            {
                ProductDataModel products = new ProductDataModel(p.id, p.vendor, p.tags);
                reportProducts.Add(products);
            }
            return reportProducts;
        }
    }
}