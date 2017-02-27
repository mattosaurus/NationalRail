# NationalRail
.NET Core wrapper to query the National Rail APIs for historical and live information.

# Installation
To use NationalRail in your C# project, you can either download the NationalRail C# .NET libraries directly from the Github repository or, if you have the NuGet package manager installed, you can grab them automatically.

```
PM> Install-Package NationalRail
```
Once you have the NationalRail libraries properly referenced in your project, you can include calls to them in your code.

Add the following namespaces to use the library:

```C#
using NationalRail;
using NationalRail.Models.LiveDepartureBoard;
using NationalRail.Models.HistoricalServicePerformance;
```
# Dependencies
Seperate accounts are need to access the <a href="http://realtime.nationalrail.co.uk/OpenLDBWSRegistration/" alt="live data">live data</a> and <a href="https://datafeeds.nationalrail.co.uk/#/" alt="">historical data</a>. An overview of the National Rail data sources can be found <a href="http://www.nationalrail.co.uk/100296.aspx" alt="national rail api">here</a>.

# Usage
The below code can be used in a .NET Core project, a test project is also included in the GitHub solution.

```C#
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
```

# References
A description of the historical service API can be found <a href="http://wiki.openraildata.com/index.php/HSP" alt="historical API description">here</a> and a description of the live API <a href="http://nrodwiki.rockshore.net/index.php/NRE_Darwin_Web_Service_(Public)" alt="live API description">here</a>.
