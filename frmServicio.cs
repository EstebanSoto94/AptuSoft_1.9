 
// Type: Aptusoft.frmServicio
 
 
// version 1.8.0

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmServicio : Form
  {
    private IContainer components = (IContainer) null;
    private Decimal _iva = new Decimal(0);
    private Decimal _totalNeto = new Decimal(0);
    private Decimal _totalIva = new Decimal(0);
    private string _usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
    private ServicioVO seVOModulo = new ServicioVO();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private GroupBox groupBox1;
    private DateTimePicker dtpIngreso;
    private DateTimePicker dtpVencimiento;
    private TextBox txtFolio;
    private TextBox txtDigito;
    private TextBox txtRut;
    private TextBox txtRazonSocial;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button btnBuscaProveedor;
    private GroupBox groupBox2;
    private TextBox txtTotal;
    private GroupBox groupBox3;
    private Label label7;
    private ComboBox cmbMedioPago;
    private Label label6;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnModificar;
    private Panel pnlBuscaProveedorDes;
    private DataGridView dgvBuscaProveedor;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private DataGridView dgvDatosVenta;
    private Label label8;
    private DateTimePicker dtpHasta;
    private Label label9;
    private DateTimePicker dtpDesde;
    private Button btnFiltrar;
    private Label lblEstadopago;
    private Button btnPagar;
    private ComboBox cmbPeriodo;
    private Label label34;
    private frmServicio intance;
    private int codigoProveedor;

    public frmServicio()
    {
      this.InitializeComponent();
      this.intance = this;
      this.cargaPermisos();
      this.cargaIva();
      this.iniciaFormulario();
      this.creaColumnasBuscaProveedores();
      this.creaColumnasDetalle();
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
      this.groupBox1 = new GroupBox();
      this.txtFolio = new TextBox();
      this.dtpVencimiento = new DateTimePicker();
      this.dtpIngreso = new DateTimePicker();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.txtDigito = new TextBox();
      this.txtRut = new TextBox();
      this.txtRazonSocial = new TextBox();
      this.btnBuscaProveedor = new Button();
      this.label4 = new Label();
      this.label5 = new Label();
      this.groupBox2 = new GroupBox();
      this.txtTotal = new TextBox();
      this.groupBox3 = new GroupBox();
      this.cmbMedioPago = new ComboBox();
      this.label6 = new Label();
      this.label7 = new Label();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnGuardar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.pnlBuscaProveedorDes = new Panel();
      this.dgvBuscaProveedor = new DataGridView();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.btnPagar = new Button();
      this.lblEstadopago = new Label();
      this.tabPage2 = new TabPage();
      this.btnFiltrar = new Button();
      this.label8 = new Label();
      this.dtpHasta = new DateTimePicker();
      this.label9 = new Label();
      this.dtpDesde = new DateTimePicker();
      this.dgvDatosVenta = new DataGridView();
      this.cmbPeriodo = new ComboBox();
      this.label34 = new Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.pnlBuscaProveedorDes.SuspendLayout();
      ((ISupportInitialize) this.dgvBuscaProveedor).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((ISupportInitialize) this.dgvDatosVenta).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.cmbPeriodo);
      this.groupBox1.Controls.Add((Control) this.txtFolio);
      this.groupBox1.Controls.Add((Control) this.label34);
      this.groupBox1.Controls.Add((Control) this.dtpVencimiento);
      this.groupBox1.Controls.Add((Control) this.dtpIngreso);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(6, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(515, 61);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.txtFolio.Location = new Point(409, 30);
      this.txtFolio.Name = "txtFolio";
      this.txtFolio.Size = new Size(100, 20);
      this.txtFolio.TabIndex = 3;
      this.txtFolio.TextAlign = HorizontalAlignment.Right;
      this.dtpVencimiento.Format = DateTimePickerFormat.Short;
      this.dtpVencimiento.Location = new Point(113, 30);
      this.dtpVencimiento.Name = "dtpVencimiento";
      this.dtpVencimiento.Size = new Size(101, 20);
      this.dtpVencimiento.TabIndex = 2;
      this.dtpIngreso.Format = DateTimePickerFormat.Short;
      this.dtpIngreso.Location = new Point(6, 30);
      this.dtpIngreso.Name = "dtpIngreso";
      this.dtpIngreso.Size = new Size(101, 20);
      this.dtpIngreso.TabIndex = 1;
      this.label3.BackColor = Color.FromArgb(64, 64, 64);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(409, 14);
      this.label3.Name = "label3";
      this.label3.Size = new Size(100, 23);
      this.label3.TabIndex = 36;
      this.label3.Text = "Folio Documento";
      this.label3.TextAlign = ContentAlignment.TopRight;
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(113, 14);
      this.label2.Name = "label2";
      this.label2.Size = new Size(100, 23);
      this.label2.TabIndex = 35;
      this.label2.Text = "Fecha Vencimiento";
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(6, 14);
      this.label1.Name = "label1";
      this.label1.Size = new Size(100, 23);
      this.label1.TabIndex = 34;
      this.label1.Text = "Fecha Ingreso";
      this.txtDigito.Location = new Point(76, 32);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 6;
      this.txtDigito.KeyPress += new KeyPressEventHandler(this.txtDigito_KeyPress);
      this.txtRut.Location = new Point(5, 32);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(68, 20);
      this.txtRut.TabIndex = 5;
      this.txtRut.KeyDown += new KeyEventHandler(this.txtRut_KeyDown);
      this.txtRut.KeyPress += new KeyPressEventHandler(this.txtRut_KeyPress);
      this.txtRazonSocial.Location = new Point(112, 32);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(396, 20);
      this.txtRazonSocial.TabIndex = 7;
      this.txtRazonSocial.TextChanged += new EventHandler(this.txtRazonSocial_TextChanged);
      this.txtRazonSocial.KeyDown += new KeyEventHandler(this.txtRazonSocial_KeyDown);
      this.btnBuscaProveedor.Location = new Point(400, 58);
      this.btnBuscaProveedor.Name = "btnBuscaProveedor";
      this.btnBuscaProveedor.Size = new Size(108, 23);
      this.btnBuscaProveedor.TabIndex = 33;
      this.btnBuscaProveedor.Text = "Buscar Proveedor";
      this.btnBuscaProveedor.UseVisualStyleBackColor = true;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(6, 16);
      this.label4.Name = "label4";
      this.label4.Size = new Size(30, 13);
      this.label4.TabIndex = 37;
      this.label4.Text = "RUT";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(112, 16);
      this.label5.Name = "label5";
      this.label5.Size = new Size(70, 13);
      this.label5.TabIndex = 38;
      this.label5.Text = "Razon Social";
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Controls.Add((Control) this.txtRut);
      this.groupBox2.Controls.Add((Control) this.txtDigito);
      this.groupBox2.Controls.Add((Control) this.txtRazonSocial);
      this.groupBox2.Controls.Add((Control) this.btnBuscaProveedor);
      this.groupBox2.Location = new Point(6, 64);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(516, 92);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.txtTotal.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotal.Location = new Point(408, 23);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new Size(100, 26);
      this.txtTotal.TabIndex = 10;
      this.txtTotal.TextAlign = HorizontalAlignment.Right;
      this.txtTotal.KeyPress += new KeyPressEventHandler(this.txtTotal_KeyPress);
      this.groupBox3.Controls.Add((Control) this.cmbMedioPago);
      this.groupBox3.Controls.Add((Control) this.label6);
      this.groupBox3.Controls.Add((Control) this.label7);
      this.groupBox3.Controls.Add((Control) this.txtTotal);
      this.groupBox3.Location = new Point(6, 153);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(516, 68);
      this.groupBox3.TabIndex = 8;
      this.groupBox3.TabStop = false;
      this.cmbMedioPago.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbMedioPago.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMedioPago.FormattingEnabled = true;
      this.cmbMedioPago.Location = new Point(103, 26);
      this.cmbMedioPago.Name = "cmbMedioPago";
      this.cmbMedioPago.Size = new Size(140, 21);
      this.cmbMedioPago.TabIndex = 9;
      this.label6.BackColor = Color.FromArgb(64, 64, 64);
      this.label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(6, 26);
      this.label6.Name = "label6";
      this.label6.Size = new Size(100, 21);
      this.label6.TabIndex = 7;
      this.label6.Text = "Medio de Pago";
      this.label6.TextAlign = ContentAlignment.MiddleLeft;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(286, 26);
      this.label7.Name = "label7";
      this.label7.Size = new Size(116, 20);
      this.label7.TabIndex = 5;
      this.label7.Text = "Total a Pagar";
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(560, 313);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(124, 23);
      this.btnSalir.TabIndex = 15;
      this.btnSalir.Text = "SALIR";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Location = new Point(544, 102);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(124, 23);
      this.btnLimpiar.TabIndex = 14;
      this.btnLimpiar.Text = "LIMPIAR";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnGuardar.Location = new Point(544, 15);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(124, 23);
      this.btnGuardar.TabIndex = 11;
      this.btnGuardar.Text = "GUARDA [F2]";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnEliminar.Location = new Point(544, 73);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(124, 23);
      this.btnEliminar.TabIndex = 13;
      this.btnEliminar.Text = "ELIMINAR";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnModificar.Location = new Point(544, 44);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(124, 23);
      this.btnModificar.TabIndex = 12;
      this.btnModificar.Text = "MODIFICAR";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.pnlBuscaProveedorDes.Controls.Add((Control) this.dgvBuscaProveedor);
      this.pnlBuscaProveedorDes.Location = new Point(20, 117);
      this.pnlBuscaProveedorDes.Name = "pnlBuscaProveedorDes";
      this.pnlBuscaProveedorDes.Size = new Size(508, 106);
      this.pnlBuscaProveedorDes.TabIndex = 33;
      this.dgvBuscaProveedor.AllowUserToAddRows = false;
      this.dgvBuscaProveedor.AllowUserToDeleteRows = false;
      this.dgvBuscaProveedor.AllowUserToResizeColumns = false;
      this.dgvBuscaProveedor.AllowUserToResizeRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvBuscaProveedor.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvBuscaProveedor.BackgroundColor = Color.LavenderBlush;
      this.dgvBuscaProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvBuscaProveedor.DefaultCellStyle = gridViewCellStyle2;
      this.dgvBuscaProveedor.Location = new Point(3, 3);
      this.dgvBuscaProveedor.Name = "dgvBuscaProveedor";
      this.dgvBuscaProveedor.ReadOnly = true;
      this.dgvBuscaProveedor.RowHeadersVisible = false;
      this.dgvBuscaProveedor.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaProveedor.Size = new Size(501, 100);
      this.dgvBuscaProveedor.TabIndex = 0;
      this.dgvBuscaProveedor.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaProveedor_CellDoubleClick);
      this.dgvBuscaProveedor.KeyDown += new KeyEventHandler(this.dgvBuscaProveedor_KeyDown);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(687, 289);
      this.tabControl1.SizeMode = TabSizeMode.Fixed;
      this.tabControl1.TabIndex = 34;
      this.tabPage1.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage1.Controls.Add((Control) this.btnPagar);
      this.tabPage1.Controls.Add((Control) this.lblEstadopago);
      this.tabPage1.Controls.Add((Control) this.groupBox1);
      this.tabPage1.Controls.Add((Control) this.pnlBuscaProveedorDes);
      this.tabPage1.Controls.Add((Control) this.groupBox2);
      this.tabPage1.Controls.Add((Control) this.btnLimpiar);
      this.tabPage1.Controls.Add((Control) this.btnModificar);
      this.tabPage1.Controls.Add((Control) this.btnGuardar);
      this.tabPage1.Controls.Add((Control) this.btnEliminar);
      this.tabPage1.Controls.Add((Control) this.groupBox3);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(679, 263);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Ingreso";
      this.btnPagar.Location = new Point(544, 154);
      this.btnPagar.Name = "btnPagar";
      this.btnPagar.Size = new Size(124, 23);
      this.btnPagar.TabIndex = 35;
      this.btnPagar.Text = "PAGAR";
      this.btnPagar.UseVisualStyleBackColor = true;
      this.btnPagar.Click += new EventHandler(this.btnPagar_Click);
      this.lblEstadopago.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblEstadopago.ForeColor = Color.Red;
      this.lblEstadopago.Location = new Point(451, 223);
      this.lblEstadopago.Name = "lblEstadopago";
      this.lblEstadopago.Size = new Size(217, 29);
      this.lblEstadopago.TabIndex = 34;
      this.lblEstadopago.Text = "ESTADO";
      this.lblEstadopago.TextAlign = ContentAlignment.TopRight;
      this.tabPage2.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage2.Controls.Add((Control) this.btnFiltrar);
      this.tabPage2.Controls.Add((Control) this.label8);
      this.tabPage2.Controls.Add((Control) this.dtpHasta);
      this.tabPage2.Controls.Add((Control) this.label9);
      this.tabPage2.Controls.Add((Control) this.dtpDesde);
      this.tabPage2.Controls.Add((Control) this.dgvDatosVenta);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(679, 263);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Busqueda";
      this.btnFiltrar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnFiltrar.Location = new Point(218, 18);
      this.btnFiltrar.Name = "btnFiltrar";
      this.btnFiltrar.Size = new Size(69, 27);
      this.btnFiltrar.TabIndex = 18;
      this.btnFiltrar.Text = "Filtrar";
      this.btnFiltrar.UseVisualStyleBackColor = true;
      this.btnFiltrar.Click += new EventHandler(this.btnFiltrar_Click);
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(7, 8);
      this.label8.Name = "label8";
      this.label8.Size = new Size(43, 15);
      this.label8.TabIndex = 10;
      this.label8.Text = "Desde";
      this.dtpHasta.Format = DateTimePickerFormat.Short;
      this.dtpHasta.Location = new Point(114, 25);
      this.dtpHasta.Name = "dtpHasta";
      this.dtpHasta.Size = new Size(98, 20);
      this.dtpHasta.TabIndex = 13;
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(115, 8);
      this.label9.Name = "label9";
      this.label9.Size = new Size(39, 15);
      this.label9.TabIndex = 11;
      this.label9.Text = "Hasta";
      this.dtpDesde.Format = DateTimePickerFormat.Short;
      this.dtpDesde.Location = new Point(10, 25);
      this.dtpDesde.Name = "dtpDesde";
      this.dtpDesde.Size = new Size(98, 20);
      this.dtpDesde.TabIndex = 12;
      this.dgvDatosVenta.AllowUserToAddRows = false;
      this.dgvDatosVenta.AllowUserToDeleteRows = false;
      this.dgvDatosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatosVenta.Location = new Point(6, 51);
      this.dgvDatosVenta.Name = "dgvDatosVenta";
      this.dgvDatosVenta.ReadOnly = true;
      this.dgvDatosVenta.RowHeadersVisible = false;
      this.dgvDatosVenta.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.ScrollBars = ScrollBars.Vertical;
      this.dgvDatosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatosVenta.Size = new Size(667, 206);
      this.dgvDatosVenta.TabIndex = 0;
      this.dgvDatosVenta.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
      this.cmbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbPeriodo.FormattingEnabled = true;
      this.cmbPeriodo.Location = new Point(220, 30);
      this.cmbPeriodo.Name = "cmbPeriodo";
      this.cmbPeriodo.Size = new Size(119, 21);
      this.cmbPeriodo.TabIndex = 39;
      this.label34.BackColor = Color.FromArgb(64, 64, 64);
      this.label34.ForeColor = Color.White;
      this.label34.Location = new Point(220, 14);
      this.label34.Name = "label34";
      this.label34.Size = new Size(119, 23);
      this.label34.TabIndex = 40;
      this.label34.Text = "Periodo Contable";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(704, 346);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.btnSalir);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmServicio";
      this.ShowIcon = false;
      this.Text = "Gastos de Servicios";
      this.FormClosing += new FormClosingEventHandler(this.frmServicio_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.pnlBuscaProveedorDes.ResumeLayout(false);
      ((ISupportInitialize) this.dgvBuscaProveedor).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((ISupportInitialize) this.dgvDatosVenta).EndInit();
      this.ResumeLayout(false);
    }

    private void cargaIva()
    {
      try
      {
        this._iva = new Calculos()._iva;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Porcentaje del Iva: " + ex.Message);
      }
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
        }
      }
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) new MedioPago().listaMediosPago();
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      this.cmbMedioPago.SelectedValue = (object) 0;
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
      this.cargaMediosPago();
      this.cargaPeriodos();
      this.seVOModulo = new ServicioVO();
      this.dtpIngreso.Value = DateTime.Today;
      this.dtpVencimiento.Value = DateTime.Today;
      this.txtFolio.Clear();
      this.txtRut.Clear();
      this.txtDigito.Clear();
      this.txtRazonSocial.Clear();
      this.txtTotal.Clear();
      this.txtFolio.Focus();
      this.lblEstadopago.Text = "";
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnPagar.Enabled = false;
      this.dgvBuscaProveedor.DataSource = (object) null;
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

    private void creaColumnasDetalle()
    {
      this.dgvDatosVenta.AutoGenerateColumns = false;
      this.dgvDatosVenta.Columns.Add("Linea", "");
      this.dgvDatosVenta.Columns[0].DataPropertyName = "Linea";
      this.dgvDatosVenta.Columns[0].Width = 20;
      this.dgvDatosVenta.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
      this.dgvDatosVenta.Columns.Add("Folio", "Folio");
      this.dgvDatosVenta.Columns[1].DataPropertyName = "FolioServicio";
      this.dgvDatosVenta.Columns[1].Width = 70;
      this.dgvDatosVenta.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("RazonSocial", "RazonSocial");
      this.dgvDatosVenta.Columns[2].DataPropertyName = "RazonSocial";
      this.dgvDatosVenta.Columns[2].Width = 100;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Ingreso", "Ingreso");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "FechaIngreso";
      this.dgvDatosVenta.Columns[3].Width = 80;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Vencimiento", "Vencimiento");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "FechaVencimiento";
      this.dgvDatosVenta.Columns[4].Width = 80;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Total", "Total");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "Total";
      this.dgvDatosVenta.Columns[5].Width = 90;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Format = "C0";
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("EstadoPago", "EstadoPago");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "EstadoPago";
      this.dgvDatosVenta.Columns[6].Width = 100;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("IdServicio", "IdServicio");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "IdServicio";
      this.dgvDatosVenta.Columns[7].Width = 100;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[7].Visible = false;
      this.dgvDatosVenta.Columns.Add("IdPeriodo", "IdPeriodo");
      this.dgvDatosVenta.Columns[8].DataPropertyName = "IdPeriodo";
      this.dgvDatosVenta.Columns[8].Width = 100;
      this.dgvDatosVenta.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[8].Visible = false;
      this.dgvDatosVenta.Columns.Add("Periodo", "Periodo");
      this.dgvDatosVenta.Columns[9].DataPropertyName = "Periodo";
      this.dgvDatosVenta.Columns[9].Width = 100;
      this.dgvDatosVenta.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[9].Visible = true;
    }

    private void buscaProveedor()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new Proveedor().buscaRutProveedor(this.txtRut.Text.Trim());
      if (arrayList2.Count == 0)
      {
        if (MessageBox.Show("No Existe Proveedor Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          new frmProveedor(this.txtRut.Text.Trim(), this.txtDigito.Text.Trim()).Show();
        else
          this.iniciaFormulario();
      }
      else
      {
        if (arrayList2.Count != 1)
          return;
        foreach (ClienteVO clienteVo in arrayList2)
          this.buscaProveedorCodigo(clienteVo.Codigo);
        this.cmbMedioPago.Focus();
      }
    }

    public void buscaProveedorCodigo(int cod)
    {
      ClienteVO clienteVo = new Proveedor().buscaCodigoProveedor(cod);
      this.codigoProveedor = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.cmbMedioPago.Focus();
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

    private bool validaCampos()
    {
      if (this.cmbMedioPago.SelectedValue == null || this.cmbMedioPago.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona el Medio de Pago", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.cmbMedioPago.Focus();
        return false;
      }
      if (this.txtFolio.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Folio del Documento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtFolio.Focus();
        return false;
      }
      if (Convert.ToInt32(this.txtFolio.Text.Trim()) == 0)
      {
        int num = (int) MessageBox.Show("Numero de Folio No Valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtFolio.Focus();
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
      if (this.txtTotal.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Total", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtTotal.Focus();
        return false;
      }
      if (!(Convert.ToDecimal(this.txtTotal.Text) <= new Decimal(0)))
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Total mayor que Cero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtTotal.Focus();
      return false;
    }

    private ServicioVO armaServicio()
    {
      DateTime dateTime1 =DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local1 = @dateTime1;
      DateTime now1 = this.dtpIngreso.Value;
      int year1 = now1.Year;
      now1 = this.dtpIngreso.Value;
      int month1 = now1.Month;
      now1 = this.dtpIngreso.Value;
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
      DateTime dateTime2=DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local2 = @dateTime2;
      DateTime now2 = this.dtpVencimiento.Value;
      int year2 = now2.Year;
      now2 = this.dtpVencimiento.Value;
      int month2 = now2.Month;
      now2 = this.dtpVencimiento.Value;
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
      ServicioVO servicioVo = new ServicioVO();
      servicioVo.FolioServicio = this.txtFolio.Text.Trim();
      servicioVo.IdProveedor = this.codigoProveedor;
      servicioVo.Rut = this.txtRut.Text.Trim();
      servicioVo.Digito = this.txtDigito.Text.Trim().ToUpper();
      servicioVo.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
      servicioVo.FechaIngreso = dateTime1;
      servicioVo.FechaVencimiento = dateTime2;
      this.calculaTotales();
      servicioVo.Neto = this._totalNeto;
      servicioVo.Iva = this._totalIva;
      servicioVo.Total = Convert.ToDecimal(this.txtTotal.Text.Trim());
      servicioVo.Usuario = this._usuario;
      servicioVo.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
      servicioVo.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
      if (this.cmbPeriodo.SelectedValue != null)
      {
        servicioVo.IdPeriodo = Convert.ToInt32(this.cmbPeriodo.SelectedValue.ToString());
        servicioVo.Periodo = this.cmbPeriodo.Text.ToString().ToUpper();
      }
      return servicioVo;
    }

    private void guardaServicio()
    {
      try
      {
        Servicio servicio = new Servicio();
        ServicioVO seVO = this.armaServicio();
        int num1 = new MedioPago().obtieneEstadoLiquida(seVO.IdMedioPago);
        if (num1 == 1)
        {
          seVO.EstadoPago = "PAGADO";
          seVO.TotalPagado = seVO.Total;
          seVO.TotalDocumentado = new Decimal(0);
          seVO.TotalPendiente = new Decimal(0);
        }
        else
        {
          seVO.EstadoPago = "PENDIENTE";
          seVO.TotalPagado = new Decimal(0);
          seVO.TotalDocumentado = new Decimal(0);
          seVO.TotalPendiente = seVO.Total;
        }
        if (servicio.servicioExiste(this.txtFolio.Text.Trim(), this.txtRut.Text.Trim()))
        {
          int num2 = (int) MessageBox.Show("Ya Existe un Documento de este Proveedor con el Numero : " + this.txtFolio.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtFolio.Focus();
        }
        else
        {
          servicio.guardaServicio(seVO);
          if (num1 == 0 && MessageBox.Show("¿ Desea Ingresar el detalle del Pago ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.pagarCompra(servicio.retornaIdServicio(seVO.FolioServicio, seVO.Rut));
          if (num1 == 1)
          {
            PagoCompra pagoCompra = new PagoCompra();
            PagoVentaVO pvVO = new PagoVentaVO();
            pvVO.FechaCobro = seVO.FechaIngreso;
            pvVO.IdFormaPago = seVO.IdMedioPago;
            pvVO.FormaPago = seVO.MedioPago;
            pvVO.Monto = seVO.Total;
            pvVO.Estado = "PAGADO";
            int idDoc = servicio.retornaIdServicio(seVO.FolioServicio, seVO.Rut);
            pagoCompra.agregarPagoCompra(pvVO, "SERVICIO", idDoc, (long) Convert.ToInt32(seVO.FolioServicio), seVO.FechaIngreso);
          }
          int num2 = (int) MessageBox.Show("Documento Guardado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void modificaServicio()
    {
      if (MessageBox.Show("Esta Seguro de Modificar este Documento ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      try
      {
        Servicio servicio = new Servicio();
        ServicioVO seVO = this.armaServicio();
        seVO.IdServicio = this.seVOModulo.IdServicio;
        int num1 = new MedioPago().obtieneEstadoLiquida(seVO.IdMedioPago);
        if (num1 == 1)
        {
          seVO.EstadoPago = "PAGADO";
          seVO.TotalPagado = seVO.Total;
          seVO.TotalDocumentado = new Decimal(0);
          seVO.TotalPendiente = new Decimal(0);
        }
        else
        {
          seVO.EstadoPago = "PENDIENTE";
          seVO.TotalPagado = new Decimal(0);
          seVO.TotalDocumentado = new Decimal(0);
          seVO.TotalPendiente = seVO.Total;
        }
        servicio.modificaServicio(seVO);
        if (num1 == 0 && this.seVOModulo.Total != seVO.Total && MessageBox.Show("¿ Desea Ingresar el detalle del Pago ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          this.pagarCompra(this.seVOModulo.IdServicio);
        int num2 = (int) MessageBox.Show("Documento Modificado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void eliminaServicio()
    {
      if (MessageBox.Show("Esta Seguro de Eliminar este Documento ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      try
      {
        new PagoCompra().eliminaPagoCompra("SERVICIO", this.seVOModulo.IdServicio, (long) Convert.ToInt32(this.seVOModulo.FolioServicio));
        new Servicio().eliminaServicio(this.seVOModulo.IdServicio);
        int num = (int) MessageBox.Show("Documento Eliminado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void pagarCompra(int id)
    {
      int num = (int) new frmPagosCompras(ref this.intance, "SERVICIO", id).ShowDialog();
      this.iniciaFormulario();
    }

    private void calculaTotales()
    {
        Decimal d5 = this._iva / new Decimal(100); 
      this._totalNeto = Convert.ToDecimal(this.txtTotal.Text.Trim()) / ++d5;
      this._totalIva = this._totalNeto * this._iva / new Decimal(100);
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modServicio = 0;
      this.Dispose();
      this.Close();
    }

    private void frmServicio_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modServicio = 0;
      this.Dispose();
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
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRut.Focus();
      }
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

    private void dgvBuscaProveedor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaProveedorCodigo(Convert.ToInt32(this.dgvBuscaProveedor.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaProveedorDes.Visible = false;
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

    private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtTotal);
    }

    private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtRut);
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.validaCampos())
        return;
      this.guardaServicio();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (!this.validaCampos())
        return;
      this.modificaServicio();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (this.seVOModulo.IdServicio <= 0)
        return;
      this.eliminaServicio();
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
      DataTable dataTable = new Servicio().listaServiciosFiltro(Convert.ToDateTime(this.dtpDesde.Text), Convert.ToDateTime(this.dtpHasta.Text));
      for (int index = 0; index < dataTable.Rows.Count; ++index)
        dataTable.Rows[index]["linea"] = (object) (index + 1);
      this.dgvDatosVenta.DataSource = (object) dataTable;
    }

    private void dgvDatosVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      Servicio servicio = new Servicio();
      string idServicio = this.dgvDatosVenta.SelectedRows[0].Cells["IdServicio"].Value.ToString();
      this.seVOModulo = new ServicioVO();
      this.seVOModulo = servicio.buscaServicioID(idServicio);
      this.dtpIngreso.Value = this.seVOModulo.FechaIngreso;
      this.dtpVencimiento.Value = this.seVOModulo.FechaVencimiento;
      this.txtFolio.Text = this.seVOModulo.FolioServicio;
      this.codigoProveedor = this.seVOModulo.IdProveedor;
      this.txtRut.Text = this.seVOModulo.Rut;
      this.txtDigito.Text = this.seVOModulo.Digito;
      this.txtRazonSocial.Text = this.seVOModulo.RazonSocial;
      this.cmbMedioPago.SelectedValue = (object) this.seVOModulo.IdMedioPago;
      this.txtTotal.Text = this.seVOModulo.Total.ToString("N0");
      this.lblEstadopago.Text = this.seVOModulo.EstadoPago;
      this.cmbPeriodo.SelectedValue = (object) this.seVOModulo.IdPeriodo;
      this.btnGuardar.Enabled = false;
      if (this._modifica)
        this.btnModificar.Enabled = true;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      this.btnPagar.Enabled = true;
      this.tabControl1.SelectedIndex = 0;
    }

    private void btnPagar_Click(object sender, EventArgs e)
    {
      this.pagarCompra(this.seVOModulo.IdServicio);
    }
  }
}
