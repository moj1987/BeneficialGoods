using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeneficialGoods.Model;
using RestSharp;
using RestSharp.Authenticators;

namespace BeneficialGoods.Networking
{
    internal class NetworkServiceImpl : NetworkService
    {
        private const string SHOPIFY_URL = "https://315b4347d6b30b86a1fd63ec6feb0abf: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@beneficial-goods.myshopify.com/";
        private const string APP_ID = "315b4347d6b30b86a1fd63ec6feb0abf";
        private const string APP_PASSWORD = "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";
        private const string START_DATE = "2021-05-01T00:00:00-04:00";
        private const string END_DATE = "2021-05-31T00:00:00-04:00";

        public string GetOrdersData(string startDate, string endDate)
        {
            try
            {
                return GetOrdersResponse(startDate, endDate).Content;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetProductsData()
        {
            try
            {
                return GetProductResponse().Content;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method get the orders data from shopify.
        /// </summary>
        /// <returns>Json Response Object</returns>
        private IRestResponse GetOrdersResponse(string startDate, string endDate)
        {
            RestClient client = new RestClient(SHOPIFY_URL)
            {
                Authenticator = new HttpBasicAuthenticator(APP_ID, APP_PASSWORD),
                Timeout = -1
            };
            var request = new RestRequest($"admin/api/2021-04/orders.json?created_at_min={startDate}&created_at_max={endDate}&status=any&fields=line_items,created_at,financial_status", Method.GET, DataFormat.Json);
            IRestResponse response = client.Execute(request);
            return response;
        }

        /// <summary>
        /// This REST API will get the all product data.
        /// </summary>
        /// <returns>IRestResponse response json object.</returns>
        private IRestResponse GetProductResponse()
        {
            var client = new RestClient(SHOPIFY_URL);
            client.Authenticator = new HttpBasicAuthenticator(APP_ID, APP_PASSWORD);
            client.Timeout = -1;
            var request = new RestRequest($"admin/api/2021-07/products.json", Method.GET, DataFormat.Json);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}