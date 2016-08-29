 
// Type: Aptusoft.frmMantenedorBodegaCajaListaOtros
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmMantenedorBodegaCajaListaOtros : Form
  {
    private string _tipo = "";
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox txtDescripcion;
    private DataGridView dgvDatos;
    private Button btnGuardar;
    private Button btnSalir;
    private Button btnLimpiar;
    private DataGridViewTextBoxColumn codigo;
    private DataGridViewTextBoxColumn descripcion;
    private TextBox txtCodigo;
    private Label label2;

    public frmMantenedorBodegaCajaListaOtros(string tipo)
    {
      this.InitializeComponent();
      this.dgvDatos.AutoGenerateColumns = false;
      this._tipo = tipo;
      this.iniciaFormulario();
    }

    private void iniciaFormulario()
    {
      this.btnGuardar.Enabled = false;
      this.txtCodigo.Clear();
      this.txtDescripcion.Clear();
      if (this._tipo.Equals("BODEGA"))
        this.cargaBodega();
      if (this._tipo.Equals("LISTA_PRECIO"))
        this.cargaListaPrecio();
      if (this._tipo.Equals("CAJAS"))
        this.cargaCajas();
      this.txtDescripcion.Focus();
    }

    private void cargaBodega()
    {
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) new BodegaCajaListaOtros().listaBodegas();
    }

    private void cargaListaPrecio()
    {
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) new BodegaCajaListaOtros().listaListas_Precio();
    }

    private void cargaCajas()
    {
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) new BodegaCajaListaOtros().listaCajas();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.txtCodigo.Text = this.dgvDatos.SelectedRows[0].Cells["codigo"].Value.ToString();
      this.txtDescripcion.Text = this.dgvDatos.SelectedRows[0].Cells["descripcion"].Value.ToString();
      this.btnGuardar.Enabled = true;
      this.txtDescripcion.Focus();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (this.txtDescripcion.Text.Trim().Length > 0 && this.txtCodigo.Text.Trim().Length > 0)
      {
        if (this._tipo.Equals("BODEGA"))
        {
          new BodegaCajaListaOtros().modificaBodega(this.txtCodigo.Text, this.txtDescripcion.Text);
          int num = (int) MessageBox.Show("Bodega Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        if (this._tipo.Equals("LISTA_PRECIO"))
        {
          new BodegaCajaListaOtros().modificaListaprecio(this.txtCodigo.Text, this.txtDescripcion.Text);
          int num = (int) MessageBox.Show("Lista Precio Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        if (!this._tipo.Equals("CAJAS"))
          return;
        new BodegaCajaListaOtros().modificaCaja(this.txtCodigo.Text, this.txtDescripcion.Text);
        int num1 = (int) MessageBox.Show("Caja Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      else
      {
        int num = (int) MessageBox.Show("Datos no Validos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtDescripcion.Focus();
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
      this.label1 = new Label();
      this.txtDescripcion = new TextBox();
      this.dgvDatos = new DataGridView();
      this.codigo = new DataGridViewTextBoxColumn();
      this.descripcion = new DataGridViewTextBoxColumn();
      this.btnGuardar = new Button();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.txtCodigo = new TextBox();
      this.label2 = new Label();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(1, 45);
      this.label1.Name = "label1";
      this.label1.Size = new Size(63, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Descripcion";
      this.txtDescripcion.CharacterCasing = CharacterCasing.Upper;
      this.txtDescripcion.Location = new Point(70, 42);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(230, 20);
      this.txtDescripcion.TabIndex = 1;
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      this.dgvDatos.AllowUserToResizeColumns = false;
      this.dgvDatos.AllowUserToResizeRows = false;
      gridViewCellStyle.BackColor = Color.Lavender;
      this.dgvDatos.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvDatos.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.codigo, (DataGridViewColumn) this.descripcion);
      this.dgvDatos.Location = new Point(4, 74);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.ReadOnly = true;
      this.dgvDatos.RowHeadersVisible = false;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(303, 279);
      this.dgvDatos.TabIndex = 2;
      this.dgvDatos.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
      this.codigo.DataPropertyName = "codigo";
      this.codigo.HeaderText = "Codigo";
      this.codigo.Name = "codigo";
      this.codigo.ReadOnly = true;
      this.codigo.Width = 60;
      this.descripcion.DataPropertyName = "descripcion";
      this.descripcion.HeaderText = "Descripcion";
      this.descripcion.Name = "descripcion";
      this.descripcion.ReadOnly = true;
      this.descripcion.Width = 220;
      this.btnGuardar.Location = new Point(316, 45);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 23);
      this.btnGuardar.TabIndex = 3;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnSalir.Location = new Point(316, 330);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 23);
      this.btnSalir.TabIndex = 4;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Location = new Point(316, 74);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 23);
      this.btnLimpiar.TabIndex = 5;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.txtCodigo.BackColor = Color.White;
      this.txtCodigo.CharacterCasing = CharacterCasing.Upper;
      this.txtCodigo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCodigo.ForeColor = Color.Black;
      this.txtCodigo.Location = new Point(70, 16);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.ReadOnly = true;
      this.txtCodigo.Size = new Size(80, 20);
      this.txtCodigo.TabIndex = 6;
      this.txtCodigo.TabStop = false;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(1, 20);
      this.label2.Name = "label2";
      this.label2.Size = new Size(40, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Codigo";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(403, 359);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.txtCodigo);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.dgvDatos);
      this.Controls.Add((Control) this.txtDescripcion);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmMantenedorBodegaCajaListaOtros";
      this.ShowIcon = false;
      this.Text = "Mantenedor";
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
