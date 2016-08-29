 
// Type: Aptusoft.Venta
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class Venta
  {
    public int Linea { get; set; }

    public int IdFactura { get; set; }

    public int Folio { get; set; }

    public long FolioIngresoCompra { get; set; }

    public DateTime FechaEmision { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public string Dia { get; set; }

    public string Mes { get; set; }

    public string Ano { get; set; }

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

    public int DiasPlazo { get; set; }

    public int IdMedioPago { get; set; }

    public string MedioPago { get; set; }

    public int IdVendedor { get; set; }

    public string Vendedor { get; set; }

    public int IdCentroCosto { get; set; }

    public string CentroCosto { get; set; }

    public string OrdenCompra { get; set; }

    public Decimal SubTotal { get; set; }

    public Decimal PorcentajeDescuento { get; set; }

    public Decimal Descuento { get; set; }

    public Decimal PorcentajeIva { get; set; }

    public Decimal Iva { get; set; }

    public Decimal Neto { get; set; }

    public Decimal Total { get; set; }

    public string TotalPalabras { get; set; }

    public string EstadoPago { get; set; }

    public string EstadoDocumento { get; set; }

    public Decimal TotalPagado { get; set; }

    public Decimal TotalDocumentado { get; set; }

    public Decimal TotalPendiente { get; set; }

    public string CodImpuesto1 { get; set; }

    public string CodImpuesto2 { get; set; }

    public string CodImpuesto3 { get; set; }

    public string CodImpuesto4 { get; set; }

    public string CodImpuesto5 { get; set; }

    public Decimal Impuesto1 { get; set; }

    public Decimal Impuesto2 { get; set; }

    public Decimal Impuesto3 { get; set; }

    public Decimal Impuesto4 { get; set; }

    public Decimal Impuesto5 { get; set; }

    public Decimal PorcentajeImpuesto1 { get; set; }

    public Decimal PorcentajeImpuesto2 { get; set; }

    public Decimal PorcentajeImpuesto3 { get; set; }

    public Decimal PorcentajeImpuesto4 { get; set; }

    public Decimal PorcentajeImpuesto5 { get; set; }

    public Decimal ComisionVendedor { get; set; }

    public string FolioGuias { get; set; }

    public string FolioNotaVentaMasivas { get; set; }

    public string Observaciones { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string DocumentoVenta { get; set; }

    public int IDDocumentoVenta { get; set; }

    public int FolioDocumentoVenta { get; set; }

    public Decimal TotalExento { get; set; }

    public Decimal TotalaCobrar { get; set; }

    public Decimal PagaCon { get; set; }

    public Decimal Vuelto { get; set; }

    public bool DescuentaInventario { get; set; }

    public string TipoGuia { get; set; }

    public bool Facturada { get; set; }

    public int FolioFactura { get; set; }

    public int IdTipoDocumentoCompra { get; set; }

    public string TipoDocumentoCompra { get; set; }

    public int FolioFacturaNC { get; set; }

    public Decimal OtrosImpuestos { get; set; }

    public int IdPeriodo { get; set; }

    public string Periodo { get; set; }

    public int IdTicket { get; set; }

    public int FolioTicket { get; set; }

    public int IdCotizacion { get; set; }

    public int FolioCotizacion { get; set; }

    public int Caja { get; set; }

    public int IdNotaVenta { get; set; }

    public int FolioNotaVenta { get; set; }

    public int IdTipoNotaCredito { get; set; }

    public string TipoNotaCredito { get; set; }

    public Decimal MontoUsado { get; set; }

    public Decimal MontoDisponible { get; set; }

    public string DocumentoNotaCredito { get; set; }

    public string DatosProducto { get; set; }

    public string Diagnostico { get; set; }

    public string Solucion { get; set; }

    public Decimal TotalCobradoOT { get; set; }

    public Decimal AbonoOT { get; set; }

    public Decimal SaldoOT { get; set; }

    public int IdTecnicoOT { get; set; }

    public string TecnicoOT { get; set; }

    public int IdEstadoOT { get; set; }

    public string EstadoOT { get; set; }

    public int FolioOT { get; set; }

    public string Mesa { get; set; }

    public int IdComanda { get; set; }

    public int FolioComanda { get; set; }

    public string Garzon { get; set; }

    public int IdGarzon { get; set; }

    public string Patente { get; set; }

    public string IT1 { get; set; }

    public string Timbre { get; set; }

    public int Fe_TipoDTE { get; set; }

    public string Fe_FchEmis { get; set; }

    public string Fe_RutEmisor { get; set; }

    public int Fe_IndServicio { get; set; }

    public string Fe_RznSoc { get; set; }

    public string Fe_GiroEmis { get; set; }

    public int Fe_Acteto { get; set; }

    public int Fe_CdgSIISucur { get; set; }

    public string Fe_DirOrigen { get; set; }

    public string Fe_CmnaOrigen { get; set; }

    public string Fe_CiudadOrigen { get; set; }

    public string Fe_Ruta_CAF { get; set; }

    public Decimal FE_ivaComun { get; set; }

    public Decimal FE_C_IvaComun { get; set; }

    public Decimal FE_IvaUsoComunFctProp { get; set; }

    public Decimal FE_TotCredIVAUsoComun { get; set; }

    public int FE_CodIvaNoRec { get; set; }

    public Decimal FE_MntIvaNoRec { get; set; }

    public int FE_OtrosImptCodImp { get; set; }

    public Decimal FE_OtrosImptTasaImp { get; set; }

    public Decimal FE_OtrosImptMntImp { get; set; }

    public int FE_tipoDocumento1 { get; set; }

    public int FE_tipoDocumento2 { get; set; }

    public int FE_tipoDocumento3 { get; set; }

    public int FE_tipoDocumento4 { get; set; }

    public int FE_tipoDocumento5 { get; set; }

    public string FE_tipoDocumentoNombre1 { get; set; }

    public string FE_tipoDocumentoNombre2 { get; set; }

    public string FE_tipoDocumentoNombre3 { get; set; }

    public string FE_tipoDocumentoNombre4 { get; set; }

    public string FE_tipoDocumentoNombre5 { get; set; }

    public string FE_folioDocumentoReferencia1 { get; set; }

    public string FE_folioDocumentoReferencia2 { get; set; }

    public string FE_folioDocumentoReferencia3 { get; set; }

    public string FE_folioDocumentoReferencia4 { get; set; }

    public string FE_folioDocumentoReferencia5 { get; set; }

    public DateTime FE_fechaDocumentoReferencia1 { get; set; }

    public DateTime FE_fechaDocumentoReferencia2 { get; set; }

    public DateTime FE_fechaDocumentoReferencia3 { get; set; }

    public DateTime FE_fechaDocumentoReferencia4 { get; set; }

    public DateTime FE_fechaDocumentoReferencia5 { get; set; }

    public int FE_tipoAccion1 { get; set; }

    public int FE_tipoAccion2 { get; set; }

    public int FE_tipoAccion3 { get; set; }

    public int FE_tipoAccion4 { get; set; }

    public int FE_tipoAccion5 { get; set; }

    public string FE_tipoAccionNombre1 { get; set; }

    public string FE_tipoAccionNombre2 { get; set; }

    public string FE_tipoAccionNombre3 { get; set; }

    public string FE_tipoAccionNombre4 { get; set; }

    public string FE_tipoAccionNombre5 { get; set; }

    public string FE_razonReferencia1 { get; set; }

    public string FE_razonReferencia2 { get; set; }

    public string FE_razonReferencia3 { get; set; }

    public string FE_razonReferencia4 { get; set; }

    public string FE_razonReferencia5 { get; set; }

    public bool FE_enviado_Sii { get; set; }

    public bool FE_enviado_Libro { get; set; }

    public string FE_tipoGuia { get; set; }

    public int FE_codigoTipoGuia { get; set; }

    public string FE_trasladadoPor { get; set; }

    public int FE_codigoTrasladadaPor { get; set; }

    public string BoletaVoucher { get; set; }

    public string NumeroVoucher { get; set; }

    public bool Enviar { get; set; }

    public string TrackIDEnvio { get; set; }

    public string TrackIDLibro { get; set; }

    public Venta()
    {
      this.IdFactura = 0;
      this.Folio = 0;
      this.FechaEmision = DateTime.Now;
      this.FechaVencimiento = DateTime.Now;
      this.IdCliente = 0;
      this.Rut = "";
      this.Digito = "";
      this.RazonSocial = "";
      this.Direccion = "";
      this.Comuna = "";
      this.Ciudad = "";
      this.Giro = "";
      this.Fono = "";
      this.Fax = "";
      this.Contacto = "";
      this.DiasPlazo = 0;
      this.IdMedioPago = 0;
      this.MedioPago = "";
      this.IdVendedor = 0;
      this.Vendedor = "";
      this.IdCentroCosto = 0;
      this.CentroCosto = "";
      this.OrdenCompra = "";
      this.SubTotal = new Decimal(0);
      this.PorcentajeDescuento = new Decimal(0);
      this.Descuento = new Decimal(0);
      this.PorcentajeIva = new Decimal(0);
      this.Iva = new Decimal(0);
      this.Neto = new Decimal(0);
      this.Total = new Decimal(0);
      this.TotalPalabras = "";
      this.EstadoPago = "";
      this.EstadoDocumento = "";
    }
  }
}
