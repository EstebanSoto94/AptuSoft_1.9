 
// Type: Aptusoft.frmComanda
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
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
  public class frmComanda : Form
  {
    private List<DatosVentaVO> lista = new List<DatosVentaVO>();
    private List<ProductoAuxiliar> listaAuxiliar = new List<ProductoAuxiliar>();
    private List<MesaVO> listaMesas = new List<MesaVO>();
    private bool _modBodega = false;
    private int noVender = 0;
    private Decimal stock = new Decimal(0);
    private Venta veOBTicket = new Venta();
    private int idImpuesto = 0;
    private Decimal netoLinea = new Decimal(0);
    private Decimal valorCompra = new Decimal(0);
    private List<ImpuestoVO> listaImpuestos = new List<ImpuestoVO>();
    private OpcionesDocumentosVO odVO = new OpcionesDocumentosVO();
    private List<VendedorVO> listaVendedores = new List<VendedorVO>();
    private List<VendedorVO> listaGarzones = new List<VendedorVO>();
    private List<MedioPagoVO> listaMediosPago = new List<MedioPagoVO>();
    private List<CentroCostoVO> listaCentroCosto = new List<CentroCostoVO>();
    private Decimal ivaInicio = new Decimal(0);
    private bool verificaCreditoActivo = false;
    private bool impideVenta = false;
    private string _mesa = "";
    private string _tipoSolicitud = "";
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private bool _anula = false;
    private bool _descuento = false;
    private bool _cambioPrecio = false;
    private int _caja = 0;
    private int _bodega = 0;
    private int _listaPrecio = 0;
    private IContainer components = (IContainer) null;
    private frmComanda intance;
    private int codigoCliente;
    private int idComanda;
    private string alertaStock;
    private string numeroLineas;
    private string decimalesValoresVenta;
    private string impideVentasSinStock;
    private int c1;
    private int c2;
    private int c3;
    private int c4;
    private int c5;
    private int c6;
    private int c7;
    private int c8;
    private int c9;
    private string p1;
    private string p2;
    private string p3;
    private string p4;
    private string p5;
    private string p6;
    private string p7;
    private string p8;
    private string p9;
    private string p10;
    private string p11;
    private string p12;
    private string p13;
    private string p14;
    private string p15;
    private string p16;
    private string p17;
    private string p18;
    private string p19;
    private string p20;
    private string p21;
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
    private TextBox txtContacto;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label8;
    private Label label7;
    private Label label6;
    private TextBox txtFax;
    private TextBox txtFono;
    private TextBox txtCiudad;
    private TextBox txtComuna;
    private TextBox txtDireccion;
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
    private Label lblFolio;
    private TextBox txtNumeroDocumento;
    private Label label1;
    private DateTimePicker dtpEmision;
    private GroupBox gbZonaBotones;
    private TextBox txtSubTotal;
    private TextBox txtTotalGeneral;
    private TextBox txtIva;
    private TextBox txtNeto;
    private TextBox txtTotalDescuento;
    private TextBox txtPorcDescuentoTotal;
    private Label label26;
    private Label label25;
    private Label label24;
    private Label label23;
    private Label label22;
    private DataGridView dgvDatosVenta;
    private TextBox txtPorIva;
    private Label label27;
    private ComboBox cmbGarzones;
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
    private Panel panelZonaDetalle;
    private Button btnBuscaCliente;
    private Label label18;
    private ComboBox cmbMedioPago;
    private TextBox txtPorcDescuentoLinea;
    private Label label31;
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
    private Button btnImprime;
    private Label label3;
    private ToolStripMenuItem cambiarNumeroDeFolioToolStripMenuItem;
    private Label lblTipoDoc;
    private GroupBox groupBox1;
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
    private Panel panelCliente;
    private Label label9;
    private TextBox txtGiro;
    private Panel panelMesa;
    private Label lblEstado;
    private ComboBox cmbGarzon;
    private ComboBox cmbMesa;
    private Button btnCambiarMesa;
    private RadioButton rdbLlevar;
    private RadioButton rdbDomicilio;
    private TabControl tabControl1;
    private TabPage tabPageMesa;
    private TabPage tabPageCliente;
    private Button btnP21;
    private Button btnP20;
    private Button btnP19;
    private Button btnP18;
    private Button btnP17;
    private Button btnP16;
    private Button btnP15;
    private Button btnP14;
    private Button btnP13;
    private Button btnP12;
    private Button btnP11;
    private Button btnP10;
    private Button btnP9;
    private Button btnP8;
    private Button btnP7;
    private Button btnP6;
    private Button btnP5;
    private Button btnP4;
    private Button btnP3;
    private Button btnP2;
    private Button btnP1;
    private Button btnCat6;
    private Button btnCat5;
    private Button btnCat4;
    private Button btnCat3;
    private Button btnCat2;
    private Button btnCat1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private Button btnCat9;
    private Button btnCat8;
    private Button btnCat7;

    public frmComanda()
    {
      this.intance = this;
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.iniciaVenta();
    }

    public frmComanda(string tipo, string mesa, string estado, string garzon, int fol)
    {
      this.intance = this;
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.iniciaVenta();
      this._tipoSolicitud = tipo;
      if (tipo.Equals("MESA"))
      {
        this.panelMesa.Visible = true;
        this.panelCliente.Visible = true;
        this._mesa = mesa;
        this.cmbMesa.Text = mesa;
        this.lblEstado.Text = estado;
        this.cmbMesa.Enabled = false;
        if (garzon.Length > 0)
          this.cmbGarzon.Text = garzon;
        if (fol > 0)
          this.buscaComandaFolio(fol);
      }
      if (tipo.Equals("RESERVA"))
      {
        this.panelMesa.Visible = true;
        this.panelCliente.Visible = true;
        this.tabControl1.SelectedTab = this.tabPageCliente;
        this._mesa = mesa;
        this.cmbMesa.Text = mesa;
        this.lblEstado.Text = estado;
        this.cmbMesa.Enabled = false;
        if (garzon.Length > 0)
          this.cmbGarzon.Text = garzon;
        if (fol > 0)
          this.buscaComandaFolio(fol);
      }
      if (!tipo.Equals("LLEVAR"))
        return;
      this.panelMesa.Visible = true;
      this.panelCliente.Visible = true;
      this.rdbDomicilio.Visible = true;
      this.rdbLlevar.Visible = true;
      this.rdbLlevar.Checked = true;
      if (garzon.Length > 0)
        this.cmbGarzon.Text = garzon;
      if (fol > 0)
        this.buscaComandaFolio(fol);
      this.tabControl1.SelectedTab = this.tabPageCliente;
    }

    private void cargaMesas()
    {
      this.listaMesas = new Mesa().listaMesas();
      this.cmbMesa.DataSource = (object) this.listaMesas;
      this.cmbMesa.ValueMember = "IdMesa";
      this.cmbMesa.DisplayMember = "NombreMesa";
    }

    private void cargaMesasDisponibles()
    {
      List<MesaVO> list = new List<MesaVO>();
      foreach (MesaVO mesaVo in this.listaMesas)
      {
        if (mesaVo.NombreMesa.Equals(this._mesa))
          list.Add(mesaVo);
        if (mesaVo.Estado.Equals("DISPONIBLE"))
          list.Add(mesaVo);
      }
      this.cmbMesa.DataSource = (object) list;
      this.cmbMesa.ValueMember = "IdMesa";
      this.cmbMesa.DisplayMember = "NombreMesa";
      this.cmbMesa.Text = this._mesa;
    }

    private void cargaBotones()
    {
      List<BotonVO> list = new Boton().listaBotones("");
      if (list.Count <= 0)
        return;
      foreach (BotonVO botonVo in list)
      {
        if (botonVo.Nombre.Equals("btnCat1"))
        {
          this.btnCat1.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c1 = botonVo.IdTexto;
        }
        if (botonVo.Nombre.Equals("btnCat2"))
        {
          this.btnCat2.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c2 = botonVo.IdTexto;
        }
        if (botonVo.Nombre.Equals("btnCat3"))
        {
          this.btnCat3.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c3 = botonVo.IdTexto;
        }
        if (botonVo.Nombre.Equals("btnCat4"))
        {
          this.btnCat4.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c4 = botonVo.IdTexto;
        }
        if (botonVo.Nombre.Equals("btnCat5"))
        {
          this.btnCat5.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c5 = botonVo.IdTexto;
        }
        if (botonVo.Nombre.Equals("btnCat6"))
        {
          this.btnCat6.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c6 = botonVo.IdTexto;
        }
        if (botonVo.Nombre.Equals("btnCat7"))
        {
          this.btnCat7.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c7 = botonVo.IdTexto;
        }
        if (botonVo.Nombre.Equals("btnCat8"))
        {
          this.btnCat8.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c8 = botonVo.IdTexto;
        }
        if (botonVo.Nombre.Equals("btnCat9"))
        {
          this.btnCat9.Text = this.primeraLetraMayuscula(botonVo.TextoBoton.ToLower());
          this.c9 = botonVo.IdTexto;
        }
      }
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("COMANDA"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._anula = Convert.ToBoolean(usuarioVo.Anula);
          this._descuento = Convert.ToBoolean(usuarioVo.Descuento);
          this._cambioPrecio = Convert.ToBoolean(usuarioVo.CambioPrecio);
          this._caja = usuarioVo.IdCaja;
          this._bodega = usuarioVo.IdBodega;
          this._listaPrecio = usuarioVo.IdListaPrecio;
        }
      }
    }

    public void cargaOpcionesDocumentosInicio()
    {
      this.odVO = new OpcionesGenerales().rescataOpcionesDocumentosPorNombre("TICKET");
    }

    public void cargaOpcionesDocumentos()
    {
      this.alertaStock = this.odVO.AlertaStockInsuficiente;
      this.impideVentasSinStock = this.odVO.ImpideVentasSinStock;
      this.numeroLineas = this.odVO.CantidadLineasDocumento;
      this.decimalesValoresVenta = this.odVO.DecimalesValorVenta.ToString();
    }

    private void cargaGarzones()
    {
      this.cmbGarzon.DataSource = (object) this.listaGarzones;
      this.cmbGarzon.ValueMember = "idVendedor";
      this.cmbGarzon.DisplayMember = "nombre";
      this.cmbGarzon.SelectedValue = (object) 0;
    }

    private void cargaGarzonesInicio()
    {
      this.listaGarzones = new Garzon().listaGarzonesVenta();
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
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void obtieneFolioTicketDisponible()
    {
      this.txtNumeroDocumento.Text = new Comanda().numeroComanda(this._caja).ToString();
    }

    private void obtieneFolioTicketDisponibleSinCaja()
    {
      this.txtNumeroDocumento.Text = new Comanda().numeroComandaSinCaja().ToString();
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

    private void cargaIvaInicio()
    {
      Calculos calculos = new Calculos();
      this.ivaInicio = calculos._iva;
      this.verificaCreditoActivo = calculos._verificaCredito;
      this.impideVenta = calculos._impedirVentasSinCredito;
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
        this.cargaGarzonesInicio();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Vendedores: " + ex.Message);
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
      this.cargaMediosPago();
      this.cmbMedioPago.Enabled = true;
      this.cargaGarzones();
      this.cargaMesas();
      this.cargaImpuestos();
      this.cargaBodega();
      this.cargaListaPrecio();
      this.codigoCliente = 0;
      this.cargaOpcionesDocumentos();
      this.txtPorIva.Text = this.ivaInicio.ToString("N0");
      this.cargaBotones();
      try
      {
        this.obtieneFolioTicketDisponible();
        this.txtNumeroDocumento.Enabled = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar Folio: " + ex.Message);
      }
      this.dtpEmision.Value = DateTime.Today;
      this.panelFolio.Visible = false;
      this.txtRut.Clear();
      this.txtDigito.Clear();
      this.txtRazonSocial.Clear();
      this.txtRazonSocial.Enabled = true;
      this.txtDireccion.Clear();
      this.txtCiudad.Clear();
      this.txtComuna.Clear();
      this.txtGiro.Clear();
      this.txtFono.Clear();
      this.txtFax.Clear();
      this.txtFax.Enabled = false;
      this.txtContacto.Clear();
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
      this.chkCantidadFija.Checked = false;
      this.txtSubTotal.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTotalImp1.Clear();
      this.txtTotalImp2.Clear();
      this.txtTotalImp3.Clear();
      this.txtTotalImp4.Clear();
      this.txtTotalImp5.Clear();
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnAnular.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnImprime.Enabled = false;
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
      this.lblTipoDoc.Text = "";
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.Columns.Clear();
      this.creaColumnasDetalle();
      this.idComanda = 0;
      this.valorCompra = new Decimal(0);
      this.lista.Clear();
      this.listaAuxiliar.Clear();
      this.limpiaEntradaDetalle();
      this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = true;
      this.gbZonaOtros.TabIndex = 0;
      this.tabControl1.TabIndex = 1;
      this.panelZonaDetalle.TabIndex = 2;
      this.gbZonaBotones.TabIndex = 3;
      this.gbZonaFechas.TabIndex = 4;
      this.panelFolio.TabIndex = 5;
      this.cmbMedioPago.Focus();
      this.ocultarBotonesProductos();
    }

    private void ocultarBotonesProductos()
    {
      this.btnP1.Visible = false;
      this.btnP2.Visible = false;
      this.btnP3.Visible = false;
      this.btnP4.Visible = false;
      this.btnP5.Visible = false;
      this.btnP6.Visible = false;
      this.btnP7.Visible = false;
      this.btnP8.Visible = false;
      this.btnP9.Visible = false;
      this.btnP10.Visible = false;
      this.btnP11.Visible = false;
      this.btnP12.Visible = false;
      this.btnP13.Visible = false;
      this.btnP14.Visible = false;
      this.btnP15.Visible = false;
      this.btnP16.Visible = false;
      this.btnP17.Visible = false;
      this.btnP18.Visible = false;
      this.btnP19.Visible = false;
      this.btnP20.Visible = false;
      this.btnP21.Visible = false;
      this.p1 = string.Empty;
      this.p2 = string.Empty;
      this.p3 = string.Empty;
      this.p4 = string.Empty;
      this.p5 = string.Empty;
      this.p6 = string.Empty;
      this.p7 = string.Empty;
      this.p8 = string.Empty;
      this.p9 = string.Empty;
      this.p10 = string.Empty;
      this.p11 = string.Empty;
      this.p12 = string.Empty;
      this.p13 = string.Empty;
      this.p14 = string.Empty;
      this.p15 = string.Empty;
      this.p16 = string.Empty;
      this.p17 = string.Empty;
      this.p18 = string.Empty;
      this.p19 = string.Empty;
      this.p20 = string.Empty;
      this.p21 = string.Empty;
    }

    private void creaColumnasDetalle()
    {
      this.dgvDatosVenta.AutoGenerateColumns = false;
      this.dgvDatosVenta.Columns.Add("Linea", "");
      this.dgvDatosVenta.Columns[0].DataPropertyName = "Linea";
      this.dgvDatosVenta.Columns[0].Width = 20;
      this.dgvDatosVenta.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
      this.dgvDatosVenta.Columns.Add("Codigo", "Codigo");
      this.dgvDatosVenta.Columns[1].DataPropertyName = "Codigo";
      this.dgvDatosVenta.Columns[1].Width = 100;
      this.dgvDatosVenta.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Descripcion", "Descripcion");
      this.dgvDatosVenta.Columns[2].DataPropertyName = "Descripcion";
      this.dgvDatosVenta.Columns[2].Width = 257;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Impreso", "Impreso");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "Impreso";
      this.dgvDatosVenta.Columns[3].Width = 60;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("ValorVenta", "Precio");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "ValorVenta";
      this.dgvDatosVenta.Columns[4].Width = 80;
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Cantidad", "Cantidad");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "Cantidad";
      this.dgvDatosVenta.Columns[5].Width = 80;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Format = "N4";
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("PorcDescuento", "% Desc.");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "PorcDescuento";
      this.dgvDatosVenta.Columns[6].Width = 60;
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Format = "N0";
      this.dgvDatosVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[6].Visible = false;
      this.dgvDatosVenta.Columns.Add("Descuento", "$ Desc.");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "Descuento";
      this.dgvDatosVenta.Columns[7].Width = 70;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[7].Visible = false;
      this.dgvDatosVenta.Columns.Add("Total", "Total");
      this.dgvDatosVenta.Columns[8].DataPropertyName = "TotalLinea";
      this.dgvDatosVenta.Columns[8].Width = 90;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("SubTotal", "SubTotal");
      this.dgvDatosVenta.Columns[9].DataPropertyName = "SubTotalLinea";
      this.dgvDatosVenta.Columns[9].Width = 90;
      this.dgvDatosVenta.Columns[9].DefaultCellStyle.Format = "C" + this.decimalesValoresVenta;
      this.dgvDatosVenta.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[9].Visible = false;
      this.dgvDatosVenta.Columns.Add("TipoDescuento", "TipoDescuento");
      this.dgvDatosVenta.Columns[10].DataPropertyName = "TipoDescuento";
      this.dgvDatosVenta.Columns[10].Width = 90;
      this.dgvDatosVenta.Columns[10].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[10].Visible = false;
      this.dgvDatosVenta.Columns.Add("ListaPrecio", "ListaPrecio");
      this.dgvDatosVenta.Columns[11].DataPropertyName = "ListaPrecio";
      this.dgvDatosVenta.Columns[11].Width = 90;
      this.dgvDatosVenta.Columns[11].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[11].Visible = false;
      this.dgvDatosVenta.Columns.Add("Bodega", "Bodega");
      this.dgvDatosVenta.Columns[12].DataPropertyName = "Bodega";
      this.dgvDatosVenta.Columns[12].Width = 90;
      this.dgvDatosVenta.Columns[12].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[12].Visible = false;
      this.dgvDatosVenta.Columns.Add("FolioFactura", "FolioFactura");
      this.dgvDatosVenta.Columns[13].DataPropertyName = "FolioFactura";
      this.dgvDatosVenta.Columns[13].Width = 90;
      this.dgvDatosVenta.Columns[13].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[13].Visible = false;
      this.dgvDatosVenta.Columns.Add("IdFactura", "IdFactura");
      this.dgvDatosVenta.Columns[14].DataPropertyName = "IdFactura";
      this.dgvDatosVenta.Columns[14].Width = 90;
      this.dgvDatosVenta.Columns[14].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[14].Visible = false;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Eliminar";
      viewButtonColumn.HeaderText = "Eliminar";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "X";
      viewButtonColumn.Width = 50;
      viewButtonColumn.DisplayIndex = 15;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn);
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
      this.dgvDatosVenta.Columns.Add("ValorCompra", "ValorCompra");
      this.dgvDatosVenta.Columns[18].DataPropertyName = "ValorCompra";
      this.dgvDatosVenta.Columns[18].Width = 90;
      this.dgvDatosVenta.Columns[18].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[18].Visible = false;
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modComanda = 0;
      this.Close();
      this.Dispose();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modComanda = 0;
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
        if (this.idImpuesto != 5)
          return;
        this.netoLinea = calculos.netoLinea(total, this.idImpuesto);
      }
      else
      {
        int num4 = (int) MessageBox.Show("El Descuento debe ser Menor al Total!!");
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
      Producto producto = new Producto();
      try
      {
        ProductoVO productoVo = producto.buscaCodigoProducto(cod);
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
              this.valorCompra = productoVo.ValorCompra;
              this.idImpuesto = productoVo.IdImpuesto;
              this.txtCantidad.Focus();
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
            this.idImpuesto = productoVo.IdImpuesto;
            this.valorCompra = productoVo.ValorCompra;
            this.txtCantidad.Focus();
          }
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe el Codigo Ingresado.");
          this.txtCodigo.Clear();
          this.txtCodigo.Focus();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error en: " + ex.Message);
      }
    }

    public void cantidad()
    {
      this.txtCantidad.Text = "1";
    }

    public void agregaLineaGrilla()
    {
      if (this.noVender != 0)
        return;
      this.txtTotalDescuento.ReadOnly = true;
      DatosVentaVO datosVentaVo = new DatosVentaVO();
      datosVentaVo.Codigo = this.txtCodigo.Text.Trim().ToUpper();
      datosVentaVo.Descripcion = this.txtDescripcion.Text.Trim().ToUpper();
      datosVentaVo.IdImpuesto = this.idImpuesto;
      datosVentaVo.NetoLinea = this.netoLinea;
      datosVentaVo.ValorCompra = this.valorCompra;
      datosVentaVo.Impreso = false;
      datosVentaVo.ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
      datosVentaVo.Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
      if (datosVentaVo.Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && this.txtCodigo.Text.Length > 0)
      {
        int num = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Imposible Hacer Venta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCantidad.Focus();
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
        if (this.lista.Count < Convert.ToInt32(this.numeroLineas))
        {
          if (this.lista.Count > 0)
          {
            bool flag = false;
            for (int index = 0; index < this.lista.Count; ++index)
            {
              if (datosVentaVo.Cantidad + this.lista[index].Cantidad > this.stock && this.impideVentasSinStock.Equals("1") && datosVentaVo.Bodega == this.lista[index].Bodega && datosVentaVo.Codigo == this.lista[index].Codigo)
              {
                int num2 = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()));
                this.txtCantidad.Focus();
                flag = true;
              }
              else if (datosVentaVo.Codigo.Length > 0 && datosVentaVo.Codigo == this.lista[index].Codigo && (datosVentaVo.ValorVenta == this.lista[index].ValorVenta && datosVentaVo.ListaPrecio == this.lista[index].ListaPrecio) && datosVentaVo.Bodega == this.lista[index].Bodega && datosVentaVo.Impreso == this.lista[index].Impreso)
              {
                flag = true;
                Calculos calculos = new Calculos();
                this.lista[index].Cantidad = this.lista[index].Cantidad + datosVentaVo.Cantidad;
                this.lista[index].PorcDescuento = new Decimal(0);
                Decimal cantidad = this.lista[index].Cantidad;
                Decimal valorVenta = this.lista[index].ValorVenta;
                Decimal num2 = new Decimal(0);
                Decimal descuento = this.lista[index].Descuento + datosVentaVo.Descuento;
                int tipoDescuento = this.lista[index].TipoDescuento;
                this.idImpuesto = Convert.ToInt32(this.lista[index].IdImpuesto.ToString());
                Decimal subTotal = calculos.subTotalLinea(valorVenta, cantidad);
                if (subTotal == new Decimal(0) || subTotal > descuento)
                {
                  this.lista[index].SubTotalLinea = subTotal;
                  this.lista[index].Descuento = descuento;
                  this.lista[index].TotalLinea = calculos.totalLinea(subTotal, descuento);
                  if (this.idImpuesto == 0)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, 0);
                  if (this.idImpuesto == 1)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 2)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 3)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 4)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  if (this.idImpuesto == 5)
                    this.netoLinea = calculos.netoLinea(this.lista[index].TotalLinea, this.idImpuesto);
                  this.lista[index].NetoLinea = this.netoLinea;
                }
                else
                {
                  int num3 = (int) MessageBox.Show("El Descuento debe ser Menor al Total!!");
                }
                index = Enumerable.Count<DatosVentaVO>((IEnumerable<DatosVentaVO>) this.lista);
                this.limpiaEntradaDetalle();
                this.calculaTotales();
                this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
              }
            }
            if (!flag)
            {
              this.lista.Add(datosVentaVo);
              this.limpiaEntradaDetalle();
              this.calculaTotales();
              this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
            }
          }
          else
          {
            this.lista.Add(datosVentaVo);
            this.limpiaEntradaDetalle();
            this.calculaTotales();
            this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
          }
        }
        else
        {
          int num4 = (int) MessageBox.Show("Se Alcanzo el Maximo de Lineas Soportadas Por este Documento.");
        }
      }
    }

    private void calculaTotales()
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      bool flag5 = false;
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
      for (int index = 0; index < this.lista.Count; ++index)
      {
        this.lista[index].Linea = index + 1;
        if (this.lista[index].IdImpuesto == 1)
          flag1 = true;
        if (this.lista[index].IdImpuesto == 2)
          flag2 = true;
        if (this.lista[index].IdImpuesto == 3)
          flag3 = true;
        if (this.lista[index].IdImpuesto == 4)
          flag4 = true;
        if (this.lista[index].IdImpuesto == 5)
          flag5 = true;
      }
      Calculos calculos = new Calculos();
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      ArrayList arrayList = new ArrayList();
      if (flag1 || flag2 || (flag3 || flag4) || flag5)
        arrayList = calculos.totalImpuestos(this.lista);
      Decimal num4;
      if (flag1)
      {
        TextBox textBox = this.txtTotalImp1;
        num4 = Convert.ToDecimal(arrayList[0].ToString());
        string str = num4.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp1.Text = "";
      if (flag2)
      {
        TextBox textBox = this.txtTotalImp2;
        num4 = Convert.ToDecimal(arrayList[1].ToString());
        string str = num4.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp2.Text = "";
      if (flag3)
      {
        TextBox textBox = this.txtTotalImp3;
        num4 = Convert.ToDecimal(arrayList[2].ToString());
        string str = num4.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp3.Text = "";
      if (flag4)
      {
        TextBox textBox = this.txtTotalImp4;
        num4 = Convert.ToDecimal(arrayList[3].ToString());
        string str = num4.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp4.Text = "";
      if (flag5)
      {
        TextBox textBox = this.txtTotalImp5;
        num4 = Convert.ToDecimal(arrayList[4].ToString());
        string str = num4.ToString("N" + this.decimalesValoresVenta);
        textBox.Text = str;
      }
      else
        this.txtTotalImp5.Text = "";
      this.txtTotalGeneral.Text = calculos.totalGeneral2(this.lista).ToString("N" + this.decimalesValoresVenta);
      this.txtTotalDescuento.Text = calculos.totalDescuento(this.lista).ToString("N" + this.decimalesValoresVenta);
      Decimal neto = calculos.totalNeto2(this.lista);
      TextBox textBox1 = this.txtSubTotal;
      num4 = calculos.totalSubTotal(this.lista);
      string str1 = num4.ToString("N" + this.decimalesValoresVenta);
      textBox1.Text = str1;
      TextBox textBox2 = this.txtIva;
      num4 = calculos.totalIva(neto);
      string str2 = num4.ToString("N" + this.decimalesValoresVenta);
      textBox2.Text = str2;
      this.txtNeto.Text = neto.ToString("N" + this.decimalesValoresVenta);
    }

    private void limpiaEntradaDetalle()
    {
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Enabled = true;
      this.btnLimpiaDetalle.Enabled = true;
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtPrecio.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      if (!this.chkCantidadFija.Checked)
        this.txtCantidad.Clear();
      this.txtDescuento.Clear();
      this.txtPorcDescuentoLinea.Clear();
      this.txtTotalLinea.Clear();
      this.txtCodigo.Focus();
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
        this.agregaLineaGrilla();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error:" + ex.Message);
      }
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0)
        return;
      e.Handled = false;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
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

    private void button7_Click(object sender, EventArgs e)
    {
      this.veOBTicket = new Venta();
      this.iniciaVenta();
    }

    private void btnLimpiaDetalle_Click(object sender, EventArgs e)
    {
      this.dgvDatosVenta.DataSource = (object) null;
      this.lista.Clear();
      this.txtSubTotal.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtTotalDescuento.Clear();
      this.txtPorcDescuentoTotal.Clear();
      this.txtTotalGeneral.Clear();
      this.txtTipoDescuento.Text = "0";
      this.txtSubTotalLinea.Clear();
      this.txtTotalImp1.Clear();
      this.txtTotalImp2.Clear();
      this.txtTotalImp3.Clear();
      this.txtTotalImp4.Clear();
      this.txtTotalImp5.Clear();
    }

    private void txtCantidad_Enter(object sender, EventArgs e)
    {
      if (!this.chkCantidadFija.Checked || this.txtCantidad.Text.Length <= 0 || this.txtDescripcion.Text.Length <= 0)
        return;
      this.agregaLineaGrilla();
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
        this.buscaCliente("rut");
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar");
        this.txtRut.Focus();
      }
      this.txtCodigo.Focus();
    }

    private void buscaCliente(string buscarPor)
    {
      ArrayList cli = new ArrayList();
      Cliente cliente = new Cliente();
      if (buscarPor.Equals("fono"))
        cli = cliente.buscaFonoCliente(this.txtFono.Text.Trim());
      if (buscarPor.Equals("rut"))
        cli = cliente.buscaRutCliente(this.txtRut.Text.Trim());
      if (cli.Count > 1)
      {
        this.txtRazonSocial.Enabled = false;
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "ticket").ShowDialog();
      }
      else if (cli.Count == 0)
      {
        if (MessageBox.Show("No Existe Cliente Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          if (buscarPor.Equals("rut"))
          {
            int num1 = (int) new frmClientes(this.txtRut.Text.Trim(), this.txtDigito.Text.Trim()).ShowDialog();
          }
          if (!buscarPor.Equals("fono"))
            return;
          int num2 = (int) new frmClientes(this.txtFono.Text).ShowDialog();
        }
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
      this.txtDireccion.Text = clienteVo.Direccion;
      this.txtComuna.Text = clienteVo.Comuna;
      this.txtCiudad.Text = clienteVo.Ciudad;
      this.txtGiro.Text = clienteVo.Giro;
      this.txtFono.Text = clienteVo.Telefono;
      this.txtFax.Text = clienteVo.Fax;
      this.txtContacto.Text = clienteVo.Contacto;
      this.cmbListaPrecio.SelectedValue = (object) clienteVo.ListaPrecio;
      if (clienteVo.IdMedioPago > 0)
        this.cmbMedioPago.SelectedValue = (object) clienteVo.IdMedioPago;
      if (clienteVo.Estado == 1)
      {
        int num = (int) MessageBox.Show("Cliente BLOQUEADO por: " + clienteVo.MotivoBloqueo + "\r\nSolo podra efecturar pagos en: " + this.cmbMedioPago.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      this.txtCodigo.Focus();
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "comanda").ShowDialog();
    }

    private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtDireccion.Focus();
    }

    private void txtRut_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtDigito.Focus();
    }

    private void frmFactura_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modComanda = 0;
    }

    private void guardaComanda()
    {
      if (!this.validaCampos())
        return;
      DateTime dateTime1 =DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local = @dateTime1;
      int year = this.dtpEmision.Value.Year;
      int month = this.dtpEmision.Value.Month;
      int day = this.dtpEmision.Value.Day;
      TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
      int hours = timeOfDay.Hours;
      DateTime now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int minutes = timeOfDay.Minutes;
      now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int seconds = timeOfDay.Seconds;
      // ISSUE: explicit reference operation
      local = new DateTime(year, month, day, hours, minutes, seconds);
      DateTime dateTime2 = dateTime1;
      Venta venta = new Venta();
      venta.Caja = this._caja;
      venta.FechaEmision = dateTime1;
      venta.FechaVencimiento = dateTime2;
      venta.IdCliente = this.codigoCliente;
      venta.Rut = this.txtRut.Text.Trim();
      venta.Digito = this.txtDigito.Text.Trim();
      venta.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
      venta.Direccion = this.txtDireccion.Text.Trim().ToUpper();
      venta.Comuna = this.txtComuna.Text.Trim().ToUpper();
      venta.Ciudad = this.txtCiudad.Text.Trim().ToUpper();
      venta.Giro = this.txtGiro.Text.Trim().ToUpper();
      venta.Fono = this.txtFono.Text.Trim();
      venta.Fax = this.txtFax.Text.Trim();
      venta.Contacto = this.txtContacto.Text.Trim().ToUpper();
      venta.DiasPlazo = 0;
      venta.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
      venta.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
      venta.IdVendedor = Convert.ToInt32(this.cmbGarzon.SelectedValue.ToString());
      venta.Vendedor = this.cmbGarzon.Text.ToString().ToUpper();
      venta.OrdenCompra = "0";
      venta.SubTotal = this.txtSubTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtSubTotal.Text.Trim()) : new Decimal(0);
      venta.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
      venta.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
      venta.PorcentajeIva = this.txtPorIva.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorIva.Text.Trim()) : new Decimal(0);
      venta.Iva = this.txtIva.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtIva.Text.Trim()) : new Decimal(0);
      venta.Neto = this.txtNeto.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtNeto.Text.Trim()) : new Decimal(0);
      venta.Total = this.txtTotalGeneral.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalGeneral.Text.Trim()) : new Decimal(0);
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
      venta.Mesa = !this._tipoSolicitud.Equals("LLEVAR") ? this.cmbMesa.Text : (!this.rdbLlevar.Checked ? "DOMICILIO" : "LLEVAR");
      venta.EstadoDocumento = "EMITIDO";
      Comanda comanda = new Comanda();
      if (comanda.existeComanda(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim())))
      {
        this.obtieneFolioTicketDisponible();
        if (this.txtNumeroDocumento.Text.Trim() == "1")
          this.obtieneFolioTicketDisponibleSinCaja();
      }
      venta.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
      for (int index = 0; index < this.lista.Count; ++index)
      {
        this.lista[index].FolioFactura = venta.Folio;
        this.lista[index].FechaIngreso = venta.FechaEmision;
      }
      this.imprimeComanda(venta, this.lista);
      comanda.agregaComanda(venta);
      comanda.agregaDetalleComanda(this.lista);
      if (this._tipoSolicitud.Equals("MESA"))
        new Mesa().cambiaEstadoMesa(this.cmbMesa.Text, "OCUPADA", this.txtNumeroDocumento.Text, this.cmbGarzon.Text);
      if (this._tipoSolicitud.Equals("RESERVA"))
        new Mesa().cambiaEstadoMesa(this.cmbMesa.Text, "RESERVADA", this.txtNumeroDocumento.Text, this.cmbGarzon.Text);
      Convert.ToInt32(this.txtNumeroDocumento.Text);
      this.iniciaVenta();
      this.Close();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaModifica();
    }

    private void guardarFacturaTeclaF2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.guardaModifica();
    }

    private void guardaModifica()
    {
      if (this.idComanda == 0)
        this.guardaComanda();
      else
        this.modificaComanda();
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

    private void modificaComanda()
    {
      if (MessageBox.Show("Esta Seguro de Modificar la Comanda", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (!this.validaCampos())
          return;
        DateTime dateTime1 =DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local = @dateTime1;
        DateTime now = this.dtpEmision.Value;
        int year = now.Year;
        now = this.dtpEmision.Value;
        int month = now.Month;
        now = this.dtpEmision.Value;
        int day = now.Day;
        now = DateTime.Now;
        int hours = now.TimeOfDay.Hours;
        now = DateTime.Now;
        int minutes = now.TimeOfDay.Minutes;
        now = DateTime.Now;
        int seconds = now.TimeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local = new DateTime(year, month, day, hours, minutes, seconds);
        DateTime dateTime2 = dateTime1;
        Venta venta = new Venta();
        venta.IdFactura = this.idComanda;
        venta.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        venta.FechaEmision = dateTime1;
        venta.FechaVencimiento = dateTime2;
        venta.IdCliente = this.codigoCliente;
        venta.Rut = this.txtRut.Text.Trim();
        venta.Digito = this.txtDigito.Text.Trim();
        venta.RazonSocial = this.txtRazonSocial.Text.Trim().ToUpper();
        venta.Direccion = this.txtDireccion.Text.Trim().ToUpper();
        venta.Comuna = this.txtComuna.Text.Trim().ToUpper();
        venta.Ciudad = this.txtCiudad.Text.Trim().ToUpper();
        venta.Giro = this.txtGiro.Text.Trim().ToUpper();
        venta.Fono = this.txtFono.Text.Trim();
        venta.Fax = this.txtFax.Text.Trim();
        venta.Contacto = this.txtContacto.Text.Trim().ToUpper();
        venta.DiasPlazo = 0;
        if (this.cmbGarzon.SelectedValue.ToString() != "0")
        {
          venta.IdVendedor = Convert.ToInt32(this.cmbGarzon.SelectedValue.ToString());
          venta.Vendedor = this.cmbGarzon.Text.ToString().ToUpper();
        }
        venta.IdMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        venta.MedioPago = this.cmbMedioPago.Text.ToString().ToUpper();
        venta.OrdenCompra = "";
        venta.SubTotal = Convert.ToDecimal(this.txtSubTotal.Text.Trim());
        venta.PorcentajeDescuento = this.txtPorcDescuentoTotal.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoTotal.Text.Trim()) : new Decimal(0);
        venta.Descuento = this.txtTotalDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDescuento.Text.Trim()) : new Decimal(0);
        venta.PorcentajeIva = Convert.ToDecimal(this.txtPorIva.Text.Trim());
        venta.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
        venta.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
        venta.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
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
        venta.Mesa = !this._tipoSolicitud.Equals("LLEVAR") ? this.cmbMesa.Text : (!this.rdbLlevar.Checked ? "DOMICILIO" : "LLEVAR");
        venta.EstadoPago = this.veOBTicket.EstadoPago;
        Comanda comanda = new Comanda();
        for (int index = 0; index < this.lista.Count; ++index)
          this.lista[index].FechaIngreso = venta.FechaEmision;
        this.imprimeComanda(venta, this.lista);
        string text = comanda.modificaComanda(venta, this.lista);
        if (this._tipoSolicitud.Equals("MESA"))
          new Mesa().cambiaEstadoMesa(this.cmbMesa.Text, "OCUPADA", this.txtNumeroDocumento.Text, this.cmbGarzon.Text);
        if (this._tipoSolicitud.Equals("RESERVA"))
          new Mesa().cambiaEstadoMesa(this.cmbMesa.Text, "RESERVADA", this.txtNumeroDocumento.Text, this.cmbGarzon.Text);
        int num = (int) MessageBox.Show(text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.Close();
      }
      else
      {
        int num = (int) MessageBox.Show("La Comanda NO fue Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      this.modificaComanda();
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
      if (this.cmbGarzon.SelectedValue == null || this.cmbGarzon.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Selecciona un Garzon", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.cmbMedioPago.Focus();
        return false;
      }
      if (this._tipoSolicitud != "RESERVA")
      {
        if (this.lista.Count == 0)
        {
          int num = (int) MessageBox.Show("Debe Ingresar Datos a Comanda", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtCodigo.Focus();
          return false;
        }
        if (Convert.ToDecimal(this.txtTotalGeneral.Text) <= new Decimal(0))
        {
          int num = (int) MessageBox.Show("Debe Ingresar Datos a Comanda", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtCodigo.Focus();
          return false;
        }
      }
      return true;
    }

    private void txtTotalDescuento_TextChanged(object sender, EventArgs e)
    {
      if (this.txtTotalDescuento.ReadOnly)
        return;
      Decimal num1 = new Decimal(0);
      bool flag = false;
      for (int index = 0; index < this.lista.Count; ++index)
      {
        if (this.lista[index].Descuento > new Decimal(0) || this.lista[index].PorcDescuento > new Decimal(0))
        {
          flag = true;
          num1 += this.lista[index].Descuento;
        }
      }
      if (flag && !this.txtTotalDescuento.ReadOnly)
      {
        if (MessageBox.Show("¿Hay Descuentos aplicados en la lista, Desea Eliminarlos e Ingresar un Descuento General?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          for (int index = 0; index < this.lista.Count; ++index)
          {
            this.lista[index].Descuento = new Decimal(0);
            this.lista[index].PorcDescuento = new Decimal(0);
            this.lista[index].TotalLinea = this.lista[index].ValorVenta * this.lista[index].Cantidad;
          }
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) this.lista;
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
        this.txtNeto.Text = num2.ToString("N" + this.decimalesValoresVenta);
        this.txtIva.Text = num3.ToString("N" + this.decimalesValoresVenta);
        this.txtTotalGeneral.Text = num4.ToString("N" + this.decimalesValoresVenta);
      }
      else
      {
        int num2 = (int) MessageBox.Show("El Descuento NO debe ser Mayor al SubTotal");
        this.txtTotalDescuento.Text = "0";
        this.txtPorcDescuentoTotal.Clear();
      }
    }

    private void txtTotalDescuento_DoubleClick(object sender, EventArgs e)
    {
      if (this.txtTotalImp1.Text.Length != 0 || this.txtTotalImp2.Text.Length != 0 || (this.txtTotalImp3.Text.Length != 0 || this.txtTotalImp4.Text.Length != 0) || this.txtTotalImp5.Text.Length != 0)
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
        for (int index = 0; index < this.lista.Count; ++index)
        {
          if (this.lista[index].Linea == Convert.ToInt32(this.txtLinea.Text))
          {
            this.lista[index].Codigo = this.txtCodigo.Text;
            this.lista[index].Descripcion = this.txtDescripcion.Text;
            this.lista[index].ValorVenta = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
            this.lista[index].Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
            this.lista[index].TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
            this.lista[index].Descuento = this.txtDescuento.Text.Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text) : new Decimal(0);
            this.lista[index].PorcDescuento = this.txtPorcDescuentoLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtPorcDescuentoLinea.Text) : new Decimal(0);
            this.lista[index].IdImpuesto = this.idImpuesto;
            this.lista[index].NetoLinea = this.netoLinea;
          }
        }
        this.dgvDatosVenta.DataSource = (object) null;
        this.dgvDatosVenta.DataSource = (object) this.lista;
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
      this.chkCantidadFija.Checked = false;
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
        int num = (int) new frmBuscaProductos("comanda", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
        this.txtCantidad.Focus();
      }
      if (e.KeyCode == Keys.F6)
      {
        this.panelFolio.Visible = true;
        this.txtFolioBuscar.Focus();
      }
      if (e.KeyCode != Keys.F2 || !this.btnGuardar.Enabled || !this._guarda)
        return;
      this.guardaComanda();
    }

    private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.txtCodigo.Focus();
      int num = (int)new frmBuscaProductos("comanda", ref this.intance, this.cmbBodega.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue), this._modBodega, this.decimalesValoresVenta).ShowDialog();
      this.txtCantidad.Focus();
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
      if (this.lista.Count <= 0)
        return;
      this.btnModificaLinea.Visible = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiaDetalle.Enabled = false;
      this.chkCantidadFija.Checked = false;
      this.txtCodigo.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Codigo"].Value.ToString();
      this.txtDescripcion.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Descripcion"].Value.ToString();
      this.txtPrecio.Text = Convert.ToDecimal(this.dgvDatosVenta.SelectedRows[0].Cells["ValorVenta"].Value.ToString()).ToString("##");
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
    }

    private void lblFolio_DoubleClick(object sender, EventArgs e)
    {
      this.panelFolio.Visible = true;
      this.txtFolioBuscar.Focus();
    }

    private void buscaComandaFolio(int folioComanda)
    {
      this.panelFolio.Visible = false;
      Comanda comanda = new Comanda();
      try
      {
        Venta venta = comanda.buscaComandaFolio(folioComanda);
        this.veOBTicket = venta;
        if (venta.IdFactura != 0)
        {
          this.iniciaVenta();
          this.cambiarNumeroDeFolioToolStripMenuItem.Enabled = false;
          this.idComanda = venta.IdFactura;
          this.dtpEmision.Value = Convert.ToDateTime(venta.FechaEmision.ToString());
          if (venta.IdVendedor != 0)
          {
            this.cmbGarzon.SelectedValue = (object) venta.IdVendedor.ToString();
            this.cmbGarzon.Text = venta.Vendedor.ToString();
          }
          else if (venta.IdVendedor == 0 && venta.Vendedor.Length > 0)
            this.cmbGarzon.Text = venta.Vendedor.ToString();
          if (venta.IdMedioPago != 0)
          {
            this.cmbMedioPago.SelectedValue = (object) venta.IdMedioPago.ToString();
            this.cmbMedioPago.Text = venta.MedioPago.ToString();
          }
          this.txtNumeroDocumento.Text = venta.Folio.ToString();
          this.codigoCliente = venta.IdCliente;
          this.txtRut.Text = venta.Rut;
          this.txtDigito.Text = venta.Digito;
          this.txtRazonSocial.Text = venta.RazonSocial.ToString();
          this.txtDireccion.Text = venta.Direccion.ToString();
          this.txtComuna.Text = venta.Comuna.ToString();
          this.txtCiudad.Text = venta.Ciudad.ToString();
          this.txtGiro.Text = venta.Giro.ToString();
          this.txtFono.Text = venta.Fono.ToString();
          this.txtFax.Text = venta.Fax.ToString();
          this.txtContacto.Text = venta.Contacto.ToString();
          this.txtSubTotal.Text = venta.SubTotal.ToString("N" + this.decimalesValoresVenta);
          TextBox textBox1 = this.txtTotalDescuento;
          Decimal num = venta.Descuento;
          string str1 = num.ToString("N" + this.decimalesValoresVenta);
          textBox1.Text = str1;
          TextBox textBox2 = this.txtPorcDescuentoTotal;
          num = venta.PorcentajeDescuento;
          string str2 = num.ToString("N0");
          textBox2.Text = str2;
          TextBox textBox3 = this.txtTotalDescuento;
          num = venta.Descuento;
          string str3 = num.ToString("N0");
          textBox3.Text = str3;
          TextBox textBox4 = this.txtNeto;
          num = venta.Neto;
          string str4 = num.ToString("N" + this.decimalesValoresVenta);
          textBox4.Text = str4;
          TextBox textBox5 = this.txtIva;
          num = venta.Iva;
          string str5 = num.ToString("N" + this.decimalesValoresVenta);
          textBox5.Text = str5;
          TextBox textBox6 = this.txtPorIva;
          num = venta.PorcentajeIva;
          string str6 = num.ToString("N0");
          textBox6.Text = str6;
          TextBox textBox7 = this.txtTotalGeneral;
          num = venta.Total;
          string str7 = num.ToString("N" + this.decimalesValoresVenta);
          textBox7.Text = str7;
          TextBox textBox8 = this.txtTotalImp1;
          num = venta.Impuesto1;
          string str8;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto1;
            str8 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str8 = "";
          textBox8.Text = str8;
          TextBox textBox9 = this.txtTotalImp2;
          num = venta.Impuesto2;
          string str9;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto2;
            str9 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str9 = "";
          textBox9.Text = str9;
          TextBox textBox10 = this.txtTotalImp3;
          num = venta.Impuesto3;
          string str10;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto3;
            str10 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str10 = "";
          textBox10.Text = str10;
          TextBox textBox11 = this.txtTotalImp4;
          num = venta.Impuesto4;
          string str11;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto4;
            str11 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str11 = "";
          textBox11.Text = str11;
          TextBox textBox12 = this.txtTotalImp5;
          num = venta.Impuesto5;
          string str12;
          if (!num.ToString("N" + this.decimalesValoresVenta).Equals("0"))
          {
            num = venta.Impuesto5;
            str12 = num.ToString("N" + this.decimalesValoresVenta);
          }
          else
            str12 = "";
          textBox12.Text = str12;
          if (venta.Mesa.Equals("LLEVAR") || venta.Mesa.Equals("DOMICILIO"))
          {
            this.panelCliente.Visible = true;
            this.panelMesa.Visible = true;
            this.rdbDomicilio.Visible = true;
            this.rdbLlevar.Visible = true;
            if (venta.Mesa.Equals("LLEVAR"))
            {
              this.rdbLlevar.Checked = true;
              this.rdbDomicilio.Checked = false;
            }
            else
            {
              this.rdbLlevar.Checked = false;
              this.rdbDomicilio.Checked = true;
            }
          }
          else
          {
            this.panelCliente.Visible = true;
            this.panelMesa.Visible = true;
            this.cmbMesa.Text = venta.Mesa;
            this.cmbMesa.Enabled = false;
            this.rdbDomicilio.Visible = false;
            this.rdbLlevar.Visible = false;
          }
          if (venta.EstadoDocumento.Equals("ANULADO"))
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
          }
          if (venta.DocumentoVenta == "FACTURA" || venta.DocumentoVenta == "FACTURA EXENTA" || (venta.DocumentoVenta == "BOLETA" || venta.DocumentoVenta == "NOTA VENTA") || venta.DocumentoVenta == "GUIA")
          {
            this.btnGuardar.Enabled = false;
            this.btnAnular.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnImprime.Enabled = true;
            this.lblTipoDoc.Text = venta.DocumentoVenta + (object) " FOLIO : " + (string) (object) venta.FolioDocumentoVenta;
          }
          this.lblEstadoDocumento.Text = venta.EstadoDocumento.ToString();
          this.lista = comanda.buscaDetalleComandaIDComanda(venta.IdFactura);
          if (this.lista.Count > 0)
          {
            this.cmbBodega.SelectedValue = (object) this.lista[0].Bodega;
            for (int index = 0; index < this.lista.Count; ++index)
              this.lista[index].Linea = index + 1;
            this.dgvDatosVenta.DataSource = (object) null;
            this.dgvDatosVenta.DataSource = (object) this.lista;
          }
          this.txtFolioBuscar.Clear();
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe Comanda Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.txtFolioBuscar.Clear();
          this.iniciaVenta();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al llamar Ticket " + ex.Message);
      }
    }

    private void btnBuscaFolio_Click(object sender, EventArgs e)
    {
      if (this.txtFolioBuscar.Text.Trim().Length > 0)
      {
        this.buscaComandaFolio(Convert.ToInt32(this.txtFolioBuscar.Text));
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Folio a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtFolioBuscar.Focus();
      }
    }

    private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPorcDescuentoLinea);
      if ((int) e.KeyChar != 13)
        return;
      if (this.txtFolioBuscar.Text.Trim().Length > 0)
      {
        this.buscaComandaFolio(Convert.ToInt32(this.txtFolioBuscar.Text));
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Folio a Buscar");
        this.txtFolioBuscar.Focus();
      }
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
      if (this.lblEstadoDocumento.Text.Equals("EMITIDO"))
      {
        if (MessageBox.Show("Esta seguro de Anular esta Comanda", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
        {
          Comanda comanda = new Comanda();
          try
          {
            int num = (int) MessageBox.Show(comanda.anulaComanda(this.idComanda, this.lista), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaVenta();
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show("Error al Anular Documento " + ex.Message);
          }
        }
        else
        {
          int num = (int) MessageBox.Show("La Comanda NO fue Anulada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
      if (!this.lblEstadoDocumento.Text.Equals("ANULADO"))
        return;
      if (MessageBox.Show("Esta seguro de Eliminar esta Comanda", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
      {
        Comanda comanda = new Comanda();
        try
        {
          comanda.eliminaComanda(this.idComanda);
          int num = (int) MessageBox.Show("Comanda Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaVenta();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar Documento " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Comanda NO fue Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaVenta();
      }
    }

    private void btnImprime_Click(object sender, EventArgs e)
    {
      this.imprimeComandaCompleta(this.veOBTicket, this.lista);
    }

    private void imprimeDirecto()
    {
      try
      {
        if (frmMenuPrincipal._MultiEmpresa)
          this.multiEmpresa();
        else
          this.monoEmpresa();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void multiEmpresa()
    {
      DataTable dataTable = new Ticket().muestraTicketFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
      LeeXml leeXml = new LeeXml();
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = leeXml.cargarDatosMultiEmpresa("ticket");
      string str1 = arrayList2[0].ToString();
      string str2 = arrayList2[1].ToString();
      ReportDocument reportDocument = new ReportDocument();
      reportDocument.Load("C:\\AptuSoft\\reportes\\Ticket_" + str2 + ".rpt");
      reportDocument.SetDataSource(dataTable);
      reportDocument.PrintOptions.PrinterName = str1;
      reportDocument.PrintToPrinter(1, false, 1, 1);
      reportDocument.Close();
      this.iniciaVenta();
    }

    private void monoEmpresa()
    {
      DataTable dataTable = new Ticket().muestraTicketFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
      ReportDocument reportDocument = new ReportDocument();
      reportDocument.Load("C:\\AptuSoft\\reportes\\Comanda.rpt");
      reportDocument.SetDataSource(dataTable);
      string str = new LeeXml().cargarDatos("ticket");
      reportDocument.PrintOptions.PrinterName = str;
      reportDocument.PrintToPrinter(1, false, 1, 1);
      reportDocument.Close();
      this.iniciaVenta();
    }

    private void imprimeComanda(Venta ve, List<DatosVentaVO> listita)
    {
      if (MessageBox.Show("Desea Imprimir la Comanda?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      Convert.ToInt32(this.txtNumeroDocumento.Text);
      DataTable dataTable = new DataTable();
      dataTable.Columns.Add("folio");
      dataTable.Columns.Add("fechaEmision");
      dataTable.Columns.Add("rut");
      dataTable.Columns.Add("digito");
      dataTable.Columns.Add("razonSocial");
      dataTable.Columns.Add("direccion");
      dataTable.Columns.Add("comuna");
      dataTable.Columns.Add("fono");
      dataTable.Columns.Add("contacto");
      dataTable.Columns.Add("medioPago");
      dataTable.Columns.Add("vendedor");
      dataTable.Columns.Add("iva");
      dataTable.Columns.Add("neto");
      dataTable.Columns.Add("total");
      dataTable.Columns.Add("caja");
      dataTable.Columns.Add("codigo");
      dataTable.Columns.Add("descripcion");
      dataTable.Columns.Add("valorVenta");
      dataTable.Columns.Add("cantidad");
      dataTable.Columns.Add("totalLinea");
      dataTable.Columns.Add("mesa");
      foreach (DatosVentaVO datosVentaVo in listita)
      {
        if (!datosVentaVo.Impreso)
        {
          DataRow row = dataTable.NewRow();
          row["folio"] = (object) datosVentaVo.FolioFactura;
          row["fechaEmision"] = (object) ve.FechaEmision;
          row["rut"] = (object) ve.Rut;
          row["digito"] = (object) ve.Digito;
          row["razonSocial"] = (object) ve.RazonSocial;
          row["direccion"] = (object) ve.Direccion;
          row["comuna"] = (object) ve.Comuna;
          row["fono"] = (object) ve.Fono;
          row["contacto"] = (object) ve.Contacto;
          row["medioPago"] = (object) ve.MedioPago;
          row["vendedor"] = (object) ve.Vendedor;
          row["iva"] = (object) ve.Iva;
          row["neto"] = (object) ve.Neto;
          row["total"] = (object) ve.Total;
          row["caja"] = (object) ve.Caja;
          row["mesa"] = (object) ve.Mesa;
          row["codigo"] = (object) datosVentaVo.Codigo;
          row["descripcion"] = (object) datosVentaVo.Descripcion;
          row["valorVenta"] = (object) datosVentaVo.ValorVenta;
          row["cantidad"] = (object) datosVentaVo.Cantidad;
          row["totalLinea"] = (object) datosVentaVo.TotalLinea;
          dataTable.Rows.Add(row);
        }
      }
      ReportDocument reportDocument = new ReportDocument();
      reportDocument.Load("C:\\AptuSoft\\reportes\\Comanda.rpt");
      reportDocument.SetDataSource(dataTable);
      string str = new LeeXml().cargarDatos("ticket");
      reportDocument.PrintOptions.PrinterName = str;
      reportDocument.PrintToPrinter(1, false, 1, 1);
      reportDocument.Close();
    }

    private void imprimeComandaCompleta(Venta ve, List<DatosVentaVO> listita)
    {
      if (MessageBox.Show("Desea Imprimir la Comanda?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        Convert.ToInt32(this.txtNumeroDocumento.Text);
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("folio");
        dataTable.Columns.Add("fechaEmision");
        dataTable.Columns.Add("rut");
        dataTable.Columns.Add("digito");
        dataTable.Columns.Add("razonSocial");
        dataTable.Columns.Add("direccion");
        dataTable.Columns.Add("comuna");
        dataTable.Columns.Add("fono");
        dataTable.Columns.Add("contacto");
        dataTable.Columns.Add("medioPago");
        dataTable.Columns.Add("vendedor");
        dataTable.Columns.Add("iva");
        dataTable.Columns.Add("neto");
        dataTable.Columns.Add("total");
        dataTable.Columns.Add("caja");
        dataTable.Columns.Add("codigo");
        dataTable.Columns.Add("descripcion");
        dataTable.Columns.Add("valorVenta");
        dataTable.Columns.Add("cantidad");
        dataTable.Columns.Add("totalLinea");
        dataTable.Columns.Add("mesa");
        foreach (DatosVentaVO datosVentaVo in listita)
        {
          DataRow row = dataTable.NewRow();
          row["folio"] = (object) datosVentaVo.FolioFactura;
          row["fechaEmision"] = (object) ve.FechaEmision;
          row["rut"] = (object) ve.Rut;
          row["digito"] = (object) ve.Digito;
          row["razonSocial"] = (object) ve.RazonSocial;
          row["direccion"] = (object) ve.Direccion;
          row["comuna"] = (object) ve.Comuna;
          row["fono"] = (object) ve.Fono;
          row["contacto"] = (object) ve.Contacto;
          row["medioPago"] = (object) ve.MedioPago;
          row["vendedor"] = (object) ve.Vendedor;
          row["iva"] = (object) ve.Iva;
          row["neto"] = (object) ve.Neto;
          row["total"] = (object) ve.Total;
          row["caja"] = (object) ve.Caja;
          row["mesa"] = (object) ve.Mesa;
          row["codigo"] = (object) datosVentaVo.Codigo;
          row["descripcion"] = (object) datosVentaVo.Descripcion;
          row["valorVenta"] = (object) datosVentaVo.ValorVenta;
          row["cantidad"] = (object) datosVentaVo.Cantidad;
          row["totalLinea"] = (object) datosVentaVo.TotalLinea;
          dataTable.Rows.Add(row);
        }
        ReportDocument reportDocument = new ReportDocument();
        reportDocument.Load("C:\\AptuSoft\\reportes\\Comanda.rpt");
        reportDocument.SetDataSource(dataTable);
        string str = new LeeXml().cargarDatos("ticket");
        reportDocument.PrintOptions.PrinterName = str;
        reportDocument.PrintToPrinter(1, false, 1, 1);
        reportDocument.Close();
      }
      else
        this.iniciaVenta();
    }

    private void txtTotalDescuento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtTotalDescuento);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(this.veOBTicket.RazonSocial);
    }

    private void dgvDatosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvDatosVenta.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      int num = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells[0].Value.ToString());
      for (int index = 0; index < this.lista.Count; ++index)
      {
        if (this.lista[index].Linea == num)
        {
          this.lista.RemoveAt(index);
          --index;
        }
      }
      this.calculaTotales();
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

    private void txtOrdenCompra_Leave(object sender, EventArgs e)
    {
    }

    private void txtPorcDescuentoTotal_DoubleClick(object sender, EventArgs e)
    {
      if (this.txtTotalImp1.Text.Length != 0 || this.txtTotalImp2.Text.Length != 0 || (this.txtTotalImp3.Text.Length != 0 || this.txtTotalImp4.Text.Length != 0) || this.txtTotalImp5.Text.Length != 0)
        return;
      this.txtPorcDescuentoTotal.ReadOnly = false;
    }

    private void cmbMesa_MouseDoubleClick(object sender, MouseEventArgs e)
    {
    }

    private void btnCambiarMesa_Click(object sender, EventArgs e)
    {
      this.cmbMesa.Enabled = true;
      this.cargaMesasDisponibles();
    }

    private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtComuna.Focus();
    }

    private void txtComuna_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtContacto.Focus();
    }

    private void txtContacto_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtFono.Focus();
    }

    public string primeraLetraMayuscula(string texto)
    {
      return texto.Substring(0, 1).ToUpper() + texto.Substring(1);
    }

    private void buscaProductosBotonera(int idCategoria)
    {
      this.ocultarBotonesProductos();
      List<ProductoVO> list = new Producto().listaProductosIdCategoria(idCategoria);
      if (list.Count <= 0)
        return;
      for (int index = 0; index < list.Count; ++index)
      {
        if (index < 21)
        {
          string str = list[index].Descripcion.Length > 20 ? list[index].Descripcion.Substring(0, 20) : list[index].Descripcion;
          if (index + 1 == 1)
          {
            this.btnP1.Visible = true;
            this.btnP1.Text = this.primeraLetraMayuscula(str.ToLower());
            this.p1 = list[index].Codigo;
          }
          if (index + 1 == 2)
          {
            this.btnP2.Visible = true;
            this.btnP2.Text = this.primeraLetraMayuscula(str.ToLower());
            this.p2 = list[index].Codigo;
          }
          if (index + 1 == 3)
          {
            this.btnP3.Visible = true;
            this.btnP3.Text = this.primeraLetraMayuscula(str.ToLower());
            this.p3 = list[index].Codigo;
          }
          if (index + 1 == 4)
          {
            this.btnP4.Visible = true;
            this.btnP4.Text = str.ToLowerInvariant();
            this.p4 = list[index].Codigo;
          }
          if (index + 1 == 5)
          {
            this.btnP5.Visible = true;
            this.btnP5.Text = str.ToLowerInvariant();
            this.p5 = list[index].Codigo;
          }
          if (index + 1 == 6)
          {
            this.btnP6.Visible = true;
            this.btnP6.Text = str.ToLowerInvariant();
            this.p6 = list[index].Codigo;
          }
          if (index + 1 == 7)
          {
            this.btnP7.Visible = true;
            this.btnP7.Text = str.ToLowerInvariant();
            this.p7 = list[index].Codigo;
          }
          if (index + 1 == 8)
          {
            this.btnP8.Visible = true;
            this.btnP8.Text = str.ToLowerInvariant();
            this.p8 = list[index].Codigo;
          }
          if (index + 1 == 9)
          {
            this.btnP9.Visible = true;
            this.btnP9.Text = str.ToLowerInvariant();
            this.p9 = list[index].Codigo;
          }
          if (index + 1 == 10)
          {
            this.btnP10.Visible = true;
            this.btnP10.Text = str.ToLowerInvariant();
            this.p10 = list[index].Codigo;
          }
          if (index + 1 == 11)
          {
            this.btnP11.Visible = true;
            this.btnP11.Text = str.ToLowerInvariant();
            this.p11 = list[index].Codigo;
          }
          if (index + 1 == 12)
          {
            this.btnP12.Visible = true;
            this.btnP12.Text = str.ToLowerInvariant();
            this.p12 = list[index].Codigo;
          }
          if (index + 1 == 13)
          {
            this.btnP13.Visible = true;
            this.btnP13.Text = str.ToLowerInvariant();
            this.p13 = list[index].Codigo;
          }
          if (index + 1 == 14)
          {
            this.btnP14.Visible = true;
            this.btnP14.Text = str.ToLowerInvariant();
            this.p14 = list[index].Codigo;
          }
          if (index + 1 == 15)
          {
            this.btnP15.Visible = true;
            this.btnP15.Text = str.ToLowerInvariant();
            this.p15 = list[index].Codigo;
          }
          if (index + 1 == 16)
          {
            this.btnP16.Visible = true;
            this.btnP16.Text = str.ToLowerInvariant();
            this.p16 = list[index].Codigo;
          }
          if (index + 1 == 17)
          {
            this.btnP17.Visible = true;
            this.btnP17.Text = str.ToLowerInvariant();
            this.p17 = list[index].Codigo;
          }
          if (index + 1 == 18)
          {
            this.btnP18.Visible = true;
            this.btnP18.Text = str.ToLowerInvariant();
            this.p18 = list[index].Codigo;
          }
          if (index + 1 == 19)
          {
            this.btnP19.Visible = true;
            this.btnP19.Text = str.ToLowerInvariant();
            this.p19 = list[index].Codigo;
          }
          if (index + 1 == 20)
          {
            this.btnP20.Visible = true;
            this.btnP20.Text = str.ToLowerInvariant();
            this.p20 = list[index].Codigo;
          }
          if (index + 1 == 21)
          {
            this.btnP21.Visible = true;
            this.btnP21.Text = str.ToLowerInvariant();
            this.p21 = list[index].Codigo;
          }
        }
        else
          index = list.Count;
      }
    }

    private void btnCat1_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c1);
    }

    private void btnCat2_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c2);
    }

    private void btnCat3_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c3);
    }

    private void btnCat4_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c4);
    }

    private void btnCat5_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c5);
    }

    private void btnCat6_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c6);
    }

    private void agregaProductoGrillaBoton(string cod)
    {
      int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      this.llamaProductoCodigo(cod, bodega);
      this.cantidad();
      this.agregaLineaGrilla();
    }

    private void btnP1_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p1);
    }

    private void btnP2_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p2);
    }

    private void btnP3_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p3);
    }

    private void btnP4_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p4);
    }

    private void btnP5_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p5);
    }

    private void btnP6_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p6);
    }

    private void btnP7_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p7);
    }

    private void btnP8_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p8);
    }

    private void btnP9_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p9);
    }

    private void btnP10_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p10);
    }

    private void btnP11_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p11);
    }

    private void btnP12_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p12);
    }

    private void btnP13_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p13);
    }

    private void btnP14_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p14);
    }

    private void btnP15_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p15);
    }

    private void btnP16_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p16);
    }

    private void btnP17_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p17);
    }

    private void btnP18_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p18);
    }

    private void btnP19_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p19);
    }

    private void btnP20_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p20);
    }

    private void btnP21_Click(object sender, EventArgs e)
    {
      this.agregaProductoGrillaBoton(this.p21);
    }

    private void btnCat7_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c7);
    }

    private void btnCat8_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c8);
    }

    private void btnCat9_Click(object sender, EventArgs e)
    {
      this.buscaProductosBotonera(this.c9);
    }

    private void txtFono_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtFono.Text.Length > 0)
      {
        this.buscaCliente("fono");
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar Fono a Buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtFono.Focus();
      }
      this.txtCodigo.Focus();
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
      this.menuStrip1 = new MenuStrip();
      this.archivoToolStripMenuItem = new ToolStripMenuItem();
      this.buscarProductosTeclaF4ToolStripMenuItem = new ToolStripMenuItem();
      this.buscarFacturaTeclaF6ToolStripMenuItem = new ToolStripMenuItem();
      this.cambiarNumeroDeFolioToolStripMenuItem = new ToolStripMenuItem();
      this.salirToolStripMenuItem = new ToolStripMenuItem();
      this.label17 = new Label();
      this.label19 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.txtCantidad = new TextBox();
      this.label13 = new Label();
      this.txtCodigo = new TextBox();
      this.label20 = new Label();
      this.txtDescripcion = new TextBox();
      this.txtTotalLinea = new TextBox();
      this.panelCliente = new Panel();
      this.txtRazonSocial = new TextBox();
      this.btnBuscaCliente = new Button();
      this.txtRut = new TextBox();
      this.txtContacto = new TextBox();
      this.txtDigito = new TextBox();
      this.label12 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label10 = new Label();
      this.txtDireccion = new TextBox();
      this.txtComuna = new TextBox();
      this.label7 = new Label();
      this.label6 = new Label();
      this.txtFono = new TextBox();
      this.panelMesa = new Panel();
      this.btnCambiarMesa = new Button();
      this.cmbMesa = new ComboBox();
      this.lblEstado = new Label();
      this.label11 = new Label();
      this.label8 = new Label();
      this.txtFax = new TextBox();
      this.txtCiudad = new TextBox();
      this.txtPrecio = new TextBox();
      this.txtDescuento = new TextBox();
      this.chkCantidadFija = new CheckBox();
      this.btnAgregar = new Button();
      this.btnLimpiaDetalle = new Button();
      this.gbZonaFechas = new GroupBox();
      this.dtpEmision = new DateTimePicker();
      this.label1 = new Label();
      this.txtNumeroDocumento = new TextBox();
      this.lblFolio = new Label();
      this.gbZonaBotones = new GroupBox();
      this.lblTipoDoc = new Label();
      this.label3 = new Label();
      this.btnImprime = new Button();
      this.lblEstadoDocumento = new Label();
      this.btnAnular = new Button();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnGuardar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.txtTotalGeneral = new TextBox();
      this.label26 = new Label();
      this.groupBox1 = new GroupBox();
      this.txtTotalImp5 = new TextBox();
      this.txtTotalImp3 = new TextBox();
      this.txtTotalImp4 = new TextBox();
      this.txtPorImp5 = new TextBox();
      this.txtPorImp3 = new TextBox();
      this.txtTotalImp2 = new TextBox();
      this.txtPorImp4 = new TextBox();
      this.txtPorImp2 = new TextBox();
      this.txtTotalImp1 = new TextBox();
      this.txtPorImp1 = new TextBox();
      this.lblImp5 = new Label();
      this.lblImp4 = new Label();
      this.lblImp3 = new Label();
      this.lblImp2 = new Label();
      this.lblImp1 = new Label();
      this.txtPorIva = new TextBox();
      this.txtSubTotal = new TextBox();
      this.txtIva = new TextBox();
      this.txtNeto = new TextBox();
      this.txtTotalDescuento = new TextBox();
      this.txtPorcDescuentoTotal = new TextBox();
      this.label25 = new Label();
      this.label24 = new Label();
      this.label23 = new Label();
      this.label22 = new Label();
      this.dgvDatosVenta = new DataGridView();
      this.label27 = new Label();
      this.gbZonaOtros = new GroupBox();
      this.cmbGarzon = new ComboBox();
      this.cmbMedioPago = new ComboBox();
      this.label18 = new Label();
      this.label28 = new Label();
      this.cmbBodega = new ComboBox();
      this.label29 = new Label();
      this.cmbListaPrecio = new ComboBox();
      this.panelZonaDetalle = new Panel();
      this.txtTipoDescuento = new TextBox();
      this.txtSubTotalLinea = new TextBox();
      this.btnLimpiaLineaDetalle = new Button();
      this.btnModificaLinea = new Button();
      this.txtLinea = new TextBox();
      this.txtPorcDescuentoLinea = new TextBox();
      this.label31 = new Label();
      this.panelFolio = new Panel();
      this.btnCerrarPanelFolio = new Button();
      this.btnBuscaFolio = new Button();
      this.txtFolioBuscar = new TextBox();
      this.label32 = new Label();
      this.label9 = new Label();
      this.txtGiro = new TextBox();
      this.rdbLlevar = new RadioButton();
      this.rdbDomicilio = new RadioButton();
      this.tabControl1 = new TabControl();
      this.tabPageMesa = new TabPage();
      this.tabPageCliente = new TabPage();
      this.btnCat1 = new Button();
      this.btnCat2 = new Button();
      this.btnCat3 = new Button();
      this.btnCat6 = new Button();
      this.btnCat5 = new Button();
      this.btnCat4 = new Button();
      this.btnP3 = new Button();
      this.btnP2 = new Button();
      this.btnP1 = new Button();
      this.btnP6 = new Button();
      this.btnP5 = new Button();
      this.btnP4 = new Button();
      this.btnP9 = new Button();
      this.btnP8 = new Button();
      this.btnP7 = new Button();
      this.btnP12 = new Button();
      this.btnP11 = new Button();
      this.btnP10 = new Button();
      this.btnP15 = new Button();
      this.btnP14 = new Button();
      this.btnP13 = new Button();
      this.btnP18 = new Button();
      this.btnP17 = new Button();
      this.btnP16 = new Button();
      this.btnP21 = new Button();
      this.btnP20 = new Button();
      this.btnP19 = new Button();
      this.groupBox2 = new GroupBox();
      this.btnCat9 = new Button();
      this.btnCat8 = new Button();
      this.btnCat7 = new Button();
      this.groupBox3 = new GroupBox();
      this.menuStrip1.SuspendLayout();
      this.panelCliente.SuspendLayout();
      this.panelMesa.SuspendLayout();
      this.gbZonaFechas.SuspendLayout();
      this.gbZonaBotones.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvDatosVenta).BeginInit();
      this.gbZonaOtros.SuspendLayout();
      this.panelZonaDetalle.SuspendLayout();
      this.panelFolio.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageMesa.SuspendLayout();
      this.tabPageCliente.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.menuStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.archivoToolStripMenuItem,
        (ToolStripItem) this.salirToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1016, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.buscarProductosTeclaF4ToolStripMenuItem,
        (ToolStripItem) this.buscarFacturaTeclaF6ToolStripMenuItem,
        (ToolStripItem) this.cambiarNumeroDeFolioToolStripMenuItem
      });
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new Size(60, 20);
      this.archivoToolStripMenuItem.Text = "Archivo";
      this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
      this.buscarProductosTeclaF4ToolStripMenuItem.Size = new Size(223, 22);
      this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
      this.buscarProductosTeclaF4ToolStripMenuItem.Click += new EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
      this.buscarFacturaTeclaF6ToolStripMenuItem.Name = "buscarFacturaTeclaF6ToolStripMenuItem";
      this.buscarFacturaTeclaF6ToolStripMenuItem.Size = new Size(223, 22);
      this.buscarFacturaTeclaF6ToolStripMenuItem.Text = "Buscar Comanda - tecla [F6]";
      this.buscarFacturaTeclaF6ToolStripMenuItem.Click += new EventHandler(this.buscarFacturaTeclaF6ToolStripMenuItem_Click);
      this.cambiarNumeroDeFolioToolStripMenuItem.Name = "cambiarNumeroDeFolioToolStripMenuItem";
      this.cambiarNumeroDeFolioToolStripMenuItem.Size = new Size(223, 22);
      this.cambiarNumeroDeFolioToolStripMenuItem.Text = "Cambiar Numero de Folio";
      this.cambiarNumeroDeFolioToolStripMenuItem.Click += new EventHandler(this.cambiarNumeroDeFolioToolStripMenuItem_Click);
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new Size(41, 20);
      this.salirToolStripMenuItem.Text = "Salir";
      this.salirToolStripMenuItem.Click += new EventHandler(this.salirToolStripMenuItem_Click);
      this.label17.BackColor = Color.FromArgb(64, 64, 64);
      this.label17.ForeColor = Color.White;
      this.label17.Location = new Point(559, 4);
      this.label17.Name = "label17";
      this.label17.Size = new Size(57, 23);
      this.label17.TabIndex = 4;
      this.label17.Text = "Cantidad";
      this.label17.TextAlign = ContentAlignment.TopCenter;
      this.label19.BackColor = Color.FromArgb(64, 64, 64);
      this.label19.ForeColor = Color.White;
      this.label19.Location = new Point(137, 647);
      this.label19.Name = "label19";
      this.label19.Size = new Size(77, 23);
      this.label19.TabIndex = 6;
      this.label19.Text = "$ Descuento";
      this.label19.TextAlign = ContentAlignment.TopCenter;
      this.label19.Visible = false;
      this.label15.BackColor = Color.FromArgb(64, 64, 64);
      this.label15.ForeColor = Color.White;
      this.label15.Location = new Point(481, 4);
      this.label15.Name = "label15";
      this.label15.Size = new Size(76, 23);
      this.label15.TabIndex = 2;
      this.label15.Text = "Precio";
      this.label15.TextAlign = ContentAlignment.TopCenter;
      this.label14.BackColor = Color.FromArgb(64, 64, 64);
      this.label14.ForeColor = Color.White;
      this.label14.Location = new Point(109, 4);
      this.label14.Name = "label14";
      this.label14.Size = new Size(368, 23);
      this.label14.TabIndex = 1;
      this.label14.Text = "Descripcion";
      this.label14.TextAlign = ContentAlignment.TopCenter;
      this.txtCantidad.BorderStyle = BorderStyle.FixedSingle;
      this.txtCantidad.Location = new Point(559, 18);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new Size(57, 20);
      this.txtCantidad.TabIndex = 12;
      this.txtCantidad.TextAlign = HorizontalAlignment.Right;
      this.txtCantidad.TextChanged += new EventHandler(this.txtCantidad_TextChanged);
      this.txtCantidad.Enter += new EventHandler(this.txtCantidad_Enter);
      this.txtCantidad.KeyDown += new KeyEventHandler(this.txtCantidad_KeyDown);
      this.txtCantidad.KeyPress += new KeyPressEventHandler(this.txtCantidad_KeyPress);
      this.label13.BackColor = Color.FromArgb(64, 64, 64);
      this.label13.ForeColor = Color.White;
      this.label13.Location = new Point(2, 4);
      this.label13.Name = "label13";
      this.label13.Size = new Size(101, 23);
      this.label13.TabIndex = 0;
      this.label13.Text = "Codigo";
      this.label13.TextAlign = ContentAlignment.TopCenter;
      this.txtCodigo.BorderStyle = BorderStyle.FixedSingle;
      this.txtCodigo.Location = new Point(2, 18);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new Size(101, 20);
      this.txtCodigo.TabIndex = 9;
      this.txtCodigo.KeyDown += new KeyEventHandler(this.txtCodigo_KeyDown);
      this.txtCodigo.KeyPress += new KeyPressEventHandler(this.txtCodigo_KeyPress);
      this.label20.BackColor = Color.FromArgb(64, 64, 64);
      this.label20.ForeColor = Color.White;
      this.label20.Location = new Point(640, 4);
      this.label20.Name = "label20";
      this.label20.Size = new Size(92, 23);
      this.label20.TabIndex = 7;
      this.label20.Text = "Total";
      this.label20.TextAlign = ContentAlignment.TopCenter;
      this.txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
      this.txtDescripcion.Location = new Point(109, 18);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(368, 20);
      this.txtDescripcion.TabIndex = 10;
      this.txtDescripcion.Enter += new EventHandler(this.txtDescripcion_Enter);
      this.txtDescripcion.KeyDown += new KeyEventHandler(this.txtDescripcion_KeyDown);
      this.txtTotalLinea.BackColor = Color.White;
      this.txtTotalLinea.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalLinea.Enabled = false;
      this.txtTotalLinea.Location = new Point(640, 18);
      this.txtTotalLinea.Name = "txtTotalLinea";
      this.txtTotalLinea.Size = new Size(92, 20);
      this.txtTotalLinea.TabIndex = 15;
      this.txtTotalLinea.TabStop = false;
      this.txtTotalLinea.TextAlign = HorizontalAlignment.Right;
      this.panelCliente.BackColor = Color.FromArgb(223, 233, 245);
      this.panelCliente.BorderStyle = BorderStyle.Fixed3D;
      this.panelCliente.Controls.Add((Control) this.txtRazonSocial);
      this.panelCliente.Controls.Add((Control) this.btnBuscaCliente);
      this.panelCliente.Controls.Add((Control) this.txtRut);
      this.panelCliente.Controls.Add((Control) this.txtContacto);
      this.panelCliente.Controls.Add((Control) this.txtDigito);
      this.panelCliente.Controls.Add((Control) this.label12);
      this.panelCliente.Controls.Add((Control) this.label4);
      this.panelCliente.Controls.Add((Control) this.label5);
      this.panelCliente.Controls.Add((Control) this.label10);
      this.panelCliente.Controls.Add((Control) this.txtDireccion);
      this.panelCliente.Controls.Add((Control) this.txtComuna);
      this.panelCliente.Controls.Add((Control) this.label7);
      this.panelCliente.Controls.Add((Control) this.label6);
      this.panelCliente.Controls.Add((Control) this.txtFono);
      this.panelCliente.Location = new Point(3, 6);
      this.panelCliente.Name = "panelCliente";
      this.panelCliente.Size = new Size(753, 82);
      this.panelCliente.TabIndex = 33;
      this.txtRazonSocial.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRazonSocial.Location = new Point(382, 5);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(336, 20);
      this.txtRazonSocial.TabIndex = 8;
      this.txtRazonSocial.KeyDown += new KeyEventHandler(this.txtRazonSocial_KeyDown);
      this.btnBuscaCliente.Location = new Point(625, 52);
      this.btnBuscaCliente.Name = "btnBuscaCliente";
      this.btnBuscaCliente.Size = new Size(93, 23);
      this.btnBuscaCliente.TabIndex = 32;
      this.btnBuscaCliente.TabStop = false;
      this.btnBuscaCliente.Text = "Buscar Cliente";
      this.btnBuscaCliente.UseVisualStyleBackColor = true;
      this.btnBuscaCliente.Click += new EventHandler(this.btnBuscaCliente_Click);
      this.txtRut.Location = new Point(220, 5);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(68, 20);
      this.txtRut.TabIndex = 6;
      this.txtRut.KeyDown += new KeyEventHandler(this.txtRut_KeyDown);
      this.txtContacto.BackColor = Color.White;
      this.txtContacto.Location = new Point(58, 49);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(230, 20);
      this.txtContacto.TabIndex = 11;
      this.txtContacto.TabStop = false;
      this.txtContacto.KeyDown += new KeyEventHandler(this.txtContacto_KeyDown);
      this.txtDigito.Location = new Point(290, 5);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 7;
      this.txtDigito.KeyPress += new KeyPressEventHandler(this.txtDigito_KeyPress);
      this.label12.AutoSize = true;
      this.label12.Location = new Point(4, 53);
      this.label12.Name = "label12";
      this.label12.Size = new Size(50, 13);
      this.label12.TabIndex = 17;
      this.label12.Text = "Contacto";
      this.label12.TextAlign = ContentAlignment.TopRight;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(186, 9);
      this.label4.Name = "label4";
      this.label4.Size = new Size(33, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "RUT";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(338, 9);
      this.label5.Name = "label5";
      this.label5.Size = new Size(39, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Cliente";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(2, 9);
      this.label10.Name = "label10";
      this.label10.Size = new Size(41, 13);
      this.label10.TabIndex = 15;
      this.label10.Text = "FONO";
      this.txtDireccion.BackColor = Color.White;
      this.txtDireccion.Location = new Point(58, 27);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new Size(412, 20);
      this.txtDireccion.TabIndex = 9;
      this.txtDireccion.TabStop = false;
      this.txtDireccion.KeyDown += new KeyEventHandler(this.txtDireccion_KeyDown);
      this.txtComuna.BackColor = Color.White;
      this.txtComuna.Location = new Point(540, 27);
      this.txtComuna.Name = "txtComuna";
      this.txtComuna.Size = new Size(176, 20);
      this.txtComuna.TabIndex = 10;
      this.txtComuna.TabStop = false;
      this.txtComuna.KeyDown += new KeyEventHandler(this.txtComuna_KeyDown);
      this.label7.AutoSize = true;
      this.label7.Location = new Point(487, 27);
      this.label7.Name = "label7";
      this.label7.Size = new Size(46, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Comuna";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(2, 31);
      this.label6.Name = "label6";
      this.label6.Size = new Size(52, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Dirección";
      this.label6.TextAlign = ContentAlignment.TopRight;
      this.txtFono.BackColor = Color.White;
      this.txtFono.Location = new Point(58, 5);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(116, 20);
      this.txtFono.TabIndex = 12;
      this.txtFono.TabStop = false;
      this.txtFono.KeyPress += new KeyPressEventHandler(this.txtFono_KeyPress);
      this.panelMesa.BackColor = Color.FromArgb(223, 233, 245);
      this.panelMesa.BorderStyle = BorderStyle.Fixed3D;
      this.panelMesa.Controls.Add((Control) this.btnCambiarMesa);
      this.panelMesa.Controls.Add((Control) this.cmbMesa);
      this.panelMesa.Controls.Add((Control) this.lblEstado);
      this.panelMesa.Location = new Point(3, 6);
      this.panelMesa.Name = "panelMesa";
      this.panelMesa.Size = new Size(751, 80);
      this.panelMesa.TabIndex = 34;
      this.btnCambiarMesa.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnCambiarMesa.Location = new Point(557, 15);
      this.btnCambiarMesa.Name = "btnCambiarMesa";
      this.btnCambiarMesa.Size = new Size(163, 32);
      this.btnCambiarMesa.TabIndex = 3;
      this.btnCambiarMesa.Text = "Cambiar de Mesa";
      this.btnCambiarMesa.UseVisualStyleBackColor = true;
      this.btnCambiarMesa.Click += new EventHandler(this.btnCambiarMesa_Click);
      this.cmbMesa.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMesa.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmbMesa.FormattingEnabled = true;
      this.cmbMesa.Location = new Point(16, 17);
      this.cmbMesa.Name = "cmbMesa";
      this.cmbMesa.Size = new Size(201, 32);
      this.cmbMesa.TabIndex = 2;
      this.cmbMesa.MouseDoubleClick += new MouseEventHandler(this.cmbMesa_MouseDoubleClick);
      this.lblEstado.AutoSize = true;
      this.lblEstado.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblEstado.Location = new Point(238, 21);
      this.lblEstado.Name = "lblEstado";
      this.lblEstado.Size = new Size(94, 24);
      this.lblEstado.TabIndex = 1;
      this.lblEstado.Text = "ESTADO";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(440, 682);
      this.label11.Name = "label11";
      this.label11.Size = new Size(24, 13);
      this.label11.TabIndex = 16;
      this.label11.Text = "Fax";
      this.label11.TextAlign = ContentAlignment.TopRight;
      this.label11.Visible = false;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(429, 660);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Ciudad";
      this.label8.TextAlign = ContentAlignment.TopRight;
      this.label8.Visible = false;
      this.txtFax.BackColor = Color.White;
      this.txtFax.Location = new Point(471, 678);
      this.txtFax.Name = "txtFax";
      this.txtFax.Size = new Size(176, 20);
      this.txtFax.TabIndex = 10;
      this.txtFax.TabStop = false;
      this.txtFax.Visible = false;
      this.txtCiudad.BackColor = Color.White;
      this.txtCiudad.Location = new Point(471, 656);
      this.txtCiudad.Name = "txtCiudad";
      this.txtCiudad.Size = new Size(176, 20);
      this.txtCiudad.TabIndex = 7;
      this.txtCiudad.TabStop = false;
      this.txtCiudad.Visible = false;
      this.txtPrecio.BorderStyle = BorderStyle.FixedSingle;
      this.txtPrecio.Location = new Point(481, 18);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.Size = new Size(76, 20);
      this.txtPrecio.TabIndex = 11;
      this.txtPrecio.TextAlign = HorizontalAlignment.Right;
      this.txtPrecio.TextChanged += new EventHandler(this.txtPrecio_TextChanged);
      this.txtPrecio.KeyDown += new KeyEventHandler(this.txtPrecio_KeyDown);
      this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress);
      this.txtDescuento.BorderStyle = BorderStyle.FixedSingle;
      this.txtDescuento.Location = new Point(137, 661);
      this.txtDescuento.Name = "txtDescuento";
      this.txtDescuento.Size = new Size(77, 20);
      this.txtDescuento.TabIndex = 14;
      this.txtDescuento.TextAlign = HorizontalAlignment.Right;
      this.txtDescuento.Visible = false;
      this.txtDescuento.TextChanged += new EventHandler(this.txtDescuento_TextChanged);
      this.txtDescuento.Enter += new EventHandler(this.txtDescuento_Enter);
      this.txtDescuento.KeyPress += new KeyPressEventHandler(this.txtDescuento_KeyPress);
      this.chkCantidadFija.AutoSize = true;
      this.chkCantidadFija.Location = new Point(618, 25);
      this.chkCantidadFija.Name = "chkCantidadFija";
      this.chkCantidadFija.Size = new Size(15, 14);
      this.chkCantidadFija.TabIndex = 16;
      this.chkCantidadFija.UseVisualStyleBackColor = true;
      this.chkCantidadFija.Click += new EventHandler(this.chkCantidadFija_Click);
      this.btnAgregar.Location = new Point(646, 40);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(55, 23);
      this.btnAgregar.TabIndex = 14;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.btnLimpiaDetalle.Location = new Point(704, 40);
      this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
      this.btnLimpiaDetalle.Size = new Size(55, 23);
      this.btnLimpiaDetalle.TabIndex = 16;
      this.btnLimpiaDetalle.Text = "Limpiar";
      this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaDetalle.Click += new EventHandler(this.btnLimpiaDetalle_Click);
      this.gbZonaFechas.Controls.Add((Control) this.dtpEmision);
      this.gbZonaFechas.Controls.Add((Control) this.label1);
      this.gbZonaFechas.Location = new Point(12, 18);
      this.gbZonaFechas.Name = "gbZonaFechas";
      this.gbZonaFechas.Size = new Size(119, 58);
      this.gbZonaFechas.TabIndex = 24;
      this.gbZonaFechas.TabStop = false;
      this.dtpEmision.Format = DateTimePickerFormat.Short;
      this.dtpEmision.Location = new Point(6, 29);
      this.dtpEmision.Name = "dtpEmision";
      this.dtpEmision.Size = new Size(104, 20);
      this.dtpEmision.TabIndex = 0;
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(8, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(102, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Emision";
      this.txtNumeroDocumento.BackColor = Color.White;
      this.txtNumeroDocumento.Location = new Point(662, 50);
      this.txtNumeroDocumento.Name = "txtNumeroDocumento";
      this.txtNumeroDocumento.Size = new Size(111, 20);
      this.txtNumeroDocumento.TabIndex = 16;
      this.txtNumeroDocumento.TabStop = false;
      this.txtNumeroDocumento.TextAlign = HorizontalAlignment.Right;
      this.txtNumeroDocumento.DoubleClick += new EventHandler(this.txtNumeroDocumento_DoubleClick);
      this.lblFolio.AutoSize = true;
      this.lblFolio.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFolio.Location = new Point(672, 31);
      this.lblFolio.Name = "lblFolio";
      this.lblFolio.Size = new Size(103, 16);
      this.lblFolio.TabIndex = 17;
      this.lblFolio.Text = "COMANDA N°";
      this.lblFolio.DoubleClick += new EventHandler(this.lblFolio_DoubleClick);
      this.gbZonaBotones.Controls.Add((Control) this.lblTipoDoc);
      this.gbZonaBotones.Controls.Add((Control) this.label3);
      this.gbZonaBotones.Controls.Add((Control) this.btnImprime);
      this.gbZonaBotones.Controls.Add((Control) this.lblEstadoDocumento);
      this.gbZonaBotones.Controls.Add((Control) this.btnAnular);
      this.gbZonaBotones.Controls.Add((Control) this.btnSalir);
      this.gbZonaBotones.Controls.Add((Control) this.btnLimpiar);
      this.gbZonaBotones.Controls.Add((Control) this.btnGuardar);
      this.gbZonaBotones.Controls.Add((Control) this.btnEliminar);
      this.gbZonaBotones.Controls.Add((Control) this.btnModificar);
      this.gbZonaBotones.Controls.Add((Control) this.txtTotalGeneral);
      this.gbZonaBotones.Controls.Add((Control) this.label26);
      this.gbZonaBotones.Location = new Point(12, 482);
      this.gbZonaBotones.Name = "gbZonaBotones";
      this.gbZonaBotones.Size = new Size(765, 121);
      this.gbZonaBotones.TabIndex = 28;
      this.gbZonaBotones.TabStop = false;
      this.gbZonaBotones.Enter += new EventHandler(this.groupBox1_Enter);
      this.lblTipoDoc.AutoSize = true;
      this.lblTipoDoc.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTipoDoc.ForeColor = Color.Red;
      this.lblTipoDoc.Location = new Point(6, 40);
      this.lblTipoDoc.Name = "lblTipoDoc";
      this.lblTipoDoc.Size = new Size(16, 24);
      this.lblTipoDoc.TabIndex = 29;
      this.lblTipoDoc.Text = ".";
      this.lblTipoDoc.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Red;
      this.label3.Location = new Point(5, 11);
      this.label3.Name = "label3";
      this.label3.Size = new Size(170, 33);
      this.label3.TabIndex = 28;
      this.label3.Text = "COMANDA";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.btnImprime.Location = new Point(6, 92);
      this.btnImprime.Name = "btnImprime";
      this.btnImprime.Size = new Size(88, 23);
      this.btnImprime.TabIndex = 26;
      this.btnImprime.Text = "RE-IMPRIMIR";
      this.btnImprime.UseVisualStyleBackColor = true;
      this.btnImprime.Click += new EventHandler(this.btnImprime_Click);
      this.lblEstadoDocumento.AutoSize = true;
      this.lblEstadoDocumento.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblEstadoDocumento.ForeColor = Color.Red;
      this.lblEstadoDocumento.Location = new Point(171, 11);
      this.lblEstadoDocumento.Name = "lblEstadoDocumento";
      this.lblEstadoDocumento.Size = new Size(140, 33);
      this.lblEstadoDocumento.TabIndex = 25;
      this.lblEstadoDocumento.Text = "ESTADO";
      this.lblEstadoDocumento.TextAlign = ContentAlignment.MiddleLeft;
      this.btnAnular.Location = new Point(184, 68);
      this.btnAnular.Name = "btnAnular";
      this.btnAnular.Size = new Size(88, 23);
      this.btnAnular.TabIndex = 24;
      this.btnAnular.Text = "ANULAR";
      this.btnAnular.UseVisualStyleBackColor = true;
      this.btnAnular.Click += new EventHandler(this.btnAnular_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(274, 92);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(88, 23);
      this.btnSalir.TabIndex = 23;
      this.btnSalir.Text = "SALIR";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Location = new Point(95, 92);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(88, 23);
      this.btnLimpiar.TabIndex = 22;
      this.btnLimpiar.Text = "LIMPIAR";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.button7_Click);
      this.btnGuardar.Location = new Point(6, 68);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(88, 23);
      this.btnGuardar.TabIndex = 19;
      this.btnGuardar.Text = "GUARDA [F2]";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnEliminar.Location = new Point(274, 68);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(88, 23);
      this.btnEliminar.TabIndex = 21;
      this.btnEliminar.Text = "ELIMINAR";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnModificar.Location = new Point(95, 68);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(88, 23);
      this.btnModificar.TabIndex = 20;
      this.btnModificar.Text = "MODIFICAR";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Visible = false;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.txtTotalGeneral.BackColor = Color.White;
      this.txtTotalGeneral.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalGeneral.Enabled = false;
      this.txtTotalGeneral.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalGeneral.Location = new Point(656, 26);
      this.txtTotalGeneral.Name = "txtTotalGeneral";
      this.txtTotalGeneral.Size = new Size(103, 29);
      this.txtTotalGeneral.TabIndex = 9;
      this.txtTotalGeneral.TabStop = false;
      this.txtTotalGeneral.TextAlign = HorizontalAlignment.Right;
      this.label26.AutoSize = true;
      this.label26.BackColor = Color.Transparent;
      this.label26.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.Black;
      this.label26.Location = new Point(576, 28);
      this.label26.Name = "label26";
      this.label26.Size = new Size(77, 24);
      this.label26.TabIndex = 4;
      this.label26.Text = "TOTAL";
      this.groupBox1.Controls.Add((Control) this.txtTotalImp5);
      this.groupBox1.Controls.Add((Control) this.txtTotalImp3);
      this.groupBox1.Controls.Add((Control) this.txtTotalImp4);
      this.groupBox1.Controls.Add((Control) this.txtPorImp5);
      this.groupBox1.Controls.Add((Control) this.txtPorImp3);
      this.groupBox1.Controls.Add((Control) this.txtTotalImp2);
      this.groupBox1.Controls.Add((Control) this.txtPorImp4);
      this.groupBox1.Controls.Add((Control) this.txtPorImp2);
      this.groupBox1.Controls.Add((Control) this.txtTotalImp1);
      this.groupBox1.Controls.Add((Control) this.txtPorImp1);
      this.groupBox1.Controls.Add((Control) this.lblImp5);
      this.groupBox1.Controls.Add((Control) this.lblImp4);
      this.groupBox1.Controls.Add((Control) this.lblImp3);
      this.groupBox1.Controls.Add((Control) this.lblImp2);
      this.groupBox1.Controls.Add((Control) this.lblImp1);
      this.groupBox1.Location = new Point(12, 640);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(68, 55);
      this.groupBox1.TabIndex = 33;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Impuestos Especiales";
      this.groupBox1.Visible = false;
      this.txtTotalImp5.BackColor = Color.White;
      this.txtTotalImp5.Enabled = false;
      this.txtTotalImp5.Location = new Point(141, 107);
      this.txtTotalImp5.Name = "txtTotalImp5";
      this.txtTotalImp5.Size = new Size(83, 20);
      this.txtTotalImp5.TabIndex = 38;
      this.txtTotalImp5.TextAlign = HorizontalAlignment.Right;
      this.txtTotalImp3.BackColor = Color.White;
      this.txtTotalImp3.Enabled = false;
      this.txtTotalImp3.Location = new Point(141, 63);
      this.txtTotalImp3.Name = "txtTotalImp3";
      this.txtTotalImp3.Size = new Size(83, 20);
      this.txtTotalImp3.TabIndex = 10;
      this.txtTotalImp3.TextAlign = HorizontalAlignment.Right;
      this.txtTotalImp4.BackColor = Color.White;
      this.txtTotalImp4.Enabled = false;
      this.txtTotalImp4.Location = new Point(141, 85);
      this.txtTotalImp4.Name = "txtTotalImp4";
      this.txtTotalImp4.Size = new Size(83, 20);
      this.txtTotalImp4.TabIndex = 36;
      this.txtTotalImp4.TextAlign = HorizontalAlignment.Right;
      this.txtPorImp5.BackColor = Color.White;
      this.txtPorImp5.Enabled = false;
      this.txtPorImp5.Location = new Point(90, 107);
      this.txtPorImp5.Name = "txtPorImp5";
      this.txtPorImp5.Size = new Size(47, 20);
      this.txtPorImp5.TabIndex = 37;
      this.txtPorImp5.TextAlign = HorizontalAlignment.Right;
      this.txtPorImp3.BackColor = Color.White;
      this.txtPorImp3.Enabled = false;
      this.txtPorImp3.Location = new Point(90, 63);
      this.txtPorImp3.Name = "txtPorImp3";
      this.txtPorImp3.Size = new Size(47, 20);
      this.txtPorImp3.TabIndex = 9;
      this.txtPorImp3.TextAlign = HorizontalAlignment.Right;
      this.txtTotalImp2.BackColor = Color.White;
      this.txtTotalImp2.Enabled = false;
      this.txtTotalImp2.Location = new Point(141, 41);
      this.txtTotalImp2.Name = "txtTotalImp2";
      this.txtTotalImp2.Size = new Size(83, 20);
      this.txtTotalImp2.TabIndex = 8;
      this.txtTotalImp2.TextAlign = HorizontalAlignment.Right;
      this.txtPorImp4.BackColor = Color.White;
      this.txtPorImp4.Enabled = false;
      this.txtPorImp4.Location = new Point(90, 85);
      this.txtPorImp4.Name = "txtPorImp4";
      this.txtPorImp4.Size = new Size(47, 20);
      this.txtPorImp4.TabIndex = 35;
      this.txtPorImp4.TextAlign = HorizontalAlignment.Right;
      this.txtPorImp2.BackColor = Color.White;
      this.txtPorImp2.Enabled = false;
      this.txtPorImp2.Location = new Point(90, 41);
      this.txtPorImp2.Name = "txtPorImp2";
      this.txtPorImp2.Size = new Size(47, 20);
      this.txtPorImp2.TabIndex = 7;
      this.txtPorImp2.TextAlign = HorizontalAlignment.Right;
      this.txtTotalImp1.BackColor = Color.White;
      this.txtTotalImp1.Enabled = false;
      this.txtTotalImp1.Location = new Point(141, 19);
      this.txtTotalImp1.Name = "txtTotalImp1";
      this.txtTotalImp1.Size = new Size(83, 20);
      this.txtTotalImp1.TabIndex = 6;
      this.txtTotalImp1.TextAlign = HorizontalAlignment.Right;
      this.txtPorImp1.BackColor = Color.White;
      this.txtPorImp1.Enabled = false;
      this.txtPorImp1.ForeColor = Color.Black;
      this.txtPorImp1.Location = new Point(90, 19);
      this.txtPorImp1.Name = "txtPorImp1";
      this.txtPorImp1.Size = new Size(47, 20);
      this.txtPorImp1.TabIndex = 5;
      this.txtPorImp1.TextAlign = HorizontalAlignment.Right;
      this.lblImp5.AutoSize = true;
      this.lblImp5.Location = new Point(10, 111);
      this.lblImp5.Name = "lblImp5";
      this.lblImp5.Size = new Size(59, 13);
      this.lblImp5.TabIndex = 4;
      this.lblImp5.Text = "Impuesto 5";
      this.lblImp4.AutoSize = true;
      this.lblImp4.Location = new Point(10, 89);
      this.lblImp4.Name = "lblImp4";
      this.lblImp4.Size = new Size(59, 13);
      this.lblImp4.TabIndex = 3;
      this.lblImp4.Text = "Impuesto 4";
      this.lblImp3.AutoSize = true;
      this.lblImp3.Location = new Point(10, 67);
      this.lblImp3.Name = "lblImp3";
      this.lblImp3.Size = new Size(59, 13);
      this.lblImp3.TabIndex = 2;
      this.lblImp3.Text = "Impuesto 3";
      this.lblImp2.AutoSize = true;
      this.lblImp2.Location = new Point(10, 45);
      this.lblImp2.Name = "lblImp2";
      this.lblImp2.Size = new Size(59, 13);
      this.lblImp2.TabIndex = 1;
      this.lblImp2.Text = "Impuesto 2";
      this.lblImp1.AutoSize = true;
      this.lblImp1.Location = new Point(10, 23);
      this.lblImp1.Name = "lblImp1";
      this.lblImp1.Size = new Size(59, 13);
      this.lblImp1.TabIndex = 0;
      this.lblImp1.Text = "Impuesto 1";
      this.txtPorIva.BackColor = Color.White;
      this.txtPorIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorIva.Enabled = false;
      this.txtPorIva.Location = new Point(317, 709);
      this.txtPorIva.Name = "txtPorIva";
      this.txtPorIva.Size = new Size(24, 20);
      this.txtPorIva.TabIndex = 11;
      this.txtPorIva.TabStop = false;
      this.txtPorIva.TextAlign = HorizontalAlignment.Right;
      this.txtPorIva.Visible = false;
      this.txtSubTotal.BackColor = Color.White;
      this.txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
      this.txtSubTotal.Enabled = false;
      this.txtSubTotal.Location = new Point(317, 643);
      this.txtSubTotal.Name = "txtSubTotal";
      this.txtSubTotal.Size = new Size(103, 20);
      this.txtSubTotal.TabIndex = 10;
      this.txtSubTotal.TabStop = false;
      this.txtSubTotal.TextAlign = HorizontalAlignment.Right;
      this.txtSubTotal.Visible = false;
      this.txtIva.BackColor = Color.White;
      this.txtIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtIva.Enabled = false;
      this.txtIva.Location = new Point(343, 709);
      this.txtIva.Name = "txtIva";
      this.txtIva.Size = new Size(77, 20);
      this.txtIva.TabIndex = 8;
      this.txtIva.TabStop = false;
      this.txtIva.TextAlign = HorizontalAlignment.Right;
      this.txtIva.Visible = false;
      this.txtNeto.BackColor = Color.White;
      this.txtNeto.BorderStyle = BorderStyle.FixedSingle;
      this.txtNeto.Enabled = false;
      this.txtNeto.Location = new Point(317, 687);
      this.txtNeto.Name = "txtNeto";
      this.txtNeto.Size = new Size(103, 20);
      this.txtNeto.TabIndex = 7;
      this.txtNeto.TabStop = false;
      this.txtNeto.TextAlign = HorizontalAlignment.Right;
      this.txtNeto.Visible = false;
      this.txtTotalDescuento.BackColor = Color.White;
      this.txtTotalDescuento.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalDescuento.Location = new Point(343, 665);
      this.txtTotalDescuento.Name = "txtTotalDescuento";
      this.txtTotalDescuento.ReadOnly = true;
      this.txtTotalDescuento.Size = new Size(77, 20);
      this.txtTotalDescuento.TabIndex = 6;
      this.txtTotalDescuento.TabStop = false;
      this.txtTotalDescuento.TextAlign = HorizontalAlignment.Right;
      this.txtTotalDescuento.Visible = false;
      this.txtTotalDescuento.TextChanged += new EventHandler(this.txtTotalDescuento_TextChanged);
      this.txtTotalDescuento.DoubleClick += new EventHandler(this.txtTotalDescuento_DoubleClick);
      this.txtTotalDescuento.KeyPress += new KeyPressEventHandler(this.txtTotalDescuento_KeyPress);
      this.txtTotalDescuento.Leave += new EventHandler(this.txtTotalDescuento_Leave);
      this.txtPorcDescuentoTotal.BackColor = Color.White;
      this.txtPorcDescuentoTotal.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorcDescuentoTotal.Location = new Point(317, 665);
      this.txtPorcDescuentoTotal.Name = "txtPorcDescuentoTotal";
      this.txtPorcDescuentoTotal.ReadOnly = true;
      this.txtPorcDescuentoTotal.Size = new Size(24, 20);
      this.txtPorcDescuentoTotal.TabIndex = 5;
      this.txtPorcDescuentoTotal.TabStop = false;
      this.txtPorcDescuentoTotal.TextAlign = HorizontalAlignment.Right;
      this.txtPorcDescuentoTotal.Visible = false;
      this.txtPorcDescuentoTotal.TextChanged += new EventHandler(this.txtPorcDescuentoTotal_TextChanged);
      this.txtPorcDescuentoTotal.DoubleClick += new EventHandler(this.txtPorcDescuentoTotal_DoubleClick);
      this.label25.AutoSize = true;
      this.label25.BackColor = Color.Transparent;
      this.label25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label25.ForeColor = Color.Black;
      this.label25.Location = new Point(278, 713);
      this.label25.Name = "label25";
      this.label25.Size = new Size(35, 13);
      this.label25.TabIndex = 3;
      this.label25.Text = "I.V.A";
      this.label25.Visible = false;
      this.label24.AutoSize = true;
      this.label24.BackColor = Color.Transparent;
      this.label24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = Color.Black;
      this.label24.Location = new Point(272, 691);
      this.label24.Name = "label24";
      this.label24.Size = new Size(41, 13);
      this.label24.TabIndex = 2;
      this.label24.Text = "NETO";
      this.label24.Visible = false;
      this.label23.AutoSize = true;
      this.label23.BackColor = Color.Transparent;
      this.label23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.Black;
      this.label23.Location = new Point(230, 669);
      this.label23.Name = "label23";
      this.label23.Size = new Size(83, 13);
      this.label23.TabIndex = 1;
      this.label23.Text = "DESCUENTO";
      this.label23.Visible = false;
      this.label22.AutoSize = true;
      this.label22.BackColor = Color.Transparent;
      this.label22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label22.ForeColor = Color.Black;
      this.label22.Location = new Point(241, 647);
      this.label22.Name = "label22";
      this.label22.Size = new Size(72, 13);
      this.label22.TabIndex = 0;
      this.label22.Text = "SUBTOTAL";
      this.label22.Visible = false;
      this.dgvDatosVenta.AllowUserToAddRows = false;
      this.dgvDatosVenta.AllowUserToDeleteRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      this.dgvDatosVenta.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvDatosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Window;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = Color.Black;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dgvDatosVenta.DefaultCellStyle = gridViewCellStyle2;
      this.dgvDatosVenta.Location = new Point(3, 69);
      this.dgvDatosVenta.MultiSelect = false;
      this.dgvDatosVenta.Name = "dgvDatosVenta";
      this.dgvDatosVenta.ReadOnly = true;
      this.dgvDatosVenta.RowHeadersVisible = false;
      this.dgvDatosVenta.RowHeadersWidth = 50;
      this.dgvDatosVenta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDatosVenta.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatosVenta.Size = new Size(756, 209);
      this.dgvDatosVenta.TabIndex = 3;
      this.dgvDatosVenta.CellClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
      this.dgvDatosVenta.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
      this.label27.BackColor = Color.FromArgb(64, 64, 64);
      this.label27.ForeColor = Color.White;
      this.label27.Location = new Point(7, 15);
      this.label27.Name = "label27";
      this.label27.Size = new Size(131, 23);
      this.label27.TabIndex = 21;
      this.label27.Text = "Garzon";
      this.gbZonaOtros.Controls.Add((Control) this.cmbGarzon);
      this.gbZonaOtros.Controls.Add((Control) this.label27);
      this.gbZonaOtros.Controls.Add((Control) this.cmbMedioPago);
      this.gbZonaOtros.Controls.Add((Control) this.label18);
      this.gbZonaOtros.Location = new Point(133, 18);
      this.gbZonaOtros.Name = "gbZonaOtros";
      this.gbZonaOtros.Size = new Size(294, 58);
      this.gbZonaOtros.TabIndex = 25;
      this.gbZonaOtros.TabStop = false;
      this.cmbGarzon.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbGarzon.FormattingEnabled = true;
      this.cmbGarzon.Location = new Point(7, 29);
      this.cmbGarzon.Name = "cmbGarzon";
      this.cmbGarzon.Size = new Size(131, 21);
      this.cmbGarzon.TabIndex = 22;
      this.cmbMedioPago.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.cmbMedioPago.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMedioPago.FormattingEnabled = true;
      this.cmbMedioPago.Location = new Point(144, 29);
      this.cmbMedioPago.Name = "cmbMedioPago";
      this.cmbMedioPago.Size = new Size(142, 21);
      this.cmbMedioPago.TabIndex = 2;
      this.cmbMedioPago.SelectedValueChanged += new EventHandler(this.cmbMedioPago_SelectedValueChanged);
      this.cmbMedioPago.Enter += new EventHandler(this.cmbMedioPago_Enter);
      this.label18.BackColor = Color.FromArgb(64, 64, 64);
      this.label18.ForeColor = Color.White;
      this.label18.Location = new Point(144, 15);
      this.label18.Name = "label18";
      this.label18.Size = new Size(141, 23);
      this.label18.TabIndex = 23;
      this.label18.Text = "Medio de Pago";
      this.label28.AutoSize = true;
      this.label28.Location = new Point(24, 611);
      this.label28.Name = "label28";
      this.label28.Size = new Size(44, 13);
      this.label28.TabIndex = 26;
      this.label28.Text = "Bodega";
      this.label28.Visible = false;
      this.cmbBodega.FormattingEnabled = true;
      this.cmbBodega.Location = new Point(584, 623);
      this.cmbBodega.Name = "cmbBodega";
      this.cmbBodega.Size = new Size(126, 21);
      this.cmbBodega.TabIndex = 17;
      this.cmbBodega.Visible = false;
      this.cmbBodega.Enter += new EventHandler(this.cmbBodega_Enter);
      this.label29.AutoSize = true;
      this.label29.Location = new Point(213, 611);
      this.label29.Name = "label29";
      this.label29.Size = new Size(77, 13);
      this.label29.TabIndex = 28;
      this.label29.Text = "Lista de Precio";
      this.label29.Visible = false;
      this.cmbListaPrecio.FormattingEnabled = true;
      this.cmbListaPrecio.Location = new Point(293, 607);
      this.cmbListaPrecio.Name = "cmbListaPrecio";
      this.cmbListaPrecio.Size = new Size(126, 21);
      this.cmbListaPrecio.TabIndex = 18;
      this.cmbListaPrecio.Visible = false;
      this.cmbListaPrecio.SelectedValueChanged += new EventHandler(this.cmbListaPrecio_SelectedValueChanged);
      this.panelZonaDetalle.BorderStyle = BorderStyle.Fixed3D;
      this.panelZonaDetalle.Controls.Add((Control) this.txtTipoDescuento);
      this.panelZonaDetalle.Controls.Add((Control) this.txtSubTotalLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.btnLimpiaLineaDetalle);
      this.panelZonaDetalle.Controls.Add((Control) this.btnModificaLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.txtLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.txtCodigo);
      this.panelZonaDetalle.Controls.Add((Control) this.txtCantidad);
      this.panelZonaDetalle.Controls.Add((Control) this.dgvDatosVenta);
      this.panelZonaDetalle.Controls.Add((Control) this.chkCantidadFija);
      this.panelZonaDetalle.Controls.Add((Control) this.btnAgregar);
      this.panelZonaDetalle.Controls.Add((Control) this.txtDescripcion);
      this.panelZonaDetalle.Controls.Add((Control) this.btnLimpiaDetalle);
      this.panelZonaDetalle.Controls.Add((Control) this.txtTotalLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.label20);
      this.panelZonaDetalle.Controls.Add((Control) this.txtPrecio);
      this.panelZonaDetalle.Controls.Add((Control) this.label14);
      this.panelZonaDetalle.Controls.Add((Control) this.label13);
      this.panelZonaDetalle.Controls.Add((Control) this.label15);
      this.panelZonaDetalle.Controls.Add((Control) this.label17);
      this.panelZonaDetalle.Location = new Point(12, 199);
      this.panelZonaDetalle.Name = "panelZonaDetalle";
      this.panelZonaDetalle.Size = new Size(767, 286);
      this.panelZonaDetalle.TabIndex = 27;
      this.txtTipoDescuento.Location = new Point(435, 42);
      this.txtTipoDescuento.Name = "txtTipoDescuento";
      this.txtTipoDescuento.Size = new Size(38, 20);
      this.txtTipoDescuento.TabIndex = 35;
      this.txtTipoDescuento.Text = "0";
      this.txtTipoDescuento.Visible = false;
      this.txtSubTotalLinea.Location = new Point(383, 42);
      this.txtSubTotalLinea.Name = "txtSubTotalLinea";
      this.txtSubTotalLinea.Size = new Size(43, 20);
      this.txtSubTotalLinea.TabIndex = 34;
      this.txtSubTotalLinea.Visible = false;
      this.btnLimpiaLineaDetalle.Location = new Point(736, 3);
      this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
      this.btnLimpiaLineaDetalle.Size = new Size(20, 34);
      this.btnLimpiaLineaDetalle.TabIndex = 33;
      this.btnLimpiaLineaDetalle.Text = "..";
      this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaLineaDetalle.Click += new EventHandler(this.btnLimpiaLineaDetalle_Click);
      this.btnModificaLinea.Location = new Point(566, 41);
      this.btnModificaLinea.Name = "btnModificaLinea";
      this.btnModificaLinea.Size = new Size(75, 23);
      this.btnModificaLinea.TabIndex = 33;
      this.btnModificaLinea.Text = "Modificar";
      this.btnModificaLinea.UseVisualStyleBackColor = true;
      this.btnModificaLinea.Click += new EventHandler(this.btnModificaLinea_Click);
      this.txtLinea.Location = new Point(305, 42);
      this.txtLinea.Name = "txtLinea";
      this.txtLinea.Size = new Size(71, 20);
      this.txtLinea.TabIndex = 32;
      this.txtLinea.Text = "NumeroLinea";
      this.txtLinea.Visible = false;
      this.txtPorcDescuentoLinea.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorcDescuentoLinea.Location = new Point(104, 661);
      this.txtPorcDescuentoLinea.Name = "txtPorcDescuentoLinea";
      this.txtPorcDescuentoLinea.Size = new Size(31, 20);
      this.txtPorcDescuentoLinea.TabIndex = 13;
      this.txtPorcDescuentoLinea.TextAlign = HorizontalAlignment.Right;
      this.txtPorcDescuentoLinea.Visible = false;
      this.txtPorcDescuentoLinea.TextChanged += new EventHandler(this.porcentajeDescuento_TextChanged);
      this.txtPorcDescuentoLinea.Enter += new EventHandler(this.txtPorcDescuentoLinea_Enter);
      this.txtPorcDescuentoLinea.KeyDown += new KeyEventHandler(this.txtPorcDescuentoLinea_KeyDown);
      this.txtPorcDescuentoLinea.KeyPress += new KeyPressEventHandler(this.txtPorcDescuentoLinea_KeyPress);
      this.label31.BackColor = Color.FromArgb(64, 64, 64);
      this.label31.ForeColor = Color.White;
      this.label31.Location = new Point(104, 647);
      this.label31.Name = "label31";
      this.label31.Size = new Size(31, 23);
      this.label31.TabIndex = 29;
      this.label31.Text = "%";
      this.label31.TextAlign = ContentAlignment.TopCenter;
      this.label31.Visible = false;
      this.panelFolio.BorderStyle = BorderStyle.FixedSingle;
      this.panelFolio.Controls.Add((Control) this.btnCerrarPanelFolio);
      this.panelFolio.Controls.Add((Control) this.btnBuscaFolio);
      this.panelFolio.Controls.Add((Control) this.txtFolioBuscar);
      this.panelFolio.Controls.Add((Control) this.label32);
      this.panelFolio.Location = new Point(550, 71);
      this.panelFolio.Name = "panelFolio";
      this.panelFolio.Size = new Size(231, 92);
      this.panelFolio.TabIndex = 24;
      this.btnCerrarPanelFolio.FlatStyle = FlatStyle.Flat;
      this.btnCerrarPanelFolio.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnCerrarPanelFolio.ForeColor = Color.Red;
      this.btnCerrarPanelFolio.Location = new Point(185, 1);
      this.btnCerrarPanelFolio.Name = "btnCerrarPanelFolio";
      this.btnCerrarPanelFolio.Size = new Size(23, 24);
      this.btnCerrarPanelFolio.TabIndex = 24;
      this.btnCerrarPanelFolio.Text = "X";
      this.btnCerrarPanelFolio.UseVisualStyleBackColor = true;
      this.btnCerrarPanelFolio.Click += new EventHandler(this.btnCerrarPanelFolio_Click);
      this.btnBuscaFolio.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaFolio.Location = new Point(25, 59);
      this.btnBuscaFolio.Name = "btnBuscaFolio";
      this.btnBuscaFolio.Size = new Size(161, 25);
      this.btnBuscaFolio.TabIndex = 2;
      this.btnBuscaFolio.Text = "Buscar";
      this.btnBuscaFolio.UseVisualStyleBackColor = true;
      this.btnBuscaFolio.Click += new EventHandler(this.btnBuscaFolio_Click);
      this.txtFolioBuscar.Location = new Point(26, 33);
      this.txtFolioBuscar.Name = "txtFolioBuscar";
      this.txtFolioBuscar.Size = new Size(162, 20);
      this.txtFolioBuscar.TabIndex = 1;
      this.txtFolioBuscar.KeyPress += new KeyPressEventHandler(this.txtFolioBuscar_KeyPress);
      this.label32.AutoSize = true;
      this.label32.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label32.Location = new Point(21, 8);
      this.label32.Name = "label32";
      this.label32.Size = new Size(164, 16);
      this.label32.TabIndex = 0;
      this.label32.Text = "Ingrese Folio a Buscar";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(454, 631);
      this.label9.Name = "label9";
      this.label9.Size = new Size(26, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Giro";
      this.label9.TextAlign = ContentAlignment.TopRight;
      this.label9.Visible = false;
      this.txtGiro.BackColor = Color.White;
      this.txtGiro.Location = new Point(484, 627);
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new Size(87, 20);
      this.txtGiro.TabIndex = 8;
      this.txtGiro.TabStop = false;
      this.txtGiro.Visible = false;
      this.rdbLlevar.BackColor = Color.FromArgb(64, 64, 64);
      this.rdbLlevar.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.rdbLlevar.ForeColor = Color.White;
      this.rdbLlevar.Location = new Point(433, 29);
      this.rdbLlevar.Name = "rdbLlevar";
      this.rdbLlevar.Size = new Size(141, 19);
      this.rdbLlevar.TabIndex = 34;
      this.rdbLlevar.TabStop = true;
      this.rdbLlevar.Text = "PARA LLEVAR";
      this.rdbLlevar.UseVisualStyleBackColor = false;
      this.rdbLlevar.Visible = false;
      this.rdbDomicilio.BackColor = Color.FromArgb(64, 64, 64);
      this.rdbDomicilio.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.rdbDomicilio.ForeColor = Color.White;
      this.rdbDomicilio.Location = new Point(433, 49);
      this.rdbDomicilio.Name = "rdbDomicilio";
      this.rdbDomicilio.Size = new Size(141, 24);
      this.rdbDomicilio.TabIndex = 35;
      this.rdbDomicilio.TabStop = true;
      this.rdbDomicilio.Text = "ENVIAR A DOMICILIO";
      this.rdbDomicilio.UseVisualStyleBackColor = false;
      this.rdbDomicilio.Visible = false;
      this.tabControl1.Controls.Add((Control) this.tabPageMesa);
      this.tabControl1.Controls.Add((Control) this.tabPageCliente);
      this.tabControl1.Location = new Point(12, 78);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(769, 119);
      this.tabControl1.SizeMode = TabSizeMode.Fixed;
      this.tabControl1.TabIndex = 36;
      this.tabPageMesa.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPageMesa.Controls.Add((Control) this.panelMesa);
      this.tabPageMesa.Location = new Point(4, 22);
      this.tabPageMesa.Name = "tabPageMesa";
      this.tabPageMesa.Padding = new Padding(3);
      this.tabPageMesa.Size = new Size(761, 93);
      this.tabPageMesa.TabIndex = 0;
      this.tabPageMesa.Text = "Mesa";
      this.tabPageCliente.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPageCliente.Controls.Add((Control) this.panelCliente);
      this.tabPageCliente.Location = new Point(4, 22);
      this.tabPageCliente.Name = "tabPageCliente";
      this.tabPageCliente.Padding = new Padding(3);
      this.tabPageCliente.Size = new Size(761, 93);
      this.tabPageCliente.TabIndex = 1;
      this.tabPageCliente.Text = "Cliente";
      this.btnCat1.BackColor = Color.MediumSeaGreen;
      this.btnCat1.FlatStyle = FlatStyle.Flat;
      this.btnCat1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat1.ForeColor = Color.White;
      this.btnCat1.Location = new Point(6, 17);
      this.btnCat1.Name = "btnCat1";
      this.btnCat1.Size = new Size(70, 60);
      this.btnCat1.TabIndex = 0;
      this.btnCat1.Text = "c1";
      this.btnCat1.UseVisualStyleBackColor = false;
      this.btnCat1.Click += new EventHandler(this.btnCat1_Click);
      this.btnCat2.BackColor = Color.MediumSeaGreen;
      this.btnCat2.FlatStyle = FlatStyle.Flat;
      this.btnCat2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat2.ForeColor = Color.White;
      this.btnCat2.Location = new Point(78, 17);
      this.btnCat2.Name = "btnCat2";
      this.btnCat2.Size = new Size(70, 60);
      this.btnCat2.TabIndex = 1;
      this.btnCat2.Text = "c2";
      this.btnCat2.UseVisualStyleBackColor = false;
      this.btnCat2.Click += new EventHandler(this.btnCat2_Click);
      this.btnCat3.BackColor = Color.MediumSeaGreen;
      this.btnCat3.FlatStyle = FlatStyle.Flat;
      this.btnCat3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat3.ForeColor = Color.White;
      this.btnCat3.Location = new Point(150, 17);
      this.btnCat3.Name = "btnCat3";
      this.btnCat3.Size = new Size(70, 60);
      this.btnCat3.TabIndex = 2;
      this.btnCat3.Text = "c3";
      this.btnCat3.UseVisualStyleBackColor = false;
      this.btnCat3.Click += new EventHandler(this.btnCat3_Click);
      this.btnCat6.BackColor = Color.MediumSeaGreen;
      this.btnCat6.FlatStyle = FlatStyle.Flat;
      this.btnCat6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat6.ForeColor = Color.White;
      this.btnCat6.Location = new Point(150, 78);
      this.btnCat6.Name = "btnCat6";
      this.btnCat6.Size = new Size(70, 60);
      this.btnCat6.TabIndex = 5;
      this.btnCat6.Text = "c6";
      this.btnCat6.UseVisualStyleBackColor = false;
      this.btnCat6.Click += new EventHandler(this.btnCat6_Click);
      this.btnCat5.BackColor = Color.MediumSeaGreen;
      this.btnCat5.FlatStyle = FlatStyle.Flat;
      this.btnCat5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat5.ForeColor = Color.White;
      this.btnCat5.Location = new Point(78, 78);
      this.btnCat5.Name = "btnCat5";
      this.btnCat5.Size = new Size(70, 60);
      this.btnCat5.TabIndex = 4;
      this.btnCat5.Text = "c5";
      this.btnCat5.UseVisualStyleBackColor = false;
      this.btnCat5.Click += new EventHandler(this.btnCat5_Click);
      this.btnCat4.BackColor = Color.MediumSeaGreen;
      this.btnCat4.FlatStyle = FlatStyle.Flat;
      this.btnCat4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat4.ForeColor = Color.White;
      this.btnCat4.Location = new Point(6, 78);
      this.btnCat4.Name = "btnCat4";
      this.btnCat4.Size = new Size(70, 60);
      this.btnCat4.TabIndex = 3;
      this.btnCat4.Text = "c4";
      this.btnCat4.UseVisualStyleBackColor = false;
      this.btnCat4.Click += new EventHandler(this.btnCat4_Click);
      this.btnP3.BackColor = Color.CornflowerBlue;
      this.btnP3.FlatStyle = FlatStyle.Flat;
      this.btnP3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP3.ForeColor = Color.White;
      this.btnP3.Location = new Point(150, 18);
      this.btnP3.Name = "btnP3";
      this.btnP3.Size = new Size(70, 60);
      this.btnP3.TabIndex = 8;
      this.btnP3.Text = "3";
      this.btnP3.UseVisualStyleBackColor = false;
      this.btnP3.Click += new EventHandler(this.btnP3_Click);
      this.btnP2.BackColor = Color.CornflowerBlue;
      this.btnP2.FlatStyle = FlatStyle.Flat;
      this.btnP2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP2.ForeColor = Color.White;
      this.btnP2.Location = new Point(78, 18);
      this.btnP2.Name = "btnP2";
      this.btnP2.Size = new Size(70, 60);
      this.btnP2.TabIndex = 7;
      this.btnP2.Text = "2";
      this.btnP2.UseVisualStyleBackColor = false;
      this.btnP2.Click += new EventHandler(this.btnP2_Click);
      this.btnP1.BackColor = Color.CornflowerBlue;
      this.btnP1.FlatStyle = FlatStyle.Flat;
      this.btnP1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP1.ForeColor = Color.White;
      this.btnP1.Location = new Point(6, 18);
      this.btnP1.Name = "btnP1";
      this.btnP1.Size = new Size(70, 60);
      this.btnP1.TabIndex = 6;
      this.btnP1.Text = "1";
      this.btnP1.UseVisualStyleBackColor = false;
      this.btnP1.Click += new EventHandler(this.btnP1_Click);
      this.btnP6.BackColor = Color.CornflowerBlue;
      this.btnP6.FlatStyle = FlatStyle.Flat;
      this.btnP6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP6.ForeColor = Color.White;
      this.btnP6.Location = new Point(150, 80);
      this.btnP6.Name = "btnP6";
      this.btnP6.Size = new Size(70, 60);
      this.btnP6.TabIndex = 11;
      this.btnP6.Text = "6";
      this.btnP6.UseVisualStyleBackColor = false;
      this.btnP6.Click += new EventHandler(this.btnP6_Click);
      this.btnP5.BackColor = Color.CornflowerBlue;
      this.btnP5.FlatStyle = FlatStyle.Flat;
      this.btnP5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP5.ForeColor = Color.White;
      this.btnP5.Location = new Point(78, 80);
      this.btnP5.Name = "btnP5";
      this.btnP5.Size = new Size(70, 60);
      this.btnP5.TabIndex = 10;
      this.btnP5.Text = "5";
      this.btnP5.UseVisualStyleBackColor = false;
      this.btnP5.Click += new EventHandler(this.btnP5_Click);
      this.btnP4.BackColor = Color.CornflowerBlue;
      this.btnP4.FlatStyle = FlatStyle.Flat;
      this.btnP4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP4.ForeColor = Color.White;
      this.btnP4.Location = new Point(6, 80);
      this.btnP4.Name = "btnP4";
      this.btnP4.Size = new Size(70, 60);
      this.btnP4.TabIndex = 9;
      this.btnP4.Text = "4";
      this.btnP4.UseVisualStyleBackColor = false;
      this.btnP4.Click += new EventHandler(this.btnP4_Click);
      this.btnP9.BackColor = Color.CornflowerBlue;
      this.btnP9.FlatStyle = FlatStyle.Flat;
      this.btnP9.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP9.ForeColor = Color.White;
      this.btnP9.Location = new Point(150, 142);
      this.btnP9.Name = "btnP9";
      this.btnP9.Size = new Size(70, 60);
      this.btnP9.TabIndex = 14;
      this.btnP9.Text = "9";
      this.btnP9.UseVisualStyleBackColor = false;
      this.btnP9.Click += new EventHandler(this.btnP9_Click);
      this.btnP8.BackColor = Color.CornflowerBlue;
      this.btnP8.FlatStyle = FlatStyle.Flat;
      this.btnP8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP8.ForeColor = Color.White;
      this.btnP8.Location = new Point(78, 142);
      this.btnP8.Name = "btnP8";
      this.btnP8.Size = new Size(70, 60);
      this.btnP8.TabIndex = 13;
      this.btnP8.Text = "8";
      this.btnP8.UseVisualStyleBackColor = false;
      this.btnP8.Click += new EventHandler(this.btnP8_Click);
      this.btnP7.BackColor = Color.CornflowerBlue;
      this.btnP7.FlatStyle = FlatStyle.Flat;
      this.btnP7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP7.ForeColor = Color.White;
      this.btnP7.Location = new Point(6, 142);
      this.btnP7.Name = "btnP7";
      this.btnP7.Size = new Size(70, 60);
      this.btnP7.TabIndex = 12;
      this.btnP7.Text = "7";
      this.btnP7.UseVisualStyleBackColor = false;
      this.btnP7.Click += new EventHandler(this.btnP7_Click);
      this.btnP12.BackColor = Color.CornflowerBlue;
      this.btnP12.FlatStyle = FlatStyle.Flat;
      this.btnP12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP12.ForeColor = Color.White;
      this.btnP12.Location = new Point(150, 204);
      this.btnP12.Name = "btnP12";
      this.btnP12.Size = new Size(70, 60);
      this.btnP12.TabIndex = 17;
      this.btnP12.Text = "12";
      this.btnP12.UseVisualStyleBackColor = false;
      this.btnP12.Click += new EventHandler(this.btnP12_Click);
      this.btnP11.BackColor = Color.CornflowerBlue;
      this.btnP11.FlatStyle = FlatStyle.Flat;
      this.btnP11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP11.ForeColor = Color.White;
      this.btnP11.Location = new Point(78, 204);
      this.btnP11.Name = "btnP11";
      this.btnP11.Size = new Size(70, 60);
      this.btnP11.TabIndex = 16;
      this.btnP11.Text = "11";
      this.btnP11.UseVisualStyleBackColor = false;
      this.btnP11.Click += new EventHandler(this.btnP11_Click);
      this.btnP10.BackColor = Color.CornflowerBlue;
      this.btnP10.FlatStyle = FlatStyle.Flat;
      this.btnP10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP10.ForeColor = Color.White;
      this.btnP10.Location = new Point(6, 204);
      this.btnP10.Name = "btnP10";
      this.btnP10.Size = new Size(70, 60);
      this.btnP10.TabIndex = 15;
      this.btnP10.Text = "10";
      this.btnP10.UseVisualStyleBackColor = false;
      this.btnP10.Click += new EventHandler(this.btnP10_Click);
      this.btnP15.BackColor = Color.CornflowerBlue;
      this.btnP15.FlatStyle = FlatStyle.Flat;
      this.btnP15.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP15.ForeColor = Color.White;
      this.btnP15.Location = new Point(150, 266);
      this.btnP15.Name = "btnP15";
      this.btnP15.Size = new Size(70, 60);
      this.btnP15.TabIndex = 20;
      this.btnP15.Text = "15";
      this.btnP15.UseVisualStyleBackColor = false;
      this.btnP15.Click += new EventHandler(this.btnP15_Click);
      this.btnP14.BackColor = Color.CornflowerBlue;
      this.btnP14.FlatStyle = FlatStyle.Flat;
      this.btnP14.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP14.ForeColor = Color.White;
      this.btnP14.Location = new Point(78, 266);
      this.btnP14.Name = "btnP14";
      this.btnP14.Size = new Size(70, 60);
      this.btnP14.TabIndex = 19;
      this.btnP14.Text = "14";
      this.btnP14.UseVisualStyleBackColor = false;
      this.btnP14.Click += new EventHandler(this.btnP14_Click);
      this.btnP13.BackColor = Color.CornflowerBlue;
      this.btnP13.FlatStyle = FlatStyle.Flat;
      this.btnP13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP13.ForeColor = Color.White;
      this.btnP13.Location = new Point(6, 266);
      this.btnP13.Name = "btnP13";
      this.btnP13.Size = new Size(70, 60);
      this.btnP13.TabIndex = 18;
      this.btnP13.Text = "13";
      this.btnP13.UseVisualStyleBackColor = false;
      this.btnP13.Click += new EventHandler(this.btnP13_Click);
      this.btnP18.BackColor = Color.CornflowerBlue;
      this.btnP18.FlatStyle = FlatStyle.Flat;
      this.btnP18.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP18.ForeColor = Color.White;
      this.btnP18.Location = new Point(150, 328);
      this.btnP18.Name = "btnP18";
      this.btnP18.Size = new Size(70, 60);
      this.btnP18.TabIndex = 23;
      this.btnP18.Text = "18";
      this.btnP18.UseVisualStyleBackColor = false;
      this.btnP18.Click += new EventHandler(this.btnP18_Click);
      this.btnP17.BackColor = Color.CornflowerBlue;
      this.btnP17.FlatStyle = FlatStyle.Flat;
      this.btnP17.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP17.ForeColor = Color.White;
      this.btnP17.Location = new Point(78, 328);
      this.btnP17.Name = "btnP17";
      this.btnP17.Size = new Size(70, 60);
      this.btnP17.TabIndex = 22;
      this.btnP17.Text = "17";
      this.btnP17.UseVisualStyleBackColor = false;
      this.btnP17.Click += new EventHandler(this.btnP17_Click);
      this.btnP16.BackColor = Color.CornflowerBlue;
      this.btnP16.FlatStyle = FlatStyle.Flat;
      this.btnP16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP16.ForeColor = Color.White;
      this.btnP16.Location = new Point(6, 328);
      this.btnP16.Name = "btnP16";
      this.btnP16.Size = new Size(70, 60);
      this.btnP16.TabIndex = 21;
      this.btnP16.Text = "16";
      this.btnP16.UseVisualStyleBackColor = false;
      this.btnP16.Click += new EventHandler(this.btnP16_Click);
      this.btnP21.BackColor = Color.CornflowerBlue;
      this.btnP21.FlatStyle = FlatStyle.Flat;
      this.btnP21.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP21.ForeColor = Color.White;
      this.btnP21.Location = new Point(150, 390);
      this.btnP21.Name = "btnP21";
      this.btnP21.Size = new Size(70, 60);
      this.btnP21.TabIndex = 26;
      this.btnP21.Text = "21";
      this.btnP21.UseVisualStyleBackColor = false;
      this.btnP21.Click += new EventHandler(this.btnP21_Click);
      this.btnP20.BackColor = Color.CornflowerBlue;
      this.btnP20.FlatStyle = FlatStyle.Flat;
      this.btnP20.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP20.ForeColor = Color.White;
      this.btnP20.Location = new Point(77, 390);
      this.btnP20.Name = "btnP20";
      this.btnP20.Size = new Size(70, 60);
      this.btnP20.TabIndex = 25;
      this.btnP20.Text = "20";
      this.btnP20.UseVisualStyleBackColor = false;
      this.btnP20.Click += new EventHandler(this.btnP20_Click);
      this.btnP19.BackColor = Color.CornflowerBlue;
      this.btnP19.FlatStyle = FlatStyle.Flat;
      this.btnP19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnP19.ForeColor = Color.White;
      this.btnP19.Location = new Point(6, 390);
      this.btnP19.Name = "btnP19";
      this.btnP19.Size = new Size(70, 60);
      this.btnP19.TabIndex = 24;
      this.btnP19.Text = "19";
      this.btnP19.UseVisualStyleBackColor = false;
      this.btnP19.Click += new EventHandler(this.btnP19_Click);
      this.groupBox2.BackColor = Color.FromArgb(223, 233, 245);
      this.groupBox2.Controls.Add((Control) this.btnCat9);
      this.groupBox2.Controls.Add((Control) this.btnCat8);
      this.groupBox2.Controls.Add((Control) this.btnCat7);
      this.groupBox2.Controls.Add((Control) this.btnCat1);
      this.groupBox2.Controls.Add((Control) this.btnCat2);
      this.groupBox2.Controls.Add((Control) this.btnCat3);
      this.groupBox2.Controls.Add((Control) this.btnCat4);
      this.groupBox2.Controls.Add((Control) this.btnCat5);
      this.groupBox2.Controls.Add((Control) this.btnCat6);
      this.groupBox2.Location = new Point(787, 32);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(226, 206);
      this.groupBox2.TabIndex = 38;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Categorias";
      this.btnCat9.BackColor = Color.MediumSeaGreen;
      this.btnCat9.FlatStyle = FlatStyle.Flat;
      this.btnCat9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat9.ForeColor = Color.White;
      this.btnCat9.Location = new Point(150, 140);
      this.btnCat9.Name = "btnCat9";
      this.btnCat9.Size = new Size(70, 60);
      this.btnCat9.TabIndex = 8;
      this.btnCat9.Text = "c9";
      this.btnCat9.UseVisualStyleBackColor = false;
      this.btnCat9.Click += new EventHandler(this.btnCat9_Click);
      this.btnCat8.BackColor = Color.MediumSeaGreen;
      this.btnCat8.FlatStyle = FlatStyle.Flat;
      this.btnCat8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat8.ForeColor = Color.White;
      this.btnCat8.Location = new Point(78, 140);
      this.btnCat8.Name = "btnCat8";
      this.btnCat8.Size = new Size(70, 60);
      this.btnCat8.TabIndex = 7;
      this.btnCat8.Text = "c8";
      this.btnCat8.UseVisualStyleBackColor = false;
      this.btnCat8.Click += new EventHandler(this.btnCat8_Click);
      this.btnCat7.BackColor = Color.MediumSeaGreen;
      this.btnCat7.FlatStyle = FlatStyle.Flat;
      this.btnCat7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCat7.ForeColor = Color.White;
      this.btnCat7.Location = new Point(6, 140);
      this.btnCat7.Name = "btnCat7";
      this.btnCat7.Size = new Size(70, 60);
      this.btnCat7.TabIndex = 6;
      this.btnCat7.Text = "c7";
      this.btnCat7.UseVisualStyleBackColor = false;
      this.btnCat7.Click += new EventHandler(this.btnCat7_Click);
      this.groupBox3.BackColor = Color.FromArgb(223, 233, 245);
      this.groupBox3.Controls.Add((Control) this.btnP21);
      this.groupBox3.Controls.Add((Control) this.btnP2);
      this.groupBox3.Controls.Add((Control) this.btnP20);
      this.groupBox3.Controls.Add((Control) this.btnP1);
      this.groupBox3.Controls.Add((Control) this.btnP19);
      this.groupBox3.Controls.Add((Control) this.btnP3);
      this.groupBox3.Controls.Add((Control) this.btnP18);
      this.groupBox3.Controls.Add((Control) this.btnP4);
      this.groupBox3.Controls.Add((Control) this.btnP17);
      this.groupBox3.Controls.Add((Control) this.btnP5);
      this.groupBox3.Controls.Add((Control) this.btnP16);
      this.groupBox3.Controls.Add((Control) this.btnP6);
      this.groupBox3.Controls.Add((Control) this.btnP15);
      this.groupBox3.Controls.Add((Control) this.btnP9);
      this.groupBox3.Controls.Add((Control) this.btnP14);
      this.groupBox3.Controls.Add((Control) this.btnP7);
      this.groupBox3.Controls.Add((Control) this.btnP13);
      this.groupBox3.Controls.Add((Control) this.btnP8);
      this.groupBox3.Controls.Add((Control) this.btnP12);
      this.groupBox3.Controls.Add((Control) this.btnP10);
      this.groupBox3.Controls.Add((Control) this.btnP11);
      this.groupBox3.Location = new Point(787, 238);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(226, 457);
      this.groupBox3.TabIndex = 39;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Productos";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1016, 699);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.panelFolio);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.rdbDomicilio);
      this.Controls.Add((Control) this.rdbLlevar);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.gbZonaFechas);
      this.Controls.Add((Control) this.gbZonaOtros);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.txtNumeroDocumento);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.cmbBodega);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.panelZonaDetalle);
      this.Controls.Add((Control) this.txtPorcDescuentoLinea);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.txtPorIva);
      this.Controls.Add((Control) this.lblFolio);
      this.Controls.Add((Control) this.txtGiro);
      this.Controls.Add((Control) this.txtCiudad);
      this.Controls.Add((Control) this.label31);
      this.Controls.Add((Control) this.gbZonaBotones);
      this.Controls.Add((Control) this.txtFax);
      this.Controls.Add((Control) this.cmbListaPrecio);
      this.Controls.Add((Control) this.label29);
      this.Controls.Add((Control) this.txtSubTotal);
      this.Controls.Add((Control) this.txtDescuento);
      this.Controls.Add((Control) this.label19);
      this.Controls.Add((Control) this.label28);
      this.Controls.Add((Control) this.txtIva);
      this.Controls.Add((Control) this.txtNeto);
      this.Controls.Add((Control) this.label22);
      this.Controls.Add((Control) this.txtTotalDescuento);
      this.Controls.Add((Control) this.label23);
      this.Controls.Add((Control) this.txtPorcDescuentoTotal);
      this.Controls.Add((Control) this.label24);
      this.Controls.Add((Control) this.label25);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "frmComanda";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Comanda";
      this.FormClosing += new FormClosingEventHandler(this.frmFactura_FormClosing);
      this.KeyDown += new KeyEventHandler(this.frmFactura_KeyDown);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panelCliente.ResumeLayout(false);
      this.panelCliente.PerformLayout();
      this.panelMesa.ResumeLayout(false);
      this.panelMesa.PerformLayout();
      this.gbZonaFechas.ResumeLayout(false);
      this.gbZonaBotones.ResumeLayout(false);
      this.gbZonaBotones.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.dgvDatosVenta).EndInit();
      this.gbZonaOtros.ResumeLayout(false);
      this.panelZonaDetalle.ResumeLayout(false);
      this.panelZonaDetalle.PerformLayout();
      this.panelFolio.ResumeLayout(false);
      this.panelFolio.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPageMesa.ResumeLayout(false);
      this.tabPageCliente.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
