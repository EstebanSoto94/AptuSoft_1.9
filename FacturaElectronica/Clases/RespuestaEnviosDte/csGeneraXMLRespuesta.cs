 
// Type: Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte.csGeneraXMLRespuesta
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace Aptusoft.FacturaElectronica.Clases.RespuestaEnviosDte
{
  public class csGeneraXMLRespuesta
  {
      string multiEmpresa = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
    private string _rutaElectronica = "";

    private void CargaRuta()
    {
      try
      {
        DataSet dataSet = new DataSet("datos");
        int num = (int) dataSet.ReadXml(@"C:\AptuSoft\xml\config.xml");
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

    public void creaXMLRespuesta(csRespuestaVO reVO, List<csRecepcionEnvioDTE> listaRecepcionDte, string tipo)
    {
      this.CargaRuta();
      csRespuestaDte csRespuestaDte = new csRespuestaDte();
      csRespuestaDte.Resultado.Caratula.version = "1.0";
      csRespuestaDte.Resultado.Caratula.RutResponde = reVO.RutResponde;
      csRespuestaDte.Resultado.Caratula.RutRecibe = reVO.RutRecibe;
      csRespuestaDte.Resultado.Caratula.IdRespuesta = 1;
      csRespuestaDte.Resultado.Caratula.NroDetalles = 1;
      csRespuestaDte.Resultado.Caratula.TmstFirmaResp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
      if (tipo.Equals("ACUSE_RECIBO"))
      {
        csRespuestaDte.Resultado.RecepcionEnvio = new csRecepcionEnvio();
        csRespuestaDte.Resultado.RecepcionEnvio.NmbEnvio = reVO.Archivo;
        csRespuestaDte.Resultado.RecepcionEnvio.FchRecep = reVO.FechaRecepcionEnvio.ToString("yyyy-MM-ddTHH:mm:ss");
        csRespuestaDte.Resultado.RecepcionEnvio.CodEnvio = reVO.CodigoEnvio;
        csRespuestaDte.Resultado.RecepcionEnvio.EnvioDTEID = reVO.IdDte;
        csRespuestaDte.Resultado.RecepcionEnvio.Digest = reVO.DigestValue;
        csRespuestaDte.Resultado.RecepcionEnvio.RutEmisor = reVO.RutRecibe;
        csRespuestaDte.Resultado.RecepcionEnvio.RutReceptor = reVO.RutResponde;
        csRespuestaDte.Resultado.RecepcionEnvio.EstadoRecepEnv = reVO.CodigoEstadoRecepcion;
        csRespuestaDte.Resultado.RecepcionEnvio.RecepEnvGlosa = reVO.GlosaEstadoRecepcion;
        csRespuestaDte.Resultado.RecepcionEnvio.NroDTE = reVO.NroDte;
        csRespuestaDte.Resultado.RecepcionEnvio.RecepcionDTE = new List<csRecepcionDTE>();
        csRecepcionDTE csRecepcionDte = new csRecepcionDTE();
        foreach (csRecepcionEnvioDTE recepcionEnvioDte in listaRecepcionDte)
          csRespuestaDte.Resultado.RecepcionEnvio.RecepcionDTE.Add(new csRecepcionDTE()
          {
            TipoDTE = recepcionEnvioDte.TipoDTE,
            Folio = recepcionEnvioDte.Folio,
            FchEmis = recepcionEnvioDte.FchEmis.ToString("yyyy-MM-dd"),
            RUTEmisor = recepcionEnvioDte.RUTEmisor,
            RUTRecep = recepcionEnvioDte.RUTRecep,
            MntTotal = recepcionEnvioDte.MntTotal,
            EstadoRecepDTE = recepcionEnvioDte.EstadoRecepDTE,
            RecepDTEGlosa = recepcionEnvioDte.RecepDTEGlosa
          });
      }
      if (tipo.Equals("RESULTADO_APROBACION"))
      {
        csRespuestaDte.Resultado.ResultadoDTE = new List<csResultadoDTE>();
        csResultadoDTE csResultadoDte = new csResultadoDTE();
        foreach (csRecepcionEnvioDTE recepcionEnvioDte in listaRecepcionDte)
          csRespuestaDte.Resultado.ResultadoDTE.Add(new csResultadoDTE()
          {
            TipoDTE = recepcionEnvioDte.TipoDTE,
            Folio = recepcionEnvioDte.Folio,
            FchEmis = recepcionEnvioDte.FchEmis.ToString("yyyy-MM-dd"),
            RUTEmisor = recepcionEnvioDte.RUTEmisor,
            RUTRecep = recepcionEnvioDte.RUTRecep,
            MntTotal = recepcionEnvioDte.MntTotal,
            CodEnvio = reVO.CodigoEnvio,
            EstadoDTE = recepcionEnvioDte.EstadoDTE,
            EstadoDTEGlosa = recepcionEnvioDte.EstadoDTEGlosa
          });
      }
      csRespuestaDte.Serializar(tipo);
      this.quitarIdentacion(tipo);
      this.estableceEncoding(tipo);
      this.firmaRespuesta(tipo, reVO.RutRecibe);
      this.eliminaArchivoTemporal(tipo);
    }

    private void quitarIdentacion(string tipo)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string uri = "";
      if (tipo.Equals("ACUSE_RECIBO"))
        uri = this._rutaElectronica + "RESPUESTAS\\1_ACUSE_RECIBO\\acuse_recibo.XML";
      if (tipo.Equals("RESULTADO_APROBACION"))
        uri = this._rutaElectronica + "RESPUESTAS\\3_RESULTADO\\resultado.XML";
      if (tipo.Equals("RECIBO_MERCADERIA"))
        uri = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\reciboMercaderia.XML";
      string fileName = uri;
      XDocument xdocument1 = XDocument.Load(uri);
      xdocument1.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
      string[] strArray = xdocument1.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      for (int index = 0; index <= strArray.Length - 1; ++index)
        strArray[index] = strArray[index].TrimStart();
      XDocument xdocument2 = XDocument.Parse(string.Join("\r\n", strArray), LoadOptions.PreserveWhitespace);
      xdocument2.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
      xdocument2.Save(fileName);
    }

    private void estableceEncoding(string tipo)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      try
      {
        string filename = "";
        if (tipo.Equals("ACUSE_RECIBO"))
          filename = this._rutaElectronica + "RESPUESTAS\\1_ACUSE_RECIBO\\acuse_recibo.XML";
        if (tipo.Equals("RESULTADO_APROBACION"))
          filename = this._rutaElectronica + "RESPUESTAS\\3_RESULTADO\\resultado.XML";
        if (tipo.Equals("RECIBO_MERCADERIA"))
          filename = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\reciboMercaderia.XML";
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.PreserveWhitespace = true;
        xmlDocument.Load(filename);
        if (xmlDocument.FirstChild.NodeType != XmlNodeType.XmlDeclaration)
          return;
        ((XmlDeclaration) xmlDocument.FirstChild).Encoding = "ISO-8859-1";
        xmlDocument.Save(filename);
      }
      catch (XmlException ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      catch (Exception ex)
      {
        Console.WriteLine("{0}", (object) ex.Message);
      }
    }

    public void firmaRespuesta(string tipo, string rutProveedor)
    {

      string str1 = "";
      string str2 = "";
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string uriSchema = !tipo.Equals("RECIBO_MERCADERIA") ? this._rutaElectronica + @"Archivos\Schemas\RespuestaEnvio\RespuestaEnvioDTE_v10.xsd" : this._rutaElectronica + @"Archivos\Schemas\RespuestaEnvio\Recibos\EnvioRecibos_v10.xsd";
      string certificadoDigital = new Emisor().buscaEmisor().CertificadoDigital;
      string str3 = DateTime.Now.ToShortDateString().Replace("/", "").Replace(":", "").Replace("-", "");
      if (tipo.Equals("ACUSE_RECIBO"))
      {
        str1 = this._rutaElectronica + @"RESPUESTAS\1_ACUSE_RECIBO\acuse_recibo.XML";
        str2 = this._rutaElectronica + @"RESPUESTAS\1_ACUSE_RECIBO\acuse_recibo_" + rutProveedor + "_" + multiEmpresa + "_" + str3 + ".XML";
      }
      if (tipo.Equals("RESULTADO_APROBACION"))
      {
        str1 = this._rutaElectronica + @"RESPUESTAS\3_RESULTADO\resultado.XML";
        str2 = this._rutaElectronica + @"RESPUESTAS\3_RESULTADO\resultado_" + rutProveedor + "_" + multiEmpresa + "_" + str3 + ".XML";
      }
      if (tipo.Equals("RECIBO_MERCADERIA"))
      {
        str1 = this._rutaElectronica + @"RESPUESTAS\2_RECIBO_MERCADERIA\reciboMercaderia.XML";
        str2 = this._rutaElectronica + @"RESPUESTAS\2_RECIBO_MERCADERIA\reciboMercaderia_" + rutProveedor + "_" + multiEmpresa + "_" + str3 + ".XML";
      }
      string CN = certificadoDigital;
      List<string> list1 = new List<string>();
      string str4 = "RespuestaDTE_1";
      XmlDocument xmldocument = new XmlDocument();
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str1);
      list1.Clear();
      List<string> list2 = FuncionesComunes.ValidarSchema(str1, uriSchema);
      if (list2.Count > 0)
      {
        int num1 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml DTE");
        int num2;
        list2.ForEach((Action<string>) (es => num2 = (int) MessageBox.Show(es)));
        int num3 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml");
      }
      if (tipo.Equals("RECIBO_MERCADERIA"))
      {
        XmlElement xmlElement = (XmlElement) xmldocument.SelectSingleNode("EnvioRecibos/SetRecibos/Caratula/TmstFirmaEnv");
        if (xmlElement == null)
          throw new Exception("No se encuentra el nodo TmstFirmaEnv");
        xmlElement.InnerText = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
        xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
        xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte EnvioRecibos_v10.xsd");
      }
      else
      {
        XmlElement xmlElement = (XmlElement) xmldocument.SelectSingleNode("RespuestaDTE/Resultado/Caratula/TmstFirmaResp");
        if (xmlElement == null)
          throw new Exception("No se encuentra el nodo TmstFirmaResp");
        xmlElement.InnerText = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
        xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
        xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte RespuestaEnvioDTE_v10.xsd");
      }
      xmldocument.Save(str2);
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str2);
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
      if (certificado == null)
        throw new Exception("No se encuentra el certificado para poder firmar ls documentos");
      string referenciaUri = string.Format("#{0}", (object) str4);
      FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
      xmldocument.Save(str2);
      list2.Clear();
      List<string> list3 = FuncionesComunes.ValidarSchema(str2, uriSchema);
      if (list3.Count <= 0)
        return;
      int num4 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml (DTE)");
      int num5;
      list3.ForEach((Action<string>) (es => num5 = (int) MessageBox.Show(es)));
      int num6 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml.");
    }

    private void eliminaArchivoTemporal(string tipo)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string path = "";
      if (tipo.Equals("ACUSE_RECIBO"))
        path = this._rutaElectronica + "RESPUESTAS\\1_ACUSE_RECIBO\\acuse_recibo.XML";
      if (tipo.Equals("RESULTADO_APROBACION"))
        path = this._rutaElectronica + "RESPUESTAS\\3_RESULTADO\\resultado.XML";
      if (tipo.Equals("RECIBO_MERCADERIA"))
        path = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\reciboMercaderia.XML";
      if (!File.Exists(path))
        return;
      try
      {
        File.Delete(path);
      }
      catch (IOException ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    public void creaXMLEnvioRecibo(csRespuestaVO reVO, List<csRecepcionEnvioDTE> lista)
    {
      new csReciboMercaderia()
      {
        SetRecibos = {
          Caratula = {
            version = "1.0",
            RutResponde = reVO.RutResponde,
            RutRecibe = reVO.RutRecibe,
            TmstFirmaEnv = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
          }
        }
      }.Serializar();
      string tipo = "RECIBO_MERCADERIA";
      this.quitarIdentacion(tipo);
      this.estableceEncoding(tipo);
      foreach (csRecepcionEnvioDTE reDTE in lista)
        this.creaXMLRecibo(reDTE);
      this.firmaRespuesta(tipo, reVO.RutRecibe);
      this.eliminaArchivoTemporal(tipo);
    }

    private void creaXMLRecibo(csRecepcionEnvioDTE reDTE)
    {
      csRecibo csRecibo = new csRecibo();
      string rutCertificado = new Emisor().buscaEmisor().RutCertificado;
      string str1 = "El acuse de recibo que se declara en este acto, de acuerdo a lo dispuesto en la letra b) del Art. 4, y la letra c) del Art. 5 de la Ley 19.983, acredita que la entrega de mercaderias o servicio(s) prestado(s) ha(n) sido recibido(s).";
      string idDoc = "R" + reDTE.RUTEmisor + "T" + reDTE.TipoDTE + "F" + reDTE.Folio;
      csRecibo.DocumentoRecibo.ID = idDoc;
      csRecibo.DocumentoRecibo.TipoDoc = reDTE.TipoDTE;
      csRecibo.DocumentoRecibo.Folio = reDTE.Folio;
      csRecibo.DocumentoRecibo.FchEmis = reDTE.FchEmis.ToString("yyyy-MM-dd");
      csRecibo.DocumentoRecibo.RUTEmisor = reDTE.RUTEmisor;
      csRecibo.DocumentoRecibo.RUTRecep = reDTE.RUTRecep;
      csRecibo.DocumentoRecibo.MntTotal = reDTE.MntTotal;
      csRecibo.DocumentoRecibo.Recinto = "SANTIAGO";
      csRecibo.DocumentoRecibo.RutFirma = rutCertificado;
      csRecibo.DocumentoRecibo.Declaracion = str1;
      csRecibo.DocumentoRecibo.TmstFirmaRecibo = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
      string str2 = reDTE.RUTEmisor + "_" + reDTE.TipoDTE + "_" + reDTE.Folio;
      csRecibo.Serializar(str2);
      this.quitarIdentacionRecibo("recibo_" + str2);
      this.estableceEncodingRecibo("recibo_" + str2);
      this.firmaRecibo(str2, idDoc);
      this.agregaReciboASETrecibo(str2);
      this.eliminaArchivoTemporalRecibo(str2);
    }

    private void eliminaArchivoTemporalRecibo(string archivo)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string path = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\recibo_" + archivo + ".XML";
      if (!File.Exists(path))
        return;
      try
      {
        File.Delete(path);
      }
      catch (IOException ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void quitarIdentacionRecibo(string archivo)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string uri = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\" + archivo + ".XML";
      string fileName = uri;
      XDocument xdocument1 = XDocument.Load(uri);
      xdocument1.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
      string[] strArray = xdocument1.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      for (int index = 0; index <= strArray.Length - 1; ++index)
        strArray[index] = strArray[index].TrimStart();
      XDocument xdocument2 = XDocument.Parse(string.Join("\r\n", strArray), LoadOptions.PreserveWhitespace);
      xdocument2.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
      xdocument2.Save(fileName);
    }

    private void estableceEncodingRecibo(string archivo)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      try
      {
        string filename = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\" + archivo + ".XML";
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.PreserveWhitespace = true;
        xmlDocument.Load(filename);
        if (xmlDocument.FirstChild.NodeType != XmlNodeType.XmlDeclaration)
          return;
        ((XmlDeclaration) xmlDocument.FirstChild).Encoding = "ISO-8859-1";
        xmlDocument.Save(filename);
      }
      catch (XmlException ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      catch (Exception ex)
      {
        Console.WriteLine("{0}", (object) ex.Message);
      }
    }

    public void firmaRecibo(string archivo, string idDoc)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string uriSchema = this._rutaElectronica + "Archivos\\Schemas\\RespuestaEnvio\\Recibos\\Recibos_v10.xsd";
      string certificadoDigital = new Emisor().buscaEmisor().CertificadoDigital;
      DateTime now = DateTime.Now;
      now.ToString().Replace("/", "-").Replace(":", "_");
      string str1 = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\recibo_" + archivo + ".XML";
      string str2 = str1;
      string CN = certificadoDigital;
      List<string> list1 = new List<string>();
      string str3 = idDoc;
      XmlDocument xmldocument = new XmlDocument();
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str1);
      list1.Clear();
      List<string> list2 = FuncionesComunes.ValidarSchema(str1, uriSchema);
      if (list2.Count > 0)
      {
        int num1 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml DTE");
        int num2;
        list2.ForEach((Action<string>) (es => num2 = (int) MessageBox.Show(es)));
        int num3 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml");
      }
      XmlElement xmlElement1 = (XmlElement) xmldocument.SelectSingleNode("Recibo/DocumentoRecibo/TmstFirmaRecibo");
      if (xmlElement1 == null)
        throw new Exception("No se encuentra el nodo TmstFirmaRecibo");
      XmlElement xmlElement2 = xmlElement1;
      now = DateTime.Now;
      string str4 = now.ToString("yyyy-MM-ddTHH:mm:ss");
      xmlElement2.InnerText = str4;
      xmldocument.Save(str2);
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str2);
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
      if (certificado == null)
        throw new Exception("No se encuentra el certificado para poder firmar ls documentos");
      string referenciaUri = string.Format("#{0}", (object) str3);
      FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
      xmldocument.Save(str2);
      list2.Clear();
      List<string> list3 = FuncionesComunes.ValidarSchema(str2, uriSchema);
      if (list3.Count <= 0)
        return;
      int num4 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml (DTE)");
      int num5;
      list3.ForEach((Action<string>) (es => num5 = (int) MessageBox.Show(es)));
      int num6 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml.");
    }

    public void agregaReciboASETrecibo(string archivo)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string filename1 = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\reciboMercaderia.XML";
      string filename2 = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\recibo_" + archivo + ".XML";
      string filename3 = this._rutaElectronica + "RESPUESTAS\\2_RECIBO_MERCADERIA\\reciboMercaderia.XML";
      XmlDocument xmlDocument1 = new XmlDocument();
      xmlDocument1.PreserveWhitespace = true;
      xmlDocument1.Load(filename1);
      XmlElement xmlElement = (XmlElement) xmlDocument1.SelectSingleNode("EnvioRecibos/SetRecibos");
      XmlDocument xmlDocument2 = new XmlDocument();
      xmlDocument2.PreserveWhitespace = true;
      xmlDocument2.Load(filename2);
      XmlElement documentElement = xmlDocument2.DocumentElement;
      xmlElement.AppendChild(xmlDocument1.ImportNode((XmlNode) documentElement, true));
      xmlDocument1.Save(filename3);
    }
  }
}
