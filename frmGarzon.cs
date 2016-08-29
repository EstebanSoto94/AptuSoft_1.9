 
// Type: Aptusoft.frmGarzon
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmGarzon : Form
  {
    private Garzon gar = new Garzon();
    private int idGar = 0;
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private IContainer components = (IContainer) null;
    private DataGridView dgvDatos;
    private GroupBox groupBox1;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnEliminar;
    private Button btnModificar;
    private Button btnGuardar;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtNombre;
    private TextBox txtFono;
    private TextBox txtEmail;
    private TextBox txtComision;
    private Label label5;
    private DataGridViewTextBoxColumn IdVendedor;
    private DataGridViewTextBoxColumn Fono;
    private DataGridViewTextBoxColumn Email;
    private DataGridViewTextBoxColumn DescUnidad;
    private DataGridViewTextBoxColumn Comision;

    public frmGarzon()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("GARZONES"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    public void iniciaFormulario()
    {
      this.idGar = 0;
      this.dgvDatos.DataSource = (object) this.gar.listaGarzones().Tables[0];
      this.txtNombre.Clear();
      this.txtFono.Clear();
      this.txtEmail.Clear();
      this.txtComision.Clear();
      this.txtNombre.Focus();
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modGarzon = 0;
      this.Close();
      this.Dispose();
    }

    private void frmVendedor_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modGarzon = 0;
      this.Dispose();
    }

    private bool validaFormulario()
    {
      if (this.txtNombre.Text.Trim().Length != 0)
        return true;
      int num = (int) MessageBox.Show("Debe Ingresar el Nombre del Garzon", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtNombre.Focus();
      return false;
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
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

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.validaFormulario())
        return;
      VendedorVO ve = new VendedorVO();
      ve.Nombre = this.txtNombre.Text.Trim().ToUpper();
      ve.Fono = this.txtFono.Text.Trim();
      ve.Email = this.txtEmail.Text.Trim().ToUpper();
      ve.Comision = this.txtComision.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtComision.Text.Trim()) : new Decimal(0);
      try
      {
        this.gar.agregaGarzon(ve);
        int num = (int) MessageBox.Show("Garzon Guardado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message);
      }
    }

    private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtComision);
    }

    private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.idGar = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
      VendedorVO vendedorVo = this.gar.buscaGarzonId(this.idGar);
      this.idGar = vendedorVo.IdVendedor;
      this.txtNombre.Text = vendedorVo.Nombre;
      this.txtFono.Text = vendedorVo.Fono;
      this.txtEmail.Text = vendedorVo.Email;
      this.txtComision.Text = vendedorVo.Comision.ToString();
      if (this._modifica)
        this.btnModificar.Enabled = true;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      this.btnGuardar.Enabled = false;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Modificar al Garzon", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !this.validaFormulario())
        return;
      VendedorVO ve = new VendedorVO();
      ve.IdVendedor = this.idGar;
      ve.Nombre = this.txtNombre.Text.Trim().ToUpper();
      ve.Fono = this.txtFono.Text.Trim();
      ve.Email = this.txtEmail.Text.Trim().ToUpper();
      ve.Comision = this.txtComision.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtComision.Text.Trim()) : new Decimal(0);
      try
      {
        this.gar.modificaGarzon(ve);
        int num = (int) MessageBox.Show("Garzon Modificado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Modificar: " + ex.Message);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Eliminar al Garzon", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      try
      {
        this.gar.eliminaGarzon(this.idGar);
        int num = (int) MessageBox.Show("Garzon Eliminado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Eliminar: " + ex.Message);
      }
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
      this.dgvDatos = new DataGridView();
      this.groupBox1 = new GroupBox();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.btnGuardar = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.txtNombre = new TextBox();
      this.txtFono = new TextBox();
      this.txtEmail = new TextBox();
      this.txtComision = new TextBox();
      this.label5 = new Label();
      this.IdVendedor = new DataGridViewTextBoxColumn();
      this.Fono = new DataGridViewTextBoxColumn();
      this.Email = new DataGridViewTextBoxColumn();
      this.DescUnidad = new DataGridViewTextBoxColumn();
      this.Comision = new DataGridViewTextBoxColumn();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.IdVendedor, (DataGridViewColumn) this.Fono, (DataGridViewColumn) this.Email, (DataGridViewColumn) this.DescUnidad, (DataGridViewColumn) this.Comision);
      this.dgvDatos.Location = new Point(12, 124);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.ReadOnly = true;
      this.dgvDatos.RowHeadersVisible = false;
      this.dgvDatos.RowHeadersWidth = 40;
      this.dgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDatos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatos.ScrollBars = ScrollBars.Vertical;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(351, 268);
      this.dgvDatos.TabIndex = 2;
      this.dgvDatos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
      this.groupBox1.Controls.Add((Control) this.btnSalir);
      this.groupBox1.Controls.Add((Control) this.btnLimpiar);
      this.groupBox1.Controls.Add((Control) this.btnEliminar);
      this.groupBox1.Controls.Add((Control) this.btnModificar);
      this.groupBox1.Controls.Add((Control) this.btnGuardar);
      this.groupBox1.Location = new Point(369, -1);
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
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(30, 22);
      this.label1.Name = "label1";
      this.label1.Size = new Size(58, 15);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nombre";
      this.label1.TextAlign = ContentAlignment.TopRight;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(25, 45);
      this.label2.Name = "label2";
      this.label2.Size = new Size(63, 15);
      this.label2.TabIndex = 5;
      this.label2.Text = "Teléfono";
      this.label2.TextAlign = ContentAlignment.TopRight;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(39, 68);
      this.label3.Name = "label3";
      this.label3.Size = new Size(49, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "E-Mail";
      this.label3.TextAlign = ContentAlignment.TopRight;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(21, 91);
      this.label4.Name = "label4";
      this.label4.Size = new Size(67, 15);
      this.label4.TabIndex = 7;
      this.label4.Text = "Comisión";
      this.label4.TextAlign = ContentAlignment.TopRight;
      this.txtNombre.Location = new Point(91, 19);
      this.txtNombre.MaxLength = 100;
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(272, 20);
      this.txtNombre.TabIndex = 8;
      this.txtFono.Location = new Point(91, 42);
      this.txtFono.MaxLength = 50;
      this.txtFono.Name = "txtFono";
      this.txtFono.Size = new Size(142, 20);
      this.txtFono.TabIndex = 9;
      this.txtEmail.Location = new Point(91, 65);
      this.txtEmail.MaxLength = 100;
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(272, 20);
      this.txtEmail.TabIndex = 10;
      this.txtComision.Location = new Point(91, 88);
      this.txtComision.MaxLength = 10;
      this.txtComision.Name = "txtComision";
      this.txtComision.Size = new Size(74, 20);
      this.txtComision.TabIndex = 11;
      this.txtComision.KeyPress += new KeyPressEventHandler(this.txtComision_KeyPress);
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(168, 91);
      this.label5.Name = "label5";
      this.label5.Size = new Size(16, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "%";
      this.label5.TextAlign = ContentAlignment.TopRight;
      this.IdVendedor.DataPropertyName = "IdGarzon";
      this.IdVendedor.HeaderText = "IdVendedor";
      this.IdVendedor.Name = "IdVendedor";
      this.IdVendedor.ReadOnly = true;
      this.IdVendedor.Resizable = DataGridViewTriState.False;
      this.IdVendedor.Visible = false;
      this.Fono.DataPropertyName = "Fono";
      this.Fono.HeaderText = "Fono";
      this.Fono.Name = "Fono";
      this.Fono.ReadOnly = true;
      this.Fono.Resizable = DataGridViewTriState.False;
      this.Fono.Visible = false;
      this.Email.DataPropertyName = "Email";
      this.Email.HeaderText = "Email";
      this.Email.Name = "Email";
      this.Email.ReadOnly = true;
      this.Email.Resizable = DataGridViewTriState.False;
      this.Email.Visible = false;
      this.DescUnidad.DataPropertyName = "Nombre";
      this.DescUnidad.HeaderText = "Garzon";
      this.DescUnidad.Name = "DescUnidad";
      this.DescUnidad.ReadOnly = true;
      this.DescUnidad.Resizable = DataGridViewTriState.False;
      this.DescUnidad.Width = 250;
      this.Comision.DataPropertyName = "Comision";
      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle.Format = "N2";
      gridViewCellStyle.NullValue = (object) null;
      this.Comision.DefaultCellStyle = gridViewCellStyle;
      this.Comision.HeaderText = "% Comision ";
      this.Comision.Name = "Comision";
      this.Comision.ReadOnly = true;
      this.Comision.Resizable = DataGridViewTriState.False;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(466, 407);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.txtComision);
      this.Controls.Add((Control) this.txtEmail);
      this.Controls.Add((Control) this.txtFono);
      this.Controls.Add((Control) this.txtNombre);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.dgvDatos);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmGarzon";
      this.ShowIcon = false;
      this.Text = "Modulo Garzones";
      this.FormClosing += new FormClosingEventHandler(this.frmVendedor_FormClosing);
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
