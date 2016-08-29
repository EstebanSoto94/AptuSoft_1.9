 
// Type: Aptusoft.frmClientes
 
 
// version 1.8.0

using Aptusoft.InternoAptusoft.Contratacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmClientes : Form
  {
    private IContainer components = (IContainer) null;
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private GroupBox groupBox1;
    private TextBox txtDigito;
    private TextBox txtRut;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox txtGiro;
    private TextBox txtFantasia;
    private TextBox txtRazonSocial;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label13;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private DateTimePicker dtpFechaIngreso;
    private TextBox txtFechaUltimaCompra;
    private TextBox txtObservaciones;
    private TextBox txtEmailContacto;
    private TextBox txtFonoContacto;
    private TextBox txtContacto;
    private TextBox txtEmail;
    private TextBox txtFax;
    private TextBox txtTelefono;
    private ComboBox cmbComuna;
    private ComboBox cmbCiudad;
    private TextBox txtDireccion;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private GroupBox groupBox2;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem;
    private ToolStripMenuItem agregarOtraDirecciónAUnClienteToolStripMenuItem;
    private Button btnBuscaCliente;
    private Label label17;
    private TextBox txtDiasPlazo;
    private CheckBox chkVerificaRut;
    private ComboBox cmbListaPrecio;
    private Label label29;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TextBox txtCredito;
    private Label label19;
    private ComboBox cmbMedioPago;
    private Label label20;
    private GroupBox groupBox3;
    private TextBox txtMotivoBloqueo;
    private Label label22;
    private ComboBox cmbEstado;
    private Label label21;
    private TabPage tabPage3;
    private DataGridView dgvDatosVenta;
    private GroupBox groupBox4;
    private Panel panel1;
    private Label label23;
    private DateTimePicker dtpDesde;
    private ComboBox cmbTipoDocumento;
    private Label label25;
    private Label label24;
    private DateTimePicker dtpHasta;
    private Button btnFiltrar;
    private TextBox txtTotalPagado;
    private Label label28;
    private TextBox txtTotalPendiente;
    private Label label27;
    private TextBox txtTotalDocumentado;
    private Label label26;
    private Label label31;
    private Label label30;
    private DataGridView dgvNotaCredito;
    private GroupBox groupBox5;
    private GroupBox groupBox6;
    private TextBox txtTotalDisponible;
    private Label label32;
    private TextBox txtTotalUsado;
    private Label label18;
    private TextBox txtDeuda;
    private Label label33;
    private GroupBox gpbClienteSoporte;
    private DateTimePicker dtpInicioSoporte;
    private NumericUpDown nudMesesSoporte;
    private Label label35;
    private Label label34;
    private Button button1;
    private Label lblDias;
    private Panel panelColorDeuda;
    private Label label36;
    private ComboBox cmbRubro;
    private frmClientes intance;
    private int codigoCliente;

    public frmClientes()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaClientes();
      this.intance = this;
      this.creaColumnasDetalle();
      this.creaColumnasDetalleNC();
    }

    public frmClientes(string r, string d)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaClientes();
      this.intance = this;
      this.txtRut.Text = r.ToString();
      this.txtDigito.Text = d.ToString().ToUpper();
      if ((!this.chkVerificaRut.Checked ? new ValidaDigito().digitoVerificador(Convert.ToInt32(this.txtRut.Text)) : this.txtDigito.Text.Trim()).Equals(this.txtDigito.Text))
      {
        this.buscaCliente();
      }
      else
      {
        int num = (int) MessageBox.Show("El RUT Ingresado no es Valido!!!");
      }
      this.creaColumnasDetalle();
      this.creaColumnasDetalleNC();
    }

    public frmClientes(string fono)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaClientes();
      this.intance = this;
      this.txtTelefono.Text = fono;
      this.buscaCliente();
      this.creaColumnasDetalle();
      this.creaColumnasDetalleNC();
      this.txtRazonSocial.Focus();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.chkVerificaRut = new System.Windows.Forms.CheckBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtEmailContacto = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtFonoContacto = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.cmbComuna = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtFechaUltimaCompra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarOtraDirecciónAUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiasPlazo = new System.Windows.Forms.TextBox();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbClienteSoporte = new System.Windows.Forms.GroupBox();
            this.panelColorDeuda = new System.Windows.Forms.Panel();
            this.lblDias = new System.Windows.Forms.Label();
            this.nudMesesSoporte = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.dtpInicioSoporte = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMotivoBloqueo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotalPendiente = new System.Windows.Forms.TextBox();
            this.txtTotalPagado = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtTotalDocumentado = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTotalDisponible = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtTotalUsado = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dgvNotaCredito = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dgvDatosVenta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpbClienteSoporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMesesSoporte)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaCredito)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.cmbRubro);
            this.groupBox1.Controls.Add(this.chkVerificaRut);
            this.groupBox1.Controls.Add(this.btnBuscaCliente);
            this.groupBox1.Controls.Add(this.txtEmailContacto);
            this.groupBox1.Controls.Add(this.txtFantasia);
            this.groupBox1.Controls.Add(this.txtFonoContacto);
            this.groupBox1.Controls.Add(this.txtDigito);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtGiro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.cmbComuna);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCiudad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 495);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(7, 164);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(300, 16);
            this.label36.TabIndex = 18;
            this.label36.Text = "Rubro";
            // 
            // cmbRubro
            // 
            this.cmbRubro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRubro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRubro.BackColor = System.Drawing.Color.White;
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.ForeColor = System.Drawing.Color.Black;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(7, 180);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(300, 21);
            this.cmbRubro.TabIndex = 19;
            // 
            // chkVerificaRut
            // 
            this.chkVerificaRut.AutoSize = true;
            this.chkVerificaRut.Location = new System.Drawing.Point(10, 54);
            this.chkVerificaRut.Name = "chkVerificaRut";
            this.chkVerificaRut.Size = new System.Drawing.Size(109, 17);
            this.chkVerificaRut.TabIndex = 17;
            this.chkVerificaRut.Text = "NO Verificar RUT";
            this.chkVerificaRut.UseVisualStyleBackColor = true;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.Location = new System.Drawing.Point(363, 76);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(97, 37);
            this.btnBuscaCliente.TabIndex = 16;
            this.btnBuscaCliente.Text = "Buscar Cliente";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtEmailContacto
            // 
            this.txtEmailContacto.Location = new System.Drawing.Point(230, 387);
            this.txtEmailContacto.Name = "txtEmailContacto";
            this.txtEmailContacto.Size = new System.Drawing.Size(230, 20);
            this.txtEmailContacto.TabIndex = 14;
            this.txtEmailContacto.Enter += new System.EventHandler(this.txtEmailContacto_Enter);
            this.txtEmailContacto.Leave += new System.EventHandler(this.txtEmailContacto_Leave);
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(142, 32);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(318, 20);
            this.txtFantasia.TabIndex = 3;
            this.txtFantasia.Enter += new System.EventHandler(this.txtFantasia_Enter);
            this.txtFantasia.Leave += new System.EventHandler(this.txtFantasia_Leave);
            // 
            // txtFonoContacto
            // 
            this.txtFonoContacto.Location = new System.Drawing.Point(7, 387);
            this.txtFonoContacto.Name = "txtFonoContacto";
            this.txtFonoContacto.Size = new System.Drawing.Size(101, 20);
            this.txtFonoContacto.TabIndex = 13;
            this.txtFonoContacto.Enter += new System.EventHandler(this.txtFonoContacto_Enter);
            this.txtFonoContacto.Leave += new System.EventHandler(this.txtFonoContacto_Leave);
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(97, 32);
            this.txtDigito.MaxLength = 1;
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(31, 20);
            this.txtDigito.TabIndex = 2;
            this.txtDigito.Tag = "Pulse Enter";
            this.txtDigito.TextChanged += new System.EventHandler(this.txtDigito_TextChanged);
            this.txtDigito.Enter += new System.EventHandler(this.txtDigito_Enter);
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            this.txtDigito.Leave += new System.EventHandler(this.txtDigito_Leave);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(230, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Email Contacto";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(7, 32);
            this.txtRut.MaxLength = 8;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(88, 20);
            this.txtRut.TabIndex = 1;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            this.txtRut.Enter += new System.EventHandler(this.txtRut_Enter);
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            this.txtRut.Leave += new System.EventHandler(this.txtRut_Leave);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(7, 347);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(453, 20);
            this.txtContacto.TabIndex = 12;
            this.txtContacto.Enter += new System.EventHandler(this.txtContacto_Enter);
            this.txtContacto.Leave += new System.EventHandler(this.txtContacto_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(453, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direccíon";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(230, 307);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(7, 427);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(453, 63);
            this.txtObservaciones.TabIndex = 15;
            this.txtObservaciones.Enter += new System.EventHandler(this.txtObservaciones_Enter);
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ciudad";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(112, 307);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(113, 20);
            this.txtFax.TabIndex = 10;
            this.txtFax.Enter += new System.EventHandler(this.txtFax_Enter);
            this.txtFax.Leave += new System.EventHandler(this.txtFax_Leave);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(233, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Comuna";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(7, 411);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(453, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Observaciones";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(7, 307);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(101, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(7, 138);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(453, 20);
            this.txtGiro.TabIndex = 5;
            this.txtGiro.Enter += new System.EventHandler(this.txtGiro_Enter);
            this.txtGiro.Leave += new System.EventHandler(this.txtGiro_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefono";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(7, 93);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(350, 20);
            this.txtRazonSocial.TabIndex = 4;
            this.txtRazonSocial.Enter += new System.EventHandler(this.txtRazonSocial_Enter);
            this.txtRazonSocial.Leave += new System.EventHandler(this.txtRazonSocial_Leave);
            // 
            // cmbComuna
            // 
            this.cmbComuna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbComuna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Location = new System.Drawing.Point(233, 264);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(227, 21);
            this.cmbComuna.TabIndex = 8;
            this.cmbComuna.Enter += new System.EventHandler(this.cmbComuna_Enter);
            this.cmbComuna.Leave += new System.EventHandler(this.cmbComuna_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(453, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giro";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(113, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fax";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(142, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Fantasia";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(7, 264);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(217, 21);
            this.cmbCiudad.TabIndex = 7;
            this.cmbCiudad.Enter += new System.EventHandler(this.cmbCiudad_Enter);
            this.cmbCiudad.Leave += new System.EventHandler(this.cmbCiudad_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre o Razon Social";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(230, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.U.T";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(7, 223);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(453, 20);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(7, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Fono Contacto";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(453, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Contacto";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(9, 35);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(127, 20);
            this.dtpFechaIngreso.TabIndex = 16;
            this.dtpFechaIngreso.Enter += new System.EventHandler(this.dtpFechaIngreso_Enter);
            this.dtpFechaIngreso.Leave += new System.EventHandler(this.dtpFechaIngreso_Leave);
            // 
            // txtFechaUltimaCompra
            // 
            this.txtFechaUltimaCompra.Location = new System.Drawing.Point(145, 34);
            this.txtFechaUltimaCompra.Name = "txtFechaUltimaCompra";
            this.txtFechaUltimaCompra.ReadOnly = true;
            this.txtFechaUltimaCompra.Size = new System.Drawing.Size(127, 20);
            this.txtFechaUltimaCompra.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(145, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Fecha Ultima Compra";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(9, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 16);
            this.label15.TabIndex = 12;
            this.label15.Text = "Fecha de Ingreso";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(6, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 40);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(81, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 40);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(158, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 40);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(236, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 40);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(697, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 40);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(9, 563);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 65);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarOtraDirecciónAUnClienteToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarOtraDirecciónAUnClienteToolStripMenuItem
            // 
            this.agregarOtraDirecciónAUnClienteToolStripMenuItem.Name = "agregarOtraDirecciónAUnClienteToolStripMenuItem";
            this.agregarOtraDirecciónAUnClienteToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.agregarOtraDirecciónAUnClienteToolStripMenuItem.Text = "Agregar Otra Dirección a Cliente";
            this.agregarOtraDirecciónAUnClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarOtraDirecciónAUnClienteToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(9, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Dias Plazo";
            // 
            // txtDiasPlazo
            // 
            this.txtDiasPlazo.Location = new System.Drawing.Point(9, 74);
            this.txtDiasPlazo.Name = "txtDiasPlazo";
            this.txtDiasPlazo.Size = new System.Drawing.Size(127, 20);
            this.txtDiasPlazo.TabIndex = 25;
            this.txtDiasPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiasPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasPlazo_KeyPress);
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(144, 74);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(128, 21);
            this.cmbListaPrecio.TabIndex = 29;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(143, 58);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(129, 16);
            this.label29.TabIndex = 30;
            this.label29.Text = "Lista de Precio";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 533);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Cliente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.gpbClienteSoporte);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cmbMedioPago);
            this.groupBox4.Controls.Add(this.dtpFechaIngreso);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtCredito);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtDiasPlazo);
            this.groupBox4.Controls.Add(this.txtFechaUltimaCompra);
            this.groupBox4.Controls.Add(this.cmbListaPrecio);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(475, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 495);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Comerciales";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbClienteSoporte
            // 
            this.gpbClienteSoporte.Controls.Add(this.panelColorDeuda);
            this.gpbClienteSoporte.Controls.Add(this.lblDias);
            this.gpbClienteSoporte.Controls.Add(this.nudMesesSoporte);
            this.gpbClienteSoporte.Controls.Add(this.label35);
            this.gpbClienteSoporte.Controls.Add(this.label34);
            this.gpbClienteSoporte.Controls.Add(this.dtpInicioSoporte);
            this.gpbClienteSoporte.Location = new System.Drawing.Point(6, 197);
            this.gpbClienteSoporte.Name = "gpbClienteSoporte";
            this.gpbClienteSoporte.Size = new System.Drawing.Size(271, 129);
            this.gpbClienteSoporte.TabIndex = 36;
            this.gpbClienteSoporte.TabStop = false;
            this.gpbClienteSoporte.Text = "Soporte";
            // 
            // panelColorDeuda
            // 
            this.panelColorDeuda.Location = new System.Drawing.Point(14, 99);
            this.panelColorDeuda.Name = "panelColorDeuda";
            this.panelColorDeuda.Size = new System.Drawing.Size(244, 23);
            this.panelColorDeuda.TabIndex = 6;
            // 
            // lblDias
            // 
            this.lblDias.BackColor = System.Drawing.Color.Red;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.Color.Yellow;
            this.lblDias.Location = new System.Drawing.Point(14, 60);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(244, 33);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "fecha de soporte";
            this.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMesesSoporte
            // 
            this.nudMesesSoporte.Location = new System.Drawing.Point(170, 35);
            this.nudMesesSoporte.Name = "nudMesesSoporte";
            this.nudMesesSoporte.Size = new System.Drawing.Size(86, 20);
            this.nudMesesSoporte.TabIndex = 4;
            this.nudMesesSoporte.ValueChanged += new System.EventHandler(this.nudMesesSoporte_ValueChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(167, 20);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(93, 13);
            this.label35.TabIndex = 3;
            this.label35.Text = "Meses de Soporte";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(13, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(72, 13);
            this.label34.TabIndex = 2;
            this.label34.Text = "Inicio Soporte";
            // 
            // dtpInicioSoporte
            // 
            this.dtpInicioSoporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioSoporte.Location = new System.Drawing.Point(15, 35);
            this.dtpInicioSoporte.Name = "dtpInicioSoporte";
            this.dtpInicioSoporte.Size = new System.Drawing.Size(96, 20);
            this.dtpInicioSoporte.TabIndex = 0;
            this.dtpInicioSoporte.ValueChanged += new System.EventHandler(this.dtpInicioSoporte_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMotivoBloqueo);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cmbEstado);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(6, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 154);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bloquear Ventas";
            // 
            // txtMotivoBloqueo
            // 
            this.txtMotivoBloqueo.Location = new System.Drawing.Point(6, 81);
            this.txtMotivoBloqueo.Multiline = true;
            this.txtMotivoBloqueo.Name = "txtMotivoBloqueo";
            this.txtMotivoBloqueo.Size = new System.Drawing.Size(259, 63);
            this.txtMotivoBloqueo.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(7, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(259, 16);
            this.label22.TabIndex = 38;
            this.label22.Text = "Motivos de Bloqueo";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(98, 37);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(167, 21);
            this.cmbEstado.TabIndex = 36;
            this.cmbEstado.SelectedValueChanged += new System.EventHandler(this.cmbEstado_SelectedValueChanged);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(98, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(167, 16);
            this.label21.TabIndex = 37;
            this.label21.Text = "Estado";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedioPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(64, 159);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(208, 21);
            this.cmbMedioPago.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(64, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(208, 23);
            this.label20.TabIndex = 34;
            this.label20.Text = "Medio de Pago Predeterminado";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(145, 117);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(127, 20);
            this.txtCredito.TabIndex = 32;
            this.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCredito.TextChanged += new System.EventHandler(this.txtCredito_TextChanged);
            this.txtCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredito_KeyPress);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(145, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 16);
            this.label19.TabIndex = 31;
            this.label19.Text = "Credito Aprobado";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.txtDeuda);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.dgvNotaCredito);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.dgvDatosVenta);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(766, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registros";
            // 
            // txtDeuda
            // 
            this.txtDeuda.BackColor = System.Drawing.Color.White;
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeuda.ForeColor = System.Drawing.Color.Black;
            this.txtDeuda.Location = new System.Drawing.Point(654, 480);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 21);
            this.txtDeuda.TabIndex = 27;
            this.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.groupBox5.Controls.Add(this.txtTotalPendiente);
            this.groupBox5.Controls.Add(this.txtTotalPagado);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtTotalDocumentado);
            this.groupBox5.Location = new System.Drawing.Point(560, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 95);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Facturas y Boletas";
            // 
            // txtTotalPendiente
            // 
            this.txtTotalPendiente.BackColor = System.Drawing.Color.White;
            this.txtTotalPendiente.Enabled = false;
            this.txtTotalPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPendiente.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPendiente.Location = new System.Drawing.Point(94, 68);
            this.txtTotalPendiente.Name = "txtTotalPendiente";
            this.txtTotalPendiente.Size = new System.Drawing.Size(100, 21);
            this.txtTotalPendiente.TabIndex = 17;
            this.txtTotalPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.BackColor = System.Drawing.Color.White;
            this.txtTotalPagado.Enabled = false;
            this.txtTotalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagado.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPagado.Location = new System.Drawing.Point(94, 18);
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.Size = new System.Drawing.Size(100, 21);
            this.txtTotalPagado.TabIndex = 19;
            this.txtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(25, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 13);
            this.label26.TabIndex = 20;
            this.label26.Text = "Pendiente";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(15, 46);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 13);
            this.label27.TabIndex = 21;
            this.label27.Text = "Documentado";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(45, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 22;
            this.label28.Text = "Pagado";
            // 
            // txtTotalDocumentado
            // 
            this.txtTotalDocumentado.BackColor = System.Drawing.Color.White;
            this.txtTotalDocumentado.Enabled = false;
            this.txtTotalDocumentado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDocumentado.ForeColor = System.Drawing.Color.Black;
            this.txtTotalDocumentado.Location = new System.Drawing.Point(94, 43);
            this.txtTotalDocumentado.Name = "txtTotalDocumentado";
            this.txtTotalDocumentado.Size = new System.Drawing.Size(100, 21);
            this.txtTotalDocumentado.TabIndex = 18;
            this.txtTotalDocumentado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(573, 483);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 13);
            this.label33.TabIndex = 28;
            this.label33.Text = "Total Deuda";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.groupBox6.Controls.Add(this.txtTotalDisponible);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.txtTotalUsado);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(560, 405);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 72);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nota de Credito";
            // 
            // txtTotalDisponible
            // 
            this.txtTotalDisponible.BackColor = System.Drawing.Color.White;
            this.txtTotalDisponible.Enabled = false;
            this.txtTotalDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDisponible.ForeColor = System.Drawing.Color.Black;
            this.txtTotalDisponible.Location = new System.Drawing.Point(94, 43);
            this.txtTotalDisponible.Name = "txtTotalDisponible";
            this.txtTotalDisponible.Size = new System.Drawing.Size(100, 21);
            this.txtTotalDisponible.TabIndex = 25;
            this.txtTotalDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(23, 46);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 13);
            this.label32.TabIndex = 26;
            this.label32.Text = "Disponible";
            // 
            // txtTotalUsado
            // 
            this.txtTotalUsado.BackColor = System.Drawing.Color.White;
            this.txtTotalUsado.Enabled = false;
            this.txtTotalUsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalUsado.ForeColor = System.Drawing.Color.Black;
            this.txtTotalUsado.Location = new System.Drawing.Point(94, 18);
            this.txtTotalUsado.Name = "txtTotalUsado";
            this.txtTotalUsado.Size = new System.Drawing.Size(100, 21);
            this.txtTotalUsado.TabIndex = 23;
            this.txtTotalUsado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(51, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Usado";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(7, 298);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(114, 15);
            this.label31.TabIndex = 26;
            this.label31.Text = "Notas de Credito";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(7, 65);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(124, 15);
            this.label30.TabIndex = 25;
            this.label30.Text = "Facturas y Boletas";
            // 
            // dgvNotaCredito
            // 
            this.dgvNotaCredito.AllowUserToAddRows = false;
            this.dgvNotaCredito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            this.dgvNotaCredito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotaCredito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNotaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaCredito.Location = new System.Drawing.Point(8, 317);
            this.dgvNotaCredito.Name = "dgvNotaCredito";
            this.dgvNotaCredito.ReadOnly = true;
            this.dgvNotaCredito.RowHeadersVisible = false;
            this.dgvNotaCredito.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotaCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotaCredito.Size = new System.Drawing.Size(546, 173);
            this.dgvNotaCredito.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.cmbTipoDocumento);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 54);
            this.panel1.TabIndex = 16;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(380, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(65, 45);
            this.btnFiltrar.TabIndex = 17;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 15);
            this.label23.TabIndex = 10;
            this.label23.Text = "Estado de Pago";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(156, 25);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(98, 20);
            this.dtpDesde.TabIndex = 14;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(9, 25);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(141, 21);
            this.cmbTipoDocumento.TabIndex = 11;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(261, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 15);
            this.label25.TabIndex = 13;
            this.label25.Text = "Hasta";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(153, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 15);
            this.label24.TabIndex = 12;
            this.label24.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(260, 25);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(98, 20);
            this.dtpHasta.TabIndex = 15;
            // 
            // dgvDatosVenta
            // 
            this.dgvDatosVenta.AllowUserToAddRows = false;
            this.dgvDatosVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            this.dgvDatosVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosVenta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVenta.Location = new System.Drawing.Point(8, 82);
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.ReadOnly = true;
            this.dgvDatosVenta.RowHeadersVisible = false;
            this.dgvDatosVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosVenta.Size = new System.Drawing.Size(751, 212);
            this.dgvDatosVenta.TabIndex = 0;
            // 
            // frmClientes
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(791, 634);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClientes_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClientes_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gpbClienteSoporte.ResumeLayout(false);
            this.gpbClienteSoporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMesesSoporte)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaCredito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("CLIENTE"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    private void iniciaClientes()
    {
      this.codigoCliente = 0;
      this.agregarOtraDirecciónAUnClienteToolStripMenuItem.Enabled = false;
      this.txtRut.Enabled = true;
      this.txtDigito.Enabled = true;
      this.txtRut.Clear();
      this.txtDigito.Clear();
      this.txtFantasia.Clear();
      this.txtRazonSocial.Clear();
      this.txtGiro.Clear();
      this.txtDireccion.Clear();
      this.txtTelefono.Clear();
      this.txtFax.Clear();
      this.txtContacto.Clear();
      this.txtEmail.Clear();
      this.txtEmailContacto.Clear();
      this.txtFonoContacto.Clear();
      this.txtObservaciones.Clear();
      this.txtFechaUltimaCompra.Clear();
      this.txtFechaUltimaCompra.Enabled = false;
      this.dtpFechaIngreso.Value.ToShortDateString();
      this.txtRut.Focus();
      this.cmbCiudad.Text = "";
      this.cmbComuna.Text = "";
      this.cargaRubros();
      this.cmbCiudad.Enabled = false;
      this.cmbComuna.Enabled = false;
      this.cmbRubro.Enabled = false;
      this.txtFantasia.Enabled = false;
      this.txtRazonSocial.Enabled = false;
      this.txtGiro.Enabled = false;
      this.txtDireccion.Enabled = false;
      this.txtTelefono.Enabled = false;
      this.txtFax.Enabled = false;
      this.txtContacto.Enabled = false;
      this.txtEmail.Enabled = false;
      this.txtEmailContacto.Enabled = false;
      this.txtFonoContacto.Enabled = false;
      this.txtObservaciones.Enabled = false;
      this.txtFechaUltimaCompra.Enabled = false;
      this.dtpFechaIngreso.Enabled = false;
      this.dtpFechaIngreso.Value = DateTime.Now;
      this.txtDiasPlazo.Enabled = false;
      this.txtDiasPlazo.Text = "0";
      this.txtCredito.Enabled = false;
      this.txtCredito.Clear();
      this.txtCredito.Text = "0";
      this.txtMotivoBloqueo.Clear();
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.cargaListaPrecio();
      this.cmbMedioPago.Enabled = false;
      this.cargaMediosPago();
      this.cargaEstado();
      this.cargaEstadoDocumento();
      this.cmbEstado.Enabled = false;
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvNotaCredito.DataSource = (object) null;
      this.txtTotalDocumentado.Clear();
      this.txtTotalPagado.Clear();
      this.txtTotalPendiente.Clear();
      this.txtTotalUsado.Clear();
      this.txtTotalDisponible.Clear();
      this.txtDeuda.Clear();
      this.dtpInicioSoporte.Enabled = false;
      this.dtpInicioSoporte.Value = DateTime.Now;
      this.nudMesesSoporte.Enabled = false;
      this.nudMesesSoporte.Value = new Decimal(1);
      this.lblDias.Text = "";
      this.panelColorDeuda.BackColor = Color.Transparent;
      if (frmMenuPrincipal._Aptusoft)
        this.gpbClienteSoporte.Visible = true;
      else
        this.gpbClienteSoporte.Visible = false;
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) new MedioPago().listaMediosPagoVenta();
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void cargaEstado()
    {
      TipoVO tipoVo = new TipoVO();
      List<TipoVO> list = new List<TipoVO>();
      tipoVo.IdTipo = 0;
      tipoVo.NombreTipo = "ACTIVO";
      list.Add(tipoVo);
      list.Add(new TipoVO()
      {
        IdTipo = 1,
        NombreTipo = "BLOQUEADO"
      });
      this.cmbEstado.DataSource = (object) list;
      this.cmbEstado.ValueMember = "IdTipo";
      this.cmbEstado.DisplayMember = "NombreTipo";
      this.cmbEstado.SelectedValue = (object) 0;
    }

    private void cargaListaPrecio()
    {
      this.cmbListaPrecio.DataSource = (object) new CargaMaestros().cargaListaPrecio();
      this.cmbListaPrecio.ValueMember = "codigo";
      this.cmbListaPrecio.DisplayMember = "descripcion";
      this.cmbListaPrecio.Enabled = true;
      this.cmbListaPrecio.SelectedValue = (object) 1;
    }

    private void activaCampos()
    {
      this.cmbCiudad.Enabled = true;
      this.cmbComuna.Enabled = true;
      this.cmbRubro.Enabled = true;
      this.txtFantasia.Enabled = true;
      this.txtRazonSocial.Enabled = true;
      this.txtGiro.Enabled = true;
      this.txtDireccion.Enabled = true;
      this.txtTelefono.Enabled = true;
      this.txtFax.Enabled = true;
      this.txtContacto.Enabled = true;
      this.txtEmail.Enabled = true;
      this.txtEmailContacto.Enabled = true;
      this.txtFonoContacto.Enabled = true;
      this.txtObservaciones.Enabled = true;
      this.txtFechaUltimaCompra.Enabled = true;
      this.dtpFechaIngreso.Enabled = true;
      this.txtDiasPlazo.Enabled = true;
      this.txtCredito.Enabled = true;
      this.cmbEstado.Enabled = true;
      this.dtpInicioSoporte.Enabled = true;
      this.nudMesesSoporte.Enabled = true;
      this.cmbMedioPago.Enabled = true;
    }

    private void cargaCiudades()
    {
      this.cmbCiudad.DataSource = (object) null;
      Ciudad ciudad = new Ciudad();
      this.cmbCiudad.SelectedValue = this.cmbCiudad.SelectedValue;
      this.cmbCiudad.DisplayMember = "nombreCiudad";
      this.cmbCiudad.ValueMember = "nombreCiudad";
      this.cmbCiudad.DataSource = (object) ciudad.cosultaCiudad().Tables[0];
    }

    private void cargaComuna()
    {
      this.cmbComuna.DataSource = (object) null;
      Comuna comuna = new Comuna();
      this.cmbComuna.SelectedValue = this.cmbComuna.SelectedValue;
      this.cmbComuna.DisplayMember = "nombreComuna";
      this.cmbComuna.ValueMember = "nombreComuna";
      this.cmbComuna.DataSource = (object) comuna.cosultaComuna().Tables[0];
    }

    private void cargaRubros()
    {
      this.cmbRubro.DataSource = (object) null;
      this.cmbRubro.DisplayMember = "nombreRubro";
      this.cmbRubro.ValueMember = "idRubro";
      this.cmbRubro.DataSource = (object) new Rubro().listaRubrosConSeleccione();
    }

    private void cargaEstadoDocumento()
    {
      this.cmbTipoDocumento.DataSource = (object) new CargaMaestros().cargaEstadosPago();
      this.cmbTipoDocumento.ValueMember = "codigo";
      this.cmbTipoDocumento.DisplayMember = "descripcion";
      this.cmbTipoDocumento.SelectedValue = (object) 0;
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
      this.dgvDatosVenta.Columns[2].Width = 200;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Folio", "Folio");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "Folio";
      this.dgvDatosVenta.Columns[3].Width = 60;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("EstadoPago", "Estado");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "EstadoPago";
      this.dgvDatosVenta.Columns[4].Width = 90;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Total", "Total");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "Total";
      this.dgvDatosVenta.Columns[5].Width = 70;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("TotalPagado", "Pagado");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "TotalPagado";
      this.dgvDatosVenta.Columns[6].Width = 70;
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("TotalDocumentado", "Documen.");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "TotalDocumentado";
      this.dgvDatosVenta.Columns[7].Width = 70;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("TotalPendiente", "Pendiente");
      this.dgvDatosVenta.Columns[8].DataPropertyName = "TotalPendiente";
      this.dgvDatosVenta.Columns[8].Width = 70;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[8].Resizable = DataGridViewTriState.False;
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
      this.dgvNotaCredito.Columns[1].Width = 75;
      this.dgvNotaCredito.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns[1].DefaultCellStyle.Format = "d";
      this.dgvNotaCredito.Columns.Add("DocumentoVenta", "Documento");
      this.dgvNotaCredito.Columns[2].DataPropertyName = "DocumentoVenta";
      this.dgvNotaCredito.Columns[2].Width = 150;
      this.dgvNotaCredito.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns[2].Visible = true;
      this.dgvNotaCredito.Columns.Add("Folio", "Folio");
      this.dgvNotaCredito.Columns[3].DataPropertyName = "Folio";
      this.dgvNotaCredito.Columns[3].Width = 60;
      this.dgvNotaCredito.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNotaCredito.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns.Add("Total", "Total");
      this.dgvNotaCredito.Columns[4].DataPropertyName = "Total";
      this.dgvNotaCredito.Columns[4].Width = 70;
      this.dgvNotaCredito.Columns[4].DefaultCellStyle.Format = "N0";
      this.dgvNotaCredito.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNotaCredito.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns.Add("MontoUsado", "$ Usado");
      this.dgvNotaCredito.Columns[5].DataPropertyName = "MontoUsado";
      this.dgvNotaCredito.Columns[5].Width = 70;
      this.dgvNotaCredito.Columns[5].DefaultCellStyle.Format = "N0";
      this.dgvNotaCredito.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNotaCredito.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvNotaCredito.Columns.Add("MontoDisponible", "$ Disp.");
      this.dgvNotaCredito.Columns[6].DataPropertyName = "MontoDisponible";
      this.dgvNotaCredito.Columns[6].Width = 70;
      this.dgvNotaCredito.Columns[6].DefaultCellStyle.Format = "N0";
      this.dgvNotaCredito.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNotaCredito.Columns[6].Resizable = DataGridViewTriState.False;
    }

    private void ventasCliente(string desde, string hasta)
    {
      Cliente cliente = new Cliente();
      string str1 = " idCliente=" + this.codigoCliente.ToString();
      string str2 = "";
      if (this.cmbTipoDocumento.SelectedValue.ToString() != "0")
        str2 = " AND estadoPago='" + this.cmbTipoDocumento.Text + "'";
      string filtro1 = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "' AND " + str1 + " " + str2;
      string filtro2 = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "' AND " + str1;
      List<Venta> list1 = Enumerable.ToList<Venta>((IEnumerable<Venta>) Enumerable.OrderByDescending<Venta, DateTime>((IEnumerable<Venta>) cliente.ventasCliente(filtro1), (Func<Venta, DateTime>) (p => p.FechaEmision)));
      List<Venta> list2 = cliente.notaCreditoCliente(filtro2);
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      Decimal num6 = new Decimal(0);
      if (list1.Count > 0)
      {
        for (int index = 0; index < list1.Count; ++index)
        {
          list1[index].Linea = index + 1;
          num1 += list1[index].TotalPagado;
          num2 += list1[index].TotalDocumentado;
          num3 += list1[index].TotalPendiente;
        }
        this.dgvDatosVenta.DataSource = (object) list1;
        this.txtTotalPagado.Text = num1.ToString("N0");
        this.txtTotalPendiente.Text = num3.ToString("N0");
        this.txtTotalDocumentado.Text = num2.ToString("N0");
      }
      if (list2.Count > 0)
      {
        for (int index = 0; index < list2.Count; ++index)
        {
          list2[index].Linea = index + 1;
          num4 += list2[index].MontoUsado;
          num5 += list2[index].MontoDisponible;
        }
        this.dgvNotaCredito.DataSource = (object) list2;
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

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modClientes = 0;
      this.Close();
      this.Dispose();
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

    private bool validaCampos()
    {
      if (this.txtRut.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar el Rut");
        this.txtRut.Focus();
        return false;
      }
      if (this.txtDigito.Text.Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar el Digito");
        this.txtDigito.Focus();
        return false;
      }
      if (this.txtRazonSocial.Text.Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar la Razon Social");
      this.txtRazonSocial.Focus();
      return false;
    }

    private void mayuscula()
    {
      this.txtDigito.Text = this.txtDigito.Text.ToUpper();
      this.txtFantasia.Text = this.txtFantasia.Text.ToUpper();
      this.txtRazonSocial.Text = this.txtRazonSocial.Text.ToUpper();
      this.txtGiro.Text = this.txtGiro.Text.ToUpper();
      this.txtDireccion.Text = this.txtDireccion.Text.ToUpper();
      this.txtContacto.Text = this.txtContacto.Text.ToUpper();
      this.txtObservaciones.Text = this.txtObservaciones.Text.ToUpper();
      this.txtEmail.Text = this.txtEmail.Text.ToLower();
      this.txtEmailContacto.Text = this.txtEmailContacto.Text.ToLower();
    }

    private ClienteVO creaCliente()
    {
      this.mayuscula();
      ClienteVO clienteVo = new ClienteVO();
      clienteVo.Codigo = this.codigoCliente;
      clienteVo.Rut = this.txtRut.Text.Trim();
      clienteVo.Digito = this.txtDigito.Text.Trim();
      clienteVo.NomFantasia = this.txtFantasia.Text.Trim();
      clienteVo.RazonSocial = this.txtRazonSocial.Text.Trim();
      clienteVo.Giro = this.txtGiro.Text.Trim();
      clienteVo.NombreRubro = this.cmbRubro.Text.Trim();
      clienteVo.Direccion = this.txtDireccion.Text.Trim();
      clienteVo.Ciudad = this.cmbCiudad.Text.Trim();
      clienteVo.Comuna = this.cmbComuna.Text.Trim();
      clienteVo.Telefono = this.txtTelefono.Text.Trim();
      clienteVo.Fax = this.txtFax.Text.Trim();
      clienteVo.Email = this.txtEmail.Text.Trim();
      clienteVo.Contacto = this.txtContacto.Text.Trim();
      clienteVo.FonoContacto = this.txtFonoContacto.Text.Trim();
      clienteVo.EmailContacto = this.txtEmailContacto.Text.Trim();
      clienteVo.Observaciones = this.txtObservaciones.Text.Trim();
      clienteVo.FechaCreacion = Convert.ToDateTime(this.dtpFechaIngreso.Value.ToShortDateString());
      clienteVo.FechaUltimaCompra = this.txtFechaUltimaCompra.Text;
      clienteVo.DiasPlazo = this.txtDiasPlazo.Text.Length > 0 ? this.txtDiasPlazo.Text.Trim() : "0";
      clienteVo.ListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
      clienteVo.CreditoAprobado = this.txtCredito.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtCredito.Text.Trim()) : new Decimal(0);
      clienteVo.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
      clienteVo.MedioPago = clienteVo.IdMedioPago <= 0 ? "" : this.cmbMedioPago.Text;
      clienteVo.Estado = Convert.ToInt32(this.cmbEstado.SelectedValue.ToString());
      clienteVo.MotivoBloqueo = clienteVo.Estado != 0 ? this.txtMotivoBloqueo.Text.ToUpper() : "";
      clienteVo.InicioSoporte = Convert.ToDateTime(this.dtpInicioSoporte.Value.ToShortDateString());
      clienteVo.MesesSoporte = Convert.ToInt32(this.nudMesesSoporte.Value.ToString());
      return clienteVo;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.validaCampos())
        return;
      if ((!this.chkVerificaRut.Checked ? new ValidaDigito().digitoVerificador(Convert.ToInt32(this.txtRut.Text)) : this.txtDigito.Text.Trim()).Equals(this.txtDigito.Text))
      {
        int num = (int) MessageBox.Show(new Cliente().agregaCliente(this.creaCliente()) ?? "", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaClientes();
      }
      else
      {
        int num1 = (int) MessageBox.Show("El RUT Ingresado no es Valido!!!");
      }
    }

    private void txtRut_Leave(object sender, EventArgs e)
    {
      this.txtRut.BackColor = Color.White;
      this.txtRut.Text = this.txtRut.Text.ToUpper();
    }

    private void txtRut_Enter(object sender, EventArgs e)
    {
      this.txtRut.BackColor = Color.Bisque;
      //if (txtRut.Text.Length > 0)
      //{
      //    clear(true);
      //}
      //else
      //{
      //    clear(false);
      //}
    }

    private void buscaCliente()
    {
      ArrayList arrayList = new ArrayList();
      ArrayList cli = new Cliente().buscaRutCliente(this.txtRut.Text.Trim());
      if (cli.Count > 1)
      {
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "cliente").ShowDialog();
        this.activaCampos();
      }
      else if (cli.Count == 0)
      {
        this.activaCampos();
        this.btnModificar.Enabled = false;
        this.btnEliminar.Enabled = false;
        if (this._guarda)
          this.btnGuardar.Enabled = true;
        this.txtFantasia.Focus();
      }
      else
      {
        if (cli.Count != 1)
          return;
        this.activaCampos();
        this.btnGuardar.Enabled = false;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        foreach (ClienteVO clienteVo in cli)
          this.buscaClienteCodigo(clienteVo.Codigo);
      }
    }

    public void buscaClienteCodigo(int cod)
    {
      this.activaCampos();
      if (this._modifica)
        this.btnModificar.Enabled = true;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      this.agregarOtraDirecciónAUnClienteToolStripMenuItem.Enabled = true;
      Cliente cliente = new Cliente();
      ClienteVO clienteVo = cliente.buscaCodigoCliente(cod);
      this.codigoCliente = clienteVo.Codigo;
      DateTime dateTime = cliente.fechaUltimaCompra(this.codigoCliente);
      string str1 = dateTime.ToShortDateString();
      if (str1.Equals("01/01/0001"))
        this.txtFechaUltimaCompra.Text = "Sin Compras";
      else
        this.txtFechaUltimaCompra.Text = str1;
      dateTime = DateTime.Now;
      string hasta = dateTime.ToString("yyyy-MM-dd");
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.txtFantasia.Text = clienteVo.NomFantasia;
      this.txtGiro.Text = clienteVo.Giro;
      this.cmbRubro.Text = clienteVo.NombreRubro;
      this.txtDireccion.Text = clienteVo.Direccion;
      this.cmbCiudad.Text = clienteVo.Ciudad;
      this.cmbComuna.Text = clienteVo.Comuna;
      this.txtTelefono.Text = clienteVo.Telefono;
      this.txtFax.Text = clienteVo.Fax;
      this.txtEmail.Text = clienteVo.Email;
      this.txtContacto.Text = clienteVo.Contacto;
      this.txtEmailContacto.Text = clienteVo.EmailContacto;
      this.txtFonoContacto.Text = clienteVo.FonoContacto;
      this.txtObservaciones.Text = clienteVo.Observaciones;
      DateTimePicker dateTimePicker = this.dtpFechaIngreso;
      dateTime = clienteVo.FechaCreacion;
      string str2 = dateTime.ToString();
      dateTimePicker.Text = str2;
      dateTime = this.dtpFechaIngreso.Value;
      string desde = dateTime.ToString("yyyy-MM-dd");
      this.dtpDesde.Value = clienteVo.FechaCreacion;
      this.txtDiasPlazo.Text = clienteVo.DiasPlazo;
      this.cmbListaPrecio.SelectedValue = (object) clienteVo.ListaPrecio;
      this.txtCredito.Text = clienteVo.CreditoAprobado.ToString("N0");
      this.cmbEstado.SelectedValue = (object) clienteVo.Estado;
      this.cmbMedioPago.SelectedValue = (object) clienteVo.IdMedioPago;
      if (clienteVo.Estado == 1)
        this.txtMotivoBloqueo.Text = clienteVo.MotivoBloqueo;
      this.txtRut.Enabled = false;
      this.txtDigito.Enabled = false;
      if (frmMenuPrincipal._Aptusoft)
      {
        this.dtpInicioSoporte.Value = clienteVo.InicioSoporte;
        this.nudMesesSoporte.Value = (Decimal) clienteVo.MesesSoporte;
        if (!this.buscaContratoActivo(this.codigoCliente))
          this.fechaSoporte();
      }
      this.ventasCliente(desde, hasta);
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

    private void fechaSoporte()
    {
      string str = "";
      DateTime now = DateTime.Now;
      DateTime dateTime = Convert.ToDateTime(this.dtpInicioSoporte.Value).AddMonths((int) Convert.ToInt16(this.nudMesesSoporte.Value));
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
        this.lblDias.Text = "Fecha de Termino: " + dateTime.ToShortDateString() + "\r\n****SIN SOPORTE ACTIVO****";
        this.lblDias.BackColor = Color.Red;
        this.lblDias.ForeColor = Color.Yellow;
      }
      else
      {
        this.lblDias.Text = "Fecha de Termino: " + dateTime.ToShortDateString() + "\r\nQuedan " + str;
        this.lblDias.BackColor = Color.LightGreen;
        this.lblDias.ForeColor = Color.Blue;
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaClientes();
    }

    private void agregarOtraDirecciónAUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      this.btnEliminar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.txtDireccion.Clear();
      this.cmbCiudad.Text = "";
      this.cmbComuna.Text = "";
      this.txtTelefono.Clear();
      this.txtFax.Clear();
      this.txtEmail.Clear();
      this.txtContacto.Clear();
      this.txtFonoContacto.Clear();
      this.txtEmailContacto.Clear();
      this.txtFechaUltimaCompra.Clear();
      this.txtObservaciones.Clear();
      this.txtCredito.Clear();
    }

    private void frmClientes_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.txtRut.Focused && e.KeyCode == Keys.Return)
        this.txtDigito.Focus();
      else if (this.txtFantasia.Focused && e.KeyCode == Keys.Return)
        this.txtRazonSocial.Focus();
      else if (this.txtRazonSocial.Focused && e.KeyCode == Keys.Return)
        this.txtGiro.Focus();
      else if (this.txtGiro.Focused && e.KeyCode == Keys.Return)
        this.txtDireccion.Focus();
      else if (this.txtDireccion.Focused && e.KeyCode == Keys.Return)
        this.cmbCiudad.Focus();
      else if (this.cmbCiudad.Focused && e.KeyCode == Keys.Return)
        this.cmbComuna.Focus();
      else if (this.cmbCiudad.Focused && e.KeyCode == Keys.Return)
        this.cmbComuna.Focus();
      else if (this.cmbComuna.Focused && e.KeyCode == Keys.Return)
        this.txtTelefono.Focus();
      else if (this.txtTelefono.Focused && e.KeyCode == Keys.Return)
        this.txtFax.Focus();
      else if (this.txtFax.Focused && e.KeyCode == Keys.Return)
        this.txtEmail.Focus();
      else if (this.txtEmail.Focused && e.KeyCode == Keys.Return)
        this.txtContacto.Focus();
      else if (this.txtContacto.Focused && e.KeyCode == Keys.Return)
        this.txtFonoContacto.Focus();
      else if (this.txtFonoContacto.Focused && e.KeyCode == Keys.Return)
      {
        this.txtEmailContacto.Focus();
      }
      else
      {
        if (!this.txtEmailContacto.Focused || e.KeyCode != Keys.Return)
          return;
        this.txtObservaciones.Focus();
      }
    }

    private void txtDigito_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.txtDigito.Text = this.txtDigito.Text.ToUpper();
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      ValidaDigito validaDigito = new ValidaDigito();
      if (this.txtRut.Text.Length > 0)
      {
        if ((!this.chkVerificaRut.Checked ? validaDigito.digitoVerificador(Convert.ToInt32(this.txtRut.Text)) : this.txtDigito.Text.Trim()).Equals(this.txtDigito.Text))
        {
          this.buscaCliente();
        }
        else
        {
          int num1 = (int) MessageBox.Show("El RUT Ingresado no es Valido!!!");
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("Debe Ingresar RUT a Buscar");
        this.txtRut.Focus();
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Modificar este Cliente.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        int num = (int) MessageBox.Show(new Cliente().modificaCliente(this.creaCliente()), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaClientes();
      }
      else
      {
        int num = (int) MessageBox.Show("El Cliente NO fue Modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaClientes();
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar este Cliente.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        int num = (int) MessageBox.Show(new Cliente().eliminaCliente(this.codigoCliente), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaClientes();
      }
      else
      {
        int num = (int) MessageBox.Show("El Cliente NO fue Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaClientes();
      }
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "cliente").ShowDialog();
    }

    private void txtDigito_Leave(object sender, EventArgs e)
    {
      this.txtDigito.BackColor = Color.White;
    }

    private void txtDigito_Enter(object sender, EventArgs e)
    {
      this.txtDigito.BackColor = Color.Bisque;
      //if (txtRut.Text.Length > 0)
      //{
      //    clear(true);
      //}
      //else
      //{
      //    clear(false);
      //}
    }

    private void txtRazonSocial_Leave(object sender, EventArgs e)
    {
      this.txtRazonSocial.BackColor = Color.White;
    }

    private void txtRazonSocial_Enter(object sender, EventArgs e)
    {
      this.txtRazonSocial.BackColor = Color.Bisque;
    }

    private void txtFantasia_Enter(object sender, EventArgs e)
    {
      this.txtFantasia.BackColor = Color.Bisque;
    }

    private void txtFantasia_Leave(object sender, EventArgs e)
    {
      this.txtFantasia.BackColor = Color.White;
    }

    private void txtGiro_Leave(object sender, EventArgs e)
    {
      this.txtGiro.BackColor = Color.White;
    }

    private void txtGiro_Enter(object sender, EventArgs e)
    {
      this.txtGiro.BackColor = Color.Bisque;
    }

    private void txtDireccion_Enter(object sender, EventArgs e)
    {
      this.txtDireccion.BackColor = Color.Bisque;
    }

    private void txtDireccion_Leave(object sender, EventArgs e)
    {
      this.txtDireccion.BackColor = Color.White;
    }

    private void cmbCiudad_Leave(object sender, EventArgs e)
    {
      this.cmbCiudad.BackColor = Color.White;
    }

    private void cmbCiudad_Enter(object sender, EventArgs e)
    {
      this.cargaCiudades();
      this.cmbCiudad.BackColor = Color.Bisque;
    }

    private void cmbComuna_Enter(object sender, EventArgs e)
    {
      this.cargaComuna();
      this.cmbComuna.BackColor = Color.Bisque;
    }

    private void cmbComuna_Leave(object sender, EventArgs e)
    {
      this.cmbComuna.BackColor = Color.White;
    }

    private void txtTelefono_Leave(object sender, EventArgs e)
    {
      this.txtTelefono.BackColor = Color.White;
    }

    private void txtTelefono_Enter(object sender, EventArgs e)
    {
      this.txtTelefono.BackColor = Color.Bisque;
    }

    private void txtFax_Enter(object sender, EventArgs e)
    {
      this.txtFax.BackColor = Color.Bisque;
    }

    private void txtFax_Leave(object sender, EventArgs e)
    {
      this.txtFax.BackColor = Color.White;
    }

    private void txtEmail_Leave(object sender, EventArgs e)
    {
      this.txtEmail.BackColor = Color.White;
      this.txtEmail.Text = this.txtEmail.Text.ToLower();
    }

    private void txtEmail_Enter(object sender, EventArgs e)
    {
      this.txtEmail.BackColor = Color.Bisque;
    }

    private void txtContacto_Enter(object sender, EventArgs e)
    {
      this.txtContacto.BackColor = Color.Bisque;
    }

    private void txtContacto_Leave(object sender, EventArgs e)
    {
      this.txtContacto.BackColor = Color.White;
    }

    private void txtFonoContacto_Leave(object sender, EventArgs e)
    {
      this.txtFonoContacto.BackColor = Color.White;
    }

    private void txtFonoContacto_Enter(object sender, EventArgs e)
    {
      this.txtFonoContacto.BackColor = Color.Bisque;
    }

    private void txtEmailContacto_Enter(object sender, EventArgs e)
    {
      this.txtEmailContacto.BackColor = Color.Bisque;
    }

    private void txtEmailContacto_Leave(object sender, EventArgs e)
    {
      this.txtEmailContacto.BackColor = Color.White;
      this.txtEmailContacto.Text = this.txtEmailContacto.Text.ToLower();
    }

    private void txtObservaciones_Leave(object sender, EventArgs e)
    {
      this.txtObservaciones.BackColor = Color.White;
    }

    private void txtObservaciones_Enter(object sender, EventArgs e)
    {
      this.txtObservaciones.BackColor = Color.Bisque;
    }

    private void dtpFechaIngreso_Enter(object sender, EventArgs e)
    {
      this.dtpFechaIngreso.BackColor = Color.Bisque;
    }

    private void dtpFechaIngreso_Leave(object sender, EventArgs e)
    {
      this.dtpFechaIngreso.BackColor = Color.White;
    }

    private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void txtDiasPlazo_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void label18_Click(object sender, EventArgs e)
    {
    }

    private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modClientes = 0;
    }

    private void txtCredito_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void cmbEstado_SelectedValueChanged(object sender, EventArgs e)
    {
      if (this.cmbEstado.Text == "BLOQUEADO")
      {
        this.cmbMedioPago.Enabled = true;
        this.txtMotivoBloqueo.Enabled = true;
      }
      else
      {
        this.cmbMedioPago.Enabled = false;
        this.txtMotivoBloqueo.Enabled = false;
        this.txtMotivoBloqueo.Clear();
        this.cmbMedioPago.SelectedValue = (object) 0;
      }
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
      this.ventasCliente(this.dtpDesde.Value.ToString("yyyy-MM-dd"), this.dtpHasta.Value.ToString("yyyy-MM-dd"));
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DateTime now = DateTime.Now;
      DateTime dateTime = Convert.ToDateTime(this.dtpInicioSoporte.Value).AddMonths(3);
      int num = dateTime.Day - now.Day;
      this.lblDias.Text = "meses " + (dateTime.Month - now.Month).ToString() + " dias " + num.ToString();
    }

    private void dtpInicioSoporte_ValueChanged(object sender, EventArgs e)
    {
      this.fechaSoporte();
    }

    private void nudMesesSoporte_ValueChanged(object sender, EventArgs e)
    {
      this.fechaSoporte();
    }

    private void txtRut_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtDigito_TextChanged(object sender, EventArgs e)
    {
        
    }
    private void clear(bool load)
    {
        if (load)
        {

            if (MessageBox.Show("Desea limpiar El formulario", "Limpiar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.codigoCliente = 0;
                this.agregarOtraDirecciónAUnClienteToolStripMenuItem.Enabled = false;
                this.txtRut.Enabled = true;
                this.txtDigito.Enabled = true;
                this.txtFantasia.Clear();
                this.txtRazonSocial.Clear();
                this.txtGiro.Clear();
                this.txtDireccion.Clear();
                this.txtTelefono.Clear();
                this.txtFax.Clear();
                this.txtContacto.Clear();
                this.txtEmail.Clear();
                this.txtEmailContacto.Clear();
                this.txtFonoContacto.Clear();
                this.txtObservaciones.Clear();
                this.txtFechaUltimaCompra.Clear();
                this.txtFechaUltimaCompra.Enabled = false;
                this.dtpFechaIngreso.Value.ToShortDateString();
                this.cmbCiudad.Text = "";
                this.cmbComuna.Text = "";
                this.cargaRubros();
                this.cmbCiudad.Enabled = false;
                this.cmbComuna.Enabled = false;
                this.cmbRubro.Enabled = false;
                this.txtFantasia.Enabled = false;
                this.txtRazonSocial.Enabled = false;
                this.txtGiro.Enabled = false;
                this.txtDireccion.Enabled = false;
                this.txtTelefono.Enabled = false;
                this.txtFax.Enabled = false;
                this.txtContacto.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtEmailContacto.Enabled = false;
                this.txtFonoContacto.Enabled = false;
                this.txtObservaciones.Enabled = false;
                this.txtFechaUltimaCompra.Enabled = false;
                this.dtpFechaIngreso.Enabled = false;
                this.dtpFechaIngreso.Value = DateTime.Now;
                this.txtDiasPlazo.Enabled = false;
                this.txtDiasPlazo.Text = "0";
                this.txtCredito.Enabled = false;
                this.txtCredito.Clear();
                this.txtCredito.Text = "0";
                this.txtMotivoBloqueo.Clear();
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.cargaListaPrecio();
                this.cmbMedioPago.Enabled = false;
                this.cargaMediosPago();
                this.cargaEstado();
                this.cargaEstadoDocumento();
                this.cmbEstado.Enabled = false;
                this.dgvDatosVenta.DataSource = (object)null;
                this.dgvNotaCredito.DataSource = (object)null;
                this.txtTotalDocumentado.Clear();
                this.txtTotalPagado.Clear();
                this.txtTotalPendiente.Clear();
                this.txtTotalUsado.Clear();
                this.txtTotalDisponible.Clear();
                this.txtDeuda.Clear();
                this.dtpInicioSoporte.Enabled = false;
                this.dtpInicioSoporte.Value = DateTime.Now;
                this.nudMesesSoporte.Enabled = false;
                this.nudMesesSoporte.Value = new Decimal(1);
                this.lblDias.Text = "";
                this.panelColorDeuda.BackColor = Color.Transparent;
                if (frmMenuPrincipal._Aptusoft)
                    this.gpbClienteSoporte.Visible = true;
                else
                    this.gpbClienteSoporte.Visible = false;
            }
            else
            {
                this.agregarOtraDirecciónAUnClienteToolStripMenuItem.Enabled = false;
                this.txtFechaUltimaCompra.Enabled = false;
                this.dtpFechaIngreso.Value.ToShortDateString();
                this.cmbCiudad.Text = "";
                this.cmbComuna.Text = "";
                this.cargaRubros();
                this.cmbCiudad.Enabled = false;
                this.cmbComuna.Enabled = false;
                this.cmbRubro.Enabled = false;
                this.txtFantasia.Enabled = false;
                this.txtRazonSocial.Enabled = false;
                this.txtGiro.Enabled = false;
                this.txtDireccion.Enabled = false;
                this.txtTelefono.Enabled = false;
                this.txtFax.Enabled = false;
                this.txtContacto.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtEmailContacto.Enabled = false;
                this.txtFonoContacto.Enabled = false;
                this.txtObservaciones.Enabled = false;
                this.txtFechaUltimaCompra.Enabled = false;
                this.dtpFechaIngreso.Enabled = false;
                this.dtpFechaIngreso.Value = DateTime.Now;
                this.txtDiasPlazo.Enabled = false;
                this.txtDiasPlazo.Text = "0";
                this.txtCredito.Enabled = false;
                this.txtCredito.Clear();
                this.txtCredito.Text = "0";
                this.txtMotivoBloqueo.Clear();
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.cargaListaPrecio();
                this.cmbMedioPago.Enabled = false;
                this.cargaMediosPago();
                this.cargaEstado();
                this.cargaEstadoDocumento();
                this.cmbEstado.Enabled = false;
                this.dgvDatosVenta.DataSource = (object)null;
                this.dgvNotaCredito.DataSource = (object)null;
                this.txtTotalDocumentado.Clear();
                this.txtTotalPagado.Clear();
                this.txtTotalPendiente.Clear();
                this.txtTotalUsado.Clear();
                this.txtTotalDisponible.Clear();
                this.txtDeuda.Clear();
                this.dtpInicioSoporte.Enabled = false;
                this.dtpInicioSoporte.Value = DateTime.Now;
                this.nudMesesSoporte.Enabled = false;
                this.nudMesesSoporte.Value = new Decimal(1);
                this.lblDias.Text = "";
                this.panelColorDeuda.BackColor = Color.Transparent;
                if (frmMenuPrincipal._Aptusoft)
                    this.gpbClienteSoporte.Visible = true;
                else
                    this.gpbClienteSoporte.Visible = false;
            }
        }
    }
  }
}
