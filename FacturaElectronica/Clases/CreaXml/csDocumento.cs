 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csDocumento
 
 
// version 1.8.0

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csDocumento
  {
    private csEncabezado _Encabezado = new csEncabezado();
    private csTED _TED = new csTED();

    public csEncabezado Encabezado
    {
      get
      {
        return this._Encabezado;
      }
      set
      {
        this._Encabezado = value;
      }
    }

    [XmlAttribute("ID")]
    public string ID { get; set; }

    [XmlElement("Detalle")]
    public List<csDetalle> Detalles { get; set; }

    [XmlElement("DscRcgGlobal")]
    public List<csDscRcgGlobal> DscRcgGlobal { get; set; }

    [XmlElement("Referencia")]
    public List<csReferencia> Referencias { get; set; }

    public csTED TED
    {
      get
      {
        return this._TED;
      }
      set
      {
        this._TED = value;
      }
    }

    [XmlElement("TmstFirma")]
    public string TmstFirma { get; set; }
  }
}
