 
// Type: Aptusoft.frmOrdenCompra
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmOrdenCompra : Form
  {
    private static List<DatosVentaVO> lista = new List<DatosVentaVO>();
    private IContainer components = (IContainer) null;
    private OpcionesDocumentosVO odVO = new OpcionesDocumentosVO();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private bool _descuento = false;
    private bool _cambioPrecio = false;
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
    private GroupBox gbZonaFechas;
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
    private GroupBox gbZonaOtros;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private Panel panelZonaDetalle;
    private Button btnBuscaProveedor;
    private DataGridView dgvBuscaProveedor;
    private Panel pnlBuscaProveedorDes;
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
    private ToolStripMenuItem guardarFacturaTeclaF2ToolStripMenuItem;
    private Button btnImprime;
    private Label label3;
    private GroupBox gbZonaDocumento;
    private TextBox txtPrecioIva;
    private Label label21;
    private Panel panelFolio;
    private Button btnCerrarPanelFolio;
    private Button btnBuscaFolio;
    private TextBox txtFolioBuscar;
    private Label label32;
    private ToolStripMenuItem cambiarToolStripMenuItem;
    private ToolStripMenuItem buscarOCTeclaF6ToolStripMenuItem;
    private ToolStripMenuItem importarToolStripMenuItem;
    private ToolStripMenuItem cotizacionToolStripMenuItem;
    private Panel pnlCotizacionBuscar;
    private Button btnBuscaCotizacion;
    private Button btnSalirBuscaCoti;
    private TextBox txtFolioCotizacion;
    private Label label36;
    private frmOrdenCompra intance;
    private int codigoProveedor;
    private int idCompra;
    private string decimalesValoresVenta;

    public frmOrdenCompra()
    {
      this.InitializeComponent();
      this.cargaPermisos();
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      this.menuStrip1 = new MenuStrip();
      this.archivoToolStripMenuItem = new ToolStripMenuItem();
      this.buscarProductosTeclaF4ToolStripMenuItem = new ToolStripMenuItem();
      this.buscarOCTeclaF6ToolStripMenuItem = new ToolStripMenuItem();
      this.guardarFacturaTeclaF2ToolStripMenuItem = new ToolStripMenuItem();
      this.cambiarToolStripMenuItem = new ToolStripMenuItem();
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
      this.gbZonaCliente = new GroupBox();
      this.btnBuscaProveedor = new Button();
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
      this.btnAgregar = new Button();
      this.btnLimpiaDetalle = new Button();
      this.gbZonaFechas = new GroupBox();
      this.dtpVencimiento = new DateTimePicker();
      this.dtpEmision = new DateTimePicker();
      this.label2 = new Label();
      this.label1 = new Label();
      this.txtNumeroDocumento = new TextBox();
      this.lblFolio = new Label();
      this.gbZonaBotones = new GroupBox();
      this.label3 = new Label();
      this.btnImprime = new Button();
      this.btnSalir = new Button();
      this.txtPorIva = new TextBox();
      this.btnLimpiar = new Button();
      this.btnGuardar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
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
      this.gbZonaOtros = new GroupBox();
      this.cmbMedioPago = new ComboBox();
      this.cmbCentroCosto = new ComboBox();
      this.label30 = new Label();
      this.label18 = new Label();
      this.panelZonaDetalle = new Panel();
      this.txtPrecioIva = new TextBox();
      this.label21 = new Label();
      this.txtTipoDescuento = new TextBox();
      this.txtSubTotalLinea = new TextBox();
      this.btnLimpiaLineaDetalle = new Button();
      this.btnModificaLinea = new Button();
      this.txtLinea = new TextBox();
      this.panel4 = new Panel();
      this.panel3 = new Panel();
      this.txtPorcDescuentoLinea = new TextBox();
      this.label31 = new Label();
      this.dgvBuscaProveedor = new DataGridView();
      this.pnlBuscaProveedorDes = new Panel();
      this.gbZonaDocumento = new GroupBox();
      this.panelFolio = new Panel();
      this.btnCerrarPanelFolio = new Button();
      this.btnBuscaFolio = new Button();
      this.txtFolioBuscar = new TextBox();
      this.label32 = new Label();
      this.importarToolStripMenuItem = new ToolStripMenuItem();
      this.cotizacionToolStripMenuItem = new ToolStripMenuItem();
      this.pnlCotizacionBuscar = new Panel();
      this.btnBuscaCotizacion = new Button();
      this.btnSalirBuscaCoti = new Button();
      this.txtFolioCotizacion = new TextBox();
      this.label36 = new Label();
      this.menuStrip1.SuspendLayout();
      this.gbZonaCliente.SuspendLayout();
      this.gbZonaFechas.SuspendLayout();
      this.gbZonaBotones.SuspendLayout();
      ((ISupportInitialize) this.dgvDatosVenta).BeginInit();
      this.gbZonaOtros.SuspendLayout();
      this.panelZonaDetalle.SuspendLayout();
      ((ISupportInitialize) this.dgvBuscaProveedor).BeginInit();
      this.pnlBuscaProveedorDes.SuspendLayout();
      this.gbZonaDocumento.SuspendLayout();
      this.panelFolio.SuspendLayout();
      this.pnlCotizacionBuscar.SuspendLayout();
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
      this.menuStrip1.Size = new Size(1008, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.buscarProductosTeclaF4ToolStripMenuItem,
        (ToolStripItem) this.buscarOCTeclaF6ToolStripMenuItem,
        (ToolStripItem) this.guardarFacturaTeclaF2ToolStripMenuItem,
        (ToolStripItem) this.cambiarToolStripMenuItem
      });
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new Size(60, 20);
      this.archivoToolStripMenuItem.Text = "Archivo";
      this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
      this.buscarProductosTeclaF4ToolStripMenuItem.Size = new Size(238, 22);
      this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
      this.buscarProductosTeclaF4ToolStripMenuItem.Click += new EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
      this.buscarOCTeclaF6ToolStripMenuItem.Name = "buscarOCTeclaF6ToolStripMenuItem";
      this.buscarOCTeclaF6ToolStripMenuItem.Size = new Size(238, 22);
      this.buscarOCTeclaF6ToolStripMenuItem.Text = "Buscar OC - tecla [F6]";
      this.buscarOCTeclaF6ToolStripMenuItem.Click += new EventHandler(this.buscarOCTeclaF6ToolStripMenuItem_Click);
      this.guardarFacturaTeclaF2ToolStripMenuItem.Name = "guardarFacturaTeclaF2ToolStripMenuItem";
      this.guardarFacturaTeclaF2ToolStripMenuItem.Size = new Size(238, 22);
      this.guardarFacturaTeclaF2ToolStripMenuItem.Text = "Guardar Documento - tecla[F2]";
      this.guardarFacturaTeclaF2ToolStripMenuItem.Click += new EventHandler(this.guardarFacturaTeclaF2ToolStripMenuItem_Click);
      this.cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
      this.cambiarToolStripMenuItem.Size = new Size(238, 22);
      this.cambiarToolStripMenuItem.Text = "Cambiar Numero de Folio";
      this.cambiarToolStripMenuItem.Click += new EventHandler(this.cambiarToolStripMenuItem_Click);
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new Size(41, 20);
      this.salirToolStripMenuItem.Text = "Salir";
      this.salirToolStripMenuItem.Click += new EventHandler(this.salirToolStripMenuItem_Click);
      this.label17.BackColor = Color.FromArgb(64, 64, 64);
      this.label17.ForeColor = Color.White;
      this.label17.Location = new Point(559, 4);
      this.label17.Name = "label17";
      this.label17.Size = new Size(57, 23);
      this.label17.TabIndex = 4;
      this.label17.Text = "Cantidad";
      this.label17.TextAlign = ContentAlignment.TopCenter;
      this.label19.BackColor = Color.FromArgb(64, 64, 64);
      this.label19.ForeColor = Color.White;
      this.label19.Location = new Point(675, 4);
      this.label19.Name = "label19";
      this.label19.Size = new Size(77, 23);
      this.label19.TabIndex = 6;
      this.label19.Text = "$ Descuento";
      this.label19.TextAlign = ContentAlignment.TopCenter;
      this.label15.BackColor = Color.FromArgb(64, 64, 64);
      this.label15.ForeColor = Color.White;
      this.label15.Location = new Point(470, 4);
      this.label15.Name = "label15";
      this.label15.Size = new Size(86, 23);
      this.label15.TabIndex = 2;
      this.label15.Text = "Precio Neto";
      this.label15.TextAlign = ContentAlignment.TopCenter;
      this.label14.BackColor = Color.FromArgb(64, 64, 64);
      this.label14.ForeColor = Color.White;
      this.label14.Location = new Point(109, 4);
      this.label14.Name = "label14";
      this.label14.Size = new Size(359, 23);
      this.label14.TabIndex = 1;
      this.label14.Text = "Descripcion";
      this.label14.TextAlign = ContentAlignment.TopCenter;
      this.txtCantidad.BorderStyle = BorderStyle.FixedSingle;
      this.txtCantidad.Location = new Point(559, 18);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new Size(57, 20);
      this.txtCantidad.TabIndex = 12;
      this.txtCantidad.TextAlign = HorizontalAlignment.Right;
      this.txtCantidad.TextChanged += new EventHandler(this.txtCantidad_TextChanged);
      this.txtCantidad.Enter += new EventHandler(this.txtCantidad_Enter);
      this.txtCantidad.KeyDown += new KeyEventHandler(this.txtCantidad_KeyDown);
      this.txtCantidad.KeyPress += new KeyPressEventHandler(this.txtCantidad_KeyPress);
      this.label13.BackColor = Color.FromArgb(64, 64, 64);
      this.label13.ForeColor = Color.White;
      this.label13.Location = new Point(2, 4);
      this.label13.Name = "label13";
      this.label13.Size = new Size(101, 23);
      this.label13.TabIndex = 0;
      this.label13.Text = "Codigo";
      this.label13.TextAlign = ContentAlignment.TopCenter;
      this.txtCodigo.BorderStyle = BorderStyle.FixedSingle;
      this.txtCodigo.Location = new Point(2, 18);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new Size(101, 20);
      this.txtCodigo.TabIndex = 9;
      this.txtCodigo.KeyDown += new KeyEventHandler(this.txtCodigo_KeyDown);
      this.txtCodigo.KeyPress += new KeyPressEventHandler(this.txtCodigo_KeyPress);
      this.txtCodigo.Leave += new EventHandler(this.txtCodigo_Leave);
      this.label20.BackColor = Color.FromArgb(64, 64, 64);
      this.label20.ForeColor = Color.White;
      this.label20.Location = new Point(762, 4);
      this.label20.Name = "label20";
      this.label20.Size = new Size(92, 23);
      this.label20.TabIndex = 7;
      this.label20.Text = "Total";
      this.label20.TextAlign = ContentAlignment.TopCenter;
      this.txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
      this.txtDescripcion.Location = new Point(109, 18);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(359, 20);
      this.txtDescripcion.TabIndex = 10;
      this.txtDescripcion.Enter += new EventHandler(this.txtDescripcion_Enter);
      this.txtDescripcion.KeyDown += new KeyEventHandler(this.txtDescripcion_KeyDown);
      this.txtTotalLinea.BackColor = Color.White;
      this.txtTotalLinea.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalLinea.Enabled = false;
      this.txtTotalLinea.Location = new Point(762, 18);
      this.txtTotalLinea.Name = "txtTotalLinea";
      this.txtTotalLinea.Size = new Size(92, 20);
      this.txtTotalLinea.TabIndex = 15;
      this.txtTotalLinea.TabStop = false;
      this.txtTotalLinea.TextAlign = HorizontalAlignment.Right;
      this.gbZonaCliente.Controls.Add((Control) this.btnBuscaProveedor);
      this.gbZonaCliente.Controls.Add((Control) this.txtContacto);
      this.gbZonaCliente.Controls.Add((Control) this.label12);
      this.gbZonaCliente.Controls.Add((Control) this.label11);
      this.gbZonaCliente.Controls.Add((Control) this.label10);
      this.gbZonaCliente.Controls.Add((Control) this.label9);
      this.gbZonaCliente.Controls.Add((Control) this.label8);
      this.gbZonaCliente.Controls.Add((Control) this.label7);
      this.gbZonaCliente.Controls.Add((Control) this.label6);
      this.gbZonaCliente.Controls.Add((Control) this.txtFax);
      this.gbZonaCliente.Controls.Add((Control) this.txtFono);
      this.gbZonaCliente.Controls.Add((Control) this.txtGiro);
      this.gbZonaCliente.Controls.Add((Control) this.txtCiudad);
      this.gbZonaCliente.Controls.Add((Control) this.txtComuna);
      this.gbZonaCliente.Controls.Add((Control) this.txtDireccion);
      this.gbZonaCliente.Controls.Add((Control) this.label5);
      this.gbZonaCliente.Controls.Add((Control) this.label4);
      this.gbZonaCliente.Controls.Add((Control) this.txtRazonSocial);
      this.gbZonaCliente.Controls.Add((Control) this.txtDigito);
      this.gbZonaCliente.Controls.Add((Control) this.txtRut);
      this.gbZonaCliente.Location = new Point(12, 71);
      this.gbZonaCliente.Name = "gbZonaCliente";
      this.gbZonaCliente.Size = new Size(880, 102);
      this.gbZonaCliente.TabIndex = 26;
      this.gbZonaCliente.TabStop = false;
      this.btnBuscaProveedor.Location = new Point(750, 8);
      this.btnBuscaProveedor.Name = "btnBuscaProveedor";
      this.btnBuscaProveedor.Size = new Size(124, 23);
      this.btnBuscaProveedor.TabIndex = 32;
      this.btnBuscaProveedor.Text = "Buscar Proveedor";
      this.btnBuscaProveedor.UseVisualStyleBackColor = true;
      this.btnBuscaProveedor.Click += new EventHandler(this.btnBuscaProveedor_Click);
      this.txtContacto.BackColor = Color.White;
      this.txtContacto.Location = new Point(60, 77);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(194, 20);
      this.txtContacto.TabIndex = 18;
      this.label12.AutoSize = true;
      this.label12.Location = new Point(6, 81);
      this.label12.Name = "label12";
      this.label12.Size = new Size(50, 13);
      this.label12.TabIndex = 17;
      this.label12.Text = "Contacto";
      this.label12.TextAlign = ContentAlignment.TopRight;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(665, 59);
      this.label11.Name = "label11";
      this.label11.Size = new Size(24, 13);
      this.label11.TabIndex = 16;
      this.label11.Text = "Fax";
      this.label11.TextAlign = ContentAlignment.TopRight;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(471, 59);
      this.label10.Name = "label10";
      this.label10.Size = new Size(31, 13);
      this.label10.TabIndex = 15;
      this.label10.Text = "Fono";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(30, 59);
      this.label9.Name = "label9";
      this.label9.Size = new Size(26, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Giro";
      this.label9.TextAlign = ContentAlignment.TopRight;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(654, 37);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Ciudad";
      this.label8.TextAlign = ContentAlignment.TopRight;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(456, 33);
      this.label7.Name = "label7";
      this.label7.Size = new Size(46, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Comuna";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(4, 37);
      this.label6.Name = "label6";
      this.label6.Size = new Size(52, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Dirección";
      this.label6.TextAlign = ContentAlignment.TopRight;
      this.txtFax.BackColor = Color.White;
      this.txtFax.Location = new Point(696, 55);
      this.txtFax.Name = "txtFax";
      this.txtFax.Size = new Size(176, 20);
      this.txtFax.TabIndex = 10;
      this.txtFono.BackColor = Color.White;
      this.txtFono.Location = new Point(508, 55);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(143, 20);
      this.txtFono.TabIndex = 9;
      this.txtGiro.BackColor = Color.White;
      this.txtGiro.Location = new Point(60, 55);
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new Size(382, 20);
      this.txtGiro.TabIndex = 8;
      this.txtCiudad.BackColor = Color.White;
      this.txtCiudad.Location = new Point(696, 33);
      this.txtCiudad.Name = "txtCiudad";
      this.txtCiudad.Size = new Size(176, 20);
      this.txtCiudad.TabIndex = 7;
      this.txtComuna.BackColor = Color.White;
      this.txtComuna.Location = new Point(508, 33);
      this.txtComuna.Name = "txtComuna";
      this.txtComuna.Size = new Size(143, 20);
      this.txtComuna.TabIndex = 6;
      this.txtDireccion.BackColor = Color.White;
      this.txtDireccion.Location = new Point(60, 33);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new Size(382, 20);
      this.txtDireccion.TabIndex = 5;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(169, 15);
      this.label5.Name = "label5";
      this.label5.Size = new Size(70, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Razon Social";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(26, 15);
      this.label4.Name = "label4";
      this.label4.Size = new Size(30, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "RUT";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.txtRazonSocial.Location = new Point(245, 11);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(495, 20);
      this.txtRazonSocial.TabIndex = 8;
      this.txtRazonSocial.TextChanged += new EventHandler(this.txtRazonSocial_TextChanged);
      this.txtRazonSocial.KeyDown += new KeyEventHandler(this.txtRazonSocial_KeyDown);
      this.txtDigito.Location = new Point(132, 11);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 7;
      this.txtDigito.KeyPress += new KeyPressEventHandler(this.txtDigito_KeyPress);
      this.txtRut.Location = new Point(60, 11);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(68, 20);
      this.txtRut.TabIndex = 6;
      this.txtRut.KeyDown += new KeyEventHandler(this.txtRut_KeyDown);
      this.txtPrecio.BorderStyle = BorderStyle.FixedSingle;
      this.txtPrecio.Location = new Point(470, 18);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.Size = new Size(86, 20);
      this.txtPrecio.TabIndex = 11;
      this.txtPrecio.TextAlign = HorizontalAlignment.Right;
      this.txtPrecio.TextChanged += new EventHandler(this.txtPrecio_TextChanged);
      this.txtPrecio.KeyDown += new KeyEventHandler(this.txtPrecio_KeyDown);
      this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress);
      this.txtDescuento.BorderStyle = BorderStyle.FixedSingle;
      this.txtDescuento.Location = new Point(675, 18);
      this.txtDescuento.Name = "txtDescuento";
      this.txtDescuento.Size = new Size(77, 20);
      this.txtDescuento.TabIndex = 14;
      this.txtDescuento.TextAlign = HorizontalAlignment.Right;
      this.txtDescuento.TextChanged += new EventHandler(this.txtDescuento_TextChanged);
      this.txtDescuento.Enter += new EventHandler(this.txtDescuento_Enter);
      this.txtDescuento.KeyPress += new KeyPressEventHandler(this.txtDescuento_KeyPress);
      this.chkCantidadFija.AutoSize = true;
      this.chkCantidadFija.Location = new Point(618, 25);
      this.chkCantidadFija.Name = "chkCantidadFija";
      this.chkCantidadFija.Size = new Size(15, 14);
      this.chkCantidadFija.TabIndex = 16;
      this.chkCantidadFija.UseVisualStyleBackColor = true;
      this.btnAgregar.Location = new Point(768, 40);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(55, 23);
      this.btnAgregar.TabIndex = 16;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.btnLimpiaDetalle.Location = new Point(826, 40);
      this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
      this.btnLimpiaDetalle.Size = new Size(55, 23);
      this.btnLimpiaDetalle.TabIndex = 17;
      this.btnLimpiaDetalle.Text = "Limpiar";
      this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaDetalle.Click += new EventHandler(this.btnLimpiaDetalle_Click);
      this.gbZonaFechas.Controls.Add((Control) this.dtpVencimiento);
      this.gbZonaFechas.Controls.Add((Control) this.dtpEmision);
      this.gbZonaFechas.Controls.Add((Control) this.label2);
      this.gbZonaFechas.Controls.Add((Control) this.label1);
      this.gbZonaFechas.Location = new Point(12, 18);
      this.gbZonaFechas.Name = "gbZonaFechas";
      this.gbZonaFechas.Size = new Size(228, 58);
      this.gbZonaFechas.TabIndex = 24;
      this.gbZonaFechas.TabStop = false;
      this.dtpVencimiento.Format = DateTimePickerFormat.Short;
      this.dtpVencimiento.Location = new Point(118, 29);
      this.dtpVencimiento.Name = "dtpVencimiento";
      this.dtpVencimiento.Size = new Size(96, 20);
      this.dtpVencimiento.TabIndex = 1;
      this.dtpEmision.Format = DateTimePickerFormat.Short;
      this.dtpEmision.Location = new Point(6, 29);
      this.dtpEmision.Name = "dtpEmision";
      this.dtpEmision.Size = new Size(104, 20);
      this.dtpEmision.TabIndex = 0;
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(118, 15);
      this.label2.Name = "label2";
      this.label2.Size = new Size(96, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Vencimiento";
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(8, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(102, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Emision";
      this.txtNumeroDocumento.BackColor = Color.White;
      this.txtNumeroDocumento.Location = new Point(9, 33);
      this.txtNumeroDocumento.Name = "txtNumeroDocumento";
      this.txtNumeroDocumento.Size = new Size(124, 20);
      this.txtNumeroDocumento.TabIndex = 2;
      this.txtNumeroDocumento.TextAlign = HorizontalAlignment.Right;
      this.txtNumeroDocumento.KeyPress += new KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
      this.lblFolio.AutoSize = true;
      this.lblFolio.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFolio.Location = new Point(9, 14);
      this.lblFolio.Name = "lblFolio";
      this.lblFolio.Size = new Size(108, 15);
      this.lblFolio.TabIndex = 5;
      this.lblFolio.Text = "Ord. Compra N°";
      this.gbZonaBotones.Controls.Add((Control) this.label3);
      this.gbZonaBotones.Controls.Add((Control) this.btnImprime);
      this.gbZonaBotones.Controls.Add((Control) this.btnSalir);
      this.gbZonaBotones.Controls.Add((Control) this.txtPorIva);
      this.gbZonaBotones.Controls.Add((Control) this.btnLimpiar);
      this.gbZonaBotones.Controls.Add((Control) this.btnGuardar);
      this.gbZonaBotones.Controls.Add((Control) this.btnEliminar);
      this.gbZonaBotones.Controls.Add((Control) this.btnModificar);
      this.gbZonaBotones.Controls.Add((Control) this.txtSubTotal);
      this.gbZonaBotones.Controls.Add((Control) this.txtTotalGeneral);
      this.gbZonaBotones.Controls.Add((Control) this.txtIva);
      this.gbZonaBotones.Controls.Add((Control) this.txtNeto);
      this.gbZonaBotones.Controls.Add((Control) this.txtTotalDescuento);
      this.gbZonaBotones.Controls.Add((Control) this.txtPorcDescuentoTotal);
      this.gbZonaBotones.Controls.Add((Control) this.label26);
      this.gbZonaBotones.Controls.Add((Control) this.label25);
      this.gbZonaBotones.Controls.Add((Control) this.label24);
      this.gbZonaBotones.Controls.Add((Control) this.label23);
      this.gbZonaBotones.Controls.Add((Control) this.label22);
      this.gbZonaBotones.Location = new Point(12, 443);
      this.gbZonaBotones.Name = "gbZonaBotones";
      this.gbZonaBotones.Size = new Size(888, 131);
      this.gbZonaBotones.TabIndex = 28;
      this.gbZonaBotones.TabStop = false;
      this.gbZonaBotones.Enter += new EventHandler(this.groupBox1_Enter);
      this.label3.AutoSize = true;
      this.label3.BackColor = Color.Transparent;
      this.label3.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Black;
      this.label3.Location = new Point(6, 17);
      this.label3.Name = "label3";
      this.label3.Size = new Size(318, 33);
      this.label3.TabIndex = 28;
      this.label3.Text = "ORDEN DE COMPRA";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.btnImprime.Location = new Point(7, 92);
      this.btnImprime.Name = "btnImprime";
      this.btnImprime.Size = new Size(86, 23);
      this.btnImprime.TabIndex = 26;
      this.btnImprime.Text = "RE-IMPRIME";
      this.btnImprime.UseVisualStyleBackColor = true;
      this.btnImprime.Click += new EventHandler(this.btnImprime_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(454, 63);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 54);
      this.btnSalir.TabIndex = 23;
      this.btnSalir.Text = "SALIR";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.txtPorIva.BackColor = Color.White;
      this.txtPorIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorIva.Enabled = false;
      this.txtPorIva.Location = new Point(777, 80);
      this.txtPorIva.Name = "txtPorIva";
      this.txtPorIva.Size = new Size(24, 20);
      this.txtPorIva.TabIndex = 11;
      this.txtPorIva.TabStop = false;
      this.txtPorIva.TextAlign = HorizontalAlignment.Right;
      this.btnLimpiar.Location = new Point(263, 63);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 23);
      this.btnLimpiar.TabIndex = 22;
      this.btnLimpiar.Text = "LIMPIAR";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.button7_Click);
      this.btnGuardar.Location = new Point(7, 63);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(88, 23);
      this.btnGuardar.TabIndex = 19;
      this.btnGuardar.Text = "GUARDA [F2]";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnEliminar.Location = new Point(182, 63);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(75, 23);
      this.btnEliminar.TabIndex = 21;
      this.btnEliminar.Text = "ELIMINA";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnModificar.Location = new Point(101, 63);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 23);
      this.btnModificar.TabIndex = 20;
      this.btnModificar.Text = "MODIFICA";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.txtSubTotal.BackColor = Color.White;
      this.txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
      this.txtSubTotal.Enabled = false;
      this.txtSubTotal.Location = new Point(777, 14);
      this.txtSubTotal.Name = "txtSubTotal";
      this.txtSubTotal.Size = new Size(103, 20);
      this.txtSubTotal.TabIndex = 10;
      this.txtSubTotal.TabStop = false;
      this.txtSubTotal.TextAlign = HorizontalAlignment.Right;
      this.txtTotalGeneral.BackColor = Color.White;
      this.txtTotalGeneral.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalGeneral.Enabled = false;
      this.txtTotalGeneral.Location = new Point(777, 102);
      this.txtTotalGeneral.Name = "txtTotalGeneral";
      this.txtTotalGeneral.Size = new Size(103, 20);
      this.txtTotalGeneral.TabIndex = 9;
      this.txtTotalGeneral.TabStop = false;
      this.txtTotalGeneral.TextAlign = HorizontalAlignment.Right;
      this.txtIva.BackColor = Color.White;
      this.txtIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtIva.Enabled = false;
      this.txtIva.Location = new Point(803, 80);
      this.txtIva.Name = "txtIva";
      this.txtIva.Size = new Size(77, 20);
      this.txtIva.TabIndex = 8;
      this.txtIva.TabStop = false;
      this.txtIva.TextAlign = HorizontalAlignment.Right;
      this.txtNeto.BackColor = Color.White;
      this.txtNeto.BorderStyle = BorderStyle.FixedSingle;
      this.txtNeto.Enabled = false;
      this.txtNeto.Location = new Point(777, 58);
      this.txtNeto.Name = "txtNeto";
      this.txtNeto.Size = new Size(103, 20);
      this.txtNeto.TabIndex = 7;
      this.txtNeto.TabStop = false;
      this.txtNeto.TextAlign = HorizontalAlignment.Right;
      this.txtTotalDescuento.BackColor = Color.White;
      this.txtTotalDescuento.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalDescuento.Location = new Point(803, 36);
      this.txtTotalDescuento.Name = "txtTotalDescuento";
      this.txtTotalDescuento.ReadOnly = true;
      this.txtTotalDescuento.Size = new Size(77, 20);
      this.txtTotalDescuento.TabIndex = 6;
      this.txtTotalDescuento.TabStop = false;
      this.txtTotalDescuento.TextAlign = HorizontalAlignment.Right;
      this.txtTotalDescuento.TextChanged += new EventHandler(this.txtTotalDescuento_TextChanged);
      this.txtTotalDescuento.DoubleClick += new EventHandler(this.txtTotalDescuento_DoubleClick);
      this.txtTotalDescuento.KeyPress += new KeyPressEventHandler(this.txtTotalDescuento_KeyPress);
      this.txtTotalDescuento.Leave += new EventHandler(this.txtTotalDescuento_Leave);
      this.txtPorcDescuentoTotal.BackColor = Color.White;
      this.txtPorcDescuentoTotal.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorcDescuentoTotal.Location = new Point(777, 36);
      this.txtPorcDescuentoTotal.Name = "txtPorcDescuentoTotal";
      this.txtPorcDescuentoTotal.ReadOnly = true;
      this.txtPorcDescuentoTotal.Size = new Size(24, 20);
      this.txtPorcDescuentoTotal.TabIndex = 5;
      this.txtPorcDescuentoTotal.TabStop = false;
      this.txtPorcDescuentoTotal.TextAlign = HorizontalAlignment.Right;
      this.txtPorcDescuentoTotal.TextChanged += new EventHandler(this.txtPorcDescuentoTotal_TextChanged);
      this.txtPorcDescuentoTotal.DoubleClick += new EventHandler(this.txtPorcDescuentoTotal_DoubleClick);
      this.txtPorcDescuentoTotal.KeyPress += new KeyPressEventHandler(this.txtPorcDescuentoTotal_KeyPress);
      this.txtPorcDescuentoTotal.Leave += new EventHandler(this.txtPorcDescuentoTotal_Leave);
      this.label26.AutoSize = true;
      this.label26.BackColor = SystemColors.Control;
      this.label26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.Black;
      this.label26.Location = new Point(726, 106);
      this.label26.Name = "label26";
      this.label26.Size = new Size(47, 13);
      this.label26.TabIndex = 4;
      this.label26.Text = "TOTAL";
      this.label25.AutoSize = true;
      this.label25.BackColor = SystemColors.Control;
      this.label25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label25.ForeColor = Color.Black;
      this.label25.Location = new Point(738, 84);
      this.label25.Name = "label25";
      this.label25.Size = new Size(35, 13);
      this.label25.TabIndex = 3;
      this.label25.Text = "I.V.A";
      this.label24.AutoSize = true;
      this.label24.BackColor = SystemColors.Control;
      this.label24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = Color.Black;
      this.label24.Location = new Point(732, 62);
      this.label24.Name = "label24";
      this.label24.Size = new Size(41, 13);
      this.label24.TabIndex = 2;
      this.label24.Text = "NETO";
      this.label23.AutoSize = true;
      this.label23.BackColor = SystemColors.Control;
      this.label23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.Black;
      this.label23.Location = new Point(690, 40);
      this.label23.Name = "label23";
      this.label23.Size = new Size(83, 13);
      this.label23.TabIndex = 1;
      this.label23.Text = "DESCUENTO";
      this.label22.AutoSize = true;
      this.label22.BackColor = SystemColors.Control;
      this.label22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label22.ForeColor = Color.Black;
      this.label22.Location = new Point(701, 18);
      this.label22.Name = "label22";
      this.label22.Size = new Size(72, 13);
      this.label22.TabIndex = 0;
      this.label22.Text = "SUBTOTAL";
      this.dgvDatosVenta.AllowUserToAddRows = false;
      this.dgvDatosVenta.AllowUserToDeleteRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      this.dgvDatosVenta.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvDatosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = Color.Black;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvDatosVenta.DefaultCellStyle = gridViewCellStyle2;
      this.dgvDatosVenta.Location = new Point(3, 80);
      this.dgvDatosVenta.MultiSelect = false;
      this.dgvDatosVenta.Name = "dgvDatosVenta";
      this.dgvDatosVenta.ReadOnly = true;
      this.dgvDatosVenta.RowHeadersVisible = false;
      this.dgvDatosVenta.RowHeadersWidth = 50;
      this.dgvDatosVenta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDatosVenta.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatosVenta.Size = new Size(877, 185);
      this.dgvDatosVenta.TabIndex = 3;
      this.dgvDatosVenta.TabStop = false;
      this.dgvDatosVenta.CellClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
      this.dgvDatosVenta.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
      this.gbZonaOtros.Controls.Add((Control) this.cmbMedioPago);
      this.gbZonaOtros.Controls.Add((Control) this.cmbCentroCosto);
      this.gbZonaOtros.Controls.Add((Control) this.label30);
      this.gbZonaOtros.Controls.Add((Control) this.label18);
      this.gbZonaOtros.Location = new Point(242, 18);
      this.gbZonaOtros.Name = "gbZonaOtros";
      this.gbZonaOtros.Size = new Size(510, 58);
      this.gbZonaOtros.TabIndex = 25;
      this.gbZonaOtros.TabStop = false;
      this.cmbMedioPago.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbMedioPago.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbMedioPago.FormattingEnabled = true;
      this.cmbMedioPago.Location = new Point(6, 29);
      this.cmbMedioPago.Name = "cmbMedioPago";
      this.cmbMedioPago.Size = new Size(140, 21);
      this.cmbMedioPago.TabIndex = 2;
      this.cmbMedioPago.Enter += new EventHandler(this.cmbMedioPago_Enter);
      this.cmbCentroCosto.FormattingEnabled = true;
      this.cmbCentroCosto.Location = new Point(152, 29);
      this.cmbCentroCosto.Name = "cmbCentroCosto";
      this.cmbCentroCosto.Size = new Size(137, 21);
      this.cmbCentroCosto.TabIndex = 4;
      this.label30.BackColor = Color.FromArgb(64, 64, 64);
      this.label30.ForeColor = Color.White;
      this.label30.Location = new Point(152, 15);
      this.label30.Name = "label30";
      this.label30.Size = new Size(137, 23);
      this.label30.TabIndex = 34;
      this.label30.Text = "Centro de Costo";
      this.label18.BackColor = Color.FromArgb(64, 64, 64);
      this.label18.ForeColor = Color.White;
      this.label18.Location = new Point(6, 15);
      this.label18.Name = "label18";
      this.label18.Size = new Size(140, 23);
      this.label18.TabIndex = 23;
      this.label18.Text = "Medio de Pago";
      this.panelZonaDetalle.BorderStyle = BorderStyle.Fixed3D;
      this.panelZonaDetalle.Controls.Add((Control) this.txtPrecioIva);
      this.panelZonaDetalle.Controls.Add((Control) this.label21);
      this.panelZonaDetalle.Controls.Add((Control) this.txtTipoDescuento);
      this.panelZonaDetalle.Controls.Add((Control) this.txtSubTotalLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.btnLimpiaLineaDetalle);
      this.panelZonaDetalle.Controls.Add((Control) this.btnModificaLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.txtLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.panel4);
      this.panelZonaDetalle.Controls.Add((Control) this.panel3);
      this.panelZonaDetalle.Controls.Add((Control) this.txtPorcDescuentoLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.label31);
      this.panelZonaDetalle.Controls.Add((Control) this.txtCodigo);
      this.panelZonaDetalle.Controls.Add((Control) this.txtCantidad);
      this.panelZonaDetalle.Controls.Add((Control) this.dgvDatosVenta);
      this.panelZonaDetalle.Controls.Add((Control) this.chkCantidadFija);
      this.panelZonaDetalle.Controls.Add((Control) this.btnAgregar);
      this.panelZonaDetalle.Controls.Add((Control) this.txtDescripcion);
      this.panelZonaDetalle.Controls.Add((Control) this.btnLimpiaDetalle);
      this.panelZonaDetalle.Controls.Add((Control) this.txtTotalLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.label20);
      this.panelZonaDetalle.Controls.Add((Control) this.txtPrecio);
      this.panelZonaDetalle.Controls.Add((Control) this.label14);
      this.panelZonaDetalle.Controls.Add((Control) this.txtDescuento);
      this.panelZonaDetalle.Controls.Add((Control) this.label13);
      this.panelZonaDetalle.Controls.Add((Control) this.label15);
      this.panelZonaDetalle.Controls.Add((Control) this.label17);
      this.panelZonaDetalle.Controls.Add((Control) this.label19);
      this.panelZonaDetalle.Location = new Point(12, 176);
      this.panelZonaDetalle.Name = "panelZonaDetalle";
      this.panelZonaDetalle.Size = new Size(888, 273);
      this.panelZonaDetalle.TabIndex = 27;
      this.txtPrecioIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtPrecioIva.Location = new Point(470, 55);
      this.txtPrecioIva.Name = "txtPrecioIva";
      this.txtPrecioIva.Size = new Size(86, 20);
      this.txtPrecioIva.TabIndex = 37;
      this.txtPrecioIva.TextAlign = HorizontalAlignment.Right;
      this.txtPrecioIva.TextChanged += new EventHandler(this.txtPrecioIva_TextChanged);
      this.txtPrecioIva.KeyPress += new KeyPressEventHandler(this.txtPrecioIva_KeyPress);
      this.label21.BackColor = Color.FromArgb(64, 64, 64);
      this.label21.ForeColor = Color.White;
      this.label21.Location = new Point(470, 41);
      this.label21.Name = "label21";
      this.label21.Size = new Size(86, 23);
      this.label21.TabIndex = 36;
      this.label21.Text = "Precio Con IVA";
      this.label21.TextAlign = ContentAlignment.TopCenter;
      this.txtTipoDescuento.Location = new Point(413, 44);
      this.txtTipoDescuento.Name = "txtTipoDescuento";
      this.txtTipoDescuento.Size = new Size(38, 20);
      this.txtTipoDescuento.TabIndex = 35;
      this.txtTipoDescuento.Text = "0";
      this.txtTipoDescuento.Visible = false;
      this.txtSubTotalLinea.Location = new Point(361, 44);
      this.txtSubTotalLinea.Name = "txtSubTotalLinea";
      this.txtSubTotalLinea.Size = new Size(43, 20);
      this.txtSubTotalLinea.TabIndex = 34;
      this.txtSubTotalLinea.Visible = false;
      this.btnLimpiaLineaDetalle.Location = new Point(858, 3);
      this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
      this.btnLimpiaLineaDetalle.Size = new Size(20, 34);
      this.btnLimpiaLineaDetalle.TabIndex = 33;
      this.btnLimpiaLineaDetalle.Text = "..";
      this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaLineaDetalle.Click += new EventHandler(this.btnLimpiaLineaDetalle_Click);
      this.btnModificaLinea.Location = new Point(688, 41);
      this.btnModificaLinea.Name = "btnModificaLinea";
      this.btnModificaLinea.Size = new Size(75, 23);
      this.btnModificaLinea.TabIndex = 33;
      this.btnModificaLinea.Text = "Modificar";
      this.btnModificaLinea.UseVisualStyleBackColor = true;
      this.btnModificaLinea.Click += new EventHandler(this.btnModificaLinea_Click);
      this.txtLinea.Location = new Point(283, 44);
      this.txtLinea.Name = "txtLinea";
      this.txtLinea.Size = new Size(71, 20);
      this.txtLinea.TabIndex = 32;
      this.txtLinea.Text = "NumeroLinea";
      this.txtLinea.Visible = false;
      this.panel4.BorderStyle = BorderStyle.Fixed3D;
      this.panel4.Location = new Point(755, 3);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(5, 36);
      this.panel4.TabIndex = 31;
      this.panel3.BorderStyle = BorderStyle.Fixed3D;
      this.panel3.Location = new Point(635, 3);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(5, 36);
      this.panel3.TabIndex = 30;
      this.txtPorcDescuentoLinea.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorcDescuentoLinea.Location = new Point(642, 18);
      this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
      this.txtPorcDescuentoLinea.Size = new Size(31, 20);
      this.txtPorcDescuentoLinea.TabIndex = 13;
      this.txtPorcDescuentoLinea.TextAlign = HorizontalAlignment.Right;
      this.txtPorcDescuentoLinea.TextChanged += new EventHandler(this.porcentajeDescuento_TextChanged);
      this.txtPorcDescuentoLinea.Enter += new EventHandler(this.txtPorcDescuentoLinea_Enter);
      this.txtPorcDescuentoLinea.KeyDown += new KeyEventHandler(this.txtPorcDescuentoLinea_KeyDown);
      this.txtPorcDescuentoLinea.KeyPress += new KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
      this.label31.BackColor = Color.FromArgb(64, 64, 64);
      this.label31.ForeColor = Color.White;
      this.label31.Location = new Point(642, 4);
      this.label31.Name = "label31";
      this.label31.Size = new Size(31, 23);
      this.label31.TabIndex = 29;
      this.label31.Text = "%";
      this.label31.TextAlign = ContentAlignment.TopCenter;
      this.dgvBuscaProveedor.AllowUserToAddRows = false;
      this.dgvBuscaProveedor.AllowUserToDeleteRows = false;
      this.dgvBuscaProveedor.AllowUserToResizeColumns = false;
      this.dgvBuscaProveedor.AllowUserToResizeRows = false;
      gridViewCellStyle3.BackColor = Color.Lavender;
      this.dgvBuscaProveedor.AlternatingRowsDefaultCellStyle = gridViewCellStyle3;
      this.dgvBuscaProveedor.BackgroundColor = Color.LavenderBlush;
      this.dgvBuscaProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle4.BackColor = SystemColors.Window;
      gridViewCellStyle4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle4.ForeColor = SystemColors.ControlText;
      gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
      this.dgvBuscaProveedor.DefaultCellStyle = gridViewCellStyle4;
      this.dgvBuscaProveedor.Location = new Point(3, 3);
      this.dgvBuscaProveedor.Name = "dgvBuscaProveedor";
      this.dgvBuscaProveedor.ReadOnly = true;
      this.dgvBuscaProveedor.RowHeadersVisible = false;
      this.dgvBuscaProveedor.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaProveedor.Size = new Size(637, 211);
      this.dgvBuscaProveedor.TabIndex = 0;
      this.dgvBuscaProveedor.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaProveedor_CellDoubleClick);
      this.dgvBuscaProveedor.KeyDown += new KeyEventHandler(this.dgvBuscaProveedor_KeyDown);
      this.pnlBuscaProveedorDes.Controls.Add((Control) this.dgvBuscaProveedor);
      this.pnlBuscaProveedorDes.Location = new Point(257, 103);
      this.pnlBuscaProveedorDes.Name = "pnlBuscaProveedorDes";
      this.pnlBuscaProveedorDes.Size = new Size(669, 217);
      this.pnlBuscaProveedorDes.TabIndex = 32;
      this.gbZonaDocumento.Controls.Add((Control) this.lblFolio);
      this.gbZonaDocumento.Controls.Add((Control) this.txtNumeroDocumento);
      this.gbZonaDocumento.Location = new Point(753, 18);
      this.gbZonaDocumento.Name = "gbZonaDocumento";
      this.gbZonaDocumento.Size = new Size(139, 58);
      this.gbZonaDocumento.TabIndex = 34;
      this.gbZonaDocumento.TabStop = false;
      this.panelFolio.BorderStyle = BorderStyle.FixedSingle;
      this.panelFolio.Controls.Add((Control) this.btnCerrarPanelFolio);
      this.panelFolio.Controls.Add((Control) this.btnBuscaFolio);
      this.panelFolio.Controls.Add((Control) this.txtFolioBuscar);
      this.panelFolio.Controls.Add((Control) this.label32);
      this.panelFolio.Location = new Point(722, 72);
      this.panelFolio.Name = "panelFolio";
      this.panelFolio.Size = new Size(227, 92);
      this.panelFolio.TabIndex = 35;
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
      this.txtFolioBuscar.KeyPress += new KeyPressEventHandler(this.txtFolioBuscar_KeyPress);
      this.label32.AutoSize = true;
      this.label32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label32.Location = new Point(21, 8);
      this.label32.Name = "label32";
      this.label32.Size = new Size(164, 16);
      this.label32.TabIndex = 0;
      this.label32.Text = "Ingrese Folio a Buscar";
      this.importarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.cotizacionToolStripMenuItem
      });
      this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
      this.importarToolStripMenuItem.Size = new Size(65, 20);
      this.importarToolStripMenuItem.Text = "Importar";
      this.cotizacionToolStripMenuItem.Name = "cotizacionToolStripMenuItem";
      this.cotizacionToolStripMenuItem.Size = new Size(152, 22);
      this.cotizacionToolStripMenuItem.Text = "Cotizacion";
      this.cotizacionToolStripMenuItem.Click += new EventHandler(this.cotizacionToolStripMenuItem_Click);
      this.pnlCotizacionBuscar.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.pnlCotizacionBuscar.BorderStyle = BorderStyle.FixedSingle;
      this.pnlCotizacionBuscar.Controls.Add((Control) this.btnBuscaCotizacion);
      this.pnlCotizacionBuscar.Controls.Add((Control) this.btnSalirBuscaCoti);
      this.pnlCotizacionBuscar.Controls.Add((Control) this.txtFolioCotizacion);
      this.pnlCotizacionBuscar.Controls.Add((Control) this.label36);
      this.pnlCotizacionBuscar.Location = new Point(371, 145);
      this.pnlCotizacionBuscar.Name = "pnlCotizacionBuscar";
      this.pnlCotizacionBuscar.Size = new Size(173, 110);
      this.pnlCotizacionBuscar.TabIndex = 38;
      this.btnBuscaCotizacion.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaCotizacion.Location = new Point(8, 77);
      this.btnBuscaCotizacion.Name = "btnBuscaCotizacion";
      this.btnBuscaCotizacion.Size = new Size(149, 23);
      this.btnBuscaCotizacion.TabIndex = 2;
      this.btnBuscaCotizacion.Text = "BUSCAR";
      this.btnBuscaCotizacion.UseVisualStyleBackColor = true;
      this.btnBuscaCotizacion.Click += new EventHandler(this.btnBuscaCotizacion_Click);
      this.btnSalirBuscaCoti.Location = new Point(132, 1);
      this.btnSalirBuscaCoti.Name = "btnSalirBuscaCoti";
      this.btnSalirBuscaCoti.Size = new Size(29, 23);
      this.btnSalirBuscaCoti.TabIndex = 3;
      this.btnSalirBuscaCoti.Text = "X";
      this.btnSalirBuscaCoti.UseVisualStyleBackColor = true;
      this.txtFolioCotizacion.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFolioCotizacion.Location = new Point(8, 45);
      this.txtFolioCotizacion.Name = "txtFolioCotizacion";
      this.txtFolioCotizacion.Size = new Size(148, 26);
      this.txtFolioCotizacion.TabIndex = 1;
      this.txtFolioCotizacion.TextAlign = HorizontalAlignment.Center;
      this.label36.BackColor = Color.Blue;
      this.label36.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label36.ForeColor = Color.White;
      this.label36.Location = new Point(8, 27);
      this.label36.Name = "label36";
      this.label36.Size = new Size(149, 18);
      this.label36.TabIndex = 0;
      this.label36.Text = "COTIZACIÓN N°";
      this.label36.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1008, 762);
      this.Controls.Add((Control) this.pnlCotizacionBuscar);
      this.Controls.Add((Control) this.panelFolio);
      this.Controls.Add((Control) this.pnlBuscaProveedorDes);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.gbZonaDocumento);
      this.Controls.Add((Control) this.panelZonaDetalle);
      this.Controls.Add((Control) this.gbZonaOtros);
      this.Controls.Add((Control) this.gbZonaFechas);
      this.Controls.Add((Control) this.gbZonaCliente);
      this.Controls.Add((Control) this.gbZonaBotones);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmOrdenCompra";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Orden de Compra";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmFactura_FormClosing);
      this.KeyDown += new KeyEventHandler(this.frmFactura_KeyDown);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.gbZonaCliente.ResumeLayout(false);
      this.gbZonaCliente.PerformLayout();
      this.gbZonaFechas.ResumeLayout(false);
      this.gbZonaBotones.ResumeLayout(false);
      this.gbZonaBotones.PerformLayout();
      ((ISupportInitialize) this.dgvDatosVenta).EndInit();
      this.gbZonaOtros.ResumeLayout(false);
      this.panelZonaDetalle.ResumeLayout(false);
      this.panelZonaDetalle.PerformLayout();
      ((ISupportInitialize) this.dgvBuscaProveedor).EndInit();
      this.pnlBuscaProveedorDes.ResumeLayout(false);
      this.gbZonaDocumento.ResumeLayout(false);
      this.gbZonaDocumento.PerformLayout();
      this.panelFolio.ResumeLayout(false);
      this.panelFolio.PerformLayout();
      this.pnlCotizacionBuscar.ResumeLayout(false);
      this.pnlCotizacionBuscar.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("ORDEN COMPRA"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._descuento = Convert.ToBoolean(usuarioVo.Descuento);
          this._cambioPrecio = Convert.ToBoolean(usuarioVo.CambioPrecio);
        }
      }
    }

    public void cargaOpcionesDocumentosInicio()
    {
      this.odVO = new OpcionesGenerales().rescataOpcionesDocumentosPorNombre("COMPRA");
    }

    public void cargaOpcionesDocumentos()
    {
      this.decimalesValoresVenta = this.odVO.DecimalesValorVenta.ToString();
    }

    private void obtieneFolioOrdenCompraDisponible()
    {
      this.txtNumeroDocumento.Text = new OrdenCompra().numeroOrdenCompra().ToString();
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) new MedioPago().listaMediosPago();
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void cargaCentroCosto()
    {
      this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
      this.cmbCentroCosto.ValueMember = "idCentroCosto";
      this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
      this.cmbCentroCosto.SelectedValue = (object) 0;
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
        this.cargaCentroCosto();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar centro costo: " + ex.Message);
      }
      try
      {
        this.obtieneFolioOrdenCompraDisponible();
        this.txtNumeroDocumento.Enabled = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar Folio: " + ex.Message);
      }
      this.codigoProveedor = 0;
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
      this.cargaOpcionesDocumentos();
      this.dtpEmision.Value = DateTime.Today;
      this.dtpVencimiento.Value = DateTime.Today;
      this.panelFolio.Visible = false;
      this.txtFolioBuscar.Clear();
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
      this.txtSubTotal.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotalGeneral.Clear();
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
      frmOrdenCompra.lista.Clear();
      this.cambiarToolStripMenuItem.Enabled = true;
      this.limpiaEntradaDetalle();
      this.pnlCotizacionBuscar.Visible = false;
      this.txtFolioCotizacion.Clear();
      this.gbZonaDocumento.TabIndex = 2;
      this.gbZonaFechas.TabIndex = 1;
      this.gbZonaOtros.TabIndex = 0;
      this.gbZonaCliente.TabIndex = 3;
      this.panelZonaDetalle.TabIndex = 4;
      this.gbZonaBotones.TabIndex = 5;
      this.cmbMedioPago.Focus();
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
      this.dgvDatosVenta.Columns[2].Width = 300;
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
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn);
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
        this.txtTotalLinea.Text = calculos.totalLinea(subTotal, descuento).ToString("N" + this.decimalesValoresVenta);
      }
      else
      {
        int num4 = (int) MessageBox.Show("El Descuento debe ser Menor al Total!!");
        this.txtDescuento.Clear();
        this.txtPorcDescuentoLinea.Clear();
      }
    }

    public void llamaProductoCodigo(string cod)
    {
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
      if (productoVo.Codigo != null)
      {
        this.txtCodigo.Text = productoVo.Codigo;
        this.txtDescripcion.Text = productoVo.Descripcion;
        this.txtPrecio.Text = productoVo.ValorCompra.ToString("N" + this.decimalesValoresVenta);
        this.txtCantidad.Focus();
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe el Codigo Ingresado.");
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
      this.txtTotalDescuento.ReadOnly = true;
      this.txtPorcDescuentoTotal.ReadOnly = true;
      frmOrdenCompra.lista.Add(new DatosVentaVO()
      {
        Codigo = this.txtCodigo.Text.Trim().ToUpper(),
        Descripcion = this.txtDescripcion.Text.Trim().ToUpper(),
        ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0),
        Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0),
        Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0),
        PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0),
        TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0),
        SubTotalLinea = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text) : new Decimal(0),
        TipoDescuento = Convert.ToInt32(this.txtTipoDescuento.Text),
        FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim())
      });
      this.limpiaEntradaDetalle();
      this.calculaTotales();
      this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
      this.txtCodigo.Focus();
    }

    private void calculaTotales()
    {
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) frmOrdenCompra.lista;
      for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
        frmOrdenCompra.lista[index].Linea = index + 1;
      Calculos calculos = new Calculos();
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal total = calculos.totalGeneralCompra(frmOrdenCompra.lista);
      this.txtTotalGeneral.Text = total.ToString("N" + this.decimalesValoresVenta);
      this.txtTotalDescuento.Text = calculos.totalDescuento(frmOrdenCompra.lista).ToString("N" + this.decimalesValoresVenta);
      Decimal neto = calculos.totalNeto(total);
      TextBox textBox1 = this.txtSubTotal;
      Decimal num4 = calculos.totalSubTotal(frmOrdenCompra.lista);
      string str1 = num4.ToString("N" + this.decimalesValoresVenta);
      textBox1.Text = str1;
      this.txtNeto.Text = neto.ToString("N" + this.decimalesValoresVenta);
      TextBox textBox2 = this.txtIva;
      num4 = calculos.totalIva(neto);
      string str2 = num4.ToString("N" + this.decimalesValoresVenta);
      textBox2.Text = str2;
    }

    private void limpiaEntradaDetalle()
    {
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Enabled = true;
      this.btnLimpiaDetalle.Enabled = true;
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
      int num = (int) new frmBuscaProveedor(ref this.intance, "orden_compra").ShowDialog();
    }

    private void txtRazonSocial_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRazonSocial.Text.Trim().Length > 0 && this.txtRut.Text.Trim().Length == 0)
      {
        this.pnlBuscaProveedorDes.Visible = true;
        List<ClienteVO> list = new Proveedor().buscaProveedorDato(1, this.txtRazonSocial.Text.Trim());
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
      this.dgvBuscaProveedor.Columns.Add("Direccion", "Direccion");
      this.dgvBuscaProveedor.Columns[4].DataPropertyName = "Direccion";
      this.dgvBuscaProveedor.Columns[4].Width = 226;
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
      frmMenuPrincipal._modOrdenCompra = 0;
    }

    private void guardaOrdenCompra()
    {
      if (!this.validaCampos())
        return;
      Venta veOB = new Venta();
      DateTime dateTime1 =DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local1 = @dateTime1;
      DateTime now = this.dtpEmision.Value;
      int year1 = now.Year;
      now = this.dtpEmision.Value;
      int month1 = now.Month;
      now = this.dtpEmision.Value;
      int day1 = now.Day;
      now = DateTime.Now;
      TimeSpan timeOfDay1 = now.TimeOfDay;
      int hours1 = timeOfDay1.Hours;
      now = DateTime.Now;
      timeOfDay1 = now.TimeOfDay;
      int minutes1 = timeOfDay1.Minutes;
      now = DateTime.Now;
      timeOfDay1 = now.TimeOfDay;
      int seconds1 = timeOfDay1.Seconds;
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
      TimeSpan timeOfDay2 = now.TimeOfDay;
      int hours2 = timeOfDay2.Hours;
      now = DateTime.Now;
      timeOfDay2 = now.TimeOfDay;
      int minutes2 = timeOfDay2.Minutes;
      now = DateTime.Now;
      timeOfDay2 = now.TimeOfDay;
      int seconds2 = timeOfDay2.Seconds;
      // ISSUE: explicit reference operation
      local2 = new DateTime(year2, month2, day2, hours2, minutes2, seconds2);
      veOB.FechaEmision = dateTime1;
      veOB.FechaVencimiento = dateTime2;
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
      if (this.cmbMedioPago.SelectedValue.ToString() != "0")
      {
        veOB.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        veOB.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
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
      veOB.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
      veOB.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
      veOB.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
      veOB.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
      veOB.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
      veOB.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
      veOB.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
      NumeroaLetra numeroaLetra = new NumeroaLetra();
      veOB.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
      veOB.EstadoPago = "PAGADO";
      veOB.TotalPagado = veOB.Total;
      veOB.TotalDocumentado = new Decimal(0);
      veOB.TotalPendiente = new Decimal(0);
      veOB.EstadoDocumento = "EMITIDA";
      OrdenCompra ordenCompra = new OrdenCompra();
      if (ordenCompra.ordenCompraExiste(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim())))
        this.obtieneFolioOrdenCompraDisponible();
      veOB.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
      {
        frmOrdenCompra.lista[index].FechaIngreso = veOB.FechaEmision;
        frmOrdenCompra.lista[index].FolioFactura = veOB.Folio;
      }
      try
      {
        ordenCompra.agregaOrdenCompra(veOB);
        try
        {
          ordenCompra.agregaDetalleOrdenCompra(frmOrdenCompra.lista);
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("error " + ex.Message);
        }
        this.imprimeCompra(Convert.ToInt32(this.txtNumeroDocumento.Text));
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar : " + ex.Message);
      }
    }

    public void buscaOrdenCompraFolio(int folio)
    {
      OrdenCompra ordenCompra = new OrdenCompra();
      Venta venta = ordenCompra.buscaOrdenCompraFolio(folio);
      this.veOBCompra = venta;
      if (venta.IdFactura != 0)
      {
        this.iniciaCompra();
        this.cambiarToolStripMenuItem.Enabled = false;
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
        TextBox textBox1 = this.txtNumeroDocumento;
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
        this.txtSubTotal.Text = venta.SubTotal.ToString("N0");
        this.txtTotalDescuento.Text = venta.Descuento.ToString("N0");
        TextBox textBox2 = this.txtPorcDescuentoTotal;
        Decimal num2 = venta.PorcentajeDescuento;
        string str2 = num2.ToString("N0");
        textBox2.Text = str2;
        TextBox textBox3 = this.txtTotalDescuento;
        num2 = venta.Descuento;
        string str3 = num2.ToString("N0");
        textBox3.Text = str3;
        TextBox textBox4 = this.txtNeto;
        num2 = venta.Neto;
        string str4 = num2.ToString("N0");
        textBox4.Text = str4;
        TextBox textBox5 = this.txtIva;
        num2 = venta.Iva;
        string str5 = num2.ToString("N0");
        textBox5.Text = str5;
        TextBox textBox6 = this.txtPorIva;
        num2 = venta.PorcentajeIva;
        string str6 = num2.ToString("N0");
        textBox6.Text = str6;
        TextBox textBox7 = this.txtTotalGeneral;
        num2 = venta.Total;
        string str7 = num2.ToString("N0");
        textBox7.Text = str7;
        this.btnGuardar.Enabled = false;
        this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        this.btnImprime.Enabled = true;
        try
        {
          frmOrdenCompra.lista = ordenCompra.buscaDetalleOrdenCompraIDCompra(venta.IdFactura);
          if (frmOrdenCompra.lista.Count <= 0)
            return;
          for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
            frmOrdenCompra.lista[index].Linea = index + 1;
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmOrdenCompra.lista;
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

    private void imprimeCompra(int folio)
    {
      if (MessageBox.Show("Desea Imprimir la Orden de Compra?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
        this.imprimeDirecto();
      else
        this.iniciaCompra();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaOrdenCompra();
    }

    private void guardarFacturaTeclaF2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.guardaOrdenCompra();
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
      if (MessageBox.Show("Esta Seguro de Modificar la Orden de Compra ", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        if (!this.validaCampos())
          return;
        Venta veOB = new Venta();
        veOB.IdFactura = this.idCompra;
        veOB.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        DateTime dateTime1 =DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local1 = @dateTime1;
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
        veOB.FechaEmision = dateTime1;
        veOB.FechaVencimiento = dateTime2;
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
        if (this.cmbMedioPago.SelectedValue.ToString() != "0")
        {
          veOB.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
          veOB.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
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
        veOB.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
        veOB.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        veOB.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
        veOB.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
        veOB.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
        veOB.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
        NumeroaLetra numeroaLetra = new NumeroaLetra();
        veOB.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
        veOB.EstadoPago = "PAGADO";
        veOB.TotalPagado = veOB.Total;
        veOB.TotalDocumentado = new Decimal(0);
        veOB.TotalPendiente = new Decimal(0);
        OrdenCompra ordenCompra = new OrdenCompra();
        for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
          frmOrdenCompra.lista[index].FechaIngreso = veOB.FechaEmision;
        int num = (int) MessageBox.Show(ordenCompra.modificaOrdenCompra(veOB, frmOrdenCompra.lista));
        this.imprimeCompra(veOB.Folio);
      }
      else
      {
        int num = (int) MessageBox.Show("La Orden de Compra NO fue Modificada.");
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
        int num = (int) MessageBox.Show("Debe Selecciona el Medio de Pago");
        this.cmbMedioPago.Focus();
        return false;
      }
      if (this.txtNumeroDocumento.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Folio del Documento");
        this.txtNumeroDocumento.Focus();
        return false;
      }
      if (Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()) == 0)
      {
        int num = (int) MessageBox.Show("Numero de Folio No Valido");
        this.txtNumeroDocumento.Focus();
        return false;
      }
      if (this.codigoProveedor == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos del Proveedor");
        this.txtRut.Focus();
        return false;
      }
      if (this.txtRut.Text.Trim().Length == 0 || this.txtDigito.Text.Trim().Length == 0 || this.txtRazonSocial.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos del Proveedor");
        this.txtRut.Focus();
        return false;
      }
      if (frmOrdenCompra.lista.Count == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos a Documento");
        this.txtCodigo.Focus();
        return false;
      }
      if (!(Convert.ToDecimal(this.txtTotalGeneral.Text) <= new Decimal(0)))
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Datos a Documento");
      this.txtCodigo.Focus();
      return false;
    }

    private void txtTotalDescuento_TextChanged(object sender, EventArgs e)
    {
      if (this.txtTotalDescuento.ReadOnly)
        return;
      Decimal num1 = new Decimal(0);
      bool flag = false;
      for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
      {
        if (frmOrdenCompra.lista[index].Descuento > new Decimal(0) || frmOrdenCompra.lista[index].PorcDescuento > new Decimal(0))
        {
          flag = true;
          num1 += frmOrdenCompra.lista[index].Descuento;
        }
      }
      if (flag && !this.txtTotalDescuento.ReadOnly)
      {
        if (MessageBox.Show("¿Hay Descuentos aplicados en la lista, Desea Eliminarlos e Ingresar un Descuento General?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
          {
            frmOrdenCompra.lista[index].Descuento = new Decimal(0);
            frmOrdenCompra.lista[index].PorcDescuento = new Decimal(0);
            frmOrdenCompra.lista[index].TotalLinea = frmOrdenCompra.lista[index].ValorVenta * frmOrdenCompra.lista[index].Cantidad;
          }
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmOrdenCompra.lista;
          this.calculaTotales();
        }
        else
        {
          this.txtTotalDescuento.ReadOnly = true;
          this.txtTotalDescuento.Text = num1.ToString("N0");
        }
      }
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new Calculos().totalDescuentoGeneralCompra(this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0), this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0));
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
        int num2 = (int) MessageBox.Show("El Descuento NO debe ser Mayor al SubTotal");
        this.txtTotalDescuento.Text = "0";
        this.txtPorcDescuentoTotal.Clear();
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
      for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
      {
        if (frmOrdenCompra.lista[index].Linea == Convert.ToInt32(this.txtLinea.Text))
        {
          frmOrdenCompra.lista[index].Codigo = this.txtCodigo.Text;
          frmOrdenCompra.lista[index].Descripcion = this.txtDescripcion.Text;
          frmOrdenCompra.lista[index].ValorVenta = Convert.ToDecimal(this.txtPrecio.Text);
          frmOrdenCompra.lista[index].Cantidad = Convert.ToDecimal(this.txtCantidad.Text);
          frmOrdenCompra.lista[index].TotalLinea = Convert.ToDecimal(this.txtTotalLinea.Text);
          frmOrdenCompra.lista[index].Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
          frmOrdenCompra.lista[index].PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
        }
      }
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) frmOrdenCompra.lista;
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
        int num = (int) new frmBuscaProductos("orden_compra", ref this.intance, this.decimalesValoresVenta).ShowDialog();
        this.txtCantidad.Focus();
      }
      if (e.KeyCode == Keys.F6)
      {
        this.panelFolio.Visible = true;
        this.txtFolioBuscar.Focus();
      }
      if (!this._guarda || this.veOBCompra.IdFactura != 0 || e.KeyCode != Keys.F2)
        return;
      this.guardaOrdenCompra();
    }

    private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.txtCodigo.Focus();
      int num = (int) new frmBuscaProductos("orden_compra", ref this.intance, this.decimalesValoresVenta).ShowDialog();
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
      if (frmOrdenCompra.lista.Count <= 0)
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
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar la Orden de Compra.", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        OrdenCompra ordenCompra = new OrdenCompra();
        try
        {
          ordenCompra.eliminaOrdenCompra(this.idCompra, frmOrdenCompra.lista);
          int num = (int) MessageBox.Show("Orden de Compra Eliminada");
          this.iniciaCompra();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar Orden de Compra " + ex.Message);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Orden de Compra NO fue Eliminada ");
        this.iniciaCompra();
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
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void multiEmpresa()
    {
      int numFactura = Convert.ToInt32(this.txtNumeroDocumento.Text);
      OrdenCompra ordenCompra = new OrdenCompra();
      int idOrdenCompra = ordenCompra.retornaIdOrdenCompra(numFactura);
      DataTable dataTable = ordenCompra.muestraOrdenCompraID(idOrdenCompra);
      LeeXml leeXml = new LeeXml();
      ArrayList arrayList = new ArrayList();
      string str = leeXml.cargarDatosMultiEmpresa("cotizacion")[1].ToString();
      ReportDocument rpt = new ReportDocument();
      rpt.Load("C:\\AptuSoft\\reportes\\OrdenCompra_" + str + ".rpt");
      rpt.SetDataSource(dataTable);
      int num = (int) new frmVisualizadorReportes(rpt).ShowDialog();
      this.iniciaCompra();
    }

    private void monoEmpresa()
    {
      int numFactura = Convert.ToInt32(this.txtNumeroDocumento.Text);
      OrdenCompra ordenCompra = new OrdenCompra();
      int idOrdenCompra = ordenCompra.retornaIdOrdenCompra(numFactura);
      DataTable dataTable = ordenCompra.muestraOrdenCompraID(idOrdenCompra);
      ReportDocument reportDocument = new ReportDocument();
      reportDocument.Load("C:\\AptuSoft\\reportes\\OrdenCompra.rpt");
      reportDocument.SetDataSource(dataTable);
      string str = new LeeXml().cargarDatos("otros");
      reportDocument.PrintOptions.PrinterName = str;
      reportDocument.PrintToPrinter(0, false, 1, 1);
      reportDocument.Close();
      this.iniciaCompra();
    }

    private void txtTotalDescuento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtTotalDescuento);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(this.veOBCompra.RazonSocial);
    }

    private void dgvDatosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      int num = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells[0].Value.ToString());
      for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
      {
        if (frmOrdenCompra.lista[index].Linea == num)
        {
          frmOrdenCompra.lista.RemoveAt(index);
          --index;
        }
      }
      this.calculaTotales();
    }

    private void txtDescripcion_Enter(object sender, EventArgs e)
    {
      if (this.txtCodigo.Text.Length <= 0 || this.txtDescripcion.Text.Length != 0)
        return;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim());
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

    private void txtPrecioIva_TextChanged(object sender, EventArgs e)
    {
      if (this.txtPrecio.Text.Length <= 0 || this.txtPrecioIva.Text.Length <= 0)
        return;
      Decimal num1 = Convert.ToDecimal(this.txtPrecioIva.Text.Trim());
      Decimal num2 = new Decimal(19);
      try
      {
          Decimal c8 = num2 / new Decimal(100);
        this.txtPrecio.Text = (num1 / ++c8).ToString("N0");
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

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modCompra = 0;
      this.Close();
      this.Dispose();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modOrdenCompra = 0;
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
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim());
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
      frmOrdenCompra.lista.Clear();
      this.txtSubTotal.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
    }

    private void txtCantidad_Enter(object sender, EventArgs e)
    {
      if (!this.chkCantidadFija.Checked || this.txtCantidad.Text.Length <= 0 || this.txtDescripcion.Text.Length <= 0)
        return;
      this.agregaLineaGrilla();
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

    private void txtPorcDescuentoTotal_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPorcDescuentoTotal);
    }

    private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtNumeroDocumento);
    }

    private void btnCerrarPanelFolio_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = false;
      this.txtFolioBuscar.Clear();
    }

    private void btnBuscaFolio_Click(object sender, EventArgs e)
    {
      this.buscaOrdenCompraFolio(Convert.ToInt32(this.txtFolioBuscar.Text));
      this.panelFolio.Visible = false;
      this.txtFolioBuscar.Clear();
    }

    private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioBuscar);
      if ((int) e.KeyChar != 13)
        return;
      this.buscaOrdenCompraFolio(Convert.ToInt32(this.txtFolioBuscar.Text));
    }

    private void txtPorcDescuentoTotal_DoubleClick(object sender, EventArgs e)
    {
      this.txtPorcDescuentoTotal.ReadOnly = false;
    }

    private void txtPorcDescuentoTotal_Leave(object sender, EventArgs e)
    {
      this.txtPorcDescuentoTotal.ReadOnly = true;
    }

    private void cambiarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.txtNumeroDocumento.Enabled = true;
      this.txtNumeroDocumento.Focus();
    }

    private void buscarOCTeclaF6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Focus();
    }

    private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.pnlCotizacionBuscar.Visible = true;
      this.txtFolioCotizacion.Clear();
      this.txtFolioCotizacion.Focus();
    }

    private void buscaCotizacionFolio()
    {
      this.panelFolio.Visible = false;
      Cotizacion cotizacion = new Cotizacion();
      Venta venta = cotizacion.buscaCotizacionFolio(Convert.ToInt32(this.txtFolioCotizacion.Text.Trim()));
      if (venta.IdFactura != 0)
      {
        this.iniciaCompra();
        frmOrdenCompra.lista = cotizacion.buscaDetalleCotizacionIDCotizacion(venta.IdFactura);
        for (int index = 0; index < frmOrdenCompra.lista.Count; ++index)
        {
          frmOrdenCompra.lista[index].Linea = index + 1;
          frmOrdenCompra.lista[index].ValorVenta = frmOrdenCompra.lista[index].ValorCompra;
          frmOrdenCompra.lista[index].TotalLinea = frmOrdenCompra.lista[index].ValorVenta * frmOrdenCompra.lista[index].Cantidad;
        }
        this.dgvDatosVenta.DataSource = (object) null;
        this.dgvDatosVenta.DataSource = (object) frmOrdenCompra.lista;
        this.calculaTotales();
        this.txtFolioBuscar.Clear();
        this.pnlCotizacionBuscar.Visible = false;
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Cotización Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtFolioBuscar.Clear();
        this.iniciaCompra();
      }
    }

    private void btnBuscaCotizacion_Click(object sender, EventArgs e)
    {
      this.buscaCotizacionFolio();
    }
  }
}
