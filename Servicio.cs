 
// Type: Aptusoft.Servicio
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Servicio
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaServicio(ServicioVO seVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO servicio (\r\n                                                            folioServicio,\r\n                                                            idProveedor,                                                            \r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            fechaIngreso,\r\n                                                            fechaVencimiento,\r\n                                                            neto,\r\n                                                            iva,\r\n                                                            total,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            estadoPago,\r\n                                                            usuario,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idPeriodo,\r\n                                                            periodo                                                            \r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folioServicio,\r\n                                                            @idProveedor, \r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @fechaIngreso,\r\n                                                            @fechaVencimiento,\r\n                                                            @neto,\r\n                                                            @iva,\r\n                                                            @total,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @estadoPago,\r\n                                                            @usuario,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idPeriodo,\r\n                                                            @periodo                                                                                                                        \r\n                                                   )";
      command.Parameters.AddWithValue("@folioServicio", (object) seVO.FolioServicio);
      command.Parameters.AddWithValue("@idProveedor", (object) seVO.IdProveedor);
      command.Parameters.AddWithValue("@rut", (object) seVO.Rut);
      command.Parameters.AddWithValue("@digito", (object) seVO.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) seVO.RazonSocial);
      command.Parameters.AddWithValue("@fechaIngreso", (object) seVO.FechaIngreso);
      command.Parameters.AddWithValue("@fechaVencimiento", (object) seVO.FechaVencimiento);
      command.Parameters.AddWithValue("@neto", (object) seVO.Neto);
      command.Parameters.AddWithValue("@iva", (object) seVO.Iva);
      command.Parameters.AddWithValue("@total", (object) seVO.Total);
      command.Parameters.AddWithValue("@totalPagado", (object) seVO.TotalPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) seVO.TotalDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) seVO.TotalPendiente);
      command.Parameters.AddWithValue("@estadoPago", (object) seVO.EstadoPago);
      command.Parameters.AddWithValue("@usuario", (object) seVO.Usuario);
      command.Parameters.AddWithValue("@idMedioPago", (object) seVO.IdMedioPago);
      command.Parameters.AddWithValue("@medioPago", (object) seVO.MedioPago);
      command.Parameters.AddWithValue("@idPeriodo", (object) seVO.IdPeriodo);
      command.Parameters.AddWithValue("@periodo", (object) seVO.Periodo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaServicio(ServicioVO seVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE servicio SET idProveedor=@idProveedor,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            fechaIngreso=@fechaIngreso,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            neto=@neto,\r\n                                                            iva=@iva,\r\n                                                            total=@total,\r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            usuario=@usuario,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idPeriodo=@idPeriodo,\r\n                                                            periodo=@periodo\r\n                                        WHERE idServicio=@idServicio";
      command.Parameters.AddWithValue("@idServicio", (object) seVO.IdServicio);
      command.Parameters.AddWithValue("@idProveedor", (object) seVO.IdProveedor);
      command.Parameters.AddWithValue("@rut", (object) seVO.Rut);
      command.Parameters.AddWithValue("@digito", (object) seVO.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) seVO.RazonSocial);
      command.Parameters.AddWithValue("@fechaIngreso", (object) seVO.FechaIngreso);
      command.Parameters.AddWithValue("@fechaVencimiento", (object) seVO.FechaVencimiento);
      command.Parameters.AddWithValue("@neto", (object) seVO.Neto);
      command.Parameters.AddWithValue("@iva", (object) seVO.Iva);
      command.Parameters.AddWithValue("@total", (object) seVO.Total);
      command.Parameters.AddWithValue("@totalPagado", (object) seVO.TotalPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) seVO.TotalDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) seVO.TotalPendiente);
      command.Parameters.AddWithValue("@estadoPago", (object) seVO.EstadoPago);
      command.Parameters.AddWithValue("@usuario", (object) seVO.Usuario);
      command.Parameters.AddWithValue("@idMedioPago", (object) seVO.IdMedioPago);
      command.Parameters.AddWithValue("@medioPago", (object) seVO.MedioPago);
      command.Parameters.AddWithValue("@idPeriodo", (object) seVO.IdPeriodo);
      command.Parameters.AddWithValue("@periodo", (object) seVO.Periodo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaServicio(int idServicio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM servicio WHERE idServicio=@idServicio";
      command.Parameters.AddWithValue("@idServicio", (object) idServicio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public bool servicioExiste(string folio, string rut)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folioServicio FROM servicio WHERE folioServicio=@folio AND rut=@rut";
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@rut", (object) rut);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int retornaIdServicio(string folio, string rut)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idServicio, folioServicio FROM servicio WHERE folioServicio=@folio AND rut=@rut";
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@rut", (object) rut);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public DataTable listaServiciosFiltro(DateTime desde, DateTime hasta)
    {
      DataTable dataTable1 = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT 0 as 'linea', idServicio, folioServicio, razonSocial, fechaIngreso, fechaVencimiento,total, estadoPago, idPeriodo, periodo\r\n                                        FROM servicio\r\n                                    WHERE DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= DATE_FORMAT(@desde, '%Y-%m-%d') AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= DATE_FORMAT(@hasta, '%Y-%m-%d') ORDER BY fechaIngreso DESC";
        command.Parameters.AddWithValue("@desde", (object) desde);
        command.Parameters.AddWithValue("@hasta", (object) hasta);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable1);
      }
      catch (Exception ex)
      {
        DataTable dataTable2;
        return dataTable2 = (DataTable) null;
      }
      return dataTable1;
    }

    public ServicioVO buscaServicioID(string idServicio)
    {
      ServicioVO servicioVo = new ServicioVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idServicio,idProveedor,\r\n                                                            folioServicio,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            fechaIngreso,\r\n                                                            fechaVencimiento,\r\n                                                            neto,\r\n                                                            iva,\r\n                                                            total,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            estadoPago,\r\n                                                            usuario,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idPeriodo,\r\n                                                            periodo\r\n                                        FROM servicio\r\n                                    WHERE idServicio=@idServicio";
      command.Parameters.AddWithValue("@idServicio", (object) idServicio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        servicioVo.IdServicio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idServicio"].ToString());
        servicioVo.FolioServicio = ((DbDataReader) mySqlDataReader)["folioServicio"].ToString();
        servicioVo.IdProveedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idProveedor"].ToString());
        servicioVo.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        servicioVo.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        servicioVo.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        servicioVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
        servicioVo.FechaVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaVencimiento"].ToString());
        servicioVo.Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"].ToString());
        servicioVo.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"].ToString());
        servicioVo.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString());
        servicioVo.TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPagado"].ToString());
        servicioVo.TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalDocumentado"].ToString());
        servicioVo.TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPendiente"].ToString());
        servicioVo.EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString();
        servicioVo.IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"].ToString());
        servicioVo.MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString();
        servicioVo.IdPeriodo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPeriodo"].ToString());
        servicioVo.Periodo = ((DbDataReader) mySqlDataReader)["periodo"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return servicioVo;
    }

    public DataTable listaServicioPago(DateTime desde, DateTime hasta, string estadoDoc, int folio, string proveedor)
    {
      string str1 = !estadoDoc.Equals("[TODOS]") ? " AND estadoPago='" + estadoDoc + "'" : "";
      string str2 = folio != 0 ? " AND folioServicio='" + (object) folio + "'" : "";
      string str3 = proveedor.Length != 0 ? " AND razonSocial='" + proveedor + "'" : "";
      DataTable dataTable1 = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT idServicio as 'idCompra', 'SERVICIO' as tipoDocumentoCompra, folioServicio AS 'folio', fechaIngreso as 'fechaEmision', rut, digito, razonSocial, total AS 'totalCobrar', estadoPago, totalPagado, totalPendiente, totalDocumentado FROM servicio\r\n                                    WHERE DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= DATE_FORMAT(@desde, '%Y-%m-%d') AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= DATE_FORMAT(@hasta, '%Y-%m-%d') " + str2 + str1 + str3 + " ORDER BY fechaIngreso DESC";
        command.Parameters.AddWithValue("@desde", (object) desde);
        command.Parameters.AddWithValue("@hasta", (object) hasta);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable1);
      }
      catch (Exception ex)
      {
        DataTable dataTable2;
        return dataTable2 = (DataTable) null;
      }
      return dataTable1;
    }

    public DataTable servicioInforme(string filtro)
    {
      string str = "SELECT idServicio, 'SERVICIO' as tipoDocumentoCompra, '1' AS idTipoDocumentoCompra,\r\n                                                            folioServicio AS 'folio',\r\n                                                            idProveedor,                                                            \r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            fechaIngreso AS 'fechaEmision',\r\n                                                            fechaVencimiento,\r\n                                                            neto,\r\n                                                            iva,\r\n                                                            total,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            estadoPago,\r\n                                                            usuario,\r\n                                                            idMedioPago,\r\n                                                            medioPago, \r\n                                                            idPeriodo,\r\n                                                            periodo                                                                                  \r\n                                FROM servicio                             \r\n                                WHERE " + filtro + " ORDER BY fechaIngreso";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
