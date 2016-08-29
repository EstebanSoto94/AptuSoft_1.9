 
// Type: Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte.csResultado
 
 
// version 1.8.0

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte
{
  public class csResultado
  {
    private csCaratulaRespuesta _caratula = new csCaratulaRespuesta();

    public csCaratulaRespuesta Caratula
    {
      get
      {
        return this._caratula;
      }
      set
      {
        this._caratula = value;
      }
    }

    [XmlAttribute("ID")]
    public string ID { get; set; }

    [XmlElement("RecepcionEnvio")]
    public csRecepcionEnvio RecepcionEnvio { get; set; }

    [XmlElement("ResultadoDTE")]
    public List<csResultadoDTE> ResultadoDTE { get; set; }
  }
}
