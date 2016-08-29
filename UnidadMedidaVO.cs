 
// Type: Aptusoft.UnidadMedidaVO
 
 
// version 1.8.0

namespace Aptusoft
{
  public class UnidadMedidaVO
  {
    private int idUniMed;
    private string nombreUnidad;

    public int IdUnidMed
    {
      get
      {
        return this.idUniMed;
      }
      set
      {
        this.idUniMed = value;
      }
    }

    public string NombreUnidad
    {
      get
      {
        return this.nombreUnidad;
      }
      set
      {
        this.nombreUnidad = value;
      }
    }
  }
}
