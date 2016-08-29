 
// Type: Aptusoft.frmDevolucion
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Formularios;
using Aptusoft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmDevolucion : Form
  {
    private IContainer components = (IContainer) null;
    private DatosVentaVO datosVO = new DatosVentaVO();
    private int idDevolucion = 0;
    private string _tipoBoleta = "";
    private int _idBoletaFiscal = 0;
    private int _idBoletaVoucher = 0;
    private List<DatosDevolucionVO> listaReponer = new List<DatosDevolucionVO>();
    private List<DatosDevolucionVO> listaSacar = new List<DatosDevolucionVO>();
    private int _caja = 0;
    private int _cajaBoleta = 0;
    private int _bodega = 0;
    private int _listaPrecio = 0;
    private Decimal _cantBoleta = new Decimal(0);
    private int idImpuesto = 0;
    private Decimal netoLinea = new Decimal(0);
    private Decimal valorCompra = new Decimal(0);
    private bool esExento = false;
    private DateTimePicker dtpFecha;
    private TextBox txtFolioBoleta;
    private Label label1;
    private Label labelTituloNumero;
    private Panel panelZonaDetalle;
    private DataGridView dgvDatosReponer;
    private Label label3;
    private Label label4;
    private TextBox txtNumeroDocumento;
    private DataGridView dgvDatosSacar;
    private Label label5;
    private RadioButton rdbSacar;
    private RadioButton rdbReponer;
    private Panel panel1;
    private TextBox txtDescuento;
    private TextBox txtPrecio;
    private TextBox txtDescripcion;
    private TextBox txtTipoDescuento;
    private TextBox txtSubTotalLinea;
    private Button btnLimpiaLineaDetalle;
    private Button btnModificaLinea;
    private TextBox txtLinea;
    private Panel panel3;
    private TextBox txtPorcDescuentoLinea;
    private Label label15;
    private Label label17;
    private Label label19;
    private TextBox txtCodigo;
    private Label label20;
    private TextBox txtCantidad;
    private Label label21;
    private CheckBox chkCantidadFija;
    private ComboBox cmbBodega;
    private Button btnAgregar;
    private ComboBox cmbListaPrecio;
    private Label label22;
    private Button btnLimpiaDetalle;
    private Label label23;
    private TextBox txtTotalLinea;
    private Label label24;
    private Label label25;
    private Label label6;
    private TextBox txtTotal;
    private ComboBox cmbVendedor;
    private Label label27;
    private Button btnImprime;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnModificar;
    private Panel panelFolio;
    private Button btnCerrarPanelFolio;
    private Button btnBuscaFolio;
    private TextBox txtFolioBuscar;
    private Label label32;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem;
    private ToolStripMenuItem buscarDevolucionF6ToolStripMenuItem;
    private Panel panelInicio;
    private Label lblTitulo;
    private Label lblCantidad;
    private Label label7;
    private TextBox txtCaja;
    private ToolStripMenuItem buscarProductosTeclaF4ToolStripMenuItem;
    private Button btnVerDevolucionesDeBoleta;
    private Label lblAlerta;
    private GroupBox gpbTipoBoleta;
    private Button btnBoletaFiscal;
    private Button btnBoletaNormal;
    private Panel panel2;
    private Label label2;
    private ComboBox cmbTipoDocumento;
    private Button btnAceptar;
    private RadioButton rdbEGuia;
    private RadioButton rdbEFactura;
    private RadioButton rdbFiscal;
    private RadioButton rdbBoleta;
    private TextBox temp;
    private frmDevolucion intance;

    public frmDevolucion()
    {
      this.InitializeComponent();
      this.intance = this;
      this.creaColumnasDetalle(this.dgvDatosReponer);
      this.creaColumnasDetalle(this.dgvDatosSacar);
      this.cargaPermisos();
      this.iniciaFormulario();
      this.txtFolioBoleta.Focus();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtFolioBoleta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTituloNumero = new System.Windows.Forms.Label();
            this.panelZonaDetalle = new System.Windows.Forms.Panel();
            this.dgvDatosSacar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDatosReponer = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.rdbReponer = new System.Windows.Forms.RadioButton();
            this.rdbSacar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTipoDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotalLinea = new System.Windows.Forms.TextBox();
            this.btnLimpiaLineaDetalle = new System.Windows.Forms.Button();
            this.btnModificaLinea = new System.Windows.Forms.Button();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPorcDescuentoLinea = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkCantidadFija = new System.Windows.Forms.CheckBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnLimpiaDetalle = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTotalLinea = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnImprime = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelFolio = new System.Windows.Forms.Panel();
            this.btnCerrarPanelFolio = new System.Windows.Forms.Button();
            this.btnBuscaFolio = new System.Windows.Forms.Button();
            this.txtFolioBuscar = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDevolucionF6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosTeclaF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.btnVerDevolucionesDeBoleta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbTipoBoleta = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rdbEGuia = new System.Windows.Forms.RadioButton();
            this.rdbEFactura = new System.Windows.Forms.RadioButton();
            this.rdbFiscal = new System.Windows.Forms.RadioButton();
            this.rdbBoleta = new System.Windows.Forms.RadioButton();
            this.btnBoletaFiscal = new System.Windows.Forms.Button();
            this.btnBoletaNormal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.temp = new System.Windows.Forms.TextBox();
            this.panelZonaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosSacar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosReponer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelFolio.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelInicio.SuspendLayout();
            this.gpbTipoBoleta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(7, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(94, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // txtFolioBoleta
            // 
            this.txtFolioBoleta.Location = new System.Drawing.Point(336, 27);
            this.txtFolioBoleta.Name = "txtFolioBoleta";
            this.txtFolioBoleta.Size = new System.Drawing.Size(76, 20);
            this.txtFolioBoleta.TabIndex = 2;
            this.txtFolioBoleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioBoleta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Devolución";
            // 
            // labelTituloNumero
            // 
            this.labelTituloNumero.AutoSize = true;
            this.labelTituloNumero.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloNumero.Location = new System.Drawing.Point(336, 8);
            this.labelTituloNumero.Name = "labelTituloNumero";
            this.labelTituloNumero.Size = new System.Drawing.Size(77, 13);
            this.labelTituloNumero.TabIndex = 3;
            this.labelTituloNumero.Text = "N° Documento";
            // 
            // panelZonaDetalle
            // 
            this.panelZonaDetalle.Controls.Add(this.dgvDatosSacar);
            this.panelZonaDetalle.Controls.Add(this.label5);
            this.panelZonaDetalle.Controls.Add(this.dgvDatosReponer);
            this.panelZonaDetalle.Controls.Add(this.label3);
            this.panelZonaDetalle.Location = new System.Drawing.Point(4, 211);
            this.panelZonaDetalle.Name = "panelZonaDetalle";
            this.panelZonaDetalle.Size = new System.Drawing.Size(900, 241);
            this.panelZonaDetalle.TabIndex = 28;
            // 
            // dgvDatosSacar
            // 
            this.dgvDatosSacar.AllowUserToAddRows = false;
            this.dgvDatosSacar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDatosSacar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatosSacar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.dgvDatosSacar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosSacar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatosSacar.Location = new System.Drawing.Point(1, 140);
            this.dgvDatosSacar.MultiSelect = false;
            this.dgvDatosSacar.Name = "dgvDatosSacar";
            this.dgvDatosSacar.ReadOnly = true;
            this.dgvDatosSacar.RowHeadersVisible = false;
            this.dgvDatosSacar.RowHeadersWidth = 50;
            this.dgvDatosSacar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosSacar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosSacar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosSacar.Size = new System.Drawing.Size(896, 99);
            this.dgvDatosSacar.TabIndex = 36;
            this.dgvDatosSacar.TabStop = false;
            this.dgvDatosSacar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosSacar_CellClick);
            this.dgvDatosSacar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosSacar_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(1, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(896, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Productos a Sacar";
            // 
            // dgvDatosReponer
            // 
            this.dgvDatosReponer.AllowUserToAddRows = false;
            this.dgvDatosReponer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDatosReponer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatosReponer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.dgvDatosReponer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosReponer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatosReponer.Location = new System.Drawing.Point(1, 20);
            this.dgvDatosReponer.MultiSelect = false;
            this.dgvDatosReponer.Name = "dgvDatosReponer";
            this.dgvDatosReponer.ReadOnly = true;
            this.dgvDatosReponer.RowHeadersVisible = false;
            this.dgvDatosReponer.RowHeadersWidth = 50;
            this.dgvDatosReponer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosReponer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosReponer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosReponer.Size = new System.Drawing.Size(896, 99);
            this.dgvDatosReponer.TabIndex = 3;
            this.dgvDatosReponer.TabStop = false;
            this.dgvDatosReponer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosReponer_CellClick);
            this.dgvDatosReponer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosReponer_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(1, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(896, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Productos a Reponer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Devolución N°";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(789, 27);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDocumento.TabIndex = 31;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdbReponer
            // 
            this.rdbReponer.AutoSize = true;
            this.rdbReponer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReponer.ForeColor = System.Drawing.Color.Navy;
            this.rdbReponer.Location = new System.Drawing.Point(8, 4);
            this.rdbReponer.Name = "rdbReponer";
            this.rdbReponer.Size = new System.Drawing.Size(164, 19);
            this.rdbReponer.TabIndex = 34;
            this.rdbReponer.TabStop = true;
            this.rdbReponer.Text = "REPONER A BODEGA";
            this.rdbReponer.UseVisualStyleBackColor = true;
            this.rdbReponer.CheckedChanged += new System.EventHandler(this.rdbReponer_CheckedChanged);
            // 
            // rdbSacar
            // 
            this.rdbSacar.AutoSize = true;
            this.rdbSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSacar.ForeColor = System.Drawing.Color.Navy;
            this.rdbSacar.Location = new System.Drawing.Point(200, 4);
            this.rdbSacar.Name = "rdbSacar";
            this.rdbSacar.Size = new System.Drawing.Size(152, 19);
            this.rdbSacar.TabIndex = 35;
            this.rdbSacar.TabStop = true;
            this.rdbSacar.Text = "SACAR DE BODEGA";
            this.rdbSacar.UseVisualStyleBackColor = true;
            this.rdbSacar.CheckedChanged += new System.EventHandler(this.rdbSacar_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtTipoDescuento);
            this.panel1.Controls.Add(this.txtSubTotalLinea);
            this.panel1.Controls.Add(this.btnLimpiaLineaDetalle);
            this.panel1.Controls.Add(this.btnModificaLinea);
            this.panel1.Controls.Add(this.txtLinea);
            this.panel1.Controls.Add(this.rdbReponer);
            this.panel1.Controls.Add(this.rdbSacar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtPorcDescuentoLinea);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.chkCantidadFija);
            this.panel1.Controls.Add(this.cmbBodega);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.cmbListaPrecio);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.btnLimpiaDetalle);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtTotalLinea);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Location = new System.Drawing.Point(4, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 95);
            this.panel1.TabIndex = 63;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(562, 3);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 18);
            this.lblCantidad.TabIndex = 63;
            this.lblCantidad.Text = ".";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Location = new System.Drawing.Point(678, 42);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(77, 20);
            this.txtDescuento.TabIndex = 10;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(484, 42);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(112, 42);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(368, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtTipoDescuento
            // 
            this.txtTipoDescuento.Location = new System.Drawing.Point(582, 66);
            this.txtTipoDescuento.Name = "txtTipoDescuento";
            this.txtTipoDescuento.Size = new System.Drawing.Size(38, 20);
            this.txtTipoDescuento.TabIndex = 62;
            this.txtTipoDescuento.Text = "0";
            this.txtTipoDescuento.Visible = false;
            // 
            // txtSubTotalLinea
            // 
            this.txtSubTotalLinea.Location = new System.Drawing.Point(530, 66);
            this.txtSubTotalLinea.Name = "txtSubTotalLinea";
            this.txtSubTotalLinea.Size = new System.Drawing.Size(43, 20);
            this.txtSubTotalLinea.TabIndex = 61;
            this.txtSubTotalLinea.Visible = false;
            // 
            // btnLimpiaLineaDetalle
            // 
            this.btnLimpiaLineaDetalle.Location = new System.Drawing.Point(861, 27);
            this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
            this.btnLimpiaLineaDetalle.Size = new System.Drawing.Size(20, 34);
            this.btnLimpiaLineaDetalle.TabIndex = 59;
            this.btnLimpiaLineaDetalle.Text = "..";
            this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaLineaDetalle.Click += new System.EventHandler(this.btnLimpiaLineaDetalle_Click);
            // 
            // btnModificaLinea
            // 
            this.btnModificaLinea.Location = new System.Drawing.Point(691, 65);
            this.btnModificaLinea.Name = "btnModificaLinea";
            this.btnModificaLinea.Size = new System.Drawing.Size(75, 23);
            this.btnModificaLinea.TabIndex = 60;
            this.btnModificaLinea.Text = "Modificar";
            this.btnModificaLinea.UseVisualStyleBackColor = true;
            this.btnModificaLinea.Click += new System.EventHandler(this.btnModificaLinea_Click);
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(452, 66);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(71, 20);
            this.txtLinea.TabIndex = 58;
            this.txtLinea.Text = "NumeroLinea";
            this.txtLinea.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(638, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 36);
            this.panel3.TabIndex = 57;
            // 
            // txtPorcDescuentoLinea
            // 
            this.txtPorcDescuentoLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcDescuentoLinea.Location = new System.Drawing.Point(645, 42);
            this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
            this.txtPorcDescuentoLinea.Size = new System.Drawing.Size(31, 20);
            this.txtPorcDescuentoLinea.TabIndex = 9;
            this.txtPorcDescuentoLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoLinea.TextChanged += new System.EventHandler(this.txtPorcDescuentoLinea_TextChanged);
            this.txtPorcDescuentoLinea.Enter += new System.EventHandler(this.txtPorcDescuentoLinea_Enter);
            this.txtPorcDescuentoLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(112, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(368, 23);
            this.label15.TabIndex = 37;
            this.label15.Text = "Descripcion";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(645, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 23);
            this.label17.TabIndex = 56;
            this.label17.Text = "%";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(197, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "Lista de Precio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(5, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(678, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 23);
            this.label20.TabIndex = 40;
            this.label20.Text = "$ Descuento";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(562, 42);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(562, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 23);
            this.label21.TabIndex = 39;
            this.label21.Text = "Cantidad";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkCantidadFija
            // 
            this.chkCantidadFija.AutoSize = true;
            this.chkCantidadFija.Location = new System.Drawing.Point(621, 49);
            this.chkCantidadFija.Name = "chkCantidadFija";
            this.chkCantidadFija.Size = new System.Drawing.Size(15, 14);
            this.chkCantidadFija.TabIndex = 50;
            this.chkCantidadFija.UseVisualStyleBackColor = true;
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(58, 66);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(126, 21);
            this.cmbBodega.TabIndex = 51;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(771, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(55, 23);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(277, 66);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(126, 21);
            this.cmbListaPrecio.TabIndex = 53;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(484, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 23);
            this.label22.TabIndex = 38;
            this.label22.Text = "Precio";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLimpiaDetalle
            // 
            this.btnLimpiaDetalle.Location = new System.Drawing.Point(829, 64);
            this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
            this.btnLimpiaDetalle.Size = new System.Drawing.Size(55, 23);
            this.btnLimpiaDetalle.TabIndex = 52;
            this.btnLimpiaDetalle.Text = "Limpiar";
            this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaDetalle.Click += new System.EventHandler(this.btnLimpiaDetalle_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(5, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 23);
            this.label23.TabIndex = 36;
            this.label23.Text = "Codigo";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalLinea
            // 
            this.txtTotalLinea.BackColor = System.Drawing.Color.White;
            this.txtTotalLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalLinea.Enabled = false;
            this.txtTotalLinea.Location = new System.Drawing.Point(765, 42);
            this.txtTotalLinea.Name = "txtTotalLinea";
            this.txtTotalLinea.Size = new System.Drawing.Size(92, 20);
            this.txtTotalLinea.TabIndex = 48;
            this.txtTotalLinea.TabStop = false;
            this.txtTotalLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 69);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 54;
            this.label24.Text = "Bodega";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(765, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 23);
            this.label25.TabIndex = 41;
            this.label25.Text = "Total";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "MONTO CANCELAR:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(750, 9);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(133, 29);
            this.txtTotal.TabIndex = 65;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(422, 27);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(131, 21);
            this.cmbVendedor.TabIndex = 3;
            this.cmbVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVendedor_KeyDown);
            this.cmbVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbVendedor_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(422, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 67;
            this.label27.Text = "Vendedor";
            // 
            // btnImprime
            // 
            this.btnImprime.Image = global::Aptusoft.Properties.Resources.imprimir_48;
            this.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprime.Location = new System.Drawing.Point(295, 8);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(70, 70);
            this.btnImprime.TabIndex = 26;
            this.btnImprime.Text = "Imprime";
            this.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(367, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 70);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Aptusoft.Properties.Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(222, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpia";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Aptusoft.Properties.Resources.disquetes_excepto_icono_7120_48;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(3, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guarda";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Aptusoft.Properties.Resources.mark_correo_basura_icono_3897_48;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(149, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 70);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Elimina";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Aptusoft.Properties.Resources.modificar_48;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(76, 9);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 70);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modifica";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelFolio
            // 
            this.panelFolio.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFolio.Controls.Add(this.btnCerrarPanelFolio);
            this.panelFolio.Controls.Add(this.btnBuscaFolio);
            this.panelFolio.Controls.Add(this.txtFolioBuscar);
            this.panelFolio.Controls.Add(this.label32);
            this.panelFolio.Location = new System.Drawing.Point(730, 64);
            this.panelFolio.Name = "panelFolio";
            this.panelFolio.Size = new System.Drawing.Size(173, 92);
            this.panelFolio.TabIndex = 69;
            // 
            // btnCerrarPanelFolio
            // 
            this.btnCerrarPanelFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPanelFolio.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarPanelFolio.Location = new System.Drawing.Point(91, 59);
            this.btnCerrarPanelFolio.Name = "btnCerrarPanelFolio";
            this.btnCerrarPanelFolio.Size = new System.Drawing.Size(76, 25);
            this.btnCerrarPanelFolio.TabIndex = 24;
            this.btnCerrarPanelFolio.Text = "Cancelar";
            this.btnCerrarPanelFolio.UseVisualStyleBackColor = true;
            this.btnCerrarPanelFolio.Click += new System.EventHandler(this.btnCerrarPanelFolio_Click);
            // 
            // btnBuscaFolio
            // 
            this.btnBuscaFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaFolio.Location = new System.Drawing.Point(4, 59);
            this.btnBuscaFolio.Name = "btnBuscaFolio";
            this.btnBuscaFolio.Size = new System.Drawing.Size(76, 25);
            this.btnBuscaFolio.TabIndex = 2;
            this.btnBuscaFolio.Text = "Buscar";
            this.btnBuscaFolio.UseVisualStyleBackColor = true;
            this.btnBuscaFolio.Click += new System.EventHandler(this.btnBuscaFolio_Click);
            // 
            // txtFolioBuscar
            // 
            this.txtFolioBuscar.Location = new System.Drawing.Point(4, 33);
            this.txtFolioBuscar.Name = "txtFolioBuscar";
            this.txtFolioBuscar.Size = new System.Drawing.Size(162, 20);
            this.txtFolioBuscar.TabIndex = 1;
            this.txtFolioBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioBuscar_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(4, 8);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(164, 16);
            this.label32.TabIndex = 0;
            this.label32.Text = "Ingrese Folio a Buscar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 70;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarDevolucionF6ToolStripMenuItem,
            this.buscarProductosTeclaF4ToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarDevolucionF6ToolStripMenuItem
            // 
            this.buscarDevolucionF6ToolStripMenuItem.Name = "buscarDevolucionF6ToolStripMenuItem";
            this.buscarDevolucionF6ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.buscarDevolucionF6ToolStripMenuItem.Text = "Buscar Devolucion - tecla [F6]";
            this.buscarDevolucionF6ToolStripMenuItem.Click += new System.EventHandler(this.buscarDevolucionF6ToolStripMenuItem_Click);
            // 
            // buscarProductosTeclaF4ToolStripMenuItem
            // 
            this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
            this.buscarProductosTeclaF4ToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
            this.buscarProductosTeclaF4ToolStripMenuItem.Click += new System.EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panelInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInicio.Controls.Add(this.label2);
            this.panelInicio.Controls.Add(this.cmbTipoDocumento);
            this.panelInicio.Controls.Add(this.lblAlerta);
            this.panelInicio.Controls.Add(this.btnVerDevolucionesDeBoleta);
            this.panelInicio.Controls.Add(this.label7);
            this.panelInicio.Controls.Add(this.txtCaja);
            this.panelInicio.Controls.Add(this.cmbVendedor);
            this.panelInicio.Controls.Add(this.label27);
            this.panelInicio.Controls.Add(this.labelTituloNumero);
            this.panelInicio.Controls.Add(this.label1);
            this.panelInicio.Controls.Add(this.txtFolioBoleta);
            this.panelInicio.Controls.Add(this.txtNumeroDocumento);
            this.panelInicio.Controls.Add(this.dtpFecha);
            this.panelInicio.Controls.Add(this.label4);
            this.panelInicio.Location = new System.Drawing.Point(4, 28);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(897, 83);
            this.panelInicio.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(107, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.BackColor = System.Drawing.Color.White;
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "Boleta",
            "Boleta Fiscal",
            "Voucher",
            "Factura Electronica",
            "Guia Electronica"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(107, 27);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(136, 21);
            this.cmbTipoDocumento.TabIndex = 75;
            this.cmbTipoDocumento.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoDocumento_SelectionChangeCommitted);
            // 
            // lblAlerta
            // 
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta.Location = new System.Drawing.Point(553, 4);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(201, 29);
            this.lblAlerta.TabIndex = 74;
            this.lblAlerta.Text = "Este Documento ya Registra cambios de Productos";
            this.lblAlerta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVerDevolucionesDeBoleta
            // 
            this.btnVerDevolucionesDeBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDevolucionesDeBoleta.Location = new System.Drawing.Point(579, 34);
            this.btnVerDevolucionesDeBoleta.Name = "btnVerDevolucionesDeBoleta";
            this.btnVerDevolucionesDeBoleta.Size = new System.Drawing.Size(142, 42);
            this.btnVerDevolucionesDeBoleta.TabIndex = 73;
            this.btnVerDevolucionesDeBoleta.Text = "Ver Productos Cambiados";
            this.btnVerDevolucionesDeBoleta.UseVisualStyleBackColor = true;
            this.btnVerDevolucionesDeBoleta.Click += new System.EventHandler(this.btnVerDevolucionesDeBoleta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(249, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "N° Caja";
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(249, 27);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(76, 20);
            this.txtCaja.TabIndex = 1;
            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaja_KeyPress);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(533, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(358, 49);
            this.lblTitulo.TabIndex = 72;
            this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE BOLETA FISCAL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpbTipoBoleta
            // 
            this.gpbTipoBoleta.BackColor = System.Drawing.Color.GhostWhite;
            this.gpbTipoBoleta.Controls.Add(this.btnAceptar);
            this.gpbTipoBoleta.Controls.Add(this.rdbEGuia);
            this.gpbTipoBoleta.Controls.Add(this.rdbEFactura);
            this.gpbTipoBoleta.Controls.Add(this.rdbFiscal);
            this.gpbTipoBoleta.Controls.Add(this.rdbBoleta);
            this.gpbTipoBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoBoleta.Location = new System.Drawing.Point(407, 247);
            this.gpbTipoBoleta.Name = "gpbTipoBoleta";
            this.gpbTipoBoleta.Size = new System.Drawing.Size(197, 167);
            this.gpbTipoBoleta.TabIndex = 75;
            this.gpbTipoBoleta.TabStop = false;
            this.gpbTipoBoleta.Text = "Seleccione Tipo de Documento";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(33, 128);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rdbEGuia
            // 
            this.rdbEGuia.AutoSize = true;
            this.rdbEGuia.Location = new System.Drawing.Point(33, 103);
            this.rdbEGuia.Name = "rdbEGuia";
            this.rdbEGuia.Size = new System.Drawing.Size(115, 19);
            this.rdbEGuia.TabIndex = 5;
            this.rdbEGuia.TabStop = true;
            this.rdbEGuia.Text = "Guia Electronica";
            this.rdbEGuia.UseVisualStyleBackColor = true;
            // 
            // rdbEFactura
            // 
            this.rdbEFactura.AutoSize = true;
            this.rdbEFactura.Location = new System.Drawing.Point(33, 78);
            this.rdbEFactura.Name = "rdbEFactura";
            this.rdbEFactura.Size = new System.Drawing.Size(130, 19);
            this.rdbEFactura.TabIndex = 4;
            this.rdbEFactura.TabStop = true;
            this.rdbEFactura.Text = "Factura Electronica";
            this.rdbEFactura.UseVisualStyleBackColor = true;
            // 
            // rdbFiscal
            // 
            this.rdbFiscal.AutoSize = true;
            this.rdbFiscal.Location = new System.Drawing.Point(33, 53);
            this.rdbFiscal.Name = "rdbFiscal";
            this.rdbFiscal.Size = new System.Drawing.Size(95, 19);
            this.rdbFiscal.TabIndex = 3;
            this.rdbFiscal.TabStop = true;
            this.rdbFiscal.Text = "Boleta Fiscal";
            this.rdbFiscal.UseVisualStyleBackColor = true;
            // 
            // rdbBoleta
            // 
            this.rdbBoleta.AutoSize = true;
            this.rdbBoleta.Location = new System.Drawing.Point(33, 28);
            this.rdbBoleta.Name = "rdbBoleta";
            this.rdbBoleta.Size = new System.Drawing.Size(60, 19);
            this.rdbBoleta.TabIndex = 2;
            this.rdbBoleta.TabStop = true;
            this.rdbBoleta.Text = "Boleta";
            this.rdbBoleta.UseVisualStyleBackColor = true;
            // 
            // btnBoletaFiscal
            // 
            this.btnBoletaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletaFiscal.Location = new System.Drawing.Point(512, 34);
            this.btnBoletaFiscal.Name = "btnBoletaFiscal";
            this.btnBoletaFiscal.Size = new System.Drawing.Size(15, 43);
            this.btnBoletaFiscal.TabIndex = 1;
            this.btnBoletaFiscal.Text = "Boleta Fiscal";
            this.btnBoletaFiscal.UseVisualStyleBackColor = true;
            this.btnBoletaFiscal.Visible = false;
            this.btnBoletaFiscal.Click += new System.EventHandler(this.btnBoletaFiscal_Click);
            // 
            // btnBoletaNormal
            // 
            this.btnBoletaNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletaNormal.Location = new System.Drawing.Point(484, 34);
            this.btnBoletaNormal.Name = "btnBoletaNormal";
            this.btnBoletaNormal.Size = new System.Drawing.Size(22, 43);
            this.btnBoletaNormal.TabIndex = 0;
            this.btnBoletaNormal.Text = "Boleta Normal";
            this.btnBoletaNormal.UseVisualStyleBackColor = true;
            this.btnBoletaNormal.Visible = false;
            this.btnBoletaNormal.Click += new System.EventHandler(this.btnBoletaNormal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.temp);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnImprime);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.btnBoletaFiscal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnBoletaNormal);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Location = new System.Drawing.Point(4, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 104);
            this.panel2.TabIndex = 76;
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(556, 74);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(111, 20);
            this.temp.TabIndex = 73;
            this.temp.Visible = false;
            // 
            // frmDevolucion
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelFolio);
            this.Controls.Add(this.gpbTipoBoleta);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelZonaDetalle);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmDevolucion";
            this.ShowIcon = false;
            this.Text = "Devolución de Productos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDevolucion_KeyDown);
            this.panelZonaDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosSacar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosReponer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFolio.ResumeLayout(false);
            this.panelFolio.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.gpbTipoBoleta.ResumeLayout(false);
            this.gpbTipoBoleta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void iniciaFormulario()
    {
      this.idDevolucion = 0;
      this._cajaBoleta = 0;
      this.panelFolio.Visible = false;
      this._idBoletaVoucher = 0;
      this.panel1.Enabled = false;
      this.obtieneFolioDisponible();
      this.txtNumeroDocumento.Enabled = false;
      this.txtTotal.Clear();
      this.cmbVendedor.Enabled = false;
      this.cargaBodega();
      this.cargaVendedores();
      this.cargaListaPrecio();
      this.txtFolioBoleta.Enabled = true;
      this.txtFolioBoleta.Clear();
      this.rdbReponer.Checked = true;
      this.rdbReponer.Enabled = true;
      this.rdbSacar.Checked = false;
      this.rdbSacar.Enabled = true;
      this.listaReponer.Clear();
      this.dgvDatosReponer.DataSource = (object) null;
      this.listaSacar.Clear();
      this.dgvDatosSacar.DataSource = (object) null;
      this.iniciaLinea();
      this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnImprime.Enabled = false;
      this.txtCaja.Text = this._caja.ToString();
      this.txtCaja.Enabled = true;
      this.btnVerDevolucionesDeBoleta.Visible = false;
      this.lblAlerta.Visible = false;
      this.cmbTipoDocumento.SelectedIndex = 0;
      this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE BOLETA";
      this._tipoBoleta = "NORMAL";
      this.rdbBoleta.Checked = true;
      this.rdbFiscal.Checked = false;
      this.rdbEFactura.Checked = false;
      this.rdbEGuia.Checked = false;
      this.txtFolioBoleta.Focus();
      this.gpbTipoBoleta.Visible = false;
    }

    private void iniciaLinea()
    {
      this.rdbReponer.Enabled = true;
      this.rdbSacar.Enabled = true;
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Enabled = true;
      this.btnLimpiaDetalle.Enabled = true;
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      if (!this.chkCantidadFija.Checked)
        this.txtCantidad.Clear();
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtPrecio.Clear();
      this.txtPorcDescuentoLinea.Clear();
      this.txtDescuento.Clear();
      this.txtTotalLinea.Clear();
      this.txtCodigo.Focus();
      this.idImpuesto = 0;
      this.netoLinea = new Decimal(0);
      this.valorCompra = new Decimal(0);
      this._cantBoleta = new Decimal(0);
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("BOLETA"))
        {
          this._caja = usuarioVo.IdCaja;
          this._bodega = usuarioVo.IdBodega;
          this._listaPrecio = usuarioVo.IdListaPrecio;
        }
      }
    }

    private void obtieneFolioDisponible()
    {
      this.txtNumeroDocumento.Text = new Devolucion().numeroDevolucion(this._caja).ToString();
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
      }
      else
      {
        this.cmbBodega.Enabled = false;
        this.cmbBodega.SelectedValue = (object) this._bodega;
      }
    }

    private void cargaVendedores()
    {
      this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
      this.cmbVendedor.ValueMember = "idVendedor";
      this.cmbVendedor.DisplayMember = "nombre";
      this.cmbVendedor.SelectedValue = (object) 0;
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

    private void creaColumnasDetalle(DataGridView dgv)
    {
      dgv.AutoGenerateColumns = false;
      dgv.Columns.Add("Linea", "");
      dgv.Columns[0].DataPropertyName = "Linea";
      dgv.Columns[0].Width = 20;
      dgv.Columns[0].Resizable = DataGridViewTriState.False;
      dgv.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
      dgv.Columns.Add("Codigo", "Codigo");
      dgv.Columns[1].DataPropertyName = "Codigo";
      dgv.Columns[1].Width = 100;
      dgv.Columns[1].Resizable = DataGridViewTriState.False;
      dgv.Columns.Add("Descripcion", "Descripcion");
      dgv.Columns[2].DataPropertyName = "Descripcion";
      dgv.Columns[2].Width = 330;
      dgv.Columns[2].Resizable = DataGridViewTriState.False;
      dgv.Columns.Add("ValorVenta", "Precio");
      dgv.Columns[3].DataPropertyName = "ValorVenta";
      dgv.Columns[3].Width = 80;
      dgv.Columns[3].DefaultCellStyle.Format = "C0";
      dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dgv.Columns[3].Resizable = DataGridViewTriState.False;
      dgv.Columns.Add("Cantidad", "Cantidad");
      dgv.Columns[4].DataPropertyName = "Cantidad";
      dgv.Columns[4].Width = 80;
      dgv.Columns[4].DefaultCellStyle.Format = "N4";
      dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dgv.Columns[4].Resizable = DataGridViewTriState.False;
      dgv.Columns.Add("PorcDescuento", "% Desc.");
      dgv.Columns[5].DataPropertyName = "PorcDescuento";
      dgv.Columns[5].Width = 60;
      dgv.Columns[5].DefaultCellStyle.Format = "N0";
      dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dgv.Columns[5].Resizable = DataGridViewTriState.False;
      dgv.Columns.Add("Descuento", "$ Desc.");
      dgv.Columns[6].DataPropertyName = "Descuento";
      dgv.Columns[6].Width = 70;
      dgv.Columns[6].DefaultCellStyle.Format = "C0";
      dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dgv.Columns[6].Resizable = DataGridViewTriState.False;
      dgv.Columns.Add("Total", "Total");
      dgv.Columns[7].DataPropertyName = "TotalLinea";
      dgv.Columns[7].Width = 90;
      dgv.Columns[7].DefaultCellStyle.Format = "C0";
      dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dgv.Columns[7].Resizable = DataGridViewTriState.False;
      dgv.Columns.Add("SubTotal", "SubTotal");
      dgv.Columns[8].DataPropertyName = "SubTotalLinea";
      dgv.Columns[8].Width = 90;
      dgv.Columns[8].DefaultCellStyle.Format = "C0";
      dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      dgv.Columns[8].Resizable = DataGridViewTriState.False;
      dgv.Columns[8].Visible = false;
      dgv.Columns.Add("TipoDescuento", "TipoDescuento");
      dgv.Columns[9].DataPropertyName = "TipoDescuento";
      dgv.Columns[9].Width = 90;
      dgv.Columns[9].Resizable = DataGridViewTriState.False;
      dgv.Columns[9].Visible = false;
      dgv.Columns.Add("ListaPrecio", "ListaPrecio");
      dgv.Columns[10].DataPropertyName = "ListaPrecio";
      dgv.Columns[10].Width = 90;
      dgv.Columns[10].Resizable = DataGridViewTriState.False;
      dgv.Columns[10].Visible = false;
      dgv.Columns.Add("Bodega", "Bodega");
      dgv.Columns[11].DataPropertyName = "Bodega";
      dgv.Columns[11].Width = 90;
      dgv.Columns[11].Resizable = DataGridViewTriState.False;
      dgv.Columns[11].Visible = false;
      dgv.Columns.Add("Folio", "Folio");
      dgv.Columns[12].DataPropertyName = "Folio";
      dgv.Columns[12].Width = 90;
      dgv.Columns[12].Resizable = DataGridViewTriState.False;
      dgv.Columns[12].Visible = false;
      dgv.Columns.Add("IdDevolucion", "IdDevolucion");
      dgv.Columns[13].DataPropertyName = "IdDevolucion";
      dgv.Columns[13].Width = 90;
      dgv.Columns[13].Resizable = DataGridViewTriState.False;
      dgv.Columns[13].Visible = false;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Eliminar";
      viewButtonColumn.HeaderText = "Eliminar";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "X";
      viewButtonColumn.Width = 50;
      viewButtonColumn.DisplayIndex = 14;
      viewButtonColumn.Resizable = DataGridViewTriState.False;
      dgv.Columns.Add((DataGridViewColumn) viewButtonColumn);
      dgv.Columns.Add("NetoLinea", "NetoLinea");
      dgv.Columns[15].DataPropertyName = "NetoLinea";
      dgv.Columns[15].Width = 90;
      dgv.Columns[15].Resizable = DataGridViewTriState.False;
      dgv.Columns[15].Visible = false;
      dgv.Columns.Add("ValorCompra", "ValorCompra");
      dgv.Columns[16].DataPropertyName = "ValorCompra";
      dgv.Columns[16].Width = 90;
      dgv.Columns[16].Resizable = DataGridViewTriState.False;
      dgv.Columns[16].Visible = false;
      dgv.Columns.Add("Estado", "Estado");
      dgv.Columns[17].DataPropertyName = "Estado";
      dgv.Columns[17].Width = 90;
      dgv.Columns[17].Resizable = DataGridViewTriState.False;
      dgv.Columns[17].Visible = false;
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

    private void txtFolioBoleta_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioBoleta);
      if ((int) e.KeyChar != 13 || this.txtFolioBoleta.Text.Length <= 0)
        return;
      bool flag = false;
      if (this._tipoBoleta.Equals("NORMAL"))
        flag = new Boleta().boletaExiste(Convert.ToInt32(this.txtFolioBoleta.Text.Trim()));
      if (this._tipoBoleta.Equals("FISCAL"))
      {
        this._idBoletaFiscal = new BoletaFiscal().retornaIdBoleta(Convert.ToInt32(this.txtFolioBoleta.Text.Trim()), Convert.ToInt32(this.txtCaja.Text.Trim()));
        flag = this._idBoletaFiscal > 0;
      }
      if (this._tipoBoleta.Equals("VOUCHER"))
      {
        this._idBoletaFiscal = new Boleta().voucherExiste(Convert.ToInt32(this.txtFolioBoleta.Text.Trim()));
        flag = this._idBoletaFiscal > 0;
      }
      if (this._tipoBoleta.Equals("FACTURA_ELECTRONICA"))
        flag = new EFactura().facturaExiste(Convert.ToInt32(this.txtFolioBoleta.Text.Trim()));
      if (this._tipoBoleta.Equals("GUIA_ELECTRONICA"))
        flag = new EGuia().guiaExiste(Convert.ToInt32(this.txtFolioBoleta.Text.Trim()));
      if (this._tipoBoleta.Equals("FACTURA_PAPEL"))
        flag = new Factura().facturaExiste(Convert.ToInt32(this.txtFolioBoleta.Text.Trim()));
      if (this._tipoBoleta.Equals("GUIA_PAPEL"))
        flag = new Guia().guiaExiste(Convert.ToInt32(this.txtFolioBoleta.Text.Trim()));
      if (flag)
      {
        this.cmbVendedor.Enabled = true;
        this.cmbVendedor.Focus();
        this.panel1.Enabled = true;
        if (this.buscaBoletasDevolucion())
        {
          int num = (int) MessageBox.Show("Este Documento Ya presenta cambios de productos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.btnVerDevolucionesDeBoleta.Visible = true;
          this.lblAlerta.Visible = true;
        }
        else
        {
          this.btnVerDevolucionesDeBoleta.Visible = false;
          this.lblAlerta.Visible = false;
        }
      }
      else
      {
        int num = (int) MessageBox.Show("No existe Documento Ingresado, en caja seleccionada", "No Existe", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.panel1.Enabled = false;
        this.cmbVendedor.Enabled = false;
      } try
      {
          Devolucion dv = new Devolucion();
          txtTotal.Text = dv.Total_boleta(Convert.ToInt32(txtFolioBoleta.Text), cmbTipoDocumento.SelectedItem.ToString());
          temp.Text = txtTotal.Text;
      }
      catch (Exception ex)
      {

      }
    }

    private bool buscaBoletasDevolucion()
    {
      return new Devolucion().buscaBoletaEnDevolucion(this.txtFolioBoleta.Text, this.txtCaja.Text, this._tipoBoleta);
    }

    private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPrecio);
    }

    private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidad);
      if ((int) e.KeyChar != 13 || this.txtCantidad.Text.Length <= 0 || !this.btnAgregar.Enabled)
        return;
      this.agregar();
    }

    private void txtPorcDescuentoLinea_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPorcDescuentoLinea);
      if ((int) e.KeyChar != 13 || this.txtPorcDescuentoLinea.Text.Length <= 0 || !this.btnAgregar.Enabled)
        return;
      this.agregar();
    }

    private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtDescuento);
      if ((int) e.KeyChar != 13 || this.txtDescuento.Text.Length <= 0 || !this.btnAgregar.Enabled)
        return;
      this.agregar();
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0)
        return;
      e.Handled = false;
      if (this.rdbReponer.Checked)
        this.llamaProductoDeBoleta(this.txtCodigo.Text);
      else
        this.llamaProductoCodigo(this.txtCodigo.Text, Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
    }

    public void llamaProductoDeBoleta(string cod)
    {
      DatosVentaVO datosVentaVo = new Devolucion().buscaProductoEnBoleta(Convert.ToInt32(this.txtFolioBoleta.Text.Trim()), cod, this._tipoBoleta, this._idBoletaFiscal);
      if (datosVentaVo.Codigo != null)
      {
        this.datosVO = datosVentaVo;
        this.txtCodigo.Text = datosVentaVo.Codigo;
        this.txtDescripcion.Text = datosVentaVo.Descripcion;
        this.txtPrecio.Text = datosVentaVo.ValorVenta.ToString("N0");
        this.esExento = datosVentaVo.Exento;
        this.valorCompra = datosVentaVo.ValorCompra;
        this._cantBoleta = datosVentaVo.Cantidad;
        this.lblCantidad.Text = datosVentaVo.Cantidad.ToString("N2");
        this.txtCantidad.Focus();
        this.cmbBodega.SelectedValue = (object) datosVentaVo.Bodega;
        this.cmbListaPrecio.SelectedValue = (object) datosVentaVo.ListaPrecio;
      }
      else
      {
        int num = (int) MessageBox.Show("NO se encontro Producto en Documento Seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCodigo.Clear();
        this.txtDescripcion.Clear();
        this.txtCantidad.Clear();
        this.txtPrecio.Clear();
        this.txtCodigo.Focus();
      }
    }

    public void llamaProductoCodigo(string cod, int bodega)
    {
      this.cmbBodega.SelectedValue = (object) bodega.ToString();
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
        this.idImpuesto = productoVo.IdImpuesto;
        this.valorCompra = productoVo.ValorCompra;
        this.txtCantidad.Focus();
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe el Codigo Ingresado.");
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
        this.txtSubTotalLinea.Text = subTotal.ToString("N0");
        this.txtDescuento.Text = descuento.ToString("##");
        this.txtPorcDescuentoLinea.Text = porDesc.ToString("##");
        Decimal total = calculos.totalLinea(subTotal, descuento);
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
        int num4 = (int) MessageBox.Show("El Descuento debe ser Menor al Total!!");
        this.txtDescuento.Clear();
        this.txtPorcDescuentoLinea.Clear();
      }
    }

    private void txtPrecio_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtCantidad_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtPorcDescuentoLinea_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtDescuento_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
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

    private void agregaLineaGrillaReponer()
    {
      if (this._cantBoleta >= Convert.ToDecimal(this.txtCantidad.Text))
      {
          string tm = this.txtTotalLinea.Text.ToString();
        this.listaReponer.Add(new DatosDevolucionVO()
        {
          Estado = "ENTRA",
          Codigo = this.txtCodigo.Text.Trim().ToUpper(),
          Descripcion = this.txtDescripcion.Text.Trim().ToUpper(),
          NetoLinea = this.netoLinea,
          ValorCompra = this.valorCompra,
          ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0),
          Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0),
          Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0),
          PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0),
          TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0),
          SubTotalLinea = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text) : new Decimal(0),
          TipoDescuento = Convert.ToInt32(this.txtTipoDescuento.Text),
          ListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString()),
          Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()),
          Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()),
          IdDevolucion = 0
        });
        this.iniciaLinea();
        for (int index = 0; index < this.listaReponer.Count; ++index)
          this.listaReponer[index].Linea = index + 1;
        this.dgvDatosReponer.DataSource = (object) null;
        this.dgvDatosReponer.DataSource = (object) this.listaReponer;
        this.calculaTotal("reponer", tm);
      }
      else
      {
        int num = (int) MessageBox.Show("En la Boleta Solo se Ingresaron " + this._cantBoleta.ToString("N2") + ", No puede agregar mas que estos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCantidad.Focus();
      }
    }

    private void agregaLineaGrillaSacar()
    {
        string tm = this.txtTotalLinea.Text.ToString();
      this.listaSacar.Add(new DatosDevolucionVO()
      {
        Estado = "SALE",
        Codigo = this.txtCodigo.Text.Trim().ToUpper(),
        Descripcion = this.txtDescripcion.Text.Trim().ToUpper(),
        NetoLinea = this.netoLinea,
        ValorCompra = this.valorCompra,
        ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0),
        Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0),
        Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0),
        PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0),
        TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0),
        SubTotalLinea = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text) : new Decimal(0),
        TipoDescuento = Convert.ToInt32(this.txtTipoDescuento.Text),
        ListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString()),
        Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()),
        Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()),
        IdDevolucion = 0
      });
      this.iniciaLinea();
      for (int index = 0; index < this.listaSacar.Count; ++index)
        this.listaSacar[index].Linea = index + 1;
      this.dgvDatosSacar.DataSource = (object) null;
      this.dgvDatosSacar.DataSource = (object) this.listaSacar;
      this.calculaTotal("sacar", tm);
    }

    private void calculaTotal(string tipo, string valor)
    {
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      for (int index = 0; index < this.listaReponer.Count; ++index)
        num1 += this.listaReponer[index].TotalLinea;
      for (int index = 0; index < this.listaSacar.Count; ++index)
        num2 += this.listaSacar[index].TotalLinea;
      Decimal num4 = num2 - num1;
      decimal total = new decimal(0);
      Calculos calculos = new Calculos();
      Devolucion dv = new Devolucion();
      if (!calculos._valoresConIva)
      {
          Decimal c6 = calculos._iva / new Decimal(100);
          num4 *= ++c6;
          this.txtTotal.Text = num4.ToString("N0");
      }
      if (valor != "")
      {
          if (tipo == "reponer")
          {

              //decimal aux = Convert.ToDecimal(dv.Total_boleta(Convert.ToInt32(this.txtFolioBoleta.Text), cmbTipoDocumento.SelectedItem.ToString()));
              //temp.Text = Convert.ToDecimal(dv.Total_boleta(Convert.ToInt32(this.txtFolioBoleta.Text), cmbTipoDocumento.SelectedItem.ToString())).ToString() ;
              //
              //decimal valor = Convert.ToDecimal(num4);
              decimal aux1 = Decimal.Negate(num4);
              Decimal tm = Decimal.Multiply(Convert.ToDecimal(valor), new Decimal(1.19));
              total = Decimal.Subtract(Convert.ToDecimal(temp.Text), tm);
              string tl = Math.Abs(total).ToString("N0"); ;
              this.txtTotal.Text = tl;//total.ToString("N0"); //num4.ToString("N0");

          }
          else if (tipo == "sacar")
          {
              decimal aux = 0;

              if (txtTotal.Text == "") { aux = Convert.ToDecimal(dv.Total_boleta(Convert.ToInt32(this.txtFolioBoleta.Text), cmbTipoDocumento.SelectedItem.ToString())); }
              else { aux = Convert.ToDecimal(this.txtTotal.Text); }


              txtTotal.Clear();
              decimal valor_1 = Convert.ToDecimal(num4);
              if (valor_1 <= Decimal.Zero) {
                    Decimal aq = Decimal.Negate(valor_1);
                    Decimal tp = Decimal.Subtract(Convert.ToDecimal(temp.Text.ToString()), Convert.ToDecimal(aq));
                    total = tp;
              }
              else
              {
                  if (valor_1 >= Decimal.Zero)
                  {
                      total = Decimal.Subtract(Convert.ToDecimal(txtTotal.Text.ToString()), Convert.ToDecimal(valor));
                  }
                  else { total = Decimal.Add(Convert.ToDecimal(temp.Text.ToString()), Convert.ToDecimal(valor)); }
              }
              this.txtTotal.Text = total.ToString("N0");// num4.ToString("N0");

          }
      }
      else
      {
          try
          {
              txtTotal.Text = dv.Total_boleta(Convert.ToInt32(txtFolioBoleta.Text), cmbTipoDocumento.SelectedItem.ToString());
              temp.Text = txtTotal.Text;
          }
          catch (Exception ex) { }
      }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      this.agregar();
    }

    private void agregar()
    {
      if (this.rdbReponer.Checked)
        this.agregaLineaGrillaReponer();
      else
        this.agregaLineaGrillaSacar();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Dispose();
      this.Close();
    }

    private void cmbVendedor_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar == 13)
      {
          Devolucion dv = new Devolucion();
          txtTotal.Text = dv.Total_boleta(Convert.ToInt32(txtFolioBoleta.Text), cmbTipoDocumento.SelectedItem.ToString());
       // int num = (int) MessageBox.Show("entra");
        this.txtCodigo.Focus();
      }
      else
      {
       // int num1 = (int) MessageBox.Show("NO entra");
      }
    }

    private void cmbVendedor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData != Keys.Return)
        return;
      Devolucion dv = new Devolucion();
      txtTotal.Text = dv.Total_boleta(Convert.ToInt32(txtFolioBoleta.Text), cmbTipoDocumento.SelectedItem.ToString());
      this.txtCodigo.Focus();
    }

    private void rdbSacar_CheckedChanged(object sender, EventArgs e)
    {
      this.txtCodigo.Focus();
    }

    private void rdbReponer_CheckedChanged(object sender, EventArgs e)
    {
      this.txtCodigo.Focus();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaDevolucion();
    }

    private void guardaDevolucion()
    {
      if (!this.valida())
        return;
      try
      {
        Devolucion devolucion = new Devolucion();
        for (int index = 0; index < this.listaReponer.Count; ++index)
          this.listaReponer[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        for (int index = 0; index < this.listaSacar.Count; ++index)
          this.listaSacar[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        devolucion.guardaDevolucion(this.armaDevolucion(), this.listaReponer, this.listaSacar);
        int num1 = (int) MessageBox.Show("Devolucion Ingresada", "Ingreso OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        Decimal num2 =Convert.ToDecimal(this.txtTotal.Text);
        string str = "Diferencia por Cambio de Producto en Devolucion Folio: " + this.txtNumeroDocumento.Text;
        if (num2 > new Decimal(0))
        {
          if (MessageBox.Show("Desea hacer un Docuemnto por la Diferencia ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            if (frmMenuPrincipal._Fiscal)
              this.btnBoletaFiscal.Enabled = true;
            else
              this.btnBoletaFiscal.Enabled = false;
            this.gpbTipoBoleta.Visible = true;
            this.rdbBoleta.Checked = true;
          }
          else
            this.Close();
        }
        else
          this.Close();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void reimprimeBoleta(string tipoBol)
    {
      Decimal val = Convert.ToDecimal(this.txtTotal.Text);
      string des = "Diferencia por Cambio de Producto en Devolucion Folio: " + this.txtNumeroDocumento.Text;
      if (tipoBol.Equals("NORMAL") || tipoBol.Equals("VOUCHER"))
      {
        if (Application.OpenForms["frmBoleta"] == null)
        {
          new frmBoleta(des, val).Show();
        }
        else
        {
          Application.OpenForms["frmBoleta"].Close();
          new frmBoleta(des, val).Show();
        }
      }
      if (tipoBol.Equals("FISCAL"))
      {
        if (Application.OpenForms["frmBoletaFiscal"] == null)
        {
          new frmBoletaFiscal(des, val).Show();
        }
        else
        {
          Application.OpenForms["frmBoletaFiscal"].Close();
          new frmBoletaFiscal(des, val).Show();
        }
      }
      if (tipoBol.Equals("FACTURA_ELECTRONICA"))
      {
        if (Application.OpenForms["frmFacturaElectronica"] == null)
        {
          new frmFacturaElectronica(des, val).Show();
        }
        else
        {
          Application.OpenForms["frmFacturaElectronica"].Close();
          new frmFacturaElectronica(des, val).Show();
        }
      }
      if (tipoBol.Equals("GUIA_ELECTRONICA"))
      {
        if (Application.OpenForms["frmGuiaDespachoElectronica"] == null)
        {
          new frmGuiaDespachoElectronica(des, val).Show();
        }
        else
        {
          Application.OpenForms["frmGuiaDespachoElectronica"].Close();
          new frmGuiaDespachoElectronica(des, val).Show();
        }
      }
      this.iniciaFormulario();
      this.Close();
    }

    private bool valida()
    {
      if (this.listaReponer.Count == 0 || this.listaSacar.Count == 0)
      {
        int num = (int) MessageBox.Show("Debe ingresar productos a Reponer y Sacar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
      }
      if (this.cmbVendedor.SelectedValue == null)
      {
        int num = (int) MessageBox.Show("Debe Seleccionar un Vendedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.cmbVendedor.Focus();
        return false;
      }
      if (this.txtFolioBoleta.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe ingresar un numero de Boleta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtFolioBoleta.Focus();
        return false;
      }
      if (this.txtCaja.Text.Trim().Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe ingresar un numero de Caja", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtCaja.Focus();
      return false;
    }

    private DevolucionVO armaDevolucion()
    {
      DevolucionVO devolucionVo = new DevolucionVO();
      devolucionVo.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      devolucionVo.Fecha = this.dtpFecha.Value;
      devolucionVo.FolioBoleta = Convert.ToInt32(this.txtFolioBoleta.Text.Trim());
      if (this.cmbVendedor.SelectedValue != null && this.cmbVendedor.SelectedValue.ToString() != "0")
      {
        devolucionVo.Vendedor = this.cmbVendedor.Text.ToUpper();
        devolucionVo.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
      }
      devolucionVo.Total =  Convert.ToDecimal(this.txtTotal.Text.Trim());
      devolucionVo.Caja = this._caja;
      devolucionVo.CajaBoleta = this.txtCaja.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtCaja.Text.Trim()) : 0;
      devolucionVo.Documento = this._tipoBoleta;
      return devolucionVo;
    }

    private void dgvDatosReponer_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvDatosReponer.Columns[e.ColumnIndex].Name == "Eliminar"))
        return;
      if (MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        int num = Convert.ToInt32(this.dgvDatosReponer.SelectedRows[0].Cells[0].Value.ToString());
        for (int index = 0; index < this.listaReponer.Count; ++index)
        {
          if (this.listaReponer[index].Linea == num)
          {
            this.listaReponer.RemoveAt(index);
            --index;
          }
        }
      }
      for (int index = 0; index < this.listaReponer.Count; ++index)
        this.listaReponer[index].Linea = index + 1;
      this.dgvDatosReponer.DataSource = (object) null;
      this.dgvDatosReponer.DataSource = (object) this.listaReponer;
      try
      {
          Devolucion dv = new Devolucion();
          txtTotal.Text = dv.Total_boleta(Convert.ToInt32(txtFolioBoleta.Text), cmbTipoDocumento.SelectedItem.ToString());
          temp.Text = txtTotal.Text;
      }
      catch (Exception ex) { }
      this.calculaTotal("reponer", txtTotalLinea.Text.ToString());
    }

    private void dgvDatosSacar_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvDatosSacar.Columns[e.ColumnIndex].Name == "Eliminar"))
        return;
      if (MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        int num = Convert.ToInt32(this.dgvDatosSacar.SelectedRows[0].Cells[0].Value.ToString());
        for (int index = 0; index < this.listaSacar.Count; ++index)
        {
          if (this.listaSacar[index].Linea == num)
          {
            this.listaSacar.RemoveAt(index);
            --index;
          }
        }
      }
      for (int index = 0; index < this.listaSacar.Count; ++index)
        this.listaSacar[index].Linea = index + 1;
      this.dgvDatosSacar.DataSource = (object) null;
      this.dgvDatosSacar.DataSource = (object) this.listaSacar;
      this.calculaTotal("sacar", txtTotalLinea.Text.ToString());
    }

    private void buscarDevolucionF6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Clear();
      this.txtFolioBuscar.Focus();
    }

    private void frmDevolucion_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F6)
      {
        this.panelFolio.Visible = true;
        this.txtFolioBuscar.Clear();
        this.txtFolioBuscar.Focus();
      }
      if (e.KeyCode != Keys.F4)
        return;
      string tipoBusqueda = !this.rdbReponer.Checked ? "productos" : "boleta";
      this.txtCodigo.Focus();
      int num = (int) new frmBuscaProductos("devolucion", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), true, "0", tipoBusqueda).ShowDialog();
      this.txtCodigo.Focus();
      SendKeys.Send("~");
      this.txtCodigo.Focus();
    }

    private void btnCerrarPanelFolio_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = false;
    }

    private void btnBuscaFolio_Click(object sender, EventArgs e)
    {
      this.buscarDevolucion();
    }

    private void buscarDevolucion()
    {
      Devolucion devolucion = new Devolucion();
      DevolucionVO devolucionVo = devolucion.buscaDevolucion(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
      if (devolucionVo.IdDevolucion != 0)
      {
        this.iniciaFormulario();
        this.btnGuardar.Enabled = false;
        this.btnModificar.Enabled = true;
        this.btnEliminar.Enabled = true;
        if (devolucionVo.Documento.Equals("FACTURA_ELECTRONICA"))
        {
          this.cmbTipoDocumento.Text = "Factura Electronica";
          this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE Factura Electronica";
        }
        if (devolucionVo.Documento.Equals("GUIA_ELECTRONICA"))
        {
          this.cmbTipoDocumento.Text = "Guia Electronica";
          this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE Guia Electronica";
        }
        if (devolucionVo.Documento.Equals("NORMAL"))
        {
          this.cmbTipoDocumento.Text = "Boleta";
          this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE BOLETA";
        }
        if (devolucionVo.Documento.Equals("FISCAL"))
        {
          this.cmbTipoDocumento.Text = "Boleta Fiscal";
          this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE BOLETA FISCAL";
        }
        if (devolucionVo.Documento.Equals("VOUCHER"))
        {
          this.cmbTipoDocumento.Text = "Voucher";
          this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE VOUCHER";
        }
        this.txtFolioBoleta.Enabled = false;
        this.txtCaja.Enabled = false;
        this.idDevolucion = devolucionVo.IdDevolucion;
        this.txtNumeroDocumento.Text = devolucionVo.Folio.ToString("N0");
        this.dtpFecha.Value = devolucionVo.Fecha;
        TextBox textBox1 = this.txtFolioBoleta;
        int num = devolucionVo.FolioBoleta;
        string str1 = num.ToString("N0");
        textBox1.Text = str1;
        TextBox textBox2 = this.txtCaja;
        num = devolucionVo.CajaBoleta;
        string str2 = num.ToString("NO");
        textBox2.Text = str2;
        this.cmbVendedor.Enabled = true;
        this.cmbVendedor.SelectedValue = (object) devolucionVo.IdVendedor;
        this.panel1.Enabled = true;
        this.txtTotal.Text = devolucionVo.Total.ToString("N0");
        this._tipoBoleta = devolucionVo.Documento;
        foreach (DatosDevolucionVO datosDevolucionVo in devolucion.buscaDetalleDevolucion(Convert.ToInt32(this.txtFolioBuscar.Text.Trim())))
        {
          if (datosDevolucionVo.Estado.Equals("ENTRA"))
            this.listaReponer.Add(datosDevolucionVo);
          else
            this.listaSacar.Add(datosDevolucionVo);
        }
        for (int index = 0; index < this.listaReponer.Count; ++index)
          this.listaReponer[index].Linea = index + 1;
        this.dgvDatosReponer.DataSource = (object) null;
        this.dgvDatosReponer.DataSource = (object) this.listaReponer;
        for (int index = 0; index < this.listaSacar.Count; ++index)
          this.listaSacar[index].Linea = index + 1;
        this.dgvDatosSacar.DataSource = (object) null;
        this.dgvDatosSacar.DataSource = (object) this.listaSacar;
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Devolución", "No Existe", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtFolioBuscar.Focus();
      }
    }

    private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioBuscar);
      if ((int) e.KeyChar != 13 || this.txtFolioBuscar.Text.Length <= 0)
        return;
      this.buscarDevolucion();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Eliminar la Devolución ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          Devolucion devolucion = new Devolucion();
          devolucion.eliminaDevolucion(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()));
          devolucion.eliminaDetalleDevolucionLista(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()), this.listaReponer, this.listaSacar);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Devolucion NO fue Eliminada", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Modificar la Devolución ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (!this.valida())
          return;
        try
        {
          Devolucion devolucion = new Devolucion();
          for (int index = 0; index < this.listaReponer.Count; ++index)
            this.listaReponer[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
          for (int index = 0; index < this.listaSacar.Count; ++index)
            this.listaSacar[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
          devolucion.modificaDevolucion(this.armaDevolucion(), this.listaReponer, this.listaSacar);
          int num = (int) MessageBox.Show("Devolucion Modificada", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Devolucion NO fue Modificada", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
    }

    private void dgvDatosReponer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.listaReponer.Count <= 0)
        return;
      this.btnModificaLinea.Visible = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiaDetalle.Enabled = false;
      this.chkCantidadFija.Checked = false;
      this.rdbReponer.Checked = true;
      this.rdbSacar.Enabled = false;
      this.txtCodigo.Text = this.dgvDatosReponer.SelectedRows[0].Cells["Codigo"].Value.ToString();
      this.txtDescripcion.Text = this.dgvDatosReponer.SelectedRows[0].Cells["Descripcion"].Value.ToString();
      this.txtPrecio.Text = Convert.ToDecimal(this.dgvDatosReponer.SelectedRows[0].Cells["ValorVenta"].Value.ToString()).ToString("##");
      this.txtCantidad.Text = this.verificaDecimales(this.dgvDatosReponer.SelectedRows[0].Cells["Cantidad"].Value.ToString());
      this.txtDescuento.Text = this.dgvDatosReponer.SelectedRows[0].Cells["Descuento"].Value.ToString();
      this.txtPorcDescuentoLinea.Text = this.dgvDatosReponer.SelectedRows[0].Cells["PorcDescuento"].Value.ToString();
      this.txtSubTotalLinea.Text = this.dgvDatosReponer.SelectedRows[0].Cells["SubTotal"].Value.ToString();
      this.txtTipoDescuento.Text = this.dgvDatosReponer.SelectedRows[0].Cells["TipoDescuento"].Value.ToString();
      this.txtLinea.Text = this.dgvDatosReponer.SelectedRows[0].Cells["Linea"].Value.ToString();
      this.cmbListaPrecio.SelectedValue = (object) this.dgvDatosReponer.SelectedRows[0].Cells["ListaPrecio"].Value.ToString();
      this.cmbBodega.SelectedValue = (object) this.dgvDatosReponer.SelectedRows[0].Cells["Bodega"].Value.ToString();
      this.netoLinea = Convert.ToDecimal(this.dgvDatosReponer.SelectedRows[0].Cells["NetoLinea"].Value.ToString());
    }

    private void dgvDatosSacar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.listaSacar.Count <= 0)
        return;
      this.btnModificaLinea.Visible = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiaDetalle.Enabled = false;
      this.chkCantidadFija.Checked = false;
      this.rdbSacar.Checked = true;
      this.rdbReponer.Enabled = false;
      this.txtCodigo.Text = this.dgvDatosSacar.SelectedRows[0].Cells["Codigo"].Value.ToString();
      this.txtDescripcion.Text = this.dgvDatosSacar.SelectedRows[0].Cells["Descripcion"].Value.ToString();
      this.txtPrecio.Text = Convert.ToDecimal(this.dgvDatosSacar.SelectedRows[0].Cells["ValorVenta"].Value.ToString()).ToString("##");
      this.txtCantidad.Text = this.verificaDecimales(this.dgvDatosSacar.SelectedRows[0].Cells["Cantidad"].Value.ToString());
      this.txtDescuento.Text = this.dgvDatosSacar.SelectedRows[0].Cells["Descuento"].Value.ToString();
      this.txtPorcDescuentoLinea.Text = this.dgvDatosSacar.SelectedRows[0].Cells["PorcDescuento"].Value.ToString();
      this.txtSubTotalLinea.Text = this.dgvDatosSacar.SelectedRows[0].Cells["SubTotal"].Value.ToString();
      this.txtTipoDescuento.Text = this.dgvDatosSacar.SelectedRows[0].Cells["TipoDescuento"].Value.ToString();
      this.txtLinea.Text = this.dgvDatosSacar.SelectedRows[0].Cells["Linea"].Value.ToString();
      this.cmbListaPrecio.SelectedValue = (object) this.dgvDatosSacar.SelectedRows[0].Cells["ListaPrecio"].Value.ToString();
      this.cmbBodega.SelectedValue = (object) this.dgvDatosSacar.SelectedRows[0].Cells["Bodega"].Value.ToString();
      this.netoLinea = Convert.ToDecimal(this.dgvDatosSacar.SelectedRows[0].Cells["NetoLinea"].Value.ToString());
      this.valorCompra = Convert.ToDecimal(this.dgvDatosSacar.SelectedRows[0].Cells["ValorCompra"].Value.ToString());
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

    private void modificaLineaRepone()
    {
      string str = this.txtCantidad.Text.Trim().Length > 0 ? this.txtCantidad.Text : "0";
      for (int index = 0; index < this.listaReponer.Count; ++index)
      {
        if (this.listaReponer[index].Linea == Convert.ToInt32(this.txtLinea.Text))
        {
          this.listaReponer[index].Codigo = this.txtCodigo.Text;
          this.listaReponer[index].Descripcion = this.txtDescripcion.Text;
          this.listaReponer[index].ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
          this.listaReponer[index].Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
          this.listaReponer[index].TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
          this.listaReponer[index].Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
          this.listaReponer[index].PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
          this.listaReponer[index].NetoLinea = this.netoLinea;
          this.listaReponer[index].IdDevolucion = this.idDevolucion;
        }
      }
      this.dgvDatosReponer.DataSource = (object) null;
      this.dgvDatosReponer.DataSource = (object) this.listaReponer;
      this.calculaTotal("reponer", txtTotalLinea.Text.ToString());
      this.iniciaLinea();
    }

    private void modificaLineaSaca()
    {
      string str = this.txtCantidad.Text.Trim().Length > 0 ? this.txtCantidad.Text : "0";
      for (int index = 0; index < this.listaSacar.Count; ++index)
      {
        if (this.listaSacar[index].Linea == Convert.ToInt32(this.txtLinea.Text))
        {
          this.listaSacar[index].Codigo = this.txtCodigo.Text;
          this.listaSacar[index].Descripcion = this.txtDescripcion.Text;
          this.listaSacar[index].ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
          this.listaSacar[index].Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
          this.listaSacar[index].TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
          this.listaSacar[index].Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
          this.listaSacar[index].PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
          this.listaSacar[index].NetoLinea = this.netoLinea;
          this.listaSacar[index].IdDevolucion = this.idDevolucion;
        }
      }
      this.dgvDatosSacar.DataSource = (object) null;
      this.dgvDatosSacar.DataSource = (object) this.listaSacar;
      this.calculaTotal("sacar",txtTotalLinea.Text.ToString());
      this.iniciaLinea();
    }

    private void btnModificaLinea_Click(object sender, EventArgs e)
    {
      if (this.rdbReponer.Checked)
        this.modificaLineaRepone();
      else
        this.modificaLineaSaca();
    }

    private void btnLimpiaLineaDetalle_Click(object sender, EventArgs e)
    {
      this.iniciaLinea();
    }

    private void btnEmiteBoleta_Click(object sender, EventArgs e)
    {
      new frmBoleta("Diferencia por Cabio de Productos en Devolución N°: " + this.txtNumeroDocumento.Text, Convert.ToDecimal(this.txtTotal.Text.Trim())).Show();
    }

    private void btnLimpiaDetalle_Click(object sender, EventArgs e)
    {
      this.listaReponer.Clear();
      this.dgvDatosReponer.DataSource = (object) null;
      this.listaSacar.Clear();
      this.dgvDatosSacar.DataSource = (object) null;
      this.calculaTotal("", txtTotalLinea.Text.ToString());
    }

    private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCaja);
      if ((int) e.KeyChar != 13 || this.txtCaja.Text.Length <= 0)
        return;
      this.txtFolioBoleta.Focus();
    }

    private void btnVerDevolucionesDeBoleta_Click(object sender, EventArgs e)
    {
      Devolucion devolucion = new Devolucion();
      DataTable dataTable1 = new DataTable();
      string filtro = "documento='" + this._tipoBoleta + "' AND folioBoleta='" + this.txtFolioBoleta.Text + "' AND cajaBoleta='" + this.txtCaja.Text + "'";
      string str = "Devolucion001.rpt";
      DataTable dataTable2 = devolucion.devolucionInforme(filtro);
      try
      {
        ReportDocument rpt = new ReportDocument();
        rpt.Load("C:\\AptuSoft\\reportes\\" + str);
        rpt.SetDataSource(dataTable2);
        new frmVisualizadorReportes(rpt).Show();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void btnBoletaNormal_Click(object sender, EventArgs e)
    {
      this.reimprimeBoleta("NORMAL");
    }

    private void btnBoletaFiscal_Click(object sender, EventArgs e)
    {
      this.reimprimeBoleta("FISCAL");
    }

    private void cmbTipoDocumento_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (this.cmbTipoDocumento.Text == "Boleta")
      {
        this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE BOLETA";
        this._tipoBoleta = "NORMAL";
        this.txtFolioBoleta.Focus();
      }
      if (this.cmbTipoDocumento.Text == "Boleta Fiscal")
      {
        this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE BOLETA FISCAL";
        this._tipoBoleta = "FISCAL";
        this.txtFolioBoleta.Focus();
      }
      if (this.cmbTipoDocumento.Text == "Voucher")
      {
        this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE VOUCHER";
        this._tipoBoleta = "VOUCHER";
        this.txtFolioBoleta.Focus();
      }
      if (this.cmbTipoDocumento.Text == "Factura Electronica")
      {
        this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE Factura Electronica";
        this._tipoBoleta = "FACTURA_ELECTRONICA";
        this.txtFolioBoleta.Focus();
      }
      if (this.cmbTipoDocumento.Text == "Guia Electronica")
      {
        this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE Guia Electronica";
        this._tipoBoleta = "GUIA_ELECTRONICA";
        this.txtFolioBoleta.Focus();
      }
      if (this.cmbTipoDocumento.Text == "Factura papel")
      {
        this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE Factura papel";
        this._tipoBoleta = "FACTURA_PAPEL";
        this.txtFolioBoleta.Focus();
      }
      if (!(this.cmbTipoDocumento.Text == "Guia Papel"))
        return;
      this.lblTitulo.Text = "DEVOLUCION PRODUCTOS DE Guia Papel";
      this._tipoBoleta = "GUIA_PAPEL";
      this.txtFolioBoleta.Focus();
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      if (this.rdbBoleta.Checked)
        this.reimprimeBoleta("NORMAL");
      if (this.rdbFiscal.Checked)
        this.reimprimeBoleta("FISCAL");
      if (this.rdbEFactura.Checked)
        this.reimprimeBoleta("FACTURA_ELECTRONICA");
      if (!this.rdbEGuia.Checked)
        return;
      this.reimprimeBoleta("GUIA_ELECTRONICA");
    }

    private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string tipoBusqueda = !this.rdbReponer.Checked ? "productos" : "boleta";
        this.txtCodigo.Focus();
        int num = (int)new frmBuscaProductos("devolucion", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), true, "0", tipoBusqueda).ShowDialog();
        this.txtCodigo.Focus();
        SendKeys.Send("~");
        this.txtCodigo.Focus();
    }
  }
}
