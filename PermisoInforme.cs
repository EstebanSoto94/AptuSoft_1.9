 
// Type: Aptusoft.PermisoInforme
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class PermisoInforme
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaPermisoInforme(List<InformeVO> lista)
    {
      foreach (InformeVO inVO in lista)
      {
        this.eliminaPermisoInforme(inVO.IdDetalleInforme);
        this.agregaPermisoInforme(inVO);
      }
    }

    private void agregaPermisoInforme(InformeVO inVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detalleinformes (idTipoUsuario, tipoUsuario, modulo, informe, codigoInforme, ingresar) \r\n                                                   VALUES(@idTipoUsuario, @tipoUsuario, @modulo, @informe, @codigoInforme, @ingresar)";
      command.Parameters.AddWithValue("@idTipoUsuario", (object) inVO.IdTipoUsuario);
      command.Parameters.AddWithValue("@tipoUsuario", (object) inVO.TipoUsuario);
      command.Parameters.AddWithValue("@modulo", (object) inVO.Modulo);
      command.Parameters.AddWithValue("@informe", (object) inVO.Informe);
      command.Parameters.AddWithValue("@codigoInforme", (object) inVO.CodigoInforme);
      command.Parameters.AddWithValue("@ingresar", (inVO.Ingresar ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    private void eliminaPermisoInforme(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detalleinformes WHERE idDetalleInforme=@id";
      command.Parameters.AddWithValue("@id", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaPermisoInformeIdTipoUsuario(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detalleinformes WHERE idTipoUsuario=@id";
      command.Parameters.AddWithValue("@id", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<InformeVO> listaPermisosInforme(string tipo)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleInforme, idTipoUsuario, tipoUsuario, modulo, informe, codigoInforme, ingresar \r\n                                    FROM detalleinformes\r\n                                    WHERE tipoUsuario=@tipo ORDER BY modulo";
      command.Parameters.AddWithValue("@tipo", (object) tipo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<InformeVO> list = new List<InformeVO>();
      InformeVO informeVo = new InformeVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new InformeVO()
        {
          IdDetalleInforme = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleInforme"].ToString()),
          IdTipoUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoUsuario"].ToString()),
          TipoUsuario = ((DbDataReader) mySqlDataReader)["tipoUsuario"].ToString(),
          Modulo = ((DbDataReader) mySqlDataReader)["modulo"].ToString(),
          Informe = ((DbDataReader) mySqlDataReader)["informe"].ToString(),
          CodigoInforme = ((DbDataReader) mySqlDataReader)["codigoInforme"].ToString(),
          Ingresar = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["ingresar"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
