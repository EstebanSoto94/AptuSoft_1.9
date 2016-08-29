 
// Type: Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte.csRecepcionEnvio
 
 
// version 1.8.0

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte
{
  public class csRecepcionEnvio
  {
    public string NmbEnvio { get; set; }

    public string FchRecep { get; set; }

    public string CodEnvio { get; set; }

    public string EnvioDTEID { get; set; }

    public string Digest { get; set; }

    public string RutEmisor { get; set; }

    public string RutReceptor { get; set; }

    public string EstadoRecepEnv { get; set; }

    public string RecepEnvGlosa { get; set; }

    public string NroDTE { get; set; }

    [XmlElement("RecepcionDTE")]
    public List<csRecepcionDTE> RecepcionDTE { get; set; }
  }
}
