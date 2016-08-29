 
// Type: Aptusoft.frmTraspasoInterno
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmTraspasoInterno : Form
  {
    private Decimal stock = new Decimal(0);
    private List<DetalleTraspaso> lista = new List<DetalleTraspaso>();
    private List<ProductoAuxiliar> listaAuxiliar = new List<ProductoAuxiliar>();
    private int idTraspaso = 0;
    private int linea = 0;
    private bool _modBodega = false;
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private bool _anula = false;
    private bool _cambioFecha = false;
    private int _caja = 0;
    private IContainer components = (IContainer) null;
    private frmTraspasoInterno intance;
    private GroupBox groupBox1;
    private Label label33;
    private Label label28;
    private ComboBox cmbBodegaDestino;
    private ComboBox cmbBodega;
    private Panel panelZonaDetalle;
    private Button btnLimpiaLineaDetalle;
    private Button btnModificaLinea;
    private TextBox txtCodigo;
    private TextBox txtCantidad;
    private DataGridView dgvDatosVenta;
    private Button btnAgregar;
    private TextBox txtDescripcion;
    private Button btnLimpiaDetalle;
    private TextBox txtTotalLinea;
    private Label label20;
    private TextBox txtPrecio;
    private Label label14;
    private Label label13;
    private Label label15;
    private Label label17;
    private DateTimePicker dtpEmision;
    private Label label1;
    private Label lblFolio;
    private TextBox txtNumeroDocumento;
    private TextBox txtAutorizado;
    private Label label12;
    private TextBox txtObservacion;
    private Label label2;
    private GroupBox gbZonaBotones;
    private Label lblFacturada;
    private Label label3;
    private Button btnImprime;
    private Button btnSalir;
    private TextBox txtPorIva;
    private Button btnLimpiar;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnModificar;
    private TextBox txtTotalGeneral;
    private TextBox txtIva;
    private TextBox txtNeto;
    private Label label26;
    private Label label25;
    private Label label24;
    private Panel panelFolio;
    private Button btnCerrarPanelFolio;
    private Button btnBuscaFolio;
    private TextBox txtFolioBuscar;
    private Label label32;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem;
    private ToolStripMenuItem buscarProductosTeclaF4ToolStripMenuItem;
    private ToolStripMenuItem buscarTraspasoTeclaF6ToolStripMenuItem;
    private ToolStripMenuItem guardarTraspasoTeclaF2ToolStripMenuItem;

    public frmTraspasoInterno()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
      this.intance = this;
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("TRASPASO INTERNO"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._anula = Convert.ToBoolean(usuarioVo.Anula);
          this._cambioFecha = Convert.ToBoolean(usuarioVo.CambioFecha);
          this._caja = usuarioVo.IdCaja;
        }
      }
    }

    private void iniciaFormulario()
    {
      try
      {
        this.obtieneFolioTraspasoDisponible();
        this.txtNumeroDocumento.Enabled = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error Cargar Folio: " + ex.Message);
      }
      this.cargaBodega();
      this.cargaIvaInicio();
      this.dtpEmision.Value = DateTime.Today;
      if (this._cambioFecha)
        this.dtpEmision.Enabled = true;
      else
        this.dtpEmision.Enabled = false;
      this.txtAutorizado.Clear();
      this.txtObservacion.Clear();
      this.txtTotalGeneral.Clear();
      this.txtNeto.Clear();
      this.txtIva.Clear();
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtDescripcion.Enabled = false;
      this.txtCantidad.Clear();
      this.txtPrecio.Clear();
      this.txtTotalLinea.Clear();
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Enabled = true;
      this.btnLimpiaDetalle.Enabled = true;
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnImprime.Enabled = false;
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.Columns.Clear();
      this.creaColumnasDetalle();
      this.lista.Clear();
      this.listaAuxiliar.Clear();
      this.panelFolio.Visible = false;
      this.idTraspaso = 0;
    }

    private void iniciaDetalleTraspaso()
    {
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtCantidad.Clear();
      this.txtPrecio.Clear();
      this.txtTotalLinea.Clear();
      this.btnModificaLinea.Visible = false;
      this.btnAgregar.Enabled = true;
      this.btnLimpiaDetalle.Enabled = true;
      this.txtCodigo.Focus();
      this.linea = 0;
    }

    private void obtieneFolioTraspasoDisponible()
    {
      this.txtNumeroDocumento.Text = new Traspaso().folioTraspaso(this._caja).ToString();
    }

    private void cargaBodega()
    {
      CargaMaestros cargaMaestros = new CargaMaestros();
      this.cmbBodega.DataSource = (object) cargaMaestros.cargaBodega();
      this.cmbBodega.ValueMember = "codigo";
      this.cmbBodega.DisplayMember = "descripcion";
      this.cmbBodegaDestino.DataSource = (object) cargaMaestros.cargaBodega();
      this.cmbBodegaDestino.ValueMember = "codigo";
      this.cmbBodegaDestino.DisplayMember = "descripcion";
    }

    private void cargaIvaInicio()
    {
      this.txtPorIva.Text = new Calculos()._iva.ToString("N0");
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
      this.dgvDatosVenta.Columns[2].Width = 300;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Precio", "Precio");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "Precio";
      this.dgvDatosVenta.Columns[3].Width = 80;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Format = "C0";
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Cantidad", "Cantidad");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "Cantidad";
      this.dgvDatosVenta.Columns[4].Width = 80;
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Format = "N4";
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Total", "Total");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "TotalLinea";
      this.dgvDatosVenta.Columns[5].Width = 90;
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Format = "C0";
      this.dgvDatosVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("BodegaOrigen", "Origen");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "BodegaOrigen";
      this.dgvDatosVenta.Columns[6].Width = 65;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[6].Visible = true;
      this.dgvDatosVenta.Columns.Add("BodegaDestino", "Destino");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "BodegaDestino";
      this.dgvDatosVenta.Columns[7].Width = 65;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[7].Visible = true;
      this.dgvDatosVenta.Columns.Add("FolioLinea", "FolioLinea");
      this.dgvDatosVenta.Columns[8].DataPropertyName = "FolioLinea";
      this.dgvDatosVenta.Columns[8].Width = 90;
      this.dgvDatosVenta.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[8].Visible = false;
      this.dgvDatosVenta.Columns.Add("IdTraspaso", "IdTraspaso");
      this.dgvDatosVenta.Columns[9].DataPropertyName = "IdTraspaso";
      this.dgvDatosVenta.Columns[9].Width = 90;
      this.dgvDatosVenta.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[9].Visible = false;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Eliminar";
      viewButtonColumn.HeaderText = "Eliminar";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "X";
      viewButtonColumn.Width = 50;
      viewButtonColumn.DisplayIndex = 10;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn);
    }

    public void llamaProductoCodigo(string cod, int bodega)
    {
      this.cmbBodega.SelectedValue = (object) bodega.ToString();
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
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
        if (this.stock <= new Decimal(0))
        {
          int num = (int) MessageBox.Show("No Hay Stock Sufuciente, No Puede Transferir Productos Sin Stock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtCodigo.Focus();
        }
        else
        {
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
          this.txtPrecio.Text = productoVo.ValorCompra.ToString("##");
          this.txtCodigo.Text = productoVo.Codigo;
          this.txtDescripcion.Text = productoVo.Descripcion;
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

    public void cantidad()
    {
      this.txtCantidad.Text = "1";
    }

    public void agregaLineaGrilla()
    {
      DetalleTraspaso detalleTraspaso = new DetalleTraspaso();
      detalleTraspaso.Codigo = this.txtCodigo.Text.Trim().ToUpper();
      detalleTraspaso.Descripcion = this.txtDescripcion.Text.Trim().ToUpper();
      detalleTraspaso.Precio = this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text) : new Decimal(0);
      detalleTraspaso.Cantidad = this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text) : new Decimal(0);
      detalleTraspaso.BodegaOrigen = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      detalleTraspaso.BodegaDestino = Convert.ToInt32(this.cmbBodegaDestino.SelectedValue.ToString());
      if (detalleTraspaso.Cantidad > this.stock && this.txtCodigo.Text.Length > 0)
      {
        int num = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Imposible Hacer Venta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCantidad.Focus();
      }
      else
      {
        detalleTraspaso.TotalLinea = this.txtTotalLinea.Text.Length > 0 ? Convert.ToDecimal(this.txtTotalLinea.Text) : new Decimal(0);
        if (this.lista.Count > 0)
        {
          bool flag = false;
          for (int index = 0; index < this.lista.Count; ++index)
          {
            if (detalleTraspaso.Codigo.Length > 0 && detalleTraspaso.Codigo == this.lista[index].Codigo && (detalleTraspaso.Precio == this.lista[index].Precio && detalleTraspaso.BodegaOrigen == this.lista[index].BodegaOrigen) && detalleTraspaso.BodegaDestino == this.lista[index].BodegaDestino)
            {
              if (detalleTraspaso.Cantidad + this.lista[index].Cantidad > this.stock)
              {
                int num = (int) MessageBox.Show("No Hay Suficiente Stock, solo quedan :" + this.verificaDecimales(this.stock.ToString()), "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtCodigo.Focus();
                flag = true;
              }
              else
              {
                flag = true;
                this.lista[index].Cantidad = this.lista[index].Cantidad + detalleTraspaso.Cantidad;
                Decimal cantidad = this.lista[index].Cantidad;
                Decimal precio = this.lista[index].Precio;
                this.lista[index].TotalLinea = cantidad * precio;
                index = Enumerable.Count<DetalleTraspaso>((IEnumerable<DetalleTraspaso>) this.lista);
                this.iniciaDetalleTraspaso();
                this.calculaTotales();
                this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
              }
            }
          }
          if (!flag)
          {
            this.lista.Add(detalleTraspaso);
            this.iniciaDetalleTraspaso();
            this.calculaTotales();
            this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
          }
        }
        else
        {
          this.lista.Add(detalleTraspaso);
          this.iniciaDetalleTraspaso();
          this.calculaTotales();
          this.dgvDatosVenta.CurrentCell = this.dgvDatosVenta[1, this.dgvDatosVenta.Rows.Count - 1];
        }
      }
    }

    private void calculaTotales()
    {
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
      for (int index = 0; index < this.lista.Count; ++index)
        this.lista[index].Linea = index + 1;
      Calculos calculos = new Calculos();
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal total = calculos.totalGeneralTraspaso(this.lista);
      this.txtTotalGeneral.Text = total.ToString("N0");
      Decimal neto = calculos.totalNeto(total);
      this.txtNeto.Text = neto.ToString("N0");
      this.txtIva.Text = calculos.totalIva(neto).ToString("N0");
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

    private void calculaTotalLinea()
    {
      Calculos calculos = new Calculos();
      Decimal num = new Decimal(0);
      this.txtTotalLinea.Text = ((this.txtCantidad.Text.Length > 0 ? Convert.ToDecimal(this.txtCantidad.Text.Trim()) : new Decimal(0)) * (this.txtPrecio.Text.Length > 0 ? Convert.ToDecimal(this.txtPrecio.Text.Trim()) : new Decimal(0))).ToString("N0");
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modTraspasos = 0;
      this.Dispose();
      this.Close();
    }

    private void frmTraspasoInterno_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modTraspasos = 0;
      this.Dispose();
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0)
        return;
      e.Handled = false;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim(), Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()));
      this.txtCantidad.Focus();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if (this.txtCodigo.Text.Length > 0 && this.txtDescripcion.Text.Trim().Length > 0)
      {
        this.agregaLineaGrilla();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Agregar un Producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidad);
      if ((int) e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0 || this.txtDescripcion.Text.Trim().Length <= 0)
        return;
      if (this.btnAgregar.Enabled)
        this.agregaLineaGrilla();
      if (this.btnModificaLinea.Visible)
        this.modificaLinea();
    }

    private void txtCantidad_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
    }

    private void txtPrecio_TextChanged(object sender, EventArgs e)
    {
      this.calculaTotalLinea();
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

    private void dgvDatosVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.lista.Count <= 0)
        return;
      this.btnModificaLinea.Visible = true;
      this.btnAgregar.Enabled = false;
      this.btnLimpiaDetalle.Enabled = false;
      this.txtCodigo.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Codigo"].Value.ToString();
      this.txtDescripcion.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Descripcion"].Value.ToString();
      this.txtPrecio.Text = Convert.ToDecimal(this.dgvDatosVenta.SelectedRows[0].Cells["Precio"].Value.ToString()).ToString("##");
      this.txtCantidad.Text = this.verificaDecimales(this.dgvDatosVenta.SelectedRows[0].Cells["Cantidad"].Value.ToString());
      this.linea = Convert.ToInt32(this.dgvDatosVenta.SelectedRows[0].Cells["Linea"].Value.ToString());
      this.cmbBodega.SelectedValue = (object) this.dgvDatosVenta.SelectedRows[0].Cells["BodegaOrigen"].Value.ToString();
      this.cmbBodegaDestino.SelectedValue = (object) this.dgvDatosVenta.SelectedRows[0].Cells["BodegaDestino"].Value.ToString();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPrecio);
    }

    private void btnModificaLinea_Click(object sender, EventArgs e)
    {
      this.modificaLinea();
    }

    private void modificaLinea()
    {
      if (this.comparaStock(Convert.ToInt32(this.cmbBodega.SelectedValue.ToString()), Convert.ToDecimal(this.txtCantidad.Text), this.txtCodigo.Text.Trim()))
      {
        for (int index = 0; index < this.lista.Count; ++index)
        {
          if (this.lista[index].Linea == Convert.ToInt32(this.linea))
          {
            this.lista[index].Codigo = this.txtCodigo.Text;
            this.lista[index].Descripcion = this.txtDescripcion.Text;
            this.lista[index].Precio = Convert.ToDecimal(this.txtPrecio.Text);
            this.lista[index].Cantidad = Convert.ToDecimal(this.txtCantidad.Text);
            this.lista[index].TotalLinea = Convert.ToDecimal(this.txtTotalLinea.Text);
            this.lista[index].BodegaOrigen = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
            this.lista[index].BodegaDestino = Convert.ToInt32(this.cmbBodegaDestino.SelectedValue.ToString());
          }
        }
        this.dgvDatosVenta.DataSource = (object) null;
        this.dgvDatosVenta.DataSource = (object) this.lista;
        this.calculaTotales();
        this.iniciaDetalleTraspaso();
      }
      else
      {
        int num = (int) MessageBox.Show("No Hay stock Suficiente", "Alerta de Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private bool comparaStock(int bodega, Decimal stockCompara, string cod)
    {
      for (int index = 0; index < this.listaAuxiliar.Count; ++index)
      {
        if (bodega == 1 && this.listaAuxiliar[index].Bodega1 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 2 && this.listaAuxiliar[index].Bodega2 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 3 && this.listaAuxiliar[index].Bodega3 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 4 && this.listaAuxiliar[index].Bodega4 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)) || (bodega == 5 && this.listaAuxiliar[index].Bodega5 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 6 && this.listaAuxiliar[index].Bodega6 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 7 && this.listaAuxiliar[index].Bodega7 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 8 && this.listaAuxiliar[index].Bodega8 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod))) || (bodega == 9 && this.listaAuxiliar[index].Bodega9 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 10 && this.listaAuxiliar[index].Bodega10 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 11 && this.listaAuxiliar[index].Bodega11 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 12 && this.listaAuxiliar[index].Bodega12 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)) || (bodega == 13 && this.listaAuxiliar[index].Bodega13 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 14 && this.listaAuxiliar[index].Bodega14 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 15 && this.listaAuxiliar[index].Bodega15 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 16 && this.listaAuxiliar[index].Bodega16 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod)))) || (bodega == 17 && this.listaAuxiliar[index].Bodega17 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 18 && this.listaAuxiliar[index].Bodega18 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || (bodega == 19 && this.listaAuxiliar[index].Bodega19 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod) || bodega == 20 && this.listaAuxiliar[index].Bodega20 < stockCompara && this.listaAuxiliar[index].Codigo.Equals(cod))))
          return false;
      }
      return true;
    }

    private void guardaTraspaso()
    {
      TraspasoVO tVO = new TraspasoVO();
      Traspaso traspaso = new Traspaso();
      DateTime dateTime=DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local = @dateTime;
      DateTime now = this.dtpEmision.Value;
      int year = now.Year;
      now = this.dtpEmision.Value;
      int month = now.Month;
      now = this.dtpEmision.Value;
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
      tVO.FechaEmision = dateTime;
      tVO.BodegaOrigen = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      tVO.BodegaDestino = Convert.ToInt32(this.cmbBodegaDestino.SelectedValue.ToString());
      tVO.Autoriza = this.txtAutorizado.Text.Trim().ToUpper();
      tVO.Observaciones = this.txtObservacion.Text.Trim().ToUpper();
      tVO.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
      tVO.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
      tVO.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
      tVO.Caja = this._caja;
      if (traspaso.traspasoExiste(Convert.ToInt32(this.txtNumeroDocumento.Text.Trim())))
      {
        int num = (int) MessageBox.Show("Ya Existe un Traspaso con el N°: " + this.txtNumeroDocumento.Text + " Debe Modificar el Folio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.txtNumeroDocumento.Enabled = true;
        this.txtNumeroDocumento.Focus();
      }
      else
      {
        tVO.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        for (int index = 0; index < this.lista.Count; ++index)
        {
          this.lista[index].FolioLinea = tVO.Folio;
          this.lista[index].FechaIngreso = tVO.FechaEmision;
          this.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }
        try
        {
          traspaso.guardaTraspaso(tVO, this.lista);
          int num = (int) MessageBox.Show("Traspaso Guardado", "Gurdado Ok", MessageBoxButtons.OK, MessageBoxIcon.Question);
          this.imprimeTraspaso(tVO.Folio);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      this.guardaTraspaso();
    }

    private bool valida()
    {
      if (this.lista.Count == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Productos a Trasladar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCodigo.Focus();
        return false;
      }
      if (!(this.cmbBodega.SelectedValue.ToString() == this.cmbBodegaDestino.SelectedValue.ToString()))
        return true;
      int num1 = (int) MessageBox.Show("Las Bodegas Deben ser Distintas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.cmbBodega.Focus();
      return false;
    }

    private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtNumeroDocumento);
    }

    private void btnLimpiaDetalle_Click(object sender, EventArgs e)
    {
      this.listaAuxiliar.Clear();
      this.lista.Clear();
      this.dgvDatosVenta.DataSource = (object) null;
      this.calculaTotales();
    }

    private void buscaTraspaso()
    {
      Traspaso traspaso = new Traspaso();
      try
      {
        TraspasoVO traspasoVo = traspaso.buscaTraspasoFolio(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
        this.idTraspaso = traspasoVo.IdTraspaso;
        if (this.idTraspaso > 0)
        {
          this.dtpEmision.Value = traspasoVo.FechaEmision;
          this.cmbBodega.SelectedValue = (object) traspasoVo.BodegaOrigen;
          this.cmbBodegaDestino.SelectedValue = (object) traspasoVo.BodegaDestino;
          this.txtAutorizado.Text = traspasoVo.Autoriza;
          this.txtObservacion.Text = traspasoVo.Observaciones;
          this.txtNumeroDocumento.Text = traspasoVo.Folio.ToString();
          this.txtNeto.Text = traspasoVo.Neto.ToString("N0");
          TextBox textBox1 = this.txtIva;
          Decimal num = traspasoVo.Iva;
          string str1 = num.ToString("N0");
          textBox1.Text = str1;
          TextBox textBox2 = this.txtTotalGeneral;
          num = traspasoVo.Total;
          string str2 = num.ToString("N0");
          textBox2.Text = str2;
          this.lista = traspaso.buscaDetalleTraspaso(this.idTraspaso);
          for (int index = 0; index < this.lista.Count; ++index)
            this.lista[index].Linea = index + 1;
          this.dgvDatosVenta.DataSource = (object) null;
          this.dgvDatosVenta.DataSource = (object) this.lista;
          this.panelFolio.Visible = false;
          this.txtFolioBuscar.Clear();
          this.btnGuardar.Enabled = false;
          this.btnImprime.Enabled = true;
          if (this._modifica)
            this.btnModificar.Enabled = true;
          if (!this._elimina)
            return;
          this.btnEliminar.Enabled = true;
        }
        else
        {
          int num1 = (int) MessageBox.Show("No Se Encuentra Traspaso Consultado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnBuscaFolio_Click(object sender, EventArgs e)
    {
      this.buscaTraspaso();
    }

    private void frmTraspasoInterno_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F4)
      {
        this.txtCodigo.Focus();
        int num = (int) new frmBuscaProductos("traspaso_interno", ref this.intance).ShowDialog();
        this.txtCantidad.Focus();
      }
      if (e.KeyCode == Keys.F6)
      {
        this.panelFolio.Visible = true;
        this.txtFolioBuscar.Focus();
      }
      if (e.KeyCode != Keys.F2 || !this._guarda || !this.valida())
        return;
      this.guardaTraspaso();
    }

    private void modificaTraspaso()
    {
      if (MessageBox.Show("Esta Seguro de Modificar el Traspaso", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        TraspasoVO tVO = new TraspasoVO();
        Traspaso traspaso = new Traspaso();
        DateTime dateTime=DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local = @dateTime;
        int year = this.dtpEmision.Value.Year;
        int month = this.dtpEmision.Value.Month;
        int day = this.dtpEmision.Value.Day;
        DateTime now = DateTime.Now;
        int hours = now.TimeOfDay.Hours;
        now = DateTime.Now;
        TimeSpan timeOfDay = now.TimeOfDay;
        int minutes = timeOfDay.Minutes;
        now = DateTime.Now;
        timeOfDay = now.TimeOfDay;
        int seconds = timeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local = new DateTime(year, month, day, hours, minutes, seconds);
        tVO.IdTraspaso = this.idTraspaso;
        tVO.FechaEmision = dateTime;
        tVO.BodegaOrigen = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
        tVO.BodegaDestino = Convert.ToInt32(this.cmbBodegaDestino.SelectedValue.ToString());
        tVO.Autoriza = this.txtAutorizado.Text.Trim().ToUpper();
        tVO.Observaciones = this.txtObservacion.Text.Trim().ToUpper();
        tVO.Neto = Convert.ToDecimal(this.txtNeto.Text.Trim());
        tVO.Iva = Convert.ToDecimal(this.txtIva.Text.Trim());
        tVO.Total = Convert.ToDecimal(this.txtTotalGeneral.Text.Trim());
        tVO.Caja = this._caja;
        tVO.Folio = Convert.ToInt32(this.txtNumeroDocumento.Text.Trim());
        for (int index = 0; index < this.lista.Count; ++index)
        {
          this.lista[index].IdTraspaso = this.idTraspaso;
          this.lista[index].FolioLinea = tVO.Folio;
          this.lista[index].FechaIngreso = tVO.FechaEmision;
          this.lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }
        try
        {
          traspaso.modificaTraspaso(tVO, this.lista);
          int num = (int) MessageBox.Show("Traspaso Modificado", "Modificado Ok", MessageBoxButtons.OK, MessageBoxIcon.Question);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("El Traspaso no Fue Modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      this.modificaTraspaso();
    }

    private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioBuscar);
      if ((int) e.KeyChar != 13 || this.txtFolioBuscar.Text.Trim().Length <= 0)
        return;
      this.buscaTraspaso();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Eliminar el Traspaso, Los Productos seran Retornados a Bodega ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        new Traspaso().eliminaTraspaso(this.idTraspaso);
        int num = (int) MessageBox.Show("El Traspaso Fue Elimnado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      else
      {
        int num1 = (int) MessageBox.Show("El Traspaso no Fue Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnLimpiaLineaDetalle_Click(object sender, EventArgs e)
    {
      this.iniciaDetalleTraspaso();
    }

    private void btnImprime_Click(object sender, EventArgs e)
    {
      this.imprimeDirecto();
    }

    private void imprimeDirecto()
    {
      DataTable dataTable = new Traspaso().muestraTraspasoFolio(Convert.ToInt32(this.txtNumeroDocumento.Text));
      try
      {
        ReportDocument rpt = new ReportDocument();
        rpt.Load("C:\\AptuSoft\\reportes\\TraspasoInterno.rpt");
        rpt.SetDataSource(dataTable);
        int num = (int) new frmVisualizadorReportes(rpt).ShowDialog();
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
    }

    private void imprimeTraspaso(int folio)
    {
      if (MessageBox.Show("Desea Imprimir El Comprobante?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        this.imprimeDirecto();
      else
        this.iniciaFormulario();
    }

    private void buscarProductosTeclaF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.txtCodigo.Focus();
      int num = (int) new frmBuscaProductos("traspaso_interno", ref this.intance).ShowDialog();
      this.txtCantidad.Focus();
    }

    private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.lista.Count <= 0)
        return;
      this.cambiaBodega();
    }

    private void cambiaBodega()
    {
      int num1 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      int num2 = Convert.ToInt32(this.cmbBodegaDestino.SelectedValue.ToString());
      for (int index = 0; index < this.lista.Count; ++index)
      {
        this.lista[index].BodegaOrigen = num1;
        this.lista[index].BodegaDestino = num2;
      }
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
    }

    private void cmbBodegaDestino_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.lista.Count <= 0)
        return;
      this.cambiaBodega();
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
      this.groupBox1 = new GroupBox();
      this.txtAutorizado = new TextBox();
      this.dtpEmision = new DateTimePicker();
      this.cmbBodegaDestino = new ComboBox();
      this.cmbBodega = new ComboBox();
      this.label12 = new Label();
      this.label1 = new Label();
      this.label33 = new Label();
      this.label28 = new Label();
      this.panelZonaDetalle = new Panel();
      this.btnLimpiaLineaDetalle = new Button();
      this.btnModificaLinea = new Button();
      this.txtCodigo = new TextBox();
      this.txtCantidad = new TextBox();
      this.dgvDatosVenta = new DataGridView();
      this.btnAgregar = new Button();
      this.txtDescripcion = new TextBox();
      this.btnLimpiaDetalle = new Button();
      this.txtTotalLinea = new TextBox();
      this.label20 = new Label();
      this.txtPrecio = new TextBox();
      this.label14 = new Label();
      this.label13 = new Label();
      this.label15 = new Label();
      this.label17 = new Label();
      this.lblFolio = new Label();
      this.txtNumeroDocumento = new TextBox();
      this.txtObservacion = new TextBox();
      this.label2 = new Label();
      this.gbZonaBotones = new GroupBox();
      this.lblFacturada = new Label();
      this.label3 = new Label();
      this.btnImprime = new Button();
      this.btnSalir = new Button();
      this.txtPorIva = new TextBox();
      this.btnLimpiar = new Button();
      this.btnGuardar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.txtTotalGeneral = new TextBox();
      this.txtIva = new TextBox();
      this.txtNeto = new TextBox();
      this.label26 = new Label();
      this.label25 = new Label();
      this.label24 = new Label();
      this.panelFolio = new Panel();
      this.btnCerrarPanelFolio = new Button();
      this.btnBuscaFolio = new Button();
      this.txtFolioBuscar = new TextBox();
      this.label32 = new Label();
      this.menuStrip1 = new MenuStrip();
      this.archivoToolStripMenuItem = new ToolStripMenuItem();
      this.buscarProductosTeclaF4ToolStripMenuItem = new ToolStripMenuItem();
      this.buscarTraspasoTeclaF6ToolStripMenuItem = new ToolStripMenuItem();
      this.guardarTraspasoTeclaF2ToolStripMenuItem = new ToolStripMenuItem();
      this.groupBox1.SuspendLayout();
      this.panelZonaDetalle.SuspendLayout();
      ((ISupportInitialize) this.dgvDatosVenta).BeginInit();
      this.gbZonaBotones.SuspendLayout();
      this.panelFolio.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.txtAutorizado);
      this.groupBox1.Controls.Add((Control) this.dtpEmision);
      this.groupBox1.Controls.Add((Control) this.cmbBodegaDestino);
      this.groupBox1.Controls.Add((Control) this.cmbBodega);
      this.groupBox1.Controls.Add((Control) this.label12);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.label33);
      this.groupBox1.Controls.Add((Control) this.label28);
      this.groupBox1.Location = new Point(12, 33);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(712, 65);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.txtAutorizado.BackColor = Color.White;
      this.txtAutorizado.Location = new Point(411, 31);
      this.txtAutorizado.Name = "txtAutorizado";
      this.txtAutorizado.Size = new Size(295, 20);
      this.txtAutorizado.TabIndex = 43;
      this.dtpEmision.Format = DateTimePickerFormat.Short;
      this.dtpEmision.Location = new Point(4, 31);
      this.dtpEmision.Name = "dtpEmision";
      this.dtpEmision.Size = new Size(104, 20);
      this.dtpEmision.TabIndex = 38;
      this.cmbBodegaDestino.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbBodegaDestino.FormattingEnabled = true;
      this.cmbBodegaDestino.Location = new Point(265, 31);
      this.cmbBodegaDestino.Name = "cmbBodegaDestino";
      this.cmbBodegaDestino.Size = new Size(139, 21);
      this.cmbBodegaDestino.TabIndex = 36;
      this.cmbBodegaDestino.SelectedIndexChanged += new EventHandler(this.cmbBodegaDestino_SelectedIndexChanged);
      this.cmbBodega.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbBodega.FormattingEnabled = true;
      this.cmbBodega.Location = new Point(120, 31);
      this.cmbBodega.Name = "cmbBodega";
      this.cmbBodega.Size = new Size(139, 21);
      this.cmbBodega.TabIndex = 17;
      this.cmbBodega.SelectedIndexChanged += new EventHandler(this.cmbBodega_SelectedIndexChanged);
      this.label12.BackColor = Color.FromArgb(64, 64, 64);
      this.label12.ForeColor = Color.White;
      this.label12.Location = new Point(411, 16);
      this.label12.Name = "label12";
      this.label12.Size = new Size(295, 23);
      this.label12.TabIndex = 42;
      this.label12.Text = "Autorizado Por";
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(102, 23);
      this.label1.TabIndex = 39;
      this.label1.Text = "Emision";
      this.label33.BackColor = Color.FromArgb(64, 64, 64);
      this.label33.ForeColor = Color.White;
      this.label33.Location = new Point(265, 16);
      this.label33.Name = "label33";
      this.label33.Size = new Size(139, 23);
      this.label33.TabIndex = 37;
      this.label33.Text = "Bodega Destino";
      this.label28.BackColor = Color.FromArgb(64, 64, 64);
      this.label28.ForeColor = Color.White;
      this.label28.Location = new Point(121, 16);
      this.label28.Name = "label28";
      this.label28.Size = new Size(138, 23);
      this.label28.TabIndex = 26;
      this.label28.Text = "Bodega Origen";
      this.panelZonaDetalle.BorderStyle = BorderStyle.Fixed3D;
      this.panelZonaDetalle.Controls.Add((Control) this.btnLimpiaLineaDetalle);
      this.panelZonaDetalle.Controls.Add((Control) this.btnModificaLinea);
      this.panelZonaDetalle.Controls.Add((Control) this.txtCodigo);
      this.panelZonaDetalle.Controls.Add((Control) this.txtCantidad);
      this.panelZonaDetalle.Controls.Add((Control) this.dgvDatosVenta);
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
      this.panelZonaDetalle.Location = new Point(12, 102);
      this.panelZonaDetalle.Name = "panelZonaDetalle";
      this.panelZonaDetalle.Size = new Size(888, 317);
      this.panelZonaDetalle.TabIndex = 28;
      this.btnLimpiaLineaDetalle.Location = new Point(714, 3);
      this.btnLimpiaLineaDetalle.Name = "btnLimpiaLineaDetalle";
      this.btnLimpiaLineaDetalle.Size = new Size(20, 34);
      this.btnLimpiaLineaDetalle.TabIndex = 33;
      this.btnLimpiaLineaDetalle.Text = "..";
      this.btnLimpiaLineaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaLineaDetalle.Click += new EventHandler(this.btnLimpiaLineaDetalle_Click);
      this.btnModificaLinea.Location = new Point(764, 33);
      this.btnModificaLinea.Name = "btnModificaLinea";
      this.btnModificaLinea.Size = new Size(114, 23);
      this.btnModificaLinea.TabIndex = 33;
      this.btnModificaLinea.Text = "Modificar";
      this.btnModificaLinea.UseVisualStyleBackColor = true;
      this.btnModificaLinea.Click += new EventHandler(this.btnModificaLinea_Click);
      this.txtCodigo.BorderStyle = BorderStyle.FixedSingle;
      this.txtCodigo.Location = new Point(2, 18);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new Size(101, 20);
      this.txtCodigo.TabIndex = 9;
      this.txtCodigo.KeyPress += new KeyPressEventHandler(this.txtCodigo_KeyPress);
      this.txtCantidad.BorderStyle = BorderStyle.FixedSingle;
      this.txtCantidad.Location = new Point(559, 18);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new Size(57, 20);
      this.txtCantidad.TabIndex = 12;
      this.txtCantidad.TextAlign = HorizontalAlignment.Right;
      this.txtCantidad.TextChanged += new EventHandler(this.txtCantidad_TextChanged);
      this.txtCantidad.KeyPress += new KeyPressEventHandler(this.txtCantidad_KeyPress);
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
      this.dgvDatosVenta.Location = new Point(3, 62);
      this.dgvDatosVenta.MultiSelect = false;
      this.dgvDatosVenta.Name = "dgvDatosVenta";
      this.dgvDatosVenta.ReadOnly = true;
      this.dgvDatosVenta.RowHeadersVisible = false;
      this.dgvDatosVenta.RowHeadersWidth = 50;
      this.dgvDatosVenta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDatosVenta.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatosVenta.Size = new Size(877, 248);
      this.dgvDatosVenta.TabIndex = 3;
      this.dgvDatosVenta.TabStop = false;
      this.dgvDatosVenta.CellClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
      this.dgvDatosVenta.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
      this.btnAgregar.Location = new Point(764, 4);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(55, 23);
      this.btnAgregar.TabIndex = 16;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
      this.txtDescripcion.Location = new Point(109, 18);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(368, 20);
      this.txtDescripcion.TabIndex = 10;
      this.btnLimpiaDetalle.Location = new Point(823, 4);
      this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
      this.btnLimpiaDetalle.Size = new Size(55, 23);
      this.btnLimpiaDetalle.TabIndex = 17;
      this.btnLimpiaDetalle.Text = "Limpiar";
      this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
      this.btnLimpiaDetalle.Click += new EventHandler(this.btnLimpiaDetalle_Click);
      this.txtTotalLinea.BackColor = Color.White;
      this.txtTotalLinea.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalLinea.Enabled = false;
      this.txtTotalLinea.Location = new Point(618, 18);
      this.txtTotalLinea.Name = "txtTotalLinea";
      this.txtTotalLinea.Size = new Size(92, 20);
      this.txtTotalLinea.TabIndex = 15;
      this.txtTotalLinea.TabStop = false;
      this.txtTotalLinea.TextAlign = HorizontalAlignment.Right;
      this.label20.BackColor = Color.FromArgb(64, 64, 64);
      this.label20.ForeColor = Color.White;
      this.label20.Location = new Point(618, 4);
      this.label20.Name = "label20";
      this.label20.Size = new Size(92, 23);
      this.label20.TabIndex = 7;
      this.label20.Text = "Total";
      this.label20.TextAlign = ContentAlignment.TopCenter;
      this.txtPrecio.BorderStyle = BorderStyle.FixedSingle;
      this.txtPrecio.Location = new Point(481, 18);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.Size = new Size(76, 20);
      this.txtPrecio.TabIndex = 11;
      this.txtPrecio.TextAlign = HorizontalAlignment.Right;
      this.txtPrecio.TextChanged += new EventHandler(this.txtPrecio_TextChanged);
      this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress);
      this.label14.BackColor = Color.FromArgb(64, 64, 64);
      this.label14.ForeColor = Color.White;
      this.label14.Location = new Point(109, 4);
      this.label14.Name = "label14";
      this.label14.Size = new Size(368, 23);
      this.label14.TabIndex = 1;
      this.label14.Text = "Descripcion";
      this.label14.TextAlign = ContentAlignment.TopCenter;
      this.label13.BackColor = Color.FromArgb(64, 64, 64);
      this.label13.ForeColor = Color.White;
      this.label13.Location = new Point(2, 4);
      this.label13.Name = "label13";
      this.label13.Size = new Size(101, 23);
      this.label13.TabIndex = 0;
      this.label13.Text = "Codigo";
      this.label13.TextAlign = ContentAlignment.TopCenter;
      this.label15.BackColor = Color.FromArgb(64, 64, 64);
      this.label15.ForeColor = Color.White;
      this.label15.Location = new Point(481, 4);
      this.label15.Name = "label15";
      this.label15.Size = new Size(76, 23);
      this.label15.TabIndex = 2;
      this.label15.Text = "Precio";
      this.label15.TextAlign = ContentAlignment.TopCenter;
      this.label17.BackColor = Color.FromArgb(64, 64, 64);
      this.label17.ForeColor = Color.White;
      this.label17.Location = new Point(559, 4);
      this.label17.Name = "label17";
      this.label17.Size = new Size(57, 23);
      this.label17.TabIndex = 4;
      this.label17.Text = "Cantidad";
      this.label17.TextAlign = ContentAlignment.TopCenter;
      this.lblFolio.AutoSize = true;
      this.lblFolio.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFolio.Location = new Point(805, 47);
      this.lblFolio.Name = "lblFolio";
      this.lblFolio.Size = new Size(95, 16);
      this.lblFolio.TabIndex = 40;
      this.lblFolio.Text = "Traspaso N°";
      this.txtNumeroDocumento.BackColor = Color.White;
      this.txtNumeroDocumento.Location = new Point(789, 67);
      this.txtNumeroDocumento.Name = "txtNumeroDocumento";
      this.txtNumeroDocumento.Size = new Size(111, 20);
      this.txtNumeroDocumento.TabIndex = 41;
      this.txtNumeroDocumento.TextAlign = HorizontalAlignment.Right;
      this.txtNumeroDocumento.KeyPress += new KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
      this.txtObservacion.Location = new Point(449, 40);
      this.txtObservacion.Multiline = true;
      this.txtObservacion.Name = "txtObservacion";
      this.txtObservacion.Size = new Size(261, 96);
      this.txtObservacion.TabIndex = 42;
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(449, 22);
      this.label2.Name = "label2";
      this.label2.Size = new Size(261, 23);
      this.label2.TabIndex = 44;
      this.label2.Text = "Observaciones";
      this.gbZonaBotones.Controls.Add((Control) this.txtObservacion);
      this.gbZonaBotones.Controls.Add((Control) this.lblFacturada);
      this.gbZonaBotones.Controls.Add((Control) this.label2);
      this.gbZonaBotones.Controls.Add((Control) this.label3);
      this.gbZonaBotones.Controls.Add((Control) this.btnImprime);
      this.gbZonaBotones.Controls.Add((Control) this.btnSalir);
      this.gbZonaBotones.Controls.Add((Control) this.txtPorIva);
      this.gbZonaBotones.Controls.Add((Control) this.btnLimpiar);
      this.gbZonaBotones.Controls.Add((Control) this.btnGuardar);
      this.gbZonaBotones.Controls.Add((Control) this.btnEliminar);
      this.gbZonaBotones.Controls.Add((Control) this.btnModificar);
      this.gbZonaBotones.Controls.Add((Control) this.txtTotalGeneral);
      this.gbZonaBotones.Controls.Add((Control) this.txtIva);
      this.gbZonaBotones.Controls.Add((Control) this.txtNeto);
      this.gbZonaBotones.Controls.Add((Control) this.label26);
      this.gbZonaBotones.Controls.Add((Control) this.label25);
      this.gbZonaBotones.Controls.Add((Control) this.label24);
      this.gbZonaBotones.Location = new Point(12, 419);
      this.gbZonaBotones.Name = "gbZonaBotones";
      this.gbZonaBotones.Size = new Size(888, 146);
      this.gbZonaBotones.TabIndex = 45;
      this.gbZonaBotones.TabStop = false;
      this.lblFacturada.AutoSize = true;
      this.lblFacturada.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblFacturada.ForeColor = Color.Red;
      this.lblFacturada.Location = new Point(6, 52);
      this.lblFacturada.Name = "lblFacturada";
      this.lblFacturada.Size = new Size(111, 25);
      this.lblFacturada.TabIndex = 39;
      this.lblFacturada.Text = "facturada";
      this.lblFacturada.Visible = false;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Red;
      this.label3.Location = new Point(6, 19);
      this.label3.Name = "label3";
      this.label3.Size = new Size(275, 29);
      this.label3.TabIndex = 28;
      this.label3.Text = "TRASPASO INTERNO";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.btnImprime.Location = new Point(7, 113);
      this.btnImprime.Name = "btnImprime";
      this.btnImprime.Size = new Size(88, 23);
      this.btnImprime.TabIndex = 26;
      this.btnImprime.Text = "RE-IMPRIMIR";
      this.btnImprime.UseVisualStyleBackColor = true;
      this.btnImprime.Click += new EventHandler(this.btnImprime_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(187, 113);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(88, 23);
      this.btnSalir.TabIndex = 23;
      this.btnSalir.Text = "SALIR";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.txtPorIva.BackColor = Color.White;
      this.txtPorIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtPorIva.Enabled = false;
      this.txtPorIva.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPorIva.Location = new Point(778, 45);
      this.txtPorIva.Name = "txtPorIva";
      this.txtPorIva.Size = new Size(24, 21);
      this.txtPorIva.TabIndex = 11;
      this.txtPorIva.TabStop = false;
      this.txtPorIva.TextAlign = HorizontalAlignment.Right;
      this.btnLimpiar.Location = new Point(97, 113);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(88, 23);
      this.btnLimpiar.TabIndex = 22;
      this.btnLimpiar.Text = "LIMPIAR";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnGuardar.Location = new Point(7, 88);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(88, 23);
      this.btnGuardar.TabIndex = 19;
      this.btnGuardar.Text = "GUARDA [F2]";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnEliminar.Location = new Point(187, 88);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(88, 23);
      this.btnEliminar.TabIndex = 21;
      this.btnEliminar.Text = "ELIMINAR";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnModificar.Location = new Point(97, 88);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(88, 23);
      this.btnModificar.TabIndex = 20;
      this.btnModificar.Text = "MODIFICAR";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.txtTotalGeneral.BackColor = Color.White;
      this.txtTotalGeneral.BorderStyle = BorderStyle.FixedSingle;
      this.txtTotalGeneral.Enabled = false;
      this.txtTotalGeneral.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTotalGeneral.Location = new Point(778, 67);
      this.txtTotalGeneral.Name = "txtTotalGeneral";
      this.txtTotalGeneral.Size = new Size(103, 21);
      this.txtTotalGeneral.TabIndex = 9;
      this.txtTotalGeneral.TabStop = false;
      this.txtTotalGeneral.TextAlign = HorizontalAlignment.Right;
      this.txtIva.BackColor = Color.White;
      this.txtIva.BorderStyle = BorderStyle.FixedSingle;
      this.txtIva.Enabled = false;
      this.txtIva.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtIva.Location = new Point(804, 45);
      this.txtIva.Name = "txtIva";
      this.txtIva.Size = new Size(77, 21);
      this.txtIva.TabIndex = 8;
      this.txtIva.TabStop = false;
      this.txtIva.TextAlign = HorizontalAlignment.Right;
      this.txtNeto.BackColor = Color.White;
      this.txtNeto.BorderStyle = BorderStyle.FixedSingle;
      this.txtNeto.Enabled = false;
      this.txtNeto.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNeto.Location = new Point(778, 23);
      this.txtNeto.Name = "txtNeto";
      this.txtNeto.Size = new Size(103, 21);
      this.txtNeto.TabIndex = 7;
      this.txtNeto.TabStop = false;
      this.txtNeto.TextAlign = HorizontalAlignment.Right;
      this.label26.AutoSize = true;
      this.label26.BackColor = SystemColors.Control;
      this.label26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.Black;
      this.label26.Location = new Point(727, 71);
      this.label26.Name = "label26";
      this.label26.Size = new Size(47, 13);
      this.label26.TabIndex = 4;
      this.label26.Text = "TOTAL";
      this.label25.AutoSize = true;
      this.label25.BackColor = SystemColors.Control;
      this.label25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label25.ForeColor = Color.Black;
      this.label25.Location = new Point(739, 49);
      this.label25.Name = "label25";
      this.label25.Size = new Size(35, 13);
      this.label25.TabIndex = 3;
      this.label25.Text = "I.V.A";
      this.label24.AutoSize = true;
      this.label24.BackColor = SystemColors.Control;
      this.label24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = Color.Black;
      this.label24.Location = new Point(733, 27);
      this.label24.Name = "label24";
      this.label24.Size = new Size(41, 13);
      this.label24.TabIndex = 2;
      this.label24.Text = "NETO";
      this.panelFolio.BorderStyle = BorderStyle.FixedSingle;
      this.panelFolio.Controls.Add((Control) this.btnCerrarPanelFolio);
      this.panelFolio.Controls.Add((Control) this.btnBuscaFolio);
      this.panelFolio.Controls.Add((Control) this.txtFolioBuscar);
      this.panelFolio.Controls.Add((Control) this.label32);
      this.panelFolio.Location = new Point(728, 90);
      this.panelFolio.Name = "panelFolio";
      this.panelFolio.Size = new Size(230, 92);
      this.panelFolio.TabIndex = 46;
      this.btnCerrarPanelFolio.FlatStyle = FlatStyle.Flat;
      this.btnCerrarPanelFolio.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnCerrarPanelFolio.ForeColor = Color.Red;
      this.btnCerrarPanelFolio.Location = new Point(185, 1);
      this.btnCerrarPanelFolio.Name = "btnCerrarPanelFolio";
      this.btnCerrarPanelFolio.Size = new Size(23, 24);
      this.btnCerrarPanelFolio.TabIndex = 24;
      this.btnCerrarPanelFolio.Text = "X";
      this.btnCerrarPanelFolio.UseVisualStyleBackColor = true;
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
      this.menuStrip1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.archivoToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1008, 24);
      this.menuStrip1.TabIndex = 47;
      this.menuStrip1.Text = "menuStrip1";
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.buscarProductosTeclaF4ToolStripMenuItem,
        (ToolStripItem) this.buscarTraspasoTeclaF6ToolStripMenuItem,
        (ToolStripItem) this.guardarTraspasoTeclaF2ToolStripMenuItem
      });
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new Size(60, 20);
      this.archivoToolStripMenuItem.Text = "Archivo";
      this.buscarProductosTeclaF4ToolStripMenuItem.Name = "buscarProductosTeclaF4ToolStripMenuItem";
      this.buscarProductosTeclaF4ToolStripMenuItem.Size = new Size(222, 22);
      this.buscarProductosTeclaF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
      this.buscarProductosTeclaF4ToolStripMenuItem.Click += new EventHandler(this.buscarProductosTeclaF4ToolStripMenuItem_Click);
      this.buscarTraspasoTeclaF6ToolStripMenuItem.Name = "buscarTraspasoTeclaF6ToolStripMenuItem";
      this.buscarTraspasoTeclaF6ToolStripMenuItem.Size = new Size(222, 22);
      this.buscarTraspasoTeclaF6ToolStripMenuItem.Text = "Buscar Traspaso - tecla [F6]";
      this.guardarTraspasoTeclaF2ToolStripMenuItem.Name = "guardarTraspasoTeclaF2ToolStripMenuItem";
      this.guardarTraspasoTeclaF2ToolStripMenuItem.Size = new Size(222, 22);
      this.guardarTraspasoTeclaF2ToolStripMenuItem.Text = "Guardar Traspaso - tecla[F2]";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1008, 600);
      this.Controls.Add((Control) this.panelFolio);
      this.Controls.Add((Control) this.gbZonaBotones);
      this.Controls.Add((Control) this.panelZonaDetalle);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.txtNumeroDocumento);
      this.Controls.Add((Control) this.lblFolio);
      this.Controls.Add((Control) this.menuStrip1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmTraspasoInterno";
      this.ShowIcon = false;
      this.Text = "Traspaso Interno";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmTraspasoInterno_FormClosing);
      this.KeyDown += new KeyEventHandler(this.frmTraspasoInterno_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.panelZonaDetalle.ResumeLayout(false);
      this.panelZonaDetalle.PerformLayout();
      ((ISupportInitialize) this.dgvDatosVenta).EndInit();
      this.gbZonaBotones.ResumeLayout(false);
      this.gbZonaBotones.PerformLayout();
      this.panelFolio.ResumeLayout(false);
      this.panelFolio.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
