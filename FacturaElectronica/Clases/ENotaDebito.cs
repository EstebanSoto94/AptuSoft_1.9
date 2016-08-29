 
// Type: Aptusoft.FacturaElectronica.Clases.ENotaDebito
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class ENotaDebito
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaNotaDebito(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO electronica_nota_debito (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total, totalExento,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            fechaModificacion,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            caja,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            folioOT,\r\n                                                            timbre,\r\n                                                            enviado_sii,\r\n                                                            tipoDocumento1,\r\n                                                            tipoDocumento2,\r\n                                                            tipoDocumento3,\r\n                                                            tipoDocumento4,\r\n                                                            tipoDocumento5,\r\n                                                            tipoDocumentoNombre1,\r\n                                                            tipoDocumentoNombre2,\r\n                                                            tipoDocumentoNombre3,\r\n                                                            tipoDocumentoNombre4,\r\n                                                            tipoDocumentoNombre5,\r\n                                                            folioDocumentoReferencia1,\r\n                                                            folioDocumentoReferencia2,\r\n                                                            folioDocumentoReferencia3,\r\n                                                            folioDocumentoReferencia4,\r\n                                                            folioDocumentoReferencia5,\r\n                                                            fechaDocumentoReferencia1,\r\n                                                            fechaDocumentoReferencia2,\r\n                                                            fechaDocumentoReferencia3,\r\n                                                            fechaDocumentoReferencia4,\r\n                                                            fechaDocumentoReferencia5,\r\n                                                            tipoAccion1,\r\n                                                            tipoAccion2,\r\n                                                            tipoAccion3,\r\n                                                            tipoAccion4,\r\n                                                            tipoAccion5,\r\n                                                            tipoAccionNombre1,\r\n                                                            tipoAccionNombre2,\r\n                                                            tipoAccionNombre3,\r\n                                                            tipoAccionNombre4,\r\n                                                            tipoAccionNombre5,\r\n                                                            razonReferencia1,\r\n                                                            razonReferencia2,\r\n                                                            razonReferencia3,\r\n                                                            razonReferencia4,\r\n                                                            razonReferencia5,\r\n                                                            codImpuesto1,\r\n                                                            codImpuesto2,\r\n                                                            codImpuesto3,\r\n                                                            codImpuesto4,\r\n                                                            codImpuesto5\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total, @totalExento,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @idTicket,\r\n                                                            @folioTicket,\r\n                                                            @folioGuias,\r\n                                                            @observaciones,\r\n                                                            @fechaModificacion,\r\n                                                            @idCotizacion,\r\n                                                            @folioCotizacion,\r\n                                                            @caja,\r\n                                                            @idNotaVenta,\r\n                                                            @folioNotaVenta,\r\n                                                            @folioOT, \r\n                                                            @timbre,\r\n                                                            @enviado_sii,\r\n                                                            @tipoDocumento1,\r\n                                                            @tipoDocumento2,\r\n                                                            @tipoDocumento3,\r\n                                                            @tipoDocumento4,\r\n                                                            @tipoDocumento5,\r\n                                                            @tipoDocumentoNombre1,\r\n                                                            @tipoDocumentoNombre2,\r\n                                                            @tipoDocumentoNombre3,\r\n                                                            @tipoDocumentoNombre4,\r\n                                                            @tipoDocumentoNombre5,\r\n                                                            @folioDocumentoReferencia1,\r\n                                                            @folioDocumentoReferencia2,\r\n                                                            @folioDocumentoReferencia3,\r\n                                                            @folioDocumentoReferencia4,\r\n                                                            @folioDocumentoReferencia5,\r\n                                                            @fechaDocumentoReferencia1,\r\n                                                            @fechaDocumentoReferencia2,\r\n                                                            @fechaDocumentoReferencia3,\r\n                                                            @fechaDocumentoReferencia4,\r\n                                                            @fechaDocumentoReferencia5,\r\n                                                            @tipoAccion1,\r\n                                                            @tipoAccion2,\r\n                                                            @tipoAccion3,\r\n                                                            @tipoAccion4,\r\n                                                            @tipoAccion5,\r\n                                                            @tipoAccionNombre1,\r\n                                                            @tipoAccionNombre2,\r\n                                                            @tipoAccionNombre3,\r\n                                                            @tipoAccionNombre4,\r\n                                                            @tipoAccionNombre5,\r\n                                                            @razonReferencia1,\r\n                                                            @razonReferencia2,\r\n                                                            @razonReferencia3,\r\n                                                            @razonReferencia4,\r\n                                                            @razonReferencia5,\r\n                                                            @codImpuesto1,\r\n                                                            @codImpuesto2,\r\n                                                            @codImpuesto3,\r\n                                                            @codImpuesto4,\r\n                                                            @codImpuesto5\r\n                                                   )";
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
        command.Parameters.AddWithValue("@enviado_sii", (veOB.FE_enviado_Sii ? 1 : 0));
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
        command.Parameters.AddWithValue("@codImpuesto1", (object) veOB.CodImpuesto1);
        command.Parameters.AddWithValue("@codImpuesto2", (object) veOB.CodImpuesto2);
        command.Parameters.AddWithValue("@codImpuesto3", (object) veOB.CodImpuesto3);
        command.Parameters.AddWithValue("@codImpuesto4", (object) veOB.CodImpuesto4);
        command.Parameters.AddWithValue("@codImpuesto5", (object) veOB.CodImpuesto5);
        ((DbCommand) command).ExecuteNonQuery();
        return "Factura Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleNotaDebito(List<DatosVentaVO> lista)
    {
      foreach (DatosVentaVO veVO in lista)
      {
        if (veVO.DescuentaInventario)
        {
          Decimal num = this.consultaStock(veVO);
          veVO.StockQueda = num - veVO.Cantidad;
          this.actualizaStock(veVO, "-");
        }
        this.agregaDetalleNotaDebito2(veVO);
      }
    }
    public string UltimoFolio()
    {
        string ultimo = "";
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand)command).CommandText = "select last_insert_id(folio) as last from electronica_nota_debito order by folio desc limit 1;";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader)mySqlDataReader).Read())
        {
            ultimo = ((DbDataReader)mySqlDataReader)["last"].ToString();
        }

        ((DbDataReader)mySqlDataReader).Close();
        return ultimo;
    }
    public bool agregaDetalleNotaDebito2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = this.RetornaIdNotaDebito(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO electronica_detalle_nota_debito (\r\n                                                            idNotaDebitoLinea,\r\n                                                            folioNotaDebito,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda, exento\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idFactuLinea,\r\n                                                            @folioFacturaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda, @exento\r\n                                                             )";
        command.Parameters.AddWithValue("@idFactuLinea", (object) num);
        command.Parameters.AddWithValue("@folioFacturaLinea", (object) veVO.FolioFactura);
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
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        string message = ex.Message;
        return false;
      }
    }

    public void agregaReferencia(List<ReferenicaVO> listaReferencia)
    {
      int num = this.RetornaIdNotaDebito(listaReferencia[0].FolioDocumento);
      foreach (ReferenicaVO refe in listaReferencia)
      {
        refe.idDocumento = num;
        this.agregaReferencia2(refe);
      }
    }

    private void agregaReferencia2(ReferenicaVO refe)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO electronica_nota_debito_referencias (\r\n                                                            idNotaDebito,\r\n                                                            folioNotaDebito,\r\n                                                            tipoDocumento,\r\n                                                            tipoDocumentoNombre,\r\n                                                            folioDocumentoReferencia,\r\n                                                            fechaDocumentoReferencia,\r\n                                                            tipoAccion,\r\n                                                            tipoAccionNombre,\r\n                                                            razonReferencia\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idNotaDebito,\r\n                                                            @folioNotaDebito,\r\n                                                            @tipoDocumento,\r\n                                                            @tipoDocumentoNombre,\r\n                                                            @folioDocumentoReferencia,\r\n                                                            @fechaDocumentoReferencia,\r\n                                                            @tipoAccion,\r\n                                                            @tipoAccionNombre,\r\n                                                            @razonReferencia\r\n                                                             )";
      command.Parameters.AddWithValue("@idNotaDebito", (object) refe.idDocumento);
      command.Parameters.AddWithValue("@folioNotaDebito", (object) refe.FolioDocumento);
      command.Parameters.AddWithValue("@tipoDocumento", (object) refe.TipoDocumento);
      command.Parameters.AddWithValue("@tipoDocumentoNombre", (object) refe.TipoDocumentoNombre);
      command.Parameters.AddWithValue("@folioDocumentoReferencia", (object) refe.FolioDocumentoReferencia);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia", (object) refe.FechaDocumentoReferencia);
      command.Parameters.AddWithValue("@tipoAccion", (object) refe.TipoAccion);
      command.Parameters.AddWithValue("@tipoAccionNombre", (object) refe.TipoAccionNombre);
      command.Parameters.AddWithValue("@razonReferencia", (object) refe.RazonReferencia);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<ReferenicaVO> buscaReferenciaIDNotaDebito(int idFactura)
    {
      List<ReferenicaVO> list = new List<ReferenicaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idReferencia, idNotaDebito,\r\n                                                            folioNotaDebito,\r\n                                                            tipoDocumento,\r\n                                                            tipoDocumentoNombre,\r\n                                                            folioDocumentoReferencia,\r\n                                                            fechaDocumentoReferencia,\r\n                                                            tipoAccion,\r\n                                                            tipoAccionNombre,\r\n                                                            razonReferencia\r\n                                                    FROM electronica_nota_debito_referencias WHERE idNotaDebito = @idNotaDebito ORDER BY idReferencia asc";
      command.Parameters.AddWithValue("@idNotaDebito", (object) idFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ReferenicaVO()
        {
          IdReferencia = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idReferencia"].ToString()),
          idDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaDebito"].ToString()),
          FolioDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaDebito"].ToString()),
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

    public bool NotaDebitoExiste(int numFactura)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM electronica_nota_debito WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
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

    public int RetornaIdNotaDebito(int numFactura)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idNotaDebito, folio FROM electronica_nota_debito WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaNotaDebitoFolio(int numFactura)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idNotaDebito,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total, totalExento,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            folioOT,\r\n                                                            timbre,\r\n                                                            enviado_sii,\r\n                                                            enviado_libro,\r\n                                                            codImpuesto1,\r\n                                                            codImpuesto2,\r\n                                                            codImpuesto3,\r\n                                                            codImpuesto4,\r\n                                                            codImpuesto5   \r\n                                                FROM electronica_nota_debito WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaDebito"]);
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
        venta.CodImpuesto1 = ((DbDataReader) mySqlDataReader)["codImpuesto1"].ToString();
        venta.CodImpuesto2 = ((DbDataReader) mySqlDataReader)["codImpuesto2"].ToString();
        venta.CodImpuesto3 = ((DbDataReader) mySqlDataReader)["codImpuesto3"].ToString();
        venta.CodImpuesto4 = ((DbDataReader) mySqlDataReader)["codImpuesto4"].ToString();
        venta.CodImpuesto5 = ((DbDataReader) mySqlDataReader)["codImpuesto5"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<DatosVentaVO> buscaDetalleNotaDebitoIDNotaDebito(int idFactura)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleNotaDebito, \r\n                                                    idNotaDebitoLinea,\r\n                                                    folioNotaDebito,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    descuentaInventario,\r\n                                                    valorCompra,stockQueda, exento\r\n                                                    FROM electronica_detalle_nota_debito WHERE idNotaDebitoLinea = @idFactura ORDER BY idDetalleNotaDebito asc";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleNotaDebito"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaDebitoLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaDebito"]),
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
          Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
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

    public int numeroNotaDebito(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand)command).CommandText = "SELECT MAX(folio)+1 FROM electronica_nota_debito";// WHERE caja=@caja";
     // command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public string modificaNotaDebito(Venta veOB, List<DatosVentaVO> listaNueva)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE electronica_nota_debito SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalExento=@totalExento,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor,\r\n                                                            folioGuias=@folioGuias,\r\n                                                            observaciones=@observaciones,\r\n                                                            fechaModificacion=@fechaModificacion,\r\n                                                            tipoDocumento1=@tipoDocumento1,\r\n                                                            tipoDocumento2=@tipoDocumento2,\r\n                                                            tipoDocumento3=@tipoDocumento3,\r\n                                                            tipoDocumento4=@tipoDocumento4,\r\n                                                            tipoDocumento5=@tipoDocumento5,\r\n                                                            tipoDocumentoNombre1=@tipoDocumentoNombre1,\r\n                                                            tipoDocumentoNombre2=@tipoDocumentoNombre2,\r\n                                                            tipoDocumentoNombre3=@tipoDocumentoNombre3,\r\n                                                            tipoDocumentoNombre4=@tipoDocumentoNombre4,\r\n                                                            tipoDocumentoNombre5=@tipoDocumentoNombre5,\r\n                                                            folioDocumentoReferencia1=@folioDocumentoReferencia1,\r\n                                                            folioDocumentoReferencia2=@folioDocumentoReferencia2,\r\n                                                            folioDocumentoReferencia3=@folioDocumentoReferencia3,\r\n                                                            folioDocumentoReferencia4=@folioDocumentoReferencia4,\r\n                                                            folioDocumentoReferencia5=@folioDocumentoReferencia5,\r\n                                                            fechaDocumentoReferencia1=@fechaDocumentoReferencia1,\r\n                                                            fechaDocumentoReferencia2=@fechaDocumentoReferencia2,\r\n                                                            fechaDocumentoReferencia3=@fechaDocumentoReferencia3,\r\n                                                            fechaDocumentoReferencia4=@fechaDocumentoReferencia4,\r\n                                                            fechaDocumentoReferencia5=@fechaDocumentoReferencia5,\r\n                                                            tipoAccion1=@tipoAccion1,\r\n                                                            tipoAccion2=@tipoAccion2,\r\n                                                            tipoAccion3=@tipoAccion3,\r\n                                                            tipoAccion4=@tipoAccion4,\r\n                                                            tipoAccion5=@tipoAccion5,\r\n                                                            tipoAccionNombre1=@tipoAccionNombre1,\r\n                                                            tipoAccionNombre2=@tipoAccionNombre2,\r\n                                                            tipoAccionNombre3=@tipoAccionNombre3,\r\n                                                            tipoAccionNombre4=@tipoAccionNombre4,\r\n                                                            tipoAccionNombre5=@tipoAccionNombre5,\r\n                                                            razonReferencia1=@razonReferencia1,\r\n                                                            razonReferencia2=@razonReferencia2,\r\n                                                            razonReferencia3=@razonReferencia3,\r\n                                                            razonReferencia4=@razonReferencia4,\r\n                                                            razonReferencia5=@razonReferencia5,\r\n                                                            codImpuesto1=@codImpuesto1,\r\n                                                            codImpuesto2=@codImpuesto2,\r\n                                                            codImpuesto3=@codImpuesto3,\r\n                                                            codImpuesto4=@codImpuesto4,\r\n                                                            codImpuesto5=@codImpuesto5                                                  \r\n\r\n                                           WHERE idNotaDebito=@idFactura AND folio=@folio";
        command.Parameters.AddWithValue("@idFactura", (object) veOB.IdFactura);
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
        command.Parameters.AddWithValue("@codImpuesto1", (object) veOB.CodImpuesto1);
        command.Parameters.AddWithValue("@codImpuesto2", (object) veOB.CodImpuesto2);
        command.Parameters.AddWithValue("@codImpuesto3", (object) veOB.CodImpuesto3);
        command.Parameters.AddWithValue("@codImpuesto4", (object) veOB.CodImpuesto4);
        command.Parameters.AddWithValue("@codImpuesto5", (object) veOB.CodImpuesto5);
        ((DbCommand) command).ExecuteNonQuery();
        foreach (DatosVentaVO datosVentaVo in this.buscaDetalleNotaDebitoIDNotaDebito(veOB.IdFactura))
        {
          new ControlProducto().registroDocumentoModifica(datosVentaVo, "NOTA DEBITO ELECTRONICA");
          new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "NOTA DEBITO ELECTRONICA");
          this.actualizaStock(datosVentaVo, "+");
        }
        this.eliminaDetalleNotaDebito(veOB);
        foreach (DatosVentaVO veVO in listaNueva)
        {
          Decimal num = this.consultaStock(veVO);
          veVO.StockQueda = num - veVO.Cantidad;
          this.agregaDetalleNotaDebito2(veVO);
          this.actualizaStock(veVO, "-");
        }
        return "Nota de Debito Electronica Modificada";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool eliminaDetalleNotaDebito(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM electronica_detalle_nota_debito WHERE idNotaDebitoLinea=@idFactura AND folioNotaDebito=@folioFactura";
        command.Parameters.AddWithValue("@idFactura", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioFactura", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public int eliminaNotaDebito(int idFactura, List<DatosVentaVO> lista)
    {
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "NOTA DEBITO ELECTRONICA");
          this.actualizaStock(datosVentaVo, "+");
        }
      }
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE electronica_nota_debito, electronica_detalle_nota_debito FROM electronica_nota_debito, electronica_detalle_nota_debito WHERE electronica_nota_debito.idNotaDebito = @idFactura AND electronica_detalle_nota_debito.idNotaDebitoLinea=@idFactura";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      return ((DbCommand) command).ExecuteNonQuery();
    }

    public string anulaNotaDebito(int idFactura, List<DatosVentaVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_nota_debito SET estadoDocumento = 'ANULADA', razonSocial= 'FACTURA ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0'  WHERE idNotaDebito=@idFactura";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "FACTURA");
          this.actualizaStock(datosVentaVo, "+");
        }
      }
      return "Factura Anulada!!";
    }

    private void registroNotaDebitoNula(DatosVentaVO vevo)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ANULA FACTURA ELECTRONICA FOLIO: " + (object) vevo.FolioFactura;
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = vevo.Cantidad + num;
      controlProducto.agregaControlProducto(cp);
    }

    public DataTable muestraNotaDebitoFolio(int folio)
    {
      string str = "SELECT \r\n                            f.idNotaDebito,\r\n                            f.folio,\r\n                            f.fechaEmision,\r\n                            f.fechaVencimiento,\r\n                            f.dia,\r\n                            f.mes,\r\n                            f.ano,\r\n                            f.idCliente, \r\n                            f.rut, \r\n                            f.digito, \r\n                            f.razonSocial,\r\n                            f.direccion, \r\n                            f.comuna, \r\n                            f.ciudad, \r\n                            f.giro, \r\n                            f.fono, \r\n                            f.fax, \r\n                            f.contacto, \r\n                            f.diasPlazo, \r\n                            f.idMedioPago,                          \r\n                            f.medioPago, \r\n                            f.idVendedor, \r\n                            f.vendedor, \r\n                            f.idCentroCosto, \r\n                            f.centroCosto, \r\n                            f.ordenCompra, \r\n                            f.subtotal, \r\n                            f.porcentajeDescuento,\r\n                            f.descuento, \r\n                            f.porcentajeIva, \r\n                            f.iva,\r\n                            f.neto, \r\n                            f.total, \r\n                            f.totalExento,\r\n                            f.totalPalabras, \r\n                            f.estadoPago, \r\n                            f.estadoDocumento, \r\n                            f.totalPagado,\r\n                            f.totalDocumentado,\r\n                            f.totalPendiente,\r\n                            f.impuesto1,\r\n                            f.impuesto2,\r\n                            f.impuesto3,\r\n                            f.impuesto4,\r\n                            f.impuesto5,\r\n                            f.porcentajeImpuesto1,\r\n                            f.porcentajeImpuesto2,\r\n                            f.porcentajeImpuesto3,\r\n                            f.porcentajeImpuesto4,\r\n                            f.porcentajeImpuesto5,\r\n                            f.comisionVendedor,\r\n                            f.idTicket,\r\n                            f.folioTicket,\r\n                            f.folioGuias,\r\n                            f.observaciones,\r\n                            f.fechaModificacion,\r\n                            f.idCotizacion,\r\n                            f.folioCotizacion,\r\n                            f.caja,\r\n                            f.idNotaVenta,\r\n                            f.folioNotaVenta,\r\n                            f.tipoDocumento1,\r\n                            f.tipoDocumento2,\r\n                            f.tipoDocumento3,\r\n                            f.tipoDocumento4,\r\n                            f.tipoDocumento5,\r\n                            f.tipoDocumentoNombre1,\r\n                            f.tipoDocumentoNombre2,\r\n                            f.tipoDocumentoNombre3,\r\n                            f.tipoDocumentoNombre4,\r\n                            f.tipoDocumentoNombre5,\r\n                            f.folioDocumentoReferencia1,\r\n                            f.folioDocumentoReferencia2,\r\n                            f.folioDocumentoReferencia3,\r\n                            f.folioDocumentoReferencia4,\r\n                            f.folioDocumentoReferencia5,\r\n                            f.fechaDocumentoReferencia1,\r\n                            f.fechaDocumentoReferencia2,\r\n                            f.fechaDocumentoReferencia3,\r\n                            f.fechaDocumentoReferencia4,\r\n                            f.fechaDocumentoReferencia5,\r\n                            f.tipoAccion1,\r\n                            f.tipoAccion2,\r\n                            f.tipoAccion3,\r\n                            f.tipoAccion4,\r\n                            f.tipoAccion5,\r\n                            f.tipoAccionNombre1,\r\n                            f.tipoAccionNombre2,\r\n                            f.tipoAccionNombre3,\r\n                            f.tipoAccionNombre4,\r\n                            f.tipoAccionNombre5,\r\n                            f.razonReferencia1,\r\n                            f.razonReferencia2,\r\n                            f.razonReferencia3,\r\n                            f.razonReferencia4,\r\n                            f.razonReferencia5,\r\n                            d.idNotaDebitoLinea,\r\n                            d.folioNotaDebito,\r\n                            d.fechaIngreso,\r\n                            d.codigo,\r\n                            d.descripcion,\r\n                            d.valorVenta,\r\n                            d.cantidad,\r\n                            d.porcentajeDescuentoLinea,\r\n                            d.descuentoLinea,\r\n                            d.subtotalLinea, \r\n                            d.totalLinea, \r\n                            d.tipoDescuento, \r\n                            d.listaPrecio, \r\n                            d.bodega, \r\n                            d.idDetalleNotaDebito,                            \r\n                            d.idImpuesto, \r\n                            d.netoLinea,\r\n                            d.valorCompra,\r\n                            d.exento,\r\n                            i.imagenCodigo AS 'imagen1'\r\n                            FROM electronica_nota_debito f INNER JOIN electronica_detalle_nota_debito d\r\n                            ON f.idNotaDebito = d.idNotaDebitoLinea\r\n                            INNER JOIN zpdf417 i\r\n                            ON i.tipoDte=56 AND i.folio = f.folio\r\n                            WHERE f.folio=@folio ORDER BY d.idDetalleNotaDebito";
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

    public DataTable notaDebitoElectronicaInforme(string filtro)
    {
      string str = "SELECT\r\n                                        idNotaDebito,\r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        fechaVencimiento,\r\n                                        idCliente,\r\n                                        rut,\r\n                                        digito,\r\n                                        razonSocial,\r\n                                        direccion,\r\n                                        comuna,\r\n                                        ciudad,\r\n                                        giro,\r\n                                        fono,\r\n                                        fax,\r\n                                        contacto,\r\n                                        diasPlazo,\r\n                                        idMedioPago,\r\n                                        medioPago,\r\n                                        idVendedor,\r\n                                        vendedor,\r\n                                        idCentroCosto,\r\n                                        centroCosto,\r\n                                        ordenCompra,\r\n                                        subtotal,\r\n                                        porcentajeDescuento,\r\n                                        descuento,\r\n                                        porcentajeIva,\r\n                                        iva,\r\n                                        neto,\r\n                                        total,\r\n                                        totalPalabras,\r\n                                        estadoPago,\r\n                                        estadoDocumento,\r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente,\r\n                                        impuesto1,\r\n                                        impuesto2,\r\n                                        impuesto3,\r\n                                        impuesto4,\r\n                                        impuesto5,\r\n                                        porcentajeImpuesto2,\r\n                                        porcentajeImpuesto1,\r\n                                        porcentajeImpuesto3,\r\n                                        porcentajeImpuesto4,\r\n                                        porcentajeImpuesto5,\r\n                                        comisionVendedor,\r\n                                        idTicket,\r\n                                        folioTicket,\r\n                                        folioGuias,\r\n                                        observaciones,\r\n                                        fechaModificacion,\r\n                                        idCotizacion,\r\n                                        folioCotizacion,\r\n                                        caja,\r\n                                        idNotaVenta,\r\n                                        folioNotaVenta                                        \r\n                                FROM\r\n                                electronica_nota_debito\r\n                                WHERE " + filtro + " ORDER BY folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
