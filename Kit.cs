 
// Type: Aptusoft.Kit
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  internal class Kit
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaKit(List<KitVO> lista)
    {
      foreach (KitVO kiVO in lista)
        this.agregaKit(kiVO);
    }

    public void agregaKit(KitVO kiVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detallekit (\r\n                                                            codigoProductoKit,\r\n                                                            codigoProductoDetalle,\r\n                                                            cantidad,\r\n                                                            descripcion\r\n                                                            )\r\n                                                    VALUES (\r\n                                                            @codigoProductoKit,\r\n                                                            @codigoProductoDetalle,\r\n                                                            @cantidad,\r\n                                                            @descripcion\r\n                                                            )";
      command.Parameters.AddWithValue("@codigoProductoKit", (object) kiVO.CodigoProductoKit);
      command.Parameters.AddWithValue("@codigoProductoDetalle", (object) kiVO.CodigoProductoDetalle);
      command.Parameters.AddWithValue("@cantidad", (object) kiVO.Cantidad);
      command.Parameters.AddWithValue("@descripcion", (object) kiVO.Descripcion);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<KitVO> buscaKitCodigoKit(string cod)
    {
      List<KitVO> list = new List<KitVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idKit,\r\n                                            codigoProductoKit,\r\n                                            codigoProductoDetalle,\r\n                                            cantidad,\r\n                                            descripcion\r\n                                    FROM detallekit \r\n                                    WHERE codigoProductoKit=@cod";
      command.Parameters.AddWithValue("@cod", (object) cod);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        KitVO kitVo = new KitVO()
        {
          IdKit = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idKit"].ToString()),
          CodigoProductoKit = ((DbDataReader) mySqlDataReader)["codigoProductoKit"].ToString(),
          CodigoProductoDetalle = ((DbDataReader) mySqlDataReader)["codigoProductoDetalle"].ToString(),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString()),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString()
        };
        list.Add(kitVo);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void eliminaKit(string cod)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detallekit WHERE codigoProductoKit=@cod";
      command.Parameters.AddWithValue("@cod", (object) cod);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public DataTable kitInforme(string filtro)
    {
      string str = "SELECT \r\n                                      idKit,\r\n                                      codigoProductoKit,\r\n                                      'D' as descripcionKit,                                      \r\n                                      codigoProductoDetalle,\r\n                                      cantidad,\r\n                                      descripcion\r\n                                FROM detallekit                       \r\n                                WHERE " + filtro + " ORDER BY idKit";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
