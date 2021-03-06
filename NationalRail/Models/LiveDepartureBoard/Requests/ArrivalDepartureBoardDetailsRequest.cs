﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ArrivalDepartureBoardDetailsRequest
    {
        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            public Body()
            {
                GetArrDepBoardWithDetailsRequest = new StationBoardRequest();
            }

            [XmlElement(ElementName = "GetArrDepBoardWithDetailsRequest", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public StationBoardRequest GetArrDepBoardWithDetailsRequest { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            public Envelope()
            {
                Header = new Header();
                Body = new Body();
            }

            [XmlElement(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Header Header { get; set; }

            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
        }
    }
}
