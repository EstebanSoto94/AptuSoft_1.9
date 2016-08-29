 
// Type: Aptusoft.Guia
 
 
// version 1.8.0

using Aptusoft.Lotes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Guia
  {
    private bool descuentaInventario = false;
    private Conexion conexion = Conexion.getConecta();

    public string agregaGuia(Venta veOB)
    {
      this.descuentaInventario = Convert.ToBoolean(veOB.DescuentaInventario);
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO guias (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            descuentaInventario,\r\n                                                            tipoGuia,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            facturada,\r\n                                                            folioFactura,\r\n                                                            caja,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idTicket,\r\n                                                            folioTicket\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @descuentaInventario,\r\n                                                            @tipoGuia,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @facturada,\r\n                                                            @folioFactura,\r\n                                                            @caja,\r\n                                                            @idNotaVenta,\r\n                                                            @folioNotaVenta,\r\n                                                            @idCotizacion,\r\n                                                            @folioCotizacion,\r\n                                                            @idTicket,\r\n                                                            @folioTicket\r\n                                                   )";
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
        command.Parameters.AddWithValue("@descuentaInventario", (veOB.DescuentaInventario ? 1 : 0));
        command.Parameters.AddWithValue("@tipoGuia", (object) veOB.TipoGuia);
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
        command.Parameters.AddWithValue("@facturada", (object) 0);
        command.Parameters.AddWithValue("@folioFactura", (object) 0);
        command.Parameters.AddWithValue("@caja", (object) veOB.Caja);
        command.Parameters.AddWithValue("@idNotaVenta", (object) veOB.IdNotaVenta);
        command.Parameters.AddWithValue("@folioNotaVenta", (object) veOB.FolioNotaVenta);
        command.Parameters.AddWithValue("@idCotizacion", (object) veOB.IdCotizacion);
        command.Parameters.AddWithValue("@folioCotizacion", (object) veOB.FolioCotizacion);
        command.Parameters.AddWithValue("@idTicket", (object) veOB.IdTicket);
        command.Parameters.AddWithValue("@folioTicket", (object) veOB.FolioTicket);
        ((DbCommand) command).ExecuteNonQuery();
        return "Guia Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleGuia(List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      int num1 = 0;
      long num2 = 0L;
      foreach (DatosVentaVO veVO in lista)
      {
        if (num1 == 0)
        {
          num1 = this.RetornaIdGuia(veVO.FolioFactura);
          num2 = (long) veVO.FolioFactura;
        }
        veVO.IdFactura = num1;
        if (!this.descuentaInventario && veVO.DescuentaInventario)
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
      string str = "GUIA DE DESPACHO";
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

    public bool agregaDetalleGuia2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura;
      if (num == 0)
        num = this.RetornaIdGuia(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detalleguia (\r\n                                                            idGuiaLinea,\r\n                                                            folioGuia,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            bodegaDestino,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda,\r\n                                                            stockQuedaDestino\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idGuiaLinea,\r\n                                                            @folioGuiaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @bodegaDestino,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda,\r\n                                                            @stockQuedaDestino\r\n                                                             )";
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
        command.Parameters.AddWithValue("@bodegaDestino", (object) veVO.BodegaDestino);
        command.Parameters.AddWithValue("@idImpuesto", (object) veVO.IdImpuesto);
        command.Parameters.AddWithValue("@netoLinea", (object) veVO.NetoLinea);
        command.Parameters.AddWithValue("@descuentaInventario", (veVO.DescuentaInventario ? 1 : 0));
        command.Parameters.AddWithValue("@valorCompra", (object) veVO.ValorCompra);
        command.Parameters.AddWithValue("@usuario", (object) veVO.Usuario);
        command.Parameters.AddWithValue("@stockQueda", (object) veVO.StockQueda);
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

    public string anulaGuia(int idGuia, List<DatosVentaVO> lista, bool descuentaStook, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE guias SET estadoDocumento = 'ANULADA', razonSocial= 'GUIA ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0' WHERE idGuia=@idGuia";
      command.Parameters.AddWithValue("@idGuia", (object) idGuia);
      ((DbCommand) command).ExecuteNonQuery();
      if (!descuentaStook)
      {
        foreach (DatosVentaVO datosVentaVo in lista)
        {
          if (datosVentaVo.DescuentaInventario)
          {
            new ControlProducto().registroDocumentoNulo(datosVentaVo, "GUIA");
            this.actualizaStock(datosVentaVo, "+");
            if (datosVentaVo.BodegaDestino > 0)
            {
              datosVentaVo.Bodega = datosVentaVo.BodegaDestino;
              datosVentaVo.StockQueda = datosVentaVo.StockQuedaDestino;
              new ControlProducto().registroDocumentoNuloNotaCredito(datosVentaVo, "GUIA TRASLADO");
              this.actualizaStock(datosVentaVo, "-");
            }
          }
        }
      }
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      return "Guia Anulada!!";
    }

    private void registroGuiaNula(DatosVentaVO vevo, string signo, int bodega)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.FechaIngreso = vevo.FechaIngreso;
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "GUIA FOLIO: " + (object) vevo.FolioFactura + "- [ANULADO]";
      cp.Bodega = vevo.Bodega;
      cp.CantidadAnterior = vevo.Cantidad + vevo.StockQueda;
      cp.CantidadActual = vevo.StockQueda;
      controlProducto.agregaControlProductoModificacion(cp);
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "GUIA FOLIO: " + (object) vevo.FolioFactura + "- [ANULADO]";
      cp.Bodega = bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = !signo.Equals("+") ? num - vevo.Cantidad : vevo.Cantidad + num;
      controlProducto.agregaControlProducto(cp);
    }

    public int eliminaGuia(int idGuia)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE guias, detalleguia FROM guias, detalleguia WHERE guias.idGuia = @idGuia AND detalleguia.idGuiaLinea=@idGuia";
      command.Parameters.AddWithValue("@idGuia", (object) idGuia);
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

    public int numeroGuia(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM guias WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool guiaExiste(int numGuia)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM guias WHERE folio=@numGuia";
      command.Parameters.AddWithValue("@numGuia", (object) numGuia);
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
        ((DbCommand)command).CommandText = "select last_insert_id(folio) as last from guias order by folio desc limit 1;";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader)mySqlDataReader).Read())
        {
            ultimo = ((DbDataReader)mySqlDataReader)["last"].ToString();
        }

        ((DbDataReader)mySqlDataReader).Close();
        return ultimo;
    }
    public bool guiaDescuentaInventario(int idGuia)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT descuentaInventario FROM guias WHERE idGuia=@numGuia";
      command.Parameters.AddWithValue("@numGuia", (object) idGuia);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["descuentaInventario"].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int RetornaIdGuia(int numGuia)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idguia, folio FROM guias WHERE folio=@numGuia";
      command.Parameters.AddWithValue("@numGuia", (object) numGuia);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaGuiaFolio(int numGuia)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idGuia,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            descuentaInventario,\r\n                                                            tipoGuia,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            facturada,\r\n                                                            folioFactura,\r\n                                                            documentoVenta,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idTicket,\r\n                                                            folioTicket\r\n                                        FROM guias WHERE folio=@numGuia";
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
        venta.TotalPalabras = ((DbDataReader) mySqlDataReader)["totalPalabras"].ToString();
        venta.EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString();
        venta.EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString();
        venta.TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPagado"]);
        venta.TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalDocumentado"]);
        venta.TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPendiente"]);
        venta.DescuentaInventario = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["descuentaInventario"]);
        venta.TipoGuia = ((DbDataReader) mySqlDataReader)["tipoGuia"].ToString();
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
        venta.Facturada = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["facturada"].ToString());
        venta.FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioFactura"].ToString());
        venta.DocumentoVenta = ((DbDataReader) mySqlDataReader)["documentoVenta"].ToString();
        venta.IdNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVenta"]);
        venta.FolioNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaVenta"]);
        venta.IdCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]);
        venta.FolioCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]);
        venta.IdTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicket"]);
        venta.FolioTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioTicket"]);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<Venta> buscaGuiasSinFacturar(int idCliente)
    {
      List<Venta> list = new List<Venta>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idGuia,\r\n                                            folio,\r\n                                            fechaEmision,\r\n                                            idCliente,                                            \r\n                                            total                                          \r\n                                            \r\n                                    FROM guias WHERE idCliente=@idCliente AND facturada=0 AND estadoDocumento='EMITIDA'";
      command.Parameters.AddWithValue("@idCliente", (object) idCliente);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new Venta()
        {
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGuia"].ToString()),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"].ToString()),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"].ToString()),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString()),
          DocumentoVenta = "GUIA"
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<DatosVentaVO> buscaDetalleGuiaIDGuia(int idGuia)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleGuia, \r\n                                                    idGuiaLinea,\r\n                                                    folioGuia,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    bodegaDestino,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    descuentaInventario,\r\n                                                    valorCompra, stockQueda, stockQuedaDestino\r\n                                                    FROM detalleguia WHERE idGuiaLinea = @idGuia ORDER BY idDetalleGuia asc";
      command.Parameters.AddWithValue("@idGuia", (object) idGuia);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleGuia"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGuiaLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioGuia"]),
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
          BodegaDestino = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodegaDestino"]),
          IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]),
          NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]),
          DescuentaInventario = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["descuentaInventario"].ToString()),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]),
          StockQueda = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQueda"]),
          StockQuedaDestino = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQuedaDestino"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaGuia(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      this.descuentaInventario = Convert.ToBoolean(veOB.DescuentaInventario);
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE guias SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n                                                            descuentaInventario=@descuentaInventario,\r\n                                                            tipoGuia=@tipoGuia,\r\n                                                            \r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor\r\n                                           WHERE idGuia=@idGuia AND folio=@folio";
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
        command.Parameters.AddWithValue("@totalPalabras", (object) veOB.TotalPalabras);
        command.Parameters.AddWithValue("@estadoPago", (object) veOB.EstadoPago);
        command.Parameters.AddWithValue("@totalPagado", (object) veOB.TotalPagado);
        command.Parameters.AddWithValue("@totalDocumentado", (object) veOB.TotalDocumentado);
        command.Parameters.AddWithValue("@totalPendiente", (object) veOB.TotalPendiente);
        command.Parameters.AddWithValue("@descuentaInventario", (veOB.DescuentaInventario ? 1 : 0));
        command.Parameters.AddWithValue("@tipoGuia", (object) veOB.TipoGuia);
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
        if (!this.descuentaInventario)
        {
          foreach (DatosVentaVO datosVentaVo in this.buscaDetalleGuiaIDGuia(veOB.IdFactura))
          {
            new ControlProducto().registroDocumentoModifica(datosVentaVo, "GUIA");
            new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "GUIA");
            this.actualizaStock(datosVentaVo, "+");
            if (datosVentaVo.BodegaDestino > 0)
            {
              datosVentaVo.Bodega = datosVentaVo.BodegaDestino;
              datosVentaVo.StockQueda = datosVentaVo.StockQuedaDestino;
              new ControlProducto().registroDocumentoModificaNotaCredito(datosVentaVo, "GUIA TRASLADO");
              new ControlProducto().registroDocumentoModificaRetornaInventarioNC(datosVentaVo, "GUIA TRASLADO");
              this.actualizaStock(datosVentaVo, "-");
            }
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
          if (!this.descuentaInventario)
          {
            Decimal num1 = this.consultaStock(veVO);
            veVO.StockQueda = num1 - veVO.Cantidad;
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
          veVO.FechaIngreso = veVO.FechaIngreso.AddSeconds(40.0);
          this.agregaDetalleGuia2(veVO);
        }
        if (listaLote.Count > 0)
        {
          int idFactura = veOB.IdFactura;
          long num = (long) veOB.Folio;
          string str = "GUIA DE DESPACHO";
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
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
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
        ((DbCommand) command).CommandText = "UPDATE guias SET facturada=@facturada, folioFactura=@folioFactura, documentoVenta=@docVenta\r\n                                           WHERE  folio=@folio";
        command.Parameters.AddWithValue("@folio", (object) str2);
        command.Parameters.AddWithValue("@facturada", (veOB.Facturada ? 1 : 0));
        command.Parameters.AddWithValue("@folioFactura", (object) veOB.Folio);
        command.Parameters.AddWithValue("@docVenta", (object) veOB.DocumentoVenta);
        ((DbCommand) command).ExecuteNonQuery();
      }
    }

    public bool eliminaDetalleGuia(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detalleguia WHERE idGuiaLinea=@idGuia AND folioGuia=@folioGuia";
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

    public DataTable muestraGuiaFolio(int folio)
    {
      string str = "SELECT \r\n                            guias.idGuia,\r\n                            guias.folio,\r\n                            guias.fechaEmision,\r\n                            guias.fechaVencimiento,\r\n                            guias.dia,\r\n                            guias.mes,\r\n                            guias.ano,\r\n                            guias.idCliente, \r\n                            guias.rut, \r\n                            guias.digito, \r\n                            guias.razonSocial,\r\n                            guias.direccion, \r\n                            guias.comuna, \r\n                            guias.ciudad, \r\n                            guias.giro, \r\n                            guias.fono, \r\n                            guias.fax, \r\n                            guias.contacto, \r\n                            guias.diasPlazo, \r\n                            guias.idMedioPago,                          \r\n                            guias.medioPago, \r\n                            guias.idVendedor, \r\n                            guias.vendedor, \r\n                            guias.idCentroCosto, \r\n                            guias.centroCosto, \r\n                            guias.ordenCompra, \r\n                            guias.subtotal, \r\n                            guias.porcentajeDescuento,\r\n                            guias.descuento, \r\n                            guias.porcentajeIva, \r\n                            guias.iva,\r\n                            guias.neto, \r\n                            guias.total, \r\n                            guias.totalPalabras, \r\n                            guias.estadoPago, \r\n                            guias.estadoDocumento,\r\n                            guias.totalPagado,\r\n                            guias.totalDocumentado,\r\n                            guias.totalPendiente,\r\n                            guias.descuentaInventario,\r\n                            guias.tipoGuia,\r\n                            guias.impuesto1,\r\n                            guias.impuesto2,\r\n                            guias.impuesto3,\r\n                            guias.impuesto4,\r\n                            guias.impuesto5,\r\n                            guias.porcentajeImpuesto1,\r\n                            guias.porcentajeImpuesto2,\r\n                            guias.porcentajeImpuesto3,\r\n                            guias.porcentajeImpuesto4,\r\n                            guias.porcentajeImpuesto5,\r\n                            guias.comisionVendedor,\r\n                            guias.facturada,\r\n                            guias.folioFactura,\r\n                            guias.caja,\r\n                            \r\n                            detalleguia.idGuiaLinea,\r\n                            detalleguia.folioGuia,\r\n                            detalleguia.fechaIngreso,\r\n                            detalleguia.codigo,\r\n                            detalleguia.descripcion,\r\n                            detalleguia.valorVenta,\r\n                            detalleguia.cantidad,\r\n                            detalleguia.porcentajeDescuentoLinea,\r\n                            detalleguia.descuentoLinea,\r\n                            detalleguia.subtotalLinea, \r\n                            detalleguia.totalLinea, \r\n                            detalleguia.tipoDescuento, \r\n                            detalleguia.listaPrecio, \r\n                            detalleguia.bodega,\r\n                            detalleguia.bodegaDestino,  \r\n                            detalleguia.idDetalleguia,\r\n                            detalleguia.idImpuesto,\r\n                            detalleguia.netoLinea,\r\n                            detalleguia.valorCompra\r\n                            FROM guias INNER JOIN detalleguia \r\n                            ON guias.idGuia = detalleguia.idGuiaLinea WHERE guias.folio=@folio ORDER BY detalleguia.idDetalleguia";
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

    public DataTable guiaInforme(string filtro)
    {
      string str = "SELECT \r\n                                            guias.idGuia,\r\n                                            guias.folio,\r\n                                            guias.fechaEmision,\r\n                                            guias.fechaVencimiento,\r\n                                            guias.dia,\r\n                                            guias.mes,\r\n                                            guias.ano,\r\n                                            guias.idCliente, \r\n                                            guias.rut, \r\n                                            guias.digito, \r\n                                            guias.razonSocial,\r\n                                            guias.direccion, \r\n                                            guias.comuna, \r\n                                            guias.ciudad, \r\n                                            guias.giro, \r\n                                            guias.fono, \r\n                                            guias.fax, \r\n                                            guias.contacto, \r\n                                            guias.diasPlazo, \r\n                                            guias.idMedioPago,                          \r\n                                            guias.medioPago, \r\n                                            guias.idVendedor, \r\n                                            guias.vendedor, \r\n                                            guias.idCentroCosto, \r\n                                            guias.centroCosto, \r\n                                            guias.ordenCompra, \r\n                                            guias.subtotal, \r\n                                            guias.porcentajeDescuento,\r\n                                            guias.descuento, \r\n                                            guias.porcentajeIva, \r\n                                            guias.iva,\r\n                                            guias.neto, \r\n                                            guias.total, \r\n                                            guias.totalPalabras, \r\n                                            guias.estadoPago, \r\n                                            guias.estadoDocumento,\r\n                                            guias.totalPagado,\r\n                                            guias.totalDocumentado,\r\n                                            guias.totalPendiente,\r\n                                            guias.descuentaInventario,\r\n                                            guias.tipoGuia,\r\n                                            guias.impuesto1,\r\n                                            guias.impuesto2,\r\n                                            guias.impuesto3,\r\n                                            guias.impuesto4,\r\n                                            guias.impuesto5,\r\n                                            guias.porcentajeImpuesto1,\r\n                                            guias.porcentajeImpuesto2,\r\n                                            guias.porcentajeImpuesto3,\r\n                                            guias.porcentajeImpuesto4,\r\n                                            guias.porcentajeImpuesto5,\r\n                                            guias.comisionVendedor,\r\n                                            guias.facturada,\r\n                                            guias.folioFactura,\r\n                                            guias.caja                                            \r\n                                FROM guias                             \r\n                                WHERE " + filtro + " ORDER BY guias.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable guiaInformeDetalle(string filtro)
    {
      string str = "SELECT \r\n                                        guias.idGuia,\r\n                                        guias.folio,\r\n                                        guias.fechaEmision,\r\n                                        guias.fechaVencimiento,\r\n                                        guias.dia,\r\n                                        guias.mes,\r\n                                        guias.ano,\r\n                                        guias.idCliente, \r\n                                        guias.rut, \r\n                                        guias.digito, \r\n                                        guias.razonSocial,\r\n                                        guias.direccion, \r\n                                        guias.comuna, \r\n                                        guias.ciudad, \r\n                                        guias.giro, \r\n                                        guias.fono, \r\n                                        guias.fax, \r\n                                        guias.contacto, \r\n                                        guias.diasPlazo, \r\n                                        guias.idMedioPago,                          \r\n                                        guias.medioPago, \r\n                                        guias.idVendedor, \r\n                                        guias.vendedor, \r\n                                        guias.idCentroCosto, \r\n                                        guias.centroCosto, \r\n                                        guias.ordenCompra, \r\n                                        guias.subtotal, \r\n                                        guias.porcentajeDescuento,\r\n                                        guias.descuento, \r\n                                        guias.porcentajeIva, \r\n                                        guias.iva,\r\n                                        guias.neto, \r\n                                        guias.total, \r\n                                        guias.totalPalabras, \r\n                                        guias.estadoPago, \r\n                                        guias.estadoDocumento,\r\n                                        guias.totalPagado,\r\n                                        guias.totalDocumentado,\r\n                                        guias.totalPendiente,\r\n                                        guias.descuentaInventario,\r\n                                        guias.tipoGuia,\r\n                                        guias.impuesto1,\r\n                                        guias.impuesto2,\r\n                                        guias.impuesto3,\r\n                                        guias.impuesto4,\r\n                                        guias.impuesto5,\r\n                                        guias.porcentajeImpuesto1,\r\n                                        guias.porcentajeImpuesto2,\r\n                                        guias.porcentajeImpuesto3,\r\n                                        guias.porcentajeImpuesto4,\r\n                                        guias.porcentajeImpuesto5,\r\n                                        guias.comisionVendedor,\r\n                                        guias.facturada,\r\n                                        guias.folioFactura,\r\n                                        guias.caja,                                        \r\n                                        detalleguia.idGuiaLinea,\r\n                                        detalleguia.folioGuia,\r\n                                        detalleguia.fechaIngreso,\r\n                                        detalleguia.codigo,\r\n                                        detalleguia.descripcion,\r\n                                        detalleguia.valorVenta,\r\n                                        detalleguia.cantidad,\r\n                                        detalleguia.porcentajeDescuentoLinea,\r\n                                        detalleguia.descuentoLinea,\r\n                                        detalleguia.subtotalLinea, \r\n                                        detalleguia.totalLinea, \r\n                                        detalleguia.tipoDescuento, \r\n                                        detalleguia.listaPrecio, \r\n                                        detalleguia.bodega,\r\n                                        detalleguia.bodegaDestino,  \r\n                                        detalleguia.idDetalleguia,\r\n                                        detalleguia.idImpuesto,\r\n                                        detalleguia.netoLinea,\r\n                                        detalleguia.valorCompra\r\n                                        FROM guias INNER JOIN detalleguia \r\n                                        ON guias.idGuia = detalleguia.idGuiaLinea                                                            \r\n                                WHERE " + filtro + " ORDER BY guias.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
