 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csReferencia
 
 
// version 1.8.0

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csReferencia
  {
    public int NroLinRef { get; set; }

    public string TpoDocRef { get; set; }

    public int IndGlobal { get; set; }

    public string FolioRef { get; set; }

    public string FchRef { get; set; }

    public int CodRef { get; set; }

    public string RazonRef { get; set; }

    public bool ShouldSerializeIndGlobal()
    {
      return this.IndGlobal != 0;
    }

    public bool ShouldSerializeCodRef()
    {
      return this.CodRef != 0;
    }
  }
}
