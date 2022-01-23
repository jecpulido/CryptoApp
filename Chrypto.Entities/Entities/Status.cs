using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrypto.Entities.Entities
{
    public partial class Status
    {
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("error_code")]
        public long ErrorCode { get; set; }

        [JsonProperty("error_message")]
        public object ErrorMessage { get; set; }

        [JsonProperty("elapsed")]
        public long Elapsed { get; set; }

        [JsonProperty("credit_count")]
        public long CreditCount { get; set; }

        [JsonProperty("notice")]
        public object Notice { get; set; }

        [JsonProperty("total_count")]
        public long TotalCount { get; set; }
 
    }
}
