 
// Type: Aptusoft.Impuestos
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  internal class Impuestos
  {
    private Conexion conexion = Conexion.getConecta();

    public List<ImpuestoVO> listaImpuestos()
    {
      List<ImpuestoVO> list = new List<ImpuestoVO>();
      list.Add(new ImpuestoVO()
      {
        IdImpuesto = 0,
        NombreImpuesto = "SIN IMPUESTOS",
        PorcentajeImpuesto = new Decimal(0)
      });
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idImpuesto, codigoImpuesto, nombreImpuesto, porcentajeImpuesto FROM impuestos ORDER BY idImpuesto";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ImpuestoVO()
        {
          IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"].ToString()),
          CodigoImpuesto = ((DbDataReader) mySqlDataReader)["codigoImpuesto"].ToString(),
          NombreImpuesto = ((DbDataReader) mySqlDataReader)["nombreImpuesto"].ToString(),
          PorcentajeImpuesto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void modificaImpuesto(ImpuestoVO imVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE impuestos SET \r\n                                            codigoImpuesto=@CodigoImpuesto,\r\n                                            nombreImpuesto=@NombreImpuesto,\r\n                                            porcentajeImpuesto=@PorcentajeImpuesto\r\n                                    WHERE idImpuesto=@IdImp";
      command.Parameters.AddWithValue("@CodigoImpuesto", (object) imVO.CodigoImpuesto);
      command.Parameters.AddWithValue("@NombreImpuesto", (object) imVO.NombreImpuesto);
      command.Parameters.AddWithValue("@PorcentajeImpuesto", (object) imVO.PorcentajeImpuesto);
      command.Parameters.AddWithValue("@IdImp", (object) imVO.IdImpuesto);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
