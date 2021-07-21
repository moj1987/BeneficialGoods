using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Data;
using Newtonsoft.Json.Linq;
using BeneficialGoods.Model;
using BeneficialGoods.Utilities;

namespace BeneficialGoods.Adapter
{
    class ProductsConverter
    {
        
        public List<ProductDataModel> GetProduct()
        {
            ProductItemsModel product = JsonSerializer.Deserialize<ProductItemsModel>(SampleProductString.GetSampleProducts());
            var allProducts = product.products.ToList();
            List<ProductDataModel> reportProducts = new List<ProductDataModel>();
            foreach (ProductDataModel p in allProducts)
            {
                ProductDataModel products = new ProductDataModel(p.ProductId, p.Vendor, p.Tags);
                reportProducts.Add(products);
            }
            return reportProducts;
        }

    }
}
