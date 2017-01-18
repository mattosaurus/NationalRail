using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class ServiceAttributesDetails
    {
        [JsonProperty("date_of_service")]
        public string DateOfService { get; set; }

        [JsonProperty("toc_code")]
        public string TocCode { get; set; }

        [JsonProperty("rid")]
        public string RID { get; set; }

        [JsonProperty("locations")]
        public List<ServiceDetailsLocation> Locations { get; set; }
    }
}
