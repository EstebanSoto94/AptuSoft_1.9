 
// Type: Aptusoft.frmUsuario
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmUsuario : Form
  {
    private int idUsuario = 0;
    private UsuarioVO _usuarioVO = new UsuarioVO();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private Label label1;
    private Label label6;
    private ComboBox cmbListaPrecio;
    private Label label5;
    private Label label4;
    private Label label3;
    private ComboBox cmbBodega;
    private ComboBox cmbCaja;
    private ComboBox cmbTipo;
    private TextBox txtClave;
    private TextBox txtNombre;
    private Label label2;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private DataGridView dgvUsuarios;
    private GroupBox groupBox2;
    private CheckBox chkModificaStock;
    private CheckBox chkInformeCaja;

    public frmUsuario()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("USUARIO"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    private void iniciaFormulario()
    {
      this.idUsuario = 0;
      this.txtNombre.Clear();
      this.txtClave.Clear();
      this.txtNombre.Focus();
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      TipoUsuario tipoUsuario = new TipoUsuario();
      this.cmbTipo.DataSource = (object) tipoUsuario.listaTiposUsuarioSinFiltro();
      this.cmbTipo.ValueMember = "IdTipoUsuario";
      this.cmbTipo.DisplayMember = "NombreTipoUsuario";
      this.chkModificaStock.Checked = false;
      this.chkInformeCaja.Checked = false;
      CargaMaestros cargaMaestros = new CargaMaestros();
      this.cmbListaPrecio.DataSource = (object) cargaMaestros.cargaListaPrecioUsuario();
      this.cmbListaPrecio.ValueMember = "IdListaPrecio";
      this.cmbListaPrecio.DisplayMember = "NombreListaPrecio";
      this.cmbBodega.DataSource = (object) cargaMaestros.cargaBodegaUsuario();
      this.cmbBodega.ValueMember = "IdBodega";
      this.cmbBodega.DisplayMember = "NombreBodega";
      this.cmbCaja.DataSource = (object) cargaMaestros.cargaCajaUsuario();
      this.cmbCaja.ValueMember = "IdCaja";
      this.cmbCaja.DisplayMember = "NombreCaja";
      this.dgvUsuarios.DataSource = (object) null;
      this.dgvUsuarios.Columns.Clear();
      this.creaColumnasUsuarios();
      List<UsuarioVO> list = new Usuario().listaUsuarios();
      for (int index = 0; index < list.Count; ++index)
      {
        list[index].TipoUsuario = tipoUsuario.retornaNombreTipoUsuario(Convert.ToInt32(list[index].IdTipoUsuario.ToString()));
        list[index].Bodega = list[index].IdBodega == 0 ? "TODAS" : list[index].Bodega;
        list[index].ListaPrecio = list[index].IdListaPrecio == 0 ? "TODAS" : list[index].ListaPrecio;
      }
      this.dgvUsuarios.DataSource = (object) list;
    }

    private void creaColumnasUsuarios()
    {
      this.dgvUsuarios.AutoGenerateColumns = false;
      this.dgvUsuarios.Columns.Add("IdUsuario", "IdUsuario");
      this.dgvUsuarios.Columns[0].DataPropertyName = "IdUsuario";
      this.dgvUsuarios.Columns[0].Width = 20;
      this.dgvUsuarios.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvUsuarios.Columns[0].Visible = false;
      this.dgvUsuarios.Columns.Add("NombreUsuario", "Usuario");
      this.dgvUsuarios.Columns[1].DataPropertyName = "NombreUsuario";
      this.dgvUsuarios.Columns[1].Width = 130;
      this.dgvUsuarios.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvUsuarios.Columns.Add("Clave", "Clave");
      this.dgvUsuarios.Columns[2].DataPropertyName = "Clave";
      this.dgvUsuarios.Columns[2].Width = 80;
      this.dgvUsuarios.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvUsuarios.Columns[2].Visible = false;
      this.dgvUsuarios.Columns.Add("TipoUsuario", "Tipo Usuario");
      this.dgvUsuarios.Columns[3].DataPropertyName = "TipoUsuario";
      this.dgvUsuarios.Columns[3].Width = 105;
      this.dgvUsuarios.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvUsuarios.Columns.Add("Bodega", "Bodega");
      this.dgvUsuarios.Columns[4].DataPropertyName = "Bodega";
      this.dgvUsuarios.Columns[4].Width = 80;
      this.dgvUsuarios.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvUsuarios.Columns.Add("Caja", "Caja");
      this.dgvUsuarios.Columns[5].DataPropertyName = "Caja";
      this.dgvUsuarios.Columns[5].Width = 70;
      this.dgvUsuarios.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvUsuarios.Columns.Add("ListaPrecio", "Lista Precio");
      this.dgvUsuarios.Columns[6].DataPropertyName = "ListaPrecio";
      this.dgvUsuarios.Columns[6].Width = 90;
      this.dgvUsuarios.Columns[6].Resizable = DataGridViewTriState.False;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modUsuario = 0;
      this.Close();
      this.Dispose();
    }

    private bool valida()
    {
      if (this.txtNombre.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe ingresar Nombre de Usuario");
        this.txtNombre.Focus();
        return false;
      }
      if (this.txtClave.Text.Trim().Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe ingresar Clave de Usuario");
      this.txtClave.Focus();
      return false;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      UsuarioVO usVO = new UsuarioVO();
      usVO.NombreUsuario = this.txtNombre.Text.Trim().ToUpper();
      usVO.Clave = this.txtClave.Text.Trim().ToUpper();
      usVO.IdTipoUsuario = Convert.ToInt32(this.cmbTipo.SelectedValue.ToString());
      usVO.IdBodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      usVO.IdCaja = Convert.ToInt32(this.cmbCaja.SelectedValue.ToString());
      usVO.IdListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
      usVO.ModificaStock = this.chkModificaStock.Checked;
      usVO.VerInformCaja = this.chkInformeCaja.Checked;
      Usuario usuario = new Usuario();
      try
      {
        usuario.agregaUsuario(usVO);
        int num = (int) MessageBox.Show("Usuario Guardado");
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar usuario: " + ex.Message);
      }
    }

    private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
    {
      this.idUsuario = Convert.ToInt32(this.dgvUsuarios.Rows[this.dgvUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString());
      Usuario usuario = new Usuario();
      try
      {
        UsuarioVO usuarioVo = usuario.retornaUsuarioID(this.idUsuario);
        this._usuarioVO = usuarioVo;
        this.idUsuario = usuarioVo.IdUsuario;
        this.txtNombre.Text = usuarioVo.NombreUsuario;
        this.txtClave.Text = usuarioVo.Clave;
        this.cmbBodega.SelectedValue = (object) usuarioVo.IdBodega;
        this.cmbCaja.SelectedValue = (object) usuarioVo.IdCaja;
        this.cmbListaPrecio.SelectedValue = (object) usuarioVo.IdListaPrecio;
        this.cmbTipo.SelectedValue = (object) usuarioVo.IdTipoUsuario;
        this.chkModificaStock.Checked = usuarioVo.ModificaStock;
        this.chkInformeCaja.Checked = usuarioVo.VerInformCaja;
        this.btnGuardar.Enabled = false;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        if (!this._elimina)
          return;
        this.btnEliminar.Enabled = true;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Llamar Usuario: " + ex.Message);
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Modificar este Usuario", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes || !this.valida())
        return;
      UsuarioVO usVO = new UsuarioVO();
      usVO.IdUsuario = this.idUsuario;
      usVO.NombreUsuario = this.txtNombre.Text.Trim().ToUpper();
      usVO.Clave = this.txtClave.Text.Trim().ToUpper();
      usVO.IdTipoUsuario = Convert.ToInt32(this.cmbTipo.SelectedValue.ToString());
      usVO.IdBodega = Convert.ToInt32(this.cmbBodega.SelectedValue.ToString());
      usVO.IdCaja = Convert.ToInt32(this.cmbCaja.SelectedValue.ToString());
      usVO.IdListaPrecio = Convert.ToInt32(this.cmbListaPrecio.SelectedValue.ToString());
      usVO.ModificaStock = this.chkModificaStock.Checked;
      usVO.VerInformCaja = this.chkInformeCaja.Checked;
      Usuario usuario = new Usuario();
      try
      {
        usuario.modificaUsuario(usVO);
        int num = (int) MessageBox.Show("Usuario Modificado");
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Modificar usuario: " + ex.Message);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar este Usuario", "Alerta", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      Usuario usuario = new Usuario();
      TipoUsuario tipoUsuario = new TipoUsuario();
      int num1 = 0;
      try
      {
        string str = tipoUsuario.retornaNombreTipoUsuario(this._usuarioVO.IdTipoUsuario);
        if (str.Equals("ADMINISTRADOR"))
          num1 = usuario.cuentaTipoUsuario(this._usuarioVO.IdTipoUsuario);
        if (str.Equals("ADMINISTRADOR") && num1 == 1)
        {
          int num2 = (int) MessageBox.Show("No se puede Eliminar este Usuario, Unico usuario Administrador");
          this.iniciaFormulario();
        }
        else
        {
          usuario.eliminaUsuario(this.idUsuario);
          this.iniciaFormulario();
        }
      }
      catch (Exception ex)
      {
        int num2 = (int) MessageBox.Show("Error al Eliminar Usuario " + ex.Message);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modUsuario = 0;
      this.Dispose();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.cmbListaPrecio = new ComboBox();
      this.cmbBodega = new ComboBox();
      this.cmbCaja = new ComboBox();
      this.cmbTipo = new ComboBox();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.txtClave = new TextBox();
      this.txtNombre = new TextBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.btnGuardar = new Button();
      this.btnModificar = new Button();
      this.btnEliminar = new Button();
      this.btnLimpiar = new Button();
      this.btnSalir = new Button();
      this.dgvUsuarios = new DataGridView();
      this.groupBox2 = new GroupBox();
      this.chkModificaStock = new CheckBox();
      this.chkInformeCaja = new CheckBox();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvUsuarios).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.cmbListaPrecio);
      this.groupBox1.Controls.Add((Control) this.cmbBodega);
      this.groupBox1.Controls.Add((Control) this.cmbCaja);
      this.groupBox1.Controls.Add((Control) this.cmbTipo);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Location = new Point(11, 89);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(420, 110);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.cmbListaPrecio.BackColor = Color.White;
      this.cmbListaPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbListaPrecio.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmbListaPrecio.FormattingEnabled = true;
      this.cmbListaPrecio.Location = new Point(213, 77);
      this.cmbListaPrecio.Name = "cmbListaPrecio";
      this.cmbListaPrecio.Size = new Size(200, 21);
      this.cmbListaPrecio.TabIndex = 10;
      this.cmbBodega.BackColor = Color.White;
      this.cmbBodega.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbBodega.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmbBodega.FormattingEnabled = true;
      this.cmbBodega.Location = new Point(7, 77);
      this.cmbBodega.Name = "cmbBodega";
      this.cmbBodega.Size = new Size(200, 21);
      this.cmbBodega.TabIndex = 6;
      this.cmbCaja.BackColor = Color.White;
      this.cmbCaja.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbCaja.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmbCaja.FormattingEnabled = true;
      this.cmbCaja.Location = new Point(213, 32);
      this.cmbCaja.Name = "cmbCaja";
      this.cmbCaja.Size = new Size(200, 21);
      this.cmbCaja.TabIndex = 5;
      this.cmbTipo.BackColor = Color.White;
      this.cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTipo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cmbTipo.FormattingEnabled = true;
      this.cmbTipo.Location = new Point(7, 32);
      this.cmbTipo.Name = "cmbTipo";
      this.cmbTipo.Size = new Size(200, 21);
      this.cmbTipo.TabIndex = 4;
      this.label6.BackColor = Color.FromArgb(64, 64, 64);
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(213, 58);
      this.label6.Name = "label6";
      this.label6.Size = new Size(200, 23);
      this.label6.TabIndex = 11;
      this.label6.Text = "Lista de Precio";
      this.label5.BackColor = Color.FromArgb(64, 64, 64);
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(213, 13);
      this.label5.Name = "label5";
      this.label5.Size = new Size(200, 23);
      this.label5.TabIndex = 9;
      this.label5.Text = "Caja";
      this.label4.BackColor = Color.FromArgb(64, 64, 64);
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(7, 58);
      this.label4.Name = "label4";
      this.label4.Size = new Size(200, 23);
      this.label4.TabIndex = 8;
      this.label4.Text = "Bodega";
      this.label3.BackColor = Color.FromArgb(64, 64, 64);
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(7, 13);
      this.label3.Name = "label3";
      this.label3.Size = new Size(200, 23);
      this.label3.TabIndex = 7;
      this.label3.Text = "Tipo de Usuario";
      this.txtClave.Location = new Point(213, 31);
      this.txtClave.MaxLength = 100;
      this.txtClave.Name = "txtClave";
      this.txtClave.Size = new Size(200, 20);
      this.txtClave.TabIndex = 3;
      this.txtNombre.Location = new Point(7, 31);
      this.txtNombre.MaxLength = 100;
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(200, 20);
      this.txtNombre.TabIndex = 2;
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(213, 15);
      this.label2.Name = "label2";
      this.label2.Size = new Size(200, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "CLAVE";
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(7, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(199, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "USUARIO";
      this.btnGuardar.Location = new Point(437, 19);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 31);
      this.btnGuardar.TabIndex = 1;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnModificar.Location = new Point(437, 52);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 31);
      this.btnModificar.TabIndex = 2;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnEliminar.Location = new Point(437, 85);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(75, 31);
      this.btnEliminar.TabIndex = 3;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnLimpiar.Location = new Point(437, 118);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 31);
      this.btnLimpiar.TabIndex = 4;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnSalir.Location = new Point(437, 165);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 31);
      this.btnSalir.TabIndex = 5;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.dgvUsuarios.AllowUserToAddRows = false;
      this.dgvUsuarios.AllowUserToDeleteRows = false;
      this.dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvUsuarios.Location = new Point(11, 205);
      this.dgvUsuarios.Name = "dgvUsuarios";
      this.dgvUsuarios.ReadOnly = true;
      this.dgvUsuarios.RowHeadersVisible = false;
      this.dgvUsuarios.RowHeadersWidth = 36;
      this.dgvUsuarios.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvUsuarios.Size = new Size(502, 262);
      this.dgvUsuarios.TabIndex = 6;
      this.dgvUsuarios.DoubleClick += new EventHandler(this.dgvUsuarios_DoubleClick);
      this.groupBox2.Controls.Add((Control) this.txtClave);
      this.groupBox2.Controls.Add((Control) this.txtNombre);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Location = new Point(11, 13);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(420, 58);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.chkModificaStock.AutoSize = true;
      this.chkModificaStock.Location = new Point(14, 76);
      this.chkModificaStock.Name = "chkModificaStock";
      this.chkModificaStock.Size = new Size(194, 17);
      this.chkModificaStock.TabIndex = 8;
      this.chkModificaStock.Text = "Puede Modificar Stock de Bodegas";
      this.chkModificaStock.UseVisualStyleBackColor = true;
      this.chkInformeCaja.AutoSize = true;
      this.chkInformeCaja.Location = new Point(227, 76);
      this.chkInformeCaja.Name = "chkInformeCaja";
      this.chkInformeCaja.Size = new Size(178, 17);
      this.chkInformeCaja.TabIndex = 9;
      this.chkInformeCaja.Text = "Ver Informes de Todas las Cajas";
      this.chkInformeCaja.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(524, 483);
      this.Controls.Add((Control) this.chkInformeCaja);
      this.Controls.Add((Control) this.chkModificaStock);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.dgvUsuarios);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.btnEliminar);
      this.Controls.Add((Control) this.btnModificar);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.groupBox1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmUsuario";
      this.ShowIcon = false;
      this.Text = "Modulo de Usuario";
      this.FormClosing += new FormClosingEventHandler(this.frmUsuario_FormClosing);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvUsuarios).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
