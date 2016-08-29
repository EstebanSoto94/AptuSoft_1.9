 
// Type: Aptusoft.frmSeleccionDevolucionBoleta
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmSeleccionDevolucionBoleta : Form
  {
    private IContainer components = (IContainer) null;
    private Button btnBoletaNormal;
    private Button btnBoletaFiscal;

    public frmSeleccionDevolucionBoleta()
    {
      this.InitializeComponent();
    }

    private void btnBoletaNormal_Click(object sender, EventArgs e)
    {
    }

    private void btnBoletaFiscal_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.btnBoletaNormal = new Button();
      this.btnBoletaFiscal = new Button();
      this.SuspendLayout();
      this.btnBoletaNormal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBoletaNormal.Location = new Point(33, 64);
      this.btnBoletaNormal.Name = "btnBoletaNormal";
      this.btnBoletaNormal.Size = new Size(213, 55);
      this.btnBoletaNormal.TabIndex = 0;
      this.btnBoletaNormal.Text = "Devolucion Boleta Normal";
      this.btnBoletaNormal.UseVisualStyleBackColor = true;
      this.btnBoletaNormal.Click += new EventHandler(this.btnBoletaNormal_Click);
      this.btnBoletaFiscal.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnBoletaFiscal.Location = new Point(33, 140);
      this.btnBoletaFiscal.Name = "btnBoletaFiscal";
      this.btnBoletaFiscal.Size = new Size(213, 55);
      this.btnBoletaFiscal.TabIndex = 1;
      this.btnBoletaFiscal.Text = "Devolucion Boleta Fiscal";
      this.btnBoletaFiscal.UseVisualStyleBackColor = true;
      this.btnBoletaFiscal.Click += new EventHandler(this.btnBoletaFiscal_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(284, 261);
      this.Controls.Add((Control) this.btnBoletaFiscal);
      this.Controls.Add((Control) this.btnBoletaNormal);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmSeleccionDevolucionBoleta";
      this.Text = "Seleccion Devolucion Boleta";
      this.ResumeLayout(false);
    }
  }
}
