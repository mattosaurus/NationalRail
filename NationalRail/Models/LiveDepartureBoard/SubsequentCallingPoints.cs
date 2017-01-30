using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class SubsequentCallingPoints
    {
        [XmlElement(ElementName = "callingPointList", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public CallingPointList CallingPointList { get; set; }
    }
}
