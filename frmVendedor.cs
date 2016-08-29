 
// Type: Aptusoft.frmVendedor
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmVendedor : Form
  {
    private Vendedor ven = new Vendedor();
    private int idVen = 0;
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

    public frmVendedor()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("VENDEDORES"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    public void iniciaFormulario()
    {
      this.idVen = 0;
      this.dgvDatos.DataSource = (object) this.ven.listaVendedores().Tables[0];
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
      frmMenuPrincipal._modVendedor = 0;
      this.Close();
      this.Dispose();
    }

    private void frmVendedor_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modVendedor = 0;
      this.Dispose();
    }

    private bool validaFormulario()
    {
      if (this.txtNombre.Text.Trim().Length != 0)
        return true;
      int num = (int) MessageBox.Show("Debe Ingresar el Nombre del Vendedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
      
        this.ven.agregaVendedor(ve);
        int num = (int) MessageBox.Show("Vendedor Guardado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      
      //catch (Exception ex)
      //{
      //  int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message);
      //}
    }

    private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtComision);
    }

    private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.idVen = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
      VendedorVO vendedorVo = this.ven.buscaVendedorId(this.idVen);
      this.idVen = vendedorVo.IdVendedor;
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
      if (MessageBox.Show("Esta Seguro de Modificar al Vendedor", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !this.validaFormulario())
        return;
      VendedorVO ve = new VendedorVO();
      ve.IdVendedor = this.idVen;
      ve.Nombre = this.txtNombre.Text.Trim().ToUpper();
      ve.Fono = this.txtFono.Text.Trim();
      ve.Email = this.txtEmail.Text.Trim().ToUpper();
      ve.Comision = this.txtComision.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtComision.Text.Trim()) : new Decimal(0);
      try
      {
        this.ven.modificaVendedor(ve);
        int num = (int) MessageBox.Show("Vendedor Modificado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Modificar: " + ex.Message);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Eliminar al Vendedor", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      try
      {
        this.ven.eliminaVendedor(this.idVen);
        int num = (int) MessageBox.Show("Vendedor Eliminado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.IdVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVendedor,
            this.Fono,
            this.Email,
            this.DescUnidad,
            this.Comision});
            this.dgvDatos.Location = new System.Drawing.Point(12, 124);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 40;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(351, 268);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // IdVendedor
            // 
            this.IdVendedor.DataPropertyName = "IdVendedor";
            this.IdVendedor.HeaderText = "IdVendedor";
            this.IdVendedor.Name = "IdVendedor";
            this.IdVendedor.ReadOnly = true;
            this.IdVendedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdVendedor.Visible = false;
            // 
            // Fono
            // 
            this.Fono.DataPropertyName = "Fono";
            this.Fono.HeaderText = "Fono";
            this.Fono.Name = "Fono";
            this.Fono.ReadOnly = true;
            this.Fono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fono.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Visible = false;
            // 
            // DescUnidad
            // 
            this.DescUnidad.DataPropertyName = "Nombre";
            this.DescUnidad.HeaderText = "Vendedor";
            this.DescUnidad.Name = "DescUnidad";
            this.DescUnidad.ReadOnly = true;
            this.DescUnidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescUnidad.Width = 250;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "Comision";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Comision.DefaultCellStyle = dataGridViewCellStyle1;
            this.Comision.HeaderText = "% Comision ";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            this.Comision.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(369, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 397);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(6, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 59);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(6, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(6, 147);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 59);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(6, 82);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 59);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(6, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 59);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teléfono";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-Mail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comisión";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 19);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtFono
            // 
            this.txtFono.Location = new System.Drawing.Point(91, 42);
            this.txtFono.MaxLength = 50;
            this.txtFono.Name = "txtFono";
            this.txtFono.Size = new System.Drawing.Size(142, 20);
            this.txtFono.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 65);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(91, 88);
            this.txtComision.MaxLength = 10;
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(74, 20);
            this.txtComision.TabIndex = 11;
            this.txtComision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComision_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmVendedor
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(466, 407);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatos);
            this.MaximizeBox = false;
            this.Name = "frmVendedor";
            this.ShowIcon = false;
            this.Text = "Modulo Vendedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVendedor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
  }
}
