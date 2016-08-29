 
// Type: Aptusoft.FacturaElectronica.Clases.Folios
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class Folios
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaFolio(FolioVO fo)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO folios (td, caja, desde, hasta)\r\n                                    VALUES(@td, @caja, @desde, @hasta)";
      command.Parameters.AddWithValue("@td", (object) fo.Td);
      command.Parameters.AddWithValue("@caja", (object) fo.Caja);
      command.Parameters.AddWithValue("@desde", (object) fo.Desde);
      command.Parameters.AddWithValue("@hasta", (object) fo.Hasta);
      ((DbCommand) command).ExecuteNonQuery();
      this.conexion.cerrarConexion();
    }

    public List<FolioVO> listadoFolios(int td)
    {
      List<FolioVO> list = new List<FolioVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idFolio, td, caja, desde, hasta FROM folios WHERE td=@td ORDER BY idFolio DESC";
      command.Parameters.AddWithValue("@td", (object) td);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new FolioVO()
        {
          IdFolio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFolio"].ToString()),
          Td = Convert.ToInt32(((DbDataReader) mySqlDataReader)["td"].ToString()),
          Caja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["caja"].ToString()),
          Desde = Convert.ToInt32(((DbDataReader) mySqlDataReader)["desde"].ToString()),
          Hasta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["hasta"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
