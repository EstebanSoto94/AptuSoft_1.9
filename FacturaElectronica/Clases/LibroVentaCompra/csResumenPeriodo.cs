 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csResumenPeriodo
 
 
// version 1.8.0

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csResumenPeriodo
  {
    private TotalesPeriodo _TotalesPeriodo = new TotalesPeriodo();

    public TotalesPeriodo TotalesPeriodo
    {
      get
      {
        return this._TotalesPeriodo;
      }
      set
      {
        this._TotalesPeriodo = value;
      }
    }
  }
}
