using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class StationBoardRequest
    {
        /// <summary>
        /// The number of services to return in the resulting station board.
        /// </summary>
        [XmlElement(ElementName = "numRows", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public int? NumRows { get; set; }

        /// <summary>
        /// The CRS code of the location for which the request is being made.
        /// </summary>
        [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public string Crs { get; set; }

        /// <summary>
        /// The CRS code of either an origin or destination location to filter in. Optional.
        /// </summary>
        [XmlElement(ElementName = "filterCrs", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public string FilterCrs { get; set; }

        /// <summary>
        /// The type of filter to apply. Filters services to include only those originating or terminating at the filterCrs location. Defaults to "to". Optional.
        /// </summary>
        [XmlElement(ElementName = "filterType", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public string FilterType { get; set; }

        /// <summary>
        /// An offset in minutes against the current time to provide the station board for. Defaults to 0. Optional.
        /// </summary>
        [XmlElement(ElementName = "timeOffset", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public int? TimeOffset { get; set; }

        /// <summary>
        /// How far into the future in minutes, relative to timeOffset, to return services for. Defaults to 120. Optional.
        /// </summary>
        [XmlElement(ElementName = "timeWindow", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public int? TimeWindow { get; set; }
    }
}
