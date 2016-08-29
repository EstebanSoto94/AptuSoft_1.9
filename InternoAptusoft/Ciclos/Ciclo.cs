 
// Type: Aptusoft.InternoAptusoft.Ciclos.Ciclo
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft.InternoAptusoft.Ciclos
{
  public class Ciclo
  {
    private Conexion conexion = Conexion.getConecta();

    public List<CicloVO> ListaCiclos()
    {
      List<CicloVO> list = new List<CicloVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                            idCiclo,\r\n                                            codigoCiclo,\r\n                                            descripcion,\r\n                                            diaFacturacion,\r\n                                            diaVencimiento,\r\n                                            diaCorteServicio,\r\n                                            diaContratacionDesde,\r\n                                            diaContratacionHasta,\r\n                                            mesPrimeraFacturacion\r\n                                    FROM internos_ciclos ORDER BY idCiclo";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      CicloVO cicloVo = new CicloVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new CicloVO()
        {
          IdCiclo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCiclo"].ToString()),
          CodigoCiclo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoCiclo"].ToString()),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          DiaFacturacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diaFacturacion"].ToString()),
          DiaVencimiento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diaVencimiento"].ToString()),
          DiaCorteServicio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diaCorteServicio"].ToString()),
          DiaContratacionDesde = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diaContratacionDesde"].ToString()),
          DiaContratacionHasta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diaContratacionHasta"].ToString()),
          MesPrimeraFacturacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesPrimeraFacturacion"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
