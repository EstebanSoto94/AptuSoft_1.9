 

 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class BoletaFiscal
  {
    private Conexion conexion = Conexion.getConecta();
    private string camposBoleta = "'BOLETA' as tipoDocumentoVenta,\r\n                                        boletasFiscal.idBoleta,\r\n                                        boletasFiscal.folio,\r\n                                        boletasFiscal.fechaEmision,\r\n                                        boletasFiscal.fechaVencimiento,\r\n                                        boletasFiscal.dia,\r\n                                        boletasFiscal.mes,\r\n                                        boletasFiscal.ano,\r\n                                        boletasFiscal.idCliente, \r\n                                        boletasFiscal.rut, \r\n                                        boletasFiscal.digito, \r\n                                        boletasFiscal.razonSocial,\r\n                                        boletasFiscal.direccion, \r\n                                        boletasFiscal.comuna, \r\n                                        boletasFiscal.ciudad, \r\n                                        boletasFiscal.giro, \r\n                                        boletasFiscal.fono, \r\n                                        boletasFiscal.fax, \r\n                                        boletasFiscal.contacto, \r\n                                        boletasFiscal.diasPlazo, \r\n                                        boletasFiscal.idMedioPago,                          \r\n                                        boletasFiscal.medioPago, \r\n                                        boletasFiscal.idVendedor, \r\n                                        boletasFiscal.vendedor, \r\n                                        boletasFiscal.idCentroCosto, \r\n                                        boletasFiscal.centroCosto, \r\n                                        boletasFiscal.ordenCompra, \r\n                                        boletasFiscal.subtotal, \r\n                                        boletasFiscal.porcentajeDescuento,\r\n                                        boletasFiscal.descuento, \r\n                                        boletasFiscal.porcentajeIva, \r\n                                        boletasFiscal.iva,\r\n                                        boletasFiscal.neto, \r\n                                        boletasFiscal.total, \r\n                                        boletasFiscal.totalExento,\r\n                                        boletasFiscal.totalaCobrar,\r\n                                        boletasFiscal.totalPalabras, \r\n                                        boletasFiscal.estadoPago, \r\n                                        boletasFiscal.estadoDocumento,\r\n                                        boletasFiscal.totalPagado,\r\n                                        boletasFiscal.totalDocumentado,\r\n                                        boletasFiscal.totalPendiente,\r\n                                        boletasFiscal.pagaCon,\r\n                                        boletasFiscal.vuelto,             \r\n                                        boletasFiscal.impuesto1,\r\n                                        boletasFiscal.impuesto2,\r\n                                        boletasFiscal.impuesto3,\r\n                                        boletasFiscal.impuesto4,\r\n                                        boletasFiscal.impuesto5,\r\n                                        boletasFiscal.porcentajeImpuesto1,\r\n                                        boletasFiscal.porcentajeImpuesto2,\r\n                                        boletasFiscal.porcentajeImpuesto3,\r\n                                        boletasFiscal.porcentajeImpuesto4,\r\n                                        boletasFiscal.porcentajeImpuesto5,\r\n                                        boletasFiscal.comisionVendedor,\r\n                                        boletasFiscal.idTicket,\r\n                                        boletasFiscal.folioTicket,\r\n                                        boletasFiscal.caja,\r\n                                        boletasFiscal.idCotizacion,\r\n                                        boletasFiscal.folioCotizacion,\r\n                                        detalleboletafiscal.idDetalleboleta,                               \r\n                                        detalleboletafiscal.idBoletaLinea,\r\n                                        detalleboletafiscal.folioBoleta,\r\n                                        detalleboletafiscal.fechaIngreso,\r\n                                        detalleboletafiscal.codigo,\r\n                                        detalleboletafiscal.descripcion,\r\n                                        detalleboletafiscal.resumenDescripcion,\r\n                                        detalleboletafiscal.valorVenta,\r\n                                        detalleboletafiscal.cantidad,\r\n                                        detalleboletafiscal.porcentajeDescuentoLinea,\r\n                                        detalleboletafiscal.descuentoLinea,\r\n                                        detalleboletafiscal.subtotalLinea, \r\n                                        detalleboletafiscal.totalLinea, \r\n                                        detalleboletafiscal.tipoDescuento, \r\n                                        detalleboletafiscal.listaPrecio, \r\n                                        detalleboletafiscal.bodega,                                       \r\n                                        detalleboletafiscal.exento, \r\n                                        detalleboletafiscal.idImpuesto, \r\n                                        detalleboletafiscal.netoLinea,\r\n                                        detalleboletafiscal.valorCompra";

    public void guardaBoleta(Venta veOB, List<DatosVentaVO> lista)
    {
      if (veOB.Total == new Decimal(0))
        veOB.Folio = 0;
      this.agregaBoleta(veOB);
      if (veOB.Total == new Decimal(0))
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT DISTINCT LAST_INSERT_ID() FROM boletasFiscal";
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
      this.agregaDetalleBoleta(lista, veOB.Caja);
    }

    public string agregaBoleta(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO boletasFiscal (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            totalExento,\r\n                                                            totalaCobrar,\r\n                                                            pagaCon,\r\n                                                            vuelto,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            caja,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @totalExento,\r\n                                                            @totalaCobrar,\r\n                                                            @pagaCon,\r\n                                                            @vuelto,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @idTicket,\r\n                                                            @folioTicket,\r\n                                                            @caja,\r\n                                                            @idCotizacion,\r\n                                                            @folioCotizacion\r\n                                                   )";
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
        ((DbCommand) command).ExecuteNonQuery();
        return "Boleta Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleBoleta(List<DatosVentaVO> lista, int caja)
    {
      foreach (DatosVentaVO veVO in lista)
      {
        Decimal num = this.consultaStock(veVO);
        veVO.StockQueda = num - veVO.Cantidad;
        this.agregaDetalleBoleta2(veVO, caja);
        this.actualizaStock(veVO, "-");
      }
    }

    public bool agregaDetalleBoleta2(DatosVentaVO veVO, int caja)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura != 0 ? veVO.IdFactura : this.retornaIdBoleta(veVO.FolioFactura, caja);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detalleboletafiscal (\r\n                                                            idBoletaLinea,\r\n                                                            folioBoleta,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            resumenDescripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            exento,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idBoletaLinea,\r\n                                                            @folioBoletaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @resumenDescripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @exento,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda\r\n                                                             )";
        command.Parameters.AddWithValue("@idBoletaLinea", (object) num);
        command.Parameters.AddWithValue("@folioBoletaLinea", (object) veVO.FolioFactura);
        command.Parameters.AddWithValue("@fechaIngreso", (object) veVO.FechaIngreso);
        command.Parameters.AddWithValue("@codigo", (object) veVO.Codigo);
        command.Parameters.AddWithValue("@descripcion", (object) veVO.Descripcion);
        command.Parameters.AddWithValue("@resumenDescripcion", (object) veVO.ResumenDescripcion);
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
        ((DbCommand) command).CommandText = "INSERT INTO detalleboletafiscal (\r\n                                                            idBoletaLinea,\r\n                                                            folioBoleta,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            resumenDescripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            exento,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idBoletaLinea,\r\n                                                            @folioBoletaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            resumenDescripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @exento,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda\r\n                                                             )";
        command.Parameters.AddWithValue("@idBoletaLinea", (object) veVO.IdFactura);
        command.Parameters.AddWithValue("@folioBoletaLinea", (object) veVO.FolioFactura);
        command.Parameters.AddWithValue("@fechaIngreso", (object) veVO.FechaIngreso);
        command.Parameters.AddWithValue("@codigo", (object) veVO.Codigo);
        command.Parameters.AddWithValue("@descripcion", (object) veVO.Descripcion);
        command.Parameters.AddWithValue("@resumenDescripcion", (object) veVO.ResumenDescripcion);
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

    public string anulaBoleta(int idBoleta, List<DatosVentaVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE boletasFiscal SET estadoDocumento = 'ANULADA', razonSocial= 'BOLETA ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0'  WHERE idBoleta=@idBoleta";
      command.Parameters.AddWithValue("@idBoleta", (object) idBoleta);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        this.registroBoletaNula(datosVentaVo);
        this.actualizaStock(datosVentaVo, "+");
      }
      return "Boleta Anulada!!";
    }

    private void registroBoletaNula(DatosVentaVO vevo)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ANULA BOLETA FOLIO: " + (object) vevo.FolioFactura;
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = num + vevo.Cantidad;
      controlProducto.agregaControlProducto(cp);
    }

    public int eliminaBoleta(int idBoleta)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE boletasFiscal, detalleboletafiscal FROM boletasFiscal, detalleboletafiscal WHERE boletasFiscal.idBoleta = @idBoleta AND detalleboletafiscal.idBoletaLinea=@idBoleta";
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
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM boletasFiscal WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool boletaExiste(int numBoleta, int caja)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM boletasFiscal WHERE folio=@numBoleta AND caja=@caja";
      command.Parameters.AddWithValue("@numBoleta", (object) numBoleta);
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int retornaIdBoleta(int numBoleta, int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta, folio FROM boletasFiscal WHERE folio=@numBoleta AND caja=@caja";
      command.Parameters.AddWithValue("@numBoleta", (object) numBoleta);
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaBoletaFolio(int numBoleta, int caja)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            totalExento,\r\n                                                            totalaCobrar,\r\n                                                            pagaCon,\r\n                                                            vuelto,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion\r\n\r\n                                        FROM boletasFiscal WHERE folio=@numBoleta AND caja=@caja";
      command.Parameters.AddWithValue("@numBoleta", (object) numBoleta);
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"]);
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
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public Venta buscaBoletaID(int idBoleta)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            totalExento,\r\n                                                            totalaCobrar,\r\n                                                            pagaCon,\r\n                                                            vuelto,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion\r\n\r\n                                        FROM boletasFiscal WHERE idBoleta=@idBoleta";
      command.Parameters.AddWithValue("@idBoleta", (object) idBoleta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"]);
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
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<DatosVentaVO> buscaDetalleBoletaIDBoleta(int idBoleta)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleBoleta, \r\n                                                    idBoletaLinea,\r\n                                                    folioBoleta,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    resumenDescripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    exento,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra                                                    \r\n                                                    FROM detalleboletafiscal WHERE idBoletaLinea = @idBoleta ORDER BY idDetalleBoleta asc";
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
          ResumenDescripcion = ((DbDataReader) mySqlDataReader)["resumenDescripcion"].ToString(),
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
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaBoleta(Venta veOB, List<DatosVentaVO> listaNueva)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE boletasFiscal SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n\r\n                                                            totalExento=@totalExento,\r\n                                                            totalaCobrar=@totalaCobrar,\r\n                                                            pagaCon=@pagaCon,\r\n                                                            vuelto=@vuelto,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor\r\n                                           WHERE idBoleta=@idBoleta AND folio=@folio";
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
        ((DbCommand) command).ExecuteNonQuery();
        foreach (DatosVentaVO veVO in this.buscaDetalleBoletaIDBoleta(veOB.IdFactura))
          this.actualizaStock(veVO, "+");
        this.eliminaDetalleBoleta(veOB);
        foreach (DatosVentaVO veVO in listaNueva)
        {
          Decimal num = this.consultaStock(veVO);
          veVO.StockQueda = num - veVO.Cantidad;
          veVO.FechaIngreso = veVO.FechaIngreso.AddSeconds(40.0);
          this.agregaDetalleBoleta3(veVO);
          this.actualizaStock(veVO, "-");
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
        ((DbCommand) command).CommandText = "DELETE FROM detalleboletafiscal WHERE idBoletaLinea=@idBoleta AND folioBoleta=@folioBoleta";
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

    public DataTable muestraBoletaFolio(int folio, int caja)
    {
      string str = "SELECT " + this.camposBoleta + " FROM boletasFiscal INNER JOIN detalleboletafiscal \r\n                            ON boletasFiscal.idBoleta = detalleboletafiscal.idBoletaLinea WHERE boletasFiscal.folio=@folio AND caja=@caja AND detalleboletafiscal.exento=0 ORDER BY detalleboletafiscal.idDetalleBoleta";
      DataTable dataTable = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        command.Parameters.AddWithValue("@folio", (object) folio);
        command.Parameters.AddWithValue("@caja", (object) caja);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      catch (Exception ex)
      {
      }
      return dataTable;
    }

    public DataTable boletaInforme(string filtro)
    {
      string str = "SELECT \r\n                                        idBoleta,\r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        fechaVencimiento,\r\n                                        dia,\r\n                                        mes,\r\n                                        ano,\r\n                                        idCliente, \r\n                                        rut, \r\n                                        digito, \r\n                                        razonSocial,\r\n                                        direccion, \r\n                                        comuna, \r\n                                        ciudad, \r\n                                        giro, \r\n                                        fono, \r\n                                        fax, \r\n                                        contacto, \r\n                                        diasPlazo, \r\n                                        idMedioPago,                          \r\n                                        medioPago, \r\n                                        idVendedor, \r\n                                        vendedor, \r\n                                        idCentroCosto, \r\n                                        centroCosto, \r\n                                        ordenCompra, \r\n                                        subtotal, \r\n                                        porcentajeDescuento,\r\n                                        descuento, \r\n                                        porcentajeIva, \r\n                                        iva,\r\n                                        neto, \r\n                                        total, \r\n                                        totalExento,\r\n                                        totalaCobrar,\r\n                                        totalPalabras, \r\n                                        estadoPago, \r\n                                        estadoDocumento,\r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente,\r\n                                        pagaCon,\r\n                                        vuelto,             \r\n                                        impuesto1,\r\n                                        impuesto2,\r\n                                        impuesto3,\r\n                                        impuesto4,\r\n                                        impuesto5,\r\n                                        porcentajeImpuesto1,\r\n                                        porcentajeImpuesto2,\r\n                                        porcentajeImpuesto3,\r\n                                        porcentajeImpuesto4,\r\n                                        porcentajeImpuesto5,\r\n                                        comisionVendedor,\r\n                                        idTicket,\r\n                                        folioTicket,\r\n                                        caja,\r\n                                        idCotizacion,\r\n                                        folioCotizacion                                                  \r\n                            FROM boletasFiscal                             \r\n                            WHERE " + filtro + " ORDER BY folio";
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
      string str = "SELECT " + this.camposBoleta + " FROM boletasFiscal INNER JOIN detalleboletafiscal ON boletasFiscal.idBoleta = detalleboletafiscal.idBoletaLinea WHERE " + filtro + " ORDER BY folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable boletaInformeDetalleCategoriaProductos(string filtro)
    {
      string str = "SELECT " + this.camposBoleta + ", productos.Categoria AS 'DescCategoria' FROM boletasFiscal  INNER JOIN detalleboletafiscal ON boletasFiscal.idBoleta = detalleboletafiscal.idBoletaLinea  LEFT JOIN productos ON productos.Codigo = detalleboletafiscal.codigo  WHERE " + filtro;
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable boletaListado(DateTime desde, DateTime hasta, int caja)
    {
      string str = "SELECT \r\n                                        idBoleta,\r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        rut, \r\n                                        digito, \r\n                                        razonSocial,                                                                                \r\n                                        vendedor,                                                                                \r\n                                        totalaCobrar,                                        \r\n                                        estadoPago, \r\n                                        estadoDocumento,                                        \r\n                                        caja                                                  \r\n                            FROM boletasFiscal                             \r\n                            WHERE DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= DATE_FORMAT(@desde, '%Y-%m-%d') AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= DATE_FORMAT(@hasta, '%Y-%m-%d') AND caja=@caja ORDER BY idBoleta";
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
