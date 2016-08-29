 
// Type: Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte.csDocumentoRecibo
 
 
// version 1.8.0

using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte
{
  public class csDocumentoRecibo
  {
    [XmlAttribute("ID")]
    public string ID { get; set; }

    public string TipoDoc { get; set; }

    public string Folio { get; set; }

    public string FchEmis { get; set; }

    public string RUTEmisor { get; set; }

    public string RUTRecep { get; set; }

    public string MntTotal { get; set; }

    public string Recinto { get; set; }

    public string RutFirma { get; set; }

    public string Declaracion { get; set; }

    public string TmstFirmaRecibo { get; set; }
  }
}
