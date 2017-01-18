using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class Service
    {
        [JsonProperty("serviceAttributesMetrics")]
        public ServiceAttributesMetrics ServiceAttributesMetrics { get; set; }

        [JsonProperty("Metrics")]
        public List<Metric> Metrics { get; set; }
    }
}
