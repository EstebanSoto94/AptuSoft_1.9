 
// Type: Aptusoft.frmMedioPago
 
 
// version 1.8.0

using AxOCXSAM350Lib;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmMedioPago : Form
  {
    private DataSet dsDatosXml = new DataSet("datos");
    private MedioPagoFiscal medio = new MedioPagoFiscal();
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private short _puertoImpresoraFiscal = (short) 0;
    private IContainer components = (IContainer) null;
    private int _idMedio;
    private int _idDisponible;
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
    private Label label2;
    private TextBox txtCodigoFiscal;
    private DataGridViewTextBoxColumn CodigoUnidad;
    private DataGridViewTextBoxColumn DescUnidad;
    private DataGridViewCheckBoxColumn Liquida;
    private DataGridViewTextBoxColumn CodigoFiscal;
    private AxOcxsam350 ocxFiscal;
    private Label label3;

    public frmMedioPago()
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this.cargaPermisos();
      this.iniciaFormulario();
      this.cargaOpcionesDocumentos();
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

    public void cargaOpcionesDocumentos()
    {
      OpcionesGenerales opcionesGenerales = new OpcionesGenerales();
      OpcionesDocumentosVO opcionesDocumentosVo = new OpcionesDocumentosVO();
      opcionesDocumentosVo = opcionesGenerales.rescataOpcionesDocumentosPorNombre("BOLETA");
      this._puertoImpresoraFiscal = new OpcionesGenerales().puertoFiscal();
    }

    private void obtenerCodigoFiscal()
    {
      List<int> list = this.medio.obtenerCodigoFiscal();
      this.txtCodigoFiscal.Text = list[0].ToString();
      this._idDisponible = list[1];
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
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) this.medio.listaMediosPagoGrilla();
      this.numFila();
      this.txtNombre.Clear();
      this.txtNombre.Focus();
      this.txtCodigoFiscal.Clear();
      this.chkLiquida.Checked = false;
      this.btnGuardar.Enabled = false;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.obtenerCodigoFiscal();
    }

    private void guardaMedioPago()
    {
      if (!this.comprobarCodigoEnImpresora())
        return;
      this.txtNombre.Text = this.txtNombre.Text.Trim().ToUpper();
      if (this.txtCodigoFiscal.Text.Trim().Length == 0)
      {
        int num1 = (int) MessageBox.Show("Debe Ingresar un Codigo Fiscal", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        try
        {
          if (MessageBox.Show("Nuevo Medio de Pago, ¿Desea Guardarlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            this.dsDatosXml = new DataSet("datos");
            int num2 = (int) this.dsDatosXml.ReadXml("C:\\AptuSoft\\xml\\fiscal.xml");
            DataRow row = this.dsDatosXml.Tables["pagos"].NewRow();
            row["idMedioPago"] = (object) this._idDisponible.ToString();
            row["nombreMedioPago"] = (object) this.txtNombre.Text.Trim();
            row["liquida"] = this.chkLiquida.Checked ? (object) "true" : (object) "false";
            row["codigoFiscal"] = (object) this.txtCodigoFiscal.Text.Trim();
            this.dsDatosXml.Tables["pagos"].Rows.Add(row);
            this.dsDatosXml.WriteXml("C:\\AptuSoft\\xml\\fiscal.xml");
            this.guardaMedioPagoImpresoraFiscal();
            this.iniciaFormulario();
            int num3 = (int) MessageBox.Show("Medio de Pago Agregado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        catch (MySqlException ex)
        {
          int num2 = (int) MessageBox.Show("Error :" + ((Exception) ex).Message);
        }
      }
    }

    private void guardaMedioPagoImpresoraFiscal()
    {
      short num1 = Convert.ToInt16(this.txtCodigoFiscal.Text);
      string text = this.txtNombre.Text;
      if (this.ocxFiscal.init(this._puertoImpresoraFiscal) != 1)
        return;
      int num2 = this.ocxFiscal.conftipopago(num1, text);
      num2 = this.ocxFiscal.fini();
    }

    private bool comprobarCodigoEnImpresora()
    {
      int num1 = this.ocxFiscal.init(this._puertoImpresoraFiscal);
      if (num1 == 1)
      {
        int num2 = this.ocxFiscal.obtenertextopago(Convert.ToInt16(this.txtCodigoFiscal.Text));
        int num3;
        if (num2 == 0)
        {
          num3 = this.ocxFiscal.fini();
          return false;
        }
        int num4 = (int) MessageBox.Show(num2.ToString());
        num3 = this.ocxFiscal.fini();
        return true;
      }
      int num5 = (int) MessageBox.Show("No Hay Conexion con Impresora " + num1.ToString(), "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      return false;
    }

    private void validaPagoFiscal()
    {
      if (this.txtCodigoFiscal.Text.Trim().Length <= 0 || this.ocxFiscal.obtenertextopago(Convert.ToInt16(this.txtCodigoFiscal.Text.Trim())) != 0)
        return;
      int num = (int) MessageBox.Show("Ya Existe este Medio de Pago", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (this.medio.buscaMedioNombre(this.txtNombre.Text.Trim()) && this.btnGuardar.Enabled)
      {
        int num = (int) MessageBox.Show("Esta Medio de Pago Ya Existe!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtNombre.Focus();
      }
      else if (this.medio.buscaCodigoFiscal(this.txtCodigoFiscal.Text.Trim()) && this.btnGuardar.Enabled)
      {
        int num = (int) MessageBox.Show("El Codigo Fiscal Ya se Encuentra Asignado!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCodigoFiscal.Focus();
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
        CodigoFiscal = Convert.ToInt32(this.txtCodigoFiscal.Text.Trim())
      });
      int num = (int) MessageBox.Show("Medio de Pago Actualizado");
      this.iniciaFormulario();
    }

    public void buscaMedioDGV()
    {
      int rowIndex = this.dgvDatos.CurrentCell.RowIndex;
      this._idMedio = Convert.ToInt32(this.dgvDatos.Rows[rowIndex].Cells[0].Value.ToString());
      this.txtNombre.Text = this.dgvDatos.Rows[rowIndex].Cells[1].Value.ToString();
      this.chkLiquida.Checked = Convert.ToBoolean(this.dgvDatos.Rows[rowIndex].Cells[2].Value);
      this.txtCodigoFiscal.Text = this.dgvDatos.Rows[rowIndex].Cells[3].Value.ToString();
      this.txtNombre.Focus();
      this.btnGuardar.Enabled = false;
      if (this._modifica && !this.txtCodigoFiscal.Visible)
        this.btnModificar.Enabled = true;
      if (!this._elimina || this.txtCodigoFiscal.Visible)
        return;
      this.btnEliminar.Enabled = true;
    }

    private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void dgvDatos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
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
        else
          e.Handled = true;
      }
    }

    private void txtCodigoFiscal_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCodigoFiscal);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMedioPago));
      this.label1 = new Label();
      this.txtNombre = new TextBox();
      this.dgvDatos = new DataGridView();
      this.CodigoUnidad = new DataGridViewTextBoxColumn();
      this.DescUnidad = new DataGridViewTextBoxColumn();
      this.Liquida = new DataGridViewCheckBoxColumn();
      this.CodigoFiscal = new DataGridViewTextBoxColumn();
      this.groupBox1 = new GroupBox();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.btnModificar = new Button();
      this.btnGuardar = new Button();
      this.chkLiquida = new CheckBox();
      this.label2 = new Label();
      this.txtCodigoFiscal = new TextBox();
      this.ocxFiscal = new AxOcxsam350();
      this.label3 = new Label();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.ocxFiscal).BeginInit();
      this.SuspendLayout();
      this.label1.BackColor = Color.FromArgb(64, 64, 64);
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(12, 21);
      this.label1.Name = "label1";
      this.label1.Size = new Size(424, 27);
      this.label1.TabIndex = 0;
      this.label1.Text = "Medio de Pago Fiscal";
      this.txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNombre.Location = new Point(12, 44);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new Size(424, 22);
      this.txtNombre.TabIndex = 1;
      this.txtNombre.TextChanged += new EventHandler(this.txtNombre_TextChanged_1);
      this.txtNombre.Leave += new EventHandler(this.txtNombre_Leave_1);
      this.txtNombre.KeyPress += new KeyPressEventHandler(this.txtNombre_KeyPress);
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.CodigoUnidad, (DataGridViewColumn) this.DescUnidad, (DataGridViewColumn) this.Liquida, (DataGridViewColumn) this.CodigoFiscal);
      this.dgvDatos.Location = new Point(12, 96);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.ReadOnly = true;
      this.dgvDatos.RowHeadersWidth = 50;
      this.dgvDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvDatos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(424, 315);
      this.dgvDatos.TabIndex = 2;
      this.dgvDatos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
      this.dgvDatos.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dgvDatos_ColumnHeaderMouseClick);
      this.CodigoUnidad.DataPropertyName = "IdMedioPago";
      this.CodigoUnidad.HeaderText = "Codigo";
      this.CodigoUnidad.Name = "CodigoUnidad";
      this.CodigoUnidad.ReadOnly = true;
      this.CodigoUnidad.Visible = false;
      this.DescUnidad.DataPropertyName = "NombreMedioPago";
      this.DescUnidad.HeaderText = "Descripcion";
      this.DescUnidad.Name = "DescUnidad";
      this.DescUnidad.ReadOnly = true;
      this.DescUnidad.Width = 250;
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
      this.CodigoFiscal.Width = 60;
      this.groupBox1.Controls.Add((Control) this.btnSalir);
      this.groupBox1.Controls.Add((Control) this.btnLimpiar);
      this.groupBox1.Controls.Add((Control) this.btnEliminar);
      this.groupBox1.Controls.Add((Control) this.btnModificar);
      this.groupBox1.Controls.Add((Control) this.btnGuardar);
      this.groupBox1.Location = new Point(443, 14);
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
      this.btnEliminar.Visible = false;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnModificar.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnModificar.Location = new Point(6, 82);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new Size(75, 59);
      this.btnModificar.TabIndex = 1;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Visible = false;
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
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(277, 72);
      this.label2.Name = "label2";
      this.label2.Size = new Size(83, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Codigo Fiscal";
      this.txtCodigoFiscal.Location = new Point(368, 69);
      this.txtCodigoFiscal.MaxLength = 2;
      this.txtCodigoFiscal.Name = "txtCodigoFiscal";
      this.txtCodigoFiscal.Size = new Size(68, 20);
      this.txtCodigoFiscal.TabIndex = 6;
      this.txtCodigoFiscal.KeyPress += new KeyPressEventHandler(this.txtCodigoFiscal_KeyPress);
      ((AxHost) this.ocxFiscal).Enabled = true;
      ((Control) this.ocxFiscal).Location = new Point(12, 417);
      ((Control) this.ocxFiscal).Name = "ocxFiscal";
      ((AxHost) this.ocxFiscal).OcxState = (AxHost.State) componentResourceManager.GetObject("ocxFiscal.OcxState");
      ((Control) this.ocxFiscal).Size = new Size(100, 34);
      ((Control) this.ocxFiscal).TabIndex = 7;
      ((Control) this.ocxFiscal).Visible = false;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(137, 436);
      this.label3.Name = "label3";
      this.label3.Size = new Size(383, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Los Medios de Pago fiscales, NO son modificables y solo se permiten 10 medios";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(544, 458);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.ocxFiscal);
      this.Controls.Add((Control) this.txtCodigoFiscal);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.chkLiquida);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.dgvDatos);
      this.Controls.Add((Control) this.txtNombre);
      this.Controls.Add((Control) this.label1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmMedioPago";
      this.ShowIcon = false;
      this.Text = "Modulo Medios de Pago Fiscal";
      this.Load += new EventHandler(this.frmMedioPago_Load);
      this.FormClosing += new FormClosingEventHandler(this.frmMedioPago_FormClosing);
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.ocxFiscal).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
