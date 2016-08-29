 
// Type: Aptusoft.PagoVentaVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class PagoVentaVO
  {
    public int Linea { get; set; }

    public int IdPagoVenta { get; set; }

    public string TipoDocumento { get; set; }

    public int IdDocumento { get; set; }

    public int FolioDocumento { get; set; }

    public long FolioDocumentoCompra { get; set; }

    public int IdFormaPago { get; set; }

    public string FormaPago { get; set; }

    public string Estado { get; set; }

    public Decimal Monto { get; set; }

    public DateTime FechaCobro { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string Banco { get; set; }

    public string Cuenta { get; set; }

    public string NumeroDocumento { get; set; }

    public string Observaciones { get; set; }

    public string TipoPago { get; set; }

    public Decimal MontoPagadoDocumento { get; set; }

    public Decimal MontoDocumentadoDocumento { get; set; }

    public Decimal MontoPendienteDocumento { get; set; }

    public Decimal TotalDocumento { get; set; }

    public Decimal MontoPagoMasivo { get; set; }
  }
}
