﻿using System;
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
            string token = "1c25fca1-5338-4d10-8267-66eadd92c37c";

            LiveDepartureBoardClient client = new LiveDepartureBoardClient(token);

            DepartureBoardRequest.Body body = new DepartureBoardRequest.Body();

            body.GetDepartureBoardRequest.NumRows = 2;
            body.GetDepartureBoardRequest.Crs = "LDS";
            body.GetDepartureBoardRequest.FilterType = "to";
            body.GetDepartureBoardRequest.TimeOffset = 0;
            body.GetDepartureBoardRequest.TimeWindow = 120;

            DepartureBoardResponse.Envelope response = client.GetDepartureBoard(body).Result;
        }
    }
}