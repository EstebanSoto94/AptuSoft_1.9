 
// Type: Aptusoft.FacturaElectronica.Clases.EnviosSII.Upload
 
 
// version 1.8.0

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Aptusoft.FacturaElectronica.Clases.EnviosSII
{
  public class Upload
  {
    public string CreaUpload(char ambiente, string rutEmisor, string rutEmpresa, string nombreArchivo, string uri, string token)
    {
      string str1 = string.Empty;
      rutEmisor = rutEmisor.Replace("-", string.Empty);
      rutEmpresa = rutEmpresa.Replace("-", string.Empty);
      StringBuilder stringBuilder = new StringBuilder();
      string str2 = rutEmisor.Substring(0, rutEmisor.Length - 1);
      string str3 = rutEmisor.Substring(rutEmisor.Length - 1);
      string str4 = rutEmpresa.Substring(0, rutEmpresa.Length - 1);
      string str5 = rutEmpresa.Substring(rutEmpresa.Length - 1);
      stringBuilder.Append("--7d23e2a11301c4\r\n");
      stringBuilder.Append("Content-Disposition: form-data; name=\"rutSender\"\r\n");
      stringBuilder.Append("\r\n");
      stringBuilder.Append(str2 + "\r\n");
      stringBuilder.Append("--7d23e2a11301c4\r\n");
      stringBuilder.Append("Content-Disposition: form-data; name=\"dvSender\"\r\n");
      stringBuilder.Append("\r\n");
      stringBuilder.Append(str3 + "\r\n");
      stringBuilder.Append("--7d23e2a11301c4\r\n");
      stringBuilder.Append("Content-Disposition: form-data; name=\"rutCompany\"\r\n");
      stringBuilder.Append("\r\n");
      stringBuilder.Append(str4 + "\r\n");
      stringBuilder.Append("--7d23e2a11301c4\r\n");
      stringBuilder.Append("Content-Disposition: form-data; name=\"dvCompany\"\r\n");
      stringBuilder.Append("\r\n");
      stringBuilder.Append(str5 + "\r\n");
      stringBuilder.Append("--7d23e2a11301c4\r\n");
      stringBuilder.Append("Content-Disposition: form-data; name=\"archivo\"; filename=\"" + nombreArchivo + "\"\r\n");
      stringBuilder.Append("Content-Type: text/xml\r\n");
      stringBuilder.Append("\r\n");
      XDocument xdocument = XDocument.Load(uri, LoadOptions.PreserveWhitespace);
      stringBuilder.Append("<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>\r");
      stringBuilder.Append(xdocument.ToString(SaveOptions.DisableFormatting));
      stringBuilder.Append("\r\n");
      stringBuilder.Append("--7d23e2a11301c4--\r\n");
      string requestUriString = "";
      switch (ambiente)
      {
        case 'M':
          requestUriString = "https://maullin.sii.cl/cgi_dte/UPL/DTEUpload";
          break;
        case 'P':
          requestUriString = "https://palena.sii.cl/cgi_dte/UPL/DTEUpload";
          break;
      }
      string str6 = "POST";
      string str7 = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg,application/vnd.ms-powerpoint, application/ms-excel,application/msword, */*";
      string str8 = "www.Aptusoft.cl";
      string format = "TOKEN={0}";
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(requestUriString);
      httpWebRequest.Method = str6;
      httpWebRequest.Accept = str7;
      httpWebRequest.Referer = str8;
      httpWebRequest.ContentType = "multipart/form-data: boundary=7d23e2a11301c4";
      httpWebRequest.ContentLength = (long) stringBuilder.Length;
      httpWebRequest.Headers.Add("Accept-Language", "es-cl");
      httpWebRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
      httpWebRequest.Headers.Add("Cache-Control", "no-cache");
      httpWebRequest.Headers.Add("Cookie", string.Format(format, (object) token));
      httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; PROG 1.0; Windows NT 5.0; YComp 5.0.2.4)";
      httpWebRequest.KeepAlive = true;
      try
      {
        using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream(), Encoding.GetEncoding("ISO-8859-1")))
          streamWriter.Write(stringBuilder.ToString());
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error en el metodo " + ex.Message);
      }
      try
      {
        using (HttpWebResponse httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse())
        {
          using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            str1 = streamReader.ReadToEnd().Trim();
        }
        if (string.IsNullOrEmpty(str1))
        {
          int num = (int) MessageBox.Show("Respuesta del SII es null");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error " + ex.Message);
      }
      return str1;
    }
  }
}
