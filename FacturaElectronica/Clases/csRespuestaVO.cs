 
// Type: Aptusoft.FacturaElectronica.Clases.csRespuestaVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class csRespuestaVO
  {
    public string RutRecibe { get; set; }

    public string RutResponde { get; set; }

    public string Archivo { get; set; }

    public DateTime FechaRecepcionEnvio { get; set; }

    public string CodigoEnvio { get; set; }

    public string IdDte { get; set; }

    public string DigestValue { get; set; }

    public string CodigoEstadoRecepcion { get; set; }

    public string GlosaEstadoRecepcion { get; set; }

    public string NroDte { get; set; }
  }
}
