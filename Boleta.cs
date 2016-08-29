 
 


// version 1.8.0

using Aptusoft.Lotes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace Aptusoft
{
  public class Boleta
  {
    private Conexion conexion = Conexion.getConecta();
    private string camposBoleta = "'BOLETA' as tipoDocumentoVenta,\r\n                                        boletas.idBoleta,\r\n                                        boletas.tipoDocumento,\r\n                                        boletas.folio,\r\n                                        boletas.fechaEmision,\r\n                                        boletas.fechaVencimiento,\r\n                                        boletas.dia,\r\n                                        boletas.mes,\r\n                                        boletas.ano,\r\n                                        boletas.idCliente, \r\n                                        boletas.rut, \r\n                                        boletas.digito, \r\n                                        boletas.razonSocial,\r\n                                        boletas.direccion, \r\n                                        boletas.comuna, \r\n                                        boletas.ciudad, \r\n                                        boletas.giro, \r\n                                        boletas.fono, \r\n                                        boletas.fax, \r\n                                        boletas.contacto, \r\n                                        boletas.diasPlazo, \r\n                                        boletas.idMedioPago,                          \r\n                                        boletas.medioPago, \r\n                                        boletas.idVendedor, \r\n                                        boletas.vendedor, \r\n                                        boletas.idCentroCosto, \r\n                                        boletas.centroCosto, \r\n                                        boletas.ordenCompra, \r\n                                        boletas.subtotal, \r\n                                        boletas.porcentajeDescuento,\r\n                                        boletas.descuento, \r\n                                        boletas.porcentajeIva, \r\n                                        boletas.iva,\r\n                                        boletas.neto, \r\n                                        boletas.total, \r\n                                        boletas.totalExento,\r\n                                        boletas.totalaCobrar,\r\n                                        boletas.totalPalabras, \r\n                                        boletas.estadoPago, \r\n                                        boletas.estadoDocumento,\r\n                                        boletas.totalPagado,\r\n                                        boletas.totalDocumentado,\r\n                                        boletas.totalPendiente,\r\n                                        boletas.pagaCon,\r\n                                        boletas.vuelto,             \r\n                                        boletas.impuesto1,\r\n                                        boletas.impuesto2,\r\n                                        boletas.impuesto3,\r\n                                        boletas.impuesto4,\r\n                                        boletas.impuesto5,\r\n                                        boletas.porcentajeImpuesto1,\r\n                                        boletas.porcentajeImpuesto2,\r\n                                        boletas.porcentajeImpuesto3,\r\n                                        boletas.porcentajeImpuesto4,\r\n                                        boletas.porcentajeImpuesto5,\r\n                                        boletas.comisionVendedor,\r\n                                        boletas.idTicket,\r\n                                        boletas.folioTicket,\r\n                                        boletas.caja,\r\n                                        boletas.idCotizacion,\r\n                                        boletas.folioCotizacion,\r\n                                        boletas.idNotaVenta,\r\n                                        boletas.folioNotaVenta,\r\n                                        boletas.idComanda,\r\n                                        boletas.folioComanda,\r\n                                        boletas.idGarzon,\r\n                                        boletas.garzon,\r\n                                        boletas.numeroVoucher,\r\n                                        detalleboleta.idDetalleboleta,                               \r\n                                        detalleboleta.idBoletaLinea,\r\n                                        detalleboleta.folioBoleta,\r\n                                        detalleboleta.fechaIngreso,\r\n                                        detalleboleta.codigo,\r\n                                        detalleboleta.descripcion,\r\n                                        detalleboleta.valorVenta,\r\n                                        detalleboleta.cantidad,\r\n                                        detalleboleta.porcentajeDescuentoLinea,\r\n                                        detalleboleta.descuentoLinea,\r\n                                        detalleboleta.subtotalLinea, \r\n                                        detalleboleta.totalLinea, \r\n                                        detalleboleta.tipoDescuento, \r\n                                        detalleboleta.listaPrecio, \r\n                                        detalleboleta.bodega,                                       \r\n                                        detalleboleta.exento, \r\n                                        detalleboleta.idImpuesto, \r\n                                        detalleboleta.netoLinea,\r\n                                        detalleboleta.valorCompra";
    private string camposBoletaDetalle = "'BOLETA' as tipoDocumentoVenta,\r\n                                        boletas.idBoleta,\r\n                                        boletas.folio,\r\n                                        boletas.fechaEmision, \r\n                                        boletas.idMedioPago,                          \r\n                                        boletas.medioPago, \r\n                                        boletas.idVendedor, \r\n                                        boletas.vendedor, \r\n                                        boletas.idCentroCosto, \r\n                                        boletas.centroCosto,                                        \r\n                                        boletas.subtotal, \r\n                                        boletas.porcentajeDescuento,\r\n                                        boletas.descuento, \r\n                                        boletas.porcentajeIva, \r\n                                        boletas.iva,\r\n                                        boletas.neto, \r\n                                        boletas.total, \r\n                                        boletas.totalExento,\r\n                                        boletas.totalaCobrar,\r\n                                        boletas.totalPalabras, \r\n                                        boletas.estadoPago, \r\n                                        boletas.estadoDocumento,\r\n                                        boletas.totalPagado,\r\n                                        boletas.totalDocumentado,\r\n                                        boletas.totalPendiente,\r\n                                        boletas.pagaCon,\r\n                                        boletas.vuelto,             \r\n                                        boletas.impuesto1,\r\n                                        boletas.impuesto2,\r\n                                        boletas.impuesto3,\r\n                                        boletas.impuesto4,\r\n                                        boletas.impuesto5,\r\n                                        boletas.porcentajeImpuesto1,\r\n                                        boletas.porcentajeImpuesto2,\r\n                                        boletas.porcentajeImpuesto3,\r\n                                        boletas.porcentajeImpuesto4,\r\n                                        boletas.porcentajeImpuesto5,                                        \r\n                                        detalleboleta.idDetalleboleta,                               \r\n                                        detalleboleta.idBoletaLinea,\r\n                                        detalleboleta.folioBoleta,\r\n                                        detalleboleta.fechaIngreso,\r\n                                        detalleboleta.codigo,\r\n                                        detalleboleta.descripcion,\r\n                                        detalleboleta.valorVenta,\r\n                                        detalleboleta.cantidad,\r\n                                        detalleboleta.porcentajeDescuentoLinea,\r\n                                        detalleboleta.descuentoLinea,\r\n                                        detalleboleta.subtotalLinea, \r\n                                        detalleboleta.totalLinea, \r\n                                        detalleboleta.tipoDescuento, \r\n                                        detalleboleta.listaPrecio, \r\n                                        detalleboleta.bodega,                                       \r\n                                        detalleboleta.exento, \r\n                                        detalleboleta.idImpuesto, \r\n                                        detalleboleta.netoLinea,\r\n                                        detalleboleta.valorCompra";
    private string camposBoletaDetalleResumen = "'BOLETA' as tipoDocumentoVenta,\r\n                                        boletas.idBoleta,\r\n                                        boletas.folio,\r\n                                        boletas.fechaEmision, \r\n                                        boletas.idMedioPago,                          \r\n                                        boletas.medioPago, \r\n                                        boletas.idVendedor, \r\n                                        boletas.vendedor, \r\n                                        boletas.idCentroCosto, \r\n                                        boletas.centroCosto,    \r\n                                        boletas.descuento,                                         \r\n                                        boletas.iva,\r\n                                        boletas.neto, \r\n                                        boletas.total, \r\n                                        boletas.totalExento,\r\n                                        boletas.totalaCobrar, \r\n                                        boletas.caja,\r\n                                        detalleboleta.codigo,\r\n                                        detalleboleta.descripcion,\r\n                                        detalleboleta.valorVenta,\r\n                                        detalleboleta.cantidad,                                        \r\n                                        detalleboleta.descuentoLinea,\r\n                                        detalleboleta.subtotalLinea, \r\n                                        detalleboleta.totalLinea,\r\n                                        detalleboleta.bodega,                                       \r\n                                        detalleboleta.exento,                                          \r\n                                        detalleboleta.netoLinea,\r\n                                        detalleboleta.valorCompra";
    private string campospos = "'BOLETA' as tipoDocumentoVenta,\r\n                                        boletas.idBoleta,\r\n                                        boletas.tipoDocumento,\r\n                                        boletas.numeroVoucher as folio,\r\n                                        boletas.fechaEmision,\r\n                                        boletas.fechaVencimiento,\r\n                                        boletas.dia,\r\n                                        boletas.mes,\r\n                                        boletas.ano,\r\n                                        boletas.idCliente, \r\n                                        boletas.rut, \r\n                                        boletas.digito, \r\n                                        boletas.razonSocial,\r\n                                        boletas.direccion, \r\n                                        boletas.comuna, \r\n                                        boletas.ciudad, \r\n                                        boletas.giro, \r\n                                        boletas.fono, \r\n                                        boletas.fax, \r\n                                        boletas.contacto, \r\n                                        boletas.diasPlazo, \r\n                                        boletas.idMedioPago,                          \r\n                                        boletas.medioPago, \r\n                                        boletas.idVendedor, \r\n                                        boletas.vendedor, \r\n                                        boletas.idCentroCosto, \r\n                                        boletas.centroCosto, \r\n                                        boletas.ordenCompra, \r\n                                        boletas.subtotal, \r\n                                        boletas.porcentajeDescuento,\r\n                                        boletas.descuento, \r\n                                        boletas.porcentajeIva, \r\n                                        boletas.iva,\r\n                                        boletas.neto, \r\n                                        boletas.total, \r\n                                        boletas.totalExento,\r\n                                        boletas.totalaCobrar,\r\n                                        boletas.totalPalabras, \r\n                                        boletas.estadoPago, \r\n                                        boletas.estadoDocumento,\r\n                                        boletas.totalPagado,\r\n                                        boletas.totalDocumentado,\r\n                                        boletas.totalPendiente,\r\n                                        boletas.pagaCon,\r\n                                        boletas.vuelto,             \r\n                                        boletas.impuesto1,\r\n                                        boletas.impuesto2,\r\n                                        boletas.impuesto3,\r\n                                        boletas.impuesto4,\r\n                                        boletas.impuesto5,\r\n                                        boletas.porcentajeImpuesto1,\r\n                                        boletas.porcentajeImpuesto2,\r\n                                        boletas.porcentajeImpuesto3,\r\n                                        boletas.porcentajeImpuesto4,\r\n                                        boletas.porcentajeImpuesto5,\r\n                                        boletas.comisionVendedor,\r\n                                        boletas.idTicket,\r\n                                        boletas.folioTicket,\r\n                                        boletas.caja,\r\n                                        boletas.idCotizacion,\r\n                                        boletas.folioCotizacion,\r\n                                        boletas.idNotaVenta,\r\n                                        boletas.folioNotaVenta,\r\n                                        boletas.idComanda,\r\n                                        boletas.folioComanda,\r\n                                        boletas.idGarzon,\r\n                                        boletas.garzon,\r\n                                        boletas.numeroVoucher,\r\n                                        detalleboleta.idDetalleboleta,                               \r\n                                        detalleboleta.idBoletaLinea,\r\n                                        detalleboleta.folioBoleta,\r\n                                        detalleboleta.fechaIngreso,\r\n                                        detalleboleta.codigo,\r\n                                        detalleboleta.descripcion,\r\n                                        detalleboleta.valorVenta,\r\n                                        detalleboleta.cantidad,\r\n                                        detalleboleta.porcentajeDescuentoLinea,\r\n                                        detalleboleta.descuentoLinea,\r\n                                        detalleboleta.subtotalLinea, \r\n                                        detalleboleta.totalLinea, \r\n                                        detalleboleta.tipoDescuento, \r\n                                        detalleboleta.listaPrecio, \r\n                                        detalleboleta.bodega,                                       \r\n                                        detalleboleta.exento, \r\n                                        detalleboleta.idImpuesto, \r\n                                        detalleboleta.netoLinea,\r\n                                        detalleboleta.valorCompra";
    private string camposposDetalle = "'BOLETA' as tipoDocumentoVenta,\r\n                                        boletas.idBoleta,\r\n                                        boletas.numeroVoucher as folio,\r\n                                        boletas.fechaEmision, \r\n                                        boletas.idMedioPago,                          \r\n                                        boletas.medioPago, \r\n                                        boletas.idVendedor, \r\n                                        boletas.vendedor, \r\n                                        boletas.idCentroCosto, \r\n                                        boletas.centroCosto,                                        \r\n                                        boletas.subtotal, \r\n                                        boletas.porcentajeDescuento,\r\n                                        boletas.descuento, \r\n                                        boletas.porcentajeIva, \r\n                                        boletas.iva,\r\n                                        boletas.neto, \r\n                                        boletas.total, \r\n                                        boletas.totalExento,\r\n                                        boletas.totalaCobrar,\r\n                                        boletas.totalPalabras, \r\n                                        boletas.estadoPago, \r\n                                        boletas.estadoDocumento,\r\n                                        boletas.totalPagado,\r\n                                        boletas.totalDocumentado,\r\n                                        boletas.totalPendiente,\r\n                                        boletas.pagaCon,\r\n                                        boletas.vuelto,             \r\n                                        boletas.impuesto1,\r\n                                        boletas.impuesto2,\r\n                                        boletas.impuesto3,\r\n                                        boletas.impuesto4,\r\n                                        boletas.impuesto5,\r\n                                        boletas.porcentajeImpuesto1,\r\n                                        boletas.porcentajeImpuesto2,\r\n                                        boletas.porcentajeImpuesto3,\r\n                                        boletas.porcentajeImpuesto4,\r\n                                        boletas.porcentajeImpuesto5,                                        \r\n                                        detalleboleta.idDetalleboleta,                               \r\n                                        detalleboleta.idBoletaLinea,\r\n                                        detalleboleta.folioBoleta,\r\n                                        detalleboleta.fechaIngreso,\r\n                                        detalleboleta.codigo,\r\n                                        detalleboleta.descripcion,\r\n                                        detalleboleta.valorVenta,\r\n                                        detalleboleta.cantidad,\r\n                                        detalleboleta.porcentajeDescuentoLinea,\r\n                                        detalleboleta.descuentoLinea,\r\n                                        detalleboleta.subtotalLinea, \r\n                                        detalleboleta.totalLinea, \r\n                                        detalleboleta.tipoDescuento, \r\n                                        detalleboleta.listaPrecio, \r\n                                        detalleboleta.bodega,                                       \r\n                                        detalleboleta.exento, \r\n                                        detalleboleta.idImpuesto, \r\n                                        detalleboleta.netoLinea,\r\n                                        detalleboleta.valorCompra";
    private string camposposDetalleResumen = "'BOLETA' as tipoDocumentoVenta,\r\n                                        boletas.idBoleta,\r\n                                        boletas.numeroVoucher as folio,\r\n                                        boletas.fechaEmision, \r\n                                        boletas.idMedioPago,                          \r\n                                        boletas.medioPago, \r\n                                        boletas.idVendedor, \r\n                                        boletas.vendedor, \r\n                                        boletas.idCentroCosto, \r\n                                        boletas.centroCosto,    \r\n                                        boletas.descuento,                                         \r\n                                        boletas.iva,\r\n                                        boletas.neto, \r\n                                        boletas.total, \r\n                                        boletas.totalExento,\r\n                                        boletas.totalaCobrar, \r\n                                        boletas.caja,\r\n                                        detalleboleta.codigo,\r\n                                        detalleboleta.descripcion,\r\n                                        detalleboleta.valorVenta,\r\n                                        detalleboleta.cantidad,                                        \r\n                                        detalleboleta.descuentoLinea,\r\n                                        detalleboleta.subtotalLinea, \r\n                                        detalleboleta.totalLinea,\r\n                                        detalleboleta.bodega,                                       \r\n                                        detalleboleta.exento,                                          \r\n                                        detalleboleta.netoLinea,\r\n                                        detalleboleta.valorCompra";

    public void guardaBoleta(Venta veOB, List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      if (veOB.Total == new Decimal(0))
        veOB.Folio = 0;
      if (veOB.BoletaVoucher == "VOUCHER")
        veOB.Folio = 0;
      this.agregaBoleta(veOB);
      if (veOB.Total == new Decimal(0) || veOB.BoletaVoucher == "VOUCHER")
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT DISTINCT LAST_INSERT_ID() FROM boletas";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        int num = 0;
        while (((DbDataReader) mySqlDataReader).Read())
          num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0].ToString());
        ((DbDataReader) mySqlDataReader).Close();
        for (int index = 0; index < lista.Count; ++index)
        {
          lista[index].FolioFactura = 0;
          lista[index].IdFactura = num;
        }
      }
      this.agregaDetalleBoleta(lista, listaLote);
    }

    public string agregaBoleta(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO boletas (\r\n                                                            tipoDocumento,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            totalExento,\r\n                                                            totalaCobrar,\r\n                                                            pagaCon,\r\n                                                            vuelto,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            caja,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            idComanda,\r\n                                                            folioComanda,garzon, idGarzon, numeroVoucher\r\n                                                            ) \r\n                                                   VALUES(   \r\n                                                            @tipoDocumento,                                                         \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @totalExento,\r\n                                                            @totalaCobrar,\r\n                                                            @pagaCon,\r\n                                                            @vuelto,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @idTicket,\r\n                                                            @folioTicket,\r\n                                                            @caja,\r\n                                                            @idCotizacion,\r\n                                                            @folioCotizacion,\r\n                                                            @idNotaVenta,\r\n                                                            @folioNotaVenta,\r\n                                                            @idComanda,\r\n                                                            @folioComanda,@garzon, @idGarzon, @numeroVoucher\r\n                                                   )";
        command.Parameters.AddWithValue("@tipoDocumento", (object) veOB.BoletaVoucher);
        command.Parameters.AddWithValue("@folio", (object) veOB.Folio);
        command.Parameters.AddWithValue("@fechaEmision", (object) veOB.FechaEmision);
        command.Parameters.AddWithValue("@fechaVencimiento", (object) veOB.FechaVencimiento);
        command.Parameters.AddWithValue("@dia", (object) veOB.FechaEmision.Day.ToString());
        command.Parameters.AddWithValue("@mes", (object) string.Format("{0:MMMM}", (object) veOB.FechaEmision).ToString().ToUpper());
        command.Parameters.AddWithValue("@ano", (object) veOB.FechaEmision.Year.ToString());
        command.Parameters.AddWithValue("@idCliente", (object) veOB.IdCliente);
        command.Parameters.AddWithValue("@rut", (object) veOB.Rut);
        command.Parameters.AddWithValue("@digito", (object) veOB.Digito);
        command.Parameters.AddWithValue("@razonSocial", (object) veOB.RazonSocial);
        command.Parameters.AddWithValue("@direccion", (object) veOB.Direccion);
        command.Parameters.AddWithValue("@comuna", (object) veOB.Comuna);
        command.Parameters.AddWithValue("@ciudad", (object) veOB.Ciudad);
        command.Parameters.AddWithValue("@giro", (object) veOB.Giro);
        command.Parameters.AddWithValue("@fono", (object) veOB.Fono);
        command.Parameters.AddWithValue("@fax", (object) veOB.Fax);
        command.Parameters.AddWithValue("@contacto", (object) veOB.Contacto);
        command.Parameters.AddWithValue("@diasPlazo", (object) veOB.DiasPlazo);
        command.Parameters.AddWithValue("@idMedioPago", (object) veOB.IdMedioPago);
        command.Parameters.AddWithValue("@medioPago", (object) veOB.MedioPago);
        command.Parameters.AddWithValue("@idVendedor", (object) veOB.IdVendedor);
        command.Parameters.AddWithValue("@vendedor", (object) veOB.Vendedor);
        command.Parameters.AddWithValue("@idCentroCosto", (object) veOB.IdCentroCosto);
        command.Parameters.AddWithValue("@centroCosto", (object) veOB.CentroCosto);
        command.Parameters.AddWithValue("@ordenCompra", (object) veOB.OrdenCompra);
        command.Parameters.AddWithValue("@subtotal", (object) veOB.SubTotal);
        command.Parameters.AddWithValue("@porcentajeDescuento", (object) veOB.PorcentajeDescuento);
        command.Parameters.AddWithValue("@descuento", (object) veOB.Descuento);
        command.Parameters.AddWithValue("@porcentajeIva", (object) veOB.PorcentajeIva);
        command.Parameters.AddWithValue("@iva", (object) veOB.Iva);
        command.Parameters.AddWithValue("@neto", (object) veOB.Neto);
        command.Parameters.AddWithValue("@total", (object) veOB.Total);
        command.Parameters.AddWithValue("@totalPalabras", (object) veOB.TotalPalabras);
        command.Parameters.AddWithValue("@estadoPago", (object) veOB.EstadoPago);
        command.Parameters.AddWithValue("@estadoDocumento", (object) veOB.EstadoDocumento);
        command.Parameters.AddWithValue("@totalPagado", (object) veOB.TotalPagado);
        command.Parameters.AddWithValue("@totalDocumentado", (object) veOB.TotalDocumentado);
        command.Parameters.AddWithValue("@totalPendiente", (object) veOB.TotalPendiente);
        command.Parameters.AddWithValue("@totalExento", (object) veOB.TotalExento);
        command.Parameters.AddWithValue("@totalaCobrar", (object) veOB.TotalaCobrar);
        command.Parameters.AddWithValue("@pagaCon", (object) veOB.PagaCon);
        command.Parameters.AddWithValue("@vuelto", (object) veOB.Vuelto);
        command.Parameters.AddWithValue("@impuesto1", (object) veOB.Impuesto1);
        command.Parameters.AddWithValue("@impuesto2", (object) veOB.Impuesto2);
        command.Parameters.AddWithValue("@impuesto3", (object) veOB.Impuesto3);
        command.Parameters.AddWithValue("@impuesto4", (object) veOB.Impuesto4);
        command.Parameters.AddWithValue("@impuesto5", (object) veOB.Impuesto5);
        command.Parameters.AddWithValue("@porcentajeImpuesto1", (object) veOB.PorcentajeImpuesto1);
        command.Parameters.AddWithValue("@porcentajeImpuesto2", (object) veOB.PorcentajeImpuesto2);
        command.Parameters.AddWithValue("@porcentajeImpuesto3", (object) veOB.PorcentajeImpuesto3);
        command.Parameters.AddWithValue("@porcentajeImpuesto4", (object) veOB.PorcentajeImpuesto4);
        command.Parameters.AddWithValue("@porcentajeImpuesto5", (object) veOB.PorcentajeImpuesto5);
        command.Parameters.AddWithValue("@comisionVendedor", (object) veOB.ComisionVendedor);
        command.Parameters.AddWithValue("@idTicket", (object) veOB.IdTicket);
        command.Parameters.AddWithValue("@folioTicket", (object) veOB.FolioTicket);
        command.Parameters.AddWithValue("@caja", (object) veOB.Caja);
        command.Parameters.AddWithValue("@idCotizacion", (object) veOB.IdCotizacion);
        command.Parameters.AddWithValue("@folioCotizacion", (object) veOB.FolioCotizacion);
        command.Parameters.AddWithValue("@idNotaVenta", (object) veOB.IdNotaVenta);
        command.Parameters.AddWithValue("@folioNotaVenta", (object) veOB.FolioNotaVenta);
        command.Parameters.AddWithValue("@idComanda", (object) veOB.IdComanda);
        command.Parameters.AddWithValue("@folioComanda", (object) veOB.FolioComanda);
        command.Parameters.AddWithValue("@garzon", (object) veOB.Garzon);
        command.Parameters.AddWithValue("@idGarzon", (object) veOB.IdGarzon);
        command.Parameters.AddWithValue("@numeroVoucher", (object) veOB.NumeroVoucher);
        ((DbCommand) command).ExecuteNonQuery();
        return "Boleta Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleBoleta(List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      int num1 = 0;
      long num2 = 0L;
      foreach (DatosVentaVO veVO in lista)
      {
        if (num1 == 0)
        {
          num1 = this.retornaIdBoleta(veVO.FolioFactura);
          num2 = (long) veVO.FolioFactura;
        }
        veVO.IdFactura = num1;
        if (veVO.DescuentaInventario)
        {
          Decimal num3 = this.consultaStock(veVO);
          veVO.StockQueda = num3 - veVO.Cantidad;
          this.actualizaStock(veVO, "-");
        }
        this.agregaDetalleBoleta2(veVO);
      }
      if (listaLote.Count <= 0)
        return;
      string str = "BOLETA";
      foreach (LoteVO loteVo in listaLote)
      {
        loteVo.Documento = str;
        loteVo.IdDocumento = num1;
        loteVo.FolioDocumento = num2;
        loteVo.TipoDocumento = "VENTA";
        loteVo.Accion = "SALE";
      }
      new Lote().RegistraLote(listaLote);
    }

    public bool agregaDetalleBoleta2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura != 0 ? veVO.IdFactura : this.retornaIdBoleta(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detalleboleta (\r\n                                                            idBoletaLinea,\r\n                                                            folioBoleta,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            exento,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idBoletaLinea,\r\n                                                            @folioBoletaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @exento,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda\r\n                                                             )";
        command.Parameters.AddWithValue("@idBoletaLinea", (object) num);
        command.Parameters.AddWithValue("@folioBoletaLinea", (object) veVO.FolioFactura);
        command.Parameters.AddWithValue("@fechaIngreso", (object) veVO.FechaIngreso);
        command.Parameters.AddWithValue("@codigo", (object) veVO.Codigo);
        command.Parameters.AddWithValue("@descripcion", (object) veVO.Descripcion);
        command.Parameters.AddWithValue("@valorVenta", (object) veVO.ValorVenta);
        command.Parameters.AddWithValue("@cantidad", (object) veVO.Cantidad);
        command.Parameters.AddWithValue("@porcentajeDescuentoLinea", (object) veVO.PorcDescuento);
        command.Parameters.AddWithValue("@descuentoLinea", (object) veVO.Descuento);
        command.Parameters.AddWithValue("@subtotalLinea", (object) veVO.SubTotalLinea);
        command.Parameters.AddWithValue("@totalLinea", (object) veVO.TotalLinea);
        command.Parameters.AddWithValue("@tipoDescuento", (object) veVO.TipoDescuento);
        command.Parameters.AddWithValue("@listaPrecio", (object) veVO.ListaPrecio);
        command.Parameters.AddWithValue("@bodega", (object) veVO.Bodega);
        command.Parameters.AddWithValue("@exento", (veVO.Exento ? 1 : 0));
        command.Parameters.AddWithValue("@idImpuesto", (object) veVO.IdImpuesto);
        command.Parameters.AddWithValue("@netoLinea", (object) veVO.NetoLinea);
        command.Parameters.AddWithValue("@descuentaInventario", (veVO.DescuentaInventario ? 1 : 0));
        command.Parameters.AddWithValue("@valorCompra", (object) veVO.ValorCompra);
        command.Parameters.AddWithValue("@usuario", (object) veVO.Usuario);
        command.Parameters.AddWithValue("@stockQueda", (object) veVO.StockQueda);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        string message = ex.Message;
        return false;
      }
    }

    public bool agregaDetalleBoleta3(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detalleboleta (\r\n                                                            idBoletaLinea,\r\n                                                            folioBoleta,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            exento,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idBoletaLinea,\r\n                                                            @folioBoletaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @exento,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda\r\n                                                             )";
        command.Parameters.AddWithValue("@idBoletaLinea", (object) veVO.IdFactura);
        command.Parameters.AddWithValue("@folioBoletaLinea", (object) veVO.FolioFactura);
        command.Parameters.AddWithValue("@fechaIngreso", (object) veVO.FechaIngreso);
        command.Parameters.AddWithValue("@codigo", (object) veVO.Codigo);
        command.Parameters.AddWithValue("@descripcion", (object) veVO.Descripcion);
        command.Parameters.AddWithValue("@valorVenta", (object) veVO.ValorVenta);
        command.Parameters.AddWithValue("@cantidad", (object) veVO.Cantidad);
        command.Parameters.AddWithValue("@porcentajeDescuentoLinea", (object) veVO.PorcDescuento);
        command.Parameters.AddWithValue("@descuentoLinea", (object) veVO.Descuento);
        command.Parameters.AddWithValue("@subtotalLinea", (object) veVO.SubTotalLinea);
        command.Parameters.AddWithValue("@totalLinea", (object) veVO.TotalLinea);
        command.Parameters.AddWithValue("@tipoDescuento", (object) veVO.TipoDescuento);
        command.Parameters.AddWithValue("@listaPrecio", (object) veVO.ListaPrecio);
        command.Parameters.AddWithValue("@bodega", (object) veVO.Bodega);
        command.Parameters.AddWithValue("@exento", (veVO.Exento ? 1 : 0));
        command.Parameters.AddWithValue("@idImpuesto", (object) veVO.IdImpuesto);
        command.Parameters.AddWithValue("@netoLinea", (object) veVO.NetoLinea);
        command.Parameters.AddWithValue("@descuentaInventario", (veVO.DescuentaInventario ? 1 : 0));
        command.Parameters.AddWithValue("@valorCompra", (object) veVO.ValorCompra);
        command.Parameters.AddWithValue("@usuario", (object) veVO.Usuario);
        command.Parameters.AddWithValue("@stockQueda", (object) veVO.StockQueda);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        string message = ex.Message;
        return false;
      }
    }

    public string anulaBoleta(int idBoleta, List<DatosVentaVO> lista, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE boletas SET estadoDocumento = 'ANULADA', razonSocial= 'BOLETA ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0'  WHERE idBoleta=@idBoleta";
      command.Parameters.AddWithValue("@idBoleta", (object) idBoleta);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "BOLETA");
          this.actualizaStock(datosVentaVo, "+");
        }
      }
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      return "Boleta Anulada!!";
    }

    public int eliminaBoleta(int idBoleta)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE boletas, detalleboleta FROM boletas, detalleboleta WHERE boletas.idBoleta = @idBoleta AND detalleboleta.idBoletaLinea=@idBoleta";
      command.Parameters.AddWithValue("@idBoleta", (object) idBoleta);
      return ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaStock(DatosVentaVO veVO, string signo)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string codigo = veVO.Codigo;
      int bodega = veVO.Bodega;
      Decimal cantidad = veVO.Cantidad;
      string str = "";
      switch (bodega)
      {
        case 1:
          str = "Bodega1";
          break;
        case 2:
          str = "Bodega2";
          break;
        case 3:
          str = "Bodega3";
          break;
        case 4:
          str = "Bodega4";
          break;
        case 5:
          str = "Bodega5";
          break;
        case 6:
          str = "Bodega6";
          break;
        case 7:
          str = "Bodega7";
          break;
        case 8:
          str = "Bodega8";
          break;
        case 9:
          str = "Bodega9";
          break;
        case 10:
          str = "Bodega10";
          break;
        case 11:
          str = "Bodega11";
          break;
        case 12:
          str = "Bodega12";
          break;
        case 13:
          str = "Bodega13";
          break;
        case 14:
          str = "Bodega14";
          break;
        case 15:
          str = "Bodega15";
          break;
        case 16:
          str = "Bodega16";
          break;
        case 17:
          str = "Bodega17";
          break;
        case 18:
          str = "Bodega18";
          break;
        case 19:
          str = "Bodega19";
          break;
        case 20:
          str = "Bodega20";
          break;
      }
      ((DbCommand) command).CommandText = "UPDATE productos SET " + str + " = " + str + " " + signo + " @stock WHERE Codigo=@codigo";
      command.Parameters.AddWithValue("@stock", (object) cantidad);
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public Decimal consultaStock(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string codigo = veVO.Codigo;
      int bodega = veVO.Bodega;
      string str = "";
      switch (bodega)
      {
        case 1:
          str = "Bodega1";
          break;
        case 2:
          str = "Bodega2";
          break;
        case 3:
          str = "Bodega3";
          break;
        case 4:
          str = "Bodega4";
          break;
        case 5:
          str = "Bodega5";
          break;
        case 6:
          str = "Bodega6";
          break;
        case 7:
          str = "Bodega7";
          break;
        case 8:
          str = "Bodega8";
          break;
        case 9:
          str = "Bodega9";
          break;
        case 10:
          str = "Bodega10";
          break;
        case 11:
          str = "Bodega11";
          break;
        case 12:
          str = "Bodega12";
          break;
        case 13:
          str = "Bodega13";
          break;
        case 14:
          str = "Bodega14";
          break;
        case 15:
          str = "Bodega15";
          break;
        case 16:
          str = "Bodega16";
          break;
        case 17:
          str = "Bodega17";
          break;
        case 18:
          str = "Bodega18";
          break;
        case 19:
          str = "Bodega19";
          break;
        case 20:
          str = "Bodega20";
          break;
      }
      Decimal num = new Decimal(0);
      ((DbCommand) command).CommandText = "SELECT " + str + " FROM productos WHERE Codigo=@codigo";
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToDecimal(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int numeroBoleta(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM boletas WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }
    public Decimal[] totales_trans(string FechaInicial, string fechaFinal)
    {
        Decimal[] suma = new Decimal[4];
        string[] datos = new string[4];
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand)command).CommandText = "select count(folio) as total,sum( valor_neto) as total_neto,sum(valor_iva) as total_iva,sum( valor_exento) as total_exento  from ingresos_manuales where tipo = \"Voucher\" and DATE_FORMAT(fecha, '%Y-%m-%d') >= \"" + FechaInicial + "\" and DATE_FORMAT(fecha, '%Y-%m-%d') <= \"" + fechaFinal + "\";";
        MySqlDataReader myreader = command.ExecuteReader();

        while(myreader.Read())
        {
            if (myreader["total"].ToString() != null && myreader["total"].ToString() != "")
            {
                suma[0] += Convert.ToDecimal(myreader["total"]);
            }
            else
            {
                suma[0] += Convert.ToDecimal(0);
            }
            //datos[0] = myreader["total"].ToString();
            //suma[0] += Convert.ToDecimal(myreader["total"]);
            if (myreader["total_neto"].ToString() != null && myreader["total_neto"].ToString() != "")
            {
                suma[1] += Convert.ToDecimal(myreader["total_neto"]);
            }
            else
            {
                suma[1] += Convert.ToDecimal(0);
            }
            

            if (myreader["total_iva"].ToString() != null && myreader["total_iva"].ToString() != "")
            {
                suma[2] += Convert.ToDecimal(myreader["total_iva"]);
            }else{
                suma[2] += Convert.ToDecimal(0);
            }

            //datos[3] = myreader["total_exento"].ToString();
            if (myreader["total_exento"].ToString() != null && myreader["total_exento"].ToString() != "")
            {
                suma[3] += Convert.ToDecimal(myreader["total_exento"]);
            }
            else
            {
                suma[3] += Convert.ToDecimal(0);
            }
        }
        myreader.Close();
        return suma;
    }
    public Decimal[] totales_Boleta(string FechaInicial, string fechaFinal)
    {
        Decimal [] suma = new Decimal[4];
        string[] datos = new string[4];
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand)command).CommandText = "select count(folio) as total,sum( valor_neto) as total_neto,sum(valor_iva) as total_iva,sum( valor_exento) as total_exento  from ingresos_manuales where tipo = \"Boleta\" and DATE_FORMAT(fecha, '%Y-%m-%d') >= \"" + FechaInicial + "\" and DATE_FORMAT(fecha, '%Y-%m-%d') <= \"" + fechaFinal + "\";";
        MySqlDataReader myreader = command.ExecuteReader();

        while (myreader.Read())
        {
            if (myreader["total"].ToString() != null && myreader["total"].ToString() != "")
            {
                suma[0] += Convert.ToDecimal(myreader["total"]);
            }
            else
            {
                suma[0] += Convert.ToDecimal(0);
            }
            //datos[0] = myreader["total"].ToString();
            //suma[0] += Convert.ToDecimal(myreader["total"]);
            if (myreader["total_neto"].ToString() != null && myreader["total_neto"].ToString() != "")
            {
                suma[1] += Convert.ToDecimal(myreader["total_neto"]);
            }
            else
            {
                suma[1] += Convert.ToDecimal(0);
            }


            if (myreader["total_iva"].ToString() != null && myreader["total_iva"].ToString() != "")
            {
                suma[2] += Convert.ToDecimal(myreader["total_iva"]);
            }
            else
            {
                suma[2] += Convert.ToDecimal(0);
            }

            //datos[3] = myreader["total_exento"].ToString();
            if (myreader["total_exento"].ToString() != null && myreader["total_exento"].ToString() != "")
            {
                suma[3] += Convert.ToDecimal(myreader["total_exento"]);
            }
            else
            {
                suma[3] += Convert.ToDecimal(0);
            }
        }
        myreader.Close();
        return suma;
    }

    public bool boletaExiste(int numBoleta)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM boletas WHERE folio=@numBoleta";
      command.Parameters.AddWithValue("@numBoleta", (object) numBoleta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }
    public string UltimoFolio()
    {
        string ultimo = "";
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand)command).CommandText = "select last_insert_id(folio) as last from boletas order by folio desc limit 1;";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader)mySqlDataReader).Read())
        {
            ultimo = ((DbDataReader)mySqlDataReader)["last"].ToString();
        }

        ((DbDataReader)mySqlDataReader).Close();
        return ultimo;
    }
    public int voucherExiste(int numBoleta)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta FROM boletas WHERE numeroVoucher=@numBoleta";
      command.Parameters.AddWithValue("@numBoleta", (object) numBoleta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int retornaIdBoleta(int numBoleta)
    {
      int num = 0;
      this.conexion.ConexionMySql.Close();
      this.conexion.ConexionMySql.Open();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta, folio FROM boletas WHERE folio=@numBoleta";
      command.Parameters.AddWithValue("@numBoleta", (object) numBoleta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaBoletaFolio(int numBoleta)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta, tipoDocumento,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            totalExento,\r\n                                                            totalaCobrar,\r\n                                                            pagaCon,\r\n                                                            vuelto,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            idComanda,\r\n                                                            folioComanda, garzon, idGarzon, numeroVoucher  \r\n\r\n                                        FROM boletas WHERE folio=@numBoleta";
      command.Parameters.AddWithValue("@numBoleta", (object) numBoleta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"]);
        venta.BoletaVoucher = ((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString();
        venta.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]);
        venta.FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]);
        venta.FechaVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaVencimiento"]);
        venta.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"]);
        venta.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        venta.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        venta.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        venta.Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString();
        venta.Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString();
        venta.Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString();
        venta.Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString();
        venta.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        venta.Fax = ((DbDataReader) mySqlDataReader)["fax"].ToString();
        venta.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        venta.DiasPlazo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diasPlazo"]);
        venta.IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"]);
        venta.MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString();
        venta.IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"]);
        venta.Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString();
        venta.IdCentroCosto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCentroCosto"]);
        venta.CentroCosto = ((DbDataReader) mySqlDataReader)["centroCosto"].ToString();
        venta.OrdenCompra = ((DbDataReader) mySqlDataReader)["ordenCompra"].ToString();
        venta.SubTotal = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotal"]);
        venta.PorcentajeDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuento"]);
        venta.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuento"]);
        venta.PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]);
        venta.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]);
        venta.Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]);
        venta.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]);
        venta.TotalPalabras = ((DbDataReader) mySqlDataReader)["totalPalabras"].ToString();
        venta.EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString();
        venta.EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString();
        venta.TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPagado"]);
        venta.TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalDocumentado"]);
        venta.TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPendiente"]);
        venta.TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]);
        venta.TotalaCobrar = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalaCobrar"]);
        venta.PagaCon = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["pagaCon"]);
        venta.Vuelto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["vuelto"]);
        venta.Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]);
        venta.Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]);
        venta.Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]);
        venta.Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]);
        venta.Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]);
        venta.PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]);
        venta.PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]);
        venta.PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]);
        venta.PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]);
        venta.PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]);
        venta.IdTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicket"]);
        venta.FolioTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioTicket"]);
        venta.IdCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]);
        venta.FolioCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]);
        venta.IdNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVenta"]);
        venta.FolioNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaVenta"]);
        venta.IdComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idComanda"]);
        venta.FolioComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioComanda"]);
        venta.Garzon = ((DbDataReader) mySqlDataReader)["garzon"].ToString();
        venta.IdGarzon = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGarzon"]);
        venta.NumeroVoucher = ((DbDataReader) mySqlDataReader)["numeroVoucher"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public Venta buscaBoletaID(int idBoleta)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta, tipoDocumento,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            totalExento,\r\n                                                            totalaCobrar,\r\n                                                            pagaCon,\r\n                                                            vuelto,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idComanda,\r\n                                                            folioComanda,garzon, idGarzon, numeroVoucher\r\n\r\n                                        FROM boletas WHERE idBoleta=@idBoleta";
      command.Parameters.AddWithValue("@idBoleta", (object) idBoleta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"]);
        venta.BoletaVoucher = ((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString();
        venta.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]);
        venta.FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]);
        venta.FechaVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaVencimiento"]);
        venta.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"]);
        venta.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        venta.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        venta.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        venta.Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString();
        venta.Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString();
        venta.Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString();
        venta.Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString();
        venta.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        venta.Fax = ((DbDataReader) mySqlDataReader)["fax"].ToString();
        venta.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        venta.DiasPlazo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diasPlazo"]);
        venta.IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"]);
        venta.MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString();
        venta.IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"]);
        venta.Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString();
        venta.IdCentroCosto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCentroCosto"]);
        venta.CentroCosto = ((DbDataReader) mySqlDataReader)["centroCosto"].ToString();
        venta.OrdenCompra = ((DbDataReader) mySqlDataReader)["ordenCompra"].ToString();
        venta.SubTotal = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotal"]);
        venta.PorcentajeDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuento"]);
        venta.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuento"]);
        venta.PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]);
        venta.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]);
        venta.Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]);
        venta.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]);
        venta.TotalPalabras = ((DbDataReader) mySqlDataReader)["totalPalabras"].ToString();
        venta.EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString();
        venta.EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString();
        venta.TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPagado"]);
        venta.TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalDocumentado"]);
        venta.TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPendiente"]);
        venta.TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]);
        venta.TotalaCobrar = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalaCobrar"]);
        venta.PagaCon = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["pagaCon"]);
        venta.Vuelto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["vuelto"]);
        venta.Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]);
        venta.Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]);
        venta.Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]);
        venta.Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]);
        venta.Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]);
        venta.PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]);
        venta.PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]);
        venta.PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]);
        venta.PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]);
        venta.PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]);
        venta.IdTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicket"]);
        venta.FolioTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioTicket"]);
        venta.IdCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]);
        venta.FolioCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]);
        venta.IdComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idComanda"]);
        venta.FolioComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioComanda"]);
        venta.Garzon = ((DbDataReader) mySqlDataReader)["garzon"].ToString();
        venta.IdGarzon = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGarzon"]);
        venta.NumeroVoucher = ((DbDataReader) mySqlDataReader)["numeroVoucher"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public Venta buscaBoletaNumeroVoucher(string numVoucher)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta, tipoDocumento,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            totalExento,\r\n                                                            totalaCobrar,\r\n                                                            pagaCon,\r\n                                                            vuelto,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idComanda,\r\n                                                            folioComanda,garzon, idGarzon, numeroVoucher\r\n\r\n                                        FROM boletas WHERE numeroVoucher=@numVoucher";
      command.Parameters.AddWithValue("@numVoucher", (object) numVoucher);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"]);
        venta.BoletaVoucher = ((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString();
        venta.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]);
        venta.FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]);
        venta.FechaVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaVencimiento"]);
        venta.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"]);
        venta.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        venta.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        venta.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        venta.Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString();
        venta.Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString();
        venta.Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString();
        venta.Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString();
        venta.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        venta.Fax = ((DbDataReader) mySqlDataReader)["fax"].ToString();
        venta.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        venta.DiasPlazo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diasPlazo"]);
        venta.IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"]);
        venta.MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString();
        venta.IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"]);
        venta.Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString();
        venta.IdCentroCosto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCentroCosto"]);
        venta.CentroCosto = ((DbDataReader) mySqlDataReader)["centroCosto"].ToString();
        venta.OrdenCompra = ((DbDataReader) mySqlDataReader)["ordenCompra"].ToString();
        venta.SubTotal = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotal"]);
        venta.PorcentajeDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuento"]);
        venta.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuento"]);
        venta.PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]);
        venta.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]);
        venta.Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]);
        venta.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]);
        venta.TotalPalabras = ((DbDataReader) mySqlDataReader)["totalPalabras"].ToString();
        venta.EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString();
        venta.EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString();
        venta.TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPagado"]);
        venta.TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalDocumentado"]);
        venta.TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPendiente"]);
        venta.TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]);
        venta.TotalaCobrar = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalaCobrar"]);
        venta.PagaCon = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["pagaCon"]);
        venta.Vuelto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["vuelto"]);
        venta.Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]);
        venta.Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]);
        venta.Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]);
        venta.Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]);
        venta.Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]);
        venta.PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]);
        venta.PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]);
        venta.PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]);
        venta.PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]);
        venta.PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]);
        venta.IdTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicket"]);
        venta.FolioTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioTicket"]);
        venta.IdCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]);
        venta.FolioCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]);
        venta.IdComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idComanda"]);
        venta.FolioComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioComanda"]);
        venta.Garzon = ((DbDataReader) mySqlDataReader)["garzon"].ToString();
        venta.IdGarzon = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGarzon"]);
        venta.NumeroVoucher = ((DbDataReader) mySqlDataReader)["numeroVoucher"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<DatosVentaVO> buscaDetalleBoletaIDBoleta(int idBoleta)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleBoleta, \r\n                                                    idBoletaLinea,\r\n                                                    folioBoleta,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    exento,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    descuentaInventario,\r\n                                                    valorCompra,stockQueda                                                    \r\n                                                    FROM detalleboleta WHERE idBoletaLinea = @idBoleta ORDER BY idDetalleBoleta asc";
      command.Parameters.AddWithValue("@idBoleta", (object) idBoleta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleBoleta"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoletaLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioBoleta"]),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"]),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"]),
          PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuentoLinea"]),
          Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoLinea"]),
          SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"]),
          TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"]),
          TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"]),
          ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"]),
          Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"]),
          Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]),
          IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]),
          NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]),
          DescuentaInventario = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["descuentaInventario"].ToString()),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]),
          StockQueda = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQueda"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaBoleta(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE boletas SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n\r\n                                                            totalExento=@totalExento,\r\n                                                            totalaCobrar=@totalaCobrar,\r\n                                                            pagaCon=@pagaCon,\r\n                                                            vuelto=@vuelto,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor,\r\n                                                            garzon=@garzon, idGarzon=@idGarzon, numeroVoucher=@numeroVoucher\r\n                                           WHERE idBoleta=@idBoleta AND folio=@folio";
        command.Parameters.AddWithValue("@idBoleta", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folio", (object) veOB.Folio);
        command.Parameters.AddWithValue("@fechaEmision", (object) veOB.FechaEmision);
        command.Parameters.AddWithValue("@fechaVencimiento", (object) veOB.FechaVencimiento);
        command.Parameters.AddWithValue("@dia", (object) veOB.FechaEmision.Day.ToString());
        command.Parameters.AddWithValue("@mes", (object) string.Format("{0:MMMM}", (object) veOB.FechaEmision).ToString().ToUpper());
        command.Parameters.AddWithValue("@ano", (object) veOB.FechaEmision.Year.ToString());
        command.Parameters.AddWithValue("@idCliente", (object) veOB.IdCliente);
        command.Parameters.AddWithValue("@rut", (object) veOB.Rut);
        command.Parameters.AddWithValue("@digito", (object) veOB.Digito);
        command.Parameters.AddWithValue("@razonSocial", (object) veOB.RazonSocial);
        command.Parameters.AddWithValue("@direccion", (object) veOB.Direccion);
        command.Parameters.AddWithValue("@comuna", (object) veOB.Comuna);
        command.Parameters.AddWithValue("@ciudad", (object) veOB.Ciudad);
        command.Parameters.AddWithValue("@giro", (object) veOB.Giro);
        command.Parameters.AddWithValue("@fono", (object) veOB.Fono);
        command.Parameters.AddWithValue("@fax", (object) veOB.Fax);
        command.Parameters.AddWithValue("@contacto", (object) veOB.Contacto);
        command.Parameters.AddWithValue("@diasPlazo", (object) veOB.DiasPlazo);
        command.Parameters.AddWithValue("@idMedioPago", (object) veOB.IdMedioPago);
        command.Parameters.AddWithValue("@medioPago", (object) veOB.MedioPago);
        command.Parameters.AddWithValue("@idVendedor", (object) veOB.IdVendedor);
        command.Parameters.AddWithValue("@vendedor", (object) veOB.Vendedor);
        command.Parameters.AddWithValue("@idCentroCosto", (object) veOB.IdCentroCosto);
        command.Parameters.AddWithValue("@centroCosto", (object) veOB.CentroCosto);
        command.Parameters.AddWithValue("@ordenCompra", (object) veOB.OrdenCompra);
        command.Parameters.AddWithValue("@subtotal", (object) veOB.SubTotal);
        command.Parameters.AddWithValue("@porcentajeDescuento", (object) veOB.PorcentajeDescuento);
        command.Parameters.AddWithValue("@descuento", (object) veOB.Descuento);
        command.Parameters.AddWithValue("@porcentajeIva", (object) veOB.PorcentajeIva);
        command.Parameters.AddWithValue("@iva", (object) veOB.Iva);
        command.Parameters.AddWithValue("@neto", (object) veOB.Neto);
        command.Parameters.AddWithValue("@total", (object) veOB.Total);
        command.Parameters.AddWithValue("@totalPalabras", (object) veOB.TotalPalabras);
        command.Parameters.AddWithValue("@estadoPago", (object) veOB.EstadoPago);
        command.Parameters.AddWithValue("@totalPagado", (object) veOB.TotalPagado);
        command.Parameters.AddWithValue("@totalDocumentado", (object) veOB.TotalDocumentado);
        command.Parameters.AddWithValue("@totalPendiente", (object) veOB.TotalPendiente);
        command.Parameters.AddWithValue("@totalExento", (object) veOB.TotalExento);
        command.Parameters.AddWithValue("@totalaCobrar", (object) veOB.TotalaCobrar);
        command.Parameters.AddWithValue("@pagaCon", (object) 0);
        command.Parameters.AddWithValue("@vuelto", (object) 0);
        command.Parameters.AddWithValue("@impuesto1", (object) veOB.Impuesto1);
        command.Parameters.AddWithValue("@impuesto2", (object) veOB.Impuesto2);
        command.Parameters.AddWithValue("@impuesto3", (object) veOB.Impuesto3);
        command.Parameters.AddWithValue("@impuesto4", (object) veOB.Impuesto4);
        command.Parameters.AddWithValue("@impuesto5", (object) veOB.Impuesto5);
        command.Parameters.AddWithValue("@porcentajeImpuesto1", (object) veOB.PorcentajeImpuesto1);
        command.Parameters.AddWithValue("@porcentajeImpuesto2", (object) veOB.PorcentajeImpuesto2);
        command.Parameters.AddWithValue("@porcentajeImpuesto3", (object) veOB.PorcentajeImpuesto3);
        command.Parameters.AddWithValue("@porcentajeImpuesto4", (object) veOB.PorcentajeImpuesto4);
        command.Parameters.AddWithValue("@porcentajeImpuesto5", (object) veOB.PorcentajeImpuesto5);
        command.Parameters.AddWithValue("@comisionVendedor", (object) veOB.ComisionVendedor);
        command.Parameters.AddWithValue("@garzon", (object) veOB.Garzon);
        command.Parameters.AddWithValue("@idGarzon", (object) veOB.IdGarzon);
        command.Parameters.AddWithValue("@numeroVoucher", (object) veOB.NumeroVoucher);
        ((DbCommand) command).ExecuteNonQuery();
        foreach (DatosVentaVO datosVentaVo in this.buscaDetalleBoletaIDBoleta(veOB.IdFactura))
        {
          new ControlProducto().registroDocumentoModifica(datosVentaVo, "BOLETA");
          new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "BOLETA");
          this.actualizaStock(datosVentaVo, "+");
        }
        this.eliminaDetalleBoleta(veOB);
        if (listaLoteAntigua.Count > 0)
        {
          foreach (LoteVO loteVo in listaLoteAntigua)
            new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
        }
        foreach (DatosVentaVO veVO in listaNueva)
        {
          Decimal num = this.consultaStock(veVO);
          veVO.StockQueda = num - veVO.Cantidad;
          veVO.FechaIngreso = veVO.FechaIngreso.AddSeconds(40.0);
          this.agregaDetalleBoleta3(veVO);
          this.actualizaStock(veVO, "-");
        }
        if (listaLote.Count > 0)
        {
          int idFactura = veOB.IdFactura;
          long num = (long) veOB.Folio;
          string str = "BOLETA";
          foreach (LoteVO loteVo in listaLote)
          {
            loteVo.Documento = str;
            loteVo.IdDocumento = idFactura;
            loteVo.FolioDocumento = num;
            loteVo.TipoDocumento = "VENTA";
            loteVo.Accion = "SALE";
          }
          new Lote().RegistraLote(listaLote);
        }
        return "Boleta Modificada";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool eliminaDetalleBoleta(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detalleboleta WHERE idBoletaLinea=@idBoleta AND folioBoleta=@folioBoleta";
        command.Parameters.AddWithValue("@idBoleta", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioBoleta", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public DataTable muestraBoletaFolio(int folio)
    {
      string str = "SELECT " + this.camposBoleta + " FROM boletas INNER JOIN detalleboleta \r\n                            ON boletas.idBoleta = detalleboleta.idBoletaLinea WHERE boletas.folio=@folio AND detalleboleta.exento=0 ORDER BY detalleboleta.idDetalleBoleta";
      DataTable dataTable = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        command.Parameters.AddWithValue("@folio", (object) folio);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      catch (Exception ex)
      {
      }
      return dataTable;
    }
    public DataTable posInforme(string filtro)
    {
        string str = "SELECT \r\n                                        idBoleta,\r\n                                        tipoDocumento,\r\n                                  fechaEmision,\r\n                                        fechaVencimiento,\r\n                                        dia,\r\n                                        mes,\r\n                                        ano,\r\n                                        idCliente, \r\n                                        rut, \r\n                                        digito, \r\n                                        razonSocial,\r\n                                        direccion, \r\n                                        comuna, \r\n                                        ciudad, \r\n                                        giro, \r\n                                        fono, \r\n                                        fax, \r\n                                        contacto, \r\n                                        diasPlazo, \r\n                                        idMedioPago,                          \r\n                                        medioPago, \r\n                                        idVendedor, \r\n                                        vendedor, \r\n                                        idCentroCosto, \r\n                                        centroCosto, \r\n                                        ordenCompra, \r\n                                        subtotal, \r\n                                        porcentajeDescuento,\r\n                                        descuento, \r\n                                        porcentajeIva, \r\n                                        iva,\r\n                                        neto, \r\n                                        total, \r\n                                        totalExento,\r\n                                        totalaCobrar,\r\n                                        totalPalabras, \r\n                                        estadoPago, \r\n                                        estadoDocumento,\r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente,\r\n                                        pagaCon,\r\n                                        vuelto,             \r\n                                        impuesto1,\r\n                                        impuesto2,\r\n                                        impuesto3,\r\n                                        impuesto4,\r\n                                        impuesto5,\r\n                                        porcentajeImpuesto1,\r\n                                        porcentajeImpuesto2,\r\n                                        porcentajeImpuesto3,\r\n                                        porcentajeImpuesto4,\r\n                                        porcentajeImpuesto5,\r\n                                        comisionVendedor,\r\n                                        idTicket,\r\n                                        folioTicket,\r\n                                        caja,\r\n                                        idCotizacion,\r\n                                        folioCotizacion,\r\n                                        idNotaVenta,\r\n                                        folioNotaVenta,\r\n                                        idComanda,\r\n                                        folioComanda,garzon, idGarzon, numeroVoucher as Folio, numeroVoucher                                              \r\n                            FROM boletas                             \r\n                            WHERE " + filtro + " ORDER BY numeroVoucher";
        DataTable dataTable = new DataTable();
        try
        {
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = str;
            ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
        }
        catch (Exception ex)
        {
        }
        return dataTable;
    }
    public int posInformeDetalleCantidadRegistros(string filtro)
    {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand)command).CommandText = "SELECT COUNT(boletas.numeroVoucher) FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea WHERE  " + filtro + " ";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        int num = 0;
        while (((DbDataReader)mySqlDataReader).Read())
            num = Convert.ToInt32(((DbDataReader)mySqlDataReader)[0]);
        ((DbDataReader)mySqlDataReader).Close();
        return num;
    }
    public DataTable posInformeDetalleCategoriaProductos(string filtro)
    {
        string str = "SELECT 'VOUCHER' as tipoDocumentoVenta,\r\n                                        boletas.idBoleta,\r\n                          boletas.folio         , numeroVoucher as folio,\r\n                                        boletas.fechaEmision,\r\n                                        detalleboleta.idDetalleboleta,\r\n                                        detalleboleta.idBoletaLinea,\r\n                                        detalleboleta.folioBoleta,\r\n                                        detalleboleta.fechaIngreso,\r\n                                        detalleboleta.codigo,\r\n                                        detalleboleta.descripcion,\r\n                                        detalleboleta.valorVenta,\r\n                                        detalleboleta.cantidad,\r\n                                        detalleboleta.porcentajeDescuentoLinea,\r\n                                        detalleboleta.descuentoLinea,\r\n                                        detalleboleta.subtotalLinea,\r\n                                        detalleboleta.totalLinea,\r\n                                        detalleboleta.tipoDescuento,\r\n                                        detalleboleta.listaPrecio,\r\n                                        detalleboleta.bodega,\r\n                                        detalleboleta.exento,\r\n                                        detalleboleta.idImpuesto,\r\n                                        detalleboleta.netoLinea,\r\n                                        detalleboleta.valorCompra,\r\n                                        productos.Categoria as 'DescCategoria' \r\n                                FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea \r\n                                INNER JOIN productos ON detalleboleta.codigo=productos.Codigo WHERE " + filtro;
        DataTable dataTable = new DataTable();
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand)command).CommandTimeout = 0;
        ((DbCommand)command).CommandText = str;
        ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
        return dataTable;
    }
    public DataTable posInformeDetalle(string filtro)
    {
        DataTable dataTable = new DataTable();
        int num1 = this.posInformeDetalleCantidadRegistros(filtro);
        string str1 = "";
        if (num1 > 1000)
        {
            int num2 = num1 % 1000;
            int num3 = num1 / 1000;
            string str2 = "SELECT " + this.campospos + " FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea  WHERE boletas.folio = 0 AND " + filtro + " ORDER BY numeroVoucher LIMIT 0, 1000";
            MySqlCommand command1 = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command1).CommandText = str2;
            ((DbDataAdapter)new MySqlDataAdapter(command1)).Fill(dataTable);
            for (int index = 1; index <= num3; ++index)
            {
                string str3 = "LIMIT " + (object)(1000 * index) + ", 1000";
                string str4 = "SELECT " + this.campospos + " FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea  WHERE boletas.folio = 0 AND " + filtro + " ORDER BY numeroVoucher " + str3;
                MySqlCommand command2 = this.conexion.ConexionMySql.CreateCommand();
                ((DbCommand)command2).CommandText = str4;
                ((DbDataAdapter)new MySqlDataAdapter(command2)).Fill(dataTable);
            }
        }
        else
        {
            string str2 = "SELECT " + this.campospos + " FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea  WHERE boletas.folio = 0 AND  detalleboleta.folioBoleta = 0 AND " + filtro + " ORDER BY numeroVoucher " + str1;
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = str2;
            ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
        }
        return dataTable;
    }
    public DataTable boletaInforme(string filtro)
    {
      string str = "SELECT \r\n                                        idBoleta,\r\n                                        tipoDocumento,\r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        fechaVencimiento,\r\n                                        dia,\r\n                                        mes,\r\n                                        ano,\r\n                                        idCliente, \r\n                                        rut, \r\n                                        digito, \r\n                                        razonSocial,\r\n                                        direccion, \r\n                                        comuna, \r\n                                        ciudad, \r\n                                        giro, \r\n                                        fono, \r\n                                        fax, \r\n                                        contacto, \r\n                                        diasPlazo, \r\n                                        idMedioPago,                          \r\n                                        medioPago, \r\n                                        idVendedor, \r\n                                        vendedor, \r\n                                        idCentroCosto, \r\n                                        centroCosto, \r\n                                        ordenCompra, \r\n                                        subtotal, \r\n                                        porcentajeDescuento,\r\n                                        descuento, \r\n                                        porcentajeIva, \r\n                                        iva,\r\n                                        neto, \r\n                                        total, \r\n                                        totalExento,\r\n                                        totalaCobrar,\r\n                                        totalPalabras, \r\n                                        estadoPago, \r\n                                        estadoDocumento,\r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente,\r\n                                        pagaCon,\r\n                                        vuelto,             \r\n                                        impuesto1,\r\n                                        impuesto2,\r\n                                        impuesto3,\r\n                                        impuesto4,\r\n                                        impuesto5,\r\n                                        porcentajeImpuesto1,\r\n                                        porcentajeImpuesto2,\r\n                                        porcentajeImpuesto3,\r\n                                        porcentajeImpuesto4,\r\n                                        porcentajeImpuesto5,\r\n                                        comisionVendedor,\r\n                                        idTicket,\r\n                                        folioTicket,\r\n                                        caja,\r\n                                        idCotizacion,\r\n                                        folioCotizacion,\r\n                                        idNotaVenta,\r\n                                        folioNotaVenta,\r\n                                        idComanda,\r\n                                        folioComanda,garzon, idGarzon, numeroVoucher                                                  \r\n                            FROM boletas                             \r\n                            WHERE " + filtro + " ORDER BY folio";
      DataTable dataTable = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      catch (Exception ex)
      {
      }
      return dataTable;
    }

    public DataTable boletaInformeDetalle(string filtro)
    {
      DataTable dataTable = new DataTable();
      int num1 = this.boletaInformeDetalleCantidadRegistros(filtro);
      string str1 = "";
      if (num1 > 1000)
      {
        int num2 = num1 % 1000;
        int num3 = num1 / 1000;
        string str2 = "SELECT " + this.camposBoleta + " FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea  WHERE boletas.folio > 0 AND " + filtro + " ORDER BY folio LIMIT 0, 1000";
        MySqlCommand command1 = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command1).CommandText = str2;
        ((DbDataAdapter) new MySqlDataAdapter(command1)).Fill(dataTable);
        for (int index = 1; index <= num3; ++index)
        {
          string str3 = "LIMIT " + (object) (1000 * index) + ", 1000";
          string str4 = "SELECT " + this.camposBoleta + " FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea  WHERE boletas.folio > 0 AND " + filtro + " ORDER BY folio " + str3;
          MySqlCommand command2 = this.conexion.ConexionMySql.CreateCommand();
          ((DbCommand) command2).CommandText = str4;
          ((DbDataAdapter) new MySqlDataAdapter(command2)).Fill(dataTable);
        }
      }
      else
      {
        string str2 = "SELECT " + this.camposBoleta + " FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea  WHERE boletas.folio > 0 AND " + filtro + " ORDER BY folio " + str1;
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str2;
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      return dataTable;
    }

    public int boletaInformeDetalleCantidadRegistros(string filtro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT COUNT(boletas.folio) FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea WHERE boletas.folio > 0 AND " + filtro + " ";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      int num = 0;
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public DataTable boletaInformeDetalleConReader(string filtro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT " + this.camposBoleta + " FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea WHERE " + filtro + " ";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<Venta> listaVenta = new List<Venta>();
      List<DatosVentaVO> listaDetalle = new List<DatosVentaVO>();
      Venta venta = new Venta();
      DatosVentaVO datosVentaVo = new DatosVentaVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        listaVenta.Add(new Venta()
        {
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          FechaVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaVencimiento"]),
          IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString(),
          Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString(),
          Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString(),
          Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString(),
          Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString(),
          Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString(),
          Fax = ((DbDataReader) mySqlDataReader)["fax"].ToString(),
          Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString(),
          DiasPlazo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["diasPlazo"]),
          IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"]),
          MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString(),
          IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"]),
          Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString(),
          IdCentroCosto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCentroCosto"]),
          CentroCosto = ((DbDataReader) mySqlDataReader)["centroCosto"].ToString(),
          OrdenCompra = ((DbDataReader) mySqlDataReader)["ordenCompra"].ToString(),
          SubTotal = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotal"]),
          PorcentajeDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuento"]),
          Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuento"]),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          TotalPalabras = ((DbDataReader) mySqlDataReader)["totalPalabras"].ToString(),
          EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString(),
          EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString(),
          TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPagado"]),
          TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalDocumentado"]),
          TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPendiente"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          TotalaCobrar = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalaCobrar"]),
          PagaCon = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["pagaCon"]),
          Vuelto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["vuelto"]),
          Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]),
          Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]),
          Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]),
          Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]),
          Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]),
          PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]),
          PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]),
          PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]),
          PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]),
          PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]),
          IdTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicket"]),
          FolioTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioTicket"]),
          IdCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]),
          FolioCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]),
          IdNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVenta"]),
          FolioNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaVenta"]),
          IdComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idComanda"]),
          FolioComanda = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioComanda"]),
          Garzon = ((DbDataReader) mySqlDataReader)["garzon"].ToString(),
          IdGarzon = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGarzon"])
        });
        listaDetalle.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleBoleta"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoletaLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioBoleta"]),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"]),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"]),
          PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuentoLinea"]),
          Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoLinea"]),
          SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"]),
          TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"]),
          TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"]),
          ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"]),
          Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"]),
          Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]),
          IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]),
          NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"])
        });
      }
      ((DbDataReader) mySqlDataReader).Close();
      int num = (int) MessageBox.Show("salio del reader");
      DataTable dataTable = new DataTable();
      return this.creaDataTableBoleta(listaVenta, listaDetalle);
    }

    private DataTable creaDataTableBoleta(List<Venta> listaVenta, List<DatosVentaVO> listaDetalle)
    {
      int num = Enumerable.Count<Venta>((IEnumerable<Venta>) listaVenta);
      Enumerable.Count<DatosVentaVO>((IEnumerable<DatosVentaVO>) listaDetalle);
      DataTable dataTable = new DataTable("Boleta");
      dataTable.Columns.Add("tipoDocumentoVenta");
      dataTable.Columns.Add("tipoDocumento");
      dataTable.Columns.Add("idBoleta");
      dataTable.Columns.Add("folio");
      dataTable.Columns.Add("fechaEmision");
      dataTable.Columns.Add("fechaVencimiento");
      dataTable.Columns.Add("dia");
      dataTable.Columns.Add("mes");
      dataTable.Columns.Add("ano");
      dataTable.Columns.Add("idCliente");
      dataTable.Columns.Add("rut");
      dataTable.Columns.Add("digito");
      dataTable.Columns.Add("razonSocial");
      dataTable.Columns.Add("direccion");
      dataTable.Columns.Add("comuna");
      dataTable.Columns.Add("ciudad");
      dataTable.Columns.Add("giro");
      dataTable.Columns.Add("fono");
      dataTable.Columns.Add("fax");
      dataTable.Columns.Add("contacto");
      dataTable.Columns.Add("diasPlazo");
      dataTable.Columns.Add("idMedioPago");
      dataTable.Columns.Add("medioPago");
      dataTable.Columns.Add("idVendedor");
      dataTable.Columns.Add("vendedor");
      dataTable.Columns.Add("idCentroCosto");
      dataTable.Columns.Add("centroCosto");
      dataTable.Columns.Add("ordenCompra");
      dataTable.Columns.Add("subtotal");
      dataTable.Columns.Add("porcentajeDescuento");
      dataTable.Columns.Add("descuento");
      dataTable.Columns.Add("porcentajeIva");
      dataTable.Columns.Add("iva");
      dataTable.Columns.Add("neto");
      dataTable.Columns.Add("total");
      dataTable.Columns.Add("totalExento");
      dataTable.Columns.Add("totalaCobrar");
      dataTable.Columns.Add("totalPalabras");
      dataTable.Columns.Add("estadoPago");
      dataTable.Columns.Add("estadoDocumento");
      dataTable.Columns.Add("totalPagado");
      dataTable.Columns.Add("totalDocumentado");
      dataTable.Columns.Add("totalPendiente");
      dataTable.Columns.Add("pagaCon");
      dataTable.Columns.Add("vuelto");
      dataTable.Columns.Add("impuesto1");
      dataTable.Columns.Add("impuesto2");
      dataTable.Columns.Add("impuesto3");
      dataTable.Columns.Add("impuesto4");
      dataTable.Columns.Add("impuesto5");
      dataTable.Columns.Add("porcentajeImpuesto1");
      dataTable.Columns.Add("porcentajeImpuesto2");
      dataTable.Columns.Add("porcentajeImpuesto3");
      dataTable.Columns.Add("porcentajeImpuesto4");
      dataTable.Columns.Add("porcentajeImpuesto5");
      dataTable.Columns.Add("comisionVendedor");
      dataTable.Columns.Add("idTicket");
      dataTable.Columns.Add("folioTicket");
      dataTable.Columns.Add("caja");
      dataTable.Columns.Add("idCotizacion");
      dataTable.Columns.Add("folioCotizacion");
      dataTable.Columns.Add("idNotaVenta");
      dataTable.Columns.Add("folioNotaVenta");
      dataTable.Columns.Add("idComanda");
      dataTable.Columns.Add("folioComanda");
      dataTable.Columns.Add("idGarzon");
      dataTable.Columns.Add("garzon");
      dataTable.Columns.Add("numeroVoucher");
      dataTable.Columns.Add("idDetalleboleta");
      dataTable.Columns.Add("idBoletaLinea");
      dataTable.Columns.Add("folioBoleta");
      dataTable.Columns.Add("fechaIngreso");
      dataTable.Columns.Add("codigo");
      dataTable.Columns.Add("descripcion");
      dataTable.Columns.Add("valorVenta");
      dataTable.Columns.Add("cantidad");
      dataTable.Columns.Add("porcentajeDescuentoLinea");
      dataTable.Columns.Add("descuentoLinea");
      dataTable.Columns.Add("subtotalLinea");
      dataTable.Columns.Add("totalLinea");
      dataTable.Columns.Add("tipoDescuento");
      dataTable.Columns.Add("listaPrecio");
      dataTable.Columns.Add("bodega");
      dataTable.Columns.Add("exento");
      dataTable.Columns.Add("idImpuesto");
      dataTable.Columns.Add("netoLinea");
      dataTable.Columns.Add("valorCompra");
      for (int index = 0; index < num; ++index)
      {
        DataRow row = dataTable.NewRow();
        row["tipoDocumentoVenta"] = (object) "BOLETA";
        row["idBoleta"] = (object) listaVenta[index].IdFactura;
        row["folio"] = (object) listaVenta[index].Folio;
        row["fechaEmision"] = (object) listaVenta[index].FechaEmision;
        row["fechaVencimiento"] = (object) listaVenta[index].FechaVencimiento;
        row["dia"] = (object) listaVenta[index].Dia;
        row["mes"] = (object) listaVenta[index].Mes;
        row["ano"] = (object) listaVenta[index].Ano;
        row["idCliente"] = (object) listaVenta[index].IdCliente;
        row["rut"] = (object) listaVenta[index].Rut;
        row["digito"] = (object) listaVenta[index].Digito;
        row["razonSocial"] = (object) listaVenta[index].RazonSocial;
        row["direccion"] = (object) listaVenta[index].Direccion;
        row["comuna"] = (object) listaVenta[index].Comuna;
        row["ciudad"] = (object) listaVenta[index].Ciudad;
        row["giro"] = (object) listaVenta[index].Giro;
        row["fono"] = (object) listaVenta[index].Fono;
        row["fax"] = (object) listaVenta[index].Fax;
        row["contacto"] = (object) listaVenta[index].Contacto;
        row["diasPlazo"] = (object) listaVenta[index].DiasPlazo;
        row["idMedioPago"] = (object) listaVenta[index].IdMedioPago;
        row["medioPago"] = (object) listaVenta[index].MedioPago;
        row["idVendedor"] = (object) listaVenta[index].IdVendedor;
        row["vendedor"] = (object) listaVenta[index].Vendedor;
        row["idCentroCosto"] = (object) listaVenta[index].IdCentroCosto;
        row["centroCosto"] = (object) listaVenta[index].CentroCosto;
        row["ordenCompra"] = (object) listaVenta[index].OrdenCompra;
        row["subtotal"] = (object) listaVenta[index].SubTotal;
        row["porcentajeDescuento"] = (object) listaVenta[index].PorcentajeDescuento;
        row["descuento"] = (object) listaVenta[index].Descuento;
        row["porcentajeIva"] = (object) listaVenta[index].PorcentajeIva;
        row["iva"] = (object) listaVenta[index].Iva;
        row["neto"] = (object) listaVenta[index].Neto;
        row["total"] = (object) listaVenta[index].Total;
        row["totalExento"] = (object) listaVenta[index].TotalExento;
        row["totalaCobrar"] = (object) listaVenta[index].TotalaCobrar;
        row["totalPalabras"] = (object) listaVenta[index].TotalPalabras;
        row["estadoPago"] = (object) listaVenta[index].EstadoPago;
        row["estadoDocumento"] = (object) listaVenta[index].EstadoDocumento;
        row["totalPagado"] = (object) listaVenta[index].TotalPagado;
        row["totalDocumentado"] = (object) listaVenta[index].TotalDocumentado;
        row["totalPendiente"] = (object) listaVenta[index].TotalPendiente;
        row["pagaCon"] = (object) listaVenta[index].PagaCon;
        row["vuelto"] = (object) listaVenta[index].Vuelto;
        row["impuesto1"] = (object) listaVenta[index].Impuesto1;
        row["impuesto2"] = (object) listaVenta[index].Impuesto2;
        row["impuesto3"] = (object) listaVenta[index].Impuesto3;
        row["impuesto4"] = (object) listaVenta[index].Impuesto4;
        row["impuesto5"] = (object) listaVenta[index].Impuesto5;
        row["porcentajeImpuesto1"] = (object) listaVenta[index].PorcentajeImpuesto1;
        row["porcentajeImpuesto2"] = (object) listaVenta[index].PorcentajeImpuesto2;
        row["porcentajeImpuesto3"] = (object) listaVenta[index].PorcentajeImpuesto3;
        row["porcentajeImpuesto4"] = (object) listaVenta[index].PorcentajeImpuesto4;
        row["porcentajeImpuesto5"] = (object) listaVenta[index].PorcentajeImpuesto5;
        row["comisionVendedor"] = (object) listaVenta[index].ComisionVendedor;
        row["idTicket"] = (object) listaVenta[index].IdTicket;
        row["folioTicket"] = (object) listaVenta[index].FolioTicket;
        row["caja"] = (object) listaVenta[index].Caja;
        row["idCotizacion"] = (object) listaVenta[index].IdCotizacion;
        row["folioCotizacion"] = (object) listaVenta[index].FolioCotizacion;
        row["idNotaVenta"] = (object) listaVenta[index].IdNotaVenta;
        row["folioNotaVenta"] = (object) listaVenta[index].FolioNotaVenta;
        row["idComanda"] = (object) listaVenta[index].IdComanda;
        row["folioComanda"] = (object) listaVenta[index].FolioComanda;
        row["idGarzon"] = (object) listaVenta[index].IdGarzon;
        row["garzon"] = (object) listaVenta[index].Garzon;
        row["idDetalleboleta"] = (object) listaDetalle[index].IdDetalle;
        row["idBoletaLinea"] = (object) listaDetalle[index].IdFactura;
        row["folioBoleta"] = (object) listaDetalle[index].FolioFactura;
        row["fechaIngreso"] = (object) listaDetalle[index].FechaIngreso;
        row["codigo"] = (object) listaDetalle[index].Codigo;
        row["descripcion"] = (object) listaDetalle[index].Descripcion;
        row["valorVenta"] = (object) listaDetalle[index].ValorVenta;
        row["cantidad"] = (object) listaDetalle[index].Cantidad;
        row["porcentajeDescuentoLinea"] = (object) listaDetalle[index].PorcDescuento;
        row["descuentoLinea"] = (object) listaDetalle[index].Descuento;
        row["subtotalLinea"] = (object) listaDetalle[index].SubTotalLinea;
        row["totalLinea"] = (object) listaDetalle[index].TotalLinea;
        row["tipoDescuento"] = (object) listaDetalle[index].TipoDescuento;
        row["listaPrecio"] = (object) listaDetalle[index].ListaPrecio;
        row["bodega"] = (object) listaDetalle[index].Bodega;
        row["exento"] = (listaDetalle[index].Exento ? 1 : 0);
        row["idImpuesto"] = (object) listaDetalle[index].IdImpuesto;
        row["netoLinea"] = (object) listaDetalle[index].NetoLinea;
        row["valorCompra"] = (object) listaDetalle[index].ValorCompra;
        dataTable.Rows.Add(row);
      }
      return dataTable;
    }

    public DataTable boletaInformeDetalleCategoriaProductos(string filtro)
    {
      string str = "SELECT 'BOLETA' as tipoDocumentoVenta,\r\n                                        boletas.idBoleta,\r\n                                        boletas.folio,\r\n                                        boletas.fechaEmision,\r\n                                        detalleboleta.idDetalleboleta,\r\n                                        detalleboleta.idBoletaLinea,\r\n                                        detalleboleta.folioBoleta,\r\n                                        detalleboleta.fechaIngreso,\r\n                                        detalleboleta.codigo,\r\n                                        detalleboleta.descripcion,\r\n                                        detalleboleta.valorVenta,\r\n                                        detalleboleta.cantidad,\r\n                                        detalleboleta.porcentajeDescuentoLinea,\r\n                                        detalleboleta.descuentoLinea,\r\n                                        detalleboleta.subtotalLinea,\r\n                                        detalleboleta.totalLinea,\r\n                                        detalleboleta.tipoDescuento,\r\n                                        detalleboleta.listaPrecio,\r\n                                        detalleboleta.bodega,\r\n                                        detalleboleta.exento,\r\n                                        detalleboleta.idImpuesto,\r\n                                        detalleboleta.netoLinea,\r\n                                        detalleboleta.valorCompra,\r\n                                        productos.Categoria as 'DescCategoria' \r\n                                FROM boletas INNER JOIN detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea \r\n                                INNER JOIN productos ON detalleboleta.codigo=productos.Codigo WHERE " + filtro;
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
    public string folio_voucher(int folioVoucher)
    {
        int num = 0;
        String n_voucher = "";
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand)command).CommandText = "SELECT id FROM Transbank WHERE folio_trans = @numBoleta";
        command.Parameters.AddWithValue("@numBoleta", (object)folioVoucher);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader)mySqlDataReader).Read())
        {
            n_voucher = ((DbDataReader)mySqlDataReader)[0].ToString();
        }
        ((DbDataReader)mySqlDataReader).Close();
        //MySqlCommand command2 = this.conexion.ConexionMySql.CreateCommand();
        //((DbCommand)command).CommandText = "SELECT id FROM Transbank WHERE folio_trans = @numBoleta";
        //command.Parameters.AddWithValue("@numBoleta", (object)folioVoucher);
        //MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        //while (((DbDataReader)mySqlDataReader2).Read())
        //{
        //    n_voucher = ((DbDataReader)mySqlDataReader)[0].ToString();
        //}
        //((DbDataReader)mySqlDataReader2).Close();
        return n_voucher;
    }
       
    public DataTable boletaListado(DateTime desde, DateTime hasta, int caja)
    {
        string str = "SELECT \r\n                                        idBoleta,\r\n       numeroVoucher as foliopos,\r\n                                 folio,\r\n                                        fechaEmision,\r\n                                        rut, \r\n                                        digito, \r\n                                        razonSocial,                                                                                \r\n                                        vendedor,                                                                                \r\n                                        totalaCobrar,                                        \r\n                                        estadoPago, \r\n                                        estadoDocumento,                                        \r\n                                        caja                                                  \r\n                            FROM boletas                             \r\n                            WHERE DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= DATE_FORMAT(@desde, '%Y-%m-%d') AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= DATE_FORMAT(@hasta, '%Y-%m-%d') AND caja=@caja ORDER BY idBoleta";
        DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      command.Parameters.AddWithValue("@desde", (object) desde);
      command.Parameters.AddWithValue("@hasta", (object) hasta);
      command.Parameters.AddWithValue("@caja", (object) caja);
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
