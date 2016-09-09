 
// Type: Aptusoft.frmOpciones2
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmOpciones2 : Form
  {
    private IContainer components = (IContainer) null;
    private List<OpcionesDocumentosVO> _lista = (List<OpcionesDocumentosVO>) null;
    private List<MedioPagoVO> _listaMediosPago = (List<MedioPagoVO>) null;
    private int _idOpcionesGenerales = 0;
    private int _idDocumento = 0;
    private string _documento = "";
    private bool _guarda = false;
    private TabControl tabControl2;
    private TabPage tabPage7;
    private GroupBox gpbPesable;
    private TextBox txtCodigoPesable;
    private Label label24;
    private RadioButton rdbSinIva;
    private Label label1;
    private RadioButton rdbConIva;
    private Label label2;
    private Label label3;
    private TextBox txtIva;
    private TabPage tabPage10;
    private GroupBox gpbVerificaCredito;
    private CheckBox chkVerificaGuias;
    private CheckBox chkVerificaBoleta;
    private CheckBox chkVerificaFacturaExenta;
    private CheckBox chkVerificaFactura;
    private CheckBox chkImpideVentas;
    private CheckBox chkVerificaCredito;
    private DataGridView dgvDatos;
    private Panel panelOpcionesDocumento;
    private CheckBox chkCotizacionCompleta;
    private CheckBox chkImpideVentaSinStock;
    private CheckBox chkAlertaStock;
    private Label label13;
    private TextBox txtDecimalesVV;
    private Label label6;
    private TextBox txtCantidadLineas;
    private CheckBox chkIniciarEnTicketBoleta;
    private GroupBox gpbFiscal;
    private CheckBox chkComprobanteExentos;
    private Label label23;
    private Label label22;
    private RadioButton rdbResumenDescripcion;
    private RadioButton rdbDescripcion;
    private TextBox txtNumPuerto;
    private Label label12;
    private CheckBox chkEnvioAutomaticoSII;
    private Button btnSalir;
    private Button btnGuardar;
    private DataGridViewTextBoxColumn IdDocumento;
    private DataGridViewTextBoxColumn NombreDocumento;
    private Button btnLimpiar;
    private ComboBox cmbMedioPago;
    private Label label18;
    private CheckBox chkPermitirMedioPago;
    private GroupBox groupBox2;
    private GroupBox groupBox1;
    private Panel panel1;
    private GroupBox groupBox3;
    private RadioButton rdbBuscaFantasia;
    private Button BtnPreciosOdepa;
    private TabPage tabPage1;
    private Button button1;
    private Button btnConfCorreo;
    private RadioButton rdbBuscaRazonSocial;

    public frmOpciones2(Boolean esFrigo)
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.cargaMediosPagoInicio();
      this.cargaPermisos();
      this.IniciaFormulario();
      if (esFrigo)
      {
          BtnPreciosOdepa.Visible = true;
      }
      else
      {
          BtnPreciosOdepa.Visible = false;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnConfCorreo = new System.Windows.Forms.Button();
            this.gpbPesable = new System.Windows.Forms.GroupBox();
            this.txtCodigoPesable = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.rdbSinIva = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbConIva = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.gpbVerificaCredito = new System.Windows.Forms.GroupBox();
            this.chkVerificaGuias = new System.Windows.Forms.CheckBox();
            this.chkVerificaBoleta = new System.Windows.Forms.CheckBox();
            this.chkVerificaFacturaExenta = new System.Windows.Forms.CheckBox();
            this.chkVerificaFactura = new System.Windows.Forms.CheckBox();
            this.chkImpideVentas = new System.Windows.Forms.CheckBox();
            this.chkVerificaCredito = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.IdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOpcionesDocumento = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCotizacionCompleta = new System.Windows.Forms.CheckBox();
            this.chkIniciarEnTicketBoleta = new System.Windows.Forms.CheckBox();
            this.chkEnvioAutomaticoSII = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbBuscaFantasia = new System.Windows.Forms.RadioButton();
            this.rdbBuscaRazonSocial = new System.Windows.Forms.RadioButton();
            this.chkAlertaStock = new System.Windows.Forms.CheckBox();
            this.chkImpideVentaSinStock = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.chkPermitirMedioPago = new System.Windows.Forms.CheckBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.txtCantidadLineas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDecimalesVV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gpbFiscal = new System.Windows.Forms.GroupBox();
            this.chkComprobanteExentos = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.rdbResumenDescripcion = new System.Windows.Forms.RadioButton();
            this.rdbDescripcion = new System.Windows.Forms.RadioButton();
            this.txtNumPuerto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnPreciosOdepa = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.gpbPesable.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.gpbVerificaCredito.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panelOpcionesDocumento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbFiscal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(3, 5);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(798, 140);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage7.Controls.Add(this.btnConfCorreo);
            this.tabPage7.Controls.Add(this.gpbPesable);
            this.tabPage7.Controls.Add(this.rdbSinIva);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.rdbConIva);
            this.tabPage7.Controls.Add(this.label2);
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.txtIva);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(790, 114);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Opciones Generales";
            // 
            // btnConfCorreo
            // 
            this.btnConfCorreo.Location = new System.Drawing.Point(496, 6);
            this.btnConfCorreo.Name = "btnConfCorreo";
            this.btnConfCorreo.Size = new System.Drawing.Size(85, 46);
            this.btnConfCorreo.TabIndex = 7;
            this.btnConfCorreo.Text = "Configuración de Correo";
            this.btnConfCorreo.UseVisualStyleBackColor = true;
            this.btnConfCorreo.Visible = false;
            this.btnConfCorreo.Click += new System.EventHandler(this.btnConfCorreo_Click);
            // 
            // gpbPesable
            // 
            this.gpbPesable.Controls.Add(this.txtCodigoPesable);
            this.gpbPesable.Controls.Add(this.label24);
            this.gpbPesable.Location = new System.Drawing.Point(587, 6);
            this.gpbPesable.Name = "gpbPesable";
            this.gpbPesable.Size = new System.Drawing.Size(197, 102);
            this.gpbPesable.TabIndex = 6;
            this.gpbPesable.TabStop = false;
            this.gpbPesable.Text = "Productos Pesables";
            // 
            // txtCodigoPesable
            // 
            this.txtCodigoPesable.Location = new System.Drawing.Point(130, 48);
            this.txtCodigoPesable.Name = "txtCodigoPesable";
            this.txtCodigoPesable.Size = new System.Drawing.Size(52, 20);
            this.txtCodigoPesable.TabIndex = 1;
            this.txtCodigoPesable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPesable_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Inicio Codigo Pesable";
            // 
            // rdbSinIva
            // 
            this.rdbSinIva.AutoSize = true;
            this.rdbSinIva.Location = new System.Drawing.Point(222, 61);
            this.rdbSinIva.Name = "rdbSinIva";
            this.rdbSinIva.Size = new System.Drawing.Size(41, 17);
            this.rdbSinIva.TabIndex = 5;
            this.rdbSinIva.TabStop = true;
            this.rdbSinIva.Text = "NO";
            this.rdbSinIva.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IVA:";
            // 
            // rdbConIva
            // 
            this.rdbConIva.AutoSize = true;
            this.rdbConIva.Location = new System.Drawing.Point(181, 61);
            this.rdbConIva.Name = "rdbConIva";
            this.rdbConIva.Size = new System.Drawing.Size(35, 17);
            this.rdbConIva.TabIndex = 4;
            this.rdbConIva.TabStop = true;
            this.rdbConIva.Text = "SI";
            this.rdbConIva.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valores de Venta Incluyen IVA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "%";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(53, 32);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(45, 20);
            this.txtIva.TabIndex = 2;
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIva_KeyPress);
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage10.Controls.Add(this.gpbVerificaCredito);
            this.tabPage10.Controls.Add(this.chkImpideVentas);
            this.tabPage10.Controls.Add(this.chkVerificaCredito);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(790, 114);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Credito";
            // 
            // gpbVerificaCredito
            // 
            this.gpbVerificaCredito.Controls.Add(this.chkVerificaGuias);
            this.gpbVerificaCredito.Controls.Add(this.chkVerificaBoleta);
            this.gpbVerificaCredito.Controls.Add(this.chkVerificaFacturaExenta);
            this.gpbVerificaCredito.Controls.Add(this.chkVerificaFactura);
            this.gpbVerificaCredito.Location = new System.Drawing.Point(200, 3);
            this.gpbVerificaCredito.Name = "gpbVerificaCredito";
            this.gpbVerificaCredito.Size = new System.Drawing.Size(580, 106);
            this.gpbVerificaCredito.TabIndex = 2;
            this.gpbVerificaCredito.TabStop = false;
            this.gpbVerificaCredito.Text = "Documentos incluidos en verificación de Credito";
            // 
            // chkVerificaGuias
            // 
            this.chkVerificaGuias.AutoSize = true;
            this.chkVerificaGuias.Location = new System.Drawing.Point(10, 81);
            this.chkVerificaGuias.Name = "chkVerificaGuias";
            this.chkVerificaGuias.Size = new System.Drawing.Size(113, 17);
            this.chkVerificaGuias.TabIndex = 3;
            this.chkVerificaGuias.Text = "Guias Sin Facturar";
            this.chkVerificaGuias.UseVisualStyleBackColor = true;
            // 
            // chkVerificaBoleta
            // 
            this.chkVerificaBoleta.AutoSize = true;
            this.chkVerificaBoleta.Location = new System.Drawing.Point(10, 61);
            this.chkVerificaBoleta.Name = "chkVerificaBoleta";
            this.chkVerificaBoleta.Size = new System.Drawing.Size(61, 17);
            this.chkVerificaBoleta.TabIndex = 2;
            this.chkVerificaBoleta.Text = "Boletas";
            this.chkVerificaBoleta.UseVisualStyleBackColor = true;
            // 
            // chkVerificaFacturaExenta
            // 
            this.chkVerificaFacturaExenta.AutoSize = true;
            this.chkVerificaFacturaExenta.Location = new System.Drawing.Point(10, 41);
            this.chkVerificaFacturaExenta.Name = "chkVerificaFacturaExenta";
            this.chkVerificaFacturaExenta.Size = new System.Drawing.Size(98, 17);
            this.chkVerificaFacturaExenta.TabIndex = 1;
            this.chkVerificaFacturaExenta.Text = "Factura Exenta";
            this.chkVerificaFacturaExenta.UseVisualStyleBackColor = true;
            // 
            // chkVerificaFactura
            // 
            this.chkVerificaFactura.AutoSize = true;
            this.chkVerificaFactura.Location = new System.Drawing.Point(10, 21);
            this.chkVerificaFactura.Name = "chkVerificaFactura";
            this.chkVerificaFactura.Size = new System.Drawing.Size(111, 17);
            this.chkVerificaFactura.TabIndex = 0;
            this.chkVerificaFactura.Text = "Factura de Venta ";
            this.chkVerificaFactura.UseVisualStyleBackColor = true;
            // 
            // chkImpideVentas
            // 
            this.chkImpideVentas.AutoSize = true;
            this.chkImpideVentas.Location = new System.Drawing.Point(6, 47);
            this.chkImpideVentas.Name = "chkImpideVentas";
            this.chkImpideVentas.Size = new System.Drawing.Size(147, 17);
            this.chkImpideVentas.TabIndex = 1;
            this.chkImpideVentas.Text = "Impedir ventas sin Credito";
            this.chkImpideVentas.UseVisualStyleBackColor = true;
            // 
            // chkVerificaCredito
            // 
            this.chkVerificaCredito.AutoSize = true;
            this.chkVerificaCredito.Location = new System.Drawing.Point(6, 24);
            this.chkVerificaCredito.Name = "chkVerificaCredito";
            this.chkVerificaCredito.Size = new System.Drawing.Size(155, 17);
            this.chkVerificaCredito.TabIndex = 0;
            this.chkVerificaCredito.Text = "Verificar Credito de Clientes";
            this.chkVerificaCredito.UseVisualStyleBackColor = true;
            this.chkVerificaCredito.CheckedChanged += new System.EventHandler(this.chkVerificaCredito_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 114);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Configracion Envio Boletas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "Configuracion De Sincronizacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDocumento,
            this.NombreDocumento});
            this.dgvDatos.Location = new System.Drawing.Point(3, 151);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(206, 420);
            this.dgvDatos.TabIndex = 6;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // IdDocumento
            // 
            this.IdDocumento.DataPropertyName = "IdDocumento";
            this.IdDocumento.HeaderText = "IdDocumento";
            this.IdDocumento.Name = "IdDocumento";
            this.IdDocumento.ReadOnly = true;
            this.IdDocumento.Visible = false;
            this.IdDocumento.Width = 60;
            // 
            // NombreDocumento
            // 
            this.NombreDocumento.DataPropertyName = "NombreDocumento";
            this.NombreDocumento.HeaderText = "Documentos";
            this.NombreDocumento.Name = "NombreDocumento";
            this.NombreDocumento.ReadOnly = true;
            this.NombreDocumento.Width = 200;
            // 
            // panelOpcionesDocumento
            // 
            this.panelOpcionesDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panelOpcionesDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpcionesDocumento.Controls.Add(this.groupBox2);
            this.panelOpcionesDocumento.Controls.Add(this.groupBox1);
            this.panelOpcionesDocumento.Controls.Add(this.gpbFiscal);
            this.panelOpcionesDocumento.Location = new System.Drawing.Point(215, 151);
            this.panelOpcionesDocumento.Name = "panelOpcionesDocumento";
            this.panelOpcionesDocumento.Size = new System.Drawing.Size(586, 420);
            this.panelOpcionesDocumento.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCotizacionCompleta);
            this.groupBox2.Controls.Add(this.chkIniciarEnTicketBoleta);
            this.groupBox2.Controls.Add(this.chkEnvioAutomaticoSII);
            this.groupBox2.Location = new System.Drawing.Point(246, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 249);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones Especiales Documentos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkCotizacionCompleta
            // 
            this.chkCotizacionCompleta.AutoSize = true;
            this.chkCotizacionCompleta.Location = new System.Drawing.Point(13, 19);
            this.chkCotizacionCompleta.Name = "chkCotizacionCompleta";
            this.chkCotizacionCompleta.Size = new System.Drawing.Size(164, 17);
            this.chkCotizacionCompleta.TabIndex = 18;
            this.chkCotizacionCompleta.Text = "Facturar Cotizacion Completa";
            this.chkCotizacionCompleta.UseVisualStyleBackColor = true;
            // 
            // chkIniciarEnTicketBoleta
            // 
            this.chkIniciarEnTicketBoleta.AutoSize = true;
            this.chkIniciarEnTicketBoleta.Location = new System.Drawing.Point(13, 42);
            this.chkIniciarEnTicketBoleta.Name = "chkIniciarEnTicketBoleta";
            this.chkIniciarEnTicketBoleta.Size = new System.Drawing.Size(165, 17);
            this.chkIniciarEnTicketBoleta.TabIndex = 23;
            this.chkIniciarEnTicketBoleta.Text = "Iniciar Boleta en N° de Ticket";
            this.chkIniciarEnTicketBoleta.UseVisualStyleBackColor = true;
            // 
            // chkEnvioAutomaticoSII
            // 
            this.chkEnvioAutomaticoSII.AutoSize = true;
            this.chkEnvioAutomaticoSII.Location = new System.Drawing.Point(13, 65);
            this.chkEnvioAutomaticoSII.Name = "chkEnvioAutomaticoSII";
            this.chkEnvioAutomaticoSII.Size = new System.Drawing.Size(134, 17);
            this.chkEnvioAutomaticoSII.TabIndex = 25;
            this.chkEnvioAutomaticoSII.Text = "Envio Automatico a SII";
            this.chkEnvioAutomaticoSII.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkAlertaStock);
            this.groupBox1.Controls.Add(this.chkImpideVentaSinStock);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtCantidadLineas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDecimalesVV);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 406);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones Basicas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbBuscaFantasia);
            this.groupBox3.Controls.Add(this.rdbBuscaRazonSocial);
            this.groupBox3.Location = new System.Drawing.Point(6, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 67);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda en Columna de Razon Social";
            // 
            // rdbBuscaFantasia
            // 
            this.rdbBuscaFantasia.AutoSize = true;
            this.rdbBuscaFantasia.Location = new System.Drawing.Point(9, 42);
            this.rdbBuscaFantasia.Name = "rdbBuscaFantasia";
            this.rdbBuscaFantasia.Size = new System.Drawing.Size(174, 17);
            this.rdbBuscaFantasia.TabIndex = 1;
            this.rdbBuscaFantasia.TabStop = true;
            this.rdbBuscaFantasia.Text = "Buscar por Nombre de Fantasia";
            this.rdbBuscaFantasia.UseVisualStyleBackColor = true;
            // 
            // rdbBuscaRazonSocial
            // 
            this.rdbBuscaRazonSocial.AutoSize = true;
            this.rdbBuscaRazonSocial.Location = new System.Drawing.Point(9, 19);
            this.rdbBuscaRazonSocial.Name = "rdbBuscaRazonSocial";
            this.rdbBuscaRazonSocial.Size = new System.Drawing.Size(142, 17);
            this.rdbBuscaRazonSocial.TabIndex = 0;
            this.rdbBuscaRazonSocial.TabStop = true;
            this.rdbBuscaRazonSocial.Text = "Buscar por Razon Social";
            this.rdbBuscaRazonSocial.UseVisualStyleBackColor = true;
            // 
            // chkAlertaStock
            // 
            this.chkAlertaStock.AutoSize = true;
            this.chkAlertaStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chkAlertaStock.Location = new System.Drawing.Point(6, 19);
            this.chkAlertaStock.Name = "chkAlertaStock";
            this.chkAlertaStock.Size = new System.Drawing.Size(141, 17);
            this.chkAlertaStock.TabIndex = 16;
            this.chkAlertaStock.Text = "Alerta Stock Insuficiente";
            this.chkAlertaStock.UseVisualStyleBackColor = true;
            // 
            // chkImpideVentaSinStock
            // 
            this.chkImpideVentaSinStock.AutoSize = true;
            this.chkImpideVentaSinStock.Location = new System.Drawing.Point(6, 42);
            this.chkImpideVentaSinStock.Name = "chkImpideVentaSinStock";
            this.chkImpideVentaSinStock.Size = new System.Drawing.Size(140, 17);
            this.chkImpideVentaSinStock.TabIndex = 17;
            this.chkImpideVentaSinStock.Text = "Impedir Venta Sin Stock";
            this.chkImpideVentaSinStock.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.chkPermitirMedioPago);
            this.panel1.Controls.Add(this.cmbMedioPago);
            this.panel1.Location = new System.Drawing.Point(6, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 78);
            this.panel1.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(5, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 15);
            this.label18.TabIndex = 27;
            this.label18.Text = "Medio de Pago por Defecto";
            // 
            // chkPermitirMedioPago
            // 
            this.chkPermitirMedioPago.AutoSize = true;
            this.chkPermitirMedioPago.Location = new System.Drawing.Point(5, 49);
            this.chkPermitirMedioPago.Name = "chkPermitirMedioPago";
            this.chkPermitirMedioPago.Size = new System.Drawing.Size(139, 17);
            this.chkPermitirMedioPago.TabIndex = 28;
            this.chkPermitirMedioPago.Text = "Permitir Solo Este medio";
            this.chkPermitirMedioPago.UseVisualStyleBackColor = true;
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedioPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(5, 22);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(211, 21);
            this.cmbMedioPago.TabIndex = 26;
            // 
            // txtCantidadLineas
            // 
            this.txtCantidadLineas.BackColor = System.Drawing.Color.White;
            this.txtCantidadLineas.Location = new System.Drawing.Point(6, 65);
            this.txtCantidadLineas.Name = "txtCantidadLineas";
            this.txtCantidadLineas.Size = new System.Drawing.Size(59, 20);
            this.txtCantidadLineas.TabIndex = 19;
            this.txtCantidadLineas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadLineas_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cantidad de lineas de detalle";
            // 
            // txtDecimalesVV
            // 
            this.txtDecimalesVV.BackColor = System.Drawing.Color.White;
            this.txtDecimalesVV.Location = new System.Drawing.Point(6, 92);
            this.txtDecimalesVV.Name = "txtDecimalesVV";
            this.txtDecimalesVV.Size = new System.Drawing.Size(59, 20);
            this.txtDecimalesVV.TabIndex = 21;
            this.txtDecimalesVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimalesVV_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Decimales en Precios";
            // 
            // gpbFiscal
            // 
            this.gpbFiscal.Controls.Add(this.chkComprobanteExentos);
            this.gpbFiscal.Controls.Add(this.label23);
            this.gpbFiscal.Controls.Add(this.label22);
            this.gpbFiscal.Controls.Add(this.rdbResumenDescripcion);
            this.gpbFiscal.Controls.Add(this.rdbDescripcion);
            this.gpbFiscal.Controls.Add(this.txtNumPuerto);
            this.gpbFiscal.Controls.Add(this.label12);
            this.gpbFiscal.Location = new System.Drawing.Point(246, 261);
            this.gpbFiscal.Name = "gpbFiscal";
            this.gpbFiscal.Size = new System.Drawing.Size(327, 151);
            this.gpbFiscal.TabIndex = 24;
            this.gpbFiscal.TabStop = false;
            this.gpbFiscal.Text = "Fiscal";
            // 
            // chkComprobanteExentos
            // 
            this.chkComprobanteExentos.AutoSize = true;
            this.chkComprobanteExentos.Location = new System.Drawing.Point(6, 50);
            this.chkComprobanteExentos.Name = "chkComprobanteExentos";
            this.chkComprobanteExentos.Size = new System.Drawing.Size(219, 17);
            this.chkComprobanteExentos.TabIndex = 21;
            this.chkComprobanteExentos.Text = "Imprime Comprobante productos Exentos";
            this.chkComprobanteExentos.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(322, 35);
            this.label23.TabIndex = 5;
            this.label23.Text = "Ej: Descripcion = \"JUGO NARANJA\" Resumen = \"JUG. NAR.\" .......        La Boleta F" +
    "iscal solo imprime texto de 50 caracteres en la Descripcion";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 13);
            this.label22.TabIndex = 4;
            // 
            // rdbResumenDescripcion
            // 
            this.rdbResumenDescripcion.AutoSize = true;
            this.rdbResumenDescripcion.Location = new System.Drawing.Point(143, 82);
            this.rdbResumenDescripcion.Name = "rdbResumenDescripcion";
            this.rdbResumenDescripcion.Size = new System.Drawing.Size(168, 17);
            this.rdbResumenDescripcion.TabIndex = 3;
            this.rdbResumenDescripcion.TabStop = true;
            this.rdbResumenDescripcion.Text = "Imprime Resumen Descripcion";
            this.rdbResumenDescripcion.UseVisualStyleBackColor = true;
            // 
            // rdbDescripcion
            // 
            this.rdbDescripcion.AutoSize = true;
            this.rdbDescripcion.Location = new System.Drawing.Point(6, 82);
            this.rdbDescripcion.Name = "rdbDescripcion";
            this.rdbDescripcion.Size = new System.Drawing.Size(120, 17);
            this.rdbDescripcion.TabIndex = 2;
            this.rdbDescripcion.TabStop = true;
            this.rdbDescripcion.Text = "Imprime Descripcion";
            this.rdbDescripcion.UseVisualStyleBackColor = true;
            // 
            // txtNumPuerto
            // 
            this.txtNumPuerto.BackColor = System.Drawing.Color.White;
            this.txtNumPuerto.Location = new System.Drawing.Point(143, 17);
            this.txtNumPuerto.Name = "txtNumPuerto";
            this.txtNumPuerto.Size = new System.Drawing.Size(51, 20);
            this.txtNumPuerto.TabIndex = 1;
            this.txtNumPuerto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPuerto_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "N° Puerto COM Impresora";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(807, 180);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(807, 151);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(807, 548);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnPreciosOdepa
            // 
            this.BtnPreciosOdepa.Location = new System.Drawing.Point(807, 49);
            this.BtnPreciosOdepa.Name = "BtnPreciosOdepa";
            this.BtnPreciosOdepa.Size = new System.Drawing.Size(75, 65);
            this.BtnPreciosOdepa.TabIndex = 27;
            this.BtnPreciosOdepa.Text = "Precios ODEPA";
            this.BtnPreciosOdepa.UseVisualStyleBackColor = true;
            this.BtnPreciosOdepa.Visible = false;
            this.BtnPreciosOdepa.Click += new System.EventHandler(this.BtnPreciosOdepa_Click);
            // 
            // frmOpciones2
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(886, 576);
            this.Controls.Add(this.BtnPreciosOdepa);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelOpcionesDocumento);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmOpciones2";
            this.ShowIcon = false;
            this.Text = "Opciones Generales";
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.gpbPesable.ResumeLayout(false);
            this.gpbPesable.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.gpbVerificaCredito.ResumeLayout(false);
            this.gpbVerificaCredito.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panelOpcionesDocumento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbFiscal.ResumeLayout(false);
            this.gpbFiscal.PerformLayout();
            this.ResumeLayout(false);

    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("OPCIONES"))
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
      }
    }

    private void cargaMediosPagoInicio()
    {
      try
      {
        this._listaMediosPago = new MedioPago().listaMediosPagoVenta();
        if (this._listaMediosPago.Count <= 0)
          return;
        foreach (MedioPagoVO medioPagoVo in this._listaMediosPago)
        {
          if (medioPagoVo.IdMedioPago == 0)
            medioPagoVo.NombreMedioPago = "TODOS LOS MEDIOS DE PAGO";
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al cargar medios de pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) this._listaMediosPago;
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void IniciaFormulario()
    {
      if (!this.chkVerificaCredito.Checked)
      {
        this.gpbVerificaCredito.Enabled = false;
        this.chkImpideVentas.Enabled = false;
      }
      else
      {
        this.gpbVerificaCredito.Enabled = true;
        this.chkImpideVentas.Enabled = true;
      }
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.CargaOpcionesGenerales();
      this.IniciaOpcionesDocumento();
    }

    private void IniciaOpcionesDocumento()
    {
      this._idDocumento = 0;
      this._documento = string.Empty;
      this.panelOpcionesDocumento.Enabled = false;
      this.CargaOpcionesDocumentos();
      this.chkAlertaStock.Checked = false;
      this.chkAlertaStock.Enabled = false;
      this.chkImpideVentaSinStock.Checked = false;
      this.chkImpideVentaSinStock.Enabled = false;
      this.chkCotizacionCompleta.Checked = false;
      this.chkCotizacionCompleta.Enabled = false;
      this.chkIniciarEnTicketBoleta.Checked = false;
      this.chkIniciarEnTicketBoleta.Enabled = false;
      this.chkEnvioAutomaticoSII.Checked = false;
      this.chkEnvioAutomaticoSII.Enabled = false;
      this.txtCantidadLineas.Clear();
      this.txtCantidadLineas.Enabled = false;
      this.txtDecimalesVV.Clear();
      this.txtDecimalesVV.Enabled = false;
      this.gpbFiscal.Enabled = false;
      this.txtNumPuerto.Clear();
      this.chkComprobanteExentos.Checked = false;
      this.cargaMediosPago();
      this.chkPermitirMedioPago.Checked = false;
      this.rdbBuscaRazonSocial.Checked = true;
      this.rdbBuscaFantasia.Checked = false;
    }

    private void LimpiaOpcionesDocumento()
    {
      this._idDocumento = 0;
      this._documento = string.Empty;
      this.panelOpcionesDocumento.Enabled = false;
      this.chkAlertaStock.Checked = false;
      this.chkAlertaStock.Enabled = false;
      this.chkImpideVentaSinStock.Checked = false;
      this.chkImpideVentaSinStock.Enabled = false;
      this.chkCotizacionCompleta.Checked = false;
      this.chkCotizacionCompleta.Enabled = false;
      this.chkIniciarEnTicketBoleta.Checked = false;
      this.chkIniciarEnTicketBoleta.Enabled = false;
      this.chkEnvioAutomaticoSII.Checked = false;
      this.chkEnvioAutomaticoSII.Enabled = false;
      this.txtCantidadLineas.Clear();
      this.txtCantidadLineas.Enabled = false;
      this.txtDecimalesVV.Clear();
      this.txtDecimalesVV.Enabled = false;
      this.gpbFiscal.Enabled = false;
      this.txtNumPuerto.Clear();
      this.chkComprobanteExentos.Checked = false;
      this.cargaMediosPago();
      this.chkPermitirMedioPago.Checked = false;
      this.rdbBuscaRazonSocial.Checked = true;
      this.rdbBuscaFantasia.Checked = false;
    }

    private void CargaOpcionesGenerales()
    {
      OpcionesGenerales opcionesGenerales = new OpcionesGenerales();
      try
      {
        OpcionesGeneralesVO opcionesGeneralesVo = opcionesGenerales.rescataOpcionesGenerales();
        this._idOpcionesGenerales = opcionesGeneralesVo.IdOpciones;
        this.txtIva.Text = opcionesGeneralesVo.PorcentajeIva.ToString("N0");
        if (opcionesGeneralesVo.valoresVentaConIva == "1")
        {
          this.rdbConIva.Checked = true;
          this.rdbSinIva.Checked = false;
        }
        if (opcionesGeneralesVo.valoresVentaConIva == "0")
        {
          this.rdbConIva.Checked = false;
          this.rdbSinIva.Checked = true;
        }
        this.chkVerificaCredito.Checked = opcionesGeneralesVo.VerificaCredito;
        this.chkImpideVentas.Checked = opcionesGeneralesVo.ImpedirVentasSinCredito;
        this.chkVerificaFactura.Checked = opcionesGeneralesVo.VerificaFactura;
        this.chkVerificaFacturaExenta.Checked = opcionesGeneralesVo.VerificaFacturaExenta;
        this.chkVerificaBoleta.Checked = opcionesGeneralesVo.VerificaBoleta;
        this.chkVerificaGuias.Checked = opcionesGeneralesVo.VerificaGuiaSinFacturar;
        this.txtCodigoPesable.Text = opcionesGeneralesVo.CodigoPesable.ToString();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al cargar Opciones Generales: " + ex.Message);
      }
    }

    private void CargaOpcionesDocumentos()
    {
      this._lista = new OpcionesGenerales().rescataOpcionesDocumentos();
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) this._lista;
    }

    private void chkVerificaCredito_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.chkVerificaCredito.Checked)
      {
        this.gpbVerificaCredito.Enabled = false;
        this.chkVerificaFactura.Checked = false;
        this.chkVerificaFacturaExenta.Checked = false;
        this.chkVerificaBoleta.Checked = false;
        this.chkVerificaGuias.Checked = false;
        this.chkImpideVentas.Checked = false;
      }
      else
      {
        this.gpbVerificaCredito.Enabled = true;
        this.chkImpideVentas.Enabled = true;
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.IniciaOpcionesDocumento();
    }

    private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this.LimpiaOpcionesDocumento();
      this._idDocumento = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
      this._documento = this.dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
      this.ActivaCampos();
    }

    private void ActivaCampos()
    {
      this.panelOpcionesDocumento.Enabled = true;
      if (this._documento.Equals("BOLETA"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = true;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
        if (frmMenuPrincipal._Fiscal)
          this.gpbFiscal.Enabled = true;
        else
          this.gpbFiscal.Enabled = false;
      }
      if (this._documento.Equals("COMPRA"))
      {
        this.chkAlertaStock.Enabled = false;
        this.chkImpideVentaSinStock.Enabled = false;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = false;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("COTIZACION"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("E-FACTURA"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = true;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("FACTURA"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = true;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("FACTURA_EXENTA"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("GUIA"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("GUIA"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("NOTA_CREDITO"))
      {
        this.chkAlertaStock.Enabled = false;
        this.chkImpideVentaSinStock.Enabled = false;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("NOTA_VENTA"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      if (this._documento.Equals("TICKET"))
      {
        this.chkAlertaStock.Enabled = true;
        this.chkImpideVentaSinStock.Enabled = true;
        this.chkCotizacionCompleta.Enabled = false;
        this.chkIniciarEnTicketBoleta.Enabled = false;
        this.chkEnvioAutomaticoSII.Enabled = false;
        this.txtCantidadLineas.Enabled = true;
        this.txtDecimalesVV.Enabled = true;
      }
      this.CargaPermisosDocumento();
    }

    private void CargaPermisosDocumento()
    {
      foreach (OpcionesDocumentosVO opcionesDocumentosVo in this._lista)
      {
        if (opcionesDocumentosVo.NombreDocumento.Equals("BOLETA") && this._documento.Equals("BOLETA"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.chkAlertaStock.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
          this.chkImpideVentaSinStock.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
          this.txtNumPuerto.Text = opcionesDocumentosVo.PuertoImpresoraFiscal.ToString();
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          if (opcionesDocumentosVo.Descripcion_Resumen.Equals("DESCRIPCION"))
          {
            this.rdbDescripcion.Checked = true;
            this.rdbResumenDescripcion.Checked = false;
          }
          else
          {
            this.rdbDescripcion.Checked = false;
            this.rdbResumenDescripcion.Checked = true;
          }
          this.chkIniciarEnTicketBoleta.Checked = opcionesDocumentosVo.iniciarEnNumeroTicket.Equals("1");
          this.chkComprobanteExentos.Checked = opcionesDocumentosVo.ComprobanteExentos.Equals("1");
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("COMPRA") && this._documento.Equals("COMPRA"))
        {
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("COTIZACION") && this._documento.Equals("COTIZACION"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.chkAlertaStock.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
          this.chkImpideVentaSinStock.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("E-FACTURA") && this._documento.Equals("E-FACTURA"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.chkAlertaStock.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
          this.chkImpideVentaSinStock.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
          this.chkEnvioAutomaticoSII.Checked = opcionesDocumentosVo.EnvioAutomaticoSII.Equals("1");
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("FACTURA") && this._documento.Equals("FACTURA"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.chkAlertaStock.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
          this.chkImpideVentaSinStock.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.chkCotizacionCompleta.Checked = opcionesDocumentosVo.FacturarCotizacionCompleta.Equals("1");
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("FACTURA_EXENTA") && this._documento.Equals("FACTURA_EXENTA"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.chkAlertaStock.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
          this.chkImpideVentaSinStock.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("GUIA") && this._documento.Equals("GUIA"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.chkAlertaStock.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
          this.chkImpideVentaSinStock.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("NOTA_CREDITO") && this._documento.Equals("NOTA_CREDITO"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("NOTA_VENTA") && this._documento.Equals("NOTA_VENTA"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.chkAlertaStock.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
          this.chkImpideVentaSinStock.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
        if (opcionesDocumentosVo.NombreDocumento.Equals("TICKET") && this._documento.Equals("TICKET"))
        {
          this.txtCantidadLineas.Text = opcionesDocumentosVo.CantidadLineasDocumento;
          this.chkAlertaStock.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
          this.chkImpideVentaSinStock.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
          this.txtDecimalesVV.Text = opcionesDocumentosVo.DecimalesValorVenta.ToString();
          this.cmbMedioPago.Text = opcionesDocumentosVo.MedioPago.Equals("0") ? "TODOS LOS MEDIOS DE PAGO" : opcionesDocumentosVo.MedioPago;
          this.chkPermitirMedioPago.Checked = opcionesDocumentosVo.PermitirMedioPago.Equals("1");
          if (opcionesDocumentosVo.BusquedaRazonSocial.Equals("1"))
          {
            this.rdbBuscaRazonSocial.Checked = true;
            this.rdbBuscaFantasia.Checked = false;
            break;
          }
          this.rdbBuscaRazonSocial.Checked = false;
          this.rdbBuscaFantasia.Checked = true;
          break;
        }
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      OpcionesGenerales opcionesGenerales = new OpcionesGenerales();
      OpcionesGeneralesVO ogVO = new OpcionesGeneralesVO();
      ogVO.IdOpciones = this._idOpcionesGenerales;
      ogVO.PorcentajeIva = Convert.ToDecimal(this.txtIva.Text.Trim());
      ogVO.valoresVentaConIva = this.rdbConIva.Checked ? "1" : "0";
      ogVO.CodigoPesable = Convert.ToInt32(this.txtCodigoPesable.Text.Trim());
      ogVO.VerificaCredito = this.chkVerificaCredito.Checked;
      ogVO.ImpedirVentasSinCredito = this.chkImpideVentas.Checked;
      ogVO.VerificaFactura = this.chkVerificaFactura.Checked;
      ogVO.VerificaFacturaExenta = this.chkVerificaFacturaExenta.Checked;
      ogVO.VerificaBoleta = this.chkVerificaBoleta.Checked;
      ogVO.VerificaGuiaSinFacturar = this.chkVerificaGuias.Checked;
      foreach (OpcionesDocumentosVO opcionesDocumentosVo in this._lista)
      {
        if (this._documento.Equals(opcionesDocumentosVo.NombreDocumento))
        {
          opcionesDocumentosVo.AlertaStockInsuficiente = this.chkAlertaStock.Checked ? "1" : "0";
          opcionesDocumentosVo.ImpideVentasSinStock = this.chkImpideVentaSinStock.Checked ? "1" : "0";
          opcionesDocumentosVo.CantidadLineasDocumento = this.txtCantidadLineas.Text.Trim().Length > 0 ? this.txtCantidadLineas.Text : "10";
          opcionesDocumentosVo.PuertoImpresoraFiscal = this.txtNumPuerto.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtNumPuerto.Text) : 0;
          opcionesDocumentosVo.DecimalesValorVenta = this.txtDecimalesVV.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVV.Text.Trim()) : 0;
          opcionesDocumentosVo.Descripcion_Resumen = this.rdbDescripcion.Checked ? "DESCRIPCION" : "RESUMEN";
          opcionesDocumentosVo.iniciarEnNumeroTicket = this.chkIniciarEnTicketBoleta.Checked ? "1" : "0";
          opcionesDocumentosVo.FacturarCotizacionCompleta = this.chkCotizacionCompleta.Checked ? "1" : "0";
          opcionesDocumentosVo.EnvioAutomaticoSII = this.chkEnvioAutomaticoSII.Checked ? "1" : "0";
          opcionesDocumentosVo.ComprobanteExentos = this.chkComprobanteExentos.Checked ? "1" : "0";
          opcionesDocumentosVo.MedioPago = this.cmbMedioPago.SelectedValue.ToString() == "0" ? "0" : this.cmbMedioPago.Text;
          opcionesDocumentosVo.PermitirMedioPago = this.chkPermitirMedioPago.Checked ? "1" : "0";
          opcionesDocumentosVo.BusquedaRazonSocial = this.rdbBuscaRazonSocial.Checked ? "1" : "2";
          break;
        }
      }
      try
      {
        opcionesGenerales.guardaOpciones(ogVO, this._lista);
        this.guardaPuertoImpresora();
        int num = (int) MessageBox.Show("GUARDADO", "Guarda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.IniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar Opciones: " + ex.Message);
      }
    }

    private void guardaPuertoImpresora()
    {
      if (!this.gpbFiscal.Enabled)
        return;
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\fiscal.xml");
        dataSet.Tables["impresora"].Rows[0]["puerto"] = (object) this.txtNumPuerto.Text;
        dataSet.WriteXml("C:\\AptuSoft\\xml\\fiscal.xml");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar puerto: " + ex.Message);
      }
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
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

    private void txtCantidadLineas_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidadLineas);
    }

    private void txtDecimalesVV_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtDecimalesVV);
    }

    private void txtNumPuerto_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtNumPuerto);
    }

    private void txtCodigoPesable_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCodigoPesable);
    }

    private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtIva);
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void BtnPreciosOdepa_Click(object sender, EventArgs e)
    {
        if (Application.OpenForms["frmOdepa"] == null)
        {
            new frmOdepa().Show();
        }
        else
        {
            Application.OpenForms["frmOdepa"].BringToFront();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        FrmConfSync syn = new FrmConfSync();
        syn.ShowDialog();
        syn.Focus();
    }

    private void btnConfCorreo_Click(object sender, EventArgs e)
    {
        if (Application.OpenForms["frmCorreo"] == null)
        {
            new frmCorreo().Show();
        }
        else
        {
            Application.OpenForms["frmCorreo"].BringToFront();
        }
    }
  }
}