 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csIdDoc
 
 
// version 1.8.0

using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csIdDoc
  {
    public int TipoDTE { get; set; }

    public int Folio { get; set; }

    public string FchEmis { get; set; }

    public int IndServicio { get; set; }

    public int TipoDespacho { get; set; }

    public int IndTraslado { get; set; }

    [XmlElement]
    public int MntBruto { get; set; }

    [XmlElement]
    public int IndMntNeto { get; set; }

    public bool ShouldSerializeIndServicio()
    {
      return this.IndServicio != 0;
    }

    public bool ShouldSerializeTipoDespacho()
    {
      return this.TipoDespacho != 0;
    }

    public bool ShouldSerializeIndTraslado()
    {
      return this.IndTraslado != 0;
    }

    public bool ShouldSerializeMntBruto()
    {
      return this.MntBruto != 0;
    }

    public bool ShouldSerializeIndMntNeto()
    {
      return this.IndMntNeto != 0;
    }
  }
}
