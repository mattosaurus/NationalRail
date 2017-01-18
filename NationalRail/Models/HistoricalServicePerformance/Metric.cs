using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class Metric
    {
        [JsonProperty("tolerance_value")]
        public string ToleranceValue { get; set; }

        [JsonProperty("num_not_tolerance")]
        public string NumberNotTolerance { get; set; }

        [JsonProperty("num_tolerance")]
        public string NumberTolerance { get; set; }

        [JsonProperty("percent_tolerance")]
        public string PercentTolerance { get; set; }

        [JsonProperty("global_tolerance")]
        public bool GlobalTolerance { get; set; }
    }
}
