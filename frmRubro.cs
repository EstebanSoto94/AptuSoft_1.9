 
// Type: Aptusoft.frmRubro
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmRubro : Form
  {
    private IContainer components = (IContainer) null;
    private string _nombreRubro = "";
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
    private TextBox txtRubro;
    private DataGridView dgvDatos;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Descripcion;
    private int _idRubro;

    public frmRubro()
    {
      this.InitializeComponent();
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
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      this.groupBox1 = new GroupBox();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.btnGuardar = new Button();
      this.label1 = new Label();
      this.txtRubro = new TextBox();
      this.dgvDatos = new DataGridView();
      this.Id = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.btnSalir);
      this.groupBox1.Controls.Add((Control) this.btnLimpiar);
      this.groupBox1.Controls.Add((Control) this.btnEliminar);
      this.groupBox1.Controls.Add((Control) this.btnModificar);
      this.groupBox1.Controls.Add((Control) this.btnGuardar);
      this.groupBox1.Location = new Point(369, 1);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(91, 410);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(6, 320);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 59);
      this.btnSalir.TabIndex = 4;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Location = new Point(6, 212);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 59);
      this.btnLimpiar.TabIndex = 3;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnEliminar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnEliminar.Location = new Point(6, 147);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(75, 59);
      this.btnEliminar.TabIndex = 2;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnModificar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnModificar.Location = new Point(6, 82);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 59);
      this.btnModificar.TabIndex = 1;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnGuardar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Location = new Point(6, 17);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 59);
      this.btnGuardar.TabIndex = 0;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.label1.BackColor = Color.LightSkyBlue;
      this.label1.FlatStyle = FlatStyle.Flat;
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.ControlLightLight;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(351, 27);
      this.label1.TabIndex = 1;
      this.label1.Text = "Rubros";
      this.txtRubro.CharacterCasing = CharacterCasing.Upper;
      this.txtRubro.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtRubro.Location = new Point(12, 32);
      this.txtRubro.Name = "txtRubro";
      this.txtRubro.Size = new Size(351, 22);
      this.txtRubro.TabIndex = 2;
      this.txtRubro.TextChanged += new EventHandler(this.txtCategoria_TextChanged);
      this.txtRubro.KeyPress += new KeyPressEventHandler(this.txtCategoria_KeyPress);
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      this.dgvDatos.AllowUserToResizeColumns = false;
      this.dgvDatos.AllowUserToResizeRows = false;
      gridViewCellStyle.BackColor = Color.Lavender;
      this.dgvDatos.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvDatos.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.Id, (DataGridViewColumn) this.Descripcion);
      this.dgvDatos.Location = new Point(12, 60);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.ReadOnly = true;
      this.dgvDatos.RowHeadersWidth = 50;
      this.dgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDatos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatos.ScrollBars = ScrollBars.Vertical;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(351, 351);
      this.dgvDatos.TabIndex = 3;
      this.dgvDatos.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dgvCategorias_ColumnHeaderMouseClick);
      this.dgvDatos.DoubleClick += new EventHandler(this.dgvCategorias_DoubleClick);
      this.Id.DataPropertyName = "IdRubro";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Resizable = DataGridViewTriState.False;
      this.Id.Visible = false;
      this.Descripcion.DataPropertyName = "NombreRubro";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      this.Descripcion.Resizable = DataGridViewTriState.False;
      this.Descripcion.Width = 350;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(463, 417);
      this.Controls.Add((Control) this.dgvDatos);
      this.Controls.Add((Control) this.txtRubro);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmRubro";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Modulo Rubros";
      this.FormClosing += new FormClosingEventHandler(this.frmCategorias_FormClosing);
      this.Load += new EventHandler(this.frmCategorias_Load);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("RUBROS"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    private void numFila()
    {
      if (this.dgvDatos.Rows.Count <= 0)
        return;
      for (int index = 0; index < this.dgvDatos.Rows.Count; ++index)
        this.dgvDatos.Rows[index].HeaderCell.Value = (object) (index + 1).ToString();
    }

    public void iniciaRubros()
    {
      this.dgvDatos.DataSource = (object) new Rubro().listaRubros();
      this.numFila();
      this.txtRubro.Clear();
      this.txtRubro.Focus();
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this._nombreRubro = "";
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      this.Dispose();
    }

    private void frmCategorias_Load(object sender, EventArgs e)
    {
      this.iniciaRubros();
    }

    private void guardaRubro()
    {
      Rubro rubro = new Rubro();
      try
      {
        rubro.agregaRubro(this.txtRubro.Text.Trim());
        int num = (int) MessageBox.Show("Rubro Guardado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaRubros();
      }
      catch (MySqlException ex)
      {
        int num = (int) MessageBox.Show("Error :" + ((Exception) ex).Message);
      }
    }

    public void buscaFila()
    {
      this.txtRubro.Text = this.txtRubro.Text.Trim().ToUpper();
      string str = this.txtRubro.Text.Trim().ToString();
      for (int index = 0; index < this.dgvDatos.Rows.Count; ++index)
      {
        if (str.Equals(this.dgvDatos.Rows[index].Cells[1].Value.ToString()))
        {
          this._idRubro = Convert.ToInt32(this.dgvDatos.Rows[index].Cells[0].Value.ToString());
          this.dgvDatos.CurrentCell = this.dgvDatos[1, index];
        }
      }
    }

    private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (new Rubro().buscaRubroDesc(this.txtRubro.Text.Trim()))
      {
        this.buscaFila();
        int num = (int) MessageBox.Show("Este Rubro Ya Existe!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRubro.Focus();
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
      }
      else
        this.guardaRubro();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (new Rubro().buscaRubroDesc(this.txtRubro.Text.Trim()) && this.btnGuardar.Enabled)
      {
        int num = (int) MessageBox.Show("Este Rubro Ya Existe!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRubro.Focus();
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (!this._modifica)
          return;
        this.btnModificar.Enabled = true;
      }
      else if (this.txtRubro.Text.Trim().Length > 0)
      {
        this.guardaRubro();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe ingresar un Nombre de Rubro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRubro.Focus();
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      this.txtRubro.Text = this.txtRubro.Text.Trim().ToUpper();
      if (this.txtRubro.Text.Trim().Length > 0)
      {
        new Rubro().actualizaRubro(new RubroVO()
        {
          IdRubro = this._idRubro,
          NombreRubro = this.txtRubro.Text.Trim()
        });
        int num = (int) MessageBox.Show("Rubro Actualizado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaRubros();
      }
      else
      {
        int num = (int) MessageBox.Show("Debe ingresar un Nombre de Rubro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtRubro.Focus();
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        new Rubro().eliminaRubro(this._idRubro);
        int num = (int) MessageBox.Show("Rubro Eliminado", "Elimina", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaRubros();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Accion Cancelada", "Elimina", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaRubros();
    }

    public void buscaRubroDGV()
    {
      int rowIndex = this.dgvDatos.CurrentCell.RowIndex;
      this._idRubro = Convert.ToInt32(this.dgvDatos.Rows[rowIndex].Cells[0].Value.ToString());
      this._nombreRubro = this.dgvDatos.Rows[rowIndex].Cells[1].Value.ToString();
      this.txtRubro.Text = this.dgvDatos.Rows[rowIndex].Cells[1].Value.ToString();
      this.txtRubro.Focus();
      this.btnGuardar.Enabled = false;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      if (!this._modifica)
        return;
      this.btnModificar.Enabled = true;
    }

    private void dgvCategorias_DoubleClick(object sender, EventArgs e)
    {
      this.buscaRubroDGV();
    }

    private void dgvCategorias_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      this.numFila();
    }

    private void frmCategorias_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void txtCategoria_TextChanged(object sender, EventArgs e)
    {
      if (this.txtRubro.Text.Length > 0 && !this.btnModificar.Enabled)
      {
        if (this._guarda)
          this.btnGuardar.Enabled = true;
        else
          this.btnGuardar.Enabled = false;
      }
      else
        this.btnGuardar.Enabled = false;
    }
  }
}
