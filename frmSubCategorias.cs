 
// Type: Aptusoft.frmSubCategorias
 
 
// version 1.8.0

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmSubCategorias : Form
  {
    private IContainer components = (IContainer) null;
    private DataGridView dgvCategoriaEnSub;
    private Label label1;
    private DataGridView dgvSubCategoria;
    private Label label2;
    private TextBox textBox1;
    private Button btnGuardar;
    private Button btnLimpiar;
    private Button btnSalir;

    public frmSubCategorias()
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
      this.dgvCategoriaEnSub = new DataGridView();
      this.label1 = new Label();
      this.dgvSubCategoria = new DataGridView();
      this.label2 = new Label();
      this.textBox1 = new TextBox();
      this.btnGuardar = new Button();
      this.btnLimpiar = new Button();
      this.btnSalir = new Button();
      ((ISupportInitialize) this.dgvCategoriaEnSub).BeginInit();
      ((ISupportInitialize) this.dgvSubCategoria).BeginInit();
      this.SuspendLayout();
      this.dgvCategoriaEnSub.BackgroundColor = Color.LightSteelBlue;
      this.dgvCategoriaEnSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCategoriaEnSub.Location = new Point(12, 29);
      this.dgvCategoriaEnSub.Name = "dgvCategoriaEnSub";
      this.dgvCategoriaEnSub.Size = new Size(250, 379);
      this.dgvCategoriaEnSub.TabIndex = 0;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(76, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Categorias";
      this.dgvSubCategoria.BackgroundColor = Color.PapayaWhip;
      this.dgvSubCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSubCategoria.Location = new Point(268, 57);
      this.dgvSubCategoria.Name = "dgvSubCategoria";
      this.dgvSubCategoria.Size = new Size(410, 350);
      this.dgvSubCategoria.TabIndex = 2;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(265, 9);
      this.label2.Name = "label2";
      this.label2.Size = new Size(98, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Sub Categoria";
      this.textBox1.Location = new Point(268, 31);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(239, 20);
      this.textBox1.TabIndex = 4;
      this.btnGuardar.Location = new Point(513, 28);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(70, 23);
      this.btnGuardar.TabIndex = 5;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Location = new Point(603, 28);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new Size(75, 23);
      this.btnLimpiar.TabIndex = 6;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnSalir.Location = new Point(603, 413);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 23);
      this.btnSalir.TabIndex = 7;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(686, 438);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnLimpiar);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.dgvSubCategoria);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.dgvCategoriaEnSub);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = "frmSubCategorias";
      this.ShowIcon = false;
      this.Text = "SubCategorias";
      ((ISupportInitialize) this.dgvCategoriaEnSub).EndInit();
      ((ISupportInitialize) this.dgvSubCategoria).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
