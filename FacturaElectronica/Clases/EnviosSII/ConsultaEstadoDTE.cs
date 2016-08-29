
using System.Xml;
namespace Aptusoft.FacturaElectronica.Clases.EnviosSII
{
    public class ConsultaEstadoDTE
    {
        private static Aptusoft.cl.sii.maullin.consultaDTE.QueryEstDteService servicioConsultaMaullin;
        private static Aptusoft.cl.sii.palena.consultaDTE.QueryEstDteService servicioConsultaPalena;
        private static XmlDocument xmlRespuestaSII;
        private static RespuestaToken token;

        public static RespuestaConsultaEstadoDTE ConsultaDTE(char ambiente, string rutCertificado, string rutEmpresa, string rutCliente, string tipoDte, string folioDte, string fecha, string monto, string nombreCertificado, string tokenString = null)
        {
            rutCertificado = rutCertificado.Replace("-", string.Empty);
            rutEmpresa = rutEmpresa.Replace("-", string.Empty);
            rutCliente = rutCliente.Replace("-", string.Empty);
            string RutConsultante = rutCertificado.Substring(0, rutCertificado.Length - 1);
            string DvConsultante = rutCertificado.Substring(rutCertificado.Length - 1);
            string RutCompania = rutEmpresa.Substring(0, rutEmpresa.Length - 1);
            string DvCompania = rutEmpresa.Substring(rutEmpresa.Length - 1);
            string RutReceptor = rutCliente.Substring(0, rutCliente.Length - 1);
            string DvReceptor = rutCliente.Substring(rutCliente.Length - 1);
            RespuestaConsultaEstadoDTE consultaEstadoDte = new RespuestaConsultaEstadoDTE();
            ConsultaEstadoDTE.xmlRespuestaSII = new XmlDocument();
            if (string.IsNullOrEmpty(tokenString))
                ConsultaEstadoDTE.token = Token.SolicitarToken(ambiente, nombreCertificado);
            else
                ConsultaEstadoDTE.token = new RespuestaToken()
                {
                    Token = tokenString
                };
            switch (ambiente)
            {
                case 'M':
                    ConsultaEstadoDTE.servicioConsultaMaullin = new Aptusoft.cl.sii.maullin.consultaDTE.QueryEstDteService();
                    ConsultaEstadoDTE.xmlRespuestaSII.LoadXml(ConsultaEstadoDTE.servicioConsultaMaullin.getEstDte(RutConsultante, DvConsultante, RutCompania, DvCompania, RutReceptor, DvReceptor, tipoDte, folioDte, fecha, monto, ConsultaEstadoDTE.token.Token));
                    break;
                case 'P':
                    try
                    {
                        ConsultaEstadoDTE.servicioConsultaPalena = new Aptusoft.cl.sii.palena.consultaDTE.QueryEstDteService();
                        ConsultaEstadoDTE.xmlRespuestaSII.LoadXml(ConsultaEstadoDTE.servicioConsultaPalena.getEstDte(RutConsultante, DvConsultante, RutCompania, DvCompania, RutReceptor, DvReceptor, tipoDte, folioDte, fecha, monto, ConsultaEstadoDTE.token.Token));
                    }
                    catch
                    {
                        ConsultaEstadoDTE.servicioConsultaPalena = new Aptusoft.cl.sii.palena.consultaDTE.QueryEstDteService();
                        ConsultaEstadoDTE.xmlRespuestaSII.LoadXml(ConsultaEstadoDTE.servicioConsultaPalena.getEstDte(RutConsultante, DvConsultante, RutCompania, DvCompania, RutReceptor, DvReceptor, tipoDte, folioDte, fecha, monto, ConsultaEstadoDTE.token.Token));
                    
                    }
                        break;
            }
            if (ConsultaEstadoDTE.xmlRespuestaSII != null)
            {
                consultaEstadoDte = new RespuestaConsultaEstadoDTE();
                consultaEstadoDte.Estado = ConsultaEstadoDTE.xmlRespuestaSII.SelectNodes("//ESTADO").Item(0).InnerXml;
                consultaEstadoDte.Glosa = ConsultaEstadoDTE.xmlRespuestaSII.SelectSingleNode("//GLOSA") == null ? "" : ConsultaEstadoDTE.xmlRespuestaSII.SelectNodes("//GLOSA").Item(0).InnerXml;
                consultaEstadoDte.ERR_CODE = ConsultaEstadoDTE.xmlRespuestaSII.SelectSingleNode("//ERR_CODE") == null ? "" : ConsultaEstadoDTE.xmlRespuestaSII.SelectNodes("//ERR_CODE").Item(0).InnerXml;
                consultaEstadoDte.GlosaErr = ConsultaEstadoDTE.xmlRespuestaSII.SelectSingleNode("//GLOSA_ERR") == null ? "" : ConsultaEstadoDTE.xmlRespuestaSII.SelectNodes("//GLOSA_ERR").Item(0).InnerXml;
                consultaEstadoDte.NumeroAtencion = ConsultaEstadoDTE.xmlRespuestaSII.SelectNodes("//NUM_ATENCION").Item(0).InnerXml;
            }
            return consultaEstadoDte;
        }
    }
}
