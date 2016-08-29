 
// Type: Aptusoft.InternoAptusoft.Contratacion.frmContratacion
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using Aptusoft;
using Aptusoft.InternoAptusoft.Ciclos;
using Aptusoft.InternoAptusoft.Facturacion;
using Aptusoft.InternoAptusoft.Ofertas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft.InternoAptusoft.Contratacion
{
  public class frmContratacion : Form
  {
    private IContainer components = (IContainer) null;
    private int _idContrato = 0;
    private int _codigoCliente = 0;
    private List<OfertaVO> _listaOfertas = new List<OfertaVO>();
    private int _idOferta = 0;
    private Panel panelZonaCliente;
    private TextBox txtRut;
    private TextBox txtDigito;
    private Button btnBuscaCliente;
    private TextBox txtRazonSocial;
    private Label label21;
    private Label label4;
    private TextBox txtDiasPlazo;
    private Label label5;
    private TextBox txtContacto;
    private TextBox txtDireccion;
    private Label label12;
    private TextBox txtComuna;
    private Label label11;
    private TextBox txtEmail;
    private TextBox txtCiudad;
    private Label label10;
    private TextBox txtGiro;
    private Label label9;
    private TextBox txtFono;
    private Label label8;
    private Label label7;
    private Label label6;
    private Panel panel4;
    private TabControl tabControl1;
    private TabPage tabPageContratacion;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private DateTimePicker dtpEmision;
    private Label label1;
    private TextBox txtCodigo;
    private TextBox txtDescripcion;
    private GroupBox groupBox3;
    private Label label17;
    private Label label16;
    private Label label13;
    private TextBox txtTotal;
    private ComboBox cmbOferta;
    private Label label15;
    private GroupBox groupBox2;
    private Label label14;
    private Label label3;
    private Label label2;
    private TextBox txtCodigoCiclo;
    private GroupBox groupBox1;
    private TextBox txtDescripcionOferta;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnGuardar;
    private TextBox txtDescripcionCiclo;
    private TextBox txtPrimerVencimiento;
    private TextBox txtPrimeraFacturacion;
    private GroupBox groupBox5;
    private Label label22;
    private Label label23;
    private Label label24;
    private TextBox txtTotalNuevoPlan;
    private TextBox txtCodigoNuevoPlan;
    private TextBox txtDescripcionNuevoPlan;
    private Button btnCambiaPlan;
    private GroupBox groupBox7;
    private TextBox txtReversaPlanObservaciones;
    private Label label28;
    private Button btnAnularPlan;
    private Button btnEliminaPlan;
    private GroupBox groupBox8;
    private Label label30;
    private TextBox txtFechaPlanContratado;
    private TextBox txtEliminaObservaciones;
    private Label label31;
    private Button btnCambiarCiclo;
    private GroupBox groupBox6;
    private TextBox txtSiguienteVencimientoNuevoCiclo;
    private TextBox txtSiguienteFacturacionNuevoCiclo;
    private TextBox txtObservacionesNuevoCiclo;
    private Label label26;
    private Label label27;
    private Label label35;
    private TextBox txtCodNuevoCiclo;
    private GroupBox groupBox4;
    private TextBox txtSegundoVencimientoCicloActual;
    private TextBox txtSegundaFacturacionCicloActual;
    private TextBox txtObservacionesCicloActual;
    private Label label25;
    private TextBox txtCodCicloActual;
    private GroupBox groupBox9;
    private Label label32;
    private Label label33;
    private Label label34;
    private TextBox txtTotalPlanContratado;
    private TextBox txtCodigoPlanContratado;
    private TextBox txtDescripcionPlanContratado;
    private Label label37;
    private Label label18;
    private TextBox txtDescuentoOferta;
    private TextBox txtMesesOferta;
    private Label label19;
    private Label label20;
    private Panel panelContratacion;
    private Label label29;
    private TextBox txtDiasContratado;
    private Label lblAlertaReversaPlan;
    private Panel panel2;
    private Label label36;
    private TextBox txtMesesContratados;
    private Label lblAlertaCambioCiclo;
    private Label label38;
    private TextBox txtDeuda;
    private TabPage tabPage1;
    private DataGridView dgvMovimientoContratacion;
    private TabPage tabPage6;
    private DataGridView dgvFacturacion;
    private DataGridViewTextBoxColumn Contratacion;
    private DataGridViewTextBoxColumn fechaModificacion;
    private DataGridViewTextBoxColumn Estado;
    private DataGridViewTextBoxColumn Observaciones;
    private DataGridViewTextBoxColumn descripcion;
    private DataGridViewTextBoxColumn Total;
    private DataGridViewTextBoxColumn CodigoCiclo;
    private DataGridViewTextBoxColumn DescripcionOferta;
    private DataGridViewTextBoxColumn FechaFacturacion;
    private DataGridViewTextBoxColumn FechaEmision;
    private DataGridViewTextBoxColumn Vencimiento;
    private DataGridViewTextBoxColumn FolioDocumentoVenta;
    private DataGridViewTextBoxColumn EstadoDocumentoVenta;
    private Button btnImprimeContrato;
    private frmContratacion intance;
    private bool _cambioCiclo;
    private DateTime _fechaCambioCiclo;

    public frmContratacion()
    {
      this.InitializeComponent();
      this.intance = this;
      this.dgvMovimientoContratacion.AutoGenerateColumns = false;
      this.dgvFacturacion.AutoGenerateColumns = false;
      this.IniciaFormulario();
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
      this.panelZonaCliente = new Panel();
      this.txtDeuda = new TextBox();
      this.label38 = new Label();
      this.txtRut = new TextBox();
      this.txtDigito = new TextBox();
      this.groupBox9 = new GroupBox();
      this.panel2 = new Panel();
      this.label36 = new Label();
      this.txtMesesContratados = new TextBox();
      this.label29 = new Label();
      this.txtDiasContratado = new TextBox();
      this.label30 = new Label();
      this.label32 = new Label();
      this.label33 = new Label();
      this.label34 = new Label();
      this.txtFechaPlanContratado = new TextBox();
      this.txtTotalPlanContratado = new TextBox();
      this.txtCodigoPlanContratado = new TextBox();
      this.txtDescripcionPlanContratado = new TextBox();
      this.btnBuscaCliente = new Button();
      this.txtRazonSocial = new TextBox();
      this.label21 = new Label();
      this.label4 = new Label();
      this.txtDiasPlazo = new TextBox();
      this.label5 = new Label();
      this.txtContacto = new TextBox();
      this.txtDireccion = new TextBox();
      this.label12 = new Label();
      this.txtComuna = new TextBox();
      this.label11 = new Label();
      this.txtEmail = new TextBox();
      this.txtCiudad = new TextBox();
      this.label10 = new Label();
      this.txtGiro = new TextBox();
      this.label9 = new Label();
      this.txtFono = new TextBox();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.panel4 = new Panel();
      this.tabControl1 = new TabControl();
      this.tabPageContratacion = new TabPage();
      this.panelContratacion = new Panel();
      this.dtpEmision = new DateTimePicker();
      this.groupBox1 = new GroupBox();
      this.label37 = new Label();
      this.label18 = new Label();
      this.txtDescuentoOferta = new TextBox();
      this.txtMesesOferta = new TextBox();
      this.txtDescripcionOferta = new TextBox();
      this.label15 = new Label();
      this.cmbOferta = new ComboBox();
      this.groupBox3 = new GroupBox();
      this.label17 = new Label();
      this.label16 = new Label();
      this.label13 = new Label();
      this.txtTotal = new TextBox();
      this.txtCodigo = new TextBox();
      this.txtDescripcion = new TextBox();
      this.groupBox2 = new GroupBox();
      this.txtPrimerVencimiento = new TextBox();
      this.txtPrimeraFacturacion = new TextBox();
      this.txtDescripcionCiclo = new TextBox();
      this.label14 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.txtCodigoCiclo = new TextBox();
      this.btnGuardar = new Button();
      this.label1 = new Label();
      this.tabPage2 = new TabPage();
      this.btnCambiaPlan = new Button();
      this.groupBox5 = new GroupBox();
      this.label22 = new Label();
      this.label23 = new Label();
      this.label24 = new Label();
      this.txtTotalNuevoPlan = new TextBox();
      this.txtCodigoNuevoPlan = new TextBox();
      this.txtDescripcionNuevoPlan = new TextBox();
      this.tabPage3 = new TabPage();
      this.groupBox7 = new GroupBox();
      this.lblAlertaReversaPlan = new Label();
      this.txtReversaPlanObservaciones = new TextBox();
      this.label28 = new Label();
      this.btnAnularPlan = new Button();
      this.tabPage4 = new TabPage();
      this.btnEliminaPlan = new Button();
      this.groupBox8 = new GroupBox();
      this.txtEliminaObservaciones = new TextBox();
      this.label31 = new Label();
      this.tabPage5 = new TabPage();
      this.lblAlertaCambioCiclo = new Label();
      this.btnCambiarCiclo = new Button();
      this.groupBox6 = new GroupBox();
      this.txtSiguienteVencimientoNuevoCiclo = new TextBox();
      this.txtSiguienteFacturacionNuevoCiclo = new TextBox();
      this.txtObservacionesNuevoCiclo = new TextBox();
      this.label26 = new Label();
      this.label27 = new Label();
      this.label35 = new Label();
      this.txtCodNuevoCiclo = new TextBox();
      this.groupBox4 = new GroupBox();
      this.label19 = new Label();
      this.label20 = new Label();
      this.txtSegundoVencimientoCicloActual = new TextBox();
      this.txtSegundaFacturacionCicloActual = new TextBox();
      this.txtObservacionesCicloActual = new TextBox();
      this.label25 = new Label();
      this.txtCodCicloActual = new TextBox();
      this.tabPage1 = new TabPage();
      this.dgvMovimientoContratacion = new DataGridView();
      this.Contratacion = new DataGridViewTextBoxColumn();
      this.fechaModificacion = new DataGridViewTextBoxColumn();
      this.Estado = new DataGridViewTextBoxColumn();
      this.Observaciones = new DataGridViewTextBoxColumn();
      this.descripcion = new DataGridViewTextBoxColumn();
      this.Total = new DataGridViewTextBoxColumn();
      this.CodigoCiclo = new DataGridViewTextBoxColumn();
      this.DescripcionOferta = new DataGridViewTextBoxColumn();
      this.tabPage6 = new TabPage();
      this.dgvFacturacion = new DataGridView();
      this.FechaFacturacion = new DataGridViewTextBoxColumn();
      this.FechaEmision = new DataGridViewTextBoxColumn();
      this.Vencimiento = new DataGridViewTextBoxColumn();
      this.FolioDocumentoVenta = new DataGridViewTextBoxColumn();
      this.EstadoDocumentoVenta = new DataGridViewTextBoxColumn();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnImprimeContrato = new Button();
      this.panelZonaCliente.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageContratacion.SuspendLayout();
      this.panelContratacion.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((ISupportInitialize) this.dgvMovimientoContratacion).BeginInit();
      this.tabPage6.SuspendLayout();
      ((ISupportInitialize) this.dgvFacturacion).BeginInit();
      this.SuspendLayout();
      this.panelZonaCliente.BackColor = Color.FromArgb(223, 233, 245);
      this.panelZonaCliente.Controls.Add((Control) this.txtDeuda);
      this.panelZonaCliente.Controls.Add((Control) this.label38);
      this.panelZonaCliente.Controls.Add((Control) this.txtRut);
      this.panelZonaCliente.Controls.Add((Control) this.txtDigito);
      this.panelZonaCliente.Controls.Add((Control) this.groupBox9);
      this.panelZonaCliente.Controls.Add((Control) this.btnBuscaCliente);
      this.panelZonaCliente.Controls.Add((Control) this.txtRazonSocial);
      this.panelZonaCliente.Controls.Add((Control) this.label21);
      this.panelZonaCliente.Controls.Add((Control) this.label4);
      this.panelZonaCliente.Controls.Add((Control) this.txtDiasPlazo);
      this.panelZonaCliente.Controls.Add((Control) this.label5);
      this.panelZonaCliente.Controls.Add((Control) this.txtContacto);
      this.panelZonaCliente.Controls.Add((Control) this.txtDireccion);
      this.panelZonaCliente.Controls.Add((Control) this.label12);
      this.panelZonaCliente.Controls.Add((Control) this.txtComuna);
      this.panelZonaCliente.Controls.Add((Control) this.label11);
      this.panelZonaCliente.Controls.Add((Control) this.txtEmail);
      this.panelZonaCliente.Controls.Add((Control) this.txtCiudad);
      this.panelZonaCliente.Controls.Add((Control) this.label10);
      this.panelZonaCliente.Controls.Add((Control) this.txtGiro);
      this.panelZonaCliente.Controls.Add((Control) this.label9);
      this.panelZonaCliente.Controls.Add((Control) this.txtFono);
      this.panelZonaCliente.Controls.Add((Control) this.label8);
      this.panelZonaCliente.Controls.Add((Control) this.label7);
      this.panelZonaCliente.Controls.Add((Control) this.label6);
      this.panelZonaCliente.Location = new Point(12, 12);
      this.panelZonaCliente.Name = "panelZonaCliente";
      this.panelZonaCliente.Size = new Size(761, 176);
      this.panelZonaCliente.TabIndex = 45;
      this.txtDeuda.BackColor = Color.White;
      this.txtDeuda.BorderStyle = BorderStyle.None;
      this.txtDeuda.CharacterCasing = CharacterCasing.Upper;
      this.txtDeuda.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDeuda.ForeColor = Color.Red;
      this.txtDeuda.Location = new Point(636, 69);
      this.txtDeuda.Name = "txtDeuda";
      this.txtDeuda.ReadOnly = true;
      this.txtDeuda.Size = new Size(117, 14);
      this.txtDeuda.TabIndex = 34;
      this.label38.AutoSize = true;
      this.label38.Location = new Point(538, 69);
      this.label38.Name = "label38";
      this.label38.Size = new Size(39, 13);
      this.label38.TabIndex = 33;
      this.label38.Text = "Deuda";
      this.txtRut.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRut.Location = new Point(60, 9);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(68, 20);
      this.txtRut.TabIndex = 6;
      this.txtRut.KeyDown += new KeyEventHandler(this.txtRut_KeyDown);
      this.txtDigito.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDigito.Location = new Point(132, 9);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 7;
      this.txtDigito.KeyDown += new KeyEventHandler(this.txtDigito_KeyDown);
      this.txtDigito.MouseDown += new MouseEventHandler(this.txtDigito_MouseDown);
      this.groupBox9.Controls.Add((Control) this.panel2);
      this.groupBox9.Controls.Add((Control) this.label36);
      this.groupBox9.Controls.Add((Control) this.txtMesesContratados);
      this.groupBox9.Controls.Add((Control) this.label29);
      this.groupBox9.Controls.Add((Control) this.txtDiasContratado);
      this.groupBox9.Controls.Add((Control) this.label30);
      this.groupBox9.Controls.Add((Control) this.label32);
      this.groupBox9.Controls.Add((Control) this.label33);
      this.groupBox9.Controls.Add((Control) this.label34);
      this.groupBox9.Controls.Add((Control) this.txtFechaPlanContratado);
      this.groupBox9.Controls.Add((Control) this.txtTotalPlanContratado);
      this.groupBox9.Controls.Add((Control) this.txtCodigoPlanContratado);
      this.groupBox9.Controls.Add((Control) this.txtDescripcionPlanContratado);
      this.groupBox9.Location = new Point(5, 94);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new Size(751, 68);
      this.groupBox9.TabIndex = 26;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Plan Contratado";
      this.panel2.BorderStyle = BorderStyle.Fixed3D;
      this.panel2.Location = new Point(176, 25);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(5, 37);
      this.panel2.TabIndex = 3;
      this.label36.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label36.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label36.Location = new Point((int) sbyte.MaxValue, 23);
      this.label36.Name = "label36";
      this.label36.Size = new Size(45, 17);
      this.label36.TabIndex = 28;
      this.label36.Text = "Meses";
      this.txtMesesContratados.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtMesesContratados.BorderStyle = BorderStyle.FixedSingle;
      this.txtMesesContratados.Location = new Point((int) sbyte.MaxValue, 40);
      this.txtMesesContratados.Name = "txtMesesContratados";
      this.txtMesesContratados.ReadOnly = true;
      this.txtMesesContratados.Size = new Size(45, 20);
      this.txtMesesContratados.TabIndex = 27;
      this.txtMesesContratados.TextAlign = HorizontalAlignment.Center;
      this.label29.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label29.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label29.Location = new Point(90, 23);
      this.label29.Name = "label29";
      this.label29.Size = new Size(34, 17);
      this.label29.TabIndex = 26;
      this.label29.Text = "Dias";
      this.txtDiasContratado.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtDiasContratado.BorderStyle = BorderStyle.FixedSingle;
      this.txtDiasContratado.Location = new Point(90, 40);
      this.txtDiasContratado.Name = "txtDiasContratado";
      this.txtDiasContratado.ReadOnly = true;
      this.txtDiasContratado.Size = new Size(34, 20);
      this.txtDiasContratado.TabIndex = 25;
      this.txtDiasContratado.TextAlign = HorizontalAlignment.Center;
      this.label30.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label30.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label30.Location = new Point(11, 23);
      this.label30.Name = "label30";
      this.label30.Size = new Size(78, 17);
      this.label30.TabIndex = 23;
      this.label30.Text = "Contratado";
      this.label32.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label32.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label32.Location = new Point(661, 23);
      this.label32.Name = "label32";
      this.label32.Size = new Size(85, 17);
      this.label32.TabIndex = 18;
      this.label32.Text = "Total";
      this.label33.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label33.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label33.Location = new Point(252, 23);
      this.label33.Name = "label33";
      this.label33.Size = new Size(404, 17);
      this.label33.TabIndex = 17;
      this.label33.Text = "Descripcion";
      this.label34.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label34.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label34.Location = new Point(186, 23);
      this.label34.Name = "label34";
      this.label34.Size = new Size(62, 17);
      this.label34.TabIndex = 16;
      this.label34.Text = "Codigo";
      this.txtFechaPlanContratado.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtFechaPlanContratado.BorderStyle = BorderStyle.FixedSingle;
      this.txtFechaPlanContratado.Location = new Point(11, 40);
      this.txtFechaPlanContratado.Name = "txtFechaPlanContratado";
      this.txtFechaPlanContratado.ReadOnly = true;
      this.txtFechaPlanContratado.Size = new Size(78, 20);
      this.txtFechaPlanContratado.TabIndex = 24;
      this.txtFechaPlanContratado.TextAlign = HorizontalAlignment.Center;
      this.txtTotalPlanContratado.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtTotalPlanContratado.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalPlanContratado.CharacterCasing = CharacterCasing.Upper;
      this.txtTotalPlanContratado.Location = new Point(661, 40);
      this.txtTotalPlanContratado.Name = "txtTotalPlanContratado";
      this.txtTotalPlanContratado.ReadOnly = true;
      this.txtTotalPlanContratado.Size = new Size(85, 20);
      this.txtTotalPlanContratado.TabIndex = 15;
      this.txtTotalPlanContratado.TextAlign = HorizontalAlignment.Right;
      this.txtCodigoPlanContratado.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtCodigoPlanContratado.BorderStyle = BorderStyle.FixedSingle;
      this.txtCodigoPlanContratado.CharacterCasing = CharacterCasing.Upper;
      this.txtCodigoPlanContratado.Location = new Point(186, 40);
      this.txtCodigoPlanContratado.Name = "txtCodigoPlanContratado";
      this.txtCodigoPlanContratado.ReadOnly = true;
      this.txtCodigoPlanContratado.Size = new Size(62, 20);
      this.txtCodigoPlanContratado.TabIndex = 13;
      this.txtDescripcionPlanContratado.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtDescripcionPlanContratado.BorderStyle = BorderStyle.FixedSingle;
      this.txtDescripcionPlanContratado.CharacterCasing = CharacterCasing.Upper;
      this.txtDescripcionPlanContratado.Location = new Point(252, 40);
      this.txtDescripcionPlanContratado.Name = "txtDescripcionPlanContratado";
      this.txtDescripcionPlanContratado.ReadOnly = true;
      this.txtDescripcionPlanContratado.Size = new Size(404, 20);
      this.txtDescripcionPlanContratado.TabIndex = 14;
      this.btnBuscaCliente.Location = new Point(663, 6);
      this.btnBuscaCliente.Name = "btnBuscaCliente";
      this.btnBuscaCliente.Size = new Size(93, 23);
      this.btnBuscaCliente.TabIndex = 32;
      this.btnBuscaCliente.Text = "Buscar Cliente";
      this.btnBuscaCliente.UseVisualStyleBackColor = true;
      this.btnBuscaCliente.Click += new EventHandler(this.btnBuscaCliente_Click);
      this.txtRazonSocial.CharacterCasing = CharacterCasing.Upper;
      this.txtRazonSocial.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRazonSocial.Location = new Point(257, 9);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(400, 20);
      this.txtRazonSocial.TabIndex = 8;
      this.label21.AutoSize = true;
      this.label21.Location = new Point(538, 51);
      this.label21.Name = "label21";
      this.label21.Size = new Size(72, 13);
      this.label21.TabIndex = 20;
      this.label21.Text = "Dias de Plazo";
      this.label4.AutoSize = true;
      this.label4.ForeColor = Color.Black;
      this.label4.Location = new Point(26, 13);
      this.label4.Name = "label4";
      this.label4.Size = new Size(30, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "RUT";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.txtDiasPlazo.BackColor = Color.White;
      this.txtDiasPlazo.BorderStyle = BorderStyle.None;
      this.txtDiasPlazo.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDiasPlazo.Location = new Point(636, 51);
      this.txtDiasPlazo.Name = "txtDiasPlazo";
      this.txtDiasPlazo.Size = new Size(117, 13);
      this.txtDiasPlazo.TabIndex = 19;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(181, 13);
      this.label5.Name = "label5";
      this.label5.Size = new Size(70, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Razon Social";
      this.txtContacto.BackColor = Color.White;
      this.txtContacto.BorderStyle = BorderStyle.None;
      this.txtContacto.CharacterCasing = CharacterCasing.Upper;
      this.txtContacto.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtContacto.Location = new Point(60, 69);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(194, 13);
      this.txtContacto.TabIndex = 18;
      this.txtDireccion.BackColor = Color.White;
      this.txtDireccion.BorderStyle = BorderStyle.None;
      this.txtDireccion.CharacterCasing = CharacterCasing.Upper;
      this.txtDireccion.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDireccion.Location = new Point(60, 34);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new Size(276, 13);
      this.txtDireccion.TabIndex = 5;
      this.label12.AutoSize = true;
      this.label12.ForeColor = Color.Black;
      this.label12.Location = new Point(6, 69);
      this.label12.Name = "label12";
      this.label12.Size = new Size(50, 13);
      this.label12.TabIndex = 17;
      this.label12.Text = "Contacto";
      this.label12.TextAlign = ContentAlignment.TopRight;
      this.txtComuna.BackColor = Color.White;
      this.txtComuna.BorderStyle = BorderStyle.None;
      this.txtComuna.CharacterCasing = CharacterCasing.Upper;
      this.txtComuna.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtComuna.Location = new Point(392, 34);
      this.txtComuna.Name = "txtComuna";
      this.txtComuna.Size = new Size(143, 13);
      this.txtComuna.TabIndex = 6;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(276, 69);
      this.label11.Name = "label11";
      this.label11.Size = new Size(32, 13);
      this.label11.TabIndex = 16;
      this.label11.Text = "Email";
      this.label11.TextAlign = ContentAlignment.TopRight;
      this.txtEmail.BackColor = Color.White;
      this.txtEmail.BorderStyle = BorderStyle.None;
      this.txtEmail.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtEmail.Location = new Point(314, 69);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(221, 13);
      this.txtEmail.TabIndex = 10;
      this.txtCiudad.BackColor = Color.White;
      this.txtCiudad.BorderStyle = BorderStyle.None;
      this.txtCiudad.CharacterCasing = CharacterCasing.Upper;
      this.txtCiudad.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCiudad.Location = new Point(580, 34);
      this.txtCiudad.Name = "txtCiudad";
      this.txtCiudad.Size = new Size(173, 13);
      this.txtCiudad.TabIndex = 7;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(355, 51);
      this.label10.Name = "label10";
      this.label10.Size = new Size(31, 13);
      this.label10.TabIndex = 15;
      this.label10.Text = "Fono";
      this.txtGiro.BackColor = Color.White;
      this.txtGiro.BorderStyle = BorderStyle.None;
      this.txtGiro.CharacterCasing = CharacterCasing.Upper;
      this.txtGiro.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtGiro.Location = new Point(60, 51);
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new Size(276, 13);
      this.txtGiro.TabIndex = 8;
      this.label9.AutoSize = true;
      this.label9.ForeColor = Color.Black;
      this.label9.Location = new Point(30, 51);
      this.label9.Name = "label9";
      this.label9.Size = new Size(26, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Giro";
      this.label9.TextAlign = ContentAlignment.TopRight;
      this.txtFono.BackColor = Color.White;
      this.txtFono.BorderStyle = BorderStyle.None;
      this.txtFono.CharacterCasing = CharacterCasing.Upper;
      this.txtFono.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFono.Location = new Point(392, 51);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(143, 13);
      this.txtFono.TabIndex = 9;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(538, 34);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Ciudad";
      this.label8.TextAlign = ContentAlignment.TopRight;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(340, 34);
      this.label7.Name = "label7";
      this.label7.Size = new Size(46, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Comuna";
      this.label6.AutoSize = true;
      this.label6.ForeColor = Color.Black;
      this.label6.Location = new Point(4, 34);
      this.label6.Name = "label6";
      this.label6.Size = new Size(52, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Dirección";
      this.label6.TextAlign = ContentAlignment.TopRight;
      this.panel4.BackColor = Color.White;
      this.panel4.Location = new Point(11, 11);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(763, 178);
      this.panel4.TabIndex = 46;
      this.tabControl1.Controls.Add((Control) this.tabPageContratacion);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Controls.Add((Control) this.tabPage5);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage6);
      this.tabControl1.Location = new Point(12, 195);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(761, 290);
      this.tabControl1.TabIndex = 47;
      this.tabPageContratacion.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPageContratacion.BorderStyle = BorderStyle.FixedSingle;
      this.tabPageContratacion.Controls.Add((Control) this.panelContratacion);
      this.tabPageContratacion.Location = new Point(4, 22);
      this.tabPageContratacion.Name = "tabPageContratacion";
      this.tabPageContratacion.Padding = new Padding(3);
      this.tabPageContratacion.Size = new Size(753, 264);
      this.tabPageContratacion.TabIndex = 0;
      this.tabPageContratacion.Text = "Contratacion";
      this.panelContratacion.Controls.Add((Control) this.dtpEmision);
      this.panelContratacion.Controls.Add((Control) this.groupBox1);
      this.panelContratacion.Controls.Add((Control) this.groupBox3);
      this.panelContratacion.Controls.Add((Control) this.groupBox2);
      this.panelContratacion.Controls.Add((Control) this.btnGuardar);
      this.panelContratacion.Controls.Add((Control) this.label1);
      this.panelContratacion.Location = new Point(2, 1);
      this.panelContratacion.Name = "panelContratacion";
      this.panelContratacion.Size = new Size(606, 256);
      this.panelContratacion.TabIndex = 49;
      this.dtpEmision.Format = DateTimePickerFormat.Short;
      this.dtpEmision.Location = new Point(140, 71);
      this.dtpEmision.Name = "dtpEmision";
      this.dtpEmision.Size = new Size(101, 20);
      this.dtpEmision.TabIndex = 0;
      this.dtpEmision.ValueChanged += new EventHandler(this.dtpEmision_ValueChanged);
      this.groupBox1.Controls.Add((Control) this.label37);
      this.groupBox1.Controls.Add((Control) this.label18);
      this.groupBox1.Controls.Add((Control) this.txtDescuentoOferta);
      this.groupBox1.Controls.Add((Control) this.txtMesesOferta);
      this.groupBox1.Controls.Add((Control) this.txtDescripcionOferta);
      this.groupBox1.Controls.Add((Control) this.label15);
      this.groupBox1.Controls.Add((Control) this.cmbOferta);
      this.groupBox1.Location = new Point(260, 62);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(340, 138);
      this.groupBox1.TabIndex = 19;
      this.groupBox1.TabStop = false;
      this.label37.AutoSize = true;
      this.label37.Location = new Point(179, 60);
      this.label37.Name = "label37";
      this.label37.Size = new Size(70, 13);
      this.label37.TabIndex = 22;
      this.label37.Text = "% Descuento";
      this.label18.AutoSize = true;
      this.label18.Location = new Point(13, 60);
      this.label18.Name = "label18";
      this.label18.Size = new Size(85, 13);
      this.label18.TabIndex = 21;
      this.label18.Text = "Meses de Oferta";
      this.txtDescuentoOferta.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtDescuentoOferta.Location = new Point(252, 56);
      this.txtDescuentoOferta.Name = "txtDescuentoOferta";
      this.txtDescuentoOferta.ReadOnly = true;
      this.txtDescuentoOferta.Size = new Size(76, 20);
      this.txtDescuentoOferta.TabIndex = 20;
      this.txtMesesOferta.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtMesesOferta.Location = new Point(101, 56);
      this.txtMesesOferta.Name = "txtMesesOferta";
      this.txtMesesOferta.ReadOnly = true;
      this.txtMesesOferta.Size = new Size(63, 20);
      this.txtMesesOferta.TabIndex = 19;
      this.txtDescripcionOferta.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtDescripcionOferta.CharacterCasing = CharacterCasing.Upper;
      this.txtDescripcionOferta.Location = new Point(11, 82);
      this.txtDescripcionOferta.Multiline = true;
      this.txtDescripcionOferta.Name = "txtDescripcionOferta";
      this.txtDescripcionOferta.ReadOnly = true;
      this.txtDescripcionOferta.Size = new Size(317, 47);
      this.txtDescripcionOferta.TabIndex = 18;
      this.label15.AutoSize = true;
      this.label15.Location = new Point(13, 21);
      this.label15.Name = "label15";
      this.label15.Size = new Size(41, 13);
      this.label15.TabIndex = 16;
      this.label15.Text = "Ofertas";
      this.cmbOferta.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbOferta.FormattingEnabled = true;
      this.cmbOferta.Location = new Point(60, 17);
      this.cmbOferta.Name = "cmbOferta";
      this.cmbOferta.Size = new Size(268, 21);
      this.cmbOferta.TabIndex = 17;
      this.cmbOferta.SelectionChangeCommitted += new EventHandler(this.cmbOferta_SelectionChangeCommitted);
      this.groupBox3.Controls.Add((Control) this.label17);
      this.groupBox3.Controls.Add((Control) this.label16);
      this.groupBox3.Controls.Add((Control) this.label13);
      this.groupBox3.Controls.Add((Control) this.txtTotal);
      this.groupBox3.Controls.Add((Control) this.txtCodigo);
      this.groupBox3.Controls.Add((Control) this.txtDescripcion);
      this.groupBox3.Location = new Point(5, 3);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(595, 59);
      this.groupBox3.TabIndex = 18;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Plan";
      this.label17.AutoSize = true;
      this.label17.Location = new Point(505, 16);
      this.label17.Name = "label17";
      this.label17.Size = new Size(31, 13);
      this.label17.TabIndex = 18;
      this.label17.Text = "Total";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(95, 16);
      this.label16.Name = "label16";
      this.label16.Size = new Size(63, 13);
      this.label16.TabIndex = 17;
      this.label16.Text = "Descripcion";
      this.label13.AutoSize = true;
      this.label13.Location = new Point(8, 16);
      this.label13.Name = "label13";
      this.label13.Size = new Size(40, 13);
      this.label13.TabIndex = 16;
      this.label13.Text = "Codigo";
      this.txtTotal.BackColor = SystemColors.Window;
      this.txtTotal.CharacterCasing = CharacterCasing.Upper;
      this.txtTotal.Location = new Point(505, 29);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new Size(84, 20);
      this.txtTotal.TabIndex = 15;
      this.txtTotal.TextAlign = HorizontalAlignment.Right;
      this.txtCodigo.BackColor = SystemColors.Window;
      this.txtCodigo.CharacterCasing = CharacterCasing.Upper;
      this.txtCodigo.Location = new Point(8, 29);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new Size(84, 20);
      this.txtCodigo.TabIndex = 13;
      this.txtCodigo.KeyDown += new KeyEventHandler(this.txtCodigo_KeyDown);
      this.txtDescripcion.BackColor = SystemColors.Window;
      this.txtDescripcion.CharacterCasing = CharacterCasing.Upper;
      this.txtDescripcion.Location = new Point(95, 29);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.ReadOnly = true;
      this.txtDescripcion.Size = new Size(404, 20);
      this.txtDescripcion.TabIndex = 14;
      this.groupBox2.Controls.Add((Control) this.txtPrimerVencimiento);
      this.groupBox2.Controls.Add((Control) this.txtPrimeraFacturacion);
      this.groupBox2.Controls.Add((Control) this.txtDescripcionCiclo);
      this.groupBox2.Controls.Add((Control) this.label14);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.txtCodigoCiclo);
      this.groupBox2.Location = new Point(5, 96);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(221, 130);
      this.groupBox2.TabIndex = 15;
      this.groupBox2.TabStop = false;
      this.txtPrimerVencimiento.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtPrimerVencimiento.CharacterCasing = CharacterCasing.Upper;
      this.txtPrimerVencimiento.Location = new Point(123, 64);
      this.txtPrimerVencimiento.Name = "txtPrimerVencimiento";
      this.txtPrimerVencimiento.ReadOnly = true;
      this.txtPrimerVencimiento.Size = new Size(88, 20);
      this.txtPrimerVencimiento.TabIndex = 22;
      this.txtPrimeraFacturacion.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtPrimeraFacturacion.CharacterCasing = CharacterCasing.Upper;
      this.txtPrimeraFacturacion.Location = new Point(123, 40);
      this.txtPrimeraFacturacion.Name = "txtPrimeraFacturacion";
      this.txtPrimeraFacturacion.ReadOnly = true;
      this.txtPrimeraFacturacion.Size = new Size(88, 20);
      this.txtPrimeraFacturacion.TabIndex = 21;
      this.txtDescripcionCiclo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtDescripcionCiclo.Location = new Point(6, 88);
      this.txtDescripcionCiclo.Multiline = true;
      this.txtDescripcionCiclo.Name = "txtDescripcionCiclo";
      this.txtDescripcionCiclo.ReadOnly = true;
      this.txtDescripcionCiclo.Size = new Size(205, 29);
      this.txtDescripcionCiclo.TabIndex = 20;
      this.label14.AutoSize = true;
      this.label14.Location = new Point(6, 66);
      this.label14.Name = "label14";
      this.label14.Size = new Size(111, 13);
      this.label14.TabIndex = 20;
      this.label14.Text = "Segundo Vencimiento";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(6, 43);
      this.label3.Name = "label3";
      this.label3.Size = new Size(109, 13);
      this.label3.TabIndex = 19;
      this.label3.Text = "Segunda Facturación";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(6, 20);
      this.label2.Name = "label2";
      this.label2.Size = new Size(66, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "Codigo Ciclo";
      this.txtCodigoCiclo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtCodigoCiclo.CharacterCasing = CharacterCasing.Upper;
      this.txtCodigoCiclo.Location = new Point(123, 16);
      this.txtCodigoCiclo.Name = "txtCodigoCiclo";
      this.txtCodigoCiclo.ReadOnly = true;
      this.txtCodigoCiclo.Size = new Size(88, 20);
      this.txtCodigoCiclo.TabIndex = 0;
      this.btnGuardar.Location = new Point(503, 206);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(97, 35);
      this.btnGuardar.TabIndex = 0;
      this.btnGuardar.Text = "Guardar Contrato";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.label1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new Point(8, 72);
      this.label1.Name = "label1";
      this.label1.Size = new Size(152, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Fecha de Contratación";
      this.tabPage2.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage2.Controls.Add((Control) this.btnCambiaPlan);
      this.tabPage2.Controls.Add((Control) this.groupBox5);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(753, 264);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Cambio de Plan";
      this.btnCambiaPlan.Location = new Point(510, 195);
      this.btnCambiaPlan.Name = "btnCambiaPlan";
      this.btnCambiaPlan.Size = new Size(97, 35);
      this.btnCambiaPlan.TabIndex = 23;
      this.btnCambiaPlan.Text = "Cambia Plan";
      this.btnCambiaPlan.UseVisualStyleBackColor = true;
      this.btnCambiaPlan.Click += new EventHandler(this.btnCambiaPlan_Click);
      this.groupBox5.Controls.Add((Control) this.label22);
      this.groupBox5.Controls.Add((Control) this.label23);
      this.groupBox5.Controls.Add((Control) this.label24);
      this.groupBox5.Controls.Add((Control) this.txtTotalNuevoPlan);
      this.groupBox5.Controls.Add((Control) this.txtCodigoNuevoPlan);
      this.groupBox5.Controls.Add((Control) this.txtDescripcionNuevoPlan);
      this.groupBox5.Location = new Point(12, 11);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(595, 59);
      this.groupBox5.TabIndex = 20;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Nuevo Plan";
      this.label22.AutoSize = true;
      this.label22.Location = new Point(505, 16);
      this.label22.Name = "label22";
      this.label22.Size = new Size(31, 13);
      this.label22.TabIndex = 18;
      this.label22.Text = "Total";
      this.label23.AutoSize = true;
      this.label23.Location = new Point(95, 16);
      this.label23.Name = "label23";
      this.label23.Size = new Size(63, 13);
      this.label23.TabIndex = 17;
      this.label23.Text = "Descripcion";
      this.label24.AutoSize = true;
      this.label24.Location = new Point(8, 16);
      this.label24.Name = "label24";
      this.label24.Size = new Size(40, 13);
      this.label24.TabIndex = 16;
      this.label24.Text = "Codigo";
      this.txtTotalNuevoPlan.BackColor = SystemColors.Window;
      this.txtTotalNuevoPlan.CharacterCasing = CharacterCasing.Upper;
      this.txtTotalNuevoPlan.Location = new Point(505, 29);
      this.txtTotalNuevoPlan.Name = "txtTotalNuevoPlan";
      this.txtTotalNuevoPlan.ReadOnly = true;
      this.txtTotalNuevoPlan.Size = new Size(84, 20);
      this.txtTotalNuevoPlan.TabIndex = 15;
      this.txtTotalNuevoPlan.TextAlign = HorizontalAlignment.Right;
      this.txtCodigoNuevoPlan.BackColor = SystemColors.Window;
      this.txtCodigoNuevoPlan.CharacterCasing = CharacterCasing.Upper;
      this.txtCodigoNuevoPlan.Location = new Point(8, 29);
      this.txtCodigoNuevoPlan.Name = "txtCodigoNuevoPlan";
      this.txtCodigoNuevoPlan.Size = new Size(84, 20);
      this.txtCodigoNuevoPlan.TabIndex = 13;
      this.txtCodigoNuevoPlan.KeyDown += new KeyEventHandler(this.txtCodigoNuevoPlan_KeyDown);
      this.txtDescripcionNuevoPlan.BackColor = SystemColors.Window;
      this.txtDescripcionNuevoPlan.CharacterCasing = CharacterCasing.Upper;
      this.txtDescripcionNuevoPlan.Location = new Point(95, 29);
      this.txtDescripcionNuevoPlan.Name = "txtDescripcionNuevoPlan";
      this.txtDescripcionNuevoPlan.ReadOnly = true;
      this.txtDescripcionNuevoPlan.Size = new Size(404, 20);
      this.txtDescripcionNuevoPlan.TabIndex = 14;
      this.tabPage3.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage3.Controls.Add((Control) this.groupBox7);
      this.tabPage3.Controls.Add((Control) this.btnAnularPlan);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(753, 264);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Reversa de Plan";
      this.groupBox7.Controls.Add((Control) this.lblAlertaReversaPlan);
      this.groupBox7.Controls.Add((Control) this.txtReversaPlanObservaciones);
      this.groupBox7.Controls.Add((Control) this.label28);
      this.groupBox7.Location = new Point(12, 11);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(595, 197);
      this.groupBox7.TabIndex = 25;
      this.groupBox7.TabStop = false;
      this.lblAlertaReversaPlan.AutoSize = true;
      this.lblAlertaReversaPlan.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblAlertaReversaPlan.ForeColor = Color.Red;
      this.lblAlertaReversaPlan.Location = new Point(9, 174);
      this.lblAlertaReversaPlan.Name = "lblAlertaReversaPlan";
      this.lblAlertaReversaPlan.Size = new Size(12, 16);
      this.lblAlertaReversaPlan.TabIndex = 26;
      this.lblAlertaReversaPlan.Text = ".";
      this.txtReversaPlanObservaciones.CharacterCasing = CharacterCasing.Upper;
      this.txtReversaPlanObservaciones.Location = new Point(92, 18);
      this.txtReversaPlanObservaciones.Multiline = true;
      this.txtReversaPlanObservaciones.Name = "txtReversaPlanObservaciones";
      this.txtReversaPlanObservaciones.Size = new Size(494, 150);
      this.txtReversaPlanObservaciones.TabIndex = 21;
      this.label28.AutoSize = true;
      this.label28.Location = new Point(8, 17);
      this.label28.Name = "label28";
      this.label28.Size = new Size(78, 13);
      this.label28.TabIndex = 20;
      this.label28.Text = "Observaciones";
      this.btnAnularPlan.Location = new Point(510, 214);
      this.btnAnularPlan.Name = "btnAnularPlan";
      this.btnAnularPlan.Size = new Size(97, 35);
      this.btnAnularPlan.TabIndex = 22;
      this.btnAnularPlan.Text = "Anular Plan";
      this.btnAnularPlan.UseVisualStyleBackColor = true;
      this.btnAnularPlan.Click += new EventHandler(this.btnAnularPlan_Click);
      this.tabPage4.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage4.Controls.Add((Control) this.btnEliminaPlan);
      this.tabPage4.Controls.Add((Control) this.groupBox8);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(753, 264);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Eliminacion de Plan";
      this.btnEliminaPlan.Location = new Point(504, 214);
      this.btnEliminaPlan.Name = "btnEliminaPlan";
      this.btnEliminaPlan.Size = new Size(97, 35);
      this.btnEliminaPlan.TabIndex = 28;
      this.btnEliminaPlan.Text = "Eliminar Plan";
      this.btnEliminaPlan.UseVisualStyleBackColor = true;
      this.btnEliminaPlan.Click += new EventHandler(this.button1_Click);
      this.groupBox8.Controls.Add((Control) this.txtEliminaObservaciones);
      this.groupBox8.Controls.Add((Control) this.label31);
      this.groupBox8.Location = new Point(12, 11);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new Size(595, 197);
      this.groupBox8.TabIndex = 27;
      this.groupBox8.TabStop = false;
      this.txtEliminaObservaciones.CharacterCasing = CharacterCasing.Upper;
      this.txtEliminaObservaciones.Location = new Point(92, 18);
      this.txtEliminaObservaciones.Multiline = true;
      this.txtEliminaObservaciones.Name = "txtEliminaObservaciones";
      this.txtEliminaObservaciones.Size = new Size(494, 150);
      this.txtEliminaObservaciones.TabIndex = 21;
      this.label31.AutoSize = true;
      this.label31.Location = new Point(8, 17);
      this.label31.Name = "label31";
      this.label31.Size = new Size(78, 13);
      this.label31.TabIndex = 20;
      this.label31.Text = "Observaciones";
      this.tabPage5.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage5.Controls.Add((Control) this.lblAlertaCambioCiclo);
      this.tabPage5.Controls.Add((Control) this.btnCambiarCiclo);
      this.tabPage5.Controls.Add((Control) this.groupBox6);
      this.tabPage5.Controls.Add((Control) this.groupBox4);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(753, 264);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Cambio de Ciclo";
      this.lblAlertaCambioCiclo.AutoSize = true;
      this.lblAlertaCambioCiclo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblAlertaCambioCiclo.ForeColor = Color.Red;
      this.lblAlertaCambioCiclo.Location = new Point(6, 182);
      this.lblAlertaCambioCiclo.Name = "lblAlertaCambioCiclo";
      this.lblAlertaCambioCiclo.Size = new Size(12, 16);
      this.lblAlertaCambioCiclo.TabIndex = 30;
      this.lblAlertaCambioCiclo.Text = ".";
      this.btnCambiarCiclo.Location = new Point(466, 144);
      this.btnCambiarCiclo.Name = "btnCambiarCiclo";
      this.btnCambiarCiclo.Size = new Size(97, 35);
      this.btnCambiarCiclo.TabIndex = 29;
      this.btnCambiarCiclo.Text = "Cambiar Ciclo";
      this.btnCambiarCiclo.UseVisualStyleBackColor = true;
      this.btnCambiarCiclo.Click += new EventHandler(this.btnCambiarCiclo_Click);
      this.groupBox6.Controls.Add((Control) this.txtSiguienteVencimientoNuevoCiclo);
      this.groupBox6.Controls.Add((Control) this.txtSiguienteFacturacionNuevoCiclo);
      this.groupBox6.Controls.Add((Control) this.txtObservacionesNuevoCiclo);
      this.groupBox6.Controls.Add((Control) this.label26);
      this.groupBox6.Controls.Add((Control) this.label27);
      this.groupBox6.Controls.Add((Control) this.label35);
      this.groupBox6.Controls.Add((Control) this.txtCodNuevoCiclo);
      this.groupBox6.Location = new Point(240, 6);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(221, 173);
      this.groupBox6.TabIndex = 19;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Nuevo Ciclo";
      this.txtSiguienteVencimientoNuevoCiclo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtSiguienteVencimientoNuevoCiclo.CharacterCasing = CharacterCasing.Upper;
      this.txtSiguienteVencimientoNuevoCiclo.Location = new Point(128, 77);
      this.txtSiguienteVencimientoNuevoCiclo.Name = "txtSiguienteVencimientoNuevoCiclo";
      this.txtSiguienteVencimientoNuevoCiclo.ReadOnly = true;
      this.txtSiguienteVencimientoNuevoCiclo.Size = new Size(87, 20);
      this.txtSiguienteVencimientoNuevoCiclo.TabIndex = 22;
      this.txtSiguienteFacturacionNuevoCiclo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtSiguienteFacturacionNuevoCiclo.CharacterCasing = CharacterCasing.Upper;
      this.txtSiguienteFacturacionNuevoCiclo.Location = new Point(128, 53);
      this.txtSiguienteFacturacionNuevoCiclo.Name = "txtSiguienteFacturacionNuevoCiclo";
      this.txtSiguienteFacturacionNuevoCiclo.ReadOnly = true;
      this.txtSiguienteFacturacionNuevoCiclo.Size = new Size(87, 20);
      this.txtSiguienteFacturacionNuevoCiclo.TabIndex = 21;
      this.txtObservacionesNuevoCiclo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtObservacionesNuevoCiclo.Location = new Point(10, 101);
      this.txtObservacionesNuevoCiclo.Multiline = true;
      this.txtObservacionesNuevoCiclo.Name = "txtObservacionesNuevoCiclo";
      this.txtObservacionesNuevoCiclo.ReadOnly = true;
      this.txtObservacionesNuevoCiclo.Size = new Size(205, 29);
      this.txtObservacionesNuevoCiclo.TabIndex = 20;
      this.label26.AutoSize = true;
      this.label26.Location = new Point(10, 79);
      this.label26.Name = "label26";
      this.label26.Size = new Size(112, 13);
      this.label26.TabIndex = 20;
      this.label26.Text = "Siguiente Vencimiento";
      this.label27.AutoSize = true;
      this.label27.Location = new Point(10, 56);
      this.label27.Name = "label27";
      this.label27.Size = new Size(110, 13);
      this.label27.TabIndex = 19;
      this.label27.Text = "Siguiente Facturación";
      this.label35.AutoSize = true;
      this.label35.Location = new Point(10, 33);
      this.label35.Name = "label35";
      this.label35.Size = new Size(66, 13);
      this.label35.TabIndex = 18;
      this.label35.Text = "Codigo Ciclo";
      this.txtCodNuevoCiclo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtCodNuevoCiclo.CharacterCasing = CharacterCasing.Upper;
      this.txtCodNuevoCiclo.Location = new Point(128, 29);
      this.txtCodNuevoCiclo.Name = "txtCodNuevoCiclo";
      this.txtCodNuevoCiclo.ReadOnly = true;
      this.txtCodNuevoCiclo.Size = new Size(87, 20);
      this.txtCodNuevoCiclo.TabIndex = 0;
      this.txtCodNuevoCiclo.KeyDown += new KeyEventHandler(this.txtCodNuevoCiclo_KeyDown);
      this.groupBox4.Controls.Add((Control) this.label19);
      this.groupBox4.Controls.Add((Control) this.label20);
      this.groupBox4.Controls.Add((Control) this.txtSegundoVencimientoCicloActual);
      this.groupBox4.Controls.Add((Control) this.txtSegundaFacturacionCicloActual);
      this.groupBox4.Controls.Add((Control) this.txtObservacionesCicloActual);
      this.groupBox4.Controls.Add((Control) this.label25);
      this.groupBox4.Controls.Add((Control) this.txtCodCicloActual);
      this.groupBox4.Location = new Point(6, 6);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(230, 173);
      this.groupBox4.TabIndex = 18;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Ciclo Actual";
      this.label19.AutoSize = true;
      this.label19.Location = new Point(6, 81);
      this.label19.Name = "label19";
      this.label19.Size = new Size(111, 13);
      this.label19.TabIndex = 24;
      this.label19.Text = "Segundo Vencimiento";
      this.label20.AutoSize = true;
      this.label20.Location = new Point(6, 57);
      this.label20.Name = "label20";
      this.label20.Size = new Size(109, 13);
      this.label20.TabIndex = 23;
      this.label20.Text = "Segunda Facturación";
      this.txtSegundoVencimientoCicloActual.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtSegundoVencimientoCicloActual.CharacterCasing = CharacterCasing.Upper;
      this.txtSegundoVencimientoCicloActual.Location = new Point(121, 77);
      this.txtSegundoVencimientoCicloActual.Name = "txtSegundoVencimientoCicloActual";
      this.txtSegundoVencimientoCicloActual.ReadOnly = true;
      this.txtSegundoVencimientoCicloActual.Size = new Size(100, 20);
      this.txtSegundoVencimientoCicloActual.TabIndex = 22;
      this.txtSegundaFacturacionCicloActual.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtSegundaFacturacionCicloActual.CharacterCasing = CharacterCasing.Upper;
      this.txtSegundaFacturacionCicloActual.Location = new Point(121, 53);
      this.txtSegundaFacturacionCicloActual.Name = "txtSegundaFacturacionCicloActual";
      this.txtSegundaFacturacionCicloActual.ReadOnly = true;
      this.txtSegundaFacturacionCicloActual.Size = new Size(100, 20);
      this.txtSegundaFacturacionCicloActual.TabIndex = 21;
      this.txtObservacionesCicloActual.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtObservacionesCicloActual.Location = new Point(6, 101);
      this.txtObservacionesCicloActual.Multiline = true;
      this.txtObservacionesCicloActual.Name = "txtObservacionesCicloActual";
      this.txtObservacionesCicloActual.ReadOnly = true;
      this.txtObservacionesCicloActual.Size = new Size(215, 29);
      this.txtObservacionesCicloActual.TabIndex = 20;
      this.label25.AutoSize = true;
      this.label25.Location = new Point(6, 33);
      this.label25.Name = "label25";
      this.label25.Size = new Size(66, 13);
      this.label25.TabIndex = 18;
      this.label25.Text = "Codigo Ciclo";
      this.txtCodCicloActual.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.txtCodCicloActual.CharacterCasing = CharacterCasing.Upper;
      this.txtCodCicloActual.Location = new Point(121, 29);
      this.txtCodCicloActual.Name = "txtCodCicloActual";
      this.txtCodCicloActual.ReadOnly = true;
      this.txtCodCicloActual.Size = new Size(100, 20);
      this.txtCodCicloActual.TabIndex = 0;
      this.tabPage1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage1.Controls.Add((Control) this.dgvMovimientoContratacion);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(753, 264);
      this.tabPage1.TabIndex = 5;
      this.tabPage1.Text = "Mov. Contratacion";
      this.dgvMovimientoContratacion.AllowUserToAddRows = false;
      this.dgvMovimientoContratacion.AllowUserToDeleteRows = false;
      this.dgvMovimientoContratacion.AllowUserToResizeColumns = false;
      this.dgvMovimientoContratacion.AllowUserToResizeRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvMovimientoContratacion.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvMovimientoContratacion.BackgroundColor = Color.LightSteelBlue;
      this.dgvMovimientoContratacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMovimientoContratacion.Columns.AddRange((DataGridViewColumn) this.Contratacion, (DataGridViewColumn) this.fechaModificacion, (DataGridViewColumn) this.Estado, (DataGridViewColumn) this.Observaciones, (DataGridViewColumn) this.descripcion, (DataGridViewColumn) this.Total, (DataGridViewColumn) this.CodigoCiclo, (DataGridViewColumn) this.DescripcionOferta);
      this.dgvMovimientoContratacion.Location = new Point(6, 6);
      this.dgvMovimientoContratacion.Name = "dgvMovimientoContratacion";
      this.dgvMovimientoContratacion.ReadOnly = true;
      this.dgvMovimientoContratacion.RowHeadersVisible = false;
      this.dgvMovimientoContratacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvMovimientoContratacion.Size = new Size(741, 252);
      this.dgvMovimientoContratacion.TabIndex = 0;
      this.Contratacion.DataPropertyName = "FechaContratacion";
      gridViewCellStyle2.Format = "d";
      gridViewCellStyle2.NullValue = (object) null;
      this.Contratacion.DefaultCellStyle = gridViewCellStyle2;
      this.Contratacion.HeaderText = "Contratacion";
      this.Contratacion.Name = "Contratacion";
      this.Contratacion.ReadOnly = true;
      this.Contratacion.Width = 70;
      this.fechaModificacion.DataPropertyName = "FechaModificacion";
      gridViewCellStyle3.Format = "d";
      gridViewCellStyle3.NullValue = (object) null;
      this.fechaModificacion.DefaultCellStyle = gridViewCellStyle3;
      this.fechaModificacion.HeaderText = "Modificado";
      this.fechaModificacion.Name = "fechaModificacion";
      this.fechaModificacion.ReadOnly = true;
      this.fechaModificacion.Width = 65;
      this.Estado.DataPropertyName = "Estado";
      this.Estado.HeaderText = "Estado";
      this.Estado.Name = "Estado";
      this.Estado.ReadOnly = true;
      this.Observaciones.DataPropertyName = "Observaciones";
      this.Observaciones.HeaderText = "Observaciones";
      this.Observaciones.Name = "Observaciones";
      this.Observaciones.ReadOnly = true;
      this.Observaciones.Width = 190;
      this.descripcion.DataPropertyName = "Descripcion";
      this.descripcion.HeaderText = "descripcion";
      this.descripcion.Name = "descripcion";
      this.descripcion.ReadOnly = true;
      this.descripcion.Width = 150;
      this.Total.DataPropertyName = "Total";
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle4.Format = "N0";
      gridViewCellStyle4.NullValue = (object) "0";
      this.Total.DefaultCellStyle = gridViewCellStyle4;
      this.Total.HeaderText = "Total";
      this.Total.Name = "Total";
      this.Total.ReadOnly = true;
      this.Total.Width = 80;
      this.CodigoCiclo.DataPropertyName = "CodigoCiclo";
      this.CodigoCiclo.HeaderText = "Ciclo";
      this.CodigoCiclo.Name = "CodigoCiclo";
      this.CodigoCiclo.ReadOnly = true;
      this.CodigoCiclo.Width = 60;
      this.DescripcionOferta.DataPropertyName = "DescripcionOferta";
      this.DescripcionOferta.HeaderText = "Oferta";
      this.DescripcionOferta.Name = "DescripcionOferta";
      this.DescripcionOferta.ReadOnly = true;
      this.DescripcionOferta.Width = 120;
      this.tabPage6.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.tabPage6.Controls.Add((Control) this.dgvFacturacion);
      this.tabPage6.Location = new Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new Padding(3);
      this.tabPage6.Size = new Size(753, 264);
      this.tabPage6.TabIndex = 6;
      this.tabPage6.Text = "Facturacion";
      this.dgvFacturacion.AllowUserToAddRows = false;
      this.dgvFacturacion.AllowUserToDeleteRows = false;
      this.dgvFacturacion.AllowUserToResizeColumns = false;
      this.dgvFacturacion.AllowUserToResizeRows = false;
      gridViewCellStyle5.BackColor = Color.Lavender;
      this.dgvFacturacion.AlternatingRowsDefaultCellStyle = gridViewCellStyle5;
      this.dgvFacturacion.BackgroundColor = Color.LightSteelBlue;
      this.dgvFacturacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFacturacion.Columns.AddRange((DataGridViewColumn) this.FechaFacturacion, (DataGridViewColumn) this.FechaEmision, (DataGridViewColumn) this.Vencimiento, (DataGridViewColumn) this.FolioDocumentoVenta, (DataGridViewColumn) this.EstadoDocumentoVenta);
      this.dgvFacturacion.Location = new Point(5, 6);
      this.dgvFacturacion.Name = "dgvFacturacion";
      this.dgvFacturacion.ReadOnly = true;
      this.dgvFacturacion.RowHeadersVisible = false;
      this.dgvFacturacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvFacturacion.Size = new Size(526, 252);
      this.dgvFacturacion.TabIndex = 0;
      this.FechaFacturacion.DataPropertyName = "FechaFacturacion";
      gridViewCellStyle6.Format = "d";
      gridViewCellStyle6.NullValue = (object) null;
      this.FechaFacturacion.DefaultCellStyle = gridViewCellStyle6;
      this.FechaFacturacion.HeaderText = "Facturacion";
      this.FechaFacturacion.Name = "FechaFacturacion";
      this.FechaFacturacion.ReadOnly = true;
      this.FechaEmision.DataPropertyName = "FechaEmision";
      gridViewCellStyle7.Format = "d";
      gridViewCellStyle7.NullValue = (object) null;
      this.FechaEmision.DefaultCellStyle = gridViewCellStyle7;
      this.FechaEmision.HeaderText = "Emision";
      this.FechaEmision.Name = "FechaEmision";
      this.FechaEmision.ReadOnly = true;
      this.Vencimiento.DataPropertyName = "FechaVencimiento";
      gridViewCellStyle8.Format = "d";
      gridViewCellStyle8.NullValue = (object) null;
      this.Vencimiento.DefaultCellStyle = gridViewCellStyle8;
      this.Vencimiento.HeaderText = "Vencimiento";
      this.Vencimiento.Name = "Vencimiento";
      this.Vencimiento.ReadOnly = true;
      this.FolioDocumentoVenta.DataPropertyName = "FolioDocumentoVenta";
      gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.FolioDocumentoVenta.DefaultCellStyle = gridViewCellStyle9;
      this.FolioDocumentoVenta.HeaderText = "Folio";
      this.FolioDocumentoVenta.Name = "FolioDocumentoVenta";
      this.FolioDocumentoVenta.ReadOnly = true;
      this.EstadoDocumentoVenta.DataPropertyName = "EstadoPago";
      this.EstadoDocumentoVenta.HeaderText = "Estado Pago";
      this.EstadoDocumentoVenta.Name = "EstadoDocumentoVenta";
      this.EstadoDocumentoVenta.ReadOnly = true;
      this.btnSalir.Location = new Point(698, 487);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 41);
      this.btnSalir.TabIndex = 2;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Location = new Point(12, 491);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 41);
      this.btnLimpiar.TabIndex = 1;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnImprimeContrato.Location = new Point(93, 491);
      this.btnImprimeContrato.Name = "btnImprimeContrato";
      this.btnImprimeContrato.Size = new Size(75, 41);
      this.btnImprimeContrato.TabIndex = 48;
      this.btnImprimeContrato.Text = "ReImprimir Contrato";
      this.btnImprimeContrato.UseVisualStyleBackColor = true;
      this.btnImprimeContrato.Click += new EventHandler(this.btnImprimeContrato_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(787, 535);
      this.Controls.Add((Control) this.btnImprimeContrato);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.panelZonaCliente);
      this.Controls.Add((Control) this.panel4);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "frmContratacion";
      this.ShowIcon = false;
      this.Text = "Modulo Contratacion";
      this.Load += new EventHandler(this.frmContratacion_Load);
      this.panelZonaCliente.ResumeLayout(false);
      this.panelZonaCliente.PerformLayout();
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPageContratacion.ResumeLayout(false);
      this.panelContratacion.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.tabPage1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvMovimientoContratacion).EndInit();
      this.tabPage6.ResumeLayout(false);
      ((ISupportInitialize) this.dgvFacturacion).EndInit();
      this.ResumeLayout(false);
    }

    private void IniciaFormulario()
    {
      this._idContrato = 0;
      this._codigoCliente = 0;
      this._cambioCiclo = false;
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
      this.txtFono.Clear();
      this.txtFono.Enabled = false;
      this.txtEmail.Clear();
      this.txtEmail.Enabled = true;
      this.txtContacto.Clear();
      this.CargaOfertas();
      this.txtFechaPlanContratado.Clear();
      this.txtDiasContratado.Clear();
      this.txtMesesContratados.Clear();
      this.txtCodigoPlanContratado.Clear();
      this.txtDescripcionPlanContratado.Clear();
      this.txtTotalPlanContratado.Clear();
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtTotal.Clear();
      this.dtpEmision.Value = DateTime.Now;
      this.txtCodigoCiclo.Clear();
      this.txtPrimeraFacturacion.Clear();
      this.txtPrimerVencimiento.Clear();
      this.txtDescripcionCiclo.Clear();
      this.BuscaPrimeraFacturacion();
      this.txtCodigoNuevoPlan.Clear();
      this.txtDescripcionNuevoPlan.Clear();
      this.txtTotalNuevoPlan.Clear();
      this.txtReversaPlanObservaciones.Clear();
      this.txtEliminaObservaciones.Clear();
      this.txtCodCicloActual.Clear();
      this.txtSegundaFacturacionCicloActual.Clear();
      this.txtSegundoVencimientoCicloActual.Clear();
      this.txtObservacionesCicloActual.Clear();
      this.txtCodNuevoCiclo.Clear();
      this.txtSiguienteFacturacionNuevoCiclo.Clear();
      this.txtSiguienteVencimientoNuevoCiclo.Clear();
      this.txtObservacionesNuevoCiclo.Clear();
      this.lblAlertaReversaPlan.Text = "";
      this.btnAnularPlan.Enabled = false;
      this.lblAlertaCambioCiclo.Text = "";
      this.btnCambiarCiclo.Enabled = false;
      this.btnImprimeContrato.Enabled = false;
      this.dgvMovimientoContratacion.DataSource = (object) null;
      this.dgvFacturacion.DataSource = (object) null;
      this.txtRut.Focus();
    }

    private void CargaOfertas()
    {
      this._idOferta = 0;
      this._listaOfertas.Clear();
      this.cmbOferta.DataSource = (object) null;
      this._listaOfertas = new OfertaNegocio().ListaOfertasVigentes();
      if (this._listaOfertas.Count <= 0)
        return;
      this.cmbOferta.DataSource = (object) this._listaOfertas;
      this.cmbOferta.ValueMember = "idOferta";
      this.cmbOferta.DisplayMember = "nombre";
      this.cmbOferta.SelectedValue = (object) 0;
      this.txtDescripcionOferta.Text = "SIN OFERTA";
      this.txtMesesOferta.Text = "0";
      this.txtDescuentoOferta.Text = "0";
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cmbOferta_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (this._listaOfertas.Count <= 0)
        return;
      this._idOferta = Convert.ToInt32(this.cmbOferta.SelectedValue);
      foreach (OfertaVO ofertaVo in this._listaOfertas)
      {
        if (this._idOferta == ofertaVo.IdOferta)
        {
          this.txtDescripcionOferta.Clear();
          this.txtDescripcionOferta.Text = ofertaVo.Descripcion;
          this.txtMesesOferta.Text = ofertaVo.CantidadMeses.ToString();
          this.txtDescuentoOferta.Text = ofertaVo.Descuento.ToString("N0");
          break;
        }
      }
    }

    private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.txtCodigo.Text.Trim().Length <= 0 || e.KeyCode != Keys.Return)
        return;
      ProductoVO productoVo = new Producto().buscaCodigoProducto(this.txtCodigo.Text.Trim());
      if (productoVo.Codigo != null)
      {
        this.txtDescripcion.Text = productoVo.Descripcion;
        this.txtTotal.Text = productoVo.ValorVenta1.ToString("N0");
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Codigo Consultado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void dtpEmision_ValueChanged(object sender, EventArgs e)
    {
      this.BuscaPrimeraFacturacion();
    }

    private void BuscaPrimeraFacturacion()
    {
      List<CicloVO> list = new CicloNegocio().PrimeraFacturacion(this.dtpEmision.Value);
      if (list.Count <= 0)
        return;
      foreach (CicloVO cicloVo in list)
      {
        this.txtCodigoCiclo.Text = cicloVo.CodigoCiclo.ToString();
        this.txtPrimeraFacturacion.Text = cicloVo.FechaFacturacion.ToShortDateString();
        this.txtPrimerVencimiento.Text = cicloVo.FechaVencimiento.ToShortDateString();
        this.txtDescripcionCiclo.Text = cicloVo.Descripcion;
        this.txtObservacionesCicloActual.Text = this.txtDescripcionCiclo.Text;
      }
    }

    private void buscaCliente()
    {
      ArrayList arrayList = new ArrayList();
      ArrayList cli = new Cliente().buscaRutCliente(this.txtRut.Text.Trim());
      if (cli.Count > 1)
      {
        this.txtRazonSocial.Enabled = false;
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "contratacion").ShowDialog();
      }
      else if (cli.Count == 0)
      {
        if (MessageBox.Show("No Existe Cliente Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          new frmClientes(this.txtRut.Text.Trim(), this.txtDigito.Text.Trim()).Show();
        else
          this.IniciaFormulario();
      }
      else
      {
        if (cli.Count != 1)
          return;
        foreach (ClienteVO clienteVo in cli)
          this.buscaClienteCodigo(clienteVo.Codigo);
        this.txtCodigo.Focus();
      }
    }

    public void buscaClienteCodigo(int cod)
    {
      ClienteVO clienteVo = new Cliente().buscaCodigoCliente(cod);
      this._codigoCliente = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.txtDireccion.Text = clienteVo.Direccion;
      this.txtComuna.Text = clienteVo.Comuna;
      this.txtCiudad.Text = clienteVo.Ciudad;
      this.txtGiro.Text = clienteVo.Giro;
      this.txtFono.Text = clienteVo.Telefono;
      this.txtEmail.Text = clienteVo.EmailContacto;
      this.txtContacto.Text = clienteVo.Contacto;
      this.txtDiasPlazo.Text = clienteVo.DiasPlazo;
      this.CalculaDeudaCliente();
      this.BuscaContratoActivo();
      this.BuscaContratoIdCliente();
      this.BuscaFacturacionIdCliente();
      this.txtCodigo.Focus();
    }

    private void BuscaContratoActivo()
    {
      ContratoVO contratoVo = new ContratoNegocio().BuscaContratoActivoIdCliente(this._codigoCliente);
      if (contratoVo.Rut != null)
      {
        this._idContrato = contratoVo.IdContrato;
        this._cambioCiclo = contratoVo.CambioCiclo;
        this._fechaCambioCiclo = contratoVo.FechaCambioCiclo;
        this.dtpEmision.Value = contratoVo.FechaContratacion;
        this.txtRut.Text = contratoVo.Rut;
        this.txtDigito.Text = contratoVo.Digito;
        this.txtRazonSocial.Text = contratoVo.RazonSocial;
        this.txtDireccion.Text = contratoVo.Direccion;
        this.txtComuna.Text = contratoVo.Comuna;
        this.txtCiudad.Text = contratoVo.Ciudad;
        this.txtGiro.Text = contratoVo.Giro;
        this.txtFono.Text = contratoVo.Fono;
        this.txtContacto.Text = contratoVo.Contacto;
        this.txtEmail.Text = contratoVo.Email;
        TextBox textBox1 = this.txtTotal;
        Decimal num = contratoVo.Total;
        string str1 = num.ToString("N0");
        textBox1.Text = str1;
        this.txtCodigo.Text = contratoVo.Codigo;
        this.txtDescripcion.Text = contratoVo.Descripcion;
        TextBox textBox2 = this.txtFechaPlanContratado;
        DateTime dateTime = contratoVo.FechaContratacion;
        string str2 = dateTime.ToShortDateString();
        textBox2.Text = str2;
        TextBox textBox3 = this.txtTotalPlanContratado;
        num = contratoVo.Total;
        string str3 = num.ToString("N0");
        textBox3.Text = str3;
        this.txtCodigoPlanContratado.Text = contratoVo.Codigo;
        this.txtDescripcionPlanContratado.Text = contratoVo.Descripcion;
        this.CalculaDiasContratados(contratoVo.FechaContratacion);
        this.txtCodigoCiclo.Text = contratoVo.CodigoCiclo.ToString();
        this.txtCodCicloActual.Text = contratoVo.CodigoCiclo.ToString();
        TextBox textBox4 = this.txtPrimeraFacturacion;
        dateTime = contratoVo.SegundaFacturacion;
        string str4 = dateTime.ToShortDateString();
        textBox4.Text = str4;
        TextBox textBox5 = this.txtSegundaFacturacionCicloActual;
        dateTime = contratoVo.SegundaFacturacion;
        string str5 = dateTime.ToShortDateString();
        textBox5.Text = str5;
        TextBox textBox6 = this.txtPrimerVencimiento;
        dateTime = contratoVo.SegundoVencimiento;
        string str6 = dateTime.ToShortDateString();
        textBox6.Text = str6;
        TextBox textBox7 = this.txtSegundoVencimientoCicloActual;
        dateTime = contratoVo.SegundoVencimiento;
        string str7 = dateTime.ToShortDateString();
        textBox7.Text = str7;
        this.txtObservacionesCicloActual.Text = this.txtDescripcionCiclo.Text;
        this._idOferta = contratoVo.CodigoOferta;
        this.cmbOferta.SelectedValue = (object) contratoVo.CodigoOferta;
        this.txtDescripcionOferta.Text = contratoVo.DescripcionOferta;
        this.txtMesesOferta.Text = contratoVo.MesesOferta.ToString();
        TextBox textBox8 = this.txtDescuentoOferta;
        num = contratoVo.DescuentoOferta;
        string str8 = num.ToString();
        textBox8.Text = str8;
        this.panelContratacion.Enabled = false;
        this.CalculaCambioCiclo();
        this.btnImprimeContrato.Enabled = true;
      }
      else
      {
        int num = (int) MessageBox.Show("Cliente Sin Contrato Activo", "Sin Contrato", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.panelContratacion.Enabled = true;
      }
    }

    private void CalculaDiasContratados(DateTime fechaContrato)
    {
      Decimal num = new Decimal(0);
      DateTime now = DateTime.Now;
      int days = (now - fechaContrato).Days;
      this.txtDiasContratado.Text = days.ToString();
      if (days > 10)
      {
        this.lblAlertaReversaPlan.Text = "NO SE PUEDE ANULAR EL PLAN CON MAS DE 10 DIAS DE CONTRATO";
        this.btnAnularPlan.Enabled = false;
      }
      else
      {
        this.lblAlertaReversaPlan.Text = "";
        this.btnAnularPlan.Enabled = true;
      }
      this.txtMesesContratados.Text =Math.Abs(fechaContrato.Month - now.Month + 12 * (fechaContrato.Year - now.Year)).ToString("##");
    }

    private void CalculaCambioCiclo()
    {
      bool flag;
      if (this._cambioCiclo)
      {
        if ((Decimal) Math.Abs(this._fechaCambioCiclo.Month - DateTime.Now.Month + 12 * (this._fechaCambioCiclo.Year - DateTime.Now.Year)) >= new Decimal(12))
        {
          this.lblAlertaCambioCiclo.Text = "";
          flag = true;
        }
        else
        {
          this.lblAlertaCambioCiclo.Text = "Ultimo cambio: " + this._fechaCambioCiclo.ToShortDateString() + ", Debe tener 12 meses o mas, desde el ultimo cambio";
          this.btnCambiarCiclo.Enabled = false;
          flag = false;
        }
      }
      else
      {
        int num = this.txtMesesContratados.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtMesesContratados.Text) : 0;
        if (!this._cambioCiclo)
        {
          this.lblAlertaCambioCiclo.Text = "";
          flag = true;
        }
        else
        {
          this.lblAlertaCambioCiclo.Text = "Debe tener 12 meses o mas para poder cambiar de Ciclo";
          this.btnCambiarCiclo.Enabled = false;
          flag = false;
        }
      }
      if (flag)
      {
        if ((this.txtDeuda.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtDeuda.Text.Trim()) : new Decimal(0)) > new Decimal(0))
        {
          this.lblAlertaCambioCiclo.Text = "Tiene Deudas Pendientes, No Puede cambiar ciclo";
          this.btnCambiarCiclo.Enabled = false;
          flag = false;
        }
        else
        {
          this.lblAlertaCambioCiclo.Text = "";
          this.btnCambiarCiclo.Enabled = true;
          flag = true;
        }
      }
      if (!flag)
        return;
      DateTime now = DateTime.Now;
      int day = now.Day;
      int month1 = now.Month;
      int year = now.Year;
      DateTime dateTime1 =DateTime.Now;
      DateTime dateTime2 = DateTime.Now;
      if (this.txtCodCicloActual.Text.Equals("1") || this.txtCodCicloActual.Text.Equals("2"))
      {
        if (now.Day >= 18 && now.Day <= 28)
        {
          int month2;
          if (now.Month == 12)
          {
            ++year;
            month2 = 1;
          }
          else
            month2 = month1 + 1;
          dateTime1 = new DateTime(year, month2, 15, now.Hour, now.Minute, now.Second);
          this.txtSiguienteFacturacionNuevoCiclo.Text = dateTime1.ToShortDateString();
          dateTime2 = new DateTime(year, month2, 21, now.Hour, now.Minute, now.Second);
          this.txtSiguienteVencimientoNuevoCiclo.Text = dateTime2.ToShortDateString();
          this.txtCodNuevoCiclo.Text = "15";
          this.txtObservacionesNuevoCiclo.Text = "15 DEL MES SIGUIENTE";
          this.lblAlertaCambioCiclo.Text = "";
          this.btnCambiarCiclo.Enabled = true;
        }
        else
        {
          this.lblAlertaCambioCiclo.Text = "Fecha para cambio de ciclo entre 18 y 28";
          this.txtObservacionesNuevoCiclo.Text = "Fecha para cambio de ciclo entre 18 y 28";
          this.btnCambiarCiclo.Enabled = false;
        }
      }
      else if (now.Day >= 3 && now.Day <= 13)
      {
        int month2;
        if (now.Month == 12)
        {
          ++year;
          month2 = 1;
        }
        else
          month2 = month1 + 1;
        dateTime1 = new DateTime(year, month2, 1, now.Hour, now.Minute, now.Second);
        this.txtSiguienteFacturacionNuevoCiclo.Text = dateTime1.ToShortDateString();
        dateTime2 = new DateTime(year, month2, 6, now.Hour, now.Minute, now.Second);
        this.txtSiguienteVencimientoNuevoCiclo.Text = dateTime2.ToShortDateString();
        this.txtCodNuevoCiclo.Text = "1";
        this.txtObservacionesNuevoCiclo.Text = "1 DEL MES SIGUIENTE";
        this.lblAlertaCambioCiclo.Text = "";
        this.btnCambiarCiclo.Enabled = true;
      }
      else
      {
        this.lblAlertaCambioCiclo.Text = "Fecha para cambio de ciclo entre  3 y 13";
        this.txtObservacionesNuevoCiclo.Text = "Fecha para cambio de ciclo entre 3 y 13";
        this.btnCambiarCiclo.Enabled = false;
      }
    }

    private void txtDigito_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.txtDigito.Text.Trim().Length <= 0)
        ;
    }

    private void txtDigito_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.txtDigito.Text.Trim().Length <= 0 || e.KeyCode != Keys.Return)
        return;
      this.buscaCliente();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.IniciaFormulario();
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "contratacion").ShowDialog();
    }

    private void txtCodigoNuevoPlan_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.txtCodigoNuevoPlan.Text.Trim().Length <= 0 || e.KeyCode != Keys.Return)
        return;
      ProductoVO productoVo = new Producto().buscaCodigoProducto(this.txtCodigoNuevoPlan.Text.Trim());
      if (productoVo.Codigo != null)
      {
        this.txtDescripcionNuevoPlan.Text = productoVo.Descripcion;
        this.txtTotalNuevoPlan.Text = productoVo.ValorVenta1.ToString("N0");
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Codigo Consultado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void txtRut_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.txtRut.Text.Trim().Length <= 0 || e.KeyCode != Keys.Return)
        return;
      this.txtDigito.Focus();
    }

    private ContratoVO ArmaContrato()
    {
      return new ContratoVO()
      {
        IdContrato = this._idContrato,
        FechaContratacion = this.dtpEmision.Value,
        IdCliente = this._codigoCliente,
        Rut = this.txtRut.Text,
        Digito = this.txtDigito.Text,
        RazonSocial = this.txtRazonSocial.Text,
        Direccion = this.txtDireccion.Text,
        Comuna = this.txtComuna.Text,
        Ciudad = this.txtCiudad.Text,
        Giro = this.txtGiro.Text,
        Fono = this.txtFono.Text,
        Contacto = this.txtContacto.Text,
        Email = this.txtEmail.Text,
        Total = Convert.ToDecimal(this.txtTotal.Text),
        Estado = "ACTIVO",
        Codigo = this.txtCodigo.Text,
        Descripcion = this.txtDescripcion.Text,
        CodigoCiclo = Convert.ToInt32(this.txtCodigoCiclo.Text),
        SegundaFacturacion = Convert.ToDateTime(this.txtPrimeraFacturacion.Text),
        SegundoVencimiento = Convert.ToDateTime(this.txtPrimerVencimiento.Text),
        CodigoOferta = this._idOferta,
        DescripcionOferta = this.txtDescripcionOferta.Text,
        MesesOferta = Convert.ToInt32(this.txtMesesOferta.Text),
        DescuentoOferta = Convert.ToDecimal(this.txtDescuentoOferta.Text)
      };
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this._idContrato = new ContratoNegocio().GuardaContrato(this.ArmaContrato());
      if (this._idContrato <= 0)
        return;
      this.ImprimeContrato();
      int num = (int) MessageBox.Show("Contrato Registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.IniciaFormulario();
    }

    private void frmContratacion_Load(object sender, EventArgs e)
    {
    }

    private void ImprimeContrato()
    {
      if (MessageBox.Show("Desea Imprimir el Contrato?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      DataTable dataTable = new ContratoNegocio().MuestraContratoID(this._idContrato);
      try
      {
        ReportDocument rpt = new ReportDocument();
        rpt.Load("C:\\AptuSoft\\reportes\\Contrato.rpt");
        rpt.SetDataSource(dataTable);
        int num = (int) new frmVisualizadorReportes(rpt).ShowDialog();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void btnCambiaPlan_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro/a de Modificar el Plan Contratado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      ContratoVO co1 = this.ArmaContrato();
      co1.Estado = "MODIFICADO";
      co1.Observaciones = "CAMBIO DE PLAN";
      co1.FechaModificacion = DateTime.Now;
      new ContratoNegocio().ModificaContrato(co1);
      ContratoVO co2 = this.ArmaContrato();
      co2.IdContrato = 0;
      co2.Codigo = this.txtCodigoNuevoPlan.Text;
      co2.Descripcion = this.txtDescripcionNuevoPlan.Text;
      co2.Total = Convert.ToDecimal(this.txtTotalNuevoPlan.Text);
      this._idContrato = new ContratoNegocio().GuardaContrato(co2);
      if (this._idContrato > 0)
      {
        this.ImprimeContrato();
        int num = (int) MessageBox.Show("Plan Modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.IniciaFormulario();
      }
    }

    private void btnAnularPlan_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro/a de Anular el Plan Contratado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      if (this.txtReversaPlanObservaciones.Text.Trim().Length > 0)
      {
        ContratoVO co = this.ArmaContrato();
        co.Estado = "ANULADO";
        co.Observaciones = this.txtReversaPlanObservaciones.Text.Trim();
        co.FechaModificacion = DateTime.Now;
        new ContratoNegocio().ModificaContrato(co);
        int num = (int) MessageBox.Show("Plan Anulado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.IniciaFormulario();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un motivo de anulacion de contrato", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtReversaPlanObservaciones.Focus();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro/a de Eliminar el Plan Contratado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      if (this.txtEliminaObservaciones.Text.Trim().Length > 0)
      {
        ContratoVO co = this.ArmaContrato();
        co.Estado = "ELIMINADO";
        co.Observaciones = this.txtEliminaObservaciones.Text.Trim();
        co.FechaModificacion = DateTime.Now;
        new ContratoNegocio().ModificaContrato(co);
        int num = (int) MessageBox.Show("Plan Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.IniciaFormulario();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un motivo de Eliminacion de contrato", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtReversaPlanObservaciones.Focus();
      }
    }

    private void txtCodNuevoCiclo_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void CalculaDeudaCliente()
    {
      Cliente cliente = new Cliente();
      string str = " idCliente=" + this._codigoCliente.ToString();
      string filtro1 = str;
      string filtro2 = str;
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
      }
      if (list2.Count > 0)
      {
        for (int index = 0; index < list2.Count; ++index)
        {
          list2[index].Linea = index + 1;
          num4 += list2[index].MontoUsado;
          num5 += list2[index].MontoDisponible;
        }
      }
      this.txtDeuda.Text = (num3 - num5).ToString("N0");
    }

    private void btnCambiarCiclo_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro/a de Cambiar el Ciclo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      ContratoVO co1 = this.ArmaContrato();
      co1.Estado = "MODIFICADO";
      co1.Observaciones = "CAMBIO DE CICLO";
      co1.FechaModificacion = DateTime.Now;
      new ContratoNegocio().ModificaContrato(co1);
      ContratoVO co2 = this.ArmaContrato();
      co2.IdContrato = 0;
      co2.CambioCiclo = true;
      co2.FechaCambioCiclo = DateTime.Now;
      co2.CodigoCiclo = Convert.ToInt32(this.txtCodNuevoCiclo.Text);
      co2.SegundaFacturacion = Convert.ToDateTime(this.txtSiguienteFacturacionNuevoCiclo.Text);
      co2.SegundoVencimiento = Convert.ToDateTime(this.txtSiguienteVencimientoNuevoCiclo.Text);
      this._idContrato = new ContratoNegocio().GuardaContratoCambioCiclo(co2);
      if (this._idContrato > 0)
      {
        this.ImprimeContrato();
        int num = (int) MessageBox.Show("Ciclo Cambiado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.IniciaFormulario();
      }
    }

    private void BuscaContratoIdCliente()
    {
      this.dgvMovimientoContratacion.DataSource = (object) null;
      this.dgvMovimientoContratacion.DataSource = (object) new ContratoNegocio().BuscaContratoIdCliente(this._codigoCliente);
    }

    private void BuscaFacturacionIdCliente()
    {
      this.dgvFacturacion.DataSource = (object) null;
      this.dgvFacturacion.DataSource = (object) new FacturacionNegocio().BuscaFacturacionIdCliente(this._codigoCliente);
    }

    private void btnImprimeContrato_Click(object sender, EventArgs e)
    {
      this.ImprimeContrato();
      this.IniciaFormulario();
    }
  }
}
