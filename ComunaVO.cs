 
// Type: Aptusoft.ComunaVO
 
 
// version 1.8.0

namespace Aptusoft
{
  public class ComunaVO
  {
    private int _codComuna;
    private string _nomComuna;

    public int CodComuna
    {
      get
      {
        return this._codComuna;
      }
      set
      {
        this._codComuna = value;
      }
    }

    public string NomComuna
    {
      get
      {
        return this._nomComuna;
      }
      set
      {
        this._nomComuna = value;
      }
    }
  }
}
