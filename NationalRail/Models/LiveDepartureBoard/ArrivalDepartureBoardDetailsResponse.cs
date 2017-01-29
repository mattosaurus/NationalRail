using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ArrivalDepartureBoardDetailsResponse
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

        [XmlRoot(ElementName = "previousCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class PreviousCallingPoints
        {
            [XmlElement(ElementName = "callingPointList", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public CallingPointList CallingPointList { get; set; }
        }

        [XmlRoot(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class Service
        {
            /// <summary>
            /// The scheduled time of arrival of this service at this location. If no sta is present then this is the origin of this service or it does not set down passengers at this location.
            /// </summary>
            [XmlElement(ElementName = "sta", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Sta { get; set; }

            /// <summary>
            /// The estimated time of arrival. Will only be present if sta is also present and ata is not present.
            /// </summary>
            [XmlElement(ElementName = "eta", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Eta { get; set; }

            /// <summary>
            /// The platform number that the service is expected to use at this location, if known and available.
            /// </summary>
            [XmlElement(ElementName = "platform", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Platform { get; set; }

            /// <summary>
            /// The display name of the Train Operating Company that operates this service.
            /// </summary>
            [XmlElement(ElementName = "operator", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Operator { get; set; }

            /// <summary>
            /// The code of the Train Operating Company that operates this service.
            /// </summary>
            [XmlElement(ElementName = "operatorCode", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string OperatorCode { get; set; }

            /// <summary>
            /// The type of service (train, bus, ferry) that these details represent. Note that real-time information (e.g. eta, etd, ata, atd, isCancelled, etc.) is only available and present for train services.
            /// </summary>
            [XmlElement(ElementName = "serviceType", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string ServiceType { get; set; }

            [XmlElement(ElementName = "serviceID", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string ServiceID { get; set; }

            /// <summary>
            /// The Retail Service ID of the service, if known.
            /// </summary>
            [XmlElement(ElementName = "rsid", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public string Rsid { get; set; }

            [XmlElement(ElementName = "origin", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Origin Origin { get; set; }

            [XmlElement(ElementName = "destination", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Destination Destination { get; set; }

            [XmlElement(ElementName = "previousCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public PreviousCallingPoints PreviousCallingPoints { get; set; }

            /// <summary>
            /// The scheduled time of departure of this service at this location. If no std is present then this is the destination of this service or it does not pick up passengers at this location.
            /// </summary>
            [XmlElement(ElementName = "std", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Std { get; set; }

            /// <summary>
            /// The estimated time of departure. Will only be present if std is also present and atd is not present.
            /// </summary>
            [XmlElement(ElementName = "etd", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Etd { get; set; }

            /// <summary>
            /// A list of lists of CallingPoint objects representing the subsequent calling points in the journey. A separate calling point list will be present for each destination of the service, relative to the current location.
            /// </summary>
            [XmlElement(ElementName = "subsequentCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public SubsequentCallingPoints SubsequentCallingPoints { get; set; }
        }

        [XmlRoot(ElementName = "subsequentCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class SubsequentCallingPoints
        {
            [XmlElement(ElementName = "callingPointList", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public CallingPointList CallingPointList { get; set; }
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
            /// If a filter was requested, the location name of the filter location.
            /// </summary>
            [XmlElement(ElementName = "filterLocationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string FilterLocationName { get; set; }

            /// <summary>
            /// If a filter was requested, the CRS code of the filter location.
            /// </summary>
            [XmlElement(ElementName = "filtercrs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string FilterCrs { get; set; }

            /// <summary>
            /// If a filter was requested, the CRS code of the filter location.
            /// </summary>
            [XmlElement(ElementName = "FilterType", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string FilterType { get; set; }

            /// <summary>
            /// An optional value that indicates if platform information is available. If this value is present with the value "true" then platform information will be returned in the service lists. If this value is not present, or has the value "false", then the platform "heading" should be suppressed in the user interface for this station board.
            /// </summary>
            [XmlElement(ElementName = "platformAvailable", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string PlatformAvailable { get; set; }

            /// <summary>
            /// Each of these lists contains a ServiceItemWithCallingPoints object for each service of the relevant type that is to appear on the station board. Each or all of these lists may contain zero items, or may not be present at all.
            /// </summary>
            [XmlElement(ElementName = "trainServices", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public TrainServices TrainServices { get; set; }
        }

        [XmlRoot(ElementName = "GetArrDepBoardWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetArrDepBoardWithDetailsResponse
        {
            [XmlElement(ElementName = "GetStationBoardResult", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetStationBoardResult GetStationBoardResult { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            [XmlElement(ElementName = "GetArrDepBoardWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetArrDepBoardWithDetailsResponse GetArrDepBoardWithDetailsResponse { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
        }
    }
}
