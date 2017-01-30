using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
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

        /// <summary>
        /// The actual time of the service at this location. The time will be either an arrival or departure time, depending on whether it is in the subsequent or previous calling point list. Will only be present if an estimated time (et) is not present.
        /// </summary>
        [XmlElement(ElementName = "at", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string At { get; set; }

        /// <summary>
        /// A flag to indicate that this service is cancelled at this location.
        /// </summary>
        [XmlElement(ElementName = "isCancelled", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? IsCancelled { get; set; }

        /// <summary>
        /// The train length (number of units) at this location. If not supplied, or zero, the length is unknown.
        /// </summary>
        [XmlElement(ElementName = "length", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public int? Length { get; set; }

        /// <summary>
        /// True if the service detaches units from the front at this location.
        /// </summary>
        [XmlElement(ElementName = "detachFront", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? DetachFront { get; set; }

        /// <summary>
        /// A list of active Adhoc Alert texts for to this location. This list contains an object called AdhocAlertTextType which contains a string to show the Adhoc Alert Text for the locaiton.
        /// </summary>
        [XmlElement(ElementName = "adhocAlerts", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public List<string> AdhocAlerts { get; set; }
    }
}
