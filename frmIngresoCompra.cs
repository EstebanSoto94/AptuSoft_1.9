 
// Type: Aptusoft.frmIngresoCompra
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using Aptusoft.Lotes;
using Aptusoft.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmIngresoCompra : Form
  {
    private static List<DatosVentaVO> lista = new List<DatosVentaVO>();
    private IContainer components = (IContainer) null;
    private bool esExento = false;
    private bool _modBodega = false;
    private OpcionesDocumentosVO odVO = new OpcionesDocumentosVO();
    public List<LoteVO> _listaLote = new List<LoteVO>();
    public List<LoteVO> _listaLoteAntigua = new List<LoteVO>();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private bool _descuento = false;
    private bool _cambioPrecio = false;
    private int _bodega = 0;
    private int idImpuesto = 0;
    private string _permisoMedioPago = "";
    private bool _permisoPemitirMedioPago = false;
    private string _opcionBusquedaRazonSocial = "1";
    private Venta veOBCompra = new Venta();
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
    private ComboBox cmbTipoDocumento;
    private GroupBox gbZonaOtros;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private Label label28;
    private ComboBox cmbBodega;
    private Panel panelZonaDetalle;
    private Button btnBuscaProveedor;
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
    private ToolStripMenuItem guardarFacturaTeclaF2ToolStripMenuItem;
    private Button btnImprime;
    private Button btnControlPago;
    private Label label3;
    private GroupBox gbZonaDocumento;
    private TextBox txtPrecioIva;
    private Label label21;
    private Button btnBuscarDocumento;
    private TextBox txtFolioFacturaNC;
    private Label lblFolioFactura;
    private TextBox txtOtroImpuesto;
    private Label label29;
    private CheckBox chkExento;
    private TextBox txtTotalCobrar;
    private Label label32;
    private Label label33;
    private TextBox txtTotalExento;
    private ComboBox cmbPeriodo;
    private Label label34;
    private ToolTip toolTip1;
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
    private Label lblCodImp5;
    private Label lblCodImp4;
    private Label lblCodImp3;
    private Label lblCodImp2;
    private Label lblCodImp1;
    private Label lblImp5;
    private Label lblImp4;
    private Label lblImp3;
    private Label lblImp2;
    private Label lblImp1;
    private frmIngresoCompra intance;
    private int codigoProveedor;
    private int idCompra;
    private DataGridView dgvBuscaProveedor;
    private Panel pnlBuscaProveedorDes;
    private string decimalesValoresVenta;

    public frmIngresoCompra()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.cargaOpcionesDocumentosInicio();
      this.iniciaCompra();
      this.intance = this;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosTeclaF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarFacturaTeclaF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
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
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gbZonaBotones = new System.Windows.Forms.GroupBox();
            this.txtTotalCobrar = new System.Windows.Forms.TextBox();
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
            this.chkExento = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btnControlPago = new System.Windows.Forms.Button();
            this.btnImprime = new System.Windows.Forms.Button();
            this.txtOtroImpuesto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPorIva = new System.Windows.Forms.TextBox();
            this.txtTotalExento = new System.Windows.Forms.TextBox();
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
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.gbZonaOtros = new System.Windows.Forms.GroupBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtFolioFacturaNC = new System.Windows.Forms.TextBox();
            this.lblFolioFactura = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.cmbCentroCosto = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.panelZonaDetalle = new System.Windows.Forms.Panel();
            this.txtPorcDescuentoLinea = new System.Windows.Forms.TextBox();
            this.txtPrecioIva = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnLimpiaLineaDetalle = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.txtTipoDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotalLinea = new System.Windows.Forms.TextBox();
            this.btnModificaLinea = new System.Windows.Forms.Button();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.gbZonaDocumento = new System.Windows.Forms.GroupBox();
            this.btnBuscarDocumento = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvBuscaProveedor = new System.Windows.Forms.DataGridView();
            this.pnlBuscaProveedorDes = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.gbZonaCliente.SuspendLayout();
            this.gbZonaBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            this.gbZonaOtros.SuspendLayout();
            this.panelZonaDetalle.SuspendLayout();
            this.gbZonaDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaProveedor)).BeginInit();
            this.pnlBuscaProveedorDes.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProductosTeclaF4ToolStripMenuItem,
            this.guardarFacturaTeclaF2ToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarProductosTeclaF4ToolStripMenuItem
            // 
            this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
            this.buscarProductosTeclaF4ToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
            this.buscarProductosTeclaF4ToolStripMenuItem.Click += new System.EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
            // 
            // guardarFacturaTeclaF2ToolStripMenuItem
            // 
            this.guardarFacturaTeclaF2ToolStripMenuItem.Name = "guardarFacturaTeclaF2ToolStripMenuItem";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.guardarFacturaTeclaF2ToolStripMenuItem.Text = "Guardar Documento - tecla[F2]";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Click += new System.EventHandler(this.guardarFacturaTeclaF2ToolStripMenuItem_Click);
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
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(669, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Cant.";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(758, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 23);
            this.label19.TabIndex = 6;
            this.label19.Text = "$ Desc.";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(596, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "$ Neto";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(201, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(316, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Descripcion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(669, 21);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(38, 20);
            this.txtCantidad.TabIndex = 13;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(113, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(113, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(822, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 23);
            this.label20.TabIndex = 7;
            this.label20.Text = "Total";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(200, 21);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(322, 20);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // txtTotalLinea
            // 
            this.txtTotalLinea.BackColor = System.Drawing.Color.White;
            this.txtTotalLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalLinea.Enabled = false;
            this.txtTotalLinea.Location = new System.Drawing.Point(822, 21);
            this.txtTotalLinea.Name = "txtTotalLinea";
            this.txtTotalLinea.Size = new System.Drawing.Size(69, 20);
            this.txtTotalLinea.TabIndex = 16;
            this.txtTotalLinea.TabStop = false;
            this.txtTotalLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbZonaCliente
            // 
            this.gbZonaCliente.Controls.Add(this.btnBuscaProveedor);
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
            this.gbZonaCliente.Location = new System.Drawing.Point(197, 71);
            this.gbZonaCliente.Name = "gbZonaCliente";
            this.gbZonaCliente.Size = new System.Drawing.Size(728, 102);
            this.gbZonaCliente.TabIndex = 26;
            this.gbZonaCliente.TabStop = false;
            // 
            // btnBuscaProveedor
            // 
            this.btnBuscaProveedor.Location = new System.Drawing.Point(624, 8);
            this.btnBuscaProveedor.Name = "btnBuscaProveedor";
            this.btnBuscaProveedor.Size = new System.Drawing.Size(95, 23);
            this.btnBuscaProveedor.TabIndex = 32;
            this.btnBuscaProveedor.Text = "Buscar Proveedor";
            this.btnBuscaProveedor.UseVisualStyleBackColor = true;
            this.btnBuscaProveedor.Click += new System.EventHandler(this.btnBuscaProveedor_Click);
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.White;
            this.txtContacto.Location = new System.Drawing.Point(60, 77);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(194, 20);
            this.txtContacto.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Contacto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(522, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fax";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Giro";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ciudad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Comuna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dirección";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(553, 55);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(166, 20);
            this.txtFax.TabIndex = 10;
            // 
            // txtFono
            // 
            this.txtFono.BackColor = System.Drawing.Color.White;
            this.txtFono.Location = new System.Drawing.Point(365, 55);
            this.txtFono.Name = "txtFono";
            this.txtFono.Size = new System.Drawing.Size(143, 20);
            this.txtFono.TabIndex = 9;
            // 
            // txtGiro
            // 
            this.txtGiro.BackColor = System.Drawing.Color.White;
            this.txtGiro.Location = new System.Drawing.Point(60, 55);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(246, 20);
            this.txtGiro.TabIndex = 8;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.Location = new System.Drawing.Point(553, 33);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(166, 20);
            this.txtCiudad.TabIndex = 7;
            // 
            // txtComuna
            // 
            this.txtComuna.BackColor = System.Drawing.Color.White;
            this.txtComuna.Location = new System.Drawing.Point(365, 33);
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(143, 20);
            this.txtComuna.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(60, 33);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(246, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Razon Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RUT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(245, 11);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(373, 20);
            this.txtRazonSocial.TabIndex = 8;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            this.txtRazonSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazonSocial_KeyDown);
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(132, 11);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(29, 20);
            this.txtDigito.TabIndex = 7;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(60, 11);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(68, 20);
            this.txtRut.TabIndex = 6;
            this.txtRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRut_KeyDown);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(596, 21);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(71, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Location = new System.Drawing.Point(758, 21);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(61, 20);
            this.txtDescuento.TabIndex = 15;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // chkCantidadFija
            // 
            this.chkCantidadFija.AutoSize = true;
            this.chkCantidadFija.Location = new System.Drawing.Point(709, 27);
            this.chkCantidadFija.Name = "chkCantidadFija";
            this.chkCantidadFija.Size = new System.Drawing.Size(15, 14);
            this.chkCantidadFija.TabIndex = 16;
            this.chkCantidadFija.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Aptusoft.Properties.Resources.construccion_de_anadir_icono_5620_32;
            this.btnAgregar.Location = new System.Drawing.Point(931, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Tag = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar Producto");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiaDetalle
            // 
            this.btnLimpiaDetalle.Image = global::Aptusoft.Properties.Resources.construccion_de_eliminar_icono_9418_32;
            this.btnLimpiaDetalle.Location = new System.Drawing.Point(931, 217);
            this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
            this.btnLimpiaDetalle.Size = new System.Drawing.Size(40, 40);
            this.btnLimpiaDetalle.TabIndex = 17;
            this.btnLimpiaDetalle.Tag = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiaDetalle, "Limpiar Grilla");
            this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaDetalle.Click += new System.EventHandler(this.btnLimpiaDetalle_Click);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(102, 29);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(96, 20);
            this.dtpVencimiento.TabIndex = 1;
            // 
            // dtpEmision
            // 
            this.dtpEmision.CustomFormat = "";
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(4, 29);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(95, 20);
            this.dtpEmision.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(102, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vencimiento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emision";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(4, 33);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(173, 20);
            this.txtNumeroDocumento.TabIndex = 2;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(4, 14);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(139, 15);
            this.lblFolio.TabIndex = 5;
            this.lblFolio.Text = "FOLIO DOCUMENTO";
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(561, 29);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(90, 20);
            this.txtOrdenCompra.TabIndex = 5;
            this.txtOrdenCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrdenCompra_KeyPress);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(561, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 23);
            this.label16.TabIndex = 7;
            this.label16.Text = "Orden de Compra";
            // 
            // gbZonaBotones
            // 
            this.gbZonaBotones.Controls.Add(this.txtTotalCobrar);
            this.gbZonaBotones.Controls.Add(this.groupBox1);
            this.gbZonaBotones.Controls.Add(this.chkExento);
            this.gbZonaBotones.Controls.Add(this.label33);
            this.gbZonaBotones.Controls.Add(this.label32);
            this.gbZonaBotones.Controls.Add(this.label3);
            this.gbZonaBotones.Controls.Add(this.label29);
            this.gbZonaBotones.Controls.Add(this.btnControlPago);
            this.gbZonaBotones.Controls.Add(this.btnImprime);
            this.gbZonaBotones.Controls.Add(this.txtOtroImpuesto);
            this.gbZonaBotones.Controls.Add(this.btnSalir);
            this.gbZonaBotones.Controls.Add(this.txtPorIva);
            this.gbZonaBotones.Controls.Add(this.txtTotalExento);
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
            this.gbZonaBotones.Location = new System.Drawing.Point(6, 512);
            this.gbZonaBotones.Name = "gbZonaBotones";
            this.gbZonaBotones.Size = new System.Drawing.Size(965, 206);
            this.gbZonaBotones.TabIndex = 28;
            this.gbZonaBotones.TabStop = false;
            this.gbZonaBotones.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTotalCobrar
            // 
            this.txtTotalCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTotalCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCobrar.Enabled = false;
            this.txtTotalCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCobrar.Location = new System.Drawing.Point(856, 176);
            this.txtTotalCobrar.Name = "txtTotalCobrar";
            this.txtTotalCobrar.Size = new System.Drawing.Size(103, 21);
            this.txtTotalCobrar.TabIndex = 41;
            this.txtTotalCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.groupBox1.Location = new System.Drawing.Point(297, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 136);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impuestos Especiales";
            // 
            // lblCodImp5
            // 
            this.lblCodImp5.Location = new System.Drawing.Point(251, 109);
            this.lblCodImp5.Name = "lblCodImp5";
            this.lblCodImp5.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp5.TabIndex = 43;
            this.lblCodImp5.Text = "Impuesto 5";
            // 
            // lblCodImp4
            // 
            this.lblCodImp4.Location = new System.Drawing.Point(251, 87);
            this.lblCodImp4.Name = "lblCodImp4";
            this.lblCodImp4.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp4.TabIndex = 42;
            this.lblCodImp4.Text = "Impuesto 4";
            // 
            // lblCodImp3
            // 
            this.lblCodImp3.Location = new System.Drawing.Point(251, 65);
            this.lblCodImp3.Name = "lblCodImp3";
            this.lblCodImp3.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp3.TabIndex = 41;
            this.lblCodImp3.Text = "Impuesto 3";
            // 
            // lblCodImp2
            // 
            this.lblCodImp2.Location = new System.Drawing.Point(251, 43);
            this.lblCodImp2.Name = "lblCodImp2";
            this.lblCodImp2.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp2.TabIndex = 40;
            this.lblCodImp2.Text = "Impuesto 2";
            // 
            // lblCodImp1
            // 
            this.lblCodImp1.Location = new System.Drawing.Point(251, 21);
            this.lblCodImp1.Name = "lblCodImp1";
            this.lblCodImp1.Size = new System.Drawing.Size(23, 13);
            this.lblCodImp1.TabIndex = 39;
            this.lblCodImp1.Text = "Impuesto 1";
            // 
            // txtTotalImp5
            // 
            this.txtTotalImp5.BackColor = System.Drawing.Color.White;
            this.txtTotalImp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImp5.Location = new System.Drawing.Point(332, 105);
            this.txtTotalImp5.Name = "txtTotalImp5";
            this.txtTotalImp5.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp5.TabIndex = 38;
            this.txtTotalImp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalImp5.TextChanged += new System.EventHandler(this.txtTotalImp5_TextChanged);
            // 
            // txtTotalImp3
            // 
            this.txtTotalImp3.BackColor = System.Drawing.Color.White;
            this.txtTotalImp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImp3.Location = new System.Drawing.Point(332, 61);
            this.txtTotalImp3.Name = "txtTotalImp3";
            this.txtTotalImp3.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp3.TabIndex = 10;
            this.txtTotalImp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalImp3.TextChanged += new System.EventHandler(this.txtTotalImp3_TextChanged);
            // 
            // txtTotalImp4
            // 
            this.txtTotalImp4.BackColor = System.Drawing.Color.White;
            this.txtTotalImp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImp4.Location = new System.Drawing.Point(332, 83);
            this.txtTotalImp4.Name = "txtTotalImp4";
            this.txtTotalImp4.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp4.TabIndex = 36;
            this.txtTotalImp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalImp4.TextChanged += new System.EventHandler(this.txtTotalImp4_TextChanged);
            // 
            // txtPorImp5
            // 
            this.txtPorImp5.BackColor = System.Drawing.Color.White;
            this.txtPorImp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorImp5.Location = new System.Drawing.Point(281, 105);
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
            this.txtPorImp3.Location = new System.Drawing.Point(281, 61);
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
            this.txtTotalImp2.Location = new System.Drawing.Point(332, 39);
            this.txtTotalImp2.Name = "txtTotalImp2";
            this.txtTotalImp2.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp2.TabIndex = 8;
            this.txtTotalImp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalImp2.TextChanged += new System.EventHandler(this.txtTotalImp2_TextChanged);
            // 
            // txtPorImp4
            // 
            this.txtPorImp4.BackColor = System.Drawing.Color.White;
            this.txtPorImp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorImp4.Location = new System.Drawing.Point(281, 83);
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
            this.txtPorImp2.Location = new System.Drawing.Point(281, 39);
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
            this.txtTotalImp1.Location = new System.Drawing.Point(332, 17);
            this.txtTotalImp1.Name = "txtTotalImp1";
            this.txtTotalImp1.Size = new System.Drawing.Size(83, 21);
            this.txtTotalImp1.TabIndex = 6;
            this.txtTotalImp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalImp1.TextChanged += new System.EventHandler(this.txtTotalImp1_TextChanged);
            // 
            // txtPorImp1
            // 
            this.txtPorImp1.BackColor = System.Drawing.Color.White;
            this.txtPorImp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorImp1.ForeColor = System.Drawing.Color.Black;
            this.txtPorImp1.Location = new System.Drawing.Point(281, 17);
            this.txtPorImp1.Name = "txtPorImp1";
            this.txtPorImp1.ReadOnly = true;
            this.txtPorImp1.Size = new System.Drawing.Size(47, 21);
            this.txtPorImp1.TabIndex = 5;
            this.txtPorImp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblImp5
            // 
            this.lblImp5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImp5.Location = new System.Drawing.Point(6, 109);
            this.lblImp5.Name = "lblImp5";
            this.lblImp5.Size = new System.Drawing.Size(238, 13);
            this.lblImp5.TabIndex = 4;
            this.lblImp5.Text = "Impuesto 5";
            this.lblImp5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblImp4
            // 
            this.lblImp4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImp4.Location = new System.Drawing.Point(6, 87);
            this.lblImp4.Name = "lblImp4";
            this.lblImp4.Size = new System.Drawing.Size(238, 13);
            this.lblImp4.TabIndex = 3;
            this.lblImp4.Text = "Impuesto 4";
            this.lblImp4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblImp3
            // 
            this.lblImp3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImp3.Location = new System.Drawing.Point(6, 65);
            this.lblImp3.Name = "lblImp3";
            this.lblImp3.Size = new System.Drawing.Size(238, 13);
            this.lblImp3.TabIndex = 2;
            this.lblImp3.Text = "Impuesto 3";
            this.lblImp3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblImp2
            // 
            this.lblImp2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImp2.Location = new System.Drawing.Point(6, 43);
            this.lblImp2.Name = "lblImp2";
            this.lblImp2.Size = new System.Drawing.Size(238, 13);
            this.lblImp2.TabIndex = 1;
            this.lblImp2.Text = "Impuesto 2";
            this.lblImp2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblImp1
            // 
            this.lblImp1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImp1.Location = new System.Drawing.Point(6, 21);
            this.lblImp1.Name = "lblImp1";
            this.lblImp1.Size = new System.Drawing.Size(238, 13);
            this.lblImp1.TabIndex = 0;
            this.lblImp1.Text = "Impuesto 1";
            this.lblImp1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkExento
            // 
            this.chkExento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.chkExento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkExento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExento.ForeColor = System.Drawing.Color.Black;
            this.chkExento.Location = new System.Drawing.Point(547, 14);
            this.chkExento.Name = "chkExento";
            this.chkExento.Size = new System.Drawing.Size(227, 20);
            this.chkExento.TabIndex = 32;
            this.chkExento.Text = "Documento de Compra Exento";
            this.chkExento.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkExento.UseVisualStyleBackColor = false;
            this.chkExento.CheckedChanged += new System.EventHandler(this.chkExento_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(748, 132);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(101, 13);
            this.label33.TabIndex = 39;
            this.label33.Text = "TOTAL EXENTO";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(743, 180);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(109, 13);
            this.label32.TabIndex = 40;
            this.label32.Text = "TOTAL GENERAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "INGRESO DE COMPRAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(724, 107);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(126, 13);
            this.label29.TabIndex = 29;
            this.label29.Text = "OTROS IMPUESTOS";
            // 
            // btnControlPago
            // 
            this.btnControlPago.Image = global::Aptusoft.Properties.Resources.dinero_48;
            this.btnControlPago.Location = new System.Drawing.Point(7, 130);
            this.btnControlPago.Name = "btnControlPago";
            this.btnControlPago.Size = new System.Drawing.Size(70, 70);
            this.btnControlPago.TabIndex = 27;
            this.btnControlPago.Text = "Pagar";
            this.btnControlPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnControlPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnControlPago.UseVisualStyleBackColor = true;
            this.btnControlPago.Click += new System.EventHandler(this.btnControlPago_Click);
            // 
            // btnImprime
            // 
            this.btnImprime.Image = global::Aptusoft.Properties.Resources.imprimir_48;
            this.btnImprime.Location = new System.Drawing.Point(220, 56);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(70, 70);
            this.btnImprime.TabIndex = 26;
            this.btnImprime.Text = "Imprimir";
            this.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // txtOtroImpuesto
            // 
            this.txtOtroImpuesto.BackColor = System.Drawing.Color.White;
            this.txtOtroImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtroImpuesto.Location = new System.Drawing.Point(856, 104);
            this.txtOtroImpuesto.Name = "txtOtroImpuesto";
            this.txtOtroImpuesto.Size = new System.Drawing.Size(103, 20);
            this.txtOtroImpuesto.TabIndex = 30;
            this.txtOtroImpuesto.TabStop = false;
            this.txtOtroImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtroImpuesto.TextChanged += new System.EventHandler(this.txtOtroImpuesto_TextChanged);
            this.txtOtroImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtroImpuesto_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.Location = new System.Drawing.Point(220, 130);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 70);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtPorIva
            // 
            this.txtPorIva.BackColor = System.Drawing.Color.White;
            this.txtPorIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorIva.Enabled = false;
            this.txtPorIva.Location = new System.Drawing.Point(856, 81);
            this.txtPorIva.Name = "txtPorIva";
            this.txtPorIva.Size = new System.Drawing.Size(24, 20);
            this.txtPorIva.TabIndex = 11;
            this.txtPorIva.TabStop = false;
            this.txtPorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalExento
            // 
            this.txtTotalExento.BackColor = System.Drawing.Color.White;
            this.txtTotalExento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalExento.Enabled = false;
            this.txtTotalExento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExento.Location = new System.Drawing.Point(856, 128);
            this.txtTotalExento.Name = "txtTotalExento";
            this.txtTotalExento.Size = new System.Drawing.Size(103, 21);
            this.txtTotalExento.TabIndex = 38;
            this.txtTotalExento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Aptusoft.Properties.Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
            this.btnLimpiar.Location = new System.Drawing.Point(78, 130);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Aptusoft.Properties.Resources.disquetes_excepto_icono_7120_48;
            this.btnGuardar.Location = new System.Drawing.Point(7, 56);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guarda";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Aptusoft.Properties.Resources.mark_correo_basura_icono_3897_48;
            this.btnEliminar.Location = new System.Drawing.Point(149, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 70);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Elimina";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Aptusoft.Properties.Resources.modificar_48;
            this.btnModificar.Location = new System.Drawing.Point(78, 56);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 70);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modifica";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(856, 14);
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
            this.txtTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeneral.Location = new System.Drawing.Point(856, 152);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.Size = new System.Drawing.Size(103, 21);
            this.txtTotalGeneral.TabIndex = 9;
            this.txtTotalGeneral.TabStop = false;
            this.txtTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.Color.White;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(882, 81);
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
            this.txtNeto.Location = new System.Drawing.Point(856, 58);
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
            this.txtTotalDescuento.Location = new System.Drawing.Point(882, 36);
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
            this.txtPorcDescuentoTotal.Location = new System.Drawing.Point(856, 36);
            this.txtPorcDescuentoTotal.Name = "txtPorcDescuentoTotal";
            this.txtPorcDescuentoTotal.ReadOnly = true;
            this.txtPorcDescuentoTotal.Size = new System.Drawing.Size(24, 20);
            this.txtPorcDescuentoTotal.TabIndex = 5;
            this.txtPorcDescuentoTotal.TabStop = false;
            this.txtPorcDescuentoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoTotal.TextChanged += new System.EventHandler(this.txtPorcDescuentoTotal_TextChanged);
            this.txtPorcDescuentoTotal.DoubleClick += new System.EventHandler(this.txtPorcDescuentoTotal_DoubleClick);
            this.txtPorcDescuentoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcDescuentoTotal_KeyPress);
            this.txtPorcDescuentoTotal.Leave += new System.EventHandler(this.txtPorcDescuentoTotal_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(805, 156);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "TOTAL";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(817, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "I.V.A";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(811, 62);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "NETO";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(769, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "DESCUENTO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(780, 18);
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
            this.dgvDatosVenta.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosVenta.Location = new System.Drawing.Point(12, 229);
            this.dgvDatosVenta.MultiSelect = false;
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.ReadOnly = true;
            this.dgvDatosVenta.RowHeadersVisible = false;
            this.dgvDatosVenta.RowHeadersWidth = 50;
            this.dgvDatosVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosVenta.Size = new System.Drawing.Size(915, 284);
            this.dgvDatosVenta.TabIndex = 3;
            this.dgvDatosVenta.TabStop = false;
            this.dgvDatosVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
            this.dgvDatosVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
            this.dgvDatosVenta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDatosVenta_DataError);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(5, 61);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(174, 23);
            this.label27.TabIndex = 21;
            this.label27.Text = "TIPO DOCUMENTO";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(4, 75);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(175, 21);
            this.cmbTipoDocumento.TabIndex = 3;
            this.cmbTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedValueChanged);
            // 
            // gbZonaOtros
            // 
            this.gbZonaOtros.Controls.Add(this.dtpVencimiento);
            this.gbZonaOtros.Controls.Add(this.cmbPeriodo);
            this.gbZonaOtros.Controls.Add(this.dtpEmision);
            this.gbZonaOtros.Controls.Add(this.label34);
            this.gbZonaOtros.Controls.Add(this.label2);
            this.gbZonaOtros.Controls.Add(this.txtFolioFacturaNC);
            this.gbZonaOtros.Controls.Add(this.label1);
            this.gbZonaOtros.Controls.Add(this.lblFolioFactura);
            this.gbZonaOtros.Controls.Add(this.txtOrdenCompra);
            this.gbZonaOtros.Controls.Add(this.cmbMedioPago);
            this.gbZonaOtros.Controls.Add(this.cmbCentroCosto);
            this.gbZonaOtros.Controls.Add(this.label30);
            this.gbZonaOtros.Controls.Add(this.label18);
            this.gbZonaOtros.Controls.Add(this.label16);
            this.gbZonaOtros.Location = new System.Drawing.Point(197, 18);
            this.gbZonaOtros.Name = "gbZonaOtros";
            this.gbZonaOtros.Size = new System.Drawing.Size(728, 58);
            this.gbZonaOtros.TabIndex = 25;
            this.gbZonaOtros.TabStop = false;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(438, 29);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(119, 21);
            this.cmbPeriodo.TabIndex = 37;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(438, 14);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(119, 23);
            this.label34.TabIndex = 38;
            this.label34.Text = "Periodo Contable";
            // 
            // txtFolioFacturaNC
            // 
            this.txtFolioFacturaNC.Location = new System.Drawing.Point(654, 29);
            this.txtFolioFacturaNC.Name = "txtFolioFacturaNC";
            this.txtFolioFacturaNC.Size = new System.Drawing.Size(68, 20);
            this.txtFolioFacturaNC.TabIndex = 35;
            this.txtFolioFacturaNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioFacturaNC_KeyPress);
            // 
            // lblFolioFactura
            // 
            this.lblFolioFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.lblFolioFactura.ForeColor = System.Drawing.Color.Black;
            this.lblFolioFactura.Location = new System.Drawing.Point(654, 14);
            this.lblFolioFactura.Name = "lblFolioFactura";
            this.lblFolioFactura.Size = new System.Drawing.Size(68, 15);
            this.lblFolioFactura.TabIndex = 36;
            this.lblFolioFactura.Text = "N° Factura";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedioPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(203, 29);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(122, 21);
            this.cmbMedioPago.TabIndex = 2;
            this.cmbMedioPago.Enter += new System.EventHandler(this.cmbMedioPago_Enter);
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCentroCosto.FormattingEnabled = true;
            this.cmbCentroCosto.Location = new System.Drawing.Point(329, 29);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Size = new System.Drawing.Size(104, 21);
            this.cmbCentroCosto.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(329, 14);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 23);
            this.label30.TabIndex = 34;
            this.label30.Text = "Centro de Costo";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(203, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Medio de Pago";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label28.Location = new System.Drawing.Point(5, 4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 15);
            this.label28.TabIndex = 26;
            this.label28.Text = "Bodega Destino";
            // 
            // cmbBodega
            // 
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBodega.Font = new System.Drawing.Font("Arial", 8.25F);
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(4, 20);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(104, 22);
            this.cmbBodega.TabIndex = 8;
            this.cmbBodega.Enter += new System.EventHandler(this.cmbBodega_Enter);
            // 
            // panelZonaDetalle
            // 
            this.panelZonaDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panelZonaDetalle.Controls.Add(this.txtPorcDescuentoLinea);
            this.panelZonaDetalle.Controls.Add(this.txtDescuento);
            this.panelZonaDetalle.Controls.Add(this.txtPrecioIva);
            this.panelZonaDetalle.Controls.Add(this.txtCodigo);
            this.panelZonaDetalle.Controls.Add(this.txtCantidad);
            this.panelZonaDetalle.Controls.Add(this.txtDescripcion);
            this.panelZonaDetalle.Controls.Add(this.txtTotalLinea);
            this.panelZonaDetalle.Controls.Add(this.txtPrecio);
            this.panelZonaDetalle.Controls.Add(this.cmbBodega);
            this.panelZonaDetalle.Controls.Add(this.label21);
            this.panelZonaDetalle.Controls.Add(this.btnLimpiaLineaDetalle);
            this.panelZonaDetalle.Controls.Add(this.label31);
            this.panelZonaDetalle.Controls.Add(this.chkCantidadFija);
            this.panelZonaDetalle.Controls.Add(this.label20);
            this.panelZonaDetalle.Controls.Add(this.label14);
            this.panelZonaDetalle.Controls.Add(this.label28);
            this.panelZonaDetalle.Controls.Add(this.label13);
            this.panelZonaDetalle.Controls.Add(this.label15);
            this.panelZonaDetalle.Controls.Add(this.label17);
            this.panelZonaDetalle.Controls.Add(this.label19);
            this.panelZonaDetalle.Location = new System.Drawing.Point(12, 176);
            this.panelZonaDetalle.Name = "panelZonaDetalle";
            this.panelZonaDetalle.Size = new System.Drawing.Size(914, 49);
            this.panelZonaDetalle.TabIndex = 27;
            // 
            // txtPorcDescuentoLinea
            // 
            this.txtPorcDescuentoLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcDescuentoLinea.Location = new System.Drawing.Point(725, 21);
            this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
            this.txtPorcDescuentoLinea.Size = new System.Drawing.Size(31, 20);
            this.txtPorcDescuentoLinea.TabIndex = 14;
            this.txtPorcDescuentoLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoLinea.TextChanged += new System.EventHandler(this.porcentajeDescuento_TextChanged);
            this.txtPorcDescuentoLinea.Enter += new System.EventHandler(this.txtPorcDescuentoLinea_Enter);
            this.txtPorcDescuentoLinea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPorcDescuentoLinea_KeyDown);
            this.txtPorcDescuentoLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
            // 
            // txtPrecioIva
            // 
            this.txtPrecioIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioIva.Location = new System.Drawing.Point(524, 21);
            this.txtPrecioIva.Name = "txtPrecioIva";
            this.txtPrecioIva.Size = new System.Drawing.Size(71, 20);
            this.txtPrecioIva.TabIndex = 12;
            this.txtPrecioIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioIva.TextChanged += new System.EventHandler(this.txtPrecioIva_TextChanged);
            this.txtPrecioIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioIva_KeyPress);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(524, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 23);
            this.label21.TabIndex = 36;
            this.label21.Text = "$ Con IVA";
            // 
            // btnLimpiaLineaDetalle
            // 
            this.btnLimpiaLineaDetalle.Location = new System.Drawing.Point(893, 5);
            this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
            this.btnLimpiaLineaDetalle.Size = new System.Drawing.Size(16, 38);
            this.btnLimpiaLineaDetalle.TabIndex = 33;
            this.btnLimpiaLineaDetalle.Text = "..";
            this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaLineaDetalle.Click += new System.EventHandler(this.btnLimpiaLineaDetalle_Click);
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(729, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 23);
            this.label31.TabIndex = 29;
            this.label31.Text = "%";
            // 
            // txtTipoDescuento
            // 
            this.txtTipoDescuento.Location = new System.Drawing.Point(1023, 473);
            this.txtTipoDescuento.Name = "txtTipoDescuento";
            this.txtTipoDescuento.Size = new System.Drawing.Size(38, 20);
            this.txtTipoDescuento.TabIndex = 35;
            this.txtTipoDescuento.Text = "0";
            this.txtTipoDescuento.Visible = false;
            // 
            // txtSubTotalLinea
            // 
            this.txtSubTotalLinea.Location = new System.Drawing.Point(971, 473);
            this.txtSubTotalLinea.Name = "txtSubTotalLinea";
            this.txtSubTotalLinea.Size = new System.Drawing.Size(43, 20);
            this.txtSubTotalLinea.TabIndex = 34;
            this.txtSubTotalLinea.Visible = false;
            // 
            // btnModificaLinea
            // 
            this.btnModificaLinea.Image = global::Aptusoft.Properties.Resources.modificalista_32;
            this.btnModificaLinea.Location = new System.Drawing.Point(931, 257);
            this.btnModificaLinea.Name = "btnModificaLinea";
            this.btnModificaLinea.Size = new System.Drawing.Size(40, 40);
            this.btnModificaLinea.TabIndex = 33;
            this.btnModificaLinea.Tag = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificaLinea, "Modificar Producto");
            this.btnModificaLinea.UseVisualStyleBackColor = true;
            this.btnModificaLinea.Click += new System.EventHandler(this.btnModificaLinea_Click);
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(971, 447);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(71, 20);
            this.txtLinea.TabIndex = 32;
            this.txtLinea.Text = "NumeroLinea";
            this.txtLinea.Visible = false;
            // 
            // gbZonaDocumento
            // 
            this.gbZonaDocumento.Controls.Add(this.cmbTipoDocumento);
            this.gbZonaDocumento.Controls.Add(this.lblFolio);
            this.gbZonaDocumento.Controls.Add(this.txtNumeroDocumento);
            this.gbZonaDocumento.Controls.Add(this.label27);
            this.gbZonaDocumento.Location = new System.Drawing.Point(12, 18);
            this.gbZonaDocumento.Name = "gbZonaDocumento";
            this.gbZonaDocumento.Size = new System.Drawing.Size(183, 106);
            this.gbZonaDocumento.TabIndex = 34;
            this.gbZonaDocumento.TabStop = false;
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.Location = new System.Drawing.Point(23, 129);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Size = new System.Drawing.Size(157, 39);
            this.btnBuscarDocumento.TabIndex = 29;
            this.btnBuscarDocumento.Text = "Buscar Documento";
            this.btnBuscarDocumento.UseVisualStyleBackColor = true;
            this.btnBuscarDocumento.Click += new System.EventHandler(this.btnBuscarDocumento_Click);
            // 
            // dgvBuscaProveedor
            // 
            this.dgvBuscaProveedor.AllowUserToAddRows = false;
            this.dgvBuscaProveedor.AllowUserToDeleteRows = false;
            this.dgvBuscaProveedor.AllowUserToResizeColumns = false;
            this.dgvBuscaProveedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            this.dgvBuscaProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBuscaProveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgvBuscaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscaProveedor.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuscaProveedor.Location = new System.Drawing.Point(5, 4);
            this.dgvBuscaProveedor.Name = "dgvBuscaProveedor";
            this.dgvBuscaProveedor.ReadOnly = true;
            this.dgvBuscaProveedor.RowHeadersVisible = false;
            this.dgvBuscaProveedor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscaProveedor.Size = new System.Drawing.Size(767, 211);
            this.dgvBuscaProveedor.TabIndex = 0;
            this.dgvBuscaProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscaProveedor_CellDoubleClick);
            this.dgvBuscaProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBuscaProveedor_KeyDown);
            // 
            // pnlBuscaProveedorDes
            // 
            this.pnlBuscaProveedorDes.BackColor = System.Drawing.Color.Transparent;
            this.pnlBuscaProveedorDes.Controls.Add(this.dgvBuscaProveedor);
            this.pnlBuscaProveedorDes.Location = new System.Drawing.Point(439, 104);
            this.pnlBuscaProveedorDes.Name = "pnlBuscaProveedorDes";
            this.pnlBuscaProveedorDes.Size = new System.Drawing.Size(794, 220);
            this.pnlBuscaProveedorDes.TabIndex = 32;
            // 
            // frmIngresoCompra
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1103, 740);
            this.Controls.Add(this.pnlBuscaProveedorDes);
            this.Controls.Add(this.gbZonaBotones);
            this.Controls.Add(this.btnBuscarDocumento);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTipoDescuento);
            this.Controls.Add(this.btnModificaLinea);
            this.Controls.Add(this.gbZonaDocumento);
            this.Controls.Add(this.txtSubTotalLinea);
            this.Controls.Add(this.panelZonaDetalle);
            this.Controls.Add(this.gbZonaOtros);
            this.Controls.Add(this.gbZonaCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.btnLimpiaDetalle);
            this.Controls.Add(this.dgvDatosVenta);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmIngresoCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingreso de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFactura_FormClosing);
            this.Load += new System.EventHandler(this.frmIngresoCompra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFactura_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbZonaCliente.ResumeLayout(false);
            this.gbZonaCliente.PerformLayout();
            this.gbZonaBotones.ResumeLayout(false);
            this.gbZonaBotones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            this.gbZonaOtros.ResumeLayout(false);
            this.gbZonaOtros.PerformLayout();
            this.panelZonaDetalle.ResumeLayout(false);
            this.panelZonaDetalle.PerformLayout();
            this.gbZonaDocumento.ResumeLayout(false);
            this.gbZonaDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaProveedor)).EndInit();
            this.pnlBuscaProveedorDes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("COMPRAS"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._descuento = Convert.ToBoolean(usuarioVo.Descuento);
          this._cambioPrecio = Convert.ToBoolean(usuarioVo.CambioPrecio);
          this._bodega = usuarioVo.IdBodega;
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

    private void cargaCentroCosto()
    {
      this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
      this.cmbCentroCosto.ValueMember = "idCentroCosto";
      this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
      this.cmbCentroCosto.SelectedValue = (object) 0;
    }

    private void cargaPeriodos()
    {
      List<PeriodoVO> list = new Periodo().listaPeriodosCombo();
      this.cmbPeriodo.DataSource = (object) list;
      this.cmbPeriodo.ValueMember = "idPeriodo";
      this.cmbPeriodo.DisplayMember = "nombre";
      for (int index = 0; index < list.Count; ++index)
      {
        if (list[index].EnCurso)
          this.cmbPeriodo.SelectedValue = (object) list[index].IdPeriodo;
      }
    }

    private void cargaTipoDocumentos()
    {
      this.cmbTipoDocumento.Enabled = true;
      this.cmbTipoDocumento.DataSource = (object) new CargaMaestros().cargaTipoDocumentos();
      this.cmbTipoDocumento.ValueMember = "codigo";
      this.cmbTipoDocumento.DisplayMember = "descripcion";
      this.cmbTipoDocumento.SelectedValue = (object) 0;
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) new MedioPago().listaMediosPago();
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

    public void cargaOpcionesDocumentosInicio()
    {
      this.odVO = new OpcionesGenerales().rescataOpcionesDocumentosPorNombre("COMPRA");
      this.cargaOpcionesDocumentos();
    }

    public void cargaOpcionesDocumentos()
    {
      this.decimalesValoresVenta = this.odVO.DecimalesValorVenta.ToString();
      this._permisoMedioPago = this.odVO.MedioPago;
      this._permisoPemitirMedioPago = this.odVO.PermitirMedioPago == "1";
      this._opcionBusquedaRazonSocial = this.odVO.BusquedaRazonSocial;
    }

    private void cargaImpuestos()
    {
      foreach (ImpuestoVO impuestoVo in new Impuestos().listaImpuestos())
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

    public void iniciaCompra()
    {
      try
      {
        this.cargaMediosPago();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar Medios de Pago: " + ex.Message);
      }
      try
      {
        this.cargaTipoDocumentos();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar Vendedores: " + ex.Message);
      }
      try
      {
        this.cargaCentroCosto();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar centro costo: " + ex.Message);
      }
      try
      {
        this.cargaPeriodos();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar periodos: " + ex.Message);
      }
      this.codigoProveedor = 0;
      this.cargaBodega();
      try
      {
        this.txtPorIva.Text = new Calculos()._iva.ToString("N0");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Porcentaje del Iva: " + ex.Message);
      }
      try
      {
        this.cargaOpcionesDocumentosInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Opciones de Documento: " + ex.Message);
        this.Close();
      }
      try
      {
        this.cargaImpuestos();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Opciones Impuestos: " + ex.Message);
        this.Close();
      }
      this.cargaOpcionesDocumentos();
      this.dtpEmision.Value = DateTime.Today;
      this.dtpVencimiento.Value = DateTime.Today;
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
      this.chkExento.Checked = false;
      this.txtSubTotal.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtNeto.Clear();
      this.txtOtroImpuesto.Clear();
      this.txtIva.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTotalExento.Clear();
      this.txtTotalCobrar.Clear();
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
      {
        this.txtPrecio.Enabled = true;
        this.txtPrecioIva.Enabled = true;
      }
      else
      {
        this.txtPrecio.Enabled = false;
        this.txtPrecioIva.Enabled = false;
      }
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.Columns.Clear();
      this.creaColumnasDetalle();
      this.pnlBuscaProveedorDes.Visible = false;
      this.creaColumnasBuscaProveedores();
      this.idCompra = 0;
      frmIngresoCompra.lista.Clear();
      this._listaLote.Clear();
      this._listaLoteAntigua.Clear();
      this.limpiaEntradaDetalle();
      this.gbZonaDocumento.TabIndex = 0;
      this.gbZonaOtros.TabIndex = 1;
      this.gbZonaCliente.TabIndex = 2;
      this.panelZonaDetalle.TabIndex = 3;
      this.gbZonaBotones.TabIndex = 4;
      this.txtNumeroDocumento.Clear();
      this.txtNumeroDocumento.Focus();
      this.lblFolioFactura.Visible = false;
      this.txtFolioFacturaNC.Visible = false;
      this.txtFolioFacturaNC.Clear();
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
      this.dgvDatosVenta.Columns[2].Width = 290;
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
      DataGridViewButtonColumn viewButtonColumn1 = new DataGridViewButtonColumn();
      viewButtonColumn1.Name = "Eliminar";
      viewButtonColumn1.HeaderText = "Eliminar";
      viewButtonColumn1.UseColumnTextForButtonValue = true;
      viewButtonColumn1.Text = "X";
      viewButtonColumn1.Width = 50;
      viewButtonColumn1.DisplayIndex = 14;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn1);
      this.dgvDatosVenta.Columns.Add("Exento", "Exento");
      this.dgvDatosVenta.Columns[15].DataPropertyName = "Exento";
      this.dgvDatosVenta.Columns[15].Width = 90;
      this.dgvDatosVenta.Columns[15].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[15].Visible = false;
      DataGridViewButtonColumn viewButtonColumn2 = new DataGridViewButtonColumn();
      viewButtonColumn2.Name = "Lote";
      viewButtonColumn2.HeaderText = "Lote";
      viewButtonColumn2.UseColumnTextForButtonValue = true;
      viewButtonColumn2.Text = "::";
      viewButtonColumn2.Width = 50;
      viewButtonColumn2.DisplayIndex = 16;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn2);
    }

    private void calculaTotalLinea()
    {
      Calculos calculos = new Calculos();
      int num1 = Convert.ToInt32(this.txtTipoDescuento.Text);
      Decimal num2 = new Decimal(0);
      Decimal num3 = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text.Trim()) : new Decimal(0);
     //se cambia el calculo del sistema de neto por cantidad a (valor + iva) * cantidad
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
        this.txtTotalLinea.Text = calculos.totalLinea(subTotal, descuento).ToString("N" + this.decimalesValoresVenta);
      }
      else
      {
        int num4 = (int) MessageBox.Show("El Descuento debe ser Menor al Total!!");
        this.txtDescuento.Clear();
        this.txtPorcDescuentoLinea.Clear();
      }
    }

    public void cantidad()
    {
      this.txtCantidad.Text = "1";
    }

    public void llamaProductoCodigo(string cod, int bodega)
    {
      this.cmbBodega.SelectedValue = (object) bodega.ToString();
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
      if (productoVo.Codigo != null)
      {
        this.txtCodigo.Text = productoVo.Codigo;
        this.txtDescripcion.Text = productoVo.Descripcion;
        this.txtPrecioIva.Text = productoVo.ValorCompra.ToString("N" + this.decimalesValoresVenta);
        this.txtCantidad.Focus();
        this.esExento = productoVo.Exento;
        this.idImpuesto = productoVo.IdImpuesto;
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe el Codigo Ingresado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtCodigo.Clear();
        this.txtCodigo.Focus();
      }
    }

    public void agregaLineaGrilla()
    {
      
      this.txtTotalDescuento.ReadOnly = true;
      this.txtPorcDescuentoTotal.ReadOnly = true;
      frmIngresoCompra.lista.Add(new DatosVentaVO()
      {
        Codigo = this.txtCodigo.Text.Trim().ToUpper(),
        Descripcion = this.txtDescripcion.Text.Trim().ToUpper(),
        //se cambia el sistema de neto * cantidad a (neto + iva) * cantidad
       // ValorVenta = this.txtPrecioIva.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecioIva.Text) : new Decimal(0)
        ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0),
        Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0),
        Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0),
        PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0),
        TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0),
        SubTotalLinea = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text) : new Decimal(0),
        TipoDescuento = Convert.ToInt32(this.txtTipoDescuento.Text),
        Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()),
        Exento = this.esExento
      });
      this.limpiaEntradaDetalle();
      this.calculaTotales();
      this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
      this.esExento = false;
    }

    private void calculaTotales()
    {
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) frmIngresoCompra.lista;
      for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
        frmIngresoCompra.lista[index].Linea = index + 1;
      Calculos calculos = new Calculos();
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      Decimal total = calculos.totalGeneralCompra(frmIngresoCompra.lista);
      this.txtTotalGeneral.Text = total.ToString("N0");
      this.txtTotalDescuento.Text = calculos.totalDescuento(frmIngresoCompra.lista).ToString("N0");
      Decimal neto = calculos.totalNeto(total);//total linea
      TextBox textBox1 = this.txtSubTotal;
      Decimal num6 = calculos.totalSubTotalCompra(frmIngresoCompra.lista);
      string str1 = num6.ToString("N0");
      textBox1.Text = str1;
      this.txtNeto.Text = neto.ToString("N0");
      TextBox textBox2 = this.txtIva;
      num6 = calculos.totalIva(neto);//precio neto
      string str2 = num6.ToString("N0");
      textBox2.Text = str2;
      Decimal num7 = calculos.totalGeneralCompraExento(frmIngresoCompra.lista);
      this.txtTotalExento.Text = num7.ToString("N0");
      this.txtTotalCobrar.Text = (total + num7).ToString("N0");
      //this.txtTotalCobrar.Text = (total).ToString("N0");
      //this.txtTotalCobrar.Text = "";
      //this.txtTotalCobrar.Text = this.txtNeto.Text;
      //this.txtTotalGeneral.Text = this.txtNeto.Text;
    }

    private void limpiaEntradaDetalle()
    {
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Enabled = true;
      this.btnLimpiaDetalle.Enabled = true;
      this.idImpuesto = 0;
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtPrecio.Clear();
      this.txtPrecioIva.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      if (!this.chkCantidadFija.Checked)
        this.txtCantidad.Clear();
      this.txtDescuento.Clear();
      this.txtPorcDescuentoLinea.Clear();
      this.txtTotalLinea.Clear();
      this.txtCodigo.Focus();
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
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

    private void buscaProveedor()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new Proveedor().buscaRutProveedor(this.txtRut.Text.Trim());
      if (arrayList2.Count == 0)
      {
        if (MessageBox.Show("No Existe Proveedor Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
          new frmProveedor(this.txtRut.Text.Trim(), this.txtDigito.Text.Trim()).Show();
        else
          this.iniciaCompra();
      }
      else
      {
        if (arrayList2.Count != 1)
          return;
        foreach (ClienteVO clienteVo in arrayList2)
          this.buscaProveedorCodigo(clienteVo.Codigo);
        this.txtCodigo.Focus();
      }
    }

    public void buscaProveedorCodigo(int cod)
    {
      ClienteVO clienteVo = new Proveedor().buscaCodigoProveedor(cod);
      this.codigoProveedor = clienteVo.Codigo;
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
      this.txtCodigo.Focus();
    }

    private void btnBuscaProveedor_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaProveedor(ref this.intance, "compra").ShowDialog();
    }

    private void txtRazonSocial_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRazonSocial.Text.Trim().Length > 0 && this.txtRut.Text.Trim().Length == 0)
      {
        this.pnlBuscaProveedorDes.Visible = true;
        List<ClienteVO> list = new Proveedor().buscaProveedorDato(Convert.ToInt32(this._opcionBusquedaRazonSocial), this.txtRazonSocial.Text.Trim());
        if (list.Count <= 0)
          return;
        this.dgvBuscaProveedor.DataSource = (object) list;
      }
      else
        this.pnlBuscaProveedorDes.Visible = false;
    }

    private void creaColumnasBuscaProveedores()
    {
      this.dgvBuscaProveedor.Columns.Clear();
      this.dgvBuscaProveedor.AutoGenerateColumns = false;
      this.dgvBuscaProveedor.Columns.Add("Codigo", "Cod.");
      this.dgvBuscaProveedor.Columns[0].DataPropertyName = "Codigo";
      this.dgvBuscaProveedor.Columns[0].Width = 35;
      this.dgvBuscaProveedor.Columns.Add("Rut", "Rut");
      this.dgvBuscaProveedor.Columns[1].DataPropertyName = "Rut";
      this.dgvBuscaProveedor.Columns[1].Width = 80;
      this.dgvBuscaProveedor.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProveedor.Columns.Add("Digito", "");
      this.dgvBuscaProveedor.Columns[2].DataPropertyName = "Digito";
      this.dgvBuscaProveedor.Columns[2].Width = 20;
      this.dgvBuscaProveedor.Columns.Add("RazonSocial", "Razon Social");
      this.dgvBuscaProveedor.Columns[3].DataPropertyName = "RazonSocial";
      this.dgvBuscaProveedor.Columns[3].Width = 270;
      this.dgvBuscaProveedor.Columns.Add("NomFantasia", "N. Fantasia");
      this.dgvBuscaProveedor.Columns[4].DataPropertyName = "NomFantasia";
      this.dgvBuscaProveedor.Columns[4].Width = 230;
      this.dgvBuscaProveedor.Columns.Add("Direccion", "Direccion");
      this.dgvBuscaProveedor.Columns[5].DataPropertyName = "Direccion";
      this.dgvBuscaProveedor.Columns[5].Width = 230;
    }

    private void dgvBuscaProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.buscaProveedorCodigo(Convert.ToInt32(this.dgvBuscaProveedor.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaProveedorDes.Visible = false;
    }

    private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
    {
      if (!this.pnlBuscaProveedorDes.Visible || e.KeyCode != Keys.Down)
        return;
      this.dgvBuscaProveedor.Focus();
    }

    private void dgvBuscaProveedor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaProveedorCodigo(Convert.ToInt32(this.dgvBuscaProveedor.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaProveedorDes.Visible = false;
    }

    private void txtRut_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtDigito.Focus();
    }

    private void frmFactura_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modCompra = 0;
    }

    private void guardaCompra()
    {
      bool flag = false;
      if (!this.validaCampos())
        return;
      Venta veOB = new Venta();
      DateTime dateTime1 =DateTime.Now;
      
      string FechaEmision = dtpEmision.Value.ToString("yyyy-MM-dd HH:mm:ss");
      string FechaVencimiento = dtpVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss");

      veOB.FechaEmision = Convert.ToDateTime(FechaEmision);
      veOB.FechaVencimiento = Convert.ToDateTime(FechaVencimiento);
      veOB.FechaModificacion = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
      veOB.IdCliente = this.codigoProveedor;
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
      veOB.FolioFacturaNC = this.txtFolioFacturaNC.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtFolioFacturaNC.Text.Trim()) : 0;
      if (this.cmbMedioPago.SelectedValue.ToString() != "0")
      {
        veOB.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        veOB.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
      }
      if (this.cmbTipoDocumento.SelectedValue.ToString() != "0")
      {
        veOB.IdTipoDocumentoCompra = Convert.ToInt32(this.cmbTipoDocumento.SelectedValue.ToString());
        veOB.TipoDocumentoCompra = this.cmbTipoDocumento.Text.ToString().ToUpper();
        //flag = true;
      }
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
      if (this.cmbPeriodo.SelectedValue != null)
      {
        veOB.IdPeriodo = Convert.ToInt32(this.cmbPeriodo.SelectedValue.ToString());
        veOB.Periodo = this.cmbPeriodo.Text.ToString().ToUpper();
      }
      veOB.OrdenCompra = this.txtOrdenCompra.Text.Trim();
      veOB.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
      veOB.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
      veOB.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
      veOB.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
      veOB.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
      veOB.OtrosImpuestos = this.txtOtroImpuesto.Text.Length > 0 ? Convert.ToDecimal(this.txtOtroImpuesto.Text.Trim()) : new Decimal(0);
      veOB.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
      veOB.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
      NumeroaLetra numeroaLetra = new NumeroaLetra();
      veOB.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
      veOB.TotalExento = this.txtTotalExento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text.Trim()) : new Decimal(0);
      veOB.TotalaCobrar = Convert.ToDecimal(this.txtTotalCobrar.Text.Trim());
      veOB.CodImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? this.lblCodImp1.Text : "0";
      veOB.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
      veOB.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
      veOB.CodImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? this.lblCodImp2.Text : "0";
      veOB.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
      veOB.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
      veOB.CodImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? this.lblCodImp3.Text : "0";
      veOB.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
      veOB.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
      veOB.CodImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? this.lblCodImp4.Text : "0";
      veOB.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
      veOB.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
      veOB.CodImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? this.lblCodImp5.Text : "0";
      veOB.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
      veOB.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
      int num1 = new MedioPago().obtieneEstadoLiquida(veOB.IdMedioPago);
      if (flag)
      {
        if (num1 == 1)
        {
          veOB.EstadoPago = "PAGADO";
          veOB.TotalPagado = veOB.Total;
          veOB.TotalDocumentado = new Decimal(0);
          veOB.TotalPendiente = new Decimal(0);
        }
        else
        {
          veOB.EstadoPago = "PENDIENTE";
          veOB.TotalPagado = new Decimal(0);
          veOB.TotalDocumentado = new Decimal(0);
          veOB.TotalPendiente = veOB.Total;
        }
      }
      else
      {
        veOB.EstadoPago = "PAGADO";
        veOB.TotalPagado = veOB.Total;
        veOB.TotalDocumentado = new Decimal(0);
        veOB.TotalPendiente = new Decimal(0);
      }
      veOB.EstadoDocumento = "EMITIDA";
      DocumentoCompra documentoCompra = new DocumentoCompra();
      if (documentoCompra.compraExiste(Convert.ToInt64(this.txtNumeroDocumento.Text.Trim()), this.txtRut.Text.Trim(), veOB.TipoDocumentoCompra))
      {
        int num2 = (int) MessageBox.Show("Ya Existe una Compra con el N°: " + this.txtNumeroDocumento.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        veOB.FolioIngresoCompra = Convert.ToInt64(this.txtNumeroDocumento.Text.Trim());
        for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
        {
          frmIngresoCompra.lista[index].RutProveedor = veOB.Rut;
          frmIngresoCompra.lista[index].IdTipoDocumentoCompra = veOB.IdTipoDocumentoCompra;
          frmIngresoCompra.lista[index].TipoDocumentoCompra = veOB.TipoDocumentoCompra;
          frmIngresoCompra.lista[index].FolioIngresoCompra = veOB.FolioIngresoCompra;
          frmIngresoCompra.lista[index].Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          frmIngresoCompra.lista[index].FechaIngreso = veOB.FechaEmision;
          frmIngresoCompra.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }
        try
        {
          try
          {
            documentoCompra.agregaCompra(veOB);
            documentoCompra.agregaDetalleCompra(frmIngresoCompra.lista, this._listaLote);
          }
          catch (Exception ex)
          {
            int num3 = (int) MessageBox.Show("error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          if (flag && num1 == 1)
          {
            PagoCompra pagoCompra = new PagoCompra();
            PagoVentaVO pvVO = new PagoVentaVO();
            pvVO.FechaCobro = veOB.FechaEmision;
            pvVO.IdFormaPago = veOB.IdMedioPago;
            pvVO.FormaPago = veOB.MedioPago;
            pvVO.Monto = veOB.Total;
            pvVO.Estado = "PAGADO";
            int idDoc = documentoCompra.retornaIdCompra(veOB.FolioIngresoCompra, veOB.TipoDocumentoCompra, veOB.Rut);
            pagoCompra.agregarPagoCompra(pvVO, veOB.TipoDocumentoCompra, idDoc, veOB.FolioIngresoCompra, veOB.FechaEmision);
          }
          this.imprimeCompra(Convert.ToInt64(this.txtNumeroDocumento.Text));
          if (flag)
          {
            if (num1 == 0 && MessageBox.Show("¿ Desea Ingresar el detalle del Pago ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              this.pagarCompra(documentoCompra.retornaIdCompra(veOB.FolioIngresoCompra, veOB.TipoDocumentoCompra, veOB.Rut), veOB.TipoDocumentoCompra);
          }
        }
        catch (Exception ex)
        {
          int num3 = (int) MessageBox.Show("Error al Guardar : " + ex.Message);
        }
      }
    }

    public void buscaCompraID(int idCom)
    {
      DocumentoCompra documentoCompra = new DocumentoCompra();
      Venta venta = documentoCompra.buscaCompraID(idCom);
      this.veOBCompra = venta;
      if (venta.IdFactura != 0)
      {
        this.iniciaCompra();
        this.idCompra = venta.IdFactura;
        this.dtpEmision.Value = Convert.ToDateTime(venta.FechaEmision.ToString());
        this.dtpVencimiento.Value = Convert.ToDateTime(venta.FechaVencimiento.ToString());
        int num1;
        if (venta.IdMedioPago != 0)
        {
          ComboBox comboBox = this.cmbMedioPago;
          num1 = venta.IdMedioPago;
          string str = num1.ToString();
          comboBox.SelectedValue = (object) str;
          this.cmbMedioPago.Text = venta.MedioPago.ToString();
        }
        if (venta.IdTipoDocumentoCompra != 0)
        {
          ComboBox comboBox = this.cmbTipoDocumento;
          num1 = venta.IdTipoDocumentoCompra;
          string str = num1.ToString();
          comboBox.SelectedValue = (object) str;
          this.cmbTipoDocumento.Text = venta.TipoDocumentoCompra.ToString();
          this.cmbTipoDocumento.Enabled = false;
        }
        if (venta.IdCentroCosto != 0)
        {
          ComboBox comboBox = this.cmbCentroCosto;
          num1 = venta.IdCentroCosto;
          string str = num1.ToString();
          comboBox.SelectedValue = (object) str;
          this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
        }
        else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
          this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
        ComboBox comboBox1 = this.cmbPeriodo;
        num1 = venta.IdPeriodo;
        string str1 = num1.ToString();
        comboBox1.SelectedValue = (object) str1;
        this.cmbPeriodo.Text = venta.Periodo.ToString();
        this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
        this.txtNumeroDocumento.Text = venta.FolioIngresoCompra.ToString();
        this.codigoProveedor = venta.IdCliente;
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
        TextBox textBox1 = this.txtFolioFacturaNC;
        num1 = venta.FolioFacturaNC;
        string str2 = num1.ToString();
        textBox1.Text = str2;
        TextBox textBox2 = this.txtSubTotal;
        Decimal num2 = venta.SubTotal;
        string str3 = num2.ToString("N0");
        textBox2.Text = str3;
        TextBox textBox3 = this.txtTotalDescuento;
        num2 = venta.Descuento;
        string str4 = num2.ToString("N0");
        textBox3.Text = str4;
        TextBox textBox4 = this.txtPorcDescuentoTotal;
        num2 = venta.PorcentajeDescuento;
        string str5 = num2.ToString("N0");
        textBox4.Text = str5;
        TextBox textBox5 = this.txtTotalDescuento;
        num2 = venta.Descuento;
        string str6 = num2.ToString("N0");
        textBox5.Text = str6;
        TextBox textBox6 = this.txtNeto;
        num2 = venta.Neto;
        string str7 = num2.ToString("N0");
        textBox6.Text = str7;
        TextBox textBox7 = this.txtOtroImpuesto;
        num2 = venta.OtrosImpuestos;
        string str8 = num2.ToString("N0");
        textBox7.Text = str8;
        TextBox textBox8 = this.txtIva;
        num2 = venta.Iva;
        string str9 = num2.ToString("N0");
        textBox8.Text = str9;
        TextBox textBox9 = this.txtPorIva;
        num2 = venta.PorcentajeIva;
        string str10 = num2.ToString("N0");
        textBox9.Text = str10;
        TextBox textBox10 = this.txtTotalGeneral;
        num2 = venta.Total;
        string str11 = num2.ToString("N0");
        textBox10.Text = str11;
        TextBox textBox11 = this.txtTotalExento;
        num2 = venta.TotalExento;
        string str12 = num2.ToString("N0");
        textBox11.Text = str12;
        TextBox textBox12 = this.txtTotalCobrar;
        num2 = venta.TotalaCobrar;
        string str13 = num2.ToString("N0");
        textBox12.Text = str13;
        TextBox textBox13 = this.txtTotalImp1;
        num2 = venta.Impuesto1;
        string str14;
        if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
        {
          num2 = venta.Impuesto1;
          str14 = num2.ToString("N" + this.decimalesValoresVenta);
        }
        else
          str14 = "";
        textBox13.Text = str14;
        TextBox textBox14 = this.txtTotalImp2;
        num2 = venta.Impuesto2;
        string str15;
        if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
        {
          num2 = venta.Impuesto2;
          str15 = num2.ToString("N" + this.decimalesValoresVenta);
        }
        else
          str15 = "";
        textBox14.Text = str15;
        TextBox textBox15 = this.txtTotalImp3;
        num2 = venta.Impuesto3;
        string str16;
        if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
        {
          num2 = venta.Impuesto3;
          str16 = num2.ToString("N" + this.decimalesValoresVenta);
        }
        else
          str16 = "";
        textBox15.Text = str16;
        TextBox textBox16 = this.txtTotalImp4;
        num2 = venta.Impuesto4;
        string str17;
        if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
        {
          num2 = venta.Impuesto4;
          str17 = num2.ToString("N" + this.decimalesValoresVenta);
        }
        else
          str17 = "";
        textBox16.Text = str17;
        TextBox textBox17 = this.txtTotalImp5;
        num2 = venta.Impuesto5;
        string str18;
        if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
        {
          num2 = venta.Impuesto5;
          str18 = num2.ToString("N" + this.decimalesValoresVenta);
        }
        else
          str18 = "";
        textBox17.Text = str18;
        if (venta.Iva == new Decimal(0) && venta.Total > new Decimal(0))
          this.chkExento.Checked = true;
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        this.btnImprime.Enabled = true;
        if (venta.TipoDocumentoCompra.Equals("FACTURA COMPRA") || venta.TipoDocumentoCompra.Equals("FACTURA ELECTRONICA"))
          this.btnControlPago.Enabled = true;
        frmIngresoCompra.lista = documentoCompra.buscaDetalleCompraIDCompra(venta.IdFactura);
        if (frmIngresoCompra.lista.Count <= 0)
          return;
        this.cmbBodega.SelectedValue = (object) frmIngresoCompra.lista[0].Bodega;
        for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
          frmIngresoCompra.lista[index].Linea = index + 1;
        this.dgvDatosVenta.DataSource = (object) null;
        this.dgvDatosVenta.DataSource = (object) frmIngresoCompra.lista;
        this._listaLote.Clear();
        this._listaLote = new Lote().ListaLotePorDocumento("COMPRA", venta.TipoDocumentoCompra, venta.IdFactura);
        this._listaLoteAntigua.Clear();
        if (this._listaLote.Count > 0)
        {
          foreach (LoteVO loteVo in this._listaLote)
            this._listaLoteAntigua.Add(loteVo);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Documento Consultado!!");
        this.iniciaCompra();
      }
    }

    private void imprimeCompra(long folio)
    {
      if (MessageBox.Show("Desea Imprimir el Documento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        this.imprimeDirecto();
      else
        this.iniciaCompra();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaCompra();
    }

    private void guardarFacturaTeclaF2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.guardaCompra();
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
      if (MessageBox.Show("Esta Seguro de Modificar este Documento ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (!this.validaCampos())
          return;
        Venta veOB = new Venta();
        veOB.IdFactura = this.idCompra;
        veOB.FolioIngresoCompra = Convert.ToInt64(this.txtNumeroDocumento.Text.Trim());
          /*
        DateTime dateTime1 =DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local1 = @dateTime1;
        int year1 = this.dtpEmision.Value.Year;
        int month1 = this.dtpEmision.Value.Month;
        DateTime now = this.dtpEmision.Value;
        int day1 = now.Day;
        now = DateTime.Now;
        int hours1 = now.TimeOfDay.Hours;
        now = DateTime.Now;
        int minutes1 = now.TimeOfDay.Minutes;
        now = DateTime.Now;
        int seconds1 = now.TimeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local1 = new DateTime(year1, month1, day1, hours1, minutes1, seconds1);
        DateTime dateTime2=DateTime.Now;
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
           * */
        veOB.FechaEmision = dtpEmision.Value;
        veOB.FechaVencimiento = dtpVencimiento.Value;
        veOB.FechaModificacion = DateTime.Now;
        veOB.IdCliente = this.codigoProveedor;
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
        veOB.FolioFacturaNC = this.txtFolioFacturaNC.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtFolioFacturaNC.Text.Trim()) : 0;
        if (this.cmbMedioPago.SelectedValue.ToString() != "0")
        {
          veOB.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
          veOB.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
        }
        if (this.cmbTipoDocumento.SelectedValue.ToString() != "0")
        {
          veOB.IdTipoDocumentoCompra = Convert.ToInt32(this.cmbTipoDocumento.SelectedValue.ToString());
          veOB.TipoDocumentoCompra = this.cmbTipoDocumento.Text.ToString().ToUpper();
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
        if (this.cmbPeriodo.SelectedValue != null)
        {
          veOB.IdPeriodo = Convert.ToInt32(this.cmbPeriodo.SelectedValue.ToString());
          veOB.Periodo = this.cmbPeriodo.Text.ToString().ToUpper();
        }
        veOB.OrdenCompra = this.txtOrdenCompra.Text.Trim();
        veOB.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
        veOB.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        veOB.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
        veOB.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
        veOB.OtrosImpuestos = this.txtOtroImpuesto.Text.Length > 0 ? Convert.ToDecimal(this.txtOtroImpuesto.Text.Trim()) : new Decimal(0);
        veOB.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
        veOB.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
        NumeroaLetra numeroaLetra = new NumeroaLetra();
        veOB.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
        veOB.TotalExento = this.txtTotalExento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text.Trim()) : new Decimal(0);
        veOB.TotalaCobrar = Convert.ToDecimal(this.txtTotalCobrar.Text.Trim());
        veOB.CodImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? this.lblCodImp1.Text : "0";
        veOB.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
        veOB.CodImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? this.lblCodImp2.Text : "0";
        veOB.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
        veOB.CodImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? this.lblCodImp3.Text : "0";
        veOB.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
        veOB.CodImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? this.lblCodImp4.Text : "0";
        veOB.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
        veOB.CodImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? this.lblCodImp5.Text : "0";
        veOB.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
        int num1 = new MedioPago().obtieneEstadoLiquida(veOB.IdMedioPago);
        if (veOB.Total != this.veOBCompra.Total)
        {
          if (num1 == 1)
          {
            veOB.EstadoPago = "PAGADO";
            veOB.TotalPagado = veOB.Total;
            veOB.TotalDocumentado = new Decimal(0);
            veOB.TotalPendiente = new Decimal(0);
          }
          else
          {
            veOB.EstadoPago = "PENDIENTE";
            veOB.TotalPagado = new Decimal(0);
            veOB.TotalDocumentado = new Decimal(0);
            veOB.TotalPendiente = veOB.Total;
          }
        }
        else if (Convert.ToInt32(this.cmbMedioPago.SelectedValue) == this.veOBCompra.IdMedioPago)
        {
          veOB.EstadoPago = this.veOBCompra.EstadoPago;
          veOB.TotalPagado = this.veOBCompra.TotalPagado;
          veOB.TotalDocumentado = this.veOBCompra.TotalDocumentado;
          veOB.TotalPendiente = this.veOBCompra.TotalPendiente;
        }
        else if (num1 == 1)
        {
          veOB.EstadoPago = "PAGADO";
          veOB.TotalPagado = veOB.Total;
          veOB.TotalDocumentado = new Decimal(0);
          veOB.TotalPendiente = new Decimal(0);
        }
        else
        {
          veOB.EstadoPago = "PENDIENTE";
          veOB.TotalPagado = new Decimal(0);
          veOB.TotalDocumentado = new Decimal(0);
          veOB.TotalPendiente = veOB.Total;
        }
        for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
        {
          frmIngresoCompra.lista[index].RutProveedor = veOB.Rut;
          frmIngresoCompra.lista[index].IdTipoDocumentoCompra = veOB.IdTipoDocumentoCompra;
          frmIngresoCompra.lista[index].TipoDocumentoCompra = veOB.TipoDocumentoCompra;
          frmIngresoCompra.lista[index].FolioIngresoCompra = veOB.FolioIngresoCompra;
          frmIngresoCompra.lista[index].Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          frmIngresoCompra.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }
        DocumentoCompra documentoCompra = new DocumentoCompra();
        for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
          frmIngresoCompra.lista[index].FechaIngreso = veOB.FechaEmision;
        int num2 = (int) MessageBox.Show(documentoCompra.modificaCompra(veOB, frmIngresoCompra.lista, this._listaLote, this._listaLoteAntigua), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.imprimeCompra(veOB.FolioIngresoCompra);
      }
      else
      {
        int num = (int) MessageBox.Show("La Compra NO fue Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaCompra();
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
        int num = (int) MessageBox.Show("Debe Selecciona el Medio de Pago", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.cmbMedioPago.Focus();
        return false;
      }
      if (this.cmbTipoDocumento.SelectedValue == null || this.cmbTipoDocumento.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona un Tipo de Documento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.cmbTipoDocumento.Focus();
        return false;
      }
      if (this.txtNumeroDocumento.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Folio del Documento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNumeroDocumento.Focus();
        return false;
      }
      if (Convert.ToInt64(this.txtNumeroDocumento.Text.Trim()) == 0L)
      {
        int num = (int) MessageBox.Show("Numero de Folio No Valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNumeroDocumento.Focus();
        return false;
      }
      if (this.codigoProveedor == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos del Proveedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRut.Focus();
        return false;
      }
      if (this.txtRut.Text.Trim().Length == 0 || this.txtDigito.Text.Trim().Length == 0 || this.txtRazonSocial.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos del Proveedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRut.Focus();
        return false;
      }
      if (frmIngresoCompra.lista.Count == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos a Documento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCodigo.Focus();
        return false;
      }
      if (!(Convert.ToDecimal(this.txtTotalCobrar.Text) <= new Decimal(0)))
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Datos a Documento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtCodigo.Focus();
      return false;
    }

    private void txtTotalDescuento_TextChanged(object sender, EventArgs e)
    {
      if (this.txtTotalDescuento.ReadOnly)
        return;
      Decimal num1 = new Decimal(0);
      bool flag = false;
      for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
      {
        if (frmIngresoCompra.lista[index].Descuento > new Decimal(0) || frmIngresoCompra.lista[index].PorcDescuento > new Decimal(0))
        {
          flag = true;
          num1 += frmIngresoCompra.lista[index].Descuento;
        }
      }
      if (flag && !this.txtTotalDescuento.ReadOnly)
      {
        if (MessageBox.Show("¿Hay Descuentos aplicados en la lista, Desea Eliminarlos e Ingresar un Descuento General?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
          {
            frmIngresoCompra.lista[index].Descuento = new Decimal(0);
            frmIngresoCompra.lista[index].PorcDescuento = new Decimal(0);
            frmIngresoCompra.lista[index].TotalLinea = frmIngresoCompra.lista[index].ValorVenta * frmIngresoCompra.lista[index].Cantidad;
          }
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmIngresoCompra.lista;
          this.calculaTotales();
        }
        else
        {
          this.txtTotalDescuento.ReadOnly = true;
          this.txtTotalDescuento.Text = num1.ToString("N0");
        }
      }
      ArrayList arrayList1 = new ArrayList();
      Calculos calculos = new Calculos();
      Decimal descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
      Decimal subtotal = this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0);
      Decimal num2;
      Decimal num3;
      if (subtotal == new Decimal(0))
      {
        num2 = new Decimal(0);
        num3 = new Decimal(0);
        Decimal num4 = this.txtTotalExento.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text) : new Decimal(0);
        if (num4 > descuento)
        {
          this.txtTotalCobrar.Text = (num4 - descuento).ToString("N0");
        }
        else
        {
          int num5 = (int) MessageBox.Show("El Descuento NO debe ser Mayor al Total Exento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtTotalDescuento.Text = "0";
          this.txtPorcDescuentoTotal.Clear();
        }
      }
      else
      {
        ArrayList arrayList2 = calculos.totalDescuentoGeneralCompra(descuento, subtotal);
        if (arrayList2.Count > 1)
        {
          Decimal num4 = Convert.ToDecimal(arrayList2[0].ToString());
          Decimal num5 = Convert.ToDecimal(arrayList2[1].ToString());
          Decimal num6 = Convert.ToDecimal(arrayList2[2].ToString());
          num2 = new Decimal(0);
          num3 = new Decimal(0);
          Decimal num7 = this.txtTotalExento.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text) : new Decimal(0);
          this.txtNeto.Text = num4.ToString("N" + this.decimalesValoresVenta);
          this.txtIva.Text = num5.ToString("N" + this.decimalesValoresVenta);
          this.txtTotalGeneral.Text = num6.ToString("N" + this.decimalesValoresVenta);
          this.txtTotalCobrar.Text = (num6 + num7).ToString("N" + this.decimalesValoresVenta);
        }
        else
        {
          int num4 = (int) MessageBox.Show("El Descuento NO debe ser Mayor al SubTotal", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtTotalDescuento.Text = "0";
          this.txtPorcDescuentoTotal.Clear();
        }
      }
    }

    private void txtTotalDescuento_DoubleClick(object sender, EventArgs e)
    {
      this.txtTotalDescuento.ReadOnly = false;
    }

    private void txtTotalDescuento_Leave(object sender, EventArgs e)
    {
      this.txtTotalDescuento.ReadOnly = true;
    }

    private void txtPorcDescuentoTotal_TextChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.txtPorcDescuentoTotal.Text.Length > 0)
        {
          Calculos calculos = new Calculos();
          Decimal porcDesc = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
          Decimal subtotal1 = this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0);
          if (subtotal1 > new Decimal(0))
          {
            Decimal num = calculos.porcentajeDescuento(subtotal1, porcDesc);
            this.txtTotalDescuento.ReadOnly = false;
            this.txtTotalDescuento.Text = num.ToString("N0");
            this.txtTotalDescuento.ReadOnly = true;
          }
          else
          {
            Decimal num1 = new Decimal(0);
            Decimal subtotal2 = this.txtTotalExento.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text) : new Decimal(0);
            Decimal num2 = calculos.porcentajeDescuento(subtotal2, porcDesc);
            this.txtTotalDescuento.ReadOnly = false;
            this.txtTotalDescuento.Text = num2.ToString("N0");
            this.txtTotalDescuento.ReadOnly = true;
          }
        }
        else
        {
          this.txtTotalDescuento.ReadOnly = false;
          this.txtTotalDescuento.Clear();
          this.txtTotalDescuento.ReadOnly = true;
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
        this.txtPorcDescuentoTotal.Clear();
      }
    }

    private void btnModificaLinea_Click(object sender, EventArgs e)
    {
      this.modificaLinea();
    }

    private void modificaLinea()
    {
      for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
      {
        if (frmIngresoCompra.lista[index].Linea == Convert.ToInt32(this.txtLinea.Text))
        {
          frmIngresoCompra.lista[index].Codigo = this.txtCodigo.Text;
          frmIngresoCompra.lista[index].Descripcion = this.txtDescripcion.Text;
          frmIngresoCompra.lista[index].ValorVenta = Convert.ToDecimal(this.txtPrecio.Text);
          frmIngresoCompra.lista[index].Cantidad = Convert.ToDecimal(this.txtCantidad.Text);
          frmIngresoCompra.lista[index].TotalLinea = Convert.ToDecimal(this.txtTotalLinea.Text);
          frmIngresoCompra.lista[index].Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
          frmIngresoCompra.lista[index].PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
        }
      }
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) frmIngresoCompra.lista;
      this.calculaTotales();
      this.limpiaEntradaDetalle();
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
        int num = (int) new frmBuscaProductos("compra", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
        this.txtCantidad.Focus();
      }
      if (!this._guarda || this.veOBCompra.IdFactura != 0 || e.KeyCode != Keys.F2)
        return;
      this.guardaCompra();
    }

    private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.txtCodigo.Focus();
      int num = (int) new frmBuscaProductos("compra", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
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
      if (frmIngresoCompra.lista.Count <= 0)
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
      this.cmbBodega.SelectedValue = (object) this.dgvDatosVenta.SelectedRows[0].Cells["Bodega"].Value.ToString();
    }

    private void cmbListaPrecio_SelectedValueChanged(object sender, EventArgs e)
    {
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar este Documento.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        DocumentoCompra documentoCompra = new DocumentoCompra();
        try
        {
          if (this.cmbTipoDocumento.SelectedValue.ToString() == "1" || this.cmbTipoDocumento.SelectedValue.ToString() == "5")
            new PagoCompra().eliminaPagoCompra(this.cmbTipoDocumento.Text, this.idCompra, Convert.ToInt64(this.txtNumeroDocumento.Text.Trim()));
          documentoCompra.eliminaCompra(this.idCompra, frmIngresoCompra.lista, this._listaLoteAntigua);
          int num = (int) MessageBox.Show("Documento de Compra Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaCompra();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar Documento " + ex.Message);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("El Documento NO fue Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaCompra();
      }
    }

    private void btnImprime_Click(object sender, EventArgs e)
    {
      this.imprimeDirecto();
    }

    private void imprimeDirecto()
    {
      long numFactura = Convert.ToInt64(this.txtNumeroDocumento.Text);
      string rut = this.txtRut.Text.Trim();
      string text = this.cmbTipoDocumento.Text;
      DocumentoCompra documentoCompra = new DocumentoCompra();
      int idCompra = documentoCompra.retornaIdCompra(numFactura, text, rut);
      DataTable dataTable = documentoCompra.muestraCompraID(idCompra);
      try
      {
        ReportDocument reportDocument = new ReportDocument();
        reportDocument.Load("C:\\AptuSoft\\reportes\\Compra.rpt");
        reportDocument.SetDataSource(dataTable);
        string str = new LeeXml().cargarDatos("otros");
        reportDocument.PrintOptions.PrinterName = str;
        reportDocument.PrintToPrinter(1, false, 1, 1);
        reportDocument.Close();
        this.iniciaCompra();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void txtTotalDescuento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtTotalDescuento);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(this.veOBCompra.RazonSocial);
    }

    private void btnControlPago_Click(object sender, EventArgs e)
    {
      this.pagarCompra(this.idCompra, this.cmbTipoDocumento.Text.Trim());
    }

    private void pagarCompra(int id, string docCompra)
    {
      int num = (int) new frmPagosCompras(ref this.intance, docCompra, id).ShowDialog();
      this.iniciaCompra();
    }

    private void dgvDatosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        int num = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells[0].Value.ToString());
        string str = "";
        for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
        {
          if (frmIngresoCompra.lista[index].Linea == num)
          {
            str = frmIngresoCompra.lista[index].Codigo;
            frmIngresoCompra.lista.RemoveAt(index);
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
      this.txtNumeroDocumento.Enabled = true;
      this.txtNumeroDocumento.Focus();
    }

    private void txtPrecio_TextChanged(object sender, EventArgs e)
    {
        this.calculaTotalLinea();
    }

    private void txtPrecioIva_TextChanged(object sender, EventArgs e)
    {
        if (this.txtPrecioIva.Text.Length <= 0)
        {
            this.txtPrecio.Text = "";
            return;
        }
      Decimal num1 = Convert.ToDecimal(this.txtPrecioIva.Text.Trim());
      Decimal num2 = new Decimal(19);
      try
      {
          Decimal h1 = num2 / new Decimal(100);
        this.txtPrecio.Text = (num1 / ++h1).ToString("N0");
      }
      catch (Exception ex)
      {
        int num3 = (int) MessageBox.Show("Error en Calculo : " + ex.Message);
      }
    }

    private void txtPrecioIva_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPrecioIva);
    }


    private void txtCantidad_TextChanged(object sender, EventArgs e)
    {
      if (this.txtCantidad.Text.Trim().Length > 8)
      {
        if (MessageBox.Show("La Cantidad Ingresada en muy grande, ¿Desea Continuar? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          this.calculaTotalLinea();
        }
        else
        {
          this.txtCantidad.Clear();
          this.txtCantidad.Focus();
        }
      }
      else
        this.calculaTotalLinea();
    }

    private void txtDescuento_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modCompra = 0;
      this.Close();
      this.Dispose();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modCompra = 0;
      GC.Collect();
      GC.WaitForPendingFinalizers();
      this.Close();
      this.Dispose();
    }

    private void porcentajeDescuento_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
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

    private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPrecio);
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
      this.veOBCompra = new Venta();
      this.iniciaCompra();
    }

    private void btnLimpiaDetalle_Click(object sender, EventArgs e)
    {
      this.dgvDatosVenta.DataSource = (object) null;
      frmIngresoCompra.lista.Clear();
      this.txtSubTotal.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      this.txtTotalCobrar.Clear();
      this.txtTotalExento.Clear();
      this.txtOtroImpuesto.Clear();
    }

    private void txtCantidad_Enter(object sender, EventArgs e)
    {
      if (!this.chkCantidadFija.Checked || this.txtCantidad.Text.Length <= 0 || this.txtDescripcion.Text.Length <= 0)
        return;
      this.agregaLineaGrilla();
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
        this.buscaProveedor();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar");
        this.txtRut.Focus();
      }
    }

    private void btnBuscarDocumento_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaDocumentosCompra(ref this.intance, "compra").ShowDialog();
    }

    private void txtPorcDescuentoTotal_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPorcDescuentoTotal);
    }

    private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtNumeroDocumento);
    }

    private void txtOrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtOrdenCompra);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtOrdenCompra.Text.Length > 0)
        this.buscaOrdenCompraFolio(Convert.ToInt32(this.txtOrdenCompra.Text));
    }

    public void buscaOrdenCompraFolio(int folio)
    {
      OrdenCompra ordenCompra = new OrdenCompra();
      Venta venta = ordenCompra.buscaOrdenCompraFolio(folio);
      this.veOBCompra = venta;
      if (venta.IdFactura != 0)
      {
        this.iniciaCompra();
        int num1;
        if (venta.IdMedioPago != 0)
        {
          ComboBox comboBox = this.cmbMedioPago;
          num1 = venta.IdMedioPago;
          string str = num1.ToString();
          comboBox.SelectedValue = (object) str;
          this.cmbMedioPago.Text = venta.MedioPago.ToString();
        }
        if (venta.IdCentroCosto != 0)
        {
          ComboBox comboBox = this.cmbCentroCosto;
          num1 = venta.IdCentroCosto;
          string str = num1.ToString();
          comboBox.SelectedValue = (object) str;
          this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
        }
        else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
          this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
        TextBox textBox1 = this.txtOrdenCompra;
        num1 = venta.Folio;
        string str1 = num1.ToString();
        textBox1.Text = str1;
        this.codigoProveedor = venta.IdCliente;
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
        TextBox textBox10 = this.txtTotalCobrar;
        num2 = venta.Total;
        string str10 = num2.ToString("N0");
        textBox10.Text = str10;
        try
        {
          frmIngresoCompra.lista = ordenCompra.buscaDetalleOrdenCompraIDCompra(venta.IdFactura);
          int num3 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (frmIngresoCompra.lista.Count <= 0)
            return;
          for (int index = 0; index < frmIngresoCompra.lista.Count; ++index)
          {
            frmIngresoCompra.lista[index].Linea = index + 1;
            frmIngresoCompra.lista[index].Bodega = num3;
          }
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmIngresoCompra.lista;
        }
        catch (Exception ex)
        {
          int num3 = (int) MessageBox.Show(ex.Message);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Documento Consultado!!");
        this.iniciaCompra();
      }
    }

    private void txtPorcDescuentoTotal_DoubleClick(object sender, EventArgs e)
    {
      this.txtPorcDescuentoTotal.ReadOnly = false;
    }

    private void txtPorcDescuentoTotal_Leave(object sender, EventArgs e)
    {
      this.txtPorcDescuentoTotal.ReadOnly = true;
    }

    private void cmbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
    {
      if (this.cmbTipoDocumento.SelectedValue.ToString() == "8" || this.cmbTipoDocumento.SelectedValue.ToString() == "7" || this.cmbTipoDocumento.SelectedValue.ToString() == "10" || this.cmbTipoDocumento.SelectedValue.ToString() == "9")
      {
        this.lblFolioFactura.Visible = true;
        this.txtFolioFacturaNC.Visible = true;
      }
      else
      {
        this.lblFolioFactura.Visible = false;
        this.txtFolioFacturaNC.Visible = false;
      }
    }

    private void txtFolioFacturaNC_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioFacturaNC);
    }

    private void txtOtroImpuesto_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtOtroImpuesto);
    }

    private void sumaOtroImpuesto()
    {
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      Decimal num6 = new Decimal(0);
      num1 = this.txtTotalGeneral.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalGeneral.Text) : new Decimal(0);
      Decimal num7 = (this.txtNeto.Text.Length > 0 ? Convert.ToDecimal(this.txtNeto.Text) : new Decimal(0)) + (this.txtIva.Text.Length > 0 ? Convert.ToDecimal(this.txtIva.Text) : new Decimal(0)) + (this.txtOtroImpuesto.Text.Length > 0 ? Convert.ToDecimal(this.txtOtroImpuesto.Text) : new Decimal(0));
      this.txtTotalGeneral.Text = num7.ToString("N0");
      Decimal num8 = this.txtTotalExento.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text) : new Decimal(0);
      this.txtTotalCobrar.Text = (num7 + num8).ToString("N0");
    }

    private void txtOtroImpuesto_TextChanged(object sender, EventArgs e)
    {
      this.sumaOtroImpuesto();
    }

    private void quitaIva()
    {
      this.txtIva.Text = "0";
      this.txtOtroImpuesto.Clear();
      txtTotalExento.Text = txtNeto.Text;
      txtNeto.Text = "0";
      this.txtSubTotal.Text = "0";
      this.txtTotalCobrar.Text = txtTotalExento.Text;
      this.txtTotalGeneral.Text = "0";
    }

    private void chkExento_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkExento.Checked)
        this.quitaIva();
      else
        this.calculaTotales();
    }

    private void calculaTotalOtrosImpuestos()
    {
      this.txtOtroImpuesto.Text = ((this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0)) + (this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0)) + (this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0)) + (this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0)) + (this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0))).ToString("N0");
    }

    private void txtTotalImp1_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalOtrosImpuestos();
    }

    private void txtTotalImp2_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalOtrosImpuestos();
    }

    private void txtTotalImp3_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalOtrosImpuestos();
    }

    private void txtTotalImp4_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalOtrosImpuestos();
    }

    private void txtTotalImp5_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalOtrosImpuestos();
    }

    private void frmIngresoCompra_Load(object sender, EventArgs e)
    {

    }

    private void dgvDatosVenta_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        try
        {
            MessageBox.Show(e.ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
  }
}
