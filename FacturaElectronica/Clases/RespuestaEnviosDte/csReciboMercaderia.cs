﻿ 
// Type: Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte.csReciboMercaderia
 
 
// version 1.8.0

using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte
{
  [XmlRoot(ElementName = "EnvioRecibos")]
  public class csReciboMercaderia
  {
    private string _rutaElectronica = "";
    private csResultado _Resultado = new csResultado();

    public csResultado SetRecibos
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

    public string Serializar()
    {
      this.CargaRuta();
      string str = "reciboMercaderia";
      this.NormalizarDocumento();
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      XmlWriterSettings settings = new XmlWriterSettings();
      settings.Encoding = Encoding.GetEncoding("ISO-8859-1");
      settings.Indent = true;
      XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
      XmlWriter xmlWriter = XmlWriter.Create(this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\" + str + ".XML", settings);
      xmlSerializer.Serialize(xmlWriter, (object) this, namespaces);
      xmlWriter.Close();
      return (string) null;
    }

    private void NormalizarDocumento()
    {
      if (string.IsNullOrEmpty(this.version))
        this.version = "1.0";
      if (!string.IsNullOrEmpty(this.SetRecibos.ID))
        return;
      this.SetRecibos.ID = "RespuestaDTE_1";
    }
  }
}
