 
// Type: Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas.csGeneraXMLreporteConsumoFolios
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Aptusoft.FacturaElectronica.Clases.ConsumoFoliosBoletas
{
  public class csGeneraXMLreporteConsumoFolios
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

    public string CreaXMLreporteConsumoFolios(List<Venta> listaDocumentos)
    {
      this.CargaRuta();
      List<Venta> list1 = new List<Venta>();
      List<Venta> list2 = new List<Venta>();
      List<Venta> list3 = new List<Venta>();
      foreach (Venta venta in listaDocumentos)
      {
        if (venta.Fe_TipoDTE == 39)
          list1.Add(venta);
        if (venta.Fe_TipoDTE == 41)
          list2.Add(venta);
        if (venta.Fe_TipoDTE == 61)
          list3.Add(venta);
      }
      csReporteConsumoFolios reporteConsumoFolios = new csReporteConsumoFolios();
      DateTime fechaEmision1 = listaDocumentos[0].FechaEmision;
      DateTime fechaEmision2 = listaDocumentos[0].FechaEmision;
      for (int index = 0; index < listaDocumentos.Count; ++index)
      {
        if (listaDocumentos[index].FechaEmision > fechaEmision2)
          fechaEmision2 = listaDocumentos[index].FechaEmision;
        if (listaDocumentos[index].FechaEmision < fechaEmision1)
          fechaEmision1 = listaDocumentos[index].FechaEmision;
      }
      EmisorVO emisorVo = new Emisor().buscaEmisor();
      reporteConsumoFolios.DocumentoConsumoFolios.Caratula.version = "1.0";
      reporteConsumoFolios.DocumentoConsumoFolios.Caratula.RutEmisor = emisorVo.RutEmisior;
      reporteConsumoFolios.DocumentoConsumoFolios.Caratula.RutEnvia = emisorVo.RutCertificado;
      string str1 = emisorVo.FechaResolucion.Substring(6, 4) + "-" + emisorVo.FechaResolucion.Substring(3, 2) + "-" + emisorVo.FechaResolucion.Substring(0, 2);
      reporteConsumoFolios.DocumentoConsumoFolios.Caratula.FchResol = str1;
      reporteConsumoFolios.DocumentoConsumoFolios.Caratula.NroResol = Convert.ToInt32(emisorVo.NumeroResolucion);
      csCaratulaConsumoFolio caratula1 = reporteConsumoFolios.DocumentoConsumoFolios.Caratula;
      object[] objArray1 = new object[5];
      objArray1[0] = (object) fechaEmision1.Year;
      objArray1[1] = (object) "-";
      object[] objArray2 = objArray1;
      int index1 = 2;
      int num1;
      string str2;
      if (fechaEmision1.Month.ToString().Length != 1)
      {
        num1 = fechaEmision1.Month;
        str2 = num1.ToString();
      }
      else
        str2 = "0" + fechaEmision1.Month.ToString();
      objArray2[index1] = (object) str2;
      objArray1[3] = (object) "-";
      object[] objArray3 = objArray1;
      int index2 = 4;
      num1 = fechaEmision1.Day;
      string str3;
      if (num1.ToString().Length != 1)
      {
        num1 = fechaEmision1.Day;
        str3 = num1.ToString();
      }
      else
      {
        string str4 = "0";
        num1 = fechaEmision1.Day;
        string str5 = num1.ToString();
        str3 = str4 + str5;
      }
      objArray3[index2] = (object) str3;
      string str6 = string.Concat(objArray1);
      caratula1.FchInicio = str6;
      csCaratulaConsumoFolio caratula2 = reporteConsumoFolios.DocumentoConsumoFolios.Caratula;
      object[] objArray4 = new object[5];
      objArray4[0] = (object) fechaEmision2.Year;
      objArray4[1] = (object) "-";
      object[] objArray5 = objArray4;
      int index3 = 2;
      num1 = fechaEmision2.Month;
      string str7;
      if (num1.ToString().Length != 1)
      {
        num1 = fechaEmision2.Month;
        str7 = num1.ToString();
      }
      else
      {
        string str4 = "0";
        num1 = fechaEmision2.Month;
        string str5 = num1.ToString();
        str7 = str4 + str5;
      }
      objArray5[index3] = (object) str7;
      objArray4[3] = (object) "-";
      object[] objArray6 = objArray4;
      int index4 = 4;
      num1 = fechaEmision2.Day;
      string str8;
      if (num1.ToString().Length != 1)
      {
        num1 = fechaEmision2.Day;
        str8 = num1.ToString();
      }
      else
      {
        string str4 = "0";
        num1 = fechaEmision2.Day;
        string str5 = num1.ToString();
        str8 = str4 + str5;
      }
      objArray6[index4] = (object) str8;
      string str9 = string.Concat(objArray4);
      caratula2.FchFinal = str9;
      reporteConsumoFolios.DocumentoConsumoFolios.Caratula.SecEnvio = 3;
      reporteConsumoFolios.DocumentoConsumoFolios.Resumen = new List<csResumenConsumoBoleta>();
      csResumenConsumoBoleta resumenConsumoBoleta1 = new csResumenConsumoBoleta();
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      Decimal num5 = new Decimal(0);
      Decimal num6 = new Decimal(0);
      int num7 = 0;
      int num8 = 0;
      int num9 = 0;
      if (list1.Count > 0)
      {
        List<Venta> list4 = Enumerable.ToList<Venta>((IEnumerable<Venta>) Enumerable.OrderBy<Venta, int>((IEnumerable<Venta>) list1, (Func<Venta, int>) (p => p.Folio)));
        foreach (Venta venta in list4)
        {
          num2 += venta.Neto;
          num3 += venta.Iva;
          num5 += venta.TotalExento;
          num6 += venta.Total;
          ++num7;
        }
        resumenConsumoBoleta1.TipoDocumento = 39;
        resumenConsumoBoleta1.MntNeto = Convert.ToDecimal(num2.ToString("N0"));
        resumenConsumoBoleta1.MntIva = Convert.ToDecimal(num3.ToString("N0"));
        resumenConsumoBoleta1.TasaIVA = new Decimal(19);
        resumenConsumoBoleta1.MntExento = Convert.ToDecimal(num5.ToString("N0"));
        resumenConsumoBoleta1.MntTotal = Convert.ToDecimal(num6.ToString("N0"));
        resumenConsumoBoleta1.FoliosEmitidos = num7;
        resumenConsumoBoleta1.FoliosAnulados = num8;
        resumenConsumoBoleta1.FoliosUtilizados = num7 + num8;
        int folio = list4[0].Folio;
        int num10 = 0;
        for (int index5 = 0; index5 < list4.Count; ++index5)
        {
          if (folio > list4[index5].Folio)
            folio = list4[index5].Folio;
        }
        int num11 = folio + 1;
        int num12 = 0;
        for (int index5 = 0; index5 < list4.Count; ++index5)
        {
          if (list4[index5].Folio > folio)
          {
            if (num11 == list4[index5].Folio)
            {
              ++num11;
              num10 = list4[index5].Folio;
            }
            else
            {
              num10 = list4[index5 - 1].Folio;
              num12 = list4[index5].Folio;
              break;
            }
          }
        }
        if (num10 == 0)
          num10 = folio;
        resumenConsumoBoleta1.RangoUtilizados = new List<csRangoUtilizadoConsumoBoleta>();
        resumenConsumoBoleta1.RangoUtilizados.Add(new csRangoUtilizadoConsumoBoleta()
        {
          Inicial = folio,
          Final = num10
        });
        if (num12 > 0)
        {
          while (num12 > 0)
          {
            int num13 = num12;
            int num14 = num13 + 1;
            num12 = 0;
            int num15 = 0;
            for (int index5 = 0; index5 < list4.Count; ++index5)
            {
              if (list4[index5].Folio > num13)
              {
                if (num14 == list4[index5].Folio)
                {
                  ++num14;
                  num15 = list4[index5].Folio;
                }
                else
                {
                  num15 = list4[index5 - 1].Folio;
                  num12 = list4[index5].Folio;
                  break;
                }
              }
            }
            if (num15 == 0)
              num15 = num13;
            resumenConsumoBoleta1.RangoUtilizados.Add(new csRangoUtilizadoConsumoBoleta()
            {
              Inicial = num13,
              Final = num15
            });
          }
        }
        reporteConsumoFolios.DocumentoConsumoFolios.Resumen = new List<csResumenConsumoBoleta>();
        reporteConsumoFolios.DocumentoConsumoFolios.Resumen.Add(resumenConsumoBoleta1);
      }
      if (list3.Count > 0)
      {
        Decimal num10 = new Decimal(0);
        num3 = new Decimal(0);
        num4 = new Decimal(0);
        num5 = new Decimal(0);
        Decimal num11 = new Decimal(0);
        int num12 = 0;
        int num13 = 0;
        num9 = 0;
        csResumenConsumoBoleta resumenConsumoBoleta2 = new csResumenConsumoBoleta();
        List<Venta> list4 = Enumerable.ToList<Venta>((IEnumerable<Venta>) Enumerable.OrderBy<Venta, int>((IEnumerable<Venta>) list3, (Func<Venta, int>) (p => p.Folio)));
        foreach (Venta venta in list4)
        {
          num10 += venta.Neto;
          num3 += venta.Iva;
          num5 += venta.TotalExento;
          num11 += venta.Total;
          ++num12;
        }
        resumenConsumoBoleta2.TipoDocumento = 61;
        resumenConsumoBoleta2.MntNeto = Convert.ToDecimal(num10.ToString("N0"));
        resumenConsumoBoleta2.MntIva = Convert.ToDecimal(num3.ToString("N0"));
        resumenConsumoBoleta2.TasaIVA = new Decimal(19);
        resumenConsumoBoleta2.MntExento = Convert.ToDecimal(num5.ToString("N0"));
        resumenConsumoBoleta2.MntTotal = Convert.ToDecimal(num11.ToString("N0"));
        resumenConsumoBoleta2.FoliosEmitidos = num12;
        resumenConsumoBoleta2.FoliosAnulados = num13;
        resumenConsumoBoleta2.FoliosUtilizados = num12 + num13;
        int folio = list4[0].Folio;
        int num14 = 0;
        for (int index5 = 0; index5 < list4.Count; ++index5)
        {
          if (folio > list4[index5].Folio)
            folio = list4[index5].Folio;
        }
        int num15 = folio + 1;
        int num16 = 0;
        for (int index5 = 0; index5 < list4.Count; ++index5)
        {
          if (list4[index5].Folio > folio)
          {
            if (num15 == list4[index5].Folio)
            {
              ++num15;
              num14 = list4[index5].Folio;
            }
            else
            {
              num14 = list4[index5 - 1].Folio;
              num16 = list4[index5].Folio;
              break;
            }
          }
        }
        if (num14 == 0)
          num14 = folio;
        resumenConsumoBoleta2.RangoUtilizados = new List<csRangoUtilizadoConsumoBoleta>();
        resumenConsumoBoleta2.RangoUtilizados.Add(new csRangoUtilizadoConsumoBoleta()
        {
          Inicial = folio,
          Final = num14
        });
        if (num16 > 0)
        {
          while (num16 > 0)
          {
            int num17 = num16;
            int num18 = num17 + 1;
            num16 = 0;
            int num19 = 0;
            for (int index5 = 0; index5 < list4.Count; ++index5)
            {
              if (list4[index5].Folio > num17)
              {
                if (num18 == list4[index5].Folio)
                {
                  ++num18;
                  num19 = list4[index5].Folio;
                }
                else
                {
                  num19 = list4[index5 - 1].Folio;
                  num16 = list4[index5].Folio;
                  break;
                }
              }
            }
            if (num19 == 0)
              num19 = num17;
            resumenConsumoBoleta2.RangoUtilizados.Add(new csRangoUtilizadoConsumoBoleta()
            {
              Inicial = num17,
              Final = num19
            });
          }
        }
        reporteConsumoFolios.DocumentoConsumoFolios.Resumen.Add(resumenConsumoBoleta2);
      }
      reporteConsumoFolios.Serializar();
      this.quitarIdentacion();
      this.estableceEncoding();
      return this.firmaLibro();
    }

    private void quitarIdentacion()
    {
      string uri = this._rutaElectronica + "DTE\\ReporteConsumoFolios\\libro1.XML";
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

    private void estableceEncoding()
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      try
      {
        string filename = this._rutaElectronica + "DTE\\ReporteConsumoFolios\\libro1.XML";
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

    public string firmaLibro()
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string uriSchema = this._rutaElectronica + @"Archivos\Schemas\Consumo_Folios\ConsumoFolio_v10.xsd";
      string certificadoDigital = new Emisor().buscaEmisor().CertificadoDigital;
      DateTime now = DateTime.Now;
      string str1 = now.ToString().Replace("/", "-").Replace(":", "_");
      string str2 = this._rutaElectronica + "DTE\\ReporteConsumoFolios\\libro1.XML";
      string str3 = this._rutaElectronica + "DTE\\ReporteConsumoFolios\\ReporteConsumoFoliosEnvio_" + str1 +"_"+multi+ ".XML";
      string str4 = "ReporteConsumoFoliosEnvio_" + str1 + "_" + multi + ".XML";
      string CN = certificadoDigital;
      List<string> list1 = new List<string>();
      string str5 = "Libro_1234";
      XmlDocument xmldocument = new XmlDocument();
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str2);
      list1.Clear();
      List<string> list2 = FuncionesComunes.ValidarSchema(str2, uriSchema);
      if (list2.Count > 0)
      {
        int num1 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml DTE");
        int num2;
        list2.ForEach((Action<string>) (es => num2 = (int) MessageBox.Show(es, "Alerta 1")));
        int num3 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml");
      }
      XmlElement xmlElement1 = (XmlElement) xmldocument.SelectSingleNode("ConsumoFolios/DocumentoConsumoFolios/Caratula/TmstFirmaEnv");
      if (xmlElement1 == null)
        throw new Exception("No se encuentra el nodo TmstFirmaEnv");
      XmlElement xmlElement2 = xmlElement1;
      now = DateTime.Now;
      string str6 = now.ToString("yyyy-MM-ddTHH:mm:ss");
      xmlElement2.InnerText = str6;
      xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
      xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
      xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte ConsumoFolio_v10.xsd");
      xmldocument.Save(str3);
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str3);
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
      if (certificado == null)
        throw new Exception("No se encuentra el certificado para poder firmar ls documentos");
      string referenciaUri = string.Format("#{0}", (object) str5);
      FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
      xmldocument.Save(str3);
      list2.Clear();
      List<string> list3 = FuncionesComunes.ValidarSchema(str3, uriSchema);
      if (list3.Count > 0)
      {
        int num1 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml (DTE)");
        int num2;
        list3.ForEach((Action<string>) (es => num2 = (int) MessageBox.Show(es, "Alerta 2")));
        int num3 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml.");
      }
      return str4;
    }
  }
}
