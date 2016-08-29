 
// Type: Aptusoft.frmLanzaInformeInventario
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using Aptusoft.DtsReportesTableAdapters;
using Aptusoft.Lotes;
using Aptusoft.TomaInventario.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmLanzaInformeInventario : Form
  {
    private IContainer components = (IContainer) null;
    private string categoriaNombre = "";
    private int idSubCategoria = 0;
    private string subCategoriaNombre = "";
    private int codigoProveedor = 0;
    private List<DatosVentaVO> listaMovimiento009 = new List<DatosVentaVO>();
    private Button btnBuscar;
    private Button btnSalir;
    private Label lblNombreInforme;
    private Label lblReporte;
    private GroupBox gpbBodega;
    private Label label1;
    private ComboBox cmbBodega;
    private CheckBox chkConStock;
    private GroupBox gpbCategoria;
    private ComboBox cmbCategoria;
    private Label label2;
    private GroupBox gpbProducto;
    private Label label4;
    private Label label3;
    private TextBox txtDescripcion;
    private TextBox txtCodigo;
    private GroupBox gpbFecha;
    private DateTimePicker dtpHasta;
    private DateTimePicker dtpDesde;
    private Label label5;
    private Label label6;
    private GroupBox gpbProveedor;
    private Button btnBuscaProveedor;
    private TextBox txtRazonSocial;
    private TextBox txtDigito;
    private TextBox txtRut;
    private Label label7;
    private Label label8;
    private TicketTableAdapter ticketTableAdapter1;
    private GroupBox gpbSubCategoria;
    private Label label9;
    private ComboBox cmbSubCategoria;
    private string codigoInforme;
    private string filtro;
    private string desde;
    private string hasta;
    private string archivo;
    private int bodega;
    private int categoria;
    private frmLanzaInformeInventario intance;
    private string codigoProducto;

    public frmLanzaInformeInventario()
    {
      this.InitializeComponent();
      this.intance = this;
    }

    public frmLanzaInformeInventario(string informe, string codInforme)
    {
      this.InitializeComponent();
      this.lblNombreInforme.Text = informe;
      this.lblReporte.Text = codInforme;
      this.codigoInforme = codInforme;
      this.intance = this;
      this.iniciaFormulario(codInforme);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombreInforme = new System.Windows.Forms.Label();
            this.lblReporte = new System.Windows.Forms.Label();
            this.gpbBodega = new System.Windows.Forms.GroupBox();
            this.chkConStock = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.gpbProducto = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbProveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscaProveedor = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ticketTableAdapter1 = new Aptusoft.DtsReportesTableAdapters.TicketTableAdapter();
            this.gpbSubCategoria = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.gpbBodega.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            this.gpbProducto.SuspendLayout();
            this.gpbFecha.SuspendLayout();
            this.gpbProveedor.SuspendLayout();
            this.gpbSubCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(453, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 50);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(534, 40);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombreInforme
            // 
            this.lblNombreInforme.AutoSize = true;
            this.lblNombreInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInforme.Location = new System.Drawing.Point(9, 17);
            this.lblNombreInforme.Name = "lblNombreInforme";
            this.lblNombreInforme.Size = new System.Drawing.Size(59, 16);
            this.lblNombreInforme.TabIndex = 5;
            this.lblNombreInforme.Text = "informe";
            // 
            // lblReporte
            // 
            this.lblReporte.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.Color.Silver;
            this.lblReporte.Location = new System.Drawing.Point(509, 182);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(100, 15);
            this.lblReporte.TabIndex = 8;
            this.lblReporte.Text = "reporte";
            this.lblReporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpbBodega
            // 
            this.gpbBodega.Controls.Add(this.chkConStock);
            this.gpbBodega.Controls.Add(this.label1);
            this.gpbBodega.Controls.Add(this.cmbBodega);
            this.gpbBodega.Location = new System.Drawing.Point(12, 36);
            this.gpbBodega.Name = "gpbBodega";
            this.gpbBodega.Size = new System.Drawing.Size(182, 82);
            this.gpbBodega.TabIndex = 9;
            this.gpbBodega.TabStop = false;
            // 
            // chkConStock
            // 
            this.chkConStock.AutoSize = true;
            this.chkConStock.Location = new System.Drawing.Point(6, 59);
            this.chkConStock.Name = "chkConStock";
            this.chkConStock.Size = new System.Drawing.Size(142, 17);
            this.chkConStock.TabIndex = 10;
            this.chkConStock.Text = "Solo Articulos con Stock";
            this.chkConStock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "BODEGA";
            // 
            // cmbBodega
            // 
            this.cmbBodega.BackColor = System.Drawing.Color.White;
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(6, 29);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(170, 21);
            this.cmbBodega.TabIndex = 10;
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.label2);
            this.gpbCategoria.Controls.Add(this.cmbCategoria);
            this.gpbCategoria.Location = new System.Drawing.Point(12, 114);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(211, 67);
            this.gpbCategoria.TabIndex = 10;
            this.gpbCategoria.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categorias";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(6, 31);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(195, 21);
            this.cmbCategoria.TabIndex = 11;
            this.cmbCategoria.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoria_SelectionChangeCommitted);
            // 
            // gpbProducto
            // 
            this.gpbProducto.Controls.Add(this.label4);
            this.gpbProducto.Controls.Add(this.label3);
            this.gpbProducto.Controls.Add(this.txtDescripcion);
            this.gpbProducto.Controls.Add(this.txtCodigo);
            this.gpbProducto.Location = new System.Drawing.Point(12, 114);
            this.gpbProducto.Name = "gpbProducto";
            this.gpbProducto.Size = new System.Drawing.Size(433, 67);
            this.gpbProducto.TabIndex = 11;
            this.gpbProducto.TabStop = false;
            this.gpbProducto.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESCRIPCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CODIGO";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(119, 31);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(298, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.dtpHasta);
            this.gpbFecha.Controls.Add(this.dtpDesde);
            this.gpbFecha.Controls.Add(this.label5);
            this.gpbFecha.Controls.Add(this.label6);
            this.gpbFecha.Location = new System.Drawing.Point(200, 36);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(245, 82);
            this.gpbFecha.TabIndex = 12;
            this.gpbFecha.TabStop = false;
            this.gpbFecha.Visible = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(129, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(104, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(6, 29);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(104, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "HASTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "DESDE";
            // 
            // gpbProveedor
            // 
            this.gpbProveedor.Controls.Add(this.btnBuscaProveedor);
            this.gpbProveedor.Controls.Add(this.txtRazonSocial);
            this.gpbProveedor.Controls.Add(this.txtDigito);
            this.gpbProveedor.Controls.Add(this.txtRut);
            this.gpbProveedor.Controls.Add(this.label7);
            this.gpbProveedor.Controls.Add(this.label8);
            this.gpbProveedor.Location = new System.Drawing.Point(12, 115);
            this.gpbProveedor.Name = "gpbProveedor";
            this.gpbProveedor.Size = new System.Drawing.Size(597, 65);
            this.gpbProveedor.TabIndex = 13;
            this.gpbProveedor.TabStop = false;
            this.gpbProveedor.Visible = false;
            // 
            // btnBuscaProveedor
            // 
            this.btnBuscaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaProveedor.Location = new System.Drawing.Point(425, 21);
            this.btnBuscaProveedor.Name = "btnBuscaProveedor";
            this.btnBuscaProveedor.Size = new System.Drawing.Size(139, 33);
            this.btnBuscaProveedor.TabIndex = 33;
            this.btnBuscaProveedor.Text = "Buscar Proveedor";
            this.btnBuscaProveedor.UseVisualStyleBackColor = true;
            this.btnBuscaProveedor.Click += new System.EventHandler(this.btnBuscaProveedor_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(130, 29);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(267, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(93, 29);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(28, 20);
            this.txtDigito.TabIndex = 1;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(6, 29);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(84, 20);
            this.txtRut.TabIndex = 0;
            this.txtRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRut_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "RAZON SOCIAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "RUT";
            // 
            // ticketTableAdapter1
            // 
            this.ticketTableAdapter1.ClearBeforeFill = true;
            // 
            // gpbSubCategoria
            // 
            this.gpbSubCategoria.Controls.Add(this.label9);
            this.gpbSubCategoria.Controls.Add(this.cmbSubCategoria);
            this.gpbSubCategoria.Location = new System.Drawing.Point(225, 114);
            this.gpbSubCategoria.Name = "gpbSubCategoria";
            this.gpbSubCategoria.Size = new System.Drawing.Size(211, 67);
            this.gpbSubCategoria.TabIndex = 14;
            this.gpbSubCategoria.TabStop = false;
            this.gpbSubCategoria.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "SubCategorias";
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Location = new System.Drawing.Point(6, 31);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(195, 21);
            this.cmbSubCategoria.TabIndex = 11;
            // 
            // frmLanzaInformeInventario
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(621, 206);
            this.Controls.Add(this.gpbBodega);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbProveedor);
            this.Controls.Add(this.gpbProducto);
            this.Controls.Add(this.gpbCategoria);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.lblNombreInforme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpbSubCategoria);
            this.KeyPreview = true;
            this.Name = "frmLanzaInformeInventario";
            this.Text = "Lanzador de Informes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLanzaInformeInventario_KeyDown);
            this.gpbBodega.ResumeLayout(false);
            this.gpbBodega.PerformLayout();
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            this.gpbProducto.ResumeLayout(false);
            this.gpbProducto.PerformLayout();
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbProveedor.ResumeLayout(false);
            this.gpbProveedor.PerformLayout();
            this.gpbSubCategoria.ResumeLayout(false);
            this.gpbSubCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private bool validador()
    {
      return true;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if (!this.validador())
        return;
      this.lanzaInforme();
    }

    private void cargaCategorias()
    {
      List<CategoriaVO> list = new Categoria().listaCategorias();
      list[0].Descripcion = "TODAS LAS CATEGORIAS";
      this.cmbCategoria.DataSource = (object) list;
      this.cmbCategoria.DisplayMember = "Descripcion";
      this.cmbCategoria.ValueMember = "IdCategoria";
      this.cmbCategoria.SelectedValue = (object) 0;
    }

    private void cargaSubCategoria(int idCat)
    {
      List<CategoriaVO> list = new Categoria().listaSubCategoriasLista(idCat);
      foreach (CategoriaVO categoriaVo in list)
      {
        if (categoriaVo.IdSubCategoria == 0)
          categoriaVo.DescripcionSubCategoria = "TODAS LAS SUBCATEGORIAS";
      }
      this.cmbSubCategoria.DataSource = (object) null;
      this.cmbSubCategoria.DataSource = (object) list;
      this.cmbSubCategoria.ValueMember = "IdSubCategoria";
      this.cmbSubCategoria.DisplayMember = "DescripcionSubCategoria";
      this.cmbSubCategoria.SelectedValue = (object) 0;
    }

    private void cargaBodegas()
    {
      this.cmbBodega.DataSource = (object) new CargaMaestros().cargaBodegaUsuario();
      this.cmbBodega.ValueMember = "IdBodega";
      this.cmbBodega.DisplayMember = "NombreBodega";
    }

    private void cargaBodegasSinTodas()
    {
      List<BodegaVO> list = new CargaMaestros().cargaBodegaUsuario();
      list.RemoveAt(20);
      this.cmbBodega.DataSource = (object) list;
      this.cmbBodega.ValueMember = "IdBodega";
      this.cmbBodega.DisplayMember = "NombreBodega";
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.label3.Text != "LOTE" && this.txtCodigo.Text.Trim().Length > 0)
        this.buscaCodigo(this.txtCodigo.Text.Trim());
    }

    private void frmLanzaInformeInventario_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.F4)
        return;
      this.txtCodigo.Focus();
      int num = (int) new frmBuscaProductos("informe_productos", ref this.intance).ShowDialog();
      this.btnBuscar.Focus();
    }

    public void buscaCodigo(string cod)
    {
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
      if (productoVo.Codigo == null)
      {
        int num = (int) MessageBox.Show("El Producto No Existe");
        this.txtCodigo.Focus();
      }
      else
      {
        this.codigoProducto = productoVo.Codigo;
        this.txtCodigo.Text = productoVo.Codigo;
        this.txtDescripcion.Text = productoVo.Descripcion;
      }
    }

    private void iniciaFormulario(string codInf)
    {
      this.cargaBodegas();
      this.cargaCategorias();
      if (this.codigoInforme.Equals("INVENTARIO001"))
      {
        this.gpbBodega.Visible = true;
        this.gpbCategoria.Visible = true;
        this.gpbSubCategoria.Visible = true;
      } if (this.codigoInforme.Equals("INVENTARIO027"))
      {
          this.gpbBodega.Visible = true;
          this.gpbCategoria.Visible = false;
          this.gpbSubCategoria.Visible = false;
      }
      if (this.codigoInforme.Equals("INVENTARIO012"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = true;
        this.gpbCategoria.Visible = true;
        this.gpbSubCategoria.Visible = true;
      }
      if (this.codigoInforme.Equals("INVENTARIO013"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = false;
        this.gpbCategoria.Visible = true;
        this.gpbSubCategoria.Visible = true;
      }
      if (this.codigoInforme.Equals("INVENTARIO014"))
      {
        this.gpbBodega.Visible = true;
        this.gpbCategoria.Visible = true;
        this.gpbSubCategoria.Visible = true;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("INVENTARIO025"))
      {
        this.gpbBodega.Visible = false;
        this.gpbBodega.Enabled = false;
        this.gpbCategoria.Visible = true;
        this.gpbSubCategoria.Visible = true;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO001"))
      {
        this.cargaBodegasSinTodas();
        this.gpbBodega.Visible = true;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = true;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO002"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = true;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = false;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO003"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = true;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = true;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO004"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = true;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO005"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = false;
        this.chkConStock.Enabled = false;
        this.gpbProveedor.Visible = true;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO009"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = true;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO010"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = true;
        this.cmbBodega.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = true;
        this.gpbSubCategoria.Visible = true;
        this.chkConStock.Enabled = false;
        this.chkConStock.Visible = false;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO011"))
      {
        this.gpbBodega.Visible = false;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = false;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = true;
        this.chkConStock.Enabled = false;
        this.label3.Text = "LOTE";
        this.txtDescripcion.Visible = false;
      }
      if (this.codigoInforme.Equals("MOVIMIENTO012"))
      {
        this.gpbBodega.Visible = false;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = true;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("KIT001"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = false;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = true;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("KIT002"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = false;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("TraspasoInterno001"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = false;
        this.chkConStock.Enabled = false;
      }
      if (this.codigoInforme.Equals("TraspasoInterno002"))
      {
        this.gpbBodega.Visible = true;
        this.gpbBodega.Enabled = false;
        this.gpbFecha.Visible = true;
        this.gpbCategoria.Visible = false;
        this.gpbSubCategoria.Visible = false;
        this.gpbProducto.Visible = false;
        this.chkConStock.Enabled = false;
      }
      if (!this.codigoInforme.Equals("TOMAINVENTARIO001"))
        return;
      this.cargaBodegas();
      this.gpbBodega.Visible = true;
      this.gpbFecha.Visible = true;
      this.gpbCategoria.Visible = false;
    }

    private void lanzaInforme()
    {
      Producto producto = new Producto();
      DataTable dataTable = new DataTable();
      string bod1 = "0";
      this.codigoProducto = txtCodigo.Text.ToString();
      if (this.codigoInforme.Equals("INVENTARIO001"))
      {
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        this.categoria = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
        this.categoriaNombre = this.cmbCategoria.Text;
        if (this.cmbSubCategoria.Items.Count > 0)
        {
          this.idSubCategoria = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
          this.subCategoriaNombre = this.cmbSubCategoria.Text;
        }
        else
          this.idSubCategoria = 0;
        bool @checked = this.chkConStock.Checked;
        switch (this.bodega)
        {
          case 0:
            this.archivo = "Inventario011.rpt";
            this.filtro = @checked ? "Bodega1 > 0 OR Bodega2 > 0 OR Bodega3 > 0 OR Bodega4 > 0 OR Bodega5 > 0 OR Bodega6 > 0 OR Bodega7 > 0 OR Bodega8 > 0 OR Bodega9 > 0 OR Bodega9 > 0 OR Bodega10 > 0" : "Descripcion != ''";
            break;
          case 1:
            this.archivo = "Inventario001.rpt";
            bod1 = "1";
            this.filtro = @checked ? "Bodega1 > 0" : "Descripcion != ''";
            break;
          case 2:
            this.archivo = "Inventario001.rpt";
            bod1 = "2";
            this.filtro = @checked ? "Bodega2 > 0" : "Descripcion != ''";
            break;
          case 3:
            this.archivo = "Inventario001.rpt";
            bod1 = "3";
            this.filtro = @checked ? "Bodega3 > 0" : "Descripcion != ''";
            break;
          case 4:
            this.archivo = "Inventario001.rpt";
            bod1 = "4";
            this.filtro = @checked ? "Bodega4 > 0" : "Descripcion != ''";
            break;
          case 5:
            this.archivo = "Inventario001.rpt";
            bod1 = "5";
            this.filtro = @checked ? "Bodega5 > 0" : "Descripcion != ''";
            break;
          case 6:
            this.archivo = "Inventario001.rpt";
            bod1 = "6";
            this.filtro = @checked ? "Bodega6 > 0" : "Descripcion != ''";
            break;
          case 7:
            this.archivo = "Inventario001.rpt";
            bod1 = "7";
            this.filtro = @checked ? "Bodega7 > 0" : "Descripcion != ''";
            break;
          case 8:
            this.archivo = "Inventario001.rpt";
            bod1 = "8";
            this.filtro = @checked ? "Bodega8 > 0" : "Descripcion != ''";
            break;
          case 9:
            this.archivo = "Inventario001.rpt";
            bod1 = "9";
            this.filtro = @checked ? "Bodega9 > 0" : "Descripcion != ''";
            break;
          case 10:
            this.archivo = "Inventario001.rpt";
            bod1 = "10";
            this.filtro = @checked ? "Bodega10 > 0" : "Descripcion != ''";
            break;
          case 11:
            this.archivo = "Inventario001.rpt";
            bod1 = "11";
            this.filtro = @checked ? "Bodega11 > 0" : "Descripcion != ''";
            break;
          case 12:
            this.archivo = "Inventario001.rpt";
            bod1 = "12";
            this.filtro = @checked ? "Bodega12 > 0" : "Descripcion != ''";
            break;
          case 13:
            this.archivo = "Inventario001.rpt";
            bod1 = "13";
            this.filtro = @checked ? "Bodega13 > 0" : "Descripcion != ''";
            break;
          case 14:
            this.archivo = "Inventario001.rpt";
            bod1 = "14";
            this.filtro = @checked ? "Bodega14 > 0" : "Descripcion != ''";
            break;
          case 15:
            this.archivo = "Inventario001.rpt";
            bod1 = "15";
            this.filtro = @checked ? "Bodega15 > 0" : "Descripcion != ''";
            break;
          case 16:
            this.archivo = "Inventario001.rpt";
            bod1 = "16";
            this.filtro = @checked ? "Bodega16 > 0" : "Descripcion != ''";
            break;
          case 17:
            this.archivo = "Inventario001.rpt";
            bod1 = "17";
            this.filtro = @checked ? "Bodega17 > 0" : "Descripcion != ''";
            break;
          case 18:
            this.archivo = "Inventario001.rpt";
            bod1 = "18";
            this.filtro = @checked ? "Bodega18 > 0" : "Descripcion != ''";
            break;
          case 19:
            this.archivo = "Inventario001.rpt";
            bod1 = "19";
            this.filtro = @checked ? "Bodega19 > 0" : "Descripcion != ''";
            break;
          case 20:
            this.archivo = "Inventario001.rpt";
            bod1 = "20";
            this.filtro = @checked ? "Bodega20 > 0" : "Descripcion != ''";
            break;
        }
        if (this.categoriaNombre != "TODAS LAS CATEGORIAS")
          this.filtro = this.filtro + " AND Categoria = '" + this.categoriaNombre + "'";
        if (this.idSubCategoria > 0)
          this.filtro = this.filtro + " AND SubCategoria = '" + this.subCategoriaNombre + "'";
        dataTable = producto.productoInforme(this.filtro, bod1);
      }
      if (this.codigoInforme.Equals("INVENTARIO012"))
      {
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        bool @checked = this.chkConStock.Checked;
        switch (this.bodega)
        {
          case 0:
            this.filtro = @checked ? "Bodega1 > 0 OR Bodega2 > 0 OR Bodega3 > 0 OR Bodega4 > 0 OR Bodega5 > 0 OR Bodega6 > 0 OR Bodega7 > 0 OR Bodega8 > 0 AND Bodega9 > 0 OR Bodega9 > 0 OR Bodega10 > 0" : "Descripcion != ''";
            break;
          case 1:
            this.filtro = @checked ? "Bodega1 > 0" : "Descripcion != ''";
            break;
          case 2:
            this.filtro = @checked ? "Bodega2 > 0" : "Descripcion != ''";
            break;
          case 3:
            this.filtro = @checked ? "Bodega3 > 0" : "Descripcion != ''";
            break;
          case 4:
            this.filtro = @checked ? "Bodega4 > 0" : "Descripcion != ''";
            break;
          case 5:
            this.filtro = @checked ? "Bodega5 > 0" : "Descripcion != ''";
            break;
          case 6:
            this.filtro = @checked ? "Bodega6 > 0" : "Descripcion != ''";
            break;
          case 7:
            this.filtro = @checked ? "Bodega7 > 0" : "Descripcion != ''";
            break;
          case 8:
            this.filtro = @checked ? "Bodega8 > 0" : "Descripcion != ''";
            break;
          case 9:
            this.filtro = @checked ? "Bodega9 > 0" : "Descripcion != ''";
            break;
          case 10:
            this.filtro = @checked ? "Bodega10 > 0" : "Descripcion != ''";
            break;
          case 11:
            this.filtro = @checked ? "Bodega11 > 0" : "Descripcion != ''";
            break;
          case 12:
            this.filtro = @checked ? "Bodega12 > 0" : "Descripcion != ''";
            break;
          case 13:
            this.filtro = @checked ? "Bodega13 > 0" : "Descripcion != ''";
            break;
          case 14:
            this.filtro = @checked ? "Bodega14 > 0" : "Descripcion != ''";
            break;
          case 15:
            this.filtro = @checked ? "Bodega15 > 0" : "Descripcion != ''";
            break;
          case 16:
            this.filtro = @checked ? "Bodega16 > 0" : "Descripcion != ''";
            break;
          case 17:
            this.filtro = @checked ? "Bodega17 > 0" : "Descripcion != ''";
            break;
          case 18:
            this.filtro = @checked ? "Bodega18 > 0" : "Descripcion != ''";
            break;
          case 19:
            this.filtro = @checked ? "Bodega19 > 0" : "Descripcion != ''";
            break;
          case 20:
            this.filtro = @checked ? "Bodega20 > 0" : "Descripcion != ''";
            break;
        }
        this.categoria = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
        this.categoriaNombre = this.cmbCategoria.Text;
        this.archivo = "Inventario012.rpt";
        this.filtro += " AND codigo is not null";
        if (this.cmbSubCategoria.Items.Count > 0)
        {
          this.idSubCategoria = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
          this.subCategoriaNombre = this.cmbSubCategoria.Text;
        }
        else
          this.idSubCategoria = 0;
        if (this.categoriaNombre != "TODAS LAS CATEGORIAS")
          this.filtro = this.filtro + " AND Categoria = '" + this.categoriaNombre + "'";
        if (this.idSubCategoria > 0)
          this.filtro = this.filtro + " AND SubCategoria = '" + this.subCategoriaNombre + "'";
        string bod2 = this.bodega.ToString("N0") ?? "";
        dataTable = producto.productoInforme(this.filtro, bod2);
      }
      if (this.codigoInforme.Equals("INVENTARIO013"))
      {
        this.categoria = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
        this.categoriaNombre = this.cmbCategoria.Text;
        this.archivo = "Inventario013.rpt";
        this.filtro = "codigo is not null";
        if (this.cmbSubCategoria.Items.Count > 0)
        {
          this.idSubCategoria = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
          this.subCategoriaNombre = this.cmbSubCategoria.Text;
        }
        else
          this.idSubCategoria = 0;
        if (this.categoriaNombre != "TODAS LAS CATEGORIAS")
          this.filtro = this.filtro + " AND Categoria = '" + this.categoriaNombre + "'";
        if (this.idSubCategoria > 0)
          this.filtro = this.filtro + " AND SubCategoria = '" + this.subCategoriaNombre + "'";
        dataTable = producto.productoInforme(this.filtro, "0");
      }
      if (this.codigoInforme.Equals("INVENTARIO014"))
      {
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        this.categoria = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
        this.categoriaNombre = this.cmbCategoria.Text;
        string bod2 = "0";
        switch (this.bodega)
        {
          case 0:
            this.archivo = "Inventario024.rpt";
            this.filtro = "StockMinimo >= (Bodega1+Bodega2+Bodega3+Bodega4+Bodega5+Bodega6+Bodega7+Bodega8+Bodega9+Bodega10)";
            break;
          case 1:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega1";
            bod2 = "1";
            break;
          case 2:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega2";
            bod2 = "2";
            break;
          case 3:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega3";
            bod2 = "3";
            break;
          case 4:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega4";
            bod2 = "4";
            break;
          case 5:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega5";
            bod2 = "5";
            break;
          case 6:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega6";
            bod2 = "6";
            break;
          case 7:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega7";
            bod2 = "7";
            break;
          case 8:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega8";
            bod2 = "8";
            break;
          case 9:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega9";
            bod2 = "9";
            break;
          case 10:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega10";
            bod2 = "10";
            break;
          case 11:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega11";
            bod2 = "11";
            break;
          case 12:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega12";
            bod2 = "12";
            break;
          case 13:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega13";
            bod2 = "13";
            break;
          case 14:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega14";
            bod2 = "14";
            break;
          case 15:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega15";
            bod2 = "5";
            break;
          case 16:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega16";
            bod2 = "16";
            break;
          case 17:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega17";
            bod2 = "17";
            break;
          case 18:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega18";
            bod2 = "18";
            break;
          case 19:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega19";
            bod2 = "19";
            break;
          case 20:
            this.archivo = "Inventario014.rpt";
            this.filtro = "StockMinimo >= Bodega20";
            bod2 = "20";
            break;
        }
        if (this.cmbSubCategoria.Items.Count > 0)
        {
          this.idSubCategoria = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
          this.subCategoriaNombre = this.cmbSubCategoria.Text;
        }
        else
          this.idSubCategoria = 0;
        if (this.categoriaNombre != "TODAS LAS CATEGORIAS")
          this.filtro = this.filtro + " AND Categoria = '" + this.categoriaNombre + "'";
        if (this.idSubCategoria > 0)
          this.filtro = this.filtro + " AND SubCategoria = '" + this.subCategoriaNombre + "'";
        dataTable = producto.productoInforme(this.filtro, bod2);
      }
      if (this.codigoInforme.Equals("INVENTARIO025"))
      {
        this.categoria = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
        this.categoriaNombre = this.cmbCategoria.Text;
        this.archivo = "Inventario025.rpt";
        this.filtro = "1";
        if (filtro.ToString() == "1")
        {
            this.filtro += " order by descripcion asc";
        }
        if (this.cmbSubCategoria.Items.Count > 0)
        {
          this.idSubCategoria = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
          this.subCategoriaNombre = this.cmbSubCategoria.Text;
           
        }
        else
          this.idSubCategoria = 0;
        if (this.categoriaNombre != "TODAS LAS CATEGORIAS")
            this.filtro = this.filtro + " AND Categoria = '" + this.categoriaNombre + "' order by descripcion asc";
        if (this.idSubCategoria > 0)
            this.filtro = this.filtro + " AND SubCategoria = '" + this.subCategoriaNombre + "' order by descripcion asc";
        dataTable = producto.productoInforme(this.filtro, "0");
      }
        if (this.codigoInforme.Equals("INVENTARIO027"))
      {
          this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.categoria = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
          this.categoriaNombre = this.cmbCategoria.Text;
          if (this.cmbSubCategoria.Items.Count > 0)
          {
              this.idSubCategoria = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
              this.subCategoriaNombre = this.cmbSubCategoria.Text;
          }
          else
              this.idSubCategoria = 0;
          bool @checked = this.chkConStock.Checked;
          switch (this.bodega)
          {
              case 0:
                  this.archivo = "Inventario000.rpt";
                  this.filtro = @checked ? "Bodega1 > 0 OR Bodega2 > 0 OR Bodega3 > 0 OR Bodega4 > 0 OR Bodega5 > 0 OR Bodega6 > 0 OR Bodega7 > 0 OR Bodega8 > 0 OR Bodega9 > 0 OR Bodega9 > 0 OR Bodega10 > 0" : "Descripcion != ''";
                  break;
              case 1:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "1";
                  this.filtro = "Bodega1 > 0";
                  break;
              case 2:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "2";
                  this.filtro = "Bodega2 > 0";
                  break;
              case 3:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "3";
                  this.filtro ="Bodega3 > 0";
                  break;
              case 4:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "4";
                  this.filtro ="Bodega4 > 0";
                  break;
              case 5:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "5";
                  this.filtro = "Bodega5 > 0" ;
                  break;
              case 6:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "6";
                  this.filtro ="Bodega6 > 0" ;
                  break;
              case 7:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "7";
                  this.filtro ="Bodega7 > 0";
                  break;
              case 8:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "8";
                  this.filtro = "Bodega8 > 0";
                  break;
              case 9:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "9";
                  this.filtro = "Bodega9 > 0";
                  break;
              case 10:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "10";
                  this.filtro = "Bodega10 > 0";
                  break;
              case 11:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "11";
                  this.filtro ="Bodega11 > 0";
                  break;
              case 12:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "12";
                  this.filtro ="Bodega12 > 0";
                  break;
              case 13:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "13";
                  this.filtro =  "Bodega13 > 0" ;
                  break;
              case 14:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "14";
                  this.filtro = "Bodega14 > 0";
                  break;
              case 15:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "15";
                  this.filtro = "Bodega15 > 0" ;
                  break;
              case 16:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "16";
                  this.filtro = "Bodega16 > 0";
                  break;
              case 17:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "17";
                  this.filtro = "Bodega17 > 0" ;
                  break;
              case 18:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "18";
                  this.filtro = "Bodega18 > 0";
                  break;
              case 19:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "19";
                  this.filtro = "Bodega19 > 0";
                  break;
              case 20:
                  this.archivo = "Inventario027.rpt";
                  bod1 = "20";
                  this.filtro = "Bodega20 > 0";
                  break;
          }
          //if (this.categoriaNombre != "TODAS LAS CATEGORIAS")
          //    this.filtro = this.filtro + " AND Categoria = '" + this.categoriaNombre + "'";
          //if (this.idSubCategoria > 0)
          //    this.filtro = this.filtro + " AND SubCategoria = '" + this.subCategoriaNombre + "'";
          dataTable = producto.productoInforme(this.filtro, bod1);
      }
      DateTime dateTime=DateTime.Now;
      if (this.codigoInforme.Equals("MOVIMIENTO001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        InventarioGeneral inventarioGeneral = new InventarioGeneral();
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND codigo='" + this.codigoProducto + "' AND bodega='" + this.bodega + "'";
        this.archivo = "Movimiento001.rpt";
        dataTable = inventarioGeneral.movimientoProductoInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("MOVIMIENTO002"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        InventarioGeneral inventarioGeneral = new InventarioGeneral();
        if (this.bodega > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.desde.ToString() + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta.ToString() + "' AND bodega='" + this.bodega.ToString() + "'";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.desde.ToString() + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta.ToString() + "'";
        this.archivo = "Movimiento002.rpt";
        dataTable = inventarioGeneral.rankingProductoInforme(this.filtro, this.bodega);
      }
      string str1;
      if (this.codigoInforme.Equals("MOVIMIENTO003"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dtpDesde.Value.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dtpHasta.Value.ToString("yyyy-MM-dd");
        str1 = this.cmbBodega.SelectedValue.ToString();
        string str2 = !(this.cmbBodega.SelectedValue.ToString() == "0") ? "bodega='" + this.cmbBodega.SelectedValue.ToString() + "'" : "bodega > '0'";
        InventarioGeneral inventarioGeneral = new InventarioGeneral();
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND codigo='" + this.codigoProducto + "' AND " + str2;
        this.archivo = "Movimiento003.rpt";
        dataTable = inventarioGeneral.detalleVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("MOVIMIENTO004"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        str1 = this.cmbBodega.SelectedValue.ToString();
        string str2 = !(this.cmbBodega.SelectedValue.ToString() == "0") ? "bodega='" + this.cmbBodega.SelectedValue.ToString() + "'" : "bodega > '0'";
        InventarioGeneral inventarioGeneral = new InventarioGeneral();
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND codigo='" + this.codigoProducto + "' AND " + str2;
        this.archivo = "Movimiento004.rpt";
        dataTable = inventarioGeneral.detalleCompraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("MOVIMIENTO005"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        InventarioGeneral inventarioGeneral = new InventarioGeneral();
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idProveedor='" + this.codigoProveedor.ToString() + "'";
        this.archivo = "Movimiento005.rpt";
        dataTable = inventarioGeneral.detalleCompraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("MOVIMIENTO009"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        InventarioGeneral inventarioGeneral = new InventarioGeneral();
        this.filtro = "DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= '" + this.hasta + "' AND codigo='" + this.codigoProducto + "' ";
        this.archivo = "Movimiento009.rpt";
        this.listaMovimiento009 = inventarioGeneral.kardex(this.filtro, true);
      }
      if (this.codigoInforme.Equals("MOVIMIENTO010"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        this.categoria = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
        this.categoriaNombre = this.cmbCategoria.Text;
        if (this.cmbSubCategoria.Items.Count > 0)
        {
          this.idSubCategoria = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
          this.subCategoriaNombre = this.cmbSubCategoria.Text;
        }
        else
          this.idSubCategoria = 0;
        InventarioGeneral inventarioGeneral = new InventarioGeneral();
        this.filtro = "DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= '" + this.hasta + "' ";
        if (this.bodega > 0)
          this.filtro = string.Concat(new object[4]
          {
            (object) this.filtro,
            (object) " AND bodega = '",
            (object) this.bodega,
            (object) "'"
          });
        if (this.categoriaNombre != "TODAS LAS CATEGORIAS")
          this.filtro = this.filtro + " AND Categoria = '" + this.categoriaNombre + "'";
        if (this.idSubCategoria > 0)
          this.filtro = this.filtro + " AND SubCategoria = '" + this.subCategoriaNombre + "'";
        this.archivo = "Movimiento010.rpt";
        dataTable = inventarioGeneral.entradaStockBodega(this.filtro);
      }
      InventarioGeneral inventarioGeneral1;
      if (this.codigoInforme.Equals("MOVIMIENTO011"))
      {
        this.codigoProducto = this.txtCodigo.Text;
        inventarioGeneral1 = new InventarioGeneral();
        this.filtro = " l.lote='" + this.codigoProducto + "' ";
        this.archivo = "Movimiento011.rpt";
        dataTable = new Lote().InformePorLote(this.filtro);
      }
      if (this.codigoInforme.Equals("MOVIMIENTO012"))
      {
        this.codigoProducto = this.txtCodigo.Text;
        inventarioGeneral1 = new InventarioGeneral();
        this.filtro = " l.codigoProducto='" + this.codigoProducto + "' ";
        this.archivo = "Movimiento011.rpt";
        dataTable = new Lote().InformePorLote(this.filtro);
      }
      if (this.codigoInforme.Equals("KIT001"))
      {
        Kit kit = new Kit();
        this.filtro = "codigoProductoKit='" + this.codigoProducto + "'";
        this.archivo = "Kit001.rpt";
        dataTable = kit.kitInforme(this.filtro);
        for (int index = 0; index < dataTable.Rows.Count; ++index)
          dataTable.Rows[index]["descripcionKit"] = (object) this.txtDescripcion.Text.Trim();
      }
      if (this.codigoInforme.Equals("KIT002"))
      {
        ArmaKit armaKit = new ArmaKit();
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        inventarioGeneral1 = new InventarioGeneral();
        this.filtro = "DATE_FORMAT(fechaIngresoKit, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaIngresoKit, '%Y-%m-%d') <= '" + this.hasta + "'";
        this.archivo = "Kit002.rpt";
        dataTable = armaKit.armaKitInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("TraspasoInterno001"))
      {
        Traspaso traspaso = new Traspaso();
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "'";
        this.archivo = "traspasoInterno001.rpt";
        dataTable = traspaso.traspasoInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("TraspasoInterno002"))
      {
        Traspaso traspaso = new Traspaso();
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "'";
        this.archivo = "traspasoInterno002.rpt";
        dataTable = traspaso.traspasoInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("TOMAINVENTARIO001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fecha, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fecha, '%Y-%m-%d') <= '" + this.hasta + "' " + (this.bodega > 0 ? " AND toma_inventario.bodega='" + (object) this.bodega + "'" : "");
        this.archivo = "tomainventario001.rpt";
        dataTable = new TomaInventarioClass().informeTomaInventario(this.filtro);
      }
      try
      {
        ReportDocument rpt = new ReportDocument();
        rpt.Load("C:\\AptuSoft\\reportes\\" + this.archivo);
        if (this.codigoInforme.Equals("MOVIMIENTO009"))
          rpt.SetDataSource((IEnumerable) this.listaMovimiento009);
        else
          rpt.SetDataSource(dataTable);
        new frmVisualizadorReportes(rpt).Show();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
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
      Cliente cliente = new Cliente();
      ArrayList arrayList2 = new Proveedor().buscaRutProveedor(this.txtRut.Text.Trim());
      if (arrayList2.Count != 1)
        return;
      foreach (ClienteVO clienteVo in arrayList2)
        this.buscaProveedorCodigo(clienteVo.Codigo);
      this.btnBuscar.Focus();
    }

    public void buscaProveedorCodigo(int cod)
    {
      ClienteVO clienteVo = new Proveedor().buscaCodigoProveedor(cod);
      this.codigoProveedor = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.btnBuscar.Focus();
    }

    private void btnBuscaProveedor_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaProveedor(ref this.intance, "informe_inventario").ShowDialog();
    }

    private void txtRut_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtDigito.Focus();
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
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtRut.Focus();
      }
    }

    private void cmbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
    {
      int idCat = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
      if (idCat > 0)
        this.cargaSubCategoria(idCat);
      else
        this.cmbSubCategoria.DataSource = (object) null;
    }
  }
}
