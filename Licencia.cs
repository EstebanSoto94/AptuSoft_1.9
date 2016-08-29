 
// Type: Aptusoft.Licencia
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class Licencia
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaLicencia(LicenciaVO li)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO licencias (idCliente, rut, mac, clave, contraclave, fechaInstalacion, contacto) \r\n                                VALUES(@idCliente, @rut, @mac, @clave, @contraclave, @fechaInstalacion, @contacto)";
      command.Parameters.AddWithValue("@idCliente", (object) li.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) li.Rut);
      command.Parameters.AddWithValue("@mac", (object) li.Mac);
      command.Parameters.AddWithValue("@clave", (object) li.Clave);
      command.Parameters.AddWithValue("@contraclave", (object) li.ContraClave);
      command.Parameters.AddWithValue("@fechaInstalacion", (object) li.Fecha);
      command.Parameters.AddWithValue("@contacto", (object) li.Contacto);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaLicencia(LicenciaVO li)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE licencias SET idCliente=@idCliente, rut=@rut, mac=@mac, clave=@clave, contraclave=@contraclave, fechaInstalacion=@fechaInstalacion, contacto=@contacto WHERE idLicencia=@idLicencia";
      command.Parameters.AddWithValue("@idLicencia", (object) li.IdLicencia);
      command.Parameters.AddWithValue("@idCliente", (object) li.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) li.Rut);
      command.Parameters.AddWithValue("@mac", (object) li.Mac);
      command.Parameters.AddWithValue("@clave", (object) li.Clave);
      command.Parameters.AddWithValue("@contraclave", (object) li.ContraClave);
      command.Parameters.AddWithValue("@fechaInstalacion", (object) li.Fecha);
      command.Parameters.AddWithValue("@contacto", (object) li.Contacto);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<LicenciaVO> listaLicencia(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idLicencia, idCliente, rut, mac, clave, contraclave, fechaInstalacion, contacto \r\n                                    FROM licencias WHERE idCliente=@idCliente ORDER BY idLicencia";
      command.Parameters.AddWithValue("@idCliente", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<LicenciaVO> list = new List<LicenciaVO>();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new LicenciaVO()
        {
          IdLicencia = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idLicencia"].ToString()),
          IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString()),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString(),
          Mac = ((DbDataReader) mySqlDataReader)["mac"].ToString(),
          Clave = ((DbDataReader) mySqlDataReader)["clave"].ToString(),
          ContraClave = ((DbDataReader) mySqlDataReader)["contraclave"].ToString(),
          Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString(),
          Fecha = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaInstalacion"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void eliminaLicencia(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM licencias WHERE idLicencia=@id";
      command.Parameters.AddWithValue("@id", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
