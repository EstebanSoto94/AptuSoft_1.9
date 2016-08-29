 
// Type: Aptusoft.ServicioVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class ServicioVO
  {
    public int IdServicio { get; set; }

    public string FolioServicio { get; set; }

    public int IdProveedor { get; set; }

    public string Rut { get; set; }

    public string Digito { get; set; }

    public string RazonSocial { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public Decimal Neto { get; set; }

    public Decimal Iva { get; set; }

    public Decimal Total { get; set; }

    public Decimal TotalPagado { get; set; }

    public Decimal TotalDocumentado { get; set; }

    public Decimal TotalPendiente { get; set; }

    public int IdMedioPago { get; set; }

    public string MedioPago { get; set; }

    public string EstadoPago { get; set; }

    public string Usuario { get; set; }

    public int IdPeriodo { get; set; }

    public string Periodo { get; set; }
  }
}
