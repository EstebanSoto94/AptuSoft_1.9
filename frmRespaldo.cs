 
// Type: Aptusoft.frmRespaldo
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmRespaldo : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Button btnRespaldo;
    private string servidor;
    private string usuario;
    private string clave;
    private string basedatos;
    private string rutaMySqlDump;

    public frmRespaldo()
    {
      this.InitializeComponent();
      this.cargarDatos();
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
      this.btnRespaldo = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(9, 46);
      this.label1.Name = "label1";
      this.label1.Size = new Size(268, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Respaldo de Base de Datos";
      this.btnRespaldo.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnRespaldo.Location = new Point(66, 131);
      this.btnRespaldo.Name = "btnRespaldo";
      this.btnRespaldo.Size = new Size(154, 38);
      this.btnRespaldo.TabIndex = 1;
      this.btnRespaldo.Text = "Hacer Respaldo";
      this.btnRespaldo.UseVisualStyleBackColor = true;
      this.btnRespaldo.Click += new EventHandler(this.btnRespaldo_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(284, 262);
      this.Controls.Add((Control) this.btnRespaldo);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmRespaldo";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Modulo Respaldo";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void cargarDatos()
    {
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        this.servidor = dataSet.Tables["Conexion"].Rows[0]["server"].ToString();
        this.basedatos = dataSet.Tables["Conexion"].Rows[0]["base"].ToString();
        this.usuario = dataSet.Tables["Conexion"].Rows[0]["user"].ToString();
        this.clave = dataSet.Tables["Conexion"].Rows[0]["pass"].ToString();
        this.rutaMySqlDump = dataSet.Tables["Conexion"].Rows[0]["dump"].ToString();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("No hay registros, Ingrese Datos " + ex.Message);
      }
    }

    private void btnRespaldo_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Respaldo BD MySql|*.sql";
      saveFileDialog.Title = "Respaldo Base de Datos MySql";
      string str = (this.basedatos + "_" + DateTime.Now.ToString() + ".sql").Replace("/", "-").Replace(":", "_");
      saveFileDialog.FileName = str;
      int num1 = (int) saveFileDialog.ShowDialog();
      if (!(saveFileDialog.FileName != ""))
        return;
      this.DatabaseBackup(saveFileDialog.FileName);
      int num2 = (int) MessageBox.Show(saveFileDialog.FileName);
    }

    public void DatabaseBackup(string destino)
    {
      try
      {
        string str1 = "";
        str1 = ("-" + DateTime.Now.ToString() + ".sql").Replace("/", "-").Replace(":", "_");
        StreamWriter streamWriter = new StreamWriter(destino);
        ProcessStartInfo startInfo = new ProcessStartInfo();
        string str2 = string.Format("-u{0} -p{1} -h{2} {3} --hex-blob --default-character-set=latin1", (object) this.usuario, (object) this.clave, (object) this.servidor, (object) this.basedatos);
        startInfo.FileName = this.rutaMySqlDump;
        startInfo.RedirectStandardInput = false;
        startInfo.RedirectStandardOutput = true;
        startInfo.Arguments = str2;
        startInfo.UseShellExecute = false;
        Process process = Process.Start(startInfo);
        string str3 = process.StandardOutput.ReadToEnd();
        streamWriter.WriteLine(str3);
        process.WaitForExit();
        streamWriter.Close();
        int num = (int) MessageBox.Show("Respaldo Terminado", "Respaldo OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      catch (IOException ex)
      {
        int num = (int) MessageBox.Show(ex.Message.ToString());
      }
    }
  }
}
