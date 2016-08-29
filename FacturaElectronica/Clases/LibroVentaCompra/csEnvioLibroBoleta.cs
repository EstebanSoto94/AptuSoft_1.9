 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csEnvioLibroBoleta
 
 
// version 1.8.0

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csEnvioLibroBoleta
  {
    private csCaratula _Caratula = new csCaratula();

    public csCaratula Caratula
    {
      get
      {
        return this._Caratula;
      }
      set
      {
        this._Caratula = value;
      }
    }

    [XmlAttribute("ID")]
    public string ID { get; set; }

    public csResumenPeriodoBoleta ResumenPeriodo { get; set; }

    [XmlElement("Detalle")]
    public List<csDetalleLibroBoletas> Detalles { get; set; }

    [XmlElement("TmstFirma")]
    public string TmstFirma { get; set; }
  }
}
