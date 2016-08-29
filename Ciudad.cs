 
// Type: Aptusoft.Ciudad
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Ciudad
  {
    private Conexion conexion = Conexion.getConecta();

    public DataSet cosultaCiudad()
    {
      DataSet dataSet = new DataSet();
      ((DataAdapter) new MySqlDataAdapter("SELECT * FROM ciudad ORDER BY nombreciudad", this.conexion.ConexionMySql)).Fill(dataSet);
      return dataSet;
    }
  }
}
