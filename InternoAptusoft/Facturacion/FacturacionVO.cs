 
// Type: Aptusoft.InternoAptusoft.Facturacion.FacturacionVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.InternoAptusoft.Facturacion
{
  public class FacturacionVO
  {
    public int IdFacturacion { get; set; }

    public DateTime FechaFacturacion { get; set; }

    public DateTime FechaEmision { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public int IdContrato { get; set; }

    public int IdCliente { get; set; }

    public int IdDocumentoVenta { get; set; }

    public int FolioDocumentoVenta { get; set; }

    public string EstadoPago { get; set; }
  }
}
