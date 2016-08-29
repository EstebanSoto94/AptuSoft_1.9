 
// Type: Aptusoft.frmPreCliente
 
 
// version 1.8.0

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmPreCliente : Form
  {
    private IContainer components = (IContainer) null;
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private GroupBox groupBox1;
    private TextBox txtEmail3;
    private TextBox txtTelefono3;
    private Label label13;
    private Label label14;
    private TextBox txtEmail2;
    private TextBox txtTelefono2;
    private Label label9;
    private Label label12;
    private Button btnBuscaCliente;
    private TextBox txtFantasia;
    private TextBox txtDigito;
    private TextBox txtRut;
    private TextBox txtContacto;
    private Label label5;
    private TextBox txtEmail;
    private Label label6;
    private Label label7;
    private TextBox txtTelefono;
    private TextBox txtGiro;
    private Label label8;
    private TextBox txtRazonSocial;
    private ComboBox cmbComuna;
    private Label label4;
    private Label label3;
    private ComboBox cmbCiudad;
    private Label label2;
    private Label label10;
    private Label label1;
    private TextBox txtDireccion;
    private Label label11;
    private Label label15;
    private DateTimePicker dtpFechaIngreso;
    private GroupBox groupBox2;
    private TextBox txtProcedencia;
    private ComboBox cmbVendedor;
    private Label label16;
    private Label label29;
    private ComboBox cmbSemaforo;
    private Label label17;
    private Panel panelSemaforo;
    private Button btnPasarACliente;
    private GroupBox groupBox3;
    private Button btnGuardar;
    private Button btnSalir;
    private Button btnModificar;
    private Button btnLimpiar;
    private Button btnEliminar;
    private Label lblActivo;
    private frmPreCliente intance;
    private int codigoCliente;

    public frmPreCliente()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaClientes();
      this.intance = this;
    }

    public frmPreCliente(int cod)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaClientes();
      this.intance = this;
      this.codigoCliente = cod;
      this.buscaClienteCodigo(this.codigoCliente);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.txtEmail3 = new TextBox();
      this.txtTelefono3 = new TextBox();
      this.label13 = new Label();
      this.label14 = new Label();
      this.txtEmail2 = new TextBox();
      this.txtTelefono2 = new TextBox();
      this.label9 = new Label();
      this.label12 = new Label();
      this.btnBuscaCliente = new Button();
      this.txtFantasia = new TextBox();
      this.txtDigito = new TextBox();
      this.txtRut = new TextBox();
      this.txtContacto = new TextBox();
      this.label5 = new Label();
      this.txtEmail = new TextBox();
      this.label6 = new Label();
      this.label7 = new Label();
      this.txtTelefono = new TextBox();
      this.txtGiro = new TextBox();
      this.label8 = new Label();
      this.txtRazonSocial = new TextBox();
      this.cmbComuna = new ComboBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.cmbCiudad = new ComboBox();
      this.label2 = new Label();
      this.label10 = new Label();
      this.label1 = new Label();
      this.txtDireccion = new TextBox();
      this.label11 = new Label();
      this.label15 = new Label();
      this.dtpFechaIngreso = new DateTimePicker();
      this.groupBox2 = new GroupBox();
      this.cmbSemaforo = new ComboBox();
      this.panelSemaforo = new Panel();
      this.label17 = new Label();
      this.txtProcedencia = new TextBox();
      this.cmbVendedor = new ComboBox();
      this.label16 = new Label();
      this.label29 = new Label();
      this.btnPasarACliente = new Button();
      this.groupBox3 = new GroupBox();
      this.btnGuardar = new Button();
      this.btnSalir = new Button();
      this.btnModificar = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.lblActivo = new Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.txtEmail3);
      this.groupBox1.Controls.Add((Control) this.txtTelefono3);
      this.groupBox1.Controls.Add((Control) this.label13);
      this.groupBox1.Controls.Add((Control) this.label14);
      this.groupBox1.Controls.Add((Control) this.txtEmail2);
      this.groupBox1.Controls.Add((Control) this.txtTelefono2);
      this.groupBox1.Controls.Add((Control) this.label9);
      this.groupBox1.Controls.Add((Control) this.label12);
      this.groupBox1.Controls.Add((Control) this.btnBuscaCliente);
      this.groupBox1.Controls.Add((Control) this.txtFantasia);
      this.groupBox1.Controls.Add((Control) this.txtDigito);
      this.groupBox1.Controls.Add((Control) this.txtRut);
      this.groupBox1.Controls.Add((Control) this.txtContacto);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.txtEmail);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.txtTelefono);
      this.groupBox1.Controls.Add((Control) this.txtGiro);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.txtRazonSocial);
      this.groupBox1.Controls.Add((Control) this.cmbComuna);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.cmbCiudad);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label10);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.txtDireccion);
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Location = new Point(0, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(423, 401);
      this.groupBox1.TabIndex = 23;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Datos";
      this.txtEmail3.Location = new Point(152, 369);
      this.txtEmail3.Name = "txtEmail3";
      this.txtEmail3.Size = new Size(263, 20);
      this.txtEmail3.TabIndex = 15;
      this.txtTelefono3.Location = new Point(8, 369);
      this.txtTelefono3.Name = "txtTelefono3";
      this.txtTelefono3.Size = new Size(132, 20);
      this.txtTelefono3.TabIndex = 14;
      this.label13.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.ForeColor = Color.White;
      this.label13.Location = new Point(8, 353);
      this.label13.Name = "label13";
      this.label13.Size = new Size(131, 16);
      this.label13.TabIndex = 21;
      this.label13.Text = "Telefono 3";
      this.label14.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.White;
      this.label14.Location = new Point(152, 353);
      this.label14.Name = "label14";
      this.label14.Size = new Size(263, 16);
      this.label14.TabIndex = 22;
      this.label14.Text = "Email 3";
      this.txtEmail2.Location = new Point(152, 327);
      this.txtEmail2.Name = "txtEmail2";
      this.txtEmail2.Size = new Size(263, 20);
      this.txtEmail2.TabIndex = 13;
      this.txtTelefono2.Location = new Point(8, 327);
      this.txtTelefono2.Name = "txtTelefono2";
      this.txtTelefono2.Size = new Size(132, 20);
      this.txtTelefono2.TabIndex = 12;
      this.label9.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = Color.White;
      this.label9.Location = new Point(8, 311);
      this.label9.Name = "label9";
      this.label9.Size = new Size(131, 16);
      this.label9.TabIndex = 17;
      this.label9.Text = "Telefono 2";
      this.label12.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.ForeColor = Color.White;
      this.label12.Location = new Point(152, 311);
      this.label12.Name = "label12";
      this.label12.Size = new Size(263, 16);
      this.label12.TabIndex = 18;
      this.label12.Text = "Email 2";
      this.btnBuscaCliente.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaCliente.Location = new Point(316, 57);
      this.btnBuscaCliente.Name = "btnBuscaCliente";
      this.btnBuscaCliente.Size = new Size(97, 37);
      this.btnBuscaCliente.TabIndex = 16;
      this.btnBuscaCliente.Text = "Buscar Cliente";
      this.btnBuscaCliente.UseVisualStyleBackColor = true;
      this.btnBuscaCliente.Click += new EventHandler(this.btnBuscaCliente_Click);
      this.txtFantasia.CharacterCasing = CharacterCasing.Upper;
      this.txtFantasia.Location = new Point(143, 32);
      this.txtFantasia.Name = "txtFantasia";
      this.txtFantasia.Size = new Size(272, 20);
      this.txtFantasia.TabIndex = 3;
      this.txtDigito.CharacterCasing = CharacterCasing.Upper;
      this.txtDigito.Location = new Point(97, 32);
      this.txtDigito.MaxLength = 1;
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(31, 20);
      this.txtDigito.TabIndex = 2;
      this.txtDigito.Tag = (object) "Pulse Enter";
      this.txtRut.CharacterCasing = CharacterCasing.Upper;
      this.txtRut.Location = new Point(7, 32);
      this.txtRut.MaxLength = 8;
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(88, 20);
      this.txtRut.TabIndex = 1;
      this.txtContacto.CharacterCasing = CharacterCasing.Upper;
      this.txtContacto.Location = new Point(7, 242);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(408, 20);
      this.txtContacto.TabIndex = 9;
      this.label5.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(7, 142);
      this.label5.Name = "label5";
      this.label5.Size = new Size(403, 16);
      this.label5.TabIndex = 0;
      this.label5.Text = "Direccíon";
      this.txtEmail.Location = new Point(152, 286);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(263, 20);
      this.txtEmail.TabIndex = 11;
      this.label6.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(7, 183);
      this.label6.Name = "label6";
      this.label6.Size = new Size(217, 16);
      this.label6.TabIndex = 1;
      this.label6.Text = "Ciudad";
      this.label7.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = Color.White;
      this.label7.Location = new Point(231, 183);
      this.label7.Name = "label7";
      this.label7.Size = new Size(181, 16);
      this.label7.TabIndex = 2;
      this.label7.Text = "Comuna";
      this.txtTelefono.Location = new Point(8, 286);
      this.txtTelefono.Name = "txtTelefono";
      this.txtTelefono.Size = new Size(132, 20);
      this.txtTelefono.TabIndex = 10;
      this.txtGiro.CharacterCasing = CharacterCasing.Upper;
      this.txtGiro.Location = new Point(7, 119);
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new Size(405, 20);
      this.txtGiro.TabIndex = 5;
      this.label8.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = Color.White;
      this.label8.Location = new Point(8, 270);
      this.label8.Name = "label8";
      this.label8.Size = new Size(131, 16);
      this.label8.TabIndex = 3;
      this.label8.Text = "Telefono 1";
      this.txtRazonSocial.CharacterCasing = CharacterCasing.Upper;
      this.txtRazonSocial.Location = new Point(7, 74);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(301, 20);
      this.txtRazonSocial.TabIndex = 4;
      this.cmbComuna.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbComuna.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbComuna.FormattingEnabled = true;
      this.cmbComuna.Location = new Point(231, 199);
      this.cmbComuna.Name = "cmbComuna";
      this.cmbComuna.Size = new Size(181, 21);
      this.cmbComuna.TabIndex = 8;
      this.label4.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(7, 103);
      this.label4.Name = "label4";
      this.label4.Size = new Size(405, 16);
      this.label4.TabIndex = 3;
      this.label4.Text = "Giro";
      this.label3.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(143, 16);
      this.label3.Name = "label3";
      this.label3.Size = new Size(272, 16);
      this.label3.TabIndex = 2;
      this.label3.Text = "Nombre de Fantasia";
      this.cmbCiudad.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbCiudad.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbCiudad.FormattingEnabled = true;
      this.cmbCiudad.Location = new Point(7, 199);
      this.cmbCiudad.Name = "cmbCiudad";
      this.cmbCiudad.Size = new Size(217, 21);
      this.cmbCiudad.TabIndex = 7;
      this.label2.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(7, 58);
      this.label2.Name = "label2";
      this.label2.Size = new Size(301, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nombre o Razon Social";
      this.label10.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = Color.White;
      this.label10.Location = new Point(152, 270);
      this.label10.Name = "label10";
      this.label10.Size = new Size(263, 16);
      this.label10.TabIndex = 5;
      this.label10.Text = "Email 1";
      this.label1.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.WhiteSmoke;
      this.label1.Location = new Point(7, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(120, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "R.U.T";
      this.txtDireccion.CharacterCasing = CharacterCasing.Upper;
      this.txtDireccion.Location = new Point(7, 158);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new Size(403, 20);
      this.txtDireccion.TabIndex = 6;
      this.label11.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.White;
      this.label11.Location = new Point(7, 226);
      this.label11.Name = "label11";
      this.label11.Size = new Size(408, 16);
      this.label11.TabIndex = 6;
      this.label11.Text = "Contacto";
      this.label15.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.White;
      this.label15.Location = new Point(6, 16);
      this.label15.Name = "label15";
      this.label15.Size = new Size(147, 16);
      this.label15.TabIndex = 24;
      this.label15.Text = "Fecha de Ingreso";
      this.dtpFechaIngreso.Format = DateTimePickerFormat.Short;
      this.dtpFechaIngreso.Location = new Point(6, 32);
      this.dtpFechaIngreso.Name = "dtpFechaIngreso";
      this.dtpFechaIngreso.Size = new Size(147, 20);
      this.dtpFechaIngreso.TabIndex = 25;
      this.groupBox2.Controls.Add((Control) this.cmbSemaforo);
      this.groupBox2.Controls.Add((Control) this.panelSemaforo);
      this.groupBox2.Controls.Add((Control) this.label17);
      this.groupBox2.Controls.Add((Control) this.txtProcedencia);
      this.groupBox2.Controls.Add((Control) this.cmbVendedor);
      this.groupBox2.Controls.Add((Control) this.label16);
      this.groupBox2.Controls.Add((Control) this.label29);
      this.groupBox2.Controls.Add((Control) this.label15);
      this.groupBox2.Controls.Add((Control) this.dtpFechaIngreso);
      this.groupBox2.Location = new Point(429, 6);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(159, 262);
      this.groupBox2.TabIndex = 26;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Datos Comerciales";
      this.cmbSemaforo.DrawMode = DrawMode.OwnerDrawFixed;
      this.cmbSemaforo.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbSemaforo.FormattingEnabled = true;
      this.cmbSemaforo.Location = new Point(5, 163);
      this.cmbSemaforo.Name = "cmbSemaforo";
      this.cmbSemaforo.Size = new Size(147, 21);
      this.cmbSemaforo.TabIndex = 33;
      this.cmbSemaforo.DrawItem += new DrawItemEventHandler(this.cmbSemaforo_DrawItem);
      this.cmbSemaforo.SelectedIndexChanged += new EventHandler(this.cmbSemaforo_SelectedIndexChanged);
      this.panelSemaforo.Location = new Point(6, 190);
      this.panelSemaforo.Name = "panelSemaforo";
      this.panelSemaforo.Size = new Size(147, 52);
      this.panelSemaforo.TabIndex = 35;
      this.label17.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = Color.White;
      this.label17.Location = new Point(5, 147);
      this.label17.Name = "label17";
      this.label17.Size = new Size(148, 16);
      this.label17.TabIndex = 34;
      this.label17.Text = "Tipo de Cliente";
      this.txtProcedencia.CharacterCasing = CharacterCasing.Upper;
      this.txtProcedencia.Location = new Point(6, 119);
      this.txtProcedencia.Name = "txtProcedencia";
      this.txtProcedencia.Size = new Size(147, 20);
      this.txtProcedencia.TabIndex = 26;
      this.cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVendedor.FormattingEnabled = true;
      this.cmbVendedor.Location = new Point(6, 74);
      this.cmbVendedor.Name = "cmbVendedor";
      this.cmbVendedor.Size = new Size(147, 21);
      this.cmbVendedor.TabIndex = 31;
      this.label16.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = Color.White;
      this.label16.Location = new Point(6, 103);
      this.label16.Name = "label16";
      this.label16.Size = new Size(147, 16);
      this.label16.TabIndex = 25;
      this.label16.Text = "Procedencia";
      this.label29.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label29.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label29.ForeColor = Color.White;
      this.label29.Location = new Point(6, 58);
      this.label29.Name = "label29";
      this.label29.Size = new Size(148, 16);
      this.label29.TabIndex = 32;
      this.label29.Text = "Vendedor";
      this.btnPasarACliente.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnPasarACliente.Location = new Point(434, 272);
      this.btnPasarACliente.Name = "btnPasarACliente";
      this.btnPasarACliente.Size = new Size(148, 49);
      this.btnPasarACliente.TabIndex = 36;
      this.btnPasarACliente.Text = "Pasar de PreCliente a Cliente";
      this.btnPasarACliente.UseVisualStyleBackColor = true;
      this.btnPasarACliente.Click += new EventHandler(this.btnPasarACliente_Click);
      this.groupBox3.Controls.Add((Control) this.btnGuardar);
      this.groupBox3.Controls.Add((Control) this.btnSalir);
      this.groupBox3.Controls.Add((Control) this.btnModificar);
      this.groupBox3.Controls.Add((Control) this.btnLimpiar);
      this.groupBox3.Controls.Add((Control) this.btnEliminar);
      this.groupBox3.Location = new Point(591, 6);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(87, 403);
      this.groupBox3.TabIndex = 37;
      this.groupBox3.TabStop = false;
      this.btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Location = new Point(6, 19);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(74, 40);
      this.btnGuardar.TabIndex = 17;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(6, 357);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(74, 40);
      this.btnSalir.TabIndex = 21;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnModificar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnModificar.Location = new Point(6, 63);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(74, 40);
      this.btnModificar.TabIndex = 18;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Location = new Point(7, 151);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(74, 40);
      this.btnLimpiar.TabIndex = 20;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnEliminar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnEliminar.Location = new Point(6, 107);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(74, 40);
      this.btnEliminar.TabIndex = 19;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.lblActivo.BackColor = Color.Red;
      this.lblActivo.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblActivo.ForeColor = Color.White;
      this.lblActivo.Location = new Point(428, 329);
      this.lblActivo.Name = "lblActivo";
      this.lblActivo.Size = new Size(160, 66);
      this.lblActivo.TabIndex = 38;
      this.lblActivo.Text = "Cliente Desactivado";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(681, 410);
      this.Controls.Add((Control) this.lblActivo);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.btnPasarACliente);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmPreCliente";
      this.ShowIcon = false;
      this.Text = " Pre-Cliente";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);
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

    private void cargaVendedores()
    {
      this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
      this.cmbVendedor.ValueMember = "idVendedor";
      this.cmbVendedor.DisplayMember = "nombre";
      this.cmbVendedor.SelectedValue = (object) 0;
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

    private void iniciaClientes()
    {
      this.codigoCliente = 0;
      this.txtRut.Clear();
      this.txtDigito.Clear();
      this.txtFantasia.Clear();
      this.txtRazonSocial.Clear();
      this.txtGiro.Clear();
      this.txtDireccion.Clear();
      this.txtContacto.Clear();
      this.txtTelefono.Clear();
      this.txtEmail.Clear();
      this.txtTelefono2.Clear();
      this.txtEmail2.Clear();
      this.txtTelefono3.Clear();
      this.txtEmail3.Clear();
      this.txtProcedencia.Clear();
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.cargaColores();
      this.cargaCiudades();
      this.cargaComuna();
      this.cmbSemaforo.SelectedIndex = 0;
      this.cargaVendedores();
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnPasarACliente.Enabled = false;
      this.lblActivo.Visible = false;
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
      if (str.Equals("Blue"))
        str = "Azul";
      graphics.DrawString(str, font, Brushes.Black, (float) bounds.X, (float) bounds.Top);
      graphics.FillRectangle(brush, bounds.X + 80, bounds.Y + 5, bounds.Width + 10, bounds.Height - 4);
    }

    private void cargaColores()
    {
      this.cmbSemaforo.Items.Clear();
      foreach (PropertyInfo propertyInfo in typeof (Color).GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public))
      {
        if (propertyInfo.Name.Equals("Red") || propertyInfo.Name.Equals("Green") || propertyInfo.Name.Equals("Yellow") || propertyInfo.Name.Equals("Blue"))
          this.cmbSemaforo.Items.Add((object) propertyInfo.Name);
      }
    }

    private void cmbSemaforo_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.panelSemaforo.BackColor = Color.FromName(this.cmbSemaforo.SelectedItem.ToString());
    }

    public void buscaClienteCodigo(int cod)
    {
      if (this._modifica)
        this.btnModificar.Enabled = true;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      this.btnPasarACliente.Enabled = true;
      this.btnGuardar.Enabled = false;
      ClienteVO clienteVo = new PreCliente().buscaCodigoCliente(cod);
      this.codigoCliente = clienteVo.Codigo;
      DateTime.Now.ToString("yyyy-MM-dd");
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.txtFantasia.Text = clienteVo.NomFantasia;
      this.txtGiro.Text = clienteVo.Giro;
      this.txtDireccion.Text = clienteVo.Direccion;
      this.cmbCiudad.Text = clienteVo.Ciudad;
      this.cmbComuna.Text = clienteVo.Comuna;
      this.txtContacto.Text = clienteVo.Contacto;
      this.dtpFechaIngreso.Text = clienteVo.FechaCreacion.ToString();
      this.txtTelefono.Text = clienteVo.Telefono;
      this.txtEmail.Text = clienteVo.Email;
      this.txtTelefono2.Text = clienteVo.Telefono2;
      this.txtEmail2.Text = clienteVo.Email2;
      this.txtTelefono3.Text = clienteVo.Telefono3;
      this.txtEmail3.Text = clienteVo.Email3;
      this.cmbVendedor.Text = clienteVo.Vendedor;
      this.txtProcedencia.Text = clienteVo.Procedencia;
      string tipoCliente = clienteVo.TipoCliente;
      if (tipoCliente.Equals("Green"))
        this.cmbSemaforo.SelectedIndex = 0;
      if (tipoCliente.Equals("Red"))
        this.cmbSemaforo.SelectedIndex = 1;
      if (tipoCliente.Equals("Yellow"))
        this.cmbSemaforo.SelectedIndex = 2;
      if (clienteVo.Activo)
        this.lblActivo.Visible = true;
      else
        this.lblActivo.Visible = false;
    }

    private ClienteVO creaCliente()
    {
      return new ClienteVO()
      {
        Codigo = this.codigoCliente,
        Rut = this.txtRut.Text.Trim(),
        Digito = this.txtDigito.Text.Trim(),
        NomFantasia = this.txtFantasia.Text.Trim(),
        RazonSocial = this.txtRazonSocial.Text.Trim(),
        Giro = this.txtGiro.Text.Trim(),
        Direccion = this.txtDireccion.Text.Trim(),
        Ciudad = this.cmbCiudad.Text.Trim(),
        Comuna = this.cmbComuna.Text.Trim(),
        Contacto = this.txtContacto.Text.Trim(),
        Telefono = this.txtTelefono.Text.Trim(),
        Email = this.txtEmail.Text.Trim(),
        Telefono2 = this.txtTelefono2.Text.Trim(),
        Email2 = this.txtEmail2.Text.Trim(),
        Telefono3 = this.txtTelefono3.Text.Trim(),
        Email3 = this.txtEmail3.Text.Trim(),
        FechaCreacion = this.dtpFechaIngreso.Value,
        Vendedor = this.cmbVendedor.Text,
        Procedencia = this.txtProcedencia.Text,
        TipoCliente = this.cmbSemaforo.Text
      };
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtRazonSocial.Text.Trim().Length > 0)
        {
          new PreCliente().agregaCliente(this.creaCliente());
          int num = (int) MessageBox.Show("PreCliente Creado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaClientes();
        }
        else
        {
          int num1 = (int) MessageBox.Show("Debe Ingresar un Nombre al Cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error" + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Modificar este Cliente.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          if (this.txtRazonSocial.Text.Trim().Length > 0)
          {
            new PreCliente().modificaCliente(this.creaCliente());
            int num = (int) MessageBox.Show("Pre-Cliente Modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaClientes();
          }
          else
          {
            int num1 = (int) MessageBox.Show("Debe Ingresar un Nombre al Cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error" + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
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
        int num = (int) MessageBox.Show(new PreCliente().eliminaCliente(this.codigoCliente), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaClientes();
      }
      else
      {
        int num = (int) MessageBox.Show("El Cliente NO fue Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaClientes();
      }
    }

    private void btnPasarACliente_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Pasar de Pre-Cliente a Cliente.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        ClienteVO cliVO = new PreCliente().buscaCodigoCliente(this.codigoCliente);
        if (cliVO.Rut.Length > 0 && cliVO.Digito.Length > 0 && cliVO.RazonSocial.Length > 0)
        {
          ArrayList arrayList = new ArrayList();
          if (new Cliente().buscaRutCliente(cliVO.Rut).Count == 0)
          {
            cliVO.InicioSoporte = DateTime.Now;
            cliVO.MesesSoporte = 1;
            cliVO.ListaPrecio = 1;
            new Cliente().agregaCliente(cliVO);
            new PreCliente().desactivaCliente(this.codigoCliente);
            int num = (int) MessageBox.Show("Pre-Cliente pasado a Cliente ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaClientes();
          }
          else
          {
            int num1 = (int) MessageBox.Show("Ya Existe un cliente con mismo Rut", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("Debe Ingresar Rut y Razon Social", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("El Pre-Cliente NO fue pasado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaClientes();
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaClientes();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaPreClientes(ref this.intance, "precliente").ShowDialog();
    }
  }
}
