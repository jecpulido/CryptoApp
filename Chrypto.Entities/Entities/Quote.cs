using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrypto.Entities.Entities
{
    public partial class Quote
    {
        [JsonProperty("USD")]
        public Usd Usd { get; set; }
    }

    public partial class Usd
    {
        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("volume_24h")]
        public double Volume24H { get; set; }

        [JsonProperty("volume_change_24h")]
        public double VolumeChange24H { get; set; }

        [JsonProperty("percent_change_1h")]
        public double PercentChange1H { get; set; }

        [JsonProperty("percent_change_24h")]
        public double PercentChange24H { get; set; }

        [JsonProperty("percent_change_7d")]
        public double PercentChange7D { get; set; }

        [JsonProperty("percent_change_30d")]
        public double PercentChange30D { get; set; }

        [JsonProperty("percent_change_60d")]
        public double PercentChange60D { get; set; }

        [JsonProperty("percent_change_90d")]
        public double PercentChange90D { get; set; }

        [JsonProperty("market_cap")]
        public double MarketCap { get; set; }

        [JsonProperty("market_cap_dominance")]
        public double MarketCapDominance { get; set; }

        [JsonProperty("fully_diluted_market_cap")]
        public double FullyDilutedMarketCap { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }
    }
}
