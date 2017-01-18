using NationalRail.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NationalRail.Models.HistoricalServicePerformance
{
    public class ServiceMetric
    {
        [JsonProperty("from_loc")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Station FromLocation { get; set; }

        [JsonProperty("to_loc")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Station ToLocation { get; set; }

        [JsonProperty("from_time")]
        public string FromTime { get; set; }

        [JsonProperty("to_time")]
        public string ToTime { get; set; }

        [JsonProperty("from_date")]
        public string FromDate { get; set; }

        [JsonProperty("to_date")]
        public string ToDate { get; set; }

        [JsonProperty("days")]
        public string Days { get; set; }

        [JsonProperty("toc_filter")]
        public List<string> TocFilter { get; set; }

        [JsonProperty("tolerence")]
        public List<int> Tolerence { get; set; }
    }
}
