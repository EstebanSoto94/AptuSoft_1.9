 
// Type: Aptusoft.FacturaElectronica.Clases.csCreaPDF
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class csCreaPDF
  {
    private string _rutaElectronica = "";

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

    private void verificaDirectorio(int tipoDoc)
    {
      string path = "";
      if (tipoDoc == 33)
        path = this._rutaElectronica + "PDF\\E-Factura\\";
      if (tipoDoc == 34)
        path = this._rutaElectronica + "PDF\\E-FacturaExenta\\";
      if (tipoDoc == 39)
        path = this._rutaElectronica + "PDF\\E-Boleta\\";
      if (tipoDoc == 61)
        path = this._rutaElectronica + "PDF\\E-NotaCredito\\";
      if (tipoDoc == 56)
        path = this._rutaElectronica + "PDF\\E-NotaDebito\\";
      if (tipoDoc == 52)
        path = this._rutaElectronica + "PDF\\E-Guia\\";
      if (Directory.Exists(path))
        return;
      Directory.CreateDirectory(path);
    }

    public void creaPDF(string archivoRpt, string nombre_archivo, int tipoDoc, DataTable dt)
    {
      try
      {
        this.CargaRuta();
        this.verificaDirectorio(tipoDoc);
        ReportDocument reportDocument = new ReportDocument();
        reportDocument.Load("C:\\AptuSoft\\reportes\\" + archivoRpt);
        reportDocument.SetDataSource(dt);
        DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
        PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
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
        destinationOptions.DiskFileName = str + nombre_archivo + ".pdf";
        ExportOptions exportOptions = reportDocument.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument.Export();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message , "Error Al Crear PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
