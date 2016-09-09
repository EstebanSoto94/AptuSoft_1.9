 
// Type: Aptusoft.frmOrdenTrabajo
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft
{
    public class frmOrdenTrabajo : Form
    {
        private IContainer components = (IContainer)null;
        private int idOT = 0;
        private List<DatosVentaVO> lista = new List<DatosVentaVO>();
        private Decimal valorCompra = new Decimal(0);
        private Decimal netoLinea = new Decimal(0);
        private bool _guarda = false;
        private bool _modifica = false;
        private bool _elimina = false;
        private bool _anula = false;
        private bool _descuento = false;
        private bool _cambioPrecio = false;
        private int _caja = 0;
        private int _bodega = 0;
        private int _listaPrecio = 0;
        private bool _modBodega = false;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private GroupBox gbZonaCliente;
        private Button btnBuscaCliente;
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
        private Label lblFolio;
        private TextBox txtNumeroDocumento;
        private GroupBox gbZonaFechas;
        private DateTimePicker dtpEntrega;
        private DateTimePicker dtpEmision;
        private Label label2;
        private Label label1;
        private GroupBox gbZonaOtros;
        private ComboBox cmbEstado;
        private Label label27;
        private GroupBox gbZonaTicket;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txtDatosProductos;
        private TextBox txtSolucion;
        private TextBox txtDiagnostico;
        private GroupBox gbZonaBotones;
        private Label label3;
        private Button btnImprime;
        private Label lblTipoDoc;
        private Button btnSalir;
        private TextBox txtPorIva;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
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
        private Panel panelZonaDetalle;
        private TextBox txtTipoDescuento;
        private TextBox txtSubTotalLinea;
        private Button btnLimpiaLineaDetalle;
        private Button btnModificaLinea;
        private TextBox txtLinea;
        private Panel panel4;
        private Panel panel3;
        private TextBox txtPorcDescuentoLinea;
        private Label label31;
        private TextBox txtCodigo;
        private TextBox txtCantidad;
        private DataGridView dgvDatosVenta;
        private CheckBox chkCantidadFija;
        private Button btnAgregar;
        private TextBox txtDescripcion;
        private Button btnLimpiaDetalle;
        private TextBox txtTotalLinea;
        private Label label20;
        private TextBox txtPrecio;
        private Label label14;
        private TextBox txtDescuento;
        private Label label28;
        private Label label13;
        private Label label15;
        private ComboBox cmbListaPrecio;
        private ComboBox cmbBodega;
        private Label label17;
        private Label label19;
        private Label label29;
        private TextBox txtSaldo;
        private Label label30;
        private TextBox txtAbono;
        private Label label21;
        private TextBox txtTotalCobrado;
        private Label label16;
        private GroupBox groupBox4;
        private ComboBox cmbVendedor;
        private Label label32;
        private Panel panelFolio;
        private Button btnCerrarPanelFolio;
        private Button btnBuscaFolio;
        private TextBox txtFolioBuscar;
        private Label label33;
        private ToolStripMenuItem buscarOTTeclaF6ToolStripMenuItem;
        private ToolStripMenuItem cambiarNumeroDeFolioToolStripMenuItem;
        private ToolStripMenuItem guardarOTTeclaF2ToolStripMenuItem;
        private ToolStripMenuItem buscarProductosTeclaF4ToolStripMenuItem;
        private Label label34;
        private TextBox txtPatente;
        private frmOrdenTrabajo intance;
        private TabPage tabPage3;
        private Button btnAgregarTecnico;
        private DataGridView dgvTecnicos;
        private Button btnAgregarVendedor;
        private DataGridView dgvVendedores;
        private ComboBox cmbTecnico;
        private Label label18;
        private Panel panelTareaTecnico;
        private Button button1;
        private Button btnAceptarTecnico;
        private TextBox txtTareaTecnico;
        private Label label35;
        private Label label36;
        private TextBox txtComisionTarea;
        private int codigoCliente;



        public frmOrdenTrabajo()
        {

            this.InitializeComponent();
            this.creaDGVTecnicos();
            this.creaDGVVendedores();
            this.creaColumnasDetalle();
            this.cargaPermisos();
            this.cargaVendedores();
            this.cargaEstado();
            this.cargaTecnicos();
            this.iniciaFormulario();
            this.cargaIvaInicio();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarOTTeclaF6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarOTTeclaF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosTeclaF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNumeroDeFolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbZonaCliente = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
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
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.gbZonaFechas = new System.Windows.Forms.GroupBox();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.gbZonaOtros = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gbZonaTicket = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDatosProductos = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvDatosVenta = new System.Windows.Forms.DataGridView();
            this.chkCantidadFija = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnLimpiaDetalle = new System.Windows.Forms.Button();
            this.txtTotalLinea = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelTareaTecnico = new System.Windows.Forms.Panel();
            this.label36 = new System.Windows.Forms.Label();
            this.txtComisionTarea = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptarTecnico = new System.Windows.Forms.Button();
            this.txtTareaTecnico = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnAgregarVendedor = new System.Windows.Forms.Button();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.btnAgregarTecnico = new System.Windows.Forms.Button();
            this.dgvTecnicos = new System.Windows.Forms.DataGridView();
            this.gbZonaBotones = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTotalCobrado = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprime = new System.Windows.Forms.Button();
            this.lblTipoDoc = new System.Windows.Forms.Label();
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
            this.panelFolio = new System.Windows.Forms.Panel();
            this.btnCerrarPanelFolio = new System.Windows.Forms.Button();
            this.btnBuscaFolio = new System.Windows.Forms.Button();
            this.txtFolioBuscar = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbZonaCliente.SuspendLayout();
            this.gbZonaFechas.SuspendLayout();
            this.gbZonaOtros.SuspendLayout();
            this.gbZonaTicket.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelZonaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelTareaTecnico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicos)).BeginInit();
            this.gbZonaBotones.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelFolio.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarOTTeclaF6ToolStripMenuItem,
            this.guardarOTTeclaF2ToolStripMenuItem,
            this.buscarProductosTeclaF4ToolStripMenuItem,
            this.cambiarNumeroDeFolioToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarOTTeclaF6ToolStripMenuItem
            // 
            this.buscarOTTeclaF6ToolStripMenuItem.Name = "buscarOTTeclaF6ToolStripMenuItem";
            this.buscarOTTeclaF6ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarOTTeclaF6ToolStripMenuItem.Text = "Buscar OT - tecla [F6]";
            this.buscarOTTeclaF6ToolStripMenuItem.Click += new System.EventHandler(this.buscarOTTeclaF6ToolStripMenuItem_Click);
            // 
            // guardarOTTeclaF2ToolStripMenuItem
            // 
            this.guardarOTTeclaF2ToolStripMenuItem.Name = "guardarOTTeclaF2ToolStripMenuItem";
            this.guardarOTTeclaF2ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.guardarOTTeclaF2ToolStripMenuItem.Text = "Guardar OT - tecla[F2]";
            this.guardarOTTeclaF2ToolStripMenuItem.Click += new System.EventHandler(this.guardarOTTeclaF2ToolStripMenuItem_Click);
            // 
            // buscarProductosTeclaF4ToolStripMenuItem
            // 
            this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
            this.buscarProductosTeclaF4ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
            this.buscarProductosTeclaF4ToolStripMenuItem.Click += new System.EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
            // 
            // cambiarNumeroDeFolioToolStripMenuItem
            // 
            this.cambiarNumeroDeFolioToolStripMenuItem.Name = "cambiarNumeroDeFolioToolStripMenuItem";
            this.cambiarNumeroDeFolioToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cambiarNumeroDeFolioToolStripMenuItem.Text = "Cambiar Numero de Folio";
            this.cambiarNumeroDeFolioToolStripMenuItem.Click += new System.EventHandler(this.cambiarNumeroDeFolioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gbZonaCliente
            // 
            this.gbZonaCliente.Controls.Add(this.label34);
            this.gbZonaCliente.Controls.Add(this.txtPatente);
            this.gbZonaCliente.Controls.Add(this.btnBuscaCliente);
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
            this.gbZonaCliente.Location = new System.Drawing.Point(7, 81);
            this.gbZonaCliente.Name = "gbZonaCliente";
            this.gbZonaCliente.Size = new System.Drawing.Size(869, 102);
            this.gbZonaCliente.TabIndex = 103;
            this.gbZonaCliente.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(342, 81);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 13);
            this.label34.TabIndex = 34;
            this.label34.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.BackColor = System.Drawing.Color.White;
            this.txtPatente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatente.Location = new System.Drawing.Point(392, 77);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(143, 20);
            this.txtPatente.TabIndex = 33;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.Location = new System.Drawing.Point(762, 8);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(102, 67);
            this.btnBuscaCliente.TabIndex = 32;
            this.btnBuscaCliente.Text = "Buscar Cliente";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.White;
            this.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContacto.Location = new System.Drawing.Point(60, 77);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(194, 20);
            this.txtContacto.TabIndex = 14;
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
            this.label11.Location = new System.Drawing.Point(549, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fax";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 59);
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
            this.label8.Location = new System.Drawing.Point(538, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ciudad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 33);
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
            this.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFax.Location = new System.Drawing.Point(580, 55);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(176, 20);
            this.txtFax.TabIndex = 13;
            // 
            // txtFono
            // 
            this.txtFono.BackColor = System.Drawing.Color.White;
            this.txtFono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFono.Location = new System.Drawing.Point(392, 55);
            this.txtFono.Name = "txtFono";
            this.txtFono.Size = new System.Drawing.Size(143, 20);
            this.txtFono.TabIndex = 12;
            // 
            // txtGiro
            // 
            this.txtGiro.BackColor = System.Drawing.Color.White;
            this.txtGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGiro.Location = new System.Drawing.Point(60, 55);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(276, 20);
            this.txtGiro.TabIndex = 11;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Location = new System.Drawing.Point(580, 33);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(176, 20);
            this.txtCiudad.TabIndex = 10;
            // 
            // txtComuna
            // 
            this.txtComuna.BackColor = System.Drawing.Color.White;
            this.txtComuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComuna.Location = new System.Drawing.Point(392, 33);
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(143, 20);
            this.txtComuna.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(60, 33);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(276, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 15);
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
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Location = new System.Drawing.Point(257, 11);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(499, 20);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // txtDigito
            // 
            this.txtDigito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDigito.Location = new System.Drawing.Point(132, 11);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(29, 20);
            this.txtDigito.TabIndex = 6;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRut.Location = new System.Drawing.Point(60, 11);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(68, 20);
            this.txtRut.TabIndex = 5;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(8, 13);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(57, 16);
            this.lblFolio.TabIndex = 5;
            this.lblFolio.Text = "OT. N°:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(8, 29);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(124, 20);
            this.txtNumeroDocumento.TabIndex = 50;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbZonaFechas
            // 
            this.gbZonaFechas.Controls.Add(this.dtpEntrega);
            this.gbZonaFechas.Controls.Add(this.dtpEmision);
            this.gbZonaFechas.Controls.Add(this.cmbVendedor);
            this.gbZonaFechas.Controls.Add(this.label2);
            this.gbZonaFechas.Controls.Add(this.label1);
            this.gbZonaFechas.Controls.Add(this.label32);
            this.gbZonaFechas.Location = new System.Drawing.Point(7, 27);
            this.gbZonaFechas.Name = "gbZonaFechas";
            this.gbZonaFechas.Size = new System.Drawing.Size(362, 58);
            this.gbZonaFechas.TabIndex = 100;
            this.gbZonaFechas.TabStop = false;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(118, 29);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(96, 20);
            this.dtpEntrega.TabIndex = 1;
            // 
            // dtpEmision
            // 
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(6, 29);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(104, 20);
            this.dtpEmision.TabIndex = 0;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(220, 29);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(131, 21);
            this.cmbVendedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Entrega";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Recepción";
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(220, 15);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(131, 23);
            this.label32.TabIndex = 41;
            this.label32.Text = "Vendedor";
            // 
            // gbZonaOtros
            // 
            this.gbZonaOtros.Controls.Add(this.cmbEstado);
            this.gbZonaOtros.Controls.Add(this.label27);
            this.gbZonaOtros.Controls.Add(this.cmbTecnico);
            this.gbZonaOtros.Controls.Add(this.label18);
            this.gbZonaOtros.Location = new System.Drawing.Point(434, 27);
            this.gbZonaOtros.Name = "gbZonaOtros";
            this.gbZonaOtros.Size = new System.Drawing.Size(298, 58);
            this.gbZonaOtros.TabIndex = 101;
            this.gbZonaOtros.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(161, 29);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(131, 21);
            this.cmbEstado.TabIndex = 4;
            this.cmbEstado.SelectedValueChanged += new System.EventHandler(this.cmbEstado_SelectedValueChanged);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(161, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 23);
            this.label27.TabIndex = 21;
            this.label27.Text = "Estado OT";
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTecnico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(19, 30);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(140, 21);
            this.cmbTecnico.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(19, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Técnico";
            // 
            // gbZonaTicket
            // 
            this.gbZonaTicket.Controls.Add(this.lblFolio);
            this.gbZonaTicket.Controls.Add(this.txtNumeroDocumento);
            this.gbZonaTicket.Location = new System.Drawing.Point(738, 27);
            this.gbZonaTicket.Name = "gbZonaTicket";
            this.gbZonaTicket.Size = new System.Drawing.Size(138, 58);
            this.gbZonaTicket.TabIndex = 102;
            this.gbZonaTicket.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 189);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 291);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 104;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSolucion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(577, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solución";
            // 
            // txtSolucion
            // 
            this.txtSolucion.BackColor = System.Drawing.Color.White;
            this.txtSolucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolucion.Location = new System.Drawing.Point(5, 22);
            this.txtSolucion.Multiline = true;
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolucion.Size = new System.Drawing.Size(271, 222);
            this.txtSolucion.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDiagnostico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(291, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnostico";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BackColor = System.Drawing.Color.White;
            this.txtDiagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(5, 22);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(271, 222);
            this.txtDiagnostico.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDatosProductos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // txtDatosProductos
            // 
            this.txtDatosProductos.BackColor = System.Drawing.Color.White;
            this.txtDatosProductos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDatosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatosProductos.Location = new System.Drawing.Point(5, 22);
            this.txtDatosProductos.Multiline = true;
            this.txtDatosProductos.Name = "txtDatosProductos";
            this.txtDatosProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDatosProductos.Size = new System.Drawing.Size(271, 222);
            this.txtDatosProductos.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage2.Controls.Add(this.panelZonaDetalle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Valorizacion";
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
            this.panelZonaDetalle.Location = new System.Drawing.Point(2, 3);
            this.panelZonaDetalle.Name = "panelZonaDetalle";
            this.panelZonaDetalle.Size = new System.Drawing.Size(888, 256);
            this.panelZonaDetalle.TabIndex = 40;
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
            this.btnLimpiaLineaDetalle.Location = new System.Drawing.Point(836, 3);
            this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
            this.btnLimpiaLineaDetalle.Size = new System.Drawing.Size(20, 34);
            this.btnLimpiaLineaDetalle.TabIndex = 33;
            this.btnLimpiaLineaDetalle.Text = "..";
            this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaLineaDetalle.Click += new System.EventHandler(this.btnLimpiaLineaDetalle_Click);
            // 
            // btnModificaLinea
            // 
            this.btnModificaLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaLinea.Location = new System.Drawing.Point(640, 41);
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
            this.panel4.Location = new System.Drawing.Point(734, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 36);
            this.panel4.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(614, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 36);
            this.panel3.TabIndex = 30;
            // 
            // txtPorcDescuentoLinea
            // 
            this.txtPorcDescuentoLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcDescuentoLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcDescuentoLinea.Location = new System.Drawing.Point(621, 18);
            this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
            this.txtPorcDescuentoLinea.Size = new System.Drawing.Size(31, 20);
            this.txtPorcDescuentoLinea.TabIndex = 13;
            this.txtPorcDescuentoLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoLinea.TextChanged += new System.EventHandler(this.txtPorcDescuentoLinea_TextChanged);
            this.txtPorcDescuentoLinea.Enter += new System.EventHandler(this.txtPorcDescuentoLinea_Enter);
            this.txtPorcDescuentoLinea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPorcDescuentoLinea_KeyDown);
            this.txtPorcDescuentoLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(621, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 23);
            this.label31.TabIndex = 29;
            this.label31.Text = "%";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(2, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(537, 18);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtPorcDescuentoLinea_Enter);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // dgvDatosVenta
            // 
            this.dgvDatosVenta.AllowUserToAddRows = false;
            this.dgvDatosVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvDatosVenta.Size = new System.Drawing.Size(854, 178);
            this.dgvDatosVenta.TabIndex = 3;
            this.dgvDatosVenta.TabStop = false;
            this.dgvDatosVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
            this.dgvDatosVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
            // 
            // chkCantidadFija
            // 
            this.chkCantidadFija.AutoSize = true;
            this.chkCantidadFija.Location = new System.Drawing.Point(597, 25);
            this.chkCantidadFija.Name = "chkCantidadFija";
            this.chkCantidadFija.Size = new System.Drawing.Size(15, 14);
            this.chkCantidadFija.TabIndex = 16;
            this.chkCantidadFija.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(721, 40);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(55, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(107, 18);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(349, 20);
            this.txtDescripcion.TabIndex = 10;
            // 
            // btnLimpiaDetalle
            // 
            this.btnLimpiaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiaDetalle.Location = new System.Drawing.Point(779, 40);
            this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
            this.btnLimpiaDetalle.Size = new System.Drawing.Size(55, 23);
            this.btnLimpiaDetalle.TabIndex = 17;
            this.btnLimpiaDetalle.Text = "Limpiar";
            this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
            // 
            // txtTotalLinea
            // 
            this.txtTotalLinea.BackColor = System.Drawing.Color.White;
            this.txtTotalLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalLinea.Enabled = false;
            this.txtTotalLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLinea.Location = new System.Drawing.Point(741, 18);
            this.txtTotalLinea.Name = "txtTotalLinea";
            this.txtTotalLinea.Size = new System.Drawing.Size(92, 20);
            this.txtTotalLinea.TabIndex = 15;
            this.txtTotalLinea.TabStop = false;
            this.txtTotalLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(741, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 23);
            this.label20.TabIndex = 7;
            this.label20.Text = "Total";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(459, 18);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(107, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(349, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Descripcion";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(654, 18);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(77, 20);
            this.txtDescuento.TabIndex = 14;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(5, 46);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Bodega";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(2, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Codigo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(459, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Precio";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(274, 42);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(126, 21);
            this.cmbListaPrecio.TabIndex = 18;
            // 
            // cmbBodega
            // 
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(55, 42);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(126, 21);
            this.cmbBodega.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(537, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Cantidad";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(654, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 23);
            this.label19.TabIndex = 6;
            this.label19.Text = "$ Descuento";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(194, 46);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Lista de Precio";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelTareaTecnico);
            this.tabPage3.Controls.Add(this.btnAgregarVendedor);
            this.tabPage3.Controls.Add(this.dgvVendedores);
            this.tabPage3.Controls.Add(this.btnAgregarTecnico);
            this.tabPage3.Controls.Add(this.dgvTecnicos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(865, 265);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Técnicos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelTareaTecnico
            // 
            this.panelTareaTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTareaTecnico.Controls.Add(this.label36);
            this.panelTareaTecnico.Controls.Add(this.txtComisionTarea);
            this.panelTareaTecnico.Controls.Add(this.button1);
            this.panelTareaTecnico.Controls.Add(this.btnAceptarTecnico);
            this.panelTareaTecnico.Controls.Add(this.txtTareaTecnico);
            this.panelTareaTecnico.Controls.Add(this.label35);
            this.panelTareaTecnico.Location = new System.Drawing.Point(92, 75);
            this.panelTareaTecnico.Name = "panelTareaTecnico";
            this.panelTareaTecnico.Size = new System.Drawing.Size(302, 156);
            this.panelTareaTecnico.TabIndex = 107;
            this.panelTareaTecnico.Visible = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(204, 53);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(73, 13);
            this.label36.TabIndex = 26;
            this.label36.Text = "Comisión en $";
            // 
            // txtComisionTarea
            // 
            this.txtComisionTarea.Location = new System.Drawing.Point(206, 69);
            this.txtComisionTarea.Name = "txtComisionTarea";
            this.txtComisionTarea.Size = new System.Drawing.Size(71, 20);
            this.txtComisionTarea.TabIndex = 2;
            this.txtComisionTarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComisionTarea_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(274, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptarTecnico
            // 
            this.btnAceptarTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarTecnico.Location = new System.Drawing.Point(25, 121);
            this.btnAceptarTecnico.Name = "btnAceptarTecnico";
            this.btnAceptarTecnico.Size = new System.Drawing.Size(264, 25);
            this.btnAceptarTecnico.TabIndex = 3;
            this.btnAceptarTecnico.Text = "Aceptar";
            this.btnAceptarTecnico.UseVisualStyleBackColor = true;
            this.btnAceptarTecnico.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTareaTecnico
            // 
            this.txtTareaTecnico.Location = new System.Drawing.Point(26, 33);
            this.txtTareaTecnico.MaxLength = 200;
            this.txtTareaTecnico.Multiline = true;
            this.txtTareaTecnico.Name = "txtTareaTecnico";
            this.txtTareaTecnico.Size = new System.Drawing.Size(162, 82);
            this.txtTareaTecnico.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(58, 8);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(181, 16);
            this.label35.TabIndex = 0;
            this.label35.Text = "Ingrese Tarea Realizada";
            // 
            // btnAgregarVendedor
            // 
            this.btnAgregarVendedor.Location = new System.Drawing.Point(589, 11);
            this.btnAgregarVendedor.Name = "btnAgregarVendedor";
            this.btnAgregarVendedor.Size = new System.Drawing.Size(101, 23);
            this.btnAgregarVendedor.TabIndex = 42;
            this.btnAgregarVendedor.Text = "Agregar Vendedor";
            this.btnAgregarVendedor.UseVisualStyleBackColor = true;
            this.btnAgregarVendedor.Visible = false;
            this.btnAgregarVendedor.Click += new System.EventHandler(this.btnAgregarVendedor_Click);
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendedores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVendedores.Location = new System.Drawing.Point(445, 47);
            this.dgvVendedores.MultiSelect = false;
            this.dgvVendedores.Name = "dgvVendedores";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVendedores.RowHeadersVisible = false;
            this.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedores.Size = new System.Drawing.Size(414, 215);
            this.dgvVendedores.TabIndex = 28;
            this.dgvVendedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedores_CellClick);
            // 
            // btnAgregarTecnico
            // 
            this.btnAgregarTecnico.Location = new System.Drawing.Point(174, 11);
            this.btnAgregarTecnico.Name = "btnAgregarTecnico";
            this.btnAgregarTecnico.Size = new System.Drawing.Size(101, 23);
            this.btnAgregarTecnico.TabIndex = 27;
            this.btnAgregarTecnico.Text = "Agregar Técnico";
            this.btnAgregarTecnico.UseVisualStyleBackColor = true;
            this.btnAgregarTecnico.Visible = false;
            this.btnAgregarTecnico.Click += new System.EventHandler(this.btnAgregarTecnico_Click);
            // 
            // dgvTecnicos
            // 
            this.dgvTecnicos.AllowUserToAddRows = false;
            this.dgvTecnicos.AllowUserToDeleteRows = false;
            this.dgvTecnicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTecnicos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTecnicos.Location = new System.Drawing.Point(7, 47);
            this.dgvTecnicos.MultiSelect = false;
            this.dgvTecnicos.Name = "dgvTecnicos";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTecnicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTecnicos.RowHeadersVisible = false;
            this.dgvTecnicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTecnicos.Size = new System.Drawing.Size(407, 215);
            this.dgvTecnicos.TabIndex = 26;
            this.dgvTecnicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTecnicos_CellClick);
            // 
            // gbZonaBotones
            // 
            this.gbZonaBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.gbZonaBotones.Controls.Add(this.groupBox4);
            this.gbZonaBotones.Controls.Add(this.label3);
            this.gbZonaBotones.Controls.Add(this.btnImprime);
            this.gbZonaBotones.Controls.Add(this.lblTipoDoc);
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
            this.gbZonaBotones.Location = new System.Drawing.Point(7, 477);
            this.gbZonaBotones.Name = "gbZonaBotones";
            this.gbZonaBotones.Size = new System.Drawing.Size(873, 151);
            this.gbZonaBotones.TabIndex = 105;
            this.gbZonaBotones.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtSaldo);
            this.groupBox4.Controls.Add(this.txtTotalCobrado);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtAbono);
            this.groupBox4.Location = new System.Drawing.Point(427, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 85);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(5, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "TOTAL COBRADO";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.ForeColor = System.Drawing.Color.Black;
            this.txtSaldo.Location = new System.Drawing.Point(119, 56);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(103, 21);
            this.txtSaldo.TabIndex = 34;
            this.txtSaldo.TabStop = false;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalCobrado
            // 
            this.txtTotalCobrado.BackColor = System.Drawing.Color.White;
            this.txtTotalCobrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCobrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCobrado.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCobrado.Location = new System.Drawing.Point(119, 12);
            this.txtTotalCobrado.Name = "txtTotalCobrado";
            this.txtTotalCobrado.Size = new System.Drawing.Size(103, 21);
            this.txtTotalCobrado.TabIndex = 30;
            this.txtTotalCobrado.TabStop = false;
            this.txtTotalCobrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCobrado.TextChanged += new System.EventHandler(this.txtTotalCobrado_TextChanged);
            this.txtTotalCobrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalCobrado_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(68, 60);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "SALDO";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(66, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "ABONO";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAbono
            // 
            this.txtAbono.BackColor = System.Drawing.Color.White;
            this.txtAbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.ForeColor = System.Drawing.Color.Black;
            this.txtAbono.Location = new System.Drawing.Point(119, 34);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(103, 21);
            this.txtAbono.TabIndex = 32;
            this.txtAbono.TabStop = false;
            this.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAbono.TextChanged += new System.EventHandler(this.txtAbono_TextChanged);
            this.txtAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "ORDEN DE TRABAJO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(274, 63);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(88, 23);
            this.btnImprime.TabIndex = 26;
            this.btnImprime.Text = "RE-IMPRIMIR";
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ForeColor = System.Drawing.Color.Red;
            this.lblTipoDoc.Location = new System.Drawing.Point(330, 14);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(24, 33);
            this.lblTipoDoc.TabIndex = 25;
            this.lblTipoDoc.Text = ".";
            this.lblTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(274, 89);
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
            this.txtPorIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorIva.ForeColor = System.Drawing.Color.Black;
            this.txtPorIva.Location = new System.Drawing.Point(754, 92);
            this.txtPorIva.Name = "txtPorIva";
            this.txtPorIva.Size = new System.Drawing.Size(24, 21);
            this.txtPorIva.TabIndex = 11;
            this.txtPorIva.TabStop = false;
            this.txtPorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(185, 89);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 63);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "GUARDA [F2]";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(185, 63);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(96, 63);
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
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubTotal.Location = new System.Drawing.Point(754, 26);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(103, 21);
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
            this.txtTotalGeneral.ForeColor = System.Drawing.Color.Black;
            this.txtTotalGeneral.Location = new System.Drawing.Point(754, 114);
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
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.ForeColor = System.Drawing.Color.Black;
            this.txtIva.Location = new System.Drawing.Point(780, 92);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(77, 21);
            this.txtIva.TabIndex = 8;
            this.txtIva.TabStop = false;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNeto
            // 
            this.txtNeto.BackColor = System.Drawing.Color.White;
            this.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto.Enabled = false;
            this.txtNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeto.ForeColor = System.Drawing.Color.Black;
            this.txtNeto.Location = new System.Drawing.Point(754, 70);
            this.txtNeto.Name = "txtNeto";
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
            this.txtTotalDescuento.Location = new System.Drawing.Point(780, 48);
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
            this.txtPorcDescuentoTotal.Location = new System.Drawing.Point(754, 48);
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
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(703, 118);
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
            this.label25.Location = new System.Drawing.Point(715, 96);
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
            this.label24.Location = new System.Drawing.Point(709, 74);
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
            this.label23.Location = new System.Drawing.Point(667, 52);
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
            this.label22.Location = new System.Drawing.Point(678, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "SUBTOTAL";
            // 
            // panelFolio
            // 
            this.panelFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFolio.Controls.Add(this.btnCerrarPanelFolio);
            this.panelFolio.Controls.Add(this.btnBuscaFolio);
            this.panelFolio.Controls.Add(this.txtFolioBuscar);
            this.panelFolio.Controls.Add(this.label33);
            this.panelFolio.Location = new System.Drawing.Point(693, 79);
            this.panelFolio.Name = "panelFolio";
            this.panelFolio.Size = new System.Drawing.Size(229, 92);
            this.panelFolio.TabIndex = 106;
            // 
            // btnCerrarPanelFolio
            // 
            this.btnCerrarPanelFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPanelFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPanelFolio.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarPanelFolio.Location = new System.Drawing.Point(188, 1);
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
            // frmOrdenTrabajo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panelFolio);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbZonaBotones);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbZonaOtros);
            this.Controls.Add(this.gbZonaFechas);
            this.Controls.Add(this.gbZonaTicket);
            this.Controls.Add(this.gbZonaCliente);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOrdenTrabajo";
            this.ShowIcon = false;
            this.Text = "Orden de Trabajo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdenTrabajo_FormClosing);
            this.Load += new System.EventHandler(this.frmOrdenTrabajo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOrdenTrabajo_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbZonaCliente.ResumeLayout(false);
            this.gbZonaCliente.PerformLayout();
            this.gbZonaFechas.ResumeLayout(false);
            this.gbZonaOtros.ResumeLayout(false);
            this.gbZonaTicket.ResumeLayout(false);
            this.gbZonaTicket.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelZonaDetalle.ResumeLayout(false);
            this.panelZonaDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panelTareaTecnico.ResumeLayout(false);
            this.panelTareaTecnico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicos)).EndInit();
            this.gbZonaBotones.ResumeLayout(false);
            this.gbZonaBotones.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelFolio.ResumeLayout(false);
            this.panelFolio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cargaIvaInicio()
        {
            this.txtPorIva.Text = new Calculos()._iva.ToString("N0");
        }

        private void cargaPermisos()
        {
            foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
            {
                if (usuarioVo.Modulo.Equals("ORDEN TRABAJO"))
                {
                    this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
                    this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
                    this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
                    this._descuento = Convert.ToBoolean(usuarioVo.Descuento);
                    this._cambioPrecio = Convert.ToBoolean(usuarioVo.CambioPrecio);
                    this._caja = usuarioVo.IdCaja;
                    this._bodega = usuarioVo.IdBodega;
                    this._listaPrecio = usuarioVo.IdListaPrecio;
                }
            }
        }

        private void cargaVendedores()
        {
            this.cmbVendedor.DataSource = (object)new Vendedor().listaVendedoresVenta();
            this.cmbVendedor.ValueMember = "idVendedor";
            this.cmbVendedor.DisplayMember = "nombre";
            this.cmbVendedor.SelectedValue = (object)0;
        }

        private void cargaTecnicos()
        {
            this.cmbTecnico.DataSource = (object)new Tecnico().listaTecnicos();
            this.cmbTecnico.ValueMember = "idVendedor";
            this.cmbTecnico.DisplayMember = "nombre";
            this.cmbTecnico.SelectedValue = (object)0;
        }

        private void cargaEstado()
        {
            this.cmbEstado.DataSource = (object)new CargaMaestros().listaEstadoOrdenTrabajo();
            this.cmbEstado.ValueMember = "IdBodega";
            this.cmbEstado.DisplayMember = "NombreBodega";
            this.cmbEstado.SelectedValue = (object)0;
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

        private void obtieneFolioOTDisponible()
        {
            this.txtNumeroDocumento.Text = new OrdenTrabajo().obtieneFolioOT(this._caja).ToString();
            this.txtNumeroDocumento.Enabled = false;
            this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = true;
        }

        private void iniciaFormulario()
        {
            this.idOT = 0;
            this.dtpEmision.Value = DateTime.Now;
            this.dtpEntrega.Value = DateTime.Now;
            this.obtieneFolioOTDisponible();
            this.codigoCliente = 0;
            this.txtRut.Clear();
            this.txtDigito.Clear();
            this.txtRazonSocial.Clear();
            this.txtDireccion.Clear();
            this.txtComuna.Clear();
            this.txtCiudad.Clear();
            this.txtGiro.Clear();
            this.txtFono.Clear();
            this.txtFax.Clear();
            this.txtContacto.Clear();
            this.txtPatente.Clear();
            this.txtDatosProductos.Clear();
            this.txtDiagnostico.Clear();
            this.txtSolucion.Clear();
            this.txtTotalCobrado.Clear();
            this.txtAbono.Clear();
            this.txtSaldo.Clear();
            this.txtSubTotal.Clear();
            this.txtNeto.Clear();
            this.txtIva.Clear();
            this.txtTotalDescuento.Clear();
            this.txtPorcDescuentoTotal.Clear();
            this.txtTotalGeneral.Clear();
            this.cmbVendedor.SelectedValue = (object)0;
            this.cmbEstado.SelectedValue = (object)0;
            this.cmbTecnico.SelectedValue = (object)0;
            this.cargaBodega();
            this.cargaListaPrecio();
            this.lista.Clear();
            this.dgvDatosVenta.DataSource = (object)null;
            if (this._guarda)
                this.btnGuardar.Enabled = true;
            else
                this.btnGuardar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnImprime.Enabled = false;
            this.iniciaDetalle();
            this.panelFolio.Visible = false;
            this.txtFolioBuscar.Clear();
            this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = true;
        }

        private void iniciaDetalle()
        {
            this.txtCodigo.Clear();
            this.txtDescripcion.Clear();
            if (!this.chkCantidadFija.Checked)
                this.txtCantidad.Clear();
            this.txtPrecio.Clear();
            this.txtDescuento.Clear();
            this.txtPorcDescuentoLinea.Clear();
            this.txtTotalLinea.Clear();
            this.txtLinea.Clear();
            this.txtSubTotalLinea.Clear();
            this.txtTipoDescuento.Text = "0";
            this.valorCompra = new Decimal(0);
            this.btnAgregar.Visible = true;
            this.btnAgregar.Enabled = true;
            this.btnLimpiaDetalle.Enabled = true;
            this.btnModificaLinea.Visible = false;
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
            this.dgvDatosVenta.Columns[2].Width = 270;
            this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
            this.dgvDatosVenta.Columns.Add("ValorVenta", "Precio");
            this.dgvDatosVenta.Columns[3].DataPropertyName = "ValorVenta";
            this.dgvDatosVenta.Columns[3].Width = 80;
            this.dgvDatosVenta.Columns[3].DefaultCellStyle.Format = "C0";
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
            this.dgvDatosVenta.Columns[6].DefaultCellStyle.Format = "C0";
            this.dgvDatosVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
            this.dgvDatosVenta.Columns.Add("Total", "Total");
            this.dgvDatosVenta.Columns[7].DataPropertyName = "TotalLinea";
            this.dgvDatosVenta.Columns[7].Width = 90;
            this.dgvDatosVenta.Columns[7].DefaultCellStyle.Format = "C0";
            this.dgvDatosVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
            this.dgvDatosVenta.Columns.Add("SubTotal", "SubTotal");
            this.dgvDatosVenta.Columns[8].DataPropertyName = "SubTotalLinea";
            this.dgvDatosVenta.Columns[8].Width = 90;
            this.dgvDatosVenta.Columns[8].DefaultCellStyle.Format = "C0";
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
            this.dgvDatosVenta.Columns[16].DefaultCellStyle.Format = "C0";
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
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal._modOT = 0;
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal._modOT = 0;
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            creaDGVVendedores();
            creaDGVTecnicos();
            this.iniciaFormulario();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            int num = (int)new frmBuscaClientes(ref this.intance, "ordenTrabajo").ShowDialog();
        }

        private void buscaCliente()
        {
            ArrayList arrayList = new ArrayList();
            ArrayList cli = new Cliente().buscaRutCliente(this.txtRut.Text.Trim());
            if (cli.Count > 1)
            {
                this.txtRazonSocial.Enabled = false;
                int num = (int)new frmClienteMismoRut(cli, ref this.intance, "ordenTrabajo").ShowDialog();
            }
            else if (cli.Count == 0)
            {
                if (MessageBox.Show("No Existe Cliente Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    new frmClientes(this.txtRut.Text.Trim(), this.txtDigito.Text.Trim()).Show();
                else
                    this.iniciaFormulario();
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
                int num = (int)MessageBox.Show("Debe Ingresar RUT a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtRut.Focus();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0)
                return;
            e.Handled = false;
            this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
        }

        public void llamaProductoCodigo(string cod, int bodega)
        {
            this.cmbBodega.SelectedValue = (object)bodega.ToString();
            ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
            if (productoVo.Codigo != null)
            {
                int num1 = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
                Decimal num2;
                if (num1 == 1)
                {
                    TextBox textBox = this.txtPrecio;
                    num2 = productoVo.ValorVenta1;
                    string str = num2.ToString("##");
                    textBox.Text = str;
                }
                if (num1 == 2)
                {
                    TextBox textBox = this.txtPrecio;
                    num2 = productoVo.ValorVenta2;
                    string str = num2.ToString("##");
                    textBox.Text = str;
                }
                if (num1 == 3)
                {
                    TextBox textBox = this.txtPrecio;
                    num2 = productoVo.ValorVenta3;
                    string str = num2.ToString("##");
                    textBox.Text = str;
                }
                this.txtCodigo.Text = productoVo.Codigo;
                this.txtDescripcion.Text = productoVo.Descripcion;
                this.valorCompra = productoVo.ValorCompra;
                this.txtCantidad.Focus();
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe el Codigo Ingresado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtCodigo.Clear();
                this.txtCodigo.Focus();
            }
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
                this.txtSubTotalLinea.Text = subTotal.ToString("##");
                this.txtDescuento.Text = descuento.ToString("##");
                this.txtPorcDescuentoLinea.Text = porDesc.ToString("##");
                Decimal total = Convert.ToDecimal(calculos.totalLinea(subTotal, descuento));
                this.txtTotalLinea.Text = total.ToString("##");
                this.netoLinea = calculos.netoLinea(total, 0);
            }
            else
            {
                int num4 = (int)MessageBox.Show("El Descuento debe ser Menor al Total!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtDescuento.Clear();
                this.txtPorcDescuentoLinea.Clear();
            }
        }

        private void btnLimpiaLineaDetalle_Click(object sender, EventArgs e)
        {
            this.iniciaDetalle();
        }

        private void txtPorcDescuentoLinea_Enter(object sender, EventArgs e)
        {
            if (this.txtPrecio.Text.Length > 0 && this.txtCantidad.Text.Length > 0)
            {
                this.txtTipoDescuento.Text = "1";
            }
            else
            {
                int num = (int)MessageBox.Show("Debe Ingresar Datos antes de hacer un Descuento", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtPrecio.Focus();
            }
        }

        private void txtPorcDescuentoLinea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right)
                return;
            this.txtDescuento.Focus();
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

        private void txtPorcDescuentoLinea_TextChanged(object sender, EventArgs e)
        {
            this.calculaTotalLinea();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            this.calculaTotalLinea();
        }

        private void txtDescuento_Enter(object sender, EventArgs e)
        {
            if (this.txtPrecio.Text.Length > 0 && this.txtCantidad.Text.Length > 0)
            {
                this.txtTipoDescuento.Text = "2";
            }
            else
            {
                int num = (int)MessageBox.Show("Debe Ingresar Datos antes de hacer un Descuento", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtPrecio.Focus();
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (!this.chkCantidadFija.Checked || this.txtCantidad.Text.Length <= 0 || this.txtDescripcion.Text.Length <= 0)
                return;
            this.agregaLineaGrilla();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
                return;
            this.txtPorcDescuentoLinea.Focus();
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

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            this.calculaTotalLinea();
        }

        public void agregaLineaGrilla()
        {
            this.txtTotalDescuento.ReadOnly = true;
            this.txtPorcDescuentoTotal.ReadOnly = true;
            DatosVentaVO datosVentaVo = new DatosVentaVO();
            datosVentaVo.Codigo = this.txtCodigo.Text.Trim().ToUpper();
            datosVentaVo.Descripcion = this.txtDescripcion.Text.Trim().ToUpper();
            datosVentaVo.IdImpuesto = 0;
            datosVentaVo.NetoLinea = this.netoLinea;
            datosVentaVo.DescuentaInventario = true;
            datosVentaVo.ValorCompra = this.valorCompra;
            datosVentaVo.ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
            datosVentaVo.Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
            datosVentaVo.Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
            datosVentaVo.PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
            datosVentaVo.TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
            datosVentaVo.SubTotalLinea = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text) : new Decimal(0);
            datosVentaVo.TipoDescuento = Convert.ToInt32(this.txtTipoDescuento.Text);
            datosVentaVo.ListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
            datosVentaVo.Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
            datosVentaVo.FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
            if (this.lista.Count > 0)
            {
                bool flag = false;
                for (int index = 0; index < this.lista.Count; ++index)
                {
                    if (datosVentaVo.Codigo.Length > 0 && datosVentaVo.Codigo == this.lista[index].Codigo && (datosVentaVo.ValorVenta == this.lista[index].ValorVenta && datosVentaVo.ListaPrecio == this.lista[index].ListaPrecio) && datosVentaVo.Bodega == this.lista[index].Bodega && datosVentaVo.DescuentaInventario == this.lista[index].DescuentaInventario)
                    {
                        flag = true;
                        Calculos calculos = new Calculos();
                        this.lista[index].Cantidad = this.lista[index].Cantidad + datosVentaVo.Cantidad;
                        this.lista[index].PorcDescuento = new Decimal(0);
                        Decimal cantidad = this.lista[index].Cantidad;
                        Decimal valorVenta = this.lista[index].ValorVenta;
                        Decimal num1 = new Decimal(0);
                        Decimal descuento = this.lista[index].Descuento + datosVentaVo.Descuento;
                        int tipoDescuento = this.lista[index].TipoDescuento;
                        Decimal subTotal = calculos.subTotalLinea(valorVenta, cantidad);
                        if (subTotal == new Decimal(0) || subTotal > descuento)
                        {
                            this.lista[index].SubTotalLinea = subTotal;
                            this.lista[index].Descuento = descuento;
                            this.lista[index].TotalLinea = calculos.totalLinea(subTotal, descuento);
                            this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, 0);
                            this.lista[index].NetoLinea = this.netoLinea;
                        }
                        else
                        {
                            int num2 = (int)MessageBox.Show("El Descuento debe ser Menor al Total!!");
                        }
                        index = Enumerable.Count<DatosVentaVO>((IEnumerable<DatosVentaVO>)this.lista);
                        this.iniciaDetalle();
                        this.calculaTotales();
                        this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
                    }
                }
                if (!flag)
                {
                    this.lista.Add(datosVentaVo);
                    this.iniciaDetalle();
                    this.calculaTotales();
                    this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
                }
            }
            else
            {
                this.lista.Add(datosVentaVo);
                this.iniciaDetalle();
                this.calculaTotales();
                this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
            }
            this.txtCodigo.Focus();
        }

        private void calculaTotales()
        {
            this.dgvDatosVenta.DataSource = (object)null;
            this.dgvDatosVenta.DataSource = (object)this.lista;
            for (int index = 0; index < this.lista.Count; ++index)
                this.lista[index].Linea = index + 1;
            Calculos calculos = new Calculos();
            Decimal num1 = new Decimal(0);
            Decimal num2 = new Decimal(0);
            Decimal num3 = new Decimal(0);
            this.txtTotalGeneral.Text = calculos.totalGeneral2(this.lista).ToString("N0");
            this.txtTotalDescuento.Text = calculos.totalDescuento(this.lista).ToString("N0");
            Decimal neto = calculos.totalNeto2(this.lista);
            this.txtSubTotal.Text = calculos.totalSubTotal(this.lista).ToString("N0");
            this.txtIva.Text = calculos.totalIva(neto).ToString("N0");
            this.txtNeto.Text = neto.ToString("N0");
        }

        private void modificaLinea()
        {
            string str = this.txtCantidad.Text.Trim().Length > 0 ? this.txtCantidad.Text : "0";
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
                    this.lista[index].NetoLinea = this.netoLinea;
                }
            }
            this.dgvDatosVenta.DataSource = (object)null;
            this.dgvDatosVenta.DataSource = (object)this.lista;
            this.iniciaDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardaModificaOT();
        }

        private Venta armaOT()
        {
            DateTime dateTime1 = DateTime.Now;
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
            DateTime dateTime2 = DateTime.Now;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            DateTime local2 = @dateTime2;
            DateTime now2 = this.dtpEntrega.Value;
            int year2 = now2.Year;
            now2 = this.dtpEntrega.Value;
            int month2 = now2.Month;
            now2 = this.dtpEntrega.Value;
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
            Venta venta = new Venta();
            venta.IdFactura = this.idOT;
            venta.Caja = this._caja;
            venta.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
            venta.FechaEmision = dateTime1;
            venta.FechaVencimiento = dateTime2;
            if (this.cmbVendedor.SelectedValue.ToString() != "0")
            {
                venta.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
                venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
            }
            else
            {
                venta.IdVendedor = 0;
                venta.Vendedor = "";
            }
            if (this.cmbTecnico.SelectedValue.ToString() != "0")
            {
                venta.IdTecnicoOT = Convert.ToInt32(this.cmbTecnico.SelectedValue.ToString());
                venta.TecnicoOT = this.cmbTecnico.Text.ToString().ToUpper();
            }
            else
            {
                venta.IdTecnicoOT = 0;
                venta.TecnicoOT = "";
            }
            venta.IdEstadoOT = Convert.ToInt32(this.cmbEstado.SelectedValue.ToString());
            venta.EstadoOT = this.cmbEstado.Text.ToString().ToUpper();
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
            venta.Patente = this.txtPatente.Text;
            venta.DatosProducto = this.txtDatosProductos.Text.Trim();
            venta.Diagnostico = this.txtDiagnostico.Text.Trim();
            venta.Solucion = this.txtSolucion.Text.Trim();
            venta.TotalCobradoOT = this.txtTotalCobrado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalCobrado.Text.Trim()) : new Decimal(0);
            venta.AbonoOT = this.txtAbono.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtAbono.Text.Trim()) : new Decimal(0);
            venta.SaldoOT = this.txtSaldo.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSaldo.Text.Trim()) : new Decimal(0);
            venta.SubTotal = this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0);
            venta.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
            venta.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
            venta.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
            venta.Iva = this.txtIva.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtIva.Text.Trim()) : new Decimal(0);
            venta.Neto = this.txtNeto.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtNeto.Text.Trim()) : new Decimal(0);
            venta.Total = this.txtTotalGeneral.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalGeneral.Text.Trim()) : new Decimal(0);
            return venta;
        }

        private bool valida()
        {
            return this.txtRazonSocial.Text.Trim().Length != 0;
        }

        private void guardaModificaOT()
        {
            if (!this.valida())
                return;
            OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
            if (this.idOT == 0)
            {
                try
                {
                    if (ordenTrabajo.otExiste(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim())))
                        this.obtieneFolioOTDisponible();
                    ordenTrabajo.agregaOT(this.armaOT(), this.lista);
                    int num = (int)MessageBox.Show("Orden de Trabajo Registrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Error al Eliminar " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Esta Seguro de Modificar la OT ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ordenTrabajo.actualizaOT(this.armaOT(), this.lista);
                        int num = (int)MessageBox.Show("Orden de Trabajo Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        int num1 = (int)MessageBox.Show("La OT No fue Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Error al Modificar " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (MessageBox.Show("Desea Imprimir la Orden de Trabajo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.imprimeDirecto();
            else
                this.iniciaFormulario();
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar != 13)
                return;
            e.Handled = false;
            this.txtDigito.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.agregaLineaGrilla();
        }

        private void calculaSaldo()
        {
            this.txtSaldo.Text = ((this.txtTotalCobrado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalCobrado.Text.Trim()) : new Decimal(0)) - (this.txtAbono.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtAbono.Text.Trim()) : new Decimal(0))).ToString("N0");
        }

        private void txtTotalCobrado_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalCobrado.Text.Trim().Length <= 0)
            {
                txtSaldo.Text = "-" + txtAbono.Text;
                return;
            }
            this.calculaSaldo();
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAbono.Text.Trim().Length <= 0)
            {
                this.txtSaldo.Text = this.txtTotalCobrado.Text;
                return;
            }
            this.calculaSaldo();
        }

        private void txtTotalCobrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtTotalCobrado);
            if ((int)e.KeyChar != 13)
                return;
            this.txtAbono.Focus();
        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtTotalCobrado);
            if ((int)e.KeyChar != 13)
                return;
            this.btnGuardar.Focus();
        }

        private void buscarOTTeclaF6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelFolio.Visible = true;
            this.txtFolioBuscar.Clear();
            this.txtFolioBuscar.Focus();
        }

        private void frmOrdenTrabajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                this.panelFolio.Visible = true;
                this.txtFolioBuscar.Clear();
                this.txtFolioBuscar.Focus();
            }
            if (e.KeyCode == Keys.F4)
            {
                this.txtCodigo.Focus();
                int num = (int)new frmBuscaProductos("ordentrabajo", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega).ShowDialog();
                this.txtCantidad.Focus();
            }
            if (e.KeyCode != Keys.F2)
                return;
            if (this._guarda)
                this.guardaModificaOT();
            if (this._modifica)
                this.guardaModificaOT();
        }

        private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtFolioBuscar);
            if ((int)e.KeyChar != 13)
                return;
            if (this.txtFolioBuscar.Text.Trim().Length > 0)
            {
                this.buscaOTFolio();
            }
            else
            {
                int num = (int)MessageBox.Show("Debe ingresar un folio a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnBuscaFolio_Click(object sender, EventArgs e)
        {
            if (this.txtFolioBuscar.Text.Trim().Length > 0)
            {
                this.buscaOTFolio();
            }
            else
            {
                int num = (int)MessageBox.Show("Debe ingresar un folio a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void buscaOTFolio()
        {
            this.panelFolio.Visible = false;
            this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = false;
            OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
            Venta venta = ordenTrabajo.buscaOTFolio(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
            if (venta.IdFactura != 0)
            {
                this.iniciaFormulario();
                this.idOT = venta.IdFactura;
                this.dtpEmision.Value = Convert.ToDateTime(venta.FechaEmision.ToString());
                this.dtpEntrega.Value = Convert.ToDateTime(venta.FechaVencimiento.ToString());
                if (venta.IdVendedor != 0)
                {
                    this.cmbVendedor.SelectedValue = (object)venta.IdVendedor.ToString();
                    this.cmbVendedor.Text = venta.Vendedor.ToString();
                }
                TextBox textBox1 = this.txtNumeroDocumento;
                int num1 = venta.Folio;
                string str1 = num1.ToString();
                textBox1.Text = str1;
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
                this.txtPatente.Text = venta.Patente;
                this.txtSubTotal.Text = venta.SubTotal.ToString("N0");
                this.txtPorcDescuentoTotal.Text = venta.PorcentajeDescuento.ToString("N0");
                this.txtTotalDescuento.Text = venta.Descuento.ToString("N0");
                this.txtNeto.Text = venta.Neto.ToString("N0");
                this.txtIva.Text = venta.Iva.ToString("N0");
                TextBox textBox2 = this.txtPorIva;
                Decimal num2 = venta.PorcentajeIva;
                string str2 = num2.ToString("N0");
                textBox2.Text = str2;
                TextBox textBox3 = this.txtTotalGeneral;
                num2 = venta.Total;
                string str3 = num2.ToString("N0");
                textBox3.Text = str3;
                this.lblTipoDoc.Text = venta.EstadoDocumento.ToString();
                this.txtDatosProductos.Text = venta.DatosProducto;
                this.txtDiagnostico.Text = venta.Diagnostico;
                this.txtSolucion.Text = venta.Solucion;
                if (venta.IdTecnicoOT != 0)
                {
                    ComboBox comboBox = this.cmbTecnico;
                    num1 = venta.IdTecnicoOT;
                    string str4 = num1.ToString();
                    comboBox.SelectedValue = (object)str4;
                    this.cmbTecnico.Text = venta.TecnicoOT.ToString();
                }
                ComboBox comboBox1 = this.cmbEstado;
                num1 = venta.IdEstadoOT;
                string str5 = num1.ToString();
                comboBox1.SelectedValue = (object)str5;
                this.cmbEstado.Text = venta.EstadoOT.ToString();
                TextBox textBox4 = this.txtTotalCobrado;
                num2 = venta.TotalCobradoOT;
                string str6 = num2.ToString("N0");
                textBox4.Text = str6;
                TextBox textBox5 = this.txtAbono;
                num2 = venta.AbonoOT;
                string str7 = num2.ToString("N0");
                textBox5.Text = str7;
                TextBox textBox6 = this.txtSaldo;
                num2 = venta.SaldoOT;
                string str8 = num2.ToString("N0");
                textBox6.Text = str8;
                this.btnGuardar.Enabled = false;
                if (this._modifica)
                    this.btnModificar.Enabled = true;
                if (this._elimina)
                    this.btnEliminar.Enabled = true;
                this.btnImprime.Enabled = true;
                if (venta.DocumentoVenta == "FACTURA" || venta.DocumentoVenta == "FACTURA EXENTA" || (venta.DocumentoVenta == "BOLETA" || venta.DocumentoVenta == "NOTA VENTA") || venta.DocumentoVenta == "GUIA")
                {
                    this.btnGuardar.Enabled = false;
                    this.btnModificar.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnImprime.Enabled = true;
                    this.lblTipoDoc.Text = venta.DocumentoVenta + " FOLIO : " + venta.FolioDocumentoVenta.ToString();
                }
                this.lista = ordenTrabajo.buscaDetalleOTId(venta.IdFactura);
                if (this.lista.Count > 0)
                {
                    this.cmbBodega.SelectedValue = (object)this.lista[0].Bodega;
                    for (int index = 0; index < this.lista.Count; ++index)
                        this.lista[index].Linea = index + 1;
                    this.dgvDatosVenta.DataSource = (object)null;
                    this.dgvDatosVenta.DataSource = (object)this.lista;
                }
                this.panelFolio.Visible = false;
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe Orden de Trabajo Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtFolioBuscar.Clear();
                this.iniciaFormulario();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.guardaModificaOT();
        }

        private void cambiarNumeroDeFolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNumeroDocumento.Enabled = true;
            this.txtNumeroDocumento.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Eliminar la OT ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new OrdenTrabajo().eliminaOT(this.idOT);
                    int num = (int)MessageBox.Show("La OT fue Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.iniciaFormulario();
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Error al Eliminar " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("La OT No fue Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
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
            this.cmbListaPrecio.SelectedValue = (object)this.dgvDatosVenta.SelectedRows[0].Cells["ListaPrecio"].Value.ToString();
            this.cmbBodega.SelectedValue = (object)this.dgvDatosVenta.SelectedRows[0].Cells["Bodega"].Value.ToString();
            this.netoLinea = Convert.ToDecimal(this.dgvDatosVenta.SelectedRows[0].Cells["NetoLinea"].Value.ToString());
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

        private void btnModificaLinea_Click(object sender, EventArgs e)
        {
            this.modificaLinea();
        }

        private void dgvDatosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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

        public void cantidad()
        {
            this.txtCantidad.Text = "1";
        }

        private void guardarOTTeclaF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._guarda)
                this.guardaModificaOT();
            if (!this._modifica)
                return;
            this.guardaModificaOT();
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
            Calculos calculos = new Calculos();
            Decimal descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
            Decimal subtotal = this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0);
            ArrayList arrayList2 = calculos.totalDescuentoGeneral(descuento, subtotal);
            if (arrayList2.Count > 1)
            {
                Decimal num2 = Convert.ToDecimal(arrayList2[0].ToString());
                Decimal num3 = Convert.ToDecimal(arrayList2[1].ToString());
                Decimal num4 = Convert.ToDecimal(arrayList2[2].ToString());
                this.txtNeto.Text = num2.ToString("N0");
                this.txtIva.Text = num3.ToString("N0");
                this.txtTotalGeneral.Text = num4.ToString("N0");
            }
            else if (subtotal > new Decimal(0))
            {
                int num2 = (int)MessageBox.Show("El Descuento NO debe ser Mayor al SubTotal");
                this.txtTotalDescuento.Text = "0";
                this.txtPorcDescuentoTotal.Clear();
            }
        }

        private void txtTotalDescuento_DoubleClick(object sender, EventArgs e)
        {
            this.txtTotalDescuento.ReadOnly = false;
        }

        private void txtTotalDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtTotalDescuento);
        }

        private void txtTotalDescuento_Leave(object sender, EventArgs e)
        {
            this.txtTotalDescuento.ReadOnly = true;
        }

        private void txtPorcDescuentoTotal_DoubleClick(object sender, EventArgs e)
        {
            this.txtPorcDescuentoTotal.ReadOnly = false;
        }

        private void txtPorcDescuentoTotal_Leave(object sender, EventArgs e)
        {
            this.txtPorcDescuentoTotal.ReadOnly = true;
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

        private void cmbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbEstado.SelectedValue == null || (!(this.cmbEstado.SelectedValue.ToString() == "1") || !(this.txtTotalGeneral.Text.Trim() == "0") && this.txtTotalGeneral.Text.Trim().Length != 0))
                return;
            int num = (int)MessageBox.Show("Antes de Finalizar debe Valorizar la OT", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnCerrarPanelFolio_Click(object sender, EventArgs e)
        {
            this.panelFolio.Visible = false;
        }

        private void frmOrdenTrabajo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuPrincipal._modOT = 0;
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            this.imprimeDirecto();
        }

        private void imprimeDirecto()
        {
            DataTable dataTable = new OrdenTrabajo().muestraOtFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
            try
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load("C:\\AptuSoft\\reportes\\OrdenTrabajo.rpt");
                rpt.SetDataSource(dataTable);
                int num = (int)new frmVisualizadorReportes(rpt).ShowDialog();
                this.iniciaFormulario();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error " + ex.Message);
            }
        }

        private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = (int)new frmBuscaProductos("ordentrabajo", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega).ShowDialog();
            this.txtCantidad.Focus();
        }

        private void btnAgregarTecnico_Click(object sender, EventArgs e)
        {
            this.panelTareaTecnico.Visible = true;
            this.txtTareaTecnico.Clear();
            this.txtComisionTarea.Clear();
            this.txtComisionTarea.Text = "0";
            this.txtTareaTecnico.Focus();
        }

        private void frmOrdenTrabajo_Load(object sender, EventArgs e)
        {

        }

        private void creaDGVTecnicos()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "id";
            c1.HeaderText = "id";
            c1.Width = 25;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "NombreTecnico";
            c2.HeaderText = "Nombre Técnico";
            c2.Width = 200;
            c2.ReadOnly = true;
            c2.Visible = true;

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "TareaRealizada";
            c3.HeaderText = "Tarea Realizada";
            c3.Width = 300;
            c3.ReadOnly = true;
            c3.Visible = true;

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Comision";
            c4.HeaderText = "Comisión";
            c4.Width = 75;
            c4.ReadOnly = true;
            c4.Visible = true;

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "FechaTarea";
            c5.ReadOnly = true;
            c5.Visible = false;

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "Eliminar";
            viewButtonColumn.HeaderText = "Eliminar";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            viewButtonColumn.Text = "X";
            viewButtonColumn.Width = 50;
            viewButtonColumn.DisplayIndex = 14;

            
            this.dgvTecnicos.Columns.Add(c1);
            this.dgvTecnicos.Columns.Add(c2);
            this.dgvTecnicos.Columns.Add(c3);
            this.dgvTecnicos.Columns.Add(c4);
            this.dgvTecnicos.Columns.Add(c5);
            this.dgvTecnicos.Columns.Add((DataGridViewColumn)viewButtonColumn);
        }

        private void creaDGVVendedores()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "id";
            c1.HeaderText = "id";
            c1.Width = 320;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "NombreTecnico";
            c2.HeaderText = "Nombre del Vendedor";
            c2.Width = 25;
            c2.ReadOnly = true;
            c2.Visible = true;

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Tarea Realizada";
            c3.Width = 25;
            c3.ReadOnly = true;
            c3.Visible = true;

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Comisión";
            c4.Width = 25;
            c4.ReadOnly = true;
            c4.Visible = true;

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "Eliminar";
            viewButtonColumn.HeaderText = "Eliminar";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            viewButtonColumn.Text = "X";
            viewButtonColumn.Width = 50;
            viewButtonColumn.DisplayIndex = 14;


            this.dgvVendedores.Columns.Add(c1);
            this.dgvVendedores.Columns.Add(c2);
            this.dgvVendedores.Columns.Add((DataGridViewColumn)viewButtonColumn);
        }

        private void dgvTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(this.dgvTecnicos.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (!dgvTecnicos.CurrentRow.Equals(string.Empty))
            {
                dgvTecnicos.Rows.Remove(dgvTecnicos.CurrentRow);
            }

        }

        private void btnAgregarVendedor_Click(object sender, EventArgs e)
        {
            agregarVendedor();
        }

        private void dgvVendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvVendedores.CurrentRow.Equals(string.Empty) && MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvVendedores.Rows.Remove(dgvVendedores.CurrentRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregarTecnico();
            this.panelTareaTecnico.Visible = false;
        }

        private void agregarVendedor()
        {
            if (!(cmbVendedor.SelectedIndex == 0))
            {
                dgvVendedores.Rows.Add(cmbVendedor.Text, cmbVendedor.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Debe Seleccionar a un Vendedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void agregarTecnico()
        {
            if (!(cmbTecnico.SelectedIndex == 0))
            {
                dgvTecnicos.Rows.Add(cmbTecnico.SelectedValue.ToString(), cmbTecnico.Text, txtTareaTecnico.Text, txtComisionTarea.Text, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
            }
            else
            {
                MessageBox.Show("Debe Seleccionar a un Técnico", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelTareaTecnico.Visible = false;
        }

        private void txtComisionTarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e, this.txtComisionTarea);
            if ((int)e.KeyChar != 13 || this.txtComisionTarea.Text.Length <= 0)
                return;
            agregarTecnico();
            panelTareaTecnico.Visible = false;
        }
    }
}
