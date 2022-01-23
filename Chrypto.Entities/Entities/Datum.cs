using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrypto.Entities.Entities
{
    //public partial class Datum
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public string Symbol { get; set; }
    //    public string Slug { get; set; }
    //    public long? CmcRank { get; set; }
    //    public long NumMarketPairs { get; set; }
    //    public long CirculatingSupply { get; set; }
    //    public long TotalSupply { get; set; }
    //    public long MaxSupply { get; set; }
    //    public string last_updated { get; set; }
    //    public string date_added { get; set; }
    //    public List<string> Tags { get; set; }
    //    public object Platform { get; set; }
    //    public Dictionary<string, Quote> Quote { get; set; }
    //}


    public partial class Datum
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("num_market_pairs")]
        public long NumMarketPairs { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("max_supply")]
        public long? MaxSupply { get; set; }

        [JsonProperty("circulating_supply")]
        public double CirculatingSupply { get; set; }

        [JsonProperty("total_supply")]
        public double TotalSupply { get; set; }

        [JsonProperty("platform")]
        public object Platform { get; set; }

        [JsonProperty("cmc_rank")]
        public long CmcRank { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("quote")]
        public Quote Quote { get; set; }
    }
}
