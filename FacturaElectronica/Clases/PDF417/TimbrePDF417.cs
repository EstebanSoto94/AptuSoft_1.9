 
// Type: Aptusoft.FacturaElectronica.Clases.PDF417.TimbrePDF417
 
 
// version 1.8.0

using System;
using System.Data;
using System.Windows.Forms;

namespace Aptusoft.FacturaElectronica.Clases.PDF417
{
  public class TimbrePDF417
  {
    private string _rutaElectronica = "";

    public void creaPDF417(string timbre)
    {
      this.CargaRuta();
      new CodigoPDF417().creaPdf417(timbre).Save(this._rutaElectronica + "pdf417.bmp");
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
  }
}
