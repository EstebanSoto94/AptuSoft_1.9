 
// Type: Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte.csCaratulaRespuesta
 
 
// version 1.8.0

using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte
{
  public class csCaratulaRespuesta
  {
    [XmlAttribute("version")]
    public string version { get; set; }

    public string RutResponde { get; set; }

    public string RutRecibe { get; set; }

    [XmlElement("IdRespuesta")]
    public int IdRespuesta { get; set; }

    [XmlElement("NroDetalles")]
    public int NroDetalles { get; set; }

    [XmlElement("TmstFirmaResp")]
    public string TmstFirmaResp { get; set; }

    [XmlElement("TmstFirmaEnv")]
    public string TmstFirmaEnv { get; set; }

    public bool ShouldSerializeIdRespuesta()
    {
      return this.IdRespuesta != 0;
    }

    public bool ShouldSerializeNroDetalles()
    {
      return this.NroDetalles != 0;
    }
  }
}
