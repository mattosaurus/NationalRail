using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ArrivalBoardDetailsResponse
    {
        [XmlRoot(ElementName = "location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public class Location
        {
            [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string LocationName { get; set; }

            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Crs { get; set; }
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
            [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string LocationName { get; set; }

            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Crs { get; set; }

            [XmlElement(ElementName = "st", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string St { get; set; }

            [XmlElement(ElementName = "at", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string At { get; set; }
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
            [XmlElement(ElementName = "sta", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Sta { get; set; }

            [XmlElement(ElementName = "eta", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Eta { get; set; }

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

            [XmlElement(ElementName = "previousCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public PreviousCallingPoints PreviousCallingPoints { get; set; }
        }

        [XmlRoot(ElementName = "trainServices", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public class TrainServices
        {
            [XmlElement(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public Service Service { get; set; }
        }

        [XmlRoot(ElementName = "GetStationBoardResult", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetStationBoardResult
        {
            [XmlElement(ElementName = "generatedAt", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string GeneratedAt { get; set; }

            [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string LocationName { get; set; }

            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Crs { get; set; }

            [XmlElement(ElementName = "platformAvailable", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string PlatformAvailable { get; set; }

            [XmlElement(ElementName = "trainServices", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public TrainServices TrainServices { get; set; }
        }

        [XmlRoot(ElementName = "GetArrBoardWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetArrBoardWithDetailsResponse
        {
            [XmlElement(ElementName = "GetStationBoardResult", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetStationBoardResult GetStationBoardResult { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            [XmlElement(ElementName = "GetArrBoardWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetArrBoardWithDetailsResponse GetArrBoardWithDetailsResponse { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
        }
    }
}
