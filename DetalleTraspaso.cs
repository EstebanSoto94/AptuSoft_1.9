 
// Type: Aptusoft.DetalleTraspaso
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class DetalleTraspaso
  {
    public int IdTraspasoDetalle { get; set; }

    public int FolioLinea { get; set; }

    public int IdTraspaso { get; set; }

    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public Decimal Precio { get; set; }

    public Decimal TotalLinea { get; set; }

    public Decimal Cantidad { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int BodegaOrigen { get; set; }

    public int BodegaDestino { get; set; }

    public int Linea { get; set; }

    public string Usuario { get; set; }

    public Decimal StockQueda { get; set; }

    public Decimal StockQuedaDestino { get; set; }
  }
}
