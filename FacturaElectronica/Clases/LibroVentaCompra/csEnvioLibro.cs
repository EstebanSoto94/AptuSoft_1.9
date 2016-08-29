 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csEnvioLibro
 
 
// version 1.8.0

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csEnvioLibro
  {
    private csCaratula _Caratula = new csCaratula();
    private List<TotalesPeriodo> _resumenPeriodo = new List<TotalesPeriodo>();

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

    public List<TotalesPeriodo> ResumenPeriodo
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
    public List<csDetalleLibro> Detalles { get; set; }

    [XmlElement("TmstFirma")]
    public string TmstFirma { get; set; }
  }
}
