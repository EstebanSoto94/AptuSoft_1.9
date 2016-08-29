 
// Type: Aptusoft.frmImprimeDocumento
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmImprimeDocumento : Form
  {
    private IContainer components = (IContainer) null;
    private frmFactura frmFac = (frmFactura) null;
    private ReportDocument rpt = new ReportDocument();
    private Panel panel1;
    private Button btnSalir;
    private Button btnImprime;
    private ComboBox cmbImpresora;
    private CrystalReportViewer crvReporte;
    private DataTable dtFactura;

    public frmImprimeDocumento()
    {
      this.InitializeComponent();
    }

    public frmImprimeDocumento(DataTable dtf, ref frmFactura f)
    {
      this.InitializeComponent();
      this.dtFactura = dtf;
      this.frmFac = f;
      this.muestraReporte();
      this.cargaComboImpresoras();
      this.cmbImpresora.SelectedItem = (object) this.impresoraDefecto();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panel1 = new Panel();
      this.btnSalir = new Button();
      this.btnImprime = new Button();
      this.cmbImpresora = new ComboBox();
      this.crvReporte = new CrystalReportViewer();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.crvReporte);
      this.panel1.Location = new Point(12, 41);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(886, 567);
      this.panel1.TabIndex = 0;
      this.btnSalir.Location = new Point(823, 10);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 23);
      this.btnSalir.TabIndex = 1;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.btnImprime.Location = new Point(304, 12);
      this.btnImprime.Name = "btnImprime";
      this.btnImprime.Size = new Size(75, 23);
      this.btnImprime.TabIndex = 2;
      this.btnImprime.Text = "Imprimir";
      this.btnImprime.UseVisualStyleBackColor = true;
      this.btnImprime.Click += new EventHandler(this.btnImprime_Click);
      this.cmbImpresora.FormattingEnabled = true;
      this.cmbImpresora.Location = new Point(12, 12);
      this.cmbImpresora.Name = "cmbImpresora";
      this.cmbImpresora.Size = new Size(219, 21);
      this.cmbImpresora.TabIndex = 3;
      this.crvReporte.ActiveViewIndex = -1;
      this.crvReporte.BorderStyle = BorderStyle.Fixed3D;
      this.crvReporte.DisplayGroupTree = false;
      this.crvReporte.Dock = DockStyle.Fill;
      this.crvReporte.Location = new Point(0, 0);
      this.crvReporte.Name = "crvReporte";
      this.crvReporte.SelectionFormula = "";
      this.crvReporte.ShowCloseButton = false;
      this.crvReporte.ShowGroupTreeButton = false;
      this.crvReporte.ShowPrintButton = false;
      this.crvReporte.Size = new Size(886, 567);
      this.crvReporte.TabIndex = 0;
      this.crvReporte.ViewTimeSelectionFormula = "";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1037, 620);
      this.Controls.Add((Control) this.cmbImpresora);
      this.Controls.Add((Control) this.btnImprime);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.panel1);
      this.Name = "frmImprimeDocumento";
      this.Text = "Visor";
      this.WindowState = FormWindowState.Maximized;
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public string impresoraDefecto()
    {
      for (int index = 0; index < PrinterSettings.InstalledPrinters.Count; ++index)
      {
        if (new PrinterSettings()
        {
          PrinterName = PrinterSettings.InstalledPrinters[index].ToString()
        }.IsDefaultPrinter)
          return PrinterSettings.InstalledPrinters[index].ToString();
      }
      return "";
    }

    public void cargaComboImpresoras()
    {
      for (int index = 0; index < PrinterSettings.InstalledPrinters.Count; ++index)
        this.cmbImpresora.Items.Add((object) new PrinterSettings()
        {
          PrinterName = PrinterSettings.InstalledPrinters[index].ToString()
        }.PrinterName.ToString());
    }

    public void muestraReporte()
    {
      try
      {
        this.rpt.Load("reportes\\Factura.rpt");
        this.rpt.SetDataSource(this.dtFactura);
        this.crvReporte.ReportSource = (object) this.rpt;
        this.crvReporte.RefreshReport();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message);
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.frmFac.iniciaVenta();
      this.Close();
      this.Dispose();
    }

    private void crvReporte_HandleException(object source, ExceptionEventArgs e)
    {
      int num = (int) MessageBox.Show(e.Exception.ToString());
    }

    private void btnImprime_Click(object sender, EventArgs e)
    {
      try
      {
        this.rpt.PrintOptions.PrinterName = this.cmbImpresora.Text;
        this.rpt.PrintToPrinter(1, false, 1, 1);
        this.frmFac.iniciaVenta();
        this.Close();
        this.Dispose();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message);
      }
    }
  }
}
