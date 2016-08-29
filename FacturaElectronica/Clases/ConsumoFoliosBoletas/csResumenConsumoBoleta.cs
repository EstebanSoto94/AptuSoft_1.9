 
// Type: Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas.csResumenConsumoBoleta
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas
{
  public class csResumenConsumoBoleta
  {
    public int TipoDocumento { get; set; }

    public Decimal MntNeto { get; set; }

    public Decimal MntIva { get; set; }

    public Decimal TasaIVA { get; set; }

    public Decimal MntExento { get; set; }

    public Decimal MntTotal { get; set; }

    public int FoliosEmitidos { get; set; }

    public int FoliosAnulados { get; set; }

    public int FoliosUtilizados { get; set; }

    [XmlElement("RangoUtilizados")]
    public List<csRangoUtilizadoConsumoBoleta> RangoUtilizados { get; set; }
  }
}
