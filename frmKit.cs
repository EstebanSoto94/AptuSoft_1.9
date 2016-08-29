 
// Type: Aptusoft.frmKit
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmKit : Form
  {
    private List<KitVO> lista = new List<KitVO>();
    private string linea = "";
    private IContainer components = (IContainer) null;
    private frmKit intance;
    private GroupBox groupBox1;
    private TextBox txtDescripcionKit;
    private TextBox txtCodigoKit;
    private Label label2;
    private Label label1;
    private TextBox txtCodigo;
    private TextBox txtDescripcion;
    private TextBox txtCantidad;
    private Button button1;
    private DataGridView dgvDatosVenta;
    private Label label3;
    private Label label4;
    private Label label5;
    private Button btnLimpiarGrilla;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnSalir;
    private Panel panel1;
    private Button btnLimpiar;
    private Button btnModificaLinea;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem;
    private ToolStripMenuItem buscarProductoF4ToolStripMenuItem;

    public frmKit()
    {
      this.InitializeComponent();
      this.intance = this;
      this.creaColumnasDetalle();
      this.iniciaFormulario();
    }

    private void iniciaFormulario()
    {
      this.txtCodigoKit.Enabled = true;
      this.txtCodigoKit.Clear();
      this.txtDescripcionKit.Clear();
      this.txtCodigoKit.Focus();
      this.lista.Clear();
      this.dgvDatosVenta.DataSource = (object) null;
      this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.limpiaDetalle();
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
      this.dgvDatosVenta.Columns[1].DataPropertyName = "CodigoProductoDetalle";
      this.dgvDatosVenta.Columns[1].Width = 100;
      this.dgvDatosVenta.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Descripcion", "Descripcion");
      this.dgvDatosVenta.Columns[2].DataPropertyName = "Descripcion";
      this.dgvDatosVenta.Columns[2].Width = 200;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns.Add("Cantidad", "Cantidad");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "Cantidad";
      this.dgvDatosVenta.Columns[3].Width = 80;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Format = "N4";
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Eliminar";
      viewButtonColumn.HeaderText = "Eliminar";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "X";
      viewButtonColumn.Width = 50;
      viewButtonColumn.DisplayIndex = 4;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewButtonColumn);
      this.dgvDatosVenta.Columns.Add("IdKit", "IdKit");
      this.dgvDatosVenta.Columns[5].DataPropertyName = "IdKit";
      this.dgvDatosVenta.Columns[5].Width = 80;
      this.dgvDatosVenta.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[5].Visible = false;
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

    private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidad);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      this.agregaLineaGrilla();
    }

    private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13 || this.txtCodigo.Text.Length <= 0)
        return;
      e.Handled = false;
      this.llamaProductoCodigo(this.txtCodigo.Text.Trim());
    }

    public void llamaProductoCodigo(string cod)
    {
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
      if (!this.txtCodigoKit.Enabled)
      {
        if (productoVo.Codigo != null)
        {
          this.txtCodigo.Text = productoVo.Codigo;
          this.txtDescripcion.Text = productoVo.Descripcion;
          this.txtCantidad.Focus();
        }
        else
        {
          int num = (int) MessageBox.Show("No Existe el Codigo Ingresado.");
          this.limpiaDetalle();
        }
      }
      else if (productoVo.Codigo == null)
      {
        int num = (int) MessageBox.Show("El Producto No Existe");
        this.txtCodigoKit.Focus();
      }
      else
      {
        this.txtCodigoKit.Text = productoVo.Codigo;
        this.txtDescripcionKit.Text = productoVo.Descripcion;
        this.txtCodigoKit.Enabled = false;
        this.txtDescripcionKit.Enabled = false;
        this.buscaKid(this.txtCodigoKit.Text.Trim());
        this.txtCodigo.Focus();
      }
    }

    private void limpiaDetalle()
    {
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      this.txtCantidad.Clear();
      this.txtCodigo.Focus();
      this.btnModificaLinea.Visible = false;
      this.button1.Enabled = true;
      this.btnLimpiarGrilla.Enabled = true;
    }

    public void cantidad()
    {
      this.txtCantidad.Text = "1";
    }

    public void agregaLineaGrilla()
    {
      if (this.txtCodigo.Text.Length > 0 && this.txtCantidad.Text.Length > 0)
      {
        this.lista.Add(new KitVO()
        {
          CodigoProductoKit = this.txtCodigoKit.Text.Trim().ToUpper(),
          CodigoProductoDetalle = this.txtCodigo.Text.Trim().ToUpper(),
          Descripcion = this.txtDescripcion.Text.Trim().ToUpper(),
          Cantidad = Convert.ToDecimal(this.txtCantidad.Text)
        });
        this.limpiaDetalle();
        this.cargaGrilla();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe llamar a un Productos");
        this.txtCodigo.Focus();
      }
    }

    private void cargaGrilla()
    {
      for (int index = 0; index < this.lista.Count; ++index)
        this.lista[index].Linea = index + 1;
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.agregaLineaGrilla();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      this.Dispose();
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
      this.cargaGrilla();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      Kit kit = new Kit();
      if (!this.valida())
        return;
      try
      {
        kit.guardaKit(this.lista);
        new Producto().cambiaEstadoKit(this.txtCodigoKit.Text.Trim(), true);
        int num = (int) MessageBox.Show("Kit Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message);
      }
    }

    private bool valida()
    {
      if (this.lista.Count == 0)
      {
        int num = (int) MessageBox.Show("Debe Agregar productos");
        this.txtCodigo.Focus();
        return false;
      }
      if (this.txtCodigoKit.Text.Trim().Length != 0)
        return true;
      this.Close();
      return false;
    }

    private void btnLimpiarGrilla_Click(object sender, EventArgs e)
    {
      this.lista.Clear();
      this.dgvDatosVenta.DataSource = (object) null;
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Modificar este Kit", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      Kit kit = new Kit();
      try
      {
        kit.eliminaKit(this.txtCodigoKit.Text.Trim().ToUpper());
        kit.guardaKit(this.lista);
        int num = (int) MessageBox.Show("Kit Modificado");
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Modificar Kit " + ex.Message);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar este Kit", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      Kit kit = new Kit();
      try
      {
        kit.eliminaKit(this.txtCodigoKit.Text.Trim().ToUpper());
        int num = (int) MessageBox.Show("Kit Eliminado");
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Eliminar Kit " + ex.Message);
      }
    }

    private void txtCodigoKit_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtCodigoKit.Text.Trim().Length > 0)
        this.llamaProductoCodigo(this.txtCodigoKit.Text.Trim());
    }

    private void buscaKid(string cod)
    {
      this.lista = new Kit().buscaKitCodigoKit(cod);
      if (this.lista.Count <= 0)
        return;
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = true;
      this.btnEliminar.Enabled = true;
      this.cargaGrilla();
      this.txtCodigo.Focus();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void dgvDatosVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.txtCodigo.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Codigo"].Value.ToString();
      this.txtDescripcion.Text = this.dgvDatosVenta.SelectedRows[0].Cells["Descripcion"].Value.ToString();
      this.txtCantidad.Text = this.verificaDecimales(this.dgvDatosVenta.SelectedRows[0].Cells["Cantidad"].Value.ToString());
      this.linea = this.dgvDatosVenta.SelectedRows[0].Cells["Linea"].Value.ToString();
      this.btnModificaLinea.Visible = true;
      this.button1.Enabled = false;
      this.btnLimpiarGrilla.Enabled = false;
    }

    private void modificaLinea()
    {
      for (int index = 0; index < this.lista.Count; ++index)
      {
        if (this.lista[index].Linea == Convert.ToInt32(this.linea))
        {
          this.lista[index].CodigoProductoDetalle = this.txtCodigo.Text;
          this.lista[index].Descripcion = this.txtDescripcion.Text;
          this.lista[index].Cantidad = Convert.ToDecimal(this.txtCantidad.Text);
        }
      }
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
      this.limpiaDetalle();
    }

    private void btnModificaLinea_Click(object sender, EventArgs e)
    {
      this.modificaLinea();
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

    private void frmKit_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.F4)
        return;
      int num = (int) new frmBuscaProductos("kit", ref this.intance).ShowDialog();
      this.txtCantidad.Focus();
    }

    private void buscarProductoF4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaProductos("kit", ref this.intance).ShowDialog();
      this.txtCantidad.Focus();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmKit));
      this.groupBox1 = new GroupBox();
      this.txtDescripcionKit = new TextBox();
      this.txtCodigoKit = new TextBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.txtCodigo = new TextBox();
      this.txtDescripcion = new TextBox();
      this.txtCantidad = new TextBox();
      this.button1 = new Button();
      this.dgvDatosVenta = new DataGridView();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.btnLimpiarGrilla = new Button();
      this.btnGuardar = new Button();
      this.btnModificar = new Button();
      this.btnEliminar = new Button();
      this.btnSalir = new Button();
      this.panel1 = new Panel();
      this.btnModificaLinea = new Button();
      this.btnLimpiar = new Button();
      this.menuStrip1 = new MenuStrip();
      this.archivoToolStripMenuItem = new ToolStripMenuItem();
      this.buscarProductoF4ToolStripMenuItem = new ToolStripMenuItem();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvDatosVenta).BeginInit();
      this.panel1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.txtDescripcionKit);
      this.groupBox1.Controls.Add((Control) this.txtCodigoKit);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(11, 32);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(480, 60);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Producto Kit";
      this.txtDescripcionKit.BackColor = Color.White;
      this.txtDescripcionKit.Location = new Point(112, 30);
      this.txtDescripcionKit.Name = "txtDescripcionKit";
      this.txtDescripcionKit.ReadOnly = true;
      this.txtDescripcionKit.Size = new Size(361, 20);
      this.txtDescripcionKit.TabIndex = 3;
      this.txtCodigoKit.BackColor = Color.White;
      this.txtCodigoKit.Location = new Point(7, 30);
      this.txtCodigoKit.Name = "txtCodigoKit";
      this.txtCodigoKit.Size = new Size(100, 20);
      this.txtCodigoKit.TabIndex = 2;
      this.txtCodigoKit.KeyPress += new KeyPressEventHandler(this.txtCodigoKit_KeyPress);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(112, 12);
      this.label2.Name = "label2";
      this.label2.Size = new Size(83, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "Descripción";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(8, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(52, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Codigo";
      this.txtCodigo.Location = new Point(9, 21);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new Size(100, 20);
      this.txtCodigo.TabIndex = 1;
      this.txtCodigo.KeyPress += new KeyPressEventHandler(this.txtCodigo_KeyPress);
      this.txtDescripcion.BackColor = Color.White;
      this.txtDescripcion.Enabled = false;
      this.txtDescripcion.Location = new Point(112, 21);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(281, 20);
      this.txtDescripcion.TabIndex = 2;
      this.txtCantidad.Location = new Point(399, 21);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new Size(74, 20);
      this.txtCantidad.TabIndex = 3;
      this.txtCantidad.KeyPress += new KeyPressEventHandler(this.txtCantidad_KeyPress);
      this.button1.Location = new Point(320, 44);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Agregar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.dgvDatosVenta.AllowUserToAddRows = false;
      this.dgvDatosVenta.AllowUserToDeleteRows = false;
      this.dgvDatosVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatosVenta.Location = new Point(13, 173);
      this.dgvDatosVenta.Name = "dgvDatosVenta";
      this.dgvDatosVenta.ReadOnly = true;
      this.dgvDatosVenta.RowHeadersVisible = false;
      this.dgvDatosVenta.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatosVenta.Size = new Size(476, 220);
      this.dgvDatosVenta.TabIndex = 5;
      this.dgvDatosVenta.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellDoubleClick);
      this.dgvDatosVenta.CellClick += new DataGridViewCellEventHandler(this.dgvDatosVenta_CellClick);
      this.label3.BackColor = Color.FromArgb(64, 64, 64);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(9, 5);
      this.label3.Name = "label3";
      this.label3.Size = new Size(100, 16);
      this.label3.TabIndex = 4;
      this.label3.Text = "Codigo";
      this.label4.BackColor = Color.FromArgb(64, 64, 64);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(113, 5);
      this.label4.Name = "label4";
      this.label4.Size = new Size(280, 16);
      this.label4.TabIndex = 6;
      this.label4.Text = "Descripción";
      this.label5.BackColor = Color.FromArgb(64, 64, 64);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(399, 5);
      this.label5.Name = "label5";
      this.label5.Size = new Size(73, 16);
      this.label5.TabIndex = 7;
      this.label5.Text = "Cantidad";
      this.btnLimpiarGrilla.Location = new Point(397, 44);
      this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
      this.btnLimpiarGrilla.Size = new Size(75, 23);
      this.btnLimpiarGrilla.TabIndex = 8;
      this.btnLimpiarGrilla.Text = "Limpiar";
      this.btnLimpiarGrilla.UseVisualStyleBackColor = true;
      this.btnLimpiarGrilla.Click += new EventHandler(this.btnLimpiarGrilla_Click);
      this.btnGuardar.Location = new Point(15, 398);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 49);
      this.btnGuardar.TabIndex = 9;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnModificar.Location = new Point(96, 398);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 49);
      this.btnModificar.TabIndex = 10;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnEliminar.Location = new Point(177, 398);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(75, 49);
      this.btnEliminar.TabIndex = 11;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnSalir.Location = new Point(416, 399);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 49);
      this.btnSalir.TabIndex = 12;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.btnModificaLinea);
      this.panel1.Controls.Add((Control) this.txtCodigo);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.txtDescripcion);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.btnLimpiarGrilla);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.txtCantidad);
      this.panel1.Location = new Point(10, 96);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(481, 73);
      this.panel1.TabIndex = 14;
      this.btnModificaLinea.Location = new Point(243, 44);
      this.btnModificaLinea.Name = "btnModificaLinea";
      this.btnModificaLinea.Size = new Size(75, 23);
      this.btnModificaLinea.TabIndex = 9;
      this.btnModificaLinea.Text = "Modifica";
      this.btnModificaLinea.UseVisualStyleBackColor = true;
      this.btnModificaLinea.Click += new EventHandler(this.btnModificaLinea_Click);
      this.btnLimpiar.Location = new Point(258, 398);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 49);
      this.btnLimpiar.TabIndex = 15;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.menuStrip1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.archivoToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(502, 24);
      this.menuStrip1.TabIndex = 16;
      this.menuStrip1.Text = "menuStrip1";
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.buscarProductoF4ToolStripMenuItem
      });
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new Size(60, 20);
      this.archivoToolStripMenuItem.Text = "Archivo";
      this.buscarProductoF4ToolStripMenuItem.Name = "buscarProductoF4ToolStripMenuItem";
      this.buscarProductoF4ToolStripMenuItem.Size = new Size(222, 22);
      this.buscarProductoF4ToolStripMenuItem.Text = "Buscar Productos - tecla[F4]";
      this.buscarProductoF4ToolStripMenuItem.Click += new EventHandler(this.buscarProductoF4ToolStripMenuItem_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(502, 454);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnEliminar);
      this.Controls.Add((Control) this.btnModificar);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.dgvDatosVenta);
///      this.FormBorderStyle = FormBorderStyle.FixedSingle;
//      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "frmKit";
      this.ShowIcon = false;
      this.Text = "Modulo Creación de  Kit";
      this.KeyDown += new KeyEventHandler(this.frmKit_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.dgvDatosVenta).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
