 
// Type: Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas.csCaratulaConsumoFolio
 
 
// version 1.8.0

using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas
{
  public class csCaratulaConsumoFolio
  {
    [XmlAttribute("version")]
    public string version { get; set; }

    public string RutEmisor { get; set; }

    public string RutEnvia { get; set; }

    public string FchResol { get; set; }

    public int NroResol { get; set; }

    public string FchInicio { get; set; }

    public string FchFinal { get; set; }

    public string Correlativo { get; set; }

    public int SecEnvio { get; set; }

    public string TmstFirmaEnv { get; set; }
  }
}
