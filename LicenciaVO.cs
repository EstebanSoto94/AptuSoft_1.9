 
// Type: Aptusoft.LicenciaVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class LicenciaVO
  {
    public int Linea { get; set; }

    public int IdLicencia { get; set; }

    public int IdCliente { get; set; }

    public string Rut { get; set; }

    public string Mac { get; set; }

    public string Clave { get; set; }

    public string ContraClave { get; set; }

    public DateTime Fecha { get; set; }

    public string Contacto { get; set; }
  }
}
