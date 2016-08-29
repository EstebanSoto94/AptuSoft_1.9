 
// Type: Aptusoft.CentroCosto
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  internal class CentroCosto
  {
    private Conexion conexion = Conexion.getConecta();

    public List<CentroCostoVO> cosultaCentroCosto()
    {
      List<CentroCostoVO> list = new List<CentroCostoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idCentroCosto, nombreCentroCosto FROM centrocosto ORDER BY idCentroCosto";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        CentroCostoVO centroCostoVo = new CentroCostoVO()
        {
          IdCentroCosto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCentroCosto"].ToString()),
          NombreCentroCosto = ((DbDataReader) mySqlDataReader)["nombreCentroCosto"].ToString()
        };
        list.Add(centroCostoVo);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void agregaCentroCosto(string _centro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO centrocosto (nombreCentroCosto) VALUES(@Nombre)";
      command.Parameters.AddWithValue("@Nombre", (object) _centro);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public bool buscaCentroCostoDesc(string _centro)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT * FROM centrocosto WHERE nombreCentroCosto = @Nombre";
      command.Parameters.AddWithValue("@Nombre", (object) _centro);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void actualizaCentroCosto(CentroCostoVO centro)
    {
      ((DbCommand) new MySqlCommand(string.Format("UPDATE centrocosto SET nombreCentroCosto='{0}' WHERE idCentroCosto={1}", (object) centro.NombreCentroCosto, (object) centro.IdCentroCosto), this.conexion.ConexionMySql)).ExecuteNonQuery();
    }

    public void eliminaCentroCosto(int _id)
    {
      string format = "DELETE FROM centrocosto WHERE idCentroCosto={0}";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = string.Format(format, (object) _id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<CentroCostoVO> listaCentroCostoVenta()
    {
      List<CentroCostoVO> list = new List<CentroCostoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idCentroCosto, nombreCentroCosto FROM centrocosto ORDER BY idCentroCosto";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new CentroCostoVO()
      {
        IdCentroCosto = 0,
        NombreCentroCosto = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new CentroCostoVO()
        {
          IdCentroCosto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCentroCosto"].ToString()),
          NombreCentroCosto = ((DbDataReader) mySqlDataReader)["nombreCentroCosto"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
