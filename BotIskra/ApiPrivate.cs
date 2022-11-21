using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.Net;
using System.Threading.Tasks;

namespace BotIskra
{
    public class ApiPrivate
    {
        private const string ApiUrl = "https://whitebit.com";
        private string ApiKey = null;
        private string ApiSecret = null;
        public ApiPrivate(string key, string secret )
        {
            ApiKey = key;
            ApiSecret = secret;
        }
        private async Task<string> GetRequest(string url, ExpandoObject payload)
        {
            if (ApiKey == null)
                throw new ArgumentNullException("Whitebit ApiKey was null.");

            if (ApiSecret == null)
                throw new ArgumentNullException("Whitebit ApiSecret was null.");

            if (url == null)
                throw new ArgumentNullException("Whitebit Url was null.");

            return await PrivateRequest.Get(ApiKey, ApiSecret, ApiUrl, url, payload);
        }
        /*public async Task<Models.WithDraw> CreateWithDraw(double amount = 0, string address  = "", string uniqueId = "")
        {
            dynamic payload = new ExpandoObject();
            payload.ticker = "USDT";
            payload.amount = amount.ToString(); 
            payload.address = address;
            payload.uniqueId = uniqueId;
            payload.network = "ERC20";
            
            try
            {
                var resp = await GetRequest("/api/v4/main-account/withdraw", payload);
                if (resp != "[]")
                    return JsonConvert.DeserializeObject<Models.WithDraw>(resp);
                else
                    return null;
            }
            catch (Exception d)
            { return null;  }
            
        }*/
        public async Task<ModelsPrivate.TrateBalance> GetMainBalance()
        {
            dynamic payload = new ExpandoObject();

            var resp = await GetRequest("/api/v4/trade-account/balance", payload);
            return JsonConvert.DeserializeObject<ModelsPrivate.TrateBalance>(resp);
        }
        public async Task<ModelsPrivate.MainHistory> CreateOrder(int count_draw, string buy, decimal trade)
        {
            Random rnd = new Random();
            dynamic payload = new ExpandoObject();
            payload.market = "CCOH_BTC";                              
            payload.side = buy;                                  
            payload.amount = count_draw.ToString();
            //payload.activation_price = "0.0000005";
            payload.price = trade;
            payload.clientOrderId = rnd.Next(1000000, 900000000).ToString();

            var ret =  await GetRequest("/api/v4/order/new", payload);
            return ret;
            //return JsonConvert.DeserializeObject<Models.MainHistory>(resp);
        }

     
    }
}
