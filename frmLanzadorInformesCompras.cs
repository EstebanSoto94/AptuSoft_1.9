 
// Type: Aptusoft.frmLanzadorInformesCompras
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmLanzadorInformesCompras : Form
  {
    private int codigoProveedor = 0;
    private int idCentroCosto = 0;
    private int docCompra = 0;
    private int idMedioPago = 0;
    private IContainer components = (IContainer) null;
    private string codigoInforme;
    private string filtro;
    private string desde;
    private string hasta;
    private string archivo;
    private frmLanzadorInformesCompras intance;
    private GroupBox gpbFecha;
    private GroupBox gpbProveedor;
    private Button btnBuscar;
    private Button btnSalir;
    private DateTimePicker dtpHasta;
    private DateTimePicker dtpDesde;
    private Label label2;
    private Label label1;
    private Label lblNombreInforme;
    private Label label3;
    private TextBox txtRazonSocial;
    private TextBox txtDigito;
    private TextBox txtRut;
    private Label label4;
    private GroupBox gpbCentroCosto;
    private Label label6;
    private ComboBox cmbCentroCosto;
    private Button btnBuscaCliente;
    private Label lblReporte;
    private GroupBox gpbFolio;
    private TextBox txtFolio;
    private Label label8;
    private GroupBox gpbTipoDoc;
    private Label label5;
    private ComboBox cmbTipoDocumento;
    private GroupBox gpbMediosPago;
    private Label label9;
    private ComboBox cmbMedioPago;
    private ComboBox cmbPeriodo;
    private GroupBox gpbPeriodo;
    private Label label10;
    private Label label7;

    public frmLanzadorInformesCompras()
    {
      this.InitializeComponent();
      this.intance = this;
    }

    public frmLanzadorInformesCompras(string informe, string codInforme)
    {
      this.InitializeComponent();
      this.lblNombreInforme.Text = informe;
      this.lblReporte.Text = codInforme;
      this.codigoInforme = codInforme;
      this.intance = this;
      this.iniciaFormulario(codInforme);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cargaTipoDocumentos()
    {
      this.cmbTipoDocumento.DataSource = (object) new CargaMaestros().cargaTipoDocumentos();
      this.cmbTipoDocumento.ValueMember = "codigo";
      this.cmbTipoDocumento.DisplayMember = "descripcion";
      this.cmbTipoDocumento.SelectedValue = (object) 0;
    }

    private void cargaCentroCosto()
    {
      this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
      this.cmbCentroCosto.ValueMember = "idCentroCosto";
      this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
      this.cmbCentroCosto.SelectedValue = (object) 0;
    }

    private void cargaMediosPago()
    {
      List<MedioPagoVO> list = new MedioPago().listaMediosPagoVenta();
      list[0].NombreMedioPago = "Todos";
      this.cmbMedioPago.DataSource = (object) list;
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void buscaProveedor()
    {
      ArrayList arrayList1 = new ArrayList();
      Cliente cliente = new Cliente();
      ArrayList arrayList2 = new Proveedor().buscaRutProveedor(this.txtRut.Text.Trim());
      if (arrayList2.Count != 1)
        return;
      foreach (ClienteVO clienteVo in arrayList2)
        this.buscaProveedorCodigo(clienteVo.Codigo);
      this.btnBuscar.Focus();
    }

    public void buscaProveedorCodigo(int cod)
    {
      ClienteVO clienteVo = new Proveedor().buscaCodigoProveedor(cod);
      this.codigoProveedor = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.btnBuscar.Focus();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      this.lanzaInforme();
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
        int num = (int) MessageBox.Show("Debe Ingresar RUT a Buscar");
        this.txtRut.Focus();
      }
    }

    private void iniciaFormulario(string codInf)
    {
      this.cargaTipoDocumentos();
      if (this.codigoInforme.Equals("COMPRA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("COMPRA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("COMPRA003"))
      {
        this.cargaCentroCosto();
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = true;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("COMPRA004"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbTipoDoc.Enabled = true;
        this.cmbTipoDocumento.DataSource = (object) null;
        this.cargaTipoDocumentos();
        this.cmbTipoDocumento.SelectedValue = (object) 0;
      }
      if (this.codigoInforme.Equals("COMPRA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbTipoDoc.Enabled = true;
        this.cmbTipoDocumento.DataSource = (object) null;
        this.cargaTipoDocumentos();
        this.cmbTipoDocumento.SelectedValue = (object) 0;
      }
      if (this.codigoInforme.Equals("COMPRA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
      }
      if (this.codigoInforme.Equals("COMPRA007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbTipoDoc.Enabled = false;
        this.gpbTipoDoc.Visible = false;
        this.cmbTipoDocumento.SelectedValue = (object) 1;
      }
      if (this.codigoInforme.Equals("COMPRA008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbTipoDoc.Enabled = false;
        this.cmbTipoDocumento.SelectedValue = (object) 1;
      }
      if (this.codigoInforme.Equals("COMPRA009"))
      {
        this.gpbFecha.Visible = false;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbTipoDoc.Enabled = false;
        this.cmbTipoDocumento.SelectedValue = (object) 1;
        this.gpbPeriodo.Visible = true;
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
      if (this.codigoInforme.Equals("ORDENCOMP001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbTipoDoc.Visible = false;
      }
      if (this.codigoInforme.Equals("ORDENCOMP002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbTipoDoc.Visible = false;
      }
      if (this.codigoInforme.Equals("ORDENCOMP003"))
      {
        this.cargaCentroCosto();
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = true;
        this.gpbFolio.Visible = false;
        this.gpbTipoDoc.Visible = false;
      }
      if (this.codigoInforme.Equals("ORDENCOMP004"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbTipoDoc.Visible = false;
      }
      if (this.codigoInforme.Equals("PAGOCOMPRA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbTipoDoc.Enabled = true;
        this.cmbTipoDocumento.DataSource = (object) null;
        this.cargaTipoDocumentos();
        this.cmbTipoDocumento.SelectedValue = (object) 0;
        this.gpbProveedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbMediosPago.Visible = true;
        this.cargaMediosPago();
      }
      if (this.codigoInforme.Equals("PAGOCOMPRA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = false;
        this.gpbTipoDoc.Enabled = true;
        this.cmbTipoDocumento.DataSource = (object) null;
        this.cargaTipoDocumentos();
        this.cmbTipoDocumento.SelectedValue = (object) 0;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbMediosPago.Visible = true;
        this.cargaMediosPago();
      }
      if (this.codigoInforme.Equals("PAGOCOMPRA003"))
      {
        this.gpbFecha.Visible = true;
        this.gpbProveedor.Visible = true;
        this.gpbTipoDoc.Enabled = true;
        this.cmbTipoDocumento.DataSource = (object) null;
        this.cargaTipoDocumentos();
        this.cmbTipoDocumento.SelectedValue = (object) 0;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbMediosPago.Visible = false;
        this.cargaMediosPago();
      }
      if (!this.codigoInforme.Equals("SERVICIO001"))
        return;
      this.gpbFecha.Visible = true;
      this.gpbProveedor.Visible = false;
      this.gpbCentroCosto.Visible = false;
      this.gpbFolio.Visible = false;
      this.gpbTipoDoc.Visible = false;
    }

    private void lanzaInforme()
    {
      this.docCompra = Convert.ToInt32(this.cmbTipoDocumento.SelectedValue.ToString());
      DocumentoCompra documentoCompra = new DocumentoCompra();
      Servicio servicio = new Servicio();
      DataTable dataTable = new DataTable();
      if (this.codigoInforme.Equals("COMPRA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idTipoDocumentoCompra='" + this.docCompra.ToString() + "'";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idTipoDocumentoCompra > '0'";
        this.archivo = "Compra001.rpt";
        dataTable = documentoCompra.compraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("COMPRA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idTipoDocumentoCompra='" + this.docCompra.ToString() + "' AND idProveedor='" + this.codigoProveedor.ToString() + "'";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idTipoDocumentoCompra > '0' AND idProveedor='" + this.codigoProveedor.ToString() + "'";
        this.archivo = "Compra002.rpt";
        dataTable = documentoCompra.compraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("COMPRA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idTipoDocumentoCompra='" + this.docCompra.ToString() + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "'";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idTipoDocumentoCompra > '0' AND idCentroCosto='" + this.idCentroCosto.ToString() + "'";
        this.archivo = "Compra003.rpt";
        dataTable = documentoCompra.compraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("COMPRA004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idTipoDocumentoCompra='" +  this.docCompra.ToString() + "' AND (estadoPago='PENDIENTE' OR estadoPago='DOCUMENTADO')";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND (idTipoDocumentoCompra = '1' OR idTipoDocumentoCompra = '5')  AND (estadoPago='PENDIENTE' OR estadoPago='DOCUMENTADO')";
        this.archivo = "Compra004.rpt";
        dataTable = documentoCompra.compraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("COMPRA005"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idTipoDocumentoCompra='" +  this.docCompra.ToString() + "' AND (estadoPago='PENDIENTE' OR estadoPago='DOCUMENTADO') AND idProveedor='" + this.codigoProveedor.ToString() + "'";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND (idTipoDocumentoCompra = '1' OR idTipoDocumentoCompra = '5') AND (estadoPago='PENDIENTE' OR estadoPago='DOCUMENTADO') AND idProveedor='" + this.codigoProveedor.ToString() + "'";
        this.archivo = "Compra005.rpt";
        dataTable = documentoCompra.compraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("COMPRA006"))
      {
        this.filtro = "idTipoDocumentoCompra='" + this.docCompra.ToString() + "'AND folio='" + this.txtFolio.Text.Trim() + "'";
        this.archivo = "Compra.rpt";
        dataTable = documentoCompra.compraInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("COMPRA007"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "'";
        string filtroServicio = "DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= '" + this.hasta + "'";
        this.archivo = "Compra007.rpt";
        dataTable = documentoCompra.libroCompraInforme(this.filtro, filtroServicio);
      }
      if (this.codigoInforme.Equals("COMPRA008"))
      {
        Proveedor proveedor = new Proveedor();
        this.archivo = "Compra008.rpt";
        dataTable = proveedor.listadoProveedoresInforme();
      }
      if (this.codigoInforme.Equals("COMPRA009"))
      {
        int num = Convert.ToInt32(this.cmbPeriodo.SelectedValue.ToString());
        //this.filtro = "idPeriodo='" + (object) num + "' AND (idTipoDocumentoCompra='1' OR idTipoDocumentoCompra='5' OR idTipoDocumentoCompra='4' OR idTipoDocumentoCompra='6' OR idTipoDocumentoCompra='7')";
       
          string filtroServicio = "idPeriodo='" + (object) num + "'";
          this.filtro = filtroServicio;
        this.archivo = "Compra009.rpt";
        dataTable = documentoCompra.libroCompraInforme(this.filtro, filtroServicio);
      }
      OrdenCompra ordenCompra = new OrdenCompra();
      if (this.codigoInforme.Equals("ORDENCOMP001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "'";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "'";
        this.archivo = "OrdenCompra001.rpt";
        dataTable = ordenCompra.ordenCompraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("ORDENCOMP002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idProveedor='" + this.codigoProveedor.ToString() + "'";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idProveedor='" + this.codigoProveedor.ToString() + "'";
        this.archivo = "OrdenCompra002.rpt";
        dataTable = ordenCompra.ordenCompraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("ORDENCOMP003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "'";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "'";
        this.archivo = "OrdenCompra003.rpt";
        dataTable = ordenCompra.ordenCompraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("ORDENCOMP004"))
      {
        this.filtro = "folio='" + this.txtFolio.Text.Trim() + "'";
        this.archivo = "OrdenCompra.rpt";
        dataTable = ordenCompra.ordenCompraInformeDetalle(this.filtro);
      }
      PagoCompra pagoCompra = new PagoCompra();
      if (this.codigoInforme.Equals("PAGOCOMPRA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        if (this.idMedioPago > 0)
        {
          if (this.docCompra > 0)
            this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND pagoscompras.estadoPagoPV != 'PAGADO' AND idMedioPagoPV=" + this.idMedioPago.ToString() + " AND pagoscompras.tipoDocumento='" + this.cmbTipoDocumento.Text + "' ";
          else
            this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND pagoscompras.estadoPagoPV != 'PAGADO' AND idMedioPagoPV=" + this.idMedioPago.ToString() + " AND (pagoscompras.tipoDocumento='FACTURA COMPRA' OR pagoscompras.tipoDocumento='FACTURA ELECTRONICA') ";
        }
        else if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND pagoscompras.estadoPagoPV != 'PAGADO' AND idMedioPagoPV > 0 AND pagoscompras.tipoDocumento='" + this.cmbTipoDocumento.Text + "'";
        else
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND pagoscompras.estadoPagoPV != 'PAGADO' AND idMedioPagoPV > 0 AND (pagoscompras.tipoDocumento='FACTURA COMPRA' OR pagoscompras.tipoDocumento='FACTURA ELECTRONICA') ";
        this.archivo = "PagoCompra001.rpt";
        dataTable = pagoCompra.pagoCompraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("PAGOCOMPRA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        if (this.idMedioPago > 0)
        {
          if (this.docCompra > 0)
            this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idMedioPagoPV=" + this.idMedioPago.ToString() + " AND pagoscompras.tipoDocumento='" + this.cmbTipoDocumento.Text + "' ";
          else
            this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idMedioPagoPV=" + this.idMedioPago.ToString();
        }
        else if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idMedioPagoPV > 0 AND pagoscompras.tipoDocumento='" + this.cmbTipoDocumento.Text + "' ";
        else
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idMedioPagoPV > 0";
        this.archivo = "PagoCompra002.rpt";
        dataTable = pagoCompra.pagoCompraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("PAGOCOMPRA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        if (this.docCompra > 0)
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idProveedor=" + this.codigoProveedor.ToString() + " AND pagoscompras.tipoDocumento='" + this.cmbTipoDocumento.Text + "' ";
        else
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idProveedor=" + this.codigoProveedor.ToString() + "  AND (pagoscompras.tipoDocumento='FACTURA COMPRA' OR pagoscompras.tipoDocumento='FACTURA ELECTRONICA') ";
        this.archivo = "PagoCompra003.rpt";
        dataTable = pagoCompra.pagoCompraInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("SERVICIO001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= '" + this.hasta + "'";
        this.archivo = "Servicio001.rpt";
        dataTable = servicio.servicioInforme(this.filtro);
      }

      //foreach (DataRow row in dataTable.Rows)
      //{
      //    if (row["idTipoDocumentoCompra"].ToString().Equals("7") || row["idTipoDocumentoCompra"].ToString().Equals("8"))
      //    {
      //        //Decimal descuento = Convert.ToDecimal(row["descuento"].ToString());
      //        //Decimal iva = Convert.ToDecimal(row["iva"].ToString());
      //        //Decimal neto = Convert.ToDecimal(row["neto"].ToString());
      //        //Decimal total = Convert.ToDecimal(row["total"].ToString());
      //        //Decimal totalpagado = Convert.ToDecimal(row["totalPagado"].ToString());
      //        //Decimal totalpendiente = Convert.ToDecimal(row["totalPendiente"].ToString());
      //        //Decimal otrosImpuestos = Convert.ToDecimal(row["otrosImpuestos"].ToString());
      //        //Decimal totalExento = Convert.ToDecimal(row["totalExento"].ToString());
      //        //Decimal totalCobrar = Convert.ToDecimal(row["totalCobrar"].ToString());
      //        //Decimal impuesto1 = Convert.ToDecimal(row["impuesto1"].ToString());
      //        //Decimal impuesto2 = Convert.ToDecimal(row["impuesto2"].ToString());
      //        //Decimal impuesto3 = Convert.ToDecimal(row["impuesto3"].ToString());
      //        //Decimal impuesto4 = Convert.ToDecimal(row["impuesto4"].ToString());
      //        //Decimal impuesto5 = Convert.ToDecimal(row["impuesto5"].ToString());

      //        string descuento = "-" + row["descuento"].ToString();
      //        string iva = "-" + row["iva"].ToString();
      //        string neto = "-" + row["neto"].ToString();
      //        string total = "-" + row["total"].ToString();
      //        string totalpagado = "-" + row["totalPagado"].ToString();
      //        string totalpendiente = "-" + row["totalPendiente"].ToString();
      //        string otrosImpuestos = "-" + row["otrosImpuestos"].ToString();
      //        string totalExento = "-" + row["totalExento"].ToString();
      //        string totalCobrar = "-" + row["totalCobrar"].ToString();
      //        string impuesto1 = "-" + row["impuesto1"].ToString();
      //        string impuesto2 = "-" + row["impuesto2"].ToString();
      //        string impuesto3 = "-" + row["impuesto3"].ToString();
      //        string impuesto4 = "-" + row["impuesto4"].ToString();
      //        string impuesto5 = "-" + row["impuesto5"].ToString();

      //        row["descuento"] = descuento;
      //        row["iva"] = iva;
      //        row["neto"] = neto;
      //        row["total"] = total;
      //        row["totalPagado"] = totalpagado;
      //        row["totalPendiente"] = totalpendiente;
      //        row["otrosImpuestos"] = otrosImpuestos;
      //        row["totalExento"] = totalExento;
      //        row["totalCobrar"] = totalCobrar;
      //        row["impuesto1"] = impuesto1;
      //        row["impuesto2"] = impuesto2;
      //        row["impuesto3"] = impuesto3;
      //        row["impuesto4"] = impuesto4;
      //        row["impuesto5"] = impuesto5;

      //    }
      //}

      try
      {
        ReportDocument rpt = new ReportDocument();
        rpt.Load("C:\\AptuSoft\\reportes\\" + this.archivo);
        rpt.SetDataSource(dataTable);
        new frmVisualizadorReportes(rpt).Show();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void txtRut_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtDigito.Focus();
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaProveedor(ref this.intance, "informe_compras").ShowDialog();
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

    private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolio);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.gpbFecha = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbProveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombreInforme = new System.Windows.Forms.Label();
            this.gpbCentroCosto = new System.Windows.Forms.GroupBox();
            this.cmbCentroCosto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblReporte = new System.Windows.Forms.Label();
            this.gpbFolio = new System.Windows.Forms.GroupBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbTipoDoc = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.gpbMediosPago = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.gpbPeriodo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpbFecha.SuspendLayout();
            this.gpbProveedor.SuspendLayout();
            this.gpbCentroCosto.SuspendLayout();
            this.gpbFolio.SuspendLayout();
            this.gpbTipoDoc.SuspendLayout();
            this.gpbMediosPago.SuspendLayout();
            this.gpbPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.dtpHasta);
            this.gpbFecha.Controls.Add(this.dtpDesde);
            this.gpbFecha.Controls.Add(this.label2);
            this.gpbFecha.Controls.Add(this.label1);
            this.gpbFecha.Location = new System.Drawing.Point(12, 46);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(235, 56);
            this.gpbFecha.TabIndex = 0;
            this.gpbFecha.TabStop = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(119, 31);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(104, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(6, 31);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(104, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HASTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESDE";
            // 
            // gpbProveedor
            // 
            this.gpbProveedor.Controls.Add(this.btnBuscaCliente);
            this.gpbProveedor.Controls.Add(this.txtRazonSocial);
            this.gpbProveedor.Controls.Add(this.txtDigito);
            this.gpbProveedor.Controls.Add(this.txtRut);
            this.gpbProveedor.Controls.Add(this.label4);
            this.gpbProveedor.Controls.Add(this.label3);
            this.gpbProveedor.Location = new System.Drawing.Point(12, 102);
            this.gpbProveedor.Name = "gpbProveedor";
            this.gpbProveedor.Size = new System.Drawing.Size(570, 65);
            this.gpbProveedor.TabIndex = 1;
            this.gpbProveedor.TabStop = false;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.Location = new System.Drawing.Point(425, 21);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(139, 33);
            this.btnBuscaCliente.TabIndex = 33;
            this.btnBuscaCliente.Text = "Buscar Proveedor";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(130, 29);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(267, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(93, 29);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(28, 20);
            this.txtDigito.TabIndex = 1;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(6, 29);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(84, 20);
            this.txtRut.TabIndex = 0;
            this.txtRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRut_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RAZON SOCIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RUT";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(426, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 50);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(507, 52);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombreInforme
            // 
            this.lblNombreInforme.AutoSize = true;
            this.lblNombreInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInforme.Location = new System.Drawing.Point(9, 17);
            this.lblNombreInforme.Name = "lblNombreInforme";
            this.lblNombreInforme.Size = new System.Drawing.Size(59, 16);
            this.lblNombreInforme.TabIndex = 5;
            this.lblNombreInforme.Text = "informe";
            // 
            // gpbCentroCosto
            // 
            this.gpbCentroCosto.Controls.Add(this.cmbCentroCosto);
            this.gpbCentroCosto.Controls.Add(this.label6);
            this.gpbCentroCosto.Location = new System.Drawing.Point(15, 101);
            this.gpbCentroCosto.Name = "gpbCentroCosto";
            this.gpbCentroCosto.Size = new System.Drawing.Size(228, 78);
            this.gpbCentroCosto.TabIndex = 6;
            this.gpbCentroCosto.TabStop = false;
            // 
            // cmbCentroCosto
            // 
            this.cmbCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCosto.FormattingEnabled = true;
            this.cmbCentroCosto.Location = new System.Drawing.Point(12, 35);
            this.cmbCentroCosto.Name = "cmbCentroCosto";
            this.cmbCentroCosto.Size = new System.Drawing.Size(203, 21);
            this.cmbCentroCosto.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CENTRO DE COSTO";
            // 
            // lblReporte
            // 
            this.lblReporte.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.Color.Silver;
            this.lblReporte.Location = new System.Drawing.Point(479, 169);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(100, 15);
            this.lblReporte.TabIndex = 8;
            this.lblReporte.Text = "reporte";
            this.lblReporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpbFolio
            // 
            this.gpbFolio.Controls.Add(this.txtFolio);
            this.gpbFolio.Controls.Add(this.label8);
            this.gpbFolio.Location = new System.Drawing.Point(14, 100);
            this.gpbFolio.Name = "gpbFolio";
            this.gpbFolio.Size = new System.Drawing.Size(169, 60);
            this.gpbFolio.TabIndex = 9;
            this.gpbFolio.TabStop = false;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(12, 31);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(133, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "INGRESE FOLIO";
            // 
            // gpbTipoDoc
            // 
            this.gpbTipoDoc.Controls.Add(this.label10);
            this.gpbTipoDoc.Controls.Add(this.label5);
            this.gpbTipoDoc.Controls.Add(this.cmbTipoDocumento);
            this.gpbTipoDoc.Location = new System.Drawing.Point(260, 32);
            this.gpbTipoDoc.Name = "gpbTipoDoc";
            this.gpbTipoDoc.Size = new System.Drawing.Size(157, 70);
            this.gpbTipoDoc.TabIndex = 10;
            this.gpbTipoDoc.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(6, 30);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(136, 21);
            this.cmbTipoDocumento.TabIndex = 11;
            // 
            // gpbMediosPago
            // 
            this.gpbMediosPago.Controls.Add(this.label9);
            this.gpbMediosPago.Controls.Add(this.cmbMedioPago);
            this.gpbMediosPago.Location = new System.Drawing.Point(12, 99);
            this.gpbMediosPago.Name = "gpbMediosPago";
            this.gpbMediosPago.Size = new System.Drawing.Size(161, 67);
            this.gpbMediosPago.TabIndex = 11;
            this.gpbMediosPago.TabStop = false;
            this.gpbMediosPago.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Medio de Pago";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(7, 35);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(141, 21);
            this.cmbMedioPago.TabIndex = 11;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(12, 32);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(130, 21);
            this.cmbPeriodo.TabIndex = 39;
            // 
            // gpbPeriodo
            // 
            this.gpbPeriodo.Controls.Add(this.label7);
            this.gpbPeriodo.Controls.Add(this.cmbPeriodo);
            this.gpbPeriodo.Location = new System.Drawing.Point(12, 46);
            this.gpbPeriodo.Name = "gpbPeriodo";
            this.gpbPeriodo.Size = new System.Drawing.Size(241, 61);
            this.gpbPeriodo.TabIndex = 7;
            this.gpbPeriodo.TabStop = false;
            this.gpbPeriodo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "PERIODO CONTABLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "[SELECCIONE] = TODOS";
            // 
            // frmLanzadorInformesCompras
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(594, 201);
            this.Controls.Add(this.gpbProveedor);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbMediosPago);
            this.Controls.Add(this.gpbTipoDoc);
            this.Controls.Add(this.gpbFolio);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.gpbCentroCosto);
            this.Controls.Add(this.lblNombreInforme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpbPeriodo);
            this.Name = "frmLanzadorInformesCompras";
            this.Text = "Lanzador de Informes";
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbProveedor.ResumeLayout(false);
            this.gpbProveedor.PerformLayout();
            this.gpbCentroCosto.ResumeLayout(false);
            this.gpbCentroCosto.PerformLayout();
            this.gpbFolio.ResumeLayout(false);
            this.gpbFolio.PerformLayout();
            this.gpbTipoDoc.ResumeLayout(false);
            this.gpbTipoDoc.PerformLayout();
            this.gpbMediosPago.ResumeLayout(false);
            this.gpbMediosPago.PerformLayout();
            this.gpbPeriodo.ResumeLayout(false);
            this.gpbPeriodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
