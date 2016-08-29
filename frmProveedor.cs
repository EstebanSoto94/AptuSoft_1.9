 
// Type: Aptusoft.frmProveedor
 
 
// version 1.8.0

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmProveedor : Form
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
    private Button btnBuscaCliente;
    private Label label18;
    private CheckBox chkVerificaRut;
    private frmProveedor intance;
    private int codigoProveedor;

    public frmProveedor()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaProveedor();
      this.intance = this;
    }

    public frmProveedor(string r, string d)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaProveedor();
      this.intance = this;
      this.txtRut.Text = r.ToString();
      this.txtDigito.Text = d.ToString().ToUpper();
      if ((!this.chkVerificaRut.Checked ? new ValidaDigito().digitoVerificador(Convert.ToInt32(this.txtRut.Text)) : this.txtDigito.Text.Trim()).Equals(this.txtDigito.Text))
      {
        this.buscaProveedor();
      }
      else
      {
        int num = (int) MessageBox.Show("El RUT Ingresado no es Valido!!!");
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 460);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // chkVerificaRut
            // 
            this.chkVerificaRut.AutoSize = true;
            this.chkVerificaRut.Location = new System.Drawing.Point(10, 56);
            this.chkVerificaRut.Name = "chkVerificaRut";
            this.chkVerificaRut.Size = new System.Drawing.Size(109, 17);
            this.chkVerificaRut.TabIndex = 18;
            this.chkVerificaRut.Text = "NO Verificar RUT";
            this.chkVerificaRut.UseVisualStyleBackColor = true;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.Location = new System.Drawing.Point(334, 80);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(79, 36);
            this.btnBuscaCliente.TabIndex = 16;
            this.btnBuscaCliente.Text = "Buscar";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtEmailContacto
            // 
            this.txtEmailContacto.Location = new System.Drawing.Point(7, 341);
            this.txtEmailContacto.Name = "txtEmailContacto";
            this.txtEmailContacto.Size = new System.Drawing.Size(208, 20);
            this.txtEmailContacto.TabIndex = 14;
            this.txtEmailContacto.Enter += new System.EventHandler(this.txtEmailContacto_Enter);
            this.txtEmailContacto.Leave += new System.EventHandler(this.txtEmailContacto_Leave);
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(143, 32);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(272, 20);
            this.txtFantasia.TabIndex = 3;
            this.txtFantasia.Enter += new System.EventHandler(this.txtFantasia_Enter);
            this.txtFantasia.Leave += new System.EventHandler(this.txtFantasia_Leave);
            // 
            // txtFonoContacto
            // 
            this.txtFonoContacto.Location = new System.Drawing.Point(231, 301);
            this.txtFonoContacto.Name = "txtFonoContacto";
            this.txtFonoContacto.Size = new System.Drawing.Size(100, 20);
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
            this.txtDigito.Enter += new System.EventHandler(this.txtDigito_Enter);
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            this.txtDigito.Leave += new System.EventHandler(this.txtDigito_Leave);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(7, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 16);
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
            this.txtRut.Enter += new System.EventHandler(this.txtRut_Enter);
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            this.txtRut.Leave += new System.EventHandler(this.txtRut_Leave);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(7, 301);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(211, 20);
            this.txtContacto.TabIndex = 12;
            this.txtContacto.Enter += new System.EventHandler(this.txtContacto_Enter);
            this.txtContacto.Leave += new System.EventHandler(this.txtContacto_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direccíon";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(231, 261);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(7, 384);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(407, 63);
            this.txtObservaciones.TabIndex = 15;
            this.txtObservaciones.Enter += new System.EventHandler(this.txtObservaciones_Enter);
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ciudad";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(119, 261);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 10;
            this.txtFax.Enter += new System.EventHandler(this.txtFax_Enter);
            this.txtFax.Leave += new System.EventHandler(this.txtFax_Leave);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(217, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Comuna";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(7, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(404, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Observaciones";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(7, 261);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(102, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(7, 138);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(405, 20);
            this.txtGiro.TabIndex = 5;
            this.txtGiro.Enter += new System.EventHandler(this.txtGiro_Enter);
            this.txtGiro.Leave += new System.EventHandler(this.txtGiro_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telefono";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(7, 96);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(321, 20);
            this.txtRazonSocial.TabIndex = 4;
            this.txtRazonSocial.Enter += new System.EventHandler(this.txtRazonSocial_Enter);
            this.txtRazonSocial.Leave += new System.EventHandler(this.txtRazonSocial_Leave);
            // 
            // cmbComuna
            // 
            this.cmbComuna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbComuna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Location = new System.Drawing.Point(217, 218);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(195, 21);
            this.cmbComuna.TabIndex = 8;
            this.cmbComuna.Enter += new System.EventHandler(this.cmbComuna_Enter);
            this.cmbComuna.Leave += new System.EventHandler(this.cmbComuna_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giro";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(118, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fax";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Fantasia";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(7, 218);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(195, 21);
            this.cmbCiudad.TabIndex = 7;
            this.cmbCiudad.Enter += new System.EventHandler(this.cmbCiudad_Enter);
            this.cmbCiudad.Leave += new System.EventHandler(this.cmbCiudad_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre o Razon Social";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(231, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.U.T";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(7, 177);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(403, 20);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(231, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Fono Contacto";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Contacto";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(444, 241);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(127, 20);
            this.dtpFechaIngreso.TabIndex = 16;
            this.dtpFechaIngreso.Enter += new System.EventHandler(this.dtpFechaIngreso_Enter);
            this.dtpFechaIngreso.Leave += new System.EventHandler(this.dtpFechaIngreso_Leave);
            // 
            // txtFechaUltimaCompra
            // 
            this.txtFechaUltimaCompra.Location = new System.Drawing.Point(444, 286);
            this.txtFechaUltimaCompra.Name = "txtFechaUltimaCompra";
            this.txtFechaUltimaCompra.ReadOnly = true;
            this.txtFechaUltimaCompra.Size = new System.Drawing.Size(127, 20);
            this.txtFechaUltimaCompra.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(444, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Fecha Ultima Compra";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(444, 225);
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
            this.btnGuardar.Size = new System.Drawing.Size(115, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(6, 48);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(6, 77);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(6, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(6, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(444, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 173);
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
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(12, 503);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(559, 33);
            this.label18.TabIndex = 26;
            this.label18.Text = "PROVEEDORES";
            // 
            // frmProveedor
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(580, 544);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtFechaUltimaCompra);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmProveedor";
            this.ShowIcon = false;
            this.Text = "Modulo Proveedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProveedor_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClientes_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("PROVEEDOR"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }
    private void clear(bool load)
    {
        if (load)
        {
            if (MessageBox.Show("Desea limpiar El formulario", "Limpiar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.codigoProveedor = 0;
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
                this.cmbCiudad.Enabled = false;
                this.cmbComuna.Enabled = false;
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
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
            else
            {
                this.txtFechaUltimaCompra.Enabled = false;
                this.dtpFechaIngreso.Value.ToShortDateString();
                this.cmbCiudad.Enabled = false;
                this.cmbComuna.Enabled = false;
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
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
        }
    }
    private void iniciaProveedor()
    {
      this.codigoProveedor = 0;
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
      this.cmbCiudad.Enabled = false;
      this.cmbComuna.Enabled = false;
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
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
    }

    private void activaCampos()
    {
      this.cmbCiudad.Enabled = true;
      this.cmbComuna.Enabled = true;
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

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modProveedor = 0;
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
    }

    private ClienteVO creaProveedor()
    {
      this.mayuscula();
      return new ClienteVO()
      {
        Codigo = this.codigoProveedor,
        Rut = this.txtRut.Text.Trim(),
        Digito = this.txtDigito.Text.Trim(),
        NomFantasia = this.txtFantasia.Text.Trim(),
        RazonSocial = this.txtRazonSocial.Text.Trim(),
        Giro = this.txtGiro.Text.Trim(),
        Direccion = this.txtDireccion.Text.Trim(),
        Ciudad = this.cmbCiudad.Text.Trim(),
        Comuna = this.cmbComuna.Text.Trim(),
        Telefono = this.txtTelefono.Text.Trim(),
        Fax = this.txtFax.Text.Trim(),
        Email = this.txtEmail.Text.Trim(),
        Contacto = this.txtContacto.Text.Trim(),
        FonoContacto = this.txtFonoContacto.Text.Trim(),
        EmailContacto = this.txtEmailContacto.Text.Trim(),
        Observaciones = this.txtObservaciones.Text.Trim(),
        FechaCreacion = Convert.ToDateTime(this.dtpFechaIngreso.Value.ToShortDateString()),
        FechaUltimaCompra = this.txtFechaUltimaCompra.Text
      };
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.validaCampos())
        return;
      if ((!this.chkVerificaRut.Checked ? new ValidaDigito().digitoVerificador(Convert.ToInt32(this.txtRut.Text)) : this.txtDigito.Text.Trim()).Equals(this.txtDigito.Text))
      {
        int num = (int) MessageBox.Show(new Proveedor().agregaProveedor(this.creaProveedor()) ?? "");
        this.iniciaProveedor();
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
      if (this.txtRut.Text.Length > 0)
      {
          clear(true);
      }
      else
      {
          clear(false);
      }
    }

    private void buscaProveedor()
    {
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new Proveedor().buscaRutProveedor(this.txtRut.Text.Trim());
      if (arrayList2.Count == 0)
      {
        int num = (int) MessageBox.Show("No Existe Proveedor Consultado");
        this.activaCampos();
        this.btnModificar.Enabled = false;
        this.btnEliminar.Enabled = false;
        if (this._guarda)
          this.btnGuardar.Enabled = true;
        this.txtFantasia.Focus();
      }
      else
      {
        if (arrayList2.Count != 1)
          return;
        this.activaCampos();
        this.btnGuardar.Enabled = false;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        foreach (ClienteVO clienteVo in arrayList2)
          this.buscaProveedorCodigo(clienteVo.Codigo);
      }
    }

    public void buscaProveedorCodigo(int cod)
    {
      this.activaCampos();
      if (this._modifica)
        this.btnModificar.Enabled = true;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      Proveedor proveedor = new Proveedor();
      ClienteVO clienteVo = proveedor.buscaCodigoProveedor(cod);
      this.codigoProveedor = clienteVo.Codigo;
      DateTime dateTime = proveedor.fechaUltimaCompra(this.codigoProveedor);
      string str1 = dateTime.ToShortDateString();
      if (str1.Equals("01/01/0001"))
        this.txtFechaUltimaCompra.Text = "Sin Compras";
      else
        this.txtFechaUltimaCompra.Text = str1;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.txtFantasia.Text = clienteVo.NomFantasia;
      this.txtGiro.Text = clienteVo.Giro;
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
      this.txtRut.Enabled = false;
      this.txtDigito.Enabled = false;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaProveedor();
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
          this.buscaProveedor();
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
      int num = (int) MessageBox.Show(new Proveedor().modificaProveedor(this.creaProveedor()));
      this.iniciaProveedor();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar este Proveedor.", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        int num = (int) MessageBox.Show(new Proveedor().eliminaProveedor(this.codigoProveedor));
        this.iniciaProveedor();
      }
      else
      {
        int num = (int) MessageBox.Show("El Proveedor NO fue Eliminado");
        this.iniciaProveedor();
      }
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaProveedor(ref this.intance, "proveedor").ShowDialog();
    }

    private void txtDigito_Leave(object sender, EventArgs e)
    {
      this.txtDigito.BackColor = Color.White;
    }

    private void txtDigito_Enter(object sender, EventArgs e)
    {
      this.txtDigito.BackColor = Color.Bisque;
      if (txtDigito.Text.Length < 0)
      {
          clear(true);
      }
      else
      {
          clear(false);
      }
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

    private void frmProveedor_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modProveedor = 0;
    }
  }
}
