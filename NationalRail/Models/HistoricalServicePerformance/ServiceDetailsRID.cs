using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class ServiceDetailsRID
    {
        public ServiceDetailsRID(string _RID)
        {
            RID = _RID;
        }

        [JsonProperty("rid")]
        public string RID { get; set; }
    }
}
