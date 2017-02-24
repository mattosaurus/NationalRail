using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NationalRail;
using NationalRail.Models.LiveDepartureBoard;
using NationalRail.Models.HistoricalServicePerformance;

namespace NationalRailTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Historical Data
            HistoricalServicePerformanceClient historicalClient = new HistoricalServicePerformanceClient("{EMAILADDRESS}", "{PASSWORD}");

            ServiceMetric metric = new ServiceMetric();

            metric.FromLocation = "BTN";
            metric.ToLocation = "VIC";
            metric.FromTime = "0700";
            metric.ToTime = "0800";
            metric.FromDate = "2016-07-01";
            metric.ToDate = "2016-07-01";
            metric.Days = "WEEKDAY";

            ServiceMetricResponse historicalResponse = historicalClient.GetServiceMetrics(metric).Result;

            foreach (NationalRail.Models.HistoricalServicePerformance.Service service in historicalResponse.Services)
            {
                foreach(string rid in service.ServiceAttributesMetrics.RIDs)
                {
                    NationalRail.Models.HistoricalServicePerformance.ServiceDetailsResponse details = historicalClient.GetServiceDetails(new ServiceDetailsRID(rid)).Result;
                }
            }

            // Live Data
            string token = "{TOKEN}";

            LiveDepartureBoardClient liveClient = new LiveDepartureBoardClient(token);

            NextDepartureRequest.Body liveBody = new NextDepartureRequest.Body();

            liveBody.GetNextDeparturesRequest.Crs = "LDS";
            liveBody.GetNextDeparturesRequest.FilterList.Crs.Add("DON");
            liveBody.GetNextDeparturesRequest.TimeOffset = 0;
            liveBody.GetNextDeparturesRequest.TimeWindow = 120;

            NextDepartureResponse.Envelope liveResponse = liveClient.GetNextDeparture(liveBody).Result;
        }
    }
}
