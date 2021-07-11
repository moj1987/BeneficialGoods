using RestSharp;
using RestSharp.Authenticators;

namespace BeneficialGoods.Model
{
    internal class ShopifyResponseDataModel
    {

        const string SHOPIFY_URL = "https://315b4347d6b30b86a1fd63ec6feb0abf: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@beneficial-goods.myshopify.com/";
        const string APP_ID = "315b4347d6b30b86a1fd63ec6feb0abf";
        const string APP_PASSWORD = "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";

        /// <summary>
        /// This method get the orders data from shopify.
        /// </summary>
        /// <returns>Json Response Object</returns>
        private IRestResponse GetResponse()
        {
            var client = new RestClient(SHOPIFY_URL);
            client.Authenticator = new HttpBasicAuthenticator(APP_ID, APP_PASSWORD);
            client.Timeout = -1;
            var request = new RestRequest("admin/api/2021-04/orders.json?created_at_min=2021-05-01T00:00:00-04:00&created_at_max=2021-05-31T00:00:00-04:00&status=any&fields=line_items,created_at,financial_status", Method.GET, DataFormat.Json);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}