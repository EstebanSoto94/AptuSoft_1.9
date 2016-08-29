 
// Type: Aptusoft.FacturaElectronica.Clases.Emisor
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class Emisor
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaEmisor(EmisorVO em)
    {
      this.eliminaEmisor();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO electronica_emisor (                                                        \r\n                                                        rutEmisor,\r\n                                                        razonSocialEmisor,\r\n                                                        giroEmisor,\r\n                                                        codActEco,\r\n                                                        codigoSucursal,\r\n                                                        direccionSucursal,\r\n                                                        comunaSucursal,\r\n                                                        ciudadSucursal,\r\n                                                        numeroResolucion,\r\n                                                        fechaResolucion,\r\n                                                        certificadoDigital,\r\n                                                        rutCertificado,\r\n                                                        simulacion\r\n                                                        )\r\n                                    VALUES(\r\n                                                        @rutEmisor,\r\n                                                        @razonSocialEmisor,\r\n                                                        @giroEmisor,\r\n                                                        @codActEco,\r\n                                                        @codigoSucursal,\r\n                                                        @direccionSucursal,\r\n                                                        @comunaSucursal,\r\n                                                        @ciudadSucursal,\r\n                                                        @numeroResolucion,\r\n                                                        @fechaResolucion,\r\n                                                        @certificadoDigital,\r\n                                                        @rutCertificado,\r\n                                                        @simulacion\r\n                                                        )";
      command.Parameters.AddWithValue("@rutEmisor", (object) em.RutEmisior);
      command.Parameters.AddWithValue("@razonSocialEmisor", (object) em.RazonSocial);
      command.Parameters.AddWithValue("@giroEmisor", (object) em.Giro);
      command.Parameters.AddWithValue("@codActEco", (object) em.CodActCome);
      command.Parameters.AddWithValue("@codigoSucursal", (object) em.CodSucursal);
      command.Parameters.AddWithValue("@direccionSucursal", (object) em.Direccion);
      command.Parameters.AddWithValue("@comunaSucursal", (object) em.Comuna);
      command.Parameters.AddWithValue("@ciudadSucursal", (object) em.Ciudad);
      command.Parameters.AddWithValue("@numeroResolucion", (object) em.NumeroResolucion);
      command.Parameters.AddWithValue("@fechaResolucion", (object) em.FechaResolucion);
      command.Parameters.AddWithValue("@certificadoDigital", (object) em.CertificadoDigital);
      command.Parameters.AddWithValue("@rutCertificado", (object) em.RutCertificado);
      command.Parameters.AddWithValue("@simulacion", (em.Simulacion ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaEmisor()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM electronica_emisor";
      ((DbCommand) command).ExecuteNonQuery();
    }

    public EmisorVO buscaEmisor()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  em.idEmisor,\r\n                                            em.rutEmisor,\r\n                                            em.razonSocialEmisor,\r\n                                            em.giroEmisor,\r\n                                            em.codActEco,\r\n                                            em.codigoSucursal,\r\n                                            em.direccionSucursal,\r\n                                            em.comunaSucursal,\r\n                                            em.ciudadSucursal,\r\n                                            em.numeroResolucion,\r\n                                            em.fechaResolucion,\r\n                                            em.certificadoDigital,\r\n                                            em.rutCertificado,\r\n                                            em.simulacion,\r\n                                            op.valoresVentaConIva\r\n                                    FROM electronica_emisor em, opcionesgenerales op";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      EmisorVO emisorVo = new EmisorVO();
      emisorVo.IdEmisor = 0;
      while (((DbDataReader) mySqlDataReader).Read())
      {
        emisorVo.IdEmisor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idEmisor"].ToString());
        emisorVo.RutEmisior = ((DbDataReader) mySqlDataReader)["rutEmisor"].ToString();
        emisorVo.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocialEmisor"].ToString();
        emisorVo.Giro = ((DbDataReader) mySqlDataReader)["giroEmisor"].ToString();
        emisorVo.CodActCome = ((DbDataReader) mySqlDataReader)["codActEco"].ToString();
        emisorVo.CodSucursal = ((DbDataReader) mySqlDataReader)["codigoSucursal"].ToString();
        emisorVo.Direccion = ((DbDataReader) mySqlDataReader)["direccionSucursal"].ToString();
        emisorVo.Comuna = ((DbDataReader) mySqlDataReader)["comunaSucursal"].ToString();
        emisorVo.Ciudad = ((DbDataReader) mySqlDataReader)["ciudadSucursal"].ToString();
        emisorVo.NumeroResolucion = ((DbDataReader) mySqlDataReader)["numeroResolucion"].ToString();
        emisorVo.FechaResolucion = ((DbDataReader) mySqlDataReader)["fechaResolucion"].ToString();
        emisorVo.CertificadoDigital = ((DbDataReader) mySqlDataReader)["certificadoDigital"].ToString();
        emisorVo.RutCertificado = ((DbDataReader) mySqlDataReader)["rutCertificado"].ToString();
        emisorVo.Simulacion = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["simulacion"]);
        emisorVo.ValoresConIva = ((DbDataReader) mySqlDataReader)["valoresVentaConIva"].ToString().Equals("1");
      }
      ((DbDataReader) mySqlDataReader).Close();
      return emisorVo;
    }
  }
}
