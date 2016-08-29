 
// Type: Aptusoft.frmListadoPagosCompra
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmListadoPagosCompra : Form
  {
    private IContainer components = (IContainer) null;
    private DataGridView dgvDocumentoCompra;
    private Button btnFiltrar;
    private Label label1;
    private ComboBox cmbTipoDocumento;
    private Label label2;
    private Label label3;
    private Label label4;
    private DateTimePicker dtpDesde;
    private DateTimePicker dtpHasta;
    private TextBox txtProveedor;
    private GroupBox groupBox1;
    private Panel pnlBuscaProveedorDes;
    private DataGridView dgvBuscaProveedor;
    private TextBox txtFolio;
    private Label label5;
    private Label label6;
    private Button button1;
    private frmListadoPagosCompra intance;

    public frmListadoPagosCompra()
    {
      this.InitializeComponent();
      this.iniciaFormulario();
      this.intance = this;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.dgvDocumentoCompra = new DataGridView();
      this.btnFiltrar = new Button();
      this.label1 = new Label();
      this.cmbTipoDocumento = new ComboBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.dtpDesde = new DateTimePicker();
      this.dtpHasta = new DateTimePicker();
      this.txtProveedor = new TextBox();
      this.groupBox1 = new GroupBox();
      this.txtFolio = new TextBox();
      this.label5 = new Label();
      this.pnlBuscaProveedorDes = new Panel();
      this.dgvBuscaProveedor = new DataGridView();
      this.label6 = new Label();
      this.button1 = new Button();
      ((ISupportInitialize) this.dgvDocumentoCompra).BeginInit();
      this.groupBox1.SuspendLayout();
      this.pnlBuscaProveedorDes.SuspendLayout();
      ((ISupportInitialize) this.dgvBuscaProveedor).BeginInit();
      this.SuspendLayout();
      this.dgvDocumentoCompra.AllowUserToAddRows = false;
      this.dgvDocumentoCompra.AllowUserToDeleteRows = false;
      gridViewCellStyle1.BackColor = Color.Lavender;
      this.dgvDocumentoCompra.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.dgvDocumentoCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvDocumentoCompra.Location = new Point(12, 111);
      this.dgvDocumentoCompra.Name = "dgvDocumentoCompra";
      this.dgvDocumentoCompra.ReadOnly = true;
      this.dgvDocumentoCompra.RowHeadersVisible = false;
      this.dgvDocumentoCompra.RowHeadersWidth = 30;
      this.dgvDocumentoCompra.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDocumentoCompra.Size = new Size(1024, 383);
      this.dgvDocumentoCompra.TabIndex = 0;
      this.dgvDocumentoCompra.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDocumentoCompra_CellDoubleClick);
      this.btnFiltrar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnFiltrar.Location = new Point(971, 47);
      this.btnFiltrar.Name = "btnFiltrar";
      this.btnFiltrar.Size = new Size(65, 53);
      this.btnFiltrar.TabIndex = 1;
      this.btnFiltrar.Text = "Filtrar";
      this.btnFiltrar.UseVisualStyleBackColor = true;
      this.btnFiltrar.Click += new EventHandler(this.btnFiltrar_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(9, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(94, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Estado de Pago";
      this.cmbTipoDocumento.FormattingEnabled = true;
      this.cmbTipoDocumento.Location = new Point(9, 33);
      this.cmbTipoDocumento.Name = "cmbTipoDocumento";
      this.cmbTipoDocumento.Size = new Size(141, 21);
      this.cmbTipoDocumento.TabIndex = 3;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(153, 16);
      this.label2.Name = "label2";
      this.label2.Size = new Size(43, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Desde";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(261, 16);
      this.label3.Name = "label3";
      this.label3.Size = new Size(39, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Hasta";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(462, 16);
      this.label4.Name = "label4";
      this.label4.Size = new Size(63, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "Proveedor";
      this.dtpDesde.Format = DateTimePickerFormat.Short;
      this.dtpDesde.Location = new Point(156, 33);
      this.dtpDesde.Name = "dtpDesde";
      this.dtpDesde.Size = new Size(98, 20);
      this.dtpDesde.TabIndex = 8;
      this.dtpHasta.Format = DateTimePickerFormat.Short;
      this.dtpHasta.Location = new Point(260, 33);
      this.dtpHasta.Name = "dtpHasta";
      this.dtpHasta.Size = new Size(98, 20);
      this.dtpHasta.TabIndex = 9;
      this.txtProveedor.Location = new Point(462, 33);
      this.txtProveedor.Name = "txtProveedor";
      this.txtProveedor.Size = new Size(485, 20);
      this.txtProveedor.TabIndex = 11;
      this.txtProveedor.TextChanged += new EventHandler(this.txtProveedor_TextChanged);
      this.txtProveedor.KeyDown += new KeyEventHandler(this.txtProveedor_KeyDown);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.txtProveedor);
      this.groupBox1.Controls.Add((Control) this.cmbTipoDocumento);
      this.groupBox1.Controls.Add((Control) this.txtFolio);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.dtpHasta);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.dtpDesde);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Location = new Point(12, 37);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(953, 63);
      this.groupBox1.TabIndex = 12;
      this.groupBox1.TabStop = false;
      this.txtFolio.Location = new Point(367, 33);
      this.txtFolio.Name = "txtFolio";
      this.txtFolio.Size = new Size(91, 20);
      this.txtFolio.TabIndex = 10;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(367, 16);
      this.label5.Name = "label5";
      this.label5.Size = new Size(34, 15);
      this.label5.TabIndex = 7;
      this.label5.Text = "Folio";
      this.pnlBuscaProveedorDes.Controls.Add((Control) this.dgvBuscaProveedor);
      this.pnlBuscaProveedorDes.Location = new Point(305, 92);
      this.pnlBuscaProveedorDes.Name = "pnlBuscaProveedorDes";
      this.pnlBuscaProveedorDes.Size = new Size(642, 216);
      this.pnlBuscaProveedorDes.TabIndex = 33;
      this.dgvBuscaProveedor.AllowUserToAddRows = false;
      this.dgvBuscaProveedor.AllowUserToDeleteRows = false;
      this.dgvBuscaProveedor.AllowUserToResizeColumns = false;
      this.dgvBuscaProveedor.AllowUserToResizeRows = false;
      gridViewCellStyle2.BackColor = Color.Lavender;
      this.dgvBuscaProveedor.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      this.dgvBuscaProveedor.BackgroundColor = Color.LavenderBlush;
      this.dgvBuscaProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = SystemColors.Window;
      gridViewCellStyle3.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle3.ForeColor = SystemColors.ControlText;
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
      this.dgvBuscaProveedor.DefaultCellStyle = gridViewCellStyle3;
      this.dgvBuscaProveedor.Location = new Point(2, 2);
      this.dgvBuscaProveedor.Name = "dgvBuscaProveedor";
      this.dgvBuscaProveedor.ReadOnly = true;
      this.dgvBuscaProveedor.RowHeadersVisible = false;
      this.dgvBuscaProveedor.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvBuscaProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvBuscaProveedor.Size = new Size(637, 211);
      this.dgvBuscaProveedor.TabIndex = 0;
      this.dgvBuscaProveedor.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaProveedor_CellDoubleClick);
      this.dgvBuscaProveedor.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dgvBuscaProveedor_CellContentDoubleClick);
      this.dgvBuscaProveedor.KeyDown += new KeyEventHandler(this.dgvBuscaProveedor_KeyDown);
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(18, 9);
      this.label6.Name = "label6";
      this.label6.Size = new Size(414, 25);
      this.label6.TabIndex = 34;
      this.label6.Text = "Control de Pagos Facturas de Compra";
      this.button1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(961, 500);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 35;
      this.button1.Text = "Salir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1044, 762);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.pnlBuscaProveedorDes);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnFiltrar);
      this.Controls.Add((Control) this.dgvDocumentoCompra);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "frmListadoPagosCompra";
      this.ShowIcon = false;
      this.Text = "Facturas de Compra";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.frmListadoPagosCompra_FormClosing);
      ((ISupportInitialize) this.dgvDocumentoCompra).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.pnlBuscaProveedorDes.ResumeLayout(false);
      ((ISupportInitialize) this.dgvBuscaProveedor).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void iniciaFormulario()
    {
      this.dgvDocumentoCompra.DataSource = (object) null;
      this.dgvDocumentoCompra.Columns.Clear();
      this.creaColumnasDetalle();
      this.cargaEstadoDocumento();
    }

    private void cargaEstadoDocumento()
    {
      this.cmbTipoDocumento.DataSource = (object) new CargaMaestros().cargaEstadosPago();
      this.cmbTipoDocumento.ValueMember = "codigo";
      this.cmbTipoDocumento.DisplayMember = "descripcion";
      this.cmbTipoDocumento.SelectedValue = (object) 0;
      this.pnlBuscaProveedorDes.Visible = false;
      this.creaColumnasBuscaProveedores();
    }

    private void creaColumnasDetalle()
    {
      this.dgvDocumentoCompra.AutoGenerateColumns = false;
      this.dgvDocumentoCompra.Columns.Add("IdFactura", "IdFactura");
      this.dgvDocumentoCompra.Columns[0].DataPropertyName = "idCompra";
      this.dgvDocumentoCompra.Columns[0].Width = 20;
      this.dgvDocumentoCompra.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns[0].Visible = false;
      this.dgvDocumentoCompra.Columns.Add("TipoDocumentoCompra", "Tipo Documento");
      this.dgvDocumentoCompra.Columns[1].DataPropertyName = "tipoDocumentoCompra";
      this.dgvDocumentoCompra.Columns[1].Width = 100;
      this.dgvDocumentoCompra.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns[1].Visible = true;
      this.dgvDocumentoCompra.Columns.Add("Folio", "Folio");
      this.dgvDocumentoCompra.Columns[2].DataPropertyName = "folio";
      this.dgvDocumentoCompra.Columns[2].Width = 70;
      this.dgvDocumentoCompra.Columns[2].DefaultCellStyle.Format = "N0";
      this.dgvDocumentoCompra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDocumentoCompra.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("FechaEmision", "Emision");
      this.dgvDocumentoCompra.Columns[3].DataPropertyName = "fechaEmision";
      this.dgvDocumentoCompra.Columns[3].Width = 80;
      this.dgvDocumentoCompra.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dgvDocumentoCompra.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("Rut", "Rut");
      this.dgvDocumentoCompra.Columns[4].DataPropertyName = "rut";
      this.dgvDocumentoCompra.Columns[4].Width = 70;
      this.dgvDocumentoCompra.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDocumentoCompra.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("Digito", "");
      this.dgvDocumentoCompra.Columns[5].DataPropertyName = "digito";
      this.dgvDocumentoCompra.Columns[5].Width = 20;
      this.dgvDocumentoCompra.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.dgvDocumentoCompra.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("RazonSocial", "Razon Social");
      this.dgvDocumentoCompra.Columns[6].DataPropertyName = "razonSocial";
      this.dgvDocumentoCompra.Columns[6].Width = 220;
      this.dgvDocumentoCompra.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.dgvDocumentoCompra.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("EstadoPago", "Estado de Pago");
      this.dgvDocumentoCompra.Columns[7].DataPropertyName = "estadoPago";
      this.dgvDocumentoCompra.Columns[7].Width = 110;
      this.dgvDocumentoCompra.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.dgvDocumentoCompra.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("TotalCobrar", "Total");
      this.dgvDocumentoCompra.Columns[8].DataPropertyName = "totalCobrar";
      this.dgvDocumentoCompra.Columns[8].Width = 80;
      this.dgvDocumentoCompra.Columns[8].DefaultCellStyle.Format = "N0";
      this.dgvDocumentoCompra.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDocumentoCompra.Columns[8].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("TotalPagado", "Pagado");
      this.dgvDocumentoCompra.Columns[9].DataPropertyName = "totalPagado";
      this.dgvDocumentoCompra.Columns[9].Width = 80;
      this.dgvDocumentoCompra.Columns[9].DefaultCellStyle.Format = "N0";
      this.dgvDocumentoCompra.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDocumentoCompra.Columns[9].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("TotalDocumentado", "Documentado");
      this.dgvDocumentoCompra.Columns[10].DataPropertyName = "totalDocumentado";
      this.dgvDocumentoCompra.Columns[10].Width = 80;
      this.dgvDocumentoCompra.Columns[10].DefaultCellStyle.Format = "N0";
      this.dgvDocumentoCompra.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDocumentoCompra.Columns[10].Resizable = DataGridViewTriState.False;
      this.dgvDocumentoCompra.Columns.Add("TotalPendiente", "Pendiente");
      this.dgvDocumentoCompra.Columns[11].DataPropertyName = "totalPendiente";
      this.dgvDocumentoCompra.Columns[11].Width = 80;
      this.dgvDocumentoCompra.Columns[11].DefaultCellStyle.Format = "N0";
      this.dgvDocumentoCompra.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDocumentoCompra.Columns[11].Resizable = DataGridViewTriState.False;
    }

    private void creaColumnasBuscaProveedores()
    {
      this.dgvBuscaProveedor.Columns.Clear();
      this.dgvBuscaProveedor.AutoGenerateColumns = false;
      this.dgvBuscaProveedor.Columns.Add("Codigo", "Cod.");
      this.dgvBuscaProveedor.Columns[0].DataPropertyName = "Codigo";
      this.dgvBuscaProveedor.Columns[0].Width = 35;
      this.dgvBuscaProveedor.Columns.Add("Rut", "Rut");
      this.dgvBuscaProveedor.Columns[1].DataPropertyName = "Rut";
      this.dgvBuscaProveedor.Columns[1].Width = 80;
      this.dgvBuscaProveedor.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvBuscaProveedor.Columns.Add("Digito", "");
      this.dgvBuscaProveedor.Columns[2].DataPropertyName = "Digito";
      this.dgvBuscaProveedor.Columns[2].Width = 20;
      this.dgvBuscaProveedor.Columns.Add("RazonSocial", "Razon Social");
      this.dgvBuscaProveedor.Columns[3].DataPropertyName = "RazonSocial";
      this.dgvBuscaProveedor.Columns[3].Width = 270;
      this.dgvBuscaProveedor.Columns.Add("Direccion", "Direccion");
      this.dgvBuscaProveedor.Columns[4].DataPropertyName = "Direccion";
      this.dgvBuscaProveedor.Columns[4].Width = 226;
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
      if (this.cmbTipoDocumento.SelectedValue != null)
      {
        DataTable dataTable = new DocumentoCompra().listaDocumentoCompraPago(Convert.ToDateTime(this.dtpDesde.Text), Convert.ToDateTime(this.dtpHasta.Text), this.cmbTipoDocumento.Text, this.txtFolio.Text.Trim().Length > 0 ? (long) Convert.ToInt32(this.txtFolio.Text.Trim()) : 0L, this.txtProveedor.Text);
        dataTable.DefaultView.Sort = "fechaEmision ASC";
        this.dgvDocumentoCompra.DataSource = (object) dataTable;
      }
      else
      {
        int num = (int) MessageBox.Show("Debe seleccionar algun Tipo de Documento");
        this.cmbTipoDocumento.Focus();
      }
    }

    private void txtProveedor_TextChanged(object sender, EventArgs e)
    {
      if (this.txtProveedor.Text.Trim().Length > 0)
      {
        this.pnlBuscaProveedorDes.Visible = true;
        List<ClienteVO> list = new Proveedor().buscaProveedorDato(1, this.txtProveedor.Text.Trim());
        if (list.Count <= 0)
          return;
        this.dgvBuscaProveedor.DataSource = (object) list;
      }
      else
        this.pnlBuscaProveedorDes.Visible = false;
    }

    private void dgvBuscaProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.txtProveedor.Text = this.dgvBuscaProveedor.SelectedRows[0].Cells[3].Value.ToString();
      this.pnlBuscaProveedorDes.Visible = false;
    }

    private void dgvBuscaProveedor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.txtProveedor.Text = this.dgvBuscaProveedor.SelectedRows[0].Cells[3].Value.ToString();
      this.pnlBuscaProveedorDes.Visible = false;
    }

    private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
    {
      if (!this.pnlBuscaProveedorDes.Visible || e.KeyCode != Keys.Down)
        return;
      this.dgvBuscaProveedor.Focus();
    }

    private void dgvDocumentoCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      int num = (int) new frmPagosCompras(ref this.intance, this.dgvDocumentoCompra.SelectedRows[0].Cells[1].Value.ToString(), Convert.ToInt32(this.dgvDocumentoCompra.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      frmMenuPrincipal._modPagoCompra = 0;
      this.Close();
      this.Dispose();
    }

    private void dgvBuscaProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.txtProveedor.Text = this.dgvBuscaProveedor.SelectedRows[0].Cells[3].Value.ToString();
      this.pnlBuscaProveedorDes.Visible = false;
    }

    private void frmListadoPagosCompra_FormClosing(object sender, FormClosingEventArgs e)
    {
      frmMenuPrincipal._modPagoCompra = 0;
      this.Dispose();
    }
  }
}
