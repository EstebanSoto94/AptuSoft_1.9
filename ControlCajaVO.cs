 
// Type: Aptusoft.ControlCajaVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class ControlCajaVO
  {
    public int IdControlCaja { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string TipoAccion { get; set; }

    public int IdTipoAcion { get; set; }

    public string TipoMovimiento { get; set; }

    public int IdTipoMovimiento { get; set; }

    public Decimal Monto { get; set; }

    public string Observaciones { get; set; }

    public int Caja { get; set; }

    public int Linea { get; set; }
  }
}
