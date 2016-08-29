 
// Type: Aptusoft.ControlProductoVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  internal class ControlProductoVO
  {
    public int IdControl { get; set; }

    public string CodigoProducto { get; set; }

    public string DescripcionProducto { get; set; }

    public Decimal CantidadActual { get; set; }

    public Decimal CantidadAnterior { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string Usuario { get; set; }

    public int Bodega { get; set; }

    public string Movimiento { get; set; }
  }
}
