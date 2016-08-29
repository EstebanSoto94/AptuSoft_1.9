 
// Type: Aptusoft.ControlFiscal
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Data.Common;

namespace Aptusoft
{
  public class ControlFiscal
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaZ(string caja)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO controlfiscal (numero, fecha, usuario) VALUES(@numero, @fecha, @usuario)";
      command.Parameters.AddWithValue("@numero", (object) caja);
      command.Parameters.AddWithValue("@fecha", (object) DateTime.Now);
      command.Parameters.AddWithValue("@usuario", (object) frmMenuPrincipal.listaUsuario[0].NombreUsuario);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public double ultimaZ()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MIN(fechaEmision) AS 'fecha' FROM boletasfiscal WHERE fechaEmision >= (SELECT Max(fecha) FROM controlfiscal WHERE numero=@caja) AND caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) frmMenuPrincipal.listaUsuario[0].IdCaja.ToString());
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      DateTime dateTime = DateTime.Now;
      while (((DbDataReader) mySqlDataReader).Read())
        dateTime = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? DateTime.Now : Convert.ToDateTime(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return (DateTime.Now - dateTime).TotalHours;
    }

    public double ultimaZSinCOntrolFiscal(string caja)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MIN(fechaEmision) AS 'fecha' FROM boletasfiscal WHERE fechaEmision >= (SELECT Max(fechaEmision) FROM boletasfiscal WHERE caja=@caja) AND caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      DateTime dateTime = DateTime.Now;
      while (((DbDataReader) mySqlDataReader).Read())
        dateTime = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? DateTime.Now : Convert.ToDateTime(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return (DateTime.Now - dateTime).TotalHours;
    }
  }
}
