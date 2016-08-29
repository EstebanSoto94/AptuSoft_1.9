 
// Type: Aptusoft.PagoVenta
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class PagoVenta
  {
    private Conexion conexion = Conexion.getConecta();

    public string ingresaPagoVenta(List<PagoVentaVO> lista, string tipoDoc, int idDoc, int folio, DateTime fechaIng, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      foreach (PagoVentaVO pvVO in lista)
      {
        try
        {
          this.agregarPagoVenta(pvVO, tipoDoc, idDoc, folio, fechaIng);
          if (pvVO.TipoPago.Equals("NC"))
            this.modificaMontoUsadoNC(pvVO);
          if (pvVO.TipoPago.Equals("NCE"))
            this.modificaMontoUsadoNCE(pvVO);
        }
        catch (Exception ex)
        {
          return "Error : " + ex.Message;
        }
      }
      try
      {
        if (tipoDoc.Equals("FACTURA"))
          this.cambiaEstadoFactura(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA_ELECTRONICA"))
          this.cambiaEstadoFacturaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA_EXENTA_ELECTRONICA"))
          this.cambiaEstadoFacturaExentaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA EXENTA"))
          this.cambiaEstadoFacturaExenta(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA"))
          this.cambiaEstadoBoleta(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("VOUCHER"))
          this.cambiaEstadoVoucher(idDoc, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA FISCAL"))
          this.cambiaEstadoBoletaFiscal(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA_ELECTRONICA"))
          this.cambiaEstadoBoletaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
      }
      catch (Exception ex)
      {
        return "Error ACTUALIZA ESTADO DOCUMENTO: " + ex.Message;
      }
      return "Ingreso de Pago";
    }

    public void agregarPagoVenta(PagoVentaVO pvVO, string tipoDoc, int idDoc, int folio, DateTime fechaIng)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO pagosventas (\r\n                                                             tipoDocumento,\r\n                                                             idDocumento,\r\n                                                             folioDocumento,\r\n                                                             idMedioPagoPV,\r\n                                                             medioPagoPV,\r\n                                                             estadoPagoPV,\r\n                                                             monto,\r\n                                                             fechaCobro,\r\n                                                             fechaIngreso,\r\n                                                             banco,\r\n                                                             cuenta,\r\n                                                             numeroDocumento,\r\n                                                             observaciones,\r\n                                                             tipoPago, montoPagoMasivo\r\n                                                             )\r\n                                                       VALUES(\r\n                                                             @tipoDocumento,\r\n                                                             @idDocumento,\r\n                                                             @folioDocumento,\r\n                                                             @idFormaPago,\r\n                                                             @formaPago,\r\n                                                             @estado,\r\n                                                             @monto,\r\n                                                             @fechaCobro,\r\n                                                             @fechaIngreso,\r\n                                                             @banco,\r\n                                                             @cuenta,\r\n                                                             @numeroDocumento,\r\n                                                             @observaciones,\r\n                                                             @tipoPago, @montoPagoMasivo   \r\n                                                            )";
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
      command.Parameters.AddWithValue("@tipoPago", (object) pvVO.TipoPago);
      command.Parameters.AddWithValue("@montoPagoMasivo", (object) pvVO.MontoPagoMasivo);
      ((DbCommand) command).ExecuteNonQuery();
    }


    private void modificaMontoUsadoNC(PagoVentaVO pvVO)
    {
      new NotaCredito().modificaMontoUsadoNotaCredito(pvVO.NumeroDocumento, pvVO.Monto);
    }

    private void modificaMontoUsadoNCE(PagoVentaVO pvVO)
    {
      new ENotaCredito().modificaMontoUsadoNotaCredito(pvVO.NumeroDocumento, pvVO.Monto);
    }

    public void cambiaEstadoFactura(int idFact, int folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE facturas SET estadoPago=@estadoPago,\r\n                                                        totalPagado=@totalPagado,\r\n                                                        totalDocumentado=@totalDocumentado,\r\n                                                        totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idFactura=@idFactura AND folio=@folio";
      command.Parameters.AddWithValue("@idFactura", (object) idFact);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoFacturaElectronica(int idFact, int folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_factura SET estadoPago=@estadoPago,\r\n                                                        totalPagado=@totalPagado,\r\n                                                        totalDocumentado=@totalDocumentado,\r\n                                                        totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idFactura=@idFactura AND folio=@folio";
      command.Parameters.AddWithValue("@idFactura", (object) idFact);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoFacturaExentaElectronica(int idFact, int folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_factura_exenta SET estadoPago=@estadoPago,\r\n                                                        totalPagado=@totalPagado,\r\n                                                        totalDocumentado=@totalDocumentado,\r\n                                                        totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idFactura=@idFactura AND folio=@folio";
      command.Parameters.AddWithValue("@idFactura", (object) idFact);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoFacturaExenta(int idFact, int folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE facturasexentas SET estadoPago=@estadoPago,\r\n                                                        totalPagado=@totalPagado,\r\n                                                        totalDocumentado=@totalDocumentado,\r\n                                                        totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idFacturaExenta=@idFactura AND folio=@folio";
      command.Parameters.AddWithValue("@idFactura", (object) idFact);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoBoleta(int idFact, int folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE boletas SET estadoPago=@estadoPago,\r\n                                                       totalPagado=@totalPagado,\r\n                                                       totalDocumentado=@totalDocumentado,\r\n                                                       totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idBoleta=@idBoleta AND folio=@folio";
      command.Parameters.AddWithValue("@idBoleta", (object) idFact);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoVoucher(int idFact, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE boletas SET estadoPago=@estadoPago,\r\n                                                       totalPagado=@totalPagado,\r\n                                                       totalDocumentado=@totalDocumentado,\r\n                                                       totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idBoleta=@idBoleta";
      command.Parameters.AddWithValue("@idBoleta", (object) idFact);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoBoletaFiscal(int idFact, int folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE boletasfiscal SET estadoPago=@estadoPago,\r\n                                                       totalPagado=@totalPagado,\r\n                                                       totalDocumentado=@totalDocumentado,\r\n                                                       totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idBoleta=@idBoleta AND folio=@folio";
      command.Parameters.AddWithValue("@idBoleta", (object) idFact);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void cambiaEstadoBoletaElectronica(int idFact, int folio, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_boleta SET estadoPago=@estadoPago,\r\n                                                       totalPagado=@totalPagado,\r\n                                                       totalDocumentado=@totalDocumentado,\r\n                                                       totalPendiente=@totalPendiente                                                            \r\n                                                    WHERE idBoleta=@idBoleta AND folio=@folio";
      command.Parameters.AddWithValue("@idBoleta", (object) idFact);
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@estadoPago", (object) estadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) tPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) tDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) tPendiente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<PagoVentaVO> listaPagosVenta(string tipoDoc, int idDoc, int folio)
    {
      List<PagoVentaVO> list = new List<PagoVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idPagoVenta,\r\n                                            tipoDocumento,\r\n                                            idDocumento,\r\n                                            folioDocumento,\r\n                                            idMedioPagoPV,\r\n                                            medioPagoPV,\r\n                                            estadoPagoPV,\r\n                                            monto,\r\n                                            fechaCobro,\r\n                                            fechaIngreso,\r\n                                            banco,\r\n                                            cuenta,\r\n                                            numeroDocumento,\r\n                                            observaciones,\r\n                                            tipoPago, montoPagoMasivo\r\n                                       FROM pagosventas WHERE \r\n                                                tipoDocumento=@tipoDoc AND\r\n                                                idDocumento=@idDoc AND\r\n                                                folioDocumento=@folio\r\n                                        ORDER BY idPagoVenta ASC";
      command.Parameters.AddWithValue("@tipoDoc", (object) tipoDoc);
      command.Parameters.AddWithValue("@idDoc", (object) idDoc);
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        PagoVentaVO pagoVentaVo = new PagoVentaVO();
        pagoVentaVo.IdPagoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPagoVenta"]);
        pagoVentaVo.TipoDocumento = ((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString();
        pagoVentaVo.IdDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDocumento"].ToString());
        pagoVentaVo.FolioDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioDocumento"].ToString());
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
        pagoVentaVo.TipoPago = ((DbDataReader) mySqlDataReader)["tipoPago"].ToString();
        pagoVentaVo.MontoPagoMasivo = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["montoPagoMasivo"].ToString());
        list.Add(pagoVentaVo);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void eliminaPagoVenta(string tipoDoc, int idDoc, int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM pagosventas WHERE\r\n                                                                 tipoDocumento=@tipoDoc AND\r\n                                                                 idDocumento=@idDoc AND\r\n                                                                 folioDocumento=@folio";
      command.Parameters.AddWithValue("@tipoDoc", (object) tipoDoc);
      command.Parameters.AddWithValue("@idDoc", (object) idDoc);
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public string modificaPagoVenta(List<PagoVentaVO> lista, string tipoDoc, int idDoc, int folio, DateTime fechaIng, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      foreach (PagoVentaVO pvVO in this.listaPagosVenta(tipoDoc, idDoc, folio))
      {
        if (pvVO.TipoPago.Equals("NC"))
        {
          pvVO.Monto = pvVO.Monto * new Decimal(-1);
          this.modificaMontoUsadoNC(pvVO);
        }
        if (pvVO.TipoPago.Equals("NCE"))
        {
          pvVO.Monto = pvVO.Monto * new Decimal(-1);
          this.modificaMontoUsadoNCE(pvVO);
        }
      }
      try
      {
        this.eliminaPagoVenta(tipoDoc, idDoc, folio);
      }
      catch (Exception ex)
      {
        return "Error Elimina Pago: " + ex.Message;
      }
      foreach (PagoVentaVO pvVO in lista)
      {
        try
        {
          this.agregarPagoVenta(pvVO, tipoDoc, idDoc, folio, fechaIng);
          if (pvVO.TipoPago.Equals("NC"))
            this.modificaMontoUsadoNC(pvVO);
          if (pvVO.TipoPago.Equals("NCE"))
            this.modificaMontoUsadoNCE(pvVO);
        }
        catch (Exception ex)
        {
          return "Error Agregar Nuevos Pagos: " + ex.Message;
        }
      }
      try
      {
        if (tipoDoc.Equals("FACTURA"))
          this.cambiaEstadoFactura(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA_ELECTRONICA"))
          this.cambiaEstadoFacturaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA_EXENTA_ELECTRONICA"))
          this.cambiaEstadoFacturaExentaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA EXENTA"))
          this.cambiaEstadoFacturaExenta(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA"))
          this.cambiaEstadoBoleta(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("VOUCHER"))
          this.cambiaEstadoVoucher(idDoc, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA FISCAL"))
          this.cambiaEstadoBoletaFiscal(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA_ELECTRONICA"))
          this.cambiaEstadoBoletaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
      }
      catch (Exception ex)
      {
        return "Error ACTUALIZA ESTADO DOCUMENTO: " + ex.Message;
      }
      return "Pagos Ingresados";
    }

    public string AgregaPagoDesdeModuloCuentaCorriente(PagoVentaVO pvVO, string tipoDoc, int idDoc, int folio, DateTime fechaIng, string estadoPago, Decimal tPagado, Decimal tDocumentado, Decimal tPendiente)
    {
      try
      {
        this.agregarPagoVenta(pvVO, tipoDoc, idDoc, folio, fechaIng);
      }
      catch (Exception ex)
      {
        return "Error Agregar Nuevos Pagos: " + ex.Message;
      }
      try
      {
        if (tipoDoc.Equals("FACTURA"))
          this.cambiaEstadoFactura(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA_ELECTRONICA"))
          this.cambiaEstadoFacturaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA_EXENTA_ELECTRONICA"))
          this.cambiaEstadoFacturaExentaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("FACTURA EXENTA"))
          this.cambiaEstadoFacturaExenta(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA"))
          this.cambiaEstadoBoleta(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("VOUCHER"))
          this.cambiaEstadoVoucher(idDoc, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA FISCAL"))
          this.cambiaEstadoBoletaFiscal(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
        if (tipoDoc.Equals("BOLETA_ELECTRONICA"))
          this.cambiaEstadoBoletaElectronica(idDoc, folio, estadoPago, tPagado, tDocumentado, tPendiente);
      }
      catch (Exception ex)
      {
        return "Error ACTUALIZA ESTADO DOCUMENTO: " + ex.Message;
      }
      return "Pagos Ingresados";
    }

    public DataTable comprobanteFactura(int folio, int idFac)
    {
      string str = "SELECT\r\n                                facturas.idFactura,\r\n                                facturas.folio,\r\n                                facturas.fechaEmision,\r\n                                facturas.fechaVencimiento,\r\n                                facturas.dia,\r\n                                facturas.mes,\r\n                                facturas.ano,\r\n                                facturas.idCliente,\r\n                                facturas.rut, \r\n                                facturas.digito,\r\n                                facturas.razonSocial,\r\n                                facturas.direccion,\r\n                                facturas.comuna,\r\n                                facturas.ciudad,\r\n                                facturas.giro,\r\n                                facturas.fono,\r\n                                facturas.fax,\r\n                                facturas.contacto,\r\n                                facturas.diasPlazo,\r\n                                facturas.idMedioPago,\r\n                                facturas.medioPago,\r\n                                facturas.idVendedor,\r\n                                facturas.vendedor,\r\n                                facturas.idCentroCosto,\r\n                                facturas.centroCosto,\r\n                                facturas.ordenCompra,\r\n                                facturas.subtotal,\r\n                                facturas.porcentajeDescuento,\r\n                                facturas.descuento,\r\n                                facturas.porcentajeIva,\r\n                                facturas.iva,\r\n                                facturas.neto,\r\n                                facturas.total, \r\n                                facturas.totalPalabras,\r\n                                facturas.estadoPago,\r\n                                facturas.estadoDocumento,\r\n                                facturas.totalPagado,\r\n                                facturas.totalDocumentado,\r\n                                facturas.totalPendiente,\r\n                                pagosventas.idPagoVenta,\r\n                                pagosventas.tipoDocumento,\r\n                                pagosventas.idDocumento,\r\n                                pagosventas.folioDocumento,\r\n                                pagosventas.idMedioPagoPV,\r\n                                pagosventas.medioPagoPV,\r\n                                pagosventas.estadoPagoPV,\r\n                                pagosventas.monto,\r\n                                pagosventas.fechaCobro,\r\n                                pagosventas.fechaIngreso,\r\n                                pagosventas.banco, \r\n                                pagosventas.cuenta,\r\n                                pagosventas.numeroDocumento,\r\n                                pagosventas.observaciones\r\n                                FROM facturas INNER JOIN  pagosventas\r\n                                ON facturas.idFactura = pagosventas.idDocumento AND facturas.folio = pagosventas.folioDocumento AND pagosventas.tipoDocumento='FACTURA'\r\n                                WHERE facturas.folio=@folio AND facturas.idFactura = @idFac ORDER BY pagosventas.idPagoVenta";
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

    public DataTable comprobanteFacturaElectronica(int folio, int idFac)
    {
      string str = "SELECT\r\n                                electronica_factura.idFactura,\r\n                                electronica_factura.folio,\r\n                                electronica_factura.fechaEmision,\r\n                                electronica_factura.fechaVencimiento,\r\n                                electronica_factura.dia,\r\n                                electronica_factura.mes,\r\n                                electronica_factura.ano,\r\n                                electronica_factura.idCliente,\r\n                                electronica_factura.rut, \r\n                                electronica_factura.digito,\r\n                                electronica_factura.razonSocial,\r\n                                electronica_factura.direccion,\r\n                                electronica_factura.comuna,\r\n                                electronica_factura.ciudad,\r\n                                electronica_factura.giro,\r\n                                electronica_factura.fono,\r\n                                electronica_factura.fax,\r\n                                electronica_factura.contacto,\r\n                                electronica_factura.diasPlazo,\r\n                                electronica_factura.idMedioPago,\r\n                                electronica_factura.medioPago,\r\n                                electronica_factura.idVendedor,\r\n                                electronica_factura.vendedor,\r\n                                electronica_factura.idCentroCosto,\r\n                                electronica_factura.centroCosto,\r\n                                electronica_factura.ordenCompra,\r\n                                electronica_factura.subtotal,\r\n                                electronica_factura.porcentajeDescuento,\r\n                                electronica_factura.descuento,\r\n                                electronica_factura.porcentajeIva,\r\n                                electronica_factura.iva,\r\n                                electronica_factura.neto,\r\n                                electronica_factura.total, \r\n                                electronica_factura.totalPalabras,\r\n                                electronica_factura.estadoPago,\r\n                                electronica_factura.estadoDocumento,\r\n                                electronica_factura.totalPagado,\r\n                                electronica_factura.totalDocumentado,\r\n                                electronica_factura.totalPendiente,\r\n                                pagosventas.idPagoVenta,\r\n                                pagosventas.tipoDocumento,\r\n                                pagosventas.idDocumento,\r\n                                pagosventas.folioDocumento,\r\n                                pagosventas.idMedioPagoPV,\r\n                                pagosventas.medioPagoPV,\r\n                                pagosventas.estadoPagoPV,\r\n                                pagosventas.monto,\r\n                                pagosventas.fechaCobro,\r\n                                pagosventas.fechaIngreso,\r\n                                pagosventas.banco, \r\n                                pagosventas.cuenta,\r\n                                pagosventas.numeroDocumento,\r\n                                pagosventas.observaciones\r\n                                FROM electronica_factura INNER JOIN  pagosventas\r\n                                ON electronica_factura.idFactura = pagosventas.idDocumento AND electronica_factura.folio = pagosventas.folioDocumento AND pagosventas.tipoDocumento='FACTURA_ELECTRONICA'\r\n                                WHERE electronica_factura.folio=@folio AND electronica_factura.idFactura = @idFac ORDER BY pagosventas.idPagoVenta";
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

    public DataTable comprobanteFacturaExentaElectronica(int folio, int idFac)
    {
      string str = "SELECT\r\n                                electronica_factura_exenta.idFactura,\r\n                                electronica_factura_exenta.folio,\r\n                                electronica_factura_exenta.fechaEmision,\r\n                                electronica_factura_exenta.fechaVencimiento,\r\n                                electronica_factura_exenta.dia,\r\n                                electronica_factura_exenta.mes,\r\n                                electronica_factura_exenta.ano,\r\n                                electronica_factura_exenta.idCliente,\r\n                                electronica_factura_exenta.rut, \r\n                                electronica_factura_exenta.digito,\r\n                                electronica_factura_exenta.razonSocial,\r\n                                electronica_factura_exenta.direccion,\r\n                                electronica_factura_exenta.comuna,\r\n                                electronica_factura_exenta.ciudad,\r\n                                electronica_factura_exenta.giro,\r\n                                electronica_factura_exenta.fono,\r\n                                electronica_factura_exenta.fax,\r\n                                electronica_factura_exenta.contacto,\r\n                                electronica_factura_exenta.diasPlazo,\r\n                                electronica_factura_exenta.idMedioPago,\r\n                                electronica_factura_exenta.medioPago,\r\n                                electronica_factura_exenta.idVendedor,\r\n                                electronica_factura_exenta.vendedor,\r\n                                electronica_factura_exenta.idCentroCosto,\r\n                                electronica_factura_exenta.centroCosto,\r\n                                electronica_factura_exenta.ordenCompra,\r\n                                electronica_factura_exenta.subtotal,\r\n                                electronica_factura_exenta.porcentajeDescuento,\r\n                                electronica_factura_exenta.descuento,\r\n                                electronica_factura_exenta.porcentajeIva,\r\n                                electronica_factura_exenta.iva,\r\n                                electronica_factura_exenta.neto,\r\n                                electronica_factura_exenta.total, \r\n                                electronica_factura_exenta.totalPalabras,\r\n                                electronica_factura_exenta.estadoPago,\r\n                                electronica_factura_exenta.estadoDocumento,\r\n                                electronica_factura_exenta.totalPagado,\r\n                                electronica_factura_exenta.totalDocumentado,\r\n                                electronica_factura_exenta.totalPendiente,\r\n                                pagosventas.idPagoVenta,\r\n                                pagosventas.tipoDocumento,\r\n                                pagosventas.idDocumento,\r\n                                pagosventas.folioDocumento,\r\n                                pagosventas.idMedioPagoPV,\r\n                                pagosventas.medioPagoPV,\r\n                                pagosventas.estadoPagoPV,\r\n                                pagosventas.monto,\r\n                                pagosventas.fechaCobro,\r\n                                pagosventas.fechaIngreso,\r\n                                pagosventas.banco, \r\n                                pagosventas.cuenta,\r\n                                pagosventas.numeroDocumento,\r\n                                pagosventas.observaciones\r\n                                FROM electronica_factura_exenta INNER JOIN  pagosventas\r\n                                ON electronica_factura_exenta.idFactura = pagosventas.idDocumento AND electronica_factura_exenta.folio = pagosventas.folioDocumento AND pagosventas.tipoDocumento='FACTURA_ELECTRONICA_EXENTA'\r\n                                WHERE electronica_factura_exenta.folio=@folio AND electronica_factura_exenta.idFactura = @idFac ORDER BY pagosventas.idPagoVenta";
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

    public DataTable comprobanteBoleta(int folio, int idFac)
    {
      string str = "SELECT\r\n                                boletas.idBoleta,\r\n                                boletas.folio,\r\n                                boletas.fechaEmision,\r\n                                boletas.fechaVencimiento,\r\n                                boletas.dia,\r\n                                boletas.mes,\r\n                                boletas.ano,\r\n                                boletas.idCliente,\r\n                                boletas.rut, \r\n                                boletas.digito,\r\n                                boletas.razonSocial,\r\n                                boletas.direccion,\r\n                                boletas.comuna,\r\n                                boletas.ciudad,\r\n                                boletas.giro,\r\n                                boletas.fono,\r\n                                boletas.fax,\r\n                                boletas.contacto,\r\n                                boletas.diasPlazo,\r\n                                boletas.idMedioPago,\r\n                                boletas.medioPago,\r\n                                boletas.idVendedor,\r\n                                boletas.vendedor,\r\n                                boletas.idCentroCosto,\r\n                                boletas.centroCosto,\r\n                                boletas.ordenCompra,\r\n                                boletas.subtotal,\r\n                                boletas.porcentajeDescuento,\r\n                                boletas.descuento,\r\n                                boletas.porcentajeIva,\r\n                                boletas.iva,\r\n                                boletas.neto,\r\n                                boletas.total, \r\n                                boletas.totalaCobrar,\r\n                                boletas.totalPalabras,\r\n                                boletas.estadoPago,\r\n                                boletas.estadoDocumento,\r\n                                boletas.totalPagado,\r\n                                boletas.totalDocumentado,\r\n                                boletas.totalPendiente,\r\n                                pagosventas.idPagoVenta,\r\n                                pagosventas.tipoDocumento,\r\n                                pagosventas.idDocumento,\r\n                                pagosventas.folioDocumento,\r\n                                pagosventas.idMedioPagoPV,\r\n                                pagosventas.medioPagoPV,\r\n                                pagosventas.estadoPagoPV,\r\n                                pagosventas.monto,\r\n                                pagosventas.fechaCobro,\r\n                                pagosventas.fechaIngreso,\r\n                                pagosventas.banco, \r\n                                pagosventas.cuenta,\r\n                                pagosventas.numeroDocumento,\r\n                                pagosventas.observaciones\r\n                                FROM boletas INNER JOIN  pagosventas\r\n                                ON boletas.idBoleta = pagosventas.idDocumento AND boletas.folio = pagosventas.folioDocumento AND pagosventas.tipoDocumento='BOLETA'\r\n                                WHERE boletas.folio=@folio AND boletas.idBoleta = @idFac ORDER BY pagosventas.idPagoVenta";
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

    public DataTable comprobanteBoletaFiscal(int folio, int idFac)
    {
      string str = "SELECT\r\n                                boletasfiscal.idBoleta,\r\n                                boletasfiscal.folio,\r\n                                boletasfiscal.fechaEmision,\r\n                                boletasfiscal.fechaVencimiento,\r\n                                boletasfiscal.dia,\r\n                                boletasfiscal.mes,\r\n                                boletasfiscal.ano,\r\n                                boletasfiscal.idCliente,\r\n                                boletasfiscal.rut, \r\n                                boletasfiscal.digito,\r\n                                boletasfiscal.razonSocial,\r\n                                boletasfiscal.direccion,\r\n                                boletasfiscal.comuna,\r\n                                boletasfiscal.ciudad,\r\n                                boletasfiscal.giro,\r\n                                boletasfiscal.fono,\r\n                                boletasfiscal.fax,\r\n                                boletasfiscal.contacto,\r\n                                boletasfiscal.diasPlazo,\r\n                                boletasfiscal.idMedioPago,\r\n                                boletasfiscal.medioPago,\r\n                                boletasfiscal.idVendedor,\r\n                                boletasfiscal.vendedor,\r\n                                boletasfiscal.idCentroCosto,\r\n                                boletasfiscal.centroCosto,\r\n                                boletasfiscal.ordenCompra,\r\n                                boletasfiscal.subtotal,\r\n                                boletasfiscal.porcentajeDescuento,\r\n                                boletasfiscal.descuento,\r\n                                boletasfiscal.porcentajeIva,\r\n                                boletasfiscal.iva,\r\n                                boletasfiscal.neto,\r\n                                boletasfiscal.total, \r\n                                boletasfiscal.totalaCobrar,\r\n                                boletasfiscal.totalPalabras,\r\n                                boletasfiscal.estadoPago,\r\n                                boletasfiscal.estadoDocumento,\r\n                                boletasfiscal.totalPagado,\r\n                                boletasfiscal.totalDocumentado,\r\n                                boletasfiscal.totalPendiente,\r\n                                pagosventas.idPagoVenta,\r\n                                pagosventas.tipoDocumento,\r\n                                pagosventas.idDocumento,\r\n                                pagosventas.folioDocumento,\r\n                                pagosventas.idMedioPagoPV,\r\n                                pagosventas.medioPagoPV,\r\n                                pagosventas.estadoPagoPV,\r\n                                pagosventas.monto,\r\n                                pagosventas.fechaCobro,\r\n                                pagosventas.fechaIngreso,\r\n                                pagosventas.banco, \r\n                                pagosventas.cuenta,\r\n                                pagosventas.numeroDocumento,\r\n                                pagosventas.observaciones\r\n                                FROM boletasfiscal INNER JOIN  pagosventas\r\n                                ON boletasfiscal.idBoleta = pagosventas.idDocumento AND boletasfiscal.folio = pagosventas.folioDocumento AND pagosventas.tipoDocumento='BOLETA FISCAL'\r\n                                WHERE boletasfiscal.folio=@folio AND boletasfiscal.idBoleta = @idFac ORDER BY pagosventas.idPagoVenta";
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

    public DataTable pagoVentaInforme(string filtro)
    {
      string str1 = "SELECT\r\n                                        pagosventas.idPagoVenta,\r\n                                        pagosventas.tipoDocumento,\r\n                                        pagosventas.idDocumento,\r\n                                        pagosventas.folioDocumento,\r\n                                        pagosventas.idMedioPagoPV,\r\n                                        pagosventas.medioPagoPV,\r\n                                        pagosventas.estadoPagoPV,\r\n                                        pagosventas.monto,\r\n                                        pagosventas.fechaCobro,\r\n                                        pagosventas.fechaIngreso,\r\n                                        pagosventas.banco, \r\n                                        pagosventas.cuenta,\r\n                                        pagosventas.numeroDocumento,\r\n                                        pagosventas.observaciones,\r\n                                        facturas.RazonSocial,\r\n                                        facturas.rut,\r\n                                        facturas.digito,\r\n                                        facturas.caja                                \r\n                                FROM pagosventas INNER JOIN facturas ON facturas.folio = pagosventas.folioDocumento                                                        \r\n                                WHERE " + filtro + " AND pagosventas.tipoDocumento='FACTURA' ORDER BY pagosventas.idPagoVenta";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str1;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str2 = "SELECT\r\n                                        pagosventas.idPagoVenta,\r\n                                        pagosventas.tipoDocumento,\r\n                                        pagosventas.idDocumento,\r\n                                        pagosventas.folioDocumento,\r\n                                        pagosventas.idMedioPagoPV,\r\n                                        pagosventas.medioPagoPV,\r\n                                        pagosventas.estadoPagoPV,\r\n                                        pagosventas.monto,\r\n                                        pagosventas.fechaCobro,\r\n                                        pagosventas.fechaIngreso,\r\n                                        pagosventas.banco, \r\n                                        pagosventas.cuenta,\r\n                                        pagosventas.numeroDocumento,\r\n                                        pagosventas.observaciones,\r\n                                        electronica_factura.RazonSocial,\r\n                                        electronica_factura.rut,\r\n                                        electronica_factura.digito,\r\n                                        electronica_factura.caja                                \r\n                                FROM pagosventas INNER JOIN electronica_factura ON electronica_factura.folio = pagosventas.folioDocumento                                                        \r\n                                WHERE " + filtro + " AND pagosventas.tipoDocumento='FACTURA_ELECTRONICA' ORDER BY pagosventas.idPagoVenta";
      ((DbCommand) command).CommandText = str2;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str3 = "SELECT\r\n                                        pagosventas.idPagoVenta,\r\n                                        pagosventas.tipoDocumento,\r\n                                        pagosventas.idDocumento,\r\n                                        pagosventas.folioDocumento,\r\n                                        pagosventas.idMedioPagoPV,\r\n                                        pagosventas.medioPagoPV,\r\n                                        pagosventas.estadoPagoPV,\r\n                                        pagosventas.monto,\r\n                                        pagosventas.fechaCobro,\r\n                                        pagosventas.fechaIngreso,\r\n                                        pagosventas.banco, \r\n                                        pagosventas.cuenta,\r\n                                        pagosventas.numeroDocumento,\r\n                                        pagosventas.observaciones,\r\n                                        facturasexentas.RazonSocial,\r\n                                        facturasexentas.rut,\r\n                                        facturasexentas.digito,                                \r\n                                        facturasexentas.caja\r\n                                FROM pagosventas INNER JOIN facturasexentas ON facturasexentas.folio = pagosventas.folioDocumento                                                        \r\n                                WHERE " + filtro + " AND pagosventas.tipoDocumento='FACTURA EXENTA' ORDER BY pagosventas.idPagoVenta";
      ((DbCommand) command).CommandText = str3;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str4 = "SELECT\r\n                                        pagosventas.idPagoVenta,\r\n                                        pagosventas.tipoDocumento,\r\n                                        pagosventas.idDocumento,\r\n                                        pagosventas.folioDocumento,\r\n                                        pagosventas.idMedioPagoPV,\r\n                                        pagosventas.medioPagoPV,\r\n                                        pagosventas.estadoPagoPV,\r\n                                        pagosventas.monto,\r\n                                        pagosventas.fechaCobro,\r\n                                        pagosventas.fechaIngreso,\r\n                                        pagosventas.banco, \r\n                                        pagosventas.cuenta,\r\n                                        pagosventas.numeroDocumento,\r\n                                        pagosventas.observaciones,\r\n                                        boletas.RazonSocial,\r\n                                        boletas.rut,\r\n                                        boletas.digito,\r\n                                        boletas.caja                                \r\n                                FROM pagosventas INNER JOIN boletas ON boletas.folio = pagosventas.folioDocumento                                                        \r\n                                WHERE " + filtro + " AND pagosventas.tipoDocumento='BOLETA' ORDER BY pagosventas.idPagoVenta";
      ((DbCommand) command).CommandText = str4;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str5 = "SELECT\r\n                                        pagosventas.idPagoVenta,\r\n                                        pagosventas.tipoDocumento,\r\n                                        pagosventas.idDocumento,\r\n                                        pagosventas.folioDocumento,\r\n                                        pagosventas.idMedioPagoPV,\r\n                                        pagosventas.medioPagoPV,\r\n                                        pagosventas.estadoPagoPV,\r\n                                        pagosventas.monto,\r\n                                        pagosventas.fechaCobro,\r\n                                        pagosventas.fechaIngreso,\r\n                                        pagosventas.banco, \r\n                                        pagosventas.cuenta,\r\n                                        pagosventas.numeroDocumento,\r\n                                        pagosventas.observaciones,\r\n                                        boletasFiscal.RazonSocial,\r\n                                        boletasFiscal.rut,\r\n                                        boletasFiscal.digito,\r\n                                        boletasFiscal.caja                                \r\n                                FROM pagosventas INNER JOIN boletasFiscal ON boletasFiscal.folio = pagosventas.folioDocumento                                                        \r\n                                WHERE " + filtro + " AND pagosventas.tipoDocumento='BOLETA FISCAL' ORDER BY pagosventas.idPagoVenta";
      ((DbCommand) command).CommandText = str5;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str6 = "SELECT\r\n                                        pagosventas.idPagoVenta,\r\n                                        pagosventas.tipoDocumento,\r\n                                        pagosventas.idDocumento,\r\n                                        pagosventas.folioDocumento,\r\n                                        pagosventas.idMedioPagoPV,\r\n                                        pagosventas.medioPagoPV,\r\n                                        pagosventas.estadoPagoPV,\r\n                                        pagosventas.monto,\r\n                                        pagosventas.fechaCobro,\r\n                                        pagosventas.fechaIngreso,\r\n                                        pagosventas.banco, \r\n                                        pagosventas.cuenta,\r\n                                        pagosventas.numeroDocumento,\r\n                                        pagosventas.observaciones,\r\n                                        boletas.RazonSocial,\r\n                                        boletas.rut,\r\n                                        boletas.digito,\r\n                                        boletas.caja                                \r\n                                FROM pagosventas INNER JOIN boletas ON boletas.idBoleta = pagosventas.idDocumento                                                        \r\n                                WHERE " + filtro + " AND pagosventas.tipoDocumento='VOUCHER' ORDER BY pagosventas.idPagoVenta";
      ((DbCommand) command).CommandText = str6;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
