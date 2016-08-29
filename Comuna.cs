 
// Type: Aptusoft.Comuna
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  internal class Comuna
  {
    private Conexion conexion = Conexion.getConecta();

    public DataSet cosultaComuna()
    {
      DataSet dataSet = new DataSet();
      ((DataAdapter) new MySqlDataAdapter("SELECT * FROM comuna ORDER BY nombrecomuna", this.conexion.ConexionMySql)).Fill(dataSet);
      return dataSet;
    }
  }
}
