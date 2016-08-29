 
// Type: Aptusoft.Periodo
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class Periodo
  {
    private Conexion conexion = Conexion.getConecta();

    public List<PeriodoVO> listaPeriodos()
    {
      List<PeriodoVO> list = new List<PeriodoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idPeriodo, nombre, visible, enCurso FROM periodocontable ORDER BY idPeriodo";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      int num = 1;
      while (((DbDataReader) mySqlDataReader).Read())
      {
        PeriodoVO periodoVo = new PeriodoVO();
        periodoVo.Linea = num;
        periodoVo.IdPeriodo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPeriodo"]);
        periodoVo.Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString();
        periodoVo.Visible = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["visible"]);
        periodoVo.EnCurso = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enCurso"]);
        ++num;
        list.Add(periodoVo);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<PeriodoVO> listaPeriodosCombo()
    {
      List<PeriodoVO> list = new List<PeriodoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idPeriodo, nombre, visible, enCurso FROM periodocontable ORDER BY enCurso DESC";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new PeriodoVO()
      {
        IdPeriodo = 0,
        Nombre = "SIN PERIODO",
        Visible = false,
        EnCurso = false
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new PeriodoVO()
        {
          IdPeriodo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPeriodo"]),
          Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString(),
          Visible = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["visible"]),
          EnCurso = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enCurso"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void guardaPeriodo(PeriodoVO peVO)
    {
      if (peVO.EnCurso)
        this.cambiaEstadoPeriodo();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO periodocontable(nombre, visible, enCurso) VALUES(@nombre, @visible, @enCurso)";
      command.Parameters.AddWithValue("@nombre", (object) peVO.Nombre);
      command.Parameters.AddWithValue("@visible", (peVO.Visible ? 1 : 0));
      command.Parameters.AddWithValue("@enCurso", (peVO.EnCurso ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoPeriodo()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE periodocontable SET enCurso=0";
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaPeriodo(PeriodoVO peVO)
    {
      if (peVO.EnCurso)
        this.cambiaEstadoPeriodo();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE periodocontable SET nombre=@nombre, visible=@visible, enCurso=@enCurso WHERE idPeriodo=@idPeriodo";
      command.Parameters.AddWithValue("@nombre", (object) peVO.Nombre);
      command.Parameters.AddWithValue("@visible", (peVO.Visible ? 1 : 0));
      command.Parameters.AddWithValue("@enCurso", (peVO.EnCurso ? 1 : 0));
      command.Parameters.AddWithValue("@idPeriodo", (object) peVO.IdPeriodo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaPeriodo(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM periodocontable WHERE idPeriodo=@id";
      command.Parameters.AddWithValue("@id", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public PeriodoVO buscaPeriodoID(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idPeriodo, nombre, visible, enCurso FROM periodocontable WHERE idPeriodo=@id";
      command.Parameters.AddWithValue("@id", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      PeriodoVO periodoVo = new PeriodoVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        periodoVo = new PeriodoVO();
        periodoVo.IdPeriodo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPeriodo"]);
        periodoVo.Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString();
        periodoVo.Visible = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["visible"]);
        periodoVo.EnCurso = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enCurso"]);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return periodoVo;
    }

    public bool buscaPeriodoNombre(string nombre)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idPeriodo, nombre FROM periodocontable WHERE  nombre=@nombre";
      command.Parameters.AddWithValue("@nombre", (object) nombre);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      bool flag = false;
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }
  }
}
