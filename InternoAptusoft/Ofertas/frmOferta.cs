 
// Type: Aptusoft.InternoAptusoft.Ofertas.frmOferta
 
 
// version 1.8.0

using Aptusoft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft.InternoAptusoft.Ofertas
{
  public class frmOferta : Form
  {
    private List<OfertaVO> _listaOfertas = new List<OfertaVO>();
    private int _idOferta = 0;
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txtCodigo;
    private TextBox txtNombreOferta;
    private TextBox txtDescripcion;
    private DataGridView dgvOfertas;
    private Panel panel1;
    private Button btnGuardar;
    private Button btnLimpiar;
    private Button btnSalir;
    private CheckBox chkOfertaVigente;
    private DataGridViewTextBoxColumn IdOferta;
    private DataGridViewTextBoxColumn CodigoOferta;
    private DataGridViewTextBoxColumn Nombre;
    private DataGridViewTextBoxColumn Descripcion;
    private DataGridViewCheckBoxColumn Vigente;
    private DataGridViewButtonColumn Elimina;
    private TextBox txtDescuento;
    private Label label4;
    private TextBox txtCantMeses;
    private Label label5;

    public frmOferta()
    {
      this.InitializeComponent();
      this.dgvOfertas.AutoGenerateColumns = false;
      this.IniciaFormulario();
    }

    private void IniciaFormulario()
    {
      this._idOferta = 0;
      this.txtCodigo.Clear();
      this.txtNombreOferta.Clear();
      this.txtDescripcion.Clear();
      this.chkOfertaVigente.Checked = false;
      this.txtCantMeses.Clear();
      this.txtDescuento.Clear();
      this.txtCodigo.Focus();
      this.CargaOfertas();
    }

    private void CargaOfertas()
    {
      this._listaOfertas = new OfertaNegocio().ListaOfertas();
      this.dgvOfertas.DataSource = (object) null;
      if (this._listaOfertas.Count <= 0)
        return;
      this.dgvOfertas.DataSource = (object) this._listaOfertas;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private OfertaVO ArmaOferta()
    {
      return new OfertaVO()
      {
        IdOferta = this._idOferta,
        CodigoOferta = this.txtCodigo.Text.Trim(),
        Nombre = this.txtNombreOferta.Text.Trim(),
        Descripcion = this.txtDescripcion.Text.Trim(),
        Vigente = this.chkOfertaVigente.Checked,
        Descuento = this.txtDescuento.Text.Trim().Length > 0 ? Convert.ToDecimal(this.txtDescuento.Text.Trim()) : new Decimal(0),
        CantidadMeses = this.txtCantMeses.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtCantMeses.Text.Trim()) : 0
      };
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      new OfertaNegocio().GuardaOferta(this.ArmaOferta());
      this.IniciaFormulario();
    }

    private void dgvOfertas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!(this.dgvOfertas.Columns[e.ColumnIndex].Name == "Elimina") || MessageBox.Show("Esta seguro de Eliminar esta Oferta", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this._idOferta = Convert.ToInt32(this.dgvOfertas.SelectedRows[0].Cells["IdOferta"].Value.ToString());
      new OfertaNegocio().EliminaOferta(this._idOferta);
      this.IniciaFormulario();
    }

    private void dgvOfertas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this._listaOfertas.Count <= 0)
        return;
      this._idOferta = Convert.ToInt32(this.dgvOfertas.SelectedRows[0].Cells["IdOferta"].Value.ToString());
      OfertaVO ofertaVo = new OfertaNegocio().BuscaOfertaPorIdEnLista(this._listaOfertas, this._idOferta);
      if (ofertaVo.IdOferta > 0)
      {
        this.txtCodigo.Clear();
        this.txtNombreOferta.Clear();
        this.txtDescripcion.Clear();
        this.txtCodigo.Text = ofertaVo.CodigoOferta;
        this.txtNombreOferta.Text = ofertaVo.Nombre;
        this.txtDescripcion.Text = ofertaVo.Descripcion;
        this.chkOfertaVigente.Checked = ofertaVo.Vigente;
        this.txtCantMeses.Text = ofertaVo.CantidadMeses.ToString();
        this.txtDescuento.Text = ofertaVo.Descuento.ToString();
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.IniciaFormulario();
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
      this.label2 = new Label();
      this.label3 = new Label();
      this.txtCodigo = new TextBox();
      this.txtNombreOferta = new TextBox();
      this.txtDescripcion = new TextBox();
      this.dgvOfertas = new DataGridView();
      this.IdOferta = new DataGridViewTextBoxColumn();
      this.CodigoOferta = new DataGridViewTextBoxColumn();
      this.Nombre = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.Vigente = new DataGridViewCheckBoxColumn();
      this.Elimina = new DataGridViewButtonColumn();
      this.panel1 = new Panel();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnGuardar = new Button();
      this.chkOfertaVigente = new CheckBox();
      this.txtDescuento = new TextBox();
      this.label4 = new Label();
      this.txtCantMeses = new TextBox();
      this.label5 = new Label();
      ((ISupportInitialize) this.dgvOfertas).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.label1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label1.Location = new Point(9, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(100, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Codigo";
      this.label2.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label2.Location = new Point(112, 15);
      this.label2.Name = "label2";
      this.label2.Size = new Size(267, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nombre";
      this.label3.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label3.Location = new Point(9, 97);
      this.label3.Name = "label3";
      this.label3.Size = new Size(370, 23);
      this.label3.TabIndex = 2;
      this.label3.Text = "Descripcion";
      this.txtCodigo.CharacterCasing = CharacterCasing.Upper;
      this.txtCodigo.Location = new Point(9, 31);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new Size(100, 20);
      this.txtCodigo.TabIndex = 3;
      this.txtNombreOferta.CharacterCasing = CharacterCasing.Upper;
      this.txtNombreOferta.Location = new Point(112, 31);
      this.txtNombreOferta.Name = "txtNombreOferta";
      this.txtNombreOferta.Size = new Size(267, 20);
      this.txtNombreOferta.TabIndex = 4;
      this.txtDescripcion.CharacterCasing = CharacterCasing.Upper;
      this.txtDescripcion.Location = new Point(9, 113);
      this.txtDescripcion.Multiline = true;
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(370, 43);
      this.txtDescripcion.TabIndex = 5;
      this.dgvOfertas.AllowUserToAddRows = false;
      this.dgvOfertas.AllowUserToDeleteRows = false;
      this.dgvOfertas.AllowUserToResizeColumns = false;
      this.dgvOfertas.AllowUserToResizeRows = false;
      this.dgvOfertas.BackgroundColor = Color.LightSteelBlue;
      this.dgvOfertas.BorderStyle = BorderStyle.Fixed3D;
      this.dgvOfertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvOfertas.Columns.AddRange((DataGridViewColumn) this.IdOferta, (DataGridViewColumn) this.CodigoOferta, (DataGridViewColumn) this.Nombre, (DataGridViewColumn) this.Descripcion, (DataGridViewColumn) this.Vigente, (DataGridViewColumn) this.Elimina);
      this.dgvOfertas.Location = new Point(9, 162);
      this.dgvOfertas.Name = "dgvOfertas";
      this.dgvOfertas.ReadOnly = true;
      this.dgvOfertas.RowHeadersVisible = false;
      this.dgvOfertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvOfertas.Size = new Size(370, 167);
      this.dgvOfertas.TabIndex = 6;
      this.dgvOfertas.CellClick += new DataGridViewCellEventHandler(this.dgvOfertas_CellClick);
      this.dgvOfertas.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvOfertas_CellDoubleClick);
      this.IdOferta.DataPropertyName = "IdOferta";
      this.IdOferta.HeaderText = "IdOferta";
      this.IdOferta.Name = "IdOferta";
      this.IdOferta.ReadOnly = true;
      this.IdOferta.Visible = false;
      this.CodigoOferta.DataPropertyName = "CodigoOferta";
      this.CodigoOferta.HeaderText = "Codigo";
      this.CodigoOferta.Name = "CodigoOferta";
      this.CodigoOferta.ReadOnly = true;
      this.CodigoOferta.Width = 60;
      this.Nombre.DataPropertyName = "Nombre";
      this.Nombre.HeaderText = "Nombre";
      this.Nombre.Name = "Nombre";
      this.Nombre.ReadOnly = true;
      this.Nombre.Width = 175;
      this.Descripcion.DataPropertyName = "Descripcion";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      this.Descripcion.Visible = false;
      this.Vigente.DataPropertyName = "Vigente";
      this.Vigente.HeaderText = "Vigente";
      this.Vigente.Name = "Vigente";
      this.Vigente.ReadOnly = true;
      this.Vigente.Resizable = DataGridViewTriState.True;
      this.Vigente.SortMode = DataGridViewColumnSortMode.Automatic;
      this.Vigente.Width = 73;
      this.Elimina.HeaderText = "";
      this.Elimina.Name = "Elimina";
      this.Elimina.ReadOnly = true;
      this.Elimina.Text = "X";
      this.Elimina.UseColumnTextForButtonValue = true;
      this.Elimina.Width = 40;
      this.panel1.Controls.Add((Control) this.btnSalir);
      this.panel1.Controls.Add((Control) this.btnLimpiar);
      this.panel1.Controls.Add((Control) this.btnGuardar);
      this.panel1.Location = new Point(385, 6);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(67, 323);
      this.panel1.TabIndex = 7;
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Image = (Image) Resources.salir_de_mi_perfil_icono_3964_48;
      this.btnSalir.Location = new Point(2, 252);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(60, 60);
      this.btnSalir.TabIndex = 24;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextAlign = ContentAlignment.BottomCenter;
      this.btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Image = (Image) Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
      this.btnLimpiar.Location = new Point(2, 72);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(60, 60);
      this.btnLimpiar.TabIndex = 23;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
      this.btnLimpiar.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnGuardar.BackgroundImageLayout = ImageLayout.Center;
      this.btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Image = (Image) Resources.guardar_documento_icono_7840_32;
      this.btnGuardar.Location = new Point(2, 7);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(60, 60);
      this.btnGuardar.TabIndex = 20;
      this.btnGuardar.Text = "Guarda";
      this.btnGuardar.TextAlign = ContentAlignment.BottomCenter;
      this.btnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.chkOfertaVigente.AutoSize = true;
      this.chkOfertaVigente.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.chkOfertaVigente.Location = new Point(240, 72);
      this.chkOfertaVigente.Name = "chkOfertaVigente";
      this.chkOfertaVigente.Size = new Size(119, 17);
      this.chkOfertaVigente.TabIndex = 8;
      this.chkOfertaVigente.Text = "OFERTA VIGENTE";
      this.chkOfertaVigente.UseVisualStyleBackColor = false;
      this.txtDescuento.CharacterCasing = CharacterCasing.Upper;
      this.txtDescuento.Location = new Point(9, 72);
      this.txtDescuento.Name = "txtDescuento";
      this.txtDescuento.Size = new Size(100, 20);
      this.txtDescuento.TabIndex = 10;
      this.label4.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label4.Location = new Point(9, 56);
      this.label4.Name = "label4";
      this.label4.Size = new Size(100, 23);
      this.label4.TabIndex = 9;
      this.label4.Text = "% Descuento";
      this.txtCantMeses.CharacterCasing = CharacterCasing.Upper;
      this.txtCantMeses.Location = new Point(115, 72);
      this.txtCantMeses.Name = "txtCantMeses";
      this.txtCantMeses.Size = new Size(100, 20);
      this.txtCantMeses.TabIndex = 12;
      this.label5.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.label5.Location = new Point(115, 56);
      this.label5.Name = "label5";
      this.label5.Size = new Size(100, 23);
      this.label5.TabIndex = 11;
      this.label5.Text = "Cant. Meses";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(456, 340);
      this.Controls.Add((Control) this.txtCantMeses);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.txtDescuento);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.chkOfertaVigente);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.dgvOfertas);
      this.Controls.Add((Control) this.txtDescripcion);
      this.Controls.Add((Control) this.txtNombreOferta);
      this.Controls.Add((Control) this.txtCodigo);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmOferta";
      this.ShowIcon = false;
      this.Text = "Modulo de Ofertas";
      ((ISupportInitialize) this.dgvOfertas).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
