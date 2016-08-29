 
// Type: Aptusoft.InternoAptusoft.Contratacion.ContratoVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.InternoAptusoft.Contratacion
{
  public class ContratoVO
  {
    public int IdContrato { get; set; }

    public DateTime FechaContratacion { get; set; }

    public int IdCliente { get; set; }

    public string Rut { get; set; }

    public string Digito { get; set; }

    public string RazonSocial { get; set; }

    public string Direccion { get; set; }

    public string Comuna { get; set; }

    public string Ciudad { get; set; }

    public string Giro { get; set; }

    public string Fono { get; set; }

    public string Fax { get; set; }

    public string Contacto { get; set; }

    public string Email { get; set; }

    public Decimal SubTotal { get; set; }

    public Decimal Descuento { get; set; }

    public Decimal Total { get; set; }

    public string Estado { get; set; }

    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public int CodigoCiclo { get; set; }

    public DateTime SegundaFacturacion { get; set; }

    public DateTime SegundoVencimiento { get; set; }

    public int CodigoOferta { get; set; }

    public string DescripcionOferta { get; set; }

    public int MesesOferta { get; set; }

    public int MesesOfertaOcupado { get; set; }

    public int MesesOfertaRestante { get; set; }

    public Decimal DescuentoOferta { get; set; }

    public string Observaciones { get; set; }

    public DateTime FechaModificacion { get; set; }

    public bool CambioCiclo { get; set; }

    public DateTime FechaCambioCiclo { get; set; }

    public bool Facturar { get; set; }

    public int FolioFactura { get; set; }
  }
}
