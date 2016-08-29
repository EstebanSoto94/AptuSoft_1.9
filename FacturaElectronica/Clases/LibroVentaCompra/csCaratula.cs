 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csCaratula
 
 
// version 1.8.0

using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csCaratula
  {
    public string RutEmisorLibro { get; set; }

    public string RutEnvia { get; set; }

    public string PeriodoTributario { get; set; }

    public string FchResol { get; set; }

    public int NroResol { get; set; }

    [XmlElement]
    public string TipoOperacion { get; set; }

    public string TipoLibro { get; set; }

    public string TipoEnvio { get; set; }

    [XmlElement]
    public int FolioNotificacion { get; set; }

    [XmlElement]
    public string CodAutRec { get; set; }

    public bool ShouldSerializeTipoOperacion()
    {
      return this.TipoOperacion.Length != 0;
    }

    public bool ShouldSerializeFolioNotificacion()
    {
      return this.FolioNotificacion != 0;
    }

    public bool ShouldSerializeCodAutRec()
    {
      return this.CodAutRec.Trim().Length != 0;
    }
  }
}
