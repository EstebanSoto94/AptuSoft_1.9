 
// Type: Aptusoft.frmMenuPrincipal
 
 
// version 1.8.0

using Aptusoft.DtsReportesTableAdapters;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Formularios;
using Aptusoft.InternoAptusoft.Contratacion;
using Aptusoft.InternoAptusoft.Ofertas;
using Aptusoft.Promocion.Formularios;
using Aptusoft.TomaInventario.Formularios;
using Aptusoft.Maquinaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmMenuPrincipal : Form
  {
    public static List<UsuarioVO> listaUsuario = new List<UsuarioVO>();
    public static List<InformeVO> listaPermisosInformes = new List<InformeVO>();
    public static bool _MultiEmpresa = true;
    public static bool _Fiscal = true;
    public static bool _Restorant = true;
    public static bool _Pesable = true;
    public static string _codigoPesable = "25";
    public static bool _Aptusoft = true;
    public static bool _Electronica = true;
    public static int _modCategoria = 0;
    public static int _modProducto = 0;
    public static int _modMaestroProducto = 0;
    public static int _modUnidMedidas = 0;
    public static int _modTraspasos = 0;
    public static int _modClientes = 0;
    public static int _modFactura = 0;
    public static int _modFacturaExenta = 0;
    public static int _modTicket = 0;
    public static int _modBoleta = 0;
    public static int _modGuia = 0;
    public static int _modNotaCredito = 0;
    public static int _modCotizacion = 0;
    public static int _modNotaVenta = 0;
    public static int _modProveedor = 0;
    public static int _modCompra = 0;
    public static int _modPagoCompra = 0;
    public static int _modPagoVenta = 0;
    public static int _modControlCaja = 0;
    public static int _modOpcionesImpresoras = 0;
    public static int _modOpciones = 0;
    public static int _modTipoUsuario = 0;
    public static int _modUsuario = 0;
    public static int _modMedioPago = 0;
    public static int _modOrdenCompra = 0;
    public static int _modVendedor = 0;
    public static int _modImpuesto = 0;
    public static int _modCentroCosto = 0;
    public static int _modBanco = 0;
    public static int _modOrdenAtencion = 0;
    public static int _modServicio = 0;
    public static int _modPeriodoContable = 0;
    public static int _modOT = 0;
    public static int _modTecnico = 0;
    public static int _modGarzon = 0;
    public static int _modComanda = 0;
    public static int _modAtencion = 0;
    public static int _modFacturaElectronica = 0;
    public static int _modOdepa = 0;
    public static int _modEstadosMaquinaria = 0;
    public static Boolean _esFrigo = false;
    private Conexion conexion = Conexion.getConecta();
    private IContainer components = (IContainer) null;
    private frmLogin padre;
    public static CalculosConexion _CalculoDatos;
    private TicketTableAdapter ticketTableAdapter1;
    private TicketTableAdapter ticketTableAdapter2;
    private TicketTableAdapter ticketTableAdapter3;
    private TicketTableAdapter ticketTableAdapter4;
    private TicketTableAdapter ticketTableAdapter5;
    private ToolStripMenuItem ventasToolStripMenuItem;
    private ToolStripMenuItem comprasToolStripMenuItem;
    private ToolStripMenuItem inventarioToolStripMenuItem;
    private ToolStripMenuItem opcionesToolStripMenuItem;
    private ToolStripMenuItem impuestosEspecialesToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem ventaToolStripMenuItem;
    private ToolStripMenuItem clientesToolStripMenuItem;
    private ToolStripMenuItem cuentaCorrienteToolStripMenuItem;
    private ToolStripMenuItem facturaToolStripMenuItem;
    private ToolStripMenuItem facturaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem;
    private ToolStripMenuItem detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarFacturaToolStripMenuItem;
    private ToolStripMenuItem facturaExentaToolStripMenuItem;
    private ToolStripMenuItem fToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem12;
    private ToolStripMenuItem listadoDeFacturasExentasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarFacturaExentaToolStripMenuItem;
    private ToolStripMenuItem boletasToolStripMenuItem1;
    private ToolStripMenuItem boletaToolStripMenuItem;
    private ToolStripMenuItem devoluciónDeProductosToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem1;
    private ToolStripMenuItem listadoDeBoletasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeBoletasToolStripMenuItem;
    private ToolStripMenuItem listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarBoletaToolStripMenuItem;
    private ToolStripMenuItem boletaFiscalToolStripMenuItem;
    private ToolStripMenuItem boletaFiscalToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem13;
    private ToolStripMenuItem listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarBoletaFiscalToolStripMenuItem;
    private ToolStripMenuItem devolucionDeProductosConBoletasToolStripMenuItem;
    private ToolStripMenuItem devolucionDeProductosToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem18;
    private ToolStripMenuItem listadoDeDevolucionesSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem guiasToolStripMenuItem;
    private ToolStripMenuItem guiaDeDespachoToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem4;
    private ToolStripMenuItem listadoDeGuiasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarGuiaToolStripMenuItem;
    private ToolStripMenuItem notasDeCreditoToolStripMenuItem;
    private ToolStripMenuItem notaDeCreditoToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem6;
    private ToolStripMenuItem listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1;
    private ToolStripMenuItem listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarNotaDeCreditoToolStripMenuItem;
    private ToolStripMenuItem cotizacionToolStripMenuItem;
    private ToolStripMenuItem cotizacionToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem3;
    private ToolStripMenuItem listadoDeCotizacionesSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarCotizacionToolStripMenuItem;
    private ToolStripMenuItem detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem;
    private ToolStripMenuItem ticketToolStripMenuItem;
    private ToolStripMenuItem ticketToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem2;
    private ToolStripMenuItem listadoDeTicketsSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeTicketAnuladosToolStripMenuItem;
    private ToolStripMenuItem visualizarTicketToolStripMenuItem;
    private ToolStripMenuItem notaDeVentaToolStripMenuItem;
    private ToolStripMenuItem notaDeVenToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem5;
    private ToolStripMenuItem listadoDeNotasDeVentasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarNotaDeVentaToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem controlDeCajaToolStripMenuItem;
    private ToolStripMenuItem controlDeCajaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem10;
    private ToolStripMenuItem listadoDeControlToolStripMenuItem;
    private ToolStripMenuItem moduloFiscalToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem informesGToolStripMenuItem;
    private ToolStripMenuItem cierreDeDiaToolStripMenuItem;
    private ToolStripMenuItem libroDeVentasToolStripMenuItem;
    private ToolStripMenuItem libroDeVentasConBoletasToolStripMenuItem;
    private ToolStripMenuItem listadoDeClientesToolStripMenuItem;
    private ToolStripMenuItem listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem resumenDeVentasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem libroDeVentasConBoletaFiscalToolStripMenuItem;
    private ToolStripMenuItem listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem pagosDeVentasToolStripMenuItem;
    private ToolStripMenuItem documentosPorCobrarSegúnFechaToolStripMenuItem1;
    private ToolStripMenuItem detalleDePagosDeVentasSegúnFechaToolStripMenuItem1;
    private ToolStripMenuItem detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDeClientesMorososToolStripMenuItem;
    private ToolStripMenuItem comprasToolStripMenuItem1;
    private ToolStripMenuItem proveedoresToolStripMenuItem;
    private ToolStripMenuItem ingresoDeComprasToolStripMenuItem;
    private ToolStripMenuItem ingresoDeComprasToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem8;
    private ToolStripMenuItem listadoDeComprasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarDocumentoDeCompraToolStripMenuItem;
    private ToolStripMenuItem libroDeComprasToolStripMenuItem;
    private ToolStripMenuItem listadoDeProveedoresToolStripMenuItem;
    private ToolStripMenuItem libroDeComprasSegúnPeriodoContableToolStripMenuItem;
    private ToolStripMenuItem ordenDeComprasToolStripMenuItem;
    private ToolStripMenuItem ordenDeCompraToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem9;
    private ToolStripMenuItem listadoOrdenesDeCompraSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarOrdenDeCompraToolStripMenuItem;
    private ToolStripMenuItem ingresoDeServiciosToolStripMenuItem;
    private ToolStripMenuItem ingresoDeGastosDeServiciosToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem14;
    private ToolStripMenuItem listadoDeGastosSegúnFechaToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem informesDePagosDeComprasToolStripMenuItem;
    private ToolStripMenuItem documentosSegunFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDePagosDeComprasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDePagosPorProveedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem inventarioToolStripMenuItem1;
    private ToolStripMenuItem productosToolStripMenuItem;
    private ToolStripMenuItem categoriasToolStripMenuItem;
    private ToolStripMenuItem unidadDeMedidaToolStripMenuItem;
    private ToolStripMenuItem kitToolStripMenuItem;
    private ToolStripMenuItem crearKitToolStripMenuItem;
    private ToolStripMenuItem armarKitToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem11;
    private ToolStripMenuItem visualizaFormulaDeKitToolStripMenuItem;
    private ToolStripMenuItem detalleDeKitArmadosSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem traspasoInternoEntreBodegasToolStripMenuItem;
    private ToolStripMenuItem traspasosInternosToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem15;
    private ToolStripMenuItem listadoDeTraspasosSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem detalleDeTraspasosSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem mantenedorDeProductosToolStripMenuItem;
    private ToolStripMenuItem mantenedorDePromocionesToolStripMenuItem;
    private ToolStripMenuItem mantenedorDePromocionesToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem20;
    private ToolStripMenuItem tomaDeInventarioToolStripMenuItem;
    private ToolStripMenuItem tomaDeInventarioToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem27;
    private ToolStripMenuItem listadoDeTomaDeInventarioSegunFechaToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem informesToolStripMenuItem7;
    private ToolStripMenuItem existenciasPorBodegaToolStripMenuItem;
    private ToolStripMenuItem listadoGeneralDePreciosToolStripMenuItem;
    private ToolStripMenuItem listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem;
    private ToolStripMenuItem listadoDeArticulosBajoStockMinimoToolStripMenuItem;
    private ToolStripMenuItem listadoDeArticulosParaTomaDeInventarioToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem movimientoDeArticulosToolStripMenuItem;
    private ToolStripMenuItem rankingDeProductosMasVendidosToolStripMenuItem;
    private ToolStripMenuItem detalleDeVentasPorProductoToolStripMenuItem;
    private ToolStripMenuItem detalleDeComprasPorProductoToolStripMenuItem;
    private ToolStripMenuItem detalleDeComprasPorProveedorToolStripMenuItem;
    private ToolStripMenuItem kardexPorProductoToolStripMenuItem;
    private ToolStripMenuItem entradaDeProductosABodegaToolStripMenuItem;
    private ToolStripMenuItem seguimientoLoteToolStripMenuItem;
    private ToolStripMenuItem seguimientoLotePorCodigoProductoToolStripMenuItem;
    private ToolStripMenuItem ordenDeTrabajoToolStripMenuItem;
    private ToolStripMenuItem ordenDeTrabajoToolStripMenuItem1;
    private ToolStripMenuItem tecnicosToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem16;
    private ToolStripMenuItem listadoDeOTSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem opcionesToolStripMenuItem1;
    private ToolStripMenuItem impuestosEspecialesToolStripMenuItem1;
    private ToolStripMenuItem vendedoresToolStripMenuItem;
    private ToolStripMenuItem mediosDeToolStripMenuItem;
    private ToolStripMenuItem mediosDePagoFiscalToolStripMenuItem;
    private ToolStripMenuItem opcionesToolStripMenuItem2;
    private ToolStripMenuItem centroDeCostoToolStripMenuItem;
    private ToolStripMenuItem bancosToolStripMenuItem;
    private ToolStripMenuItem rubrosToolStripMenuItem;
    private ToolStripMenuItem periodosContablesToolStripMenuItem;
    private ToolStripMenuItem impresorasToolStripMenuItem;
    private ToolStripMenuItem maestroDeBodegasToolStripMenuItem;
    private ToolStripMenuItem mestroDeListasDePrecioToolStripMenuItem;
    private ToolStripMenuItem maestroDeCajasToolStripMenuItem;
    private ToolStripMenuItem tipoDeUsuariosToolStripMenuItem;
    private ToolStripMenuItem usuariosToolStripMenuItem;
    private ToolStripMenuItem respaldarInformaciónToolStripMenuItem;
    private ToolStripMenuItem odepaToolStripMenuItem;
    private ToolStripMenuItem atenciónClientesToolStripMenuItem;
    private ToolStripMenuItem ordenDeAtenciónToolStripMenuItem;
    private ToolStripMenuItem preClienteToolStripMenuItem;
    private ToolStripMenuItem preVentaToolStripMenuItem;
    private ToolStripMenuItem moduloFacturacionToolStripMenuItem;
    private ToolStripMenuItem moduloFacturacionToolStripMenuItem1;
    private ToolStripMenuItem maestroDeOfertasToolStripMenuItem;
    private ToolStripMenuItem moduloDeContratacionToolStripMenuItem;
    private ToolStripMenuItem restaurantToolStripMenuItem;
    private ToolStripMenuItem garzonesToolStripMenuItem;
    private ToolStripMenuItem atenciónToolStripMenuItem;
    private ToolStripMenuItem configuracionBotonesComandaToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem17;
    private ToolStripMenuItem listadoDeComandasToolStripMenuItem;
    private ToolStripMenuItem electronicaToolStripMenuItem;
    private ToolStripMenuItem cAFToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripMenuItem facturaElectronicaToolStripMenuItem;
    private ToolStripMenuItem facturaElectronicaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem19;
    private ToolStripMenuItem listadoDeFacturasSegúnFechaToolStripMenuItem1;
    private ToolStripMenuItem listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem;
    private ToolStripMenuItem listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem;
    private ToolStripMenuItem visualizarFacturaElectronicaToolStripMenuItem;
    private ToolStripMenuItem facturaExentaElectronicaToolStripMenuItem;
    private ToolStripMenuItem facturaExentaElectronicaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem24;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem toolStripMenuItem4;
    private ToolStripMenuItem toolStripMenuItem5;
    private ToolStripMenuItem toolStripMenuItem6;
    private ToolStripMenuItem toolStripMenuItem7;
    private ToolStripMenuItem notaDeCreditoElectronicaToolStripMenuItem;
    private ToolStripMenuItem notaDeCreditoElectronicaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem21;
    private ToolStripMenuItem listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarNotaDeCreditoElectronicaToolStripMenuItem;
    private ToolStripMenuItem notaDeDebitoElectronicaToolStripMenuItem;
    private ToolStripMenuItem notaDeDebitoElectronicaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem22;
    private ToolStripMenuItem listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem visualizarNotaDeDebitoElectronicaToolStripMenuItem;
    private ToolStripMenuItem guiaDeDespachoElectronicaToolStripMenuItem;
    private ToolStripMenuItem guiaDeDespachoElectronicaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem23;
    private ToolStripMenuItem listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem;
    private ToolStripMenuItem guiasElectronicasNOFacturadasToolStripMenuItem;
    private ToolStripMenuItem visualizarGuiasElectronicaToolStripMenuItem;
    private ToolStripMenuItem boletaElectronicaToolStripMenuItem;
    private ToolStripMenuItem boletaElectronicaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem25;
    private ToolStripMenuItem toolStripMenuItem8;
    private ToolStripMenuItem toolStripMenuItem9;
    private ToolStripMenuItem toolStripMenuItem10;
    private ToolStripMenuItem toolStripMenuItem11;
    private ToolStripMenuItem toolStripMenuItem12;
    private ToolStripMenuItem toolStripMenuItem13;
    private ToolStripMenuItem toolStripMenuItem14;
    private ToolStripMenuItem toolStripMenuItem15;
    private ToolStripMenuItem toolStripMenuItem16;
    private ToolStripMenuItem boletaElectronicaExentaToolStripMenuItem;
    private ToolStripMenuItem boletaElectronicaExentaToolStripMenuItem1;
    private ToolStripMenuItem informesToolStripMenuItem26;
    private ToolStripMenuItem toolStripMenuItem17;
    private ToolStripMenuItem toolStripMenuItem18;
    private ToolStripMenuItem toolStripMenuItem19;
    private ToolStripMenuItem toolStripMenuItem20;
    private ToolStripMenuItem toolStripMenuItem21;
    private ToolStripMenuItem toolStripMenuItem22;
    private ToolStripMenuItem toolStripMenuItem23;
    private ToolStripMenuItem toolStripMenuItem24;
    private ToolStripMenuItem toolStripMenuItem25;
    private ToolStripSeparator toolStripSeparator9;
    private ToolStripMenuItem comprasElectronicasToolStripMenuItem;
    private ToolStripMenuItem intercambioDeInformacionToolStripMenuItem1;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripMenuItem generadorDeEnviosToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem datosDelEmisorToolStripMenuItem;
    private ToolStripMenuItem opcionesLocalesToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem1;
    private Panel pnlVenta;
    private Button btnBoletaFiscal;
    private Label label1;
    private Button btnPagosVentas;
    private Button btnFactura;
    private Button btnCliente;
    private Button btnNotaVenta;
    private Button btnGuia;
    private Button btnTicket;
    private Button btnCotizacion;
    private Button btnBoleta;
    private Panel pnlCompra;
    private Label label4;
    private Button btnPagoCompras;
    private Button btnOrdenCompra;
    private Button btnProveedor;
    private Button btnIngresoCompra;
    private Panel pnlInventario;
    private Label label3;
    private Button btnCategorias;
    private Button btnUnidMedidas;
    private Button btnProducto;
    private Panel pnlOpciones;
    private Label label2;
    private Button btnUsuario;
    private Button btnOpciones;
    private Button btnTipoUsuario;
    private Button btnImpresoras;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Panel panel1;
    private Label lblDocumentosElectronicosSinEnviar;
    private Label lblConexion;
    private Label label9;
    private Label lblEmpresa;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label lblTipoUsuario;
    private Label lblUsuario;
    private Label lblCaja;
    private Label lblBodega;
    private Button btnPruebas;
    private Timer timer1;
    private Label lblFiscal;
    private Panel pnlVentasElectronicas;
    private Label label10;
    private Button btnEBoleta;
    private Button btnEFacturaExenta;
    private Button btnEnotaDebito;
    private Button btnENotaCredito;
    private Button btnEGuias;
    private Button btnCaf;
    private Button btnEFactura;
    private Button btnEnvios;
    private Button btnVentaElectronica;
    private Button btnOpcion;
    private Button btnInventario;
    private Button btnComprar;
    private Button btnVender;
    private ToolStripMenuItem respaldarInstalacionToolStripMenuItem;
    private ToolStripMenuItem valorizacionDeExistenciaToolStripMenuItem;
    private ToolStripMenuItem extrasToolStripMenuItem;
    private ToolStripMenuItem arriendosDeMaquinariaToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem26;
    private ToolStripMenuItem toolStripMenuItem27;
    private ToolStripMenuItem toolStripMenuItem28;
    private ToolStripMenuItem toolStripMenuItem29;
    private ToolStripMenuItem toolStripMenuItem30;
    private ToolStripMenuItem toolStripMenuItem31;
    private ToolStripMenuItem toolStripMenuItem32;
    private ToolStripMenuItem toolStripMenuItem33;
    private ToolStripMenuItem toolStripMenuItem34;
    private ToolStripMenuItem generadorDeCodigosDeBarraToolStripMenuItem;
    private ToolStripMenuItem maquinariaToolStripMenuItem;
    private ToolStripMenuItem estadosDeMaquinariaToolStripMenuItem;
    private ToolStripMenuItem ingresosManualesToolStripMenuItem;
    private ToolStripMenuItem ingresoBoletasManualesToolStripMenuItem;
    private ToolStripMenuItem informesToolStripMenuItem28;
    private ToolStripMenuItem listadoDeBoletasIngresadasToolStripMenuItem;
    private CheckBox chbFrigo;
    private TicketTableAdapter ticketTableAdapter6;

    public frmMenuPrincipal()
    {
      this.InitializeComponent();
      this.timer1.Enabled = true;
      this.timer1.Start();
      this.pnlVenta.Visible = true;
      if (frmMenuPrincipal._Fiscal)
      {
        this.moduloFiscalToolStripMenuItem.Visible = true;
        this.mediosDePagoFiscalToolStripMenuItem.Visible = true;
      }
      else
      {
        this.moduloFiscalToolStripMenuItem.Visible = false;
        this.mediosDePagoFiscalToolStripMenuItem.Visible = false;
      }
      if (frmMenuPrincipal._Electronica)
      {
        this.electronicaToolStripMenuItem.Visible = true;
        this.btnVentaElectronica.Enabled = true;
      }
      else
      {
        this.electronicaToolStripMenuItem.Visible = false;
        this.btnVentaElectronica.Enabled = false;
      }
      if (frmMenuPrincipal._Restorant)
        this.restaurantToolStripMenuItem.Visible = true;
      else
        this.restaurantToolStripMenuItem.Visible = false;
      if (frmMenuPrincipal._Aptusoft)
        this.atenciónClientesToolStripMenuItem.Visible = true;
      else
        this.atenciónClientesToolStripMenuItem.Visible = false;
      frmMenuPrincipal._CalculoDatos = new CalculosConexion();
    }

    public frmMenuPrincipal(frmLogin pa, List<UsuarioVO> lu)
    {
      this.InitializeComponent();
      this.timer1.Enabled = true;
      this.timer1.Start();
      this.padre = pa;
      frmMenuPrincipal.listaUsuario = lu;
      this.cargaLabelDatousuario();
      this.cargaPermisosInformes();
      this.pnlVenta.Visible = true;
      if (frmMenuPrincipal._Fiscal)
      {
        this.moduloFiscalToolStripMenuItem.Visible = true;
        this.boletaFiscalToolStripMenuItem.Visible = true;
        this.mediosDePagoFiscalToolStripMenuItem.Visible = true;
        this.btnBoletaFiscal.Visible = true;
        this.lblEmpresa.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
        this.lblFiscal.Visible = true;
      }
      else
      {
        this.moduloFiscalToolStripMenuItem.Visible = false;
        this.boletaFiscalToolStripMenuItem.Visible = false;
        this.btnBoletaFiscal.Visible = false;
        this.mediosDePagoFiscalToolStripMenuItem.Visible = false;
      }
      if (frmMenuPrincipal._Electronica)
      {
        this.electronicaToolStripMenuItem.Visible = true;
        this.btnVentaElectronica.Enabled = true;
      }
      else
      {
        this.electronicaToolStripMenuItem.Visible = false;
        this.btnVentaElectronica.Enabled = false;
      }
      if (frmMenuPrincipal._Restorant)
        this.restaurantToolStripMenuItem.Visible = true;
      else
        this.restaurantToolStripMenuItem.Visible = false;
      if (frmMenuPrincipal._Aptusoft)
        this.atenciónClientesToolStripMenuItem.Visible = true;
      else
        this.atenciónClientesToolStripMenuItem.Visible = false;
      if (frmMenuPrincipal._MultiEmpresa)
        this.lblEmpresa.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      frmMenuPrincipal._CalculoDatos = new CalculosConexion();
    }

    private void cargaPermisosInformes()
    {
      frmMenuPrincipal.listaPermisosInformes = new PermisoInforme().listaPermisosInforme(this.lblTipoUsuario.Text);
    }

    private void cargaLabelDatousuario()
    {
      this.lblUsuario.Text = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      this.lblBodega.Text = frmMenuPrincipal.listaUsuario[0].IdBodega == 0 ? "TODAS" : "BODEGA " + frmMenuPrincipal.listaUsuario[0].IdBodega.ToString();
      Label label1 = this.lblCaja;
      int num = frmMenuPrincipal.listaUsuario[0].IdCaja;
      string str1 = num.ToString();
      label1.Text = str1;
      TipoUsuario tipoUsuario1 = new TipoUsuario();
      Label label2 = this.lblTipoUsuario;
      TipoUsuario tipoUsuario2 = tipoUsuario1;
      num = frmMenuPrincipal.listaUsuario[0].IdTipoUsuario;
      int idTipo = Convert.ToInt32(num.ToString());
      string str2 = tipoUsuario2.retornaNombreTipoUsuario(idTipo);
      label2.Text = str2;
      if (!frmMenuPrincipal._MultiEmpresa)
        return;
      this.lblEmpresa.Text = "Conectado a " + frmLogin._Empresa.ToUpper();
    }

    private bool buscaPermiso(string modulo)
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals(modulo))
          return Convert.ToBoolean(usuarioVo.Ingresa);
      }
      return false;
    }

    private bool buscaPermisoInforme(string codInf)
    {
      foreach (InformeVO informeVo in frmMenuPrincipal.listaPermisosInformes)
      {
        if (informeVo.CodigoInforme.Equals(codInf))
          return Convert.ToBoolean(informeVo.Ingresar);
      }
      return false;
    }

    private void alerta()
    {
      int num = (int) MessageBox.Show("SIN AUTORIZACIÓN PARA INGRESAR", "AptuSoft", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    private void btnTicket_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("TICKET"))
      {
        if (frmMenuPrincipal._modTicket != 0)
          return;
        frmMenuPrincipal._modTicket = 1;
        new frmTicket().Show();
      }
      else
        this.alerta();
    }

    private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void btnCotizacion_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("COTIZACION"))
      {
        if (frmMenuPrincipal._modCotizacion != 0)
          return;
        frmMenuPrincipal._modCotizacion = 1;
        new frmCotizacion().Show();
      }
      else
        this.alerta();
    }

    private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void btnGuia_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("GUIA"))
      {
        if (frmMenuPrincipal._modGuia != 0)
          return;
        frmMenuPrincipal._modGuia = 1;
        new frmGuiaDespacho().Show();
      }
      else
        this.alerta();
    }

    private void guiasToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void btnBoleta_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("BOLETA"))
      {
        if (frmMenuPrincipal._modBoleta != 0)
          return;
        frmMenuPrincipal._modBoleta = 1;
        new frmBoleta().Show();
      }
      else
        this.alerta();
    }

    private void boletasToolStripMenuItem1_Click(object sender, EventArgs e)
    {
    }

    private void btnFactura_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("FACTURA"))
      {
        if (frmMenuPrincipal._modFactura != 0)
          return;
        frmMenuPrincipal._modFactura = 1;
        new frmFactura().Show();
      }
      else
        this.alerta();
    }

    private void btnCliente_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("CLIENTE"))
      {
        if (frmMenuPrincipal._modClientes != 0)
          return;
        frmMenuPrincipal._modClientes = 1;
        new frmClientes().Show();
      }
      else
        this.alerta();
    }

    private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("CLIENTE"))
      {
        if (frmMenuPrincipal._modClientes != 0)
          return;
        frmMenuPrincipal._modClientes = 1;
        new frmClientes().Show();
      }
      else
        this.alerta();
    }

    private void btnPagosVentas_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("PAGOS VENTAS"))
      {
        if (frmMenuPrincipal._modPagoVenta != 0)
          return;
        frmMenuPrincipal._modPagoVenta = 1;
        new frmPagoVenta().Show();
      }
      else
        this.alerta();
    }

    private void notasDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void notaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void btnOrdenCompra_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("ORDEN COMPRA"))
      {
        if (frmMenuPrincipal._modOrdenCompra != 0)
          return;
        frmMenuPrincipal._modOrdenCompra = 1;
        new frmOrdenCompra().Show();
      }
      else
        this.alerta();
    }

    private void ordenDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void btnIngresoCompra_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("COMPRAS"))
      {
        if (frmMenuPrincipal._modCompra != 0)
          return;
        frmMenuPrincipal._modCompra = 1;
        new frmIngresoCompra().Show();
      }
      else
        this.alerta();
    }

    private void ingresoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void btnProveedor_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("PROVEEDOR"))
      {
        if (frmMenuPrincipal._modProveedor != 0)
          return;
        frmMenuPrincipal._modProveedor = 1;
        new frmProveedor().Show();
      }
      else
        this.alerta();
    }

    private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("PROVEEDOR"))
      {
        if (frmMenuPrincipal._modProveedor != 0)
          return;
        frmMenuPrincipal._modProveedor = 1;
        new frmProveedor().Show();
      }
      else
        this.alerta();
    }

    private void btnPagoCompras_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("PAGOS COMPRAS"))
      {
        if (frmMenuPrincipal._modPagoCompra != 0)
          return;
        frmMenuPrincipal._modPagoCompra = 1;
        new frmListadoPagosCompra().Show();
      }
      else
        this.alerta();
    }

    private void btnCategorias_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("CATEGORIA"))
      {
        if (frmMenuPrincipal._modCategoria != 0)
          return;
        frmMenuPrincipal._modCategoria = 1;
        new frmCategorias().Show();
      }
      else
        this.alerta();
    }

    private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("CATEGORIA"))
      {
        if (frmMenuPrincipal._modCategoria != 0)
          return;
        frmMenuPrincipal._modCategoria = 1;
        new frmCategorias().Show();
      }
      else
        this.alerta();
    }

    private void btnProducto_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("PRODUCTO"))
      {
        if (frmMenuPrincipal._modProducto != 0)
          return;
        frmMenuPrincipal._modProducto = 1;
        new frmProductos().Show();
      }
      else
        this.alerta();
    }

    private void productosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("PRODUCTO"))
      {
        if (frmMenuPrincipal._modProducto != 0)
          return;
        frmMenuPrincipal._modProducto = 1;
        new frmProductos().Show();
      }
      else
        this.alerta();
    }

    private void btnUnidMedidas_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("UNIDAD MEDIDA"))
      {
        if (frmMenuPrincipal._modUnidMedidas != 0)
          return;
        frmMenuPrincipal._modUnidMedidas = 1;
        new frmUnidadMedidas().Show();
      }
      else
        this.alerta();
    }

    private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("UNIDAD MEDIDA"))
      {
        if (frmMenuPrincipal._modUnidMedidas != 0)
          return;
        frmMenuPrincipal._modUnidMedidas = 1;
        new frmUnidadMedidas().Show();
      }
      else
        this.alerta();
    }

    private void btnOpciones_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("OPCIONES"))
      {
        if (frmMenuPrincipal._modOpciones != 0)
          return;
        new frmOpciones2(_esFrigo).Show();
      }
      else
        this.alerta();
    }

    private void opcionesToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("OPCIONES"))
      {
        if (frmMenuPrincipal._modOpciones != 0)
          return;
        new frmOpciones2(_esFrigo).Show();
      }
      else
        this.alerta();
    }

    private void btnImpresoras_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("IMPRESORA"))
      {
        if (frmMenuPrincipal._modOpcionesImpresoras != 0)
          return;
        frmMenuPrincipal._modOpcionesImpresoras = 1;
        new frmImpresoras().Show();
      }
      else
        this.alerta();
    }

    private void impresorasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("IMPRESORA"))
      {
        if (frmMenuPrincipal._modOpcionesImpresoras != 0)
          return;
        frmMenuPrincipal._modOpcionesImpresoras = 1;
        new frmImpresoras().Show();
      }
      else
        this.alerta();
    }

    private void btnTipoUsuario_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("TIPO USUARIO"))
      {
        if (frmMenuPrincipal._modTipoUsuario != 0)
          return;
        new frmTipoUsuario().Show();
      }
      else
        this.alerta();
    }

    private void tipoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("TIPO USUARIO"))
      {
        if (frmMenuPrincipal._modTipoUsuario != 0)
          return;
        new frmTipoUsuario().Show();
      }
      else
        this.alerta();
    }

    private void btnUsuario_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("USUARIO"))
      {
        if (frmMenuPrincipal._modUsuario != 0)
          return;
        new frmUsuario().Show();
      }
      else
        this.alerta();
    }

    private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("USUARIO"))
      {
        if (frmMenuPrincipal._modUsuario != 0)
          return;
        new frmUsuario().Show();
      }
      else
        this.alerta();
    }

    private void impuestosEspecialesToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("IMPUESTOS ESPECIALES"))
      {
        if (frmMenuPrincipal._modImpuesto != 0)
          return;
        frmMenuPrincipal._modImpuesto = 1;
        new frmImpuestos().Show();
      }
      else
        this.alerta();
    }

    private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("VENDEDORES"))
      {
        if (frmMenuPrincipal._modVendedor != 0)
          return;
        frmMenuPrincipal._modVendedor = 1;
        new frmVendedor().Show();
      }
      else
        this.alerta();
    }

    private void mediosDeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("MEDIOS DE PAGO"))
      {
        if (frmMenuPrincipal._modMedioPago != 0)
          return;
        frmMenuPrincipal._modMedioPago = 1;
        new frmMedioPagoNOFiscal().Show();
      }
      else
        this.alerta();
    }

    private void mediosDePagoFiscalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("MEDIOS DE PAGO"))
      {
        if (frmMenuPrincipal._modMedioPago != 0)
          return;
        frmMenuPrincipal._modMedioPago = 1;
        new frmMedioPago().Show();
      }
      else
        this.alerta();
    }

    private void centroDeCostoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("CENTRO DE COSTO"))
      {
        if (frmMenuPrincipal._modCentroCosto != 0)
          return;
        frmMenuPrincipal._modCentroCosto = 1;
        new frmCentroCosto().Show();
      }
      else
        this.alerta();
    }

    private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.conexion.cerrarConexion();
      this.Dispose();
      this.padre.Close();
    }

    private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.Close();
      this.Dispose();
      this.padre.Close();
    }

    private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("FACTURA"))
      {
        if (frmMenuPrincipal._modFactura != 0)
          return;
        frmMenuPrincipal._modFactura = 1;
        new frmFactura().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeFacturasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA001"))
        new frmLanzadorInformesVenta("Listado de Facturas Según Fecha", "FACTURA001").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA002"))
        new frmLanzadorInformesVenta("Listado de Facturas Por Cliente, Según Fecha", "FACTURA002").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA003"))
        new frmLanzadorInformesVenta("Listado de Facturas Por Vendedor, Según Fecha", "FACTURA003").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA004"))
        new frmLanzadorInformesVenta("Listado de Facturas Por Centro de Costo, Según Fecha", "FACTURA004").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA005"))
        new frmLanzadorInformesVenta("Listado de Facturas Pendientes de Pago", "FACTURA005").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA006"))
        new frmLanzadorInformesVenta("Listado de Facturas Pendientes de Pago, Por Cliente, Según Fecha", "FACTURA006").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA007"))
        new frmLanzadorInformesVenta("Listado de Facturas Anuladas, Según Fecha", "FACTURA007").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA008"))
        new frmLanzadorInformesVenta("Listado de Facturas, Según Fecha de Vencimiento", "FACTURA008").Show();
      else
        this.alerta();
    }

    private void detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA009"))
        new frmLanzadorInformesVenta("Detalle de Articulos Vendidos con Factura, Según Fecha", "FACTURA009").Show();
      else
        this.alerta();
    }

    private void detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA010"))
        new frmLanzadorInformesVenta("Detalle de Articulos Vendidos con Factura, Por Cliente, Según Fecha", "FACTURA010").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA011"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Factura, Según Fecha", "FACTURA011").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA012"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Factura, Por Cliente, Según Fecha", "FACTURA012").Show();
      else
        this.alerta();
    }

    private void listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA013"))
        new frmLanzadorInformesVenta("Listado de Articulos Vendidos con Factura y su Rentabilidad, Según Fecha", "FACTURA013").Show();
      else
        this.alerta();
    }

    private void visualizarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA014"))
        new frmLanzadorInformesVenta("Visualizar Factura", "FACTURA014").Show();
      else
        this.alerta();
    }

    private void boletaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("BOLETA"))
      {
        if (frmMenuPrincipal._modBoleta != 0)
          return;
        frmMenuPrincipal._modBoleta = 1;
        new frmBoleta().Show();
      }
      else
        this.alerta();
    }

    private void devoluciónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void listadoDeBoletasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA001"))
        new frmLanzadorInformesVenta("Listado de Boletas, Según Fecha", "BOLETA001").Show();
      else
        this.alerta();
    }

    private void listadoDeBoletasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA002"))
        new frmLanzadorInformesVenta("Listado de Boletas por Cliente, Según Fecha", "BOLETA002").Show();
      else
        this.alerta();
    }

    private void listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA003"))
        new frmLanzadorInformesVenta("Listado de Boletas por Vendedor, Según Fecha", "BOLETA003").Show();
      else
        this.alerta();
    }

    private void listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA004"))
        new frmLanzadorInformesVenta("Listado de Boletas por Centro de Costo, Según Fecha", "BOLETA004").Show();
      else
        this.alerta();
    }

    private void listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA005"))
        new frmLanzadorInformesVenta("Listado de Boletas Anuladas, Según Fecha", "BOLETA005").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA006"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Boletas, Según Fecha", "BOLETA006").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA007"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Boletas, Según Fecha", "BOLETA007").Show();
      else
        this.alerta();
    }

    private void listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA008"))
        new frmLanzadorInformesVenta("Listado de Articulos Vendidos con Boletas y su Rentabilidad, Según Fecha", "BOLETA008").Show();
      else
        this.alerta();
    }

    private void visualizarBoletaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA009"))
        new frmLanzadorInformesVenta("Visualizar Boleta", "BOLETA009").Show();
      else
        this.alerta();
    }

    private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("TICKET"))
      {
        if (frmMenuPrincipal._modTicket != 0)
          return;
        frmMenuPrincipal._modTicket = 1;
        new frmTicket().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeTicketsSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("TICKET001"))
        new frmLanzadorInformesVenta("Listado de Tickets, Según Fecha", "TICKET001").Show();
      else
        this.alerta();
    }

    private void listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("TICKET002"))
        new frmLanzadorInformesVenta("Listado de Tickets por Vendedor, Según Fecha", "TICKET002").Show();
      else
        this.alerta();
    }

    private void listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("TICKET003"))
        new frmLanzadorInformesVenta("Listado de Tickets por Cliente, Según Fecha", "TICKET003").Show();
      else
        this.alerta();
    }

    private void listadoDeTicketAnuladosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("TICKET004"))
        new frmLanzadorInformesVenta("Listado de Tickets Anulados, Según Fecha", "TICKET004").Show();
      else
        this.alerta();
    }

    private void visualizarTicketToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("TICKET005"))
        new frmLanzadorInformesVenta("Visualizar Ticket", "TICKET005").Show();
      else
        this.alerta();
    }

    private void cotizacionToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("COTIZACION"))
      {
        if (frmMenuPrincipal._modCotizacion != 0)
          return;
        frmMenuPrincipal._modCotizacion = 1;
        new frmCotizacion().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeCotizacionesSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COTIZACION001"))
        new frmLanzadorInformesVenta("Listado de Cotizaciones, Según Fecha", "COTIZACION001").Show();
      else
        this.alerta();
    }

    private void listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COTIZACION002"))
        new frmLanzadorInformesVenta("Listado de Cotizaciones por Cliente, Según Fecha", "COTIZACION002").Show();
      else
        this.alerta();
    }

    private void listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COTIZACION003"))
        new frmLanzadorInformesVenta("Listado de Cotizaciones por Vendedor, Según Fecha", "COTIZACION003").Show();
      else
        this.alerta();
    }

    private void detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COTIZACION004"))
        new frmLanzadorInformesVenta("Detalle de Articulos Cotizados, Según Fecha", "COTIZACION004").Show();
      else
        this.alerta();
    }

    private void visualizarCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COTIZACION005"))
        new frmLanzadorInformesVenta("Visualizar Cotizacion", "COTIZACION005").Show();
      else
        this.alerta();
    }

    private void detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COTIZACION006"))
        new frmLanzadorInformesVenta("Detalle de Cotizaciones Pendientes de Facturar", "COTIZACION006").Show();
      else
        this.alerta();
    }

    private void guiaDeDespachoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("GUIA"))
      {
        if (frmMenuPrincipal._modGuia != 0)
          return;
        frmMenuPrincipal._modGuia = 1;
        new frmGuiaDespacho().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeGuiasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA001"))
        new frmLanzadorInformesVenta("Listado de Guias, Según Fecha", "GUIA001").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA002"))
        new frmLanzadorInformesVenta("Listado de Guias por Clientes, Según Fecha", "GUIA002").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA003"))
        new frmLanzadorInformesVenta("Listado de Guias por Vendedor, Según Fecha", "GUIA003").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA004"))
        new frmLanzadorInformesVenta("Listado de Guias por Centro de Costo, Según Fecha", "GUIA004").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA005"))
        new frmLanzadorInformesVenta("Listado de Guias Anuladas, Según Fecha", "GUIA005").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA006"))
        new frmLanzadorInformesVenta("Listado de Guias NO Facturadas, Según Fecha", "GUIA006").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA007"))
        new frmLanzadorInformesVenta("Listado de Guias NO Facturadas por Cliente, Según Fecha", "GUIA007").Show();
      else
        this.alerta();
    }

    private void detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA008"))
        new frmLanzadorInformesVenta("Detalle de Articulos vendidos con Guias, Según Fecha", "GUIA008").Show();
      else
        this.alerta();
    }

    private void visualizarGuiaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIA009"))
        new frmLanzadorInformesVenta("Visualizar Guia", "GUIA009").Show();
      else
        this.alerta();
    }

    private void btnNotaVenta_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("NOTA VENTA"))
      {
        if (frmMenuPrincipal._modNotaVenta != 0)
          return;
        frmMenuPrincipal._modNotaVenta = 1;
        new frmNotaVenta().Show();
      }
      else
        this.alerta();
    }

    private void notaDeVenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("NOTA VENTA"))
      {
        if (frmMenuPrincipal._modNotaVenta != 0)
          return;
        frmMenuPrincipal._modNotaVenta = 1;
        new frmNotaVenta().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeNotasDeVentasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA001"))
        new frmLanzadorInformesVenta("Listado de Notas de Venta, Según Fecha", "NOTAVENTA001").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA002"))
        new frmLanzadorInformesVenta("Listado de Notas de Venta por Cliente, Según Fecha", "NOTAVENTA002").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA003"))
        new frmLanzadorInformesVenta("Listado de Notas de Venta por Vendedor, Según Fecha", "NOTAVENTA003").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA004"))
        new frmLanzadorInformesVenta("Listado de Notas de Venta por Centro de Costo, Según Fecha", "NOTAVENTA004").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA005"))
        new frmLanzadorInformesVenta("Listado de Notas de Venta Anuladas, Según Fecha", "NOTAVENTA005").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA006"))
        new frmLanzadorInformesVenta("Listado de Notas de Venta No Facturadas, Según Fecha", "NOTAVENTA006").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA007"))
        new frmLanzadorInformesVenta("Listado de Notas de Venta NO Facturadas por Cliente, Según Fecha", "NOTAVENTA007").Show();
      else
        this.alerta();
    }

    private void listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA008"))
        new frmLanzadorInformesVenta("Detalle de Articulos Vendidos con Nota de Venta, Según Fecha", "NOTAVENTA008").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA009"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Nota de Venta, Según Fecha", "NOTAVENTA009").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA010"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Nota de Venta por Cliente, Según Fecha", "NOTAVENTA010").Show();
      else
        this.alerta();
    }

    private void visualizarNotaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTAVENTA011"))
        new frmLanzadorInformesVenta("Visualizar Nota de Venta", "NOTAVENTA011").Show();
      else
        this.alerta();
    }

    private void notaDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("NOTA CREDITO"))
      {
        if (frmMenuPrincipal._modNotaCredito != 0)
          return;
        frmMenuPrincipal._modNotaCredito = 1;
        new frmNotaCredito().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITO001"))
        new frmLanzadorInformesVenta("Listado de Notas de Credito, Según Fecha", "NOTACREDITO001").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITO002"))
        new frmLanzadorInformesVenta("Listado de Notas de Credito por Cliente, Según Fecha", "NOTACREDITO002").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITO003"))
        new frmLanzadorInformesVenta("Listado de Notas de Credito por Vendedor, Según Fecha", "NOTACREDITO003").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITO004"))
        new frmLanzadorInformesVenta("Listado de Notas de Credito por Centro de Costo, Según Fecha", "NOTACREDITO004").Show();
      else
        this.alerta();
    }

    private void visualizarNotaDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITO005"))
        new frmLanzadorInformesVenta("Visualizar Nota de Credito", "NOTACREDITO005").Show();
      else
        this.alerta();
    }

    private void existenciasPorBodegaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("INVENTARIO001"))
        new frmLanzaInformeInventario("Existencias por Bodega", "INVENTARIO001").Show();
      else
        this.alerta();
    }

    private void listadoGeneralDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("INVENTARIO012"))
        new frmLanzaInformeInventario("Listado General de Precios", "INVENTARIO012").Show();
      else
        this.alerta();
    }

    private void listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("INVENTARIO013"))
        new frmLanzaInformeInventario("Listado General de Precios y su Rentabilidad", "INVENTARIO013").Show();
      else
        this.alerta();
    }

    private void listadoDeArticulosBajoStockMinimoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("INVENTARIO014"))
        new frmLanzaInformeInventario("Listado de Articulos Bajo Stock Minimo", "INVENTARIO014").Show();
      else
        this.alerta();
    }

    private void listadoDeArticulosParaTomaDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("INVENTARIO025"))
        new frmLanzaInformeInventario("Listado de Articulos Para Toma de Inventario", "INVENTARIO025").Show();
      else
        this.alerta();
    }

    private void movimientoDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("MOVIMIENTO001"))
        new frmLanzaInformeInventario("Movimiento de Productos", "MOVIMIENTO001").Show();
      else
        this.alerta();
    }

    private void rankingDeProductosMasVendidosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("MOVIMIENTO002"))
        new frmLanzaInformeInventario("Ranking de Productos mas Vendidos", "MOVIMIENTO002").Show();
      else
        this.alerta();
    }

    private void detalleDeVentasPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("MOVIMIENTO003"))
        new frmLanzaInformeInventario("Detalle de Ventas por Producto", "MOVIMIENTO003").Show();
      else
        this.alerta();
    }

    private void detalleDeComprasPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("MOVIMIENTO004"))
        new frmLanzaInformeInventario("Detalle de Compras por Producto", "MOVIMIENTO004").Show();
      else
        this.alerta();
    }

    private void detalleDeComprasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("MOVIMIENTO005"))
        new frmLanzaInformeInventario("Detalle de Compras por Proveedor", "MOVIMIENTO005").Show();
      else
        this.alerta();
    }

    private void kardexPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("MOVIMIENTO009"))
        new frmLanzaInformeInventario("Kardex por Producto", "MOVIMIENTO009").Show();
      else
        this.alerta();
    }

    private void ingresoDeComprasToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("COMPRAS"))
      {
        if (frmMenuPrincipal._modCompra != 0)
          return;
        frmMenuPrincipal._modCompra = 1;
        new frmIngresoCompra().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeComprasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA001"))
        new frmLanzadorInformesCompras("Listado de Compras, Según Fecha", "COMPRA001").Show();
      else
        this.alerta();
    }

    private void listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA002"))
        new frmLanzadorInformesCompras("Listado de Compras por Proveedor, Según Fecha", "COMPRA002").Show();
      else
        this.alerta();
    }

    private void listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA003"))
        new frmLanzadorInformesCompras("Listado de Compras por Centro de Costo, Según Fecha", "COMPRA003").Show();
      else
        this.alerta();
    }

    private void listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA004"))
        new frmLanzadorInformesCompras("Listado de Facturas de Compras Pendientes de Pagos, Según Fecha", "COMPRA004").Show();
      else
        this.alerta();
    }

    private void listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA005"))
        new frmLanzadorInformesCompras("Listado de Facturas de Compras Pendientes de Pagos por Proveedor, Según Fecha", "COMPRA005").Show();
      else
        this.alerta();
    }

    private void visualizarDocumentoDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA006"))
        new frmLanzadorInformesCompras("Visualizar Documento de Compra, Según Fecha", "COMPRA006").Show();
      else
        this.alerta();
    }

    private void libroDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA007"))
        new frmLanzadorInformesCompras("Libro de Compras", "COMPRA007").Show();
      else
        this.alerta();
    }

    private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA008"))
        new frmLanzadorInformesCompras("Listado de Proveedores", "COMPRA008").Show();
      else
        this.alerta();
    }

    private void libroDeComprasSegúnPeriodoContableToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("COMPRA009"))
        new frmLanzadorInformesCompras("Libro de Compras, Según Periodo Contable", "COMPRA009").Show();
      else
        this.alerta();
    }

    private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("ORDEN COMPRA"))
      {
        if (frmMenuPrincipal._modOrdenCompra != 0)
          return;
        frmMenuPrincipal._modOrdenCompra = 1;
        new frmOrdenCompra().Show();
      }
      else
        this.alerta();
    }

    private void listadoOrdenesDeCompraSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("ORDENCOMP001"))
        new frmLanzadorInformesCompras("Listado de Ordenes de Compra, Según Fecha", "ORDENCOMP001").Show();
      else
        this.alerta();
    }

    private void listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("ORDENCOMP002"))
        new frmLanzadorInformesCompras("Listado de Ordenes de Compra por Proveedor, Según Fecha", "ORDENCOMP002").Show();
      else
        this.alerta();
    }

    private void listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("ORDENCOMP003"))
        new frmLanzadorInformesCompras("Listado de Ordenes de Compra por Centro de Costo, Según Fecha", "ORDENCOMP003").Show();
      else
        this.alerta();
    }

    private void visualizarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("ORDENCOMP004"))
        new frmLanzadorInformesCompras("Visualizar Orden de Compra", "ORDENCOMP004").Show();
      else
        this.alerta();
    }

    private void cierreDeDiaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA001"))
        new frmLanzadorInformesVenta("Resumen de Ventas Diarias", "VENTA001").Show();
      else
        this.alerta();
    }

    private void libroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA002"))
        new frmLanzadorInformesVenta("Libro de Ventas", "VENTA002").Show();
      else
        this.alerta();
    }

    private void libroDeVentasConBoletasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA003"))
        new frmLanzadorInformesVenta("Libro de Ventas con Boletas", "VENTA003").Show();
      else
        this.alerta();
    }

    private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA004"))
        new frmLanzadorInformesVenta("Listado de Clientes", "VENTA004").Show();
      else
        this.alerta();
    }

    private void listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA005"))
        new frmLanzadorInformesVenta("Listado de Articulos Vendidos con Factura y Boletas y su Rentabilidad, Según Fecha", "VENTA005").Show();
      else
        this.alerta();
    }

    private void listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA005"))
        new frmLanzadorInformesVenta("Listado de Articulos Vendidos con Factura y Boletas, Según Fecha", "VENTA016").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA006"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Facturas y Boletas agrupados por Categoria, Según Fecha", "VENTA006").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA007"))
        new frmLanzadorInformesVenta("Listado de Ventas por Vendedor, Según Fecha", "VENTA007").Show();
      else
        this.alerta();
    }

    private void listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA010"))
        new frmLanzadorInformesVenta("Listado de Documentos de Venta Pendientes de Pago, Según Fecha", "VENTA010").Show();
      else
        this.alerta();
    }

    private void resumenDeVentasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA011"))
        new frmLanzadorInformesVenta("Resumen de Ventas, Según Fecha", "VENTA011").Show();
      else
        this.alerta();
    }

    private void detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA013"))
        new frmLanzadorInformesVenta("Detalle de Comisiones por Vendedor, Según Fecha", "VENTA013").Show();
      else
        this.alerta();
    }

    private void documentosPorCobrarSegúnFechaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("PAGOVENTA001"))
        new frmLanzadorInformesVenta("Documentos de Venta por Cobrar, Según Fecha", "PAGOVENTA001").Show();
      else
        this.alerta();
    }

    private void detalleDePagosDeVentasSegúnFechaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (!this.buscaPermisoInforme("PAGOVENTA002"))
        return;
      new frmLanzadorInformesVenta("Detalle de Pagos de Ventas, Según Fecha de Cobro", "PAGOVENTA002").Show();
    }

    private void detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("PAGOVENTA003"))
        new frmLanzadorInformesVenta("Detalle de Pagos de Ventas por Cliente, Según Fecha de Cobro", "PAGOVENTA003").Show();
      else
        this.alerta();
    }

    private void detalleDeClientesMorososToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("PAGOVENTA004"))
        new frmLanzadorInformesVenta("Detalle de Clientes Morosos", "PAGOVENTA004").Show();
      else
        this.alerta();
    }

    private void listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("PAGOVENTA005"))
        new frmLanzadorInformesVenta("Listado de Ventas por Estado de Documento, Según Fecha", "PAGOVENTA005").Show();
      else
        this.alerta();
    }

    private void documentosSegunFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("PAGOCOMPRA001"))
        new frmLanzadorInformesCompras("Documentos por Pagar, Según Fecha", "PAGOCOMPRA001").Show();
      else
        this.alerta();
    }

    private void detalleDePagosDeComprasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("PAGOCOMPRA002"))
        new frmLanzadorInformesCompras("Detalle de Pagos de Compra, Según Fecha", "PAGOCOMPRA002").Show();
      else
        this.alerta();
    }

    private void detalleDePagosPorProveedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("PAGOCOMPRA003"))
        new frmLanzadorInformesCompras("Detalle de Pagos de Compra por Proveedor, Según Fecha", "PAGOCOMPRA003").Show();
      else
        this.alerta();
    }

    private void crearKitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmKit().Show();
    }

    private void armarKitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmArmaKit().Show();
    }

    private void visualizaFormulaDeKitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("KIT001"))
        new frmLanzaInformeInventario("Visualizar Formula de Kit", "KIT001").Show();
      else
        this.alerta();
    }

    private void detalleDeKitArmadosSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("KIT002"))
        new frmLanzaInformeInventario("Detalle de Kit Armados, Según Fecha", "KIT002").Show();
      else
        this.alerta();
    }

    private void traspasoInternoEntreBodegasToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void controlDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void controlDeCajaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (!this.buscaPermiso("CONTROL CAJA") || frmMenuPrincipal._modControlCaja != 0)
        return;
      frmMenuPrincipal._modControlCaja = 1;
      new frmControlCaja().Show();
    }

    private void listadoDeControlToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("CONTROLCAJA001"))
        new frmLanzadorInformesVenta("Listado de Movimientos de Caja, Según Fecha", "CONTROLCAJA001").Show();
      else
        this.alerta();
    }

    private void btnVender_Click(object sender, EventArgs e)
    {
      this.pnlVenta.Visible = true;
      this.pnlVentasElectronicas.Visible = false;
      this.pnlCompra.Visible = false;
      this.pnlInventario.Visible = false;
      this.pnlOpciones.Visible = false;
    }

    private void btnVentaElectronica_Click(object sender, EventArgs e)
    {
      this.pnlVenta.Visible = false;
      this.pnlVentasElectronicas.Visible = true;
      this.pnlCompra.Visible = false;
      this.pnlInventario.Visible = false;
      this.pnlOpciones.Visible = false;
    }

    private void btnComprar_Click(object sender, EventArgs e)
    {
      this.pnlVenta.Visible = false;
      this.pnlVentasElectronicas.Visible = false;
      this.pnlCompra.Visible = true;
      this.pnlInventario.Visible = false;
      this.pnlOpciones.Visible = false;
    }

    private void btnInventario_Click(object sender, EventArgs e)
    {
      this.pnlVenta.Visible = false;
      this.pnlVentasElectronicas.Visible = false;
      this.pnlCompra.Visible = false;
      this.pnlInventario.Visible = true;
      this.pnlOpciones.Visible = false;
    }

    private void btnOpcion_Click(object sender, EventArgs e)
    {
      this.pnlVenta.Visible = false;
      this.pnlVentasElectronicas.Visible = false;
      this.pnlCompra.Visible = false;
      this.pnlInventario.Visible = false;
      this.pnlOpciones.Visible = true;
    }

    private void respaldarInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmRespaldo().Show();
    }

    private void fToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("FACTURA EXENTA"))
      {
        if (frmMenuPrincipal._modFacturaExenta != 0)
          return;
        frmMenuPrincipal._modFacturaExenta = 1;
        new frmFacturaExenta().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeFacturasExentasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTA001"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas,  Según Fecha", "FACTURAEXENTA001").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTA002"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas por Cliente,  Según Fecha", "FACTURAEXENTA002").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTA003"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas por Vendedor,  Según Fecha", "FACTURAEXENTA003").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTA004"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas Pendientes de Pagos,  Según Fecha", "FACTURAEXENTA004").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTA005"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas Pendientes de Pagos por Clientes,  Según Fecha", "FACTURAEXENTA005").Show();
      else
        this.alerta();
    }

    private void detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTA006"))
        new frmLanzadorInformesVenta("Detalle de Articulos Vendidos con Facturas Exentas, Según Fecha", "FACTURAEXENTA006").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTA007"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Facturas Exentas, Según Fecha", "FACTURAEXENTA007").Show();
      else
        this.alerta();
    }

    private void visualizarFacturaExentaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTA008"))
        new frmLanzadorInformesVenta("Visualizar Factura Exenta", "FACTURAEXENTA008").Show();
      else
        this.alerta();
    }

    private void btnPruebas_Click(object sender, EventArgs e)
    {
    }

    private void ordenDeAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (frmMenuPrincipal._modOrdenAtencion != 0)
        return;
      frmMenuPrincipal._modOrdenAtencion = 1;
      new frmOrdenAtencion().Show();
    }

    private void informesToolStripMenuItem1_Click(object sender, EventArgs e)
    {
    }

    private void informesToolStripMenuItem4_Click(object sender, EventArgs e)
    {
    }

    private void informesToolStripMenuItem8_Click(object sender, EventArgs e)
    {
    }

    private void moduloFiscalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmModuloFiscal().Show();
    }

    private void btnBoletaFiscal_Click(object sender, EventArgs e)
    {
        try
        {
            if (frmMenuPrincipal._modBoleta == 0)
            {
                double num1 = new ControlFiscal().ultimaZ();
                if (num1 <= 24.0)
                {
                    frmMenuPrincipal._modBoleta = 1;
                    new frmBoletaFiscal().Show();
                }
                else
                {
                    int num2 = (int)MessageBox.Show("El Ultimo Cierre Z fue Emitido hace " + num1.ToString("N0") + " Horas, No Puede hacer Ventas, mientras No lo emita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    int num3 = (int)new frmModuloFiscal().ShowDialog();
                }
            }
               // this.alerta();
        }catch(Exception ex){

        }
              
    }

    private void boletaFiscalToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("BOLETA"))
      {
        if (frmMenuPrincipal._modBoleta != 0)
          return;
        frmMenuPrincipal._modBoleta = 1;
        new frmBoletaFiscal().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA001"))
        new frmLanzadorInformesVenta("Listado de Boletas Fiscales, Según Fecha", "BOLETAFISCAL001").Show();
      else
        this.alerta();
    }

    private void listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA002"))
        new frmLanzadorInformesVenta("Listado de Boletas Fiscales por Cliente, Según Fecha", "BOLETAFISCAL002").Show();
      else
        this.alerta();
    }

    private void listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA003"))
        new frmLanzadorInformesVenta("Listado de Boletas Fiscales por Vendedor, Según Fecha", "BOLETAFISCAL003").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA006"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Boletas, Según Fecha", "BOLETAFISCAL006").Show();
      else
        this.alerta();
    }

    private void resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA007"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Boletas Fiscales, Según Fecha", "BOLETAFISCAL007").Show();
      else
        this.alerta();
    }

    private void listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA008"))
        new frmLanzadorInformesVenta("Listado de Articulos Vendidos con Boletas Fiscales y su Rentabilidad, Según Fecha", "BOLETAFISCAL008").Show();
      else
        this.alerta();
    }

    private void visualizarBoletaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETA009"))
        new frmLanzadorInformesVenta("Visualizar Boleta", "BOLETAFISCAL009").Show();
      else
        this.alerta();
    }

    public void reboot()
    {
        Application.Restart();
    }
    private void frmMenuPrincipal_Load(object sender, EventArgs e)
    {
    }

    private void ingresoDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void listadoDeGastosSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("SERVICIO001"))
        new frmLanzadorInformesCompras("Listado de Gastos de Servicios, Según Fecha", "SERVICIO001").Show();
      else
        this.alerta();
    }

    private void ingresoDeGastosDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("SERVICIOS"))
      {
        if (frmMenuPrincipal._modServicio != 0)
          return;
        frmMenuPrincipal._modServicio = 1;
        new frmServicio().Show();
      }
      else
        this.alerta();
    }

    private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("BANCOS"))
      {
        if (frmMenuPrincipal._modBanco != 0)
          return;
        frmMenuPrincipal._modBanco = 1;
        new frmBanco().Show();
      }
      else
        this.alerta();
    }

    private void periodosContablesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("PERIODOS"))
      {
        if (frmMenuPrincipal._modPeriodoContable != 0)
          return;
        frmMenuPrincipal._modPeriodoContable = 1;
        new frmPeriodoContable().Show();
      }
      else
        this.alerta();
    }

    private void traspasosInternosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!this.buscaPermiso("TRASPASO INTERNO") || frmMenuPrincipal._modTraspasos != 0)
        return;
      frmMenuPrincipal._modTraspasos = 1;
      new frmTraspasoInterno().Show();
    }

    private void listadoDeTraspasosSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("TraspasoInterno001"))
        new frmLanzaInformeInventario("Listado de Traspasos, Según Fecha", "TraspasoInterno001").Show();
      else
        this.alerta();
    }

    private void detalleDeTraspasosSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("TraspasoInterno002"))
        new frmLanzaInformeInventario("Detalle de Traspasos, Según Fecha", "TraspasoInterno002").Show();
      else
        this.alerta();
    }

    private void ordenDeTrabajoToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("ORDEN TRABAJO"))
      {
        if (frmMenuPrincipal._modOT != 0)
          return;
        frmMenuPrincipal._modOT = 1;
        new frmOrdenTrabajo().Show();
      }
      else
        this.alerta();
    }

    private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("TECNICO"))
      {
        if (frmMenuPrincipal._modTecnico != 0)
          return;
        frmMenuPrincipal._modTecnico = 1;
        int num = (int) new frmTecnico().ShowDialog();
      }
      else
        this.alerta();
    }

    private void listadoDeOTSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("ORDENTRABAJO001"))
        new frmLanzadorInformesVenta("Listado de OT, Según Fecha", "ORDENTRABAJO001").Show();
      else
        this.alerta();
    }

    private void libroDeVentasConBoletaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("VENTA003"))
        new frmLanzadorInformesVenta("Libro de Ventas con Boleta Fiscal", "VENTA014").Show();
      else
        this.alerta();
    }

    private void garzonesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("GARZONES"))
      {
        if (frmMenuPrincipal._modGarzon != 0)
          return;
        frmMenuPrincipal._modGarzon = 1;
        new frmGarzon().Show();
      }
      else
        this.alerta();
    }

    private void atenciónToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("COMANDA"))
      {
        if (frmMenuPrincipal._modComanda != 0)
          return;
        frmMenuPrincipal._modComanda = 1;
        new frmAtencionRestaurant().Show();
      }
      else
        this.alerta();
    }

    private void listadoDeComandasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURA001"))
        new frmLanzadorInformesVenta("Listado de Comandas, Según Fechas", "COMANDA001").Show();
      else
        this.alerta();
    }

    private void restaurantToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.lblConexion.Text = (Convert.ToInt32(this.lblConexion.Text) + 3).ToString();
      this.pruebaConexion();
      this.buscaDocumentosElectronicosSinEnviar();
    }

    private void buscaDocumentosElectronicosSinEnviar()
    {
        this.lblDocumentosElectronicosSinEnviar.Text = "Documento Electronicos Sin Enviar : " + new GeneraEnvios().buscaDocumentosSinEnviarParaAlerta().ToString();
    }

    private void pruebaConexion()
    {
      try
      {
        Conexion.reconexion();
      }
      catch
      {
        int num = (int) MessageBox.Show("Error al Conectar", "Conexión Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void preClienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmPreCliente().Show();
    }

    private void preVentaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmPreVentas().Show();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void devolucionDeProductosConBoletasToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void devolucionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("BOLETA"))
        new frmDevolucion().Show();
      else
        this.alerta();
    }

    private void listadoDeDevolucionesSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLanzadorInformesVenta("Listado de Devoluciones, Según Fecha", "DEVOLUCION001").Show();
    }

    private void moduloFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void mantenedorDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("PRODUCTO"))
      {
        if (frmMenuPrincipal._modMaestroProducto != 0)
          return;
        frmMenuPrincipal._modMaestroProducto = 1;
        new frmMantenedorDeProductos().Show();
      }
      else
        this.alerta();
    }

    private void configuracionBotonesComandaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmConfiguracionBotones().ShowDialog();
    }

    private void cAFToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("CAF"))
      {
        if (Application.OpenForms["frmCaf"] == null)
        {
          new frmCaf().Show();
        }
        else
        {
          Application.OpenForms["frmCaf"].WindowState = FormWindowState.Normal;
          Application.OpenForms["frmCaf"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void facturaElectronicaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("E-FACTURA"))
      {
        if (Application.OpenForms["frmFacturaElectronica"] == null)
        {
          new frmFacturaElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmFacturaElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmFacturaElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void datosDelEmisorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Application.OpenForms["frmEmisor"] == null)
      {
        new frmEmisor().Show();
      }
      else
      {
        Application.OpenForms["frmEmisor"].WindowState = FormWindowState.Normal;
        Application.OpenForms["frmEmisor"].BringToFront();
      }
    }

    private void mantenedorDePromocionesToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void mantenedorDePromocionesToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (Application.OpenForms["frmPromocion"] == null)
      {
        new frmPromocion().Show();
      }
      else
      {
        Application.OpenForms["frmPromocion"].WindowState = FormWindowState.Normal;
        Application.OpenForms["frmPromocion"].BringToFront();
      }
    }

    private void notaDeCreditoElectronicaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("E-NOTA CREDITO"))
      {
        if (Application.OpenForms["frmNotaCreditoElectronica"] == null)
        {
          new frmNotaCreditoElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmNotaCreditoElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmNotaCreditoElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void facturaElectronicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void notaDeDebitoElectronicaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("E-NOTA DEBITO"))
      {
        if (Application.OpenForms["frmNotaDebitoElectronica"] == null)
        {
          new frmNotaDebitoElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmNotaDebitoElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmNotaDebitoElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void generadorDeEnviosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("GENERADOR_ENVIOS"))
      {
        if (Application.OpenForms["frmGeneraodrDeEnvios"] == null)
        {
          new frmGeneraodrDeEnvios().Show();
        }
        else
        {
          Application.OpenForms["frmGeneraodrDeEnvios"].WindowState = FormWindowState.Normal;
          Application.OpenForms["frmGeneraodrDeEnvios"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void intercambioDeInformacionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmIntercambioDeInformacion().Show();
    }

    private void listadoDeFacturasSegúnFechaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAELECTRONICA001"))
        new frmLanzadorInformesVenta("Listado de Facturas Electronicas Según Fecha", "FACTURAELECTRONICA001").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAELECTRONICA002"))
        new frmLanzadorInformesVenta("Listado de Facturas Electronicas por Cliente Según Fecha", "FACTURAELECTRONICA002").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAELECTRONICA003"))
        new frmLanzadorInformesVenta("Listado de Facturas Electronicas por Vendedor Según Fecha", "FACTURAELECTRONICA003").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAELECTRONICA004"))
        new frmLanzadorInformesVenta("Listado de Facturas Electronicas Por Centro de Costo, Según Fecha", "FACTURAELECTRONICA004").Show();
      else
        this.alerta();
    }

    private void listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAELECTRONICA005"))
        new frmLanzadorInformesVenta("Listado de Facturas Electronicas Pendientes de Pago Según Fecha", "FACTURAELECTRONICA005").Show();
      else
        this.alerta();
    }

    private void listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAELECTRONICA006"))
        new frmLanzadorInformesVenta("Listado de Productos vendidos por fecha, agrupados por categoria", "FACTURAELECTRONICA006").Show();
      else
        this.alerta();
    }

    private void visualizarFacturaElectronicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAELECTRONICA014"))
        new frmLanzadorInformesVenta("Visualizar Factura Electronica", "FACTURAELECTRONICA014").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITOELECTRONICA001"))
        new frmLanzadorInformesVenta("Listado de Notas de Credito Electronicas, Según Fecha", "NOTACREDITOELECTRONICA001").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITOELECTRONICA002"))
        new frmLanzadorInformesVenta("Listado de Notas de Credito Electronicas Por Cliente, Según Fecha", "NOTACREDITOELECTRONICA002").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITOELECTRONICA003"))
        new frmLanzadorInformesVenta("Listado de Notas de Credito Electronicas Por Vendedor, Según Fecha", "NOTACREDITOELECTRONICA003").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITOELECTRONICA004"))
        new frmLanzadorInformesVenta("Listado de Notas de Credito Electronicas Por Centro de Costo, Según Fecha", "NOTACREDITOELECTRONICA004").Show();
      else
        this.alerta();
    }

    private void visualizarNotaDeCreditoElectronicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTACREDITOELECTRONICA005"))
        new frmLanzadorInformesVenta("Visualizar Nota de Credito Electronica", "NOTACREDITOELECTRONICA005").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTADEBITOELECTRONICA001"))
        new frmLanzadorInformesVenta("Listado de Notas de Debito Electronicas, Según Fecha", "NOTADEBITOELECTRONICA001").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTADEBITOELECTRONICA002"))
        new frmLanzadorInformesVenta("Listado de Notas de Debito Electronicas por Cliente, Según Fecha", "NOTADEBITOELECTRONICA002").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTADEBITOELECTRONICA003"))
        new frmLanzadorInformesVenta("Listado de Notas de Debito Electronicas por Vendedor, Según Fecha", "NOTADEBITOELECTRONICA003").Show();
      else
        this.alerta();
    }

    private void listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTADEBITOELECTRONICA004"))
        new frmLanzadorInformesVenta("Listado de Notas de Debito Electronicas por Centro de Costo, Según Fecha", "NOTADEBITOELECTRONICA004").Show();
      else
        this.alerta();
    }

    private void visualizarNotaDeDebitoElectronicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("NOTADEBITOELECTRONICA005"))
        new frmLanzadorInformesVenta("Visualizar Nota de Debito Electronica", "NOTADEBITOELECTRONICA005").Show();
      else
        this.alerta();
    }

    private void opcionesLocalesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmOpcionesLocalesFacturaElectronica().ShowDialog();
    }

    private void intercambioDeInformacionToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      new frmIntercambioDeInformacion().Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      new frmVisualizaWebPDF().Show();
    }

    private void guiaDeDespachoElectronicaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("E-GUIA"))
      {
        if (Application.OpenForms["frmGuiaDespachoElectronica"] == null)
        {
          new frmGuiaDespachoElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmGuiaDespachoElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmGuiaDespachoElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIAELECTRONICA001"))
        new frmLanzadorInformesVenta("Listado de Guia Electronicas Según Fecha", "GUIAELECTRONICA001").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIAELECTRONICA002"))
        new frmLanzadorInformesVenta("Listado de Guias Electronicas por Cliente Según Fecha", "GUIAELECTRONICA002").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIAELECTRONICA003"))
        new frmLanzadorInformesVenta("Listado de Guias Electronicas por Vendedor Según Fecha", "GUIAELECTRONICA003").Show();
      else
        this.alerta();
    }

    private void listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIAELECTRONICA004"))
        new frmLanzadorInformesVenta("Listado de Guias Electronicas Por Centro de Costo, Según Fecha", "GUIAELECTRONICA004").Show();
      else
        this.alerta();
    }

    private void visualizarGuiasElectronicaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIAELECTRONICA014"))
        new frmLanzadorInformesVenta("Visualizar Guia Electronica", "GUIAELECTRONICA014").Show();
      else
        this.alerta();
    }

    private void guiasElectronicasNOFacturadasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("GUIAELECTRONICA005"))
        new frmLanzadorInformesVenta("Guias Electronicas NO Facturadas", "GUIAELECTRONICA005").Show();
      else
        this.alerta();
    }

    private void moduloFacturacionToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      new frmModuloFacturacionAptusoft().Show();
    }

    private void maestroDeOfertasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Application.OpenForms["frmOferta"] == null)
        new frmOferta().Show();
      else
        Application.OpenForms["frmOferta"].BringToFront();
    }

    private void moduloDeContratacionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Application.OpenForms["frmContratacion"] == null)
        new frmContratacion().Show();
      else
        Application.OpenForms["frmContratacion"].BringToFront();
    }

    private void facturaExentaElectronicaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("E-FACTURA-EXENTA"))
      {
        if (Application.OpenForms["frmFacturaExentaElectronica"] == null)
        {
          new frmFacturaExentaElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmFacturaExentaElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmFacturaExentaElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTAELECTRONICA001"))
        new frmLanzadorInformesVenta("Listado de Facturas Exenta Electronicas Según Fecha", "FACTURAEXENTAELECTRONICA001").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTAELECTRONICA002"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas Electronicas por Cliente Según Fecha", "FACTURAEXENTAELECTRONICA002").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem3_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTAELECTRONICA003"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas Electronicas por Vendedor Según Fecha", "FACTURAEXENTAELECTRONICA003").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem5_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTAELECTRONICA004"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas Electronicas Por Centro de Costo, Según Fecha", "FACTURAEXENTAELECTRONICA004").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem4_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTAELECTRONICA005"))
        new frmLanzadorInformesVenta("Listado de Facturas Exentas Electronicas Pendientes de Pago Según Fecha", "FACTURAEXENTAELECTRONICA005").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem6_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTAELECTRONICA006"))
        new frmLanzadorInformesVenta("Listado de Productos vendidos por fecha, agrupados por categoria", "FACTURAEXENTAELECTRONICA006").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem7_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("FACTURAEXENTAELECTRONICA014"))
        new frmLanzadorInformesVenta("Visualizar Factura Exenta Electronica", "FACTURAEXENTAELECTRONICA014").Show();
      else
        this.alerta();
    }

    private void pnlVenta_Paint(object sender, PaintEventArgs e)
    {
    }

    private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("RUBROS"))
      {
        if (Application.OpenForms["frmRubro"] == null)
        {
          new frmRubro().Show();
        }
        else
        {
          Application.OpenForms["frmRubro"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmRubro"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLanzadorInformesVenta("Listado de Articulos Vendidos Por Rubro, Según Fecha", "VENTA017").Show();
    }

    private void maestroDeBodegasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmMantenedorBodegaCajaListaOtros("BODEGA").Show();
    }

    private void mestroDeListasDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmMantenedorBodegaCajaListaOtros("LISTA_PRECIO").Show();
    }

    private void maestroDeCajasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmMantenedorBodegaCajaListaOtros("CAJAS").Show();
    }

    private void entradaDeProductosABodegaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("MOVIMIENTO010"))
        new frmLanzaInformeInventario("Entrada de Productos a Bodega", "MOVIMIENTO010").Show();
      else
        this.alerta();
    }

    private void seguimientoLoteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLanzaInformeInventario("Seguimiento Lote", "MOVIMIENTO011").Show();
    }

    private void seguimientoLotePorCodigoProductoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLanzaInformeInventario("Seguimiento Lote", "MOVIMIENTO012").Show();
    }

    private void boletaElectronicaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("E-BOLETA"))
      {
        if (Application.OpenForms["frmBoletaElectronica"] == null)
        {
          new frmBoletaElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmBoletaElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmBoletaElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void toolStripMenuItem8_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA001"))
        new frmLanzadorInformesVenta("Listado de Boletas, Según Fecha", "BOLETAELECTRONICA001").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem9_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA002"))
        new frmLanzadorInformesVenta("Listado de Boletas por Cliente, Según Fecha", "BOLETAELECTRONICA002").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem10_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA003"))
        new frmLanzadorInformesVenta("Listado de Boletas por Vendedor, Según Fecha", "BOLETAELECTRONICA003").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem11_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA004"))
        new frmLanzadorInformesVenta("Listado de Boletas por Centro de Costo, Según Fecha", "BOLETAELECTRONICA004").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem12_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA005"))
        new frmLanzadorInformesVenta("Listado de Boletas Anuladas, Según Fecha", "BOLETAELECTRONICA005").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem13_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA006"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Boletas, Según Fecha", "BOLETAELECTRONICA006").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem14_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA007"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Boletas, Según Fecha", "BOLETAELECTRONICA007").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem15_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA008"))
        new frmLanzadorInformesVenta("Listado de Articulos Vendidos con Boletas y su Rentabilidad, Según Fecha", "BOLETAELECTRONICA008").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem16_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAELECTRONICA009"))
        new frmLanzadorInformesVenta("Visualizar Boleta", "BOLETAELECTRONICA009").Show();
      else
        this.alerta();
    }

    private void boletaElectronicaExentaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("E-BOLETA-EXENTA"))
      {
        if (Application.OpenForms["frmBoletaElectronica"] == null)
        {
          new frmBoletaElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmBoletaElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmBoletaElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void toolStripMenuItem17_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA001"))
        new frmLanzadorInformesVenta("Listado de Boletas, Según Fecha", "BOLETAEXENTAELECTRONICA001").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem18_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA002"))
        new frmLanzadorInformesVenta("Listado de Boletas por Cliente, Según Fecha", "BOLETAEXENTAELECTRONICA002").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem19_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA003"))
        new frmLanzadorInformesVenta("Listado de Boletas por Vendedor, Según Fecha", "BOLETAEXENTAELECTRONICA003").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem20_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA004"))
        new frmLanzadorInformesVenta("Listado de Boletas por Centro de Costo, Según Fecha", "BOLETAEXENTAELECTRONICA004").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem21_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA005"))
        new frmLanzadorInformesVenta("Listado de Boletas Anuladas, Según Fecha", "BOLETAEXENTAELECTRONICA005").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem22_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA006"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Boletas, Según Fecha", "BOLETAEXENTAELECTRONICA006").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem23_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA007"))
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Boletas, Según Fecha", "BOLETAEXENTAELECTRONICA007").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem24_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA008"))
        new frmLanzadorInformesVenta("Listado de Articulos Vendidos con Boletas y su Rentabilidad, Según Fecha", "BOLETAEXENTAELECTRONICA008").Show();
      else
        this.alerta();
    }

    private void toolStripMenuItem25_Click(object sender, EventArgs e)
    {
      if (this.buscaPermisoInforme("BOLETAEXENTAELECTRONICA009"))
        new frmLanzadorInformesVenta("Visualizar Boleta", "BOLETAEXENTAELECTRONICA009").Show();
      else
        this.alerta();
    }

    private void btnCaf_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("CAF"))
      {
        if (Application.OpenForms["frmCaf"] == null)
        {
          new frmCaf().Show();
        }
        else
        {
          Application.OpenForms["frmCaf"].WindowState = FormWindowState.Normal;
          Application.OpenForms["frmCaf"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void btnEnvios_Click(object sender, EventArgs e)
    {
         validarDatosEmisor vl = new validarDatosEmisor();
        if (vl.valUser())
        {
      if (this.buscaPermiso("GENERADOR_ENVIOS"))
      {
        if (Application.OpenForms["frmGeneraodrDeEnvios"] == null)
        {
          new frmGeneraodrDeEnvios().Show();
        }
        else
        {
          Application.OpenForms["frmGeneraodrDeEnvios"].WindowState = FormWindowState.Normal;
          Application.OpenForms["frmGeneraodrDeEnvios"].BringToFront();
        }
      }
      else
        this.alerta();
        }
        else
        {
            MessageBox.Show("No hay datos de emisor,Por favor ingrese los datos e intente una vez mas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new frmEmisor().Show();
        }
    }

    private void btnEFactura_Click(object sender, EventArgs e)
    {
        validarDatosEmisor vl = new validarDatosEmisor();
        if (vl.valUser())
        {
            if (this.buscaPermiso("E-FACTURA"))
            {
                if (!_esFrigo)
                {
                    if (Application.OpenForms["frmFacturaElectronica"] == null)
                    {
                        new frmFacturaElectronica().Show();
                    }
                    else
                    {
                        Application.OpenForms["frmFacturaElectronica"].WindowState = FormWindowState.Maximized;
                        Application.OpenForms["frmFacturaElectronica"].BringToFront();
                    }
                }
                else
                {
                    if (Application.OpenForms["frmFacturaElectronicaFrigo"] == null)
                    {
                        new frmFacturaElectronicaFrigo().Show();
                    }
                    else
                    {
                        Application.OpenForms["frmFacturaElectronicaFrigo"].WindowState = FormWindowState.Maximized;
                        Application.OpenForms["frmFacturaElectronicaFrigo"].BringToFront();
                    }
                }
            }
            else
                this.alerta();
        }
        else
        {
            MessageBox.Show("No hay datos de emisor,Por favor ingrese los datos e intente una vez mas","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            new frmEmisor().Show();
        }
    }

    private void btnEFacturaExenta_Click(object sender, EventArgs e)
    { validarDatosEmisor vl = new validarDatosEmisor();
        if (vl.valUser())
        {
      if (this.buscaPermiso("E-FACTURA-EXENTA"))
      {
        if (Application.OpenForms["frmFacturaExentaElectronica"] == null)
        {
          new frmFacturaExentaElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmFacturaExentaElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmFacturaExentaElectronica"].BringToFront();
        }
      }
      else
          this.alerta();
        }
        else
        {
            MessageBox.Show("No hay datos de emisor,Por favor ingrese los datos e intente una vez mas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new frmEmisor().Show();
        }
    }

    private void btnENotaCredito_Click(object sender, EventArgs e)
    {
        validarDatosEmisor vl = new validarDatosEmisor();
        if (vl.valUser())
        {
      if (this.buscaPermiso("E-NOTA CREDITO"))
      {
        if (Application.OpenForms["frmNotaCreditoElectronica"] == null)
        {
          new frmNotaCreditoElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmNotaCreditoElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmNotaCreditoElectronica"].BringToFront();
        }
      }
      else{    this.alerta(); } 

        }
        else
        {
            MessageBox.Show("No hay datos de emisor,Por favor ingrese los datos e intente una vez mas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new frmEmisor().Show();
        }
    }

    private void btnEnotaDebito_Click(object sender, EventArgs e)
    {
        validarDatosEmisor vl = new validarDatosEmisor();
        if (vl.valUser())
        {
      if (this.buscaPermiso("E-NOTA DEBITO"))
      {
        if (Application.OpenForms["frmNotaDebitoElectronica"] == null)
        {
          new frmNotaDebitoElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmNotaDebitoElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmNotaDebitoElectronica"].BringToFront();
        }
      }
      else
          this.alerta();
        }
        else
        {
            MessageBox.Show("No hay datos de emisor,Por favor ingrese los datos e intente una vez mas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new frmEmisor().Show();
        }
    }

    private void btnEGuias_Click(object sender, EventArgs e)
    {
        validarDatosEmisor vl = new validarDatosEmisor();
        if (vl.valUser())
        {
      if (this.buscaPermiso("E-GUIA"))
      {
        if (Application.OpenForms["frmGuiaDespachoElectronica"] == null)
        {
          new frmGuiaDespachoElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmGuiaDespachoElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmGuiaDespachoElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
        }
        else
        {
            MessageBox.Show("No hay datos de emisor,Por favor ingrese los datos e intente una vez mas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new frmEmisor().Show();
        }
    }

    private void btnEBoleta_Click(object sender, EventArgs e)
    {
        validarDatosEmisor vl = new validarDatosEmisor();
        if (vl.valUser())
        {
      if (this.buscaPermiso("E-BOLETA"))
      {
        if (Application.OpenForms["frmBoletaElectronica"] == null)
        {
          new frmBoletaElectronica().Show();
        }
        else
        {
          Application.OpenForms["frmBoletaElectronica"].WindowState = FormWindowState.Maximized;
          Application.OpenForms["frmBoletaElectronica"].BringToFront();
        }
      }
      else
        this.alerta();
        }
        else
        {
            MessageBox.Show("No hay datos de emisor,Por favor ingrese los datos e intente una vez mas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new frmEmisor().Show();
        }
    }

    private void tomaDeInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("TOMA_INVENTARIO"))
      {
        if (Application.OpenForms["frmTomaInventario"] == null)
        {
          new frmTomaInventario().Show();
        }
        else
        {
          Application.OpenForms["frmTomaInventario"].WindowState = FormWindowState.Normal;
          Application.OpenForms["frmTomaInventario"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    private void listadoDeTomaDeInventarioSegunFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLanzaInformeInventario("Listado de Toma de Inventario Segun Fecha", "TOMAINVENTARIO001").Show();
    }

    private void cuentaCorrienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.buscaPermiso("CUENTA CORRIENTE"))
      {
        if (Application.OpenForms["frmModuloFacturacionAptusoft"] == null)
        {
          new frmModuloFacturacionAptusoft().Show();
        }
        else
        {
          Application.OpenForms["frmModuloFacturacionAptusoft"].WindowState = FormWindowState.Normal;
          Application.OpenForms["frmModuloFacturacionAptusoft"].BringToFront();
        }
      }
      else
        this.alerta();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaCorrienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaExentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasExentasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarFacturaExentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluciónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarBoletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosManualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoBoletasManualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasIngresadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaFiscalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarBoletaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionDeProductosConBoletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeDevolucionesSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiaDeDespachoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarGuiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarNotaDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCotizacionesSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTicketsSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTicketAnuladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeVenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeVentasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarNotaDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.controlDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeCajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.informesGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDeVentasConBoletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeVentasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDeVentasConBoletaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosPorCobrarSegúnFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDePagosDeVentasSegúnFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeClientesMorososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeComprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeComprasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarDocumentoDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDeComprasSegúnPeriodoContableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoOrdenesDeCompraSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarOrdenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeGastosDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGastosSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.informesDePagosDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosSegunFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDePagosDeComprasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDePagosPorProveedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearKitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armarKitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaFormulaDeKitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeKitArmadosSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasoInternoEntreBodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspasosInternosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTraspasosSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeTraspasosSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorDePromocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorDePromocionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.tomaDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tomaDeInventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTomaDeInventarioSegunFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.informesToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasPorBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosBajoStockMinimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosParaTomaDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.movimientoDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingDeProductosMasVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeVentasPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeComprasPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeComprasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexPorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProductosABodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguimientoLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguimientoLotePorCodigoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorizacionDeExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeOTSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenciónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeAtenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloFacturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloFacturacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDeOfertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloDeContratacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.facturaElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaElectronicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasSegúnFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarFacturaElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaExentaElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaExentaElectronicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeCreditoElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeCreditoElectronicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarNotaDeCreditoElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeDebitoElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeDebitoElectronicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarNotaDeDebitoElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiaDeDespachoElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiaDeDespachoElectronicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiasElectronicasNOFacturadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarGuiasElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaElectronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaElectronicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaElectronicaExentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaElectronicaExentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.comprasElectronicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intercambioDeInformacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.generadorDeEnviosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.datosDelEmisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesLocalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garzonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionBotonesComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeComandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosEspecialesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediosDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediosDePagoFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeCostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDeBodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mestroDeListasDePrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDeCajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odepaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarInstalacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generadorDeCodigosDeBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arriendosDeMaquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosDeMaquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.btnBoletaFiscal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPagosVentas = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnNotaVenta = new System.Windows.Forms.Button();
            this.btnGuia = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnBoleta = new System.Windows.Forms.Button();
            this.pnlCompra = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPagoCompras = new System.Windows.Forms.Button();
            this.btnOrdenCompra = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnIngresoCompra = new System.Windows.Forms.Button();
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnUnidMedidas = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnTipoUsuario = new System.Windows.Forms.Button();
            this.btnImpresoras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbFrigo = new System.Windows.Forms.CheckBox();
            this.lblDocumentosElectronicosSinEnviar = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFiscal = new System.Windows.Forms.Label();
            this.pnlVentasElectronicas = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEBoleta = new System.Windows.Forms.Button();
            this.btnEFacturaExenta = new System.Windows.Forms.Button();
            this.btnEnotaDebito = new System.Windows.Forms.Button();
            this.btnENotaCredito = new System.Windows.Forms.Button();
            this.btnEGuias = new System.Windows.Forms.Button();
            this.btnCaf = new System.Windows.Forms.Button();
            this.btnEFactura = new System.Windows.Forms.Button();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.btnVentaElectronica = new System.Windows.Forms.Button();
            this.btnOpcion = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlVenta.SuspendLayout();
            this.pnlCompra.SuspendLayout();
            this.pnlInventario.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlVentasElectronicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            resources.ApplyResources(this.ventasToolStripMenuItem, "ventasToolStripMenuItem");
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            resources.ApplyResources(this.comprasToolStripMenuItem, "comprasToolStripMenuItem");
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            resources.ApplyResources(this.inventarioToolStripMenuItem, "inventarioToolStripMenuItem");
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impuestosEspecialesToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            resources.ApplyResources(this.opcionesToolStripMenuItem, "opcionesToolStripMenuItem");
            // 
            // impuestosEspecialesToolStripMenuItem
            // 
            this.impuestosEspecialesToolStripMenuItem.Name = "impuestosEspecialesToolStripMenuItem";
            resources.ApplyResources(this.impuestosEspecialesToolStripMenuItem, "impuestosEspecialesToolStripMenuItem");
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.comprasToolStripMenuItem1,
            this.inventarioToolStripMenuItem1,
            this.ordenDeTrabajoToolStripMenuItem,
            this.atenciónClientesToolStripMenuItem,
            this.electronicaToolStripMenuItem,
            this.restaurantToolStripMenuItem,
            this.opcionesToolStripMenuItem1,
            this.extrasToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.cuentaCorrienteToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.facturaExentaToolStripMenuItem,
            this.boletasToolStripMenuItem1,
            this.boletaFiscalToolStripMenuItem,
            this.devolucionDeProductosConBoletasToolStripMenuItem,
            this.guiasToolStripMenuItem,
            this.notasDeCreditoToolStripMenuItem,
            this.cotizacionToolStripMenuItem,
            this.ticketToolStripMenuItem,
            this.notaDeVentaToolStripMenuItem,
            this.toolStripSeparator5,
            this.controlDeCajaToolStripMenuItem,
            this.moduloFiscalToolStripMenuItem,
            this.toolStripSeparator2,
            this.informesGToolStripMenuItem,
            this.pagosDeVentasToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            resources.ApplyResources(this.ventaToolStripMenuItem, "ventaToolStripMenuItem");
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            resources.ApplyResources(this.clientesToolStripMenuItem, "clientesToolStripMenuItem");
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cuentaCorrienteToolStripMenuItem
            // 
            this.cuentaCorrienteToolStripMenuItem.Name = "cuentaCorrienteToolStripMenuItem";
            resources.ApplyResources(this.cuentaCorrienteToolStripMenuItem, "cuentaCorrienteToolStripMenuItem");
            this.cuentaCorrienteToolStripMenuItem.Click += new System.EventHandler(this.cuentaCorrienteToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem1,
            this.informesToolStripMenuItem});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            resources.ApplyResources(this.facturaToolStripMenuItem, "facturaToolStripMenuItem");
            // 
            // facturaToolStripMenuItem1
            // 
            this.facturaToolStripMenuItem1.Name = "facturaToolStripMenuItem1";
            resources.ApplyResources(this.facturaToolStripMenuItem1, "facturaToolStripMenuItem1");
            this.facturaToolStripMenuItem1.Click += new System.EventHandler(this.facturaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeFacturasSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem,
            this.detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem,
            this.detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem,
            this.visualizarFacturaToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            resources.ApplyResources(this.informesToolStripMenuItem, "informesToolStripMenuItem");
            // 
            // listadoDeFacturasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasSegúnFechaToolStripMenuItem, "listadoDeFacturasSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem, "listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem, "listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasPendientesDePagoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem, "listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem, "listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasAnuladasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem
            // 
            this.listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem.Name = "listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem, "listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem");
            this.listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasSegúnFechaDeVencimientoToolStripMenuItem_Click);
            // 
            // detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem
            // 
            this.detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem.Name = "detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem, "detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem");
            this.detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem_Click);
            // 
            // detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem
            // 
            this.detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem.Name = "detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem, "detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem");
            this.detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem");
            this.resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConFacturaSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem");
            this.resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConFacturaPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem
            // 
            this.listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem.Name = "listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem, "listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem");
            this.listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosVendidosConFacturaYSuRentabilidadSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarFacturaToolStripMenuItem
            // 
            this.visualizarFacturaToolStripMenuItem.Name = "visualizarFacturaToolStripMenuItem";
            resources.ApplyResources(this.visualizarFacturaToolStripMenuItem, "visualizarFacturaToolStripMenuItem");
            this.visualizarFacturaToolStripMenuItem.Click += new System.EventHandler(this.visualizarFacturaToolStripMenuItem_Click);
            // 
            // facturaExentaToolStripMenuItem
            // 
            this.facturaExentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.informesToolStripMenuItem12});
            this.facturaExentaToolStripMenuItem.Name = "facturaExentaToolStripMenuItem";
            resources.ApplyResources(this.facturaExentaToolStripMenuItem, "facturaExentaToolStripMenuItem");
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            resources.ApplyResources(this.fToolStripMenuItem, "fToolStripMenuItem");
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem12
            // 
            this.informesToolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeFacturasExentasSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem,
            this.detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem,
            this.visualizarFacturaExentaToolStripMenuItem});
            this.informesToolStripMenuItem12.Name = "informesToolStripMenuItem12";
            resources.ApplyResources(this.informesToolStripMenuItem12, "informesToolStripMenuItem12");
            // 
            // listadoDeFacturasExentasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasExentasSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasExentasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasExentasSegúnFechaToolStripMenuItem, "listadoDeFacturasExentasSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasExentasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasExentasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem, "listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasExentasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasExentasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem, "listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasExentasPendientesDePagoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem, "listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasExentasPendientesDePagoPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem
            // 
            this.detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem.Name = "detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem, "detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem");
            this.detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeArticulosVendidosConFacturaExentasSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem");
            this.resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConFacturasExentasSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarFacturaExentaToolStripMenuItem
            // 
            this.visualizarFacturaExentaToolStripMenuItem.Name = "visualizarFacturaExentaToolStripMenuItem";
            resources.ApplyResources(this.visualizarFacturaExentaToolStripMenuItem, "visualizarFacturaExentaToolStripMenuItem");
            this.visualizarFacturaExentaToolStripMenuItem.Click += new System.EventHandler(this.visualizarFacturaExentaToolStripMenuItem_Click);
            // 
            // boletasToolStripMenuItem1
            // 
            this.boletasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletaToolStripMenuItem,
            this.devoluciónDeProductosToolStripMenuItem,
            this.informesToolStripMenuItem1,
            this.toolStripMenuItem26,
            this.ingresosManualesToolStripMenuItem});
            this.boletasToolStripMenuItem1.Name = "boletasToolStripMenuItem1";
            resources.ApplyResources(this.boletasToolStripMenuItem1, "boletasToolStripMenuItem1");
            this.boletasToolStripMenuItem1.Click += new System.EventHandler(this.boletasToolStripMenuItem1_Click);
            // 
            // boletaToolStripMenuItem
            // 
            this.boletaToolStripMenuItem.Name = "boletaToolStripMenuItem";
            resources.ApplyResources(this.boletaToolStripMenuItem, "boletaToolStripMenuItem");
            this.boletaToolStripMenuItem.Click += new System.EventHandler(this.boletaToolStripMenuItem_Click);
            // 
            // devoluciónDeProductosToolStripMenuItem
            // 
            this.devoluciónDeProductosToolStripMenuItem.Name = "devoluciónDeProductosToolStripMenuItem";
            resources.ApplyResources(this.devoluciónDeProductosToolStripMenuItem, "devoluciónDeProductosToolStripMenuItem");
            this.devoluciónDeProductosToolStripMenuItem.Click += new System.EventHandler(this.devoluciónDeProductosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem1
            // 
            this.informesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeBoletasSegúnFechaToolStripMenuItem,
            this.listadoDeBoletasToolStripMenuItem,
            this.listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem,
            this.listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem,
            this.visualizarBoletaToolStripMenuItem});
            this.informesToolStripMenuItem1.Name = "informesToolStripMenuItem1";
            resources.ApplyResources(this.informesToolStripMenuItem1, "informesToolStripMenuItem1");
            this.informesToolStripMenuItem1.Click += new System.EventHandler(this.informesToolStripMenuItem1_Click);
            // 
            // listadoDeBoletasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeBoletasSegúnFechaToolStripMenuItem.Name = "listadoDeBoletasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasSegúnFechaToolStripMenuItem, "listadoDeBoletasSegúnFechaToolStripMenuItem");
            this.listadoDeBoletasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeBoletasToolStripMenuItem
            // 
            this.listadoDeBoletasToolStripMenuItem.Name = "listadoDeBoletasToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasToolStripMenuItem, "listadoDeBoletasToolStripMenuItem");
            this.listadoDeBoletasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasToolStripMenuItem_Click);
            // 
            // listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem.Name = "listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem, "listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem");
            this.listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasAnuladasSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem");
            this.resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConBoletasSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuI" +
    "tem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuI" +
        "tem");
            this.resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem
            // 
            this.listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem.Name = "listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem, "listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem");
            this.listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosVendidosConBoletasYSuRentabilidadSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarBoletaToolStripMenuItem
            // 
            this.visualizarBoletaToolStripMenuItem.Name = "visualizarBoletaToolStripMenuItem";
            resources.ApplyResources(this.visualizarBoletaToolStripMenuItem, "visualizarBoletaToolStripMenuItem");
            this.visualizarBoletaToolStripMenuItem.Click += new System.EventHandler(this.visualizarBoletaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem27,
            this.toolStripMenuItem28,
            this.toolStripMenuItem29,
            this.toolStripMenuItem30,
            this.toolStripMenuItem31,
            this.toolStripMenuItem32,
            this.toolStripMenuItem33,
            this.toolStripMenuItem34});
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            resources.ApplyResources(this.toolStripMenuItem26, "toolStripMenuItem26");
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            resources.ApplyResources(this.toolStripMenuItem27, "toolStripMenuItem27");
            this.toolStripMenuItem27.Click += new System.EventHandler(this.toolStripMenuItem27_Click);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            resources.ApplyResources(this.toolStripMenuItem28, "toolStripMenuItem28");
            this.toolStripMenuItem28.Click += new System.EventHandler(this.toolStripMenuItem28_Click);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            resources.ApplyResources(this.toolStripMenuItem29, "toolStripMenuItem29");
            this.toolStripMenuItem29.Click += new System.EventHandler(this.toolStripMenuItem29_Click);
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            resources.ApplyResources(this.toolStripMenuItem30, "toolStripMenuItem30");
            this.toolStripMenuItem30.Click += new System.EventHandler(this.toolStripMenuItem30_Click);
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            resources.ApplyResources(this.toolStripMenuItem31, "toolStripMenuItem31");
            this.toolStripMenuItem31.Click += new System.EventHandler(this.toolStripMenuItem31_Click);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            resources.ApplyResources(this.toolStripMenuItem32, "toolStripMenuItem32");
            this.toolStripMenuItem32.Click += new System.EventHandler(this.toolStripMenuItem32_Click);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            resources.ApplyResources(this.toolStripMenuItem33, "toolStripMenuItem33");
            this.toolStripMenuItem33.Click += new System.EventHandler(this.toolStripMenuItem33_Click);
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            resources.ApplyResources(this.toolStripMenuItem34, "toolStripMenuItem34");
            this.toolStripMenuItem34.Click += new System.EventHandler(this.toolStripMenuItem34_Click);
            // 
            // ingresosManualesToolStripMenuItem
            // 
            this.ingresosManualesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoBoletasManualesToolStripMenuItem,
            this.informesToolStripMenuItem28});
            this.ingresosManualesToolStripMenuItem.Name = "ingresosManualesToolStripMenuItem";
            resources.ApplyResources(this.ingresosManualesToolStripMenuItem, "ingresosManualesToolStripMenuItem");
            this.ingresosManualesToolStripMenuItem.Click += new System.EventHandler(this.ingresosManualesToolStripMenuItem_Click);
            // 
            // ingresoBoletasManualesToolStripMenuItem
            // 
            this.ingresoBoletasManualesToolStripMenuItem.Name = "ingresoBoletasManualesToolStripMenuItem";
            resources.ApplyResources(this.ingresoBoletasManualesToolStripMenuItem, "ingresoBoletasManualesToolStripMenuItem");
            this.ingresoBoletasManualesToolStripMenuItem.Click += new System.EventHandler(this.ingresoBoletasManualesToolStripMenuItem_Click_1);
            // 
            // informesToolStripMenuItem28
            // 
            this.informesToolStripMenuItem28.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeBoletasIngresadasToolStripMenuItem});
            this.informesToolStripMenuItem28.Name = "informesToolStripMenuItem28";
            resources.ApplyResources(this.informesToolStripMenuItem28, "informesToolStripMenuItem28");
            this.informesToolStripMenuItem28.Click += new System.EventHandler(this.informesToolStripMenuItem28_Click);
            // 
            // listadoDeBoletasIngresadasToolStripMenuItem
            // 
            this.listadoDeBoletasIngresadasToolStripMenuItem.Name = "listadoDeBoletasIngresadasToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasIngresadasToolStripMenuItem, "listadoDeBoletasIngresadasToolStripMenuItem");
            this.listadoDeBoletasIngresadasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasIngresadasToolStripMenuItem_Click);
            // 
            // boletaFiscalToolStripMenuItem
            // 
            this.boletaFiscalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletaFiscalToolStripMenuItem1,
            this.informesToolStripMenuItem13});
            this.boletaFiscalToolStripMenuItem.Name = "boletaFiscalToolStripMenuItem";
            resources.ApplyResources(this.boletaFiscalToolStripMenuItem, "boletaFiscalToolStripMenuItem");
            // 
            // boletaFiscalToolStripMenuItem1
            // 
            this.boletaFiscalToolStripMenuItem1.Name = "boletaFiscalToolStripMenuItem1";
            resources.ApplyResources(this.boletaFiscalToolStripMenuItem1, "boletaFiscalToolStripMenuItem1");
            this.boletaFiscalToolStripMenuItem1.Click += new System.EventHandler(this.boletaFiscalToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem13
            // 
            this.informesToolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem,
            this.listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem,
            this.listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem,
            this.visualizarBoletaFiscalToolStripMenuItem});
            this.informesToolStripMenuItem13.Name = "informesToolStripMenuItem13";
            resources.ApplyResources(this.informesToolStripMenuItem13, "informesToolStripMenuItem13");
            // 
            // listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem
            // 
            this.listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem.Name = "listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem, "listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem");
            this.listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasFiscalesSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem, "listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasFiscalesPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem, "listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeBoletasFiscalesPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem");
            this.resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConBoletasFiscalesSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolSt" +
    "ripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolSt" +
        "ripMenuItem");
            this.resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConBoletasFiscalesAgrupadosPorCategoriaSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem
            // 
            this.listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem.Name = "listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMen" +
    "uItem";
            resources.ApplyResources(this.listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem, "listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMen" +
        "uItem");
            this.listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosVendidosConBoletasFiscalesYSuRentabilidadSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarBoletaFiscalToolStripMenuItem
            // 
            this.visualizarBoletaFiscalToolStripMenuItem.Name = "visualizarBoletaFiscalToolStripMenuItem";
            resources.ApplyResources(this.visualizarBoletaFiscalToolStripMenuItem, "visualizarBoletaFiscalToolStripMenuItem");
            this.visualizarBoletaFiscalToolStripMenuItem.Click += new System.EventHandler(this.visualizarBoletaFiscalToolStripMenuItem_Click);
            // 
            // devolucionDeProductosConBoletasToolStripMenuItem
            // 
            this.devolucionDeProductosConBoletasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devolucionDeProductosToolStripMenuItem,
            this.informesToolStripMenuItem18});
            this.devolucionDeProductosConBoletasToolStripMenuItem.Name = "devolucionDeProductosConBoletasToolStripMenuItem";
            resources.ApplyResources(this.devolucionDeProductosConBoletasToolStripMenuItem, "devolucionDeProductosConBoletasToolStripMenuItem");
            this.devolucionDeProductosConBoletasToolStripMenuItem.Click += new System.EventHandler(this.devolucionDeProductosConBoletasToolStripMenuItem_Click);
            // 
            // devolucionDeProductosToolStripMenuItem
            // 
            this.devolucionDeProductosToolStripMenuItem.Name = "devolucionDeProductosToolStripMenuItem";
            resources.ApplyResources(this.devolucionDeProductosToolStripMenuItem, "devolucionDeProductosToolStripMenuItem");
            this.devolucionDeProductosToolStripMenuItem.Click += new System.EventHandler(this.devolucionDeProductosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem18
            // 
            this.informesToolStripMenuItem18.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeDevolucionesSegúnFechaToolStripMenuItem});
            this.informesToolStripMenuItem18.Name = "informesToolStripMenuItem18";
            resources.ApplyResources(this.informesToolStripMenuItem18, "informesToolStripMenuItem18");
            // 
            // listadoDeDevolucionesSegúnFechaToolStripMenuItem
            // 
            this.listadoDeDevolucionesSegúnFechaToolStripMenuItem.Name = "listadoDeDevolucionesSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeDevolucionesSegúnFechaToolStripMenuItem, "listadoDeDevolucionesSegúnFechaToolStripMenuItem");
            this.listadoDeDevolucionesSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeDevolucionesSegúnFechaToolStripMenuItem_Click);
            // 
            // guiasToolStripMenuItem
            // 
            this.guiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiaDeDespachoToolStripMenuItem,
            this.informesToolStripMenuItem4});
            this.guiasToolStripMenuItem.Name = "guiasToolStripMenuItem";
            resources.ApplyResources(this.guiasToolStripMenuItem, "guiasToolStripMenuItem");
            this.guiasToolStripMenuItem.Click += new System.EventHandler(this.guiasToolStripMenuItem_Click);
            // 
            // guiaDeDespachoToolStripMenuItem
            // 
            this.guiaDeDespachoToolStripMenuItem.Name = "guiaDeDespachoToolStripMenuItem";
            resources.ApplyResources(this.guiaDeDespachoToolStripMenuItem, "guiaDeDespachoToolStripMenuItem");
            this.guiaDeDespachoToolStripMenuItem.Click += new System.EventHandler(this.guiaDeDespachoToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem4
            // 
            this.informesToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeGuiasSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem,
            this.detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem,
            this.visualizarGuiaToolStripMenuItem});
            this.informesToolStripMenuItem4.Name = "informesToolStripMenuItem4";
            resources.ApplyResources(this.informesToolStripMenuItem4, "informesToolStripMenuItem4");
            this.informesToolStripMenuItem4.Click += new System.EventHandler(this.informesToolStripMenuItem4_Click);
            // 
            // listadoDeGuiasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasSegúnFechaToolStripMenuItem, "listadoDeGuiasSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem, "listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem, "listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasAnuladasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem, "listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasNoFacturadasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem, "listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasNoFacturadasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem
            // 
            this.detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem.Name = "detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem, "detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem");
            this.detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeArticulosVendidosConGuiasSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarGuiaToolStripMenuItem
            // 
            this.visualizarGuiaToolStripMenuItem.Name = "visualizarGuiaToolStripMenuItem";
            resources.ApplyResources(this.visualizarGuiaToolStripMenuItem, "visualizarGuiaToolStripMenuItem");
            this.visualizarGuiaToolStripMenuItem.Click += new System.EventHandler(this.visualizarGuiaToolStripMenuItem_Click);
            // 
            // notasDeCreditoToolStripMenuItem
            // 
            this.notasDeCreditoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaDeCreditoToolStripMenuItem,
            this.informesToolStripMenuItem6});
            this.notasDeCreditoToolStripMenuItem.Name = "notasDeCreditoToolStripMenuItem";
            resources.ApplyResources(this.notasDeCreditoToolStripMenuItem, "notasDeCreditoToolStripMenuItem");
            this.notasDeCreditoToolStripMenuItem.Click += new System.EventHandler(this.notasDeCreditoToolStripMenuItem_Click);
            // 
            // notaDeCreditoToolStripMenuItem
            // 
            this.notaDeCreditoToolStripMenuItem.Name = "notaDeCreditoToolStripMenuItem";
            resources.ApplyResources(this.notaDeCreditoToolStripMenuItem, "notaDeCreditoToolStripMenuItem");
            this.notaDeCreditoToolStripMenuItem.Click += new System.EventHandler(this.notaDeCreditoToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem6
            // 
            this.informesToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1,
            this.listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.visualizarNotaDeCreditoToolStripMenuItem});
            this.informesToolStripMenuItem6.Name = "informesToolStripMenuItem6";
            resources.ApplyResources(this.informesToolStripMenuItem6, "informesToolStripMenuItem6");
            // 
            // listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem, "listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem, "listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeCreditoPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1
            // 
            this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1.Name = "listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1";
            resources.ApplyResources(this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1, "listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1");
            this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeNotasDeCreditoSegúnFechaToolStripMenuItem1_Click);
            // 
            // listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeCreditoPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarNotaDeCreditoToolStripMenuItem
            // 
            this.visualizarNotaDeCreditoToolStripMenuItem.Name = "visualizarNotaDeCreditoToolStripMenuItem";
            resources.ApplyResources(this.visualizarNotaDeCreditoToolStripMenuItem, "visualizarNotaDeCreditoToolStripMenuItem");
            this.visualizarNotaDeCreditoToolStripMenuItem.Click += new System.EventHandler(this.visualizarNotaDeCreditoToolStripMenuItem_Click);
            // 
            // cotizacionToolStripMenuItem
            // 
            this.cotizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionToolStripMenuItem1,
            this.informesToolStripMenuItem3});
            this.cotizacionToolStripMenuItem.Name = "cotizacionToolStripMenuItem";
            resources.ApplyResources(this.cotizacionToolStripMenuItem, "cotizacionToolStripMenuItem");
            this.cotizacionToolStripMenuItem.Click += new System.EventHandler(this.cotizacionToolStripMenuItem_Click);
            // 
            // cotizacionToolStripMenuItem1
            // 
            this.cotizacionToolStripMenuItem1.Name = "cotizacionToolStripMenuItem1";
            resources.ApplyResources(this.cotizacionToolStripMenuItem1, "cotizacionToolStripMenuItem1");
            this.cotizacionToolStripMenuItem1.Click += new System.EventHandler(this.cotizacionToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem3
            // 
            this.informesToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeCotizacionesSegúnFechaToolStripMenuItem,
            this.listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem,
            this.detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem,
            this.visualizarCotizacionToolStripMenuItem,
            this.detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem});
            this.informesToolStripMenuItem3.Name = "informesToolStripMenuItem3";
            resources.ApplyResources(this.informesToolStripMenuItem3, "informesToolStripMenuItem3");
            // 
            // listadoDeCotizacionesSegúnFechaToolStripMenuItem
            // 
            this.listadoDeCotizacionesSegúnFechaToolStripMenuItem.Name = "listadoDeCotizacionesSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeCotizacionesSegúnFechaToolStripMenuItem, "listadoDeCotizacionesSegúnFechaToolStripMenuItem");
            this.listadoDeCotizacionesSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCotizacionesSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem, "listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCotizacionesPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem, "listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCotizacionesPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem
            // 
            this.detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem.Name = "detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem, "detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem");
            this.detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeArticulosCotizadosSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarCotizacionToolStripMenuItem
            // 
            this.visualizarCotizacionToolStripMenuItem.Name = "visualizarCotizacionToolStripMenuItem";
            resources.ApplyResources(this.visualizarCotizacionToolStripMenuItem, "visualizarCotizacionToolStripMenuItem");
            this.visualizarCotizacionToolStripMenuItem.Click += new System.EventHandler(this.visualizarCotizacionToolStripMenuItem_Click);
            // 
            // detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem
            // 
            this.detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem.Name = "detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem";
            resources.ApplyResources(this.detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem, "detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem");
            this.detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem.Click += new System.EventHandler(this.detalleDeCotizacionesPendientesDeFacturarToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem1,
            this.informesToolStripMenuItem2});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            resources.ApplyResources(this.ticketToolStripMenuItem, "ticketToolStripMenuItem");
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem1
            // 
            this.ticketToolStripMenuItem1.Name = "ticketToolStripMenuItem1";
            resources.ApplyResources(this.ticketToolStripMenuItem1, "ticketToolStripMenuItem1");
            this.ticketToolStripMenuItem1.Click += new System.EventHandler(this.ticketToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem2
            // 
            this.informesToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTicketsSegúnFechaToolStripMenuItem,
            this.listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeTicketAnuladosToolStripMenuItem,
            this.visualizarTicketToolStripMenuItem});
            this.informesToolStripMenuItem2.Name = "informesToolStripMenuItem2";
            resources.ApplyResources(this.informesToolStripMenuItem2, "informesToolStripMenuItem2");
            // 
            // listadoDeTicketsSegúnFechaToolStripMenuItem
            // 
            this.listadoDeTicketsSegúnFechaToolStripMenuItem.Name = "listadoDeTicketsSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeTicketsSegúnFechaToolStripMenuItem, "listadoDeTicketsSegúnFechaToolStripMenuItem");
            this.listadoDeTicketsSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTicketsSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem, "listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTicketsPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem, "listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTicketsPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeTicketAnuladosToolStripMenuItem
            // 
            this.listadoDeTicketAnuladosToolStripMenuItem.Name = "listadoDeTicketAnuladosToolStripMenuItem";
            resources.ApplyResources(this.listadoDeTicketAnuladosToolStripMenuItem, "listadoDeTicketAnuladosToolStripMenuItem");
            this.listadoDeTicketAnuladosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTicketAnuladosToolStripMenuItem_Click);
            // 
            // visualizarTicketToolStripMenuItem
            // 
            this.visualizarTicketToolStripMenuItem.Name = "visualizarTicketToolStripMenuItem";
            resources.ApplyResources(this.visualizarTicketToolStripMenuItem, "visualizarTicketToolStripMenuItem");
            this.visualizarTicketToolStripMenuItem.Click += new System.EventHandler(this.visualizarTicketToolStripMenuItem_Click);
            // 
            // notaDeVentaToolStripMenuItem
            // 
            this.notaDeVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaDeVenToolStripMenuItem,
            this.informesToolStripMenuItem5});
            this.notaDeVentaToolStripMenuItem.Name = "notaDeVentaToolStripMenuItem";
            resources.ApplyResources(this.notaDeVentaToolStripMenuItem, "notaDeVentaToolStripMenuItem");
            this.notaDeVentaToolStripMenuItem.Click += new System.EventHandler(this.notaDeVentaToolStripMenuItem_Click);
            // 
            // notaDeVenToolStripMenuItem
            // 
            this.notaDeVenToolStripMenuItem.Name = "notaDeVenToolStripMenuItem";
            resources.ApplyResources(this.notaDeVenToolStripMenuItem, "notaDeVenToolStripMenuItem");
            this.notaDeVenToolStripMenuItem.Click += new System.EventHandler(this.notaDeVenToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem5
            // 
            this.informesToolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeNotasDeVentasSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem,
            this.visualizarNotaDeVentaToolStripMenuItem});
            this.informesToolStripMenuItem5.Name = "informesToolStripMenuItem5";
            resources.ApplyResources(this.informesToolStripMenuItem5, "informesToolStripMenuItem5");
            // 
            // listadoDeNotasDeVentasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeVentasSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeVentasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeVentasSegúnFechaToolStripMenuItem, "listadoDeNotasDeVentasSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeVentasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeVentasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem, "listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeVentasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeVentasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeVentasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem, "listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeVentasAnuladasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem, "listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeVentasNOFacturadasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem, "listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeVentasNOFacturadasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem
            // 
            this.listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem.Name = "listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem, "listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem");
            this.listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem");
            this.resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConNotaDeVentaSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem");
            this.resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConNotaDeVentaPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarNotaDeVentaToolStripMenuItem
            // 
            this.visualizarNotaDeVentaToolStripMenuItem.Name = "visualizarNotaDeVentaToolStripMenuItem";
            resources.ApplyResources(this.visualizarNotaDeVentaToolStripMenuItem, "visualizarNotaDeVentaToolStripMenuItem");
            this.visualizarNotaDeVentaToolStripMenuItem.Click += new System.EventHandler(this.visualizarNotaDeVentaToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // controlDeCajaToolStripMenuItem
            // 
            this.controlDeCajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeCajaToolStripMenuItem1,
            this.informesToolStripMenuItem10});
            this.controlDeCajaToolStripMenuItem.Name = "controlDeCajaToolStripMenuItem";
            resources.ApplyResources(this.controlDeCajaToolStripMenuItem, "controlDeCajaToolStripMenuItem");
            this.controlDeCajaToolStripMenuItem.Click += new System.EventHandler(this.controlDeCajaToolStripMenuItem_Click);
            // 
            // controlDeCajaToolStripMenuItem1
            // 
            this.controlDeCajaToolStripMenuItem1.Name = "controlDeCajaToolStripMenuItem1";
            resources.ApplyResources(this.controlDeCajaToolStripMenuItem1, "controlDeCajaToolStripMenuItem1");
            this.controlDeCajaToolStripMenuItem1.Click += new System.EventHandler(this.controlDeCajaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem10
            // 
            this.informesToolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeControlToolStripMenuItem});
            this.informesToolStripMenuItem10.Name = "informesToolStripMenuItem10";
            resources.ApplyResources(this.informesToolStripMenuItem10, "informesToolStripMenuItem10");
            // 
            // listadoDeControlToolStripMenuItem
            // 
            this.listadoDeControlToolStripMenuItem.Name = "listadoDeControlToolStripMenuItem";
            resources.ApplyResources(this.listadoDeControlToolStripMenuItem, "listadoDeControlToolStripMenuItem");
            this.listadoDeControlToolStripMenuItem.Click += new System.EventHandler(this.listadoDeControlToolStripMenuItem_Click);
            // 
            // moduloFiscalToolStripMenuItem
            // 
            this.moduloFiscalToolStripMenuItem.Name = "moduloFiscalToolStripMenuItem";
            resources.ApplyResources(this.moduloFiscalToolStripMenuItem, "moduloFiscalToolStripMenuItem");
            this.moduloFiscalToolStripMenuItem.Click += new System.EventHandler(this.moduloFiscalToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // informesGToolStripMenuItem
            // 
            this.informesGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreDeDiaToolStripMenuItem,
            this.libroDeVentasToolStripMenuItem,
            this.libroDeVentasConBoletasToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem,
            this.listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem,
            this.resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem,
            this.resumenDeVentasSegúnFechaToolStripMenuItem,
            this.detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem,
            this.libroDeVentasConBoletaFiscalToolStripMenuItem,
            this.listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem});
            this.informesGToolStripMenuItem.Name = "informesGToolStripMenuItem";
            resources.ApplyResources(this.informesGToolStripMenuItem, "informesGToolStripMenuItem");
            // 
            // cierreDeDiaToolStripMenuItem
            // 
            this.cierreDeDiaToolStripMenuItem.Name = "cierreDeDiaToolStripMenuItem";
            resources.ApplyResources(this.cierreDeDiaToolStripMenuItem, "cierreDeDiaToolStripMenuItem");
            this.cierreDeDiaToolStripMenuItem.Click += new System.EventHandler(this.cierreDeDiaToolStripMenuItem_Click);
            // 
            // libroDeVentasToolStripMenuItem
            // 
            this.libroDeVentasToolStripMenuItem.Name = "libroDeVentasToolStripMenuItem";
            resources.ApplyResources(this.libroDeVentasToolStripMenuItem, "libroDeVentasToolStripMenuItem");
            this.libroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.libroDeVentasToolStripMenuItem_Click);
            // 
            // libroDeVentasConBoletasToolStripMenuItem
            // 
            this.libroDeVentasConBoletasToolStripMenuItem.Name = "libroDeVentasConBoletasToolStripMenuItem";
            resources.ApplyResources(this.libroDeVentasConBoletasToolStripMenuItem, "libroDeVentasConBoletasToolStripMenuItem");
            this.libroDeVentasConBoletasToolStripMenuItem.Click += new System.EventHandler(this.libroDeVentasConBoletasToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            resources.ApplyResources(this.listadoDeClientesToolStripMenuItem, "listadoDeClientesToolStripMenuItem");
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem.Name = "listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem, "listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem");
            this.listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosVendidosConFacturaYBoletasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem
            // 
            this.listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem.Name = "listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuIt" +
    "em";
            resources.ApplyResources(this.listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem, "listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuIt" +
        "em");
            this.listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosVendidosConFacturaYBoletasRentabilidadSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem
            // 
            this.resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem.Name = "resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolS" +
    "tripMenuItem";
            resources.ApplyResources(this.resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem, "resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolS" +
        "tripMenuItem");
            this.resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeArticulosVendidosConFacturasYBoletasAgrupadosPorCategoriaSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasYBoletasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem, "listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeDocumentosDeVentaPendientesDePagoPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // resumenDeVentasSegúnFechaToolStripMenuItem
            // 
            this.resumenDeVentasSegúnFechaToolStripMenuItem.Name = "resumenDeVentasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.resumenDeVentasSegúnFechaToolStripMenuItem, "resumenDeVentasSegúnFechaToolStripMenuItem");
            this.resumenDeVentasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.resumenDeVentasSegúnFechaToolStripMenuItem_Click);
            // 
            // detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem.Name = "detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem, "detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem");
            this.detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeComisionesPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // libroDeVentasConBoletaFiscalToolStripMenuItem
            // 
            this.libroDeVentasConBoletaFiscalToolStripMenuItem.Name = "libroDeVentasConBoletaFiscalToolStripMenuItem";
            resources.ApplyResources(this.libroDeVentasConBoletaFiscalToolStripMenuItem, "libroDeVentasConBoletaFiscalToolStripMenuItem");
            this.libroDeVentasConBoletaFiscalToolStripMenuItem.Click += new System.EventHandler(this.libroDeVentasConBoletaFiscalToolStripMenuItem_Click);
            // 
            // listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem
            // 
            this.listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem.Name = "listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem, "listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem");
            this.listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadosDeArticulosVendidosPorRubroSegúnFechaToolStripMenuItem_Click);
            // 
            // pagosDeVentasToolStripMenuItem
            // 
            this.pagosDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentosPorCobrarSegúnFechaToolStripMenuItem1,
            this.detalleDePagosDeVentasSegúnFechaToolStripMenuItem1,
            this.detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem,
            this.detalleDeClientesMorososToolStripMenuItem});
            this.pagosDeVentasToolStripMenuItem.Name = "pagosDeVentasToolStripMenuItem";
            resources.ApplyResources(this.pagosDeVentasToolStripMenuItem, "pagosDeVentasToolStripMenuItem");
            // 
            // documentosPorCobrarSegúnFechaToolStripMenuItem1
            // 
            this.documentosPorCobrarSegúnFechaToolStripMenuItem1.Name = "documentosPorCobrarSegúnFechaToolStripMenuItem1";
            resources.ApplyResources(this.documentosPorCobrarSegúnFechaToolStripMenuItem1, "documentosPorCobrarSegúnFechaToolStripMenuItem1");
            this.documentosPorCobrarSegúnFechaToolStripMenuItem1.Click += new System.EventHandler(this.documentosPorCobrarSegúnFechaToolStripMenuItem1_Click);
            // 
            // detalleDePagosDeVentasSegúnFechaToolStripMenuItem1
            // 
            this.detalleDePagosDeVentasSegúnFechaToolStripMenuItem1.Name = "detalleDePagosDeVentasSegúnFechaToolStripMenuItem1";
            resources.ApplyResources(this.detalleDePagosDeVentasSegúnFechaToolStripMenuItem1, "detalleDePagosDeVentasSegúnFechaToolStripMenuItem1");
            this.detalleDePagosDeVentasSegúnFechaToolStripMenuItem1.Click += new System.EventHandler(this.detalleDePagosDeVentasSegúnFechaToolStripMenuItem1_Click);
            // 
            // detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem.Name = "detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem, "detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem");
            this.detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDePagosDeVentasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem.Name = "listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem, "listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem");
            this.listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeVentasPorEstadoDelDocumentoSegúnFechaToolStripMenuItem_Click);
            // 
            // detalleDeClientesMorososToolStripMenuItem
            // 
            this.detalleDeClientesMorososToolStripMenuItem.Name = "detalleDeClientesMorososToolStripMenuItem";
            resources.ApplyResources(this.detalleDeClientesMorososToolStripMenuItem, "detalleDeClientesMorososToolStripMenuItem");
            this.detalleDeClientesMorososToolStripMenuItem.Click += new System.EventHandler(this.detalleDeClientesMorososToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.ingresoDeComprasToolStripMenuItem,
            this.ordenDeComprasToolStripMenuItem,
            this.ingresoDeServiciosToolStripMenuItem,
            this.toolStripSeparator3,
            this.informesDePagosDeComprasToolStripMenuItem});
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            resources.ApplyResources(this.comprasToolStripMenuItem1, "comprasToolStripMenuItem1");
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            resources.ApplyResources(this.proveedoresToolStripMenuItem, "proveedoresToolStripMenuItem");
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // ingresoDeComprasToolStripMenuItem
            // 
            this.ingresoDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeComprasToolStripMenuItem1,
            this.informesToolStripMenuItem8});
            this.ingresoDeComprasToolStripMenuItem.Name = "ingresoDeComprasToolStripMenuItem";
            resources.ApplyResources(this.ingresoDeComprasToolStripMenuItem, "ingresoDeComprasToolStripMenuItem");
            this.ingresoDeComprasToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeComprasToolStripMenuItem_Click);
            // 
            // ingresoDeComprasToolStripMenuItem1
            // 
            this.ingresoDeComprasToolStripMenuItem1.Name = "ingresoDeComprasToolStripMenuItem1";
            resources.ApplyResources(this.ingresoDeComprasToolStripMenuItem1, "ingresoDeComprasToolStripMenuItem1");
            this.ingresoDeComprasToolStripMenuItem1.Click += new System.EventHandler(this.ingresoDeComprasToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem8
            // 
            this.informesToolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeComprasSegúnFechaToolStripMenuItem,
            this.listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem,
            this.listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem,
            this.listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem,
            this.visualizarDocumentoDeCompraToolStripMenuItem,
            this.libroDeComprasToolStripMenuItem,
            this.listadoDeProveedoresToolStripMenuItem,
            this.libroDeComprasSegúnPeriodoContableToolStripMenuItem});
            this.informesToolStripMenuItem8.Name = "informesToolStripMenuItem8";
            resources.ApplyResources(this.informesToolStripMenuItem8, "informesToolStripMenuItem8");
            this.informesToolStripMenuItem8.Click += new System.EventHandler(this.informesToolStripMenuItem8_Click);
            // 
            // listadoDeComprasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeComprasSegúnFechaToolStripMenuItem.Name = "listadoDeComprasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeComprasSegúnFechaToolStripMenuItem, "listadoDeComprasSegúnFechaToolStripMenuItem");
            this.listadoDeComprasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeComprasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem.Name = "listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem, "listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem");
            this.listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeComprasPorProveedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeComprasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem.Name = "listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem, "listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem");
            this.listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeComprasPendientesDePagoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem.Name = "listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem, "listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem");
            this.listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeComprasPendientesDePagoPorProveedorSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarDocumentoDeCompraToolStripMenuItem
            // 
            this.visualizarDocumentoDeCompraToolStripMenuItem.Name = "visualizarDocumentoDeCompraToolStripMenuItem";
            resources.ApplyResources(this.visualizarDocumentoDeCompraToolStripMenuItem, "visualizarDocumentoDeCompraToolStripMenuItem");
            this.visualizarDocumentoDeCompraToolStripMenuItem.Click += new System.EventHandler(this.visualizarDocumentoDeCompraToolStripMenuItem_Click);
            // 
            // libroDeComprasToolStripMenuItem
            // 
            this.libroDeComprasToolStripMenuItem.Name = "libroDeComprasToolStripMenuItem";
            resources.ApplyResources(this.libroDeComprasToolStripMenuItem, "libroDeComprasToolStripMenuItem");
            this.libroDeComprasToolStripMenuItem.Click += new System.EventHandler(this.libroDeComprasToolStripMenuItem_Click);
            // 
            // listadoDeProveedoresToolStripMenuItem
            // 
            this.listadoDeProveedoresToolStripMenuItem.Name = "listadoDeProveedoresToolStripMenuItem";
            resources.ApplyResources(this.listadoDeProveedoresToolStripMenuItem, "listadoDeProveedoresToolStripMenuItem");
            this.listadoDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProveedoresToolStripMenuItem_Click);
            // 
            // libroDeComprasSegúnPeriodoContableToolStripMenuItem
            // 
            this.libroDeComprasSegúnPeriodoContableToolStripMenuItem.Name = "libroDeComprasSegúnPeriodoContableToolStripMenuItem";
            resources.ApplyResources(this.libroDeComprasSegúnPeriodoContableToolStripMenuItem, "libroDeComprasSegúnPeriodoContableToolStripMenuItem");
            this.libroDeComprasSegúnPeriodoContableToolStripMenuItem.Click += new System.EventHandler(this.libroDeComprasSegúnPeriodoContableToolStripMenuItem_Click);
            // 
            // ordenDeComprasToolStripMenuItem
            // 
            this.ordenDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeCompraToolStripMenuItem,
            this.informesToolStripMenuItem9});
            this.ordenDeComprasToolStripMenuItem.Name = "ordenDeComprasToolStripMenuItem";
            resources.ApplyResources(this.ordenDeComprasToolStripMenuItem, "ordenDeComprasToolStripMenuItem");
            this.ordenDeComprasToolStripMenuItem.Click += new System.EventHandler(this.ordenDeComprasToolStripMenuItem_Click);
            // 
            // ordenDeCompraToolStripMenuItem
            // 
            this.ordenDeCompraToolStripMenuItem.Name = "ordenDeCompraToolStripMenuItem";
            resources.ApplyResources(this.ordenDeCompraToolStripMenuItem, "ordenDeCompraToolStripMenuItem");
            this.ordenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ordenDeCompraToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem9
            // 
            this.informesToolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoOrdenesDeCompraSegúnFechaToolStripMenuItem,
            this.listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem,
            this.listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem,
            this.visualizarOrdenDeCompraToolStripMenuItem});
            this.informesToolStripMenuItem9.Name = "informesToolStripMenuItem9";
            resources.ApplyResources(this.informesToolStripMenuItem9, "informesToolStripMenuItem9");
            // 
            // listadoOrdenesDeCompraSegúnFechaToolStripMenuItem
            // 
            this.listadoOrdenesDeCompraSegúnFechaToolStripMenuItem.Name = "listadoOrdenesDeCompraSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoOrdenesDeCompraSegúnFechaToolStripMenuItem, "listadoOrdenesDeCompraSegúnFechaToolStripMenuItem");
            this.listadoOrdenesDeCompraSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoOrdenesDeCompraSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem
            // 
            this.listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem.Name = "listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem, "listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem");
            this.listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoOrdenesDeCompraPorProveedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem
            // 
            this.listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem.Name = "listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem, "listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem");
            this.listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoOrdenesDeCompraPSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarOrdenDeCompraToolStripMenuItem
            // 
            this.visualizarOrdenDeCompraToolStripMenuItem.Name = "visualizarOrdenDeCompraToolStripMenuItem";
            resources.ApplyResources(this.visualizarOrdenDeCompraToolStripMenuItem, "visualizarOrdenDeCompraToolStripMenuItem");
            this.visualizarOrdenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.visualizarOrdenDeCompraToolStripMenuItem_Click);
            // 
            // ingresoDeServiciosToolStripMenuItem
            // 
            this.ingresoDeServiciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeGastosDeServiciosToolStripMenuItem,
            this.informesToolStripMenuItem14});
            this.ingresoDeServiciosToolStripMenuItem.Name = "ingresoDeServiciosToolStripMenuItem";
            resources.ApplyResources(this.ingresoDeServiciosToolStripMenuItem, "ingresoDeServiciosToolStripMenuItem");
            this.ingresoDeServiciosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeServiciosToolStripMenuItem_Click);
            // 
            // ingresoDeGastosDeServiciosToolStripMenuItem
            // 
            this.ingresoDeGastosDeServiciosToolStripMenuItem.Name = "ingresoDeGastosDeServiciosToolStripMenuItem";
            resources.ApplyResources(this.ingresoDeGastosDeServiciosToolStripMenuItem, "ingresoDeGastosDeServiciosToolStripMenuItem");
            this.ingresoDeGastosDeServiciosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeGastosDeServiciosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem14
            // 
            this.informesToolStripMenuItem14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeGastosSegúnFechaToolStripMenuItem});
            this.informesToolStripMenuItem14.Name = "informesToolStripMenuItem14";
            resources.ApplyResources(this.informesToolStripMenuItem14, "informesToolStripMenuItem14");
            // 
            // listadoDeGastosSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGastosSegúnFechaToolStripMenuItem.Name = "listadoDeGastosSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGastosSegúnFechaToolStripMenuItem, "listadoDeGastosSegúnFechaToolStripMenuItem");
            this.listadoDeGastosSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGastosSegúnFechaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // informesDePagosDeComprasToolStripMenuItem
            // 
            this.informesDePagosDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentosSegunFechaToolStripMenuItem,
            this.detalleDePagosDeComprasSegúnFechaToolStripMenuItem,
            this.detalleDePagosPorProveedorSegúnFechaToolStripMenuItem});
            this.informesDePagosDeComprasToolStripMenuItem.Name = "informesDePagosDeComprasToolStripMenuItem";
            resources.ApplyResources(this.informesDePagosDeComprasToolStripMenuItem, "informesDePagosDeComprasToolStripMenuItem");
            // 
            // documentosSegunFechaToolStripMenuItem
            // 
            this.documentosSegunFechaToolStripMenuItem.Name = "documentosSegunFechaToolStripMenuItem";
            resources.ApplyResources(this.documentosSegunFechaToolStripMenuItem, "documentosSegunFechaToolStripMenuItem");
            this.documentosSegunFechaToolStripMenuItem.Click += new System.EventHandler(this.documentosSegunFechaToolStripMenuItem_Click);
            // 
            // detalleDePagosDeComprasSegúnFechaToolStripMenuItem
            // 
            this.detalleDePagosDeComprasSegúnFechaToolStripMenuItem.Name = "detalleDePagosDeComprasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDePagosDeComprasSegúnFechaToolStripMenuItem, "detalleDePagosDeComprasSegúnFechaToolStripMenuItem");
            this.detalleDePagosDeComprasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDePagosDeComprasSegúnFechaToolStripMenuItem_Click);
            // 
            // detalleDePagosPorProveedorSegúnFechaToolStripMenuItem
            // 
            this.detalleDePagosPorProveedorSegúnFechaToolStripMenuItem.Name = "detalleDePagosPorProveedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDePagosPorProveedorSegúnFechaToolStripMenuItem, "detalleDePagosPorProveedorSegúnFechaToolStripMenuItem");
            this.detalleDePagosPorProveedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDePagosPorProveedorSegúnFechaToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.unidadDeMedidaToolStripMenuItem,
            this.kitToolStripMenuItem,
            this.traspasoInternoEntreBodegasToolStripMenuItem,
            this.mantenedorDeProductosToolStripMenuItem,
            this.mantenedorDePromocionesToolStripMenuItem,
            this.tomaDeInventarioToolStripMenuItem,
            this.toolStripSeparator4,
            this.informesToolStripMenuItem7});
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            resources.ApplyResources(this.inventarioToolStripMenuItem1, "inventarioToolStripMenuItem1");
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            resources.ApplyResources(this.productosToolStripMenuItem, "productosToolStripMenuItem");
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            resources.ApplyResources(this.categoriasToolStripMenuItem, "categoriasToolStripMenuItem");
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem
            // 
            this.unidadDeMedidaToolStripMenuItem.Name = "unidadDeMedidaToolStripMenuItem";
            resources.ApplyResources(this.unidadDeMedidaToolStripMenuItem, "unidadDeMedidaToolStripMenuItem");
            this.unidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem_Click);
            // 
            // kitToolStripMenuItem
            // 
            this.kitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearKitToolStripMenuItem,
            this.armarKitToolStripMenuItem,
            this.informesToolStripMenuItem11});
            this.kitToolStripMenuItem.Name = "kitToolStripMenuItem";
            resources.ApplyResources(this.kitToolStripMenuItem, "kitToolStripMenuItem");
            // 
            // crearKitToolStripMenuItem
            // 
            this.crearKitToolStripMenuItem.Name = "crearKitToolStripMenuItem";
            resources.ApplyResources(this.crearKitToolStripMenuItem, "crearKitToolStripMenuItem");
            this.crearKitToolStripMenuItem.Click += new System.EventHandler(this.crearKitToolStripMenuItem_Click);
            // 
            // armarKitToolStripMenuItem
            // 
            this.armarKitToolStripMenuItem.Name = "armarKitToolStripMenuItem";
            resources.ApplyResources(this.armarKitToolStripMenuItem, "armarKitToolStripMenuItem");
            this.armarKitToolStripMenuItem.Click += new System.EventHandler(this.armarKitToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem11
            // 
            this.informesToolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizaFormulaDeKitToolStripMenuItem,
            this.detalleDeKitArmadosSegúnFechaToolStripMenuItem});
            this.informesToolStripMenuItem11.Name = "informesToolStripMenuItem11";
            resources.ApplyResources(this.informesToolStripMenuItem11, "informesToolStripMenuItem11");
            // 
            // visualizaFormulaDeKitToolStripMenuItem
            // 
            this.visualizaFormulaDeKitToolStripMenuItem.Name = "visualizaFormulaDeKitToolStripMenuItem";
            resources.ApplyResources(this.visualizaFormulaDeKitToolStripMenuItem, "visualizaFormulaDeKitToolStripMenuItem");
            this.visualizaFormulaDeKitToolStripMenuItem.Click += new System.EventHandler(this.visualizaFormulaDeKitToolStripMenuItem_Click);
            // 
            // detalleDeKitArmadosSegúnFechaToolStripMenuItem
            // 
            this.detalleDeKitArmadosSegúnFechaToolStripMenuItem.Name = "detalleDeKitArmadosSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDeKitArmadosSegúnFechaToolStripMenuItem, "detalleDeKitArmadosSegúnFechaToolStripMenuItem");
            this.detalleDeKitArmadosSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeKitArmadosSegúnFechaToolStripMenuItem_Click);
            // 
            // traspasoInternoEntreBodegasToolStripMenuItem
            // 
            this.traspasoInternoEntreBodegasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traspasosInternosToolStripMenuItem,
            this.informesToolStripMenuItem15});
            this.traspasoInternoEntreBodegasToolStripMenuItem.Name = "traspasoInternoEntreBodegasToolStripMenuItem";
            resources.ApplyResources(this.traspasoInternoEntreBodegasToolStripMenuItem, "traspasoInternoEntreBodegasToolStripMenuItem");
            this.traspasoInternoEntreBodegasToolStripMenuItem.Click += new System.EventHandler(this.traspasoInternoEntreBodegasToolStripMenuItem_Click);
            // 
            // traspasosInternosToolStripMenuItem
            // 
            this.traspasosInternosToolStripMenuItem.Name = "traspasosInternosToolStripMenuItem";
            resources.ApplyResources(this.traspasosInternosToolStripMenuItem, "traspasosInternosToolStripMenuItem");
            this.traspasosInternosToolStripMenuItem.Click += new System.EventHandler(this.traspasosInternosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem15
            // 
            this.informesToolStripMenuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTraspasosSegúnFechaToolStripMenuItem,
            this.detalleDeTraspasosSegúnFechaToolStripMenuItem});
            this.informesToolStripMenuItem15.Name = "informesToolStripMenuItem15";
            resources.ApplyResources(this.informesToolStripMenuItem15, "informesToolStripMenuItem15");
            // 
            // listadoDeTraspasosSegúnFechaToolStripMenuItem
            // 
            this.listadoDeTraspasosSegúnFechaToolStripMenuItem.Name = "listadoDeTraspasosSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeTraspasosSegúnFechaToolStripMenuItem, "listadoDeTraspasosSegúnFechaToolStripMenuItem");
            this.listadoDeTraspasosSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTraspasosSegúnFechaToolStripMenuItem_Click);
            // 
            // detalleDeTraspasosSegúnFechaToolStripMenuItem
            // 
            this.detalleDeTraspasosSegúnFechaToolStripMenuItem.Name = "detalleDeTraspasosSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.detalleDeTraspasosSegúnFechaToolStripMenuItem, "detalleDeTraspasosSegúnFechaToolStripMenuItem");
            this.detalleDeTraspasosSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeTraspasosSegúnFechaToolStripMenuItem_Click);
            // 
            // mantenedorDeProductosToolStripMenuItem
            // 
            this.mantenedorDeProductosToolStripMenuItem.Name = "mantenedorDeProductosToolStripMenuItem";
            resources.ApplyResources(this.mantenedorDeProductosToolStripMenuItem, "mantenedorDeProductosToolStripMenuItem");
            this.mantenedorDeProductosToolStripMenuItem.Click += new System.EventHandler(this.mantenedorDeProductosToolStripMenuItem_Click);
            // 
            // mantenedorDePromocionesToolStripMenuItem
            // 
            this.mantenedorDePromocionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorDePromocionesToolStripMenuItem1,
            this.informesToolStripMenuItem20});
            this.mantenedorDePromocionesToolStripMenuItem.Name = "mantenedorDePromocionesToolStripMenuItem";
            resources.ApplyResources(this.mantenedorDePromocionesToolStripMenuItem, "mantenedorDePromocionesToolStripMenuItem");
            this.mantenedorDePromocionesToolStripMenuItem.Click += new System.EventHandler(this.mantenedorDePromocionesToolStripMenuItem_Click);
            // 
            // mantenedorDePromocionesToolStripMenuItem1
            // 
            this.mantenedorDePromocionesToolStripMenuItem1.Name = "mantenedorDePromocionesToolStripMenuItem1";
            resources.ApplyResources(this.mantenedorDePromocionesToolStripMenuItem1, "mantenedorDePromocionesToolStripMenuItem1");
            this.mantenedorDePromocionesToolStripMenuItem1.Click += new System.EventHandler(this.mantenedorDePromocionesToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem20
            // 
            this.informesToolStripMenuItem20.Name = "informesToolStripMenuItem20";
            resources.ApplyResources(this.informesToolStripMenuItem20, "informesToolStripMenuItem20");
            // 
            // tomaDeInventarioToolStripMenuItem
            // 
            this.tomaDeInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tomaDeInventarioToolStripMenuItem1,
            this.informesToolStripMenuItem27});
            this.tomaDeInventarioToolStripMenuItem.Name = "tomaDeInventarioToolStripMenuItem";
            resources.ApplyResources(this.tomaDeInventarioToolStripMenuItem, "tomaDeInventarioToolStripMenuItem");
            // 
            // tomaDeInventarioToolStripMenuItem1
            // 
            this.tomaDeInventarioToolStripMenuItem1.Name = "tomaDeInventarioToolStripMenuItem1";
            resources.ApplyResources(this.tomaDeInventarioToolStripMenuItem1, "tomaDeInventarioToolStripMenuItem1");
            this.tomaDeInventarioToolStripMenuItem1.Click += new System.EventHandler(this.tomaDeInventarioToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem27
            // 
            this.informesToolStripMenuItem27.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTomaDeInventarioSegunFechaToolStripMenuItem});
            this.informesToolStripMenuItem27.Name = "informesToolStripMenuItem27";
            resources.ApplyResources(this.informesToolStripMenuItem27, "informesToolStripMenuItem27");
            // 
            // listadoDeTomaDeInventarioSegunFechaToolStripMenuItem
            // 
            this.listadoDeTomaDeInventarioSegunFechaToolStripMenuItem.Name = "listadoDeTomaDeInventarioSegunFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeTomaDeInventarioSegunFechaToolStripMenuItem, "listadoDeTomaDeInventarioSegunFechaToolStripMenuItem");
            this.listadoDeTomaDeInventarioSegunFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTomaDeInventarioSegunFechaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // informesToolStripMenuItem7
            // 
            this.informesToolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existenciasPorBodegaToolStripMenuItem,
            this.listadoGeneralDePreciosToolStripMenuItem,
            this.listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem,
            this.listadoDeArticulosBajoStockMinimoToolStripMenuItem,
            this.listadoDeArticulosParaTomaDeInventarioToolStripMenuItem,
            this.toolStripSeparator1,
            this.movimientoDeArticulosToolStripMenuItem,
            this.rankingDeProductosMasVendidosToolStripMenuItem,
            this.detalleDeVentasPorProductoToolStripMenuItem,
            this.detalleDeComprasPorProductoToolStripMenuItem,
            this.detalleDeComprasPorProveedorToolStripMenuItem,
            this.kardexPorProductoToolStripMenuItem,
            this.entradaDeProductosABodegaToolStripMenuItem,
            this.seguimientoLoteToolStripMenuItem,
            this.seguimientoLotePorCodigoProductoToolStripMenuItem,
            this.valorizacionDeExistenciaToolStripMenuItem});
            this.informesToolStripMenuItem7.Name = "informesToolStripMenuItem7";
            resources.ApplyResources(this.informesToolStripMenuItem7, "informesToolStripMenuItem7");
            // 
            // existenciasPorBodegaToolStripMenuItem
            // 
            this.existenciasPorBodegaToolStripMenuItem.Name = "existenciasPorBodegaToolStripMenuItem";
            resources.ApplyResources(this.existenciasPorBodegaToolStripMenuItem, "existenciasPorBodegaToolStripMenuItem");
            this.existenciasPorBodegaToolStripMenuItem.Click += new System.EventHandler(this.existenciasPorBodegaToolStripMenuItem_Click);
            // 
            // listadoGeneralDePreciosToolStripMenuItem
            // 
            this.listadoGeneralDePreciosToolStripMenuItem.Name = "listadoGeneralDePreciosToolStripMenuItem";
            resources.ApplyResources(this.listadoGeneralDePreciosToolStripMenuItem, "listadoGeneralDePreciosToolStripMenuItem");
            this.listadoGeneralDePreciosToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDePreciosToolStripMenuItem_Click);
            // 
            // listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem
            // 
            this.listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem.Name = "listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem";
            resources.ApplyResources(this.listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem, "listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem");
            this.listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDePreciosYSuRentabilidadToolStripMenuItem_Click);
            // 
            // listadoDeArticulosBajoStockMinimoToolStripMenuItem
            // 
            this.listadoDeArticulosBajoStockMinimoToolStripMenuItem.Name = "listadoDeArticulosBajoStockMinimoToolStripMenuItem";
            resources.ApplyResources(this.listadoDeArticulosBajoStockMinimoToolStripMenuItem, "listadoDeArticulosBajoStockMinimoToolStripMenuItem");
            this.listadoDeArticulosBajoStockMinimoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosBajoStockMinimoToolStripMenuItem_Click);
            // 
            // listadoDeArticulosParaTomaDeInventarioToolStripMenuItem
            // 
            this.listadoDeArticulosParaTomaDeInventarioToolStripMenuItem.Name = "listadoDeArticulosParaTomaDeInventarioToolStripMenuItem";
            resources.ApplyResources(this.listadoDeArticulosParaTomaDeInventarioToolStripMenuItem, "listadoDeArticulosParaTomaDeInventarioToolStripMenuItem");
            this.listadoDeArticulosParaTomaDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.listadoDeArticulosParaTomaDeInventarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // movimientoDeArticulosToolStripMenuItem
            // 
            this.movimientoDeArticulosToolStripMenuItem.Name = "movimientoDeArticulosToolStripMenuItem";
            resources.ApplyResources(this.movimientoDeArticulosToolStripMenuItem, "movimientoDeArticulosToolStripMenuItem");
            this.movimientoDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.movimientoDeArticulosToolStripMenuItem_Click);
            // 
            // rankingDeProductosMasVendidosToolStripMenuItem
            // 
            this.rankingDeProductosMasVendidosToolStripMenuItem.Name = "rankingDeProductosMasVendidosToolStripMenuItem";
            resources.ApplyResources(this.rankingDeProductosMasVendidosToolStripMenuItem, "rankingDeProductosMasVendidosToolStripMenuItem");
            this.rankingDeProductosMasVendidosToolStripMenuItem.Click += new System.EventHandler(this.rankingDeProductosMasVendidosToolStripMenuItem_Click);
            // 
            // detalleDeVentasPorProductoToolStripMenuItem
            // 
            this.detalleDeVentasPorProductoToolStripMenuItem.Name = "detalleDeVentasPorProductoToolStripMenuItem";
            resources.ApplyResources(this.detalleDeVentasPorProductoToolStripMenuItem, "detalleDeVentasPorProductoToolStripMenuItem");
            this.detalleDeVentasPorProductoToolStripMenuItem.Click += new System.EventHandler(this.detalleDeVentasPorProductoToolStripMenuItem_Click);
            // 
            // detalleDeComprasPorProductoToolStripMenuItem
            // 
            this.detalleDeComprasPorProductoToolStripMenuItem.Name = "detalleDeComprasPorProductoToolStripMenuItem";
            resources.ApplyResources(this.detalleDeComprasPorProductoToolStripMenuItem, "detalleDeComprasPorProductoToolStripMenuItem");
            this.detalleDeComprasPorProductoToolStripMenuItem.Click += new System.EventHandler(this.detalleDeComprasPorProductoToolStripMenuItem_Click);
            // 
            // detalleDeComprasPorProveedorToolStripMenuItem
            // 
            this.detalleDeComprasPorProveedorToolStripMenuItem.Name = "detalleDeComprasPorProveedorToolStripMenuItem";
            resources.ApplyResources(this.detalleDeComprasPorProveedorToolStripMenuItem, "detalleDeComprasPorProveedorToolStripMenuItem");
            this.detalleDeComprasPorProveedorToolStripMenuItem.Click += new System.EventHandler(this.detalleDeComprasPorProveedorToolStripMenuItem_Click);
            // 
            // kardexPorProductoToolStripMenuItem
            // 
            this.kardexPorProductoToolStripMenuItem.Name = "kardexPorProductoToolStripMenuItem";
            resources.ApplyResources(this.kardexPorProductoToolStripMenuItem, "kardexPorProductoToolStripMenuItem");
            this.kardexPorProductoToolStripMenuItem.Click += new System.EventHandler(this.kardexPorProductoToolStripMenuItem_Click);
            // 
            // entradaDeProductosABodegaToolStripMenuItem
            // 
            this.entradaDeProductosABodegaToolStripMenuItem.Name = "entradaDeProductosABodegaToolStripMenuItem";
            resources.ApplyResources(this.entradaDeProductosABodegaToolStripMenuItem, "entradaDeProductosABodegaToolStripMenuItem");
            this.entradaDeProductosABodegaToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProductosABodegaToolStripMenuItem_Click);
            // 
            // seguimientoLoteToolStripMenuItem
            // 
            this.seguimientoLoteToolStripMenuItem.Name = "seguimientoLoteToolStripMenuItem";
            resources.ApplyResources(this.seguimientoLoteToolStripMenuItem, "seguimientoLoteToolStripMenuItem");
            this.seguimientoLoteToolStripMenuItem.Click += new System.EventHandler(this.seguimientoLoteToolStripMenuItem_Click);
            // 
            // seguimientoLotePorCodigoProductoToolStripMenuItem
            // 
            this.seguimientoLotePorCodigoProductoToolStripMenuItem.Name = "seguimientoLotePorCodigoProductoToolStripMenuItem";
            resources.ApplyResources(this.seguimientoLotePorCodigoProductoToolStripMenuItem, "seguimientoLotePorCodigoProductoToolStripMenuItem");
            this.seguimientoLotePorCodigoProductoToolStripMenuItem.Click += new System.EventHandler(this.seguimientoLotePorCodigoProductoToolStripMenuItem_Click);
            // 
            // valorizacionDeExistenciaToolStripMenuItem
            // 
            this.valorizacionDeExistenciaToolStripMenuItem.Name = "valorizacionDeExistenciaToolStripMenuItem";
            resources.ApplyResources(this.valorizacionDeExistenciaToolStripMenuItem, "valorizacionDeExistenciaToolStripMenuItem");
            this.valorizacionDeExistenciaToolStripMenuItem.Click += new System.EventHandler(this.valorizacionDeExistenciaToolStripMenuItem_Click);
            // 
            // ordenDeTrabajoToolStripMenuItem
            // 
            this.ordenDeTrabajoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeTrabajoToolStripMenuItem1,
            this.tecnicosToolStripMenuItem,
            this.informesToolStripMenuItem16});
            this.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem";
            resources.ApplyResources(this.ordenDeTrabajoToolStripMenuItem, "ordenDeTrabajoToolStripMenuItem");
            // 
            // ordenDeTrabajoToolStripMenuItem1
            // 
            this.ordenDeTrabajoToolStripMenuItem1.Name = "ordenDeTrabajoToolStripMenuItem1";
            resources.ApplyResources(this.ordenDeTrabajoToolStripMenuItem1, "ordenDeTrabajoToolStripMenuItem1");
            this.ordenDeTrabajoToolStripMenuItem1.Click += new System.EventHandler(this.ordenDeTrabajoToolStripMenuItem1_Click);
            // 
            // tecnicosToolStripMenuItem
            // 
            this.tecnicosToolStripMenuItem.Name = "tecnicosToolStripMenuItem";
            resources.ApplyResources(this.tecnicosToolStripMenuItem, "tecnicosToolStripMenuItem");
            this.tecnicosToolStripMenuItem.Click += new System.EventHandler(this.tecnicosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem16
            // 
            this.informesToolStripMenuItem16.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeOTSegúnFechaToolStripMenuItem});
            this.informesToolStripMenuItem16.Name = "informesToolStripMenuItem16";
            resources.ApplyResources(this.informesToolStripMenuItem16, "informesToolStripMenuItem16");
            // 
            // listadoDeOTSegúnFechaToolStripMenuItem
            // 
            this.listadoDeOTSegúnFechaToolStripMenuItem.Name = "listadoDeOTSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeOTSegúnFechaToolStripMenuItem, "listadoDeOTSegúnFechaToolStripMenuItem");
            this.listadoDeOTSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeOTSegúnFechaToolStripMenuItem_Click);
            // 
            // atenciónClientesToolStripMenuItem
            // 
            this.atenciónClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeAtenciónToolStripMenuItem,
            this.preClienteToolStripMenuItem,
            this.preVentaToolStripMenuItem,
            this.moduloFacturacionToolStripMenuItem});
            this.atenciónClientesToolStripMenuItem.Name = "atenciónClientesToolStripMenuItem";
            resources.ApplyResources(this.atenciónClientesToolStripMenuItem, "atenciónClientesToolStripMenuItem");
            // 
            // ordenDeAtenciónToolStripMenuItem
            // 
            this.ordenDeAtenciónToolStripMenuItem.Name = "ordenDeAtenciónToolStripMenuItem";
            resources.ApplyResources(this.ordenDeAtenciónToolStripMenuItem, "ordenDeAtenciónToolStripMenuItem");
            this.ordenDeAtenciónToolStripMenuItem.Click += new System.EventHandler(this.ordenDeAtenciónToolStripMenuItem_Click);
            // 
            // preClienteToolStripMenuItem
            // 
            this.preClienteToolStripMenuItem.Name = "preClienteToolStripMenuItem";
            resources.ApplyResources(this.preClienteToolStripMenuItem, "preClienteToolStripMenuItem");
            this.preClienteToolStripMenuItem.Click += new System.EventHandler(this.preClienteToolStripMenuItem_Click);
            // 
            // preVentaToolStripMenuItem
            // 
            this.preVentaToolStripMenuItem.Name = "preVentaToolStripMenuItem";
            resources.ApplyResources(this.preVentaToolStripMenuItem, "preVentaToolStripMenuItem");
            this.preVentaToolStripMenuItem.Click += new System.EventHandler(this.preVentaToolStripMenuItem_Click);
            // 
            // moduloFacturacionToolStripMenuItem
            // 
            this.moduloFacturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduloFacturacionToolStripMenuItem1,
            this.maestroDeOfertasToolStripMenuItem,
            this.moduloDeContratacionToolStripMenuItem});
            this.moduloFacturacionToolStripMenuItem.Name = "moduloFacturacionToolStripMenuItem";
            resources.ApplyResources(this.moduloFacturacionToolStripMenuItem, "moduloFacturacionToolStripMenuItem");
            this.moduloFacturacionToolStripMenuItem.Click += new System.EventHandler(this.moduloFacturacionToolStripMenuItem_Click);
            // 
            // moduloFacturacionToolStripMenuItem1
            // 
            this.moduloFacturacionToolStripMenuItem1.Name = "moduloFacturacionToolStripMenuItem1";
            resources.ApplyResources(this.moduloFacturacionToolStripMenuItem1, "moduloFacturacionToolStripMenuItem1");
            this.moduloFacturacionToolStripMenuItem1.Click += new System.EventHandler(this.moduloFacturacionToolStripMenuItem1_Click);
            // 
            // maestroDeOfertasToolStripMenuItem
            // 
            this.maestroDeOfertasToolStripMenuItem.Name = "maestroDeOfertasToolStripMenuItem";
            resources.ApplyResources(this.maestroDeOfertasToolStripMenuItem, "maestroDeOfertasToolStripMenuItem");
            this.maestroDeOfertasToolStripMenuItem.Click += new System.EventHandler(this.maestroDeOfertasToolStripMenuItem_Click);
            // 
            // moduloDeContratacionToolStripMenuItem
            // 
            this.moduloDeContratacionToolStripMenuItem.Name = "moduloDeContratacionToolStripMenuItem";
            resources.ApplyResources(this.moduloDeContratacionToolStripMenuItem, "moduloDeContratacionToolStripMenuItem");
            this.moduloDeContratacionToolStripMenuItem.Click += new System.EventHandler(this.moduloDeContratacionToolStripMenuItem_Click);
            // 
            // electronicaToolStripMenuItem
            // 
            this.electronicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cAFToolStripMenuItem,
            this.toolStripSeparator8,
            this.facturaElectronicaToolStripMenuItem,
            this.facturaExentaElectronicaToolStripMenuItem,
            this.notaDeCreditoElectronicaToolStripMenuItem,
            this.notaDeDebitoElectronicaToolStripMenuItem,
            this.guiaDeDespachoElectronicaToolStripMenuItem,
            this.boletaElectronicaToolStripMenuItem,
            this.boletaElectronicaExentaToolStripMenuItem,
            this.toolStripSeparator9,
            this.comprasElectronicasToolStripMenuItem,
            this.toolStripSeparator6,
            this.generadorDeEnviosToolStripMenuItem,
            this.toolStripSeparator7,
            this.datosDelEmisorToolStripMenuItem,
            this.opcionesLocalesToolStripMenuItem});
            this.electronicaToolStripMenuItem.Name = "electronicaToolStripMenuItem";
            resources.ApplyResources(this.electronicaToolStripMenuItem, "electronicaToolStripMenuItem");
            // 
            // cAFToolStripMenuItem
            // 
            this.cAFToolStripMenuItem.Name = "cAFToolStripMenuItem";
            resources.ApplyResources(this.cAFToolStripMenuItem, "cAFToolStripMenuItem");
            this.cAFToolStripMenuItem.Click += new System.EventHandler(this.cAFToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // facturaElectronicaToolStripMenuItem
            // 
            this.facturaElectronicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaElectronicaToolStripMenuItem1,
            this.informesToolStripMenuItem19});
            this.facturaElectronicaToolStripMenuItem.Name = "facturaElectronicaToolStripMenuItem";
            resources.ApplyResources(this.facturaElectronicaToolStripMenuItem, "facturaElectronicaToolStripMenuItem");
            this.facturaElectronicaToolStripMenuItem.Click += new System.EventHandler(this.facturaElectronicaToolStripMenuItem_Click);
            // 
            // facturaElectronicaToolStripMenuItem1
            // 
            this.facturaElectronicaToolStripMenuItem1.Name = "facturaElectronicaToolStripMenuItem1";
            resources.ApplyResources(this.facturaElectronicaToolStripMenuItem1, "facturaElectronicaToolStripMenuItem1");
            this.facturaElectronicaToolStripMenuItem1.Click += new System.EventHandler(this.facturaElectronicaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem19
            // 
            this.informesToolStripMenuItem19.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeFacturasSegúnFechaToolStripMenuItem1,
            this.listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem,
            this.listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem,
            this.visualizarFacturaElectronicaToolStripMenuItem});
            this.informesToolStripMenuItem19.Name = "informesToolStripMenuItem19";
            resources.ApplyResources(this.informesToolStripMenuItem19, "informesToolStripMenuItem19");
            // 
            // listadoDeFacturasSegúnFechaToolStripMenuItem1
            // 
            this.listadoDeFacturasSegúnFechaToolStripMenuItem1.Name = "listadoDeFacturasSegúnFechaToolStripMenuItem1";
            resources.ApplyResources(this.listadoDeFacturasSegúnFechaToolStripMenuItem1, "listadoDeFacturasSegúnFechaToolStripMenuItem1");
            this.listadoDeFacturasSegúnFechaToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeFacturasSegúnFechaToolStripMenuItem1_Click);
            // 
            // listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem, "listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasElectronicasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasElectronicasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem
            // 
            this.listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem.Name = "listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem, "listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem");
            this.listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasElectronicasPendientesDePagoToolStripMenuItem_Click);
            // 
            // listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem
            // 
            this.listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem.Name = "listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem";
            resources.ApplyResources(this.listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem, "listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem");
            this.listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosVendidosAgrupadosPorCatgoeriasToolStripMenuItem_Click);
            // 
            // visualizarFacturaElectronicaToolStripMenuItem
            // 
            this.visualizarFacturaElectronicaToolStripMenuItem.Name = "visualizarFacturaElectronicaToolStripMenuItem";
            resources.ApplyResources(this.visualizarFacturaElectronicaToolStripMenuItem, "visualizarFacturaElectronicaToolStripMenuItem");
            this.visualizarFacturaElectronicaToolStripMenuItem.Click += new System.EventHandler(this.visualizarFacturaElectronicaToolStripMenuItem_Click);
            // 
            // facturaExentaElectronicaToolStripMenuItem
            // 
            this.facturaExentaElectronicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaExentaElectronicaToolStripMenuItem1,
            this.informesToolStripMenuItem24});
            this.facturaExentaElectronicaToolStripMenuItem.Name = "facturaExentaElectronicaToolStripMenuItem";
            resources.ApplyResources(this.facturaExentaElectronicaToolStripMenuItem, "facturaExentaElectronicaToolStripMenuItem");
            // 
            // facturaExentaElectronicaToolStripMenuItem1
            // 
            this.facturaExentaElectronicaToolStripMenuItem1.Name = "facturaExentaElectronicaToolStripMenuItem1";
            resources.ApplyResources(this.facturaExentaElectronicaToolStripMenuItem1, "facturaExentaElectronicaToolStripMenuItem1");
            this.facturaExentaElectronicaToolStripMenuItem1.Click += new System.EventHandler(this.facturaExentaElectronicaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem24
            // 
            this.informesToolStripMenuItem24.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.informesToolStripMenuItem24.Name = "informesToolStripMenuItem24";
            resources.ApplyResources(this.informesToolStripMenuItem24, "informesToolStripMenuItem24");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // notaDeCreditoElectronicaToolStripMenuItem
            // 
            this.notaDeCreditoElectronicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaDeCreditoElectronicaToolStripMenuItem1,
            this.informesToolStripMenuItem21});
            this.notaDeCreditoElectronicaToolStripMenuItem.Name = "notaDeCreditoElectronicaToolStripMenuItem";
            resources.ApplyResources(this.notaDeCreditoElectronicaToolStripMenuItem, "notaDeCreditoElectronicaToolStripMenuItem");
            // 
            // notaDeCreditoElectronicaToolStripMenuItem1
            // 
            this.notaDeCreditoElectronicaToolStripMenuItem1.Name = "notaDeCreditoElectronicaToolStripMenuItem1";
            resources.ApplyResources(this.notaDeCreditoElectronicaToolStripMenuItem1, "notaDeCreditoElectronicaToolStripMenuItem1");
            this.notaDeCreditoElectronicaToolStripMenuItem1.Click += new System.EventHandler(this.notaDeCreditoElectronicaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem21
            // 
            this.informesToolStripMenuItem21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.visualizarNotaDeCreditoElectronicaToolStripMenuItem});
            this.informesToolStripMenuItem21.Name = "informesToolStripMenuItem21";
            resources.ApplyResources(this.informesToolStripMenuItem21, "informesToolStripMenuItem21");
            // 
            // listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem, "listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeCreditoElectronicasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem, "listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeCreditoElectronicasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeCreditoElectronicasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeCreditoElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarNotaDeCreditoElectronicaToolStripMenuItem
            // 
            this.visualizarNotaDeCreditoElectronicaToolStripMenuItem.Name = "visualizarNotaDeCreditoElectronicaToolStripMenuItem";
            resources.ApplyResources(this.visualizarNotaDeCreditoElectronicaToolStripMenuItem, "visualizarNotaDeCreditoElectronicaToolStripMenuItem");
            this.visualizarNotaDeCreditoElectronicaToolStripMenuItem.Click += new System.EventHandler(this.visualizarNotaDeCreditoElectronicaToolStripMenuItem_Click);
            // 
            // notaDeDebitoElectronicaToolStripMenuItem
            // 
            this.notaDeDebitoElectronicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaDeDebitoElectronicaToolStripMenuItem1,
            this.informesToolStripMenuItem22});
            this.notaDeDebitoElectronicaToolStripMenuItem.Name = "notaDeDebitoElectronicaToolStripMenuItem";
            resources.ApplyResources(this.notaDeDebitoElectronicaToolStripMenuItem, "notaDeDebitoElectronicaToolStripMenuItem");
            // 
            // notaDeDebitoElectronicaToolStripMenuItem1
            // 
            this.notaDeDebitoElectronicaToolStripMenuItem1.Name = "notaDeDebitoElectronicaToolStripMenuItem1";
            resources.ApplyResources(this.notaDeDebitoElectronicaToolStripMenuItem1, "notaDeDebitoElectronicaToolStripMenuItem1");
            this.notaDeDebitoElectronicaToolStripMenuItem1.Click += new System.EventHandler(this.notaDeDebitoElectronicaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem22
            // 
            this.informesToolStripMenuItem22.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem,
            this.visualizarNotaDeDebitoElectronicaToolStripMenuItem});
            this.informesToolStripMenuItem22.Name = "informesToolStripMenuItem22";
            resources.ApplyResources(this.informesToolStripMenuItem22, "informesToolStripMenuItem22");
            // 
            // listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem, "listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeDebitoElectronicasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem, "listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeDebitoElectronicasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeDebitoElectronicasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem.Name = "listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem, "listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem");
            this.listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeNotasDeDebitoElectronicasPorCentroCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // visualizarNotaDeDebitoElectronicaToolStripMenuItem
            // 
            this.visualizarNotaDeDebitoElectronicaToolStripMenuItem.Name = "visualizarNotaDeDebitoElectronicaToolStripMenuItem";
            resources.ApplyResources(this.visualizarNotaDeDebitoElectronicaToolStripMenuItem, "visualizarNotaDeDebitoElectronicaToolStripMenuItem");
            this.visualizarNotaDeDebitoElectronicaToolStripMenuItem.Click += new System.EventHandler(this.visualizarNotaDeDebitoElectronicaToolStripMenuItem_Click);
            // 
            // guiaDeDespachoElectronicaToolStripMenuItem
            // 
            this.guiaDeDespachoElectronicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiaDeDespachoElectronicaToolStripMenuItem1,
            this.informesToolStripMenuItem23});
            this.guiaDeDespachoElectronicaToolStripMenuItem.Name = "guiaDeDespachoElectronicaToolStripMenuItem";
            resources.ApplyResources(this.guiaDeDespachoElectronicaToolStripMenuItem, "guiaDeDespachoElectronicaToolStripMenuItem");
            // 
            // guiaDeDespachoElectronicaToolStripMenuItem1
            // 
            this.guiaDeDespachoElectronicaToolStripMenuItem1.Name = "guiaDeDespachoElectronicaToolStripMenuItem1";
            resources.ApplyResources(this.guiaDeDespachoElectronicaToolStripMenuItem1, "guiaDeDespachoElectronicaToolStripMenuItem1");
            this.guiaDeDespachoElectronicaToolStripMenuItem1.Click += new System.EventHandler(this.guiaDeDespachoElectronicaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem23
            // 
            this.informesToolStripMenuItem23.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem,
            this.listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem,
            this.guiasElectronicasNOFacturadasToolStripMenuItem,
            this.visualizarGuiasElectronicaToolStripMenuItem});
            this.informesToolStripMenuItem23.Name = "informesToolStripMenuItem23";
            resources.ApplyResources(this.informesToolStripMenuItem23, "informesToolStripMenuItem23");
            // 
            // listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem, "listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasElectronicasSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem, "listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasElectronicasPorClienteSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem, "listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasElectronicasPorVendedorSegúnFechaToolStripMenuItem_Click);
            // 
            // listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem
            // 
            this.listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem.Name = "listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem";
            resources.ApplyResources(this.listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem, "listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem");
            this.listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeGuiasElectronicasPorCentroDeCostoSegúnFechaToolStripMenuItem_Click);
            // 
            // guiasElectronicasNOFacturadasToolStripMenuItem
            // 
            this.guiasElectronicasNOFacturadasToolStripMenuItem.Name = "guiasElectronicasNOFacturadasToolStripMenuItem";
            resources.ApplyResources(this.guiasElectronicasNOFacturadasToolStripMenuItem, "guiasElectronicasNOFacturadasToolStripMenuItem");
            this.guiasElectronicasNOFacturadasToolStripMenuItem.Click += new System.EventHandler(this.guiasElectronicasNOFacturadasToolStripMenuItem_Click);
            // 
            // visualizarGuiasElectronicaToolStripMenuItem
            // 
            this.visualizarGuiasElectronicaToolStripMenuItem.Name = "visualizarGuiasElectronicaToolStripMenuItem";
            resources.ApplyResources(this.visualizarGuiasElectronicaToolStripMenuItem, "visualizarGuiasElectronicaToolStripMenuItem");
            this.visualizarGuiasElectronicaToolStripMenuItem.Click += new System.EventHandler(this.visualizarGuiasElectronicaToolStripMenuItem_Click);
            // 
            // boletaElectronicaToolStripMenuItem
            // 
            this.boletaElectronicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletaElectronicaToolStripMenuItem1,
            this.informesToolStripMenuItem25});
            this.boletaElectronicaToolStripMenuItem.Name = "boletaElectronicaToolStripMenuItem";
            resources.ApplyResources(this.boletaElectronicaToolStripMenuItem, "boletaElectronicaToolStripMenuItem");
            // 
            // boletaElectronicaToolStripMenuItem1
            // 
            this.boletaElectronicaToolStripMenuItem1.Name = "boletaElectronicaToolStripMenuItem1";
            resources.ApplyResources(this.boletaElectronicaToolStripMenuItem1, "boletaElectronicaToolStripMenuItem1");
            this.boletaElectronicaToolStripMenuItem1.Click += new System.EventHandler(this.boletaElectronicaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem25
            // 
            this.informesToolStripMenuItem25.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            this.informesToolStripMenuItem25.Name = "informesToolStripMenuItem25";
            resources.ApplyResources(this.informesToolStripMenuItem25, "informesToolStripMenuItem25");
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            resources.ApplyResources(this.toolStripMenuItem13, "toolStripMenuItem13");
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            resources.ApplyResources(this.toolStripMenuItem14, "toolStripMenuItem14");
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            resources.ApplyResources(this.toolStripMenuItem15, "toolStripMenuItem15");
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            resources.ApplyResources(this.toolStripMenuItem16, "toolStripMenuItem16");
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // boletaElectronicaExentaToolStripMenuItem
            // 
            this.boletaElectronicaExentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletaElectronicaExentaToolStripMenuItem1,
            this.informesToolStripMenuItem26});
            this.boletaElectronicaExentaToolStripMenuItem.Name = "boletaElectronicaExentaToolStripMenuItem";
            resources.ApplyResources(this.boletaElectronicaExentaToolStripMenuItem, "boletaElectronicaExentaToolStripMenuItem");
            // 
            // boletaElectronicaExentaToolStripMenuItem1
            // 
            this.boletaElectronicaExentaToolStripMenuItem1.Name = "boletaElectronicaExentaToolStripMenuItem1";
            resources.ApplyResources(this.boletaElectronicaExentaToolStripMenuItem1, "boletaElectronicaExentaToolStripMenuItem1");
            this.boletaElectronicaExentaToolStripMenuItem1.Click += new System.EventHandler(this.boletaElectronicaExentaToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem26
            // 
            this.informesToolStripMenuItem26.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25});
            this.informesToolStripMenuItem26.Name = "informesToolStripMenuItem26";
            resources.ApplyResources(this.informesToolStripMenuItem26, "informesToolStripMenuItem26");
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            resources.ApplyResources(this.toolStripMenuItem17, "toolStripMenuItem17");
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem17_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            resources.ApplyResources(this.toolStripMenuItem18, "toolStripMenuItem18");
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            resources.ApplyResources(this.toolStripMenuItem19, "toolStripMenuItem19");
            this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem19_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            resources.ApplyResources(this.toolStripMenuItem20, "toolStripMenuItem20");
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem20_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            resources.ApplyResources(this.toolStripMenuItem21, "toolStripMenuItem21");
            this.toolStripMenuItem21.Click += new System.EventHandler(this.toolStripMenuItem21_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            resources.ApplyResources(this.toolStripMenuItem22, "toolStripMenuItem22");
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem22_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            resources.ApplyResources(this.toolStripMenuItem23, "toolStripMenuItem23");
            this.toolStripMenuItem23.Click += new System.EventHandler(this.toolStripMenuItem23_Click);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            resources.ApplyResources(this.toolStripMenuItem24, "toolStripMenuItem24");
            this.toolStripMenuItem24.Click += new System.EventHandler(this.toolStripMenuItem24_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            resources.ApplyResources(this.toolStripMenuItem25, "toolStripMenuItem25");
            this.toolStripMenuItem25.Click += new System.EventHandler(this.toolStripMenuItem25_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // comprasElectronicasToolStripMenuItem
            // 
            this.comprasElectronicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intercambioDeInformacionToolStripMenuItem1});
            this.comprasElectronicasToolStripMenuItem.Name = "comprasElectronicasToolStripMenuItem";
            resources.ApplyResources(this.comprasElectronicasToolStripMenuItem, "comprasElectronicasToolStripMenuItem");
            // 
            // intercambioDeInformacionToolStripMenuItem1
            // 
            this.intercambioDeInformacionToolStripMenuItem1.Name = "intercambioDeInformacionToolStripMenuItem1";
            resources.ApplyResources(this.intercambioDeInformacionToolStripMenuItem1, "intercambioDeInformacionToolStripMenuItem1");
            this.intercambioDeInformacionToolStripMenuItem1.Click += new System.EventHandler(this.intercambioDeInformacionToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // generadorDeEnviosToolStripMenuItem
            // 
            this.generadorDeEnviosToolStripMenuItem.Name = "generadorDeEnviosToolStripMenuItem";
            resources.ApplyResources(this.generadorDeEnviosToolStripMenuItem, "generadorDeEnviosToolStripMenuItem");
            this.generadorDeEnviosToolStripMenuItem.Click += new System.EventHandler(this.generadorDeEnviosToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // datosDelEmisorToolStripMenuItem
            // 
            this.datosDelEmisorToolStripMenuItem.Name = "datosDelEmisorToolStripMenuItem";
            resources.ApplyResources(this.datosDelEmisorToolStripMenuItem, "datosDelEmisorToolStripMenuItem");
            this.datosDelEmisorToolStripMenuItem.Click += new System.EventHandler(this.datosDelEmisorToolStripMenuItem_Click);
            // 
            // opcionesLocalesToolStripMenuItem
            // 
            this.opcionesLocalesToolStripMenuItem.Name = "opcionesLocalesToolStripMenuItem";
            resources.ApplyResources(this.opcionesLocalesToolStripMenuItem, "opcionesLocalesToolStripMenuItem");
            this.opcionesLocalesToolStripMenuItem.Click += new System.EventHandler(this.opcionesLocalesToolStripMenuItem_Click);
            // 
            // restaurantToolStripMenuItem
            // 
            this.restaurantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.garzonesToolStripMenuItem,
            this.atenciónToolStripMenuItem,
            this.configuracionBotonesComandaToolStripMenuItem,
            this.informesToolStripMenuItem17});
            resources.ApplyResources(this.restaurantToolStripMenuItem, "restaurantToolStripMenuItem");
            this.restaurantToolStripMenuItem.Name = "restaurantToolStripMenuItem";
            this.restaurantToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.restaurantToolStripMenuItem.Click += new System.EventHandler(this.restaurantToolStripMenuItem_Click);
            // 
            // garzonesToolStripMenuItem
            // 
            this.garzonesToolStripMenuItem.Name = "garzonesToolStripMenuItem";
            resources.ApplyResources(this.garzonesToolStripMenuItem, "garzonesToolStripMenuItem");
            this.garzonesToolStripMenuItem.Click += new System.EventHandler(this.garzonesToolStripMenuItem_Click);
            // 
            // atenciónToolStripMenuItem
            // 
            this.atenciónToolStripMenuItem.Name = "atenciónToolStripMenuItem";
            resources.ApplyResources(this.atenciónToolStripMenuItem, "atenciónToolStripMenuItem");
            this.atenciónToolStripMenuItem.Click += new System.EventHandler(this.atenciónToolStripMenuItem_Click);
            // 
            // configuracionBotonesComandaToolStripMenuItem
            // 
            this.configuracionBotonesComandaToolStripMenuItem.Name = "configuracionBotonesComandaToolStripMenuItem";
            resources.ApplyResources(this.configuracionBotonesComandaToolStripMenuItem, "configuracionBotonesComandaToolStripMenuItem");
            this.configuracionBotonesComandaToolStripMenuItem.Click += new System.EventHandler(this.configuracionBotonesComandaToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem17
            // 
            this.informesToolStripMenuItem17.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeComandasToolStripMenuItem});
            this.informesToolStripMenuItem17.Name = "informesToolStripMenuItem17";
            resources.ApplyResources(this.informesToolStripMenuItem17, "informesToolStripMenuItem17");
            // 
            // listadoDeComandasToolStripMenuItem
            // 
            this.listadoDeComandasToolStripMenuItem.Name = "listadoDeComandasToolStripMenuItem";
            resources.ApplyResources(this.listadoDeComandasToolStripMenuItem, "listadoDeComandasToolStripMenuItem");
            this.listadoDeComandasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeComandasToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem1
            // 
            this.opcionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impuestosEspecialesToolStripMenuItem1,
            this.vendedoresToolStripMenuItem,
            this.mediosDeToolStripMenuItem,
            this.mediosDePagoFiscalToolStripMenuItem,
            this.opcionesToolStripMenuItem2,
            this.centroDeCostoToolStripMenuItem,
            this.bancosToolStripMenuItem,
            this.rubrosToolStripMenuItem,
            this.periodosContablesToolStripMenuItem,
            this.impresorasToolStripMenuItem,
            this.maestroDeBodegasToolStripMenuItem,
            this.mestroDeListasDePrecioToolStripMenuItem,
            this.maestroDeCajasToolStripMenuItem,
            this.tipoDeUsuariosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.respaldarInformaciónToolStripMenuItem,
            this.odepaToolStripMenuItem,
            this.respaldarInstalacionToolStripMenuItem,
            this.generadorDeCodigosDeBarraToolStripMenuItem});
            this.opcionesToolStripMenuItem1.Name = "opcionesToolStripMenuItem1";
            resources.ApplyResources(this.opcionesToolStripMenuItem1, "opcionesToolStripMenuItem1");
            // 
            // impuestosEspecialesToolStripMenuItem1
            // 
            this.impuestosEspecialesToolStripMenuItem1.Name = "impuestosEspecialesToolStripMenuItem1";
            resources.ApplyResources(this.impuestosEspecialesToolStripMenuItem1, "impuestosEspecialesToolStripMenuItem1");
            this.impuestosEspecialesToolStripMenuItem1.Click += new System.EventHandler(this.impuestosEspecialesToolStripMenuItem1_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            resources.ApplyResources(this.vendedoresToolStripMenuItem, "vendedoresToolStripMenuItem");
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // mediosDeToolStripMenuItem
            // 
            this.mediosDeToolStripMenuItem.Name = "mediosDeToolStripMenuItem";
            resources.ApplyResources(this.mediosDeToolStripMenuItem, "mediosDeToolStripMenuItem");
            this.mediosDeToolStripMenuItem.Click += new System.EventHandler(this.mediosDeToolStripMenuItem_Click);
            // 
            // mediosDePagoFiscalToolStripMenuItem
            // 
            this.mediosDePagoFiscalToolStripMenuItem.Name = "mediosDePagoFiscalToolStripMenuItem";
            resources.ApplyResources(this.mediosDePagoFiscalToolStripMenuItem, "mediosDePagoFiscalToolStripMenuItem");
            this.mediosDePagoFiscalToolStripMenuItem.Click += new System.EventHandler(this.mediosDePagoFiscalToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem2
            // 
            this.opcionesToolStripMenuItem2.Name = "opcionesToolStripMenuItem2";
            resources.ApplyResources(this.opcionesToolStripMenuItem2, "opcionesToolStripMenuItem2");
            this.opcionesToolStripMenuItem2.Click += new System.EventHandler(this.opcionesToolStripMenuItem2_Click);
            // 
            // centroDeCostoToolStripMenuItem
            // 
            this.centroDeCostoToolStripMenuItem.Name = "centroDeCostoToolStripMenuItem";
            resources.ApplyResources(this.centroDeCostoToolStripMenuItem, "centroDeCostoToolStripMenuItem");
            this.centroDeCostoToolStripMenuItem.Click += new System.EventHandler(this.centroDeCostoToolStripMenuItem_Click);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            resources.ApplyResources(this.bancosToolStripMenuItem, "bancosToolStripMenuItem");
            this.bancosToolStripMenuItem.Click += new System.EventHandler(this.bancosToolStripMenuItem_Click);
            // 
            // rubrosToolStripMenuItem
            // 
            this.rubrosToolStripMenuItem.Name = "rubrosToolStripMenuItem";
            resources.ApplyResources(this.rubrosToolStripMenuItem, "rubrosToolStripMenuItem");
            this.rubrosToolStripMenuItem.Click += new System.EventHandler(this.rubrosToolStripMenuItem_Click);
            // 
            // periodosContablesToolStripMenuItem
            // 
            this.periodosContablesToolStripMenuItem.Name = "periodosContablesToolStripMenuItem";
            resources.ApplyResources(this.periodosContablesToolStripMenuItem, "periodosContablesToolStripMenuItem");
            this.periodosContablesToolStripMenuItem.Click += new System.EventHandler(this.periodosContablesToolStripMenuItem_Click);
            // 
            // impresorasToolStripMenuItem
            // 
            this.impresorasToolStripMenuItem.Name = "impresorasToolStripMenuItem";
            resources.ApplyResources(this.impresorasToolStripMenuItem, "impresorasToolStripMenuItem");
            this.impresorasToolStripMenuItem.Click += new System.EventHandler(this.impresorasToolStripMenuItem_Click);
            // 
            // maestroDeBodegasToolStripMenuItem
            // 
            this.maestroDeBodegasToolStripMenuItem.Name = "maestroDeBodegasToolStripMenuItem";
            resources.ApplyResources(this.maestroDeBodegasToolStripMenuItem, "maestroDeBodegasToolStripMenuItem");
            this.maestroDeBodegasToolStripMenuItem.Click += new System.EventHandler(this.maestroDeBodegasToolStripMenuItem_Click);
            // 
            // mestroDeListasDePrecioToolStripMenuItem
            // 
            this.mestroDeListasDePrecioToolStripMenuItem.Name = "mestroDeListasDePrecioToolStripMenuItem";
            resources.ApplyResources(this.mestroDeListasDePrecioToolStripMenuItem, "mestroDeListasDePrecioToolStripMenuItem");
            this.mestroDeListasDePrecioToolStripMenuItem.Click += new System.EventHandler(this.mestroDeListasDePrecioToolStripMenuItem_Click);
            // 
            // maestroDeCajasToolStripMenuItem
            // 
            this.maestroDeCajasToolStripMenuItem.Name = "maestroDeCajasToolStripMenuItem";
            resources.ApplyResources(this.maestroDeCajasToolStripMenuItem, "maestroDeCajasToolStripMenuItem");
            this.maestroDeCajasToolStripMenuItem.Click += new System.EventHandler(this.maestroDeCajasToolStripMenuItem_Click);
            // 
            // tipoDeUsuariosToolStripMenuItem
            // 
            this.tipoDeUsuariosToolStripMenuItem.Name = "tipoDeUsuariosToolStripMenuItem";
            resources.ApplyResources(this.tipoDeUsuariosToolStripMenuItem, "tipoDeUsuariosToolStripMenuItem");
            this.tipoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuariosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // respaldarInformaciónToolStripMenuItem
            // 
            this.respaldarInformaciónToolStripMenuItem.Name = "respaldarInformaciónToolStripMenuItem";
            resources.ApplyResources(this.respaldarInformaciónToolStripMenuItem, "respaldarInformaciónToolStripMenuItem");
            this.respaldarInformaciónToolStripMenuItem.Click += new System.EventHandler(this.respaldarInformaciónToolStripMenuItem_Click);
            // 
            // odepaToolStripMenuItem
            // 
            this.odepaToolStripMenuItem.Name = "odepaToolStripMenuItem";
            resources.ApplyResources(this.odepaToolStripMenuItem, "odepaToolStripMenuItem");
            this.odepaToolStripMenuItem.Click += new System.EventHandler(this.odepaToolStripMenuItem_Click);
            // 
            // respaldarInstalacionToolStripMenuItem
            // 
            this.respaldarInstalacionToolStripMenuItem.Name = "respaldarInstalacionToolStripMenuItem";
            resources.ApplyResources(this.respaldarInstalacionToolStripMenuItem, "respaldarInstalacionToolStripMenuItem");
            this.respaldarInstalacionToolStripMenuItem.Click += new System.EventHandler(this.respaldarInstalacionToolStripMenuItem_Click);
            // 
            // generadorDeCodigosDeBarraToolStripMenuItem
            // 
            this.generadorDeCodigosDeBarraToolStripMenuItem.Name = "generadorDeCodigosDeBarraToolStripMenuItem";
            resources.ApplyResources(this.generadorDeCodigosDeBarraToolStripMenuItem, "generadorDeCodigosDeBarraToolStripMenuItem");
            this.generadorDeCodigosDeBarraToolStripMenuItem.Click += new System.EventHandler(this.generadorDeCodigosDeBarraToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arriendosDeMaquinariaToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            resources.ApplyResources(this.extrasToolStripMenuItem, "extrasToolStripMenuItem");
            // 
            // arriendosDeMaquinariaToolStripMenuItem
            // 
            this.arriendosDeMaquinariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maquinariaToolStripMenuItem,
            this.estadosDeMaquinariaToolStripMenuItem});
            this.arriendosDeMaquinariaToolStripMenuItem.Name = "arriendosDeMaquinariaToolStripMenuItem";
            resources.ApplyResources(this.arriendosDeMaquinariaToolStripMenuItem, "arriendosDeMaquinariaToolStripMenuItem");
            // 
            // maquinariaToolStripMenuItem
            // 
            this.maquinariaToolStripMenuItem.Name = "maquinariaToolStripMenuItem";
            resources.ApplyResources(this.maquinariaToolStripMenuItem, "maquinariaToolStripMenuItem");
            this.maquinariaToolStripMenuItem.Click += new System.EventHandler(this.maquinariaToolStripMenuItem_Click);
            // 
            // estadosDeMaquinariaToolStripMenuItem
            // 
            this.estadosDeMaquinariaToolStripMenuItem.Name = "estadosDeMaquinariaToolStripMenuItem";
            resources.ApplyResources(this.estadosDeMaquinariaToolStripMenuItem, "estadosDeMaquinariaToolStripMenuItem");
            this.estadosDeMaquinariaToolStripMenuItem.Click += new System.EventHandler(this.estadosDeMaquinariaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            resources.ApplyResources(this.salirToolStripMenuItem1, "salirToolStripMenuItem1");
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // pnlVenta
            // 
            this.pnlVenta.BackColor = System.Drawing.Color.Transparent;
            this.pnlVenta.Controls.Add(this.btnBoletaFiscal);
            this.pnlVenta.Controls.Add(this.label1);
            this.pnlVenta.Controls.Add(this.btnPagosVentas);
            this.pnlVenta.Controls.Add(this.btnFactura);
            this.pnlVenta.Controls.Add(this.btnCliente);
            this.pnlVenta.Controls.Add(this.btnNotaVenta);
            this.pnlVenta.Controls.Add(this.btnGuia);
            this.pnlVenta.Controls.Add(this.btnTicket);
            this.pnlVenta.Controls.Add(this.btnCotizacion);
            this.pnlVenta.Controls.Add(this.btnBoleta);
            resources.ApplyResources(this.pnlVenta, "pnlVenta");
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVenta_Paint);
            // 
            // btnBoletaFiscal
            // 
            resources.ApplyResources(this.btnBoletaFiscal, "btnBoletaFiscal");
            this.btnBoletaFiscal.FlatAppearance.BorderSize = 0;
            this.btnBoletaFiscal.Name = "btnBoletaFiscal";
            this.btnBoletaFiscal.UseVisualStyleBackColor = true;
            this.btnBoletaFiscal.Click += new System.EventHandler(this.btnBoletaFiscal_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnPagosVentas
            // 
            resources.ApplyResources(this.btnPagosVentas, "btnPagosVentas");
            this.btnPagosVentas.FlatAppearance.BorderSize = 0;
            this.btnPagosVentas.Name = "btnPagosVentas";
            this.btnPagosVentas.UseVisualStyleBackColor = true;
            this.btnPagosVentas.Click += new System.EventHandler(this.btnPagosVentas_Click);
            // 
            // btnFactura
            // 
            resources.ApplyResources(this.btnFactura, "btnFactura");
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnCliente
            // 
            resources.ApplyResources(this.btnCliente, "btnCliente");
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnNotaVenta
            // 
            resources.ApplyResources(this.btnNotaVenta, "btnNotaVenta");
            this.btnNotaVenta.FlatAppearance.BorderSize = 0;
            this.btnNotaVenta.Name = "btnNotaVenta";
            this.btnNotaVenta.UseVisualStyleBackColor = true;
            this.btnNotaVenta.Click += new System.EventHandler(this.btnNotaVenta_Click);
            // 
            // btnGuia
            // 
            resources.ApplyResources(this.btnGuia, "btnGuia");
            this.btnGuia.FlatAppearance.BorderSize = 0;
            this.btnGuia.Name = "btnGuia";
            this.btnGuia.UseVisualStyleBackColor = true;
            this.btnGuia.Click += new System.EventHandler(this.btnGuia_Click);
            // 
            // btnTicket
            // 
            resources.ApplyResources(this.btnTicket, "btnTicket");
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnCotizacion
            // 
            resources.ApplyResources(this.btnCotizacion, "btnCotizacion");
            this.btnCotizacion.FlatAppearance.BorderSize = 0;
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.UseVisualStyleBackColor = true;
            this.btnCotizacion.Click += new System.EventHandler(this.btnCotizacion_Click);
            // 
            // btnBoleta
            // 
            resources.ApplyResources(this.btnBoleta, "btnBoleta");
            this.btnBoleta.FlatAppearance.BorderSize = 0;
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.UseVisualStyleBackColor = true;
            this.btnBoleta.Click += new System.EventHandler(this.btnBoleta_Click);
            // 
            // pnlCompra
            // 
            this.pnlCompra.BackColor = System.Drawing.Color.Transparent;
            this.pnlCompra.Controls.Add(this.label4);
            this.pnlCompra.Controls.Add(this.btnPagoCompras);
            this.pnlCompra.Controls.Add(this.btnOrdenCompra);
            this.pnlCompra.Controls.Add(this.btnProveedor);
            this.pnlCompra.Controls.Add(this.btnIngresoCompra);
            resources.ApplyResources(this.pnlCompra, "pnlCompra");
            this.pnlCompra.Name = "pnlCompra";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnPagoCompras
            // 
            resources.ApplyResources(this.btnPagoCompras, "btnPagoCompras");
            this.btnPagoCompras.FlatAppearance.BorderSize = 0;
            this.btnPagoCompras.Name = "btnPagoCompras";
            this.btnPagoCompras.UseVisualStyleBackColor = true;
            this.btnPagoCompras.Click += new System.EventHandler(this.btnPagoCompras_Click);
            // 
            // btnOrdenCompra
            // 
            resources.ApplyResources(this.btnOrdenCompra, "btnOrdenCompra");
            this.btnOrdenCompra.FlatAppearance.BorderSize = 0;
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.UseVisualStyleBackColor = true;
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnOrdenCompra_Click);
            // 
            // btnProveedor
            // 
            resources.ApplyResources(this.btnProveedor, "btnProveedor");
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnIngresoCompra
            // 
            resources.ApplyResources(this.btnIngresoCompra, "btnIngresoCompra");
            this.btnIngresoCompra.FlatAppearance.BorderSize = 0;
            this.btnIngresoCompra.Name = "btnIngresoCompra";
            this.btnIngresoCompra.UseVisualStyleBackColor = true;
            this.btnIngresoCompra.Click += new System.EventHandler(this.btnIngresoCompra_Click);
            // 
            // pnlInventario
            // 
            this.pnlInventario.BackColor = System.Drawing.Color.Transparent;
            this.pnlInventario.Controls.Add(this.label3);
            this.pnlInventario.Controls.Add(this.btnCategorias);
            this.pnlInventario.Controls.Add(this.btnUnidMedidas);
            this.pnlInventario.Controls.Add(this.btnProducto);
            resources.ApplyResources(this.pnlInventario, "pnlInventario");
            this.pnlInventario.Name = "pnlInventario";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnCategorias
            // 
            resources.ApplyResources(this.btnCategorias, "btnCategorias");
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnUnidMedidas
            // 
            resources.ApplyResources(this.btnUnidMedidas, "btnUnidMedidas");
            this.btnUnidMedidas.FlatAppearance.BorderSize = 0;
            this.btnUnidMedidas.Name = "btnUnidMedidas";
            this.btnUnidMedidas.UseVisualStyleBackColor = true;
            this.btnUnidMedidas.Click += new System.EventHandler(this.btnUnidMedidas_Click);
            // 
            // btnProducto
            // 
            resources.ApplyResources(this.btnProducto, "btnProducto");
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpciones.Controls.Add(this.label2);
            this.pnlOpciones.Controls.Add(this.btnUsuario);
            this.pnlOpciones.Controls.Add(this.btnOpciones);
            this.pnlOpciones.Controls.Add(this.btnTipoUsuario);
            this.pnlOpciones.Controls.Add(this.btnImpresoras);
            resources.ApplyResources(this.pnlOpciones, "pnlOpciones");
            this.pnlOpciones.Name = "pnlOpciones";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnUsuario
            // 
            resources.ApplyResources(this.btnUsuario, "btnUsuario");
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnOpciones
            // 
            resources.ApplyResources(this.btnOpciones, "btnOpciones");
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // btnTipoUsuario
            // 
            resources.ApplyResources(this.btnTipoUsuario, "btnTipoUsuario");
            this.btnTipoUsuario.FlatAppearance.BorderSize = 0;
            this.btnTipoUsuario.Name = "btnTipoUsuario";
            this.btnTipoUsuario.UseVisualStyleBackColor = true;
            this.btnTipoUsuario.Click += new System.EventHandler(this.btnTipoUsuario_Click);
            // 
            // btnImpresoras
            // 
            resources.ApplyResources(this.btnImpresoras, "btnImpresoras");
            this.btnImpresoras.FlatAppearance.BorderSize = 0;
            this.btnImpresoras.Name = "btnImpresoras";
            this.btnImpresoras.UseVisualStyleBackColor = true;
            this.btnImpresoras.Click += new System.EventHandler(this.btnImpresoras_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.chbFrigo);
            this.panel1.Controls.Add(this.lblDocumentosElectronicosSinEnviar);
            this.panel1.Controls.Add(this.lblConexion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTipoUsuario);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblCaja);
            this.panel1.Controls.Add(this.lblBodega);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chbFrigo
            // 
            resources.ApplyResources(this.chbFrigo, "chbFrigo");
            this.chbFrigo.Name = "chbFrigo";
            this.chbFrigo.UseVisualStyleBackColor = true;
            this.chbFrigo.CheckedChanged += new System.EventHandler(this.chbFrigo_CheckedChanged);
            // 
            // lblDocumentosElectronicosSinEnviar
            // 
            resources.ApplyResources(this.lblDocumentosElectronicosSinEnviar, "lblDocumentosElectronicosSinEnviar");
            this.lblDocumentosElectronicosSinEnviar.ForeColor = System.Drawing.Color.Gray;
            this.lblDocumentosElectronicosSinEnviar.Name = "lblDocumentosElectronicosSinEnviar";
            // 
            // lblConexion
            // 
            resources.ApplyResources(this.lblConexion, "lblConexion");
            this.lblConexion.ForeColor = System.Drawing.Color.Gray;
            this.lblConexion.Name = "lblConexion";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Name = "label9";
            // 
            // lblEmpresa
            // 
            resources.ApplyResources(this.lblEmpresa, "lblEmpresa");
            this.lblEmpresa.Name = "lblEmpresa";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblTipoUsuario
            // 
            resources.ApplyResources(this.lblTipoUsuario, "lblTipoUsuario");
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblCaja
            // 
            resources.ApplyResources(this.lblCaja, "lblCaja");
            this.lblCaja.ForeColor = System.Drawing.Color.Black;
            this.lblCaja.Name = "lblCaja";
            // 
            // lblBodega
            // 
            resources.ApplyResources(this.lblBodega, "lblBodega");
            this.lblBodega.ForeColor = System.Drawing.Color.Black;
            this.lblBodega.Name = "lblBodega";
            // 
            // btnPruebas
            // 
            resources.ApplyResources(this.btnPruebas, "btnPruebas");
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 180000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFiscal
            // 
            resources.ApplyResources(this.lblFiscal, "lblFiscal");
            this.lblFiscal.BackColor = System.Drawing.Color.Transparent;
            this.lblFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFiscal.ForeColor = System.Drawing.Color.Gray;
            this.lblFiscal.Name = "lblFiscal";
            // 
            // pnlVentasElectronicas
            // 
            this.pnlVentasElectronicas.BackColor = System.Drawing.Color.Transparent;
            this.pnlVentasElectronicas.Controls.Add(this.label10);
            this.pnlVentasElectronicas.Controls.Add(this.btnEBoleta);
            this.pnlVentasElectronicas.Controls.Add(this.btnEFacturaExenta);
            this.pnlVentasElectronicas.Controls.Add(this.btnEnotaDebito);
            this.pnlVentasElectronicas.Controls.Add(this.btnENotaCredito);
            this.pnlVentasElectronicas.Controls.Add(this.btnEGuias);
            this.pnlVentasElectronicas.Controls.Add(this.btnCaf);
            this.pnlVentasElectronicas.Controls.Add(this.btnEFactura);
            this.pnlVentasElectronicas.Controls.Add(this.btnEnvios);
            resources.ApplyResources(this.pnlVentasElectronicas, "pnlVentasElectronicas");
            this.pnlVentasElectronicas.Name = "pnlVentasElectronicas";
            this.pnlVentasElectronicas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVentasElectronicas_Paint);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btnEBoleta
            // 
            resources.ApplyResources(this.btnEBoleta, "btnEBoleta");
            this.btnEBoleta.FlatAppearance.BorderSize = 0;
            this.btnEBoleta.Name = "btnEBoleta";
            this.btnEBoleta.UseVisualStyleBackColor = true;
            this.btnEBoleta.Click += new System.EventHandler(this.btnEBoleta_Click);
            // 
            // btnEFacturaExenta
            // 
            resources.ApplyResources(this.btnEFacturaExenta, "btnEFacturaExenta");
            this.btnEFacturaExenta.FlatAppearance.BorderSize = 0;
            this.btnEFacturaExenta.Name = "btnEFacturaExenta";
            this.btnEFacturaExenta.UseVisualStyleBackColor = true;
            this.btnEFacturaExenta.Click += new System.EventHandler(this.btnEFacturaExenta_Click);
            // 
            // btnEnotaDebito
            // 
            resources.ApplyResources(this.btnEnotaDebito, "btnEnotaDebito");
            this.btnEnotaDebito.FlatAppearance.BorderSize = 0;
            this.btnEnotaDebito.Name = "btnEnotaDebito";
            this.btnEnotaDebito.UseVisualStyleBackColor = true;
            this.btnEnotaDebito.Click += new System.EventHandler(this.btnEnotaDebito_Click);
            // 
            // btnENotaCredito
            // 
            resources.ApplyResources(this.btnENotaCredito, "btnENotaCredito");
            this.btnENotaCredito.FlatAppearance.BorderSize = 0;
            this.btnENotaCredito.Name = "btnENotaCredito";
            this.btnENotaCredito.UseVisualStyleBackColor = true;
            this.btnENotaCredito.Click += new System.EventHandler(this.btnENotaCredito_Click);
            // 
            // btnEGuias
            // 
            resources.ApplyResources(this.btnEGuias, "btnEGuias");
            this.btnEGuias.FlatAppearance.BorderSize = 0;
            this.btnEGuias.Name = "btnEGuias";
            this.btnEGuias.UseVisualStyleBackColor = true;
            this.btnEGuias.Click += new System.EventHandler(this.btnEGuias_Click);
            // 
            // btnCaf
            // 
            resources.ApplyResources(this.btnCaf, "btnCaf");
            this.btnCaf.FlatAppearance.BorderSize = 0;
            this.btnCaf.Name = "btnCaf";
            this.btnCaf.UseVisualStyleBackColor = true;
            this.btnCaf.Click += new System.EventHandler(this.btnCaf_Click);
            // 
            // btnEFactura
            // 
            resources.ApplyResources(this.btnEFactura, "btnEFactura");
            this.btnEFactura.FlatAppearance.BorderSize = 0;
            this.btnEFactura.Name = "btnEFactura";
            this.btnEFactura.UseVisualStyleBackColor = true;
            this.btnEFactura.Click += new System.EventHandler(this.btnEFactura_Click);
            // 
            // btnEnvios
            // 
            resources.ApplyResources(this.btnEnvios, "btnEnvios");
            this.btnEnvios.FlatAppearance.BorderSize = 0;
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.UseVisualStyleBackColor = true;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // btnVentaElectronica
            // 
            this.btnVentaElectronica.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnVentaElectronica, "btnVentaElectronica");
            this.btnVentaElectronica.FlatAppearance.BorderSize = 0;
            this.btnVentaElectronica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVentaElectronica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVentaElectronica.Name = "btnVentaElectronica";
            this.btnVentaElectronica.UseVisualStyleBackColor = false;
            this.btnVentaElectronica.Click += new System.EventHandler(this.btnVentaElectronica_Click);
            // 
            // btnOpcion
            // 
            this.btnOpcion.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnOpcion, "btnOpcion");
            this.btnOpcion.FlatAppearance.BorderSize = 0;
            this.btnOpcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOpcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOpcion.Name = "btnOpcion";
            this.btnOpcion.UseVisualStyleBackColor = false;
            this.btnOpcion.Click += new System.EventHandler(this.btnOpcion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnInventario, "btnInventario");
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnComprar, "btnComprar");
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnVender, "btnVender");
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVender.Name = "btnVender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // frmMenuPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblFiscal);
            this.Controls.Add(this.pnlVentasElectronicas);
            this.Controls.Add(this.btnVentaElectronica);
            this.Controls.Add(this.pnlVenta);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlCompra);
            this.Controls.Add(this.pnlInventario);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.btnOpcion);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Name = "frmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.pnlCompra.ResumeLayout(false);
            this.pnlCompra.PerformLayout();
            this.pnlInventario.ResumeLayout(false);
            this.pnlInventario.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlVentasElectronicas.ResumeLayout(false);
            this.pnlVentasElectronicas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void odepaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
        new frmOdepa().Show();
    }

    private void respaldarInstalacionToolStripMenuItem_Click(object sender, EventArgs e)
    {

        if (MessageBox.Show("Esta Seguro De Crear Respaldo de Su instalacion", "Respaldo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            System.Diagnostics.Process.Start(@"C:\aptusoft\archivos\backup.bat");
        }
        else
        {

        }
    }

    private void valorizacionDeExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //if (this.buscaPermisoInforme("INVENTARIO027"))
            new frmLanzaInformeInventario("Valorizacion De Existencia", "INVENTARIO027").Show();
        //else
        //    this.alerta();
    }

    private void arriendosDeMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void toolStripMenuItem27_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Listado de Ticket, Según Fecha", "pos001").Show();
    }

    private void toolStripMenuItem28_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Listado de Ticket por Cliente, Según Fecha", "pos002").Show();
    }

    private void toolStripMenuItem29_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Listado de Ticket por Vendedor, Según Fecha", "pos003").Show();
    }

    private void toolStripMenuItem30_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Listado de Ticket por Centro de Costo, Según Fecha", "pos004").Show();
    }

    private void toolStripMenuItem31_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Listado de Ticket Anuladas, Según Fecha", "pos005").Show();
    }

    private void toolStripMenuItem32_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Ticket, Según Fecha", "pos006").Show();
    }

    private void toolStripMenuItem33_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Resumen de Articulos Vendidos con Ticket, Según Fecha", "pos007").Show();

    }

    private void toolStripMenuItem34_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Listado de Articulos Vendidos con Ticket y su Rentabilidad, Según Fecha", "pos008").Show();
    }

    private void generadorDeCodigosDeBarraToolStripMenuItem_Click(object sender, EventArgs e)
    {

        frmCodeBar frmcode = new frmCodeBar();
        frmcode.ShowDialog();
    }

    private void ingresoBoletasManualesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmInger ingreso = new frmInger();
            ingreso.ShowDialog();
    }

    private void pnlVentasElectronicas_Paint(object sender, PaintEventArgs e)
    {

    }

    private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }

    private void ingresoBoletasManualesToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        frmInger ingresos = new frmInger();
        ingresos.ShowDialog();
    }

    private void ingresosManualesToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void listadoDeBoletasIngresadasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new frmLanzadorInformesVenta("Listado de Boletas Manuales Ordenada Por Fecha", "ingresomanual1").Show();
    }

    private void informesToolStripMenuItem28_Click(object sender, EventArgs e)
    {

    }

    private void maquinariaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Application.OpenForms["frmMaquinaria"] == null)
        {
            new frmMaquinaria().Show();
        }
        else
        {
            Application.OpenForms["frmMaquinaria"].BringToFront();
        }
    }

    private void estadosDeMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Application.OpenForms["frmEstado"] == null)
        {
            new frmEstado().Show();
        }
        else
        {
            Application.OpenForms["frmEstado"].BringToFront();
        }
    }

    private void chbFrigo_CheckedChanged(object sender, EventArgs e)
    {
        if (chbFrigo.Checked)
        {
            _esFrigo = true;
        }
        else
        {
            _esFrigo = false;
        }
    }

    private void envíoXMLAClienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }
  }
}
