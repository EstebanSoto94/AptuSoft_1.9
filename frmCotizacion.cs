
// Type: Aptusoft.frmCotizacion




using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft
{
    public class frmCotizacion : Form
    {
        private bool limpiar = true;
        private IContainer components = (IContainer)null;
        private List<DatosVentaVO> lista = new List<DatosVentaVO>();
        private List<ProductoAuxiliar> listaAuxiliar = new List<ProductoAuxiliar>();
        private int noVender = 0;
        private Decimal stock = new Decimal(0);
        private bool _modBodega = false;
        private int idImpuesto = 0;
        private Decimal netoLinea = new Decimal(0);
        private Decimal valorCompra = new Decimal(0);
        private List<VendedorVO> listaVendedores = new List<VendedorVO>();
        private List<MedioPagoVO> listaMediosPago = new List<MedioPagoVO>();
        private List<ImpuestoVO> listaImpuestos = new List<ImpuestoVO>();
        private List<CentroCostoVO> listaCentroCosto = new List<CentroCostoVO>();
        private OpcionesDocumentosVO odVO = new OpcionesDocumentosVO();
        private Decimal ivaInicio = new Decimal(0);
        private bool _guarda = false;
        private bool _modifica = false;
        private bool _elimina = false;
        private bool _anula = false;
        private bool _descuento = false;
        private bool _cambioPrecio = false;
        private bool _cambioFecha = false;
        private int _caja = 0;
        private int _bodega = 0;
        private int _listaPrecio = 0;
        private Venta veOBCotizacion = new Venta();
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
        private GroupBox gbZonaCliente;
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
        private GroupBox gbZonaFechas;
        private Label label16;
        private TextBox txtOrdenCompra;
        private Label lblFolio;
        private TextBox txtNumeroDocumento;
        private Label label2;
        private DateTimePicker dtpVencimiento;
        private Label label1;
        private DateTimePicker dtpEmision;
        private GroupBox gbZonaBotones;
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
        private Label label28;
        private ComboBox cmbBodega;
        private Label label29;
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
        private Panel panel4;
        private Panel panel3;
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
        private CheckBox chkMedioPagoFijo;
        private CheckBox chkVendedorFijo;
        private Label lblTipoDoc;
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
        private Button btnCerrarBuscaCliente;
        private Panel pnlUsaCotizacion;
        private Button btnCerrarBuscaCotizacionUsar;
        private Button btnBuscaCotizacionUsar;
        private TextBox txtBuscaCotizacionUsar;
        private Label label33;
        private ToolStripMenuItem usarCotizaciónTeclaF7ToolStripMenuItem;
        private CheckBox chkExento;
        private Button btnBuscaPreCliente;
        private TextBox txtEmail;
        private Label label34;
        private Button btnEnviarCorreo;
        private frmCotizacion intance;
        private int codigoCliente;
        private int idCotizacion;
        private string alertaStock;
        private string numeroLineas;
        private string impideVentasSinStock;
        private string decimalesValoresVenta;

        


        public frmCotizacion()
        {
            this.intance = this;
            this.InitializeComponent();
            this.cargaPermisos();
            this.iniciaFormulario();
            this.iniciaVenta();
            if (frmMenuPrincipal._Aptusoft)
                this.btnBuscaPreCliente.Visible = true;
            else
                this.btnBuscaPreCliente.Visible = false;
        }

        public frmCotizacion(string folio)
        {
            this.intance = this;
            this.InitializeComponent();
            this.cargaPermisos();
            this.iniciaFormulario();
            this.iniciaVenta();
            if (frmMenuPrincipal._Aptusoft)
                this.btnBuscaPreCliente.Visible = true;
            else
                this.btnBuscaPreCliente.Visible = false;
            this.txtFolioBuscar.Text = folio;
            this.buscaCotizacionFolio();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosTeclaF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaTeclaF6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarFacturaTeclaF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNumeroDeFolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usarCotizaciónTeclaF7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gbZonaCliente = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnBuscaPreCliente = new System.Windows.Forms.Button();
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiaDetalle = new System.Windows.Forms.Button();
            this.gbZonaFechas = new System.Windows.Forms.GroupBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gbZonaBotones = new System.Windows.Forms.GroupBox();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.chkExento = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprime = new System.Windows.Forms.Button();
            this.lblEstadoDocumento = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPorIva = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
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
            this.chkVendedorFijo = new System.Windows.Forms.CheckBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.chkMedioPagoFijo = new System.Windows.Forms.CheckBox();
            this.cmbCentroCosto = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.panelZonaDetalle = new System.Windows.Forms.Panel();
            this.txtTipoDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotalLinea = new System.Windows.Forms.TextBox();
            this.btnLimpiaLineaDetalle = new System.Windows.Forms.Button();
            this.btnModificaLinea = new System.Windows.Forms.Button();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPorcDescuentoLinea = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvBuscaCliente = new System.Windows.Forms.DataGridView();
            this.pnlBuscaClienteDes = new System.Windows.Forms.Panel();
            this.btnCerrarBuscaCliente = new System.Windows.Forms.Button();
            this.panelFolio = new System.Windows.Forms.Panel();
            this.btnCerrarPanelFolio = new System.Windows.Forms.Button();
            this.btnBuscaFolio = new System.Windows.Forms.Button();
            this.txtFolioBuscar = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.pnlUsaCotizacion = new System.Windows.Forms.Panel();
            this.btnCerrarBuscaCotizacionUsar = new System.Windows.Forms.Button();
            this.btnBuscaCotizacionUsar = new System.Windows.Forms.Button();
            this.txtBuscaCotizacionUsar = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbZonaCliente.SuspendLayout();
            this.gbZonaFechas.SuspendLayout();
            this.gbZonaBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            this.gbZonaOtros.SuspendLayout();
            this.panelZonaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).BeginInit();
            this.pnlBuscaClienteDes.SuspendLayout();
            this.panelFolio.SuspendLayout();
            this.pnlUsaCotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
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
            this.usarCotizaciónTeclaF7ToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarProductosTeclaF4ToolStripMenuItem
            // 
            this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
            this.buscarProductosTeclaF4ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
            this.buscarProductosTeclaF4ToolStripMenuItem.Click += new System.EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
            // 
            // buscarFacturaTeclaF6ToolStripMenuItem
            // 
            this.buscarFacturaTeclaF6ToolStripMenuItem.Name = "buscarFacturaTeclaF6ToolStripMenuItem";
            this.buscarFacturaTeclaF6ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.buscarFacturaTeclaF6ToolStripMenuItem.Text = "Buscar Cotización - tecla [F6]";
            this.buscarFacturaTeclaF6ToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturaTeclaF6ToolStripMenuItem_Click);
            // 
            // guardarFacturaTeclaF2ToolStripMenuItem
            // 
            this.guardarFacturaTeclaF2ToolStripMenuItem.Name = "guardarFacturaTeclaF2ToolStripMenuItem";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.guardarFacturaTeclaF2ToolStripMenuItem.Text = "Guardar Cotización - tecla[F2]";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Click += new System.EventHandler(this.guardarFacturaTeclaF2ToolStripMenuItem_Click);
            // 
            // cambiarNumeroDeFolioToolStripMenuItem
            // 
            this.cambiarNumeroDeFolioToolStripMenuItem.Name = "cambiarNumeroDeFolioToolStripMenuItem";
            this.cambiarNumeroDeFolioToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cambiarNumeroDeFolioToolStripMenuItem.Text = "Cambiar Numero de Folio";
            this.cambiarNumeroDeFolioToolStripMenuItem.Click += new System.EventHandler(this.cambiarNumeroDeFolioToolStripMenuItem_Click);
            // 
            // usarCotizaciónTeclaF7ToolStripMenuItem
            // 
            this.usarCotizaciónTeclaF7ToolStripMenuItem.Name = "usarCotizaciónTeclaF7ToolStripMenuItem";
            this.usarCotizaciónTeclaF7ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.usarCotizaciónTeclaF7ToolStripMenuItem.Text = "Usar Cotización - tecla[F7]";
            this.usarCotizaciónTeclaF7ToolStripMenuItem.Click += new System.EventHandler(this.usarCotizaciónTeclaF7ToolStripMenuItem_Click);
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
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(559, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Cantidad";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(675, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 23);
            this.label19.TabIndex = 6;
            this.label19.Text = "$ Descuento";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(481, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Precio";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(109, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(368, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Descripcion";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(559, 18);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(2, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Codigo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(2, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(762, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 23);
            this.label20.TabIndex = 7;
            this.label20.Text = "Total";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(109, 18);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(368, 20);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // txtTotalLinea
            // 
            this.txtTotalLinea.BackColor = System.Drawing.Color.White;
            this.txtTotalLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalLinea.Enabled = false;
            this.txtTotalLinea.Location = new System.Drawing.Point(762, 18);
            this.txtTotalLinea.Name = "txtTotalLinea";
            this.txtTotalLinea.Size = new System.Drawing.Size(92, 20);
            this.txtTotalLinea.TabIndex = 15;
            this.txtTotalLinea.TabStop = false;
            this.txtTotalLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbZonaCliente
            // 
            this.gbZonaCliente.Controls.Add(this.txtEmail);
            this.gbZonaCliente.Controls.Add(this.label34);
            this.gbZonaCliente.Controls.Add(this.btnBuscaPreCliente);
            this.gbZonaCliente.Controls.Add(this.btnBuscaCliente);
            this.gbZonaCliente.Controls.Add(this.label21);
            this.gbZonaCliente.Controls.Add(this.txtDiasPlazo);
            this.gbZonaCliente.Controls.Add(this.txtContacto);
            this.gbZonaCliente.Controls.Add(this.label12);
            this.gbZonaCliente.Controls.Add(this.label11);
            this.gbZonaCliente.Controls.Add(this.label10);
            this.gbZonaCliente.Controls.Add(this.label9);
            this.gbZonaCliente.Controls.Add(this.label8);
            this.gbZonaCliente.Controls.Add(this.label7);
            this.gbZonaCliente.Controls.Add(this.label6);
            this.gbZonaCliente.Controls.Add(this.txtFax);
            this.gbZonaCliente.Controls.Add(this.txtFono);
            this.gbZonaCliente.Controls.Add(this.txtGiro);
            this.gbZonaCliente.Controls.Add(this.txtCiudad);
            this.gbZonaCliente.Controls.Add(this.txtComuna);
            this.gbZonaCliente.Controls.Add(this.txtDireccion);
            this.gbZonaCliente.Controls.Add(this.label5);
            this.gbZonaCliente.Controls.Add(this.label4);
            this.gbZonaCliente.Controls.Add(this.txtRazonSocial);
            this.gbZonaCliente.Controls.Add(this.txtDigito);
            this.gbZonaCliente.Controls.Add(this.txtRut);
            this.gbZonaCliente.Location = new System.Drawing.Point(12, 71);
            this.gbZonaCliente.Name = "gbZonaCliente";
            this.gbZonaCliente.Size = new System.Drawing.Size(888, 102);
            this.gbZonaCliente.TabIndex = 26;
            this.gbZonaCliente.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(329, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 35;
            this.txtEmail.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(294, 81);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 13);
            this.label34.TabIndex = 34;
            this.label34.Text = "Email";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBuscaPreCliente
            // 
            this.btnBuscaPreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaPreCliente.Location = new System.Drawing.Point(705, 77);
            this.btnBuscaPreCliente.Name = "btnBuscaPreCliente";
            this.btnBuscaPreCliente.Size = new System.Drawing.Size(175, 23);
            this.btnBuscaPreCliente.TabIndex = 33;
            this.btnBuscaPreCliente.TabStop = false;
            this.btnBuscaPreCliente.Text = "Buscar PRE-CLIENTE";
            this.btnBuscaPreCliente.UseVisualStyleBackColor = true;
            this.btnBuscaPreCliente.Click += new System.EventHandler(this.btnBuscaPreCliente_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Location = new System.Drawing.Point(788, 9);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(93, 23);
            this.btnBuscaCliente.TabIndex = 32;
            this.btnBuscaCliente.TabStop = false;
            this.btnBuscaCliente.Text = "Buscar Cliente";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(535, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Dias de Plazo";
            // 
            // txtDiasPlazo
            // 
            this.txtDiasPlazo.BackColor = System.Drawing.Color.White;
            this.txtDiasPlazo.Location = new System.Drawing.Point(609, 77);
            this.txtDiasPlazo.Name = "txtDiasPlazo";
            this.txtDiasPlazo.Size = new System.Drawing.Size(52, 20);
            this.txtDiasPlazo.TabIndex = 19;
            this.txtDiasPlazo.TabStop = false;
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.White;
            this.txtContacto.Location = new System.Drawing.Point(74, 77);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(194, 20);
            this.txtContacto.TabIndex = 18;
            this.txtContacto.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Contacto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(674, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fax";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Giro";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ciudad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Comuna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dirección";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(705, 55);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(176, 20);
            this.txtFax.TabIndex = 10;
            this.txtFax.TabStop = false;
            // 
            // txtFono
            // 
            this.txtFono.BackColor = System.Drawing.Color.White;
            this.txtFono.Location = new System.Drawing.Point(485, 55);
            this.txtFono.Name = "txtFono";
            this.txtFono.Size = new System.Drawing.Size(176, 20);
            this.txtFono.TabIndex = 9;
            this.txtFono.TabStop = false;
            // 
            // txtGiro
            // 
            this.txtGiro.BackColor = System.Drawing.Color.White;
            this.txtGiro.Location = new System.Drawing.Point(74, 55);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(353, 20);
            this.txtGiro.TabIndex = 8;
            this.txtGiro.TabStop = false;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.Location = new System.Drawing.Point(705, 33);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(176, 20);
            this.txtCiudad.TabIndex = 7;
            this.txtCiudad.TabStop = false;
            // 
            // txtComuna
            // 
            this.txtComuna.BackColor = System.Drawing.Color.White;
            this.txtComuna.Location = new System.Drawing.Point(485, 33);
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(176, 20);
            this.txtComuna.TabIndex = 6;
            this.txtComuna.TabStop = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(74, 33);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(353, 20);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Razon Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RUT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(271, 11);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(500, 20);
            this.txtRazonSocial.TabIndex = 8;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            this.txtRazonSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazonSocial_KeyDown);
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(146, 11);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(29, 20);
            this.txtDigito.TabIndex = 7;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(74, 11);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(68, 20);
            this.txtRut.TabIndex = 6;
            this.txtRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRut_KeyDown);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(481, 18);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Location = new System.Drawing.Point(675, 18);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(77, 20);
            this.txtDescuento.TabIndex = 14;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // chkCantidadFija
            // 
            this.chkCantidadFija.AutoSize = true;
            this.chkCantidadFija.Location = new System.Drawing.Point(618, 25);
            this.chkCantidadFija.Name = "chkCantidadFija";
            this.chkCantidadFija.Size = new System.Drawing.Size(15, 14);
            this.chkCantidadFija.TabIndex = 16;
            this.chkCantidadFija.UseVisualStyleBackColor = true;
            this.chkCantidadFija.Click += new System.EventHandler(this.chkCantidadFija_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(768, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(55, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiaDetalle
            // 
            this.btnLimpiaDetalle.Location = new System.Drawing.Point(826, 40);
            this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
            this.btnLimpiaDetalle.Size = new System.Drawing.Size(55, 23);
            this.btnLimpiaDetalle.TabIndex = 16;
            this.btnLimpiaDetalle.Text = "Limpiar";
            this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaDetalle.Click += new System.EventHandler(this.btnLimpiaDetalle_Click);
            // 
            // gbZonaFechas
            // 
            this.gbZonaFechas.Controls.Add(this.dtpVencimiento);
            this.gbZonaFechas.Controls.Add(this.dtpEmision);
            this.gbZonaFechas.Controls.Add(this.label2);
            this.gbZonaFechas.Controls.Add(this.label1);
            this.gbZonaFechas.Location = new System.Drawing.Point(12, 18);
            this.gbZonaFechas.Name = "gbZonaFechas";
            this.gbZonaFechas.Size = new System.Drawing.Size(228, 58);
            this.gbZonaFechas.TabIndex = 24;
            this.gbZonaFechas.TabStop = false;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(118, 29);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(96, 20);
            this.dtpVencimiento.TabIndex = 1;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vencimiento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emision";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(787, 50);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroDocumento.TabIndex = 16;
            this.txtNumeroDocumento.TabStop = false;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.DoubleClick += new System.EventHandler(this.txtNumeroDocumento_DoubleClick);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(786, 31);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(100, 16);
            this.lblFolio.TabIndex = 17;
            this.lblFolio.Text = "Cotización N°";
            this.lblFolio.DoubleClick += new System.EventHandler(this.lblFolio_DoubleClick);
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(432, 29);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(91, 20);
            this.txtOrdenCompra.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(432, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 23);
            this.label16.TabIndex = 77;
            this.label16.Text = "Orden de Compra";
            // 
            // gbZonaBotones
            // 
            this.gbZonaBotones.Controls.Add(this.btnEnviarCorreo);
            this.gbZonaBotones.Controls.Add(this.chkExento);
            this.gbZonaBotones.Controls.Add(this.groupBox1);
            this.gbZonaBotones.Controls.Add(this.lblTipoDoc);
            this.gbZonaBotones.Controls.Add(this.label3);
            this.gbZonaBotones.Controls.Add(this.btnImprime);
            this.gbZonaBotones.Controls.Add(this.lblEstadoDocumento);
            this.gbZonaBotones.Controls.Add(this.btnAnular);
            this.gbZonaBotones.Controls.Add(this.btnSalir);
            this.gbZonaBotones.Controls.Add(this.txtPorIva);
            this.gbZonaBotones.Controls.Add(this.btnLimpiar);
            this.gbZonaBotones.Controls.Add(this.btnGuardar);
            this.gbZonaBotones.Controls.Add(this.btnEliminar);
            this.gbZonaBotones.Controls.Add(this.btnModificar);
            this.gbZonaBotones.Controls.Add(this.txtSubTotal);
            this.gbZonaBotones.Controls.Add(this.txtTotalGeneral);
            this.gbZonaBotones.Controls.Add(this.txtIva);
            this.gbZonaBotones.Controls.Add(this.txtNeto);
            this.gbZonaBotones.Controls.Add(this.txtTotalDescuento);
            this.gbZonaBotones.Controls.Add(this.txtPorcDescuentoTotal);
            this.gbZonaBotones.Controls.Add(this.label26);
            this.gbZonaBotones.Controls.Add(this.label25);
            this.gbZonaBotones.Controls.Add(this.label24);
            this.gbZonaBotones.Controls.Add(this.label23);
            this.gbZonaBotones.Controls.Add(this.label22);
            this.gbZonaBotones.Location = new System.Drawing.Point(12, 443);
            this.gbZonaBotones.Name = "gbZonaBotones";
            this.gbZonaBotones.Size = new System.Drawing.Size(888, 146);
            this.gbZonaBotones.TabIndex = 28;
            this.gbZonaBotones.TabStop = false;
            this.gbZonaBotones.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Location = new System.Drawing.Point(185, 110);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(88, 23);
            this.btnEnviarCorreo.TabIndex = 34;
            this.btnEnviarCorreo.Text = "Enviar Outlook";
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // chkExento
            // 
            this.chkExento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkExento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkExento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExento.ForeColor = System.Drawing.Color.White;
            this.chkExento.Location = new System.Drawing.Point(730, 11);
            this.chkExento.Name = "chkExento";
            this.chkExento.Size = new System.Drawing.Size(152, 20);
            this.chkExento.TabIndex = 33;
            this.chkExento.Text = "Cotizacion Exenta";
            this.chkExento.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkExento.UseVisualStyleBackColor = false;
            this.chkExento.CheckedChanged += new System.EventHandler(this.chkExento_CheckedChanged);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(454, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 133);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impuestos Especiales";
            // 
            // txtTotalImp5
            // 
            this.txtTotalImp5.BackColor = System.Drawing.Color.White;
            this.txtTotalImp5.Enabled = false;
            this.txtTotalImp5.Location = new System.Drawing.Point(141, 107);
            this.txtTotalImp5.Name = "txtTotalImp5";
            this.txtTotalImp5.Size = new System.Drawing.Size(83, 20);
            this.txtTotalImp5.TabIndex = 38;
            this.txtTotalImp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp3
            // 
            this.txtTotalImp3.BackColor = System.Drawing.Color.White;
            this.txtTotalImp3.Enabled = false;
            this.txtTotalImp3.Location = new System.Drawing.Point(141, 63);
            this.txtTotalImp3.Name = "txtTotalImp3";
            this.txtTotalImp3.Size = new System.Drawing.Size(83, 20);
            this.txtTotalImp3.TabIndex = 10;
            this.txtTotalImp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp4
            // 
            this.txtTotalImp4.BackColor = System.Drawing.Color.White;
            this.txtTotalImp4.Enabled = false;
            this.txtTotalImp4.Location = new System.Drawing.Point(141, 85);
            this.txtTotalImp4.Name = "txtTotalImp4";
            this.txtTotalImp4.Size = new System.Drawing.Size(83, 20);
            this.txtTotalImp4.TabIndex = 36;
            this.txtTotalImp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp5
            // 
            this.txtPorImp5.BackColor = System.Drawing.Color.White;
            this.txtPorImp5.Enabled = false;
            this.txtPorImp5.Location = new System.Drawing.Point(90, 107);
            this.txtPorImp5.Name = "txtPorImp5";
            this.txtPorImp5.Size = new System.Drawing.Size(47, 20);
            this.txtPorImp5.TabIndex = 37;
            this.txtPorImp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp3
            // 
            this.txtPorImp3.BackColor = System.Drawing.Color.White;
            this.txtPorImp3.Enabled = false;
            this.txtPorImp3.Location = new System.Drawing.Point(90, 63);
            this.txtPorImp3.Name = "txtPorImp3";
            this.txtPorImp3.Size = new System.Drawing.Size(47, 20);
            this.txtPorImp3.TabIndex = 9;
            this.txtPorImp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp2
            // 
            this.txtTotalImp2.BackColor = System.Drawing.Color.White;
            this.txtTotalImp2.Enabled = false;
            this.txtTotalImp2.Location = new System.Drawing.Point(141, 41);
            this.txtTotalImp2.Name = "txtTotalImp2";
            this.txtTotalImp2.Size = new System.Drawing.Size(83, 20);
            this.txtTotalImp2.TabIndex = 8;
            this.txtTotalImp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp4
            // 
            this.txtPorImp4.BackColor = System.Drawing.Color.White;
            this.txtPorImp4.Enabled = false;
            this.txtPorImp4.Location = new System.Drawing.Point(90, 85);
            this.txtPorImp4.Name = "txtPorImp4";
            this.txtPorImp4.Size = new System.Drawing.Size(47, 20);
            this.txtPorImp4.TabIndex = 35;
            this.txtPorImp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp2
            // 
            this.txtPorImp2.BackColor = System.Drawing.Color.White;
            this.txtPorImp2.Enabled = false;
            this.txtPorImp2.Location = new System.Drawing.Point(90, 41);
            this.txtPorImp2.Name = "txtPorImp2";
            this.txtPorImp2.Size = new System.Drawing.Size(47, 20);
            this.txtPorImp2.TabIndex = 7;
            this.txtPorImp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp1
            // 
            this.txtTotalImp1.BackColor = System.Drawing.Color.White;
            this.txtTotalImp1.Enabled = false;
            this.txtTotalImp1.Location = new System.Drawing.Point(141, 19);
            this.txtTotalImp1.Name = "txtTotalImp1";
            this.txtTotalImp1.Size = new System.Drawing.Size(83, 20);
            this.txtTotalImp1.TabIndex = 6;
            this.txtTotalImp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp1
            // 
            this.txtPorImp1.BackColor = System.Drawing.Color.White;
            this.txtPorImp1.Enabled = false;
            this.txtPorImp1.ForeColor = System.Drawing.Color.Black;
            this.txtPorImp1.Location = new System.Drawing.Point(90, 19);
            this.txtPorImp1.Name = "txtPorImp1";
            this.txtPorImp1.Size = new System.Drawing.Size(47, 20);
            this.txtPorImp1.TabIndex = 5;
            this.txtPorImp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImp5
            // 
            this.lblImp5.AutoSize = true;
            this.lblImp5.Location = new System.Drawing.Point(10, 111);
            this.lblImp5.Name = "lblImp5";
            this.lblImp5.Size = new System.Drawing.Size(59, 13);
            this.lblImp5.TabIndex = 4;
            this.lblImp5.Text = "Impuesto 5";
            // 
            // lblImp4
            // 
            this.lblImp4.AutoSize = true;
            this.lblImp4.Location = new System.Drawing.Point(10, 89);
            this.lblImp4.Name = "lblImp4";
            this.lblImp4.Size = new System.Drawing.Size(59, 13);
            this.lblImp4.TabIndex = 3;
            this.lblImp4.Text = "Impuesto 4";
            // 
            // lblImp3
            // 
            this.lblImp3.AutoSize = true;
            this.lblImp3.Location = new System.Drawing.Point(10, 67);
            this.lblImp3.Name = "lblImp3";
            this.lblImp3.Size = new System.Drawing.Size(59, 13);
            this.lblImp3.TabIndex = 2;
            this.lblImp3.Text = "Impuesto 3";
            // 
            // lblImp2
            // 
            this.lblImp2.AutoSize = true;
            this.lblImp2.Location = new System.Drawing.Point(10, 45);
            this.lblImp2.Name = "lblImp2";
            this.lblImp2.Size = new System.Drawing.Size(59, 13);
            this.lblImp2.TabIndex = 1;
            this.lblImp2.Text = "Impuesto 2";
            // 
            // lblImp1
            // 
            this.lblImp1.AutoSize = true;
            this.lblImp1.Location = new System.Drawing.Point(10, 23);
            this.lblImp1.Name = "lblImp1";
            this.lblImp1.Size = new System.Drawing.Size(59, 13);
            this.lblImp1.TabIndex = 0;
            this.lblImp1.Text = "Impuesto 1";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ForeColor = System.Drawing.Color.Red;
            this.lblTipoDoc.Location = new System.Drawing.Point(9, 46);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(20, 29);
            this.lblTipoDoc.TabIndex = 29;
            this.lblTipoDoc.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "COTIZACIÓN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(7, 110);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(88, 23);
            this.btnImprime.TabIndex = 26;
            this.btnImprime.Text = "RE-IMPRIME";
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // lblEstadoDocumento
            // 
            this.lblEstadoDocumento.AutoSize = true;
            this.lblEstadoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDocumento.ForeColor = System.Drawing.Color.Red;
            this.lblEstadoDocumento.Location = new System.Drawing.Point(177, 17);
            this.lblEstadoDocumento.Name = "lblEstadoDocumento";
            this.lblEstadoDocumento.Size = new System.Drawing.Size(118, 29);
            this.lblEstadoDocumento.TabIndex = 25;
            this.lblEstadoDocumento.Text = "ESTADO";
            this.lblEstadoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(185, 86);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(88, 23);
            this.btnAnular.TabIndex = 24;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(274, 110);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtPorIva
            // 
            this.txtPorIva.BackColor = System.Drawing.Color.White;
            this.txtPorIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorIva.Enabled = false;
            this.txtPorIva.Location = new System.Drawing.Point(778, 100);
            this.txtPorIva.Name = "txtPorIva";
            this.txtPorIva.Size = new System.Drawing.Size(24, 20);
            this.txtPorIva.TabIndex = 11;
            this.txtPorIva.TabStop = false;
            this.txtPorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(96, 110);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 86);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "GUARDA [F2]";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(274, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(96, 86);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(778, 34);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(103, 20);
            this.txtSubTotal.TabIndex = 10;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.BackColor = System.Drawing.Color.White;
            this.txtTotalGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGeneral.Enabled = false;
            this.txtTotalGeneral.Location = new System.Drawing.Point(778, 122);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.Size = new System.Drawing.Size(103, 20);
            this.txtTotalGeneral.TabIndex = 9;
            this.txtTotalGeneral.TabStop = false;
            this.txtTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.Color.White;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(804, 100);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(77, 20);
            this.txtIva.TabIndex = 8;
            this.txtIva.TabStop = false;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNeto
            // 
            this.txtNeto.BackColor = System.Drawing.Color.White;
            this.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto.Enabled = false;
            this.txtNeto.Location = new System.Drawing.Point(778, 78);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(103, 20);
            this.txtNeto.TabIndex = 7;
            this.txtNeto.TabStop = false;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalDescuento
            // 
            this.txtTotalDescuento.BackColor = System.Drawing.Color.White;
            this.txtTotalDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDescuento.Location = new System.Drawing.Point(804, 56);
            this.txtTotalDescuento.Name = "txtTotalDescuento";
            this.txtTotalDescuento.ReadOnly = true;
            this.txtTotalDescuento.Size = new System.Drawing.Size(77, 20);
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
            this.txtPorcDescuentoTotal.Location = new System.Drawing.Point(778, 56);
            this.txtPorcDescuentoTotal.Name = "txtPorcDescuentoTotal";
            this.txtPorcDescuentoTotal.ReadOnly = true;
            this.txtPorcDescuentoTotal.Size = new System.Drawing.Size(24, 20);
            this.txtPorcDescuentoTotal.TabIndex = 5;
            this.txtPorcDescuentoTotal.TabStop = false;
            this.txtPorcDescuentoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoTotal.TextChanged += new System.EventHandler(this.txtPorcDescuentoTotal_TextChanged);
            this.txtPorcDescuentoTotal.DoubleClick += new System.EventHandler(this.txtPorcDescuentoTotal_DoubleClick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(727, 126);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "TOTAL";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(739, 104);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "I.V.A";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(733, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "NETO";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(691, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "DESCUENTO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(702, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "SUBTOTAL";
            // 
            // dgvDatosVenta
            // 
            this.dgvDatosVenta.AllowUserToAddRows = false;
            this.dgvDatosVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDatosVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosVenta.Location = new System.Drawing.Point(3, 69);
            this.dgvDatosVenta.MultiSelect = false;
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.ReadOnly = true;
            this.dgvDatosVenta.RowHeadersVisible = false;
            this.dgvDatosVenta.RowHeadersWidth = 50;
            this.dgvDatosVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosVenta.Size = new System.Drawing.Size(877, 196);
            this.dgvDatosVenta.TabIndex = 3;
            this.dgvDatosVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
            this.dgvDatosVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(152, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 23);
            this.label27.TabIndex = 21;
            this.label27.Text = "Vendedor";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(152, 29);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(131, 21);
            this.cmbVendedor.TabIndex = 3;
            this.cmbVendedor.Enter += new System.EventHandler(this.cmbVendedor_Enter);
            // 
            // gbZonaOtros
            // 
            this.gbZonaOtros.Controls.Add(this.cmbVendedor);
            this.gbZonaOtros.Controls.Add(this.chkVendedorFijo);
            this.gbZonaOtros.Controls.Add(this.cmbMedioPago);
            this.gbZonaOtros.Controls.Add(this.chkMedioPagoFijo);
            this.gbZonaOtros.Controls.Add(this.txtOrdenCompra);
            this.gbZonaOtros.Controls.Add(this.cmbCentroCosto);
            this.gbZonaOtros.Controls.Add(this.label30);
            this.gbZonaOtros.Controls.Add(this.label18);
            this.gbZonaOtros.Controls.Add(this.label16);
            this.gbZonaOtros.Controls.Add(this.label27);
            this.gbZonaOtros.Location = new System.Drawing.Point(243, 18);
            this.gbZonaOtros.Name = "gbZonaOtros";
            this.gbZonaOtros.Size = new System.Drawing.Size(533, 58);
            this.gbZonaOtros.TabIndex = 25;
            this.gbZonaOtros.TabStop = false;
            // 
            // chkVendedorFijo
            // 
            this.chkVendedorFijo.AutoSize = true;
            this.chkVendedorFijo.Location = new System.Drawing.Point(270, 16);
            this.chkVendedorFijo.Name = "chkVendedorFijo";
            this.chkVendedorFijo.Size = new System.Drawing.Size(15, 14);
            this.chkVendedorFijo.TabIndex = 36;
            this.chkVendedorFijo.TabStop = false;
            this.chkVendedorFijo.UseVisualStyleBackColor = true;
            this.chkVendedorFijo.CheckedChanged += new System.EventHandler(this.chkVendedorFijo_CheckedChanged);
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedioPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(6, 29);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(140, 21);
            this.cmbMedioPago.TabIndex = 2;
            this.cmbMedioPago.SelectedValueChanged += new System.EventHandler(this.cmbMedioPago_SelectedValueChanged);
            this.cmbMedioPago.Enter += new System.EventHandler(this.cmbMedioPago_Enter);
            // 
            // chkMedioPagoFijo
            // 
            this.chkMedioPagoFijo.AutoSize = true;
            this.chkMedioPagoFijo.Location = new System.Drawing.Point(132, 16);
            this.chkMedioPagoFijo.Name = "chkMedioPagoFijo";
            this.chkMedioPagoFijo.Size = new System.Drawing.Size(15, 14);
            this.chkMedioPagoFijo.TabIndex = 35;
            this.chkMedioPagoFijo.TabStop = false;
            this.chkMedioPagoFijo.UseVisualStyleBackColor = true;
            this.chkMedioPagoFijo.CheckedChanged += new System.EventHandler(this.chkMedioPagoFijo_CheckedChanged);
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCosto.FormattingEnabled = true;
            this.cmbCentroCosto.Location = new System.Drawing.Point(289, 29);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Size = new System.Drawing.Size(137, 21);
            this.cmbCentroCosto.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(289, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 23);
            this.label30.TabIndex = 34;
            this.label30.Text = "Centro de Costo";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(6, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Medio de Pago";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 46);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Bodega";
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(55, 42);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(126, 21);
            this.cmbBodega.TabIndex = 17;
            this.cmbBodega.Enter += new System.EventHandler(this.cmbBodega_Enter);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(194, 46);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Lista de Precio";
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(274, 42);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(126, 21);
            this.cmbListaPrecio.TabIndex = 18;
            this.cmbListaPrecio.SelectedValueChanged += new System.EventHandler(this.cmbListaPrecio_SelectedValueChanged);
            // 
            // panelZonaDetalle
            // 
            this.panelZonaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelZonaDetalle.Controls.Add(this.txtTipoDescuento);
            this.panelZonaDetalle.Controls.Add(this.txtSubTotalLinea);
            this.panelZonaDetalle.Controls.Add(this.btnLimpiaLineaDetalle);
            this.panelZonaDetalle.Controls.Add(this.btnModificaLinea);
            this.panelZonaDetalle.Controls.Add(this.txtLinea);
            this.panelZonaDetalle.Controls.Add(this.panel4);
            this.panelZonaDetalle.Controls.Add(this.panel3);
            this.panelZonaDetalle.Controls.Add(this.txtPorcDescuentoLinea);
            this.panelZonaDetalle.Controls.Add(this.label31);
            this.panelZonaDetalle.Controls.Add(this.txtCodigo);
            this.panelZonaDetalle.Controls.Add(this.txtCantidad);
            this.panelZonaDetalle.Controls.Add(this.dgvDatosVenta);
            this.panelZonaDetalle.Controls.Add(this.chkCantidadFija);
            this.panelZonaDetalle.Controls.Add(this.btnAgregar);
            this.panelZonaDetalle.Controls.Add(this.txtDescripcion);
            this.panelZonaDetalle.Controls.Add(this.btnLimpiaDetalle);
            this.panelZonaDetalle.Controls.Add(this.txtTotalLinea);
            this.panelZonaDetalle.Controls.Add(this.label20);
            this.panelZonaDetalle.Controls.Add(this.txtPrecio);
            this.panelZonaDetalle.Controls.Add(this.label14);
            this.panelZonaDetalle.Controls.Add(this.txtDescuento);
            this.panelZonaDetalle.Controls.Add(this.label28);
            this.panelZonaDetalle.Controls.Add(this.label13);
            this.panelZonaDetalle.Controls.Add(this.label15);
            this.panelZonaDetalle.Controls.Add(this.cmbListaPrecio);
            this.panelZonaDetalle.Controls.Add(this.cmbBodega);
            this.panelZonaDetalle.Controls.Add(this.label17);
            this.panelZonaDetalle.Controls.Add(this.label19);
            this.panelZonaDetalle.Controls.Add(this.label29);
            this.panelZonaDetalle.Location = new System.Drawing.Point(12, 176);
            this.panelZonaDetalle.Name = "panelZonaDetalle";
            this.panelZonaDetalle.Size = new System.Drawing.Size(888, 273);
            this.panelZonaDetalle.TabIndex = 27;
            // 
            // txtTipoDescuento
            // 
            this.txtTipoDescuento.Location = new System.Drawing.Point(579, 42);
            this.txtTipoDescuento.Name = "txtTipoDescuento";
            this.txtTipoDescuento.Size = new System.Drawing.Size(38, 20);
            this.txtTipoDescuento.TabIndex = 35;
            this.txtTipoDescuento.Text = "0";
            this.txtTipoDescuento.Visible = false;
            // 
            // txtSubTotalLinea
            // 
            this.txtSubTotalLinea.Location = new System.Drawing.Point(527, 42);
            this.txtSubTotalLinea.Name = "txtSubTotalLinea";
            this.txtSubTotalLinea.Size = new System.Drawing.Size(43, 20);
            this.txtSubTotalLinea.TabIndex = 34;
            this.txtSubTotalLinea.Visible = false;
            // 
            // btnLimpiaLineaDetalle
            // 
            this.btnLimpiaLineaDetalle.Location = new System.Drawing.Point(858, 3);
            this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
            this.btnLimpiaLineaDetalle.Size = new System.Drawing.Size(20, 34);
            this.btnLimpiaLineaDetalle.TabIndex = 33;
            this.btnLimpiaLineaDetalle.Text = "..";
            this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaLineaDetalle.Click += new System.EventHandler(this.btnLimpiaLineaDetalle_Click);
            // 
            // btnModificaLinea
            // 
            this.btnModificaLinea.Location = new System.Drawing.Point(688, 41);
            this.btnModificaLinea.Name = "btnModificaLinea";
            this.btnModificaLinea.Size = new System.Drawing.Size(75, 23);
            this.btnModificaLinea.TabIndex = 33;
            this.btnModificaLinea.Text = "Modificar";
            this.btnModificaLinea.UseVisualStyleBackColor = true;
            this.btnModificaLinea.Click += new System.EventHandler(this.btnModificaLinea_Click);
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(449, 42);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(71, 20);
            this.txtLinea.TabIndex = 32;
            this.txtLinea.Text = "NumeroLinea";
            this.txtLinea.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(755, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 36);
            this.panel4.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(635, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 36);
            this.panel3.TabIndex = 30;
            // 
            // txtPorcDescuentoLinea
            // 
            this.txtPorcDescuentoLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcDescuentoLinea.Location = new System.Drawing.Point(642, 18);
            this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
            this.txtPorcDescuentoLinea.Size = new System.Drawing.Size(31, 20);
            this.txtPorcDescuentoLinea.TabIndex = 13;
            this.txtPorcDescuentoLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoLinea.TextChanged += new System.EventHandler(this.porcentajeDescuento_TextChanged);
            this.txtPorcDescuentoLinea.Enter += new System.EventHandler(this.txtPorcDescuentoLinea_Enter);
            this.txtPorcDescuentoLinea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPorcDescuentoLinea_KeyDown);
            this.txtPorcDescuentoLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(642, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 23);
            this.label31.TabIndex = 29;
            this.label31.Text = "%";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvBuscaCliente
            // 
            this.dgvBuscaCliente.AllowUserToAddRows = false;
            this.dgvBuscaCliente.AllowUserToDeleteRows = false;
            this.dgvBuscaCliente.AllowUserToResizeColumns = false;
            this.dgvBuscaCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            this.dgvBuscaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBuscaCliente.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscaCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuscaCliente.Location = new System.Drawing.Point(31, 2);
            this.dgvBuscaCliente.Name = "dgvBuscaCliente";
            this.dgvBuscaCliente.ReadOnly = true;
            this.dgvBuscaCliente.RowHeadersVisible = false;
            this.dgvBuscaCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscaCliente.Size = new System.Drawing.Size(628, 211);
            this.dgvBuscaCliente.TabIndex = 0;
            this.dgvBuscaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscaCliente_CellDoubleClick);
            this.dgvBuscaCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBuscaCliente_KeyDown);
            // 
            // pnlBuscaClienteDes
            // 
            this.pnlBuscaClienteDes.Controls.Add(this.btnCerrarBuscaCliente);
            this.pnlBuscaClienteDes.Controls.Add(this.dgvBuscaCliente);
            this.pnlBuscaClienteDes.Location = new System.Drawing.Point(907, 103);
            this.pnlBuscaClienteDes.Name = "pnlBuscaClienteDes";
            this.pnlBuscaClienteDes.Size = new System.Drawing.Size(42, 218);
            this.pnlBuscaClienteDes.TabIndex = 32;
            // 
            // btnCerrarBuscaCliente
            // 
            this.btnCerrarBuscaCliente.Location = new System.Drawing.Point(4, 3);
            this.btnCerrarBuscaCliente.Name = "btnCerrarBuscaCliente";
            this.btnCerrarBuscaCliente.Size = new System.Drawing.Size(25, 23);
            this.btnCerrarBuscaCliente.TabIndex = 33;
            this.btnCerrarBuscaCliente.Text = "X";
            this.btnCerrarBuscaCliente.UseVisualStyleBackColor = true;
            this.btnCerrarBuscaCliente.Click += new System.EventHandler(this.btnCerrarBuscaCliente_Click);
            // 
            // panelFolio
            // 
            this.panelFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFolio.Controls.Add(this.btnCerrarPanelFolio);
            this.panelFolio.Controls.Add(this.btnBuscaFolio);
            this.panelFolio.Controls.Add(this.txtFolioBuscar);
            this.panelFolio.Controls.Add(this.label32);
            this.panelFolio.Location = new System.Drawing.Point(721, 71);
            this.panelFolio.Name = "panelFolio";
            this.panelFolio.Size = new System.Drawing.Size(232, 92);
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
            // pnlUsaCotizacion
            // 
            this.pnlUsaCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsaCotizacion.Controls.Add(this.btnCerrarBuscaCotizacionUsar);
            this.pnlUsaCotizacion.Controls.Add(this.btnBuscaCotizacionUsar);
            this.pnlUsaCotizacion.Controls.Add(this.txtBuscaCotizacionUsar);
            this.pnlUsaCotizacion.Controls.Add(this.label33);
            this.pnlUsaCotizacion.Location = new System.Drawing.Point(366, 182);
            this.pnlUsaCotizacion.Name = "pnlUsaCotizacion";
            this.pnlUsaCotizacion.Size = new System.Drawing.Size(232, 103);
            this.pnlUsaCotizacion.TabIndex = 25;
            // 
            // btnCerrarBuscaCotizacionUsar
            // 
            this.btnCerrarBuscaCotizacionUsar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarBuscaCotizacionUsar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBuscaCotizacionUsar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarBuscaCotizacionUsar.Location = new System.Drawing.Point(185, 1);
            this.btnCerrarBuscaCotizacionUsar.Name = "btnCerrarBuscaCotizacionUsar";
            this.btnCerrarBuscaCotizacionUsar.Size = new System.Drawing.Size(23, 24);
            this.btnCerrarBuscaCotizacionUsar.TabIndex = 24;
            this.btnCerrarBuscaCotizacionUsar.Text = "X";
            this.btnCerrarBuscaCotizacionUsar.UseVisualStyleBackColor = true;
            this.btnCerrarBuscaCotizacionUsar.Click += new System.EventHandler(this.btnCerrarBuscaCotizacionUsar_Click);
            // 
            // btnBuscaCotizacionUsar
            // 
            this.btnBuscaCotizacionUsar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCotizacionUsar.Location = new System.Drawing.Point(25, 59);
            this.btnBuscaCotizacionUsar.Name = "btnBuscaCotizacionUsar";
            this.btnBuscaCotizacionUsar.Size = new System.Drawing.Size(161, 25);
            this.btnBuscaCotizacionUsar.TabIndex = 2;
            this.btnBuscaCotizacionUsar.Text = "Buscar";
            this.btnBuscaCotizacionUsar.UseVisualStyleBackColor = true;
            this.btnBuscaCotizacionUsar.Click += new System.EventHandler(this.btnBuscaCotizacionUsar_Click);
            // 
            // txtBuscaCotizacionUsar
            // 
            this.txtBuscaCotizacionUsar.Location = new System.Drawing.Point(26, 33);
            this.txtBuscaCotizacionUsar.Name = "txtBuscaCotizacionUsar";
            this.txtBuscaCotizacionUsar.Size = new System.Drawing.Size(162, 20);
            this.txtBuscaCotizacionUsar.TabIndex = 1;
            this.txtBuscaCotizacionUsar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaCotizacionUsar_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(21, 8);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(164, 16);
            this.label33.TabIndex = 0;
            this.label33.Text = "Ingrese Folio a Buscar";
            // 
            // frmCotizacion
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1008, 742);
            this.Controls.Add(this.pnlUsaCotizacion);
            this.Controls.Add(this.panelFolio);
            this.Controls.Add(this.pnlBuscaClienteDes);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.panelZonaDetalle);
            this.Controls.Add(this.gbZonaOtros);
            this.Controls.Add(this.gbZonaFechas);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.gbZonaCliente);
            this.Controls.Add(this.gbZonaBotones);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cotización";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFactura_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFactura_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbZonaCliente.ResumeLayout(false);
            this.gbZonaCliente.PerformLayout();
            this.gbZonaFechas.ResumeLayout(false);
            this.gbZonaBotones.ResumeLayout(false);
            this.gbZonaBotones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            this.gbZonaOtros.ResumeLayout(false);
            this.gbZonaOtros.PerformLayout();
            this.panelZonaDetalle.ResumeLayout(false);
            this.panelZonaDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).EndInit();
            this.pnlBuscaClienteDes.ResumeLayout(false);
            this.panelFolio.ResumeLayout(false);
            this.panelFolio.PerformLayout();
            this.pnlUsaCotizacion.ResumeLayout(false);
            this.pnlUsaCotizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cargaPermisos()
        {
            foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
            {
                if (usuarioVo.Modulo.Equals("COTIZACION"))
                {
                    this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
                    this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
                    this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
                    this._anula = Convert.ToBoolean(usuarioVo.Anula);
                    this._descuento = Convert.ToBoolean(usuarioVo.Descuento);
                    this._cambioPrecio = Convert.ToBoolean(usuarioVo.CambioPrecio);
                    this._cambioFecha = Convert.ToBoolean(usuarioVo.CambioFecha);
                    this._caja = usuarioVo.IdCaja;
                    this._bodega = usuarioVo.IdBodega;
                    this._listaPrecio = usuarioVo.IdListaPrecio;
                }
            }
        }

        public void cargaOpcionesDocumentosInicio()
        {
            this.odVO = new OpcionesGenerales().rescataOpcionesDocumentosPorNombre("COTIZACION");
        }

        public void cargaOpcionesDocumentos()
        {
            this.alertaStock = this.odVO.AlertaStockInsuficiente;
            this.impideVentasSinStock = this.odVO.ImpideVentasSinStock;
            this.numeroLineas = this.odVO.CantidadLineasDocumento;
            this.decimalesValoresVenta = this.odVO.DecimalesValorVenta.ToString();
        }

        private void cargaVendedores()
        {
            this.cmbVendedor.DataSource = (object)this.listaVendedores;
            this.cmbVendedor.ValueMember = "idVendedor";
            this.cmbVendedor.DisplayMember = "nombre";
            this.cmbVendedor.SelectedValue = (object)0;
        }

        private void cargaVendedoresInicio()
        {
            this.listaVendedores = new Vendedor().listaVendedoresVenta();
        }

        private void cargaCentroCosto()
        {
            this.cmbCentroCosto.DataSource = (object)this.listaCentroCosto;
            this.cmbCentroCosto.ValueMember = "idCentroCosto";
            this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
            this.cmbCentroCosto.SelectedValue = (object)0;
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
            this.cmbMedioPago.DataSource = (object)this.listaMediosPago;
            this.cmbMedioPago.ValueMember = "idMedioPago";
            this.cmbMedioPago.DisplayMember = "nombreMedioPago";
            this.cmbMedioPago.SelectedValue = (object)0;
        }

        private void obtieneFolioCotizacionDisponible()
        {
            this.txtNumeroDocumento.Text = new Cotizacion().numeroCotizacion(this._caja).ToString();
        }

        private void obtieneFolioCotizacionDisponibleSinCaja()
        {
            this.txtNumeroDocumento.Text = new Cotizacion().numeroCotizacionSinCaja().ToString();
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
            this.cmbBodega.DataSource = (object)new CargaMaestros().cargaBodega();
            this.cmbBodega.ValueMember = "codigo";
            this.cmbBodega.DisplayMember = "descripcion";
            if (this._bodega == 0)
            {
                this.cmbBodega.Enabled = true;
                this.cmbBodega.SelectedValue = (object)1;
                this._modBodega = true;
            }
            else
            {
                this.cmbBodega.Enabled = false;
                this.cmbBodega.SelectedValue = (object)this._bodega;
                this._modBodega = false;
            }
        }

        private void cargaListaPrecio()
        {
            this.cmbListaPrecio.DataSource = (object)new CargaMaestros().cargaListaPrecio();
            this.cmbListaPrecio.ValueMember = "codigo";
            this.cmbListaPrecio.DisplayMember = "descripcion";
            if (this._listaPrecio == 0)
            {
                this.cmbListaPrecio.Enabled = true;
                this.cmbListaPrecio.SelectedValue = (object)1;
            }
            else
            {
                this.cmbListaPrecio.Enabled = false;
                this.cmbListaPrecio.SelectedValue = (object)this._listaPrecio;
            }
        }

        private void cargaIvaInicio()
        {
            this.ivaInicio = new Calculos()._iva;
        }

        private void iniciaFormulario()
        {
            try
            {
                this.cargaIvaInicio();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Cargar Porcentaje del Iva: " + ex.Message);
            }
            try
            {
                this.cargaVendedoresInicio();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Cargar Vendedores: " + ex.Message);
                this.Close();
            }
            try
            {
                this.cargaCentroCostoInicio();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Cargar Centro Costo: " + ex.Message);
                this.Close();
            }
            try
            {
                this.cargaMediosPagoInicio();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Cargar Medios de Pago: " + ex.Message);
                this.Close();
            }
            try
            {
                this.cargaImpuestosInicio();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Cargar Impuestos: " + ex.Message);
                this.Close();
            }
            try
            {
                this.cargaOpcionesDocumentosInicio();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Cargar Opciones de Documento: " + ex.Message);
                this.Close();
            }
        }

        public void iniciaVenta()
        {
            if (!this.chkMedioPagoFijo.Checked)
                this.cargaMediosPago();
            if (!this.chkVendedorFijo.Checked)
                this.cargaVendedores();
            this.chkMedioPagoFijo.Enabled = true;
            this.cmbMedioPago.Enabled = true;
            this.cargaCentroCosto();
            this.cargaImpuestos();
            this.cargaBodega();
            this.cargaListaPrecio();
            this.codigoCliente = 0;
            this.cargaOpcionesDocumentos();
            this.txtPorIva.Text = this.ivaInicio.ToString("N0");
            this.chkExento.Checked = false;
            try
            {
                this.obtieneFolioCotizacionDisponible();
                this.txtNumeroDocumento.Enabled = false;
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error Cargar Folio: " + ex.Message);
            }
            this.txtDiasPlazo.Text = "0";
            this.txtDiasPlazo.Enabled = false;
            this.dtpEmision.Value = DateTime.Today;
            this.dtpVencimiento.Value = DateTime.Today;
            if (this._cambioFecha)
            {
                this.dtpEmision.Enabled = true;
                this.dtpVencimiento.Enabled = true;
            }
            else
            {
                this.dtpEmision.Enabled = false;
                this.dtpVencimiento.Enabled = false;
            }
            this.panelFolio.Visible = false;
            this.txtOrdenCompra.Clear();
            this.txtRut.Clear();
            this.txtDigito.Clear();
            this.txtRazonSocial.Clear();
            this.txtRazonSocial.Enabled = true;
            this.txtDireccion.Clear();
            this.txtDireccion.Enabled = true;
            this.txtCiudad.Clear();
            this.txtCiudad.Enabled = true;
            this.txtComuna.Clear();
            this.txtComuna.Enabled = true;
            this.txtGiro.Clear();
            this.txtGiro.Enabled = true;
            this.txtFono.Clear();
            this.txtFono.Enabled = true;
            this.txtFax.Clear();
            this.txtFax.Enabled = true;
            this.txtContacto.Clear();
            this.txtEmail.Clear();
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
            this.txtSubTotal.Clear();
            this.txtTotalDescuento.Clear();
            this.txtPorcDescuentoTotal.Clear();
            this.txtNeto.Clear();
            this.txtIva.Clear();
            this.txtTotalGeneral.Clear();
            this.txtTotalImp1.Clear();
            this.txtTotalImp2.Clear();
            this.txtTotalImp3.Clear();
            this.txtTotalImp4.Clear();
            this.txtTotalImp5.Clear();
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
            this.btnEnviarCorreo.Enabled = false;
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
            this.lblTipoDoc.Text = "";
            this.dgvDatosVenta.DataSource = (object)null;
            this.dgvDatosVenta.Columns.Clear();
            this.creaColumnasDetalle();
            this.pnlBuscaClienteDes.Visible = false;
            this.creaColumnasBuscaClientes();
            this.idCotizacion = 0;
            this.valorCompra = new Decimal(0);
            this.lista.Clear();
            this.listaAuxiliar.Clear();
            this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = true;
            this.limpiaEntradaDetalle();
            this.gbZonaOtros.TabIndex = 0;
            this.gbZonaCliente.TabIndex = 1;
            this.panelZonaDetalle.TabIndex = 2;
            this.gbZonaBotones.TabIndex = 3;
            this.gbZonaFechas.TabIndex = 4;
            this.panelFolio.TabIndex = 5;
            this.pnlBuscaClienteDes.TabIndex = 6;
            this.cmbMedioPago.Focus();
            this.pnlUsaCotizacion.Visible = false;
        }

        private void creaColumnasDetalle()
        {
            this.dgvDatosVenta.AutoGenerateColumns = false;
            this.dgvDatosVenta.Columns.Add("Linea", "");
            this.dgvDatosVenta.Columns[0].DataPropertyName = "Linea";
            this.dgvDatosVenta.Columns[0].Width = 20;
            this.dgvDatosVenta.Columns[0].Resizable = DataGridViewTriState.False;
            this.dgvDatosVenta.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
            this.dgvDatosVenta.Columns.Add("Codigo", "Codigo");
            this.dgvDatosVenta.Columns[1].DataPropertyName = "Codigo";
            this.dgvDatosVenta.Columns[1].Width = 100;
            this.dgvDatosVenta.Columns[1].Resizable = DataGridViewTriState.False;
            this.dgvDatosVenta.Columns.Add("Descripcion", "Descripcion");
            this.dgvDatosVenta.Columns[2].DataPropertyName = "Descripcion";
            this.dgvDatosVenta.Columns[2].Width = 307;
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
            this.dgvDatosVenta.Columns[5].Width = 60;
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
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "Eliminar";
            viewButtonColumn.HeaderText = "Eliminar";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            viewButtonColumn.Text = "X";
            viewButtonColumn.Width = 50;
            viewButtonColumn.DisplayIndex = 14;
            this.dgvDatosVenta.Columns.Add((DataGridViewColumn)viewButtonColumn);
            this.dgvDatosVenta.Columns.Add("IdImpuesto", "IdImpuesto");
            this.dgvDatosVenta.Columns[15].DataPropertyName = "IdImpuesto";
            this.dgvDatosVenta.Columns[15].Width = 90;
            this.dgvDatosVenta.Columns[15].Resizable = DataGridViewTriState.False;
            this.dgvDatosVenta.Columns[15].Visible = false;
            this.dgvDatosVenta.Columns.Add("NetoLinea", "NetoLinea");
            this.dgvDatosVenta.Columns[16].DataPropertyName = "NetoLinea";
            this.dgvDatosVenta.Columns[16].Width = 90;
            this.dgvDatosVenta.Columns[16].Resizable = DataGridViewTriState.False;
            this.dgvDatosVenta.Columns[16].Visible = false;
            this.dgvDatosVenta.Columns.Add("ValorCompra", "ValorCompra");
            this.dgvDatosVenta.Columns[17].DataPropertyName = "ValorCompra";
            this.dgvDatosVenta.Columns[17].Width = 90;
            this.dgvDatosVenta.Columns[17].Resizable = DataGridViewTriState.False;
            this.dgvDatosVenta.Columns[17].Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal._modCotizacion = 0;
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
                descuento = calculos.descuentoValorLinea(porDesc, subTotal);
            if (num1 == 2)
            {
                porDesc = calculos.descuentoPorcentajeLinea(descuento, subTotal);
                descuento = calculos.descuentoValorLinea(porDesc, subTotal);
            }
            if (subTotal == new Decimal(0) || subTotal > descuento)
            {
                this.txtSubTotalLinea.Text = subTotal.ToString("N" + this.decimalesValoresVenta);
                this.txtDescuento.Text = descuento.ToString("##");
                this.txtPorcDescuentoLinea.Text = porDesc.ToString("##");
                Decimal total = Convert.ToDecimal(calculos.totalLinea(subTotal, descuento).ToString("N" + this.decimalesValoresVenta));
                this.txtTotalLinea.Text = total.ToString("N" + this.decimalesValoresVenta);
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
                if (this.idImpuesto != 5)
                    return;
                this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
            }
            else
            {
                int num4 = (int)MessageBox.Show("El Descuento debe ser Menor al Total!!");
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
            this.cmbBodega.SelectedValue = (object)bodega.ToString();
            this.noVender = 0;
            Producto producto = new Producto();
            try
            {
                ProductoVO productoVo = producto.buscaCodigoProducto(cod);
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
                        Bodega10 = productoVo.Bodega10
                    });
                    if (this.alertaStock.Equals("1"))
                    {
                        if (this.stock <= productoVo.StockMinimo)
                        {
                            int num = (int)MessageBox.Show("El Stock de este Producto esta Bajo el Stock Minimo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                            this.txtCodigo.Text = productoVo.Codigo;
                            this.txtDescripcion.Text = productoVo.Descripcion;
                            this.valorCompra = productoVo.ValorCompra;
                            this.idImpuesto = productoVo.IdImpuesto;
                            this.txtCantidad.Focus();
                        }
                        else
                        {
                            int num3 = (int)MessageBox.Show("No esta Autorizado para Vender Productos Sin Stock");
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
                        this.txtCodigo.Text = productoVo.Codigo;
                        this.txtDescripcion.Text = productoVo.Descripcion;
                        this.idImpuesto = productoVo.IdImpuesto;
                        this.valorCompra = productoVo.ValorCompra;
                        this.txtCantidad.Focus();
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show("No Existe el Codigo Ingresado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txtCodigo.Clear();
                    this.txtCodigo.Focus();
                }
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error en: " + ex.Message);
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
            DatosVentaVO datosVentaVo = new DatosVentaVO();
            datosVentaVo.Codigo = this.txtCodigo.Text.Trim().ToUpper();
            datosVentaVo.Descripcion = this.txtDescripcion.Text.Trim().ToUpper();
            datosVentaVo.IdImpuesto = this.idImpuesto;
            datosVentaVo.NetoLinea = this.netoLinea;
            datosVentaVo.ValorCompra = this.valorCompra;
            datosVentaVo.ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
            datosVentaVo.Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
            if (datosVentaVo.Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && this.txtCodigo.Text.Length > 0)
            {
                int num = (int)MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Imposible Hacer Venta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtCantidad.Focus();
            }
            else
            {
                if (datosVentaVo.Cantidad > this.stock && this.alertaStock.Equals("1") && this.txtCodigo.Text.Length > 0)
                {
                    int num1 = (int)MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                datosVentaVo.Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
                datosVentaVo.PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
                datosVentaVo.TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
                datosVentaVo.SubTotalLinea = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text) : new Decimal(0);
                datosVentaVo.TipoDescuento = Convert.ToInt32(this.txtTipoDescuento.Text);
                datosVentaVo.ListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
                datosVentaVo.Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                datosVentaVo.FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
                if (this.lista.Count < Convert.ToInt32(this.numeroLineas))
                {
                    if (this.lista.Count > 0)
                    {
                        bool flag = false;
                        for (int index = 0; index < this.lista.Count; ++index)
                        {
                            if (datosVentaVo.Cantidad + this.lista[index].Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && datosVentaVo.Bodega == this.lista[index].Bodega && datosVentaVo.Codigo == this.lista[index].Codigo)
                            {
                                int num2 = (int)MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()));
                                this.txtCantidad.Focus();
                                flag = true;
                            }
                            else if (datosVentaVo.Codigo.Length > 0 && datosVentaVo.Codigo == this.lista[index].Codigo && (datosVentaVo.ValorVenta == this.lista[index].ValorVenta && datosVentaVo.ListaPrecio == this.lista[index].ListaPrecio) && datosVentaVo.Bodega == this.lista[index].Bodega)
                            {
                                flag = true;
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
                                    int num3 = (int)MessageBox.Show("El Descuento debe ser Menor al Total!!");
                                }
                                index = Enumerable.Count<DatosVentaVO>((IEnumerable<DatosVentaVO>)this.lista);
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
                    int num4 = (int)MessageBox.Show("Se Alcanzo el Maximo de Lineas Soportadas Por este Documento.");
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
            this.dgvDatosVenta.DataSource = (object)null;
            this.dgvDatosVenta.DataSource = (object)this.lista;
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
            ArrayList arrayList = new ArrayList();
            if (flag1 || flag2 || (flag3 || flag4) || flag5)
                arrayList = calculos.totalImpuestos(this.lista);
            Decimal num4;
            if (flag1)
            {
                TextBox textBox = this.txtTotalImp1;
                num4 = Convert.ToDecimal(arrayList[0].ToString());
                string str = num4.ToString("N" + this.decimalesValoresVenta);
                textBox.Text = str;
            }
            else
                this.txtTotalImp1.Text = "";
            if (flag2)
            {
                TextBox textBox = this.txtTotalImp2;
                num4 = Convert.ToDecimal(arrayList[1].ToString());
                string str = num4.ToString("N" + this.decimalesValoresVenta);
                textBox.Text = str;
            }
            else
                this.txtTotalImp2.Text = "";
            if (flag3)
            {
                TextBox textBox = this.txtTotalImp3;
                num4 = Convert.ToDecimal(arrayList[2].ToString());
                string str = num4.ToString("N" + this.decimalesValoresVenta);
                textBox.Text = str;
            }
            else
                this.txtTotalImp3.Text = "";
            if (flag4)
            {
                TextBox textBox = this.txtTotalImp4;
                num4 = Convert.ToDecimal(arrayList[3].ToString());
                string str = num4.ToString("N" + this.decimalesValoresVenta);
                textBox.Text = str;
            }
            else
                this.txtTotalImp4.Text = "";
            if (flag5)
            {
                TextBox textBox = this.txtTotalImp5;
                num4 = Convert.ToDecimal(arrayList[4].ToString());
                string str = num4.ToString("N" + this.decimalesValoresVenta);
                textBox.Text = str;
            }
            else
                this.txtTotalImp5.Text = "";
            this.txtTotalGeneral.Text = calculos.totalGeneral2(this.lista).ToString("N" + this.decimalesValoresVenta);
            this.txtTotalDescuento.Text = calculos.totalDescuento(this.lista).ToString("N" + this.decimalesValoresVenta);
            Decimal neto = calculos.totalNeto2(this.lista);
            TextBox textBox1 = this.txtSubTotal;
            num4 = calculos.totalSubTotal(this.lista);
            string str1 = num4.ToString("N" + this.decimalesValoresVenta);
            textBox1.Text = str1;
            TextBox textBox2 = this.txtIva;
            num4 = calculos.totalIva(neto);
            string str2 = num4.ToString("N" + this.decimalesValoresVenta);
            textBox2.Text = str2;
            this.txtNeto.Text = neto.ToString("N" + this.decimalesValoresVenta);
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
            if ((int)e.KeyChar == 46)
                e.KeyChar = ',';
            if (caja.Text.Trim().Length == 0 && (int)e.KeyChar == 44)
                e.KeyChar = '0';
            if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                bool flag = false;
                int num = 0;
                for (int index = 0; index < caja.Text.Length; ++index)
                {
                    if ((int)caja.Text[index] == 44)
                        flag = true;
                    if (flag && num++ >= 4)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
                    e.Handled = false;
                else if ((int)e.KeyChar == 44)
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
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0)
                return;
            e.Handled = false;
            this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
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
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtCantidad);
            if ((int)e.KeyChar != 13 || this.txtCantidad.Text.Length <= 0)
                return;
            if (this.btnAgregar.Enabled)
                this.agregaLineaGrilla();
            if (this.btnModificaLinea.Visible)
                this.modificaLinea();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtDescuento);
            if ((int)e.KeyChar != 13)
                return;
            if (this.btnAgregar.Enabled)
                this.agregaLineaGrilla();
            if (this.btnModificaLinea.Visible)
                this.modificaLinea();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.veOBCotizacion = new Venta();
            this.iniciaVenta();
        }

        private void btnLimpiaDetalle_Click(object sender, EventArgs e)
        {
            this.dgvDatosVenta.DataSource = (object)null;
            this.lista.Clear();
            this.txtSubTotal.Clear();
            this.txtNeto.Clear();
            this.txtIva.Clear();
            this.txtTotalDescuento.Clear();
            this.txtPorcDescuentoTotal.Clear();
            this.txtTotalGeneral.Clear();
            this.txtTipoDescuento.Text = "0";
            this.txtSubTotalLinea.Clear();
            this.txtTotalImp1.Clear();
            this.txtTotalImp2.Clear();
            this.txtTotalImp3.Clear();
            this.txtTotalImp4.Clear();
            this.txtTotalImp5.Clear();
            this.txtTipoDescuento.Text = "0";
            this.txtSubTotalLinea.Clear();
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
            if ((int)e.KeyChar != 13)
                return;
            e.Handled = false;
            if (this.txtRut.Text.Length > 0)
            {
                this.buscaCliente();
            }
            else
            {
                int num = (int)MessageBox.Show("Debe Ingresar RUT a Buscar");
                this.txtRut.Focus();
            }
            this.txtCodigo.Focus();
        }

        private void buscaCliente()
        {
            ArrayList arrayList = new ArrayList();
            ArrayList cli = new Cliente().buscaRutCliente(this.txtRut.Text.Trim());
            if (cli.Count > 1)
            {
                this.txtRazonSocial.Enabled = true;
                int num = (int)new frmClienteMismoRut(cli, ref this.intance, "cotizacion").ShowDialog();
            }
            else if (cli.Count == 0)
            {
                if (MessageBox.Show("No Existe Cliente Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            this.txtRazonSocial.Text = clienteVo.RazonSocial;
            this.txtDireccion.Text = clienteVo.Direccion;
            this.txtComuna.Text = clienteVo.Comuna;
            this.txtCiudad.Text = clienteVo.Ciudad;
            this.txtGiro.Text = clienteVo.Giro;
            this.txtFono.Text = clienteVo.Telefono;
            this.txtFax.Text = clienteVo.Fax;
            this.txtContacto.Text = clienteVo.Contacto;
            this.txtEmail.Text = clienteVo.Email;
            this.txtDiasPlazo.Text = clienteVo.DiasPlazo;
            this.cmbListaPrecio.SelectedValue = (object)clienteVo.ListaPrecio;
            if (clienteVo.Estado == 1)
            {
                this.cmbMedioPago.SelectedValue = (object)clienteVo.IdMedioPago;
                this.chkMedioPagoFijo.Enabled = false;
                this.chkMedioPagoFijo.Checked = false;
                this.cmbMedioPago.Enabled = false;
                int num = (int)MessageBox.Show("Cliente BLOQUEADO por: " + clienteVo.MotivoBloqueo + "\r\nSolo podra efecturar pagos en: " + this.cmbMedioPago.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.chkMedioPagoFijo.Enabled = true;
                this.cmbMedioPago.Enabled = true;
            }
            this.calculaFechaVencimiento(Convert.ToInt32(clienteVo.DiasPlazo));
            this.txtCodigo.Focus();
        }

        private void calculaFechaVencimiento(int dias)
        {
            this.dtpVencimiento.Value = this.dtpEmision.Value.AddDays((double)dias);
        }

        private void dtpEmision_ValueChanged(object sender, EventArgs e)
        {
            this.calculaFechaVencimiento(Convert.ToInt32(this.txtDiasPlazo.Text.Trim()));
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            int num = (int)new frmBuscaClientes(ref this.intance, "cotizacion").ShowDialog();
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {
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
            frmMenuPrincipal._modCotizacion = 0;
        }

        private void guardaCotizacion()
        {
            if (!this.validaCampos())
                return;
            DateTime dateTime1 = DateTime.Now;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            DateTime local001 = @dateTime1;
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
            local001 = new DateTime(year1, month1, day1, hours1, minutes1, seconds1);
            DateTime dateTime2 = DateTime.Now;
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
            Venta veOB = new Venta();
            veOB.Caja = this._caja;
            veOB.FechaEmision = Convert.ToDateTime(dtpEmision.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            veOB.FechaVencimiento = Convert.ToDateTime(dtpVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            veOB.FechaModificacion = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            veOB.IdCliente = this.codigoCliente;
            veOB.Rut = this.txtRut.Text.Trim();
            veOB.Digito = this.txtDigito.Text.Trim();
            veOB.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
            veOB.Direccion = this.txtDireccion.Text.Trim().ToUpper();
            veOB.Comuna = this.txtComuna.Text.Trim().ToUpper();
            veOB.Ciudad = this.txtCiudad.Text.Trim().ToUpper();
            veOB.Giro = this.txtGiro.Text.Trim().ToUpper();
            veOB.Fono = this.txtFono.Text.Trim();
            veOB.Fax = this.txtFax.Text.Trim();
            veOB.Contacto = this.txtContacto.Text.Trim().ToUpper();
            veOB.Email = this.txtEmail.Text.Trim();
            veOB.DiasPlazo = Convert.ToInt32(this.txtDiasPlazo.Text.Trim());
            if (this.cmbMedioPago.SelectedValue.ToString() != "0")
            {
                veOB.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
                veOB.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
            }
            if (this.cmbVendedor.SelectedValue != null)
            {
                if (this.cmbVendedor.SelectedValue.ToString() != "0")
                {
                    veOB.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
                    veOB.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
                    foreach (VendedorVO vendedorVo in this.listaVendedores)
                    {
                        if (veOB.IdVendedor == vendedorVo.IdVendedor)
                            veOB.ComisionVendedor = vendedorVo.Comision;
                    }
                }
            }
            else if (this.cmbVendedor.Text != "[SELECCIONE]")
                veOB.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
            if (this.cmbCentroCosto.SelectedValue != null)
            {
                if (this.cmbCentroCosto.SelectedValue.ToString() != "0")
                {
                    veOB.IdCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
                    veOB.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
                }
            }
            else if (this.cmbCentroCosto.Text != "[SELECCIONE]")
                veOB.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
            veOB.OrdenCompra = this.txtOrdenCompra.Text.Trim();
            veOB.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
            veOB.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
            veOB.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
            veOB.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
            veOB.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
            veOB.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
            veOB.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
            NumeroaLetra numeroaLetra = new NumeroaLetra();
            veOB.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
            veOB.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
            veOB.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
            veOB.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
            veOB.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
            veOB.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
            veOB.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
            veOB.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
            veOB.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
            veOB.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
            veOB.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
            veOB.EstadoDocumento = "EMITIDO";
            Cotizacion cotizacion = new Cotizacion();
            if (cotizacion.cotizacionExiste(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim())))
            {
                this.obtieneFolioCotizacionDisponible();
                if (this.txtNumeroDocumento.Text.Trim() == "1")
                    this.obtieneFolioCotizacionDisponibleSinCaja();
            }
            veOB.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
            for (int index = 0; index < this.lista.Count; ++index)
            {
                this.lista[index].FolioFactura = veOB.Folio;
                this.lista[index].FechaIngreso = veOB.FechaEmision;
            }
            cotizacion.agregaCotizacion(veOB);
            cotizacion.agregaDetalleCotizacion(this.lista);
            this.imprimeCotizacion(Convert.ToInt32(this.txtNumeroDocumento.Text));
            try
            {
                this.enviarMail();
            }
            catch
            {
                this.iniciaVenta();
            }
            if (limpiar)
            {
                this.iniciaVenta();
            }
        }

        private void imprimeCotizacion(int folio)
        {
            if (MessageBox.Show("Desea Imprimir la Cotización?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.imprimeDirecto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardaCotizacion();
        }

        private void guardarFacturaTeclaF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.guardaCotizacion();
        }

        private void txtDescuento_Enter(object sender, EventArgs e)
        {
            if (this.txtPrecio.Text.Length > 0 && this.txtCantidad.Text.Length > 0)
            {
                this.txtTipoDescuento.Text = "2";
            }
            else
            {
                int num = (int)MessageBox.Show("Debe Ingresar Datos antes de hacer un Descuento");
                this.txtPrecio.Focus();
            }
        }

        private void txtPorcDescuentoLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtPorcDescuentoLinea);
            if ((int)e.KeyChar != 13)
                return;
            if (this.btnAgregar.Enabled)
                this.agregaLineaGrilla();
            if (this.btnModificaLinea.Visible)
                this.modificaLinea();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Modificar la Cotización ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!this.validaCampos())
                    return;
                DateTime dateTime1 = DateTime.Now;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                DateTime local001 = @dateTime1;
                DateTime now = this.dtpEmision.Value;
                int year1 = now.Year;
                now = this.dtpEmision.Value;
                int month1 = now.Month;
                now = this.dtpEmision.Value;
                int day1 = now.Day;
                now = DateTime.Now;
                int hours1 = now.TimeOfDay.Hours;
                now = DateTime.Now;
                int minutes1 = now.TimeOfDay.Minutes;
                now = DateTime.Now;
                int seconds1 = now.TimeOfDay.Seconds;
                // ISSUE: explicit reference operation
                local001 = new DateTime(year1, month1, day1, hours1, minutes1, seconds1);
                DateTime dateTime2 = DateTime.Now;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                DateTime local2 = @dateTime2;
                now = this.dtpVencimiento.Value;
                int year2 = now.Year;
                now = this.dtpVencimiento.Value;
                int month2 = now.Month;
                now = this.dtpVencimiento.Value;
                int day2 = now.Day;
                now = DateTime.Now;
                int hours2 = now.TimeOfDay.Hours;
                now = DateTime.Now;
                int minutes2 = now.TimeOfDay.Minutes;
                now = DateTime.Now;
                int seconds2 = now.TimeOfDay.Seconds;
                // ISSUE: explicit reference operation
                local2 = new DateTime(year2, month2, day2, hours2, minutes2, seconds2);
                Venta veOB = new Venta();
                veOB.IdFactura = this.idCotizacion;
                veOB.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
                veOB.FechaEmision = dateTime1;
                veOB.FechaVencimiento = dateTime2;
                veOB.IdCliente = this.codigoCliente;
                veOB.Rut = this.txtRut.Text.Trim();
                veOB.Digito = this.txtDigito.Text.Trim();
                veOB.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
                veOB.Direccion = this.txtDireccion.Text.Trim().ToUpper();
                veOB.Comuna = this.txtComuna.Text.Trim().ToUpper();
                veOB.Ciudad = this.txtCiudad.Text.Trim().ToUpper();
                veOB.Giro = this.txtGiro.Text.Trim().ToUpper();
                veOB.Fono = this.txtFono.Text.Trim();
                veOB.Fax = this.txtFax.Text.Trim();
                veOB.Contacto = this.txtContacto.Text.Trim().ToUpper();
                veOB.Email = this.txtEmail.Text.Trim();
                veOB.DiasPlazo = Convert.ToInt32(this.txtDiasPlazo.Text.Trim());
                if (this.cmbMedioPago.SelectedValue.ToString() != "0")
                {
                    veOB.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
                    veOB.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
                }
                if (this.cmbVendedor.SelectedValue != null)
                {
                    if (this.cmbVendedor.SelectedValue.ToString() != "0")
                    {
                        veOB.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
                        veOB.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
                        foreach (VendedorVO vendedorVo in this.listaVendedores)
                        {
                            if (veOB.IdVendedor == vendedorVo.IdVendedor)
                                veOB.ComisionVendedor = vendedorVo.Comision;
                        }
                    }
                    else if (this.cmbVendedor.Text != "[SELECCIONE]")
                        veOB.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
                }
                if (this.cmbCentroCosto.SelectedValue != null)
                {
                    if (this.cmbCentroCosto.SelectedValue.ToString() != "0")
                    {
                        veOB.IdCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
                        veOB.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
                    }
                    else if (this.cmbCentroCosto.Text != "[SELECCIONE]")
                        veOB.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
                }
                veOB.OrdenCompra = this.txtOrdenCompra.Text.Trim();
                veOB.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
                veOB.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
                veOB.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
                veOB.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
                veOB.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
                veOB.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
                veOB.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
                NumeroaLetra numeroaLetra = new NumeroaLetra();
                veOB.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
                veOB.EstadoPago = this.veOBCotizacion.EstadoPago;
                veOB.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
                veOB.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
                veOB.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
                veOB.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
                veOB.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
                veOB.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
                veOB.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
                veOB.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
                veOB.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
                veOB.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
                Cotizacion cotizacion = new Cotizacion();
                for (int index = 0; index < this.lista.Count; ++index)
                    this.lista[index].FechaIngreso = veOB.FechaEmision;
                int num = (int)MessageBox.Show(cotizacion.modificaCotizacion(veOB, this.lista), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.imprimeCotizacion(veOB.Folio);
                try
                {
                    this.enviarMail();
                }
                catch
                {
                    this.iniciaVenta();
                }
                this.iniciaVenta();
            }
            else
            {
                int num = (int)MessageBox.Show("La Cotizacion NO fue Modificada.");
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
                int num = (int)MessageBox.Show("Debe Selecciona el Medio de Pago");
                this.cmbMedioPago.Focus();
                return false;
            }
            if (this.lista.Count == 0)
            {
                int num = (int)MessageBox.Show("Debe Ingresar Datos a Facturar");
                this.txtCodigo.Focus();
                return false;
            }
            if (!(Convert.ToDecimal(this.txtTotalGeneral.Text) <= new Decimal(0)))
                return true;
            int num1 = (int)MessageBox.Show("Debe Ingresar Datos a Facturar");
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
                    this.dgvDatosVenta.DataSource = (object)null;
                    this.dgvDatosVenta.DataSource = (object)this.lista;
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
                this.txtTotalGeneral.Text = num4.ToString("N" + this.decimalesValoresVenta);
            }
            else
            {
                int num2 = (int)MessageBox.Show("El Descuento NO debe ser Mayor al SubTotal");
                this.txtTotalDescuento.Text = "0";
                this.txtPorcDescuentoTotal.Clear();
            }
        }

        private void txtTotalDescuento_DoubleClick(object sender, EventArgs e)
        {
            if (!((this.txtTotalImp1.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text) : new Decimal(0)) + (this.txtTotalImp2.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text) : new Decimal(0)) + (this.txtTotalImp3.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text) : new Decimal(0)) + (this.txtTotalImp4.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text) : new Decimal(0)) + (this.txtTotalImp5.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text) : new Decimal(0)) == new Decimal(0)))
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
                this.dgvDatosVenta.DataSource = (object)null;
                this.dgvDatosVenta.DataSource = (object)this.lista;
                this.calculaTotales();
                this.limpiaEntradaDetalle();
            }
            else
            {
                int num = (int)MessageBox.Show("No Hay stock Suficiente", "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool comparaStock(int bodega, Decimal stockCompara, string cod)
        {
            if (this.impideVentasSinStock.Equals("1"))
            {
                for (int index = 0; index < this.listaAuxiliar.Count; ++index)
                {
                    if (bodega == 1 && this.listaAuxiliar[index].Bodega1 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 2 && this.listaAuxiliar[index].Bodega2 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 3 && this.listaAuxiliar[index].Bodega3 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 4 && this.listaAuxiliar[index].Bodega4 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)) || (bodega == 5 && this.listaAuxiliar[index].Bodega5 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 6 && this.listaAuxiliar[index].Bodega6 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 7 && this.listaAuxiliar[index].Bodega7 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 8 && this.listaAuxiliar[index].Bodega8 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod))) || (bodega == 9 && this.listaAuxiliar[index].Bodega9 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 10 && this.listaAuxiliar[index].Bodega10 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)))
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
                int num = (int)MessageBox.Show("Debe Ingresar Datos antes de hacer un Descuento");
                this.txtPrecio.Focus();
            }
        }

        private void frmFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.txtCodigo.Focus();
                int num = (int)new frmBuscaProductos("cotizacion", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
                this.txtCantidad.Focus();
            }
            if (e.KeyCode == Keys.F6)
            {
                this.panelFolio.Visible = true;
                this.txtFolioBuscar.Focus();
            }
            if (e.KeyCode == Keys.F7)
            {
                this.txtBuscaCotizacionUsar.Clear();
                this.pnlUsaCotizacion.Visible = true;
                this.txtBuscaCotizacionUsar.Focus();
            }
            if (!this._guarda || this.veOBCotizacion.IdFactura != 0 || e.KeyCode != Keys.F2)
                return;
            this.guardaCotizacion();
        }

        private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Focus();
            int num = (int)new frmBuscaProductos("cotizacion", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
            this.txtCantidad.Focus();
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
            this.txtPrecio.Text = Convert.ToDecimal(this.dgvDatosVenta.SelectedRows[0].Cells["ValorVenta"].Value.ToString()).ToString("N" + this.decimalesValoresVenta);
            this.txtCantidad.Text = this.verificaDecimales(this.dgvDatosVenta.SelectedRows[0].Cells["Cantidad"].Value.ToString());
            this.txtDescuento.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Descuento"].Value.ToString();
            this.txtPorcDescuentoLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["PorcDescuento"].Value.ToString();
            this.txtSubTotalLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["SubTotal"].Value.ToString();
            this.txtTipoDescuento.Text = this.dgvDatosVenta.SelectedRows[0].Cells["TipoDescuento"].Value.ToString();
            this.txtLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Linea"].Value.ToString();
            this.cmbListaPrecio.SelectedValue = (object)this.dgvDatosVenta.SelectedRows[0].Cells["ListaPrecio"].Value.ToString();
            this.cmbBodega.SelectedValue = (object)this.dgvDatosVenta.SelectedRows[0].Cells["Bodega"].Value.ToString();
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
        }

        private void lblFolio_DoubleClick(object sender, EventArgs e)
        {
            this.panelFolio.Visible = true;
            this.txtFolioBuscar.Focus();
        }

        private void buscaCotizacionFolio()
        {
            this.panelFolio.Visible = false;
            Cotizacion cotizacion = new Cotizacion();
            Venta venta = cotizacion.buscaCotizacionFolio(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
            this.veOBCotizacion = venta;
            if (venta.IdFactura != 0)
            {
                this.iniciaVenta();
                this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = false;
                this.idCotizacion = venta.IdFactura;
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
                this.txtEmail.Text = venta.Email;
                this.txtDiasPlazo.Text = venta.DiasPlazo.ToString();
                TextBox textBox1 = this.txtSubTotal;
                Decimal num = venta.SubTotal;
                string str1 = num.ToString("N" + this.decimalesValoresVenta);
                textBox1.Text = str1;
                TextBox textBox2 = this.txtPorcDescuentoTotal;
                num = venta.PorcentajeDescuento;
                string str2 = num.ToString("N0");
                textBox2.Text = str2;
                TextBox textBox3 = this.txtTotalDescuento;
                num = venta.Descuento;
                string str3 = num.ToString("N" + this.decimalesValoresVenta);
                textBox3.Text = str3;
                TextBox textBox4 = this.txtNeto;
                num = venta.Neto;
                string str4 = num.ToString("N" + this.decimalesValoresVenta);
                textBox4.Text = str4;
                TextBox textBox5 = this.txtIva;
                num = venta.Iva;
                string str5 = num.ToString("N" + this.decimalesValoresVenta);
                textBox5.Text = str5;
                TextBox textBox6 = this.txtPorIva;
                num = venta.PorcentajeIva;
                string str6 = num.ToString("N0");
                textBox6.Text = str6;
                TextBox textBox7 = this.txtTotalGeneral;
                num = venta.Total;
                string str7 = num.ToString("N" + this.decimalesValoresVenta);
                textBox7.Text = str7;
                if (venta.Iva == new Decimal(0) && venta.Total > new Decimal(0))
                    this.chkExento.Checked = true;
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
                this.btnGuardar.Enabled = false;
                this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
                if (venta.EstadoDocumento.Equals("ANULADA"))
                {
                    this.btnAnular.Enabled = false;
                    this.btnImprime.Enabled = false;
                    if (this._elimina)
                        this.btnEliminar.Enabled = true;
                }
                else
                {
                    if (this._anula)
                        this.btnAnular.Enabled = true;
                    if (this._modifica)
                        this.btnModificar.Enabled = true;
                    this.btnImprime.Enabled = true;
                    this.btnEnviarCorreo.Enabled = true;
                }
                if (venta.DocumentoVenta.Length > 0)
                {
                    this.btnGuardar.Enabled = false;
                    this.btnAnular.Enabled = false;
                    this.btnModificar.Enabled = false;
                    this.btnImprime.Enabled = true;
                    this.btnEnviarCorreo.Enabled = true;
                    this.lblTipoDoc.Text = venta.DocumentoVenta + (object)" FOLIO : " + (string)(object)venta.FolioDocumentoVenta;
                }
                this.lblEstadoDocumento.Text = venta.EstadoDocumento.ToString();
                this.lista = cotizacion.buscaDetalleCotizacionIDCotizacion(venta.IdFactura);
                this.cmbBodega.SelectedValue = (object)this.lista[0].Bodega;
                for (int index = 0; index < this.lista.Count; ++index)
                    this.lista[index].Linea = index + 1;
                this.dgvDatosVenta.DataSource = (object)null;
                this.dgvDatosVenta.DataSource = (object)this.lista;
                this.txtFolioBuscar.Clear();
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe Cotización Consultada!!");
                this.txtFolioBuscar.Clear();
                this.iniciaVenta();
            }
        }

        private void btnBuscaFolio_Click(object sender, EventArgs e)
        {
            if (this.txtFolioBuscar.Text.Trim().Length > 0)
            {
                this.buscaCotizacionFolio();
            }
            else
            {
                int num = (int)MessageBox.Show("Debe Ingresar un Folio a Buscar");
                this.txtFolioBuscar.Focus();
            }
        }

        private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtPorcDescuentoLinea);
            if ((int)e.KeyChar != 13)
                return;
            if (this.txtFolioBuscar.Text.Trim().Length > 0)
            {
                this.buscaCotizacionFolio();
            }
            else
            {
                int num = (int)MessageBox.Show("Debe Ingresar un Folio a Buscar");
                this.txtFolioBuscar.Focus();
            }
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
            if (this.lblEstadoDocumento.Text.Equals("EMITIDO"))
            {
                if (MessageBox.Show("Esta seguro de Anular esta Cotización.", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cotizacion cotizacion = new Cotizacion();
                    try
                    {
                        int num = (int)MessageBox.Show(cotizacion.anulaCotizacion(this.idCotizacion, this.lista));
                        this.iniciaVenta();
                    }
                    catch (System.Exception ex)
                    {
                        int num = (int)MessageBox.Show("Error al Anular Documento " + ex.Message);
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show("La Cotizacion NO fue Anulada..");
                    this.iniciaVenta();
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Este Documento ya Se encuentra Anulado!!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!this.lblEstadoDocumento.Text.Equals("ANULADA"))
                return;
            if (MessageBox.Show("Esta seguro de Eliminar esta Cotización.", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cotizacion cotizacion = new Cotizacion();
                try
                {
                    cotizacion.eliminaCotizacion(this.idCotizacion);
                    int num = (int)MessageBox.Show("Cotizacion Eliminada");
                    this.iniciaVenta();
                }
                catch (System.Exception ex)
                {
                    int num = (int)MessageBox.Show("Error al Eliminar Documento " + ex.Message);
                }
            }
            else
            {
                int num = (int)MessageBox.Show("La Cotización NO fue Eliminada ");
                this.iniciaVenta();
            }
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            this.imprimeDirecto();
        }

        private void imprimeDirecto()
        {
            try
            {
                if (frmMenuPrincipal._MultiEmpresa)
                    this.multiEmpresa();
                else
                    this.monoEmpresa();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error " + ex.Message);
            }
        }

        private void multiEmpresa()
        {
            DataTable dataTable = new Cotizacion().muestraCotizacionFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            LeeXml leeXml = new LeeXml();
            ArrayList arrayList1 = new ArrayList();
            ArrayList arrayList2 = leeXml.cargarDatosMultiEmpresa("cotizacion");
            arrayList2[0].ToString();
            string str = arrayList2[1].ToString();
            try
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load("C:\\AptuSoft\\reportes\\Cotizacion_" + str + ".rpt");
                rpt.SetDataSource(dataTable);
                int num = (int)new frmVisualizadorReportes(rpt).ShowDialog();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error " + ex.Message);
            }
        }

        private void monoEmpresa()
        {
            DataTable dataTable = new Cotizacion().muestraCotizacionFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            try
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load("C:\\AptuSoft\\reportes\\Cotizacion.rpt");
                rpt.SetDataSource(dataTable);
                int num = (int)new frmVisualizadorReportes(rpt).ShowDialog();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show("Error " + ex.Message);
            }
        }

        private void txtTotalDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtTotalDescuento);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = (int)MessageBox.Show(this.veOBCotizacion.RazonSocial);
        }

        private void dgvDatosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            int num = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells[0].Value.ToString());
            for (int index = 0; index < this.lista.Count; ++index)
            {
                if (this.lista[index].Linea == num)
                {
                    this.lista.RemoveAt(index);
                    --index;
                }
            }
            this.calculaTotales();
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
            this.txtNumeroDocumento.Enabled = true;
            this.txtNumeroDocumento.Focus();
        }

        private void chkMedioPagoFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbMedioPago.SelectedValue == null || this.cmbMedioPago.SelectedValue.ToString() == "0")
            {
                int num = (int)MessageBox.Show("Debe Selecciona el Medio de Pago");
                this.cmbMedioPago.Focus();
                this.chkMedioPagoFijo.Checked = false;
            }
            else if (this.chkMedioPagoFijo.Checked)
                this.cmbMedioPago.Enabled = false;
            else
                this.cmbMedioPago.Enabled = true;
        }

        private void chkVendedorFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbVendedor.SelectedValue == null || this.cmbVendedor.SelectedValue.ToString() == "0")
            {
                int num = (int)MessageBox.Show("Debe Selecciona un Vendedor");
                this.cmbVendedor.Focus();
                this.chkVendedorFijo.Checked = false;
            }
            else if (this.chkVendedorFijo.Checked)
                this.cmbVendedor.Enabled = false;
            else
                this.cmbVendedor.Enabled = true;
        }

        private void txtOrdenCompra_Leave(object sender, EventArgs e)
        {
        }

        private void txtPorcDescuentoTotal_DoubleClick(object sender, EventArgs e)
        {
            if (!((this.txtTotalImp1.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text) : new Decimal(0)) + (this.txtTotalImp2.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text) : new Decimal(0)) + (this.txtTotalImp3.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text) : new Decimal(0)) + (this.txtTotalImp4.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text) : new Decimal(0)) + (this.txtTotalImp5.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text) : new Decimal(0)) == new Decimal(0)))
                return;
            this.txtPorcDescuentoTotal.ReadOnly = false;
        }

        private void btnCerrarBuscaCliente_Click(object sender, EventArgs e)
        {
            this.pnlBuscaClienteDes.Visible = false;
        }

        private void txtBuscaCotizacionUsar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtBuscaCotizacionUsar);
            if ((int)e.KeyChar != 13)
                return;
            if (this.txtBuscaCotizacionUsar.Text.Trim().Length > 0)
            {
                this.usarCotizacionFolio();
            }
            else
            {
                int num = (int)MessageBox.Show("Debe Ingresar un Folio a Buscar");
                this.txtBuscaCotizacionUsar.Focus();
            }
        }

        private void usarCotizacionFolio()
        {
            this.pnlUsaCotizacion.Visible = false;
            Cotizacion cotizacion = new Cotizacion();
            Venta venta = cotizacion.buscaCotizacionFolio(Convert.ToInt32(this.txtBuscaCotizacionUsar.Text.Trim()));
            this.veOBCotizacion = venta;
            if (venta.IdFactura != 0)
            {
                this.iniciaVenta();
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
                this.codigoCliente = venta.IdCliente;
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
                string str1 = num.ToString("N" + this.decimalesValoresVenta);
                textBox1.Text = str1;
                TextBox textBox2 = this.txtPorcDescuentoTotal;
                num = venta.PorcentajeDescuento;
                string str2 = num.ToString("N0");
                textBox2.Text = str2;
                TextBox textBox3 = this.txtTotalDescuento;
                num = venta.Descuento;
                string str3 = num.ToString("N" + this.decimalesValoresVenta);
                textBox3.Text = str3;
                TextBox textBox4 = this.txtNeto;
                num = venta.Neto;
                string str4 = num.ToString("N" + this.decimalesValoresVenta);
                textBox4.Text = str4;
                TextBox textBox5 = this.txtIva;
                num = venta.Iva;
                string str5 = num.ToString("N" + this.decimalesValoresVenta);
                textBox5.Text = str5;
                TextBox textBox6 = this.txtPorIva;
                num = venta.PorcentajeIva;
                string str6 = num.ToString("N0");
                textBox6.Text = str6;
                TextBox textBox7 = this.txtTotalGeneral;
                num = venta.Total;
                string str7 = num.ToString("N" + this.decimalesValoresVenta);
                textBox7.Text = str7;
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
                this.lista = cotizacion.buscaDetalleCotizacionIDCotizacion(venta.IdFactura);
                this.cmbBodega.SelectedValue = (object)this.lista[0].Bodega;
                for (int index = 0; index < this.lista.Count; ++index)
                    this.lista[index].Linea = index + 1;
                this.dgvDatosVenta.DataSource = (object)null;
                this.dgvDatosVenta.DataSource = (object)this.lista;
                this.txtFolioBuscar.Clear();
                this.calculaTotales();
                if (!(venta.Iva == new Decimal(0)) || !(venta.Total > new Decimal(0)))
                    return;
                this.chkExento.Checked = true;
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe Cotización Consultada!!");
                this.txtFolioBuscar.Clear();
                this.iniciaVenta();
            }
        }

        private void btnBuscaCotizacionUsar_Click(object sender, EventArgs e)
        {
            this.usarCotizacionFolio();
        }

        private void usarCotizaciónTeclaF7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBuscaCotizacionUsar.Clear();
            this.pnlUsaCotizacion.Visible = true;
            this.txtBuscaCotizacionUsar.Focus();
        }

        private void btnCerrarBuscaCotizacionUsar_Click(object sender, EventArgs e)
        {
            this.pnlUsaCotizacion.Visible = false;
            this.txtBuscaCotizacionUsar.Clear();
        }

        private void quitaIva()
        {
            this.txtIva.Text = "0";
            this.txtTotalImp1.Clear();
            this.txtTotalImp2.Clear();
            this.txtTotalImp3.Clear();
            this.txtTotalImp4.Clear();
            this.txtTotalImp5.Clear();
            this.txtTotalGeneral.Text = this.txtNeto.Text;
        }

        private void chkExento_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkExento.Checked)
                this.quitaIva();
            else
                this.calculaTotales();
        }

        private void btnBuscaPreCliente_Click(object sender, EventArgs e)
        {
            int num = (int)new frmBuscaPreClientes(ref this.intance, "cotizacion").ShowDialog();
        }

        public void buscaPreClienteCodigo(int cod)
        {
            ClienteVO clienteVo = new PreCliente().buscaCodigoCliente(cod);
            this.codigoCliente = clienteVo.Codigo;
            this.txtRut.Text = clienteVo.Rut;
            this.txtDigito.Text = clienteVo.Digito;
            this.txtRazonSocial.Text = clienteVo.RazonSocial;
            this.txtDireccion.Text = clienteVo.Direccion;
            this.txtComuna.Text = clienteVo.Comuna;
            this.txtCiudad.Text = clienteVo.Ciudad;
            this.txtGiro.Text = clienteVo.Giro;
            this.txtFono.Text = clienteVo.Telefono;
            this.txtFax.Text = clienteVo.Fax;
            this.txtContacto.Text = clienteVo.Contacto;
            this.txtDiasPlazo.Text = clienteVo.DiasPlazo.Length > 0 ? clienteVo.DiasPlazo : "0";
            this.txtEmail.Text = clienteVo.Email;
            this.chkMedioPagoFijo.Enabled = true;
            this.cmbMedioPago.Enabled = true;
            this.txtCodigo.Focus();
        }

        private void enviarMail()
        {
            if (MessageBox.Show("Desea Enviar la Cotización por Outlook?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            this.verificaDirectorio();
            this.cotizacionPDF();
            try
            {

               /* _MailItem mailItem = (_MailItem)((_Application)new ApplicationClass()).CreateItem(OlItemType.olMailItem);
                mailItem.To = this.txtEmail.Text;
                mailItem.Subject = "Cotizacion Numero: " + this.txtNumeroDocumento.Text;
                mailItem.Attachments.Add((object)("C:\\AptuSoft\\PDF\\COTIZACIONES\\Cotizacion_" + this.txtNumeroDocumento.Text + ".pdf"), (object)OlAttachmentType.olByValue, (object)1, (object)"Report");
                mailItem.Display((object)true);*/
            }
            catch
            {
                this.iniciaFormulario();
            }
        }

        private void cotizacionPDF()
        {
            DataTable dataTable = new Cotizacion().muestraCotizacionFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\AptuSoft\\reportes\\Cotizacion.rpt");
            reportDocument.SetDataSource(dataTable);
            try
            {
                DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
                destinationOptions.DiskFileName = "C:\\AptuSoft\\PDF\\COTIZACIONES\\Cotizacion_" + this.txtNumeroDocumento.Text + ".pdf";
                ExportOptions exportOptions = reportDocument.ExportOptions;
                exportOptions.ExportDestinationType = (ExportDestinationType)1;
                exportOptions.ExportFormatType = (ExportFormatType)5;
                exportOptions.DestinationOptions = (object)destinationOptions;
                exportOptions.FormatOptions = (object)wordFormatOptions;
                reportDocument.Export();
            }
            catch (System.Exception ex)
            {
                int num = (int)MessageBox.Show(ex.ToString());
            }
        }

        private void verificaDirectorio()
        {
            string path = "C:\\AptuSoft\\PDF\\COTIZACIONES";
            if (Directory.Exists(path))
                return;
            Directory.CreateDirectory(path);
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                this.enviarMail();
            }
            catch
            {
                this.iniciaVenta();
            }
        }
    }
}
