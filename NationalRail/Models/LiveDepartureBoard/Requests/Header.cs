using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class Header
    {
        public Header()
        {
            AccessToken = new AccessToken();
        }

        [XmlElement(ElementName = "AccessToken", Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken { get; set; }
    }
}
