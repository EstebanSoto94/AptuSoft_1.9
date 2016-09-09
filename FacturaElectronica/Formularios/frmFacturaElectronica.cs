 
// Type: Aptusoft.FacturaElectronica.Formularios.frmFacturaElectronica
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Aptusoft;
using Aptusoft.DtsReportesTableAdapters;
using Aptusoft.FacturaElectronica;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.CreaXml;
using Aptusoft.FacturaElectronica.Clases.PDF417;
using Aptusoft.Lotes;
using Aptusoft.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net.Mail;
using System.Net.Mime;



namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmFacturaElectronica : Form
  {
      Venta venta = new Venta();
       private bool limpiar = true;
      #region
      private IContainer components = (IContainer) null;
    private List<DatosVentaVO> lista = new List<DatosVentaVO>();
    private List<ProductoAuxiliar> listaAuxiliar = new List<ProductoAuxiliar>();
    private bool _modBodega = false;
    private int noVender = 0;
    private string _timbre = "";
    private bool hayTicket = false;
    private bool hayGuia = false;
    private bool hayCotizacion = false;
    private bool hayNotaVenta = false;
    private bool hayOT = false;
    private bool hayNotaVentaMasiva = false;
    private Decimal stock = new Decimal(0);
    private int idImpuesto = 0;
    private Decimal netoLinea = new Decimal(0);
    private Decimal valorCompra = new Decimal(0);
    private List<VendedorVO> listaVendedores = new List<VendedorVO>();
    private List<MedioPagoVO> listaMediosPago = new List<MedioPagoVO>();
    private List<ImpuestoVO> listaImpuestos = new List<ImpuestoVO>();
    private List<CentroCostoVO> listaCentroCosto = new List<CentroCostoVO>();
    private OpcionesDocumentosVO odVO = new OpcionesDocumentosVO();
    private Decimal ivaInicio = new Decimal(0);
    private bool verificaCreditoActivo = false;
    private bool impideVentaSinCredito = false;
    private bool impideVenta = false;
    private bool buscaOT = false;
    private List<ReferenicaVO> listaReferencias = new List<ReferenicaVO>();
    private bool esExento = false;
    private string _rutaElectronica = "";
    private string _permisoMedioPago = "";
    private bool _permisoPemitirMedioPago = false;
    private string _opcionBusquedaRazonSocial = "1";
    public List<LoteVO> _listaLote = new List<LoteVO>();
    public List<LoteVO> _listaLoteAntigua = new List<LoteVO>();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private bool _anula = false;
    private bool _descuento = false;
    private bool _cambioPrecio = false;
    private int _caja = 0;
    private int _bodega = 0;
    private int _listaPrecio = 0;
    private List<Venta> listaGuias = new List<Venta>();
    private Venta veOBFactura = new Venta();
    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem;
    private Label label17;
    private Label label19;
    private Label label15;
    private Label label14;
    private TextBox txtCantidad;
    private Label label13;
    private TextBox txtCodigo;
    private Label label20;
    private TextBox txtDescripcion;
    private TextBox txtTotalLinea;
    private Label label21;
    private TextBox txtDiasPlazo;
    private TextBox txtContacto;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private TextBox txtFax;
    private TextBox txtFono;
    private TextBox txtGiro;
    private TextBox txtCiudad;
    private TextBox txtComuna;
    private TextBox txtDireccion;
    private Label label5;
    private Label label4;
    private TextBox txtRazonSocial;
    private TextBox txtDigito;
    private TextBox txtRut;
    private TextBox txtPrecio;
    private TextBox txtDescuento;
    private CheckBox chkCantidadFija;
    private Button btnAgregar;
    private Button btnLimpiaDetalle;
    private Label label16;
    private TextBox txtOrdenCompra;
    private Label lblFolio;
    private TextBox txtNumeroDocumento;
    private TextBox txtSubTotal;
    private TextBox txtTotalGeneral;
    private TextBox txtIva;
    private TextBox txtNeto;
    private TextBox txtTotalDescuento;
    private TextBox txtPorcDescuentoTotal;
    private Label label26;
    private Label label25;
    private Label label24;
    private Label label23;
    private Label label22;
    private DataGridView dgvDatosVenta;
    private TextBox txtPorIva;
    private Label label27;
    private ComboBox cmbVendedor;
    private GroupBox gbZonaOtros;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private ComboBox cmbListaPrecio;
    private Panel panelZonaDetalle;
    private Button btnBuscaCliente;
    private DataGridView dgvBuscaCliente;
    private Panel pnlBuscaClienteDes;
    private Label label18;
    private ComboBox cmbMedioPago;
    private ComboBox cmbCentroCosto;
    private Label label30;
    private TextBox txtPorcDescuentoLinea;
    private Label label31;
    private TextBox txtLinea;
    private Button btnModificaLinea;
    private Button btnLimpiaLineaDetalle;
    private TextBox txtSubTotalLinea;
    private TextBox txtTipoDescuento;
    private ToolStripMenuItem buscarProductosTeclaF4ToolStripMenuItem;
    private Panel panelFolio;
    private Button btnBuscaFolio;
    private TextBox txtFolioBuscar;
    private Label label32;
    private Button btnCerrarPanelFolio;
    private ToolStripMenuItem buscarFacturaTeclaF6ToolStripMenuItem;
    private Button btnAnular;
    private Label lblEstadoDocumento;
    private ToolStripMenuItem guardarFacturaTeclaF2ToolStripMenuItem;
    private Button btnImprime;
    private Label label3;
    private ToolStripMenuItem cambiarNumeroDeFolioToolStripMenuItem;
    private Label label33;
    private TextBox txtTicket;
    private GroupBox gbZonaTicket;
    private ToolStripMenuItem importarToolStripMenuItem;
    private ToolStripMenuItem guiasToolStripMenuItem;
    private ToolStripMenuItem cotizaciónToolStripMenuItem;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label label35;
    private Label label34;
    private TextBox txtObservaciones;
    private TextBox txtGuias;
    private Label label36;
    private Button btnBuscaCotizacion;
    private TextBox txtFolioCotizacion;
    private Button btnSalirBuscaCoti;
    private Panel pnlCotizacionBuscar;
    private ToolStripMenuItem calculaVueltoTeclaF5ToolStripMenuItem;
    private ToolStripMenuItem notaDeVentaToolStripMenuItem;
    private Panel panelNotaVenta;
    private Button btnBuscaNotaventa;
    private Button btnCierraNota;
    private TextBox txtFolioNotaVenta;
    private Label label37;
    private Button btnVerificaCredito;
    private TextBox txtCreditoDisponible;
    private Label label38;
    private ToolStripMenuItem ordenDeTrabajoToolStripMenuItem;
    private TabPage tabPage3;
    private ComboBox cmbTipoDocumentoReferencia;
    private Label label43;
    private Label label42;
    private Label label41;
    private Label label40;
    private Label label39;
    private DataGridView dgvReferencias;
    private TextBox txtRazonReferencia;
    private ComboBox cmbTipoAccion;
    private DateTimePicker dtpFechaReferencia;
    private TextBox txtFolioDocumentoReferencia;
    private Button btnGuardaReferencia;
    private DataGridViewTextBoxColumn IdReferencia;
    private DataGridViewTextBoxColumn IdDocumento;
    private DataGridViewTextBoxColumn FolioDocumento;
    private DataGridViewTextBoxColumn TipoDocumento;
    private DataGridViewTextBoxColumn TipoDocumentoNombre;
    private DataGridViewTextBoxColumn FolioDocumentoReferencia;
    private DataGridViewTextBoxColumn FechaDocumentoReferencia;
    private DataGridViewTextBoxColumn TipoAccion;
    private DataGridViewTextBoxColumn TipoAccionNombre;
    private DataGridViewTextBoxColumn RazonReferencia;
    private DataGridViewButtonColumn EliminaReferencia;
    private Button button1;
    private TextBox txtTotalExento;
    private Label label44;
    private Button button2;
    private TabPage tabPage4;
    private GroupBox groupBox1;
    private TextBox txtTotalImp5;
    private TextBox txtTotalImp3;
    private TextBox txtTotalImp4;
    private TextBox txtPorImp5;
    private TextBox txtPorImp3;
    private TextBox txtTotalImp2;
    private TextBox txtPorImp4;
    private TextBox txtPorImp2;
    private TextBox txtTotalImp1;
    private TextBox txtPorImp1;
    private Label lblImp5;
    private Label lblImp4;
    private Label lblImp3;
    private Label lblImp2;
    private Label lblImp1;
    private Panel panelZonaCliente;
    private Label label29;
    private Label label28;
    private ToolTip toolTip1;
    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private Panel panel4;
    private Button btnComprobarFolio;
    private Label label1;
    private Label label2;
    private DateTimePicker dtpEmision;
    private DateTimePicker dtpVencimiento;
    private GroupBox gbZonaFechas;
    private Button btnCreaPdf;
    private CheckBox chkHistoricoVentas;
    private Label lblCodImp4;
    private Label lblCodImp3;
    private Label lblCodImp2;
    private Label lblCodImp1;
    private TicketTableAdapter ticketTableAdapter1;
    private ToolStripMenuItem notaDeVentaToolStripMenuItem1;
    private ToolStripMenuItem facturacionMasivaDeNotasDeVentasToolStripMenuItem;
    private TicketTableAdapter ticketTableAdapter2;
    private frmFacturaElectronica intance;
    private int codigoCliente;
    private int idFactura;
    private int idTicket;
    private string alertaStock;
    private string numeroLineas;
    private string envioAutomaticoSii;
    private string decimalesValoresVenta;
    private ComboBox cmbBodega;
    private TicketTableAdapter ticketTableAdapter3;
    private TicketTableAdapter ticketTableAdapter4;
    private Label lblCodImp5;
    private string impideVentasSinStock;
    private Button button3;
    private Button btnControlPago;
    private Button btnEnviar;
    private string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      #endregion
    public frmFacturaElectronica()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.cargaOpcionesDocumentosInicio();
      this.CargaRuta();
      this.iniciaFormulario();
      this.iniciaVenta();
      this.intance = this;
      this.dgvReferencias.AutoGenerateColumns = false;
    }

    public frmFacturaElectronica(string folio)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.cargaOpcionesDocumentosInicio();
      this.CargaRuta();
      this.iniciaFormulario();
      this.iniciaVenta();
      this.intance = this;
      this.dgvReferencias.AutoGenerateColumns = false;
      this.txtFolioBuscar.Text = folio;
      this.buscaFacturaFolio();
    }

    public frmFacturaElectronica(string des, Decimal val)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.cargaOpcionesDocumentosInicio();
      this.CargaRuta();
      this.iniciaFormulario();
      this.iniciaVenta();
      this.intance = this;
      this.dgvReferencias.AutoGenerateColumns = false;
      this.agregaDevolucionGrilla(des, val);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosTeclaF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaTeclaF6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarFacturaTeclaF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNumeroDeFolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculaVueltoTeclaF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeVentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionMasivaDeNotasDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTotalLinea = new System.Windows.Forms.TextBox();
            this.txtCreditoDisponible = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDiasPlazo = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtFono = new System.Windows.Forms.TextBox();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtComuna = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.chkCantidadFija = new System.Windows.Forms.CheckBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalExento = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstadoDocumento = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtPorIva = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotalGeneral = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtTotalDescuento = new System.Windows.Forms.TextBox();
            this.txtPorcDescuentoTotal = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvDatosVenta = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.gbZonaOtros = new System.Windows.Forms.GroupBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.cmbCentroCosto = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.panelZonaDetalle = new System.Windows.Forms.Panel();
            this.txtPorcDescuentoLinea = new System.Windows.Forms.TextBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnLimpiaLineaDetalle = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.txtTipoDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotalLinea = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.dgvBuscaCliente = new System.Windows.Forms.DataGridView();
            this.pnlBuscaClienteDes = new System.Windows.Forms.Panel();
            this.panelFolio = new System.Windows.Forms.Panel();
            this.btnCerrarPanelFolio = new System.Windows.Forms.Button();
            this.btnBuscaFolio = new System.Windows.Forms.Button();
            this.txtFolioBuscar = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.gbZonaTicket = new System.Windows.Forms.GroupBox();
            this.chkHistoricoVentas = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprime = new System.Windows.Forms.Button();
            this.btnControlPago = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodImp5 = new System.Windows.Forms.Label();
            this.lblCodImp4 = new System.Windows.Forms.Label();
            this.lblCodImp3 = new System.Windows.Forms.Label();
            this.lblCodImp2 = new System.Windows.Forms.Label();
            this.lblCodImp1 = new System.Windows.Forms.Label();
            this.txtTotalImp5 = new System.Windows.Forms.TextBox();
            this.txtTotalImp3 = new System.Windows.Forms.TextBox();
            this.txtTotalImp4 = new System.Windows.Forms.TextBox();
            this.txtPorImp5 = new System.Windows.Forms.TextBox();
            this.txtPorImp3 = new System.Windows.Forms.TextBox();
            this.txtTotalImp2 = new System.Windows.Forms.TextBox();
            this.txtPorImp4 = new System.Windows.Forms.TextBox();
            this.txtPorImp2 = new System.Windows.Forms.TextBox();
            this.txtTotalImp1 = new System.Windows.Forms.TextBox();
            this.txtPorImp1 = new System.Windows.Forms.TextBox();
            this.lblImp5 = new System.Windows.Forms.Label();
            this.lblImp4 = new System.Windows.Forms.Label();
            this.lblImp3 = new System.Windows.Forms.Label();
            this.lblImp2 = new System.Windows.Forms.Label();
            this.lblImp1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtGuias = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGuardaReferencia = new System.Windows.Forms.Button();
            this.txtRazonReferencia = new System.Windows.Forms.TextBox();
            this.cmbTipoAccion = new System.Windows.Forms.ComboBox();
            this.dtpFechaReferencia = new System.Windows.Forms.DateTimePicker();
            this.txtFolioDocumentoReferencia = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumentoReferencia = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.dgvReferencias = new System.Windows.Forms.DataGridView();
            this.IdReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolioDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumentoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolioDocumentoReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDocumentoReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAccionNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminaReferencia = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscaCotizacion = new System.Windows.Forms.Button();
            this.txtFolioCotizacion = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btnSalirBuscaCoti = new System.Windows.Forms.Button();
            this.pnlCotizacionBuscar = new System.Windows.Forms.Panel();
            this.panelNotaVenta = new System.Windows.Forms.Panel();
            this.btnCierraNota = new System.Windows.Forms.Button();
            this.btnBuscaNotaventa = new System.Windows.Forms.Button();
            this.txtFolioNotaVenta = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btnVerificaCredito = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelZonaCliente = new System.Windows.Forms.Panel();
            this.btnModificaLinea = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiaDetalle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnComprobarFolio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.gbZonaFechas = new System.Windows.Forms.GroupBox();
            this.btnCreaPdf = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            this.gbZonaOtros.SuspendLayout();
            this.panelZonaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).BeginInit();
            this.pnlBuscaClienteDes.SuspendLayout();
            this.panelFolio.SuspendLayout();
            this.gbZonaTicket.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencias)).BeginInit();
            this.pnlCotizacionBuscar.SuspendLayout();
            this.panelNotaVenta.SuspendLayout();
            this.panelZonaCliente.SuspendLayout();
            this.gbZonaFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProductosTeclaF4ToolStripMenuItem,
            this.buscarFacturaTeclaF6ToolStripMenuItem,
            this.guardarFacturaTeclaF2ToolStripMenuItem,
            this.cambiarNumeroDeFolioToolStripMenuItem,
            this.calculaVueltoTeclaF5ToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarProductosTeclaF4ToolStripMenuItem
            // 
            this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
            this.buscarProductosTeclaF4ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
            this.buscarProductosTeclaF4ToolStripMenuItem.Click += new System.EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
            // 
            // buscarFacturaTeclaF6ToolStripMenuItem
            // 
            this.buscarFacturaTeclaF6ToolStripMenuItem.Name = "buscarFacturaTeclaF6ToolStripMenuItem";
            this.buscarFacturaTeclaF6ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarFacturaTeclaF6ToolStripMenuItem.Text = "Buscar Factura - tecla [F6]";
            this.buscarFacturaTeclaF6ToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturaTeclaF6ToolStripMenuItem_Click);
            // 
            // guardarFacturaTeclaF2ToolStripMenuItem
            // 
            this.guardarFacturaTeclaF2ToolStripMenuItem.Name = "guardarFacturaTeclaF2ToolStripMenuItem";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.guardarFacturaTeclaF2ToolStripMenuItem.Text = "Guardar Factura - tecla[F2]";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Click += new System.EventHandler(this.guardarFacturaTeclaF2ToolStripMenuItem_Click);
            // 
            // cambiarNumeroDeFolioToolStripMenuItem
            // 
            this.cambiarNumeroDeFolioToolStripMenuItem.Name = "cambiarNumeroDeFolioToolStripMenuItem";
            this.cambiarNumeroDeFolioToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cambiarNumeroDeFolioToolStripMenuItem.Text = "Cambiar Numero de Folio";
            this.cambiarNumeroDeFolioToolStripMenuItem.Click += new System.EventHandler(this.cambiarNumeroDeFolioToolStripMenuItem_Click);
            // 
            // calculaVueltoTeclaF5ToolStripMenuItem
            // 
            this.calculaVueltoTeclaF5ToolStripMenuItem.Name = "calculaVueltoTeclaF5ToolStripMenuItem";
            this.calculaVueltoTeclaF5ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.calculaVueltoTeclaF5ToolStripMenuItem.Text = "Calcula Vuelto - tecla [F5]";
            this.calculaVueltoTeclaF5ToolStripMenuItem.Click += new System.EventHandler(this.calculaVueltoTeclaF5ToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiasToolStripMenuItem,
            this.cotizaciónToolStripMenuItem,
            this.notaDeVentaToolStripMenuItem,
            this.ordenDeTrabajoToolStripMenuItem});
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // guiasToolStripMenuItem
            // 
            this.guiasToolStripMenuItem.Name = "guiasToolStripMenuItem";
            this.guiasToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.guiasToolStripMenuItem.Text = "Guias";
            this.guiasToolStripMenuItem.Click += new System.EventHandler(this.guiasToolStripMenuItem_Click);
            // 
            // cotizaciónToolStripMenuItem
            // 
            this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
            this.cotizaciónToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cotizaciónToolStripMenuItem.Text = "Cotización";
            this.cotizaciónToolStripMenuItem.Click += new System.EventHandler(this.cotizaciónToolStripMenuItem_Click);
            // 
            // notaDeVentaToolStripMenuItem
            // 
            this.notaDeVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaDeVentaToolStripMenuItem1,
            this.facturacionMasivaDeNotasDeVentasToolStripMenuItem});
            this.notaDeVentaToolStripMenuItem.Name = "notaDeVentaToolStripMenuItem";
            this.notaDeVentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.notaDeVentaToolStripMenuItem.Text = "Nota de Venta";
            this.notaDeVentaToolStripMenuItem.Click += new System.EventHandler(this.notaDeVentaToolStripMenuItem_Click);
            // 
            // notaDeVentaToolStripMenuItem1
            // 
            this.notaDeVentaToolStripMenuItem1.Name = "notaDeVentaToolStripMenuItem1";
            this.notaDeVentaToolStripMenuItem1.Size = new System.Drawing.Size(280, 22);
            this.notaDeVentaToolStripMenuItem1.Text = "Nota de venta";
            this.notaDeVentaToolStripMenuItem1.Click += new System.EventHandler(this.notaDeVentaToolStripMenuItem1_Click);
            // 
            // facturacionMasivaDeNotasDeVentasToolStripMenuItem
            // 
            this.facturacionMasivaDeNotasDeVentasToolStripMenuItem.Name = "facturacionMasivaDeNotasDeVentasToolStripMenuItem";
            this.facturacionMasivaDeNotasDeVentasToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.facturacionMasivaDeNotasDeVentasToolStripMenuItem.Text = "Facturacion Masiva de Notas de Ventas";
            this.facturacionMasivaDeNotasDeVentasToolStripMenuItem.Click += new System.EventHandler(this.facturacionMasivaDeNotasDeVentasToolStripMenuItem_Click);
            // 
            // ordenDeTrabajoToolStripMenuItem
            // 
            this.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem";
            this.ordenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ordenDeTrabajoToolStripMenuItem.Text = "Orden de Trabajo";
            this.ordenDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.ordenDeTrabajoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(643, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Cant.";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(733, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 23);
            this.label19.TabIndex = 6;
            this.label19.Text = "$ Desc.";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(580, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Precio";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(258, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(320, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Descripcion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.Location = new System.Drawing.Point(643, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(38, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(171, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Location = new System.Drawing.Point(171, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(796, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 23);
            this.label20.TabIndex = 7;
            this.label20.Text = "Total";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.Location = new System.Drawing.Point(258, 19);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(320, 20);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // txtTotalLinea
            // 
            this.txtTotalLinea.BackColor = System.Drawing.Color.White;
            this.txtTotalLinea.Enabled = false;
            this.txtTotalLinea.Location = new System.Drawing.Point(796, 19);
            this.txtTotalLinea.Name = "txtTotalLinea";
            this.txtTotalLinea.Size = new System.Drawing.Size(69, 20);
            this.txtTotalLinea.TabIndex = 15;
            this.txtTotalLinea.TabStop = false;
            this.txtTotalLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCreditoDisponible
            // 
            this.txtCreditoDisponible.BackColor = System.Drawing.Color.White;
            this.txtCreditoDisponible.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditoDisponible.ForeColor = System.Drawing.Color.Black;
            this.txtCreditoDisponible.Location = new System.Drawing.Point(636, 68);
            this.txtCreditoDisponible.Name = "txtCreditoDisponible";
            this.txtCreditoDisponible.ReadOnly = true;
            this.txtCreditoDisponible.Size = new System.Drawing.Size(82, 20);
            this.txtCreditoDisponible.TabIndex = 34;
            this.txtCreditoDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(538, 72);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(92, 13);
            this.label38.TabIndex = 33;
            this.label38.Text = "Credito Disponible";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Location = new System.Drawing.Point(663, 6);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(93, 23);
            this.btnBuscaCliente.TabIndex = 32;
            this.btnBuscaCliente.Text = "Buscar Cliente";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(538, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Dias de Plazo";
            // 
            // txtDiasPlazo
            // 
            this.txtDiasPlazo.BackColor = System.Drawing.Color.White;
            this.txtDiasPlazo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiasPlazo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasPlazo.Location = new System.Drawing.Point(636, 51);
            this.txtDiasPlazo.Name = "txtDiasPlazo";
            this.txtDiasPlazo.Size = new System.Drawing.Size(117, 13);
            this.txtDiasPlazo.TabIndex = 19;
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.White;
            this.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContacto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(60, 68);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(194, 20);
            this.txtContacto.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Contacto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Email";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Giro";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ciudad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Comuna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dirección";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(314, 68);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(221, 20);
            this.txtFax.TabIndex = 10;
            // 
            // txtFono
            // 
            this.txtFono.BackColor = System.Drawing.Color.White;
            this.txtFono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFono.Location = new System.Drawing.Point(392, 51);
            this.txtFono.Name = "txtFono";
            this.txtFono.Size = new System.Drawing.Size(143, 13);
            this.txtFono.TabIndex = 9;
            // 
            // txtGiro
            // 
            this.txtGiro.BackColor = System.Drawing.Color.White;
            this.txtGiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGiro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiro.Location = new System.Drawing.Point(60, 51);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(276, 13);
            this.txtGiro.TabIndex = 8;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(580, 34);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(173, 13);
            this.txtCiudad.TabIndex = 7;
            // 
            // txtComuna
            // 
            this.txtComuna.BackColor = System.Drawing.Color.White;
            this.txtComuna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComuna.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComuna.Location = new System.Drawing.Point(392, 34);
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(143, 13);
            this.txtComuna.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(60, 34);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(276, 13);
            this.txtDireccion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Razon Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RUT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(257, 9);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(400, 20);
            this.txtRazonSocial.TabIndex = 8;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            this.txtRazonSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazonSocial_KeyDown);
            // 
            // txtDigito
            // 
            this.txtDigito.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigito.Location = new System.Drawing.Point(132, 9);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(29, 20);
            this.txtDigito.TabIndex = 7;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(60, 9);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(68, 20);
            this.txtRut.TabIndex = 6;
            this.txtRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRut_KeyDown);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.Location = new System.Drawing.Point(580, 19);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(61, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescuento.Location = new System.Drawing.Point(733, 19);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(61, 20);
            this.txtDescuento.TabIndex = 14;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // chkCantidadFija
            // 
            this.chkCantidadFija.AutoSize = true;
            this.chkCantidadFija.Location = new System.Drawing.Point(684, 25);
            this.chkCantidadFija.Name = "chkCantidadFija";
            this.chkCantidadFija.Size = new System.Drawing.Size(15, 14);
            this.chkCantidadFija.TabIndex = 16;
            this.chkCantidadFija.UseVisualStyleBackColor = true;
            this.chkCantidadFija.Click += new System.EventHandler(this.chkCantidadFija_Click);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(4, 35);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroDocumento.TabIndex = 16;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.DoubleClick += new System.EventHandler(this.txtNumeroDocumento_DoubleClick);
            this.txtNumeroDocumento.Leave += new System.EventHandler(this.txtNumeroDocumento_Leave);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.Color.Blue;
            this.lblFolio.Location = new System.Drawing.Point(4, 16);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(114, 16);
            this.lblFolio.TabIndex = 5;
            this.lblFolio.Text = "E-FACTURA N°";
            this.lblFolio.DoubleClick += new System.EventHandler(this.lblFolio_DoubleClick);
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(437, 30);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(101, 20);
            this.txtOrdenCompra.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(437, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Orden de Com.";
            // 
            // txtTotalExento
            // 
            this.txtTotalExento.BackColor = System.Drawing.Color.White;
            this.txtTotalExento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalExento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExento.ForeColor = System.Drawing.Color.Black;
            this.txtTotalExento.Location = new System.Drawing.Point(112, 94);
            this.txtTotalExento.Name = "txtTotalExento";
            this.txtTotalExento.ReadOnly = true;
            this.txtTotalExento.Size = new System.Drawing.Size(103, 21);
            this.txtTotalExento.TabIndex = 31;
            this.txtTotalExento.TabStop = false;
            this.txtTotalExento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(21, 98);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(87, 14);
            this.label44.TabIndex = 30;
            this.label44.Text = "TOTAL EXENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "FACTURA ELECTRONICA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstadoDocumento
            // 
            this.lblEstadoDocumento.AutoSize = true;
            this.lblEstadoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDocumento.ForeColor = System.Drawing.Color.Blue;
            this.lblEstadoDocumento.Location = new System.Drawing.Point(290, 15);
            this.lblEstadoDocumento.Name = "lblEstadoDocumento";
            this.lblEstadoDocumento.Size = new System.Drawing.Size(104, 25);
            this.lblEstadoDocumento.TabIndex = 25;
            this.lblEstadoDocumento.Text = "ESTADO";
            this.lblEstadoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(478, 638);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(88, 23);
            this.btnAnular.TabIndex = 24;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Visible = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtPorIva
            // 
            this.txtPorIva.BackColor = System.Drawing.Color.White;
            this.txtPorIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorIva.ForeColor = System.Drawing.Color.Black;
            this.txtPorIva.Location = new System.Drawing.Point(112, 71);
            this.txtPorIva.Name = "txtPorIva";
            this.txtPorIva.ReadOnly = true;
            this.txtPorIva.Size = new System.Drawing.Size(24, 21);
            this.txtPorIva.TabIndex = 11;
            this.txtPorIva.TabStop = false;
            this.txtPorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubTotal.Location = new System.Drawing.Point(112, 5);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(103, 21);
            this.txtSubTotal.TabIndex = 10;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.BackColor = System.Drawing.Color.White;
            this.txtTotalGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeneral.ForeColor = System.Drawing.Color.Black;
            this.txtTotalGeneral.Location = new System.Drawing.Point(112, 117);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.ReadOnly = true;
            this.txtTotalGeneral.Size = new System.Drawing.Size(103, 21);
            this.txtTotalGeneral.TabIndex = 9;
            this.txtTotalGeneral.TabStop = false;
            this.txtTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.Color.White;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.ForeColor = System.Drawing.Color.Black;
            this.txtIva.Location = new System.Drawing.Point(138, 71);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(77, 21);
            this.txtIva.TabIndex = 8;
            this.txtIva.TabStop = false;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNeto
            // 
            this.txtNeto.BackColor = System.Drawing.Color.White;
            this.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeto.ForeColor = System.Drawing.Color.Black;
            this.txtNeto.Location = new System.Drawing.Point(112, 49);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(103, 21);
            this.txtNeto.TabIndex = 7;
            this.txtNeto.TabStop = false;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalDescuento
            // 
            this.txtTotalDescuento.BackColor = System.Drawing.Color.White;
            this.txtTotalDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDescuento.ForeColor = System.Drawing.Color.Black;
            this.txtTotalDescuento.Location = new System.Drawing.Point(138, 27);
            this.txtTotalDescuento.Name = "txtTotalDescuento";
            this.txtTotalDescuento.ReadOnly = true;
            this.txtTotalDescuento.Size = new System.Drawing.Size(77, 21);
            this.txtTotalDescuento.TabIndex = 6;
            this.txtTotalDescuento.TabStop = false;
            this.txtTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDescuento.TextChanged += new System.EventHandler(this.txtTotalDescuento_TextChanged);
            this.txtTotalDescuento.DoubleClick += new System.EventHandler(this.txtTotalDescuento_DoubleClick);
            this.txtTotalDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDescuento_KeyPress);
            this.txtTotalDescuento.Leave += new System.EventHandler(this.txtTotalDescuento_Leave);
            // 
            // txtPorcDescuentoTotal
            // 
            this.txtPorcDescuentoTotal.BackColor = System.Drawing.Color.White;
            this.txtPorcDescuentoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcDescuentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcDescuentoTotal.ForeColor = System.Drawing.Color.Black;
            this.txtPorcDescuentoTotal.Location = new System.Drawing.Point(112, 27);
            this.txtPorcDescuentoTotal.Name = "txtPorcDescuentoTotal";
            this.txtPorcDescuentoTotal.ReadOnly = true;
            this.txtPorcDescuentoTotal.Size = new System.Drawing.Size(24, 21);
            this.txtPorcDescuentoTotal.TabIndex = 5;
            this.txtPorcDescuentoTotal.TabStop = false;
            this.txtPorcDescuentoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoTotal.TextChanged += new System.EventHandler(this.txtPorcDescuentoTotal_TextChanged);
            this.txtPorcDescuentoTotal.DoubleClick += new System.EventHandler(this.txtPorcDescuentoTotal_DoubleClick);
            this.txtPorcDescuentoTotal.Leave += new System.EventHandler(this.txtPorcDescuentoTotal_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(65, 121);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 14);
            this.label26.TabIndex = 4;
            this.label26.Text = "TOTAL";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(77, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 14);
            this.label25.TabIndex = 3;
            this.label25.Text = "I.V.A";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(73, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 14);
            this.label24.TabIndex = 2;
            this.label24.Text = "NETO";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(38, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 14);
            this.label23.TabIndex = 1;
            this.label23.Text = "DESCUENTO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(44, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 14);
            this.label22.TabIndex = 0;
            this.label22.Text = "SUBTOTAL";
            // 
            // dgvDatosVenta
            // 
            this.dgvDatosVenta.AllowUserToAddRows = false;
            this.dgvDatosVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDatosVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatosVenta.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatosVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatosVenta.Location = new System.Drawing.Point(12, 220);
            this.dgvDatosVenta.MultiSelect = false;
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.ReadOnly = true;
            this.dgvDatosVenta.RowHeadersVisible = false;
            this.dgvDatosVenta.RowHeadersWidth = 50;
            this.dgvDatosVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosVenta.Size = new System.Drawing.Size(888, 228);
            this.dgvDatosVenta.TabIndex = 3;
            this.dgvDatosVenta.TabStop = false;
            this.dgvDatosVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
            this.dgvDatosVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(152, 12);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(142, 17);
            this.label27.TabIndex = 21;
            this.label27.Text = "Vendedor";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(152, 29);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(142, 21);
            this.cmbVendedor.TabIndex = 3;
            this.cmbVendedor.Enter += new System.EventHandler(this.cmbVendedor_Enter);
            // 
            // gbZonaOtros
            // 
            this.gbZonaOtros.Controls.Add(this.txtOrdenCompra);
            this.gbZonaOtros.Controls.Add(this.cmbMedioPago);
            this.gbZonaOtros.Controls.Add(this.cmbCentroCosto);
            this.gbZonaOtros.Controls.Add(this.cmbVendedor);
            this.gbZonaOtros.Controls.Add(this.label30);
            this.gbZonaOtros.Controls.Add(this.label18);
            this.gbZonaOtros.Controls.Add(this.label16);
            this.gbZonaOtros.Controls.Add(this.label27);
            this.gbZonaOtros.Location = new System.Drawing.Point(228, 21);
            this.gbZonaOtros.Name = "gbZonaOtros";
            this.gbZonaOtros.Size = new System.Drawing.Size(548, 55);
            this.gbZonaOtros.TabIndex = 25;
            this.gbZonaOtros.TabStop = false;
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedioPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(6, 29);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(140, 21);
            this.cmbMedioPago.TabIndex = 2;
            this.cmbMedioPago.SelectedValueChanged += new System.EventHandler(this.cmbMedioPago_SelectedValueChanged);
            this.cmbMedioPago.Enter += new System.EventHandler(this.cmbMedioPago_Enter);
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCentroCosto.FormattingEnabled = true;
            this.cmbCentroCosto.Location = new System.Drawing.Point(299, 29);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Size = new System.Drawing.Size(134, 21);
            this.cmbCentroCosto.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(299, 12);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(134, 17);
            this.label30.TabIndex = 34;
            this.label30.Text = "Centro de Costo";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Medio de Pago";
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbListaPrecio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(98, 18);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(69, 22);
            this.cmbListaPrecio.TabIndex = 18;
            this.cmbListaPrecio.SelectedValueChanged += new System.EventHandler(this.cmbListaPrecio_SelectedValueChanged);
            // 
            // panelZonaDetalle
            // 
            this.panelZonaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panelZonaDetalle.Controls.Add(this.txtPorcDescuentoLinea);
            this.panelZonaDetalle.Controls.Add(this.txtCodigo);
            this.panelZonaDetalle.Controls.Add(this.txtCantidad);
            this.panelZonaDetalle.Controls.Add(this.txtDescripcion);
            this.panelZonaDetalle.Controls.Add(this.txtTotalLinea);
            this.panelZonaDetalle.Controls.Add(this.txtPrecio);
            this.panelZonaDetalle.Controls.Add(this.txtDescuento);
            this.panelZonaDetalle.Controls.Add(this.cmbBodega);
            this.panelZonaDetalle.Controls.Add(this.cmbListaPrecio);
            this.panelZonaDetalle.Controls.Add(this.label29);
            this.panelZonaDetalle.Controls.Add(this.label28);
            this.panelZonaDetalle.Controls.Add(this.btnLimpiaLineaDetalle);
            this.panelZonaDetalle.Controls.Add(this.label31);
            this.panelZonaDetalle.Controls.Add(this.chkCantidadFija);
            this.panelZonaDetalle.Controls.Add(this.label20);
            this.panelZonaDetalle.Controls.Add(this.label14);
            this.panelZonaDetalle.Controls.Add(this.label13);
            this.panelZonaDetalle.Controls.Add(this.label15);
            this.panelZonaDetalle.Controls.Add(this.label17);
            this.panelZonaDetalle.Controls.Add(this.label19);
            this.panelZonaDetalle.Location = new System.Drawing.Point(12, 174);
            this.panelZonaDetalle.Name = "panelZonaDetalle";
            this.panelZonaDetalle.Size = new System.Drawing.Size(888, 44);
            this.panelZonaDetalle.TabIndex = 27;
            // 
            // txtPorcDescuentoLinea
            // 
            this.txtPorcDescuentoLinea.BackColor = System.Drawing.SystemColors.Window;
            this.txtPorcDescuentoLinea.Location = new System.Drawing.Point(700, 19);
            this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
            this.txtPorcDescuentoLinea.Size = new System.Drawing.Size(31, 20);
            this.txtPorcDescuentoLinea.TabIndex = 13;
            this.txtPorcDescuentoLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoLinea.TextChanged += new System.EventHandler(this.porcentajeDescuento_TextChanged);
            this.txtPorcDescuentoLinea.Enter += new System.EventHandler(this.txtPorcDescuentoLinea_Enter);
            this.txtPorcDescuentoLinea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPorcDescuentoLinea_KeyDown);
            this.txtPorcDescuentoLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
            // 
            // cmbBodega
            // 
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBodega.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(3, 18);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(92, 22);
            this.cmbBodega.TabIndex = 17;
            this.cmbBodega.Enter += new System.EventHandler(this.cmbBodega_Enter);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(98, 2);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 23);
            this.label29.TabIndex = 35;
            this.label29.Text = "Lista $";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 23);
            this.label28.TabIndex = 34;
            this.label28.Text = "Bodega";
            // 
            // btnLimpiaLineaDetalle
            // 
            this.btnLimpiaLineaDetalle.Location = new System.Drawing.Point(867, 2);
            this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
            this.btnLimpiaLineaDetalle.Size = new System.Drawing.Size(16, 38);
            this.btnLimpiaLineaDetalle.TabIndex = 33;
            this.btnLimpiaLineaDetalle.Text = "..";
            this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaLineaDetalle.Click += new System.EventHandler(this.btnLimpiaLineaDetalle_Click);
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(700, 2);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 23);
            this.label31.TabIndex = 29;
            this.label31.Text = "%";
            // 
            // txtTipoDescuento
            // 
            this.txtTipoDescuento.Location = new System.Drawing.Point(418, 640);
            this.txtTipoDescuento.Name = "txtTipoDescuento";
            this.txtTipoDescuento.Size = new System.Drawing.Size(38, 20);
            this.txtTipoDescuento.TabIndex = 35;
            this.txtTipoDescuento.Text = "0";
            this.txtTipoDescuento.Visible = false;
            // 
            // txtSubTotalLinea
            // 
            this.txtSubTotalLinea.Location = new System.Drawing.Point(366, 640);
            this.txtSubTotalLinea.Name = "txtSubTotalLinea";
            this.txtSubTotalLinea.Size = new System.Drawing.Size(43, 20);
            this.txtSubTotalLinea.TabIndex = 34;
            this.txtSubTotalLinea.Visible = false;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(335, 640);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(24, 20);
            this.txtLinea.TabIndex = 32;
            this.txtLinea.Text = "NumeroLinea";
            this.txtLinea.Visible = false;
            // 
            // dgvBuscaCliente
            // 
            this.dgvBuscaCliente.AllowUserToAddRows = false;
            this.dgvBuscaCliente.AllowUserToDeleteRows = false;
            this.dgvBuscaCliente.AllowUserToResizeColumns = false;
            this.dgvBuscaCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Lavender;
            this.dgvBuscaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBuscaCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscaCliente.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBuscaCliente.Location = new System.Drawing.Point(3, 3);
            this.dgvBuscaCliente.Name = "dgvBuscaCliente";
            this.dgvBuscaCliente.ReadOnly = true;
            this.dgvBuscaCliente.RowHeadersVisible = false;
            this.dgvBuscaCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscaCliente.Size = new System.Drawing.Size(715, 211);
            this.dgvBuscaCliente.TabIndex = 0;
            this.dgvBuscaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscaCliente_CellContentClick);
            this.dgvBuscaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscaCliente_CellDoubleClick);
            this.dgvBuscaCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBuscaCliente_KeyDown);
            // 
            // pnlBuscaClienteDes
            // 
            this.pnlBuscaClienteDes.BackColor = System.Drawing.Color.Transparent;
            this.pnlBuscaClienteDes.Controls.Add(this.dgvBuscaCliente);
            this.pnlBuscaClienteDes.Location = new System.Drawing.Point(266, 105);
            this.pnlBuscaClienteDes.Name = "pnlBuscaClienteDes";
            this.pnlBuscaClienteDes.Size = new System.Drawing.Size(721, 214);
            this.pnlBuscaClienteDes.TabIndex = 32;
            // 
            // panelFolio
            // 
            this.panelFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFolio.Controls.Add(this.btnCerrarPanelFolio);
            this.panelFolio.Controls.Add(this.btnBuscaFolio);
            this.panelFolio.Controls.Add(this.txtFolioBuscar);
            this.panelFolio.Controls.Add(this.label32);
            this.panelFolio.Location = new System.Drawing.Point(750, 73);
            this.panelFolio.Name = "panelFolio";
            this.panelFolio.Size = new System.Drawing.Size(212, 92);
            this.panelFolio.TabIndex = 24;
            // 
            // btnCerrarPanelFolio
            // 
            this.btnCerrarPanelFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPanelFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPanelFolio.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarPanelFolio.Location = new System.Drawing.Point(185, 1);
            this.btnCerrarPanelFolio.Name = "btnCerrarPanelFolio";
            this.btnCerrarPanelFolio.Size = new System.Drawing.Size(23, 24);
            this.btnCerrarPanelFolio.TabIndex = 24;
            this.btnCerrarPanelFolio.Text = "X";
            this.btnCerrarPanelFolio.UseVisualStyleBackColor = true;
            this.btnCerrarPanelFolio.Click += new System.EventHandler(this.btnCerrarPanelFolio_Click);
            // 
            // btnBuscaFolio
            // 
            this.btnBuscaFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaFolio.Location = new System.Drawing.Point(25, 59);
            this.btnBuscaFolio.Name = "btnBuscaFolio";
            this.btnBuscaFolio.Size = new System.Drawing.Size(161, 25);
            this.btnBuscaFolio.TabIndex = 2;
            this.btnBuscaFolio.Text = "Buscar";
            this.btnBuscaFolio.UseVisualStyleBackColor = true;
            this.btnBuscaFolio.Click += new System.EventHandler(this.btnBuscaFolio_Click);
            // 
            // txtFolioBuscar
            // 
            this.txtFolioBuscar.Location = new System.Drawing.Point(26, 33);
            this.txtFolioBuscar.Name = "txtFolioBuscar";
            this.txtFolioBuscar.Size = new System.Drawing.Size(162, 20);
            this.txtFolioBuscar.TabIndex = 1;
            this.txtFolioBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFolioBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioBuscar_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(21, 8);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(164, 16);
            this.label32.TabIndex = 0;
            this.label32.Text = "Ingrese Folio a Buscar";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(7, 62);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(61, 13);
            this.label33.TabIndex = 33;
            this.label33.Text = "Ticket N°";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(4, 80);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(111, 20);
            this.txtTicket.TabIndex = 29;
            this.txtTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicket_KeyPress);
            // 
            // gbZonaTicket
            // 
            this.gbZonaTicket.Controls.Add(this.chkHistoricoVentas);
            this.gbZonaTicket.Controls.Add(this.txtTicket);
            this.gbZonaTicket.Controls.Add(this.label33);
            this.gbZonaTicket.Controls.Add(this.lblFolio);
            this.gbZonaTicket.Controls.Add(this.txtNumeroDocumento);
            this.gbZonaTicket.Location = new System.Drawing.Point(775, 21);
            this.gbZonaTicket.Name = "gbZonaTicket";
            this.gbZonaTicket.Size = new System.Drawing.Size(127, 150);
            this.gbZonaTicket.TabIndex = 34;
            this.gbZonaTicket.TabStop = false;
            // 
            // chkHistoricoVentas
            // 
            this.chkHistoricoVentas.Location = new System.Drawing.Point(3, 106);
            this.chkHistoricoVentas.Name = "chkHistoricoVentas";
            this.chkHistoricoVentas.Size = new System.Drawing.Size(116, 40);
            this.chkHistoricoVentas.TabIndex = 34;
            this.chkHistoricoVentas.Text = "Factura para historico de ventas";
            this.chkHistoricoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHistoricoVentas.UseVisualStyleBackColor = true;
            this.chkHistoricoVentas.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 451);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 181);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnImprime);
            this.tabPage1.Controls.Add(this.lblEstadoDocumento);
            this.tabPage1.Controls.Add(this.btnControlPago);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnModificar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 155);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Image = global::Aptusoft.Properties.Resources.send_mail_icone_9097_48;
            this.btnEnviar.Location = new System.Drawing.Point(439, 58);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(70, 70);
            this.btnEnviar.TabIndex = 34;
            this.btnEnviar.Text = "Envío a Cliente";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.txtSubTotal);
            this.panel1.Controls.Add(this.txtTotalExento);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.txtPorIva);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.txtPorcDescuentoTotal);
            this.panel1.Controls.Add(this.txtTotalGeneral);
            this.panel1.Controls.Add(this.txtTotalDescuento);
            this.panel1.Controls.Add(this.txtNeto);
            this.panel1.Controls.Add(this.txtIva);
            this.panel1.Location = new System.Drawing.Point(654, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 143);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(653, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 145);
            this.panel2.TabIndex = 33;
            // 
            // btnImprime
            // 
            this.btnImprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprime.Image = global::Aptusoft.Properties.Resources.imprimir_48;
            this.btnImprime.Location = new System.Drawing.Point(223, 58);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(70, 70);
            this.btnImprime.TabIndex = 26;
            this.btnImprime.Text = "Imprimir";
            this.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // btnControlPago
            // 
            this.btnControlPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlPago.Image = global::Aptusoft.Properties.Resources.pagar_48;
            this.btnControlPago.Location = new System.Drawing.Point(367, 58);
            this.btnControlPago.Name = "btnControlPago";
            this.btnControlPago.Size = new System.Drawing.Size(70, 70);
            this.btnControlPago.TabIndex = 27;
            this.btnControlPago.Text = "Pagar";
            this.btnControlPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnControlPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnControlPago.UseVisualStyleBackColor = true;
            this.btnControlPago.Click += new System.EventHandler(this.btnControlPago_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Aptusoft.Properties.Resources.disquetes_excepto_icono_7120_48;
            this.btnGuardar.Location = new System.Drawing.Point(7, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guarda";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.Location = new System.Drawing.Point(511, 58);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 70);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::Aptusoft.Properties.Resources.modificar_48;
            this.btnModificar.Location = new System.Drawing.Point(79, 58);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 70);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modifica";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::Aptusoft.Properties.Resources.mark_correo_basura_icono_3897_48;
            this.btnEliminar.Location = new System.Drawing.Point(151, 58);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 70);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Elimina";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Aptusoft.Properties.Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
            this.btnLimpiar.Location = new System.Drawing.Point(295, 58);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(880, 155);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Impuestos Esp.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodImp5);
            this.groupBox1.Controls.Add(this.lblCodImp4);
            this.groupBox1.Controls.Add(this.lblCodImp3);
            this.groupBox1.Controls.Add(this.lblCodImp2);
            this.groupBox1.Controls.Add(this.lblCodImp1);
            this.groupBox1.Controls.Add(this.txtTotalImp5);
            this.groupBox1.Controls.Add(this.txtTotalImp3);
            this.groupBox1.Controls.Add(this.txtTotalImp4);
            this.groupBox1.Controls.Add(this.txtPorImp5);
            this.groupBox1.Controls.Add(this.txtPorImp3);
            this.groupBox1.Controls.Add(this.txtTotalImp2);
            this.groupBox1.Controls.Add(this.txtPorImp4);
            this.groupBox1.Controls.Add(this.txtPorImp2);
            this.groupBox1.Controls.Add(this.txtTotalImp1);
            this.groupBox1.Controls.Add(this.txtPorImp1);
            this.groupBox1.Controls.Add(this.lblImp5);
            this.groupBox1.Controls.Add(this.lblImp4);
            this.groupBox1.Controls.Add(this.lblImp3);
            this.groupBox1.Controls.Add(this.lblImp2);
            this.groupBox1.Controls.Add(this.lblImp1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 133);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impuestos Especiales";
            // 
            // lblCodImp5
            // 
            this.lblCodImp5.Location = new System.Drawing.Point(146, 111);
            this.lblCodImp5.Name = "lblCodImp5";
            this.lblCodImp5.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp5.TabIndex = 43;
            this.lblCodImp5.Text = "Impuesto 5";
            // 
            // lblCodImp4
            // 
            this.lblCodImp4.Location = new System.Drawing.Point(146, 89);
            this.lblCodImp4.Name = "lblCodImp4";
            this.lblCodImp4.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp4.TabIndex = 42;
            this.lblCodImp4.Text = "Impuesto 4";
            // 
            // lblCodImp3
            // 
            this.lblCodImp3.Location = new System.Drawing.Point(146, 67);
            this.lblCodImp3.Name = "lblCodImp3";
            this.lblCodImp3.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp3.TabIndex = 41;
            this.lblCodImp3.Text = "Impuesto 3";
            // 
            // lblCodImp2
            // 
            this.lblCodImp2.Location = new System.Drawing.Point(146, 45);
            this.lblCodImp2.Name = "lblCodImp2";
            this.lblCodImp2.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp2.TabIndex = 40;
            this.lblCodImp2.Text = "Impuesto 2";
            // 
            // lblCodImp1
            // 
            this.lblCodImp1.Location = new System.Drawing.Point(146, 23);
            this.lblCodImp1.Name = "lblCodImp1";
            this.lblCodImp1.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp1.TabIndex = 39;
            this.lblCodImp1.Text = "Impuesto 1";
            // 
            // txtTotalImp5
            // 
            this.txtTotalImp5.BackColor = System.Drawing.Color.White;
            this.txtTotalImp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImp5.Location = new System.Drawing.Point(57, 107);
            this.txtTotalImp5.Name = "txtTotalImp5";
            this.txtTotalImp5.ReadOnly = true;
            this.txtTotalImp5.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp5.TabIndex = 38;
            this.txtTotalImp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp3
            // 
            this.txtTotalImp3.BackColor = System.Drawing.Color.White;
            this.txtTotalImp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImp3.Location = new System.Drawing.Point(57, 63);
            this.txtTotalImp3.Name = "txtTotalImp3";
            this.txtTotalImp3.ReadOnly = true;
            this.txtTotalImp3.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp3.TabIndex = 10;
            this.txtTotalImp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp4
            // 
            this.txtTotalImp4.BackColor = System.Drawing.Color.White;
            this.txtTotalImp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImp4.Location = new System.Drawing.Point(57, 85);
            this.txtTotalImp4.Name = "txtTotalImp4";
            this.txtTotalImp4.ReadOnly = true;
            this.txtTotalImp4.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp4.TabIndex = 36;
            this.txtTotalImp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp5
            // 
            this.txtPorImp5.BackColor = System.Drawing.Color.White;
            this.txtPorImp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorImp5.Location = new System.Drawing.Point(6, 107);
            this.txtPorImp5.Name = "txtPorImp5";
            this.txtPorImp5.ReadOnly = true;
            this.txtPorImp5.Size = new System.Drawing.Size(47, 21);
            this.txtPorImp5.TabIndex = 37;
            this.txtPorImp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPorImp3
            // 
            this.txtPorImp3.BackColor = System.Drawing.Color.White;
            this.txtPorImp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorImp3.Location = new System.Drawing.Point(6, 63);
            this.txtPorImp3.Name = "txtPorImp3";
            this.txtPorImp3.ReadOnly = true;
            this.txtPorImp3.Size = new System.Drawing.Size(47, 21);
            this.txtPorImp3.TabIndex = 9;
            this.txtPorImp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalImp2
            // 
            this.txtTotalImp2.BackColor = System.Drawing.Color.White;
            this.txtTotalImp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImp2.Location = new System.Drawing.Point(57, 41);
            this.txtTotalImp2.Name = "txtTotalImp2";
            this.txtTotalImp2.ReadOnly = true;
            this.txtTotalImp2.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp2.TabIndex = 8;
            this.txtTotalImp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp4
            // 
            this.txtPorImp4.BackColor = System.Drawing.Color.White;
            this.txtPorImp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorImp4.Location = new System.Drawing.Point(6, 85);
            this.txtPorImp4.Name = "txtPorImp4";
            this.txtPorImp4.ReadOnly = true;
            this.txtPorImp4.Size = new System.Drawing.Size(47, 21);
            this.txtPorImp4.TabIndex = 35;
            this.txtPorImp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPorImp2
            // 
            this.txtPorImp2.BackColor = System.Drawing.Color.White;
            this.txtPorImp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorImp2.Location = new System.Drawing.Point(6, 41);
            this.txtPorImp2.Name = "txtPorImp2";
            this.txtPorImp2.ReadOnly = true;
            this.txtPorImp2.Size = new System.Drawing.Size(47, 21);
            this.txtPorImp2.TabIndex = 7;
            this.txtPorImp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalImp1
            // 
            this.txtTotalImp1.BackColor = System.Drawing.Color.White;
            this.txtTotalImp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImp1.Location = new System.Drawing.Point(57, 19);
            this.txtTotalImp1.Name = "txtTotalImp1";
            this.txtTotalImp1.ReadOnly = true;
            this.txtTotalImp1.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp1.TabIndex = 6;
            this.txtTotalImp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp1
            // 
            this.txtPorImp1.BackColor = System.Drawing.Color.White;
            this.txtPorImp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorImp1.ForeColor = System.Drawing.Color.Black;
            this.txtPorImp1.Location = new System.Drawing.Point(6, 19);
            this.txtPorImp1.Name = "txtPorImp1";
            this.txtPorImp1.ReadOnly = true;
            this.txtPorImp1.Size = new System.Drawing.Size(47, 21);
            this.txtPorImp1.TabIndex = 5;
            this.txtPorImp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblImp5
            // 
            this.lblImp5.AutoSize = true;
            this.lblImp5.Location = new System.Drawing.Point(166, 111);
            this.lblImp5.Name = "lblImp5";
            this.lblImp5.Size = new System.Drawing.Size(59, 13);
            this.lblImp5.TabIndex = 4;
            this.lblImp5.Text = "Impuesto 5";
            // 
            // lblImp4
            // 
            this.lblImp4.AutoSize = true;
            this.lblImp4.Location = new System.Drawing.Point(166, 89);
            this.lblImp4.Name = "lblImp4";
            this.lblImp4.Size = new System.Drawing.Size(59, 13);
            this.lblImp4.TabIndex = 3;
            this.lblImp4.Text = "Impuesto 4";
            // 
            // lblImp3
            // 
            this.lblImp3.AutoSize = true;
            this.lblImp3.Location = new System.Drawing.Point(166, 67);
            this.lblImp3.Name = "lblImp3";
            this.lblImp3.Size = new System.Drawing.Size(59, 13);
            this.lblImp3.TabIndex = 2;
            this.lblImp3.Text = "Impuesto 3";
            // 
            // lblImp2
            // 
            this.lblImp2.AutoSize = true;
            this.lblImp2.Location = new System.Drawing.Point(166, 45);
            this.lblImp2.Name = "lblImp2";
            this.lblImp2.Size = new System.Drawing.Size(59, 13);
            this.lblImp2.TabIndex = 1;
            this.lblImp2.Text = "Impuesto 2";
            // 
            // lblImp1
            // 
            this.lblImp1.AutoSize = true;
            this.lblImp1.Location = new System.Drawing.Point(166, 23);
            this.lblImp1.Name = "lblImp1";
            this.lblImp1.Size = new System.Drawing.Size(59, 13);
            this.lblImp1.TabIndex = 0;
            this.lblImp1.Text = "Impuesto 1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.txtGuias);
            this.tabPage2.Controls.Add(this.txtObservaciones);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 155);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Otros";
            // 
            // txtGuias
            // 
            this.txtGuias.BackColor = System.Drawing.Color.White;
            this.txtGuias.Location = new System.Drawing.Point(462, 28);
            this.txtGuias.Multiline = true;
            this.txtGuias.Name = "txtGuias";
            this.txtGuias.ReadOnly = true;
            this.txtGuias.Size = new System.Drawing.Size(405, 116);
            this.txtGuias.TabIndex = 0;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(14, 28);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(405, 116);
            this.txtObservaciones.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(462, 12);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(405, 23);
            this.label35.TabIndex = 3;
            this.label35.Text = "GUIAS";
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(14, 12);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(405, 23);
            this.label34.TabIndex = 2;
            this.label34.Text = "OBSERVACIONES";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.btnGuardaReferencia);
            this.tabPage3.Controls.Add(this.txtRazonReferencia);
            this.tabPage3.Controls.Add(this.cmbTipoAccion);
            this.tabPage3.Controls.Add(this.dtpFechaReferencia);
            this.tabPage3.Controls.Add(this.txtFolioDocumentoReferencia);
            this.tabPage3.Controls.Add(this.cmbTipoDocumentoReferencia);
            this.tabPage3.Controls.Add(this.label43);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.dgvReferencias);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(880, 155);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Referencias";
            // 
            // btnGuardaReferencia
            // 
            this.btnGuardaReferencia.Location = new System.Drawing.Point(788, 126);
            this.btnGuardaReferencia.Name = "btnGuardaReferencia";
            this.btnGuardaReferencia.Size = new System.Drawing.Size(75, 23);
            this.btnGuardaReferencia.TabIndex = 12;
            this.btnGuardaReferencia.Text = "Guardar";
            this.btnGuardaReferencia.UseVisualStyleBackColor = true;
            this.btnGuardaReferencia.Click += new System.EventHandler(this.btnGuardaReferencia_Click);
            // 
            // txtRazonReferencia
            // 
            this.txtRazonReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonReferencia.Location = new System.Drawing.Point(634, 23);
            this.txtRazonReferencia.Multiline = true;
            this.txtRazonReferencia.Name = "txtRazonReferencia";
            this.txtRazonReferencia.Size = new System.Drawing.Size(229, 97);
            this.txtRazonReferencia.TabIndex = 11;
            // 
            // cmbTipoAccion
            // 
            this.cmbTipoAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAccion.FormattingEnabled = true;
            this.cmbTipoAccion.Location = new System.Drawing.Point(350, 23);
            this.cmbTipoAccion.Name = "cmbTipoAccion";
            this.cmbTipoAccion.Size = new System.Drawing.Size(278, 21);
            this.cmbTipoAccion.TabIndex = 10;
            // 
            // dtpFechaReferencia
            // 
            this.dtpFechaReferencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReferencia.Location = new System.Drawing.Point(243, 23);
            this.dtpFechaReferencia.Name = "dtpFechaReferencia";
            this.dtpFechaReferencia.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaReferencia.TabIndex = 9;
            // 
            // txtFolioDocumentoReferencia
            // 
            this.txtFolioDocumentoReferencia.Location = new System.Drawing.Point(161, 23);
            this.txtFolioDocumentoReferencia.MaxLength = 18;
            this.txtFolioDocumentoReferencia.Name = "txtFolioDocumentoReferencia";
            this.txtFolioDocumentoReferencia.Size = new System.Drawing.Size(78, 20);
            this.txtFolioDocumentoReferencia.TabIndex = 8;
            this.txtFolioDocumentoReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFolioDocumentoReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioDocumentoReferencia_KeyPress);
            // 
            // cmbTipoDocumentoReferencia
            // 
            this.cmbTipoDocumentoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumentoReferencia.FormattingEnabled = true;
            this.cmbTipoDocumentoReferencia.Location = new System.Drawing.Point(5, 23);
            this.cmbTipoDocumentoReferencia.Name = "cmbTipoDocumentoReferencia";
            this.cmbTipoDocumentoReferencia.Size = new System.Drawing.Size(152, 21);
            this.cmbTipoDocumentoReferencia.TabIndex = 7;
            this.cmbTipoDocumentoReferencia.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumentoReferencia_SelectedIndexChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(634, 7);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(93, 13);
            this.label43.TabIndex = 6;
            this.label43.Text = "Razon Referencia";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(350, 7);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 13);
            this.label42.TabIndex = 5;
            this.label42.Text = "Tipo de Accion";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(243, 7);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(101, 13);
            this.label41.TabIndex = 4;
            this.label41.Text = "Fecha de Doc. Ref.";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(161, 7);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(78, 13);
            this.label40.TabIndex = 3;
            this.label40.Text = "Folio Doc. Ref.";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(5, 7);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(129, 13);
            this.label39.TabIndex = 2;
            this.label39.Text = "Documento a Referenciar";
            // 
            // dgvReferencias
            // 
            this.dgvReferencias.AllowUserToAddRows = false;
            this.dgvReferencias.AllowUserToDeleteRows = false;
            this.dgvReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReferencia,
            this.IdDocumento,
            this.FolioDocumento,
            this.TipoDocumento,
            this.TipoDocumentoNombre,
            this.FolioDocumentoReferencia,
            this.FechaDocumentoReferencia,
            this.TipoAccion,
            this.TipoAccionNombre,
            this.RazonReferencia,
            this.EliminaReferencia});
            this.dgvReferencias.Location = new System.Drawing.Point(5, 50);
            this.dgvReferencias.Name = "dgvReferencias";
            this.dgvReferencias.ReadOnly = true;
            this.dgvReferencias.RowHeadersVisible = false;
            this.dgvReferencias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReferencias.Size = new System.Drawing.Size(623, 99);
            this.dgvReferencias.TabIndex = 1;
            this.dgvReferencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReferencias_CellClick);
            // 
            // IdReferencia
            // 
            this.IdReferencia.DataPropertyName = "IdReferencia";
            this.IdReferencia.HeaderText = "IdReferencia";
            this.IdReferencia.Name = "IdReferencia";
            this.IdReferencia.ReadOnly = true;
            this.IdReferencia.Visible = false;
            // 
            // IdDocumento
            // 
            this.IdDocumento.DataPropertyName = "IdDocumento";
            this.IdDocumento.HeaderText = "IdDocumento";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            this.IdDocumento.Visible = false;
            // 
            // FolioDocumento
            // 
            this.FolioDocumento.DataPropertyName = "FolioDocumento";
            this.FolioDocumento.HeaderText = "N° Doc.";
            this.FolioDocumento.Name = "FolioDocumento";
            this.FolioDocumento.ReadOnly = true;
            this.FolioDocumento.Visible = false;
            this.FolioDocumento.Width = 70;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "TipoDocumento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Visible = false;
            // 
            // TipoDocumentoNombre
            // 
            this.TipoDocumentoNombre.DataPropertyName = "TipoDocumentoNombre";
            this.TipoDocumentoNombre.HeaderText = "Documento";
            this.TipoDocumentoNombre.Name = "TipoDocumentoNombre";
            this.TipoDocumentoNombre.ReadOnly = true;
            this.TipoDocumentoNombre.Width = 120;
            // 
            // FolioDocumentoReferencia
            // 
            this.FolioDocumentoReferencia.DataPropertyName = "FolioDocumentoReferencia";
            this.FolioDocumentoReferencia.HeaderText = "N° Ref.";
            this.FolioDocumentoReferencia.Name = "FolioDocumentoReferencia";
            this.FolioDocumentoReferencia.ReadOnly = true;
            this.FolioDocumentoReferencia.Width = 70;
            // 
            // FechaDocumentoReferencia
            // 
            this.FechaDocumentoReferencia.DataPropertyName = "FechaDocumentoReferencia";
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.FechaDocumentoReferencia.DefaultCellStyle = dataGridViewCellStyle10;
            this.FechaDocumentoReferencia.HeaderText = "Fecha";
            this.FechaDocumentoReferencia.Name = "FechaDocumentoReferencia";
            this.FechaDocumentoReferencia.ReadOnly = true;
            this.FechaDocumentoReferencia.Width = 80;
            // 
            // TipoAccion
            // 
            this.TipoAccion.DataPropertyName = "TipoAccion";
            this.TipoAccion.HeaderText = "TipoAccion";
            this.TipoAccion.Name = "TipoAccion";
            this.TipoAccion.ReadOnly = true;
            this.TipoAccion.Visible = false;
            // 
            // TipoAccionNombre
            // 
            this.TipoAccionNombre.DataPropertyName = "TipoAccionNombre";
            this.TipoAccionNombre.HeaderText = "Tipo Accion";
            this.TipoAccionNombre.Name = "TipoAccionNombre";
            this.TipoAccionNombre.ReadOnly = true;
            this.TipoAccionNombre.Width = 130;
            // 
            // RazonReferencia
            // 
            this.RazonReferencia.DataPropertyName = "RazonReferencia";
            this.RazonReferencia.HeaderText = "Razon";
            this.RazonReferencia.Name = "RazonReferencia";
            this.RazonReferencia.ReadOnly = true;
            this.RazonReferencia.Width = 150;
            // 
            // EliminaReferencia
            // 
            this.EliminaReferencia.HeaderText = "Eli.";
            this.EliminaReferencia.Name = "EliminaReferencia";
            this.EliminaReferencia.ReadOnly = true;
            this.EliminaReferencia.Text = "X";
            this.EliminaReferencia.UseColumnTextForButtonValue = true;
            this.EliminaReferencia.Width = 50;
            // 
            // btnBuscaCotizacion
            // 
            this.btnBuscaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCotizacion.Location = new System.Drawing.Point(8, 77);
            this.btnBuscaCotizacion.Name = "btnBuscaCotizacion";
            this.btnBuscaCotizacion.Size = new System.Drawing.Size(149, 23);
            this.btnBuscaCotizacion.TabIndex = 2;
            this.btnBuscaCotizacion.Text = "BUSCAR";
            this.btnBuscaCotizacion.UseVisualStyleBackColor = true;
            this.btnBuscaCotizacion.Click += new System.EventHandler(this.btnBuscaCotizacion_Click);
            // 
            // txtFolioCotizacion
            // 
            this.txtFolioCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioCotizacion.Location = new System.Drawing.Point(8, 45);
            this.txtFolioCotizacion.Name = "txtFolioCotizacion";
            this.txtFolioCotizacion.Size = new System.Drawing.Size(148, 26);
            this.txtFolioCotizacion.TabIndex = 1;
            this.txtFolioCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFolioCotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioCotizacion_KeyPress);
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Blue;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(8, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(149, 18);
            this.label36.TabIndex = 0;
            this.label36.Text = "COTIZACIÓN N°";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalirBuscaCoti
            // 
            this.btnSalirBuscaCoti.Location = new System.Drawing.Point(157, 3);
            this.btnSalirBuscaCoti.Name = "btnSalirBuscaCoti";
            this.btnSalirBuscaCoti.Size = new System.Drawing.Size(29, 23);
            this.btnSalirBuscaCoti.TabIndex = 3;
            this.btnSalirBuscaCoti.Text = "X";
            this.btnSalirBuscaCoti.UseVisualStyleBackColor = true;
            this.btnSalirBuscaCoti.Click += new System.EventHandler(this.btnSalirBuscaCoti_Click);
            // 
            // pnlCotizacionBuscar
            // 
            this.pnlCotizacionBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlCotizacionBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCotizacionBuscar.Controls.Add(this.btnBuscaCotizacion);
            this.pnlCotizacionBuscar.Controls.Add(this.btnSalirBuscaCoti);
            this.pnlCotizacionBuscar.Controls.Add(this.txtFolioCotizacion);
            this.pnlCotizacionBuscar.Controls.Add(this.label36);
            this.pnlCotizacionBuscar.Location = new System.Drawing.Point(444, 131);
            this.pnlCotizacionBuscar.Name = "pnlCotizacionBuscar";
            this.pnlCotizacionBuscar.Size = new System.Drawing.Size(193, 110);
            this.pnlCotizacionBuscar.TabIndex = 37;
            // 
            // panelNotaVenta
            // 
            this.panelNotaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelNotaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotaVenta.Controls.Add(this.btnCierraNota);
            this.panelNotaVenta.Controls.Add(this.btnBuscaNotaventa);
            this.panelNotaVenta.Controls.Add(this.txtFolioNotaVenta);
            this.panelNotaVenta.Controls.Add(this.label37);
            this.panelNotaVenta.Location = new System.Drawing.Point(366, 129);
            this.panelNotaVenta.Name = "panelNotaVenta";
            this.panelNotaVenta.Size = new System.Drawing.Size(218, 106);
            this.panelNotaVenta.TabIndex = 38;
            // 
            // btnCierraNota
            // 
            this.btnCierraNota.Location = new System.Drawing.Point(176, 1);
            this.btnCierraNota.Name = "btnCierraNota";
            this.btnCierraNota.Size = new System.Drawing.Size(29, 23);
            this.btnCierraNota.TabIndex = 3;
            this.btnCierraNota.Text = "X";
            this.btnCierraNota.UseVisualStyleBackColor = true;
            this.btnCierraNota.Click += new System.EventHandler(this.btnCierraNota_Click);
            // 
            // btnBuscaNotaventa
            // 
            this.btnBuscaNotaventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaNotaventa.Location = new System.Drawing.Point(24, 75);
            this.btnBuscaNotaventa.Name = "btnBuscaNotaventa";
            this.btnBuscaNotaventa.Size = new System.Drawing.Size(148, 23);
            this.btnBuscaNotaventa.TabIndex = 2;
            this.btnBuscaNotaventa.Text = "BUSCAR";
            this.btnBuscaNotaventa.UseVisualStyleBackColor = true;
            this.btnBuscaNotaventa.Click += new System.EventHandler(this.btnBuscaNotaventa_Click);
            // 
            // txtFolioNotaVenta
            // 
            this.txtFolioNotaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioNotaVenta.Location = new System.Drawing.Point(24, 44);
            this.txtFolioNotaVenta.Name = "txtFolioNotaVenta";
            this.txtFolioNotaVenta.Size = new System.Drawing.Size(148, 26);
            this.txtFolioNotaVenta.TabIndex = 1;
            this.txtFolioNotaVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFolioNotaVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioNotaVenta_KeyPress);
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Blue;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(24, 26);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(149, 18);
            this.label37.TabIndex = 0;
            this.label37.Text = "NOTA DE VENTA N°";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVerificaCredito
            // 
            this.btnVerificaCredito.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificaCredito.Location = new System.Drawing.Point(721, 68);
            this.btnVerificaCredito.Name = "btnVerificaCredito";
            this.btnVerificaCredito.Size = new System.Drawing.Size(32, 21);
            this.btnVerificaCredito.TabIndex = 39;
            this.btnVerificaCredito.Text = "VC";
            this.btnVerificaCredito.UseVisualStyleBackColor = true;
            this.btnVerificaCredito.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "UsarFactura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelZonaCliente
            // 
            this.panelZonaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panelZonaCliente.Controls.Add(this.txtCreditoDisponible);
            this.panelZonaCliente.Controls.Add(this.txtRut);
            this.panelZonaCliente.Controls.Add(this.label38);
            this.panelZonaCliente.Controls.Add(this.txtDigito);
            this.panelZonaCliente.Controls.Add(this.btnBuscaCliente);
            this.panelZonaCliente.Controls.Add(this.txtRazonSocial);
            this.panelZonaCliente.Controls.Add(this.label21);
            this.panelZonaCliente.Controls.Add(this.label4);
            this.panelZonaCliente.Controls.Add(this.txtDiasPlazo);
            this.panelZonaCliente.Controls.Add(this.label5);
            this.panelZonaCliente.Controls.Add(this.txtContacto);
            this.panelZonaCliente.Controls.Add(this.txtDireccion);
            this.panelZonaCliente.Controls.Add(this.label12);
            this.panelZonaCliente.Controls.Add(this.txtComuna);
            this.panelZonaCliente.Controls.Add(this.label11);
            this.panelZonaCliente.Controls.Add(this.txtFax);
            this.panelZonaCliente.Controls.Add(this.txtCiudad);
            this.panelZonaCliente.Controls.Add(this.label10);
            this.panelZonaCliente.Controls.Add(this.txtGiro);
            this.panelZonaCliente.Controls.Add(this.label9);
            this.panelZonaCliente.Controls.Add(this.txtFono);
            this.panelZonaCliente.Controls.Add(this.btnVerificaCredito);
            this.panelZonaCliente.Controls.Add(this.label8);
            this.panelZonaCliente.Controls.Add(this.label7);
            this.panelZonaCliente.Controls.Add(this.label6);
            this.panelZonaCliente.Location = new System.Drawing.Point(12, 78);
            this.panelZonaCliente.Name = "panelZonaCliente";
            this.panelZonaCliente.Size = new System.Drawing.Size(761, 93);
            this.panelZonaCliente.TabIndex = 42;
            // 
            // btnModificaLinea
            // 
            this.btnModificaLinea.Image = global::Aptusoft.Properties.Resources.modificalista_32;
            this.btnModificaLinea.Location = new System.Drawing.Point(903, 254);
            this.btnModificaLinea.Name = "btnModificaLinea";
            this.btnModificaLinea.Size = new System.Drawing.Size(40, 40);
            this.btnModificaLinea.TabIndex = 33;
            this.btnModificaLinea.UseVisualStyleBackColor = true;
            this.btnModificaLinea.Click += new System.EventHandler(this.btnModificaLinea_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Aptusoft.Properties.Resources.construccion_de_anadir_icono_5620_32;
            this.btnAgregar.Location = new System.Drawing.Point(903, 174);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Tag = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiaDetalle
            // 
            this.btnLimpiaDetalle.Image = global::Aptusoft.Properties.Resources.construccion_de_eliminar_icono_9418_32;
            this.btnLimpiaDetalle.Location = new System.Drawing.Point(903, 214);
            this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
            this.btnLimpiaDetalle.Size = new System.Drawing.Size(40, 40);
            this.btnLimpiaDetalle.TabIndex = 17;
            this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaDetalle.Click += new System.EventHandler(this.btnLimpiaDetalle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(11, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 46);
            this.panel3.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(11, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 95);
            this.panel4.TabIndex = 44;
            // 
            // btnComprobarFolio
            // 
            this.btnComprobarFolio.BackgroundImage = global::Aptusoft.Properties.Resources.comprobar_si_puede_icono_8214_48;
            this.btnComprobarFolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComprobarFolio.FlatAppearance.BorderSize = 0;
            this.btnComprobarFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobarFolio.Location = new System.Drawing.Point(903, 47);
            this.btnComprobarFolio.Name = "btnComprobarFolio";
            this.btnComprobarFolio.Size = new System.Drawing.Size(30, 30);
            this.btnComprobarFolio.TabIndex = 45;
            this.btnComprobarFolio.UseVisualStyleBackColor = true;
            this.btnComprobarFolio.Click += new System.EventHandler(this.btnComprobarFolio_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emision";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vencimiento";
            // 
            // dtpEmision
            // 
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(6, 29);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(104, 20);
            this.dtpEmision.TabIndex = 0;
            this.dtpEmision.ValueChanged += new System.EventHandler(this.dtpEmision_ValueChanged);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(113, 29);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(96, 20);
            this.dtpVencimiento.TabIndex = 1;
            // 
            // gbZonaFechas
            // 
            this.gbZonaFechas.Controls.Add(this.dtpVencimiento);
            this.gbZonaFechas.Controls.Add(this.dtpEmision);
            this.gbZonaFechas.Controls.Add(this.label2);
            this.gbZonaFechas.Controls.Add(this.label1);
            this.gbZonaFechas.Location = new System.Drawing.Point(11, 21);
            this.gbZonaFechas.Name = "gbZonaFechas";
            this.gbZonaFechas.Size = new System.Drawing.Size(214, 55);
            this.gbZonaFechas.TabIndex = 24;
            this.gbZonaFechas.TabStop = false;
            // 
            // btnCreaPdf
            // 
            this.btnCreaPdf.Location = new System.Drawing.Point(12, 638);
            this.btnCreaPdf.Name = "btnCreaPdf";
            this.btnCreaPdf.Size = new System.Drawing.Size(75, 23);
            this.btnCreaPdf.TabIndex = 46;
            this.btnCreaPdf.Text = "Crea Pdf";
            this.btnCreaPdf.UseVisualStyleBackColor = true;
            this.btnCreaPdf.Visible = false;
            this.btnCreaPdf.Click += new System.EventHandler(this.btnCreaPdf_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 638);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Crea Pdf";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frmFacturaElectronica
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(997, 667);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCreaPdf);
            this.Controls.Add(this.panelFolio);
            this.Controls.Add(this.btnComprobarFolio);
            this.Controls.Add(this.pnlCotizacionBuscar);
            this.Controls.Add(this.panelNotaVenta);
            this.Controls.Add(this.pnlBuscaClienteDes);
            this.Controls.Add(this.panelZonaCliente);
            this.Controls.Add(this.panelZonaDetalle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTipoDescuento);
            this.Controls.Add(this.btnModificaLinea);
            this.Controls.Add(this.txtSubTotalLinea);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiaDetalle);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvDatosVenta);
            this.Controls.Add(this.gbZonaTicket);
            this.Controls.Add(this.gbZonaOtros);
            this.Controls.Add(this.gbZonaFechas);
            this.Controls.Add(this.panel4);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFacturaElectronica";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura Electronica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFactura_FormClosing);
            this.Load += new System.EventHandler(this.frmFacturaElectronica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFactura_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            this.gbZonaOtros.ResumeLayout(false);
            this.gbZonaOtros.PerformLayout();
            this.panelZonaDetalle.ResumeLayout(false);
            this.panelZonaDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).EndInit();
            this.pnlBuscaClienteDes.ResumeLayout(false);
            this.panelFolio.ResumeLayout(false);
            this.panelFolio.PerformLayout();
            this.gbZonaTicket.ResumeLayout(false);
            this.gbZonaTicket.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencias)).EndInit();
            this.pnlCotizacionBuscar.ResumeLayout(false);
            this.pnlCotizacionBuscar.PerformLayout();
            this.panelNotaVenta.ResumeLayout(false);
            this.panelNotaVenta.PerformLayout();
            this.panelZonaCliente.ResumeLayout(false);
            this.panelZonaCliente.PerformLayout();
            this.gbZonaFechas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("E-FACTURA"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._anula = Convert.ToBoolean(usuarioVo.Anula);
          this._descuento = Convert.ToBoolean(usuarioVo.Descuento);
          this._cambioPrecio = Convert.ToBoolean(usuarioVo.CambioPrecio);
          this._caja = usuarioVo.IdCaja;
          this._bodega = usuarioVo.IdBodega;
          this._listaPrecio = usuarioVo.IdListaPrecio;
        }
      }
    }

    public void cargaOpcionesDocumentosInicio()
    {
      this.odVO = new OpcionesGenerales().rescataOpcionesDocumentosPorNombre("E-FACTURA");
      this.cargaOpcionesDocumentos();
    }

    public void cargaOpcionesDocumentos()
    {
      this.alertaStock = this.odVO.AlertaStockInsuficiente;
      this.impideVentasSinStock = this.odVO.ImpideVentasSinStock;
      this.numeroLineas = this.odVO.CantidadLineasDocumento;
      this.decimalesValoresVenta = this.odVO.DecimalesValorVenta.ToString();
      this.envioAutomaticoSii = this.odVO.EnvioAutomaticoSII;
      this._permisoMedioPago = this.odVO.MedioPago;
      this._permisoPemitirMedioPago = this.odVO.PermitirMedioPago == "1";
      this._opcionBusquedaRazonSocial = this.odVO.BusquedaRazonSocial;
    }

    private void cargaVendedores()
    {
      this.cmbVendedor.DataSource = (object) this.listaVendedores;
      this.cmbVendedor.ValueMember = "idVendedor";
      this.cmbVendedor.DisplayMember = "nombre";
      this.cmbVendedor.SelectedValue = (object) 0;
    }

    private void cargaVendedoresInicio()
    {
      this.listaVendedores = new Vendedor().listaVendedoresVenta();
    }

    private void cargaCentroCosto()
    {
      this.cmbCentroCosto.DataSource = (object) this.listaCentroCosto;
      this.cmbCentroCosto.ValueMember = "idCentroCosto";
      this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
      this.cmbCentroCosto.SelectedValue = (object) 0;
    }

    private void cargaCentroCostoInicio()
    {
      this.listaCentroCosto = new CentroCosto().listaCentroCostoVenta();
    }

    private void cargaMediosPagoInicio()
    {
      this.listaMediosPago = new MedioPago().listaMediosPagoVenta();
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) this.listaMediosPago;
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      if (this._permisoMedioPago.Equals("0"))
        this.cmbMedioPago.SelectedValue = (object) 0;
      else
        this.cmbMedioPago.Text = this._permisoMedioPago;
      if (this._permisoPemitirMedioPago)
        this.cmbMedioPago.Enabled = false;
      else
        this.cmbMedioPago.Enabled = true;
    }

    private void obtieneFolioFacturaDisponible()
    {
      int folio = new EFactura().numeroFactura(this._caja);
      this.txtNumeroDocumento.Text = folio.ToString();
      if (this.chkHistoricoVentas.Checked)
        return;
      string archivoCaf = new Caf().archivoCaf(33, folio);
      bool flag = true;
      SubeXMLToDb sube = new SubeXMLToDb();
      sube.RecuperaCaf("33", @"\CAF\");
      if (this.compruebaExisteArchivoCaf(archivoCaf))
      {
        if (archivoCaf.Length == 0)
        {
          int num = (int) MessageBox.Show("No hay folios CAF disponibles, debe solicitar a SII y cargar en sistema", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this._guarda = false;
          flag = false;
        }
        if (!this._guarda && flag)
        {
          this.cargaPermisos();
          if (this._guarda)
          {
            this.btnGuardar.Enabled = true;
            this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = true;
          }
          else
          {
            this.btnGuardar.Enabled = false;
            this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
          }
        }
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Archivo CAF en este PC, Debe solicitarlo al Administrador del Sistema, sin este archivo No podra Emitir documentos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this._guarda = false;
      }
    }

    private void CargaRuta()
    {
      try
      {
        DataSet dataSet = new DataSet("datos");
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        string filterExpression = "principal=1";
        DataRow[] dataRowArray = dataSet.Tables["conexion"].Select(filterExpression);
        string str = "";
        for (int index = 0; index < dataRowArray.Length; ++index)
          str = dataRowArray[index]["rutaElectronica"].ToString();
        this._rutaElectronica = str.Replace("\\", "\\\\") + "\\\\";
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Ruta " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private bool compruebaExisteArchivoCaf(string archivoCaf)
    {
      bool flag = false;
      if (File.Exists(this._rutaElectronica + "CAF\\E-Factura\\" + archivoCaf))
        flag = true;
      return flag;
    }

    private void cargaImpuestosInicio()
    {
      this.listaImpuestos = new Impuestos().listaImpuestos();
    }

    private void cargaImpuestos()
    {
      foreach (ImpuestoVO impuestoVo in this.listaImpuestos)
      {
        if (impuestoVo.IdImpuesto == 1)
        {
          this.lblCodImp1.Text = impuestoVo.CodigoImpuesto;
          this.lblImp1.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp1.Text = impuestoVo.PorcentajeImpuesto.ToString("N0");
        }
        if (impuestoVo.IdImpuesto == 2)
        {
          this.lblCodImp2.Text = impuestoVo.CodigoImpuesto;
          this.lblImp2.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp2.Text = impuestoVo.PorcentajeImpuesto.ToString("N0");
        }
        if (impuestoVo.IdImpuesto == 3)
        {
          this.lblCodImp3.Text = impuestoVo.CodigoImpuesto;
          this.lblImp3.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp3.Text = impuestoVo.PorcentajeImpuesto.ToString("N0");
        }
        if (impuestoVo.IdImpuesto == 4)
        {
          this.lblCodImp4.Text = impuestoVo.CodigoImpuesto;
          this.lblImp4.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp4.Text = impuestoVo.PorcentajeImpuesto.ToString("N0");
        }
        if (impuestoVo.IdImpuesto == 5)
        {
          this.lblCodImp5.Text = impuestoVo.CodigoImpuesto;
          this.lblImp5.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp5.Text = impuestoVo.PorcentajeImpuesto.ToString("N0");
        }
      }
    }

    private void cargaBodega()
    {
      this.cmbBodega.DataSource = (object) new CargaMaestros().cargaBodega();
      this.cmbBodega.ValueMember = "codigo";
      this.cmbBodega.DisplayMember = "descripcion";
      if (this._bodega == 0)
      {
        this.cmbBodega.Enabled = true;
        this.cmbBodega.SelectedValue = (object) 1;
        this._modBodega = true;
      }
      else
      {
        this.cmbBodega.Enabled = false;
        this.cmbBodega.SelectedValue = (object) this._bodega;
        this._modBodega = false;
      }
    }

    private void cargaListaPrecio()
    {
      this.cmbListaPrecio.DataSource = (object) new CargaMaestros().cargaListaPrecio();
      this.cmbListaPrecio.ValueMember = "codigo";
      this.cmbListaPrecio.DisplayMember = "descripcion";
      if (this._listaPrecio == 0)
      {
        this.cmbListaPrecio.Enabled = true;
        this.cmbListaPrecio.SelectedValue = (object) 1;
      }
      else
      {
        this.cmbListaPrecio.Enabled = false;
        this.cmbListaPrecio.SelectedValue = (object) this._listaPrecio;
      }
    }

    private void cargaIvaInicio()
    {
      Calculos calculos = new Calculos();
      this.ivaInicio = calculos._iva;
      this.verificaCreditoActivo = calculos._verificaCredito;
      this.impideVenta = calculos._impedirVentasSinCredito;
    }

    private void iniciaFormulario()
    {
      try
      {
        this.cargaIvaInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Porcentaje del Iva: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      try
      {
        this.cargaVendedoresInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Vendedores: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Close();
      }
      try
      {
        this.cargaCentroCostoInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Centro Costo: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Close();
      }
      try
      {
        this.cargaMediosPagoInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Medios de Pago: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Close();
      }
      try
      {
        this.cargaImpuestosInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Impuestos: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Close();
      }
      try
      {
        this.cargaOpcionesDocumentosInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Opciones de Documento: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.Close();
      }
    }

    public void iniciaVenta()
    {
        this.btnEnviar.Enabled = false;
      this.btnComprobarFolio.Visible = false;
      this.buscaOT = false;
      this.cargaMediosPago();
      this.cargaVendedores();
      this.cargaCentroCosto();
      this.cargaImpuestos();
      this.cargaBodega();
      this.cargaListaPrecio();
      this.codigoCliente = 0;
      this.cargaOpcionesDocumentos();
      this.txtPorIva.Text = this.ivaInicio.ToString("N0");
      this.btnCreaPdf.Visible = false;
      try
      {
        this.obtieneFolioFacturaDisponible();
        this.txtNumeroDocumento.Enabled = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar Folio: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this._timbre = "";
      if (!this.chkHistoricoVentas.Checked)
        this.chkHistoricoVentas.Visible = false;
      this.txtDiasPlazo.Text = "0";
      this.txtDiasPlazo.Enabled = false;
      this.dtpEmision.Value = DateTime.Today;
      this.dtpVencimiento.Value = DateTime.Today;
      this.panelFolio.Visible = false;
      this.txtOrdenCompra.Clear();
      this.txtRut.Clear();
      this.txtDigito.Clear();
      this.txtRazonSocial.Clear();
      this.txtRazonSocial.Enabled = true;
      this.txtDireccion.Clear();
      this.txtDireccion.Enabled = false;
      this.txtCiudad.Clear();
      this.txtCiudad.Enabled = false;
      this.txtComuna.Clear();
      this.txtComuna.Enabled = false;
      this.txtGiro.Clear();
      this.txtGiro.Enabled = false;
      this.txtFono.Clear();
      this.txtFono.Enabled = false;
      this.txtFax.Clear();
      this.txtFax.Enabled = false;
      this.txtContacto.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtPrecio.Clear();
      if (!this.chkCantidadFija.Checked)
        this.txtCantidad.Clear();
      this.txtDescuento.Clear();
      this.txtPorcDescuentoLinea.Clear();
      this.txtTotalLinea.Text = "0";
      this.btnModificaLinea.Visible = false;
      this.chkCantidadFija.Checked = false;
      this.txtTicket.Clear();
      this.txtSubTotal.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotalExento.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTotalImp1.Clear();
      this.txtTotalImp2.Clear();
      this.txtTotalImp3.Clear();
      this.txtTotalImp4.Clear();
      this.txtTotalImp5.Clear();
      this.txtObservaciones.Clear();
      this.txtGuias.Clear();
      this.pnlCotizacionBuscar.Visible = false;
      this.panelNotaVenta.Visible = false;
      this.txtFolioCotizacion.Clear();
      this.txtFolioNotaVenta.Clear();
      if (this._guarda)
      {
        this.btnGuardar.Enabled = true;
        this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = true;
      }
      else
      {
        this.btnGuardar.Enabled = false;
        this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
      }
      this.btnModificar.Enabled = false;
      this.btnAnular.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnImprime.Enabled = false;
      this.btnControlPago.Enabled = false;
      if (this._descuento)
      {
        this.txtPorcDescuentoLinea.Enabled = true;
        this.txtPorcDescuentoTotal.Enabled = true;
        this.txtDescuento.Enabled = true;
        this.txtTotalDescuento.Enabled = true;
      }
      else
      {
        this.txtPorcDescuentoLinea.Enabled = false;
        this.txtPorcDescuentoTotal.Enabled = false;
        this.txtDescuento.Enabled = false;
        this.txtTotalDescuento.Enabled = false;
      }
      if (this._cambioPrecio)
        this.txtPrecio.Enabled = true;
      else
        this.txtPrecio.Enabled = false;
      this.lblEstadoDocumento.Text = "";
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.Columns.Clear();
      this.creaColumnasDetalle();
      this.pnlBuscaClienteDes.Visible = false;
      this.creaColumnasBuscaClientes();
      this.idFactura = 0;
      this.idTicket = 0;
      this.hayTicket = false;
      this.hayGuia = false;
      this.hayCotizacion = false;
      this.hayNotaVenta = false;
      this.hayOT = false;
      this.hayNotaVentaMasiva = false;
      this.label35.Text = "GUIAS";
      this.valorCompra = new Decimal(0);
      this.lista.Clear();
      this._listaLote.Clear();
      this._listaLoteAntigua.Clear();
      this.listaAuxiliar.Clear();
      this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = true;
      this.limpiaEntradaDetalle();
      this.gbZonaTicket.TabIndex = 2;
      this.gbZonaOtros.TabIndex = 0;
      this.panelZonaCliente.TabIndex = 3;
      this.gbZonaFechas.TabIndex = 4;
      this.panelZonaDetalle.TabIndex = 5;
      this.txtTicket.Focus();
      this.txtCreditoDisponible.Clear();
      this.btnVerificaCredito.Enabled = false;
      this.impideVentaSinCredito = false;
      this.iniciaReferencia();
      this.listaReferencias.Clear();
      this.dgvReferencias.DataSource = (object) null;
    }

    private void creaColumnasDetalle()
    {
      this.dgvDatosVenta.AutoGenerateColumns = false;
      this.dgvDatosVenta.Columns.Add("Linea", "");
      this.dgvDatosVenta.Columns[0].DataPropertyName = "Linea";
      this.dgvDatosVenta.Columns[0].Width = 20;
      this.dgvDatosVenta.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[0].DefaultCellStyle.BackColor = Color.Lavender;
      this.dgvDatosVenta.Columns.Add("Codigo", "Codigo");
      this.dgvDatosVenta.Columns[1].DataPropertyName = "Codigo";
      this.dgvDatosVenta.Columns[1].Width = 100;
      this.dgvDatosVenta.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Descripcion", "Descripcion");
      this.dgvDatosVenta.Columns[2].DataPropertyName = "Descripcion";
      this.dgvDatosVenta.Columns[2].Width = 260;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("ValorVenta", "Precio");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "ValorVenta";
      this.dgvDatosVenta.Columns[3].Width = 80;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Cantidad", "Cantidad");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "Cantidad";
      this.dgvDatosVenta.Columns[4].Width = 80;
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Format = "N4";
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("PorcDescuento", "% Desc.");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "PorcDescuento";
      this.dgvDatosVenta.Columns[5].Width = 65;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Descuento", "$ Desc.");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "Descuento";
      this.dgvDatosVenta.Columns[6].Width = 70;
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Total", "Total");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "TotalLinea";
      this.dgvDatosVenta.Columns[7].Width = 90;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("SubTotal", "SubTotal");
      this.dgvDatosVenta.Columns[8].DataPropertyName = "SubTotalLinea";
      this.dgvDatosVenta.Columns[8].Width = 90;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[8].Visible = false;
      this.dgvDatosVenta.Columns.Add("TipoDescuento", "TipoDescuento");
      this.dgvDatosVenta.Columns[9].DataPropertyName = "TipoDescuento";
      this.dgvDatosVenta.Columns[9].Width = 90;
      this.dgvDatosVenta.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[9].Visible = false;
      this.dgvDatosVenta.Columns.Add("ListaPrecio", "ListaPrecio");
      this.dgvDatosVenta.Columns[10].DataPropertyName = "ListaPrecio";
      this.dgvDatosVenta.Columns[10].Width = 90;
      this.dgvDatosVenta.Columns[10].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[10].Visible = false;
      this.dgvDatosVenta.Columns.Add("Bodega", "Bodega");
      this.dgvDatosVenta.Columns[11].DataPropertyName = "Bodega";
      this.dgvDatosVenta.Columns[11].Width = 90;
      this.dgvDatosVenta.Columns[11].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[11].Visible = false;
      this.dgvDatosVenta.Columns.Add("FolioFactura", "FolioFactura");
      this.dgvDatosVenta.Columns[12].DataPropertyName = "FolioFactura";
      this.dgvDatosVenta.Columns[12].Width = 90;
      this.dgvDatosVenta.Columns[12].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[12].Visible = false;
      this.dgvDatosVenta.Columns.Add("IdFactura", "IdFactura");
      this.dgvDatosVenta.Columns[13].DataPropertyName = "IdFactura";
      this.dgvDatosVenta.Columns[13].Width = 90;
      this.dgvDatosVenta.Columns[13].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[13].Visible = false;
      DataGridViewButtonColumn viewButtonColumn1 = new DataGridViewButtonColumn();
      viewButtonColumn1.Name = "Eliminar";
      viewButtonColumn1.HeaderText = "Eliminar";
      viewButtonColumn1.UseColumnTextForButtonValue = true;
      viewButtonColumn1.Text = "X";
      viewButtonColumn1.Width = 50;
      viewButtonColumn1.DisplayIndex = 14;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn1);
      this.dgvDatosVenta.Columns.Add("IdImpuesto", "IdImpuesto");
      this.dgvDatosVenta.Columns[15].DataPropertyName = "IdImpuesto";
      this.dgvDatosVenta.Columns[15].Width = 90;
      this.dgvDatosVenta.Columns[15].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[15].Visible = false;
      this.dgvDatosVenta.Columns.Add("NetoLinea", "NetoLinea");
      this.dgvDatosVenta.Columns[16].DataPropertyName = "NetoLinea";
      this.dgvDatosVenta.Columns[16].Width = 90;
      this.dgvDatosVenta.Columns[16].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[16].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[16].Visible = false;
      this.dgvDatosVenta.Columns.Add("DescuentaInventario", "DescuentaInventario");
      this.dgvDatosVenta.Columns[17].DataPropertyName = "DescuentaInventario";
      this.dgvDatosVenta.Columns[17].Width = 90;
      this.dgvDatosVenta.Columns[17].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[17].Visible = false;
      this.dgvDatosVenta.Columns.Add("ValorCompra", "ValorCompra");
      this.dgvDatosVenta.Columns[18].DataPropertyName = "ValorCompra";
      this.dgvDatosVenta.Columns[18].Width = 90;
      this.dgvDatosVenta.Columns[18].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[18].Visible = false;
      this.dgvDatosVenta.Columns.Add("CodigoImpuesto", "CodigoImpuesto");
      this.dgvDatosVenta.Columns[19].DataPropertyName = "CodigoImpuesto";
      this.dgvDatosVenta.Columns[19].Width = 90;
      this.dgvDatosVenta.Columns[19].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[19].Visible = false;
      DataGridViewButtonColumn viewButtonColumn2 = new DataGridViewButtonColumn();
      viewButtonColumn2.Name = "Lote";
      viewButtonColumn2.HeaderText = "Lote";
      viewButtonColumn2.UseColumnTextForButtonValue = true;
      viewButtonColumn2.Text = "::";
      viewButtonColumn2.Width = 50;
      viewButtonColumn2.DisplayIndex = 20;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn2);
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modFacturaElectronica = 0;
      this.Dispose();
      this.Close();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modFacturaElectronica = 0;
      GC.Collect();
      GC.WaitForPendingFinalizers();
      this.Close();
      this.Dispose();
    }

    private void calculaTotalLinea()
    {
      
        Calculos calculos = new Calculos();
      int num1 = Convert.ToInt32(this.txtTipoDescuento.Text);
      Decimal num2 = new Decimal(0);
      Decimal num3 = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text.Trim()) : new Decimal(0);
      Decimal valor = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text.Trim()) : new Decimal(0);
      Decimal cant = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text.Trim()) : new Decimal(0);
      Decimal descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text.Trim()) : new Decimal(0);
      Decimal porDesc = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text.Trim()) : new Decimal(0);
      Decimal subTotal = calculos.subTotalLinea(valor, cant);
      

      if (num1 == 1)
        descuento = Convert.ToDecimal(calculos.descuentoValorLinea(porDesc, subTotal).ToString("N0"));
      if (num1 == 2)
      {
        porDesc = calculos.descuentoPorcentajeLinea(descuento, subTotal);
        descuento = calculos.descuentoValorLinea(porDesc, subTotal);
      }
      if (subTotal == new Decimal(0) || subTotal > descuento)
      {
        this.txtSubTotalLinea.Text = subTotal.ToString("N0");
       
        this.txtDescuento.Text = descuento.ToString("N" + this.decimalesValoresVenta);
        this.txtPorcDescuentoLinea.Text = porDesc.ToString("##");
        Decimal total = Convert.ToDecimal(calculos.totalLinea(subTotal, descuento).ToString("N" + this.decimalesValoresVenta));
        this.txtTotalLinea.Text = total.ToString("N0");

        #region Calcula Impuestos SI los precios de venta INCLUYEN IVA
       
            if (this.idImpuesto == 0)
                this.netoLinea = calculos.netoLinea(total, 0);
            if (this.idImpuesto == 1)
                this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
            if (this.idImpuesto == 2)
                this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
            if (this.idImpuesto == 3)
                this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
            if (this.idImpuesto == 4)
                this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
            if (this.idImpuesto == 5)
                this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
        #endregion

        
        if (!this.esExento)
          return;
        this.netoLinea = new Decimal(0);
      }
      else
      {
        int num4 = (int) MessageBox.Show("El Descuento debe ser Menor al Total!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtDescuento.Clear();
        this.txtPorcDescuentoLinea.Clear();
      }
    }

    private void porcentajeDescuento_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    public void llamaProductoCodigo(string cod, int bodega)
    {
        Calculos calculos = new Calculos();
      this.cmbBodega.SelectedValue = (object) bodega.ToString();
      this.noVender = 0;
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
      this.esExento = productoVo.Exento;
      if (productoVo.Codigo != null)
      {
        switch (bodega)
        {
          case 1:
            this.stock = productoVo.Bodega1;
            break;
          case 2:
            this.stock = productoVo.Bodega2;
            break;
          case 3:
            this.stock = productoVo.Bodega3;
            break;
          case 4:
            this.stock = productoVo.Bodega4;
            break;
          case 5:
            this.stock = productoVo.Bodega5;
            break;
          case 6:
            this.stock = productoVo.Bodega6;
            break;
          case 7:
            this.stock = productoVo.Bodega7;
            break;
          case 8:
            this.stock = productoVo.Bodega8;
            break;
          case 9:
            this.stock = productoVo.Bodega9;
            break;
          case 10:
            this.stock = productoVo.Bodega10;
            break;
          case 11:
            this.stock = productoVo.Bodega11;
            break;
          case 12:
            this.stock = productoVo.Bodega12;
            break;
          case 13:
            this.stock = productoVo.Bodega13;
            break;
          case 14:
            this.stock = productoVo.Bodega14;
            break;
          case 15:
            this.stock = productoVo.Bodega15;
            break;
          case 16:
            this.stock = productoVo.Bodega16;
            break;
          case 17:
            this.stock = productoVo.Bodega17;
            break;
          case 18:
            this.stock = productoVo.Bodega18;
            break;
          case 19:
            this.stock = productoVo.Bodega19;
            break;
          case 20:
            this.stock = productoVo.Bodega20;
            break;
        }
        this.listaAuxiliar.Add(new ProductoAuxiliar()
        {
          Codigo = productoVo.Codigo,
          Bodega1 = productoVo.Bodega1,
          Bodega2 = productoVo.Bodega2,
          Bodega3 = productoVo.Bodega3,
          Bodega4 = productoVo.Bodega4,
          Bodega5 = productoVo.Bodega5,
          Bodega6 = productoVo.Bodega6,
          Bodega7 = productoVo.Bodega7,
          Bodega8 = productoVo.Bodega8,
          Bodega9 = productoVo.Bodega9,
          Bodega10 = productoVo.Bodega10,
          Bodega11 = productoVo.Bodega11,
          Bodega12 = productoVo.Bodega12,
          Bodega13 = productoVo.Bodega13,
          Bodega14 = productoVo.Bodega14,
          Bodega15 = productoVo.Bodega15,
          Bodega16 = productoVo.Bodega16,
          Bodega17 = productoVo.Bodega17,
          Bodega18 = productoVo.Bodega18,
          Bodega19 = productoVo.Bodega19,
          Bodega20 = productoVo.Bodega20
        });
        if (this.alertaStock.Equals("1"))
        {
          if (this.stock <= productoVo.StockMinimo)
          {
            int num = (int) MessageBox.Show("El Stock de este Producto esta Bajo el Stock Minimo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (this.impideVentasSinStock.Equals("1") && this.stock <= new Decimal(0))
              this.noVender = 1;
          }
          if (this.noVender == 0)
          {
            int num1 = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
            Decimal num2;
            if (num1 == 1)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta1;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            if (num1 == 2)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta2;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            if (num1 == 3)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta3;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            if (num1 == 4)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta4;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            if (num1 == 5)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta5;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            this.txtCodigo.Text = productoVo.Codigo;
            this.txtDescripcion.Text = productoVo.Descripcion;
            this.valorCompra = productoVo.ValorCompra;
            this.idImpuesto = productoVo.IdImpuesto;
            this.txtPrecio.Focus();
          }
          else
          {
            int num3 = (int) MessageBox.Show("No esta Autorizado para Vender Productos Sin Stock", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
        {
          int num1 = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
          Decimal num2;
          if (num1 == 1)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta1;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          if (num1 == 2)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta2;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          if (num1 == 3)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta3;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          if (num1 == 4)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta4;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          if (num1 == 5)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta5;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          this.txtCodigo.Text = productoVo.Codigo;
          this.txtDescripcion.Text = productoVo.Descripcion;
          this.idImpuesto = productoVo.IdImpuesto;
          this.valorCompra = productoVo.ValorCompra;
          this.txtPrecio.Focus();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe el Codigo Ingresado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCodigo.Clear();
        this.txtCodigo.Focus();
      }
    }

    public void cantidad()
    {
        this.txtCantidad.Text = "1";
    }

    public void agregaLineaGrilla()
    {
      if (this.noVender != 0)
        return;

      Calculos calculos = new Calculos();
      this.txtTotalDescuento.ReadOnly = true;
      this.txtPorcDescuentoTotal.ReadOnly = true;
      DatosVentaVO datosVentaVo = new DatosVentaVO();
      datosVentaVo.Codigo = this.txtCodigo.Text.Trim().ToUpper();
      datosVentaVo.Descripcion = this.txtDescripcion.Text.Trim();
      datosVentaVo.IdImpuesto = this.idImpuesto;
      datosVentaVo.Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
 
      
      if (this.idImpuesto > 0)
      {
        if (this.idImpuesto == 1)
          datosVentaVo.CodigoImpuesto = this.lblCodImp1.Text;
        if (this.idImpuesto == 2)
          datosVentaVo.CodigoImpuesto = this.lblCodImp2.Text;
        if (this.idImpuesto == 3)
          datosVentaVo.CodigoImpuesto = this.lblCodImp3.Text;
        if (this.idImpuesto == 4)
          datosVentaVo.CodigoImpuesto = this.lblCodImp4.Text;
        if (this.idImpuesto == 5)
          datosVentaVo.CodigoImpuesto = this.lblCodImp5.Text;
      }
      datosVentaVo.NetoLinea = this.netoLinea;
      datosVentaVo.DescuentaInventario = true;
      datosVentaVo.ValorCompra = this.valorCompra;
      datosVentaVo.ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
      
      if (datosVentaVo.Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && this.txtCodigo.Text.Length > 0)
      {
        int num = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Imposible Hacer Venta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtPrecio.Focus();
      }
      else
      {
        if (datosVentaVo.Cantidad > this.stock && this.alertaStock.Equals("1") && this.txtCodigo.Text.Length > 0)
        {
          int num1 = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        datosVentaVo.Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
        datosVentaVo.PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
        datosVentaVo.TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
        datosVentaVo.SubTotalLinea = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text) : new Decimal(0);
        datosVentaVo.TipoDescuento = Convert.ToInt32(this.txtTipoDescuento.Text);
        datosVentaVo.ListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
        datosVentaVo.Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        datosVentaVo.FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        datosVentaVo.Exento = this.esExento;
        if (this.lista.Count < Convert.ToInt32(this.numeroLineas))
        {
          if (this.lista.Count > 0)
          {
            bool flag = false;
            for (int index = 0; index < this.lista.Count; ++index)
            {
              if (datosVentaVo.Cantidad + this.lista[index].Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && datosVentaVo.Bodega == this.lista[index].Bodega && datosVentaVo.Codigo == this.lista[index].Codigo)
              {
                int num2 = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()));
                this.txtPrecio.Focus();
                flag = true;
              }
              else if (datosVentaVo.Codigo.Length > 0 && datosVentaVo.Codigo == this.lista[index].Codigo && (datosVentaVo.ValorVenta == this.lista[index].ValorVenta && datosVentaVo.ListaPrecio == this.lista[index].ListaPrecio) && datosVentaVo.Bodega == this.lista[index].Bodega && datosVentaVo.DescuentaInventario == this.lista[index].DescuentaInventario)
              {
                  //Esta bandera agrupa por ID
                flag = false;

                this.lista[index].Cantidad = this.lista[index].Cantidad;
                this.lista[index].PorcDescuento = new Decimal(0);
                Decimal cantidad = this.lista[index].Cantidad;
                Decimal valorVenta = this.lista[index].ValorVenta;
                Decimal num2 = new Decimal(0);
                Decimal descuento = this.lista[index].Descuento + datosVentaVo.Descuento;
                int tipoDescuento = this.lista[index].TipoDescuento;
                this.idImpuesto = Convert.ToInt32(this.lista[index].IdImpuesto.ToString());
                Decimal subTotal = calculos.subTotalLinea(valorVenta, cantidad);
                if (subTotal == new Decimal(0) || subTotal > descuento)
                {
                  this.lista[index].SubTotalLinea = subTotal;
                  this.lista[index].Descuento = descuento;
                  this.lista[index].TotalLinea = calculos.totalLinea(subTotal, descuento);
                  if (this.idImpuesto == 0)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, 0);
                  if (this.idImpuesto == 1)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 2)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 3)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 4)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 5)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  this.lista[index].NetoLinea = this.netoLinea;
                }
                else
                {
                  int num3 = (int) MessageBox.Show("El Descuento debe ser Menor al Total!!");
                }
                index = Enumerable.Count<DatosVentaVO>((IEnumerable<DatosVentaVO>) this.lista);
                this.limpiaEntradaDetalle();
                this.calculaTotales();
                this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
                this.esExento = false;
              }
            }
            if (!flag)
            {
              this.lista.Add(datosVentaVo);
              this.limpiaEntradaDetalle();
              this.calculaTotales();
              this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
              this.esExento = false;
            }
          }
          else
          {
            this.lista.Add(datosVentaVo);
            this.limpiaEntradaDetalle();
            this.calculaTotales();
            this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
            this.esExento = false;
          }
        }
        else
        {
          int num4 = (int) MessageBox.Show("Se Alcanzo el Maximo de Lineas Soportadas Por este Documento.");
        }
      }
    }

    private void calculaTotales()
    {
      

      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      bool flag5 = false;
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
      for (int index = 0; index < this.lista.Count; ++index)
      {
        this.lista[index].Linea = index + 1;
        if (this.lista[index].IdImpuesto == 1)
          flag1 = true;
        if (this.lista[index].IdImpuesto == 2)
          flag2 = true;
        if (this.lista[index].IdImpuesto == 3)
          flag3 = true;
        if (this.lista[index].IdImpuesto == 4)
          flag4 = true;
        if (this.lista[index].IdImpuesto == 5)
          flag5 = true;
      }
      Calculos calculos = new Calculos();
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      ArrayList arrayList = new ArrayList();
      if (flag1 || flag2 || (flag3 || flag4) || flag5)
        arrayList = calculos.totalImpuestos(this.lista);

      Decimal num5;

      if (flag1)
      {
            TextBox textBox = this.txtTotalImp1;
            num5 = Convert.ToDecimal(arrayList[0].ToString());
            string str = num5.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;        
      }
      else
      {
          this.txtTotalImp1.Text = "";
      }
      if (flag2)
      {
        TextBox textBox = this.txtTotalImp2;
        num5 = Convert.ToDecimal(arrayList[1].ToString());
        string str = num5.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp2.Text = "";
      if (flag3)
      {
        TextBox textBox = this.txtTotalImp3;
        num5 = Convert.ToDecimal(arrayList[2].ToString());
        string str = num5.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp3.Text = "";
      if (flag4)
      {
        TextBox textBox = this.txtTotalImp4;
        num5 = Convert.ToDecimal(arrayList[3].ToString());
        string str = num5.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp4.Text = "";
      if (flag5)
      {
        TextBox textBox = this.txtTotalImp5;
        num5 = Convert.ToDecimal(arrayList[4].ToString());
        string str = num5.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp5.Text = "";

      Decimal num6 = calculos.totalGeneralFacturaElectronica(this.lista);
      this.txtTotalGeneral.Text = num6.ToString("N0");
      this.txtTotalDescuento.Text = calculos.totalDescuentoFacturaElectronica(this.lista).ToString("N0");
      Decimal neto = calculos.totalNeto2(this.lista);
      TextBox textBox1 = this.txtSubTotal;
      num5 = calculos.totalSubTotalBoleta(this.lista);
      string str1 = num5.ToString("N" + this.decimalesValoresVenta);
      textBox1.Text = str1;
      TextBox textBox2 = this.txtIva;
      num5 = calculos.totalIva(neto);
      string str2 = num5.ToString("N" + this.decimalesValoresVenta);
      textBox2.Text = str2;
      this.txtNeto.Text = neto.ToString("N0");
      Decimal num7 = calculos.totalGeneralBoletaExento(this.lista);
      this.txtTotalExento.Text = num7.ToString("N0");
      this.txtTotalGeneral.Text = (num6 + num7).ToString("N0");
      
      
      
    }

    private void limpiaEntradaDetalle()
    {
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Enabled = true;
      this.btnLimpiaDetalle.Enabled = true;
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtPrecio.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      if (!this.chkCantidadFija.Checked)
        this.txtCantidad.Clear();
      this.txtDescuento.Clear();
      this.txtPorcDescuentoLinea.Clear();
      this.txtTotalLinea.Clear();
      this.txtCodigo.Focus();
      this.idImpuesto = 0;
      this.netoLinea = new Decimal(0);
      this.valorCompra = new Decimal(0);
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (caja.Text.Trim().Length == 0 && (int) e.KeyChar == 44)
        e.KeyChar = '0';
      if ((int) e.KeyChar == 8)
      {
        e.Handled = false;
      }
      else
      {
        bool flag = false;
        int num = 0;
        for (int index = 0; index < caja.Text.Length; ++index)
        {
          if ((int) caja.Text[index] == 44)
            flag = true;
          if (flag && num++ >= 4)
          {
            e.Handled = true;
            return;
          }
        }
        if ((int) e.KeyChar >= 48 && (int) e.KeyChar <= 57)
          e.Handled = false;
        else if ((int) e.KeyChar == 44)
          e.Handled = flag;
        else
          e.Handled = true;
      }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      try
      {
        this.agregaLineaGrilla();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error:" + ex.Message);
      }
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0)
        return;
      e.Handled = false;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
    }

    private void txtCodigo_Leave(object sender, EventArgs e)
    {
    }

    private void txtPrecio_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtCantidad_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
      //decimal odepa = this.calcularOdepa(Convert.ToInt32(txtCantidad.Text));

    }

    private void txtDescuento_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPrecio);
      if ((int) e.KeyChar != 13 || this.txtPrecio.Text.Length <= 0)
        return;
      this.txtCantidad.Focus();
    }

    private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidad);
      if ((int) e.KeyChar != 13 || this.txtCantidad.Text.Length <= 0)
        return;
      if (this.btnAgregar.Enabled)
        this.agregaLineaGrilla();
      if (this.btnModificaLinea.Visible)
        this.modificaLinea();
    }

    private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtDescuento);
      if ((int) e.KeyChar != 13)
        return;
      if (this.btnAgregar.Enabled)
        this.agregaLineaGrilla();
      if (this.btnModificaLinea.Visible)
        this.modificaLinea();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      this.veOBFactura = new Venta();
      this.iniciaVenta();
    }

    private void btnLimpiaDetalle_Click(object sender, EventArgs e)
    {
      this.dgvDatosVenta.DataSource = (object) null;
      this.lista.Clear();
      this.txtSubTotal.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTotalImp1.Clear();
      this.txtTotalImp2.Clear();
      this.txtTotalImp3.Clear();
      this.txtTotalImp4.Clear();
      this.txtTotalImp5.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      this.txtTotalExento.Clear();
    }

    private void txtCantidad_Enter(object sender, EventArgs e)
    {
      if (!this.chkCantidadFija.Checked || this.txtCantidad.Text.Length <= 0 || this.txtDescripcion.Text.Length <= 0)
        return;
      this.agregaLineaGrilla();
    }

    private void chkCantidadFija_Click(object sender, EventArgs e)
    {
    }

    private void cmbVendedor_Enter(object sender, EventArgs e)
    {
    }

    private void cmbBodega_Enter(object sender, EventArgs e)
    {
      this.cargaBodega();
    }

    private void txtDigito_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtRut.Text.Length > 0)
      {
        this.buscaCliente();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar");
        this.txtRut.Focus();
      }
    }

    private void buscaCliente()
    {
      ArrayList arrayList = new ArrayList();
      ArrayList cli = new Cliente().buscaRutCliente(this.txtRut.Text.Trim());
      if (cli.Count > 1)
      {
        this.txtRazonSocial.Enabled = false;
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "factura_electronica").ShowDialog();
      }
      else if (cli.Count == 0)
      {
        if (MessageBox.Show("No Existe Cliente Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          new frmClientes(this.txtRut.Text.Trim(), this.txtDigito.Text.Trim()).Show();
        else
          this.iniciaVenta();
      }
      else
      {
        if (cli.Count != 1)
          return;
        foreach (ClienteVO clienteVo in cli)
          this.buscaClienteCodigo(clienteVo.Codigo);
        this.txtCodigo.Focus();
      }
    }

    public void buscaClienteCodigo(int cod)
    {
      ClienteVO clienteVo = new Cliente().buscaCodigoCliente(cod);
      this.codigoCliente = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      if (clienteVo.RazonSocial.Length > 100)
        clienteVo.RazonSocial = clienteVo.RazonSocial.Substring(0, 99);
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      if (clienteVo.Direccion.Length > 70)
        clienteVo.Direccion = clienteVo.Direccion.Substring(0, 69);
      this.txtDireccion.Text = clienteVo.Direccion;
      if (clienteVo.Comuna.Length > 20)
        clienteVo.Comuna = clienteVo.Comuna.Substring(0, 19);
      this.txtComuna.Text = clienteVo.Comuna;
      if (clienteVo.Ciudad.Length > 20)
        clienteVo.Ciudad = clienteVo.Ciudad.Substring(0, 19);
      this.txtCiudad.Text = clienteVo.Ciudad;
      if (clienteVo.Giro.Length > 40)
        clienteVo.Giro = clienteVo.Giro.Substring(0, 39);
      this.txtGiro.Text = clienteVo.Giro;
      this.txtFono.Text = clienteVo.Telefono;
      this.txtFax.Text = clienteVo.EmailContacto;
      this.txtContacto.Text = clienteVo.Contacto;
      this.txtDiasPlazo.Text = clienteVo.DiasPlazo;
      this.cmbListaPrecio.SelectedValue = (object) clienteVo.ListaPrecio;
      if (clienteVo.IdMedioPago > 0)
        this.cmbMedioPago.SelectedValue = (object) clienteVo.IdMedioPago;
      if (clienteVo.Estado == 1)
      {
        int num = (int) MessageBox.Show("Cliente BLOQUEADO por: " + clienteVo.MotivoBloqueo + "\r\nSolo podra efecturar pagos en: " + this.cmbMedioPago.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      this.calculaFechaVencimiento(Convert.ToInt32(clienteVo.DiasPlazo));
      this.txtCodigo.Focus();
      if (!this.verificaCreditoActivo)
        return;
      this.verificaCredito();
    }

    private void calculaFechaVencimiento(int dias)
    {
      this.dtpVencimiento.Value = this.dtpEmision.Value.AddDays((double) dias);
    }

    private void dtpEmision_ValueChanged(object sender, EventArgs e)
    {
      this.calculaFechaVencimiento(Convert.ToInt32(this.txtDiasPlazo.Text.Trim()));
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "factura_electronica").ShowDialog();
    }

    private void txtRazonSocial_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRazonSocial.Text.Trim().Length > 0 && this.txtRut.Text.Trim().Length == 0)
      {
        this.pnlBuscaClienteDes.Visible = true;
        List<ClienteVO> list = new Cliente().buscaClienteDato(Convert.ToInt32(this._opcionBusquedaRazonSocial), this.txtRazonSocial.Text.Trim());
        if (list.Count <= 0)
          return;
        this.dgvBuscaCliente.DataSource = (object) list;
      }
      else
        this.pnlBuscaClienteDes.Visible = false;
    }

    private void creaColumnasBuscaClientes()
    {
      this.dgvBuscaCliente.Columns.Clear();
      this.dgvBuscaCliente.AutoGenerateColumns = false;
      this.dgvBuscaCliente.Columns.Add("Codigo", "Cod.");
      this.dgvBuscaCliente.Columns[0].DataPropertyName = "Codigo";
      this.dgvBuscaCliente.Columns[0].Width = 35;
      this.dgvBuscaCliente.Columns[0].Visible = false;
      this.dgvBuscaCliente.Columns.Add("Rut", "Rut");
      this.dgvBuscaCliente.Columns[1].DataPropertyName = "Rut";
      this.dgvBuscaCliente.Columns[1].Width = 70;
      this.dgvBuscaCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaCliente.Columns.Add("Digito", "");
      this.dgvBuscaCliente.Columns[2].DataPropertyName = "Digito";
      this.dgvBuscaCliente.Columns[2].Width = 20;
      this.dgvBuscaCliente.Columns.Add("RazonSocial", "Razon Social");
      this.dgvBuscaCliente.Columns[3].DataPropertyName = "RazonSocial";
      this.dgvBuscaCliente.Columns[3].Width = 280;
      this.dgvBuscaCliente.Columns.Add("NomFantasia", "N. Fantasia");
      this.dgvBuscaCliente.Columns[4].DataPropertyName = "NomFantasia";
      this.dgvBuscaCliente.Columns[4].Width = 230;
      this.dgvBuscaCliente.Columns.Add("Direccion", "Direccion");
      this.dgvBuscaCliente.Columns[5].DataPropertyName = "Direccion";
      this.dgvBuscaCliente.Columns[5].Width = 230;
    }

    private void dgvBuscaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
    {
      if (!this.pnlBuscaClienteDes.Visible || e.KeyCode != Keys.Down)
        return;
      this.dgvBuscaCliente.Focus();
    }

    private void dgvBuscaCliente_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void txtRut_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtDigito.Focus();
    }

    private void frmFactura_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modFacturaElectronica = 0;
    }

    private void guardaFactura()
    {
      if (!this.validaCampos())
        return;
      
      
      venta.Caja = this._caja;
      venta.FechaEmision = Convert.ToDateTime(dtpEmision.Value.ToString("yyyy-MM-dd HH:mm:ss"));
      venta.FechaVencimiento = Convert.ToDateTime(dtpVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
      venta.FechaModificacion = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
      venta.IdCliente = this.codigoCliente;
      venta.Rut = this.txtRut.Text.Trim();
      venta.Digito = this.txtDigito.Text.Trim();
      venta.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
      venta.Direccion = this.txtDireccion.Text.Trim().ToUpper();
      venta.Comuna = this.txtComuna.Text.Trim().ToUpper();
      venta.Ciudad = this.txtCiudad.Text.Trim().ToUpper();
      venta.Giro = this.txtGiro.Text.Trim().ToUpper();
      venta.Fono = this.txtFono.Text.Trim();
      venta.Fax = this.txtFax.Text.Trim();
      venta.Contacto = this.txtContacto.Text.Trim().ToUpper();
      venta.DiasPlazo = Convert.ToInt32(this.txtDiasPlazo.Text.Trim());
      if (this.cmbMedioPago.SelectedValue.ToString() != "0")
      {
        venta.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        venta.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
      }
      if (this.cmbVendedor.SelectedValue != null)
      {
        if (this.cmbVendedor.SelectedValue.ToString() != "0")
        {
          venta.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
          venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
          foreach (VendedorVO vendedorVo in this.listaVendedores)
          {
            if (venta.IdVendedor == vendedorVo.IdVendedor)
              venta.ComisionVendedor = vendedorVo.Comision;
          }
        }
      }
      else if (this.cmbVendedor.Text != "[SELECCIONE]")
        venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
      if (this.cmbCentroCosto.SelectedValue != null)
      {
        if (this.cmbCentroCosto.SelectedValue.ToString() != "0")
        {
          venta.IdCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
          venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
        }
      }
      else if (this.cmbCentroCosto.Text != "[SELECCIONE]")
        venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
      venta.OrdenCompra = this.txtOrdenCompra.Text.Trim();
      venta.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
      venta.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
      venta.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
      venta.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
      venta.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
      venta.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
      venta.TotalExento = this.txtTotalExento.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text.Trim()) : new Decimal(0);
      venta.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
      NumeroaLetra numeroaLetra = new NumeroaLetra();
      venta.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
      if (this.hayGuia)
        venta.FolioGuias = this.txtGuias.Text.Trim();
      if (this.hayNotaVentaMasiva)
        venta.FolioNotaVentaMasivas = this.txtGuias.Text.Trim();
      //venta.Observaciones = this.txtObservaciones.Text.Trim();
      if (this.hayTicket)
      {
        venta.FolioTicket = this.veOBFactura.Folio;
        venta.IdTicket = this.idFactura;
      }
      else
      {
        venta.FolioTicket = 0;
        venta.IdTicket = 0;
      }
      if (this.hayCotizacion)
      {
        venta.FolioCotizacion = this.veOBFactura.Folio;
        venta.IdCotizacion = this.idFactura;
      }
      else
      {
        venta.FolioCotizacion = 0;
        venta.IdCotizacion = 0;
      }
      if (this.hayNotaVenta)
      {
        venta.FolioNotaVenta = this.veOBFactura.Folio;
        venta.IdNotaVenta = this.idFactura;
      }
      else
      {
        venta.FolioNotaVenta = 0;
        venta.IdNotaVenta = 0;
      }
      venta.FolioOT = !this.hayOT ? 0 : this.veOBFactura.Folio;
      venta.CodImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? this.lblCodImp1.Text : "0";
      venta.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
      venta.CodImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? this.lblCodImp2.Text : "0";
      venta.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
      venta.CodImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? this.lblCodImp3.Text : "0";
      venta.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
      venta.CodImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? this.lblCodImp4.Text : "0";
      venta.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
      venta.CodImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? this.lblCodImp5.Text : "0";
      venta.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
      if (this.listaReferencias.Count > 0)
      {
        int num = 1;
        foreach (ReferenicaVO referenicaVo in this.listaReferencias)
        {
          if (num == 1)
          {
            venta.FE_tipoDocumento1 = referenicaVo.TipoDocumento;
            venta.FE_tipoDocumentoNombre1 = referenicaVo.TipoDocumentoNombre;
            venta.FE_folioDocumentoReferencia1 = referenicaVo.FolioDocumentoReferencia;
            venta.FE_fechaDocumentoReferencia1 = referenicaVo.FechaDocumentoReferencia;
            venta.FE_tipoAccion1 = referenicaVo.TipoAccion;
            venta.FE_tipoAccionNombre1 = referenicaVo.TipoAccionNombre;
            venta.FE_razonReferencia1 = referenicaVo.RazonReferencia;
          }
          if (num == 2)
          {
            venta.FE_tipoDocumento2 = referenicaVo.TipoDocumento;
            venta.FE_tipoDocumentoNombre2 = referenicaVo.TipoDocumentoNombre;
            venta.FE_folioDocumentoReferencia2 = referenicaVo.FolioDocumentoReferencia;
            venta.FE_fechaDocumentoReferencia2 = referenicaVo.FechaDocumentoReferencia;
            venta.FE_tipoAccion2 = referenicaVo.TipoAccion;
            venta.FE_tipoAccionNombre2 = referenicaVo.TipoAccionNombre;
            venta.FE_razonReferencia2 = referenicaVo.RazonReferencia;
          }
          if (num == 3)
          {
            venta.FE_tipoDocumento3 = referenicaVo.TipoDocumento;
            venta.FE_tipoDocumentoNombre3 = referenicaVo.TipoDocumentoNombre;
            venta.FE_folioDocumentoReferencia3 = referenicaVo.FolioDocumentoReferencia;
            venta.FE_fechaDocumentoReferencia3 = referenicaVo.FechaDocumentoReferencia;
            venta.FE_tipoAccion3 = referenicaVo.TipoAccion;
            venta.FE_tipoAccionNombre3 = referenicaVo.TipoAccionNombre;
            venta.FE_razonReferencia3 = referenicaVo.RazonReferencia;
          }
          if (num == 4)
          {
            venta.FE_tipoDocumento4 = referenicaVo.TipoDocumento;
            venta.FE_tipoDocumentoNombre4 = referenicaVo.TipoDocumentoNombre;
            venta.FE_folioDocumentoReferencia4 = referenicaVo.FolioDocumentoReferencia;
            venta.FE_fechaDocumentoReferencia4 = referenicaVo.FechaDocumentoReferencia;
            venta.FE_tipoAccion4 = referenicaVo.TipoAccion;
            venta.FE_tipoAccionNombre4 = referenicaVo.TipoAccionNombre;
            venta.FE_razonReferencia4 = referenicaVo.RazonReferencia;
          }
          if (num == 5)
          {
            venta.FE_tipoDocumento5 = referenicaVo.TipoDocumento;
            venta.FE_tipoDocumentoNombre5 = referenicaVo.TipoDocumentoNombre;
            venta.FE_folioDocumentoReferencia5 = referenicaVo.FolioDocumentoReferencia;
            venta.FE_fechaDocumentoReferencia5 = referenicaVo.FechaDocumentoReferencia;
            venta.FE_tipoAccion5 = referenicaVo.TipoAccion;
            venta.FE_tipoAccionNombre5 = referenicaVo.TipoAccionNombre;
            venta.FE_razonReferencia5 = referenicaVo.RazonReferencia;
          }
          ++num;
        }
      }
      int num1 = 0;
      foreach (MedioPagoVO medioPagoVo in this.listaMediosPago)
      {
        if (venta.IdMedioPago == medioPagoVo.IdMedioPago)
          num1 = Convert.ToInt32(medioPagoVo.Liquida);
      }
      if (num1 == 1)
      {
        venta.EstadoPago = "PAGADO";
        venta.TotalPagado = venta.Total;
        venta.TotalDocumentado = new Decimal(0);
        venta.TotalPendiente = new Decimal(0);
      }
      else
      {
        venta.EstadoPago = "PENDIENTE";
        venta.TotalPagado = new Decimal(0);
        venta.TotalDocumentado = new Decimal(0);
        venta.TotalPendiente = venta.Total;
        if (this.verificaCreditoActivo)
        {
          if (Convert.ToDecimal(this.txtCreditoDisponible.Text) < Convert.ToDecimal(this.txtTotalGeneral.Text))
          {
            if (this.impideVenta)
            {
              this.impideVentaSinCredito = true;
            }
            else
            {
              this.impideVentaSinCredito = false;
              int num2 = (int) MessageBox.Show("El Cliente No tiene Credito Disponible para la Actual Venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
          }
          else
            this.impideVentaSinCredito = false;
        }
      }
      if (!this.impideVentaSinCredito)
      {
        venta.EstadoDocumento = "EMITIDA";
        EFactura efactura = new EFactura();
        bool flag = efactura.facturaExiste(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()));
        if (flag)
        {
         // int num2 = (int) MessageBox.Show("Ya Existe una Factura con el N°: " + this.txtNumeroDocumento.Text + " Debe Modificar el Folio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.txtNumeroDocumento.Enabled = false;
          Decimal aux = Decimal.Add( Convert.ToDecimal( efactura.UltimoFolio()),1);
          this.txtNumeroDocumento.Text = aux.ToString();//se setea el folio para esta factura
          //this.txtNumeroDocumento.Focus();
          this.btnGuardar.Focus();
          this.btnGuardar.PerformClick();
          limpiar = false;//variable que genera limpiesa del formulario
        }
        if (!flag)
        {
          venta.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
          for (int index = 0; index < this.lista.Count; ++index)
          {
            if (index == 0)
              venta.IT1 = this.lista[index].Descripcion;
            this.lista[index].FolioFactura = venta.Folio;
            this.lista[index].FechaIngreso = venta.FechaEmision;
            this.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
          }
          if (this.chkHistoricoVentas.Checked)
            venta.FE_enviado_Sii = true;
          efactura.agregaFactura(venta);
          efactura.agregaDetalleFactura(this.lista, this._listaLote);
          if (this.listaReferencias.Count > 0)
            efactura.agregaReferencia(this.listaReferencias);
          this.creaXML(venta, this.lista);
          
          if (MessageBox.Show("¿Desea crear PDF?", "PDF", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
          {
              this.creaPDF();
          }
          this.cambiaEstadoTicket();
          this.cambiaEstadoGuia(venta);
          this.cambiaEstadoCotizacion();
          this.cambiaEstadoNotaVenta();
          this.cambiaEstadoOT();
          this.cambiaEstadoNotaVentaMasiva(venta);
          if (num1 == 1)
          {
            PagoVenta pagoVenta = new PagoVenta();
            PagoVentaVO pvVO = new PagoVentaVO();
            pvVO.FechaCobro = venta.FechaEmision;
            pvVO.IdFormaPago = venta.IdMedioPago;
            pvVO.FormaPago = venta.MedioPago;
            pvVO.Monto = venta.Total;
            pvVO.Estado = "PAGADO";
            pvVO.TipoPago = "MP";
            int idDoc = efactura.RetornaIdFactura(venta.Folio);
            pagoVenta.agregarPagoVenta(pvVO, "FACTURA_ELECTRONICA", idDoc, venta.Folio, venta.FechaEmision);
          }
          int folio = Convert.ToInt32(this.txtNumeroDocumento.Text);
          int codCli = this.codigoCliente;
          SubeXMLToDb sube = new SubeXMLToDb();
          sube.Sube("Factura_electronica", venta.Folio.ToString(), @"DTE\\E-Factura\\", "EFactura_" + folio.ToString("##"));
          limpiar = true;
          if (this.envioAutomaticoSii.Equals("1") && !this.chkHistoricoVentas.Checked && MessageBox.Show("¿ Desea Enviar el DTE a SII ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            string ruta = this._rutaElectronica + "DTE\\E-Factura\\";
           new frmEnviosSII("EFactura_" + folio.ToString("##") + "_" + str + "_envio.XML", ruta, new List<Venta>()
            {
              new Venta()
              {
                Folio = folio,
                Fe_TipoDTE = 33
              }
            }, "ENVIO").ShowDialog();
          }
          //if (MessageBox.Show("¿Desea Enviar DTE al contrbuyente vía e-Mail?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          //{
          //    creaPDF();
          //    envio(venta);
          //}
          if (!this.chkHistoricoVentas.Checked)
            this.imprimeFactura(folio);
          if (num1 == 0 && MessageBox.Show("¿ Desea Ingresar el detalle del Pago ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.pagarFactura(folio, codCli);
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("El Cliente No tiene Credito Disponible para la Actual Venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        int num3 = (int) new frmMuestraCredito(this.codigoCliente).ShowDialog();
      }

      if (limpiar)
      {
          this.iniciaVenta();
      }
    }

    private void envio(Venta ve)
    {
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        string archivo = "EFactura_" + ve.Folio.ToString("##") + "_" + str;
        string ruta_xml = this._rutaElectronica + @"DTE\E-Factura\" + archivo + "_envio_Contribuyente.xml";
        string ruta_pdf = this._rutaElectronica + @"PDF\E-Factura\"+archivo+".pdf";
        Attachment xml; Attachment pdf;
        try
        {
            xml = new Attachment(ruta_xml, MediaTypeNames.Application.Octet);
            pdf = new Attachment(ruta_pdf, MediaTypeNames.Application.Octet);

            new Correo(xml, pdf, ruta_pdf, ruta_xml, ve).ShowDialog();
        }catch(Exception ex)
        {
            MessageBox.Show("Error al intentar cargar las rutas de Archivos, más info", "Error 33,4591-4595", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
   
    private void creaXML(Venta ve, List<DatosVentaVO> listaDetalle)
    {
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      if (this.chkHistoricoVentas.Checked) return;
      ve.Fe_TipoDTE = 33;
      ve.Fe_FchEmis = ve.FechaEmision.ToString("yyyy-MM-dd");
      GeneradorXML generadorXml = new GeneradorXML();
      int tipoDescuento = 0;
      foreach (DatosVentaVO datosVentaVo in listaDetalle)
      {
        if (datosVentaVo.PorcDescuento > new Decimal(0) || datosVentaVo.Descuento > new Decimal(0))
          tipoDescuento = 1;
      }
      if (tipoDescuento == 0)
      {
        if (this.txtPorcDescuentoTotal.Text.Trim().Length > 0 && this.txtPorcDescuentoTotal.Text.Trim() != "0")
          tipoDescuento = 2;
        else if (this.txtTotalDescuento.Text.Trim().Length > 0 && this.txtTotalDescuento.Text.Trim() != "0")
          tipoDescuento = 3;
      }
      generadorXml.armaXML(ve, listaDetalle, this.listaReferencias, tipoDescuento);
      this.armaCodigoPDF417("EFactura_" + ve.Folio.ToString("##")+"_"+str);
      // "EFactura_" + ve.Folio.ToString("##") + "_" + str+"_";
    }

    private void creaXMLCliente(Venta ve, List<DatosVentaVO> listaDetalle)
    {
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        if (this.chkHistoricoVentas.Checked) return;
        ve.Fe_TipoDTE = 33;
        ve.Fe_FchEmis = ve.FechaEmision.ToString("yyyy-MM-dd");
        GeneradorXML generadorXml = new GeneradorXML();
        int tipoDescuento = 0;
        foreach (DatosVentaVO datosVentaVo in listaDetalle)
        {
            if (datosVentaVo.PorcDescuento > new Decimal(0) || datosVentaVo.Descuento > new Decimal(0))
                tipoDescuento = 1;
        }
        if (tipoDescuento == 0)
        {
            if (this.txtPorcDescuentoTotal.Text.Trim().Length > 0 && this.txtPorcDescuentoTotal.Text.Trim() != "0")
                tipoDescuento = 2;
            else if (this.txtTotalDescuento.Text.Trim().Length > 0 && this.txtTotalDescuento.Text.Trim() != "0")
                tipoDescuento = 3;
        }
        generadorXml.armaXMLCliente(ve, listaDetalle, this.listaReferencias, tipoDescuento);
        this.armaCodigoPDF417("EFactura_" + ve.Folio.ToString("##") + "_" + str + "_envio_Contribuyente");
        // "EFactura_" + ve.Folio.ToString("##") + "_" + str+"_";
    }

    private void imprimeFactura(int folio)
    {
      if (!this.chkHistoricoVentas.Checked)
      {
        //if (MessageBox.Show("Desea Imprimir la Factura?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          this.imprimeDirecto();
        //else
        //  this.iniciaVenta();
      }
      else
        this.iniciaVenta();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaFactura();
    }

    private void guardarFacturaTeclaF2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.guardaFactura();
    }

    private void cambiaEstadoTicket()
    {
      if (!this.hayTicket)
        return;
      Ticket ticket = new Ticket();
      string str = "FACTURA";
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBFactura.IDDocumentoVenta = new Factura().RetornaIdFactura(this.veOBFactura.FolioDocumentoVenta);
      this.veOBFactura.DocumentoVenta = str;
      ticket.modificaTipoDocumentoTicket(this.veOBFactura);
    }

    private void cambiaEstadoTicketEliminaFactura()
    {
      if (!this.hayTicket)
        return;
      Ticket ticket = new Ticket();
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      Factura factura = new Factura();
      this.veOBFactura.IDDocumentoVenta = 0;
      this.veOBFactura.FolioDocumentoVenta = 0;
      this.veOBFactura.DocumentoVenta = "";
      this.veOBFactura.IdFactura = this.veOBFactura.IdTicket;
      this.veOBFactura.Folio = this.veOBFactura.FolioTicket;
      ticket.modificaTipoDocumentoTicket(this.veOBFactura);
    }

    private void txtDescuento_Enter(object sender, EventArgs e)
    {
      if (this.txtPrecio.Text.Length > 0 && this.txtCantidad.Text.Length > 0)
      {
        this.txtTipoDescuento.Text = "2";
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos antes de hacer un Descuento");
        this.txtPrecio.Focus();
      }
    }

    private void txtPorcDescuentoLinea_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPorcDescuentoLinea);
      if ((int) e.KeyChar != 13)
        return;
      if (this.btnAgregar.Enabled)
        this.agregaLineaGrilla();
      if (this.btnModificaLinea.Visible)
        this.modificaLinea();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      DialogResult dialogResult = MessageBox.Show("Esta Seguro de Modificar la Factura ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      
      if (dialogResult == DialogResult.Yes)
      {
        if (!this.validaCampos())
          return;
        Venta venta = new Venta();
        venta.IdFactura = this.idFactura;
        venta.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        venta.FechaEmision = Convert.ToDateTime(dtpEmision.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.FechaVencimiento = Convert.ToDateTime(dtpVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.FechaModificacion = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.IdCliente = this.codigoCliente;
        venta.Rut = this.txtRut.Text.Trim();
        venta.Digito = this.txtDigito.Text.Trim();
        venta.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
        venta.Direccion = this.txtDireccion.Text.Trim().ToUpper();
        venta.Comuna = this.txtComuna.Text.Trim().ToUpper();
        venta.Ciudad = this.txtCiudad.Text.Trim().ToUpper();
        venta.Giro = this.txtGiro.Text.Trim().ToUpper();
        venta.Fono = this.txtFono.Text.Trim();
        venta.Fax = this.txtFax.Text.Trim();
        venta.Contacto = this.txtContacto.Text.Trim().ToUpper();
        venta.DiasPlazo = Convert.ToInt32(this.txtDiasPlazo.Text.Trim());
        if (this.cmbMedioPago.SelectedValue.ToString() != "0")
        {
          venta.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
          venta.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
        }
        if (this.cmbVendedor.SelectedValue != null)
        {
          if (this.cmbVendedor.SelectedValue.ToString() != "0")
          {
            venta.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
            venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
            foreach (VendedorVO vendedorVo in this.listaVendedores)
            {
              if (venta.IdVendedor == vendedorVo.IdVendedor)
                venta.ComisionVendedor = vendedorVo.Comision;
            }
          }
          else if (this.cmbVendedor.Text != "[SELECCIONE]")
            venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
        }
        if (this.cmbCentroCosto.SelectedValue != null)
        {
          if (this.cmbCentroCosto.SelectedValue.ToString() != "0")
          {
            venta.IdCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
            venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
          }
          else if (this.cmbCentroCosto.Text != "[SELECCIONE]")
            venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
        }
        venta.OrdenCompra = this.txtOrdenCompra.Text.Trim();
        venta.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
        venta.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        venta.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
        venta.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
        venta.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
        venta.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
        venta.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
        NumeroaLetra numeroaLetra = new NumeroaLetra();
        venta.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
        if (this.hayGuia)
          venta.FolioGuias = this.txtGuias.Text.Trim();
        if (this.hayNotaVentaMasiva)
          venta.FolioNotaVentaMasivas = this.txtGuias.Text.Trim();
        //venta.Observaciones = this.txtObservaciones.Text.Trim();
        venta.CodImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? this.lblCodImp1.Text : "0";
        venta.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
        venta.CodImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? this.lblCodImp2.Text : "0";
        venta.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
        venta.CodImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? this.lblCodImp3.Text : "0";
        venta.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
        venta.CodImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? this.lblCodImp4.Text : "0";
        venta.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
        venta.CodImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? this.lblCodImp5.Text : "0";
        venta.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
        if (this.listaReferencias.Count > 0)
        {
          int num = 1;
          foreach (ReferenicaVO referenicaVo in this.listaReferencias)
          {
            if (num == 1)
            {
              venta.FE_tipoDocumento1 = referenicaVo.TipoDocumento;
              venta.FE_tipoDocumentoNombre1 = referenicaVo.TipoDocumentoNombre;
              venta.FE_folioDocumentoReferencia1 = referenicaVo.FolioDocumentoReferencia;
              venta.FE_fechaDocumentoReferencia1 = referenicaVo.FechaDocumentoReferencia;
              venta.FE_tipoAccion1 = referenicaVo.TipoAccion;
              venta.FE_tipoAccionNombre1 = referenicaVo.TipoAccionNombre;
              venta.FE_razonReferencia1 = referenicaVo.RazonReferencia;
            }
            if (num == 2)
            {
              venta.FE_tipoDocumento2 = referenicaVo.TipoDocumento;
              venta.FE_tipoDocumentoNombre2 = referenicaVo.TipoDocumentoNombre;
              venta.FE_folioDocumentoReferencia2 = referenicaVo.FolioDocumentoReferencia;
              venta.FE_fechaDocumentoReferencia2 = referenicaVo.FechaDocumentoReferencia;
              venta.FE_tipoAccion2 = referenicaVo.TipoAccion;
              venta.FE_tipoAccionNombre2 = referenicaVo.TipoAccionNombre;
              venta.FE_razonReferencia2 = referenicaVo.RazonReferencia;
            }
            if (num == 3)
            {
              venta.FE_tipoDocumento3 = referenicaVo.TipoDocumento;
              venta.FE_tipoDocumentoNombre3 = referenicaVo.TipoDocumentoNombre;
              venta.FE_folioDocumentoReferencia3 = referenicaVo.FolioDocumentoReferencia;
              venta.FE_fechaDocumentoReferencia3 = referenicaVo.FechaDocumentoReferencia;
              venta.FE_tipoAccion3 = referenicaVo.TipoAccion;
              venta.FE_tipoAccionNombre3 = referenicaVo.TipoAccionNombre;
              venta.FE_razonReferencia3 = referenicaVo.RazonReferencia;
            }
            if (num == 4)
            {
              venta.FE_tipoDocumento4 = referenicaVo.TipoDocumento;
              venta.FE_tipoDocumentoNombre4 = referenicaVo.TipoDocumentoNombre;
              venta.FE_folioDocumentoReferencia4 = referenicaVo.FolioDocumentoReferencia;
              venta.FE_fechaDocumentoReferencia4 = referenicaVo.FechaDocumentoReferencia;
              venta.FE_tipoAccion4 = referenicaVo.TipoAccion;
              venta.FE_tipoAccionNombre4 = referenicaVo.TipoAccionNombre;
              venta.FE_razonReferencia4 = referenicaVo.RazonReferencia;
            }
            if (num == 5)
            {
              venta.FE_tipoDocumento5 = referenicaVo.TipoDocumento;
              venta.FE_tipoDocumentoNombre5 = referenicaVo.TipoDocumentoNombre;
              venta.FE_folioDocumentoReferencia5 = referenicaVo.FolioDocumentoReferencia;
              venta.FE_fechaDocumentoReferencia5 = referenicaVo.FechaDocumentoReferencia;
              venta.FE_tipoAccion5 = referenicaVo.TipoAccion;
              venta.FE_tipoAccionNombre5 = referenicaVo.TipoAccionNombre;
              venta.FE_razonReferencia5 = referenicaVo.RazonReferencia;
            }
            ++num;
          }
        }
        int num1 = 0;
        foreach (MedioPagoVO medioPagoVo in this.listaMediosPago)
        {
          if (venta.IdMedioPago == medioPagoVo.IdMedioPago)
            num1 = Convert.ToInt32(medioPagoVo.Liquida);
        }
        PagoVentaVO pagoVentaVo;
        if (venta.Total != this.veOBFactura.Total)
        {
          if (num1 == 1)
          {
            venta.EstadoPago = "PAGADO";
            venta.TotalPagado = venta.Total;
            venta.TotalDocumentado = new Decimal(0);
            venta.TotalPendiente = new Decimal(0);
            PagoVenta pagoVenta = new PagoVenta();
            PagoVentaVO pvVO = new PagoVentaVO();
            pagoVenta.eliminaPagoVenta("FACTURA_ELECTRONICA", this.idFactura, venta.Folio);
            pvVO.FechaCobro = venta.FechaEmision;
            pvVO.IdFormaPago = venta.IdMedioPago;
            pvVO.FormaPago = venta.MedioPago;
            pvVO.Monto = venta.Total;
            pvVO.Estado = "PAGADO";
            pvVO.TipoPago = "MP";
            pagoVenta.agregarPagoVenta(pvVO, "FACTURA_ELECTRONICA", this.idFactura, venta.Folio, venta.FechaEmision);
          }
          else
          {
            venta.EstadoPago = "PENDIENTE";
            venta.TotalPagado = new Decimal(0);
            venta.TotalDocumentado = new Decimal(0);
            venta.TotalPendiente = venta.Total;
            PagoVenta pagoVenta = new PagoVenta();
            pagoVentaVo = new PagoVentaVO();
            pagoVenta.eliminaPagoVenta("FACTURA_ELECTRONICA", this.idFactura, venta.Folio);
          }
        }
        else if (Convert.ToInt32(this.cmbMedioPago.SelectedValue) == this.veOBFactura.IdMedioPago)
        {
          venta.EstadoPago = this.veOBFactura.EstadoPago;
          venta.TotalPagado = this.veOBFactura.TotalPagado;
          venta.TotalDocumentado = this.veOBFactura.TotalDocumentado;
          venta.TotalPendiente = this.veOBFactura.TotalPendiente;
        }
        else if (num1 == 1)
        {
          venta.EstadoPago = "PAGADO";
          venta.TotalPagado = venta.Total;
          venta.TotalDocumentado = new Decimal(0);
          venta.TotalPendiente = new Decimal(0);
          PagoVenta pagoVenta = new PagoVenta();
          PagoVentaVO pvVO = new PagoVentaVO();
          pagoVenta.eliminaPagoVenta("FACTURA_ELECTRONICA", this.idFactura, venta.Folio);
          pvVO.FechaCobro = venta.FechaEmision;
          pvVO.IdFormaPago = venta.IdMedioPago;
          pvVO.FormaPago = venta.MedioPago;
          pvVO.Monto = venta.Total;
          pvVO.Estado = "PAGADO";
          pagoVenta.agregarPagoVenta(pvVO, "FACTURA_ELECTRONICA", this.idFactura, venta.Folio, venta.FechaEmision);
        }
        else
        {
          venta.EstadoPago = "PENDIENTE";
          venta.TotalPagado = new Decimal(0);
          venta.TotalDocumentado = new Decimal(0);
          venta.TotalPendiente = venta.Total;
          PagoVenta pagoVenta = new PagoVenta();
          pagoVentaVo = new PagoVentaVO();
          pagoVenta.eliminaPagoVenta("FACTURA_ELECTRONICA", this.idFactura, venta.Folio);
        }
        EFactura efactura = new EFactura();
        for (int index = 0; index < this.lista.Count; ++index)
        {
          this.lista[index].FechaIngreso = venta.FechaEmision;
          this.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }
        string text = efactura.modificaFactura(venta, this.lista, this._listaLote, this._listaLoteAntigua);
        this.creaXML(venta, this.lista);
        if (MessageBox.Show("¿Desea Crear Archivo Pdf?", "Crear PDF", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            this.creaPDF();
        }
        int num2 = (int) MessageBox.Show(text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        int num3 = Convert.ToInt32(this.txtNumeroDocumento.Text);
        SubeXMLToDb sube = new SubeXMLToDb();
        if (sube.existe(num3.ToString("##"), "33"))
        {
            sube.Sube("Factura_electronica", venta.Folio.ToString(), @"DTE\\E-Factura\\", "EFactura_" + num3.ToString("##"));
        }
        else
        {
            sube.Actualizar("Factura_electronica", venta.Folio.ToString(), @"DTE\\E-Factura\\", "EFactura_" + num3.ToString("##"));
        }
       
        if (this.envioAutomaticoSii.Equals("1") && MessageBox.Show("¿ Desea Enviar el DTE a SII ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          string ruta = this._rutaElectronica + "DTE\\E-Factura\\";
          int num4 = (int) new frmEnviosSII("EFactura_" + num3.ToString("##") + "_" + str + "_envio.XML", ruta, new List<Venta>()
          {
            new Venta()
            {
              Folio = num3,
              Fe_TipoDTE = 33
            }
          }, "ENVIO").ShowDialog();
        }
        this.imprimeFactura(venta.Folio);
      }
      else
      {
        int num = (int) MessageBox.Show("La Factura NO fue Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
      }
    }

    private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Tab)
        return;
      this.txtPorcDescuentoLinea.Focus();
    }

    private void txtPorcDescuentoLinea_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Right)
        return;
      this.txtDescuento.Focus();
    }

    private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void cmbMedioPago_Enter(object sender, EventArgs e)
    {
    }

    private bool validaCampos()
    {
      if (this.cmbMedioPago.SelectedValue == null || this.cmbMedioPago.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona el Medio de Pago");
        this.cmbMedioPago.Focus();
        return false;
      }
      if (this.codigoCliente == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos del Cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtRut.Focus();
        return false;
      }
      if (this.txtRut.Text.Trim().Length == 0 || this.txtDigito.Text.Trim().Length == 0 || (this.txtRazonSocial.Text.Trim().Length == 0 || this.txtGiro.Text.Trim().Length == 0) || (this.txtDireccion.Text.Trim().Length == 0 || this.txtComuna.Text.Trim().Length == 0) || this.txtCiudad.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos del Cliente Obligatorios (Rut y digito, Razon social, Giro, Direccion, Comuna y ciudad )", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtRut.Focus();
        return false;
      }
      if (this.lista.Count == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos a Facturar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtCodigo.Focus();
        return false;
      }
      if (!(Convert.ToDecimal(this.txtTotalGeneral.Text) <= new Decimal(0)))
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Datos a Facturar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.txtCodigo.Focus();
      return false;
    }

    private void txtTotalDescuento_TextChanged(object sender, EventArgs e)
    {
      if (this.txtTotalDescuento.ReadOnly)
        return;
      Decimal num1 = new Decimal(0);
      bool flag = false;
      for (int index = 0; index < this.lista.Count; ++index)
      {
        if (this.lista[index].Descuento > new Decimal(0) || this.lista[index].PorcDescuento > new Decimal(0))
        {
          flag = true;
          num1 += this.lista[index].Descuento;
        }
      }
      if (flag && !this.txtTotalDescuento.ReadOnly)
      {
        if (MessageBox.Show("¿Hay Descuentos aplicados en la lista, Desea Eliminarlos e Ingresar un Descuento General?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          for (int index = 0; index < this.lista.Count; ++index)
          {
            this.lista[index].Descuento = new Decimal(0);
            this.lista[index].PorcDescuento = new Decimal(0);
            this.lista[index].TotalLinea = this.lista[index].ValorVenta * this.lista[index].Cantidad;
          }
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) this.lista;
          this.calculaTotales();
        }
        else
        {
          this.txtTotalDescuento.ReadOnly = true;
          this.txtTotalDescuento.Text = num1.ToString("N0");
        }
      }
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new Calculos().totalDescuentoGeneral(this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0), this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0));
      if (arrayList2.Count > 1)
      {
        Decimal num2 = Convert.ToDecimal(arrayList2[0].ToString());
        Decimal num3 = Convert.ToDecimal(arrayList2[1].ToString());
        Decimal num4 = Convert.ToDecimal(arrayList2[2].ToString());
        this.txtNeto.Text = num2.ToString("N" + this.decimalesValoresVenta);
        this.txtIva.Text = num3.ToString("N" + this.decimalesValoresVenta);
        Decimal num5 = this.txtTotalExento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text.Trim()) : new Decimal(0);
        if (num5 > new Decimal(0))
          num4 += num5;
        this.txtTotalGeneral.Text = num4.ToString("N" + this.decimalesValoresVenta);
      }
      else
      {
        int num2 = (int) MessageBox.Show("El Descuento NO debe ser Mayor al SubTotal");
        this.txtTotalDescuento.Text = "0";
        this.txtPorcDescuentoTotal.Clear();
      }
    }

    private void txtTotalDescuento_DoubleClick(object sender, EventArgs e)
    {
      if (this.txtTotalImp1.Text.Length != 0 || this.txtTotalImp2.Text.Length != 0 || (this.txtTotalImp3.Text.Length != 0 || this.txtTotalImp4.Text.Length != 0) || this.txtTotalImp5.Text.Length != 0)
        return;
      this.txtTotalDescuento.ReadOnly = false;
    }

    private void txtTotalDescuento_Leave(object sender, EventArgs e)
    {
      this.txtTotalDescuento.ReadOnly = true;
    }

    private void txtPorcDescuentoTotal_TextChanged(object sender, EventArgs e)
    {
      if (this.txtPorcDescuentoTotal.Text.Length > 0)
      {
        Calculos calculos = new Calculos();
        Decimal porcDesc = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        Decimal subtotal = this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0);
        Decimal num = calculos.porcentajeDescuento(subtotal, porcDesc);
        this.txtTotalDescuento.ReadOnly = false;
        this.txtTotalDescuento.Text = num.ToString("N0");
        this.txtTotalDescuento.ReadOnly = true;
      }
      else
      {
        this.txtTotalDescuento.ReadOnly = false;
        this.txtTotalDescuento.Clear();
        this.txtTotalDescuento.ReadOnly = true;
      }
    }

    private void btnModificaLinea_Click(object sender, EventArgs e)
    {
      this.modificaLinea();
    }

    private void modificaLinea()
    {
      if (this.comparaStock(Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()), Convert.ToDecimal(this.txtCantidad.Text.Trim().Length > 0 ? this.txtCantidad.Text : "0"), this.txtCodigo.Text.Trim()))
      {
        for (int index = 0; index < this.lista.Count; ++index)
        {
          if (this.lista[index].Linea == Convert.ToInt32(this.txtLinea.Text))
          {
            this.lista[index].Codigo = this.txtCodigo.Text;
            this.lista[index].Descripcion = this.txtDescripcion.Text;
            this.lista[index].ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
            this.lista[index].Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
            this.lista[index].TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
            this.lista[index].Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
            this.lista[index].PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
            this.lista[index].IdImpuesto = this.idImpuesto;
            this.lista[index].NetoLinea = this.netoLinea;
          }
        }
        this.dgvDatosVenta.DataSource = (object) null;
        this.dgvDatosVenta.DataSource = (object) this.lista;
        this.calculaTotales();
        this.limpiaEntradaDetalle();
      }
      else
      {
        int num = (int) MessageBox.Show("No Hay stock Suficiente", "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private bool comparaStock(int bodega, Decimal stockCompara, string cod)
    {
      if (this.impideVentasSinStock.Equals("1"))
      {
        for (int index = 0; index < this.listaAuxiliar.Count; ++index)
        {
          if (bodega == 1 && this.listaAuxiliar[index].Bodega1 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 2 && this.listaAuxiliar[index].Bodega2 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 3 && this.listaAuxiliar[index].Bodega3 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 4 && this.listaAuxiliar[index].Bodega4 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)) || (bodega == 5 && this.listaAuxiliar[index].Bodega5 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 6 && this.listaAuxiliar[index].Bodega6 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 7 && this.listaAuxiliar[index].Bodega7 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 8 && this.listaAuxiliar[index].Bodega8 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod))) || (bodega == 9 && this.listaAuxiliar[index].Bodega9 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 10 && this.listaAuxiliar[index].Bodega10 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 11 && this.listaAuxiliar[index].Bodega11 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 12 && this.listaAuxiliar[index].Bodega12 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)) || (bodega == 13 && this.listaAuxiliar[index].Bodega13 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 14 && this.listaAuxiliar[index].Bodega14 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 15 && this.listaAuxiliar[index].Bodega15 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 16 && this.listaAuxiliar[index].Bodega16 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)))) || (bodega == 17 && this.listaAuxiliar[index].Bodega17 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 18 && this.listaAuxiliar[index].Bodega18 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 19 && this.listaAuxiliar[index].Bodega19 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 20 && this.listaAuxiliar[index].Bodega20 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod))))
            return false;
        }
      }
      return true;
    }

    private void btnLimpiaLineaDetalle_Click(object sender, EventArgs e)
    {
      this.limpiaEntradaDetalle();
      this.chkCantidadFija.Checked = false;
    }

    private void txtPorcDescuentoLinea_Enter(object sender, EventArgs e)
    {
      if (this.txtPrecio.Text.Length > 0 && this.txtCantidad.Text.Length > 0)
      {
        this.txtTipoDescuento.Text = "1";
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos antes de hacer un Descuento");
        this.txtPrecio.Focus();
      }
    }

    private void frmFactura_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F4)
      {
        this.txtCodigo.Focus();
        int num = (int) new frmBuscaProductos("factura_electronica", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
        this.txtPrecio.Focus();
      }
      if (e.KeyCode == Keys.F6)
      {
        this.panelFolio.Visible = true;
        this.txtFolioBuscar.Focus();
      }
      if (e.KeyCode == Keys.F2 && this.btnGuardar.Enabled && this._guarda)
        this.guardaFactura();
      if (e.KeyCode == Keys.F5)
      {
        int num1 = (int) new frmVuelto(this.txtTotalGeneral.Text, ref this.intance, "factura_electronica").ShowDialog();
      }
      if (e.KeyCode != Keys.F12)
        return;
      this.btnCreaPdf.Visible = true;
      this.chkHistoricoVentas.Visible = true;
    }

    private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        int num = (int)new frmBuscaProductos("factura_electronica", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
        txtPrecio.Focus();
    }

    private string verificaDecimales(string cantidad)
    {
      int num = cantidad.ToString().IndexOf(',');
      string str = cantidad;
      if (num != -1)
      {
        string[] strArray = cantidad.Split(',');
        str = Convert.ToInt32(strArray[1]) <= 0 ? strArray[0] : cantidad;
      }
      return str;
    }

    private void dgvDatosVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.lista.Count <= 0)
        return;
      this.btnModificaLinea.Visible = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiaDetalle.Enabled = false;
      this.chkCantidadFija.Checked = false;
      this.txtCodigo.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Codigo"].Value.ToString();
      this.txtDescripcion.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Descripcion"].Value.ToString();
      this.txtPrecio.Text = Convert.ToDecimal(this.dgvDatosVenta.SelectedRows[0].Cells["ValorVenta"].Value.ToString()).ToString("##");
      this.txtCantidad.Text = this.verificaDecimales(this.dgvDatosVenta.SelectedRows[0].Cells["Cantidad"].Value.ToString());
      this.txtDescuento.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Descuento"].Value.ToString();
      this.txtPorcDescuentoLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["PorcDescuento"].Value.ToString();
      this.txtSubTotalLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["SubTotal"].Value.ToString();
      this.txtTipoDescuento.Text = this.dgvDatosVenta.SelectedRows[0].Cells["TipoDescuento"].Value.ToString();
      this.txtLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Linea"].Value.ToString();
      this.cmbListaPrecio.SelectedValue = (object) this.dgvDatosVenta.SelectedRows[0].Cells["ListaPrecio"].Value.ToString();
      this.cmbBodega.SelectedValue = (object) this.dgvDatosVenta.SelectedRows[0].Cells["Bodega"].Value.ToString();
      this.idImpuesto = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells["IdImpuesto"].Value.ToString());
      this.netoLinea = Convert.ToDecimal(this.dgvDatosVenta.SelectedRows[0].Cells["NetoLinea"].Value.ToString());
    }

    private void cmbListaPrecio_SelectedValueChanged(object sender, EventArgs e)
    {
      if (!this.btnModificaLinea.Visible)
        return;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
    }

    private void cmbMedioPago_SelectedValueChanged(object sender, EventArgs e)
    {
    }

    private void txtNumeroDocumento_DoubleClick(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
    }

    private void lblFolio_DoubleClick(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Focus();
    }

    private void buscaFacturaFolio()
    {
        try
        {
            this.panelFolio.Visible = false;
            EFactura efactura = new EFactura();

            venta = efactura.buscaFacturaFolio(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));

            this.veOBFactura = venta;
            if (venta.IdFactura != 0)
            {
                this.iniciaVenta();
                this.btnEnviar.Enabled = true;
                this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = false;
                this.idFactura = venta.IdFactura;
                DateTimePicker dateTimePicker1 = this.dtpEmision;
                DateTime dateTime1 = venta.FechaEmision;
                DateTime dateTime2 = Convert.ToDateTime(dateTime1.ToString());
                dateTimePicker1.Value = dateTime2;
                DateTimePicker dateTimePicker2 = this.dtpVencimiento;
                dateTime1 = venta.FechaVencimiento;
                DateTime dateTime3 = Convert.ToDateTime(dateTime1.ToString());
                dateTimePicker2.Value = dateTime3;
                if (venta.IdMedioPago != 0)
                {
                    this.cmbMedioPago.SelectedValue = (object)venta.IdMedioPago.ToString();
                    this.cmbMedioPago.Text = venta.MedioPago.ToString();
                }
                if (venta.IdVendedor != 0)
                {
                    this.cmbVendedor.SelectedValue = (object)venta.IdVendedor.ToString();
                    this.cmbVendedor.Text = venta.Vendedor.ToString();
                }
                else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
                    this.cmbVendedor.Text = venta.Vendedor.ToString();
                if (venta.IdCentroCosto != 0)
                {
                    this.cmbCentroCosto.SelectedValue = (object)venta.IdCentroCosto.ToString();
                    this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
                }
                else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
                    this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
                this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
                this.txtNumeroDocumento.Text = venta.Folio.ToString();
                this.codigoCliente = venta.IdCliente;
                this.verificaCredito();
                this.txtRut.Text = venta.Rut;
                this.txtDigito.Text = venta.Digito;
                this.txtRazonSocial.Text = venta.RazonSocial.ToString();
                this.txtDireccion.Text = venta.Direccion.ToString();
                this.txtComuna.Text = venta.Comuna.ToString();
                this.txtCiudad.Text = venta.Ciudad.ToString();
                this.txtGiro.Text = venta.Giro.ToString();
                this.txtFono.Text = venta.Fono.ToString();
                this.txtFax.Text = venta.Fax.ToString();
                this.txtContacto.Text = venta.Contacto.ToString();
                this.txtDiasPlazo.Text = venta.DiasPlazo.ToString();
                this.txtSubTotal.Text = venta.SubTotal.ToString("N0");
                this.txtTotalDescuento.Text = venta.Descuento.ToString("N0");
                this.txtPorcDescuentoTotal.Text = venta.PorcentajeDescuento.ToString("N0");
                TextBox textBox1 = this.txtTotalDescuento;
                Decimal num = venta.Descuento;
                string str1 = num.ToString("N" + this.decimalesValoresVenta);
                textBox1.Text = str1;
                TextBox textBox2 = this.txtNeto;
                num = venta.Neto;
                string str2 = num.ToString("N" + this.decimalesValoresVenta);
                textBox2.Text = str2;
                TextBox textBox3 = this.txtIva;
                num = venta.Iva;
                string str3 = num.ToString("N" + this.decimalesValoresVenta);
                textBox3.Text = str3;
                TextBox textBox4 = this.txtPorIva;
                num = venta.PorcentajeIva;
                string str4 = num.ToString("N0");
                textBox4.Text = str4;
                TextBox textBox5 = this.txtTotalExento;
                num = venta.TotalExento;
                string str5 = num.ToString("N" + this.decimalesValoresVenta);
                textBox5.Text = str5;
                TextBox textBox6 = this.txtTotalGeneral;
                num = venta.Total;
                string str6 = num.ToString("N" + this.decimalesValoresVenta);
                textBox6.Text = str6;
                this.txtGuias.Text = venta.FolioGuias;
                //this.txtObservaciones.Text = venta.Observaciones;
                TextBox textBox7 = this.txtTotalImp1;
                num = venta.Impuesto1;
                string str7;
                if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
                {
                    num = venta.Impuesto1;
                    str7 = num.ToString("N" + this.decimalesValoresVenta);
                }
                else
                    str7 = "";
                textBox7.Text = str7;
                TextBox textBox8 = this.txtTotalImp2;
                num = venta.Impuesto2;
                string str8;
                if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
                {
                    num = venta.Impuesto2;
                    str8 = num.ToString("N" + this.decimalesValoresVenta);
                }
                else
                    str8 = "";
                textBox8.Text = str8;
                TextBox textBox9 = this.txtTotalImp3;
                num = venta.Impuesto3;
                string str9;
                if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
                {
                    num = venta.Impuesto3;
                    str9 = num.ToString("N" + this.decimalesValoresVenta);
                }
                else
                    str9 = "";
                textBox9.Text = str9;
                TextBox textBox10 = this.txtTotalImp4;
                num = venta.Impuesto4;
                string str10;
                if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
                {
                    num = venta.Impuesto4;
                    str10 = num.ToString("N" + this.decimalesValoresVenta);
                }
                else
                    str10 = "";
                textBox10.Text = str10;
                TextBox textBox11 = this.txtTotalImp5;
                num = venta.Impuesto5;
                string str11;
                if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
                {
                    num = venta.Impuesto5;
                    str11 = num.ToString("N" + this.decimalesValoresVenta);
                }
                else
                    str11 = "";
                textBox11.Text = str11;
                this._timbre = venta.Timbre;
                if (venta.IdTicket > 0)
                {
                    this.hayTicket = true;
                    this.txtTicket.Text = venta.FolioTicket.ToString();
                    this.idTicket = venta.IdTicket;
                }
                if (venta.IdCotizacion > 0)
                    this.hayCotizacion = true;
                if (venta.IdNotaVenta > 0)
                    this.hayNotaVenta = true;
                if (venta.FolioGuias.Length > 0)
                    this.hayGuia = true;
                if (venta.FolioOT > 0)
                    this.hayOT = true;
                if (venta.FolioNotaVentaMasivas.Length > 0)
                    this.hayNotaVentaMasiva = true;
                this.btnGuardar.Enabled = false;
                this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
                if (!venta.FE_enviado_Sii)
                {
                    if (this._elimina)
                        this.btnEliminar.Enabled = true;
                    if (this._modifica)
                        this.btnModificar.Enabled = true;
                }
                else
                {
                    this.btnEliminar.Enabled = false;
                    this.btnModificar.Enabled = false;
                }
                this.btnImprime.Enabled = true;
                this.btnControlPago.Enabled = true;
                this.lblEstadoDocumento.Text = venta.EstadoDocumento.ToString();
                this.lista = efactura.buscaDetalleFacturaIDFactura(venta.IdFactura);
                this.listaReferencias = efactura.buscaReferenciaIDFactura(venta.IdFactura);
                this.cmbBodega.SelectedValue = (object)this.lista[0].Bodega;
                for (int index = 0; index < this.lista.Count; ++index)
                {
                    this.lista[index].Linea = index + 1;
                    if (this.lista[index].IdImpuesto > 0)
                    {
                        if (this.lista[index].IdImpuesto == 1)
                            this.lista[index].CodigoImpuesto = this.lblCodImp1.Text;
                        if (this.lista[index].IdImpuesto == 2)
                            this.lista[index].CodigoImpuesto = this.lblCodImp2.Text;
                        if (this.lista[index].IdImpuesto == 3)
                            this.lista[index].CodigoImpuesto = this.lblCodImp3.Text;
                        if (this.lista[index].IdImpuesto == 4)
                            this.lista[index].CodigoImpuesto = this.lblCodImp4.Text;
                        if (this.lista[index].IdImpuesto == 5)
                            this.lista[index].CodigoImpuesto = this.lblCodImp5.Text;
                    }
                }
                this.dgvDatosVenta.DataSource = (object)null;
                this.dgvDatosVenta.DataSource = (object)this.lista;
                this.dgvReferencias.DataSource = (object)null;
                this.dgvReferencias.DataSource = (object)this.listaReferencias;
                this._listaLote.Clear();
                this._listaLote = new Lote().ListaLotePorDocumento("VENTA", "FACTURA ELECTRONICA", venta.IdFactura);
                this._listaLoteAntigua.Clear();
                if (this._listaLote.Count > 0)
                {
                    foreach (LoteVO loteVo in this._listaLote)
                        this._listaLoteAntigua.Add(loteVo);
                }
                this.txtFolioBuscar.Clear();
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe Factura Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtFolioBuscar.Clear();
                this.iniciaVenta();

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("ingrese Folio");
        }
    }

    private void btnBuscaFolio_Click(object sender, EventArgs e)
    {
      if (this.txtFolioBuscar.Text.Trim().Length > 0)
      {
        this.buscaFacturaFolio();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Folio a Buscar");
        this.txtFolioBuscar.Focus();
      }
    }

    private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioBuscar);
      if ((int) e.KeyChar != 13)
        return;
      this.buscaFacturaFolio();
    }

    private void btnCerrarPanelFolio_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = false;
      this.txtFolioBuscar.Clear();
    }

    private void buscarFacturaTeclaF6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Focus();
    }

    private void btnAnular_Click(object sender, EventArgs e)
    {
      if (this.lblEstadoDocumento.Text.Equals("EMITIDA"))
      {
        if (MessageBox.Show("Esta seguro de Anular esta Factura. Los productos seran retornados a Bodega", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          EFactura efactura = new EFactura();
          try
          {
            new PagoVenta().eliminaPagoVenta("FACTURA", this.idFactura, Convert.ToInt32(this.txtNumeroDocumento.Text));
            string text = efactura.anulaFactura(this.idFactura, this.lista);
            if (this.hayTicket)
              this.cambiaEstadoTicketEliminaFactura();
            if (this.hayGuia)
              this.cambiaEstadoGuiaEliminaFactura(this.veOBFactura);
            if (this.hayCotizacion)
              this.cambiaEstadoCotizacionEliminaFactura();
            if (this.hayNotaVenta)
              this.cambiaEstadoNotaVentaEliminaFactura();
            if (this.hayOT)
              this.cambiaEstadoOTEliminaFactura();
            int num = (int) MessageBox.Show(text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaVenta();
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show("Error al Anular Documento " + ex.Message);
          }
        }
        else
        {
          int num = (int) MessageBox.Show("La Factura NO fue Anulada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Este Documento ya Se encuentra Anulado!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar esta Factura.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        EFactura efactura = new EFactura();
        try
        {
          efactura.eliminaFactura(this.idFactura, this.lista, this._listaLoteAntigua);
          SubeXMLToDb sube = new SubeXMLToDb();
          sube.eliminar("Factura_electronica", this.lista[0].FolioFactura.ToString());
          if (this.hayTicket)
            this.cambiaEstadoTicketEliminaFactura();
          if (this.hayGuia)
            this.cambiaEstadoGuiaEliminaFactura(this.veOBFactura);
          if (this.hayCotizacion)
            this.cambiaEstadoCotizacionEliminaFactura();
          if (this.hayNotaVenta)
            this.cambiaEstadoNotaVentaEliminaFactura();
          if (this.hayNotaVentaMasiva)
            this.cambiaEstadoNotaVentaMasivaEliminaFactura(this.veOBFactura);
          int num = (int) MessageBox.Show("Factura Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar Documento " + ex.Message);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Factura NO fue Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
      }
    }

    private void btnImprime_Click(object sender, EventArgs e)

    {
        this.imprimeDirecto();
      //this.iniciaVenta();

        /////

    }
    private void imprimeDirecto()
    {      LeeXml leeXml = new LeeXml();
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = leeXml.cargarDatosMultiEmpresa("factura");
      string impresora = arrayList2[0].ToString();
      string str = arrayList2[1].ToString();
        
        if (MessageBox.Show("Imprimir Factura Electronica", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            EFactura efactura = new EFactura();
            DataTable dataTable = efactura.muestraFacturaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\AptuSoft\\reportes\\FacturaElectronica_"+str+".rpt");
            reportDocument.SetDataSource(dataTable);
            //string str = new LeeXml().cargarDatos("factura");
            try
            {
                reportDocument.PrintOptions.PrinterName = impresora;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Hay Impresora Selecionada", "Error", MessageBoxButtons.OK);
            }
            reportDocument.PrintToPrinter(1, false, 1, 1);
            reportDocument.Close();
        }

        if (MessageBox.Show("Imprimir Copia Cedible de Factura Electronica", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            EFactura efactura = new EFactura();
            DataTable dataTable = efactura.muestraFacturaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\AptuSoft\\reportes\\FacturaElectronicaCedible_"+str+".rpt");
            reportDocument.SetDataSource(dataTable);
            //string str = new LeeXml().cargarDatos("factura");
            try
            {
                reportDocument.PrintOptions.PrinterName = impresora;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Hay Impresora Selecionada", "Error", MessageBoxButtons.OK);
            }
            reportDocument.PrintToPrinter(1, false, 1, 1);
            reportDocument.Close();
        }
    }

    private void creaPDF()
    {
        try
        {
            if (this.chkHistoricoVentas.Checked)
                return;
            csCreaPDF csCreaPdf = new csCreaPDF();
            ArrayList arrayList = new ArrayList();
            string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
            string archivoRpt1;
            string archivoRpt2;
            if (frmMenuPrincipal._MultiEmpresa)
            {
                archivoRpt1 = "FacturaElectronica_" + str + ".rpt";
                archivoRpt2 = "FacturaElectronicaCedible_" + str + ".rpt";
            }
            else
            {
                archivoRpt1 = "FacturaElectronica_" + str + ".rpt";
                archivoRpt2 = "FacturaElectronicaCedible_" + str + ".rpt";
            }
            string nombre_archivo1 = "EFactura_" + this.txtNumeroDocumento.Text + "_" + str;
            int tipoDoc = 33;
            DataTable dt = new EFactura().muestraFacturaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            csCreaPdf.creaPDF(archivoRpt1, nombre_archivo1, tipoDoc, dt);
            string nombre_archivo2 = "EFacturaCedible_" + this.txtNumeroDocumento.Text + "_" + str;
            csCreaPdf.creaPDF(archivoRpt2, nombre_archivo2, tipoDoc, dt);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void multiEmpresa()
    {
      LeeXml leeXml = new LeeXml();
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = leeXml.cargarDatosMultiEmpresa("factura");
      arrayList2[0].ToString();
      string str = arrayList2[1].ToString();
      DataTable dataTable = new EFactura().muestraFacturaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
      ReportDocument rpt1 = new ReportDocument();
      rpt1.Load("C:\\AptuSoft\\reportes\\FacturaElectronica_" + str + ".rpt");
      rpt1.SetDataSource(dataTable);
      int num1 = (int) new frmVisualizadorReportes(rpt1).ShowDialog();
      ReportDocument rpt2 = new ReportDocument();
      rpt2.Load("C:\\AptuSoft\\reportes\\FacturaElectronicaCedible_" + str + ".rpt");
      rpt2.SetDataSource(dataTable);
      int num2 = (int) new frmVisualizadorReportes(rpt2).ShowDialog();
      this._timbre = string.Empty;
      this.iniciaVenta();
    }

    private void monoEmpresa()
    {      
        LeeXml leeXml = new LeeXml();
        ArrayList arrayList1 = new ArrayList();
        ArrayList arrayList2 = leeXml.cargarDatosMultiEmpresa("factura");
        arrayList2[0].ToString();
        string str = arrayList2[1].ToString();
      DataTable dataTable = new EFactura().muestraFacturaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
      ReportDocument rpt1 = new ReportDocument();
      rpt1.Load("C:\\AptuSoft\\reportes\\FacturaElectronica_"+str+".rpt");
      rpt1.SetDataSource(dataTable);
      int num1 = (int) new frmVisualizadorReportes(rpt1).ShowDialog();
      ReportDocument rpt2 = new ReportDocument();
      rpt2.Load("C:\\AptuSoft\\reportes\\FacturaElectronicaCedible_"+str+".rpt");
      rpt2.SetDataSource(dataTable);
      int num2 = (int) new frmVisualizadorReportes(rpt2).ShowDialog();
      this._timbre = string.Empty;
      this.iniciaVenta();
    }

    private void txtTotalDescuento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtTotalDescuento);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(this.veOBFactura.RazonSocial);
    }

    private void btnControlPago_Click(object sender, EventArgs e)
    {
      this.pagarFactura(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()), this.codigoCliente);
    }

    private void pagarFactura(int folio, int codCli)
    {
      int num = (int) new frmPagoVenta(ref this.intance, "FACTURA_ELECTRONICA", folio, codCli).ShowDialog();
      this.iniciaVenta();
    }

    private void dgvDatosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        int num = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells[0].Value.ToString());
        string str = "";
        for (int index = 0; index < this.lista.Count; ++index)
        {
          if (this.lista[index].Linea == num)
          {
            str = this.lista[index].Codigo;
            this.lista.RemoveAt(index);
            --index;
          }
        }
        this.calculaTotales();
        if (this._listaLote.Count > 0)
        {
          for (int index = 0; index < this._listaLote.Count; ++index)
          {
            if (this._listaLote[index].CodigoProducto == str)
            {
              this._listaLote.RemoveAt(index);
              --index;
            }
          }
        }
      }
      if (!(this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Lote"))
        return;
      string descrip = this.dgvDatosVenta.SelectedRows[0].Cells["descripcion"].Value.ToString();
      string str1 = this.dgvDatosVenta.SelectedRows[0].Cells["cantidad"].Value.ToString();
      string cod = this.dgvDatosVenta.SelectedRows[0].Cells["codigo"].Value.ToString();
      int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue);
      string text = this.cmbBodega.Text;
      Decimal cant = Convert.ToDecimal(str1);
      int num1 = (int) new frmLoteCompraVenta(cod, descrip, cant, bodega, text, this._listaLote, ref this.intance).ShowDialog();
    }

    private void txtDescripcion_Enter(object sender, EventArgs e)
    {
      if (this.txtCodigo.Text.Length <= 0 || this.txtDescripcion.Text.Length != 0)
        return;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
      this.txtCodigo.Focus();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void cambiarNumeroDeFolioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.btnComprobarFolio.Visible = true;
      this.txtNumeroDocumento.Enabled = true;
      this.txtNumeroDocumento.Focus();
    }

    private void txtTicket_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtTicket);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtTicket.Text.Length > 0)
        this.buscaTicketFolio();
    }

    private void buscaTicketFolio()
    {
      this.panelFolio.Visible = false;
      Ticket ticket = new Ticket();
      int numTicket = Convert.ToInt32(this.txtTicket.Text.Trim());
      try
      {
        Venta venta = ticket.buscaTicketFolio(numTicket);
        this.veOBFactura = venta;
        if (venta.IdFactura != 0)
        {
          if (venta.IDDocumentoVenta == 0)
          {
            this.iniciaVenta();
            this.txtTicket.Text = numTicket.ToString();
            this.idFactura = venta.IdFactura;
            this.dtpEmision.Value = Convert.ToDateTime(venta.FechaEmision.ToString());
            this.dtpVencimiento.Value = Convert.ToDateTime(venta.FechaVencimiento.ToString());
            if (venta.IdMedioPago != 0)
            {
              this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
              this.cmbMedioPago.Text = venta.MedioPago.ToString();
            }
            if (venta.IdVendedor != 0)
            {
              this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            }
            else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            if (venta.IdCentroCosto != 0)
            {
              this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            }
            else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
            this.codigoCliente = venta.IdCliente;
            this.verificaCredito();
            this.txtRut.Text = venta.Rut;
            this.txtDigito.Text = venta.Digito;
            this.txtRazonSocial.Text = venta.RazonSocial.ToString();
            this.txtDireccion.Text = venta.Direccion.ToString();
            this.txtComuna.Text = venta.Comuna.ToString();
            this.txtCiudad.Text = venta.Ciudad.ToString();
            this.txtGiro.Text = venta.Giro.ToString();
            this.txtFono.Text = venta.Fono.ToString();
            this.txtFax.Text = venta.Fax.ToString();
            this.txtContacto.Text = venta.Contacto.ToString();
            this.txtDiasPlazo.Text = venta.DiasPlazo.ToString();
            this.txtSubTotal.Text = venta.SubTotal.ToString("N0");
            TextBox textBox1 = this.txtTotalDescuento;
            Decimal num = venta.Descuento;
            string str1 = num.ToString("N0");
            textBox1.Text = str1;
            TextBox textBox2 = this.txtPorcDescuentoTotal;
            num = venta.PorcentajeDescuento;
            string str2 = num.ToString("N0");
            textBox2.Text = str2;
            TextBox textBox3 = this.txtTotalDescuento;
            num = venta.Descuento;
            string str3 = num.ToString("N0");
            textBox3.Text = str3;
            TextBox textBox4 = this.txtNeto;
            num = venta.Neto;
            string str4 = num.ToString("N0");
            textBox4.Text = str4;
            TextBox textBox5 = this.txtIva;
            num = venta.Iva;
            string str5 = num.ToString("N0");
            textBox5.Text = str5;
            TextBox textBox6 = this.txtPorIva;
            num = venta.PorcentajeIva;
            string str6 = num.ToString("N0");
            textBox6.Text = str6;
            TextBox textBox7 = this.txtTotalGeneral;
            num = venta.Total;
            string str7 = num.ToString("N0");
            textBox7.Text = str7;
            TextBox textBox8 = this.txtTotalImp1;
            num = venta.Impuesto1;
            string str8;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto1;
              str8 = num.ToString("N0");
            }
            else
              str8 = "";
            textBox8.Text = str8;
            TextBox textBox9 = this.txtTotalImp2;
            num = venta.Impuesto2;
            string str9;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto2;
              str9 = num.ToString("N0");
            }
            else
              str9 = "";
            textBox9.Text = str9;
            TextBox textBox10 = this.txtTotalImp3;
            num = venta.Impuesto3;
            string str10;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto3;
              str10 = num.ToString("N0");
            }
            else
              str10 = "";
            textBox10.Text = str10;
            TextBox textBox11 = this.txtTotalImp4;
            num = venta.Impuesto4;
            string str11;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto4;
              str11 = num.ToString("N0");
            }
            else
              str11 = "";
            textBox11.Text = str11;
            TextBox textBox12 = this.txtTotalImp5;
            num = venta.Impuesto5;
            string str12;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto5;
              str12 = num.ToString("N0");
            }
            else
              str12 = "";
            textBox12.Text = str12;
            this.hayTicket = true;
            this.lista = ticket.buscaDetalleTicketIDTicket(venta.IdFactura);
            for (int index = 0; index < this.lista.Count; ++index)
            {
              this.lista[index].Linea = index + 1;
              this.lista[index].FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
              this.lista[index].IdFactura = 0;
              this.lista[index].DescuentaInventario = true;
            }
            this.dgvDatosVenta.DataSource = (object) null;
            this.dgvDatosVenta.DataSource = (object) this.lista;
            this._listaLote.Clear();
            this._listaLote = new Lote().ListaLotePorDocumento("VENTA", "TICKET", venta.IdFactura);
            this._listaLoteAntigua.Clear();
            if (this._listaLote.Count <= 0)
              return;
            foreach (LoteVO loteVo in this._listaLote)
              this._listaLoteAntigua.Add(loteVo);
          }
          else
          {
            int num1 = (int) MessageBox.Show(string.Concat(new object[4]
            {
              (object) "Ticket ya Documentado en: ",
              (object) venta.DocumentoVenta,
              (object) " Folio N°: ",
              (object) venta.FolioDocumentoVenta
            }));
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("No Existe Ticket Consultado!!");
          this.iniciaVenta();
          this.txtTicket.Focus();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("error al llamar ticket " + ex.Message);
      }
    }

    private void txtPorcDescuentoTotal_DoubleClick(object sender, EventArgs e)
    {
      if (this.txtTotalImp1.Text.Length != 0 || this.txtTotalImp2.Text.Length != 0 || (this.txtTotalImp3.Text.Length != 0 || this.txtTotalImp4.Text.Length != 0) || this.txtTotalImp5.Text.Length != 0)
        return;
      this.txtPorcDescuentoTotal.ReadOnly = false;
    }

    private void txtPorcDescuentoTotal_Leave(object sender, EventArgs e)
    {
      this.txtPorcDescuentoTotal.ReadOnly = true;
    }

    private void listadoDeFacturasSegunFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLanzadorInformesVenta("Listado de Facturas Segun Fecha", "FACTURA001").Show();
    }

    private void listadoDeFacturasPorClienteSegunFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLanzadorInformesVenta("Listado de Facturas Por Cliente, Segun Fecha", "FACTURA002").Show();
    }

    private void listadoDeFacturasPorVendedorSegunFechaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLanzadorInformesVenta("Listado de Facturas Por Vendedor, Segun Fecha", "FACTURA003").Show();
    }

    private void guiasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmFacturaGuias(ref this.intance, "factura_electronica", "guias").ShowDialog();
    }

    public void facturaGuias(List<Venta> listaGuias)
    {

      this.lista.Clear();
      string str = "";
      int num = 0;
      EGuia eguia = new EGuia();
      foreach (Venta venta in listaGuias)
      {
        this.codigoCliente = venta.IdCliente;
        this.verificaCredito();
        foreach (DatosVentaVO dv in eguia.buscaDetalleGuiaIDGuia(venta.IdFactura))
        {
          dv.DescuentaInventario = false;
          dv.IdFactura = 0;
          dv.FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
          //this.agregaLineasDesdeGuias(dv);
        }
        str = num != 0 ? str + "-" + venta.Folio.ToString("N0") : str + venta.Folio.ToString("N0");
        ++num;
      }
      this.hayGuia = true;
      this.txtGuias.Text = str;
      this.buscaClienteCodigo(this.codigoCliente);
      //this.dgvDatosVenta.DataSource = (object) this.lista;
      //this.calculaTotales();
      this.armaReferenciaDeGuia();

      string glosa = "Factura Elect. segun Guias: ";
      int i = 0;
      decimal precio = 0;
      foreach (Venta venta in listaGuias)
      {
          
          glosa += "N" + listaGuias[i].Folio + ", ";
          precio = precio + listaGuias[i].SubTotal;
          i++;
      }

      glosa = glosa.Remove(glosa.Length - 2, 2);

      txtDescripcion.Text = glosa;
      txtPrecio.Text = precio.ToString();
      txtCantidad.Text = "1";
      

      this.agregaLineaGrilla();
    }

    private void agregaLineasDesdeGuias(DatosVentaVO dv)
    {
      if (this.lista.Count < Convert.ToInt32(this.numeroLineas))
      {
        if (this.lista.Count > 0)
        {
          bool flag = false;
          for (int index = 0; index < this.lista.Count; ++index)
          {
            if (dv.Codigo.Length > 0 && dv.Codigo == this.lista[index].Codigo && (dv.ValorVenta == this.lista[index].ValorVenta && dv.ListaPrecio == this.lista[index].ListaPrecio) && dv.Bodega == this.lista[index].Bodega)
            {
              flag = true;
              Calculos calculos = new Calculos();
              this.lista[index].Cantidad = this.lista[index].Cantidad + dv.Cantidad;
              this.lista[index].PorcDescuento = new Decimal(0);
              Decimal cantidad = this.lista[index].Cantidad;
              Decimal valorVenta = this.lista[index].ValorVenta;
              Decimal num = new Decimal(0);
              Decimal descuento = this.lista[index].Descuento + dv.Descuento;
              int tipoDescuento = this.lista[index].TipoDescuento;
              this.idImpuesto = Convert.ToInt32(this.lista[index].IdImpuesto.ToString());
              Decimal subTotal = calculos.subTotalLinea(valorVenta, cantidad);
              this.lista[index].SubTotalLinea = subTotal;
              this.lista[index].Descuento = descuento;
              this.lista[index].TotalLinea = calculos.totalLinea(subTotal, descuento);
              if (this.idImpuesto == 0)
                this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, 0);
              if (this.idImpuesto == 1)
                this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
              if (this.idImpuesto == 2)
                this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
              if (this.idImpuesto == 3)
                this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
              if (this.idImpuesto == 4)
                this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
              if (this.idImpuesto == 5)
                this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
              this.lista[index].NetoLinea = this.netoLinea;
              index = Enumerable.Count<DatosVentaVO>((IEnumerable<DatosVentaVO>) this.lista);
              this.limpiaEntradaDetalle();
              this.calculaTotales();
              this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
            }
          }
          if (flag)
            return;
          this.lista.Add(dv);
          this.calculaTotales();
        }
        else
        {
          this.lista.Add(dv);
          this.calculaTotales();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Se Alcanzo el Maximo de Lineas Soportadas Por este Documento.");
      }
    }

    private void armaReferenciaDeGuia()
    {
      this.listaReferencias.Add(new ReferenicaVO()
      {
        FolioDocumento = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()),
        TipoDocumento = 52,
        TipoDocumentoNombre = "GUIA DESPACHO ELECTRONICA M",
        FolioDocumentoReferencia = "0",
        FechaDocumentoReferencia = this.dtpEmision.Value,
        TipoAccion = 0,
        TipoAccionNombre = "",
        RazonReferencia = "",
        IndGlobal = 1
      });
      this.dgvReferencias.DataSource = (object) null;
      this.dgvReferencias.DataSource = (object) this.listaReferencias;
    }

    private void cambiaEstadoGuia(Venta ve)
    {
      if (!this.hayGuia)
        return;
      ve.Facturada = true;
      ve.DocumentoVenta = "FACTURA ELECTRONICA";
      EGuia eguia = new EGuia();
      try
      {
        eguia.facturaGuia(ve);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al facturar Guias: " + ex.Message);
      }
    }

    private void cambiaEstadoGuiaEliminaFactura(Venta ve)
    {
      if (!this.hayGuia)
        return;
      ve.Facturada = false;
      ve.Folio = 0;
      ve.DocumentoVenta = "";
      EGuia eguia = new EGuia();
      try
      {
        eguia.facturaGuia(ve);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al facturar Guias: " + ex.Message);
      }
    }

    private void btnSalirBuscaCoti_Click(object sender, EventArgs e)
    {
      this.pnlCotizacionBuscar.Visible = false;
      this.txtFolioCotizacion.Clear();
    }

    private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.label36.Text = "COTIZACIÓN N°";
      this.buscaOT = false;
      this.pnlCotizacionBuscar.Visible = true;
      this.txtFolioCotizacion.Focus();
    }

    private void buscaCotizacionFolio()
    {
      this.panelFolio.Visible = false;
      Cotizacion cotizacion = new Cotizacion();
      int numCotizacion = Convert.ToInt32(this.txtFolioCotizacion.Text.Trim());
      try
      {
        Venta venta = cotizacion.buscaCotizacionFolio(numCotizacion);
        this.veOBFactura = venta;
        if (venta.IdFactura != 0)
        {
          if (venta.IDDocumentoVenta == 0)
          {
            this.iniciaVenta();
            this.idFactura = venta.IdFactura;
            if (venta.IdMedioPago != 0)
            {
              this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
              this.cmbMedioPago.Text = venta.MedioPago.ToString();
            }
            if (venta.IdVendedor != 0)
            {
              this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            }
            else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            if (venta.IdCentroCosto != 0)
            {
              this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            }
            else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
            this.codigoCliente = venta.IdCliente;
            this.verificaCredito();
            this.txtRut.Text = venta.Rut;
            this.txtDigito.Text = venta.Digito;
            this.txtRazonSocial.Text = venta.RazonSocial.ToString();
            this.txtDireccion.Text = venta.Direccion.ToString();
            this.txtComuna.Text = venta.Comuna.ToString();
            this.txtCiudad.Text = venta.Ciudad.ToString();
            this.txtGiro.Text = venta.Giro.ToString();
            this.txtFono.Text = venta.Fono.ToString();
            this.txtFax.Text = venta.Fax.ToString();
            this.txtContacto.Text = venta.Contacto.ToString();
            TextBox textBox1 = this.txtDiasPlazo;
            int num1 = venta.DiasPlazo;
            string str1 = num1.ToString();
            textBox1.Text = str1;
            TextBox textBox2 = this.txtSubTotal;
            Decimal num2 = venta.SubTotal;
            string str2 = num2.ToString("N0");
            textBox2.Text = str2;
            TextBox textBox3 = this.txtTotalDescuento;
            num2 = venta.Descuento;
            string str3 = num2.ToString("N0");
            textBox3.Text = str3;
            TextBox textBox4 = this.txtPorcDescuentoTotal;
            num2 = venta.PorcentajeDescuento;
            string str4 = num2.ToString("N0");
            textBox4.Text = str4;
            TextBox textBox5 = this.txtTotalDescuento;
            num2 = venta.Descuento;
            string str5 = num2.ToString("N0");
            textBox5.Text = str5;
            TextBox textBox6 = this.txtNeto;
            num2 = venta.Neto;
            string str6 = num2.ToString("N0");
            textBox6.Text = str6;
            TextBox textBox7 = this.txtIva;
            num2 = venta.Iva;
            string str7 = num2.ToString("N0");
            textBox7.Text = str7;
            TextBox textBox8 = this.txtPorIva;
            num2 = venta.PorcentajeIva;
            string str8 = num2.ToString("N0");
            textBox8.Text = str8;
            TextBox textBox9 = this.txtTotalGeneral;
            num2 = venta.Total;
            string str9 = num2.ToString("N0");
            textBox9.Text = str9;
            TextBox textBox10 = this.txtTotalImp1;
            num2 = venta.Impuesto1;
            string str10;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto1;
              str10 = num2.ToString("N0");
            }
            else
              str10 = "";
            textBox10.Text = str10;
            TextBox textBox11 = this.txtTotalImp2;
            num2 = venta.Impuesto2;
            string str11;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto2;
              str11 = num2.ToString("N0");
            }
            else
              str11 = "";
            textBox11.Text = str11;
            TextBox textBox12 = this.txtTotalImp3;
            num2 = venta.Impuesto3;
            string str12;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto3;
              str12 = num2.ToString("N0");
            }
            else
              str12 = "";
            textBox12.Text = str12;
            TextBox textBox13 = this.txtTotalImp4;
            num2 = venta.Impuesto4;
            string str13;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto4;
              str13 = num2.ToString("N0");
            }
            else
              str13 = "";
            textBox13.Text = str13;
            TextBox textBox14 = this.txtTotalImp5;
            num2 = venta.Impuesto5;
            string str14;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto5;
              str14 = num2.ToString("N0");
            }
            else
              str14 = "";
            textBox14.Text = str14;
            this.hayCotizacion = true;
            //TextBox textBox15 = this.txtObservaciones;
            string str15 = "Cotizacion N°: ";
            num1 = venta.Folio;
            string str16 = num1.ToString();
            string str17 = str15 + str16;
            //textBox15.Text = str17;
            this.lista = cotizacion.buscaDetalleCotizacionIDCotizacion(venta.IdFactura);
            for (int index = 0; index < this.lista.Count; ++index)
            {
              this.lista[index].Linea = index + 1;
              this.lista[index].FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
              this.lista[index].IdFactura = 0;
              this.lista[index].DescuentaInventario = true;
            }
            this.dgvDatosVenta.DataSource = (object) null;
            this.dgvDatosVenta.DataSource = (object) this.lista;
            if (!this.verificaCreditoActivo)
              return;
            this.verificaCredito();
          }
          else
          {
            int num3 = (int) MessageBox.Show(string.Concat(new object[4]
            {
              (object) "Cotizacion ya Documentada en: ",
              (object) venta.DocumentoVenta,
              (object) " Folio N°: ",
              (object) venta.FolioDocumentoVenta
            }), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        else
        {
          int num1 = (int) MessageBox.Show("No Existe la Cotización Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al llamar Cotización " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void cambiaEstadoCotizacion()
    {
      if (!this.hayCotizacion)
        return;
      Cotizacion cotizacion = new Cotizacion();
      string str = "FACTURA";
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBFactura.IDDocumentoVenta = new Factura().RetornaIdFactura(this.veOBFactura.FolioDocumentoVenta);
      this.veOBFactura.DocumentoVenta = str;
      cotizacion.modificaTipoDocumentoCotizacion(this.veOBFactura);
    }

    private void cambiaEstadoCotizacionEliminaFactura()
    {
      if (!this.hayCotizacion)
        return;
      Cotizacion cotizacion = new Cotizacion();
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      Factura factura = new Factura();
      this.veOBFactura.IDDocumentoVenta = 0;
      this.veOBFactura.FolioDocumentoVenta = 0;
      this.veOBFactura.DocumentoVenta = "";
      this.veOBFactura.IdFactura = this.veOBFactura.IdCotizacion;
      this.veOBFactura.Folio = this.veOBFactura.FolioCotizacion;
      cotizacion.modificaTipoDocumentoCotizacion(this.veOBFactura);
    }

    private void btnBuscaCotizacion_Click(object sender, EventArgs e)
    {
      if (this.txtFolioCotizacion.Text.Trim().Length > 0)
      {
        if (!this.buscaOT)
          this.buscaCotizacionFolio();
        else
          this.buscaOrdenrabajo();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Un Folio a Buscar");
        this.txtFolioCotizacion.Focus();
      }
    }

    private void buscaOrdenrabajo()
    {
      this.panelFolio.Visible = false;
      OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
      int folio = Convert.ToInt32(this.txtFolioCotizacion.Text.Trim());
      try
      {
        Venta venta = ordenTrabajo.buscaOTFolio(folio);
        this.veOBFactura = venta;
        if (venta.IdFactura != 0)
        {
          if (venta.IDDocumentoVenta == 0)
          {
            this.iniciaVenta();
            this.idFactura = venta.IdFactura;
            this.hayOT = true;
            if (venta.IdVendedor != 0)
            {
              this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            }
            else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
            this.codigoCliente = venta.IdCliente;
            this.verificaCredito();
            this.txtRut.Text = venta.Rut;
            this.txtDigito.Text = venta.Digito;
            this.txtRazonSocial.Text = venta.RazonSocial.ToString();
            this.txtDireccion.Text = venta.Direccion.ToString();
            this.txtComuna.Text = venta.Comuna.ToString();
            this.txtCiudad.Text = venta.Ciudad.ToString();
            this.txtGiro.Text = venta.Giro.ToString();
            this.txtFono.Text = venta.Fono.ToString();
            this.txtFax.Text = venta.Fax.ToString();
            this.txtContacto.Text = venta.Contacto.ToString();
            this.txtDiasPlazo.Text = venta.DiasPlazo.ToString();
            TextBox textBox1 = this.txtSubTotal;
            Decimal num = venta.SubTotal;
            string str1 = num.ToString("N0");
            textBox1.Text = str1;
            TextBox textBox2 = this.txtTotalDescuento;
            num = venta.Descuento;
            string str2 = num.ToString("N0");
            textBox2.Text = str2;
            TextBox textBox3 = this.txtPorcDescuentoTotal;
            num = venta.PorcentajeDescuento;
            string str3 = num.ToString("N0");
            textBox3.Text = str3;
            TextBox textBox4 = this.txtTotalDescuento;
            num = venta.Descuento;
            string str4 = num.ToString("N0");
            textBox4.Text = str4;
            TextBox textBox5 = this.txtNeto;
            num = venta.Neto;
            string str5 = num.ToString("N0");
            textBox5.Text = str5;
            TextBox textBox6 = this.txtIva;
            num = venta.Iva;
            string str6 = num.ToString("N0");
            textBox6.Text = str6;
            TextBox textBox7 = this.txtPorIva;
            num = venta.PorcentajeIva;
            string str7 = num.ToString("N0");
            textBox7.Text = str7;
            TextBox textBox8 = this.txtTotalGeneral;
            num = venta.Total;
            string str8 = num.ToString("N0");
            textBox8.Text = str8;
            TextBox textBox9 = this.txtTotalImp1;
            num = venta.Impuesto1;
            string str9;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto1;
              str9 = num.ToString("N0");
            }
            else
              str9 = "";
            textBox9.Text = str9;
            TextBox textBox10 = this.txtTotalImp2;
            num = venta.Impuesto2;
            string str10;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto2;
              str10 = num.ToString("N0");
            }
            else
              str10 = "";
            textBox10.Text = str10;
            TextBox textBox11 = this.txtTotalImp3;
            num = venta.Impuesto3;
            string str11;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto3;
              str11 = num.ToString("N0");
            }
            else
              str11 = "";
            textBox11.Text = str11;
            TextBox textBox12 = this.txtTotalImp4;
            num = venta.Impuesto4;
            string str12;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto4;
              str12 = num.ToString("N0");
            }
            else
              str12 = "";
            textBox12.Text = str12;
            TextBox textBox13 = this.txtTotalImp5;
            num = venta.Impuesto5;
            string str13;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto5;
              str13 = num.ToString("N0");
            }
            else
              str13 = "";
            textBox13.Text = str13;
            //this.txtObservaciones.Text = "Orden de Trabajo N°: " + venta.Folio.ToString();
            this.lista = ordenTrabajo.buscaDetalleOTId(venta.IdFactura);
            for (int index = 0; index < this.lista.Count; ++index)
            {
              this.lista[index].Linea = index + 1;
              this.lista[index].FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
              this.lista[index].IdFactura = 0;
              this.lista[index].DescuentaInventario = true;
            }
            this.dgvDatosVenta.DataSource = (object) null;
            this.dgvDatosVenta.DataSource = (object) this.lista;
          }
          else
          {
            int num1 = (int) MessageBox.Show(string.Concat(new object[4]
            {
              (object) "OT ya Documentada en: ",
              (object) venta.DocumentoVenta,
              (object) " Folio N°: ",
              (object) venta.FolioDocumentoVenta
            }));
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("No Existe la OT Consultada!!");
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al llamar OT " + ex.Message);
      }
    }

    private void txtFolioCotizacion_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioCotizacion);
      if ((int) e.KeyChar != 13)
        return;
      if (!this.buscaOT)
        this.buscaCotizacionFolio();
      else
        this.buscaOrdenrabajo();
    }

    private void calculaVueltoTeclaF5ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmVuelto(this.txtTotalGeneral.Text, ref this.intance, "factura").ShowDialog();
    }

    private void buscaNotaVentaFolio()
    {
      NotaVenta notaVenta = new NotaVenta();
      int numFactura = Convert.ToInt32(this.txtFolioNotaVenta.Text.Trim());
      try
      {
        Venta venta = notaVenta.buscaNotaVentaFolio(numFactura);
        this.veOBFactura = venta;
        if (venta.IdFactura != 0)
        {
          if (venta.IDDocumentoVenta == 0)
          {
            this.iniciaVenta();
            this.idFactura = venta.IdFactura;
            if (venta.IdMedioPago != 0)
            {
              this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
              this.cmbMedioPago.Text = venta.MedioPago.ToString();
            }
            if (venta.IdVendedor != 0)
            {
              this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            }
            else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            if (venta.IdCentroCosto != 0)
            {
              this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            }
            else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
            this.codigoCliente = venta.IdCliente;
            this.verificaCredito();
            this.txtRut.Text = venta.Rut;
            this.txtDigito.Text = venta.Digito;
            this.txtRazonSocial.Text = venta.RazonSocial.ToString();
            this.txtDireccion.Text = venta.Direccion.ToString();
            this.txtComuna.Text = venta.Comuna.ToString();
            this.txtCiudad.Text = venta.Ciudad.ToString();
            this.txtGiro.Text = venta.Giro.ToString();
            this.txtFono.Text = venta.Fono.ToString();
            this.txtFax.Text = venta.Fax.ToString();
            this.txtContacto.Text = venta.Contacto.ToString();
            this.txtDiasPlazo.Text = venta.DiasPlazo.ToString();
            TextBox textBox1 = this.txtSubTotal;
            Decimal num = venta.SubTotal;
            string str1 = num.ToString("N0");
            textBox1.Text = str1;
            TextBox textBox2 = this.txtTotalDescuento;
            num = venta.Descuento;
            string str2 = num.ToString("N0");
            textBox2.Text = str2;
            TextBox textBox3 = this.txtPorcDescuentoTotal;
            num = venta.PorcentajeDescuento;
            string str3 = num.ToString("N0");
            textBox3.Text = str3;
            TextBox textBox4 = this.txtTotalDescuento;
            num = venta.Descuento;
            string str4 = num.ToString("N0");
            textBox4.Text = str4;
            TextBox textBox5 = this.txtNeto;
            num = venta.Neto;
            string str5 = num.ToString("N0");
            textBox5.Text = str5;
            TextBox textBox6 = this.txtIva;
            num = venta.Iva;
            string str6 = num.ToString("N0");
            textBox6.Text = str6;
            TextBox textBox7 = this.txtPorIva;
            num = venta.PorcentajeIva;
            string str7 = num.ToString("N0");
            textBox7.Text = str7;
            TextBox textBox8 = this.txtTotalGeneral;
            num = venta.Total;
            string str8 = num.ToString("N0");
            textBox8.Text = str8;
            TextBox textBox9 = this.txtTotalImp1;
            num = venta.Impuesto1;
            string str9;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto1;
              str9 = num.ToString("N0");
            }
            else
              str9 = "";
            textBox9.Text = str9;
            TextBox textBox10 = this.txtTotalImp2;
            num = venta.Impuesto2;
            string str10;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto2;
              str10 = num.ToString("N0");
            }
            else
              str10 = "";
            textBox10.Text = str10;
            TextBox textBox11 = this.txtTotalImp3;
            num = venta.Impuesto3;
            string str11;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto3;
              str11 = num.ToString("N0");
            }
            else
              str11 = "";
            textBox11.Text = str11;
            TextBox textBox12 = this.txtTotalImp4;
            num = venta.Impuesto4;
            string str12;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto4;
              str12 = num.ToString("N0");
            }
            else
              str12 = "";
            textBox12.Text = str12;
            TextBox textBox13 = this.txtTotalImp5;
            num = venta.Impuesto5;
            string str13;
            if (!num.ToString("N0").Equals("0"))
            {
              num = venta.Impuesto5;
              str13 = num.ToString("N0");
            }
            else
              str13 = "";
            textBox13.Text = str13;
            this.hayNotaVenta = true;
            //this.txtObservaciones.Text = "Nota de Venta N°: " + venta.Folio.ToString();
            this.lista = notaVenta.buscaDetalleNotaVentaIDNotaVenta(venta.IdFactura);
            for (int index = 0; index < this.lista.Count; ++index)
            {
              this.lista[index].Linea = index + 1;
              this.lista[index].FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
              this.lista[index].IdFactura = 0;
              this.lista[index].DescuentaInventario = false;
            }
            this.dgvDatosVenta.DataSource = (object) null;
            this.dgvDatosVenta.DataSource = (object) this.lista;
            if (!this.verificaCreditoActivo)
              return;
            this.verificaCredito();
          }
          else
          {
            int num1 = (int) MessageBox.Show(string.Concat(new object[4]
            {
              (object) "Nota de Venta ya Documentada en: ",
              (object) venta.DocumentoVenta,
              (object) " Folio N°: ",
              (object) venta.FolioDocumentoVenta
            }));
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("No Existe la Nota de Venta Consultada!!");
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al llamar Nota de Venta " + ex.Message);
      }
    }

    private void btnBuscaNotaventa_Click(object sender, EventArgs e)
    {
      if (this.txtFolioNotaVenta.Text.Trim().Length > 0)
      {
        this.buscaNotaVentaFolio();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Un Folio a Buscar");
        this.txtFolioNotaVenta.Focus();
      }
    }

    private void btnCierraNota_Click(object sender, EventArgs e)
    {
      this.panelNotaVenta.Visible = false;
    }

    private void notaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void cambiaEstadoNotaVenta()
    {
      if (!this.hayNotaVenta)
        return;
      NotaVenta notaVenta = new NotaVenta();
      string str = "FACTURA ELECTRONICA";
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBFactura.IDDocumentoVenta = new EFactura().RetornaIdFactura(this.veOBFactura.FolioDocumentoVenta);
      this.veOBFactura.DocumentoVenta = str;
      notaVenta.modificaTipoDocumentoNotaVenta(this.veOBFactura);
    }

    private void cambiaEstadoNotaVentaEliminaFactura()
    {
      if (!this.hayNotaVenta)
        return;
      NotaVenta notaVenta = new NotaVenta();
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBFactura.IDDocumentoVenta = 0;
      this.veOBFactura.FolioDocumentoVenta = 0;
      this.veOBFactura.DocumentoVenta = "";
      this.veOBFactura.IdFactura = this.veOBFactura.IdNotaVenta;
      this.veOBFactura.Folio = this.veOBFactura.FolioNotaVenta;
      notaVenta.modificaTipoDocumentoNotaVenta(this.veOBFactura);
    }

    private void txtFolioNotaVenta_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioNotaVenta);
      if ((int) e.KeyChar != 13)
        return;
      this.buscaNotaVentaFolio();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      int num = (int) new frmMuestraCredito(this.codigoCliente).ShowDialog();
    }

    private void verificaCredito()
    {
      this.btnVerificaCredito.Enabled = true;
      foreach (CreditoVO creditoVo in new Credito().verificaCredito(this.codigoCliente))
      {
        if (creditoVo.Codigo == 7)
          this.txtCreditoDisponible.Text = creditoVo.Total.ToString("N0");
      }
    }

    private void ordenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.buscaOT = true;
      this.label36.Text = "OT N°";
      this.pnlCotizacionBuscar.Visible = true;
      this.txtFolioCotizacion.Focus();
    }

    private void cambiaEstadoOT()
    {
      if (!this.hayOT)
        return;
      OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
      string str = "FACTURA";
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBFactura.IDDocumentoVenta = new Factura().RetornaIdFactura(this.veOBFactura.FolioDocumentoVenta);
      this.veOBFactura.DocumentoVenta = str;
      ordenTrabajo.modificaTipoDocumentoOT(this.veOBFactura);
    }

    private void cambiaEstadoOTEliminaFactura()
    {
      if (!this.hayOT)
        return;
      OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      Factura factura = new Factura();
      this.veOBFactura.IDDocumentoVenta = 0;
      this.veOBFactura.FolioDocumentoVenta = 0;
      this.veOBFactura.DocumentoVenta = "";
      this.veOBFactura.Folio = this.veOBFactura.FolioOT;
      ordenTrabajo.modificaTipoDocumentoOT(this.veOBFactura);
    }

    private void iniciaReferencia()
    {
      this.cargaDocumentoReferencia();
      this.cargaDocumentoTipoAccion();
      this.txtFolioDocumentoReferencia.Clear();
      this.dtpFechaReferencia.Value = DateTime.Now;
      this.txtRazonReferencia.Clear();
    }

    private void cargaDocumentoReferencia()
    {
      this.cmbTipoDocumentoReferencia.DataSource = (object) null;
      this.cmbTipoDocumentoReferencia.DataSource = (object) new TipoDocumentoVO().listaDocumentos();
      this.cmbTipoDocumentoReferencia.ValueMember = "CodigoDocumento";
      this.cmbTipoDocumentoReferencia.DisplayMember = "NombreDocumento";
      this.cmbTipoDocumentoReferencia.SelectedValue = (object) 33;
    }

    private void cargaDocumentoTipoAccion()
    {
      this.cmbTipoAccion.DataSource = (object) null;
      this.cmbTipoAccion.DataSource = (object) new TipoDocumentoVO().listaTipoAccion();
      this.cmbTipoAccion.ValueMember = "CodigoAccion";
      this.cmbTipoAccion.DisplayMember = "NombreAccion";
      this.cmbTipoAccion.SelectedValue = (object) 1;
    }

    private void cargaDocumentoTipoAccionSinAnula()
    {
        this.cmbTipoAccion.DataSource = (object)null;
        this.cmbTipoAccion.DataSource = (object)new TipoDocumentoVO().listaTipoAccionSinAnulaDocumento();
        this.cmbTipoAccion.ValueMember = "CodigoAccion";
        this.cmbTipoAccion.DisplayMember = "NombreAccion";
        this.cmbTipoAccion.SelectedValue = (object)2;
    }


    private void btnGuardaReferencia_Click(object sender, EventArgs e)
    {
      if (!this.validaReferencia())
        return;
      this.armaReferencia();
      this.iniciaReferencia();
    }

    private bool validaReferencia()
    {
      if (this.txtFolioDocumentoReferencia.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Folio a referenciar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtFolioDocumentoReferencia.Focus();
        return false;
      }
      if (this.txtRazonReferencia.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar una Razon de referencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRazonReferencia.Focus();
        return false;
      }
      if (this.txtFolioDocumentoReferencia.Text.Trim().Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar folio de documento a referenciar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtFolioDocumentoReferencia.Focus();
      return false;
    }

    private void armaReferencia()
    {
      ReferenicaVO referenicaVo = new ReferenicaVO();
      referenicaVo.FolioDocumento = Convert.ToInt32(this.txtNumeroDocumento.Text);
      referenicaVo.TipoDocumento = Convert.ToInt32(this.cmbTipoDocumentoReferencia.SelectedValue);
      string str1 = "";
      if (referenicaVo.TipoDocumento == 30)
          str1 = "FACTURA";
      if (referenicaVo.TipoDocumento == 33)
        str1 = "FACTURA ELECTRONICA";
      if (referenicaVo.TipoDocumento == 32)
        str1 = "FACTURA EXENTA";
      if (referenicaVo.TipoDocumento == 34)
          str1 = "FACTURA EXENTA ELECTRONICA";
      if (referenicaVo.TipoDocumento == 50)
        str1 = "GUIA DESPACHO";
      if (referenicaVo.TipoDocumento == 52)
          str1 = "GUIA DESPACHO ELECTRONICA";
      if (referenicaVo.TipoDocumento == 60)
          str1 = "NOTA DE CREDITO";
      if (referenicaVo.TipoDocumento == 61)
          str1 = "NOTA DE CREDITO ELECTRONICA";
      if (referenicaVo.TipoDocumento == 55)
        str1 = "NOTA DE DEBITO";
      if (referenicaVo.TipoDocumento == 56)
          str1 = "NOTA DE DEBITO ELECTRONICA";
      if (referenicaVo.TipoDocumento == 35)
          str1 = "BOLETA";
      if (referenicaVo.TipoDocumento == 39)
          str1 = "BOLETA ELECTRONICA";
      if (referenicaVo.TipoDocumento == 801)
          str1 = "ORDEN DE COMPRA";
      if (referenicaVo.TipoDocumento == 48)
          str1 = "TICKET POS";
      if (referenicaVo.TipoDocumento == 0)
        str1 = "SET";
      referenicaVo.TipoDocumentoNombre = str1;
      referenicaVo.FolioDocumentoReferencia = this.txtFolioDocumentoReferencia.Text;
      referenicaVo.FechaDocumentoReferencia = this.dtpFechaReferencia.Value;
      referenicaVo.TipoAccion = Convert.ToInt32(this.cmbTipoAccion.SelectedValue);
      string str2 = "";
      if (referenicaVo.TipoAccion == 1)
        str2 = "ANULA DOCUMENTO DE REFERENCIA";
      if (referenicaVo.TipoAccion == 2)
        str2 = "CORRIGE TEXTO DOCUMENTO REFERENCIA";
      if (referenicaVo.TipoAccion == 3)
        str2 = "CORRIGE MONTOS";
      if (referenicaVo.TipoAccion == 4)
        str2 = "OTRO";
      referenicaVo.TipoAccionNombre = str2;
      referenicaVo.RazonReferencia = this.txtRazonReferencia.Text;
      this.listaReferencias.Add(referenicaVo);
      this.dgvReferencias.DataSource = (object) null;
      this.dgvReferencias.DataSource = (object) this.listaReferencias;
    }

    private void dgvReferencias_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            if (!(this.dgvReferencias.Columns[e.ColumnIndex].Name == "EliminaReferencia") || MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            int num1 = Convert.ToInt32(this.dgvReferencias.SelectedRows[0].Cells["TipoDocumento"].Value.ToString());
            int num2 = Convert.ToInt32(this.dgvReferencias.SelectedRows[0].Cells["FolioDocumento"].Value.ToString());
            int num3 = Convert.ToInt32(this.dgvReferencias.SelectedRows[0].Cells["TipoAccion"].Value.ToString());
            for (int index = 0; index < this.listaReferencias.Count; ++index)
            {
                if (this.listaReferencias[index].TipoDocumento == num1 && this.listaReferencias[index].FolioDocumento == num2 && this.listaReferencias[index].TipoAccion == num3)
                {
                    this.listaReferencias.RemoveAt(index);
                    --index;
                }
            }
            this.dgvReferencias.DataSource = (object)null;
            if (this.listaReferencias.Count > 0)
                this.dgvReferencias.DataSource = (object)this.listaReferencias;
        }
        catch (Exception ex)
        {

        }
    }


    private void txtFolioDocumentoReferencia_KeyPress(object sender, KeyPressEventArgs e)
    {
     
      if ((int) e.KeyChar != 13)
        return;
      int num1 = Convert.ToInt32(this.cmbTipoDocumentoReferencia.SelectedValue);
      int folioBuscar = this.txtFolioDocumentoReferencia.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtFolioDocumentoReferencia.Text.Trim()) : 0;
      if (folioBuscar > 0)
      {
        if (num1 == 52)
          this.buscaGuiaFolio(folioBuscar);
      }
      else
      {
        int num2 = (int) MessageBox.Show("Debe ingresar un folio a buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void button1_Click_2(object sender, EventArgs e)
    {
    }

    private void button1_Click_3(object sender, EventArgs e)
    {
      for (int fol = 91; fol < 101; ++fol)
      {
        if (this.reUsarFacturaFolio(fol))
        {
          this.guardaFactura();
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe Factura Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }

    private bool reUsarFacturaFolio(int fol)
    {
      this.panelFolio.Visible = false;
      EFactura efactura = new EFactura();
      Venta venta = efactura.buscaFacturaFolio(fol);
      this.veOBFactura = venta;
      if (venta.IdFactura == 0)
        return false;
      if (venta.IdMedioPago != 0)
      {
        this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
        this.cmbMedioPago.Text = venta.MedioPago.ToString();
      }
      if (venta.IdVendedor != 0)
      {
        this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
        this.cmbVendedor.Text = venta.Vendedor.ToString();
      }
      else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
        this.cmbVendedor.Text = venta.Vendedor.ToString();
      if (venta.IdCentroCosto != 0)
      {
        this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
        this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
      }
      else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
        this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
      this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
      this.codigoCliente = venta.IdCliente;
      this.verificaCredito();
      this.txtRut.Text = venta.Rut;
      this.txtDigito.Text = venta.Digito;
      this.txtRazonSocial.Text = venta.RazonSocial.ToString();
      this.txtDireccion.Text = venta.Direccion.ToString();
      this.txtComuna.Text = venta.Comuna.ToString();
      this.txtCiudad.Text = venta.Ciudad.ToString();
      this.txtGiro.Text = venta.Giro.ToString();
      this.txtFono.Text = venta.Fono.ToString();
      this.txtFax.Text = venta.Fax.ToString();
      this.txtContacto.Text = venta.Contacto.ToString();
      this.txtDiasPlazo.Text = venta.DiasPlazo.ToString();
      this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
      this.txtTotalDescuento.Text = venta.Descuento.ToString("N0");
      TextBox textBox1 = this.txtPorcDescuentoTotal;
      Decimal num = venta.PorcentajeDescuento;
      string str1 = num.ToString("N0");
      textBox1.Text = str1;
      TextBox textBox2 = this.txtTotalDescuento;
      num = venta.Descuento;
      string str2 = num.ToString("N" + this.decimalesValoresVenta);
      textBox2.Text = str2;
      TextBox textBox3 = this.txtNeto;
      num = venta.Neto;
      string str3 = num.ToString("N" + this.decimalesValoresVenta);
      textBox3.Text = str3;
      TextBox textBox4 = this.txtIva;
      num = venta.Iva;
      string str4 = num.ToString("N" + this.decimalesValoresVenta);
      textBox4.Text = str4;
      TextBox textBox5 = this.txtPorIva;
      num = venta.PorcentajeIva;
      string str5 = num.ToString("N0");
      textBox5.Text = str5;
      TextBox textBox6 = this.txtTotalExento;
      num = venta.TotalExento;
      string str6 = num.ToString("N" + this.decimalesValoresVenta);
      textBox6.Text = str6;
      TextBox textBox7 = this.txtTotalGeneral;
      num = venta.Total;
      string str7 = num.ToString("N" + this.decimalesValoresVenta);
      textBox7.Text = str7;
      this.txtGuias.Text = venta.FolioGuias;
      //this.txtObservaciones.Text = venta.Observaciones;
      TextBox textBox8 = this.txtTotalImp1;
      num = venta.Impuesto1;
      string str8;
      if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
      {
        num = venta.Impuesto1;
        str8 = num.ToString("N" + this.decimalesValoresVenta);
      }
      else
        str8 = "";
      textBox8.Text = str8;
      TextBox textBox9 = this.txtTotalImp2;
      num = venta.Impuesto2;
      string str9;
      if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
      {
        num = venta.Impuesto2;
        str9 = num.ToString("N" + this.decimalesValoresVenta);
      }
      else
        str9 = "";
      textBox9.Text = str9;
      TextBox textBox10 = this.txtTotalImp3;
      num = venta.Impuesto3;
      string str10;
      if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
      {
        num = venta.Impuesto3;
        str10 = num.ToString("N" + this.decimalesValoresVenta);
      }
      else
        str10 = "";
      textBox10.Text = str10;
      TextBox textBox11 = this.txtTotalImp4;
      num = venta.Impuesto4;
      string str11;
      if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
      {
        num = venta.Impuesto4;
        str11 = num.ToString("N" + this.decimalesValoresVenta);
      }
      else
        str11 = "";
      textBox11.Text = str11;
      TextBox textBox12 = this.txtTotalImp5;
      num = venta.Impuesto5;
      string str12;
      if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
      {
        num = venta.Impuesto5;
        str12 = num.ToString("N" + this.decimalesValoresVenta);
      }
      else
        str12 = "";
      textBox12.Text = str12;
      this._timbre = venta.Timbre;
      if (venta.IdTicket > 0)
      {
        this.hayTicket = true;
        this.txtTicket.Text = venta.FolioTicket.ToString();
        this.idTicket = venta.IdTicket;
      }
      if (venta.IdCotizacion > 0)
        this.hayCotizacion = true;
      if (venta.IdNotaVenta > 0)
        this.hayNotaVenta = true;
      if (venta.FolioGuias.Length > 0)
        this.hayGuia = true;
      if (venta.FolioOT > 0)
        this.hayOT = true;
      this.lista = efactura.buscaDetalleFacturaIDFactura(venta.IdFactura);
      this.listaReferencias = efactura.buscaReferenciaIDFactura(venta.IdFactura);
      this.cmbBodega.SelectedValue = (object) this.lista[0].Bodega;
      for (int index = 0; index < this.lista.Count; ++index)
      {
        this.lista[index].Linea = index + 1;
        if (this.lista[index].IdImpuesto > 0)
        {
          if (this.lista[index].IdImpuesto == 1)
            this.lista[index].CodigoImpuesto = this.lblCodImp1.Text;
          if (this.lista[index].IdImpuesto == 2)
            this.lista[index].CodigoImpuesto = this.lblCodImp2.Text;
          if (this.lista[index].IdImpuesto == 3)
            this.lista[index].CodigoImpuesto = this.lblCodImp3.Text;
          if (this.lista[index].IdImpuesto == 4)
            this.lista[index].CodigoImpuesto = this.lblCodImp4.Text;
          if (this.lista[index].IdImpuesto == 5)
            this.lista[index].CodigoImpuesto = this.lblCodImp5.Text;
        }
      }
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
      this.dgvReferencias.DataSource = (object) null;
      this.dgvReferencias.DataSource = (object) this.listaReferencias;
      return true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.armaCodigoPDF417("EFactura_" + this.txtNumeroDocumento.Text);
    }

    private void armaCodigoPDF417Respaldo(string documento)
    {
      try
      {
        XDocument xdocument = XDocument.Load(this._rutaElectronica + "DTE\\E-Factura\\" + documento + ".XML", LoadOptions.PreserveWhitespace);
        xdocument.Declaration.Encoding = "ISO-8859-1";
        new XmlNamespaceManager((XmlNameTable) new NameTable()).AddNamespace("sii", "http://www.sii.cl/SiiDte");
        XElement xelement = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument, "DTE/Documento/TED");
        string str = xelement.ToString().Replace(Environment.NewLine, "");
        if (xelement != null)
        {
          this._timbre = str;
          CodigoPDF417 codigoPdF417 = new CodigoPDF417();
          new ImagenPdf417().agregaImagenPdf417(new ImagenPdf417VO()
          {
            Imagen = codigoPdF417.creaPdf417(this._timbre),
            FolioDte = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()),
            TipoDte = 33
          });
        }
        else
        {
          int num = (int) MessageBox.Show("Error al armar PDF417", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error PDF417" + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void armaCodigoPDF417(string documento)
    {
      try
      {
        XDocument xdocument = XDocument.Load(this._rutaElectronica + "DTE\\E-Factura\\EFacturaXML\\" + documento + ".XML", LoadOptions.PreserveWhitespace);
        xdocument.Declaration.Encoding = "ISO-8859-1";
        new XmlNamespaceManager((XmlNameTable) new NameTable()).AddNamespace("sii", "http://www.sii.cl/SiiDte");
        XElement xelement = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument, "DTE/Documento/TED");
        string str = xelement.ToString().Replace(Environment.NewLine, "");
        if (xelement != null)
        {
          this._timbre = str;
          CodigoPDF417 codigoPdF417 = new CodigoPDF417();
          new ImagenPdf417().agregaImagenPdf417(new ImagenPdf417VO()
          {
            Imagen = codigoPdF417.creaPdf417(this._timbre.Trim()),
            FolioDte = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()),
            TipoDte = 33
          });
        }
        else
        {
          int num = (int) MessageBox.Show("Error al armar PDF417", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error PDF417" + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnComprobarFolio_Click(object sender, EventArgs e)
    {
      if (this.txtNumeroDocumento.Text.Trim().Length <= 0)
        return;
      string str = new Caf().archivoCaf(33, Convert.ToInt32(this.txtNumeroDocumento.Text));
      bool flag = true;
      if (str.Length == 0)
      {
        int num = (int) MessageBox.Show("No hay folios CAF disponibles, debe solicitar a SII y cargar en sistema", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this._guarda = false;
        flag = false;
      }
      if (!this._guarda && flag)
      {
        int num = (int) MessageBox.Show("Se cargaron Folios CAF al sistema", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.cargaPermisos();
        if (this._guarda)
        {
          this.btnGuardar.Enabled = true;
          this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = true;
        }
        else
        {
          this.btnGuardar.Enabled = false;
          this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
        }
      }
    }

    private void btnCreaPdf_Click(object sender, EventArgs e)
    {
      this.creaPDF();
      int num = (int) MessageBox.Show("Listo");
    }

    private void buscaGuiaFolio(int folioBuscar)
    {
      this.panelFolio.Visible = false;
      EGuia eguia = new EGuia();
      Venta venta = eguia.buscaGuiaFolio(folioBuscar);
      this.veOBFactura = venta;
      if (venta.IdFactura != 0)
      {
        if (!venta.Facturada)
        {
          this.hayGuia = true;
          this.idFactura = venta.IdFactura;
          this.dtpFechaReferencia.Value = Convert.ToDateTime(venta.FechaEmision.ToString());
          if (venta.IdMedioPago != 0)
          {
            this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
            this.cmbMedioPago.Text = venta.MedioPago.ToString();
          }
          if (venta.IdVendedor != 0)
          {
            this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          }
          else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          if (venta.IdCentroCosto != 0)
          {
            this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          }
          else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
          this.codigoCliente = venta.IdCliente;
          this.verificaCredito();
          this.txtRut.Text = venta.Rut;
          this.txtDigito.Text = venta.Digito;
          this.txtRazonSocial.Text = venta.RazonSocial.ToString();
          this.txtDireccion.Text = venta.Direccion.ToString();
          this.txtComuna.Text = venta.Comuna.ToString();
          this.txtCiudad.Text = venta.Ciudad.ToString();
          this.txtGiro.Text = venta.Giro.ToString();
          this.txtFono.Text = venta.Fono.ToString();
          this.txtFax.Text = venta.Fax.ToString();
          this.txtContacto.Text = venta.Contacto.ToString();
          TextBox textBox1 = this.txtDiasPlazo;
          int num1 = venta.DiasPlazo;
          string str1 = num1.ToString();
          textBox1.Text = str1;
          TextBox textBox2 = this.txtSubTotal;
          Decimal num2 = venta.SubTotal;
          string str2 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox2.Text = str2;
          TextBox textBox3 = this.txtTotalDescuento;
          num2 = venta.Descuento;
          string str3 = num2.ToString("N0");
          textBox3.Text = str3;
          TextBox textBox4 = this.txtPorcDescuentoTotal;
          num2 = venta.PorcentajeDescuento;
          string str4 = num2.ToString("N0");
          textBox4.Text = str4;
          TextBox textBox5 = this.txtTotalDescuento;
          num2 = venta.Descuento;
          string str5 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox5.Text = str5;
          TextBox textBox6 = this.txtNeto;
          num2 = venta.Neto;
          string str6 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox6.Text = str6;
          TextBox textBox7 = this.txtIva;
          num2 = venta.Iva;
          string str7 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox7.Text = str7;
          TextBox textBox8 = this.txtPorIva;
          num2 = venta.PorcentajeIva;
          string str8 = num2.ToString("N0");
          textBox8.Text = str8;
          TextBox textBox9 = this.txtTotalExento;
          num2 = venta.TotalExento;
          string str9 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox9.Text = str9;
          TextBox textBox10 = this.txtTotalGeneral;
          num2 = venta.Total;
          string str10 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox10.Text = str10;
          TextBox textBox11 = this.txtGuias;
          num1 = venta.Folio;
          string str11 = num1.ToString();
          textBox11.Text = str11;
          //this.txtObservaciones.Text = venta.Observaciones;
          TextBox textBox12 = this.txtTotalImp1;
          num2 = venta.Impuesto1;
          string str12;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto1;
            str12 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str12 = "";
          textBox12.Text = str12;
          TextBox textBox13 = this.txtTotalImp2;
          num2 = venta.Impuesto2;
          string str13;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto2;
            str13 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str13 = "";
          textBox13.Text = str13;
          TextBox textBox14 = this.txtTotalImp3;
          num2 = venta.Impuesto3;
          string str14;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto3;
            str14 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str14 = "";
          textBox14.Text = str14;
          TextBox textBox15 = this.txtTotalImp4;
          num2 = venta.Impuesto4;
          string str15;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto4;
            str15 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str15 = "";
          textBox15.Text = str15;
          TextBox textBox16 = this.txtTotalImp5;
          num2 = venta.Impuesto5;
          string str16;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto5;
            str16 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str16 = "";
          textBox16.Text = str16;
          this.lista = eguia.buscaDetalleGuiaIDGuia(venta.IdFactura);
          this.cmbBodega.SelectedValue = (object) this.lista[0].Bodega;
          for (int index = 0; index < this.lista.Count; ++index)
            this.lista[index].Linea = index + 1;
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) this.lista;
          this.txtFolioBuscar.Clear();
        }
        else
        {
          int num3 = (int) MessageBox.Show(string.Concat(new object[4]
          {
            (object) "Guia ya Documentada en: ",
            (object) venta.DocumentoVenta,
            (object) " Folio N°: ",
            (object) venta.FolioFactura
          }), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("No Existe Guia Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtFolioBuscar.Clear();
        this.iniciaVenta();
      }
    }

    private void txtNumeroDocumento_Leave(object sender, EventArgs e)
    {
      if (this.chkHistoricoVentas.Checked || this.txtNumeroDocumento.Text.Trim().Length <= 0)
        return;
      string str = new Caf().archivoCaf(33, Convert.ToInt32(this.txtNumeroDocumento.Text));
      bool flag = true;
      if (str.Length == 0)
      {
        int num = (int) MessageBox.Show("No hay folios CAF disponibles, debe solicitar a SII y cargar en sistema", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this._guarda = false;
        flag = false;
      }
      if (!this._guarda && flag)
      {
        int num = (int) MessageBox.Show("Se cargaron Folios CAF al sistema", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.cargaPermisos();
        if (this._guarda)
        {
          this.btnGuardar.Enabled = true;
          this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = true;
        }
        else
        {
          this.btnGuardar.Enabled = false;
          this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
        }
      }
      if (!this._guarda && !flag)
      {
        this.btnGuardar.Enabled = false;
        this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
      }
    }

    private void notaDeVentaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.panelNotaVenta.Visible = true;
      this.txtFolioNotaVenta.Focus();
    }

    private void facturacionMasivaDeNotasDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmFacturaGuias(ref this.intance, "factura_electronica", "nota_de_venta").ShowDialog();
    }

    public void facturaNotaVentaMasiva(List<Venta> listaNV)
    {
      this.lista.Clear();
      string str = "";
      int num = 0;
      NotaVenta notaVenta = new NotaVenta();
      foreach (Venta venta in listaNV)
      {
        this.codigoCliente = venta.IdCliente;
        this.verificaCredito();
        foreach (DatosVentaVO dv in notaVenta.buscaDetalleNotaVentaIDNotaVenta(venta.IdFactura))
        {
          dv.DescuentaInventario = false;
          dv.IdFactura = 0;
          dv.FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
          this.agregaLineasDesdeGuias(dv);
        }
        str = num != 0 ? str + "-" + venta.Folio.ToString("N0") : str + venta.Folio.ToString("N0");
        ++num;
      }
      this.label35.Text = "NOTAS DE VENTA";
      this.hayNotaVentaMasiva = true;
      this.txtGuias.Text = str;
      this.buscaClienteCodigo(this.codigoCliente);
      this.dgvDatosVenta.DataSource = (object) this.lista;
      this.calculaTotales();
    }

    private void cambiaEstadoNotaVentaMasiva(Venta ve)
    {
      if (!this.hayNotaVentaMasiva)
        return;
      ve.Facturada = true;
      ve.DocumentoVenta = "FACTURA ELECTRONICA";
      NotaVenta notaVenta = new NotaVenta();
      try
      {
        notaVenta.facturaNotaVentaMasiva(ve);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al facturar Notas de Venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void cambiaEstadoNotaVentaMasivaEliminaFactura(Venta ve)
    {
      if (!this.hayNotaVentaMasiva)
        return;
      ve.Folio = 0;
      ve.DocumentoVenta = "";
      ve.IdFactura = 0;
      NotaVenta notaVenta = new NotaVenta();
      try
      {
        notaVenta.facturaNotaVentaMasiva(ve);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al facturar Notas de venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void agregaDevolucionGrilla(string descripcion, Decimal valor)
    {
      DatosVentaVO datosVentaVo = new DatosVentaVO();
      this.txtDescripcion.Text = descripcion.ToUpper();
      this.txtPrecio.Text = valor.ToString();
      this.txtCantidad.Text = "1";
      this.calculaTotalLinea();
      this.agregaLineaGrilla();
      this.limpiaEntradaDetalle();
      this.calculaTotales();
    }

    private void txtCodigo_TextChanged(object sender, EventArgs e)
    {

    }

    private void frmFacturaElectronica_Load(object sender, EventArgs e)
    {
        
    }

    private void dgvBuscaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
       // this.creaXML(venta, this.lista);
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
        
    }

    private void cmbTipoDocumentoReferencia_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(cmbTipoDocumentoReferencia.SelectedIndex == 0)
        {
            cargaDocumentoTipoAccionSinAnula();
        }
        else
        {
            cargaDocumentoTipoAccion();
        }
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
        modificarVentaParaEnvio();
        creaXMLCliente(venta, lista);
        creaPDF();
        envio(venta);
    }

    void modificarVentaParaEnvio()
    {
        venta.Caja = this._caja;
        venta.FechaEmision = Convert.ToDateTime(dtpEmision.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.FechaVencimiento = Convert.ToDateTime(dtpVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.FechaModificacion = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.IdCliente = this.codigoCliente;
        venta.Rut = this.txtRut.Text.Trim();
        venta.Digito = this.txtDigito.Text.Trim();
        venta.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
        venta.Direccion = this.txtDireccion.Text.Trim().ToUpper();
        venta.Comuna = this.txtComuna.Text.Trim().ToUpper();
        venta.Ciudad = this.txtCiudad.Text.Trim().ToUpper();
        venta.Giro = this.txtGiro.Text.Trim().ToUpper();
        venta.Fono = this.txtFono.Text.Trim();
        venta.Fax = this.txtFax.Text.Trim();
        venta.Contacto = this.txtContacto.Text.Trim().ToUpper();
        venta.DiasPlazo = Convert.ToInt32(this.txtDiasPlazo.Text.Trim());
        if (this.cmbMedioPago.SelectedValue.ToString() != "0")
        {
            venta.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
            venta.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
        }
        if (this.cmbVendedor.SelectedValue != null)
        {
            if (this.cmbVendedor.SelectedValue.ToString() != "0")
            {
                venta.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
                venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
                foreach (VendedorVO vendedorVo in this.listaVendedores)
                {
                    if (venta.IdVendedor == vendedorVo.IdVendedor)
                        venta.ComisionVendedor = vendedorVo.Comision;
                }
            }
        }
        else if (this.cmbVendedor.Text != "[SELECCIONE]")
            venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
        if (this.cmbCentroCosto.SelectedValue != null)
        {
            if (this.cmbCentroCosto.SelectedValue.ToString() != "0")
            {
                venta.IdCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
                venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
            }
        }
        else if (this.cmbCentroCosto.Text != "[SELECCIONE]")
            venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
        venta.OrdenCompra = this.txtOrdenCompra.Text.Trim();
        venta.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
        venta.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        venta.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
        venta.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
        venta.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
        venta.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
        venta.TotalExento = this.txtTotalExento.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text.Trim()) : new Decimal(0);
        venta.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
        NumeroaLetra numeroaLetra = new NumeroaLetra();
        venta.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
        if (this.hayGuia)
            venta.FolioGuias = this.txtGuias.Text.Trim();
        if (this.hayNotaVentaMasiva)
            venta.FolioNotaVentaMasivas = this.txtGuias.Text.Trim();
        if (this.hayTicket)
        {
            venta.FolioTicket = this.veOBFactura.Folio;
            venta.IdTicket = this.idFactura;
        }
        else
        {
            venta.FolioTicket = 0;
            venta.IdTicket = 0;
        }
        if (this.hayCotizacion)
        {
            venta.FolioCotizacion = this.veOBFactura.Folio;
            venta.IdCotizacion = this.idFactura;
        }
        else
        {
            venta.FolioCotizacion = 0;
            venta.IdCotizacion = 0;
        }
        if (this.hayNotaVenta)
        {
            venta.FolioNotaVenta = this.veOBFactura.Folio;
            venta.IdNotaVenta = this.idFactura;
        }
        else
        {
            venta.FolioNotaVenta = 0;
            venta.IdNotaVenta = 0;
        }
        venta.FolioOT = !this.hayOT ? 0 : this.veOBFactura.Folio;
        venta.CodImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? this.lblCodImp1.Text : "0";
        venta.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
        venta.CodImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? this.lblCodImp2.Text : "0";
        venta.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
        venta.CodImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? this.lblCodImp3.Text : "0";
        venta.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
        venta.CodImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? this.lblCodImp4.Text : "0";
        venta.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
        venta.CodImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? this.lblCodImp5.Text : "0";
        venta.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
        if (this.listaReferencias.Count > 0)
        {
            int num = 1;
            foreach (ReferenicaVO referenicaVo in this.listaReferencias)
            {
                if (num == 1)
                {
                    venta.FE_tipoDocumento1 = referenicaVo.TipoDocumento;
                    venta.FE_tipoDocumentoNombre1 = referenicaVo.TipoDocumentoNombre;
                    venta.FE_folioDocumentoReferencia1 = referenicaVo.FolioDocumentoReferencia;
                    venta.FE_fechaDocumentoReferencia1 = referenicaVo.FechaDocumentoReferencia;
                    venta.FE_tipoAccion1 = referenicaVo.TipoAccion;
                    venta.FE_tipoAccionNombre1 = referenicaVo.TipoAccionNombre;
                    venta.FE_razonReferencia1 = referenicaVo.RazonReferencia;
                }
                if (num == 2)
                {
                    venta.FE_tipoDocumento2 = referenicaVo.TipoDocumento;
                    venta.FE_tipoDocumentoNombre2 = referenicaVo.TipoDocumentoNombre;
                    venta.FE_folioDocumentoReferencia2 = referenicaVo.FolioDocumentoReferencia;
                    venta.FE_fechaDocumentoReferencia2 = referenicaVo.FechaDocumentoReferencia;
                    venta.FE_tipoAccion2 = referenicaVo.TipoAccion;
                    venta.FE_tipoAccionNombre2 = referenicaVo.TipoAccionNombre;
                    venta.FE_razonReferencia2 = referenicaVo.RazonReferencia;
                }
                if (num == 3)
                {
                    venta.FE_tipoDocumento3 = referenicaVo.TipoDocumento;
                    venta.FE_tipoDocumentoNombre3 = referenicaVo.TipoDocumentoNombre;
                    venta.FE_folioDocumentoReferencia3 = referenicaVo.FolioDocumentoReferencia;
                    venta.FE_fechaDocumentoReferencia3 = referenicaVo.FechaDocumentoReferencia;
                    venta.FE_tipoAccion3 = referenicaVo.TipoAccion;
                    venta.FE_tipoAccionNombre3 = referenicaVo.TipoAccionNombre;
                    venta.FE_razonReferencia3 = referenicaVo.RazonReferencia;
                }
                if (num == 4)
                {
                    venta.FE_tipoDocumento4 = referenicaVo.TipoDocumento;
                    venta.FE_tipoDocumentoNombre4 = referenicaVo.TipoDocumentoNombre;
                    venta.FE_folioDocumentoReferencia4 = referenicaVo.FolioDocumentoReferencia;
                    venta.FE_fechaDocumentoReferencia4 = referenicaVo.FechaDocumentoReferencia;
                    venta.FE_tipoAccion4 = referenicaVo.TipoAccion;
                    venta.FE_tipoAccionNombre4 = referenicaVo.TipoAccionNombre;
                    venta.FE_razonReferencia4 = referenicaVo.RazonReferencia;
                }
                if (num == 5)
                {
                    venta.FE_tipoDocumento5 = referenicaVo.TipoDocumento;
                    venta.FE_tipoDocumentoNombre5 = referenicaVo.TipoDocumentoNombre;
                    venta.FE_folioDocumentoReferencia5 = referenicaVo.FolioDocumentoReferencia;
                    venta.FE_fechaDocumentoReferencia5 = referenicaVo.FechaDocumentoReferencia;
                    venta.FE_tipoAccion5 = referenicaVo.TipoAccion;
                    venta.FE_tipoAccionNombre5 = referenicaVo.TipoAccionNombre;
                    venta.FE_razonReferencia5 = referenicaVo.RazonReferencia;
                }
                ++num;
            }
        }
        int num1 = 0;
        foreach (MedioPagoVO medioPagoVo in this.listaMediosPago)
        {
            if (venta.IdMedioPago == medioPagoVo.IdMedioPago)
                num1 = Convert.ToInt32(medioPagoVo.Liquida);
        }
        if (num1 == 1)
        {
            venta.EstadoPago = "PAGADO";
            venta.TotalPagado = venta.Total;
            venta.TotalDocumentado = new Decimal(0);
            venta.TotalPendiente = new Decimal(0);
        }
        else
        {
            venta.EstadoPago = "PENDIENTE";
            venta.TotalPagado = new Decimal(0);
            venta.TotalDocumentado = new Decimal(0);
            venta.TotalPendiente = venta.Total;
        }

        venta.EstadoDocumento = "EMITIDA";
        venta.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        for (int index = 0; index < this.lista.Count; ++index)
        {
            if (index == 0)
                venta.IT1 = this.lista[index].Descripcion;
            this.lista[index].FolioFactura = venta.Folio;
            this.lista[index].FechaIngreso = venta.FechaEmision;
            this.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }

        int folio = Convert.ToInt32(this.txtNumeroDocumento.Text);
        int codCli = this.codigoCliente;
    }
  }
}
