 
// Type: Aptusoft.PagoCompra
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class PagoCompra
  {
    private Conexion conexion = Conexion.getConecta();

    public string ingresaPagoCompra(List<PagoVentaVO> lista, string tipoDoc, int idDoc, long folio, DateTime fechaIng, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      foreach (PagoVentaVO pvVO in lista)
      {
        try
        {
          this.agregarPagoCompra(pvVO, tipoDoc, idDoc, folio, fechaIng);
        }
        catch (Exception ex)
        {
          return "Error : " + ex.Message;
        }
      }
      try
      {
        //if (tipoDoc.Equals("FACTURA COMPRA") || tipoDoc.Equals("FACTURA ELECTRONICA"))
          this.cambiaEstadoDocumentoCompra(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        //if (tipoDoc.Equals("SERVICIO"))
          this.cambiaEstadoDocumentoServicio(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
      }
      catch (Exception ex)
      {
        return "Error ACTUALIZA ESTADO DOCUMENTO: " + ex.Message;
      }
      return "Pago Ingresado Correctamente";
    }

    public void agregarPagoCompra(PagoVentaVO pvVO, string tipoDoc, int idDoc, long folio, DateTime fechaIng)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO pagoscompras (\r\n                                                             tipoDocumento,\r\n                                                             idDocumento,\r\n                                                             folioDocumento,\r\n                                                             idMedioPagoPV,\r\n                                                             medioPagoPV,\r\n                                                             estadoPagoPV,\r\n                                                             monto,\r\n                                                             fechaCobro,\r\n                                                             fechaIngreso,\r\n                                                             banco,\r\n                                                             cuenta,\r\n                                                             numeroDocumento,\r\n                                                             observaciones\r\n                                                             )\r\n                                                       VALUES(\r\n                                                             @tipoDocumento,\r\n                                                             @idDocumento,\r\n                                                             @folioDocumento,\r\n                                                             @idFormaPago,\r\n                                                             @formaPago,\r\n                                                             @estado,\r\n                                                             @monto,\r\n                                                             @fechaCobro,\r\n                                                             @fechaIngreso,\r\n                                                             @banco,\r\n                                                             @cuenta,\r\n                                                             @numeroDocumento,\r\n                                                             @observaciones   \r\n                                                            )";
      command.Parameters.AddWithValue("@tipoDocumento", (object) tipoDoc);
      command.Parameters.AddWithValue("@idDocumento", (object) idDoc.ToString());
      command.Parameters.AddWithValue("@folioDocumento", (object) folio.ToString());
      command.Parameters.AddWithValue("@idFormaPago", (object) pvVO.IdFormaPago.ToString());
      command.Parameters.AddWithValue("@formaPago", (object) pvVO.FormaPago);
      command.Parameters.AddWithValue("@estado", (object) pvVO.Estado);
      command.Parameters.AddWithValue("@monto", (object) pvVO.Monto);
      command.Parameters.AddWithValue("@fechaCobro", (object) pvVO.FechaCobro);
      command.Parameters.AddWithValue("@fechaIngreso", (object) fechaIng);
      command.Parameters.AddWithValue("@banco", (object) pvVO.Banco);
      command.Parameters.AddWithValue("@cuenta", (object) pvVO.Cuenta);
      command.Parameters.AddWithValue("@numeroDocumento", (object) pvVO.NumeroDocumento);
      command.Parameters.AddWithValue("@observaciones", (object) pvVO.Observaciones);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoDocumentoCompra(int idCompra, long folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE compras SET  estadoPago=@estadoPago,\r\n                                                        totalPagado=@totalPagado,\r\n                                                        totalDocumentado=@totalDocumentado,\r\n                                                        totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idCompra=@idCompra AND folio=@folio";
      command.Parameters.AddWithValue("@idCompra", (object) idCompra);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoDocumentoServicio(int idServicio, long folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE servicio SET  estadoPago=@estadoPago,\r\n                                                        totalPagado=@totalPagado,\r\n                                                        totalDocumentado=@totalDocumentado,\r\n                                                        totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idServicio=@idServicio AND folioServicio=@folio";
      command.Parameters.AddWithValue("@idServicio", (object) idServicio);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<PagoVentaVO> listaPagosCompra(string tipoDoc, int idDoc, long folio)
    {
      List<PagoVentaVO> list = new List<PagoVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idPagoCompra,\r\n                                            tipoDocumento,\r\n                                            idDocumento,\r\n                                            folioDocumento,\r\n                                            idMedioPagoPV,\r\n                                            medioPagoPV,\r\n                                            estadoPagoPV,\r\n                                            monto,\r\n                                            fechaCobro,\r\n                                            fechaIngreso,\r\n                                            banco,\r\n                                            cuenta,\r\n                                            numeroDocumento,\r\n                                            observaciones\r\n                                       FROM pagoscompras WHERE \r\n                                                tipoDocumento=@tipoDoc AND\r\n                                                idDocumento=@idDoc AND\r\n                                                folioDocumento=@folio\r\n                                        ORDER BY idPagoCompra ASC";
      command.Parameters.AddWithValue("@tipoDoc", (object) tipoDoc);
      command.Parameters.AddWithValue("@idDoc", (object) idDoc);
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        PagoVentaVO pagoVentaVo = new PagoVentaVO();
        pagoVentaVo.IdPagoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPagoCompra"]);
        pagoVentaVo.TipoDocumento = ((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString();
        pagoVentaVo.IdDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDocumento"].ToString());
        pagoVentaVo.FolioDocumentoCompra = Convert.ToInt64(((DbDataReader) mySqlDataReader)["folioDocumento"].ToString());
        pagoVentaVo.IdFormaPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPagoPV"].ToString());
        pagoVentaVo.FormaPago = ((DbDataReader) mySqlDataReader)["medioPagoPV"].ToString();
        pagoVentaVo.Estado = ((DbDataReader) mySqlDataReader)["estadoPagoPV"].ToString();
        string str = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["monto"].ToString()).ToString("N0");
        pagoVentaVo.Monto = Convert.ToDecimal(str);
        pagoVentaVo.FechaCobro = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCobro"].ToString());
        pagoVentaVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
        pagoVentaVo.Banco = ((DbDataReader) mySqlDataReader)["banco"].ToString();
        pagoVentaVo.Cuenta = ((DbDataReader) mySqlDataReader)["cuenta"].ToString();
        pagoVentaVo.NumeroDocumento = ((DbDataReader) mySqlDataReader)["numeroDocumento"].ToString();
        pagoVentaVo.Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString();
        list.Add(pagoVentaVo);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void eliminaPagoCompra(string tipoDoc, int idDoc, long folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM pagoscompras WHERE\r\n                                                                 tipoDocumento=@tipoDoc AND\r\n                                                                 idDocumento=@idDoc AND\r\n                                                                 folioDocumento=@folio";
      command.Parameters.AddWithValue("@tipoDoc", (object) tipoDoc);
      command.Parameters.AddWithValue("@idDoc", (object) idDoc);
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public string modificaPagoCompra(List<PagoVentaVO> lista, string tipoDoc, int idDoc, long folio, DateTime fechaIng, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      try
      {
        this.eliminaPagoCompra(tipoDoc, idDoc, folio);
      }
      catch (Exception ex)
      {
        return "Error Elimina Pago: " + ex.Message;
      }
      foreach (PagoVentaVO pvVO in lista)
      {
        try
        {
          this.agregarPagoCompra(pvVO, tipoDoc, idDoc, folio, fechaIng);
        }
        catch (Exception ex)
        {
          return "Error Agregar Nuevos Pagos: " + ex.Message;
        }
      }
      try
      {
        if (tipoDoc.Equals("FACTURA COMPRA") || tipoDoc.Equals("FACTURA ELECTRONICA"))
          this.cambiaEstadoDocumentoCompra(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("SERVICIO"))
          this.cambiaEstadoDocumentoServicio(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
      }
      catch (Exception ex)
      {
        return "Error ACTUALIZA ESTADO DOCUMENTO: " + ex.Message;
      }
      return "Pagos Ingresados";
    }

    public DataTable pagoCompraInforme(string filtro)
    {
      string str = "SELECT\r\n                                        pagoscompras.idPagoCompra,\r\n                                        pagoscompras.tipoDocumento,\r\n                                        pagoscompras.idDocumento,\r\n                                        pagoscompras.folioDocumento,\r\n                                        pagoscompras.idMedioPagoPV,\r\n                                        pagoscompras.medioPagoPV,\r\n                                        pagoscompras.estadoPagoPV,\r\n                                        pagoscompras.monto,\r\n                                        pagoscompras.fechaCobro,\r\n                                        pagoscompras.fechaIngreso,\r\n                                        pagoscompras.banco, \r\n                                        pagoscompras.cuenta,\r\n                                        pagoscompras.numeroDocumento,\r\n                                        pagoscompras.observaciones,\r\n                                        compras.RazonSocial,\r\n                                        compras.rut,\r\n                                        compras.digito                                \r\n                                FROM pagoscompras INNER JOIN compras ON compras.idCompra = pagoscompras.idDocumento                                                        \r\n                                WHERE " + filtro + " ORDER BY pagoscompras.idPagoCompra";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable comprobantePagoCompra(long folio, int idFac)
    {
      string str = "SELECT\r\n                                        compras.idCompra,\r\n                                        compras.folio,\r\n                                        compras.fechaEmision,\r\n                                        compras.fechaVencimiento,\r\n                                        compras.dia,\r\n                                        compras.mes,\r\n                                        compras.ano,\r\n                                        compras.idProveedor,\r\n                                        compras.rut,\r\n                                        compras.digito,\r\n                                        compras.razonSocial,\r\n                                        compras.direccion,\r\n                                        compras.comuna,\r\n                                        compras.ciudad,\r\n                                        compras.giro,\r\n                                        compras.fono,\r\n                                        compras.fax,\r\n                                        compras.contacto,\r\n                                        compras.diasPlazo,\r\n                                        compras.idMedioPago,\r\n                                        compras.medioPago,\r\n                                        compras.idCentroCosto,\r\n                                        compras.centroCosto,\r\n                                        compras.ordenCompra,\r\n                                        compras.subtotal,\r\n                                        compras.porcentajeDescuento,\r\n                                        compras.descuento,\r\n                                        compras.porcentajeIva,\r\n                                        compras.iva,\r\n                                        compras.neto,\r\n                                        compras.total,\r\n                                        compras.totalPalabras,\r\n                                        compras.estadoPago,\r\n                                        compras.estadoDocumento,\r\n                                        compras.totalPagado,\r\n                                        compras.totalDocumentado,\r\n                                        compras.totalPendiente,\r\n                                        compras.idTipoDocumentoCompra,\r\n                                        compras.tipoDocumentoCompra,\r\n                                        pagoscompras.idPagoCompra,\r\n                                        pagoscompras.tipoDocumento,\r\n                                        pagoscompras.idDocumento,\r\n                                        pagoscompras.folioDocumento,\r\n                                        pagoscompras.idMedioPagoPV,\r\n                                        pagoscompras.medioPagoPV,\r\n                                        pagoscompras.estadoPagoPV,\r\n                                        pagoscompras.monto,\r\n                                        pagoscompras.fechaCobro,\r\n                                        pagoscompras.fechaIngreso,\r\n                                        pagoscompras.banco, \r\n                                        pagoscompras.cuenta,\r\n                                        pagoscompras.numeroDocumento,\r\n                                        pagoscompras.observaciones\r\n                                FROM compras INNER JOIN  pagoscompras\r\n                                ON compras.idCompra = pagoscompras.idDocumento AND compras.folio = pagoscompras.folioDocumento\r\n                                WHERE compras.folio=@folio AND compras.idCompra = @idFac ORDER BY pagoscompras.idPagoCompra";
      DataTable dataTable = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        command.Parameters.AddWithValue("@folio", (object) folio);
        command.Parameters.AddWithValue("@idFac", (object) idFac);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      catch (Exception ex)
      {
      }
      return dataTable;
    }
  }
}
