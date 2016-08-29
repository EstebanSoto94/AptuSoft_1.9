 
// Type: Aptusoft.LeeXml
 
 
// version 1.8.0

using System;
using System.Collections;
using System.Data;
using System.Xml;

namespace Aptusoft
{
  public class LeeXml
  {
    public string cargarDatos(string documento)
    {
      string str;
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        str = dataSet.Tables["impresoras"].Rows[0][documento].ToString();
      }
      catch (Exception ex)
      {
        return "No hay registros, Ingrese Datos En [OPCIONES - Impresoras] " + ex.Message;
      }
      return str;
    }

    public ArrayList cargarDatosMultiEmpresa(string documento)
    {
      ArrayList arrayList = new ArrayList();
      string str1 = "";
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        string str2 = dataSet.Tables["impresoras"].Rows[0][documento].ToString();
        string filterExpression = "principal=1";
        foreach (DataRow dataRow in dataSet.Tables["Conexion"].Select(filterExpression))
          str1 = dataRow["empresa"].ToString();
        arrayList.Add((object) str2);
        arrayList.Add((object) str1);
      }
      catch (Exception ex)
      {
        arrayList.Add((object) ("No hay registros, Ingrese Datos En [OPCIONES - Impresoras] " + ex.Message));
      }
      return arrayList;
    }
   public string getRut()
    {
        String rut = "";
        string multi = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        XmlDocument xd = new XmlDocument();
        xd.Load(@"C:\AptuSoft\Electronica\Archivos\SetDte_"+multi+".xml");
        XmlNodeList nodelist = xd.SelectNodes("EnvioDTE/SetDTE/Caratula"); // get all <testcase> nodes

        foreach (XmlNode node in nodelist) // for each <testcase> node
        {
            if (node.SelectSingleNode("RutEmisor").InnerText.Length != 0)
            {
                try
                {
                   rut  = node.SelectSingleNode("RutEmisor").InnerText;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error in reading XML", "xmlError", MessageBoxButtons.OK);
                }
            }
        }
        return rut;
    }
    public string cargarDatosOtrosDocumentos()
    {
      string str;
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        str = dataSet.Tables["impresoras"].Rows[0]["otros"].ToString();
        dataSet.Clear();
      }
      catch (Exception ex)
      {
        return "No hay registros, Ingrese Datos En [OPCIONES - Impresoras] " + ex.Message;
      }
      return str;
    }


    public string leeEstadoImpresoraFiscal()
    {
      string str;
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        str = dataSet.Tables["EstadoImpresionFiscal"].Rows[0]["estado"].ToString() + "-" + dataSet.Tables["EstadoImpresionFiscal"].Rows[0]["folio"].ToString();
      }
      catch (Exception ex)
      {
        return "No hay registros de Estado " + ex.Message;
      }
      return str;
    }

    public void cambiaEstadoImpresoraFiscal(string estado, string folio)
    {
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        dataSet.Tables["EstadoImpresionFiscal"].Rows[0]["estado"] = (object) estado;
        dataSet.Tables["EstadoImpresionFiscal"].Rows[0]["folio"] = (object) folio;
        dataSet.WriteXml("C:\\AptuSoft\\xml\\config.xml");
      }
      catch
      {
      }
    }
  }
}
