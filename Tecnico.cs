 
// Type: Aptusoft.Tecnico
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Tecnico
  {
    private Conexion conexion = Conexion.getConecta();

    public List<VendedorVO> listaTecnicos()
    {
      List<VendedorVO> list = new List<VendedorVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idTecnico, nombre FROM tecnicos ORDER BY idTecnico";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new VendedorVO()
      {
        IdVendedor = 0,
        Nombre = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new VendedorVO()
        {
          IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTecnico"].ToString()),
          Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public DataSet listaTecnicosGrilla()
    {
      DataSet dataSet = new DataSet();
      ((DataAdapter) new MySqlDataAdapter("SELECT idTecnico, nombre, fono, email FROM tecnicos ORDER BY idTecnico", this.conexion.ConexionMySql)).Fill(dataSet);
      return dataSet;
    }

    public void agregaTecnico(VendedorVO ve)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO tecnicos (nombre, fono, email) VALUES(@Nombre, @Fono, @Email )";
      command.Parameters.AddWithValue("@Nombre", (object) ve.Nombre);
      command.Parameters.AddWithValue("@Fono", (object) ve.Fono);
      command.Parameters.AddWithValue("@Email", (object) ve.Email);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public VendedorVO buscaTecnicoId(int _idven)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idTecnico, nombre, fono, email  FROM tecnicos WHERE idTecnico = @idVendedor";
      command.Parameters.AddWithValue("@idVendedor", (object) _idven);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      VendedorVO vendedorVo = new VendedorVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        vendedorVo.IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTecnico"].ToString());
        vendedorVo.Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString();
        vendedorVo.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        vendedorVo.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return vendedorVo;
    }

    public void modificaTecnico(VendedorVO ve)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE tecnicos SET nombre=@Nombre, fono=@Fono, email=@Email WHERE idTecnico=@IdVen";
      command.Parameters.AddWithValue("@Nombre", (object) ve.Nombre);
      command.Parameters.AddWithValue("@Fono", (object) ve.Fono);
      command.Parameters.AddWithValue("@Email", (object) ve.Email);
      command.Parameters.AddWithValue("@IdVen", (object) ve.IdVendedor);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaTecnico(int _id)
    {
      string format = "DELETE FROM tecnicos WHERE idTecnico={0}";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = string.Format(format, (object) _id);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
