 
// Type: Aptusoft.frmLicencia
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmLicencia : Form
  {
    private List<LicenciaVO> listaLicencia = new List<LicenciaVO>();
    private frmOrdenAtencion frmOA = (frmOrdenAtencion) null;
    private IContainer components = (IContainer) null;
    private int idCliente;
    private int idLicencia;
    private TextBox txtRut;
    private TextBox txtDigito;
    private TextBox txtRazonSocial;
    private TextBox txtMac1;
    private TextBox txtMac2;
    private TextBox txtMac3;
    private TextBox txtMac4;
    private TextBox txtMac5;
    private TextBox txtMac6;
    private Label label1;
    private Label label2;
    private GroupBox groupBox1;
    private DataGridView dgvLicencias;
    private Button btnLimpia;
    private Button btnAgregar;
    private Button btnModificar;
    private Button btnSalir;
    private Label label3;
    private Label label4;
    private TextBox txtContacto;
    private Label label5;
    private Label label6;
    private TextBox txtClave;
    private TextBox txtContraclave;
    private GroupBox groupBox2;
    private DateTimePicker dtpFecha;
    private Label label7;

    public frmLicencia()
    {
      this.InitializeComponent();
      this.iniciaFormulario();
    }

    public frmLicencia(int ic, string r, string d, string rs, frmOrdenAtencion oa)
    {
      this.InitializeComponent();
      this.idCliente = ic;
      this.txtMac1.Focus();
      this.txtRut.Text = r;
      this.txtRut.Enabled = false;
      this.txtDigito.Text = d;
      this.txtDigito.Enabled = false;
      this.txtRazonSocial.Text = rs;
      this.txtRazonSocial.Enabled = false;
      this.iniciaFormulario();
      this.frmOA = oa;
    }

    private void iniciaFormulario()
    {
      this.limpiaDatos();
      this.dgvLicencias.DataSource = (object) null;
      this.dgvLicencias.Columns.Clear();
      this.creaColumnasLicencia();
      this.cargaListaLicencias();
    }

    private void limpiaDatos()
    {
      this.idLicencia = 0;
      this.txtMac1.Clear();
      this.txtMac2.Clear();
      this.txtMac3.Clear();
      this.txtMac4.Clear();
      this.txtMac5.Clear();
      this.txtMac6.Clear();
      this.txtClave.Clear();
      this.txtContraclave.Clear();
      this.txtContacto.Clear();
      this.txtMac1.Focus();
      this.btnModificar.Enabled = false;
      this.btnAgregar.Enabled = true;
      this.dtpFecha.Value = DateTime.Now;
    }

    private void cargaListaLicencias()
    {
      this.listaLicencia.Clear();
      this.listaLicencia = new Licencia().listaLicencia(this.idCliente);
      for (int index = 0; index < this.listaLicencia.Count; ++index)
        this.listaLicencia[index].Linea = index + 1;
      this.dgvLicencias.DataSource = (object) this.listaLicencia;
    }

    private void creaColumnasLicencia()
    {
      this.dgvLicencias.Columns.Clear();
      this.dgvLicencias.AutoGenerateColumns = false;
      this.dgvLicencias.Columns.Add("Linea", "");
      this.dgvLicencias.Columns[0].DataPropertyName = "Linea";
      this.dgvLicencias.Columns[0].Width = 20;
      this.dgvLicencias.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns[0].DefaultCellStyle.BackColor = Color.Gainsboro;
      this.dgvLicencias.Columns.Add("IdLicencia", "IdLicencia");
      this.dgvLicencias.Columns[1].DataPropertyName = "IdLicencia";
      this.dgvLicencias.Columns[1].Width = 35;
      this.dgvLicencias.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns[1].Visible = false;
      this.dgvLicencias.Columns.Add("IdCliente", "IdCliente");
      this.dgvLicencias.Columns[2].DataPropertyName = "IdCliente";
      this.dgvLicencias.Columns[2].Width = 35;
      this.dgvLicencias.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns[2].Visible = false;
      this.dgvLicencias.Columns.Add("Rut", "Rut");
      this.dgvLicencias.Columns[3].DataPropertyName = "Rut";
      this.dgvLicencias.Columns[3].Width = 35;
      this.dgvLicencias.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns[3].Visible = false;
      this.dgvLicencias.Columns.Add("Mac", "Mac");
      this.dgvLicencias.Columns[4].DataPropertyName = "Mac";
      this.dgvLicencias.Columns[4].Width = 135;
      this.dgvLicencias.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns.Add("Clave", "Clave");
      this.dgvLicencias.Columns[5].DataPropertyName = "Clave";
      this.dgvLicencias.Columns[5].Width = 115;
      this.dgvLicencias.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns.Add("ContraClave", "Contra Clave");
      this.dgvLicencias.Columns[6].DataPropertyName = "ContraClave";
      this.dgvLicencias.Columns[6].Width = 115;
      this.dgvLicencias.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns.Add("Fecha", "Fecha Instalación");
      this.dgvLicencias.Columns[7].DataPropertyName = "Fecha";
      this.dgvLicencias.Columns[7].Width = 135;
      this.dgvLicencias.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvLicencias.Columns.Add("Contacto", "Contacto");
      this.dgvLicencias.Columns[8].DataPropertyName = "Contacto";
      this.dgvLicencias.Columns[8].Width = 150;
      this.dgvLicencias.Columns[8].Resizable = DataGridViewTriState.False;
      DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
      viewButtonColumn.Name = "Eliminar";
      viewButtonColumn.HeaderText = "Eliminar";
      viewButtonColumn.UseColumnTextForButtonValue = true;
      viewButtonColumn.Text = "X";
      viewButtonColumn.Width = 50;
      viewButtonColumn.DisplayIndex = 9;
      this.dgvLicencias.Columns.Add((DataGridViewColumn) viewButtonColumn);
    }

    private bool valida()
    {
      if (this.txtMac1.Text.Trim().Length != 0 && this.txtMac2.Text.Trim().Length != 0 && (this.txtMac3.Text.Trim().Length != 0 && this.txtMac4.Text.Trim().Length != 0) && this.txtMac5.Text.Trim().Length != 0 && this.txtMac6.Text.Trim().Length != 0)
        return true;
      int num = (int) MessageBox.Show("Debe Ingresar Una MAC completa", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtMac1.Focus();
      return false;
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      LicenciaVO li = new LicenciaVO();
      li.IdCliente = this.idCliente;
      li.Rut = this.txtRut.Text + "-" + this.txtDigito.Text;
      li.Mac = this.txtMac1.Text.Trim().ToUpper() + "-" + this.txtMac2.Text.Trim().ToUpper() + "-" + this.txtMac3.Text.Trim().ToUpper() + "-" + this.txtMac4.Text.Trim().ToUpper() + "-" + this.txtMac5.Text.Trim().ToUpper() + "-" + this.txtMac6.Text.Trim().ToUpper();
      li.Clave = this.txtClave.Text.Trim();
      li.ContraClave = this.txtContraclave.Text.Trim();
      li.Contacto = this.txtContacto.Text.Trim().ToUpper();
      DateTime dateTime=DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local = @dateTime;
      int year = this.dtpFecha.Value.Year;
      int month = this.dtpFecha.Value.Month;
      int day = this.dtpFecha.Value.Day;
      TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
      int hours = timeOfDay.Hours;
      DateTime now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int minutes = timeOfDay.Minutes;
      now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int seconds = timeOfDay.Seconds;
      // ISSUE: explicit reference operation
      local = new DateTime(year, month, day, hours, minutes, seconds);
      li.Fecha = dateTime;
      Licencia licencia = new Licencia();
      try
      {
        licencia.agregaLicencia(li);
        int num = (int) MessageBox.Show("Licencia Guardada", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      LicenciaVO li = new LicenciaVO();
      li.IdLicencia = this.idLicencia;
      li.IdCliente = this.idCliente;
      li.Rut = this.txtRut.Text + "-" + this.txtDigito.Text;
      li.Mac = this.txtMac1.Text.Trim().ToUpper() + "-" + this.txtMac2.Text.Trim().ToUpper() + "-" + this.txtMac3.Text.Trim().ToUpper() + "-" + this.txtMac4.Text.Trim().ToUpper() + "-" + this.txtMac5.Text.Trim().ToUpper() + "-" + this.txtMac6.Text.Trim().ToUpper();
      li.Clave = this.txtClave.Text.Trim();
      li.ContraClave = this.txtContraclave.Text.Trim();
      li.Contacto = this.txtContacto.Text.Trim().ToUpper();
      DateTime dateTime=DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local = @dateTime;
      int year = this.dtpFecha.Value.Year;
      int month = this.dtpFecha.Value.Month;
      int day = this.dtpFecha.Value.Day;
      TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
      int hours = timeOfDay.Hours;
      DateTime now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int minutes = timeOfDay.Minutes;
      now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int seconds = timeOfDay.Seconds;
      // ISSUE: explicit reference operation
      local = new DateTime(year, month, day, hours, minutes, seconds);
      li.Fecha = dateTime;
      Licencia licencia = new Licencia();
      try
      {
        licencia.modificaLicencia(li);
        int num = (int) MessageBox.Show("Licencia Modificada", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.frmOA.buscaClienteCodigo(this.idCliente);
      this.Close();
    }

    private void txtMac1_TextChanged(object sender, EventArgs e)
    {
      if (this.txtMac1.Text.Trim().Length != 2)
        return;
      this.txtMac2.Focus();
    }

    private void txtMac2_TextChanged(object sender, EventArgs e)
    {
      if (this.txtMac2.Text.Trim().Length != 2)
        return;
      this.txtMac3.Focus();
    }

    private void txtMac3_TextChanged(object sender, EventArgs e)
    {
      if (this.txtMac3.Text.Trim().Length != 2)
        return;
      this.txtMac4.Focus();
    }

    private void txtMac4_TextChanged(object sender, EventArgs e)
    {
      if (this.txtMac4.Text.Trim().Length != 2)
        return;
      this.txtMac5.Focus();
    }

    private void txtMac5_TextChanged(object sender, EventArgs e)
    {
      if (this.txtMac5.Text.Trim().Length != 2)
        return;
      this.txtMac6.Focus();
    }

    private void txtMac6_TextChanged(object sender, EventArgs e)
    {
      if (this.txtMac6.Text.Trim().Length != 2)
        return;
      this.txtClave.Focus();
    }

    private void btnLimpia_Click(object sender, EventArgs e)
    {
      this.limpiaDatos();
    }

    private void dgvLicencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.listaLicencia.Count <= 0)
        return;
      this.btnModificar.Enabled = true;
      this.btnAgregar.Enabled = false;
      this.idLicencia = Convert.ToInt32(this.dgvLicencias.SelectedRows[0].Cells["IdLicencia"].Value.ToString());
      this.dtpFecha.Value = Convert.ToDateTime(this.dgvLicencias.SelectedRows[0].Cells["Fecha"].Value.ToString());
      string str = this.dgvLicencias.SelectedRows[0].Cells["Mac"].Value.ToString();
      this.txtMac1.Text = str.Substring(0, 2);
      this.txtMac2.Text = str.Substring(3, 2);
      this.txtMac3.Text = str.Substring(6, 2);
      this.txtMac4.Text = str.Substring(9, 2);
      this.txtMac5.Text = str.Substring(12, 2);
      this.txtMac6.Text = str.Substring(15, 2);
      this.txtClave.Text = this.dgvLicencias.SelectedRows[0].Cells["Clave"].Value.ToString();
      this.txtContraclave.Text = this.dgvLicencias.SelectedRows[0].Cells["ContraClave"].Value.ToString();
      this.txtContacto.Text = this.dgvLicencias.SelectedRows[0].Cells["Contacto"].Value.ToString();
      this.txtMac1.Focus();
    }

    private void dgvLicencias_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvLicencias.Columns[e.ColumnIndex].Name == "Eliminar") || MessageBox.Show("¿ Esta Seguro de Eliminar esta Licencia ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      int id = Convert.ToInt32(this.dgvLicencias.SelectedRows[0].Cells[1].Value.ToString());
      Licencia licencia = new Licencia();
      try
      {
        licencia.eliminaLicencia(id);
        int num = (int) MessageBox.Show("Licencia Eliminada", "Elimina", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
      this.txtRut = new TextBox();
      this.txtDigito = new TextBox();
      this.txtRazonSocial = new TextBox();
      this.txtMac1 = new TextBox();
      this.txtMac2 = new TextBox();
      this.txtMac3 = new TextBox();
      this.txtMac4 = new TextBox();
      this.txtMac5 = new TextBox();
      this.txtMac6 = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.groupBox1 = new GroupBox();
      this.dgvLicencias = new DataGridView();
      this.btnLimpia = new Button();
      this.btnAgregar = new Button();
      this.btnModificar = new Button();
      this.btnSalir = new Button();
      this.label3 = new Label();
      this.label4 = new Label();
      this.txtContacto = new TextBox();
      this.label5 = new Label();
      this.label6 = new Label();
      this.txtClave = new TextBox();
      this.txtContraclave = new TextBox();
      this.groupBox2 = new GroupBox();
      this.dtpFecha = new DateTimePicker();
      this.label7 = new Label();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dgvLicencias).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.txtRut.Location = new Point(21, 42);
      this.txtRut.Name = "txtRut";
      this.txtRut.Size = new Size(100, 20);
      this.txtRut.TabIndex = 16;
      this.txtDigito.Location = new Point(124, 42);
      this.txtDigito.Name = "txtDigito";
      this.txtDigito.Size = new Size(35, 20);
      this.txtDigito.TabIndex = 1;
      this.txtRazonSocial.Location = new Point(170, 42);
      this.txtRazonSocial.Name = "txtRazonSocial";
      this.txtRazonSocial.Size = new Size(395, 20);
      this.txtRazonSocial.TabIndex = 2;
      this.txtMac1.Location = new Point(6, 30);
      this.txtMac1.MaxLength = 2;
      this.txtMac1.Name = "txtMac1";
      this.txtMac1.Size = new Size(37, 20);
      this.txtMac1.TabIndex = 3;
      this.txtMac1.TextChanged += new EventHandler(this.txtMac1_TextChanged);
      this.txtMac2.Location = new Point(45, 30);
      this.txtMac2.MaxLength = 2;
      this.txtMac2.Name = "txtMac2";
      this.txtMac2.Size = new Size(37, 20);
      this.txtMac2.TabIndex = 4;
      this.txtMac2.TextChanged += new EventHandler(this.txtMac2_TextChanged);
      this.txtMac3.Location = new Point(84, 30);
      this.txtMac3.MaxLength = 2;
      this.txtMac3.Name = "txtMac3";
      this.txtMac3.Size = new Size(37, 20);
      this.txtMac3.TabIndex = 5;
      this.txtMac3.TextChanged += new EventHandler(this.txtMac3_TextChanged);
      this.txtMac4.Location = new Point(123, 30);
      this.txtMac4.MaxLength = 2;
      this.txtMac4.Name = "txtMac4";
      this.txtMac4.Size = new Size(37, 20);
      this.txtMac4.TabIndex = 6;
      this.txtMac4.TextChanged += new EventHandler(this.txtMac4_TextChanged);
      this.txtMac5.Location = new Point(162, 30);
      this.txtMac5.MaxLength = 2;
      this.txtMac5.Name = "txtMac5";
      this.txtMac5.Size = new Size(37, 20);
      this.txtMac5.TabIndex = 7;
      this.txtMac5.TextChanged += new EventHandler(this.txtMac5_TextChanged);
      this.txtMac6.Location = new Point(201, 30);
      this.txtMac6.MaxLength = 2;
      this.txtMac6.Name = "txtMac6";
      this.txtMac6.Size = new Size(37, 20);
      this.txtMac6.TabIndex = 8;
      this.txtMac6.TextChanged += new EventHandler(this.txtMac6_TextChanged);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(21, 26);
      this.label1.Name = "label1";
      this.label1.Size = new Size(24, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Rut";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(6, 14);
      this.label2.Name = "label2";
      this.label2.Size = new Size(30, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "MAC";
      this.groupBox1.Controls.Add((Control) this.dgvLicencias);
      this.groupBox1.Location = new Point(12, 157);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(764, 171);
      this.groupBox1.TabIndex = 31;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Licencias";
      this.dgvLicencias.AllowUserToAddRows = false;
      this.dgvLicencias.AllowUserToDeleteRows = false;
      this.dgvLicencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLicencias.Location = new Point(11, 18);
      this.dgvLicencias.Name = "dgvLicencias";
      this.dgvLicencias.ReadOnly = true;
      this.dgvLicencias.RowHeadersVisible = false;
      this.dgvLicencias.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvLicencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvLicencias.Size = new Size(745, 147);
      this.dgvLicencias.TabIndex = 0;
      this.dgvLicencias.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvLicencias_CellDoubleClick);
      this.dgvLicencias.CellClick += new DataGridViewCellEventHandler(this.dgvLicencias_CellClick);
      this.btnLimpia.Location = new Point(726, 27);
      this.btnLimpia.Name = "btnLimpia";
      this.btnLimpia.Size = new Size(29, 23);
      this.btnLimpia.TabIndex = 32;
      this.btnLimpia.Text = "::";
      this.btnLimpia.UseVisualStyleBackColor = true;
      this.btnLimpia.Click += new EventHandler(this.btnLimpia_Click);
      this.btnAgregar.Location = new Point(621, 135);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(75, 23);
      this.btnAgregar.TabIndex = 33;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.btnModificar.Location = new Point(701, 135);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 23);
      this.btnModificar.TabIndex = 34;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.btnSalir.Location = new Point(699, 334);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 23);
      this.btnSalir.TabIndex = 35;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.label3.AutoSize = true;
      this.label3.Location = new Point(167, 26);
      this.label3.Name = "label3";
      this.label3.Size = new Size(70, 13);
      this.label3.TabIndex = 36;
      this.label3.Text = "Razon Social";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(528, 14);
      this.label4.Name = "label4";
      this.label4.Size = new Size(50, 13);
      this.label4.TabIndex = 37;
      this.label4.Text = "Contacto";
      this.txtContacto.Location = new Point(528, 30);
      this.txtContacto.Name = "txtContacto";
      this.txtContacto.Size = new Size(189, 20);
      this.txtContacto.TabIndex = 43;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(249, 14);
      this.label5.Name = "label5";
      this.label5.Size = new Size(34, 13);
      this.label5.TabIndex = 39;
      this.label5.Text = "Clave";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(389, 14);
      this.label6.Name = "label6";
      this.label6.Size = new Size(65, 13);
      this.label6.TabIndex = 40;
      this.label6.Text = "ContraClave";
      this.txtClave.Location = new Point(249, 30);
      this.txtClave.Name = "txtClave";
      this.txtClave.Size = new Size(133, 20);
      this.txtClave.TabIndex = 41;
      this.txtContraclave.Location = new Point(389, 30);
      this.txtContraclave.Name = "txtContraclave";
      this.txtContraclave.Size = new Size(133, 20);
      this.txtContraclave.TabIndex = 42;
      this.groupBox2.Controls.Add((Control) this.txtMac1);
      this.groupBox2.Controls.Add((Control) this.txtContraclave);
      this.groupBox2.Controls.Add((Control) this.txtMac2);
      this.groupBox2.Controls.Add((Control) this.txtClave);
      this.groupBox2.Controls.Add((Control) this.txtMac3);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.txtMac4);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Controls.Add((Control) this.txtMac5);
      this.groupBox2.Controls.Add((Control) this.txtContacto);
      this.groupBox2.Controls.Add((Control) this.txtMac6);
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.btnLimpia);
      this.groupBox2.Location = new Point(12, 65);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(764, 64);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.dtpFecha.Format = DateTimePickerFormat.Short;
      this.dtpFecha.Location = new Point(672, 42);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new Size(101, 20);
      this.dtpFecha.TabIndex = 44;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(669, 26);
      this.label7.Name = "label7";
      this.label7.Size = new Size(91, 13);
      this.label7.TabIndex = 45;
      this.label7.Text = "Fecha Instalación";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(785, 368);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.dtpFecha);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnModificar);
      this.Controls.Add((Control) this.btnAgregar);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.txtRazonSocial);
      this.Controls.Add((Control) this.txtDigito);
      this.Controls.Add((Control) this.txtRut);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "frmLicencia";
      this.ShowIcon = false;
      this.Text = "Ingreso de Licencias";
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.dgvLicencias).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
