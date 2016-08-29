 
// Type: Aptusoft.frmMedioPagoNOFiscal
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmMedioPagoNOFiscal : Form
  {
    private IContainer components = (IContainer) null;
    private MedioPago medio = new MedioPago();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private Label label1;
    private TextBox txtNombre;
    private DataGridView dgvDatos;
    private GroupBox groupBox1;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnEliminar;
    private Button btnModificar;
    private Button btnGuardar;
    private CheckBox chkLiquida;
    private CheckBox chkUsaVoucher;
    private DataGridViewTextBoxColumn CodigoUnidad;
    private DataGridViewTextBoxColumn DescUnidad;
    private DataGridViewCheckBoxColumn Liquida;
    private DataGridViewTextBoxColumn CodigoFiscal;
    private DataGridViewCheckBoxColumn UsaVoucher;
    private int _idMedio;

    public frmMedioPagoNOFiscal()
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
      this.label1 = new Label();
      this.txtNombre = new TextBox();
      this.dgvDatos = new DataGridView();
      this.groupBox1 = new GroupBox();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.btnGuardar = new Button();
      this.chkLiquida = new CheckBox();
      this.chkUsaVoucher = new CheckBox();
      this.CodigoUnidad = new DataGridViewTextBoxColumn();
      this.DescUnidad = new DataGridViewTextBoxColumn();
      this.Liquida = new DataGridViewCheckBoxColumn();
      this.CodigoFiscal = new DataGridViewTextBoxColumn();
      this.UsaVoucher = new DataGridViewCheckBoxColumn();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(12, 21);
      this.label1.Name = "label1";
      this.label1.Size = new Size(392, 27);
      this.label1.TabIndex = 0;
      this.label1.Text = "Medio de Pago";
      this.txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombre.Location = new Point(12, 44);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(392, 22);
      this.txtNombre.TabIndex = 1;
      this.txtNombre.TextChanged += new EventHandler(this.txtNombre_TextChanged_1);
      this.txtNombre.KeyPress += new KeyPressEventHandler(this.txtNombre_KeyPress);
      this.txtNombre.Leave += new EventHandler(this.txtNombre_Leave_1);
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      this.dgvDatos.BackgroundColor = Color.LightSteelBlue;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.CodigoUnidad, (DataGridViewColumn) this.DescUnidad, (DataGridViewColumn) this.Liquida, (DataGridViewColumn) this.CodigoFiscal, (DataGridViewColumn) this.UsaVoucher);
      this.dgvDatos.Location = new Point(12, 96);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.ReadOnly = true;
      this.dgvDatos.RowHeadersVisible = false;
      this.dgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDatos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(394, 315);
      this.dgvDatos.TabIndex = 2;
      this.dgvDatos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
      this.dgvDatos.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dgvDatos_ColumnHeaderMouseClick);
      this.groupBox1.Controls.Add((Control) this.btnSalir);
      this.groupBox1.Controls.Add((Control) this.btnLimpiar);
      this.groupBox1.Controls.Add((Control) this.btnEliminar);
      this.groupBox1.Controls.Add((Control) this.btnModificar);
      this.groupBox1.Controls.Add((Control) this.btnGuardar);
      this.groupBox1.Location = new Point(412, 14);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(91, 397);
      this.groupBox1.TabIndex = 3;
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
      this.chkLiquida.AutoSize = true;
      this.chkLiquida.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkLiquida.Location = new Point(16, 72);
      this.chkLiquida.Name = "chkLiquida";
      this.chkLiquida.Size = new Size(135, 17);
      this.chkLiquida.TabIndex = 4;
      this.chkLiquida.Text = "Liquida Documento";
      this.chkLiquida.UseVisualStyleBackColor = true;
      this.chkUsaVoucher.AutoSize = true;
      this.chkUsaVoucher.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkUsaVoucher.Location = new Point(205, 72);
      this.chkUsaVoucher.Name = "chkUsaVoucher";
      this.chkUsaVoucher.Size = new Size(199, 17);
      this.chkUsaVoucher.TabIndex = 5;
      this.chkUsaVoucher.Text = "Usa Voucher en vez de Boleta";
      this.chkUsaVoucher.UseVisualStyleBackColor = true;
      this.CodigoUnidad.DataPropertyName = "IdMedioPago";
      this.CodigoUnidad.HeaderText = "Codigo";
      this.CodigoUnidad.Name = "CodigoUnidad";
      this.CodigoUnidad.ReadOnly = true;
      this.CodigoUnidad.Visible = false;
      this.DescUnidad.DataPropertyName = "NombreMedioPago";
      this.DescUnidad.HeaderText = "Descripcion";
      this.DescUnidad.Name = "DescUnidad";
      this.DescUnidad.ReadOnly = true;
      this.DescUnidad.Width = 220;
      this.Liquida.DataPropertyName = "Liquida";
      this.Liquida.HeaderText = "Liquida";
      this.Liquida.Name = "Liquida";
      this.Liquida.ReadOnly = true;
      this.Liquida.Width = 60;
      this.CodigoFiscal.DataPropertyName = "CodigoFiscal";
      this.CodigoFiscal.HeaderText = "Fiscal";
      this.CodigoFiscal.MaxInputLength = 4;
      this.CodigoFiscal.Name = "CodigoFiscal";
      this.CodigoFiscal.ReadOnly = true;
      this.CodigoFiscal.Visible = false;
      this.CodigoFiscal.Width = 60;
      this.UsaVoucher.DataPropertyName = "UsaVoucher";
      this.UsaVoucher.HeaderText = "Usa Voucher";
      this.UsaVoucher.Name = "UsaVoucher";
      this.UsaVoucher.ReadOnly = true;
      this.UsaVoucher.Resizable = DataGridViewTriState.True;
      this.UsaVoucher.SortMode = DataGridViewColumnSortMode.Automatic;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(506, 423);
      this.Controls.Add((Control) this.chkUsaVoucher);
      this.Controls.Add((Control) this.chkLiquida);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.dgvDatos);
      this.Controls.Add((Control) this.txtNombre);
      this.Controls.Add((Control) this.label1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmMedioPagoNOFiscal";
      this.ShowIcon = false;
      this.Text = "Modulo Medios de Pago";
      this.FormClosing += new FormClosingEventHandler(this.frmMedioPago_FormClosing);
      this.Load += new EventHandler(this.frmMedioPago_Load);
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("MEDIOS DE PAGO"))
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

    public void iniciaFormulario()
    {
      this.dgvDatos.DataSource = (object) this.medio.listaMediosPagoGrilla();
      this.numFila();
      this.txtNombre.Clear();
      this.txtNombre.Focus();
      this.chkLiquida.Checked = false;
      this.chkUsaVoucher.Checked = false;
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
    }

    private void guardaMedioPago()
    {
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
      try
      {
        this.medio.agregaMedioPago(new MedioPagoVO()
        {
          NombreMedioPago = this.txtNombre.Text,
          Liquida = this.chkLiquida.Checked,
          UsaVoucher = this.chkUsaVoucher.Checked
        });
        this.iniciaFormulario();
        int num = (int) MessageBox.Show("Medio de Pago registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      catch (MySqlException ex)
      {
        int num = (int) MessageBox.Show("Error :" + ((Exception) ex).Message);
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (this.medio.buscaMedioNombre(this.txtNombre.Text.Trim()) && this.btnGuardar.Enabled)
      {
        int num = (int) MessageBox.Show("Esta Medio de Pago Ya Existe!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtNombre.Focus();
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (!this._modifica)
          return;
        this.btnModificar.Enabled = true;
      }
      else
        this.guardaMedioPago();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modMedioPago = 0;
      this.Close();
      this.Dispose();
    }

    private void txtNombre_TextChanged_1(object sender, EventArgs e)
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

    private void txtNombre_Leave_1(object sender, EventArgs e)
    {
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
    }

    private void frmMedioPago_Load(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    public void buscaFila()
    {
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
      string str = this.txtNombre.Text.Trim().ToString();
      for (int index = 0; index < this.dgvDatos.Rows.Count; ++index)
      {
        if (str.Equals(this.dgvDatos.Rows[index].Cells[1].Value.ToString()))
        {
          this._idMedio = Convert.ToInt32(this.dgvDatos.Rows[index].Cells[0].Value.ToString());
          this.dgvDatos.CurrentCell = this.dgvDatos[1, index];
        }
      }
    }

    private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.medio.buscaMedioNombre(this.txtNombre.Text.Trim()))
      {
        this.buscaFila();
        int num = (int) MessageBox.Show("Este Medio de Pago Ya Existe!!", "Advertencia");
        this.txtNombre.Focus();
        this.btnGuardar.Enabled = false;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
      }
      else
        this.guardaMedioPago();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
      if (this.txtNombre.Text.Length <= 0)
        return;
      this.medio.actualizaMEDIO(new MedioPagoVO()
      {
        IdMedioPago = this._idMedio,
        NombreMedioPago = this.txtNombre.Text.Trim(),
        Liquida = this.chkLiquida.Checked,
        UsaVoucher = this.chkUsaVoucher.Checked
      });
      int num = (int) MessageBox.Show("Medio de Pago Actualizado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.iniciaFormulario();
    }

    public void buscaMedioDGV()
    {
      int rowIndex = this.dgvDatos.CurrentCell.RowIndex;
      this._idMedio = Convert.ToInt32(this.dgvDatos.Rows[rowIndex].Cells[0].Value.ToString());
      this.txtNombre.Text = this.dgvDatos.Rows[rowIndex].Cells[1].Value.ToString();
      this.chkLiquida.Checked = Convert.ToBoolean(this.dgvDatos.Rows[rowIndex].Cells[2].Value);
      this.chkUsaVoucher.Checked = Convert.ToBoolean(this.dgvDatos.Rows[rowIndex].Cells["UsaVoucher"].Value);
      this.txtNombre.Focus();
      this.btnGuardar.Enabled = false;
      if (this._modifica)
        this.btnModificar.Enabled = true;
      if (!this._elimina)
        return;
      this.btnEliminar.Enabled = true;
    }

    private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.buscaMedioDGV();
    }

    private void dgvDatos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      this.numFila();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar el Medio de Pago", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.medio.eliminaMEDIO(this._idMedio);
      int num = (int) MessageBox.Show("Medio de Pago Eliminado");
      this.iniciaFormulario();
    }

    private void frmMedioPago_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modMedioPago = 0;
      this.Dispose();
    }
  }
}
