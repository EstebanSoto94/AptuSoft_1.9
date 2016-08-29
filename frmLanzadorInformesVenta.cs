 
// Type: Aptusoft.frmLanzadorInformesVenta
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.Properties;
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
  public class frmLanzadorInformesVenta : Form
  {
    private int codigoCliente = 0;
    private int idVendedor = 0;
    private int idCentroCosto = 0;
    private int idMedioPago = 0;
    private IContainer components = (IContainer) null;
    private string codigoInforme;
    private string filtro;
    private string desde;
    private string hasta;
    private string archivo;
    private frmLanzadorInformesVenta intance;
    private GroupBox gpbFecha;
    private GroupBox gpbCliente;
    private GroupBox gpbVendedor;
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
    private Label label5;
    private ComboBox cmbVendedor;
    private GroupBox gpbCentroCosto;
    private Label label6;
    private ComboBox cmbCentroCosto;
    private Button btnBuscaCliente;
    private GroupBox gpbCaja;
    private Label label7;
    private ComboBox cmbCaja;
    private Label lblReporte;
    private GroupBox gpbFolio;
    public TextBox txtFolio;
    private Label labelFolioBoleta;
    private GroupBox gpbMediosPago;
    private Label label9;
    private ComboBox cmbMedioPago;
    private GroupBox gpbEstadoPago;
    private Label label10;
    private ComboBox cmbEstadoPago;
    private GroupBox gpbTecnico;
    private ComboBox cmbTecnico;
    private Label label11;
    private Panel panel1;
    private CrystalReportViewer crvVisualizador;
    private GroupBox gpbEstadoOt;
    private Label label12;
    private ComboBox cmbEstadoOt;
    private RadioButton rdbBoletaNormal;
    private RadioButton rdbBoletaFiscal;
    private RadioButton rdbTodasLasBoletas;
    private GroupBox gpbCategoria;
    private Label label8;
    private ComboBox cmbCategoria;
    private GroupBox gpbPatente;
    private TextBox txtPatente;
    private Label label13;
    private PictureBox pictureBox1;
    private Label lblCatgandoReporte;
    private GroupBox gpbSubCategoria;
    private Label label14;
    private ComboBox cmbSubCategoria;

    public frmLanzadorInformesVenta()
    {
      this.InitializeComponent();
      this.intance = this;
    }

    public frmLanzadorInformesVenta(string informe, string codInforme, string VarFolio="")
    {
      this.InitializeComponent();
      this.lblNombreInforme.Text = informe;
      this.lblReporte.Text = codInforme;
      this.codigoInforme = codInforme;
      this.txtFolio.Text = VarFolio;
      this.intance = this;
      this.iniciaFormulario(codInforme);
    }

    private void cargaCategorias()
    {
      List<CategoriaVO> list = new Categoria().listaCategorias();
      list[0].Descripcion = "TODAS LAS CATEGORIAS";
      this.cmbCategoria.DataSource = (object) list;
      this.cmbCategoria.DisplayMember = "Descripcion";
      this.cmbCategoria.ValueMember = "IdCategoria";
      this.cmbCategoria.SelectedValue = (object) 0;
    }

    private void cargaSubCategoria(int idCat)
    {
      List<CategoriaVO> list = new Categoria().listaSubCategoriasLista(idCat);
      foreach (CategoriaVO categoriaVo in list)
      {
        if (categoriaVo.IdSubCategoria == 0)
          categoriaVo.DescripcionSubCategoria = "TODAS LAS SUBCATEGORIAS";
      }
      this.cmbSubCategoria.DataSource = (object) null;
      this.cmbSubCategoria.DataSource = (object) list;
      this.cmbSubCategoria.ValueMember = "IdSubCategoria";
      this.cmbSubCategoria.DisplayMember = "DescripcionSubCategoria";
      this.cmbSubCategoria.SelectedValue = (object) 0;
    }

    private bool validador()
    {
      bool flag = true;
      if (this.codigoInforme.Equals("FACTURA003") && this.cmbVendedor.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Seleccionar un Vendedor");
        this.cmbVendedor.Focus();
        flag = false;
      }
      if (this.codigoInforme.Equals("FACTURA004") && this.cmbCentroCosto.SelectedValue.ToString() == "0")
      {
        int num = (int) MessageBox.Show("Debe Seleccionar un Centro de Costo");
        this.cmbVendedor.Focus();
        flag = false;
      }
      return flag;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void buscaCliente()
    {
      ArrayList arrayList = new ArrayList();
      ArrayList cli = new Cliente().buscaRutCliente(this.txtRut.Text.Trim());
      if (cli.Count > 1)
      {
        this.txtRazonSocial.Enabled = false;
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "informe_factura").ShowDialog();
      }
      else if (cli.Count == 0)
      {
        int num1 = (int) MessageBox.Show("No Existe Cliente Consultado", "Alerta");
      }
      else
      {
        if (cli.Count != 1)
          return;
        foreach (ClienteVO clienteVo in cli)
          this.buscaClienteCodigo(clienteVo.Codigo);
      }
    }


    public void buscaClienteCodigo(int cod)
    {
      ClienteVO clienteVo = new Cliente().buscaCodigoCliente(cod);
      this.codigoCliente = clienteVo.Codigo;
      this.txtRut.Text = clienteVo.Rut;
      this.txtDigito.Text = clienteVo.Digito;
      this.txtRazonSocial.Text = clienteVo.RazonSocial;
      this.btnBuscar.Focus();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if (!this.validador())
        return;
      this.btnBuscar.Enabled = false;
      this.pictureBox1.Visible = true;
      this.lblCatgandoReporte.Visible = true;
      this.Refresh();
      this.lanzaInforme();
      this.lblCatgandoReporte.Visible = false;
      this.pictureBox1.Visible = false;
      this.btnBuscar.Enabled = true;
      this.Refresh();
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

    private void cargaMediosPago()
    {
      List<MedioPagoVO> list = new MedioPago().listaMediosPagoVenta();
      MedioPagoVO medioPagoVo = new MedioPagoVO();
      list[0].NombreMedioPago = "Todos";
      medioPagoVo.IdMedioPago = 99;
      medioPagoVo.NombreMedioPago = "Nota de Credito";
      list.Add(medioPagoVo);
      this.cmbMedioPago.DataSource = (object) list;
      this.cmbMedioPago.ValueMember = "idMedioPago";
      this.cmbMedioPago.DisplayMember = "nombreMedioPago";
      this.cmbMedioPago.SelectedValue = (object) 0;
    }

    private void cargaEstadosDePago()
    {
      this.cmbEstadoPago.DataSource = (object) new CargaMaestros().cargaEstadosPago();
      this.cmbEstadoPago.ValueMember = "codigo";
      this.cmbEstadoPago.DisplayMember = "descripcion";
      this.cmbEstadoPago.SelectedValue = (object) 0;
    }

    private void cargaTecnicos()
    {
      List<VendedorVO> list = new Tecnico().listaTecnicos();
      list[0].Nombre = "TODOS";
      this.cmbTecnico.DataSource = (object) list;
      this.cmbTecnico.ValueMember = "idVendedor";
      this.cmbTecnico.DisplayMember = "nombre";
      this.cmbTecnico.SelectedValue = (object) 0;
    }

    private void cargaGarzones()
    {
      List<VendedorVO> list = new Garzon().listaGarzonesVenta();
      list[0].Nombre = "TODOS";
      this.cmbTecnico.DataSource = (object) list;
      this.cmbTecnico.ValueMember = "idVendedor";
      this.cmbTecnico.DisplayMember = "nombre";
      this.cmbTecnico.SelectedValue = (object) 0;
    }

    private void cargaEstadoOT()
    {
      this.cmbEstadoOt.DataSource = (object) new CargaMaestros().listaEstadoOrdenTrabajoInforme();
      this.cmbEstadoOt.ValueMember = "IdBodega";
      this.cmbEstadoOt.DisplayMember = "NombreBodega";
      this.cmbEstadoOt.SelectedValue = (object) 3;
    }

    private void iniciaFormulario(string codInf)
    {
      List<CajaVO> list1 = new CargaMaestros().cargaCajaUsuario();
      list1.Add(new CajaVO()
      {
        IdCaja = 0,
        nombreCaja = "TODAS"
      });
      this.cmbCaja.DataSource = (object) Enumerable.ToList<CajaVO>((IEnumerable<CajaVO>) Enumerable.OrderBy<CajaVO, int>((IEnumerable<CajaVO>) list1, (Func<CajaVO, int>) (p => p.IdCaja)));
      this.cmbCaja.ValueMember = "IdCaja";
      this.cmbCaja.DisplayMember = "NombreCaja";
      if (frmMenuPrincipal.listaUsuario[0].VerInformCaja)
      {
        this.cmbCaja.Enabled = true;
        this.cmbCaja.SelectedValue = (object) 0;
      }
      else
      {
        this.cmbCaja.Enabled = false;
        this.cmbCaja.SelectedValue = (object) frmMenuPrincipal.listaUsuario[0].IdCaja;
      }
        //informe de ingreso manual
      if (this.codigoInforme.Equals("ingresomanual1"))
      {
          this.gpbCaja.Visible = false;
          this.gpbFecha.Visible = true;
          this.gpbCliente.Visible = false;
          this.gpbVendedor.Visible = false;
          this.gpbCentroCosto.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA009"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA010"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA011"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA012"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA013"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURA014"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      } if (this.codigoInforme.Equals("pos001"))
      {
          this.gpbFecha.Visible = true;
          this.gpbCliente.Visible = false;
          this.gpbVendedor.Visible = false;
          this.gpbCentroCosto.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("pos002"))
      {
          this.gpbFecha.Visible = true;
          this.gpbCliente.Visible = true;
          this.gpbVendedor.Visible = false;
          this.gpbCentroCosto.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("pos003"))
      {
          this.cmbVendedor.DataSource = (object)new Vendedor().listaVendedoresVenta();
          this.cmbVendedor.ValueMember = "idVendedor";
          this.cmbVendedor.DisplayMember = "nombre";
          this.cmbVendedor.SelectedValue = (object)0;
          this.gpbFecha.Visible = true;
          this.gpbCliente.Visible = false;
          this.gpbVendedor.Visible = true;
          this.gpbCentroCosto.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("pos004"))
      {
          this.cmbCentroCosto.DataSource = (object)new CentroCosto().listaCentroCostoVenta();
          this.cmbCentroCosto.ValueMember = "idCentroCosto";
          this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
          this.cmbCentroCosto.SelectedValue = (object)0;
          this.gpbFecha.Visible = true;
          this.gpbCentroCosto.Visible = true;
          this.gpbCliente.Visible = false;
          this.gpbVendedor.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("pos005"))
      {
          this.gpbFecha.Visible = true;
          this.gpbCliente.Visible = false;
          this.gpbVendedor.Visible = false;
          this.gpbCentroCosto.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("pos006"))
      {
          this.gpbFecha.Visible = true;
          this.gpbCliente.Visible = false;
          this.gpbVendedor.Visible = false;
          this.gpbCentroCosto.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("pos007"))
      {
          this.gpbFecha.Visible = true;
          this.gpbCliente.Visible = false;
          this.gpbVendedor.Visible = false;
          this.gpbCentroCosto.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("pos008"))
      {
          this.gpbFecha.Visible = true;
          this.gpbCliente.Visible = false;
          this.gpbVendedor.Visible = false;
          this.gpbCentroCosto.Visible = false;
          this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETA009"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL009"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = true;
      }
      if (this.codigoInforme.Equals("TICKET001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("TICKET002"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("TICKET003"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("TICKET004"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("TICKET005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("COTIZACION001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("COTIZACION002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("COTIZACION003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("COTIZACION004"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("COTIZACION005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("COTIZACION006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbMediosPago.Visible = true;
        this.cargaMediosPago();
      }
      if (this.codigoInforme.Equals("GUIA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIA007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIA008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIA009"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbMediosPago.Visible = true;
        this.cargaMediosPago();
      }
      if (this.codigoInforme.Equals("NOTAVENTA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA009"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA010"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTAVENTA011"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITO001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITO002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITO003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITO004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITO005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("VENTA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA003"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA004"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCaja.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.cargaCategorias();
        this.gpbCategoria.Visible = true;
        this.gpbSubCategoria.Visible = true;
      }
      if (this.codigoInforme.Equals("VENTA007"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA010"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCaja.Enabled = false;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA011"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA013"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA014"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA016"))
      {
        List<VendedorVO> list2 = new Vendedor().listaVendedoresVenta();
        list2[0].Nombre = "[TODOS]";
        this.cmbVendedor.DataSource = (object) list2;
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("VENTA017"))
      {
        new Vendedor().listaVendedoresVenta()[0].Nombre = "[TODOS]";
        this.label5.Text = "RUBROS";
        this.cmbVendedor.DataSource = (object) null;
        this.cmbVendedor.DisplayMember = "nombreRubro";
        this.cmbVendedor.ValueMember = "idRubro";
        this.cmbVendedor.DataSource = (object) new Rubro().listaRubrosConSeleccione();
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("PAGOVENTA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCaja.Enabled = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbMediosPago.Visible = true;
        this.cargaMediosPago();
      }
      if (this.codigoInforme.Equals("PAGOVENTA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCaja.Enabled = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbMediosPago.Visible = true;
        this.cargaMediosPago();
      }
      if (this.codigoInforme.Equals("PAGOVENTA003"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCaja.Enabled = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("PAGOVENTA004"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCaja.Enabled = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("PAGOVENTA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCaja.Enabled = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
        this.gpbEstadoPago.Visible = true;
        this.cargaEstadosDePago();
      }
      if (this.codigoInforme.Equals("CONTROLCAJA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA004"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("ORDENTRABAJO001"))
      {
        this.cargaEstadoOT();
        this.cargaTecnicos();
        this.gpbFecha.Visible = true;
        this.gpbTecnico.Visible = true;
        this.gpbEstadoOt.Visible = true;
        this.gpbPatente.Visible = true;
        this.gpbCliente.Visible = true;
        //this.gpbCliente.Visible = true
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("COMANDA001"))
      {
        this.cargaGarzones();
        this.gpbTecnico.Visible = true;
        this.label11.Text = "GARZONES";
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("DEVOLUCION001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.labelFolioBoleta.Text = "FOLIO BOLETA";
        this.rdbTodasLasBoletas.Visible = true;
        this.rdbBoletaNormal.Visible = true;
        this.rdbBoletaFiscal.Visible = true;
        this.rdbTodasLasBoletas.Checked = true;
        this.rdbBoletaNormal.Checked = false;
        this.rdbBoletaFiscal.Checked = false;
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA005"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA006"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = true;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA014"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA014"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbVendedor.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA005"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA006"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = true;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA014"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA009"))
      {
        this.gpbFecha.Visible = true;
        this.gpbFecha.Enabled = false;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = true;
        this.gpbCaja.Enabled = false;
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA001"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA002"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = true;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA003"))
      {
        this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
        this.cmbVendedor.ValueMember = "idVendedor";
        this.cmbVendedor.DisplayMember = "nombre";
        this.cmbVendedor.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = true;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA004"))
      {
        this.cmbCentroCosto.DataSource = (object) new CentroCosto().listaCentroCostoVenta();
        this.cmbCentroCosto.ValueMember = "idCentroCosto";
        this.cmbCentroCosto.DisplayMember = "nombreCentroCosto";
        this.cmbCentroCosto.SelectedValue = (object) 0;
        this.gpbFecha.Visible = true;
        this.gpbCentroCosto.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA005"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA006"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA007"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA008"))
      {
        this.gpbFecha.Visible = true;
        this.gpbCliente.Visible = false;
        this.gpbVendedor.Visible = false;
        this.gpbCentroCosto.Visible = false;
        this.gpbFolio.Visible = false;
      }
      if (!this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA009"))
        return;
      this.gpbFecha.Visible = true;
      this.gpbFecha.Enabled = false;
      this.gpbCliente.Visible = false;
      this.gpbVendedor.Visible = false;
      this.gpbCentroCosto.Visible = false;
      this.gpbFolio.Visible = true;
      this.gpbCaja.Enabled = false;
    }

    public void lanzaInforme()
    {
      string str1 = !(this.cmbCaja.SelectedValue.ToString() == "0") ? "caja='" + this.cmbCaja.SelectedValue.ToString() + "'" : "caja > '0'";
      Factura factura = new Factura();
      DataTable dataTable = new DataTable();
      VoIngresoManuales man = new VoIngresoManuales();
        //ingreso manual
      if (this.codigoInforme.Equals("ingresomanual1"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.filtro = "DATE_FORMAT(fecha, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fecha, '%Y-%m-%d') <= '" + this.hasta+"'";
          this.archivo = "ingresomanuales1.rpt";
          dataTable = man.select(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "Factura001.rpt";
        dataTable = factura.facturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" +  this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura002.rpt";
        dataTable = factura.facturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" +  this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura003.rpt";
        dataTable = factura.facturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" +  this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura004.rpt";
        dataTable = factura.facturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA005"))
      {
        this.filtro = "(estadoPago= 'PENDIENTE' OR estadoPago= 'DOCUMENTADO') AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura005.rpt";
        dataTable = factura.facturaInformePagos(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA006"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "(DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "') AND (idCliente='" + this.codigoCliente.ToString() + "') AND (estadoPago= 'PENDIENTE' OR estadoPago= 'DOCUMENTADO') AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura006.rpt";
        dataTable = factura.facturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA007"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='ANULADA' AND " + str1;
        this.archivo = "Factura007.rpt";
        dataTable = factura.facturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA008"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaVencimiento, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaVencimiento, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura008.rpt";
        dataTable = factura.facturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA009"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura009.rpt";
        dataTable = factura.facturaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA010"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "(DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "') AND (idCliente='" + this.codigoCliente.ToString() + "') AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura010.rpt";
        dataTable = factura.facturaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA011"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura011.rpt";
        dataTable = factura.facturaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA012"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura012.rpt";
        dataTable = factura.facturaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA013"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Factura013.rpt";
        dataTable = factura.facturaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURA014"))
      {
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "Factura.rpt";
        dataTable = factura.muestraFacturaFolio(Convert.ToInt32(this.filtro));
      }
      Boleta boleta = new Boleta();
      if (this.codigoInforme.Equals("pos001"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + " AND folio = 0";
          this.archivo = "pos001.rpt";
          dataTable = boleta.posInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("pos002"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND rut='" + this.txtRut.Text + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND folio = 0";
          this.archivo = "pos002.rpt";
          dataTable = boleta.posInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("pos003"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND folio = 0";
          this.archivo = "pos003.rpt";
          dataTable = boleta.posInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("pos004"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND folio = 0";
          this.archivo = "pos004.rpt";
          dataTable = boleta.posInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("pos005"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='ANULADA' AND " + str1 + " AND folio = 0";
          this.archivo = "pos005.rpt";
          dataTable = boleta.posInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("pos006"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND folio = 0";
          this.archivo = "pos006.rpt";
          dataTable = boleta.posInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("pos007"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND folio = 0";
          this.archivo = "pos007.rpt";
          dataTable = boleta.posInformeDetalleCategoriaProductos(this.filtro);
      }
      if (this.codigoInforme.Equals("pos008"))
      {
          this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
          this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND folio = 0";
          this.archivo = "pos008.rpt";
          dataTable = boleta.posInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + " AND folio <> 0";
        this.archivo = "Boleta001.rpt";
        dataTable = boleta.boletaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND rut='" + this.txtRut.Text + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Boleta002.rpt";
        dataTable = boleta.boletaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Boleta003.rpt";
        dataTable = boleta.boletaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND folio <> 0";
        this.archivo = "Boleta004.rpt";
        dataTable = boleta.boletaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA005"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='ANULADA' AND " + str1 + " AND folio <> 0";
        this.archivo = "Boleta005.rpt";
        dataTable = boleta.boletaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA006"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Boleta006.rpt";
        dataTable = boleta.boletaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA007"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Boleta007.rpt";
        dataTable = boleta.boletaInformeDetalleCategoriaProductos(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA008"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Boleta008.rpt";
        dataTable = boleta.boletaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETA009"))
      {
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "Boleta.rpt";
        dataTable = boleta.muestraBoletaFolio(Convert.ToInt32(this.filtro));
      }
      BoletaFiscal boletaFiscal = new BoletaFiscal();
      if (this.codigoInforme.Equals("BOLETAFISCAL001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "BoletaFiscal001.rpt";
        dataTable = boletaFiscal.boletaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" +  this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaFiscal002.rpt";
        dataTable = boletaFiscal.boletaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaFiscal003.rpt";
        dataTable = boletaFiscal.boletaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL006"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaFiscal006.rpt";
        dataTable = boletaFiscal.boletaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL007"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaFiscal007.rpt";
        dataTable = boletaFiscal.boletaInformeDetalleCategoriaProductos(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL008"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaFiscal008.rpt";
        dataTable = boletaFiscal.boletaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAFISCAL009"))
      {
        int caja = Convert.ToInt32(this.cmbCaja.SelectedValue.ToString());
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "BoletaFiscal.rpt";
        dataTable = boletaFiscal.muestraBoletaFolio(Convert.ToInt32(this.filtro), caja);
      }
      Ticket ticket = new Ticket();
      if (this.codigoInforme.Equals("TICKET001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "Ticket001.rpt";
        dataTable = ticket.ticketInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("TICKET002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDO' AND " + str1;
        this.archivo = "Ticket002.rpt";
        dataTable = ticket.ticketInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("TICKET003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND rut ='" + this.txtRut.Text + "' AND estadoDocumento='EMITIDO' AND " + str1;
        this.archivo = "Ticket003.rpt";
        dataTable = ticket.ticketInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("TICKET004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='ANULADO' AND " + str1;
        this.archivo = "Ticket004.rpt";
        dataTable = ticket.ticketInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("TICKET005"))
      {
        this.filtro = "folio =" + this.txtFolio.Text.Trim();
        this.archivo = "Ticket.rpt";
        dataTable = ticket.ticketInformeDetalle(this.filtro);
      }
      Cotizacion cotizacion = new Cotizacion();
      if (this.codigoInforme.Equals("COTIZACION001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "Cotizacion001.rpt";
        dataTable = cotizacion.cotizacionInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("COTIZACION002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object)this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + this.codigoCliente.ToString() +"' AND estadoDocumento='EMITIDO' AND " + str1;
        this.archivo = "Cotizacion002.rpt";
        dataTable = cotizacion.cotizacionInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("COTIZACION003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" +  this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDO' AND " + str1;
        this.archivo = "Cotizacion003.rpt";
        dataTable = cotizacion.cotizacionInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("COTIZACION004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDO' AND " + str1;
        this.archivo = "Cotizacion004.rpt";
        dataTable = cotizacion.cotizacionInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("COTIZACION005"))
      {
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "Cotizacion.rpt";
        dataTable = cotizacion.muestraCotizacionFolio(Convert.ToInt32(this.filtro));
      }
      if (this.codigoInforme.Equals("COTIZACION006"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDO' AND folioDocumentoVenta=0 AND " + str1;
        this.archivo = "Cotizacion006.rpt";
        dataTable = cotizacion.cotizacionInformeDetalle(this.filtro);
      }
      Guia guia = new Guia();
      if (this.codigoInforme.Equals("GUIA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        if (this.idMedioPago > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + "AND idMedioPago=" + this.idMedioPago.ToString();
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + "AND idMedioPago > 0";
        this.archivo = "Guia001.rpt";
        dataTable = guia.guiaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND rut='" +  this.txtRut.Text + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Guia002.rpt";
        dataTable = guia.guiaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Guia003.rpt";
        dataTable = guia.guiaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIA004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" +  this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Guia004.rpt";
        dataTable = guia.guiaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIA005"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='ANULADA' AND " + str1;
        this.archivo = "Guia005.rpt";
        dataTable = guia.guiaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIA006"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND facturada='0'";
        this.archivo = "Guia006.rpt";
        dataTable = guia.guiaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIA007"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND facturada='0'";
        this.archivo = "Guia007.rpt";
        dataTable = guia.guiaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIA008"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Guia008.rpt";
        dataTable = guia.guiaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIA009"))
      {
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "Guia.rpt";
        dataTable = guia.muestraGuiaFolio(Convert.ToInt32(this.filtro));
      }
      NotaVenta notaVenta = new NotaVenta();
      if (this.codigoInforme.Equals("NOTAVENTA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        if (this.idMedioPago > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + "AND idMedioPago=" + this.idMedioPago.ToString();
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + "AND idMedioPago > 0";
        this.archivo = "NotaVenta001.rpt";
        dataTable = notaVenta.notaVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" +  this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaVenta002.rpt";
        dataTable = notaVenta.notaVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" +  this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaVenta003.rpt";
        dataTable = notaVenta.notaVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" +  this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaVenta004.rpt";
        dataTable = notaVenta.notaVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA005"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='ANULADA' AND " + str1;
        this.archivo = "NotaVenta005.rpt";
        dataTable = notaVenta.notaVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA006"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + " AND idDocumentoVenta='0' AND estadoDocumento='EMITIDA'";
        this.archivo = "NotaVenta006.rpt";
        dataTable = notaVenta.notaVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA007"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" +  this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND idDocumentoVenta='0'";
        this.archivo = "NotaVenta007.rpt";
        dataTable = notaVenta.notaVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA008"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + " AND estadoDocumento='EMITIDA'";
        this.archivo = "NotaVenta008.rpt";
        dataTable = notaVenta.notaVentaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA009"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + " AND estadoDocumento='EMITIDA'";
        this.archivo = "NotaVenta009.rpt";
        dataTable = notaVenta.notaVentaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA010"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" +  this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaVenta010.rpt";
        dataTable = notaVenta.notaVentaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTAVENTA011"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "NotaVenta.rpt";
        dataTable = notaVenta.muestraNotaVentaFolio(Convert.ToInt32(this.filtro));
      }
      NotaCredito notaCredito = new NotaCredito();
      if (this.codigoInforme.Equals("NOTACREDITO001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "NotaCredito001.rpt";
        dataTable = notaCredito.notaCreditoInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTACREDITO002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object)this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND rut='" + this.txtRut.Text +"' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaCredito002.rpt";
        dataTable = notaCredito.notaCreditoInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTACREDITO003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaCredito003.rpt";
        dataTable = notaCredito.notaCreditoInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTACREDITO004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object)this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() +"' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaCredito004.rpt";
        dataTable = notaCredito.notaCreditoInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTACREDITO005"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "NotaCredito.rpt";
        dataTable = notaCredito.muestraNotaCreditoFolio(Convert.ToInt32(this.filtro));
      }
      VentaGeneral ventaGeneral = new VentaGeneral();
      if (this.codigoInforme.Equals("VENTA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "Venta001.rpt";
        dataTable = ventaGeneral.cierreDiaInforme(this.filtro);
        if (this.cmbCaja.SelectedValue.ToString() == "0")
        {
          for (int index = 0; index < dataTable.Rows.Count; ++index)
            dataTable.Rows[index]["caja"] = (object) 0;
        }
      }
      if (this.codigoInforme.Equals("VENTA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "Venta002.rpt";
        dataTable = ventaGeneral.libroVentasInforme(this.filtro);
        if (this.cmbCaja.SelectedValue.ToString() == "0")
        {
          for (int index = 0; index < dataTable.Rows.Count; ++index)
            dataTable.Rows[index]["caja"] = (object) 0;
        }
      }
      if (this.codigoInforme.Equals("VENTA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + " AND folio <> 0";
        this.archivo = "Venta003.rpt";
        dataTable = boleta.boletaInforme(this.filtro);
        if (this.cmbCaja.SelectedValue.ToString() == "0")
        {
          for (int index = 0; index < dataTable.Rows.Count; ++index)
            dataTable.Rows[index]["caja"] = (object) 0;
        }
      }
      if (this.codigoInforme.Equals("VENTA004"))
      {
        Cliente cliente = new Cliente();
        this.archivo = "Venta004.rpt";
        dataTable = cliente.listadoClientesInforme();
      }
      if (this.codigoInforme.Equals("VENTA005"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1 + " AND folio <> 0";
        this.archivo = "Venta005.rpt";
        dataTable = ventaGeneral.boletaFacturaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("VENTA006"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        string str2 = this.cmbCategoria.Text.Equals("TODAS LAS CATEGORIAS") ? "" : " AND productos.Categoria = '" + this.cmbCategoria.Text + "'";
        string str3 = "";
        int num;
        if (this.cmbSubCategoria.Items.Count > 0)
        {
          num = Convert.ToInt32(this.cmbSubCategoria.SelectedValue.ToString());
          str3 = this.cmbSubCategoria.Text;
        }
        else
          num = 0;
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1 + str2;
        if (num > 0)
          this.filtro = this.filtro + " AND productos.SubCategoria = '" + str3 + "'";
        this.archivo = "Venta006.rpt";
        dataTable = ventaGeneral.boletaFacturaInformeDetalleCategoriaProductos(this.filtro);
      }
      if (this.codigoInforme.Equals("VENTA007"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "Venta007.rpt";
        dataTable = ventaGeneral.boletaFacturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("VENTA010"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "idCliente='" + (object) this.codigoCliente + "'";
        this.archivo = "Venta010.rpt";
        dataTable = ventaGeneral.boletaFacturaNotaCreditoInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("VENTA011"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "(DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "') AND " + str1 + " AND folio <> 0"; 
        this.archivo = "Venta011.rpt";
        dataTable = ventaGeneral.resumenVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("VENTA013"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "idVendedor= '" + this.idVendedor + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object)this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND  estadoDocumento='EMITIDA'  AND " + str1;
        this.archivo = "Venta013.rpt";
        dataTable = ventaGeneral.boletaFacturaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("VENTA014"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "Venta014.rpt";
        dataTable = ventaGeneral.libroVentasBoletaFiscalInforme(this.filtro);
        if (this.cmbCaja.SelectedValue.ToString() == "0")
        {
          for (int index = 0; index < dataTable.Rows.Count; ++index)
            dataTable.Rows[index]["caja"] = (object) 0;
        }
      }
      if (this.codigoInforme.Equals("VENTA016"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        if (this.idVendedor > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" +  this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1+ " AND folio <> 0";
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1+ " AND folio <> 0";
        this.archivo = "Venta016.rpt";
        dataTable = ventaGeneral.boletaFacturaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("VENTA017"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        string text = this.cmbVendedor.Text;
        string str2 = !(text != "[TODOS]") ? "" : " AND rubro='" + text + "' ";
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1 + str2;
        this.archivo = "Venta017.rpt";
        dataTable = ventaGeneral.boletaFacturaInformeDetalle(this.filtro);
      }
      PagoVenta pagoVenta = new PagoVenta();
      if (this.codigoInforme.Equals("PAGOVENTA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        if (this.idMedioPago > 0)
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND pagosventas.estadoPagoPV != 'PAGADO' AND idMedioPagoPV=" + this.idMedioPago.ToString() + " AND " + str1;
        else
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND pagosventas.estadoPagoPV != 'PAGADO' AND idMedioPagoPV > 0  AND " + str1;
        this.archivo = "PagoVenta001.rpt";
        dataTable = pagoVenta.pagoVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("PAGOVENTA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idMedioPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue.ToString());
        if (this.idMedioPago > 0)
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idMedioPagoPV=" + this.idMedioPago.ToString() + " AND " + str1;
        else
          this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idMedioPagoPV > 0  AND " + str1;
        this.archivo = "PagoVenta002.rpt";
        dataTable = pagoVenta.pagoVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("PAGOVENTA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaCobro, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaCobro, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente=" + this.codigoCliente.ToString() + " AND " + str1;
        this.archivo = "PagoVenta003.rpt";
        dataTable = pagoVenta.pagoVentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("PAGOVENTA004"))
      {
        this.filtro = "estadoPago='PENDIENTE'  AND " + str1;
        this.archivo = "PagoVenta004.rpt";
        dataTable = ventaGeneral.boletaFacturaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("PAGOVENTA005"))
      {
        int num = Convert.ToInt32(this.cmbEstadoPago.SelectedValue.ToString());
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        if (num == 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        if (num == 1)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoPago='PAGADO' AND " + str1;
        if (num == 2)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoPago='DOCUMENTADO' AND " + str1;
        if (num == 3)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoPago='PENDIENTE' AND " + str1;
        this.archivo = "PagoVenta005.rpt";
        dataTable = ventaGeneral.boletaFacturaInforme(this.filtro);
      }
      ControlCaja controlCaja = new ControlCaja();
      if (this.codigoInforme.Equals("CONTROLCAJA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "ControlCaja001.rpt";
        dataTable = controlCaja.controlCajaInforme(this.filtro);
      }
      FacturaExenta facturaExenta = new FacturaExenta();
      if (this.codigoInforme.Equals("FACTURAEXENTA001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "FacturaExenta001.rpt";
        dataTable = facturaExenta.facturaExentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA002"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExenta002.rpt";
        dataTable = facturaExenta.facturaExentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA003"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" +  this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExenta003.rpt";
        dataTable = facturaExenta.facturaExentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA004"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "(DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "') AND (estadoPago= 'PENDIENTE' OR estadoPago= 'DOCUMENTADO') AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExenta004.rpt";
        dataTable = facturaExenta.facturaExentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA005"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "(DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object)this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "') AND (idCliente='" + this.codigoCliente.ToString() +"') AND (estadoPago= 'PENDIENTE' OR estadoPago= 'DOCUMENTADO') AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExenta005.rpt";
        dataTable = facturaExenta.facturaExentaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA006"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExenta006.rpt";
        dataTable = facturaExenta.facturaExentaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA007"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExenta007.rpt";
        dataTable = facturaExenta.facturaExentaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTA008"))
      {
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "FacturaExenta.rpt";
        dataTable = facturaExenta.muestraFacturaExentaFolio(Convert.ToInt32(this.filtro));
      }
      if (this.codigoInforme.Equals("ORDENTRABAJO001"))
      {
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        this.hasta = this.dtpHasta.Value.ToString("yyyy-MM-dd");
        string str2 = this.cmbTecnico.SelectedValue.ToString();
        string str3 = this.cmbEstadoOt.SelectedValue.ToString();
        string str4 = this.txtRut.Text;
        string str5 = " ";
        string str6 = " ";
        if (str2 != "0")
          str5 = " AND idTecnico=" + str2 + " ";
        if (str3 != "3")
          str6 = " AND idEstadoOT=" + str3 + " ";
        if (str4.Length > 0)
          str4 = " AND rut='" + str4 + "'";
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + str5 + str6 + str4;
        this.archivo = "OrdenTrabajo001.rpt";
        dataTable = new OrdenTrabajo().otInforme(this.filtro);
      }
      Comanda comanda = new Comanda();
      DateTime dateTime=DateTime.Now;
      if (this.codigoInforme.Equals("COMANDA001"))
      {
        string str2 = this.cmbTecnico.SelectedValue.ToString();
        string str3 = !(str2 != "0") ? "" : " AND idVendedor='" + str2 + "'";
        this.desde = this.dtpDesde.Value.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + str3;
        this.archivo = "Comanda001.rpt";
        dataTable = comanda.comandaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("DEVOLUCION001"))
      {
        Devolucion devolucion = new Devolucion();
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        string str2 = this.txtFolio.Text.Trim().Length > 0 ? " AND folioBoleta=" + this.txtFolio.Text.Trim() : "";
        string str3 = !this.rdbBoletaFiscal.Checked ? (!this.rdbBoletaNormal.Checked ? "" : " AND documento='NORMAL'") : " AND documento='FISCAL'";
        this.filtro = "DATE_FORMAT(fecha, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fecha, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1 + str2 + str3;
        this.archivo = "Devolucion001.rpt";
        dataTable = devolucion.devolucionInforme(this.filtro);
      }
      EFactura efactura = new EFactura();
      if (this.codigoInforme.Equals("FACTURAELECTRONICA001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "FacturaElectronica001.rpt";
        dataTable = efactura.facturaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA002"))
      {
        //dateTime = this.dtpDesde.Value;
        //this.desde = dateTime.ToString("yyyy-MM-dd");
        //dateTime = this.dtpHasta.Value;
        //this.hasta = dateTime.ToString("yyyy-MM-dd");
        //this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + (string) (object) this.codigoCliente + "' AND estadoDocumento='EMITIDA' AND " + str1;
        //this.archivo = "FacturaElectronica002.rpt";
        //dataTable = efactura.facturaElectronicaInforme(this.filtro);
          dateTime = this.dtpDesde.Value;
          this.desde = dateTime.ToString("yyyy-MM-dd");
          dateTime = this.dtpHasta.Value;
          this.hasta = dateTime.ToString("yyyy-MM-dd");
          object[] objArray = new object[8];
          int index1 = 0;
          string str2 = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '";
          objArray[index1] = (object)str2;
          int index2 = 1;
          string str3 = this.desde;
          objArray[index2] = (object)str3;
          int index3 = 2;
          string str4 = "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '";
          objArray[index3] = (object)str4;
          int index4 = 3;
          string str5 = this.hasta;
          objArray[index4] = (object)str5;
          int index5 = 4;
          string str6 = "' AND idCliente='";
          objArray[index5] = (object)str6;
          int index6 = 5;
          // ISSUE: variable of a boxed type
          int local = this.codigoCliente;
          objArray[index6] = (object)local;
          int index7 = 6;
          string str7 = "' AND estadoDocumento='EMITIDA' AND ";
          objArray[index7] = (object)str7;
          int index8 = 7;
          string str8 = str1;
          objArray[index8] = (object)str8;
          this.filtro = string.Concat(objArray);
          this.archivo = "FacturaElectronica002.rpt";
          dataTable = efactura.facturaElectronicaInforme(this.filtro);

      }


      if (this.codigoInforme.Equals("FACTURAELECTRONICA003"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaElectronica003.rpt";
        dataTable = efactura.facturaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA004"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaElectronica004.rpt";
        dataTable = efactura.facturaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA005"))
      {
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        string str2 = "";
        if (this.idVendedor > 0)
          str2 = " AND idVendedor='" + (object) this.idVendedor + "' ";
        this.filtro = "(estadoPago= 'PENDIENTE' OR estadoPago= 'DOCUMENTADO') AND estadoDocumento='EMITIDA' AND " + str1 + str2;
        this.archivo = "FacturaElectronica005.rpt";
        dataTable = efactura.facturaElectronicaInformePagos(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAELECTRONICA006"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        if (this.idCentroCosto > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaElectronica006.rpt";
        dataTable = efactura.facturaElectronicaInformeProductoCategoria(this.filtro);
      }
      ArrayList arrayList;
      if (this.codigoInforme.Equals("FACTURAELECTRONICA014"))
      {
          if (this.txtFolio.Text.Trim() != "" && this.txtFolio.Text.Trim() != null)
          {
              if (frmMenuPrincipal._MultiEmpresa)
              {
                  LeeXml leeXml = new LeeXml();
                  arrayList = new ArrayList();
                  this.archivo = "FacturaElectronica_" + leeXml.cargarDatosMultiEmpresa("factura")[1].ToString() + ".rpt";
              }
              else
                  this.archivo = "FacturaElectronica.rpt";
              this.filtro = this.txtFolio.Text.Trim();
              dataTable = efactura.muestraFacturaFolio(Convert.ToInt32(this.filtro));
          }
          else
          {
              MessageBox.Show("Debe Ingresar Folio a Buscar");
             
          }
      }
      ENotaCredito enotaCredito = new ENotaCredito();
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "NotaCreditoElectronica001.rpt";
        dataTable = enotaCredito.notaCreditoElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA002"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaCreditoElectronica002.rpt";
        dataTable = enotaCredito.notaCreditoElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA003"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaCreditoElectronica003.rpt";
        dataTable = enotaCredito.notaCreditoElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA004"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" +  this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaCreditoElectronica004.rpt";
        dataTable = enotaCredito.notaCreditoElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTACREDITOELECTRONICA005"))
      {
        if (frmMenuPrincipal._MultiEmpresa)
        {
          LeeXml leeXml = new LeeXml();
          arrayList = new ArrayList();
          this.archivo = "NotaCreditoElectronica_" + leeXml.cargarDatosMultiEmpresa("factura")[1].ToString() + ".rpt";
        }
        else
          this.archivo = "NotaCreditoElectronica.rpt";
        this.filtro = this.txtFolio.Text.Trim();
        dataTable = enotaCredito.muestraNotaCreditoFolio(Convert.ToInt32(this.filtro));
      }
      ENotaDebito enotaDebito = new ENotaDebito();
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "NotaDebitoElectronica001.rpt";
        dataTable = enotaDebito.notaDebitoElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA002"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" +  this.codigoCliente + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaDebitoElectronica002.rpt";
        dataTable = enotaDebito.notaDebitoElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA003"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaDebitoElectronica003.rpt";
        dataTable = enotaDebito.notaDebitoElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA004"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "NotaDebitoElectronica004.rpt";
        dataTable = enotaDebito.notaDebitoElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("NOTADEBITOELECTRONICA005"))
      {
        if (frmMenuPrincipal._MultiEmpresa)
        {
          LeeXml leeXml = new LeeXml();
          arrayList = new ArrayList();
          this.archivo = "NotaDebitoElectronica_" + leeXml.cargarDatosMultiEmpresa("factura")[1].ToString() + ".rpt";
        }
        else
          this.archivo = "NotaDebitoElectronica.rpt";
        this.filtro = this.txtFolio.Text.Trim();
        dataTable = enotaDebito.muestraNotaDebitoFolio(Convert.ToInt32(this.filtro));
      }
      EGuia eguia = new EGuia();
      if (this.codigoInforme.Equals("GUIAELECTRONICA001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "GuiaElectronica001.rpt";
        dataTable = eguia.guiaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA002"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + this.codigoCliente + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "GuiaElectronica002.rpt";
        dataTable = eguia.guiaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA003"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("dvvvvvvvvgcrrrrrryyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "GuiaElectronica003.rpt";
        dataTable = eguia.guiaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA004"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "GuiaElectronica004.rpt";
        dataTable = eguia.guiaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA005"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND facturada=0 AND " + str1;
        this.archivo = "GuiaElectronica005.rpt";
        dataTable = eguia.guiaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("GUIAELECTRONICA014"))
      {
        if (frmMenuPrincipal._MultiEmpresa)
        {
          LeeXml leeXml = new LeeXml();
          arrayList = new ArrayList();
          this.archivo = "GuiaElectronica_" + leeXml.cargarDatosMultiEmpresa("factura")[1].ToString() + ".rpt";
        }
        else
          this.archivo = "GuiaElectronica.rpt";
        this.filtro = this.txtFolio.Text.Trim();
        dataTable = eguia.muestraGuiaFolio(Convert.ToInt32(this.filtro));
      }
      EFacturaExenta efacturaExenta = new EFacturaExenta();
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "FacturaExentaElectronica001.rpt";
        dataTable = efacturaExenta.facturaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA002"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExentaElectronica002.rpt";
        dataTable = efacturaExenta.facturaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA003"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExentaElectronica003.rpt";
        dataTable = efacturaExenta.facturaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA004"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExentaElectronica004.rpt";
        dataTable = efacturaExenta.facturaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA005"))
      {
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        string str2 = "";
        if (this.idVendedor > 0)
          str2 = " AND idVendedor='" + (object) this.idVendedor + "' ";
        this.filtro = "(estadoPago= 'PENDIENTE' OR estadoPago= 'DOCUMENTADO') AND estadoDocumento='EMITIDA' AND " + str1 + str2;
        this.archivo = "FacturaExentaElectronica005.rpt";
        dataTable = efacturaExenta.facturaElectronicaInformePagos(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA006"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        if (this.idCentroCosto > 0)
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        else
          this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "FacturaExentaElectronica006.rpt";
        dataTable = efacturaExenta.facturaElectronicaInformeProductoCategoria(this.filtro);
      }
      if (this.codigoInforme.Equals("FACTURAEXENTAELECTRONICA014"))
      {
        if (frmMenuPrincipal._MultiEmpresa)
        {
          LeeXml leeXml = new LeeXml();
          arrayList = new ArrayList();
          this.archivo = "FacturaExentaElectronica_" + leeXml.cargarDatosMultiEmpresa("factura")[1].ToString() + ".rpt";
        }
        else
          this.archivo = "FacturaExentaElectronica.rpt";
        this.filtro = this.txtFolio.Text.Trim();
        dataTable = efacturaExenta.muestraFacturaFolio(Convert.ToInt32(this.filtro));
      }
      EBoleta eboleta = new EBoleta();
      if (this.codigoInforme.Equals("BOLETAELECTRONICA001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "BoletaElectronica001.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA002"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" + this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica002.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA003"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" +  this.idVendedor.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica003.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA004"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica004.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA005"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='ANULADA' AND " + str1;
        this.archivo = "BoletaElectronica005.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA006"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica006.rpt";
        dataTable = eboleta.boletaElectronicaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA007"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica007.rpt";
        dataTable = eboleta.boletaElectronicaInformeProductoCategoria(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA008"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica008.rpt";
        dataTable = eboleta.boletaElectronicaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAELECTRONICA009"))
      {
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "BoletaElectronica.rpt";
        dataTable = eboleta.muestraBoletaFolio(Convert.ToInt32(this.filtro));
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA001"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND " + str1;
        this.archivo = "BoletaElectronica001.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA002"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCliente='" +  this.codigoCliente.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica002.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA003"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idVendedor = Convert.ToInt32(this.cmbVendedor.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object)this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idVendedor='" + this.idVendedor.ToString() +"' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica003.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA004"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.idCentroCosto = Convert.ToInt32(this.cmbCentroCosto.SelectedValue.ToString());
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + (object) this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND idCentroCosto='" + this.idCentroCosto.ToString() + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica004.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA005"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='ANULADA' AND " + str1;
        this.archivo = "BoletaElectronica005.rpt";
        dataTable = eboleta.boletaElectronicaInforme(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA006"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica006.rpt";
        dataTable = eboleta.boletaElectronicaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA007"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica007.rpt";
        dataTable = eboleta.boletaElectronicaInformeProductoCategoria(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA008"))
      {
        dateTime = this.dtpDesde.Value;
        this.desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHasta.Value;
        this.hasta = dateTime.ToString("yyyy-MM-dd");
        this.filtro = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + this.desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + this.hasta + "' AND estadoDocumento='EMITIDA' AND " + str1;
        this.archivo = "BoletaElectronica008.rpt";
        dataTable = eboleta.boletaElectronicaInformeDetalle(this.filtro);
      }
      if (this.codigoInforme.Equals("BOLETAEXENTAELECTRONICA009"))
      {
        this.filtro = this.txtFolio.Text.Trim();
        this.archivo = "BoletaElectronica.rpt";
        dataTable = eboleta.muestraBoletaFolio(Convert.ToInt32(this.filtro));
      }
      try
      {
        ReportDocument reportDocument = new ReportDocument();
        reportDocument.Load("C:\\AptuSoft\\reportes\\" + this.archivo);
        reportDocument.SetDataSource(dataTable);
        this.crvVisualizador.ReportSource = (object) reportDocument;
        this.crvVisualizador.RefreshReport();
      }
      catch (Exception ex)
      {
        //int num = (int) MessageBox.Show("Error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
      int num = (int) new frmBuscaClientes(ref this.intance, "informe_factura").ShowDialog();
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

    private void frmLanzadorInformesVenta_Load(object sender, EventArgs e)
    {
    }

    private void cmbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
    {
      int idCat = Convert.ToInt32(this.cmbCategoria.SelectedValue.ToString());
      if (idCat > 0)
        this.cargaSubCategoria(idCat);
      else
        this.cmbSubCategoria.DataSource = (object) null;
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
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.gpbVendedor = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.lblNombreInforme = new System.Windows.Forms.Label();
            this.gpbCentroCosto = new System.Windows.Forms.GroupBox();
            this.cmbCentroCosto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbCaja = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.gpbFolio = new System.Windows.Forms.GroupBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.labelFolioBoleta = new System.Windows.Forms.Label();
            this.gpbMediosPago = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.gpbEstadoPago = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstadoPago = new System.Windows.Forms.ComboBox();
            this.gpbTecnico = new System.Windows.Forms.GroupBox();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crvVisualizador = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gpbPatente = new System.Windows.Forms.GroupBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gpbEstadoOt = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEstadoOt = new System.Windows.Forms.ComboBox();
            this.rdbBoletaNormal = new System.Windows.Forms.RadioButton();
            this.rdbBoletaFiscal = new System.Windows.Forms.RadioButton();
            this.rdbTodasLasBoletas = new System.Windows.Forms.RadioButton();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCatgandoReporte = new System.Windows.Forms.Label();
            this.gpbSubCategoria = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.gpbFecha.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            this.gpbVendedor.SuspendLayout();
            this.gpbCentroCosto.SuspendLayout();
            this.gpbCaja.SuspendLayout();
            this.gpbFolio.SuspendLayout();
            this.gpbMediosPago.SuspendLayout();
            this.gpbEstadoPago.SuspendLayout();
            this.gpbTecnico.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbPatente.SuspendLayout();
            this.gpbEstadoOt.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbSubCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFecha
            // 
            this.gpbFecha.Controls.Add(this.dtpDesde);
            this.gpbFecha.Controls.Add(this.label2);
            this.gpbFecha.Controls.Add(this.label1);
            this.gpbFecha.Controls.Add(this.dtpHasta);
            this.gpbFecha.Location = new System.Drawing.Point(12, 23);
            this.gpbFecha.Name = "gpbFecha";
            this.gpbFecha.Size = new System.Drawing.Size(245, 56);
            this.gpbFecha.TabIndex = 0;
            this.gpbFecha.TabStop = false;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(6, 27);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(104, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 11);
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
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(129, 27);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(104, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.txtRazonSocial);
            this.gpbCliente.Controls.Add(this.txtDigito);
            this.gpbCliente.Controls.Add(this.txtRut);
            this.gpbCliente.Controls.Add(this.label4);
            this.gpbCliente.Controls.Add(this.label3);
            this.gpbCliente.Controls.Add(this.btnBuscaCliente);
            this.gpbCliente.Location = new System.Drawing.Point(233, 74);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(430, 72);
            this.gpbCliente.TabIndex = 1;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Visible = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(110, 44);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(314, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(197, 11);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(28, 20);
            this.txtDigito.TabIndex = 1;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(110, 11);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(84, 20);
            this.txtRut.TabIndex = 0;
            this.txtRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRut_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RAZON SOCIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RUT";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.Location = new System.Drawing.Point(272, 5);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(114, 33);
            this.btnBuscaCliente.TabIndex = 33;
            this.btnBuscaCliente.Text = "Buscar Cliente";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // gpbVendedor
            // 
            this.gpbVendedor.Controls.Add(this.label5);
            this.gpbVendedor.Controls.Add(this.cmbVendedor);
            this.gpbVendedor.Location = new System.Drawing.Point(12, 78);
            this.gpbVendedor.Name = "gpbVendedor";
            this.gpbVendedor.Size = new System.Drawing.Size(228, 65);
            this.gpbVendedor.TabIndex = 2;
            this.gpbVendedor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "VENDEDOR";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.BackColor = System.Drawing.Color.White;
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(6, 29);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(209, 21);
            this.cmbVendedor.TabIndex = 0;
            // 
            // lblNombreInforme
            // 
            this.lblNombreInforme.AutoSize = true;
            this.lblNombreInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInforme.Location = new System.Drawing.Point(9, 8);
            this.lblNombreInforme.Name = "lblNombreInforme";
            this.lblNombreInforme.Size = new System.Drawing.Size(59, 16);
            this.lblNombreInforme.TabIndex = 5;
            this.lblNombreInforme.Text = "informe";
            // 
            // gpbCentroCosto
            // 
            this.gpbCentroCosto.Controls.Add(this.cmbCentroCosto);
            this.gpbCentroCosto.Controls.Add(this.label6);
            this.gpbCentroCosto.Location = new System.Drawing.Point(14, 78);
            this.gpbCentroCosto.Name = "gpbCentroCosto";
            this.gpbCentroCosto.Size = new System.Drawing.Size(228, 67);
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
            // gpbCaja
            // 
            this.gpbCaja.Controls.Add(this.label7);
            this.gpbCaja.Controls.Add(this.cmbCaja);
            this.gpbCaja.Location = new System.Drawing.Point(260, 22);
            this.gpbCaja.Name = "gpbCaja";
            this.gpbCaja.Size = new System.Drawing.Size(160, 56);
            this.gpbCaja.TabIndex = 7;
            this.gpbCaja.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "CAJA";
            // 
            // cmbCaja
            // 
            this.cmbCaja.BackColor = System.Drawing.Color.White;
            this.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(6, 29);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(148, 21);
            this.cmbCaja.TabIndex = 8;
            // 
            // lblReporte
            // 
            this.lblReporte.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.Color.Silver;
            this.lblReporte.Location = new System.Drawing.Point(591, 129);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(146, 15);
            this.lblReporte.TabIndex = 8;
            this.lblReporte.Text = "reporte";
            this.lblReporte.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpbFolio
            // 
            this.gpbFolio.Controls.Add(this.txtFolio);
            this.gpbFolio.Controls.Add(this.labelFolioBoleta);
            this.gpbFolio.Location = new System.Drawing.Point(422, 22);
            this.gpbFolio.Name = "gpbFolio";
            this.gpbFolio.Size = new System.Drawing.Size(160, 56);
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
            // labelFolioBoleta
            // 
            this.labelFolioBoleta.AutoSize = true;
            this.labelFolioBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolioBoleta.Location = new System.Drawing.Point(12, 15);
            this.labelFolioBoleta.Name = "labelFolioBoleta";
            this.labelFolioBoleta.Size = new System.Drawing.Size(102, 13);
            this.labelFolioBoleta.TabIndex = 0;
            this.labelFolioBoleta.Text = "INGRESE FOLIO";
            // 
            // gpbMediosPago
            // 
            this.gpbMediosPago.Controls.Add(this.label9);
            this.gpbMediosPago.Controls.Add(this.cmbMedioPago);
            this.gpbMediosPago.Location = new System.Drawing.Point(12, 78);
            this.gpbMediosPago.Name = "gpbMediosPago";
            this.gpbMediosPago.Size = new System.Drawing.Size(161, 67);
            this.gpbMediosPago.TabIndex = 10;
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
            // gpbEstadoPago
            // 
            this.gpbEstadoPago.Controls.Add(this.label10);
            this.gpbEstadoPago.Controls.Add(this.cmbEstadoPago);
            this.gpbEstadoPago.Location = new System.Drawing.Point(422, 22);
            this.gpbEstadoPago.Name = "gpbEstadoPago";
            this.gpbEstadoPago.Size = new System.Drawing.Size(162, 56);
            this.gpbEstadoPago.TabIndex = 11;
            this.gpbEstadoPago.TabStop = false;
            this.gpbEstadoPago.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Estado de Pago";
            // 
            // cmbEstadoPago
            // 
            this.cmbEstadoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPago.FormattingEnabled = true;
            this.cmbEstadoPago.Location = new System.Drawing.Point(9, 30);
            this.cmbEstadoPago.Name = "cmbEstadoPago";
            this.cmbEstadoPago.Size = new System.Drawing.Size(145, 21);
            this.cmbEstadoPago.TabIndex = 0;
            // 
            // gpbTecnico
            // 
            this.gpbTecnico.Controls.Add(this.cmbTecnico);
            this.gpbTecnico.Controls.Add(this.label11);
            this.gpbTecnico.Location = new System.Drawing.Point(12, 78);
            this.gpbTecnico.Name = "gpbTecnico";
            this.gpbTecnico.Size = new System.Drawing.Size(228, 67);
            this.gpbTecnico.TabIndex = 7;
            this.gpbTecnico.TabStop = false;
            this.gpbTecnico.Visible = false;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(12, 35);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(203, 21);
            this.cmbTecnico.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "TECNICO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crvVisualizador);
            this.panel1.Controls.Add(this.gpbPatente);
            this.panel1.Location = new System.Drawing.Point(12, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 521);
            this.panel1.TabIndex = 12;
            // 
            // crvVisualizador
            // 
            this.crvVisualizador.ActiveViewIndex = -1;
            this.crvVisualizador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crvVisualizador.CachedPageNumberPerDoc = 10;
            this.crvVisualizador.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisualizador.Location = new System.Drawing.Point(0, 0);
            this.crvVisualizador.Name = "crvVisualizador";
            this.crvVisualizador.SelectionFormula = "";
            this.crvVisualizador.ShowCloseButton = false;
            this.crvVisualizador.ShowGroupTreeButton = false;
            this.crvVisualizador.ShowRefreshButton = false;
            this.crvVisualizador.Size = new System.Drawing.Size(1000, 521);
            this.crvVisualizador.TabIndex = 1;
            this.crvVisualizador.ViewTimeSelectionFormula = "";
            // 
            // gpbPatente
            // 
            this.gpbPatente.Controls.Add(this.txtPatente);
            this.gpbPatente.Controls.Add(this.label13);
            this.gpbPatente.Location = new System.Drawing.Point(450, 51);
            this.gpbPatente.Name = "gpbPatente";
            this.gpbPatente.Size = new System.Drawing.Size(180, 61);
            this.gpbPatente.TabIndex = 19;
            this.gpbPatente.TabStop = false;
            this.gpbPatente.Visible = false;
            // 
            // txtPatente
            // 
            this.txtPatente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatente.Location = new System.Drawing.Point(71, 20);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 1;
            this.txtPatente.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "PATENTE";
            this.label13.Visible = false;
            // 
            // gpbEstadoOt
            // 
            this.gpbEstadoOt.Controls.Add(this.label12);
            this.gpbEstadoOt.Controls.Add(this.cmbEstadoOt);
            this.gpbEstadoOt.Location = new System.Drawing.Point(422, 22);
            this.gpbEstadoOt.Name = "gpbEstadoOt";
            this.gpbEstadoOt.Size = new System.Drawing.Size(162, 56);
            this.gpbEstadoOt.TabIndex = 14;
            this.gpbEstadoOt.TabStop = false;
            this.gpbEstadoOt.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Estado de Orden de Trabajo";
            // 
            // cmbEstadoOt
            // 
            this.cmbEstadoOt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoOt.FormattingEnabled = true;
            this.cmbEstadoOt.Location = new System.Drawing.Point(9, 30);
            this.cmbEstadoOt.Name = "cmbEstadoOt";
            this.cmbEstadoOt.Size = new System.Drawing.Size(145, 21);
            this.cmbEstadoOt.TabIndex = 0;
            // 
            // rdbBoletaNormal
            // 
            this.rdbBoletaNormal.AutoSize = true;
            this.rdbBoletaNormal.Location = new System.Drawing.Point(591, 50);
            this.rdbBoletaNormal.Name = "rdbBoletaNormal";
            this.rdbBoletaNormal.Size = new System.Drawing.Size(91, 17);
            this.rdbBoletaNormal.TabIndex = 15;
            this.rdbBoletaNormal.TabStop = true;
            this.rdbBoletaNormal.Text = "Boleta Normal";
            this.rdbBoletaNormal.UseVisualStyleBackColor = true;
            this.rdbBoletaNormal.Visible = false;
            // 
            // rdbBoletaFiscal
            // 
            this.rdbBoletaFiscal.AutoSize = true;
            this.rdbBoletaFiscal.Location = new System.Drawing.Point(591, 73);
            this.rdbBoletaFiscal.Name = "rdbBoletaFiscal";
            this.rdbBoletaFiscal.Size = new System.Drawing.Size(85, 17);
            this.rdbBoletaFiscal.TabIndex = 16;
            this.rdbBoletaFiscal.TabStop = true;
            this.rdbBoletaFiscal.Text = "Boleta Fiscal";
            this.rdbBoletaFiscal.UseVisualStyleBackColor = true;
            this.rdbBoletaFiscal.Visible = false;
            // 
            // rdbTodasLasBoletas
            // 
            this.rdbTodasLasBoletas.AutoSize = true;
            this.rdbTodasLasBoletas.Location = new System.Drawing.Point(591, 31);
            this.rdbTodasLasBoletas.Name = "rdbTodasLasBoletas";
            this.rdbTodasLasBoletas.Size = new System.Drawing.Size(109, 17);
            this.rdbTodasLasBoletas.TabIndex = 17;
            this.rdbTodasLasBoletas.TabStop = true;
            this.rdbTodasLasBoletas.Text = "Todas las Boletas";
            this.rdbTodasLasBoletas.UseVisualStyleBackColor = true;
            this.rdbTodasLasBoletas.Visible = false;
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.label8);
            this.gpbCategoria.Controls.Add(this.cmbCategoria);
            this.gpbCategoria.Location = new System.Drawing.Point(14, 80);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(211, 65);
            this.gpbCategoria.TabIndex = 18;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Categorias";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(6, 31);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(195, 21);
            this.cmbCategoria.TabIndex = 11;
            this.cmbCategoria.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoria_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Aptusoft.Properties.Resources.ruedas;
            this.pictureBox1.Location = new System.Drawing.Point(739, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_48;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(937, 56);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 72);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Aptusoft.Properties.Resources.de_busqueda_de_archivos_encontrar_vista_del_documento_icono_8728_48;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(862, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 72);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCatgandoReporte
            // 
            this.lblCatgandoReporte.AutoSize = true;
            this.lblCatgandoReporte.ForeColor = System.Drawing.Color.DimGray;
            this.lblCatgandoReporte.Location = new System.Drawing.Point(743, 129);
            this.lblCatgandoReporte.Name = "lblCatgandoReporte";
            this.lblCatgandoReporte.Size = new System.Drawing.Size(100, 13);
            this.lblCatgandoReporte.TabIndex = 21;
            this.lblCatgandoReporte.Text = "Cargando Reporte..";
            this.lblCatgandoReporte.Visible = false;
            // 
            // gpbSubCategoria
            // 
            this.gpbSubCategoria.Controls.Add(this.label14);
            this.gpbSubCategoria.Controls.Add(this.cmbSubCategoria);
            this.gpbSubCategoria.Location = new System.Drawing.Point(230, 80);
            this.gpbSubCategoria.Name = "gpbSubCategoria";
            this.gpbSubCategoria.Size = new System.Drawing.Size(211, 67);
            this.gpbSubCategoria.TabIndex = 22;
            this.gpbSubCategoria.TabStop = false;
            this.gpbSubCategoria.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "SubCategorias";
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Location = new System.Drawing.Point(6, 31);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(195, 21);
            this.cmbSubCategoria.TabIndex = 11;
            // 
            // frmLanzadorInformesVenta
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1370, 744);
            this.Controls.Add(this.gpbEstadoOt);
            this.Controls.Add(this.gpbCaja);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.gpbFecha);
            this.Controls.Add(this.gpbSubCategoria);
            this.Controls.Add(this.lblCatgandoReporte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbCategoria);
            this.Controls.Add(this.rdbTodasLasBoletas);
            this.Controls.Add(this.rdbBoletaFiscal);
            this.Controls.Add(this.rdbBoletaNormal);
            this.Controls.Add(this.gpbCentroCosto);
            this.Controls.Add(this.gpbVendedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombreInforme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpbTecnico);
            this.Controls.Add(this.gpbEstadoPago);
            this.Controls.Add(this.gpbMediosPago);
            this.Controls.Add(this.gpbFolio);
            this.Controls.Add(this.lblReporte);
            this.Name = "frmLanzadorInformesVenta";
            this.Text = "Lanzador de Informes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLanzadorInformesVenta_Load);
            this.gpbFecha.ResumeLayout(false);
            this.gpbFecha.PerformLayout();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbVendedor.ResumeLayout(false);
            this.gpbVendedor.PerformLayout();
            this.gpbCentroCosto.ResumeLayout(false);
            this.gpbCentroCosto.PerformLayout();
            this.gpbCaja.ResumeLayout(false);
            this.gpbCaja.PerformLayout();
            this.gpbFolio.ResumeLayout(false);
            this.gpbFolio.PerformLayout();
            this.gpbMediosPago.ResumeLayout(false);
            this.gpbMediosPago.PerformLayout();
            this.gpbEstadoPago.ResumeLayout(false);
            this.gpbEstadoPago.PerformLayout();
            this.gpbTecnico.ResumeLayout(false);
            this.gpbTecnico.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpbPatente.ResumeLayout(false);
            this.gpbPatente.PerformLayout();
            this.gpbEstadoOt.ResumeLayout(false);
            this.gpbEstadoOt.PerformLayout();
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbSubCategoria.ResumeLayout(false);
            this.gpbSubCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void search_Click(object sender, EventArgs e)
    {
        int num = (int)new frmBuscaClientes(ref this.intance, "informe_factura2").ShowDialog();
    }
  }
}
