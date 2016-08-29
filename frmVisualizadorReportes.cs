 
// Type: Aptusoft.frmVisualizadorReportes
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmVisualizadorReportes : Form
  {
    private IContainer components = (IContainer) null;
    private CrystalReportViewer crvVisualizador;
    private Panel panel1;
    private Button btnSalir;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem salirToolStripMenuItem;

    public frmVisualizadorReportes()
    {
      this.InitializeComponent();
    }

    public frmVisualizadorReportes(ReportDocument rpt)
    {
      this.InitializeComponent();
      this.crvVisualizador.ReportSource = (object) rpt;
      this.crvVisualizador.RefreshReport();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.crvVisualizador = new CrystalReportViewer();
      this.panel1 = new Panel();
      this.btnSalir = new Button();
      this.menuStrip1 = new MenuStrip();
      this.salirToolStripMenuItem = new ToolStripMenuItem();
      this.panel1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.crvVisualizador.ActiveViewIndex = -1;
      this.crvVisualizador.BorderStyle = BorderStyle.Fixed3D;
      this.crvVisualizador.DisplayGroupTree = false;
      this.crvVisualizador.Dock = DockStyle.Fill;
      this.crvVisualizador.Location = new Point(0, 0);
      this.crvVisualizador.Name = "crvVisualizador";
      this.crvVisualizador.SelectionFormula = "";
      this.crvVisualizador.ShowCloseButton = false;
      this.crvVisualizador.ShowGroupTreeButton = false;
      this.crvVisualizador.ShowRefreshButton = false;
      this.crvVisualizador.Size = new Size(1300, 665);
      this.crvVisualizador.TabIndex = 0;
      this.crvVisualizador.ViewTimeSelectionFormula = "";
      this.panel1.Controls.Add((Control) this.crvVisualizador);
      this.panel1.Location = new Point(12, 27);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1300, 665);
      this.panel1.TabIndex = 1;
      this.btnSalir.Location = new Point(1318, 27);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(53, 49);
      this.btnSalir.TabIndex = 2;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.menuStrip1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.salirToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1547, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new Size(41, 20);
      this.salirToolStripMenuItem.Text = "Salir";
      this.salirToolStripMenuItem.Click += new EventHandler(this.salirToolStripMenuItem_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(1547, 740);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.menuStrip1);
//      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmVisualizadorReportes";
      this.ShowIcon = false;
      this.Text = "Visualizador de Reportes";
      this.WindowState = FormWindowState.Maximized;
      this.panel1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Dispose();
      this.Close();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Dispose();
      this.Close();
    }
  }
}
