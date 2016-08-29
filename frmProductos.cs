 
// Type: Aptusoft.frmProductos
 
 
// version 1.8.0

using Aptusoft.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmProductos : Form
  {
    private IContainer components = (IContainer) null;
    private int _codEncontrado = 0;
    private ArrayList listaStock = new ArrayList();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private bool _modificaStock = false;
    private string rutaIMG1 = "";
    private string rutaIMG2 = "";
    private string rutaIMG3 = "";
    private TextBox txtMarca;
    private TextBox txtDescripcion;
    private CheckBox chkExento;
    private CheckBox chkPesable;
    private ComboBox cmbCategoria;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox txtValorVenta3;
    private TextBox txtValorVenta2;
    private TextBox txtValorVenta1;
    private TextBox txtUtilidad3;
    private TextBox txtUtilidad2;
    private TextBox txtUtilidad1;
    private TextBox txtValorCompra;
    private Label lblLista3;
    private Label lblLista2;
    private Label lblLista1;
    private Label label5;
    private CheckBox chkIngresaUtilidad;
    private Panel panel3;
    private ComboBox cmbBuscaCategoria;
    private Label label13;
    private Label label12;
    private TextBox txtBusca;
    private Button btnBuscar;
    private TextBox txtBodega7;
    private TextBox txtBodega6;
    private TextBox txtBodega5;
    private TextBox txtBodega4;
    private TextBox txtBodega3;
    private TextBox txtBodega2;
    private TextBox txtBodega1;
    private Label lblBodega10;
    private Label lblBodega9;
    private Label lblBodega8;
    private Label lblBodega7;
    private Label lblBodega6;
    private Label lblBodega5;
    private Label lblBodega4;
    private Label lblBodega3;
    private Label lblBodega2;
    private Label lblBodega1;
    private TextBox txtBodega9;
    private TextBox txtBodega10;
    private TextBox txtBodega8;
    private ComboBox cmbUnidadMedida;
    private TextBox txtStockMinimo;
    private Label label26;
    private Label label25;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnEliminar;
    private Button btnModificar;
    private Button btnGuardar;
    private GroupBox groupBox1;
    private TextBox txtCodigo;
    private DataGridView dgvProductos;
    private Button button1;
    private Button btnIngresarCategoria;
    private ComboBox cmbImpuesto;
    private Label label24;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private PictureBox pictureBox3;
    private PictureBox pictureBox2;
    private PictureBox pictureBox1;
    private Button btnQuitaIMG3;
    private Button btnAgregaIMG3;
    private Button btnQuitaIMG2;
    private Button btnAgregaIMG2;
    private Button btnQuitaIMG1;
    private Button btnAgregaIMG1;
    private CheckBox chkKit;
    private TextBox txtCodigoAlternativo;
    private Label label27;
    private Button btnMostrarImagenes;
    private Button btnPesables;
    private Label lblResumenDescripcion;
    private TextBox txtResumenDescripcion;
    private ComboBox cmbSubCategoria;
    private Label label6;
    private TabControl tabControl2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private DataGridView dgvLote;
    private DataGridViewTextBoxColumn Lote;
    private DataGridViewTextBoxColumn Cantidad;
    private DataGridViewTextBoxColumn Bodega;
    private DataGridViewTextBoxColumn BodegaNombre;
    private Panel panel1;
    private TextBox txtBodega11;
    private TextBox txtBodega12;
    private Label lblBodega11;
    private TextBox txtBodega13;
    private Label lblBodega12;
    private TextBox txtBodega14;
    private Label lblBodega13;
    private TextBox txtBodega15;
    private Label lblBodega14;
    private TextBox txtBodega16;
    private Label lblBodega15;
    private TextBox txtBodega17;
    private Label lblBodega16;
    private TextBox txtBodega18;
    private Label lblBodega17;
    private TextBox txtBodega20;
    private Label lblBodega18;
    private TextBox txtBodega19;
    private Label lblBodega19;
    private Label lblBodega20;
    private Panel panel2;
    private TextBox txtUtilidad5;
    private TextBox txtUtilidad4;
    private TextBox txtValorVenta5;
    private Label lblLista4;
    private TextBox txtValorVenta4;
    private Label lblLista5;
    private Panel panel4;
    private bool _conIva;
    private Decimal _iva;

    public frmProductos()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.obtieneIva();
      this.cargaCategorias();
      this.cargaUnidadMedida();
      this.cargaImpuestos();
      this.dgvLote.AutoGenerateColumns = false;
      if (frmMenuPrincipal._Pesable)
      {
        this.btnPesables.Visible = true;
        this.chkPesable.Visible = true;
      }
      else
      {
        this.btnPesables.Visible = false;
        this.chkPesable.Visible = false;
      }
      if (frmMenuPrincipal._Fiscal)
      {
        this.lblResumenDescripcion.Visible = true;
        this.txtResumenDescripcion.Visible = true;
        this.txtResumenDescripcion.Clear();
      }
      else
      {
        this.lblResumenDescripcion.Visible = false;
        this.txtResumenDescripcion.Visible = false;
        this.txtResumenDescripcion.Clear();
      }
      if (this._modificaStock)
      {
        this.txtBodega1.ReadOnly = false;
        this.txtBodega2.ReadOnly = false;
        this.txtBodega3.ReadOnly = false;
        this.txtBodega4.ReadOnly = false;
        this.txtBodega5.ReadOnly = false;
        this.txtBodega6.ReadOnly = false;
        this.txtBodega7.ReadOnly = false;
        this.txtBodega8.ReadOnly = false;
        this.txtBodega9.ReadOnly = false;
        this.txtBodega10.ReadOnly = false;
        this.txtBodega11.ReadOnly = false;
        this.txtBodega12.ReadOnly = false;
        this.txtBodega13.ReadOnly = false;
        this.txtBodega14.ReadOnly = false;
        this.txtBodega15.ReadOnly = false;
        this.txtBodega16.ReadOnly = false;
        this.txtBodega17.ReadOnly = false;
        this.txtBodega18.ReadOnly = false;
        this.txtBodega19.ReadOnly = false;
        this.txtBodega20.ReadOnly = false;
      }
      else
      {
        this.txtBodega1.ReadOnly = true;
        this.txtBodega2.ReadOnly = true;
        this.txtBodega3.ReadOnly = true;
        this.txtBodega4.ReadOnly = true;
        this.txtBodega5.ReadOnly = true;
        this.txtBodega6.ReadOnly = true;
        this.txtBodega7.ReadOnly = true;
        this.txtBodega8.ReadOnly = true;
        this.txtBodega9.ReadOnly = true;
        this.txtBodega10.ReadOnly = true;
        this.txtBodega11.ReadOnly = true;
        this.txtBodega12.ReadOnly = true;
        this.txtBodega13.ReadOnly = true;
        this.txtBodega14.ReadOnly = true;
        this.txtBodega15.ReadOnly = true;
        this.txtBodega16.ReadOnly = true;
        this.txtBodega17.ReadOnly = true;
        this.txtBodega18.ReadOnly = true;
        this.txtBodega19.ReadOnly = true;
        this.txtBodega20.ReadOnly = true;
      }
      this.iniciaProducto();
      this.cargaBodegas();
      this.cargaListas();
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.chkPesable = new System.Windows.Forms.CheckBox();
            this.chkExento = new System.Windows.Forms.CheckBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBodega10 = new System.Windows.Forms.Label();
            this.lblBodega9 = new System.Windows.Forms.Label();
            this.lblBodega8 = new System.Windows.Forms.Label();
            this.lblBodega7 = new System.Windows.Forms.Label();
            this.lblBodega6 = new System.Windows.Forms.Label();
            this.lblBodega5 = new System.Windows.Forms.Label();
            this.lblBodega4 = new System.Windows.Forms.Label();
            this.lblBodega3 = new System.Windows.Forms.Label();
            this.lblBodega2 = new System.Windows.Forms.Label();
            this.lblBodega1 = new System.Windows.Forms.Label();
            this.txtBodega9 = new System.Windows.Forms.TextBox();
            this.txtBodega10 = new System.Windows.Forms.TextBox();
            this.txtBodega8 = new System.Windows.Forms.TextBox();
            this.txtBodega7 = new System.Windows.Forms.TextBox();
            this.txtBodega6 = new System.Windows.Forms.TextBox();
            this.txtBodega5 = new System.Windows.Forms.TextBox();
            this.txtBodega4 = new System.Windows.Forms.TextBox();
            this.txtBodega3 = new System.Windows.Forms.TextBox();
            this.txtBodega2 = new System.Windows.Forms.TextBox();
            this.txtBodega1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBuscaCategoria = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.chkIngresaUtilidad = new System.Windows.Forms.CheckBox();
            this.txtValorVenta3 = new System.Windows.Forms.TextBox();
            this.txtValorVenta2 = new System.Windows.Forms.TextBox();
            this.txtValorVenta1 = new System.Windows.Forms.TextBox();
            this.txtUtilidad3 = new System.Windows.Forms.TextBox();
            this.txtUtilidad2 = new System.Windows.Forms.TextBox();
            this.txtUtilidad1 = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblLista3 = new System.Windows.Forms.Label();
            this.lblLista2 = new System.Windows.Forms.Label();
            this.lblLista1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUtilidad5 = new System.Windows.Forms.TextBox();
            this.txtUtilidad4 = new System.Windows.Forms.TextBox();
            this.txtValorVenta5 = new System.Windows.Forms.TextBox();
            this.lblLista4 = new System.Windows.Forms.Label();
            this.cmbImpuesto = new System.Windows.Forms.ComboBox();
            this.txtValorVenta4 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblLista5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkKit = new System.Windows.Forms.CheckBox();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIngresarCategoria = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCodigoAlternativo = new System.Windows.Forms.TextBox();
            this.txtResumenDescripcion = new System.Windows.Forms.TextBox();
            this.lblResumenDescripcion = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPesables = new System.Windows.Forms.Button();
            this.txtBodega11 = new System.Windows.Forms.TextBox();
            this.txtBodega12 = new System.Windows.Forms.TextBox();
            this.lblBodega11 = new System.Windows.Forms.Label();
            this.txtBodega13 = new System.Windows.Forms.TextBox();
            this.lblBodega12 = new System.Windows.Forms.Label();
            this.txtBodega14 = new System.Windows.Forms.TextBox();
            this.lblBodega13 = new System.Windows.Forms.Label();
            this.txtBodega15 = new System.Windows.Forms.TextBox();
            this.lblBodega14 = new System.Windows.Forms.Label();
            this.txtBodega16 = new System.Windows.Forms.TextBox();
            this.lblBodega15 = new System.Windows.Forms.Label();
            this.txtBodega17 = new System.Windows.Forms.TextBox();
            this.lblBodega16 = new System.Windows.Forms.Label();
            this.txtBodega18 = new System.Windows.Forms.TextBox();
            this.lblBodega17 = new System.Windows.Forms.Label();
            this.txtBodega20 = new System.Windows.Forms.TextBox();
            this.lblBodega18 = new System.Windows.Forms.Label();
            this.txtBodega19 = new System.Windows.Forms.TextBox();
            this.lblBodega19 = new System.Windows.Forms.Label();
            this.lblBodega20 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodegaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMostrarImagenes = new System.Windows.Forms.Button();
            this.btnQuitaIMG3 = new System.Windows.Forms.Button();
            this.btnAgregaIMG3 = new System.Windows.Forms.Button();
            this.btnQuitaIMG2 = new System.Windows.Forms.Button();
            this.btnAgregaIMG2 = new System.Windows.Forms.Button();
            this.btnQuitaIMG1 = new System.Windows.Forms.Button();
            this.btnAgregaIMG1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(107, 32);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(359, 20);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Location = new System.Drawing.Point(107, 82);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(246, 20);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(107, 107);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(246, 21);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoria_SelectionChangeCommitted);
            this.cmbCategoria.Enter += new System.EventHandler(this.cmbCategoria_Enter);
            this.cmbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoria_KeyPress);
            this.cmbCategoria.Leave += new System.EventHandler(this.cmbCategoria_Leave);
            this.cmbCategoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCategoria_MouseClick);
            // 
            // chkPesable
            // 
            this.chkPesable.AutoSize = true;
            this.chkPesable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPesable.Location = new System.Drawing.Point(508, 47);
            this.chkPesable.Name = "chkPesable";
            this.chkPesable.Size = new System.Drawing.Size(64, 17);
            this.chkPesable.TabIndex = 8;
            this.chkPesable.Text = "Pesable";
            this.chkPesable.UseVisualStyleBackColor = true;
            // 
            // chkExento
            // 
            this.chkExento.AutoSize = true;
            this.chkExento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkExento.Location = new System.Drawing.Point(513, 6);
            this.chkExento.Name = "chkExento";
            this.chkExento.Size = new System.Drawing.Size(59, 17);
            this.chkExento.TabIndex = 7;
            this.chkExento.Text = "Exento";
            this.chkExento.UseVisualStyleBackColor = true;
            this.chkExento.CheckedChanged += new System.EventHandler(this.chkExento_CheckedChanged);
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUnidadMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(107, 157);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(246, 21);
            this.cmbUnidadMedida.TabIndex = 6;
            this.cmbUnidadMedida.Enter += new System.EventHandler(this.cmbUnidadMedida_Enter);
            this.cmbUnidadMedida.Leave += new System.EventHandler(this.cmbUnidadMedida_Leave);
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockMinimo.Location = new System.Drawing.Point(6, 483);
            this.txtStockMinimo.MaxLength = 10;
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(61, 20);
            this.txtStockMinimo.TabIndex = 17;
            this.txtStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStockMinimo.Enter += new System.EventHandler(this.txtStockMinimo_Enter);
            this.txtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMinimo_KeyPress);
            this.txtStockMinimo.Leave += new System.EventHandler(this.txtStockMinimo_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(8, 161);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Unidad de Medida";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(73, 483);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(153, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "Alerta Stock Minimo";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(3, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 70);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Aptusoft.Properties.Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(3, 222);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpia";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::Aptusoft.Properties.Resources.mark_correo_basura_icono_3897_48;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(3, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 70);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Elimina";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::Aptusoft.Properties.Resources.modificar_48;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(3, 76);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 70);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modifica";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Aptusoft.Properties.Resources.disquetes_excepto_icono_7120_48;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 70);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guarda";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBodega10
            // 
            this.lblBodega10.AutoSize = true;
            this.lblBodega10.ForeColor = System.Drawing.Color.Black;
            this.lblBodega10.Location = new System.Drawing.Point(73, 208);
            this.lblBodega10.Name = "lblBodega10";
            this.lblBodega10.Size = new System.Drawing.Size(59, 13);
            this.lblBodega10.TabIndex = 17;
            this.lblBodega10.Text = "Bodega 10";
            // 
            // lblBodega9
            // 
            this.lblBodega9.AutoSize = true;
            this.lblBodega9.ForeColor = System.Drawing.Color.Black;
            this.lblBodega9.Location = new System.Drawing.Point(73, 186);
            this.lblBodega9.Name = "lblBodega9";
            this.lblBodega9.Size = new System.Drawing.Size(53, 13);
            this.lblBodega9.TabIndex = 16;
            this.lblBodega9.Text = "Bodega 9";
            // 
            // lblBodega8
            // 
            this.lblBodega8.AutoSize = true;
            this.lblBodega8.ForeColor = System.Drawing.Color.Black;
            this.lblBodega8.Location = new System.Drawing.Point(73, 164);
            this.lblBodega8.Name = "lblBodega8";
            this.lblBodega8.Size = new System.Drawing.Size(53, 13);
            this.lblBodega8.TabIndex = 15;
            this.lblBodega8.Text = "Bodega 8";
            // 
            // lblBodega7
            // 
            this.lblBodega7.AutoSize = true;
            this.lblBodega7.ForeColor = System.Drawing.Color.Black;
            this.lblBodega7.Location = new System.Drawing.Point(73, 142);
            this.lblBodega7.Name = "lblBodega7";
            this.lblBodega7.Size = new System.Drawing.Size(53, 13);
            this.lblBodega7.TabIndex = 14;
            this.lblBodega7.Text = "Bodega 7";
            // 
            // lblBodega6
            // 
            this.lblBodega6.AutoSize = true;
            this.lblBodega6.ForeColor = System.Drawing.Color.Black;
            this.lblBodega6.Location = new System.Drawing.Point(73, 120);
            this.lblBodega6.Name = "lblBodega6";
            this.lblBodega6.Size = new System.Drawing.Size(53, 13);
            this.lblBodega6.TabIndex = 13;
            this.lblBodega6.Text = "Bodega 6";
            // 
            // lblBodega5
            // 
            this.lblBodega5.AutoSize = true;
            this.lblBodega5.ForeColor = System.Drawing.Color.Black;
            this.lblBodega5.Location = new System.Drawing.Point(73, 98);
            this.lblBodega5.Name = "lblBodega5";
            this.lblBodega5.Size = new System.Drawing.Size(53, 13);
            this.lblBodega5.TabIndex = 12;
            this.lblBodega5.Text = "Bodega 5";
            // 
            // lblBodega4
            // 
            this.lblBodega4.AutoSize = true;
            this.lblBodega4.ForeColor = System.Drawing.Color.Black;
            this.lblBodega4.Location = new System.Drawing.Point(73, 76);
            this.lblBodega4.Name = "lblBodega4";
            this.lblBodega4.Size = new System.Drawing.Size(53, 13);
            this.lblBodega4.TabIndex = 11;
            this.lblBodega4.Text = "Bodega 4";
            // 
            // lblBodega3
            // 
            this.lblBodega3.AutoSize = true;
            this.lblBodega3.ForeColor = System.Drawing.Color.Black;
            this.lblBodega3.Location = new System.Drawing.Point(73, 54);
            this.lblBodega3.Name = "lblBodega3";
            this.lblBodega3.Size = new System.Drawing.Size(53, 13);
            this.lblBodega3.TabIndex = 10;
            this.lblBodega3.Text = "Bodega 3";
            // 
            // lblBodega2
            // 
            this.lblBodega2.AutoSize = true;
            this.lblBodega2.ForeColor = System.Drawing.Color.Black;
            this.lblBodega2.Location = new System.Drawing.Point(73, 32);
            this.lblBodega2.Name = "lblBodega2";
            this.lblBodega2.Size = new System.Drawing.Size(53, 13);
            this.lblBodega2.TabIndex = 9;
            this.lblBodega2.Text = "Bodega 2";
            // 
            // lblBodega1
            // 
            this.lblBodega1.AutoSize = true;
            this.lblBodega1.ForeColor = System.Drawing.Color.Black;
            this.lblBodega1.Location = new System.Drawing.Point(73, 10);
            this.lblBodega1.Name = "lblBodega1";
            this.lblBodega1.Size = new System.Drawing.Size(53, 13);
            this.lblBodega1.TabIndex = 8;
            this.lblBodega1.Text = "Bodega 1";
            // 
            // txtBodega9
            // 
            this.txtBodega9.BackColor = System.Drawing.Color.White;
            this.txtBodega9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega9.Location = new System.Drawing.Point(6, 182);
            this.txtBodega9.MaxLength = 50;
            this.txtBodega9.Name = "txtBodega9";
            this.txtBodega9.Size = new System.Drawing.Size(61, 20);
            this.txtBodega9.TabIndex = 26;
            this.txtBodega9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega9.Enter += new System.EventHandler(this.txtBodega9_Enter);
            this.txtBodega9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega9_KeyPress);
            this.txtBodega9.Leave += new System.EventHandler(this.txtBodega9_Leave);
            // 
            // txtBodega10
            // 
            this.txtBodega10.BackColor = System.Drawing.Color.White;
            this.txtBodega10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega10.Location = new System.Drawing.Point(6, 204);
            this.txtBodega10.MaxLength = 50;
            this.txtBodega10.Name = "txtBodega10";
            this.txtBodega10.Size = new System.Drawing.Size(61, 20);
            this.txtBodega10.TabIndex = 27;
            this.txtBodega10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega10.Enter += new System.EventHandler(this.txtBodega10_Enter);
            this.txtBodega10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega10_KeyPress);
            this.txtBodega10.Leave += new System.EventHandler(this.txtBodega10_Leave);
            // 
            // txtBodega8
            // 
            this.txtBodega8.BackColor = System.Drawing.Color.White;
            this.txtBodega8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega8.Location = new System.Drawing.Point(6, 160);
            this.txtBodega8.MaxLength = 50;
            this.txtBodega8.Name = "txtBodega8";
            this.txtBodega8.Size = new System.Drawing.Size(61, 20);
            this.txtBodega8.TabIndex = 25;
            this.txtBodega8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega8.Enter += new System.EventHandler(this.txtBodega8_Enter);
            this.txtBodega8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega8_KeyPress);
            this.txtBodega8.Leave += new System.EventHandler(this.txtBodega8_Leave);
            // 
            // txtBodega7
            // 
            this.txtBodega7.BackColor = System.Drawing.Color.White;
            this.txtBodega7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega7.Location = new System.Drawing.Point(6, 138);
            this.txtBodega7.MaxLength = 50;
            this.txtBodega7.Name = "txtBodega7";
            this.txtBodega7.Size = new System.Drawing.Size(61, 20);
            this.txtBodega7.TabIndex = 24;
            this.txtBodega7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega7.Enter += new System.EventHandler(this.txtBodega7_Enter);
            this.txtBodega7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega7_KeyPress);
            this.txtBodega7.Leave += new System.EventHandler(this.txtBodega7_Leave);
            // 
            // txtBodega6
            // 
            this.txtBodega6.BackColor = System.Drawing.Color.White;
            this.txtBodega6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega6.Location = new System.Drawing.Point(6, 116);
            this.txtBodega6.MaxLength = 50;
            this.txtBodega6.Name = "txtBodega6";
            this.txtBodega6.Size = new System.Drawing.Size(61, 20);
            this.txtBodega6.TabIndex = 23;
            this.txtBodega6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega6.Enter += new System.EventHandler(this.txtBodega6_Enter);
            this.txtBodega6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega6_KeyPress);
            this.txtBodega6.Leave += new System.EventHandler(this.txtBodega6_Leave);
            // 
            // txtBodega5
            // 
            this.txtBodega5.BackColor = System.Drawing.Color.White;
            this.txtBodega5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega5.Location = new System.Drawing.Point(6, 94);
            this.txtBodega5.MaxLength = 50;
            this.txtBodega5.Name = "txtBodega5";
            this.txtBodega5.Size = new System.Drawing.Size(61, 20);
            this.txtBodega5.TabIndex = 22;
            this.txtBodega5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega5.Enter += new System.EventHandler(this.txtBodega5_Enter);
            this.txtBodega5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega5_KeyPress);
            this.txtBodega5.Leave += new System.EventHandler(this.txtBodega5_Leave);
            // 
            // txtBodega4
            // 
            this.txtBodega4.BackColor = System.Drawing.Color.White;
            this.txtBodega4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega4.Location = new System.Drawing.Point(6, 72);
            this.txtBodega4.MaxLength = 50;
            this.txtBodega4.Name = "txtBodega4";
            this.txtBodega4.Size = new System.Drawing.Size(61, 20);
            this.txtBodega4.TabIndex = 21;
            this.txtBodega4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega4.Enter += new System.EventHandler(this.txtBodega4_Enter);
            this.txtBodega4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega4_KeyPress);
            this.txtBodega4.Leave += new System.EventHandler(this.txtBodega4_Leave);
            // 
            // txtBodega3
            // 
            this.txtBodega3.BackColor = System.Drawing.Color.White;
            this.txtBodega3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega3.Location = new System.Drawing.Point(6, 50);
            this.txtBodega3.MaxLength = 50;
            this.txtBodega3.Name = "txtBodega3";
            this.txtBodega3.Size = new System.Drawing.Size(61, 20);
            this.txtBodega3.TabIndex = 20;
            this.txtBodega3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega3.Enter += new System.EventHandler(this.txtBodega3_Enter);
            this.txtBodega3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega3_KeyPress);
            this.txtBodega3.Leave += new System.EventHandler(this.txtBodega3_Leave);
            // 
            // txtBodega2
            // 
            this.txtBodega2.BackColor = System.Drawing.Color.White;
            this.txtBodega2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega2.Location = new System.Drawing.Point(6, 28);
            this.txtBodega2.MaxLength = 50;
            this.txtBodega2.Name = "txtBodega2";
            this.txtBodega2.Size = new System.Drawing.Size(61, 20);
            this.txtBodega2.TabIndex = 19;
            this.txtBodega2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega2.Enter += new System.EventHandler(this.txtBodega2_Enter);
            this.txtBodega2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega2_KeyPress);
            this.txtBodega2.Leave += new System.EventHandler(this.txtBodega2_Leave);
            // 
            // txtBodega1
            // 
            this.txtBodega1.BackColor = System.Drawing.Color.White;
            this.txtBodega1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega1.Location = new System.Drawing.Point(6, 6);
            this.txtBodega1.MaxLength = 50;
            this.txtBodega1.Name = "txtBodega1";
            this.txtBodega1.Size = new System.Drawing.Size(61, 20);
            this.txtBodega1.TabIndex = 18;
            this.txtBodega1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega1.Enter += new System.EventHandler(this.txtBodega1_Enter);
            this.txtBodega1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega1_KeyPress);
            this.txtBodega1.Leave += new System.EventHandler(this.txtBodega1_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.cmbBuscaCategoria);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtBusca);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 57);
            this.panel3.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(476, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbBuscaCategoria
            // 
            this.cmbBuscaCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuscaCategoria.FormattingEnabled = true;
            this.cmbBuscaCategoria.Location = new System.Drawing.Point(309, 28);
            this.cmbBuscaCategoria.Name = "cmbBuscaCategoria";
            this.cmbBuscaCategoria.Size = new System.Drawing.Size(161, 21);
            this.cmbBuscaCategoria.TabIndex = 6;
            this.cmbBuscaCategoria.Enter += new System.EventHandler(this.cmbBuscaCategoria_Enter);
            this.cmbBuscaCategoria.Leave += new System.EventHandler(this.cmbBuscaCategoria_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(309, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Filtrar por Categoria";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Buscar por Descripcion";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(3, 28);
            this.txtBusca.MaxLength = 250;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(260, 20);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            this.txtBusca.Leave += new System.EventHandler(this.txtBusca_Leave);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvProductos.Location = new System.Drawing.Point(3, 64);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(567, 192);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.DoubleClick += new System.EventHandler(this.dgvProductos_DoubleClick);
            // 
            // chkIngresaUtilidad
            // 
            this.chkIngresaUtilidad.AutoSize = true;
            this.chkIngresaUtilidad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIngresaUtilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIngresaUtilidad.Location = new System.Drawing.Point(3, 50);
            this.chkIngresaUtilidad.Name = "chkIngresaUtilidad";
            this.chkIngresaUtilidad.Size = new System.Drawing.Size(122, 17);
            this.chkIngresaUtilidad.TabIndex = 14;
            this.chkIngresaUtilidad.Text = "Ingresar % de Utilitad";
            this.chkIngresaUtilidad.UseVisualStyleBackColor = true;
            this.chkIngresaUtilidad.CheckedChanged += new System.EventHandler(this.chkIngresaUtilidad_CheckedChanged);
            this.chkIngresaUtilidad.TextChanged += new System.EventHandler(this.chkIngresaUtilidad_TextChanged);
            // 
            // txtValorVenta3
            // 
            this.txtValorVenta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenta3.Location = new System.Drawing.Point(328, 25);
            this.txtValorVenta3.MaxLength = 50;
            this.txtValorVenta3.Name = "txtValorVenta3";
            this.txtValorVenta3.Size = new System.Drawing.Size(79, 20);
            this.txtValorVenta3.TabIndex = 13;
            this.txtValorVenta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorVenta3.TextChanged += new System.EventHandler(this.txtValorVenta3_TextChanged);
            this.txtValorVenta3.Enter += new System.EventHandler(this.txtValorVenta3_Enter);
            this.txtValorVenta3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenta3_KeyPress);
            this.txtValorVenta3.Leave += new System.EventHandler(this.txtValorVenta3_Leave);
            // 
            // txtValorVenta2
            // 
            this.txtValorVenta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenta2.Location = new System.Drawing.Point(243, 25);
            this.txtValorVenta2.MaxLength = 50;
            this.txtValorVenta2.Name = "txtValorVenta2";
            this.txtValorVenta2.Size = new System.Drawing.Size(79, 20);
            this.txtValorVenta2.TabIndex = 12;
            this.txtValorVenta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorVenta2.TextChanged += new System.EventHandler(this.txtValorVenta2_TextChanged);
            this.txtValorVenta2.Enter += new System.EventHandler(this.txtValorVenta2_Enter);
            this.txtValorVenta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenta2_KeyPress);
            this.txtValorVenta2.Leave += new System.EventHandler(this.txtValorVenta2_Leave);
            // 
            // txtValorVenta1
            // 
            this.txtValorVenta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenta1.Location = new System.Drawing.Point(158, 25);
            this.txtValorVenta1.MaxLength = 50;
            this.txtValorVenta1.Name = "txtValorVenta1";
            this.txtValorVenta1.Size = new System.Drawing.Size(79, 20);
            this.txtValorVenta1.TabIndex = 11;
            this.txtValorVenta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorVenta1.TextChanged += new System.EventHandler(this.txtValorVenta1_TextChanged);
            this.txtValorVenta1.Enter += new System.EventHandler(this.txtValorVenta1_Enter);
            this.txtValorVenta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenta1_KeyPress);
            this.txtValorVenta1.Leave += new System.EventHandler(this.txtValorVenta1_Leave);
            // 
            // txtUtilidad3
            // 
            this.txtUtilidad3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUtilidad3.Location = new System.Drawing.Point(328, 48);
            this.txtUtilidad3.MaxLength = 50;
            this.txtUtilidad3.Name = "txtUtilidad3";
            this.txtUtilidad3.Size = new System.Drawing.Size(79, 20);
            this.txtUtilidad3.TabIndex = 16;
            this.txtUtilidad3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUtilidad3.TextChanged += new System.EventHandler(this.txtUtilidad3_TextChanged);
            this.txtUtilidad3.Enter += new System.EventHandler(this.txtUtilidad3_Enter);
            this.txtUtilidad3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilidad3_KeyPress);
            this.txtUtilidad3.Leave += new System.EventHandler(this.txtUtilidad3_Leave);
            // 
            // txtUtilidad2
            // 
            this.txtUtilidad2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUtilidad2.Location = new System.Drawing.Point(243, 48);
            this.txtUtilidad2.MaxLength = 50;
            this.txtUtilidad2.Name = "txtUtilidad2";
            this.txtUtilidad2.Size = new System.Drawing.Size(79, 20);
            this.txtUtilidad2.TabIndex = 15;
            this.txtUtilidad2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUtilidad2.TextChanged += new System.EventHandler(this.txtUtilidad2_TextChanged);
            this.txtUtilidad2.Enter += new System.EventHandler(this.txtUtilidad2_Enter);
            this.txtUtilidad2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilidad2_KeyPress);
            this.txtUtilidad2.Leave += new System.EventHandler(this.txtUtilidad2_Leave);
            // 
            // txtUtilidad1
            // 
            this.txtUtilidad1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUtilidad1.Location = new System.Drawing.Point(158, 48);
            this.txtUtilidad1.MaxLength = 50;
            this.txtUtilidad1.Name = "txtUtilidad1";
            this.txtUtilidad1.Size = new System.Drawing.Size(79, 20);
            this.txtUtilidad1.TabIndex = 14;
            this.txtUtilidad1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUtilidad1.TextChanged += new System.EventHandler(this.txtUtilidad1_TextChanged);
            this.txtUtilidad1.Enter += new System.EventHandler(this.txtUtilidad1_Enter);
            this.txtUtilidad1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilidad1_KeyPress);
            this.txtUtilidad1.Leave += new System.EventHandler(this.txtUtilidad1_Leave);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorCompra.Location = new System.Drawing.Point(3, 25);
            this.txtValorCompra.MaxLength = 50;
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(103, 20);
            this.txtValorCompra.TabIndex = 10;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCompra.TextChanged += new System.EventHandler(this.txtValorCompra_TextChanged);
            this.txtValorCompra.Enter += new System.EventHandler(this.txtValorCompra_Enter);
            this.txtValorCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCompra_KeyPress);
            this.txtValorCompra.Leave += new System.EventHandler(this.txtValorCompra_Leave);
            // 
            // lblLista3
            // 
            this.lblLista3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.lblLista3.ForeColor = System.Drawing.Color.Black;
            this.lblLista3.Location = new System.Drawing.Point(328, 9);
            this.lblLista3.Name = "lblLista3";
            this.lblLista3.Size = new System.Drawing.Size(79, 15);
            this.lblLista3.TabIndex = 4;
            this.lblLista3.Text = "Valor Venta 3";
            // 
            // lblLista2
            // 
            this.lblLista2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.lblLista2.ForeColor = System.Drawing.Color.Black;
            this.lblLista2.Location = new System.Drawing.Point(243, 9);
            this.lblLista2.Name = "lblLista2";
            this.lblLista2.Size = new System.Drawing.Size(79, 15);
            this.lblLista2.TabIndex = 3;
            this.lblLista2.Text = "Valor Venta 2";
            // 
            // lblLista1
            // 
            this.lblLista1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.lblLista1.ForeColor = System.Drawing.Color.Black;
            this.lblLista1.Location = new System.Drawing.Point(158, 9);
            this.lblLista1.Name = "lblLista1";
            this.lblLista1.Size = new System.Drawing.Size(79, 15);
            this.lblLista1.TabIndex = 2;
            this.lblLista1.Text = "Valor Venta 1";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor Compra NETO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripcion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 609);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Location = new System.Drawing.Point(869, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 587);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtUtilidad5);
            this.panel2.Controls.Add(this.txtUtilidad4);
            this.panel2.Controls.Add(this.txtValorVenta5);
            this.panel2.Controls.Add(this.lblLista4);
            this.panel2.Controls.Add(this.cmbImpuesto);
            this.panel2.Controls.Add(this.txtValorVenta4);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.lblLista5);
            this.panel2.Controls.Add(this.txtUtilidad3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtUtilidad2);
            this.panel2.Controls.Add(this.txtUtilidad1);
            this.panel2.Controls.Add(this.txtValorCompra);
            this.panel2.Controls.Add(this.txtValorVenta1);
            this.panel2.Controls.Add(this.txtValorVenta3);
            this.panel2.Controls.Add(this.lblLista1);
            this.panel2.Controls.Add(this.lblLista2);
            this.panel2.Controls.Add(this.chkIngresaUtilidad);
            this.panel2.Controls.Add(this.txtValorVenta2);
            this.panel2.Controls.Add(this.lblLista3);
            this.panel2.Location = new System.Drawing.Point(6, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 100);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtUtilidad5
            // 
            this.txtUtilidad5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUtilidad5.Location = new System.Drawing.Point(494, 48);
            this.txtUtilidad5.MaxLength = 50;
            this.txtUtilidad5.Name = "txtUtilidad5";
            this.txtUtilidad5.Size = new System.Drawing.Size(79, 20);
            this.txtUtilidad5.TabIndex = 24;
            this.txtUtilidad5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUtilidad5.TextChanged += new System.EventHandler(this.txtUtilidad5_TextChanged);
            this.txtUtilidad5.Enter += new System.EventHandler(this.txtUtilidad5_Enter);
            this.txtUtilidad5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilidad5_KeyPress);
            this.txtUtilidad5.Leave += new System.EventHandler(this.txtUtilidad5_Leave);
            // 
            // txtUtilidad4
            // 
            this.txtUtilidad4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUtilidad4.Location = new System.Drawing.Point(411, 48);
            this.txtUtilidad4.MaxLength = 50;
            this.txtUtilidad4.Name = "txtUtilidad4";
            this.txtUtilidad4.Size = new System.Drawing.Size(79, 20);
            this.txtUtilidad4.TabIndex = 23;
            this.txtUtilidad4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUtilidad4.TextChanged += new System.EventHandler(this.txtUtilidad4_TextChanged);
            this.txtUtilidad4.Enter += new System.EventHandler(this.txtUtilidad4_Enter);
            this.txtUtilidad4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilidad4_KeyPress);
            this.txtUtilidad4.Leave += new System.EventHandler(this.txtUtilidad4_Leave);
            // 
            // txtValorVenta5
            // 
            this.txtValorVenta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenta5.Location = new System.Drawing.Point(494, 25);
            this.txtValorVenta5.MaxLength = 50;
            this.txtValorVenta5.Name = "txtValorVenta5";
            this.txtValorVenta5.Size = new System.Drawing.Size(79, 20);
            this.txtValorVenta5.TabIndex = 22;
            this.txtValorVenta5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorVenta5.TextChanged += new System.EventHandler(this.txtValorVenta5_TextChanged);
            this.txtValorVenta5.Enter += new System.EventHandler(this.txtValorVenta5_Enter);
            this.txtValorVenta5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenta5_KeyPress);
            this.txtValorVenta5.Leave += new System.EventHandler(this.txtValorVenta5_Leave);
            // 
            // lblLista4
            // 
            this.lblLista4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.lblLista4.ForeColor = System.Drawing.Color.Black;
            this.lblLista4.Location = new System.Drawing.Point(411, 9);
            this.lblLista4.Name = "lblLista4";
            this.lblLista4.Size = new System.Drawing.Size(79, 15);
            this.lblLista4.TabIndex = 17;
            this.lblLista4.Text = "Valor Venta 4";
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.BackColor = System.Drawing.Color.White;
            this.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Location = new System.Drawing.Point(158, 73);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(249, 21);
            this.cmbImpuesto.TabIndex = 28;
            // 
            // txtValorVenta4
            // 
            this.txtValorVenta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenta4.Location = new System.Drawing.Point(411, 25);
            this.txtValorVenta4.MaxLength = 50;
            this.txtValorVenta4.Name = "txtValorVenta4";
            this.txtValorVenta4.Size = new System.Drawing.Size(79, 20);
            this.txtValorVenta4.TabIndex = 21;
            this.txtValorVenta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorVenta4.TextChanged += new System.EventHandler(this.txtValorVenta4_TextChanged);
            this.txtValorVenta4.Enter += new System.EventHandler(this.txtValorVenta4_Enter);
            this.txtValorVenta4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenta4_KeyPress);
            this.txtValorVenta4.Leave += new System.EventHandler(this.txtValorVenta4_Leave);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(3, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(153, 20);
            this.label24.TabIndex = 29;
            this.label24.Text = "Impuesto Especial";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLista5
            // 
            this.lblLista5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.lblLista5.ForeColor = System.Drawing.Color.Black;
            this.lblLista5.Location = new System.Drawing.Point(494, 9);
            this.lblLista5.Name = "lblLista5";
            this.lblLista5.Size = new System.Drawing.Size(79, 15);
            this.lblLista5.TabIndex = 18;
            this.lblLista5.Text = "Valor Venta 5";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.chkKit);
            this.panel4.Controls.Add(this.cmbSubCategoria);
            this.panel4.Controls.Add(this.chkPesable);
            this.panel4.Controls.Add(this.chkExento);
            this.panel4.Controls.Add(this.txtMarca);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnIngresarCategoria);
            this.panel4.Controls.Add(this.txtCodigo);
            this.panel4.Controls.Add(this.cmbUnidadMedida);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.txtCodigoAlternativo);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtResumenDescripcion);
            this.panel4.Controls.Add(this.txtDescripcion);
            this.panel4.Controls.Add(this.lblResumenDescripcion);
            this.panel4.Controls.Add(this.cmbCategoria);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 192);
            this.panel4.TabIndex = 31;
            // 
            // chkKit
            // 
            this.chkKit.AutoSize = true;
            this.chkKit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKit.Location = new System.Drawing.Point(534, 27);
            this.chkKit.Name = "chkKit";
            this.chkKit.Size = new System.Drawing.Size(38, 17);
            this.chkKit.TabIndex = 9;
            this.chkKit.Text = "Kit";
            this.chkKit.UseVisualStyleBackColor = true;
            this.chkKit.CheckedChanged += new System.EventHandler(this.chkKit_CheckedChanged);
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Location = new System.Drawing.Point(107, 132);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(246, 21);
            this.cmbSubCategoria.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "SubCategoria";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(356, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ingresar Nueva";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngresarCategoria
            // 
            this.btnIngresarCategoria.BackColor = System.Drawing.Color.White;
            this.btnIngresarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCategoria.Location = new System.Drawing.Point(356, 106);
            this.btnIngresarCategoria.Name = "btnIngresarCategoria";
            this.btnIngresarCategoria.Size = new System.Drawing.Size(110, 23);
            this.btnIngresarCategoria.TabIndex = 12;
            this.btnIngresarCategoria.Text = "Ingresar Nueva";
            this.btnIngresarCategoria.UseVisualStyleBackColor = false;
            this.btnIngresarCategoria.Click += new System.EventHandler(this.btnIngresarCategoria_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(107, 7);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave_1);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(259, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 13);
            this.label27.TabIndex = 16;
            this.label27.Text = "Codigo Alternativo";
            // 
            // txtCodigoAlternativo
            // 
            this.txtCodigoAlternativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoAlternativo.Location = new System.Drawing.Point(356, 7);
            this.txtCodigoAlternativo.MaxLength = 50;
            this.txtCodigoAlternativo.Name = "txtCodigoAlternativo";
            this.txtCodigoAlternativo.Size = new System.Drawing.Size(110, 20);
            this.txtCodigoAlternativo.TabIndex = 2;
            this.txtCodigoAlternativo.Enter += new System.EventHandler(this.txtCodigoAlternativo_Enter);
            this.txtCodigoAlternativo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoAlternativo_KeyPress);
            this.txtCodigoAlternativo.Leave += new System.EventHandler(this.txtCodigoAlternativo_Leave);
            // 
            // txtResumenDescripcion
            // 
            this.txtResumenDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResumenDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResumenDescripcion.Location = new System.Drawing.Point(107, 57);
            this.txtResumenDescripcion.MaxLength = 50;
            this.txtResumenDescripcion.Name = "txtResumenDescripcion";
            this.txtResumenDescripcion.Size = new System.Drawing.Size(359, 20);
            this.txtResumenDescripcion.TabIndex = 17;
            // 
            // lblResumenDescripcion
            // 
            this.lblResumenDescripcion.AutoSize = true;
            this.lblResumenDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblResumenDescripcion.Location = new System.Drawing.Point(8, 61);
            this.lblResumenDescripcion.Name = "lblResumenDescripcion";
            this.lblResumenDescripcion.Size = new System.Drawing.Size(98, 13);
            this.lblResumenDescripcion.TabIndex = 18;
            this.lblResumenDescripcion.Text = "Resumen de Desc.";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(593, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(270, 584);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.btnPesables);
            this.tabPage3.Controls.Add(this.txtBodega11);
            this.tabPage3.Controls.Add(this.txtBodega12);
            this.tabPage3.Controls.Add(this.lblBodega11);
            this.tabPage3.Controls.Add(this.txtBodega13);
            this.tabPage3.Controls.Add(this.lblBodega12);
            this.tabPage3.Controls.Add(this.txtBodega14);
            this.tabPage3.Controls.Add(this.txtStockMinimo);
            this.tabPage3.Controls.Add(this.lblBodega13);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.txtBodega15);
            this.tabPage3.Controls.Add(this.lblBodega14);
            this.tabPage3.Controls.Add(this.txtBodega16);
            this.tabPage3.Controls.Add(this.lblBodega15);
            this.tabPage3.Controls.Add(this.txtBodega17);
            this.tabPage3.Controls.Add(this.lblBodega16);
            this.tabPage3.Controls.Add(this.txtBodega18);
            this.tabPage3.Controls.Add(this.lblBodega17);
            this.tabPage3.Controls.Add(this.txtBodega20);
            this.tabPage3.Controls.Add(this.lblBodega18);
            this.tabPage3.Controls.Add(this.txtBodega19);
            this.tabPage3.Controls.Add(this.lblBodega19);
            this.tabPage3.Controls.Add(this.lblBodega20);
            this.tabPage3.Controls.Add(this.txtBodega1);
            this.tabPage3.Controls.Add(this.txtBodega2);
            this.tabPage3.Controls.Add(this.lblBodega1);
            this.tabPage3.Controls.Add(this.txtBodega3);
            this.tabPage3.Controls.Add(this.lblBodega2);
            this.tabPage3.Controls.Add(this.txtBodega4);
            this.tabPage3.Controls.Add(this.lblBodega3);
            this.tabPage3.Controls.Add(this.txtBodega5);
            this.tabPage3.Controls.Add(this.lblBodega4);
            this.tabPage3.Controls.Add(this.txtBodega6);
            this.tabPage3.Controls.Add(this.lblBodega5);
            this.tabPage3.Controls.Add(this.txtBodega7);
            this.tabPage3.Controls.Add(this.lblBodega6);
            this.tabPage3.Controls.Add(this.txtBodega8);
            this.tabPage3.Controls.Add(this.lblBodega7);
            this.tabPage3.Controls.Add(this.txtBodega10);
            this.tabPage3.Controls.Add(this.lblBodega8);
            this.tabPage3.Controls.Add(this.txtBodega9);
            this.tabPage3.Controls.Add(this.lblBodega9);
            this.tabPage3.Controls.Add(this.lblBodega10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(262, 558);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Bodegas";
            // 
            // btnPesables
            // 
            this.btnPesables.BackColor = System.Drawing.Color.White;
            this.btnPesables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesables.Location = new System.Drawing.Point(6, 529);
            this.btnPesables.Name = "btnPesables";
            this.btnPesables.Size = new System.Drawing.Size(247, 25);
            this.btnPesables.TabIndex = 31;
            this.btnPesables.Text = "Generar Archivo de Productos Pesables";
            this.btnPesables.UseVisualStyleBackColor = false;
            this.btnPesables.Click += new System.EventHandler(this.btnPesables_Click);
            // 
            // txtBodega11
            // 
            this.txtBodega11.BackColor = System.Drawing.Color.White;
            this.txtBodega11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega11.Location = new System.Drawing.Point(6, 226);
            this.txtBodega11.MaxLength = 50;
            this.txtBodega11.Name = "txtBodega11";
            this.txtBodega11.Size = new System.Drawing.Size(61, 20);
            this.txtBodega11.TabIndex = 38;
            this.txtBodega11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega11.TextChanged += new System.EventHandler(this.txtBodega11_TextChanged);
            this.txtBodega11.Enter += new System.EventHandler(this.txtBodega11_Enter);
            this.txtBodega11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega11_KeyPress);
            this.txtBodega11.Leave += new System.EventHandler(this.txtBodega11_Leave);
            // 
            // txtBodega12
            // 
            this.txtBodega12.BackColor = System.Drawing.Color.White;
            this.txtBodega12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega12.Location = new System.Drawing.Point(6, 248);
            this.txtBodega12.MaxLength = 50;
            this.txtBodega12.Name = "txtBodega12";
            this.txtBodega12.Size = new System.Drawing.Size(61, 20);
            this.txtBodega12.TabIndex = 39;
            this.txtBodega12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega12.Enter += new System.EventHandler(this.txtBodega12_Enter);
            this.txtBodega12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega12_KeyPress);
            this.txtBodega12.Leave += new System.EventHandler(this.txtBodega12_Leave);
            // 
            // lblBodega11
            // 
            this.lblBodega11.AutoSize = true;
            this.lblBodega11.ForeColor = System.Drawing.Color.Black;
            this.lblBodega11.Location = new System.Drawing.Point(73, 230);
            this.lblBodega11.Name = "lblBodega11";
            this.lblBodega11.Size = new System.Drawing.Size(59, 13);
            this.lblBodega11.TabIndex = 28;
            this.lblBodega11.Text = "Bodega 11";
            // 
            // txtBodega13
            // 
            this.txtBodega13.BackColor = System.Drawing.Color.White;
            this.txtBodega13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega13.Location = new System.Drawing.Point(6, 270);
            this.txtBodega13.MaxLength = 50;
            this.txtBodega13.Name = "txtBodega13";
            this.txtBodega13.Size = new System.Drawing.Size(61, 20);
            this.txtBodega13.TabIndex = 40;
            this.txtBodega13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega13.Enter += new System.EventHandler(this.txtBodega13_Enter);
            this.txtBodega13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega13_KeyPress);
            this.txtBodega13.Leave += new System.EventHandler(this.txtBodega13_Leave);
            // 
            // lblBodega12
            // 
            this.lblBodega12.AutoSize = true;
            this.lblBodega12.ForeColor = System.Drawing.Color.Black;
            this.lblBodega12.Location = new System.Drawing.Point(73, 252);
            this.lblBodega12.Name = "lblBodega12";
            this.lblBodega12.Size = new System.Drawing.Size(59, 13);
            this.lblBodega12.TabIndex = 29;
            this.lblBodega12.Text = "Bodega 12";
            // 
            // txtBodega14
            // 
            this.txtBodega14.BackColor = System.Drawing.Color.White;
            this.txtBodega14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega14.Location = new System.Drawing.Point(6, 292);
            this.txtBodega14.MaxLength = 50;
            this.txtBodega14.Name = "txtBodega14";
            this.txtBodega14.Size = new System.Drawing.Size(61, 20);
            this.txtBodega14.TabIndex = 41;
            this.txtBodega14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega14.Enter += new System.EventHandler(this.txtBodega14_Enter);
            this.txtBodega14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega14_KeyPress);
            this.txtBodega14.Leave += new System.EventHandler(this.txtBodega14_Leave);
            // 
            // lblBodega13
            // 
            this.lblBodega13.AutoSize = true;
            this.lblBodega13.ForeColor = System.Drawing.Color.Black;
            this.lblBodega13.Location = new System.Drawing.Point(73, 274);
            this.lblBodega13.Name = "lblBodega13";
            this.lblBodega13.Size = new System.Drawing.Size(59, 13);
            this.lblBodega13.TabIndex = 30;
            this.lblBodega13.Text = "Bodega 13";
            // 
            // txtBodega15
            // 
            this.txtBodega15.BackColor = System.Drawing.Color.White;
            this.txtBodega15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega15.Location = new System.Drawing.Point(6, 314);
            this.txtBodega15.MaxLength = 50;
            this.txtBodega15.Name = "txtBodega15";
            this.txtBodega15.Size = new System.Drawing.Size(61, 20);
            this.txtBodega15.TabIndex = 42;
            this.txtBodega15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega15.Enter += new System.EventHandler(this.txtBodega15_Enter);
            this.txtBodega15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega15_KeyPress);
            this.txtBodega15.Leave += new System.EventHandler(this.txtBodega15_Leave);
            // 
            // lblBodega14
            // 
            this.lblBodega14.AutoSize = true;
            this.lblBodega14.ForeColor = System.Drawing.Color.Black;
            this.lblBodega14.Location = new System.Drawing.Point(73, 296);
            this.lblBodega14.Name = "lblBodega14";
            this.lblBodega14.Size = new System.Drawing.Size(59, 13);
            this.lblBodega14.TabIndex = 31;
            this.lblBodega14.Text = "Bodega 14";
            // 
            // txtBodega16
            // 
            this.txtBodega16.BackColor = System.Drawing.Color.White;
            this.txtBodega16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega16.Location = new System.Drawing.Point(6, 336);
            this.txtBodega16.MaxLength = 50;
            this.txtBodega16.Name = "txtBodega16";
            this.txtBodega16.Size = new System.Drawing.Size(61, 20);
            this.txtBodega16.TabIndex = 43;
            this.txtBodega16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega16.Enter += new System.EventHandler(this.txtBodega16_Enter);
            this.txtBodega16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega16_KeyPress);
            this.txtBodega16.Leave += new System.EventHandler(this.txtBodega16_Leave);
            // 
            // lblBodega15
            // 
            this.lblBodega15.AutoSize = true;
            this.lblBodega15.ForeColor = System.Drawing.Color.Black;
            this.lblBodega15.Location = new System.Drawing.Point(73, 318);
            this.lblBodega15.Name = "lblBodega15";
            this.lblBodega15.Size = new System.Drawing.Size(59, 13);
            this.lblBodega15.TabIndex = 32;
            this.lblBodega15.Text = "Bodega 15";
            // 
            // txtBodega17
            // 
            this.txtBodega17.BackColor = System.Drawing.Color.White;
            this.txtBodega17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega17.Location = new System.Drawing.Point(6, 358);
            this.txtBodega17.MaxLength = 50;
            this.txtBodega17.Name = "txtBodega17";
            this.txtBodega17.Size = new System.Drawing.Size(61, 20);
            this.txtBodega17.TabIndex = 44;
            this.txtBodega17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega17.TextChanged += new System.EventHandler(this.txtBodega17_TextChanged);
            this.txtBodega17.Enter += new System.EventHandler(this.txtBodega17_Enter);
            this.txtBodega17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega17_KeyPress);
            this.txtBodega17.Leave += new System.EventHandler(this.txtBodega17_Leave);
            // 
            // lblBodega16
            // 
            this.lblBodega16.AutoSize = true;
            this.lblBodega16.ForeColor = System.Drawing.Color.Black;
            this.lblBodega16.Location = new System.Drawing.Point(73, 340);
            this.lblBodega16.Name = "lblBodega16";
            this.lblBodega16.Size = new System.Drawing.Size(59, 13);
            this.lblBodega16.TabIndex = 33;
            this.lblBodega16.Text = "Bodega 16";
            // 
            // txtBodega18
            // 
            this.txtBodega18.BackColor = System.Drawing.Color.White;
            this.txtBodega18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega18.Location = new System.Drawing.Point(6, 380);
            this.txtBodega18.MaxLength = 50;
            this.txtBodega18.Name = "txtBodega18";
            this.txtBodega18.Size = new System.Drawing.Size(61, 20);
            this.txtBodega18.TabIndex = 45;
            this.txtBodega18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega18.Enter += new System.EventHandler(this.txtBodega18_Enter);
            this.txtBodega18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega18_KeyPress);
            this.txtBodega18.Leave += new System.EventHandler(this.txtBodega18_Leave);
            // 
            // lblBodega17
            // 
            this.lblBodega17.AutoSize = true;
            this.lblBodega17.ForeColor = System.Drawing.Color.Black;
            this.lblBodega17.Location = new System.Drawing.Point(73, 362);
            this.lblBodega17.Name = "lblBodega17";
            this.lblBodega17.Size = new System.Drawing.Size(59, 13);
            this.lblBodega17.TabIndex = 34;
            this.lblBodega17.Text = "Bodega 17";
            // 
            // txtBodega20
            // 
            this.txtBodega20.BackColor = System.Drawing.Color.White;
            this.txtBodega20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega20.Location = new System.Drawing.Point(6, 424);
            this.txtBodega20.MaxLength = 50;
            this.txtBodega20.Name = "txtBodega20";
            this.txtBodega20.Size = new System.Drawing.Size(61, 20);
            this.txtBodega20.TabIndex = 47;
            this.txtBodega20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega20.Enter += new System.EventHandler(this.txtBodega20_Enter);
            this.txtBodega20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega20_KeyPress);
            this.txtBodega20.Leave += new System.EventHandler(this.txtBodega20_Leave);
            // 
            // lblBodega18
            // 
            this.lblBodega18.AutoSize = true;
            this.lblBodega18.ForeColor = System.Drawing.Color.Black;
            this.lblBodega18.Location = new System.Drawing.Point(73, 384);
            this.lblBodega18.Name = "lblBodega18";
            this.lblBodega18.Size = new System.Drawing.Size(59, 13);
            this.lblBodega18.TabIndex = 35;
            this.lblBodega18.Text = "Bodega 18";
            // 
            // txtBodega19
            // 
            this.txtBodega19.BackColor = System.Drawing.Color.White;
            this.txtBodega19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBodega19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodega19.Location = new System.Drawing.Point(6, 402);
            this.txtBodega19.MaxLength = 50;
            this.txtBodega19.Name = "txtBodega19";
            this.txtBodega19.Size = new System.Drawing.Size(61, 20);
            this.txtBodega19.TabIndex = 46;
            this.txtBodega19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBodega19.Enter += new System.EventHandler(this.txtBodega19_Enter);
            this.txtBodega19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBodega19_KeyPress);
            this.txtBodega19.Leave += new System.EventHandler(this.txtBodega19_Leave);
            // 
            // lblBodega19
            // 
            this.lblBodega19.AutoSize = true;
            this.lblBodega19.ForeColor = System.Drawing.Color.Black;
            this.lblBodega19.Location = new System.Drawing.Point(73, 406);
            this.lblBodega19.Name = "lblBodega19";
            this.lblBodega19.Size = new System.Drawing.Size(59, 13);
            this.lblBodega19.TabIndex = 36;
            this.lblBodega19.Text = "Bodega 19";
            // 
            // lblBodega20
            // 
            this.lblBodega20.AutoSize = true;
            this.lblBodega20.ForeColor = System.Drawing.Color.Black;
            this.lblBodega20.Location = new System.Drawing.Point(73, 428);
            this.lblBodega20.Name = "lblBodega20";
            this.lblBodega20.Size = new System.Drawing.Size(59, 13);
            this.lblBodega20.TabIndex = 37;
            this.lblBodega20.Text = "Bodega 20";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.dgvLote);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(262, 558);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Lotes";
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.AllowUserToResizeColumns = false;
            this.dgvLote.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            this.dgvLote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLote.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lote,
            this.Cantidad,
            this.Bodega,
            this.BodegaNombre});
            this.dgvLote.Location = new System.Drawing.Point(6, 6);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.ReadOnly = true;
            this.dgvLote.RowHeadersVisible = false;
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.Size = new System.Drawing.Size(250, 229);
            this.dgvLote.TabIndex = 0;
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "Lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Bodega
            // 
            this.Bodega.DataPropertyName = "Bodega";
            this.Bodega.HeaderText = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.ReadOnly = true;
            this.Bodega.Width = 60;
            // 
            // BodegaNombre
            // 
            this.BodegaNombre.DataPropertyName = "BodegaNombre";
            this.BodegaNombre.HeaderText = "BodegaNombre";
            this.BodegaNombre.Name = "BodegaNombre";
            this.BodegaNombre.ReadOnly = true;
            this.BodegaNombre.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 314);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 286);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dgvProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscador";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage2.Controls.Add(this.btnMostrarImagenes);
            this.tabPage2.Controls.Add(this.btnQuitaIMG3);
            this.tabPage2.Controls.Add(this.btnAgregaIMG3);
            this.tabPage2.Controls.Add(this.btnQuitaIMG2);
            this.tabPage2.Controls.Add(this.btnAgregaIMG2);
            this.tabPage2.Controls.Add(this.btnQuitaIMG1);
            this.tabPage2.Controls.Add(this.btnAgregaIMG1);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Imagenes";
            // 
            // btnMostrarImagenes
            // 
            this.btnMostrarImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarImagenes.Location = new System.Drawing.Point(10, 13);
            this.btnMostrarImagenes.Name = "btnMostrarImagenes";
            this.btnMostrarImagenes.Size = new System.Drawing.Size(75, 150);
            this.btnMostrarImagenes.TabIndex = 8;
            this.btnMostrarImagenes.Text = "Mostrar Imagenes";
            this.btnMostrarImagenes.UseVisualStyleBackColor = true;
            this.btnMostrarImagenes.Click += new System.EventHandler(this.btnMostrarImagenes_Click);
            // 
            // btnQuitaIMG3
            // 
            this.btnQuitaIMG3.Location = new System.Drawing.Point(497, 173);
            this.btnQuitaIMG3.Name = "btnQuitaIMG3";
            this.btnQuitaIMG3.Size = new System.Drawing.Size(61, 23);
            this.btnQuitaIMG3.TabIndex = 8;
            this.btnQuitaIMG3.Text = "Quitar";
            this.btnQuitaIMG3.UseVisualStyleBackColor = true;
            this.btnQuitaIMG3.Click += new System.EventHandler(this.btnQuitaIMG3_Click);
            // 
            // btnAgregaIMG3
            // 
            this.btnAgregaIMG3.Location = new System.Drawing.Point(434, 173);
            this.btnAgregaIMG3.Name = "btnAgregaIMG3";
            this.btnAgregaIMG3.Size = new System.Drawing.Size(61, 23);
            this.btnAgregaIMG3.TabIndex = 7;
            this.btnAgregaIMG3.Text = "Agregar";
            this.btnAgregaIMG3.UseVisualStyleBackColor = true;
            this.btnAgregaIMG3.Click += new System.EventHandler(this.btnAgregaIMG3_Click);
            // 
            // btnQuitaIMG2
            // 
            this.btnQuitaIMG2.Location = new System.Drawing.Point(338, 173);
            this.btnQuitaIMG2.Name = "btnQuitaIMG2";
            this.btnQuitaIMG2.Size = new System.Drawing.Size(61, 23);
            this.btnQuitaIMG2.TabIndex = 6;
            this.btnQuitaIMG2.Text = "Quitar";
            this.btnQuitaIMG2.UseVisualStyleBackColor = true;
            this.btnQuitaIMG2.Click += new System.EventHandler(this.btnQuitaIMG2_Click);
            // 
            // btnAgregaIMG2
            // 
            this.btnAgregaIMG2.Location = new System.Drawing.Point(274, 173);
            this.btnAgregaIMG2.Name = "btnAgregaIMG2";
            this.btnAgregaIMG2.Size = new System.Drawing.Size(61, 23);
            this.btnAgregaIMG2.TabIndex = 5;
            this.btnAgregaIMG2.Text = "Agregar";
            this.btnAgregaIMG2.UseVisualStyleBackColor = true;
            this.btnAgregaIMG2.Click += new System.EventHandler(this.btnAgregaIMG2_Click);
            // 
            // btnQuitaIMG1
            // 
            this.btnQuitaIMG1.Location = new System.Drawing.Point(180, 173);
            this.btnQuitaIMG1.Name = "btnQuitaIMG1";
            this.btnQuitaIMG1.Size = new System.Drawing.Size(61, 23);
            this.btnQuitaIMG1.TabIndex = 4;
            this.btnQuitaIMG1.Text = "Quitar";
            this.btnQuitaIMG1.UseVisualStyleBackColor = true;
            this.btnQuitaIMG1.Click += new System.EventHandler(this.btnQuitaIMG1_Click);
            // 
            // btnAgregaIMG1
            // 
            this.btnAgregaIMG1.Location = new System.Drawing.Point(116, 173);
            this.btnAgregaIMG1.Name = "btnAgregaIMG1";
            this.btnAgregaIMG1.Size = new System.Drawing.Size(61, 23);
            this.btnAgregaIMG1.TabIndex = 3;
            this.btnAgregaIMG1.Text = "Agregar";
            this.btnAgregaIMG1.UseVisualStyleBackColor = true;
            this.btnAgregaIMG1.Click += new System.EventHandler(this.btnAgregaIMG1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(408, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(249, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(91, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmProductos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1192, 672);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmProductos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductos_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductos_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("PRODUCTO"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._modificaStock = Convert.ToBoolean(usuarioVo.ModificaStock);
        }
      }
    }

    private void cargaBodegas()
    {
      foreach (BodegaVO bodegaVo in new BodegaCajaListaOtros().listaBodegasList())
      {
        switch (bodegaVo.IdBodega)
        {
          case 1:
            this.lblBodega1.Text = bodegaVo.nombreBodega;
            break;
          case 2:
            this.lblBodega2.Text = bodegaVo.nombreBodega;
            break;
          case 3:
            this.lblBodega3.Text = bodegaVo.nombreBodega;
            break;
          case 4:
            this.lblBodega4.Text = bodegaVo.nombreBodega;
            break;
          case 5:
            this.lblBodega5.Text = bodegaVo.nombreBodega;
            break;
          case 6:
            this.lblBodega6.Text = bodegaVo.nombreBodega;
            break;
          case 7:
            this.lblBodega7.Text = bodegaVo.nombreBodega;
            break;
          case 8:
            this.lblBodega8.Text = bodegaVo.nombreBodega;
            break;
          case 9:
            this.lblBodega9.Text = bodegaVo.nombreBodega;
            break;
          case 10:
            this.lblBodega10.Text = bodegaVo.nombreBodega;
            break;
          case 11:
            this.lblBodega11.Text = bodegaVo.nombreBodega;
            break;
          case 12:
            this.lblBodega12.Text = bodegaVo.nombreBodega;
            break;
          case 13:
            this.lblBodega13.Text = bodegaVo.nombreBodega;
            break;
          case 14:
            this.lblBodega14.Text = bodegaVo.nombreBodega;
            break;
          case 15:
            this.lblBodega15.Text = bodegaVo.nombreBodega;
            break;
          case 16:
            this.lblBodega16.Text = bodegaVo.nombreBodega;
            break;
          case 17:
            this.lblBodega17.Text = bodegaVo.nombreBodega;
            break;
          case 18:
            this.lblBodega18.Text = bodegaVo.nombreBodega;
            break;
          case 19:
            this.lblBodega19.Text = bodegaVo.nombreBodega;
            break;
          case 20:
            this.lblBodega20.Text = bodegaVo.nombreBodega;
            break;
        }
      }
    }

    private void cargaListas()
    {
      foreach (ListaPrecioVO listaPrecioVo in new BodegaCajaListaOtros().listaListaPrecioList())
      {
        switch (listaPrecioVo.IdListaPrecio)
        {
          case 1:
            this.lblLista1.Text = listaPrecioVo.nombreListaPrecio;
            break;
          case 2:
            this.lblLista2.Text = listaPrecioVo.nombreListaPrecio;
            break;
          case 3:
            this.lblLista3.Text = listaPrecioVo.nombreListaPrecio;
            break;
          case 4:
            this.lblLista4.Text = listaPrecioVo.nombreListaPrecio;
            break;
          case 5:
            this.lblLista5.Text = listaPrecioVo.nombreListaPrecio;
            break;
        }
      }
    }

    private void obtieneIva()
    {
      Calculos calculos = new Calculos();
      this._conIva = calculos._valoresConIva;
      this._iva = calculos._iva;
    }

    private void cargaListaArticulos()
    {
      this.dgvProductos.DataSource = (object) new Producto().listaProductos().Tables[0];
    }

    private void cargaImpuestos()
    {
      this.cmbImpuesto.DataSource = (object) new Impuestos().listaImpuestos();
      this.cmbImpuesto.ValueMember = "IdImpuesto";
      this.cmbImpuesto.DisplayMember = "NombreImpuesto";
      this.cmbImpuesto.SelectedValue = (object) 0;
    }

    private void iniciaProducto()
    {
      this.dgvProductos.DataSource = (object) null;
      this.dgvProductos.Columns.Clear();
      this.creaColumnasDetalle();
      this.txtCodigo.Clear();
      this.txtCodigoAlternativo.Clear();
      this.txtDescripcion.Clear();
      this.txtResumenDescripcion.Clear();
      this.txtMarca.Clear();
      this.cmbCategoria.SelectedValue = (object) 0;
      this.cmbUnidadMedida.SelectedValue = (object) 0;
      this.cmbImpuesto.SelectedValue = (object) 0;
      this.cmbSubCategoria.DataSource = (object) null;
      this.cmbBuscaCategoria.Text = "(Seleccionar)";
      this.chkExento.Checked = false;
      this.chkKit.Checked = false;
      this.chkKit.Enabled = false;
      this.cmbBuscaCategoria.DataSource = (object) null;
      this.chkPesable.Checked = false;
      this.chkIngresaUtilidad.Checked = false;
      this.txtValorCompra.Clear();
      this.txtValorVenta1.Clear();
      this.txtValorVenta2.Clear();
      this.txtValorVenta3.Clear();
      this.txtValorVenta4.Clear();
      this.txtValorVenta5.Clear();
      this.txtUtilidad1.Clear();
      this.txtUtilidad2.Clear();
      this.txtUtilidad3.Clear();
      this.txtUtilidad4.Clear();
      this.txtUtilidad5.Clear();
      this.txtUtilidad1.Enabled = false;
      this.txtUtilidad2.Enabled = false;
      this.txtUtilidad3.Enabled = false;
      this.txtUtilidad4.Enabled = false;
      this.txtUtilidad5.Enabled = false;
      this.txtStockMinimo.Clear();
      this.txtBodega1.Clear();
      this.txtBodega2.Clear();
      this.txtBodega3.Clear();
      this.txtBodega4.Clear();
      this.txtBodega5.Clear();
      this.txtBodega6.Clear();
      this.txtBodega7.Clear();
      this.txtBodega8.Clear();
      this.txtBodega9.Clear();
      this.txtBodega10.Clear();
      this.txtBodega11.Clear();
      this.txtBodega12.Clear();
      this.txtBodega13.Clear();
      this.txtBodega14.Clear();
      this.txtBodega15.Clear();
      this.txtBodega16.Clear();
      this.txtBodega17.Clear();
      this.txtBodega18.Clear();
      this.txtBodega19.Clear();
      this.txtBodega20.Clear();
      this.txtBusca.Clear();
      this.pictureBox1.Image = (Image) null;
      this.rutaIMG1 = "";
      this.pictureBox2.Image = (Image) null;
      this.rutaIMG2 = "";
      this.pictureBox3.Image = (Image) null;
      this.rutaIMG3 = "";
      this.dgvProductos.DataSource = (object) null;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnGuardar.Enabled = false;
      this.listaStock.Clear();
      this.dgvLote.DataSource = (object) null;
      this.txtCodigo.Focus();
    }

    private void creaColumnasDetalle()
    {
      this.dgvProductos.AutoGenerateColumns = false;
      this.dgvProductos.Columns.Add("Codigo", "Codigo");
      this.dgvProductos.Columns[0].DataPropertyName = "Codigo";
      this.dgvProductos.Columns[0].Width = 60;
      this.dgvProductos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvProductos.Columns.Add("Descripcion", "Descripcion");
      this.dgvProductos.Columns[1].DataPropertyName = "Descripcion";
      this.dgvProductos.Columns[1].Width = 210;
      this.dgvProductos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvProductos.Columns.Add("ValorCompra", "ValorCompra");
      this.dgvProductos.Columns[2].DataPropertyName = "ValorCompra";
      this.dgvProductos.Columns[2].Width = 100;
      this.dgvProductos.Columns[2].DefaultCellStyle.Format = "N2";
      this.dgvProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvProductos.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvProductos.Columns.Add("ValorVenta", "ValorVenta");
      this.dgvProductos.Columns[3].DataPropertyName = "ValorVenta1";
      this.dgvProductos.Columns[3].Width = 100;
      this.dgvProductos.Columns[3].DefaultCellStyle.Format = "N2";
      this.dgvProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvProductos.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvProductos.Columns.Add("Bodega1", "Bodega1");
      this.dgvProductos.Columns[4].DataPropertyName = "Bodega1";
      this.dgvProductos.Columns[4].Width = 70;
      this.dgvProductos.Columns[4].DefaultCellStyle.Format = "N2";
      this.dgvProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvProductos.Columns[4].Resizable = DataGridViewTriState.False;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modProducto = 0;
      this.Close();
      this.Dispose();
    }

    private void cargaCategorias()
    {
      this.cmbCategoria.DataSource = (object) new Categoria().listaCategorias();
      this.cmbCategoria.DisplayMember = "Descripcion";
      this.cmbCategoria.ValueMember = "IdCategoria";
      this.cmbCategoria.SelectedValue = (object) 0;
    }

    private void cargaCategorias2()
    {
      this.cmbCategoria.DataSource = (object) new Categoria().listaCategorias();
      this.cmbCategoria.DisplayMember = "Descripcion";
      this.cmbCategoria.ValueMember = "IdCategoria";
    }

    private void cargaUnidadMedida()
    {
      this.cmbUnidadMedida.DataSource = (object) new UnidadMedida().listaUnidadMedidaProductos();
      this.cmbUnidadMedida.DisplayMember = "NombreUnidad";
      this.cmbUnidadMedida.ValueMember = "IdUnidMed";
      this.cmbUnidadMedida.SelectedValue = (object) 0;
    }

    private void cargaCategoriasBuscar()
    {
      this.cmbBuscaCategoria.DataSource = (object) null;
      Categoria categoria = new Categoria();
      this.cmbBuscaCategoria.SelectedValue = this.cmbBuscaCategoria.SelectedValue;
      this.cmbBuscaCategoria.DisplayMember = "DescCategoria";
      this.cmbBuscaCategoria.ValueMember = "Id";
      this.cmbBuscaCategoria.DataSource = (object) categoria.cosultaCategoria().Tables[0];
    }

    private void cmbCategoria_Enter(object sender, EventArgs e)
    {
      this.cmbCategoria.BackColor = Color.PeachPuff;
    }

    private void frmProductos_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.F1)
        return;
      string str1 = "Pulsada F1   ";
      DateTime dateTime = DateTime.Now;
      dateTime = dateTime.Date;
      string str2 = dateTime.ToShortDateString();
      int num = (int) MessageBox.Show(str1 + str2);
    }

    private void llenaCampos()
    {
      if (this.txtValorVenta2.Text.Length == 0)
        this.txtValorVenta2.Text = "0";
      if (this.txtValorVenta3.Text.Length == 0)
        this.txtValorVenta3.Text = "0";
      if (this.txtValorVenta4.Text.Length == 0)
        this.txtValorVenta4.Text = "0";
      if (this.txtValorVenta5.Text.Length == 0)
        this.txtValorVenta5.Text = "0";
      if (this.txtUtilidad1.Text.Length == 0)
        this.txtUtilidad1.Text = "0";
      if (this.txtUtilidad2.Text.Length == 0)
        this.txtUtilidad2.Text = "0";
      if (this.txtUtilidad3.Text.Length == 0)
        this.txtUtilidad3.Text = "0";
      if (this.txtUtilidad4.Text.Length == 0)
        this.txtUtilidad4.Text = "0";
      if (this.txtUtilidad5.Text.Length == 0)
        this.txtUtilidad5.Text = "0";
      if (this.txtBodega1.Text.Length == 0)
        this.txtBodega1.Text = "0";
      if (this.txtBodega2.Text.Length == 0)
        this.txtBodega2.Text = "0";
      if (this.txtBodega3.Text.Length == 0)
        this.txtBodega3.Text = "0";
      if (this.txtBodega4.Text.Length == 0)
        this.txtBodega4.Text = "0";
      if (this.txtBodega5.Text.Length == 0)
        this.txtBodega5.Text = "0";
      if (this.txtBodega6.Text.Length == 0)
        this.txtBodega6.Text = "0";
      if (this.txtBodega7.Text.Length == 0)
        this.txtBodega7.Text = "0";
      if (this.txtBodega8.Text.Length == 0)
        this.txtBodega8.Text = "0";
      if (this.txtBodega9.Text.Length == 0)
        this.txtBodega9.Text = "0";
      if (this.txtBodega10.Text.Length == 0)
        this.txtBodega10.Text = "0";
      if (this.txtBodega11.Text.Length == 0)
        this.txtBodega11.Text = "0";
      if (this.txtBodega12.Text.Length == 0)
        this.txtBodega12.Text = "0";
      if (this.txtBodega13.Text.Length == 0)
        this.txtBodega13.Text = "0";
      if (this.txtBodega14.Text.Length == 0)
        this.txtBodega14.Text = "0";
      if (this.txtBodega15.Text.Length == 0)
        this.txtBodega15.Text = "0";
      if (this.txtBodega16.Text.Length == 0)
        this.txtBodega16.Text = "0";
      if (this.txtBodega17.Text.Length == 0)
        this.txtBodega17.Text = "0";
      if (this.txtBodega18.Text.Length == 0)
        this.txtBodega18.Text = "0";
      if (this.txtBodega19.Text.Length == 0)
        this.txtBodega19.Text = "0";
      if (this.txtBodega20.Text.Length != 0)
        return;
      this.txtBodega20.Text = "0";
    }

    private bool validaCampos()
    {
      if (this.txtCodigo.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar el Codigo");
        this.txtCodigo.Focus();
        return false;
      }
      if (this.txtDescripcion.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar una Descripcion");
        this.txtDescripcion.Focus();
        return false;
      }
      if (this.cmbCategoria.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Seleccionar una Categoria");
        this.cmbCategoria.Focus();
        return false;
      }
      if (this.txtValorCompra.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar el Valor de Compra");
        this.txtValorCompra.Focus();
        return false;
      }
      if (this.txtValorVenta1.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar el Valor de Venta");
        this.txtValorVenta1.Focus();
        return false;
      }
      if (this.txtStockMinimo.Text.Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar el Stock Minimo");
      this.txtStockMinimo.Focus();
      return false;
    }

    private ProductoVO armaProducto()
    {
      ProductoVO productoVo = new ProductoVO();
      productoVo.Codigo = this.txtCodigo.Text.Trim();
      productoVo.CodigoAlternativo = this.txtCodigoAlternativo.Text.Trim();
      productoVo.Descripcion = this.txtDescripcion.Text.Trim();
      productoVo.ResumenDescripcion = !frmMenuPrincipal._Fiscal ? "" : this.txtResumenDescripcion.Text.Trim();
      productoVo.Marca = this.txtMarca.Text.Trim();
      productoVo.CodCategoria = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
      productoVo.Categoria = this.cmbCategoria.Text.Trim();
      if (this.cmbSubCategoria.Text.Trim().Length > 0)
      {
        productoVo.IdSubCategoria = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
        productoVo.SubCategoria = this.cmbSubCategoria.Text.Trim();
      }
      else
      {
        productoVo.IdSubCategoria = 0;
        productoVo.SubCategoria = "";
      }
      if (this.cmbUnidadMedida.SelectedValue.ToString() != "0" && this.cmbUnidadMedida.SelectedValue != null)
      {
        productoVo.CodUnidadMedida = Convert.ToInt32(this.cmbUnidadMedida.SelectedValue.ToString());
        productoVo.UnidadMedida = this.cmbUnidadMedida.Text.Trim();
      }
      else
      {
        productoVo.CodUnidadMedida = 0;
        productoVo.UnidadMedida = "";
      }
      productoVo.Pesable = this.chkPesable.Checked;
      productoVo.Exento = this.chkExento.Checked;
      productoVo.Kit = this.chkKit.Checked;
      productoVo.ValorCompra = Convert.ToDecimal(this.txtValorCompra.Text.Trim());
      productoVo.ValorVenta1 = Convert.ToDecimal(this.txtValorVenta1.Text.Trim());
      productoVo.ValorVenta2 = Convert.ToDecimal(this.txtValorVenta2.Text.Trim());
      productoVo.ValorVenta3 = Convert.ToDecimal(this.txtValorVenta3.Text.Trim());
      productoVo.ValorVenta4 = Convert.ToDecimal(this.txtValorVenta4.Text.Trim());
      productoVo.ValorVenta5 = Convert.ToDecimal(this.txtValorVenta5.Text.Trim());
      productoVo.PorcRentabilidad1 = Convert.ToDecimal(this.txtUtilidad1.Text.Trim());
      productoVo.PorcRentabilidad2 = Convert.ToDecimal(this.txtUtilidad2.Text.Trim());
      productoVo.PorcRentabilidad3 = Convert.ToDecimal(this.txtUtilidad3.Text.Trim());
      productoVo.PorcRentabilidad4 = Convert.ToDecimal(this.txtUtilidad4.Text.Trim());
      productoVo.PorcRentabilidad5 = Convert.ToDecimal(this.txtUtilidad5.Text.Trim());
      productoVo.StockMinimo = Convert.ToDecimal(this.txtStockMinimo.Text.Trim());
      productoVo.Bodega1 = Convert.ToDecimal(this.txtBodega1.Text.Trim());
      productoVo.Bodega2 = Convert.ToDecimal(this.txtBodega2.Text.Trim());
      productoVo.Bodega3 = Convert.ToDecimal(this.txtBodega3.Text.Trim());
      productoVo.Bodega4 = Convert.ToDecimal(this.txtBodega4.Text.Trim());
      productoVo.Bodega5 = Convert.ToDecimal(this.txtBodega5.Text.Trim());
      productoVo.Bodega6 = Convert.ToDecimal(this.txtBodega6.Text.Trim());
      productoVo.Bodega7 = Convert.ToDecimal(this.txtBodega7.Text.Trim());
      productoVo.Bodega8 = Convert.ToDecimal(this.txtBodega8.Text.Trim());
      productoVo.Bodega9 = Convert.ToDecimal(this.txtBodega9.Text.Trim());
      productoVo.Bodega10 = Convert.ToDecimal(this.txtBodega10.Text.Trim());
      productoVo.Bodega11 = Convert.ToDecimal(this.txtBodega11.Text.Trim());
      productoVo.Bodega12 = Convert.ToDecimal(this.txtBodega12.Text.Trim());
      productoVo.Bodega13 = Convert.ToDecimal(this.txtBodega13.Text.Trim());
      productoVo.Bodega14 = Convert.ToDecimal(this.txtBodega14.Text.Trim());
      productoVo.Bodega15 = Convert.ToDecimal(this.txtBodega15.Text.Trim());
      productoVo.Bodega16 = Convert.ToDecimal(this.txtBodega16.Text.Trim());
      productoVo.Bodega17 = Convert.ToDecimal(this.txtBodega17.Text.Trim());
      productoVo.Bodega18 = Convert.ToDecimal(this.txtBodega18.Text.Trim());
      productoVo.Bodega19 = Convert.ToDecimal(this.txtBodega19.Text.Trim());
      productoVo.Bodega20 = Convert.ToDecimal(this.txtBodega20.Text.Trim());
      if (this.cmbImpuesto.SelectedValue != null)
      {
        productoVo.IdImpuesto = Convert.ToInt32(this.cmbImpuesto.SelectedValue.ToString());
        productoVo.NombreImpuesto = this.cmbImpuesto.Text.ToString();
      }
      productoVo.RutaImg1 = this.rutaIMG1;
      productoVo.RutaImg2 = this.rutaIMG2;
      productoVo.RutaImg3 = this.rutaIMG3;
      return productoVo;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.validaCampos())
        return;
      this.llenaCampos();
      Producto producto = new Producto();
      try
      {
        producto.guardaProducto(this.armaProducto());
        this.comparaStockIngresa();
        int num = (int) MessageBox.Show("Producto Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaProducto();
        this._codEncontrado = 0;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Erroar al Guardar producto" + ex.Message);
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Modificar este Producto", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (!this.validaCampos())
          return;
        Producto producto = new Producto();
        try
        {
          this.comparaStockActualiza();
          producto.modificaProducto(this.armaProducto());
          int num = (int) MessageBox.Show("Producto Modificado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaProducto();
          this._codEncontrado = 0;
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Modificar producto " + ex.Message);
        }
      }
      else
      {
        this._codEncontrado = 0;
        this.iniciaProducto();
      }
    }

    private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
    {
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

    private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
    {
        
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtValorVenta1.Focus();
    }

    private void txtValorVenta1_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtValorVenta2.Focus();
    }

    private void txtValorVenta2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtValorVenta3.Focus();
    }

    private void txtValorVenta3_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtValorVenta4.Focus();
    }

    private void txtUtilidad1_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtUtilidad2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtUtilidad3_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega1.Focus();
    }

    private void txtBodega1_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega2.Focus();
    }

    private void txtBodega2_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega3.Focus();
    }

    private void txtBodega3_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega4.Focus();
    }

    private void txtBodega4_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega5.Focus();
    }

    private void txtBodega5_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega6.Focus();
    }

    private void txtBodega6_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega7.Focus();
    }

    private void txtBodega7_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega8.Focus();
    }

    private void txtBodega8_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega9.Focus();
    }

    private void txtBodega9_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtBodega10.Focus();
    }

    private void txtBodega10_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtCodigo_Enter(object sender, EventArgs e)
    {
      this.txtCodigo.BackColor = Color.PeachPuff;
    }

    private void txtCodigo_Leave_1(object sender, EventArgs e)
    {
      if (this._codEncontrado == 0 && this.txtCodigo.Text.Length > 0)
        this.buscaCodigo(this.txtCodigo.Text.Trim());
      this.txtCodigo.BackColor = Color.White;
      this.txtCodigo.Text = this.txtCodigo.Text.ToUpper();
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

    private void buscaCodigo(string cod)
    {
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
      if (productoVo.Codigo == null)
      {
        this._codEncontrado = 1;
        int num = (int) MessageBox.Show("El Producto No Existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        string str = cod;
        this.iniciaProducto();
        this.txtCodigo.Text = str;
        this.txtCodigoAlternativo.Focus();
        if (this._guarda)
          this.btnGuardar.Enabled = true;
        this.btnEliminar.Enabled = false;
        this.btnModificar.Enabled = false;
      }
      else
      {
        this.txtCodigo.Text = productoVo.Codigo;
        this.txtCodigoAlternativo.Text = productoVo.CodigoAlternativo;
        this.txtDescripcion.Text = productoVo.Descripcion;
        this.txtResumenDescripcion.Text = productoVo.ResumenDescripcion;
        this.txtMarca.Text = productoVo.Marca;
        this.cargaCategorias();
        this.cmbCategoria.Text = productoVo.Categoria;
        if (productoVo.IdSubCategoria > 0)
        {
          this.cargaSubCategoria(productoVo.CodCategoria);
          this.cmbSubCategoria.Text = productoVo.SubCategoria;
        }
        this.cargaUnidadMedida();
        this.cmbUnidadMedida.SelectedValue = (object) productoVo.CodUnidadMedida;
        this.chkExento.Checked = productoVo.Exento;
        if (productoVo.Exento)
        {
          this.cmbImpuesto.Enabled = false;
        }
        else
        {
          this.cmbImpuesto.Enabled = true;
          this.cmbImpuesto.SelectedValue = (object) productoVo.IdImpuesto;
        }
        this.chkKit.Visible = true;
        this.chkKit.Checked = productoVo.Kit;
        this.chkPesable.Checked = productoVo.Pesable;
        this.txtValorCompra.Text = this.verificaDecimales(productoVo.ValorCompra.ToString());
        TextBox textBox1 = this.txtValorVenta1;
        Decimal num = productoVo.ValorVenta1;
        string str1 = this.verificaDecimales(num.ToString());
        textBox1.Text = str1;
        TextBox textBox2 = this.txtValorVenta2;
        num = productoVo.ValorVenta2;
        string str2 = this.verificaDecimales(num.ToString());
        textBox2.Text = str2;
        TextBox textBox3 = this.txtValorVenta3;
        num = productoVo.ValorVenta3;
        string str3 = this.verificaDecimales(num.ToString());
        textBox3.Text = str3;
        TextBox textBox4 = this.txtValorVenta4;
        num = productoVo.ValorVenta4;
        string str4 = this.verificaDecimales(num.ToString());
        textBox4.Text = str4;
        TextBox textBox5 = this.txtValorVenta5;
        num = productoVo.ValorVenta5;
        string str5 = this.verificaDecimales(num.ToString());
        textBox5.Text = str5;
        TextBox textBox6 = this.txtUtilidad1;
        num = productoVo.PorcRentabilidad1;
        string str6 = num.ToString("N2");
        textBox6.Text = str6;
        TextBox textBox7 = this.txtUtilidad2;
        num = productoVo.PorcRentabilidad2;
        string str7 = num.ToString("N2");
        textBox7.Text = str7;
        TextBox textBox8 = this.txtUtilidad3;
        num = productoVo.PorcRentabilidad3;
        string str8 = num.ToString("N2");
        textBox8.Text = str8;
        TextBox textBox9 = this.txtUtilidad4;
        num = productoVo.PorcRentabilidad4;
        string str9 = num.ToString("N2");
        textBox9.Text = str9;
        TextBox textBox10 = this.txtUtilidad5;
        num = productoVo.PorcRentabilidad5;
        string str10 = num.ToString("N2");
        textBox10.Text = str10;
        TextBox textBox11 = this.txtStockMinimo;
        num = productoVo.StockMinimo;
        string str11 = num.ToString("N0");
        textBox11.Text = str11;
        TextBox textBox12 = this.txtBodega1;
        num = productoVo.Bodega1;
        string str12 = this.verificaDecimales(num.ToString());
        textBox12.Text = str12;
        TextBox textBox13 = this.txtBodega2;
        num = productoVo.Bodega2;
        string str13 = this.verificaDecimales(num.ToString());
        textBox13.Text = str13;
        TextBox textBox14 = this.txtBodega3;
        num = productoVo.Bodega3;
        string str14 = this.verificaDecimales(num.ToString());
        textBox14.Text = str14;
        TextBox textBox15 = this.txtBodega4;
        num = productoVo.Bodega4;
        string str15 = this.verificaDecimales(num.ToString());
        textBox15.Text = str15;
        TextBox textBox16 = this.txtBodega5;
        num = productoVo.Bodega5;
        string str16 = this.verificaDecimales(num.ToString());
        textBox16.Text = str16;
        TextBox textBox17 = this.txtBodega6;
        num = productoVo.Bodega6;
        string str17 = this.verificaDecimales(num.ToString());
        textBox17.Text = str17;
        TextBox textBox18 = this.txtBodega7;
        num = productoVo.Bodega7;
        string str18 = this.verificaDecimales(num.ToString());
        textBox18.Text = str18;
        TextBox textBox19 = this.txtBodega8;
        num = productoVo.Bodega8;
        string str19 = this.verificaDecimales(num.ToString());
        textBox19.Text = str19;
        TextBox textBox20 = this.txtBodega9;
        num = productoVo.Bodega9;
        string str20 = this.verificaDecimales(num.ToString());
        textBox20.Text = str20;
        TextBox textBox21 = this.txtBodega10;
        num = productoVo.Bodega10;
        string str21 = this.verificaDecimales(num.ToString());
        textBox21.Text = str21;
        TextBox textBox22 = this.txtBodega11;
        num = productoVo.Bodega11;
        string str22 = this.verificaDecimales(num.ToString());
        textBox22.Text = str22;
        TextBox textBox23 = this.txtBodega12;
        num = productoVo.Bodega12;
        string str23 = this.verificaDecimales(num.ToString());
        textBox23.Text = str23;
        TextBox textBox24 = this.txtBodega13;
        num = productoVo.Bodega13;
        string str24 = this.verificaDecimales(num.ToString());
        textBox24.Text = str24;
        TextBox textBox25 = this.txtBodega14;
        num = productoVo.Bodega14;
        string str25 = this.verificaDecimales(num.ToString());
        textBox25.Text = str25;
        TextBox textBox26 = this.txtBodega15;
        num = productoVo.Bodega15;
        string str26 = this.verificaDecimales(num.ToString());
        textBox26.Text = str26;
        TextBox textBox27 = this.txtBodega16;
        num = productoVo.Bodega16;
        string str27 = this.verificaDecimales(num.ToString());
        textBox27.Text = str27;
        TextBox textBox28 = this.txtBodega17;
        num = productoVo.Bodega17;
        string str28 = this.verificaDecimales(num.ToString());
        textBox28.Text = str28;
        TextBox textBox29 = this.txtBodega18;
        num = productoVo.Bodega18;
        string str29 = this.verificaDecimales(num.ToString());
        textBox29.Text = str29;
        TextBox textBox30 = this.txtBodega19;
        num = productoVo.Bodega19;
        string str30 = this.verificaDecimales(num.ToString());
        textBox30.Text = str30;
        TextBox textBox31 = this.txtBodega20;
        num = productoVo.Bodega20;
        string str31 = this.verificaDecimales(num.ToString());
        textBox31.Text = str31;
        this.listaStock.Add((object) productoVo.Bodega1);
        this.listaStock.Add((object) productoVo.Bodega2);
        this.listaStock.Add((object) productoVo.Bodega3);
        this.listaStock.Add((object) productoVo.Bodega4);
        this.listaStock.Add((object) productoVo.Bodega5);
        this.listaStock.Add((object) productoVo.Bodega6);
        this.listaStock.Add((object) productoVo.Bodega7);
        this.listaStock.Add((object) productoVo.Bodega8);
        this.listaStock.Add((object) productoVo.Bodega9);
        this.listaStock.Add((object) productoVo.Bodega10);
        this.listaStock.Add((object) productoVo.Bodega11);
        this.listaStock.Add((object) productoVo.Bodega12);
        this.listaStock.Add((object) productoVo.Bodega13);
        this.listaStock.Add((object) productoVo.Bodega14);
        this.listaStock.Add((object) productoVo.Bodega15);
        this.listaStock.Add((object) productoVo.Bodega16);
        this.listaStock.Add((object) productoVo.Bodega17);
        this.listaStock.Add((object) productoVo.Bodega18);
        this.listaStock.Add((object) productoVo.Bodega19);
        this.listaStock.Add((object) productoVo.Bodega20);
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        this.BuscaLote(productoVo.Codigo);
        this._codEncontrado = 0;
      }
    }

    private void BuscaLote(string codigo)
    {
      this.dgvLote.DataSource = (object) null;
      this.dgvLote.DataSource = (object) new Aptusoft.Lotes.Lote().ListaLotePorCodigo(codigo);
    }

    private void buscaCodigoAlternativo(string cod)
    {
      ProductoVO productoVo = new Producto().buscaCodigoAlternativoProducto(cod);
      if (productoVo.Codigo == null)
      {
        this._codEncontrado = 1;
        int num = (int) MessageBox.Show("El Producto No Existe");
      }
      else
      {
        this.txtCodigo.Text = productoVo.Codigo;
        this.txtCodigoAlternativo.Text = productoVo.CodigoAlternativo;
        this.txtDescripcion.Text = productoVo.Descripcion;
        this.txtResumenDescripcion.Text = productoVo.ResumenDescripcion;
        this.txtMarca.Text = productoVo.Marca;
        this.cargaCategorias();
        this.cmbCategoria.Text = productoVo.Categoria;
        if (productoVo.IdSubCategoria > 0)
        {
          this.cargaSubCategoria(productoVo.CodCategoria);
          this.cmbSubCategoria.Text = productoVo.SubCategoria;
        }
        this.cargaUnidadMedida();
        this.cmbUnidadMedida.SelectedValue = (object) productoVo.CodUnidadMedida;
        this.chkExento.Checked = productoVo.Exento;
        if (productoVo.Exento)
        {
          this.cmbImpuesto.Enabled = false;
        }
        else
        {
          this.cmbImpuesto.Enabled = true;
          this.cmbImpuesto.SelectedValue = (object) productoVo.IdImpuesto;
        }
        this.chkKit.Visible = true;
        this.chkKit.Checked = productoVo.Kit;
        this.chkPesable.Checked = productoVo.Pesable;
        TextBox textBox1 = this.txtValorCompra;
        Decimal num = productoVo.ValorCompra;
        string str1 = num.ToString("N0");
        textBox1.Text = str1;
        TextBox textBox2 = this.txtValorVenta1;
        num = productoVo.ValorVenta1;
        string str2 = num.ToString("N0");
        textBox2.Text = str2;
        TextBox textBox3 = this.txtValorVenta2;
        num = productoVo.ValorVenta2;
        string str3 = num.ToString("N0");
        textBox3.Text = str3;
        TextBox textBox4 = this.txtValorVenta3;
        num = productoVo.ValorVenta3;
        string str4 = num.ToString("N0");
        textBox4.Text = str4;
        TextBox textBox5 = this.txtValorVenta4;
        num = productoVo.ValorVenta4;
        string str5 = num.ToString("N0");
        textBox5.Text = str5;
        TextBox textBox6 = this.txtValorVenta5;
        num = productoVo.ValorVenta5;
        string str6 = num.ToString("N0");
        textBox6.Text = str6;
        TextBox textBox7 = this.txtUtilidad1;
        num = productoVo.PorcRentabilidad1;
        string str7 = num.ToString("N2");
        textBox7.Text = str7;
        TextBox textBox8 = this.txtUtilidad2;
        num = productoVo.PorcRentabilidad2;
        string str8 = num.ToString("N2");
        textBox8.Text = str8;
        TextBox textBox9 = this.txtUtilidad3;
        num = productoVo.PorcRentabilidad3;
        string str9 = num.ToString("N2");
        textBox9.Text = str9;
        TextBox textBox10 = this.txtUtilidad4;
        num = productoVo.PorcRentabilidad4;
        string str10 = num.ToString("N2");
        textBox10.Text = str10;
        TextBox textBox11 = this.txtUtilidad5;
        num = productoVo.PorcRentabilidad5;
        string str11 = num.ToString("N2");
        textBox11.Text = str11;
        TextBox textBox12 = this.txtStockMinimo;
        num = productoVo.StockMinimo;
        string str12 = num.ToString("N0");
        textBox12.Text = str12;
        TextBox textBox13 = this.txtBodega1;
        num = productoVo.Bodega1;
        string str13 = this.verificaDecimales(num.ToString());
        textBox13.Text = str13;
        TextBox textBox14 = this.txtBodega2;
        num = productoVo.Bodega2;
        string str14 = this.verificaDecimales(num.ToString());
        textBox14.Text = str14;
        TextBox textBox15 = this.txtBodega3;
        num = productoVo.Bodega3;
        string str15 = this.verificaDecimales(num.ToString());
        textBox15.Text = str15;
        TextBox textBox16 = this.txtBodega4;
        num = productoVo.Bodega4;
        string str16 = this.verificaDecimales(num.ToString());
        textBox16.Text = str16;
        TextBox textBox17 = this.txtBodega5;
        num = productoVo.Bodega5;
        string str17 = this.verificaDecimales(num.ToString());
        textBox17.Text = str17;
        TextBox textBox18 = this.txtBodega6;
        num = productoVo.Bodega6;
        string str18 = this.verificaDecimales(num.ToString());
        textBox18.Text = str18;
        TextBox textBox19 = this.txtBodega7;
        num = productoVo.Bodega7;
        string str19 = this.verificaDecimales(num.ToString());
        textBox19.Text = str19;
        TextBox textBox20 = this.txtBodega8;
        num = productoVo.Bodega8;
        string str20 = this.verificaDecimales(num.ToString());
        textBox20.Text = str20;
        TextBox textBox21 = this.txtBodega9;
        num = productoVo.Bodega9;
        string str21 = this.verificaDecimales(num.ToString());
        textBox21.Text = str21;
        TextBox textBox22 = this.txtBodega10;
        num = productoVo.Bodega10;
        string str22 = this.verificaDecimales(num.ToString());
        textBox22.Text = str22;
        TextBox textBox23 = this.txtBodega11;
        num = productoVo.Bodega11;
        string str23 = this.verificaDecimales(num.ToString());
        textBox23.Text = str23;
        TextBox textBox24 = this.txtBodega12;
        num = productoVo.Bodega12;
        string str24 = this.verificaDecimales(num.ToString());
        textBox24.Text = str24;
        TextBox textBox25 = this.txtBodega13;
        num = productoVo.Bodega13;
        string str25 = this.verificaDecimales(num.ToString());
        textBox25.Text = str25;
        TextBox textBox26 = this.txtBodega14;
        num = productoVo.Bodega14;
        string str26 = this.verificaDecimales(num.ToString());
        textBox26.Text = str26;
        TextBox textBox27 = this.txtBodega15;
        num = productoVo.Bodega15;
        string str27 = this.verificaDecimales(num.ToString());
        textBox27.Text = str27;
        TextBox textBox28 = this.txtBodega16;
        num = productoVo.Bodega16;
        string str28 = this.verificaDecimales(num.ToString());
        textBox28.Text = str28;
        TextBox textBox29 = this.txtBodega17;
        num = productoVo.Bodega17;
        string str29 = this.verificaDecimales(num.ToString());
        textBox29.Text = str29;
        TextBox textBox30 = this.txtBodega18;
        num = productoVo.Bodega18;
        string str30 = this.verificaDecimales(num.ToString());
        textBox30.Text = str30;
        TextBox textBox31 = this.txtBodega19;
        num = productoVo.Bodega19;
        string str31 = this.verificaDecimales(num.ToString());
        textBox31.Text = str31;
        TextBox textBox32 = this.txtBodega20;
        num = productoVo.Bodega20;
        string str32 = this.verificaDecimales(num.ToString());
        textBox32.Text = str32;
        this.listaStock.Add((object) productoVo.Bodega1);
        this.listaStock.Add((object) productoVo.Bodega2);
        this.listaStock.Add((object) productoVo.Bodega3);
        this.listaStock.Add((object) productoVo.Bodega4);
        this.listaStock.Add((object) productoVo.Bodega5);
        this.listaStock.Add((object) productoVo.Bodega6);
        this.listaStock.Add((object) productoVo.Bodega7);
        this.listaStock.Add((object) productoVo.Bodega8);
        this.listaStock.Add((object) productoVo.Bodega9);
        this.listaStock.Add((object) productoVo.Bodega10);
        this.listaStock.Add((object) productoVo.Bodega11);
        this.listaStock.Add((object) productoVo.Bodega12);
        this.listaStock.Add((object) productoVo.Bodega13);
        this.listaStock.Add((object) productoVo.Bodega14);
        this.listaStock.Add((object) productoVo.Bodega15);
        this.listaStock.Add((object) productoVo.Bodega16);
        this.listaStock.Add((object) productoVo.Bodega17);
        this.listaStock.Add((object) productoVo.Bodega18);
        this.listaStock.Add((object) productoVo.Bodega19);
        this.listaStock.Add((object) productoVo.Bodega20);
        this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox1.Image = (Image) productoVo.Img1;
        this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox2.Image = (Image) productoVo.Img2;
        this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox3.Image = (Image) productoVo.Img3;
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        this._codEncontrado = 0;
      }
    }

    private void calculaValorVenta()
    {
        bool flag = this._conIva;
        Decimal iva = this._iva;
        Decimal num2 = new Decimal(0);
        if (this.txtValorCompra.Text.Trim().Length != 0 && this.txtValorCompra.Text != "" && this.txtValorCompra.Text != null)
        {
            Decimal ValorCommpra = Decimal.Parse(this.txtValorCompra.Text.Trim());
            Decimal num4;
            Decimal num5;
            if (ValorCommpra > new Decimal(0))
            {
                if (this.chkIngresaUtilidad.Checked)
                {
                    if (!this.chkExento.Checked)
                    {
                        if (this.txtUtilidad1.Text.Trim().Length > 0)
                        {
                            Decimal txtutilidad = Convert.ToDecimal(this.txtUtilidad1.Text);
                            num4 = new Decimal(0);
                            num4 = txtutilidad / new Decimal(100);
                            ++num4;
                            Decimal utilidad = ValorCommpra * num4;
                            this.txtValorVenta1.Text = string.Format("{0:0}", utilidad);
                            if (flag)
                            {
                                txtValorVenta1.Clear();
                                if (txtValorVenta1.Text.Length <= 0)
                                {
                                    Decimal d1 =  Decimal.Divide(iva, new Decimal(100))+1;
                                    //utilidad *= ++d1;
                                    Decimal iva_incluido = Decimal.Multiply(ValorCommpra, d1);
                                    Decimal total = Decimal.Multiply(iva_incluido, Decimal.Divide(Convert.ToDecimal(txtUtilidad1.Text.ToString()), 100)+1);
                                    this.txtValorVenta1.Text = string.Format("{0:0}", total);
                                }
                            }
                            if (txtValorVenta1.Text.Length <= 0) { return; }
                        }
                        if (this.txtUtilidad2.Text.Trim().Length > 0) //&& txtUtilidad2.Text.ToString() != "0")
                        {
                            Decimal txtutilidad = Convert.ToDecimal(this.txtUtilidad2.Text);
                            num4 = new Decimal(0);
                            num4 = txtutilidad / new Decimal(100);
                            ++num4;
                            Decimal utilidad = ValorCommpra * num4;
                            this.txtValorVenta2.Text = string.Format("{0:0}", utilidad);
                            if (flag)
                            {
                                //Decimal d7 = iva / new Decimal(100);
                                //utilidad *= ++d7;
                                //this.txtValorVenta2.Text = string.Format("{0:0}", utilidad);
                                txtValorVenta2.Clear();
                                if (txtValorVenta2.Text.Length <= 0 )
                                {
                                    Decimal d7 = Decimal.Divide(iva, new Decimal(100)) + 1;
                                    //utilidad *= ++d1;
                                    Decimal iva_incluido = Decimal.Multiply(ValorCommpra, d7);
                                    Decimal total = Decimal.Multiply(iva_incluido, Decimal.Divide(Convert.ToDecimal(txtUtilidad2.Text.ToString()), 100) + 1);
                                    this.txtValorVenta2.Text = string.Format("{0:0}", total);
                                }
                            }
                            if (txtValorVenta2.Text.Length <= 0) { return; }
                        }
                        if (this.txtUtilidad3.Text.Trim().Length > 0)
                        {
                            Decimal txtutilidad = Convert.ToDecimal(this.txtUtilidad3.Text);
                            num4 = new Decimal(0);
                            num4 = txtutilidad / new Decimal(100);
                            ++num4;
                            Decimal utilidad = ValorCommpra * num4;

                            this.txtValorVenta3.Text = string.Format("{0:0}", utilidad);
                            if (flag)
                            {
                                //Decimal d1 = iva / new Decimal(100);
                                //utilidad *= ++d1;
                                //this.txtValorVenta3.Text = string.Format("{0:0}", utilidad);
                                txtValorVenta3.Clear();
                                if (txtValorVenta3.Text.Length <= 0 )
                                {
                                    Decimal d3 = Decimal.Divide(iva, new Decimal(100)) + 1;
                                    //utilidad *= ++d1;
                                    Decimal iva_incluido = Decimal.Multiply(ValorCommpra, d3);
                                    Decimal total = Decimal.Multiply(iva_incluido, Decimal.Divide(Convert.ToDecimal(txtUtilidad3.Text.ToString()), 100) + 1);
                                    this.txtValorVenta3.Text = string.Format("{0:0}", total);
                                }
                            }
                            if (txtValorVenta3.Text.Length <= 0) { return; }
                        }
                        if (this.txtUtilidad4.Text.Trim().Length > 0)
                        {
                            Decimal txtutilidad = Convert.ToDecimal(this.txtUtilidad4.Text);
                            num4 = new Decimal(0);
                            num4 = txtutilidad / new Decimal(100);
                            ++num4;
                            Decimal utilidad = ValorCommpra * num4;

                            this.txtValorVenta4.Text = string.Format("{0:0}", utilidad);
                            if (flag)
                            {
                                //Decimal d1 = iva / new Decimal(100);
                                //utilidad *= ++d1;
                                //this.txtValorVenta4.Text = string.Format("{0:0}", utilidad);
                                txtValorVenta4.Clear();
                                if (txtValorVenta4.Text.Length <= 0 )
                                {
                                    Decimal d4 = Decimal.Divide(iva, new Decimal(100)) + 1;
                                    //utilidad *= ++d1;
                                    Decimal iva_incluido = Decimal.Multiply(ValorCommpra, d4);
                                    Decimal total = Decimal.Multiply(iva_incluido, Decimal.Divide(Convert.ToDecimal(txtUtilidad4.Text.ToString()), 100) + 1);
                                    this.txtValorVenta4.Text = string.Format("{0:0}", total);
                                }
                            }
                            if (txtValorVenta4.Text.Length <= 0) { return; }
                        }
                        if (this.txtUtilidad5.Text.Trim().Length > 0)
                        {

                            Decimal txtutilidad = Convert.ToDecimal(this.txtUtilidad5.Text);
                            num4 = new Decimal(0);
                            num4 = txtutilidad / new Decimal(100);
                            ++num4;
                            Decimal utilidad = ValorCommpra * num4;

                            this.txtValorVenta5.Text = string.Format("{0:0}", utilidad);
                            if (flag)
                            {
                                //Decimal d1 = iva / new Decimal(100);
                                //utilidad *= ++d1;
                                //this.txtValorVenta5.Text = string.Format("{0:0}", utilidad);
                                txtValorVenta5.Clear();
                                if (txtValorVenta5.Text.Length <= 0 )
                                {
                                    Decimal d1 = Decimal.Divide(iva, new Decimal(100)) + 1;
                                    //utilidad *= ++d1;
                                    Decimal iva_incluido = Decimal.Multiply(ValorCommpra, d1);
                                    Decimal total = Decimal.Multiply(iva_incluido, Decimal.Divide(Convert.ToDecimal(txtUtilidad5.Text.ToString()), 100) + 1);
                                    this.txtValorVenta5.Text = string.Format("{0:0}", total);
                                }
                            }
                            if (txtValorVenta5.Text.Length <= 0) { return; }
                        }
                    }
                    else
                    {
                        if (this.txtUtilidad1.Text.Trim().Length > 0)
                        {
                            Decimal num6 = Convert.ToDecimal(this.txtUtilidad1.Text);
                            num4 = new Decimal(0);
                            Decimal h2 = num6 / new Decimal(100);
                            this.txtValorVenta1.Text = string.Format("{0:0}", (object)(ValorCommpra * ++h2));
                        }
                        if (this.txtUtilidad2.Text.Trim().Length > 0)
                        {
                            Decimal num6 = Convert.ToDecimal(this.txtUtilidad2.Text);
                            num4 = new Decimal(0);
                            Decimal h3 = num6 / new Decimal(100);
                            this.txtValorVenta2.Text = string.Format("{0:0}", (object)(ValorCommpra * ++h3));
                        }
                        if (this.txtUtilidad3.Text.Trim().Length > 0)
                        {
                            Decimal num6 = Convert.ToDecimal(this.txtUtilidad3.Text);
                            num4 = new Decimal(0);
                            Decimal h4 = num6 / new Decimal(100);
                            this.txtValorVenta3.Text = string.Format("{0:0}", (object)(ValorCommpra * ++h4));
                        }
                        if (this.txtUtilidad4.Text.Trim().Length > 0)
                        {
                            Decimal num6 = Convert.ToDecimal(this.txtUtilidad4.Text);
                            num4 = new Decimal(0);
                            Decimal h5 = num6 / new Decimal(100);
                            this.txtValorVenta4.Text = string.Format("{0:0}", (object)(ValorCommpra * ++h5));
                        }
                        if (this.txtUtilidad5.Text.Trim().Length > 0)
                        {
                            Decimal num6 = Convert.ToDecimal(this.txtUtilidad5.Text);
                            num4 = new Decimal(0);
                            Decimal h6 = num6 / new Decimal(100);
                            this.txtValorVenta5.Text = string.Format("{0:0}", (object)(ValorCommpra * ++h6));
                        }
                    }
                }
                else if (!this.chkExento.Checked)
                {
                    if (this.txtValorVenta1.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal num6 = Decimal.Parse(this.txtValorVenta1.Text.Trim());

                        if (flag)
                        {
                            Decimal e4 = iva / new Decimal(100);
                            num6 /= ++e4;
                            Decimal e5 = num6 / ValorCommpra;

                            this.txtUtilidad1.Text = string.Format("{0:00.00}", (object)(--e5 * new Decimal(100)));
                        }
                    }
                    if (this.txtValorVenta2.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal num6 = Decimal.Parse(this.txtValorVenta2.Text.Trim());
                        if (flag)
                        {
                            Decimal f1 = iva / new Decimal(100);
                            num6 /= ++f1;
                            Decimal f2 = num6 / ValorCommpra;
                            this.txtUtilidad2.Text = string.Format("{0:00.00}", (object)(--f2 * new Decimal(100)));

                        }
                    }
                    if (this.txtValorVenta3.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal num6 = Decimal.Parse(this.txtValorVenta3.Text.Trim());
                        if (flag)
                        {
                            Decimal f3 = iva / new Decimal(100);
                            num6 /= ++f3;
                            Decimal f4 = num6 / ValorCommpra;
                            this.txtUtilidad3.Text = string.Format("{0:00.00}", (object)(--f4 * new Decimal(100)));

                        }
                    }
                    if (this.txtValorVenta4.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal num6 = Decimal.Parse(this.txtValorVenta4.Text.Trim());
                        if (flag)
                        {
                            Decimal f5 = iva / new Decimal(100);
                            num6 /= ++f5;
                            Decimal f6 = num6 / ValorCommpra;
                            this.txtUtilidad4.Text = string.Format("{0:00.00}", (object)(--f6 * new Decimal(100)));
                        }
                    }
                    if (this.txtValorVenta5.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal num6 = Decimal.Parse(this.txtValorVenta5.Text.Trim());
                        if (flag)
                        {
                            Decimal f7 = iva / new Decimal(100);
                            num6 /= ++f7;
                            Decimal f8 = num6 / ValorCommpra;
                            this.txtUtilidad5.Text = string.Format("{0:00.00}", (object)(--f8 * new Decimal(100)));
                        }
                    }
                }
                else
                {
                    if (this.txtValorVenta1.Text.Trim().Length > 0)
                    {
                        Decimal f9 = Decimal.Parse(this.txtValorVenta1.Text.Trim()) / ValorCommpra;
                        num5 = new Decimal(0);
                        this.txtUtilidad1.Text = string.Format("{0:00.00}", (object)(--f9 * new Decimal(100)));
                    }
                    if (this.txtValorVenta2.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal g1 = Decimal.Parse(this.txtValorVenta2.Text.Trim()) / ValorCommpra;
                        this.txtUtilidad2.Text = string.Format("{0:00.00}", (object)(--g1 * new Decimal(100)));
                    }
                    if (this.txtValorVenta3.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal g2 = Decimal.Parse(this.txtValorVenta3.Text.Trim()) / ValorCommpra;
                        this.txtUtilidad3.Text = string.Format("{0:00.00}", (object)(--g2 * new Decimal(100)));
                    }
                    if (this.txtValorVenta4.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal g3 = Decimal.Parse(this.txtValorVenta4.Text.Trim()) / ValorCommpra;
                        this.txtUtilidad4.Text = string.Format("{0:00.00}", (object)(--g3 * new Decimal(100)));
                    }
                    if (this.txtValorVenta5.Text.Trim().Length > 0)
                    {
                        num5 = new Decimal(0);
                        Decimal g4 = Decimal.Parse(this.txtValorVenta5.Text.Trim()) / ValorCommpra;
                        this.txtUtilidad5.Text = string.Format("{0:00.00}", (object)(--g4 * new Decimal(100)));
                    }
                }
            }
            
            else
            {
                return;
            }
        }
    }
    private void txtDescripcion_Enter(object sender, EventArgs e)
    {
      this.txtDescripcion.BackColor = Color.PeachPuff;
    }

    private void txtDescripcion_Leave(object sender, EventArgs e)
    {
      this.txtDescripcion.BackColor = Color.White;
      this.txtDescripcion.Text = this.txtDescripcion.Text.ToUpper();
    }

    private void txtMarca_Enter(object sender, EventArgs e)
    {
      this.txtMarca.BackColor = Color.PeachPuff;
    }

    private void txtMarca_Leave(object sender, EventArgs e)
    {
      this.txtMarca.BackColor = Color.White;
      this.txtMarca.Text = this.txtMarca.Text.ToUpper();
    }

    private void cmbCategoria_Leave(object sender, EventArgs e)
    {
      this.cmbCategoria.BackColor = Color.White;
    }

    private void txtValorCompra_Enter(object sender, EventArgs e)
    {
      this.txtValorCompra.BackColor = Color.PeachPuff;
    }

    private void txtValorCompra_Leave(object sender, EventArgs e)
    {
      this.txtValorCompra.BackColor = Color.White;
    }

    private void txtValorVenta1_Enter(object sender, EventArgs e)
    {
      this.txtValorVenta1.BackColor = Color.PeachPuff;
    }

    private void txtValorVenta1_Leave(object sender, EventArgs e)
    {
      this.txtValorVenta1.BackColor = Color.White;
    }

    private void txtValorVenta2_Enter(object sender, EventArgs e)
    {
      this.txtValorVenta2.BackColor = Color.PeachPuff;
    }

    private void txtValorVenta2_Leave(object sender, EventArgs e)
    {
      this.txtValorVenta2.BackColor = Color.White;
    }

    private void txtValorVenta3_Enter(object sender, EventArgs e)
    {
      this.txtValorVenta3.BackColor = Color.PeachPuff;
    }

    private void txtValorVenta3_Leave(object sender, EventArgs e)
    {
      this.txtValorVenta3.BackColor = Color.White;
    }

    private void txtUtilidad1_Enter(object sender, EventArgs e)
    {
      this.txtUtilidad1.BackColor = Color.PeachPuff;
    }

    private void txtUtilidad1_Leave(object sender, EventArgs e)
    {
      this.txtUtilidad1.BackColor = Color.White;
    }

    private void txtUtilidad2_Enter(object sender, EventArgs e)
    {
      this.txtUtilidad2.BackColor = Color.PeachPuff;
    }

    private void txtUtilidad2_Leave(object sender, EventArgs e)
    {
      this.txtUtilidad2.BackColor = Color.White;
    }

    private void txtUtilidad3_Enter(object sender, EventArgs e)
    {
      this.txtUtilidad3.BackColor = Color.PeachPuff;
    }

    private void txtUtilidad3_Leave(object sender, EventArgs e)
    {
      this.txtUtilidad3.BackColor = Color.White;
    }

    private void cmbUnidadMedida_Enter(object sender, EventArgs e)
    {
      this.cmbUnidadMedida.BackColor = Color.PeachPuff;
    }

    private void cmbUnidadMedida_Leave(object sender, EventArgs e)
    {
      this.cmbUnidadMedida.BackColor = Color.White;
    }

    private void txtStockMinimo_Enter(object sender, EventArgs e)
    {
      this.txtStockMinimo.BackColor = Color.PeachPuff;
    }

    private void txtStockMinimo_Leave(object sender, EventArgs e)
    {
      this.txtStockMinimo.BackColor = Color.White;
    }

    private void txtBusca_Enter(object sender, EventArgs e)
    {
      this.txtBusca.BackColor = Color.PeachPuff;
    }

    private void txtBusca_Leave(object sender, EventArgs e)
    {
      this.txtBusca.BackColor = Color.White;
    }

    private void cmbBuscaCategoria_Enter(object sender, EventArgs e)
    {
      this.cargaCategoriasBuscar();
      this.cmbBuscaCategoria.BackColor = Color.PeachPuff;
    }

    private void cmbBuscaCategoria_Leave(object sender, EventArgs e)
    {
      this.cmbBuscaCategoria.BackColor = Color.White;
    }

    private void txtBodega1_Enter(object sender, EventArgs e)
    {
      this.txtBodega1.BackColor = Color.PeachPuff;
    }

    private void txtBodega1_Leave(object sender, EventArgs e)
    {
      this.txtBodega1.BackColor = Color.White;
    }

    private void txtBodega2_Enter(object sender, EventArgs e)
    {
      this.txtBodega2.BackColor = Color.PeachPuff;
    }

    private void txtBodega2_Leave(object sender, EventArgs e)
    {
      this.txtBodega2.BackColor = Color.White;
    }

    private void txtBodega3_Enter(object sender, EventArgs e)
    {
      this.txtBodega3.BackColor = Color.PeachPuff;
    }

    private void txtBodega3_Leave(object sender, EventArgs e)
    {
      this.txtBodega3.BackColor = Color.White;
    }

    private void txtBodega4_Enter(object sender, EventArgs e)
    {
      this.txtBodega4.BackColor = Color.PeachPuff;
    }

    private void txtBodega4_Leave(object sender, EventArgs e)
    {
      this.txtBodega4.BackColor = Color.White;
    }

    private void txtBodega5_Enter(object sender, EventArgs e)
    {
      this.txtBodega5.BackColor = Color.PeachPuff;
    }

    private void txtBodega5_Leave(object sender, EventArgs e)
    {
      this.txtBodega5.BackColor = Color.White;
    }

    private void txtBodega6_Enter(object sender, EventArgs e)
    {
      this.txtBodega6.BackColor = Color.PeachPuff;
    }

    private void txtBodega6_Leave(object sender, EventArgs e)
    {
      this.txtBodega6.BackColor = Color.White;
    }

    private void txtBodega7_Enter(object sender, EventArgs e)
    {
      this.txtBodega7.BackColor = Color.PeachPuff;
    }

    private void txtBodega7_Leave(object sender, EventArgs e)
    {
      this.txtBodega7.BackColor = Color.White;
    }

    private void txtBodega8_Enter(object sender, EventArgs e)
    {
      this.txtBodega8.BackColor = Color.PeachPuff;
    }

    private void txtBodega8_Leave(object sender, EventArgs e)
    {
      this.txtBodega8.BackColor = Color.White;
    }

    private void txtBodega9_Enter(object sender, EventArgs e)
    {
      this.txtBodega9.BackColor = Color.PeachPuff;
    }

    private void txtBodega9_Leave(object sender, EventArgs e)
    {
      this.txtBodega9.BackColor = Color.White;
    }

    private void txtBodega10_Enter(object sender, EventArgs e)
    {
      this.txtBodega10.BackColor = Color.PeachPuff;
    }

    private void txtBodega10_Leave(object sender, EventArgs e)
    {
      this.txtBodega10.BackColor = Color.White;
    }

    private void chkIngresaUtilidad_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkIngresaUtilidad.Checked)
      {
        if (this.txtValorCompra.Text == "0" || this.txtValorCompra.Text.Trim().Length == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar un Valor de Compra Superior a Cero");
          this.chkIngresaUtilidad.Checked = false;
          this.txtValorCompra.Focus();
        }
        else
        {
          this.txtUtilidad1.Enabled = true;
          this.txtUtilidad2.Enabled = true;
          this.txtUtilidad3.Enabled = true;
          this.txtUtilidad4.Enabled = true;
          this.txtUtilidad5.Enabled = true;
        }
      }
      else
      {
        this.txtUtilidad1.Enabled = false;
        this.txtUtilidad2.Enabled = false;
        this.txtUtilidad3.Enabled = false;
        this.txtUtilidad4.Enabled = false;
        this.txtUtilidad5.Enabled = false;
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this._codEncontrado = 0;
      this.iniciaProducto();
     // this.InitializeComponent();
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.buscaCodigo(this.txtCodigo.Text.Trim());
    }

    private void txtValorVenta1_TextChanged(object sender, EventArgs e)
    {
        //if (this.txtValorVenta1.Text.Trim().Length != 0) { this.calculaValorVenta(); }
        //else
        //{
         
        //}
    }

    private void txtUtilidad1_TextChanged(object sender, EventArgs e)
    {
        //txtUtilidad1.Text = "0";
        if (this.txtUtilidad1.Text.Trim().Length == 0)
        {
            txtUtilidad1.Text = "0";
        }
        else if(txtUtilidad1.Text.Length < 0 && txtUtilidad1.Text == "0"){
            txtUtilidad1.Clear();
        }
        else
        {
            this.calculaValorVenta();
        }
    }

    private void txtValorVenta2_TextChanged(object sender, EventArgs e)
    {
        //if (this.txtValorVenta2.Text.Trim().Length != 0) { this.calculaValorVenta(); }
        //else
        //{
             
        //}
    }

    private void txtValorVenta3_TextChanged(object sender, EventArgs e)
    {
        //if (this.txtValorVenta3.Text.Trim().Length != 0) { this.calculaValorVenta(); }
      //this.calculaValorVenta();
    }

    private void txtUtilidad2_TextChanged(object sender, EventArgs e)
    {
        //if (this.txtUtilidad2.Text.Trim().Length == 0)
        //{
        //    txtUtilidad2.Text = "0";
        //}
        //else if (txtUtilidad2.Text.Length < 0 && txtUtilidad2.Text == "0")
        //{
        //    txtUtilidad2.Clear();
        //}
        //else
        //{
        //    this.calculaValorVenta();
        //}
        if (this.txtUtilidad2.Text.Trim().Length == 0)
        {
            txtUtilidad2.Text = "0";
        }
        else if (txtUtilidad2.Text.Length < 0 && txtUtilidad2.Text == "0")
        {
            txtUtilidad2.Clear();
        }
        else
        {
           this.calculaValorVenta();
        }
    }

    private void txtUtilidad3_TextChanged(object sender, EventArgs e)
    {
        if (this.txtUtilidad3.Text.Trim().Length == 0)
        {
            txtUtilidad3.Text = "0";
        }
        else if (txtUtilidad3.Text.Length < 0 && txtUtilidad3.Text == "0")
        {
            txtUtilidad3.Clear();
        }
        else
        {
            this.calculaValorVenta();
        }
    }

    private void chkIngresaUtilidad_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtMarca.Focus();
    }

    private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.cmbCategoria.Focus();
    }

    private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.cmbUnidadMedida.Focus();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar este Producto", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || this.txtCodigo.Text.Trim().Length <= 0)
        return;
      Producto producto = new Producto();
      try
      {
        producto.eliminaProducto(this.txtCodigo.Text.Trim());
        int num = (int) MessageBox.Show("Producto Eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaProducto();
        this._codEncontrado = 0;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Eliminar Producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void txtValorCompra_TextChanged(object sender, EventArgs e)
    {
      if (this.txtValorCompra.Text.Trim().Length <= 0)
        return;
      this.calculaValorVenta();
    }

    private void dgvProductos_DoubleClick(object sender, EventArgs e)
    {
      this.buscaCodigo(this.dgvProductos.SelectedRows[0].Cells["CODIGO"].Value.ToString());
    }

    private void txtBusca_TextChanged(object sender, EventArgs e)
    {
      if (this.txtBusca.Text.Trim().Length <= 0)
        return;
      this.dgvProductos.DataSource = (object) new Producto().listaProductosDescripcion(1, this.txtBusca.Text.Trim(), "Bodega1", "").Tables[0];
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if (this.cmbBuscaCategoria.SelectedIndex != -1)
      {
        this.dgvProductos.DataSource = (object) new Producto().listaProductosCategoria(this.cmbBuscaCategoria.Text).Tables[0];
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Seleccionar una categoria");
      }
    }

    private void btnIngresarCategoria_Click(object sender, EventArgs e)
    {
      int num = (int) new frmCategorias().ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) new frmUnidadMedidas().ShowDialog();
    }

    private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modProducto = 0;
    }

    private void chkExento_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkExento.Checked)
        this.cmbImpuesto.Enabled = false;
      else
        this.cmbImpuesto.Enabled = true;
      this.calculaValorVenta();
    }

    private void cargarImagen(int img)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Archivos JPEG(*.jpg)| *.jpg";
      openFileDialog.InitialDirectory = "c:/";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      string fileName = openFileDialog.FileName;
      if (img == 1)
      {
        this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        this.rutaIMG1 = fileName;
        Bitmap bitmap = new Bitmap(fileName);
        if (bitmap.Width <= 1024)
        {
          this.pictureBox1.Image = (Image) bitmap;
        }
        else
        {
          int num = (int) MessageBox.Show("Imagen Tamaño " +  bitmap.Width.ToString() + " X " +  bitmap.Height.ToString() + "px es Muy Grande, El Tamaño no debe superar los 1024x768px", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      if (img == 2)
      {
        this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        this.rutaIMG2 = fileName;
        Bitmap bitmap = new Bitmap(fileName);
        if (bitmap.Width <= 1024)
        {
          this.pictureBox2.Image = (Image) bitmap;
        }
        else
        {
          int num = (int) MessageBox.Show("Imagen Tamaño " +  bitmap.Width.ToString() + " X " +  bitmap.Height.ToString() + "px es Muy Grande, El Tamaño no debe superar los 1024x768px", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      if (img == 3)
      {
        this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        this.rutaIMG3 = fileName;
        Bitmap bitmap = new Bitmap(fileName);
        if (bitmap.Width <= 1024)
        {
          this.pictureBox3.Image = (Image) bitmap;
        }
        else
        {
          int num = (int) MessageBox.Show("Imagen Tamaño " + (object) bitmap.Width + " X " + (string) (object) bitmap.Height + "px es Muy Grande, El Tamaño no debe superar los 1024x768px", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
    }

    private void btnAgregaIMG1_Click(object sender, EventArgs e)
    {
      this.cargarImagen(1);
    }

    private void btnAgregaIMG2_Click(object sender, EventArgs e)
    {
      this.cargarImagen(2);
    }

    private void btnAgregaIMG3_Click(object sender, EventArgs e)
    {
      this.cargarImagen(3);
    }

    private void btnQuitaIMG1_Click(object sender, EventArgs e)
    {
      this.pictureBox1.Image = (Image) null;
      this.rutaIMG1 = "1";
    }

    private void btnQuitaIMG2_Click(object sender, EventArgs e)
    {
      this.pictureBox2.Image = (Image) null;
      this.rutaIMG2 = "1";
    }

    private void btnQuitaIMG3_Click(object sender, EventArgs e)
    {
      this.pictureBox3.Image = (Image) null;
      this.rutaIMG3 = "1";
    }

    private void chkKit_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void btnCreaKit_Click(object sender, EventArgs e)
    {
    }

    private void btnArmaKit_Click(object sender, EventArgs e)
    {
    }

    private void comparaStockActualiza()
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = this.txtCodigo.Text.Trim();
      cp.DescripcionProducto = this.txtDescripcion.Text.Trim();
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "MODIFICACION STOCK";
      if (this.verificaDecimales(this.listaStock[0].ToString()) != this.txtBodega1.Text.Trim())
      {
        cp.Bodega = 1;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[0].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega1.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[1].ToString()) != this.txtBodega2.Text)
      {
        cp.Bodega = 2;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[1].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega2.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[2].ToString()) != this.txtBodega3.Text)
      {
        cp.Bodega = 3;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[2].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega3.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[3].ToString()) != this.txtBodega4.Text)
      {
        cp.Bodega = 4;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[3].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega4.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[4].ToString()) != this.txtBodega5.Text)
      {
        cp.Bodega = 5;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[4].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega5.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[5].ToString()) != this.txtBodega6.Text)
      {
        cp.Bodega = 6;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[5].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega6.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[6].ToString()) != this.txtBodega7.Text)
      {
        cp.Bodega = 7;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[6].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega7.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[7].ToString()) != this.txtBodega8.Text)
      {
        cp.Bodega = 8;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[7].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega8.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[8].ToString()) != this.txtBodega9.Text)
      {
        cp.Bodega = 9;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[8].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega9.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[9].ToString()) != this.txtBodega10.Text)
      {
        cp.Bodega = 10;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[9].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega10.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[10].ToString()) != this.txtBodega11.Text.Trim())
      {
        cp.Bodega = 11;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[10].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega11.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[11].ToString()) != this.txtBodega12.Text)
      {
        cp.Bodega = 12;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[11].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega12.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[12].ToString()) != this.txtBodega13.Text)
      {
        cp.Bodega = 3;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[12].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega13.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[13].ToString()) != this.txtBodega14.Text)
      {
        cp.Bodega = 14;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[13].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega14.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[14].ToString()) != this.txtBodega15.Text)
      {
        cp.Bodega = 15;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[14].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega15.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[15].ToString()) != this.txtBodega16.Text)
      {
        cp.Bodega = 16;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[15].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega16.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[16].ToString()) != this.txtBodega17.Text)
      {
        cp.Bodega = 17;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[16].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega17.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[17].ToString()) != this.txtBodega18.Text)
      {
        cp.Bodega = 18;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[17].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega18.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.verificaDecimales(this.listaStock[18].ToString()) != this.txtBodega19.Text)
      {
        cp.Bodega = 19;
        cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[18].ToString());
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega19.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (!(this.verificaDecimales(this.listaStock[19].ToString()) != this.txtBodega20.Text))
        return;
      cp.Bodega = 20;
      cp.CantidadAnterior = Convert.ToDecimal(this.listaStock[19].ToString());
      cp.CantidadActual = Convert.ToDecimal(this.txtBodega20.Text.Trim());
      controlProducto.agregaControlProducto(cp);
    }

    private void comparaStockIngresa()
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = this.txtCodigo.Text.Trim();
      cp.DescripcionProducto = this.txtDescripcion.Text.Trim();
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "INGRESO INICIAL";
      if (this.txtBodega1.Text.Trim() != "0")
      {
        cp.Bodega = 1;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega1.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega2.Text.Trim() != "0")
      {
        cp.Bodega = 2;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega2.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega3.Text.Trim() != "0")
      {
        cp.Bodega = 3;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega3.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega4.Text.Trim() != "0")
      {
        cp.Bodega = 4;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega4.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega5.Text.Trim() != "0")
      {
        cp.Bodega = 5;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega5.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega6.Text.Trim() != "0")
      {
        cp.Bodega = 6;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega6.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega7.Text.Trim() != "0")
      {
        cp.Bodega = 7;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega7.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega8.Text.Trim() != "0")
      {
        cp.Bodega = 8;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega8.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega9.Text.Trim() != "0")
      {
        cp.Bodega = 9;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega9.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega10.Text.Trim() != "0")
      {
        cp.Bodega = 10;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega10.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega11.Text.Trim() != "0")
      {
        cp.Bodega = 11;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega11.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega12.Text.Trim() != "0")
      {
        cp.Bodega = 12;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega12.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega13.Text.Trim() != "0")
      {
        cp.Bodega = 13;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega13.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega14.Text.Trim() != "0")
      {
        cp.Bodega = 14;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega14.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega15.Text.Trim() != "0")
      {
        cp.Bodega = 15;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega15.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega16.Text.Trim() != "0")
      {
        cp.Bodega = 16;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega16.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega17.Text.Trim() != "0")
      {
        cp.Bodega = 17;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega17.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega18.Text.Trim() != "0")
      {
        cp.Bodega = 18;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega18.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (this.txtBodega19.Text.Trim() != "0")
      {
        cp.Bodega = 19;
        cp.CantidadAnterior = new Decimal(0);
        cp.CantidadActual = Convert.ToDecimal(this.txtBodega19.Text.Trim());
        controlProducto.agregaControlProducto(cp);
      }
      if (!(this.txtBodega20.Text.Trim() != "0"))
        return;
      cp.Bodega = 20;
      cp.CantidadAnterior = new Decimal(0);
      cp.CantidadActual = Convert.ToDecimal(this.txtBodega20.Text.Trim());
      controlProducto.agregaControlProducto(cp);
    }

    private void txtCodigoAlternativo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtDescripcion.Focus();
    }

    private void txtCodigoAlternativo_Leave(object sender, EventArgs e)
    {
      this.txtCodigoAlternativo.BackColor = Color.White;
      this.txtCodigoAlternativo.Text = this.txtCodigoAlternativo.Text.ToUpper();
    }

    private void txtCodigoAlternativo_Enter(object sender, EventArgs e)
    {
      this.txtCodigoAlternativo.BackColor = Color.PeachPuff;
    }

    private void btnMostrarImagenes_Click(object sender, EventArgs e)
    {
      if (this.txtCodigo.Text.Trim().Length > 0)
      {
        ProductoVO productoVo = new Producto().buscaImagenProducto(this.txtCodigo.Text.Trim());
        this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox1.Image = (Image) productoVo.Img1;
        this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox2.Image = (Image) productoVo.Img2;
        this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox3.Image = (Image) productoVo.Img3;
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Codigo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCodigo.Focus();
      }
    }

    private void btnPesables_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Generar un nuevo Archivo de Productos Pesables?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      string path = "c:/    /AptuSoft//PLU//plu_balanza.txt";
      if (File.Exists(path))
        File.Delete(path);
      List<ProductoVO> list = new Producto().listaPLU();
      using (StreamWriter text = File.CreateText(path))
      {
        int num1 = 1;
        foreach (ProductoVO productoVo in list)
        {
          string str = productoVo.Codigo + "\t0\t0\t" + productoVo.Codigo + "\t" + productoVo.Descripcion + "\t\t\t0\t0\t17\t0\tKg\t" + productoVo.ValorVenta1.ToString("##") + "\t0\t0\t0\t0\t0\t0\t0\t0\t0\t13\t128\t0\t0\t" + DateTime.Now.ToString() + "\t0\t0\t0\t\t0\t0\t\t0\t0\t\t0\t0\t" + num1.ToString() + "\t";
          text.WriteLine(str);
          ++num1;
        }
        text.Close();
        int num2 = (int) MessageBox.Show((num1 - 1).ToString() + " Productos Exportados ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cmbCategoria_MouseClick(object sender, MouseEventArgs e)
    {
      string text = this.cmbCategoria.Text;
      this.cargaCategorias2();
      this.cmbCategoria.Text = text;
    }

    private void cmbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
    {
      int idCat = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
      if (idCat <= 0)
        return;
      this.cargaSubCategoria(idCat);
    }

    private void cargaSubCategoria(int idCat)
    {
      this.cmbSubCategoria.DataSource = (object) null;
      this.cmbSubCategoria.DataSource = (object) new Categoria().listaSubCategoriasLista(idCat);
      this.cmbSubCategoria.ValueMember = "IdSubCategoria";
      this.cmbSubCategoria.DisplayMember = "DescripcionSubCategoria";
      this.cmbSubCategoria.SelectedValue = (object) 0;
    }

    private void txtValorVenta4_Enter(object sender, EventArgs e)
    {
      this.txtValorVenta4.BackColor = Color.PeachPuff;
    }

    private void txtValorVenta5_Enter(object sender, EventArgs e)
    {
      this.txtValorVenta5.BackColor = Color.PeachPuff;
    }

    private void txtValorVenta4_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtValorVenta5.Focus();
    }

    private void txtValorVenta5_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.txtStockMinimo.Focus();
    }

    private void txtValorVenta4_Leave(object sender, EventArgs e)
    {
      this.txtValorVenta4.BackColor = Color.White;
    }

    private void txtValorVenta5_Leave(object sender, EventArgs e)
    {
      this.txtValorVenta5.BackColor = Color.White;
    }

    private void txtValorVenta4_TextChanged(object sender, EventArgs e)
    {
        //if (this.txtValorVenta4.Text.Trim().Length != 0) { this.calculaValorVenta(); }
        //return;
      //this.calculaValorVenta();
    }

    private void txtValorVenta5_TextChanged(object sender, EventArgs e)
    {
      ///if (this.txtValorVenta5.Text.Trim().Length <= 0)
    //    return;
      //this.calculaValorVenta();
    }

    private void txtUtilidad4_Enter(object sender, EventArgs e)
    {
      this.txtUtilidad4.BackColor = Color.PeachPuff;
    }

    private void txtUtilidad5_Enter(object sender, EventArgs e)
    {
      this.txtUtilidad5.BackColor = Color.PeachPuff;
    }

    private void txtUtilidad4_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtUtilidad5_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtUtilidad4_Leave(object sender, EventArgs e)
    {
      this.txtUtilidad4.BackColor = Color.White;
    }

    private void txtUtilidad5_Leave(object sender, EventArgs e)
    {
      this.txtUtilidad5.BackColor = Color.White;
    }

    private void txtUtilidad4_TextChanged(object sender, EventArgs e)
    {
        if (this.txtUtilidad4.Text.Trim().Length == 0)
        {
            txtUtilidad4.Text = "0";
        }
        else if (txtUtilidad4.Text.Length < 0 && txtUtilidad4.Text == "0")
        {
            txtUtilidad4.Clear();
        }
        else
        {
            this.calculaValorVenta();
        }
    }

    private void txtUtilidad5_TextChanged(object sender, EventArgs e)
    {
        if (this.txtUtilidad5.Text.Trim().Length == 0)
        {
            txtUtilidad5.Text = "0";
        }
        else if (txtUtilidad5.Text.Length < 0 && txtUtilidad5.Text == "0")
        {
            txtUtilidad5.Clear();
        }
        else
        {
            this.calculaValorVenta();
        }
    }

    private void txtBodega11_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtBodega12_Enter(object sender, EventArgs e)
    {
      this.txtBodega12.BackColor = Color.PeachPuff;
    }

    private void txtBodega13_Enter(object sender, EventArgs e)
    {
      this.txtBodega13.BackColor = Color.PeachPuff;
    }

    private void txtBodega14_Enter(object sender, EventArgs e)
    {
      this.txtBodega14.BackColor = Color.PeachPuff;
    }

    private void txtBodega15_Enter(object sender, EventArgs e)
    {
      this.txtBodega15.BackColor = Color.PeachPuff;
    }

    private void txtBodega16_Enter(object sender, EventArgs e)
    {
      this.txtBodega16.BackColor = Color.PeachPuff;
    }

    private void txtBodega17_Enter(object sender, EventArgs e)
    {
      this.txtBodega17.BackColor = Color.PeachPuff;
    }

    private void txtBodega18_Enter(object sender, EventArgs e)
    {
      this.txtBodega18.BackColor = Color.PeachPuff;
    }

    private void txtBodega19_Enter(object sender, EventArgs e)
    {
      this.txtBodega19.BackColor = Color.PeachPuff;
    }

    private void txtBodega20_Enter(object sender, EventArgs e)
    {
      this.txtBodega20.BackColor = Color.PeachPuff;
    }

    private void txtBodega11_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega12_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega13_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega14_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega15_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega16_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega17_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega18_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega19_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega20_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtBodega11_Leave(object sender, EventArgs e)
    {
      this.txtBodega11.BackColor = Color.White;
    }

    private void txtBodega12_Leave(object sender, EventArgs e)
    {
      this.txtBodega12.BackColor = Color.White;
    }

    private void txtBodega13_Leave(object sender, EventArgs e)
    {
      this.txtBodega13.BackColor = Color.White;
    }

    private void txtBodega14_Leave(object sender, EventArgs e)
    {
      this.txtBodega14.BackColor = Color.White;
    }

    private void txtBodega15_Leave(object sender, EventArgs e)
    {
      this.txtBodega15.BackColor = Color.White;
    }

    private void txtBodega16_Leave(object sender, EventArgs e)
    {
      this.txtBodega16.BackColor = Color.White;
    }

    private void txtBodega17_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtBodega17_Leave(object sender, EventArgs e)
    {
      this.txtBodega17.BackColor = Color.White;
    }

    private void txtBodega18_Leave(object sender, EventArgs e)
    {
      this.txtBodega17.BackColor = Color.White;
    }

    private void txtBodega19_Leave(object sender, EventArgs e)
    {
      this.txtBodega19.BackColor = Color.White;
    }

    private void txtBodega20_Leave(object sender, EventArgs e)
    {
      this.txtBodega20.BackColor = Color.White;
    }

    private void txtBodega11_Enter(object sender, EventArgs e)
    {
      this.txtBodega11.BackColor = Color.PeachPuff;
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
