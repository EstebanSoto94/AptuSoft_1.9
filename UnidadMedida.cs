 
// Type: Aptusoft.UnidadMedida
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class UnidadMedida
  {
    private Conexion conexion = Conexion.getConecta();

    public DataSet listaUnidadMedida()
    {
      DataSet dataSet = new DataSet();
      ((DataAdapter) new MySqlDataAdapter("SELECT CodigoUnidad, DescUnidad FROM unidadmedida ORDER BY CodigoUnidad", this.conexion.ConexionMySql)).Fill(dataSet);
      return dataSet;
    }

    public List<UnidadMedidaVO> listaUnidadMedidaProductos()
    {
      List<UnidadMedidaVO> list = new List<UnidadMedidaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT CodigoUnidad, DescUnidad FROM unidadmedida ORDER BY CodigoUnidad";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new UnidadMedidaVO()
      {
        IdUnidMed = 0,
        NombreUnidad = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new UnidadMedidaVO()
        {
          IdUnidMed = Convert.ToInt32(((DbDataReader) mySqlDataReader)["CodigoUnidad"].ToString()),
          NombreUnidad = ((DbDataReader) mySqlDataReader)["DescUnidad"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public bool buscaUnidadDesc(string _unidad)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT * FROM unidadmedida WHERE DescUnidad = @Unidad";
      command.Parameters.AddWithValue("@Unidad", (object) _unidad);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void agregaUnidad(string _unidad)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO unidadmedida (DescUnidad) VALUES(@Unidad)";
      command.Parameters.AddWithValue("@Unidad", (object) _unidad);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaUnidad(UnidadMedidaVO unidad)
    {
      ((DbCommand) new MySqlCommand(string.Format("UPDATE unidadmedida SET DescUnidad='{0}' WHERE CodigoUnidad={1}", (object) unidad.NombreUnidad, (object) unidad.IdUnidMed), this.conexion.ConexionMySql)).ExecuteNonQuery();
    }

    public void eliminaUnidad(int _id)
    {
      string format = "DELETE FROM unidadmedida WHERE CodigoUnidad={0}";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = string.Format(format, (object) _id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public int hayProductosEnUnidad(int codUni)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT COUNT(*) FROM productos WHERE CodUnidadMedida = @codUni";
      command.Parameters.AddWithValue("@codUni", (object) codUni);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      int num = 0;
      while (((DbDataReader) mySqlDataReader).Read())
        num = int.Parse(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }
  }
}
