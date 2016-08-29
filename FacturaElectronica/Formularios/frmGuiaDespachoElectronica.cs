 
// Type: Aptusoft.FacturaElectronica.Formularios.frmGuiaDespachoElectronica
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Aptusoft.DtsReportesTableAdapters;
using Aptusoft;
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

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmGuiaDespachoElectronica : Form
  {

    private IContainer components = (IContainer) null;
    private List<DatosVentaVO> lista = new List<DatosVentaVO>();
    private List<ProductoAuxiliar> listaAuxiliar = new List<ProductoAuxiliar>();
    private bool _modBodega = false;
    private int noVender = 0;
    private string _timbre = "";
    private bool hayTicket = false;
    private bool hayCotizacion = false;
    private bool hayNotaVenta = false;
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
    public List<LoteVO> _listaLote = new List<LoteVO>();
    public List<LoteVO> _listaLoteAntigua = new List<LoteVO>();
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
    private ComboBox cmbBodega;
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
    private Label lblEstadoDocumento;
    private ToolStripMenuItem guardarFacturaTeclaF2ToolStripMenuItem;
    private Button btnImprime;
    private Label label3;
    private ToolStripMenuItem cambiarNumeroDeFolioToolStripMenuItem;
    private Label label33;
    private TextBox txtTicket;
    private GroupBox gbZonaTicket;
    private ToolStripMenuItem importarToolStripMenuItem;
    private ToolStripMenuItem cotizaciónToolStripMenuItem;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Label label34;
    private TextBox txtObservaciones;
    private Label label36;
    private Button btnBuscaCotizacion;
    private TextBox txtFolioCotizacion;
    private Button btnSalirBuscaCoti;
    private Panel pnlCotizacionBuscar;
    private ToolStripMenuItem notaDeVentaToolStripMenuItem;
    private Panel panelNotaVenta;
    private Button btnBuscaNotaventa;
    private Button btnCierraNota;
    private TextBox txtFolioNotaVenta;
    private Label label37;
    private Button btnVerificaCredito;
    private TextBox txtCreditoDisponible;
    private Label label38;
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
    private ComboBox cmbTipoTraslado;
    private Label label35;
    private ComboBox cmbBodegaDestino;
    private Label label45;
    private ComboBox cmbTrasladadoPor;
    private Label label46;
    private Label lblFacturada;
    private Button btnAnular;
    private frmGuiaDespachoElectronica intance;
    private int codigoCliente;
    private int idGuia;
    private int idTicket;
    private string alertaStock;
    private string numeroLineas;
    private string envioAutomaticoSii;
    private string decimalesValoresVenta;
    private string impideVentasSinStock;
    private string multi = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
    private string impresora = new LeeXml().cargarDatosMultiEmpresa("factura")[0].ToString();
    private bool limpiar = true;
    public frmGuiaDespachoElectronica()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.CargaRuta();
      this.iniciaFormulario();
      this.iniciaVenta();
      this.intance = this;
      this.dgvReferencias.AutoGenerateColumns = false;
    }

    public frmGuiaDespachoElectronica(string folio)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.CargaRuta();
      this.iniciaFormulario();
      this.iniciaVenta();
      this.intance = this;
      this.dgvReferencias.AutoGenerateColumns = false;
      this.txtFolioBuscar.Text = folio;
      this.buscaGuiaFolio();
    }

    public frmGuiaDespachoElectronica(string des, Decimal val)
    {
      this.InitializeComponent();
      this.cargaPermisos();
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
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      this.menuStrip1 = new MenuStrip();
      this.archivoToolStripMenuItem = new ToolStripMenuItem();
      this.buscarProductosTeclaF4ToolStripMenuItem = new ToolStripMenuItem();
      this.buscarFacturaTeclaF6ToolStripMenuItem = new ToolStripMenuItem();
      this.guardarFacturaTeclaF2ToolStripMenuItem = new ToolStripMenuItem();
      this.cambiarNumeroDeFolioToolStripMenuItem = new ToolStripMenuItem();
      this.importarToolStripMenuItem = new ToolStripMenuItem();
      this.cotizaciónToolStripMenuItem = new ToolStripMenuItem();
      this.notaDeVentaToolStripMenuItem = new ToolStripMenuItem();
      this.salirToolStripMenuItem = new ToolStripMenuItem();
      this.label17 = new Label();
      this.label19 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.txtCantidad = new TextBox();
      this.label13 = new Label();
      this.txtCodigo = new TextBox();
      this.label20 = new Label();
      this.txtDescripcion = new TextBox();
      this.txtTotalLinea = new TextBox();
      this.txtCreditoDisponible = new TextBox();
      this.label38 = new Label();
      this.btnBuscaCliente = new Button();
      this.label21 = new Label();
      this.txtDiasPlazo = new TextBox();
      this.txtContacto = new TextBox();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.txtFax = new TextBox();
      this.txtFono = new TextBox();
      this.txtGiro = new TextBox();
      this.txtCiudad = new TextBox();
      this.txtComuna = new TextBox();
      this.txtDireccion = new TextBox();
      this.label5 = new Label();
      this.label4 = new Label();
      this.txtRazonSocial = new TextBox();
      this.txtDigito = new TextBox();
      this.txtRut = new TextBox();
      this.txtPrecio = new TextBox();
      this.txtDescuento = new TextBox();
      this.chkCantidadFija = new CheckBox();
      this.txtNumeroDocumento = new TextBox();
      this.lblFolio = new Label();
      this.txtOrdenCompra = new TextBox();
      this.label16 = new Label();
      this.txtTotalExento = new TextBox();
      this.label44 = new Label();
      this.label3 = new Label();
      this.lblEstadoDocumento = new Label();
      this.txtPorIva = new TextBox();
      this.txtSubTotal = new TextBox();
      this.txtTotalGeneral = new TextBox();
      this.txtIva = new TextBox();
      this.txtNeto = new TextBox();
      this.txtTotalDescuento = new TextBox();
      this.txtPorcDescuentoTotal = new TextBox();
      this.label26 = new Label();
      this.label25 = new Label();
      this.label24 = new Label();
      this.label23 = new Label();
      this.label22 = new Label();
      this.dgvDatosVenta = new DataGridView();
      this.label27 = new Label();
      this.cmbVendedor = new ComboBox();
      this.gbZonaOtros = new GroupBox();
      this.cmbMedioPago = new ComboBox();
      this.cmbCentroCosto = new ComboBox();
      this.label30 = new Label();
      this.label18 = new Label();
      this.cmbBodega = new ComboBox();
      this.cmbListaPrecio = new ComboBox();
      this.panelZonaDetalle = new Panel();
      this.cmbBodegaDestino = new ComboBox();
      this.label45 = new Label();
      this.txtPorcDescuentoLinea = new TextBox();
      this.label29 = new Label();
      this.label28 = new Label();
      this.btnLimpiaLineaDetalle = new Button();
      this.label31 = new Label();
      this.txtTipoDescuento = new TextBox();
      this.txtSubTotalLinea = new TextBox();
      this.txtLinea = new TextBox();
      this.dgvBuscaCliente = new DataGridView();
      this.pnlBuscaClienteDes = new Panel();
      this.panelFolio = new Panel();
      this.btnCerrarPanelFolio = new Button();
      this.btnBuscaFolio = new Button();
      this.txtFolioBuscar = new TextBox();
      this.label32 = new Label();
      this.label33 = new Label();
      this.txtTicket = new TextBox();
      this.gbZonaTicket = new GroupBox();
      this.cmbTrasladadoPor = new ComboBox();
      this.cmbTipoTraslado = new ComboBox();
      this.label46 = new Label();
      this.label35 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.lblFacturada = new Label();
      this.panel1 = new Panel();
      this.panel2 = new Panel();
      this.tabPage4 = new TabPage();
      this.groupBox1 = new GroupBox();
      this.txtTotalImp5 = new TextBox();
      this.txtTotalImp3 = new TextBox();
      this.txtTotalImp4 = new TextBox();
      this.txtPorImp5 = new TextBox();
      this.txtPorImp3 = new TextBox();
      this.txtTotalImp2 = new TextBox();
      this.txtPorImp4 = new TextBox();
      this.txtPorImp2 = new TextBox();
      this.txtTotalImp1 = new TextBox();
      this.txtPorImp1 = new TextBox();
      this.lblImp5 = new Label();
      this.lblImp4 = new Label();
      this.lblImp3 = new Label();
      this.lblImp2 = new Label();
      this.lblImp1 = new Label();
      this.tabPage2 = new TabPage();
      this.txtObservaciones = new TextBox();
      this.label34 = new Label();
      this.tabPage3 = new TabPage();
      this.btnGuardaReferencia = new Button();
      this.txtRazonReferencia = new TextBox();
      this.cmbTipoAccion = new ComboBox();
      this.dtpFechaReferencia = new DateTimePicker();
      this.txtFolioDocumentoReferencia = new TextBox();
      this.cmbTipoDocumentoReferencia = new ComboBox();
      this.label43 = new Label();
      this.label42 = new Label();
      this.label41 = new Label();
      this.label40 = new Label();
      this.label39 = new Label();
      this.dgvReferencias = new DataGridView();
      this.IdReferencia = new DataGridViewTextBoxColumn();
      this.IdDocumento = new DataGridViewTextBoxColumn();
      this.FolioDocumento = new DataGridViewTextBoxColumn();
      this.TipoDocumento = new DataGridViewTextBoxColumn();
      this.TipoDocumentoNombre = new DataGridViewTextBoxColumn();
      this.FolioDocumentoReferencia = new DataGridViewTextBoxColumn();
      this.FechaDocumentoReferencia = new DataGridViewTextBoxColumn();
      this.TipoAccion = new DataGridViewTextBoxColumn();
      this.TipoAccionNombre = new DataGridViewTextBoxColumn();
      this.RazonReferencia = new DataGridViewTextBoxColumn();
      this.EliminaReferencia = new DataGridViewButtonColumn();
      this.btnBuscaCotizacion = new Button();
      this.txtFolioCotizacion = new TextBox();
      this.label36 = new Label();
      this.btnSalirBuscaCoti = new Button();
      this.pnlCotizacionBuscar = new Panel();
      this.panelNotaVenta = new Panel();
      this.btnCierraNota = new Button();
      this.btnBuscaNotaventa = new Button();
      this.txtFolioNotaVenta = new TextBox();
      this.label37 = new Label();
      this.btnVerificaCredito = new Button();
      this.button1 = new Button();
      this.button2 = new Button();
      this.panelZonaCliente = new Panel();
      this.toolTip1 = new ToolTip(this.components);
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.label1 = new Label();
      this.label2 = new Label();
      this.dtpEmision = new DateTimePicker();
      this.dtpVencimiento = new DateTimePicker();
      this.gbZonaFechas = new GroupBox();
      this.btnCreaPdf = new Button();
      this.btnComprobarFolio = new Button();
      this.btnModificaLinea = new Button();
      this.btnAgregar = new Button();
      this.btnLimpiaDetalle = new Button();
      this.btnAnular = new Button();
      this.btnImprime = new Button();
      this.btnGuardar = new Button();
      this.btnSalir = new Button();
      this.btnModificar = new Button();
      this.btnEliminar = new Button();
      this.btnLimpiar = new Button();
      this.menuStrip1.SuspendLayout();
      ((ISupportInitialize) this.dgvDatosVenta).BeginInit();
      this.gbZonaOtros.SuspendLayout();
      this.panelZonaDetalle.SuspendLayout();
      ((ISupportInitialize) this.dgvBuscaCliente).BeginInit();
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
      ((ISupportInitialize) this.dgvReferencias).BeginInit();
      this.pnlCotizacionBuscar.SuspendLayout();
      this.panelNotaVenta.SuspendLayout();
      this.panelZonaCliente.SuspendLayout();
      this.gbZonaFechas.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.menuStrip1.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.archivoToolStripMenuItem,
        (ToolStripItem) this.importarToolStripMenuItem,
        (ToolStripItem) this.salirToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1352, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.buscarProductosTeclaF4ToolStripMenuItem,
        (ToolStripItem) this.buscarFacturaTeclaF6ToolStripMenuItem,
        (ToolStripItem) this.guardarFacturaTeclaF2ToolStripMenuItem,
        (ToolStripItem) this.cambiarNumeroDeFolioToolStripMenuItem
      });
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new Size(60, 20);
      this.archivoToolStripMenuItem.Text = "Archivo";
      this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
      this.buscarProductosTeclaF4ToolStripMenuItem.Size = new Size(222, 22);
      this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
      this.buscarProductosTeclaF4ToolStripMenuItem.Click += new EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
      this.buscarFacturaTeclaF6ToolStripMenuItem.Name = "buscarFacturaTeclaF6ToolStripMenuItem";
      this.buscarFacturaTeclaF6ToolStripMenuItem.Size = new Size(222, 22);
      this.buscarFacturaTeclaF6ToolStripMenuItem.Text = "Buscar Guia - tecla [F6]";
      this.buscarFacturaTeclaF6ToolStripMenuItem.Click += new EventHandler(this.buscarFacturaTeclaF6ToolStripMenuItem_Click);
      this.guardarFacturaTeclaF2ToolStripMenuItem.Name = "guardarFacturaTeclaF2ToolStripMenuItem";
      this.guardarFacturaTeclaF2ToolStripMenuItem.Size = new Size(222, 22);
      this.guardarFacturaTeclaF2ToolStripMenuItem.Text = "Guardar Guia - tecla[F2]";
      this.guardarFacturaTeclaF2ToolStripMenuItem.Click += new EventHandler(this.guardarFacturaTeclaF2ToolStripMenuItem_Click);
      this.cambiarNumeroDeFolioToolStripMenuItem.Name = "cambiarNumeroDeFolioToolStripMenuItem";
      this.cambiarNumeroDeFolioToolStripMenuItem.Size = new Size(222, 22);
      this.cambiarNumeroDeFolioToolStripMenuItem.Text = "Cambiar Numero de Folio";
      this.cambiarNumeroDeFolioToolStripMenuItem.Click += new EventHandler(this.cambiarNumeroDeFolioToolStripMenuItem_Click);
      this.importarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.cotizaciónToolStripMenuItem,
        (ToolStripItem) this.notaDeVentaToolStripMenuItem
      });
      this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
      this.importarToolStripMenuItem.Size = new Size(65, 20);
      this.importarToolStripMenuItem.Text = "Importar";
      this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
      this.cotizaciónToolStripMenuItem.Size = new Size(149, 22);
      this.cotizaciónToolStripMenuItem.Text = "Cotización";
      this.cotizaciónToolStripMenuItem.Click += new EventHandler(this.cotizaciónToolStripMenuItem_Click);
      this.notaDeVentaToolStripMenuItem.Name = "notaDeVentaToolStripMenuItem";
      this.notaDeVentaToolStripMenuItem.Size = new Size(149, 22);
      this.notaDeVentaToolStripMenuItem.Text = "Nota de Venta";
      this.notaDeVentaToolStripMenuItem.Click += new EventHandler(this.notaDeVentaToolStripMenuItem_Click);
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new Size(41, 20);
      this.salirToolStripMenuItem.Text = "Salir";
      this.salirToolStripMenuItem.Click += new EventHandler(this.salirToolStripMenuItem_Click);
      this.label17.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = Color.Black;
      this.label17.Location = new Point(704, 2);
      this.label17.Name = "label17";
      this.label17.Size = new Size(38, 23);
      this.label17.TabIndex = 4;
      this.label17.Text = "Cant.";
      this.label19.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.ForeColor = Color.Black;
      this.label19.Location = new Point(794, 2);
      this.label19.Name = "label19";
      this.label19.Size = new Size(61, 23);
      this.label19.TabIndex = 6;
      this.label19.Text = "$ Desc.";
      this.label15.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.Black;
      this.label15.Location = new Point(641, 2);
      this.label15.Name = "label15";
      this.label15.Size = new Size(61, 23);
      this.label15.TabIndex = 2;
      this.label15.Text = "Precio";
      this.label14.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.Black;
      this.label14.Location = new Point(353, 2);
      this.label14.Name = "label14";
      this.label14.Size = new Size(289, 23);
      this.label14.TabIndex = 1;
      this.label14.Text = "Descripcion";
      this.txtCantidad.BackColor = SystemColors.Window;
      this.txtCantidad.Location = new Point(704, 19);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new Size(38, 20);
      this.txtCantidad.TabIndex = 12;
      this.txtCantidad.TextAlign = HorizontalAlignment.Right;
      this.txtCantidad.TextChanged += new EventHandler(this.txtCantidad_TextChanged);
      this.txtCantidad.Enter += new EventHandler(this.txtCantidad_Enter);
      this.txtCantidad.KeyDown += new KeyEventHandler(this.txtCantidad_KeyDown);
      this.txtCantidad.KeyPress += new KeyPressEventHandler(this.txtCantidad_KeyPress);
      this.label13.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.ForeColor = Color.Black;
      this.label13.Location = new Point(266, 2);
      this.label13.Name = "label13";
      this.label13.Size = new Size(84, 23);
      this.label13.TabIndex = 0;
      this.label13.Text = "Codigo";
      this.txtCodigo.BackColor = SystemColors.Window;
      this.txtCodigo.Location = new Point(266, 19);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new Size(84, 20);
      this.txtCodigo.TabIndex = 9;
      this.txtCodigo.KeyDown += new KeyEventHandler(this.txtCodigo_KeyDown);
      this.txtCodigo.KeyPress += new KeyPressEventHandler(this.txtCodigo_KeyPress);
      this.txtCodigo.Leave += new EventHandler(this.txtCodigo_Leave);
      this.label20.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label20.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.ForeColor = Color.Black;
      this.label20.Location = new Point(857, 2);
      this.label20.Name = "label20";
      this.label20.Size = new Size(69, 23);
      this.label20.TabIndex = 7;
      this.label20.Text = "Total";
      this.txtDescripcion.BackColor = SystemColors.Window;
      this.txtDescripcion.Location = new Point(353, 19);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(289, 20);
      this.txtDescripcion.TabIndex = 10;
      this.txtDescripcion.Enter += new EventHandler(this.txtDescripcion_Enter);
      this.txtDescripcion.KeyDown += new KeyEventHandler(this.txtDescripcion_KeyDown);
      this.txtTotalLinea.BackColor = Color.White;
      this.txtTotalLinea.Enabled = false;
      this.txtTotalLinea.Location = new Point(857, 19);
      this.txtTotalLinea.Name = "txtTotalLinea";
      this.txtTotalLinea.Size = new Size(69, 20);
      this.txtTotalLinea.TabIndex = 15;
      this.txtTotalLinea.TabStop = false;
      this.txtTotalLinea.TextAlign = HorizontalAlignment.Right;
      this.txtCreditoDisponible.BackColor = Color.White;
      this.txtCreditoDisponible.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCreditoDisponible.ForeColor = Color.Black;
      this.txtCreditoDisponible.Location = new Point(636, 68);
      this.txtCreditoDisponible.Name = "txtCreditoDisponible";
      this.txtCreditoDisponible.ReadOnly = true;
      this.txtCreditoDisponible.Size = new Size(82, 20);
      this.txtCreditoDisponible.TabIndex = 34;
      this.txtCreditoDisponible.TextAlign = HorizontalAlignment.Right;
      this.label38.AutoSize = true;
      this.label38.Location = new Point(538, 72);
      this.label38.Name = "label38";
      this.label38.Size = new Size(92, 13);
      this.label38.TabIndex = 33;
      this.label38.Text = "Credito Disponible";
      this.btnBuscaCliente.Location = new Point(663, 6);
      this.btnBuscaCliente.Name = "btnBuscaCliente";
      this.btnBuscaCliente.Size = new Size(93, 23);
      this.btnBuscaCliente.TabIndex = 32;
      this.btnBuscaCliente.Text = "Buscar Cliente";
      this.btnBuscaCliente.UseVisualStyleBackColor = true;
      this.btnBuscaCliente.Click += new EventHandler(this.btnBuscaCliente_Click);
      this.label21.AutoSize = true;
      this.label21.Location = new Point(538, 51);
      this.label21.Name = "label21";
      this.label21.Size = new Size(72, 13);
      this.label21.TabIndex = 20;
      this.label21.Text = "Dias de Plazo";
      this.txtDiasPlazo.BackColor = Color.White;
      this.txtDiasPlazo.BorderStyle = BorderStyle.None;
      this.txtDiasPlazo.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDiasPlazo.Location = new Point(636, 51);
      this.txtDiasPlazo.Name = "txtDiasPlazo";
      this.txtDiasPlazo.Size = new Size(117, 13);
      this.txtDiasPlazo.TabIndex = 19;
      this.txtContacto.BackColor = Color.White;
      this.txtContacto.CharacterCasing = CharacterCasing.Upper;
      this.txtContacto.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtContacto.Location = new Point(60, 68);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(194, 20);
      this.txtContacto.TabIndex = 18;
      this.label12.AutoSize = true;
      this.label12.ForeColor = Color.Black;
      this.label12.Location = new Point(6, 72);
      this.label12.Name = "label12";
      this.label12.Size = new Size(50, 13);
      this.label12.TabIndex = 17;
      this.label12.Text = "Contacto";
      this.label12.TextAlign = ContentAlignment.TopRight;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(276, 72);
      this.label11.Name = "label11";
      this.label11.Size = new Size(32, 13);
      this.label11.TabIndex = 16;
      this.label11.Text = "Email";
      this.label11.TextAlign = ContentAlignment.TopRight;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(355, 51);
      this.label10.Name = "label10";
      this.label10.Size = new Size(31, 13);
      this.label10.TabIndex = 15;
      this.label10.Text = "Fono";
      this.label9.AutoSize = true;
      this.label9.ForeColor = Color.Black;
      this.label9.Location = new Point(30, 51);
      this.label9.Name = "label9";
      this.label9.Size = new Size(26, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Giro";
      this.label9.TextAlign = ContentAlignment.TopRight;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(538, 34);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Ciudad";
      this.label8.TextAlign = ContentAlignment.TopRight;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(340, 34);
      this.label7.Name = "label7";
      this.label7.Size = new Size(46, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Comuna";
      this.label6.AutoSize = true;
      this.label6.ForeColor = Color.Black;
      this.label6.Location = new Point(4, 34);
      this.label6.Name = "label6";
      this.label6.Size = new Size(52, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Dirección";
      this.label6.TextAlign = ContentAlignment.TopRight;
      this.txtFax.BackColor = Color.White;
      this.txtFax.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFax.Location = new Point(314, 68);
      this.txtFax.Name = "txtFax";
      this.txtFax.Size = new Size(221, 20);
      this.txtFax.TabIndex = 10;
      this.txtFono.BackColor = Color.White;
      this.txtFono.BorderStyle = BorderStyle.None;
      this.txtFono.CharacterCasing = CharacterCasing.Upper;
      this.txtFono.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFono.Location = new Point(392, 51);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(143, 13);
      this.txtFono.TabIndex = 9;
      this.txtGiro.BackColor = Color.White;
      this.txtGiro.BorderStyle = BorderStyle.None;
      this.txtGiro.CharacterCasing = CharacterCasing.Upper;
      this.txtGiro.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtGiro.Location = new Point(60, 51);
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new Size(276, 13);
      this.txtGiro.TabIndex = 8;
      this.txtCiudad.BackColor = Color.White;
      this.txtCiudad.BorderStyle = BorderStyle.None;
      this.txtCiudad.CharacterCasing = CharacterCasing.Upper;
      this.txtCiudad.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCiudad.Location = new Point(580, 34);
      this.txtCiudad.Name = "txtCiudad";
      this.txtCiudad.Size = new Size(173, 13);
      this.txtCiudad.TabIndex = 7;
      this.txtComuna.BackColor = Color.White;
      this.txtComuna.BorderStyle = BorderStyle.None;
      this.txtComuna.CharacterCasing = CharacterCasing.Upper;
      this.txtComuna.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtComuna.Location = new Point(392, 34);
      this.txtComuna.Name = "txtComuna";
      this.txtComuna.Size = new Size(143, 13);
      this.txtComuna.TabIndex = 6;
      this.txtDireccion.BackColor = Color.White;
      this.txtDireccion.BorderStyle = BorderStyle.None;
      this.txtDireccion.CharacterCasing = CharacterCasing.Upper;
      this.txtDireccion.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDireccion.Location = new Point(60, 34);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new Size(276, 13);
      this.txtDireccion.TabIndex = 5;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(181, 13);
      this.label5.Name = "label5";
      this.label5.Size = new Size(70, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Razon Social";
      this.label4.AutoSize = true;
      this.label4.ForeColor = Color.Black;
      this.label4.Location = new Point(26, 13);
      this.label4.Name = "label4";
      this.label4.Size = new Size(30, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "RUT";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.txtRazonSocial.CharacterCasing = CharacterCasing.Upper;
      this.txtRazonSocial.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRazonSocial.Location = new Point(257, 9);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(400, 20);
      this.txtRazonSocial.TabIndex = 8;
      this.txtRazonSocial.TextChanged += new EventHandler(this.txtRazonSocial_TextChanged);
      this.txtRazonSocial.KeyDown += new KeyEventHandler(this.txtRazonSocial_KeyDown);
      this.txtDigito.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDigito.Location = new Point(132, 9);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 7;
      this.txtDigito.KeyPress += new KeyPressEventHandler(this.txtDigito_KeyPress);
      this.txtRut.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRut.Location = new Point(60, 9);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(68, 20);
      this.txtRut.TabIndex = 6;
      this.txtRut.KeyDown += new KeyEventHandler(this.txtRut_KeyDown);
      this.txtPrecio.BackColor = SystemColors.Window;
      this.txtPrecio.Location = new Point(645, 19);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.Size = new Size(57, 20);
      this.txtPrecio.TabIndex = 11;
      this.txtPrecio.TextAlign = HorizontalAlignment.Right;
      this.txtPrecio.TextChanged += new EventHandler(this.txtPrecio_TextChanged);
      this.txtPrecio.KeyDown += new KeyEventHandler(this.txtPrecio_KeyDown);
      this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress);
      this.txtDescuento.BackColor = SystemColors.Window;
      this.txtDescuento.Location = new Point(794, 19);
      this.txtDescuento.Name = "txtDescuento";
      this.txtDescuento.Size = new Size(61, 20);
      this.txtDescuento.TabIndex = 14;
      this.txtDescuento.TextAlign = HorizontalAlignment.Right;
      this.txtDescuento.TextChanged += new EventHandler(this.txtDescuento_TextChanged);
      this.txtDescuento.Enter += new EventHandler(this.txtDescuento_Enter);
      this.txtDescuento.KeyPress += new KeyPressEventHandler(this.txtDescuento_KeyPress);
      this.chkCantidadFija.AutoSize = true;
      this.chkCantidadFija.Location = new Point(743, 25);
      this.chkCantidadFija.Name = "chkCantidadFija";
      this.chkCantidadFija.Size = new Size(15, 14);
      this.chkCantidadFija.TabIndex = 16;
      this.chkCantidadFija.UseVisualStyleBackColor = true;
      this.chkCantidadFija.Click += new EventHandler(this.chkCantidadFija_Click);
      this.txtNumeroDocumento.BackColor = Color.White;
      this.txtNumeroDocumento.Location = new Point(90, 15);
      this.txtNumeroDocumento.Name = "txtNumeroDocumento";
      this.txtNumeroDocumento.Size = new Size(92, 20);
      this.txtNumeroDocumento.TabIndex = 16;
      this.txtNumeroDocumento.TextAlign = HorizontalAlignment.Right;
      this.txtNumeroDocumento.TextChanged += new EventHandler(this.txtNumeroDocumento_TextChanged);
      this.txtNumeroDocumento.DoubleClick += new EventHandler(this.txtNumeroDocumento_DoubleClick);
      this.lblFolio.AutoSize = true;
      this.lblFolio.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFolio.ForeColor = Color.Blue;
      this.lblFolio.Location = new Point(5, 16);
      this.lblFolio.Name = "lblFolio";
      this.lblFolio.Size = new Size(79, 16);
      this.lblFolio.TabIndex = 5;
      this.lblFolio.Text = "E-GUIA N°";
      this.lblFolio.DoubleClick += new EventHandler(this.lblFolio_DoubleClick);
      this.txtOrdenCompra.Location = new Point(437, 30);
      this.txtOrdenCompra.Name = "txtOrdenCompra";
      this.txtOrdenCompra.Size = new Size(101, 20);
      this.txtOrdenCompra.TabIndex = 5;
      this.label16.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = Color.Black;
      this.label16.Location = new Point(437, 12);
      this.label16.Name = "label16";
      this.label16.Size = new Size(101, 17);
      this.label16.TabIndex = 7;
      this.label16.Text = "Orden de Com.";
      this.txtTotalExento.BackColor = Color.White;
      this.txtTotalExento.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalExento.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalExento.ForeColor = Color.Black;
      this.txtTotalExento.Location = new Point(112, 94);
      this.txtTotalExento.Name = "txtTotalExento";
      this.txtTotalExento.ReadOnly = true;
      this.txtTotalExento.Size = new Size(103, 21);
      this.txtTotalExento.TabIndex = 31;
      this.txtTotalExento.TabStop = false;
      this.txtTotalExento.TextAlign = HorizontalAlignment.Right;
      this.label44.AutoSize = true;
      this.label44.BackColor = Color.Transparent;
      this.label44.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label44.ForeColor = Color.Black;
      this.label44.Location = new Point(21, 98);
      this.label44.Name = "label44";
      this.label44.Size = new Size(87, 14);
      this.label44.TabIndex = 30;
      this.label44.Text = "TOTAL EXENTO";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Blue;
      this.label3.Location = new Point(7, 15);
      this.label3.Name = "label3";
      this.label3.Size = new Size(402, 25);
      this.label3.TabIndex = 28;
      this.label3.Text = "GUIA DE DESPACHO ELECTRONICA";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.lblEstadoDocumento.AutoSize = true;
      this.lblEstadoDocumento.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblEstadoDocumento.ForeColor = Color.Blue;
      this.lblEstadoDocumento.Location = new Point(406, 15);
      this.lblEstadoDocumento.Name = "lblEstadoDocumento";
      this.lblEstadoDocumento.Size = new Size(104, 25);
      this.lblEstadoDocumento.TabIndex = 25;
      this.lblEstadoDocumento.Text = "ESTADO";
      this.lblEstadoDocumento.TextAlign = ContentAlignment.MiddleLeft;
      this.txtPorIva.BackColor = Color.White;
      this.txtPorIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorIva.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPorIva.ForeColor = Color.Black;
      this.txtPorIva.Location = new Point(112, 71);
      this.txtPorIva.Name = "txtPorIva";
      this.txtPorIva.ReadOnly = true;
      this.txtPorIva.Size = new Size(24, 21);
      this.txtPorIva.TabIndex = 11;
      this.txtPorIva.TabStop = false;
      this.txtPorIva.TextAlign = HorizontalAlignment.Center;
      this.txtSubTotal.BackColor = Color.White;
      this.txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
      this.txtSubTotal.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSubTotal.ForeColor = Color.Black;
      this.txtSubTotal.Location = new Point(112, 5);
      this.txtSubTotal.Name = "txtSubTotal";
      this.txtSubTotal.ReadOnly = true;
      this.txtSubTotal.Size = new Size(103, 21);
      this.txtSubTotal.TabIndex = 10;
      this.txtSubTotal.TabStop = false;
      this.txtSubTotal.TextAlign = HorizontalAlignment.Right;
      this.txtTotalGeneral.BackColor = Color.White;
      this.txtTotalGeneral.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalGeneral.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalGeneral.ForeColor = Color.Black;
      this.txtTotalGeneral.Location = new Point(112, 117);
      this.txtTotalGeneral.Name = "txtTotalGeneral";
      this.txtTotalGeneral.ReadOnly = true;
      this.txtTotalGeneral.Size = new Size(103, 21);
      this.txtTotalGeneral.TabIndex = 9;
      this.txtTotalGeneral.TabStop = false;
      this.txtTotalGeneral.TextAlign = HorizontalAlignment.Right;
      this.txtIva.BackColor = Color.White;
      this.txtIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtIva.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtIva.ForeColor = Color.Black;
      this.txtIva.Location = new Point(138, 71);
      this.txtIva.Name = "txtIva";
      this.txtIva.ReadOnly = true;
      this.txtIva.Size = new Size(77, 21);
      this.txtIva.TabIndex = 8;
      this.txtIva.TabStop = false;
      this.txtIva.TextAlign = HorizontalAlignment.Right;
      this.txtNeto.BackColor = Color.White;
      this.txtNeto.BorderStyle = BorderStyle.FixedSingle;
      this.txtNeto.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNeto.ForeColor = Color.Black;
      this.txtNeto.Location = new Point(112, 49);
      this.txtNeto.Name = "txtNeto";
      this.txtNeto.ReadOnly = true;
      this.txtNeto.Size = new Size(103, 21);
      this.txtNeto.TabIndex = 7;
      this.txtNeto.TabStop = false;
      this.txtNeto.TextAlign = HorizontalAlignment.Right;
      this.txtTotalDescuento.BackColor = Color.White;
      this.txtTotalDescuento.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalDescuento.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalDescuento.ForeColor = Color.Black;
      this.txtTotalDescuento.Location = new Point(138, 27);
      this.txtTotalDescuento.Name = "txtTotalDescuento";
      this.txtTotalDescuento.ReadOnly = true;
      this.txtTotalDescuento.Size = new Size(77, 21);
      this.txtTotalDescuento.TabIndex = 6;
      this.txtTotalDescuento.TabStop = false;
      this.txtTotalDescuento.TextAlign = HorizontalAlignment.Right;
      this.txtTotalDescuento.TextChanged += new EventHandler(this.txtTotalDescuento_TextChanged);
      this.txtTotalDescuento.DoubleClick += new EventHandler(this.txtTotalDescuento_DoubleClick);
      this.txtTotalDescuento.KeyPress += new KeyPressEventHandler(this.txtTotalDescuento_KeyPress);
      this.txtTotalDescuento.Leave += new EventHandler(this.txtTotalDescuento_Leave);
      this.txtPorcDescuentoTotal.BackColor = Color.White;
      this.txtPorcDescuentoTotal.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorcDescuentoTotal.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPorcDescuentoTotal.ForeColor = Color.Black;
      this.txtPorcDescuentoTotal.Location = new Point(112, 27);
      this.txtPorcDescuentoTotal.Name = "txtPorcDescuentoTotal";
      this.txtPorcDescuentoTotal.ReadOnly = true;
      this.txtPorcDescuentoTotal.Size = new Size(24, 21);
      this.txtPorcDescuentoTotal.TabIndex = 5;
      this.txtPorcDescuentoTotal.TabStop = false;
      this.txtPorcDescuentoTotal.TextAlign = HorizontalAlignment.Right;
      this.txtPorcDescuentoTotal.TextChanged += new EventHandler(this.txtPorcDescuentoTotal_TextChanged);
      this.txtPorcDescuentoTotal.DoubleClick += new EventHandler(this.txtPorcDescuentoTotal_DoubleClick);
      this.txtPorcDescuentoTotal.Leave += new EventHandler(this.txtPorcDescuentoTotal_Leave);
      this.label26.AutoSize = true;
      this.label26.BackColor = Color.Transparent;
      this.label26.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.Black;
      this.label26.Location = new Point(65, 121);
      this.label26.Name = "label26";
      this.label26.Size = new Size(43, 14);
      this.label26.TabIndex = 4;
      this.label26.Text = "TOTAL";
      this.label25.AutoSize = true;
      this.label25.BackColor = Color.Transparent;
      this.label25.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label25.ForeColor = Color.Black;
      this.label25.Location = new Point(77, 75);
      this.label25.Name = "label25";
      this.label25.Size = new Size(31, 14);
      this.label25.TabIndex = 3;
      this.label25.Text = "I.V.A";
      this.label24.AutoSize = true;
      this.label24.BackColor = Color.Transparent;
      this.label24.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = Color.Black;
      this.label24.Location = new Point(73, 53);
      this.label24.Name = "label24";
      this.label24.Size = new Size(35, 14);
      this.label24.TabIndex = 2;
      this.label24.Text = "NETO";
      this.label23.AutoSize = true;
      this.label23.BackColor = Color.Transparent;
      this.label23.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.Black;
      this.label23.Location = new Point(38, 31);
      this.label23.Name = "label23";
      this.label23.Size = new Size(70, 14);
      this.label23.TabIndex = 1;
      this.label23.Text = "DESCUENTO";
      this.label22.AutoSize = true;
      this.label22.BackColor = Color.Transparent;
      this.label22.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label22.ForeColor = Color.Black;
      this.label22.Location = new Point(44, 9);
      this.label22.Name = "label22";
      this.label22.Size = new Size(64, 14);
      this.label22.TabIndex = 0;
      this.label22.Text = "SUBTOTAL";
      this.dgvDatosVenta.AllowUserToAddRows = false;
      this.dgvDatosVenta.AllowUserToDeleteRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      this.dgvDatosVenta.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvDatosVenta.BackgroundColor = Color.LightSteelBlue;
      this.dgvDatosVenta.BorderStyle = BorderStyle.Fixed3D;
      this.dgvDatosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = Color.Black;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvDatosVenta.DefaultCellStyle = gridViewCellStyle2;
      this.dgvDatosVenta.Location = new Point(12, 220);
      this.dgvDatosVenta.MultiSelect = false;
      this.dgvDatosVenta.Name = "dgvDatosVenta";
      this.dgvDatosVenta.ReadOnly = true;
      this.dgvDatosVenta.RowHeadersVisible = false;
      this.dgvDatosVenta.RowHeadersWidth = 50;
      this.dgvDatosVenta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDatosVenta.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatosVenta.Size = new Size(950, 228);
      this.dgvDatosVenta.TabIndex = 3;
      this.dgvDatosVenta.TabStop = false;
      this.dgvDatosVenta.CellClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
      this.dgvDatosVenta.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
      this.label27.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label27.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label27.ForeColor = Color.Black;
      this.label27.Location = new Point(152, 12);
      this.label27.Name = "label27";
      this.label27.Size = new Size(142, 17);
      this.label27.TabIndex = 21;
      this.label27.Text = "Vendedor";
      this.cmbVendedor.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbVendedor.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVendedor.FlatStyle = FlatStyle.Flat;
      this.cmbVendedor.FormattingEnabled = true;
      this.cmbVendedor.Location = new Point(152, 29);
      this.cmbVendedor.Name = "cmbVendedor";
      this.cmbVendedor.Size = new Size(142, 21);
      this.cmbVendedor.TabIndex = 3;
      this.cmbVendedor.Enter += new EventHandler(this.cmbVendedor_Enter);
      this.gbZonaOtros.Controls.Add((Control) this.txtOrdenCompra);
      this.gbZonaOtros.Controls.Add((Control) this.cmbMedioPago);
      this.gbZonaOtros.Controls.Add((Control) this.cmbCentroCosto);
      this.gbZonaOtros.Controls.Add((Control) this.cmbVendedor);
      this.gbZonaOtros.Controls.Add((Control) this.label30);
      this.gbZonaOtros.Controls.Add((Control) this.label18);
      this.gbZonaOtros.Controls.Add((Control) this.label16);
      this.gbZonaOtros.Controls.Add((Control) this.label27);
      this.gbZonaOtros.Location = new Point(228, 21);
      this.gbZonaOtros.Name = "gbZonaOtros";
      this.gbZonaOtros.Size = new Size(548, 55);
      this.gbZonaOtros.TabIndex = 25;
      this.gbZonaOtros.TabStop = false;
      this.cmbMedioPago.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbMedioPago.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMedioPago.FlatStyle = FlatStyle.Flat;
      this.cmbMedioPago.FormattingEnabled = true;
      this.cmbMedioPago.Location = new Point(6, 29);
      this.cmbMedioPago.Name = "cmbMedioPago";
      this.cmbMedioPago.Size = new Size(140, 21);
      this.cmbMedioPago.TabIndex = 2;
      this.cmbMedioPago.SelectedValueChanged += new EventHandler(this.cmbMedioPago_SelectedValueChanged);
      this.cmbMedioPago.Enter += new EventHandler(this.cmbMedioPago_Enter);
      this.cmbCentroCosto.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbCentroCosto.FlatStyle = FlatStyle.Flat;
      this.cmbCentroCosto.FormattingEnabled = true;
      this.cmbCentroCosto.Location = new Point(299, 29);
      this.cmbCentroCosto.Name = "cmbCentroCosto";
      this.cmbCentroCosto.Size = new Size(134, 21);
      this.cmbCentroCosto.TabIndex = 4;
      this.label30.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label30.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label30.ForeColor = Color.Black;
      this.label30.Location = new Point(299, 12);
      this.label30.Name = "label30";
      this.label30.Size = new Size(134, 17);
      this.label30.TabIndex = 34;
      this.label30.Text = "Centro de Costo";
      this.label18.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label18.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.ForeColor = Color.Black;
      this.label18.Location = new Point(6, 12);
      this.label18.Name = "label18";
      this.label18.Size = new Size(140, 17);
      this.label18.TabIndex = 23;
      this.label18.Text = "Medio de Pago";
      this.cmbBodega.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbBodega.FlatStyle = FlatStyle.Flat;
      this.cmbBodega.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbBodega.FormattingEnabled = true;
      this.cmbBodega.Location = new Point(3, 18);
      this.cmbBodega.Name = "cmbBodega";
      this.cmbBodega.Size = new Size(92, 22);
      this.cmbBodega.TabIndex = 17;
      this.cmbBodega.Enter += new EventHandler(this.cmbBodega_Enter);
      this.cmbListaPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbListaPrecio.FlatStyle = FlatStyle.Flat;
      this.cmbListaPrecio.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbListaPrecio.FormattingEnabled = true;
      this.cmbListaPrecio.Location = new Point(193, 18);
      this.cmbListaPrecio.Name = "cmbListaPrecio";
      this.cmbListaPrecio.Size = new Size(69, 22);
      this.cmbListaPrecio.TabIndex = 18;
      this.cmbListaPrecio.SelectedValueChanged += new EventHandler(this.cmbListaPrecio_SelectedValueChanged);
      this.panelZonaDetalle.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.panelZonaDetalle.Controls.Add((Control) this.cmbBodegaDestino);
      this.panelZonaDetalle.Controls.Add((Control) this.label45);
      this.panelZonaDetalle.Controls.Add((Control) this.txtPorcDescuentoLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.txtCodigo);
      this.panelZonaDetalle.Controls.Add((Control) this.txtCantidad);
      this.panelZonaDetalle.Controls.Add((Control) this.txtDescripcion);
      this.panelZonaDetalle.Controls.Add((Control) this.txtTotalLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.txtPrecio);
      this.panelZonaDetalle.Controls.Add((Control) this.txtDescuento);
      this.panelZonaDetalle.Controls.Add((Control) this.cmbListaPrecio);
      this.panelZonaDetalle.Controls.Add((Control) this.cmbBodega);
      this.panelZonaDetalle.Controls.Add((Control) this.label29);
      this.panelZonaDetalle.Controls.Add((Control) this.label28);
      this.panelZonaDetalle.Controls.Add((Control) this.btnLimpiaLineaDetalle);
      this.panelZonaDetalle.Controls.Add((Control) this.label31);
      this.panelZonaDetalle.Controls.Add((Control) this.chkCantidadFija);
      this.panelZonaDetalle.Controls.Add((Control) this.label20);
      this.panelZonaDetalle.Controls.Add((Control) this.label14);
      this.panelZonaDetalle.Controls.Add((Control) this.label13);
      this.panelZonaDetalle.Controls.Add((Control) this.label15);
      this.panelZonaDetalle.Controls.Add((Control) this.label17);
      this.panelZonaDetalle.Controls.Add((Control) this.label19);
      this.panelZonaDetalle.Location = new Point(12, 174);
      this.panelZonaDetalle.Name = "panelZonaDetalle";
      this.panelZonaDetalle.Size = new Size(949, 44);
      this.panelZonaDetalle.TabIndex = 27;
      this.cmbBodegaDestino.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbBodegaDestino.FlatStyle = FlatStyle.Flat;
      this.cmbBodegaDestino.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbBodegaDestino.FormattingEnabled = true;
      this.cmbBodegaDestino.Location = new Point(98, 18);
      this.cmbBodegaDestino.Name = "cmbBodegaDestino";
      this.cmbBodegaDestino.Size = new Size(92, 22);
      this.cmbBodegaDestino.TabIndex = 36;
      this.label45.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label45.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label45.ForeColor = Color.Black;
      this.label45.Location = new Point(100, 2);
      this.label45.Name = "label45";
      this.label45.Size = new Size(92, 23);
      this.label45.TabIndex = 37;
      this.label45.Text = "Bod. Destino";
      this.txtPorcDescuentoLinea.BackColor = SystemColors.Window;
      this.txtPorcDescuentoLinea.Location = new Point(761, 19);
      this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
      this.txtPorcDescuentoLinea.Size = new Size(31, 20);
      this.txtPorcDescuentoLinea.TabIndex = 13;
      this.txtPorcDescuentoLinea.TextAlign = HorizontalAlignment.Right;
      this.txtPorcDescuentoLinea.TextChanged += new EventHandler(this.porcentajeDescuento_TextChanged);
      this.txtPorcDescuentoLinea.Enter += new EventHandler(this.txtPorcDescuentoLinea_Enter);
      this.txtPorcDescuentoLinea.KeyDown += new KeyEventHandler(this.txtPorcDescuentoLinea_KeyDown);
      this.txtPorcDescuentoLinea.KeyPress += new KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
      this.label29.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label29.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label29.ForeColor = Color.Black;
      this.label29.Location = new Point(193, 2);
      this.label29.Name = "label29";
      this.label29.Size = new Size(69, 23);
      this.label29.TabIndex = 35;
      this.label29.Text = "Lista $";
      this.label28.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label28.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label28.ForeColor = Color.Black;
      this.label28.Location = new Point(3, 2);
      this.label28.Name = "label28";
      this.label28.Size = new Size(92, 23);
      this.label28.TabIndex = 34;
      this.label28.Text = "Bod. Origen";
      this.btnLimpiaLineaDetalle.Location = new Point(928, 2);
      this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
      this.btnLimpiaLineaDetalle.Size = new Size(16, 38);
      this.btnLimpiaLineaDetalle.TabIndex = 33;
      this.btnLimpiaLineaDetalle.Text = "..";
      this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaLineaDetalle.Click += new EventHandler(this.btnLimpiaLineaDetalle_Click);
      this.label31.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label31.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label31.ForeColor = Color.Black;
      this.label31.Location = new Point(761, 2);
      this.label31.Name = "label31";
      this.label31.Size = new Size(31, 23);
      this.label31.TabIndex = 29;
      this.label31.Text = "%";
      this.txtTipoDescuento.Location = new Point(418, 640);
      this.txtTipoDescuento.Name = "txtTipoDescuento";
      this.txtTipoDescuento.Size = new Size(38, 20);
      this.txtTipoDescuento.TabIndex = 35;
      this.txtTipoDescuento.Text = "0";
      this.txtTipoDescuento.Visible = false;
      this.txtSubTotalLinea.Location = new Point(366, 640);
      this.txtSubTotalLinea.Name = "txtSubTotalLinea";
      this.txtSubTotalLinea.Size = new Size(43, 20);
      this.txtSubTotalLinea.TabIndex = 34;
      this.txtSubTotalLinea.Visible = false;
      this.txtLinea.Location = new Point(335, 640);
      this.txtLinea.Name = "txtLinea";
      this.txtLinea.Size = new Size(24, 20);
      this.txtLinea.TabIndex = 32;
      this.txtLinea.Text = "NumeroLinea";
      this.txtLinea.Visible = false;
      this.dgvBuscaCliente.AllowUserToAddRows = false;
      this.dgvBuscaCliente.AllowUserToDeleteRows = false;
      this.dgvBuscaCliente.AllowUserToResizeColumns = false;
      this.dgvBuscaCliente.AllowUserToResizeRows = false;
      gridViewCellStyle3.BackColor = Color.Lavender;
      this.dgvBuscaCliente.AlternatingRowsDefaultCellStyle = gridViewCellStyle3;
      this.dgvBuscaCliente.BackgroundColor = Color.LavenderBlush;
      this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle4.BackColor = SystemColors.Window;
      gridViewCellStyle4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle4.ForeColor = SystemColors.ControlText;
      gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
      this.dgvBuscaCliente.DefaultCellStyle = gridViewCellStyle4;
      this.dgvBuscaCliente.Location = new Point(-1, -1);
      this.dgvBuscaCliente.Name = "dgvBuscaCliente";
      this.dgvBuscaCliente.ReadOnly = true;
      this.dgvBuscaCliente.RowHeadersVisible = false;
      this.dgvBuscaCliente.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaCliente.Size = new Size(657, 211);
      this.dgvBuscaCliente.TabIndex = 0;
      this.dgvBuscaCliente.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaCliente_CellDoubleClick);
      this.dgvBuscaCliente.KeyDown += new KeyEventHandler(this.dgvBuscaCliente_KeyDown);
      this.pnlBuscaClienteDes.BackColor = Color.FromArgb(64, 64, 64);
      this.pnlBuscaClienteDes.Controls.Add((Control) this.dgvBuscaCliente);
      this.pnlBuscaClienteDes.Location = new Point(269, 108);
      this.pnlBuscaClienteDes.Name = "pnlBuscaClienteDes";
      this.pnlBuscaClienteDes.Size = new Size(658, 211);
      this.pnlBuscaClienteDes.TabIndex = 32;
      this.panelFolio.BorderStyle = BorderStyle.FixedSingle;
      this.panelFolio.Controls.Add((Control) this.btnCerrarPanelFolio);
      this.panelFolio.Controls.Add((Control) this.btnBuscaFolio);
      this.panelFolio.Controls.Add((Control) this.txtFolioBuscar);
      this.panelFolio.Controls.Add((Control) this.label32);
      this.panelFolio.Location = new Point(802, 60);
      this.panelFolio.Name = "panelFolio";
      this.panelFolio.Size = new Size(224, 92);
      this.panelFolio.TabIndex = 24;
      this.btnCerrarPanelFolio.FlatStyle = FlatStyle.Flat;
      this.btnCerrarPanelFolio.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnCerrarPanelFolio.ForeColor = Color.Red;
      this.btnCerrarPanelFolio.Location = new Point(185, 1);
      this.btnCerrarPanelFolio.Name = "btnCerrarPanelFolio";
      this.btnCerrarPanelFolio.Size = new Size(23, 24);
      this.btnCerrarPanelFolio.TabIndex = 24;
      this.btnCerrarPanelFolio.Text = "X";
      this.btnCerrarPanelFolio.UseVisualStyleBackColor = true;
      this.btnCerrarPanelFolio.Click += new EventHandler(this.btnCerrarPanelFolio_Click);
      this.btnBuscaFolio.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaFolio.Location = new Point(25, 59);
      this.btnBuscaFolio.Name = "btnBuscaFolio";
      this.btnBuscaFolio.Size = new Size(161, 25);
      this.btnBuscaFolio.TabIndex = 2;
      this.btnBuscaFolio.Text = "Buscar";
      this.btnBuscaFolio.UseVisualStyleBackColor = true;
      this.btnBuscaFolio.Click += new EventHandler(this.btnBuscaFolio_Click);
      this.txtFolioBuscar.Location = new Point(26, 33);
      this.txtFolioBuscar.Name = "txtFolioBuscar";
      this.txtFolioBuscar.Size = new Size(162, 20);
      this.txtFolioBuscar.TabIndex = 1;
      this.txtFolioBuscar.TextAlign = HorizontalAlignment.Center;
      this.txtFolioBuscar.KeyPress += new KeyPressEventHandler(this.txtFolioBuscar_KeyPress);
      this.label32.AutoSize = true;
      this.label32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label32.Location = new Point(21, 8);
      this.label32.Name = "label32";
      this.label32.Size = new Size(164, 16);
      this.label32.TabIndex = 0;
      this.label32.Text = "Ingrese Folio a Buscar";
      this.label33.AutoSize = true;
      this.label33.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label33.ForeColor = Color.Black;
      this.label33.Location = new Point(1073, 200);
      this.label33.Name = "label33";
      this.label33.Size = new Size(61, 13);
      this.label33.TabIndex = 33;
      this.label33.Text = "Ticket N°";
      this.label33.Visible = false;
      this.txtTicket.Location = new Point(1158, 196);
      this.txtTicket.Name = "txtTicket";
      this.txtTicket.Size = new Size(92, 20);
      this.txtTicket.TabIndex = 29;
      this.txtTicket.TextAlign = HorizontalAlignment.Right;
      this.txtTicket.Visible = false;
      this.txtTicket.TextChanged += new EventHandler(this.txtTicket_TextChanged);
      this.txtTicket.KeyPress += new KeyPressEventHandler(this.txtTicket_KeyPress);
      this.gbZonaTicket.Controls.Add((Control) this.cmbTrasladadoPor);
      this.gbZonaTicket.Controls.Add((Control) this.cmbTipoTraslado);
      this.gbZonaTicket.Controls.Add((Control) this.label46);
      this.gbZonaTicket.Controls.Add((Control) this.label35);
      this.gbZonaTicket.Controls.Add((Control) this.lblFolio);
      this.gbZonaTicket.Controls.Add((Control) this.txtNumeroDocumento);
      this.gbZonaTicket.Location = new Point(775, 21);
      this.gbZonaTicket.Name = "gbZonaTicket";
      this.gbZonaTicket.Size = new Size(187, 149);
      this.gbZonaTicket.TabIndex = 34;
      this.gbZonaTicket.TabStop = false;
      this.cmbTrasladadoPor.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbTrasladadoPor.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbTrasladadoPor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTrasladadoPor.FlatStyle = FlatStyle.Flat;
      this.cmbTrasladadoPor.FormattingEnabled = true;
      this.cmbTrasladadoPor.Location = new Point(6, 121);
      this.cmbTrasladadoPor.Name = "cmbTrasladadoPor";
      this.cmbTrasladadoPor.Size = new Size(176, 21);
      this.cmbTrasladadoPor.TabIndex = 49;
      this.cmbTipoTraslado.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbTipoTraslado.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbTipoTraslado.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTipoTraslado.FlatStyle = FlatStyle.Flat;
      this.cmbTipoTraslado.FormattingEnabled = true;
      this.cmbTipoTraslado.Location = new Point(6, 75);
      this.cmbTipoTraslado.Name = "cmbTipoTraslado";
      this.cmbTipoTraslado.Size = new Size(176, 21);
      this.cmbTipoTraslado.TabIndex = 47;
      this.cmbTipoTraslado.SelectionChangeCommitted += new EventHandler(this.cmbTipoTraslado_SelectionChangeCommitted);
      this.label46.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label46.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label46.ForeColor = Color.Black;
      this.label46.Location = new Point(6, 104);
      this.label46.Name = "label46";
      this.label46.Size = new Size(176, 17);
      this.label46.TabIndex = 50;
      this.label46.Text = "Trasladado Por";
      this.label35.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label35.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label35.ForeColor = Color.Black;
      this.label35.Location = new Point(6, 58);
      this.label35.Name = "label35";
      this.label35.Size = new Size(176, 17);
      this.label35.TabIndex = 48;
      this.label35.Text = "Tipo de Traslado";
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Location = new Point(11, 451);
      this.tabControl1.Multiline = true;
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(951, 181);
      this.tabControl1.SizeMode = TabSizeMode.Fixed;
      this.tabControl1.TabIndex = 35;
      this.tabPage1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage1.Controls.Add((Control) this.btnAnular);
      this.tabPage1.Controls.Add((Control) this.lblFacturada);
      this.tabPage1.Controls.Add((Control) this.panel1);
      this.tabPage1.Controls.Add((Control) this.panel2);
      this.tabPage1.Controls.Add((Control) this.label3);
      this.tabPage1.Controls.Add((Control) this.btnImprime);
      this.tabPage1.Controls.Add((Control) this.lblEstadoDocumento);
      this.tabPage1.Controls.Add((Control) this.btnGuardar);
      this.tabPage1.Controls.Add((Control) this.btnSalir);
      this.tabPage1.Controls.Add((Control) this.btnModificar);
      this.tabPage1.Controls.Add((Control) this.btnEliminar);
      this.tabPage1.Controls.Add((Control) this.btnLimpiar);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(943, 155);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Principal";
      this.lblFacturada.AutoSize = true;
      this.lblFacturada.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFacturada.ForeColor = Color.Red;
      this.lblFacturada.Location = new Point(7, 44);
      this.lblFacturada.Name = "lblFacturada";
      this.lblFacturada.Size = new Size(111, 25);
      this.lblFacturada.TabIndex = 47;
      this.lblFacturada.Text = "facturada";
      this.lblFacturada.Visible = false;
      this.panel1.BackColor = Color.FromArgb(223, 233, 245);
      this.panel1.Controls.Add((Control) this.txtSubTotal);
      this.panel1.Controls.Add((Control) this.txtTotalExento);
      this.panel1.Controls.Add((Control) this.label23);
      this.panel1.Controls.Add((Control) this.label44);
      this.panel1.Controls.Add((Control) this.label22);
      this.panel1.Controls.Add((Control) this.label24);
      this.panel1.Controls.Add((Control) this.txtPorIva);
      this.panel1.Controls.Add((Control) this.label25);
      this.panel1.Controls.Add((Control) this.label26);
      this.panel1.Controls.Add((Control) this.txtPorcDescuentoTotal);
      this.panel1.Controls.Add((Control) this.txtTotalGeneral);
      this.panel1.Controls.Add((Control) this.txtTotalDescuento);
      this.panel1.Controls.Add((Control) this.txtNeto);
      this.panel1.Controls.Add((Control) this.txtIva);
      this.panel1.Location = new Point(717, 6);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(221, 143);
      this.panel1.TabIndex = 32;
      this.panel2.BackColor = Color.White;
      this.panel2.Location = new Point(716, 5);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(223, 145);
      this.panel2.TabIndex = 33;
      this.tabPage4.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage4.Controls.Add((Control) this.groupBox1);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(943, 155);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Impuestos Esp.";
      this.groupBox1.Controls.Add((Control) this.txtTotalImp5);
      this.groupBox1.Controls.Add((Control) this.txtTotalImp3);
      this.groupBox1.Controls.Add((Control) this.txtTotalImp4);
      this.groupBox1.Controls.Add((Control) this.txtPorImp5);
      this.groupBox1.Controls.Add((Control) this.txtPorImp3);
      this.groupBox1.Controls.Add((Control) this.txtTotalImp2);
      this.groupBox1.Controls.Add((Control) this.txtPorImp4);
      this.groupBox1.Controls.Add((Control) this.txtPorImp2);
      this.groupBox1.Controls.Add((Control) this.txtTotalImp1);
      this.groupBox1.Controls.Add((Control) this.txtPorImp1);
      this.groupBox1.Controls.Add((Control) this.lblImp5);
      this.groupBox1.Controls.Add((Control) this.lblImp4);
      this.groupBox1.Controls.Add((Control) this.lblImp3);
      this.groupBox1.Controls.Add((Control) this.lblImp2);
      this.groupBox1.Controls.Add((Control) this.lblImp1);
      this.groupBox1.Location = new Point(10, 11);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(265, 133);
      this.groupBox1.TabIndex = 30;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Impuestos Especiales";
      this.txtTotalImp5.BackColor = Color.White;
      this.txtTotalImp5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalImp5.Location = new Point(141, 107);
      this.txtTotalImp5.Name = "txtTotalImp5";
      this.txtTotalImp5.ReadOnly = true;
      this.txtTotalImp5.Size = new Size(83, 21);
      this.txtTotalImp5.TabIndex = 38;
      this.txtTotalImp5.TextAlign = HorizontalAlignment.Right;
      this.txtTotalImp3.BackColor = Color.White;
      this.txtTotalImp3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalImp3.Location = new Point(141, 63);
      this.txtTotalImp3.Name = "txtTotalImp3";
      this.txtTotalImp3.ReadOnly = true;
      this.txtTotalImp3.Size = new Size(83, 21);
      this.txtTotalImp3.TabIndex = 10;
      this.txtTotalImp3.TextAlign = HorizontalAlignment.Right;
      this.txtTotalImp4.BackColor = Color.White;
      this.txtTotalImp4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalImp4.Location = new Point(141, 85);
      this.txtTotalImp4.Name = "txtTotalImp4";
      this.txtTotalImp4.ReadOnly = true;
      this.txtTotalImp4.Size = new Size(83, 21);
      this.txtTotalImp4.TabIndex = 36;
      this.txtTotalImp4.TextAlign = HorizontalAlignment.Right;
      this.txtPorImp5.BackColor = Color.White;
      this.txtPorImp5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPorImp5.Location = new Point(90, 107);
      this.txtPorImp5.Name = "txtPorImp5";
      this.txtPorImp5.ReadOnly = true;
      this.txtPorImp5.Size = new Size(47, 21);
      this.txtPorImp5.TabIndex = 37;
      this.txtPorImp5.TextAlign = HorizontalAlignment.Center;
      this.txtPorImp3.BackColor = Color.White;
      this.txtPorImp3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPorImp3.Location = new Point(90, 63);
      this.txtPorImp3.Name = "txtPorImp3";
      this.txtPorImp3.ReadOnly = true;
      this.txtPorImp3.Size = new Size(47, 21);
      this.txtPorImp3.TabIndex = 9;
      this.txtPorImp3.TextAlign = HorizontalAlignment.Center;
      this.txtTotalImp2.BackColor = Color.White;
      this.txtTotalImp2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalImp2.Location = new Point(141, 41);
      this.txtTotalImp2.Name = "txtTotalImp2";
      this.txtTotalImp2.ReadOnly = true;
      this.txtTotalImp2.Size = new Size(83, 21);
      this.txtTotalImp2.TabIndex = 8;
      this.txtTotalImp2.TextAlign = HorizontalAlignment.Right;
      this.txtPorImp4.BackColor = Color.White;
      this.txtPorImp4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPorImp4.Location = new Point(90, 85);
      this.txtPorImp4.Name = "txtPorImp4";
      this.txtPorImp4.ReadOnly = true;
      this.txtPorImp4.Size = new Size(47, 21);
      this.txtPorImp4.TabIndex = 35;
      this.txtPorImp4.TextAlign = HorizontalAlignment.Center;
      this.txtPorImp2.BackColor = Color.White;
      this.txtPorImp2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPorImp2.Location = new Point(90, 41);
      this.txtPorImp2.Name = "txtPorImp2";
      this.txtPorImp2.ReadOnly = true;
      this.txtPorImp2.Size = new Size(47, 21);
      this.txtPorImp2.TabIndex = 7;
      this.txtPorImp2.TextAlign = HorizontalAlignment.Center;
      this.txtTotalImp1.BackColor = Color.White;
      this.txtTotalImp1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalImp1.Location = new Point(141, 19);
      this.txtTotalImp1.Name = "txtTotalImp1";
      this.txtTotalImp1.ReadOnly = true;
      this.txtTotalImp1.Size = new Size(83, 21);
      this.txtTotalImp1.TabIndex = 6;
      this.txtTotalImp1.TextAlign = HorizontalAlignment.Right;
      this.txtPorImp1.BackColor = Color.White;
      this.txtPorImp1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPorImp1.ForeColor = Color.Black;
      this.txtPorImp1.Location = new Point(90, 19);
      this.txtPorImp1.Name = "txtPorImp1";
      this.txtPorImp1.ReadOnly = true;
      this.txtPorImp1.Size = new Size(47, 21);
      this.txtPorImp1.TabIndex = 5;
      this.txtPorImp1.TextAlign = HorizontalAlignment.Center;
      this.lblImp5.AutoSize = true;
      this.lblImp5.Location = new Point(10, 111);
      this.lblImp5.Name = "lblImp5";
      this.lblImp5.Size = new Size(59, 13);
      this.lblImp5.TabIndex = 4;
      this.lblImp5.Text = "Impuesto 5";
      this.lblImp4.AutoSize = true;
      this.lblImp4.Location = new Point(10, 89);
      this.lblImp4.Name = "lblImp4";
      this.lblImp4.Size = new Size(59, 13);
      this.lblImp4.TabIndex = 3;
      this.lblImp4.Text = "Impuesto 4";
      this.lblImp3.AutoSize = true;
      this.lblImp3.Location = new Point(10, 67);
      this.lblImp3.Name = "lblImp3";
      this.lblImp3.Size = new Size(59, 13);
      this.lblImp3.TabIndex = 2;
      this.lblImp3.Text = "Impuesto 3";
      this.lblImp2.AutoSize = true;
      this.lblImp2.Location = new Point(10, 45);
      this.lblImp2.Name = "lblImp2";
      this.lblImp2.Size = new Size(59, 13);
      this.lblImp2.TabIndex = 1;
      this.lblImp2.Text = "Impuesto 2";
      this.lblImp1.AutoSize = true;
      this.lblImp1.Location = new Point(10, 23);
      this.lblImp1.Name = "lblImp1";
      this.lblImp1.Size = new Size(59, 13);
      this.lblImp1.TabIndex = 0;
      this.lblImp1.Text = "Impuesto 1";
      this.tabPage2.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage2.Controls.Add((Control) this.txtObservaciones);
      this.tabPage2.Controls.Add((Control) this.label34);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(943, 155);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Otros";
      this.txtObservaciones.Location = new Point(14, 28);
      this.txtObservaciones.Multiline = true;
      this.txtObservaciones.Name = "txtObservaciones";
      this.txtObservaciones.Size = new Size(405, 116);
      this.txtObservaciones.TabIndex = 1;
      this.label34.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label34.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label34.ForeColor = Color.White;
      this.label34.Location = new Point(14, 12);
      this.label34.Name = "label34";
      this.label34.Size = new Size(405, 23);
      this.label34.TabIndex = 2;
      this.label34.Text = "OBSERVACIONES";
      this.tabPage3.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage3.Controls.Add((Control) this.btnGuardaReferencia);
      this.tabPage3.Controls.Add((Control) this.txtRazonReferencia);
      this.tabPage3.Controls.Add((Control) this.cmbTipoAccion);
      this.tabPage3.Controls.Add((Control) this.dtpFechaReferencia);
      this.tabPage3.Controls.Add((Control) this.txtFolioDocumentoReferencia);
      this.tabPage3.Controls.Add((Control) this.cmbTipoDocumentoReferencia);
      this.tabPage3.Controls.Add((Control) this.label43);
      this.tabPage3.Controls.Add((Control) this.label42);
      this.tabPage3.Controls.Add((Control) this.label41);
      this.tabPage3.Controls.Add((Control) this.label40);
      this.tabPage3.Controls.Add((Control) this.label39);
      this.tabPage3.Controls.Add((Control) this.dgvReferencias);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(943, 155);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Referencias";
      this.btnGuardaReferencia.Location = new Point(852, 126);
      this.btnGuardaReferencia.Name = "btnGuardaReferencia";
      this.btnGuardaReferencia.Size = new Size(75, 23);
      this.btnGuardaReferencia.TabIndex = 12;
      this.btnGuardaReferencia.Text = "Guardar";
      this.btnGuardaReferencia.UseVisualStyleBackColor = true;
      this.btnGuardaReferencia.Click += new EventHandler(this.btnGuardaReferencia_Click);
      this.txtRazonReferencia.CharacterCasing = CharacterCasing.Upper;
      this.txtRazonReferencia.Location = new Point(634, 23);
      this.txtRazonReferencia.Multiline = true;
      this.txtRazonReferencia.Name = "txtRazonReferencia";
      this.txtRazonReferencia.Size = new Size(296, 97);
      this.txtRazonReferencia.TabIndex = 11;
      this.cmbTipoAccion.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTipoAccion.FormattingEnabled = true;
      this.cmbTipoAccion.Location = new Point(350, 23);
      this.cmbTipoAccion.Name = "cmbTipoAccion";
      this.cmbTipoAccion.Size = new Size(278, 21);
      this.cmbTipoAccion.TabIndex = 10;
      this.dtpFechaReferencia.Format = DateTimePickerFormat.Short;
      this.dtpFechaReferencia.Location = new Point(243, 23);
      this.dtpFechaReferencia.Name = "dtpFechaReferencia";
      this.dtpFechaReferencia.Size = new Size(101, 20);
      this.dtpFechaReferencia.TabIndex = 9;
      this.txtFolioDocumentoReferencia.Location = new Point(161, 23);
      this.txtFolioDocumentoReferencia.Name = "txtFolioDocumentoReferencia";
      this.txtFolioDocumentoReferencia.Size = new Size(78, 20);
      this.txtFolioDocumentoReferencia.TabIndex = 8;
      this.txtFolioDocumentoReferencia.TextAlign = HorizontalAlignment.Right;
      this.txtFolioDocumentoReferencia.KeyPress += new KeyPressEventHandler(this.txtFolioDocumentoReferencia_KeyPress);
      this.cmbTipoDocumentoReferencia.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTipoDocumentoReferencia.FormattingEnabled = true;
      this.cmbTipoDocumentoReferencia.Location = new Point(5, 23);
      this.cmbTipoDocumentoReferencia.Name = "cmbTipoDocumentoReferencia";
      this.cmbTipoDocumentoReferencia.Size = new Size(152, 21);
      this.cmbTipoDocumentoReferencia.TabIndex = 7;
      this.label43.AutoSize = true;
      this.label43.Location = new Point(634, 7);
      this.label43.Name = "label43";
      this.label43.Size = new Size(93, 13);
      this.label43.TabIndex = 6;
      this.label43.Text = "Razon Referencia";
      this.label42.AutoSize = true;
      this.label42.Location = new Point(350, 7);
      this.label42.Name = "label42";
      this.label42.Size = new Size(79, 13);
      this.label42.TabIndex = 5;
      this.label42.Text = "Tipo de Accion";
      this.label41.AutoSize = true;
      this.label41.Location = new Point(243, 7);
      this.label41.Name = "label41";
      this.label41.Size = new Size(101, 13);
      this.label41.TabIndex = 4;
      this.label41.Text = "Fecha de Doc. Ref.";
      this.label40.AutoSize = true;
      this.label40.Location = new Point(161, 7);
      this.label40.Name = "label40";
      this.label40.Size = new Size(78, 13);
      this.label40.TabIndex = 3;
      this.label40.Text = "Folio Doc. Ref.";
      this.label39.AutoSize = true;
      this.label39.Location = new Point(5, 7);
      this.label39.Name = "label39";
      this.label39.Size = new Size(129, 13);
      this.label39.TabIndex = 2;
      this.label39.Text = "Documento a Referenciar";
      this.dgvReferencias.AllowUserToAddRows = false;
      this.dgvReferencias.AllowUserToDeleteRows = false;
      this.dgvReferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvReferencias.Columns.AddRange((DataGridViewColumn) this.IdReferencia, (DataGridViewColumn) this.IdDocumento, (DataGridViewColumn) this.FolioDocumento, (DataGridViewColumn) this.TipoDocumento, (DataGridViewColumn) this.TipoDocumentoNombre, (DataGridViewColumn) this.FolioDocumentoReferencia, (DataGridViewColumn) this.FechaDocumentoReferencia, (DataGridViewColumn) this.TipoAccion, (DataGridViewColumn) this.TipoAccionNombre, (DataGridViewColumn) this.RazonReferencia, (DataGridViewColumn) this.EliminaReferencia);
      this.dgvReferencias.Location = new Point(5, 50);
      this.dgvReferencias.Name = "dgvReferencias";
      this.dgvReferencias.ReadOnly = true;
      this.dgvReferencias.RowHeadersVisible = false;
      this.dgvReferencias.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvReferencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvReferencias.Size = new Size(623, 99);
      this.dgvReferencias.TabIndex = 1;
      this.dgvReferencias.CellClick += new DataGridViewCellEventHandler(this.dgvReferencias_CellClick);
      this.IdReferencia.DataPropertyName = "IdReferencia";
      this.IdReferencia.HeaderText = "IdReferencia";
      this.IdReferencia.Name = "IdReferencia";
      this.IdReferencia.ReadOnly = true;
      this.IdReferencia.Visible = false;
      this.IdDocumento.DataPropertyName = "IdDocumento";
      this.IdDocumento.HeaderText = "IdDocumento";
      this.IdDocumento.Name = "IdDocumento";
      this.IdDocumento.ReadOnly = true;
      this.IdDocumento.Visible = false;
      this.FolioDocumento.DataPropertyName = "FolioDocumento";
      this.FolioDocumento.HeaderText = "N° Doc.";
      this.FolioDocumento.Name = "FolioDocumento";
      this.FolioDocumento.ReadOnly = true;
      this.FolioDocumento.Visible = false;
      this.FolioDocumento.Width = 70;
      this.TipoDocumento.DataPropertyName = "TipoDocumento";
      this.TipoDocumento.HeaderText = "TipoDocumento";
      this.TipoDocumento.Name = "TipoDocumento";
      this.TipoDocumento.ReadOnly = true;
      this.TipoDocumento.Visible = false;
      this.TipoDocumentoNombre.DataPropertyName = "TipoDocumentoNombre";
      this.TipoDocumentoNombre.HeaderText = "Documento";
      this.TipoDocumentoNombre.Name = "TipoDocumentoNombre";
      this.TipoDocumentoNombre.ReadOnly = true;
      this.TipoDocumentoNombre.Width = 120;
      this.FolioDocumentoReferencia.DataPropertyName = "FolioDocumentoReferencia";
      this.FolioDocumentoReferencia.HeaderText = "N° Ref.";
      this.FolioDocumentoReferencia.Name = "FolioDocumentoReferencia";
      this.FolioDocumentoReferencia.ReadOnly = true;
      this.FolioDocumentoReferencia.Width = 70;
      this.FechaDocumentoReferencia.DataPropertyName = "FechaDocumentoReferencia";
      gridViewCellStyle5.Format = "d";
      gridViewCellStyle5.NullValue = (object) null;
      this.FechaDocumentoReferencia.DefaultCellStyle = gridViewCellStyle5;
      this.FechaDocumentoReferencia.HeaderText = "Fecha";
      this.FechaDocumentoReferencia.Name = "FechaDocumentoReferencia";
      this.FechaDocumentoReferencia.ReadOnly = true;
      this.FechaDocumentoReferencia.Width = 80;
      this.TipoAccion.DataPropertyName = "TipoAccion";
      this.TipoAccion.HeaderText = "TipoAccion";
      this.TipoAccion.Name = "TipoAccion";
      this.TipoAccion.ReadOnly = true;
      this.TipoAccion.Visible = false;
      this.TipoAccionNombre.DataPropertyName = "TipoAccionNombre";
      this.TipoAccionNombre.HeaderText = "Tipo Accion";
      this.TipoAccionNombre.Name = "TipoAccionNombre";
      this.TipoAccionNombre.ReadOnly = true;
      this.TipoAccionNombre.Width = 130;
      this.RazonReferencia.DataPropertyName = "RazonReferencia";
      this.RazonReferencia.HeaderText = "Razon";
      this.RazonReferencia.Name = "RazonReferencia";
      this.RazonReferencia.ReadOnly = true;
      this.RazonReferencia.Width = 150;
      this.EliminaReferencia.HeaderText = "Eli.";
      this.EliminaReferencia.Name = "EliminaReferencia";
      this.EliminaReferencia.ReadOnly = true;
      this.EliminaReferencia.Text = "X";
      this.EliminaReferencia.UseColumnTextForButtonValue = true;
      this.EliminaReferencia.Width = 50;
      this.btnBuscaCotizacion.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaCotizacion.Location = new Point(21, 74);
      this.btnBuscaCotizacion.Name = "btnBuscaCotizacion";
      this.btnBuscaCotizacion.Size = new Size(149, 23);
      this.btnBuscaCotizacion.TabIndex = 2;
      this.btnBuscaCotizacion.Text = "BUSCAR";
      this.btnBuscaCotizacion.UseVisualStyleBackColor = true;
      this.btnBuscaCotizacion.Click += new EventHandler(this.btnBuscaCotizacion_Click);
      this.txtFolioCotizacion.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFolioCotizacion.Location = new Point(21, 42);
      this.txtFolioCotizacion.Name = "txtFolioCotizacion";
      this.txtFolioCotizacion.Size = new Size(148, 26);
      this.txtFolioCotizacion.TabIndex = 1;
      this.txtFolioCotizacion.TextAlign = HorizontalAlignment.Center;
      this.txtFolioCotizacion.KeyPress += new KeyPressEventHandler(this.txtFolioCotizacion_KeyPress);
      this.label36.BackColor = Color.Blue;
      this.label36.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label36.ForeColor = Color.White;
      this.label36.Location = new Point(21, 24);
      this.label36.Name = "label36";
      this.label36.Size = new Size(149, 18);
      this.label36.TabIndex = 0;
      this.label36.Text = "COTIZACIÓN N°";
      this.label36.TextAlign = ContentAlignment.TopCenter;
      this.btnSalirBuscaCoti.Location = new Point(161, -1);
      this.btnSalirBuscaCoti.Name = "btnSalirBuscaCoti";
      this.btnSalirBuscaCoti.Size = new Size(28, 23);
      this.btnSalirBuscaCoti.TabIndex = 3;
      this.btnSalirBuscaCoti.Text = "X";
      this.btnSalirBuscaCoti.UseVisualStyleBackColor = true;
      this.btnSalirBuscaCoti.Click += new EventHandler(this.btnSalirBuscaCoti_Click);
      this.pnlCotizacionBuscar.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.pnlCotizacionBuscar.BorderStyle = BorderStyle.FixedSingle;
      this.pnlCotizacionBuscar.Controls.Add((Control) this.btnBuscaCotizacion);
      this.pnlCotizacionBuscar.Controls.Add((Control) this.btnSalirBuscaCoti);
      this.pnlCotizacionBuscar.Controls.Add((Control) this.txtFolioCotizacion);
      this.pnlCotizacionBuscar.Controls.Add((Control) this.label36);
      this.pnlCotizacionBuscar.Location = new Point(380, 151);
      this.pnlCotizacionBuscar.Name = "pnlCotizacionBuscar";
      this.pnlCotizacionBuscar.Size = new Size(190, 110);
      this.pnlCotizacionBuscar.TabIndex = 37;
      this.panelNotaVenta.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.panelNotaVenta.BorderStyle = BorderStyle.FixedSingle;
      this.panelNotaVenta.Controls.Add((Control) this.btnCierraNota);
      this.panelNotaVenta.Controls.Add((Control) this.btnBuscaNotaventa);
      this.panelNotaVenta.Controls.Add((Control) this.txtFolioNotaVenta);
      this.panelNotaVenta.Controls.Add((Control) this.label37);
      this.panelNotaVenta.Location = new Point(465, 143);
      this.panelNotaVenta.Name = "panelNotaVenta";
      this.panelNotaVenta.Size = new Size(192, 106);
      this.panelNotaVenta.TabIndex = 38;
      this.btnCierraNota.Location = new Point(162, 0);
      this.btnCierraNota.Name = "btnCierraNota";
      this.btnCierraNota.Size = new Size(29, 23);
      this.btnCierraNota.TabIndex = 3;
      this.btnCierraNota.Text = "X";
      this.btnCierraNota.UseVisualStyleBackColor = true;
      this.btnCierraNota.Click += new EventHandler(this.btnCierraNota_Click);
      this.btnBuscaNotaventa.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaNotaventa.Location = new Point(21, 73);
      this.btnBuscaNotaventa.Name = "btnBuscaNotaventa";
      this.btnBuscaNotaventa.Size = new Size(148, 23);
      this.btnBuscaNotaventa.TabIndex = 2;
      this.btnBuscaNotaventa.Text = "BUSCAR";
      this.btnBuscaNotaventa.UseVisualStyleBackColor = true;
      this.btnBuscaNotaventa.Click += new EventHandler(this.btnBuscaNotaventa_Click);
      this.txtFolioNotaVenta.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFolioNotaVenta.Location = new Point(21, 42);
      this.txtFolioNotaVenta.Name = "txtFolioNotaVenta";
      this.txtFolioNotaVenta.Size = new Size(148, 26);
      this.txtFolioNotaVenta.TabIndex = 1;
      this.txtFolioNotaVenta.TextAlign = HorizontalAlignment.Center;
      this.txtFolioNotaVenta.KeyPress += new KeyPressEventHandler(this.txtFolioNotaVenta_KeyPress);
      this.label37.BackColor = Color.Blue;
      this.label37.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label37.ForeColor = Color.White;
      this.label37.Location = new Point(21, 24);
      this.label37.Name = "label37";
      this.label37.Size = new Size(149, 18);
      this.label37.TabIndex = 0;
      this.label37.Text = "NOTA DE VENTA N°";
      this.label37.TextAlign = ContentAlignment.TopCenter;
      this.btnVerificaCredito.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnVerificaCredito.Location = new Point(721, 68);
      this.btnVerificaCredito.Name = "btnVerificaCredito";
      this.btnVerificaCredito.Size = new Size(32, 21);
      this.btnVerificaCredito.TabIndex = 39;
      this.btnVerificaCredito.Text = "VC";
      this.toolTip1.SetToolTip((Control) this.btnVerificaCredito, "Verificar Credito del Cliente");
      this.btnVerificaCredito.UseVisualStyleBackColor = true;
      this.btnVerificaCredito.Click += new EventHandler(this.button1_Click_1);
      this.button1.Location = new Point(820, 638);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 40;
      this.button1.Text = "UsarFactura";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.button1_Click_3);
      this.button2.Location = new Point(723, 634);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 41;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Visible = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.panelZonaCliente.BackColor = Color.FromArgb(223, 233, 245);
      this.panelZonaCliente.Controls.Add((Control) this.txtCreditoDisponible);
      this.panelZonaCliente.Controls.Add((Control) this.txtRut);
      this.panelZonaCliente.Controls.Add((Control) this.label38);
      this.panelZonaCliente.Controls.Add((Control) this.txtDigito);
      this.panelZonaCliente.Controls.Add((Control) this.btnBuscaCliente);
      this.panelZonaCliente.Controls.Add((Control) this.txtRazonSocial);
      this.panelZonaCliente.Controls.Add((Control) this.label21);
      this.panelZonaCliente.Controls.Add((Control) this.label4);
      this.panelZonaCliente.Controls.Add((Control) this.txtDiasPlazo);
      this.panelZonaCliente.Controls.Add((Control) this.label5);
      this.panelZonaCliente.Controls.Add((Control) this.txtContacto);
      this.panelZonaCliente.Controls.Add((Control) this.txtDireccion);
      this.panelZonaCliente.Controls.Add((Control) this.label12);
      this.panelZonaCliente.Controls.Add((Control) this.txtComuna);
      this.panelZonaCliente.Controls.Add((Control) this.label11);
      this.panelZonaCliente.Controls.Add((Control) this.txtFax);
      this.panelZonaCliente.Controls.Add((Control) this.txtCiudad);
      this.panelZonaCliente.Controls.Add((Control) this.label10);
      this.panelZonaCliente.Controls.Add((Control) this.txtGiro);
      this.panelZonaCliente.Controls.Add((Control) this.label9);
      this.panelZonaCliente.Controls.Add((Control) this.txtFono);
      this.panelZonaCliente.Controls.Add((Control) this.btnVerificaCredito);
      this.panelZonaCliente.Controls.Add((Control) this.label8);
      this.panelZonaCliente.Controls.Add((Control) this.label7);
      this.panelZonaCliente.Controls.Add((Control) this.label6);
      this.panelZonaCliente.Location = new Point(12, 78);
      this.panelZonaCliente.Name = "panelZonaCliente";
      this.panelZonaCliente.Size = new Size(761, 93);
      this.panelZonaCliente.TabIndex = 42;
      this.panel3.BackColor = Color.White;
      this.panel3.Location = new Point(11, 173);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(951, 46);
      this.panel3.TabIndex = 43;
      this.panel4.BackColor = Color.White;
      this.panel4.Location = new Point(11, 77);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(763, 95);
      this.panel4.TabIndex = 44;
      this.label1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new Point(6, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(102, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Emision";
      this.label2.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Black;
      this.label2.Location = new Point(113, 12);
      this.label2.Name = "label2";
      this.label2.Size = new Size(95, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Vencimiento";
      this.dtpEmision.Format = DateTimePickerFormat.Short;
      this.dtpEmision.Location = new Point(6, 29);
      this.dtpEmision.Name = "dtpEmision";
      this.dtpEmision.Size = new Size(104, 20);
      this.dtpEmision.TabIndex = 0;
      this.dtpEmision.ValueChanged += new EventHandler(this.dtpEmision_ValueChanged);
      this.dtpVencimiento.Format = DateTimePickerFormat.Short;
      this.dtpVencimiento.Location = new Point(113, 29);
      this.dtpVencimiento.Name = "dtpVencimiento";
      this.dtpVencimiento.Size = new Size(96, 20);
      this.dtpVencimiento.TabIndex = 1;
      this.gbZonaFechas.Controls.Add((Control) this.dtpVencimiento);
      this.gbZonaFechas.Controls.Add((Control) this.dtpEmision);
      this.gbZonaFechas.Controls.Add((Control) this.label2);
      this.gbZonaFechas.Controls.Add((Control) this.label1);
      this.gbZonaFechas.Location = new Point(11, 21);
      this.gbZonaFechas.Name = "gbZonaFechas";
      this.gbZonaFechas.Size = new Size(214, 55);
      this.gbZonaFechas.TabIndex = 24;
      this.gbZonaFechas.TabStop = false;
      this.btnCreaPdf.Location = new Point(12, 638);
      this.btnCreaPdf.Name = "btnCreaPdf";
      this.btnCreaPdf.Size = new Size(75, 23);
      this.btnCreaPdf.TabIndex = 46;
      this.btnCreaPdf.Text = "Crea Pdf";
      this.btnCreaPdf.UseVisualStyleBackColor = true;
      this.btnCreaPdf.Visible = false;
      this.btnCreaPdf.Click += new EventHandler(this.btnCreaPdf_Click);
      this.btnComprobarFolio.BackgroundImage = (Image) Resources.comprobar_si_puede_icono_8214_48;
      this.btnComprobarFolio.BackgroundImageLayout = ImageLayout.Zoom;
      this.btnComprobarFolio.FlatAppearance.BorderSize = 0;
      this.btnComprobarFolio.FlatStyle = FlatStyle.Flat;
      this.btnComprobarFolio.Location = new Point(967, 45);
      this.btnComprobarFolio.Name = "btnComprobarFolio";
      this.btnComprobarFolio.Size = new Size(30, 30);
      this.btnComprobarFolio.TabIndex = 45;
      this.btnComprobarFolio.UseVisualStyleBackColor = true;
      this.btnComprobarFolio.Click += new EventHandler(this.btnComprobarFolio_Click);
      this.btnModificaLinea.Image = (Image) Resources.modificalista_32;
      this.btnModificaLinea.Location = new Point(966, 253);
      this.btnModificaLinea.Name = "btnModificaLinea";
      this.btnModificaLinea.Size = new Size(40, 40);
      this.btnModificaLinea.TabIndex = 33;
      this.toolTip1.SetToolTip((Control) this.btnModificaLinea, "Modificar Producto");
      this.btnModificaLinea.UseVisualStyleBackColor = true;
      this.btnModificaLinea.Click += new EventHandler(this.btnModificaLinea_Click);
      this.btnAgregar.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAgregar.Image = (Image) Resources.construccion_de_anadir_icono_5620_32;
      this.btnAgregar.Location = new Point(966, 173);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(40, 40);
      this.btnAgregar.TabIndex = 16;
      this.btnAgregar.Tag = (object) "Agregar";
      this.btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
      this.toolTip1.SetToolTip((Control) this.btnAgregar, "Agregar Producto");
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.btnLimpiaDetalle.Image = (Image) Resources.construccion_de_eliminar_icono_9418_32;
      this.btnLimpiaDetalle.Location = new Point(966, 213);
      this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
      this.btnLimpiaDetalle.Size = new Size(40, 40);
      this.btnLimpiaDetalle.TabIndex = 17;
      this.toolTip1.SetToolTip((Control) this.btnLimpiaDetalle, "Limpiar Grilla");
      this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaDetalle.Click += new EventHandler(this.btnLimpiaDetalle_Click);
      this.btnAnular.BackgroundImageLayout = ImageLayout.Center;
      this.btnAnular.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAnular.Image = (Image) Resources.eliminar_pagina_icono_7071_32;
      this.btnAnular.Location = new Point(151, 77);
      this.btnAnular.Name = "btnAnular";
      this.btnAnular.Size = new Size(70, 70);
      this.btnAnular.TabIndex = 48;
      this.btnAnular.Text = "Anula";
      this.btnAnular.TextAlign = ContentAlignment.BottomCenter;
      this.btnAnular.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnAnular.UseVisualStyleBackColor = true;
      this.btnAnular.Click += new EventHandler(this.btnAnular_Click);
      this.btnImprime.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnImprime.Image = (Image) Resources.imprimir_48;
      this.btnImprime.Location = new Point(295, 77);
      this.btnImprime.Name = "btnImprime";
      this.btnImprime.Size = new Size(70, 70);
      this.btnImprime.TabIndex = 26;
      this.btnImprime.Text = "Imprimir";
      this.btnImprime.TextAlign = ContentAlignment.BottomCenter;
      this.btnImprime.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnImprime.UseVisualStyleBackColor = true;
      this.btnImprime.Click += new EventHandler(this.btnImprime_Click);
      this.btnGuardar.BackgroundImageLayout = ImageLayout.Center;
      this.btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Image = (Image) Resources.disquetes_excepto_icono_7120_48;
      this.btnGuardar.Location = new Point(7, 77);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(70, 70);
      this.btnGuardar.TabIndex = 19;
      this.btnGuardar.Text = "Guarda";
      this.btnGuardar.TextAlign = ContentAlignment.BottomCenter;
      this.btnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Image = (Image) Resources.salir_de_mi_perfil_icono_3964_48;
      this.btnSalir.Location = new Point(464, 77);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(70, 70);
      this.btnSalir.TabIndex = 23;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextAlign = ContentAlignment.BottomCenter;
      this.btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnModificar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnModificar.Image = (Image) Resources.modificar_48;
      this.btnModificar.Location = new Point(79, 77);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(70, 70);
      this.btnModificar.TabIndex = 20;
      this.btnModificar.Text = "Modifica";
      this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
      this.btnModificar.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnEliminar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEliminar.Image = (Image) Resources.mark_correo_basura_icono_3897_48;
      this.btnEliminar.Location = new Point(223, 77);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(70, 70);
      this.btnEliminar.TabIndex = 21;
      this.btnEliminar.Text = "Elimina";
      this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
      this.btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Image = (Image) Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
      this.btnLimpiar.Location = new Point(367, 77);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(70, 70);
      this.btnLimpiar.TabIndex = 22;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
      this.btnLimpiar.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.button7_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1352, 667);
      this.Controls.Add((Control) this.btnCreaPdf);
      this.Controls.Add((Control) this.panelFolio);
      this.Controls.Add((Control) this.btnComprobarFolio);
      this.Controls.Add((Control) this.txtTicket);
      this.Controls.Add((Control) this.pnlCotizacionBuscar);
      this.Controls.Add((Control) this.label33);
      this.Controls.Add((Control) this.panelNotaVenta);
      this.Controls.Add((Control) this.pnlBuscaClienteDes);
      this.Controls.Add((Control) this.panelZonaCliente);
      this.Controls.Add((Control) this.panelZonaDetalle);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.txtTipoDescuento);
      this.Controls.Add((Control) this.btnModificaLinea);
      this.Controls.Add((Control) this.txtSubTotalLinea);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.txtLinea);
      this.Controls.Add((Control) this.btnAgregar);
      this.Controls.Add((Control) this.btnLimpiaDetalle);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.dgvDatosVenta);
      this.Controls.Add((Control) this.gbZonaTicket);
      this.Controls.Add((Control) this.gbZonaOtros);
      this.Controls.Add((Control) this.gbZonaFechas);
      this.Controls.Add((Control) this.panel4);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmGuiaDespachoElectronica";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "52 - Guia Despacho Electronica";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmFactura_FormClosing);
      this.KeyDown += new KeyEventHandler(this.frmFactura_KeyDown);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((ISupportInitialize) this.dgvDatosVenta).EndInit();
      this.gbZonaOtros.ResumeLayout(false);
      this.gbZonaOtros.PerformLayout();
      this.panelZonaDetalle.ResumeLayout(false);
      this.panelZonaDetalle.PerformLayout();
      ((ISupportInitialize) this.dgvBuscaCliente).EndInit();
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
      ((ISupportInitialize) this.dgvReferencias).EndInit();
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
        if (usuarioVo.Modulo.Equals("E-GUIA"))
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
    }

    public void cargaOpcionesDocumentos()
    {
      this.alertaStock = this.odVO.AlertaStockInsuficiente;
      this.impideVentasSinStock = this.odVO.ImpideVentasSinStock;
      this.numeroLineas = this.odVO.CantidadLineasDocumento;
      this.decimalesValoresVenta = this.odVO.DecimalesValorVenta.ToString();
      this.envioAutomaticoSii = this.odVO.EnvioAutomaticoSII;
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
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void obtieneFolioGuiaDisponible()
    {
      int folio = new EGuia().numeroGuia(this._caja);
      this.txtNumeroDocumento.Text = folio.ToString();
      string archivoCaf = new Caf().archivoCaf(52, folio);
      bool flag = true; SubeXMLToDb sube = new SubeXMLToDb();
      sube.RecuperaCaf("52", @"\CAF\");
      if (this.compruebaExisteArchivoCaf(archivoCaf))
      {
        if (archivoCaf.Length == 0)
        {
          int num = (int) MessageBox.Show("No hay folios CAF disponibles, debe solicitar a SII y cargar en sistema", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this._guarda = false;
          flag = false;
        }
        if (this._guarda || !flag)
          return;
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
      if (File.Exists(this._rutaElectronica + "CAF\\E-Guia\\" + archivoCaf))
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
          this.lblImp1.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp1.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
        if (impuestoVo.IdImpuesto == 2)
        {
          this.lblImp2.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp2.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
        if (impuestoVo.IdImpuesto == 3)
        {
          this.lblImp3.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp3.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
        if (impuestoVo.IdImpuesto == 4)
        {
          this.lblImp4.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp4.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
        if (impuestoVo.IdImpuesto == 5)
        {
          this.lblImp5.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp5.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
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

    private void cargaBodegaDestino()
    {
      this.cmbBodegaDestino.DataSource = (object) new CargaMaestros().cargaBodega();
      this.cmbBodegaDestino.ValueMember = "codigo";
      this.cmbBodegaDestino.DisplayMember = "descripcion";
      if (this._bodega == 0)
      {
        this.cmbBodegaDestino.Enabled = true;
        this.cmbBodegaDestino.SelectedValue = (object) 1;
        this._modBodega = true;
      }
      else
      {
        this.cmbBodegaDestino.Enabled = false;
        this.cmbBodegaDestino.SelectedValue = (object) this._bodega;
        this._modBodega = false;
      }
      this.cmbBodegaDestino.Enabled = false;
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
      this.btnComprobarFolio.Visible = false;
      this.buscaOT = false;
      this.cmbMedioPago.Enabled = true;
      this.cargaMediosPago();
      this.lblFacturada.Visible = false;
      this.cargaVendedores();
      this.cargaCentroCosto();
      this.cargaImpuestos();
      this.cargaBodega();
      this.cargaBodegaDestino();
      this.cargaListaPrecio();
      this.codigoCliente = 0;
      this.cargaOpcionesDocumentos();
      this.txtPorIva.Text = this.ivaInicio.ToString("N0");
      this.btnCreaPdf.Visible = false;
      this.cargaTiposDeTraslado();
      this.cargaTrasladadoPor();
      try
      {
        this.obtieneFolioGuiaDisponible();
        this.txtNumeroDocumento.Enabled = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar Folio: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this._timbre = "";
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
      this.btnEliminar.Enabled = false;
      this.btnImprime.Enabled = false;
      this.btnAnular.Enabled = false;
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
      this.idGuia = 0;
      this.idTicket = 0;
      this.hayTicket = false;
      this.hayCotizacion = false;
      this.hayNotaVenta = false;
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
      this.dgvDatosVenta.Columns[2].Width = 250;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Bodega", "Bo");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "Bodega";
      this.dgvDatosVenta.Columns[3].Width = 40;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgvDatosVenta.Columns.Add("BodegaDestino", "Bd");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "BodegaDestino";
      this.dgvDatosVenta.Columns[4].Width = 40;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgvDatosVenta.Columns.Add("ValorVenta", "Precio");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "ValorVenta";
      this.dgvDatosVenta.Columns[5].Width = 80;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Cantidad", "Cantidad");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "Cantidad";
      this.dgvDatosVenta.Columns[6].Width = 70;
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Format = "N4";
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("PorcDescuento", "% Desc.");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "PorcDescuento";
      this.dgvDatosVenta.Columns[7].Width = 65;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Descuento", "$ Desc.");
      this.dgvDatosVenta.Columns[8].DataPropertyName = "Descuento";
      this.dgvDatosVenta.Columns[8].Width = 70;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Total", "Total");
      this.dgvDatosVenta.Columns[9].DataPropertyName = "TotalLinea";
      this.dgvDatosVenta.Columns[9].Width = 90;
      this.dgvDatosVenta.Columns[9].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("SubTotal", "SubTotal");
      this.dgvDatosVenta.Columns[10].DataPropertyName = "SubTotalLinea";
      this.dgvDatosVenta.Columns[10].Width = 90;
      this.dgvDatosVenta.Columns[10].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[10].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[10].Visible = false;
      this.dgvDatosVenta.Columns.Add("TipoDescuento", "TipoDescuento");
      this.dgvDatosVenta.Columns[11].DataPropertyName = "TipoDescuento";
      this.dgvDatosVenta.Columns[11].Width = 90;
      this.dgvDatosVenta.Columns[11].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[11].Visible = false;
      this.dgvDatosVenta.Columns.Add("ListaPrecio", "ListaPrecio");
      this.dgvDatosVenta.Columns[12].DataPropertyName = "ListaPrecio";
      this.dgvDatosVenta.Columns[12].Width = 90;
      this.dgvDatosVenta.Columns[12].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[12].Visible = false;
      this.dgvDatosVenta.Columns.Add("FolioFactura", "FolioFactura");
      this.dgvDatosVenta.Columns[13].DataPropertyName = "FolioFactura";
      this.dgvDatosVenta.Columns[13].Width = 90;
      this.dgvDatosVenta.Columns[13].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[13].Visible = false;
      this.dgvDatosVenta.Columns.Add("IdFactura", "IdFactura");
      this.dgvDatosVenta.Columns[14].DataPropertyName = "IdFactura";
      this.dgvDatosVenta.Columns[14].Width = 90;
      this.dgvDatosVenta.Columns[14].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[14].Visible = false;
      DataGridViewButtonColumn viewButtonColumn1 = new DataGridViewButtonColumn();
      viewButtonColumn1.Name = "Eliminar";
      viewButtonColumn1.HeaderText = "Eliminar";
      viewButtonColumn1.UseColumnTextForButtonValue = true;
      viewButtonColumn1.Text = "X";
      viewButtonColumn1.Width = 50;
      viewButtonColumn1.DisplayIndex = 15;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn1);
      this.dgvDatosVenta.Columns.Add("IdImpuesto", "IdImpuesto");
      this.dgvDatosVenta.Columns[16].DataPropertyName = "IdImpuesto";
      this.dgvDatosVenta.Columns[16].Width = 90;
      this.dgvDatosVenta.Columns[16].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[16].Visible = false;
      this.dgvDatosVenta.Columns.Add("NetoLinea", "NetoLinea");
      this.dgvDatosVenta.Columns[17].DataPropertyName = "NetoLinea";
      this.dgvDatosVenta.Columns[17].Width = 90;
      this.dgvDatosVenta.Columns[17].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[17].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[17].Visible = false;
      this.dgvDatosVenta.Columns.Add("DescuentaInventario", "DescuentaInventario");
      this.dgvDatosVenta.Columns[18].DataPropertyName = "DescuentaInventario";
      this.dgvDatosVenta.Columns[18].Width = 90;
      this.dgvDatosVenta.Columns[18].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[18].Visible = false;
      this.dgvDatosVenta.Columns.Add("ValorCompra", "ValorCompra");
      this.dgvDatosVenta.Columns[19].DataPropertyName = "ValorCompra";
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
      this.txtTotalDescuento.ReadOnly = true;
      this.txtPorcDescuentoTotal.ReadOnly = true;
      DatosVentaVO datosVentaVo = new DatosVentaVO();
      datosVentaVo.Codigo = this.txtCodigo.Text.Trim().ToUpper();
      datosVentaVo.Descripcion = this.txtDescripcion.Text.Trim();
      datosVentaVo.IdImpuesto = this.idImpuesto;
      datosVentaVo.NetoLinea = this.netoLinea;
      datosVentaVo.DescuentaInventario = true;
      datosVentaVo.ValorCompra = this.valorCompra;
      datosVentaVo.ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
      datosVentaVo.Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
      if (datosVentaVo.Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && this.txtCodigo.Text.Length > 0)
      {
        int num = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Imposible Hacer Venta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCantidad.Focus();
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
        datosVentaVo.BodegaDestino = !this.cmbBodegaDestino.Enabled ? 0 : Convert.ToInt32(this.cmbBodegaDestino.SelectedValue.ToString());
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
                this.txtCantidad.Focus();
                flag = true;
              }
              else if (datosVentaVo.Codigo.Length > 0 && datosVentaVo.Codigo == this.lista[index].Codigo && (datosVentaVo.ValorVenta == this.lista[index].ValorVenta && datosVentaVo.ListaPrecio == this.lista[index].ListaPrecio) && datosVentaVo.Bodega == this.lista[index].Bodega && datosVentaVo.DescuentaInventario == this.lista[index].DescuentaInventario)
              {
                flag = false;
                Calculos calculos = new Calculos();
                this.lista[index].Cantidad = this.lista[index].Cantidad + datosVentaVo.Cantidad;
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
              }
            }
            if (!flag)
            {
              this.lista.Add(datosVentaVo);
              this.limpiaEntradaDetalle();
              this.calculaTotales();
              this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
            }
          }
          else
          {
            this.lista.Add(datosVentaVo);
            this.limpiaEntradaDetalle();
            this.calculaTotales();
            this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
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
        this.txtTotalImp1.Text = "";
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
      this.txtTotalGeneral.Text = num6.ToString("N" + this.decimalesValoresVenta);
      this.txtTotalDescuento.Text = calculos.totalDescuentoFacturaElectronica(this.lista).ToString("N" + this.decimalesValoresVenta);
      Decimal neto = calculos.totalNeto2(this.lista);
      TextBox textBox1 = this.txtSubTotal;
      num5 = calculos.totalSubTotalBoleta(this.lista);
      string str1 = num5.ToString("N" + this.decimalesValoresVenta);
      textBox1.Text = str1;
      TextBox textBox2 = this.txtIva;
      num5 = calculos.totalIva(neto);
      string str2 = num5.ToString("N" + this.decimalesValoresVenta);
      textBox2.Text = str2;
      this.txtNeto.Text = neto.ToString("N" + this.decimalesValoresVenta);
      Decimal num7 = calculos.totalGeneralBoletaExento(this.lista);
      this.txtTotalExento.Text = num7.ToString("N" + this.decimalesValoresVenta);
      this.txtTotalGeneral.Text = (num6 + num7).ToString("N" + this.decimalesValoresVenta);
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
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "guia_electronica").ShowDialog();
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
      int num = (int) new frmBuscaClientes(ref this.intance, "guia_electronica").ShowDialog();
    }

    private void txtRazonSocial_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRazonSocial.Text.Trim().Length > 0 && this.txtRut.Text.Trim().Length == 0)
      {
        this.pnlBuscaClienteDes.Visible = true;
        List<ClienteVO> list = new Cliente().buscaClienteDato(1, this.txtRazonSocial.Text.Trim());
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
      this.dgvBuscaCliente.Columns.Add("Rut", "Rut");
      this.dgvBuscaCliente.Columns[1].DataPropertyName = "Rut";
      this.dgvBuscaCliente.Columns[1].Width = 80;
      this.dgvBuscaCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaCliente.Columns.Add("Digito", "");
      this.dgvBuscaCliente.Columns[2].DataPropertyName = "Digito";
      this.dgvBuscaCliente.Columns[2].Width = 20;
      this.dgvBuscaCliente.Columns.Add("RazonSocial", "Razon Social");
      this.dgvBuscaCliente.Columns[3].DataPropertyName = "RazonSocial";
      this.dgvBuscaCliente.Columns[3].Width = 270;
      this.dgvBuscaCliente.Columns.Add("Direccion", "Direccion");
      this.dgvBuscaCliente.Columns[4].DataPropertyName = "Direccion";
      this.dgvBuscaCliente.Columns[4].Width = 226;
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

    private void guardaGuia()
    {
      if (!this.validaCampos())
        return;
      DateTime dateTime1 =DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local1 = @dateTime1;
      int year1 = this.dtpEmision.Value.Year;
      int month1 = this.dtpEmision.Value.Month;
      int day1 = this.dtpEmision.Value.Day;
      TimeSpan timeOfDay1 = DateTime.Now.TimeOfDay;
      int hours1 = timeOfDay1.Hours;
      DateTime now1 = DateTime.Now;
      timeOfDay1 = now1.TimeOfDay;
      int minutes1 = timeOfDay1.Minutes;
      now1 = DateTime.Now;
      timeOfDay1 = now1.TimeOfDay;
      int seconds1 = timeOfDay1.Seconds;
      // ISSUE: explicit reference operation
      local1 = new DateTime(year1, month1, day1, hours1, minutes1, seconds1);
      DateTime dateTime2=DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local2 = @dateTime2;
      now1 = this.dtpVencimiento.Value;
      int year2 = now1.Year;
      int month2 = this.dtpVencimiento.Value.Month;
      int day2 = this.dtpVencimiento.Value.Day;
      TimeSpan timeOfDay2 = DateTime.Now.TimeOfDay;
      int hours2 = timeOfDay2.Hours;
      DateTime now2 = DateTime.Now;
      timeOfDay2 = now2.TimeOfDay;
      int minutes2 = timeOfDay2.Minutes;
      now2 = DateTime.Now;
      timeOfDay2 = now2.TimeOfDay;
      int seconds2 = timeOfDay2.Seconds;
      // ISSUE: explicit reference operation
      local2 = new DateTime(year2, month2, day2, hours2, minutes2, seconds2);
      Venta venta = new Venta();
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
      venta.FE_codigoTipoGuia = Convert.ToInt32(this.cmbTipoTraslado.SelectedValue.ToString());
      venta.FE_tipoGuia = this.cmbTipoTraslado.Text;
      venta.FE_codigoTrasladadaPor = Convert.ToInt32(this.cmbTrasladadoPor.SelectedValue.ToString());
      venta.FE_trasladadoPor = this.cmbTrasladadoPor.Text;
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
      venta.Observaciones = this.txtObservaciones.Text.Trim().ToUpper();
      if (this.hayTicket)
      {
        venta.FolioTicket = this.veOBFactura.Folio;
        venta.IdTicket = this.idGuia;
      }
      else
      {
        venta.FolioTicket = 0;
        venta.IdTicket = 0;
      }
      if (this.hayCotizacion)
      {
        venta.FolioCotizacion = this.veOBFactura.Folio;
        venta.IdCotizacion = this.idGuia;
      }
      else
      {
        venta.FolioCotizacion = 0;
        venta.IdCotizacion = 0;
      }
      if (this.hayNotaVenta)
      {
        venta.FolioNotaVenta = this.veOBFactura.Folio;
        venta.IdNotaVenta = this.idGuia;
      }
      else
      {
        venta.FolioNotaVenta = 0;
        venta.IdNotaVenta = 0;
      }
      venta.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
      venta.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
      venta.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
      venta.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
      venta.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
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
      venta.EstadoPago = "PAGADO";
      venta.TotalPagado = venta.Total;
      venta.TotalDocumentado = new Decimal(0);
      venta.TotalPendiente = new Decimal(0);
      venta.EstadoDocumento = "EMITIDA";
      EGuia eguia = new EGuia();
      bool flag = eguia.guiaExiste(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()));
      if (flag)
      {
          // int num2 = (int) MessageBox.Show("Ya Existe una Factura con el N°: " + this.txtNumeroDocumento.Text + " Debe Modificar el Folio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.txtNumeroDocumento.Enabled = false;
          Decimal aux = Decimal.Add(Convert.ToDecimal(eguia.UltimoFolio()), 1);
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
        eguia.agregaGuia(venta);
        eguia.agregaDetalleGuia(this.lista, this._listaLote);
        if (this.listaReferencias.Count > 0)
          eguia.agregaReferencia(this.listaReferencias);
        this.creaXML(venta, this.lista);
        if (MessageBox.Show("¿Desea Crear Archivo Pdf?", "Crear PDF", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {
            this.creaPDF();
        }
        this.cambiaEstadoCotizacion();
        this.cambiaEstadoNotaVenta();
        int folio = Convert.ToInt32(this.txtNumeroDocumento.Text);
        int num1 = this.codigoCliente;
        SubeXMLToDb sube = new SubeXMLToDb();
        sube.Sube("GuiaDespacho_Electronica", venta.Folio.ToString(), @"DTE\\E-Guia\\", "EGuia_" + folio.ToString("##"));
        limpiar = true;
        if (this.envioAutomaticoSii.Equals("1") && MessageBox.Show("¿ Desea Enviar el DTE a SII ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          string ruta = this._rutaElectronica + "DTE\\E-Guia\\";
          int num2 = (int) new frmEnviosSII("EGuia_" + folio.ToString("##") + "_"+multi+ "_envio.XML", ruta, new List<Venta>()
          {
            new Venta()
            {
              Folio = folio,
              Fe_TipoDTE = 52
            }
          }, "ENVIO").ShowDialog();
        }
        this.imprimeGuia(folio);
      }
      if (limpiar)
      {
          this.iniciaVenta();
      }
    }

    private void creaXML(Venta ve, List<DatosVentaVO> listaDetalle)
    {
      ve.Fe_TipoDTE = 52;
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
      this.armaCodigoPDF417("EGuia_" + ve.Folio.ToString("##")+"_"+multi);
    }

    private void imprimeGuia(int folio)
    {
      //if (MessageBox.Show("Desea Imprimir la Guia?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        this.imprimeDirecto();
      //else
      //  this.iniciaVenta();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaGuia();
    }

    private void guardarFacturaTeclaF2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.guardaGuia();
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
      DialogResult dialogResult = MessageBox.Show("Esta Seguro de Modificar la Guia ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      DateTime dateTime1 =DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local1 = @dateTime1;
      DateTime now1 = this.dtpEmision.Value;
      int year1 = now1.Year;
      now1 = this.dtpEmision.Value;
      int month1 = now1.Month;
      now1 = this.dtpEmision.Value;
      int day1 = now1.Day;
      now1 = DateTime.Now;
      TimeSpan timeOfDay1 = now1.TimeOfDay;
      int hours1 = timeOfDay1.Hours;
      now1 = DateTime.Now;
      timeOfDay1 = now1.TimeOfDay;
      int minutes1 = timeOfDay1.Minutes;
      now1 = DateTime.Now;
      timeOfDay1 = now1.TimeOfDay;
      int seconds1 = timeOfDay1.Seconds;
      // ISSUE: explicit reference operation
      local1 = new DateTime(year1, month1, day1, hours1, minutes1, seconds1);
      DateTime dateTime2=DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local2 = @dateTime2;
      DateTime now2 = this.dtpVencimiento.Value;
      int year2 = now2.Year;
      now2 = this.dtpVencimiento.Value;
      int month2 = now2.Month;
      now2 = this.dtpVencimiento.Value;
      int day2 = now2.Day;
      now2 = DateTime.Now;
      TimeSpan timeOfDay2 = now2.TimeOfDay;
      int hours2 = timeOfDay2.Hours;
      now2 = DateTime.Now;
      timeOfDay2 = now2.TimeOfDay;
      int minutes2 = timeOfDay2.Minutes;
      now2 = DateTime.Now;
      timeOfDay2 = now2.TimeOfDay;
      int seconds2 = timeOfDay2.Seconds;
      // ISSUE: explicit reference operation
      local2 = new DateTime(year2, month2, day2, hours2, minutes2, seconds2);
      if (dialogResult == DialogResult.Yes)
      {
        if (!this.validaCampos())
          return;
        Venta venta = new Venta();
        venta.IdFactura = this.idGuia;
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
        venta.Observaciones = this.txtObservaciones.Text.Trim().ToUpper();
        venta.FE_codigoTipoGuia = Convert.ToInt32(this.cmbTipoTraslado.SelectedValue.ToString());
        venta.FE_tipoGuia = this.cmbTipoTraslado.Text;
        venta.FE_codigoTrasladadaPor = Convert.ToInt32(this.cmbTrasladadoPor.SelectedValue.ToString());
        venta.FE_trasladadoPor = this.cmbTrasladadoPor.Text;
        venta.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
        venta.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
        venta.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
        venta.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
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
        EGuia eguia = new EGuia();
        for (int index = 0; index < this.lista.Count; ++index)
        {
          this.lista[index].FechaIngreso = venta.FechaEmision;
          this.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }
        try
        {
          string text = eguia.modificaGuia(venta, this.lista, this._listaLote, this._listaLoteAntigua);
          this.creaXML(venta, this.lista);
          if (MessageBox.Show("¿Desea Crear Archivo Pdf?", "Crear PDF", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
          {
              this.creaPDF();
          }
          int num2 = (int) MessageBox.Show(text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          int num3 = Convert.ToInt32(this.txtNumeroDocumento.Text);
          SubeXMLToDb sube = new SubeXMLToDb();
            if(sube.existe(num3.ToString("##"), "52")){
                sube.Sube("GuiaDespacho_Electronica", venta.Folio.ToString(), @"DTE\\E-Guia\\", "EGuia_" + num3.ToString("##"));
            }
            else
            {
                sube.Actualizar("GuiaDespacho_Electronica", venta.Folio.ToString(), @"DTE\\E-Guia\\", "EGuia_" + num3.ToString("##"));
            }
          
          if (this.envioAutomaticoSii.Equals("1") && MessageBox.Show("¿ Desea Enviar el DTE a SII ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            string ruta = this._rutaElectronica + "DTE\\E-Guia\\";
            int num4 = (int) new frmEnviosSII("EGuia_" + num3.ToString("##") +"_"+multi+ "_envio.XML", ruta, new List<Venta>()
            {
              new Venta()
              {
                Folio = num3,
                Fe_TipoDTE = 52
              }
            }, "ENVIO").ShowDialog();
          }
          this.imprimeGuia(venta.Folio);
        }
        catch (Exception ex)
        {
          int num2 = (int) MessageBox.Show("Error al Modificar Guia Electronica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Guia NO fue Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
      if (this.lista.Count != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Datos a Guia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        int num = (int) new frmBuscaProductos("guia_electronica", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
        this.txtCantidad.Focus();
      }
      if (e.KeyCode == Keys.F6)
      {
        this.panelFolio.Visible = true;
        this.txtFolioBuscar.Focus();
      }
      if (e.KeyCode == Keys.F2 && this.btnGuardar.Enabled && this._guarda)
        this.guardaGuia();
      if (e.KeyCode != Keys.F12)
        return;
      this.btnCreaPdf.Visible = true;
    }

    private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaProductos("guia_electronica", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
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

    private void buscaGuiaFolio()
    {
      this.panelFolio.Visible = false;
      EGuia eguia = new EGuia();
      Venta venta = eguia.buscaGuiaFolio(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
      this.veOBFactura = venta;
      if (venta.IdFactura != 0)
      {
        this.iniciaVenta();
        this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = false;
        this.idGuia = venta.IdFactura;
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
        this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
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
        this.txtObservaciones.Text = venta.Observaciones;
        this.cmbTipoTraslado.SelectedValue = (object) venta.FE_codigoTipoGuia;
        this.cmbTrasladadoPor.SelectedValue = (object) venta.FE_codigoTrasladadaPor;
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
        this.btnGuardar.Enabled = false;
        this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
        if (!venta.FE_enviado_Sii)
        {
          if (this._elimina)
            this.btnEliminar.Enabled = true;
          if (this._modifica)
            this.btnModificar.Enabled = true;
          if (this._anula)
            this.btnAnular.Enabled = true;
        }
        else
        {
          this.btnEliminar.Enabled = false;
          this.btnModificar.Enabled = false;
          this.btnAnular.Enabled = false;
        }
        this.btnImprime.Enabled = true;
        this.lblEstadoDocumento.Text = venta.EstadoDocumento.ToString();
        this.lista = eguia.buscaDetalleGuiaIDGuia(venta.IdFactura);
        this.listaReferencias = eguia.buscaReferenciaIDGuia(venta.IdFactura);
        this.cmbBodega.SelectedValue = (object) this.lista[0].Bodega;
        for (int index = 0; index < this.lista.Count; ++index)
          this.lista[index].Linea = index + 1;
        this.dgvDatosVenta.DataSource = (object) null;
        this.dgvDatosVenta.DataSource = (object) this.lista;
        this.dgvReferencias.DataSource = (object) null;
        this.dgvReferencias.DataSource = (object) this.listaReferencias;
        if (venta.Facturada)
        {
            this.lblFacturada.Text = venta.DocumentoVenta + " FOLIO : " + venta.FolioFactura.ToString() ;
          this.lblFacturada.Visible = true;
        }
        this._listaLote.Clear();
        this._listaLote = new Lote().ListaLotePorDocumento("VENTA", "GUIA ELECTRONICA", venta.IdFactura);
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
        int num = (int) MessageBox.Show("No Existe Guia Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtFolioBuscar.Clear();
        this.iniciaVenta();
      }
    }

    private void btnBuscaFolio_Click(object sender, EventArgs e)
    {
      if (this.txtFolioBuscar.Text.Trim().Length > 0)
      {
        this.buscaGuiaFolio();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Folio a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtFolioBuscar.Focus();
      }
    }

    private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioBuscar);
      if ((int) e.KeyChar != 13)
        return;
      this.buscaGuiaFolio();
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

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar esta Guia.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        EGuia eguia = new EGuia();
        try
        {
          eguia.eliminaGuia(this.idGuia, this.lista, this._listaLoteAntigua);
          SubeXMLToDb sube = new SubeXMLToDb();
          sube.eliminar("GuiaDespacho_Electronica", this.lista[0].FolioFactura.ToString());
          if (this.hayTicket)
            this.cambiaEstadoTicketEliminaFactura();
          if (this.hayCotizacion)
            this.cambiaEstadoCotizacionEliminaFactura();
          if (this.hayNotaVenta)
            this.cambiaEstadoNotaVentaEliminaFactura();
          int num = (int) MessageBox.Show("Guia Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar Documento " + ex.Message);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Guia NO fue Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
      }
    }

    private void btnImprime_Click(object sender, EventArgs e)
    {
      this.imprimeDirecto();
    }

    private bool comprobarExistePDF()
    {
      return File.Exists(this._rutaElectronica + "PDF\\E-Guia\\EGuia_" + this.txtNumeroDocumento.Text + ".pdf");
    }

    private void imprimeDirecto()
    {
        if (MessageBox.Show("Imprimir Guia Despacho Electronica", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            EGuia efactura = new EGuia();
            DataTable dataTable = efactura.muestraGuiaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\AptuSoft\\reportes\\GuiaElectronica_"+multi+".rpt");
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

        if (MessageBox.Show("Imprimir Copia Cedible de la Guia Despacho Electronica", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            EGuia efactura = new EGuia();
            DataTable dataTable = efactura.muestraGuiaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\AptuSoft\\reportes\\GuiaElectronicaCedible_"+multi+".rpt");
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
            ArrayList arrayList = new ArrayList();
            string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
            csCreaPDF csCreaPdf = new csCreaPDF();
            string archivoRpt1;
            string archivoRpt2;
            if (frmMenuPrincipal._MultiEmpresa)
            {

                archivoRpt1 = "GuiaElectronica_" + str + ".rpt";
                archivoRpt2 = "GuiaElectronicaCedible_" + str + ".rpt";
            }
            else
            {
                archivoRpt1 = "GuiaElectronica_" + str + ".rpt";
                archivoRpt2 = "GuiaElectronicaCedible_" + str + ".rpt";
            }
            string nombre_archivo1 = "EGuia_" + this.txtNumeroDocumento.Text + "_" + str;
            int tipoDoc = 52;
            DataTable dt = new EGuia().muestraGuiaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            csCreaPdf.creaPDF(archivoRpt1, nombre_archivo1, tipoDoc, dt);
            string nombre_archivo2 = "EGuiaCedible_" + this.txtNumeroDocumento.Text + "_" + str;
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
      DataTable dataTable = new EGuia().muestraGuiaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
      ReportDocument rpt1 = new ReportDocument();
      rpt1.Load("C:\\AptuSoft\\reportes\\GuiaElectronica_" + str + ".rpt");
      rpt1.SetDataSource(dataTable);
      int num1 = (int) new frmVisualizadorReportes(rpt1).ShowDialog();
      ReportDocument rpt2 = new ReportDocument();
      rpt2.Load("C:\\AptuSoft\\reportes\\GuiaElectronicaCedible_" + str + ".rpt");
      rpt2.SetDataSource(dataTable);
      int num2 = (int) new frmVisualizadorReportes(rpt2).ShowDialog();
      this._timbre = string.Empty;
      this.iniciaVenta();
    }

    private void monoEmpresa()
    {
      DataTable dataTable = new EGuia().muestraGuiaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
      ReportDocument rpt1 = new ReportDocument();
      rpt1.Load("C:\\AptuSoft\\reportes\\GuiaElectronica_"+multi+".rpt");
      rpt1.SetDataSource(dataTable);
      int num1 = (int) new frmVisualizadorReportes(rpt1).ShowDialog();
      ReportDocument rpt2 = new ReportDocument();
      rpt2.Load("C:\\AptuSoft\\reportes\\GuiaElectronicaCedible_"+multi+".rpt");
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
            this.idGuia = venta.IdFactura;
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
            this.idGuia = venta.IdFactura;
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
            TextBox textBox15 = this.txtObservaciones;
            string str15 = "Cotizacion N°: ";
            num1 = venta.Folio;
            string str16 = num1.ToString();
            string str17 = str15 + str16;
            textBox15.Text = str17;
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
      string str = "GUIA ELECTRONICA";
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBFactura.IDDocumentoVenta = new EGuia().retornaIdGuia(this.veOBFactura.FolioDocumentoVenta);
      this.veOBFactura.DocumentoVenta = str;
      cotizacion.modificaTipoDocumentoCotizacion(this.veOBFactura);
    }

    private void cambiaEstadoCotizacionEliminaFactura()
    {
      if (!this.hayCotizacion)
        return;
      Cotizacion cotizacion = new Cotizacion();
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
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
        int num = (int) MessageBox.Show("Debe Ingresar Un Folio a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            this.idGuia = venta.IdFactura;
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
            TextBox textBox1 = this.txtDiasPlazo;
            int num1 = venta.DiasPlazo;
            string str1 = num1.ToString();
            textBox1.Text = str1;
            this.txtSubTotal.Text = venta.SubTotal.ToString("N0");
            this.txtTotalDescuento.Text = venta.Descuento.ToString("N0");
            this.txtPorcDescuentoTotal.Text = venta.PorcentajeDescuento.ToString("N0");
            TextBox textBox2 = this.txtTotalDescuento;
            Decimal num2 = venta.Descuento;
            string str2 = num2.ToString("N0");
            textBox2.Text = str2;
            TextBox textBox3 = this.txtNeto;
            num2 = venta.Neto;
            string str3 = num2.ToString("N0");
            textBox3.Text = str3;
            TextBox textBox4 = this.txtIva;
            num2 = venta.Iva;
            string str4 = num2.ToString("N0");
            textBox4.Text = str4;
            TextBox textBox5 = this.txtPorIva;
            num2 = venta.PorcentajeIva;
            string str5 = num2.ToString("N0");
            textBox5.Text = str5;
            TextBox textBox6 = this.txtTotalGeneral;
            num2 = venta.Total;
            string str6 = num2.ToString("N0");
            textBox6.Text = str6;
            TextBox textBox7 = this.txtTotalImp1;
            num2 = venta.Impuesto1;
            string str7;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto1;
              str7 = num2.ToString("N0");
            }
            else
              str7 = "";
            textBox7.Text = str7;
            TextBox textBox8 = this.txtTotalImp2;
            num2 = venta.Impuesto2;
            string str8;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto2;
              str8 = num2.ToString("N0");
            }
            else
              str8 = "";
            textBox8.Text = str8;
            TextBox textBox9 = this.txtTotalImp3;
            num2 = venta.Impuesto3;
            string str9;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto3;
              str9 = num2.ToString("N0");
            }
            else
              str9 = "";
            textBox9.Text = str9;
            TextBox textBox10 = this.txtTotalImp4;
            num2 = venta.Impuesto4;
            string str10;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto4;
              str10 = num2.ToString("N0");
            }
            else
              str10 = "";
            textBox10.Text = str10;
            TextBox textBox11 = this.txtTotalImp5;
            num2 = venta.Impuesto5;
            string str11;
            if (!num2.ToString("N0").Equals("0"))
            {
              num2 = venta.Impuesto5;
              str11 = num2.ToString("N0");
            }
            else
              str11 = "";
            textBox11.Text = str11;
            TextBox textBox12 = this.txtObservaciones;
            string str12 = "Orden de Trabajo N°: ";
            num1 = venta.Folio;
            string str13 = num1.ToString();
            string str14 = str12 + str13;
            textBox12.Text = str14;
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
            int num3 = (int) MessageBox.Show(string.Concat(new object[4]
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
          int num1 = (int) MessageBox.Show("No Existe la OT Consultada!!");
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
            this.idGuia = venta.IdFactura;
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
            this.txtObservaciones.Text = "Nota de Venta N°: " + venta.Folio.ToString();
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
            }), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("No Existe la Nota de Venta Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al llamar Nota de Venta " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
      this.panelNotaVenta.Visible = true;
      this.txtFolioNotaVenta.Focus();
    }

    private void cambiaEstadoNotaVenta()
    {
      if (!this.hayNotaVenta)
        return;
      NotaVenta notaVenta = new NotaVenta();
      string str = "GUIA ELECTRONICA";
      this.veOBFactura.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBFactura.IDDocumentoVenta = new EGuia().retornaIdGuia(this.veOBFactura.FolioDocumentoVenta);
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

    private void cargaTiposDeTraslado()
    {
      this.cmbTipoTraslado.DataSource = (object) null;
      this.cmbTipoTraslado.DataSource = (object) new TipoDocumentoVO().tiposDeTrasladoGuia();
      this.cmbTipoTraslado.ValueMember = "CodigoAccion";
      this.cmbTipoTraslado.DisplayMember = "NombreAccion";
      this.cmbTipoTraslado.SelectedValue = (object) 1;
    }

    private void cargaTrasladadoPor()
    {
      this.cmbTrasladadoPor.DataSource = (object) null;
      this.cmbTrasladadoPor.DataSource = (object) new TipoDocumentoVO().guiaTrasladadoPor();
      this.cmbTrasladadoPor.ValueMember = "CodigoAccion";
      this.cmbTrasladadoPor.DisplayMember = "NombreAccion";
      this.cmbTrasladadoPor.SelectedValue = (object) 1;
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
        catch (Exception ex) { }
    }

    private void txtFolioDocumentoReferencia_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioDocumentoReferencia);
    }

    private void button1_Click_2(object sender, EventArgs e)
    {
    }

    private void button1_Click_3(object sender, EventArgs e)
    {
      for (int fol = 91; fol < 101; ++fol)
      {
        if (this.reUsarGuiaFolio(fol))
        {
          this.guardaGuia();
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe Factura Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }

    private bool reUsarGuiaFolio(int fol)
    {
      this.panelFolio.Visible = false;
      EGuia eguia = new EGuia();
      Venta venta = eguia.buscaGuiaFolio(fol);
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
      this.txtObservaciones.Text = venta.Observaciones;
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
      this.lista = eguia.buscaDetalleGuiaIDGuia(venta.IdFactura);
      this.listaReferencias = eguia.buscaReferenciaIDGuia(venta.IdFactura);
      this.cmbBodega.SelectedValue = (object) this.lista[0].Bodega;
      for (int index = 0; index < this.lista.Count; ++index)
        this.lista[index].Linea = index + 1;
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
      this.dgvReferencias.DataSource = (object) null;
      this.dgvReferencias.DataSource = (object) this.listaReferencias;
      return true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.armaCodigoPDF417("EGuia_" + this.txtNumeroDocumento.Text);
    }

    private void armaCodigoPDF417Respaldo(string documento)
    {
      try
      {
        XDocument xdocument = XDocument.Load(this._rutaElectronica + "DTE\\E-Guia\\" + documento + ".XML", LoadOptions.PreserveWhitespace);
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
            TipoDte = 52
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
        XDocument xdocument = XDocument.Load(this._rutaElectronica + "DTE\\E-Guia\\EGuiaXML\\" + documento + ".XML", LoadOptions.PreserveWhitespace);
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
            TipoDte = 52
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
      string str = new Caf().archivoCaf(52, Convert.ToInt32(this.txtNumeroDocumento.Text));
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

    private void cmbTipoTraslado_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (this.cmbTipoTraslado.SelectedValue.ToString() == "5")
        this.cmbBodegaDestino.Enabled = true;
      else
        this.cmbBodegaDestino.Enabled = false;
    }

    private void txtTicket_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
    {
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

    private void btnAnular_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Anular esta Guia. Los productos seran retornados a Bodega", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        EGuia eguia = new EGuia();
        try
        {
          eguia.anulaGuia(this.idGuia, this.lista, this._listaLoteAntigua);
          if (this.hayTicket)
            this.cambiaEstadoTicketEliminaFactura();
          if (this.hayCotizacion)
            this.cambiaEstadoCotizacionEliminaFactura();
          if (this.hayNotaVenta)
            this.cambiaEstadoNotaVentaEliminaFactura();
          int num = (int) MessageBox.Show("Guia Anulada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Anular Documento " + ex.Message);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Guia NO fue Anulada..", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
      }
    }
  }
}
