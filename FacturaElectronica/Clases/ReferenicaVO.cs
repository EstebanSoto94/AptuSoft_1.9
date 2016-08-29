 
// Type: Aptusoft.FacturaElectronica.Clases.ReferenicaVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class ReferenicaVO
  {
    public int IdReferencia { get; set; }

    public int idDocumento { get; set; }

    public int FolioDocumento { get; set; }

    public int TipoDocumento { get; set; }

    public string TipoDocumentoNombre { get; set; }

    public string FolioDocumentoReferencia { get; set; }

    public DateTime FechaDocumentoReferencia { get; set; }

    public int TipoAccion { get; set; }

    public string TipoAccionNombre { get; set; }

    public string RazonReferencia { get; set; }

    public int IndGlobal { get; set; }
  }
}
