 
// Type: Aptusoft.frmImpuestos
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmImpuestos : Form
  {
    private Impuestos imp = new Impuestos();
    private int idImp = 0;
    private bool _guarda = false;
    private bool _modifica = false;
    private bool _elimina = false;
    private IContainer components = (IContainer) null;
    private DataGridView dgvDatos;
    private GroupBox groupBox1;
    private Button btnSalir;
    private Button btnLimpiar;
    private Button btnModificar;
    private Label label1;
    private Label label4;
    private TextBox txtImpuesto;
    private TextBox txtPorcentaje;
    private Label label5;
    private TextBox txtCodigoImpuesto;
    private Label label2;
    private DataGridViewTextBoxColumn IdImpuesto;
    private DataGridViewTextBoxColumn CodigoImpuesto;
    private DataGridViewTextBoxColumn NombreInpuesto;
    private DataGridViewTextBoxColumn PorcentajeImpuesto;
    private Label label3;

    public frmImpuestos()
    {
      this.InitializeComponent();
      this.cargaPermisos();
      this.iniciaFormulario();
    }

    private void cargaPermisos()
    {
      foreach (UsuarioVO usuarioVo in frmMenuPrincipal.listaUsuario)
      {
        if (usuarioVo.Modulo.Equals("IMPUESTOS ESPECIALES"))
        {
          this._guarda = Convert.ToBoolean(usuarioVo.Guarda);
          this._modifica = Convert.ToBoolean(usuarioVo.Modifica);
          this._elimina = Convert.ToBoolean(usuarioVo.Elimina);
        }
      }
    }

    public void iniciaFormulario()
    {
      this.idImp = 0;
      List<ImpuestoVO> list = this.imp.listaImpuestos();
      list.RemoveAt(0);
      this.dgvDatos.DataSource = (object) list;
      this.txtCodigoImpuesto.Clear();
      this.txtImpuesto.Clear();
      this.txtPorcentaje.Clear();
      this.txtImpuesto.Focus();
      this.btnModificar.Enabled = false;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modImpuesto = 0;
      this.Close();
      this.Dispose();
    }

    private void frmVendedor_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modImpuesto = 0;
      this.Dispose();
    }

    private string verificaDecimales(string cantidad)
    {
      int num = cantidad.ToString().IndexOf(',');
      string str = cantidad;
      if (num != -1)
      {
        string[] strArray = cantidad.Split(',');
        str = Convert.ToInt32(strArray[1]) <= 0 ? strArray[0] : cantidad;
      }
      return str;
    }

    private bool validaFormulario()
    {
      if (this.txtCodigoImpuesto.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Codigo para el Impuesto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCodigoImpuesto.Focus();
        return false;
      }
      if (this.txtImpuesto.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar Nombre para el Impuesto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtImpuesto.Focus();
        return false;
      }
      if (this.txtPorcentaje.Text.Trim().Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar Porcentaje para el Impuesto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtPorcentaje.Focus();
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

    private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPorcentaje);
    }

    private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.idImp = Convert.ToInt32(this.dgvDatos.SelectedRows[0].Cells[0].Value.ToString());
      this.txtCodigoImpuesto.Text = this.dgvDatos.SelectedRows[0].Cells[1].Value.ToString();
      this.txtImpuesto.Text = this.dgvDatos.SelectedRows[0].Cells[2].Value.ToString();
      this.txtPorcentaje.Text = this.verificaDecimales(this.dgvDatos.SelectedRows[0].Cells[3].Value.ToString());
      if (this._guarda)
        this.btnModificar.Enabled = true;
      else
        this.btnModificar.Enabled = false;
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Modificar el Impuesto", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !this.validaFormulario())
        return;
      ImpuestoVO imVO = new ImpuestoVO();
      imVO.IdImpuesto = this.idImp;
      imVO.CodigoImpuesto = this.txtCodigoImpuesto.Text;
      imVO.NombreImpuesto = this.txtImpuesto.Text.Trim().ToUpper();
      imVO.PorcentajeImpuesto = Convert.ToDecimal(this.txtPorcentaje.Text.Trim());
      try
      {
        this.imp = new Impuestos();
        this.imp.modificaImpuesto(imVO);
        int num = (int) MessageBox.Show("Impuesto Modificado Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Modificar: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.IdImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoImpuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdImpuesto,
            this.CodigoImpuesto,
            this.NombreInpuesto,
            this.PorcentajeImpuesto});
            this.dgvDatos.Location = new System.Drawing.Point(12, 92);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 40;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(459, 282);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // IdImpuesto
            // 
            this.IdImpuesto.DataPropertyName = "IdImpuesto";
            this.IdImpuesto.HeaderText = "Id";
            this.IdImpuesto.Name = "IdImpuesto";
            this.IdImpuesto.ReadOnly = true;
            this.IdImpuesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdImpuesto.Visible = false;
            this.IdImpuesto.Width = 50;
            // 
            // CodigoImpuesto
            // 
            this.CodigoImpuesto.DataPropertyName = "CodigoImpuesto";
            this.CodigoImpuesto.HeaderText = "Codigo";
            this.CodigoImpuesto.Name = "CodigoImpuesto";
            this.CodigoImpuesto.ReadOnly = true;
            this.CodigoImpuesto.Width = 50;
            // 
            // NombreInpuesto
            // 
            this.NombreInpuesto.DataPropertyName = "NombreImpuesto";
            this.NombreInpuesto.HeaderText = "Impuesto";
            this.NombreInpuesto.Name = "NombreInpuesto";
            this.NombreInpuesto.ReadOnly = true;
            this.NombreInpuesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreInpuesto.Width = 300;
            // 
            // PorcentajeImpuesto
            // 
            this.PorcentajeImpuesto.DataPropertyName = "PorcentajeImpuesto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.PorcentajeImpuesto.DefaultCellStyle = dataGridViewCellStyle2;
            this.PorcentajeImpuesto.HeaderText = "Porcentaje";
            this.PorcentajeImpuesto.Name = "PorcentajeImpuesto";
            this.PorcentajeImpuesto.ReadOnly = true;
            this.PorcentajeImpuesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PorcentajeImpuesto.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Location = new System.Drawing.Point(12, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(378, 13);
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
            this.btnLimpiar.Location = new System.Drawing.Point(87, 13);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(6, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 59);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Guardar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IMPUESTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PORCENTAJE %";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(122, 34);
            this.txtImpuesto.MaxLength = 100;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(349, 20);
            this.txtImpuesto.TabIndex = 8;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(122, 59);
            this.txtPorcentaje.MaxLength = 10;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(61, 20);
            this.txtPorcentaje.TabIndex = 9;
            this.txtPorcentaje.TextChanged += new System.EventHandler(this.txtPorcentaje_TextChanged);
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComision_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCodigoImpuesto
            // 
            this.txtCodigoImpuesto.Location = new System.Drawing.Point(122, 10);
            this.txtCodigoImpuesto.MaxLength = 10;
            this.txtCodigoImpuesto.Name = "txtCodigoImpuesto";
            this.txtCodigoImpuesto.Size = new System.Drawing.Size(61, 20);
            this.txtCodigoImpuesto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "COD. IMPUESTO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "(CODIGO VALIDO POR SII)";
            // 
            // frmImpuestos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(483, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoImpuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatos);
            this.MaximizeBox = false;
            this.Name = "frmImpuestos";
            this.ShowIcon = false;
            this.Text = "Modulo Impuestos Especiales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVendedor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void txtPorcentaje_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
