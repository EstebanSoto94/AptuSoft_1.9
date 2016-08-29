 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csTotalesServicio
 
 
// version 1.8.0

using System;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csTotalesServicio
  {
    public int TpoServ { get; set; }

    public int TotDoc { get; set; }

    public Decimal TotMntExe { get; set; }

    public Decimal TotMntNeto { get; set; }

    [XmlElement]
    public int TasaIVA { get; set; }

    public Decimal TotMntIVA { get; set; }

    public Decimal TotMntTotal { get; set; }

    public bool ShouldSerializeTasaIVA()
    {
      return this.TasaIVA != 0;
    }
  }
}
