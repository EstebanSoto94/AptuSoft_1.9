 
// Type: Aptusoft.FacturaElectronica.Clases.EnviosSII.Semilla
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Aptusoft.FacturaElectronica.Clases.EnviosSII
{
  public class Semilla
  {
    private static string xmlSemillaFirmada = "";
    private static RespuestaSemilla semilla;
    private static XmlDocument xmlSemilla;
    private static Aptusoft.cl.sii.palena.semilla.CrSeedService servicioSemillaPalena;
    private static Aptusoft.cl.sii.maullin.semilla.CrSeedService servicioSemillaMaullin;

    public static string SolicitarSemilla(char ambiente, string nombreCertificado)
    {
      Semilla.xmlSemilla = new XmlDocument();
      switch (ambiente)
      {
        case 'M':
          Semilla.servicioSemillaMaullin = new Aptusoft.cl.sii.maullin.semilla.CrSeedService();
          Semilla.xmlSemilla.LoadXml(Semilla.servicioSemillaMaullin.getSeed());
          break;
        case 'P':
          Semilla.servicioSemillaPalena = new Aptusoft.cl.sii.palena.semilla.CrSeedService();
          Semilla.xmlSemilla.LoadXml(Semilla.servicioSemillaPalena.getSeed());
          break;
      }
      if (Semilla.xmlSemilla != null)
      {
        Semilla.semilla = new RespuestaSemilla()
        {
          Semilla = Semilla.xmlSemilla.SelectNodes("//SEMILLA").Item(0).InnerXml,
          Estado = Semilla.xmlSemilla.SelectNodes("//ESTADO").Item(0).InnerXml
        };
        if (!Semilla.semilla.Estado.Equals("00"))
        {
          int num = (int) MessageBox.Show("ERROR " + Semilla.semilla.Estado);
        }
        Semilla.FirmarSemilla(nombreCertificado);
      }
      return Semilla.xmlSemillaFirmada;
    }

    private static void FirmarSemilla(string nombreCertificado)
    {
      XmlDocument xmldocument = Semilla.ToXmlDocument(new XDocument(new object[1]
      {
        (object) new XElement((XName) "getToken", (object) new XElement((XName) "item", (object) new XElement((XName) "Semilla", (object) Semilla.semilla.Semilla)))
      }));
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(nombreCertificado);
      Semilla.firmarDocumentoXml(ref xmldocument, certificado, "");
      Semilla.xmlSemillaFirmada = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n";
      Semilla.xmlSemillaFirmada += xmldocument.OuterXml;
    }

    private static XmlDocument ToXmlDocument(XDocument xDocument)
    {
      XmlDocument xmlDocument = new XmlDocument();
      using (XmlReader reader = xDocument.CreateReader())
        xmlDocument.Load(reader);
      return xmlDocument;
    }

    public static void firmarDocumentoXml(ref XmlDocument xmldocument, X509Certificate2 certificado, string referenciaUri)
    {
      SignedXml signedXml = new SignedXml(xmldocument);
      signedXml.SigningKey = certificado.PrivateKey;
      Signature signature = signedXml.Signature;
      RSAKeyValue rsaKeyValue = new RSAKeyValue((RSA) certificado.PublicKey.Key);
      signature.KeyInfo.AddClause((KeyInfoClause) rsaKeyValue);
      KeyInfoX509Data keyInfoX509Data = new KeyInfoX509Data((X509Certificate) certificado);
      signature.KeyInfo.AddClause((KeyInfoClause) keyInfoX509Data);
      Reference reference = new Reference();
      reference.Uri = "";
      XmlDsigEnvelopedSignatureTransform signatureTransform = new XmlDsigEnvelopedSignatureTransform();
      reference.AddTransform((Transform) signatureTransform);
      signedXml.AddReference(reference);
      signedXml.ComputeSignature();
      XmlNode node = (XmlNode) signedXml.GetXml();
      xmldocument.DocumentElement.AppendChild(xmldocument.ImportNode(node, true));
    }
  }
}
