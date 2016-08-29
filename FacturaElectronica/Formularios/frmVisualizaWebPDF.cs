 
// Type: Aptusoft.FacturaElectronica.Formularios.frmVisualizaWebPDF
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmVisualizaWebPDF : Form
  {
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private WebBrowser webBrowser1;
    private Button btnSalir;

    public frmVisualizaWebPDF()
    {
      this.InitializeComponent();
      this.inicia();
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
      this.webBrowser1 = new WebBrowser();
      this.btnSalir = new Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.webBrowser1);
      this.panel1.Location = new Point(12, 34);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(984, 611);
      this.panel1.TabIndex = 0;
      this.webBrowser1.Dock = DockStyle.Fill;
      this.webBrowser1.Location = new Point(0, 0);
      this.webBrowser1.MinimumSize = new Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new Size(984, 611);
      this.webBrowser1.TabIndex = 0;
      this.btnSalir.Location = new Point(921, 5);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 23);
      this.btnSalir.TabIndex = 1;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1008, 730);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.panel1);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmVisualizaWebPDF";
      this.Text = "Visualizador PDF";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.frmVisualizaWebPDF_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void inicia()
    {
      this.webBrowser1.Navigate("C:\\AptuSoft\\Electronica\\PDF\\E-Factura\\EFactura_181.pdf");
    }

    private void frmVisualizaWebPDF_Load(object sender, EventArgs e)
    {
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
