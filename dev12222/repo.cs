using System;

namespace WebAPIClient
{
    public class CriptoAsset
    {
        public string name { get; set; }
        public string symbol { get; set; }
        public double current_price { get; set; }
        public double market_cap_rank { get; set; }
        public double market_cap { get; set; }
        public double image { get; set; }
        public double price_change_percentage_24h { get; set; }
        public double high_24h { get; set; }
        public double low_24h { get; set; }
        public double circulating_supply { get; set; }
        public double ath { get; set; }   
    }
}