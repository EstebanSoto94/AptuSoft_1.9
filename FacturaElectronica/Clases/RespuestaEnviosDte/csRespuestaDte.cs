 
// Type: Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte.csRespuestaDte
 
 
// version 1.8.0

using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte
{
  [XmlRoot(ElementName = "RespuestaDTE")]
  public class csRespuestaDte
  {
    private string _rutaElectronica = "";
    private csResultado _Resultado = new csResultado();

    public csResultado Resultado
    {
      get
      {
        return this._Resultado;
      }
      set
      {
        this._Resultado = value;
      }
    }

    [XmlAttribute("version")]
    public string version { get; set; }

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

    public string Serializar(string tipoOperacion)
    {
      this.CargaRuta();
      string str1 = "";
      if (tipoOperacion.Equals("ACUSE_RECIBO"))
        str1 = "acuse_recibo";
      if (tipoOperacion.Equals("RESULTADO_APROBACION"))
        str1 = "resultado";
      this.NormalizarDocumento();
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      XmlWriterSettings settings = new XmlWriterSettings();
      settings.Encoding = Encoding.GetEncoding("ISO-8859-1");
      settings.Indent = true;
      XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
      string str2 = "";
      if (tipoOperacion.Equals("ACUSE_RECIBO"))
        str2 = this._rutaElectronica + "RESPUESTAS\\1_ACUSE_RECIBO\\";
      if (tipoOperacion.Equals("RESULTADO_APROBACION"))
        str2 = this._rutaElectronica + "RESPUESTAS\\3_RESULTADO\\";
      XmlWriter xmlWriter = XmlWriter.Create(str2 + str1 + ".XML", settings);
      xmlSerializer.Serialize(xmlWriter, (object) this, namespaces);
      xmlWriter.Close();
      return (string) null;
    }

    private void NormalizarDocumento()
    {
      if (string.IsNullOrEmpty(this.version))
        this.version = "1.0";
      if (!string.IsNullOrEmpty(this.Resultado.ID))
        return;
      this.Resultado.ID = "RespuestaDTE_1";
    }
  }
}
