 
// Type: Aptusoft.frmOrdenAtencion
 
 
// version 1.8.0

using Aptusoft.InternoAptusoft.Contratacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmOrdenAtencion : Form
  {
    private int idCliente = 0;
    private List<LicenciaVO> listaLicencia = new List<LicenciaVO>();
    private List<OrdenAtencionVO> listaOrdenAtencion = new List<OrdenAtencionVO>();
    private IContainer components = (IContainer) null;
    private frmOrdenAtencion intance;
    private GroupBox gbZonaCliente;
    private Button btnBuscaCliente;
    private Label label21;
    private TextBox txtDiasPlazo;
    private TextBox txtContacto;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private TextBox txtFax;
    private TextBox txtFono;
    private TextBox txtGiro;
    private TextBox txtCiudad;
    private TextBox txtComuna;
    private TextBox txtDireccion;
    private Label label5;
    private Label label4;
    private TextBox txtRazonSocial;
    private TextBox txtDigito;
    private TextBox txtRut;
    private Button btnOt;
    private Button btnLicencia;
    private GroupBox groupBox1;
    private DataGridView dgvLicencias;
    private GroupBox groupBox2;
    private DataGridView dgvOt;
    private Button btnLimpiar;
    private Button btnSalir;
    private Panel pnlBuscaClienteDes;
    private DataGridView dgvBuscaCliente;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private GroupBox groupBox4;
    private ComboBox cmbEstadoFiltro;
    private DateTimePicker dtpHastaFiltro;
    private DateTimePicker dtpDesdeFiltro;
    private Label label13;
    private Label label14;
    private Label label15;
    private DataGridView dgvOTfiltro;
    private Button btnBuscaFiltro;
    private GroupBox groupBox3;
    private ComboBox cmbEstado;
    private DateTimePicker dtpHasta;
    private DateTimePicker dtpDesde;
    private Label label1;
    private Label label2;
    private Label label3;
    private DataGridView dgDatosEstado;
    private DataGridViewTextBoxColumn Numero2;
    private DataGridViewTextBoxColumn Fecha2;
    private DataGridViewTextBoxColumn Nombre2;
    private DataGridViewTextBoxColumn Requerimiento2;
    private DataGridViewTextBoxColumn Tecnico2;
    private DataGridViewTextBoxColumn Estado2;
    private DataGridViewTextBoxColumn Contacto2;
    private DataGridViewTextBoxColumn Email2;
    private Button btnBuscar;
    private Label label16;
    private TextBox txtEmail;
    private Label label35;
    private Label label34;
    private TextBox txtMesesSoporte;
    private TextBox txtInicioSoporte;
    private Label lblDias;
    private RadioButton rdbFechaAtencion;
    private RadioButton rdbFechaIngreso;
    private ComboBox cmbVendedor;
    private Label label17;
    private Button btnReconectar;
    private Panel panelColorDeuda;

    public frmOrdenAtencion()
    {
      this.InitializeComponent();
      this.intance = this;
      this.iniciaFormulario();
    }

    private void iniciaFormulario()
    {
      this.cargaVendedores();
      this.idCliente = 0;
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
      this.txtFax.Clear();
      this.txtFax.Enabled = false;
      this.txtContacto.Clear();
      this.txtContacto.Enabled = false;
      this.txtDiasPlazo.Clear();
      this.txtDiasPlazo.Enabled = false;
      this.txtEmail.Clear();
      this.txtEmail.Enabled = false;
      this.lblDias.Text = "";
      this.txtInicioSoporte.Clear();
      this.txtInicioSoporte.Enabled = false;
      this.txtMesesSoporte.Clear();
      this.txtMesesSoporte.Enabled = false;
      this.dgvLicencias.DataSource = (object) null;
      this.dgvLicencias.Columns.Clear();
      this.dgvOt.DataSource = (object) null;
      this.dgvOt.Columns.Clear();
      this.dgvOTfiltro.DataSource = (object) null;
      this.dgvOTfiltro.Columns.Clear();
      this.dgvBuscaCliente.DataSource = (object) null;
      this.dgvBuscaCliente.Columns.Clear();
      this.pnlBuscaClienteDes.Visible = false;
      this.creaColumnasBuscaClientes();
      this.creaColumnasLicencia();
      this.creaColumnasOt();
      this.creaColumnasOtFiltro();
      this.btnLicencia.Enabled = false;
      this.btnOt.Enabled = false;
      this.panelColorDeuda.BackColor = Color.Transparent;
      this.cargaEstado();
      this.rdbFechaAtencion.Checked = true;
      this.rdbFechaIngreso.Checked = false;
      this.txtRut.Focus();
    }

    private void cargaVendedores()
    {
      this.cmbVendedor.DataSource = (object) new Vendedor().listaVendedoresVenta();
      this.cmbVendedor.ValueMember = "idVendedor";
      this.cmbVendedor.DisplayMember = "nombre";
      this.cmbVendedor.SelectedValue = (object) 0;
    }

    private void creaColumnasBuscaClientes()
    {
      this.dgvBuscaCliente.Columns.Clear();
      this.dgvBuscaCliente.AutoGenerateColumns = false;
      this.dgvBuscaCliente.Columns.Add("Codigo", "Cod.");
      this.dgvBuscaCliente.Columns[0].DataPropertyName = "Codigo";
      this.dgvBuscaCliente.Columns[0].Width = 35;
      this.dgvBuscaCliente.Columns.Add("Rut", "Rut");
      this.dgvBuscaCliente.Columns[1].DataPropertyName = "Rut";
      this.dgvBuscaCliente.Columns[1].Width = 80;
      this.dgvBuscaCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaCliente.Columns.Add("Digito", "");
      this.dgvBuscaCliente.Columns[2].DataPropertyName = "Digito";
      this.dgvBuscaCliente.Columns[2].Width = 20;
      this.dgvBuscaCliente.Columns.Add("RazonSocial", "Razon Social");
      this.dgvBuscaCliente.Columns[3].DataPropertyName = "RazonSocial";
      this.dgvBuscaCliente.Columns[3].Width = 270;
      this.dgvBuscaCliente.Columns.Add("Direccion", "Direccion");
      this.dgvBuscaCliente.Columns[4].DataPropertyName = "Direccion";
      this.dgvBuscaCliente.Columns[4].Width = 226;
    }

    private void creaColumnasLicencia()
    {
      this.dgvLicencias.Columns.Clear();
      this.dgvLicencias.AutoGenerateColumns = false;
      this.dgvLicencias.Columns.Add("Linea", "");
      this.dgvLicencias.Columns[0].DataPropertyName = "Linea";
      this.dgvLicencias.Columns[0].Width = 25;
      this.dgvLicencias.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns[0].DefaultCellStyle.BackColor = Color.Gainsboro;
      this.dgvLicencias.Columns.Add("IdLicencia", "IdLicencia");
      this.dgvLicencias.Columns[1].DataPropertyName = "IdLicencia";
      this.dgvLicencias.Columns[1].Width = 35;
      this.dgvLicencias.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns[1].Visible = false;
      this.dgvLicencias.Columns.Add("IdCliente", "IdCliente");
      this.dgvLicencias.Columns[2].DataPropertyName = "IdCliente";
      this.dgvLicencias.Columns[2].Width = 35;
      this.dgvLicencias.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns[2].Visible = false;
      this.dgvLicencias.Columns.Add("Rut", "Rut");
      this.dgvLicencias.Columns[3].DataPropertyName = "Rut";
      this.dgvLicencias.Columns[3].Width = 35;
      this.dgvLicencias.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns[3].Visible = false;
      this.dgvLicencias.Columns.Add("Fecha", "Fecha Instalación");
      this.dgvLicencias.Columns[4].DataPropertyName = "Fecha";
      this.dgvLicencias.Columns[4].Width = 135;
      this.dgvLicencias.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns.Add("Mac", "Mac");
      this.dgvLicencias.Columns[5].DataPropertyName = "Mac";
      this.dgvLicencias.Columns[5].Width = 135;
      this.dgvLicencias.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns.Add("Clave", "Clave");
      this.dgvLicencias.Columns[6].DataPropertyName = "Clave";
      this.dgvLicencias.Columns[6].Width = 135;
      this.dgvLicencias.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns.Add("ContraClave", "Contra Clave");
      this.dgvLicencias.Columns[7].DataPropertyName = "ContraClave";
      this.dgvLicencias.Columns[7].Width = 135;
      this.dgvLicencias.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns.Add("Contacto", "Contacto");
      this.dgvLicencias.Columns[8].DataPropertyName = "Contacto";
      this.dgvLicencias.Columns[8].Width = 210;
      this.dgvLicencias.Columns[8].Resizable = DataGridViewTriState.False;
    }

    private void creaColumnasOt()
    {
      this.dgvOt.Columns.Clear();
      this.dgvOt.AutoGenerateColumns = false;
      this.dgvOt.Columns.Add("Linea", "");
      this.dgvOt.Columns[0].DataPropertyName = "Linea";
      this.dgvOt.Columns[0].Width = 25;
      this.dgvOt.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns[0].DefaultCellStyle.BackColor = Color.Gainsboro;
      this.dgvOt.Columns.Add("FechaIngreso", "Fecha Solicitud");
      this.dgvOt.Columns[1].DataPropertyName = "FechaIngreso";
      this.dgvOt.Columns[1].Width = 110;
      this.dgvOt.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("Requerimiento", "Requerimiento");
      this.dgvOt.Columns[2].DataPropertyName = "Requerimiento";
      this.dgvOt.Columns[2].Width = 295;
      this.dgvOt.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("Tecnico", "Tecnico");
      this.dgvOt.Columns[3].DataPropertyName = "Tecnico";
      this.dgvOt.Columns[3].Width = 100;
      this.dgvOt.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("Estado", "Estado");
      this.dgvOt.Columns[4].DataPropertyName = "Estado";
      this.dgvOt.Columns[4].Width = 85;
      this.dgvOt.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("FechaAtencion", "Fecha Atencion");
      this.dgvOt.Columns[5].DataPropertyName = "FechaAtencion";
      this.dgvOt.Columns[5].Width = 110;
      this.dgvOt.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns.Add("IdOrdenAtencion", "IdOrdenAtencion");
      this.dgvOt.Columns[6].DataPropertyName = "IdOrdenAtencion";
      this.dgvOt.Columns[6].Width = 80;
      this.dgvOt.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvOt.Columns[6].Visible = false;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Eliminar";
      viewButtonColumn.HeaderText = "Eliminar";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "X";
      viewButtonColumn.Width = 50;
      viewButtonColumn.DisplayIndex = 7;
      this.dgvOt.Columns.Add((DataGridViewColumn) viewButtonColumn);
    }

    private void creaColumnasOtFiltro()
    {
      this.dgvOTfiltro.Columns.Clear();
      this.dgvOTfiltro.AutoGenerateColumns = false;
      this.dgvOTfiltro.Columns.Add("Linea", "");
      this.dgvOTfiltro.Columns[0].DataPropertyName = "Linea";
      this.dgvOTfiltro.Columns[0].Width = 25;
      this.dgvOTfiltro.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns[0].DefaultCellStyle.BackColor = Color.Lavender;
      this.dgvOTfiltro.Columns.Add("FechaIngreso", "Solicitado el");
      this.dgvOTfiltro.Columns[1].DataPropertyName = "FechaIngreso";
      this.dgvOTfiltro.Columns[1].Width = 100;
      this.dgvOTfiltro.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns.Add("FechaAtencion", "Atender");
      this.dgvOTfiltro.Columns[2].DataPropertyName = "FechaAtencion";
      this.dgvOTfiltro.Columns[2].Width = 70;
      this.dgvOTfiltro.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns[2].DefaultCellStyle.Format = "d";
      this.dgvOTfiltro.Columns.Add("HoraAtencion", "Hora A.");
      this.dgvOTfiltro.Columns[3].DataPropertyName = "FechaAtencion";
      this.dgvOTfiltro.Columns[3].Width = 70;
      this.dgvOTfiltro.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns[3].DefaultCellStyle.Format = "T";
      this.dgvOTfiltro.Columns.Add("RazonSocial", "Cliente");
      this.dgvOTfiltro.Columns[4].DataPropertyName = "RazonSocial";
      this.dgvOTfiltro.Columns[4].Width = 150;
      this.dgvOTfiltro.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns.Add("Requerimiento", "Requerimiento");
      this.dgvOTfiltro.Columns[5].DataPropertyName = "Requerimiento";
      this.dgvOTfiltro.Columns[5].Width = 200;
      this.dgvOTfiltro.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns.Add("Tecnico", "Tecnico");
      this.dgvOTfiltro.Columns[6].DataPropertyName = "Tecnico";
      this.dgvOTfiltro.Columns[6].Width = 100;
      this.dgvOTfiltro.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns.Add("Estado", "Estado");
      this.dgvOTfiltro.Columns[7].DataPropertyName = "Estado";
      this.dgvOTfiltro.Columns[7].Width = 85;
      this.dgvOTfiltro.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns.Add("IdOrdenAtencion", "IdOrdenAtencion");
      this.dgvOTfiltro.Columns[8].DataPropertyName = "IdOrdenAtencion";
      this.dgvOTfiltro.Columns[8].Width = 80;
      this.dgvOTfiltro.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvOTfiltro.Columns[8].Visible = false;
    }

    private void cargaListaLicencias()
    {
      this.listaLicencia.Clear();
      this.listaLicencia = new Licencia().listaLicencia(this.idCliente);
      for (int index = 0; index < this.listaLicencia.Count; ++index)
        this.listaLicencia[index].Linea = index + 1;
      this.dgvLicencias.DataSource = (object) this.listaLicencia;
    }

    private void cargalistaOrdenAtencion()
    {
      this.listaOrdenAtencion.Clear();
      this.listaOrdenAtencion = new OrdenAtencion().listaOrdenAtencion(this.idCliente);
      for (int index = 0; index < this.listaOrdenAtencion.Count; ++index)
        this.listaOrdenAtencion[index].Linea = index + 1;
      this.dgvOt.DataSource = (object) this.listaOrdenAtencion;
    }

    private void cargaEstado()
    {
      CargaMaestros cargaMaestros = new CargaMaestros();
      List<BodegaVO> list1 = new List<BodegaVO>();
      List<BodegaVO> list2 = cargaMaestros.listaEstadoOT();
      list2.Add(new BodegaVO()
      {
        IdBodega = 0,
        nombreBodega = "TODAS"
      });
      this.cmbEstadoFiltro.DataSource = (object) list2;
      this.cmbEstadoFiltro.ValueMember = "IdBodega";
      this.cmbEstadoFiltro.DisplayMember = "NombreBodega";
      this.cmbEstadoFiltro.SelectedValue = (object) 0;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
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
        int num = (int) new frmClienteMismoRut(cli, ref this.intance, "orden_atencion").ShowDialog();
      }
      else if (cli.Count == 0)
      {
        if (MessageBox.Show("No Existe Cliente Consultado, ¿Desea Crearlo?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
          new frmClientes(this.txtRut.Text.Trim(), this.txtDigito.Text.Trim()).Show();
        else
          this.iniciaFormulario();
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
      this.idCliente = clienteVo.Codigo;
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
      this.txtDiasPlazo.Text = clienteVo.DiasPlazo;
      this.txtEmail.Text = clienteVo.Email;
      this.txtInicioSoporte.Text = clienteVo.InicioSoporte.ToShortDateString();
      this.txtMesesSoporte.Text = clienteVo.MesesSoporte.ToString();
      if (!this.buscaContratoActivo(this.idCliente))
        this.fechaSoporte(clienteVo.InicioSoporte, clienteVo.MesesSoporte);
      this.btnOt.Enabled = true;
      this.btnLicencia.Enabled = true;
      this.cargaListaLicencias();
      this.cargalistaOrdenAtencion();
      this.ventasCliente("2012-01-01", DateTime.Now.ToString("yyyy-MM-dd"));
    }

    private bool buscaContratoActivo(int idCli)
    {
      ContratoVO contratoVo = new ContratoNegocio().BuscaContratoActivoIdCliente(idCli);
      if (contratoVo.Estado == null || !contratoVo.Estado.Equals("ACTIVO"))
        return false;
      this.lblDias.Text = "Soporte Ilimitado desde " + contratoVo.FechaContratacion.ToShortDateString();
      this.lblDias.BackColor = Color.LightGreen;
      this.lblDias.ForeColor = Color.Blue;
      return true;
    }

    private void ventasCliente(string desde, string hasta)
    {
      Cliente cliente = new Cliente();
      string str1 = " idCliente=" + this.idCliente.ToString();
      string str2 = "";
      string filtro1 = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "' AND " + str1 + " " + str2;
      string filtro2 = "DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "' AND " + str1;
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
      if (num3 - num5 > new Decimal(0))
        this.panelColorDeuda.BackColor = Color.Red;
      else
        this.panelColorDeuda.BackColor = Color.LightGreen;
    }

    private void fechaSoporte(DateTime inicio, int cantMes)
    {
      string str = "";
      DateTime now = DateTime.Now;
      DateTime dateTime = inicio.AddMonths((int) Convert.ToInt16(cantMes));
      int num1 = dateTime.Day - now.Day;
      int num2 = dateTime.Month - now.Month;
      int num3 = dateTime.Year - now.Year;
      if (num2 < 0)
      {
        --num3;
        num2 += 12;
      }
      if (num1 < 0)
      {
        --num2;
        num1 += DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
      }
      if (num3 < 0)
        str = "Fecha Invalida";
      if (num3 > 0)
        str = str + num3.ToString() + " años ";
      if (num2 > 0)
        str = str + num2.ToString() + " meses ";
      if (num1 > 0)
        str = str + num1.ToString() + " dias ";
      if (dateTime < now)
      {
        this.lblDias.Text = "Fecha de Termino: " + dateTime.ToShortDateString() + " ****SIN SOPORTE ACTIVO****";
        this.lblDias.BackColor = Color.Red;
        this.lblDias.ForeColor = Color.Yellow;
      }
      else
      {
        this.lblDias.Text = "Fecha de Termino: " + dateTime.ToShortDateString() + " Quedan " + str;
        this.lblDias.BackColor = Color.LightGreen;
        this.lblDias.ForeColor = Color.Blue;
      }
    }

    private void txtRazonSocial_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRazonSocial.Text.Trim().Length > 0 && this.txtRut.Text.Trim().Length == 0)
      {
        this.pnlBuscaClienteDes.Visible = true;
        List<ClienteVO> list = new Cliente().buscaClienteDato(1, this.txtRazonSocial.Text.Trim());
        if (list.Count <= 0)
          return;
        this.dgvBuscaCliente.DataSource = (object) list;
      }
      else
        this.pnlBuscaClienteDes.Visible = false;
    }

    private void dgvBuscaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void dgvBuscaCliente_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaClienteCodigo(Convert.ToInt32(this.dgvBuscaCliente.SelectedRows[0].Cells[0].Value.ToString()));
      this.pnlBuscaClienteDes.Visible = false;
    }

    private void txtRazonSocial_KeyDown(object sender, KeyEventArgs e)
    {
      if (!this.pnlBuscaClienteDes.Visible || e.KeyCode != Keys.Down)
        return;
      this.dgvBuscaCliente.Focus();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modOrdenAtencion = 0;
      this.Dispose();
      this.Close();
    }

    private void btnLicencia_Click(object sender, EventArgs e)
    {
      int num = (int) new frmLicencia(this.idCliente, this.txtRut.Text, this.txtDigito.Text, this.txtRazonSocial.Text, this.intance).ShowDialog();
    }

    private void btnOt_Click(object sender, EventArgs e)
    {
      int num = (int) new frmOt(this.idCliente, this.txtRut.Text, this.txtDigito.Text, this.txtRazonSocial.Text, this.txtEmail.Text, this.txtFono.Text, this.txtContacto.Text, this.intance).ShowDialog();
    }

    private void dgvOt_DoubleClick(object sender, EventArgs e)
    {
      if (this.dgvOt.RowCount <= 0)
        return;
      int num = (int) new frmOt(Convert.ToInt32(this.dgvOt.SelectedRows[0].Cells["IdOrdenAtencion"].Value.ToString()), this.intance).ShowDialog();
    }

    private void dgvOt_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvOt.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar esta Orden de Atención", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      new OrdenAtencion().eliminaOrdenAtencion(Convert.ToInt32(this.dgvOt.SelectedRows[0].Cells["IdOrdenAtencion"].Value.ToString()));
      int num = (int) MessageBox.Show("Orden de Atención Eliminada", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.buscaClienteCodigo(this.idCliente);
    }

    private void btnBuscaCliente_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaClientes(ref this.intance, "orden_atencion").ShowDialog();
    }

    private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtRut);
      if ((int) e.KeyChar != 13)
        return;
      this.txtDigito.Focus();
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

    private void frmOrdenAtencion_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modOrdenAtencion = 0;
    }

    private void btnBuscaFiltro_Click(object sender, EventArgs e)
    {
      try
      {
        DateTime dateTime = this.dtpDesdeFiltro.Value;
        string desde = dateTime.ToString("yyyy-MM-dd");
        dateTime = this.dtpHastaFiltro.Value;
        string hasta = dateTime.ToString("yyyy-MM-dd");
        string tipoFecha = this.rdbFechaAtencion.Checked ? "fechaAtencion" : "fechaIngreso";
        string tecnico = this.cmbVendedor.Text != "[SELECCIONE]" ? " and tecnico='" + this.cmbVendedor.Text + "' " : "";
        OrdenAtencion ordenAtencion = new OrdenAtencion();
        List<OrdenAtencionVO> list1 = new List<OrdenAtencionVO>();
        string estado = !this.cmbEstadoFiltro.Text.Equals("TODAS") ? " AND estado='" + this.cmbEstadoFiltro.Text + "'" : "";
        List<OrdenAtencionVO> list2 = ordenAtencion.listaOrdenAtencionFiltro(desde, hasta, estado, tipoFecha, tecnico);
        if (list2.Count > 0)
        {
          for (int index = 0; index < list2.Count; ++index)
            list2[index].Linea = index + 1;
        }
        this.dgvOTfiltro.DataSource = (object) list2;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message ?? "");
      }
    }

    private void dgvOTfiltro_DoubleClick(object sender, EventArgs e)
    {
      if (this.dgvOTfiltro.RowCount <= 0)
        return;
      int num = (int) new frmOt(Convert.ToInt32(this.dgvOTfiltro.SelectedRows[0].Cells["IdOrdenAtencion"].Value.ToString()), this.intance).ShowDialog();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      try
      {
        Conexion.getConecta();
      }
      catch
      {
        int num = (int) MessageBox.Show("Error en Conexion, Reinicie la Aplicacion Aptusoft", "Conexión Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnReconectar_Click(object sender, EventArgs e)
    {
      this.pruebaConexion();
    }

    private bool pruebaConexion()
    {
      try
      {
        Conexion.reconexion();
        int num = (int) MessageBox.Show("Conexión Bien Establecida", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        return true;
      }
      catch
      {
        int num = (int) MessageBox.Show("Error al Conectar", "Conexión Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      this.gbZonaCliente = new GroupBox();
      this.lblDias = new Label();
      this.txtMesesSoporte = new TextBox();
      this.txtInicioSoporte = new TextBox();
      this.label35 = new Label();
      this.label16 = new Label();
      this.label34 = new Label();
      this.txtEmail = new TextBox();
      this.btnBuscaCliente = new Button();
      this.label21 = new Label();
      this.txtDiasPlazo = new TextBox();
      this.txtContacto = new TextBox();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.txtFax = new TextBox();
      this.txtFono = new TextBox();
      this.txtGiro = new TextBox();
      this.txtCiudad = new TextBox();
      this.txtComuna = new TextBox();
      this.txtDireccion = new TextBox();
      this.label5 = new Label();
      this.label4 = new Label();
      this.txtRazonSocial = new TextBox();
      this.txtDigito = new TextBox();
      this.txtRut = new TextBox();
      this.btnOt = new Button();
      this.btnLicencia = new Button();
      this.groupBox1 = new GroupBox();
      this.dgvLicencias = new DataGridView();
      this.groupBox2 = new GroupBox();
      this.dgvOt = new DataGridView();
      this.btnLimpiar = new Button();
      this.btnSalir = new Button();
      this.pnlBuscaClienteDes = new Panel();
      this.dgvBuscaCliente = new DataGridView();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.groupBox4 = new GroupBox();
      this.cmbVendedor = new ComboBox();
      this.label17 = new Label();
      this.rdbFechaAtencion = new RadioButton();
      this.rdbFechaIngreso = new RadioButton();
      this.cmbEstadoFiltro = new ComboBox();
      this.dtpHastaFiltro = new DateTimePicker();
      this.dtpDesdeFiltro = new DateTimePicker();
      this.label13 = new Label();
      this.label14 = new Label();
      this.label15 = new Label();
      this.btnBuscaFiltro = new Button();
      this.dgvOTfiltro = new DataGridView();
      this.groupBox3 = new GroupBox();
      this.cmbEstado = new ComboBox();
      this.dtpHasta = new DateTimePicker();
      this.dtpDesde = new DateTimePicker();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.dgDatosEstado = new DataGridView();
      this.Numero2 = new DataGridViewTextBoxColumn();
      this.Fecha2 = new DataGridViewTextBoxColumn();
      this.Nombre2 = new DataGridViewTextBoxColumn();
      this.Requerimiento2 = new DataGridViewTextBoxColumn();
      this.Tecnico2 = new DataGridViewTextBoxColumn();
      this.Estado2 = new DataGridViewTextBoxColumn();
      this.Contacto2 = new DataGridViewTextBoxColumn();
      this.Email2 = new DataGridViewTextBoxColumn();
      this.btnBuscar = new Button();
      this.btnReconectar = new Button();
      this.panelColorDeuda = new Panel();
      this.gbZonaCliente.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvLicencias).BeginInit();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.dgvOt).BeginInit();
      this.pnlBuscaClienteDes.SuspendLayout();
      ((ISupportInitialize) this.dgvBuscaCliente).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      ((ISupportInitialize) this.dgvOTfiltro).BeginInit();
      this.groupBox3.SuspendLayout();
      ((ISupportInitialize) this.dgDatosEstado).BeginInit();
      this.SuspendLayout();
      this.gbZonaCliente.Controls.Add((Control) this.lblDias);
      this.gbZonaCliente.Controls.Add((Control) this.txtMesesSoporte);
      this.gbZonaCliente.Controls.Add((Control) this.txtInicioSoporte);
      this.gbZonaCliente.Controls.Add((Control) this.label35);
      this.gbZonaCliente.Controls.Add((Control) this.label16);
      this.gbZonaCliente.Controls.Add((Control) this.label34);
      this.gbZonaCliente.Controls.Add((Control) this.txtEmail);
      this.gbZonaCliente.Controls.Add((Control) this.btnBuscaCliente);
      this.gbZonaCliente.Controls.Add((Control) this.label21);
      this.gbZonaCliente.Controls.Add((Control) this.txtDiasPlazo);
      this.gbZonaCliente.Controls.Add((Control) this.txtContacto);
      this.gbZonaCliente.Controls.Add((Control) this.label12);
      this.gbZonaCliente.Controls.Add((Control) this.label11);
      this.gbZonaCliente.Controls.Add((Control) this.label10);
      this.gbZonaCliente.Controls.Add((Control) this.label9);
      this.gbZonaCliente.Controls.Add((Control) this.label8);
      this.gbZonaCliente.Controls.Add((Control) this.label7);
      this.gbZonaCliente.Controls.Add((Control) this.label6);
      this.gbZonaCliente.Controls.Add((Control) this.txtFax);
      this.gbZonaCliente.Controls.Add((Control) this.txtFono);
      this.gbZonaCliente.Controls.Add((Control) this.txtGiro);
      this.gbZonaCliente.Controls.Add((Control) this.txtCiudad);
      this.gbZonaCliente.Controls.Add((Control) this.txtComuna);
      this.gbZonaCliente.Controls.Add((Control) this.txtDireccion);
      this.gbZonaCliente.Controls.Add((Control) this.label5);
      this.gbZonaCliente.Controls.Add((Control) this.label4);
      this.gbZonaCliente.Controls.Add((Control) this.txtRazonSocial);
      this.gbZonaCliente.Controls.Add((Control) this.txtDigito);
      this.gbZonaCliente.Controls.Add((Control) this.txtRut);
      this.gbZonaCliente.Location = new Point(6, 6);
      this.gbZonaCliente.Name = "gbZonaCliente";
      this.gbZonaCliente.Size = new Size(815, 140);
      this.gbZonaCliente.TabIndex = 27;
      this.gbZonaCliente.TabStop = false;
      this.lblDias.BackColor = Color.Red;
      this.lblDias.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblDias.ForeColor = Color.Yellow;
      this.lblDias.Location = new Point(353, 112);
      this.lblDias.Name = "lblDias";
      this.lblDias.Size = new Size(454, 19);
      this.lblDias.TabIndex = 40;
      this.lblDias.Text = "fecha de soporte";
      this.txtMesesSoporte.BackColor = Color.White;
      this.txtMesesSoporte.Location = new Point(290, 111);
      this.txtMesesSoporte.Name = "txtMesesSoporte";
      this.txtMesesSoporte.Size = new Size(46, 20);
      this.txtMesesSoporte.TabIndex = 39;
      this.txtInicioSoporte.BackColor = Color.White;
      this.txtInicioSoporte.Location = new Point(77, 111);
      this.txtInicioSoporte.Name = "txtInicioSoporte";
      this.txtInicioSoporte.Size = new Size(100, 20);
      this.txtInicioSoporte.TabIndex = 38;
      this.label35.AutoSize = true;
      this.label35.Location = new Point(192, 115);
      this.label35.Name = "label35";
      this.label35.Size = new Size(93, 13);
      this.label35.TabIndex = 37;
      this.label35.Text = "Meses de Soporte";
      this.label16.AutoSize = true;
      this.label16.Location = new Point(451, 89);
      this.label16.Name = "label16";
      this.label16.Size = new Size(36, 13);
      this.label16.TabIndex = 34;
      this.label16.Text = "E-Mail";
      this.label34.AutoSize = true;
      this.label34.Location = new Point(4, 115);
      this.label34.Name = "label34";
      this.label34.Size = new Size(72, 13);
      this.label34.TabIndex = 36;
      this.label34.Text = "Inicio Soporte";
      this.txtEmail.BackColor = Color.White;
      this.txtEmail.Location = new Point(488, 85);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(213, 20);
      this.txtEmail.TabIndex = 33;
      this.btnBuscaCliente.Location = new Point(663, 16);
      this.btnBuscaCliente.Name = "btnBuscaCliente";
      this.btnBuscaCliente.Size = new Size(144, 23);
      this.btnBuscaCliente.TabIndex = 32;
      this.btnBuscaCliente.Text = "Buscar Cliente";
      this.btnBuscaCliente.UseVisualStyleBackColor = true;
      this.btnBuscaCliente.Click += new EventHandler(this.btnBuscaCliente_Click);
      this.label21.AutoSize = true;
      this.label21.Location = new Point(264, 89);
      this.label21.Name = "label21";
      this.label21.Size = new Size(72, 13);
      this.label21.TabIndex = 20;
      this.label21.Text = "Dias de Plazo";
      this.txtDiasPlazo.BackColor = Color.White;
      this.txtDiasPlazo.Location = new Point(339, 85);
      this.txtDiasPlazo.Name = "txtDiasPlazo";
      this.txtDiasPlazo.Size = new Size(100, 20);
      this.txtDiasPlazo.TabIndex = 19;
      this.txtContacto.BackColor = Color.White;
      this.txtContacto.Location = new Point(60, 85);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(194, 20);
      this.txtContacto.TabIndex = 18;
      this.label12.AutoSize = true;
      this.label12.Location = new Point(4, 89);
      this.label12.Name = "label12";
      this.label12.Size = new Size(50, 13);
      this.label12.TabIndex = 17;
      this.label12.Text = "Contacto";
      this.label12.TextAlign = ContentAlignment.TopRight;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(549, 67);
      this.label11.Name = "label11";
      this.label11.Size = new Size(24, 13);
      this.label11.TabIndex = 16;
      this.label11.Text = "Fax";
      this.label11.TextAlign = ContentAlignment.TopRight;
      this.label10.AutoSize = true;
      this.label10.Location = new Point(355, 67);
      this.label10.Name = "label10";
      this.label10.Size = new Size(31, 13);
      this.label10.TabIndex = 15;
      this.label10.Text = "Fono";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(30, 67);
      this.label9.Name = "label9";
      this.label9.Size = new Size(26, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Giro";
      this.label9.TextAlign = ContentAlignment.TopRight;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(538, 45);
      this.label8.Name = "label8";
      this.label8.Size = new Size(40, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Ciudad";
      this.label8.TextAlign = ContentAlignment.TopRight;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(340, 41);
      this.label7.Name = "label7";
      this.label7.Size = new Size(46, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Comuna";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(4, 45);
      this.label6.Name = "label6";
      this.label6.Size = new Size(52, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Dirección";
      this.label6.TextAlign = ContentAlignment.TopRight;
      this.txtFax.BackColor = Color.White;
      this.txtFax.Location = new Point(580, 63);
      this.txtFax.Name = "txtFax";
      this.txtFax.Size = new Size(227, 20);
      this.txtFax.TabIndex = 10;
      this.txtFono.BackColor = Color.White;
      this.txtFono.Location = new Point(392, 63);
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(143, 20);
      this.txtFono.TabIndex = 9;
      this.txtGiro.BackColor = Color.White;
      this.txtGiro.Location = new Point(60, 63);
      this.txtGiro.Name = "txtGiro";
      this.txtGiro.Size = new Size(276, 20);
      this.txtGiro.TabIndex = 8;
      this.txtCiudad.BackColor = Color.White;
      this.txtCiudad.Location = new Point(580, 41);
      this.txtCiudad.Name = "txtCiudad";
      this.txtCiudad.Size = new Size(227, 20);
      this.txtCiudad.TabIndex = 7;
      this.txtComuna.BackColor = Color.White;
      this.txtComuna.Location = new Point(392, 41);
      this.txtComuna.Name = "txtComuna";
      this.txtComuna.Size = new Size(143, 20);
      this.txtComuna.TabIndex = 6;
      this.txtDireccion.BackColor = Color.White;
      this.txtDireccion.Location = new Point(60, 41);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.Size = new Size(276, 20);
      this.txtDireccion.TabIndex = 5;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(181, 23);
      this.label5.Name = "label5";
      this.label5.Size = new Size(70, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Razon Social";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(26, 23);
      this.label4.Name = "label4";
      this.label4.Size = new Size(30, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "RUT";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.txtRazonSocial.Location = new Point(257, 19);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(400, 20);
      this.txtRazonSocial.TabIndex = 8;
      this.txtRazonSocial.TextChanged += new EventHandler(this.txtRazonSocial_TextChanged);
      this.txtRazonSocial.KeyDown += new KeyEventHandler(this.txtRazonSocial_KeyDown);
      this.txtDigito.Location = new Point(132, 19);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(29, 20);
      this.txtDigito.TabIndex = 7;
      this.txtDigito.KeyPress += new KeyPressEventHandler(this.txtDigito_KeyPress);
      this.txtRut.Location = new Point(60, 19);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(68, 20);
      this.txtRut.TabIndex = 6;
      this.txtRut.KeyPress += new KeyPressEventHandler(this.txtRut_KeyPress);
      this.btnOt.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnOt.Location = new Point(646, 292);
      this.btnOt.Name = "btnOt";
      this.btnOt.Size = new Size(169, 23);
      this.btnOt.TabIndex = 28;
      this.btnOt.Text = "Ingresar OT";
      this.btnOt.UseVisualStyleBackColor = true;
      this.btnOt.Click += new EventHandler(this.btnOt_Click);
      this.btnLicencia.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLicencia.Location = new Point(646, 152);
      this.btnLicencia.Name = "btnLicencia";
      this.btnLicencia.Size = new Size(169, 23);
      this.btnLicencia.TabIndex = 29;
      this.btnLicencia.Text = "Ingresar Licencia";
      this.btnLicencia.UseVisualStyleBackColor = true;
      this.btnLicencia.Click += new EventHandler(this.btnLicencia_Click);
      this.groupBox1.Controls.Add((Control) this.dgvLicencias);
      this.groupBox1.Location = new Point(6, 172);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(815, 118);
      this.groupBox1.TabIndex = 30;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Licencias";
      this.dgvLicencias.AllowUserToAddRows = false;
      this.dgvLicencias.AllowUserToDeleteRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvLicencias.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvLicencias.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvLicencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLicencias.Location = new Point(9, 18);
      this.dgvLicencias.Name = "dgvLicencias";
      this.dgvLicencias.ReadOnly = true;
      this.dgvLicencias.RowHeadersVisible = false;
      this.dgvLicencias.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvLicencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvLicencias.Size = new Size(798, 94);
      this.dgvLicencias.TabIndex = 0;
      this.groupBox2.Controls.Add((Control) this.dgvOt);
      this.groupBox2.Location = new Point(6, 313);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(815, 219);
      this.groupBox2.TabIndex = 31;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Ordenes de Trabajo";
      this.dgvOt.AllowUserToAddRows = false;
      this.dgvOt.AllowUserToDeleteRows = false;
      gridViewCellStyle2.BackColor = Color.Lavender;
      this.dgvOt.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.dgvOt.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvOt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvOt.Location = new Point(9, 16);
      this.dgvOt.Name = "dgvOt";
      this.dgvOt.ReadOnly = true;
      this.dgvOt.RowHeadersVisible = false;
      this.dgvOt.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvOt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvOt.Size = new Size(798, 190);
      this.dgvOt.TabIndex = 0;
      this.dgvOt.CellClick += new DataGridViewCellEventHandler(this.dgvOt_CellClick);
      this.dgvOt.DoubleClick += new EventHandler(this.dgvOt_DoubleClick);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Location = new Point(859, 472);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(109, 40);
      this.btnLimpiar.TabIndex = 32;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(859, 518);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(109, 40);
      this.btnSalir.TabIndex = 33;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.pnlBuscaClienteDes.Controls.Add((Control) this.dgvBuscaCliente);
      this.pnlBuscaClienteDes.Location = new Point(263, 45);
      this.pnlBuscaClienteDes.Name = "pnlBuscaClienteDes";
      this.pnlBuscaClienteDes.Size = new Size(566, 173);
      this.pnlBuscaClienteDes.TabIndex = 34;
      this.pnlBuscaClienteDes.Visible = false;
      this.dgvBuscaCliente.AllowUserToAddRows = false;
      this.dgvBuscaCliente.AllowUserToDeleteRows = false;
      this.dgvBuscaCliente.AllowUserToResizeColumns = false;
      this.dgvBuscaCliente.AllowUserToResizeRows = false;
      gridViewCellStyle3.BackColor = Color.Lavender;
      this.dgvBuscaCliente.AlternatingRowsDefaultCellStyle = gridViewCellStyle3;
      this.dgvBuscaCliente.BackgroundColor = Color.LavenderBlush;
      this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle4.BackColor = SystemColors.Window;
      gridViewCellStyle4.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle4.ForeColor = SystemColors.ControlText;
      gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
      this.dgvBuscaCliente.DefaultCellStyle = gridViewCellStyle4;
      this.dgvBuscaCliente.Location = new Point(1, 1);
      this.dgvBuscaCliente.Name = "dgvBuscaCliente";
      this.dgvBuscaCliente.ReadOnly = true;
      this.dgvBuscaCliente.RowHeadersVisible = false;
      this.dgvBuscaCliente.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaCliente.Size = new Size(560, 169);
      this.dgvBuscaCliente.TabIndex = 0;
      this.dgvBuscaCliente.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaCliente_CellDoubleClick);
      this.dgvBuscaCliente.KeyDown += new KeyEventHandler(this.dgvBuscaCliente_KeyDown);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(840, 571);
      this.tabControl1.TabIndex = 35;
      this.tabPage1.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage1.Controls.Add((Control) this.pnlBuscaClienteDes);
      this.tabPage1.Controls.Add((Control) this.btnLicencia);
      this.tabPage1.Controls.Add((Control) this.gbZonaCliente);
      this.tabPage1.Controls.Add((Control) this.groupBox1);
      this.tabPage1.Controls.Add((Control) this.btnOt);
      this.tabPage1.Controls.Add((Control) this.groupBox2);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(832, 545);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "ORDENES DE ATENCIÓN";
      this.tabPage2.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage2.Controls.Add((Control) this.groupBox4);
      this.tabPage2.Controls.Add((Control) this.dgvOTfiltro);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(832, 545);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "BUSQUEDA";
      this.groupBox4.BackColor = Color.FromArgb(223, 233, 245);
      this.groupBox4.Controls.Add((Control) this.cmbVendedor);
      this.groupBox4.Controls.Add((Control) this.label17);
      this.groupBox4.Controls.Add((Control) this.rdbFechaAtencion);
      this.groupBox4.Controls.Add((Control) this.rdbFechaIngreso);
      this.groupBox4.Controls.Add((Control) this.cmbEstadoFiltro);
      this.groupBox4.Controls.Add((Control) this.dtpHastaFiltro);
      this.groupBox4.Controls.Add((Control) this.dtpDesdeFiltro);
      this.groupBox4.Controls.Add((Control) this.label13);
      this.groupBox4.Controls.Add((Control) this.label14);
      this.groupBox4.Controls.Add((Control) this.label15);
      this.groupBox4.Controls.Add((Control) this.btnBuscaFiltro);
      this.groupBox4.Location = new Point(6, 6);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(820, 107);
      this.groupBox4.TabIndex = 1;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Filtro";
      this.cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbVendedor.FormattingEnabled = true;
      this.cmbVendedor.Location = new Point(443, 41);
      this.cmbVendedor.Name = "cmbVendedor";
      this.cmbVendedor.Size = new Size(157, 21);
      this.cmbVendedor.TabIndex = 13;
      this.label17.BackColor = Color.LightSkyBlue;
      this.label17.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = Color.White;
      this.label17.Location = new Point(443, 23);
      this.label17.Name = "label17";
      this.label17.Size = new Size(157, 18);
      this.label17.TabIndex = 12;
      this.label17.Text = "Tecnico";
      this.rdbFechaAtencion.AutoSize = true;
      this.rdbFechaAtencion.Location = new Point(15, 78);
      this.rdbFechaAtencion.Name = "rdbFechaAtencion";
      this.rdbFechaAtencion.Size = new Size(115, 17);
      this.rdbFechaAtencion.TabIndex = 11;
      this.rdbFechaAtencion.TabStop = true;
      this.rdbFechaAtencion.Text = "Fecha de Atención";
      this.rdbFechaAtencion.UseVisualStyleBackColor = true;
      this.rdbFechaIngreso.AutoSize = true;
      this.rdbFechaIngreso.Location = new Point(136, 77);
      this.rdbFechaIngreso.Name = "rdbFechaIngreso";
      this.rdbFechaIngreso.Size = new Size(108, 17);
      this.rdbFechaIngreso.TabIndex = 10;
      this.rdbFechaIngreso.TabStop = true;
      this.rdbFechaIngreso.Text = "Fecha de Ingreso";
      this.rdbFechaIngreso.UseVisualStyleBackColor = true;
      this.cmbEstadoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbEstadoFiltro.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbEstadoFiltro.FormattingEnabled = true;
      this.cmbEstadoFiltro.Location = new Point(280, 41);
      this.cmbEstadoFiltro.Name = "cmbEstadoFiltro";
      this.cmbEstadoFiltro.Size = new Size(157, 22);
      this.cmbEstadoFiltro.TabIndex = 0;
      this.dtpHastaFiltro.CalendarFont = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpHastaFiltro.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpHastaFiltro.Format = DateTimePickerFormat.Short;
      this.dtpHastaFiltro.Location = new Point(143, 41);
      this.dtpHastaFiltro.Name = "dtpHastaFiltro";
      this.dtpHastaFiltro.Size = new Size(131, 22);
      this.dtpHastaFiltro.TabIndex = 3;
      this.dtpDesdeFiltro.CalendarFont = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpDesdeFiltro.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpDesdeFiltro.Format = DateTimePickerFormat.Short;
      this.dtpDesdeFiltro.Location = new Point(6, 41);
      this.dtpDesdeFiltro.Name = "dtpDesdeFiltro";
      this.dtpDesdeFiltro.Size = new Size(131, 22);
      this.dtpDesdeFiltro.TabIndex = 2;
      this.label13.BackColor = Color.LightSkyBlue;
      this.label13.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label13.ForeColor = Color.White;
      this.label13.Location = new Point(280, 23);
      this.label13.Name = "label13";
      this.label13.Size = new Size(157, 18);
      this.label13.TabIndex = 9;
      this.label13.Text = "Estado";
      this.label14.BackColor = Color.LightSkyBlue;
      this.label14.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.White;
      this.label14.Location = new Point(143, 23);
      this.label14.Name = "label14";
      this.label14.Size = new Size(131, 18);
      this.label14.TabIndex = 8;
      this.label14.Text = "Hasta";
      this.label15.BackColor = Color.LightSkyBlue;
      this.label15.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.White;
      this.label15.Location = new Point(6, 23);
      this.label15.Name = "label15";
      this.label15.Size = new Size(131, 18);
      this.label15.TabIndex = 7;
      this.label15.Text = "Desde";
      this.btnBuscaFiltro.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscaFiltro.Location = new Point(606, 40);
      this.btnBuscaFiltro.Name = "btnBuscaFiltro";
      this.btnBuscaFiltro.Size = new Size((int) sbyte.MaxValue, 23);
      this.btnBuscaFiltro.TabIndex = 1;
      this.btnBuscaFiltro.Text = "Buscar";
      this.btnBuscaFiltro.UseVisualStyleBackColor = true;
      this.btnBuscaFiltro.Click += new EventHandler(this.btnBuscaFiltro_Click);
      this.dgvOTfiltro.AllowUserToAddRows = false;
      this.dgvOTfiltro.AllowUserToDeleteRows = false;
      this.dgvOTfiltro.AllowUserToResizeColumns = false;
      this.dgvOTfiltro.AllowUserToResizeRows = false;
      gridViewCellStyle5.BackColor = Color.Lavender;
      this.dgvOTfiltro.AlternatingRowsDefaultCellStyle = gridViewCellStyle5;
      this.dgvOTfiltro.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvOTfiltro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvOTfiltro.Location = new Point(6, 119);
      this.dgvOTfiltro.Name = "dgvOTfiltro";
      this.dgvOTfiltro.ReadOnly = true;
      this.dgvOTfiltro.RowHeadersVisible = false;
      this.dgvOTfiltro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvOTfiltro.Size = new Size(820, 405);
      this.dgvOTfiltro.TabIndex = 4;
      this.dgvOTfiltro.DoubleClick += new EventHandler(this.dgvOTfiltro_DoubleClick);
      this.groupBox3.BackColor = SystemColors.Control;
      this.groupBox3.Controls.Add((Control) this.cmbEstado);
      this.groupBox3.Controls.Add((Control) this.dtpHasta);
      this.groupBox3.Controls.Add((Control) this.dtpDesde);
      this.groupBox3.Controls.Add((Control) this.label1);
      this.groupBox3.Controls.Add((Control) this.label2);
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Controls.Add((Control) this.dgDatosEstado);
      this.groupBox3.Controls.Add((Control) this.btnBuscar);
      this.groupBox3.Location = new Point(6, 6);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(798, 476);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.cmbEstado.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbEstado.FormattingEnabled = true;
      this.cmbEstado.Location = new Point(280, 41);
      this.cmbEstado.Name = "cmbEstado";
      this.cmbEstado.Size = new Size(157, 22);
      this.cmbEstado.TabIndex = 0;
      this.dtpHasta.CalendarFont = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpHasta.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpHasta.Format = DateTimePickerFormat.Short;
      this.dtpHasta.Location = new Point(143, 41);
      this.dtpHasta.Name = "dtpHasta";
      this.dtpHasta.Size = new Size(131, 22);
      this.dtpHasta.TabIndex = 3;
      this.dtpDesde.CalendarFont = new Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpDesde.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dtpDesde.Format = DateTimePickerFormat.Short;
      this.dtpDesde.Location = new Point(6, 41);
      this.dtpDesde.Name = "dtpDesde";
      this.dtpDesde.Size = new Size(131, 22);
      this.dtpDesde.TabIndex = 2;
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(280, 23);
      this.label1.Name = "label1";
      this.label1.Size = new Size(157, 18);
      this.label1.TabIndex = 9;
      this.label1.Text = "Estado";
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(143, 23);
      this.label2.Name = "label2";
      this.label2.Size = new Size(131, 18);
      this.label2.TabIndex = 8;
      this.label2.Text = "Hasta";
      this.label3.BackColor = Color.FromArgb(64, 64, 64);
      this.label3.Font = new Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(6, 23);
      this.label3.Name = "label3";
      this.label3.Size = new Size(131, 18);
      this.label3.TabIndex = 7;
      this.label3.Text = "Desde";
      this.dgDatosEstado.AllowUserToAddRows = false;
      this.dgDatosEstado.AllowUserToDeleteRows = false;
      this.dgDatosEstado.AllowUserToResizeColumns = false;
      this.dgDatosEstado.AllowUserToResizeRows = false;
      this.dgDatosEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgDatosEstado.Columns.AddRange((DataGridViewColumn) this.Numero2, (DataGridViewColumn) this.Fecha2, (DataGridViewColumn) this.Nombre2, (DataGridViewColumn) this.Requerimiento2, (DataGridViewColumn) this.Tecnico2, (DataGridViewColumn) this.Estado2, (DataGridViewColumn) this.Contacto2, (DataGridViewColumn) this.Email2);
      this.dgDatosEstado.Location = new Point(6, 71);
      this.dgDatosEstado.Name = "dgDatosEstado";
      this.dgDatosEstado.ReadOnly = true;
      this.dgDatosEstado.RowHeadersVisible = false;
      this.dgDatosEstado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgDatosEstado.Size = new Size(780, 358);
      this.dgDatosEstado.TabIndex = 4;
      this.Numero2.DataPropertyName = "NUMERO";
      this.Numero2.HeaderText = "Numero";
      this.Numero2.Name = "Numero2";
      this.Numero2.ReadOnly = true;
      this.Numero2.Visible = false;
      this.Fecha2.DataPropertyName = "FECHA";
      this.Fecha2.HeaderText = "Fecha";
      this.Fecha2.Name = "Fecha2";
      this.Fecha2.ReadOnly = true;
      this.Fecha2.Width = 75;
      this.Nombre2.DataPropertyName = "NOMBRE";
      this.Nombre2.HeaderText = "Cliente";
      this.Nombre2.Name = "Nombre2";
      this.Nombre2.ReadOnly = true;
      this.Nombre2.Width = 240;
      this.Requerimiento2.DataPropertyName = "Motivo";
      this.Requerimiento2.HeaderText = "Requerimiento";
      this.Requerimiento2.Name = "Requerimiento2";
      this.Requerimiento2.ReadOnly = true;
      this.Requerimiento2.Width = 250;
      this.Tecnico2.DataPropertyName = "TECNICO";
      this.Tecnico2.HeaderText = "Tecnico";
      this.Tecnico2.Name = "Tecnico2";
      this.Tecnico2.ReadOnly = true;
      this.Tecnico2.Width = 120;
      this.Estado2.DataPropertyName = "ESTADO";
      this.Estado2.HeaderText = "Estado";
      this.Estado2.Name = "Estado2";
      this.Estado2.ReadOnly = true;
      this.Estado2.Width = 80;
      this.Contacto2.DataPropertyName = "CONTACTO";
      this.Contacto2.HeaderText = "Contacto";
      this.Contacto2.Name = "Contacto2";
      this.Contacto2.ReadOnly = true;
      this.Contacto2.Visible = false;
      this.Email2.DataPropertyName = "EMAIL";
      this.Email2.HeaderText = "Email";
      this.Email2.Name = "Email2";
      this.Email2.ReadOnly = true;
      this.Email2.Visible = false;
      this.btnBuscar.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBuscar.Location = new Point(443, 40);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new Size((int) sbyte.MaxValue, 23);
      this.btnBuscar.TabIndex = 1;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnReconectar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnReconectar.Location = new Point(855, 224);
      this.btnReconectar.Name = "btnReconectar";
      this.btnReconectar.Size = new Size(113, 65);
      this.btnReconectar.TabIndex = 46;
      this.btnReconectar.Text = "Reconectar Servidor";
      this.btnReconectar.UseVisualStyleBackColor = true;
      this.btnReconectar.Visible = false;
      this.btnReconectar.Click += new EventHandler(this.btnReconectar_Click);
      this.panelColorDeuda.Location = new Point(859, 54);
      this.panelColorDeuda.Name = "panelColorDeuda";
      this.panelColorDeuda.Size = new Size(96, 142);
      this.panelColorDeuda.TabIndex = 47;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(979, 594);
      this.Controls.Add((Control) this.panelColorDeuda);
      this.Controls.Add((Control) this.btnReconectar);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiar);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "frmOrdenAtencion";
      this.ShowIcon = false;
      this.Text = "Orden de Atención";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmOrdenAtencion_FormClosing);
      this.gbZonaCliente.ResumeLayout(false);
      this.gbZonaCliente.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvLicencias).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((ISupportInitialize) this.dgvOt).EndInit();
      this.pnlBuscaClienteDes.ResumeLayout(false);
      ((ISupportInitialize) this.dgvBuscaCliente).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      ((ISupportInitialize) this.dgvOTfiltro).EndInit();
      this.groupBox3.ResumeLayout(false);
      ((ISupportInitialize) this.dgDatosEstado).EndInit();
      this.ResumeLayout(false);
    }
  }
}
