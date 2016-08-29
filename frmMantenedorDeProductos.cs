 
// Type: Aptusoft.frmMantenedorDeProductos
 
 
// version 1.8.0

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmMantenedorDeProductos : Form
  {
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private bool _modificaStock = false;
    private List<ProductoVO> listaProductos = new List<ProductoVO>();
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox txtDescripcion;
    private ComboBox cmbCategoria;
    private Button btnFiltrar;
    private Button btnSalir;
    private Label label2;
    private DataGridView dgvBuscaProductos;
    private RadioButton rdbDescripcion;
    private RadioButton rdbCodigo;
    private GroupBox groupBox1;
    private RadioButton rdbBajar;
    private RadioButton rdbSubir;
    private RadioButton rdbCambiaPorcUtilidad;
    private RadioButton rdbCambiaPorc;
    private Label label3;
    private TextBox txtPorcentaje;
    private Panel panel1;
    private CheckBox chkSeleccionarTodos;
    private Button btnCambiarPrecio;
    private Button btnGuardaCambioPrecio;
    private Button btnLimpiar;
    private GroupBox groupBox2;
    private Button btnEliminar;
    private GroupBox groupBox3;
    private ComboBox cmbBodega;
    private Button btnBodegaCero;

    public frmMantenedorDeProductos()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.cargaBodega();
      this.iniciFormulario();
      this.creaColumnasDetalleVenta();
    }

    private void cargaBodega()
    {
      this.cmbBodega.DataSource = (object) new CargaMaestros().cargaBodega();
      this.cmbBodega.ValueMember = "codigo";
      this.cmbBodega.DisplayMember = "descripcion";
      this.cmbBodega.SelectedValue = (object) 1;
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("PRODUCTO"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._modificaStock = Convert.ToBoolean(usuarioVo.ModificaStock);
        }
      }
    }

    private void iniciFormulario()
    {
      this.txtDescripcion.Clear();
      this.txtPorcentaje.Clear();
      this.rdbDescripcion.Checked = true;
      this.rdbCodigo.Checked = false;
      this.rdbSubir.Checked = true;
      this.rdbBajar.Checked = false;
      this.rdbCambiaPorc.Checked = true;
      this.rdbCambiaPorcUtilidad.Checked = false;
      this.cargaCategorias();
      this.listaProductos.Clear();
      this.dgvBuscaProductos.DataSource = (object) null;
      this.btnGuardaCambioPrecio.Enabled = false;
      this.chkSeleccionarTodos.Checked = false;
      this.btnEliminar.Enabled = false;
      if (this._modificaStock)
      {
        this.btnBodegaCero.Enabled = true;
        this.cmbBodega.Enabled = true;
      }
      else
      {
        this.btnBodegaCero.Enabled = false;
        this.cmbBodega.Enabled = false;
      }
    }

    private void creaColumnasDetalleVenta()
    {
      this.dgvBuscaProductos.AutoGenerateColumns = false;
      this.dgvBuscaProductos.Columns.Add("Linea", "");
      this.dgvBuscaProductos.Columns[0].DataPropertyName = "Linea";
      this.dgvBuscaProductos.Columns[0].Width = 20;
      this.dgvBuscaProductos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
      this.dgvBuscaProductos.Columns[0].ReadOnly = true;
      this.dgvBuscaProductos.Columns.Add("Codigo", "Codigo");
      this.dgvBuscaProductos.Columns[1].DataPropertyName = "Codigo";
      this.dgvBuscaProductos.Columns[1].Width = 80;
      this.dgvBuscaProductos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns[1].ReadOnly = true;
      this.dgvBuscaProductos.Columns.Add("Descripcion", "Descripcion");
      this.dgvBuscaProductos.Columns[2].DataPropertyName = "Descripcion";
      this.dgvBuscaProductos.Columns[2].Width = 178;
      this.dgvBuscaProductos.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns[2].ReadOnly = true;
      this.dgvBuscaProductos.Columns.Add("ValorCompra", "$ Compra");
      this.dgvBuscaProductos.Columns[3].DataPropertyName = "ValorCompra";
      this.dgvBuscaProductos.Columns[3].Width = 80;
      this.dgvBuscaProductos.Columns[3].DefaultCellStyle.Format = "C0";
      this.dgvBuscaProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProductos.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns[3].ReadOnly = true;
      this.dgvBuscaProductos.Columns.Add("ValorVenta", "$ Venta");
      this.dgvBuscaProductos.Columns[4].DataPropertyName = "ValorVenta1";
      this.dgvBuscaProductos.Columns[4].Width = 80;
      this.dgvBuscaProductos.Columns[4].DefaultCellStyle.Format = "C0";
      this.dgvBuscaProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProductos.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns[4].ReadOnly = true;
      this.dgvBuscaProductos.Columns.Add("NuevoValorVenta", "Nvo. $ Venta");
      this.dgvBuscaProductos.Columns[5].DataPropertyName = "NuevoValorVenta";
      this.dgvBuscaProductos.Columns[5].Width = 94;
      this.dgvBuscaProductos.Columns[5].DefaultCellStyle.Format = "N0";
      this.dgvBuscaProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProductos.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns[5].ReadOnly = true;
      this.dgvBuscaProductos.Columns.Add("PorcRentabilidad1", "% Utilidad");
      this.dgvBuscaProductos.Columns[6].DataPropertyName = "PorcRentabilidad1";
      this.dgvBuscaProductos.Columns[6].Width = 80;
      this.dgvBuscaProductos.Columns[6].DefaultCellStyle.Format = "N2";
      this.dgvBuscaProductos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProductos.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns[6].ReadOnly = true;
      DataGridViewCheckBoxColumn viewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn1.Name = "Exento";
      viewCheckBoxColumn1.HeaderText = "Exento";
      viewCheckBoxColumn1.DataPropertyName = "Exento";
      viewCheckBoxColumn1.Width = 70;
      viewCheckBoxColumn1.DisplayIndex = 7;
      viewCheckBoxColumn1.FalseValue = (object) 0;
      viewCheckBoxColumn1.TrueValue = (object) 1;
      viewCheckBoxColumn1.ReadOnly = true;
      viewCheckBoxColumn1.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn1);
      DataGridViewCheckBoxColumn viewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn2.Name = "Seleccionar";
      viewCheckBoxColumn2.HeaderText = "Seleccionar";
      viewCheckBoxColumn2.DataPropertyName = "Seleccionar";
      viewCheckBoxColumn2.Width = 70;
      viewCheckBoxColumn2.DisplayIndex = 8;
      viewCheckBoxColumn2.FalseValue = (object) 0;
      viewCheckBoxColumn2.TrueValue = (object) 1;
      viewCheckBoxColumn2.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn2);
    }

    private void cargaCategorias()
    {
      this.cmbCategoria.DataSource = (object) null;
      Categoria categoria = new Categoria();
      DataSet dataSet = new DataSet();
      DataTable dataTable = categoria.cosultaCategoria().Tables[0];
      DataRow row = dataTable.NewRow();
      row[0] = (object) 0;
      row[1] = (object) "[TODAS]";
      dataTable.Rows.Add(row);
      dataTable.DefaultView.Sort = "ID ASC";
      this.cmbCategoria.SelectedValue = this.cmbCategoria.SelectedValue;
      this.cmbCategoria.DisplayMember = "DescCategoria";
      this.cmbCategoria.ValueMember = "Id";
      this.cmbCategoria.DataSource = (object) dataTable;
      this.cmbCategoria.SelectedValue = (object) 0;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modMaestroProducto = 0;
      this.Close();
      this.Dispose();
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
      this.buscaProductos();
      if (this.listaProductos.Count <= 0)
        return;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      else
        this.btnEliminar.Enabled = false;
    }

    private void buscaProductos()
    {
      Producto producto = new Producto();
      int campo = 0;
      string categoria = "";
      if (this.cmbCategoria.Text != "[TODAS]")
        categoria = "AND Categoria ='" + this.cmbCategoria.Text + "'";
      if (this.rdbDescripcion.Checked)
        campo = 1;
      if (this.rdbCodigo.Checked)
        campo = 3;
      this.dgvBuscaProductos.Columns.Clear();
      this.creaColumnasDetalleVenta();
      this.listaProductos.Clear();
      this.listaProductos = producto.listaProductosDescripcionMantenedor(campo, this.txtDescripcion.Text.Trim(), categoria);
      this.dgvBuscaProductos.DataSource = (object) this.listaProductos;
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
    }

    private void dgvBuscaProductos_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.dgvBuscaProductos.RowCount <= 0 || e.KeyCode != Keys.Return)
        ;
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
      if (!(this.dgvBuscaProductos.Columns[e.ColumnIndex].Name == "Agregar"))
        ;
    }

    private void rdbCambiaPorcUtilidad_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rdbCambiaPorcUtilidad.Checked)
        return;
      this.rdbSubir.Enabled = false;
      this.rdbSubir.Checked = true;
      this.rdbBajar.Enabled = false;
    }

    private void rdbCambiaPorc_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rdbCambiaPorc.Checked)
        return;
      this.rdbSubir.Enabled = true;
      this.rdbSubir.Checked = true;
      this.rdbBajar.Enabled = true;
    }

    private void chkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSeleccionarTodos.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvBuscaProductos.Rows)
          dataGridViewRow.Cells["Seleccionar"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvBuscaProductos.Rows)
          dataGridViewRow.Cells["Seleccionar"].Value = (object) false;
      }
    }

    private void btnCambiarPrecio_Click(object sender, EventArgs e)
    {
      if (this.listaProductos.Count > 0)
      {
        if (this.txtPorcentaje.Text.Trim().Length > 0)
        {
          this.cambiaPrecios();
          if (!this._modifica)
            return;
          this.btnGuardaCambioPrecio.Enabled = true;
        }
        else
        {
          int num = (int) MessageBox.Show("Debe Ingresar un Porcentaje: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtPorcentaje.Focus();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("No Hay Datos: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void cambiaPrecios()
    {
      try
      {
        Decimal num1 = Convert.ToDecimal(this.txtPorcentaje.Text.Trim());
        Calculos calculos = new Calculos();
        bool flag1 = calculos._valoresConIva;
        Decimal num2 = calculos._iva;
        if (this.rdbCambiaPorc.Checked)
        {
          if (this.rdbSubir.Checked)
          {
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvBuscaProductos.Rows)
            {
              Decimal num3 = Convert.ToDecimal(dataGridViewRow.Cells["ValorVenta"].Value.ToString());
              Decimal num4 = Convert.ToDecimal(dataGridViewRow.Cells["ValorCompra"].Value.ToString());
              bool flag2 = Convert.ToBoolean(dataGridViewRow.Cells["Exento"].Value);
              Decimal num5 = num3 * num1 / new Decimal(100) + num3;
              dataGridViewRow.Cells["NuevoValorVenta"].Value = (object) num5.ToString("N0");
              Decimal b7 = num2 / new Decimal(100);
              if (num4 != 0)
              {
              Decimal b8 = (!flag1 || flag2 ? num5 : num5 / ++b7) / num4;
             
                  Decimal num6 = --b8 * new Decimal(100);
                  dataGridViewRow.Cells["PorcRentabilidad1"].Value = (object)num6.ToString();
              }
            }
          }
          if (this.rdbBajar.Checked)
          {
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvBuscaProductos.Rows)
            {
              Decimal num3 = Convert.ToDecimal(dataGridViewRow.Cells["ValorVenta"].Value.ToString());
              Decimal num4 = Convert.ToDecimal(dataGridViewRow.Cells["ValorCompra"].Value.ToString());
              bool flag2 = Convert.ToBoolean(dataGridViewRow.Cells["Exento"].Value);
              Decimal num5 = num3 - num3 * num1 / new Decimal(100);
              dataGridViewRow.Cells["NuevoValorVenta"].Value = (object) num5.ToString("N0");
              Decimal c1 = num2 / new Decimal(100);
                Decimal c2=  !flag1 || flag2 ? num5 : num5 / ++c1;
                if (num4 != 0){
              Decimal num6 = --c2 / num4 * new Decimal(100);//cae en valores 
                  dataGridViewRow.Cells["PorcRentabilidad1"].Value = (object)num6.ToString();
              }
            }
          }
        }
        if (!this.rdbCambiaPorcUtilidad.Checked)
          return;
        Decimal num7 = Convert.ToDecimal(this.txtPorcentaje.Text.Trim());
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvBuscaProductos.Rows)
        {
          Decimal num3 = Convert.ToDecimal(dataGridViewRow.Cells["ValorCompra"].Value.ToString());
          bool flag2 = Convert.ToBoolean(dataGridViewRow.Cells["Exento"].Value);
          Decimal d2 = num1 / new Decimal(100);
          Decimal num4 = num3 * ++d2;
          if (flag1 && !flag2)
          {
              Decimal d4 = num2 / new Decimal(100);
              num4 *= ++d4;
              dataGridViewRow.Cells["NuevoValorVenta"].Value = (object)num4.ToString("N0");
              dataGridViewRow.Cells["PorcRentabilidad1"].Value = (object)num7.ToString();
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void soloNumeros(KeyPressEventArgs e)
    {
      string str = "0123456789.,";
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (str.Contains(string.Concat((object) e.KeyChar)) || (int) e.KeyChar == 8)
        e.Handled = false;
      else
        e.Handled = true;
    }

    private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e);
    }

    private void btnGuardaCambioPrecio_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro/a de Modificar los Precios", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        int num1 = 0;
        ProductoVO productoVo = new ProductoVO();
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvBuscaProductos.Rows)
        {
          if (Convert.ToBoolean(dataGridViewRow.Cells["Seleccionar"].Value))
          {
            this.modificaPrecio(new ProductoVO()
            {
              Codigo = dataGridViewRow.Cells["Codigo"].Value.ToString(),
              ValorVenta1 = Convert.ToDecimal(dataGridViewRow.Cells["NuevoValorVenta"].Value.ToString()),
              PorcRentabilidad1 = Convert.ToDecimal(dataGridViewRow.Cells["PorcRentabilidad1"].Value.ToString())
            });
            ++num1;
          }
        }
        if (num1 == 0)
        {
          int num2 = (int) MessageBox.Show("Debe Seleccionar Productos a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.chkSeleccionarTodos.Focus();
        }
        else
        {
          int num2 = (int) MessageBox.Show("Precios Modificados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciFormulario();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Los Precios NO fueron Modificados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void modificaPrecio(ProductoVO pro)
    {
      try
      {
        new Producto().modificaPrecioProducto(pro);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Producto Codigo: " + pro.Codigo + ", Error al Modificar precio: " + ex.Message, "Error,", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciFormulario();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro/a de Eliminar los productos Seleccionados", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        int num1 = 0;
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvBuscaProductos.Rows)
        {
          if (Convert.ToBoolean(dataGridViewRow.Cells["Seleccionar"].Value))
          {
            this.eliminaProductos(dataGridViewRow.Cells["Codigo"].Value.ToString());
            ++num1;
          }
        }
        if (num1 == 0)
        {
          int num2 = (int) MessageBox.Show("Debe Seleccionar Productos a Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.chkSeleccionarTodos.Focus();
        }
        else
        {
          int num2 = (int) MessageBox.Show("Productos Eliminados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciFormulario();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Los Productos NO fueron Eliminados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void eliminaProductos(string cod)
    {
      try
      {
        new Producto().eliminaProducto(cod);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Producto Codigo: " + cod + ", Error al Eliminar: " + ex.Message, "Error,", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void frmMantenedorProductos_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modMaestroProducto = 0;
    }

    private void btnBodegaCero_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro/a de dejar en cero la " + this.cmbBodega.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      new Producto().modificaStockBodega(this.cmbBodega.SelectedValue.ToString());
      int num = (int) MessageBox.Show("El Stock de la " + this.cmbBodega.Text + " quedo en cero", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
      this.rdbCodigo = new RadioButton();
      this.groupBox1 = new GroupBox();
      this.btnGuardaCambioPrecio = new Button();
      this.btnCambiarPrecio = new Button();
      this.panel1 = new Panel();
      this.rdbBajar = new RadioButton();
      this.rdbSubir = new RadioButton();
      this.rdbCambiaPorcUtilidad = new RadioButton();
      this.rdbCambiaPorc = new RadioButton();
      this.label3 = new Label();
      this.txtPorcentaje = new TextBox();
      this.chkSeleccionarTodos = new CheckBox();
      this.btnLimpiar = new Button();
      this.groupBox2 = new GroupBox();
      this.btnEliminar = new Button();
      this.groupBox3 = new GroupBox();
      this.cmbBodega = new ComboBox();
      this.btnBodegaCero = new Button();
      ((ISupportInitialize) this.dgvBuscaProductos).BeginInit();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(496, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ingrese Producto a Buscar";
      this.txtDescripcion.Location = new Point(12, 27);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(496, 20);
      this.txtDescripcion.TabIndex = 1;
      this.txtDescripcion.KeyDown += new KeyEventHandler(this.txtDescripcion_KeyDown);
      this.cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbCategoria.FormattingEnabled = true;
      this.cmbCategoria.Location = new Point(512, 27);
      this.cmbCategoria.Name = "cmbCategoria";
      this.cmbCategoria.Size = new Size(182, 21);
      this.cmbCategoria.TabIndex = 2;
      this.cmbCategoria.SelectedValueChanged += new EventHandler(this.cmbCategoria_SelectedValueChanged);
      this.btnFiltrar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnFiltrar.Location = new Point(782, 9);
      this.btnFiltrar.Name = "btnFiltrar";
      this.btnFiltrar.Size = new Size(187, 38);
      this.btnFiltrar.TabIndex = 3;
      this.btnFiltrar.Text = "FILTRAR";
      this.btnFiltrar.UseVisualStyleBackColor = true;
      this.btnFiltrar.Click += new EventHandler(this.btnFiltrar_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(885, 486);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(92, 37);
      this.btnSalir.TabIndex = 4;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.Font = new Font("Verdana", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(512, 9);
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
      this.dgvBuscaProductos.Location = new Point(12, 78);
      this.dgvBuscaProductos.MultiSelect = false;
      this.dgvBuscaProductos.Name = "dgvBuscaProductos";
      this.dgvBuscaProductos.RowHeadersVisible = false;
      this.dgvBuscaProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvBuscaProductos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProductos.ScrollBars = ScrollBars.Vertical;
      this.dgvBuscaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaProductos.Size = new Size(772, 445);
      this.dgvBuscaProductos.TabIndex = 6;
      this.dgvBuscaProductos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaProductos_CellDoubleClick);
      this.dgvBuscaProductos.CellClick += new DataGridViewCellEventHandler(this.dgvBuscaProductos_CellClick);
      this.dgvBuscaProductos.KeyDown += new KeyEventHandler(this.dgvBuscaProductos_KeyDown);
      this.rdbDescripcion.AutoSize = true;
      this.rdbDescripcion.Location = new Point(15, 52);
      this.rdbDescripcion.Name = "rdbDescripcion";
      this.rdbDescripcion.Size = new Size(81, 17);
      this.rdbDescripcion.TabIndex = 7;
      this.rdbDescripcion.TabStop = true;
      this.rdbDescripcion.Text = "Descripcion";
      this.rdbDescripcion.UseVisualStyleBackColor = true;
      this.rdbCodigo.AutoSize = true;
      this.rdbCodigo.Location = new Point(100, 52);
      this.rdbCodigo.Name = "rdbCodigo";
      this.rdbCodigo.Size = new Size(58, 17);
      this.rdbCodigo.TabIndex = 9;
      this.rdbCodigo.TabStop = true;
      this.rdbCodigo.Text = "Codigo";
      this.rdbCodigo.UseVisualStyleBackColor = true;
      this.groupBox1.Controls.Add((Control) this.btnGuardaCambioPrecio);
      this.groupBox1.Controls.Add((Control) this.btnCambiarPrecio);
      this.groupBox1.Controls.Add((Control) this.panel1);
      this.groupBox1.Controls.Add((Control) this.rdbCambiaPorcUtilidad);
      this.groupBox1.Controls.Add((Control) this.rdbCambiaPorc);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.txtPorcentaje);
      this.groupBox1.Location = new Point(790, 73);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(179, 213);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Cambiar Precios";
      this.btnGuardaCambioPrecio.Location = new Point(6, 184);
      this.btnGuardaCambioPrecio.Name = "btnGuardaCambioPrecio";
      this.btnGuardaCambioPrecio.Size = new Size(164, 23);
      this.btnGuardaCambioPrecio.TabIndex = 13;
      this.btnGuardaCambioPrecio.Text = "Guardar Cambios";
      this.btnGuardaCambioPrecio.UseVisualStyleBackColor = true;
      this.btnGuardaCambioPrecio.Click += new EventHandler(this.btnGuardaCambioPrecio_Click);
      this.btnCambiarPrecio.Location = new Point(118, 30);
      this.btnCambiarPrecio.Name = "btnCambiarPrecio";
      this.btnCambiarPrecio.Size = new Size(53, 23);
      this.btnCambiarPrecio.TabIndex = 12;
      this.btnCambiarPrecio.Text = "Aplicar";
      this.btnCambiarPrecio.UseVisualStyleBackColor = true;
      this.btnCambiarPrecio.Click += new EventHandler(this.btnCambiarPrecio_Click);
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.rdbBajar);
      this.panel1.Controls.Add((Control) this.rdbSubir);
      this.panel1.Location = new Point(6, 59);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(165, 27);
      this.panel1.TabIndex = 11;
      this.rdbBajar.AutoSize = true;
      this.rdbBajar.Location = new Point(80, 3);
      this.rdbBajar.Name = "rdbBajar";
      this.rdbBajar.Size = new Size(49, 17);
      this.rdbBajar.TabIndex = 5;
      this.rdbBajar.TabStop = true;
      this.rdbBajar.Text = "Bajar";
      this.rdbBajar.UseVisualStyleBackColor = true;
      this.rdbSubir.AutoSize = true;
      this.rdbSubir.Location = new Point(3, 3);
      this.rdbSubir.Name = "rdbSubir";
      this.rdbSubir.Size = new Size(49, 17);
      this.rdbSubir.TabIndex = 4;
      this.rdbSubir.TabStop = true;
      this.rdbSubir.Text = "Subir";
      this.rdbSubir.UseVisualStyleBackColor = true;
      this.rdbCambiaPorcUtilidad.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.rdbCambiaPorcUtilidad.Location = new Point(6, 123);
      this.rdbCambiaPorcUtilidad.Name = "rdbCambiaPorcUtilidad";
      this.rdbCambiaPorcUtilidad.Size = new Size(165, 37);
      this.rdbCambiaPorcUtilidad.TabIndex = 3;
      this.rdbCambiaPorcUtilidad.TabStop = true;
      this.rdbCambiaPorcUtilidad.Text = "Cambiar Precio Venta % Utilidad";
      this.rdbCambiaPorcUtilidad.UseVisualStyleBackColor = true;
      this.rdbCambiaPorcUtilidad.CheckedChanged += new EventHandler(this.rdbCambiaPorcUtilidad_CheckedChanged);
      this.rdbCambiaPorc.AutoSize = true;
      this.rdbCambiaPorc.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.rdbCambiaPorc.Location = new Point(6, 100);
      this.rdbCambiaPorc.Name = "rdbCambiaPorc";
      this.rdbCambiaPorc.Size = new Size(160, 17);
      this.rdbCambiaPorc.TabIndex = 2;
      this.rdbCambiaPorc.TabStop = true;
      this.rdbCambiaPorc.Text = "Cambiar Precio Venta %";
      this.rdbCambiaPorc.UseVisualStyleBackColor = true;
      this.rdbCambiaPorc.CheckedChanged += new EventHandler(this.rdbCambiaPorc_CheckedChanged);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(92, 34);
      this.label3.Name = "label3";
      this.label3.Size = new Size(20, 16);
      this.label3.TabIndex = 1;
      this.label3.Text = "%";
      this.txtPorcentaje.Location = new Point(6, 32);
      this.txtPorcentaje.Name = "txtPorcentaje";
      this.txtPorcentaje.Size = new Size(83, 20);
      this.txtPorcentaje.TabIndex = 0;
      this.txtPorcentaje.KeyPress += new KeyPressEventHandler(this.txtPorcentaje_KeyPress);
      this.chkSeleccionarTodos.AutoSize = true;
      this.chkSeleccionarTodos.CheckAlign = ContentAlignment.MiddleRight;
      this.chkSeleccionarTodos.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkSeleccionarTodos.Location = new Point(633, 53);
      this.chkSeleccionarTodos.Name = "chkSeleccionarTodos";
      this.chkSeleccionarTodos.Size = new Size(145, 19);
      this.chkSeleccionarTodos.TabIndex = 11;
      this.chkSeleccionarTodos.Text = "Seleccionar Todos";
      this.chkSeleccionarTodos.UseVisualStyleBackColor = true;
      this.chkSeleccionarTodos.CheckedChanged += new EventHandler(this.chkSeleccionarTodos_CheckedChanged);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Location = new Point(790, 486);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(92, 37);
      this.btnLimpiar.TabIndex = 12;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.groupBox2.Controls.Add((Control) this.btnEliminar);
      this.groupBox2.Location = new Point(790, 287);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(179, 72);
      this.groupBox2.TabIndex = 13;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Eliminar Productos";
      this.btnEliminar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnEliminar.Location = new Point(7, 20);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(159, 43);
      this.btnEliminar.TabIndex = 0;
      this.btnEliminar.Text = "Eliminar Productos Seleccionados";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.groupBox3.Controls.Add((Control) this.btnBodegaCero);
      this.groupBox3.Controls.Add((Control) this.cmbBodega);
      this.groupBox3.Location = new Point(790, 365);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(179, 100);
      this.groupBox3.TabIndex = 14;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Bodegas en Cero";
      this.cmbBodega.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbBodega.FormattingEnabled = true;
      this.cmbBodega.Location = new Point(10, 27);
      this.cmbBodega.Name = "cmbBodega";
      this.cmbBodega.Size = new Size(156, 21);
      this.cmbBodega.TabIndex = 27;
      this.btnBodegaCero.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBodegaCero.Location = new Point(9, 64);
      this.btnBodegaCero.Name = "btnBodegaCero";
      this.btnBodegaCero.Size = new Size(159, 23);
      this.btnBodegaCero.TabIndex = 28;
      this.btnBodegaCero.Text = "Dejar Bodega en Cero";
      this.btnBodegaCero.UseVisualStyleBackColor = true;
      this.btnBodegaCero.Click += new EventHandler(this.btnBodegaCero_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1079, 590);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.chkSeleccionarTodos);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.rdbCodigo);
      this.Controls.Add((Control) this.rdbDescripcion);
      this.Controls.Add((Control) this.dgvBuscaProductos);
      this.Controls.Add((Control) this.cmbCategoria);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.txtDescripcion);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnFiltrar);
      this.Controls.Add((Control) this.label1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "frmMantenedorDeProductos";
      this.ShowIcon = false;
      this.Text = "Mantenedor de Productos";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmMantenedorProductos_FormClosing);
      ((ISupportInitialize) this.dgvBuscaProductos).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
