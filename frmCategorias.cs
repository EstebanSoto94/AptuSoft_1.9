 
// Type: Aptusoft.frmCategorias
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmCategorias : Form
  {
    private IContainer components = (IContainer) null;
    private int _idSubCategoria = 0;
    private string _nombreCategoria = "";
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private GroupBox groupBox1;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnEliminar;
    private Button btnModificar;
    private Button btnGuardar;
    private Label label1;
    private TextBox txtCategoria;
    private DataGridView dgvCategorias;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Descripcion;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TextBox txtNombreSubCategoria;
    private Label label2;
    private DataGridView dgvSubCategoria;
    private Label label3;
    private DataGridView dgvCategoriaEnSub;
    private DataGridViewTextBoxColumn IdCategoria;
    private DataGridViewTextBoxColumn DescripcionCategoria;
    private TextBox txtCategoriaEnSubCategoria;
    private Button btnGuardaSubCategoria;
    private DataGridViewTextBoxColumn idSubCategoria;
    private DataGridViewTextBoxColumn nombreSubCategoria;
    private DataGridViewTextBoxColumn idCategoriaEnSub;
    private DataGridViewTextBoxColumn nombrecategoriaEnSub;
    private DataGridViewButtonColumn Elimina;
    private int _idCategoria;

    public frmCategorias()
    {
      this.InitializeComponent();
      this.dgvCategoriaEnSub.AutoGenerateColumns = false;
      this.dgvSubCategoria.AutoGenerateColumns = false;
      this.cargaPermisos();
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
      this.groupBox1 = new GroupBox();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.btnGuardar = new Button();
      this.label1 = new Label();
      this.txtCategoria = new TextBox();
      this.dgvCategorias = new DataGridView();
      this.Id = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.txtNombreSubCategoria = new TextBox();
      this.label2 = new Label();
      this.dgvSubCategoria = new DataGridView();
      this.label3 = new Label();
      this.dgvCategoriaEnSub = new DataGridView();
      this.IdCategoria = new DataGridViewTextBoxColumn();
      this.DescripcionCategoria = new DataGridViewTextBoxColumn();
      this.txtCategoriaEnSubCategoria = new TextBox();
      this.btnGuardaSubCategoria = new Button();
      this.idSubCategoria = new DataGridViewTextBoxColumn();
      this.nombreSubCategoria = new DataGridViewTextBoxColumn();
      this.idCategoriaEnSub = new DataGridViewTextBoxColumn();
      this.nombrecategoriaEnSub = new DataGridViewTextBoxColumn();
      this.Elimina = new DataGridViewButtonColumn();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvCategorias).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((ISupportInitialize) this.dgvSubCategoria).BeginInit();
      ((ISupportInitialize) this.dgvCategoriaEnSub).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.btnSalir);
      this.groupBox1.Controls.Add((Control) this.btnLimpiar);
      this.groupBox1.Controls.Add((Control) this.btnEliminar);
      this.groupBox1.Controls.Add((Control) this.btnModificar);
      this.groupBox1.Controls.Add((Control) this.btnGuardar);
      this.groupBox1.Location = new Point(459, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(91, 434);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(6, 365);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 59);
      this.btnSalir.TabIndex = 4;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Location = new Point(6, 292);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 59);
      this.btnLimpiar.TabIndex = 3;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnEliminar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnEliminar.Location = new Point(6, 227);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(75, 59);
      this.btnEliminar.TabIndex = 2;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnModificar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnModificar.Location = new Point(6, 162);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 59);
      this.btnModificar.TabIndex = 1;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnGuardar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Location = new Point(6, 97);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 59);
      this.btnGuardar.TabIndex = 0;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new Point(6, 11);
      this.label1.Name = "label1";
      this.label1.Size = new Size(69, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Categoria";
      this.txtCategoria.CharacterCasing = CharacterCasing.Upper;
      this.txtCategoria.Location = new Point(6, 31);
      this.txtCategoria.Name = "txtCategoria";
      this.txtCategoria.Size = new Size(351, 20);
      this.txtCategoria.TabIndex = 2;
      this.txtCategoria.TextChanged += new EventHandler(this.txtCategoria_TextChanged);
      this.txtCategoria.KeyPress += new KeyPressEventHandler(this.txtCategoria_KeyPress);
      this.txtCategoria.Leave += new EventHandler(this.txtCategoria_Leave);
      this.dgvCategorias.AllowUserToAddRows = false;
      this.dgvCategorias.AllowUserToDeleteRows = false;
      this.dgvCategorias.AllowUserToResizeColumns = false;
      this.dgvCategorias.AllowUserToResizeRows = false;
      gridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
      this.dgvCategorias.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvCategorias.BackgroundColor = Color.LightSteelBlue;
      this.dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvCategorias.Columns.AddRange((DataGridViewColumn) this.Id, (DataGridViewColumn) this.Descripcion);
      this.dgvCategorias.Location = new Point(6, 60);
      this.dgvCategorias.Name = "dgvCategorias";
      this.dgvCategorias.ReadOnly = true;
      this.dgvCategorias.RowHeadersWidth = 50;
      this.dgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvCategorias.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvCategorias.ScrollBars = ScrollBars.Vertical;
      this.dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvCategorias.Size = new Size(351, 338);
      this.dgvCategorias.TabIndex = 3;
      this.dgvCategorias.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dgvCategorias_ColumnHeaderMouseClick);
      this.dgvCategorias.DoubleClick += new EventHandler(this.dgvCategorias_DoubleClick);
      this.Id.DataPropertyName = "Id";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Resizable = DataGridViewTriState.False;
      this.Id.Visible = false;
      this.Descripcion.DataPropertyName = "DescCategoria";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      this.Descripcion.Resizable = DataGridViewTriState.False;
      this.Descripcion.Width = 350;
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(428, 434);
      this.tabControl1.TabIndex = 4;
      this.tabPage1.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage1.Controls.Add((Control) this.label1);
      this.tabPage1.Controls.Add((Control) this.dgvCategorias);
      this.tabPage1.Controls.Add((Control) this.txtCategoria);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(420, 408);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Categorias";
      this.tabPage2.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage2.Controls.Add((Control) this.btnGuardaSubCategoria);
      this.tabPage2.Controls.Add((Control) this.txtCategoriaEnSubCategoria);
      this.tabPage2.Controls.Add((Control) this.txtNombreSubCategoria);
      this.tabPage2.Controls.Add((Control) this.label2);
      this.tabPage2.Controls.Add((Control) this.dgvSubCategoria);
      this.tabPage2.Controls.Add((Control) this.label3);
      this.tabPage2.Controls.Add((Control) this.dgvCategoriaEnSub);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(420, 408);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "SubCategorias";
      this.txtNombreSubCategoria.CharacterCasing = CharacterCasing.Upper;
      this.txtNombreSubCategoria.Location = new Point(204, 67);
      this.txtNombreSubCategoria.Name = "txtNombreSubCategoria";
      this.txtNombreSubCategoria.Size = new Size(210, 20);
      this.txtNombreSubCategoria.TabIndex = 9;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(201, 49);
      this.label2.Name = "label2";
      this.label2.Size = new Size(98, 15);
      this.label2.TabIndex = 8;
      this.label2.Text = "Sub Categoria";
      this.dgvSubCategoria.AllowUserToAddRows = false;
      this.dgvSubCategoria.AllowUserToDeleteRows = false;
      this.dgvSubCategoria.AllowUserToResizeColumns = false;
      this.dgvSubCategoria.AllowUserToResizeRows = false;
      gridViewCellStyle2.BackColor = Color.Lavender;
      this.dgvSubCategoria.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.dgvSubCategoria.BackgroundColor = Color.PapayaWhip;
      this.dgvSubCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSubCategoria.Columns.AddRange((DataGridViewColumn) this.idSubCategoria, (DataGridViewColumn) this.nombreSubCategoria, (DataGridViewColumn) this.idCategoriaEnSub, (DataGridViewColumn) this.nombrecategoriaEnSub, (DataGridViewColumn) this.Elimina);
      this.dgvSubCategoria.Location = new Point(204, 116);
      this.dgvSubCategoria.Name = "dgvSubCategoria";
      this.dgvSubCategoria.ReadOnly = true;
      this.dgvSubCategoria.RowHeadersVisible = false;
      this.dgvSubCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvSubCategoria.Size = new Size(210, 286);
      this.dgvSubCategoria.TabIndex = 7;
      this.dgvSubCategoria.CellClick += new DataGridViewCellEventHandler(this.dgvSubCategoria_CellClick);
      this.dgvSubCategoria.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvSubCategoria_CellDoubleClick);
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(6, 4);
      this.label3.Name = "label3";
      this.label3.Size = new Size(76, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "Categorias";
      this.dgvCategoriaEnSub.AllowUserToAddRows = false;
      this.dgvCategoriaEnSub.AllowUserToDeleteRows = false;
      this.dgvCategoriaEnSub.AllowUserToResizeColumns = false;
      this.dgvCategoriaEnSub.AllowUserToResizeRows = false;
      gridViewCellStyle3.BackColor = Color.Lavender;
      this.dgvCategoriaEnSub.AlternatingRowsDefaultCellStyle = gridViewCellStyle3;
      this.dgvCategoriaEnSub.BackgroundColor = Color.LightSteelBlue;
      this.dgvCategoriaEnSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCategoriaEnSub.Columns.AddRange((DataGridViewColumn) this.IdCategoria, (DataGridViewColumn) this.DescripcionCategoria);
      this.dgvCategoriaEnSub.Location = new Point(6, 23);
      this.dgvCategoriaEnSub.Name = "dgvCategoriaEnSub";
      this.dgvCategoriaEnSub.ReadOnly = true;
      this.dgvCategoriaEnSub.RowHeadersVisible = false;
      this.dgvCategoriaEnSub.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvCategoriaEnSub.Size = new Size(189, 379);
      this.dgvCategoriaEnSub.TabIndex = 5;
      this.dgvCategoriaEnSub.CellClick += new DataGridViewCellEventHandler(this.dgvCategoriaEnSub_CellClick);
      this.IdCategoria.DataPropertyName = "ID";
      this.IdCategoria.HeaderText = "IdCategoria";
      this.IdCategoria.Name = "IdCategoria";
      this.IdCategoria.ReadOnly = true;
      this.IdCategoria.Visible = false;
      this.IdCategoria.Width = 30;
      this.DescripcionCategoria.DataPropertyName = "DescCategoria";
      this.DescripcionCategoria.HeaderText = "Descripcion";
      this.DescripcionCategoria.Name = "DescripcionCategoria";
      this.DescripcionCategoria.ReadOnly = true;
      this.DescripcionCategoria.Width = 180;
      this.txtCategoriaEnSubCategoria.BackColor = Color.Bisque;
      this.txtCategoriaEnSubCategoria.BorderStyle = BorderStyle.FixedSingle;
      this.txtCategoriaEnSubCategoria.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCategoriaEnSubCategoria.Location = new Point(204, 23);
      this.txtCategoriaEnSubCategoria.Name = "txtCategoriaEnSubCategoria";
      this.txtCategoriaEnSubCategoria.ReadOnly = true;
      this.txtCategoriaEnSubCategoria.Size = new Size(210, 21);
      this.txtCategoriaEnSubCategoria.TabIndex = 10;
      this.btnGuardaSubCategoria.Location = new Point(351, 90);
      this.btnGuardaSubCategoria.Name = "btnGuardaSubCategoria";
      this.btnGuardaSubCategoria.Size = new Size(60, 23);
      this.btnGuardaSubCategoria.TabIndex = 11;
      this.btnGuardaSubCategoria.Text = "Guarda";
      this.btnGuardaSubCategoria.UseVisualStyleBackColor = true;
      this.btnGuardaSubCategoria.Click += new EventHandler(this.btnGuardaSubCategoria_Click);
      this.idSubCategoria.DataPropertyName = "idSubCategoria";
      this.idSubCategoria.HeaderText = "idSubCategoria";
      this.idSubCategoria.Name = "idSubCategoria";
      this.idSubCategoria.ReadOnly = true;
      this.idSubCategoria.Visible = false;
      this.nombreSubCategoria.DataPropertyName = "nombreSubCategoria";
      this.nombreSubCategoria.HeaderText = "SubCategoria";
      this.nombreSubCategoria.Name = "nombreSubCategoria";
      this.nombreSubCategoria.ReadOnly = true;
      this.nombreSubCategoria.Width = 165;
      this.idCategoriaEnSub.DataPropertyName = "idCategoria";
      this.idCategoriaEnSub.HeaderText = "idCategoriaEnSub";
      this.idCategoriaEnSub.Name = "idCategoriaEnSub";
      this.idCategoriaEnSub.ReadOnly = true;
      this.idCategoriaEnSub.Visible = false;
      this.nombrecategoriaEnSub.DataPropertyName = "nombreCategoria";
      this.nombrecategoriaEnSub.HeaderText = "nombrecategoriaEnSub";
      this.nombrecategoriaEnSub.Name = "nombrecategoriaEnSub";
      this.nombrecategoriaEnSub.ReadOnly = true;
      this.nombrecategoriaEnSub.Visible = false;
      this.Elimina.HeaderText = "";
      this.Elimina.Name = "Elimina";
      this.Elimina.ReadOnly = true;
      this.Elimina.Text = "X";
      this.Elimina.UseColumnTextForButtonValue = true;
      this.Elimina.Width = 30;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(558, 454);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.groupBox1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmCategorias";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Modulo Categorias";
      this.FormClosing += new FormClosingEventHandler(this.frmCategorias_FormClosing);
      this.Load += new EventHandler(this.frmCategorias_Load);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvCategorias).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((ISupportInitialize) this.dgvSubCategoria).EndInit();
      ((ISupportInitialize) this.dgvCategoriaEnSub).EndInit();
      this.ResumeLayout(false);
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("CATEGORIA"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    private void numFila()
    {
      if (this.dgvCategorias.Rows.Count <= 0)
        return;
      for (int index = 0; index < this.dgvCategorias.Rows.Count; ++index)
        this.dgvCategorias.Rows[index].HeaderCell.Value = (object) (index + 1).ToString();
    }

    public void iniciaCategoria()
    {
      Categoria categoria = new Categoria();
      this.dgvCategorias.DataSource = (object) categoria.cosultaCategoria().Tables[0];
      this.dgvCategoriaEnSub.DataSource = (object) categoria.cosultaCategoria().Tables[0];
      this.dgvSubCategoria.DataSource = (object) null;
      this.numFila();
      this.txtCategoria.Clear();
      this.txtCategoria.Focus();
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this._nombreCategoria = "";
      this.txtCategoriaEnSubCategoria.Clear();
      this.txtNombreSubCategoria.Clear();
      this._idSubCategoria = 0;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modCategoria = 0;
      this.Close();
      this.Dispose();
    }

    private void frmCategorias_Load(object sender, EventArgs e)
    {
      this.iniciaCategoria();
    }

    private void txtCategoria_Leave(object sender, EventArgs e)
    {
      this.txtCategoria.Text = this.txtCategoria.Text.Trim().ToUpper();
    }

    private void guardaCategoria()
    {
      Categoria categoria = new Categoria();
      try
      {
        categoria.agregaCategoria(this.txtCategoria.Text.Trim());
        int num = (int) MessageBox.Show("Categoria Guardada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaCategoria();
      }
      catch (MySqlException ex)
      {
        int num = (int) MessageBox.Show("Error :" + ((Exception) ex).Message);
      }
    }

    public void buscaFila()
    {
      this.txtCategoria.Text = this.txtCategoria.Text.Trim().ToUpper();
      string str = this.txtCategoria.Text.Trim().ToString();
      for (int index = 0; index < this.dgvCategorias.Rows.Count; ++index)
      {
        if (str.Equals(this.dgvCategorias.Rows[index].Cells[1].Value.ToString()))
        {
          this._idCategoria = Convert.ToInt32(this.dgvCategorias.Rows[index].Cells[0].Value.ToString());
          this.dgvCategorias.CurrentCell = this.dgvCategorias[1, index];
        }
      }
    }

    private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (new Categoria().buscaCategoriaDesc(this.txtCategoria.Text.Trim()))
      {
        this.buscaFila();
        int num = (int) MessageBox.Show("Esta Categoria Ya Existe!!", "Advertencia");
        this.txtCategoria.Focus();
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
      }
      else
        this.guardaCategoria();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (new Categoria().buscaCategoriaDesc(this.txtCategoria.Text.Trim()) && this.btnGuardar.Enabled)
      {
        int num = (int) MessageBox.Show("Esta Categoria Ya Existe!!", "Advertencia");
        this.txtCategoria.Focus();
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (!this._modifica)
          return;
        this.btnModificar.Enabled = true;
      }
      else if (this.txtCategoria.Text.Trim().Length > 0)
      {
        this.guardaCategoria();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe ingresar un Nombre de Categoria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCategoria.Focus();
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      this.txtCategoria.Text = this.txtCategoria.Text.Trim().ToUpper();
      if (this.txtCategoria.Text.Trim().Length > 0)
      {
        CategoriaVO categoria1 = new CategoriaVO();
        categoria1.IdCategoria = this._idCategoria;
        categoria1.Descripcion = this.txtCategoria.Text.Trim();
        Categoria categoria2 = new Categoria();
        Categoria categoria3 = new Categoria();
        categoria3.actualizaCategoria(categoria1);
        categoria3.modificaCategoriaEnProductos(this.txtCategoria.Text.Trim(), this._nombreCategoria);
        int num = (int) MessageBox.Show("categoria actualizada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaCategoria();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe ingresar un Nombre de Categoria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCategoria.Focus();
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar la Categoria", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      Categoria categoria1 = new Categoria();
      Categoria categoria2 = new Categoria();
      int num1 = categoria2.hayProductosEnCategoria(this._idCategoria);
      if (num1 == 0)
      {
        categoria2.eliminaCategoria(this._idCategoria);
        int num2 = (int) MessageBox.Show("Categoria Eliminada", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaCategoria();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Existen [" + num1.ToString() + "] Articulos Asociados a Esta Categoria, No se puede Eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaCategoria();
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaCategoria();
    }

    public void buscaCategoriaDGV()
    {
      int rowIndex = this.dgvCategorias.CurrentCell.RowIndex;
      this._idCategoria = Convert.ToInt32(this.dgvCategorias.Rows[rowIndex].Cells[0].Value.ToString());
      this._nombreCategoria = this.dgvCategorias.Rows[rowIndex].Cells[1].Value.ToString();
      this.txtCategoria.Text = this.dgvCategorias.Rows[rowIndex].Cells[1].Value.ToString();
      this.txtCategoria.Focus();
      this.btnGuardar.Enabled = false;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      if (!this._modifica)
        return;
      this.btnModificar.Enabled = true;
    }

    private void dgvCategorias_DoubleClick(object sender, EventArgs e)
    {
      this.buscaCategoriaDGV();
    }

    private void dgvCategorias_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      this.numFila();
    }

    private void frmCategorias_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modCategoria = 0;
    }

    private void txtCategoria_TextChanged(object sender, EventArgs e)
    {
      if (this.txtCategoria.Text.Length > 0 && !this.btnModificar.Enabled)
      {
        if (this._guarda)
          this.btnGuardar.Enabled = true;
        else
          this.btnGuardar.Enabled = false;
      }
      else
        this.btnGuardar.Enabled = false;
    }

    private void dgvCategoriaEnSub_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      this._idCategoria = Convert.ToInt32(this.dgvCategoriaEnSub.SelectedRows[0].Cells["IdCategoria"].Value.ToString());
      this.txtCategoriaEnSubCategoria.Text = this.dgvCategoriaEnSub.SelectedRows[0].Cells["DescripcionCategoria"].Value.ToString();
      this.cargaSubCategorias();
    }

    private void btnGuardaSubCategoria_Click(object sender, EventArgs e)
    {
      CategoriaVO ca = new CategoriaVO();
      if (this._idSubCategoria == 0)
      {
        ca.DescripcionSubCategoria = this.txtNombreSubCategoria.Text.Trim();
        ca.IdCategoria = this._idCategoria;
        ca.Descripcion = this.txtCategoriaEnSubCategoria.Text.Trim();
        new Categoria().agregaSubCategoria(ca);
        int num = (int) MessageBox.Show("Sub categoria Agregada", "Guarda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.cargaSubCategorias();
        this.txtNombreSubCategoria.Clear();
        this.txtNombreSubCategoria.Focus();
        this._idSubCategoria = 0;
      }
      else
      {
        ca.IdSubCategoria = this._idSubCategoria;
        ca.DescripcionSubCategoria = this.txtNombreSubCategoria.Text.Trim();
        new Categoria().modificaSubCategoria(ca);
        int num = (int) MessageBox.Show("Sub categoria Modificada", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.cargaSubCategorias();
        this.txtNombreSubCategoria.Clear();
        this.txtNombreSubCategoria.Focus();
        this._idSubCategoria = 0;
      }
    }

    private void cargaSubCategorias()
    {
      this.dgvSubCategoria.DataSource = (object) null;
      this.dgvSubCategoria.DataSource = (object) new Categoria().listaSubCategoria(this._idCategoria);
    }

    private void dgvSubCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvSubCategoria.Columns[e.ColumnIndex].Name == "Elimina"))
        return;
      if (MessageBox.Show("Esta seguro de Eliminar esta SubCategoria", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          new Categoria().eliminaSubCategoria(Convert.ToInt32(this.dgvSubCategoria.SelectedRows[0].Cells["idSubCategoria"].Value.ToString()));
          int num = (int) MessageBox.Show("SubCategoria Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.cargaSubCategorias();
          this.txtNombreSubCategoria.Clear();
          this.txtNombreSubCategoria.Focus();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error Elimina SubCategoria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
    }

    private void dgvSubCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this._idSubCategoria = Convert.ToInt32(this.dgvSubCategoria.SelectedRows[0].Cells["IdSubCategoria"].Value.ToString());
      this.txtNombreSubCategoria.Text = this.dgvSubCategoria.SelectedRows[0].Cells["nombreSubCategoria"].Value.ToString();
    }
  }
}
