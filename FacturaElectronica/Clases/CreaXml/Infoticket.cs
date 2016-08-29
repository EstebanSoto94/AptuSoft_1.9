using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
    public class Infoticket{
       //<infoticket>
      
            [XmlElement]
            public int FolioTicket { get; set; }
            [XmlElement]
            public string FchGenera { get; set; }
            [XmlElement]
            public string NmbEvento { get; set; }
            [XmlElement]
            public string TpoTicket { get; set; }
            [XmlElement]
            public string CdgEvento { get; set; }
            [XmlElement]
            public string FchEvento { get; set; }
            [XmlElement]
            public string LugarEvento { get; set; }
            [XmlElement]
            public string UbicEvento { get; set; }
            [XmlElement]
            public string FilaUbicEvento { get; set; }
            [XmlElement]
            public string AsntoUbicEvento { get; set; }
        //</infoticket>
    }
}
