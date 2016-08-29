 
// Type: Aptusoft.frmControlCaja
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmControlCaja : Form
  {
    private IContainer components = (IContainer) null;
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private int _caja = 0;
    private int idControlCaja = 0;
    private GroupBox groupBox1;
    private ComboBox cmbMovimiento;
    private DateTimePicker dtpFecha;
    private TextBox txtMonto;
    private Label label5;
    private Label label4;
    private Label label2;
    private Label label3;
    private RadioButton rdbSalida;
    private RadioButton rdbEntrada;
    private Panel panel1;
    private TextBox txtObservaciones;
    private Label label6;
    private DataGridView dgvDatos;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private Button btnModificar;

    public frmControlCaja()
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
      this.groupBox1 = new GroupBox();
      this.txtMonto = new TextBox();
      this.rdbSalida = new RadioButton();
      this.rdbEntrada = new RadioButton();
      this.label3 = new Label();
      this.label5 = new Label();
      this.cmbMovimiento = new ComboBox();
      this.dtpFecha = new DateTimePicker();
      this.label4 = new Label();
      this.label2 = new Label();
      this.panel1 = new Panel();
      this.txtObservaciones = new TextBox();
      this.label6 = new Label();
      this.dgvDatos = new DataGridView();
      this.btnGuardar = new Button();
      this.btnEliminar = new Button();
      this.btnLimpiar = new Button();
      this.btnSalir = new Button();
      this.btnModificar = new Button();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.txtMonto);
      this.groupBox1.Controls.Add((Control) this.rdbSalida);
      this.groupBox1.Controls.Add((Control) this.rdbEntrada);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.cmbMovimiento);
      this.groupBox1.Controls.Add((Control) this.dtpFecha);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(520, 68);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.txtMonto.Location = new Point(406, 32);
      this.txtMonto.Name = "txtMonto";
      this.txtMonto.Size = new Size(100, 20);
      this.txtMonto.TabIndex = 6;
      this.rdbSalida.AutoSize = true;
      this.rdbSalida.Location = new Point(189, 35);
      this.rdbSalida.Name = "rdbSalida";
      this.rdbSalida.Size = new Size(54, 17);
      this.rdbSalida.TabIndex = 11;
      this.rdbSalida.TabStop = true;
      this.rdbSalida.Text = "Salida";
      this.rdbSalida.UseVisualStyleBackColor = true;
      this.rdbSalida.CheckedChanged += new EventHandler(this.rdbSalida_CheckedChanged);
      this.rdbEntrada.AutoSize = true;
      this.rdbEntrada.Location = new Point(125, 35);
      this.rdbEntrada.Name = "rdbEntrada";
      this.rdbEntrada.Size = new Size(62, 17);
      this.rdbEntrada.TabIndex = 10;
      this.rdbEntrada.TabStop = true;
      this.rdbEntrada.Text = "Entrada";
      this.rdbEntrada.UseVisualStyleBackColor = true;
      this.rdbEntrada.CheckedChanged += new EventHandler(this.rdbEntrada_CheckedChanged);
      this.label3.BackColor = Color.FromArgb(64, 64, 64);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(124, 16);
      this.label3.Name = "label3";
      this.label3.Size = new Size(119, 16);
      this.label3.TabIndex = 12;
      this.label3.Text = "Tipo de Acción";
      this.label5.BackColor = Color.FromArgb(64, 64, 64);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(406, 16);
      this.label5.Name = "label5";
      this.label5.Size = new Size(100, 23);
      this.label5.TabIndex = 4;
      this.label5.Text = "Monto";
      this.label5.TextAlign = ContentAlignment.TopRight;
      this.cmbMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbMovimiento.FormattingEnabled = true;
      this.cmbMovimiento.Location = new Point(249, 32);
      this.cmbMovimiento.Name = "cmbMovimiento";
      this.cmbMovimiento.Size = new Size(151, 21);
      this.cmbMovimiento.TabIndex = 9;
      this.dtpFecha.Format = DateTimePickerFormat.Short;
      this.dtpFecha.Location = new Point(14, 32);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new Size(102, 20);
      this.dtpFecha.TabIndex = 7;
      this.dtpFecha.ValueChanged += new EventHandler(this.dtpFecha_ValueChanged);
      this.label4.BackColor = Color.FromArgb(64, 64, 64);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(249, 16);
      this.label4.Name = "label4";
      this.label4.Size = new Size(151, 23);
      this.label4.TabIndex = 3;
      this.label4.Text = "Tipo Movimiento";
      this.label2.BackColor = Color.FromArgb(64, 64, 64);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(14, 16);
      this.label2.Name = "label2";
      this.label2.Size = new Size(102, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "Fecha";
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.txtObservaciones);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Location = new Point(12, 83);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(520, 124);
      this.panel1.TabIndex = 1;
      this.txtObservaciones.Location = new Point(14, 26);
      this.txtObservaciones.Multiline = true;
      this.txtObservaciones.Name = "txtObservaciones";
      this.txtObservaciones.Size = new Size(490, 90);
      this.txtObservaciones.TabIndex = 0;
      this.label6.BackColor = Color.FromArgb(64, 64, 64);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(14, 7);
      this.label6.Name = "label6";
      this.label6.Size = new Size(490, 23);
      this.label6.TabIndex = 13;
      this.label6.Text = "Observaciones";
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Location = new Point(12, 213);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.ReadOnly = true;
      this.dgvDatos.RowHeadersVisible = false;
      this.dgvDatos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatos.ScrollBars = ScrollBars.Vertical;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(520, 130);
      this.dgvDatos.TabIndex = 2;
      this.dgvDatos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
      this.btnGuardar.Location = new Point(12, 359);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 44);
      this.btnGuardar.TabIndex = 3;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnEliminar.Location = new Point(174, 359);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(75, 44);
      this.btnEliminar.TabIndex = 4;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnLimpiar.Location = new Point((int) byte.MaxValue, 359);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 44);
      this.btnLimpiar.TabIndex = 5;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnSalir.Location = new Point(457, 359);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 44);
      this.btnSalir.TabIndex = 6;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnModificar.Location = new Point(93, 359);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 44);
      this.btnModificar.TabIndex = 7;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(546, 415);
      this.Controls.Add((Control) this.btnModificar);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.btnEliminar);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.dgvDatos);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.groupBox1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmControlCaja";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Control de Caja";
      this.FormClosing += new FormClosingEventHandler(this.frmControlCaja_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.ResumeLayout(false);
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("CONTROL CAJA"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
          this._caja = usuarioVo.IdCaja;
        }
      }
    }

    private void iniciaFormulario()
    {
      this.rdbEntrada.Checked = true;
      this.rdbSalida.Checked = false;
      this.txtMonto.Clear();
      this.txtObservaciones.Clear();
      this.dtpFecha.Value = DateTime.Now;
      this.cargaTipoMovimiento(1);
      this.cargaControlesDeCaja();
      this.idControlCaja = 0;
      if (this._guarda)
        this.btnGuardar.Enabled = true;
      else
        this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
    }

    private void cargaTipoMovimiento(int accion)
    {
      BodegaVO bodegaVo = new BodegaVO();
      List<BodegaVO> list = new List<BodegaVO>();
      if (accion == 1)
      {
        list.Add(new BodegaVO()
        {
          IdBodega = 0,
          nombreBodega = "SELECCIONAR"
        });
        list.Add(new BodegaVO()
        {
          IdBodega = 1,
          nombreBodega = "CAJA INICIAL"
        });
        list.Add(new BodegaVO()
        {
          IdBodega = 2,
          nombreBodega = "ABONO"
        });
      }
      if (accion == 2)
      {
        list.Add(new BodegaVO()
        {
          IdBodega = 0,
          nombreBodega = "SELECCIONAR"
        });
        list.Add(new BodegaVO()
        {
          IdBodega = 3,
          nombreBodega = "CAJA DIA SIGUIENTE"
        });
        list.Add(new BodegaVO()
        {
          IdBodega = 4,
          nombreBodega = "GASTO"
        });
        list.Add(new BodegaVO()
        {
          IdBodega = 5,
          nombreBodega = "RETIRO"
        });
      }
      this.cmbMovimiento.DataSource = (object) null;
      this.cmbMovimiento.DataSource = (object) list;
      this.cmbMovimiento.ValueMember = "idBodega";
      this.cmbMovimiento.DisplayMember = "nombreBodega";
      this.cmbMovimiento.SelectedValue = (object) 0;
    }

    private void cargaControlesDeCaja()
    {
      this.dgvDatos.DataSource = (object) null;
      this.creaColumnasDetalle();
      List<ControlCajaVO> list = new ControlCaja().buscaControlCaja(this._caja, this.dtpFecha.Value);
      for (int index = 0; index < list.Count; ++index)
        list[index].Linea = index + 1;
      this.dgvDatos.DataSource = (object) list;
    }

    private void creaColumnasDetalle()
    {
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvDatos.Columns.Add("Linea", "");
      this.dgvDatos.Columns[0].DataPropertyName = "Linea";
      this.dgvDatos.Columns[0].Width = 20;
      this.dgvDatos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
      this.dgvDatos.Columns.Add("IdControlCaja", "IdControlCaja");
      this.dgvDatos.Columns[1].DataPropertyName = "IdControlCaja";
      this.dgvDatos.Columns[1].Width = 100;
      this.dgvDatos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[1].Visible = false;
      this.dgvDatos.Columns.Add("FechaIngreso", "FechaIngreso");
      this.dgvDatos.Columns[2].DataPropertyName = "FechaIngreso";
      this.dgvDatos.Columns[2].Width = 110;
      this.dgvDatos.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns.Add("TipoAccion", "TipoAccion");
      this.dgvDatos.Columns[3].DataPropertyName = "TipoAccion";
      this.dgvDatos.Columns[3].Width = 80;
      this.dgvDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatos.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns.Add("IdTipoAcion", "IdTipoAcion");
      this.dgvDatos.Columns[4].DataPropertyName = "IdTipoAcion";
      this.dgvDatos.Columns[4].Width = 80;
      this.dgvDatos.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[4].Visible = false;
      this.dgvDatos.Columns.Add("TipoMovimiento", "TipoMovimiento");
      this.dgvDatos.Columns[5].DataPropertyName = "TipoMovimiento";
      this.dgvDatos.Columns[5].Width = 130;
      this.dgvDatos.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns.Add("IdTipoMovimiento", "IdTipoMovimiento");
      this.dgvDatos.Columns[6].DataPropertyName = "IdTipoMovimiento";
      this.dgvDatos.Columns[6].Width = 70;
      this.dgvDatos.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[6].Visible = false;
      this.dgvDatos.Columns.Add("Monto", "Monto");
      this.dgvDatos.Columns[7].DataPropertyName = "Monto";
      this.dgvDatos.Columns[7].Width = 80;
      this.dgvDatos.Columns[7].DefaultCellStyle.Format = "C0";
      this.dgvDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatos.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns.Add("Observaciones", "Observaciones");
      this.dgvDatos.Columns[8].DataPropertyName = "Observaciones";
      this.dgvDatos.Columns[8].Width = 110;
      this.dgvDatos.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns.Add("Caja", "Caja");
      this.dgvDatos.Columns[9].DataPropertyName = "Caja";
      this.dgvDatos.Columns[9].Width = 90;
      this.dgvDatos.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvDatos.Columns[9].Visible = false;
    }

    private void guardaControlCaja()
    {
      DateTime dateTime=DateTime.Now;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      DateTime local = @dateTime;
      DateTime now = this.dtpFecha.Value;
      int year = now.Year;
      now = this.dtpFecha.Value;
      int month = now.Month;
      now = this.dtpFecha.Value;
      int day = now.Day;
      now = DateTime.Now;
      TimeSpan timeOfDay = now.TimeOfDay;
      int hours = timeOfDay.Hours;
      now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int minutes = timeOfDay.Minutes;
      now = DateTime.Now;
      timeOfDay = now.TimeOfDay;
      int seconds = timeOfDay.Seconds;
      // ISSUE: explicit reference operation
      local = new DateTime(year, month, day, hours, minutes, seconds);
      ControlCajaVO ccVO = new ControlCajaVO();
      ccVO.FechaIngreso = dateTime;
      ccVO.IdTipoAcion = this.rdbEntrada.Checked ? 1 : 2;
      ccVO.TipoAccion = this.rdbEntrada.Checked ? "ENTRADA" : "SALIDA";
      ccVO.IdTipoMovimiento = Convert.ToInt32(this.cmbMovimiento.SelectedValue.ToString());
      ccVO.TipoMovimiento = this.cmbMovimiento.Text;
      ccVO.Monto = Convert.ToDecimal(this.txtMonto.Text.Trim());
      ccVO.Observaciones = this.txtObservaciones.Text.Trim().ToUpper();
      ccVO.Caja = this._caja;
      ControlCaja controlCaja = new ControlCaja();
      try
      {
        controlCaja.agregaControlCaja(ccVO);
        int num = (int) MessageBox.Show("Caja Guardada", "Guarda Caja", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al guardar " + ex.Message);
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      this.guardaControlCaja();
    }

    private bool valida()
    {
      if (this.txtMonto.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Un Monto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtMonto.Focus();
        return false;
      }
      if (!(this.cmbMovimiento.SelectedValue.ToString() == "0"))
        return true;
      int num1 = (int) MessageBox.Show("Debe Seleccionar Un tipo de Movimiento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.cmbMovimiento.Focus();
      return false;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modControlCaja = 0;
      this.Dispose();
      this.Close();
    }

    private void frmControlCaja_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modControlCaja = 0;
      this.Dispose();
    }

    private void rdbSalida_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rdbSalida.Checked)
        this.cargaTipoMovimiento(2);
      else
        this.cargaTipoMovimiento(1);
    }

    private void rdbEntrada_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rdbEntrada.Checked)
        this.cargaTipoMovimiento(1);
      else
        this.cargaTipoMovimiento(2);
    }

    private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this._modifica)
        this.btnModificar.Enabled = true;
      if (this._elimina)
        this.btnEliminar.Enabled = true;
      this.btnGuardar.Enabled = false;
      this.idControlCaja = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells["IdControlCaja"].Value.ToString());
      this.dtpFecha.Value = Convert.ToDateTime(this.dgvDatos.SelectedRows[0].Cells["FechaIngreso"].Value.ToString());
      if (this.dgvDatos.SelectedRows[0].Cells["IdTipoAcion"].Value.ToString().Equals("1"))
        this.rdbEntrada.Checked = true;
      else
        this.rdbSalida.Checked = true;
      this.cmbMovimiento.SelectedValue = (object) Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells["IdTipoMovimiento"].Value.ToString());
      this.txtMonto.Text = Convert.ToDecimal(this.dgvDatos.SelectedRows[0].Cells["Monto"].Value.ToString()).ToString("##");
      this.txtObservaciones.Text = this.dgvDatos.SelectedRows[0].Cells["Observaciones"].Value.ToString();
    }

    private void dtpFecha_ValueChanged(object sender, EventArgs e)
    {
      if (this.idControlCaja != 0)
        return;
      this.cargaControlesDeCaja();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Modificar la Caja ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        if (!this.valida())
          return;
        DateTime dateTime=DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local = @dateTime;
        DateTime now = this.dtpFecha.Value;
        int year = now.Year;
        now = this.dtpFecha.Value;
        int month = now.Month;
        now = this.dtpFecha.Value;
        int day = now.Day;
        now = DateTime.Now;
        int hours = now.TimeOfDay.Hours;
        now = DateTime.Now;
        int minutes = now.TimeOfDay.Minutes;
        now = DateTime.Now;
        int seconds = now.TimeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local = new DateTime(year, month, day, hours, minutes, seconds);
        ControlCajaVO ccVO = new ControlCajaVO();
        ccVO.IdControlCaja = this.idControlCaja;
        ccVO.FechaIngreso = dateTime;
        ccVO.IdTipoAcion = this.rdbEntrada.Checked ? 1 : 2;
        ccVO.TipoAccion = this.rdbEntrada.Checked ? "ENTRADA" : "SALIDA";
        ccVO.IdTipoMovimiento = Convert.ToInt32(this.cmbMovimiento.SelectedValue.ToString());
        ccVO.TipoMovimiento = this.cmbMovimiento.Text;
        ccVO.Monto = Convert.ToDecimal(this.txtMonto.Text.Trim());
        ccVO.Observaciones = this.txtObservaciones.Text.Trim().ToUpper();
        ccVO.Caja = this._caja;
        ControlCaja controlCaja = new ControlCaja();
        try
        {
          controlCaja.modificaControlCaja(ccVO);
          int num = (int) MessageBox.Show("Caja Modificada", "Modifica Caja", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Modificar " + ex.Message);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Caja NO fue Modificada.");
        this.iniciaFormulario();
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Eliminar la Caja ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        ControlCaja controlCaja = new ControlCaja();
        try
        {
          controlCaja.eliminaControlCaja(this.idControlCaja);
          int num = (int) MessageBox.Show("Caja Eliminada", "Elimina Caja", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Eliminar " + ex.Message);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("La Caja NO fue Eliminada.");
        this.iniciaFormulario();
      }
    }
  }
}
