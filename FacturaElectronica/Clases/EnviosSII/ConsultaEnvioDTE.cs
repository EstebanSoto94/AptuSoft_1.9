 
// Type: Aptusoft.FacturaElectronica.Clases.EnviosSII.ConsultaEnvioDTE
 
 
// version 1.8.0

using System.Collections.Generic;
using System.Xml;

namespace Aptusoft.FacturaElectronica.Clases.EnviosSII
{
  public class ConsultaEnvioDTE
  {
    private static Aptusoft.cl.sii.maullin.consulta.QueryEstUpService servicioConsultaMaullin;
    private static Aptusoft.cl.sii.palena.consulta.QueryEstUpService servicioConsultaPalena;
    private static XmlDocument xmlRespuestaSII;
    private static RespuestaToken token;
    private static RespuestaConsultaEnvioDTE consulta;

    public static List<RespuestaConsultaEnvioDTE> ConsultaDTE(char ambiente, string rutEmpresa, string trackID, string nombreCertificado, string tokenString = null)
    {
      rutEmpresa = rutEmpresa.Replace("-", string.Empty);
      string RutCompania = rutEmpresa.Substring(0, rutEmpresa.Length - 1);
      string DvCompania = rutEmpresa.Substring(rutEmpresa.Length - 1);
      ConsultaEnvioDTE.xmlRespuestaSII = new XmlDocument();
      List<RespuestaConsultaEnvioDTE> list = (List<RespuestaConsultaEnvioDTE>) null;
      if (string.IsNullOrEmpty(tokenString))
        ConsultaEnvioDTE.token = Token.SolicitarToken(ambiente, nombreCertificado);
      else
        ConsultaEnvioDTE.token = new RespuestaToken()
        {
          Token = tokenString
        };
      switch (ambiente)
      {
        case 'M':
          ConsultaEnvioDTE.servicioConsultaMaullin = new Aptusoft.cl.sii.maullin.consulta.QueryEstUpService();
          ConsultaEnvioDTE.xmlRespuestaSII.LoadXml(ConsultaEnvioDTE.servicioConsultaMaullin.getEstUp(RutCompania, DvCompania, trackID, ConsultaEnvioDTE.token.Token));
          break;
        case 'P':
          ConsultaEnvioDTE.servicioConsultaPalena = new Aptusoft.cl.sii.palena.consulta.QueryEstUpService();
          ConsultaEnvioDTE.xmlRespuestaSII.LoadXml(ConsultaEnvioDTE.servicioConsultaPalena.getEstUp(RutCompania, DvCompania, trackID, ConsultaEnvioDTE.token.Token));
          break;
      }
      if (ConsultaEnvioDTE.xmlRespuestaSII != null)
      {
        string innerXml1 = ConsultaEnvioDTE.xmlRespuestaSII.SelectNodes("//ESTADO").Item(0).InnerXml;
        list = new List<RespuestaConsultaEnvioDTE>();
        if (innerXml1.Equals("EPR"))
        {
          XmlElement xmlElement1 = (XmlElement) ConsultaEnvioDTE.xmlRespuestaSII.DocumentElement.LastChild;
          string innerXml2 = xmlElement1.SelectSingleNode("//TRACKID").InnerXml;
          string innerText = xmlElement1.SelectSingleNode("//ESTADO").InnerText;
          string innerXml3 = xmlElement1.SelectSingleNode("//GLOSA").InnerXml;
          string innerXml4 = xmlElement1.SelectSingleNode("//NUM_ATENCION").InnerXml;
          foreach (XmlElement xmlElement2 in ConsultaEnvioDTE.xmlRespuestaSII.DocumentElement.FirstChild.ChildNodes)
          {
            if (xmlElement2.Name.Equals("TIPO_DOCTO"))
            {
              ConsultaEnvioDTE.consulta = new RespuestaConsultaEnvioDTE();
              ConsultaEnvioDTE.consulta.TrackID = innerXml2;
              ConsultaEnvioDTE.consulta.Estado = innerText;
              ConsultaEnvioDTE.consulta.Glosa = innerXml3;
              ConsultaEnvioDTE.consulta.NumeroAtencion = innerXml4;
              ConsultaEnvioDTE.consulta.Tipo_Docto = xmlElement2.InnerText;
            }
            if (xmlElement2.Name.Equals("INFORMADOS"))
              ConsultaEnvioDTE.consulta.Informados = xmlElement2.InnerText;
            if (xmlElement2.Name.Equals("ACEPTADOS"))
              ConsultaEnvioDTE.consulta.Aceptados = xmlElement2.InnerText;
            if (xmlElement2.Name.Equals("RECHAZADOS"))
              ConsultaEnvioDTE.consulta.Rechazados = xmlElement2.InnerText;
            if (xmlElement2.Name.Equals("REPAROS"))
            {
              ConsultaEnvioDTE.consulta.Reparos = xmlElement2.InnerText;
              list.Add(ConsultaEnvioDTE.consulta);
            }
          }
        }
        else
        {
          XmlElement xmlElement = (XmlElement) ConsultaEnvioDTE.xmlRespuestaSII.DocumentElement.LastChild;
          ConsultaEnvioDTE.consulta = new RespuestaConsultaEnvioDTE();
          ConsultaEnvioDTE.consulta.Estado = xmlElement.SelectSingleNode("//ESTADO").InnerText;
          int result = 0;
          if (int.TryParse(innerXml1, out result))
          {
            if (innerXml1 != "-11")
            {
              ConsultaEnvioDTE.consulta.Glosa = xmlElement.SelectSingleNode("//GLOSA").InnerXml;
            }
            else
            {
              ConsultaEnvioDTE.consulta.ERR_CODE = xmlElement.SelectSingleNode("//ERR_CODE").InnerXml;
              ConsultaEnvioDTE.consulta.ERR_CODE = ConsultaEnvioDTE.Err_code(ConsultaEnvioDTE.consulta.ERR_CODE);
              ConsultaEnvioDTE.consulta.SQL_CODE = xmlElement.SelectSingleNode("//SQL_CODE").InnerXml;
              ConsultaEnvioDTE.consulta.SQL_CODE = ConsultaEnvioDTE.Sql_code(ConsultaEnvioDTE.consulta.SQL_CODE);
              ConsultaEnvioDTE.consulta.SRV_CODE = xmlElement.SelectSingleNode("//SRV_CODE").InnerXml;
              ConsultaEnvioDTE.consulta.SRV_CODE = ConsultaEnvioDTE.Svr_code(ConsultaEnvioDTE.consulta.SRV_CODE);
              ConsultaEnvioDTE.consulta.NumeroAtencion = xmlElement.SelectSingleNode("//NUM_ATENCION").InnerXml;
            }
          }
          else
          {
            ConsultaEnvioDTE.consulta.NumeroAtencion = xmlElement.SelectSingleNode("//NUM_ATENCION").InnerXml;
            ConsultaEnvioDTE.consulta.Glosa = xmlElement.SelectSingleNode("//GLOSA").InnerXml;
          }
          list.Add(ConsultaEnvioDTE.consulta);
        }
      }
      return list;
    }

    private static string Svr_code(string cod)
    {
      string str = cod + "-";
      switch (cod)
      {
        case "0":
          str += " Todo Ok";
          break;
        case "1":
          str += " Error en Entrada";
          break;
        case "2":
          str += " Error SQL";
          break;
      }
      return str;
    }

    private static string Sql_code(string cod)
    {
      string str1 = cod + "-";
      string str2;
      switch (cod)
      {
        case "0":
          str2 = str1 + " Schema Validado";
          break;
        default:
          str2 = str1 + " Código de Oracle";
          break;
      }
      return str2;
    }

    private static string Err_code(string cod)
    {
      string str = cod + "-";
      switch (cod)
      {
        case "0":
          str += " Se retorna el estado";
          break;
        case "1":
          str += " El envío no es de la Empresa, faltan parámetros de entrada";
          break;
        case "2":
          str += " Error de Proceso";
          break;
      }
      return str;
    }
  }
}
