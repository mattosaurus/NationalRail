using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class ServiceMetricResponse
    {
        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("Services")]
        public List<Service> Services { get; set; }
    }
}
