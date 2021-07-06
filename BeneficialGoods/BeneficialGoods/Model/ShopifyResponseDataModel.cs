using BeneficialGoods.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace BeneficialGoods.Model
{
    internal class ShopifyResponseDataModel
    {
        public ShopifyResponseDataModel()
        {
            
            var client = new RestClient("https://315b4347d6b30b86a1fd63ec6feb0abf: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@beneficial-goods.myshopify.com/");
            client.Authenticator = new HttpBasicAuthenticator("315b4347d6b30b86a1fd63ec6feb0abf", "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");

            client.Timeout = -1;
            var request = new RestRequest("admin/api/2021-04/orders.json", Method.GET, DataFormat.Json);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            //var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

            //var timeline = await client.GetAsync<HomeTimeline>(request, cancellationToken);

        }
        //get the data from Shopify via REST apis.
        public static async Task<RegInfoResponseObj> GetRegInfo()
        {
            // Initialization.  
            RegInfoResponseObj responseObj = new RegInfoResponseObj();

            try
            {
                // Posting.  
                using (var client = new HttpClient())
                {
                    // Setting Base address.  
                    client.BaseAddress = new Uri("https://315b4347d6b30b86a1fd63ec6feb0abf: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@beneficial-goods.myshopify.com/admin/api/2021-04/orders.json");

                    // Setting content type.  
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Setting timeout.  
                    client.Timeout = TimeSpan.FromSeconds(Convert.ToDouble(1000000));

                    // Initialization.  
                    HttpResponseMessage response = new HttpResponseMessage();

                    // HTTP POST  
                    response = await client.GetAsync("admin/api/2021-04/orders.json").ConfigureAwait(false);

                    // Verification  
                    if (response.IsSuccessStatusCode)
                    {
                        // Reading Response.  
                        string result = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine(result);
                        //responseObj = JsonConvert.DeserializeObject<RegInfoResponseObj>(result);

                        // Releasing.  
                        response.Dispose();
                    }
                    else
                    {
                        // Reading Response.  
                        string result = response.Content.ReadAsStringAsync().Result;
                        responseObj.code = 602;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return responseObj;
        }

    }
}