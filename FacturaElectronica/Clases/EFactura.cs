 
// Type: Aptusoft.FacturaElectronica.Clases.EFactura
 
 
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
  public class EFactura
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaFactura(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO electronica_factura (                         folio,                         fechaEmision,                         fechaVencimiento,                         dia,                         mes,                         ano,                         idCliente,                         rut,                         digito,                         razonSocial,                         direccion,                         comuna,                         ciudad,                         giro,                         fono,                         fax,                          contacto,                         diasPlazo,                         idMedioPago,                         medioPago,                         idVendedor,                         vendedor,                         idCentroCosto,                         centroCosto,                         ordenCompra,                         subtotal,                         porcentajeDescuento,                          descuento,                         porcentajeIva,                         iva,                         neto,                         total,totalExento,                         totalPalabras,                         estadoPago,                         estadoDocumento,                         totalPagado,                         totalDocumentado,                         totalPendiente,                         impuesto1,                         impuesto2,                         impuesto3,                         impuesto4,                         impuesto5,                         porcentajeImpuesto1,                         porcentajeImpuesto2,                         porcentajeImpuesto3,                         porcentajeImpuesto4,                         porcentajeImpuesto5,                         comisionVendedor,                         idTicket,                         folioTicket,                         folioGuias,                         observaciones,                         fechaModificacion,                         idCotizacion,                         folioCotizacion,                         caja,                         idNotaVenta,                         folioNotaVenta,                         folioOT,                         timbre,                         enviado_sii,                         tipoDocumento1,                         tipoDocumento2,                         tipoDocumento3,                         tipoDocumento4,                         tipoDocumento5,                         tipoDocumentoNombre1,                         tipoDocumentoNombre2,                         tipoDocumentoNombre3,                         tipoDocumentoNombre4,                         tipoDocumentoNombre5,                         folioDocumentoReferencia1,                         folioDocumentoReferencia2,                         folioDocumentoReferencia3,                         folioDocumentoReferencia4,                         folioDocumentoReferencia5,                         fechaDocumentoReferencia1,                         fechaDocumentoReferencia2,                         fechaDocumentoReferencia3,                         fechaDocumentoReferencia4,                         fechaDocumentoReferencia5,                         tipoAccion1,                         tipoAccion2,                         tipoAccion3,                         tipoAccion4,                         tipoAccion5,                         tipoAccionNombre1,                         tipoAccionNombre2,                         tipoAccionNombre3,                         tipoAccionNombre4,                         tipoAccionNombre5,                         razonReferencia1,                         razonReferencia2,                         razonReferencia3,                         razonReferencia4,                         razonReferencia5,                         codImpuesto1,                         codImpuesto2,                         codImpuesto3,                         codImpuesto4,                         codImpuesto5                         )                 VALUES(                                                                                     @folio,                         @fechaEmision,                         @fechaVencimiento,                         @dia,                         @mes,                         @ano,                         @idCliente,                         @rut,                         @digito,                         @razonSocial,                         @direccion,                         @comuna,                         @ciudad,                         @giro,                         @fono,                         @fax,                          @contacto,                         @diasPlazo,                         @idMedioPago,                         @medioPago,                         @idVendedor,                         @vendedor,                         @idCentroCosto,                         @centroCosto,                         @ordenCompra,                         @subtotal,                         @porcentajeDescuento,                          @descuento,                         @porcentajeIva,                         @iva,                         @neto,                         @total, @totalExento,                         @totalPalabras,                         @estadoPago,                         @estadoDocumento,                         @totalPagado,                         @totalDocumentado,                         @totalPendiente,                         @impuesto1,                         @impuesto2,                         @impuesto3,                         @impuesto4,                         @impuesto5,                         @porcentajeImpuesto1,                         @porcentajeImpuesto2,                         @porcentajeImpuesto3,                         @porcentajeImpuesto4,                         @porcentajeImpuesto5,                         @comisionVendedor,                         @idTicket,                         @folioTicket,                         @folioGuias,                         @observaciones,                         @fechaModificacion,                         @idCotizacion,                         @folioCotizacion,                         @caja,                         @idNotaVenta,                         @folioNotaVenta,                         @folioOT,                          @timbre,                         @enviado_sii,                         @tipoDocumento1,                         @tipoDocumento2,                         @tipoDocumento3,                         @tipoDocumento4,                         @tipoDocumento5,                         @tipoDocumentoNombre1,                         @tipoDocumentoNombre2,                         @tipoDocumentoNombre3,                         @tipoDocumentoNombre4,                         @tipoDocumentoNombre5,                         @folioDocumentoReferencia1,                         @folioDocumentoReferencia2,                         @folioDocumentoReferencia3,                         @folioDocumentoReferencia4,                         @folioDocumentoReferencia5,                         @fechaDocumentoReferencia1,                         @fechaDocumentoReferencia2,                         @fechaDocumentoReferencia3,                         @fechaDocumentoReferencia4,                         @fechaDocumentoReferencia5,                         @tipoAccion1,                         @tipoAccion2,                         @tipoAccion3,                         @tipoAccion4,                         @tipoAccion5,                         @tipoAccionNombre1,                         @tipoAccionNombre2,                         @tipoAccionNombre3,                         @tipoAccionNombre4,                         @tipoAccionNombre5,                         @razonReferencia1,                         @razonReferencia2,                         @razonReferencia3,                         @razonReferencia4,                         @razonReferencia5,                         @codImpuesto1,                         @codImpuesto2,                         @codImpuesto3,                         @codImpuesto4,                         @codImpuesto5                )";
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
        if (conexion.ConexionMySql.State != ConnectionState.Open)
        {
            int con = 0;
            do
            {
                con++;
                try
                {
                    conexion.ConexionMySql.Open();
                    ((DbCommand)command).ExecuteNonQuery();
                    return "Factura Ingresada";
                }
                catch { conexion.ConexionMySql.Close(); }
            } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
        }
        else
        {
            ((DbCommand)command).ExecuteNonQuery();
            
        }
        return "Factura Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleFactura(List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      int num1 = 0;
      long num2 = 0L;
      foreach (DatosVentaVO veVO in lista)
      {
        if (num1 == 0)
        {
          num1 = this.RetornaIdFactura(veVO.FolioFactura);
          num2 = (long) veVO.FolioFactura;
        }
        veVO.IdFactura = num1;
        if (veVO.DescuentaInventario)
        {
          Decimal num3 = this.consultaStock(veVO);
          veVO.StockQueda = num3 - veVO.Cantidad;
          this.actualizaStock(veVO, "-");
        }
        this.agregaDetalleFactura2(veVO);
      }
      if (listaLote.Count <= 0)
        return;
      string str = "FACTURA ELECTRONICA";
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

    public bool agregaDetalleFactura2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura;
      if (num == 0)
        num = this.RetornaIdFactura(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO electronica_detalle_factura (                         idFacturaLinea,                         folioFactura,                         fechaIngreso,                         codigo,                         descripcion,                         valorVenta,                         cantidad,                         porcentajeDescuentoLinea,                         descuentoLinea,                         subtotalLinea,                         totalLinea,                         tipoDescuento,                         listaPrecio,                         bodega,                         idImpuesto,                         netoLinea,                         descuentaInventario,                         valorCompra,                         usuario,                         stockQueda, exento                          )                    VALUES(                         @idFactuLinea,                         @folioFacturaLinea,                         @fechaIngreso,                         @codigo,                         @descripcion,                         @valorVenta,                         @cantidad,                         @porcentajeDescuentoLinea,                         @descuentoLinea,                         @subtotalLinea,                         @totalLinea,                         @tipoDescuento,                         @listaPrecio,                         @bodega,                         @idImpuesto,                         @netoLinea,                         @descuentaInventario,                         @valorCompra,                         @usuario,                         @stockQueda, @exento                          )";
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
        if (conexion.ConexionMySql.State != ConnectionState.Open)
        {
            int con = 0;
            do
            {
                con++;
                try
                {
                    conexion.ConexionMySql.Open();
                    ((DbCommand)command).ExecuteNonQuery();
                }
                catch { conexion.ConexionMySql.Close(); }
            } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
        }
        else
        {
            ((DbCommand)command).ExecuteNonQuery();

        }
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
      int num = this.RetornaIdFactura(listaReferencia[0].FolioDocumento);
      foreach (ReferenicaVO refe in listaReferencia)
      {
        refe.idDocumento = num;
        this.agregaReferencia2(refe);
      }
    }

    private void agregaReferencia2(ReferenicaVO refe)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO electronica_factura_referencias (idFactura,folioFactura,tipoDocumento,tipoDocumentoNombre,folioDocumentoReferencia,fechaDocumentoReferencia,tipoAccion,tipoAccionNombre,razonReferencia, indGlobal) VALUES(@idFactura,@folioFactura,@tipoDocumento,@tipoDocumentoNombre,@folioDocumentoReferencia,@fechaDocumentoReferencia,@tipoAccion,          @tipoAccionNombre,@razonReferencia, @indGlobal)";
      command.Parameters.AddWithValue("@idFactura", (object) refe.idDocumento);
      command.Parameters.AddWithValue("@folioFactura", (object) refe.FolioDocumento);
      command.Parameters.AddWithValue("@tipoDocumento", (object) refe.TipoDocumento);
      command.Parameters.AddWithValue("@tipoDocumentoNombre", (object) refe.TipoDocumentoNombre);
      command.Parameters.AddWithValue("@folioDocumentoReferencia", refe.FolioDocumentoReferencia);
      command.Parameters.AddWithValue("@fechaDocumentoReferencia", (object) refe.FechaDocumentoReferencia);
      command.Parameters.AddWithValue("@tipoAccion", (object) refe.TipoAccion);
      command.Parameters.AddWithValue("@tipoAccionNombre", (object) refe.TipoAccionNombre);
      command.Parameters.AddWithValue("@razonReferencia", (object) refe.RazonReferencia);
      command.Parameters.AddWithValue("@indGlobal", Convert.ToInt32(( refe.IndGlobal.ToString().Length > 0 ? refe.IndGlobal.ToString() : "0" )));
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
                  ((DbCommand)command).ExecuteNonQuery();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();

      }
    }

    public List<ReferenicaVO> buscaReferenciaIDFactura(int idFactura)
    {
      List<ReferenicaVO> list = new List<ReferenicaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idReferencia, idFactura, folioFactura, tipoDocumento, tipoDocumentoNombre, folioDocumentoReferencia, fechaDocumentoReferencia, tipoAccion, tipoAccionNombre, razonReferencia, indGlobal FROM electronica_factura_referencias WHERE idFactura = @idFactura ORDER BY idReferencia asc";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
                  MySqlDataReader mySqlDataReader = command.ExecuteReader();
                  while (((DbDataReader)mySqlDataReader).Read())
                      list.Add(new ReferenicaVO()
                      {
                          IdReferencia = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idReferencia"].ToString()),
                          idDocumento = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idFactura"].ToString()),
                          FolioDocumento = Convert.ToInt32(((DbDataReader)mySqlDataReader)["folioFactura"].ToString()),
                          TipoDocumento = Convert.ToInt32(((DbDataReader)mySqlDataReader)["tipoDocumento"].ToString()),
                          TipoDocumentoNombre = ((DbDataReader)mySqlDataReader)["tipoDocumentoNombre"].ToString(),
                          FolioDocumentoReferencia = ((DbDataReader)mySqlDataReader)["folioDocumentoReferencia"].ToString(),
                          FechaDocumentoReferencia = Convert.ToDateTime(((DbDataReader)mySqlDataReader)["fechaDocumentoReferencia"]),
                          TipoAccion = Convert.ToInt32(((DbDataReader)mySqlDataReader)["tipoAccion"].ToString()),
                          TipoAccionNombre = ((DbDataReader)mySqlDataReader)["tipoAccionNombre"].ToString(),
                          RazonReferencia = ((DbDataReader)mySqlDataReader)["razonReferencia"].ToString(),
/*indGlobal*/             IndGlobal = Convert.ToInt32(((DbDataReader)mySqlDataReader)["indGlobal"].ToString())
                      });
                  ((DbDataReader)mySqlDataReader).Close();
                  return list;
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          MySqlDataReader mySqlDataReader = command.ExecuteReader();
          while (((DbDataReader)mySqlDataReader).Read())
              list.Add(new ReferenicaVO()
              {
                  IdReferencia = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idReferencia"].ToString()),
                  idDocumento = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idFactura"].ToString()),
                  FolioDocumento = Convert.ToInt32(((DbDataReader)mySqlDataReader)["folioFactura"].ToString()),
                  TipoDocumento = Convert.ToInt32(((DbDataReader)mySqlDataReader)["tipoDocumento"].ToString()),
                  TipoDocumentoNombre = ((DbDataReader)mySqlDataReader)["tipoDocumentoNombre"].ToString(),
                  FolioDocumentoReferencia = ((DbDataReader)mySqlDataReader)["folioDocumentoReferencia"].ToString(),
                  FechaDocumentoReferencia = Convert.ToDateTime(((DbDataReader)mySqlDataReader)["fechaDocumentoReferencia"]),
                  TipoAccion = Convert.ToInt32(((DbDataReader)mySqlDataReader)["tipoAccion"].ToString()),
                  TipoAccionNombre = ((DbDataReader)mySqlDataReader)["tipoAccionNombre"].ToString(),
                  RazonReferencia = ((DbDataReader)mySqlDataReader)["razonReferencia"].ToString(),
/*indGlobal*/     IndGlobal = Convert.ToInt32(((DbDataReader)mySqlDataReader)["indGlobal"].ToString())
              });
          ((DbDataReader)mySqlDataReader).Close();
          return list;
      }
      return list;
      
    }

    public bool facturaExiste(int numFactura)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM electronica_factura WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
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
        ((DbCommand)command).CommandText = "select last_insert_id(folio) as last from electronica_factura order by folio desc limit 1;";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader)mySqlDataReader).Read())
        {
            ultimo = ((DbDataReader)mySqlDataReader)["last"].ToString();
        }
            
        ((DbDataReader)mySqlDataReader).Close();
        return ultimo;
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

    public int RetornaIdFactura(int numFactura)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idfactura, folio FROM electronica_factura WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaFacturaFolio(int numFactura)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idFactura, folio, fechaEmision, fechaVencimiento,                         idCliente,                         rut,                         digito,                         razonSocial,                         direccion,                         comuna,                         ciudad,                         giro,                         fono,                         fax,                          contacto,                         diasPlazo,                         idMedioPago,                         medioPago,                         idVendedor,                         vendedor,                         idCentroCosto,                         centroCosto,                         ordenCompra,                         subtotal,                         porcentajeDescuento,                          descuento,                         porcentajeIva,                         iva,                         neto,                         total, totalExento,                         totalPalabras,                         estadoPago,                         estadoDocumento,                         totalPagado,                         totalDocumentado,                         totalPendiente,                         impuesto1,                         impuesto2,                         impuesto3,                         impuesto4,                         impuesto5,                         porcentajeImpuesto1,                         porcentajeImpuesto2,                         porcentajeImpuesto3,                         porcentajeImpuesto4,                         porcentajeImpuesto5,                         idTicket,                         folioTicket,                         folioGuias,                         observaciones,                         idCotizacion,                         folioCotizacion,                         idNotaVenta,                         folioNotaVenta,                         folioOT,                          folioNotaVentaMasiva,                         timbre,                         enviado_sii,                         enviado_libro,                         codImpuesto1,                         codImpuesto2,                         codImpuesto3,                         codImpuesto4,                         codImpuesto5                  FROM electronica_factura WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFactura"]);
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
        venta.FolioNotaVentaMasivas = ((DbDataReader) mySqlDataReader)["folioNotaVentaMasiva"].ToString();
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

    public List<DatosVentaVO> buscaDetalleFacturaIDFactura(int idFactura)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleFactura,                  idFacturaLinea,                 folioFactura,                 fechaIngreso,                 codigo,                 descripcion,                 valorVenta,                 cantidad,                 porcentajeDescuentoLinea,                 descuentoLinea,                 subtotalLinea,                 totalLinea,                 tipoDescuento,                 listaPrecio,                 bodega,                 idImpuesto,                 netoLinea,                 descuentaInventario,                 valorCompra,stockQueda, exento                 FROM electronica_detalle_factura WHERE idFacturaLinea = @idFactura ORDER BY idDetalleFactura asc";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleFactura"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFacturaLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioFactura"]),
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
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
                  ((DbCommand)command).ExecuteNonQuery();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();

      }
    }

    public int numeroFactura(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM electronica_factura;";
      //      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM electronica_factura WHERE caja=@caja";
      //command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public string modificaFactura(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE electronica_factura SET fechaEmision=@fechaEmision,                         fechaVencimiento=@fechaVencimiento,                         dia=@dia,                         mes=@mes,                         ano=@ano,                                                                                     idCliente=@idCliente,                         rut=@rut,                         digito=@digito,                         razonSocial=@razonSocial,                         direccion=@direccion,                         comuna=@comuna,                         ciudad=@ciudad,                         giro=@giro,                         fono=@fono,                         fax=@fax,                          contacto=@contacto,                         diasPlazo=@diasPlazo,                         idMedioPago=@idMedioPago,                         medioPago=@medioPago,                         idVendedor=@idVendedor,                         vendedor=@vendedor,                         idCentroCosto=@idCentroCosto,                         centroCosto=@centroCosto,                         ordenCompra=@ordenCompra,                         subtotal=@subtotal,                         porcentajeDescuento=@porcentajeDescuento,                          descuento=@descuento,                         porcentajeIva=@porcentajeIva,                         iva=@iva,                         neto=@neto,                         total=@total,                         totalExento=@totalExento,                         totalPalabras=@totalPalabras,                         estadoPago=@estadoPago,                                                                                     totalPagado=@totalPagado,                         totalDocumentado=@totalDocumentado,                         totalPendiente=@totalPendiente,                         impuesto1=@impuesto1,                         impuesto2=@impuesto2,                         impuesto3=@impuesto3,                         impuesto4=@impuesto4,                         impuesto5=@impuesto5,                         porcentajeImpuesto1=@porcentajeImpuesto1,                         porcentajeImpuesto2=@porcentajeImpuesto2,                         porcentajeImpuesto3=@porcentajeImpuesto3,                         porcentajeImpuesto4=@porcentajeImpuesto4,                         porcentajeImpuesto5=@porcentajeImpuesto5,                         comisionVendedor=@comisionVendedor,                         folioGuias=@folioGuias,                         observaciones=@observaciones,                         fechaModificacion=@fechaModificacion,                         tipoDocumento1=@tipoDocumento1,                         tipoDocumento2=@tipoDocumento2,                         tipoDocumento3=@tipoDocumento3,                         tipoDocumento4=@tipoDocumento4,                         tipoDocumento5=@tipoDocumento5,                         tipoDocumentoNombre1=@tipoDocumentoNombre1,                         tipoDocumentoNombre2=@tipoDocumentoNombre2,                         tipoDocumentoNombre3=@tipoDocumentoNombre3,                         tipoDocumentoNombre4=@tipoDocumentoNombre4,                         tipoDocumentoNombre5=@tipoDocumentoNombre5,                         folioDocumentoReferencia1=@folioDocumentoReferencia1,                         folioDocumentoReferencia2=@folioDocumentoReferencia2,                         folioDocumentoReferencia3=@folioDocumentoReferencia3,                         folioDocumentoReferencia4=@folioDocumentoReferencia4,                         folioDocumentoReferencia5=@folioDocumentoReferencia5,                         fechaDocumentoReferencia1=@fechaDocumentoReferencia1,                         fechaDocumentoReferencia2=@fechaDocumentoReferencia2,                         fechaDocumentoReferencia3=@fechaDocumentoReferencia3,                         fechaDocumentoReferencia4=@fechaDocumentoReferencia4,                         fechaDocumentoReferencia5=@fechaDocumentoReferencia5,                         tipoAccion1=@tipoAccion1,                         tipoAccion2=@tipoAccion2,                         tipoAccion3=@tipoAccion3,                         tipoAccion4=@tipoAccion4,                         tipoAccion5=@tipoAccion5,                         tipoAccionNombre1=@tipoAccionNombre1,                         tipoAccionNombre2=@tipoAccionNombre2,                         tipoAccionNombre3=@tipoAccionNombre3,                         tipoAccionNombre4=@tipoAccionNombre4,                         tipoAccionNombre5=@tipoAccionNombre5,                         razonReferencia1=@razonReferencia1,                         razonReferencia2=@razonReferencia2,                         razonReferencia3=@razonReferencia3,                         razonReferencia4=@razonReferencia4,                         razonReferencia5=@razonReferencia5,                         codImpuesto1=@codImpuesto1,                         codImpuesto2=@codImpuesto2,                         codImpuesto3=@codImpuesto3,                         codImpuesto4=@codImpuesto4,                         codImpuesto5=@codImpuesto5                                              \r\n        WHERE idFactura=@idFactura AND folio=@folio";
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
        command.Parameters.AddWithValue("@folioDocumentoReferencia1", veOB.FE_folioDocumentoReferencia1);
        command.Parameters.AddWithValue("@folioDocumentoReferencia2", veOB.FE_folioDocumentoReferencia2);
        command.Parameters.AddWithValue("@folioDocumentoReferencia3", veOB.FE_folioDocumentoReferencia3);
        command.Parameters.AddWithValue("@folioDocumentoReferencia4", veOB.FE_folioDocumentoReferencia4);
        command.Parameters.AddWithValue("@folioDocumentoReferencia5", veOB.FE_folioDocumentoReferencia5);
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
        if (conexion.ConexionMySql.State != ConnectionState.Open)
        {
            int con = 0;
            do
            {
                con++;
                try
                {
                    conexion.ConexionMySql.Open();
                    ((DbCommand)command).ExecuteNonQuery();
                }
                catch { conexion.ConexionMySql.Close(); }
            } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
        }
        else
        {
            ((DbCommand)command).ExecuteNonQuery();

        }
        foreach (DatosVentaVO datosVentaVo in this.buscaDetalleFacturaIDFactura(veOB.IdFactura))
        {
          new ControlProducto().registroDocumentoModifica(datosVentaVo, "FACTURA ELECTRONICA");
          new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "FACTURA ELECTRONICA");
          this.actualizaStock(datosVentaVo, "+");
        }
        this.eliminaDetalleFactura(veOB);
        if (listaLoteAntigua.Count > 0)
        {
          foreach (LoteVO loteVo in listaLoteAntigua)
            new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
        }
        foreach (DatosVentaVO veVO in listaNueva)
        {
          Decimal num = this.consultaStock(veVO);
          veVO.StockQueda = num - veVO.Cantidad;
          this.agregaDetalleFactura2(veVO);
          this.actualizaStock(veVO, "-");
        }
        if (listaLote.Count > 0)
        {
          int idFactura = veOB.IdFactura;
          long num = (long) veOB.Folio;
          string str = "FACTURA ELECTRONICA";
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
        return "Factura Modificada";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool eliminaDetalleFactura(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM electronica_detalle_factura WHERE idFacturaLinea=@idFactura AND folioFactura=@folioFactura";
        command.Parameters.AddWithValue("@idFactura", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioFactura", (object) veOB.Folio);
        if (conexion.ConexionMySql.State != ConnectionState.Open)
        {
            int con = 0;
            do
            {
                con++;
                try
                {
                    conexion.ConexionMySql.Open();
                    ((DbCommand)command).ExecuteNonQuery();
                }
                catch { conexion.ConexionMySql.Close(); }
            } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
        }
        else
        {
            ((DbCommand)command).ExecuteNonQuery();

        }
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public int eliminaFactura(int idFactura, List<DatosVentaVO> lista, List<LoteVO> listaLoteAntigua)
    {
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "FACTURA ELECTRONICA");
          this.actualizaStock(datosVentaVo, "+");
        }
      }
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE electronica_factura, electronica_detalle_factura FROM electronica_factura, electronica_detalle_factura WHERE electronica_factura.idFactura = @idFactura AND electronica_detalle_factura.idFacturaLinea=@idFactura";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
                  return ((DbCommand)command).ExecuteNonQuery();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
          
      }
      else
      {
          return ((DbCommand)command).ExecuteNonQuery();

      }
      return ((DbCommand)command).ExecuteNonQuery();
    }

    public string anulaFactura(int idFactura, List<DatosVentaVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_factura SET estadoDocumento = 'ANULADA', razonSocial= 'FACTURA ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0'  WHERE idFactura=@idFactura";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
                  ((DbCommand)command).ExecuteNonQuery();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);

      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();

      }
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "FACTURA ELECTRONICA");
          this.actualizaStock(datosVentaVo, "+");
        }
      }
      return "Factura Anulada!!";
    }

    private void registroFacturaNula(DatosVentaVO vevo)
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

    public DataTable muestraFacturaFolio(int folio)
    {
      string str = "SELECT \r\n                            f.idFactura,\r\n                            f.folio,\r\n                            f.fechaEmision,\r\n                            f.fechaVencimiento,\r\n                            f.dia,\r\n                            f.mes,\r\n                            f.ano,\r\n                            f.idCliente, \r\n                            f.rut, \r\n                            f.digito, \r\n                            f.razonSocial,\r\n                            f.direccion, \r\n                            f.comuna, \r\n                            f.ciudad, \r\n                            f.giro, \r\n                            f.fono, \r\n                            f.fax, \r\n                            f.contacto, \r\n                            f.diasPlazo, \r\n                            f.idMedioPago,                          \r\n                            f.medioPago, \r\n                            f.idVendedor, \r\n                            f.vendedor, \r\n                            f.idCentroCosto, \r\n                            f.centroCosto, \r\n                            f.ordenCompra, \r\n                            f.subtotal, \r\n                            f.porcentajeDescuento,\r\n                            f.descuento, \r\n                            f.porcentajeIva, \r\n                            f.iva,\r\n                            f.neto, \r\n                            f.total, \r\n                            f.totalExento,\r\n                            f.totalPalabras, \r\n                            f.estadoPago, \r\n                            f.estadoDocumento, \r\n                            f.totalPagado,\r\n                            f.totalDocumentado,\r\n                            f.totalPendiente,\r\n                            f.impuesto1,\r\n                            f.impuesto2,\r\n                            f.impuesto3,\r\n                            f.impuesto4,\r\n                            f.impuesto5,\r\n                            f.porcentajeImpuesto1,\r\n                            f.porcentajeImpuesto2,\r\n                            f.porcentajeImpuesto3,\r\n                            f.porcentajeImpuesto4,\r\n                            f.porcentajeImpuesto5,\r\n                            f.comisionVendedor,\r\n                            f.idTicket,\r\n                            f.folioTicket,\r\n                            f.folioGuias,\r\n                            f.observaciones,\r\n                            f.fechaModificacion,\r\n                            f.idCotizacion,\r\n                            f.folioCotizacion,\r\n                            f.caja,\r\n                            f.idNotaVenta,\r\n                            f.folioNotaVenta,\r\n                            f.tipoDocumento1,\r\n                            f.tipoDocumento2,\r\n                            f.tipoDocumento3,\r\n                            f.tipoDocumento4,\r\n                            f.tipoDocumento5,\r\n                            f.tipoDocumentoNombre1,\r\n                            f.tipoDocumentoNombre2,\r\n                            f.tipoDocumentoNombre3,\r\n                            f.tipoDocumentoNombre4,\r\n                            f.tipoDocumentoNombre5,\r\n                            f.folioDocumentoReferencia1,\r\n                            f.folioDocumentoReferencia2,\r\n                            f.folioDocumentoReferencia3,\r\n                            f.folioDocumentoReferencia4,\r\n                            f.folioDocumentoReferencia5,\r\n                            f.fechaDocumentoReferencia1,\r\n                            f.fechaDocumentoReferencia2,\r\n                            f.fechaDocumentoReferencia3,\r\n                            f.fechaDocumentoReferencia4,\r\n                            f.fechaDocumentoReferencia5,\r\n                            f.tipoAccion1,\r\n                            f.tipoAccion2,\r\n                            f.tipoAccion3,\r\n                            f.tipoAccion4,\r\n                            f.tipoAccion5,\r\n                            f.tipoAccionNombre1,\r\n                            f.tipoAccionNombre2,\r\n                            f.tipoAccionNombre3,\r\n                            f.tipoAccionNombre4,\r\n                            f.tipoAccionNombre5,\r\n                            f.razonReferencia1,\r\n                            f.razonReferencia2,\r\n                            f.razonReferencia3,\r\n                            f.razonReferencia4,\r\n                            f.razonReferencia5,\r\n                            f.codImpuesto1,\r\n                            f.codImpuesto2,\r\n                            f.codImpuesto3,\r\n                            f.codImpuesto4,\r\n                            f.codImpuesto5,\r\n                            d.idFacturaLinea,\r\n                            d.folioFactura,\r\n                            d.fechaIngreso,\r\n                            d.codigo,\r\n                            d.descripcion,\r\n                            d.valorVenta,\r\n                            d.cantidad,\r\n                            d.porcentajeDescuentoLinea,\r\n                            d.descuentoLinea,\r\n                            d.subtotalLinea, \r\n                            d.totalLinea, \r\n                            d.tipoDescuento, \r\n                            d.listaPrecio, \r\n                            d.bodega, \r\n                            d.idDetallefactura,                            \r\n                            d.idImpuesto, \r\n                            d.netoLinea,\r\n                            d.valorCompra,\r\n                            d.exento,                           \r\n                            i.imagenCodigo AS 'imagen1',\r\n                            l.lote,\r\n                            l.cantidad as 'cantidadLote',\r\n                            l.codigo as 'codigoLote'\r\n                            FROM electronica_factura f INNER JOIN electronica_detalle_factura d\r\n                            ON f.idFactura = d.idFacturaLinea                            \r\n                            INNER JOIN zpdf417 i\r\n                            ON i.tipoDte=33 AND i.folio = f.folio\r\n                            LEFT JOIN lotes_detalle l ON l.documento='FACTURA ELECTRONICA' AND l.tipoDocumento='VENTA' AND l.idDocumento=f.idFactura\r\n                            WHERE f.folio=@folio ORDER BY d.idDetallefactura";
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

    public DataTable facturaElectronicaInforme(string filtro)
    {
      string str = "SELECT     idFactura,     folio,     fechaEmision,     fechaVencimiento,     idCliente,     rut,     digito,     razonSocial,     direccion,     comuna,     ciudad,     giro,     fono,     fax,     contacto,     diasPlazo,     idMedioPago,     medioPago,     idVendedor,     vendedor,     idCentroCosto,     centroCosto,     ordenCompra,     subtotal,     porcentajeDescuento,     descuento,     porcentajeIva,     iva,     neto,     total,     totalPalabras,     estadoPago,     estadoDocumento,     totalPagado,     totalDocumentado,     totalPendiente,     impuesto1,     impuesto2,     impuesto3,     impuesto4,     impuesto5,     porcentajeImpuesto2,     porcentajeImpuesto1,     porcentajeImpuesto3,     porcentajeImpuesto4,     porcentajeImpuesto5,     comisionVendedor,     idTicket,     folioTicket,     folioGuias,     observaciones,     fechaModificacion,     idCotizacion,     folioCotizacion,     caja,     idNotaVenta,     folioNotaVenta                                        \r\n                                FROM\r\n                                electronica_factura\r\n                                WHERE " + filtro + " ORDER BY folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable facturaElectronicaInformePagos(string filtro)
    {
      string str = "SELECT \r\n                            facturas.idFactura,\r\n                            facturas.folio,\r\n                            facturas.fechaEmision,\r\n                            facturas.fechaVencimiento,\r\n                            facturas.idCliente, \r\n                            facturas.rut, \r\n                            facturas.digito, \r\n                            facturas.razonSocial,\r\n                            facturas.direccion, \r\n                            facturas.comuna, \r\n                            facturas.ciudad, \r\n                            facturas.giro, \r\n                            facturas.fono, \r\n                            facturas.fax, \r\n                            facturas.contacto, \r\n                            facturas.diasPlazo, \r\n                            facturas.idMedioPago,                          \r\n                            facturas.medioPago, \r\n                            facturas.idVendedor, \r\n                            facturas.vendedor, \r\n                            facturas.idCentroCosto, \r\n                            facturas.centroCosto, \r\n                            facturas.ordenCompra, \r\n                            facturas.subtotal, \r\n                            facturas.porcentajeDescuento,\r\n                            facturas.descuento, \r\n                            facturas.porcentajeIva, \r\n                            facturas.iva, facturas.neto, \r\n                            facturas.total, \r\n                            facturas.totalPalabras, \r\n                            facturas.estadoPago, \r\n                            facturas.estadoDocumento, \r\n                            facturas.totalPagado,\r\n                            facturas.totalDocumentado,\r\n                            facturas.totalPendiente,\r\n                            facturas.impuesto1,\r\n                            facturas.impuesto2,\r\n                            facturas.impuesto3,\r\n                            facturas.impuesto4,\r\n                            facturas.impuesto5,\r\n                            facturas.porcentajeImpuesto1,\r\n                            facturas.porcentajeImpuesto2,\r\n                            facturas.porcentajeImpuesto3,\r\n                            facturas.porcentajeImpuesto4,\r\n                            facturas.porcentajeImpuesto5,\r\n                            facturas.comisionVendedor,\r\n                            facturas.idTicket,\r\n                            facturas.folioTicket,\r\n                            facturas.folioGuias,\r\n                            facturas.observaciones,\r\n                            facturas.fechaModificacion,\r\n                            facturas.idCotizacion,\r\n                            facturas.folioCotizacion,\r\n                            facturas.caja,\r\n                            facturas.idNotaVenta,\r\n                            facturas.folioNotaVenta,                            \r\n                            pagosventas.medioPagoPV,\r\n                            pagosventas.estadoPagoPV,\r\n                            pagosventas.monto,\r\n                            pagosventas.fechaCobro,\r\n                            pagosventas.fechaIngreso,\r\n                            pagosventas.banco,\r\n                            pagosventas.cuenta,\r\n                            pagosventas.numeroDocumento\r\n                            FROM electronica_factura facturas LEFT JOIN pagosventas \r\n                            ON facturas.idFactura = pagosventas.idDocumento AND pagosventas.tipoDocumento='FACTURA_ELECTRONICA' WHERE " + filtro + " ORDER BY facturas.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable facturaElectronicaInformeProductoCategoria(string filtro)
    {
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT f.folio, f.fechaEmision,         f.idCentroCosto,         f.centroCosto,         d.codigo,         d.descripcion,         d.cantidad,         d.valorVenta,         d.totalLinea,         p.Categoria FROM electronica_factura f  INNER JOIN electronica_detalle_factura d  ON f.idFactura=d.idFacturaLinea LEFT JOIN productos p ON p.codigo=d.codigo WHERE " + filtro;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
