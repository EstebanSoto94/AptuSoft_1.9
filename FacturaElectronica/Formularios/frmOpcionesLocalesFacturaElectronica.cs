 
// Type: Aptusoft.FacturaElectronica.Formularios.frmOpcionesLocalesFacturaElectronica
 
 
// version 1.8.0

using Aptusoft.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmOpcionesLocalesFacturaElectronica : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox txtRuta;
    private Button btnExaminar;
    private Button btnGuardar;
    private Button btnSalir;
    private Button button1;

    public frmOpcionesLocalesFacturaElectronica()
    {
      this.InitializeComponent();
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
      this.txtRuta = new TextBox();
      this.btnExaminar = new Button();
      this.btnGuardar = new Button();
      this.btnSalir = new Button();
      this.button1 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(12, 23);
      this.label1.Name = "label1";
      this.label1.Size = new Size(274, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ruta de Archivos Para Facturacion Electronica";
      this.txtRuta.BackColor = Color.White;
      this.txtRuta.Location = new Point(12, 39);
      this.txtRuta.Name = "txtRuta";
      this.txtRuta.ReadOnly = true;
      this.txtRuta.Size = new Size(352, 20);
      this.txtRuta.TabIndex = 1;
      this.btnExaminar.Location = new Point(289, 65);
      this.btnExaminar.Name = "btnExaminar";
      this.btnExaminar.Size = new Size(75, 23);
      this.btnExaminar.TabIndex = 2;
      this.btnExaminar.Text = "Examinar";
      this.btnExaminar.UseVisualStyleBackColor = true;
      this.btnExaminar.Click += new EventHandler(this.btnExaminar_Click);
      this.btnGuardar.Image = (Image) Resources.disquetes_excepto_icono_7120_48;
      this.btnGuardar.Location = new Point(12, 104);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(75, 76);
      this.btnGuardar.TabIndex = 3;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.TextAlign = ContentAlignment.BottomCenter;
      this.btnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.btnSalir.Image = (Image) Resources.salir_de_mi_perfil_icono_3964_48;
      this.btnSalir.Location = new Point(289, 104);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new Size(75, 76);
      this.btnSalir.TabIndex = 4;
      this.btnSalir.Text = "Salir";
      this.btnSalir.TextAlign = ContentAlignment.BottomCenter;
      this.btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new EventHandler(this.btnSalir_Click);
      this.button1.Location = new Point(152, 93);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
      this.ClientSize = new Size(379, 192);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.btnSalir);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.btnExaminar);
      this.Controls.Add((Control) this.txtRuta);
      this.Controls.Add((Control) this.label1);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmOpcionesLocalesFacturaElectronica";
      this.Text = "Opciones Locales Factura Electronica";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void IniciaFormulario()
    {
      this.CargaRuta();
    }

    private void CargaRuta()
    {
      DataSet dataSet = new DataSet("datos");
      int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
      string filterExpression = "principal=1";
      DataRow[] dataRowArray = dataSet.Tables["conexion"].Select(filterExpression);
      string str = "";
      for (int index = 0; index < dataRowArray.Length; ++index)
        str = dataRowArray[index]["rutaElectronica"].ToString();
      this.txtRuta.Text = str;
    }

    private void btnExaminar_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.ShowDialog();
      this.txtRuta.Text = folderBrowserDialog.SelectedPath;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      DataSet dataSet = new DataSet();
      int num1 = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
      dataSet.Tables["Conexion"].Rows[0]["rutaElectronica"] = (object) this.txtRuta.Text.Trim();
      dataSet.WriteXml("C:\\AptuSoft\\xml\\config.xml");
      int num2 = (int) MessageBox.Show("Ruta Guardada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(this.txtRuta.Text.Replace("\\", "\\\\") + "\\\\");
    }
  }
}
