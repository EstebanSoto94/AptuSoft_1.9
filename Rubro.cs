 
// Type: Aptusoft.Rubro
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class Rubro
  {
    private Conexion conexion = Conexion.getConecta();

    public List<RubroVO> listaRubros()
    {
      List<RubroVO> list = new List<RubroVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idRubro, nombreRubro FROM rubros ORDER BY nombreRubro";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      RubroVO rubroVo = new RubroVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new RubroVO()
        {
          IdRubro = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idRubro"].ToString()),
          NombreRubro = ((DbDataReader) mySqlDataReader)["nombreRubro"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<RubroVO> listaRubrosConSeleccione()
    {
      List<RubroVO> list = new List<RubroVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idRubro, nombreRubro FROM rubros ORDER BY nombreRubro";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new RubroVO()
      {
        IdRubro = 0,
        NombreRubro = "[TODOS]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new RubroVO()
        {
          IdRubro = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idRubro"].ToString()),
          NombreRubro = ((DbDataReader) mySqlDataReader)["nombreRubro"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public bool buscaRubroDesc(string nombreRubro)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT * FROM rubros WHERE nombreRubro = @nombreRubro";
      command.Parameters.AddWithValue("@nombreRubro", (object) nombreRubro);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void agregaRubro(string nombreRubro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO rubros (nombreRubro) VALUES(@nombreRubro)";
      command.Parameters.AddWithValue("@nombreRubro", (object) nombreRubro);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaRubro(RubroVO ru)
    {
      ((DbCommand) new MySqlCommand(string.Format("UPDATE rubros SET nombreRubro='{0}' WHERE idRubro={1}", (object) ru.NombreRubro, (object) ru.IdRubro), this.conexion.ConexionMySql)).ExecuteNonQuery();
    }

    public void eliminaRubro(int _id)
    {
      string format = "DELETE FROM rubros WHERE idRubro={0}";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = string.Format(format, (object) _id);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
