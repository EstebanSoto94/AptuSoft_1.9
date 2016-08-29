 
// Type: Aptusoft.Banco
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class Banco
  {
    private Conexion conexion = Conexion.getConecta();

    public List<TipoVO> listaBancos()
    {
      List<TipoVO> list = new List<TipoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBanco, nombreBanco FROM banco ORDER BY idBanco";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      TipoVO tipoVo = new TipoVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new TipoVO()
        {
          IdTipo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBanco"].ToString()),
          NombreTipo = ((DbDataReader) mySqlDataReader)["nombreBanco"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void guardaBanco(string nombre)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO banco (nombreBanco) VALUES(@Nombrebanco)";
      command.Parameters.AddWithValue("@Nombrebanco", (object) nombre);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public TipoVO buscaBancoId(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBanco, nombreBanco FROM banco WHERE idBanco=@id";
      command.Parameters.AddWithValue("@id", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      TipoVO tipoVo = new TipoVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        tipoVo = new TipoVO();
        tipoVo.IdTipo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBanco"].ToString());
        tipoVo.NombreTipo = ((DbDataReader) mySqlDataReader)["nombreBanco"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return tipoVo;
    }

    public bool buscaBancoNombre(string nombre)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBanco, nombreBanco FROM banco WHERE nombreBanco=@nombre";
      command.Parameters.AddWithValue("@nombre", (object) nombre);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      bool flag = false;
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void modificaBanco(TipoVO _banco)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE banco SET nombreBanco=@Nombre WHERE idBanco=@Id";
      command.Parameters.AddWithValue("@Nombre", (object) _banco.NombreTipo);
      command.Parameters.AddWithValue("@Id", (object) _banco.IdTipo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaBanco(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM banco WHERE idBanco=@Id";
      command.Parameters.AddWithValue("@Id", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
