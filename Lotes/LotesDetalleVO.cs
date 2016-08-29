 
// Type: Aptusoft.Lotes.LotesDetalleVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.Lotes
{
  public class LotesDetalleVO
  {
    public int IdDetalleLote { get; set; }

    public int IdLoteLinea { get; set; }

    public string Lote { get; set; }

    public string Documento { get; set; }

    public int IdDocumento { get; set; }

    public int FolioDocumento { get; set; }

    public Decimal Cantidad { get; set; }

    public string Accion { get; set; }
  }
}
