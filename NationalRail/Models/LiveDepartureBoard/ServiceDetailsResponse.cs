using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ServiceDetailsResponse
    {
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

        [XmlRoot(ElementName = "subsequentCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public class SubsequentCallingPoints
        {
            [XmlElement(ElementName = "callingPointList", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public CallingPointList CallingPointList { get; set; }
        }

        [XmlRoot(ElementName = "GetServiceDetailsResult", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetServiceDetailsResult
        {
            /// <summary>
            /// The time at which the service details were generated.
            /// </summary>
            [XmlElement(ElementName = "generatedAt", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string GeneratedAt { get; set; }

            /// <summary>
            /// The type of service (train, bus, ferry) that these details represent. Note that real-time information (e.g. eta, etd, ata, atd, isCancelled, etc.) is only available and present for train services.
            /// </summary>
            [XmlElement(ElementName = "serviceType", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string ServiceType { get; set; }

            /// <summary>
            /// The display name of the departure board location that these service details were accessed from.
            /// </summary>
            [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string LocationName { get; set; }

            /// <summary>
            /// The CRS code of the departure board location that these service details were accessed from.
            /// </summary>
            [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Crs { get; set; }

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

            [XmlElement(ElementName = "platform", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Platform { get; set; }

            /// <summary>
            /// The scheduled time of departure of this service at this location. If no std is present then this is the destination of this service or it does not pick up passengers at this location.
            /// </summary>
            [XmlElement(ElementName = "std", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Std { get; set; }

            /// <summary>
            /// 	The estimated time of departure. Will only be present if std is also present and atd is not present.
            /// </summary>
            [XmlElement(ElementName = "etd", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public string Etd { get; set; }

            /// <summary>
            /// A list of lists of CallingPoint objects representing the subsequent calling points in the journey. A separate calling point list will be present for each destination of the service, relative to the current location.
            /// </summary>
            [XmlElement(ElementName = "subsequentCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
            public SubsequentCallingPoints SubsequentCallingPoints { get; set; }

            /// <summary>
            /// The Retail Service ID of the service, if known.
            /// </summary>
            [XmlElement(ElementName = "rsid", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
            public string Rsid { get; set; }
        }

        [XmlRoot(ElementName = "GetServiceDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetServiceDetailsResponse
        {
            [XmlElement(ElementName = "GetServiceDetailsResult", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetServiceDetailsResult GetServiceDetailsResult { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            [XmlElement(ElementName = "GetServiceDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetServiceDetailsResponse GetServiceDetailsResponse { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
        }
    }
}
