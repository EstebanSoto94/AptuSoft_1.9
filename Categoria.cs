 
// Type: Aptusoft.Categoria
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Categoria
  {
    private Conexion conexion = Conexion.getConecta();

    public DataSet cosultaCategoria()
    {
      DataSet dataSet = new DataSet();
      ((DataAdapter) new MySqlDataAdapter("SELECT Id, DescCategoria FROM categorias ORDER BY DescCategoria", this.conexion.ConexionMySql)).Fill(dataSet);
      return dataSet;
    }

    public List<CategoriaVO> listaCategorias()
    {
      List<CategoriaVO> list = new List<CategoriaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT Id, DescCategoria FROM categorias ORDER BY DescCategoria";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new CategoriaVO()
      {
        IdCategoria = 0,
        Descripcion = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new CategoriaVO()
        {
          IdCategoria = Convert.ToInt32(((DbDataReader) mySqlDataReader)["Id"].ToString()),
          Descripcion = ((DbDataReader) mySqlDataReader)["DescCategoria"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public bool buscaCategoriaDesc(string _categoria)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT * FROM categorias WHERE DescCategoria = @DescCategoria";
      command.Parameters.AddWithValue("@DescCategoria", (object) _categoria);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void agregaCategoria(string _categoria)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO categorias (DescCategoria) VALUES(@DescCategoria)";
      command.Parameters.AddWithValue("@DescCategoria", (object) _categoria);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaCategoria(CategoriaVO categoria)
    {
      ((DbCommand) new MySqlCommand(string.Format("UPDATE categorias SET DescCategoria='{0}' WHERE ID={1}", (object) categoria.Descripcion, (object) categoria.IdCategoria), this.conexion.ConexionMySql)).ExecuteNonQuery();
    }

    public void eliminaCategoria(int _id)
    {
      string format = "DELETE FROM categorias WHERE ID={0}";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = string.Format(format, (object) _id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public int hayProductosEnCategoria(int codCat)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT COUNT(*) FROM productos WHERE codCategoria = @codCat";
      command.Parameters.AddWithValue("@CodCat", (object) codCat);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      int num = 0;
      while (((DbDataReader) mySqlDataReader).Read())
        num = int.Parse(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public void modificaCategoriaEnProductos(string catNueva, string catAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE productos set Categoria=@catNueva WHERE Categoria=@catAntigua";
      command.Parameters.AddWithValue("@catNueva", (object) catNueva);
      command.Parameters.AddWithValue("@catAntigua", (object) catAntigua);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void agregaSubCategoria(CategoriaVO ca)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO categorias_subcategoria (\r\n                                                nombreSubCategoria,\r\n                                                idCategoria,\r\n                                                nombreCategoria)\r\n                                        VALUES (\r\n                                                @nombreSubCategoria,\r\n                                                @idCategoria,\r\n                                                @nombreCategoria)";
      command.Parameters.AddWithValue("@nombreSubCategoria", (object) ca.DescripcionSubCategoria);
      command.Parameters.AddWithValue("@idCategoria", (object) ca.IdCategoria);
      command.Parameters.AddWithValue("@nombreCategoria", (object) ca.Descripcion);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaSubCategoria(CategoriaVO ca)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE categorias_subcategoria SET\r\n                                                nombreSubCategoria=@nombreSubCategoria\r\n                                    WHERE idSubCategoria=@idSubCategoria";
      command.Parameters.AddWithValue("@nombreSubCategoria", (object) ca.DescripcionSubCategoria);
      command.Parameters.AddWithValue("@idSubCategoria", (object) ca.IdSubCategoria);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public DataTable listaSubCategoria(int idCategoria)
    {
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT   idSubCategoria,\r\n                                    nombreSubCategoria,\r\n                                    idCategoria,\r\n                                    nombreCategoria\r\n                           FROM categorias_subcategoria WHERE idCategoria=@idcategoria ORDER BY nombreSubCategoria";
      command.Parameters.AddWithValue("@idcategoria", (object) idCategoria);
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public List<CategoriaVO> listaSubCategoriasLista(int idCategoria)
    {
      List<CategoriaVO> list = new List<CategoriaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT   idSubCategoria,\r\n                                            nombreSubCategoria                                   \r\n                            FROM categorias_subcategoria \r\n                            WHERE idCategoria=@idcategoria ORDER BY nombreSubCategoria";
      command.Parameters.AddWithValue("@idcategoria", (object) idCategoria);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new CategoriaVO()
      {
        IdSubCategoria = 0,
        DescripcionSubCategoria = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new CategoriaVO()
        {
          IdSubCategoria = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idSubCategoria"].ToString()),
          DescripcionSubCategoria = ((DbDataReader) mySqlDataReader)["nombreSubCategoria"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void eliminaSubCategoria(int _id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM categorias_subcategoria WHERE idSubCategoria=@id";
      command.Parameters.AddWithValue("@id", (object) _id);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
