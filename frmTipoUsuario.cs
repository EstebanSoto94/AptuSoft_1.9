 
// Type: Aptusoft.frmTipoUsuario
 
 
// version 1.8.0

using Aptusoft.DtsReportesTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmTipoUsuario : Form
  {
    private IContainer components = (IContainer) null;
    private ArrayList modulos = new ArrayList();
    private List<DetalleTipoUsuarioVO> listaPermisos = new List<DetalleTipoUsuarioVO>();
    private List<TipoUsuarioVO> listaTipoUsuarios = new List<TipoUsuarioVO>();
    private int idTipo = 0;
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private GroupBox groupBox1;
    private TextBox txtNombre;
    private Label label1;
    private DataGridView dgvPermisos;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private DataGridView dgvLista;
    private CheckBox chkCambioPrecio;
    private CheckBox chkDescuento;
    private CheckBox chkAnula;
    private CheckBox chkElimina;
    private CheckBox chkModifica;
    private CheckBox chkGuarda;
    private CheckBox chkIngresa;
    private Panel pnlSeleccionaFila;
    private CheckBox chkSeleccionaTodo;
    private Label label2;
    private Button btnPermisoInformes;
    private CheckBox chkCambioFecha;
    private TicketTableAdapter ticketTableAdapter1;

    public frmTipoUsuario()
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
      this.btnPermisoInformes = new Button();
      this.dgvPermisos = new DataGridView();
      this.txtNombre = new TextBox();
      this.label1 = new Label();
      this.pnlSeleccionaFila = new Panel();
      this.chkCambioFecha = new CheckBox();
      this.chkSeleccionaTodo = new CheckBox();
      this.chkCambioPrecio = new CheckBox();
      this.chkIngresa = new CheckBox();
      this.chkDescuento = new CheckBox();
      this.chkGuarda = new CheckBox();
      this.chkAnula = new CheckBox();
      this.chkModifica = new CheckBox();
      this.chkElimina = new CheckBox();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.btnGuardar = new Button();
      this.btnModificar = new Button();
      this.dgvLista = new DataGridView();
      this.label2 = new Label();
      this.ticketTableAdapter1 = new TicketTableAdapter();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvPermisos).BeginInit();
      this.pnlSeleccionaFila.SuspendLayout();
      ((ISupportInitialize) this.dgvLista).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.btnPermisoInformes);
      this.groupBox1.Controls.Add((Control) this.dgvPermisos);
      this.groupBox1.Controls.Add((Control) this.txtNombre);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.pnlSeleccionaFila);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(788, 517);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.btnPermisoInformes.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnPermisoInformes.Location = new Point(508, 16);
      this.btnPermisoInformes.Name = "btnPermisoInformes";
      this.btnPermisoInformes.Size = new Size(266, 37);
      this.btnPermisoInformes.TabIndex = 12;
      this.btnPermisoInformes.Text = "Permiso para Informes";
      this.btnPermisoInformes.UseVisualStyleBackColor = true;
      this.btnPermisoInformes.Click += new EventHandler(this.btnPermisoInformes_Click);
      this.dgvPermisos.AllowUserToAddRows = false;
      this.dgvPermisos.AllowUserToDeleteRows = false;
      this.dgvPermisos.AllowUserToResizeColumns = false;
      this.dgvPermisos.AllowUserToResizeRows = false;
      gridViewCellStyle.BackColor = Color.Lavender;
      this.dgvPermisos.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvPermisos.BackgroundColor = Color.LightSteelBlue;
      this.dgvPermisos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
      this.dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPermisos.Location = new Point(9, 59);
      this.dgvPermisos.MultiSelect = false;
      this.dgvPermisos.Name = "dgvPermisos";
      this.dgvPermisos.RowHeadersWidth = 50;
      this.dgvPermisos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvPermisos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvPermisos.ScrollBars = ScrollBars.Vertical;
      this.dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvPermisos.Size = new Size(765, 398);
      this.dgvPermisos.TabIndex = 0;
      this.dgvPermisos.CellClick += new DataGridViewCellEventHandler(this.dgvPermisos_CellClick);
      this.txtNombre.Location = new Point(9, 32);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(266, 20);
      this.txtNombre.TabIndex = 1;
      this.txtNombre.TextChanged += new EventHandler(this.txtNombre_TextChanged);
      this.label1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new Point(10, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(264, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "TIPO DE USUARIO";
      this.pnlSeleccionaFila.BorderStyle = BorderStyle.Fixed3D;
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkCambioFecha);
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkSeleccionaTodo);
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkCambioPrecio);
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkIngresa);
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkDescuento);
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkGuarda);
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkAnula);
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkModifica);
      this.pnlSeleccionaFila.Controls.Add((Control) this.chkElimina);
      this.pnlSeleccionaFila.Location = new Point(6, 466);
      this.pnlSeleccionaFila.Name = "pnlSeleccionaFila";
      this.pnlSeleccionaFila.Size = new Size(768, 37);
      this.pnlSeleccionaFila.TabIndex = 10;
      this.pnlSeleccionaFila.Visible = false;
      this.chkCambioFecha.AutoSize = true;
      this.chkCambioFecha.Location = new Point(680, 10);
      this.chkCambioFecha.Name = "chkCambioFecha";
      this.chkCambioFecha.Size = new Size(15, 14);
      this.chkCambioFecha.TabIndex = 10;
      this.chkCambioFecha.UseVisualStyleBackColor = true;
      this.chkCambioFecha.CheckedChanged += new EventHandler(this.chkCambioFecha_CheckedChanged);
      this.chkSeleccionaTodo.AutoSize = true;
      this.chkSeleccionaTodo.Location = new Point(5, 7);
      this.chkSeleccionaTodo.Name = "chkSeleccionaTodo";
      this.chkSeleccionaTodo.Size = new Size(110, 17);
      this.chkSeleccionaTodo.TabIndex = 9;
      this.chkSeleccionaTodo.Text = "Seleccionar Todo";
      this.chkSeleccionaTodo.UseVisualStyleBackColor = true;
      this.chkSeleccionaTodo.CheckedChanged += new EventHandler(this.chkSeleccionaTodo_CheckedChanged);
      this.chkCambioPrecio.AutoSize = true;
      this.chkCambioPrecio.Location = new Point(590, 10);
      this.chkCambioPrecio.Name = "chkCambioPrecio";
      this.chkCambioPrecio.Size = new Size(15, 14);
      this.chkCambioPrecio.TabIndex = 8;
      this.chkCambioPrecio.UseVisualStyleBackColor = true;
      this.chkCambioPrecio.CheckedChanged += new EventHandler(this.chkCambioPrecio_CheckedChanged);
      this.chkIngresa.AutoSize = true;
      this.chkIngresa.Location = new Point(215, 10);
      this.chkIngresa.Name = "chkIngresa";
      this.chkIngresa.Size = new Size(15, 14);
      this.chkIngresa.TabIndex = 2;
      this.chkIngresa.UseVisualStyleBackColor = true;
      this.chkIngresa.CheckedChanged += new EventHandler(this.chkIngresa_CheckedChanged);
      this.chkDescuento.AutoSize = true;
      this.chkDescuento.Location = new Point(515, 10);
      this.chkDescuento.Name = "chkDescuento";
      this.chkDescuento.Size = new Size(15, 14);
      this.chkDescuento.TabIndex = 7;
      this.chkDescuento.UseVisualStyleBackColor = true;
      this.chkDescuento.CheckedChanged += new EventHandler(this.chkDescuento_CheckedChanged);
      this.chkGuarda.AutoSize = true;
      this.chkGuarda.Location = new Point(275, 10);
      this.chkGuarda.Name = "chkGuarda";
      this.chkGuarda.Size = new Size(15, 14);
      this.chkGuarda.TabIndex = 3;
      this.chkGuarda.UseVisualStyleBackColor = true;
      this.chkGuarda.CheckedChanged += new EventHandler(this.chkGuarda_CheckedChanged);
      this.chkAnula.AutoSize = true;
      this.chkAnula.Location = new Point(455, 10);
      this.chkAnula.Name = "chkAnula";
      this.chkAnula.Size = new Size(15, 14);
      this.chkAnula.TabIndex = 6;
      this.chkAnula.UseVisualStyleBackColor = true;
      this.chkAnula.CheckedChanged += new EventHandler(this.chkAnula_CheckedChanged);
      this.chkModifica.AutoSize = true;
      this.chkModifica.Location = new Point(335, 10);
      this.chkModifica.Name = "chkModifica";
      this.chkModifica.Size = new Size(15, 14);
      this.chkModifica.TabIndex = 4;
      this.chkModifica.UseVisualStyleBackColor = true;
      this.chkModifica.CheckedChanged += new EventHandler(this.chkModifica_CheckedChanged);
      this.chkElimina.AutoSize = true;
      this.chkElimina.Location = new Point(395, 10);
      this.chkElimina.Name = "chkElimina";
      this.chkElimina.Size = new Size(15, 14);
      this.chkElimina.TabIndex = 5;
      this.chkElimina.UseVisualStyleBackColor = true;
      this.chkElimina.CheckedChanged += new EventHandler(this.chkElimina_CheckedChanged);
      this.btnSalir.Location = new Point(806, 433);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 36);
      this.btnSalir.TabIndex = 5;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Location = new Point(806, 391);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 36);
      this.btnLimpiar.TabIndex = 4;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnEliminar.Location = new Point(806, 349);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(75, 36);
      this.btnEliminar.TabIndex = 3;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnGuardar.Location = new Point(806, 265);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 36);
      this.btnGuardar.TabIndex = 1;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnModificar.Location = new Point(806, 307);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 36);
      this.btnModificar.TabIndex = 2;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.dgvLista.AllowUserToAddRows = false;
      this.dgvLista.AllowUserToDeleteRows = false;
      this.dgvLista.AllowUserToResizeColumns = false;
      this.dgvLista.AllowUserToResizeRows = false;
      this.dgvLista.BackgroundColor = Color.LightSteelBlue;
      this.dgvLista.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
      this.dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLista.Location = new Point(806, 38);
      this.dgvLista.MultiSelect = false;
      this.dgvLista.Name = "dgvLista";
      this.dgvLista.ReadOnly = true;
      this.dgvLista.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvLista.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvLista.ScrollBars = ScrollBars.Vertical;
      this.dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvLista.Size = new Size(242, 122);
      this.dgvLista.TabIndex = 6;
      this.dgvLista.DoubleClick += new EventHandler(this.dgvLista_DoubleClick);
      this.label2.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label2.ForeColor = Color.Black;
      this.label2.Location = new Point(806, 19);
      this.label2.Name = "label2";
      this.label2.Size = new Size(242, 23);
      this.label2.TabIndex = 11;
      this.label2.Text = "LISTA DE TIPOS DE USUARIOS";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.ticketTableAdapter1.ClearBeforeFill = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1068, 740);
      this.Controls.Add((Control) this.dgvLista);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.btnModificar);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.btnEliminar);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "frmTipoUsuario";
      this.ShowIcon = false;
      this.Text = "Tipos de Usuarios";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmTipoUsuario_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.dgvPermisos).EndInit();
      this.pnlSeleccionaFila.ResumeLayout(false);
      this.pnlSeleccionaFila.PerformLayout();
      ((ISupportInitialize) this.dgvLista).EndInit();
      this.ResumeLayout(false);
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("TIPO USUARIO"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    private void cargalistaTipoUsuario()
    {
      TipoUsuario tipoUsuario = new TipoUsuario();
      try
      {
        this.listaTipoUsuarios = tipoUsuario.listaTiposUsuario();
        this.dgvLista.DataSource = (object) this.listaTipoUsuarios;
        this.numFila(this.dgvLista);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Tipos de Usuario: " + ex.Message);
      }
    }

    private void iniciaFormulario()
    {
      this.txtNombre.Clear();
      this.txtNombre.Focus();
      this.pnlSeleccionaFila.Visible = false;
      this.chkSeleccionaTodo.Checked = false;
      this.chkIngresa.Checked = false;
      this.chkGuarda.Checked = false;
      this.chkModifica.Checked = false;
      this.chkElimina.Checked = false;
      this.chkAnula.Checked = false;
      this.chkDescuento.Checked = false;
      this.chkCambioPrecio.Checked = false;
      this.dgvPermisos.DataSource = (object) null;
      this.dgvPermisos.Columns.Clear();
      this.dgvLista.DataSource = (object) null;
      this.dgvLista.Columns.Clear();
      this.idTipo = 0;
      this.listaPermisos.Clear();
      this.creaColumnasPermisos();
      this.creaColumnasTipos();
      this.cargalistaTipoUsuario();
      this.cargaModulos();
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.btnGuardar.Enabled = false;
      this.btnPermisoInformes.Enabled = false;
    }

    private bool valida()
    {
      if (this.txtNombre.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Una Descripción");
        this.txtNombre.Focus();
        return false;
      }
      if (new TipoUsuario().retornaIdTipoUsuario(this.txtNombre.Text.Trim().ToUpper()) == 0 || this.idTipo != 0)
        return true;
      int num1 = (int) MessageBox.Show("El Tipo de Usuario ya Existe");
      this.txtNombre.Focus();
      return false;
    }

    private void creaColumnasPermisos()
    {
      this.dgvPermisos.AutoGenerateColumns = false;
      this.dgvPermisos.Columns.Add("IdDetalleTipoUsuario", "IdDetalleTipoUsuario");
      this.dgvPermisos.Columns[0].DataPropertyName = "IdDetalleTipoUsuario";
      this.dgvPermisos.Columns[0].Width = 20;
      this.dgvPermisos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvPermisos.Columns[0].Visible = false;
      this.dgvPermisos.Columns.Add("IdTipoUsuario", "IdTipoUsuario");
      this.dgvPermisos.Columns[1].DataPropertyName = "IdTipoUsuario";
      this.dgvPermisos.Columns[1].Width = 20;
      this.dgvPermisos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvPermisos.Columns[1].Visible = false;
      this.dgvPermisos.Columns.Add("Modulo", "Modulo");
      this.dgvPermisos.Columns[2].DataPropertyName = "Modulo";
      this.dgvPermisos.Columns[2].Width = 140;
      this.dgvPermisos.Columns[2].Resizable = DataGridViewTriState.True;
      this.dgvPermisos.Columns[2].ReadOnly = true;
      DataGridViewCheckBoxColumn viewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn1.Name = "Ingresar";
      viewCheckBoxColumn1.HeaderText = "Ingresar";
      viewCheckBoxColumn1.DataPropertyName = "Ingresa";
      viewCheckBoxColumn1.Width = 60;
      viewCheckBoxColumn1.DisplayIndex = 3;
      viewCheckBoxColumn1.FalseValue = (object) 0;
      viewCheckBoxColumn1.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn1);
      DataGridViewCheckBoxColumn viewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn2.Name = "Guardar";
      viewCheckBoxColumn2.HeaderText = "Guardar";
      viewCheckBoxColumn2.DataPropertyName = "Guarda";
      viewCheckBoxColumn2.Width = 60;
      viewCheckBoxColumn2.DisplayIndex = 4;
      viewCheckBoxColumn2.FalseValue = (object) 0;
      viewCheckBoxColumn2.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn2);
      DataGridViewCheckBoxColumn viewCheckBoxColumn3 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn3.Name = "Modificar";
      viewCheckBoxColumn3.HeaderText = "Modificar";
      viewCheckBoxColumn3.DataPropertyName = "Modifica";
      viewCheckBoxColumn3.Width = 60;
      viewCheckBoxColumn3.DisplayIndex = 5;
      viewCheckBoxColumn3.FalseValue = (object) 0;
      viewCheckBoxColumn3.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn3);
      DataGridViewCheckBoxColumn viewCheckBoxColumn4 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn4.Name = "Eliminar";
      viewCheckBoxColumn4.HeaderText = "Eliminar";
      viewCheckBoxColumn4.DataPropertyName = "Elimina";
      viewCheckBoxColumn4.Width = 60;
      viewCheckBoxColumn4.DisplayIndex = 6;
      viewCheckBoxColumn4.FalseValue = (object) 0;
      viewCheckBoxColumn4.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn4);
      DataGridViewCheckBoxColumn viewCheckBoxColumn5 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn5.Name = "Anular";
      viewCheckBoxColumn5.HeaderText = "Anular";
      viewCheckBoxColumn5.DataPropertyName = "Anula";
      viewCheckBoxColumn5.Width = 60;
      viewCheckBoxColumn5.DisplayIndex = 7;
      viewCheckBoxColumn5.FalseValue = (object) 0;
      viewCheckBoxColumn5.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn5);
      DataGridViewCheckBoxColumn viewCheckBoxColumn6 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn6.Name = "Descuento";
      viewCheckBoxColumn6.HeaderText = "Descuento";
      viewCheckBoxColumn6.DataPropertyName = "Descuento";
      viewCheckBoxColumn6.Width = 60;
      viewCheckBoxColumn6.DisplayIndex = 8;
      viewCheckBoxColumn6.FalseValue = (object) 0;
      viewCheckBoxColumn6.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn6);
      DataGridViewCheckBoxColumn viewCheckBoxColumn7 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn7.Name = "CambioPrecio";
      viewCheckBoxColumn7.HeaderText = "Cambio Precio";
      viewCheckBoxColumn7.DataPropertyName = "CambioPrecio";
      viewCheckBoxColumn7.Width = 90;
      viewCheckBoxColumn7.DisplayIndex = 9;
      viewCheckBoxColumn7.FalseValue = (object) 0;
      viewCheckBoxColumn7.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn7);
      DataGridViewCheckBoxColumn viewCheckBoxColumn8 = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn8.Name = "CambioFecha";
      viewCheckBoxColumn8.HeaderText = "Cambio Fecha";
      viewCheckBoxColumn8.DataPropertyName = "CambioFecha";
      viewCheckBoxColumn8.Width = 90;
      viewCheckBoxColumn8.DisplayIndex = 10;
      viewCheckBoxColumn8.FalseValue = (object) 0;
      viewCheckBoxColumn8.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn8);
    }

    private void creaColumnasTipos()
    {
      this.dgvLista.AutoGenerateColumns = false;
      this.dgvLista.Columns.Add("IdTipoUsuario", "IdTipoUsuario");
      this.dgvLista.Columns[0].DataPropertyName = "IdTipoUsuario";
      this.dgvLista.Columns[0].Width = 20;
      this.dgvLista.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvLista.Columns[0].Visible = false;
      this.dgvLista.Columns.Add("NombreTipoUsuario", "Descripcion");
      this.dgvLista.Columns[1].DataPropertyName = "NombreTipoUsuario";
      this.dgvLista.Columns[1].Width = 190;
      this.dgvPermisos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvLista.Columns[1].ReadOnly = true;
    }

    private void cargaModulos()
    {
      this.modulos.Clear();
      this.modulos.Add((object) "TICKET");
      this.modulos.Add((object) "COTIZACION");
      this.modulos.Add((object) "GUIA");
      this.modulos.Add((object) "BOLETA");
      this.modulos.Add((object) "FACTURA");
      this.modulos.Add((object) "FACTURA EXENTA");
      this.modulos.Add((object) "COMANDA");
      this.modulos.Add((object) "E-FACTURA");
      this.modulos.Add((object) "E-FACTURA-EXENTA");
      this.modulos.Add((object) "E-GUIA");
      this.modulos.Add((object) "E-NOTA CREDITO");
      this.modulos.Add((object) "E-NOTA DEBITO");
      this.modulos.Add((object) "E-BOLETA");
      this.modulos.Add((object) "E-BOLETA-EXENTA");
      this.modulos.Add((object) "CAF");
      this.modulos.Add((object) "GENERADOR_ENVIOS");
      this.modulos.Add((object) "NOTA VENTA");
      this.modulos.Add((object) "NOTA CREDITO");
      this.modulos.Add((object) "CLIENTE");
      this.modulos.Add((object) "PAGOS VENTAS");
      this.modulos.Add((object) "CONTROL CAJA");
      this.modulos.Add((object) "CUENTA CORRIENTE");
      this.modulos.Add((object) "ORDEN TRABAJO");
      this.modulos.Add((object) "TECNICO");
      this.modulos.Add((object) "ORDEN COMPRA");
      this.modulos.Add((object) "COMPRAS");
      this.modulos.Add((object) "PROVEEDOR");
      this.modulos.Add((object) "PAGOS COMPRAS");
      this.modulos.Add((object) "SERVICIOS");
      this.modulos.Add((object) "CATEGORIA");
      this.modulos.Add((object) "PRODUCTO");
      this.modulos.Add((object) "UNIDAD MEDIDA");
      this.modulos.Add((object) "CREA FORMULA KIT");
      this.modulos.Add((object) "ARMAR KIT");
      this.modulos.Add((object) "TRASPASO INTERNO");
      this.modulos.Add((object) "TOMA_INVENTARIO");
      this.modulos.Add((object) "OPCIONES");
      this.modulos.Add((object) "IMPRESORA");
      this.modulos.Add((object) "TIPO USUARIO");
      this.modulos.Add((object) "USUARIO");
      this.modulos.Add((object) "IMPUESTOS ESPECIALES");
      this.modulos.Add((object) "VENDEDORES");
      this.modulos.Add((object) "CENTRO DE COSTO");
      this.modulos.Add((object) "MEDIOS DE PAGO");
      this.modulos.Add((object) "BANCOS");
      this.modulos.Add((object) "PERIODOS");
      this.modulos.Add((object) "GARZONES");
      this.modulos.Add((object) "RUBROS");
    }

    private void cargaColumaPermisos()
    {
      List<DetalleTipoUsuarioVO> list = new List<DetalleTipoUsuarioVO>();
      DetalleTipoUsuarioVO detalleTipoUsuarioVo = new DetalleTipoUsuarioVO();
      for (int index = 0; index < this.modulos.Count; ++index)
        list.Add(new DetalleTipoUsuarioVO()
        {
          Modulo = this.modulos[index].ToString()
        });
      this.dgvPermisos.DataSource = (object) null;
      this.dgvPermisos.DataSource = (object) list;
      this.numFila(this.dgvPermisos);
    }

    private void txtNombre_TextChanged(object sender, EventArgs e)
    {
      if (this.txtNombre.Text.Trim().Length <= 0 || this.idTipo != 0)
        return;
      this.cargaColumaPermisos();
      this.pnlSeleccionaFila.Visible = true;
      if (this._guarda)
        this.btnGuardar.Enabled = true;
    }

    private void numFila(DataGridView dgv)
    {
      if (dgv.Rows.Count <= 0)
        return;
      for (int index = 0; index < dgv.Rows.Count; ++index)
        dgv.Rows[index].HeaderCell.Value = (object) (index + 1).ToString();
    }

    private void chkIngresa_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkIngresa.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Ingresar"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Ingresar"].Value = (object) false;
      }
    }

    private void chkGuarda_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkGuarda.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Guardar"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Guardar"].Value = (object) false;
      }
    }

    private void chkModifica_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkModifica.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Modificar"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Modificar"].Value = (object) false;
      }
    }

    private void chkElimina_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkElimina.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Eliminar"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Eliminar"].Value = (object) false;
      }
    }

    private void chkAnula_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkAnula.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Anular"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Anular"].Value = (object) false;
      }
    }

    private void chkDescuento_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkDescuento.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Descuento"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Descuento"].Value = (object) false;
      }
    }

    private void chkCambioPrecio_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkCambioPrecio.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["CambioPrecio"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["CambioPrecio"].Value = (object) false;
      }
    }

    private void chkSeleccionaTodo_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSeleccionaTodo.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
        {
          dataGridViewRow.Cells["Ingresar"].Value = (object) true;
          dataGridViewRow.Cells["Guardar"].Value = (object) true;
          dataGridViewRow.Cells["Modificar"].Value = (object) true;
          dataGridViewRow.Cells["Eliminar"].Value = (object) true;
          dataGridViewRow.Cells["Anular"].Value = (object) true;
          dataGridViewRow.Cells["Descuento"].Value = (object) true;
          dataGridViewRow.Cells["CambioPrecio"].Value = (object) true;
          dataGridViewRow.Cells["CambioFecha"].Value = (object) true;
        }
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
        {
          dataGridViewRow.Cells["Ingresar"].Value = (object) false;
          dataGridViewRow.Cells["Guardar"].Value = (object) false;
          dataGridViewRow.Cells["Modificar"].Value = (object) false;
          dataGridViewRow.Cells["Eliminar"].Value = (object) false;
          dataGridViewRow.Cells["Anular"].Value = (object) false;
          dataGridViewRow.Cells["Descuento"].Value = (object) false;
          dataGridViewRow.Cells["CambioPrecio"].Value = (object) false;
          dataGridViewRow.Cells["CambioFecha"].Value = (object) false;
        }
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      TipoUsuarioVO tuVO = new TipoUsuarioVO();
      tuVO.NombreTipoUsuario = this.txtNombre.Text.Trim().ToUpper();
      DetalleTipoUsuarioVO detalleTipoUsuarioVo = new DetalleTipoUsuarioVO();
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
        this.listaPermisos.Add(new DetalleTipoUsuarioVO()
        {
          Modulo = dataGridViewRow.Cells["Modulo"].Value.ToString(),
          Ingresa = Convert.ToBoolean(dataGridViewRow.Cells["Ingresar"].Value),
          Guarda = Convert.ToBoolean(dataGridViewRow.Cells["Guardar"].Value),
          Modifica = Convert.ToBoolean(dataGridViewRow.Cells["Modificar"].Value),
          Elimina = Convert.ToBoolean(dataGridViewRow.Cells["Eliminar"].Value),
          Anula = Convert.ToBoolean(dataGridViewRow.Cells["Anular"].Value),
          Descuento = Convert.ToBoolean(dataGridViewRow.Cells["Descuento"].Value),
          CambioPrecio = Convert.ToBoolean(dataGridViewRow.Cells["CambioPrecio"].Value),
          CambioFecha = Convert.ToBoolean(dataGridViewRow.Cells["CambioFecha"].Value)
        });
      TipoUsuario tipoUsuario = new TipoUsuario();
      try
      {
        tipoUsuario.guardaTipoUsuario(tuVO, this.listaPermisos);
        int num = (int) MessageBox.Show("Tipo de Usuario Guardado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar Tipos de Usuario: " + ex.Message);
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      frmMenuPrincipal._modTipoUsuario = 0;
    }

    private void dgvLista_DoubleClick(object sender, EventArgs e)
    {
      this.dgvPermisos.DataSource = (object) null;
      int rowIndex = this.dgvLista.CurrentCell.RowIndex;
      this.idTipo = Convert.ToInt32(this.dgvLista.Rows[rowIndex].Cells[0].Value.ToString());
      this.txtNombre.Text = this.dgvLista.Rows[rowIndex].Cells[1].Value.ToString();
      TipoUsuario tipoUsuario = new TipoUsuario();
      try
      {
        this.listaPermisos = tipoUsuario.listaDetalleTipoUsuario(this.idTipo);
        DetalleTipoUsuarioVO detalleTipoUsuarioVo = new DetalleTipoUsuarioVO();
        for (int index1 = 0; index1 < this.modulos.Count; ++index1)
        {
          string str = this.modulos[index1].ToString();
          bool flag = false;
          int num = 0;
          for (int index2 = 0; index2 < this.listaPermisos.Count; ++index2)
          {
            num = this.listaPermisos[index2].IdTipoUsuario;
            if (this.listaPermisos[index2].Modulo.Equals(str))
            {
              index2 = this.listaPermisos.Count;
              flag = true;
            }
          }
          if (!flag)
            this.listaPermisos.Add(new DetalleTipoUsuarioVO()
            {
              IdTipoUsuario = num,
              Modulo = str,
              Ingresa = false,
              Guarda = false,
              Modifica = false,
              Elimina = false,
              Anula = false,
              Descuento = false,
              CambioPrecio = false,
              CambioFecha = false
            });
        }
        this.dgvPermisos.DataSource = (object) this.listaPermisos;
        this.numFila(this.dgvPermisos);
        this.pnlSeleccionaFila.Visible = true;
        if (this._modifica)
          this.btnModificar.Enabled = true;
        if (this._elimina)
          this.btnEliminar.Enabled = true;
        this.btnPermisoInformes.Enabled = true;
        this.btnGuardar.Enabled = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Tipo: " + ex.Message);
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      TipoUsuarioVO tuVO = new TipoUsuarioVO();
      tuVO.IdTipoUsuario = this.idTipo;
      tuVO.NombreTipoUsuario = this.txtNombre.Text.Trim().ToUpper();
      DetalleTipoUsuarioVO detalleTipoUsuarioVo = new DetalleTipoUsuarioVO();
      List<DetalleTipoUsuarioVO> lista = new List<DetalleTipoUsuarioVO>();
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
        lista.Add(new DetalleTipoUsuarioVO()
        {
          IdDetalleTipoUsuario = Convert.ToInt32(dataGridViewRow.Cells["IdDetalleTipoUsuario"].Value.ToString()),
          IdTipoUsuario = Convert.ToInt32(dataGridViewRow.Cells["IdTipoUsuario"].Value.ToString()),
          Modulo = dataGridViewRow.Cells["Modulo"].Value.ToString(),
          Ingresa = Convert.ToBoolean(dataGridViewRow.Cells["Ingresar"].Value),
          Guarda = Convert.ToBoolean(dataGridViewRow.Cells["Guardar"].Value),
          Modifica = Convert.ToBoolean(dataGridViewRow.Cells["Modificar"].Value),
          Elimina = Convert.ToBoolean(dataGridViewRow.Cells["Eliminar"].Value),
          Anula = Convert.ToBoolean(dataGridViewRow.Cells["Anular"].Value),
          Descuento = Convert.ToBoolean(dataGridViewRow.Cells["Descuento"].Value),
          CambioPrecio = Convert.ToBoolean(dataGridViewRow.Cells["CambioPrecio"].Value),
          CambioFecha = Convert.ToBoolean(dataGridViewRow.Cells["CambioFecha"].Value)
        });
      TipoUsuario tipoUsuario = new TipoUsuario();
      try
      {
        tipoUsuario.modificarTipoUsuario(tuVO, lista);
        int num = (int) MessageBox.Show("Tipo de Usuario Modificado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Modificar tipo de Usuario" + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar el Tipo de Usuario", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          new TipoUsuario().eliminaTipoUsuario(this.idTipo);
          new PermisoInforme().eliminaPermisoInformeIdTipoUsuario(this.idTipo);
          int num = (int) MessageBox.Show("Tipo de Usuario Eliminado");
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar Tipo: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Tipo de Usuario NO fue Eliminado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void frmTipoUsuario_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modTipoUsuario = 0;
      this.Dispose();
    }

    private void dgvPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void btnPermisoInformes_Click(object sender, EventArgs e)
    {
      int num = (int) new frmPermisoInforme(this.txtNombre.Text.ToUpper(), this.idTipo).ShowDialog();
    }

    private void chkCambioFecha_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkCambioFecha.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["CambioFecha"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["CambioFecha"].Value = (object) false;
      }
    }
  }
}
