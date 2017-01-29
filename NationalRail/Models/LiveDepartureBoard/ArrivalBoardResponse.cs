using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ArrivalBoardResponse
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

        [XmlRoot(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class Service
        {
            /// <summary>
            /// An optional Scheduled Time of Arrival of the service at the station board location. Arrival times will only be available for Arrival and Arrival & Departure station boards but may also not be present at locations that are not scheduled to arrive at the location (e.g. the origin).
            /// </summary>
            [XmlElement(ElementName = "sta", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Sta { get; set; }

            /// <summary>
            /// An optional Estimated Time of Arrival of the service at the station board location. Arrival times will only be available for Arrival and Arrival & Departure station boards and only where an sta time is present.
            /// </summary>
            [XmlElement(ElementName = "eta", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Eta { get; set; }

            /// <summary>
            /// An optional platform number for the service at this location. This will only be present where available and where the station board platformAvailable value is "true".
            /// </summary>
            [XmlElement(ElementName = "platform", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Platform { get; set; }

            /// <summary>
            /// The name of the Train Operating Company that operates the service.
            /// </summary>
            [XmlElement(ElementName = "operator", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Operator { get; set; }

            /// <summary>
            /// The code of the Train Operating Company that operates the service.
            /// </summary>
            [XmlElement(ElementName = "operatorCode", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string OperatorCode { get; set; }

            /// <summary>
            /// The type of service (train, bus, ferry) that this item represents. Note that real-time information (e.g. eta, etd, ata, atd, etc.) is only available and present for train services.
            /// </summary>
            [XmlElement(ElementName = "serviceType", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string ServiceType { get; set; }

            /// <summary>
            /// The unique service identifier of this service relative to the station board on which it is displayed. This value can be passed to GetServiceDetails to obtain the full details of the individual service.
            /// </summary>
            [XmlElement(ElementName = "serviceID", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string ServiceID { get; set; }

            /// <summary>
            /// The Retail Service ID of the service, if known.
            /// </summary>
            [XmlElement(ElementName = "rsid", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public string Rsid { get; set; }

            /// <summary>
            /// A list of ServiceLocation objects giving original origins of this service. Note that a service may have more than one original origin, if the service comprises of multiple trains that join at a previous location in the schedule. Original Origins will only be available for Arrival and Arrival & Departure station boards.
            /// </summary>
            [XmlElement(ElementName = "origin", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Origin Origin { get; set; }

            /// <summary>
            /// A list of ServiceLocation objects giving original destinations of this service. Note that a service may have more than one original destination, if the service comprises of multiple trains that divide at a subsequent location in the schedule. Original Destinations will only be available for Departure and Arrival & Departure station boards.
            /// </summary>
            [XmlElement(ElementName = "destination", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Destination Destination { get; set; }
        }

        [XmlRoot(ElementName = "trainServices", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class TrainServices
        {
            [XmlElement(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public List<Service> Service { get; set; }
        }

        [XmlRoot(ElementName = "GetStationBoardResult", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetStationBoardResult
        {
            /// <summary>
            /// The type of service (train, bus, ferry) that this item represents. Note that real-time information (e.g. eta, etd, ata, atd, etc.) is only available and present for train services.
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

            /// <summary>
            /// Each of these lists contains a ServiceItem object for each service of the relevant type that is to appear on the station board. Each or all of these lists may contain zero items, or may not be present at all.
            /// </summary>
            [XmlElement(ElementName = "trainServices", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public TrainServices TrainServices { get; set; }
        }

        [XmlRoot(ElementName = "GetArrivalBoardResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetArrivalBoardResponse
        {
            [XmlElement(ElementName = "GetStationBoardResult", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetStationBoardResult GetStationBoardResult { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            [XmlElement(ElementName = "GetArrivalBoardResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetArrivalBoardResponse GetArrivalBoardResponse { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
        }
    }
}
