﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NationalRail.Models.LiveDepartureBoard
{
    public class ServicesWithCallingPoints
    {
        [XmlElement(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
        public List<ServiceWithCallingPoints> Service { get; set; }
    }
}
