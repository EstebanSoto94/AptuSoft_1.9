 
// Type: Aptusoft.InternoAptusoft.Ofertas.OfertaVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.InternoAptusoft.Ofertas
{
  public class OfertaVO
  {
    public int IdOferta { get; set; }

    public string CodigoOferta { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public bool Vigente { get; set; }

    public Decimal Descuento { get; set; }

    public int CantidadMeses { get; set; }
  }
}
