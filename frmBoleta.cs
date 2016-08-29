 
// Type: Aptusoft.frmBoleta
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using Aptusoft.Lotes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmBoleta : Form
  {
      private bool limpiar = true;
    private static List<DatosVentaVO> lista = new List<DatosVentaVO>();
    private List<ProductoAuxiliar> listaAuxiliar = new List<ProductoAuxiliar>();
    private bool esExento = false;
    private bool _modBodega = false;
    private int noVender = 0;
    private string _mesa = "";
    private string _porcIva = "0";
    private string _Iva = "0";
    private string _Neto = "0";
    private bool hayTicket = false;
    private bool hayComanda = false;
    private bool hayCotizacion = false;
    private bool hayNotaVenta = false;
    private Decimal stock = new Decimal(0);
    private int idImpuesto = 0;
    private Decimal netoLinea = new Decimal(0);
    private Decimal valorCompra = new Decimal(0);
    private List<VendedorVO> listaVendedores = new List<VendedorVO>();
    private List<VendedorVO> listaGarzones = new List<VendedorVO>();
    private List<MedioPagoVO> listaMediosPago = new List<MedioPagoVO>();
    private List<ImpuestoVO> listaImpuestos = new List<ImpuestoVO>();
    private List<CentroCostoVO> listaCentroCosto = new List<CentroCostoVO>();
    private OpcionesDocumentosVO odVO = new OpcionesDocumentosVO();
    private Decimal ivaInicio = new Decimal(0);
    private bool verificaCreditoActivo = false;
    private bool impideVentaSinCredito = false;
    private bool impideVenta = false;
    private string _permisoMedioPago = "";
    private bool _permisoPemitirMedioPago = false;
    private string _opcionBusquedaRazonSocial = "1";
    private string codigoRepetido = "";
    private string cantidadRepetido = "";
    public List<LoteVO> _listaLote = new List<LoteVO>();
    public List<LoteVO> _listaLoteAntigua = new List<LoteVO>();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private bool _anula = false;
    private bool _descuento = false;
    private bool _cambioPrecio = false;
    private bool _cambioFecha = false;
    private int _caja = 0;
    private int _bodega = 0;
    private int _listaPrecio = 0;
    private Venta veOBBoleta = new Venta();
    private IContainer components = (IContainer) null;
    private string _Direccion;
    private string _Comuna;
    private string _Ciudad;
    private string _Giro;
    private string _Fono;
    private string _Fax;
    private string _Contacto;
    private string _DiasPlazo;
    private string _ResumenDescripcion;
    private frmBoleta intance;
    private int codigoCliente;
    private int idBoleta;
    private int idTicket;
    private int idComanda;
    private string alertaStock;
    private string numeroLineas;
    private string descripcionResumen;
    private string iniciaEnNumeroDeticket;
    private string decimalesValoresVenta;
    private string impideVentasSinStock;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem;
    private Label label17;
    private Label label19;
    private Label label15;
    private Label label14;
    private TextBox txtCantidad;
    private Label label13;
    private TextBox txtCodigo;
    private Label label20;
    private TextBox txtDescripcion;
    private TextBox txtTotalLinea;
    private GroupBox gbZonaCliente;
    private Label label5;
    private Label label4;
    private TextBox txtRazonSocial;
    private TextBox txtDigito;
    private TextBox txtRut;
    private TextBox txtPrecio;
    private TextBox txtDescuento;
    private CheckBox chkCantidadFija;
    private Button btnAgregar;
    private Button btnLimpiaDetalle;
    private GroupBox gbZonaFechas;
    private Label label16;
    private TextBox txtOrdenCompra;
    private Label lblFolio;
    private TextBox txtNumeroDocumento;
    private Label label2;
    private DateTimePicker dtpVencimiento;
    private Label label1;
    private DateTimePicker dtpEmision;
    private GroupBox gbZonaBotones;
    private TextBox txtSubTotal;
    private TextBox txtTotalGeneral;
    private TextBox txtTotalDescuento;
    private TextBox txtPorcDescuentoTotal;
    private Label label26;
    private Label label23;
    private Label label22;
    private DataGridView dgvDatosVenta;
    private Label label27;
    private ComboBox cmbVendedor;
    private GroupBox gbZonaOtros;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private Label label28;
    private ComboBox cmbBodega;
    private Label label29;
    private ComboBox cmbListaPrecio;
    private Button btnBuscaCliente;
    private DataGridView dgvBuscaCliente;
    private Panel pnlBuscaClienteDes;
    private Label label18;
    private ComboBox cmbMedioPago;
    private ComboBox cmbCentroCosto;
    private Label label30;
    private TextBox txtPorcDescuentoLinea;
    private Label label31;
    private Panel panel4;
    private Panel panel3;
    private TextBox txtLinea;
    private Button btnModificaLinea;
    private Button btnLimpiaLineaDetalle;
    private TextBox txtSubTotalLinea;
    private TextBox txtTipoDescuento;
    private ToolStripMenuItem buscarProductosTeclaF4ToolStripMenuItem;
    private Panel panelFolio;
    private Button btnBuscaFolio;
    private TextBox txtFolioBuscar;
    private Label label32;
    private Button btnCerrarPanelFolio;
    private ToolStripMenuItem buscarFacturaTeclaF6ToolStripMenuItem;
    private Button btnAnular;
    private Label lblEstadoDocumento;
    private ToolStripMenuItem guardarFacturaTeclaF2ToolStripMenuItem;
    private Button btnImprime;
    private Button btnControlPago;
    private Label label3;
    private ToolStripMenuItem cambiarNumeroDeFolioToolStripMenuItem;
    private Label label33;
    private TextBox txtTicket;
    private CheckBox chkVendedorFijo;
    private CheckBox chkMedioPagoFijo;
    private Label label6;
    private TextBox txtTotalExento;
    private GroupBox groupBox1;
    private TextBox txtTotalCobrar;
    private Label label7;
    private GroupBox groupBox2;
    private TextBox txtTotalImp5;
    private TextBox txtTotalImp3;
    private TextBox txtTotalImp4;
    private TextBox txtPorImp5;
    private TextBox txtPorImp3;
    private TextBox txtTotalImp2;
    private TextBox txtPorImp4;
    private TextBox txtPorImp2;
    private TextBox txtTotalImp1;
    private TextBox txtPorImp1;
    private Label lblImp5;
    private Label lblImp4;
    private Label lblImp3;
    private Label lblImp2;
    private Label lblImp1;
    private TextBox txtNeto;
    private TextBox txtIva;
    private Label label8;
    private Label lblPagaCon;
    private Panel panelVuelto;
    private Label lblVuelto;
    private Label label10;
    private ToolStripMenuItem calculaVueltoTeclaF5ToolStripMenuItem;
    private ToolStripMenuItem listarBoletasToolStripMenuItem;
    private ToolStripMenuItem importarToolStripMenuItem;
    private ToolStripMenuItem cotizaciónToolStripMenuItem;
    private Panel pnlCotizacionBuscar;
    private GroupBox groupBox3;
    private Button btnBuscaCotizacion;
    private Button btnSalirBuscaCoti;
    private TextBox txtFolioCotizacion;
    private Label label36;
    private Panel panelNotaVenta;
    private GroupBox groupBox4;
    private Button btnBuscaNotaventa;
    private Button btnCierraNota;
    private TextBox txtFolioNotaVenta;
    private Label label37;
    private ToolStripMenuItem notaDeVentaToolStripMenuItem;
    private Button btnVerificaCredito;
    private TextBox txtCreditoDisponible;
    private Label label38;
    private TextBox txtComanda;
    private Label lblComanda;
    private ComboBox cmbGarzon;
    private Label lblGarzon;
    private CheckBox chkCentroCostoFijo;
    private TextBox txtCodigoRapido;
    private Label label9;
    private Button btnRepiteCodigo;
    private TextBox txtDescripcionCopia;
    private Label label11;
    private Panel panel2;
    private Label label12;
    private TabControl tabControlZonaDetalle;
    private TabPage tabPageVentaNormal;
    private TabPage tabPageVentaRapida;
    private Panel panel1;
    private Panel panelNumeroOperacion;
    private Label label21;
    private TextBox txtNumeroOperacion;
    private Button btnCancelarNumOperacion;
    private Button btnAceptarNumOperacion;
    private TextBox txtNumeroVoucher;
    private ToolStripMenuItem buscarVoucherToolStripMenuItem;
    private Panel panel5;
    private Label label34;
    private Label label25;
    private TextBox textBox1;
    private Button button1;
    private Button button2;
    private TextBox txtvoucher;
    private Label label24;

    public frmBoleta()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.iniciaVenta();
      this.intance = this;
      if (frmMenuPrincipal._Restorant)
      {
        this.lblComanda.Visible = true;
        this.lblGarzon.Visible = true;
        this.cmbGarzon.Visible = true;
        this.txtComanda.Visible = true;
      }
      else
      {
        this.lblComanda.Visible = false;
        this.lblGarzon.Visible = false;
        this.cmbGarzon.Visible = false;
        this.txtComanda.Visible = false;
      }
    }

    public frmBoleta(string des, Decimal val)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.iniciaVenta();
      this.intance = this;
      this.agregaDevolucionGrilla(des, val);
      if (frmMenuPrincipal._Restorant)
      {
        this.lblComanda.Visible = true;
        this.lblGarzon.Visible = true;
        this.cmbGarzon.Visible = true;
        this.txtComanda.Visible = true;
      }
      else
      {
        this.lblComanda.Visible = false;
        this.lblGarzon.Visible = false;
        this.cmbGarzon.Visible = false;
        this.txtComanda.Visible = false;
      }
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("BOLETA"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._anula = Convert.ToBoolean(usuarioVo.Anula);
          this._descuento = Convert.ToBoolean(usuarioVo.Descuento);
          this._cambioPrecio = Convert.ToBoolean(usuarioVo.CambioPrecio);
          this._cambioFecha = Convert.ToBoolean(usuarioVo.CambioFecha);
          this._caja = usuarioVo.IdCaja;
          this._bodega = usuarioVo.IdBodega;
          this._listaPrecio = usuarioVo.IdListaPrecio;
        }
      }
    }

    public void cargaOpcionesDocumentosInicio()
    {
      this.odVO = new OpcionesGenerales().rescataOpcionesDocumentosPorNombre("BOLETA");
    }

    public void cargaOpcionesDocumentos()
    {
      this.alertaStock = this.odVO.AlertaStockInsuficiente;
      this.impideVentasSinStock = this.odVO.ImpideVentasSinStock;
      this.numeroLineas = this.odVO.CantidadLineasDocumento;
      this.decimalesValoresVenta = this.odVO.DecimalesValorVenta.ToString();
      this.descripcionResumen = this.odVO.Descripcion_Resumen;
      this.iniciaEnNumeroDeticket = this.odVO.iniciarEnNumeroTicket;
      this._permisoMedioPago = this.odVO.MedioPago;
      this._permisoPemitirMedioPago = this.odVO.PermitirMedioPago == "1";
      this._opcionBusquedaRazonSocial = this.odVO.BusquedaRazonSocial;
    }

    private void cargaVendedores()
    {
      this.cmbVendedor.DataSource = (object) this.listaVendedores;
      this.cmbVendedor.ValueMember = "idVendedor";
      this.cmbVendedor.DisplayMember = "nombre";
      this.cmbVendedor.SelectedValue = (object) 0;
    }

    private void cargaVendedoresInicio()
    {
      this.listaVendedores = new Vendedor().listaVendedoresVenta();
    }

    private void cargaGarzones()
    {
      if (!frmMenuPrincipal._Restorant)
        return;
      this.cmbGarzon.DataSource = (object) this.listaGarzones;
      this.cmbGarzon.ValueMember = "idVendedor";
      this.cmbGarzon.DisplayMember = "nombre";
      this.cmbGarzon.SelectedValue = (object) 0;
    }

    private void cargaGarzonesInicio()
    {
      if (!frmMenuPrincipal._Restorant)
        return;
      this.listaGarzones = new Garzon().listaGarzonesVenta();
    }

    private void cargaCentroCosto()
    {
      this.cmbCentroCosto.DataSource = (object) this.listaCentroCosto;
      this.cmbCentroCosto.ValueMember = "idCentroCosto";
      this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
      this.cmbCentroCosto.SelectedValue = (object) 0;
    }

    private void cargaCentroCostoInicio()
    {
      this.listaCentroCosto = new CentroCosto().listaCentroCostoVenta();
    }

    private void cargaMediosPagoInicio()
    {
      this.listaMediosPago = new MedioPago().listaMediosPagoVenta();
    }

    private void cargaMediosPago()
    {
      this.cmbMedioPago.DataSource = (object) this.listaMediosPago;
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      if (this._permisoMedioPago.Equals("0"))
        this.cmbMedioPago.SelectedValue = (object) 0;
      else
        this.cmbMedioPago.Text = this._permisoMedioPago;
      if (this._permisoPemitirMedioPago)
      {
        this.chkMedioPagoFijo.Checked = true;
        this.chkMedioPagoFijo.Enabled = false;
        this.cmbMedioPago.Enabled = false;
      }
      else
      {
        this.chkMedioPagoFijo.Enabled = true;
        this.cmbMedioPago.Enabled = true;
      }
    }

    private void obtieneFolioBoletaDisponible()
    {
      this.txtNumeroDocumento.Text = new Boleta().numeroBoleta(this._caja).ToString();
    }

    private void cargaImpuestosInicio()
    {
      this.listaImpuestos = new Impuestos().listaImpuestos();
    }

    private void cargaImpuestos()
    {
      foreach (ImpuestoVO impuestoVo in this.listaImpuestos)
      {
        if (impuestoVo.IdImpuesto == 1)
        {
          this.lblImp1.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp1.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
        if (impuestoVo.IdImpuesto == 2)
        {
          this.lblImp2.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp2.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
        if (impuestoVo.IdImpuesto == 3)
        {
          this.lblImp3.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp3.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
        if (impuestoVo.IdImpuesto == 4)
        {
          this.lblImp4.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp4.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
        if (impuestoVo.IdImpuesto == 5)
        {
          this.lblImp5.Text = impuestoVo.NombreImpuesto;
          this.txtPorImp5.Text = impuestoVo.PorcentajeImpuesto.ToString("N2");
        }
      }
    }

    private void cargaBodega()
    {
      this.cmbBodega.DataSource = (object) new CargaMaestros().cargaBodega();
      this.cmbBodega.ValueMember = "codigo";
      this.cmbBodega.DisplayMember = "descripcion";
      if (this._bodega == 0)
      {
        this.cmbBodega.Enabled = true;
        this.cmbBodega.SelectedValue = (object) 1;
        this._modBodega = true;
      }
      else
      {
        this.cmbBodega.Enabled = false;
        this.cmbBodega.SelectedValue = (object) this._bodega;
        this._modBodega = false;
      }
    }

    private void cargaListaPrecio()
    {
      this.cmbListaPrecio.DataSource = (object) new CargaMaestros().cargaListaPrecio();
      this.cmbListaPrecio.ValueMember = "codigo";
      this.cmbListaPrecio.DisplayMember = "descripcion";
      if (this._listaPrecio == 0)
      {
        this.cmbListaPrecio.Enabled = true;
        this.cmbListaPrecio.SelectedValue = (object) 1;
      }
      else
      {
        this.cmbListaPrecio.Enabled = false;
        this.cmbListaPrecio.SelectedValue = (object) this._listaPrecio;
      }
    }

    private void cargaIvaInicio()
    {
      Calculos calculos = new Calculos();
      this.ivaInicio = calculos._iva;
      this.verificaCreditoActivo = calculos._verificaCredito;
      this.impideVenta = calculos._impedirVentasSinCredito;
    }

    private void iniciaFormulario()
    {
      try
      {
        this.cargaIvaInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Porcentaje del Iva: " + ex.Message);
      }
      try
      {
        this.cargaVendedoresInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Vendedores: " + ex.Message);
        this.Close();
      }
      try
      {
        this.cargaGarzonesInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Garzones: " + ex.Message);
        this.Close();
      }
      try
      {
        this.cargaCentroCostoInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Centro Costo: " + ex.Message);
        this.Close();
      }
      try
      {
        this.cargaMediosPagoInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Medios de Pago: " + ex.Message);
        this.Close();
      }
      try
      {
        this.cargaImpuestosInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Impuestos: " + ex.Message);
        this.Close();
      }
      try
      {
        this.cargaOpcionesDocumentosInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Opciones de Documento: " + ex.Message);
        this.Close();
      }
    }

    public void iniciaVenta()
    {
      this.cargaImpuestos();
      this.cargaBodega();
      this.cargaListaPrecio();
      this.codigoCliente = 0;
      this.cargaOpcionesDocumentos();
      this._Iva = this.ivaInicio.ToString("N0");
      this.panelVuelto.Visible = false;
      this.lblVuelto.Text = "0";
      this.lblPagaCon.Text = "0";
      this.pnlCotizacionBuscar.Visible = false;
      this.txtFolioCotizacion.Clear();
      this.panelNotaVenta.Visible = false;
      this.txtFolioNotaVenta.Clear();
      if (!this.chkMedioPagoFijo.Checked)
        this.cargaMediosPago();
      else
        this.cmbMedioPago.Enabled = false;
      if (!this.chkCentroCostoFijo.Checked)
      {
        this.cargaCentroCosto();
        this.cmbCentroCosto.Enabled = true;
      }
      else
        this.cmbCentroCosto.Enabled = false;
      if (!this.chkVendedorFijo.Checked)
        this.cargaVendedores();
      this.cargaGarzones();
      try
      {
        this.obtieneFolioBoletaDisponible();
        this.txtNumeroDocumento.Enabled = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar Folio: " + ex.Message);
      }
      this.dtpEmision.Value = DateTime.Today;
      this.dtpVencimiento.Value = DateTime.Today;
      if (this._cambioFecha)
      {
        this.dtpEmision.Enabled = true;
        this.dtpVencimiento.Enabled = true;
      }
      else
      {
        this.dtpEmision.Enabled = false;
        this.dtpVencimiento.Enabled = false;
      }
      this.panelFolio.Visible = false;
      this.txtNumeroVoucher.Clear();
      this.txtOrdenCompra.Clear();
      this.txtRut.Clear();
      this.txtDigito.Clear();
      this.txtRazonSocial.Clear();
      this.txtRazonSocial.Enabled = true;
      this._Direccion = "";
      this._Comuna = "";
      this._Ciudad = "";
      this._Giro = "";
      this._Fono = "";
      this._Fax = "";
      this._Contacto = "";
      this._DiasPlazo = "0";
      this.txtNumeroVoucher.ReadOnly = false;
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtPrecio.Clear();
      if (!this.chkCantidadFija.Checked)
        this.txtCantidad.Clear();
      this.txtDescuento.Clear();
      this.txtPorcDescuentoLinea.Clear();
      this.txtTotalLinea.Text = "0";
      this.btnModificaLinea.Visible = false;
      this.txtTicket.Clear();
      this.txtComanda.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtSubTotal.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTotalExento.Clear();
      this.txtTotalCobrar.Clear();
      this.txtTotalImp1.Clear();
      this.txtTotalImp2.Clear();
      this.txtTotalImp3.Clear();
      this.txtTotalImp4.Clear();
      this.txtTotalImp5.Clear();
      this.txtCodigoRapido.Clear();
      this.codigoRepetido = "";
      this.cantidadRepetido = "";
      this.txtDescripcionCopia.Clear();
      this.btnRepiteCodigo.Enabled = false;
      if (this._guarda)
      {
        this.btnGuardar.Enabled = true;
        this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = true;
      }
      else
      {
        this.btnGuardar.Enabled = false;
        this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
      }
      this.btnModificar.Enabled = false;
      this.btnAnular.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnImprime.Enabled = false;
      this.btnControlPago.Enabled = false;
      if (this._descuento)
      {
        this.txtPorcDescuentoLinea.Enabled = true;
        this.txtPorcDescuentoTotal.Enabled = true;
        this.txtDescuento.Enabled = true;
        this.txtTotalDescuento.Enabled = true;
      }
      else
      {
        this.txtPorcDescuentoLinea.Enabled = false;
        this.txtPorcDescuentoTotal.Enabled = false;
        this.txtDescuento.Enabled = false;
        this.txtTotalDescuento.Enabled = false;
      }
      if (this._cambioPrecio)
        this.txtPrecio.Enabled = true;
      else
        this.txtPrecio.Enabled = false;
      this.lblEstadoDocumento.Text = "";
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.Columns.Clear();
      this.creaColumnasDetalle();
      this.pnlBuscaClienteDes.Visible = false;
      this.creaColumnasBuscaClientes();
      this.idBoleta = 0;
      this.hayTicket = false;
      this.idTicket = 0;
      this.hayComanda = false;
      this.idComanda = 0;
      this._mesa = "";
      this.valorCompra = new Decimal(0);
      this.hayCotizacion = false;
      this.hayNotaVenta = false;
      this._Iva = "0";
      this._Neto = "0";
      frmBoleta.lista.Clear();
      this._listaLote.Clear();
      this._listaLoteAntigua.Clear();
      this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = true;
      this.limpiaEntradaDetalle();
      this.listaAuxiliar.Clear();
      this.panelNumeroOperacion.Visible = false;
      this.txtNumeroOperacion.Clear();
      if (this.iniciaEnNumeroDeticket.Equals("1"))
      {
        this.tabControlZonaDetalle.TabIndex = 1;
        this.gbZonaOtros.TabIndex = 2;
        this.gbZonaBotones.TabIndex = 3;
        this.gbZonaCliente.TabIndex = 4;
        this.gbZonaFechas.TabIndex = 5;
        this.txtTicket.Focus();
      }
      else
      {
        this.gbZonaOtros.TabIndex = 0;
        this.tabControlZonaDetalle.TabIndex = 1;
        this.gbZonaBotones.TabIndex = 3;
        this.gbZonaCliente.TabIndex = 4;
        this.gbZonaFechas.TabIndex = 5;
        this.cmbMedioPago.Focus();
      }
      this.txtCreditoDisponible.Clear();
      this.btnVerificaCredito.Enabled = false;
      this.impideVentaSinCredito = false;
    }

    private void creaColumnasDetalle()
    {
      this.dgvDatosVenta.AutoGenerateColumns = false;
      this.dgvDatosVenta.Columns.Add("Linea", "");
      this.dgvDatosVenta.Columns[0].DataPropertyName = "Linea";
      this.dgvDatosVenta.Columns[0].Width = 20;
      this.dgvDatosVenta.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[0].DefaultCellStyle.BackColor = Color.Lavender;
      this.dgvDatosVenta.Columns.Add("Codigo", "Codigo");
      this.dgvDatosVenta.Columns[1].DataPropertyName = "Codigo";
      this.dgvDatosVenta.Columns[1].Width = 100;
      this.dgvDatosVenta.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Descripcion", "Descripcion");
      this.dgvDatosVenta.Columns[2].DataPropertyName = "Descripcion";
      this.dgvDatosVenta.Columns[2].Width = 257;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("ValorVenta", "Precio");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "ValorVenta";
      this.dgvDatosVenta.Columns[3].Width = 80;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Cantidad", "Cantidad");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "Cantidad";
      this.dgvDatosVenta.Columns[4].Width = 80;
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Format = "N4";
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("PorcDescuento", "% Desc.");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "PorcDescuento";
      this.dgvDatosVenta.Columns[5].Width = 60;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Descuento", "$ Desc.");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "Descuento";
      this.dgvDatosVenta.Columns[6].Width = 70;
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Total", "Total");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "TotalLinea";
      this.dgvDatosVenta.Columns[7].Width = 90;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("SubTotal", "SubTotal");
      this.dgvDatosVenta.Columns[8].DataPropertyName = "SubTotalLinea";
      this.dgvDatosVenta.Columns[8].Width = 90;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[8].Visible = false;
      this.dgvDatosVenta.Columns.Add("TipoDescuento", "TipoDescuento");
      this.dgvDatosVenta.Columns[9].DataPropertyName = "TipoDescuento";
      this.dgvDatosVenta.Columns[9].Width = 90;
      this.dgvDatosVenta.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[9].Visible = false;
      this.dgvDatosVenta.Columns.Add("ListaPrecio", "ListaPrecio");
      this.dgvDatosVenta.Columns[10].DataPropertyName = "ListaPrecio";
      this.dgvDatosVenta.Columns[10].Width = 90;
      this.dgvDatosVenta.Columns[10].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[10].Visible = false;
      this.dgvDatosVenta.Columns.Add("Bodega", "Bodega");
      this.dgvDatosVenta.Columns[11].DataPropertyName = "Bodega";
      this.dgvDatosVenta.Columns[11].Width = 90;
      this.dgvDatosVenta.Columns[11].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[11].Visible = false;
      this.dgvDatosVenta.Columns.Add("FolioFactura", "FolioFactura");
      this.dgvDatosVenta.Columns[12].DataPropertyName = "FolioFactura";
      this.dgvDatosVenta.Columns[12].Width = 90;
      this.dgvDatosVenta.Columns[12].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[12].Visible = false;
      this.dgvDatosVenta.Columns.Add("IdFactura", "IdFactura");
      this.dgvDatosVenta.Columns[13].DataPropertyName = "IdFactura";
      this.dgvDatosVenta.Columns[13].Width = 90;
      this.dgvDatosVenta.Columns[13].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[13].Visible = false;
      DataGridViewButtonColumn viewButtonColumn1 = new DataGridViewButtonColumn();
      viewButtonColumn1.Name = "Eliminar";
      viewButtonColumn1.HeaderText = "Eliminar";
      viewButtonColumn1.UseColumnTextForButtonValue = true;
      viewButtonColumn1.Text = "X";
      viewButtonColumn1.Width = 50;
      viewButtonColumn1.DisplayIndex = 14;
      viewButtonColumn1.Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn1);
      this.dgvDatosVenta.Columns.Add("Exento", "Exento");
      this.dgvDatosVenta.Columns[15].DataPropertyName = "Exento";
      this.dgvDatosVenta.Columns[15].Width = 90;
      this.dgvDatosVenta.Columns[15].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[15].Visible = false;
      this.dgvDatosVenta.Columns.Add("IdImpuesto", "IdImpuesto");
      this.dgvDatosVenta.Columns[16].DataPropertyName = "IdImpuesto";
      this.dgvDatosVenta.Columns[16].Width = 90;
      this.dgvDatosVenta.Columns[16].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[16].Visible = false;
      this.dgvDatosVenta.Columns.Add("NetoLinea", "NetoLinea");
      this.dgvDatosVenta.Columns[17].DataPropertyName = "NetoLinea";
      this.dgvDatosVenta.Columns[17].Width = 90;
      this.dgvDatosVenta.Columns[17].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[17].Visible = false;
      this.dgvDatosVenta.Columns.Add("DescuentaInventario", "DescuentaInventario");
      this.dgvDatosVenta.Columns[18].DataPropertyName = "DescuentaInventario";
      this.dgvDatosVenta.Columns[18].Width = 90;
      this.dgvDatosVenta.Columns[18].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[18].Visible = false;
      this.dgvDatosVenta.Columns.Add("ValorCompra", "ValorCompra");
      this.dgvDatosVenta.Columns[19].DataPropertyName = "ValorCompra";
      this.dgvDatosVenta.Columns[19].Width = 90;
      this.dgvDatosVenta.Columns[19].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[19].Visible = false;
      DataGridViewButtonColumn viewButtonColumn2 = new DataGridViewButtonColumn();
      viewButtonColumn2.Name = "Lote";
      viewButtonColumn2.HeaderText = "Lote";
      viewButtonColumn2.UseColumnTextForButtonValue = true;
      viewButtonColumn2.Text = "::";
      viewButtonColumn2.Width = 50;
      viewButtonColumn2.DisplayIndex = 20;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn2);
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modBoleta = 0;
      GC.Collect();
      GC.WaitForPendingFinalizers();
      this.Close();
      this.Dispose();
    }

    private void calculaTotalLinea()
    {
      Calculos calculos = new Calculos();
      int num1 = Convert.ToInt32(this.txtTipoDescuento.Text);
      Decimal num2 = new Decimal(0);
      Decimal num3 = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text.Trim()) : new Decimal(0);
      Decimal valor = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text.Trim()) : new Decimal(0);
      Decimal cant = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text.Trim()) : new Decimal(0);
      Decimal descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text.Trim()) : new Decimal(0);
      Decimal porDesc = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text.Trim()) : new Decimal(0);
      Decimal subTotal = calculos.subTotalLinea(valor, cant);
      if (num1 == 1)
        descuento = calculos.descuentoValorLinea(porDesc, subTotal);
      if (num1 == 2)
      {
        porDesc = calculos.descuentoPorcentajeLinea(descuento, subTotal);
        descuento = calculos.descuentoValorLinea(porDesc, subTotal);
      }
      if (subTotal == new Decimal(0) || subTotal > descuento)
      {
        this.txtSubTotalLinea.Text = subTotal.ToString("N" + this.decimalesValoresVenta);
        this.txtDescuento.Text = descuento.ToString("##");
        this.txtPorcDescuentoLinea.Text = porDesc.ToString("##");
        Decimal total = Convert.ToDecimal(calculos.totalLinea(subTotal, descuento).ToString("N" + this.decimalesValoresVenta));
        this.txtTotalLinea.Text = total.ToString("N" + this.decimalesValoresVenta);
        if (this.idImpuesto == 0)
          this.netoLinea = calculos.netoLinea(total, 0);
        if (this.idImpuesto == 1)
          this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
        if (this.idImpuesto == 2)
          this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
        if (this.idImpuesto == 3)
          this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
        if (this.idImpuesto == 4)
          this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
        if (this.idImpuesto == 5)
          this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
        if (!this.esExento)
          return;
        this.netoLinea = new Decimal(0);
      }
      else
      {
        int num4 = (int) MessageBox.Show("El Descuento debe ser Menor al Total", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtDescuento.Clear();
        this.txtPorcDescuentoLinea.Clear();
      }
    }

    private void porcentajeDescuento_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    public void llamaProductoCodigo(string cod, int bodega)
    {
      this.cmbBodega.SelectedValue = (object) bodega.ToString();
      this.noVender = 0;
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
      this.esExento = productoVo.Exento;
      if (productoVo.Codigo != null)
      {
        switch (bodega)
        {
          case 1:
            this.stock = productoVo.Bodega1;
            break;
          case 2:
            this.stock = productoVo.Bodega2;
            break;
          case 3:
            this.stock = productoVo.Bodega3;
            break;
          case 4:
            this.stock = productoVo.Bodega4;
            break;
          case 5:
            this.stock = productoVo.Bodega5;
            break;
          case 6:
            this.stock = productoVo.Bodega6;
            break;
          case 7:
            this.stock = productoVo.Bodega7;
            break;
          case 8:
            this.stock = productoVo.Bodega8;
            break;
          case 9:
            this.stock = productoVo.Bodega9;
            break;
          case 10:
            this.stock = productoVo.Bodega10;
            break;
          case 11:
            this.stock = productoVo.Bodega11;
            break;
          case 12:
            this.stock = productoVo.Bodega12;
            break;
          case 13:
            this.stock = productoVo.Bodega13;
            break;
          case 14:
            this.stock = productoVo.Bodega14;
            break;
          case 15:
            this.stock = productoVo.Bodega15;
            break;
          case 16:
            this.stock = productoVo.Bodega16;
            break;
          case 17:
            this.stock = productoVo.Bodega17;
            break;
          case 18:
            this.stock = productoVo.Bodega18;
            break;
          case 19:
            this.stock = productoVo.Bodega19;
            break;
          case 20:
            this.stock = productoVo.Bodega20;
            break;
        }
        this.listaAuxiliar.Add(new ProductoAuxiliar()
        {
          Codigo = productoVo.Codigo,
          Bodega1 = productoVo.Bodega1,
          Bodega2 = productoVo.Bodega2,
          Bodega3 = productoVo.Bodega3,
          Bodega4 = productoVo.Bodega4,
          Bodega5 = productoVo.Bodega5,
          Bodega6 = productoVo.Bodega6,
          Bodega7 = productoVo.Bodega7,
          Bodega8 = productoVo.Bodega8,
          Bodega9 = productoVo.Bodega9,
          Bodega10 = productoVo.Bodega10,
          Bodega11 = productoVo.Bodega11,
          Bodega12 = productoVo.Bodega12,
          Bodega13 = productoVo.Bodega13,
          Bodega14 = productoVo.Bodega14,
          Bodega15 = productoVo.Bodega15,
          Bodega16 = productoVo.Bodega16,
          Bodega17 = productoVo.Bodega17,
          Bodega18 = productoVo.Bodega18,
          Bodega19 = productoVo.Bodega19,
          Bodega20 = productoVo.Bodega20
        });
        if (this.alertaStock.Equals("1"))
        {
          if (this.stock <= productoVo.StockMinimo)
          {
            int num = (int) MessageBox.Show("El Stock de este Producto esta Bajo el Stock Minimo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (this.impideVentasSinStock.Equals("1") && this.stock <= new Decimal(0))
              this.noVender = 1;
          }
          if (this.noVender == 0)
          {
            int num1 = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
            Decimal num2;
            if (num1 == 1)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta1;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            if (num1 == 2)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta2;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            if (num1 == 3)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta3;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            if (num1 == 4)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta4;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            if (num1 == 5)
            {
              TextBox textBox = this.txtPrecio;
              num2 = productoVo.ValorVenta5;
              string str = num2.ToString("N" + this.decimalesValoresVenta);
              textBox.Text = str;
            }
            this.txtCodigo.Text = productoVo.Codigo;
            this.txtDescripcion.Text = productoVo.Descripcion;
            this._ResumenDescripcion = productoVo.ResumenDescripcion;
            this.idImpuesto = productoVo.IdImpuesto;
            this.valorCompra = productoVo.ValorCompra;
            this.txtPrecio.Focus();
          }
          else
          {
            int num3 = (int) MessageBox.Show("No esta Autorizado para Vender Productos Sin Stock", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
        {
          int num1 = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
          Decimal num2;
          if (num1 == 1)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta1;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          if (num1 == 2)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta2;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          if (num1 == 3)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta3;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          if (num1 == 4)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta4;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          if (num1 == 5)
          {
            TextBox textBox = this.txtPrecio;
            num2 = productoVo.ValorVenta5;
            string str = num2.ToString("N" + this.decimalesValoresVenta);
            textBox.Text = str;
          }
          this.txtCodigo.Text = productoVo.Codigo;
          this.txtDescripcion.Text = productoVo.Descripcion;
          this._ResumenDescripcion = productoVo.ResumenDescripcion;
          this.idImpuesto = productoVo.IdImpuesto;
          this.valorCompra = productoVo.ValorCompra;
          this.txtPrecio.Focus();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe el Codigo Ingresado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCodigo.Clear();
        this.txtCodigo.Focus();
      }
    }

    public void seleccionaListaPrecios(int listaPrecio)
    {
      this.cmbListaPrecio.SelectedValue = (object) listaPrecio;
    }

    public void agregaLineaGrilla()
    {
      if (this.noVender != 0)
        return;
      this.txtTotalDescuento.ReadOnly = true;
      DatosVentaVO datosVentaVo = new DatosVentaVO();
      datosVentaVo.Codigo = this.txtCodigo.Text.Trim().ToUpper();
      datosVentaVo.Descripcion = this.txtDescripcion.Text.Trim().ToUpper();
      datosVentaVo.ResumenDescripcion = this._ResumenDescripcion;
      datosVentaVo.IdImpuesto = this.idImpuesto;
      datosVentaVo.NetoLinea = this.netoLinea;
      datosVentaVo.DescuentaInventario = true;
      datosVentaVo.ValorCompra = this.valorCompra;
      datosVentaVo.ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
      datosVentaVo.Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
      if (datosVentaVo.Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && this.txtCodigo.Text.Length > 0)
      {
        int num = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Imposible Hacer Venta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtPrecio.Focus();
      }
      else
      {
        if (datosVentaVo.Cantidad > this.stock && this.alertaStock.Equals("1") && this.txtCodigo.Text.Length > 0)
        {
          int num1 = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        datosVentaVo.Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
        datosVentaVo.PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
        datosVentaVo.TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
        datosVentaVo.SubTotalLinea = this.txtSubTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtSubTotalLinea.Text) : new Decimal(0);
        datosVentaVo.TipoDescuento = Convert.ToInt32(this.txtTipoDescuento.Text);
        datosVentaVo.ListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
        datosVentaVo.Bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        datosVentaVo.FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        datosVentaVo.Exento = this.esExento;
        if (frmBoleta.lista.Count < Convert.ToInt32(this.numeroLineas))
        {
          if (frmBoleta.lista.Count > 0)
          {
            bool flag = false;
            for (int index = 0; index < frmBoleta.lista.Count; ++index)
            {
              if (datosVentaVo.Cantidad + frmBoleta.lista[index].Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && datosVentaVo.Bodega == frmBoleta.lista[index].Bodega && datosVentaVo.Codigo == frmBoleta.lista[index].Codigo)
              {
                int num2 = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()));
                this.txtPrecio.Focus();
                flag = true;
              }
              else if (datosVentaVo.Codigo.Length > 0 && datosVentaVo.Codigo == frmBoleta.lista[index].Codigo && (datosVentaVo.ValorVenta == frmBoleta.lista[index].ValorVenta && datosVentaVo.ListaPrecio == frmBoleta.lista[index].ListaPrecio) && datosVentaVo.Bodega == frmBoleta.lista[index].Bodega && datosVentaVo.DescuentaInventario == frmBoleta.lista[index].DescuentaInventario)
              {
                flag = false;
                Calculos calculos = new Calculos();
                frmBoleta.lista[index].Cantidad = frmBoleta.lista[index].Cantidad;//datosVentaVo.Cantidad;
                frmBoleta.lista[index].PorcDescuento = new Decimal(0);
                Decimal cantidad = lista[index].Cantidad;
                Decimal valorVenta = frmBoleta.lista[index].ValorVenta;
                Decimal num2 = new Decimal(0);
                Decimal descuento = frmBoleta.lista[index].Descuento + datosVentaVo.Descuento;
                int tipoDescuento = frmBoleta.lista[index].TipoDescuento;
                this.idImpuesto = Convert.ToInt32(frmBoleta.lista[index].IdImpuesto.ToString());
                Decimal subTotal = calculos.subTotalLinea(valorVenta, cantidad);
                if (subTotal == new Decimal(0) || subTotal > descuento)
                {
                  frmBoleta.lista[index].SubTotalLinea = subTotal;
                  frmBoleta.lista[index].Descuento = descuento;
                  frmBoleta.lista[index].TotalLinea = calculos.totalLinea(subTotal, descuento);
                  if (this.idImpuesto == 0)
                    this.netoLinea = calculos.netoLinea(frmBoleta.lista[index].TotalLinea, 0);
                  if (this.idImpuesto == 1)
                    this.netoLinea = calculos.netoLinea(frmBoleta.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 2)
                    this.netoLinea = calculos.netoLinea(frmBoleta.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 3)
                    this.netoLinea = calculos.netoLinea(frmBoleta.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 4)
                    this.netoLinea = calculos.netoLinea(frmBoleta.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 5)
                    this.netoLinea = calculos.netoLinea(frmBoleta.lista[index].TotalLinea, this.idImpuesto);
                  frmBoleta.lista[index].NetoLinea = this.netoLinea;
                }
                else
                {
                  int num3 = (int) MessageBox.Show("El Descuento debe ser Menor al Total!!");
                }
                index = Enumerable.Count<DatosVentaVO>((IEnumerable<DatosVentaVO>) frmBoleta.lista);
                this.limpiaEntradaDetalle();
                this.calculaTotales();
                this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
              }
            }
            if (!flag)
            {
              frmBoleta.lista.Add(datosVentaVo);
              this.limpiaEntradaDetalle();
              this.calculaTotales();
              this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
          }
          }
          else
          {
              frmBoleta.lista.Add(datosVentaVo);
              this.limpiaEntradaDetalle();
              this.calculaTotales();
              this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
          }
        }
        else
        {
          int num4 = (int) MessageBox.Show("Se Alcanzo el Maximo de Lineas Soportadas Por este Documento");
        }
      }
    }

    public void cantidad()
    {
      this.txtCantidad.Text = "1";
    }

    private void calculaTotales()
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      bool flag5 = false;
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
      for (int index = 0; index < frmBoleta.lista.Count; ++index)
      {
        frmBoleta.lista[index].Linea = index + 1;
        if (frmBoleta.lista[index].IdImpuesto == 1)
          flag1 = true;
        if (frmBoleta.lista[index].IdImpuesto == 2)
          flag2 = true;
        if (frmBoleta.lista[index].IdImpuesto == 3)
          flag3 = true;
        if (frmBoleta.lista[index].IdImpuesto == 4)
          flag4 = true;
        if (frmBoleta.lista[index].IdImpuesto == 5)
          flag5 = true;
      }
      Calculos calculos = new Calculos();
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      ArrayList arrayList = new ArrayList();
      if (flag1 || flag2 || (flag3 || flag4) || flag5)
        arrayList = calculos.totalImpuestos(frmBoleta.lista);
      Decimal num6;
      if (flag1)
      {
        TextBox textBox = this.txtTotalImp1;
        num6 = Convert.ToDecimal(arrayList[0].ToString());
        string str = num6.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp1.Text = "";
      if (flag2)
      {
        TextBox textBox = this.txtTotalImp2;
        num6 = Convert.ToDecimal(arrayList[1].ToString());
        string str = num6.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp2.Text = "";
      if (flag3)
      {
        TextBox textBox = this.txtTotalImp3;
        num6 = Convert.ToDecimal(arrayList[2].ToString());
        string str = num6.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp3.Text = "";
      if (flag4)
      {
        TextBox textBox = this.txtTotalImp4;
        num6 = Convert.ToDecimal(arrayList[3].ToString());
        string str = num6.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp4.Text = "";
      if (flag5)
      {
        TextBox textBox = this.txtTotalImp5;
        num6 = Convert.ToDecimal(arrayList[4].ToString());
        string str = num6.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp5.Text = "";
      Decimal num7 = calculos.totalGeneralBoleta(frmBoleta.lista);
      this.txtTotalGeneral.Text = num7.ToString("N" + this.decimalesValoresVenta);
      this.txtTotalDescuento.Text = calculos.totalDescuentoBoleta(frmBoleta.lista).ToString("N" + this.decimalesValoresVenta);
      Decimal neto = calculos.totalNeto2(frmBoleta.lista);
      TextBox textBox1 = this.txtSubTotal;
      num6 = calculos.totalSubTotalBoleta(frmBoleta.lista);
      string str1 = num6.ToString("N" + this.decimalesValoresVenta);
      textBox1.Text = str1;
      this._Neto = neto.ToString("N" + this.decimalesValoresVenta);
      num6 = calculos.totalIva(neto);
      this._Iva = num6.ToString("N" + this.decimalesValoresVenta);
      this.txtNeto.Text = this._Neto.ToString();
      this.txtIva.Text = this._Iva.ToString();
      Decimal num8 = calculos.totalGeneralBoletaExento(frmBoleta.lista);
      this.txtTotalExento.Text = num8.ToString("N" + this.decimalesValoresVenta);
      this.txtTotalCobrar.Text = (num7 + num8).ToString("N" + this.decimalesValoresVenta);
    }

    private void limpiaEntradaDetalle()
    {
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Enabled = true;
      this.btnLimpiaDetalle.Enabled = true;
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this._ResumenDescripcion = string.Empty;
      this.txtPrecio.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      if (!this.chkCantidadFija.Checked)
        this.txtCantidad.Clear();
      this.txtDescuento.Clear();
      this.txtPorcDescuentoLinea.Clear();
      this.txtTotalLinea.Clear();
      this.txtCodigoRapido.Clear();
      if (this.tabControlZonaDetalle.SelectedIndex == 0)
        this.txtCodigo.Focus();
      else
        this.txtCodigoRapido.Focus();
      this.idImpuesto = 0;
      this.netoLinea = new Decimal(0);
      this.valorCompra = new Decimal(0);
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

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      try
      {
        if (frmMenuPrincipal._Pesable && this.txtCodigo.Text.Trim().Length > 0)
          this.codigoPesable(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
        else
          this.agregaLineaGrilla();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error:" + ex.Message);
      }
    }

    private void btnQuitar_Click(object sender, EventArgs e)
    {
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0)
        return;
      e.Handled = false;
      int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      if (frmMenuPrincipal._Pesable)
        this.codigoPesable(this.txtCodigo.Text.Trim(), bodega);
      else
        this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), bodega);
    }

    private void codigoPesable(string texto, int bodega)
    {
      string cod = texto;
      string str1 = "";
      if (texto.Length == 13)
        str1 = texto.Substring(0, 2);
      if (texto.Length == 13 && str1.Equals(frmMenuPrincipal._codigoPesable))
      {
        string str2 = texto.Substring(7, 5);
        this.llamaProductoCodigo(texto.Substring(2, 5), bodega);
        string str3 = "";
        if (this.txtDescripcion.Text.Trim().Length <= 0)
          return;
        this.txtDescripcionCopia.Text = this.txtDescripcion.Text;
        for (int index = 0; index < str2.Length; ++index)
        {
          if (index == 2)
            str3 += ",";
          str3 += str2[index].ToString();
        }
        this.txtCantidad.Text = str3;
        this.agregaLineaGrilla();
      }
      else
        this.llamaProductoCodigo(cod, bodega);
    }

    private void txtCodigo_Leave(object sender, EventArgs e)
    {
    }

    private void txtPrecio_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtCantidad_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtDescuento_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPrecio);
    }

    private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidad);
      if ((int) e.KeyChar != 13 || this.txtCantidad.Text.Length <= 0)
        return;
      if (this.btnAgregar.Enabled)
        this.agregaLineaGrilla();
      if (this.btnModificaLinea.Visible)
        this.modificaLinea();
    }

    private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtDescuento);
      if ((int) e.KeyChar != 13)
        return;
      if (this.btnAgregar.Enabled)
        this.agregaLineaGrilla();
      if (this.btnModificaLinea.Visible)
        this.modificaLinea();
    }

    private void btnLimpiaDetalle_Click(object sender, EventArgs e)
    {
      this.dgvDatosVenta.DataSource = (object) null;
      frmBoleta.lista.Clear();
      this.txtSubTotal.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTotalImp1.Clear();
      this.txtTotalImp2.Clear();
      this.txtTotalImp3.Clear();
      this.txtTotalImp4.Clear();
      this.txtTotalImp5.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      this._Neto = "";
      this._Iva = "";
    }

    private void chkCantidadFija_Click(object sender, EventArgs e)
    {
    }

    private void cmbVendedor_Enter(object sender, EventArgs e)
    {
    }

    private void cmbBodega_Enter(object sender, EventArgs e)
    {
      this.cargaBodega();
    }

    private void txtDigito_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtRut.Text.Length > 0)
      {
        this.buscaCliente();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar");
        this.txtRut.Focus();
      }
    }

    private void buscaCliente()
    {
      ArrayList arrayList = new ArrayList();
      ArrayList cli = new Cliente().buscaRutCliente(this.txtRut.Text.Trim());
      if (cli.Count > 1)
      {
        this.txtRazonSocial.Enabled = false;
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "boleta").ShowDialog();
      }
      else if (cli.Count == 0)
      {
        if (MessageBox.Show("No Existe Cliente Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
          new frmClientes(this.txtRut.Text.Trim(), this.txtDigito.Text.Trim()).Show();
        else
          this.iniciaVenta();
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
      this.codigoCliente = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.cmbListaPrecio.SelectedValue = (object) clienteVo.ListaPrecio;
      if (clienteVo.IdMedioPago > 0)
        this.cmbMedioPago.SelectedValue = (object) clienteVo.IdMedioPago;
      if (clienteVo.Estado == 1)
      {
        int num = (int) MessageBox.Show("Cliente BLOQUEADO por: " + clienteVo.MotivoBloqueo + "\r\nSolo podra efecturar pagos en: " + this.cmbMedioPago.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      this._Direccion = clienteVo.Direccion;
      this._Comuna = clienteVo.Comuna;
      this._Ciudad = clienteVo.Ciudad;
      this._Giro = clienteVo.Giro;
      this._Fono = clienteVo.Telefono;
      this._Fax = clienteVo.Fax;
      this._Contacto = clienteVo.Contacto;
      this._DiasPlazo = clienteVo.DiasPlazo;
      this.calculaFechaVencimiento(Convert.ToInt32(clienteVo.DiasPlazo));
      this.txtCodigo.Focus();
      if (!this.verificaCreditoActivo)
        return;
      this.verificaCredito();
    }

    private void calculaFechaVencimiento(int dias)
    {
      this.dtpVencimiento.Value = this.dtpEmision.Value.AddDays((double) dias);
    }

    private void dtpEmision_ValueChanged(object sender, EventArgs e)
    {
      this.calculaFechaVencimiento(Convert.ToInt32(this._DiasPlazo));
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "boleta").ShowDialog();
    }

    private void txtRazonSocial_TextChanged(object sender, EventArgs e)
    {
      if (this.hayComanda)
        return;
      if (this.txtRazonSocial.Text.Trim().Length > 0 && this.txtRut.Text.Trim().Length == 0)
      {
        this.pnlBuscaClienteDes.Visible = true;
        List<ClienteVO> list = new Cliente().buscaClienteDato(Convert.ToInt32(this._opcionBusquedaRazonSocial), this.txtRazonSocial.Text.Trim());
        if (list.Count > 0)
          this.dgvBuscaCliente.DataSource = (object) list;
      }
      else
        this.pnlBuscaClienteDes.Visible = false;
    }

    private void creaColumnasBuscaClientes()
    {
      this.dgvBuscaCliente.Columns.Clear();
      this.dgvBuscaCliente.AutoGenerateColumns = false;
      this.dgvBuscaCliente.Columns.Add("Codigo", "Cod.");
      this.dgvBuscaCliente.Columns[0].DataPropertyName = "Codigo";
      this.dgvBuscaCliente.Columns[0].Width = 35;
      this.dgvBuscaCliente.Columns[0].Visible = false;
      this.dgvBuscaCliente.Columns.Add("Rut", "Rut");
      this.dgvBuscaCliente.Columns[1].DataPropertyName = "Rut";
      this.dgvBuscaCliente.Columns[1].Width = 70;
      this.dgvBuscaCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaCliente.Columns.Add("Digito", "");
      this.dgvBuscaCliente.Columns[2].DataPropertyName = "Digito";
      this.dgvBuscaCliente.Columns[2].Width = 20;
      this.dgvBuscaCliente.Columns.Add("RazonSocial", "Razon Social");
      this.dgvBuscaCliente.Columns[3].DataPropertyName = "RazonSocial";
      this.dgvBuscaCliente.Columns[3].Width = 280;
      this.dgvBuscaCliente.Columns.Add("NomFantasia", "N. Fantasia");
      this.dgvBuscaCliente.Columns[4].DataPropertyName = "NomFantasia";
      this.dgvBuscaCliente.Columns[4].Width = 230;
      this.dgvBuscaCliente.Columns.Add("Direccion", "Direccion");
      this.dgvBuscaCliente.Columns[5].DataPropertyName = "Direccion";
      this.dgvBuscaCliente.Columns[5].Width = 230;
    }

    private void dgvBuscaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
    {
      if (!this.pnlBuscaClienteDes.Visible || e.KeyCode != Keys.Down)
        return;
      this.dgvBuscaCliente.Focus();
    }

    private void dgvBuscaCliente_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void txtRut_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtDigito.Focus();
    }

    private void frmFactura_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modBoleta = 0;
      this.Dispose();
    }

    private void Guarda()
    {
      bool flag = false;
      int num = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
      foreach (MedioPagoVO medioPagoVo in this.listaMediosPago)
      {
        if (num == medioPagoVo.IdMedioPago)
          flag = medioPagoVo.UsaVoucher;
      }
      if (flag)
      {
        this.panelNumeroOperacion.Visible = true;
        this.txtNumeroOperacion.Clear();
        this.txtNumeroOperacion.Focus();
      }
      else
        this.guardaBoleta();
    }
    Decimal redondea(Decimal valor)
    {
        return Decimal.Round(valor, 0);
    }
    private void guardaBoleta()
    {
      if (this.validaCampos())
      {
        DateTime dateTime1 =DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local1 = @dateTime1;
        int year1 = this.dtpEmision.Value.Year;
        int month1 = this.dtpEmision.Value.Month;
        int day1 = this.dtpEmision.Value.Day;
        TimeSpan timeOfDay1 = DateTime.Now.TimeOfDay;
        int hours1 = timeOfDay1.Hours;
        DateTime now1 = DateTime.Now;
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
        now1 = this.dtpVencimiento.Value;
        int year2 = now1.Year;
        int month2 = this.dtpVencimiento.Value.Month;
        int day2 = this.dtpVencimiento.Value.Day;
        TimeSpan timeOfDay2 = DateTime.Now.TimeOfDay;
        int hours2 = timeOfDay2.Hours;
        DateTime now2 = DateTime.Now;
        timeOfDay2 = now2.TimeOfDay;
        int minutes2 = timeOfDay2.Minutes;
        now2 = DateTime.Now;
        timeOfDay2 = now2.TimeOfDay;
        int seconds2 = timeOfDay2.Seconds;
        // ISSUE: explicit reference operation
        local2 = new DateTime(year2, month2, day2, hours2, minutes2, seconds2);
        Venta venta = new Venta();
        venta.BoletaVoucher = "BOLETA";
        venta.NumeroVoucher = "0";
        venta.Caja = this._caja;
        venta.FechaEmision = Convert.ToDateTime(dtpEmision.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.FechaVencimiento = Convert.ToDateTime(dtpVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.FechaModificacion = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.IdCliente = this.codigoCliente;
        venta.Rut = this.txtRut.Text.Trim();
        venta.Digito = this.txtDigito.Text.Trim();
        venta.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
        venta.Direccion = this._Direccion.ToUpper();
        venta.Comuna = this._Comuna.ToUpper();
        venta.Ciudad = this._Ciudad.ToUpper();
        venta.Giro = this._Giro.ToUpper();
        venta.Fono = this._Fono;
        venta.Fax = this._Fax;
        venta.Contacto = this._Contacto.ToUpper();
        venta.DiasPlazo = Convert.ToInt32(this._DiasPlazo);
        if (this.cmbMedioPago.SelectedValue.ToString() != "0")
        {
          venta.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
          venta.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
        }
        if (this.cmbVendedor.SelectedValue != null)
        {
          if (this.cmbVendedor.SelectedValue.ToString() != "0")
          {
            venta.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
            venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
            foreach (VendedorVO vendedorVo in this.listaVendedores)
            {
              if (venta.IdVendedor == vendedorVo.IdVendedor)
                venta.ComisionVendedor = vendedorVo.Comision;
            }
          }
        }
        else if (this.cmbVendedor.Text != "[SELECCIONE]")
          venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
        if (this.cmbGarzon.SelectedValue != null && this.cmbGarzon.SelectedValue.ToString() != "0")
        {
          venta.IdGarzon = Convert.ToInt32(this.cmbGarzon.SelectedValue.ToString());
          venta.Garzon = this.cmbGarzon.Text.ToString().ToUpper();
        }
        if (this.cmbCentroCosto.SelectedValue != null)
        {
          if (this.cmbCentroCosto.SelectedValue.ToString() != "0")
          {
            venta.IdCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
            venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
          }
        }
        else if (this.cmbCentroCosto.Text != "[SELECCIONE]")
          venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
        venta.OrdenCompra = this.txtOrdenCompra.Text.Trim();
        venta.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
        venta.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        venta.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
        venta.PorcentajeIva = Convert.ToDecimal(this._porcIva);
        venta.Iva = Convert.ToDecimal(this._Iva);
        venta.Neto = Convert.ToDecimal(this._Neto);
        venta.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
        venta.TotalExento = this.txtTotalExento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text.Trim()) : new Decimal(0);
        venta.TotalaCobrar = Convert.ToDecimal(this.txtTotalCobrar.Text.Trim());
        if (this.hayTicket)
        {
          venta.FolioTicket = this.veOBBoleta.Folio;
          venta.IdTicket = this.idBoleta;
        }
        else
        {
          venta.FolioTicket = 0;
          venta.IdTicket = 0;
        }
        if (this.hayComanda)
        {
          venta.FolioComanda = this.veOBBoleta.Folio;
          venta.IdComanda = this.idBoleta;
        }
        else
        {
          venta.FolioComanda = 0;
          venta.IdComanda = 0;
        }
        if (this.hayCotizacion)
        {
          venta.FolioCotizacion = this.veOBBoleta.Folio;
          venta.IdCotizacion = this.idBoleta;
        }
        else
        {
          venta.FolioCotizacion = 0;
          venta.IdCotizacion = 0;
        }
        if (this.hayNotaVenta)
        {
          venta.FolioNotaVenta = this.veOBBoleta.Folio;
          venta.IdNotaVenta = this.idBoleta;
        }
        else
        {
          venta.FolioNotaVenta = 0;
          venta.IdNotaVenta = 0;
        }
        venta.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
        venta.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
        venta.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
        venta.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
        venta.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
        NumeroaLetra numeroaLetra = new NumeroaLetra();
        venta.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
        int num1 = 0;
        foreach (MedioPagoVO medioPagoVo in this.listaMediosPago)
        {
          if (venta.IdMedioPago == medioPagoVo.IdMedioPago)
            num1 = Convert.ToInt32(medioPagoVo.Liquida);
        }
        if (num1 == 1)
        {
          venta.EstadoPago = "PAGADO";
          venta.TotalPagado = venta.Total;
          venta.TotalDocumentado = new Decimal(0);
          venta.TotalPendiente = new Decimal(0);
        }
        else
        {
          venta.EstadoPago = "PENDIENTE";
          venta.TotalPagado = new Decimal(0);
          venta.TotalDocumentado = new Decimal(0);
          venta.TotalPendiente = venta.Total;
          if (this.verificaCreditoActivo && this.codigoCliente != 0)
          {
            if (Convert.ToDecimal(this.txtCreditoDisponible.Text) < Convert.ToDecimal(this.txtTotalGeneral.Text))
            {
              if (this.impideVenta)
              {
                this.impideVentaSinCredito = true;
              }
              else
              {
                this.impideVentaSinCredito = false;
                int num2 = (int) MessageBox.Show("El Cliente No tiene Credito Disponible para la Actual Venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              }
            }
            else
              this.impideVentaSinCredito = false;
          }
          else
            this.impideVentaSinCredito = false;
        }
        if (!this.impideVentaSinCredito)
        {
          venta.EstadoDocumento = "EMITIDA";
          Boleta boleta = new Boleta();
          if (boleta.boletaExiste(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim())))
          {
              // int num2 = (int) MessageBox.Show("Ya Existe una Factura con el N°: " + this.txtNumeroDocumento.Text + " Debe Modificar el Folio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              this.txtNumeroDocumento.Enabled = false;
              Decimal aux = Decimal.Add(Convert.ToDecimal(boleta.UltimoFolio()), 1);
              this.txtNumeroDocumento.Text = aux.ToString();//se setea el folio para esta factura
              //this.txtNumeroDocumento.Focus();
              this.btnGuardar.Focus();
              this.btnGuardar.PerformClick();
              limpiar = false;//variable que genera limpiesa del formulario
          }
          else
          {
            venta.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
            for (int index = 0; index < frmBoleta.lista.Count; ++index)
            {
              frmBoleta.lista[index].FolioFactura = venta.Folio;
              frmBoleta.lista[index].FechaIngreso = venta.FechaEmision;
              frmBoleta.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
            }
            if (num1 == 1 && venta.BoletaVoucher.Equals("BOLETA"))
            {
              int num2 = (int) new frmVuelto(this.txtTotalCobrar.Text, ref this.intance, "boleta").ShowDialog();
            }
            venta.PagaCon = Convert.ToDecimal(this.lblPagaCon.Text);
            venta.Vuelto = Convert.ToDecimal(this.lblVuelto.Text);
            try
            {
              boleta.guardaBoleta(venta, frmBoleta.lista, this._listaLote);
            }
            catch (Exception ex)
            {
              int num3 = (int) MessageBox.Show("Error : " + ex.Message);
            }
            this.cambiaEstadoTicket();
            this.cambiaEstadoComanda();
            this.cambiaEstadoCotizacion();
            this.cambiaEstadoNotaVenta();
            if (num1 == 1)
            {
              PagoVenta pagoVenta = new PagoVenta();
              PagoVentaVO pvVO = new PagoVentaVO();
              pvVO.FechaCobro = venta.FechaEmision;
              pvVO.IdFormaPago = venta.IdMedioPago;
              pvVO.FormaPago = venta.MedioPago;
              pvVO.Monto = venta.Total;
              pvVO.Estado = "PAGADO";
              pvVO.TipoPago = "MP";
              int idDoc = boleta.retornaIdBoleta(venta.Folio);
              pagoVenta.agregarPagoVenta(pvVO, "BOLETA", idDoc, venta.Folio, venta.FechaEmision);
            }
            int folio = Convert.ToInt32(this.txtNumeroDocumento.Text);
            string boletaVoucher = venta.BoletaVoucher;
            if (venta.Total > new Decimal(0))
              this.imprimeBoleta(folio, venta);
            else
              this.iniciaVenta();
            limpiar = true;
            if (num1 == 0 && MessageBox.Show("¿ Desea Ingresar el detalle del Pago ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              this.pagarBoleta(folio);
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("El Cliente No tiene Credito Disponible para la Actual Venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          int num3 = (int) new frmMuestraCredito(this.codigoCliente).ShowDialog();
          limpiar = false;
        }
      }
      
      this.veOBBoleta = new Venta();
      
    }

    private void guardaVoucher()
    {
      if (this.validaCampos())
      {
        DateTime dateTime1 =DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local1 = @dateTime1;
        int year1 = this.dtpEmision.Value.Year;
        int month1 = this.dtpEmision.Value.Month;
        int day1 = this.dtpEmision.Value.Day;
        TimeSpan timeOfDay1 = DateTime.Now.TimeOfDay;
        int hours1 = timeOfDay1.Hours;
        DateTime now1 = DateTime.Now;
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
        now1 = this.dtpVencimiento.Value;
        int year2 = now1.Year;
        int month2 = this.dtpVencimiento.Value.Month;
        int day2 = this.dtpVencimiento.Value.Day;
        TimeSpan timeOfDay2 = DateTime.Now.TimeOfDay;
        int hours2 = timeOfDay2.Hours;
        DateTime now2 = DateTime.Now;
        timeOfDay2 = now2.TimeOfDay;
        int minutes2 = timeOfDay2.Minutes;
        now2 = DateTime.Now;
        timeOfDay2 = now2.TimeOfDay;
        int seconds2 = timeOfDay2.Seconds;
        // ISSUE: explicit reference operation
        local2 = new DateTime(year2, month2, day2, hours2, minutes2, seconds2);
        Venta veOB = new Venta();
        veOB.BoletaVoucher = "VOUCHER";
        veOB.NumeroVoucher = Convert.ToInt32(this.txtNumeroOperacion.Text.Trim()).ToString();
        veOB.Caja = this._caja;
        veOB.FechaEmision = dateTime1;
        veOB.FechaVencimiento = dateTime2;
        veOB.IdCliente = this.codigoCliente;
        veOB.Rut = this.txtRut.Text.Trim();
        veOB.Digito = this.txtDigito.Text.Trim();
        veOB.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
        veOB.Direccion = this._Direccion.ToUpper();
        veOB.Comuna = this._Comuna.ToUpper();
        veOB.Ciudad = this._Ciudad.ToUpper();
        veOB.Giro = this._Giro.ToUpper();
        veOB.Fono = this._Fono;
        veOB.Fax = this._Fax;
        veOB.Contacto = this._Contacto.ToUpper();
        veOB.DiasPlazo = Convert.ToInt32(this._DiasPlazo);
        if (this.cmbMedioPago.SelectedValue.ToString() != "0")
        {
          veOB.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
          veOB.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
        }
        if (this.cmbVendedor.SelectedValue != null)
        {
          if (this.cmbVendedor.SelectedValue.ToString() != "0")
          {
            veOB.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
            veOB.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
            foreach (VendedorVO vendedorVo in this.listaVendedores)
            {
              if (veOB.IdVendedor == vendedorVo.IdVendedor)
                veOB.ComisionVendedor = vendedorVo.Comision;
            }
          }
        }
        else if (this.cmbVendedor.Text != "[SELECCIONE]")
          veOB.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
        if (this.cmbGarzon.SelectedValue != null && this.cmbGarzon.SelectedValue.ToString() != "0")
        {
          veOB.IdGarzon = Convert.ToInt32(this.cmbGarzon.SelectedValue.ToString());
          veOB.Garzon = this.cmbGarzon.Text.ToString().ToUpper();
        }
        if (this.cmbCentroCosto.SelectedValue != null)
        {
          if (this.cmbCentroCosto.SelectedValue.ToString() != "0")
          {
            veOB.IdCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
            veOB.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
          }
        }
        else if (this.cmbCentroCosto.Text != "[SELECCIONE]")
          veOB.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
        veOB.OrdenCompra = this.txtOrdenCompra.Text.Trim();
        veOB.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
        veOB.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        veOB.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeIva = Convert.ToDecimal(this._porcIva);
        veOB.Iva = Convert.ToDecimal(this._Iva);
        veOB.Neto = Convert.ToDecimal(this._Neto);
        veOB.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
        veOB.TotalExento = this.txtTotalExento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text.Trim()) : new Decimal(0);
        veOB.TotalaCobrar = Convert.ToDecimal(this.txtTotalCobrar.Text.Trim());
        if (this.hayTicket)
        {
          veOB.FolioTicket = this.veOBBoleta.Folio;
          veOB.IdTicket = this.idBoleta;
        }
        else
        {
          veOB.FolioTicket = 0;
          veOB.IdTicket = 0;
        }
        if (this.hayComanda)
        {
          veOB.FolioComanda = this.veOBBoleta.Folio;
          veOB.IdComanda = this.idBoleta;
        }
        else
        {
          veOB.FolioComanda = 0;
          veOB.IdComanda = 0;
        }
        if (this.hayCotizacion)
        {
          veOB.FolioCotizacion = this.veOBBoleta.Folio;
          veOB.IdCotizacion = this.idBoleta;
        }
        else
        {
          veOB.FolioCotizacion = 0;
          veOB.IdCotizacion = 0;
        }
        if (this.hayNotaVenta)
        {
          veOB.FolioNotaVenta = this.veOBBoleta.Folio;
          veOB.IdNotaVenta = this.idBoleta;
        }
        else
        {
          veOB.FolioNotaVenta = 0;
          veOB.IdNotaVenta = 0;
        }
        veOB.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
        veOB.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
        veOB.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
        veOB.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
        veOB.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
        veOB.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
        NumeroaLetra numeroaLetra = new NumeroaLetra();
        veOB.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
        int num1 = 0;
        foreach (MedioPagoVO medioPagoVo in this.listaMediosPago)
        {
          if (veOB.IdMedioPago == medioPagoVo.IdMedioPago)
            num1 = Convert.ToInt32(medioPagoVo.Liquida);
        }
        if (num1 == 1)
        {
          veOB.EstadoPago = "PAGADO";
          veOB.TotalPagado = veOB.Total;
          veOB.TotalDocumentado = new Decimal(0);
          veOB.TotalPendiente = new Decimal(0);
        }
        else
        {
          veOB.EstadoPago = "PENDIENTE";
          veOB.TotalPagado = new Decimal(0);
          veOB.TotalDocumentado = new Decimal(0);
          veOB.TotalPendiente = veOB.Total;
          if (this.verificaCreditoActivo && this.codigoCliente != 0)
          {
            if (Convert.ToDecimal(this.txtCreditoDisponible.Text) < Convert.ToDecimal(this.txtTotalGeneral.Text))
            {
              if (this.impideVenta)
              {
                this.impideVentaSinCredito = true;
              }
              else
              {
                this.impideVentaSinCredito = false;
                int num2 = (int) MessageBox.Show("El Cliente No tiene Credito Disponible para la Actual Venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              }
            }
            else
              this.impideVentaSinCredito = false;
          }
          else
            this.impideVentaSinCredito = false;
        }
        if (!this.impideVentaSinCredito)
        {
          veOB.EstadoDocumento = "EMITIDA";
          Boleta boleta = new Boleta();
          veOB.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
          for (int index = 0; index < frmBoleta.lista.Count; ++index)
          {
            frmBoleta.lista[index].FechaIngreso = veOB.FechaEmision;
            frmBoleta.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
          }
          veOB.PagaCon = new Decimal(0);
          veOB.Vuelto = new Decimal(0);
          try
          {
            boleta.guardaBoleta(veOB, frmBoleta.lista, this._listaLote);
          }
          catch (Exception ex)
          {
            int num2 = (int) MessageBox.Show("Error : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          this.cambiaEstadoTicket();
          this.cambiaEstadoComanda();
          this.cambiaEstadoCotizacion();
          this.cambiaEstadoNotaVenta();
          PagoVenta pagoVenta = new PagoVenta();
          PagoVentaVO pvVO = new PagoVentaVO();
          pvVO.FechaCobro = veOB.FechaEmision;
          pvVO.IdFormaPago = veOB.IdMedioPago;
          pvVO.FormaPago = veOB.MedioPago;
          pvVO.Monto = veOB.Total;
          pvVO.Estado = "PAGADO";
          pvVO.TipoPago = "MP";
          pvVO.NumeroDocumento = this.txtNumeroOperacion.Text;
          int num3 = boleta.retornaIdBoleta(veOB.Folio);
          pagoVenta.agregarPagoVenta(pvVO, "VOUCHER", num3, num3, veOB.FechaEmision);
          this.iniciaVenta();
        }
        else
        {
          int num2 = (int) MessageBox.Show("El Cliente No tiene Credito Disponible para la Actual Venta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          int num3 = (int) new frmMuestraCredito(this.codigoCliente).ShowDialog();
        }
      }
      this.veOBBoleta = new Venta();
    }

    private void imprimeBoleta(int folio, Venta ve)
    {
      if (MessageBox.Show("Desea Imprimir la Boleta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        this.imprimeDirecto(ve);
      else
        this.iniciaVenta();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.Guarda();
    }

    private void guardarFacturaTeclaF2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Guarda();
    }

    private void cambiaEstadoTicket()
    {
      if (!this.hayTicket)
        return;
      Ticket ticket = new Ticket();
      string str = "BOLETA";
      this.veOBBoleta.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      Factura factura = new Factura();
      this.veOBBoleta.IDDocumentoVenta = new Boleta().retornaIdBoleta(this.veOBBoleta.FolioDocumentoVenta);
      this.veOBBoleta.DocumentoVenta = str;
      ticket.modificaTipoDocumentoTicket(this.veOBBoleta);
    }

    private void cambiaEstadoTicketEliminaBoleta()
    {
      if (!this.hayTicket)
        return;
      Ticket ticket = new Ticket();
      this.veOBBoleta.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBBoleta.IDDocumentoVenta = 0;
      this.veOBBoleta.FolioDocumentoVenta = 0;
      this.veOBBoleta.DocumentoVenta = "";
      this.veOBBoleta.IdFactura = this.veOBBoleta.IdTicket;
      this.veOBBoleta.Folio = this.veOBBoleta.FolioTicket;
      ticket.modificaTipoDocumentoTicket(this.veOBBoleta);
    }

    private void cambiaEstadoComanda()
    {
      if (!this.hayComanda)
        return;
      Comanda comanda = new Comanda();
      string str = "BOLETA";
      this.veOBBoleta.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBBoleta.IDDocumentoVenta = new Boleta().retornaIdBoleta(this.veOBBoleta.FolioDocumentoVenta);
      this.veOBBoleta.DocumentoVenta = str;
      comanda.modificaTipoDocumentoComanda(this.veOBBoleta);
      if (this._mesa != "DOMICILIO" && this._mesa != "LLEVAR")
        new Mesa().cambiaEstadoMesa(this._mesa, "DISPONIBLE", "0", "");
    }

    private void cambiaEstadoComandaEliminaBoleta()
    {
      if (!this.hayComanda)
        return;
      Comanda comanda = new Comanda();
      this.veOBBoleta.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBBoleta.IDDocumentoVenta = 0;
      this.veOBBoleta.FolioDocumentoVenta = 0;
      this.veOBBoleta.DocumentoVenta = "";
      this.veOBBoleta.IdFactura = this.veOBBoleta.IdTicket;
      this.veOBBoleta.Folio = this.veOBBoleta.FolioTicket;
      comanda.modificaTipoDocumentoComanda(this.veOBBoleta);
    }

    private void txtDescuento_Enter(object sender, EventArgs e)
    {
      if (this.txtPrecio.Text.Length > 0 && this.txtCantidad.Text.Length > 0)
      {
        this.txtTipoDescuento.Text = "2";
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos antes de hacer un Descuento");
        this.txtPrecio.Focus();
      }
    }

    private void txtPorcDescuentoLinea_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPorcDescuentoLinea);
      if ((int) e.KeyChar != 13)
        return;
      if (this.btnAgregar.Enabled)
        this.agregaLineaGrilla();
      if (this.btnModificaLinea.Visible)
        this.modificaLinea();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Modificar la Boleta ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (!this.validaCampos())
          return;
        DateTime dateTime1 =DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local1 = @dateTime1;
        DateTime now = this.dtpEmision.Value;
        int year1 = now.Year;
        now = this.dtpEmision.Value;
        int month1 = now.Month;
        now = this.dtpEmision.Value;
        int day1 = now.Day;
        now = DateTime.Now;
        int hours1 = now.TimeOfDay.Hours;
        now = DateTime.Now;
        int minutes1 = now.TimeOfDay.Minutes;
        now = DateTime.Now;
        int seconds1 = now.TimeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local1 = new DateTime(year1, month1, day1, hours1, minutes1, seconds1);
        DateTime dateTime2=DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local2 = @dateTime2;
        now = this.dtpVencimiento.Value;
        int year2 = now.Year;
        now = this.dtpVencimiento.Value;
        int month2 = now.Month;
        now = this.dtpVencimiento.Value;
        int day2 = now.Day;
        now = DateTime.Now;
        int hours2 = now.TimeOfDay.Hours;
        now = DateTime.Now;
        int minutes2 = now.TimeOfDay.Minutes;
        now = DateTime.Now;
        int seconds2 = now.TimeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local2 = new DateTime(year2, month2, day2, hours2, minutes2, seconds2);
        Venta venta = new Venta();
        venta.IdFactura = this.idBoleta;
        venta.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        venta.NumeroVoucher = this.txtNumeroVoucher.Text;
        venta.FechaEmision = Convert.ToDateTime(dtpEmision.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.FechaVencimiento = Convert.ToDateTime(dtpVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.FechaModificacion = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        venta.Caja = this._caja;
        venta.IdCliente = this.codigoCliente;
        venta.Rut = this.txtRut.Text.Trim();
        venta.Digito = this.txtDigito.Text.Trim();
        venta.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
        venta.Direccion = this._Direccion.ToUpper();
        venta.Comuna = this._Comuna.ToUpper();
        venta.Ciudad = this._Ciudad.ToUpper();
        venta.Giro = this._Giro.ToUpper();
        venta.Fono = this._Fono;
        venta.Fax = this._Fax;
        venta.Contacto = this._Contacto.ToUpper();
        venta.DiasPlazo = Convert.ToInt32(this._DiasPlazo);
        if (this.cmbMedioPago.SelectedValue.ToString() != "0")
        {
          venta.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
          venta.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
        }
        if (this.cmbVendedor.SelectedValue != null)
        {
          if (this.cmbVendedor.SelectedValue.ToString() != "0")
          {
            venta.IdVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
            venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
            foreach (VendedorVO vendedorVo in this.listaVendedores)
            {
              if (venta.IdVendedor == vendedorVo.IdVendedor)
                venta.ComisionVendedor = vendedorVo.Comision;
            }
          }
          else if (this.cmbVendedor.Text != "[SELECCIONE]")
            venta.Vendedor = this.cmbVendedor.Text.ToString().ToUpper();
        }
        if (this.cmbGarzon.SelectedValue != null && this.cmbGarzon.SelectedValue.ToString() != "0")
        {
          venta.IdGarzon = Convert.ToInt32(this.cmbGarzon.SelectedValue.ToString());
          venta.Garzon = this.cmbGarzon.Text.ToString().ToUpper();
        }
        if (this.cmbCentroCosto.SelectedValue != null)
        {
          if (this.cmbCentroCosto.SelectedValue.ToString() != "0")
          {
            venta.IdCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
            venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
          }
          else if (this.cmbCentroCosto.Text != "[SELECCIONE]")
            venta.CentroCosto = this.cmbCentroCosto.Text.ToString().ToUpper();
        }
        venta.OrdenCompra = this.txtOrdenCompra.Text.Trim();
        venta.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
        venta.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        venta.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
        venta.PorcentajeIva = Convert.ToDecimal(this._porcIva);
        venta.Iva = Convert.ToDecimal(this._Iva);
        venta.Neto = Convert.ToDecimal(this._Neto);
        venta.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
        venta.TotalExento = this.txtTotalExento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text.Trim()) : new Decimal(0);
        venta.TotalaCobrar = Convert.ToDecimal(this.txtTotalCobrar.Text.Trim());
        NumeroaLetra numeroaLetra = new NumeroaLetra();
        venta.TotalPalabras = numeroaLetra.enletras(this.txtTotalGeneral.Text.Trim());
        venta.Impuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto1 = this.txtTotalImp1.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp1.Text.Trim()) : new Decimal(0);
        venta.Impuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto2 = this.txtTotalImp2.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp2.Text.Trim()) : new Decimal(0);
        venta.Impuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto3 = this.txtTotalImp3.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp3.Text.Trim()) : new Decimal(0);
        venta.Impuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto4 = this.txtTotalImp4.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp4.Text.Trim()) : new Decimal(0);
        venta.Impuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text.Trim()) : new Decimal(0);
        venta.PorcentajeImpuesto5 = this.txtTotalImp5.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorImp5.Text.Trim()) : new Decimal(0);
        int num1 = 0;
        foreach (MedioPagoVO medioPagoVo in this.listaMediosPago)
        {
          if (venta.IdMedioPago == medioPagoVo.IdMedioPago)
            num1 = Convert.ToInt32(medioPagoVo.Liquida);
        }
        PagoVentaVO pagoVentaVo;
        if (venta.Total != this.veOBBoleta.Total)
        {
          if (num1 == 1)
          {
            venta.EstadoPago = "PAGADO";
            venta.TotalPagado = venta.Total;
            venta.TotalDocumentado = new Decimal(0);
            venta.TotalPendiente = new Decimal(0);
            PagoVenta pagoVenta = new PagoVenta();
            PagoVentaVO pvVO = new PagoVentaVO();
            if (this.veOBBoleta.BoletaVoucher.Equals("BOLETA"))
              pagoVenta.eliminaPagoVenta("BOLETA", this.idBoleta, venta.Folio);
            else
              pagoVenta.eliminaPagoVenta("VOUCHER", this.idBoleta, this.idBoleta);
            pvVO.FechaCobro = venta.FechaEmision;
            pvVO.IdFormaPago = venta.IdMedioPago;
            pvVO.FormaPago = venta.MedioPago;
            pvVO.Monto = venta.Total;
            pvVO.Estado = "PAGADO";
            pvVO.NumeroDocumento = this.txtNumeroVoucher.Text;
            if (this.veOBBoleta.BoletaVoucher.Equals("BOLETA"))
              pagoVenta.agregarPagoVenta(pvVO, "BOLETA", this.idBoleta, venta.Folio, venta.FechaEmision);
            else
              pagoVenta.agregarPagoVenta(pvVO, "VOUCHER", this.idBoleta, this.idBoleta, venta.FechaEmision);
          }
          else
          {
            venta.EstadoPago = "PENDIENTE";
            venta.TotalPagado = new Decimal(0);
            venta.TotalDocumentado = new Decimal(0);
            venta.TotalPendiente = venta.Total;
            PagoVenta pagoVenta = new PagoVenta();
            pagoVentaVo = new PagoVentaVO();
            if (this.veOBBoleta.BoletaVoucher.Equals("BOLETA"))
              pagoVenta.eliminaPagoVenta("BOLETA", this.idBoleta, venta.Folio);
            else
              pagoVenta.eliminaPagoVenta("VOUCHER", this.idBoleta, this.idBoleta);
          }
        }
        else if (Convert.ToInt32(this.cmbMedioPago.SelectedValue) == this.veOBBoleta.IdMedioPago)
        {
          venta.EstadoPago = this.veOBBoleta.EstadoPago;
          venta.TotalPagado = this.veOBBoleta.TotalPagado;
          venta.TotalDocumentado = this.veOBBoleta.TotalDocumentado;
          venta.TotalPendiente = this.veOBBoleta.TotalPendiente;
        }
        else if (num1 == 1)
        {
          venta.EstadoPago = "PAGADO";
          venta.TotalPagado = venta.Total;
          venta.TotalDocumentado = new Decimal(0);
          venta.TotalPendiente = new Decimal(0);
          PagoVenta pagoVenta = new PagoVenta();
          PagoVentaVO pvVO = new PagoVentaVO();
          if (this.veOBBoleta.BoletaVoucher.Equals("BOLETA"))
            pagoVenta.eliminaPagoVenta("BOLETA", this.idBoleta, venta.Folio);
          else
            pagoVenta.eliminaPagoVenta("VOUCHER", this.idBoleta, this.idBoleta);
          pvVO.FechaCobro = venta.FechaEmision;
          pvVO.IdFormaPago = venta.IdMedioPago;
          pvVO.FormaPago = venta.MedioPago;
          pvVO.Monto = venta.Total;
          pvVO.Estado = "PAGADO";
          pvVO.NumeroDocumento = this.txtNumeroVoucher.Text;
          if (this.veOBBoleta.BoletaVoucher.Equals("BOLETA"))
            pagoVenta.agregarPagoVenta(pvVO, "BOLETA", this.idBoleta, venta.Folio, venta.FechaEmision);
          else
            pagoVenta.agregarPagoVenta(pvVO, "VOUCHER", this.idBoleta, this.idBoleta, venta.FechaEmision);
        }
        else
        {
          venta.EstadoPago = "PENDIENTE";
          venta.TotalPagado = new Decimal(0);
          venta.TotalDocumentado = new Decimal(0);
          venta.TotalPendiente = venta.Total;
          PagoVenta pagoVenta = new PagoVenta();
          pagoVentaVo = new PagoVentaVO();
          if (this.veOBBoleta.BoletaVoucher.Equals("BOLETA"))
            pagoVenta.eliminaPagoVenta("BOLETA", this.idBoleta, venta.Folio);
          else
            pagoVenta.eliminaPagoVenta("VOUCHER", this.idBoleta, this.idBoleta);
        }
        Boleta boleta = new Boleta();
        for (int index = 0; index < frmBoleta.lista.Count; ++index)
        {
          frmBoleta.lista[index].FechaIngreso = venta.FechaEmision;
          frmBoleta.lista[index].IdFactura = this.idBoleta;
          frmBoleta.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }
        int num2 = (int) MessageBox.Show(boleta.modificaBoleta(venta, frmBoleta.lista, this._listaLote, this._listaLoteAntigua), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        if (this.veOBBoleta.BoletaVoucher.Equals("BOLETA"))
        {
          if (venta.Total > new Decimal(0))
            this.imprimeBoleta(venta.Folio, venta);
          else
            this.iniciaVenta();
        }
        else
          this.iniciaVenta();
      }
      else
      {
        int num = (int) MessageBox.Show("La Boleta NO fue Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
      }
    }

    private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Tab)
        return;
      this.txtPorcDescuentoLinea.Focus();
    }

    private void txtPorcDescuentoLinea_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Right)
        return;
      this.txtDescuento.Focus();
    }

    private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void cmbMedioPago_Enter(object sender, EventArgs e)
    {
    }

    private bool validaCampos()
    {
      if (this.cmbMedioPago.SelectedValue == null || this.cmbMedioPago.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona el Medio de Pago");
        this.cmbMedioPago.Focus();
        return false;
      }
      if (frmBoleta.lista.Count == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos a Boleta");
        this.txtCodigo.Focus();
        return false;
      }
      if (!(Convert.ToDecimal(this.txtTotalCobrar.Text) <= new Decimal(0)))
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Datos a Boleta");
      this.txtCodigo.Focus();
      return false;
    }

    private void txtTotalDescuento_TextChanged(object sender, EventArgs e)
    {
      if (this.txtTotalDescuento.ReadOnly)
        return;
      Decimal num1 = new Decimal(0);
      bool flag = false;
      for (int index = 0; index < frmBoleta.lista.Count; ++index)
      {
        if (frmBoleta.lista[index].Descuento > new Decimal(0) || frmBoleta.lista[index].PorcDescuento > new Decimal(0))
        {
          flag = true;
          num1 += frmBoleta.lista[index].Descuento;
        }
      }
      if (flag && !this.txtTotalDescuento.ReadOnly)
      {
        if (MessageBox.Show("¿Hay Descuentos aplicados en la lista, Desea Eliminarlos e Ingresar un Descuento General?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          for (int index = 0; index < frmBoleta.lista.Count; ++index)
          {
            frmBoleta.lista[index].Descuento = new Decimal(0);
            frmBoleta.lista[index].PorcDescuento = new Decimal(0);
            frmBoleta.lista[index].TotalLinea = frmBoleta.lista[index].ValorVenta * frmBoleta.lista[index].Cantidad;
          }
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
          this.calculaTotales();
        }
        else
        {
          this.txtTotalDescuento.ReadOnly = true;
          this.txtTotalDescuento.Text = num1.ToString("N0");
        }
      }
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new Calculos().totalDescuentoGeneral(this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0), this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0));
      if (arrayList2.Count > 1)
      {
        Decimal num2 = Convert.ToDecimal(arrayList2[0].ToString());
        Decimal num3 = Convert.ToDecimal(arrayList2[1].ToString());
        Decimal num4 = Convert.ToDecimal(arrayList2[2].ToString());
        this._Neto = num2.ToString("N" + this.decimalesValoresVenta);
        this._Iva = num3.ToString("N" + this.decimalesValoresVenta);
        this.txtTotalGeneral.Text = num4.ToString("N" + this.decimalesValoresVenta);
      }
      else
      {
        int num2 = (int) MessageBox.Show("El Descuento NO debe ser Mayor al SubTotal");
        this.txtTotalDescuento.Text = "0";
        this.txtPorcDescuentoTotal.Clear();
      }
      if (txtTotalDescuento.Text.Length != 0)
      {
         txtTotalDescuento.Text= redondea(Convert.ToDecimal(txtTotalDescuento.Text)).ToString("N0");
      }
    }

    private void txtTotalDescuento_DoubleClick(object sender, EventArgs e)
    {
      if (!((this.txtTotalImp1.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text) : new Decimal(0)) + (this.txtTotalImp2.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text) : new Decimal(0)) + (this.txtTotalImp3.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text) : new Decimal(0)) + (this.txtTotalImp4.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text) : new Decimal(0)) + (this.txtTotalImp5.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text) : new Decimal(0)) == new Decimal(0)))
        return;
      this.txtTotalDescuento.ReadOnly = false;
    }

    private void txtTotalDescuento_Leave(object sender, EventArgs e)
    {
      this.txtTotalDescuento.ReadOnly = true;
    }

    private void txtPorcDescuentoTotal_TextChanged(object sender, EventArgs e)
    {
      if (this.txtPorcDescuentoTotal.Text.Length > 0)
      {
        Calculos calculos = new Calculos();
        Decimal porcDesc = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        Decimal subtotal = this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0);
        Decimal num = calculos.porcentajeDescuento(subtotal, porcDesc);
        this.txtTotalDescuento.ReadOnly = false;
        this.txtTotalDescuento.Text = num.ToString("N0");
        this.txtTotalDescuento.ReadOnly = true;
      }
      else
      {
        this.txtTotalDescuento.ReadOnly = false;
        this.txtTotalDescuento.Clear();
        this.txtTotalDescuento.ReadOnly = true;
      }
    }

    private void btnModificaLinea_Click(object sender, EventArgs e)
    {
      this.modificaLinea();
    }

    private void modificaLinea()
    {
      if (this.comparaStock(Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()), Convert.ToDecimal(this.txtCantidad.Text.Trim().Length > 0 ? this.txtCantidad.Text : "0"), this.txtCodigo.Text.Trim()))
      {
        for (int index = 0; index < frmBoleta.lista.Count; ++index)
        {
          if (frmBoleta.lista[index].Linea == Convert.ToInt32(this.txtLinea.Text))
          {
            frmBoleta.lista[index].Codigo = this.txtCodigo.Text;
            frmBoleta.lista[index].Descripcion = this.txtDescripcion.Text;
            frmBoleta.lista[index].ValorVenta = this.txtPrecio.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
            frmBoleta.lista[index].Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
            frmBoleta.lista[index].TotalLinea = this.txtTotalLinea.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
            frmBoleta.lista[index].Descuento = this.txtDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
            frmBoleta.lista[index].PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
            frmBoleta.lista[index].IdImpuesto = this.idImpuesto;
            frmBoleta.lista[index].NetoLinea = this.netoLinea;
          }
        }
        this.dgvDatosVenta.DataSource = (object) null;
        this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
        this.calculaTotales();
        this.limpiaEntradaDetalle();
      }
      else
      {
        int num = (int) MessageBox.Show("No Hay stock Suficiente", "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private bool comparaStock(int bodega, Decimal stockCompara, string cod)
    {
      if (this.impideVentasSinStock.Equals("1"))
      {
        for (int index = 0; index < this.listaAuxiliar.Count; ++index)
        {
          if (bodega == 1 && this.listaAuxiliar[index].Bodega1 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 2 && this.listaAuxiliar[index].Bodega2 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 3 && this.listaAuxiliar[index].Bodega3 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 4 && this.listaAuxiliar[index].Bodega4 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)) || (bodega == 5 && this.listaAuxiliar[index].Bodega5 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 6 && this.listaAuxiliar[index].Bodega6 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 7 && this.listaAuxiliar[index].Bodega7 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 8 && this.listaAuxiliar[index].Bodega8 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod))) || (bodega == 9 && this.listaAuxiliar[index].Bodega9 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 10 && this.listaAuxiliar[index].Bodega10 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 11 && this.listaAuxiliar[index].Bodega11 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 12 && this.listaAuxiliar[index].Bodega12 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)) || (bodega == 13 && this.listaAuxiliar[index].Bodega13 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 14 && this.listaAuxiliar[index].Bodega14 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 15 && this.listaAuxiliar[index].Bodega15 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 16 && this.listaAuxiliar[index].Bodega16 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)))) || (bodega == 17 && this.listaAuxiliar[index].Bodega17 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 18 && this.listaAuxiliar[index].Bodega18 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 19 && this.listaAuxiliar[index].Bodega19 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 20 && this.listaAuxiliar[index].Bodega20 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod))))
            return false;
        }
      }
      return true;
    }

    private void btnLimpiaLineaDetalle_Click(object sender, EventArgs e)
    {
      this.limpiaEntradaDetalle();
    }

    private void txtPorcDescuentoLinea_Enter(object sender, EventArgs e)
    {
      if (this.txtPrecio.Text.Length > 0 && this.txtCantidad.Text.Length > 0)
      {
        this.txtTipoDescuento.Text = "1";
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Datos antes de hacer un Descuento");
        this.txtPrecio.Focus();
      }
    }

    private void frmFactura_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F4)
      {
        this.txtCodigo.Focus();
        int num = (int) new frmBuscaProductos("boleta", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
        this.txtPrecio.Focus();
      }
      if (e.KeyCode == Keys.F6)
      {
        this.panelFolio.Visible = true;
        this.txtFolioBuscar.Focus();
      }
      if (e.KeyCode == Keys.F2 && this.btnGuardar.Enabled && this._guarda)
        this.Guarda();
      if (e.KeyCode != Keys.F5)
        return;
      int num1 = (int) new frmVuelto(this.txtTotalCobrar.Text, ref this.intance, "boleta").ShowDialog();
    }

    private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //this.txtCodigo.Focus();
      int num = (int) new frmBuscaProductos("boleta", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
      this.txtPrecio.Focus();
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

    private void dgvDatosVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (frmBoleta.lista.Count <= 0)
        return;
      this.btnModificaLinea.Visible = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiaDetalle.Enabled = false;
      this.chkCantidadFija.Checked = false;
      this.txtCodigo.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Codigo"].Value.ToString();
      this.txtDescripcion.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Descripcion"].Value.ToString();
      this.txtPrecio.Text = Convert.ToDecimal(this.dgvDatosVenta.SelectedRows[0].Cells["ValorVenta"].Value.ToString()).ToString("N" + this.decimalesValoresVenta);
      this.txtCantidad.Text = this.verificaDecimales(this.dgvDatosVenta.SelectedRows[0].Cells["Cantidad"].Value.ToString());
      this.txtDescuento.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Descuento"].Value.ToString();
      this.txtPorcDescuentoLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["PorcDescuento"].Value.ToString();
      this.txtSubTotalLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["SubTotal"].Value.ToString();
      this.txtTipoDescuento.Text = this.dgvDatosVenta.SelectedRows[0].Cells["TipoDescuento"].Value.ToString();
      this.txtLinea.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Linea"].Value.ToString();
      this.cmbListaPrecio.SelectedValue = (object) this.dgvDatosVenta.SelectedRows[0].Cells["ListaPrecio"].Value.ToString();
      this.cmbBodega.SelectedValue = (object) this.dgvDatosVenta.SelectedRows[0].Cells["Bodega"].Value.ToString();
      this.idImpuesto = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells["IdImpuesto"].Value.ToString());
      this.netoLinea = Convert.ToDecimal(this.dgvDatosVenta.SelectedRows[0].Cells["NetoLinea"].Value.ToString());
      this.tabControlZonaDetalle.SelectedIndex = 0;
    }

    private void cmbListaPrecio_SelectedValueChanged(object sender, EventArgs e)
    {
      if (!this.btnModificaLinea.Visible)
        return;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
    }

    private void cmbMedioPago_SelectedValueChanged(object sender, EventArgs e)
    {
    }

    private void txtNumeroDocumento_DoubleClick(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
    }

    private void lblFolio_DoubleClick(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Focus();
    }

    private void buscaBoletaFolio()
    {
      this.panelFolio.Visible = false;
      Boleta boleta = new Boleta();
      try
      {
        Venta venta = boleta.buscaBoletaFolio(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
        this.veOBBoleta = venta;
        if (venta.IdFactura != 0)
        {
          this.iniciaVenta();
          this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = false;
          this.idBoleta = venta.IdFactura;
          if (venta.IdTicket > 0)
          {
            this.hayTicket = true;
            this.txtTicket.Text = venta.FolioTicket.ToString();
            this.idTicket = venta.IdTicket;
          }
          if (venta.IdComanda > 0)
          {
            this.hayComanda = true;
            this.txtComanda.Text = venta.FolioComanda.ToString();
            this.idComanda = venta.IdComanda;
          }
          if (venta.IdCotizacion > 0)
            this.hayCotizacion = true;
          if (venta.IdNotaVenta > 0)
            this.hayNotaVenta = true;
          DateTimePicker dateTimePicker1 = this.dtpEmision;
          DateTime dateTime1 = venta.FechaEmision;
          DateTime dateTime2 = Convert.ToDateTime(dateTime1.ToString());
          dateTimePicker1.Value = dateTime2;
          DateTimePicker dateTimePicker2 = this.dtpVencimiento;
          dateTime1 = venta.FechaVencimiento;
          DateTime dateTime3 = Convert.ToDateTime(dateTime1.ToString());
          dateTimePicker2.Value = dateTime3;
          if (venta.IdMedioPago != 0)
          {
            this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
            this.cmbMedioPago.Text = venta.MedioPago.ToString();
          }
          if (venta.IdVendedor != 0)
          {
            this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          }
          else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          if (venta.IdGarzon != 0)
          {
            this.cmbGarzon.SelectedValue = (object) venta.IdGarzon.ToString();
            this.cmbGarzon.Text = venta.Garzon.ToString();
          }
          else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
            this.cmbGarzon.Text = venta.Garzon.ToString();
          if (venta.IdCentroCosto != 0)
          {
            this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          }
          else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          this.txtNumeroVoucher.Text = venta.NumeroVoucher;
          this.txtNumeroVoucher.Text = venta.NumeroVoucher;
          if (venta.NumeroVoucher.Length > 0)
            this.txtNumeroVoucher.ReadOnly = true;
          else
            this.txtNumeroVoucher.ReadOnly = false;
          this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
          this.txtNumeroDocumento.Text = venta.Folio.ToString();
          this.codigoCliente = venta.IdCliente;
          this.verificaCredito();
          this.txtRut.Text = venta.Rut;
          this.txtDigito.Text = venta.Digito;
          this.txtRazonSocial.Text = venta.RazonSocial.ToString();
          this._Direccion = venta.Direccion.ToString();
          this._Comuna = venta.Comuna.ToString();
          this._Ciudad = venta.Ciudad.ToString();
          this._Giro = venta.Giro.ToString();
          this._Fono = venta.Fono.ToString();
          this._Fax = venta.Fax.ToString();
          this._Contacto = venta.Contacto.ToString();
          this._DiasPlazo = venta.DiasPlazo.ToString();
          this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
          TextBox textBox1 = this.txtPorcDescuentoTotal;
          Decimal num = venta.PorcentajeDescuento;
          string str1 = num.ToString("N0");
          textBox1.Text = str1;
          TextBox textBox2 = this.txtTotalDescuento;
          num = venta.Descuento;
          string str2 = num.ToString("N" + this.decimalesValoresVenta);
          textBox2.Text = str2;
          num = venta.Neto;
          this._Neto = num.ToString("N" + this.decimalesValoresVenta);
          num = venta.Iva;
          this._Iva = num.ToString("N0");
          num = venta.PorcentajeIva;
          this._porcIva = num.ToString("N0");
          TextBox textBox3 = this.txtTotalGeneral;
          num = venta.Total;
          string str3 = num.ToString("N" + this.decimalesValoresVenta);
          textBox3.Text = str3;
          TextBox textBox4 = this.txtTotalExento;
          num = venta.TotalExento;
          string str4 = num.ToString("N" + this.decimalesValoresVenta);
          textBox4.Text = str4;
          TextBox textBox5 = this.txtTotalCobrar;
          num = venta.TotalaCobrar;
          string str5 = num.ToString("N" + this.decimalesValoresVenta);
          textBox5.Text = str5;
          TextBox textBox6 = this.txtTotalImp1;
          num = venta.Impuesto1;
          string str6;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto1;
            str6 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str6 = "";
          textBox6.Text = str6;
          TextBox textBox7 = this.txtTotalImp2;
          num = venta.Impuesto2;
          string str7;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto2;
            str7 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str7 = "";
          textBox7.Text = str7;
          TextBox textBox8 = this.txtTotalImp3;
          num = venta.Impuesto3;
          string str8;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto3;
            str8 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str8 = "";
          textBox8.Text = str8;
          TextBox textBox9 = this.txtTotalImp4;
          num = venta.Impuesto4;
          string str9;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto4;
            str9 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str9 = "";
          textBox9.Text = str9;
          TextBox textBox10 = this.txtTotalImp5;
          num = venta.Impuesto5;
          string str10;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto5;
            str10 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str10 = "";
          textBox10.Text = str10;
          this.panelVuelto.Visible = true;
          Label label1 = this.lblPagaCon;
          num = venta.PagaCon;
          string str11 = num.ToString("N0");
          label1.Text = str11;
          Label label2 = this.lblVuelto;
          num = venta.Vuelto;
          string str12 = num.ToString("N0");
          label2.Text = str12;
          this.btnGuardar.Enabled = false;
          this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
          if (venta.EstadoDocumento.Equals("ANULADA"))
          {
            this.btnAnular.Enabled = false;
            this.btnImprime.Enabled = false;
            if (this._elimina)
              this.btnEliminar.Enabled = true;
          }
          else
          {
            if (this._anula)
              this.btnAnular.Enabled = true;
            if (this._modifica)
              this.btnModificar.Enabled = true;
            this.btnImprime.Enabled = true;
            this.btnControlPago.Enabled = true;
          }
          this.lblEstadoDocumento.Text = venta.EstadoDocumento.ToString();
          frmBoleta.lista = boleta.buscaDetalleBoletaIDBoleta(venta.IdFactura);
          this.cmbBodega.SelectedValue = (object) frmBoleta.lista[0].Bodega;
          for (int index = 0; index < frmBoleta.lista.Count; ++index)
            frmBoleta.lista[index].Linea = index + 1;
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
          this._listaLote.Clear();
          this._listaLote = new Lote().ListaLotePorDocumento("VENTA", "BOLETA", venta.IdFactura);
          this._listaLoteAntigua.Clear();
          if (this._listaLote.Count > 0)
          {
            foreach (LoteVO loteVo in this._listaLote)
              this._listaLoteAntigua.Add(loteVo);
          }
          this.txtFolioBuscar.Clear();
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe Boleta Consultada!!");
          this.txtFolioBuscar.Clear();
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error : " + ex.Message);
      }
    }

    public void buscaBoletaID(int id)
    {
      this.panelFolio.Visible = false;
      Boleta boleta = new Boleta();
      try
      {
        Venta venta = boleta.buscaBoletaID(id);
        this.veOBBoleta = venta;
        if (venta.IdFactura != 0)
        {
          this.iniciaVenta();
          this.idBoleta = venta.IdFactura;
          this.dtpEmision.Value = Convert.ToDateTime(venta.FechaEmision.ToString());
          this.dtpVencimiento.Value = Convert.ToDateTime(venta.FechaVencimiento.ToString());
          if (venta.IdMedioPago != 0)
          {
            this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
            this.cmbMedioPago.Text = venta.MedioPago.ToString();
          }
          if (venta.IdVendedor != 0)
          {
            this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          }
          else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          if (venta.IdGarzon != 0)
          {
            this.cmbGarzon.SelectedValue = (object) venta.IdGarzon.ToString();
            this.cmbGarzon.Text = venta.Garzon.ToString();
          }
          else if (venta.IdGarzon == 0 && venta.Garzon.Length > 0)
            this.cmbGarzon.Text = venta.Garzon.ToString();
          if (venta.IdCentroCosto != 0)
          {
            this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          }
          else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          this.txtNumeroVoucher.Text = venta.NumeroVoucher;
          if (venta.NumeroVoucher.Length > 0)
            this.txtNumeroVoucher.ReadOnly = true;
          else
            this.txtNumeroVoucher.ReadOnly = false;
          this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
          TextBox textBox1 = this.txtNumeroDocumento;
          int num1 = venta.Folio;
          string str1 = num1.ToString();
          textBox1.Text = str1;
          this.codigoCliente = venta.IdCliente;
          this.txtRut.Text = venta.Rut;
          this.txtDigito.Text = venta.Digito;
          this.txtRazonSocial.Text = venta.RazonSocial.ToString();
          this._Direccion = venta.Direccion.ToString();
          this._Comuna = venta.Comuna.ToString();
          this._Ciudad = venta.Ciudad.ToString();
          this._Giro = venta.Giro.ToString();
          this._Fono = venta.Fono.ToString();
          this._Fax = venta.Fax.ToString();
          this._Contacto = venta.Contacto.ToString();
          num1 = venta.DiasPlazo;
          this._DiasPlazo = num1.ToString();
          this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
          this.txtPorcDescuentoTotal.Text = venta.PorcentajeDescuento.ToString("N0");
          TextBox textBox2 = this.txtTotalDescuento;
          Decimal num2 = venta.Descuento;
          string str2 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox2.Text = str2;
          num2 = venta.Neto;
          this._Neto = num2.ToString("N" + this.decimalesValoresVenta);
          num2 = venta.Iva;
          this._Iva = num2.ToString("N" + this.decimalesValoresVenta);
          num2 = venta.PorcentajeIva;
          this._porcIva = num2.ToString("N0");
          TextBox textBox3 = this.txtTotalGeneral;
          num2 = venta.Total;
          string str3 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox3.Text = str3;
          TextBox textBox4 = this.txtTotalExento;
          num2 = venta.TotalExento;
          string str4 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox4.Text = str4;
          TextBox textBox5 = this.txtTotalCobrar;
          num2 = venta.TotalaCobrar;
          string str5 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox5.Text = str5;
          TextBox textBox6 = this.txtTotalImp1;
          num2 = venta.Impuesto1;
          string str6;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto1;
            str6 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str6 = "";
          textBox6.Text = str6;
          TextBox textBox7 = this.txtTotalImp2;
          num2 = venta.Impuesto2;
          string str7;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto2;
            str7 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str7 = "";
          textBox7.Text = str7;
          TextBox textBox8 = this.txtTotalImp3;
          num2 = venta.Impuesto3;
          string str8;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto3;
            str8 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str8 = "";
          textBox8.Text = str8;
          TextBox textBox9 = this.txtTotalImp4;
          num2 = venta.Impuesto4;
          string str9;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto4;
            str9 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str9 = "";
          textBox9.Text = str9;
          TextBox textBox10 = this.txtTotalImp5;
          num2 = venta.Impuesto5;
          string str10;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto5;
            str10 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str10 = "";
          textBox10.Text = str10;
          this.panelVuelto.Visible = true;
          Label label1 = this.lblPagaCon;
          num2 = venta.PagaCon;
          string str11 = num2.ToString("N0");
          label1.Text = str11;
          Label label2 = this.lblVuelto;
          num2 = venta.Vuelto;
          string str12 = num2.ToString("N0");
          label2.Text = str12;
          if (venta.IdTicket > 0)
          {
            this.hayTicket = true;
            TextBox textBox11 = this.txtTicket;
            num1 = venta.FolioTicket;
            string str13 = num1.ToString();
            textBox11.Text = str13;
            this.idTicket = venta.IdTicket;
          }
          if (venta.IdComanda > 0)
          {
            this.hayComanda = true;
            TextBox textBox11 = this.txtComanda;
            num1 = venta.FolioComanda;
            string str13 = num1.ToString();
            textBox11.Text = str13;
            this.idComanda = venta.IdComanda;
          }
          this.btnGuardar.Enabled = false;
          this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
          if (venta.EstadoDocumento.Equals("ANULADA"))
          {
            this.btnAnular.Enabled = false;
            this.btnImprime.Enabled = false;
            if (this._elimina)
              this.btnEliminar.Enabled = true;
          }
          else
          {
            if (this._anula)
              this.btnAnular.Enabled = true;
            if (this._modifica)
              this.btnModificar.Enabled = true;
            this.btnImprime.Enabled = true;
            this.btnControlPago.Enabled = true;
          }
          this.lblEstadoDocumento.Text = venta.EstadoDocumento.ToString();
          frmBoleta.lista = boleta.buscaDetalleBoletaIDBoleta(venta.IdFactura);
          this.cmbBodega.SelectedValue = (object) frmBoleta.lista[0].Bodega;
          for (int index = 0; index < frmBoleta.lista.Count; ++index)
            frmBoleta.lista[index].Linea = index + 1;
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
          this.txtFolioBuscar.Clear();
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe Boleta Consultada!!");
          this.txtFolioBuscar.Clear();
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error : " + ex.Message);
      }
    }

    private void btnBuscaFolio_Click(object sender, EventArgs e)
    {
      if (this.txtFolioBuscar.Text.Trim().Length > 0)
      {
        this.buscaBoletaFolio();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Folio a Buscar");
        this.txtFolioBuscar.Focus();
      }
    }

    private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPorcDescuentoLinea);
      if ((int) e.KeyChar != 13)
        return;
      this.buscaBoletaFolio();
    }

    private void btnCerrarPanelFolio_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = false;
      this.txtFolioBuscar.Clear();
    }

    private void buscarFacturaTeclaF6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Focus();
    }

    private void btnAnular_Click(object sender, EventArgs e)
    {
      if (this.lblEstadoDocumento.Text.Equals("EMITIDA"))
      {
        if (MessageBox.Show("Esta seguro de Anular esta Boleta. Los productos seran retornados a Bodega", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          Boleta boleta = new Boleta();
          try
          {
            PagoVenta pagoVenta = new PagoVenta();
            if (this.veOBBoleta.BoletaVoucher.Equals("BOLETA"))
              pagoVenta.eliminaPagoVenta("BOLETA", this.idBoleta, Convert.ToInt32(this.txtNumeroDocumento.Text));
            else
              pagoVenta.eliminaPagoVenta("VOUCHER", this.idBoleta, this.idBoleta);
            string text = boleta.anulaBoleta(this.idBoleta, frmBoleta.lista, this._listaLoteAntigua);
            if (this.hayTicket)
              this.cambiaEstadoTicketEliminaBoleta();
            if (this.hayComanda)
              this.cambiaEstadoComandaEliminaBoleta();
            if (this.hayCotizacion)
              this.cambiaEstadoCotizacionEliminaBoleta();
            if (this.hayNotaVenta)
              this.cambiaEstadoNotaVentaEliminaBoleta();
            int num = (int) MessageBox.Show(text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaVenta();
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show("Error al Anular Documento " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
        {
          int num = (int) MessageBox.Show("La Boleta NO fue Anulada..", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Este Documento ya Se encuentra Anulado!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (!this.lblEstadoDocumento.Text.Equals("ANULADA"))
        return;
      if (MessageBox.Show("Esta seguro de Eliminar esta Boleta.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        Boleta boleta = new Boleta();
        try
        {
          boleta.eliminaBoleta(this.idBoleta);
          int num = (int) MessageBox.Show("Boleta Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar Documento " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Boleta NO fue Eliminada ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
      }
    }

    private void btnImprime_Click(object sender, EventArgs e)
    {
      this.imprimeDirecto(this.veOBBoleta);
    }

    private void imprimeDirecto(Venta ve)
    {
      try
      {
        if (frmMenuPrincipal._MultiEmpresa)
          this.multiEmpresa();
        else
          this.monoEmpresa(ve);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void multiEmpresa()
    {
      DataTable dataTable = new Boleta().muestraBoletaFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
      LeeXml leeXml = new LeeXml();
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = leeXml.cargarDatosMultiEmpresa("boleta");
      string str1 = arrayList2[0].ToString();
      string str2 = arrayList2[1].ToString();
      ReportDocument reportDocument = new ReportDocument();
      reportDocument.Load("C:\\AptuSoft\\reportes\\Boleta_" + str2 + ".rpt");
      reportDocument.SetDataSource(dataTable);
      reportDocument.PrintOptions.PrinterName = str1;
      reportDocument.PrintToPrinter(1, false, 1, 1);
      reportDocument.Close();
      this.iniciaVenta();
    }

    private void monoEmpresa(Venta ve)
    {
      Convert.ToInt32(this.txtNumeroDocumento.Text);
      Boleta boleta = new Boleta();
      DataTable dataTable = this.creaDataTableBoleta(ve);
      ReportDocument reportDocument = new ReportDocument();
      reportDocument.Load("C:\\AptuSoft\\reportes\\Boleta.rpt");
      reportDocument.SetDataSource(dataTable);
      string str = new LeeXml().cargarDatos("boleta");
      reportDocument.PrintOptions.PrinterName = str;
      reportDocument.PrintToPrinter(1, false, 0, 0);
      reportDocument.Close();
      this.iniciaVenta();
    }

    private DataTable creaDataTableBoleta(Venta ve)
    {
      DataTable dataTable = new DataTable("Boleta");
      dataTable.Columns.Add("tipoDocumentoVenta");
      dataTable.Columns.Add("idBoleta");
      dataTable.Columns.Add("folio");
      dataTable.Columns.Add("fechaEmision");
      dataTable.Columns.Add("fechaVencimiento");
      dataTable.Columns.Add("dia");
      dataTable.Columns.Add("mes");
      dataTable.Columns.Add("ano");
      dataTable.Columns.Add("idCliente");
      dataTable.Columns.Add("rut");
      dataTable.Columns.Add("digito");
      dataTable.Columns.Add("razonSocial");
      dataTable.Columns.Add("direccion");
      dataTable.Columns.Add("comuna");
      dataTable.Columns.Add("ciudad");
      dataTable.Columns.Add("giro");
      dataTable.Columns.Add("fono");
      dataTable.Columns.Add("fax");
      dataTable.Columns.Add("contacto");
      dataTable.Columns.Add("diasPlazo");
      dataTable.Columns.Add("idMedioPago");
      dataTable.Columns.Add("medioPago");
      dataTable.Columns.Add("idVendedor");
      dataTable.Columns.Add("vendedor");
      dataTable.Columns.Add("idCentroCosto");
      dataTable.Columns.Add("centroCosto");
      dataTable.Columns.Add("ordenCompra");
      dataTable.Columns.Add("subtotal");
      dataTable.Columns.Add("porcentajeDescuento");
      dataTable.Columns.Add("descuento");
      dataTable.Columns.Add("porcentajeIva");
      dataTable.Columns.Add("iva");
      dataTable.Columns.Add("neto");
      dataTable.Columns.Add("total");
      dataTable.Columns.Add("totalExento");
      dataTable.Columns.Add("totalaCobrar");
      dataTable.Columns.Add("totalPalabras");
      dataTable.Columns.Add("estadoPago");
      dataTable.Columns.Add("estadoDocumento");
      dataTable.Columns.Add("totalPagado");
      dataTable.Columns.Add("totalDocumentado");
      dataTable.Columns.Add("totalPendiente");
      dataTable.Columns.Add("pagaCon");
      dataTable.Columns.Add("vuelto");
      dataTable.Columns.Add("impuesto1");
      dataTable.Columns.Add("impuesto2");
      dataTable.Columns.Add("impuesto3");
      dataTable.Columns.Add("impuesto4");
      dataTable.Columns.Add("impuesto5");
      dataTable.Columns.Add("porcentajeImpuesto1");
      dataTable.Columns.Add("porcentajeImpuesto2");
      dataTable.Columns.Add("porcentajeImpuesto3");
      dataTable.Columns.Add("porcentajeImpuesto4");
      dataTable.Columns.Add("porcentajeImpuesto5");
      dataTable.Columns.Add("comisionVendedor");
      dataTable.Columns.Add("idTicket");
      dataTable.Columns.Add("folioTicket");
      dataTable.Columns.Add("caja");
      dataTable.Columns.Add("idCotizacion");
      dataTable.Columns.Add("folioCotizacion");
      dataTable.Columns.Add("idNotaVenta");
      dataTable.Columns.Add("folioNotaVenta");
      dataTable.Columns.Add("idComanda");
      dataTable.Columns.Add("folioComanda");
      dataTable.Columns.Add("idGarzon");
      dataTable.Columns.Add("garzon");
      dataTable.Columns.Add("idDetalleboleta");
      dataTable.Columns.Add("idBoletaLinea");
      dataTable.Columns.Add("folioBoleta");
      dataTable.Columns.Add("fechaIngreso");
      dataTable.Columns.Add("codigo");
      dataTable.Columns.Add("descripcion");
      dataTable.Columns.Add("valorVenta");
      dataTable.Columns.Add("cantidad");
      dataTable.Columns.Add("porcentajeDescuentoLinea");
      dataTable.Columns.Add("descuentoLinea");
      dataTable.Columns.Add("subtotalLinea");
      dataTable.Columns.Add("totalLinea");
      dataTable.Columns.Add("tipoDescuento");
      dataTable.Columns.Add("listaPrecio");
      dataTable.Columns.Add("bodega");
      dataTable.Columns.Add("exento");
      dataTable.Columns.Add("idImpuesto");
      dataTable.Columns.Add("netoLinea");
      dataTable.Columns.Add("valorCompra");
      foreach (DatosVentaVO datosVentaVo in frmBoleta.lista)
      {
        DataRow row = dataTable.NewRow();
        row["tipoDocumentoVenta"] = (object) "BOLETA";
        row["idBoleta"] = (object) ve.IdFactura;
        row["folio"] = (object) ve.Folio;
        row["fechaEmision"] = (object) ve.FechaEmision;
        row["fechaVencimiento"] = (object) ve.FechaVencimiento;
        row["dia"] = (object) ve.Dia;
        row["mes"] = (object) ve.Mes;
        row["ano"] = (object) ve.Ano;
        row["idCliente"] = (object) ve.IdCliente;
        row["rut"] = (object) ve.Rut;
        row["digito"] = (object) ve.Digito;
        row["razonSocial"] = (object) ve.RazonSocial;
        row["direccion"] = (object) ve.Direccion;
        row["comuna"] = (object) ve.Comuna;
        row["ciudad"] = (object) ve.Ciudad;
        row["giro"] = (object) ve.Giro;
        row["fono"] = (object) ve.Fono;
        row["fax"] = (object) ve.Fax;
        row["contacto"] = (object) ve.Contacto;
        row["diasPlazo"] = (object) ve.DiasPlazo;
        row["idMedioPago"] = (object) ve.IdMedioPago;
        row["medioPago"] = (object) ve.MedioPago;
        row["idVendedor"] = (object) ve.IdVendedor;
        row["vendedor"] = (object) ve.Vendedor;
        row["idCentroCosto"] = (object) ve.IdCentroCosto;
        row["centroCosto"] = (object) ve.CentroCosto;
        row["ordenCompra"] = (object) ve.OrdenCompra;
        row["subtotal"] = (object) ve.SubTotal;
        row["porcentajeDescuento"] = (object) ve.PorcentajeDescuento;
        row["descuento"] = (object) ve.Descuento;
        row["porcentajeIva"] = (object) ve.PorcentajeIva;
        row["iva"] = (object) ve.Iva;
        row["neto"] = (object) ve.Neto;
        row["total"] = (object) ve.Total;
        row["totalExento"] = (object) ve.TotalExento;
        row["totalaCobrar"] = (object) ve.TotalaCobrar;
        row["totalPalabras"] = (object) ve.TotalPalabras;
        row["estadoPago"] = (object) ve.EstadoPago;
        row["estadoDocumento"] = (object) ve.EstadoDocumento;
        row["totalPagado"] = (object) ve.TotalPagado;
        row["totalDocumentado"] = (object) ve.TotalDocumentado;
        row["totalPendiente"] = (object) ve.TotalPendiente;
        row["pagaCon"] = (object) ve.PagaCon;
        row["vuelto"] = (object) ve.Vuelto;
        row["impuesto1"] = (object) ve.Impuesto1;
        row["impuesto2"] = (object) ve.Impuesto2;
        row["impuesto3"] = (object) ve.Impuesto3;
        row["impuesto4"] = (object) ve.Impuesto4;
        row["impuesto5"] = (object) ve.Impuesto5;
        row["porcentajeImpuesto1"] = (object) ve.PorcentajeImpuesto1;
        row["porcentajeImpuesto2"] = (object) ve.PorcentajeImpuesto2;
        row["porcentajeImpuesto3"] = (object) ve.PorcentajeImpuesto3;
        row["porcentajeImpuesto4"] = (object) ve.PorcentajeImpuesto4;
        row["porcentajeImpuesto5"] = (object) ve.PorcentajeImpuesto5;
        row["comisionVendedor"] = (object) ve.ComisionVendedor;
        row["idTicket"] = (object) ve.IdTicket;
        row["folioTicket"] = (object) ve.FolioTicket;
        row["caja"] = (object) ve.Caja;
        row["idCotizacion"] = (object) ve.IdCotizacion;
        row["folioCotizacion"] = (object) ve.FolioCotizacion;
        row["idNotaVenta"] = (object) ve.IdNotaVenta;
        row["folioNotaVenta"] = (object) ve.FolioNotaVenta;
        row["idComanda"] = (object) ve.IdComanda;
        row["folioComanda"] = (object) ve.FolioComanda;
        row["idGarzon"] = (object) ve.IdGarzon;
        row["garzon"] = (object) ve.Garzon;
        row["idDetalleboleta"] = (object) datosVentaVo.IdDetalle;
        row["idBoletaLinea"] = (object) datosVentaVo.IdFactura;
        row["folioBoleta"] = (object) datosVentaVo.FolioFactura;
        row["fechaIngreso"] = (object) datosVentaVo.FechaIngreso;
        row["codigo"] = (object) datosVentaVo.Codigo;
        row["descripcion"] = (object) datosVentaVo.Descripcion;
        row["valorVenta"] = (object) datosVentaVo.ValorVenta;
        row["cantidad"] = (object) datosVentaVo.Cantidad;
        row["porcentajeDescuentoLinea"] = (object) datosVentaVo.PorcDescuento;
        row["descuentoLinea"] = (object) datosVentaVo.Descuento;
        row["subtotalLinea"] = (object) datosVentaVo.SubTotalLinea;
        row["totalLinea"] = (object) datosVentaVo.TotalLinea;
        row["tipoDescuento"] = (object) datosVentaVo.TipoDescuento;
        row["listaPrecio"] = (object) datosVentaVo.ListaPrecio;
        row["bodega"] = (object) datosVentaVo.Bodega;
        row["exento"] = (datosVentaVo.Exento ? 1 : 0);
        row["idImpuesto"] = (object) datosVentaVo.IdImpuesto;
        row["netoLinea"] = (object) datosVentaVo.NetoLinea;
        row["valorCompra"] = (object) datosVentaVo.ValorCompra;
        dataTable.Rows.Add(row);
      }
      return dataTable;
    }

    private void txtTotalDescuento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtTotalDescuento);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(this.veOBBoleta.RazonSocial);
    }

    private void btnControlPago_Click(object sender, EventArgs e)
    {
      int folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      if (folio > 0)
      {
        this.pagarBoleta(folio);
      }
      else
      {
        int num = (int) new frmPagoVenta(ref this.intance, "VOUCHER", Convert.ToInt32(this.txtNumeroVoucher.Text.Trim())).ShowDialog();
        this.iniciaVenta();
      }
    }

    private void pagarBoleta(int folio)
    {
      int num = (int) new frmPagoVenta(ref this.intance, "BOLETA", folio).ShowDialog();
      this.iniciaVenta();
    }

    private void dgvDatosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Eliminar" && MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        int num = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells[0].Value.ToString());
        string str = "";
        for (int index = 0; index < frmBoleta.lista.Count; ++index)
        {
          if (frmBoleta.lista[index].Linea == num)
          {
            str = frmBoleta.lista[index].Codigo;
            frmBoleta.lista.RemoveAt(index);
            --index;
          }
        }
        this.calculaTotales();
        if (this._listaLote.Count > 0)
        {
          for (int index = 0; index < this._listaLote.Count; ++index)
          {
            if (this._listaLote[index].CodigoProducto == str)
            {
              this._listaLote.RemoveAt(index);
              --index;
            }
          }
        }
      }
      if (!(this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Lote"))
        return;
      string descrip = this.dgvDatosVenta.SelectedRows[0].Cells["descripcion"].Value.ToString();
      string str1 = this.dgvDatosVenta.SelectedRows[0].Cells["cantidad"].Value.ToString();
      string cod = this.dgvDatosVenta.SelectedRows[0].Cells["codigo"].Value.ToString();
      int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue);
      string text = this.cmbBodega.Text;
      Decimal cant = Convert.ToDecimal(str1);
      int num1 = (int) new frmLoteCompraVenta(cod, descrip, cant, bodega, text, this._listaLote, ref this.intance).ShowDialog();
    }

    private void txtDescripcion_Enter(object sender, EventArgs e)
    {
      if (this.txtCodigo.Text.Length <= 0 || this.txtDescripcion.Text.Length != 0)
        return;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
      this.txtCodigo.Focus();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void cambiarNumeroDeFolioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.txtNumeroDocumento.Enabled = true;
      this.txtNumeroDocumento.Focus();
    }

    private void txtTicket_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtTicket);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtTicket.Text.Length > 0)
        this.buscaTicketFolio();
    }

    private void buscaTicketFolio()
    {
      this.panelFolio.Visible = false;
      Ticket ticket = new Ticket();
      int numTicket = Convert.ToInt32(this.txtTicket.Text.Trim());
      Venta venta = ticket.buscaTicketFolio(numTicket);
      this.veOBBoleta = venta;
      if (venta.IdFactura != 0)
      {
        if (venta.IDDocumentoVenta == 0)
        {
          this.iniciaVenta();
          this.txtTicket.Text = numTicket.ToString();
          this.idBoleta = venta.IdFactura;
          this.dtpEmision.Value = Convert.ToDateTime(venta.FechaEmision.ToString());
          this.dtpVencimiento.Value = Convert.ToDateTime(venta.FechaVencimiento.ToString());
          if (venta.IdMedioPago != 0)
          {
            this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
            this.cmbMedioPago.Text = venta.MedioPago.ToString();
          }
          if (venta.IdVendedor != 0)
          {
            this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          }
          else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          if (venta.IdCentroCosto != 0)
          {
            this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          }
          else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
          this.codigoCliente = venta.IdCliente;
          this.verificaCredito();
          this.txtRut.Text = venta.Rut;
          this.txtDigito.Text = venta.Digito;
          this.txtRazonSocial.Text = venta.RazonSocial.ToString();
          this._Direccion = venta.Direccion.ToString();
          this._Comuna = venta.Comuna.ToString();
          this._Ciudad = venta.Ciudad.ToString();
          this._Giro = venta.Giro.ToString();
          this._Fono = venta.Fono.ToString();
          this._Fax = venta.Fax.ToString();
          this._Contacto = venta.Contacto.ToString();
          this._DiasPlazo = venta.DiasPlazo.ToString();
          TextBox textBox1 = this.txtSubTotal;
          Decimal num = venta.SubTotal;
          string str1 = num.ToString("N" + this.decimalesValoresVenta);
          textBox1.Text = str1;
          TextBox textBox2 = this.txtTotalDescuento;
          num = venta.Descuento;
          string str2 = num.ToString("N" + this.decimalesValoresVenta);
          textBox2.Text = str2;
          TextBox textBox3 = this.txtPorcDescuentoTotal;
          num = venta.PorcentajeDescuento;
          string str3 = num.ToString("N0");
          textBox3.Text = str3;
          num = venta.Neto;
          this._Neto = num.ToString("N" + this.decimalesValoresVenta);
          num = venta.Iva;
          this._Iva = num.ToString("N" + this.decimalesValoresVenta);
          num = venta.PorcentajeIva;
          this._porcIva = num.ToString("N0");
          TextBox textBox4 = this.txtTotalGeneral;
          num = venta.Total;
          string str4 = num.ToString("N" + this.decimalesValoresVenta);
          textBox4.Text = str4;
          TextBox textBox5 = this.txtTotalImp1;
          num = venta.Impuesto1;
          string str5;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto1;
            str5 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str5 = "";
          textBox5.Text = str5;
          TextBox textBox6 = this.txtTotalImp2;
          num = venta.Impuesto2;
          string str6;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto2;
            str6 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str6 = "";
          textBox6.Text = str6;
          TextBox textBox7 = this.txtTotalImp3;
          num = venta.Impuesto3;
          string str7;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto3;
            str7 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str7 = "";
          textBox7.Text = str7;
          TextBox textBox8 = this.txtTotalImp4;
          num = venta.Impuesto4;
          string str8;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto4;
            str8 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str8 = "";
          textBox8.Text = str8;
          TextBox textBox9 = this.txtTotalImp5;
          num = venta.Impuesto5;
          string str9;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto5;
            str9 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str9 = "";
          textBox9.Text = str9;
          this.hayTicket = true;
          frmBoleta.lista = ticket.buscaDetalleTicketIDTicket(venta.IdFactura);
          for (int index = 0; index < frmBoleta.lista.Count; ++index)
          {
            frmBoleta.lista[index].Linea = index + 1;
            frmBoleta.lista[index].FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
            frmBoleta.lista[index].IdFactura = 0;
            frmBoleta.lista[index].DescuentaInventario = true;
          }
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
          this._listaLote.Clear();
          this._listaLote = new Lote().ListaLotePorDocumento("VENTA", "TICKET", venta.IdFactura);
          this._listaLoteAntigua.Clear();
          if (this._listaLote.Count <= 0)
            return;
          foreach (LoteVO loteVo in this._listaLote)
            this._listaLoteAntigua.Add(loteVo);
        }
        else
        {
          int num1 = (int) MessageBox.Show(string.Concat(new object[4]
          {
            (object) "Ticket ya Documentado en: ",
            (object) venta.DocumentoVenta,
            (object) " Folio N°: ",
            (object) venta.FolioDocumentoVenta
          }));
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("No Existe Ticket Consultado!!");
        this.iniciaVenta();
        this.txtTicket.Focus();
      }
    }

    private void buscaComandaFolio(int numComanda)
    {
      this.panelFolio.Visible = false;
      Comanda comanda = new Comanda();
      Venta venta = comanda.buscaComandaFolio(numComanda);
      this.veOBBoleta = venta;
      if (venta.IdFactura != 0)
      {
        if (venta.IDDocumentoVenta == 0)
        {
          this.iniciaVenta();
          this.hayComanda = true;
          this.txtComanda.Text = numComanda.ToString();
          this.idBoleta = venta.IdFactura;
          DateTimePicker dateTimePicker1 = this.dtpEmision;
          DateTime fechaEmision = venta.FechaEmision;
          DateTime dateTime1 = Convert.ToDateTime(fechaEmision.ToString());
          dateTimePicker1.Value = dateTime1;
          DateTimePicker dateTimePicker2 = this.dtpVencimiento;
          fechaEmision = venta.FechaEmision;
          DateTime dateTime2 = Convert.ToDateTime(fechaEmision.ToString());
          dateTimePicker2.Value = dateTime2;
          if (venta.IdVendedor != 0)
          {
            this.cmbGarzon.SelectedValue = (object) venta.IdVendedor.ToString();
            this.cmbGarzon.Text = venta.Vendedor.ToString();
          }
          else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
            this.cmbGarzon.Text = venta.Vendedor.ToString();
          this.codigoCliente = venta.IdCliente;
          this.verificaCredito();
          this.txtRut.Text = venta.Rut;
          this.txtDigito.Text = venta.Digito;
          this.txtRazonSocial.Text = venta.RazonSocial.ToString();
          this._Direccion = venta.Direccion.ToString();
          this._Comuna = venta.Comuna.ToString();
          this._Ciudad = venta.Ciudad.ToString();
          this._Giro = venta.Giro.ToString();
          this._Fono = venta.Fono.ToString();
          this._Fax = venta.Fax.ToString();
          this._Contacto = venta.Contacto.ToString();
          this._DiasPlazo = venta.DiasPlazo.ToString();
          this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
          TextBox textBox1 = this.txtTotalDescuento;
          Decimal num = venta.Descuento;
          string str1 = num.ToString("N" + this.decimalesValoresVenta);
          textBox1.Text = str1;
          TextBox textBox2 = this.txtPorcDescuentoTotal;
          num = venta.PorcentajeDescuento;
          string str2 = num.ToString("N0");
          textBox2.Text = str2;
          num = venta.Neto;
          this._Neto = num.ToString("N" + this.decimalesValoresVenta);
          num = venta.Iva;
          this._Iva = num.ToString("N" + this.decimalesValoresVenta);
          num = venta.PorcentajeIva;
          this._porcIva = num.ToString("N0");
          TextBox textBox3 = this.txtTotalGeneral;
          num = venta.Total;
          string str3 = num.ToString("N" + this.decimalesValoresVenta);
          textBox3.Text = str3;
          TextBox textBox4 = this.txtTotalImp1;
          num = venta.Impuesto1;
          string str4;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto1;
            str4 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str4 = "";
          textBox4.Text = str4;
          TextBox textBox5 = this.txtTotalImp2;
          num = venta.Impuesto2;
          string str5;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto2;
            str5 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str5 = "";
          textBox5.Text = str5;
          TextBox textBox6 = this.txtTotalImp3;
          num = venta.Impuesto3;
          string str6;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto3;
            str6 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str6 = "";
          textBox6.Text = str6;
          TextBox textBox7 = this.txtTotalImp4;
          num = venta.Impuesto4;
          string str7;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto4;
            str7 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str7 = "";
          textBox7.Text = str7;
          TextBox textBox8 = this.txtTotalImp5;
          num = venta.Impuesto5;
          string str8;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto5;
            str8 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str8 = "";
          textBox8.Text = str8;
          this._mesa = venta.Mesa;
          frmBoleta.lista = comanda.buscaDetalleComandaIDComanda(venta.IdFactura);
          for (int index = 0; index < frmBoleta.lista.Count; ++index)
          {
            frmBoleta.lista[index].Linea = index + 1;
            frmBoleta.lista[index].FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
            frmBoleta.lista[index].IdFactura = 0;
            frmBoleta.lista[index].DescuentaInventario = false;
          }
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
        }
        else
        {
          int num1 = (int) MessageBox.Show(string.Concat(new object[4]
          {
            (object) "Comanda ya Documentado en: ",
            (object) venta.DocumentoVenta,
            (object) " Folio N°: ",
            (object) venta.FolioDocumentoVenta
          }), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("No Existe Comanda Consultada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
        this.txtComanda.Focus();
      }
    }

    private void chkMedioPagoFijo_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cmbMedioPago.SelectedValue == null || this.cmbMedioPago.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona el Medio de Pago");
        this.cmbMedioPago.Focus();
        this.chkMedioPagoFijo.Checked = false;
      }
      else if (this.chkMedioPagoFijo.Checked)
        this.cmbMedioPago.Enabled = false;
      else
        this.cmbMedioPago.Enabled = true;
    }

    private void chkVendedorFijo_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cmbVendedor.SelectedValue == null || this.cmbVendedor.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona un Vendedor");
        this.cmbVendedor.Focus();
        this.chkVendedorFijo.Checked = false;
      }
      else if (this.chkVendedorFijo.Checked)
        this.cmbVendedor.Enabled = false;
      else
        this.cmbVendedor.Enabled = true;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.veOBBoleta = new Venta();
      this.iniciaVenta();
    }

    private void txtTotalGeneral_TextChanged(object sender, EventArgs e)
    {
      if (this.txtTotalGeneral.Text.Length <= 0)
        return;
      this.txtTotalCobrar.Text = (Convert.ToDecimal(this.txtTotalGeneral.Text) + (this.txtTotalExento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalExento.Text) : new Decimal(0))).ToString("N0");
      if (txtTotalGeneral.Text.Length != 0)
      {
          txtTotalGeneral.Text = redondea(Convert.ToDecimal(txtTotalGeneral.Text)).ToString("N0");
      }
    }

    private void txtPorcDescuentoTotal_DoubleClick(object sender, EventArgs e)
    {
      if (!((this.txtTotalImp1.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp1.Text) : new Decimal(0)) + (this.txtTotalImp2.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp2.Text) : new Decimal(0)) + (this.txtTotalImp3.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp3.Text) : new Decimal(0)) + (this.txtTotalImp4.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp4.Text) : new Decimal(0)) + (this.txtTotalImp5.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalImp5.Text) : new Decimal(0)) == new Decimal(0)))
        return;
      this.txtPorcDescuentoTotal.ReadOnly = false;
    }

    public void muestraVuelto(string paga, string vuelto)
    {
      this.lblPagaCon.Text = paga;
      this.lblVuelto.Text = vuelto;
      this.panelVuelto.Visible = true;
    }

    private void calculaVueltoTeclaF5ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmVuelto(this.txtTotalCobrar.Text, ref this.intance, "boleta").ShowDialog();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
    }

    private void listarBoletasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmListaDocumentosVenta(this._caja, ref this.intance).ShowDialog();
    }

    private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.pnlCotizacionBuscar.Visible = true;
      this.txtFolioCotizacion.Focus();
    }

    private void txtFolioCotizacion_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioCotizacion);
      if ((int) e.KeyChar != 13)
        return;
      this.buscaCotizacionFolio();
    }

    private void btnSalirBuscaCoti_Click(object sender, EventArgs e)
    {
      this.pnlCotizacionBuscar.Visible = false;
    }

    private void btnBuscaCotizacion_Click(object sender, EventArgs e)
    {
      if (this.txtFolioCotizacion.Text.Trim().Length > 0)
      {
        this.buscaCotizacionFolio();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Un Folio a Buscar");
        this.txtFolioCotizacion.Focus();
      }
    }

    private void buscaCotizacionFolio()
    {
      this.panelFolio.Visible = false;
      Cotizacion cotizacion = new Cotizacion();
      int numCotizacion = Convert.ToInt32(this.txtFolioCotizacion.Text.Trim());
      try
      {
        Venta venta = cotizacion.buscaCotizacionFolio(numCotizacion);
        this.veOBBoleta = venta;
        if (venta.IdFactura != 0)
        {
          if (venta.IDDocumentoVenta == 0)
          {
            this.iniciaVenta();
            this.idBoleta = venta.IdFactura;
            DateTimePicker dateTimePicker1 = this.dtpEmision;
            DateTime dateTime1 = venta.FechaEmision;
            DateTime dateTime2 = Convert.ToDateTime(dateTime1.ToString());
            dateTimePicker1.Value = dateTime2;
            DateTimePicker dateTimePicker2 = this.dtpVencimiento;
            dateTime1 = venta.FechaVencimiento;
            DateTime dateTime3 = Convert.ToDateTime(dateTime1.ToString());
            dateTimePicker2.Value = dateTime3;
            if (venta.IdMedioPago != 0)
            {
              this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
              this.cmbMedioPago.Text = venta.MedioPago.ToString();
            }
            if (venta.IdVendedor != 0)
            {
              this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            }
            else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            if (venta.IdCentroCosto != 0)
            {
              this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            }
            else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
            this.codigoCliente = venta.IdCliente;
            this.verificaCredito();
            this.txtRut.Text = venta.Rut;
            this.txtDigito.Text = venta.Digito;
            this.txtRazonSocial.Text = venta.RazonSocial.ToString();
            this._Direccion = venta.Direccion.ToString();
            this._Comuna = venta.Comuna.ToString();
            this._Ciudad = venta.Ciudad.ToString();
            this._Giro = venta.Giro.ToString();
            this._Fono = venta.Fono.ToString();
            this._Fax = venta.Fax.ToString();
            this._Contacto = venta.Contacto.ToString();
            this._DiasPlazo = venta.DiasPlazo.ToString();
            this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
            TextBox textBox1 = this.txtPorcDescuentoTotal;
            Decimal num = venta.PorcentajeDescuento;
            string str1 = num.ToString("N0");
            textBox1.Text = str1;
            TextBox textBox2 = this.txtTotalDescuento;
            num = venta.Descuento;
            string str2 = num.ToString("N" + this.decimalesValoresVenta);
            textBox2.Text = str2;
            TextBox textBox3 = this.txtNeto;
            num = venta.Neto;
            string str3 = num.ToString("N" + this.decimalesValoresVenta);
            textBox3.Text = str3;
            TextBox textBox4 = this.txtIva;
            num = venta.Iva;
            string str4 = num.ToString("N" + this.decimalesValoresVenta);
            textBox4.Text = str4;
            num = venta.PorcentajeIva;
            this._porcIva = num.ToString("N0");
            TextBox textBox5 = this.txtTotalGeneral;
            num = venta.Total;
            string str5 = num.ToString("N" + this.decimalesValoresVenta);
            textBox5.Text = str5;
            TextBox textBox6 = this.txtTotalImp1;
            num = venta.Impuesto1;
            string str6;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto1;
              str6 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str6 = "";
            textBox6.Text = str6;
            TextBox textBox7 = this.txtTotalImp2;
            num = venta.Impuesto2;
            string str7;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto2;
              str7 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str7 = "";
            textBox7.Text = str7;
            TextBox textBox8 = this.txtTotalImp3;
            num = venta.Impuesto3;
            string str8;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto3;
              str8 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str8 = "";
            textBox8.Text = str8;
            TextBox textBox9 = this.txtTotalImp4;
            num = venta.Impuesto4;
            string str9;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto4;
              str9 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str9 = "";
            textBox9.Text = str9;
            TextBox textBox10 = this.txtTotalImp5;
            num = venta.Impuesto5;
            string str10;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto5;
              str10 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str10 = "";
            textBox10.Text = str10;
            this.hayCotizacion = true;
            frmBoleta.lista = cotizacion.buscaDetalleCotizacionIDCotizacion(venta.IdFactura);
            for (int index = 0; index < frmBoleta.lista.Count; ++index)
            {
              frmBoleta.lista[index].Linea = index + 1;
              frmBoleta.lista[index].FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
              frmBoleta.lista[index].IdFactura = 0;
              frmBoleta.lista[index].DescuentaInventario = true;
            }
            this.dgvDatosVenta.DataSource = (object) null;
            this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
          }
          else
          {
            int num1 = (int) MessageBox.Show(string.Concat(new object[4]
            {
              "Cotizacion ya Documentada en: ",
               venta.DocumentoVenta.ToString(),
               " Folio N°: ",
               venta.FolioDocumentoVenta.ToString()
            }));
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("No Existe la Cotización Consultada!!");
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al llamar Cotización " + ex.Message);
      }
    }

    private void cambiaEstadoCotizacion()
    {
      if (!this.hayCotizacion)
        return;
      Cotizacion cotizacion = new Cotizacion();
      string str = "BOLETA";
      this.veOBBoleta.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBBoleta.IDDocumentoVenta = new Boleta().retornaIdBoleta(this.veOBBoleta.FolioDocumentoVenta);
      this.veOBBoleta.DocumentoVenta = str;
      cotizacion.modificaTipoDocumentoCotizacion(this.veOBBoleta);
    }

    private void cambiaEstadoCotizacionEliminaBoleta()
    {
      if (!this.hayCotizacion)
        return;
      Cotizacion cotizacion = new Cotizacion();
      this.veOBBoleta.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBBoleta.IDDocumentoVenta = 0;
      this.veOBBoleta.FolioDocumentoVenta = 0;
      this.veOBBoleta.DocumentoVenta = "";
      this.veOBBoleta.IdFactura = this.veOBBoleta.IdCotizacion;
      this.veOBBoleta.Folio = this.veOBBoleta.FolioCotizacion;
      cotizacion.modificaTipoDocumentoCotizacion(this.veOBBoleta);
    }

    private void agregaDevolucionGrilla(string descripcion, Decimal valor)
    {
      frmBoleta.lista.Add(new DatosVentaVO()
      {
        Codigo = "",
        Descripcion = descripcion.ToUpper(),
        IdImpuesto = 0,
        NetoLinea = new Decimal(0),
        ValorCompra = new Decimal(0),
        ValorVenta = valor,
        Cantidad = new Decimal(1),
        Descuento = new Decimal(0),
        PorcDescuento = new Decimal(0),
        TotalLinea = valor,
        SubTotalLinea = new Decimal(0),
        TipoDescuento = 0,
        ListaPrecio = 1,
        Bodega = 1,
        FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim()),
        Exento = false
      });
      this.limpiaEntradaDetalle();
      this.calculaTotales();
    }

    private void btnCierraNota_Click(object sender, EventArgs e)
    {
      this.panelNotaVenta.Visible = false;
    }

    private void notaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.panelNotaVenta.Visible = true;
      this.txtFolioNotaVenta.Clear();
      this.txtFolioNotaVenta.Focus();
    }

    private void btnBuscaNotaventa_Click(object sender, EventArgs e)
    {
      if (this.txtFolioNotaVenta.Text.Trim().Length > 0)
      {
        this.buscaNotaVentaFolio();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Un Folio a Buscar");
        this.txtFolioNotaVenta.Focus();
      }
    }

    private void buscaNotaVentaFolio()
    {
      NotaVenta notaVenta = new NotaVenta();
      int numFactura = Convert.ToInt32(this.txtFolioNotaVenta.Text.Trim());
      try
      {
        Venta venta = notaVenta.buscaNotaVentaFolio(numFactura);
        this.veOBBoleta = venta;
        if (venta.IdFactura != 0)
        {
          if (venta.IDDocumentoVenta == 0)
          {
            this.iniciaVenta();
            this.idBoleta = venta.IdFactura;
            if (venta.IdMedioPago != 0)
            {
              this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
              this.cmbMedioPago.Text = venta.MedioPago.ToString();
            }
            if (venta.IdVendedor != 0)
            {
              this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            }
            else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
              this.cmbVendedor.Text = venta.Vendedor.ToString();
            if (venta.IdCentroCosto != 0)
            {
              this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            }
            else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
              this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
            this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
            this.codigoCliente = venta.IdCliente;
            this.verificaCredito();
            this.txtRut.Text = venta.Rut;
            this.txtDigito.Text = venta.Digito;
            this.txtRazonSocial.Text = venta.RazonSocial.ToString();
            this._Direccion = venta.Direccion.ToString();
            this._Comuna = venta.Comuna.ToString();
            this._Ciudad = venta.Ciudad.ToString();
            this._Giro = venta.Giro.ToString();
            this._Fono = venta.Fono.ToString();
            this._Fax = venta.Fax.ToString();
            this._Contacto = venta.Contacto.ToString();
            this._DiasPlazo = venta.DiasPlazo.ToString();
            this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
            this.txtPorcDescuentoTotal.Text = venta.PorcentajeDescuento.ToString("N0");
            TextBox textBox1 = this.txtTotalDescuento;
            Decimal num = venta.Descuento;
            string str1 = num.ToString("N" + this.decimalesValoresVenta);
            textBox1.Text = str1;
            TextBox textBox2 = this.txtNeto;
            num = venta.Neto;
            string str2 = num.ToString("N" + this.decimalesValoresVenta);
            textBox2.Text = str2;
            TextBox textBox3 = this.txtIva;
            num = venta.Iva;
            string str3 = num.ToString("N" + this.decimalesValoresVenta);
            textBox3.Text = str3;
            num = venta.PorcentajeIva;
            this._porcIva = num.ToString("N0");
            TextBox textBox4 = this.txtTotalGeneral;
            num = venta.Total;
            string str4 = num.ToString("N" + this.decimalesValoresVenta);
            textBox4.Text = str4;
            TextBox textBox5 = this.txtTotalImp1;
            num = venta.Impuesto1;
            string str5;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto1;
              str5 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str5 = "";
            textBox5.Text = str5;
            TextBox textBox6 = this.txtTotalImp2;
            num = venta.Impuesto2;
            string str6;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto2;
              str6 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str6 = "";
            textBox6.Text = str6;
            TextBox textBox7 = this.txtTotalImp3;
            num = venta.Impuesto3;
            string str7;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto3;
              str7 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str7 = "";
            textBox7.Text = str7;
            TextBox textBox8 = this.txtTotalImp4;
            num = venta.Impuesto4;
            string str8;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto4;
              str8 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str8 = "";
            textBox8.Text = str8;
            TextBox textBox9 = this.txtTotalImp5;
            num = venta.Impuesto5;
            string str9;
            if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
            {
              num = venta.Impuesto5;
              str9 = num.ToString("N" + this.decimalesValoresVenta);
            }
            else
              str9 = "";
            textBox9.Text = str9;
            this.hayNotaVenta = true;
            frmBoleta.lista = notaVenta.buscaDetalleNotaVentaIDNotaVenta(venta.IdFactura);
            for (int index = 0; index < frmBoleta.lista.Count; ++index)
            {
              frmBoleta.lista[index].Linea = index + 1;
              frmBoleta.lista[index].FolioFactura = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
              frmBoleta.lista[index].IdFactura = 0;
              frmBoleta.lista[index].DescuentaInventario = false;
            }
            this.dgvDatosVenta.DataSource = (object) null;
            this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
          }
          else
          {
            int num1 = (int) MessageBox.Show(string.Concat(new object[4]
            {
              (object) "Nota de Venta ya Documentada en: ",
              (object) venta.DocumentoVenta,
              (object) " Folio N°: ",
              (object) venta.FolioDocumentoVenta
            }));
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("No Existe la Nota de Venta Consultada!!");
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al llamar Nota de Venta " + ex.Message);
      }
    }

    private void cambiaEstadoNotaVenta()
    {
      if (!this.hayNotaVenta)
        return;
      NotaVenta notaVenta = new NotaVenta();
      string str = "BOLETA";
      this.veOBBoleta.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBBoleta.IDDocumentoVenta = new Boleta().retornaIdBoleta(this.veOBBoleta.FolioDocumentoVenta);
      this.veOBBoleta.DocumentoVenta = str;
      notaVenta.modificaTipoDocumentoNotaVenta(this.veOBBoleta);
    }

    private void cambiaEstadoNotaVentaEliminaBoleta()
    {
      if (!this.hayNotaVenta)
        return;
      NotaVenta notaVenta = new NotaVenta();
      this.veOBBoleta.FolioDocumentoVenta = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      this.veOBBoleta.IDDocumentoVenta = 0;
      this.veOBBoleta.FolioDocumentoVenta = 0;
      this.veOBBoleta.DocumentoVenta = "";
      this.veOBBoleta.IdFactura = this.veOBBoleta.IdNotaVenta;
      this.veOBBoleta.Folio = this.veOBBoleta.FolioNotaVenta;
      notaVenta.modificaTipoDocumentoNotaVenta(this.veOBBoleta);
    }

    private void txtFolioNotaVenta_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioNotaVenta);
      if ((int) e.KeyChar != 13)
        return;
      this.buscaNotaVentaFolio();
    }

    private void btnVerificaCredito_Click(object sender, EventArgs e)
    {
      int num = (int) new frmMuestraCredito(this.codigoCliente).ShowDialog();
    }

    private void verificaCredito()
    {
      this.btnVerificaCredito.Enabled = true;
      foreach (CreditoVO creditoVo in new Credito().verificaCredito(this.codigoCliente))
      {
        if (creditoVo.Codigo == 7)
          this.txtCreditoDisponible.Text = creditoVo.Total.ToString("N0");
      }
    }

    private void txtComanda_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtComanda);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtComanda.Text.Length > 0)
        this.buscaComandaFolio(Convert.ToInt32(this.txtComanda.Text.Trim()));
    }

    private void chkCentroCostoFijo_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cmbCentroCosto.SelectedValue == null || this.cmbCentroCosto.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona el Centro de Costo");
        this.cmbCentroCosto.Focus();
        this.chkCentroCostoFijo.Checked = false;
      }
      else if (this.chkCentroCostoFijo.Checked)
        this.cmbCentroCosto.Enabled = false;
      else
        this.cmbCentroCosto.Enabled = true;
    }

    private void txtCodigoRapido_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13 || this.txtCodigoRapido.Text.Length <= 0)
        return;
      this.codigoRapido(this.txtCodigoRapido.Text);
      e.Handled = false;
      int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      if (frmMenuPrincipal._Pesable)
      {
        this.codigoPesable(this.txtCodigo.Text.Trim(), bodega);
        this.txtDescripcionCopia.Text = this.txtDescripcion.Text;
        if (this.txtDescripcion.Text.Trim().Length > 0)
        {
          this.btnRepiteCodigo.Enabled = true;
          this.agregaLineaGrilla();
        }
        else
          this.btnRepiteCodigo.Enabled = false;
      }
      else
      {
        this.txtDescripcionCopia.Text = this.txtDescripcion.Text;
        this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), bodega);
        if (this.txtDescripcion.Text.Trim().Length > 0)
        {
          this.btnRepiteCodigo.Enabled = true;
          this.agregaLineaGrilla();
        }
        else
          this.btnRepiteCodigo.Enabled = false;
      }
    }

    private void codigoRapido(string cod)
    {
      int length = cod.IndexOf('*');
      if (length == -1)
        length = cod.IndexOf('x');
      if (length == -1)
        length = cod.IndexOf('X');
      if (length > 0)
      {
        string s = cod.Substring(0, length);
        string str = cod.Substring(length + 1, cod.Length - length - 1);
        Decimal result = new Decimal(0);
        if (Decimal.TryParse(s, out result))
        {
          this.txtCodigo.Text = str;
          this.txtCantidad.Text = s;
          this.cantidadRepetido = this.txtCantidad.Text;
          this.codigoRepetido = this.txtCodigo.Text;
        }
        else
        {
          int num = (int) MessageBox.Show("La cantidad no es Numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.txtCodigoRapido.Focus();
        }
      }
      else
      {
        this.txtCodigo.Text = cod;
        this.txtCantidad.Text = "1";
        this.cantidadRepetido = this.txtCantidad.Text;
        this.codigoRepetido = this.txtCodigo.Text;
      }
    }

    private void txtCantidad_Enter(object sender, EventArgs e)
    {
      if (!this.chkCantidadFija.Checked || this.txtCantidad.Text.Length <= 0 || this.txtDescripcion.Text.Length <= 0)
        return;
      this.agregaLineaGrilla();
    }

    private void btnRepiteCodigo_Click(object sender, EventArgs e)
    {
      this.txtCodigo.Text = this.codigoRepetido;
      this.txtCantidad.Text = this.cantidadRepetido;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
      if (this.txtDescripcion.Text.Trim().Length > 0)
        this.agregaLineaGrilla();
      else
        this.btnRepiteCodigo.Enabled = false;
    }

    private void btnAceptarNumOperacion_Click(object sender, EventArgs e)
    {
      if (this.txtNumeroOperacion.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Numero de Operación", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNumeroOperacion.Focus();
      }
      else
      {
        this.guardaVoucher();
        this.panelNumeroOperacion.Visible = false;
      }
    }

    private void btnCancelarNumOperacion_Click(object sender, EventArgs e)
    {
      if (this.txtNumeroOperacion.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Numero de Operación", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNumeroOperacion.Focus();
      }
      else
        this.panelNumeroOperacion.Visible = false;
    }

    private void txtNumeroVoucher_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      if (this.txtNumeroVoucher.Text.Trim().Length > 0)
      {
        this.buscaBoletaVoucher(this.txtNumeroVoucher.Text.Trim());
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Numero de Voucher a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNumeroVoucher.Focus();
      }
    }

    public void buscaBoletaVoucher(string numVoucher)
    {
      this.panelFolio.Visible = false;
      Boleta boleta = new Boleta();
      try
      {
        Venta venta = boleta.buscaBoletaNumeroVoucher(numVoucher);
        this.veOBBoleta = venta;
        if (venta.IdFactura != 0)
        {
          this.iniciaVenta();
          this.idBoleta = venta.IdFactura;
          this.dtpEmision.Value = Convert.ToDateTime(venta.FechaEmision.ToString());
          this.dtpVencimiento.Value = Convert.ToDateTime(venta.FechaVencimiento.ToString());
          if (venta.IdMedioPago != 0)
          {
            this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
            this.cmbMedioPago.Text = venta.MedioPago.ToString();
          }
          if (venta.IdVendedor != 0)
          {
            this.cmbVendedor.SelectedValue = (object) venta.IdVendedor.ToString();
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          }
          else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
            this.cmbVendedor.Text = venta.Vendedor.ToString();
          if (venta.IdGarzon != 0)
          {
            this.cmbGarzon.SelectedValue = (object) venta.IdGarzon.ToString();
            this.cmbGarzon.Text = venta.Garzon.ToString();
          }
          else if (venta.IdGarzon == 0 && venta.Garzon.Length > 0)
            this.cmbGarzon.Text = venta.Garzon.ToString();
          if (venta.IdCentroCosto != 0)
          {
            this.cmbCentroCosto.SelectedValue = (object) venta.IdCentroCosto.ToString();
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          }
          else if (venta.IdCentroCosto == 0 && venta.CentroCosto.Length > 0)
            this.cmbCentroCosto.Text = venta.CentroCosto.ToString();
          this.txtNumeroVoucher.Text = venta.NumeroVoucher;
          if (venta.NumeroVoucher.Length > 0)
            this.txtNumeroVoucher.ReadOnly = true;
          else
            this.txtNumeroVoucher.ReadOnly = false;
          this.txtOrdenCompra.Text = venta.OrdenCompra.ToString();
          TextBox textBox1 = this.txtNumeroDocumento;
          int num1 = venta.Folio;
          string str1 = num1.ToString();
          textBox1.Text = str1;
          this.codigoCliente = venta.IdCliente;
          this.txtRut.Text = venta.Rut;
          this.txtDigito.Text = venta.Digito;
          this.txtRazonSocial.Text = venta.RazonSocial.ToString();
          this._Direccion = venta.Direccion.ToString();
          this._Comuna = venta.Comuna.ToString();
          this._Ciudad = venta.Ciudad.ToString();
          this._Giro = venta.Giro.ToString();
          this._Fono = venta.Fono.ToString();
          this._Fax = venta.Fax.ToString();
          this._Contacto = venta.Contacto.ToString();
          num1 = venta.DiasPlazo;
          this._DiasPlazo = num1.ToString();
          this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
          this.txtPorcDescuentoTotal.Text = venta.PorcentajeDescuento.ToString("N0");
          TextBox textBox2 = this.txtTotalDescuento;
          Decimal num2 = venta.Descuento;
          string str2 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox2.Text = str2;
          num2 = venta.Neto;
          this._Neto = num2.ToString("N" + this.decimalesValoresVenta);
          num2 = venta.Iva;
          this._Iva = num2.ToString("N" + this.decimalesValoresVenta);
          num2 = venta.PorcentajeIva;
          this._porcIva = num2.ToString("N0");
          TextBox textBox3 = this.txtTotalGeneral;
          num2 = venta.Total;
          string str3 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox3.Text = str3;
          TextBox textBox4 = this.txtTotalExento;
          num2 = venta.TotalExento;
          string str4 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox4.Text = str4;
          TextBox textBox5 = this.txtTotalCobrar;
          num2 = venta.TotalaCobrar;
          string str5 = num2.ToString("N" + this.decimalesValoresVenta);
          textBox5.Text = str5;
          TextBox textBox6 = this.txtTotalImp1;
          num2 = venta.Impuesto1;
          string str6;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto1;
            str6 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str6 = "";
          textBox6.Text = str6;
          TextBox textBox7 = this.txtTotalImp2;
          num2 = venta.Impuesto2;
          string str7;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto2;
            str7 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str7 = "";
          textBox7.Text = str7;
          TextBox textBox8 = this.txtTotalImp3;
          num2 = venta.Impuesto3;
          string str8;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto3;
            str8 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str8 = "";
          textBox8.Text = str8;
          TextBox textBox9 = this.txtTotalImp4;
          num2 = venta.Impuesto4;
          string str9;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto4;
            str9 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str9 = "";
          textBox9.Text = str9;
          TextBox textBox10 = this.txtTotalImp5;
          num2 = venta.Impuesto5;
          string str10;
          if (!num2.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num2 = venta.Impuesto5;
            str10 = num2.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str10 = "";
          textBox10.Text = str10;
          this.panelVuelto.Visible = true;
          Label label1 = this.lblPagaCon;
          num2 = venta.PagaCon;
          string str11 = num2.ToString("N0");
          label1.Text = str11;
          Label label2 = this.lblVuelto;
          num2 = venta.Vuelto;
          string str12 = num2.ToString("N0");
          label2.Text = str12;
          if (venta.IdTicket > 0)
          {
            this.hayTicket = true;
            TextBox textBox11 = this.txtTicket;
            num1 = venta.FolioTicket;
            string str13 = num1.ToString();
            textBox11.Text = str13;
            this.idTicket = venta.IdTicket;
          }
          if (venta.IdComanda > 0)
          {
            this.hayComanda = true;
            TextBox textBox11 = this.txtComanda;
            num1 = venta.FolioComanda;
            string str13 = num1.ToString();
            textBox11.Text = str13;
            this.idComanda = venta.IdComanda;
          }
          this.btnGuardar.Enabled = false;
          this.guardarFacturaTeclaF2ToolStripMenuItem.Enabled = false;
          if (venta.EstadoDocumento.Equals("ANULADA"))
          {
            this.btnAnular.Enabled = false;
            this.btnImprime.Enabled = false;
            if (this._elimina)
              this.btnEliminar.Enabled = true;
          }
          else
          {
            if (this._anula)
              this.btnAnular.Enabled = true;
            if (this._modifica)
              this.btnModificar.Enabled = true;
            this.btnImprime.Enabled = true;
            this.btnControlPago.Enabled = true;
          }
          this.lblEstadoDocumento.Text = venta.EstadoDocumento.ToString();
          frmBoleta.lista = boleta.buscaDetalleBoletaIDBoleta(venta.IdFactura);
          this.cmbBodega.SelectedValue = (object) frmBoleta.lista[0].Bodega;
          for (int index = 0; index < frmBoleta.lista.Count; ++index)
            frmBoleta.lista[index].Linea = index + 1;
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) frmBoleta.lista;
          this.txtFolioBuscar.Clear();
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe Boleta Consultada!!");
          this.txtFolioBuscar.Clear();
          this.iniciaVenta();
        } Boleta bl = new Boleta();
        lblFolio.Text = "Ticket POS N°";
          
        txtvoucher.Text = bl.folio_voucher(Convert.ToInt32(numVoucher));

      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error : " + ex.Message);
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosTeclaF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturaTeclaF6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarFacturaTeclaF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNumeroDeFolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculaVueltoTeclaF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarBoletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVoucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTotalLinea = new System.Windows.Forms.TextBox();
            this.gbZonaCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.txtCreditoDisponible = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.btnVerificaCredito = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.chkCantidadFija = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiaDetalle = new System.Windows.Forms.Button();
            this.gbZonaFechas = new System.Windows.Forms.GroupBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gbZonaBotones = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnControlPago = new System.Windows.Forms.Button();
            this.btnImprime = new System.Windows.Forms.Button();
            this.lblEstadoDocumento = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalExento = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotalGeneral = new System.Windows.Forms.TextBox();
            this.txtTotalDescuento = new System.Windows.Forms.TextBox();
            this.txtPorcDescuentoTotal = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvDatosVenta = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.gbZonaOtros = new System.Windows.Forms.GroupBox();
            this.txtNumeroVoucher = new System.Windows.Forms.TextBox();
            this.chkCentroCostoFijo = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.chkVendedorFijo = new System.Windows.Forms.CheckBox();
            this.chkMedioPagoFijo = new System.Windows.Forms.CheckBox();
            this.cmbCentroCosto = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.txtTipoDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotalLinea = new System.Windows.Forms.TextBox();
            this.btnLimpiaLineaDetalle = new System.Windows.Forms.Button();
            this.btnModificaLinea = new System.Windows.Forms.Button();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPorcDescuentoLinea = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dgvBuscaCliente = new System.Windows.Forms.DataGridView();
            this.pnlBuscaClienteDes = new System.Windows.Forms.Panel();
            this.panelFolio = new System.Windows.Forms.Panel();
            this.btnCerrarPanelFolio = new System.Windows.Forms.Button();
            this.btnBuscaFolio = new System.Windows.Forms.Button();
            this.txtFolioBuscar = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelVuelto = new System.Windows.Forms.Panel();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPagaCon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalCobrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalImp5 = new System.Windows.Forms.TextBox();
            this.txtTotalImp3 = new System.Windows.Forms.TextBox();
            this.txtTotalImp4 = new System.Windows.Forms.TextBox();
            this.txtPorImp5 = new System.Windows.Forms.TextBox();
            this.txtPorImp3 = new System.Windows.Forms.TextBox();
            this.txtTotalImp2 = new System.Windows.Forms.TextBox();
            this.txtPorImp4 = new System.Windows.Forms.TextBox();
            this.txtPorImp2 = new System.Windows.Forms.TextBox();
            this.txtTotalImp1 = new System.Windows.Forms.TextBox();
            this.txtPorImp1 = new System.Windows.Forms.TextBox();
            this.lblImp5 = new System.Windows.Forms.Label();
            this.lblImp4 = new System.Windows.Forms.Label();
            this.lblImp3 = new System.Windows.Forms.Label();
            this.lblImp2 = new System.Windows.Forms.Label();
            this.lblImp1 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.pnlCotizacionBuscar = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscaCotizacion = new System.Windows.Forms.Button();
            this.btnSalirBuscaCoti = new System.Windows.Forms.Button();
            this.txtFolioCotizacion = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.panelNotaVenta = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscaNotaventa = new System.Windows.Forms.Button();
            this.btnCierraNota = new System.Windows.Forms.Button();
            this.txtFolioNotaVenta = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cmbGarzon = new System.Windows.Forms.ComboBox();
            this.lblGarzon = new System.Windows.Forms.Label();
            this.txtDescripcionCopia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRepiteCodigo = new System.Windows.Forms.Button();
            this.txtCodigoRapido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlZonaDetalle = new System.Windows.Forms.TabControl();
            this.tabPageVentaNormal = new System.Windows.Forms.TabPage();
            this.tabPageVentaRapida = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNumeroOperacion = new System.Windows.Forms.Panel();
            this.btnCancelarNumOperacion = new System.Windows.Forms.Button();
            this.btnAceptarNumOperacion = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNumeroOperacion = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtvoucher = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gbZonaCliente.SuspendLayout();
            this.gbZonaFechas.SuspendLayout();
            this.gbZonaBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            this.gbZonaOtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).BeginInit();
            this.pnlBuscaClienteDes.SuspendLayout();
            this.panelFolio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelVuelto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlCotizacionBuscar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelNotaVenta.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControlZonaDetalle.SuspendLayout();
            this.tabPageVentaNormal.SuspendLayout();
            this.tabPageVentaRapida.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNumeroOperacion.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProductosTeclaF4ToolStripMenuItem,
            this.buscarFacturaTeclaF6ToolStripMenuItem,
            this.guardarFacturaTeclaF2ToolStripMenuItem,
            this.cambiarNumeroDeFolioToolStripMenuItem,
            this.calculaVueltoTeclaF5ToolStripMenuItem,
            this.listarBoletasToolStripMenuItem,
            this.buscarVoucherToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarProductosTeclaF4ToolStripMenuItem
            // 
            this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
            this.buscarProductosTeclaF4ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
            this.buscarProductosTeclaF4ToolStripMenuItem.Click += new System.EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
            // 
            // buscarFacturaTeclaF6ToolStripMenuItem
            // 
            this.buscarFacturaTeclaF6ToolStripMenuItem.Name = "buscarFacturaTeclaF6ToolStripMenuItem";
            this.buscarFacturaTeclaF6ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarFacturaTeclaF6ToolStripMenuItem.Text = "Buscar Boleta - tecla [F6]";
            this.buscarFacturaTeclaF6ToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturaTeclaF6ToolStripMenuItem_Click);
            // 
            // guardarFacturaTeclaF2ToolStripMenuItem
            // 
            this.guardarFacturaTeclaF2ToolStripMenuItem.Name = "guardarFacturaTeclaF2ToolStripMenuItem";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.guardarFacturaTeclaF2ToolStripMenuItem.Text = "Guardar Boleta - tecla[F2]";
            this.guardarFacturaTeclaF2ToolStripMenuItem.Click += new System.EventHandler(this.guardarFacturaTeclaF2ToolStripMenuItem_Click);
            // 
            // cambiarNumeroDeFolioToolStripMenuItem
            // 
            this.cambiarNumeroDeFolioToolStripMenuItem.Name = "cambiarNumeroDeFolioToolStripMenuItem";
            this.cambiarNumeroDeFolioToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cambiarNumeroDeFolioToolStripMenuItem.Text = "Cambiar Numero de Folio";
            this.cambiarNumeroDeFolioToolStripMenuItem.Click += new System.EventHandler(this.cambiarNumeroDeFolioToolStripMenuItem_Click);
            // 
            // calculaVueltoTeclaF5ToolStripMenuItem
            // 
            this.calculaVueltoTeclaF5ToolStripMenuItem.Name = "calculaVueltoTeclaF5ToolStripMenuItem";
            this.calculaVueltoTeclaF5ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.calculaVueltoTeclaF5ToolStripMenuItem.Text = "Calcula Vuelto - tecla [F5]";
            this.calculaVueltoTeclaF5ToolStripMenuItem.Click += new System.EventHandler(this.calculaVueltoTeclaF5ToolStripMenuItem_Click);
            // 
            // listarBoletasToolStripMenuItem
            // 
            this.listarBoletasToolStripMenuItem.Name = "listarBoletasToolStripMenuItem";
            this.listarBoletasToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.listarBoletasToolStripMenuItem.Text = "Listar Boletas";
            this.listarBoletasToolStripMenuItem.Click += new System.EventHandler(this.listarBoletasToolStripMenuItem_Click);
            // 
            // buscarVoucherToolStripMenuItem
            // 
            this.buscarVoucherToolStripMenuItem.Name = "buscarVoucherToolStripMenuItem";
            this.buscarVoucherToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarVoucherToolStripMenuItem.Text = "Buscar Vale POS";
            this.buscarVoucherToolStripMenuItem.Click += new System.EventHandler(this.buscarVoucherToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizaciónToolStripMenuItem,
            this.notaDeVentaToolStripMenuItem});
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // cotizaciónToolStripMenuItem
            // 
            this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
            this.cotizaciónToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cotizaciónToolStripMenuItem.Text = "Cotización";
            this.cotizaciónToolStripMenuItem.Click += new System.EventHandler(this.cotizaciónToolStripMenuItem_Click);
            // 
            // notaDeVentaToolStripMenuItem
            // 
            this.notaDeVentaToolStripMenuItem.Name = "notaDeVentaToolStripMenuItem";
            this.notaDeVentaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.notaDeVentaToolStripMenuItem.Text = "Nota de Venta";
            this.notaDeVentaToolStripMenuItem.Click += new System.EventHandler(this.notaDeVentaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(560, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Cantidad";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(676, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 23);
            this.label19.TabIndex = 6;
            this.label19.Text = "$ Descuento";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(482, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Precio";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(110, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(368, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Descripcion";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(560, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Codigo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(3, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(101, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(763, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 23);
            this.label20.TabIndex = 7;
            this.label20.Text = "Total";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(110, 20);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(368, 20);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // txtTotalLinea
            // 
            this.txtTotalLinea.BackColor = System.Drawing.Color.White;
            this.txtTotalLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalLinea.Enabled = false;
            this.txtTotalLinea.Location = new System.Drawing.Point(763, 20);
            this.txtTotalLinea.Name = "txtTotalLinea";
            this.txtTotalLinea.Size = new System.Drawing.Size(92, 20);
            this.txtTotalLinea.TabIndex = 15;
            this.txtTotalLinea.TabStop = false;
            this.txtTotalLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbZonaCliente
            // 
            this.gbZonaCliente.Controls.Add(this.btnBuscaCliente);
            this.gbZonaCliente.Controls.Add(this.label5);
            this.gbZonaCliente.Controls.Add(this.label4);
            this.gbZonaCliente.Controls.Add(this.txtRazonSocial);
            this.gbZonaCliente.Controls.Add(this.txtDigito);
            this.gbZonaCliente.Controls.Add(this.txtCreditoDisponible);
            this.gbZonaCliente.Controls.Add(this.label38);
            this.gbZonaCliente.Controls.Add(this.txtRut);
            this.gbZonaCliente.Controls.Add(this.btnVerificaCredito);
            this.gbZonaCliente.Location = new System.Drawing.Point(12, 71);
            this.gbZonaCliente.Name = "gbZonaCliente";
            this.gbZonaCliente.Size = new System.Drawing.Size(764, 40);
            this.gbZonaCliente.TabIndex = 26;
            this.gbZonaCliente.TabStop = false;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.Location = new System.Drawing.Point(456, 12);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(66, 20);
            this.btnBuscaCliente.TabIndex = 32;
            this.btnBuscaCliente.Text = "Buscar";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RUT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(193, 12);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(260, 20);
            this.txtRazonSocial.TabIndex = 8;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            this.txtRazonSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazonSocial_KeyDown);
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(109, 12);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(29, 20);
            this.txtDigito.TabIndex = 7;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtCreditoDisponible
            // 
            this.txtCreditoDisponible.BackColor = System.Drawing.Color.White;
            this.txtCreditoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditoDisponible.ForeColor = System.Drawing.Color.Black;
            this.txtCreditoDisponible.Location = new System.Drawing.Point(591, 12);
            this.txtCreditoDisponible.Name = "txtCreditoDisponible";
            this.txtCreditoDisponible.ReadOnly = true;
            this.txtCreditoDisponible.Size = new System.Drawing.Size(72, 21);
            this.txtCreditoDisponible.TabIndex = 42;
            this.txtCreditoDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(541, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 13);
            this.label38.TabIndex = 41;
            this.label38.Text = "Credito";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(40, 12);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(68, 20);
            this.txtRut.TabIndex = 6;
            this.txtRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRut_KeyDown);
            // 
            // btnVerificaCredito
            // 
            this.btnVerificaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificaCredito.Location = new System.Drawing.Point(666, 12);
            this.btnVerificaCredito.Name = "btnVerificaCredito";
            this.btnVerificaCredito.Size = new System.Drawing.Size(93, 20);
            this.btnVerificaCredito.TabIndex = 41;
            this.btnVerificaCredito.Text = "Verificar Credito";
            this.btnVerificaCredito.UseVisualStyleBackColor = true;
            this.btnVerificaCredito.Click += new System.EventHandler(this.btnVerificaCredito_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(482, 20);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Location = new System.Drawing.Point(676, 20);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(77, 20);
            this.txtDescuento.TabIndex = 14;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.Enter += new System.EventHandler(this.txtDescuento_Enter);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // chkCantidadFija
            // 
            this.chkCantidadFija.AutoSize = true;
            this.chkCantidadFija.Location = new System.Drawing.Point(619, 27);
            this.chkCantidadFija.Name = "chkCantidadFija";
            this.chkCantidadFija.Size = new System.Drawing.Size(15, 14);
            this.chkCantidadFija.TabIndex = 16;
            this.chkCantidadFija.UseVisualStyleBackColor = true;
            this.chkCantidadFija.Click += new System.EventHandler(this.chkCantidadFija_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(87, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(55, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiaDetalle
            // 
            this.btnLimpiaDetalle.Location = new System.Drawing.Point(145, 2);
            this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
            this.btnLimpiaDetalle.Size = new System.Drawing.Size(55, 23);
            this.btnLimpiaDetalle.TabIndex = 17;
            this.btnLimpiaDetalle.Text = "Limpiar";
            this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaDetalle.Click += new System.EventHandler(this.btnLimpiaDetalle_Click);
            // 
            // gbZonaFechas
            // 
            this.gbZonaFechas.Controls.Add(this.dtpVencimiento);
            this.gbZonaFechas.Controls.Add(this.dtpEmision);
            this.gbZonaFechas.Controls.Add(this.label2);
            this.gbZonaFechas.Controls.Add(this.label1);
            this.gbZonaFechas.Location = new System.Drawing.Point(12, 18);
            this.gbZonaFechas.Name = "gbZonaFechas";
            this.gbZonaFechas.Size = new System.Drawing.Size(228, 58);
            this.gbZonaFechas.TabIndex = 24;
            this.gbZonaFechas.TabStop = false;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(118, 29);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(96, 20);
            this.dtpVencimiento.TabIndex = 1;
            // 
            // dtpEmision
            // 
            this.dtpEmision.CustomFormat = "";
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmision.Location = new System.Drawing.Point(6, 29);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(104, 20);
            this.dtpEmision.TabIndex = 0;
            this.dtpEmision.ValueChanged += new System.EventHandler(this.dtpEmision_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vencimiento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emision";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(782, 42);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroDocumento.TabIndex = 16;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.DoubleClick += new System.EventHandler(this.txtNumeroDocumento_DoubleClick);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(782, 26);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(87, 16);
            this.lblFolio.TabIndex = 5;
            this.lblFolio.Text = "BOLETA N°";
            this.lblFolio.DoubleClick += new System.EventHandler(this.lblFolio_DoubleClick);
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(907, 262);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(91, 20);
            this.txtOrdenCompra.TabIndex = 5;
            this.txtOrdenCompra.Visible = false;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(907, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 23);
            this.label16.TabIndex = 7;
            this.label16.Text = "Orden de Compra";
            this.label16.Visible = false;
            // 
            // gbZonaBotones
            // 
            this.gbZonaBotones.Controls.Add(this.label3);
            this.gbZonaBotones.Controls.Add(this.btnControlPago);
            this.gbZonaBotones.Controls.Add(this.btnImprime);
            this.gbZonaBotones.Controls.Add(this.lblEstadoDocumento);
            this.gbZonaBotones.Controls.Add(this.btnAnular);
            this.gbZonaBotones.Controls.Add(this.btnSalir);
            this.gbZonaBotones.Controls.Add(this.btnLimpiar);
            this.gbZonaBotones.Controls.Add(this.btnGuardar);
            this.gbZonaBotones.Controls.Add(this.btnEliminar);
            this.gbZonaBotones.Controls.Add(this.btnModificar);
            this.gbZonaBotones.Location = new System.Drawing.Point(12, 490);
            this.gbZonaBotones.Name = "gbZonaBotones";
            this.gbZonaBotones.Size = new System.Drawing.Size(362, 132);
            this.gbZonaBotones.TabIndex = 28;
            this.gbZonaBotones.TabStop = false;
            this.gbZonaBotones.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "BOLETA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnControlPago
            // 
            this.btnControlPago.Location = new System.Drawing.Point(7, 97);
            this.btnControlPago.Name = "btnControlPago";
            this.btnControlPago.Size = new System.Drawing.Size(88, 23);
            this.btnControlPago.TabIndex = 27;
            this.btnControlPago.Text = "PAGAR";
            this.btnControlPago.UseVisualStyleBackColor = true;
            this.btnControlPago.Click += new System.EventHandler(this.btnControlPago_Click);
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(95, 97);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(88, 23);
            this.btnImprime.TabIndex = 26;
            this.btnImprime.Text = "RE-IMPRIMIR";
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // lblEstadoDocumento
            // 
            this.lblEstadoDocumento.AutoSize = true;
            this.lblEstadoDocumento.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDocumento.ForeColor = System.Drawing.Color.Red;
            this.lblEstadoDocumento.Location = new System.Drawing.Point(134, 24);
            this.lblEstadoDocumento.Name = "lblEstadoDocumento";
            this.lblEstadoDocumento.Size = new System.Drawing.Size(133, 34);
            this.lblEstadoDocumento.TabIndex = 25;
            this.lblEstadoDocumento.Text = "ESTADO";
            this.lblEstadoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(183, 69);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(88, 23);
            this.btnAnular.TabIndex = 24;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(271, 97);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(183, 97);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "GUARDA [F2]";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(271, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(95, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "TOTAL EXENTO";
            // 
            // txtTotalExento
            // 
            this.txtTotalExento.BackColor = System.Drawing.Color.White;
            this.txtTotalExento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalExento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExento.ForeColor = System.Drawing.Color.Black;
            this.txtTotalExento.Location = new System.Drawing.Point(200, 78);
            this.txtTotalExento.Name = "txtTotalExento";
            this.txtTotalExento.ReadOnly = true;
            this.txtTotalExento.Size = new System.Drawing.Size(123, 21);
            this.txtTotalExento.TabIndex = 29;
            this.txtTotalExento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalExento.TextChanged += new System.EventHandler(this.txtTotalExento_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubTotal.Location = new System.Drawing.Point(200, 9);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(123, 21);
            this.txtSubTotal.TabIndex = 10;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.BackColor = System.Drawing.Color.White;
            this.txtTotalGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeneral.ForeColor = System.Drawing.Color.Black;
            this.txtTotalGeneral.Location = new System.Drawing.Point(200, 55);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.ReadOnly = true;
            this.txtTotalGeneral.Size = new System.Drawing.Size(123, 21);
            this.txtTotalGeneral.TabIndex = 9;
            this.txtTotalGeneral.TabStop = false;
            this.txtTotalGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalGeneral.TextChanged += new System.EventHandler(this.txtTotalGeneral_TextChanged);
            // 
            // txtTotalDescuento
            // 
            this.txtTotalDescuento.BackColor = System.Drawing.Color.White;
            this.txtTotalDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDescuento.Location = new System.Drawing.Point(230, 32);
            this.txtTotalDescuento.Name = "txtTotalDescuento";
            this.txtTotalDescuento.ReadOnly = true;
            this.txtTotalDescuento.Size = new System.Drawing.Size(93, 21);
            this.txtTotalDescuento.TabIndex = 6;
            this.txtTotalDescuento.TabStop = false;
            this.txtTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDescuento.TextChanged += new System.EventHandler(this.txtTotalDescuento_TextChanged);
            this.txtTotalDescuento.DoubleClick += new System.EventHandler(this.txtTotalDescuento_DoubleClick);
            this.txtTotalDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalDescuento_KeyPress);
            this.txtTotalDescuento.Leave += new System.EventHandler(this.txtTotalDescuento_Leave);
            // 
            // txtPorcDescuentoTotal
            // 
            this.txtPorcDescuentoTotal.BackColor = System.Drawing.Color.White;
            this.txtPorcDescuentoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcDescuentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcDescuentoTotal.Location = new System.Drawing.Point(200, 32);
            this.txtPorcDescuentoTotal.Name = "txtPorcDescuentoTotal";
            this.txtPorcDescuentoTotal.ReadOnly = true;
            this.txtPorcDescuentoTotal.Size = new System.Drawing.Size(24, 21);
            this.txtPorcDescuentoTotal.TabIndex = 5;
            this.txtPorcDescuentoTotal.TabStop = false;
            this.txtPorcDescuentoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoTotal.TextChanged += new System.EventHandler(this.txtPorcDescuentoTotal_TextChanged);
            this.txtPorcDescuentoTotal.DoubleClick += new System.EventHandler(this.txtPorcDescuentoTotal_DoubleClick);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(148, 59);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "TOTAL";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(112, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "DESCUENTO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(123, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "SUBTOTAL";
            // 
            // dgvDatosVenta
            // 
            this.dgvDatosVenta.AllowUserToAddRows = false;
            this.dgvDatosVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDatosVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDatosVenta.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDatosVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatosVenta.Location = new System.Drawing.Point(18, 216);
            this.dgvDatosVenta.MultiSelect = false;
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.ReadOnly = true;
            this.dgvDatosVenta.RowHeadersVisible = false;
            this.dgvDatosVenta.RowHeadersWidth = 50;
            this.dgvDatosVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosVenta.Size = new System.Drawing.Size(877, 271);
            this.dgvDatosVenta.TabIndex = 3;
            this.dgvDatosVenta.TabStop = false;
            this.dgvDatosVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
            this.dgvDatosVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(254, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 23);
            this.label27.TabIndex = 21;
            this.label27.Text = "Vendedor";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(254, 29);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(131, 21);
            this.cmbVendedor.TabIndex = 3;
            this.cmbVendedor.Enter += new System.EventHandler(this.cmbVendedor_Enter);
            // 
            // gbZonaOtros
            // 
            this.gbZonaOtros.Controls.Add(this.txtNumeroVoucher);
            this.gbZonaOtros.Controls.Add(this.chkCentroCostoFijo);
            this.gbZonaOtros.Controls.Add(this.label24);
            this.gbZonaOtros.Controls.Add(this.cmbMedioPago);
            this.gbZonaOtros.Controls.Add(this.chkVendedorFijo);
            this.gbZonaOtros.Controls.Add(this.chkMedioPagoFijo);
            this.gbZonaOtros.Controls.Add(this.cmbCentroCosto);
            this.gbZonaOtros.Controls.Add(this.cmbVendedor);
            this.gbZonaOtros.Controls.Add(this.label30);
            this.gbZonaOtros.Controls.Add(this.label18);
            this.gbZonaOtros.Controls.Add(this.label27);
            this.gbZonaOtros.Location = new System.Drawing.Point(243, 18);
            this.gbZonaOtros.Name = "gbZonaOtros";
            this.gbZonaOtros.Size = new System.Drawing.Size(533, 58);
            this.gbZonaOtros.TabIndex = 25;
            this.gbZonaOtros.TabStop = false;
            // 
            // txtNumeroVoucher
            // 
            this.txtNumeroVoucher.Location = new System.Drawing.Point(150, 30);
            this.txtNumeroVoucher.Name = "txtNumeroVoucher";
            this.txtNumeroVoucher.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroVoucher.TabIndex = 46;
            this.txtNumeroVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroVoucher_KeyDown);
            // 
            // chkCentroCostoFijo
            // 
            this.chkCentroCostoFijo.AutoSize = true;
            this.chkCentroCostoFijo.Location = new System.Drawing.Point(513, 16);
            this.chkCentroCostoFijo.Name = "chkCentroCostoFijo";
            this.chkCentroCostoFijo.Size = new System.Drawing.Size(15, 14);
            this.chkCentroCostoFijo.TabIndex = 44;
            this.chkCentroCostoFijo.TabStop = false;
            this.chkCentroCostoFijo.UseVisualStyleBackColor = true;
            this.chkCentroCostoFijo.CheckedChanged += new System.EventHandler(this.chkCentroCostoFijo_CheckedChanged);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(150, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 23);
            this.label24.TabIndex = 47;
            this.label24.Text = "N° Op. Voucher";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMedioPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(6, 29);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(140, 21);
            this.cmbMedioPago.TabIndex = 2;
            this.cmbMedioPago.SelectedValueChanged += new System.EventHandler(this.cmbMedioPago_SelectedValueChanged);
            this.cmbMedioPago.Enter += new System.EventHandler(this.cmbMedioPago_Enter);
            // 
            // chkVendedorFijo
            // 
            this.chkVendedorFijo.AutoSize = true;
            this.chkVendedorFijo.Location = new System.Drawing.Point(372, 16);
            this.chkVendedorFijo.Name = "chkVendedorFijo";
            this.chkVendedorFijo.Size = new System.Drawing.Size(15, 14);
            this.chkVendedorFijo.TabIndex = 30;
            this.chkVendedorFijo.TabStop = false;
            this.chkVendedorFijo.UseVisualStyleBackColor = true;
            this.chkVendedorFijo.CheckedChanged += new System.EventHandler(this.chkVendedorFijo_CheckedChanged);
            // 
            // chkMedioPagoFijo
            // 
            this.chkMedioPagoFijo.AutoSize = true;
            this.chkMedioPagoFijo.Location = new System.Drawing.Point(132, 16);
            this.chkMedioPagoFijo.Name = "chkMedioPagoFijo";
            this.chkMedioPagoFijo.Size = new System.Drawing.Size(15, 14);
            this.chkMedioPagoFijo.TabIndex = 29;
            this.chkMedioPagoFijo.TabStop = false;
            this.chkMedioPagoFijo.UseVisualStyleBackColor = true;
            this.chkMedioPagoFijo.CheckedChanged += new System.EventHandler(this.chkMedioPagoFijo_CheckedChanged);
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCosto.FormattingEnabled = true;
            this.cmbCentroCosto.Location = new System.Drawing.Point(391, 29);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Size = new System.Drawing.Size(137, 21);
            this.cmbCentroCosto.TabIndex = 4;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(391, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 23);
            this.label30.TabIndex = 34;
            this.label30.Text = "Centro de Costo";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(6, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Medio de Pago";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 48);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Bodega";
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(56, 44);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(126, 21);
            this.cmbBodega.TabIndex = 17;
            this.cmbBodega.Enter += new System.EventHandler(this.cmbBodega_Enter);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(195, 48);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Lista de Precio";
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(275, 44);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(126, 21);
            this.cmbListaPrecio.TabIndex = 18;
            this.cmbListaPrecio.SelectedValueChanged += new System.EventHandler(this.cmbListaPrecio_SelectedValueChanged);
            // 
            // txtTipoDescuento
            // 
            this.txtTipoDescuento.Location = new System.Drawing.Point(580, 44);
            this.txtTipoDescuento.Name = "txtTipoDescuento";
            this.txtTipoDescuento.Size = new System.Drawing.Size(38, 20);
            this.txtTipoDescuento.TabIndex = 35;
            this.txtTipoDescuento.Text = "0";
            this.txtTipoDescuento.Visible = false;
            // 
            // txtSubTotalLinea
            // 
            this.txtSubTotalLinea.Location = new System.Drawing.Point(528, 44);
            this.txtSubTotalLinea.Name = "txtSubTotalLinea";
            this.txtSubTotalLinea.Size = new System.Drawing.Size(43, 20);
            this.txtSubTotalLinea.TabIndex = 34;
            this.txtSubTotalLinea.Visible = false;
            // 
            // btnLimpiaLineaDetalle
            // 
            this.btnLimpiaLineaDetalle.Location = new System.Drawing.Point(859, 5);
            this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
            this.btnLimpiaLineaDetalle.Size = new System.Drawing.Size(20, 34);
            this.btnLimpiaLineaDetalle.TabIndex = 33;
            this.btnLimpiaLineaDetalle.Text = "..";
            this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
            this.btnLimpiaLineaDetalle.Click += new System.EventHandler(this.btnLimpiaLineaDetalle_Click);
            // 
            // btnModificaLinea
            // 
            this.btnModificaLinea.Location = new System.Drawing.Point(7, 3);
            this.btnModificaLinea.Name = "btnModificaLinea";
            this.btnModificaLinea.Size = new System.Drawing.Size(75, 23);
            this.btnModificaLinea.TabIndex = 33;
            this.btnModificaLinea.Text = "Modificar";
            this.btnModificaLinea.UseVisualStyleBackColor = true;
            this.btnModificaLinea.Click += new System.EventHandler(this.btnModificaLinea_Click);
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(450, 44);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(71, 20);
            this.txtLinea.TabIndex = 32;
            this.txtLinea.Text = "NumeroLinea";
            this.txtLinea.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(756, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 36);
            this.panel4.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(636, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 36);
            this.panel3.TabIndex = 30;
            // 
            // txtPorcDescuentoLinea
            // 
            this.txtPorcDescuentoLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcDescuentoLinea.Location = new System.Drawing.Point(643, 20);
            this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
            this.txtPorcDescuentoLinea.Size = new System.Drawing.Size(31, 20);
            this.txtPorcDescuentoLinea.TabIndex = 13;
            this.txtPorcDescuentoLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcDescuentoLinea.TextChanged += new System.EventHandler(this.porcentajeDescuento_TextChanged);
            this.txtPorcDescuentoLinea.Enter += new System.EventHandler(this.txtPorcDescuentoLinea_Enter);
            this.txtPorcDescuentoLinea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPorcDescuentoLinea_KeyDown);
            this.txtPorcDescuentoLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(643, 6);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 23);
            this.label31.TabIndex = 29;
            this.label31.Text = "%";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvBuscaCliente
            // 
            this.dgvBuscaCliente.AllowUserToAddRows = false;
            this.dgvBuscaCliente.AllowUserToDeleteRows = false;
            this.dgvBuscaCliente.AllowUserToResizeColumns = false;
            this.dgvBuscaCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Lavender;
            this.dgvBuscaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBuscaCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscaCliente.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBuscaCliente.Location = new System.Drawing.Point(2, 3);
            this.dgvBuscaCliente.Name = "dgvBuscaCliente";
            this.dgvBuscaCliente.ReadOnly = true;
            this.dgvBuscaCliente.RowHeadersVisible = false;
            this.dgvBuscaCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscaCliente.Size = new System.Drawing.Size(769, 205);
            this.dgvBuscaCliente.TabIndex = 0;
            this.dgvBuscaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscaCliente_CellDoubleClick);
            this.dgvBuscaCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBuscaCliente_KeyDown);
            // 
            // pnlBuscaClienteDes
            // 
            this.pnlBuscaClienteDes.BackColor = System.Drawing.Color.Transparent;
            this.pnlBuscaClienteDes.Controls.Add(this.dgvBuscaCliente);
            this.pnlBuscaClienteDes.Location = new System.Drawing.Point(205, 101);
            this.pnlBuscaClienteDes.Name = "pnlBuscaClienteDes";
            this.pnlBuscaClienteDes.Size = new System.Drawing.Size(776, 210);
            this.pnlBuscaClienteDes.TabIndex = 32;
            // 
            // panelFolio
            // 
            this.panelFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFolio.Controls.Add(this.btnCerrarPanelFolio);
            this.panelFolio.Controls.Add(this.btnBuscaFolio);
            this.panelFolio.Controls.Add(this.txtFolioBuscar);
            this.panelFolio.Controls.Add(this.label32);
            this.panelFolio.Location = new System.Drawing.Point(696, 73);
            this.panelFolio.Name = "panelFolio";
            this.panelFolio.Size = new System.Drawing.Size(234, 92);
            this.panelFolio.TabIndex = 24;
            // 
            // btnCerrarPanelFolio
            // 
            this.btnCerrarPanelFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPanelFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPanelFolio.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarPanelFolio.Location = new System.Drawing.Point(185, 1);
            this.btnCerrarPanelFolio.Name = "btnCerrarPanelFolio";
            this.btnCerrarPanelFolio.Size = new System.Drawing.Size(23, 24);
            this.btnCerrarPanelFolio.TabIndex = 24;
            this.btnCerrarPanelFolio.Text = "X";
            this.btnCerrarPanelFolio.UseVisualStyleBackColor = true;
            this.btnCerrarPanelFolio.Click += new System.EventHandler(this.btnCerrarPanelFolio_Click);
            // 
            // btnBuscaFolio
            // 
            this.btnBuscaFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaFolio.Location = new System.Drawing.Point(25, 59);
            this.btnBuscaFolio.Name = "btnBuscaFolio";
            this.btnBuscaFolio.Size = new System.Drawing.Size(161, 25);
            this.btnBuscaFolio.TabIndex = 2;
            this.btnBuscaFolio.Text = "Buscar";
            this.btnBuscaFolio.UseVisualStyleBackColor = true;
            this.btnBuscaFolio.Click += new System.EventHandler(this.btnBuscaFolio_Click);
            // 
            // txtFolioBuscar
            // 
            this.txtFolioBuscar.Location = new System.Drawing.Point(26, 33);
            this.txtFolioBuscar.Name = "txtFolioBuscar";
            this.txtFolioBuscar.Size = new System.Drawing.Size(162, 20);
            this.txtFolioBuscar.TabIndex = 1;
            this.txtFolioBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioBuscar_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(21, 8);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(164, 16);
            this.label32.TabIndex = 0;
            this.label32.Text = "Ingrese Folio a Buscar";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(782, 65);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(61, 13);
            this.label33.TabIndex = 33;
            this.label33.Text = "Ticket N°";
            // 
            // txtTicket
            // 
            this.txtTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTicket.Location = new System.Drawing.Point(782, 80);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(111, 20);
            this.txtTicket.TabIndex = 29;
            this.txtTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicket_KeyPress);
            // 
            // txtComanda
            // 
            this.txtComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtComanda.Location = new System.Drawing.Point(782, 114);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(111, 20);
            this.txtComanda.TabIndex = 35;
            this.txtComanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComanda_KeyPress);
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(786, 100);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(77, 13);
            this.lblComanda.TabIndex = 34;
            this.lblComanda.Text = "Comanda N°";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelVuelto);
            this.groupBox1.Controls.Add(this.txtTotalCobrar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTotalGeneral);
            this.groupBox1.Controls.Add(this.txtPorcDescuentoTotal);
            this.groupBox1.Controls.Add(this.txtTotalExento);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtTotalDescuento);
            this.groupBox1.Location = new System.Drawing.Point(569, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 133);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // panelVuelto
            // 
            this.panelVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelVuelto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVuelto.Controls.Add(this.lblVuelto);
            this.panelVuelto.Controls.Add(this.label10);
            this.panelVuelto.Controls.Add(this.lblPagaCon);
            this.panelVuelto.Controls.Add(this.label8);
            this.panelVuelto.Location = new System.Drawing.Point(3, 13);
            this.panelVuelto.Name = "panelVuelto";
            this.panelVuelto.Size = new System.Drawing.Size(101, 69);
            this.panelVuelto.TabIndex = 38;
            this.panelVuelto.Visible = false;
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVuelto.Location = new System.Drawing.Point(6, 47);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(15, 15);
            this.lblVuelto.TabIndex = 41;
            this.lblVuelto.Text = "0";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 32);
            this.label10.TabIndex = 40;
            this.label10.Text = "Vuelto";
            // 
            // lblPagaCon
            // 
            this.lblPagaCon.AutoSize = true;
            this.lblPagaCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaCon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPagaCon.Location = new System.Drawing.Point(6, 16);
            this.lblPagaCon.Name = "lblPagaCon";
            this.lblPagaCon.Size = new System.Drawing.Size(15, 15);
            this.lblPagaCon.TabIndex = 39;
            this.lblPagaCon.Text = "0";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Paga Con";
            // 
            // txtTotalCobrar
            // 
            this.txtTotalCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTotalCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCobrar.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCobrar.Location = new System.Drawing.Point(200, 101);
            this.txtTotalCobrar.Name = "txtTotalCobrar";
            this.txtTotalCobrar.ReadOnly = true;
            this.txtTotalCobrar.Size = new System.Drawing.Size(123, 29);
            this.txtTotalCobrar.TabIndex = 37;
            this.txtTotalCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCobrar.TextChanged += new System.EventHandler(this.txtTotalCobrar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "TOTAL A COBRAR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalImp5);
            this.groupBox2.Controls.Add(this.txtTotalImp3);
            this.groupBox2.Controls.Add(this.txtTotalImp4);
            this.groupBox2.Controls.Add(this.txtPorImp5);
            this.groupBox2.Controls.Add(this.txtPorImp3);
            this.groupBox2.Controls.Add(this.txtTotalImp2);
            this.groupBox2.Controls.Add(this.txtPorImp4);
            this.groupBox2.Controls.Add(this.txtPorImp2);
            this.groupBox2.Controls.Add(this.txtTotalImp1);
            this.groupBox2.Controls.Add(this.txtPorImp1);
            this.groupBox2.Controls.Add(this.lblImp5);
            this.groupBox2.Controls.Add(this.lblImp4);
            this.groupBox2.Controls.Add(this.lblImp3);
            this.groupBox2.Controls.Add(this.lblImp2);
            this.groupBox2.Controls.Add(this.lblImp1);
            this.groupBox2.Location = new System.Drawing.Point(377, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 132);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impuestos Especiales";
            // 
            // txtTotalImp5
            // 
            this.txtTotalImp5.BackColor = System.Drawing.Color.White;
            this.txtTotalImp5.Enabled = false;
            this.txtTotalImp5.Location = new System.Drawing.Point(123, 104);
            this.txtTotalImp5.Name = "txtTotalImp5";
            this.txtTotalImp5.Size = new System.Drawing.Size(63, 20);
            this.txtTotalImp5.TabIndex = 38;
            this.txtTotalImp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp3
            // 
            this.txtTotalImp3.BackColor = System.Drawing.Color.White;
            this.txtTotalImp3.Enabled = false;
            this.txtTotalImp3.Location = new System.Drawing.Point(123, 60);
            this.txtTotalImp3.Name = "txtTotalImp3";
            this.txtTotalImp3.Size = new System.Drawing.Size(63, 20);
            this.txtTotalImp3.TabIndex = 10;
            this.txtTotalImp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp4
            // 
            this.txtTotalImp4.BackColor = System.Drawing.Color.White;
            this.txtTotalImp4.Enabled = false;
            this.txtTotalImp4.Location = new System.Drawing.Point(123, 82);
            this.txtTotalImp4.Name = "txtTotalImp4";
            this.txtTotalImp4.Size = new System.Drawing.Size(63, 20);
            this.txtTotalImp4.TabIndex = 36;
            this.txtTotalImp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp5
            // 
            this.txtPorImp5.BackColor = System.Drawing.Color.White;
            this.txtPorImp5.Enabled = false;
            this.txtPorImp5.Location = new System.Drawing.Point(87, 104);
            this.txtPorImp5.Name = "txtPorImp5";
            this.txtPorImp5.Size = new System.Drawing.Size(33, 20);
            this.txtPorImp5.TabIndex = 37;
            this.txtPorImp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp3
            // 
            this.txtPorImp3.BackColor = System.Drawing.Color.White;
            this.txtPorImp3.Enabled = false;
            this.txtPorImp3.Location = new System.Drawing.Point(87, 60);
            this.txtPorImp3.Name = "txtPorImp3";
            this.txtPorImp3.Size = new System.Drawing.Size(33, 20);
            this.txtPorImp3.TabIndex = 9;
            this.txtPorImp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp2
            // 
            this.txtTotalImp2.BackColor = System.Drawing.Color.White;
            this.txtTotalImp2.Enabled = false;
            this.txtTotalImp2.Location = new System.Drawing.Point(123, 38);
            this.txtTotalImp2.Name = "txtTotalImp2";
            this.txtTotalImp2.Size = new System.Drawing.Size(63, 20);
            this.txtTotalImp2.TabIndex = 8;
            this.txtTotalImp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp4
            // 
            this.txtPorImp4.BackColor = System.Drawing.Color.White;
            this.txtPorImp4.Enabled = false;
            this.txtPorImp4.Location = new System.Drawing.Point(87, 82);
            this.txtPorImp4.Name = "txtPorImp4";
            this.txtPorImp4.Size = new System.Drawing.Size(33, 20);
            this.txtPorImp4.TabIndex = 35;
            this.txtPorImp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp2
            // 
            this.txtPorImp2.BackColor = System.Drawing.Color.White;
            this.txtPorImp2.Enabled = false;
            this.txtPorImp2.Location = new System.Drawing.Point(87, 38);
            this.txtPorImp2.Name = "txtPorImp2";
            this.txtPorImp2.Size = new System.Drawing.Size(33, 20);
            this.txtPorImp2.TabIndex = 7;
            this.txtPorImp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalImp1
            // 
            this.txtTotalImp1.BackColor = System.Drawing.Color.White;
            this.txtTotalImp1.Enabled = false;
            this.txtTotalImp1.Location = new System.Drawing.Point(123, 16);
            this.txtTotalImp1.Name = "txtTotalImp1";
            this.txtTotalImp1.Size = new System.Drawing.Size(63, 20);
            this.txtTotalImp1.TabIndex = 6;
            this.txtTotalImp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorImp1
            // 
            this.txtPorImp1.BackColor = System.Drawing.Color.White;
            this.txtPorImp1.Enabled = false;
            this.txtPorImp1.ForeColor = System.Drawing.Color.Black;
            this.txtPorImp1.Location = new System.Drawing.Point(87, 16);
            this.txtPorImp1.Name = "txtPorImp1";
            this.txtPorImp1.Size = new System.Drawing.Size(33, 20);
            this.txtPorImp1.TabIndex = 5;
            this.txtPorImp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImp5
            // 
            this.lblImp5.AutoSize = true;
            this.lblImp5.Location = new System.Drawing.Point(5, 108);
            this.lblImp5.Name = "lblImp5";
            this.lblImp5.Size = new System.Drawing.Size(59, 13);
            this.lblImp5.TabIndex = 4;
            this.lblImp5.Text = "Impuesto 5";
            // 
            // lblImp4
            // 
            this.lblImp4.AutoSize = true;
            this.lblImp4.Location = new System.Drawing.Point(5, 86);
            this.lblImp4.Name = "lblImp4";
            this.lblImp4.Size = new System.Drawing.Size(59, 13);
            this.lblImp4.TabIndex = 3;
            this.lblImp4.Text = "Impuesto 4";
            // 
            // lblImp3
            // 
            this.lblImp3.AutoSize = true;
            this.lblImp3.Location = new System.Drawing.Point(5, 64);
            this.lblImp3.Name = "lblImp3";
            this.lblImp3.Size = new System.Drawing.Size(59, 13);
            this.lblImp3.TabIndex = 2;
            this.lblImp3.Text = "Impuesto 3";
            // 
            // lblImp2
            // 
            this.lblImp2.AutoSize = true;
            this.lblImp2.Location = new System.Drawing.Point(5, 42);
            this.lblImp2.Name = "lblImp2";
            this.lblImp2.Size = new System.Drawing.Size(59, 13);
            this.lblImp2.TabIndex = 1;
            this.lblImp2.Text = "Impuesto 2";
            // 
            // lblImp1
            // 
            this.lblImp1.AutoSize = true;
            this.lblImp1.Location = new System.Drawing.Point(5, 20);
            this.lblImp1.Name = "lblImp1";
            this.lblImp1.Size = new System.Drawing.Size(59, 13);
            this.lblImp1.TabIndex = 0;
            this.lblImp1.Text = "Impuesto 1";
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(905, 466);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(92, 20);
            this.txtNeto.TabIndex = 37;
            this.txtNeto.Visible = false;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(905, 492);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(92, 20);
            this.txtIva.TabIndex = 38;
            this.txtIva.Visible = false;
            // 
            // pnlCotizacionBuscar
            // 
            this.pnlCotizacionBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCotizacionBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCotizacionBuscar.Controls.Add(this.groupBox3);
            this.pnlCotizacionBuscar.Location = new System.Drawing.Point(590, 123);
            this.pnlCotizacionBuscar.Name = "pnlCotizacionBuscar";
            this.pnlCotizacionBuscar.Size = new System.Drawing.Size(211, 122);
            this.pnlCotizacionBuscar.TabIndex = 39;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.btnBuscaCotizacion);
            this.groupBox3.Controls.Add(this.btnSalirBuscaCoti);
            this.groupBox3.Controls.Add(this.txtFolioCotizacion);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Location = new System.Drawing.Point(-1, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 115);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnBuscaCotizacion
            // 
            this.btnBuscaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCotizacion.Location = new System.Drawing.Point(25, 75);
            this.btnBuscaCotizacion.Name = "btnBuscaCotizacion";
            this.btnBuscaCotizacion.Size = new System.Drawing.Size(139, 23);
            this.btnBuscaCotizacion.TabIndex = 2;
            this.btnBuscaCotizacion.Text = "BUSCAR";
            this.btnBuscaCotizacion.UseVisualStyleBackColor = true;
            this.btnBuscaCotizacion.Click += new System.EventHandler(this.btnBuscaCotizacion_Click);
            // 
            // btnSalirBuscaCoti
            // 
            this.btnSalirBuscaCoti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirBuscaCoti.Location = new System.Drawing.Point(172, 10);
            this.btnSalirBuscaCoti.Name = "btnSalirBuscaCoti";
            this.btnSalirBuscaCoti.Size = new System.Drawing.Size(29, 23);
            this.btnSalirBuscaCoti.TabIndex = 3;
            this.btnSalirBuscaCoti.Text = "X";
            this.btnSalirBuscaCoti.UseVisualStyleBackColor = true;
            this.btnSalirBuscaCoti.Click += new System.EventHandler(this.btnSalirBuscaCoti_Click);
            // 
            // txtFolioCotizacion
            // 
            this.txtFolioCotizacion.Location = new System.Drawing.Point(25, 49);
            this.txtFolioCotizacion.Name = "txtFolioCotizacion";
            this.txtFolioCotizacion.Size = new System.Drawing.Size(140, 20);
            this.txtFolioCotizacion.TabIndex = 1;
            this.txtFolioCotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioCotizacion_KeyPress);
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(26, 31);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(138, 18);
            this.label36.TabIndex = 0;
            this.label36.Text = "COTIZACIÓN N°";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelNotaVenta
            // 
            this.panelNotaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelNotaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNotaVenta.Controls.Add(this.groupBox4);
            this.panelNotaVenta.Location = new System.Drawing.Point(333, 123);
            this.panelNotaVenta.Name = "panelNotaVenta";
            this.panelNotaVenta.Size = new System.Drawing.Size(230, 125);
            this.panelNotaVenta.TabIndex = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.btnBuscaNotaventa);
            this.groupBox4.Controls.Add(this.btnCierraNota);
            this.groupBox4.Controls.Add(this.txtFolioNotaVenta);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Location = new System.Drawing.Point(-1, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 119);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // btnBuscaNotaventa
            // 
            this.btnBuscaNotaventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaNotaventa.Location = new System.Drawing.Point(25, 83);
            this.btnBuscaNotaventa.Name = "btnBuscaNotaventa";
            this.btnBuscaNotaventa.Size = new System.Drawing.Size(148, 23);
            this.btnBuscaNotaventa.TabIndex = 2;
            this.btnBuscaNotaventa.Text = "BUSCAR";
            this.btnBuscaNotaventa.UseVisualStyleBackColor = true;
            this.btnBuscaNotaventa.Click += new System.EventHandler(this.btnBuscaNotaventa_Click);
            // 
            // btnCierraNota
            // 
            this.btnCierraNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCierraNota.Location = new System.Drawing.Point(191, 10);
            this.btnCierraNota.Name = "btnCierraNota";
            this.btnCierraNota.Size = new System.Drawing.Size(29, 23);
            this.btnCierraNota.TabIndex = 3;
            this.btnCierraNota.Text = "X";
            this.btnCierraNota.UseVisualStyleBackColor = true;
            this.btnCierraNota.Click += new System.EventHandler(this.btnCierraNota_Click);
            // 
            // txtFolioNotaVenta
            // 
            this.txtFolioNotaVenta.Location = new System.Drawing.Point(25, 57);
            this.txtFolioNotaVenta.Name = "txtFolioNotaVenta";
            this.txtFolioNotaVenta.Size = new System.Drawing.Size(148, 20);
            this.txtFolioNotaVenta.TabIndex = 1;
            this.txtFolioNotaVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioNotaVenta_KeyPress);
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(24, 39);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(149, 18);
            this.label37.TabIndex = 0;
            this.label37.Text = "NOTA DE VENTA N°";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbGarzon
            // 
            this.cmbGarzon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGarzon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGarzon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGarzon.FormattingEnabled = true;
            this.cmbGarzon.Location = new System.Drawing.Point(638, 113);
            this.cmbGarzon.Name = "cmbGarzon";
            this.cmbGarzon.Size = new System.Drawing.Size(131, 21);
            this.cmbGarzon.TabIndex = 35;
            // 
            // lblGarzon
            // 
            this.lblGarzon.AutoSize = true;
            this.lblGarzon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarzon.Location = new System.Drawing.Point(587, 117);
            this.lblGarzon.Name = "lblGarzon";
            this.lblGarzon.Size = new System.Drawing.Size(47, 13);
            this.lblGarzon.TabIndex = 43;
            this.lblGarzon.Text = "Garzon";
            this.lblGarzon.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescripcionCopia
            // 
            this.txtDescripcionCopia.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCopia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCopia.Location = new System.Drawing.Point(301, 5);
            this.txtDescripcionCopia.Name = "txtDescripcionCopia";
            this.txtDescripcionCopia.ReadOnly = true;
            this.txtDescripcionCopia.Size = new System.Drawing.Size(384, 29);
            this.txtDescripcionCopia.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(551, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Ultimo producto agregado";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(292, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 59);
            this.panel2.TabIndex = 45;
            // 
            // btnRepiteCodigo
            // 
            this.btnRepiteCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepiteCodigo.Location = new System.Drawing.Point(693, 5);
            this.btnRepiteCodigo.Name = "btnRepiteCodigo";
            this.btnRepiteCodigo.Size = new System.Drawing.Size(184, 30);
            this.btnRepiteCodigo.TabIndex = 12;
            this.btnRepiteCodigo.Text = "REPETIR ULTIMO CODIGO";
            this.btnRepiteCodigo.UseVisualStyleBackColor = true;
            this.btnRepiteCodigo.Click += new System.EventHandler(this.btnRepiteCodigo_Click);
            // 
            // txtCodigoRapido
            // 
            this.txtCodigoRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoRapido.Location = new System.Drawing.Point(100, 5);
            this.txtCodigoRapido.Name = "txtCodigoRapido";
            this.txtCodigoRapido.Size = new System.Drawing.Size(186, 29);
            this.txtCodigoRapido.TabIndex = 11;
            this.txtCodigoRapido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoRapido_KeyPress);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 30);
            this.label9.TabIndex = 10;
            this.label9.Text = "Codigo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 34);
            this.label12.TabIndex = 47;
            this.label12.Text = "Si es mas de 1 marque cantidad * codigo Ej: 5*ABC123";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabControlZonaDetalle
            // 
            this.tabControlZonaDetalle.Controls.Add(this.tabPageVentaNormal);
            this.tabControlZonaDetalle.Controls.Add(this.tabPageVentaRapida);
            this.tabControlZonaDetalle.Location = new System.Drawing.Point(12, 119);
            this.tabControlZonaDetalle.Name = "tabControlZonaDetalle";
            this.tabControlZonaDetalle.SelectedIndex = 0;
            this.tabControlZonaDetalle.Size = new System.Drawing.Size(894, 95);
            this.tabControlZonaDetalle.TabIndex = 36;
            // 
            // tabPageVentaNormal
            // 
            this.tabPageVentaNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPageVentaNormal.Controls.Add(this.txtDescuento);
            this.tabPageVentaNormal.Controls.Add(this.txtCodigo);
            this.tabPageVentaNormal.Controls.Add(this.txtPrecio);
            this.tabPageVentaNormal.Controls.Add(this.txtCantidad);
            this.tabPageVentaNormal.Controls.Add(this.txtTotalLinea);
            this.tabPageVentaNormal.Controls.Add(this.txtDescripcion);
            this.tabPageVentaNormal.Controls.Add(this.label13);
            this.tabPageVentaNormal.Controls.Add(this.txtTipoDescuento);
            this.tabPageVentaNormal.Controls.Add(this.label29);
            this.tabPageVentaNormal.Controls.Add(this.txtSubTotalLinea);
            this.tabPageVentaNormal.Controls.Add(this.label19);
            this.tabPageVentaNormal.Controls.Add(this.btnLimpiaLineaDetalle);
            this.tabPageVentaNormal.Controls.Add(this.label17);
            this.tabPageVentaNormal.Controls.Add(this.cmbBodega);
            this.tabPageVentaNormal.Controls.Add(this.txtLinea);
            this.tabPageVentaNormal.Controls.Add(this.cmbListaPrecio);
            this.tabPageVentaNormal.Controls.Add(this.panel4);
            this.tabPageVentaNormal.Controls.Add(this.label15);
            this.tabPageVentaNormal.Controls.Add(this.panel3);
            this.tabPageVentaNormal.Controls.Add(this.label28);
            this.tabPageVentaNormal.Controls.Add(this.txtPorcDescuentoLinea);
            this.tabPageVentaNormal.Controls.Add(this.label31);
            this.tabPageVentaNormal.Controls.Add(this.label14);
            this.tabPageVentaNormal.Controls.Add(this.label20);
            this.tabPageVentaNormal.Controls.Add(this.chkCantidadFija);
            this.tabPageVentaNormal.Location = new System.Drawing.Point(4, 22);
            this.tabPageVentaNormal.Name = "tabPageVentaNormal";
            this.tabPageVentaNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentaNormal.Size = new System.Drawing.Size(886, 69);
            this.tabPageVentaNormal.TabIndex = 0;
            this.tabPageVentaNormal.Text = "Venta Normal";
            // 
            // tabPageVentaRapida
            // 
            this.tabPageVentaRapida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.tabPageVentaRapida.Controls.Add(this.label9);
            this.tabPageVentaRapida.Controls.Add(this.label11);
            this.tabPageVentaRapida.Controls.Add(this.label12);
            this.tabPageVentaRapida.Controls.Add(this.txtDescripcionCopia);
            this.tabPageVentaRapida.Controls.Add(this.txtCodigoRapido);
            this.tabPageVentaRapida.Controls.Add(this.btnRepiteCodigo);
            this.tabPageVentaRapida.Controls.Add(this.panel2);
            this.tabPageVentaRapida.Location = new System.Drawing.Point(4, 22);
            this.tabPageVentaRapida.Name = "tabPageVentaRapida";
            this.tabPageVentaRapida.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentaRapida.Size = new System.Drawing.Size(886, 69);
            this.tabPageVentaRapida.TabIndex = 1;
            this.tabPageVentaRapida.Text = "Venta Rapida";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiaDetalle);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnModificaLinea);
            this.panel1.Location = new System.Drawing.Point(696, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 28);
            this.panel1.TabIndex = 44;
            // 
            // panelNumeroOperacion
            // 
            this.panelNumeroOperacion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelNumeroOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNumeroOperacion.Controls.Add(this.btnCancelarNumOperacion);
            this.panelNumeroOperacion.Controls.Add(this.btnAceptarNumOperacion);
            this.panelNumeroOperacion.Controls.Add(this.label21);
            this.panelNumeroOperacion.Controls.Add(this.txtNumeroOperacion);
            this.panelNumeroOperacion.Location = new System.Drawing.Point(358, 127);
            this.panelNumeroOperacion.Name = "panelNumeroOperacion";
            this.panelNumeroOperacion.Size = new System.Drawing.Size(241, 144);
            this.panelNumeroOperacion.TabIndex = 45;
            // 
            // btnCancelarNumOperacion
            // 
            this.btnCancelarNumOperacion.Location = new System.Drawing.Point(125, 83);
            this.btnCancelarNumOperacion.Name = "btnCancelarNumOperacion";
            this.btnCancelarNumOperacion.Size = new System.Drawing.Size(65, 23);
            this.btnCancelarNumOperacion.TabIndex = 3;
            this.btnCancelarNumOperacion.Text = "Cancelar";
            this.btnCancelarNumOperacion.UseVisualStyleBackColor = true;
            this.btnCancelarNumOperacion.Click += new System.EventHandler(this.btnCancelarNumOperacion_Click);
            // 
            // btnAceptarNumOperacion
            // 
            this.btnAceptarNumOperacion.Location = new System.Drawing.Point(51, 83);
            this.btnAceptarNumOperacion.Name = "btnAceptarNumOperacion";
            this.btnAceptarNumOperacion.Size = new System.Drawing.Size(65, 23);
            this.btnAceptarNumOperacion.TabIndex = 2;
            this.btnAceptarNumOperacion.Text = "Aceptar";
            this.btnAceptarNumOperacion.UseVisualStyleBackColor = true;
            this.btnAceptarNumOperacion.Click += new System.EventHandler(this.btnAceptarNumOperacion_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(26, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(199, 15);
            this.label21.TabIndex = 1;
            this.label21.Text = "N° DE OPERACION VOUCHER";
            // 
            // txtNumeroOperacion
            // 
            this.txtNumeroOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOperacion.Location = new System.Drawing.Point(51, 58);
            this.txtNumeroOperacion.Name = "txtNumeroOperacion";
            this.txtNumeroOperacion.Size = new System.Drawing.Size(138, 21);
            this.txtNumeroOperacion.TabIndex = 0;
            this.txtNumeroOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(601, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 92);
            this.panel5.TabIndex = 46;
            this.panel5.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(21, 15);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(151, 16);
            this.label34.TabIndex = 50;
            this.label34.Text = "Ingrese N° Vale POS";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(24, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 13);
            this.label25.TabIndex = 49;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 48;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(206, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtvoucher
            // 
            this.txtvoucher.Location = new System.Drawing.Point(783, 42);
            this.txtvoucher.Name = "txtvoucher";
            this.txtvoucher.Size = new System.Drawing.Size(109, 20);
            this.txtvoucher.TabIndex = 47;
            this.txtvoucher.Visible = false;
            // 
            // frmBoleta
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.txtvoucher);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelNumeroOperacion);
            this.Controls.Add(this.pnlCotizacionBuscar);
            this.Controls.Add(this.panelFolio);
            this.Controls.Add(this.txtOrdenCompra);
            this.Controls.Add(this.panelNotaVenta);
            this.Controls.Add(this.pnlBuscaClienteDes);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.txtComanda);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblGarzon);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.cmbGarzon);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosVenta);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControlZonaDetalle);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.gbZonaOtros);
            this.Controls.Add(this.gbZonaFechas);
            this.Controls.Add(this.gbZonaCliente);
            this.Controls.Add(this.gbZonaBotones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBoleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boleta de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFactura_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFactura_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbZonaCliente.ResumeLayout(false);
            this.gbZonaCliente.PerformLayout();
            this.gbZonaFechas.ResumeLayout(false);
            this.gbZonaBotones.ResumeLayout(false);
            this.gbZonaBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            this.gbZonaOtros.ResumeLayout(false);
            this.gbZonaOtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).EndInit();
            this.pnlBuscaClienteDes.ResumeLayout(false);
            this.panelFolio.ResumeLayout(false);
            this.panelFolio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelVuelto.ResumeLayout(false);
            this.panelVuelto.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlCotizacionBuscar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelNotaVenta.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControlZonaDetalle.ResumeLayout(false);
            this.tabPageVentaNormal.ResumeLayout(false);
            this.tabPageVentaNormal.PerformLayout();
            this.tabPageVentaRapida.ResumeLayout(false);
            this.tabPageVentaRapida.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelNumeroOperacion.ResumeLayout(false);
            this.panelNumeroOperacion.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (this.textBox1.Text.Trim().Length > 0)
        {
            this.buscaBoletaVoucher(this.textBox1.Text.Trim());
            panel5.Visible = false;
        }
        else
        {
            int num = (int)MessageBox.Show("Debe Ingresar un Numero de Voucher a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.textBox1.Focus();

        }
    }

    private void buscarVoucherToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.panel5.Visible = true;
        this.textBox1.Clear();
        this.textBox1.Focus();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {

        if (e.KeyCode != Keys.Return)
            return;
        if (this.textBox1.Text.Trim().Length > 0)
        {
            this.buscaBoletaVoucher(this.textBox1.Text.Trim());
            panel5.Visible = false;
        }
        else
        {
            int num = (int)MessageBox.Show("Debe Ingresar un Numero de Voucher a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.textBox1.Focus();

        }
    }

    private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtSubTotal_TextChanged(object sender, EventArgs e)
    {
        if (txtSubTotal.Text.Length != 0)
        {
           txtSubTotal.Text=  redondea(Convert.ToDecimal(txtSubTotal.Text)).ToString("N0");
        }
    }

    private void txtTotalExento_TextChanged(object sender, EventArgs e)
    {
        if (txtTotalExento.Text.Length != 0)
        {
            txtTotalExento.Text = redondea(Convert.ToDecimal(txtTotalExento.Text)).ToString("N0");
        }
    }

    private void txtTotalCobrar_TextChanged(object sender, EventArgs e)
    {
        if (txtTotalCobrar.Text.Length != 0)
        {
            txtTotalCobrar.Text = redondea(Convert.ToDecimal(txtTotalCobrar.Text)).ToString("N0");
        }
    }
  }
}
