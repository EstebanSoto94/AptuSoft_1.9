 
// Type: Aptusoft.FacturaElectronica.Clases.EmisorVO
 
 
// version 1.8.0

namespace Aptusoft.FacturaElectronica.Clases
{
  public class EmisorVO
  {
    public int IdEmisor { get; set; }

    public string RutEmisior { get; set; }

    public string RazonSocial { get; set; }

    public string Giro { get; set; }

    public string CodActCome { get; set; }

    public string CodSucursal { get; set; }

    public string Direccion { get; set; }

    public string Comuna { get; set; }

    public string Ciudad { get; set; }

    public string NumeroResolucion { get; set; }

    public string FechaResolucion { get; set; }

    public string CertificadoDigital { get; set; }

    public string RutCertificado { get; set; }

    public bool ValoresConIva { get; set; }

    public bool Simulacion { get; set; }
  }
}
