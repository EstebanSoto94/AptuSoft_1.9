 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csEmisor
 
 
// version 1.8.0

using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csEmisor
  {
    public string RUTEmisor { get; set; }

    [XmlElement]
    public string RznSoc { get; set; }

    [XmlElement]
    public string RznSocEmisor { get; set; }

    [XmlElement]
    public string GiroEmis { get; set; }

    [XmlElement]
    public string GiroEmisor { get; set; }

    [XmlElement]
    public int Acteco { get; set; }

    public int CdgSIISucur { get; set; }

    public string DirOrigen { get; set; }

    public string CmnaOrigen { get; set; }

    public string CiudadOrigen { get; set; }

    public string Telefono { get; set; }

    public bool ShouldSerializeRznSoc()
    {
      return this.RznSoc.Length != 0;
    }

    public bool ShouldSerializeRznSocEmisor()
    {
      return this.RznSocEmisor.Length != 0;
    }

    public bool ShouldSerializeGiroEmis()
    {
      return this.GiroEmis.Length != 0;
    }

    public bool ShouldSerializeGiroEmisor()
    {
      return this.GiroEmisor.Length != 0;
    }

    public bool ShouldSerializeActeco()
    {
      return this.Acteco != 0;
    }
  }
}
