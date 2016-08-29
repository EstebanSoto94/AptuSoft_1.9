 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csReceptor
 
 
// version 1.8.0

using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csReceptor
  {
    public string RUTRecep { get; set; }

    public string RznSocRecep { get; set; }

    [XmlElement]
    public string GiroRecep { get; set; }

    public string DirRecep { get; set; }

    public string CmnaRecep { get; set; }

    public string CiudadRecep { get; set; }

    public bool ShouldSerializeGiroRecep()
    {
      return this.GiroRecep.Length != 0;
    }
  }
}
