﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class DepartureBoardRequest
    {
        [XmlRoot(ElementName = "AccessToken", Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public class AccessToken
        {
            [XmlElement(ElementName = "TokenValue", Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
            public string TokenValue { get; set; }
        }

        [XmlRoot(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Header
        {
            public Header()
            {
                AccessToken = new AccessToken();
            }

            [XmlElement(ElementName = "AccessToken", Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
            public AccessToken AccessToken { get; set; }
        }

        [XmlRoot(ElementName = "GetDepartureBoardRequest", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetDepartureBoardRequest
        {
            [XmlElement(ElementName = "numRows", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public int? NumRows { get; set; }

            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public string Crs { get; set; }

            [XmlElement(ElementName = "filterCrs", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public string FilterCrs { get; set; }

            [XmlElement(ElementName = "filterType", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public string FilterType { get; set; }

            [XmlElement(ElementName = "timeOffset", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public int? TimeOffset { get; set; }

            [XmlElement(ElementName = "timeWindow", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public int? TimeWindow { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            public Body()
            {
                GetDepartureBoardRequest = new GetDepartureBoardRequest();
            }

            [XmlElement(ElementName = "GetDepartureBoardRequest", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetDepartureBoardRequest GetDepartureBoardRequest { get; set; }
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
