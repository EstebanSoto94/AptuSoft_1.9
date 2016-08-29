 
// Type: Aptusoft.TomaInventario.Clases.TomaInventarioVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.TomaInventario.Clases
{
  public class TomaInventarioVO
  {
    public int IdTomaInventario { get; set; }

    public DateTime Fecha { get; set; }

    public string Autoriza { get; set; }

    public int BodegaInventario { get; set; }

    public int Caja { get; set; }

    public string Usuario { get; set; }

    public string Estado { get; set; }
  }
}
