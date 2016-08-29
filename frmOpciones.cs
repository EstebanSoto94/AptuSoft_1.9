 
// Type: Aptusoft.frmOpciones
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmOpciones : Form
  {
    private IContainer components = (IContainer) null;
    private int idOpcionesGenerales = 0;
    private string rutaImagen = "";
    private bool _guarda = false;
    private RadioButton rdbSinIva;
    private RadioButton rdbConIva;
    private Label label3;
    private TextBox txtIva;
    private Label label2;
    private Label label1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TextBox txtCantidadLineasFactura;
    private Label label6;
    private CheckBox chkImpideVentaSinStockFactura;
    private CheckBox chkAlertaStockFactura;
    private Button btnGuardar;
    private TabPage tabPage2;
    private Label label4;
    private TextBox txtCantidadLineasTicket;
    private CheckBox chkImpideVentaSinStockTicket;
    private CheckBox chkAlertaStockTicket;
    private TabPage tabPage3;
    private CheckBox chkImpideVentaSinStockBoleta;
    private CheckBox chkAlertaStockBoleta;
    private Label label5;
    private TextBox txtCantidadLineasBoleta;
    private TabPage tabPage4;
    private CheckBox chkImpideVentaSinStockGuia;
    private CheckBox chkAlertaStockGuia;
    private Label label7;
    private TextBox txtCantidadLineasGuia;
    private Button btnSalir;
    private TabPage tabPage5;
    private Label label8;
    private TextBox txtCantidadLineasNotaCredito;
    private TabPage tabPage6;
    private CheckBox chkImpideVentaSinStockCotizacion;
    private CheckBox chkAlertaStockCotizacion;
    private Label label9;
    private TextBox txtCantidadLineasCotizacion;
    private TabControl tabControl2;
    private TabPage tabPage7;
    private TabPage tabPage8;
    private CheckBox chkImpideVentaSinStockNotaVenta;
    private CheckBox chkAlertaStockNotaVenta;
    private Label label10;
    private TextBox txtCantidadLineasNotaVenta;
    private TabPage tabPage9;
    private CheckBox chkImpideVentaSinStockFacturaExenta;
    private CheckBox chkAlertaStockFacturaExenta;
    private Label label11;
    private TextBox txtCantidadLineasFacturaExenta;
    private GroupBox gpbFiscal;
    private TextBox txtNumPuerto;
    private Label label12;
    private TabPage tabPage10;
    private GroupBox gpbVerificaCredito;
    private CheckBox chkImpideVentas;
    private CheckBox chkVerificaCredito;
    private CheckBox chkVerificaGuias;
    private CheckBox chkVerificaBoleta;
    private CheckBox chkVerificaFacturaExenta;
    private CheckBox chkVerificaFactura;
    private Label label13;
    private TextBox txtDecimalesVVFactura;
    private Label label14;
    private TextBox txtDecimalesVVGuia;
    private Label label15;
    private TextBox txtDecimalesVVTicket;
    private Label label16;
    private TextBox txtDecimalesVVBoleta;
    private Label label17;
    private TextBox txtDecimalesVVNotaCredito;
    private Label label18;
    private TextBox txtDecimalesVVCotizacion;
    private Label label19;
    private TextBox txtDecimalesVVNotaVenta;
    private Label label20;
    private TextBox txtDecimalesVVFacturaExenta;
    private TabPage tabPage11;
    private Label label21;
    private TextBox txtDecimalesVVCompra;
    private RadioButton rdbResumenDescripcion;
    private RadioButton rdbDescripcion;
    private Label label23;
    private Label label22;
    private CheckBox chkIniciarEnTicketBoleta;
    private GroupBox gpbPesable;
    private TextBox txtCodigoPesable;
    private Label label24;
    private CheckBox chkCotizacionCompleta;
    private TabPage tabPage12;
    private CheckBox chkEnvioAutomaticoSIIEFactura;
    private Label label25;
    private TextBox txtDecimalesVVEFactura;
    private CheckBox chkImpideVentaSinStockEFactura;
    private CheckBox chkAlertaStockEFactura;
    private Label label26;
    private TextBox txtCantidadLineasEFactura;
    private CheckBox chkComprobanteExentos;

    public frmOpciones()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      if (frmMenuPrincipal._Fiscal)
      {
        this.gpbFiscal.Visible = true;
        this.rdbConIva.Enabled = true;
        this.rdbSinIva.Enabled = true;
      }
      else
      {
        this.gpbFiscal.Visible = false;
        this.rdbConIva.Enabled = true;
        this.rdbSinIva.Enabled = true;
      }
      this.iniciaFormularioOpciones();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.rdbSinIva = new RadioButton();
      this.rdbConIva = new RadioButton();
      this.label3 = new Label();
      this.txtIva = new TextBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.chkCotizacionCompleta = new CheckBox();
      this.label13 = new Label();
      this.txtDecimalesVVFactura = new TextBox();
      this.chkImpideVentaSinStockFactura = new CheckBox();
      this.chkAlertaStockFactura = new CheckBox();
      this.label6 = new Label();
      this.txtCantidadLineasFactura = new TextBox();
      this.tabPage2 = new TabPage();
      this.label15 = new Label();
      this.txtDecimalesVVTicket = new TextBox();
      this.label4 = new Label();
      this.txtCantidadLineasTicket = new TextBox();
      this.chkImpideVentaSinStockTicket = new CheckBox();
      this.chkAlertaStockTicket = new CheckBox();
      this.tabPage3 = new TabPage();
      this.chkIniciarEnTicketBoleta = new CheckBox();
      this.label16 = new Label();
      this.txtDecimalesVVBoleta = new TextBox();
      this.gpbFiscal = new GroupBox();
      this.label23 = new Label();
      this.label22 = new Label();
      this.rdbResumenDescripcion = new RadioButton();
      this.rdbDescripcion = new RadioButton();
      this.txtNumPuerto = new TextBox();
      this.label12 = new Label();
      this.chkImpideVentaSinStockBoleta = new CheckBox();
      this.chkAlertaStockBoleta = new CheckBox();
      this.label5 = new Label();
      this.txtCantidadLineasBoleta = new TextBox();
      this.tabPage4 = new TabPage();
      this.label14 = new Label();
      this.txtDecimalesVVGuia = new TextBox();
      this.chkImpideVentaSinStockGuia = new CheckBox();
      this.chkAlertaStockGuia = new CheckBox();
      this.label7 = new Label();
      this.txtCantidadLineasGuia = new TextBox();
      this.tabPage5 = new TabPage();
      this.label17 = new Label();
      this.txtDecimalesVVNotaCredito = new TextBox();
      this.label8 = new Label();
      this.txtCantidadLineasNotaCredito = new TextBox();
      this.tabPage6 = new TabPage();
      this.label18 = new Label();
      this.txtDecimalesVVCotizacion = new TextBox();
      this.chkImpideVentaSinStockCotizacion = new CheckBox();
      this.chkAlertaStockCotizacion = new CheckBox();
      this.label9 = new Label();
      this.txtCantidadLineasCotizacion = new TextBox();
      this.tabPage8 = new TabPage();
      this.label19 = new Label();
      this.txtDecimalesVVNotaVenta = new TextBox();
      this.chkImpideVentaSinStockNotaVenta = new CheckBox();
      this.chkAlertaStockNotaVenta = new CheckBox();
      this.label10 = new Label();
      this.txtCantidadLineasNotaVenta = new TextBox();
      this.tabPage9 = new TabPage();
      this.label20 = new Label();
      this.txtDecimalesVVFacturaExenta = new TextBox();
      this.chkImpideVentaSinStockFacturaExenta = new CheckBox();
      this.chkAlertaStockFacturaExenta = new CheckBox();
      this.label11 = new Label();
      this.txtCantidadLineasFacturaExenta = new TextBox();
      this.tabPage11 = new TabPage();
      this.label21 = new Label();
      this.txtDecimalesVVCompra = new TextBox();
      this.tabPage12 = new TabPage();
      this.chkEnvioAutomaticoSIIEFactura = new CheckBox();
      this.label25 = new Label();
      this.txtDecimalesVVEFactura = new TextBox();
      this.chkImpideVentaSinStockEFactura = new CheckBox();
      this.chkAlertaStockEFactura = new CheckBox();
      this.label26 = new Label();
      this.txtCantidadLineasEFactura = new TextBox();
      this.btnGuardar = new Button();
      this.btnSalir = new Button();
      this.tabControl2 = new TabControl();
      this.tabPage7 = new TabPage();
      this.gpbPesable = new GroupBox();
      this.txtCodigoPesable = new TextBox();
      this.label24 = new Label();
      this.tabPage10 = new TabPage();
      this.gpbVerificaCredito = new GroupBox();
      this.chkVerificaGuias = new CheckBox();
      this.chkVerificaBoleta = new CheckBox();
      this.chkVerificaFacturaExenta = new CheckBox();
      this.chkVerificaFactura = new CheckBox();
      this.chkImpideVentas = new CheckBox();
      this.chkVerificaCredito = new CheckBox();
      this.chkComprobanteExentos = new CheckBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.gpbFiscal.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.tabPage6.SuspendLayout();
      this.tabPage8.SuspendLayout();
      this.tabPage9.SuspendLayout();
      this.tabPage11.SuspendLayout();
      this.tabPage12.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage7.SuspendLayout();
      this.gpbPesable.SuspendLayout();
      this.tabPage10.SuspendLayout();
      this.gpbVerificaCredito.SuspendLayout();
      this.SuspendLayout();
      this.rdbSinIva.AutoSize = true;
      this.rdbSinIva.Location = new Point(222, 61);
      this.rdbSinIva.Name = "rdbSinIva";
      this.rdbSinIva.Size = new Size(41, 17);
      this.rdbSinIva.TabIndex = 5;
      this.rdbSinIva.TabStop = true;
      this.rdbSinIva.Text = "NO";
      this.rdbSinIva.UseVisualStyleBackColor = true;
      this.rdbConIva.AutoSize = true;
      this.rdbConIva.Location = new Point(181, 61);
      this.rdbConIva.Name = "rdbConIva";
      this.rdbConIva.Size = new Size(35, 17);
      this.rdbConIva.TabIndex = 4;
      this.rdbConIva.TabStop = true;
      this.rdbConIva.Text = "SI";
      this.rdbConIva.UseVisualStyleBackColor = true;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(101, 35);
      this.label3.Name = "label3";
      this.label3.Size = new Size(15, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "%";
      this.txtIva.Location = new Point(53, 32);
      this.txtIva.Name = "txtIva";
      this.txtIva.Size = new Size(45, 20);
      this.txtIva.TabIndex = 2;
      this.txtIva.KeyPress += new KeyPressEventHandler(this.txtIva_KeyPress);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(21, 63);
      this.label2.Name = "label2";
      this.label2.Size = new Size(154, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Valores de Venta Incluyen IVA:";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(20, 35);
      this.label1.Name = "label1";
      this.label1.Size = new Size(27, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "IVA:";
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Controls.Add((Control) this.tabPage4);
      this.tabControl1.Controls.Add((Control) this.tabPage5);
      this.tabControl1.Controls.Add((Control) this.tabPage6);
      this.tabControl1.Controls.Add((Control) this.tabPage8);
      this.tabControl1.Controls.Add((Control) this.tabPage9);
      this.tabControl1.Controls.Add((Control) this.tabPage11);
      this.tabControl1.Controls.Add((Control) this.tabPage12);
      this.tabControl1.Location = new Point(12, 157);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(706, 179);
      this.tabControl1.TabIndex = 1;
      this.tabPage1.Controls.Add((Control) this.chkCotizacionCompleta);
      this.tabPage1.Controls.Add((Control) this.label13);
      this.tabPage1.Controls.Add((Control) this.txtDecimalesVVFactura);
      this.tabPage1.Controls.Add((Control) this.chkImpideVentaSinStockFactura);
      this.tabPage1.Controls.Add((Control) this.chkAlertaStockFactura);
      this.tabPage1.Controls.Add((Control) this.label6);
      this.tabPage1.Controls.Add((Control) this.txtCantidadLineasFactura);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(698, 153);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Factura";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.chkCotizacionCompleta.AutoSize = true;
      this.chkCotizacionCompleta.Location = new Point(222, 45);
      this.chkCotizacionCompleta.Name = "chkCotizacionCompleta";
      this.chkCotizacionCompleta.Size = new Size(164, 17);
      this.chkCotizacionCompleta.TabIndex = 15;
      this.chkCotizacionCompleta.Text = "Facturar Cotizacion Completa";
      this.chkCotizacionCompleta.UseVisualStyleBackColor = true;
      this.label13.AutoSize = true;
      this.label13.Location = new Point(351, 108);
      this.label13.Name = "label13";
      this.label13.Size = new Size(155, 13);
      this.label13.TabIndex = 14;
      this.label13.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVFactura.Location = new Point(506, 105);
      this.txtDecimalesVVFactura.Name = "txtDecimalesVVFactura";
      this.txtDecimalesVVFactura.Size = new Size(59, 20);
      this.txtDecimalesVVFactura.TabIndex = 13;
      this.txtDecimalesVVFactura.KeyPress += new KeyPressEventHandler(this.txtDecimalesVVFactura_KeyPress);
      this.chkImpideVentaSinStockFactura.AutoSize = true;
      this.chkImpideVentaSinStockFactura.Location = new Point(23, 68);
      this.chkImpideVentaSinStockFactura.Name = "chkImpideVentaSinStockFactura";
      this.chkImpideVentaSinStockFactura.Size = new Size(140, 17);
      this.chkImpideVentaSinStockFactura.TabIndex = 12;
      this.chkImpideVentaSinStockFactura.Text = "Impedir Venta Sin Stock";
      this.chkImpideVentaSinStockFactura.UseVisualStyleBackColor = true;
      this.chkAlertaStockFactura.AutoSize = true;
      this.chkAlertaStockFactura.Location = new Point(23, 45);
      this.chkAlertaStockFactura.Name = "chkAlertaStockFactura";
      this.chkAlertaStockFactura.Size = new Size(141, 17);
      this.chkAlertaStockFactura.TabIndex = 11;
      this.chkAlertaStockFactura.Text = "Alerta Stock Insuficiente";
      this.chkAlertaStockFactura.UseVisualStyleBackColor = true;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(20, 111);
      this.label6.Name = "label6";
      this.label6.Size = new Size(152, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "Cantidad de Lineas en Factura";
      this.txtCantidadLineasFactura.Location = new Point(175, 108);
      this.txtCantidadLineasFactura.Name = "txtCantidadLineasFactura";
      this.txtCantidadLineasFactura.Size = new Size(59, 20);
      this.txtCantidadLineasFactura.TabIndex = 7;
      this.txtCantidadLineasFactura.KeyPress += new KeyPressEventHandler(this.txtCantidadLineasFactura_KeyPress);
      this.tabPage2.Controls.Add((Control) this.label15);
      this.tabPage2.Controls.Add((Control) this.txtDecimalesVVTicket);
      this.tabPage2.Controls.Add((Control) this.label4);
      this.tabPage2.Controls.Add((Control) this.txtCantidadLineasTicket);
      this.tabPage2.Controls.Add((Control) this.chkImpideVentaSinStockTicket);
      this.tabPage2.Controls.Add((Control) this.chkAlertaStockTicket);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(698, 153);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Ticket";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.label15.AutoSize = true;
      this.label15.Location = new Point(351, 108);
      this.label15.Name = "label15";
      this.label15.Size = new Size(155, 13);
      this.label15.TabIndex = 16;
      this.label15.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVTicket.Location = new Point(506, 105);
      this.txtDecimalesVVTicket.Name = "txtDecimalesVVTicket";
      this.txtDecimalesVVTicket.Size = new Size(59, 20);
      this.txtDecimalesVVTicket.TabIndex = 15;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(20, 111);
      this.label4.Name = "label4";
      this.label4.Size = new Size(146, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Cantidad de Lineas en Ticket";
      this.txtCantidadLineasTicket.Location = new Point(175, 108);
      this.txtCantidadLineasTicket.Name = "txtCantidadLineasTicket";
      this.txtCantidadLineasTicket.Size = new Size(59, 20);
      this.txtCantidadLineasTicket.TabIndex = 2;
      this.txtCantidadLineasTicket.KeyPress += new KeyPressEventHandler(this.txtCantidadLineasTicket_KeyPress);
      this.chkImpideVentaSinStockTicket.AutoSize = true;
      this.chkImpideVentaSinStockTicket.Location = new Point(23, 68);
      this.chkImpideVentaSinStockTicket.Name = "chkImpideVentaSinStockTicket";
      this.chkImpideVentaSinStockTicket.Size = new Size(140, 17);
      this.chkImpideVentaSinStockTicket.TabIndex = 1;
      this.chkImpideVentaSinStockTicket.Text = "Impedir Venta Sin Stock";
      this.chkImpideVentaSinStockTicket.UseVisualStyleBackColor = true;
      this.chkAlertaStockTicket.AutoSize = true;
      this.chkAlertaStockTicket.Location = new Point(23, 45);
      this.chkAlertaStockTicket.Name = "chkAlertaStockTicket";
      this.chkAlertaStockTicket.Size = new Size(141, 17);
      this.chkAlertaStockTicket.TabIndex = 0;
      this.chkAlertaStockTicket.Text = "Alerta Stock Insuficiente";
      this.chkAlertaStockTicket.UseVisualStyleBackColor = true;
      this.tabPage3.Controls.Add((Control) this.chkIniciarEnTicketBoleta);
      this.tabPage3.Controls.Add((Control) this.label16);
      this.tabPage3.Controls.Add((Control) this.txtDecimalesVVBoleta);
      this.tabPage3.Controls.Add((Control) this.gpbFiscal);
      this.tabPage3.Controls.Add((Control) this.chkImpideVentaSinStockBoleta);
      this.tabPage3.Controls.Add((Control) this.chkAlertaStockBoleta);
      this.tabPage3.Controls.Add((Control) this.label5);
      this.tabPage3.Controls.Add((Control) this.txtCantidadLineasBoleta);
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(698, 153);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Boleta";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.chkIniciarEnTicketBoleta.AutoSize = true;
      this.chkIniciarEnTicketBoleta.Location = new Point(23, 61);
      this.chkIniciarEnTicketBoleta.Name = "chkIniciarEnTicketBoleta";
      this.chkIniciarEnTicketBoleta.Size = new Size(165, 17);
      this.chkIniciarEnTicketBoleta.TabIndex = 20;
      this.chkIniciarEnTicketBoleta.Text = "Iniciar Boleta en N° de Ticket";
      this.chkIniciarEnTicketBoleta.UseVisualStyleBackColor = true;
      this.label16.AutoSize = true;
      this.label16.Location = new Point(20, 120);
      this.label16.Name = "label16";
      this.label16.Size = new Size(155, 13);
      this.label16.TabIndex = 19;
      this.label16.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVBoleta.Location = new Point(175, 117);
      this.txtDecimalesVVBoleta.Name = "txtDecimalesVVBoleta";
      this.txtDecimalesVVBoleta.Size = new Size(59, 20);
      this.txtDecimalesVVBoleta.TabIndex = 18;
      this.gpbFiscal.Controls.Add((Control) this.chkComprobanteExentos);
      this.gpbFiscal.Controls.Add((Control) this.label23);
      this.gpbFiscal.Controls.Add((Control) this.label22);
      this.gpbFiscal.Controls.Add((Control) this.rdbResumenDescripcion);
      this.gpbFiscal.Controls.Add((Control) this.rdbDescripcion);
      this.gpbFiscal.Controls.Add((Control) this.txtNumPuerto);
      this.gpbFiscal.Controls.Add((Control) this.label12);
      this.gpbFiscal.Location = new Point(240, 4);
      this.gpbFiscal.Name = "gpbFiscal";
      this.gpbFiscal.Size = new Size(452, 142);
      this.gpbFiscal.TabIndex = 17;
      this.gpbFiscal.TabStop = false;
      this.gpbFiscal.Text = "Fiscal";
      this.label23.Font = new Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label23.Location = new Point(3, 102);
      this.label23.Name = "label23";
      this.label23.Size = new Size(322, 35);
      this.label23.TabIndex = 5;
      this.label23.Text = "Ej: Descripcion = \"JUGO NARANJA\" Resumen = \"JUG. NAR.\" .......        La Boleta Fiscal solo imprime texto de 50 caracteres en la Descripcion";
      this.label22.AutoSize = true;
      this.label22.Location = new Point(3, 51);
      this.label22.Name = "label22";
      this.label22.Size = new Size(0, 13);
      this.label22.TabIndex = 4;
      this.rdbResumenDescripcion.AutoSize = true;
      this.rdbResumenDescripcion.Location = new Point(143, 82);
      this.rdbResumenDescripcion.Name = "rdbResumenDescripcion";
      this.rdbResumenDescripcion.Size = new Size(168, 17);
      this.rdbResumenDescripcion.TabIndex = 3;
      this.rdbResumenDescripcion.TabStop = true;
      this.rdbResumenDescripcion.Text = "Imprime Resumen Descripcion";
      this.rdbResumenDescripcion.UseVisualStyleBackColor = true;
      this.rdbDescripcion.AutoSize = true;
      this.rdbDescripcion.Location = new Point(6, 82);
      this.rdbDescripcion.Name = "rdbDescripcion";
      this.rdbDescripcion.Size = new Size(120, 17);
      this.rdbDescripcion.TabIndex = 2;
      this.rdbDescripcion.TabStop = true;
      this.rdbDescripcion.Text = "Imprime Descripcion";
      this.rdbDescripcion.UseVisualStyleBackColor = true;
      this.txtNumPuerto.Location = new Point(143, 17);
      this.txtNumPuerto.Name = "txtNumPuerto";
      this.txtNumPuerto.Size = new Size(51, 20);
      this.txtNumPuerto.TabIndex = 1;
      this.txtNumPuerto.KeyPress += new KeyPressEventHandler(this.txtNumPuerto_KeyPress);
      this.label12.AutoSize = true;
      this.label12.Location = new Point(6, 18);
      this.label12.Name = "label12";
      this.label12.Size = new Size(129, 13);
      this.label12.TabIndex = 0;
      this.label12.Text = "N° Puerto COM Impresora";
      this.chkImpideVentaSinStockBoleta.AutoSize = true;
      this.chkImpideVentaSinStockBoleta.Location = new Point(23, 38);
      this.chkImpideVentaSinStockBoleta.Name = "chkImpideVentaSinStockBoleta";
      this.chkImpideVentaSinStockBoleta.Size = new Size(140, 17);
      this.chkImpideVentaSinStockBoleta.TabIndex = 16;
      this.chkImpideVentaSinStockBoleta.Text = "Impedir Venta Sin Stock";
      this.chkImpideVentaSinStockBoleta.UseVisualStyleBackColor = true;
      this.chkAlertaStockBoleta.AutoSize = true;
      this.chkAlertaStockBoleta.Location = new Point(23, 15);
      this.chkAlertaStockBoleta.Name = "chkAlertaStockBoleta";
      this.chkAlertaStockBoleta.Size = new Size(141, 17);
      this.chkAlertaStockBoleta.TabIndex = 15;
      this.chkAlertaStockBoleta.Text = "Alerta Stock Insuficiente";
      this.chkAlertaStockBoleta.UseVisualStyleBackColor = true;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(20, 95);
      this.label5.Name = "label5";
      this.label5.Size = new Size(146, 13);
      this.label5.TabIndex = 14;
      this.label5.Text = "Cantidad de Lineas en Boleta";
      this.txtCantidadLineasBoleta.Location = new Point(175, 92);
      this.txtCantidadLineasBoleta.Name = "txtCantidadLineasBoleta";
      this.txtCantidadLineasBoleta.Size = new Size(59, 20);
      this.txtCantidadLineasBoleta.TabIndex = 13;
      this.txtCantidadLineasBoleta.KeyPress += new KeyPressEventHandler(this.txtCantidadLineasBoleta_KeyPress);
      this.tabPage4.Controls.Add((Control) this.label14);
      this.tabPage4.Controls.Add((Control) this.txtDecimalesVVGuia);
      this.tabPage4.Controls.Add((Control) this.chkImpideVentaSinStockGuia);
      this.tabPage4.Controls.Add((Control) this.chkAlertaStockGuia);
      this.tabPage4.Controls.Add((Control) this.label7);
      this.tabPage4.Controls.Add((Control) this.txtCantidadLineasGuia);
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(698, 153);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Guia de Despacho";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.label14.AutoSize = true;
      this.label14.Location = new Point(351, 108);
      this.label14.Name = "label14";
      this.label14.Size = new Size(155, 13);
      this.label14.TabIndex = 18;
      this.label14.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVGuia.Location = new Point(506, 105);
      this.txtDecimalesVVGuia.Name = "txtDecimalesVVGuia";
      this.txtDecimalesVVGuia.Size = new Size(59, 20);
      this.txtDecimalesVVGuia.TabIndex = 17;
      this.txtDecimalesVVGuia.KeyPress += new KeyPressEventHandler(this.txtDecimalesVVGuia_KeyPress);
      this.chkImpideVentaSinStockGuia.AutoSize = true;
      this.chkImpideVentaSinStockGuia.Location = new Point(23, 68);
      this.chkImpideVentaSinStockGuia.Name = "chkImpideVentaSinStockGuia";
      this.chkImpideVentaSinStockGuia.Size = new Size(140, 17);
      this.chkImpideVentaSinStockGuia.TabIndex = 16;
      this.chkImpideVentaSinStockGuia.Text = "Impedir Venta Sin Stock";
      this.chkImpideVentaSinStockGuia.UseVisualStyleBackColor = true;
      this.chkAlertaStockGuia.AutoSize = true;
      this.chkAlertaStockGuia.Location = new Point(23, 45);
      this.chkAlertaStockGuia.Name = "chkAlertaStockGuia";
      this.chkAlertaStockGuia.Size = new Size(141, 17);
      this.chkAlertaStockGuia.TabIndex = 15;
      this.chkAlertaStockGuia.Text = "Alerta Stock Insuficiente";
      this.chkAlertaStockGuia.UseVisualStyleBackColor = true;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(20, 111);
      this.label7.Name = "label7";
      this.label7.Size = new Size(138, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "Cantidad de Lineas en Guia";
      this.txtCantidadLineasGuia.Location = new Point(162, 108);
      this.txtCantidadLineasGuia.Name = "txtCantidadLineasGuia";
      this.txtCantidadLineasGuia.Size = new Size(59, 20);
      this.txtCantidadLineasGuia.TabIndex = 13;
      this.txtCantidadLineasGuia.KeyPress += new KeyPressEventHandler(this.txtCantidadLineasGuia_KeyPress);
      this.tabPage5.Controls.Add((Control) this.label17);
      this.tabPage5.Controls.Add((Control) this.txtDecimalesVVNotaCredito);
      this.tabPage5.Controls.Add((Control) this.label8);
      this.tabPage5.Controls.Add((Control) this.txtCantidadLineasNotaCredito);
      this.tabPage5.Location = new Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new Padding(3);
      this.tabPage5.Size = new Size(698, 153);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Nota Credito";
      this.tabPage5.UseVisualStyleBackColor = true;
      this.label17.AutoSize = true;
      this.label17.Location = new Point(351, 108);
      this.label17.Name = "label17";
      this.label17.Size = new Size(155, 13);
      this.label17.TabIndex = 16;
      this.label17.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVNotaCredito.Location = new Point(506, 105);
      this.txtDecimalesVVNotaCredito.Name = "txtDecimalesVVNotaCredito";
      this.txtDecimalesVVNotaCredito.Size = new Size(59, 20);
      this.txtDecimalesVVNotaCredito.TabIndex = 15;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(20, 111);
      this.label8.Name = "label8";
      this.label8.Size = new Size(190, 13);
      this.label8.TabIndex = 12;
      this.label8.Text = "Cantidad de Lineas en Nota de Credito";
      this.txtCantidadLineasNotaCredito.Location = new Point(213, 108);
      this.txtCantidadLineasNotaCredito.Name = "txtCantidadLineasNotaCredito";
      this.txtCantidadLineasNotaCredito.Size = new Size(59, 20);
      this.txtCantidadLineasNotaCredito.TabIndex = 11;
      this.txtCantidadLineasNotaCredito.KeyPress += new KeyPressEventHandler(this.txtCantidadLineasNotaCredito_KeyPress);
      this.tabPage6.Controls.Add((Control) this.label18);
      this.tabPage6.Controls.Add((Control) this.txtDecimalesVVCotizacion);
      this.tabPage6.Controls.Add((Control) this.chkImpideVentaSinStockCotizacion);
      this.tabPage6.Controls.Add((Control) this.chkAlertaStockCotizacion);
      this.tabPage6.Controls.Add((Control) this.label9);
      this.tabPage6.Controls.Add((Control) this.txtCantidadLineasCotizacion);
      this.tabPage6.Location = new Point(4, 22);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Padding = new Padding(3);
      this.tabPage6.Size = new Size(698, 153);
      this.tabPage6.TabIndex = 5;
      this.tabPage6.Text = "Cotización";
      this.tabPage6.UseVisualStyleBackColor = true;
      this.label18.AutoSize = true;
      this.label18.Location = new Point(351, 108);
      this.label18.Name = "label18";
      this.label18.Size = new Size(155, 13);
      this.label18.TabIndex = 18;
      this.label18.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVCotizacion.Location = new Point(506, 105);
      this.txtDecimalesVVCotizacion.Name = "txtDecimalesVVCotizacion";
      this.txtDecimalesVVCotizacion.Size = new Size(59, 20);
      this.txtDecimalesVVCotizacion.TabIndex = 17;
      this.chkImpideVentaSinStockCotizacion.AutoSize = true;
      this.chkImpideVentaSinStockCotizacion.Location = new Point(23, 68);
      this.chkImpideVentaSinStockCotizacion.Name = "chkImpideVentaSinStockCotizacion";
      this.chkImpideVentaSinStockCotizacion.Size = new Size(140, 17);
      this.chkImpideVentaSinStockCotizacion.TabIndex = 16;
      this.chkImpideVentaSinStockCotizacion.Text = "Impedir Venta Sin Stock";
      this.chkImpideVentaSinStockCotizacion.UseVisualStyleBackColor = true;
      this.chkAlertaStockCotizacion.AutoSize = true;
      this.chkAlertaStockCotizacion.Location = new Point(23, 45);
      this.chkAlertaStockCotizacion.Name = "chkAlertaStockCotizacion";
      this.chkAlertaStockCotizacion.Size = new Size(141, 17);
      this.chkAlertaStockCotizacion.TabIndex = 15;
      this.chkAlertaStockCotizacion.Text = "Alerta Stock Insuficiente";
      this.chkAlertaStockCotizacion.UseVisualStyleBackColor = true;
      this.label9.AutoSize = true;
      this.label9.Location = new Point(20, 111);
      this.label9.Name = "label9";
      this.label9.Size = new Size(165, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Cantidad de Lineas en Cotización";
      this.txtCantidadLineasCotizacion.Location = new Point(187, 108);
      this.txtCantidadLineasCotizacion.Name = "txtCantidadLineasCotizacion";
      this.txtCantidadLineasCotizacion.Size = new Size(59, 20);
      this.txtCantidadLineasCotizacion.TabIndex = 13;
      this.txtCantidadLineasCotizacion.KeyPress += new KeyPressEventHandler(this.txtCantidadLineasCotizacion_KeyPress);
      this.tabPage8.Controls.Add((Control) this.label19);
      this.tabPage8.Controls.Add((Control) this.txtDecimalesVVNotaVenta);
      this.tabPage8.Controls.Add((Control) this.chkImpideVentaSinStockNotaVenta);
      this.tabPage8.Controls.Add((Control) this.chkAlertaStockNotaVenta);
      this.tabPage8.Controls.Add((Control) this.label10);
      this.tabPage8.Controls.Add((Control) this.txtCantidadLineasNotaVenta);
      this.tabPage8.Location = new Point(4, 22);
      this.tabPage8.Name = "tabPage8";
      this.tabPage8.Padding = new Padding(3);
      this.tabPage8.Size = new Size(698, 153);
      this.tabPage8.TabIndex = 6;
      this.tabPage8.Text = "Nota Venta";
      this.tabPage8.UseVisualStyleBackColor = true;
      this.label19.AutoSize = true;
      this.label19.Location = new Point(351, 108);
      this.label19.Name = "label19";
      this.label19.Size = new Size(155, 13);
      this.label19.TabIndex = 18;
      this.label19.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVNotaVenta.Location = new Point(506, 105);
      this.txtDecimalesVVNotaVenta.Name = "txtDecimalesVVNotaVenta";
      this.txtDecimalesVVNotaVenta.Size = new Size(59, 20);
      this.txtDecimalesVVNotaVenta.TabIndex = 17;
      this.chkImpideVentaSinStockNotaVenta.AutoSize = true;
      this.chkImpideVentaSinStockNotaVenta.Location = new Point(23, 68);
      this.chkImpideVentaSinStockNotaVenta.Name = "chkImpideVentaSinStockNotaVenta";
      this.chkImpideVentaSinStockNotaVenta.Size = new Size(140, 17);
      this.chkImpideVentaSinStockNotaVenta.TabIndex = 16;
      this.chkImpideVentaSinStockNotaVenta.Text = "Impedir Venta Sin Stock";
      this.chkImpideVentaSinStockNotaVenta.UseVisualStyleBackColor = true;
      this.chkAlertaStockNotaVenta.AutoSize = true;
      this.chkAlertaStockNotaVenta.Location = new Point(23, 45);
      this.chkAlertaStockNotaVenta.Name = "chkAlertaStockNotaVenta";
      this.chkAlertaStockNotaVenta.Size = new Size(141, 17);
      this.chkAlertaStockNotaVenta.TabIndex = 15;
      this.chkAlertaStockNotaVenta.Text = "Alerta Stock Insuficiente";
      this.chkAlertaStockNotaVenta.UseVisualStyleBackColor = true;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(20, 111);
      this.label10.Name = "label10";
      this.label10.Size = new Size(170, 13);
      this.label10.TabIndex = 14;
      this.label10.Text = "Cantidad de Lineas en Nota Venta";
      this.txtCantidadLineasNotaVenta.Location = new Point(192, 108);
      this.txtCantidadLineasNotaVenta.Name = "txtCantidadLineasNotaVenta";
      this.txtCantidadLineasNotaVenta.Size = new Size(59, 20);
      this.txtCantidadLineasNotaVenta.TabIndex = 13;
      this.txtCantidadLineasNotaVenta.KeyPress += new KeyPressEventHandler(this.txtCantidadLineasNotaVenta_KeyPress);
      this.tabPage9.Controls.Add((Control) this.label20);
      this.tabPage9.Controls.Add((Control) this.txtDecimalesVVFacturaExenta);
      this.tabPage9.Controls.Add((Control) this.chkImpideVentaSinStockFacturaExenta);
      this.tabPage9.Controls.Add((Control) this.chkAlertaStockFacturaExenta);
      this.tabPage9.Controls.Add((Control) this.label11);
      this.tabPage9.Controls.Add((Control) this.txtCantidadLineasFacturaExenta);
      this.tabPage9.Location = new Point(4, 22);
      this.tabPage9.Name = "tabPage9";
      this.tabPage9.Padding = new Padding(3);
      this.tabPage9.Size = new Size(698, 153);
      this.tabPage9.TabIndex = 7;
      this.tabPage9.Text = "Factura Exenta";
      this.tabPage9.UseVisualStyleBackColor = true;
      this.label20.AutoSize = true;
      this.label20.Location = new Point(351, 108);
      this.label20.Name = "label20";
      this.label20.Size = new Size(155, 13);
      this.label20.TabIndex = 18;
      this.label20.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVFacturaExenta.Location = new Point(506, 105);
      this.txtDecimalesVVFacturaExenta.Name = "txtDecimalesVVFacturaExenta";
      this.txtDecimalesVVFacturaExenta.Size = new Size(59, 20);
      this.txtDecimalesVVFacturaExenta.TabIndex = 17;
      this.chkImpideVentaSinStockFacturaExenta.AutoSize = true;
      this.chkImpideVentaSinStockFacturaExenta.Location = new Point(23, 68);
      this.chkImpideVentaSinStockFacturaExenta.Name = "chkImpideVentaSinStockFacturaExenta";
      this.chkImpideVentaSinStockFacturaExenta.Size = new Size(140, 17);
      this.chkImpideVentaSinStockFacturaExenta.TabIndex = 16;
      this.chkImpideVentaSinStockFacturaExenta.Text = "Impedir Venta Sin Stock";
      this.chkImpideVentaSinStockFacturaExenta.UseVisualStyleBackColor = true;
      this.chkAlertaStockFacturaExenta.AutoSize = true;
      this.chkAlertaStockFacturaExenta.Location = new Point(23, 45);
      this.chkAlertaStockFacturaExenta.Name = "chkAlertaStockFacturaExenta";
      this.chkAlertaStockFacturaExenta.Size = new Size(141, 17);
      this.chkAlertaStockFacturaExenta.TabIndex = 15;
      this.chkAlertaStockFacturaExenta.Text = "Alerta Stock Insuficiente";
      this.chkAlertaStockFacturaExenta.UseVisualStyleBackColor = true;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(20, 111);
      this.label11.Name = "label11";
      this.label11.Size = new Size(188, 13);
      this.label11.TabIndex = 14;
      this.label11.Text = "Cantidad de Lineas en Factura Exenta";
      this.txtCantidadLineasFacturaExenta.Location = new Point(210, 108);
      this.txtCantidadLineasFacturaExenta.Name = "txtCantidadLineasFacturaExenta";
      this.txtCantidadLineasFacturaExenta.Size = new Size(59, 20);
      this.txtCantidadLineasFacturaExenta.TabIndex = 13;
      this.tabPage11.Controls.Add((Control) this.label21);
      this.tabPage11.Controls.Add((Control) this.txtDecimalesVVCompra);
      this.tabPage11.Location = new Point(4, 22);
      this.tabPage11.Name = "tabPage11";
      this.tabPage11.Padding = new Padding(3);
      this.tabPage11.Size = new Size(698, 153);
      this.tabPage11.TabIndex = 8;
      this.tabPage11.Text = "Compras";
      this.tabPage11.UseVisualStyleBackColor = true;
      this.label21.AutoSize = true;
      this.label21.Location = new Point(342, 108);
      this.label21.Name = "label21";
      this.label21.Size = new Size(163, 13);
      this.label21.TabIndex = 20;
      this.label21.Text = "Decimales en Valores de Compra";
      this.txtDecimalesVVCompra.Location = new Point(506, 105);
      this.txtDecimalesVVCompra.Name = "txtDecimalesVVCompra";
      this.txtDecimalesVVCompra.Size = new Size(59, 20);
      this.txtDecimalesVVCompra.TabIndex = 19;
      this.tabPage12.Controls.Add((Control) this.chkEnvioAutomaticoSIIEFactura);
      this.tabPage12.Controls.Add((Control) this.label25);
      this.tabPage12.Controls.Add((Control) this.txtDecimalesVVEFactura);
      this.tabPage12.Controls.Add((Control) this.chkImpideVentaSinStockEFactura);
      this.tabPage12.Controls.Add((Control) this.chkAlertaStockEFactura);
      this.tabPage12.Controls.Add((Control) this.label26);
      this.tabPage12.Controls.Add((Control) this.txtCantidadLineasEFactura);
      this.tabPage12.Location = new Point(4, 22);
      this.tabPage12.Name = "tabPage12";
      this.tabPage12.Padding = new Padding(3);
      this.tabPage12.Size = new Size(698, 153);
      this.tabPage12.TabIndex = 9;
      this.tabPage12.Text = "Factura Electronica";
      this.tabPage12.UseVisualStyleBackColor = true;
      this.chkEnvioAutomaticoSIIEFactura.AutoSize = true;
      this.chkEnvioAutomaticoSIIEFactura.Location = new Point(354, 45);
      this.chkEnvioAutomaticoSIIEFactura.Name = "chkEnvioAutomaticoSIIEFactura";
      this.chkEnvioAutomaticoSIIEFactura.Size = new Size(134, 17);
      this.chkEnvioAutomaticoSIIEFactura.TabIndex = 21;
      this.chkEnvioAutomaticoSIIEFactura.Text = "Envio Automatico a SII";
      this.chkEnvioAutomaticoSIIEFactura.UseVisualStyleBackColor = true;
      this.label25.AutoSize = true;
      this.label25.Location = new Point(351, 108);
      this.label25.Name = "label25";
      this.label25.Size = new Size(155, 13);
      this.label25.TabIndex = 20;
      this.label25.Text = "Decimales en Valores de Venta";
      this.txtDecimalesVVEFactura.Location = new Point(506, 105);
      this.txtDecimalesVVEFactura.Name = "txtDecimalesVVEFactura";
      this.txtDecimalesVVEFactura.Size = new Size(59, 20);
      this.txtDecimalesVVEFactura.TabIndex = 19;
      this.chkImpideVentaSinStockEFactura.AutoSize = true;
      this.chkImpideVentaSinStockEFactura.Location = new Point(23, 68);
      this.chkImpideVentaSinStockEFactura.Name = "chkImpideVentaSinStockEFactura";
      this.chkImpideVentaSinStockEFactura.Size = new Size(140, 17);
      this.chkImpideVentaSinStockEFactura.TabIndex = 18;
      this.chkImpideVentaSinStockEFactura.Text = "Impedir Venta Sin Stock";
      this.chkImpideVentaSinStockEFactura.UseVisualStyleBackColor = true;
      this.chkAlertaStockEFactura.AutoSize = true;
      this.chkAlertaStockEFactura.Location = new Point(23, 45);
      this.chkAlertaStockEFactura.Name = "chkAlertaStockEFactura";
      this.chkAlertaStockEFactura.Size = new Size(141, 17);
      this.chkAlertaStockEFactura.TabIndex = 17;
      this.chkAlertaStockEFactura.Text = "Alerta Stock Insuficiente";
      this.chkAlertaStockEFactura.UseVisualStyleBackColor = true;
      this.label26.AutoSize = true;
      this.label26.Location = new Point(20, 111);
      this.label26.Name = "label26";
      this.label26.Size = new Size(152, 13);
      this.label26.TabIndex = 16;
      this.label26.Text = "Cantidad de Lineas en Factura";
      this.txtCantidadLineasEFactura.Location = new Point(175, 108);
      this.txtCantidadLineasEFactura.Name = "txtCantidadLineasEFactura";
      this.txtCantidadLineasEFactura.Size = new Size(59, 20);
      this.txtCantidadLineasEFactura.TabIndex = 15;
      this.btnGuardar.Location = new Point(12, 341);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 34);
      this.btnGuardar.TabIndex = 2;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnSalir.Location = new Point(643, 338);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 34);
      this.btnSalir.TabIndex = 3;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.tabControl2.Controls.Add((Control) this.tabPage7);
      this.tabControl2.Controls.Add((Control) this.tabPage10);
      this.tabControl2.Location = new Point(12, 12);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(583, 140);
      this.tabControl2.TabIndex = 4;
      this.tabPage7.Controls.Add((Control) this.gpbPesable);
      this.tabPage7.Controls.Add((Control) this.rdbSinIva);
      this.tabPage7.Controls.Add((Control) this.label1);
      this.tabPage7.Controls.Add((Control) this.rdbConIva);
      this.tabPage7.Controls.Add((Control) this.label2);
      this.tabPage7.Controls.Add((Control) this.label3);
      this.tabPage7.Controls.Add((Control) this.txtIva);
      this.tabPage7.Location = new Point(4, 22);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Padding = new Padding(3);
      this.tabPage7.Size = new Size(575, 114);
      this.tabPage7.TabIndex = 0;
      this.tabPage7.Text = "Opciones Generales";
      this.tabPage7.UseVisualStyleBackColor = true;
      this.gpbPesable.Controls.Add((Control) this.txtCodigoPesable);
      this.gpbPesable.Controls.Add((Control) this.label24);
      this.gpbPesable.Location = new Point(305, 6);
      this.gpbPesable.Name = "gpbPesable";
      this.gpbPesable.Size = new Size(260, 102);
      this.gpbPesable.TabIndex = 6;
      this.gpbPesable.TabStop = false;
      this.gpbPesable.Text = "Productos Pesables";
      this.txtCodigoPesable.Location = new Point(130, 48);
      this.txtCodigoPesable.Name = "txtCodigoPesable";
      this.txtCodigoPesable.Size = new Size(52, 20);
      this.txtCodigoPesable.TabIndex = 1;
      this.txtCodigoPesable.KeyPress += new KeyPressEventHandler(this.txtPesable_KeyPress);
      this.label24.AutoSize = true;
      this.label24.Location = new Point(15, 52);
      this.label24.Name = "label24";
      this.label24.Size = new Size(109, 13);
      this.label24.TabIndex = 0;
      this.label24.Text = "Inicio Codigo Pesable";
      this.tabPage10.Controls.Add((Control) this.gpbVerificaCredito);
      this.tabPage10.Controls.Add((Control) this.chkImpideVentas);
      this.tabPage10.Controls.Add((Control) this.chkVerificaCredito);
      this.tabPage10.Location = new Point(4, 22);
      this.tabPage10.Name = "tabPage10";
      this.tabPage10.Padding = new Padding(3);
      this.tabPage10.Size = new Size(575, 114);
      this.tabPage10.TabIndex = 1;
      this.tabPage10.Text = "Credito";
      this.tabPage10.UseVisualStyleBackColor = true;
      this.gpbVerificaCredito.Controls.Add((Control) this.chkVerificaGuias);
      this.gpbVerificaCredito.Controls.Add((Control) this.chkVerificaBoleta);
      this.gpbVerificaCredito.Controls.Add((Control) this.chkVerificaFacturaExenta);
      this.gpbVerificaCredito.Controls.Add((Control) this.chkVerificaFactura);
      this.gpbVerificaCredito.Location = new Point(253, 3);
      this.gpbVerificaCredito.Name = "gpbVerificaCredito";
      this.gpbVerificaCredito.Size = new Size(315, 106);
      this.gpbVerificaCredito.TabIndex = 2;
      this.gpbVerificaCredito.TabStop = false;
      this.gpbVerificaCredito.Text = "Documentos incluidos en verificación de Credito";
      this.chkVerificaGuias.AutoSize = true;
      this.chkVerificaGuias.Location = new Point(10, 81);
      this.chkVerificaGuias.Name = "chkVerificaGuias";
      this.chkVerificaGuias.Size = new Size(113, 17);
      this.chkVerificaGuias.TabIndex = 3;
      this.chkVerificaGuias.Text = "Guias Sin Facturar";
      this.chkVerificaGuias.UseVisualStyleBackColor = true;
      this.chkVerificaBoleta.AutoSize = true;
      this.chkVerificaBoleta.Location = new Point(10, 61);
      this.chkVerificaBoleta.Name = "chkVerificaBoleta";
      this.chkVerificaBoleta.Size = new Size(61, 17);
      this.chkVerificaBoleta.TabIndex = 2;
      this.chkVerificaBoleta.Text = "Boletas";
      this.chkVerificaBoleta.UseVisualStyleBackColor = true;
      this.chkVerificaFacturaExenta.AutoSize = true;
      this.chkVerificaFacturaExenta.Location = new Point(10, 41);
      this.chkVerificaFacturaExenta.Name = "chkVerificaFacturaExenta";
      this.chkVerificaFacturaExenta.Size = new Size(98, 17);
      this.chkVerificaFacturaExenta.TabIndex = 1;
      this.chkVerificaFacturaExenta.Text = "Factura Exenta";
      this.chkVerificaFacturaExenta.UseVisualStyleBackColor = true;
      this.chkVerificaFactura.AutoSize = true;
      this.chkVerificaFactura.Location = new Point(10, 21);
      this.chkVerificaFactura.Name = "chkVerificaFactura";
      this.chkVerificaFactura.Size = new Size(111, 17);
      this.chkVerificaFactura.TabIndex = 0;
      this.chkVerificaFactura.Text = "Factura de Venta ";
      this.chkVerificaFactura.UseVisualStyleBackColor = true;
      this.chkImpideVentas.AutoSize = true;
      this.chkImpideVentas.Location = new Point(23, 49);
      this.chkImpideVentas.Name = "chkImpideVentas";
      this.chkImpideVentas.Size = new Size(147, 17);
      this.chkImpideVentas.TabIndex = 1;
      this.chkImpideVentas.Text = "Impedir ventas sin Credito";
      this.chkImpideVentas.UseVisualStyleBackColor = true;
      this.chkVerificaCredito.AutoSize = true;
      this.chkVerificaCredito.Location = new Point(23, 26);
      this.chkVerificaCredito.Name = "chkVerificaCredito";
      this.chkVerificaCredito.Size = new Size(155, 17);
      this.chkVerificaCredito.TabIndex = 0;
      this.chkVerificaCredito.Text = "Verificar Credito de Clientes";
      this.chkVerificaCredito.UseVisualStyleBackColor = true;
      this.chkVerificaCredito.CheckedChanged += new EventHandler(this.chkVerificaCredito_CheckedChanged);
      this.chkComprobanteExentos.AutoSize = true;
      this.chkComprobanteExentos.Location = new Point(6, 50);
      this.chkComprobanteExentos.Name = "chkComprobanteExentos";
      this.chkComprobanteExentos.Size = new Size(219, 17);
      this.chkComprobanteExentos.TabIndex = 21;
      this.chkComprobanteExentos.Text = "Imprime Comprobante productos Exentos";
      this.chkComprobanteExentos.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(730, 387);
      this.Controls.Add((Control) this.tabControl2);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.tabControl1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmOpciones";
      this.ShowIcon = false;
      this.Text = "Opciones Generales";
      this.FormClosing += new FormClosingEventHandler(this.frmOpciones_FormClosing);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.gpbFiscal.ResumeLayout(false);
      this.gpbFiscal.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.tabPage6.ResumeLayout(false);
      this.tabPage6.PerformLayout();
      this.tabPage8.ResumeLayout(false);
      this.tabPage8.PerformLayout();
      this.tabPage9.ResumeLayout(false);
      this.tabPage9.PerformLayout();
      this.tabPage11.ResumeLayout(false);
      this.tabPage11.PerformLayout();
      this.tabPage12.ResumeLayout(false);
      this.tabPage12.PerformLayout();
      this.tabControl2.ResumeLayout(false);
      this.tabPage7.ResumeLayout(false);
      this.tabPage7.PerformLayout();
      this.gpbPesable.ResumeLayout(false);
      this.gpbPesable.PerformLayout();
      this.tabPage10.ResumeLayout(false);
      this.tabPage10.PerformLayout();
      this.gpbVerificaCredito.ResumeLayout(false);
      this.gpbVerificaCredito.PerformLayout();
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

    private void iniciaFormularioOpciones()
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
      OpcionesGenerales opcionesGenerales = new OpcionesGenerales();
      try
      {
        OpcionesGeneralesVO opcionesGeneralesVo = opcionesGenerales.rescataOpcionesGenerales();
        this.idOpcionesGenerales = opcionesGeneralesVo.IdOpciones;
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
      try
      {
        foreach (OpcionesDocumentosVO opcionesDocumentosVo in opcionesGenerales.rescataOpcionesDocumentos())
        {
          int num;
          if (opcionesDocumentosVo.NombreDocumento.Equals("FACTURA"))
          {
            this.txtCantidadLineasFactura.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            this.chkAlertaStockFactura.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
            this.chkImpideVentaSinStockFactura.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
            TextBox textBox = this.txtDecimalesVVFactura;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
            this.chkCotizacionCompleta.Checked = opcionesDocumentosVo.FacturarCotizacionCompleta.Equals("1");
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("TICKET"))
          {
            this.txtCantidadLineasTicket.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            this.chkAlertaStockTicket.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
            this.chkImpideVentaSinStockTicket.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
            TextBox textBox = this.txtDecimalesVVTicket;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("BOLETA"))
          {
            this.txtCantidadLineasBoleta.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            this.chkAlertaStockBoleta.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
            this.chkImpideVentaSinStockBoleta.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
            TextBox textBox1 = this.txtNumPuerto;
            num = opcionesDocumentosVo.PuertoImpresoraFiscal;
            string str1 = num.ToString();
            textBox1.Text = str1;
            TextBox textBox2 = this.txtDecimalesVVBoleta;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str2 = num.ToString();
            textBox2.Text = str2;
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
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("GUIA"))
          {
            this.txtCantidadLineasGuia.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            this.chkAlertaStockGuia.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
            this.chkImpideVentaSinStockGuia.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
            TextBox textBox = this.txtDecimalesVVGuia;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("NOTA_CREDITO"))
          {
            this.txtCantidadLineasNotaCredito.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            TextBox textBox = this.txtDecimalesVVNotaCredito;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("COTIZACION"))
          {
            this.txtCantidadLineasCotizacion.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            this.chkAlertaStockCotizacion.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
            this.chkImpideVentaSinStockCotizacion.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
            TextBox textBox = this.txtDecimalesVVCotizacion;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("NOTA_VENTA"))
          {
            this.txtCantidadLineasNotaVenta.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            this.chkAlertaStockNotaVenta.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
            this.chkImpideVentaSinStockNotaVenta.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
            TextBox textBox = this.txtDecimalesVVNotaVenta;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("FACTURA_EXENTA"))
          {
            this.txtCantidadLineasFacturaExenta.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            this.chkAlertaStockFacturaExenta.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
            this.chkImpideVentaSinStockFacturaExenta.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
            TextBox textBox = this.txtDecimalesVVFacturaExenta;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("COMPRA"))
          {
            TextBox textBox = this.txtDecimalesVVCompra;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
          }
          if (opcionesDocumentosVo.NombreDocumento.Equals("E-FACTURA"))
          {
            this.txtCantidadLineasEFactura.Text = opcionesDocumentosVo.CantidadLineasDocumento;
            this.chkAlertaStockEFactura.Checked = opcionesDocumentosVo.AlertaStockInsuficiente.Equals("1");
            this.chkImpideVentaSinStockEFactura.Checked = opcionesDocumentosVo.ImpideVentasSinStock.Equals("1");
            TextBox textBox = this.txtDecimalesVVEFactura;
            num = opcionesDocumentosVo.DecimalesValorVenta;
            string str = num.ToString();
            textBox.Text = str;
            this.chkEnvioAutomaticoSIIEFactura.Checked = opcionesDocumentosVo.EnvioAutomaticoSII.Equals("1");
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al cargar Opciones de Documento: " + ex.Message);
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      OpcionesGenerales opcionesGenerales = new OpcionesGenerales();
      OpcionesGeneralesVO ogVO = new OpcionesGeneralesVO();
      ogVO.IdOpciones = this.idOpcionesGenerales;
      ogVO.PorcentajeIva = Convert.ToDecimal(this.txtIva.Text.Trim());
      ogVO.valoresVentaConIva = this.rdbConIva.Checked ? "1" : "0";
      ogVO.CodigoPesable = Convert.ToInt32(this.txtCodigoPesable.Text.Trim());
      ogVO.VerificaCredito = this.chkVerificaCredito.Checked;
      ogVO.ImpedirVentasSinCredito = this.chkImpideVentas.Checked;
      ogVO.VerificaFactura = this.chkVerificaFactura.Checked;
      ogVO.VerificaFacturaExenta = this.chkVerificaFacturaExenta.Checked;
      ogVO.VerificaBoleta = this.chkVerificaBoleta.Checked;
      ogVO.VerificaGuiaSinFacturar = this.chkVerificaGuias.Checked;
      OpcionesDocumentosVO opcionesDocumentosVo = new OpcionesDocumentosVO();
      List<OpcionesDocumentosVO> lista = new List<OpcionesDocumentosVO>();
      opcionesDocumentosVo.NombreDocumento = "FACTURA";
      opcionesDocumentosVo.AlertaStockInsuficiente = this.chkAlertaStockFactura.Checked ? "1" : "0";
      opcionesDocumentosVo.ImpideVentasSinStock = this.chkImpideVentaSinStockFactura.Checked ? "1" : "0";
      opcionesDocumentosVo.CantidadLineasDocumento = this.txtCantidadLineasFactura.Text.Trim();
      opcionesDocumentosVo.PuertoImpresoraFiscal = 0;
      opcionesDocumentosVo.DecimalesValorVenta = this.txtDecimalesVVFactura.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVFactura.Text.Trim()) : 0;
      opcionesDocumentosVo.Descripcion_Resumen = "DESCRIPCION";
      opcionesDocumentosVo.iniciarEnNumeroTicket = "0";
      opcionesDocumentosVo.FacturarCotizacionCompleta = this.chkCotizacionCompleta.Checked ? "1" : "0";
      opcionesDocumentosVo.ComprobanteExentos = "0";
      lista.Add(opcionesDocumentosVo);
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "TICKET",
        AlertaStockInsuficiente = this.chkAlertaStockTicket.Checked ? "1" : "0",
        ImpideVentasSinStock = this.chkImpideVentaSinStockTicket.Checked ? "1" : "0",
        CantidadLineasDocumento = this.txtCantidadLineasTicket.Text.Trim(),
        PuertoImpresoraFiscal = 0,
        DecimalesValorVenta = this.txtDecimalesVVTicket.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVTicket.Text.Trim()) : 0,
        Descripcion_Resumen = "DESCRIPCION",
        iniciarEnNumeroTicket = "0",
        FacturarCotizacionCompleta = "0",
        ComprobanteExentos = "0"
      });
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "BOLETA",
        AlertaStockInsuficiente = this.chkAlertaStockBoleta.Checked ? "1" : "0",
        ImpideVentasSinStock = this.chkImpideVentaSinStockBoleta.Checked ? "1" : "0",
        CantidadLineasDocumento = this.txtCantidadLineasBoleta.Text.Trim(),
        PuertoImpresoraFiscal = Convert.ToInt32(this.txtNumPuerto.Text),
        DecimalesValorVenta = this.txtDecimalesVVBoleta.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVBoleta.Text.Trim()) : 0,
        Descripcion_Resumen = this.rdbDescripcion.Checked ? "DESCRIPCION" : "RESUMEN",
        iniciarEnNumeroTicket = this.chkIniciarEnTicketBoleta.Checked ? "1" : "0",
        FacturarCotizacionCompleta = "0",
        ComprobanteExentos = this.chkComprobanteExentos.Checked ? "1" : "0"
      });
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "GUIA",
        AlertaStockInsuficiente = this.chkAlertaStockGuia.Checked ? "1" : "0",
        ImpideVentasSinStock = this.chkImpideVentaSinStockGuia.Checked ? "1" : "0",
        CantidadLineasDocumento = this.txtCantidadLineasGuia.Text.Trim(),
        PuertoImpresoraFiscal = 0,
        DecimalesValorVenta = this.txtDecimalesVVGuia.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVGuia.Text.Trim()) : 0,
        Descripcion_Resumen = "DESCRIPCION",
        iniciarEnNumeroTicket = "0",
        FacturarCotizacionCompleta = "0",
        ComprobanteExentos = "0"
      });
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "NOTA_CREDITO",
        AlertaStockInsuficiente = "0",
        ImpideVentasSinStock = "0",
        CantidadLineasDocumento = this.txtCantidadLineasNotaCredito.Text.Trim(),
        PuertoImpresoraFiscal = 0,
        DecimalesValorVenta = this.txtDecimalesVVNotaCredito.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVNotaCredito.Text.Trim()) : 0,
        Descripcion_Resumen = "DESCRIPCION",
        iniciarEnNumeroTicket = "0",
        FacturarCotizacionCompleta = "0",
        ComprobanteExentos = "0"
      });
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "COTIZACION",
        AlertaStockInsuficiente = this.chkAlertaStockCotizacion.Checked ? "1" : "0",
        ImpideVentasSinStock = this.chkImpideVentaSinStockCotizacion.Checked ? "1" : "0",
        CantidadLineasDocumento = this.txtCantidadLineasCotizacion.Text.Trim(),
        PuertoImpresoraFiscal = 0,
        DecimalesValorVenta = this.txtDecimalesVVCotizacion.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVCotizacion.Text.Trim()) : 0,
        Descripcion_Resumen = "DESCRIPCION",
        iniciarEnNumeroTicket = "0",
        FacturarCotizacionCompleta = "0",
        ComprobanteExentos = "0"
      });
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "NOTA_VENTA",
        AlertaStockInsuficiente = this.chkAlertaStockNotaVenta.Checked ? "1" : "0",
        ImpideVentasSinStock = this.chkImpideVentaSinStockNotaVenta.Checked ? "1" : "0",
        CantidadLineasDocumento = this.txtCantidadLineasNotaVenta.Text.Trim(),
        PuertoImpresoraFiscal = 0,
        DecimalesValorVenta = this.txtDecimalesVVNotaVenta.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVNotaVenta.Text.Trim()) : 0,
        Descripcion_Resumen = "DESCRIPCION",
        iniciarEnNumeroTicket = "0",
        FacturarCotizacionCompleta = "0",
        ComprobanteExentos = "0"
      });
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "FACTURA_EXENTA",
        AlertaStockInsuficiente = this.chkAlertaStockFacturaExenta.Checked ? "1" : "0",
        ImpideVentasSinStock = this.chkImpideVentaSinStockFacturaExenta.Checked ? "1" : "0",
        CantidadLineasDocumento = this.txtCantidadLineasFacturaExenta.Text.Trim(),
        PuertoImpresoraFiscal = 0,
        DecimalesValorVenta = this.txtDecimalesVVFacturaExenta.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVFacturaExenta.Text.Trim()) : 0,
        Descripcion_Resumen = "DESCRIPCION",
        iniciarEnNumeroTicket = "0",
        FacturarCotizacionCompleta = "0",
        ComprobanteExentos = "0"
      });
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "COMPRA",
        AlertaStockInsuficiente = "0",
        ImpideVentasSinStock = "0",
        CantidadLineasDocumento = "0",
        PuertoImpresoraFiscal = 0,
        DecimalesValorVenta = this.txtDecimalesVVCompra.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVCompra.Text.Trim()) : 0,
        Descripcion_Resumen = "DESCRIPCION",
        iniciarEnNumeroTicket = "0",
        FacturarCotizacionCompleta = "0",
        ComprobanteExentos = "0"
      });
      lista.Add(new OpcionesDocumentosVO()
      {
        NombreDocumento = "E-FACTURA",
        AlertaStockInsuficiente = this.chkAlertaStockEFactura.Checked ? "1" : "0",
        ImpideVentasSinStock = this.chkImpideVentaSinStockEFactura.Checked ? "1" : "0",
        CantidadLineasDocumento = this.txtCantidadLineasEFactura.Text.Trim(),
        PuertoImpresoraFiscal = 0,
        DecimalesValorVenta = this.txtDecimalesVVEFactura.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtDecimalesVVEFactura.Text.Trim()) : 0,
        Descripcion_Resumen = "DESCRIPCION",
        iniciarEnNumeroTicket = "0",
        FacturarCotizacionCompleta = "0",
        EnvioAutomaticoSII = this.chkEnvioAutomaticoSIIEFactura.Checked ? "1" : "0",
        ComprobanteExentos = "0"
      });
      try
      {
        opcionesGenerales.guardaOpciones(ogVO, lista);
        this.guardaPuertoImpresora();
        int num = (int) MessageBox.Show("GUARDADO", "Guarda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormularioOpciones();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar Opciones: " + ex.Message);
      }
    }

    private void guardaPuertoImpresora()
    {
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

    private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtIva);
    }

    private void txtCantidadLineasFactura_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidadLineasFactura);
    }

    private void txtCantidadLineasTicket_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidadLineasTicket);
    }

    private void txtCantidadLineasBoleta_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidadLineasBoleta);
    }

    private void txtCantidadLineasGuia_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidadLineasGuia);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      this.Dispose();
      frmMenuPrincipal._modOpciones = 0;
    }

    private void txtCantidadLineasNotaCredito_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidadLineasNotaCredito);
    }

    private void txtCantidadLineasCotizacion_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidadLineasCotizacion);
    }

    private void frmOpciones_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modOpciones = 0;
    }

    private void txtCantidadLineasNotaVenta_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidadLineasNotaVenta);
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

    private void txtDecimalesVVFactura_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtDecimalesVVFactura);
    }

    private void txtDecimalesVVGuia_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtDecimalesVVGuia);
    }

    private void txtNumPuerto_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtNumPuerto);
    }

    private void txtPesable_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCodigoPesable);
    }
  }
}
