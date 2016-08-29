 
// Type: Aptusoft.Promocion.Clases.PromocionVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.Promocion.Clases
{
  public class PromocionVO
  {
    public int IdPromocion { get; set; }

    public string Descripcion { get; set; }

    public Decimal Cantidad { get; set; }

    public Decimal Precio { get; set; }

    public DateTime Inicio { get; set; }

    public DateTime Fin { get; set; }
  }
}
