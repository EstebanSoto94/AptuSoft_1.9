using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptusoft.FacturaElectronica.Formularios
{
    public partial class frmManuales : Form
    {
        private string _rutaElectronica = "";
        private string _archivo = "";
        private int _tipo = 0;
        private AxAcroPDF axAcroPDF1;
        public frmManuales()
        {
            InitializeComponent();
        }
        void CargaRuta()
        {
            try
            {
                DataSet dataSet = new DataSet("datos");
                int num = (int)dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
                string filterExpression = "principal=1";
                DataRow[] dataRowArray = dataSet.Tables["conexion"].Select(filterExpression);
                string str = "";
                for (int index = 0; index < dataRowArray.Length; ++index)
                    str = dataRowArray[index]["rutaElectronica"].ToString();
                this._rutaElectronica = str.Replace("\\", "\\\\") + "\\\\";
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Cargar Ruta " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public frmManuales(string archivo, int tipo)
    {
        CargaRuta();
            this._tipo = tipo;
      if (tipo == 33)
      {
        this._archivo = archivo;
        archivo = "EFactura_" + archivo;
      }
      else if (tipo == 34)
      {
        this._archivo = archivo;
        archivo = "EFacturaExenta_" + archivo;
      }
      else if (tipo == 52)
      {
        this._archivo = archivo;
        archivo = "EGuia_" + archivo;
      }
      this.visualizaPdf(archivo, tipo);
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
      string temp = str + archivo + ".pdf";
      Uri r = new Uri(temp);
      Uri d = new Uri(@"file:///C://AptuSoft//Electronica//PDF/E-Factura/EFactura_1.pdf");
      //this.axAcroPDF1.LoadFile(str + archivo + ".pdf");
      cargar_pdf(d.ToString());
        

    }
    void cargar_pdf(string url)
    {
        Process p = new Process();
        //p.ProcessName("manuales Aptusoft");
        p.StartInfo.Arguments = url;
        p.Start();
        //webBrowser1.Url = new Uri(url);
    }

    }

}
