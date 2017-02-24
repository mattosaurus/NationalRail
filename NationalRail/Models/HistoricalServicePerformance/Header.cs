using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class Header
    {
        [JsonProperty("from_location")]
        public string FromLocation { get; set; }

        [JsonProperty("to_location")]
        public string ToLocation { get; set; }
    }
}
