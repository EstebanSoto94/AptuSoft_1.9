 
// Type: Aptusoft.ControlCaja
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class ControlCaja
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaControlCaja(ControlCajaVO ccVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO controlcaja (fechaIngreso, tipoAccion, idTipoAcion, tipoMovimiento, idTipoMovimiento, monto, observaciones, caja) \r\n            VALUES (@fechaIngreso, @tipoAccion, @idTipoAcion, @tipoMovimiento, @idTipoMovimiento, @monto, @observaciones, @caja)";
      command.Parameters.AddWithValue("@fechaIngreso", (object) ccVO.FechaIngreso);
      command.Parameters.AddWithValue("@tipoAccion", (object) ccVO.TipoAccion);
      command.Parameters.AddWithValue("@idTipoAcion", (object) ccVO.IdTipoAcion);
      command.Parameters.AddWithValue("@tipoMovimiento", (object) ccVO.TipoMovimiento);
      command.Parameters.AddWithValue("@idTipoMovimiento", (object) ccVO.IdTipoMovimiento);
      command.Parameters.AddWithValue("@monto", (object) ccVO.Monto);
      command.Parameters.AddWithValue("@observaciones", (object) ccVO.Observaciones);
      command.Parameters.AddWithValue("@caja", (object) ccVO.Caja);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<ControlCajaVO> buscaControlCaja(int caja, DateTime fecha)
    {
      List<ControlCajaVO> list = new List<ControlCajaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idControlCaja, fechaIngreso, tipoAccion, idTipoAcion, tipoMovimiento, idTipoMovimiento, monto, observaciones, caja                                                                                      \r\n                                    FROM controlcaja WHERE caja=@caja AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') = DATE_FORMAT(@fecha, '%Y-%m-%d')";
      command.Parameters.AddWithValue("@caja", (object) caja);
      command.Parameters.AddWithValue("@fecha", (object) fecha);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ControlCajaVO()
        {
          IdControlCaja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idControlCaja"].ToString()),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          TipoAccion = ((DbDataReader) mySqlDataReader)["tipoAccion"].ToString(),
          IdTipoAcion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoAcion"].ToString()),
          TipoMovimiento = ((DbDataReader) mySqlDataReader)["tipoMovimiento"].ToString(),
          IdTipoMovimiento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoMovimiento"].ToString()),
          Monto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["monto"].ToString()),
          Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString(),
          Caja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["caja"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void modificaControlCaja(ControlCajaVO ccVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE controlcaja SET \r\n                                                            fechaIngreso=@fechaIngreso,\r\n                                                            tipoAccion=@tipoAccion,\r\n                                                            idTipoAcion=@idTipoAcion,\r\n                                                            tipoMovimiento=@tipoMovimiento,\r\n                                                            idTipoMovimiento=@idTipoMovimiento,\r\n                                                            monto=@monto,\r\n                                                            observaciones=@observaciones,\r\n                                                            caja=@caja \r\n                                    WHERE idControlCaja=@idControl";
      command.Parameters.AddWithValue("@idControl", (object) ccVO.IdControlCaja);
      command.Parameters.AddWithValue("@fechaIngreso", (object) ccVO.FechaIngreso);
      command.Parameters.AddWithValue("@tipoAccion", (object) ccVO.TipoAccion);
      command.Parameters.AddWithValue("@idTipoAcion", (object) ccVO.IdTipoAcion);
      command.Parameters.AddWithValue("@tipoMovimiento", (object) ccVO.TipoMovimiento);
      command.Parameters.AddWithValue("@idTipoMovimiento", (object) ccVO.IdTipoMovimiento);
      command.Parameters.AddWithValue("@monto", (object) ccVO.Monto);
      command.Parameters.AddWithValue("@observaciones", (object) ccVO.Observaciones);
      command.Parameters.AddWithValue("@caja", (object) ccVO.Caja);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaControlCaja(int idControl)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM controlcaja WHERE idControlCaja=@idControl";
      command.Parameters.AddWithValue("@idControl", (object) idControl);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public DataTable controlCajaInforme(string filtro)
    {
      List<ControlCajaVO> list = new List<ControlCajaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idControlCaja, fechaIngreso, tipoAccion, idTipoAcion, tipoMovimiento, idTipoMovimiento, monto, observaciones, caja                                                                                      \r\n                                    FROM controlcaja \r\n                                    WHERE " + filtro + " ORDER BY idControlCaja";
      DataTable dataTable = new DataTable();
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
