 
// Type: Aptusoft.frmNuevaBusquedaClienteProveedor
 
 
// version 1.8.0

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmNuevaBusquedaClienteProveedor : Form
  {
    private IContainer components = (IContainer) null;
    private DataGridView dgvCliente;

    public frmNuevaBusquedaClienteProveedor()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.dgvCliente = new DataGridView();
      ((ISupportInitialize) this.dgvCliente).BeginInit();
      this.SuspendLayout();
      this.dgvCliente.BackgroundColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCliente.Location = new Point(2, 4);
      this.dgvCliente.Name = "dgvCliente";
      this.dgvCliente.Size = new Size(945, 447);
      this.dgvCliente.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(949, 453);
      this.Controls.Add((Control) this.dgvCliente);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmNuevaBusquedaClienteProveedor";
      ((ISupportInitialize) this.dgvCliente).EndInit();
      this.ResumeLayout(false);
    }
  }
}
