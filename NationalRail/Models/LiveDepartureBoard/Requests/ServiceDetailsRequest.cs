using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ServiceDetailsRequest
    {
        [XmlRoot(ElementName = "GetServiceDetailsRequest", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
        public class GetServiceDetailsRequest
        {
            [XmlElement(ElementName = "serviceID", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public string ServiceID { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Body
        {
            public Body()
            {
                GetServiceDetailsRequest = new GetServiceDetailsRequest();
            }

            [XmlElement(ElementName = "GetServiceDetailsRequest", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/")]
            public GetServiceDetailsRequest GetServiceDetailsRequest { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public class Envelope
        {
            public Envelope()
            {
                Header = new Header();
                Body = new Body();
            }

            [XmlElement(ElementName = "Header", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Header Header { get; set; }

            [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
            public Body Body { get; set; }
        }
    }
}
