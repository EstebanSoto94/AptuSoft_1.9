 
// Type: Aptusoft.TomaInventario.Formularios.frmTomaInventario
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using Aptusoft;
using Aptusoft.TomaInventario.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft.TomaInventario.Formularios
{
  public class frmTomaInventario : Form
  {
    private IContainer components = (IContainer) null;
    private List<ProductoVO> lista = new List<ProductoVO>();
    private List<ProductoVO> listaGuarda = new List<ProductoVO>();
    private int idToma = 0;
    private Decimal costo = new Decimal(0);
    private bool agregadosPorCategoria = false;
    private DataGridView dgvDatos;
    private GroupBox groupBox1;
    private TextBox txtAutorizado;
    private DateTimePicker dtpEmision;
    private Label label12;
    private Label label1;
    private TextBox txtNumeroDocumento;
    private Label lblFolio;
    private Label label28;
    private ComboBox cmbBodega;
    private Panel panelZonaDetalle;
    private TextBox txtStockFisico;
    private Label label2;
    private Button btnLimpiaLineaDetalle;
    private Button btnModificaLinea;
    private Panel panel4;
    private TextBox txtCodigo;
    private TextBox txtStockSistema;
    private Button btnAgregar;
    private TextBox txtDescripcion;
    private TextBox txtDiferencia;
    private Label label20;
    private Label label14;
    private Label label13;
    private Label label17;
    private Button btnLimpiaDetalle;
    private Button btnImprime;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnGuardar;
    private Button btnEliminar;
    private Panel panel1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button btnAgregarCategorias;
    private ComboBox cmbCategoria;
    private Label label3;
    private Panel panelFolio;
    private Button btnCerrarPanelFolio;
    private Button btnBuscaFolio;
    private TextBox txtFolioBuscar;
    private Label label32;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem;
    private ToolStripMenuItem buscarFacturaTeclaF6ToolStripMenuItem;
    private ToolStripMenuItem guardarFacturaTeclaF2ToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem;
    private ComboBox cmbEstado;
    private Label label4;
    private Button btnComprobarMovimientos;
    private DataGridViewTextBoxColumn Linea;
    private DataGridViewTextBoxColumn Alerta;
    private DataGridViewTextBoxColumn Codigo;
    private DataGridViewTextBoxColumn Descripcion;
    private DataGridViewTextBoxColumn StockReal;
    private DataGridViewTextBoxColumn StockSistema;
    private DataGridViewTextBoxColumn Diferencia;
    private DataGridViewTextBoxColumn ValorCompra;
    private DataGridViewButtonColumn Elimina;

    public frmTomaInventario()
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.cargaCategorias();
      this.cargaBodegas();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elimina = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.txtAutorizado = new System.Windows.Forms.TextBox();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.panelZonaDetalle = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificaLinea = new System.Windows.Forms.Button();
            this.txtStockFisico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiaLineaDetalle = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtStockSistema = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDiferencia = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnLimpiaDetalle = new System.Windows.Forms.Button();
            this.btnImprime = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComprobarMovimientos = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarCategorias = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFolio = new System.Windows.Forms.Panel();
            this.btnCerrarPanelFolio = new System.Windows.Forms.Button();
            this.btnBuscaFolio = new System.Windows.Forms.Button();
            this.txtFolioBuscar = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaTeclaF6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarFacturaTeclaF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelZonaDetalle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelFolio.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linea,
            this.Alerta,
            this.Codigo,
            this.Descripcion,
            this.StockReal,
            this.StockSistema,
            this.Diferencia,
            this.ValorCompra,
            this.Elimina});
            this.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDatos.Location = new System.Drawing.Point(12, 168);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(871, 400);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.TabStop = false;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellEndEdit);
            this.dgvDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellEnter);
            this.dgvDatos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDatos_EditingControlShowing);
            this.dgvDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDatos_KeyPress);
            // 
            // Linea
            // 
            this.Linea.DataPropertyName = "Linea";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Linea.DefaultCellStyle = dataGridViewCellStyle1;
            this.Linea.HeaderText = "";
            this.Linea.Name = "Linea";
            this.Linea.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Linea.Width = 30;
            // 
            // Alerta
            // 
            this.Alerta.DataPropertyName = "Marca";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Alerta.DefaultCellStyle = dataGridViewCellStyle2;
            this.Alerta.HeaderText = "Dif";
            this.Alerta.Name = "Alerta";
            this.Alerta.ReadOnly = true;
            this.Alerta.Width = 60;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 320;
            // 
            // StockReal
            // 
            this.StockReal.DataPropertyName = "StockFisico";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = "0";
            this.StockReal.DefaultCellStyle = dataGridViewCellStyle5;
            this.StockReal.HeaderText = "Stock Fisico";
            this.StockReal.Name = "StockReal";
            this.StockReal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StockSistema
            // 
            this.StockSistema.DataPropertyName = "StockSistema";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.StockSistema.DefaultCellStyle = dataGridViewCellStyle6;
            this.StockSistema.HeaderText = "Stock Sistema";
            this.StockSistema.Name = "StockSistema";
            this.StockSistema.ReadOnly = true;
            this.StockSistema.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Diferencia
            // 
            this.Diferencia.DataPropertyName = "Diferencia";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Diferencia.DefaultCellStyle = dataGridViewCellStyle7;
            this.Diferencia.HeaderText = "Diferencia";
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            this.Diferencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Diferencia.Width = 90;
            // 
            // ValorCompra
            // 
            this.ValorCompra.DataPropertyName = "ValorCompra";
            this.ValorCompra.HeaderText = "ValorCompra";
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorCompra.Visible = false;
            // 
            // Elimina
            // 
            this.Elimina.HeaderText = "Elimina";
            this.Elimina.Name = "Elimina";
            this.Elimina.Text = "X";
            this.Elimina.ToolTipText = "X";
            this.Elimina.UseColumnTextForButtonValue = true;
            this.Elimina.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBodega);
            this.groupBox1.Controls.Add(this.txtAutorizado);
            this.groupBox1.Controls.Add(this.dtpEmision);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbBodega
            // 
            this.cmbBodega.BackColor = System.Drawing.Color.White;
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(414, 31);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(142, 21);
            this.cmbBodega.TabIndex = 2;
            // 
            // txtAutorizado
            // 
            this.txtAutorizado.BackColor = System.Drawing.Color.White;
            this.txtAutorizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutorizado.Location = new System.Drawing.Point(113, 31);
            this.txtAutorizado.Name = "txtAutorizado";
            this.txtAutorizado.Size = new System.Drawing.Size(295, 20);
            this.txtAutorizado.TabIndex = 0;
            // 
            // dtpEmision
            // 
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(4, 31);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(104, 20);
            this.dtpEmision.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(113, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 23);
            this.label12.TabIndex = 42;
            this.label12.Text = "Autorizado Por";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Emision";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(414, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(142, 23);
            this.label28.TabIndex = 26;
            this.label28.Text = "Bodega";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(764, 51);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.ReadOnly = true;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroDocumento.TabIndex = 12;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(718, 33);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(162, 16);
            this.lblFolio.TabIndex = 42;
            this.lblFolio.Text = "Toma de Inventario N°";
            // 
            // panelZonaDetalle
            // 
            this.panelZonaDetalle.Controls.Add(this.btnAgregar);
            this.panelZonaDetalle.Controls.Add(this.btnModificaLinea);
            this.panelZonaDetalle.Controls.Add(this.txtStockFisico);
            this.panelZonaDetalle.Controls.Add(this.label2);
            this.panelZonaDetalle.Controls.Add(this.btnLimpiaLineaDetalle);
            this.panelZonaDetalle.Controls.Add(this.txtCodigo);
            this.panelZonaDetalle.Controls.Add(this.txtStockSistema);
            this.panelZonaDetalle.Controls.Add(this.txtDescripcion);
            this.panelZonaDetalle.Controls.Add(this.label14);
            this.panelZonaDetalle.Controls.Add(this.label13);
            this.panelZonaDetalle.Controls.Add(this.label17);
            this.panelZonaDetalle.Location = new System.Drawing.Point(3, 6);
            this.panelZonaDetalle.Name = "panelZonaDetalle";
            this.panelZonaDetalle.Size = new System.Drawing.Size(854, 57);
            this.panelZonaDetalle.TabIndex = 44;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(678, 16);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificaLinea
            // 
            this.btnModificaLinea.Location = new System.Drawing.Point(738, 16);
            this.btnModificaLinea.Name = "btnModificaLinea";
            this.btnModificaLinea.Size = new System.Drawing.Size(65, 23);
            this.btnModificaLinea.TabIndex = 33;
            this.btnModificaLinea.Text = "Modificar";
            this.btnModificaLinea.UseVisualStyleBackColor = true;
            // 
            // txtStockFisico
            // 
            this.txtStockFisico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockFisico.ForeColor = System.Drawing.Color.Black;
            this.txtStockFisico.Location = new System.Drawing.Point(473, 18);
            this.txtStockFisico.Name = "txtStockFisico";
            this.txtStockFisico.Size = new System.Drawing.Size(84, 21);
            this.txtStockFisico.TabIndex = 4;
            this.txtStockFisico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStockFisico.TextChanged += new System.EventHandler(this.txtStockFisico_TextChanged);
            this.txtStockFisico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockFisico_KeyDown);
            this.txtStockFisico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockFisico_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(473, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Stock Fisico";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLimpiaLineaDetalle
            // 
            this.btnLimpiaLineaDetalle.Location = new System.Drawing.Point(652, 5);
            this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
            this.btnLimpiaLineaDetalle.Size = new System.Drawing.Size(20, 35);
            this.btnLimpiaLineaDetalle.TabIndex = 33;
            this.btnLimpiaLineaDetalle.Text = "..";
            this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaLineaDetalle.Click += new System.EventHandler(this.btnLimpiaLineaDetalle_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(2, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 21);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtStockSistema
            // 
            this.txtStockSistema.BackColor = System.Drawing.Color.GhostWhite;
            this.txtStockSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockSistema.ForeColor = System.Drawing.Color.Black;
            this.txtStockSistema.Location = new System.Drawing.Point(562, 18);
            this.txtStockSistema.Name = "txtStockSistema";
            this.txtStockSistema.ReadOnly = true;
            this.txtStockSistema.Size = new System.Drawing.Size(84, 21);
            this.txtStockSistema.TabIndex = 11;
            this.txtStockSistema.TabStop = false;
            this.txtStockSistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStockSistema.TextChanged += new System.EventHandler(this.txtStockSistema_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(109, 18);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(359, 21);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.TabStop = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(109, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(359, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Descripcion";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(2, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Codigo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(562, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Stock Sistema";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(897, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 36);
            this.panel4.TabIndex = 31;
            this.panel4.Visible = false;
            // 
            // txtDiferencia
            // 
            this.txtDiferencia.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiferencia.ForeColor = System.Drawing.Color.Black;
            this.txtDiferencia.Location = new System.Drawing.Point(907, 234);
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.ReadOnly = true;
            this.txtDiferencia.Size = new System.Drawing.Size(92, 21);
            this.txtDiferencia.TabIndex = 15;
            this.txtDiferencia.TabStop = false;
            this.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiferencia.Visible = false;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(907, 220);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 23);
            this.label20.TabIndex = 7;
            this.label20.Text = "Diferencia";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label20.Visible = false;
            // 
            // btnLimpiaDetalle
            // 
            this.btnLimpiaDetalle.Location = new System.Drawing.Point(743, 7);
            this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
            this.btnLimpiaDetalle.Size = new System.Drawing.Size(116, 51);
            this.btnLimpiaDetalle.TabIndex = 45;
            this.btnLimpiaDetalle.Text = "Limpiar Lista";
            this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaDetalle.Click += new System.EventHandler(this.btnLimpiaDetalle_Click);
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(108, 35);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(88, 23);
            this.btnImprime.TabIndex = 8;
            this.btnImprime.Text = "RE-IMPRIMIR";
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(196, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(196, 7);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(4, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 51);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDA [F2]";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(108, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnComprobarMovimientos);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnLimpiaDetalle);
            this.panel1.Controls.Add(this.btnImprime);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Location = new System.Drawing.Point(12, 574);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 69);
            this.panel1.TabIndex = 52;
            // 
            // btnComprobarMovimientos
            // 
            this.btnComprobarMovimientos.Location = new System.Drawing.Point(574, 7);
            this.btnComprobarMovimientos.Name = "btnComprobarMovimientos";
            this.btnComprobarMovimientos.Size = new System.Drawing.Size(160, 51);
            this.btnComprobarMovimientos.TabIndex = 46;
            this.btnComprobarMovimientos.Text = "Comprobar Movimientos de Inventario Antes de Ajuste";
            this.btnComprobarMovimientos.UseVisualStyleBackColor = true;
            this.btnComprobarMovimientos.Click += new System.EventHandler(this.btnComprobarMovimientos_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 95);
            this.tabControl1.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage1.Controls.Add(this.panelZonaDetalle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 69);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar productos por codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage2.Controls.Add(this.btnAgregarCategorias);
            this.tabPage2.Controls.Add(this.cmbCategoria);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(863, 69);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar productos por Categorias";
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.Location = new System.Drawing.Point(196, 13);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarCategorias.TabIndex = 8;
            this.btnAgregarCategorias.Text = "Agregar";
            this.btnAgregarCategorias.UseVisualStyleBackColor = true;
            this.btnAgregarCategorias.Click += new System.EventHandler(this.btnAgregarCategorias_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(8, 30);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(183, 21);
            this.cmbCategoria.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria";
            // 
            // panelFolio
            // 
            this.panelFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFolio.Controls.Add(this.btnCerrarPanelFolio);
            this.panelFolio.Controls.Add(this.btnBuscaFolio);
            this.panelFolio.Controls.Add(this.txtFolioBuscar);
            this.panelFolio.Controls.Add(this.label32);
            this.panelFolio.Location = new System.Drawing.Point(715, 75);
            this.panelFolio.Name = "panelFolio";
            this.panelFolio.Size = new System.Drawing.Size(223, 92);
            this.panelFolio.TabIndex = 55;
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
            this.txtFolioBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFolioBuscar_KeyDown);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarFacturaTeclaF6ToolStripMenuItem,
            this.guardarFacturaTeclaF2ToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarFacturaTeclaF6ToolStripMenuItem
            // 
            this.buscarFacturaTeclaF6ToolStripMenuItem.Name = "buscarFacturaTeclaF6ToolStripMenuItem";
            this.buscarFacturaTeclaF6ToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.buscarFacturaTeclaF6ToolStripMenuItem.Text = "Buscar Toma de Inventario - tecla [F6]";
            this.buscarFacturaTeclaF6ToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturaTeclaF6ToolStripMenuItem_Click);
            // 
            // guardarFacturaTeclaF2ToolStripMenuItem
            // 
            this.guardarFacturaTeclaF2ToolStripMenuItem.Name = "guardarFacturaTeclaF2ToolStripMenuItem";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.guardarFacturaTeclaF2ToolStripMenuItem.Text = "Guardar Toma de Inventario - tecla[F2]";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "PENDIENTE",
            "FINALIZADA"});
            this.cmbEstado.Location = new System.Drawing.Point(584, 43);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(585, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Estado";
            // 
            // frmTomaInventario
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1002, 734);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelFolio);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.txtDiferencia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.KeyPreview = true;
            this.Name = "frmTomaInventario";
            this.ShowIcon = false;
            this.Text = "Toma de Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTomaInventario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelZonaDetalle.ResumeLayout(false);
            this.panelZonaDetalle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelFolio.ResumeLayout(false);
            this.panelFolio.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void iniciaFormulario()
    {
      this.cargaFolio();
      this.cmbEstado.SelectedIndex = 0;
      this.agregadosPorCategoria = false;
      this.cmbBodega.SelectedValue = (object) 1;
      this.cmbCategoria.SelectedValue = (object) 0;
      this.idToma = 0;
      this.costo = new Decimal(0);
      this.dtpEmision.Value = DateTime.Now;
      this.txtAutorizado.Clear();
      this.lista.Clear();
      this.listaGuarda.Clear();
      this.dgvDatos.DataSource = (object) null;
      this.btnEliminar.Enabled = false;
      this.btnImprime.Enabled = false;
      this.iniciaDetalle();
      this.panelFolio.Visible = false;
      this.txtFolioBuscar.Clear();
      this.btnComprobarMovimientos.Enabled = true;
      this.txtAutorizado.Focus();
    }

    private void iniciaDetalle()
    {
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtStockFisico.Clear();
      this.txtStockSistema.Clear();
      this.txtDiferencia.Clear();
      this.costo = new Decimal(0);
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Visible = true;
    }

    private void cargaFolio()
    {
      this.txtNumeroDocumento.Text = new TomaInventarioClass().numeroTomaInventario().ToString();
    }

    private void cargaBodegas()
    {
      this.cmbBodega.DataSource = (object) new CargaMaestros().cargaBodega();
      this.cmbBodega.ValueMember = "codigo";
      this.cmbBodega.DisplayMember = "descripcion";
    }

    private void cargaCategorias()
    {
      List<CategoriaVO> list = new Categoria().listaCategorias();
      foreach (CategoriaVO categoriaVo in list)
      {
        if (categoriaVo.Descripcion.Equals("[SELECCIONE]"))
          categoriaVo.Descripcion = "[TODAS]";
      }
      this.cmbCategoria.DataSource = (object) list;
      this.cmbCategoria.DisplayMember = "Descripcion";
      this.cmbCategoria.ValueMember = "IdCategoria";
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnLimpiaDetalle_Click(object sender, EventArgs e)
    {
      this.lista.Clear();
      this.dgvDatos.DataSource = (object) null;
      this.txtCodigo.Focus();
    }

    private void btnLimpiaLineaDetalle_Click(object sender, EventArgs e)
    {
      this.iniciaDetalle();
      this.txtCodigo.Focus();
    }

    private void buscaProductoCodigo()
    {
      ProductoVO productoVo = new Producto().buscaCodigoProducto(this.txtCodigo.Text.Trim());
      if (productoVo.Codigo != null)
      {
        this.txtDescripcion.Text = productoVo.Descripcion;
        Decimal num = new Decimal(0);
        switch (Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()))
        {
          case 1:
            num = productoVo.Bodega1;
            break;
          case 2:
            num = productoVo.Bodega2;
            break;
          case 3:
            num = productoVo.Bodega3;
            break;
          case 4:
            num = productoVo.Bodega4;
            break;
          case 5:
            num = productoVo.Bodega5;
            break;
          case 6:
            num = productoVo.Bodega6;
            break;
          case 7:
            num = productoVo.Bodega7;
            break;
          case 8:
            num = productoVo.Bodega8;
            break;
          case 9:
            num = productoVo.Bodega9;
            break;
          case 10:
            num = productoVo.Bodega10;
            break;
          case 11:
            num = productoVo.Bodega11;
            break;
          case 12:
            num = productoVo.Bodega12;
            break;
          case 13:
            num = productoVo.Bodega13;
            break;
          case 14:
            num = productoVo.Bodega14;
            break;
          case 15:
            num = productoVo.Bodega15;
            break;
          case 16:
            num = productoVo.Bodega16;
            break;
          case 17:
            num = productoVo.Bodega17;
            break;
          case 18:
            num = productoVo.Bodega18;
            break;
          case 19:
            num = productoVo.Bodega19;
            break;
          case 20:
            num = productoVo.Bodega20;
            break;
        }
        this.txtStockSistema.Text = num.ToString("N0");
        this.costo = productoVo.ValorCompra;
        this.txtStockFisico.Focus();
      }
      else
      {
        int num1 = (int) MessageBox.Show("No existe codigo ingresado", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void calculaDiferenciaTexBox()
    {
      this.txtDiferencia.Text = this.calculoDiferencia(this.txtStockFisico.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtStockFisico.Text.Trim()) : new Decimal(0), this.txtStockSistema.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtStockSistema.Text.Trim()) : new Decimal(0)).ToString("N0");
    }

    private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return || this.txtCodigo.Text.Length <= 0)
        return;
      this.buscaProductoCodigo();
    }

    private void txtStockSistema_TextChanged(object sender, EventArgs e)
    {
      this.calculaDiferenciaTexBox();
    }

    private void txtStockFisico_TextChanged(object sender, EventArgs e)
    {
      this.calculaDiferenciaTexBox();
    }

    private void agregaLineaGrilla()
    { ///se cae en vacio
        try
        {
            ProductoVO productoVo1 = new ProductoVO();
            productoVo1.Codigo = this.txtCodigo.Text.Trim();
            productoVo1.Descripcion = this.txtDescripcion.Text.Trim();
            productoVo1.StockSistema = Convert.ToDecimal(this.txtStockSistema.Text.Trim());
            productoVo1.StockFisico = Convert.ToDecimal(this.txtStockFisico.Text.Trim());
            productoVo1.Diferencia = Convert.ToDecimal(this.txtDiferencia.Text.Trim());
            productoVo1.ValorCompra = this.costo;
            if (this.lista.Count > 0)
            {
                bool flag = false;
                for (int index = 0; index < this.lista.Count; ++index)
                {
                    if (productoVo1.Codigo.Equals(this.lista[index].Codigo))
                    {
                        this.lista[index].StockFisico = this.lista[index].StockFisico + productoVo1.StockFisico;
                        this.lista[index].Diferencia = this.calculoDiferencia(this.lista[index].StockFisico, this.lista[index].StockSistema);
                        flag = true;
                        index = this.lista.Count;
                    }
                }
                if (!flag)
                    this.lista.Add(productoVo1);
            }
            else
                this.lista.Add(productoVo1);
            int num = 1;
            foreach (ProductoVO productoVo2 in this.lista)
            {
                productoVo2.Linea = num;
                ++num;
            }
            this.dgvDatos.DataSource = (object)null;
            this.dgvDatos.DataSource = (object)this.lista;
            this.dgvDatos.CurrentCell = this.dgvDatos[1, this.dgvDatos.Rows.Count - 1];
            this.iniciaDetalle();
            this.txtCodigo.Focus();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      this.agregaLineaGrilla();
    }

    private void txtStockFisico_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return || this.txtStockFisico.Text.Length <= 0)
        return;
      this.agregaLineaGrilla();
    }

    private void btnAgregarCategorias_Click(object sender, EventArgs e)
    {
      this.lista.Clear();
      this.dgvDatos.DataSource = (object) null;
      this.lista = new Producto().buscaProductoPorCategoria(this.cmbCategoria.SelectedText.ToString());
      int num1 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      Decimal num2 = new Decimal(0);
      int num3 = 1;
      foreach (ProductoVO productoVo in this.lista)
      {
        productoVo.Linea = num3;
        switch (num1)
        {
          case 1:
            num2 = productoVo.Bodega1;
            break;
          case 2:
            num2 = productoVo.Bodega2;
            break;
          case 3:
            num2 = productoVo.Bodega3;
            break;
          case 4:
            num2 = productoVo.Bodega4;
            break;
          case 5:
            num2 = productoVo.Bodega5;
            break;
          case 6:
            num2 = productoVo.Bodega6;
            break;
          case 7:
            num2 = productoVo.Bodega7;
            break;
          case 8:
            num2 = productoVo.Bodega8;
            break;
          case 9:
            num2 = productoVo.Bodega9;
            break;
          case 10:
            num2 = productoVo.Bodega10;
            break;
          case 11:
            num2 = productoVo.Bodega11;
            break;
          case 12:
            num2 = productoVo.Bodega12;
            break;
          case 13:
            num2 = productoVo.Bodega13;
            break;
          case 14:
            num2 = productoVo.Bodega14;
            break;
          case 15:
            num2 = productoVo.Bodega15;
            break;
          case 16:
            num2 = productoVo.Bodega16;
            break;
          case 17:
            num2 = productoVo.Bodega17;
            break;
          case 18:
            num2 = productoVo.Bodega18;
            break;
          case 19:
            num2 = productoVo.Bodega19;
            break;
          case 20:
            num2 = productoVo.Bodega20;
            break;
        }
        productoVo.StockSistema = num2;
        ++num3;
      }
      this.dgvDatos.DataSource = (object) this.lista;
      this.agregadosPorCategoria = true;
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

    private void txtStockFisico_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtStockFisico);
    }

    private TomaInventarioVO armaTomaInventario()
    {
      return new TomaInventarioVO()
      {
        IdTomaInventario = this.idToma,
        Fecha = this.dtpEmision.Value,
        Autoriza = this.txtAutorizado.Text.Trim(),
        BodegaInventario = Convert.ToInt32(this.cmbBodega.SelectedValue),
        Caja = frmMenuPrincipal.listaUsuario[0].IdCaja,
        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        Estado = this.cmbEstado.Text
      };
    }

    private bool valida()
    {
      if (this.txtAutorizado.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Persona autorizada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtAutorizado.Focus();
        return false;
      }
      if (Enumerable.Count<ProductoVO>((IEnumerable<ProductoVO>) this.lista) != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Productos a inventariar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtCodigo.Focus();
      return false;
    }

    private void guardaModifica()
    {
      if (!this.valida())
        return;
      if (this.cmbEstado.Text.Equals("FINALIZADA"))
      {
        if (MessageBox.Show("Esta seguro/a de Actualizar el inventario, El Stock Fisico remplazara al stock de Sistema", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          if (this.idToma == 0)
          {
            try
            {
              this.agregaGrillaaLista();
              new TomaInventarioClass().agregaTomaInventario(this.armaTomaInventario(), this.listaGuarda);
            }
            catch (Exception ex)
            {
              int num = (int) MessageBox.Show("Error " + ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
          }
          else
          {
            try
            {
              this.agregaGrillaaLista();
              new TomaInventarioClass().modificaTomaInventario(this.armaTomaInventario(), this.listaGuarda);
            }
            catch (Exception ex)
            {
              int num = (int) MessageBox.Show("Error " + ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
          }
          if (MessageBox.Show("Quiere Imprimir el comprobante?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.imprimeTomaInventario();
          this.iniciaFormulario();
        }
        else
        {
          int num1 = (int) MessageBox.Show("Toma de Inventario NO FUE Registrada ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        if (this.idToma == 0)
        {
          try
          {
            this.agregaGrillaaLista();
            new TomaInventarioClass().agregaTomaInventario(this.armaTomaInventario(), this.listaGuarda);
          }
          catch (Exception ex)
          {
            int num2 = (int) MessageBox.Show("Error " + ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
        {
          try
          {
            this.agregaGrillaaLista();
            new TomaInventarioClass().modificaTomaInventario(this.armaTomaInventario(), this.listaGuarda);
          }
          catch (Exception ex)
          {
            int num2 = (int) MessageBox.Show("Error " + ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        if (MessageBox.Show("Quiere Imprimir el comprobante?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          this.imprimeTomaInventario();
        this.iniciaFormulario();
      }
    }

    private void agregaGrillaaLista()
    {
      if (this.dgvDatos.RowCount <= 0)
        return;
      this.listaGuarda.Clear();
      ProductoVO productoVo1 = new ProductoVO();
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatos.Rows)
      {
        if (dataGridViewRow.Cells["Codigo"].Value != null && dataGridViewRow.Cells["Codigo"].Value.ToString() != "")
        {
          ProductoVO productoVo2 = new ProductoVO();
          productoVo2.Codigo = dataGridViewRow.Cells["Codigo"].Value.ToString();
          productoVo2.Descripcion = dataGridViewRow.Cells["Descripcion"].Value.ToString();
          productoVo2.StockFisico = dataGridViewRow.Cells["StockReal"].Value.ToString().Length > 0 ? Convert.ToDecimal(dataGridViewRow.Cells["StockReal"].Value.ToString()) : new Decimal(0);
          productoVo2.StockSistema = dataGridViewRow.Cells["StockSistema"].Value.ToString().Length > 0 ? Convert.ToDecimal(dataGridViewRow.Cells["StockSistema"].Value.ToString()) : new Decimal(0);
          productoVo2.Diferencia = this.calculoDiferencia(productoVo2.StockFisico, productoVo2.StockSistema);
          productoVo2.ValorCompra = dataGridViewRow.Cells["ValorCompra"].Value.ToString().Length > 0 ? Convert.ToDecimal(dataGridViewRow.Cells["ValorCompra"].Value.ToString()) : new Decimal(0);
          this.listaGuarda.Add(productoVo2);
        }
      }
    }

    private Decimal calculoDiferencia(Decimal stkFisico, Decimal stkSistema)
    {
      Decimal num = new Decimal(0);
      return !(stkSistema < new Decimal(0)) ? stkFisico - stkSistema : stkSistema + stkFisico;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaModifica();
    }

    private void buscarFacturaTeclaF6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Clear();
      this.txtFolioBuscar.Focus();
    }

    private void frmTomaInventario_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
        this.guardaModifica();
      if (e.KeyCode != Keys.F6)
        return;
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Focus();
    }

    private void buscaFolio()
    {
      if (this.txtFolioBuscar.Text.Trim().Length > 0)
      {
        TomaInventarioVO tomaInventarioVo = new TomaInventarioClass().buscaTomaInventarioID(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
        if (tomaInventarioVo.IdTomaInventario > 0)
        {
          this.idToma = tomaInventarioVo.IdTomaInventario;
          this.txtNumeroDocumento.Text = tomaInventarioVo.IdTomaInventario.ToString();
          this.dtpEmision.Value = tomaInventarioVo.Fecha;
          this.txtAutorizado.Text = tomaInventarioVo.Autoriza;
          this.cmbBodega.SelectedValue = (object) tomaInventarioVo.BodegaInventario;
          this.cmbEstado.Text = tomaInventarioVo.Estado;
          if (tomaInventarioVo.Estado.Equals("FINALIZADA"))
            this.btnComprobarMovimientos.Enabled = false;
          else
            this.btnComprobarMovimientos.Enabled = true;
          this.lista.Clear();
          this.lista = new TomaInventarioClass().buscaDetalleTomaInventarioID(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
          for (int index = 0; index < this.lista.Count; ++index)
            this.lista[index].Linea = index + 1;
          this.dgvDatos.DataSource = (object) this.lista;
          this.panelFolio.Visible = false;
          this.btnEliminar.Enabled = true;
          this.btnImprime.Enabled = true;
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe el Folio Ingresado", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.txtFolioBuscar.Focus();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Debe ingresar un numero de folio a buscar", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtFolioBuscar.Focus();
      }
    }

    private void btnBuscaFolio_Click(object sender, EventArgs e)
    {
      this.buscaFolio();
    }

    private void txtFolioBuscar_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaFolio();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro/a de Eliminar la Toma inventario", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      new TomaInventarioClass().eliminaTomaInventario(this.idToma);
      int num = (int) MessageBox.Show("Toma de Inventario Eliminada", "elimina", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.iniciaFormulario();
    }

    private void btnImprime_Click(object sender, EventArgs e)
    {
      this.imprimeTomaInventario();
    }

    private void imprimeTomaInventario()
    {
      DataTable dataTable = new TomaInventarioClass().muestraTomaInventarioFolio(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()));
      ReportDocument rpt = new ReportDocument();
      rpt.Load("C:\\AptuSoft\\reportes\\TomaInventario.rpt");
      rpt.SetDataSource(dataTable);
      int num = (int) new frmVisualizadorReportes(rpt).ShowDialog();
      this.iniciaFormulario();
    }

    private void dgvDatos_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dgvDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvDatos.SelectedRows[0].Cells["Codigo"].Value == null)
        return;
      try
      {
        string s = this.dgvDatos.SelectedRows[0].Cells["StockReal"].Value.ToString();
        Decimal result = new Decimal(0);
        if (Decimal.TryParse(s, out result))
        {
          result = this.dgvDatos.SelectedRows[0].Cells["StockReal"].Value.ToString().Length > 0 ? Convert.ToDecimal(this.dgvDatos.SelectedRows[0].Cells["StockReal"].Value.ToString()) : new Decimal(0);
          Decimal stkSistema = this.dgvDatos.SelectedRows[0].Cells["StockSistema"].Value.ToString().Length > 0 ? Convert.ToDecimal(this.dgvDatos.SelectedRows[0].Cells["StockSistema"].Value.ToString()) : new Decimal(0);
          Decimal num = new Decimal(0);
          this.dgvDatos.SelectedRows[0].Cells["Diferencia"].Value = (object) this.calculoDiferencia(result, stkSistema).ToString();
        }
        else
        {
          int num1 = (int) MessageBox.Show("Solo se Permite Ingresar Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("error " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void dgvDatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvDatos.Columns[e.ColumnIndex].Name == "Elimina") || MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      int num = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
      for (int index = 0; index < this.lista.Count; ++index)
      {
        if (this.lista[index].Linea == num)
        {
          this.lista.RemoveAt(index);
          --index;
        }
      }
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) this.lista;
    }

    private void dgvDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dgvDatos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
      if (this.dgvDatos.CurrentCell.ColumnIndex != 3)
        return;
      TextBox textBox = e.Control as TextBox;
      if (textBox != null)
      {
        textBox.KeyPress -= new KeyPressEventHandler(this.dgvDatos_KeyPress);
        textBox.KeyPress += new KeyPressEventHandler(this.dgvDatos_KeyPress);
        DataGridViewTextBoxEditingControl boxEditingControl = (DataGridViewTextBoxEditingControl) e.Control;
        boxEditingControl.KeyUp -= new KeyEventHandler(this.text_KeyUp);
        boxEditingControl.KeyUp += new KeyEventHandler(this.text_KeyUp);
      }
    }

    private void text_KeyUp(object sender, KeyEventArgs e)
    {
      int editingControlRowIndex = ((DataGridViewTextBoxEditingControl) sender).EditingControlRowIndex;
      if (e.KeyCode != Keys.Return)
        return;
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      if (editingControlRowIndex > 0)
      {
        Decimal num4 = this.calculoDiferencia(this.dgvDatos.Rows[editingControlRowIndex - 1].Cells["StockReal"].Value.ToString().Length > 0 ? Convert.ToDecimal(this.dgvDatos.Rows[editingControlRowIndex - 1].Cells["StockReal"].Value.ToString()) : new Decimal(0), this.dgvDatos.Rows[editingControlRowIndex - 1].Cells["StockSistema"].Value.ToString().Length > 0 ? Convert.ToDecimal(this.dgvDatos.Rows[editingControlRowIndex - 1].Cells["StockSistema"].Value.ToString()) : new Decimal(0));
        this.dgvDatos.Rows[editingControlRowIndex - 1].Cells["Diferencia"].Value = (object) num4.ToString();
      }
      else
      {
        Decimal num4 = this.calculoDiferencia(this.dgvDatos.Rows[editingControlRowIndex].Cells["StockReal"].Value.ToString().Length > 0 ? Convert.ToDecimal(this.dgvDatos.Rows[editingControlRowIndex].Cells["StockReal"].Value.ToString()) : new Decimal(0), this.dgvDatos.Rows[editingControlRowIndex].Cells["StockSistema"].Value.ToString().Length > 0 ? Convert.ToDecimal(this.dgvDatos.Rows[editingControlRowIndex].Cells["StockSistema"].Value.ToString()) : new Decimal(0));
        this.dgvDatos.Rows[editingControlRowIndex].Cells["Diferencia"].Value = (object) num4.ToString();
      }
    }

    private void dgvDatos_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.dgvDatos.CurrentCell.ColumnIndex != 3)
        return;
      int num = (int) e.KeyChar == 8 || char.IsNumber(e.KeyChar) ? 0 : ((int) e.KeyChar != 44 ? 1 : 0);
      e.Handled = num != 0;
    }

    private void btnComprobarMovimientos_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro/a de Comprobar Movimientos de inventarios hechos durante el proceso de toma de inventario, esto ajustara los stock fisico y de sistema", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || this.lista.Count <= 0)
        return;
      Decimal num1 = new Decimal(0);
      int num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      Decimal num3 = new Decimal(0);
      List<ProductoVO> list = new List<ProductoVO>();
      foreach (ProductoVO productoVo1 in this.lista)
      {
        Decimal num4 = new Decimal(0);
        num3 = new Decimal(0);
        ProductoVO productoVo2 = new Producto().buscaCodigoProducto(productoVo1.Codigo);
        switch (num2)
        {
          case 1:
            num4 = productoVo2.Bodega1;
            break;
          case 2:
            num4 = productoVo2.Bodega2;
            break;
          case 3:
            num4 = productoVo2.Bodega3;
            break;
          case 4:
            num4 = productoVo2.Bodega4;
            break;
          case 5:
            num4 = productoVo2.Bodega5;
            break;
          case 6:
            num4 = productoVo2.Bodega6;
            break;
          case 7:
            num4 = productoVo2.Bodega7;
            break;
          case 8:
            num4 = productoVo2.Bodega8;
            break;
          case 9:
            num4 = productoVo2.Bodega9;
            break;
          case 10:
            num4 = productoVo2.Bodega10;
            break;
          case 11:
            num4 = productoVo2.Bodega11;
            break;
          case 12:
            num4 = productoVo2.Bodega12;
            break;
          case 13:
            num4 = productoVo2.Bodega13;
            break;
          case 14:
            num4 = productoVo2.Bodega14;
            break;
          case 15:
            num4 = productoVo2.Bodega15;
            break;
          case 16:
            num4 = productoVo2.Bodega16;
            break;
          case 17:
            num4 = productoVo2.Bodega17;
            break;
          case 18:
            num4 = productoVo2.Bodega18;
            break;
          case 19:
            num4 = productoVo2.Bodega19;
            break;
          case 20:
            num4 = productoVo2.Bodega20;
            break;
        }
        if (productoVo1.StockSistema != num4)
        {
          Decimal num5 = productoVo1.StockSistema - num4;
          productoVo1.StockSistema = num4;
          productoVo1.StockFisico = productoVo1.StockFisico - num5;
          productoVo1.Diferencia = this.calculoDiferencia(productoVo1.StockFisico, productoVo1.StockSistema);
          productoVo1.Marca = num5.ToString();
          list.Add(productoVo1);
        }
      }
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) this.lista;
      if (list.Count > 0)
      {
        foreach (ProductoVO productoVo in list)
          this.marcaFilasModificadas(productoVo.Codigo, productoVo.Marca);
        int num4 = (int) MessageBox.Show((string) (object) list.Count + (object) " Productos presentaron movimientos durante la toma de inventario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num6 = (int) MessageBox.Show("No Hay mMovimientos de inventario durante el proceso Toma", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void marcaFilasModificadas(string codigo, string diferencia)
    {
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatos.Rows)
      {
        if (codigo == dataGridViewRow.Cells["Codigo"].Value.ToString())
          dataGridViewRow.Cells["Alerta"].Value = (object) diferencia;
      }
    }
  }
}
