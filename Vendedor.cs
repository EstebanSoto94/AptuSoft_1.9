 
// Type: Aptusoft.Vendedor
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Vendedor
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaVendedor(VendedorVO ve)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO vendedores (nombre, fono, email, comision) VALUES(@Nombre, @Fono, @Email,@Comision )";
      command.Parameters.AddWithValue("@Nombre", (object) ve.Nombre);
      command.Parameters.AddWithValue("@Fono", (object) ve.Fono);
      command.Parameters.AddWithValue("@Email", (object) ve.Email);
      command.Parameters.AddWithValue("@Comision", (object) ve.Comision);
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();
      }
        
    }

    public DataSet listaVendedores()
    {
      DataSet dataSet = new DataSet();
      ((DataAdapter) new MySqlDataAdapter("SELECT idVendedor, nombre, fono, email, comision FROM vendedores ORDER BY idVendedor", this.conexion.ConexionMySql)).Fill(dataSet);
      return dataSet;
    }

    public List<VendedorVO> listaVendedoresVenta()
    {
      List<VendedorVO> list = new List<VendedorVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idVendedor, nombre, comision FROM vendedores ORDER BY idVendedor";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new VendedorVO()
      {
        IdVendedor = 0,
        Nombre = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new VendedorVO()
        {
          IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"].ToString()),
          Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString(),
          Comision = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["comision"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public VendedorVO buscaVendedorId(int _idven)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idVendedor, nombre, fono, email, comision FROM vendedores WHERE idVendedor = @idVendedor";
      command.Parameters.AddWithValue("@idVendedor", (object) _idven);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      VendedorVO vendedorVo = new VendedorVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        vendedorVo.IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"].ToString());
        vendedorVo.Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString();
        vendedorVo.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        vendedorVo.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        vendedorVo.Comision = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["comision"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      return vendedorVo;
    }

    public void modificaVendedor(VendedorVO ve)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE vendedores SET nombre=@Nombre, fono=@Fono, email=@Email, comision=@Comision WHERE idVendedor=@IdVen";
      command.Parameters.AddWithValue("@Nombre", (object) ve.Nombre);
      command.Parameters.AddWithValue("@Fono", (object) ve.Fono);
      command.Parameters.AddWithValue("@Email", (object) ve.Email);
      command.Parameters.AddWithValue("@Comision", (object) ve.Comision);
      command.Parameters.AddWithValue("@IdVen", (object) ve.IdVendedor);
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();
      }
    }

    public void eliminaVendedor(int _id)
    {
      string format = "DELETE FROM vendedores WHERE idVendedor={0}";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = string.Format(format, (object) _id);
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();
      }
    }
  }
}
