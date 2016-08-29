 
// Type: Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML.FuncionesComunes
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML
{
  public class FuncionesComunes
  {
    private static bool verbose = false;

    public static RSACryptoServiceProvider crearRsaDesdePEM(string base64)
    {
      base64 = base64.Replace("-----BEGIN RSA PRIVATE KEY-----", string.Empty);
      base64 = base64.Replace("-----END RSA PRIVATE KEY-----", string.Empty);
      return FuncionesComunes.DecodeRSAPrivateKey(Convert.FromBase64String(base64));
    }

    public static RSACryptoServiceProvider crearRsaDesdePEMPublic(string base64)
    {
      base64 = base64.Replace("-----BEGIN RSA PRIVATE KEY-----", string.Empty);
      base64 = base64.Replace("-----END RSA PRIVATE KEY-----", string.Empty);
      return FuncionesComunes.DecodeRSAPrivateKey(Convert.FromBase64String(base64));
    }

    public static RSACryptoServiceProvider DecodeRSAPrivateKey(byte[] privkey)
    {
      BinaryReader binr = new BinaryReader((Stream) new MemoryStream(privkey));
      try
      {
        switch (binr.ReadUInt16())
        {
          case (ushort) 33072:
            int num1 = (int) binr.ReadByte();
            break;
          case (ushort) 33328:
            int num2 = (int) binr.ReadInt16();
            break;
          default:
            return (RSACryptoServiceProvider) null;
        }
        if ((int) binr.ReadUInt16() != 258 || (int) binr.ReadByte() != 0)
          return (RSACryptoServiceProvider) null;
        int integerSize1 = FuncionesComunes.GetIntegerSize(binr);
        byte[] data1 = binr.ReadBytes(integerSize1);
        int integerSize2 = FuncionesComunes.GetIntegerSize(binr);
        byte[] data2 = binr.ReadBytes(integerSize2);
        int integerSize3 = FuncionesComunes.GetIntegerSize(binr);
        byte[] data3 = binr.ReadBytes(integerSize3);
        int integerSize4 = FuncionesComunes.GetIntegerSize(binr);
        byte[] data4 = binr.ReadBytes(integerSize4);
        int integerSize5 = FuncionesComunes.GetIntegerSize(binr);
        byte[] data5 = binr.ReadBytes(integerSize5);
        int integerSize6 = FuncionesComunes.GetIntegerSize(binr);
        byte[] data6 = binr.ReadBytes(integerSize6);
        int integerSize7 = FuncionesComunes.GetIntegerSize(binr);
        byte[] data7 = binr.ReadBytes(integerSize7);
        int integerSize8 = FuncionesComunes.GetIntegerSize(binr);
        byte[] data8 = binr.ReadBytes(integerSize8);
        Console.WriteLine("showing components ..");
        if (FuncionesComunes.verbose)
        {
          FuncionesComunes.showBytes("\nModulus", data1);
          FuncionesComunes.showBytes("\nExponent", data2);
          FuncionesComunes.showBytes("\nD", data3);
          FuncionesComunes.showBytes("\nP", data4);
          FuncionesComunes.showBytes("\nQ", data5);
          FuncionesComunes.showBytes("\nDP", data6);
          FuncionesComunes.showBytes("\nDQ", data7);
          FuncionesComunes.showBytes("\nIQ", data8);
        }
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(1024, new CspParameters()
        {
          Flags = CspProviderFlags.UseMachineKeyStore
        });
        cryptoServiceProvider.ImportParameters(new RSAParameters()
        {
          Modulus = data1,
          Exponent = data2,
          D = data3,
          P = data4,
          Q = data5,
          DP = data6,
          DQ = data7,
          InverseQ = data8
        });
        return cryptoServiceProvider;
      }
      catch
      {
        return (RSACryptoServiceProvider) null;
      }
      finally
      {
        binr.Close();
      }
    }

    private static int GetIntegerSize(BinaryReader binr)
    {
      if ((int) binr.ReadByte() != 2)
        return 0;
      byte num1 = binr.ReadByte();
      int num2;
      switch (num1)
      {
        case (byte) 129:
          num2 = (int) binr.ReadByte();
          break;
        case (byte) 130:
          byte num3 = binr.ReadByte();
          num2 = BitConverter.ToInt32(new byte[4]
          {
            binr.ReadByte(),
            num3,
            (byte) 0,
            (byte) 0
          }, 0);
          break;
        default:
          num2 = (int) num1;
          break;
      }
      while ((int) binr.ReadByte() == 0)
        --num2;
      binr.BaseStream.Seek(-1L, SeekOrigin.Current);
      return num2;
    }

    private static void showBytes(string info, byte[] data)
    {
      Console.WriteLine("{0} [{1} bytes]", (object) info, (object) data.Length);
      for (int index = 1; index <= data.Length; ++index)
      {
        Console.Write("{0:X2} ", (object) data[index - 1]);
        if (index % 16 == 0)
          Console.WriteLine();
      }
      Console.WriteLine("\n\n");
    }

    public static X509Certificate2 RecuperarCertificado(string CN)
    {
      X509Certificate2 x509Certificate2 = (X509Certificate2) null;
      if (string.IsNullOrEmpty(CN) || CN.Length == 0)
        return (X509Certificate2) null;
      try
      {
        X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
        x509Store.Open(OpenFlags.ReadOnly);
        X509Certificate2Collection certificate2Collection = x509Store.Certificates.Find(X509FindType.FindByTimeValid, (object) DateTime.Now, false).Find(X509FindType.FindBySubjectName, (object) CN, false);
        if (certificate2Collection != null && certificate2Collection.Count != 0)
          x509Certificate2 = certificate2Collection[0];
        x509Store.Close();
      }
      catch (Exception ex)
      {
        x509Certificate2 = (X509Certificate2) null;
      }
      return x509Certificate2;
    }

    public static void firmarDocumentoXml(ref XmlDocument xmldocument, X509Certificate2 certificado, string referenciaUri)
    {
        try
        {
            SignedXml signedXml = new SignedXml(xmldocument);
            signedXml.SigningKey = certificado.PrivateKey;
            System.Security.Cryptography.Xml.Signature signature = signedXml.Signature;
            signature.SignedInfo.AddReference(new Reference()
            {
                Uri = referenciaUri
            });
            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause((KeyInfoClause)new RSAKeyValue((RSA)certificado.PrivateKey));
            keyInfo.AddClause((KeyInfoClause)new KeyInfoX509Data((X509Certificate)certificado));
            signature.KeyInfo = keyInfo;
            signedXml.ComputeSignature();
            XmlElement xml = signedXml.GetXml();
            xmldocument.DocumentElement.AppendChild(xmldocument.ImportNode((XmlNode)xml, true));
        }
        catch (Exception ex)
        {

        }
    }

    public static List<string> ValidarSchema(string uriDte, string uriSchema)
    {
      List<string> errores = new List<string>();
       try
      {
        XmlSchemaSet schemas = new XmlSchemaSet();
        schemas.Add("http://www.sii.cl/SiiDte", uriSchema);
        System.Xml.Schema.Extensions.Validate(XDocument.Load(uriDte), schemas, (ValidationEventHandler) ((o, e) => errores.Add(e.Message)));
      }
      catch (Exception ex)
      {
          if (ex.Message != "Faceta de restricción de MaxInclusive no válida - La cadena '999999999999999999999999999999.9999' no es un valor Decimal válido.")
          {
              errores.Add("Error al intentar validar schema contra documento xml " + ex.Message);
          }
      
      }
      return errores;
    }
    public static List<string> ValidarSchema(string uriDte, string uriSchema, string tipo)
    {
        List<string> errores = new List<string>();
        if (tipo != "boleta")
        {
            try
            {
                XmlSchemaSet schemas = new XmlSchemaSet();
                schemas.Add("http://www.sii.cl/SiiDte", uriSchema);
                System.Xml.Schema.Extensions.Validate(XDocument.Load(uriDte), schemas, (ValidationEventHandler)((o, e) => errores.Add(e.Message)));
            }
            catch (Exception ex)
            {
                errores.Add("Error al intentar validar schema contra documento xml " + ex.Message);
            }
        }
        return errores;
    }
    public static bool verificarCaffff()
    {
      string s1 = "<DA>\r\n" + "<RE>76256545-5</RE>\r\n" + "<RS>CONSORCIO AEROPORTUARIO DE LA SERENA S.A</RS>\r\n" + "<TD>33</TD>\r\n" + "<RNG><D>1</D><H>100</H></RNG>\r\n" + "<FA>2013-02-18</FA>\r\n" + "<RSAPK><M>nQmHDN4bQPeiv3fySXid4oTHBU3KNCKLUZ7fC4uNvQFnlThcRfmZMCjdojScaG+jQvgkLp1A/eLDNQdUNgVj6w==</M><E>Aw==</E></RSAPK>\r\n" + "<IDK>100</IDK>\r\n" + "</DA>\r\n";
      string xmlString = "<RSAKeyValue><Modulus>nQmHDN4bQPeiv3fySXid4oTHBU3KNCKLUZ7fC4uNvQFnlThcRfmZMCjdojScaG+jQvgkLp1A/eLDNQdUNgVj6w==</Modulus><Exponent>Aw==</Exponent></RSAKeyValue>";
      string s2 = "v9WScHNso/yuJOb95hzlgxT4QiRWHwrdoFLvQL2G2vGS5glgtgOTYn2uehmzXefA3IOLoTYglAjX1WGlipUrVA==";
      byte[] hash1 = new SHA1CryptoServiceProvider().ComputeHash(new ASCIIEncoding().GetBytes(s1));
      byte[] hash2 = new SHA1CryptoServiceProvider().ComputeHash(Convert.FromBase64String(s2));
      RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider();
      cryptoServiceProvider.FromXmlString(xmlString);
      cryptoServiceProvider.VerifyHash(hash1, "SHA1", hash2);
      return false;
    }
  }
}
