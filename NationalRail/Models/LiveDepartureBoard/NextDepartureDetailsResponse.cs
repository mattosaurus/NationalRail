using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class NextDepartureDetailsResponse
    {
        [XmlRoot(ElementName = "location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public class Location
        {
            /// <summary>
            /// The name of the location.
            /// </summary>
            [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string LocationName { get; set; }

            /// <summary>
            /// The CRS code of this location. A CRS code of ??? indicates an error situation where no crs code is known for this location.
            /// </summary>
            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Crs { get; set; }

            /// <summary>
            /// An optional via text that should be displayed after the location, to indicate further information about an ambiguous route. Note that vias are only present for ServiceLocation objects that appear in destination lists
            /// </summary>
            [XmlElement(ElementName = "via", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Via { get; set; }
        }

        [XmlRoot(ElementName = "origin", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class Origin
        {
            [XmlElement(ElementName = "location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public Location Location { get; set; }
        }

        [XmlRoot(ElementName = "destination", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class Destination
        {
            [XmlElement(ElementName = "location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public Location Location { get; set; }
        }

        [XmlRoot(ElementName = "callingPoint", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public class CallingPoint
        {
            /// <summary>
            /// The display name of this location.
            /// </summary>
            [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string LocationName { get; set; }

            /// <summary>
            /// The CRS code of this location. A CRS code of ??? indicates an error situation where no crs code is known for this location.
            /// </summary>
            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Crs { get; set; }

            /// <summary>
            /// The scheduled time of the service at this location. The time will be either an arrival or departure time, depending on whether it is in the subsequent or previous calling point list.
            /// </summary>
            [XmlElement(ElementName = "st", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string St { get; set; }

            /// <summary>
            /// The actual time of the service at this location. The time will be either an arrival or departure time, depending on whether it is in the subsequent or previous calling point list. Will only be present if an estimated time (et) is not present.
            /// </summary>
            [XmlElement(ElementName = "at", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string At { get; set; }

            /// <summary>
            /// The estimated time of the service at this location. The time will be either an arrival or departure time, depending on whether it is in the subsequent or previous calling point list. Will only be present if an actual time (at) is not present.
            /// </summary>
            [XmlElement(ElementName = "et", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Et { get; set; }
        }

        [XmlRoot(ElementName = "callingPointList", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public class CallingPointList
        {
            [XmlElement(ElementName = "callingPoint", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public List<CallingPoint> CallingPoint { get; set; }
        }

        [XmlRoot(ElementName = "subsequentCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class SubsequentCallingPoints
        {
            [XmlElement(ElementName = "callingPointList", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public CallingPointList CallingPointList { get; set; }
        }

        [XmlRoot(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class Service
        {
            [XmlElement(ElementName = "std", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Std { get; set; }

            [XmlElement(ElementName = "etd", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Etd { get; set; }

            [XmlElement(ElementName = "platform", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Platform { get; set; }

            [XmlElement(ElementName = "operator", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Operator { get; set; }

            [XmlElement(ElementName = "operatorCode", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string OperatorCode { get; set; }

            [XmlElement(ElementName = "serviceType", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string ServiceType { get; set; }

            [XmlElement(ElementName = "serviceID", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string ServiceID { get; set; }

            [XmlElement(ElementName = "rsid", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public string Rsid { get; set; }

            [XmlElement(ElementName = "origin", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Origin Origin { get; set; }

            [XmlElement(ElementName = "destination", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Destination Destination { get; set; }

            [XmlElement(ElementName = "subsequentCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public SubsequentCallingPoints SubsequentCallingPoints { get; set; }
        }

        [XmlRoot(ElementName = "departures", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class Departures
        {
            [XmlElement(ElementName = "destination", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Destination Destination { get; set; }
        }

        [XmlRoot(ElementName = "DeparturesBoard", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class DeparturesBoard
        {
            /// <summary>
            /// The time at which the station board was generated.
            /// </summary>
            [XmlElement(ElementName = "generatedAt", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string GeneratedAt { get; set; }

            /// <summary>
            /// The name of the location that the station board is for.
            /// </summary>
            [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string LocationName { get; set; }

            /// <summary>
            /// The CRS code of the location that the station board is for.
            /// </summary>
            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Crs { get; set; }

            /// <summary>
            /// An optional value that indicates if platform information is available. If this value is present with the value "true" then platform information will be returned in the service lists. If this value is not present, or has the value "false", then the platform "heading" should be suppressed in the user interface for this station board.
            /// </summary>
            [XmlElement(ElementName = "platformAvailable", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string PlatformAvailable { get; set; }

            [XmlElement(ElementName = "departures", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Departures Departures { get; set; }
        }

        [XmlRoot(ElementName = "GetNextDeparturesWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetNextDeparturesWithDetailsResponse
        {
            [XmlElement(ElementName = "DeparturesBoard", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public DeparturesBoard DeparturesBoard { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            [XmlElement(ElementName = "GetNextDeparturesWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetNextDeparturesWithDetailsResponse GetNextDeparturesWithDetailsResponse { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
        }
    }
}
