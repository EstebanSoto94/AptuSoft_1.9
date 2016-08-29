 
// Type: Aptusoft.FacturaElectronica.Clases.EnviosSII.Token
 
 
// version 1.8.0

using System.Windows.Forms;
using System.Xml;

namespace Aptusoft.FacturaElectronica.Clases.EnviosSII
{
  public class Token
  {
    private static RespuestaToken token;
    private static XmlDocument xmlToken;
    private static Aptusoft.cl.sii.palena.token.GetTokenFromSeedService servicioTokenPalena;
    private static Aptusoft.cl.sii.maullin.token.GetTokenFromSeedService servicioTokenMaullin;

    public static RespuestaToken SolicitarToken(char ambiente, string nombreCertificado)
    {
      Token.xmlToken = new XmlDocument();
      switch (ambiente)
      {
        case 'M':
          Token.servicioTokenMaullin = new Aptusoft.cl.sii.maullin.token.GetTokenFromSeedService();
          Token.xmlToken.LoadXml(Token.servicioTokenMaullin.getToken(Semilla.SolicitarSemilla(ambiente, nombreCertificado)));
          break;
        case 'P':
          Token.servicioTokenPalena = new Aptusoft.cl.sii.palena.token.GetTokenFromSeedService();
          Token.xmlToken.LoadXml(Token.servicioTokenPalena.getToken(Semilla.SolicitarSemilla(ambiente, nombreCertificado)));
          break;
      }
      if (Token.xmlToken != null)
      {
        Token.token = new RespuestaToken();
        Token.token.Token = Token.xmlToken.SelectNodes("//TOKEN").Item(0).InnerXml;
        Token.token.Estado = Token.xmlToken.SelectNodes("//ESTADO").Item(0).InnerXml;
        if (!Token.token.Estado.Equals("00"))
        {
          int num = (int) MessageBox.Show("ERROR " + Token.token.Estado);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("ERROR " + Token.token.Estado);
      }
      return Token.token;
    }
  }
}
