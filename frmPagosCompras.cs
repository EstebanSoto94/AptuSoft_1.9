 
// Type: Aptusoft.frmPagosCompras
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmPagosCompras : Form
  {
    private static List<PagoVentaVO> listaPago = new List<PagoVentaVO>();
    private static int _linea = 0;
    private static int idDoc = 0;
    private frmIngresoCompra frmIC = (frmIngresoCompra) null;
    private frmListadoPagosCompra frmLPC = (frmListadoPagosCompra) null;
    private frmServicio frmSER = (frmServicio) null;
    private bool _guarda = false;
    private bool _modifica = false;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private TextBox txtRazonSocial;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label label4;
    private TextBox txtEmision;
    private TextBox txtFolio;
    private GroupBox groupBox2;
    private Label label5;
    private TextBox txtTotalFactura;
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
    private TextBox txtTipoDocCompra;

    public frmPagosCompras()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
    }

    public frmPagosCompras(ref frmIngresoCompra co, string modulo, int idCompra)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmIC = co;
      this.txtTipoDocCompra.Text = modulo;
      this.buscaCompra(idCompra);
    }

    public frmPagosCompras(ref frmListadoPagosCompra lpc, string modulo, int idCompra)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmLPC = lpc;
      this.txtTipoDocCompra.Text = modulo;
      if (modulo.Equals("SERVICIO"))
        this.buscaServicio(idCompra);
      else
        this.buscaCompra(idCompra);
    }

    public frmPagosCompras(ref frmServicio ser, string modulo, int idServicio)
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.frmSER = ser;
      this.txtTipoDocCompra.Text = modulo;
      this.buscaServicio(idServicio);
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("PAGOS COMPRAS"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
        }
      }
    }

    private void iniciaFormulario()
    {
      frmPagosCompras.listaPago.Clear();
      this.cargaMediosPago();
      this.cargaBancos();
      this.txtFolio.Enabled = true;
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
      this.rdbPagado.Checked = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiar.Enabled = false;
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnImprimir.Enabled = false;
      frmPagosCompras.idDoc = 0;
    }

    private void limpiaEntradaPagos()
    {
      this.cmbMedioPago.SelectedValue = (object) 0;
      this.cmbBanco.SelectedValue = (object) 0;
      this.rdbPagado.Checked = true;
      this.txtMonto.Clear();
      this.dtpFechaCobro.Value = DateTime.Now;
      this.txtCuenta.Clear();
      this.txtNumeroDocumento.Clear();
      this.txtObservaciones.Clear();
      this.cmbMedioPago.Focus();
      this.btnAgregar.Enabled = true;
      this.btnLimpiar.Enabled = true;
      this.btnModificaLinea.Visible = false;
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
      this.dgvDetalle.Columns[1].Width = 70;
      this.dgvDetalle.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("FormaPago", "Forma de Pago");
      this.dgvDetalle.Columns[2].DataPropertyName = "FormaPago";
      this.dgvDetalle.Columns[2].Width = 100;
      this.dgvDetalle.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Monto", "Monto");
      this.dgvDetalle.Columns[3].DataPropertyName = "Monto";
      this.dgvDetalle.Columns[3].Width = 80;
      this.dgvDetalle.Columns[3].DefaultCellStyle.Format = "C0";
      this.dgvDetalle.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDetalle.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Banco", "Banco");
      this.dgvDetalle.Columns[4].DataPropertyName = "Banco";
      this.dgvDetalle.Columns[4].Width = 100;
      this.dgvDetalle.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Cuenta", "Cuenta");
      this.dgvDetalle.Columns[5].DataPropertyName = "Cuenta";
      this.dgvDetalle.Columns[5].Width = 100;
      this.dgvDetalle.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("NumeroDocumento", "N° Documento");
      this.dgvDetalle.Columns[6].DataPropertyName = "NumeroDocumento";
      this.dgvDetalle.Columns[6].Width = 100;
      this.dgvDetalle.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDetalle.Columns.Add("Observaciones", "Observaciones");
      this.dgvDetalle.Columns[7].DataPropertyName = "Observaciones";
      this.dgvDetalle.Columns[7].Width = 150;
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
    }

    private void buscaCompra(int idCompra)
    {
      Venta venta1 = new Venta();
      Venta venta2 = new DocumentoCompra().buscaCompraID(idCompra);
      if (venta2.IdFactura != 0)
      {
        frmPagosCompras.idDoc = venta2.IdFactura;
        this.txtRut.Text = venta2.Rut + "-" + venta2.Digito;
        this.txtRazonSocial.Text = venta2.RazonSocial;
        this.txtEmision.Text = venta2.FechaEmision.ToShortDateString();
        this.txtFolio.Text = venta2.FolioIngresoCompra.ToString();
        TextBox textBox1 = this.txtTotalFactura;
        Decimal num1 = venta2.TotalaCobrar;
        string str1 = num1.ToString("N0");
        textBox1.Text = str1;
        this.lblEstadoPago.Text = venta2.EstadoPago;
        TextBox textBox2 = this.txtTotalPagado;
        num1 = venta2.TotalPagado;
        string str2 = num1.ToString("N0");
        textBox2.Text = str2;
        TextBox textBox3 = this.txtTotalDocumentado;
        num1 = venta2.TotalDocumentado;
        string str3 = num1.ToString("N0");
        textBox3.Text = str3;
        TextBox textBox4 = this.txtTotalPendiente;
        num1 = venta2.TotalPendiente;
        string str4 = num1.ToString("N0");
        textBox4.Text = str4;
        PagoCompra pagoCompra = new PagoCompra();
        try
        {
          frmPagosCompras.listaPago = pagoCompra.listaPagosCompra(this.txtTipoDocCompra.Text.Trim(), frmPagosCompras.idDoc, venta2.FolioIngresoCompra);
        }
        catch (Exception ex)
        {
          int num2 = (int) MessageBox.Show("Error: " + ex.Message);
        }
        if (frmPagosCompras.listaPago.Count > 0)
        {
          this.btnGuardar.Enabled = false;
          if (this._modifica)
            this.btnModificar.Enabled = true;
          this.btnImprimir.Enabled = true;
          for (int index = 0; index < frmPagosCompras.listaPago.Count; ++index)
            frmPagosCompras.listaPago[index].Linea = index + 1;
          this.dgvDetalle.DataSource = (object) null;
          this.dgvDetalle.DataSource = (object) frmPagosCompras.listaPago;
        }
        this.btnAgregar.Enabled = true;
        this.btnLimpiar.Enabled = true;
        this.txtFolio.Enabled = false;
        this.cmbMedioPago.Focus();
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Documento Consultado");
      }
    }

    private void buscaServicio(int idServicio)
    {
      ServicioVO servicioVo1 = new ServicioVO();
      ServicioVO servicioVo2 = new Servicio().buscaServicioID(idServicio.ToString());
      if (servicioVo2.IdServicio != 0)
      {
        frmPagosCompras.idDoc = servicioVo2.IdServicio;
        this.txtRut.Text = servicioVo2.Rut + "-" + servicioVo2.Digito;
        this.txtRazonSocial.Text = servicioVo2.RazonSocial;
        this.txtEmision.Text = servicioVo2.FechaIngreso.ToShortDateString();
        this.txtFolio.Text = servicioVo2.FolioServicio;
        this.txtTotalFactura.Text = servicioVo2.Total.ToString("N0");
        this.lblEstadoPago.Text = servicioVo2.EstadoPago;
        this.txtTotalPagado.Text = servicioVo2.TotalPagado.ToString("N0");
        TextBox textBox1 = this.txtTotalDocumentado;
        Decimal num1 = servicioVo2.TotalDocumentado;
        string str1 = num1.ToString("N0");
        textBox1.Text = str1;
        TextBox textBox2 = this.txtTotalPendiente;
        num1 = servicioVo2.TotalPendiente;
        string str2 = num1.ToString("N0");
        textBox2.Text = str2;
        PagoCompra pagoCompra = new PagoCompra();
        try
        {
          frmPagosCompras.listaPago = pagoCompra.listaPagosCompra(this.txtTipoDocCompra.Text.Trim(), frmPagosCompras.idDoc, (long) Convert.ToInt32(servicioVo2.FolioServicio));
        }
        catch (Exception ex)
        {
          int num2 = (int) MessageBox.Show("Error: " + ex.Message);
        }
        if (frmPagosCompras.listaPago.Count > 0)
        {
          this.btnGuardar.Enabled = false;
          if (this._modifica)
            this.btnModificar.Enabled = true;
          this.btnImprimir.Enabled = true;
          for (int index = 0; index < frmPagosCompras.listaPago.Count; ++index)
            frmPagosCompras.listaPago[index].Linea = index + 1;
          this.dgvDetalle.DataSource = (object) null;
          this.dgvDetalle.DataSource = (object) frmPagosCompras.listaPago;
        }
        this.btnAgregar.Enabled = true;
        this.btnLimpiar.Enabled = true;
        this.txtFolio.Enabled = false;
        this.cmbMedioPago.Focus();
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Documento Consultado");
      }
    }

    private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolio);
      if ((int) e.KeyChar != 13)
        ;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      this.Dispose();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if (!this.validaIngreso())
        return;
      this.agregaPago();
    }

    private void agregaPago()
    {
      PagoVentaVO pagoVentaVo = new PagoVentaVO();
      DateTime dateTime=DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
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
      // ISSUE: explicit reference operation
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
      frmPagosCompras.listaPago.Add(pagoVentaVo);
      for (int index = 0; index < frmPagosCompras.listaPago.Count; ++index)
        frmPagosCompras.listaPago[index].Linea = index + 1;
      this.calculaTotales();
      this.limpiaEntradaPagos();
    }

    private void calculaTotales()
    {
      this.dgvDetalle.DataSource = (object) null;
      this.dgvDetalle.DataSource = (object) frmPagosCompras.listaPago;
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = Convert.ToDecimal(this.txtTotalFactura.Text.Trim());
      foreach (PagoVentaVO pagoVentaVo in frmPagosCompras.listaPago)
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
        int num = (int) MessageBox.Show("Debe seleccionar un Medio de Pago Valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.cmbMedioPago.Focus();
        return false;
      }
      if (this.txtMonto.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe ingresar Un Monto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtMonto.Focus();
        return false;
      }
      Decimal num1 = this.txtTotalFactura.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalFactura.Text.Trim()) : new Decimal(0);
      Decimal num2 = this.txtTotalPagado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPagado.Text.Trim()) : new Decimal(0);
      Decimal num3 = this.txtTotalDocumentado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDocumentado.Text.Trim()) : new Decimal(0);
      Decimal num4 = this.txtTotalPendiente.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPendiente.Text.Trim()) : new Decimal(0);
      Decimal num5 = this.txtMonto.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtMonto.Text.Trim()) : new Decimal(0);
      if (!(num2 + num3 + num5 > num1))
        return true;
      int num6 = (int) MessageBox.Show("Los Montos No Deben superar al Total de La Factura", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
      if (!(this.dgvDetalle.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar este Pago", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      int num = Convert.ToInt32(this.dgvDetalle.SelectedRows[0].Cells[0].Value.ToString());
      for (int index = 0; index < frmPagosCompras.listaPago.Count; ++index)
      {
        if (frmPagosCompras.listaPago[index].Linea == num)
        {
          frmPagosCompras.listaPago.RemoveAt(index);
          --index;
        }
      }
      this.calculaTotales();
      this.limpiaEntradaPagos();
    }

    private void dgvDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.btnModificaLinea.Visible = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiar.Enabled = false;
      frmPagosCompras._linea = Convert.ToInt32(this.dgvDetalle.SelectedRows[0].Cells[0].Value.ToString());
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

    private void btnModificaLinea_Click(object sender, EventArgs e)
    {
      Decimal num1 = this.txtTotalFactura.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalFactura.Text.Trim()) : new Decimal(0);
      Decimal num2 = this.txtTotalPagado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPagado.Text.Trim()) : new Decimal(0);
      Decimal num3 = this.txtTotalDocumentado.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalDocumentado.Text.Trim()) : new Decimal(0);
      Decimal num4 = this.txtTotalPendiente.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtTotalPendiente.Text.Trim()) : new Decimal(0);
      Decimal num5 = this.txtMonto.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtMonto.Text.Trim()) : new Decimal(0);
      bool flag = false;
      for (int index = 0; index < frmPagosCompras.listaPago.Count; ++index)
      {
        if (frmPagosCompras.listaPago[index].Linea == frmPagosCompras._linea)
        {
          if (frmPagosCompras.listaPago[index].Estado.Equals("PAGADO"))
            num2 -= frmPagosCompras.listaPago[index].Monto;
          else
            num3 -= frmPagosCompras.listaPago[index].Monto;
          if (num2 + num3 + num5 > num1)
          {
            int num6 = (int) MessageBox.Show("los Montos no Deben superar al Total de La Factura");
            this.txtMonto.Focus();
          }
          else
          {
            PagoVentaVO pagoVentaVo = new PagoVentaVO();
            DateTime dateTime=DateTime.Now;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
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
            // ISSUE: explicit reference operation
            local = new DateTime(year, month, day, hours, minutes, seconds);
            frmPagosCompras.listaPago[index].FechaCobro = dateTime;
            frmPagosCompras.listaPago[index].FormaPago = this.cmbMedioPago.Text;
            frmPagosCompras.listaPago[index].IdFormaPago = Convert.ToInt32(this.cmbMedioPago.SelectedValue);
            frmPagosCompras.listaPago[index].Monto = Convert.ToDecimal(this.txtMonto.Text.Trim());
            if (this.rdbPagado.Checked)
              frmPagosCompras.listaPago[index].Estado = "PAGADO";
            if (this.rdbDocumentado.Checked)
              frmPagosCompras.listaPago[index].Estado = "DOCUMENTADO";
            frmPagosCompras.listaPago[index].Banco = this.cmbBanco.SelectedIndex != 0 ? this.cmbBanco.Text : "";
            frmPagosCompras.listaPago[index].Cuenta = this.txtCuenta.Text.Trim();
            frmPagosCompras.listaPago[index].NumeroDocumento = this.txtNumeroDocumento.Text.Trim();
            frmPagosCompras.listaPago[index].Observaciones = this.txtObservaciones.Text.Trim().ToUpper();
            flag = true;
          }
        }
      }
      if (!flag)
        return;
      this.dgvDetalle.DataSource = (object) null;
      this.dgvDetalle.DataSource = (object) frmPagosCompras.listaPago;
      this.calculaTotales();
      this.limpiaEntradaPagos();
    }

    private void estadoDocumento()
    {
      Decimal num1 = Convert.ToDecimal(this.txtTotalFactura.Text);
      Decimal num2 = Convert.ToDecimal(this.txtTotalPagado.Text);
      Decimal num3 = Convert.ToDecimal(this.txtTotalDocumentado.Text);
      Decimal num4 = Convert.ToDecimal(this.txtTotalPendiente.Text);
      if (num1 == num2)
        this.lblEstadoPago.Text = "PAGADO";
      else if (num3 > new Decimal(0) && num1 != num2 && num4 == new Decimal(0))
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
      frmPagosCompras.listaPago.Clear();
      this.dgvDetalle.DataSource = (object) null;
      this.calculaTotales();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaPagoCompra();
    }

    private void guardaPagoCompra()
    {
      if (!this.validaIngresoPagoCompra())
        return;
      PagoCompra pagoCompra = new PagoCompra();
      string text1 = this.txtTipoDocCompra.Text;
      long folio = Convert.ToInt64(this.txtFolio.Text.Trim());
      DateTime now = DateTime.Now;
      string text2 = this.lblEstadoPago.Text;
      Decimal tPagado = Convert.ToDecimal(this.txtTotalPagado.Text);
      Decimal tDocumentado = Convert.ToDecimal(this.txtTotalDocumentado.Text);
      Decimal tPendiente = Convert.ToDecimal(this.txtTotalPendiente.Text);
      int num = (int) MessageBox.Show(pagoCompra.ingresaPagoCompra(frmPagosCompras.listaPago, text1, frmPagosCompras.idDoc, folio, now, text2, tPagado, tDocumentado, tPendiente), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      if (MessageBox.Show("Desea Imprimir el Comprobante", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
        this.imprimeDirecto();
      this.iniciaFormulario();
    }

    private bool validaIngresoPagoCompra()
    {
      if (this.txtFolio.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar El Folio del Documento");
        this.txtFolio.Focus();
        return false;
      }
      if (frmPagosCompras.idDoc != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar El Folio del Documento");
      this.txtFolio.Focus();
      return false;
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      this.modificaPagoCompra();
    }

    private void modificaPagoCompra()
    {
      if (!this.validaIngresoPagoCompra())
        return;
      PagoCompra pagoCompra = new PagoCompra();
      string text1 = this.txtTipoDocCompra.Text;
      long folio = Convert.ToInt64(this.txtFolio.Text.Trim());
      DateTime today = DateTime.Today;
      string text2 = this.lblEstadoPago.Text;
      Decimal tPagado = Convert.ToDecimal(this.txtTotalPagado.Text);
      Decimal tDocumentado = Convert.ToDecimal(this.txtTotalDocumentado.Text);
      Decimal tPendiente = Convert.ToDecimal(this.txtTotalPendiente.Text);
      pagoCompra.modificaPagoCompra(frmPagosCompras.listaPago, text1, frmPagosCompras.idDoc, folio, today, text2, tPagado, tDocumentado, tPendiente);
      if (MessageBox.Show("Desea Imprimir el Comprobante", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        this.imprimeDirecto();
      this.iniciaFormulario();
    }

    private void frmPagoVenta_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F5 && this.validaIngreso())
        this.agregaPago();
      if (e.KeyCode != Keys.F2)
        return;
      if (this.btnGuardar.Enabled)
        this.guardaPagoCompra();
      if (this.btnModificar.Enabled)
        this.modificaPagoCompra();
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
      this.imprimeDirecto();
    }

    private void imprimeDirecto()
    {
      PagoCompra pagoCompra = new PagoCompra();
      if (!this.txtTipoDocCompra.Text.Equals("FACTURA COMPRA") && !this.txtTipoDocCompra.Text.Equals("FACTURA ELECTRONICA"))
        return;
      DataTable dataTable = pagoCompra.comprobantePagoCompra(Convert.ToInt64(this.txtFolio.Text), frmPagosCompras.idDoc);
      try
      {
        ReportDocument reportDocument = new ReportDocument();
        reportDocument.Load("C:\\AptuSoft\\reportes\\ComprobantePagoCompra.rpt");
        reportDocument.SetDataSource(dataTable);
        string str = new LeeXml().cargarDatosOtrosDocumentos();
        reportDocument.PrintOptions.PrinterName = str;
        reportDocument.PrintToPrinter(1, false, 1, 1);
        reportDocument.Close();
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Con Reporte " + ex.Message);
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
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
      this.txtTipoDocCompra = new TextBox();
      this.txtFolio = new TextBox();
      this.label4 = new Label();
      this.label1 = new Label();
      this.txtRut = new TextBox();
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
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.dgvDetalle).BeginInit();
      this.panel1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.txtTipoDocCompra);
      this.groupBox1.Controls.Add((Control) this.txtFolio);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(6, -3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(259, 60);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.txtTipoDocCompra.Enabled = false;
      this.txtTipoDocCompra.Location = new Point(6, 30);
      this.txtTipoDocCompra.Name = "txtTipoDocCompra";
      this.txtTipoDocCompra.Size = new Size(149, 20);
      this.txtTipoDocCompra.TabIndex = 28;
      this.txtTipoDocCompra.Text = "FACTURA COMPRA";
      this.txtFolio.BackColor = Color.White;
      this.txtFolio.Location = new Point(159, 31);
      this.txtFolio.Name = "txtFolio";
      this.txtFolio.Size = new Size(95, 20);
      this.txtFolio.TabIndex = 2;
      this.txtFolio.TextAlign = HorizontalAlignment.Right;
      this.txtFolio.KeyPress += new KeyPressEventHandler(this.txtFolio_KeyPress);
      this.label4.BackColor = Color.FromArgb(64, 64, 64);
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(159, 14);
      this.label4.Name = "label4";
      this.label4.Size = new Size(94, 22);
      this.label4.TabIndex = 7;
      this.label4.Text = "Folio";
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(7, 14);
      this.label1.Name = "label1";
      this.label1.Size = new Size(148, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tipo Documento";
      this.txtRut.BackColor = Color.White;
      this.txtRut.Location = new Point(111, 31);
      this.txtRut.Name = "txtRut";
      this.txtRut.ReadOnly = true;
      this.txtRut.Size = new Size(85, 20);
      this.txtRut.TabIndex = 14;
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
      this.txtRazonSocial.Size = new Size(396, 20);
      this.txtRazonSocial.TabIndex = 4;
      this.label3.AutoSize = true;
      this.label3.BackColor = SystemColors.Control;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Black;
      this.label3.Location = new Point(111, 14);
      this.label3.Name = "label3";
      this.label3.Size = new Size(29, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "Rut";
      this.label2.AutoSize = true;
      this.label2.BackColor = SystemColors.Control;
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
      this.groupBox2.Location = new Point(442, 349);
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
      this.label5.BackColor = Color.FromArgb(64, 64, 64);
      this.label5.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(252, 16);
      this.label5.Name = "label5";
      this.label5.Size = new Size(172, 34);
      this.label5.TabIndex = 1;
      this.label5.Text = "Total";
      this.label5.TextAlign = ContentAlignment.MiddleRight;
      this.txtObservaciones.Location = new Point(388, 51);
      this.txtObservaciones.Name = "txtObservaciones";
      this.txtObservaciones.Size = new Size(436, 20);
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
      this.label11.BackColor = SystemColors.Control;
      this.label11.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.Black;
      this.label11.Location = new Point(5, 9);
      this.label11.Name = "label11";
      this.label11.Size = new Size(115, 17);
      this.label11.TabIndex = 8;
      this.label11.Text = "Fecha de Cobro:";
      this.label11.TextAlign = ContentAlignment.MiddleLeft;
      this.txtMonto.Location = new Point(525, 9);
      this.txtMonto.Name = "txtMonto";
      this.txtMonto.Size = new Size(90, 20);
      this.txtMonto.TabIndex = 5;
      this.txtMonto.TextAlign = HorizontalAlignment.Right;
      this.txtMonto.KeyPress += new KeyPressEventHandler(this.txtMonto_KeyPress);
      this.label10.BackColor = SystemColors.Control;
      this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = Color.Black;
      this.label10.Location = new Point(475, 9);
      this.label10.Name = "label10";
      this.label10.Size = new Size(53, 17);
      this.label10.TabIndex = 6;
      this.label10.Text = "Monto:";
      this.label10.TextAlign = ContentAlignment.MiddleLeft;
      this.rdbDocumentado.BackColor = SystemColors.Control;
      this.rdbDocumentado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.rdbDocumentado.Location = new Point(710, 9);
      this.rdbDocumentado.Name = "rdbDocumentado";
      this.rdbDocumentado.Size = new Size(114, 17);
      this.rdbDocumentado.TabIndex = 7;
      this.rdbDocumentado.TabStop = true;
      this.rdbDocumentado.Text = "Documentado";
      this.rdbDocumentado.UseVisualStyleBackColor = false;
      this.rdbPagado.BackColor = SystemColors.Control;
      this.rdbPagado.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.rdbPagado.Location = new Point(626, 9);
      this.rdbPagado.Name = "rdbPagado";
      this.rdbPagado.Size = new Size(83, 20);
      this.rdbPagado.TabIndex = 6;
      this.rdbPagado.TabStop = true;
      this.rdbPagado.Text = "Pagado";
      this.rdbPagado.TextAlign = ContentAlignment.TopLeft;
      this.rdbPagado.UseVisualStyleBackColor = false;
      this.cmbMedioPago.FormattingEnabled = true;
      this.cmbMedioPago.Location = new Point(352, 9);
      this.cmbMedioPago.Name = "cmbMedioPago";
      this.cmbMedioPago.Size = new Size(114, 21);
      this.cmbMedioPago.TabIndex = 4;
      this.label9.BackColor = SystemColors.Control;
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
      this.dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvDetalle.Location = new Point(6, 173);
      this.dgvDetalle.Name = "dgvDetalle";
      this.dgvDetalle.ReadOnly = true;
      this.dgvDetalle.RowHeadersVisible = false;
      this.dgvDetalle.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDetalle.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDetalle.Size = new Size(872, 170);
      this.dgvDetalle.TabIndex = 27;
      this.dgvDetalle.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDetalle_CellDoubleClick);
      this.dgvDetalle.CellClick += new DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
      this.btnAgregar.Location = new Point(713, 144);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(75, 23);
      this.btnAgregar.TabIndex = 12;
      this.btnAgregar.Text = "Agregar [F5]";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.btnLimpiar.Location = new Point(794, 144);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 23);
      this.btnLimpiar.TabIndex = 13;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnGuardar.Location = new Point(6, 388);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 23);
      this.btnGuardar.TabIndex = 15;
      this.btnGuardar.Text = "Guardar [F2]";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnModificar.Location = new Point(87, 388);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(85, 23);
      this.btnModificar.TabIndex = 16;
      this.btnModificar.Text = "Modificar [F2]";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnImprimir.Location = new Point(6, 416);
      this.btnImprimir.Name = "btnImprimir";
      this.btnImprimir.Size = new Size(75, 23);
      this.btnImprimir.TabIndex = 17;
      this.btnImprimir.Text = "Imprimir";
      this.btnImprimir.UseVisualStyleBackColor = true;
      this.btnImprimir.Click += new EventHandler(this.btnImprimir_Click);
      this.btnLimpiarFormulario.Location = new Point(87, 416);
      this.btnLimpiarFormulario.Name = "btnLimpiarFormulario";
      this.btnLimpiarFormulario.Size = new Size(75, 23);
      this.btnLimpiarFormulario.TabIndex = 18;
      this.btnLimpiarFormulario.Text = "Limpiar";
      this.btnLimpiarFormulario.UseVisualStyleBackColor = true;
      this.btnLimpiarFormulario.Click += new EventHandler(this.btnLimpiarFormulario_Click);
      this.btnSalir.Location = new Point(166, 416);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 23);
      this.btnSalir.TabIndex = 19;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.lblEstadoPago.AutoSize = true;
      this.lblEstadoPago.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblEstadoPago.ForeColor = Color.Black;
      this.lblEstadoPago.Location = new Point(11, 348);
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
      this.panel1.Size = new Size(873, 80);
      this.panel1.TabIndex = 22;
      this.btnLimpiaDetalle.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiaDetalle.Location = new Point(842, 3);
      this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
      this.btnLimpiaDetalle.Size = new Size(19, 68);
      this.btnLimpiaDetalle.TabIndex = 20;
      this.btnLimpiaDetalle.Text = "..";
      this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaDetalle.Click += new EventHandler(this.btnLimpiaDetalle_Click);
      this.btnModificaLinea.Location = new Point(632, 144);
      this.btnModificaLinea.Name = "btnModificaLinea";
      this.btnModificaLinea.Size = new Size(75, 23);
      this.btnModificaLinea.TabIndex = 14;
      this.btnModificaLinea.Text = "Modificar";
      this.btnModificaLinea.UseVisualStyleBackColor = true;
      this.btnModificaLinea.Click += new EventHandler(this.btnModificaLinea_Click);
      this.groupBox3.Controls.Add((Control) this.txtRazonSocial);
      this.groupBox3.Controls.Add((Control) this.label16);
      this.groupBox3.Controls.Add((Control) this.txtEmision);
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Controls.Add((Control) this.txtRut);
      this.groupBox3.Controls.Add((Control) this.label2);
      this.groupBox3.Location = new Point(268, -3);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(608, 60);
      this.groupBox3.TabIndex = 21;
      this.groupBox3.TabStop = false;
      this.label16.AutoSize = true;
      this.label16.BackColor = SystemColors.Control;
      this.label16.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = Color.Black;
      this.label16.Location = new Point(199, 14);
      this.label16.Name = "label16";
      this.label16.Size = new Size(92, 15);
      this.label16.TabIndex = 15;
      this.label16.Text = "Razon Social";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(890, 451);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.btnModificaLinea);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.lblEstadoPago);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiarFormulario);
      this.Controls.Add((Control) this.btnImprimir);
      this.Controls.Add((Control) this.btnModificar);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.btnAgregar);
      this.Controls.Add((Control) this.dgvDetalle);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox2);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "frmPagosCompras";
      this.ShowIcon = false;
      this.Text = "Control De Pagos de Compras";
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
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
