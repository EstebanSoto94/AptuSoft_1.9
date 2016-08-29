 
// Type: Aptusoft.CategoriaVO
 
 
// version 1.8.0

namespace Aptusoft
{
  public class CategoriaVO
  {
    private int _idCategoria;
    private string _descripcion;

    public int IdSubCategoria { get; set; }

    public string DescripcionSubCategoria { get; set; }

    public int IdCategoria
    {
      get
      {
        return this._idCategoria;
      }
      set
      {
        this._idCategoria = value;
      }
    }

    public string Descripcion
    {
      get
      {
        return this._descripcion;
      }
      set
      {
        this._descripcion = value;
      }
    }

    public CategoriaVO()
    {
      this._idCategoria = 0;
      this._descripcion = (string) null;
    }
  }
}
