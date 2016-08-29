 
// Type: Aptusoft.frmBanco
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmBanco : Form
  {
    private IContainer components = (IContainer) null;
    private List<TipoVO> lista = new List<TipoVO>();
    private int _idBanco = 0;
    private Banco _banco = new Banco();
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
    private DataGridView dgvBancos;
    private DataGridViewTextBoxColumn Linea;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Descripcion;

    public frmBanco()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
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
      this.dgvBancos = new DataGridView();
      this.Linea = new DataGridViewTextBoxColumn();
      this.Id = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvBancos).BeginInit();
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
      this.label1.Text = "Banco";
      this.txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombre.Location = new Point(12, 44);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(351, 22);
      this.txtNombre.TabIndex = 2;
      this.dgvBancos.AllowUserToAddRows = false;
      this.dgvBancos.AllowUserToDeleteRows = false;
      this.dgvBancos.AllowUserToResizeColumns = false;
      this.dgvBancos.AllowUserToResizeRows = false;
      gridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
      this.dgvBancos.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvBancos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvBancos.Columns.AddRange((DataGridViewColumn) this.Linea, (DataGridViewColumn) this.Id, (DataGridViewColumn) this.Descripcion);
      this.dgvBancos.Location = new Point(12, 73);
      this.dgvBancos.Name = "dgvBancos";
      this.dgvBancos.ReadOnly = true;
      this.dgvBancos.RowHeadersVisible = false;
      this.dgvBancos.RowHeadersWidth = 50;
      this.dgvBancos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvBancos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBancos.ScrollBars = ScrollBars.Vertical;
      this.dgvBancos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBancos.Size = new Size(351, 338);
      this.dgvBancos.TabIndex = 3;
      this.dgvBancos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBancos_CellDoubleClick);
      this.Linea.DataPropertyName = "Linea";
      this.Linea.HeaderText = "";
      this.Linea.Name = "Linea";
      this.Linea.ReadOnly = true;
      this.Linea.Width = 20;
      this.Id.DataPropertyName = "IdTipo";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Resizable = DataGridViewTriState.False;
      this.Id.Visible = false;
      this.Descripcion.DataPropertyName = "NombreTipo";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      this.Descripcion.Resizable = DataGridViewTriState.False;
      this.Descripcion.Width = 350;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(471, 440);
      this.Controls.Add((Control) this.dgvBancos);
      this.Controls.Add((Control) this.txtNombre);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmBanco";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Modulo Bancos";
      this.FormClosing += new FormClosingEventHandler(this.frmBanco_FormClosing);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvBancos).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("BANCOS"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    private void cargaBancos()
    {
      this.lista = new Banco().listaBancos();
      for (int index = 0; index < this.lista.Count; ++index)
        this.lista[index].Linea = index + 1;
      this.dgvBancos.DataSource = (object) this.lista;
    }

    private void iniciaFormulario()
    {
      this.cargaBancos();
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this._idBanco = 0;
      this.txtNombre.Clear();
      this.txtNombre.Focus();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (this.txtNombre.Text.Trim().Length > 0)
      {
        if (!this._banco.buscaBancoNombre(this.txtNombre.Text.Trim().ToUpper()))
        {
          this.guardaBanco();
        }
        else
        {
          int num = (int) MessageBox.Show("Ya Existe un Banco con Mismo Nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtNombre.Focus();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNombre.Focus();
      }
    }

    private void guardaBanco()
    {
      try
      {
        this._banco.guardaBanco(this.txtNombre.Text.Trim().ToUpper());
        int num = (int) MessageBox.Show("Banco Guardado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modBanco = 0;
      this.Dispose();
    }

    private void frmBanco_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modBanco = 0;
    }

    private void dgvBancos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this._idBanco = Convert.ToInt32(this.dgvBancos.SelectedRows[0].Cells["Id"].Value.ToString());
      this.buscaBancoID();
    }

    private void buscaBancoID()
    {
      TipoVO tipoVo1 = new TipoVO();
      TipoVO tipoVo2 = this._banco.buscaBancoId(this._idBanco);
      if (tipoVo2 != null)
      {
        this.txtNombre.Text = tipoVo2.NombreTipo;
        this._idBanco = tipoVo2.IdTipo;
        this.btnGuardar.Enabled = false;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        if (!this._elimina)
          return;
        this.btnEliminar.Enabled = true;
      }
      else
      {
        int num = (int) MessageBox.Show("NO se Encontro Banco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (this.txtNombre.Text.Trim().Length > 0)
      {
        if (!this._banco.buscaBancoNombre(this.txtNombre.Text.Trim().ToUpper()))
        {
          this.modificaBanco();
        }
        else
        {
          int num = (int) MessageBox.Show("Ya Existe un Banco con Mismo Nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.txtNombre.Focus();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Debe Ingresar un Nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNombre.Focus();
      }
    }

    private void modificaBanco()
    {
      if (MessageBox.Show("Esta seguro de Modificar", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          this._banco.modificaBanco(new TipoVO()
          {
            IdTipo = this._idBanco,
            NombreTipo = this.txtNombre.Text.Trim().ToUpper()
          });
          int num = (int) MessageBox.Show("Banco Modificado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Banco NO Fue Modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (this._idBanco <= 0)
        return;
      if (MessageBox.Show("Esta seguro de Eliminar", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          this._banco.eliminaBanco(this._idBanco);
          int num = (int) MessageBox.Show("Banco Eliminado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Banco NO Fue Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
    }
  }
}
