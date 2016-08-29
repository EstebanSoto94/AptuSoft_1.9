 
// Type: Aptusoft.DatosDevolucionVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class DatosDevolucionVO
  {
    public int Linea { get; set; }

    public int IdDetalleDevolucion { get; set; }

    public int IdDevolucion { get; set; }

    public int Folio { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string Estado { get; set; }

    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public Decimal ValorVenta { get; set; }

    public Decimal Cantidad { get; set; }

    public Decimal PorcDescuento { get; set; }

    public Decimal Descuento { get; set; }

    public int TipoDescuento { get; set; }

    public Decimal SubTotalLinea { get; set; }

    public Decimal TotalLinea { get; set; }

    public Decimal NetoLinea { get; set; }

    public Decimal ValorCompra { get; set; }

    public int ListaPrecio { get; set; }

    public int Bodega { get; set; }

    public bool Exento { get; set; }

    public string Usuario { get; set; }

    public Decimal StockQueda { get; set; }
  }
}
