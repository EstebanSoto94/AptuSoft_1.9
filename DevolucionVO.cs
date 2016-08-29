 
// Type: Aptusoft.DevolucionVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class DevolucionVO
  {
    public int IdDevolucion { get; set; }

    public int Folio { get; set; }

    public DateTime Fecha { get; set; }

    public int FolioBoleta { get; set; }

    public int IdVendedor { get; set; }

    public string Vendedor { get; set; }

    public Decimal Total { get; set; }

    public int Caja { get; set; }

    public int CajaBoleta { get; set; }

    public string Documento { get; set; }
  }
}
