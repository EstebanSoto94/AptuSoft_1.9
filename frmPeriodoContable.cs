 
// Type: Aptusoft.frmPeriodoContable
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmPeriodoContable : Form
  {
    private int idPeriodo = 0;
    private bool enCurso = false;
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private IContainer components = (IContainer) null;
    private DataGridView dgvPeriodos;
    private Label label1;
    private GroupBox groupBox1;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnEliminar;
    private Button btnModificar;
    private Button btnGuardar;
    private DataGridViewTextBoxColumn Linea;
    private DataGridViewTextBoxColumn IdPeriodo;
    private DataGridViewTextBoxColumn Nombre;
    private DataGridViewCheckBoxColumn Visible;
    private DataGridViewCheckBoxColumn EnCurso;
    private CheckBox chkVisible;
    private CheckBox chkEnCurso;
    private TextBox txtNombre;

    public frmPeriodoContable()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("PERIODOS"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    private void iniciaFormulario()
    {
      this.txtNombre.Clear();
      this.chkEnCurso.Checked = false;
      this.chkVisible.Checked = false;
      this.idPeriodo = 0;
      this.enCurso = false;
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.txtNombre.Focus();
      this.cargaPeriodos();
    }

    private void cargaPeriodos()
    {
      try
      {
        List<PeriodoVO> list = new Periodo().listaPeriodos();
        if (list.Count <= 0)
          return;
        this.dgvPeriodos.DataSource = (object) list;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al carga lista " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modPeriodoContable = 0;
      this.Dispose();
    }

    private void frmPeriodoContable_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modPeriodoContable = 0;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtNombre.Text.Trim().Length > 0)
        {
          if (!new Periodo().buscaPeriodoNombre(this.txtNombre.Text.Trim()))
          {
            new Periodo().guardaPeriodo(new PeriodoVO()
            {
              Nombre = this.txtNombre.Text.Trim().ToUpper(),
              Visible = this.chkVisible.Checked,
              EnCurso = this.chkEnCurso.Checked
            });
            int num = (int) MessageBox.Show("Periodo Guardado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaFormulario();
          }
          else
          {
            int num = (int) MessageBox.Show("Ya existe un Periodo con este Nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            this.txtNombre.Focus();
          }
        }
        else
        {
          int num1 = (int) MessageBox.Show("Debe Ingresar un Nombre de Periodo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("error al guardar " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void dgvPeriodos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.idPeriodo = Convert.ToInt32(this.dgvPeriodos.SelectedRows[0].Cells["IdPeriodo"].Value.ToString());
      PeriodoVO periodoVo = new Periodo().buscaPeriodoID(this.idPeriodo);
      this.txtNombre.Text = periodoVo.Nombre;
      this.chkVisible.Checked = periodoVo.Visible;
      this.chkEnCurso.Checked = periodoVo.EnCurso;
      this.enCurso = periodoVo.EnCurso;
      this.btnGuardar.Enabled = false;
      if (this._modifica)
        this.btnModificar.Enabled = true;
      if (!this._elimina)
        return;
      this.btnEliminar.Enabled = true;
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtNombre.Text.Trim().Length > 0 && this.idPeriodo > 0)
        {
          new Periodo().modificaPeriodo(new PeriodoVO()
          {
            IdPeriodo = this.idPeriodo,
            Nombre = this.txtNombre.Text.Trim().ToUpper(),
            Visible = this.chkVisible.Checked,
            EnCurso = this.chkEnCurso.Checked
          });
          int num = (int) MessageBox.Show("Periodo Modificado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        else
        {
          int num1 = (int) MessageBox.Show("Debe Ingresar un Nombre de Periodo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("error al modificar " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.txtNombre.Text.Trim().Length > 0 && this.idPeriodo > 0)
        {
          if (!this.enCurso)
          {
            new Periodo().eliminaPeriodo(this.idPeriodo);
            int num = (int) MessageBox.Show("Periodo Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.iniciaFormulario();
          }
          else
          {
            int num1 = (int) MessageBox.Show("Antes de Eliminar debe dejar otro Periodo en Curso", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("Debe seleccionar un Periodo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("error al eliminar " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
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
      this.dgvPeriodos = new DataGridView();
      this.Linea = new DataGridViewTextBoxColumn();
      this.IdPeriodo = new DataGridViewTextBoxColumn();
      this.Nombre = new DataGridViewTextBoxColumn();
      this.Visible = new DataGridViewCheckBoxColumn();
      this.EnCurso = new DataGridViewCheckBoxColumn();
      this.label1 = new Label();
      this.groupBox1 = new GroupBox();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.btnGuardar = new Button();
      this.chkVisible = new CheckBox();
      this.chkEnCurso = new CheckBox();
      this.txtNombre = new TextBox();
      ((ISupportInitialize) this.dgvPeriodos).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.dgvPeriodos.AllowUserToAddRows = false;
      this.dgvPeriodos.AllowUserToDeleteRows = false;
      this.dgvPeriodos.AllowUserToResizeColumns = false;
      this.dgvPeriodos.AllowUserToResizeRows = false;
      gridViewCellStyle.BackColor = Color.Lavender;
      this.dgvPeriodos.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvPeriodos.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvPeriodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvPeriodos.Columns.AddRange((DataGridViewColumn) this.Linea, (DataGridViewColumn) this.IdPeriodo, (DataGridViewColumn) this.Nombre, (DataGridViewColumn) this.Visible, (DataGridViewColumn) this.EnCurso);
      this.dgvPeriodos.Location = new Point(12, 93);
      this.dgvPeriodos.Name = "dgvPeriodos";
      this.dgvPeriodos.ReadOnly = true;
      this.dgvPeriodos.RowHeadersVisible = false;
      this.dgvPeriodos.RowHeadersWidth = 50;
      this.dgvPeriodos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvPeriodos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvPeriodos.ScrollBars = ScrollBars.Vertical;
      this.dgvPeriodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvPeriodos.Size = new Size(351, 305);
      this.dgvPeriodos.TabIndex = 6;
      this.dgvPeriodos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvPeriodos_CellDoubleClick);
      this.Linea.DataPropertyName = "Linea";
      this.Linea.HeaderText = "";
      this.Linea.Name = "Linea";
      this.Linea.ReadOnly = true;
      this.Linea.Width = 20;
      this.IdPeriodo.DataPropertyName = "IdPeriodo";
      this.IdPeriodo.HeaderText = "Id";
      this.IdPeriodo.Name = "IdPeriodo";
      this.IdPeriodo.ReadOnly = true;
      this.IdPeriodo.Resizable = DataGridViewTriState.False;
      this.IdPeriodo.Visible = false;
      this.Nombre.DataPropertyName = "Nombre";
      this.Nombre.HeaderText = "Nombre";
      this.Nombre.Name = "Nombre";
      this.Nombre.ReadOnly = true;
      this.Nombre.Resizable = DataGridViewTriState.False;
      this.Nombre.Width = 150;
      this.Visible.DataPropertyName = "Visible";
      this.Visible.HeaderText = "Visible";
      this.Visible.Name = "Visible";
      this.Visible.ReadOnly = true;
      this.Visible.Width = 60;
      this.EnCurso.DataPropertyName = "EnCurso";
      this.EnCurso.HeaderText = "En Curso";
      this.EnCurso.Name = "EnCurso";
      this.EnCurso.ReadOnly = true;
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.FlatStyle = FlatStyle.Flat;
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.ControlLightLight;
      this.label1.Location = new Point(12, 8);
      this.label1.Name = "label1";
      this.label1.Size = new Size(351, 24);
      this.label1.TabIndex = 4;
      this.label1.Text = "PERIODO CONTABLE";
      this.groupBox1.Controls.Add((Control) this.btnSalir);
      this.groupBox1.Controls.Add((Control) this.btnLimpiar);
      this.groupBox1.Controls.Add((Control) this.btnEliminar);
      this.groupBox1.Controls.Add((Control) this.btnModificar);
      this.groupBox1.Controls.Add((Control) this.btnGuardar);
      this.groupBox1.Location = new Point(369, 1);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(91, 397);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Location = new Point(6, 329);
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
      this.chkVisible.AutoSize = true;
      this.chkVisible.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkVisible.Location = new Point(14, 58);
      this.chkVisible.Name = "chkVisible";
      this.chkVisible.Size = new Size(200, 19);
      this.chkVisible.TabIndex = 10;
      this.chkVisible.Text = "Visible en Modulos de Compras";
      this.chkVisible.UseVisualStyleBackColor = true;
      this.chkEnCurso.AutoSize = true;
      this.chkEnCurso.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkEnCurso.Location = new Point(226, 58);
      this.chkEnCurso.Name = "chkEnCurso";
      this.chkEnCurso.Size = new Size(137, 19);
      this.chkEnCurso.TabIndex = 11;
      this.chkEnCurso.Text = "Periodo en Curso";
      this.chkEnCurso.UseVisualStyleBackColor = true;
      this.txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombre.Location = new Point(12, 31);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(351, 22);
      this.txtNombre.TabIndex = 12;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(470, 414);
      this.Controls.Add((Control) this.txtNombre);
      this.Controls.Add((Control) this.chkEnCurso);
      this.Controls.Add((Control) this.chkVisible);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.dgvPeriodos);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmPeriodoContable";
      this.ShowIcon = false;
      this.Text = "Periodo Contable";
      this.FormClosing += new FormClosingEventHandler(this.frmPeriodoContable_FormClosing);
      ((ISupportInitialize) this.dgvPeriodos).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
