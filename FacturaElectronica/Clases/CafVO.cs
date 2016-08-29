 
// Type: Aptusoft.FacturaElectronica.Clases.CafVO
 
 
// version 1.8.0

namespace Aptusoft.FacturaElectronica.Clases
{
  public class CafVO
  {
    public int IdCaf { get; set; }

    public int TipoDocumento { get; set; }

    public string TipoDocumentoNombre { get; set; }

    public string RutaArchivo { get; set; }

    public int Desde { get; set; }

    public int Hasta { get; set; }

    public bool Activo { get; set; }
  }
}
