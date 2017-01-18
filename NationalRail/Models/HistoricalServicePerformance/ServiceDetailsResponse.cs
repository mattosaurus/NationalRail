using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class ServiceDetailsResponse
    {
        [JsonProperty("serviceAttributesDetails")]
        public ServiceAttributesDetails ServiceAttributesDetails { get; set; }
    }
}
