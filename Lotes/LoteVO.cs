 
// Type: Aptusoft.Lotes.LoteVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.Lotes
{
  public class LoteVO
  {
    public int IdLote { get; set; }

    public string Lote { get; set; }

    public string CodigoProducto { get; set; }

    public string Descripcion { get; set; }

    public int Bodega { get; set; }

    public string BodegaNombre { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdDetalleLote { get; set; }

    public string TipoDocumento { get; set; }

    public string Documento { get; set; }

    public int IdDocumento { get; set; }

    public long FolioDocumento { get; set; }

    public Decimal Cantidad { get; set; }

    public string Accion { get; set; }

    public DateTime FechaIngreso { get; set; }

    public bool Valida { get; set; }
  }
}
