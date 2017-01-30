using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ArrivalBoardRequest
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

        [XmlRoot(ElementName = "GetArrivalBoardRequest", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetArrivalBoardRequest
        {
            /// <summary>
            /// The number of services to return in the resulting station board.
            /// </summary>
            [XmlElement(ElementName = "numRows", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public int? NumRows { get; set; }

            /// <summary>
            /// The CRS code (see above) of the location for which the request is being made.
            /// </summary>
            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public string Crs { get; set; }

            /// <summary>
            /// The CRS code of either an origin or destination location to filter in. Optional.
            /// </summary>
            [XmlElement(ElementName = "filterCrs", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public string FilterCrs { get; set; }

            /// <summary>
            /// The type of filter to apply. Filters services to include only those originating or terminating at the filterCrs location. Defaults to "to". Optional.
            /// </summary>
            [XmlElement(ElementName = "filterType", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public string FilterType { get; set; }

            /// <summary>
            /// An offset in minutes against the current time to provide the station board for. Defaults to 0. Optional.
            /// </summary>
            [XmlElement(ElementName = "timeOffset", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public int? TimeOffset { get; set; }

            /// <summary>
            /// How far into the future in minutes, relative to timeOffset, to return services for. Defaults to 120. Optional.
            /// </summary>
            [XmlElement(ElementName = "timeWindow", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public int? TimeWindow { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            public Body()
            {
                GetArrivalBoardRequest = new GetArrivalBoardRequest();
            }

            [XmlElement(ElementName = "GetArrivalBoardRequest", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetArrivalBoardRequest GetArrivalBoardRequest { get; set; }
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
