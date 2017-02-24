using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class ServiceAttributesMetrics
    {
        [JsonProperty("origin_location")]
        public string OriginLocation { get; set; }

        [JsonProperty("destination_location")]
        public string DestinationLocation { get; set; }

        [JsonProperty("gbtt_ptd")]
        public string DepartureTime { get; set; }

        [JsonProperty("gbtt_pta")]
        public string ArrivalTime { get; set; }

        [JsonProperty("toc_code")]
        public string TocCode { get; set; }

        [JsonProperty("matched_services")]
        public string MatchedServices { get; set; }

        [JsonProperty("rids")]
        public List<string> RIDs { get; set; }
    }
}
