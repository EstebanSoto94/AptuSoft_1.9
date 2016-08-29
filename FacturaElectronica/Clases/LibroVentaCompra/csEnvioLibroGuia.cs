 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csEnvioLibroGuia
 
 
// version 1.8.0

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csEnvioLibroGuia
  {
    private csCaratula _Caratula = new csCaratula();
    private List<csTotalesPeriodoGuias> _resumenPeriodo = new List<csTotalesPeriodoGuias>();

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

    [XmlElement("ResumenPeriodo")]
    public List<csTotalesPeriodoGuias> ResumenPeriodo
    {
      get
      {
        return this._resumenPeriodo;
      }
      set
      {
        this._resumenPeriodo = value;
      }
    }

    [XmlElement("Detalle")]
    public List<csDetalleLibroGuias> Detalles { get; set; }

    [XmlElement("TmstFirma")]
    public string TmstFirma { get; set; }
  }
}
