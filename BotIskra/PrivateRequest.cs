using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BotIskra
{
    public static class PrivateRequest
    {
        private static readonly HttpClient _httpClient = new HttpClient();

       
        public static async Task<string> Get(string apiKey, string apiSecret, string hostname, string request, dynamic data)
        {
         
            // If the nonce is similar to or lower than the previous request number, you will receive the 'too many requests' error message
            // nonce is a number that is always higher than the previous request number
            var nonce = GetNonce();
            var nonceWindow = false; // boolean, enable nonce validation in time range of current time +/- 5s, also check if nonce value is unique

            data.nonce =  nonce;
            data.request = request;
            data.nonceWindow = nonceWindow;

            var dataJsonStr = JsonConvert.SerializeObject(data);
            var payload = Base64Encode(dataJsonStr);
            var signature = CalcSignature(payload, apiSecret);

            var content = new StringContent(dataJsonStr, Encoding.UTF8, "application/json");
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{hostname}{request}")
            {
                Content = content
            };
            requestMessage.Headers.Add("X-TXC-APIKEY", apiKey);
            requestMessage.Headers.Add("X-TXC-PAYLOAD", payload);
            requestMessage.Headers.Add("X-TXC-SIGNATURE", signature);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        private static string CalcSignature(string text, string apiSecret)
        {
            using (var hmac = new HMACSHA512(Encoding.UTF8.GetBytes(apiSecret)))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            }
        }
        private static string GetNonce()
        {
            //Thread.Sleep(5000);
            var milliseconds = (long)DateTime.Now.ToUniversalTime()
                .Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
                .TotalMilliseconds;

            return milliseconds.ToString();
        }
    }
}
