 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csGeneraXMLLibroBoletas
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csGeneraXMLLibroBoletas
  {
      private string multi = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      private string impresora = new LeeXml().cargarDatosMultiEmpresa("factura")[0].ToString();
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

    public string creaXMLlibroBoletas(string periodo, string tipoLibro, string tipoEnvio, int folioNotificacion, List<csTotalesPeriodoBoletas> listaResumenPeriodo, List<csDetalleLibroBoletas> listaDetalle, string codigoAutorizacion)
    {
      this.CargaRuta();
      csLibroBoletas csLibroBoletas = new csLibroBoletas();
      EmisorVO emisorVo = new Emisor().buscaEmisor();
      csLibroBoletas.EnvioLibro.Caratula.RutEmisorLibro = emisorVo.RutEmisior;
      csLibroBoletas.EnvioLibro.Caratula.RutEnvia = emisorVo.RutCertificado;
      csLibroBoletas.EnvioLibro.Caratula.PeriodoTributario = periodo;
      string str = emisorVo.FechaResolucion.Substring(6, 4) + "-" + emisorVo.FechaResolucion.Substring(3, 2) + "-" + emisorVo.FechaResolucion.Substring(0, 2);
      csLibroBoletas.EnvioLibro.Caratula.FchResol = str;
      csLibroBoletas.EnvioLibro.Caratula.NroResol = Convert.ToInt32(emisorVo.NumeroResolucion);
      csLibroBoletas.EnvioLibro.Caratula.TipoOperacion = "";
      csLibroBoletas.EnvioLibro.Caratula.TipoLibro = tipoLibro;
      csLibroBoletas.EnvioLibro.Caratula.TipoEnvio = tipoEnvio;
      csLibroBoletas.EnvioLibro.Caratula.FolioNotificacion = folioNotificacion;
      csLibroBoletas.EnvioLibro.Caratula.CodAutRec = codigoAutorizacion;
      csTotalesPeriodoBoletas totalesPeriodoBoletas = new csTotalesPeriodoBoletas();
      csLibroBoletas.EnvioLibro.ResumenPeriodo = new csResumenPeriodoBoleta();
      for (int index = 0; index < listaResumenPeriodo.Count; ++index)
      {
        if (listaResumenPeriodo[index].TpoDoc == 39)
        {
          csLibroBoletas.EnvioLibro.ResumenPeriodo.TotalesPeriodo = new csTotalesPeriodoBoletas();
          csLibroBoletas.EnvioLibro.ResumenPeriodo.TotalesPeriodo = new csTotalesPeriodoBoletas()
          {
            TpoDoc = listaResumenPeriodo[index].TpoDoc,
            TotalesServicio = listaResumenPeriodo[index].TotalesServicio
          };
        }
        if (listaResumenPeriodo[index].TpoDoc == 41)
        {
          csLibroBoletas.EnvioLibro.ResumenPeriodo.TotalesPeriodo = new csTotalesPeriodoBoletas();
          csLibroBoletas.EnvioLibro.ResumenPeriodo.TotalesPeriodo = new csTotalesPeriodoBoletas()
          {
            TpoDoc = listaResumenPeriodo[index].TpoDoc,
            TotalesServicio = listaResumenPeriodo[index].TotalesServicio
          };
        }
      }
      csLibroBoletas.EnvioLibro.Detalles = new List<csDetalleLibroBoletas>();
      foreach (csDetalleLibroBoletas detalleLibroBoletas in listaDetalle)
        csLibroBoletas.EnvioLibro.Detalles.Add(detalleLibroBoletas);
      csLibroBoletas.Serializar();
      this.quitarIdentacion();
      this.agregaSETLibro();
      return this.firmaLibro();
    }

    private void quitarIdentacion()
    {
      string uri = this._rutaElectronica + "LIBROS\\BOLETAS\\libro1.XML";
      string fileName = uri;
      XDocument xdocument1 = XDocument.Load(uri);
      xdocument1.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
      string[] strArray = xdocument1.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      for (int index = 0; index <= strArray.Length - 1; ++index)
      {
         // if (strArray[index] == "        <TotAnulado>0</TotAnulado>" || strArray[index] == "<TotAnulado>0</TotAnulado>") { strArray[index].Remove(index); }

          strArray[index] = strArray[index].TrimStart();
      }
      XDocument xdocument2 = XDocument.Parse(string.Join("\r\n", strArray), LoadOptions.PreserveWhitespace);
      xdocument2.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
      xdocument2.Save(fileName);
    }

    private void agregaSETLibro()
    {
      string str = "";
      string filename1 = this._rutaElectronica + "Archivos\\SETLIBROBOLETA_"+multi+".XML";
      string filename2 = this._rutaElectronica + "LIBROS\\BOLETAS\\libro1.XML";
      str = this._rutaElectronica + "LIBROS\\BOLETAS\\libro1_resultado.XML";
      XmlDocument xmlDocument1 = new XmlDocument();
      xmlDocument1.PreserveWhitespace = true;
//      xmlDocument1.Load(filename1);
      XmlElement documentElement = xmlDocument1.DocumentElement;
      XmlDocument xmlDocument2 = new XmlDocument();
      xmlDocument2.PreserveWhitespace = true;
      xmlDocument2.Load(filename2);
      XmlElement xmlElement = (XmlElement) xmlDocument2.SelectSingleNode("LibroBoleta/EnvioLibro");
//      documentElement.AppendChild(xmlDocument1.ImportNode((XmlNode) xmlElement, true));
//      xmlDocument1.Save(filename2);
    }

    public string firmaLibro()
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string uriSchema = this._rutaElectronica + "Archivos\\Schemas\\LibroVentaCompra\\LibroBOLETA_v10.xsd";
      string certificadoDigital = new Emisor().buscaEmisor().CertificadoDigital;
      DateTime now = DateTime.Now;
      string str1 = now.ToString().Replace("/", "-").Replace(":", "_");
      string str2 = this._rutaElectronica + "LIBROS\\BOLETAS\\libro1.XML";
      string filename = this._rutaElectronica + "LIBROS\\BOLETAS\\LibroBoletasEnvio_" + str1 +"_"+multi+ ".XML";
      string str3 = "LibroBoletasEnvio_" + str1 + "_" + multi + ".XML";
      string CN = certificadoDigital;
      List<string> list1 = new List<string>();
      string str4 = "Libro_1234";
      XmlDocument xmldocument = new XmlDocument();
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str2);
      list1.Clear();
      List<string> list2 = FuncionesComunes.ValidarSchema(str2, uriSchema);
      if (list2.Count > 0)
      {
        int num1 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml DTE");
        int num2;
        list2.ForEach((Action<string>) (es => num2 = (int) MessageBox.Show(es)));
        int num3 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml");
      }
      XmlElement xmlElement1 = (XmlElement) xmldocument.SelectSingleNode("LibroBoleta/EnvioLibro/TmstFirma");
      if (xmlElement1 == null)
        throw new Exception("No se encuentra el nodo TmstFirma");
      XmlElement xmlElement2 = xmlElement1;
      now = DateTime.Now;
      string str5 = now.ToString("yyyy-MM-ddTHH:mm:ss");
      xmlElement2.InnerText = str5;
      xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
      xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
      xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte LibroBOLETA_v10.xsd");
      xmldocument.Save(filename);
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(filename);
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
      if (certificado == null)
        throw new Exception("No se encuentra el certificado para poder firmar ls documentos");
      string referenciaUri = string.Format("#{0}", (object) str4);
      FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
      xmldocument.Save(filename);
      return str3;
    }
  }
}
