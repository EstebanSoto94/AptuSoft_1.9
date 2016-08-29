 
// Type: Aptusoft.TraspasoVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class TraspasoVO
  {
    public int IdTraspaso { get; set; }

    public int Folio { get; set; }

    public DateTime FechaEmision { get; set; }

    public int BodegaOrigen { get; set; }

    public int BodegaDestino { get; set; }

    public string Autoriza { get; set; }

    public string Observaciones { get; set; }

    public Decimal Neto { get; set; }

    public Decimal Iva { get; set; }

    public Decimal Total { get; set; }

    public int Caja { get; set; }

    public string Usuario { get; set; }

    public Decimal StockQueda { get; set; }

    public Decimal StockQuedaDestino { get; set; }
  }
}
