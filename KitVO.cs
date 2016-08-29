 
// Type: Aptusoft.KitVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class KitVO
  {
    public int IdKit { get; set; }

    public int FolioKit { get; set; }

    public int Linea { get; set; }

    public string CodigoProductoKit { get; set; }

    public string CodigoProductoDetalle { get; set; }

    public string Descripcion { get; set; }

    public string DescripcionDetalle { get; set; }

    public Decimal Cantidad { get; set; }

    public Decimal CantidadUsada { get; set; }

    public Decimal CantidadCU { get; set; }

    public string Bodega { get; set; }

    public string BodegaOrigen { get; set; }

    public DateTime FechaIngresoKit { get; set; }

    public string Usuario { get; set; }

    public Decimal StockQueda { get; set; }
  }
}
