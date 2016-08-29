 
// Type: Aptusoft.UsuarioVO
 
 
// version 1.8.0

namespace Aptusoft
{
  public class UsuarioVO
  {
    public int IdUsuario { get; set; }

    public string NombreUsuario { get; set; }

    public string Clave { get; set; }

    public int IdTipoUsuario { get; set; }

    public int IdBodega { get; set; }

    public int IdCaja { get; set; }

    public int IdListaPrecio { get; set; }

    public string TipoUsuario { get; set; }

    public string Bodega { get; set; }

    public string Caja { get; set; }

    public string ListaPrecio { get; set; }

    public string Modulo { get; set; }

    public bool Ingresa { get; set; }

    public bool Guarda { get; set; }

    public bool Modifica { get; set; }

    public bool Elimina { get; set; }

    public bool Anula { get; set; }

    public bool Descuento { get; set; }

    public bool CambioPrecio { get; set; }

    public bool CambioFecha { get; set; }

    public bool ModificaStock { get; set; }

    public bool VerInformCaja { get; set; }
  }
}
