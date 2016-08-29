 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csGeneraXMLlibroCompraVenta
 
 
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
  public class csGeneraXMLlibroCompraVenta
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

    public string creaXMLlibroCompraVenta(string periodo, string tipoOperacion, string tipoLibro, string tipoEnvio, int folioNotificacion, List<TotalesPeriodo> listaResumenPeriodo, List<csDetalleLibro> listaDetalle, string codigoAutorizacion)
    {
      this.CargaRuta();
      csLibroCompraVenta libroCompraVenta = new csLibroCompraVenta();
      EmisorVO emisorVo = new Emisor().buscaEmisor();
      libroCompraVenta.EnvioLibro.Caratula.RutEmisorLibro = emisorVo.RutEmisior;
      libroCompraVenta.EnvioLibro.Caratula.RutEnvia = emisorVo.RutCertificado;
      libroCompraVenta.EnvioLibro.Caratula.PeriodoTributario = periodo;
      string str = emisorVo.FechaResolucion.Substring(6, 4) + "-" + emisorVo.FechaResolucion.Substring(3, 2) + "-" + emisorVo.FechaResolucion.Substring(0, 2);
      libroCompraVenta.EnvioLibro.Caratula.FchResol = str;
      libroCompraVenta.EnvioLibro.Caratula.NroResol = Convert.ToInt32(emisorVo.NumeroResolucion);
      libroCompraVenta.EnvioLibro.Caratula.TipoOperacion = tipoOperacion;
      libroCompraVenta.EnvioLibro.Caratula.TipoLibro = tipoLibro;
      libroCompraVenta.EnvioLibro.Caratula.TipoEnvio = tipoEnvio;
      libroCompraVenta.EnvioLibro.Caratula.FolioNotificacion = folioNotificacion;
      libroCompraVenta.EnvioLibro.Caratula.CodAutRec = codigoAutorizacion;
      TotalesPeriodo totalesPeriodo = new TotalesPeriodo();
      libroCompraVenta.EnvioLibro.ResumenPeriodo = new List<TotalesPeriodo>();
      for (int index = 0; index < listaResumenPeriodo.Count; ++index)
              libroCompraVenta.EnvioLibro.ResumenPeriodo.Add(new TotalesPeriodo()
              {
                  TpoDoc = listaResumenPeriodo[index].TpoDoc,
                  TpoImp = listaResumenPeriodo[index].TpoImp,
                  TotDoc = listaResumenPeriodo[index].TotDoc,
                  TotOpExe = listaResumenPeriodo[index].TotOpExe,
                  TotMntExe = listaResumenPeriodo[index].TotMntExe,
                  TotMntNeto = listaResumenPeriodo[index].TotMntNeto,
                  TotOpIVARec = listaResumenPeriodo[index].TotOpIVARec,
                  TotMntIVA = listaResumenPeriodo[index].TotMntIVA,
                  TotIVAUsoComun = listaResumenPeriodo[index].TotIVAUsoComun,
                  FctProp = listaResumenPeriodo[index].FctProp,
                  TotCredIVAUsoComun = listaResumenPeriodo[index].TotCredIVAUsoComun,
                  TotIVANoRec =
                  {
                      CodIVANoRec = listaResumenPeriodo[index].TotIVANoRec.CodIVANoRec,
                      TotOpIVANoRec = listaResumenPeriodo[index].TotIVANoRec.TotOpIVANoRec,
                      TotMntIVANoRec = listaResumenPeriodo[index].TotIVANoRec.TotMntIVANoRec
                  },
                  TotOtrosImp = listaResumenPeriodo[index].TotOtrosImp,
                  TotMntTotal = listaResumenPeriodo[index].TotMntTotal
              });
        //agrega el detalle del envio del dte
      libroCompraVenta.EnvioLibro.Detalles = new List<csDetalleLibro>();
      foreach (csDetalleLibro csDetalleLibro in listaDetalle)
      {
          if (csDetalleLibro.TpoDoc != 0)
          {
              libroCompraVenta.EnvioLibro.Detalles.Add(csDetalleLibro);
          }
      }
      libroCompraVenta.Serializar(tipoOperacion);
      this.quitarIdentacion(tipoOperacion);
      this.agregaSETLibro(tipoOperacion);
      return this.firmaLibro(tipoOperacion);
    }
    public string creaXMLlibroCompraVenta(string periodo, string tipoOperacion, string tipoLibro, string tipoEnvio, int folioNotificacion, List<TotalesPeriodo> listaResumenPeriodo, DataGridView detalle, string codigoAutorizacion)
    {
        this.CargaRuta();
        csLibroCompraVenta libroCompraVenta = new csLibroCompraVenta();
        EmisorVO emisorVo = new Emisor().buscaEmisor();
        libroCompraVenta.EnvioLibro.Caratula.RutEmisorLibro = emisorVo.RutEmisior;
        libroCompraVenta.EnvioLibro.Caratula.RutEnvia = emisorVo.RutCertificado;
        libroCompraVenta.EnvioLibro.Caratula.PeriodoTributario = periodo;
        string str = emisorVo.FechaResolucion.Substring(6, 4) + "-" + emisorVo.FechaResolucion.Substring(3, 2) + "-" + emisorVo.FechaResolucion.Substring(0, 2);
        libroCompraVenta.EnvioLibro.Caratula.FchResol = str;
        libroCompraVenta.EnvioLibro.Caratula.NroResol = Convert.ToInt32(emisorVo.NumeroResolucion);
        libroCompraVenta.EnvioLibro.Caratula.TipoOperacion = tipoOperacion;
        libroCompraVenta.EnvioLibro.Caratula.TipoLibro = tipoLibro;
        libroCompraVenta.EnvioLibro.Caratula.TipoEnvio = tipoEnvio;
        libroCompraVenta.EnvioLibro.Caratula.FolioNotificacion = folioNotificacion;
        libroCompraVenta.EnvioLibro.Caratula.CodAutRec = codigoAutorizacion;
        TotalesPeriodo totalesPeriodo = new TotalesPeriodo();
        libroCompraVenta.EnvioLibro.ResumenPeriodo = new List<TotalesPeriodo>();
        for (int index = 0; index < listaResumenPeriodo.Count; ++index)
            libroCompraVenta.EnvioLibro.ResumenPeriodo.Add(new TotalesPeriodo()
            {
                TpoDoc = listaResumenPeriodo[index].TpoDoc,
                TpoImp = listaResumenPeriodo[index].TpoImp,
                TotDoc = listaResumenPeriodo[index].TotDoc,
                TotOpExe = listaResumenPeriodo[index].TotOpExe,
                TotMntExe = listaResumenPeriodo[index].TotMntExe,
                TotMntNeto = listaResumenPeriodo[index].TotMntNeto,
                TotOpIVARec = listaResumenPeriodo[index].TotOpIVARec,
                TotMntIVA = listaResumenPeriodo[index].TotMntIVA,
                TotIVAUsoComun = listaResumenPeriodo[index].TotIVAUsoComun,
                FctProp = listaResumenPeriodo[index].FctProp,
                TotCredIVAUsoComun = listaResumenPeriodo[index].TotCredIVAUsoComun,
                TotIVANoRec =
                {
                    CodIVANoRec = listaResumenPeriodo[index].TotIVANoRec.CodIVANoRec,
                    TotOpIVANoRec = listaResumenPeriodo[index].TotIVANoRec.TotOpIVANoRec,
                    TotMntIVANoRec = listaResumenPeriodo[index].TotIVANoRec.TotMntIVANoRec
                },
                TotOtrosImp = listaResumenPeriodo[index].TotOtrosImp,
                TotMntTotal = listaResumenPeriodo[index].TotMntTotal
            });
        //agrega el detalle del envio del dte
        libroCompraVenta.EnvioLibro.Detalles = new List<csDetalleLibro>();
        foreach (csDetalleLibro csDetalleLibro in detalle.Rows)
            libroCompraVenta.EnvioLibro.Detalles.Add(csDetalleLibro);
        libroCompraVenta.Serializar(tipoOperacion);
        this.quitarIdentacion(tipoOperacion);
        this.agregaSETLibro(tipoOperacion);
        return this.firmaLibro(tipoOperacion);
    }
    private void quitarIdentacion(string tipoOperacion)
    {
      string uri = "";
      if (tipoOperacion.Equals("VENTA"))
        uri = this._rutaElectronica + "LIBROS\\VENTA\\libro1.XML";
      if (tipoOperacion.Equals("COMPRA"))
        uri = this._rutaElectronica + "LIBROS\\COMPRA\\libro1.XML";
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

    private void agregaSETLibro(string tipoOperacion)
    {
      string filename1 = "";
      string str = "";
      string filename2 = this._rutaElectronica + "Archivos\\SETLIBRO.XML";
      if (tipoOperacion.Equals("VENTA"))
      {
        filename1 = this._rutaElectronica + "LIBROS\\VENTA\\libro1.XML";
        str = this._rutaElectronica + "LIBROS\\VENTA\\libro1_resultado.XML";
      }
      if (tipoOperacion.Equals("COMPRA"))
      {
        filename1 = this._rutaElectronica + "LIBROS\\COMPRA\\libro1.XML";
        str = this._rutaElectronica + "LIBROS\\COMPRA\\libro1_resultado.XML";
      }
      XmlDocument xmlDocument1 = new XmlDocument();
      xmlDocument1.PreserveWhitespace = true;
      xmlDocument1.Load(filename2);
      XmlElement documentElement = xmlDocument1.DocumentElement;
      XmlDocument xmlDocument2 = new XmlDocument();
      xmlDocument2.PreserveWhitespace = true;
      xmlDocument2.Load(filename1);
      XmlElement xmlElement = (XmlElement) xmlDocument2.SelectSingleNode("LibroCompraVenta/EnvioLibro");
      documentElement.AppendChild(xmlDocument1.ImportNode((XmlNode) xmlElement, true));
      xmlDocument1.Save(filename1);
    }

    public string firmaLibro(string tipoOperacion)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string uriSchema = this._rutaElectronica + "Archivos\\Schemas\\LibroVentaCompra\\LibroCV_v10.xsd";
      string certificadoDigital = new Emisor().buscaEmisor().CertificadoDigital;
      DateTime now = DateTime.Now;
      string str4 = now.ToString().Replace("/", "-").Replace(":", "_");
      if (tipoOperacion.Equals("VENTA"))
      {
        str1 = this._rutaElectronica + "LIBROS\\VENTA\\libro1.XML";
        str2 = this._rutaElectronica + "LIBROS\\VENTA\\LibroVentaEnvio_" + str4 +"_"+multi+ ".XML";
        str3 = "LibroVentaEnvio_" + str4 + "_" + multi + ".XML";
      }
      if (tipoOperacion.Equals("COMPRA"))
      {
        str1 = this._rutaElectronica + "LIBROS\\COMPRA\\libro1.XML";
        str2 = this._rutaElectronica + "LIBROS\\COMPRA\\LibroCompraEnvio_" + str4 + "_" + multi + ".XML";
        str3 = "LibroCompraEnvio_" + str4 + "_" + multi + ".XML";
      }
      string CN = certificadoDigital;
      List<string> list1 = new List<string>();
      string str5 = "Libro_1234";
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
      XmlElement xmlElement1 = (XmlElement) xmldocument.SelectSingleNode("LibroCompraVenta/EnvioLibro/TmstFirma");
      if (xmlElement1 == null)
        throw new Exception("No se encuentra el nodo TmstFirma");
      XmlElement xmlElement2 = xmlElement1;
      now = DateTime.Now;
      string str6 = now.ToString("yyyy-MM-ddTHH:mm:ss");
      xmlElement2.InnerText = str6;
      xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
      xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
      xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte LibroCV_v10.xsd");
      xmldocument.Save(str2);
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str2);
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
      if (certificado == null)
        throw new Exception("No se encuentra el certificado para poder firmar ls documentos");
      string referenciaUri = string.Format("#{0}", (object) str5);
      FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
      xmldocument.Save(str2);
      list2.Clear();
      List<string> list3 = FuncionesComunes.ValidarSchema(str2, uriSchema);
      if (list3.Count > 0)
      {
        int num1 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml (DTE)");
        int num2;
        list3.ForEach((Action<string>) (es => num2 = (int) MessageBox.Show(es)));
        int num3 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml.");
      }
      return str3;
    }
  }
}
