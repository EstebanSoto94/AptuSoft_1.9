 
// Type: Aptusoft.frmModuloFacturacionAptusoft
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Formularios;
using Aptusoft.InternoAptusoft.Contratacion;
using Aptusoft.InternoAptusoft.Email;
using Aptusoft.InternoAptusoft.Facturacion;
using Aptusoft.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmModuloFacturacionAptusoft : Form
  {
    private IContainer components = (IContainer) null;
    private int idCliente = 0;
    private List<ContratoVO> _listaContratos = new List<ContratoVO>();
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private GroupBox gbZonaCliente;
    private Label lblDias;
    private TextBox txtMesesSoporte;
    private TextBox txtInicioSoporte;
    private Label label35;
    private Label label16;
    private Label label34;
    private TextBox txtEmail;
    private Button btnBuscaCliente;
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
    private Label label31;
    private Label label30;
    private DataGridView dgvNotaCredito;
    private DataGridView dgvDatosVenta;
    private TextBox txtDeuda;
    private TextBox txtTotalPendiente;
    private TextBox txtTotalPagado;
    private Label label26;
    private Label label27;
    private Label label28;
    private TextBox txtTotalDocumentado;
    private Label label33;
    private TextBox txtTotalDisponible;
    private Label label32;
    private TextBox txtTotalUsado;
    private Label label18;
    private Label label1;
    private Label label2;
    private TextBox txtFechaUltimaCompra;
    private DateTimePicker dtpFechaIngreso;
    private Button btnLimpiar;
    private TabControl tabControl2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private Panel panel2;
    private TabPage tabPage5;
    private DataGridView dgvProductosCliente;
    private DataGridView dgvPagosClientes;
    private Panel pnlBuscaClienteDes;
    private DataGridView dgvBuscaCliente;
    private TabPage tabPage6;
    private DataGridView dgvOt;
    private Button btnOt;
    private Button btnSalir;
    private Label label14;
    private Label label15;
    private DataGridView dgvListadoPagos;
    private Label label19;
    private Button btnBuscaClienteListadoPago;
    private TextBox txtClienteListadoPago;
    private Label label17;
    private ComboBox cmbEstadoPagoListado;
    private Label label20;
    private DateTimePicker dtpHasta;
    private Label label22;
    private DateTimePicker dtpDesde;
    private Button btnBuscaListadoPagos;
    private TabPage tabPage7;
    private DataGridView dgvFacturacionCiclo;
    private RadioButton rdbCiclo15;
    private RadioButton rdbCiclo1y2;
    private Button btnBuscarContratosAFacturar;
    private DateTimePicker dtpFechaFacturacion;
    private CheckBox chkMarcarTodos;
    private Button btnFacturar;
    private Label lblAlertaFacturando;
    private Panel panelColorDeuda;
    private DataGridViewTextBoxColumn IdContrato;
    private DataGridViewTextBoxColumn IdClienteFacturacion;
    private DataGridViewTextBoxColumn Rut;
    private DataGridViewTextBoxColumn Digito;
    private DataGridViewTextBoxColumn RazonSocial;
    private DataGridViewTextBoxColumn Email;
    private DataGridViewTextBoxColumn DescripcionFacturacion;
    private DataGridViewTextBoxColumn SubTotal;
    private DataGridViewTextBoxColumn CodigoCiclo;
    private DataGridViewTextBoxColumn CodigoOferta;
    private DataGridViewTextBoxColumn DescripcionOferta;
    private DataGridViewTextBoxColumn MesesOferta;
    private DataGridViewTextBoxColumn MesesOfertaOcupado;
    private DataGridViewTextBoxColumn MesesOfertaRestante;
    private DataGridViewTextBoxColumn DescuentoOferta;
    private DataGridViewTextBoxColumn Descuento;
    private DataGridViewTextBoxColumn Total;
    private DataGridViewCheckBoxColumn Facturar;
    private DataGridViewTextBoxColumn SegundaFacturacion;
    private GroupBox groupBox1;
    private Panel panelAptusoft;
    private Panel panel3;
    private TextBox txtPagoPendiente;
    private TextBox txtMonto;
    private Label label40;
    private TextBox txtCantidadDocPendiente;
    private Label label39;
    private Label label29;
    private Panel panelPago;
    private RadioButton rdbDocumentado;
    private ComboBox cmbMedioPago;
    private DateTimePicker dtpFechaCobro;
    private TextBox txtObservaciones;
    private RadioButton rdbPagado;
    private TextBox txtNumeroDocumento;
    private Label label23;
    private TextBox txtCuenta;
    private ComboBox cmbBanco;
    private Label label24;
    private Label label25;
    private Label label36;
    private Label label37;
    private Label label38;
    private TabPage tabPage8;
    private DataGridView dgvPendientes;
    private DataGridViewTextBoxColumn FechaCobro;
    private DataGridViewTextBoxColumn TipoDocumento;
    private DataGridViewTextBoxColumn FolioCobro;
    private DataGridViewTextBoxColumn Monto;
    private DataGridViewTextBoxColumn MedioPagoPV;
    private DataGridViewTextBoxColumn EstadoPagoPV;
    private DataGridViewTextBoxColumn Fecha;
    private DataGridViewTextBoxColumn TipoDocumentoCompra;
    private DataGridViewTextBoxColumn Folio;
    private DataGridViewTextBoxColumn Codigo;
    private DataGridViewTextBoxColumn Descripcion;
    private DataGridViewTextBoxColumn Cantidad;
    private DataGridViewTextBoxColumn Valor;
    private GroupBox groupBox4;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private Panel panel4;
    private Button btnLimpiarPago;
    private Button btnPagar;
    private CheckBox chkSeleccionarTodos;
    private frmModuloFacturacionAptusoft intance;

    public frmModuloFacturacionAptusoft()
    {
      this.InitializeComponent();
      if (!frmMenuPrincipal._Aptusoft)
      {
        this.tabControl1.Controls.Remove((Control) this.tabPage7);
        this.tabControl2.Controls.Remove((Control) this.tabPage6);
        this.panelColorDeuda.Visible = false;
        this.panelAptusoft.Visible = false;
      }
      this.intance = this;
      this.dgvFacturacionCiclo.AutoGenerateColumns = false;
      this.creaColumnasDetalle();
      this.creaColumnasDetallePendientes();
      this.creaColumnasDetalleNC();
      this.creaColumnasBuscaClientes();
      this.creaColumnasOt();
      this.creaColumnasListadoPagos();
      this.dgvProductosCliente.AutoGenerateColumns = false;
      this.dgvPagosClientes.AutoGenerateColumns = false;
      this.cargaEstadoPago();
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle13 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle14 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle15 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle16 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle17 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle18 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle19 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle20 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle21 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle22 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle23 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle24 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle25 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle26 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle27 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle28 = new DataGridViewCellStyle();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.pnlBuscaClienteDes = new Panel();
      this.dgvBuscaCliente = new DataGridView();
      this.panel2 = new Panel();
      this.groupBox4 = new GroupBox();
      this.label33 = new Label();
      this.txtDeuda = new TextBox();
      this.groupBox2 = new GroupBox();
      this.txtTotalDocumentado = new TextBox();
      this.txtTotalPagado = new TextBox();
      this.label26 = new Label();
      this.label27 = new Label();
      this.txtTotalPendiente = new TextBox();
      this.label28 = new Label();
      this.groupBox3 = new GroupBox();
      this.label18 = new Label();
      this.txtTotalUsado = new TextBox();
      this.label32 = new Label();
      this.txtTotalDisponible = new TextBox();
      this.tabControl2 = new TabControl();
      this.tabPage3 = new TabPage();
      this.dgvDatosVenta = new DataGridView();
      this.label30 = new Label();
      this.dgvNotaCredito = new DataGridView();
      this.label31 = new Label();
      this.tabPage4 = new TabPage();
      this.label14 = new Label();
      this.dgvPagosClientes = new DataGridView();
      this.FechaCobro = new DataGridViewTextBoxColumn();
      this.TipoDocumento = new DataGridViewTextBoxColumn();
      this.FolioCobro = new DataGridViewTextBoxColumn();
      this.Monto = new DataGridViewTextBoxColumn();
      this.MedioPagoPV = new DataGridViewTextBoxColumn();
      this.EstadoPagoPV = new DataGridViewTextBoxColumn();
      this.tabPage8 = new TabPage();
      this.panel3 = new Panel();
      this.chkSeleccionarTodos = new CheckBox();
      this.txtCantidadDocPendiente = new TextBox();
      this.txtPagoPendiente = new TextBox();
      this.label40 = new Label();
      this.label39 = new Label();
      this.panelPago = new Panel();
      this.btnLimpiarPago = new Button();
      this.btnPagar = new Button();
      this.panel4 = new Panel();
      this.label36 = new Label();
      this.label37 = new Label();
      this.label25 = new Label();
      this.txtObservaciones = new TextBox();
      this.label24 = new Label();
      this.cmbBanco = new ComboBox();
      this.txtNumeroDocumento = new TextBox();
      this.txtCuenta = new TextBox();
      this.txtMonto = new TextBox();
      this.rdbDocumentado = new RadioButton();
      this.cmbMedioPago = new ComboBox();
      this.dtpFechaCobro = new DateTimePicker();
      this.rdbPagado = new RadioButton();
      this.label29 = new Label();
      this.label23 = new Label();
      this.label38 = new Label();
      this.dgvPendientes = new DataGridView();
      this.tabPage5 = new TabPage();
      this.dgvProductosCliente = new DataGridView();
      this.Fecha = new DataGridViewTextBoxColumn();
      this.TipoDocumentoCompra = new DataGridViewTextBoxColumn();
      this.Folio = new DataGridViewTextBoxColumn();
      this.Codigo = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.Cantidad = new DataGridViewTextBoxColumn();
      this.Valor = new DataGridViewTextBoxColumn();
      this.tabPage6 = new TabPage();
      this.label15 = new Label();
      this.btnOt = new Button();
      this.dgvOt = new DataGridView();
      this.gbZonaCliente = new GroupBox();
      this.panelAptusoft = new Panel();
      this.label34 = new Label();
      this.label35 = new Label();
      this.txtInicioSoporte = new TextBox();
      this.lblDias = new Label();
      this.txtMesesSoporte = new TextBox();
      this.dtpFechaIngreso = new DateTimePicker();
      this.label2 = new Label();
      this.txtFechaUltimaCompra = new TextBox();
      this.label1 = new Label();
      this.label16 = new Label();
      this.txtEmail = new TextBox();
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
      this.tabPage2 = new TabPage();
      this.groupBox1 = new GroupBox();
      this.cmbEstadoPagoListado = new ComboBox();
      this.label17 = new Label();
      this.btnBuscaClienteListadoPago = new Button();
      this.label20 = new Label();
      this.txtClienteListadoPago = new TextBox();
      this.dtpHasta = new DateTimePicker();
      this.label19 = new Label();
      this.label22 = new Label();
      this.dtpDesde = new DateTimePicker();
      this.btnBuscaListadoPagos = new Button();
      this.dgvListadoPagos = new DataGridView();
      this.tabPage7 = new TabPage();
      this.lblAlertaFacturando = new Label();
      this.btnFacturar = new Button();
      this.chkMarcarTodos = new CheckBox();
      this.dtpFechaFacturacion = new DateTimePicker();
      this.rdbCiclo15 = new RadioButton();
      this.rdbCiclo1y2 = new RadioButton();
      this.btnBuscarContratosAFacturar = new Button();
      this.dgvFacturacionCiclo = new DataGridView();
      this.IdContrato = new DataGridViewTextBoxColumn();
      this.IdClienteFacturacion = new DataGridViewTextBoxColumn();
      this.Rut = new DataGridViewTextBoxColumn();
      this.Digito = new DataGridViewTextBoxColumn();
      this.RazonSocial = new DataGridViewTextBoxColumn();
      this.Email = new DataGridViewTextBoxColumn();
      this.DescripcionFacturacion = new DataGridViewTextBoxColumn();
      this.SubTotal = new DataGridViewTextBoxColumn();
      this.CodigoCiclo = new DataGridViewTextBoxColumn();
      this.CodigoOferta = new DataGridViewTextBoxColumn();
      this.DescripcionOferta = new DataGridViewTextBoxColumn();
      this.MesesOferta = new DataGridViewTextBoxColumn();
      this.MesesOfertaOcupado = new DataGridViewTextBoxColumn();
      this.MesesOfertaRestante = new DataGridViewTextBoxColumn();
      this.DescuentoOferta = new DataGridViewTextBoxColumn();
      this.Descuento = new DataGridViewTextBoxColumn();
      this.Total = new DataGridViewTextBoxColumn();
      this.Facturar = new DataGridViewCheckBoxColumn();
      this.SegundaFacturacion = new DataGridViewTextBoxColumn();
      this.panelColorDeuda = new Panel();
      this.btnLimpiar = new Button();
      this.btnSalir = new Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.pnlBuscaClienteDes.SuspendLayout();
      ((ISupportInitialize) this.dgvBuscaCliente).BeginInit();
      this.panel2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((ISupportInitialize) this.dgvDatosVenta).BeginInit();
      ((ISupportInitialize) this.dgvNotaCredito).BeginInit();
      this.tabPage4.SuspendLayout();
      ((ISupportInitialize) this.dgvPagosClientes).BeginInit();
      this.tabPage8.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panelPago.SuspendLayout();
      this.panel4.SuspendLayout();
      ((ISupportInitialize) this.dgvPendientes).BeginInit();
      this.tabPage5.SuspendLayout();
      ((ISupportInitialize) this.dgvProductosCliente).BeginInit();
      this.tabPage6.SuspendLayout();
      ((ISupportInitialize) this.dgvOt).BeginInit();
      this.gbZonaCliente.SuspendLayout();
      this.panelAptusoft.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvListadoPagos).BeginInit();
      this.tabPage7.SuspendLayout();
      ((ISupportInitialize) this.dgvFacturacionCiclo).BeginInit();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage7);
      this.tabControl1.Location = new Point(4, 5);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(1034, 571);
      this.tabControl1.TabIndex = 0;
      this.tabPage1.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage1.Controls.Add((Control) this.pnlBuscaClienteDes);
      this.tabPage1.Controls.Add((Control) this.panel2);
      this.tabPage1.Controls.Add((Control) this.tabControl2);
      this.tabPage1.Controls.Add((Control) this.gbZonaCliente);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(1026, 545);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Ficha Cliente";
      this.pnlBuscaClienteDes.BorderStyle = BorderStyle.FixedSingle;
      this.pnlBuscaClienteDes.Controls.Add((Control) this.dgvBuscaCliente);
      this.pnlBuscaClienteDes.Location = new Point(1019, 46);
      this.pnlBuscaClienteDes.Name = "pnlBuscaClienteDes";
      this.pnlBuscaClienteDes.Size = new Size(60, 233);
      this.pnlBuscaClienteDes.TabIndex = 38;
      this.pnlBuscaClienteDes.Visible = false;
      this.dgvBuscaCliente.AllowUserToAddRows = false;
      this.dgvBuscaCliente.AllowUserToDeleteRows = false;
      this.dgvBuscaCliente.AllowUserToResizeColumns = false;
      this.dgvBuscaCliente.AllowUserToResizeRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvBuscaCliente.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvBuscaCliente.BackgroundColor = Color.LavenderBlush;
      this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvBuscaCliente.DefaultCellStyle = gridViewCellStyle2;
      this.dgvBuscaCliente.Location = new Point(2, 1);
      this.dgvBuscaCliente.Name = "dgvBuscaCliente";
      this.dgvBuscaCliente.ReadOnly = true;
      this.dgvBuscaCliente.RowHeadersVisible = false;
      this.dgvBuscaCliente.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaCliente.Size = new Size(750, 227);
      this.dgvBuscaCliente.TabIndex = 0;
      this.dgvBuscaCliente.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaCliente_CellDoubleClick);
      this.dgvBuscaCliente.KeyDown += new KeyEventHandler(this.dgvBuscaCliente_KeyDown);
      this.panel2.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.panel2.BorderStyle = BorderStyle.FixedSingle;
      this.panel2.Controls.Add((Control) this.groupBox4);
      this.panel2.Controls.Add((Control) this.groupBox2);
      this.panel2.Controls.Add((Control) this.groupBox3);
      this.panel2.Location = new Point(877, 178);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(140, 364);
      this.panel2.TabIndex = 38;
      this.groupBox4.Controls.Add((Control) this.label33);
      this.groupBox4.Controls.Add((Control) this.txtDeuda);
      this.groupBox4.Location = new Point(10, 283);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(117, 62);
      this.groupBox4.TabIndex = 39;
      this.groupBox4.TabStop = false;
      this.label33.AutoSize = true;
      this.label33.BackColor = Color.Transparent;
      this.label33.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label33.Location = new Point(29, 16);
      this.label33.Name = "label33";
      this.label33.Size = new Size(77, 13);
      this.label33.TabIndex = 36;
      this.label33.Text = "Total Deuda";
      this.txtDeuda.BackColor = Color.White;
      this.txtDeuda.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDeuda.ForeColor = Color.Black;
      this.txtDeuda.Location = new Point(9, 32);
      this.txtDeuda.Name = "txtDeuda";
      this.txtDeuda.ReadOnly = true;
      this.txtDeuda.Size = new Size(97, 21);
      this.txtDeuda.TabIndex = 34;
      this.txtDeuda.TextAlign = HorizontalAlignment.Right;
      this.groupBox2.Controls.Add((Control) this.txtTotalDocumentado);
      this.groupBox2.Controls.Add((Control) this.txtTotalPagado);
      this.groupBox2.Controls.Add((Control) this.label26);
      this.groupBox2.Controls.Add((Control) this.label27);
      this.groupBox2.Controls.Add((Control) this.txtTotalPendiente);
      this.groupBox2.Controls.Add((Control) this.label28);
      this.groupBox2.Location = new Point(10, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(117, 154);
      this.groupBox2.TabIndex = 39;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Ventas";
      this.txtTotalDocumentado.BackColor = Color.White;
      this.txtTotalDocumentado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalDocumentado.ForeColor = Color.Black;
      this.txtTotalDocumentado.Location = new Point(9, 75);
      this.txtTotalDocumentado.Name = "txtTotalDocumentado";
      this.txtTotalDocumentado.ReadOnly = true;
      this.txtTotalDocumentado.Size = new Size(97, 21);
      this.txtTotalDocumentado.TabIndex = 18;
      this.txtTotalDocumentado.TextAlign = HorizontalAlignment.Right;
      this.txtTotalPagado.BackColor = Color.White;
      this.txtTotalPagado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalPagado.ForeColor = Color.Black;
      this.txtTotalPagado.Location = new Point(9, 35);
      this.txtTotalPagado.Name = "txtTotalPagado";
      this.txtTotalPagado.ReadOnly = true;
      this.txtTotalPagado.Size = new Size(97, 21);
      this.txtTotalPagado.TabIndex = 19;
      this.txtTotalPagado.TextAlign = HorizontalAlignment.Right;
      this.label26.AutoSize = true;
      this.label26.BackColor = Color.Transparent;
      this.label26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label26.Location = new Point(42, 99);
      this.label26.Name = "label26";
      this.label26.Size = new Size(64, 13);
      this.label26.TabIndex = 20;
      this.label26.Text = "Pendiente";
      this.label27.AutoSize = true;
      this.label27.BackColor = Color.Transparent;
      this.label27.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label27.Location = new Point(32, 59);
      this.label27.Name = "label27";
      this.label27.Size = new Size(74, 13);
      this.label27.TabIndex = 21;
      this.label27.Text = "Documentado";
      this.txtTotalPendiente.BackColor = Color.White;
      this.txtTotalPendiente.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalPendiente.ForeColor = Color.Black;
      this.txtTotalPendiente.Location = new Point(9, 115);
      this.txtTotalPendiente.Name = "txtTotalPendiente";
      this.txtTotalPendiente.ReadOnly = true;
      this.txtTotalPendiente.Size = new Size(97, 21);
      this.txtTotalPendiente.TabIndex = 17;
      this.txtTotalPendiente.TextAlign = HorizontalAlignment.Right;
      this.label28.AutoSize = true;
      this.label28.BackColor = Color.Transparent;
      this.label28.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label28.Location = new Point(62, 19);
      this.label28.Name = "label28";
      this.label28.Size = new Size(44, 13);
      this.label28.TabIndex = 22;
      this.label28.Text = "Pagado";
      this.groupBox3.Controls.Add((Control) this.label18);
      this.groupBox3.Controls.Add((Control) this.txtTotalUsado);
      this.groupBox3.Controls.Add((Control) this.label32);
      this.groupBox3.Controls.Add((Control) this.txtTotalDisponible);
      this.groupBox3.Location = new Point(10, 165);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(117, 113);
      this.groupBox3.TabIndex = 40;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Notas de Credito";
      this.label18.AutoSize = true;
      this.label18.BackColor = Color.Transparent;
      this.label18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.Location = new Point(68, 25);
      this.label18.Name = "label18";
      this.label18.Size = new Size(38, 13);
      this.label18.TabIndex = 24;
      this.label18.Text = "Usado";
      this.txtTotalUsado.BackColor = Color.White;
      this.txtTotalUsado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalUsado.ForeColor = Color.Black;
      this.txtTotalUsado.Location = new Point(9, 41);
      this.txtTotalUsado.Name = "txtTotalUsado";
      this.txtTotalUsado.ReadOnly = true;
      this.txtTotalUsado.Size = new Size(97, 21);
      this.txtTotalUsado.TabIndex = 23;
      this.txtTotalUsado.TextAlign = HorizontalAlignment.Right;
      this.label32.AutoSize = true;
      this.label32.BackColor = Color.Transparent;
      this.label32.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label32.Location = new Point(40, 66);
      this.label32.Name = "label32";
      this.label32.Size = new Size(66, 13);
      this.label32.TabIndex = 26;
      this.label32.Text = "Disponible";
      this.txtTotalDisponible.BackColor = Color.White;
      this.txtTotalDisponible.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTotalDisponible.ForeColor = Color.Black;
      this.txtTotalDisponible.Location = new Point(9, 82);
      this.txtTotalDisponible.Name = "txtTotalDisponible";
      this.txtTotalDisponible.ReadOnly = true;
      this.txtTotalDisponible.Size = new Size(97, 21);
      this.txtTotalDisponible.TabIndex = 25;
      this.txtTotalDisponible.TextAlign = HorizontalAlignment.Right;
      this.tabControl2.Controls.Add((Control) this.tabPage3);
      this.tabControl2.Controls.Add((Control) this.tabPage4);
      this.tabControl2.Controls.Add((Control) this.tabPage8);
      this.tabControl2.Controls.Add((Control) this.tabPage5);
      this.tabControl2.Controls.Add((Control) this.tabPage6);
      this.tabControl2.Location = new Point(6, 158);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(869, 384);
      this.tabControl2.TabIndex = 37;
      this.tabPage3.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage3.Controls.Add((Control) this.dgvDatosVenta);
      this.tabPage3.Controls.Add((Control) this.label30);
      this.tabPage3.Controls.Add((Control) this.dgvNotaCredito);
      this.tabPage3.Controls.Add((Control) this.label31);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(861, 358);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "Ventas";
      this.dgvDatosVenta.AllowUserToAddRows = false;
      this.dgvDatosVenta.AllowUserToDeleteRows = false;
      gridViewCellStyle3.BackColor = Color.Lavender;
      this.dgvDatosVenta.AlternatingRowsDefaultCellStyle = gridViewCellStyle3;
      this.dgvDatosVenta.BackgroundColor = Color.LightSteelBlue;
      this.dgvDatosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle4.BackColor = SystemColors.Window;
      gridViewCellStyle4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle4.ForeColor = SystemColors.ControlText;
      gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
      this.dgvDatosVenta.DefaultCellStyle = gridViewCellStyle4;
      this.dgvDatosVenta.Location = new Point(6, 20);
      this.dgvDatosVenta.Name = "dgvDatosVenta";
      this.dgvDatosVenta.ReadOnly = true;
      this.dgvDatosVenta.RowHeadersVisible = false;
      this.dgvDatosVenta.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatosVenta.Size = new Size(850, 180);
      this.dgvDatosVenta.TabIndex = 29;
      this.dgvDatosVenta.CellClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
      this.label30.AutoSize = true;
      this.label30.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label30.Location = new Point(5, 2);
      this.label30.Name = "label30";
      this.label30.Size = new Size(124, 15);
      this.label30.TabIndex = 31;
      this.label30.Text = "Facturas y Boletas";
      this.dgvNotaCredito.AllowUserToAddRows = false;
      this.dgvNotaCredito.AllowUserToDeleteRows = false;
      gridViewCellStyle5.BackColor = Color.Lavender;
      this.dgvNotaCredito.AlternatingRowsDefaultCellStyle = gridViewCellStyle5;
      this.dgvNotaCredito.BackgroundColor = Color.LightSteelBlue;
      this.dgvNotaCredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvNotaCredito.Location = new Point(6, 221);
      this.dgvNotaCredito.Name = "dgvNotaCredito";
      this.dgvNotaCredito.ReadOnly = true;
      this.dgvNotaCredito.RowHeadersVisible = false;
      this.dgvNotaCredito.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvNotaCredito.Size = new Size(850, 131);
      this.dgvNotaCredito.TabIndex = 30;
      this.label31.AutoSize = true;
      this.label31.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label31.Location = new Point(5, 203);
      this.label31.Name = "label31";
      this.label31.Size = new Size(114, 15);
      this.label31.TabIndex = 32;
      this.label31.Text = "Notas de Credito";
      this.tabPage4.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage4.Controls.Add((Control) this.label14);
      this.tabPage4.Controls.Add((Control) this.dgvPagosClientes);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(861, 358);
      this.tabPage4.TabIndex = 1;
      this.tabPage4.Text = "Pagos";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(11, 10);
      this.label14.Name = "label14";
      this.label14.Size = new Size(210, 13);
      this.label14.TabIndex = 1;
      this.label14.Text = "Doble Click sobre la fila para Ingresar Pago";
      this.dgvPagosClientes.AllowUserToAddRows = false;
      this.dgvPagosClientes.AllowUserToDeleteRows = false;
      gridViewCellStyle6.BackColor = Color.Lavender;
      this.dgvPagosClientes.AlternatingRowsDefaultCellStyle = gridViewCellStyle6;
      this.dgvPagosClientes.BackgroundColor = Color.LightSteelBlue;
      this.dgvPagosClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPagosClientes.Columns.AddRange((DataGridViewColumn) this.FechaCobro, (DataGridViewColumn) this.TipoDocumento, (DataGridViewColumn) this.FolioCobro, (DataGridViewColumn) this.Monto, (DataGridViewColumn) this.MedioPagoPV, (DataGridViewColumn) this.EstadoPagoPV);
      this.dgvPagosClientes.Location = new Point(11, 29);
      this.dgvPagosClientes.Name = "dgvPagosClientes";
      this.dgvPagosClientes.ReadOnly = true;
      this.dgvPagosClientes.RowHeadersVisible = false;
      this.dgvPagosClientes.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvPagosClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvPagosClientes.Size = new Size(844, 300);
      this.dgvPagosClientes.TabIndex = 0;
      this.dgvPagosClientes.DoubleClick += new EventHandler(this.dgvPagosClientes_DoubleClick);
      this.FechaCobro.DataPropertyName = "FechaCobro";
      gridViewCellStyle7.Format = "d";
      gridViewCellStyle7.NullValue = (object) null;
      this.FechaCobro.DefaultCellStyle = gridViewCellStyle7;
      this.FechaCobro.HeaderText = "Fecha de Cobro";
      this.FechaCobro.Name = "FechaCobro";
      this.FechaCobro.ReadOnly = true;
      this.FechaCobro.Width = 110;
      this.TipoDocumento.DataPropertyName = "TipoDocumento";
      this.TipoDocumento.HeaderText = "TipoDocumento";
      this.TipoDocumento.Name = "TipoDocumento";
      this.TipoDocumento.ReadOnly = true;
      this.TipoDocumento.Width = 200;
      this.FolioCobro.DataPropertyName = "FolioDocumento";
      gridViewCellStyle8.Format = "N0";
      gridViewCellStyle8.NullValue = (object) "0";
      this.FolioCobro.DefaultCellStyle = gridViewCellStyle8;
      this.FolioCobro.HeaderText = "Folio";
      this.FolioCobro.Name = "FolioCobro";
      this.FolioCobro.ReadOnly = true;
      this.Monto.DataPropertyName = "Monto";
      gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle9.Format = "N0";
      gridViewCellStyle9.NullValue = (object) "0";
      this.Monto.DefaultCellStyle = gridViewCellStyle9;
      this.Monto.HeaderText = "Monto";
      this.Monto.Name = "Monto";
      this.Monto.ReadOnly = true;
      this.MedioPagoPV.DataPropertyName = "FormaPago";
      this.MedioPagoPV.HeaderText = "MedioPago";
      this.MedioPagoPV.Name = "MedioPagoPV";
      this.MedioPagoPV.ReadOnly = true;
      this.MedioPagoPV.Width = 165;
      this.EstadoPagoPV.DataPropertyName = "Estado";
      this.EstadoPagoPV.HeaderText = "EstadoPago";
      this.EstadoPagoPV.Name = "EstadoPagoPV";
      this.EstadoPagoPV.ReadOnly = true;
      this.EstadoPagoPV.Width = 150;
      this.tabPage8.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage8.Controls.Add((Control) this.panel3);
      this.tabPage8.Controls.Add((Control) this.panelPago);
      this.tabPage8.Controls.Add((Control) this.dgvPendientes);
      this.tabPage8.Location = new Point(4, 22);
      this.tabPage8.Name = "tabPage8";
      this.tabPage8.Padding = new Padding(3);
      this.tabPage8.Size = new Size(861, 358);
      this.tabPage8.TabIndex = 4;
      this.tabPage8.Text = "Saldo Pendiente";
      this.panel3.BackColor = Color.FromArgb(223, 233, 245);
      this.panel3.BorderStyle = BorderStyle.FixedSingle;
      this.panel3.Controls.Add((Control) this.chkSeleccionarTodos);
      this.panel3.Controls.Add((Control) this.txtCantidadDocPendiente);
      this.panel3.Controls.Add((Control) this.txtPagoPendiente);
      this.panel3.Controls.Add((Control) this.label40);
      this.panel3.Controls.Add((Control) this.label39);
      this.panel3.Location = new Point(3, 234);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(855, 28);
      this.panel3.TabIndex = 43;
      this.chkSeleccionarTodos.AutoSize = true;
      this.chkSeleccionarTodos.CheckAlign = ContentAlignment.MiddleRight;
      this.chkSeleccionarTodos.Location = new Point(774, 6);
      this.chkSeleccionarTodos.Name = "chkSeleccionarTodos";
      this.chkSeleccionarTodos.Size = new Size(72, 17);
      this.chkSeleccionarTodos.TabIndex = 18;
      this.chkSeleccionarTodos.Text = " S. Todos";
      this.chkSeleccionarTodos.UseVisualStyleBackColor = true;
      this.chkSeleccionarTodos.CheckedChanged += new EventHandler(this.chkSeleccionarTodos_CheckedChanged);
      this.txtCantidadDocPendiente.BackColor = Color.MistyRose;
      this.txtCantidadDocPendiente.BorderStyle = BorderStyle.FixedSingle;
      this.txtCantidadDocPendiente.Location = new Point(507, 3);
      this.txtCantidadDocPendiente.Name = "txtCantidadDocPendiente";
      this.txtCantidadDocPendiente.ReadOnly = true;
      this.txtCantidadDocPendiente.Size = new Size(55, 20);
      this.txtCantidadDocPendiente.TabIndex = 14;
      this.txtCantidadDocPendiente.TextAlign = HorizontalAlignment.Right;
      this.txtPagoPendiente.BackColor = Color.MistyRose;
      this.txtPagoPendiente.BorderStyle = BorderStyle.FixedSingle;
      this.txtPagoPendiente.Location = new Point(668, 3);
      this.txtPagoPendiente.Name = "txtPagoPendiente";
      this.txtPagoPendiente.ReadOnly = true;
      this.txtPagoPendiente.Size = new Size(99, 20);
      this.txtPagoPendiente.TabIndex = 16;
      this.txtPagoPendiente.TextAlign = HorizontalAlignment.Right;
      this.label40.AutoSize = true;
      this.label40.BackColor = Color.Transparent;
      this.label40.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label40.ForeColor = Color.Black;
      this.label40.Location = new Point(568, 6);
      this.label40.Name = "label40";
      this.label40.Size = new Size(96, 15);
      this.label40.TabIndex = 17;
      this.label40.Text = "Total Pendiente:";
      this.label40.TextAlign = ContentAlignment.MiddleLeft;
      this.label39.AutoSize = true;
      this.label39.BackColor = Color.Transparent;
      this.label39.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label39.ForeColor = Color.Black;
      this.label39.Location = new Point(438, 6);
      this.label39.Name = "label39";
      this.label39.Size = new Size(66, 15);
      this.label39.TabIndex = 15;
      this.label39.Text = "Cant. Doc.:";
      this.label39.TextAlign = ContentAlignment.MiddleLeft;
      this.panelPago.BackColor = Color.FromArgb(223, 233, 245);
      this.panelPago.BorderStyle = BorderStyle.FixedSingle;
      this.panelPago.Controls.Add((Control) this.btnLimpiarPago);
      this.panelPago.Controls.Add((Control) this.btnPagar);
      this.panelPago.Controls.Add((Control) this.panel4);
      this.panelPago.Controls.Add((Control) this.txtMonto);
      this.panelPago.Controls.Add((Control) this.rdbDocumentado);
      this.panelPago.Controls.Add((Control) this.cmbMedioPago);
      this.panelPago.Controls.Add((Control) this.dtpFechaCobro);
      this.panelPago.Controls.Add((Control) this.rdbPagado);
      this.panelPago.Controls.Add((Control) this.label29);
      this.panelPago.Controls.Add((Control) this.label23);
      this.panelPago.Controls.Add((Control) this.label38);
      this.panelPago.Location = new Point(2, 264);
      this.panelPago.Name = "panelPago";
      this.panelPago.Size = new Size(856, 91);
      this.panelPago.TabIndex = 42;
      this.btnLimpiarPago.Location = new Point(742, 60);
      this.btnLimpiarPago.Name = "btnLimpiarPago";
      this.btnLimpiarPago.Size = new Size(107, 23);
      this.btnLimpiarPago.TabIndex = 46;
      this.btnLimpiarPago.Text = "Limpiar";
      this.btnLimpiarPago.UseVisualStyleBackColor = true;
      this.btnLimpiarPago.Click += new EventHandler(this.btnLimpiarPago_Click);
      this.btnPagar.Location = new Point(742, 31);
      this.btnPagar.Name = "btnPagar";
      this.btnPagar.Size = new Size(107, 23);
      this.btnPagar.TabIndex = 45;
      this.btnPagar.Text = "Pagar";
      this.btnPagar.UseVisualStyleBackColor = true;
      this.btnPagar.Click += new EventHandler(this.btnPagar_Click);
      this.panel4.BorderStyle = BorderStyle.Fixed3D;
      this.panel4.Controls.Add((Control) this.label36);
      this.panel4.Controls.Add((Control) this.label37);
      this.panel4.Controls.Add((Control) this.label25);
      this.panel4.Controls.Add((Control) this.txtObservaciones);
      this.panel4.Controls.Add((Control) this.label24);
      this.panel4.Controls.Add((Control) this.cmbBanco);
      this.panel4.Controls.Add((Control) this.txtNumeroDocumento);
      this.panel4.Controls.Add((Control) this.txtCuenta);
      this.panel4.Location = new Point(5, 33);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(731, 51);
      this.panel4.TabIndex = 44;
      this.label36.AutoSize = true;
      this.label36.Location = new Point(158, 6);
      this.label36.Name = "label36";
      this.label36.Size = new Size(41, 13);
      this.label36.TabIndex = 11;
      this.label36.Text = "Cuenta";
      this.label37.AutoSize = true;
      this.label37.Location = new Point(4, 6);
      this.label37.Name = "label37";
      this.label37.Size = new Size(38, 13);
      this.label37.TabIndex = 10;
      this.label37.Text = "Banco";
      this.label25.AutoSize = true;
      this.label25.Location = new Point(270, 6);
      this.label25.Name = "label25";
      this.label25.Size = new Size(77, 13);
      this.label25.TabIndex = 12;
      this.label25.Text = "N° Documento";
      this.txtObservaciones.CharacterCasing = CharacterCasing.Upper;
      this.txtObservaciones.Location = new Point(385, 22);
      this.txtObservaciones.Name = "txtObservaciones";
      this.txtObservaciones.Size = new Size(339, 20);
      this.txtObservaciones.TabIndex = 11;
      this.label24.AutoSize = true;
      this.label24.Location = new Point(383, 6);
      this.label24.Name = "label24";
      this.label24.Size = new Size(78, 13);
      this.label24.TabIndex = 13;
      this.label24.Text = "Observaciones";
      this.cmbBanco.FormattingEnabled = true;
      this.cmbBanco.Location = new Point(4, 22);
      this.cmbBanco.Name = "cmbBanco";
      this.cmbBanco.Size = new Size(148, 21);
      this.cmbBanco.TabIndex = 8;
      this.txtNumeroDocumento.CharacterCasing = CharacterCasing.Upper;
      this.txtNumeroDocumento.Location = new Point(270, 22);
      this.txtNumeroDocumento.Name = "txtNumeroDocumento";
      this.txtNumeroDocumento.Size = new Size(113, 20);
      this.txtNumeroDocumento.TabIndex = 10;
      this.txtCuenta.CharacterCasing = CharacterCasing.Upper;
      this.txtCuenta.Location = new Point(158, 22);
      this.txtCuenta.Name = "txtCuenta";
      this.txtCuenta.Size = new Size(108, 20);
      this.txtCuenta.TabIndex = 9;
      this.txtMonto.Location = new Point(117, 8);
      this.txtMonto.Name = "txtMonto";
      this.txtMonto.Size = new Size(99, 20);
      this.txtMonto.TabIndex = 5;
      this.txtMonto.TextAlign = HorizontalAlignment.Right;
      this.rdbDocumentado.BackColor = Color.Transparent;
      this.rdbDocumentado.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.rdbDocumentado.Location = new Point(754, 8);
      this.rdbDocumentado.Name = "rdbDocumentado";
      this.rdbDocumentado.Size = new Size(93, 17);
      this.rdbDocumentado.TabIndex = 7;
      this.rdbDocumentado.TabStop = true;
      this.rdbDocumentado.Text = "Documentado";
      this.rdbDocumentado.UseVisualStyleBackColor = false;
      this.cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMedioPago.FlatStyle = FlatStyle.Flat;
      this.cmbMedioPago.FormattingEnabled = true;
      this.cmbMedioPago.Location = new Point(508, 8);
      this.cmbMedioPago.Name = "cmbMedioPago";
      this.cmbMedioPago.Size = new Size(162, 21);
      this.cmbMedioPago.TabIndex = 4;
      this.dtpFechaCobro.Format = DateTimePickerFormat.Short;
      this.dtpFechaCobro.Location = new Point(309, 8);
      this.dtpFechaCobro.Name = "dtpFechaCobro";
      this.dtpFechaCobro.Size = new Size(102, 20);
      this.dtpFechaCobro.TabIndex = 3;
      this.rdbPagado.BackColor = Color.Transparent;
      this.rdbPagado.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.rdbPagado.Location = new Point(679, 8);
      this.rdbPagado.Name = "rdbPagado";
      this.rdbPagado.Size = new Size(68, 20);
      this.rdbPagado.TabIndex = 6;
      this.rdbPagado.TabStop = true;
      this.rdbPagado.Text = "Pagado";
      this.rdbPagado.TextAlign = ContentAlignment.TopLeft;
      this.rdbPagado.UseVisualStyleBackColor = false;
      this.label29.AutoSize = true;
      this.label29.BackColor = Color.Transparent;
      this.label29.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label29.ForeColor = Color.Black;
      this.label29.Location = new Point(6, 8);
      this.label29.Name = "label29";
      this.label29.Size = new Size(105, 15);
      this.label29.TabIndex = 6;
      this.label29.Text = "Monto a Pagar:";
      this.label29.TextAlign = ContentAlignment.MiddleLeft;
      this.label23.BackColor = Color.Transparent;
      this.label23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.Black;
      this.label23.Location = new Point(423, 8);
      this.label23.Name = "label23";
      this.label23.Size = new Size(89, 17);
      this.label23.TabIndex = 0;
      this.label23.Text = "Medio de Pago:";
      this.label23.TextAlign = ContentAlignment.MiddleLeft;
      this.label38.BackColor = Color.Transparent;
      this.label38.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label38.ForeColor = Color.Black;
      this.label38.Location = new Point(225, 8);
      this.label38.Name = "label38";
      this.label38.Size = new Size(102, 17);
      this.label38.TabIndex = 8;
      this.label38.Text = "Fecha de Cobro:";
      this.label38.TextAlign = ContentAlignment.MiddleLeft;
      this.dgvPendientes.AllowUserToAddRows = false;
      this.dgvPendientes.AllowUserToDeleteRows = false;
      gridViewCellStyle10.BackColor = Color.Lavender;
      this.dgvPendientes.AlternatingRowsDefaultCellStyle = gridViewCellStyle10;
      this.dgvPendientes.BackgroundColor = Color.LightSteelBlue;
      this.dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle11.BackColor = SystemColors.Window;
      gridViewCellStyle11.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle11.ForeColor = SystemColors.ControlText;
      gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle11.WrapMode = DataGridViewTriState.False;
      this.dgvPendientes.DefaultCellStyle = gridViewCellStyle11;
      this.dgvPendientes.Location = new Point(3, 3);
      this.dgvPendientes.Name = "dgvPendientes";
      this.dgvPendientes.RowHeadersVisible = false;
      this.dgvPendientes.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvPendientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvPendientes.Size = new Size(855, 229);
      this.dgvPendientes.TabIndex = 30;
      this.dgvPendientes.CellContentClick += new DataGridViewCellEventHandler(this.dgvPendientes_CellContentClick);
      this.dgvPendientes.CellValueChanged += new DataGridViewCellEventHandler(this.dgvPendientes_CellValueChanged);
      this.tabPage5.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage5.Controls.Add((Control) this.dgvProductosCliente);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(861, 358);
      this.tabPage5.TabIndex = 2;
      this.tabPage5.Text = "Productos Adquiridos";
      this.dgvProductosCliente.AllowUserToAddRows = false;
      this.dgvProductosCliente.AllowUserToDeleteRows = false;
      gridViewCellStyle12.BackColor = Color.Lavender;
      this.dgvProductosCliente.AlternatingRowsDefaultCellStyle = gridViewCellStyle12;
      this.dgvProductosCliente.BackgroundColor = Color.LightSteelBlue;
      this.dgvProductosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProductosCliente.Columns.AddRange((DataGridViewColumn) this.Fecha, (DataGridViewColumn) this.TipoDocumentoCompra, (DataGridViewColumn) this.Folio, (DataGridViewColumn) this.Codigo, (DataGridViewColumn) this.Descripcion, (DataGridViewColumn) this.Cantidad, (DataGridViewColumn) this.Valor);
      this.dgvProductosCliente.Location = new Point(11, 19);
      this.dgvProductosCliente.Name = "dgvProductosCliente";
      this.dgvProductosCliente.ReadOnly = true;
      this.dgvProductosCliente.RowHeadersVisible = false;
      this.dgvProductosCliente.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvProductosCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductosCliente.Size = new Size(844, 310);
      this.dgvProductosCliente.TabIndex = 0;
      this.Fecha.DataPropertyName = "FechaIngreso";
      gridViewCellStyle13.Format = "d";
      gridViewCellStyle13.NullValue = (object) null;
      this.Fecha.DefaultCellStyle = gridViewCellStyle13;
      this.Fecha.HeaderText = "Fecha";
      this.Fecha.Name = "Fecha";
      this.Fecha.ReadOnly = true;
      this.Fecha.Width = 80;
      this.TipoDocumentoCompra.DataPropertyName = "TipoDocumentoCompra";
      this.TipoDocumentoCompra.HeaderText = "Doc.";
      this.TipoDocumentoCompra.Name = "TipoDocumentoCompra";
      this.TipoDocumentoCompra.ReadOnly = true;
      this.TipoDocumentoCompra.Width = 150;
      this.Folio.DataPropertyName = "FolioFactura";
      gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle14.Format = "N0";
      gridViewCellStyle14.NullValue = (object) "0";
      this.Folio.DefaultCellStyle = gridViewCellStyle14;
      this.Folio.HeaderText = "Folio";
      this.Folio.Name = "Folio";
      this.Folio.ReadOnly = true;
      this.Folio.Width = 60;
      this.Codigo.DataPropertyName = "Codigo";
      this.Codigo.HeaderText = "Codigo";
      this.Codigo.Name = "Codigo";
      this.Codigo.ReadOnly = true;
      this.Descripcion.DataPropertyName = "Descripcion";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      this.Descripcion.Width = 250;
      this.Cantidad.DataPropertyName = "Cantidad";
      gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle15.Format = "N0";
      gridViewCellStyle15.NullValue = (object) "0";
      this.Cantidad.DefaultCellStyle = gridViewCellStyle15;
      this.Cantidad.HeaderText = "Cantidad";
      this.Cantidad.Name = "Cantidad";
      this.Cantidad.ReadOnly = true;
      this.Cantidad.Width = 80;
      this.Valor.DataPropertyName = "ValorVenta";
      gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle16.Format = "N0";
      gridViewCellStyle16.NullValue = (object) "0";
      this.Valor.DefaultCellStyle = gridViewCellStyle16;
      this.Valor.HeaderText = "Valor";
      this.Valor.Name = "Valor";
      this.Valor.ReadOnly = true;
      this.tabPage6.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage6.Controls.Add((Control) this.label15);
      this.tabPage6.Controls.Add((Control) this.btnOt);
      this.tabPage6.Controls.Add((Control) this.dgvOt);
      this.tabPage6.Location = new Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new Padding(3);
      this.tabPage6.Size = new Size(861, 358);
      this.tabPage6.TabIndex = 3;
      this.tabPage6.Text = "Ordenes de Trabajo";
      this.label15.AutoSize = true;
      this.label15.Location = new Point(212, 12);
      this.label15.Name = "label15";
      this.label15.Size = new Size(177, 13);
      this.label15.TabIndex = 41;
      this.label15.Text = "Doble Click sobre la fila para ver OT";
      this.btnOt.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnOt.Location = new Point(11, 6);
      this.btnOt.Name = "btnOt";
      this.btnOt.Size = new Size(169, 23);
      this.btnOt.TabIndex = 40;
      this.btnOt.Text = "Ingresar OT";
      this.btnOt.UseVisualStyleBackColor = true;
      this.btnOt.Click += new EventHandler(this.btnOt_Click);
      this.dgvOt.AllowUserToAddRows = false;
      this.dgvOt.AllowUserToDeleteRows = false;
      gridViewCellStyle17.BackColor = Color.Lavender;
      this.dgvOt.AlternatingRowsDefaultCellStyle = gridViewCellStyle17;
      this.dgvOt.BackgroundColor = Color.LightSteelBlue;
      this.dgvOt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvOt.Location = new Point(11, 35);
      this.dgvOt.Name = "dgvOt";
      this.dgvOt.ReadOnly = true;
      this.dgvOt.RowHeadersVisible = false;
      this.dgvOt.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvOt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvOt.Size = new Size(844, 294);
      this.dgvOt.TabIndex = 39;
      this.dgvOt.CellClick += new DataGridViewCellEventHandler(this.dgvOt_CellClick);
      this.dgvOt.DoubleClick += new EventHandler(this.dgvOt_DoubleClick);
      this.gbZonaCliente.Controls.Add((Control) this.panelAptusoft);
      this.gbZonaCliente.Controls.Add((Control) this.dtpFechaIngreso);
      this.gbZonaCliente.Controls.Add((Control) this.label2);
      this.gbZonaCliente.Controls.Add((Control) this.txtFechaUltimaCompra);
      this.gbZonaCliente.Controls.Add((Control) this.label1);
      this.gbZonaCliente.Controls.Add((Control) this.label16);
      this.gbZonaCliente.Controls.Add((Control) this.txtEmail);
      this.gbZonaCliente.Controls.Add((Control) this.btnBuscaCliente);
      this.gbZonaCliente.Controls.Add((Control) this.label21);
      this.gbZonaCliente.Controls.Add((Control) this.txtDiasPlazo);
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
      this.gbZonaCliente.Location = new Point(6, 6);
      this.gbZonaCliente.Name = "gbZonaCliente";
      this.gbZonaCliente.Size = new Size(1017, 146);
      this.gbZonaCliente.TabIndex = 28;
      this.gbZonaCliente.TabStop = false;
      this.panelAptusoft.Controls.Add((Control) this.label34);
      this.panelAptusoft.Controls.Add((Control) this.label35);
      this.panelAptusoft.Controls.Add((Control) this.txtInicioSoporte);
      this.panelAptusoft.Controls.Add((Control) this.lblDias);
      this.panelAptusoft.Controls.Add((Control) this.txtMesesSoporte);
      this.panelAptusoft.Location = new Point(5, 115);
      this.panelAptusoft.Name = "panelAptusoft";
      this.panelAptusoft.Size = new Size(802, 25);
      this.panelAptusoft.TabIndex = 44;
      this.label34.AutoSize = true;
      this.label34.Location = new Point(3, 7);
      this.label34.Name = "label34";
      this.label34.Size = new Size(72, 13);
      this.label34.TabIndex = 36;
      this.label34.Text = "Inicio Soporte";
      this.label35.AutoSize = true;
      this.label35.Location = new Point(194, 7);
      this.label35.Name = "label35";
      this.label35.Size = new Size(93, 13);
      this.label35.TabIndex = 37;
      this.label35.Text = "Meses de Soporte";
      this.txtInicioSoporte.BackColor = Color.White;
      this.txtInicioSoporte.Location = new Point(95, 3);
      this.txtInicioSoporte.Name = "txtInicioSoporte";
      this.txtInicioSoporte.Size = new Size(92, 20);
      this.txtInicioSoporte.TabIndex = 38;
      this.lblDias.BackColor = Color.Red;
      this.lblDias.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDias.ForeColor = Color.Yellow;
      this.lblDias.Location = new Point(391, 4);
      this.lblDias.Name = "lblDias";
      this.lblDias.Size = new Size(406, 19);
      this.lblDias.TabIndex = 40;
      this.lblDias.Text = "fecha de soporte";
      this.txtMesesSoporte.BackColor = Color.White;
      this.txtMesesSoporte.Location = new Point(289, 3);
      this.txtMesesSoporte.Name = "txtMesesSoporte";
      this.txtMesesSoporte.Size = new Size(46, 20);
      this.txtMesesSoporte.TabIndex = 39;
      this.dtpFechaIngreso.Format = DateTimePickerFormat.Short;
      this.dtpFechaIngreso.Location = new Point(901, 19);
      this.dtpFechaIngreso.Name = "dtpFechaIngreso";
      this.dtpFechaIngreso.Size = new Size(106, 20);
      this.dtpFechaIngreso.TabIndex = 43;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(790, 47);
      this.label2.Name = "label2";
      this.label2.Size = new Size(105, 13);
      this.label2.TabIndex = 42;
      this.label2.Text = "Fecha ultima compra";
      this.txtFechaUltimaCompra.BackColor = Color.White;
      this.txtFechaUltimaCompra.Location = new Point(901, 43);
      this.txtFechaUltimaCompra.Name = "txtFechaUltimaCompra";
      this.txtFechaUltimaCompra.Size = new Size(106, 20);
      this.txtFechaUltimaCompra.TabIndex = 16;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(805, 24);
      this.label1.Name = "label1";
      this.label1.Size = new Size(90, 13);
      this.label1.TabIndex = 41;
      this.label1.Text = "Fecha de Ingreso";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(350, 96);
      this.label16.Name = "label16";
      this.label16.Size = new Size(36, 13);
      this.label16.TabIndex = 34;
      this.label16.Text = "E-Mail";
      this.txtEmail.BackColor = Color.White;
      this.txtEmail.Location = new Point(392, 89);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(235, 20);
      this.txtEmail.TabIndex = 33;
      this.btnBuscaCliente.Location = new Point(682, 17);
      this.btnBuscaCliente.Name = "btnBuscaCliente";
      this.btnBuscaCliente.Size = new Size(106, 23);
      this.btnBuscaCliente.TabIndex = 32;
      this.btnBuscaCliente.Text = "Buscar Cliente";
      this.btnBuscaCliente.UseVisualStyleBackColor = true;
      this.btnBuscaCliente.Click += new EventHandler(this.btnBuscaCliente_Click);
      this.label21.AutoSize = true;
      this.label21.Location = new Point(825, 70);
      this.label21.Name = "label21";
      this.label21.Size = new Size(72, 13);
      this.label21.TabIndex = 20;
      this.label21.Text = "Dias de Plazo";
      this.txtDiasPlazo.BackColor = Color.White;
      this.txtDiasPlazo.Location = new Point(901, 66);
      this.txtDiasPlazo.Name = "txtDiasPlazo";
      this.txtDiasPlazo.Size = new Size(106, 20);
      this.txtDiasPlazo.TabIndex = 19;
      this.txtContacto.BackColor = Color.White;
      this.txtContacto.Location = new Point(60, 89);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(276, 20);
      this.txtContacto.TabIndex = 18;
      this.label12.AutoSize = true;
      this.label12.Location = new Point(4, 93);
      this.label12.Name = "label12";
      this.label12.Size = new Size(50, 13);
      this.label12.TabIndex = 17;
      this.label12.Text = "Contacto";
      this.label12.TextAlign = ContentAlignment.TopRight;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(633, 70);
      this.label11.Name = "label11";
      this.label11.Size = new Size(24, 13);
      this.label11.TabIndex = 16;
      this.label11.Text = "Fax";
      this.label11.TextAlign = ContentAlignment.TopRight;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(447, 70);
      this.label10.Name = "label10";
      this.label10.Size = new Size(31, 13);
      this.label10.TabIndex = 15;
      this.label10.Text = "Fono";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(4, 47);
      this.label9.Name = "label9";
      this.label9.Size = new Size(26, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Giro";
      this.label9.TextAlign = ContentAlignment.TopRight;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(592, 47);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Ciudad";
      this.label8.TextAlign = ContentAlignment.TopRight;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(392, 47);
      this.label7.Name = "label7";
      this.label7.Size = new Size(46, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Comuna";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(4, 70);
      this.label6.Name = "label6";
      this.label6.Size = new Size(52, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Dirección";
      this.label6.TextAlign = ContentAlignment.TopRight;
      this.txtFax.BackColor = Color.White;
      this.txtFax.Location = new Point(664, 66);
      this.txtFax.Name = "txtFax";
      this.txtFax.Size = new Size(125, 20);
      this.txtFax.TabIndex = 10;
      this.txtFono.BackColor = Color.White;
      this.txtFono.Location = new Point(484, 66);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(143, 20);
      this.txtFono.TabIndex = 9;
      this.txtGiro.BackColor = Color.White;
      this.txtGiro.Location = new Point(60, 66);
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new Size(381, 20);
      this.txtGiro.TabIndex = 8;
      this.txtCiudad.BackColor = Color.White;
      this.txtCiudad.Location = new Point(636, 43);
      this.txtCiudad.Name = "txtCiudad";
      this.txtCiudad.Size = new Size(153, 20);
      this.txtCiudad.TabIndex = 7;
      this.txtComuna.BackColor = Color.White;
      this.txtComuna.Location = new Point(444, 43);
      this.txtComuna.Name = "txtComuna";
      this.txtComuna.Size = new Size(143, 20);
      this.txtComuna.TabIndex = 6;
      this.txtDireccion.BackColor = Color.White;
      this.txtDireccion.Location = new Point(60, 43);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new Size(326, 20);
      this.txtDireccion.TabIndex = 5;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(181, 23);
      this.label5.Name = "label5";
      this.label5.Size = new Size(70, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Razon Social";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(4, 23);
      this.label4.Name = "label4";
      this.label4.Size = new Size(30, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "RUT";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.txtRazonSocial.Location = new Point(257, 19);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(420, 20);
      this.txtRazonSocial.TabIndex = 8;
      this.txtRazonSocial.TextChanged += new EventHandler(this.txtRazonSocial_TextChanged);
      this.txtRazonSocial.KeyDown += new KeyEventHandler(this.txtRazonSocial_KeyDown);
      this.txtDigito.Location = new Point(132, 19);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 7;
      this.txtDigito.KeyPress += new KeyPressEventHandler(this.txtDigito_KeyPress);
      this.txtRut.Location = new Point(60, 19);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(68, 20);
      this.txtRut.TabIndex = 6;
      this.txtRut.KeyPress += new KeyPressEventHandler(this.txtRut_KeyPress);
      this.tabPage2.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage2.Controls.Add((Control) this.groupBox1);
      this.tabPage2.Controls.Add((Control) this.btnBuscaListadoPagos);
      this.tabPage2.Controls.Add((Control) this.dgvListadoPagos);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(1026, 545);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Listado de Pagos";
      this.groupBox1.Controls.Add((Control) this.cmbEstadoPagoListado);
      this.groupBox1.Controls.Add((Control) this.label17);
      this.groupBox1.Controls.Add((Control) this.btnBuscaClienteListadoPago);
      this.groupBox1.Controls.Add((Control) this.label20);
      this.groupBox1.Controls.Add((Control) this.txtClienteListadoPago);
      this.groupBox1.Controls.Add((Control) this.dtpHasta);
      this.groupBox1.Controls.Add((Control) this.label19);
      this.groupBox1.Controls.Add((Control) this.label22);
      this.groupBox1.Controls.Add((Control) this.dtpDesde);
      this.groupBox1.Location = new Point(6, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(933, 71);
      this.groupBox1.TabIndex = 41;
      this.groupBox1.TabStop = false;
      this.cmbEstadoPagoListado.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEstadoPagoListado.FormattingEnabled = true;
      this.cmbEstadoPagoListado.Location = new Point(6, 37);
      this.cmbEstadoPagoListado.Name = "cmbEstadoPagoListado";
      this.cmbEstadoPagoListado.Size = new Size(141, 21);
      this.cmbEstadoPagoListado.TabIndex = 32;
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.Location = new Point(6, 20);
      this.label17.Name = "label17";
      this.label17.Size = new Size(94, 15);
      this.label17.TabIndex = 31;
      this.label17.Text = "Estado de Pago";
      this.btnBuscaClienteListadoPago.Location = new Point(840, 34);
      this.btnBuscaClienteListadoPago.Name = "btnBuscaClienteListadoPago";
      this.btnBuscaClienteListadoPago.Size = new Size(87, 23);
      this.btnBuscaClienteListadoPago.TabIndex = 34;
      this.btnBuscaClienteListadoPago.Text = "Buscar Cliente";
      this.btnBuscaClienteListadoPago.UseVisualStyleBackColor = true;
      this.btnBuscaClienteListadoPago.Click += new EventHandler(this.btnBuscaClienteListadoPago_Click);
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.Location = new Point(158, 20);
      this.label20.Name = "label20";
      this.label20.Size = new Size(43, 15);
      this.label20.TabIndex = 36;
      this.label20.Text = "Desde";
      this.txtClienteListadoPago.Enabled = false;
      this.txtClienteListadoPago.Location = new Point(369, 37);
      this.txtClienteListadoPago.Name = "txtClienteListadoPago";
      this.txtClienteListadoPago.Size = new Size(465, 20);
      this.txtClienteListadoPago.TabIndex = 33;
      this.dtpHasta.Format = DateTimePickerFormat.Short;
      this.dtpHasta.Location = new Point(265, 37);
      this.dtpHasta.Name = "dtpHasta";
      this.dtpHasta.Size = new Size(98, 20);
      this.dtpHasta.TabIndex = 39;
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.Location = new Point(369, 20);
      this.label19.Name = "label19";
      this.label19.Size = new Size(45, 15);
      this.label19.TabIndex = 35;
      this.label19.Text = "Cliente";
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.Location = new Point(266, 20);
      this.label22.Name = "label22";
      this.label22.Size = new Size(39, 15);
      this.label22.TabIndex = 37;
      this.label22.Text = "Hasta";
      this.dtpDesde.Format = DateTimePickerFormat.Short;
      this.dtpDesde.Location = new Point(161, 37);
      this.dtpDesde.Name = "dtpDesde";
      this.dtpDesde.Size = new Size(98, 20);
      this.dtpDesde.TabIndex = 38;
      this.btnBuscaListadoPagos.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaListadoPagos.Image = (Image) Resources.de_busqueda_de_archivos_encontrar_vista_del_documento_icono_8728_48;
      this.btnBuscaListadoPagos.ImageAlign = ContentAlignment.TopCenter;
      this.btnBuscaListadoPagos.Location = new Point(945, 6);
      this.btnBuscaListadoPagos.Name = "btnBuscaListadoPagos";
      this.btnBuscaListadoPagos.Size = new Size(75, 75);
      this.btnBuscaListadoPagos.TabIndex = 40;
      this.btnBuscaListadoPagos.Text = "Buscar";
      this.btnBuscaListadoPagos.TextAlign = ContentAlignment.BottomCenter;
      this.btnBuscaListadoPagos.UseVisualStyleBackColor = true;
      this.btnBuscaListadoPagos.Click += new EventHandler(this.btnBuscaListadoPagos_Click);
      this.dgvListadoPagos.AllowUserToAddRows = false;
      this.dgvListadoPagos.AllowUserToDeleteRows = false;
      gridViewCellStyle18.BackColor = Color.Lavender;
      this.dgvListadoPagos.AlternatingRowsDefaultCellStyle = gridViewCellStyle18;
      this.dgvListadoPagos.BackgroundColor = Color.LightSteelBlue;
      this.dgvListadoPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvListadoPagos.Location = new Point(6, 83);
      this.dgvListadoPagos.Name = "dgvListadoPagos";
      this.dgvListadoPagos.ReadOnly = true;
      this.dgvListadoPagos.RowHeadersVisible = false;
      this.dgvListadoPagos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvListadoPagos.Size = new Size(1014, 456);
      this.dgvListadoPagos.TabIndex = 30;
      this.dgvListadoPagos.DoubleClick += new EventHandler(this.dgvListadoPagos_DoubleClick);
      this.tabPage7.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage7.Controls.Add((Control) this.lblAlertaFacturando);
      this.tabPage7.Controls.Add((Control) this.btnFacturar);
      this.tabPage7.Controls.Add((Control) this.chkMarcarTodos);
      this.tabPage7.Controls.Add((Control) this.dtpFechaFacturacion);
      this.tabPage7.Controls.Add((Control) this.rdbCiclo15);
      this.tabPage7.Controls.Add((Control) this.rdbCiclo1y2);
      this.tabPage7.Controls.Add((Control) this.btnBuscarContratosAFacturar);
      this.tabPage7.Controls.Add((Control) this.dgvFacturacionCiclo);
      this.tabPage7.Location = new Point(4, 22);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Padding = new Padding(3);
      this.tabPage7.Size = new Size(1026, 545);
      this.tabPage7.TabIndex = 2;
      this.tabPage7.Text = "Facturacion por Ciclo";
      this.lblAlertaFacturando.AutoSize = true;
      this.lblAlertaFacturando.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblAlertaFacturando.ForeColor = Color.Red;
      this.lblAlertaFacturando.Location = new Point(161, 508);
      this.lblAlertaFacturando.Name = "lblAlertaFacturando";
      this.lblAlertaFacturando.Size = new Size(518, 25);
      this.lblAlertaFacturando.TabIndex = 7;
      this.lblAlertaFacturando.Text = "PROCESO DE FACTURACION EJECUTANDOSE";
      this.btnFacturar.Location = new Point(6, 505);
      this.btnFacturar.Name = "btnFacturar";
      this.btnFacturar.Size = new Size(143, 31);
      this.btnFacturar.TabIndex = 6;
      this.btnFacturar.Text = "Facturar Seleccionadas";
      this.btnFacturar.UseVisualStyleBackColor = true;
      this.btnFacturar.Click += new EventHandler(this.btnFacturar_Click);
      this.chkMarcarTodos.AutoSize = true;
      this.chkMarcarTodos.CheckAlign = ContentAlignment.MiddleRight;
      this.chkMarcarTodos.Location = new Point(782, 13);
      this.chkMarcarTodos.Name = "chkMarcarTodos";
      this.chkMarcarTodos.Size = new Size(92, 17);
      this.chkMarcarTodos.TabIndex = 5;
      this.chkMarcarTodos.Text = "Marcar Todos";
      this.chkMarcarTodos.UseVisualStyleBackColor = true;
      this.chkMarcarTodos.CheckedChanged += new EventHandler(this.chkMarcarTodos_CheckedChanged);
      this.dtpFechaFacturacion.Format = DateTimePickerFormat.Short;
      this.dtpFechaFacturacion.Location = new Point(166, 8);
      this.dtpFechaFacturacion.Name = "dtpFechaFacturacion";
      this.dtpFechaFacturacion.Size = new Size(101, 20);
      this.dtpFechaFacturacion.TabIndex = 4;
      this.rdbCiclo15.AutoSize = true;
      this.rdbCiclo15.Location = new Point(86, 10);
      this.rdbCiclo15.Name = "rdbCiclo15";
      this.rdbCiclo15.Size = new Size(63, 17);
      this.rdbCiclo15.TabIndex = 3;
      this.rdbCiclo15.TabStop = true;
      this.rdbCiclo15.Text = "Ciclo 15";
      this.rdbCiclo15.UseVisualStyleBackColor = true;
      this.rdbCiclo1y2.AutoSize = true;
      this.rdbCiclo1y2.Location = new Point(6, 10);
      this.rdbCiclo1y2.Name = "rdbCiclo1y2";
      this.rdbCiclo1y2.Size = new Size(74, 17);
      this.rdbCiclo1y2.TabIndex = 2;
      this.rdbCiclo1y2.TabStop = true;
      this.rdbCiclo1y2.Text = "Ciclo 1 y 2";
      this.rdbCiclo1y2.UseVisualStyleBackColor = true;
      this.btnBuscarContratosAFacturar.Location = new Point(281, 7);
      this.btnBuscarContratosAFacturar.Name = "btnBuscarContratosAFacturar";
      this.btnBuscarContratosAFacturar.Size = new Size(207, 23);
      this.btnBuscarContratosAFacturar.TabIndex = 1;
      this.btnBuscarContratosAFacturar.Text = "Pendientes de Facturar";
      this.btnBuscarContratosAFacturar.UseVisualStyleBackColor = true;
      this.btnBuscarContratosAFacturar.Click += new EventHandler(this.btnBuscarContratosAFacturar_Click);
      this.dgvFacturacionCiclo.AllowUserToAddRows = false;
      this.dgvFacturacionCiclo.AllowUserToDeleteRows = false;
      this.dgvFacturacionCiclo.AllowUserToResizeColumns = false;
      this.dgvFacturacionCiclo.AllowUserToResizeRows = false;
      gridViewCellStyle19.BackColor = Color.Lavender;
      this.dgvFacturacionCiclo.AlternatingRowsDefaultCellStyle = gridViewCellStyle19;
      this.dgvFacturacionCiclo.BackgroundColor = Color.LightSteelBlue;
      this.dgvFacturacionCiclo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFacturacionCiclo.Columns.AddRange((DataGridViewColumn) this.IdContrato, (DataGridViewColumn) this.IdClienteFacturacion, (DataGridViewColumn) this.Rut, (DataGridViewColumn) this.Digito, (DataGridViewColumn) this.RazonSocial, (DataGridViewColumn) this.Email, (DataGridViewColumn) this.DescripcionFacturacion, (DataGridViewColumn) this.SubTotal, (DataGridViewColumn) this.CodigoCiclo, (DataGridViewColumn) this.CodigoOferta, (DataGridViewColumn) this.DescripcionOferta, (DataGridViewColumn) this.MesesOferta, (DataGridViewColumn) this.MesesOfertaOcupado, (DataGridViewColumn) this.MesesOfertaRestante, (DataGridViewColumn) this.DescuentoOferta, (DataGridViewColumn) this.Descuento, (DataGridViewColumn) this.Total, (DataGridViewColumn) this.Facturar, (DataGridViewColumn) this.SegundaFacturacion);
      this.dgvFacturacionCiclo.Location = new Point(6, 35);
      this.dgvFacturacionCiclo.Name = "dgvFacturacionCiclo";
      this.dgvFacturacionCiclo.RowHeadersVisible = false;
      this.dgvFacturacionCiclo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvFacturacionCiclo.Size = new Size(1010, 464);
      this.dgvFacturacionCiclo.TabIndex = 0;
      this.IdContrato.DataPropertyName = "IdContrato";
      this.IdContrato.HeaderText = "IdContrato";
      this.IdContrato.Name = "IdContrato";
      this.IdContrato.Visible = false;
      this.IdClienteFacturacion.DataPropertyName = "IdCliente";
      this.IdClienteFacturacion.HeaderText = "IdCliente";
      this.IdClienteFacturacion.Name = "IdClienteFacturacion";
      this.IdClienteFacturacion.Visible = false;
      this.Rut.DataPropertyName = "Rut";
      gridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.Rut.DefaultCellStyle = gridViewCellStyle20;
      this.Rut.HeaderText = "Rut";
      this.Rut.Name = "Rut";
      this.Rut.ReadOnly = true;
      this.Rut.Width = 60;
      this.Digito.DataPropertyName = "Digito";
      this.Digito.HeaderText = "";
      this.Digito.Name = "Digito";
      this.Digito.ReadOnly = true;
      this.Digito.Width = 20;
      this.RazonSocial.DataPropertyName = "RazonSocial";
      this.RazonSocial.HeaderText = "RazonSocial";
      this.RazonSocial.Name = "RazonSocial";
      this.RazonSocial.ReadOnly = true;
      this.RazonSocial.Width = 240;
      this.Email.DataPropertyName = "Email";
      this.Email.HeaderText = "Email";
      this.Email.Name = "Email";
      this.DescripcionFacturacion.DataPropertyName = "Descripcion";
      this.DescripcionFacturacion.HeaderText = "Descripcion";
      this.DescripcionFacturacion.Name = "DescripcionFacturacion";
      this.DescripcionFacturacion.ReadOnly = true;
      this.DescripcionFacturacion.Width = 140;
      this.SubTotal.DataPropertyName = "SubTotal";
      gridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle21.Format = "N0";
      gridViewCellStyle21.NullValue = (object) "0";
      this.SubTotal.DefaultCellStyle = gridViewCellStyle21;
      this.SubTotal.HeaderText = "SubTotal";
      this.SubTotal.Name = "SubTotal";
      this.SubTotal.ReadOnly = true;
      this.SubTotal.Width = 80;
      this.CodigoCiclo.DataPropertyName = "CodigoCiclo";
      gridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.CodigoCiclo.DefaultCellStyle = gridViewCellStyle22;
      this.CodigoCiclo.HeaderText = "Ciclo";
      this.CodigoCiclo.Name = "CodigoCiclo";
      this.CodigoCiclo.Visible = false;
      this.CodigoCiclo.Width = 60;
      this.CodigoOferta.DataPropertyName = "CodigoOferta";
      this.CodigoOferta.HeaderText = "CodigoOferta";
      this.CodigoOferta.Name = "CodigoOferta";
      this.CodigoOferta.Visible = false;
      this.DescripcionOferta.DataPropertyName = "DescripcionOferta";
      this.DescripcionOferta.HeaderText = "DescripcionOferta";
      this.DescripcionOferta.Name = "DescripcionOferta";
      this.DescripcionOferta.Visible = false;
      this.MesesOferta.DataPropertyName = "MesesOferta";
      gridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.MesesOferta.DefaultCellStyle = gridViewCellStyle23;
      this.MesesOferta.HeaderText = "MesesOferta";
      this.MesesOferta.Name = "MesesOferta";
      this.MesesOferta.ToolTipText = "Meses de Oferta";
      this.MesesOferta.Visible = false;
      this.MesesOferta.Width = 80;
      this.MesesOfertaOcupado.DataPropertyName = "MesesOfertaOcupado";
      this.MesesOfertaOcupado.HeaderText = "MesesOfertaOcupado";
      this.MesesOfertaOcupado.Name = "MesesOfertaOcupado";
      this.MesesOfertaOcupado.Visible = false;
      this.MesesOfertaRestante.DataPropertyName = "MesesOfertaRestante";
      gridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle24.NullValue = (object) "0";
      this.MesesOfertaRestante.DefaultCellStyle = gridViewCellStyle24;
      this.MesesOfertaRestante.HeaderText = "M. Of.";
      this.MesesOfertaRestante.Name = "MesesOfertaRestante";
      this.MesesOfertaRestante.ReadOnly = true;
      this.MesesOfertaRestante.ToolTipText = "Meses de Oferta Restante";
      this.MesesOfertaRestante.Width = 60;
      this.DescuentoOferta.DataPropertyName = "DescuentoOferta";
      gridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle25.Format = "N0";
      gridViewCellStyle25.NullValue = (object) "0";
      this.DescuentoOferta.DefaultCellStyle = gridViewCellStyle25;
      this.DescuentoOferta.HeaderText = "% Desc.";
      this.DescuentoOferta.Name = "DescuentoOferta";
      this.DescuentoOferta.ReadOnly = true;
      this.DescuentoOferta.ToolTipText = "Descuento de Oferta";
      this.DescuentoOferta.Width = 70;
      this.Descuento.DataPropertyName = "Descuento";
      gridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle26.Format = "N0";
      gridViewCellStyle26.NullValue = (object) "0";
      this.Descuento.DefaultCellStyle = gridViewCellStyle26;
      this.Descuento.HeaderText = "$ Desc.";
      this.Descuento.Name = "Descuento";
      this.Descuento.ReadOnly = true;
      this.Descuento.Width = 80;
      this.Total.DataPropertyName = "Total";
      gridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle27.Format = "N0";
      gridViewCellStyle27.NullValue = (object) "0";
      this.Total.DefaultCellStyle = gridViewCellStyle27;
      this.Total.HeaderText = "Total Neto";
      this.Total.Name = "Total";
      this.Total.ReadOnly = true;
      this.Total.Width = 80;
      this.Facturar.DataPropertyName = "Facturar";
      this.Facturar.HeaderText = "Facturar";
      this.Facturar.Name = "Facturar";
      this.Facturar.Width = 60;
      this.SegundaFacturacion.DataPropertyName = "SegundaFacturacion";
      gridViewCellStyle28.Format = "d";
      gridViewCellStyle28.NullValue = (object) null;
      this.SegundaFacturacion.DefaultCellStyle = gridViewCellStyle28;
      this.SegundaFacturacion.HeaderText = "SegundaFacturacion";
      this.SegundaFacturacion.Name = "SegundaFacturacion";
      this.panelColorDeuda.Location = new Point(1042, 27);
      this.panelColorDeuda.Name = "panelColorDeuda";
      this.panelColorDeuda.Size = new Size(96, 142);
      this.panelColorDeuda.TabIndex = 39;
      this.btnLimpiar.Image = (Image) Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
      this.btnLimpiar.ImageAlign = ContentAlignment.TopCenter;
      this.btnLimpiar.Location = new Point(1040, 416);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 75);
      this.btnLimpiar.TabIndex = 37;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Image = (Image) Resources.salir_de_mi_perfil_icono_3964_48;
      this.btnSalir.ImageAlign = ContentAlignment.TopCenter;
      this.btnSalir.Location = new Point(1040, 497);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 75);
      this.btnSalir.TabIndex = 39;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextAlign = ContentAlignment.BottomCenter;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1215, 584);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.panelColorDeuda);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.tabControl1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.Name = "frmModuloFacturacionAptusoft";
      this.ShowIcon = false;
      this.Text = "Modulo de Facturación";
      this.WindowState = FormWindowState.Maximized;
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.pnlBuscaClienteDes.ResumeLayout(false);
      ((ISupportInitialize) this.dgvBuscaCliente).EndInit();
      this.panel2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.tabControl2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      ((ISupportInitialize) this.dgvDatosVenta).EndInit();
      ((ISupportInitialize) this.dgvNotaCredito).EndInit();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      ((ISupportInitialize) this.dgvPagosClientes).EndInit();
      this.tabPage8.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panelPago.ResumeLayout(false);
      this.panelPago.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      ((ISupportInitialize) this.dgvPendientes).EndInit();
      this.tabPage5.ResumeLayout(false);
      ((ISupportInitialize) this.dgvProductosCliente).EndInit();
      this.tabPage6.ResumeLayout(false);
      this.tabPage6.PerformLayout();
      ((ISupportInitialize) this.dgvOt).EndInit();
      this.gbZonaCliente.ResumeLayout(false);
      this.gbZonaCliente.PerformLayout();
      this.panelAptusoft.ResumeLayout(false);
      this.panelAptusoft.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.dgvListadoPagos).EndInit();
      this.tabPage7.ResumeLayout(false);
      this.tabPage7.PerformLayout();
      ((ISupportInitialize) this.dgvFacturacionCiclo).EndInit();
      this.ResumeLayout(false);
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) new MedioPago().listaMediosPago();
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void cargaBancos()
    {
      this.cmbBanco.DataSource = (object) new CargaMaestros().listaBancos();
      this.cmbBanco.ValueMember = "idBanco";
      this.cmbBanco.DisplayMember = "nombreBanco";
      this.cmbBanco.SelectedValue = (object) 0;
    }

    private void iniciaFormulario()
    {
      this.idCliente = 0;
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
      this.txtContacto.Enabled = false;
      this.txtDiasPlazo.Clear();
      this.txtDiasPlazo.Enabled = false;
      this.txtEmail.Clear();
      this.txtEmail.Enabled = false;
      this.dtpFechaIngreso.Enabled = false;
      this.dtpFechaIngreso.Value = DateTime.Now;
      this.txtFechaUltimaCompra.Clear();
      this.txtFechaUltimaCompra.Enabled = false;
      this.lblDias.Text = "";
      this.txtInicioSoporte.Clear();
      this.txtInicioSoporte.Enabled = false;
      this.txtMesesSoporte.Clear();
      this.txtMesesSoporte.Enabled = false;
      this.dgvBuscaCliente.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvPendientes.DataSource = (object) null;
      this.dgvNotaCredito.DataSource = (object) null;
      this.dgvProductosCliente.DataSource = (object) null;
      this.dgvPagosClientes.DataSource = (object) null;
      this.dgvOt.DataSource = (object) null;
      this.dgvListadoPagos.DataSource = (object) null;
      this.pnlBuscaClienteDes.Visible = false;
      this.txtTotalPagado.Clear();
      this.txtTotalPendiente.Clear();
      this.txtTotalDocumentado.Clear();
      this.txtTotalUsado.Clear();
      this.txtTotalDisponible.Clear();
      this.txtDeuda.Clear();
      this.cmbEstadoPagoListado.SelectedValue = (object) 0;
      this.panelColorDeuda.BackColor = Color.Transparent;
      this.rdbCiclo1y2.Checked = true;
      this.rdbCiclo15.Checked = false;
      this.chkMarcarTodos.Checked = false;
      this.dgvFacturacionCiclo.DataSource = (object) null;
      this.dtpFechaFacturacion.Value = DateTime.Now;
      this._listaContratos.Clear();
      this.lblAlertaFacturando.Visible = false;
      this.btnFacturar.Enabled = true;
      this.txtClienteListadoPago.Clear();
      this.txtRut.Focus();
      this.panelPago.Enabled = false;
      this.iniciaPago();
      this.txtCantidadDocPendiente.Clear();
      this.txtPagoPendiente.Clear();
    }

    private void iniciaPago()
    {
      this.cargaMediosPago();
      this.cargaBancos();
      this.txtMonto.Clear();
      this.dtpFechaCobro.Value = DateTime.Now;
      this.rdbPagado.Checked = true;
      this.rdbDocumentado.Checked = false;
      this.txtCuenta.Clear();
      this.txtNumeroDocumento.Clear();
      this.txtObservaciones.Clear();
      this.txtCantidadDocPendiente.Clear();
      this.txtPagoPendiente.Clear();
      this.chkSeleccionarTodos.Checked = false;
    }

    private void cargaEstadoPago()
    {
      this.cmbEstadoPagoListado.DataSource = (object) new CargaMaestros().cargaEstadosPago();
      this.cmbEstadoPagoListado.ValueMember = "codigo";
      this.cmbEstadoPagoListado.DisplayMember = "descripcion";
      this.cmbEstadoPagoListado.SelectedValue = (object) 0;
    }

    private void creaColumnasDetalle()
    {
      this.dgvDatosVenta.AutoGenerateColumns = false;
      this.dgvDatosVenta.Columns.Add("Linea", "");
      this.dgvDatosVenta.Columns[0].DataPropertyName = "Linea";
      this.dgvDatosVenta.Columns[0].Width = 20;
      this.dgvDatosVenta.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Emision", "Emision");
      this.dgvDatosVenta.Columns[1].DataPropertyName = "FechaEmision";
      this.dgvDatosVenta.Columns[1].Width = 75;
      this.dgvDatosVenta.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[1].DefaultCellStyle.Format = "d";
      this.dgvDatosVenta.Columns.Add("DocumentoVenta", "Documento");
      this.dgvDatosVenta.Columns[2].DataPropertyName = "DocumentoVenta";
      this.dgvDatosVenta.Columns[2].Width = 120;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Folio", "Folio");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "Folio";
      this.dgvDatosVenta.Columns[3].Width = 65;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("EstadoPago", "Estado");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "EstadoPago";
      this.dgvDatosVenta.Columns[4].Width = 90;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Total", "Total");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "Total";
      this.dgvDatosVenta.Columns[5].Width = 90;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("TotalPagado", "Pagado");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "TotalPagado";
      this.dgvDatosVenta.Columns[6].Width = 80;
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("TotalDocumentado", "Documentado");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "TotalDocumentado";
      this.dgvDatosVenta.Columns[7].Width = 90;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("TotalPendiente", "Pendiente");
      this.dgvDatosVenta.Columns[8].DataPropertyName = "TotalPendiente";
      this.dgvDatosVenta.Columns[8].Width = 80;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[8].Resizable = DataGridViewTriState.False;
      DataGridViewButtonColumn viewButtonColumn1 = new DataGridViewButtonColumn();
      viewButtonColumn1.Name = "VerFactura";
      viewButtonColumn1.HeaderText = "Ver";
      viewButtonColumn1.UseColumnTextForButtonValue = true;
      viewButtonColumn1.Text = "Ver";
      viewButtonColumn1.Width = 55;
      viewButtonColumn1.DisplayIndex = 9;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn1);
      DataGridViewButtonColumn viewButtonColumn2 = new DataGridViewButtonColumn();
      viewButtonColumn2.Name = "Pagar";
      viewButtonColumn2.HeaderText = "Pagar";
      viewButtonColumn2.UseColumnTextForButtonValue = true;
      viewButtonColumn2.Text = "Pagar";
      viewButtonColumn2.Width = 55;
      viewButtonColumn2.DisplayIndex = 10;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn2);
    }

    private void creaColumnasDetallePendientes()
    {
      this.dgvPendientes.AutoGenerateColumns = false;
      this.dgvPendientes.Columns.Add("Linea", "");
      this.dgvPendientes.Columns[0].DataPropertyName = "Linea";
      this.dgvPendientes.Columns[0].Width = 20;
      this.dgvPendientes.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[0].ReadOnly = true;
      this.dgvPendientes.Columns.Add("Emision", "Emision");
      this.dgvPendientes.Columns[1].DataPropertyName = "FechaEmision";
      this.dgvPendientes.Columns[1].Width = 75;
      this.dgvPendientes.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[1].DefaultCellStyle.Format = "d";
      this.dgvPendientes.Columns[1].ReadOnly = true;
      this.dgvPendientes.Columns.Add("DocumentoVenta", "Documento");
      this.dgvPendientes.Columns[2].DataPropertyName = "DocumentoVenta";
      this.dgvPendientes.Columns[2].Width = 190;
      this.dgvPendientes.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[2].ReadOnly = true;
      this.dgvPendientes.Columns.Add("Folio", "Folio");
      this.dgvPendientes.Columns[3].DataPropertyName = "Folio";
      this.dgvPendientes.Columns[3].Width = 65;
      this.dgvPendientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvPendientes.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[3].ReadOnly = true;
      this.dgvPendientes.Columns.Add("EstadoPago", "Estado");
      this.dgvPendientes.Columns[4].DataPropertyName = "EstadoPago";
      this.dgvPendientes.Columns[4].Width = 90;
      this.dgvPendientes.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[4].Visible = true;
      this.dgvPendientes.Columns[4].ReadOnly = true;
      this.dgvPendientes.Columns.Add("Total", "Total");
      this.dgvPendientes.Columns[5].DataPropertyName = "Total";
      this.dgvPendientes.Columns[5].Width = 90;
      this.dgvPendientes.Columns[5].DefaultCellStyle.Format = "N0";
      this.dgvPendientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvPendientes.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[5].ReadOnly = true;
      this.dgvPendientes.Columns.Add("TotalPagado", "Pagado");
      this.dgvPendientes.Columns[6].DataPropertyName = "TotalPagado";
      this.dgvPendientes.Columns[6].Width = 80;
      this.dgvPendientes.Columns[6].DefaultCellStyle.Format = "N0";
      this.dgvPendientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvPendientes.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[6].ReadOnly = true;
      this.dgvPendientes.Columns.Add("TotalDocumentado", "Documentado");
      this.dgvPendientes.Columns[7].DataPropertyName = "TotalDocumentado";
      this.dgvPendientes.Columns[7].Width = 90;
      this.dgvPendientes.Columns[7].DefaultCellStyle.Format = "N0";
      this.dgvPendientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvPendientes.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[7].ReadOnly = true;
      this.dgvPendientes.Columns.Add("TotalPendiente", "Pendiente");
      this.dgvPendientes.Columns[8].DataPropertyName = "TotalPendiente";
      this.dgvPendientes.Columns[8].Width = 80;
      this.dgvPendientes.Columns[8].DefaultCellStyle.Format = "N0";
      this.dgvPendientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvPendientes.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[8].ReadOnly = true;
      DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn.Name = "Pagar";
      viewCheckBoxColumn.HeaderText = "Pagar";
      viewCheckBoxColumn.Width = 55;
      viewCheckBoxColumn.DisplayIndex = 9;
      this.dgvPendientes.Columns.Add((DataGridViewColumn) viewCheckBoxColumn);
      this.dgvPendientes.Columns.Add("IdFactura", "IdFactura");
      this.dgvPendientes.Columns[10].DataPropertyName = "IdFactura";
      this.dgvPendientes.Columns[10].Width = 80;
      this.dgvPendientes.Columns[10].DefaultCellStyle.Format = "N0";
      this.dgvPendientes.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvPendientes.Columns[10].Resizable = DataGridViewTriState.False;
      this.dgvPendientes.Columns[10].ReadOnly = true;
      this.dgvPendientes.Columns[10].Visible = false;
    }

    private void creaColumnasBuscaClientes()
    {
      this.dgvBuscaCliente.AutoGenerateColumns = false;
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

    private void creaColumnasDetalleNC()
    {
      this.dgvNotaCredito.AutoGenerateColumns = false;
      this.dgvNotaCredito.Columns.Add("Linea", "");
      this.dgvNotaCredito.Columns[0].DataPropertyName = "Linea";
      this.dgvNotaCredito.Columns[0].Width = 20;
      this.dgvNotaCredito.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns.Add("Emision", "Emision");
      this.dgvNotaCredito.Columns[1].DataPropertyName = "FechaEmision";
      this.dgvNotaCredito.Columns[1].Width = 80;
      this.dgvNotaCredito.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns.Add("DocumentoVenta", "Documento");
      this.dgvNotaCredito.Columns[2].DataPropertyName = "DocumentoVenta";
      this.dgvNotaCredito.Columns[2].Width = 200;
      this.dgvNotaCredito.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns[2].Visible = true;
      this.dgvNotaCredito.Columns.Add("Folio", "Folio");
      this.dgvNotaCredito.Columns[3].DataPropertyName = "Folio";
      this.dgvNotaCredito.Columns[3].Width = 70;
      this.dgvNotaCredito.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNotaCredito.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns.Add("Total", "Total");
      this.dgvNotaCredito.Columns[4].DataPropertyName = "Total";
      this.dgvNotaCredito.Columns[4].Width = 100;
      this.dgvNotaCredito.Columns[4].DefaultCellStyle.Format = "N0";
      this.dgvNotaCredito.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNotaCredito.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns.Add("MontoUsado", "Monto Usado");
      this.dgvNotaCredito.Columns[5].DataPropertyName = "MontoUsado";
      this.dgvNotaCredito.Columns[5].Width = 100;
      this.dgvNotaCredito.Columns[5].DefaultCellStyle.Format = "N0";
      this.dgvNotaCredito.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNotaCredito.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns.Add("MontoDisponible", "Disponible");
      this.dgvNotaCredito.Columns[6].DataPropertyName = "MontoDisponible";
      this.dgvNotaCredito.Columns[6].Width = 100;
      this.dgvNotaCredito.Columns[6].DefaultCellStyle.Format = "N0";
      this.dgvNotaCredito.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNotaCredito.Columns[6].Resizable = DataGridViewTriState.False;
    }

    private void creaColumnasOt()
    {
      this.dgvOt.AutoGenerateColumns = false;
      this.dgvOt.Columns.Add("Linea", "");
      this.dgvOt.Columns[0].DataPropertyName = "Linea";
      this.dgvOt.Columns[0].Width = 25;
      this.dgvOt.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns[0].DefaultCellStyle.BackColor = Color.Gainsboro;
      this.dgvOt.Columns.Add("FechaIngreso", "Fecha Solicitud");
      this.dgvOt.Columns[1].DataPropertyName = "FechaIngreso";
      this.dgvOt.Columns[1].Width = 110;
      this.dgvOt.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("Requerimiento", "Requerimiento");
      this.dgvOt.Columns[2].DataPropertyName = "Requerimiento";
      this.dgvOt.Columns[2].Width = 325;
      this.dgvOt.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("Tecnico", "Tecnico");
      this.dgvOt.Columns[3].DataPropertyName = "Tecnico";
      this.dgvOt.Columns[3].Width = 100;
      this.dgvOt.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("Estado", "Estado");
      this.dgvOt.Columns[4].DataPropertyName = "Estado";
      this.dgvOt.Columns[4].Width = 85;
      this.dgvOt.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("FechaAtencion", "Fecha Atencion");
      this.dgvOt.Columns[5].DataPropertyName = "FechaAtencion";
      this.dgvOt.Columns[5].Width = 110;
      this.dgvOt.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("IdOrdenAtencion", "IdOrdenAtencion");
      this.dgvOt.Columns[6].DataPropertyName = "IdOrdenAtencion";
      this.dgvOt.Columns[6].Width = 80;
      this.dgvOt.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns[6].Visible = false;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Eliminar";
      viewButtonColumn.HeaderText = "Eliminar";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "X";
      viewButtonColumn.Width = 50;
      viewButtonColumn.DisplayIndex = 7;
      this.dgvOt.Columns.Add((DataGridViewColumn) viewButtonColumn);
    }

    private void creaColumnasListadoPagos()
    {
      this.dgvListadoPagos.AutoGenerateColumns = false;
      this.dgvListadoPagos.Columns.Add("Linea", "");
      this.dgvListadoPagos.Columns[0].DataPropertyName = "Linea";
      this.dgvListadoPagos.Columns[0].Width = 20;
      this.dgvListadoPagos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[0].Visible = false;
      this.dgvListadoPagos.Columns[0].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("Emision", "Emision");
      this.dgvListadoPagos.Columns[1].DataPropertyName = "FechaEmision";
      this.dgvListadoPagos.Columns[1].Width = 70;
      this.dgvListadoPagos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[1].DefaultCellStyle.Format = "d";
      this.dgvListadoPagos.Columns[1].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("DocumentoVenta", "Documento");
      this.dgvListadoPagos.Columns[2].DataPropertyName = "DocumentoVenta";
      this.dgvListadoPagos.Columns[2].Width = 150;
      this.dgvListadoPagos.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[2].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("Folio", "Folio");
      this.dgvListadoPagos.Columns[3].DataPropertyName = "Folio";
      this.dgvListadoPagos.Columns[3].Width = 60;
      this.dgvListadoPagos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvListadoPagos.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[3].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("RazonSocial", "Cliente");
      this.dgvListadoPagos.Columns[4].DataPropertyName = "RazonSocial";
      this.dgvListadoPagos.Columns[4].Width = 305;
      this.dgvListadoPagos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.dgvListadoPagos.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[4].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("EstadoPago", "Estado");
      this.dgvListadoPagos.Columns[5].DataPropertyName = "EstadoPago";
      this.dgvListadoPagos.Columns[5].Width = 90;
      this.dgvListadoPagos.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[5].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("Total", "Total");
      this.dgvListadoPagos.Columns[6].DataPropertyName = "Total";
      this.dgvListadoPagos.Columns[6].Width = 80;
      this.dgvListadoPagos.Columns[6].DefaultCellStyle.Format = "N0";
      this.dgvListadoPagos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvListadoPagos.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[6].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("TotalPagado", "Pagado");
      this.dgvListadoPagos.Columns[7].DataPropertyName = "TotalPagado";
      this.dgvListadoPagos.Columns[7].Width = 80;
      this.dgvListadoPagos.Columns[7].DefaultCellStyle.Format = "N0";
      this.dgvListadoPagos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvListadoPagos.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[7].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("TotalDocumentado", "Documentado");
      this.dgvListadoPagos.Columns[8].DataPropertyName = "TotalDocumentado";
      this.dgvListadoPagos.Columns[8].Width = 80;
      this.dgvListadoPagos.Columns[8].DefaultCellStyle.Format = "N0";
      this.dgvListadoPagos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvListadoPagos.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[8].ReadOnly = true;
      this.dgvListadoPagos.Columns.Add("TotalPendiente", "Pendiente");
      this.dgvListadoPagos.Columns[9].DataPropertyName = "TotalPendiente";
      this.dgvListadoPagos.Columns[9].Width = 80;
      this.dgvListadoPagos.Columns[9].DefaultCellStyle.Format = "N0";
      this.dgvListadoPagos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvListadoPagos.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvListadoPagos.Columns[9].ReadOnly = true;
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
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "modulo_facturacion_Aptusoft").ShowDialog();
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
      }
    }

    public void buscaClienteCodigo(int cod)
    {
      Cliente cliente = new Cliente();
      ClienteVO clienteVo = cliente.buscaCodigoCliente(cod);
      this.idCliente = clienteVo.Codigo;
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
      this.txtDiasPlazo.Text = clienteVo.DiasPlazo;
      this.txtEmail.Text = clienteVo.Email;
      this.txtInicioSoporte.Text = clienteVo.InicioSoporte.ToShortDateString();
      this.txtMesesSoporte.Text = clienteVo.MesesSoporte.ToString();
      if (!this.buscaContratoActivo(this.idCliente))
        this.fechaSoporte(clienteVo.InicioSoporte, clienteVo.MesesSoporte);
      this.dtpFechaIngreso.Text = clienteVo.FechaCreacion.ToString();
      string desde = "2012-01-01";
      string hasta = DateTime.Now.ToString("yyyy-MM-dd");
      string str = cliente.fechaUltimaCompra(this.idCliente).ToShortDateString();
      if (str.Equals("01/01/0001"))
        this.txtFechaUltimaCompra.Text = "Sin Compras";
      else
        this.txtFechaUltimaCompra.Text = str;
      this.ventasCliente(desde, hasta);
      this.productosCliente();
      this.pagosCliente();
      this.ordenAtencionCliente();
      this.txtClienteListadoPago.Text = clienteVo.RazonSocial;
    }

    private bool buscaContratoActivo(int idCli)
    {
      ContratoVO contratoVo = new ContratoNegocio().BuscaContratoActivoIdCliente(idCli);
      if (contratoVo.Estado == null || !contratoVo.Estado.Equals("ACTIVO"))
        return false;
      this.lblDias.Text = "Soporte Ilimitado desde " + contratoVo.FechaContratacion.ToShortDateString();
      this.lblDias.BackColor = Color.LightGreen;
      this.lblDias.ForeColor = Color.Blue;
      return true;
    }

    private void fechaSoporte(DateTime inicio, int cantMes)
    {
      string str = "";
      DateTime now = DateTime.Now;
      DateTime dateTime = inicio.AddMonths((int) Convert.ToInt16(cantMes));
      int num1 = dateTime.Day - now.Day;
      int num2 = dateTime.Month - now.Month;
      int num3 = dateTime.Year - now.Year;
      if (num2 < 0)
      {
        --num3;
        num2 += 12;
      }
      if (num1 < 0)
      {
        --num2;
        num1 += DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
      }
      if (num3 < 0)
        str = "Fecha Invalida";
      if (num3 > 0)
        str = str + num3.ToString() + " años ";
      if (num2 > 0)
        str = str + num2.ToString() + " meses ";
      if (num1 > 0)
        str = str + num1.ToString() + " dias ";
      if (dateTime < now)
      {
        this.lblDias.Text = "Fecha de Termino: " + dateTime.ToShortDateString() + " ****SIN SOPORTE ACTIVO****";
        this.lblDias.BackColor = Color.Red;
        this.lblDias.ForeColor = Color.Yellow;
      }
      else
      {
        this.lblDias.Text = "Fecha de Termino: " + dateTime.ToShortDateString() + " Quedan " + str;
        this.lblDias.BackColor = Color.LightGreen;
        this.lblDias.ForeColor = Color.Blue;
      }
    }

    private void ventasCliente(string desde, string hasta)
    {
      Cliente cliente = new Cliente();
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvPendientes.DataSource = (object) null;
      this.dgvNotaCredito.DataSource = (object) null;
      string str1 = " idCliente=" + this.idCliente.ToString();
      string str2 = "";
      string filtro1 = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "' AND " + str1 + " " + str2;
      string filtro2 = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "' AND " + str1;
      List<Venta> list1 = cliente.ventasCliente(filtro1);
      List<Venta> list2 = new List<Venta>();
      List<Venta> list3 = Enumerable.ToList<Venta>((IEnumerable<Venta>) Enumerable.OrderByDescending<Venta, DateTime>((IEnumerable<Venta>) list1, (Func<Venta, DateTime>) (p => p.FechaEmision)));
      List<Venta> list4 = cliente.notaCreditoCliente(filtro2);
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      Decimal num6 = new Decimal(0);
      if (list3.Count > 0)
      {
        for (int index = 0; index < list3.Count; ++index)
        {
          list3[index].Linea = index + 1;
          num1 += list3[index].TotalPagado;
          num2 += list3[index].TotalDocumentado;
          num3 += list3[index].TotalPendiente;
        }
        this.dgvDatosVenta.DataSource = (object) list3;
        this.txtTotalPagado.Text = num1.ToString("N0");
        this.txtTotalPendiente.Text = num3.ToString("N0");
        this.txtTotalDocumentado.Text = num2.ToString("N0");
        foreach (Venta venta in list3)
        {
          if (venta.TotalPendiente > new Decimal(0))
            list2.Add(venta);
        }
        if (list2.Count > 0)
          this.dgvPendientes.DataSource = (object) list2;
        this.iniciaPago();
      }
      if (list4.Count > 0)
      {
        for (int index = 0; index < list4.Count; ++index)
        {
          list4[index].Linea = index + 1;
          num4 += list4[index].MontoUsado;
          num5 += list4[index].MontoDisponible;
        }
        this.dgvNotaCredito.DataSource = (object) list4;
        this.txtTotalUsado.Text = num4.ToString("N0");
        this.txtTotalDisponible.Text = num5.ToString("N0");
      }
      Decimal num7 = num3 - num5;
      this.txtDeuda.Text = num7.ToString("N0");
      if (num7 > new Decimal(0))
        this.panelColorDeuda.BackColor = Color.Red;
      else
        this.panelColorDeuda.BackColor = Color.LightGreen;
    }

    private void productosCliente()
    {
      this.dgvProductosCliente.DataSource = (object) null;
      this.dgvProductosCliente.DataSource = (object) Enumerable.ToList<DatosVentaVO>((IEnumerable<DatosVentaVO>) Enumerable.OrderByDescending<DatosVentaVO, DateTime>((IEnumerable<DatosVentaVO>) new Cliente().productosCliente(this.idCliente), (Func<DatosVentaVO, DateTime>) (o => o.FechaIngreso)));
    }

    private void pagosCliente()
    {
      this.dgvPagosClientes.DataSource = (object) null;
      this.dgvPagosClientes.DataSource = (object) Enumerable.ToList<PagoVentaVO>((IEnumerable<PagoVentaVO>) Enumerable.OrderByDescending<PagoVentaVO, DateTime>((IEnumerable<PagoVentaVO>) new Cliente().pagosCliente(this.idCliente), (Func<PagoVentaVO, DateTime>) (o => o.FechaCobro)));
    }

    private void ordenAtencionCliente()
    {
      List<OrdenAtencionVO> list1 = new List<OrdenAtencionVO>();
      List<OrdenAtencionVO> list2 = new OrdenAtencion().listaOrdenAtencion(this.idCliente);
      for (int index = 0; index < list2.Count; ++index)
        list2[index].Linea = index + 1;
      this.dgvOt.DataSource = (object) list2;
    }

    private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtDigito.Focus();
    }

    private void soloNumeros(KeyPressEventArgs e)
    {
      string str = "0123456789";
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (str.Contains(string.Concat((object) e.KeyChar)) || (int) e.KeyChar == 8)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "modulo_facturacion_Aptusoft").ShowDialog();
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

    private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
    {
      if (!this.pnlBuscaClienteDes.Visible || e.KeyCode != Keys.Down)
        return;
      this.dgvBuscaCliente.Focus();
    }

    private void dgvBuscaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void dgvBuscaCliente_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void btnOt_Click(object sender, EventArgs e)
    {
      int num = (int) new frmOt(this.idCliente, this.txtRut.Text, this.txtDigito.Text, this.txtRazonSocial.Text, this.txtEmail.Text, this.txtFono.Text, this.txtContacto.Text, this.intance).ShowDialog();
      this.ordenAtencionCliente();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dgvOt_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvOt.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar esta Orden de Atención", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      new OrdenAtencion().eliminaOrdenAtencion(Convert.ToInt32(this.dgvOt.SelectedRows[0].Cells["IdOrdenAtencion"].Value.ToString()));
      int num = (int) MessageBox.Show("Orden de Atención Eliminada", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.ordenAtencionCliente();
    }

    private void dgvOt_DoubleClick(object sender, EventArgs e)
    {
      if (this.dgvOt.RowCount <= 0)
        return;
      int num = (int) new frmOt(Convert.ToInt32(this.dgvOt.SelectedRows[0].Cells["IdOrdenAtencion"].Value.ToString()), this.intance).ShowDialog();
      this.ordenAtencionCliente();
    }

    private void dgvDatosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      string str = this.dgvDatosVenta.SelectedRows[0].Cells["DocumentoVenta"].Value.ToString();
      string folio = this.dgvDatosVenta.SelectedRows[0].Cells["Folio"].Value.ToString();
      if (this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "VerFactura")
      {
        if (str.Equals("FACTURA"))
        {
          bool flag = false;
          foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
          {
            if (usuarioVo.Modulo.Equals("FACTURA"))
              flag = Convert.ToBoolean(usuarioVo.Ingresa);
          }
          if (flag)
          {
            if (Application.OpenForms["frmFactura"] == null)
            {
              new frmFactura(folio).Show();
            }
            else
            {
              Application.OpenForms["frmFactura"].Close();
              new frmFactura(folio).Show();
            }
          }
          else
          {
            int num = (int) MessageBox.Show("Sin Permiso Para Ingresar al Modulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        if (str.Equals("FACTURA ELECTRONICA"))
        {
          bool flag = false;
          foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
          {
            if (usuarioVo.Modulo.Equals("FACTURA"))
              flag = Convert.ToBoolean(usuarioVo.Ingresa);
          }
          if (flag)
          {
            if (Application.OpenForms["frmFacturaElectronica"] == null)
            {
              new frmFacturaElectronica(folio).Show();
            }
            else
            {
              Application.OpenForms["frmFacturaElectronica"].Close();
              new frmFacturaElectronica(folio).Show();
            }
          }
          else
          {
            int num = (int) MessageBox.Show("Sin Permiso Para Ingresar al Modulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
      }
      if (!(this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Pagar"))
        return;
      if (str.Equals("FACTURA"))
      {
        int num1 = (int) new frmPagoVenta(ref this.intance, "FACTURA", folio, this.idCliente).ShowDialog();
      }
      if (str.Equals("FACTURA ELECTRONICA"))
      {
        int num2 = (int) new frmPagoVenta(ref this.intance, "FACTURA_ELECTRONICA", folio, this.idCliente).ShowDialog();
      }
    }

    private void dgvPagosClientes_DoubleClick(object sender, EventArgs e)
    {
      if (this.dgvPagosClientes.RowCount <= 0)
        return;
      string str = this.dgvPagosClientes.SelectedRows[0].Cells["TipoDocumento"].Value.ToString();
      string folio = this.dgvPagosClientes.SelectedRows[0].Cells["FolioCobro"].Value.ToString();
      if (str.Equals("FACTURA"))
      {
        int num1 = (int) new frmPagoVenta(ref this.intance, "FACTURA", folio, this.idCliente).ShowDialog();
      }
      if (str.Equals("FACTURA_ELECTRONICA"))
      {
        int num2 = (int) new frmPagoVenta(ref this.intance, "FACTURA_ELECTRONICA", folio, this.idCliente).ShowDialog();
      }
    }

    private void btnBuscaClienteListadoPago_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "modulo_facturacion_Aptusoft").ShowDialog();
    }

    private void btnBuscaListadoPagos_Click(object sender, EventArgs e)
    {
      this.listadoPagos();
    }

    private void listadoPagos()
    {
      Cliente cliente = new Cliente();
      this.dgvListadoPagos.DataSource = (object) null;
      string str1 = "";
      if (this.txtClienteListadoPago.Text.Trim().Length > 0)
        str1 = " AND idCliente=" + this.idCliente.ToString();
      string str2 = this.dtpDesde.Value.ToString("yyyy-MM-dd");
      string str3 = this.dtpHasta.Value.ToString("yyyy-MM-dd");
      string str4 = "";
      if (this.cmbEstadoPagoListado.SelectedValue != null && this.cmbEstadoPagoListado.Text != "[TODOS]")
        str4 = " AND estadoPago='" + this.cmbEstadoPagoListado.Text + "'";
      string filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + str2 + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + str3 + "' " + str1 + " " + str4;
      List<Venta> list = Enumerable.ToList<Venta>((IEnumerable<Venta>) Enumerable.OrderByDescending<Venta, DateTime>((IEnumerable<Venta>) cliente.ventasCliente(filtro), (Func<Venta, DateTime>) (p => p.FechaEmision)));
      if (list.Count <= 0)
        return;
      this.dgvListadoPagos.DataSource = (object) list;
    }

    private void dgvListadoPagos_DoubleClick(object sender, EventArgs e)
    {
      if (this.dgvListadoPagos.RowCount <= 0)
        return;
      int num = (int) new frmPagoVenta(ref this.intance, this.dgvListadoPagos.SelectedRows[0].Cells["DocumentoVenta"].Value.ToString(), this.dgvListadoPagos.SelectedRows[0].Cells["Folio"].Value.ToString(), this.idCliente).ShowDialog();
    }

    private void btnBuscarContratosAFacturar_Click(object sender, EventArgs e)
    {
      this.chkMarcarTodos.Checked = true;
      if (this.rdbCiclo1y2.Checked)
      {
        string consulta = "codigoCiclo < 15";
        this.dgvFacturacionCiclo.DataSource = (object) null;
        this._listaContratos = new ContratoNegocio().BuscaContratoActivoCodigoCiclo(consulta, this.dtpFechaFacturacion.Value);
        if (this._listaContratos.Count > 0)
          this.dgvFacturacionCiclo.DataSource = (object) this._listaContratos;
        else
          this.dgvFacturacionCiclo.DataSource = (object) null;
      }
      else
      {
        string consulta = "codigoCiclo = 15";
        this.dgvFacturacionCiclo.DataSource = (object) null;
        this._listaContratos = new ContratoNegocio().BuscaContratoActivoCodigoCiclo(consulta, this.dtpFechaFacturacion.Value);
        this.dgvFacturacionCiclo.DataSource = this._listaContratos.Count <= 0 ? (object) null : (object) this._listaContratos;
      }
    }

    private void chkMarcarTodos_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkMarcarTodos.Checked)
      {
        if (this._listaContratos.Count <= 0)
          return;
        for (int index = 0; index < this._listaContratos.Count; ++index)
          this._listaContratos[index].Facturar = true;
        this.dgvFacturacionCiclo.DataSource = (object) null;
        this.dgvFacturacionCiclo.DataSource = (object) this._listaContratos;
      }
      else if (this._listaContratos.Count > 0)
      {
        for (int index = 0; index < this._listaContratos.Count; ++index)
          this._listaContratos[index].Facturar = false;
        this.dgvFacturacionCiclo.DataSource = (object) null;
        this.dgvFacturacionCiclo.DataSource = (object) this._listaContratos;
      }
    }

    private void btnFacturar_Click(object sender, EventArgs e)
    {
      if (this._listaContratos.Count > 0)
      {
        if (MessageBox.Show("Esta Seguro/a de Facturar las Seleccionadas?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          this.btnFacturar.Enabled = false;
          this.lblAlertaFacturando.Visible = true;
          this.Refresh();
          this.SeleccionarContratosAFacturar();
          if (MessageBox.Show("Desea Enviar las Facturas por Correo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.EnviarFacturaCorreo();
          this.lblAlertaFacturando.Visible = false;
          int num = (int) MessageBox.Show("Proceso de Facturacion Terminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.btnFacturar.Enabled = true;
          this.iniciaFormulario();
        }
        else
        {
          int num1 = (int) MessageBox.Show("Accion Cancelada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("No Hay documentos a facturar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void SeleccionarContratosAFacturar()
    {
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvFacturacionCiclo.Rows)
      {
        if (Convert.ToBoolean(dataGridViewRow.Cells["Facturar"].Value))
          this.FacturarCiclos(Convert.ToInt32(dataGridViewRow.Cells["idContrato"].Value.ToString()));
      }
    }

    private void FacturarCiclos(int idContrato)
    {
      foreach (ContratoVO con in this._listaContratos)
      {
        if (con.IdContrato == idContrato)
        {
          if (con.Total > new Decimal(0))
            con.FolioFactura = new FacturacionNegocio().CreaFacturaElectronica(con, this.dtpFechaFacturacion.Value);
          else
            new FacturacionNegocio().GuardaFacturacion(new FacturacionVO()
            {
              IdContrato = con.IdContrato,
              IdCliente = con.IdCliente,
              IdDocumentoVenta = 0,
              FolioDocumentoVenta = 0
            });
          if (con.Descuento > new Decimal(0))
            new ContratoNegocio().ModificaMesesOfertaOcupado(con.IdContrato);
        }
      }
    }

    private void EnviarFacturaCorreo()
    {
      foreach (ContratoVO contratoVo in this._listaContratos)
      {
        if (contratoVo.FolioFactura > 0 && contratoVo.Total > new Decimal(0) && contratoVo.Email.Trim().Length > 0)
          new Aptusoft.InternoAptusoft.Email.Email().EnviaEmail(new EmailVO()
          {
            De = "info@Aptusoft.cl",
            Para = contratoVo.Email,
            Asunto = "Factura Plan Aptusoft",
            Mensaje = "Se adjunto factura electronica",
            Adjunto = contratoVo.FolioFactura.ToString("##")
          });
      }
    }

    private void calculaPendienteSeleccionados()
    {
      Decimal num1 = new Decimal(0);
      int num2 = 0;
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPendientes.Rows)
      {
        if (Convert.ToBoolean(dataGridViewRow.Cells["Pagar"].Value))
        {
          num1 += Convert.ToDecimal(dataGridViewRow.Cells["TotalPendiente"].Value.ToString());
          ++num2;
        }
      }
      this.txtPagoPendiente.Text = num1.ToString("N0");
      this.txtCantidadDocPendiente.Text = num2.ToString("N0");
      if (num2 > 0)
        this.panelPago.Enabled = true;
      else
        this.panelPago.Enabled = false;
    }

    private void dgvPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      this.dgvPendientes.CommitEdit(DataGridViewDataErrorContexts.Commit);
    }

    private void dgvPendientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvPendientes.RowCount <= 0)
        return;
      this.calculaPendienteSeleccionados();
    }

    private void btnLimpiarPago_Click(object sender, EventArgs e)
    {
      this.iniciaPago();
    }

    private void chkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
    {
      if (this.dgvPendientes.RowCount <= 0)
        return;
      if (this.chkSeleccionarTodos.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPendientes.Rows)
          dataGridViewRow.Cells["Pagar"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPendientes.Rows)
          dataGridViewRow.Cells["Pagar"].Value = (object) false;
      }
    }

    private void PagoMultiple()
    {
      if (!this.ValidaPagoMultiple())
        return;
      this.RecorreListaPagaDocumento(this.CreaListaPagoCtaCte());
      int num = (int) MessageBox.Show("Pagos Registrados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private bool ValidaPagoMultiple()
    {
      if (this.txtMonto.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Monto a Pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtMonto.Focus();
        return false;
      }
      if (Convert.ToDecimal(this.txtMonto.Text.Trim()) == new Decimal(0))
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Monto a Pagar Mayor a Cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtMonto.Focus();
        return false;
      }
      if (!(this.cmbMedioPago.SelectedValue.ToString() == "0"))
        return true;
      int num1 = (int) MessageBox.Show("Debe Seleccionar un Medio de Pago Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.cmbMedioPago.Focus();
      return false;
    }

    private List<PagoVentaVO> CreaListaPagoCtaCte()
    {
      List<PagoVentaVO> list = new List<PagoVentaVO>();
      PagoVentaVO pagoVentaVo1 = new PagoVentaVO();
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPendientes.Rows)
      {
        if (Convert.ToBoolean(dataGridViewRow.Cells["Pagar"].Value))
        {
          PagoVentaVO pagoVentaVo2 = new PagoVentaVO();
          pagoVentaVo2.IdDocumento = Convert.ToInt32(dataGridViewRow.Cells["IdFactura"].Value.ToString());
          pagoVentaVo2.FolioDocumento = Convert.ToInt32(dataGridViewRow.Cells["Folio"].Value.ToString());
          pagoVentaVo2.TipoDocumento = dataGridViewRow.Cells["DocumentoVenta"].Value.ToString();
          pagoVentaVo2.TotalDocumento = Convert.ToDecimal(dataGridViewRow.Cells["Total"].Value.ToString());
          pagoVentaVo2.MontoPagadoDocumento = Convert.ToDecimal(dataGridViewRow.Cells["TotalPagado"].Value.ToString());
          pagoVentaVo2.MontoDocumentadoDocumento = Convert.ToDecimal(dataGridViewRow.Cells["TotalDocumentado"].Value.ToString());
          pagoVentaVo2.MontoPendienteDocumento = Convert.ToDecimal(dataGridViewRow.Cells["TotalPendiente"].Value.ToString());
          pagoVentaVo2.FechaCobro = this.dtpFechaCobro.Value;
          pagoVentaVo2.IdFormaPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
          pagoVentaVo2.FormaPago = this.cmbMedioPago.Text;
          pagoVentaVo2.Estado = this.rdbPagado.Checked ? "PAGADO" : "DOCUMENTADO";
          if (this.cmbBanco.SelectedValue.ToString() != "0")
            pagoVentaVo2.Banco = this.cmbBanco.Text;
          pagoVentaVo2.Cuenta = this.txtCuenta.Text;
          pagoVentaVo2.NumeroDocumento = this.txtNumeroDocumento.Text;
          pagoVentaVo2.Observaciones = this.txtObservaciones.Text;
          pagoVentaVo2.TipoPago = "PMD";
          list.Add(pagoVentaVo2);
        }
      }
      return list;
    }

    private void RecorreListaPagaDocumento(List<PagoVentaVO> listaPagos)
    {
      Decimal num1 = Convert.ToDecimal(this.txtMonto.Text.Trim());
      Decimal num2 = num1;
      DateTime now = DateTime.Now;
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      foreach (PagoVentaVO pvVO in listaPagos)
      {
        pvVO.MontoPagoMasivo = num1;
        num3 = new Decimal(0);
        num4 = new Decimal(0);
        num5 = new Decimal(0);
        Decimal tPagado;
        Decimal tDocumentado;
        Decimal tPendiente;
        if (num2 >= pvVO.MontoPendienteDocumento)
        {
          if (pvVO.Estado.Equals("PAGADO"))
          {
            tPagado = pvVO.MontoPagadoDocumento + pvVO.MontoPendienteDocumento;
            tDocumentado = pvVO.MontoDocumentadoDocumento;
            tPendiente = new Decimal(0);
            pvVO.Monto = pvVO.MontoPendienteDocumento;
            num2 -= pvVO.MontoPendienteDocumento;
          }
          else
          {
            tPagado = pvVO.MontoPagadoDocumento;
            tDocumentado = pvVO.MontoDocumentadoDocumento + pvVO.MontoPendienteDocumento;
            tPendiente = new Decimal(0);
            pvVO.Monto = pvVO.MontoPendienteDocumento;
            num2 -= pvVO.MontoPendienteDocumento;
          }
        }
        else if (pvVO.Estado.Equals("PAGADO"))
        {
          tPagado = pvVO.MontoPagadoDocumento + num2;
          tDocumentado = pvVO.MontoDocumentadoDocumento;
          tPendiente = pvVO.MontoPendienteDocumento - num2;
          pvVO.Monto = num2;
        }
        else
        {
          tPagado = pvVO.MontoPagadoDocumento;
          tDocumentado = pvVO.MontoDocumentadoDocumento + num2;
          tPendiente = pvVO.MontoPendienteDocumento - num2;
          num2 -= pvVO.MontoPendienteDocumento;
          pvVO.Monto = num2;
        }
        this.PagaDocumento(pvVO, now, tPagado, tDocumentado, tPendiente);
        if (num2 == new Decimal(0))
          break;
      }
    }

    private void PagaDocumento(PagoVentaVO pvVO, DateTime fechaIngreso, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      new PagoVenta().AgregaPagoDesdeModuloCuentaCorriente(pvVO, pvVO.TipoDocumento, pvVO.IdDocumento, pvVO.FolioDocumento, fechaIngreso, pvVO.Estado, tPagado, tDocumentado, tPendiente);
    }

    private void btnPagar_Click(object sender, EventArgs e)
    {
      this.PagoMultiple();
      this.buscaClienteCodigo(this.idCliente);
    }
  }
}
