 
// Type: Aptusoft.OrdenAtencionVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class OrdenAtencionVO
  {
    public int Linea { get; set; }

    public int IdOrdenAtencion { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaAtencion { get; set; }

    public string HoraAtencion { get; set; }

    public int IdCliente { get; set; }

    public string Rut { get; set; }

    public string Digito { get; set; }

    public string RazonSocial { get; set; }

    public string Contacto { get; set; }

    public string Email { get; set; }

    public string Fono { get; set; }

    public string Email2 { get; set; }

    public string Fono2 { get; set; }

    public string Email3 { get; set; }

    public string Fono3 { get; set; }

    public string Requerimiento { get; set; }

    public string Solucion { get; set; }

    public int IdTecnico { get; set; }

    public string Tecnico { get; set; }

    public string Estado { get; set; }

    public string Usuario { get; set; }

    public string IngresadoPor { get; set; }

    public string TipoSolicitud { get; set; }
  }
}
