 
// Type: Aptusoft.Promocion.Formularios.frmPromocion
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.Promocion.Clases;
using Aptusoft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft.Promocion.Formularios
{
  public class frmPromocion : Form
  {
    private IContainer components = (IContainer) null;
    private List<PromocionVO> listaPromociones = new List<PromocionVO>();
    private List<DetallePromocionVO> lista = new List<DetallePromocionVO>();
    private int idPromocion = 0;
    private Panel panel1;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private DateTimePicker dtpFin;
    private DateTimePicker dtpInicio;
    private TextBox txtPrecio;
    private TextBox txtCantidad;
    private TextBox txtDescripcion;
    private Label label2;
    private DataGridView dgvDatos;
    private Button btnGuardar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private Label label7;
    private Button btnAgregar;
    private GroupBox groupBox1;
    private Button btnLimpiaDetalle;
    private ToolTip toolTip1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private DataGridView dgvLista;
    private Label label1;
    private DataGridViewTextBoxColumn IdPromocionLista;
    private DataGridViewTextBoxColumn DescripcionPromocion;
    private DataGridViewTextBoxColumn FechaInicio;
    private DataGridViewTextBoxColumn FechaTermino;
    private DataGridViewTextBoxColumn Precio;
    private DataGridViewTextBoxColumn Cantidad;
    private DataGridViewTextBoxColumn codigo;
    private DataGridViewTextBoxColumn Descripcion;
    private DataGridViewTextBoxColumn CantidadEnPromocion;
    private DataGridViewButtonColumn Elimina;
    private frmPromocion intance;

    public frmPromocion()
    {
      this.InitializeComponent();
      this.intance = this;
      this.toolTip1.SetToolTip((Control) this.btnAgregar, "Agregar Producto a la Promocion");
      this.toolTip1.SetToolTip((Control) this.btnLimpiaDetalle, "Limpiar Grilla de Productos");
      this.toolTip1.SetToolTip((Control) this.btnGuardar, "Guardar Promocion");
      this.toolTip1.SetToolTip((Control) this.btnEliminar, "Eliminar Promocion");
      this.toolTip1.SetToolTip((Control) this.btnLimpiar, "Limpiar Formulario");
      this.toolTip1.SetToolTip((Control) this.btnSalir, "Salir del Modulo");
      this.toolTip1.SetToolTip((Control) this.txtDescripcion, "nombre que identifica a la promocion, Ejemplo: lleve 3 pague 1");
      this.toolTip1.SetToolTip((Control) this.txtCantidad, "cantidad de productos necesarios para que se cumpla la promocion");
      this.toolTip1.SetToolTip((Control) this.txtPrecio, "Precio de la promocion si se cumple la cantidad de productos");
      this.dgvDatos.AutoGenerateColumns = false;
      this.dgvLista.AutoGenerateColumns = false;
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
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      this.panel1 = new Panel();
      this.txtDescripcion = new TextBox();
      this.label7 = new Label();
      this.dtpFin = new DateTimePicker();
      this.dtpInicio = new DateTimePicker();
      this.txtPrecio = new TextBox();
      this.label4 = new Label();
      this.txtCantidad = new TextBox();
      this.label3 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label2 = new Label();
      this.dgvDatos = new DataGridView();
      this.groupBox1 = new GroupBox();
      this.toolTip1 = new ToolTip(this.components);
      this.btnLimpiaDetalle = new Button();
      this.btnAgregar = new Button();
      this.btnSalir = new Button();
      this.btnLimpiar = new Button();
      this.btnEliminar = new Button();
      this.btnGuardar = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.tabPage2 = new TabPage();
      this.label1 = new Label();
      this.dgvLista = new DataGridView();
      this.IdPromocionLista = new DataGridViewTextBoxColumn();
      this.DescripcionPromocion = new DataGridViewTextBoxColumn();
      this.FechaInicio = new DataGridViewTextBoxColumn();
      this.FechaTermino = new DataGridViewTextBoxColumn();
      this.Precio = new DataGridViewTextBoxColumn();
      this.Cantidad = new DataGridViewTextBoxColumn();
      this.codigo = new DataGridViewTextBoxColumn();
      this.Descripcion = new DataGridViewTextBoxColumn();
      this.CantidadEnPromocion = new DataGridViewTextBoxColumn();
      this.Elimina = new DataGridViewButtonColumn();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dgvDatos).BeginInit();
      this.groupBox1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((ISupportInitialize) this.dgvLista).BeginInit();
      this.SuspendLayout();
      this.panel1.BorderStyle = BorderStyle.Fixed3D;
      this.panel1.Controls.Add((Control) this.txtDescripcion);
      this.panel1.Controls.Add((Control) this.label7);
      this.panel1.Controls.Add((Control) this.dtpFin);
      this.panel1.Controls.Add((Control) this.dtpInicio);
      this.panel1.Controls.Add((Control) this.txtPrecio);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.txtCantidad);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Location = new Point(4, 5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(494, 121);
      this.panel1.TabIndex = 0;
      this.txtDescripcion.CharacterCasing = CharacterCasing.Upper;
      this.txtDescripcion.Location = new Point(8, 28);
      this.txtDescripcion.Name = "txtDescripcion";
      this.txtDescripcion.Size = new Size(472, 20);
      this.txtDescripcion.TabIndex = 8;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(111, 97);
      this.label7.Name = "label7";
      this.label7.Size = new Size(122, 13);
      this.label7.TabIndex = 13;
      this.label7.Text = "Ejemplo lleve 3 x $1.000";
      this.dtpFin.Format = DateTimePickerFormat.Short;
      this.dtpFin.Location = new Point(362, 72);
      this.dtpFin.Name = "dtpFin";
      this.dtpFin.Size = new Size(116, 20);
      this.dtpFin.TabIndex = 12;
      this.dtpInicio.Format = DateTimePickerFormat.Short;
      this.dtpInicio.Location = new Point(240, 72);
      this.dtpInicio.Name = "dtpInicio";
      this.dtpInicio.Size = new Size(116, 20);
      this.dtpInicio.TabIndex = 11;
      this.txtPrecio.CharacterCasing = CharacterCasing.Upper;
      this.txtPrecio.Location = new Point(124, 72);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.Size = new Size(110, 20);
      this.txtPrecio.TabIndex = 10;
      this.txtPrecio.TextAlign = HorizontalAlignment.Right;
      this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress);
      this.label4.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label4.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(124, 52);
      this.label4.Name = "label4";
      this.label4.Size = new Size(110, 23);
      this.label4.TabIndex = 3;
      this.label4.Text = "Paga (Precio)";
      this.label4.TextAlign = ContentAlignment.MiddleLeft;
      this.txtCantidad.CharacterCasing = CharacterCasing.Upper;
      this.txtCantidad.Location = new Point(8, 72);
      this.txtCantidad.Name = "txtCantidad";
      this.txtCantidad.Size = new Size(110, 20);
      this.txtCantidad.TabIndex = 9;
      this.txtCantidad.TextAlign = HorizontalAlignment.Right;
      this.txtCantidad.KeyPress += new KeyPressEventHandler(this.txtCantidad_KeyPress);
      this.label3.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label3.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(8, 52);
      this.label3.Name = "label3";
      this.label3.Size = new Size(110, 23);
      this.label3.TabIndex = 2;
      this.label3.Text = "Lleva (Cantidad)";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.label6.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label6.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.White;
      this.label6.Location = new Point(362, 52);
      this.label6.Name = "label6";
      this.label6.Size = new Size(116, 23);
      this.label6.TabIndex = 5;
      this.label6.Text = "Fin";
      this.label6.TextAlign = ContentAlignment.MiddleLeft;
      this.label5.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label5.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(240, 52);
      this.label5.Name = "label5";
      this.label5.Size = new Size(116, 23);
      this.label5.TabIndex = 4;
      this.label5.Text = "Inicio";
      this.label5.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.BackColor = Color.FromArgb(128, 128, (int) byte.MaxValue);
      this.label2.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(8, 8);
      this.label2.Name = "label2";
      this.label2.Size = new Size(472, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "Descripcion Promocion";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.dgvDatos.AllowUserToAddRows = false;
      this.dgvDatos.AllowUserToDeleteRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvDatos.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvDatos.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDatos.Columns.AddRange((DataGridViewColumn) this.codigo, (DataGridViewColumn) this.Descripcion, (DataGridViewColumn) this.CantidadEnPromocion, (DataGridViewColumn) this.Elimina);
      this.dgvDatos.Location = new Point(7, 15);
      this.dgvDatos.Name = "dgvDatos";
      this.dgvDatos.RowHeadersVisible = false;
      this.dgvDatos.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDatos.Size = new Size(477, 225);
      this.dgvDatos.TabIndex = 1;
      this.groupBox1.Controls.Add((Control) this.dgvDatos);
      this.groupBox1.Controls.Add((Control) this.btnLimpiaDetalle);
      this.groupBox1.Controls.Add((Control) this.btnAgregar);
      this.groupBox1.Location = new Point(6, 128);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(492, 289);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Productos Incluidos en la promocion";
      this.btnLimpiaDetalle.Image = (Image) Resources.construccion_de_eliminar_icono_9418_32;
      this.btnLimpiaDetalle.Location = new Point(443, 245);
      this.btnLimpiaDetalle.Name = "btnLimpiaDetalle";
      this.btnLimpiaDetalle.Size = new Size(40, 40);
      this.btnLimpiaDetalle.TabIndex = 9;
      this.btnLimpiaDetalle.UseVisualStyleBackColor = true;
      this.btnAgregar.Image = (Image) Resources.construccion_de_anadir_icono_5620_32;
      this.btnAgregar.Location = new Point(400, 244);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new Size(40, 40);
      this.btnAgregar.TabIndex = 7;
      this.btnAgregar.TextAlign = ContentAlignment.BottomCenter;
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
      this.btnSalir.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSalir.Image = (Image) Resources.salir_de_mi_perfil_icono_3964_48;
      this.btnSalir.ImageAlign = ContentAlignment.TopCenter;
      this.btnSalir.Location = new Point(447, 460);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(72, 72);
      this.btnSalir.TabIndex = 6;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextAlign = ContentAlignment.BottomCenter;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnLimpiar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnLimpiar.Image = (Image) Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
      this.btnLimpiar.ImageAlign = ContentAlignment.TopCenter;
      this.btnLimpiar.Location = new Point(155, 460);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(72, 72);
      this.btnLimpiar.TabIndex = 5;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new EventHandler(this.btnLimpiar_Click);
      this.btnEliminar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnEliminar.Image = (Image) Resources.mark_correo_basura_icono_3897_48;
      this.btnEliminar.ImageAlign = ContentAlignment.TopCenter;
      this.btnEliminar.Location = new Point(80, 460);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new Size(72, 72);
      this.btnEliminar.TabIndex = 4;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
      this.btnEliminar.UseVisualStyleBackColor = true;
      this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
      this.btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnGuardar.Image = (Image) Resources.disquetes_excepto_icono_7120_48;
      this.btnGuardar.ImageAlign = ContentAlignment.TopCenter;
      this.btnGuardar.Location = new Point(5, 460);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(72, 72);
      this.btnGuardar.TabIndex = 3;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.TextAlign = ContentAlignment.BottomCenter;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.HotTrack = true;
      this.tabControl1.Location = new Point(3, 5);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(518, 449);
      this.tabControl1.TabIndex = 10;
      this.tabPage1.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage1.BorderStyle = BorderStyle.FixedSingle;
      this.tabPage1.Controls.Add((Control) this.panel1);
      this.tabPage1.Controls.Add((Control) this.groupBox1);
//      this.tabPage1.ImeMode = ImeMode.NoControl;
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(510, 423);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Promocion";
      this.tabPage1.ToolTipText = "Maestro de Promociones";
      this.tabPage2.BackColor = Color.FromArgb(223, 233, 245);
      this.tabPage2.BorderStyle = BorderStyle.FixedSingle;
      this.tabPage2.Controls.Add((Control) this.label1);
      this.tabPage2.Controls.Add((Control) this.dgvLista);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(510, 423);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Lista de Promociones Activas";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(11, 402);
      this.label1.Name = "label1";
      this.label1.Size = new Size(270, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Doble click sobre la fila para seleccionar una promocion";
      this.dgvLista.AllowUserToAddRows = false;
      this.dgvLista.AllowUserToDeleteRows = false;
      gridViewCellStyle2.BackColor = Color.Lavender;
      this.dgvLista.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.dgvLista.BackgroundColor = SystemColors.ActiveCaption;
      this.dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLista.Columns.AddRange((DataGridViewColumn) this.IdPromocionLista, (DataGridViewColumn) this.DescripcionPromocion, (DataGridViewColumn) this.FechaInicio, (DataGridViewColumn) this.FechaTermino, (DataGridViewColumn) this.Precio, (DataGridViewColumn) this.Cantidad);
      this.dgvLista.Location = new Point(6, 6);
      this.dgvLista.Name = "dgvLista";
      this.dgvLista.ReadOnly = true;
      this.dgvLista.RowHeadersVisible = false;
      this.dgvLista.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgvLista.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvLista.Size = new Size(496, 390);
      this.dgvLista.TabIndex = 0;
      this.dgvLista.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
      this.IdPromocionLista.DataPropertyName = "IdPromocion";
      this.IdPromocionLista.HeaderText = "IdPromocion";
      this.IdPromocionLista.Name = "IdPromocionLista";
      this.IdPromocionLista.ReadOnly = true;
      this.IdPromocionLista.Visible = false;
      this.DescripcionPromocion.DataPropertyName = "Descripcion";
      this.DescripcionPromocion.HeaderText = "Descripcion";
      this.DescripcionPromocion.Name = "DescripcionPromocion";
      this.DescripcionPromocion.ReadOnly = true;
      this.DescripcionPromocion.Width = 235;
      this.FechaInicio.DataPropertyName = "Inicio";
      gridViewCellStyle3.Format = "d";
      gridViewCellStyle3.NullValue = (object) null;
      this.FechaInicio.DefaultCellStyle = gridViewCellStyle3;
      this.FechaInicio.HeaderText = "Inicio";
      this.FechaInicio.Name = "FechaInicio";
      this.FechaInicio.ReadOnly = true;
      this.FechaInicio.Width = 80;
      this.FechaTermino.DataPropertyName = "Fin";
      gridViewCellStyle4.Format = "d";
      this.FechaTermino.DefaultCellStyle = gridViewCellStyle4;
      this.FechaTermino.HeaderText = "Termino";
      this.FechaTermino.Name = "FechaTermino";
      this.FechaTermino.ReadOnly = true;
      this.FechaTermino.Width = 80;
      this.Precio.DataPropertyName = "Precio";
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle5.Format = "N0";
      gridViewCellStyle5.NullValue = (object) "0";
      this.Precio.DefaultCellStyle = gridViewCellStyle5;
      this.Precio.HeaderText = "Precio";
      this.Precio.Name = "Precio";
      this.Precio.ReadOnly = true;
      this.Precio.Width = 80;
      this.Cantidad.DataPropertyName = "Cantidad";
      this.Cantidad.HeaderText = "Cantidad";
      this.Cantidad.Name = "Cantidad";
      this.Cantidad.ReadOnly = true;
      this.Cantidad.Visible = false;
      this.codigo.DataPropertyName = "Codigo";
      this.codigo.HeaderText = "Codigo";
      this.codigo.Name = "codigo";
      this.codigo.ReadOnly = true;
      this.codigo.Width = 80;
      this.Descripcion.DataPropertyName = "DescripcionDetalle";
      this.Descripcion.HeaderText = "Descripcion";
      this.Descripcion.Name = "Descripcion";
      this.Descripcion.ReadOnly = true;
      this.Descripcion.Width = 230;
      this.CantidadEnPromocion.DataPropertyName = "CantidadDetalle";
      gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle6.Format = "N0";
      this.CantidadEnPromocion.DefaultCellStyle = gridViewCellStyle6;
      this.CantidadEnPromocion.HeaderText = "Cantidad";
      this.CantidadEnPromocion.Name = "CantidadEnPromocion";
      this.CantidadEnPromocion.Width = 80;
      this.Elimina.HeaderText = "Elimina";
      this.Elimina.Name = "Elimina";
      this.Elimina.Text = "X";
      this.Elimina.ToolTipText = "Eliminar Producto";
      this.Elimina.UseColumnTextForButtonValue = true;
      this.Elimina.Width = 60;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
///      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(525, 538);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.btnEliminar);
      this.Controls.Add((Control) this.btnGuardar);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "frmPromocion";
      this.ShowIcon = false;
      this.Text = "Maestro de Promociones";
      this.KeyDown += new KeyEventHandler(this.frmPromocion_KeyDown);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dgvDatos).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((ISupportInitialize) this.dgvLista).EndInit();
      this.ResumeLayout(false);
    }

    private void iniciaFormulario()
    {
      this.cargaPromocionesActivas();
      this.idPromocion = 0;
      this.btnEliminar.Enabled = false;
      this.txtDescripcion.Clear();
      this.txtCantidad.Clear();
      this.txtPrecio.Clear();
      this.dtpInicio.Value = DateTime.Now;
      this.dtpFin.Value = DateTime.Now;
      this.dgvDatos.DataSource = (object) null;
      this.lista.Clear();
      this.txtDescripcion.Focus();
    }

    private void cargaPromocionesActivas()
    {
      this.listaPromociones.Clear();
      this.listaPromociones = new Promo().listaPromocion();
      if (this.listaPromociones.Count <= 0)
        return;
      this.dgvLista.DataSource = (object) null;
      this.dgvLista.DataSource = (object) this.listaPromociones;
    }

    public void agregaProductoGrilla(string cod, string des)
    {
      this.lista.Add(new DetallePromocionVO()
      {
        Codigo = cod,
        DescripcionDetalle = des
      });
      this.dgvDatos.DataSource = (object) null;
      this.dgvDatos.DataSource = (object) this.lista;
    }

    private bool valida()
    {
      if (this.txtDescripcion.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar una descripcion de la promocion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.txtDescripcion.Focus();
        return false;
      }
      if (this.txtCantidad.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar una cantidad de producto para cumplir promocion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.txtCantidad.Focus();
        return false;
      }
      if (this.txtPrecio.Text.Trim().Length == 0)
      {
        int num = (int) MessageBox.Show("Debe Ingresar un precion de la promocion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.txtPrecio.Focus();
        return false;
      }
      if (this.lista.Count != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingresar productos a la promocion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.btnAgregar.Focus();
      return false;
    }

    private PromocionVO armaPromocion()
    {
      return new PromocionVO()
      {
        IdPromocion = this.idPromocion,
        Descripcion = this.txtDescripcion.Text.Trim(),
        Cantidad = Convert.ToDecimal(this.txtCantidad.Text.Trim()),
        Precio = Convert.ToDecimal(this.txtPrecio.Text.Trim()),
        Inicio = this.dtpInicio.Value,
        Fin = this.dtpFin.Value
      };
    }

    private void guardaModifica()
    {
      if (!this.valida())
        return;
      Promo promo = new Promo();
      if (this.idPromocion == 0)
      {
        promo.agregaPromocion(this.armaPromocion(), this.lista);
        int num = (int) MessageBox.Show("Promocion Guardada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        promo.modificaPromocion(this.armaPromocion(), this.lista);
        int num = (int) MessageBox.Show("Promocion Modificada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      this.iniciaFormulario();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      int num = (int) new frmBuscaProductos("promocion", ref this.intance).ShowDialog();
      this.btnGuardar.Focus();
    }

    private void frmPromocion_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.F4)
        return;
      int num = (int) new frmBuscaProductos("promocion", ref this.intance).ShowDialog();
      this.btnGuardar.Focus();
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (caja.Text.Trim().Length == 0 && (int) e.KeyChar == 44)
        e.KeyChar = '0';
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

    private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtCantidad);
    }

    private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtPrecio);
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaModifica();
    }

    private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.idPromocion = Convert.ToInt32(this.dgvLista.SelectedRows[0].Cells["IdPromocionLista"].Value);
      this.txtDescripcion.Text = this.dgvLista.SelectedRows[0].Cells["DescripcionPromocion"].Value.ToString();
      this.dtpInicio.Value = Convert.ToDateTime(this.dgvLista.SelectedRows[0].Cells["FechaInicio"].Value);
      this.dtpFin.Value = Convert.ToDateTime(this.dgvLista.SelectedRows[0].Cells["FechaTermino"].Value);
      this.txtPrecio.Text = Convert.ToDecimal(this.dgvLista.SelectedRows[0].Cells["Precio"].Value.ToString()).ToString("##");
      this.txtCantidad.Text = Convert.ToDecimal(this.dgvLista.SelectedRows[0].Cells["Cantidad"].Value.ToString()).ToString("##");
      this.lista.Clear();
      this.lista = new Promo().buscaDetallePromocionId(this.idPromocion);
      if (this.lista.Count > 0)
      {
        this.dgvDatos.DataSource = (object) null;
        this.dgvDatos.DataSource = (object) this.lista;
      }
      this.btnEliminar.Enabled = true;
      this.tabControl1.SelectTab(this.tabPage1);
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar esta Promocion", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        new Promo().eliminaPromocion(this.idPromocion);
        int num = (int) MessageBox.Show("Promocion Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      else
      {
        int num1 = (int) MessageBox.Show("La promocion NO fue Eliminada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
  }
}
