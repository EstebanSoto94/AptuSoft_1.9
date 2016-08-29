 
// Type: Aptusoft.FacturaElectronica.Clases.EGuia
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.Lotes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class EGuia
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaGuia(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO electronica_guia (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,totalExento,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            fechaModificacion,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            caja,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            folioOT,\r\n                                                            timbre,\r\n                                                            tipoDocumento1,\r\n                                                            tipoDocumento2,\r\n                                                            tipoDocumento3,\r\n                                                            tipoDocumento4,\r\n                                                            tipoDocumento5,\r\n                                                            tipoDocumentoNombre1,\r\n                                                            tipoDocumentoNombre2,\r\n                                                            tipoDocumentoNombre3,\r\n                                                            tipoDocumentoNombre4,\r\n                                                            tipoDocumentoNombre5,\r\n                                                            folioDocumentoReferencia1,\r\n                                                            folioDocumentoReferencia2,\r\n                                                            folioDocumentoReferencia3,\r\n                                                            folioDocumentoReferencia4,\r\n                                                            folioDocumentoReferencia5,\r\n                                                            fechaDocumentoReferencia1,\r\n                                                            fechaDocumentoReferencia2,\r\n                                                            fechaDocumentoReferencia3,\r\n                                                            fechaDocumentoReferencia4,\r\n                                                            fechaDocumentoReferencia5,\r\n                                                            tipoAccion1,\r\n                                                            tipoAccion2,\r\n                                                            tipoAccion3,\r\n                                                            tipoAccion4,\r\n                                                            tipoAccion5,\r\n                                                            tipoAccionNombre1,\r\n                                                            tipoAccionNombre2,\r\n                                                            tipoAccionNombre3,\r\n                                                            tipoAccionNombre4,\r\n                                                            tipoAccionNombre5,\r\n                                                            razonReferencia1,\r\n                                                            razonReferencia2,\r\n                                                            razonReferencia3,\r\n                                                            razonReferencia4,\r\n                                                            razonReferencia5,\r\n                                                            tipoGuia,\r\n                                                            codigoTipoGuia,\r\n                                                            trasladadoPor,\r\n                                                            codigoTrasladadoPor\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total, @totalExento,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @idTicket,\r\n                                                            @folioTicket,\r\n                                                            @folioGuias,\r\n                                                            @observaciones,\r\n                                                            @fechaModificacion,\r\n                                                            @idCotizacion,\r\n                                                            @folioCotizacion,\r\n                                                            @caja,\r\n                                                            @idNotaVenta,\r\n                                                            @folioNotaVenta,\r\n                                                            @folioOT, \r\n                                                            @timbre,\r\n                                                            @tipoDocumento1,\r\n                                                            @tipoDocumento2,\r\n                                                            @tipoDocumento3,\r\n                                                            @tipoDocumento4,\r\n                                                            @tipoDocumento5,\r\n                                                            @tipoDocumentoNombre1,\r\n                                                            @tipoDocumentoNombre2,\r\n                                                            @tipoDocumentoNombre3,\r\n                                                            @tipoDocumentoNombre4,\r\n                                                            @tipoDocumentoNombre5,\r\n                                                            @folioDocumentoReferencia1,\r\n                                                            @folioDocumentoReferencia2,\r\n                                                            @folioDocumentoReferencia3,\r\n                                                            @folioDocumentoReferencia4,\r\n                                                            @folioDocumentoReferencia5,\r\n                                                            @fechaDocumentoReferencia1,\r\n                                                            @fechaDocumentoReferencia2,\r\n                                                            @fechaDocumentoReferencia3,\r\n                                                            @fechaDocumentoReferencia4,\r\n                                                            @fechaDocumentoReferencia5,\r\n                                                            @tipoAccion1,\r\n                                                            @tipoAccion2,\r\n                                                            @tipoAccion3,\r\n                                                            @tipoAccion4,\r\n                                                            @tipoAccion5,\r\n                                                            @tipoAccionNombre1,\r\n                                                            @tipoAccionNombre2,\r\n                                                            @tipoAccionNombre3,\r\n                                                            @tipoAccionNombre4,\r\n                                                            @tipoAccionNombre5,\r\n                                                            @razonReferencia1,\r\n                                                            @razonReferencia2,\r\n                                                            @razonReferencia3,\r\n                                                            @razonReferencia4,\r\n                                                            @razonReferencia5,\r\n                                                            @tipoGuia,\r\n                                                            @codigoTipoGuia,\r\n                                                            @trasladadoPor,\r\n                                                            @codigoTrasladadoPor\r\n                                                   )";
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
      command.Parameters.AddWithValue("@totalExento", (object) veOB.TotalExento);
      command.Parameters.AddWithValue("@totalPalabras", (object) veOB.TotalPalabras);
      command.Parameters.AddWithValue("@estadoPago", (object) veOB.EstadoPago);
      command.Parameters.AddWithValue("@estadoDocumento", (object) veOB.EstadoDocumento);
      command.Parameters.AddWithValue("@totalPagado", (object) veOB.TotalPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) veOB.TotalDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) veOB.TotalPendiente);
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
      command.Parameters.AddWithValue("@folioGuias", (object) veOB.FolioGuias);
      command.Parameters.AddWithValue("@observaciones", (object) veOB.Observaciones);
      command.Parameters.AddWithValue("@fechaModificacion", (object) DateTime.Now);
      command.Parameters.AddWithValue("@idCotizacion", (object) veOB.IdCotizacion);
      command.Parameters.AddWithValue("@folioCotizacion", (object) veOB.FolioCotizacion);
      command.Parameters.AddWithValue("@caja", (object) veOB.Caja);
      command.Parameters.AddWithValue("@idNotaVenta", (object) veOB.IdNotaVenta);
      command.Parameters.AddWithValue("@folioNotaVenta", (object) veOB.FolioNotaVenta);
      command.Parameters.AddWithValue("@folioOT", (object) veOB.FolioOT);
      command.Parameters.AddWithValue("@timbre", (object) veOB.Timbre);
      command.Parameters.AddWithValue("@tipoDocumento1", (object) veOB.FE_tipoDocumento1);
      command.Parameters.AddWithValue("@tipoDocumento2", (object) veOB.FE_tipoDocumento2);
      command.Parameters.AddWithValue("@tipoDocumento3", (object) veOB.FE_tipoDocumento3);
      command.Parameters.AddWithValue("@tipoDocumento4", (object) veOB.FE_tipoDocumento4);
      command.Parameters.AddWithValue("@tipoDocumento5", (object) veOB.FE_tipoDocumento5);
      command.Parameters.AddWithValue("@tipoDocumentoNombre1", (object) veOB.FE_tipoDocumentoNombre1);
      command.Parameters.AddWithValue("@tipoDocumentoNombre2", (object) veOB.FE_tipoDocumentoNombre2);
      command.Parameters.AddWithValue("@tipoDocumentoNombre3", (object) veOB.FE_tipoDocumentoNombre3);
      command.Parameters.AddWithValue("@tipoDocumentoNombre4", (object) veOB.FE_tipoDocumentoNombre4);
      command.Parameters.AddWithValue("@tipoDocumentoNombre5", (object) veOB.FE_tipoDocumentoNombre5);
      command.Parameters.AddWithValue("@folioDocumentoReferencia1", (object) veOB.FE_folioDocumentoReferencia1);
      command.Parameters.AddWithValue("@folioDocumentoReferencia2", (object) veOB.FE_folioDocumentoReferencia2);
      command.Parameters.AddWithValue("@folioDocumentoReferencia3", (object) veOB.FE_folioDocumentoReferencia3);
      command.Parameters.AddWithValue("@folioDocumentoReferencia4", (object) veOB.FE_folioDocumentoReferencia4);
      command.Parameters.AddWithValue("@folioDocumentoReferencia5", (object) veOB.FE_folioDocumentoReferencia5);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia1", (object) veOB.FE_fechaDocumentoReferencia1);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia2", (object) veOB.FE_fechaDocumentoReferencia2);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia3", (object) veOB.FE_fechaDocumentoReferencia3);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia4", (object) veOB.FE_fechaDocumentoReferencia4);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia5", (object) veOB.FE_fechaDocumentoReferencia5);
      command.Parameters.AddWithValue("@tipoAccion1", (object) veOB.FE_tipoAccion1);
      command.Parameters.AddWithValue("@tipoAccion2", (object) veOB.FE_tipoAccion2);
      command.Parameters.AddWithValue("@tipoAccion3", (object) veOB.FE_tipoAccion3);
      command.Parameters.AddWithValue("@tipoAccion4", (object) veOB.FE_tipoAccion4);
      command.Parameters.AddWithValue("@tipoAccion5", (object) veOB.FE_tipoAccion5);
      command.Parameters.AddWithValue("@tipoAccionNombre1", (object) veOB.FE_tipoAccionNombre1);
      command.Parameters.AddWithValue("@tipoAccionNombre2", (object) veOB.FE_tipoAccionNombre2);
      command.Parameters.AddWithValue("@tipoAccionNombre3", (object) veOB.FE_tipoAccionNombre3);
      command.Parameters.AddWithValue("@tipoAccionNombre4", (object) veOB.FE_tipoAccionNombre4);
      command.Parameters.AddWithValue("@tipoAccionNombre5", (object) veOB.FE_tipoAccionNombre5);
      command.Parameters.AddWithValue("@razonReferencia1", (object) veOB.FE_razonReferencia1);
      command.Parameters.AddWithValue("@razonReferencia2", (object) veOB.FE_razonReferencia2);
      command.Parameters.AddWithValue("@razonReferencia3", (object) veOB.FE_razonReferencia3);
      command.Parameters.AddWithValue("@razonReferencia4", (object) veOB.FE_razonReferencia4);
      command.Parameters.AddWithValue("@razonReferencia5", (object) veOB.FE_razonReferencia5);
      command.Parameters.AddWithValue("@tipoGuia", (object) veOB.FE_tipoGuia);
      command.Parameters.AddWithValue("@codigoTipoGuia", (object) veOB.FE_codigoTipoGuia);
      command.Parameters.AddWithValue("@trasladadoPor", (object) veOB.FE_trasladadoPor);
      command.Parameters.AddWithValue("@codigoTrasladadoPor", (object) veOB.FE_codigoTrasladadaPor);
      ((DbCommand) command).ExecuteNonQuery();
      return "Guia Ingresada";
    }

    public void agregaDetalleGuia(List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      int num1 = 0;
      long num2 = 0L;
      foreach (DatosVentaVO veVO in lista)
      {
        if (num1 == 0)
        {
          num1 = this.retornaIdGuia(veVO.FolioFactura);
          num2 = (long) veVO.FolioFactura;
        }
        veVO.IdFactura = num1;
        if (veVO.DescuentaInventario)
        {
          Decimal num3 = this.consultaStock(veVO);
          veVO.StockQueda = num3 - veVO.Cantidad;
          this.actualizaStock(veVO, "-");
          if (veVO.BodegaDestino > 0)
          {
            int bodega = veVO.Bodega;
            veVO.Bodega = veVO.BodegaDestino;
            Decimal num4 = this.consultaStock(veVO);
            veVO.StockQuedaDestino = num4 + veVO.Cantidad;
            this.actualizaStock(veVO, "+");
            veVO.Bodega = bodega;
          }
        }
        this.agregaDetalleGuia2(veVO);
      }
      if (listaLote.Count <= 0)
        return;
      string str = "GUIA ELECTRONICA";
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
    public string UltimoFolio()
    {
        string ultimo = "";
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand)command).CommandText = "select last_insert_id(folio) as last from electronica_guia order by folio desc limit 1;";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader)mySqlDataReader).Read())
        {
            ultimo = ((DbDataReader)mySqlDataReader)["last"].ToString();
        }

        ((DbDataReader)mySqlDataReader).Close();
        return ultimo;
    }
    public bool agregaDetalleGuia2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura;
      if (num == 0)
        num = this.retornaIdGuia(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO electronica_detalle_guia (\r\n                                                            idGuiaLinea,\r\n                                                            folioGuia,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda, \r\n                                                            exento,\r\n                                                            bodegaDestino,\r\n                                                            stockQuedaDestino\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idGuiaLinea,\r\n                                                            @folioGuiaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda,\r\n                                                            @exento,\r\n                                                            @bodegaDestino,\r\n                                                            @stockQuedaDestino\r\n                                                             )";
        command.Parameters.AddWithValue("@idGuiaLinea", (object) num);
        command.Parameters.AddWithValue("@folioGuiaLinea", (object) veVO.FolioFactura);
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
        command.Parameters.AddWithValue("@idImpuesto", (object) veVO.IdImpuesto);
        command.Parameters.AddWithValue("@netoLinea", (object) veVO.NetoLinea);
        command.Parameters.AddWithValue("@descuentaInventario", (veVO.DescuentaInventario ? 1 : 0));
        command.Parameters.AddWithValue("@valorCompra", (object) veVO.ValorCompra);
        command.Parameters.AddWithValue("@usuario", (object) veVO.Usuario);
        command.Parameters.AddWithValue("@stockQueda", (object) veVO.StockQueda);
        command.Parameters.AddWithValue("@exento", (veVO.Exento ? 1 : 0));
        command.Parameters.AddWithValue("@bodegaDestino", (object) veVO.BodegaDestino);
        command.Parameters.AddWithValue("@stockQuedaDestino", (object) veVO.StockQuedaDestino);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        string message = ex.Message;
        return false;
      }
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

    public int retornaIdGuia(int numGuia)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idGuia, folio FROM electronica_guia WHERE folio=@numGuia";
      command.Parameters.AddWithValue("@numGuia", (object) numGuia);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public void agregaReferencia(List<ReferenicaVO> listaReferencia)
    {
      int num = this.retornaIdGuia(listaReferencia[0].FolioDocumento);
      foreach (ReferenicaVO refe in listaReferencia)
      {
        refe.idDocumento = num;
        this.agregaReferencia2(refe);
      }
    }

    private void agregaReferencia2(ReferenicaVO refe)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO electronica_guia_referencias (\r\n                                                            idGuia,\r\n                                                            folioGuia,\r\n                                                            tipoDocumento,\r\n                                                            tipoDocumentoNombre,\r\n                                                            folioDocumentoReferencia,\r\n                                                            fechaDocumentoReferencia,\r\n                                                            tipoAccion,\r\n                                                            tipoAccionNombre,\r\n                                                            razonReferencia\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idGuia,\r\n                                                            @folioGuia,\r\n                                                            @tipoDocumento,\r\n                                                            @tipoDocumentoNombre,\r\n                                                            @folioDocumentoReferencia,\r\n                                                            @fechaDocumentoReferencia,\r\n                                                            @tipoAccion,\r\n                                                            @tipoAccionNombre,\r\n                                                            @razonReferencia\r\n                                                             )";
      command.Parameters.AddWithValue("@idGuia", (object) refe.idDocumento);
      command.Parameters.AddWithValue("@folioGuia", (object) refe.FolioDocumento);
      command.Parameters.AddWithValue("@tipoDocumento", (object) refe.TipoDocumento);
      command.Parameters.AddWithValue("@tipoDocumentoNombre", (object) refe.TipoDocumentoNombre);
      command.Parameters.AddWithValue("@folioDocumentoReferencia", (object) refe.FolioDocumentoReferencia);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia", (object) refe.FechaDocumentoReferencia);
      command.Parameters.AddWithValue("@tipoAccion", (object) refe.TipoAccion);
      command.Parameters.AddWithValue("@tipoAccionNombre", (object) refe.TipoAccionNombre);
      command.Parameters.AddWithValue("@razonReferencia", (object) refe.RazonReferencia);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public bool guiaExiste(int numGuia)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM electronica_guia WHERE folio=@numGuia";
      command.Parameters.AddWithValue("@numGuia", (object) numGuia);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int numeroGuia(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand)command).CommandText = "SELECT MAX(folio)+1 FROM electronica_guia";
        /*WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);*/
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaGuiaFolio(int numGuia)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idGuia,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total, totalExento,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            folioOT, \r\n                                                            timbre,\r\n                                                            enviado_sii,\r\n                                                            enviado_libro, \r\n                                                            tipoGuia,\r\n                                                            codigoTipoGuia,\r\n                                                            trasladadoPor,\r\n                                                            codigoTrasladadoPor,\r\n                                                            facturada,\r\n                                                            folioFactura,\r\n                                                            documentoVenta     \r\n                                                FROM electronica_guia WHERE folio=@numGuia";
      command.Parameters.AddWithValue("@numGuia", (object) numGuia);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGuia"]);
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
        venta.TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]);
        venta.TotalPalabras = ((DbDataReader) mySqlDataReader)["totalPalabras"].ToString();
        venta.EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString();
        venta.EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString();
        venta.TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPagado"]);
        venta.TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalDocumentado"]);
        venta.TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPendiente"]);
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
        venta.FolioGuias = ((DbDataReader) mySqlDataReader)["folioGuias"].ToString();
        venta.Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString();
        venta.IdCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]);
        venta.FolioCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]);
        venta.IdNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVenta"]);
        venta.FolioNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaVenta"]);
        venta.FolioOT = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioOT"]);
        venta.Timbre = ((DbDataReader) mySqlDataReader)["timbre"].ToString();
        venta.FE_enviado_Sii = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_sii"]);
        venta.FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"]);
        venta.FE_codigoTipoGuia = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoTipoGuia"].ToString());
        venta.FE_tipoGuia = ((DbDataReader) mySqlDataReader)["tipoGuia"].ToString();
        venta.FE_codigoTrasladadaPor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoTrasladadoPor"].ToString());
        venta.FE_trasladadoPor = ((DbDataReader) mySqlDataReader)["trasladadoPor"].ToString();
        venta.Facturada = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["facturada"]);
        venta.FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioFactura"]);
        venta.DocumentoVenta = ((DbDataReader) mySqlDataReader)["documentoVenta"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<DatosVentaVO> buscaDetalleGuiaIDGuia(int idGuia)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleGuia, \r\n                                                    idGuiaLinea,\r\n                                                    folioGuia,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    descuentaInventario,\r\n                                                    valorCompra,stockQueda, exento, bodegaDestino, stockQuedaDestino\r\n                                                    FROM electronica_detalle_guia WHERE idGuiaLinea = @idGuia ORDER BY idDetalleGuia asc";
      command.Parameters.AddWithValue("@idGuia", (object) idGuia);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleGuia"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGuiaLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioGuia"]),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"]),
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
          IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]),
          NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]),
          DescuentaInventario = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["descuentaInventario"].ToString()),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]),
          StockQueda = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQueda"]),
          Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]),
          BodegaDestino = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodegaDestino"]),
          StockQuedaDestino = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQuedaDestino"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<ReferenicaVO> buscaReferenciaIDGuia(int idGuia)
    {
      List<ReferenicaVO> list = new List<ReferenicaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idReferencia, idGuia,\r\n                                                            folioGuia,\r\n                                                            tipoDocumento,\r\n                                                            tipoDocumentoNombre,\r\n                                                            folioDocumentoReferencia,\r\n                                                            fechaDocumentoReferencia,\r\n                                                            tipoAccion,\r\n                                                            tipoAccionNombre,\r\n                                                            razonReferencia\r\n                                                    FROM electronica_guia_referencias WHERE idGuia = @idGuia ORDER BY idReferencia asc";
      command.Parameters.AddWithValue("@idGuia", (object) idGuia);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ReferenicaVO()
        {
          IdReferencia = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idReferencia"].ToString()),
          idDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGuia"].ToString()),
          FolioDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioGuia"].ToString()),
          TipoDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()),
          TipoDocumentoNombre = ((DbDataReader) mySqlDataReader)["tipoDocumentoNombre"].ToString(),
          FolioDocumentoReferencia = ((DbDataReader) mySqlDataReader)["folioDocumentoReferencia"].ToString(),
          FechaDocumentoReferencia = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaDocumentoReferencia"]),
          TipoAccion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoAccion"].ToString()),
          TipoAccionNombre = ((DbDataReader) mySqlDataReader)["tipoAccionNombre"].ToString(),
          RazonReferencia = ((DbDataReader) mySqlDataReader)["razonReferencia"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaGuia(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_guia SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalExento=@totalExento,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor,\r\n                                                            folioGuias=@folioGuias,\r\n                                                            observaciones=@observaciones,\r\n                                                            fechaModificacion=@fechaModificacion,\r\n                                                            tipoDocumento1=@tipoDocumento1,\r\n                                                            tipoDocumento2=@tipoDocumento2,\r\n                                                            tipoDocumento3=@tipoDocumento3,\r\n                                                            tipoDocumento4=@tipoDocumento4,\r\n                                                            tipoDocumento5=@tipoDocumento5,\r\n                                                            tipoDocumentoNombre1=@tipoDocumentoNombre1,\r\n                                                            tipoDocumentoNombre2=@tipoDocumentoNombre2,\r\n                                                            tipoDocumentoNombre3=@tipoDocumentoNombre3,\r\n                                                            tipoDocumentoNombre4=@tipoDocumentoNombre4,\r\n                                                            tipoDocumentoNombre5=@tipoDocumentoNombre5,\r\n                                                            folioDocumentoReferencia1=@folioDocumentoReferencia1,\r\n                                                            folioDocumentoReferencia2=@folioDocumentoReferencia2,\r\n                                                            folioDocumentoReferencia3=@folioDocumentoReferencia3,\r\n                                                            folioDocumentoReferencia4=@folioDocumentoReferencia4,\r\n                                                            folioDocumentoReferencia5=@folioDocumentoReferencia5,\r\n                                                            fechaDocumentoReferencia1=@fechaDocumentoReferencia1,\r\n                                                            fechaDocumentoReferencia2=@fechaDocumentoReferencia2,\r\n                                                            fechaDocumentoReferencia3=@fechaDocumentoReferencia3,\r\n                                                            fechaDocumentoReferencia4=@fechaDocumentoReferencia4,\r\n                                                            fechaDocumentoReferencia5=@fechaDocumentoReferencia5,\r\n                                                            tipoAccion1=@tipoAccion1,\r\n                                                            tipoAccion2=@tipoAccion2,\r\n                                                            tipoAccion3=@tipoAccion3,\r\n                                                            tipoAccion4=@tipoAccion4,\r\n                                                            tipoAccion5=@tipoAccion5,\r\n                                                            tipoAccionNombre1=@tipoAccionNombre1,\r\n                                                            tipoAccionNombre2=@tipoAccionNombre2,\r\n                                                            tipoAccionNombre3=@tipoAccionNombre3,\r\n                                                            tipoAccionNombre4=@tipoAccionNombre4,\r\n                                                            tipoAccionNombre5=@tipoAccionNombre5,\r\n                                                            razonReferencia1=@razonReferencia1,\r\n                                                            razonReferencia2=@razonReferencia2,\r\n                                                            razonReferencia3=@razonReferencia3,\r\n                                                            razonReferencia4=@razonReferencia4,\r\n                                                            razonReferencia5=@razonReferencia5,\r\n                                                            tipoGuia=@tipoGuia,\r\n                                                            codigoTipoGuia=@codigoTipoGuia,\r\n                                                            trasladadoPor=@trasladadoPor,\r\n                                                            codigoTrasladadoPor=@codigoTrasladadoPor                                              \r\n\r\n                                           WHERE idGuia=@idGuia AND folio=@folio";
      command.Parameters.AddWithValue("@idGuia", (object) veOB.IdFactura);
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
      command.Parameters.AddWithValue("@totalExento", (object) veOB.TotalExento);
      command.Parameters.AddWithValue("@totalPalabras", (object) veOB.TotalPalabras);
      command.Parameters.AddWithValue("@estadoPago", (object) veOB.EstadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) veOB.TotalPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) veOB.TotalDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) veOB.TotalPendiente);
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
      command.Parameters.AddWithValue("@folioGuias", (object) veOB.FolioGuias);
      command.Parameters.AddWithValue("@observaciones", (object) veOB.Observaciones);
      command.Parameters.AddWithValue("@fechaModificacion", (object) DateTime.Now);
      command.Parameters.AddWithValue("@tipoDocumento1", (object) veOB.FE_tipoDocumento1);
      command.Parameters.AddWithValue("@tipoDocumento2", (object) veOB.FE_tipoDocumento2);
      command.Parameters.AddWithValue("@tipoDocumento3", (object) veOB.FE_tipoDocumento3);
      command.Parameters.AddWithValue("@tipoDocumento4", (object) veOB.FE_tipoDocumento4);
      command.Parameters.AddWithValue("@tipoDocumento5", (object) veOB.FE_tipoDocumento5);
      command.Parameters.AddWithValue("@tipoDocumentoNombre1", (object) veOB.FE_tipoDocumentoNombre1);
      command.Parameters.AddWithValue("@tipoDocumentoNombre2", (object) veOB.FE_tipoDocumentoNombre2);
      command.Parameters.AddWithValue("@tipoDocumentoNombre3", (object) veOB.FE_tipoDocumentoNombre3);
      command.Parameters.AddWithValue("@tipoDocumentoNombre4", (object) veOB.FE_tipoDocumentoNombre4);
      command.Parameters.AddWithValue("@tipoDocumentoNombre5", (object) veOB.FE_tipoDocumentoNombre5);
      command.Parameters.AddWithValue("@folioDocumentoReferencia1", (object) veOB.FE_folioDocumentoReferencia1);
      command.Parameters.AddWithValue("@folioDocumentoReferencia2", (object) veOB.FE_folioDocumentoReferencia2);
      command.Parameters.AddWithValue("@folioDocumentoReferencia3", (object) veOB.FE_folioDocumentoReferencia3);
      command.Parameters.AddWithValue("@folioDocumentoReferencia4", (object) veOB.FE_folioDocumentoReferencia4);
      command.Parameters.AddWithValue("@folioDocumentoReferencia5", (object) veOB.FE_folioDocumentoReferencia5);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia1", (object) veOB.FE_fechaDocumentoReferencia1);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia2", (object) veOB.FE_fechaDocumentoReferencia2);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia3", (object) veOB.FE_fechaDocumentoReferencia3);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia4", (object) veOB.FE_fechaDocumentoReferencia4);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia5", (object) veOB.FE_fechaDocumentoReferencia5);
      command.Parameters.AddWithValue("@tipoAccion1", (object) veOB.FE_tipoAccion1);
      command.Parameters.AddWithValue("@tipoAccion2", (object) veOB.FE_tipoAccion2);
      command.Parameters.AddWithValue("@tipoAccion3", (object) veOB.FE_tipoAccion3);
      command.Parameters.AddWithValue("@tipoAccion4", (object) veOB.FE_tipoAccion4);
      command.Parameters.AddWithValue("@tipoAccion5", (object) veOB.FE_tipoAccion5);
      command.Parameters.AddWithValue("@tipoAccionNombre1", (object) veOB.FE_tipoAccionNombre1);
      command.Parameters.AddWithValue("@tipoAccionNombre2", (object) veOB.FE_tipoAccionNombre2);
      command.Parameters.AddWithValue("@tipoAccionNombre3", (object) veOB.FE_tipoAccionNombre3);
      command.Parameters.AddWithValue("@tipoAccionNombre4", (object) veOB.FE_tipoAccionNombre4);
      command.Parameters.AddWithValue("@tipoAccionNombre5", (object) veOB.FE_tipoAccionNombre5);
      command.Parameters.AddWithValue("@razonReferencia1", (object) veOB.FE_razonReferencia1);
      command.Parameters.AddWithValue("@razonReferencia2", (object) veOB.FE_razonReferencia2);
      command.Parameters.AddWithValue("@razonReferencia3", (object) veOB.FE_razonReferencia3);
      command.Parameters.AddWithValue("@razonReferencia4", (object) veOB.FE_razonReferencia4);
      command.Parameters.AddWithValue("@razonReferencia5", (object) veOB.FE_razonReferencia5);
      command.Parameters.AddWithValue("@tipoGuia", (object) veOB.FE_tipoGuia);
      command.Parameters.AddWithValue("@codigoTipoGuia", (object) veOB.FE_codigoTipoGuia);
      command.Parameters.AddWithValue("@trasladadoPor", (object) veOB.FE_trasladadoPor);
      command.Parameters.AddWithValue("@codigoTrasladadoPor", (object) veOB.FE_codigoTrasladadaPor);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in this.buscaDetalleGuiaIDGuia(veOB.IdFactura))
      {
        new ControlProducto().registroDocumentoModifica(datosVentaVo, "GUIA ELECTRONICA");
        new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "GUIA ELECTRONICA");
        this.actualizaStock(datosVentaVo, "+");
        if (datosVentaVo.BodegaDestino > 0)
        {
          datosVentaVo.Bodega = datosVentaVo.BodegaDestino;
          datosVentaVo.StockQueda = datosVentaVo.StockQuedaDestino;
          new ControlProducto().registroDocumentoModificaNotaCredito(datosVentaVo, "GUIA ELECTRONICA TRASLADO");
          new ControlProducto().registroDocumentoModificaRetornaInventarioNC(datosVentaVo, "GUIA ELECTRONICA TRASLADO");
          this.actualizaStock(datosVentaVo, "-");
        }
      }
      this.eliminaDetalleGuia(veOB);
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      foreach (DatosVentaVO veVO in listaNueva)
      {
        Decimal num1 = this.consultaStock(veVO);
        veVO.StockQueda = num1 - veVO.Cantidad;
        this.agregaDetalleGuia2(veVO);
        this.actualizaStock(veVO, "-");
        if (veVO.BodegaDestino > 0)
        {
          int bodega = veVO.Bodega;
          veVO.Bodega = veVO.BodegaDestino;
          Decimal num2 = this.consultaStock(veVO);
          veVO.StockQuedaDestino = num2 + veVO.Cantidad;
          this.actualizaStock(veVO, "+");
          veVO.Bodega = bodega;
        }
      }
      if (listaLote.Count > 0)
      {
        int idFactura = veOB.IdFactura;
        long num = (long) veOB.Folio;
        string str = "GUIA ELECTRONICA";
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
      return "Guia Modificada";
    }

    public bool eliminaDetalleGuia(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM electronica_detalle_guia WHERE idGuiaLinea=@idGuia AND folioGuia=@folioGuia";
        command.Parameters.AddWithValue("@idGuia", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioGuia", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public int eliminaGuia(int idGuia, List<DatosVentaVO> lista, List<LoteVO> listaLoteAntigua)
    {
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "GUIA ELECTRONICA");
          this.actualizaStock(datosVentaVo, "+");
          if (datosVentaVo.BodegaDestino > 0)
          {
            datosVentaVo.Bodega = datosVentaVo.BodegaDestino;
            datosVentaVo.StockQueda = datosVentaVo.StockQuedaDestino;
            new ControlProducto().registroDocumentoNuloNotaCredito(datosVentaVo, "GUIA ELECTRONICA TRASLADO");
            this.actualizaStock(datosVentaVo, "-");
          }
        }
      }
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE electronica_guia, electronica_detalle_guia FROM electronica_guia, electronica_detalle_guia WHERE electronica_guia.idGuia = @idGuia AND electronica_detalle_guia.idGuiaLinea=@idGuia";
      command.Parameters.AddWithValue("@idGuia", (object) idGuia);
      int num = ((DbCommand) command).ExecuteNonQuery();
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      return num;
    }

    public List<Venta> buscaGuiaseElectronicaSinFacturar(int idCliente)
    {
      List<Venta> list = new List<Venta>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idGuia,\r\n                                            folio,\r\n                                            fechaEmision,\r\n                                            idCliente,                                            \r\n                                            total                                          \r\n                                            \r\n                                    FROM electronica_guia WHERE idCliente=@idCliente AND facturada=0 AND estadoDocumento='EMITIDA'";
      command.Parameters.AddWithValue("@idCliente", (object) idCliente);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new Venta()
        {
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGuia"].ToString()),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"].ToString()),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"].ToString()),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString()),
          DocumentoVenta = "GUIA ELECTRONICA"
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void facturaGuia(Venta veOB)
    {
      string folioGuias = veOB.FolioGuias;
      char[] chArray = new char[1]
      {
        '-'
      };
      foreach (string str1 in folioGuias.Split(chArray))
      {
        string str2 = str1.Replace(".", "");
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "UPDATE electronica_guia SET facturada=@facturada, folioFactura=@folioFactura, documentoVenta=@docVenta\r\n                                           WHERE  folio=@folio";
        command.Parameters.AddWithValue("@folio", (object) str2);
        command.Parameters.AddWithValue("@facturada", (veOB.Facturada ? 1 : 0));
        command.Parameters.AddWithValue("@folioFactura", (object) veOB.Folio);
        command.Parameters.AddWithValue("@docVenta", (object) veOB.DocumentoVenta);
        ((DbCommand) command).ExecuteNonQuery();
      }
    }

    public DataTable muestraGuiaFolio(int folio)
    {
      string str = "SELECT \r\n                            f.idGuia,\r\n                            f.folio,\r\n                            f.fechaEmision,\r\n                            f.fechaVencimiento,\r\n                            f.dia,\r\n                            f.mes,\r\n                            f.ano,\r\n                            f.idCliente, \r\n                            f.rut, \r\n                            f.digito, \r\n                            f.razonSocial,\r\n                            f.direccion, \r\n                            f.comuna, \r\n                            f.ciudad, \r\n                            f.giro, \r\n                            f.fono, \r\n                            f.fax, \r\n                            f.contacto, \r\n                            f.diasPlazo, \r\n                            f.idMedioPago,                          \r\n                            f.medioPago, \r\n                            f.idVendedor, \r\n                            f.vendedor, \r\n                            f.idCentroCosto, \r\n                            f.centroCosto, \r\n                            f.ordenCompra, \r\n                            f.subtotal, \r\n                            f.porcentajeDescuento,\r\n                            f.descuento, \r\n                            f.porcentajeIva, \r\n                            f.iva,\r\n                            f.neto, \r\n                            f.total, \r\n                            f.totalExento,\r\n                            f.totalPalabras, \r\n                            f.estadoPago, \r\n                            f.estadoDocumento, \r\n                            f.totalPagado,\r\n                            f.totalDocumentado,\r\n                            f.totalPendiente,\r\n                            f.impuesto1,\r\n                            f.impuesto2,\r\n                            f.impuesto3,\r\n                            f.impuesto4,\r\n                            f.impuesto5,\r\n                            f.porcentajeImpuesto1,\r\n                            f.porcentajeImpuesto2,\r\n                            f.porcentajeImpuesto3,\r\n                            f.porcentajeImpuesto4,\r\n                            f.porcentajeImpuesto5,\r\n                            f.comisionVendedor,\r\n                            f.idTicket,\r\n                            f.folioTicket,\r\n                            f.folioGuias,\r\n                            f.observaciones,\r\n                            f.fechaModificacion,\r\n                            f.idCotizacion,\r\n                            f.folioCotizacion,\r\n                            f.caja,\r\n                            f.idNotaVenta,\r\n                            f.folioNotaVenta,\r\n                            f.tipoDocumento1,\r\n                            f.tipoDocumento2,\r\n                            f.tipoDocumento3,\r\n                            f.tipoDocumento4,\r\n                            f.tipoDocumento5,\r\n                            f.tipoDocumentoNombre1,\r\n                            f.tipoDocumentoNombre2,\r\n                            f.tipoDocumentoNombre3,\r\n                            f.tipoDocumentoNombre4,\r\n                            f.tipoDocumentoNombre5,\r\n                            f.folioDocumentoReferencia1,\r\n                            f.folioDocumentoReferencia2,\r\n                            f.folioDocumentoReferencia3,\r\n                            f.folioDocumentoReferencia4,\r\n                            f.folioDocumentoReferencia5,\r\n                            f.fechaDocumentoReferencia1,\r\n                            f.fechaDocumentoReferencia2,\r\n                            f.fechaDocumentoReferencia3,\r\n                            f.fechaDocumentoReferencia4,\r\n                            f.fechaDocumentoReferencia5,\r\n                            f.tipoAccion1,\r\n                            f.tipoAccion2,\r\n                            f.tipoAccion3,\r\n                            f.tipoAccion4,\r\n                            f.tipoAccion5,\r\n                            f.tipoAccionNombre1,\r\n                            f.tipoAccionNombre2,\r\n                            f.tipoAccionNombre3,\r\n                            f.tipoAccionNombre4,\r\n                            f.tipoAccionNombre5,\r\n                            f.razonReferencia1,\r\n                            f.razonReferencia2,\r\n                            f.razonReferencia3,\r\n                            f.razonReferencia4,\r\n                            f.razonReferencia5,\r\n                            f.tipoGuia as 'tipoDocumentoVenta',\r\n                            f.codigoTipoGuia as 'codigoDocumento',\r\n                            f.trasladadoPor,\r\n                            f.codigoTrasladadoPor,\r\n                            d.idGuiaLinea,\r\n                            d.folioGuia,\r\n                            d.fechaIngreso,\r\n                            d.codigo,\r\n                            d.descripcion,\r\n                            d.valorVenta,\r\n                            d.cantidad,\r\n                            d.porcentajeDescuentoLinea,\r\n                            d.descuentoLinea,\r\n                            d.subtotalLinea, \r\n                            d.totalLinea, \r\n                            d.tipoDescuento, \r\n                            d.listaPrecio, \r\n                            d.bodega, \r\n                            d.idDetalleGuia,                            \r\n                            d.idImpuesto, \r\n                            d.netoLinea,\r\n                            d.valorCompra,\r\n                            d.exento,                           \r\n                            i.imagenCodigo AS 'imagen1'\r\n                            FROM electronica_guia f INNER JOIN electronica_detalle_guia d\r\n                            ON f.idGuia = d.idGuiaLinea                            \r\n                            INNER JOIN zpdf417 i\r\n                            ON i.tipoDte=52 AND i.folio = f.folio                            \r\n                            WHERE f.folio=@folio ORDER BY d.idDetalleGuia";
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

    public DataTable guiaElectronicaInforme(string filtro)
    {
      string str = "SELECT\r\n                                        idGuia,\r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        fechaVencimiento,\r\n                                        idCliente,\r\n                                        rut,\r\n                                        digito,\r\n                                        razonSocial,\r\n                                        direccion,\r\n                                        comuna,\r\n                                        ciudad,\r\n                                        giro,\r\n                                        fono,\r\n                                        fax,\r\n                                        contacto,\r\n                                        diasPlazo,\r\n                                        idMedioPago,\r\n                                        medioPago,\r\n                                        idVendedor,\r\n                                        vendedor,\r\n                                        idCentroCosto,\r\n                                        centroCosto,\r\n                                        ordenCompra,\r\n                                        subtotal,\r\n                                        porcentajeDescuento,\r\n                                        descuento,\r\n                                        porcentajeIva,\r\n                                        iva,\r\n                                        neto,\r\n                                        total,\r\n                                        totalPalabras,\r\n                                        estadoPago,\r\n                                        estadoDocumento,\r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente,\r\n                                        impuesto1,\r\n                                        impuesto2,\r\n                                        impuesto3,\r\n                                        impuesto4,\r\n                                        impuesto5,\r\n                                        porcentajeImpuesto2,\r\n                                        porcentajeImpuesto1,\r\n                                        porcentajeImpuesto3,\r\n                                        porcentajeImpuesto4,\r\n                                        porcentajeImpuesto5,\r\n                                        comisionVendedor,\r\n                                        idTicket,\r\n                                        folioTicket,\r\n                                        folioGuias,\r\n                                        observaciones,\r\n                                        fechaModificacion,\r\n                                        idCotizacion,\r\n                                        folioCotizacion,\r\n                                        caja,\r\n                                        idNotaVenta,\r\n                                        folioNotaVenta                                        \r\n                                FROM\r\n                                electronica_guia\r\n                                WHERE " + filtro + " ORDER BY folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public void anulaGuia(int idGuia, List<DatosVentaVO> lista, List<LoteVO> listaLoteAntigua)
    {
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "GUIA ELECTRONICA");
          this.actualizaStock(datosVentaVo, "+");
          if (datosVentaVo.BodegaDestino > 0)
          {
            datosVentaVo.Bodega = datosVentaVo.BodegaDestino;
            datosVentaVo.StockQueda = datosVentaVo.StockQuedaDestino;
            new ControlProducto().registroDocumentoNuloNotaCredito(datosVentaVo, "GUIA ELECTRONICA TRASLADO");
            this.actualizaStock(datosVentaVo, "-");
          }
        }
      }
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_guia SET estadoDocumento = 'ANULADA' WHERE idGuia=@idGuia";
      command.Parameters.AddWithValue("@idGuia", (object) idGuia);
      ((DbCommand) command).ExecuteNonQuery();
      if (listaLoteAntigua.Count <= 0)
        return;
      foreach (LoteVO loteVo in listaLoteAntigua)
        new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
    }
  }
}
