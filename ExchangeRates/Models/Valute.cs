﻿using System;
using System.Collections.Generic;

namespace ExchangeRates.Models
{
    public class Status
    {
        public System.DateTime timestamp { get; set; }
        public int error_code { get; set; }
        public object error_message { get; set; }
        public int elapsed { get; set; }
        public int credit_count { get; set; }
    }

    public class Platform
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public string token_address { get; set; }
    }

    public class USD
    {
        public double? price { get; set; }
        public double? volume_24h { get; set; }
        public double? percent_change_1h { get; set; }
        public double? percent_change_24h { get; set; }
        public double? percent_change_7d { get; set; }
        public double? market_cap { get; set; }
        public DateTime last_updated { get; set; }
    }

    public class Quote
    {
        public USD USD { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string slug { get; set; }
        public double? circulating_supply { get; set; }
        public double? total_supply { get; set; }
        public double? max_supply { get; set; }
        public DateTime date_added { get; set; }
        public int num_market_pairs { get; set; }
        public List<object> tags { get; set; }
        public Platform platform { get; set; }
        public int? cmc_rank { get; set; }
        public DateTime last_updated { get; set; }
        public Quote quote { get; set; }
    }

    public class RootObject
    {
        public Status status { get; set; }
        public List<Datum> data { get; set; }
    }
}