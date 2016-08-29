 
// Type: Aptusoft.Lotes.frmLoteCompraVenta
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica.Formularios;
using Aptusoft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft.Lotes
{
  public class frmLoteCompraVenta : Form
  {
    private int _bodega = 0;
    private Decimal _cantidadDisponible = new Decimal(0);
    private List<LoteVO> _listaLote = new List<LoteVO>();
    private frmIngresoCompra _IngresoCompra = (frmIngresoCompra) null;
    private frmBoleta _BoletaPapel = (frmBoleta) null;
    private frmFactura _FacturaPapel = (frmFactura) null;
    private frmFacturaElectronica _FacturaElectronica = (frmFacturaElectronica) null;
    private frmFacturaElectronicaFrigo frmFacElecFrigo = (frmFacturaElectronicaFrigo)null;
    private frmNotaVenta _NotaVenta = (frmNotaVenta) null;
    private frmNotaCredito _NotaCredito = (frmNotaCredito) null;
    private frmGuiaDespacho _GuiaDespacho = (frmGuiaDespacho) null;
    private frmTicket _Ticket = (frmTicket) null;
    private frmGuiaDespachoElectronica _GuiaElectronica = (frmGuiaDespachoElectronica) null;
    private frmNotaCreditoElectronica _NotaCreditoElectronica = (frmNotaCreditoElectronica) null;
    private frmBoletaElectronica _BoletaElectronica = (frmBoletaElectronica) null;
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtCodigo;
    private TextBox txtDescripcion;
    private TextBox txtLote;
    private TextBox txtCantidadLote;
    private DataGridView dgvDatos;
    private Button btnAgregar;
    private Button btnSalir;
    private TextBox txtCantidadTotal;
    private Label label5;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private ToolTip toolTip1;
    private Panel panel1;
    private DataGridView dgvLotesDisponibles;
    private DataGridViewTextBoxColumn CodigoDisponible;
    private DataGridViewTextBoxColumn DescripcionDisponible;
    private DataGridViewTextBoxColumn LoteDisponible;
    private DataGridViewTextBoxColumn CantidadDisponible;
    private DataGridViewButtonColumn Seleccionar;
    private Label label6;
    private Label lblBodega;
    private TextBox txtBodega;
    private DataGridViewTextBoxColumn Codigo;
    private DataGridViewTextBoxColumn Descripcion;
    private DataGridViewTextBoxColumn Lote;
    private DataGridViewTextBoxColumn Cantidad;
    private DataGridViewTextBoxColumn Bodega;
    private DataGridViewTextBoxColumn BodegaNombre;
    private DataGridViewButtonColumn Eliminar;
    private DataGridViewTextBoxColumn IdDetalleLote;
    private TextBox txtCantidadDisponible;
    private Label label7;
    private Button btnLimpiar;

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmIngresoCompra com)
    {
      this.InitializeComponent();
      this._IngresoCompra = com;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmBoleta bo)
    {
      this.InitializeComponent();
      this._BoletaPapel = bo;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmFactura fa)
    {
      this.InitializeComponent();
      this._FacturaPapel = fa;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmFacturaElectronica fe)
    {
      this.InitializeComponent();
      this._FacturaElectronica = fe;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmFacturaElectronicaFrigo fe)
    {
        this.InitializeComponent();
        this.frmFacElecFrigo = fe;
        this.dgvDatos.AutoGenerateColumns = false;
        this.dgvLotesDisponibles.AutoGenerateColumns = false;
        this.txtCodigo.Text = cod;
        this.txtDescripcion.Text = descrip;
        this._bodega = bodega;
        this.txtBodega.Text = bodegaNombre;
        this.txtCantidadTotal.Text = cant.ToString();
        this._listaLote = lista;
        this.CargaLista();
        this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmNotaVenta nv)
    {
      this.InitializeComponent();
      this._NotaVenta = nv;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmNotaCredito nc)
    {
      this.InitializeComponent();
      this._NotaCredito = nc;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmGuiaDespacho gd)
    {
      this.InitializeComponent();
      this._GuiaDespacho = gd;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmTicket tk)
    {
      this.InitializeComponent();
      this._Ticket = tk;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmGuiaDespachoElectronica ge)
    {
      this.InitializeComponent();
      this._GuiaElectronica = ge;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmNotaCreditoElectronica nce)
    {
      this.InitializeComponent();
      this._NotaCreditoElectronica = nce;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    public frmLoteCompraVenta(string cod, string descrip, Decimal cant, int bodega, string bodegaNombre, List<LoteVO> lista, ref frmBoletaElectronica bo)
    {
      this.InitializeComponent();
      this._BoletaElectronica = bo;
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLotesDisponibles.AutoGenerateColumns = false;
      this.txtCodigo.Text = cod;
      this.txtDescripcion.Text = descrip;
      this._bodega = bodega;
      this.txtBodega.Text = bodegaNombre;
      this.txtCantidadTotal.Text = cant.ToString();
      this._listaLote = lista;
      this.CargaLista();
      this.txtLote.Focus();
    }

    private void IniciaFormulario()
    {
      this.txtCantidadLote.Enabled = true;
      this.btnAgregar.Enabled = true;
      this.txtLote.Clear();
      this.txtCantidadLote.Clear();
      this.txtLote.Focus();
      this._cantidadDisponible = new Decimal(0);
      this.txtCantidadDisponible.Clear();
      this.CargaLista();
    }

    private void CargaLista()
    {
      List<LoteVO> list = new List<LoteVO>();
      if (this._listaLote.Count > 0)
      {
        foreach (LoteVO loteVo in this._listaLote)
        {
          if (loteVo.CodigoProducto.Equals(this.txtCodigo.Text))
          {
            loteVo.Descripcion = this.txtDescripcion.Text;
            loteVo.BodegaNombre = this.txtBodega.Text;
            list.Add(loteVo);
          }
        }
        this.dgvDatos.DataSource = (object) null;
        this.dgvDatos.DataSource = (object) list;
      }
      else
        this.dgvDatos.DataSource = (object) null;
      this.txtLote.Focus();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      this.GuardaLote();
    }

    private void GuardaLote()
    {
      if (!this.Valida())
        return;
      LoteVO loteVo1 = new LoteVO();
      loteVo1.Lote = this.txtLote.Text;
      loteVo1.CodigoProducto = this.txtCodigo.Text;
      loteVo1.Descripcion = this.txtDescripcion.Text;
      loteVo1.Cantidad = Convert.ToDecimal(this.txtCantidadLote.Text);
      loteVo1.Bodega = this._bodega;
      loteVo1.BodegaNombre = this.txtBodega.Text;
      bool flag = false;
      foreach (LoteVO loteVo2 in this._listaLote)
      {
        if (loteVo2.Lote == loteVo1.Lote && loteVo2.CodigoProducto == loteVo1.CodigoProducto && loteVo2.Bodega == loteVo1.Bodega)
        {
          loteVo2.Cantidad += loteVo1.Cantidad;
          flag = true;
          break;
        }
      }
      if (!flag)
        this._listaLote.Add(loteVo1);
      this.IniciaFormulario();
    }

    private bool Valida()
    {
      if (this.txtLote.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Un Lote", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtLote.Focus();
        return false;
      }
      if (this.txtCantidadLote.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Una Cantidad de Lote", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCantidadLote.Focus();
        return false;
      }
      return this.ValidaCantidad(Convert.ToDecimal(this.txtCantidadLote.Text));
    }

    private bool ValidaCantidad(Decimal cant)
    {
      Decimal num1 = Convert.ToDecimal(this.txtCantidadTotal.Text);
      Decimal num2 = cant;
      foreach (LoteVO loteVo in this._listaLote)
      {
        if (loteVo.CodigoProducto.Equals(this.txtCodigo.Text))
          num2 += loteVo.Cantidad;
      }
      if (num1 >= num2)
        return true;
      int num3 = (int) MessageBox.Show("La Cantidad de Lote no debe superar la Cantidad Total: " + this.txtCantidadTotal.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtCantidadLote.Clear();
      this.txtCantidadLote.Focus();
      return false;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmLoteCompraVenta_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this._IngresoCompra != null)
        this._IngresoCompra._listaLote = this._listaLote;
      if (this._BoletaPapel != null)
        this._BoletaPapel._listaLote = this._listaLote;
      if (this._FacturaPapel != null)
        this._FacturaPapel._listaLote = this._listaLote;
      if (this._FacturaElectronica != null)
        this._FacturaElectronica._listaLote = this._listaLote;
      if (this._NotaVenta != null)
        this._NotaVenta._listaLote = this._listaLote;
      if (this._NotaCredito != null)
        this._NotaCredito._listaLote = this._listaLote;
      if (this._GuiaDespacho != null)
        this._GuiaDespacho._listaLote = this._listaLote;
      if (this._Ticket != null)
        this._Ticket._listaLote = this._listaLote;
      if (this._GuiaElectronica != null)
        this._GuiaElectronica._listaLote = this._listaLote;
      if (this._NotaCreditoElectronica != null)
        this._NotaCreditoElectronica._listaLote = this._listaLote;
      if (this._BoletaElectronica == null)
        return;
      this._BoletaElectronica._listaLote = this._listaLote;
    }

    private void txtLote_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtCantidadLote.Focus();
    }

    private void BuscaLote()
    {
      this._cantidadDisponible = new Decimal(0);
      if (this.txtLote.Text.Trim().Length > 0)
      {
        this._cantidadDisponible = new Aptusoft.Lotes.Lote().BuscaLoteDisponible(this.txtCodigo.Text, this.txtLote.Text, this._bodega);
      }
      else
      {
        int num1 = (int) MessageBox.Show("Debe Ingresar un Lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.txtCantidadDisponible.Text = this._cantidadDisponible.ToString("N0");
      if (this._cantidadDisponible == new Decimal(0))
      {
        if (this._BoletaPapel != null || this._FacturaPapel != null || (this._FacturaElectronica != null || this._NotaVenta != null) || (this._GuiaDespacho != null || this._GuiaElectronica != null || this._Ticket != null) || this._BoletaElectronica != null)
        {
          this.txtCantidadLote.Enabled = false;
          this.btnAgregar.Enabled = false;
        }
        this.txtCantidadDisponible.Clear();
        int num2 = (int) MessageBox.Show("Lote NO Disponible", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        this.txtCantidadLote.Enabled = true;
        this.btnAgregar.Enabled = true;
      }
    }

    private void txtCantidadLote_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.GuardaLote();
    }

    private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvDatos.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("Esta seguro de Eliminar esta Fila", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      string str = this.dgvDatos.SelectedRows[0].Cells["Lote"].Value.ToString();
      for (int index = 0; index < this._listaLote.Count; ++index)
      {
        if (this._listaLote[index].Lote == str)
        {
          this._listaLote.RemoveAt(index);
          --index;
        }
      }
      this.CargaLista();
    }

    private void txtLote_Leave(object sender, EventArgs e)
    {
      if (this.txtCantidadDisponible.Text.Trim().Length != 0 || this.txtLote.Text.Trim().Length <= 0)
        return;
      this.BuscaLote();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.IniciaFormulario();
    }

    private void txtLote_TextChanged(object sender, EventArgs e)
    {
    }

    private void txtLote_Enter(object sender, EventArgs e)
    {
      this.txtLote.Clear();
      this.txtCantidadLote.Clear();
      this.txtCantidadDisponible.Clear();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.txtCodigo = new TextBox();
      this.txtDescripcion = new TextBox();
      this.txtLote = new TextBox();
      this.txtCantidadLote = new TextBox();
      this.dgvDatos = new DataGridView();
      this.Codigo = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.Lote = new DataGridViewTextBoxColumn();
      this.Cantidad = new DataGridViewTextBoxColumn();
      this.Bodega = new DataGridViewTextBoxColumn();
      this.BodegaNombre = new DataGridViewTextBoxColumn();
      this.Eliminar = new DataGridViewButtonColumn();
      this.IdDetalleLote = new DataGridViewTextBoxColumn();
      this.btnSalir = new Button();
      this.txtCantidadTotal = new TextBox();
      this.label5 = new Label();
      this.groupBox1 = new GroupBox();
      this.lblBodega = new Label();
      this.txtBodega = new TextBox();
      this.groupBox2 = new GroupBox();
      this.btnAgregar = new Button();
      this.toolTip1 = new ToolTip(this.components);
      this.panel1 = new Panel();
      this.dgvLotesDisponibles = new DataGridView();
      this.CodigoDisponible = new DataGridViewTextBoxColumn();
      this.DescripcionDisponible = new DataGridViewTextBoxColumn();
      this.LoteDisponible = new DataGridViewTextBoxColumn();
      this.CantidadDisponible = new DataGridViewTextBoxColumn();
      this.Seleccionar = new DataGridViewButtonColumn();
      this.label6 = new Label();
      this.txtCantidadDisponible = new TextBox();
      this.label7 = new Label();
      this.btnLimpiar = new Button();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dgvLotesDisponibles).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(9, 14);
      this.label1.Name = "label1";
      this.label1.Size = new Size(40, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Codigo";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(95, 14);
      this.label2.Name = "label2";
      this.label2.Size = new Size(63, 13);
      this.label2.TabIndex = 14;
      this.label2.Text = "Descripcion";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(8, 10);
      this.label3.Name = "label3";
      this.label3.Size = new Size(28, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Lote";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(268, 10);
      this.label4.Name = "label4";
      this.label4.Size = new Size(73, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Cantidad Lote";
      this.txtCodigo.BackColor = Color.White;
      this.txtCodigo.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCodigo.ForeColor = Color.Black;
      this.txtCodigo.Location = new Point(6, 32);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new Size(86, 21);
      this.txtCodigo.TabIndex = 4;
      this.txtDescripcion.BackColor = Color.White;
      this.txtDescripcion.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtDescripcion.ForeColor = Color.Black;
      this.txtDescripcion.Location = new Point(98, 32);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(346, 21);
      this.txtDescripcion.TabIndex = 5;
      this.txtLote.CharacterCasing = CharacterCasing.Upper;
      this.txtLote.Location = new Point(8, 28);
      this.txtLote.Name = "txtLote";
      this.txtLote.Size = new Size(151, 20);
      this.txtLote.TabIndex = 1;
      this.txtLote.TextChanged += new EventHandler(this.txtLote_TextChanged);
      this.txtLote.Enter += new EventHandler(this.txtLote_Enter);
      this.txtLote.KeyDown += new KeyEventHandler(this.txtLote_KeyDown);
      this.txtLote.Leave += new EventHandler(this.txtLote_Leave);
      this.txtCantidadLote.Location = new Point(269, 28);
      this.txtCantidadLote.Name = "txtCantidadLote";
      this.txtCantidadLote.Size = new Size(72, 20);
      this.txtCantidadLote.TabIndex = 7;
      this.txtCantidadLote.TextAlign = HorizontalAlignment.Center;
      this.txtCantidadLote.KeyDown += new KeyEventHandler(this.txtCantidadLote_KeyDown);
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      this.dgvDatos.AllowUserToResizeColumns = false;
      this.dgvDatos.AllowUserToResizeRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvDatos.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvDatos.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.Codigo, (DataGridViewColumn) this.Descripcion, (DataGridViewColumn) this.Lote, (DataGridViewColumn) this.Cantidad, (DataGridViewColumn) this.Bodega, (DataGridViewColumn) this.BodegaNombre, (DataGridViewColumn) this.Eliminar, (DataGridViewColumn) this.IdDetalleLote);
      this.dgvDatos.Location = new Point(9, (int) sbyte.MaxValue);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.ReadOnly = true;
      this.dgvDatos.RowHeadersVisible = false;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(691, 163);
      this.dgvDatos.TabIndex = 8;
      this.dgvDatos.CellClick += new DataGridViewCellEventHandler(this.dgvDatos_CellClick);
      this.Codigo.DataPropertyName = "CodigoProducto";
      this.Codigo.HeaderText = "Codigo";
      this.Codigo.Name = "Codigo";
      this.Codigo.ReadOnly = true;
      this.Codigo.Width = 80;
      this.Descripcion.DataPropertyName = "Descripcion";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      this.Descripcion.Width = 240;
      this.Lote.DataPropertyName = "Lote";
      this.Lote.HeaderText = "Lote";
      this.Lote.Name = "Lote";
      this.Lote.ReadOnly = true;
      this.Cantidad.DataPropertyName = "Cantidad";
      this.Cantidad.HeaderText = "Cantidad";
      this.Cantidad.Name = "Cantidad";
      this.Cantidad.ReadOnly = true;
      this.Cantidad.Width = 70;
      this.Bodega.DataPropertyName = "Bodega";
      this.Bodega.HeaderText = "BodegaCodigo";
      this.Bodega.Name = "Bodega";
      this.Bodega.ReadOnly = true;
      this.Bodega.Visible = false;
      this.BodegaNombre.DataPropertyName = "BodegaNombre";
      this.BodegaNombre.HeaderText = "Bodega";
      this.BodegaNombre.Name = "BodegaNombre";
      this.BodegaNombre.ReadOnly = true;
      this.BodegaNombre.Width = 150;
      this.Eliminar.HeaderText = "";
      this.Eliminar.Name = "Eliminar";
      this.Eliminar.ReadOnly = true;
      this.Eliminar.Text = "X";
      this.Eliminar.ToolTipText = "Elimina Fila";
      this.Eliminar.UseColumnTextForButtonValue = true;
      this.Eliminar.Width = 30;
      this.IdDetalleLote.DataPropertyName = "IdDetalleLote";
      this.IdDetalleLote.HeaderText = "IdDetalleLote";
      this.IdDetalleLote.Name = "IdDetalleLote";
      this.IdDetalleLote.ReadOnly = true;
      this.IdDetalleLote.Visible = false;
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(625, 296);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 21);
      this.btnSalir.TabIndex = 10;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.txtCantidadTotal.BackColor = Color.White;
      this.txtCantidadTotal.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCantidadTotal.ForeColor = Color.Black;
      this.txtCantidadTotal.Location = new Point(614, 32);
      this.txtCantidadTotal.Name = "txtCantidadTotal";
      this.txtCantidadTotal.Size = new Size(66, 21);
      this.txtCantidadTotal.TabIndex = 11;
      this.txtCantidadTotal.TextAlign = HorizontalAlignment.Right;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(611, 16);
      this.label5.Name = "label5";
      this.label5.Size = new Size(76, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Cantidad Total";
      this.groupBox1.Controls.Add((Control) this.lblBodega);
      this.groupBox1.Controls.Add((Control) this.txtBodega);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.txtCantidadTotal);
      this.groupBox1.Controls.Add((Control) this.txtCodigo);
      this.groupBox1.Controls.Add((Control) this.txtDescripcion);
      this.groupBox1.Enabled = false;
      this.groupBox1.Location = new Point(5, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(695, 61);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.lblBodega.AutoSize = true;
      this.lblBodega.Location = new Point(450, 12);
      this.lblBodega.Name = "lblBodega";
      this.lblBodega.Size = new Size(44, 13);
      this.lblBodega.TabIndex = 13;
      this.lblBodega.Text = "Bodega";
      this.txtBodega.BackColor = Color.White;
      this.txtBodega.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtBodega.ForeColor = Color.Black;
      this.txtBodega.Location = new Point(450, 32);
      this.txtBodega.Name = "txtBodega";
      this.txtBodega.Size = new Size(159, 21);
      this.txtBodega.TabIndex = 14;
      this.groupBox2.Controls.Add((Control) this.btnLimpiar);
      this.groupBox2.Controls.Add((Control) this.txtCantidadDisponible);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.txtLote);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.txtCantidadLote);
      this.groupBox2.Controls.Add((Control) this.btnAgregar);
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Location = new Point(5, 63);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(695, 58);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.btnAgregar.Image = (Image) Resources.add_icone_9220_16;
      this.btnAgregar.Location = new Point(346, 16);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(36, 36);
      this.btnAgregar.TabIndex = 9;
      this.toolTip1.SetToolTip((Control) this.btnAgregar, "Agregar cantidad de Lote");
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.panel1.BorderStyle = BorderStyle.FixedSingle;
      this.panel1.Controls.Add((Control) this.dgvLotesDisponibles);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Location = new Point(141, 305);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(65, 58);
      this.panel1.TabIndex = 15;
      this.panel1.Visible = false;
      this.dgvLotesDisponibles.AllowUserToAddRows = false;
      this.dgvLotesDisponibles.AllowUserToDeleteRows = false;
      this.dgvLotesDisponibles.AllowUserToResizeColumns = false;
      this.dgvLotesDisponibles.AllowUserToResizeRows = false;
      gridViewCellStyle2.BackColor = Color.Lavender;
      this.dgvLotesDisponibles.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.dgvLotesDisponibles.BackgroundColor = Color.Bisque;
      this.dgvLotesDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLotesDisponibles.Columns.AddRange((DataGridViewColumn) this.CodigoDisponible, (DataGridViewColumn) this.DescripcionDisponible, (DataGridViewColumn) this.LoteDisponible, (DataGridViewColumn) this.CantidadDisponible, (DataGridViewColumn) this.Seleccionar);
      this.dgvLotesDisponibles.Location = new Point(8, 25);
      this.dgvLotesDisponibles.Name = "dgvLotesDisponibles";
      this.dgvLotesDisponibles.ReadOnly = true;
      this.dgvLotesDisponibles.RowHeadersVisible = false;
      this.dgvLotesDisponibles.Size = new Size(279, 165);
      this.dgvLotesDisponibles.TabIndex = 1;
      this.CodigoDisponible.HeaderText = "CodigoDisponible";
      this.CodigoDisponible.Name = "CodigoDisponible";
      this.CodigoDisponible.ReadOnly = true;
      this.CodigoDisponible.Visible = false;
      this.DescripcionDisponible.HeaderText = "DescripcionDisponible";
      this.DescripcionDisponible.Name = "DescripcionDisponible";
      this.DescripcionDisponible.ReadOnly = true;
      this.DescripcionDisponible.Visible = false;
      this.LoteDisponible.HeaderText = "LoteDisponible";
      this.LoteDisponible.Name = "LoteDisponible";
      this.LoteDisponible.ReadOnly = true;
      this.CantidadDisponible.HeaderText = "Cantidad";
      this.CantidadDisponible.Name = "CantidadDisponible";
      this.CantidadDisponible.ReadOnly = true;
      this.CantidadDisponible.Width = 80;
      this.Seleccionar.HeaderText = "Seleccionar";
      this.Seleccionar.Name = "Seleccionar";
      this.Seleccionar.ReadOnly = true;
      this.Seleccionar.Text = "Seleccionar";
      this.Seleccionar.UseColumnTextForButtonValue = true;
      this.Seleccionar.Width = 80;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(9, 6);
      this.label6.Name = "label6";
      this.label6.Size = new Size(223, 16);
      this.label6.TabIndex = 0;
      this.label6.Text = "Lotes disponibles por producto";
      this.txtCantidadDisponible.BackColor = Color.White;
      this.txtCantidadDisponible.Enabled = false;
      this.txtCantidadDisponible.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCantidadDisponible.ForeColor = Color.Black;
      this.txtCantidadDisponible.Location = new Point(162, 28);
      this.txtCantidadDisponible.Name = "txtCantidadDisponible";
      this.txtCantidadDisponible.Size = new Size(100, 20);
      this.txtCantidadDisponible.TabIndex = 11;
      this.txtCantidadDisponible.TextAlign = HorizontalAlignment.Center;
      this.label7.AutoSize = true;
      this.label7.ForeColor = SystemColors.ButtonShadow;
      this.label7.Location = new Point(161, 10);
      this.label7.Name = "label7";
      this.label7.Size = new Size(101, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "Cantidad Disponible";
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Location = new Point(605, 20);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 23);
      this.btnLimpiar.TabIndex = 16;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.TextAlign = ContentAlignment.TopCenter;
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(710, 326);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.dgvDatos);
//      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.Name = "frmLoteCompraVenta";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Cantiodad por Lote";
      this.FormClosing += new FormClosingEventHandler(this.frmLoteCompraVenta_FormClosing);
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dgvLotesDisponibles).EndInit();
      this.ResumeLayout(false);
    }
  }
}
