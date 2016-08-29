 
// Type: Aptusoft.frmCentroCosto
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmCentroCosto : Form
  {
    private IContainer components = (IContainer) null;
    private CentroCosto centro = new CentroCosto();
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
    private TextBox txtNombre;
    private DataGridView dgvCentroCosto;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Descripcion;
    private int _idCentroCosto;

    public frmCentroCosto()
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
      this.txtNombre = new TextBox();
      this.dgvCentroCosto = new DataGridView();
      this.Id = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvCentroCosto).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.btnSalir);
      this.groupBox1.Controls.Add((Control) this.btnLimpiar);
      this.groupBox1.Controls.Add((Control) this.btnEliminar);
      this.groupBox1.Controls.Add((Control) this.btnModificar);
      this.groupBox1.Controls.Add((Control) this.btnGuardar);
      this.groupBox1.Location = new Point(369, 14);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(91, 397);
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
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.FlatStyle = FlatStyle.Flat;
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.ControlLightLight;
      this.label1.Location = new Point(12, 21);
      this.label1.Name = "label1";
      this.label1.Size = new Size(351, 27);
      this.label1.TabIndex = 1;
      this.label1.Text = " Centro de Costo";
      this.txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombre.Location = new Point(12, 44);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(351, 22);
      this.txtNombre.TabIndex = 2;
      this.txtNombre.TextChanged += new EventHandler(this.txtCategoria_TextChanged);
      this.txtNombre.Leave += new EventHandler(this.txtCategoria_Leave);
      this.txtNombre.KeyPress += new KeyPressEventHandler(this.txtCategoria_KeyPress);
      this.dgvCentroCosto.AllowUserToAddRows = false;
      this.dgvCentroCosto.AllowUserToDeleteRows = false;
      this.dgvCentroCosto.AllowUserToResizeColumns = false;
      this.dgvCentroCosto.AllowUserToResizeRows = false;
      gridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
      this.dgvCentroCosto.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvCentroCosto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvCentroCosto.Columns.AddRange((DataGridViewColumn) this.Id, (DataGridViewColumn) this.Descripcion);
      this.dgvCentroCosto.Location = new Point(12, 73);
      this.dgvCentroCosto.Name = "dgvCentroCosto";
      this.dgvCentroCosto.ReadOnly = true;
      this.dgvCentroCosto.RowHeadersWidth = 50;
      this.dgvCentroCosto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvCentroCosto.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvCentroCosto.ScrollBars = ScrollBars.Vertical;
      this.dgvCentroCosto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvCentroCosto.Size = new Size(351, 338);
      this.dgvCentroCosto.TabIndex = 3;
      this.dgvCentroCosto.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dgvCategorias_ColumnHeaderMouseClick);
      this.dgvCentroCosto.DoubleClick += new EventHandler(this.dgvCategorias_DoubleClick);
      this.Id.DataPropertyName = "IdCentroCosto";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Resizable = DataGridViewTriState.False;
      this.Descripcion.DataPropertyName = "NombreCentroCosto";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      this.Descripcion.Resizable = DataGridViewTriState.False;
      this.Descripcion.Width = 350;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(471, 440);
      this.Controls.Add((Control) this.dgvCentroCosto);
      this.Controls.Add((Control) this.txtNombre);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox1);
      this.MaximizeBox = false;
      this.Name = "frmCentroCosto";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Modulo Centro de Costo";
      this.Load += new EventHandler(this.frmCategorias_Load);
      this.FormClosing += new FormClosingEventHandler(this.frmCategorias_FormClosing);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvCentroCosto).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("CENTRO DE COSTO"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    private void numFila()
    {
      if (this.dgvCentroCosto.Rows.Count <= 0)
        return;
      for (int index = 0; index < this.dgvCentroCosto.Rows.Count; ++index)
        this.dgvCentroCosto.Rows[index].HeaderCell.Value = (object) (index + 1).ToString();
    }

    public void iniciaFormulario()
    {
      this.dgvCentroCosto.DataSource = (object) this.centro.cosultaCentroCosto();
      this.numFila();
      this.txtNombre.Clear();
      this.txtNombre.Focus();
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modCentroCosto = 0;
      this.Close();
      this.Dispose();
    }

    private void frmCategorias_Load(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void txtCategoria_Leave(object sender, EventArgs e)
    {
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
    }

    private void guardaCentroCosto()
    {
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
      try
      {
        this.centro.agregaCentroCosto(this.txtNombre.Text.Trim());
        this.iniciaFormulario();
        int num = (int) MessageBox.Show("Centro de Costo Guardado");
      }
      catch (MySqlException ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar:" + ((Exception) ex).Message);
      }
    }

    public void buscaFila()
    {
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
      string str = this.txtNombre.Text.Trim().ToString();
      for (int index = 0; index < this.dgvCentroCosto.Rows.Count; ++index)
      {
        if (str.Equals(this.dgvCentroCosto.Rows[index].Cells[1].Value.ToString()))
        {
          this._idCentroCosto = Convert.ToInt32(this.dgvCentroCosto.Rows[index].Cells[0].Value.ToString());
          this.dgvCentroCosto.CurrentCell = this.dgvCentroCosto[1, index];
        }
      }
    }

    private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.centro.buscaCentroCostoDesc(this.txtNombre.Text.Trim()))
      {
        this.buscaFila();
        int num = (int) MessageBox.Show("Esta Centro de Costo Ya Existe!!", "Advertencia");
        this.txtNombre.Focus();
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
      }
      else
        this.guardaCentroCosto();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (this.centro.buscaCentroCostoDesc(this.txtNombre.Text.Trim()) && this.btnGuardar.Enabled)
      {
        int num = (int) MessageBox.Show("Este Centro de Costo Ya Existe!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.txtNombre.Focus();
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (!this._modifica)
          return;
        this.btnModificar.Enabled = true;
      }
      else
        this.guardaCentroCosto();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
      if (this.txtNombre.Text.Length <= 0)
        return;
      CentroCostoVO centro = new CentroCostoVO()
      {
        IdCentroCosto = this._idCentroCosto,
        NombreCentroCosto = this.txtNombre.Text.Trim()
      };
      try
      {
        this.centro.actualizaCentroCosto(centro);
        int num = (int) MessageBox.Show("Centro de Costo Actualizado");
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Modificar" + ex.Message);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar el Centro de Costo", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      try
      {
        this.centro.eliminaCentroCosto(this._idCentroCosto);
        int num = (int) MessageBox.Show("Centro Costo Eliminado");
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Eliminar: " + ex.Message);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    public void buscaCentroCostoDGV()
    {
      int rowIndex = this.dgvCentroCosto.CurrentCell.RowIndex;
      this._idCentroCosto = Convert.ToInt32(this.dgvCentroCosto.Rows[rowIndex].Cells[0].Value.ToString());
      this.txtNombre.Text = this.dgvCentroCosto.Rows[rowIndex].Cells[1].Value.ToString();
      this.txtNombre.Focus();
      this.btnGuardar.Enabled = false;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      if (!this._modifica)
        return;
      this.btnModificar.Enabled = true;
    }

    private void dgvCategorias_DoubleClick(object sender, EventArgs e)
    {
      this.buscaCentroCostoDGV();
    }

    private void dgvCategorias_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      this.numFila();
    }

    private void frmCategorias_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modCentroCosto = 0;
    }

    private void txtCategoria_TextChanged(object sender, EventArgs e)
    {
      if (this.txtNombre.Text.Length > 0 && !this.btnModificar.Enabled)
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
