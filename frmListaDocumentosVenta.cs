 
// Type: Aptusoft.frmListaDocumentosVenta
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmListaDocumentosVenta : Form
  {
    private frmBoleta frmBol = (frmBoleta) null;
    private frmBoletaFiscal frmBolFis = (frmBoletaFiscal) null;
    private IContainer components = (IContainer) null;
    private int caja;
    private DataGridView dgvDocumentoVenta;
    private GroupBox groupBox1;
    private Label label2;
    private DateTimePicker dtpHasta;
    private Label label3;
    private DateTimePicker dtpDesde;
    private Button btnFiltrar;
    private Label label1;

    public frmListaDocumentosVenta()
    {
      this.InitializeComponent();
      this.iniciaFormulario();
    }

    public frmListaDocumentosVenta(int caja, ref frmBoleta b)
    {
      this.InitializeComponent();
      this.iniciaFormulario();
      this.caja = caja;
      this.frmBol = b;
    }

    public frmListaDocumentosVenta(int caja, ref frmBoletaFiscal b)
    {
      this.InitializeComponent();
      this.iniciaFormulario();
      this.caja = caja;
      this.frmBolFis = b;
    }

    private void iniciaFormulario()
    {
      this.dgvDocumentoVenta.DataSource = (object) null;
      this.dgvDocumentoVenta.Columns.Clear();
      this.creaColumnasDetalle();
    }

    private void creaColumnasDetalle()
    {
        this.dgvDocumentoVenta.AutoGenerateColumns = false;
        this.dgvDocumentoVenta.Columns.Add("IdBoleta", "IdBoleta");
        this.dgvDocumentoVenta.Columns[0].DataPropertyName = "idBoleta";
        this.dgvDocumentoVenta.Columns[0].Width = 50;
        this.dgvDocumentoVenta.Columns[0].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns[0].Visible = true;
        this.dgvDocumentoVenta.Columns.Add("Folio", "Folio");
        this.dgvDocumentoVenta.Columns[1].DataPropertyName = "folio";
        this.dgvDocumentoVenta.Columns[1].Width = 70;
        this.dgvDocumentoVenta.Columns[1].DefaultCellStyle.Format = "N0";
        this.dgvDocumentoVenta.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        this.dgvDocumentoVenta.Columns[1].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns.Add("Folio POS", "Folio POS");
        this.dgvDocumentoVenta.Columns[2].DataPropertyName = "foliopos";
        this.dgvDocumentoVenta.Columns[2].Width = 100;
        this.dgvDocumentoVenta.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        this.dgvDocumentoVenta.Columns[2].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns.Add("FechaEmision", "Emision");
        this.dgvDocumentoVenta.Columns[3].DataPropertyName = "fechaEmision";
        this.dgvDocumentoVenta.Columns[3].Width = 100;
        this.dgvDocumentoVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        this.dgvDocumentoVenta.Columns[3].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns.Add("Rut", "Rut");
        this.dgvDocumentoVenta.Columns[4].DataPropertyName = "rut";
        this.dgvDocumentoVenta.Columns[4].Width = 70;
        this.dgvDocumentoVenta.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        this.dgvDocumentoVenta.Columns[4].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns[4].Visible = false;
        this.dgvDocumentoVenta.Columns.Add("Digito", "");
        this.dgvDocumentoVenta.Columns[5].DataPropertyName = "digito";
        this.dgvDocumentoVenta.Columns[5].Width = 20;
        this.dgvDocumentoVenta.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        this.dgvDocumentoVenta.Columns[5].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns[5].Visible = false;
        this.dgvDocumentoVenta.Columns.Add("RazonSocial", "Razon Social");
        this.dgvDocumentoVenta.Columns[6].DataPropertyName = "razonSocial";
        this.dgvDocumentoVenta.Columns[6].Width = 200;
        this.dgvDocumentoVenta.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        this.dgvDocumentoVenta.Columns[6].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns.Add("EstadoPago", "Estado de Pago");
        this.dgvDocumentoVenta.Columns[7].DataPropertyName = "estadoPago";
        this.dgvDocumentoVenta.Columns[7].Width = 110;
        this.dgvDocumentoVenta.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        this.dgvDocumentoVenta.Columns[7].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns[7].Visible = false;
        this.dgvDocumentoVenta.Columns.Add("Total", "Total");
        this.dgvDocumentoVenta.Columns[8].DataPropertyName = "totalaCobrar";
        this.dgvDocumentoVenta.Columns[8].Width = 80;
        this.dgvDocumentoVenta.Columns[8].DefaultCellStyle.Format = "N0";
        this.dgvDocumentoVenta.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        this.dgvDocumentoVenta.Columns[8].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns.Add("Vendedor", "Vendedor");
        this.dgvDocumentoVenta.Columns[9].DataPropertyName = "vendedor";
        this.dgvDocumentoVenta.Columns[9].Width = 110;
        this.dgvDocumentoVenta.Columns[9].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns.Add("EstadoDocumento", "Estado Documento");
        this.dgvDocumentoVenta.Columns[10].DataPropertyName = "estadoDocumento";
        this.dgvDocumentoVenta.Columns[10].Width = 110;
        this.dgvDocumentoVenta.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        this.dgvDocumentoVenta.Columns[10].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns[10].Visible = false;
        this.dgvDocumentoVenta.Columns.Add("Caja", "Caja");
        this.dgvDocumentoVenta.Columns[11].DataPropertyName = "caja";
        this.dgvDocumentoVenta.Columns[11].Width = 110;
        this.dgvDocumentoVenta.Columns[11].Resizable = DataGridViewTriState.False;
        this.dgvDocumentoVenta.Columns[11].Visible = false;
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.frmBol != null)
          this.dgvDocumentoVenta.DataSource = (object) new Boleta().boletaListado(Convert.ToDateTime(this.dtpDesde.Text), Convert.ToDateTime(this.dtpHasta.Text), this.caja);
        else
          this.dgvDocumentoVenta.DataSource = (object) new BoletaFiscal().boletaListado(Convert.ToDateTime(this.dtpDesde.Text), Convert.ToDateTime(this.dtpHasta.Text), this.caja);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error : " + ex.Message);
      }
    }

    private void dgvDocumentoVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      int id = Convert.ToInt32(this.dgvDocumentoVenta.SelectedRows[0].Cells[0].Value.ToString());
      if (this.frmBol != null)
        this.frmBol.buscaBoletaID(id);
      else
        this.frmBolFis.buscaBoletaID(id);
      this.Close();
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
      this.dgvDocumentoVenta = new DataGridView();
      this.groupBox1 = new GroupBox();
      this.btnFiltrar = new Button();
      this.label2 = new Label();
      this.dtpHasta = new DateTimePicker();
      this.label3 = new Label();
      this.dtpDesde = new DateTimePicker();
      this.label1 = new Label();
      ((ISupportInitialize) this.dgvDocumentoVenta).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.dgvDocumentoVenta.AllowUserToAddRows = false;
      this.dgvDocumentoVenta.AllowUserToDeleteRows = false;
      gridViewCellStyle.BackColor = Color.Lavender;
      this.dgvDocumentoVenta.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.dgvDocumentoVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgvDocumentoVenta.Location = new Point(12, 80);
      this.dgvDocumentoVenta.Name = "dgvDocumentoVenta";
      this.dgvDocumentoVenta.ReadOnly = true;
      this.dgvDocumentoVenta.RowHeadersVisible = false;
      this.dgvDocumentoVenta.RowHeadersWidth = 30;
      this.dgvDocumentoVenta.RowTemplate.Resizable = DataGridViewTriState.False;
      this.dgvDocumentoVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dgvDocumentoVenta.Size = new Size(638, 366);
      this.dgvDocumentoVenta.TabIndex = 1;
      this.dgvDocumentoVenta.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvDocumentoVenta_CellDoubleClick);
      this.groupBox1.Controls.Add((Control) this.btnFiltrar);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.dtpHasta);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.dtpDesde);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(638, 62);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.btnFiltrar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnFiltrar.Location = new Point(227, 15);
      this.btnFiltrar.Name = "btnFiltrar";
      this.btnFiltrar.Size = new Size(65, 38);
      this.btnFiltrar.TabIndex = 14;
      this.btnFiltrar.Text = "Filtrar";
      this.btnFiltrar.UseVisualStyleBackColor = true;
      this.btnFiltrar.Click += new EventHandler(this.btnFiltrar_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(6, 16);
      this.label2.Name = "label2";
      this.label2.Size = new Size(43, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Desde";
      this.dtpHasta.Format = DateTimePickerFormat.Short;
      this.dtpHasta.Location = new Point(113, 33);
      this.dtpHasta.Name = "dtpHasta";
      this.dtpHasta.Size = new Size(98, 20);
      this.dtpHasta.TabIndex = 9;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(114, 16);
      this.label3.Name = "label3";
      this.label3.Size = new Size(39, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Hasta";
      this.dtpDesde.Format = DateTimePickerFormat.Short;
      this.dtpDesde.Location = new Point(9, 33);
      this.dtpDesde.Name = "dtpDesde";
      this.dtpDesde.Size = new Size(98, 20);
      this.dtpDesde.TabIndex = 8;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(12, 449);
      this.label1.Name = "label1";
      this.label1.Size = new Size(366, 15);
      this.label1.TabIndex = 15;
      this.label1.Text = "Si el Folio es 0 significa que es un Comprobante de Boleta Exenta";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(660, 469);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.dgvDocumentoVenta);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmListaDocumentosVenta";
      this.ShowIcon = false;
      this.Text = "Lista Documentos de Venta";
      ((ISupportInitialize) this.dgvDocumentoVenta).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
