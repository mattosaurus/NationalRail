using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class NextDepartureResponse
    {
        [XmlRoot(ElementName = "GetNextDeparturesResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetNextDeparturesResponse
        {
            [XmlElement(ElementName = "DeparturesBoard", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public DeparturesBoard DeparturesBoard { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            [XmlElement(ElementName = "GetNextDeparturesResponse", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetNextDeparturesResponse GetNextDeparturesResponse { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
        }
    }
}
