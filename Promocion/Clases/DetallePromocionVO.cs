 
// Type: Aptusoft.Promocion.Clases.DetallePromocionVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.Promocion.Clases
{
  public class DetallePromocionVO : PromocionVO
  {
    public int IdDetallePromocion { get; set; }

    public string Codigo { get; set; }

    public string DescripcionDetalle { get; set; }

    public Decimal CantidadDetalle { get; set; }

    public Decimal CantidadEnVenta { get; set; }

    public int CantidadDePromociones { get; set; }

    public Decimal TotalLinea { get; set; }
  }
}
