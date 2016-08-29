 
// Type: Aptusoft.frmPreVentas
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmPreVentas : Form
  {
    private IContainer components = (IContainer) null;
    private int idCliente = 0;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private Panel pnlBuscaClienteDes;
    private DataGridView dgvBuscaCliente;
    private GroupBox gbZonaCliente;
    private Label label16;
    private TextBox txtEmail;
    private Button btnBuscaCliente;
    private TextBox txtContacto;
    private Label label12;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
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
    private Button btnOt;
    private GroupBox groupBox2;
    private DataGridView dgvOt;
    private TabPage tabPage2;
    private GroupBox groupBox4;
    private Label label17;
    private Button btnBuscaFiltro;
    private DataGridView dgvClientesFiltro;
    private ComboBox cmbVendedor;
    private TextBox txtTipoCliente;
    private Label label3;
    private TextBox txtProcedencia;
    private Label label2;
    private TextBox txtVendedor;
    private Label label1;
    private Label label19;
    private TextBox txtEmail3;
    private Label label20;
    private TextBox txtFono3;
    private Label label11;
    private TextBox txtEmail2;
    private Label label18;
    private TextBox txtFono2;
    private Label label13;
    private TextBox txtIntentos;
    private ComboBox cmbSemaforo;
    private Label label14;
    private Button btnFicha;
    private Label lblActivo;
    private Button btnSalir;
    private Button btnLimpiar;
    private TabPage tabPage3;
    private GroupBox groupBox1;
    private ComboBox cmbVendedorBusqueda;
    private Label label15;
    private ComboBox cmbEstadoFiltro;
    private DateTimePicker dtpHastaFiltro;
    private DateTimePicker dtpDesdeFiltro;
    private Label label21;
    private Label label22;
    private Label label23;
    private Button btnBuscarOtBusqueda;
    private GroupBox groupBox3;
    private DataGridView dgvOtBusqueda;
    private RadioButton rdbFechaAtencion;
    private RadioButton rdbFechaIngreso;
    private DataGridViewTextBoxColumn IdOrden;
    private DataGridViewTextBoxColumn Fecha;
    private DataGridViewTextBoxColumn FechaAtencion;
    private DataGridViewTextBoxColumn Vendedor;
    private DataGridViewTextBoxColumn Observacion;
    private DataGridViewTextBoxColumn Estado;
    private DataGridViewTextBoxColumn IdOrdenAtencionB;
    private DataGridViewTextBoxColumn FechaIngresoB;
    private DataGridViewTextBoxColumn FechaAtencionB;
    private DataGridViewTextBoxColumn Cliente;
    private DataGridViewTextBoxColumn IdClienteB;
    private DataGridViewTextBoxColumn VendedorB;
    private DataGridViewTextBoxColumn EstadoB;
    private DataGridViewTextBoxColumn ObservacionB;
    private TextBox txtCantidadRegistros;
    private TextBox txtNumeroRegistros;
    private Button btnUltimo;
    private Button btnSiguiente;
    private Button btnAtraz;
    private Button btnPrimero;
    private Label label25;
    private Label label24;
    private TextBox txtPaginaActual;
    private TextBox txtPaginasTotal;
    private Panel panel1;
    private Label lblBuscando;
    private DataGridViewTextBoxColumn Linea;
    private DataGridViewTextBoxColumn CodigoCliente;
    private DataGridViewTextBoxColumn FechaCreacion;
    private DataGridViewTextBoxColumn RazonSocial;
    private DataGridViewTextBoxColumn Vendedor2;
    private DataGridViewTextBoxColumn Intentos;
    private DataGridViewTextBoxColumn TipoCliente;
    private TabPage tabPage4;
    private Panel panel2;
    private CrystalReportViewer crvVisualizador;
    private Panel panel3;
    private ComboBox cmbProcedencia;
    private ComboBox cmbVendedorInforme;
    private Label label27;
    private Label label26;
    private Button btnFiltrar;
    private DateTimePicker dtpHastaInforme;
    private DateTimePicker dtpDesdeInforme;
    private Label label28;
    private Label label29;
    private TabControl tabControl2;
    private TabPage tabPage5;
    private TabPage tabPage6;
    private DataGridView dgvCotizaciones;
    private Label label30;
    private DataGridViewTextBoxColumn FechaCotizacion;
    private DataGridViewTextBoxColumn FolioCotizacion;
    private DataGridViewTextBoxColumn TotalCotizacion;
    private DataGridViewTextBoxColumn VendedorCotizacion;
    private frmPreVentas intance;

    public frmPreVentas()
    {
      this.InitializeComponent();
      this.intance = this;
      this.creaColumnasBuscaClientes();
      this.dgvOt.AutoGenerateColumns = false;
      this.dgvOtBusqueda.AutoGenerateColumns = false;
      this.dgvClientesFiltro.AutoGenerateColumns = false;
      this.dgvCotizaciones.AutoGenerateColumns = false;
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
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.pnlBuscaClienteDes = new Panel();
      this.dgvBuscaCliente = new DataGridView();
      this.lblActivo = new Label();
      this.btnFicha = new Button();
      this.gbZonaCliente = new GroupBox();
      this.label13 = new Label();
      this.txtIntentos = new TextBox();
      this.label19 = new Label();
      this.txtEmail3 = new TextBox();
      this.label20 = new Label();
      this.txtFono3 = new TextBox();
      this.label11 = new Label();
      this.txtEmail2 = new TextBox();
      this.label18 = new Label();
      this.txtFono2 = new TextBox();
      this.txtTipoCliente = new TextBox();
      this.label3 = new Label();
      this.txtProcedencia = new TextBox();
      this.label2 = new Label();
      this.txtVendedor = new TextBox();
      this.label1 = new Label();
      this.label16 = new Label();
      this.txtEmail = new TextBox();
      this.btnBuscaCliente = new Button();
      this.txtContacto = new TextBox();
      this.label12 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
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
      this.btnOt = new Button();
      this.groupBox2 = new GroupBox();
      this.tabControl2 = new TabControl();
      this.tabPage5 = new TabPage();
      this.dgvOt = new DataGridView();
      this.IdOrden = new DataGridViewTextBoxColumn();
      this.Fecha = new DataGridViewTextBoxColumn();
      this.FechaAtencion = new DataGridViewTextBoxColumn();
      this.Vendedor = new DataGridViewTextBoxColumn();
      this.Observacion = new DataGridViewTextBoxColumn();
      this.Estado = new DataGridViewTextBoxColumn();
      this.tabPage6 = new TabPage();
      this.label30 = new Label();
      this.dgvCotizaciones = new DataGridView();
      this.FechaCotizacion = new DataGridViewTextBoxColumn();
      this.FolioCotizacion = new DataGridViewTextBoxColumn();
      this.TotalCotizacion = new DataGridViewTextBoxColumn();
      this.VendedorCotizacion = new DataGridViewTextBoxColumn();
      this.tabPage2 = new TabPage();
      this.lblBuscando = new Label();
      this.panel1 = new Panel();
      this.txtPaginaActual = new TextBox();
      this.txtPaginasTotal = new TextBox();
      this.btnPrimero = new Button();
      this.btnAtraz = new Button();
      this.btnUltimo = new Button();
      this.btnSiguiente = new Button();
      this.label25 = new Label();
      this.label24 = new Label();
      this.txtCantidadRegistros = new TextBox();
      this.txtNumeroRegistros = new TextBox();
      this.groupBox4 = new GroupBox();
      this.cmbSemaforo = new ComboBox();
      this.label14 = new Label();
      this.cmbVendedor = new ComboBox();
      this.label17 = new Label();
      this.btnBuscaFiltro = new Button();
      this.dgvClientesFiltro = new DataGridView();
      this.Linea = new DataGridViewTextBoxColumn();
      this.CodigoCliente = new DataGridViewTextBoxColumn();
      this.FechaCreacion = new DataGridViewTextBoxColumn();
      this.RazonSocial = new DataGridViewTextBoxColumn();
      this.Vendedor2 = new DataGridViewTextBoxColumn();
      this.Intentos = new DataGridViewTextBoxColumn();
      this.TipoCliente = new DataGridViewTextBoxColumn();
      this.tabPage3 = new TabPage();
      this.groupBox1 = new GroupBox();
      this.rdbFechaAtencion = new RadioButton();
      this.rdbFechaIngreso = new RadioButton();
      this.cmbVendedorBusqueda = new ComboBox();
      this.label15 = new Label();
      this.cmbEstadoFiltro = new ComboBox();
      this.dtpHastaFiltro = new DateTimePicker();
      this.dtpDesdeFiltro = new DateTimePicker();
      this.label21 = new Label();
      this.label22 = new Label();
      this.label23 = new Label();
      this.btnBuscarOtBusqueda = new Button();
      this.groupBox3 = new GroupBox();
      this.dgvOtBusqueda = new DataGridView();
      this.IdOrdenAtencionB = new DataGridViewTextBoxColumn();
      this.FechaIngresoB = new DataGridViewTextBoxColumn();
      this.FechaAtencionB = new DataGridViewTextBoxColumn();
      this.Cliente = new DataGridViewTextBoxColumn();
      this.IdClienteB = new DataGridViewTextBoxColumn();
      this.VendedorB = new DataGridViewTextBoxColumn();
      this.EstadoB = new DataGridViewTextBoxColumn();
      this.ObservacionB = new DataGridViewTextBoxColumn();
      this.tabPage4 = new TabPage();
      this.panel3 = new Panel();
      this.btnFiltrar = new Button();
      this.cmbProcedencia = new ComboBox();
      this.dtpHastaInforme = new DateTimePicker();
      this.dtpDesdeInforme = new DateTimePicker();
      this.label28 = new Label();
      this.label29 = new Label();
      this.cmbVendedorInforme = new ComboBox();
      this.label27 = new Label();
      this.label26 = new Label();
      this.panel2 = new Panel();
      this.crvVisualizador = new CrystalReportViewer();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.pnlBuscaClienteDes.SuspendLayout();
      ((ISupportInitialize) this.dgvBuscaCliente).BeginInit();
      this.gbZonaCliente.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage5.SuspendLayout();
      ((ISupportInitialize) this.dgvOt).BeginInit();
      this.tabPage6.SuspendLayout();
      ((ISupportInitialize) this.dgvCotizaciones).BeginInit();
      this.tabPage2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      ((ISupportInitialize) this.dgvClientesFiltro).BeginInit();
      this.tabPage3.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((ISupportInitialize) this.dgvOtBusqueda).BeginInit();
      this.tabPage4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Location = new Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(840, 592);
      this.tabControl1.TabIndex = 36;
      this.tabPage1.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage1.Controls.Add((Control) this.pnlBuscaClienteDes);
      this.tabPage1.Controls.Add((Control) this.lblActivo);
      this.tabPage1.Controls.Add((Control) this.btnFicha);
      this.tabPage1.Controls.Add((Control) this.gbZonaCliente);
      this.tabPage1.Controls.Add((Control) this.btnOt);
      this.tabPage1.Controls.Add((Control) this.groupBox2);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(832, 566);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "PRE-VENTAS";
      this.pnlBuscaClienteDes.Controls.Add((Control) this.dgvBuscaCliente);
      this.pnlBuscaClienteDes.Location = new Point(257, 45);
      this.pnlBuscaClienteDes.Name = "pnlBuscaClienteDes";
      this.pnlBuscaClienteDes.Size = new Size(572, 173);
      this.pnlBuscaClienteDes.TabIndex = 34;
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
      this.dgvBuscaCliente.Location = new Point(1, 1);
      this.dgvBuscaCliente.Name = "dgvBuscaCliente";
      this.dgvBuscaCliente.ReadOnly = true;
      this.dgvBuscaCliente.RowHeadersVisible = false;
      this.dgvBuscaCliente.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaCliente.Size = new Size(560, 169);
      this.dgvBuscaCliente.TabIndex = 0;
      this.dgvBuscaCliente.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaCliente_CellDoubleClick);
      this.dgvBuscaCliente.KeyDown += new KeyEventHandler(this.dgvBuscaCliente_KeyDown);
      this.lblActivo.BackColor = Color.Red;
      this.lblActivo.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblActivo.ForeColor = Color.White;
      this.lblActivo.Location = new Point(250, 197);
      this.lblActivo.Name = "lblActivo";
      this.lblActivo.Size = new Size(385, 28);
      this.lblActivo.TabIndex = 39;
      this.lblActivo.Text = "Cliente Desactivado";
      this.lblActivo.TextAlign = ContentAlignment.TopCenter;
      this.btnFicha.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnFicha.Location = new Point(66, 198);
      this.btnFicha.Name = "btnFicha";
      this.btnFicha.Size = new Size(169, 23);
      this.btnFicha.TabIndex = 35;
      this.btnFicha.Text = "Ficha Pre-Cliente";
      this.btnFicha.UseVisualStyleBackColor = true;
      this.btnFicha.Click += new EventHandler(this.btnFicha_Click);
      this.gbZonaCliente.Controls.Add((Control) this.label13);
      this.gbZonaCliente.Controls.Add((Control) this.txtIntentos);
      this.gbZonaCliente.Controls.Add((Control) this.label19);
      this.gbZonaCliente.Controls.Add((Control) this.txtEmail3);
      this.gbZonaCliente.Controls.Add((Control) this.label20);
      this.gbZonaCliente.Controls.Add((Control) this.txtFono3);
      this.gbZonaCliente.Controls.Add((Control) this.label11);
      this.gbZonaCliente.Controls.Add((Control) this.txtEmail2);
      this.gbZonaCliente.Controls.Add((Control) this.label18);
      this.gbZonaCliente.Controls.Add((Control) this.txtFono2);
      this.gbZonaCliente.Controls.Add((Control) this.txtTipoCliente);
      this.gbZonaCliente.Controls.Add((Control) this.label3);
      this.gbZonaCliente.Controls.Add((Control) this.txtProcedencia);
      this.gbZonaCliente.Controls.Add((Control) this.label2);
      this.gbZonaCliente.Controls.Add((Control) this.txtVendedor);
      this.gbZonaCliente.Controls.Add((Control) this.label1);
      this.gbZonaCliente.Controls.Add((Control) this.label16);
      this.gbZonaCliente.Controls.Add((Control) this.txtEmail);
      this.gbZonaCliente.Controls.Add((Control) this.btnBuscaCliente);
      this.gbZonaCliente.Controls.Add((Control) this.txtContacto);
      this.gbZonaCliente.Controls.Add((Control) this.label12);
      this.gbZonaCliente.Controls.Add((Control) this.label10);
      this.gbZonaCliente.Controls.Add((Control) this.label9);
      this.gbZonaCliente.Controls.Add((Control) this.label8);
      this.gbZonaCliente.Controls.Add((Control) this.label7);
      this.gbZonaCliente.Controls.Add((Control) this.label6);
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
      this.gbZonaCliente.Size = new Size(815, 186);
      this.gbZonaCliente.TabIndex = 27;
      this.gbZonaCliente.TabStop = false;
      this.label13.AutoSize = true;
      this.label13.Location = new Point(550, 154);
      this.label13.Name = "label13";
      this.label13.Size = new Size(45, 13);
      this.label13.TabIndex = 50;
      this.label13.Text = "Intentos";
      this.txtIntentos.BackColor = Color.White;
      this.txtIntentos.Enabled = false;
      this.txtIntentos.ForeColor = Color.Black;
      this.txtIntentos.Location = new Point(598, 151);
      this.txtIntentos.Name = "txtIntentos";
      this.txtIntentos.Size = new Size(59, 20);
      this.txtIntentos.TabIndex = 49;
      this.label19.AutoSize = true;
      this.label19.Location = new Point(209, 155);
      this.label19.Name = "label19";
      this.label19.Size = new Size(42, 13);
      this.label19.TabIndex = 48;
      this.label19.Text = "E-Mail3";
      this.txtEmail3.BackColor = Color.White;
      this.txtEmail3.Location = new Point(253, 151);
      this.txtEmail3.Name = "txtEmail3";
      this.txtEmail3.Size = new Size(282, 20);
      this.txtEmail3.TabIndex = 47;
      this.label20.AutoSize = true;
      this.label20.Location = new Point(23, 155);
      this.label20.Name = "label20";
      this.label20.Size = new Size(37, 13);
      this.label20.TabIndex = 46;
      this.label20.Text = "Fono3";
      this.txtFono3.BackColor = Color.White;
      this.txtFono3.Location = new Point(60, 151);
      this.txtFono3.Name = "txtFono3";
      this.txtFono3.Size = new Size(143, 20);
      this.txtFono3.TabIndex = 45;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(209, 133);
      this.label11.Name = "label11";
      this.label11.Size = new Size(42, 13);
      this.label11.TabIndex = 44;
      this.label11.Text = "E-Mail2";
      this.txtEmail2.BackColor = Color.White;
      this.txtEmail2.Location = new Point(253, 129);
      this.txtEmail2.Name = "txtEmail2";
      this.txtEmail2.Size = new Size(282, 20);
      this.txtEmail2.TabIndex = 43;
      this.label18.AutoSize = true;
      this.label18.Location = new Point(23, 133);
      this.label18.Name = "label18";
      this.label18.Size = new Size(37, 13);
      this.label18.TabIndex = 42;
      this.label18.Text = "Fono2";
      this.txtFono2.BackColor = Color.White;
      this.txtFono2.Location = new Point(60, 129);
      this.txtFono2.Name = "txtFono2";
      this.txtFono2.Size = new Size(143, 20);
      this.txtFono2.TabIndex = 41;
      this.txtTipoCliente.BackColor = Color.White;
      this.txtTipoCliente.BorderStyle = BorderStyle.FixedSingle;
      this.txtTipoCliente.Location = new Point(663, 85);
      this.txtTipoCliente.Multiline = true;
      this.txtTipoCliente.Name = "txtTipoCliente";
      this.txtTipoCliente.Size = new Size(144, 86);
      this.txtTipoCliente.TabIndex = 40;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(588, 89);
      this.label3.Name = "label3";
      this.label3.Size = new Size(63, 13);
      this.label3.TabIndex = 39;
      this.label3.Text = "Tipo Cliente";
      this.label3.TextAlign = ContentAlignment.TopRight;
      this.txtProcedencia.BackColor = Color.White;
      this.txtProcedencia.Location = new Point(392, 85);
      this.txtProcedencia.Name = "txtProcedencia";
      this.txtProcedencia.Size = new Size(143, 20);
      this.txtProcedencia.TabIndex = 38;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(319, 89);
      this.label2.Name = "label2";
      this.label2.Size = new Size(67, 13);
      this.label2.TabIndex = 37;
      this.label2.Text = "Procedencia";
      this.label2.TextAlign = ContentAlignment.TopRight;
      this.txtVendedor.BackColor = Color.White;
      this.txtVendedor.Location = new Point(60, 85);
      this.txtVendedor.Name = "txtVendedor";
      this.txtVendedor.Size = new Size(253, 20);
      this.txtVendedor.TabIndex = 36;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(4, 89);
      this.label1.Name = "label1";
      this.label1.Size = new Size(53, 13);
      this.label1.TabIndex = 35;
      this.label1.Text = "Vendedor";
      this.label1.TextAlign = ContentAlignment.TopRight;
      this.label16.AutoSize = true;
      this.label16.Location = new Point(209, 111);
      this.label16.Name = "label16";
      this.label16.Size = new Size(36, 13);
      this.label16.TabIndex = 34;
      this.label16.Text = "E-Mail";
      this.txtEmail.BackColor = Color.White;
      this.txtEmail.Location = new Point(253, 107);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(282, 20);
      this.txtEmail.TabIndex = 33;
      this.btnBuscaCliente.Location = new Point(663, 16);
      this.btnBuscaCliente.Name = "btnBuscaCliente";
      this.btnBuscaCliente.Size = new Size(144, 23);
      this.btnBuscaCliente.TabIndex = 32;
      this.btnBuscaCliente.Text = "Buscar Pre-Cliente";
      this.btnBuscaCliente.UseVisualStyleBackColor = true;
      this.btnBuscaCliente.Click += new EventHandler(this.btnBuscaCliente_Click);
      this.txtContacto.BackColor = Color.White;
      this.txtContacto.Location = new Point(392, 63);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(415, 20);
      this.txtContacto.TabIndex = 18;
      this.label12.AutoSize = true;
      this.label12.Location = new Point(336, 67);
      this.label12.Name = "label12";
      this.label12.Size = new Size(50, 13);
      this.label12.TabIndex = 17;
      this.label12.Text = "Contacto";
      this.label12.TextAlign = ContentAlignment.TopRight;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(23, 111);
      this.label10.Name = "label10";
      this.label10.Size = new Size(31, 13);
      this.label10.TabIndex = 15;
      this.label10.Text = "Fono";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(30, 67);
      this.label9.Name = "label9";
      this.label9.Size = new Size(26, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Giro";
      this.label9.TextAlign = ContentAlignment.TopRight;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(538, 45);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Ciudad";
      this.label8.TextAlign = ContentAlignment.TopRight;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(340, 45);
      this.label7.Name = "label7";
      this.label7.Size = new Size(46, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Comuna";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(4, 45);
      this.label6.Name = "label6";
      this.label6.Size = new Size(52, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Dirección";
      this.label6.TextAlign = ContentAlignment.TopRight;
      this.txtFono.BackColor = Color.White;
      this.txtFono.Location = new Point(60, 107);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(143, 20);
      this.txtFono.TabIndex = 9;
      this.txtGiro.BackColor = Color.White;
      this.txtGiro.Location = new Point(60, 63);
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new Size(276, 20);
      this.txtGiro.TabIndex = 8;
      this.txtCiudad.BackColor = Color.White;
      this.txtCiudad.Location = new Point(580, 41);
      this.txtCiudad.Name = "txtCiudad";
      this.txtCiudad.Size = new Size(227, 20);
      this.txtCiudad.TabIndex = 7;
      this.txtComuna.BackColor = Color.White;
      this.txtComuna.Location = new Point(392, 41);
      this.txtComuna.Name = "txtComuna";
      this.txtComuna.Size = new Size(143, 20);
      this.txtComuna.TabIndex = 6;
      this.txtDireccion.BackColor = Color.White;
      this.txtDireccion.Location = new Point(60, 41);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new Size(276, 20);
      this.txtDireccion.TabIndex = 5;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(181, 23);
      this.label5.Name = "label5";
      this.label5.Size = new Size(70, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Razon Social";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(26, 23);
      this.label4.Name = "label4";
      this.label4.Size = new Size(30, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "RUT";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.txtRazonSocial.Location = new Point(257, 19);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(400, 20);
      this.txtRazonSocial.TabIndex = 8;
      this.txtRazonSocial.TextChanged += new EventHandler(this.txtRazonSocial_TextChanged);
      this.txtRazonSocial.KeyDown += new KeyEventHandler(this.txtRazonSocial_KeyDown);
      this.txtDigito.Location = new Point(132, 19);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 7;
      this.txtRut.Location = new Point(60, 19);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(68, 20);
      this.txtRut.TabIndex = 6;
      this.btnOt.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnOt.Location = new Point(644, 198);
      this.btnOt.Name = "btnOt";
      this.btnOt.Size = new Size(169, 23);
      this.btnOt.TabIndex = 28;
      this.btnOt.Text = "Ingresar Atencion";
      this.btnOt.UseVisualStyleBackColor = true;
      this.btnOt.Click += new EventHandler(this.btnOt_Click);
      this.groupBox2.Controls.Add((Control) this.tabControl2);
      this.groupBox2.Location = new Point(6, 221);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(815, 311);
      this.groupBox2.TabIndex = 31;
      this.groupBox2.TabStop = false;
      this.tabControl2.Controls.Add((Control) this.tabPage5);
      this.tabControl2.Controls.Add((Control) this.tabPage6);
      this.tabControl2.Location = new Point(7, 19);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(800, 286);
      this.tabControl2.TabIndex = 1;
      this.tabPage5.Controls.Add((Control) this.dgvOt);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(792, 260);
      this.tabPage5.TabIndex = 0;
      this.tabPage5.Text = "Atenciones";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.dgvOt.AllowUserToAddRows = false;
      this.dgvOt.AllowUserToDeleteRows = false;
      gridViewCellStyle3.BackColor = Color.Lavender;
      this.dgvOt.AlternatingRowsDefaultCellStyle = gridViewCellStyle3;
      this.dgvOt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvOt.Columns.AddRange((DataGridViewColumn) this.IdOrden, (DataGridViewColumn) this.Fecha, (DataGridViewColumn) this.FechaAtencion, (DataGridViewColumn) this.Vendedor, (DataGridViewColumn) this.Observacion, (DataGridViewColumn) this.Estado);
      this.dgvOt.Location = new Point(3, 6);
      this.dgvOt.Name = "dgvOt";
      this.dgvOt.ReadOnly = true;
      this.dgvOt.RowHeadersVisible = false;
      this.dgvOt.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvOt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvOt.Size = new Size(783, 248);
      this.dgvOt.TabIndex = 0;
      this.dgvOt.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvOt_CellDoubleClick);
      this.IdOrden.DataPropertyName = "IdOrdenAtencion";
      this.IdOrden.HeaderText = "IdOrden";
      this.IdOrden.Name = "IdOrden";
      this.IdOrden.ReadOnly = true;
      this.IdOrden.Visible = false;
      this.Fecha.DataPropertyName = "FechaIngreso";
      gridViewCellStyle4.Format = "g";
      gridViewCellStyle4.NullValue = (object) null;
      this.Fecha.DefaultCellStyle = gridViewCellStyle4;
      this.Fecha.HeaderText = "Fecha";
      this.Fecha.Name = "Fecha";
      this.Fecha.ReadOnly = true;
      this.Fecha.Resizable = DataGridViewTriState.False;
      this.FechaAtencion.DataPropertyName = "FechaAtencion";
      gridViewCellStyle5.Format = "g";
      gridViewCellStyle5.NullValue = (object) null;
      this.FechaAtencion.DefaultCellStyle = gridViewCellStyle5;
      this.FechaAtencion.HeaderText = "FechaAtencion";
      this.FechaAtencion.Name = "FechaAtencion";
      this.FechaAtencion.ReadOnly = true;
      this.Vendedor.DataPropertyName = "Tecnico";
      this.Vendedor.HeaderText = "Vendedor";
      this.Vendedor.Name = "Vendedor";
      this.Vendedor.ReadOnly = true;
      this.Vendedor.Width = 150;
      this.Observacion.DataPropertyName = "Requerimiento";
      this.Observacion.HeaderText = "Observacion";
      this.Observacion.Name = "Observacion";
      this.Observacion.ReadOnly = true;
      this.Observacion.Width = 320;
      this.Estado.DataPropertyName = "Estado";
      this.Estado.HeaderText = "Estado";
      this.Estado.Name = "Estado";
      this.Estado.ReadOnly = true;
      this.tabPage6.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage6.Controls.Add((Control) this.label30);
      this.tabPage6.Controls.Add((Control) this.dgvCotizaciones);
      this.tabPage6.Location = new Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new Padding(3);
      this.tabPage6.Size = new Size(792, 260);
      this.tabPage6.TabIndex = 1;
      this.tabPage6.Text = "Cotizaciones";
      this.label30.AutoSize = true;
      this.label30.Location = new Point(539, 231);
      this.label30.Name = "label30";
      this.label30.Size = new Size(174, 13);
      this.label30.TabIndex = 1;
      this.label30.Text = "Doble Click para mostrar Cotizacion";
      this.dgvCotizaciones.AllowUserToAddRows = false;
      this.dgvCotizaciones.AllowUserToDeleteRows = false;
      gridViewCellStyle6.BackColor = Color.Lavender;
      this.dgvCotizaciones.AlternatingRowsDefaultCellStyle = gridViewCellStyle6;
      this.dgvCotizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCotizaciones.Columns.AddRange((DataGridViewColumn) this.FechaCotizacion, (DataGridViewColumn) this.FolioCotizacion, (DataGridViewColumn) this.TotalCotizacion, (DataGridViewColumn) this.VendedorCotizacion);
      this.dgvCotizaciones.Location = new Point(6, 6);
      this.dgvCotizaciones.Name = "dgvCotizaciones";
      this.dgvCotizaciones.ReadOnly = true;
      this.dgvCotizaciones.RowHeadersVisible = false;
      this.dgvCotizaciones.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvCotizaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvCotizaciones.Size = new Size(526, 248);
      this.dgvCotizaciones.TabIndex = 0;
      this.dgvCotizaciones.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvCotizaciones_CellDoubleClick);
      this.FechaCotizacion.DataPropertyName = "FechaEmision";
      gridViewCellStyle7.NullValue = (object) null;
      this.FechaCotizacion.DefaultCellStyle = gridViewCellStyle7;
      this.FechaCotizacion.HeaderText = "Fecha";
      this.FechaCotizacion.Name = "FechaCotizacion";
      this.FechaCotizacion.ReadOnly = true;
      this.FechaCotizacion.Width = 150;
      this.FolioCotizacion.DataPropertyName = "Folio";
      gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle8.Format = "N0";
      gridViewCellStyle8.NullValue = (object) null;
      this.FolioCotizacion.DefaultCellStyle = gridViewCellStyle8;
      this.FolioCotizacion.HeaderText = "Folio";
      this.FolioCotizacion.Name = "FolioCotizacion";
      this.FolioCotizacion.ReadOnly = true;
      this.TotalCotizacion.DataPropertyName = "Total";
      gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle9.Format = "N0";
      gridViewCellStyle9.NullValue = (object) "0";
      this.TotalCotizacion.DefaultCellStyle = gridViewCellStyle9;
      this.TotalCotizacion.HeaderText = "Total";
      this.TotalCotizacion.Name = "TotalCotizacion";
      this.TotalCotizacion.ReadOnly = true;
      this.VendedorCotizacion.DataPropertyName = "Vendedor";
      this.VendedorCotizacion.HeaderText = "Vendedor";
      this.VendedorCotizacion.Name = "VendedorCotizacion";
      this.VendedorCotizacion.ReadOnly = true;
      this.VendedorCotizacion.Width = 150;
      this.tabPage2.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage2.Controls.Add((Control) this.lblBuscando);
      this.tabPage2.Controls.Add((Control) this.panel1);
      this.tabPage2.Controls.Add((Control) this.label25);
      this.tabPage2.Controls.Add((Control) this.label24);
      this.tabPage2.Controls.Add((Control) this.txtCantidadRegistros);
      this.tabPage2.Controls.Add((Control) this.txtNumeroRegistros);
      this.tabPage2.Controls.Add((Control) this.groupBox4);
      this.tabPage2.Controls.Add((Control) this.dgvClientesFiltro);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(832, 566);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "BUSQUEDA DE CLIENTES";
      this.lblBuscando.BorderStyle = BorderStyle.FixedSingle;
      this.lblBuscando.Font = new Font("Arial", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblBuscando.ForeColor = Color.Red;
      this.lblBuscando.Location = new Point(221, 209);
      this.lblBuscando.Name = "lblBuscando";
      this.lblBuscando.Size = new Size(433, 102);
      this.lblBuscando.TabIndex = 37;
      this.lblBuscando.Text = "BUSCANDO.....";
      this.lblBuscando.TextAlign = ContentAlignment.MiddleCenter;
      this.panel1.BackColor = Color.White;
      this.panel1.BorderStyle = BorderStyle.FixedSingle;
      this.panel1.Controls.Add((Control) this.txtPaginaActual);
      this.panel1.Controls.Add((Control) this.txtPaginasTotal);
      this.panel1.Controls.Add((Control) this.btnPrimero);
      this.panel1.Controls.Add((Control) this.btnAtraz);
      this.panel1.Controls.Add((Control) this.btnUltimo);
      this.panel1.Controls.Add((Control) this.btnSiguiente);
      this.panel1.Location = new Point(273, 525);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(261, 35);
      this.panel1.TabIndex = 15;
      this.txtPaginaActual.BackColor = Color.White;
      this.txtPaginaActual.Location = new Point(81, 5);
      this.txtPaginaActual.Name = "txtPaginaActual";
      this.txtPaginaActual.ReadOnly = true;
      this.txtPaginaActual.Size = new Size(46, 20);
      this.txtPaginaActual.TabIndex = 13;
      this.txtPaginaActual.TabStop = false;
      this.txtPaginaActual.TextAlign = HorizontalAlignment.Center;
      this.txtPaginasTotal.BackColor = Color.White;
      this.txtPaginasTotal.Location = new Point(132, 5);
      this.txtPaginasTotal.Name = "txtPaginasTotal";
      this.txtPaginasTotal.ReadOnly = true;
      this.txtPaginasTotal.Size = new Size(46, 20);
      this.txtPaginasTotal.TabIndex = 14;
      this.txtPaginasTotal.TabStop = false;
      this.txtPaginasTotal.TextAlign = HorizontalAlignment.Center;
      this.btnPrimero.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnPrimero.ForeColor = Color.Black;
      this.btnPrimero.Location = new Point(8, 2);
      this.btnPrimero.Name = "btnPrimero";
      this.btnPrimero.Size = new Size(31, 27);
      this.btnPrimero.TabIndex = 9;
      this.btnPrimero.Text = "<<";
      this.btnPrimero.UseVisualStyleBackColor = true;
      this.btnPrimero.Click += new EventHandler(this.btnPrimero_Click);
      this.btnAtraz.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAtraz.ForeColor = Color.Black;
      this.btnAtraz.Location = new Point(44, 2);
      this.btnAtraz.Name = "btnAtraz";
      this.btnAtraz.Size = new Size(31, 27);
      this.btnAtraz.TabIndex = 10;
      this.btnAtraz.Text = "<";
      this.btnAtraz.UseVisualStyleBackColor = true;
      this.btnAtraz.Click += new EventHandler(this.btnAtraz_Click);
      this.btnUltimo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnUltimo.ForeColor = Color.Black;
      this.btnUltimo.Location = new Point(221, 2);
      this.btnUltimo.Name = "btnUltimo";
      this.btnUltimo.Size = new Size(31, 27);
      this.btnUltimo.TabIndex = 12;
      this.btnUltimo.Text = ">>";
      this.btnUltimo.UseVisualStyleBackColor = true;
      this.btnUltimo.Click += new EventHandler(this.btnUltimo_Click);
      this.btnSiguiente.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSiguiente.ForeColor = Color.Black;
      this.btnSiguiente.Location = new Point(186, 2);
      this.btnSiguiente.Name = "btnSiguiente";
      this.btnSiguiente.Size = new Size(31, 27);
      this.btnSiguiente.TabIndex = 11;
      this.btnSiguiente.Text = ">";
      this.btnSiguiente.UseVisualStyleBackColor = true;
      this.btnSiguiente.Click += new EventHandler(this.btnSiguiente_Click);
      this.label25.AutoSize = true;
      this.label25.Location = new Point(173, 530);
      this.label25.Name = "label25";
      this.label25.Size = new Size(19, 13);
      this.label25.TabIndex = 8;
      this.label25.Text = "de";
      this.label24.AutoSize = true;
      this.label24.Location = new Point(9, 530);
      this.label24.Name = "label24";
      this.label24.Size = new Size(109, 13);
      this.label24.TabIndex = 7;
      this.label24.Text = "Registros Retornados";
      this.txtCantidadRegistros.BackColor = Color.White;
      this.txtCantidadRegistros.Location = new Point(195, 527);
      this.txtCantidadRegistros.Name = "txtCantidadRegistros";
      this.txtCantidadRegistros.ReadOnly = true;
      this.txtCantidadRegistros.Size = new Size(72, 20);
      this.txtCantidadRegistros.TabIndex = 6;
      this.txtNumeroRegistros.BackColor = Color.White;
      this.txtNumeroRegistros.Location = new Point(121, 527);
      this.txtNumeroRegistros.Name = "txtNumeroRegistros";
      this.txtNumeroRegistros.ReadOnly = true;
      this.txtNumeroRegistros.Size = new Size(48, 20);
      this.txtNumeroRegistros.TabIndex = 5;
      this.groupBox4.BackColor = Color.FromArgb(223, 233, 245);
      this.groupBox4.Controls.Add((Control) this.cmbSemaforo);
      this.groupBox4.Controls.Add((Control) this.label14);
      this.groupBox4.Controls.Add((Control) this.cmbVendedor);
      this.groupBox4.Controls.Add((Control) this.label17);
      this.groupBox4.Controls.Add((Control) this.btnBuscaFiltro);
      this.groupBox4.Location = new Point(6, 5);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(820, 68);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Filtro";
      this.cmbSemaforo.DrawMode = DrawMode.OwnerDrawFixed;
      this.cmbSemaforo.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSemaforo.FormattingEnabled = true;
      this.cmbSemaforo.Location = new Point(176, 39);
      this.cmbSemaforo.Name = "cmbSemaforo";
      this.cmbSemaforo.Size = new Size(148, 21);
      this.cmbSemaforo.TabIndex = 35;
      this.cmbSemaforo.DrawItem += new DrawItemEventHandler(this.cmbSemaforo_DrawItem);
      this.label14.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.White;
      this.label14.Location = new Point(176, 21);
      this.label14.Name = "label14";
      this.label14.Size = new Size(148, 29);
      this.label14.TabIndex = 36;
      this.label14.Text = "Tipo de Cliente";
      this.cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVendedor.FormattingEnabled = true;
      this.cmbVendedor.Location = new Point(6, 39);
      this.cmbVendedor.Name = "cmbVendedor";
      this.cmbVendedor.Size = new Size(157, 21);
      this.cmbVendedor.TabIndex = 13;
      this.label17.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = Color.White;
      this.label17.Location = new Point(6, 21);
      this.label17.Name = "label17";
      this.label17.Size = new Size(157, 18);
      this.label17.TabIndex = 12;
      this.label17.Text = "Vendedor";
      this.btnBuscaFiltro.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaFiltro.Location = new Point(330, 37);
      this.btnBuscaFiltro.Name = "btnBuscaFiltro";
      this.btnBuscaFiltro.Size = new Size((int) sbyte.MaxValue, 23);
      this.btnBuscaFiltro.TabIndex = 1;
      this.btnBuscaFiltro.Text = "Buscar";
      this.btnBuscaFiltro.UseVisualStyleBackColor = true;
      this.btnBuscaFiltro.Click += new EventHandler(this.btnBuscaFiltro_Click);
      this.dgvClientesFiltro.AllowUserToAddRows = false;
      this.dgvClientesFiltro.AllowUserToDeleteRows = false;
      this.dgvClientesFiltro.AllowUserToResizeColumns = false;
      this.dgvClientesFiltro.AllowUserToResizeRows = false;
      gridViewCellStyle10.BackColor = Color.Lavender;
      this.dgvClientesFiltro.AlternatingRowsDefaultCellStyle = gridViewCellStyle10;
      this.dgvClientesFiltro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvClientesFiltro.Columns.AddRange((DataGridViewColumn) this.Linea, (DataGridViewColumn) this.CodigoCliente, (DataGridViewColumn) this.FechaCreacion, (DataGridViewColumn) this.RazonSocial, (DataGridViewColumn) this.Vendedor2, (DataGridViewColumn) this.Intentos, (DataGridViewColumn) this.TipoCliente);
      this.dgvClientesFiltro.Location = new Point(0, 79);
      this.dgvClientesFiltro.Name = "dgvClientesFiltro";
      this.dgvClientesFiltro.ReadOnly = true;
      this.dgvClientesFiltro.RowHeadersVisible = false;
      this.dgvClientesFiltro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvClientesFiltro.Size = new Size(820, 440);
      this.dgvClientesFiltro.TabIndex = 4;
      this.dgvClientesFiltro.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvClientesFiltro_CellDoubleClick);
      this.Linea.DataPropertyName = "Linea";
      this.Linea.HeaderText = "Linea";
      this.Linea.Name = "Linea";
      this.Linea.ReadOnly = true;
      this.Linea.Width = 50;
      this.CodigoCliente.DataPropertyName = "Codigo";
      this.CodigoCliente.HeaderText = "CodigoCliente";
      this.CodigoCliente.Name = "CodigoCliente";
      this.CodigoCliente.ReadOnly = true;
      this.CodigoCliente.Visible = false;
      this.FechaCreacion.DataPropertyName = "FechaCreacion";
      gridViewCellStyle11.Format = "d";
      gridViewCellStyle11.NullValue = (object) null;
      this.FechaCreacion.DefaultCellStyle = gridViewCellStyle11;
      this.FechaCreacion.HeaderText = "Fecha Creacion";
      this.FechaCreacion.Name = "FechaCreacion";
      this.FechaCreacion.ReadOnly = true;
      this.FechaCreacion.Width = 120;
      this.RazonSocial.DataPropertyName = "RazonSocial";
      this.RazonSocial.HeaderText = "RazonSocial";
      this.RazonSocial.Name = "RazonSocial";
      this.RazonSocial.ReadOnly = true;
      this.RazonSocial.Width = 350;
      this.Vendedor2.DataPropertyName = "Vendedor";
      this.Vendedor2.HeaderText = "Vendedor";
      this.Vendedor2.Name = "Vendedor2";
      this.Vendedor2.ReadOnly = true;
      this.Vendedor2.Width = 150;
      this.Intentos.DataPropertyName = "Intentos";
      gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.Intentos.DefaultCellStyle = gridViewCellStyle12;
      this.Intentos.HeaderText = "Intentos";
      this.Intentos.Name = "Intentos";
      this.Intentos.ReadOnly = true;
      this.Intentos.Width = 60;
      this.TipoCliente.DataPropertyName = "TipoCliente";
      this.TipoCliente.HeaderText = "TipoCliente";
      this.TipoCliente.Name = "TipoCliente";
      this.TipoCliente.ReadOnly = true;
      this.TipoCliente.Width = 70;
      this.tabPage3.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage3.Controls.Add((Control) this.groupBox1);
      this.tabPage3.Controls.Add((Control) this.groupBox3);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(832, 566);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "BUSQUEDA";
      this.groupBox1.BackColor = Color.FromArgb(223, 233, 245);
      this.groupBox1.Controls.Add((Control) this.rdbFechaAtencion);
      this.groupBox1.Controls.Add((Control) this.rdbFechaIngreso);
      this.groupBox1.Controls.Add((Control) this.cmbVendedorBusqueda);
      this.groupBox1.Controls.Add((Control) this.label15);
      this.groupBox1.Controls.Add((Control) this.cmbEstadoFiltro);
      this.groupBox1.Controls.Add((Control) this.dtpHastaFiltro);
      this.groupBox1.Controls.Add((Control) this.dtpDesdeFiltro);
      this.groupBox1.Controls.Add((Control) this.label21);
      this.groupBox1.Controls.Add((Control) this.label22);
      this.groupBox1.Controls.Add((Control) this.label23);
      this.groupBox1.Controls.Add((Control) this.btnBuscarOtBusqueda);
      this.groupBox1.Location = new Point(6, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(820, 102);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filtro";
      this.rdbFechaAtencion.AutoSize = true;
      this.rdbFechaAtencion.Location = new Point(7, 74);
      this.rdbFechaAtencion.Name = "rdbFechaAtencion";
      this.rdbFechaAtencion.Size = new Size(115, 17);
      this.rdbFechaAtencion.TabIndex = 15;
      this.rdbFechaAtencion.TabStop = true;
      this.rdbFechaAtencion.Text = "Fecha de Atención";
      this.rdbFechaAtencion.UseVisualStyleBackColor = true;
      this.rdbFechaIngreso.AutoSize = true;
      this.rdbFechaIngreso.Location = new Point(128, 74);
      this.rdbFechaIngreso.Name = "rdbFechaIngreso";
      this.rdbFechaIngreso.Size = new Size(108, 17);
      this.rdbFechaIngreso.TabIndex = 14;
      this.rdbFechaIngreso.TabStop = true;
      this.rdbFechaIngreso.Text = "Fecha de Ingreso";
      this.rdbFechaIngreso.UseVisualStyleBackColor = true;
      this.cmbVendedorBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVendedorBusqueda.FormattingEnabled = true;
      this.cmbVendedorBusqueda.Location = new Point(443, 41);
      this.cmbVendedorBusqueda.Name = "cmbVendedorBusqueda";
      this.cmbVendedorBusqueda.Size = new Size(157, 21);
      this.cmbVendedorBusqueda.TabIndex = 13;
      this.label15.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label15.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.White;
      this.label15.Location = new Point(443, 23);
      this.label15.Name = "label15";
      this.label15.Size = new Size(157, 18);
      this.label15.TabIndex = 12;
      this.label15.Text = "Vendedor";
      this.cmbEstadoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEstadoFiltro.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbEstadoFiltro.FormattingEnabled = true;
      this.cmbEstadoFiltro.Location = new Point(280, 41);
      this.cmbEstadoFiltro.Name = "cmbEstadoFiltro";
      this.cmbEstadoFiltro.Size = new Size(157, 22);
      this.cmbEstadoFiltro.TabIndex = 0;
      this.dtpHastaFiltro.CalendarFont = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpHastaFiltro.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpHastaFiltro.Format = DateTimePickerFormat.Short;
      this.dtpHastaFiltro.Location = new Point(143, 41);
      this.dtpHastaFiltro.Name = "dtpHastaFiltro";
      this.dtpHastaFiltro.Size = new Size(131, 22);
      this.dtpHastaFiltro.TabIndex = 3;
      this.dtpDesdeFiltro.CalendarFont = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpDesdeFiltro.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpDesdeFiltro.Format = DateTimePickerFormat.Short;
      this.dtpDesdeFiltro.Location = new Point(6, 41);
      this.dtpDesdeFiltro.Name = "dtpDesdeFiltro";
      this.dtpDesdeFiltro.Size = new Size(131, 22);
      this.dtpDesdeFiltro.TabIndex = 2;
      this.label21.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label21.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label21.ForeColor = Color.White;
      this.label21.Location = new Point(280, 23);
      this.label21.Name = "label21";
      this.label21.Size = new Size(157, 18);
      this.label21.TabIndex = 9;
      this.label21.Text = "Estado";
      this.label22.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label22.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label22.ForeColor = Color.White;
      this.label22.Location = new Point(143, 23);
      this.label22.Name = "label22";
      this.label22.Size = new Size(131, 18);
      this.label22.TabIndex = 8;
      this.label22.Text = "Hasta";
      this.label23.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label23.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.White;
      this.label23.Location = new Point(6, 23);
      this.label23.Name = "label23";
      this.label23.Size = new Size(131, 18);
      this.label23.TabIndex = 7;
      this.label23.Text = "Desde";
      this.btnBuscarOtBusqueda.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscarOtBusqueda.Location = new Point(606, 40);
      this.btnBuscarOtBusqueda.Name = "btnBuscarOtBusqueda";
      this.btnBuscarOtBusqueda.Size = new Size((int) sbyte.MaxValue, 23);
      this.btnBuscarOtBusqueda.TabIndex = 1;
      this.btnBuscarOtBusqueda.Text = "Buscar";
      this.btnBuscarOtBusqueda.UseVisualStyleBackColor = true;
      this.btnBuscarOtBusqueda.Click += new EventHandler(this.btnBuscarOtBusqueda_Click);
      this.groupBox3.Controls.Add((Control) this.dgvOtBusqueda);
      this.groupBox3.Location = new Point(9, 102);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(815, 426);
      this.groupBox3.TabIndex = 32;
      this.groupBox3.TabStop = false;
      this.dgvOtBusqueda.AllowUserToAddRows = false;
      this.dgvOtBusqueda.AllowUserToDeleteRows = false;
      gridViewCellStyle13.BackColor = Color.Lavender;
      this.dgvOtBusqueda.AlternatingRowsDefaultCellStyle = gridViewCellStyle13;
      this.dgvOtBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvOtBusqueda.Columns.AddRange((DataGridViewColumn) this.IdOrdenAtencionB, (DataGridViewColumn) this.FechaIngresoB, (DataGridViewColumn) this.FechaAtencionB, (DataGridViewColumn) this.Cliente, (DataGridViewColumn) this.IdClienteB, (DataGridViewColumn) this.VendedorB, (DataGridViewColumn) this.EstadoB, (DataGridViewColumn) this.ObservacionB);
      this.dgvOtBusqueda.Location = new Point(9, 16);
      this.dgvOtBusqueda.Name = "dgvOtBusqueda";
      this.dgvOtBusqueda.ReadOnly = true;
      this.dgvOtBusqueda.RowHeadersVisible = false;
      this.dgvOtBusqueda.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvOtBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvOtBusqueda.Size = new Size(798, 404);
      this.dgvOtBusqueda.TabIndex = 0;
      this.dgvOtBusqueda.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvOtBusqueda_CellDoubleClick);
      this.IdOrdenAtencionB.DataPropertyName = "IdOrdenAtencion";
      this.IdOrdenAtencionB.HeaderText = "IdOrden";
      this.IdOrdenAtencionB.Name = "IdOrdenAtencionB";
      this.IdOrdenAtencionB.ReadOnly = true;
      this.IdOrdenAtencionB.Visible = false;
      this.FechaIngresoB.DataPropertyName = "FechaIngreso";
      gridViewCellStyle14.Format = "g";
      gridViewCellStyle14.NullValue = (object) null;
      this.FechaIngresoB.DefaultCellStyle = gridViewCellStyle14;
      this.FechaIngresoB.HeaderText = "Fecha";
      this.FechaIngresoB.Name = "FechaIngresoB";
      this.FechaIngresoB.ReadOnly = true;
      this.FechaIngresoB.Resizable = DataGridViewTriState.False;
      this.FechaAtencionB.DataPropertyName = "FechaAtencion";
      gridViewCellStyle15.Format = "g";
      gridViewCellStyle15.NullValue = (object) null;
      this.FechaAtencionB.DefaultCellStyle = gridViewCellStyle15;
      this.FechaAtencionB.HeaderText = "FechaAtencion";
      this.FechaAtencionB.Name = "FechaAtencionB";
      this.FechaAtencionB.ReadOnly = true;
      this.Cliente.DataPropertyName = "RazonSocial";
      this.Cliente.HeaderText = "Cliente";
      this.Cliente.Name = "Cliente";
      this.Cliente.ReadOnly = true;
      this.Cliente.Width = 320;
      this.IdClienteB.DataPropertyName = "IdCliente";
      this.IdClienteB.HeaderText = "IdClienteB";
      this.IdClienteB.Name = "IdClienteB";
      this.IdClienteB.ReadOnly = true;
      this.IdClienteB.Visible = false;
      this.VendedorB.DataPropertyName = "Tecnico";
      this.VendedorB.HeaderText = "Vendedor";
      this.VendedorB.Name = "VendedorB";
      this.VendedorB.ReadOnly = true;
      this.VendedorB.Width = 150;
      this.EstadoB.DataPropertyName = "Estado";
      this.EstadoB.HeaderText = "Estado";
      this.EstadoB.Name = "EstadoB";
      this.EstadoB.ReadOnly = true;
      this.ObservacionB.DataPropertyName = "requerimiento";
      this.ObservacionB.HeaderText = "ObservacionB";
      this.ObservacionB.Name = "ObservacionB";
      this.ObservacionB.ReadOnly = true;
      this.ObservacionB.Visible = false;
      this.tabPage4.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage4.Controls.Add((Control) this.panel3);
      this.tabPage4.Controls.Add((Control) this.panel2);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(832, 566);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "INFORMES";
      this.panel3.Controls.Add((Control) this.btnFiltrar);
      this.panel3.Controls.Add((Control) this.cmbProcedencia);
      this.panel3.Controls.Add((Control) this.dtpHastaInforme);
      this.panel3.Controls.Add((Control) this.dtpDesdeInforme);
      this.panel3.Controls.Add((Control) this.label28);
      this.panel3.Controls.Add((Control) this.label29);
      this.panel3.Controls.Add((Control) this.cmbVendedorInforme);
      this.panel3.Controls.Add((Control) this.label27);
      this.panel3.Controls.Add((Control) this.label26);
      this.panel3.Location = new Point(7, 7);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(818, 60);
      this.panel3.TabIndex = 7;
      this.btnFiltrar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnFiltrar.Location = new Point(712, 10);
      this.btnFiltrar.Name = "btnFiltrar";
      this.btnFiltrar.Size = new Size(93, 40);
      this.btnFiltrar.TabIndex = 20;
      this.btnFiltrar.Text = "BUSCAR";
      this.btnFiltrar.UseVisualStyleBackColor = true;
      this.btnFiltrar.Click += new EventHandler(this.btnFiltrar_Click);
      this.cmbProcedencia.FormattingEnabled = true;
      this.cmbProcedencia.Items.AddRange(new object[9]
      {
        (object) "[TODOS]",
        (object) "EFRAN",
        (object) "EMAIL",
        (object) "ENTEL",
        (object) "FACEBOOK",
        (object) "FONO",
        (object) "PAGINA WEB",
        (object) "PYMETEC",
        (object) "RECOMENDADO"
      });
      this.cmbProcedencia.Location = new Point(234, 29);
      this.cmbProcedencia.Name = "cmbProcedencia";
      this.cmbProcedencia.Size = new Size(131, 21);
      this.cmbProcedencia.TabIndex = 6;
      this.dtpHastaInforme.CalendarFont = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpHastaInforme.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpHastaInforme.Format = DateTimePickerFormat.Short;
      this.dtpHastaInforme.Location = new Point(111, 28);
      this.dtpHastaInforme.Name = "dtpHastaInforme";
      this.dtpHastaInforme.Size = new Size(103, 22);
      this.dtpHastaInforme.TabIndex = 17;
      this.dtpDesdeInforme.CalendarFont = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpDesdeInforme.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpDesdeInforme.Format = DateTimePickerFormat.Short;
      this.dtpDesdeInforme.Location = new Point(3, 28);
      this.dtpDesdeInforme.Name = "dtpDesdeInforme";
      this.dtpDesdeInforme.Size = new Size(103, 22);
      this.dtpDesdeInforme.TabIndex = 16;
      this.label28.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label28.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label28.ForeColor = Color.White;
      this.label28.Location = new Point(111, 10);
      this.label28.Name = "label28";
      this.label28.Size = new Size(103, 18);
      this.label28.TabIndex = 19;
      this.label28.Text = "Hasta";
      this.label29.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label29.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label29.ForeColor = Color.White;
      this.label29.Location = new Point(3, 10);
      this.label29.Name = "label29";
      this.label29.Size = new Size(103, 18);
      this.label29.TabIndex = 18;
      this.label29.Text = "Desde";
      this.cmbVendedorInforme.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVendedorInforme.FormattingEnabled = true;
      this.cmbVendedorInforme.Location = new Point(373, 29);
      this.cmbVendedorInforme.Name = "cmbVendedorInforme";
      this.cmbVendedorInforme.Size = new Size(157, 21);
      this.cmbVendedorInforme.TabIndex = 15;
      this.label27.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label27.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label27.ForeColor = Color.White;
      this.label27.Location = new Point(373, 10);
      this.label27.Name = "label27";
      this.label27.Size = new Size(157, 27);
      this.label27.TabIndex = 14;
      this.label27.Text = "Vendedor";
      this.label26.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label26.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.White;
      this.label26.Location = new Point(234, 10);
      this.label26.Name = "label26";
      this.label26.Size = new Size(131, 27);
      this.label26.TabIndex = 8;
      this.label26.Text = "Procedencia";
      this.panel2.Controls.Add((Control) this.crvVisualizador);
      this.panel2.Location = new Point(6, 73);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(820, 487);
      this.panel2.TabIndex = 0;
      this.crvVisualizador.ActiveViewIndex = -1;
      this.crvVisualizador.BorderStyle = BorderStyle.Fixed3D;
      this.crvVisualizador.DisplayGroupTree = false;
      this.crvVisualizador.Dock = DockStyle.Fill;
      this.crvVisualizador.Location = new Point(0, 0);
      this.crvVisualizador.Name = "crvVisualizador";
      this.crvVisualizador.SelectionFormula = "";
      this.crvVisualizador.ShowCloseButton = false;
      this.crvVisualizador.ShowGroupTreeButton = false;
      this.crvVisualizador.ShowRefreshButton = false;
      this.crvVisualizador.Size = new Size(820, 487);
      this.crvVisualizador.TabIndex = 2;
      this.crvVisualizador.ViewTimeSelectionFormula = "";
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(854, 559);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(109, 40);
      this.btnSalir.TabIndex = 38;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Location = new Point(854, 513);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(109, 40);
      this.btnLimpiar.TabIndex = 37;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(969, 607);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.tabControl1);
      this.Name = "frmPreVentas";
      this.ShowIcon = false;
      this.Text = "Pre-Ventas";
      this.WindowState = FormWindowState.Maximized;
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.pnlBuscaClienteDes.ResumeLayout(false);
      ((ISupportInitialize) this.dgvBuscaCliente).EndInit();
      this.gbZonaCliente.ResumeLayout(false);
      this.gbZonaCliente.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      ((ISupportInitialize) this.dgvOt).EndInit();
      this.tabPage6.ResumeLayout(false);
      this.tabPage6.PerformLayout();
      ((ISupportInitialize) this.dgvCotizaciones).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      ((ISupportInitialize) this.dgvClientesFiltro).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      ((ISupportInitialize) this.dgvOtBusqueda).EndInit();
      this.tabPage4.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void cargaEstado()
    {
      CargaMaestros cargaMaestros = new CargaMaestros();
      List<BodegaVO> list = new List<BodegaVO>();
      this.cmbEstadoFiltro.DataSource = (object) cargaMaestros.listaEstadoOT();
      this.cmbEstadoFiltro.ValueMember = "IdBodega";
      this.cmbEstadoFiltro.DisplayMember = "NombreBodega";
      this.cmbEstadoFiltro.SelectedValue = (object) 1;
    }

    private void cargaVendedores()
    {
      Aptusoft.Vendedor vendedor = new Aptusoft.Vendedor();
      this.cmbVendedor.DataSource = (object) vendedor.listaVendedoresVenta();
      this.cmbVendedor.ValueMember = "idVendedor";
      this.cmbVendedor.DisplayMember = "nombre";
      this.cmbVendedor.SelectedValue = (object) 0;
      this.cmbVendedorBusqueda.DataSource = (object) vendedor.listaVendedoresVenta();
      this.cmbVendedorBusqueda.ValueMember = "idVendedor";
      this.cmbVendedorBusqueda.DisplayMember = "nombre";
      this.cmbVendedorBusqueda.SelectedValue = (object) 0;
      this.cmbVendedorInforme.DataSource = (object) vendedor.listaVendedoresVenta();
      this.cmbVendedorInforme.ValueMember = "idVendedor";
      this.cmbVendedorInforme.DisplayMember = "nombre";
      this.cmbVendedorInforme.SelectedValue = (object) 0;
    }

    private void iniciaFormulario()
    {
      this.cargaEstado();
      this.cargaVendedores();
      this.cargaColores();
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
      this.txtContacto.Clear();
      this.txtContacto.Enabled = false;
      this.txtFono.Clear();
      this.txtFono.Enabled = false;
      this.txtEmail.Clear();
      this.txtEmail.Enabled = false;
      this.txtFono2.Clear();
      this.txtFono2.Enabled = false;
      this.txtEmail2.Clear();
      this.txtEmail2.Enabled = false;
      this.txtFono3.Clear();
      this.txtFono3.Enabled = false;
      this.txtEmail3.Clear();
      this.txtEmail3.Enabled = false;
      this.txtVendedor.Clear();
      this.txtVendedor.Enabled = false;
      this.txtProcedencia.Clear();
      this.txtProcedencia.Enabled = false;
      this.txtTipoCliente.Clear();
      this.txtTipoCliente.Enabled = false;
      this.txtIntentos.Text = "0";
      this.btnOt.Enabled = false;
      this.btnFicha.Enabled = false;
      this.lblActivo.Visible = false;
      this.dgvOt.DataSource = (object) null;
      this.dgvClientesFiltro.DataSource = (object) null;
      this.dgvOtBusqueda.DataSource = (object) null;
      this.rdbFechaAtencion.Checked = true;
      this.rdbFechaIngreso.Checked = false;
      this.btnPrimero.Enabled = false;
      this.btnAtraz.Enabled = false;
      this.btnSiguiente.Enabled = false;
      this.btnUltimo.Enabled = false;
      this.lblBuscando.Visible = false;
      this.dgvCotizaciones.DataSource = (object) null;
      this.cmbProcedencia.SelectedIndex = 0;
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaPreClientes(ref this.intance, "preventa").ShowDialog();
    }

    public void buscaClienteCodigo(int cod)
    {
      ClienteVO clienteVo = new PreCliente().buscaCodigoCliente(cod);
      this.idCliente = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.txtDireccion.Text = clienteVo.Direccion;
      this.txtComuna.Text = clienteVo.Comuna;
      this.txtCiudad.Text = clienteVo.Ciudad;
      this.txtGiro.Text = clienteVo.Giro;
      this.txtContacto.Text = clienteVo.Contacto;
      this.txtFono.Text = clienteVo.Telefono;
      this.txtEmail.Text = clienteVo.Email;
      this.txtFono2.Text = clienteVo.Telefono2;
      this.txtEmail2.Text = clienteVo.Email2;
      this.txtFono3.Text = clienteVo.Telefono3;
      this.txtEmail3.Text = clienteVo.Email3;
      this.txtProcedencia.Text = clienteVo.Procedencia;
      this.txtVendedor.Text = clienteVo.Vendedor;
      this.txtTipoCliente.BackColor = Color.FromName(clienteVo.TipoCliente);
      if (clienteVo.Activo)
      {
        this.lblActivo.Visible = true;
        this.btnOt.Enabled = false;
        this.btnFicha.Enabled = true;
      }
      else
      {
        this.lblActivo.Visible = false;
        this.btnOt.Enabled = true;
        this.btnFicha.Enabled = true;
      }
      this.buscaOrdenes();
      if (this.txtRazonSocial.Text.Trim().Length <= 0)
        return;
      this.buscaCotizaciones();
    }

    public void buscaOrdenes()
    {
      List<OrdenAtencionVO> list = new AtencionPreVenta().listaOrden(this.idCliente);
      this.txtIntentos.Text = list.Count.ToString();
      this.dgvOt.DataSource = (object) list;
    }

    private void buscaCotizaciones()
    {
      this.dgvCotizaciones.DataSource = (object) null;
      this.dgvCotizaciones.DataSource = (object) new Cotizacion().buscaCotizacionRazonSocial(this.txtRazonSocial.Text.Trim());
    }

    private void btnOt_Click(object sender, EventArgs e)
    {
      int num = (int) new frmAtencionPreventa(new OrdenAtencionVO()
      {
        IdCliente = this.idCliente,
        Rut = this.txtRut.Text,
        Digito = this.txtDigito.Text,
        RazonSocial = this.txtRazonSocial.Text,
        Contacto = this.txtContacto.Text,
        Tecnico = this.txtVendedor.Text,
        Email = this.txtEmail.Text,
        Fono = this.txtFono.Text,
        Email2 = this.txtEmail2.Text,
        Fono2 = this.txtFono2.Text,
        Email3 = this.txtEmail3.Text,
        Fono3 = this.txtFono3.Text,
        FechaAtencion = DateTime.Now
      }, 0).ShowDialog();
    }

    private void dgvOt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvOt.RowCount <= 0)
        return;
      int num = (int) new frmAtencionPreventa(Convert.ToInt32(this.dgvOt.SelectedRows[0].Cells["IdOrden"].Value.ToString())).ShowDialog();
      this.buscaOrdenes();
    }

    private void btnBuscaFiltro_Click(object sender, EventArgs e)
    {
      this.lblBuscando.Visible = true;
      this.Refresh();
      string _busca = "WHERE";
      if (this.cmbVendedor.Text != "[SELECCIONE]")
        _busca = _busca + " vendedor='" + this.cmbVendedor.Text + "'";
      if (this.cmbSemaforo.Text != "White")
        _busca = !_busca.Equals("WHERE") ? _busca + " AND tipoCliente='" + this.cmbSemaforo.Text + "'" : _busca + " tipoCliente='" + this.cmbSemaforo.Text + "'";
      if (_busca.Equals("WHERE"))
        _busca = string.Empty;
      this.dgvClientesFiltro.DataSource = (object) null;
      this.dgvClientesFiltro.DataSource = (object) new PreCliente().buscaClienteFiltro(_busca);
      for (int index = 0; index < this.dgvClientesFiltro.RowCount; ++index)
      {
        string name = this.dgvClientesFiltro[6, index].Value.ToString();
        this.dgvClientesFiltro[6, index].Style.BackColor = Color.FromName(name);
      }
      this.txtNumeroRegistros.Text = this.dgvClientesFiltro.RowCount.ToString();
      this.txtCantidadRegistros.Text = new PreCliente().cantidadRegistros(_busca);
      this.txtPaginaActual.Text = "1";
      if (this.txtCantidadRegistros.Text.Trim().Length > 0)
      {
        this.txtPaginasTotal.Text = (Convert.ToInt32(this.txtCantidadRegistros.Text) % 1000 <= 0 ? Convert.ToInt32(this.txtCantidadRegistros.Text) / 1000 : Convert.ToInt32(this.txtCantidadRegistros.Text) / 1000 + 1).ToString("N0");
        if (Convert.ToInt32(this.txtCantidadRegistros.Text) > 1000)
        {
          this.btnPrimero.Enabled = false;
          this.btnAtraz.Enabled = false;
          this.btnSiguiente.Enabled = true;
          this.btnUltimo.Enabled = true;
        }
        else
        {
          this.btnPrimero.Enabled = false;
          this.btnAtraz.Enabled = false;
          this.btnSiguiente.Enabled = false;
          this.btnUltimo.Enabled = false;
          this.txtPaginaActual.Text = "1";
          this.txtPaginasTotal.Text = "1";
        }
      }
      this.lblBuscando.Visible = false;
    }

    private void dgvClientesFiltro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvClientesFiltro.RowCount <= 0)
        return;
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvClientesFiltro.SelectedRows[0].Cells["CodigoCliente"].Value.ToString()));
      this.tabControl1.SelectedIndex = 0;
    }

    private void cmbSemaforo_DrawItem(object sender, DrawItemEventArgs e)
    {
      Graphics graphics = e.Graphics;
      Rectangle bounds = e.Bounds;
      if (e.Index < 0)
        return;
      string str = ((ComboBox) sender).Items[e.Index].ToString();
      Font font = new Font("Arial", 9f, FontStyle.Regular);
      Brush brush = (Brush) new SolidBrush(Color.FromName(str));
      if (str.Equals("Red"))
        str = "Rojo";
      if (str.Equals("Green"))
        str = "Verde";
      if (str.Equals("Yellow"))
        str = "Amarillo";
      if (str.Equals("White"))
        str = "Todos";
      if (str.Equals("Blue"))
        str = "Azul";
      graphics.DrawString(str, font, Brushes.Black, (float) bounds.X, (float) bounds.Top);
      graphics.FillRectangle(brush, bounds.X + 80, bounds.Y + 5, bounds.Width + 10, bounds.Height - 4);
    }

    private void cargaColores()
    {
      foreach (PropertyInfo propertyInfo in typeof (Color).GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public))
      {
        if (propertyInfo.Name.Equals("Red") || propertyInfo.Name.Equals("Green") || (propertyInfo.Name.Equals("Yellow") || propertyInfo.Name.Equals("White")) || propertyInfo.Name.Equals("Blue"))
          this.cmbSemaforo.Items.Add((object) propertyInfo.Name);
      }
      this.cmbSemaforo.SelectedIndex = 3;
    }

    private void btnFicha_Click(object sender, EventArgs e)
    {
      int num = (int) new frmPreCliente(this.idCliente).ShowDialog();
    }

    private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
    {
      if (!this.pnlBuscaClienteDes.Visible || e.KeyCode != Keys.Down)
        return;
      this.dgvBuscaCliente.Focus();
    }

    private void txtRazonSocial_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRazonSocial.Text.Trim().Length > 0 && this.txtRut.Text.Trim().Length == 0 && this.idCliente == 0)
      {
        this.pnlBuscaClienteDes.Visible = true;
        List<ClienteVO> list = new PreCliente().buscaClienteDato(1, this.txtRazonSocial.Text.Trim());
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

    private void dgvBuscaCliente_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnBuscarOtBusqueda_Click(object sender, EventArgs e)
    {
      this.busquedaOrdenAtencionFiltro();
    }

    private void busquedaOrdenAtencionFiltro()
    {
      string str1 = this.dtpDesdeFiltro.Value.ToString("yyyy-MM-dd");
      string str2 = this.dtpHastaFiltro.Value.ToString("yyyy-MM-dd");
      string str3 = "estado='" + this.cmbEstadoFiltro.Text + "'";
      string str4 = this.cmbVendedorBusqueda.Text != "[SELECCIONE]" ? " AND vendedor='" + this.cmbVendedorBusqueda.Text + "' " : "";
      string filtro;
      if (this.rdbFechaAtencion.Checked)
        filtro = "WHERE DATE_FORMAT(fechaAtencion, '%Y-%m-%d') >= '" + str1 + "' AND DATE_FORMAT(fechaAtencion, '%Y-%m-%d') <= '" + str2 + "' AND " + str3 + str4;
      else
        filtro = "WHERE DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= '" + str1 + "' AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= '" + str2 + "' AND " + str3 + str4;
      this.dgvOtBusqueda.DataSource = (object) null;
      this.dgvOtBusqueda.DataSource = (object) new AtencionPreVenta().listaOrdenFiltro(filtro);
    }

    private void dgvOtBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvOtBusqueda.RowCount <= 0)
        return;
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvOtBusqueda.SelectedRows[0].Cells["IdClienteB"].Value.ToString()));
      this.tabControl1.SelectedIndex = 0;
    }

    private void btnSiguiente_Click(object sender, EventArgs e)
    {
      this.lblBuscando.Visible = true;
      this.Refresh();
      this.btnSiguiente.Enabled = false;
      string _busca = "WHERE";
      if (this.cmbVendedor.Text != "[SELECCIONE]")
        _busca = _busca + " vendedor='" + this.cmbVendedor.Text + "'";
      if (this.cmbSemaforo.Text != "White")
        _busca = !_busca.Equals("WHERE") ? _busca + " AND tipoCliente='" + this.cmbSemaforo.Text + "'" : _busca + " tipoCliente='" + this.cmbSemaforo.Text + "'";
      if (_busca.Equals("WHERE"))
        _busca = string.Empty;
      this.dgvClientesFiltro.DataSource = (object) null;
      int num1 = Convert.ToInt32(this.txtPaginaActual.Text) * 1000;
      this.dgvClientesFiltro.DataSource = (object) new PreCliente().buscaClientePagina(_busca, num1.ToString());
      for (int index = 0; index < this.dgvClientesFiltro.RowCount; ++index)
      {
        string name = this.dgvClientesFiltro[6, index].Value.ToString();
        this.dgvClientesFiltro[6, index].Style.BackColor = Color.FromName(name);
      }
      if (this.txtCantidadRegistros.Text.Trim().Length > 0)
      {
        TextBox textBox1 = this.txtNumeroRegistros;
        int num2 = this.dgvClientesFiltro.RowCount;
        string str1 = num2.ToString();
        textBox1.Text = str1;
        TextBox textBox2 = this.txtPaginaActual;
        num2 = Convert.ToInt32(this.txtPaginaActual.Text) + 1;
        string str2 = num2.ToString();
        textBox2.Text = str2;
      }
      this.lblBuscando.Visible = false;
      if (this.txtPaginaActual.Text == this.txtPaginasTotal.Text)
      {
        this.btnSiguiente.Enabled = false;
        this.btnUltimo.Enabled = false;
      }
      else
      {
        this.btnSiguiente.Enabled = true;
        this.btnUltimo.Enabled = true;
      }
      this.btnPrimero.Enabled = true;
      this.btnAtraz.Enabled = true;
    }

    private void btnUltimo_Click(object sender, EventArgs e)
    {
      int num1 = Convert.ToInt32(this.txtCantidadRegistros.Text) % 1000;
      this.lblBuscando.Visible = true;
      this.btnSiguiente.Enabled = false;
      this.btnUltimo.Enabled = false;
      this.Refresh();
      string _busca = "WHERE";
      if (this.cmbVendedor.Text != "[SELECCIONE]")
        _busca = _busca + " vendedor='" + this.cmbVendedor.Text + "'";
      if (this.cmbSemaforo.Text != "White")
        _busca = !_busca.Equals("WHERE") ? _busca + " AND tipoCliente='" + this.cmbSemaforo.Text + "'" : _busca + " tipoCliente='" + this.cmbSemaforo.Text + "'";
      if (_busca.Equals("WHERE"))
        _busca = string.Empty;
      this.dgvClientesFiltro.DataSource = (object) null;
      int num2 = num1 <= 0 ? Convert.ToInt32(this.txtCantidadRegistros.Text) - 1000 : Convert.ToInt32(this.txtCantidadRegistros.Text) - num1;
      this.dgvClientesFiltro.DataSource = (object) new PreCliente().buscaClientePagina(_busca, num2.ToString());
      for (int index = 0; index < this.dgvClientesFiltro.RowCount; ++index)
      {
        string name = this.dgvClientesFiltro[6, index].Value.ToString();
        this.dgvClientesFiltro[6, index].Style.BackColor = Color.FromName(name);
      }
      if (this.txtCantidadRegistros.Text.Trim().Length > 0)
      {
        if (num1 > 0)
          this.txtNumeroRegistros.Text = num1.ToString();
        this.txtPaginaActual.Text = this.txtPaginasTotal.Text;
      }
      this.lblBuscando.Visible = false;
      this.btnPrimero.Enabled = true;
      this.btnAtraz.Enabled = true;
    }

    private void btnAtraz_Click(object sender, EventArgs e)
    {
      this.lblBuscando.Visible = true;
      this.Refresh();
      this.btnAtraz.Enabled = false;
      string _busca = "WHERE";
      if (this.cmbVendedor.Text != "[SELECCIONE]")
        _busca = _busca + " vendedor='" + this.cmbVendedor.Text + "'";
      if (this.cmbSemaforo.Text != "White")
        _busca = !_busca.Equals("WHERE") ? _busca + " AND tipoCliente='" + this.cmbSemaforo.Text + "'" : _busca + " tipoCliente='" + this.cmbSemaforo.Text + "'";
      if (_busca.Equals("WHERE"))
        _busca = string.Empty;
      this.dgvClientesFiltro.DataSource = (object) null;
      int num = (Convert.ToInt32(this.txtPaginaActual.Text) - 2) * 1000;
      this.dgvClientesFiltro.DataSource = (object) new PreCliente().buscaClientePagina(_busca, num.ToString());
      for (int index = 0; index < this.dgvClientesFiltro.RowCount; ++index)
      {
        string name = this.dgvClientesFiltro[6, index].Value.ToString();
        this.dgvClientesFiltro[6, index].Style.BackColor = Color.FromName(name);
      }
      if (this.txtCantidadRegistros.Text.Trim().Length > 0)
      {
        this.txtNumeroRegistros.Text = "1000";
        this.txtPaginaActual.Text = (Convert.ToInt32(this.txtPaginaActual.Text) - 1).ToString();
      }
      if (this.txtPaginaActual.Text.Equals("1"))
      {
        this.btnAtraz.Enabled = false;
        this.btnPrimero.Enabled = false;
      }
      else
      {
        this.btnAtraz.Enabled = true;
        this.btnPrimero.Enabled = true;
      }
      if (this.txtPaginaActual.Text == this.txtPaginasTotal.Text)
      {
        this.btnSiguiente.Enabled = false;
        this.btnUltimo.Enabled = false;
      }
      else
      {
        this.btnSiguiente.Enabled = true;
        this.btnUltimo.Enabled = true;
      }
      this.lblBuscando.Visible = false;
    }

    private void btnPrimero_Click(object sender, EventArgs e)
    {
      this.lblBuscando.Visible = true;
      this.Refresh();
      string _busca = "WHERE";
      if (this.cmbVendedor.Text != "[SELECCIONE]")
        _busca = _busca + " vendedor='" + this.cmbVendedor.Text + "'";
      if (this.cmbSemaforo.Text != "White")
        _busca = !_busca.Equals("WHERE") ? _busca + " AND tipoCliente='" + this.cmbSemaforo.Text + "'" : _busca + " tipoCliente='" + this.cmbSemaforo.Text + "'";
      if (_busca.Equals("WHERE"))
        _busca = string.Empty;
      this.dgvClientesFiltro.DataSource = (object) null;
      this.dgvClientesFiltro.DataSource = (object) new PreCliente().buscaClienteFiltro(_busca);
      for (int index = 0; index < this.dgvClientesFiltro.RowCount; ++index)
      {
        string name = this.dgvClientesFiltro[6, index].Value.ToString();
        this.dgvClientesFiltro[6, index].Style.BackColor = Color.FromName(name);
      }
      this.txtNumeroRegistros.Text = this.dgvClientesFiltro.RowCount.ToString();
      this.txtCantidadRegistros.Text = new PreCliente().cantidadRegistros(_busca);
      this.txtPaginaActual.Text = "1";
      if (this.txtCantidadRegistros.Text.Trim().Length > 0)
      {
        this.txtPaginasTotal.Text = (Convert.ToInt32(this.txtCantidadRegistros.Text) % 1000 <= 0 ? Convert.ToInt32(this.txtCantidadRegistros.Text) / 1000 : Convert.ToInt32(this.txtCantidadRegistros.Text) / 1000 + 1).ToString("N0");
        if (Convert.ToInt32(this.txtCantidadRegistros.Text) > 1000)
        {
          this.btnPrimero.Enabled = false;
          this.btnAtraz.Enabled = false;
          this.btnSiguiente.Enabled = true;
          this.btnUltimo.Enabled = true;
        }
        else
        {
          this.btnPrimero.Enabled = false;
          this.btnAtraz.Enabled = false;
          this.btnSiguiente.Enabled = false;
          this.btnUltimo.Enabled = false;
          this.txtPaginaActual.Text = "1";
          this.txtPaginasTotal.Text = "1";
        }
      }
      this.lblBuscando.Visible = false;
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
      string filtro = "DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= '" + this.dtpDesdeInforme.Value.ToString("yyyy-MM-dd") + "' AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= '" + this.dtpHastaInforme.Value.ToString("yyyy-MM-dd") + "'";
      if (this.cmbProcedencia.Text != "[TODOS]")
        filtro = filtro + " AND procedencia = '" + this.cmbProcedencia.Text + "'";
      if (this.cmbVendedorInforme.Text != "[SELECCIONE]")
        filtro = filtro + " AND orden_preventa.vendedor = '" + this.cmbVendedorInforme.Text + "'";
      string str = "Interno.rpt";
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = new AtencionPreVenta().preventaInforme(filtro);
      try
      {
        ReportDocument reportDocument = new ReportDocument();
        reportDocument.Load("C:\\AptuSoft\\reportes\\" + str);
        reportDocument.SetDataSource(dataTable2);
        this.crvVisualizador.ReportSource = (object) reportDocument;
        this.crvVisualizador.RefreshReport();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void dgvCotizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvCotizaciones.RowCount <= 0)
        return;
      int num = (int) new frmCotizacion(this.dgvCotizaciones.SelectedRows[0].Cells["FolioCotizacion"].Value.ToString()).ShowDialog();
    }
  }
}
