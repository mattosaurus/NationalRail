using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NationalRail;
using NationalRail.Models.LiveDepartureBoard;

namespace NationalRailTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string token = "{TOKEN}";

            LiveDepartureBoardClient client = new LiveDepartureBoardClient(token);

            NextDepartureRequest.Body body = new NextDepartureRequest.Body();

            body.GetNextDeparturesRequest.Crs = "LDS";
            body.GetNextDeparturesRequest.FilterList.Crs.Add("DON");
            body.GetNextDeparturesRequest.TimeOffset = 0;
            body.GetNextDeparturesRequest.TimeWindow = 120;

            NextDepartureResponse.Envelope response = client.GetNextDeparture(body).Result;
        }
    }
}
