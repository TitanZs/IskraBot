using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BotIskra
{
    public class ModelsPublic
    {
        public class Pair
        {
            public DateTime lastUpdateTimestamp { get; set; }
            public string tradingPairs { get; set; }
            public string lastPrice { get; set; }
            public string lowestAsk { get; set; }
            public string highestBid { get; set; }
            public string baseVolume24h { get; set; }
            public string quoteVolume24h { get; set; }
            public bool tradesEnabled { get; set; }
        }   
        public class PairResult
        {
            public bool success { get; set; }
            public object message { get; set; }
            public Pair[] result { get; set; }
        }
        public class FeeObject
        {
            public bool is_depositable { get; set; }
            public bool is_withdrawal { get; set; }
            public string ticker { get; set; }
            public string name { get; set; }
            public List<object> providers { get; set; }
            public FeeWithdraw withdraw { get; set; }
            public FeeDeposit deposit { get; set; }
        }
        public class FeeWithdraw
        {
            public string max_amount { get; set; }
            public string min_amount { get; set; }
            public string @fixed { get; set; }
            public object flex { get; set; }
        }
        public class FeeDeposit
        {
            public string max_amount { get; set; }
            public string min_amount { get; set; }
            public object @fixed { get; set; }
            public object flex { get; set; }
        }

        public class Fee
        {
            [JsonProperty("USDT (BEP20)")]
            public FeeObject USDT_BEP20 { get; set; }

            [JsonProperty("USDT (EOS)")]
            public FeeObject USDT_EOS { get; set; }

            [JsonProperty("USDT (ERC20)")]
            public FeeObject USDT_ERC20 { get; set; }

            [JsonProperty("USDT (OMNI)")]
            public FeeObject USDT_OMNI { get; set; }

            [JsonProperty("USDT (TRC20)")]
            public FeeObject USDT_TRC20 { get; set; }
            public FeeObject ETH { get; set; }
            public FeeObject BTC { get; set; }
            public FeeObject CCOH { get; set; }

        }


        public class ticker
        {
            public string bid { get; set; }
            public string ask { get; set; }
            public string low { get; set; }
            public string high { get; set; }
            public string last { get; set; }
            public string vol { get; set; }
            public string deal { get; set; }
            public string change { get; set; }

        }

        public class BTC_USDT
        {
            public ticker ticker { get; set; }
        }
        public class result
        {
            public ticker CCOH_BTC { get; set; }
        }
        public class Trade
        {
            public string message { get; set; }
            public string success { get; set; }
            public result result { get; set; }
        }

    }
}
