 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csTED
 
 
// version 1.8.0

using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csTED
  {
    private csDD _DD = new csDD();

    [XmlAttribute("version")]
    public string version { get; set; }

    public csDD DD
    {
      get
      {
        return this._DD;
      }
      set
      {
        this._DD = value;
      }
    }

    public string FRMT { get; set; }
  }
}
