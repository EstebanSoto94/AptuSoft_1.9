 
// Type: Aptusoft.DetalleTipoUsuarioVO
 
 
// version 1.8.0

namespace Aptusoft
{
  internal class DetalleTipoUsuarioVO
  {
    public int IdDetalleTipoUsuario { get; set; }

    public int IdTipoUsuario { get; set; }

    public string NombreTipoUsuario { get; set; }

    public string Modulo { get; set; }

    public bool Ingresa { get; set; }

    public bool Guarda { get; set; }

    public bool Modifica { get; set; }

    public bool Elimina { get; set; }

    public bool Anula { get; set; }

    public bool Descuento { get; set; }

    public bool CambioPrecio { get; set; }

    public bool CambioFecha { get; set; }

    public DetalleTipoUsuarioVO()
    {
      this.Ingresa = false;
      this.Guarda = false;
      this.Elimina = false;
      this.Anula = false;
      this.Descuento = false;
      this.CambioPrecio = false;
      this.CambioFecha = false;
    }
  }
}
