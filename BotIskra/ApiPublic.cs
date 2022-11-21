using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.Net;
using System.Threading.Tasks;

namespace BotIskra
{
    public static class ApiPublic
    {
        private const string ApiUrlv4 = "https://whitebit.com/api/v4/public";
        private const string ApiUrlv2 = "https://whitebit.com/api/v2/public";
        private static string GetRequest(string url)
        {
            try
            {
                using (var c = new WebClient())
                {
                    c.Encoding = System.Text.Encoding.UTF8;
                    return c.DownloadString(url);
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Get exchages pairs
        /// </summary>
        public static ModelsPublic.Pair[] GetPairs()
        {
            var data = GetRequest($"{ApiUrlv2}/ticker");

            if(data == null)
                throw new Exception("Whitebit api connection error");

            var json = JsonConvert.DeserializeObject<ModelsPublic.PairResult>(data);

            if (json == null)
                throw new Exception("The whitebit api response was null");

            return json.result;
        }

 

        public static ModelsPublic.Fee GetFee()
        {
            var data = GetRequest($"{ApiUrlv4}/fee");

            if (data == null)
                throw new Exception("Whitebit api connection error");

            return JsonConvert.DeserializeObject<ModelsPublic.Fee>(data);
        }


    }
}
