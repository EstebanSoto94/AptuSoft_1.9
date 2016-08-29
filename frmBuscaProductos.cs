 
// Type: Aptusoft.frmBuscaProductos
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Formularios;
using Aptusoft.Promocion.Formularios;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmBuscaProductos : Form
  {
    private IContainer components = (IContainer) null;
    private frmFactura frmFac = (frmFactura) null;
    private frmFacturaExenta frmFacExe = (frmFacturaExenta) null;
    private frmTicket frnTic = (frmTicket) null;
    private frmBoleta frmBol = (frmBoleta) null;
    private frmBoletaFiscal frmBolFis = (frmBoletaFiscal) null;
    private frmGuiaDespacho frmGui = (frmGuiaDespacho) null;
    private frmNotaCredito frmNC = (frmNotaCredito) null;
    private frmCotizacion frmCoti = (frmCotizacion) null;
    private frmIngresoCompra frmCompra = (frmIngresoCompra) null;
    private frmOrdenCompra frmOC = (frmOrdenCompra) null;
    private frmNotaVenta frmNotVen = (frmNotaVenta) null;
    private frmKit frmk = (frmKit) null;
    private frmTraspasoInterno frmTras = (frmTraspasoInterno) null;
    private frmLanzaInformeInventario frmLanzaInventario = (frmLanzaInformeInventario) null;
    private frmOrdenTrabajo frmOT = (frmOrdenTrabajo) null;
    private frmComanda frmComa = (frmComanda) null;
    private frmCodeBar code = (frmCodeBar)null;
    private frmDevolucion frmDevo = (frmDevolucion) null;
    private frmFacturaElectronica frmFacElectronic = (frmFacturaElectronica) null;
    private frmFacturaElectronicaFrigo frmFacElecFrigo = (frmFacturaElectronicaFrigo)null;
    private frmFacturaExentaElectronica frmFacExeElectronic = (frmFacturaExentaElectronica) null;
    private frmNotaCreditoElectronica frmNCElectronic = (frmNotaCreditoElectronica) null;
    private frmNotaDebitoElectronica frmNDElectronic = (frmNotaDebitoElectronica) null;
    private frmGuiaDespachoElectronica frmGuiaElectronic = (frmGuiaDespachoElectronica) null;
    private frmBoletaElectronica frmBoletaElectronic = (frmBoletaElectronica) null;
    private frmPromocion frmPromo = (frmPromocion) null;
    private Label label1;
    private TextBox txtDescripcion;
    private ComboBox cmbCategoria;
    private Button btnFiltrar;
    private Button btnSalir;
    private Label label2;
    private DataGridView dgvBuscaProductos;
    private RadioButton rdbDescripcion;
    private RadioButton rdbMarca;
    private RadioButton rdbCodigo;
    private ComboBox cmbBodega;
    private Label label3;
    private RadioButton rdbCodigoAlternativo;
    private string decimalesValores;
    private string modulo;
    private string tipoBusquedaDevolucion;

    public frmBuscaProductos()
    {
      this.InitializeComponent();
      this.iniciFormulario();
    }

    public frmBuscaProductos(string mod, ref frmFactura f, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmFac = f;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmFacturaElectronica f, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmFacElectronic = f;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmFacturaElectronicaFrigo f, string bodega, int codBodega, bool modBodega, string decimales)
    {
        this.InitializeComponent();
        this.iniciFormulario();
        this.modulo = mod;
        this.frmFacElecFrigo = f;
        this.creaColumnasDetalleVenta(bodega);
        this.cmbBodega.SelectedValue = (object)codBodega;
        this.decimalesValores = decimales;
        if (modBodega)
            return;
        this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmFacturaExentaElectronica fe, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmFacExeElectronic = fe;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmNotaCreditoElectronica f, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmNCElectronic = f;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmNotaDebitoElectronica f, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmNDElectronic = f;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmGuiaDespachoElectronica g, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmGuiaElectronic = g;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmBoletaElectronica b, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmBoletaElectronic = b;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmFacturaExenta fe, string bodega, int codBodega, bool modBodega)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmFacExe = fe;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmTicket t, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frnTic = t;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmDevolucion d, string bodega, int codBodega, bool modBodega, string decimales, string tipoBusqueda)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmDevo = d;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (!modBodega)
        this.cmbBodega.Enabled = false;
      this.tipoBusquedaDevolucion = tipoBusqueda;
    }

    public frmBuscaProductos(string mod, ref frmComanda co, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmComa = co;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmBoleta b, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmBol = b;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmBoletaFiscal b, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmBolFis = b;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmGuiaDespacho g, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmGui = g;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmNotaCredito nc, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmNC = nc;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmNotaVenta nv, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmNotVen = nv;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmCotizacion coti, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmCoti = coti;
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      this.decimalesValores = decimales;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmKit k)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmk = k;
      this.creaColumnasDetalleVenta("Bodega1");
    }

    public frmBuscaProductos(string mod, ref frmLanzaInformeInventario linv)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmLanzaInventario = linv;
      this.creaColumnasDetalleVenta("Bodega1");
    }

    public frmBuscaProductos(string mod, ref frmIngresoCompra com, string bodega, int codBodega, bool modBodega, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmCompra = com;
      this.decimalesValores = decimales;
      this.creaColumnasDetalleCompra(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }
    public frmBuscaProductos(string mod, ref frmCodeBar c)
    {
        this.InitializeComponent();
        this.iniciFormulario();
        this.modulo = mod;
        this.code = c;
        this.creaColumnasDetalleVenta("Bodega1");
    }
    public frmBuscaProductos(string mod, ref frmOrdenCompra oc, string decimales)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmOC = oc;
      this.decimalesValores = decimales;
      this.creaColumnasDetalleCompra("Bodega1");
    }

    public frmBuscaProductos(string mod, ref frmTraspasoInterno ti)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmTras = ti;
      this.decimalesValores = "2";
      this.creaColumnasDetalleCompra("Bodega1");
    }

    public frmBuscaProductos(string mod, ref frmOrdenTrabajo o, string bodega, int codBodega, bool modBodega)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmOT = o;
      this.decimalesValores = "2";
      this.creaColumnasDetalleVenta(bodega);
      this.cmbBodega.SelectedValue = (object) codBodega;
      if (modBodega)
        return;
      this.cmbBodega.Enabled = false;
    }

    public frmBuscaProductos(string mod, ref frmPromocion p)
    {
      this.InitializeComponent();
      this.iniciFormulario();
      this.modulo = mod;
      this.frmPromo = p;
      this.creaColumnasDetalleVenta("Bodega1");
      this.cmbBodega.SelectedValue = (object) 1;
      this.decimalesValores = "0";
      this.cmbBodega.Enabled = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.label1 = new Label();
      this.txtDescripcion = new TextBox();
      this.cmbCategoria = new ComboBox();
      this.btnFiltrar = new Button();
      this.btnSalir = new Button();
      this.label2 = new Label();
      this.dgvBuscaProductos = new DataGridView();
      this.rdbDescripcion = new RadioButton();
      this.rdbMarca = new RadioButton();
      this.rdbCodigo = new RadioButton();
      this.cmbBodega = new ComboBox();
      this.label3 = new Label();
      this.rdbCodigoAlternativo = new RadioButton();
      ((ISupportInitialize) this.dgvBuscaProductos).BeginInit();
      this.SuspendLayout();
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(3, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(497, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ingrese Producto a Buscar";
      this.txtDescripcion.Location = new Point(3, 27);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(497, 20);
      this.txtDescripcion.TabIndex = 1;
      this.txtDescripcion.KeyDown += new KeyEventHandler(this.txtDescripcion_KeyDown);
      this.cmbCategoria.FormattingEnabled = true;
      this.cmbCategoria.Location = new Point(506, 27);
      this.cmbCategoria.Name = "cmbCategoria";
      this.cmbCategoria.Size = new Size(182, 21);
      this.cmbCategoria.TabIndex = 2;
      this.cmbCategoria.Enter += new EventHandler(this.cmbCategoria_Enter);
      this.cmbCategoria.SelectedValueChanged += new EventHandler(this.cmbCategoria_SelectedValueChanged);
      this.btnFiltrar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnFiltrar.Location = new Point(867, 9);
      this.btnFiltrar.Name = "btnFiltrar";
      this.btnFiltrar.Size = new Size(88, 38);
      this.btnFiltrar.TabIndex = 3;
      this.btnFiltrar.Text = "Filtrar";
      this.btnFiltrar.UseVisualStyleBackColor = true;
      this.btnFiltrar.Click += new EventHandler(this.btnFiltrar_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(867, 431);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(88, 35);
      this.btnSalir.TabIndex = 4;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(506, 9);
      this.label2.Name = "label2";
      this.label2.Size = new Size(182, 23);
      this.label2.TabIndex = 5;
      this.label2.Text = "Filtrar por Categoria";
      this.dgvBuscaProductos.AllowUserToAddRows = false;
      this.dgvBuscaProductos.AllowUserToDeleteRows = false;
      gridViewCellStyle.BackColor = Color.LightSteelBlue;
      this.dgvBuscaProductos.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvBuscaProductos.BackgroundColor = Color.WhiteSmoke;
      this.dgvBuscaProductos.BorderStyle = BorderStyle.Fixed3D;
      this.dgvBuscaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvBuscaProductos.Location = new Point(3, 73);
      this.dgvBuscaProductos.MultiSelect = false;
      this.dgvBuscaProductos.Name = "dgvBuscaProductos";
      this.dgvBuscaProductos.ReadOnly = true;
      this.dgvBuscaProductos.RowHeadersVisible = false;
      this.dgvBuscaProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvBuscaProductos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.ScrollBars = ScrollBars.Vertical;
      this.dgvBuscaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaProductos.Size = new Size(952, 352);
      this.dgvBuscaProductos.TabIndex = 6;
      this.dgvBuscaProductos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaProductos_CellDoubleClick);
      this.dgvBuscaProductos.CellClick += new DataGridViewCellEventHandler(this.dgvBuscaProductos_CellClick);
      this.dgvBuscaProductos.KeyDown += new KeyEventHandler(this.dgvBuscaProductos_KeyDown);
      this.rdbDescripcion.AutoSize = true;
      this.rdbDescripcion.Location = new Point(15, 50);
      this.rdbDescripcion.Name = "rdbDescripcion";
      this.rdbDescripcion.Size = new Size(81, 17);
      this.rdbDescripcion.TabIndex = 7;
      this.rdbDescripcion.TabStop = true;
      this.rdbDescripcion.Text = "Descripcion";
      this.rdbDescripcion.UseVisualStyleBackColor = true;
      this.rdbMarca.AutoSize = true;
      this.rdbMarca.Location = new Point(102, 50);
      this.rdbMarca.Name = "rdbMarca";
      this.rdbMarca.Size = new Size(55, 17);
      this.rdbMarca.TabIndex = 8;
      this.rdbMarca.TabStop = true;
      this.rdbMarca.Text = "Marca";
      this.rdbMarca.UseVisualStyleBackColor = true;
      this.rdbCodigo.AutoSize = true;
      this.rdbCodigo.Location = new Point(164, 50);
      this.rdbCodigo.Name = "rdbCodigo";
      this.rdbCodigo.Size = new Size(58, 17);
      this.rdbCodigo.TabIndex = 9;
      this.rdbCodigo.TabStop = true;
      this.rdbCodigo.Text = "Codigo";
      this.rdbCodigo.UseVisualStyleBackColor = true;
      this.cmbBodega.FormattingEnabled = true;
      this.cmbBodega.Location = new Point(694, 26);
      this.cmbBodega.Name = "cmbBodega";
      this.cmbBodega.Size = new Size(146, 21);
      this.cmbBodega.TabIndex = 10;
      this.cmbBodega.SelectedValueChanged += new EventHandler(this.cmbBodega_SelectedValueChanged);
      this.label3.BackColor = Color.FromArgb(64, 64, 64);
      this.label3.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(694, 9);
      this.label3.Name = "label3";
      this.label3.Size = new Size(146, 23);
      this.label3.TabIndex = 11;
      this.label3.Text = "Bodega";
      this.rdbCodigoAlternativo.AutoSize = true;
      this.rdbCodigoAlternativo.Location = new Point(228, 50);
      this.rdbCodigoAlternativo.Name = "rdbCodigoAlternativo";
      this.rdbCodigoAlternativo.Size = new Size(111, 17);
      this.rdbCodigoAlternativo.TabIndex = 12;
      this.rdbCodigoAlternativo.TabStop = true;
      this.rdbCodigoAlternativo.Text = "Codigo Alternativo";
      this.rdbCodigoAlternativo.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(957, 467);
      this.Controls.Add((Control) this.rdbCodigoAlternativo);
      this.Controls.Add((Control) this.cmbBodega);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.rdbCodigo);
      this.Controls.Add((Control) this.rdbMarca);
      this.Controls.Add((Control) this.rdbDescripcion);
      this.Controls.Add((Control) this.dgvBuscaProductos);
      this.Controls.Add((Control) this.cmbCategoria);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.txtDescripcion);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnFiltrar);
      this.Controls.Add((Control) this.label1);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "frmBuscaProductos";
      this.ShowIcon = false;
      this.Text = "Buscador de Productos";
      ((ISupportInitialize) this.dgvBuscaProductos).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void iniciFormulario()
    {
      this.txtDescripcion.Clear();
      this.rdbDescripcion.Checked = true;
      this.rdbMarca.Checked = false;
      this.rdbCodigo.Checked = false;
      this.rdbCodigoAlternativo.Checked = false;
      this.cargaBodega();
      this.cargaCategorias();
    }

    private void creaColumnasDetalleVenta(string bodega)
    {
      this.dgvBuscaProductos.AutoGenerateColumns = false;
      this.dgvBuscaProductos.Columns.Add("Codigo", "Codigo");
      this.dgvBuscaProductos.Columns[0].DataPropertyName = "Codigo";
      this.dgvBuscaProductos.Columns[0].Width = 90;
      this.dgvBuscaProductos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("CodigoAlternativo", "Codigo Alt.");
      this.dgvBuscaProductos.Columns[1].DataPropertyName = "CodigoAlternativo";
      this.dgvBuscaProductos.Columns[1].Width = 80;
      this.dgvBuscaProductos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("Descripcion", "Descripcion");
      this.dgvBuscaProductos.Columns[2].DataPropertyName = "Descripcion";
      this.dgvBuscaProductos.Columns[2].Width = 420;
      this.dgvBuscaProductos.Columns[2].Resizable = DataGridViewTriState.True;
      this.dgvBuscaProductos.Columns.Add("Marca", "Marca");
      this.dgvBuscaProductos.Columns[3].DataPropertyName = "Marca";
      this.dgvBuscaProductos.Columns[3].Width = 120;
      this.dgvBuscaProductos.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("ValorVenta", "Precio");
      this.dgvBuscaProductos.Columns[4].DataPropertyName = "ValorVenta1";
      this.dgvBuscaProductos.Columns[4].Width = 70;
      this.dgvBuscaProductos.Columns[4].DefaultCellStyle.Format = "C" + this.decimalesValores;
      this.dgvBuscaProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProductos.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("Stock", bodega);
      this.dgvBuscaProductos.Columns[5].DataPropertyName = bodega;
      this.dgvBuscaProductos.Columns[5].Width = 70;
      this.dgvBuscaProductos.Columns[5].DefaultCellStyle.Format = "N2";
      this.dgvBuscaProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProductos.Columns[5].Resizable = DataGridViewTriState.False;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Agregar";
      viewButtonColumn.HeaderText = " ";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "Agregar";
      viewButtonColumn.Width = 80;
      viewButtonColumn.DisplayIndex = 6;
      viewButtonColumn.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add((DataGridViewColumn) viewButtonColumn);
    }

    private void creaColumnasDetalleCompra(string bodega)
    {
      this.dgvBuscaProductos.AutoGenerateColumns = false;
      this.dgvBuscaProductos.Columns.Add("Codigo", "Codigo");
      this.dgvBuscaProductos.Columns[0].DataPropertyName = "Codigo";
      this.dgvBuscaProductos.Columns[0].Width = 90;
      this.dgvBuscaProductos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("CodigoAlternativo", "Codigo Alt.");
      this.dgvBuscaProductos.Columns[1].DataPropertyName = "CodigoAlternativo";
      this.dgvBuscaProductos.Columns[1].Width = 80;
      this.dgvBuscaProductos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("Descripcion", "Descripcion");
      this.dgvBuscaProductos.Columns[2].DataPropertyName = "Descripcion";
      this.dgvBuscaProductos.Columns[2].Width = 420;
      this.dgvBuscaProductos.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("Marca", "Marca");
      this.dgvBuscaProductos.Columns[3].DataPropertyName = "Marca";
      this.dgvBuscaProductos.Columns[3].Width = 120;
      this.dgvBuscaProductos.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("ValorCompra", "PrecioCompra");
      this.dgvBuscaProductos.Columns[4].DataPropertyName = "ValorCompra";
      this.dgvBuscaProductos.Columns[4].Width = 70;
      this.dgvBuscaProductos.Columns[4].DefaultCellStyle.Format = "C" + this.decimalesValores;
      this.dgvBuscaProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProductos.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add("Stock", bodega);
      this.dgvBuscaProductos.Columns[5].DataPropertyName = bodega;
      this.dgvBuscaProductos.Columns[5].Width = 70;
      this.dgvBuscaProductos.Columns[5].DefaultCellStyle.Format = "N2";
      this.dgvBuscaProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProductos.Columns[5].Resizable = DataGridViewTriState.False;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Agregar";
      viewButtonColumn.HeaderText = " ";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "Agregar";
      viewButtonColumn.Width = 80;
      viewButtonColumn.DisplayIndex = 6;
      viewButtonColumn.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add((DataGridViewColumn) viewButtonColumn);
    }

    private void cargaCategorias()
    {
      this.cmbCategoria.DataSource = (object) null;
      Categoria categoria = new Categoria();
      DataSet dataSet = new DataSet();
      DataTable dataTable = categoria.cosultaCategoria().Tables[0];
      DataRow row = dataTable.NewRow();
      row[0] = (object) 0;
      row[1] = (object) "[SELECCIONE]";
      dataTable.Rows.Add(row);
      dataTable.DefaultView.Sort = "ID ASC";
      this.cmbCategoria.SelectedValue = this.cmbCategoria.SelectedValue;
      this.cmbCategoria.DisplayMember = "DescCategoria";
      this.cmbCategoria.ValueMember = "Id";
      this.cmbCategoria.DataSource = (object) dataTable;
      this.cmbCategoria.SelectedValue = (object) 0;
    }

    private void cargaBodega()
    {
      this.cmbBodega.DataSource = (object) new CargaMaestros().cargaBodega();
      this.cmbBodega.ValueMember = "codigo";
      this.cmbBodega.DisplayMember = "descripcion";
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void cmbCategoria_Enter(object sender, EventArgs e)
    {
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
      this.buscaProductos();
    }

    private void buscaProductos()
    {
      Producto producto = new Producto();
      int campo = 0;
      string bodega = "Bodega" + this.cmbBodega.SelectedValue.ToString();
      string categoria = "";
      if (this.cmbCategoria.Text != "[SELECCIONE]")
        categoria = "AND Categoria ='" + this.cmbCategoria.Text + "'";
      if (this.rdbDescripcion.Checked)
        campo = 1;
      if (this.rdbMarca.Checked)
        campo = 2;
      if (this.rdbCodigo.Checked)
        campo = 3;
      if (this.rdbCodigoAlternativo.Checked)
        campo = 4;
      this.dgvBuscaProductos.Columns.Clear();
      if (this.modulo.Equals("compra") || this.modulo.Equals("orden_compra") || this.modulo.Equals("traspaso_interno"))
        this.creaColumnasDetalleCompra(bodega);
      else
        this.creaColumnasDetalleVenta(bodega);
      this.dgvBuscaProductos.DataSource = (object) producto.listaProductosDescripcion(campo, this.txtDescripcion.Text.Trim(), bodega, categoria).Tables[0];
      this.dgvBuscaProductos.Focus();
    }

    private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.buscaProductos();
    }

    private void dgvBuscaProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      string str;
      Decimal num1;//frmFacElecFrigo
      if (this.modulo.Equals("devolucion"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("devolucion"))
          {
              this.frmDevo.llamaProductoCodigo(cod, bodega);
              this.Close();
          }
      }
      if (this.modulo.Equals("bar"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          //this.code.set_codigo(cod);
          frmCodeBar cd = new frmCodeBar();
          cd.set_codigo(cod);
          this.Close();
      }
      //factura_electronica_frigo
      if (this.modulo.Equals("factura_electronica_frigo"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          ////agregar productos
          //frmFactura fr = new frmFactura();
          //fr.llamaProductoCodigo(cod, bodega);
          this.frmFacElecFrigo.llamaProductoCodigo(cod, bodega);
          this.Close();
      }
      if (this.modulo.Equals("boleta"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmBol.llamaProductoCodigo(cod, bodega);
          //this.frmBol.cantidad();
          //this.frmBol.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("factura"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          ////agregar productos
          //frmFactura fr = new frmFactura();
          //fr.llamaProductoCodigo(cod, bodega);
          this.frmFac.llamaProductoCodigo(cod, bodega);
          this.Close();
      }
      if (this.modulo.Equals("factura_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          //agregar productos
          //frmFactura fr = new frmFactura();
          //fr.llamaProductoCodigo(cod, bodega);
          //fr.cantidad();
          //fr.agregaLineaGrilla();
          this.frmFacElectronic.llamaProductoCodigo(cod, bodega);
          this.Close();
      }
      if (this.modulo.Equals("factura_exenta_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          //agregar productos
          this.frmFacExeElectronic.llamaProductoCodigo(cod, bodega);
          this.Close();
      }
      if (this.modulo.Equals("nota_credito_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("nota_credito_electronica"))
          {
              this.frmNCElectronic.llamaProductoCodigo(cod, bodega);

              this.Close();
          }
      }
      if (this.modulo.Equals("nota_debito_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("nota_debito_electronica"))
          {
              this.frmNDElectronic.llamaProductoCodigo(cod, bodega);
              this.Close();
          }
      }
      if (this.modulo.Equals("guia_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("guia_electronica"))
          {
              this.frmGuiaElectronic.llamaProductoCodigo(cod, bodega);
              this.Close();
          }
      }
      if (this.modulo.Equals("boleta_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("boleta_electronica"))
          {
              this.frmBoletaElectronic.llamaProductoCodigo(cod, bodega);
              this.Close();
          }
      }
      if (this.modulo.Equals("factura_exenta"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmFacExe.llamaProductoCodigo(cod, bodega);
          //this.frmFacExe.cantidad();
          //this.frmFacExe.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("ticket"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frnTic.llamaProductoCodigo(cod, bodega);
          //this.frnTic.cantidad();
          //this.frnTic.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("comanda"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmComa.llamaProductoCodigo(cod, bodega);
          //this.frmComa.cantidad();
          //this.frmComa.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("boleta_fiscal"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmBolFis.llamaProductoCodigo(cod, bodega);
          //this.frmBolFis.cantidad();
          //this.frmBolFis.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("guia"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmGui.llamaProductoCodigo(cod, bodega);
          //this.frmGui.cantidad();
          //this.frmGui.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("notaCredito"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmNC.llamaProductoCodigo(cod, bodega);
          //this.frmNC.cantidad();
          //this.frmNC.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("nota_venta"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          ////str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          ////num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmNotVen.llamaProductoCodigo(cod, bodega);
          //this.frmNotVen.cantidad();
          //this.frmNotVen.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("cotizacion"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmCoti.llamaProductoCodigo(cod, bodega);
          //this.frmCoti.cantidad();
          //this.frmCoti.agregaLineaGrilla();
          this.Close();
      }
      int num2;
      if (this.modulo.Equals("kit"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          // str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmk.llamaProductoCodigo(cod);
          this.Close();
      }
      if (this.modulo.Equals("compra"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmCompra.llamaProductoCodigo(cod, bodega);
          //this.frmCompra.cantidad();
          //this.frmCompra.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("orden_compra"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmOC.llamaProductoCodigo(cod);
          //this.frmOC.cantidad();
          //this.frmOC.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("traspaso_interno"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmTras.llamaProductoCodigo(cod, bodega);
          //this.frmTras.cantidad();
          //this.frmTras.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("informe_productos"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmLanzaInventario.buscaCodigo(cod);
          this.Close();
      }
      if (this.modulo.Equals("ordentrabajo"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmOT.llamaProductoCodigo(cod, bodega);
          //this.frmOT.cantidad();
          //this.frmOT.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("promocion"))
          this.frmPromo.agregaProductoGrilla(this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString(), this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString());
        
    }

    private void dgvBuscaProductos_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.dgvBuscaProductos.RowCount <= 0 || e.KeyCode != Keys.Return)
        return;
      string str;
      Decimal num1;
      if (this.modulo.Equals("devolucion"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("devolucion"))
          {
              this.frmDevo.llamaProductoCodigo(cod, bodega);
              this.Close();
          }
      }
      if (this.modulo.Equals("bar"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          //this.code.set_codigo(cod);
          frmCodeBar cd = new frmCodeBar();
          cd.set_codigo(cod);
          this.Close();
      }
      //factura_electronica_frigo
      if (this.modulo.Equals("factura_electronica_frigo"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          ////agregar productos
          //frmFactura fr = new frmFactura();
          //fr.llamaProductoCodigo(cod, bodega);
          this.frmFacElecFrigo.llamaProductoCodigo(cod, bodega);
          this.Close();
      }
      if (this.modulo.Equals("boleta"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmBol.llamaProductoCodigo(cod, bodega);
          //this.frmBol.cantidad();
          //this.frmBol.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("factura"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          ////agregar productos
          //frmFactura fr = new frmFactura();
          //fr.llamaProductoCodigo(cod, bodega);
          this.frmFac.llamaProductoCodigo(cod, bodega);
          this.Close();
      }
      if (this.modulo.Equals("factura_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          //agregar productos
          //frmFactura fr = new frmFactura();
          //fr.llamaProductoCodigo(cod, bodega);
          //fr.cantidad();
          //fr.agregaLineaGrilla();
          this.frmFacElectronic.llamaProductoCodigo(cod, bodega);
          this.Close();
      }
      if (this.modulo.Equals("factura_exenta_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          //agregar productos
          this.frmFacExeElectronic.llamaProductoCodigo(cod, bodega);
          this.Close();
      }
      if (this.modulo.Equals("nota_credito_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("nota_credito_electronica"))
          {
              this.frmNCElectronic.llamaProductoCodigo(cod, bodega);

              this.Close();
          }
      }
      if (this.modulo.Equals("nota_debito_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("nota_debito_electronica"))
          {
              this.frmNDElectronic.llamaProductoCodigo(cod, bodega);
              this.Close();
          }
      }
      if (this.modulo.Equals("guia_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("guia_electronica"))
          {
              this.frmGuiaElectronic.llamaProductoCodigo(cod, bodega);
              this.Close();
          }
      }
      if (this.modulo.Equals("boleta_electronica"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          if (this.modulo.Equals("boleta_electronica"))
          {
              this.frmBoletaElectronic.llamaProductoCodigo(cod, bodega);
              this.Close();
          }
      }
      if (this.modulo.Equals("factura_exenta"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmFacExe.llamaProductoCodigo(cod, bodega);
          //this.frmFacExe.cantidad();
          //this.frmFacExe.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("ticket"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frnTic.llamaProductoCodigo(cod, bodega);
          //this.frnTic.cantidad();
          //this.frnTic.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("comanda"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmComa.llamaProductoCodigo(cod, bodega);
          //this.frmComa.cantidad();
          //this.frmComa.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("boleta_fiscal"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmBolFis.llamaProductoCodigo(cod, bodega);
          //this.frmBolFis.cantidad();
          //this.frmBolFis.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("guia"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmGui.llamaProductoCodigo(cod, bodega);
          //this.frmGui.cantidad();
          //this.frmGui.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("notaCredito"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmNC.llamaProductoCodigo(cod, bodega);
          //this.frmNC.cantidad();
          //this.frmNC.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("nota_venta"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          ////str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          ////num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmNotVen.llamaProductoCodigo(cod, bodega);
          //this.frmNotVen.cantidad();
          //this.frmNotVen.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("cotizacion"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmCoti.llamaProductoCodigo(cod, bodega);
          //this.frmCoti.cantidad();
          //this.frmCoti.agregaLineaGrilla();
          this.Close();
      }
      int num2;
      if (this.modulo.Equals("kit"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          // str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmk.llamaProductoCodigo(cod);
          this.Close();
      }
      if (this.modulo.Equals("compra"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmCompra.llamaProductoCodigo(cod, bodega);
          //this.frmCompra.cantidad();
          //this.frmCompra.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("orden_compra"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmOC.llamaProductoCodigo(cod);
          //this.frmOC.cantidad();
          //this.frmOC.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("traspaso_interno"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmTras.llamaProductoCodigo(cod, bodega);
          //this.frmTras.cantidad();
          //this.frmTras.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("informe_productos"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmLanzaInventario.buscaCodigo(cod);
          this.Close();
      }
      if (this.modulo.Equals("ordentrabajo"))
      {
          string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
          //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
          //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
          int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
          this.frmOT.llamaProductoCodigo(cod, bodega);
          //this.frmOT.cantidad();
          //this.frmOT.agregaLineaGrilla();
          this.Close();
      }
      if (this.modulo.Equals("promocion"))
          this.frmPromo.agregaProductoGrilla(this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString(), this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString());
        
      
    }

    private void cmbBodega_SelectedValueChanged(object sender, EventArgs e)
    {
      if (this.dgvBuscaProductos.Rows.Count <= 0)
        return;
      this.buscaProductos();
    }

    private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
    {
      if (this.dgvBuscaProductos.Rows.Count <= 0)
        return;
      this.buscaProductos();
    }

    private void dgvBuscaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            if (!(this.dgvBuscaProductos.Columns[e.ColumnIndex].Name == "Agregar"))
                return;
            string str;

            Decimal num1; 
            if (this.modulo.Equals("devolucion"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                if (this.modulo.Equals("devolucion"))
                {
                    this.frmDevo.llamaProductoCodigo(cod, bodega);
                    this.Close();
                }
            } 
            if (this.modulo.Equals("bar"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                //this.code.set_codigo(cod);
                frmCodeBar cd = new frmCodeBar();
                cd.set_codigo(cod);
                this.Close();
            }
            //factura_electronica_frigo
            if (this.modulo.Equals("factura_electronica_frigo"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                ////agregar productos
                //frmFactura fr = new frmFactura();
                //fr.llamaProductoCodigo(cod, bodega);
                this.frmFacElecFrigo.llamaProductoCodigo(cod, bodega);
                this.Close();
            }
            if (this.modulo.Equals("boleta"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmBol.llamaProductoCodigo(cod, bodega);
                //this.frmBol.cantidad();
                //this.frmBol.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("factura"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                ////agregar productos
                //frmFactura fr = new frmFactura();
                //fr.llamaProductoCodigo(cod, bodega);
                this.frmFac.llamaProductoCodigo(cod, bodega);
                this.Close();
            }
            if (this.modulo.Equals("factura_electronica"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                //agregar productos
                //frmFactura fr = new frmFactura();
                //fr.llamaProductoCodigo(cod, bodega);
                //fr.cantidad();
                //fr.agregaLineaGrilla();
                this.frmFacElectronic.llamaProductoCodigo(cod, bodega);
                this.Close();
            }
            if (this.modulo.Equals("factura_exenta_electronica"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                //agregar productos
                this.frmFacExeElectronic.llamaProductoCodigo(cod, bodega);
                this.Close();
            }
            if (this.modulo.Equals("nota_credito_electronica"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                if (this.modulo.Equals("nota_credito_electronica"))
                {
                    this.frmNCElectronic.llamaProductoCodigo(cod, bodega);
                 
                    this.Close();
                }
            }
            if (this.modulo.Equals("nota_debito_electronica"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                if (this.modulo.Equals("nota_debito_electronica"))
                {
                    this.frmNDElectronic.llamaProductoCodigo(cod, bodega);
                    this.Close();
                }
            }
            if (this.modulo.Equals("guia_electronica"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                if (this.modulo.Equals("guia_electronica"))
                {
                    this.frmGuiaElectronic.llamaProductoCodigo(cod, bodega);
                    this.Close();
                }
            }
            if (this.modulo.Equals("boleta_electronica"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                if (this.modulo.Equals("boleta_electronica"))
                {
                    this.frmBoletaElectronic.llamaProductoCodigo(cod, bodega);
                    this.Close();
                }
            }
            if (this.modulo.Equals("factura_exenta"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmFacExe.llamaProductoCodigo(cod, bodega);
                //this.frmFacExe.cantidad();
                //this.frmFacExe.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("ticket"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frnTic.llamaProductoCodigo(cod, bodega);
                //this.frnTic.cantidad();
                //this.frnTic.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("comanda"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmComa.llamaProductoCodigo(cod, bodega);
                //this.frmComa.cantidad();
                //this.frmComa.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("boleta_fiscal"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmBolFis.llamaProductoCodigo(cod, bodega);
                //this.frmBolFis.cantidad();
                //this.frmBolFis.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("guia"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmGui.llamaProductoCodigo(cod, bodega);
                //this.frmGui.cantidad();
                //this.frmGui.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("notaCredito"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmNC.llamaProductoCodigo(cod, bodega);
                //this.frmNC.cantidad();
                //this.frmNC.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("nota_venta"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                ////str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                ////num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmNotVen.llamaProductoCodigo(cod, bodega);
                //this.frmNotVen.cantidad();
                //this.frmNotVen.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("cotizacion"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmCoti.llamaProductoCodigo(cod, bodega);
                //this.frmCoti.cantidad();
                //this.frmCoti.agregaLineaGrilla();
                this.Close();
            }
            int num2;
            if (this.modulo.Equals("kit"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
               // str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmk.llamaProductoCodigo(cod);
                this.Close();
            }
            if (this.modulo.Equals("compra"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmCompra.llamaProductoCodigo(cod, bodega);
                //this.frmCompra.cantidad();
                //this.frmCompra.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("orden_compra"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmOC.llamaProductoCodigo(cod);
                //this.frmOC.cantidad();
                //this.frmOC.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("traspaso_interno"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmTras.llamaProductoCodigo(cod, bodega);
                //this.frmTras.cantidad();
                //this.frmTras.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("informe_productos"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num2 = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmLanzaInventario.buscaCodigo(cod);
                this.Close();
            }
            if (this.modulo.Equals("ordentrabajo"))
            {
                string cod = this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString();
                //str = this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString();
                //num1 = Convert.ToDecimal(this.dgvBuscaProductos.SelectedRows[0].Cells[4].Value.ToString());
                int bodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
                this.frmOT.llamaProductoCodigo(cod, bodega);
                //this.frmOT.cantidad();
                //this.frmOT.agregaLineaGrilla();
                this.Close();
            }
            if (this.modulo.Equals("promocion"))
                this.frmPromo.agregaProductoGrilla(this.dgvBuscaProductos.SelectedRows[0].Cells[0].Value.ToString(), this.dgvBuscaProductos.SelectedRows[0].Cells[2].Value.ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
  }
}
