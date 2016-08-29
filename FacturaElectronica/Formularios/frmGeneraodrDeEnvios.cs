 
// Type: Aptusoft.FacturaElectronica.Formularios.frmGeneraodrDeEnvios
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas;
using Aptusoft.FacturaElectronica.Clases.CreaXml;
using Aptusoft.FacturaElectronica.Clases.LibroVentaCompra;
using Aptusoft.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmGeneraodrDeEnvios : Form
  {
      private string multi = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      private string impresora = new LeeXml().cargarDatosMultiEmpresa("factura")[0].ToString();
    private string _documentoResumen = "BOLETA";
    public TotalesPeriodo _totalePeriodoManualBoleta35 = (TotalesPeriodo) null;
    public TotalesPeriodo _totalePeriodoManualBoleta35_2 = (TotalesPeriodo)null;
    public TotalesPeriodo _totalePeriodoManualBoleta48 = (TotalesPeriodo)null;
    private IContainer components = (IContainer) null;
    private List<Venta> lista = new List<Venta>();
    private List<Venta> listaResumen = new List<Venta>();
    private string _rutaElectronica = "";
    private DataGridView dgvDatos;
    private Button btnBuscar;
    private Button btnGeneraArchivoEnvio;
    private TextBox txtFE;
    private TextBox txtNCE;
    private TextBox txtNDE;
    private Button btnGeneraLibro;
    private Button btnMuestraLibroCompra;
    private Button btnGeneraLibroCompras;
    private TextBox txtPeriodo;
    private ToolTip toolTip1;
    private Button btnSalir;
    private TextBox txtFacturaPapel;
    private TextBox txtNotaCreditoPapel;
    private Label label8;
    private ComboBox cmbTipoEnvio;
    private GroupBox groupBox1;
    private Panel pnlNotificacion;
    private Label label7;
    private TextBox txtNotificacion;
    private RadioButton rdbTAEspecial;
    private RadioButton rdbTAMensual;
    private RadioButton rdbLibroCompras;
    private RadioButton rdbLibroVentas;
    private GroupBox groupBox5;
    private GroupBox groupBox4;
    private NumericUpDown nudMes;
    private NumericUpDown nudAno;
    private Panel panel1;
    private Label label11;
    private Label label9;
    private Panel panel2;
    private CheckBox chk60;
    private CheckBox chk30;
    private CheckBox chk56;
    private CheckBox chk61;
    private CheckBox chk33;
    private Panel panelLibros;
    private Panel panel4;
    private RadioButton rdbBusquedaLibroCompras;
    private RadioButton rdbBusquedaLibroVentas;
    private RadioButton rdbEnviarDte;
    private Panel panelFecha;
    private Label label10;
    private DateTimePicker dtpBusquedaHasta;
    private Label label12;
    private DateTimePicker dtpBusquedaDesde;
    private Button btnLimpiar;
    private Button button1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private DataGridView dgvResumen;
    private Panel panel3;
    private GroupBox groupBox2;
    private Label label13;
    private TabControl tabControlBusqueda;
    private TabPage tabPagePorFecha;
    private TabPage tabPagePorPeriodo;
    private ComboBox cmbPeriodo;
    private Label label34;
    private Panel pnlRectifica;
    private TextBox txtRectifica;
    private Label label4;
    private RadioButton rdbTARectifica;
    private CheckBox chk35;
    private CheckBox chk52;
    private DataGridViewTextBoxColumn CodigoDocumento;
    private DataGridViewTextBoxColumn Documento;
    private DataGridViewTextBoxColumn Cantidad;
    private DataGridViewTextBoxColumn NetoResumen;
    private DataGridViewTextBoxColumn IvaResumen;
    private DataGridViewTextBoxColumn ExentoResumen;
    private DataGridViewTextBoxColumn TotalResumen;
    private DataGridViewTextBoxColumn Impuesto1;
    private DataGridViewTextBoxColumn Impuesto2;
    private DataGridViewTextBoxColumn Impuesto3;
    private DataGridViewTextBoxColumn Impuesto4;
    private DataGridViewTextBoxColumn Impuesto5;
    private CheckBox chk34;
    private RadioButton rdbLibroGuias;
    private RadioButton rdbBusquedaLibroGuias;
    private TabControl tabControl2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private Panel panel7;
    private CheckBox chk34Enviados;
    private Button btnBuscarEnviados;
    private Label label1;
    private DateTimePicker dtpHastaEnviados;
    private Label label2;
    private DateTimePicker dtpDesdeEnviados;
    private CheckBox chk52Enviados;
    private CheckBox chk35Enviados;
    private CheckBox chk60Enviados;
    private CheckBox chk30Enviados;
    private CheckBox chk56Enviados;
    private CheckBox chk61Enviados;
    private CheckBox chk33Enviados;
    private Label label3;
    private Label label5;
    private DataGridView dgvDatosEnviados;
    private Button btnLiberarLibro;
    private Button btnLiberarEnviado;
    private CheckBox chkSeleccionarTodos;
    private DataGridViewCheckBoxColumn Seleccionar;
    private DataGridViewTextBoxColumn Enviar;
    private DataGridViewTextBoxColumn Tipo;
    private DataGridViewTextBoxColumn Folio;
    private DataGridViewTextBoxColumn IdFactura;
    private DataGridViewTextBoxColumn Fecha;
    private DataGridViewTextBoxColumn Rut;
    private DataGridViewTextBoxColumn RazonSocial;
    private DataGridViewTextBoxColumn Neto;
    private DataGridViewTextBoxColumn Iva;
    private DataGridViewTextBoxColumn Exento;
    private DataGridViewTextBoxColumn Total;
    private DataGridViewTextBoxColumn codImpuesto1;
    private DataGridViewTextBoxColumn codImpuesto2;
    private DataGridViewTextBoxColumn codImpuesto3;
    private DataGridViewTextBoxColumn codImpuesto4;
    private DataGridViewTextBoxColumn codImpuesto5;
    private DataGridViewTextBoxColumn OtrosImpuestos1;
    private DataGridViewTextBoxColumn OtrosImpuestos2;
    private DataGridViewTextBoxColumn OtrosImpuestos3;
    private DataGridViewTextBoxColumn OtrosImpuestos4;
    private DataGridViewTextBoxColumn OtrosImpuestos5;
    private DataGridViewTextBoxColumn porcentajeImpuesto1;
    private DataGridViewTextBoxColumn porcentajeImpuesto2;
    private DataGridViewTextBoxColumn porcentajeImpuesto3;
    private DataGridViewTextBoxColumn porcentajeImpuesto4;
    private DataGridViewTextBoxColumn porcentajeImpuesto5;
    private DataGridViewTextBoxColumn porcentajeIva;
    private DataGridViewTextBoxColumn TipoGuia;
    private DataGridViewTextBoxColumn Facturada;
    private DataGridViewTextBoxColumn FolioFactura;
    private DataGridViewTextBoxColumn DocumentoVenta;
    private DataGridViewTextBoxColumn FechaDocumentoReferencia;
    private DataGridViewTextBoxColumn EstadoDocumento;
    private CheckBox chk41;
    private CheckBox chk39;
    private DataGridViewCheckBoxColumn SeleccionarEnviado;
    private DataGridViewTextBoxColumn EnviarEnviados;
    private DataGridViewTextBoxColumn TipoEnviado;
    private DataGridViewTextBoxColumn FolioEnviado;
    private DataGridViewTextBoxColumn IdFacturaEnviado;
    private DataGridViewTextBoxColumn FechaEnviado;
    private DataGridViewTextBoxColumn RutEnviado;
    private DataGridViewTextBoxColumn RazonSocialEnviado;
    private DataGridViewTextBoxColumn TotalEnviado;
    private DataGridViewTextBoxColumn TrackIdEnvio;
    private DataGridViewTextBoxColumn TrackIdEnvioLibro;
    private DataGridViewCheckBoxColumn EnviadoSii;
    private DataGridViewCheckBoxColumn EnviadoLibro;
    private RadioButton rdbBusquedaLibroBoletas;
    private RadioButton rdbLibroBoletas;
    private RadioButton rdbBusquedaConsumoFolios;
    private Label lblres;
    private Panel panelResumenBoletas;
    private TextBox txtPorcentajeIvaResumen;
    private Button btnIngresarResumenBoleta;
    private TextBox txtTotalBoletas;
    private TextBox txtExentoBoletas;
    private TextBox txtIvaBoletas;
    private TextBox txtNetoBoletas;
    private TextBox txtCantidadBoletas;
    private Label label22;
    private Label label21;
    private Label label20;
    private Label label19;
    private Label label18;
    private Label label17;
    private Button btnResumenBoletaExenta;
    private Button btnResumenComprobantePago;
    private Button btnResumenBoleta;
    private Button button2;
    private CheckBox checkBox1;
    private Label label6;

    public frmGeneraodrDeEnvios()
    {
      this.InitializeComponent();
      this.CargaRuta();
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvResumen.AutoGenerateColumns = false;
      this.dgvDatosEnviados.AutoGenerateColumns = false;
      this.iniciaFormulario();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Enviar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codImpuesto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codImpuesto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codImpuesto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codImpuesto4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codImpuesto5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosImpuestos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosImpuestos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosImpuestos3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosImpuestos4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosImpuestos5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeImpuesto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeImpuesto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeImpuesto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeImpuesto4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeImpuesto5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolioFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDocumentoReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFE = new System.Windows.Forms.TextBox();
            this.txtNCE = new System.Windows.Forms.TextBox();
            this.txtNDE = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGeneraLibroCompras = new System.Windows.Forms.Button();
            this.btnMuestraLibroCompra = new System.Windows.Forms.Button();
            this.btnGeneraLibro = new System.Windows.Forms.Button();
            this.btnGeneraArchivoEnvio = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarEnviados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFacturaPapel = new System.Windows.Forms.TextBox();
            this.txtNotaCreditoPapel = new System.Windows.Forms.TextBox();
            this.rdbLibroVentas = new System.Windows.Forms.RadioButton();
            this.rdbLibroCompras = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlRectifica = new System.Windows.Forms.Panel();
            this.txtRectifica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbTARectifica = new System.Windows.Forms.RadioButton();
            this.pnlNotificacion = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotificacion = new System.Windows.Forms.TextBox();
            this.rdbTAEspecial = new System.Windows.Forms.RadioButton();
            this.rdbTAMensual = new System.Windows.Forms.RadioButton();
            this.cmbTipoEnvio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbLibroBoletas = new System.Windows.Forms.RadioButton();
            this.rdbLibroGuias = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbBusquedaConsumoFolios = new System.Windows.Forms.RadioButton();
            this.rdbBusquedaLibroBoletas = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbBusquedaLibroGuias = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbEnviarDte = new System.Windows.Forms.RadioButton();
            this.rdbBusquedaLibroCompras = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rdbBusquedaLibroVentas = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chk41 = new System.Windows.Forms.CheckBox();
            this.tabControlBusqueda = new System.Windows.Forms.TabControl();
            this.tabPagePorFecha = new System.Windows.Forms.TabPage();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpBusquedaHasta = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpBusquedaDesde = new System.Windows.Forms.DateTimePicker();
            this.tabPagePorPeriodo = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.chk39 = new System.Windows.Forms.CheckBox();
            this.chk34 = new System.Windows.Forms.CheckBox();
            this.chk52 = new System.Windows.Forms.CheckBox();
            this.chk35 = new System.Windows.Forms.CheckBox();
            this.chk60 = new System.Windows.Forms.CheckBox();
            this.chk30 = new System.Windows.Forms.CheckBox();
            this.chk56 = new System.Windows.Forms.CheckBox();
            this.chk61 = new System.Windows.Forms.CheckBox();
            this.chk33 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelLibros = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnResumenBoletaExenta = new System.Windows.Forms.Button();
            this.btnResumenComprobantePago = new System.Windows.Forms.Button();
            this.btnResumenBoleta = new System.Windows.Forms.Button();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.CodigoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetoResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IvaResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExentoResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelResumenBoletas = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPorcentajeIvaResumen = new System.Windows.Forms.TextBox();
            this.btnIngresarResumenBoleta = new System.Windows.Forms.Button();
            this.txtTotalBoletas = new System.Windows.Forms.TextBox();
            this.txtExentoBoletas = new System.Windows.Forms.TextBox();
            this.txtIvaBoletas = new System.Windows.Forms.TextBox();
            this.txtNetoBoletas = new System.Windows.Forms.TextBox();
            this.txtCantidadBoletas = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnLiberarLibro = new System.Windows.Forms.Button();
            this.btnLiberarEnviado = new System.Windows.Forms.Button();
            this.chkSeleccionarTodos = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chk34Enviados = new System.Windows.Forms.CheckBox();
            this.dtpHastaEnviados = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesdeEnviados = new System.Windows.Forms.DateTimePicker();
            this.chk52Enviados = new System.Windows.Forms.CheckBox();
            this.chk35Enviados = new System.Windows.Forms.CheckBox();
            this.chk60Enviados = new System.Windows.Forms.CheckBox();
            this.chk30Enviados = new System.Windows.Forms.CheckBox();
            this.chk56Enviados = new System.Windows.Forms.CheckBox();
            this.chk61Enviados = new System.Windows.Forms.CheckBox();
            this.chk33Enviados = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDatosEnviados = new System.Windows.Forms.DataGridView();
            this.SeleccionarEnviado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnviarEnviados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolioEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFacturaEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocialEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEnviado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackIdEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackIdEnvioLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnviadoSii = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnviadoLibro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlRectifica.SuspendLayout();
            this.pnlNotificacion.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControlBusqueda.SuspendLayout();
            this.tabPagePorFecha.SuspendLayout();
            this.panelFecha.SuspendLayout();
            this.tabPagePorPeriodo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelLibros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelResumenBoletas.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEnviados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Enviar,
            this.Tipo,
            this.Folio,
            this.IdFactura,
            this.Fecha,
            this.Rut,
            this.RazonSocial,
            this.Neto,
            this.Iva,
            this.Exento,
            this.Total,
            this.codImpuesto1,
            this.codImpuesto2,
            this.codImpuesto3,
            this.codImpuesto4,
            this.codImpuesto5,
            this.OtrosImpuestos1,
            this.OtrosImpuestos2,
            this.OtrosImpuestos3,
            this.OtrosImpuestos4,
            this.OtrosImpuestos5,
            this.porcentajeImpuesto1,
            this.porcentajeImpuesto2,
            this.porcentajeImpuesto3,
            this.porcentajeImpuesto4,
            this.porcentajeImpuesto5,
            this.porcentajeIva,
            this.TipoGuia,
            this.Facturada,
            this.FolioFactura,
            this.DocumentoVenta,
            this.FechaDocumentoReferencia,
            this.EstadoDocumento});
            this.dgvDatos.Location = new System.Drawing.Point(6, 6);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1040, 403);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDatos_DataError);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 30;
            // 
            // Enviar
            // 
            this.Enviar.DataPropertyName = "Enviar";
            this.Enviar.HeaderText = "Enviar";
            this.Enviar.Name = "Enviar";
            this.Enviar.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Fe_TipoDTE";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 40;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "Folio";
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Width = 60;
            // 
            // IdFactura
            // 
            this.IdFactura.DataPropertyName = "IdFactura";
            this.IdFactura.HeaderText = "IdFactura";
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.ReadOnly = true;
            this.IdFactura.Visible = false;
            this.IdFactura.Width = 60;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // Rut
            // 
            this.Rut.DataPropertyName = "Rut";
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 80;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "RazonSocial";
            this.RazonSocial.HeaderText = "RazonSocial";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 360;
            // 
            // Neto
            // 
            this.Neto.DataPropertyName = "Neto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.Neto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Neto.HeaderText = "Neto";
            this.Neto.Name = "Neto";
            this.Neto.ReadOnly = true;
            this.Neto.Width = 90;
            // 
            // Iva
            // 
            this.Iva.DataPropertyName = "Iva";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.Iva.DefaultCellStyle = dataGridViewCellStyle4;
            this.Iva.HeaderText = "Iva";
            this.Iva.Name = "Iva";
            this.Iva.ReadOnly = true;
            this.Iva.Width = 90;
            // 
            // Exento
            // 
            this.Exento.DataPropertyName = "TotalExento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.Exento.DefaultCellStyle = dataGridViewCellStyle5;
            this.Exento.HeaderText = "Exento";
            this.Exento.Name = "Exento";
            this.Exento.ReadOnly = true;
            this.Exento.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // codImpuesto1
            // 
            this.codImpuesto1.DataPropertyName = "codImpuesto1";
            this.codImpuesto1.HeaderText = "C. Imp. 1";
            this.codImpuesto1.Name = "codImpuesto1";
            this.codImpuesto1.ReadOnly = true;
            this.codImpuesto1.Visible = false;
            this.codImpuesto1.Width = 80;
            // 
            // codImpuesto2
            // 
            this.codImpuesto2.DataPropertyName = "codImpuesto2";
            this.codImpuesto2.HeaderText = "C. Imp. 2";
            this.codImpuesto2.Name = "codImpuesto2";
            this.codImpuesto2.ReadOnly = true;
            this.codImpuesto2.Visible = false;
            // 
            // codImpuesto3
            // 
            this.codImpuesto3.DataPropertyName = "codImpuesto3";
            this.codImpuesto3.HeaderText = "C. Imp. 3";
            this.codImpuesto3.Name = "codImpuesto3";
            this.codImpuesto3.ReadOnly = true;
            this.codImpuesto3.Visible = false;
            // 
            // codImpuesto4
            // 
            this.codImpuesto4.DataPropertyName = "codImpuesto4";
            this.codImpuesto4.HeaderText = "C. Imp. 4";
            this.codImpuesto4.Name = "codImpuesto4";
            this.codImpuesto4.ReadOnly = true;
            this.codImpuesto4.Visible = false;
            // 
            // codImpuesto5
            // 
            this.codImpuesto5.DataPropertyName = "codImpuesto5";
            this.codImpuesto5.HeaderText = "C. Imp. 5";
            this.codImpuesto5.Name = "codImpuesto5";
            this.codImpuesto5.ReadOnly = true;
            this.codImpuesto5.Visible = false;
            // 
            // OtrosImpuestos1
            // 
            this.OtrosImpuestos1.DataPropertyName = "impuesto1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            this.OtrosImpuestos1.DefaultCellStyle = dataGridViewCellStyle7;
            this.OtrosImpuestos1.HeaderText = "Imp 1";
            this.OtrosImpuestos1.Name = "OtrosImpuestos1";
            this.OtrosImpuestos1.ReadOnly = true;
            this.OtrosImpuestos1.Visible = false;
            this.OtrosImpuestos1.Width = 60;
            // 
            // OtrosImpuestos2
            // 
            this.OtrosImpuestos2.DataPropertyName = "impuesto2";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            this.OtrosImpuestos2.DefaultCellStyle = dataGridViewCellStyle8;
            this.OtrosImpuestos2.HeaderText = "Imp 2";
            this.OtrosImpuestos2.Name = "OtrosImpuestos2";
            this.OtrosImpuestos2.ReadOnly = true;
            this.OtrosImpuestos2.Visible = false;
            this.OtrosImpuestos2.Width = 60;
            // 
            // OtrosImpuestos3
            // 
            this.OtrosImpuestos3.DataPropertyName = "impuesto3";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            this.OtrosImpuestos3.DefaultCellStyle = dataGridViewCellStyle9;
            this.OtrosImpuestos3.HeaderText = "Imp 3";
            this.OtrosImpuestos3.Name = "OtrosImpuestos3";
            this.OtrosImpuestos3.ReadOnly = true;
            this.OtrosImpuestos3.Visible = false;
            this.OtrosImpuestos3.Width = 60;
            // 
            // OtrosImpuestos4
            // 
            this.OtrosImpuestos4.DataPropertyName = "impuesto4";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = "0";
            this.OtrosImpuestos4.DefaultCellStyle = dataGridViewCellStyle10;
            this.OtrosImpuestos4.HeaderText = "Imp 4";
            this.OtrosImpuestos4.Name = "OtrosImpuestos4";
            this.OtrosImpuestos4.ReadOnly = true;
            this.OtrosImpuestos4.Visible = false;
            this.OtrosImpuestos4.Width = 60;
            // 
            // OtrosImpuestos5
            // 
            this.OtrosImpuestos5.DataPropertyName = "impuesto5";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = "0";
            this.OtrosImpuestos5.DefaultCellStyle = dataGridViewCellStyle11;
            this.OtrosImpuestos5.HeaderText = "Imp 5";
            this.OtrosImpuestos5.Name = "OtrosImpuestos5";
            this.OtrosImpuestos5.ReadOnly = true;
            this.OtrosImpuestos5.Visible = false;
            this.OtrosImpuestos5.Width = 60;
            // 
            // porcentajeImpuesto1
            // 
            this.porcentajeImpuesto1.DataPropertyName = "porcentajeImpuesto1";
            this.porcentajeImpuesto1.HeaderText = "porcentajeImpuesto1";
            this.porcentajeImpuesto1.Name = "porcentajeImpuesto1";
            this.porcentajeImpuesto1.ReadOnly = true;
            this.porcentajeImpuesto1.Visible = false;
            // 
            // porcentajeImpuesto2
            // 
            this.porcentajeImpuesto2.DataPropertyName = "porcentajeImpuesto2";
            this.porcentajeImpuesto2.HeaderText = "porcentajeImpuesto2";
            this.porcentajeImpuesto2.Name = "porcentajeImpuesto2";
            this.porcentajeImpuesto2.ReadOnly = true;
            this.porcentajeImpuesto2.Visible = false;
            // 
            // porcentajeImpuesto3
            // 
            this.porcentajeImpuesto3.DataPropertyName = "porcentajeImpuesto3";
            this.porcentajeImpuesto3.HeaderText = "porcentajeImpuesto3";
            this.porcentajeImpuesto3.Name = "porcentajeImpuesto3";
            this.porcentajeImpuesto3.ReadOnly = true;
            this.porcentajeImpuesto3.Visible = false;
            // 
            // porcentajeImpuesto4
            // 
            this.porcentajeImpuesto4.DataPropertyName = "porcentajeImpuesto4";
            this.porcentajeImpuesto4.HeaderText = "porcentajeImpuesto4";
            this.porcentajeImpuesto4.Name = "porcentajeImpuesto4";
            this.porcentajeImpuesto4.ReadOnly = true;
            this.porcentajeImpuesto4.Visible = false;
            // 
            // porcentajeImpuesto5
            // 
            this.porcentajeImpuesto5.DataPropertyName = "porcentajeImpuesto5";
            this.porcentajeImpuesto5.HeaderText = "porcentajeImpuesto5";
            this.porcentajeImpuesto5.Name = "porcentajeImpuesto5";
            this.porcentajeImpuesto5.ReadOnly = true;
            this.porcentajeImpuesto5.Visible = false;
            // 
            // porcentajeIva
            // 
            this.porcentajeIva.DataPropertyName = "porcentajeIva";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            this.porcentajeIva.DefaultCellStyle = dataGridViewCellStyle12;
            this.porcentajeIva.HeaderText = "porcentajeIva";
            this.porcentajeIva.Name = "porcentajeIva";
            this.porcentajeIva.ReadOnly = true;
            this.porcentajeIva.Visible = false;
            this.porcentajeIva.Width = 60;
            // 
            // TipoGuia
            // 
            this.TipoGuia.DataPropertyName = "FE_codigoTipoGuia";
            this.TipoGuia.HeaderText = "TipoGuia";
            this.TipoGuia.Name = "TipoGuia";
            this.TipoGuia.ReadOnly = true;
            this.TipoGuia.Visible = false;
            // 
            // Facturada
            // 
            this.Facturada.DataPropertyName = "Facturada";
            this.Facturada.HeaderText = "Facturada";
            this.Facturada.Name = "Facturada";
            this.Facturada.ReadOnly = true;
            this.Facturada.Visible = false;
            // 
            // FolioFactura
            // 
            this.FolioFactura.DataPropertyName = "FolioFactura";
            this.FolioFactura.HeaderText = "FolioFactura";
            this.FolioFactura.Name = "FolioFactura";
            this.FolioFactura.ReadOnly = true;
            this.FolioFactura.Visible = false;
            // 
            // DocumentoVenta
            // 
            this.DocumentoVenta.DataPropertyName = "DocumentoVenta";
            this.DocumentoVenta.HeaderText = "DocumentoVenta";
            this.DocumentoVenta.Name = "DocumentoVenta";
            this.DocumentoVenta.ReadOnly = true;
            this.DocumentoVenta.Visible = false;
            // 
            // FechaDocumentoReferencia
            // 
            this.FechaDocumentoReferencia.DataPropertyName = "FechaModificacion";
            this.FechaDocumentoReferencia.HeaderText = "FechaDocumentoReferencia";
            this.FechaDocumentoReferencia.Name = "FechaDocumentoReferencia";
            this.FechaDocumentoReferencia.ReadOnly = true;
            this.FechaDocumentoReferencia.Visible = false;
            // 
            // EstadoDocumento
            // 
            this.EstadoDocumento.DataPropertyName = "EstadoDocumento";
            this.EstadoDocumento.HeaderText = "EstadoDocumento";
            this.EstadoDocumento.Name = "EstadoDocumento";
            this.EstadoDocumento.Visible = false;
            // 
            // txtFE
            // 
            this.txtFE.BackColor = System.Drawing.Color.White;
            this.txtFE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFE.ForeColor = System.Drawing.Color.Black;
            this.txtFE.Location = new System.Drawing.Point(1364, 25);
            this.txtFE.Name = "txtFE";
            this.txtFE.ReadOnly = true;
            this.txtFE.Size = new System.Drawing.Size(39, 20);
            this.txtFE.TabIndex = 6;
            this.txtFE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFE.Visible = false;
            // 
            // txtNCE
            // 
            this.txtNCE.BackColor = System.Drawing.Color.White;
            this.txtNCE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNCE.ForeColor = System.Drawing.Color.Black;
            this.txtNCE.Location = new System.Drawing.Point(1364, 77);
            this.txtNCE.Name = "txtNCE";
            this.txtNCE.ReadOnly = true;
            this.txtNCE.Size = new System.Drawing.Size(39, 20);
            this.txtNCE.TabIndex = 7;
            this.txtNCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNCE.Visible = false;
            // 
            // txtNDE
            // 
            this.txtNDE.BackColor = System.Drawing.Color.White;
            this.txtNDE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNDE.ForeColor = System.Drawing.Color.Black;
            this.txtNDE.Location = new System.Drawing.Point(1364, 129);
            this.txtNDE.Name = "txtNDE";
            this.txtNDE.ReadOnly = true;
            this.txtNDE.Size = new System.Drawing.Size(39, 20);
            this.txtNDE.TabIndex = 8;
            this.txtNDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNDE.Visible = false;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.BackColor = System.Drawing.Color.White;
            this.txtPeriodo.Location = new System.Drawing.Point(103, 40);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(92, 20);
            this.txtPeriodo.TabIndex = 13;
            this.txtPeriodo.TabStop = false;
            // 
            // btnGeneraLibroCompras
            // 
            this.btnGeneraLibroCompras.Image = global::Aptusoft.Properties.Resources.libro2_48;
            this.btnGeneraLibroCompras.Location = new System.Drawing.Point(1384, 155);
            this.btnGeneraLibroCompras.Name = "btnGeneraLibroCompras";
            this.btnGeneraLibroCompras.Size = new System.Drawing.Size(19, 12);
            this.btnGeneraLibroCompras.TabIndex = 12;
            this.btnGeneraLibroCompras.Text = "Libro de Compras";
            this.btnGeneraLibroCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneraLibroCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnGeneraLibroCompras, "Generar Libro de Compras");
            this.btnGeneraLibroCompras.UseVisualStyleBackColor = true;
            this.btnGeneraLibroCompras.Visible = false;
            this.btnGeneraLibroCompras.Click += new System.EventHandler(this.btnGeneraLibroCompras_Click);
            // 
            // btnMuestraLibroCompra
            // 
            this.btnMuestraLibroCompra.Image = global::Aptusoft.Properties.Resources.set_48;
            this.btnMuestraLibroCompra.Location = new System.Drawing.Point(1176, 552);
            this.btnMuestraLibroCompra.Name = "btnMuestraLibroCompra";
            this.btnMuestraLibroCompra.Size = new System.Drawing.Size(97, 95);
            this.btnMuestraLibroCompra.TabIndex = 11;
            this.btnMuestraLibroCompra.Text = "SetLibroCompra";
            this.btnMuestraLibroCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuestraLibroCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnMuestraLibroCompra, "Genera set de Libro de Compras");
            this.btnMuestraLibroCompra.UseVisualStyleBackColor = true;
            this.btnMuestraLibroCompra.Visible = false;
            this.btnMuestraLibroCompra.Click += new System.EventHandler(this.btnMuestraLibroCompra_Click);
            // 
            // btnGeneraLibro
            // 
            this.btnGeneraLibro.Image = global::Aptusoft.Properties.Resources.libro2_48;
            this.btnGeneraLibro.Location = new System.Drawing.Point(116, 410);
            this.btnGeneraLibro.Name = "btnGeneraLibro";
            this.btnGeneraLibro.Size = new System.Drawing.Size(87, 95);
            this.btnGeneraLibro.TabIndex = 9;
            this.btnGeneraLibro.Text = "Generar Libro";
            this.btnGeneraLibro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneraLibro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnGeneraLibro, "Generar Libro de Ventas");
            this.btnGeneraLibro.UseVisualStyleBackColor = true;
            this.btnGeneraLibro.Click += new System.EventHandler(this.btnGeneraLibro_Click);
            // 
            // btnGeneraArchivoEnvio
            // 
            this.btnGeneraArchivoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneraArchivoEnvio.Image = global::Aptusoft.Properties.Resources.send_mail_icone_9097_48;
            this.btnGeneraArchivoEnvio.Location = new System.Drawing.Point(841, 6);
            this.btnGeneraArchivoEnvio.Name = "btnGeneraArchivoEnvio";
            this.btnGeneraArchivoEnvio.Size = new System.Drawing.Size(91, 91);
            this.btnGeneraArchivoEnvio.TabIndex = 2;
            this.btnGeneraArchivoEnvio.Text = "Enviar a SII";
            this.btnGeneraArchivoEnvio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneraArchivoEnvio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnGeneraArchivoEnvio, "Crear Archivo con DTE para enviar a SII");
            this.btnGeneraArchivoEnvio.UseVisualStyleBackColor = true;
            this.btnGeneraArchivoEnvio.Click += new System.EventHandler(this.btnGeneraArchivoEnvio_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(765, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar DTE para Enviar a Sii");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarEnviados
            // 
            this.btnBuscarEnviados.Image = global::Aptusoft.Properties.Resources.buscar_documento_48;
            this.btnBuscarEnviados.Location = new System.Drawing.Point(591, 11);
            this.btnBuscarEnviados.Name = "btnBuscarEnviados";
            this.btnBuscarEnviados.Size = new System.Drawing.Size(76, 70);
            this.btnBuscarEnviados.TabIndex = 31;
            this.btnBuscarEnviados.Text = "Buscar";
            this.btnBuscarEnviados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarEnviados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnBuscarEnviados, "Buscar DTE para Enviar a Sii");
            this.btnBuscarEnviados.UseVisualStyleBackColor = true;
            this.btnBuscarEnviados.Click += new System.EventHandler(this.btnBuscarEnviados_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.Location = new System.Drawing.Point(1072, 555);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 92);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFacturaPapel
            // 
            this.txtFacturaPapel.BackColor = System.Drawing.Color.White;
            this.txtFacturaPapel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacturaPapel.ForeColor = System.Drawing.Color.Black;
            this.txtFacturaPapel.Location = new System.Drawing.Point(1364, 51);
            this.txtFacturaPapel.Name = "txtFacturaPapel";
            this.txtFacturaPapel.ReadOnly = true;
            this.txtFacturaPapel.Size = new System.Drawing.Size(39, 20);
            this.txtFacturaPapel.TabIndex = 6;
            this.txtFacturaPapel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFacturaPapel.Visible = false;
            // 
            // txtNotaCreditoPapel
            // 
            this.txtNotaCreditoPapel.BackColor = System.Drawing.Color.White;
            this.txtNotaCreditoPapel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaCreditoPapel.ForeColor = System.Drawing.Color.Black;
            this.txtNotaCreditoPapel.Location = new System.Drawing.Point(1364, 103);
            this.txtNotaCreditoPapel.Name = "txtNotaCreditoPapel";
            this.txtNotaCreditoPapel.ReadOnly = true;
            this.txtNotaCreditoPapel.Size = new System.Drawing.Size(39, 20);
            this.txtNotaCreditoPapel.TabIndex = 7;
            this.txtNotaCreditoPapel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNotaCreditoPapel.Visible = false;
            // 
            // rdbLibroVentas
            // 
            this.rdbLibroVentas.AutoSize = true;
            this.rdbLibroVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLibroVentas.Location = new System.Drawing.Point(8, 19);
            this.rdbLibroVentas.Name = "rdbLibroVentas";
            this.rdbLibroVentas.Size = new System.Drawing.Size(125, 19);
            this.rdbLibroVentas.TabIndex = 13;
            this.rdbLibroVentas.TabStop = true;
            this.rdbLibroVentas.Text = "Libro de Ventas";
            this.rdbLibroVentas.UseVisualStyleBackColor = true;
            // 
            // rdbLibroCompras
            // 
            this.rdbLibroCompras.AutoSize = true;
            this.rdbLibroCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLibroCompras.Location = new System.Drawing.Point(8, 44);
            this.rdbLibroCompras.Name = "rdbLibroCompras";
            this.rdbLibroCompras.Size = new System.Drawing.Size(139, 19);
            this.rdbLibroCompras.TabIndex = 14;
            this.rdbLibroCompras.TabStop = true;
            this.rdbLibroCompras.Text = "Libro de Compras";
            this.rdbLibroCompras.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlRectifica);
            this.groupBox1.Controls.Add(this.rdbTARectifica);
            this.groupBox1.Controls.Add(this.pnlNotificacion);
            this.groupBox1.Controls.Add(this.rdbTAEspecial);
            this.groupBox1.Controls.Add(this.rdbTAMensual);
            this.groupBox1.Location = new System.Drawing.Point(3, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Libro";
            // 
            // pnlRectifica
            // 
            this.pnlRectifica.Controls.Add(this.txtRectifica);
            this.pnlRectifica.Controls.Add(this.label4);
            this.pnlRectifica.Location = new System.Drawing.Point(80, 13);
            this.pnlRectifica.Name = "pnlRectifica";
            this.pnlRectifica.Size = new System.Drawing.Size(110, 76);
            this.pnlRectifica.TabIndex = 30;
            this.pnlRectifica.Visible = false;
            // 
            // txtRectifica
            // 
            this.txtRectifica.Location = new System.Drawing.Point(6, 52);
            this.txtRectifica.Name = "txtRectifica";
            this.txtRectifica.Size = new System.Drawing.Size(100, 20);
            this.txtRectifica.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 45);
            this.label4.TabIndex = 31;
            this.label4.Text = "Código de Autorización de Reemplazo de Libro Electronico";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbTARectifica
            // 
            this.rdbTARectifica.AutoSize = true;
            this.rdbTARectifica.Location = new System.Drawing.Point(10, 66);
            this.rdbTARectifica.Name = "rdbTARectifica";
            this.rdbTARectifica.Size = new System.Drawing.Size(67, 17);
            this.rdbTARectifica.TabIndex = 17;
            this.rdbTARectifica.TabStop = true;
            this.rdbTARectifica.Text = "Rectifica";
            this.rdbTARectifica.UseVisualStyleBackColor = true;
            this.rdbTARectifica.CheckedChanged += new System.EventHandler(this.rdbTARectifica_CheckedChanged);
            // 
            // pnlNotificacion
            // 
            this.pnlNotificacion.Controls.Add(this.label7);
            this.pnlNotificacion.Controls.Add(this.txtNotificacion);
            this.pnlNotificacion.Location = new System.Drawing.Point(81, 15);
            this.pnlNotificacion.Name = "pnlNotificacion";
            this.pnlNotificacion.Size = new System.Drawing.Size(112, 54);
            this.pnlNotificacion.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Folio de Notificacion";
            // 
            // txtNotificacion
            // 
            this.txtNotificacion.Location = new System.Drawing.Point(5, 26);
            this.txtNotificacion.Name = "txtNotificacion";
            this.txtNotificacion.Size = new System.Drawing.Size(103, 20);
            this.txtNotificacion.TabIndex = 2;
            // 
            // rdbTAEspecial
            // 
            this.rdbTAEspecial.AutoSize = true;
            this.rdbTAEspecial.Location = new System.Drawing.Point(9, 43);
            this.rdbTAEspecial.Name = "rdbTAEspecial";
            this.rdbTAEspecial.Size = new System.Drawing.Size(65, 17);
            this.rdbTAEspecial.TabIndex = 1;
            this.rdbTAEspecial.TabStop = true;
            this.rdbTAEspecial.Text = "Especial";
            this.rdbTAEspecial.UseVisualStyleBackColor = true;
            this.rdbTAEspecial.CheckedChanged += new System.EventHandler(this.rdbTAEspecial_CheckedChanged);
            // 
            // rdbTAMensual
            // 
            this.rdbTAMensual.AutoSize = true;
            this.rdbTAMensual.Location = new System.Drawing.Point(10, 20);
            this.rdbTAMensual.Name = "rdbTAMensual";
            this.rdbTAMensual.Size = new System.Drawing.Size(65, 17);
            this.rdbTAMensual.TabIndex = 0;
            this.rdbTAMensual.TabStop = true;
            this.rdbTAMensual.Text = "Mensual";
            this.rdbTAMensual.UseVisualStyleBackColor = true;
            // 
            // cmbTipoEnvio
            // 
            this.cmbTipoEnvio.Enabled = false;
            this.cmbTipoEnvio.FormattingEnabled = true;
            this.cmbTipoEnvio.Items.AddRange(new object[] {
            "TOTAL",
            "PARCIAL",
            "FINAL",
            "AJUSTE"});
            this.cmbTipoEnvio.Location = new System.Drawing.Point(6, 39);
            this.cmbTipoEnvio.Name = "cmbTipoEnvio";
            this.cmbTipoEnvio.Size = new System.Drawing.Size(184, 21);
            this.cmbTipoEnvio.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo de Envio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbLibroBoletas);
            this.groupBox4.Controls.Add(this.rdbLibroGuias);
            this.groupBox4.Controls.Add(this.rdbLibroVentas);
            this.groupBox4.Controls.Add(this.rdbLibroCompras);
            this.groupBox4.Location = new System.Drawing.Point(3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 126);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de Operacion";
            // 
            // rdbLibroBoletas
            // 
            this.rdbLibroBoletas.AutoSize = true;
            this.rdbLibroBoletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLibroBoletas.Location = new System.Drawing.Point(8, 93);
            this.rdbLibroBoletas.Name = "rdbLibroBoletas";
            this.rdbLibroBoletas.Size = new System.Drawing.Size(130, 19);
            this.rdbLibroBoletas.TabIndex = 16;
            this.rdbLibroBoletas.TabStop = true;
            this.rdbLibroBoletas.Text = "Libro de Boletas";
            this.rdbLibroBoletas.UseVisualStyleBackColor = true;
            // 
            // rdbLibroGuias
            // 
            this.rdbLibroGuias.AutoSize = true;
            this.rdbLibroGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLibroGuias.Location = new System.Drawing.Point(8, 68);
            this.rdbLibroGuias.Name = "rdbLibroGuias";
            this.rdbLibroGuias.Size = new System.Drawing.Size(119, 19);
            this.rdbLibroGuias.TabIndex = 15;
            this.rdbLibroGuias.TabStop = true;
            this.rdbLibroGuias.Text = "Libro de Guias";
            this.rdbLibroGuias.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbTipoEnvio);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(3, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 73);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // nudMes
            // 
            this.nudMes.BackColor = System.Drawing.Color.White;
            this.nudMes.Location = new System.Drawing.Point(58, 40);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.ReadOnly = true;
            this.nudMes.Size = new System.Drawing.Size(39, 20);
            this.nudMes.TabIndex = 17;
            this.nudMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.ValueChanged += new System.EventHandler(this.nudMes_ValueChanged);
            // 
            // nudAno
            // 
            this.nudAno.BackColor = System.Drawing.Color.White;
            this.nudAno.Location = new System.Drawing.Point(5, 40);
            this.nudAno.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.ReadOnly = true;
            this.nudAno.Size = new System.Drawing.Size(50, 20);
            this.nudAno.TabIndex = 16;
            this.nudAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAno.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudAno.ValueChanged += new System.EventHandler(this.nudAno_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.rdbBusquedaConsumoFolios);
            this.panel1.Controls.Add(this.rdbBusquedaLibroBoletas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rdbBusquedaLibroGuias);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rdbEnviarDte);
            this.panel1.Controls.Add(this.rdbBusquedaLibroCompras);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.rdbBusquedaLibroVentas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.chk41);
            this.panel1.Controls.Add(this.tabControlBusqueda);
            this.panel1.Controls.Add(this.chk39);
            this.panel1.Controls.Add(this.chk34);
            this.panel1.Controls.Add(this.btnGeneraArchivoEnvio);
            this.panel1.Controls.Add(this.chk52);
            this.panel1.Controls.Add(this.chk35);
            this.panel1.Controls.Add(this.chk60);
            this.panel1.Controls.Add(this.chk30);
            this.panel1.Controls.Add(this.chk56);
            this.panel1.Controls.Add(this.chk61);
            this.panel1.Controls.Add(this.chk33);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 144);
            this.panel1.TabIndex = 26;
            // 
            // rdbBusquedaConsumoFolios
            // 
            this.rdbBusquedaConsumoFolios.AutoSize = true;
            this.rdbBusquedaConsumoFolios.Location = new System.Drawing.Point(447, 119);
            this.rdbBusquedaConsumoFolios.Name = "rdbBusquedaConsumoFolios";
            this.rdbBusquedaConsumoFolios.Size = new System.Drawing.Size(155, 17);
            this.rdbBusquedaConsumoFolios.TabIndex = 46;
            this.rdbBusquedaConsumoFolios.TabStop = true;
            this.rdbBusquedaConsumoFolios.Text = "Reporte Consumo de Folios";
            this.rdbBusquedaConsumoFolios.UseVisualStyleBackColor = true;
            this.rdbBusquedaConsumoFolios.CheckedChanged += new System.EventHandler(this.rdbBusquedaConsumoFolios_CheckedChanged);
            // 
            // rdbBusquedaLibroBoletas
            // 
            this.rdbBusquedaLibroBoletas.AutoSize = true;
            this.rdbBusquedaLibroBoletas.Location = new System.Drawing.Point(447, 99);
            this.rdbBusquedaLibroBoletas.Name = "rdbBusquedaLibroBoletas";
            this.rdbBusquedaLibroBoletas.Size = new System.Drawing.Size(114, 17);
            this.rdbBusquedaLibroBoletas.TabIndex = 44;
            this.rdbBusquedaLibroBoletas.TabStop = true;
            this.rdbBusquedaLibroBoletas.Text = "Libro de E-Boletas ";
            this.rdbBusquedaLibroBoletas.UseVisualStyleBackColor = true;
            this.rdbBusquedaLibroBoletas.CheckedChanged += new System.EventHandler(this.rdbBusquedaLibroBoletas_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Buscar DTE Para:";
            // 
            // rdbBusquedaLibroGuias
            // 
            this.rdbBusquedaLibroGuias.AutoSize = true;
            this.rdbBusquedaLibroGuias.Location = new System.Drawing.Point(447, 79);
            this.rdbBusquedaLibroGuias.Name = "rdbBusquedaLibroGuias";
            this.rdbBusquedaLibroGuias.Size = new System.Drawing.Size(93, 17);
            this.rdbBusquedaLibroGuias.TabIndex = 43;
            this.rdbBusquedaLibroGuias.TabStop = true;
            this.rdbBusquedaLibroGuias.Text = "Libro de Guias";
            this.rdbBusquedaLibroGuias.UseVisualStyleBackColor = true;
            this.rdbBusquedaLibroGuias.CheckedChanged += new System.EventHandler(this.rdbBusquedaLibroGuias_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Aptusoft.Properties.Resources.comprobar_la_lista_de_tareas_icono_7647_48;
            this.button1.Location = new System.Drawing.Point(935, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 91);
            this.button1.TabIndex = 29;
            this.button1.Text = "Consultar DTE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbEnviarDte
            // 
            this.rdbEnviarDte.AutoSize = true;
            this.rdbEnviarDte.Location = new System.Drawing.Point(447, 19);
            this.rdbEnviarDte.Name = "rdbEnviarDte";
            this.rdbEnviarDte.Size = new System.Drawing.Size(80, 17);
            this.rdbEnviarDte.TabIndex = 35;
            this.rdbEnviarDte.TabStop = true;
            this.rdbEnviarDte.Text = "Enviar a SII";
            this.rdbEnviarDte.UseVisualStyleBackColor = true;
            this.rdbEnviarDte.CheckedChanged += new System.EventHandler(this.rdbEnviarDte_CheckedChanged);
            // 
            // rdbBusquedaLibroCompras
            // 
            this.rdbBusquedaLibroCompras.AutoSize = true;
            this.rdbBusquedaLibroCompras.Location = new System.Drawing.Point(447, 59);
            this.rdbBusquedaLibroCompras.Name = "rdbBusquedaLibroCompras";
            this.rdbBusquedaLibroCompras.Size = new System.Drawing.Size(107, 17);
            this.rdbBusquedaLibroCompras.TabIndex = 37;
            this.rdbBusquedaLibroCompras.TabStop = true;
            this.rdbBusquedaLibroCompras.Text = "Libro de Compras";
            this.rdbBusquedaLibroCompras.UseVisualStyleBackColor = true;
            this.rdbBusquedaLibroCompras.CheckedChanged += new System.EventHandler(this.rdbBusquedaLibroCompras_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(765, 76);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 38);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rdbBusquedaLibroVentas
            // 
            this.rdbBusquedaLibroVentas.AutoSize = true;
            this.rdbBusquedaLibroVentas.Location = new System.Drawing.Point(447, 39);
            this.rdbBusquedaLibroVentas.Name = "rdbBusquedaLibroVentas";
            this.rdbBusquedaLibroVentas.Size = new System.Drawing.Size(99, 17);
            this.rdbBusquedaLibroVentas.TabIndex = 36;
            this.rdbBusquedaLibroVentas.TabStop = true;
            this.rdbBusquedaLibroVentas.Text = "Libro de Ventas";
            this.rdbBusquedaLibroVentas.UseVisualStyleBackColor = true;
            this.rdbBusquedaLibroVentas.CheckedChanged += new System.EventHandler(this.rdbBusquedaLibroVentas_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(436, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 134);
            this.panel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(831, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 134);
            this.panel4.TabIndex = 28;
            // 
            // chk41
            // 
            this.chk41.AutoSize = true;
            this.chk41.Location = new System.Drawing.Point(151, 44);
            this.chk41.Name = "chk41";
            this.chk41.Size = new System.Drawing.Size(133, 17);
            this.chk41.TabIndex = 44;
            this.chk41.Text = "41 - E-Boletas Exentas";
            this.chk41.UseVisualStyleBackColor = true;
            // 
            // tabControlBusqueda
            // 
            this.tabControlBusqueda.Controls.Add(this.tabPagePorFecha);
            this.tabControlBusqueda.Controls.Add(this.tabPagePorPeriodo);
            this.tabControlBusqueda.Location = new System.Drawing.Point(599, 4);
            this.tabControlBusqueda.Name = "tabControlBusqueda";
            this.tabControlBusqueda.SelectedIndex = 0;
            this.tabControlBusqueda.Size = new System.Drawing.Size(164, 114);
            this.tabControlBusqueda.TabIndex = 30;
            // 
            // tabPagePorFecha
            // 
            this.tabPagePorFecha.Controls.Add(this.panelFecha);
            this.tabPagePorFecha.Location = new System.Drawing.Point(4, 22);
            this.tabPagePorFecha.Name = "tabPagePorFecha";
            this.tabPagePorFecha.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePorFecha.Size = new System.Drawing.Size(156, 88);
            this.tabPagePorFecha.TabIndex = 0;
            this.tabPagePorFecha.Text = "Por Fecha";
            this.tabPagePorFecha.UseVisualStyleBackColor = true;
            // 
            // panelFecha
            // 
            this.panelFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panelFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFecha.Controls.Add(this.label10);
            this.panelFecha.Controls.Add(this.dtpBusquedaHasta);
            this.panelFecha.Controls.Add(this.label12);
            this.panelFecha.Controls.Add(this.dtpBusquedaDesde);
            this.panelFecha.Location = new System.Drawing.Point(3, 4);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(153, 78);
            this.panelFecha.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Desde";
            // 
            // dtpBusquedaHasta
            // 
            this.dtpBusquedaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBusquedaHasta.Location = new System.Drawing.Point(48, 39);
            this.dtpBusquedaHasta.Name = "dtpBusquedaHasta";
            this.dtpBusquedaHasta.Size = new System.Drawing.Size(98, 20);
            this.dtpBusquedaHasta.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Hasta";
            // 
            // dtpBusquedaDesde
            // 
            this.dtpBusquedaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBusquedaDesde.Location = new System.Drawing.Point(48, 16);
            this.dtpBusquedaDesde.Name = "dtpBusquedaDesde";
            this.dtpBusquedaDesde.Size = new System.Drawing.Size(98, 20);
            this.dtpBusquedaDesde.TabIndex = 40;
            // 
            // tabPagePorPeriodo
            // 
            this.tabPagePorPeriodo.Controls.Add(this.panel3);
            this.tabPagePorPeriodo.Location = new System.Drawing.Point(4, 22);
            this.tabPagePorPeriodo.Name = "tabPagePorPeriodo";
            this.tabPagePorPeriodo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePorPeriodo.Size = new System.Drawing.Size(156, 88);
            this.tabPagePorPeriodo.TabIndex = 1;
            this.tabPagePorPeriodo.Text = "Por Periodo";
            this.tabPagePorPeriodo.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbPeriodo);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 78);
            this.panel3.TabIndex = 43;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(3, 34);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(143, 21);
            this.cmbPeriodo.TabIndex = 39;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(3, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(143, 23);
            this.label34.TabIndex = 40;
            this.label34.Text = "Periodo Contable";
            // 
            // chk39
            // 
            this.chk39.AutoSize = true;
            this.chk39.Location = new System.Drawing.Point(151, 24);
            this.chk39.Name = "chk39";
            this.chk39.Size = new System.Drawing.Size(92, 17);
            this.chk39.TabIndex = 43;
            this.chk39.Text = "39 - E-Boletas";
            this.chk39.UseVisualStyleBackColor = true;
            // 
            // chk34
            // 
            this.chk34.AutoSize = true;
            this.chk34.Location = new System.Drawing.Point(11, 44);
            this.chk34.Name = "chk34";
            this.chk34.Size = new System.Drawing.Size(134, 17);
            this.chk34.TabIndex = 42;
            this.chk34.Text = "34 - E-Facturas Exenta";
            this.chk34.UseVisualStyleBackColor = true;
            // 
            // chk52
            // 
            this.chk52.AutoSize = true;
            this.chk52.Location = new System.Drawing.Point(11, 104);
            this.chk52.Name = "chk52";
            this.chk52.Size = new System.Drawing.Size(84, 17);
            this.chk52.TabIndex = 41;
            this.chk52.Text = "52 - E-Guias";
            this.chk52.UseVisualStyleBackColor = true;
            // 
            // chk35
            // 
            this.chk35.AutoSize = true;
            this.chk35.Location = new System.Drawing.Point(299, 44);
            this.chk35.Name = "chk35";
            this.chk35.Size = new System.Drawing.Size(82, 17);
            this.chk35.TabIndex = 38;
            this.chk35.Text = "35 - Boletas";
            this.chk35.UseVisualStyleBackColor = true;
            // 
            // chk60
            // 
            this.chk60.AutoSize = true;
            this.chk60.Location = new System.Drawing.Point(299, 64);
            this.chk60.Name = "chk60";
            this.chk60.Size = new System.Drawing.Size(126, 17);
            this.chk60.TabIndex = 33;
            this.chk60.Text = "60 - Notas de Credito";
            this.chk60.UseVisualStyleBackColor = true;
            // 
            // chk30
            // 
            this.chk30.AutoSize = true;
            this.chk30.Location = new System.Drawing.Point(299, 24);
            this.chk30.Name = "chk30";
            this.chk30.Size = new System.Drawing.Size(88, 17);
            this.chk30.TabIndex = 32;
            this.chk30.Text = "30 - Facturas";
            this.chk30.UseVisualStyleBackColor = true;
            // 
            // chk56
            // 
            this.chk56.AutoSize = true;
            this.chk56.Location = new System.Drawing.Point(11, 64);
            this.chk56.Name = "chk56";
            this.chk56.Size = new System.Drawing.Size(134, 17);
            this.chk56.TabIndex = 31;
            this.chk56.Text = "56 - E-Notas de Debito";
            this.chk56.UseVisualStyleBackColor = true;
            // 
            // chk61
            // 
            this.chk61.AutoSize = true;
            this.chk61.Location = new System.Drawing.Point(11, 84);
            this.chk61.Name = "chk61";
            this.chk61.Size = new System.Drawing.Size(136, 17);
            this.chk61.TabIndex = 30;
            this.chk61.Text = "61 - E-Notas de Credito";
            this.chk61.UseVisualStyleBackColor = true;
            // 
            // chk33
            // 
            this.chk33.AutoSize = true;
            this.chk33.Location = new System.Drawing.Point(11, 24);
            this.chk33.Name = "chk33";
            this.chk33.Size = new System.Drawing.Size(98, 17);
            this.chk33.TabIndex = 29;
            this.chk33.Text = "33 - E-Facturas";
            this.chk33.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(295, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "DOCUMENTOS PAPEL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "DOCUMENTOS ELECTRONICOS";
            // 
            // panelLibros
            // 
            this.panelLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panelLibros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLibros.Controls.Add(this.groupBox4);
            this.panelLibros.Controls.Add(this.btnGeneraLibro);
            this.panelLibros.Controls.Add(this.groupBox1);
            this.panelLibros.Controls.Add(this.groupBox5);
            this.panelLibros.Controls.Add(this.groupBox2);
            this.panelLibros.Location = new System.Drawing.Point(1069, 24);
            this.panelLibros.Name = "panelLibros";
            this.panelLibros.Size = new System.Drawing.Size(209, 521);
            this.panelLibros.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMes);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPeriodo);
            this.groupBox2.Controls.Add(this.nudAno);
            this.groupBox2.Location = new System.Drawing.Point(3, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 74);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Periodo Tributario";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 415);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1046, 204);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1038, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtro de Busqueda";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnResumenBoletaExenta);
            this.tabPage2.Controls.Add(this.btnResumenComprobantePago);
            this.tabPage2.Controls.Add(this.btnResumenBoleta);
            this.tabPage2.Controls.Add(this.dgvResumen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1038, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Totales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnResumenBoletaExenta
            // 
            this.btnResumenBoletaExenta.Location = new System.Drawing.Point(809, 149);
            this.btnResumenBoletaExenta.Name = "btnResumenBoletaExenta";
            this.btnResumenBoletaExenta.Size = new System.Drawing.Size(223, 23);
            this.btnResumenBoletaExenta.TabIndex = 35;
            this.btnResumenBoletaExenta.Text = "Ingresar Resumen de Boletas Exentas (38)";
            this.btnResumenBoletaExenta.UseVisualStyleBackColor = true;
            this.btnResumenBoletaExenta.Visible = false;
            this.btnResumenBoletaExenta.Click += new System.EventHandler(this.btnResumenBoletaExenta_Click);
            // 
            // btnResumenComprobantePago
            // 
            this.btnResumenComprobantePago.Location = new System.Drawing.Point(580, 149);
            this.btnResumenComprobantePago.Name = "btnResumenComprobantePago";
            this.btnResumenComprobantePago.Size = new System.Drawing.Size(223, 23);
            this.btnResumenComprobantePago.TabIndex = 34;
            this.btnResumenComprobantePago.Text = "Ingresar Comprobante de Pago (48)";
            this.btnResumenComprobantePago.UseVisualStyleBackColor = true;
            this.btnResumenComprobantePago.Click += new System.EventHandler(this.btnResumenComprobantePago_Click);
            // 
            // btnResumenBoleta
            // 
            this.btnResumenBoleta.Location = new System.Drawing.Point(351, 149);
            this.btnResumenBoleta.Name = "btnResumenBoleta";
            this.btnResumenBoleta.Size = new System.Drawing.Size(223, 23);
            this.btnResumenBoleta.TabIndex = 33;
            this.btnResumenBoleta.Text = "IngresarResumen de Boletas (35)";
            this.btnResumenBoleta.UseVisualStyleBackColor = true;
            this.btnResumenBoleta.Click += new System.EventHandler(this.btnResumenBoleta_Click);
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.AllowUserToResizeColumns = false;
            this.dgvResumen.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResumen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvResumen.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDocumento,
            this.Documento,
            this.Cantidad,
            this.NetoResumen,
            this.IvaResumen,
            this.ExentoResumen,
            this.TotalResumen,
            this.Impuesto1,
            this.Impuesto2,
            this.Impuesto3,
            this.Impuesto4,
            this.Impuesto5});
            this.dgvResumen.Location = new System.Drawing.Point(6, 6);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.RowHeadersVisible = false;
            this.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumen.Size = new System.Drawing.Size(1026, 137);
            this.dgvResumen.TabIndex = 0;
            // 
            // CodigoDocumento
            // 
            this.CodigoDocumento.DataPropertyName = "Fe_TipoDTE";
            this.CodigoDocumento.HeaderText = "Tipo";
            this.CodigoDocumento.Name = "CodigoDocumento";
            this.CodigoDocumento.ReadOnly = true;
            this.CodigoDocumento.Width = 50;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "DocumentoVenta";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "TotalDocumentado";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N0";
            dataGridViewCellStyle15.NullValue = "0";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle15;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // NetoResumen
            // 
            this.NetoResumen.DataPropertyName = "Neto";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = "0";
            this.NetoResumen.DefaultCellStyle = dataGridViewCellStyle16;
            this.NetoResumen.HeaderText = "Neto";
            this.NetoResumen.Name = "NetoResumen";
            this.NetoResumen.ReadOnly = true;
            // 
            // IvaResumen
            // 
            this.IvaResumen.DataPropertyName = "Iva";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = "0";
            this.IvaResumen.DefaultCellStyle = dataGridViewCellStyle17;
            this.IvaResumen.HeaderText = "Iva";
            this.IvaResumen.Name = "IvaResumen";
            this.IvaResumen.ReadOnly = true;
            // 
            // ExentoResumen
            // 
            this.ExentoResumen.DataPropertyName = "TotalExento";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = "0";
            this.ExentoResumen.DefaultCellStyle = dataGridViewCellStyle18;
            this.ExentoResumen.HeaderText = "Exento";
            this.ExentoResumen.Name = "ExentoResumen";
            this.ExentoResumen.ReadOnly = true;
            // 
            // TotalResumen
            // 
            this.TotalResumen.DataPropertyName = "Total";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N0";
            dataGridViewCellStyle19.NullValue = "0";
            this.TotalResumen.DefaultCellStyle = dataGridViewCellStyle19;
            this.TotalResumen.HeaderText = "Total";
            this.TotalResumen.Name = "TotalResumen";
            this.TotalResumen.ReadOnly = true;
            // 
            // Impuesto1
            // 
            this.Impuesto1.DataPropertyName = "Impuesto1";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = "0";
            this.Impuesto1.DefaultCellStyle = dataGridViewCellStyle20;
            this.Impuesto1.HeaderText = "Imp1";
            this.Impuesto1.Name = "Impuesto1";
            this.Impuesto1.ReadOnly = true;
            this.Impuesto1.Width = 70;
            // 
            // Impuesto2
            // 
            this.Impuesto2.DataPropertyName = "Impuesto2";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N0";
            dataGridViewCellStyle21.NullValue = "0";
            this.Impuesto2.DefaultCellStyle = dataGridViewCellStyle21;
            this.Impuesto2.HeaderText = "Imp2";
            this.Impuesto2.Name = "Impuesto2";
            this.Impuesto2.ReadOnly = true;
            this.Impuesto2.Width = 70;
            // 
            // Impuesto3
            // 
            this.Impuesto3.DataPropertyName = "Impuesto3";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N0";
            dataGridViewCellStyle22.NullValue = "0";
            this.Impuesto3.DefaultCellStyle = dataGridViewCellStyle22;
            this.Impuesto3.HeaderText = "Imp3";
            this.Impuesto3.Name = "Impuesto3";
            this.Impuesto3.ReadOnly = true;
            this.Impuesto3.Width = 70;
            // 
            // Impuesto4
            // 
            this.Impuesto4.DataPropertyName = "Impuesto4";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N0";
            dataGridViewCellStyle23.NullValue = "0";
            this.Impuesto4.DefaultCellStyle = dataGridViewCellStyle23;
            this.Impuesto4.HeaderText = "Imp4";
            this.Impuesto4.Name = "Impuesto4";
            this.Impuesto4.ReadOnly = true;
            this.Impuesto4.Width = 70;
            // 
            // Impuesto5
            // 
            this.Impuesto5.DataPropertyName = "Impuesto5";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N0";
            dataGridViewCellStyle24.NullValue = "0";
            this.Impuesto5.DefaultCellStyle = dataGridViewCellStyle24;
            this.Impuesto5.HeaderText = "Imp5";
            this.Impuesto5.Name = "Impuesto5";
            this.Impuesto5.ReadOnly = true;
            this.Impuesto5.Width = 70;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(4, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1062, 647);
            this.tabControl2.TabIndex = 30;
            this.tabControl2.Enter += new System.EventHandler(this.tabControl2_Enter);
            this.tabControl2.Leave += new System.EventHandler(this.tabControl2_Leave);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage3.Controls.Add(this.panelResumenBoletas);
            this.tabPage3.Controls.Add(this.dgvDatos);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1054, 621);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Inicial";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            this.tabPage3.Leave += new System.EventHandler(this.tabPage3_Leave);
            // 
            // panelResumenBoletas
            // 
            this.panelResumenBoletas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelResumenBoletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumenBoletas.Controls.Add(this.checkBox1);
            this.panelResumenBoletas.Controls.Add(this.button2);
            this.panelResumenBoletas.Controls.Add(this.txtPorcentajeIvaResumen);
            this.panelResumenBoletas.Controls.Add(this.btnIngresarResumenBoleta);
            this.panelResumenBoletas.Controls.Add(this.txtTotalBoletas);
            this.panelResumenBoletas.Controls.Add(this.txtExentoBoletas);
            this.panelResumenBoletas.Controls.Add(this.txtIvaBoletas);
            this.panelResumenBoletas.Controls.Add(this.txtNetoBoletas);
            this.panelResumenBoletas.Controls.Add(this.txtCantidadBoletas);
            this.panelResumenBoletas.Controls.Add(this.label22);
            this.panelResumenBoletas.Controls.Add(this.label21);
            this.panelResumenBoletas.Controls.Add(this.label20);
            this.panelResumenBoletas.Controls.Add(this.label19);
            this.panelResumenBoletas.Controls.Add(this.label18);
            this.panelResumenBoletas.Controls.Add(this.label17);
            this.panelResumenBoletas.Location = new System.Drawing.Point(401, 151);
            this.panelResumenBoletas.Name = "panelResumenBoletas";
            this.panelResumenBoletas.Size = new System.Drawing.Size(253, 235);
            this.panelResumenBoletas.TabIndex = 33;
            this.panelResumenBoletas.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 205);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Desea Editar Los Resultados";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "X7";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPorcentajeIvaResumen
            // 
            this.txtPorcentajeIvaResumen.Location = new System.Drawing.Point(107, 89);
            this.txtPorcentajeIvaResumen.Name = "txtPorcentajeIvaResumen";
            this.txtPorcentajeIvaResumen.Size = new System.Drawing.Size(29, 20);
            this.txtPorcentajeIvaResumen.TabIndex = 12;
            this.txtPorcentajeIvaResumen.Text = "19";
            this.txtPorcentajeIvaResumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresarResumenBoleta
            // 
            this.btnIngresarResumenBoleta.Location = new System.Drawing.Point(38, 168);
            this.btnIngresarResumenBoleta.Name = "btnIngresarResumenBoleta";
            this.btnIngresarResumenBoleta.Size = new System.Drawing.Size(176, 23);
            this.btnIngresarResumenBoleta.TabIndex = 11;
            this.btnIngresarResumenBoleta.Text = "Ingresar Resumen";
            this.btnIngresarResumenBoleta.UseVisualStyleBackColor = true;
            this.btnIngresarResumenBoleta.Click += new System.EventHandler(this.btnIngresarResumenBoleta_Click);
            // 
            // txtTotalBoletas
            // 
            this.txtTotalBoletas.Location = new System.Drawing.Point(107, 139);
            this.txtTotalBoletas.Name = "txtTotalBoletas";
            this.txtTotalBoletas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBoletas.TabIndex = 10;
            this.txtTotalBoletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExentoBoletas
            // 
            this.txtExentoBoletas.Location = new System.Drawing.Point(107, 114);
            this.txtExentoBoletas.Name = "txtExentoBoletas";
            this.txtExentoBoletas.Size = new System.Drawing.Size(100, 20);
            this.txtExentoBoletas.TabIndex = 9;
            this.txtExentoBoletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIvaBoletas
            // 
            this.txtIvaBoletas.Location = new System.Drawing.Point(140, 89);
            this.txtIvaBoletas.Name = "txtIvaBoletas";
            this.txtIvaBoletas.Size = new System.Drawing.Size(67, 20);
            this.txtIvaBoletas.TabIndex = 8;
            this.txtIvaBoletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNetoBoletas
            // 
            this.txtNetoBoletas.Location = new System.Drawing.Point(107, 64);
            this.txtNetoBoletas.Name = "txtNetoBoletas";
            this.txtNetoBoletas.Size = new System.Drawing.Size(100, 20);
            this.txtNetoBoletas.TabIndex = 7;
            this.txtNetoBoletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidadBoletas
            // 
            this.txtCantidadBoletas.Location = new System.Drawing.Point(107, 39);
            this.txtCantidadBoletas.Name = "txtCantidadBoletas";
            this.txtCantidadBoletas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadBoletas.TabIndex = 6;
            this.txtCantidadBoletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(34, 142);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 16);
            this.label22.TabIndex = 5;
            this.label22.Text = "Total";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(34, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 16);
            this.label21.TabIndex = 4;
            this.label21.Text = "Exento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(34, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 16);
            this.label20.TabIndex = 3;
            this.label20.Text = "Iva";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(34, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "Neto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(34, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Cantidad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Resumen de Boletas (35)";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage4.Controls.Add(this.btnLiberarLibro);
            this.tabPage4.Controls.Add(this.btnLiberarEnviado);
            this.tabPage4.Controls.Add(this.chkSeleccionarTodos);
            this.tabPage4.Controls.Add(this.panel7);
            this.tabPage4.Controls.Add(this.dgvDatosEnviados);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1054, 621);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Dte Enviados";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            this.tabPage4.Leave += new System.EventHandler(this.tabPage4_Leave);
            // 
            // btnLiberarLibro
            // 
            this.btnLiberarLibro.Location = new System.Drawing.Point(905, 481);
            this.btnLiberarLibro.Name = "btnLiberarLibro";
            this.btnLiberarLibro.Size = new System.Drawing.Size(139, 23);
            this.btnLiberarLibro.TabIndex = 55;
            this.btnLiberarLibro.Text = "Liberar Enviado a Libro";
            this.btnLiberarLibro.UseVisualStyleBackColor = true;
            this.btnLiberarLibro.Click += new System.EventHandler(this.btnLiberarLibro_Click);
            // 
            // btnLiberarEnviado
            // 
            this.btnLiberarEnviado.Location = new System.Drawing.Point(760, 481);
            this.btnLiberarEnviado.Name = "btnLiberarEnviado";
            this.btnLiberarEnviado.Size = new System.Drawing.Size(139, 23);
            this.btnLiberarEnviado.TabIndex = 54;
            this.btnLiberarEnviado.Text = "Liberar Enviados";
            this.btnLiberarEnviado.UseVisualStyleBackColor = true;
            this.btnLiberarEnviado.Click += new System.EventHandler(this.btnLiberarEnviado_Click);
            // 
            // chkSeleccionarTodos
            // 
            this.chkSeleccionarTodos.AutoSize = true;
            this.chkSeleccionarTodos.Location = new System.Drawing.Point(14, 8);
            this.chkSeleccionarTodos.Name = "chkSeleccionarTodos";
            this.chkSeleccionarTodos.Size = new System.Drawing.Size(115, 17);
            this.chkSeleccionarTodos.TabIndex = 53;
            this.chkSeleccionarTodos.Text = "Seleccionar Todos";
            this.chkSeleccionarTodos.UseVisualStyleBackColor = true;
            this.chkSeleccionarTodos.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodos_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.chk34Enviados);
            this.panel7.Controls.Add(this.dtpHastaEnviados);
            this.panel7.Controls.Add(this.btnBuscarEnviados);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.dtpDesdeEnviados);
            this.panel7.Controls.Add(this.chk52Enviados);
            this.panel7.Controls.Add(this.chk35Enviados);
            this.panel7.Controls.Add(this.chk60Enviados);
            this.panel7.Controls.Add(this.chk30Enviados);
            this.panel7.Controls.Add(this.chk56Enviados);
            this.panel7.Controls.Add(this.chk61Enviados);
            this.panel7.Controls.Add(this.chk33Enviados);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(5, 480);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(690, 134);
            this.panel7.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Desde";
            // 
            // chk34Enviados
            // 
            this.chk34Enviados.AutoSize = true;
            this.chk34Enviados.Location = new System.Drawing.Point(13, 46);
            this.chk34Enviados.Name = "chk34Enviados";
            this.chk34Enviados.Size = new System.Drawing.Size(185, 17);
            this.chk34Enviados.TabIndex = 52;
            this.chk34Enviados.Text = "34 - Facturas Exenta Electronicas";
            this.chk34Enviados.UseVisualStyleBackColor = true;
            // 
            // dtpHastaEnviados
            // 
            this.dtpHastaEnviados.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaEnviados.Location = new System.Drawing.Point(478, 49);
            this.dtpHastaEnviados.Name = "dtpHastaEnviados";
            this.dtpHastaEnviados.Size = new System.Drawing.Size(93, 20);
            this.dtpHastaEnviados.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Hasta";
            // 
            // dtpDesdeEnviados
            // 
            this.dtpDesdeEnviados.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeEnviados.Location = new System.Drawing.Point(478, 23);
            this.dtpDesdeEnviados.Name = "dtpDesdeEnviados";
            this.dtpDesdeEnviados.Size = new System.Drawing.Size(93, 20);
            this.dtpDesdeEnviados.TabIndex = 40;
            // 
            // chk52Enviados
            // 
            this.chk52Enviados.AutoSize = true;
            this.chk52Enviados.Location = new System.Drawing.Point(13, 102);
            this.chk52Enviados.Name = "chk52Enviados";
            this.chk52Enviados.Size = new System.Drawing.Size(135, 17);
            this.chk52Enviados.TabIndex = 51;
            this.chk52Enviados.Text = "52 - Guias Electronicas";
            this.chk52Enviados.UseVisualStyleBackColor = true;
            // 
            // chk35Enviados
            // 
            this.chk35Enviados.AutoSize = true;
            this.chk35Enviados.Location = new System.Drawing.Point(236, 47);
            this.chk35Enviados.Name = "chk35Enviados";
            this.chk35Enviados.Size = new System.Drawing.Size(82, 17);
            this.chk35Enviados.TabIndex = 50;
            this.chk35Enviados.Text = "35 - Boletas";
            this.chk35Enviados.UseVisualStyleBackColor = true;
            // 
            // chk60Enviados
            // 
            this.chk60Enviados.AutoSize = true;
            this.chk60Enviados.Location = new System.Drawing.Point(236, 66);
            this.chk60Enviados.Name = "chk60Enviados";
            this.chk60Enviados.Size = new System.Drawing.Size(126, 17);
            this.chk60Enviados.TabIndex = 49;
            this.chk60Enviados.Text = "60 - Notas de Credito";
            this.chk60Enviados.UseVisualStyleBackColor = true;
            // 
            // chk30Enviados
            // 
            this.chk30Enviados.AutoSize = true;
            this.chk30Enviados.Location = new System.Drawing.Point(236, 28);
            this.chk30Enviados.Name = "chk30Enviados";
            this.chk30Enviados.Size = new System.Drawing.Size(88, 17);
            this.chk30Enviados.TabIndex = 48;
            this.chk30Enviados.Text = "30 - Facturas";
            this.chk30Enviados.UseVisualStyleBackColor = true;
            // 
            // chk56Enviados
            // 
            this.chk56Enviados.AutoSize = true;
            this.chk56Enviados.Location = new System.Drawing.Point(13, 83);
            this.chk56Enviados.Name = "chk56Enviados";
            this.chk56Enviados.Size = new System.Drawing.Size(185, 17);
            this.chk56Enviados.TabIndex = 47;
            this.chk56Enviados.Text = "56 - Notas de Debito Electronicas";
            this.chk56Enviados.UseVisualStyleBackColor = true;
            // 
            // chk61Enviados
            // 
            this.chk61Enviados.AutoSize = true;
            this.chk61Enviados.Location = new System.Drawing.Point(13, 64);
            this.chk61Enviados.Name = "chk61Enviados";
            this.chk61Enviados.Size = new System.Drawing.Size(187, 17);
            this.chk61Enviados.TabIndex = 46;
            this.chk61Enviados.Text = "61 - Notas de Credito Electronicas";
            this.chk61Enviados.UseVisualStyleBackColor = true;
            // 
            // chk33Enviados
            // 
            this.chk33Enviados.AutoSize = true;
            this.chk33Enviados.Location = new System.Drawing.Point(13, 28);
            this.chk33Enviados.Name = "chk33Enviados";
            this.chk33Enviados.Size = new System.Drawing.Size(149, 17);
            this.chk33Enviados.TabIndex = 45;
            this.chk33Enviados.Text = "33 - Facturas Electronicas";
            this.chk33Enviados.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "DOCUMENTOS PAPEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "DOCUMENTOS ELECTRONICOS";
            // 
            // dgvDatosEnviados
            // 
            this.dgvDatosEnviados.AllowUserToAddRows = false;
            this.dgvDatosEnviados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Lavender;
            this.dgvDatosEnviados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvDatosEnviados.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatosEnviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEnviados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarEnviado,
            this.EnviarEnviados,
            this.TipoEnviado,
            this.FolioEnviado,
            this.IdFacturaEnviado,
            this.FechaEnviado,
            this.RutEnviado,
            this.RazonSocialEnviado,
            this.TotalEnviado,
            this.TrackIdEnvio,
            this.TrackIdEnvioLibro,
            this.EnviadoSii,
            this.EnviadoLibro});
            this.dgvDatosEnviados.Location = new System.Drawing.Point(4, 29);
            this.dgvDatosEnviados.Name = "dgvDatosEnviados";
            this.dgvDatosEnviados.RowHeadersVisible = false;
            this.dgvDatosEnviados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosEnviados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosEnviados.Size = new System.Drawing.Size(1040, 445);
            this.dgvDatosEnviados.TabIndex = 1;
            this.dgvDatosEnviados.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDatosEnviados_DataError);
            // 
            // SeleccionarEnviado
            // 
            this.SeleccionarEnviado.HeaderText = "";
            this.SeleccionarEnviado.Name = "SeleccionarEnviado";
            this.SeleccionarEnviado.Width = 30;
            // 
            // EnviarEnviados
            // 
            this.EnviarEnviados.DataPropertyName = "Enviar";
            this.EnviarEnviados.HeaderText = "EnviarEnviados";
            this.EnviarEnviados.Name = "EnviarEnviados";
            this.EnviarEnviados.Visible = false;
            // 
            // TipoEnviado
            // 
            this.TipoEnviado.DataPropertyName = "Fe_TipoDTE";
            this.TipoEnviado.HeaderText = "Tipo";
            this.TipoEnviado.Name = "TipoEnviado";
            this.TipoEnviado.ReadOnly = true;
            this.TipoEnviado.Width = 40;
            // 
            // FolioEnviado
            // 
            this.FolioEnviado.DataPropertyName = "Folio";
            this.FolioEnviado.HeaderText = "Folio";
            this.FolioEnviado.Name = "FolioEnviado";
            this.FolioEnviado.ReadOnly = true;
            this.FolioEnviado.Width = 60;
            // 
            // IdFacturaEnviado
            // 
            this.IdFacturaEnviado.DataPropertyName = "IdFactura";
            this.IdFacturaEnviado.HeaderText = "IdFactura";
            this.IdFacturaEnviado.Name = "IdFacturaEnviado";
            this.IdFacturaEnviado.ReadOnly = true;
            this.IdFacturaEnviado.Visible = false;
            this.IdFacturaEnviado.Width = 60;
            // 
            // FechaEnviado
            // 
            this.FechaEnviado.DataPropertyName = "FechaEmision";
            dataGridViewCellStyle26.Format = "d";
            dataGridViewCellStyle26.NullValue = null;
            this.FechaEnviado.DefaultCellStyle = dataGridViewCellStyle26;
            this.FechaEnviado.HeaderText = "Fecha";
            this.FechaEnviado.Name = "FechaEnviado";
            this.FechaEnviado.ReadOnly = true;
            this.FechaEnviado.Width = 80;
            // 
            // RutEnviado
            // 
            this.RutEnviado.DataPropertyName = "Rut";
            this.RutEnviado.HeaderText = "Rut";
            this.RutEnviado.Name = "RutEnviado";
            this.RutEnviado.ReadOnly = true;
            this.RutEnviado.Width = 80;
            // 
            // RazonSocialEnviado
            // 
            this.RazonSocialEnviado.DataPropertyName = "RazonSocial";
            this.RazonSocialEnviado.HeaderText = "RazonSocial";
            this.RazonSocialEnviado.Name = "RazonSocialEnviado";
            this.RazonSocialEnviado.ReadOnly = true;
            this.RazonSocialEnviado.Width = 330;
            // 
            // TotalEnviado
            // 
            this.TotalEnviado.DataPropertyName = "Total";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "N0";
            dataGridViewCellStyle27.NullValue = "0";
            this.TotalEnviado.DefaultCellStyle = dataGridViewCellStyle27;
            this.TotalEnviado.HeaderText = "Total";
            this.TotalEnviado.Name = "TotalEnviado";
            this.TotalEnviado.ReadOnly = true;
            // 
            // TrackIdEnvio
            // 
            this.TrackIdEnvio.DataPropertyName = "TrackIDEnvio";
            this.TrackIdEnvio.HeaderText = "TrackId Envio";
            this.TrackIdEnvio.Name = "TrackIdEnvio";
            // 
            // TrackIdEnvioLibro
            // 
            this.TrackIdEnvioLibro.DataPropertyName = "TrackIDLibro";
            this.TrackIdEnvioLibro.HeaderText = "TrackId Libro";
            this.TrackIdEnvioLibro.Name = "TrackIdEnvioLibro";
            // 
            // EnviadoSii
            // 
            this.EnviadoSii.DataPropertyName = "FE_enviado_Sii";
            this.EnviadoSii.HeaderText = "Env SII";
            this.EnviadoSii.Name = "EnviadoSii";
            this.EnviadoSii.ReadOnly = true;
            this.EnviadoSii.Width = 50;
            // 
            // EnviadoLibro
            // 
            this.EnviadoLibro.DataPropertyName = "FE_enviado_Libro";
            this.EnviadoLibro.HeaderText = "E Libro";
            this.EnviadoLibro.Name = "EnviadoLibro";
            this.EnviadoLibro.ReadOnly = true;
            this.EnviadoLibro.Width = 50;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(1305, 265);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(41, 13);
            this.lblres.TabIndex = 31;
            this.lblres.Text = "label14";
            this.lblres.Visible = false;
            // 
            // frmGeneraodrDeEnvios
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1370, 655);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.panelLibros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGeneraLibroCompras);
            this.Controls.Add(this.btnMuestraLibroCompra);
            this.Controls.Add(this.txtFE);
            this.Controls.Add(this.txtNCE);
            this.Controls.Add(this.txtNDE);
            this.Controls.Add(this.txtFacturaPapel);
            this.Controls.Add(this.txtNotaCreditoPapel);
            this.KeyPreview = true;
            this.Name = "frmGeneraodrDeEnvios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Envios";
            this.toolTip1.SetToolTip(this, "Permite Generar el set del libro de compras");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGeneraodrDeEnvios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRectifica.ResumeLayout(false);
            this.pnlRectifica.PerformLayout();
            this.pnlNotificacion.ResumeLayout(false);
            this.pnlNotificacion.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlBusqueda.ResumeLayout(false);
            this.tabPagePorFecha.ResumeLayout(false);
            this.panelFecha.ResumeLayout(false);
            this.panelFecha.PerformLayout();
            this.tabPagePorPeriodo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelLibros.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelResumenBoletas.ResumeLayout(false);
            this.panelResumenBoletas.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEnviados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

    private void iniciaFormulario()
    {
      this._totalePeriodoManualBoleta35 = (TotalesPeriodo) null;
      this.lista.Clear();
      this.listaResumen.Clear();
      this.dgvDatos.DataSource = (object) null;
      this.dgvResumen.DataSource = (object) null;
      this.chk33.Checked = true;
      this.chk34.Checked = true;
      this.chk61.Checked = true;
      this.chk56.Checked = true;
      this.chk52.Checked = true;
      this.chk30.Checked = false;
      this.chk35.Checked = false;
      this.chk60.Checked = false;
      this.chk30.Enabled = false;
      this.chk35.Enabled = false;
      this.chk60.Enabled = false;
      this.chk39.Enabled = false;
      this.chk41.Enabled = false;
      this.txtFE.Clear();
      this.txtNCE.Clear();
      this.txtNDE.Clear();
      this.txtFacturaPapel.Clear();
      this.txtNotaCreditoPapel.Clear();
      this.rdbEnviarDte.Checked = true;
      this.rdbBusquedaLibroVentas.Checked = false;
      this.rdbBusquedaLibroCompras.Checked = false;
      this.rdbBusquedaLibroGuias.Checked = false;
      this.rdbBusquedaLibroBoletas.Checked = false;
      this.tabControlBusqueda.Enabled = false;
      this.btnGeneraArchivoEnvio.Enabled = false;
      this.panelLibros.Enabled = false;
      this.panelLibros.Visible = false;
      this.rdbLibroVentas.Checked = true;
      this.rdbLibroCompras.Checked = false;
      this.rdbLibroGuias.Checked = false;
      this.rdbTAMensual.Checked = true;
      this.rdbTAEspecial.Checked = false;
      this.pnlNotificacion.Visible = false;
      this.pnlRectifica.Visible = false;
      this.txtNotificacion.Clear();
      this.cmbTipoEnvio.SelectedIndex = 0;
      this.txtPeriodo.Clear();
      //this.nudAno.Value = (Decimal) DateTime.Now.Year;
      //this.nudMes.Value = (Decimal) DateTime.Now.Month;
      this.creaPeriodo();
      this.btnGeneraLibro.Enabled = false;
      this.btnMuestraLibroCompra.Visible = false;
      this.rdbBusquedaLibroVentas.Enabled = true;
      this.rdbBusquedaLibroCompras.Enabled = true;
      this.rdbBusquedaConsumoFolios.Enabled = true;
      this.rdbBusquedaLibroBoletas.Enabled = true;
      this.rdbBusquedaLibroGuias.Enabled = true;
      this.rdbEnviarDte.Enabled = true;
      this.chk33Enviados.Checked = true;
      this.chk34Enviados.Checked = true;
      this.chk61Enviados.Checked = true;
      this.chk56Enviados.Checked = true;
      this.chk52Enviados.Checked = true;
      this.chk30Enviados.Checked = false;
      this.chk35Enviados.Checked = false;
      this.chk60Enviados.Checked = false;
      this.cargaPeriodos();
    }
    public List<string> P = new List<string>();
    private void btnBuscar_Click(object sender, EventArgs e)
    {
        Buscar_No_Enviado();
    }

    void Buscar_No_Enviado()
    {


        this.lista.Clear();

        if (this.rdbEnviarDte.Checked)
        {
            this.lista = new GeneraEnvios().buscaDosumentosSinEnviar(this.chk33.Checked, this.chk34.Checked, this.chk61.Checked, this.chk56.Checked, this.chk52.Checked);
            this.dgvDatos.DataSource = (object)null;
            this.dgvDatos.DataSource = (object)this.lista;
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgvDatos.Rows)
            {
                dataGridViewRow.Cells["Seleccionar"].Value = (object)true;

            }

            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {

                //P[i] = Convert.ToString(dgvDatos.Rows[3].Cells[i]);

                lblres.Text = Convert.ToString(dgvDatos.Rows[i].Cells["Folio"]);

            }

        }
        if (this.rdbBusquedaConsumoFolios.Checked)
        {
            this.lista = new GeneraEnvios().buscaDocumentoConsumoFolio();
            this.dgvDatos.DataSource = (object)null;
            this.dgvDatos.DataSource = (object)this.lista;
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgvDatos.Rows)
                dataGridViewRow.Cells["Seleccionar"].Value = (object)true;
        }
        if (this.rdbBusquedaLibroVentas.Checked)
        {
            this.lista = new GeneraEnvios().buscaDosumentosParaLibro(this.dtpBusquedaDesde.Value.ToString("yyyy-MM-dd"), this.dtpBusquedaHasta.Value.ToString("yyyy-MM-dd"), this.chk30.Checked, this.chk60.Checked, this.chk35.Checked);
            this.dgvDatos.DataSource = (object)null;
            this.dgvDatos.DataSource = (object)this.lista;
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgvDatos.Rows)
            {
                dataGridViewRow.Cells["Seleccionar"].Value = (object)true;
                dataGridViewRow.Cells["Seleccionar"].ReadOnly = true;
            }
        }
        if (this.rdbBusquedaLibroGuias.Checked)
        {
            this.lista = new GeneraEnvios().buscaDosumentosParaLibroGuias(this.dtpBusquedaDesde.Value.ToString("yyyy-MM-dd"), this.dtpBusquedaHasta.Value.ToString("yyyy-MM-dd"));
            this.dgvDatos.DataSource = (object)null;
            this.dgvDatos.DataSource = (object)this.lista;
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgvDatos.Rows)
                dataGridViewRow.Cells["Seleccionar"].Value = (object)true;
        }
        if (this.rdbBusquedaLibroBoletas.Checked)
        {
            this.lista = new GeneraEnvios().buscaDosumentosParaLibroBoletas(this.dtpBusquedaDesde.Value.ToString("yyyy-MM-dd"), this.dtpBusquedaHasta.Value.ToString("yyyy-MM-dd"));
            this.dgvDatos.DataSource = (object)null;
            this.dgvDatos.DataSource = (object)this.lista;
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgvDatos.Rows)
                dataGridViewRow.Cells["Seleccionar"].Value = (object)true;
        }
        if (this.rdbBusquedaLibroCompras.Checked)
        {
            if (this.tabControlBusqueda.SelectedTab == this.tabPagePorFecha)
                this.lista = new GeneraEnvios().buscaDocumentosLibroCompra("DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.dtpBusquedaDesde.Value.ToString("yyyy-MM-dd") + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.dtpBusquedaHasta.Value.ToString("yyyy-MM-dd") + "'");
            else
                this.lista = new GeneraEnvios().buscaDocumentosLibroCompra("periodo='" + this.cmbPeriodo.Text.ToString().ToUpper() + "'");
            this.dgvDatos.DataSource = (object)null;
            this.dgvDatos.DataSource = (object)this.lista;
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgvDatos.Rows)
            {
                dataGridViewRow.Cells["Seleccionar"].Value = (object)true;
                dataGridViewRow.Cells["Seleccionar"].ReadOnly = true;
            }
        }
        if (this.lista.Count > 0)
        {
            Decimal num1 = new Decimal(0);
            Decimal num2 = new Decimal(0);
            Decimal num3 = new Decimal(0);
            Decimal num4 = new Decimal(0);
            Decimal num5 = new Decimal(0);
            Decimal num6 = new Decimal(0);
            Decimal num7 = new Decimal(0);
            Decimal num8 = new Decimal(0);
            Decimal num9 = new Decimal(0);
            Decimal num10 = new Decimal(0);
            Decimal num11 = new Decimal(0);
            Decimal num12 = new Decimal(0);
            Decimal num13 = new Decimal(0);
            Decimal num14 = new Decimal(0);
            Decimal num15 = new Decimal(0);
            Decimal num16 = new Decimal(0);
            Decimal num17 = new Decimal(0);
            Decimal num18 = new Decimal(0);
            Decimal num19 = new Decimal(0);
            Decimal num20 = new Decimal(0);
            Decimal num21 = new Decimal(0);
            Decimal num22 = new Decimal(0);
            Decimal num23 = new Decimal(0);
            Decimal num24 = new Decimal(0);
            Decimal num25 = new Decimal(0);
            Decimal num26 = new Decimal(0);
            Decimal num27 = new Decimal(0);
            Decimal num28 = new Decimal(0);
            Decimal num29 = new Decimal(0);
            Decimal num30 = new Decimal(0);
            Decimal num31 = new Decimal(0);
            Decimal num32 = new Decimal(0);
            Decimal num33 = new Decimal(0);
            Decimal num34 = new Decimal(0);
            Decimal num35 = new Decimal(0);
            Decimal num36 = new Decimal(0);
            Decimal num37 = new Decimal(0);
            int num38 = 0;
            int num39 = 0;
            int num40 = 0;
            int num41 = 0;
            int num42 = 0;
            int num43 = 0;
            int num44 = 0;
            int num45 = 0;
            Decimal num46 = new Decimal(0);
            Decimal num47 = new Decimal(0);
            Decimal num48 = new Decimal(0);
            Decimal num49 = new Decimal(0);
            Decimal num50 = new Decimal(0);
            Decimal num51 = new Decimal(0);
            Decimal num52 = new Decimal(0);
            Decimal num53 = new Decimal(0);
            Decimal num54 = new Decimal(0);
            Decimal num55 = new Decimal(0);
            Decimal num56 = new Decimal(0);
            Decimal num57 = new Decimal(0);
            Decimal num58 = new Decimal(0);
            Decimal num59 = new Decimal(0);
            Decimal num60 = new Decimal(0);

            //Numeros para la guia de despacho papel (50)
            Decimal num61 = new Decimal(0);
            Decimal num62 = new Decimal(0);
            Decimal num63 = new Decimal(0);
            Decimal num64 = new Decimal(0);
            Decimal num65 = new Decimal(0);
            Decimal num66 = new Decimal(0);
            Decimal num67 = new Decimal(0);
            Decimal num68 = new Decimal(0);
            Decimal num69 = new Decimal(0);
            Decimal num70 = new Decimal(0);

            //Numeros para Factura compra papel (45)
            Decimal num71 = new Decimal(0);
            Decimal num72 = new Decimal(0);
            Decimal num73 = new Decimal(0);
            Decimal num74 = new Decimal(0);
            Decimal num75 = new Decimal(0);
            Decimal num76 = new Decimal(0);
            Decimal num77 = new Decimal(0);
            Decimal num78 = new Decimal(0);
            Decimal num79 = new Decimal(0);
            Decimal num80 = new Decimal(0);

            //Numeros para Factura compra electronica (46)
            Decimal num81 = new Decimal(0);
            Decimal num82 = new Decimal(0);
            Decimal num83 = new Decimal(0);
            Decimal num84 = new Decimal(0);
            Decimal num85 = new Decimal(0);
            Decimal num86 = new Decimal(0);
            Decimal num87 = new Decimal(0);
            Decimal num88 = new Decimal(0);
            Decimal num89 = new Decimal(0);
            Decimal num90 = new Decimal(0);

            //Numeros para Factura compra electronica (46)
            Decimal num91 = new Decimal(0);
            Decimal num92 = new Decimal(0);
            Decimal num93 = new Decimal(0);
            Decimal num94 = new Decimal(0);
            Decimal num95 = new Decimal(0);
            Decimal num96 = new Decimal(0);
            Decimal num97 = new Decimal(0);
            Decimal num98 = new Decimal(0);
            Decimal num99 = new Decimal(0);
            Decimal num100 = new Decimal(0);

            //Numeros para Factura Exenta
            Decimal num101 = new Decimal(0);
            Decimal num102 = new Decimal(0);
            Decimal num103 = new Decimal(0);
            Decimal num104 = new Decimal(0);
            Decimal num105 = new Decimal(0);

            //Numeros para impuestos (30) (60)
            Decimal num151 = new Decimal(0);
            Decimal num152 = new Decimal(0);
            Decimal num153 = new Decimal(0);
            Decimal num154 = new Decimal(0);
            Decimal num155 = new Decimal(0);
            Decimal num156 = new Decimal(0);
            Decimal num157 = new Decimal(0);
            Decimal num158 = new Decimal(0);
            Decimal num159 = new Decimal(0);
            Decimal num160 = new Decimal(0);

            //Numeros para Boletas Electrónicas
            Decimal num106 = new Decimal(0);
            Decimal num107 = new Decimal(0);
            Decimal num108 = new Decimal(0);
            Decimal num109 = new Decimal(0);
            Decimal num110 = new Decimal(0);
            Decimal num111 = new Decimal(0);
            Decimal num112 = new Decimal(0);
            Decimal num113 = new Decimal(0);
            Decimal num114 = new Decimal(0);
            Decimal num115 = new Decimal(0);

            foreach (Venta venta in this.lista)
            {
                //Boletas Electrónicas
                if (venta.Fe_TipoDTE == 39)
                {
                    num106 += venta.Neto;
                    num107 += venta.Iva;
                    num108 += venta.TotalExento;
                    num109 += venta.Total;
                    num110 += venta.Impuesto1;
                    num111 += venta.Impuesto2;
                    num112 += venta.Impuesto3;
                    num113 += venta.Impuesto4;
                    num114 += venta.Impuesto5;
                    ++num115;
                }

                //Factura Papel
                if (venta.Fe_TipoDTE == 30)
                {
                    num1 += venta.Neto;
                    num2 += venta.Iva;
                    num3 += venta.TotalExento;
                    num4 += venta.Total;
                    num151 += venta.Impuesto1;
                    num152 += venta.Impuesto2;
                    num153 += venta.Impuesto3;
                    num154 += venta.Impuesto4;
                    num155 += venta.Impuesto5;
                    ++num38;
                }
                //Factura Exenta Electrónica 
                if (venta.Fe_TipoDTE == 34)
                {
                    num5 += venta.Neto;
                    num6 += venta.Iva;
                    num7 += venta.TotalExento;
                    num8 += venta.Total;
                    ++num41;
                }
                //Factura Exenta Papel
                if (venta.Fe_TipoDTE == 32)
                {
                    num101 += venta.Neto;
                    num102 += venta.Iva;
                    num103 += venta.TotalExento;
                    num104 += venta.Total;
                    ++num105;
                }
                //Total Operaciones del Mes, Boletas
                if (venta.Fe_TipoDTE == 35)
                {
                    num9 += venta.Neto;
                    num10 += venta.Iva;
                    num11 += venta.TotalExento;
                    num12 += venta.Total;
                    ++num42;
                }
                //Nota de Credito Papel
                if (venta.Fe_TipoDTE == 60)
                {
                    num13 += venta.Neto;
                    num14 += venta.Iva;
                    num15 += venta.TotalExento;
                    num16 += venta.Total;
                    num156 += venta.Impuesto1;
                    num157 += venta.Impuesto2;
                    num158+= venta.Impuesto3;
                    num159 += venta.Impuesto4;
                    num160 += venta.Impuesto5;
                    ++num39;
                }
                if (venta.Fe_TipoDTE == 33)
                {
                    num21 += venta.Impuesto1;
                    num22 += venta.Impuesto2;
                    num23 += venta.Impuesto3;
                    num24 += venta.Impuesto4;
                    num25 += venta.Impuesto5;
                    num17 += venta.Neto;
                    num18 += venta.Iva;
                    num19 += venta.TotalExento;
                    num20 += venta.Total;
                    ++num40;
                }
                if (venta.Fe_TipoDTE == 61)
                {
                    num26 += venta.Neto;
                    num27 += venta.Iva;
                    num28 += venta.TotalExento;
                    num29 += venta.Total;
                    num46 += venta.Impuesto1;
                    num47 += venta.Impuesto2;
                    num48 += venta.Impuesto3;
                    num49 += venta.Impuesto4;
                    num50 += venta.Impuesto5;
                    ++num43;
                }
                if (venta.Fe_TipoDTE == 56)
                {

                    num30 += venta.Neto;
                    num31 += venta.Iva;
                    num32 += venta.TotalExento;
                    num33 += venta.Total;
                    num51 += venta.Impuesto1;
                    num52 += venta.Impuesto2;
                    num53 += venta.Impuesto3;
                    num54 += venta.Impuesto4;
                    num55 += venta.Impuesto5;
                    ++num44;
                }
                if (venta.Fe_TipoDTE == 52)
                {
                    num34 += venta.Neto;
                    num35 += venta.Iva;
                    num36 += venta.TotalExento;
                    num37 += venta.Total;
                    num56 += venta.Impuesto1;
                    num57 += venta.Impuesto2;
                    num58 += venta.Impuesto3;
                    num59 += venta.Impuesto4;
                    num60 += venta.Impuesto5;
                    ++num45;
                }
                if (venta.Fe_TipoDTE == 50)
                {
                    num61 += venta.Neto;
                    num62 += venta.Iva;
                    num63 += venta.TotalExento;
                    num64 += venta.Total;
                    num65 += venta.Impuesto1;
                    num66 += venta.Impuesto2;
                    num67 += venta.Impuesto3;
                    num68 += venta.Impuesto4;
                    num69 += venta.Impuesto5;
                    ++num70;
                }
                if (venta.Fe_TipoDTE == 45)
                {
                    num71 += venta.Neto;
                    num72 += venta.Iva;
                    num73 += venta.TotalExento;
                    num74 += venta.Total;
                    num75 += venta.Impuesto1;
                    num76 += venta.Impuesto2;
                    num77 += venta.Impuesto3;
                    num78 += venta.Impuesto4;
                    num79 += venta.Impuesto5;
                    ++num80;
                }
                if (venta.Fe_TipoDTE == 46)
                {
                    num81 += venta.Neto;
                    num82 += venta.Iva;
                    num83 += venta.TotalExento;
                    num84 += venta.Total;
                    num85 += venta.Impuesto1;
                    num86 += venta.Impuesto2;
                    num87 += venta.Impuesto3;
                    num88 += venta.Impuesto4;
                    num89 += venta.Impuesto5;
                    ++num90;
                }
                if (venta.Fe_TipoDTE == 55)
                {
                    num91 += venta.Neto;
                    num92 += venta.Iva;
                    num93 += venta.TotalExento;
                    num94 += venta.Total;
                    num95 += venta.Impuesto1;
                    num96 += venta.Impuesto2;
                    num97 += venta.Impuesto3;
                    num98 += venta.Impuesto4;
                    num99 += venta.Impuesto5;
                    ++num100;
                }
            }
            this.listaResumen.Clear();
            Venta venta1 = new Venta();
            if (num38 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "FACTURA",
                    Fe_TipoDTE = 30,
                    Neto = num1,
                    Iva = num2,
                    TotalExento = num3,
                    Total = num4,
                    TotalDocumentado = (Decimal)num38,
                    Impuesto1 = num151,
                    Impuesto2 = num152,
                    Impuesto3 = num153,
                    Impuesto4 = num154,
                    Impuesto5 = num155
                });
            if (num42 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "BOLETA",
                    Fe_TipoDTE = 35,
                    Neto = num9,
                    Iva = num10,
                    TotalExento = num11,
                    Total = num12,
                    TotalDocumentado = (Decimal)num42
                });

            if (num115 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "BOLETA ELECTRONICA",
                    Fe_TipoDTE = 39,
                    Neto = num106,
                    Iva = num107,
                    TotalExento = num108,
                    Total = num109,
                    TotalDocumentado = (Decimal)num115,
                    Impuesto1 = num110,
                    Impuesto2 = num111,
                    Impuesto3 = num112,
                    Impuesto4 = num113,
                    Impuesto5 = num114
                });
            
            if (num40 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "FACTURA ELECTRONICA",
                    Fe_TipoDTE = 33,
                    Neto = num17,
                    Iva = num18,
                    TotalExento = num19,
                    Total = num20,
                    TotalDocumentado = (Decimal)num40,
                    Impuesto1 = num21,
                    Impuesto2 = num22,
                    Impuesto3 = num23,
                    Impuesto4 = num24,
                    Impuesto5 = num25
                });

            if (num105 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "FACTURA EXENTA",
                    Fe_TipoDTE = 32,
                    Neto = num101,
                    Iva = num102,
                    TotalExento = num103,
                    Total = num104,
                    TotalDocumentado = (Decimal)num105
                });

            if (num41 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "FACTURA EXENTA ELECTRONICA",
                    Fe_TipoDTE = 34,
                    Neto = num5,
                    Iva = num6,
                    TotalExento = num7,
                    Total = num8,
                    TotalDocumentado = (Decimal)num41
                });

            if (num43 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "NOTA CREDITO ELECTRONICA",
                    Fe_TipoDTE = 61,
                    Neto = num26,
                    Iva = num27,
                    TotalExento = num28,
                    Total = num29,
                    TotalDocumentado = (Decimal)num43,
                    Impuesto1 = num46,
                    Impuesto2 = num47,
                    Impuesto3 = num48,
                    Impuesto4 = num49,
                    Impuesto5 = num50
                });
            if (num39 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "NOTA CREDITO",
                    Fe_TipoDTE = 60,
                    Neto = num13,
                    Iva = num14,
                    TotalExento = num15,
                    Total = num16,
                    TotalDocumentado = (Decimal)num39,
                    Impuesto1 = num156,
                    Impuesto2 = num157,
                    Impuesto3 = num158,
                    Impuesto4 = num159,
                    Impuesto5 = num160
                });
            if (num44 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "NOTA DEBITO ELECTRONICA",
                    Fe_TipoDTE = 56,
                    Neto = num30,
                    Iva = num31,
                    TotalExento = num32,
                    Total = num33,
                    TotalDocumentado = (Decimal)num44,
                    Impuesto1 = num51,
                    Impuesto2 = num52,
                    Impuesto3 = num53,
                    Impuesto4 = num54,
                    Impuesto5 = num55
                });
            if (num100 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "NOTA DEBITO",
                    Fe_TipoDTE = 55,
                    Neto = num91,
                    Iva = num92,
                    TotalExento = num93,
                    Total = num94,
                    TotalDocumentado = (Decimal)num100,
                    Impuesto1 = num95,
                    Impuesto2 = num96,
                    Impuesto3 = num97,
                    Impuesto4 = num98,
                    Impuesto5 = num99
                });
            if (num45 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "GUIA DESPACHO ELECTRONICA",
                    Fe_TipoDTE = 52,
                    Neto = num34,
                    Iva = num35,
                    TotalExento = num36,
                    Total = num37,
                    TotalDocumentado = (Decimal)num45,
                    Impuesto1 = num56,
                    Impuesto2 = num57,
                    Impuesto3 = num58,
                    Impuesto4 = num59,
                    Impuesto5 = num60
                });
            if (num70 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "GUIA DESPACHO",
                    Fe_TipoDTE = 50,
                    Neto = num61,
                    Iva = num62,
                    TotalExento = num63,
                    Total = num64,
                    TotalDocumentado = (Decimal)num70,
                    Impuesto1 = num65,
                    Impuesto2 = num66,
                    Impuesto3 = num67,
                    Impuesto4 = num68,
                    Impuesto5 = num69
                });
            if (num80 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "FACTURA COMPRA",
                    Fe_TipoDTE = 45,
                    Neto = num71,
                    Iva = num72,
                    TotalExento = num73,
                    Total = num74,
                    TotalDocumentado = (Decimal)num80,
                    Impuesto1 = num75,
                    Impuesto2 = num76,
                    Impuesto3 = num77,
                    Impuesto4 = num78,
                    Impuesto5 = num79
                });
            if (num90 > 0)
                this.listaResumen.Add(new Venta()
                {
                    DocumentoVenta = "FACTURA COMPRA ELECTRONICA",
                    Fe_TipoDTE = 46,
                    Neto = num81,
                    Iva = num82,
                    TotalExento = num83,
                    Total = num84,
                    TotalDocumentado = (Decimal)num90,
                    Impuesto1 = num85,
                    Impuesto2 = num86,
                    Impuesto3 = num87,
                    Impuesto4 = num88,
                    Impuesto5 = num89
                });

            this.dgvResumen.DataSource = (object)null;
            this.dgvResumen.DataSource = (object)this.listaResumen;
            if (this.rdbEnviarDte.Checked)
            {
                this.btnGeneraArchivoEnvio.Enabled = true;
                this.rdbBusquedaLibroVentas.Enabled = false;
                this.rdbBusquedaLibroCompras.Enabled = false;
                this.rdbBusquedaLibroBoletas.Enabled = false;
                this.rdbBusquedaLibroGuias.Enabled = false;
                this.rdbBusquedaConsumoFolios.Enabled = false;
            }
            if (this.rdbBusquedaConsumoFolios.Checked)
            {
                this.btnGeneraArchivoEnvio.Enabled = true;
                this.rdbBusquedaLibroVentas.Enabled = false;
                this.rdbBusquedaLibroCompras.Enabled = false;
                this.rdbBusquedaLibroBoletas.Enabled = false;
                this.rdbBusquedaLibroGuias.Enabled = false;
                this.rdbBusquedaConsumoFolios.Enabled = true;
            }
            if (this.rdbBusquedaLibroVentas.Checked)
            {
                this.panelLibros.Visible = true;
                this.panelLibros.Enabled = true;
                this.rdbLibroVentas.Checked = true;
                this.rdbLibroCompras.Checked = false;
                this.rdbLibroBoletas.Checked = false;
                this.rdbLibroBoletas.Enabled = false;
                this.btnGeneraArchivoEnvio.Enabled = false;
                this.rdbEnviarDte.Enabled = false;
                this.rdbBusquedaLibroCompras.Enabled = false;
                this.rdbBusquedaLibroBoletas.Enabled = false;
                this.rdbBusquedaLibroGuias.Enabled = false;
                this.rdbBusquedaConsumoFolios.Enabled = false;
                this.btnGeneraLibro.Enabled = true;
                this.rdbTAMensual.Enabled = true;
                this.rdbTARectifica.Enabled = true;
            }
            if (this.rdbBusquedaLibroGuias.Checked)
            {
                this.panelLibros.Visible = true;
                this.panelLibros.Enabled = true;
                this.rdbLibroGuias.Checked = true;
                this.rdbLibroBoletas.Checked = false;
                this.rdbLibroVentas.Checked = false;
                this.rdbLibroCompras.Checked = false;
                this.btnGeneraArchivoEnvio.Enabled = false;
                this.rdbEnviarDte.Enabled = false;
                this.rdbBusquedaLibroCompras.Enabled = false;
                this.rdbBusquedaLibroVentas.Enabled = false;
                this.rdbBusquedaLibroBoletas.Enabled = false;
                this.rdbBusquedaConsumoFolios.Enabled = false;
                this.btnGeneraLibro.Enabled = true;
                this.rdbTAEspecial.Checked = true;
                this.rdbTAMensual.Checked = false;
                this.rdbTARectifica.Checked = false;
                this.rdbTAMensual.Enabled = false;
                this.rdbTARectifica.Enabled = false;
                this.pnlNotificacion.Visible = true;
            }
            if (this.rdbBusquedaLibroBoletas.Checked)
            {
                this.panelLibros.Visible = true;
                this.panelLibros.Enabled = true;
                this.rdbLibroGuias.Checked = false;
                this.rdbLibroBoletas.Checked = true;
                this.rdbLibroVentas.Checked = false;
                this.rdbLibroCompras.Checked = false;
                this.btnGeneraArchivoEnvio.Enabled = false;
                this.rdbEnviarDte.Enabled = false;
                this.rdbBusquedaLibroCompras.Enabled = false;
                this.rdbBusquedaLibroVentas.Enabled = false;
                this.rdbBusquedaLibroGuias.Enabled = false;
                this.rdbBusquedaConsumoFolios.Enabled = false;
                this.btnGeneraLibro.Enabled = true;
                this.rdbTAEspecial.Checked = true;
                this.rdbTAMensual.Checked = false;
                this.rdbTARectifica.Checked = false;
                this.rdbTAMensual.Enabled = false;
                this.rdbTARectifica.Enabled = false;
                this.pnlNotificacion.Visible = true;
            }
            if (!this.rdbLibroCompras.Checked)
                return;
            this.panelLibros.Visible = true;
            this.panelLibros.Enabled = true;
            this.rdbLibroVentas.Checked = false;
            this.rdbLibroBoletas.Checked = false;
            this.rdbLibroCompras.Checked = true;
            this.btnGeneraArchivoEnvio.Enabled = false;
            this.rdbEnviarDte.Enabled = false;
            this.rdbBusquedaLibroVentas.Enabled = false;
            this.rdbBusquedaLibroBoletas.Enabled = false;
            this.rdbBusquedaLibroGuias.Enabled = false;
            this.rdbBusquedaConsumoFolios.Enabled = false;
            this.btnGeneraLibro.Enabled = true;
            this.rdbTAMensual.Enabled = true;
            this.rdbTARectifica.Enabled = true;
        }
        else
        {
            int num = (int)MessageBox.Show("No se encontraron DTES para enviar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
    private void btnGeneraArchivoEnvio_Click(object sender, EventArgs e)
    {
        Crear_envio_xml();
    }
    void Crear_envio_xml()
    {
        if (this.SacarNoSeleccionadas())
        {
            this.comprobarExisteArchivo();
            if (this.lista.Count > 0)
            {
                try
                {
                    List<Venta> list = new List<Venta>();
                    foreach (Venta venta in this.lista)
                    {
                        if (venta.Enviar)
                            list.Add(venta);
                    }
                    
                    if (this.rdbEnviarDte.Checked)
                    {
                        string archivo = new GeneradorXML().agregaListadoDteASetDte(list);
                        if (this._rutaElectronica.Length == 0)
                            this.CargaRuta();
                        string ruta = this._rutaElectronica + "DTE\\Envios\\";
                        int num1 = (int)MessageBox.Show("Archivo DTE Creado : " + archivo, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        int num2 = (int)new frmEnviosSII(archivo, ruta, list, "ENVIO").ShowDialog();
                    }
                    if (this.rdbBusquedaConsumoFolios.Checked)
                    {
                        string archivo = new csGeneraXMLreporteConsumoFolios().CreaXMLreporteConsumoFolios(list);
                        if (this._rutaElectronica.Length == 0)
                            this.CargaRuta();
                        string ruta = this._rutaElectronica + "DTE\\ReporteConsumoFolios\\";
                        int num1 = (int)MessageBox.Show("Reporte de Consumo de Folios Creado : " + archivo, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        int num2 = (int)new frmEnviosSII(archivo, ruta, list, "CONSUMO_FOLIOS").ShowDialog();
                    }
                    this.iniciaFormulario();
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                int num3 = (int)MessageBox.Show("No Hay DTES para enviar ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        else
        {
            int num4 = (int)MessageBox.Show("No Hay DTES Seleccionados ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }

    private bool SacarNoSeleccionadas()
    {
        int num1 = 0;
        try
        {
            
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dgvDatos.Rows)
            {
                if (Convert.ToBoolean(dataGridViewRow.Cells["Seleccionar"].Value))
                {
                    int num2 = dataGridViewRow.Cells["Tipo"].Value.ToString().Length > 0 ? Convert.ToInt32(dataGridViewRow.Cells["Tipo"].Value.ToString()) : 0;
                    int num3 = Convert.ToInt32(dataGridViewRow.Cells["Folio"].Value.ToString());
                    int num4 = Convert.ToInt32(dataGridViewRow.Cells["IdFactura"].Value.ToString());
                    for (int index = 0; index < this.lista.Count; ++index)
                    {
                        if (this.lista[index].Folio == num3 && this.lista[index].Fe_TipoDTE == num2 && this.lista[index].IdFactura == num4)
                        {
                            this.lista[index].Enviar = true;
                            ++num1;
                            break;
                        }
                    }
                }
            }
            
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
        }
        return num1 > 0;
    }

    private void comprobarExisteArchivo()
    {
      for (int index1 = 0; index1 < this.lista.Count; ++index1)
      {
        if (this.lista[index1].Enviar)
        {
          string str = this.lista[index1].Folio.ToString("##");
          int feTipoDte = this.lista[index1].Fe_TipoDTE;
            string folio = this.lista[index1].Folio.ToString();
            string tipo = "";
          string path = "";
          if (feTipoDte == 33)
              tipo = "DTE\\E-Factura\\EFacturaXML\\EFactura_";
            path = this._rutaElectronica + tipo + str +"_"+multi+ ".XML";
            if (feTipoDte == 34)
                tipo = "DTE\\E-FacturaExenta\\EFacturaExentaXML\\EFacturaExenta_";
            path = this._rutaElectronica + tipo + str + ".XML";
            if (feTipoDte == 61)
                tipo = "DTE\\E-NotaCredito\\ENotaCreditoXML\\ENotaCredito_";
            path = this._rutaElectronica + tipo + str + "_" + multi + ".XML";
            if (feTipoDte == 56)
                tipo = "DTE\\E-NotaDebito\\ENotaDebitoXML\\ENotaDebito_";
            path = this._rutaElectronica + tipo + str + "_" + multi + ".XML";
            if (feTipoDte == 52)
                tipo = "DTE\\E-Guia\\EGuiaXML\\EGuia_";
            path = this._rutaElectronica + tipo + str + "_" + multi + ".XML";
            if (feTipoDte == 39)
                tipo = "DTE\\E-Boleta\\EBoletaXML\\EBoleta_";
            path = this._rutaElectronica + tipo + str + "_" + multi + ".XML";
          try
          {
              SubeXMLToDb sube = new SubeXMLToDb();
              if (!File.Exists(path))
              {
                  //SubeXMLToDb sube = new SubeXMLToDb();
                  sube.Recupera(folio, tipo);
                  //int num = (int)MessageBox.Show("El Archivo " + path + " NO existe, sera quitado de la lista de envio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                  //    if (num <= 0){

                  //}else{
                  //    for (int index2 = 0; index2 < this.lista.Count; ++index2)
                  //    {
                  //        if (this.lista[index2].Folio == this.lista[index1].Folio && this.lista[index2].Fe_TipoDTE == this.lista[index1].Fe_TipoDTE)
                  //        {
                  //            this.lista.RemoveAt(index2);
                  //            --index2;
                  //            --index1;
                  //        }
                  //    }
                  //}
              }
              if (sube.existe(folio, tipo))// == false)
              {

                  XmlDocument xd = new XmlDocument();
                  xd.Load(path);
                  XmlNodeList nodelist = xd.SelectNodes("DTE/Documento/Encabezado/IdDoc");
                  foreach (XmlNode node in nodelist) // for each <testcase> node
                  {
                      try
                      {
                          string folio_doc = node.SelectSingleNode("Folio").InnerText;
                          string tipo_doc = node.SelectSingleNode("TipoDTE").InnerText;

                          sube.SubeArchivoFisico(tipo_doc, path, folio_doc);
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show("Error in reading XML", "xmlError", MessageBoxButtons.OK);
                      }
                  }
              }
             
          }
          catch (Exception ex)
          {
             // MessageBox.Show(ex.Message);
              
          }
        }
      }
    }

    private string generaLibroVentas()
    {
      csGeneraXMLlibroCompraVenta llibroCompraVenta = new csGeneraXMLlibroCompraVenta();
      string text1 = this.txtPeriodo.Text;
      string tipoOperacion = "VENTA";
      int folioNotificacion = 0;
      string codigoAutorizacion = "";
      string tipoLibro;
      if (this.rdbTAMensual.Checked)
        tipoLibro = "MENSUAL";
      else if (this.rdbTAEspecial.Checked)
      {
        tipoLibro = "ESPECIAL";
        if (this.txtNotificacion.Text.Length > 0)
          folioNotificacion = Convert.ToInt32(this.txtNotificacion.Text);
      }
      else
      {
        tipoLibro = "RECTIFICA";
        codigoAutorizacion = this.txtRectifica.Text;
      }
      string text2 = this.cmbTipoEnvio.Text;
      List<TotalesPeriodo> listaResumenPeriodo = new List<TotalesPeriodo>();
      
      TotalesPeriodo totalesPeriodo1 = new TotalesPeriodo();
      List<int> list = new List<int>();
      foreach (Venta venta in this.lista)
      {
        bool flag = true;
        TotalesPeriodo totalesPeriodo2 = new TotalesPeriodo();
        if (list.Count > 0)
        {
          foreach (int num in list)
          {
            if (num == venta.Fe_TipoDTE)
            {
              flag = false;
              break;
            }
          }
        }
        if (flag)
        {
          for (int index1 = 0; index1 < this.lista.Count; ++index1)
          {
            if (venta.Fe_TipoDTE == this.lista[index1].Fe_TipoDTE)
            {
              totalesPeriodo2.TpoDoc = this.lista[index1].Fe_TipoDTE;
              totalesPeriodo2.TpoImp = 1;
              ++totalesPeriodo2.TotDoc;
              TotalesPeriodo totalesPeriodo3 = totalesPeriodo2;
              Decimal totMntExe = totalesPeriodo3.TotMntExe;
              Decimal num1 = this.lista[index1].TotalExento;
              Decimal num2 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num3 = totMntExe + num2;
              totalesPeriodo3.TotMntExe = num3;
              TotalesPeriodo totalesPeriodo4 = totalesPeriodo2;
              Decimal totMntNeto = totalesPeriodo4.TotMntNeto;
              num1 = this.lista[index1].Neto;
              Decimal num4 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num5 = totMntNeto + num4;
              totalesPeriodo4.TotMntNeto = num5;
              totalesPeriodo2.TotOpIVARec = 0;
              TotalesPeriodo totalesPeriodo5 = totalesPeriodo2;
              Decimal totMntIva = totalesPeriodo5.TotMntIVA;
              num1 = this.lista[index1].Iva;
              Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num7 = totMntIva + num6;
              totalesPeriodo5.TotMntIVA = num7;
              totalesPeriodo2.TotOpIVAUsoComun = 0;
              totalesPeriodo2.TotIVAUsoComun = new Decimal(0);
              totalesPeriodo2.TotImpSinCredito = new Decimal(0);
              if (this.lista[index1].Impuesto1 > new Decimal(0) || this.lista[index1].Impuesto2 > new Decimal(0) || (this.lista[index1].Impuesto3 > new Decimal(0) || this.lista[index1].Impuesto4 > new Decimal(0)) || this.lista[index1].Impuesto5 > new Decimal(0))
              {
                csTotOtrosImp csTotOtrosImp1 = new csTotOtrosImp();
                if (totalesPeriodo2.TotOtrosImp.Count == 0)
                {
                  totalesPeriodo2.TotOtrosImp = new List<csTotOtrosImp>();
                  if (this.lista[index1].Impuesto1 > new Decimal(0))
                  {
                    csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                    csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto1);
                    csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                    num1 = this.lista[index1].Impuesto1;
                    Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                    csTotOtrosImp3.TotMntImp = num8;
                    totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                  }
                  if (this.lista[index1].Impuesto2 > new Decimal(0))
                  {
                    csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                    csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto2);
                    csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                    num1 = this.lista[index1].Impuesto2;
                    Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                    csTotOtrosImp3.TotMntImp = num8;
                    totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                  }
                  if (this.lista[index1].Impuesto3 > new Decimal(0))
                  {
                    csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                    csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto3);
                    csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                    num1 = this.lista[index1].Impuesto3;
                    Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                    csTotOtrosImp3.TotMntImp = num8;
                    totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                  }
                  if (this.lista[index1].Impuesto4 > new Decimal(0))
                  {
                    csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                    csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto4);
                    csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                    num1 = this.lista[index1].Impuesto4;
                    Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                    csTotOtrosImp3.TotMntImp = num8;
                    totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                  }
                  if (this.lista[index1].Impuesto5 > new Decimal(0))
                  {
                    csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                    csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto5);
                    csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                    num1 = this.lista[index1].Impuesto5;
                    Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                    csTotOtrosImp3.TotMntImp = num8;
                    totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                  }
                }
                else
                {
                  int count = totalesPeriodo2.TotOtrosImp.Count;
                  for (int index2 = 0; index2 < count; ++index2)
                  {
                    if (this.lista[index1].Impuesto1 > new Decimal(0))
                    {
                      if (totalesPeriodo2.TotOtrosImp[index2].CodImp.ToString() == this.lista[index1].CodImpuesto1)
                      {
                        csTotOtrosImp csTotOtrosImp2 = totalesPeriodo2.TotOtrosImp[index2];
                        Decimal totMntImp = csTotOtrosImp2.TotMntImp;
                        num1 = this.lista[index1].Impuesto1;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        Decimal num9 = totMntImp + num8;
                        csTotOtrosImp2.TotMntImp = num9;
                      }
                      else
                      {
                        csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                        csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto1);
                        csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                        num1 = this.lista[index1].Impuesto1;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        csTotOtrosImp3.TotMntImp = num8;
                        totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                      }
                    }
                    if (this.lista[index1].Impuesto2 > new Decimal(0))
                    {
                      if (totalesPeriodo2.TotOtrosImp[index2].CodImp.ToString() == this.lista[index1].CodImpuesto2)
                      {
                        csTotOtrosImp csTotOtrosImp2 = totalesPeriodo2.TotOtrosImp[index2];
                        Decimal totMntImp = csTotOtrosImp2.TotMntImp;
                        num1 = this.lista[index1].Impuesto2;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        Decimal num9 = totMntImp + num8;
                        csTotOtrosImp2.TotMntImp = num9;
                      }
                      else
                      {
                        csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                        csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto2);
                        csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                        num1 = this.lista[index1].Impuesto2;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        csTotOtrosImp3.TotMntImp = num8;
                        totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                      }
                    }
                    if (this.lista[index1].Impuesto3 > new Decimal(0))
                    {
                      if (totalesPeriodo2.TotOtrosImp[index2].CodImp.ToString() == this.lista[index1].CodImpuesto3)
                      {
                        csTotOtrosImp csTotOtrosImp2 = totalesPeriodo2.TotOtrosImp[index2];
                        Decimal totMntImp = csTotOtrosImp2.TotMntImp;
                        num1 = this.lista[index1].Impuesto3;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        Decimal num9 = totMntImp + num8;
                        csTotOtrosImp2.TotMntImp = num9;
                      }
                      else
                      {
                        csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                        csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto3);
                        csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                        num1 = this.lista[index1].Impuesto3;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        csTotOtrosImp3.TotMntImp = num8;
                        totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                      }
                    }
                    if (this.lista[index1].Impuesto4 > new Decimal(0))
                    {
                      if (totalesPeriodo2.TotOtrosImp[index2].CodImp.ToString() == this.lista[index1].CodImpuesto4)
                      {
                        csTotOtrosImp csTotOtrosImp2 = totalesPeriodo2.TotOtrosImp[index2];
                        Decimal totMntImp = csTotOtrosImp2.TotMntImp;
                        num1 = this.lista[index1].Impuesto4;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        Decimal num9 = totMntImp + num8;
                        csTotOtrosImp2.TotMntImp = num9;
                      }
                      else
                      {
                        csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                        csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto4);
                        csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                        num1 = this.lista[index1].Impuesto4;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        csTotOtrosImp3.TotMntImp = num8;
                        totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                      }
                    }
                    if (this.lista[index1].Impuesto5 > new Decimal(0))
                    {
                      if (totalesPeriodo2.TotOtrosImp[index2].CodImp.ToString() == this.lista[index1].CodImpuesto5)
                      {
                        csTotOtrosImp csTotOtrosImp2 = totalesPeriodo2.TotOtrosImp[index2];
                        Decimal totMntImp = csTotOtrosImp2.TotMntImp;
                        num1 = this.lista[index1].Impuesto5;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        Decimal num9 = totMntImp + num8;
                        csTotOtrosImp2.TotMntImp = num9;
                      }
                      else
                      {
                        csTotOtrosImp csTotOtrosImp2 = new csTotOtrosImp();
                        csTotOtrosImp2.CodImp = Convert.ToInt32(this.lista[index1].CodImpuesto5);
                        csTotOtrosImp csTotOtrosImp3 = csTotOtrosImp2;
                        num1 = this.lista[index1].Impuesto5;
                        Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
                        csTotOtrosImp3.TotMntImp = num8;
                        totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp2);
                      }
                    }
                  }
                }
              }
              TotalesPeriodo totalesPeriodo6 = totalesPeriodo2;
              Decimal totMntTotal = totalesPeriodo6.TotMntTotal;
              num1 = this.lista[index1].Total;
              Decimal num10 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num11 = totMntTotal + num10;
              totalesPeriodo6.TotMntTotal = num11;
            }
          }
           
          if (this._totalePeriodoManualBoleta35 != null)
          {
              listaResumenPeriodo.Add(_totalePeriodoManualBoleta35);
              _totalePeriodoManualBoleta35 = null;
          }
          if (this._totalePeriodoManualBoleta48 != null)
          {
              listaResumenPeriodo.Add(_totalePeriodoManualBoleta48);
              _totalePeriodoManualBoleta48 = null;
          }
          if (this._totalePeriodoManualBoleta35_2 != null)
          {
              listaResumenPeriodo.Add(_totalePeriodoManualBoleta35_2);
              _totalePeriodoManualBoleta35_2 = null;
          }
          listaResumenPeriodo.Add(totalesPeriodo2);
          list.Add(venta.Fe_TipoDTE);
        }

      }
      List<csDetalleLibro> listaDetalle = new List<csDetalleLibro>();
      csDetalleLibro csDetalleLibro1 = new csDetalleLibro();
      foreach (Venta venta in this.lista)
      {
        if (venta.Fe_TipoDTE != 35 && venta.Fe_TipoDTE != 39 && venta.Fe_TipoDTE != 41)
        {
          csDetalleLibro csDetalleLibro2 = new csDetalleLibro();
          csDetalleLibro2.TpoDoc = venta.Fe_TipoDTE;
          csDetalleLibro2.NroDoc = venta.Folio;
          csDetalleLibro2.TpoImp = 1;
          csDetalleLibro csDetalleLibro3 = csDetalleLibro2;
          Decimal num1 = venta.PorcentajeIva;
          Decimal num2 = Convert.ToDecimal(num1.ToString("N0"));
          csDetalleLibro3.TasaImp = num2;
          csDetalleLibro2.FchDoc = venta.FechaEmision.ToString("yyyy-MM-dd");
          csDetalleLibro2.RUTDoc = venta.Rut;
          string str = venta.RazonSocial;
          if (str.Length > 49)
            str = str.Substring(0, 49);
          csDetalleLibro2.RznSoc = str;
          csDetalleLibro csDetalleLibro4 = csDetalleLibro2;
          num1 = venta.TotalExento;
          Decimal num3 = Convert.ToDecimal(num1.ToString("N0"));
          csDetalleLibro4.MntExe = num3;
          csDetalleLibro csDetalleLibro5 = csDetalleLibro2;
          num1 = venta.Neto;
          Decimal num4 = Convert.ToDecimal(num1.ToString("N0"));
          csDetalleLibro5.MntNeto = num4;
          csDetalleLibro csDetalleLibro6 = csDetalleLibro2;
          num1 = venta.Iva;
          Decimal num5 = Convert.ToDecimal(num1.ToString("N0"));
          csDetalleLibro6.MntIVA = num5;
          csDetalleLibro2.IVAUsoComun = new Decimal(0);
          csDetalleLibro2.MntSinCred = new Decimal(0);
          if (venta.Impuesto1 > new Decimal(0) || venta.Impuesto2 > new Decimal(0) || (venta.Impuesto3 > new Decimal(0) || venta.Impuesto4 > new Decimal(0)) || venta.Impuesto5 > new Decimal(0))
          {
            csOtrosImp csOtrosImp1 = new csOtrosImp();
            if (venta.Impuesto1 > new Decimal(0))
            {
              csOtrosImp csOtrosImp2 = new csOtrosImp();
              csOtrosImp2.CodImp = Convert.ToInt32(venta.CodImpuesto1);
              csOtrosImp csOtrosImp3 = csOtrosImp2;
              num1 = venta.Impuesto1;
              Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp3.MntImp = num6;
              csOtrosImp csOtrosImp4 = csOtrosImp2;
              num1 = venta.PorcentajeImpuesto1;
              Decimal num7 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp4.TasaImp = num7;
              csDetalleLibro2.OtrosImp.Add(csOtrosImp2);
            }
            if (venta.Impuesto2 > new Decimal(0))
            {
              csOtrosImp csOtrosImp2 = new csOtrosImp();
              csOtrosImp2.CodImp = Convert.ToInt32(venta.CodImpuesto2);
              csOtrosImp csOtrosImp3 = csOtrosImp2;
              num1 = venta.Impuesto2;
              Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp3.MntImp = num6;
              csOtrosImp csOtrosImp4 = csOtrosImp2;
              num1 = venta.PorcentajeImpuesto2;
              Decimal num7 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp4.TasaImp = num7;
              csDetalleLibro2.OtrosImp.Add(csOtrosImp2);
            }
            if (venta.Impuesto3 > new Decimal(0))
            {
              csOtrosImp csOtrosImp2 = new csOtrosImp();
              csOtrosImp2.CodImp = Convert.ToInt32(venta.CodImpuesto3);
              csOtrosImp csOtrosImp3 = csOtrosImp2;
              num1 = venta.Impuesto3;
              Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp3.MntImp = num6;
              csOtrosImp csOtrosImp4 = csOtrosImp2;
              num1 = venta.PorcentajeImpuesto3;
              Decimal num7 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp4.TasaImp = num7;
              csDetalleLibro2.OtrosImp.Add(csOtrosImp2);
            }
            if (venta.Impuesto4 > new Decimal(0))
            {
              csOtrosImp csOtrosImp2 = new csOtrosImp();
              csOtrosImp2.CodImp = Convert.ToInt32(venta.CodImpuesto4);
              csOtrosImp csOtrosImp3 = csOtrosImp2;
              num1 = venta.Impuesto4;
              Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp3.MntImp = num6;
              csOtrosImp csOtrosImp4 = csOtrosImp2;
              num1 = venta.PorcentajeImpuesto4;
              Decimal num7 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp4.TasaImp = num7;
              csDetalleLibro2.OtrosImp.Add(csOtrosImp2);
            }
            if (venta.Impuesto5 > new Decimal(0))
            {
              csOtrosImp csOtrosImp2 = new csOtrosImp();
              csOtrosImp2.CodImp = Convert.ToInt32(venta.CodImpuesto5);
              csOtrosImp csOtrosImp3 = csOtrosImp2;
              num1 = venta.Impuesto5;
              Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp3.MntImp = num6;
              csOtrosImp csOtrosImp4 = csOtrosImp2;
              num1 = venta.PorcentajeImpuesto5;
              Decimal num7 = Convert.ToDecimal(num1.ToString("N0"));
              csOtrosImp4.TasaImp = num7;
              csDetalleLibro2.OtrosImp.Add(csOtrosImp2);
            }
          }
          csDetalleLibro csDetalleLibro7 = csDetalleLibro2;
          num1 = venta.Total;
          Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
          csDetalleLibro7.MntTotal = num8;
          listaDetalle.Add(csDetalleLibro2);
        }
      }



      return llibroCompraVenta.creaXMLlibroCompraVenta(text1, tipoOperacion, tipoLibro, text2, folioNotificacion, listaResumenPeriodo, listaDetalle, codigoAutorizacion);
      //return llibroCompraVenta.creaXMLlibroCompraVenta(text1, tipoOperacion, tipoLibro, text2, folioNotificacion, listaResumenPeriodo,dgvResumen, codigoAutorizacion);
    }


    private string generaLibroCompra()
    {
      csGeneraXMLlibroCompraVenta llibroCompraVenta = new csGeneraXMLlibroCompraVenta();
      string text1 = this.txtPeriodo.Text;
      string tipoOperacion = "COMPRA";
      int folioNotificacion = 0;
      string codigoAutorizacion = "";
      string tipoLibro;
      if (this.rdbTAMensual.Checked)
        tipoLibro = "MENSUAL";
      else if (this.rdbTAEspecial.Checked)
      {
        tipoLibro = "ESPECIAL";
        if (this.txtNotificacion.Text.Length > 0)
          folioNotificacion = Convert.ToInt32(this.txtNotificacion.Text);
      }
      else
      {
        tipoLibro = "RECTIFICA";
        codigoAutorizacion = this.txtRectifica.Text;
      }
      string text2 = this.cmbTipoEnvio.Text;
      List<TotalesPeriodo> listaResumenPeriodo = new List<TotalesPeriodo>();
      TotalesPeriodo totalesPeriodo1 = new TotalesPeriodo();
      foreach (Venta venta in this.listaResumen)
      {
        TotalesPeriodo totalesPeriodo2 = new TotalesPeriodo();
        totalesPeriodo2.TpoDoc = venta.Fe_TipoDTE;
        totalesPeriodo2.TotDoc = Convert.ToInt32(venta.TotalDocumentado);
        TotalesPeriodo totalesPeriodo3 = totalesPeriodo2;
        Decimal num1 = venta.TotalExento;
        Decimal num2 = Convert.ToDecimal(num1.ToString("N0"));
        totalesPeriodo3.TotMntExe = num2;
        if (venta.TotalExento > new Decimal(0))
          ++totalesPeriodo2.TotOpExe;
        TotalesPeriodo totalesPeriodo4 = totalesPeriodo2;
        Decimal totMntNeto = totalesPeriodo4.TotMntNeto;
        num1 = venta.Neto;
        Decimal num3 = Convert.ToDecimal(num1.ToString("N0"));
        Decimal num4 = totMntNeto + num3;
        totalesPeriodo4.TotMntNeto = num4;
        TotalesPeriodo totalesPeriodo5 = totalesPeriodo2;
        Decimal totMntIva = totalesPeriodo5.TotMntIVA;
        num1 = venta.Iva;
        Decimal num5 = Convert.ToDecimal(num1.ToString("N0"));
        Decimal num6 = totMntIva + num5;
        totalesPeriodo5.TotMntIVA = num6;
        TotalesPeriodo totalesPeriodo6 = totalesPeriodo2;
        num1 = venta.Total;
        Decimal num7 = Convert.ToDecimal(num1.ToString("N0"));
        totalesPeriodo6.TotMntTotal = num7;
        listaResumenPeriodo.Add(totalesPeriodo2);
      }
      List<csDetalleLibro> listaDetalle = new List<csDetalleLibro>();
      csDetalleLibro csDetalleLibro1 = new csDetalleLibro();
      foreach (Venta venta in this.lista)
      {
        csDetalleLibro csDetalleLibro2 = new csDetalleLibro();
        csDetalleLibro2.TpoDoc = venta.Fe_TipoDTE;
        csDetalleLibro2.NroDoc = venta.Folio;
        csDetalleLibro2.TpoImp = 1;
        csDetalleLibro csDetalleLibro3 = csDetalleLibro2;
        Decimal num1 = venta.PorcentajeIva;
        Decimal num2 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro3.TasaImp = num2;
        csDetalleLibro2.FchDoc = venta.FechaEmision.ToString("yyyy-MM-dd");
        csDetalleLibro2.RUTDoc = venta.Rut;
        csDetalleLibro2.RznSoc = venta.RazonSocial;
        csDetalleLibro csDetalleLibro4 = csDetalleLibro2;
        num1 = venta.TotalExento;
        Decimal num3 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro4.MntExe = num3;
        csDetalleLibro csDetalleLibro5 = csDetalleLibro2;
        num1 = venta.Neto;
        Decimal num4 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro5.MntNeto = num4;
        csDetalleLibro csDetalleLibro6 = csDetalleLibro2;
        num1 = venta.Iva;
        Decimal num5 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro6.MntIVA = num5;
        csDetalleLibro csDetalleLibro7 = csDetalleLibro2;
        num1 = venta.Total;
        Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro7.MntTotal = num6;
        listaDetalle.Add(csDetalleLibro2);
      }
      return llibroCompraVenta.creaXMLlibroCompraVenta(text1, tipoOperacion, tipoLibro, text2, folioNotificacion, listaResumenPeriodo, listaDetalle, codigoAutorizacion);
    }

    private string generaLibrGuias()
    {
      csGeneraXMLLibroGuias generaXmlLibroGuias = new csGeneraXMLLibroGuias();
      string text1 = this.txtPeriodo.Text;
      int folioNotificacion = 0;
      string codigoAutorizacion = "";
      string tipoLibro;
      if (this.rdbTAMensual.Checked)
        tipoLibro = "MENSUAL";
      else if (this.rdbTAEspecial.Checked)
      {
        tipoLibro = "ESPECIAL";
        if (this.txtNotificacion.Text.Length > 0)
          folioNotificacion = Convert.ToInt32(this.txtNotificacion.Text);
      }
      else
      {
        tipoLibro = "RECTIFICA";
        codigoAutorizacion = this.txtRectifica.Text;
      }
      string text2 = this.cmbTipoEnvio.Text;
      List<csTotalesPeriodoGuias> listaResumenPeriodo = new List<csTotalesPeriodoGuias>();
      csTotalesPeriodoGuias totalesPeriodoGuias = new csTotalesPeriodoGuias();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      Decimal num7 = new Decimal(0);
      Decimal num8 = new Decimal(0);
      Decimal num9 = new Decimal(0);
      Decimal num10 = new Decimal(0);
      Decimal num11 = new Decimal(0);
      Decimal num12 = new Decimal(0);
      foreach (Venta venta in this.lista)
      {
        totalesPeriodoGuias.TotFolAnulado = 0;
        if (venta.EstadoDocumento.Equals("ANULADA"))
        {
          ++totalesPeriodoGuias.TotGuiaAnulada;
        }
        else
        {
          if (venta.FE_codigoTipoGuia == 1)
          {
            ++totalesPeriodoGuias.TotGuiaVenta;
            totalesPeriodoGuias.TotMntGuiaVta += venta.Total;
          }
          totalesPeriodoGuias.TotMntModificado = new Decimal(0);
          if (venta.FE_codigoTipoGuia == 2)
          {
            ++num1;
            num7 += venta.Total;
          }
          if (venta.FE_codigoTipoGuia == 3)
          {
            ++num2;
            num8 += venta.Total;
          }
          if (venta.FE_codigoTipoGuia == 4)
          {
            ++num3;
            num9 += venta.Total;
          }
          if (venta.FE_codigoTipoGuia == 5)
          {
            ++num4;
            num10 += venta.Total;
          }
          if (venta.FE_codigoTipoGuia == 6)
          {
            ++num5;
            num11 += venta.Total;
          }
          if (venta.FE_codigoTipoGuia == 7)
          {
            ++num6;
            num12 += venta.Total;
          }
        }
      }
      csTotTraslado csTotTraslado = new csTotTraslado();
      if (num1 > 0)
        totalesPeriodoGuias.TotTraslado.Add(new csTotTraslado()
        {
          TpoTraslado = 2,
          CantGuia = num1,
          MntGuia = Convert.ToDecimal(num7.ToString("N0"))
        });
      if (num2 > 0)
        totalesPeriodoGuias.TotTraslado.Add(new csTotTraslado()
        {
          TpoTraslado = 3,
          CantGuia = num2,
          MntGuia = Convert.ToDecimal(num8.ToString("N0"))
        });
      if (num3 > 0)
        totalesPeriodoGuias.TotTraslado.Add(new csTotTraslado()
        {
          TpoTraslado = 4,
          CantGuia = num3,
          MntGuia = Convert.ToDecimal(num9.ToString("N0"))
        });
      if (num4 > 0)
        totalesPeriodoGuias.TotTraslado.Add(new csTotTraslado()
        {
          TpoTraslado = 5,
          CantGuia = num4,
          MntGuia = Convert.ToDecimal(num10.ToString("N0"))
        });
      if (num5 > 0)
        totalesPeriodoGuias.TotTraslado.Add(new csTotTraslado()
        {
          TpoTraslado = 6,
          CantGuia = num5,
          MntGuia = Convert.ToDecimal(num11.ToString("N0"))
        });
      if (num6 > 0)
        totalesPeriodoGuias.TotTraslado.Add(new csTotTraslado()
        {
          TpoTraslado = 7,
          CantGuia = num6,
          MntGuia = Convert.ToDecimal(num12.ToString("N0"))
        });
      listaResumenPeriodo.Add(totalesPeriodoGuias);
      List<csDetalleLibroGuias> listaDetalle = new List<csDetalleLibroGuias>();
      csDetalleLibroGuias detalleLibroGuias1 = new csDetalleLibroGuias();
      foreach (Venta venta in this.lista)
      {
        csDetalleLibroGuias detalleLibroGuias2 = new csDetalleLibroGuias();
        detalleLibroGuias2.Folio = venta.Folio;
        detalleLibroGuias2.Anulado = !venta.EstadoDocumento.Equals("ANULADA") ? 0 : 2;
        detalleLibroGuias2.TpoOper = venta.FE_codigoTipoGuia;
        detalleLibroGuias2.FchDoc = venta.FechaEmision.ToString("yyyy-MM-dd");
        detalleLibroGuias2.RUTDoc = venta.Rut;
        string str = venta.RazonSocial;
        if (str.Length > 49)
          str = str.Substring(0, 49);
        detalleLibroGuias2.RznSoc = str;
        csDetalleLibroGuias detalleLibroGuias3 = detalleLibroGuias2;
        Decimal num13 = venta.Neto;
        Decimal num14 = Convert.ToDecimal(num13.ToString("N0"));
        detalleLibroGuias3.MntNeto = num14;
        csDetalleLibroGuias detalleLibroGuias4 = detalleLibroGuias2;
        num13 = venta.PorcentajeIva;
        Decimal num15 = Convert.ToDecimal(num13.ToString("N0"));
        detalleLibroGuias4.TasaImp = num15;
        csDetalleLibroGuias detalleLibroGuias5 = detalleLibroGuias2;
        num13 = venta.Iva;
        Decimal num16 = Convert.ToDecimal(num13.ToString("N0"));
        detalleLibroGuias5.IVA = num16;
        csDetalleLibroGuias detalleLibroGuias6 = detalleLibroGuias2;
        num13 = venta.Total;
        Decimal num17 = Convert.ToDecimal(num13.ToString("N0"));
        detalleLibroGuias6.MntTotal = num17;
        if (venta.Facturada && venta.DocumentoVenta.Equals("FACTURA ELECTRONICA"))
        {
          detalleLibroGuias2.TpoDocRef = 33;
          detalleLibroGuias2.FolioDocRef = venta.FolioFactura;
          DateTime dateTimexr = DateTime.Now;
          detalleLibroGuias2.FchDocRef = dateTimexr.ToString("yyyy-MM-dd");//CON ESTO CORREGI EL RECUPERAR LA FECHA DE MODIFICACION DEL DOC DE REFERENCIA.
         // detalleLibroGuias2.FchDocRef = venta.FechaModificacion.ToString("yyyy-MM-dd");
        }
        listaDetalle.Add(detalleLibroGuias2);
      }
      return generaXmlLibroGuias.creaXMLlibroGuias(text1, tipoLibro, text2, folioNotificacion, listaResumenPeriodo, listaDetalle, codigoAutorizacion);
    }

    private string generaLibroBoletas()
    {
      csGeneraXMLLibroBoletas generaXmlLibroBoletas = new csGeneraXMLLibroBoletas();
      string text1 = this.txtPeriodo.Text;
      int folioNotificacion = 0;
      string codigoAutorizacion = "";
      string tipoLibro;
      if (this.rdbTAMensual.Checked)
        tipoLibro = "MENSUAL";
      else if (this.rdbTAEspecial.Checked)
      {
        tipoLibro = "ESPECIAL";
        if (this.txtNotificacion.Text.Length > 0)
          folioNotificacion = Convert.ToInt32(this.txtNotificacion.Text);
      }
      else
      {
        tipoLibro = "RECTIFICA";
        codigoAutorizacion = this.txtRectifica.Text;
      }
      string text2 = this.cmbTipoEnvio.Text;
      List<csTotalesPeriodoBoletas> listaResumenPeriodo = new List<csTotalesPeriodoBoletas>();
      csTotalesPeriodoBoletas totalesPeriodoBoletas1 = new csTotalesPeriodoBoletas();
      csTotalesServicio csTotalesServicio1 = new csTotalesServicio();
      csTotalesServicio csTotalesServicio2 = new csTotalesServicio();
      foreach (Venta venta in this.lista)
      {
        if (venta.Fe_TipoDTE == 39)
        {
          csTotalesServicio1.TpoServ = 3;
          ++csTotalesServicio1.TotDoc;
          csTotalesServicio1.TotMntExe += venta.TotalExento;
          csTotalesServicio1.TotMntNeto += venta.Neto;
          csTotalesServicio1.TotMntIVA += venta.Iva;
          csTotalesServicio1.TotMntTotal += venta.Total;
        }
        if (venta.Fe_TipoDTE == 41)
        {
          csTotalesServicio2.TpoServ = 3;
          ++csTotalesServicio2.TotDoc;
          csTotalesServicio2.TotMntExe += venta.TotalExento;
          csTotalesServicio2.TotMntNeto = new Decimal(0);
          csTotalesServicio2.TotMntIVA = new Decimal(0);
          csTotalesServicio2.TotMntTotal += venta.Total;
        }
      }
      Decimal num1;
      if (csTotalesServicio1.TpoServ > 0)
      {
        csTotalesPeriodoBoletas totalesPeriodoBoletas2 = new csTotalesPeriodoBoletas();
        totalesPeriodoBoletas2.TpoDoc = 39;
        totalesPeriodoBoletas2.TotalesServicio = csTotalesServicio1;
        totalesPeriodoBoletas2.TotalesServicio.TotMntExe = Convert.ToDecimal(totalesPeriodoBoletas2.TotalesServicio.TotMntExe.ToString("N0"));
        csTotalesServicio totalesServicio1 = totalesPeriodoBoletas2.TotalesServicio;
        num1 = totalesPeriodoBoletas2.TotalesServicio.TotMntNeto;
        Decimal num2 = Convert.ToDecimal(num1.ToString("N0"));
        totalesServicio1.TotMntNeto = num2;
        csTotalesServicio totalesServicio2 = totalesPeriodoBoletas2.TotalesServicio;
        num1 = totalesPeriodoBoletas2.TotalesServicio.TotMntIVA;
        Decimal num3 = Convert.ToDecimal(num1.ToString("N0"));
        totalesServicio2.TotMntIVA = num3;
        csTotalesServicio totalesServicio3 = totalesPeriodoBoletas2.TotalesServicio;
        num1 = totalesPeriodoBoletas2.TotalesServicio.TotMntTotal;
        Decimal num4 = Convert.ToDecimal(num1.ToString("N0"));
        totalesServicio3.TotMntTotal = num4;
        listaResumenPeriodo.Add(totalesPeriodoBoletas2);
      }
      if (csTotalesServicio2.TpoServ > 0)
        listaResumenPeriodo.Add(new csTotalesPeriodoBoletas()
        {
          TpoDoc = 41,
          TotalesServicio = csTotalesServicio2
        });
      List<csDetalleLibroBoletas> listaDetalle = new List<csDetalleLibroBoletas>();
      csDetalleLibroBoletas detalleLibroBoletas1 = new csDetalleLibroBoletas();
      foreach (Venta venta in this.lista)
      {
        csDetalleLibroBoletas detalleLibroBoletas2 = new csDetalleLibroBoletas();
        if (venta.Fe_TipoDTE == 39 || venta.Fe_TipoDTE == 41)
        {
          detalleLibroBoletas2.TpoDoc = venta.Fe_TipoDTE;
          detalleLibroBoletas2.FolioDoc = venta.Folio;
          detalleLibroBoletas2.TpoServ = 3;
          detalleLibroBoletas2.FchEmiDoc = venta.FechaEmision.ToString("yyyy-MM-dd");
          detalleLibroBoletas2.RUTCliente = venta.Rut;
          csDetalleLibroBoletas detalleLibroBoletas3 = detalleLibroBoletas2;
          num1 = venta.TotalExento;
          Decimal num2 = Convert.ToDecimal(num1.ToString("N0"));
          detalleLibroBoletas3.MntExe = num2;
          csDetalleLibroBoletas detalleLibroBoletas4 = detalleLibroBoletas2;
          num1 = venta.Total;
          Decimal num3 = Convert.ToDecimal(num1.ToString("N0"));
          detalleLibroBoletas4.MntTotal = num3;
        }
        listaDetalle.Add(detalleLibroBoletas2);
      }
      string str = generaXmlLibroBoletas.creaXMLlibroBoletas(text1, tipoLibro, text2, folioNotificacion, listaResumenPeriodo, listaDetalle, codigoAutorizacion);
      int num5 = (int) MessageBox.Show("Terminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      return str;
    }

    private void btnGeneraLibro_Click(object sender, EventArgs e)
    {
      string archivo = "";
      string ruta = "";
      if (this.rdbBusquedaLibroVentas.Checked)
      {
        archivo = this.generaLibroVentas();
        //this.generaLibroBoletas();
        ruta = this._rutaElectronica + "LIBROS\\VENTA\\";
      }
      if (this.rdbBusquedaLibroCompras.Checked)
      {
        archivo = this.generaLibroCompra();
        ruta = this._rutaElectronica + "LIBROS\\COMPRA\\";
      }
      if (this.rdbBusquedaLibroGuias.Checked)
      {
        archivo = this.generaLibrGuias();
        ruta = this._rutaElectronica + "LIBROS\\GUIAS\\";
      }
      if (this.rdbBusquedaLibroBoletas.Checked)
      {
        archivo = this.generaLibroBoletas();
        ruta = this._rutaElectronica + "LIBROS\\BOLETAS\\";
      }
      int num1 = (int) MessageBox.Show("Archivo de libro Creado : " + archivo, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      int num2 = (int) new frmEnviosSII(archivo, ruta, this.lista, "LIBRO").ShowDialog();
      this.iniciaFormulario();
    }

    private void btnMuestraLibroCompra_Click(object sender, EventArgs e)
    {
      new frmIngresoLibroCompraSetPrueba().Show();
    }

    private void btnGeneraLibroCompras_Click(object sender, EventArgs e)
    {
      csGeneraXMLlibroCompraVenta llibroCompraVenta = new csGeneraXMLlibroCompraVenta();
      string text = this.txtPeriodo.Text;
      string tipoOperacion = "COMPRA";
      string tipoLibro = "ESPECIAL";
      string tipoEnvio = "TOTAL";
      int folioNotificacion = 2;
      List<TotalesPeriodo> listaResumenPeriodo = new List<TotalesPeriodo>();
      TotalesPeriodo totalesPeriodo1 = new TotalesPeriodo();
      List<int> list = new List<int>();
      foreach (Venta venta in this.lista)
      {
        bool flag = true;
        TotalesPeriodo totalesPeriodo2 = new TotalesPeriodo();
        if (list.Count > 0)
        {
          foreach (int num in list)
          {
            if (num == venta.Fe_TipoDTE)
            {
              flag = false;
              break;
            }
          }
        }
        if (flag)
        {
          for (int index = 0; index < this.lista.Count; ++index)
          {
            if (venta.Fe_TipoDTE == this.lista[index].Fe_TipoDTE)
            {
              totalesPeriodo2.TpoDoc = this.lista[index].Fe_TipoDTE;
              ++totalesPeriodo2.TotDoc;
              TotalesPeriodo totalesPeriodo3 = totalesPeriodo2;
              Decimal totMntExe = totalesPeriodo3.TotMntExe;
              Decimal num1 = this.lista[index].TotalExento;
              Decimal num2 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num3 = totMntExe + num2;
              totalesPeriodo3.TotMntExe = num3;
              if (this.lista[index].TotalExento > new Decimal(0))
                ++totalesPeriodo2.TotOpExe;
              TotalesPeriodo totalesPeriodo4 = totalesPeriodo2;
              Decimal totMntNeto = totalesPeriodo4.TotMntNeto;
              num1 = this.lista[index].Neto;
              Decimal num4 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num5 = totMntNeto + num4;
              totalesPeriodo4.TotMntNeto = num5;
              if (this.lista[index].Iva > new Decimal(0))
                ++totalesPeriodo2.TotOpIVARec;
              TotalesPeriodo totalesPeriodo5 = totalesPeriodo2;
              Decimal totMntIva = totalesPeriodo5.TotMntIVA;
              num1 = this.lista[index].Iva;
              Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num7 = totMntIva + num6;
              totalesPeriodo5.TotMntIVA = num7;
              TotalesPeriodo totalesPeriodo6 = totalesPeriodo2;
              Decimal totIvaUsoComun = totalesPeriodo6.TotIVAUsoComun;
              num1 = this.lista[index].FE_ivaComun;
              Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num9 = totIvaUsoComun + num8;
              totalesPeriodo6.TotIVAUsoComun = num9;
              TotalesPeriodo totalesPeriodo7 = totalesPeriodo2;
              Decimal totCredIvaUsoComun = totalesPeriodo7.TotCredIVAUsoComun;
              num1 = this.lista[index].FE_TotCredIVAUsoComun;
              Decimal num10 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num11 = totCredIvaUsoComun + num10;
              totalesPeriodo7.TotCredIVAUsoComun = num11;
              totalesPeriodo2.FctProp = this.lista[index].FE_IvaUsoComunFctProp;
              if (this.lista[index].FE_MntIvaNoRec > new Decimal(0))
              {
                totalesPeriodo2.TotIVANoRec = new csTotIVANoRec();
                totalesPeriodo2.TotIVANoRec.CodIVANoRec = this.lista[index].FE_CodIvaNoRec;
                ++totalesPeriodo2.TotIVANoRec.TotOpIVANoRec;
                csTotIVANoRec totIvaNoRec = totalesPeriodo2.TotIVANoRec;
                Decimal totMntIvaNoRec = totIvaNoRec.TotMntIVANoRec;
                num1 = this.lista[index].FE_MntIvaNoRec;
                Decimal num12 = Convert.ToDecimal(num1.ToString("N0"));
                Decimal num13 = totMntIvaNoRec + num12;
                totIvaNoRec.TotMntIVANoRec = num13;
              }
              if (this.lista[index].FE_OtrosImptMntImp > new Decimal(0))
              {
                csTotOtrosImp csTotOtrosImp1 = new csTotOtrosImp();
                csTotOtrosImp1.CodImp = this.lista[index].FE_OtrosImptCodImp;
                csTotOtrosImp csTotOtrosImp2 = csTotOtrosImp1;
                Decimal totMntImp = csTotOtrosImp2.TotMntImp;
                num1 = this.lista[index].FE_OtrosImptMntImp;
                Decimal num12 = Convert.ToDecimal(num1.ToString("N0"));
                Decimal num13 = totMntImp + num12;
                csTotOtrosImp2.TotMntImp = num13;
                totalesPeriodo2.TotOtrosImp.Add(csTotOtrosImp1);
              }
              TotalesPeriodo totalesPeriodo8 = totalesPeriodo2;
              Decimal totMntTotal = totalesPeriodo8.TotMntTotal;
              num1 = this.lista[index].Total;
              Decimal num14 = Convert.ToDecimal(num1.ToString("N0"));
              Decimal num15 = totMntTotal + num14;
              totalesPeriodo8.TotMntTotal = num15;
            }
          }
          listaResumenPeriodo.Add(totalesPeriodo2);
          list.Add(venta.Fe_TipoDTE);
        }
      }
      List<csDetalleLibro> listaDetalle = new List<csDetalleLibro>();
      csDetalleLibro csDetalleLibro1 = new csDetalleLibro();
      foreach (Venta venta in this.lista)
      {
        csDetalleLibro csDetalleLibro2 = new csDetalleLibro();
        csDetalleLibro2.TpoDoc = venta.Fe_TipoDTE;
        csDetalleLibro2.NroDoc = venta.Folio;
        csDetalleLibro2.TpoImp = 1;
        csDetalleLibro csDetalleLibro3 = csDetalleLibro2;
        Decimal num1 = venta.PorcentajeIva;
        Decimal num2 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro3.TasaImp = num2;
        csDetalleLibro2.FchDoc = venta.FechaEmision.ToString("yyyy-MM-dd");
        csDetalleLibro2.RUTDoc = venta.Rut;
        string str = venta.RazonSocial;
        if (str.Length > 49)
          str = str.Substring(0, 49);
        csDetalleLibro2.RznSoc = str;
        csDetalleLibro csDetalleLibro4 = csDetalleLibro2;
        num1 = venta.TotalExento;
        Decimal num3 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro4.MntExe = num3;
        csDetalleLibro csDetalleLibro5 = csDetalleLibro2;
        num1 = venta.Neto;
        Decimal num4 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro5.MntNeto = num4;
        csDetalleLibro csDetalleLibro6 = csDetalleLibro2;
        num1 = venta.Iva;
        Decimal num5 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro6.MntIVA = num5;
        csDetalleLibro csDetalleLibro7 = csDetalleLibro2;
        num1 = venta.FE_ivaComun;
        Decimal num6 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro7.IVAUsoComun = num6;
        csDetalleLibro2.IVANoRec.CodIVANoRec = venta.FE_CodIvaNoRec;
        csIVANoRec ivaNoRec = csDetalleLibro2.IVANoRec;
        num1 = venta.FE_MntIvaNoRec;
        Decimal num7 = Convert.ToDecimal(num1.ToString("N0"));
        ivaNoRec.MntIVANoRec = num7;
        if (venta.FE_OtrosImptMntImp > new Decimal(0))
        {
          csOtrosImp csOtrosImp1 = new csOtrosImp();
          csOtrosImp1.CodImp = venta.FE_OtrosImptCodImp;
          csOtrosImp csOtrosImp2 = csOtrosImp1;
          num1 = venta.FE_OtrosImptTasaImp;
          Decimal num8 = Convert.ToDecimal(num1.ToString("N0"));
          csOtrosImp2.TasaImp = num8;
          csOtrosImp csOtrosImp3 = csOtrosImp1;
          num1 = venta.FE_OtrosImptMntImp;
          Decimal num9 = Convert.ToDecimal(num1.ToString("N0"));
          csOtrosImp3.MntImp = num9;
          csDetalleLibro2.OtrosImp.Add(csOtrosImp1);
        }
        csDetalleLibro csDetalleLibro8 = csDetalleLibro2;
        num1 = venta.Total;
        Decimal num10 = Convert.ToDecimal(num1.ToString("N0"));
        csDetalleLibro8.MntTotal = num10;
        listaDetalle.Add(csDetalleLibro2);
      }
      llibroCompraVenta.creaXMLlibroCompraVenta(text, tipoOperacion, tipoLibro, tipoEnvio, folioNotificacion, listaResumenPeriodo, listaDetalle, "");
      int num16 = (int) MessageBox.Show("Terminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void frmGeneraodrDeEnvios_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.F5)
        return;
      this.btnMuestraLibroCompra.Enabled = true;
      this.btnMuestraLibroCompra.Visible = true;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void nudAno_ValueChanged(object sender, EventArgs e)
    {
      this.creaPeriodo();
    }

    private void nudMes_ValueChanged(object sender, EventArgs e)
    {
      this.creaPeriodo();
    }

    private void creaPeriodo()
    {
      string str1 = this.nudAno.Value.ToString();
      string str2 = this.nudMes.Value.ToString();
      if (str2.Length == 1)
        str2 = "0" + str2;
      this.txtPeriodo.Text = str1 + "-" + str2;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void rdbEnviarDte_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rdbEnviarDte.Checked || this.rdbBusquedaConsumoFolios.Checked)
      {

        this.chk30.Enabled = false;
        this.chk35.Enabled = false;
        this.chk60.Enabled = false;
        this.chk39.Enabled = false;
        this.chk41.Enabled = false;
        this.chk30.Checked = false;
        this.chk35.Checked = false;
        this.chk60.Checked = false;
        this.chk39.Checked = false;
        this.chk41.Checked = false;
        this.tabControlBusqueda.Enabled = false;
        this.panelLibros.Visible = false;
      }
      else
      {
        this.chk33.Enabled = true;
        this.chk56.Enabled = true;
        this.chk61.Enabled = true;
        this.chk30.Enabled = true;
        this.chk35.Enabled = true;
        this.chk60.Enabled = true;
        this.chk39.Enabled = true;
        this.chk41.Enabled = true;
        this.panelLibros.Visible = true;
      }
    }

    private void rdbBusquedaLibroVentas_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rdbBusquedaLibroVentas.Checked)
        return;
      this.chk52.Checked = false;
      this.rdbLibroVentas.Checked = true;
      this.rdbLibroVentas.Enabled = true;
      this.rdbLibroCompras.Checked = false;
      this.rdbLibroCompras.Enabled = false;
      this.rdbLibroGuias.Checked = false;
      this.rdbLibroGuias.Enabled = false;
      this.tabControlBusqueda.TabPages.Clear();
      this.tabControlBusqueda.TabPages.Add(this.tabPagePorFecha);
      this.tabControlBusqueda.Enabled = true;
    }

    private void rdbBusquedaLibroCompras_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rdbBusquedaLibroCompras.Checked)
        return;
      this.chk52.Checked = false;
      this.rdbLibroVentas.Checked = false;
      this.rdbLibroVentas.Enabled = false;
      this.rdbLibroCompras.Checked = true;
      this.rdbLibroCompras.Enabled = true;
      this.rdbLibroGuias.Checked = false;
      this.rdbLibroGuias.Enabled = false;
      this.tabControlBusqueda.TabPages.Clear();
      this.tabControlBusqueda.TabPages.Add(this.tabPagePorFecha);
      this.tabControlBusqueda.TabPages.Add(this.tabPagePorPeriodo);
      this.tabControlBusqueda.Enabled = true;
    }

    private void rdbTAEspecial_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rdbTAEspecial.Checked)
      {
        this.pnlNotificacion.Visible = true;
        this.pnlRectifica.Visible = false;
      }
      else if (this.rdbTARectifica.Checked)
      {
        this.pnlNotificacion.Visible = false;
        this.pnlRectifica.Visible = true;
      }
      else if (this.rdbTAMensual.Checked && this.rdbLibroGuias.Checked)
      {
        this.pnlNotificacion.Visible = true;
        this.pnlRectifica.Visible = false;
      }
      else
      {
        this.pnlNotificacion.Visible = false;
        this.pnlRectifica.Visible = false;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      new frmEnviosSII().Show();
    }

    private void rdbTARectifica_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rdbTAEspecial.Checked)
      {
        this.pnlNotificacion.Visible = true;
        this.pnlRectifica.Visible = false;
      }
      else if (this.rdbTARectifica.Checked)
      {
        this.pnlNotificacion.Visible = false;
        this.pnlRectifica.Visible = true;
      }
      else
      {
        this.pnlNotificacion.Visible = false;
        this.pnlRectifica.Visible = false;
      }
    }

    private void rdbBusquedaLibroGuias_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rdbBusquedaLibroGuias.Checked)
        return;
      this.rdbLibroVentas.Checked = false;
      this.rdbLibroVentas.Enabled = false;
      this.rdbLibroCompras.Checked = false;
      this.rdbLibroCompras.Enabled = false;
      this.rdbLibroBoletas.Checked = false;
      this.rdbLibroBoletas.Enabled = false;
      this.rdbLibroGuias.Checked = true;
      this.rdbLibroGuias.Enabled = true;
      this.tabControlBusqueda.TabPages.Clear();
      this.tabControlBusqueda.TabPages.Add(this.tabPagePorFecha);
      this.tabControlBusqueda.Enabled = true;
    }

    private void btnBuscarEnviados_Click(object sender, EventArgs e)
    {
      this.lista = new GeneraEnvios().buscaDosumentosEnviados(this.dtpDesdeEnviados.Value.ToString("yyyy-MM-dd"), this.dtpHastaEnviados.Value.ToString("yyyy-MM-dd"), this.chk33Enviados.Checked, this.chk34Enviados.Checked, this.chk61Enviados.Checked, this.chk56Enviados.Checked, this.chk52Enviados.Checked, this.chk30Enviados.Checked, this.chk60Enviados.Checked, this.chk35Enviados.Checked);
      this.dgvDatosEnviados.DataSource = (object) null;
      this.dgvDatosEnviados.DataSource = (object) this.lista;
    }

    private bool SacarNoSeleccionadasEnviados()
    {
      int num1 = 0;
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatosEnviados.Rows)
      {
        if (Convert.ToBoolean(dataGridViewRow.Cells["SeleccionarEnviado"].Value))
        {
          int num2 = dataGridViewRow.Cells["TipoEnviado"].Value.ToString().Length > 0 ? Convert.ToInt32(dataGridViewRow.Cells["TipoEnviado"].Value.ToString()) : 0;
          int num3 = Convert.ToInt32(dataGridViewRow.Cells["FolioEnviado"].Value.ToString());
          int num4 = Convert.ToInt32(dataGridViewRow.Cells["IdFacturaEnviado"].Value.ToString());
          for (int index = 0; index < this.lista.Count; ++index)
          {
            if (this.lista[index].Folio == num3 && this.lista[index].Fe_TipoDTE == num2 && this.lista[index].IdFactura == num4)
            {
              this.lista[index].Enviar = true;
              ++num1;
              break;
            }
          }
        }
      }
      return num1 > 0;
    }

    private void btnLiberarEnviado_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Desactivar el Envio, los Dte aceptado por sii NO pueden ser Modificados", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (this.SacarNoSeleccionadasEnviados())
        {
          new GeneraEnvios().desactivaEnvioDTE(this.lista);
        }
        else
        {
          int num1 = (int) MessageBox.Show("No Hay DTES Seleccionados ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("Accion Cancelada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnLiberarLibro_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Desactivar el Envio de Libros de Venta, los Dte aceptado por sii NO pueden ser Modificados", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (this.SacarNoSeleccionadasEnviados())
        {
          new GeneraEnvios().desactivaEnvioLibro(this.lista);
        }
        else
        {
          int num1 = (int) MessageBox.Show("No Hay DTES Seleccionados ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("Accion Cancelada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void chkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
    {
      if (this.lista.Count <= 0)
        return;
      if (this.chkSeleccionarTodos.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatosEnviados.Rows)
          dataGridViewRow.Cells["SeleccionarEnviado"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatosEnviados.Rows)
          dataGridViewRow.Cells["SeleccionarEnviado"].Value = (object) false;
      }
    }

    private void rdbBusquedaLibroBoletas_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rdbBusquedaLibroBoletas.Checked)
        return;
      this.rdbLibroVentas.Checked = false;
      this.rdbLibroVentas.Enabled = false;
      this.rdbLibroCompras.Checked = false;
      this.rdbLibroCompras.Enabled = false;
      this.rdbLibroBoletas.Checked = true;
      this.rdbLibroBoletas.Enabled = true;
      this.rdbLibroGuias.Checked = false;
      this.rdbLibroGuias.Enabled = false;
      this.tabControlBusqueda.TabPages.Clear();
      this.tabControlBusqueda.TabPages.Add(this.tabPagePorFecha);
      this.tabControlBusqueda.Enabled = true;
    }

    private void rdbBusquedaConsumoFolios_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rdbEnviarDte.Checked || this.rdbBusquedaConsumoFolios.Checked)
      {
        this.chk30.Enabled = false;
        this.chk35.Enabled = false;
        this.chk60.Enabled = false;
        this.chk39.Enabled = false;
        this.chk41.Enabled = false;
        this.chk30.Checked = false;
        this.chk35.Checked = false;
        this.chk60.Checked = false;
        this.chk39.Checked = false;
        this.chk41.Checked = false;
        this.tabControlBusqueda.Enabled = false;
        this.panelLibros.Visible = false;
      }
      else
      {
        this.chk33.Enabled = true;
        this.chk56.Enabled = true;
        this.chk61.Enabled = true;
        this.chk30.Enabled = true;
        this.chk35.Enabled = true;
        this.chk60.Enabled = true;
        this.chk39.Enabled = true;
        this.chk41.Enabled = true;
        this.panelLibros.Visible = true; 
      }
    }

    private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnResumenBoleta_Click(object sender, EventArgs e)
    {
        this.checkBox1.Checked = false;
        this.txtCantidadBoletas.ReadOnly = false;
        this.txtNetoBoletas.ReadOnly = false;
        this.txtIvaBoletas.ReadOnly = false;
        this.txtExentoBoletas.ReadOnly = false;
        txtPorcentajeIvaResumen.ReadOnly = false;
        this.txtTotalBoletas.ReadOnly = false;
        this._documentoResumen = "BOLETA";
        this.label17.Text = "Resumen de Boletas (35)";
        this.panelResumenBoletas.Visible = true;
        this.txtCantidadBoletas.Clear();
        this.txtNetoBoletas.Clear();
        this.txtIvaBoletas.Clear();
        this.txtExentoBoletas.Clear();
        this.txtTotalBoletas.Clear();
        this.txtCantidadBoletas.Focus(); Boleta bl = new Boleta();
        Decimal[] table_total = bl.totales_Boleta(dtpBusquedaDesde.Value.ToString("yyyy-MM-dd"), dtpBusquedaHasta.Value.ToString("yyyy-MM-dd"));
        if (table_total[0].ToString() == "0")
        {
            txtCantidadBoletas.Text = "0";
            txtNetoBoletas.Text = "0";
            txtIvaBoletas.Text = "0";
            txtExentoBoletas.Text = "0";
            txtTotalBoletas.Text = "0";
        }
        else
        {
            txtCantidadBoletas.Text = table_total[0].ToString("N0");
            txtNetoBoletas.Text = table_total[1].ToString("N0");
            txtIvaBoletas.Text = table_total[2].ToString("N0");
            txtExentoBoletas.Text = table_total[3].ToString("N0");
            txtTotalBoletas.Text = Decimal.Add(Convert.ToDecimal(table_total[1].ToString()), Convert.ToDecimal(table_total[2].ToString())).ToString("N0");
        }
        this.txtCantidadBoletas.ReadOnly = true;
        this.txtNetoBoletas.ReadOnly = true;
        this.txtIvaBoletas.ReadOnly = true;
        this.txtExentoBoletas.ReadOnly = true;
        txtPorcentajeIvaResumen.ReadOnly = true;
        this.txtTotalBoletas.ReadOnly = true;

    }

    private void btnResumenComprobantePago_Click(object sender, EventArgs e)
    {
        this.checkBox1.Checked = false;
        this._documentoResumen = "COMPROBANTE";
        this.label17.Text = "Resumen Comp. pago (48)";
        this.panelResumenBoletas.Visible = true;
        this.txtCantidadBoletas.Clear();
        this.txtNetoBoletas.Clear();
        this.txtIvaBoletas.Clear();
        this.txtExentoBoletas.Clear();
        this.txtTotalBoletas.Clear();
        this.txtCantidadBoletas.Focus();
        Boleta bl = new Boleta();
        Decimal[] table_total = bl.totales_trans(dtpBusquedaDesde.Value.ToString("yyyy-MM-dd"), dtpBusquedaHasta.Value.ToString("yyyy-MM-dd"));
        if (table_total[0].ToString() == "0")
        {
            txtCantidadBoletas.Text = "0";
            txtNetoBoletas.Text = "0";
            txtIvaBoletas.Text = "0";
            txtExentoBoletas.Text = "0";
            txtTotalBoletas.Text = "0";
        }
        else
        {
            txtCantidadBoletas.Text = table_total[0].ToString("N0");
            txtNetoBoletas.Text = table_total[1].ToString("N0");
            txtIvaBoletas.Text = table_total[2].ToString("N0");
            txtExentoBoletas.Text = table_total[3].ToString("N0");
            txtTotalBoletas.Text = Decimal.Add(Convert.ToDecimal(table_total[1].ToString()), Convert.ToDecimal(table_total[2].ToString())).ToString("N0");
        }
        this.txtCantidadBoletas.ReadOnly = true;
        this.txtNetoBoletas.ReadOnly = true;
        this.txtIvaBoletas.ReadOnly = true;
        this.txtExentoBoletas.ReadOnly = true;
        txtPorcentajeIvaResumen.ReadOnly = true;
        this.txtTotalBoletas.ReadOnly = true;
    }

    private void btnResumenBoletaExenta_Click(object sender, EventArgs e)
    {
        this.txtCantidadBoletas.ReadOnly = false;
        this.txtNetoBoletas.ReadOnly = false;
        this.txtIvaBoletas.ReadOnly = false;
        this.txtExentoBoletas.ReadOnly = false;
        txtPorcentajeIvaResumen.ReadOnly = false;
        this.txtTotalBoletas.ReadOnly = false;
        this._documentoResumen = "BOLETA_EXENTA";
        this.label17.Text = "Resumen de Boletas Exentas(38)";
        this.panelResumenBoletas.Visible = true;
        this.txtCantidadBoletas.Clear();
        this.txtNetoBoletas.Clear();
        this.txtIvaBoletas.Clear();
        this.txtExentoBoletas.Clear();
        this.txtTotalBoletas.Clear();
        this.txtCantidadBoletas.Focus();
        

    }
    void ingresa_resumen_boletas_fisicas()
    {
        if (this._documentoResumen.Equals("BOLETA"))
        {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            ///this.listaResumen.RemoveAll(frmGeneraodrDeEnvios.btnIngresarResumenBoleta)));
            Venta venta = new Venta();
            venta.DocumentoVenta = "BOLETA";
            venta.Fe_TipoDTE = 35;
            venta.Neto = this.txtNetoBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtNetoBoletas.Text.Trim()) : Decimal.Zero;
            venta.Iva = this.txtIvaBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtIvaBoletas.Text.Trim()) : Decimal.Zero;
            venta.TotalExento = this.txtExentoBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtExentoBoletas.Text.Trim()) : Decimal.Zero;
            venta.Total = this.txtTotalBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalBoletas.Text.Trim()) : Decimal.Zero;
            venta.TotalDocumentado = this.txtCantidadBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtCantidadBoletas.Text.Trim()) : Decimal.Zero;

            this.listaResumen.Add(venta);
            this.dgvResumen.DataSource = (object)null;
            this.dgvResumen.DataSource = (object)this.listaResumen;
            this._totalePeriodoManualBoleta35 = new TotalesPeriodo();
            this._totalePeriodoManualBoleta35.TpoDoc = 35;
            this._totalePeriodoManualBoleta35.TpoImp = 1;
            this._totalePeriodoManualBoleta35.TotDoc = Convert.ToInt32(venta.TotalDocumentado);
            this._totalePeriodoManualBoleta35.TotMntExe = venta.TotalExento;
            this._totalePeriodoManualBoleta35.TotMntNeto = Convert.ToInt32( venta.Neto);
            this._totalePeriodoManualBoleta35.TotOpIVARec = 0;
            this._totalePeriodoManualBoleta35.TotMntIVA = Convert.ToInt32( venta.Iva);
            this._totalePeriodoManualBoleta35.TotOpIVAUsoComun = 0;
            this._totalePeriodoManualBoleta35.TotIVAUsoComun = Decimal.Zero;
            this._totalePeriodoManualBoleta35.TotImpSinCredito = Decimal.Zero;
            this._totalePeriodoManualBoleta35.TotMntTotal = Convert.ToInt32(venta.Total);
    
        }
        if (this._documentoResumen.Equals("COMPROBANTE"))
        {
            if (this._documentoResumen.Equals("BOLETA"))
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                ///this.listaResumen.RemoveAll(frmGeneraodrDeEnvios.btnIngresarResumenBoleta)));
                Venta venta = new Venta();
                venta.DocumentoVenta = "BOLETA";
                venta.Fe_TipoDTE = 35;
                venta.Neto = this.txtNetoBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtNetoBoletas.Text.Trim()) : Decimal.Zero;
                venta.Iva = this.txtIvaBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtIvaBoletas.Text.Trim()) : Decimal.Zero;
                venta.TotalExento = this.txtExentoBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtExentoBoletas.Text.Trim()) : Decimal.Zero;
                venta.Total = this.txtTotalBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalBoletas.Text.Trim()) : Decimal.Zero;
                venta.TotalDocumentado = this.txtCantidadBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtCantidadBoletas.Text.Trim()) : Decimal.Zero;
                this.listaResumen.Add(venta);//agrega a resumen
                this.dgvResumen.DataSource = (object)null;
                this.dgvResumen.DataSource = (object)this.listaResumen;
                this._totalePeriodoManualBoleta35_2 = new TotalesPeriodo();
                this._totalePeriodoManualBoleta35_2.TpoDoc = 35;
                this._totalePeriodoManualBoleta35_2.TpoImp = 1;
                this._totalePeriodoManualBoleta35_2.TotDoc = Convert.ToInt32(venta.TotalDocumentado);
                this._totalePeriodoManualBoleta35_2.TotMntExe = venta.TotalExento;
                this._totalePeriodoManualBoleta35_2.TotMntNeto = venta.Neto;
                this._totalePeriodoManualBoleta35_2.TotOpIVARec = 0;
                this._totalePeriodoManualBoleta35_2.TotMntIVA = venta.Iva;
                this._totalePeriodoManualBoleta35_2.TotOpIVAUsoComun = 0;
                this._totalePeriodoManualBoleta35_2.TotIVAUsoComun = Decimal.Zero;
                this._totalePeriodoManualBoleta35_2.TotImpSinCredito = Decimal.Zero;
                this._totalePeriodoManualBoleta35_2.TotMntTotal = venta.Total;
            }
            if (this._documentoResumen.Equals("COMPROBANTE"))
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                //this.listaResumen.RemoveAll(frmGeneraodrDeEnvios = new Predicate<Venta>(frmGeneraodrDeEnvios.btnIngresarResumenBoleta_Click)));
                Venta venta = new Venta();
                venta.DocumentoVenta = "Comprobante de pago electrónico";
                venta.Fe_TipoDTE = 48;
                venta.Neto = this.txtNetoBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtNetoBoletas.Text.Trim()) : Decimal.Zero;
                venta.Iva = this.txtIvaBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtIvaBoletas.Text.Trim()) : Decimal.Zero;
                venta.TotalExento = this.txtExentoBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtExentoBoletas.Text.Trim()) : Decimal.Zero;
                venta.Total = this.txtTotalBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalBoletas.Text.Trim()) : Decimal.Zero;
                venta.TotalDocumentado = this.txtCantidadBoletas.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtCantidadBoletas.Text.Trim()) : Decimal.Zero;
                this.listaResumen.Add(venta);
                this.dgvResumen.DataSource = (object)null;
                this.dgvResumen.DataSource = (object)this.listaResumen;
                this._totalePeriodoManualBoleta48 = new TotalesPeriodo();
                this._totalePeriodoManualBoleta48.TpoDoc = 48;
                this._totalePeriodoManualBoleta48.TpoImp = 1;
                this._totalePeriodoManualBoleta48.TotDoc = Convert.ToInt32(venta.TotalDocumentado);
                this._totalePeriodoManualBoleta48.TotMntExe = venta.TotalExento;
                this._totalePeriodoManualBoleta48.TotMntNeto = venta.Neto;
                this._totalePeriodoManualBoleta48.TotOpIVARec = 0;
                this._totalePeriodoManualBoleta48.TotMntIVA = venta.Iva;
                this._totalePeriodoManualBoleta48.TotOpIVAUsoComun = 0;
                this._totalePeriodoManualBoleta48.TotIVAUsoComun = Decimal.Zero;
                this._totalePeriodoManualBoleta48.TotImpSinCredito = Decimal.Zero;
                this._totalePeriodoManualBoleta48.TotMntTotal = venta.Total;
            }
        }
            this.panelResumenBoletas.Visible = false;   
    }
    private void btnIngresarResumenBoleta_Click(object sender, EventArgs e)
    {
        ingresa_resumen_boletas_fisicas();
      ///this.panelResumenBoletas.Visible = false;

    }

    private void tabControl2_Enter(object sender, EventArgs e)
    {
        //this.iniciaFormulario();
    }

    private void tabControl2_Leave(object sender, EventArgs e)
    {
        //this.iniciaFormulario();
    }

    private void dgvDatos_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        this.iniciaFormulario();
    }

    private void tabPage3_Click(object sender, EventArgs e)
    {

    }

    private void tabPage3_Enter(object sender, EventArgs e)
    {
        
    }

    private void tabPage3_Leave(object sender, EventArgs e)
    {
            //DataTable dt = (DataTable)dgvDatos.DataSource;
            //dt.Clear();
        //this.iniciaFormulario();
       
    }

    private void tabPage4_Click(object sender, EventArgs e)
    {

    }

    private void tabPage4_Leave(object sender, EventArgs e)
    {
        //DataTable dt = (DataTable)dgvDatosEnviados.DataSource;
        //dt.Clear();
      //  this.iniciaFormulario();
    }

    private void btnResumenBoleta_Click_1(object sender, EventArgs e)
    {
        this.panelResumenBoletas.Visible = true;
    }

    private void dgvDatosEnviados_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        this.iniciaFormulario();
       
    }

    private void button2_Click(object sender, EventArgs e)
    {
          panelResumenBoletas.Visible = false;
        this.txtExentoBoletas.Text = "0";
        this.txtCantidadBoletas.Text = "0";
        this.txtIvaBoletas.Text = "0";
        this.txtNetoBoletas.Text = "0";
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
        {
            if (MessageBox.Show("Esta Seguro que desea Editar Los Resultados,\r\nestos no se guardaran en la base de datos", "aptusoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.txtCantidadBoletas.ReadOnly = false;
                this.txtNetoBoletas.ReadOnly = false;
                this.txtIvaBoletas.ReadOnly = false;
                this.txtExentoBoletas.ReadOnly = false;
                this.txtTotalBoletas.ReadOnly = false;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
        else
        {
            this.txtCantidadBoletas.ReadOnly = true;
            this.txtNetoBoletas.ReadOnly = true;
            this.txtIvaBoletas.ReadOnly = true;
            this.txtExentoBoletas.ReadOnly = true;
            this.txtTotalBoletas.ReadOnly = true;
        }
    }
  }
}
