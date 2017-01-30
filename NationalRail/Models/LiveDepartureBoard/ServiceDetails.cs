using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ServiceDetails
    {
        /// <summary>
        /// The time at which the service details were generated.
        /// </summary>
        [XmlElement(ElementName = "generatedAt", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string GeneratedAt { get; set; }

        /// <summary>
        /// The Retail Service ID of the service, if known.
        /// </summary>
        [XmlElement(ElementName = "rsid", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public string Rsid { get; set; }

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

        /// <summary>
        /// Indicates that the service is cancelled at this location.
        /// </summary>
        [XmlElement(ElementName = "isCancelled", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? IsCancelled { get; set; }

        /// <summary>
        /// A cancellation reason for this service.
        /// </summary>
        [XmlElement(ElementName = "cancelReason", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string CancelReason { get; set; }

        /// <summary>
        /// A delay reason for this service.
        /// </summary>
        [XmlElement(ElementName = "delayReason", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string DelayReason { get; set; }

        /// <summary>
        /// If an expected movement report has been missed, this will contain a message describing the missed movement.
        /// </summary>
        [XmlElement(ElementName = "overdueMessage", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string OverdueMessage { get; set; }

        /// <summary>
        /// The train length (number of units) at this location. If not supplied, or zero, the length is unknown.
        /// </summary>
        [XmlElement(ElementName = "length", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public int? length { get; set; }

        /// <summary>
        /// True if the service detaches units from the front at this location.
        /// </summary>
        [XmlElement(ElementName = "detachFront", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? DetachFront { get; set; }

        /// <summary>
        /// True if the service is operating in the reverse of its normal formation.
        /// </summary>
        [XmlElement(ElementName = "isReverseFormation", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? IsReverseFormation { get; set; }

        /// <summary>
        /// The platform number that the service is expected to use at this location, if known and available.
        /// </summary>
        [XmlElement(ElementName = "platform", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string Platform { get; set; }

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
        /// The actual time of arrival. Will only be present if sta is also present and eta is not present.
        /// </summary>
        [XmlElement(ElementName = "ata", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string Ata { get; set; }

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
        /// The actual time of departure. Will only be present if std is also present and etd is not present.
        /// </summary>
        [XmlElement(ElementName = "atd", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string Atd { get; set; }

        /// <summary>
        /// A list of active Adhoc Alert texts for to this location. This list contains an object called AdhocAlertTextType which contains a string to show the Adhoc Alert Text for the locaiton.
        /// </summary>
        [XmlElement(ElementName = "adhocAlerts", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public List<string> AdhocAlerts { get; set; }

        /// <summary>
        /// A list of lists of CallingPoint objects representing the previous calling points in the journey. A separate calling point list will be present for each origin of the service, relative to the current location
        /// </summary>
        [XmlElement(ElementName = "previousCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public PreviousCallingPoints PreviousCallingPoints { get; set; }

        /// <summary>
        /// A list of lists of CallingPoint objects representing the subsequent calling points in the journey. A separate calling point list will be present for each destination of the service, relative to the current location.
        /// </summary>
        [XmlElement(ElementName = "subsequentCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public SubsequentCallingPoints SubsequentCallingPoints { get; set; }
    }
}
