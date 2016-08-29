 
// Type: Aptusoft.FacturaElectronica.Formularios.frmVisualizaPDF
 
 
// version 1.8.0

using AxAcroPDFLib;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft.FacturaElectronica.Formularios
{
  public class frmVisualizaPDF : Form
  {
    private string _rutaElectronica = "";
    private string _archivo = "";
    private int _tipo = 0;
    private IContainer components = (IContainer) null;
    private Button btnImpresionCedible;
    private Button btnImpresionNormal;
    private AxAcroPDF axAcroPDF1;
    private Button btnSalir;

    public frmVisualizaPDF(string archivo, int tipo)
    {
      this.InitializeComponent();
      this.CargaRuta();
      this._tipo = tipo;
      if (tipo == 33)
      {
        this._archivo = archivo;
        archivo = "EFactura_" + archivo;
        this.btnImpresionNormal.Visible = true;
        this.btnImpresionCedible.Visible = true;
      }
      else if (tipo == 34)
      {
        this._archivo = archivo;
        archivo = "EFacturaExenta_" + archivo;
        this.btnImpresionNormal.Visible = true;
        this.btnImpresionCedible.Visible = true;
      }
      else if (tipo == 52)
      {
        this._archivo = archivo;
        archivo = "EGuia_" + archivo;
        this.btnImpresionNormal.Visible = true;
        this.btnImpresionCedible.Visible = true;
      }
      else if (tipo == 39)
      {
          this._archivo = archivo;
          archivo =  archivo;
          this.btnImpresionNormal.Visible = true;
          this.btnImpresionCedible.Visible = true;
      }
      else
      {
        this.btnImpresionNormal.Visible = false;
        this.btnImpresionCedible.Visible = false;
      }
      this.visualizaPdf(archivo, tipo);
    }

    private void CargaRuta()
    {
      try
      {
        DataSet dataSet = new DataSet("datos");
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        string filterExpression = "principal=1";
        DataRow[] dataRowArray = dataSet.Tables["conexion"].Select(filterExpression);
        string str = "";
        for (int index = 0; index < dataRowArray.Length; ++index)
          str = dataRowArray[index]["rutaElectronica"].ToString();
        this._rutaElectronica = str.Replace("\\", "\\\\") + "\\\\";
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Ruta " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void visualizaPdf(string archivo, int tipoDoc)
    {
      string str = "";
      if (tipoDoc == 33)
        str = this._rutaElectronica + "PDF\\E-Factura\\";
      if (tipoDoc == 34)
        str = this._rutaElectronica + "PDF\\E-FacturaExenta\\";
      if (tipoDoc == 39)
        str = this._rutaElectronica + "PDF\\E-Boleta\\";
      if (tipoDoc == 61)
        str = this._rutaElectronica + "PDF\\E-NotaCredito\\";
      if (tipoDoc == 56)
        str = this._rutaElectronica + "PDF\\E-NotaDebito\\";
      if (tipoDoc == 52)
        str = this._rutaElectronica + "PDF\\E-Guia\\";
      Uri r = new Uri(str + archivo + ".pdf");
      this.axAcroPDF1.LoadFile(str + archivo + ".pdf");
     // webKitBrowser1.Url = r;

    }

    private void btnImpresionNormal_Click(object sender, EventArgs e)
    {
      if (this._tipo == 33)
        this.visualizaPdf("EFactura_" + this._archivo, 33);
      if (this._tipo == 34)
        this.visualizaPdf("EFacturaExenta_" + this._archivo, 34);
      if (this._tipo != 52)
        return;
      this.visualizaPdf("EGuia_" + this._archivo, 52);
      if (this._tipo == 39)
          this.visualizaPdf(this._archivo, 39);
    }

    private void btnImpresionCedible_Click(object sender, EventArgs e)
    {
      if (this._tipo == 33)
        this.visualizaPdf("EFacturaCedible_" + this._archivo, 33);
      if (this._tipo == 34)
        this.visualizaPdf("EFacturaExentaCedible_" + this._archivo, 34);
      if (this._tipo != 52)
        return;
      this.visualizaPdf("EGuiaCedible_" + this._archivo, 52);
      if (this._tipo == 39)
          this.visualizaPdf(this._archivo, 39);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
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
            this.btnImpresionCedible = new System.Windows.Forms.Button();
            this.btnImpresionNormal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
          //  this.webKitBrowser1 = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // btnImpresionCedible
            // 
            this.btnImpresionCedible.BackColor = System.Drawing.Color.White;
            this.btnImpresionCedible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresionCedible.Location = new System.Drawing.Point(141, 12);
            this.btnImpresionCedible.Name = "btnImpresionCedible";
            this.btnImpresionCedible.Size = new System.Drawing.Size(114, 23);
            this.btnImpresionCedible.TabIndex = 4;
            this.btnImpresionCedible.Text = "Cedible";
            this.btnImpresionCedible.UseVisualStyleBackColor = false;
            this.btnImpresionCedible.Click += new System.EventHandler(this.btnImpresionCedible_Click);
            // 
            // btnImpresionNormal
            // 
            this.btnImpresionNormal.BackColor = System.Drawing.Color.White;
            this.btnImpresionNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresionNormal.Location = new System.Drawing.Point(12, 12);
            this.btnImpresionNormal.Name = "btnImpresionNormal";
            this.btnImpresionNormal.Size = new System.Drawing.Size(123, 23);
            this.btnImpresionNormal.TabIndex = 3;
            this.btnImpresionNormal.Text = "Normal";
            this.btnImpresionNormal.UseVisualStyleBackColor = false;
            this.btnImpresionNormal.Click += new System.EventHandler(this.btnImpresionNormal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(892, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // webKitBrowser1
            // 
            //this.webKitBrowser1.BackColor = System.Drawing.Color.White;
            //this.webKitBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.webKitBrowser1.Location = new System.Drawing.Point(0, 0);
            //this.webKitBrowser1.Name = "webKitBrowser1";
            //this.webKitBrowser1.Size = new System.Drawing.Size(1018, 744);
            //this.webKitBrowser1.TabIndex = 0;
            //this.webKitBrowser1.Url = null;
            // 
            // frmVisualizaPDF
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1018, 744);
          //  this.Controls.Add(this.webKitBrowser1);
            this.Name = "frmVisualizaPDF";
            this.Text = "Visualizador PDF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

    }
  }
}
