 
// Type: Aptusoft.InternoAptusoft.Facturacion.FacturacionDato
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft.InternoAptusoft.Facturacion
{
  public class FacturacionDato
  {
    private Conexion conexion = Conexion.getConecta();

    public bool BuscaContratoFacturado(int idContrato, DateTime fechaFacturacion)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idFacturacion FROM internos_facturacion \r\n                                    WHERE \r\n                                            idContrato=@idContrato AND DATE_FORMAT(fechaFacturacion, '%Y-%m') = DATE_FORMAT(@fechaFacturacion, '%Y-%m')  ";
      command.Parameters.AddWithValue("@idContrato", (object) idContrato);
      command.Parameters.AddWithValue("@fechaFacturacion", (object) fechaFacturacion);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public bool BuscaContratoFacturadoAlgunaVez(int idContrato)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idFacturacion FROM internos_facturacion \r\n                                    WHERE \r\n                                            idContrato=@idContrato ";
      command.Parameters.AddWithValue("@idContrato", (object) idContrato);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void GuardaFacturacion(FacturacionVO fa)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO internos_facturacion (\r\n                                                                    fechaFacturacion,\r\n                                                                    idContrato,\r\n                                                                    idCliente,\r\n                                                                    idDocumentoVenta,\r\n                                                                    folioDocumentoVenta                                                                    \r\n                                                                ) \r\n                                                           VALUES(\r\n                                                                    @fechaFacturacion,\r\n                                                                    @idContrato,\r\n                                                                    @idCliente,\r\n                                                                    @idDocumentoVenta,\r\n                                                                    @folioDocumentoVenta                                                                    \r\n                                                                    )";
      command.Parameters.AddWithValue("@fechaFacturacion", (object) DateTime.Now);
      command.Parameters.AddWithValue("@idContrato", (object) fa.IdContrato);
      command.Parameters.AddWithValue("@idCliente", (object) fa.IdCliente);
      command.Parameters.AddWithValue("@idDocumentoVenta", (object) fa.IdDocumentoVenta);
      command.Parameters.AddWithValue("@folioDocumentoVenta", (object) fa.FolioDocumentoVenta);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<FacturacionVO> BuscaFacturacionIdCliente(int idCliente)
    {
      List<FacturacionVO> list = new List<FacturacionVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                            i.fechaFacturacion,\r\n                                            ef.fechaEmision,\r\n                                            ef.fechaVencimiento, \r\n                                            i.folioDocumentoVenta,\r\n                                            ef.estadoPago\r\n                                    FROM \r\n                                    internos_facturacion i\r\n                                    INNER JOIN \r\n                                    electronica_factura ef \r\n                                    ON i.idDocumentoVenta=ef.idFactura\r\n                                    WHERE i.idCliente=@idCliente";
      command.Parameters.AddWithValue("@idCliente", (object) idCliente);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      FacturacionVO facturacionVo = new FacturacionVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new FacturacionVO()
        {
          FechaFacturacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaFacturacion"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          FechaVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaVencimiento"]),
          FolioDocumentoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioDocumentoVenta"].ToString()),
          EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
