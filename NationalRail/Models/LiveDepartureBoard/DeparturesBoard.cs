using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
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
        /// If a filter was requested, the type of filter.
        /// </summary>
        [XmlElement(ElementName = "filterType", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string FilterType { get; set; }

        /// <summary>
        /// An optional value that indicates if platform information is available. If this value is present with the value "true" then platform information will be returned in the service lists. If this value is not present, or has the value "false", then the platform "heading" should be suppressed in the user interface for this station board.
        /// </summary>
        [XmlElement(ElementName = "platformAvailable", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? PlatformAvailable { get; set; }

        /// <summary>
        /// An optional value that indicates if services are currently available for this station board. If this value is present with the value "false" then no services will be returned in the service lists. This value may be set, for example, if access to a station has been closed to the public at short notice, even though the scheduled services are still running. It would be usual in such cases for one of the nrccMessages to describe why the list of services has been suppressed.
        /// </summary>
        [XmlElement(ElementName = "areServicesAvailable", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool? AreServicesAvailable { get; set; }

        /// <summary>
        /// The DepartureItem object for each service that is to appear on the station board. A DepartureItem will exist for each CRS code requested in the filter but if no information is available the ServiceItem part will be empty
        /// </summary>
        [XmlElement(ElementName = "departures", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public Departures Departures { get; set; }
    }
}
