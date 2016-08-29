
using CrystalDecisions.CrystalReports.Engine;
using Aptusoft.DtsReportesTableAdapters;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Formularios;
//using Aptusoft.Logistica;
//using Aptusoft.Promoimport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmPagoVenta : Form
  {
    private static List<PagoVentaVO> listaPago = new List<PagoVentaVO>();
    private static int _linea = 0;
    private static int idDoc = 0;
    private frmFactura frmFac = (frmFactura) null;

    private frmFacturaExenta frmFacExe = (frmFacturaExenta) null;
    private frmBoleta frmBol = (frmBoleta) null;
    private frmBoletaFiscal frmBolFis = (frmBoletaFiscal) null;
    private frmModuloFacturacionAptusoft frmMFF = (frmModuloFacturacionAptusoft) null;
    private frmFacturaElectronica frmFacElec = (frmFacturaElectronica) null;
    private frmFacturaElectronicaFrigo frmFacElecFrigo = (frmFacturaElectronicaFrigo)null;
    private frmFacturaExentaElectronica frmFacExeElec = (frmFacturaExentaElectronica) null;
    private frmBoletaElectronica frmBolElec = (frmBoletaElectronica) null;
    private frmNotaVenta frmNotaVe = (frmNotaVenta) null;
    private int idCliente = 0;
    private int _caja = 0;
    private string _tipoNotaCredito = "";
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private TextBox txtRazonSocial;
    private ComboBox cmbTipoDocumento;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label label4;
    private TextBox txtEmision;
    private TextBox txtFolio;
    private GroupBox groupBox2;
    private Label label5;
    private TextBox txtTotalFactura;
    private Button btnBuscar;
    private TextBox txtTotalPendiente;
    private TextBox txtTotalDocumentado;
    private TextBox txtTotalPagado;
    private Label label8;
    private Label label7;
    private Label label6;
    private RadioButton rdbDocumentado;
    private RadioButton rdbPagado;
    private ComboBox cmbMedioPago;
    private Label label9;
    private DateTimePicker dtpFechaCobro;
    private Label label11;
    private TextBox txtMonto;
    private Label label10;
    private TextBox txtCuenta;
    private ComboBox cmbBanco;
    private Label label15;
    private Label label14;
    private Label label13;
    private Label label12;
    private TextBox txtObservaciones;
    private TextBox txtNumeroDocumento;
    private DataGridView dgvDetalle;
    private Button btnAgregar;
    private Button btnLimpiar;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnImprimir;
    private Button btnLimpiarFormulario;
    private Button btnSalir;
    private Label lblEstadoPago;
    private Panel panel1;
    private TextBox txtRut;
    private Button btnModificaLinea;
    private Button btnLimpiaDetalle;
    private GroupBox groupBox3;
    private Label label16;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private DataGridView dgvNC;
    private Panel pnlRecuedroNC;
    private Button btnCerrar;
    private Button btnPagar;
    private TextBox txtMontoUsar;
    private TextBox txtMontoDisponible;
    private TextBox txtFolioNC;
    private Label label19;
    private Label label18;
    private Label label17;
    private TicketTableAdapter ticketTableAdapter1;

    public frmPagoVenta()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
    }

    public frmPagoVenta(ref frmFactura f, string modulo, int folio, int idCli)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmFac = f;
      this.buscaFactura(folio, modulo);
      this.txtFolio.Text = folio.ToString();
      this.idCliente = idCli;
      this.cargaListaNotaCredito();
    }


    public frmPagoVenta(ref frmNotaVenta nv, string modulo, int folio, int idCli)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmNotaVe = nv;
      this.buscaFactura(folio, modulo);
      this.txtFolio.Text = folio.ToString();
      this.idCliente = idCli;
      this.cargaListaNotaCredito();
    }

    public frmPagoVenta(ref frmFacturaExenta fe, string modulo, int folio)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmFacExe = fe;
      this.buscaFactura(folio, modulo);
      this.txtFolio.Text = folio.ToString();
    }

    public frmPagoVenta(ref frmBoleta b, string modulo, int folio)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmBol = b;
      this.buscaFactura(folio, modulo);
      this.txtFolio.Text = folio.ToString();
    }


    public frmPagoVenta(ref frmBoletaFiscal b, string modulo, int folio, int cajaBF)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmBolFis = b;
      this._caja = cajaBF;
      this.buscaFactura(folio, modulo);
      this.txtFolio.Text = folio.ToString();
    }

    public frmPagoVenta(ref frmModuloFacturacionAptusoft mff, string modulo, string folio, int idCli)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmMFF = mff;
      this.buscaFactura(Convert.ToInt32(folio), modulo);
      this.txtFolio.Text = folio;
      this.idCliente = idCli;
      this.cargaListaNotaCredito();
    }

    public frmPagoVenta(ref frmFacturaElectronica f, string modulo, int folio, int idCli)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmFacElec = f;
      this.buscaFactura(folio, modulo);
      this.txtFolio.Text = folio.ToString();
      this.idCliente = idCli;
      this.cargaListaNotaCredito();
    }

    public frmPagoVenta(ref frmFacturaElectronicaFrigo f, string modulo, int folio, int idCli)
    {
        this.InitializeComponent();
        this.cargaPermisos();
        this.iniciaFormulario();
        this.frmFacElecFrigo = f;
        this.buscaFactura(folio, modulo);
        this.txtFolio.Text = folio.ToString();
        this.idCliente = idCli;
        this.cargaListaNotaCredito();
    }

    public frmPagoVenta(ref frmFacturaExentaElectronica fe, string modulo, int folio, int idCli)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmFacExeElec = fe;
      this.buscaFactura(folio, modulo);
      this.txtFolio.Text = folio.ToString();
      this.idCliente = idCli;
      this.cargaListaNotaCredito();
    }

    public frmPagoVenta(ref frmBoletaElectronica b, string modulo, int folio, int idCli)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmBolElec = b;
      this.buscaFactura(folio, modulo);
      this.txtFolio.Text = folio.ToString();
      this.idCliente = idCli;
      this.cargaListaNotaCredito();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("PAGOS VENTAS"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._caja = usuarioVo.IdCaja;
        }
      }
    }

    private void iniciaFormulario()
    {
      frmPagoVenta.listaPago.Clear();
      this.cargaMediosPago();
      this.cargaTipoDocumentos();
      this.cargaBancos();
      this.txtFolio.Enabled = true;
      this.cmbTipoDocumento.Enabled = true;
      this.txtFolio.Clear();
      this.txtEmision.Clear();
      this.txtRut.Clear();
      this.txtRazonSocial.Clear();
      this.lblEstadoPago.Text = ".";
      this.txtTotalDocumentado.Clear();
      this.txtTotalFactura.Clear();
      this.txtTotalPendiente.Clear();
      this.txtTotalPagado.Clear();
      this.limpiaEntradaPagos();
      this.dgvDetalle.DataSource = (object) null;
      this.dgvDetalle.Columns.Clear();
      this.creaColumnasDetalle();
      this.dgvNC.DataSource = (object) null;
      this.dgvNC.Columns.Clear();
      this.creaColumnasNC();
      this._tipoNotaCredito = "";
      this.rdbPagado.Checked = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiar.Enabled = false;
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.btnImprimir.Enabled = false;
      frmPagoVenta.idDoc = 0;
      this.pnlRecuedroNC.Visible = false;
      this.tabControl1.Enabled = true;
    }

    private void limpiaEntradaPagos()
    {
      this.cmbMedioPago.SelectedValue = (object) 0;
      this.cmbBanco.SelectedValue = (object) 0;
      this.rdbPagado.Checked = true;
      this.txtMonto.Clear();
      this.dtpFechaCobro.Value = DateTime.Today;
      this.txtCuenta.Clear();
      this.txtNumeroDocumento.Clear();
      this.txtObservaciones.Clear();
      this.cmbMedioPago.Focus();
      if (this._guarda)
        this.btnAgregar.Enabled = true;
      this.btnLimpiar.Enabled = true;
      this.btnModificaLinea.Visible = false;
    }

    private void cargaTipoDocumentos()
    {
      this.cmbTipoDocumento.DataSource = (object) new CargaMaestros().cargaTipoDocumentoVenta();
      this.cmbTipoDocumento.ValueMember = "codigo";
      this.cmbTipoDocumento.DisplayMember = "descripcion";
      this.cmbTipoDocumento.SelectedValue = (object) 5;
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) new MedioPago().listaMediosPago();
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void cargaBancos()
    {
      this.cmbBanco.DataSource = (object) new CargaMaestros().listaBancos();
      this.cmbBanco.ValueMember = "idBanco";
      this.cmbBanco.DisplayMember = "nombreBanco";
      this.cmbBanco.SelectedValue = (object) 0;
    }

    private void cargaListaNotaCredito()
    {
      List<Venta> list1 = new List<Venta>();
      List<Venta> lisVen = new NotaCredito().buscaNotaCreditoPago(this.idCliente);
    }

    private void creaColumnasDetalle()
    {
      this.dgvDetalle.AutoGenerateColumns = false;
      this.dgvDetalle.Columns.Add("Linea", "");
      this.dgvDetalle.Columns[0].DataPropertyName = "Linea";
      this.dgvDetalle.Columns[0].Width = 20;
      this.dgvDetalle.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns[0].Visible = false;
      this.dgvDetalle.Columns.Add("Fecha", "Fechas");
      this.dgvDetalle.Columns[1].DataPropertyName = "FechaCobro";
      this.dgvDetalle.Columns[1].Width = 80;
      this.dgvDetalle.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("FormaPago", "Forma de Pago");
      this.dgvDetalle.Columns[2].DataPropertyName = "FormaPago";
      this.dgvDetalle.Columns[2].Width = 180;
      this.dgvDetalle.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Monto", "Monto");
      this.dgvDetalle.Columns[3].DataPropertyName = "Monto";
      this.dgvDetalle.Columns[3].Width = 70;
      this.dgvDetalle.Columns[3].DefaultCellStyle.Format = "C0";
      this.dgvDetalle.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDetalle.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Banco", "Banco");
      this.dgvDetalle.Columns[4].DataPropertyName = "Banco";
      this.dgvDetalle.Columns[4].Width = 90;
      this.dgvDetalle.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Cuenta", "Cuenta");
      this.dgvDetalle.Columns[5].DataPropertyName = "Cuenta";
      this.dgvDetalle.Columns[5].Width = 90;
      this.dgvDetalle.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns[5].Visible = false;
      this.dgvDetalle.Columns.Add("NumeroDocumento", "N° Documento");
      this.dgvDetalle.Columns[6].DataPropertyName = "NumeroDocumento";
      this.dgvDetalle.Columns[6].Width = 90;
      this.dgvDetalle.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Observaciones", "Observaciones");
      this.dgvDetalle.Columns[7].DataPropertyName = "Observaciones";
      this.dgvDetalle.Columns[7].Width = 190;
      this.dgvDetalle.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Estado", "Estado");
      this.dgvDetalle.Columns[8].DataPropertyName = "Estado";
      this.dgvDetalle.Columns[8].Width = 100;
      this.dgvDetalle.Columns[8].Resizable = DataGridViewTriState.False;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Eliminar";
      viewButtonColumn.HeaderText = "Eliminar";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "X";
      viewButtonColumn.Width = 50;
      viewButtonColumn.DisplayIndex = 9;
      this.dgvDetalle.Columns.Add((DataGridViewColumn) viewButtonColumn);
      this.dgvDetalle.Columns.Add("idFormaPago", "idFormaPago");
      this.dgvDetalle.Columns[10].DataPropertyName = "idFormaPago";
      this.dgvDetalle.Columns[10].Visible = false;
      this.dgvDetalle.Columns.Add("tipoPago", "tipoPago");
      this.dgvDetalle.Columns[11].DataPropertyName = "tipoPago";
      this.dgvDetalle.Columns[11].Visible = false;
    }

    private void creaColumnasNC()
    {
      this.dgvNC.AutoGenerateColumns = false;
      this.dgvNC.Columns.Add("Linea", "");
      this.dgvNC.Columns[0].DataPropertyName = "Linea";
      this.dgvNC.Columns[0].Width = 30;
      this.dgvNC.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvNC.Columns.Add("Fecha", "Fechas");
      this.dgvNC.Columns[1].DataPropertyName = "FechaEmision";
      this.dgvNC.Columns[1].Width = 80;
      this.dgvNC.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvNC.Columns.Add("Id", "Id");
      this.dgvNC.Columns[2].DataPropertyName = "IdFactura";
      this.dgvNC.Columns[2].Width = 70;
      this.dgvNC.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvNC.Columns[2].Visible = false;
      this.dgvNC.Columns.Add("Folio", "Folio");
      this.dgvNC.Columns[3].DataPropertyName = "Folio";
      this.dgvNC.Columns[3].Width = 100;
      this.dgvNC.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvNC.Columns.Add("Total", "Total");
      this.dgvNC.Columns[4].DataPropertyName = "Total";
      this.dgvNC.Columns[4].Width = 100;
      this.dgvNC.Columns[4].DefaultCellStyle.Format = "C0";
      this.dgvNC.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNC.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvNC.Columns.Add("MontoUsado", "MontoUsado");
      this.dgvNC.Columns[5].DataPropertyName = "MontoUsado";
      this.dgvNC.Columns[5].Width = 100;
      this.dgvNC.Columns[5].DefaultCellStyle.Format = "C0";
      this.dgvNC.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNC.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvNC.Columns.Add("MontoDisponible", "MontoDisponible");
      this.dgvNC.Columns[6].DataPropertyName = "MontoDisponible";
      this.dgvNC.Columns[6].Width = 100;
      this.dgvNC.Columns[6].DefaultCellStyle.Format = "C0";
      this.dgvNC.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvNC.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvNC.Columns.Add("TipoDocumento", "Tipo Documento");
      this.dgvNC.Columns[7].DataPropertyName = "TipoNotaCredito";
      this.dgvNC.Columns[7].Width = 250;
      this.dgvNC.Columns[7].Resizable = DataGridViewTriState.False;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Pagar";
      viewButtonColumn.HeaderText = " ";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "Pagar";
      viewButtonColumn.Width = 100;
      viewButtonColumn.DisplayIndex = 8;
      this.dgvNC.Columns.Add((DataGridViewColumn) viewButtonColumn);
    }

    private void buscaFactura(int folio, string tipoDocumento)
    {
      int num1 = 0;
      Venta venta = new Venta();
      if (tipoDocumento.Equals("FACTURA"))
      {
        venta = new Factura().buscaFacturaFolio(folio);
        this.idCliente = venta.IdCliente;
        num1 = 1;
      }
      if (tipoDocumento.Equals("FACTURA EXENTA"))
      {
        venta = new FacturaExenta().buscaFacturaExentaFolio(folio);
        this.idCliente = venta.IdCliente;
        num1 = 2;
      }
      if (tipoDocumento.Equals("BOLETA"))
      {
        venta = new Boleta().buscaBoletaFolio(folio);
        this.idCliente = venta.IdCliente;
        num1 = 3;
      }
      if (tipoDocumento.Equals("VOUCHER"))
      {
        venta = new Boleta().buscaBoletaNumeroVoucher(folio.ToString());
        this.idCliente = venta.IdCliente;
        num1 = 7;
      }
      if (tipoDocumento.Equals("BOLETA FISCAL"))
      {
        venta = new BoletaFiscal().buscaBoletaFolio(folio, this._caja);
        this.idCliente = venta.IdCliente;
        num1 = 4;
      }
      if (tipoDocumento.Equals("FACTURA_ELECTRONICA"))
      {
        venta = new EFactura().buscaFacturaFolio(folio);
        this.idCliente = venta.IdCliente;
        num1 = 5;
      }
      if (tipoDocumento.Equals("FACTURA_EXENTA_ELECTRONICA"))
      {
        venta = new EFacturaExenta().buscaFacturaFolio(folio);
        this.idCliente = venta.IdCliente;
        num1 = 6;
      }
      if (tipoDocumento.Equals("BOLETA_ELECTRONICA"))
      {
        venta = new EBoleta().buscaBoletaFolio(folio);
        this.idCliente = venta.IdCliente;
        num1 = 8;
      }
      if (tipoDocumento.Equals("NOTA VENTA"))
      {
        venta = new NotaVenta().buscaNotaVentaFolio(folio);
        this.idCliente = venta.IdCliente;
        num1 = 9;
      }
      if ((uint) venta.IdFactura > 0U)
      {
        if (venta.EstadoDocumento.Equals("EMITIDA"))
        {
          frmPagoVenta.idDoc = venta.IdFactura;
          this.txtRut.Text = venta.Rut + "-" + venta.Digito;
          this.txtRazonSocial.Text = venta.RazonSocial;
          this.txtEmision.Text = venta.FechaEmision.ToShortDateString();
          if (num1 == 3 || num1 == 4 || num1 == 7 || num1 == 8)
            this.txtTotalFactura.Text = venta.TotalaCobrar.ToString("N0");
          else
            this.txtTotalFactura.Text = venta.Total.ToString("N0");
          this.cmbTipoDocumento.SelectedValue = (object) num1;
          this.lblEstadoPago.Text = venta.EstadoPago;
          TextBox textBox1 = this.txtTotalPagado;
          Decimal num2 = venta.TotalPagado;
          string str1 = num2.ToString("N0");
          textBox1.Text = str1;
          TextBox textBox2 = this.txtTotalDocumentado;
          num2 = venta.TotalDocumentado;
          string str2 = num2.ToString("N0");
          textBox2.Text = str2;
          TextBox textBox3 = this.txtTotalPendiente;
          num2 = venta.TotalPendiente;
          string str3 = num2.ToString("N0");
          textBox3.Text = str3;
          PagoVenta pagoVenta = new PagoVenta();
          frmPagoVenta.listaPago = !tipoDocumento.Equals("VOUCHER") ? pagoVenta.listaPagosVenta(tipoDocumento, frmPagoVenta.idDoc, folio) : pagoVenta.listaPagosVenta(tipoDocumento, frmPagoVenta.idDoc, frmPagoVenta.idDoc);
          if (frmPagoVenta.listaPago.Count > 0)
          {
            this.btnGuardar.Enabled = false;
            if (this._modifica)
              this.btnModificar.Enabled = true;
            this.btnImprimir.Enabled = true;
            for (int index = 0; index < frmPagoVenta.listaPago.Count; ++index)
              frmPagoVenta.listaPago[index].Linea = index + 1;
            this.dgvDetalle.DataSource = (object) null;
            this.dgvDetalle.DataSource = (object) frmPagoVenta.listaPago;
          }
          if (this._guarda)
            this.btnAgregar.Enabled = true;
          this.btnLimpiar.Enabled = true;
          this.txtFolio.Enabled = false;
          this.cmbTipoDocumento.Enabled = false;
          if (num1 == 9 && venta.FolioDocumentoVenta > 0)
          {
            this.btnAgregar.Enabled = false;
            this.btnLimpiar.Enabled = false;
            this.btnModificaLinea.Enabled = false;
            this.btnImprimir.Enabled = false;
            this.tabControl1.Enabled = false;
          }
          this.cargaListaNotaCredito();
          this.cmbMedioPago.Focus();
        }
        else
        {
          int num3 = (int) MessageBox.Show("Documento Anulado, No tiene Pagos Relacionados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num4 = (int) MessageBox.Show("No Existe Documento Consultado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolio);
      if ((int) e.KeyChar != 13)
        return;
      if (this.cmbTipoDocumento.SelectedValue.ToString() != "0")
      {
        if (this.txtFolio.Text.Trim().Length > 0)
        {
          this.buscaFactura(Convert.ToInt32(this.txtFolio.Text.Trim()), this.cmbTipoDocumento.Text);
        }
        else
        {
          int num = (int) MessageBox.Show("Debe Ingresar un Folio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtFolio.Focus();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Debe seleccionar un tipo de documento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.cmbTipoDocumento.Focus();
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modPagoVenta = 0;
      this.Close();
      this.Dispose();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if (!this.validaIngreso())
        return;
      this.agregaPago();
      this.guardaPagoVentaDesdeAgregar();
    }

    private void agregaPago()
    {
      PagoVentaVO pagoVentaVo = new PagoVentaVO();
      DateTime dateTime=DateTime.Now;
      DateTime local = @dateTime;
      DateTime now = this.dtpFechaCobro.Value;
      int year = now.Year;
      now = this.dtpFechaCobro.Value;
      int month = now.Month;
      now = this.dtpFechaCobro.Value;
      int day = now.Day;
      now = DateTime.Now;
      TimeSpan timeOfDay = now.TimeOfDay;
      int hours = timeOfDay.Hours;
      now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int minutes = timeOfDay.Minutes;
      now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int seconds = timeOfDay.Seconds;
      local = new DateTime(year, month, day, hours, minutes, seconds);

      string FechaCobro = dtpFechaCobro.Value.ToString("yyyy-MM-dd");

      pagoVentaVo.FechaCobro = Convert.ToDateTime(FechaCobro);
      pagoVentaVo.FormaPago = this.cmbMedioPago.Text.Trim();
      pagoVentaVo.IdFormaPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue);
      pagoVentaVo.Monto = Convert.ToDecimal(this.txtMonto.Text.Trim());
      pagoVentaVo.Banco = this.cmbBanco.Text != "[SELECCIONE]" ? this.cmbBanco.Text : "";
      pagoVentaVo.Cuenta = this.txtCuenta.Text.Trim();
      pagoVentaVo.NumeroDocumento = this.txtNumeroDocumento.Text.Trim();
      pagoVentaVo.Observaciones = this.txtObservaciones.Text.Trim().ToUpper();
      if (this.rdbPagado.Checked)
        pagoVentaVo.Estado = "PAGADO";
      if (this.rdbDocumentado.Checked)
        pagoVentaVo.Estado = "DOCUMENTADO";
      pagoVentaVo.TipoPago = "MP";
      frmPagoVenta.listaPago.Add(pagoVentaVo);
      for (int index = 0; index < frmPagoVenta.listaPago.Count; ++index)
        frmPagoVenta.listaPago[index].Linea = index + 1;
      this.calculaTotales();
      this.limpiaEntradaPagos();
    }

    private void agregaPagoNotaCredito(string folio, Decimal monto)
    {
      PagoVentaVO pagoVentaVo = new PagoVentaVO();
      DateTime now = DateTime.Now;
      pagoVentaVo.FechaCobro = now;
      if (this._tipoNotaCredito.Equals("PAPEL"))
      {
        pagoVentaVo.FormaPago = "NOTA DE CREDITO N°:" + folio;
        pagoVentaVo.TipoPago = "NC";
        pagoVentaVo.Observaciones = "NOTA DE CREDITO N°:" + folio;
      }
      else
      {
        pagoVentaVo.FormaPago = "NOTA DE CREDITO ELECTRONICA N°:" + folio;
        pagoVentaVo.TipoPago = "NCE";
        pagoVentaVo.Observaciones = "NOTA DE CREDITO ELECTRONICA N°:" + folio;
      }
      pagoVentaVo.IdFormaPago = 99;
      pagoVentaVo.Monto = Convert.ToDecimal(monto);
      pagoVentaVo.Banco = "";
      pagoVentaVo.Cuenta = "";
      pagoVentaVo.NumeroDocumento = folio;
      pagoVentaVo.Estado = "PAGADO";
      frmPagoVenta.listaPago.Add(pagoVentaVo);
      for (int index = 0; index < frmPagoVenta.listaPago.Count; ++index)
        frmPagoVenta.listaPago[index].Linea = index + 1;
      this.calculaTotales();
      this.limpiaEntradaPagos();
    }

    private void calculaTotales()
    {
      this.dgvDetalle.DataSource = (object) null;
      this.dgvDetalle.DataSource = (object) frmPagoVenta.listaPago;
      Decimal num1 = new Decimal();
      Decimal num2 = new Decimal();
      Decimal num3 = new Decimal();
      Decimal num4 = Convert.ToDecimal(this.txtTotalFactura.Text.Trim());
      foreach (PagoVentaVO pagoVentaVo in frmPagoVenta.listaPago)
      {
        if (pagoVentaVo.Estado.Equals("PAGADO"))
          num3 += pagoVentaVo.Monto;
        if (pagoVentaVo.Estado.Equals("DOCUMENTADO"))
          num1 += pagoVentaVo.Monto;
      }
      this.txtTotalPagado.Text = num3.ToString("N0");
      this.txtTotalDocumentado.Text = num1.ToString("N0");
      this.txtTotalPendiente.Text = (num4 - (num3 + num1)).ToString("N0");
      this.estadoDocumento();
    }

    private bool validaIngreso()
    {
      if (this.cmbMedioPago.SelectedValue == null || this.cmbMedioPago.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe seleccionar un Medio de Pago Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.cmbMedioPago.Focus();
        return false;
      }
      if (this.txtMonto.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe ingresar Un Monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtMonto.Focus();
        return false;
      }
      Decimal num1 = this.txtTotalFactura.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalFactura.Text.Trim()) : Decimal.Zero;
      Decimal num2 = this.txtTotalPagado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPagado.Text.Trim()) : Decimal.Zero;
      Decimal num3 = this.txtTotalDocumentado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDocumentado.Text.Trim()) : Decimal.Zero;
      Decimal num4 = this.txtTotalPendiente.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPendiente.Text.Trim()) : Decimal.Zero;
      Decimal num5 = this.txtMonto.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtMonto.Text.Trim()) : Decimal.Zero;
      if (!(num2 + num3 + num5 > num1))
        return true;
      int num6 = (int) MessageBox.Show("los Montos no Deben superar al Total de La Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtMonto.Focus();
      return false;
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

    private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolio);
    }

    private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvDetalle.Columns[e.ColumnIndex].Name == "Eliminar"))
        return;
      if (this._elimina)
      {
        if (MessageBox.Show("Esta seguro de Eliminar este Pago", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          int num = Convert.ToInt32(this.dgvDetalle.SelectedRows[0].Cells[0].Value.ToString());
          for (int index = 0; index < frmPagoVenta.listaPago.Count; ++index)
          {
            if (frmPagoVenta.listaPago[index].Linea == num)
            {
              frmPagoVenta.listaPago.RemoveAt(index);
              --index;
            }
          }
          this.calculaTotales();
          this.limpiaEntradaPagos();
          this.guardaPagoVentaDesdeAgregar();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("No tiene Permisos para Eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void dgvDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvDetalle.SelectedRows[0].Cells["tipoPago"].Value.ToString() == "MP" || this.dgvDetalle.SelectedRows[0].Cells["tipoPago"].Value.ToString() == "PMD" || this.dgvDetalle.SelectedRows[0].Cells["tipoPago"].Value.ToString() == "MP_NV")
      {
        if (this._modifica)
          this.btnModificaLinea.Visible = true;
        this.btnAgregar.Enabled = false;
        this.btnLimpiar.Enabled = false;
        frmPagoVenta._linea = Convert.ToInt32(this.dgvDetalle.SelectedRows[0].Cells[0].Value.ToString());
        this.dtpFechaCobro.Value = Convert.ToDateTime(this.dgvDetalle.SelectedRows[0].Cells[1].Value.ToString());
        this.cmbMedioPago.SelectedValue = (object) this.dgvDetalle.SelectedRows[0].Cells[10].Value.ToString();
        this.txtMonto.Text = Convert.ToDecimal(this.dgvDetalle.SelectedRows[0].Cells[3].Value.ToString()).ToString("N0");
        this.cmbBanco.Text = this.dgvDetalle.SelectedRows[0].Cells[4].Value.ToString();
        this.txtCuenta.Text = this.dgvDetalle.SelectedRows[0].Cells[5].Value.ToString();
        this.txtNumeroDocumento.Text = this.dgvDetalle.SelectedRows[0].Cells[6].Value.ToString();
        this.txtObservaciones.Text = this.dgvDetalle.SelectedRows[0].Cells[7].Value.ToString();
        if (this.dgvDetalle.SelectedRows[0].Cells[8].Value.ToString().Equals("PAGADO"))
          this.rdbPagado.Checked = true;
        else
          this.rdbDocumentado.Checked = true;
      }
      else
      {
        int num = (int) MessageBox.Show("El Pago con Nota de Credito NO se puede Modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnModificaLinea_Click(object sender, EventArgs e)
    {
      Decimal num1 = this.txtTotalFactura.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalFactura.Text.Trim()) : Decimal.Zero;
      Decimal num2 = this.txtTotalPagado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPagado.Text.Trim()) : Decimal.Zero;
      Decimal num3 = this.txtTotalDocumentado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDocumentado.Text.Trim()) : Decimal.Zero;
      Decimal num4 = this.txtTotalPendiente.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPendiente.Text.Trim()) : Decimal.Zero;
      Decimal num5 = this.txtMonto.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtMonto.Text.Trim()) : Decimal.Zero;
      bool flag = false;
      for (int index = 0; index < frmPagoVenta.listaPago.Count; ++index)
      {
        if (frmPagoVenta.listaPago[index].Linea == frmPagoVenta._linea)
        {
          if (frmPagoVenta.listaPago[index].Estado.Equals("PAGADO"))
            num2 -= frmPagoVenta.listaPago[index].Monto;
          else
            num3 -= frmPagoVenta.listaPago[index].Monto;
          if (num2 + num3 + num5 > num1)
          {
            int num6 = (int) MessageBox.Show("los Montos no Deben superar al Total de La Factura");
            this.txtMonto.Focus();
          }
          else
          {
            PagoVentaVO pagoVentaVo = new PagoVentaVO();
            DateTime dateTime=DateTime.Now;
            DateTime local = @dateTime;
            DateTime now = this.dtpFechaCobro.Value;
            int year = now.Year;
            now = this.dtpFechaCobro.Value;
            int month = now.Month;
            now = this.dtpFechaCobro.Value;
            int day = now.Day;
            now = DateTime.Now;
            int hours = now.TimeOfDay.Hours;
            now = DateTime.Now;
            int minutes = now.TimeOfDay.Minutes;
            now = DateTime.Now;
            int seconds = now.TimeOfDay.Seconds;
            local = new DateTime(year, month, day, hours, minutes, seconds);

            string FechaCobro = dtpFechaCobro.Value.ToString("yyyy-MM-dd");

            frmPagoVenta.listaPago[index].FechaCobro = Convert.ToDateTime(FechaCobro);
            frmPagoVenta.listaPago[index].FormaPago = this.cmbMedioPago.Text;
            frmPagoVenta.listaPago[index].IdFormaPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue);
            frmPagoVenta.listaPago[index].Monto = Convert.ToDecimal(this.txtMonto.Text.Trim());
            if (this.rdbPagado.Checked)
              frmPagoVenta.listaPago[index].Estado = "PAGADO";
            if (this.rdbDocumentado.Checked)
              frmPagoVenta.listaPago[index].Estado = "DOCUMENTADO";
            frmPagoVenta.listaPago[index].Banco = this.cmbBanco.SelectedIndex != 0 ? this.cmbBanco.Text : "";
            frmPagoVenta.listaPago[index].Cuenta = this.txtCuenta.Text.Trim();
            frmPagoVenta.listaPago[index].NumeroDocumento = this.txtNumeroDocumento.Text.Trim();
            frmPagoVenta.listaPago[index].Observaciones = this.txtObservaciones.Text.Trim().ToUpper();
            flag = true;
          }
        }
      }
      if (!flag)
        return;
      this.dgvDetalle.DataSource = (object) null;
      this.dgvDetalle.DataSource = (object) frmPagoVenta.listaPago;
      this.calculaTotales();
      this.limpiaEntradaPagos();
      this.guardaPagoVentaDesdeAgregar();
    }

    private void estadoDocumento()
    {
      Decimal num1 = Convert.ToDecimal(this.txtTotalFactura.Text);
      Decimal num2 = Convert.ToDecimal(this.txtTotalPagado.Text);
      Decimal num3 = Convert.ToDecimal(this.txtTotalDocumentado.Text);
      Decimal num4 = Convert.ToDecimal(this.txtTotalPendiente.Text);
      if (num1 == num2)
        this.lblEstadoPago.Text = "PAGADO";
      else if (num3 > Decimal.Zero && num1 != num2 && num4 == Decimal.Zero)
        this.lblEstadoPago.Text = "DOCUMENTADO";
      else
        this.lblEstadoPago.Text = "PENDIENTE";
    }

    private void btnLimpiarFormulario_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnLimpiaDetalle_Click(object sender, EventArgs e)
    {
      this.limpiaEntradaPagos();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      if (frmPagoVenta.listaPago.Count <= 0)
        return;
      if (MessageBox.Show("Esta seguro de Eliminar todos los pagos Registrados de este Documento", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        frmPagoVenta.listaPago.Clear();
        this.dgvDetalle.DataSource = (object) null;
        this.calculaTotales();
        this.guardaPagoVentaDesdeAgregar();
      }
      else
      {
        int num = (int) MessageBox.Show("Los Pagos no fueron Eliminados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaPagoVenta();
    }

    private void guardaPagoVenta()
    {
      if (!this.validaIngresoPagoVenta())
        return;
      PagoVenta pagoVenta = new PagoVenta();
      string text1 = this.cmbTipoDocumento.Text;
      int folio = Convert.ToInt32(this.txtFolio.Text.Trim());
      DateTime now = DateTime.Now;
      string text2 = this.lblEstadoPago.Text;
      Decimal tPagado = Convert.ToDecimal(this.txtTotalPagado.Text);
      Decimal tDocumentado = Convert.ToDecimal(this.txtTotalDocumentado.Text);
      Decimal tPendiente = Convert.ToDecimal(this.txtTotalPendiente.Text);
      int num = (int) MessageBox.Show(pagoVenta.ingresaPagoVenta(frmPagoVenta.listaPago, text1, frmPagoVenta.idDoc, folio, now, text2, tPagado, tDocumentado, tPendiente), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      if (MessageBox.Show("Desea Imprimir el Comprobante", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        this.imprimeDirecto();
      this.iniciaFormulario();
    }

    private void guardaPagoVentaDesdeAgregar()
    {
      if (!this.validaIngresoPagoVenta())
        return;
      PagoVenta pagoVenta = new PagoVenta();
      string text1 = this.cmbTipoDocumento.Text;
      int folio = Convert.ToInt32(this.txtFolio.Text.Trim());
      DateTime now = DateTime.Now;
      string text2 = this.lblEstadoPago.Text;
      Decimal tPagado = Convert.ToDecimal(this.txtTotalPagado.Text);
      Decimal tDocumentado = Convert.ToDecimal(this.txtTotalDocumentado.Text);
      Decimal tPendiente = Convert.ToDecimal(this.txtTotalPendiente.Text);
      string str = "";
      str = !text1.Equals("VOUCHER") ? pagoVenta.modificaPagoVenta(frmPagoVenta.listaPago, text1, frmPagoVenta.idDoc, folio, now, text2, tPagado, tDocumentado, tPendiente) : pagoVenta.modificaPagoVenta(frmPagoVenta.listaPago, text1, frmPagoVenta.idDoc, frmPagoVenta.idDoc, now, text2, tPagado, tDocumentado, tPendiente);
      this.buscaFactura(Convert.ToInt32(this.txtFolio.Text.Trim()), this.cmbTipoDocumento.Text);
    }

    private bool validaIngresoPagoVenta()
    {
      if (this.cmbTipoDocumento.SelectedValue == null || this.cmbTipoDocumento.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona Un tipo de Documento Valido");
        this.cmbTipoDocumento.Focus();
        return false;
      }
      if (this.txtFolio.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar El Folio del Documento");
        this.txtFolio.Focus();
        return false;
      }
      if (frmPagoVenta.idDoc != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar El Folio del Documento");
      this.txtFolio.Focus();
      return false;
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      this.modificaPagoVenta();
    }

    private void modificaPagoVenta()
    {
      if (!this.validaIngresoPagoVenta())
        return;
      PagoVenta pagoVenta = new PagoVenta();
      string text1 = this.cmbTipoDocumento.Text;
      int folio = Convert.ToInt32(this.txtFolio.Text.Trim());
      DateTime now = DateTime.Now;
      string text2 = this.lblEstadoPago.Text;
      Decimal tPagado = Convert.ToDecimal(this.txtTotalPagado.Text);
      Decimal tDocumentado = Convert.ToDecimal(this.txtTotalDocumentado.Text);
      Decimal tPendiente = Convert.ToDecimal(this.txtTotalPendiente.Text);
      pagoVenta.modificaPagoVenta(frmPagoVenta.listaPago, text1, frmPagoVenta.idDoc, folio, now, text2, tPagado, tDocumentado, tPendiente);
      if (MessageBox.Show("Desea Imprimir el Comprobante", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        this.imprimeDirecto();
      this.iniciaFormulario();
    }

    private void frmPagoVenta_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F5)
      {
        if (this._guarda)
        {
          if (this.validaIngreso() && this.btnAgregar.Enabled)
          {
            this.agregaPago();
            this.guardaPagoVentaDesdeAgregar();
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Sin permisos para Guardar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      if (e.KeyCode != Keys.F2)
        return;
      if (this.btnAgregar.Enabled)
        this.guardaPagoVenta();
      if (this.btnModificaLinea.Enabled)
        this.modificaPagoVenta();
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
      this.imprimeDirecto();
    }

    private void imprimeDirecto()
    {
      PagoVenta pagoVenta = new PagoVenta();
      if (this.cmbTipoDocumento.Text.Equals("FACTURA"))
      {
        DataTable dataTable = pagoVenta.comprobanteFactura(Convert.ToInt32(this.txtFolio.Text), frmPagoVenta.idDoc);
        try
        {
          ReportDocument reportDocument = new ReportDocument();
          reportDocument.Load("C:\\AptuSoft\\reportes\\ComprobantePagoFactura.rpt");
          reportDocument.SetDataSource(dataTable);
          string str = new LeeXml().cargarDatosOtrosDocumentos();
          reportDocument.PrintOptions.PrinterName = str;
          reportDocument.PrintToPrinter(1, false, 1, 1);
          reportDocument.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error Con Reporte " + ex.Message);
        }
      }
      if (this.cmbTipoDocumento.Text.Equals("FACTURA_ELECTRONICA"))
      {
        DataTable dataTable = pagoVenta.comprobanteFacturaElectronica(Convert.ToInt32(this.txtFolio.Text), frmPagoVenta.idDoc);
        try
        {
          ReportDocument reportDocument = new ReportDocument();
          reportDocument.Load("C:\\AptuSoft\\reportes\\ComprobantePagoFactura.rpt");
          reportDocument.SetDataSource(dataTable);
          string str = new LeeXml().cargarDatosOtrosDocumentos();
          reportDocument.PrintOptions.PrinterName = str;
          reportDocument.PrintToPrinter(1, false, 1, 1);
          reportDocument.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error Con Reporte " + ex.Message);
        }
      }
      if (this.cmbTipoDocumento.Text.Equals("FACTURA_EXENTA_ELECTRONICA"))
      {
        DataTable dataTable = pagoVenta.comprobanteFacturaExentaElectronica(Convert.ToInt32(this.txtFolio.Text), frmPagoVenta.idDoc);
        try
        {
          ReportDocument reportDocument = new ReportDocument();
          reportDocument.Load("C:\\AptuSoft\\reportes\\ComprobantePagoFactura.rpt");
          reportDocument.SetDataSource(dataTable);
          string str = new LeeXml().cargarDatosOtrosDocumentos();
          reportDocument.PrintOptions.PrinterName = str;
          reportDocument.PrintToPrinter(1, false, 1, 1);
          reportDocument.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error Con Reporte " + ex.Message);
        }
      }
      if (this.cmbTipoDocumento.Text.Equals("BOLETA") || this.cmbTipoDocumento.Text.Equals("VOUCHER"))
      {
        DataTable dataTable = pagoVenta.comprobanteBoleta(Convert.ToInt32(this.txtFolio.Text), frmPagoVenta.idDoc);
        try
        {
          ReportDocument reportDocument = new ReportDocument();
          reportDocument.Load("C:\\AptuSoft\\reportes\\ComprobantePagoBoleta.rpt");
          reportDocument.SetDataSource(dataTable);
          string str = new LeeXml().cargarDatosOtrosDocumentos();
          reportDocument.PrintOptions.PrinterName = str;
          reportDocument.PrintToPrinter(1, false, 1, 1);
          reportDocument.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error Con Reporte " + ex.Message);
        }
      }
      if (this.cmbTipoDocumento.Text.Equals("BOLETA FISCAL"))
      {
        DataTable dataTable = pagoVenta.comprobanteBoletaFiscal(Convert.ToInt32(this.txtFolio.Text), frmPagoVenta.idDoc);
        try
        {
          ReportDocument reportDocument = new ReportDocument();
          reportDocument.Load("C:\\AptuSoft\\reportes\\ComprobantePagoBoleta.rpt");
          reportDocument.SetDataSource(dataTable);
          string str = new LeeXml().cargarDatosOtrosDocumentos();
          reportDocument.PrintOptions.PrinterName = str;
          reportDocument.PrintToPrinter(1, false, 1, 1);
          reportDocument.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error Con Reporte " + ex.Message);
        }
      }
      this.iniciaFormulario();
    }

    private void frmPagoVenta_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modPagoVenta = 0;
      this.Dispose();
    }

    private void dgvNC_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvNC.Columns[e.ColumnIndex].Name == "Pagar"))
        return;
      this.txtFolioNC.Enabled = false;
      this.txtMontoDisponible.Enabled = false;
      this.pnlRecuedroNC.Visible = true;
      this.txtFolioNC.Clear();
      this.txtMontoDisponible.Clear();
      this.txtMontoUsar.Clear();
      this.txtFolioNC.Text = this.dgvNC.SelectedRows[0].Cells["Folio"].Value.ToString();
      this.txtMontoDisponible.Text = Convert.ToDecimal(this.dgvNC.SelectedRows[0].Cells["MontoDisponible"].Value.ToString()).ToString("N0");
      this._tipoNotaCredito = !this.dgvNC.SelectedRows[0].Cells["TipoDocumento"].Value.ToString().Equals("NOTA CREDITO") ? "ELECTRONICA" : "PAPEL";
      this.tabControl1.SelectedIndex = 0;
      this.txtMontoUsar.Focus();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.pnlRecuedroNC.Visible = false;
    }

    private void txtMontoUsar_TextChanged(object sender, EventArgs e)
    {
      Decimal num1 = new Decimal();
      Decimal num2 = new Decimal();
      Decimal num3 = this.txtMontoDisponible.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtMontoDisponible.Text.Trim()) : Decimal.Zero;
      if (!((this.txtMontoUsar.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtMontoUsar.Text.Trim()) : Decimal.Zero) > num3))
        return;
      int num4 = (int) MessageBox.Show("El Monto a usar No puede ser Mayor al Disponible", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtMontoUsar.Text = this.txtMontoDisponible.Text;
    }

    private void txtFolioNC_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioNC);
    }

    private void txtMontoUsar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtMontoUsar);
      if ((int) e.KeyChar != 13)
        return;
      this.agregaPagoNotaCredito(this.txtFolioNC.Text, Convert.ToDecimal(this.txtMontoUsar.Text.Trim()));
      this.pnlRecuedroNC.Visible = false;
    }

    private void btnPagar_Click(object sender, EventArgs e)
    {
      if (!this.validaIngresoNC())
        return;
      this.agregaPagoNotaCredito(this.txtFolioNC.Text, Convert.ToDecimal(this.txtMontoUsar.Text.Trim()));
      this.pnlRecuedroNC.Visible = false;
      this.guardaPagoVentaDesdeAgregar();
    }

    private bool validaIngresoNC()
    {
      Decimal num1 = this.txtTotalFactura.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalFactura.Text.Trim()) : Decimal.Zero;
      Decimal num2 = this.txtTotalPagado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPagado.Text.Trim()) : Decimal.Zero;
      Decimal num3 = this.txtTotalDocumentado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDocumentado.Text.Trim()) : Decimal.Zero;
      Decimal num4 = this.txtTotalPendiente.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPendiente.Text.Trim()) : Decimal.Zero;
      Decimal num5 = this.txtMontoUsar.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtMontoUsar.Text.Trim()) : Decimal.Zero;
      if (!(num2 + num3 + num5 > num1))
        return true;
      int num6 = (int) MessageBox.Show("los Montos no Deben superar al Total de La Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtMonto.Focus();
      return false;
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
      this.txtFolio = new TextBox();
      this.label4 = new Label();
      this.cmbTipoDocumento = new ComboBox();
      this.label1 = new Label();
      this.txtRut = new TextBox();
      this.btnBuscar = new Button();
      this.txtEmision = new TextBox();
      this.txtRazonSocial = new TextBox();
      this.label3 = new Label();
      this.label2 = new Label();
      this.groupBox2 = new GroupBox();
      this.txtTotalPendiente = new TextBox();
      this.txtTotalDocumentado = new TextBox();
      this.txtTotalPagado = new TextBox();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.txtTotalFactura = new TextBox();
      this.label5 = new Label();
      this.txtObservaciones = new TextBox();
      this.txtNumeroDocumento = new TextBox();
      this.txtCuenta = new TextBox();
      this.cmbBanco = new ComboBox();
      this.label15 = new Label();
      this.label14 = new Label();
      this.label13 = new Label();
      this.label12 = new Label();
      this.dtpFechaCobro = new DateTimePicker();
      this.label11 = new Label();
      this.txtMonto = new TextBox();
      this.label10 = new Label();
      this.rdbDocumentado = new RadioButton();
      this.rdbPagado = new RadioButton();
      this.cmbMedioPago = new ComboBox();
      this.label9 = new Label();
      this.dgvDetalle = new DataGridView();
      this.btnAgregar = new Button();
      this.btnLimpiar = new Button();
      this.btnGuardar = new Button();
      this.btnModificar = new Button();
      this.btnImprimir = new Button();
      this.btnLimpiarFormulario = new Button();
      this.btnSalir = new Button();
      this.lblEstadoPago = new Label();
      this.panel1 = new Panel();
      this.btnLimpiaDetalle = new Button();
      this.btnModificaLinea = new Button();
      this.groupBox3 = new GroupBox();
      this.label16 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.dgvNC = new DataGridView();
      this.pnlRecuedroNC = new Panel();
      this.btnCerrar = new Button();
      this.btnPagar = new Button();
      this.txtMontoUsar = new TextBox();
      this.txtMontoDisponible = new TextBox();
      this.txtFolioNC = new TextBox();
      this.label19 = new Label();
      this.label18 = new Label();
      this.label17 = new Label();
      this.ticketTableAdapter1 = new TicketTableAdapter();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.dgvDetalle).BeginInit();
      this.panel1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((ISupportInitialize) this.dgvNC).BeginInit();
      this.pnlRecuedroNC.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.txtFolio);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.cmbTipoDocumento);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(6, -3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(336, 60);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.txtFolio.BackColor = Color.White;
      this.txtFolio.Location = new Point(236, 31);
      this.txtFolio.Name = "txtFolio";
      this.txtFolio.Size = new Size(95, 20);
      this.txtFolio.TabIndex = 2;
      this.txtFolio.TextAlign = HorizontalAlignment.Right;
      this.txtFolio.KeyPress += new KeyPressEventHandler(this.txtFolio_KeyPress);
      this.label4.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.Black;
      this.label4.Location = new Point(236, 14);
      this.label4.Name = "label4";
      this.label4.Size = new Size(94, 22);
      this.label4.TabIndex = 7;
      this.label4.Text = "Folio";
      this.cmbTipoDocumento.BackColor = Color.White;
      this.cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTipoDocumento.FlatStyle = FlatStyle.Flat;
      this.cmbTipoDocumento.FormattingEnabled = true;
      this.cmbTipoDocumento.Location = new Point(7, 30);
      this.cmbTipoDocumento.Name = "cmbTipoDocumento";
      this.cmbTipoDocumento.Size = new Size(223, 21);
      this.cmbTipoDocumento.TabIndex = 1;
      this.label1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new Point(7, 14);
      this.label1.Name = "label1";
      this.label1.Size = new Size(224, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tipo Documento";
      this.txtRut.BackColor = Color.White;
      this.txtRut.Location = new Point(111, 31);
      this.txtRut.Name = "txtRut";
      this.txtRut.ReadOnly = true;
      this.txtRut.Size = new Size(85, 20);
      this.txtRut.TabIndex = 14;
      this.btnBuscar.Location = new Point(533, 14);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new Size(11, 38);
      this.btnBuscar.TabIndex = 8;
      this.btnBuscar.Text = "Buscar Documento";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Visible = false;
      this.txtEmision.BackColor = Color.White;
      this.txtEmision.Location = new Point(8, 31);
      this.txtEmision.Name = "txtEmision";
      this.txtEmision.ReadOnly = true;
      this.txtEmision.Size = new Size(100, 20);
      this.txtEmision.TabIndex = 6;
      this.txtRazonSocial.BackColor = Color.White;
      this.txtRazonSocial.Location = new Point(202, 31);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.ReadOnly = true;
      this.txtRazonSocial.Size = new Size(325, 20);
      this.txtRazonSocial.TabIndex = 4;
      this.label3.AutoSize = true;
      this.label3.BackColor = Color.Transparent;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Black;
      this.label3.Location = new Point(111, 14);
      this.label3.Name = "label3";
      this.label3.Size = new Size(29, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "Rut";
      this.label2.AutoSize = true;
      this.label2.BackColor = Color.Transparent;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Black;
      this.label2.Location = new Point(8, 14);
      this.label2.Name = "label2";
      this.label2.Size = new Size(59, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "Emision";
      this.groupBox2.Controls.Add((Control) this.txtTotalPendiente);
      this.groupBox2.Controls.Add((Control) this.txtTotalDocumentado);
      this.groupBox2.Controls.Add((Control) this.txtTotalPagado);
      this.groupBox2.Controls.Add((Control) this.label8);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.txtTotalFactura);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Location = new Point(457, 358);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(434, 94);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.txtTotalPendiente.BackColor = Color.Red;
      this.txtTotalPendiente.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalPendiente.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalPendiente.ForeColor = Color.White;
      this.txtTotalPendiente.Location = new Point(141, 64);
      this.txtTotalPendiente.Name = "txtTotalPendiente";
      this.txtTotalPendiente.ReadOnly = true;
      this.txtTotalPendiente.Size = new Size(100, 22);
      this.txtTotalPendiente.TabIndex = 25;
      this.txtTotalPendiente.TextAlign = HorizontalAlignment.Right;
      this.txtTotalDocumentado.BackColor = Color.White;
      this.txtTotalDocumentado.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalDocumentado.Location = new Point(141, 40);
      this.txtTotalDocumentado.Name = "txtTotalDocumentado";
      this.txtTotalDocumentado.ReadOnly = true;
      this.txtTotalDocumentado.Size = new Size(100, 22);
      this.txtTotalDocumentado.TabIndex = 24;
      this.txtTotalDocumentado.TextAlign = HorizontalAlignment.Right;
      this.txtTotalPagado.BackColor = Color.White;
      this.txtTotalPagado.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalPagado.Location = new Point(141, 16);
      this.txtTotalPagado.Name = "txtTotalPagado";
      this.txtTotalPagado.ReadOnly = true;
      this.txtTotalPagado.Size = new Size(100, 22);
      this.txtTotalPagado.TabIndex = 23;
      this.txtTotalPagado.TextAlign = HorizontalAlignment.Right;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(8, 66);
      this.label8.Name = "label8";
      this.label8.Size = new Size(108, 15);
      this.label8.TabIndex = 4;
      this.label8.Text = "Total Pendiente";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(8, 42);
      this.label7.Name = "label7";
      this.label7.Size = new Size(132, 15);
      this.label7.TabIndex = 3;
      this.label7.Text = "Total Documentado";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(8, 18);
      this.label6.Name = "label6";
      this.label6.Size = new Size(92, 15);
      this.label6.TabIndex = 2;
      this.label6.Text = "Total Pagado";
      this.txtTotalFactura.BackColor = Color.White;
      this.txtTotalFactura.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalFactura.Location = new Point(252, 49);
      this.txtTotalFactura.Name = "txtTotalFactura";
      this.txtTotalFactura.ReadOnly = true;
      this.txtTotalFactura.Size = new Size(172, 35);
      this.txtTotalFactura.TabIndex = 26;
      this.txtTotalFactura.TextAlign = HorizontalAlignment.Right;
      this.label5.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label5.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.Black;
      this.label5.Location = new Point(252, 16);
      this.label5.Name = "label5";
      this.label5.Size = new Size(172, 34);
      this.label5.TabIndex = 1;
      this.label5.Text = "Total";
      this.label5.TextAlign = ContentAlignment.MiddleRight;
      this.txtObservaciones.Location = new Point(388, 51);
      this.txtObservaciones.Name = "txtObservaciones";
      this.txtObservaciones.Size = new Size(464, 20);
      this.txtObservaciones.TabIndex = 11;
      this.txtNumeroDocumento.Location = new Point(271, 51);
      this.txtNumeroDocumento.Name = "txtNumeroDocumento";
      this.txtNumeroDocumento.Size = new Size(113, 20);
      this.txtNumeroDocumento.TabIndex = 10;
      this.txtCuenta.Location = new Point(159, 51);
      this.txtCuenta.Name = "txtCuenta";
      this.txtCuenta.Size = new Size(108, 20);
      this.txtCuenta.TabIndex = 9;
      this.cmbBanco.FormattingEnabled = true;
      this.cmbBanco.Location = new Point(5, 51);
      this.cmbBanco.Name = "cmbBanco";
      this.cmbBanco.Size = new Size(148, 21);
      this.cmbBanco.TabIndex = 8;
      this.label15.AutoSize = true;
      this.label15.Location = new Point(389, 36);
      this.label15.Name = "label15";
      this.label15.Size = new Size(78, 13);
      this.label15.TabIndex = 13;
      this.label15.Text = "Observaciones";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(271, 36);
      this.label14.Name = "label14";
      this.label14.Size = new Size(77, 13);
      this.label14.TabIndex = 12;
      this.label14.Text = "N° Documento";
      this.label13.AutoSize = true;
      this.label13.Location = new Point(159, 36);
      this.label13.Name = "label13";
      this.label13.Size = new Size(41, 13);
      this.label13.TabIndex = 11;
      this.label13.Text = "Cuenta";
      this.label12.AutoSize = true;
      this.label12.Location = new Point(5, 36);
      this.label12.Name = "label12";
      this.label12.Size = new Size(38, 13);
      this.label12.TabIndex = 10;
      this.label12.Text = "Banco";
      this.dtpFechaCobro.Format = DateTimePickerFormat.Short;
      this.dtpFechaCobro.Location = new Point(119, 9);
      this.dtpFechaCobro.Name = "dtpFechaCobro";
      this.dtpFechaCobro.Size = new Size(99, 20);
      this.dtpFechaCobro.TabIndex = 3;
      this.label11.BackColor = Color.Transparent;
      this.label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.Black;
      this.label11.Location = new Point(5, 9);
      this.label11.Name = "label11";
      this.label11.Size = new Size(115, 17);
      this.label11.TabIndex = 8;
      this.label11.Text = "Fecha de Cobro:";
      this.label11.TextAlign = ContentAlignment.MiddleLeft;
      this.txtMonto.Location = new Point(543, 9);
      this.txtMonto.Name = "txtMonto";
      this.txtMonto.Size = new Size(90, 20);
      this.txtMonto.TabIndex = 5;
      this.txtMonto.TextAlign = HorizontalAlignment.Right;
      this.txtMonto.KeyPress += new KeyPressEventHandler(this.txtMonto_KeyPress);
      this.label10.BackColor = Color.Transparent;
      this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = Color.Black;
      this.label10.Location = new Point(493, 9);
      this.label10.Name = "label10";
      this.label10.Size = new Size(53, 17);
      this.label10.TabIndex = 6;
      this.label10.Text = "Monto:";
      this.label10.TextAlign = ContentAlignment.MiddleLeft;
      this.rdbDocumentado.BackColor = Color.Transparent;
      this.rdbDocumentado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.rdbDocumentado.Location = new Point(737, 9);
      this.rdbDocumentado.Name = "rdbDocumentado";
      this.rdbDocumentado.Size = new Size(114, 17);
      this.rdbDocumentado.TabIndex = 7;
      this.rdbDocumentado.TabStop = true;
      this.rdbDocumentado.Text = "Documentado";
      this.rdbDocumentado.UseVisualStyleBackColor = false;
      this.rdbPagado.BackColor = Color.Transparent;
      this.rdbPagado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.rdbPagado.Location = new Point(653, 9);
      this.rdbPagado.Name = "rdbPagado";
      this.rdbPagado.Size = new Size(83, 20);
      this.rdbPagado.TabIndex = 6;
      this.rdbPagado.TabStop = true;
      this.rdbPagado.Text = "Pagado";
      this.rdbPagado.TextAlign = ContentAlignment.TopLeft;
      this.rdbPagado.UseVisualStyleBackColor = false;
      this.cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMedioPago.FormattingEnabled = true;
      this.cmbMedioPago.Location = new Point(352, 9);
      this.cmbMedioPago.Name = "cmbMedioPago";
      this.cmbMedioPago.Size = new Size(135, 21);
      this.cmbMedioPago.TabIndex = 4;
      this.label9.BackColor = Color.Transparent;
      this.label9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = Color.Black;
      this.label9.Location = new Point(241, 9);
      this.label9.Name = "label9";
      this.label9.Size = new Size(108, 17);
      this.label9.TabIndex = 0;
      this.label9.Text = "Medio de Pago:";
      this.label9.TextAlign = ContentAlignment.MiddleLeft;
      this.dgvDetalle.AllowUserToAddRows = false;
      this.dgvDetalle.AllowUserToDeleteRows = false;
      this.dgvDetalle.BackgroundColor = Color.LightSteelBlue;
      this.dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvDetalle.Location = new Point(2, 6);
      this.dgvDetalle.Name = "dgvDetalle";
      this.dgvDetalle.ReadOnly = true;
      this.dgvDetalle.RowHeadersVisible = false;
      this.dgvDetalle.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDetalle.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDetalle.Size = new Size(872, 163);
      this.dgvDetalle.TabIndex = 27;
      this.dgvDetalle.CellClick += new DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
      this.dgvDetalle.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDetalle_CellDoubleClick);
      this.btnAgregar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAgregar.Location = new Point(687, 144);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(103, 32);
      this.btnAgregar.TabIndex = 12;
      this.btnAgregar.Text = "Guardar [F5]";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Location = new Point(794, 144);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 32);
      this.btnLimpiar.TabIndex = 13;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnGuardar.Location = new Point(257, 424);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 23);
      this.btnGuardar.TabIndex = 15;
      this.btnGuardar.Text = "Guardar [F2]";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Visible = false;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnModificar.Location = new Point(338, 424);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(85, 23);
      this.btnModificar.TabIndex = 16;
      this.btnModificar.Text = "Modificar [F2]";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Visible = false;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnImprimir.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnImprimir.Location = new Point(6, 406);
      this.btnImprimir.Name = "btnImprimir";
      this.btnImprimir.Size = new Size(75, 41);
      this.btnImprimir.TabIndex = 17;
      this.btnImprimir.Text = "Imprimir";
      this.btnImprimir.UseVisualStyleBackColor = true;
      this.btnImprimir.Click += new EventHandler(this.btnImprimir_Click);
      this.btnLimpiarFormulario.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiarFormulario.Location = new Point(87, 406);
      this.btnLimpiarFormulario.Name = "btnLimpiarFormulario";
      this.btnLimpiarFormulario.Size = new Size(75, 41);
      this.btnLimpiarFormulario.TabIndex = 18;
      this.btnLimpiarFormulario.Text = "Limpiar";
      this.btnLimpiarFormulario.UseVisualStyleBackColor = true;
      this.btnLimpiarFormulario.Click += new EventHandler(this.btnLimpiarFormulario_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(166, 406);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 41);
      this.btnSalir.TabIndex = 19;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.lblEstadoPago.AutoSize = true;
      this.lblEstadoPago.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblEstadoPago.ForeColor = Color.Black;
      this.lblEstadoPago.Location = new Point(11, 361);
      this.lblEstadoPago.Name = "lblEstadoPago";
      this.lblEstadoPago.Size = new Size(24, 33);
      this.lblEstadoPago.TabIndex = 12;
      this.lblEstadoPago.Text = ".";
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.btnLimpiaDetalle);
      this.panel1.Controls.Add((Control) this.rdbDocumentado);
      this.panel1.Controls.Add((Control) this.txtMonto);
      this.panel1.Controls.Add((Control) this.cmbMedioPago);
      this.panel1.Controls.Add((Control) this.dtpFechaCobro);
      this.panel1.Controls.Add((Control) this.txtObservaciones);
      this.panel1.Controls.Add((Control) this.rdbPagado);
      this.panel1.Controls.Add((Control) this.txtNumeroDocumento);
      this.panel1.Controls.Add((Control) this.label9);
      this.panel1.Controls.Add((Control) this.txtCuenta);
      this.panel1.Controls.Add((Control) this.cmbBanco);
      this.panel1.Controls.Add((Control) this.label15);
      this.panel1.Controls.Add((Control) this.label14);
      this.panel1.Controls.Add((Control) this.label10);
      this.panel1.Controls.Add((Control) this.label13);
      this.panel1.Controls.Add((Control) this.label12);
      this.panel1.Controls.Add((Control) this.label11);
      this.panel1.Location = new Point(5, 58);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(887, 80);
      this.panel1.TabIndex = 22;
      this.btnLimpiaDetalle.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiaDetalle.Location = new Point(858, 3);
      this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
      this.btnLimpiaDetalle.Size = new Size(19, 68);
      this.btnLimpiaDetalle.TabIndex = 20;
      this.btnLimpiaDetalle.Text = "..";
      this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaDetalle.Click += new EventHandler(this.btnLimpiaDetalle_Click);
      this.btnModificaLinea.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnModificaLinea.Location = new Point(584, 144);
      this.btnModificaLinea.Name = "btnModificaLinea";
      this.btnModificaLinea.Size = new Size(98, 32);
      this.btnModificaLinea.TabIndex = 14;
      this.btnModificaLinea.Text = "Modificar";
      this.btnModificaLinea.UseVisualStyleBackColor = true;
      this.btnModificaLinea.Click += new EventHandler(this.btnModificaLinea_Click);
      this.groupBox3.Controls.Add((Control) this.txtRazonSocial);
      this.groupBox3.Controls.Add((Control) this.label16);
      this.groupBox3.Controls.Add((Control) this.txtEmision);
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Controls.Add((Control) this.txtRut);
      this.groupBox3.Controls.Add((Control) this.btnBuscar);
      this.groupBox3.Controls.Add((Control) this.label2);
      this.groupBox3.Location = new Point(340, -3);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(552, 60);
      this.groupBox3.TabIndex = 21;
      this.groupBox3.TabStop = false;
      this.label16.AutoSize = true;
      this.label16.BackColor = Color.Transparent;
      this.label16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = Color.Black;
      this.label16.Location = new Point(199, 14);
      this.label16.Name = "label16";
      this.label16.Size = new Size(92, 15);
      this.label16.TabIndex = 15;
      this.label16.Text = "Razon Social";
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(6, 160);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(886, 198);
      this.tabControl1.SizeMode = TabSizeMode.Fixed;
      this.tabControl1.TabIndex = 28;
      this.tabPage1.Controls.Add((Control) this.dgvDetalle);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(878, 172);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Pagos";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage2.Controls.Add((Control) this.dgvNC);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(878, 172);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Notas de Credito";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.dgvNC.AllowUserToAddRows = false;
      this.dgvNC.AllowUserToDeleteRows = false;
      this.dgvNC.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvNC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvNC.Location = new Point(2, 6);
      this.dgvNC.Name = "dgvNC";
      this.dgvNC.ReadOnly = true;
      this.dgvNC.RowHeadersVisible = false;
      this.dgvNC.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvNC.ScrollBars = ScrollBars.Vertical;
      this.dgvNC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvNC.Size = new Size(869, 163);
      this.dgvNC.TabIndex = 0;
      this.dgvNC.CellClick += new DataGridViewCellEventHandler(this.dgvNC_CellClick);
      this.pnlRecuedroNC.BackColor = Color.WhiteSmoke;
      this.pnlRecuedroNC.BorderStyle = BorderStyle.FixedSingle;
      this.pnlRecuedroNC.Controls.Add((Control) this.btnCerrar);
      this.pnlRecuedroNC.Controls.Add((Control) this.btnPagar);
      this.pnlRecuedroNC.Controls.Add((Control) this.txtMontoUsar);
      this.pnlRecuedroNC.Controls.Add((Control) this.txtMontoDisponible);
      this.pnlRecuedroNC.Controls.Add((Control) this.txtFolioNC);
      this.pnlRecuedroNC.Controls.Add((Control) this.label19);
      this.pnlRecuedroNC.Controls.Add((Control) this.label18);
      this.pnlRecuedroNC.Controls.Add((Control) this.label17);
      this.pnlRecuedroNC.Location = new Point(286, 144);
      this.pnlRecuedroNC.Name = "pnlRecuedroNC";
      this.pnlRecuedroNC.Size = new Size(286, 119);
      this.pnlRecuedroNC.TabIndex = 29;
      this.btnCerrar.FlatStyle = FlatStyle.Flat;
      this.btnCerrar.Location = new Point(256, 1);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new Size(26, 23);
      this.btnCerrar.TabIndex = 7;
      this.btnCerrar.Text = "X";
      this.btnCerrar.UseVisualStyleBackColor = true;
      this.btnCerrar.Click += new EventHandler(this.btnCerrar_Click);
      this.btnPagar.Location = new Point(137, 91);
      this.btnPagar.Name = "btnPagar";
      this.btnPagar.Size = new Size(99, 23);
      this.btnPagar.TabIndex = 6;
      this.btnPagar.Text = "Pagar";
      this.btnPagar.UseVisualStyleBackColor = true;
      this.btnPagar.Click += new EventHandler(this.btnPagar_Click);
      this.txtMontoUsar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtMontoUsar.Location = new Point(136, 65);
      this.txtMontoUsar.Name = "txtMontoUsar";
      this.txtMontoUsar.Size = new Size(100, 21);
      this.txtMontoUsar.TabIndex = 5;
      this.txtMontoUsar.TextChanged += new EventHandler(this.txtMontoUsar_TextChanged);
      this.txtMontoUsar.KeyPress += new KeyPressEventHandler(this.txtMontoUsar_KeyPress);
      this.txtMontoDisponible.BackColor = Color.White;
      this.txtMontoDisponible.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtMontoDisponible.Location = new Point(136, 39);
      this.txtMontoDisponible.Name = "txtMontoDisponible";
      this.txtMontoDisponible.Size = new Size(100, 21);
      this.txtMontoDisponible.TabIndex = 4;
      this.txtFolioNC.BackColor = Color.White;
      this.txtFolioNC.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFolioNC.Location = new Point(136, 13);
      this.txtFolioNC.Name = "txtFolioNC";
      this.txtFolioNC.Size = new Size(100, 21);
      this.txtFolioNC.TabIndex = 3;
      this.txtFolioNC.KeyPress += new KeyPressEventHandler(this.txtFolioNC_KeyPress);
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label19.Location = new Point(48, 68);
      this.label19.Name = "label19";
      this.label19.Size = new Size(81, 15);
      this.label19.TabIndex = 2;
      this.label19.Text = "Monto Usar";
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label18.Location = new Point(9, 42);
      this.label18.Name = "label18";
      this.label18.Size = new Size(120, 15);
      this.label18.TabIndex = 1;
      this.label18.Text = "Monto Disponible";
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label17.Location = new Point(22, 16);
      this.label17.Name = "label17";
      this.label17.Size = new Size(107, 15);
      this.label17.TabIndex = 0;
      this.label17.Text = "Nota Credito N°";
      this.ticketTableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(898, 455);
      this.Controls.Add((Control) this.pnlRecuedroNC);
      this.Controls.Add((Control) this.btnModificaLinea);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.btnAgregar);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.lblEstadoPago);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiarFormulario);
      this.Controls.Add((Control) this.btnImprimir);
      this.Controls.Add((Control) this.btnModificar);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox2);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "frmPagoVenta";
      this.ShowIcon = false;
      this.Text = "Control De Pagos de Ventas";
      this.FormClosing += new FormClosingEventHandler(this.frmPagoVenta_FormClosing);
      this.KeyDown += new KeyEventHandler(this.frmPagoVenta_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((ISupportInitialize) this.dgvDetalle).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((ISupportInitialize) this.dgvNC).EndInit();
      this.pnlRecuedroNC.ResumeLayout(false);
      this.pnlRecuedroNC.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
