 
// Type: Aptusoft.Garzon
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Garzon
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaGarzon(VendedorVO ve)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO garzones (nombre, fono, email, comision) VALUES(@Nombre, @Fono, @Email,@Comision )";
      command.Parameters.AddWithValue("@Nombre", (object) ve.Nombre);
      command.Parameters.AddWithValue("@Fono", (object) ve.Fono);
      command.Parameters.AddWithValue("@Email", (object) ve.Email);
      command.Parameters.AddWithValue("@Comision", (object) ve.Comision);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public DataSet listaGarzones()
    {
      DataSet dataSet = new DataSet();
      ((DataAdapter) new MySqlDataAdapter("SELECT idGarzon, nombre, fono, email, comision FROM garzones ORDER BY idGarzon", this.conexion.ConexionMySql)).Fill(dataSet);
      return dataSet;
    }

    public List<VendedorVO> listaGarzonesVenta()
    {
      List<VendedorVO> list = new List<VendedorVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idGarzon, nombre, comision FROM garzones ORDER BY idGarzon";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new VendedorVO()
      {
        IdVendedor = 0,
        Nombre = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new VendedorVO()
        {
          IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGarzon"].ToString()),
          Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString(),
          Comision = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["comision"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public VendedorVO buscaGarzonId(int _idGar)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idGarzon, nombre, fono, email, comision FROM garzones WHERE idGarzon = @idGarzon";
      command.Parameters.AddWithValue("@idGarzon", (object) _idGar);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      VendedorVO vendedorVo = new VendedorVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        vendedorVo.IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGarzon"].ToString());
        vendedorVo.Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString();
        vendedorVo.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        vendedorVo.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        vendedorVo.Comision = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["comision"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      return vendedorVo;
    }

    public void modificaGarzon(VendedorVO ve)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE garzones SET nombre=@Nombre, fono=@Fono, email=@Email, comision=@Comision WHERE idGarzon=@IdVen";
      command.Parameters.AddWithValue("@Nombre", (object) ve.Nombre);
      command.Parameters.AddWithValue("@Fono", (object) ve.Fono);
      command.Parameters.AddWithValue("@Email", (object) ve.Email);
      command.Parameters.AddWithValue("@Comision", (object) ve.Comision);
      command.Parameters.AddWithValue("@IdVen", (object) ve.IdVendedor);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaGarzon(int _id)
    {
      string format = "DELETE FROM garzones WHERE idGarzon={0}";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = string.Format(format, (object) _id);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
