 
// Type: Aptusoft.InternoAptusoft.Email.Email
 
 
// version 1.8.0

using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace Aptusoft.InternoAptusoft.Email
{
  public class Email
  {
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

    public void EnviaEmail(EmailVO em)
    {
      this.CargaRuta();
      string str1 = this._rutaElectronica + "PDF\\E-Factura\\EFactura_" + em.Adjunto + ".pdf";
      string host = "smtp.gmail.com";
      string userName = "soporte@Aptusoft.cl";
      string password = "f5llp3m2";
      MailMessage message = new MailMessage();
      message.To.Add(new MailAddress(em.Para));
      message.Bcc.Add("nperez@Aptusoft.cl");
      message.From = new MailAddress(em.De);
      message.Subject = em.Asunto;
      message.IsBodyHtml = true;
      em.Mensaje = this.FormatoMensaje(em.Mensaje);
      message.Body = em.Mensaje;
      if (str1.Trim().Length > 0)
      {
        string str2 = str1;
        Attachment attachment = new Attachment(str2, "application/octet-stream");
        ContentDisposition contentDisposition = attachment.ContentDisposition;
        contentDisposition.CreationDate = System.IO.File.GetCreationTime(str2);
        contentDisposition.ModificationDate = System.IO.File.GetLastWriteTime(str2);
        contentDisposition.ReadDate = System.IO.File.GetLastAccessTime(str2);
        message.Attachments.Add(attachment);
      }
      SmtpClient smtpClient = new SmtpClient(host);
      smtpClient.UseDefaultCredentials = false;
      smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(userName, password);
      smtpClient.EnableSsl = true;
      try
      {
        smtpClient.Send(message);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private string FormatoMensaje(string observaciones)
    {
      return "<table width='80%' border='0' cellspacing='0' cellpadding='0' style='font-family:Arial, Helvetica, sans-serif; font-size:14px;  text-decoration:none;'> \r\n            <tr>                \r\n                <td>&nbsp;&nbsp;" + observaciones + "</td>\r\n            </tr>              \r\n           </table>";
    }
  }
}
