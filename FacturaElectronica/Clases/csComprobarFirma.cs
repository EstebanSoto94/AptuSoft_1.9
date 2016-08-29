 
// Type: Aptusoft.FacturaElectronica.Clases.csComprobarFirma
 
 
// version 1.8.0

using System;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class csComprobarFirma
  {
    private const string XPATH_MODULUS = "sii:EnvioDTE/sig:Signature/sig:KeyInfo/sig:KeyValue/sig:RSAKeyValue/sig:Modulus";
    private const string XPATH_EXPONENT = "sii:EnvioDTE/sig:Signature/sig:KeyInfo/sig:KeyValue/sig:RSAKeyValue/sig:Exponent";

    public bool comprobarFirma(string uriXml)
    {
      try
      {
        XmlDocument document = new XmlDocument();
        document.PreserveWhitespace = true;
        document.Load(uriXml);
        XmlNamespaceManager nsmgr = new XmlNamespaceManager(document.NameTable);
        nsmgr.AddNamespace("sii", document.DocumentElement.NamespaceURI);
        nsmgr.AddNamespace("sig", "http://www.w3.org/2000/09/xmldsig#");
        string innerText1 = document.SelectSingleNode("sii:EnvioDTE/sig:Signature/sig:KeyInfo/sig:KeyValue/sig:RSAKeyValue/sig:Modulus", nsmgr).InnerText;
        string innerText2 = document.SelectSingleNode("sii:EnvioDTE/sig:Signature/sig:KeyInfo/sig:KeyValue/sig:RSAKeyValue/sig:Exponent", nsmgr).InnerText;
        string str = string.Format(string.Empty + "<RSAKeyValue>" + "<Modulus>{0}</Modulus>" + "<Exponent>{1}</Exponent>" + "</RSAKeyValue>" + "<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>", (object) innerText1, (object) innerText2);
        int num = (int) MessageBox.Show(str);
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider();
        cryptoServiceProvider.FromXmlString(str);
        SignedXml signedXml = new SignedXml(document);
        XmlNodeList elementsByTagName = document.GetElementsByTagName("Signature");
        signedXml.LoadXml((XmlElement) elementsByTagName[0]);
        return signedXml.CheckSignature((AsymmetricAlgorithm) cryptoServiceProvider);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
        return false;
      }
    }

    private string trasnformaIso(string texto)
    {
      Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
      Encoding utF8 = Encoding.UTF8;
      byte[] bytes1 = utF8.GetBytes(texto);
      byte[] bytes2 = Encoding.Convert(utF8, encoding, bytes1);
      return encoding.GetString(bytes2);
    }
  }
}
