 
// Type: Aptusoft.OpcionesDocumentosVO
 
 
// version 1.8.0

namespace Aptusoft
{
  public class OpcionesDocumentosVO
  {
    public int IdDocumento { get; set; }

    public string NombreDocumento { get; set; }

    public string AlertaStockInsuficiente { get; set; }

    public string ImpideVentasSinStock { get; set; }

    public string CantidadLineasDocumento { get; set; }

    public int PuertoImpresoraFiscal { get; set; }

    public int DecimalesValorVenta { get; set; }

    public string Descripcion_Resumen { get; set; }

    public string iniciarEnNumeroTicket { get; set; }

    public string FacturarCotizacionCompleta { get; set; }

    public string EnvioAutomaticoSII { get; set; }

    public string ComprobanteExentos { get; set; }

    public string MedioPago { get; set; }

    public string PermitirMedioPago { get; set; }

    public string BusquedaRazonSocial { get; set; }
  }
}
