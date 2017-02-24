using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.HistoricalServicePerformance
{
    public class ServiceDetailsLocation
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("gbtt_ptd")]
        public string PredictedTimeOfDeparture { get; set; }

        [JsonProperty("gbtt_pta")]
        public string PredictedTimeOfArrival { get; set; }

        [JsonProperty("actual_td")]
        public string ActualTimeOfDeparture { get; set; }

        [JsonProperty("actual_ta")]
        public string ActualTimeOfArrival { get; set; }

        [JsonProperty("late_canc_reason")]
        public string LateCancelationReason { get; set; }
    }
}
