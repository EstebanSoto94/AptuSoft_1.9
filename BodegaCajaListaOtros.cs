 
// Type: Aptusoft.BodegaCajaListaOtros
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class BodegaCajaListaOtros
  {
    private Conexion conexion = Conexion.getConecta();

    public void modificaBodega(string codigo, string descripcion)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE bodegas SET descripcion=@descripcion WHERE codigo=@codigo";
      command.Parameters.AddWithValue("@descripcion", (object) descripcion);
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaListaprecio(string codigo, string descripcion)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE listas_precio SET descripcion=@descripcion WHERE codigo=@codigo";
      command.Parameters.AddWithValue("@descripcion", (object) descripcion);
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaCaja(string codigo, string descripcion)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE cajas SET descripcion=@descripcion WHERE codigo=@codigo";
      command.Parameters.AddWithValue("@descripcion", (object) descripcion);
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public DataTable listaBodegas()
    {
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, descripcion FROM bodegas ORDER BY codigo";
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public List<BodegaVO> listaBodegasList()
    {
      List<BodegaVO> list = new List<BodegaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, descripcion FROM bodegas ORDER BY codigo";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      BodegaVO bodegaVo = new BodegaVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new BodegaVO()
        {
          IdBodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigo"].ToString()),
          nombreBodega = ((DbDataReader) mySqlDataReader)["descripcion"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<ListaPrecioVO> listaListaPrecioList()
    {
      List<ListaPrecioVO> list = new List<ListaPrecioVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, descripcion FROM listas_precio ORDER BY codigo";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      ListaPrecioVO listaPrecioVo = new ListaPrecioVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ListaPrecioVO()
        {
          IdListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigo"].ToString()),
          nombreListaPrecio = ((DbDataReader) mySqlDataReader)["descripcion"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<CajaVO> listaCajaList()
    {
      List<CajaVO> list = new List<CajaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, descripcion FROM cajas ORDER BY codigo";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      CajaVO cajaVo = new CajaVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new CajaVO()
        {
          IdCaja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigo"].ToString()),
          nombreCaja = ((DbDataReader) mySqlDataReader)["descripcion"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public DataTable listaListas_Precio()
    {
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, descripcion FROM listas_precio ORDER BY codigo";
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable listaCajas()
    {
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, descripcion FROM cajas ORDER BY codigo";
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
