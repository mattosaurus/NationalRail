using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
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
}
