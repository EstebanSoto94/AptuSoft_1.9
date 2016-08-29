 
// Type: Aptusoft.CiudadVO
 
 
// version 1.8.0

namespace Aptusoft
{
  public class CiudadVO
  {
    private int _codCiudad;
    private string _nomCiudad;

    public int CodCiudad
    {
      get
      {
        return this._codCiudad;
      }
      set
      {
        this._codCiudad = value;
      }
    }

    public string NomCiudad
    {
      get
      {
        return this._nomCiudad;
      }
      set
      {
        this._nomCiudad = value;
      }
    }
  }
}
