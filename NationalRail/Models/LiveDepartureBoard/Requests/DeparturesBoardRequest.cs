using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class DeparturesBoardRequest
    {
        public DeparturesBoardRequest()
        {
            FilterList = new FilterList();
        }

        [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public string Crs { get; set; }

        [XmlElement(ElementName = "filterList", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public FilterList FilterList { get; set; }

        [XmlElement(ElementName = "timeOffset", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public int? TimeOffset { get; set; }

        [XmlElement(ElementName = "timeWindow", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public int? TimeWindow { get; set; }
    }
}
