 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csResumenPeriodoBoleta
 
 
// version 1.8.0

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csResumenPeriodoBoleta
  {
    private csTotalesPeriodoBoletas _TotalesPeriodo = new csTotalesPeriodoBoletas();

    public csTotalesPeriodoBoletas TotalesPeriodo
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
