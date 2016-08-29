 
// Type: Aptusoft.InformeVO
 
 
// version 1.8.0

namespace Aptusoft
{
  public class InformeVO
  {
    public int Linea { get; set; }

    public int IdDetalleInforme { get; set; }

    public int IdTipoUsuario { get; set; }

    public string TipoUsuario { get; set; }

    public string Modulo { get; set; }

    public string Informe { get; set; }

    public string CodigoInforme { get; set; }

    public bool Ingresar { get; set; }

    public InformeVO()
    {
      this.Linea = 0;
      this.IdDetalleInforme = 0;
      this.Ingresar = false;
    }
  }
}
