 
// Type: Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas.csEnvioConsumoBoleta
 
 
// version 1.8.0

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas
{
  public class csEnvioConsumoBoleta
  {
    private csCaratulaConsumoFolio _Caratula = new csCaratulaConsumoFolio();

    public csCaratulaConsumoFolio Caratula
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

    [XmlElement("Resumen")]
    public List<csResumenConsumoBoleta> Resumen { get; set; }
  }
}
