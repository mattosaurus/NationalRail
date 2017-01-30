using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ServiceWithCallingPoints
    {
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

        /// <summary>
        /// An optional list of ServiceLocation objects giving live/current origins of this service which is not starting at original cancelled origins. Note that a service may have more than one live origin. if the service comprises of multiple trains that join at a previous location in the schedule. Live Origins will only be available for Arrival and Arrival & Departure station boards
        /// </summary>
        [XmlElement(ElementName = "currentOrigins", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public Origin CurrentOrigins { get; set; }

        /// <summary>
        /// An optional list of ServiceLocation objects giving live/current destinations of this service which is not ending at original cancelled destinations. Note that a service may have more than one live destination, if the service comprises of multiple trains that divide at a subsequent location in the schedule. Live Destinations will only be available for Departure and Arrival & Departure station boards.
        /// </summary>
        [XmlElement(ElementName = "currentDestinations", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public Destination CurrentDestinations { get; set; }

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
        /// An optional Scheduled Time of Departure of the service at the station board location. Departure times will only be available for Departure and Arrival & Departure station boards but may also not be present at locations that are not scheduled to depart at the location (e.g. the destination).
        /// </summary>
        [XmlElement(ElementName = "std", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string Std { get; set; }

        /// <summary>
        /// An optional Estimated Time of Departure of the service at the station board location. Departure times will only be available for Departure and Arrival & Departure station boards and only where an std time is present.
        /// </summary>
        [XmlElement(ElementName = "etd", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string Etd { get; set; }

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
        /// If this value is present and has the value "true" then the service is operating on a circular route through the network and will call again at this location later on its journey. The user interface should indicate this fact to the user, to help them choose the correct service from a set of similar alternatives.
        /// </summary>
        [XmlElement(ElementName = "isCircularRoute", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? IsCircularRoute { get; set; }

        /// <summary>
        /// A flag to indicate that this service is cancelled at this location.
        /// </summary>
        [XmlElement(ElementName = "isCancelled", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? IsCancelled { get; set; }

        /// <summary>
        /// A flag to indicate that this service is no longer stopping at the requested from/to filter location.
        /// </summary>
        [XmlElement(ElementName = "filterLocationCancelled", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string FilterLocationCancelled { get; set; }

        /// <summary>
        /// The type of service (train, bus, ferry) that this item represents. Note that real-time information (e.g. eta, etd, ata, atd, etc.) is only available and present for train services.
        /// </summary>
        [XmlElement(ElementName = "serviceType", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string ServiceType { get; set; }

        /// <summary>
        /// The train length (number of units) at this location. If not supplied, or zero, the length is unknown.
        /// </summary>
        [XmlElement(ElementName = "length", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public int Length { get; set; }

        /// <summary>
        /// 	True if the service detaches units from the front at this location.
        /// </summary>
        [XmlElement(ElementName = "detachFront", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? DetachFront { get; set; }

        /// <summary>
        /// True if the service is operating in the reverse of its normal formation.
        /// </summary>
        [XmlElement(ElementName = "isReverseFormation", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? IsReverseFormation { get; set; }

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
        /// The unique service identifier of this service relative to the station board on which it is displayed. This value can be passed to GetServiceDetails to obtain the full details of the individual service.
        /// </summary>
        [XmlElement(ElementName = "serviceID", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string ServiceID { get; set; }

        /// <summary>
        /// A list of Adhoc Alerts related to this location for this service. This list contains an object called AdhocAlertTextType which contains a string to show the Adhoc Alert Text for the location.
        /// </summary>
        [XmlElement(ElementName = "adhocAlerts", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public List<string> AdhocAlerts { get; set; }
    }
}
