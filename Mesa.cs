 
// Type: Aptusoft.Mesa
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class Mesa
  {
    private Conexion conexion = Conexion.getConecta();

    public List<MesaVO> listaMesas()
    {
      List<MesaVO> list = new List<MesaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idMesa, nombreMesa, garzon, estado, folioComanda\r\n                                                    FROM mesas ORDER BY idMesa asc";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new MesaVO()
        {
          IdMesa = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMesa"].ToString()),
          NombreMesa = ((DbDataReader) mySqlDataReader)["nombreMesa"].ToString(),
          Garzon = ((DbDataReader) mySqlDataReader)["garzon"].ToString(),
          Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString(),
          FolioComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioComanda"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<MesaVO> listaMesasDisponibles()
    {
      List<MesaVO> list = new List<MesaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idMesa, nombreMesa, garzon, estado, folioComanda\r\n                                                    FROM mesas WHERE estado='DISPONIBLE' ORDER BY idMesa asc";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new MesaVO()
        {
          IdMesa = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMesa"].ToString()),
          NombreMesa = ((DbDataReader) mySqlDataReader)["nombreMesa"].ToString(),
          Garzon = ((DbDataReader) mySqlDataReader)["garzon"].ToString(),
          Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString(),
          FolioComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioComanda"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void cambiaEstadoMesa(string mesa, string estado, string folioComanda, string garzon)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE mesas SET estado=@estado, folioComanda=@folioComanda, garzon=@garzon\r\n                                    WHERE nombreMesa=@mesa";
      command.Parameters.AddWithValue("@estado", (object) estado);
      command.Parameters.AddWithValue("@folioComanda", (object) folioComanda);
      command.Parameters.AddWithValue("@garzon", (object) garzon);
      command.Parameters.AddWithValue("@mesa", (object) mesa);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
