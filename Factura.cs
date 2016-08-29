 
// Type: Aptusoft.Factura
 
 
// version 1.8.0

using Aptusoft.Lotes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Factura
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaFactura(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO facturas (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            fechaModificacion,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            caja,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            folioOT, folioNotaVentaMasiva\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @idTicket,\r\n                                                            @folioTicket,\r\n                                                            @folioGuias,\r\n                                                            @observaciones,\r\n                                                            @fechaModificacion,\r\n                                                            @idCotizacion,\r\n                                                            @folioCotizacion,\r\n                                                            @caja,\r\n                                                            @idNotaVenta,\r\n                                                            @folioNotaVenta,\r\n                                                            @folioOT, @folioNotaVentaMasiva\r\n\r\n                                                   )";
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
        command.Parameters.AddWithValue("@folioNotaVentaMasiva", (object) veOB.FolioNotaVentaMasivas);
        ((DbCommand) command).ExecuteNonQuery();
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
      string str = "FACTURA";
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
        ((DbCommand) command).CommandText = "INSERT INTO detallefactura (\r\n                                                            idFacturaLinea,\r\n                                                            folioFactura,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idFactuLinea,\r\n                                                            @folioFacturaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda\r\n                                                             )";
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
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        string message = ex.Message;
        return false;
      }
    }

    public string anulaFactura(int idFactura, List<DatosVentaVO> lista, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE facturas SET estadoDocumento = 'ANULADA', razonSocial= 'FACTURA ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0'  WHERE idFactura=@idFactura";
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
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
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
      cp.Movimiento = "ANULA FACTURA FOLIO: " + (object) vevo.FolioFactura;
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = vevo.Cantidad + num;
      controlProducto.agregaControlProducto(cp);
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

    public int eliminaFactura(int idFactura)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE facturas, detallefactura FROM facturas, detallefactura WHERE facturas.idFactura = @idFactura AND detallefactura.idFacturaLinea=@idFactura";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
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

    public int numeroFactura(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM facturas WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool facturaExiste(int numFactura)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM facturas WHERE folio=@numFactura";
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
        ((DbCommand)command).CommandText = "select last_insert_id(folio) as last from facturas order by folio desc limit 1;";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader)mySqlDataReader).Read())
        {
            ultimo = ((DbDataReader)mySqlDataReader)["last"].ToString();
        }

        ((DbDataReader)mySqlDataReader).Close();
        return ultimo;
    }
    public int RetornaIdFactura(int numFactura)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idfactura, folio FROM facturas WHERE folio=@numFactura";
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
      ((DbCommand) command).CommandText = "SELECT idFactura,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            folioOT, folioNotaVentaMasiva     \r\n                                                FROM facturas WHERE folio=@numFactura";
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
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<Venta> buscaFacturasSegunFolioCotizacion(int folioCoti, int idCoti)
    {
      List<Venta> list = new List<Venta>();
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idFactura,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta,\r\n                                                            folioOT, folioNotaVentaMasiva     \r\n                                                FROM facturas WHERE folioCotizacion=@folioCotizacion AND idCotizacion=@idCotizacion ";
      command.Parameters.AddWithValue("@folioCotizacion", (object) folioCoti);
      command.Parameters.AddWithValue("@idCotizacion", (object) idCoti);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new Venta()
        {
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFactura"]),
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
          FolioGuias = ((DbDataReader) mySqlDataReader)["folioGuias"].ToString(),
          Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString(),
          IdCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]),
          FolioCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]),
          IdNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVenta"]),
          FolioNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaVenta"]),
          FolioOT = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioOT"]),
          FolioNotaVentaMasivas = ((DbDataReader) mySqlDataReader)["folioNotaVentaMasiva"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<DatosVentaVO> buscaDetalleFacturaIDFactura(int idFactura)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleFactura, \r\n                                                    idFacturaLinea,\r\n                                                    folioFactura,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    descuentaInventario,\r\n                                                    valorCompra,stockQueda\r\n                                                    FROM detallefactura WHERE idFacturaLinea = @idFactura ORDER BY idDetalleFactura asc";
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
          StockQueda = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQueda"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaFactura(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE facturas SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor,\r\n                                                            folioGuias=@folioGuias,\r\n                                                            observaciones=@observaciones,\r\n                                                            fechaModificacion=@fechaModificacion,\r\n                                                            folioNotaVentaMasiva=@folioNotaVentaMasiva,\r\n                                                            caja=@caja\r\n\r\n                                           WHERE idFactura=@idFactura AND folio=@folio";
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
        command.Parameters.AddWithValue("@folioNotaVentaMasiva", (object) veOB.FolioNotaVentaMasivas);
        command.Parameters.AddWithValue("@caja", (object) veOB.Caja);
        ((DbCommand) command).ExecuteNonQuery();
        foreach (DatosVentaVO datosVentaVo in this.buscaDetalleFacturaIDFactura(veOB.IdFactura))
        {
          new ControlProducto().registroDocumentoModifica(datosVentaVo, "FACTURA");
          new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "FACTURA");
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
          veVO.FechaIngreso = veVO.FechaIngreso.AddSeconds(40.0);
          this.agregaDetalleFactura2(veVO);
          this.actualizaStock(veVO, "-");
        }
        if (listaLote.Count > 0)
        {
          int idFactura = veOB.IdFactura;
          long num = (long) veOB.Folio;
          string str = "FACTURA";
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
        ((DbCommand) command).CommandText = "DELETE FROM detallefactura WHERE idFacturaLinea=@idFactura AND folioFactura=@folioFactura";
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

    public DataTable muestraFacturaFolio(int folio)
    {
      string str = "SELECT \r\n                            facturas.idFactura,\r\n                            facturas.folio,\r\n                            facturas.fechaEmision,\r\n                            facturas.fechaVencimiento,\r\n                            facturas.dia,\r\n                            facturas.mes,\r\n                            facturas.ano,\r\n                            facturas.idCliente, \r\n                            facturas.rut, \r\n                            facturas.digito, \r\n                            facturas.razonSocial,\r\n                            facturas.direccion, \r\n                            facturas.comuna, \r\n                            facturas.ciudad, \r\n                            facturas.giro, \r\n                            facturas.fono, \r\n                            facturas.fax, \r\n                            facturas.contacto, \r\n                            facturas.diasPlazo, \r\n                            facturas.idMedioPago,                          \r\n                            facturas.medioPago, \r\n                            facturas.idVendedor, \r\n                            facturas.vendedor, \r\n                            facturas.idCentroCosto, \r\n                            facturas.centroCosto, \r\n                            facturas.ordenCompra, \r\n                            facturas.subtotal, \r\n                            facturas.porcentajeDescuento,\r\n                            facturas.descuento, \r\n                            facturas.porcentajeIva, \r\n                            facturas.iva,\r\n                            facturas.neto, \r\n                            facturas.total, \r\n                            facturas.totalPalabras, \r\n                            facturas.estadoPago, \r\n                            facturas.estadoDocumento, \r\n                            facturas.totalPagado,\r\n                            facturas.totalDocumentado,\r\n                            facturas.totalPendiente,\r\n                            facturas.impuesto1,\r\n                            facturas.impuesto2,\r\n                            facturas.impuesto3,\r\n                            facturas.impuesto4,\r\n                            facturas.impuesto5,\r\n                            facturas.porcentajeImpuesto1,\r\n                            facturas.porcentajeImpuesto2,\r\n                            facturas.porcentajeImpuesto3,\r\n                            facturas.porcentajeImpuesto4,\r\n                            facturas.porcentajeImpuesto5,\r\n                            facturas.comisionVendedor,\r\n                            facturas.idTicket,\r\n                            facturas.folioTicket,\r\n                            facturas.folioGuias,\r\n                            facturas.observaciones,\r\n                            facturas.fechaModificacion,\r\n                            facturas.idCotizacion,\r\n                            facturas.folioCotizacion,\r\n                            facturas.caja,\r\n                            facturas.idNotaVenta,\r\n                            facturas.folioNotaVenta,\r\n                            facturas.folioNotaVentaMasiva,\r\n                            detallefactura.idFacturaLinea,\r\n                            detallefactura.folioFactura,\r\n                            detallefactura.fechaIngreso,\r\n                            detallefactura.codigo,\r\n                            detallefactura.descripcion,\r\n                            detallefactura.valorVenta,\r\n                            detallefactura.cantidad,\r\n                            detallefactura.porcentajeDescuentoLinea,\r\n                            detallefactura.descuentoLinea,\r\n                            detallefactura.subtotalLinea, \r\n                            detallefactura.totalLinea, \r\n                            detallefactura.tipoDescuento, \r\n                            detallefactura.listaPrecio, \r\n                            detallefactura.bodega, \r\n                            detallefactura.idDetallefactura,                            \r\n                            detallefactura.idImpuesto, \r\n                            detallefactura.netoLinea,\r\n                            detallefactura.valorCompra\r\n                            FROM facturas INNER JOIN detallefactura \r\n                            ON facturas.idFactura = detallefactura.idFacturaLinea WHERE facturas.folio=@folio ORDER BY detallefactura.idDetallefactura";
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

    public DataTable facturaInforme(string filtro)
    {
      string str = "SELECT\r\n                                        idFactura,\r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        fechaVencimiento,\r\n                                        idCliente,\r\n                                        rut,\r\n                                        digito,\r\n                                        razonSocial,\r\n                                        direccion,\r\n                                        comuna,\r\n                                        ciudad,\r\n                                        giro,\r\n                                        fono,\r\n                                        fax,\r\n                                        contacto,\r\n                                        diasPlazo,\r\n                                        idMedioPago,\r\n                                        medioPago,\r\n                                        idVendedor,\r\n                                        vendedor,\r\n                                        idCentroCosto,\r\n                                        centroCosto,\r\n                                        ordenCompra,\r\n                                        subtotal,\r\n                                        porcentajeDescuento,\r\n                                        descuento,\r\n                                        porcentajeIva,\r\n                                        iva,\r\n                                        neto,\r\n                                        total,\r\n                                        totalPalabras,\r\n                                        estadoPago,\r\n                                        estadoDocumento,\r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente,\r\n                                        impuesto1,\r\n                                        impuesto2,\r\n                                        impuesto3,\r\n                                        impuesto4,\r\n                                        impuesto5,\r\n                                        porcentajeImpuesto2,\r\n                                        porcentajeImpuesto1,\r\n                                        porcentajeImpuesto3,\r\n                                        porcentajeImpuesto4,\r\n                                        porcentajeImpuesto5,\r\n                                        comisionVendedor,\r\n                                        idTicket,\r\n                                        folioTicket,\r\n                                        folioGuias,\r\n                                        observaciones,\r\n                                        fechaModificacion,\r\n                                        idCotizacion,\r\n                                        folioCotizacion,\r\n                                        caja,\r\n                                        folioNotaVentaMasiva\r\n                                FROM\r\n                                facturas                                 \r\n                                WHERE " + filtro + " ORDER BY folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable facturaInformeDetalle(string filtro)
    {
      string str = "SELECT 'FACTURA' as tipoDocumentoVenta,\r\n                            facturas.idFactura,\r\n                            facturas.folio,\r\n                            facturas.fechaEmision,\r\n                            facturas.fechaVencimiento,\r\n                            facturas.idCliente, \r\n                            facturas.rut, \r\n                            facturas.digito, \r\n                            facturas.razonSocial,\r\n                            facturas.direccion, \r\n                            facturas.comuna, \r\n                            facturas.ciudad, \r\n                            facturas.giro, \r\n                            facturas.fono, \r\n                            facturas.fax, \r\n                            facturas.contacto, \r\n                            facturas.diasPlazo, \r\n                            facturas.idMedioPago,                          \r\n                            facturas.medioPago, \r\n                            facturas.idVendedor, \r\n                            facturas.vendedor, \r\n                            facturas.idCentroCosto, \r\n                            facturas.centroCosto, \r\n                            facturas.ordenCompra, \r\n                            facturas.subtotal, \r\n                            facturas.porcentajeDescuento,\r\n                            facturas.descuento, \r\n                            facturas.porcentajeIva, \r\n                            facturas.iva, facturas.neto, \r\n                            facturas.total, \r\n                            facturas.totalPalabras, \r\n                            facturas.estadoPago, \r\n                            facturas.estadoDocumento, \r\n                            facturas.impuesto1,\r\n                            facturas.impuesto2,\r\n                            facturas.impuesto3,\r\n                            facturas.impuesto4,\r\n                            facturas.impuesto5,\r\n                            facturas.porcentajeImpuesto1,\r\n                            facturas.porcentajeImpuesto2,\r\n                            facturas.porcentajeImpuesto3,\r\n                            facturas.porcentajeImpuesto4,\r\n                            facturas.porcentajeImpuesto5,\r\n                            facturas.folioCotizacion,\r\n                            detallefactura.idFacturaLinea,\r\n                            detallefactura.folioFactura,\r\n                            detallefactura.fechaIngreso,\r\n                            detallefactura.codigo,\r\n                            detallefactura.descripcion,\r\n                            detallefactura.valorVenta,\r\n                            detallefactura.cantidad,\r\n                            detallefactura.porcentajeDescuentoLinea,\r\n                            detallefactura.descuentoLinea,\r\n                            detallefactura.subtotalLinea, \r\n                            detallefactura.totalLinea, \r\n                            detallefactura.tipoDescuento, \r\n                            detallefactura.listaPrecio, \r\n                            detallefactura.bodega, \r\n                            detallefactura.idDetallefactura,                            \r\n                            detallefactura.idImpuesto, \r\n                            detallefactura.netoLinea,\r\n                            detallefactura.valorCompra\r\n                            FROM facturas INNER JOIN detallefactura \r\n                            ON facturas.idFactura = detallefactura.idFacturaLinea WHERE " + filtro + " ORDER BY facturas.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable facturaProductosInformeDetalle(string filtro)
    {
      string str = "SELECT\r\n                                    productos.Codigo,\r\n                                    productos.Descripcion,\r\n                                    productos.Marca,\r\n                                    productos.Activo,\r\n                                    productos.Pesable,\r\n                                    productos.Exento,\r\n                                    productos.Kit, \r\n                                    productos.ValorVenta1,\r\n                                    productos.ValorVenta2,\r\n                                    productos.ValorVenta3,\r\n                                    productos.ValorCompra,\r\n                                    productos.PorcRentabilidad1,\r\n                                    productos.PorcRentabilidad2, \r\n                                    productos.PorcRentabilidad3,\r\n                                    productos.StockMinimo,\r\n                                    productos.Bodega1,\r\n                                    productos.Bodega2,\r\n                                    productos.Bodega3,\r\n                                    productos.Bodega4,\r\n                                    productos.Bodega5, \r\n                                    productos.Bodega6,\r\n                                    productos.Bodega7,\r\n                                    productos.Bodega8,\r\n                                    productos.Bodega9,\r\n                                    productos.Bodega10,\r\n                                    productos.Bodega11,\r\n                                    productos.Bodega12,\r\n                                    productos.Bodega13,\r\n                                    productos.Bodega14,\r\n                                    productos.Bodega15, \r\n                                    productos.Bodega16,\r\n                                    productos.Bodega17,\r\n                                    productos.Bodega18,\r\n                                    productos.Bodega19,\r\n                                    productos.Bodega20,\r\n                                    productos.CodCategoria,\r\n                                    productos.Categoria, \r\n                                    productos.CodUnidadMedida,\r\n                                    productos.UnidadMedida,\r\n                                    productos.FechaCreacion,\r\n                                    productos.IdImpuesto,\r\n                                    productos.NombreImpuesto,\r\n                                    detallefactura.idDetallefactura,\r\n                                    detallefactura.idFacturaLinea,\r\n                                    detallefactura.folioFactura,\r\n                                    detallefactura.fechaIngreso,\r\n                                    detallefactura.valorVenta,\r\n                                    detallefactura.cantidad,\r\n                                    detallefactura.porcentajeDescuentoLinea,\r\n                                    detallefactura.descuentoLinea,\r\n                                    detallefactura.subtotalLinea,\r\n                                    detallefactura.totalLinea, \r\n                                    detallefactura.tipoDescuento,\r\n                                    detallefactura.listaPrecio,\r\n                                    detallefactura.bodega,\r\n                                    detallefactura.netoLinea, \r\n                                    detallefactura.descuentaInventario,\r\n                                    facturas.idFactura,\r\n                                    facturas.folio,\r\n                                    facturas.fechaEmision,\r\n                                    facturas.fechaVencimiento,\r\n                                    facturas.dia, \r\n                                    facturas.mes,\r\n                                    facturas.ano,\r\n                                    facturas.idCliente,\r\n                                    facturas.rut,\r\n                                    facturas.digito,\r\n                                    facturas.razonSocial,\r\n                                    facturas.direccion,\r\n                                    facturas.comuna,\r\n                                    facturas.ciudad,\r\n                                    facturas.giro, \r\n                                    facturas.fono,\r\n                                    facturas.fax,\r\n                                    facturas.contacto,\r\n                                    facturas.diasPlazo,\r\n                                    facturas.idMedioPago,\r\n                                    facturas.medioPago,\r\n                                    facturas.idVendedor,\r\n                                    facturas.vendedor, \r\n                                    facturas.idCentroCosto,\r\n                                    facturas.centroCosto,\r\n                                    facturas.ordenCompra,\r\n                                    facturas.subtotal,\r\n                                    facturas.porcentajeDescuento,\r\n                                    facturas.descuento,\r\n                                    facturas.porcentajeIva, \r\n                                    facturas.iva,\r\n                                    facturas.neto,\r\n                                    facturas.total,\r\n                                    facturas.totalPalabras,\r\n                                    facturas.estadoPago,\r\n                                    facturas.estadoDocumento,\r\n                                    facturas.totalPagado,\r\n                                    facturas.totalDocumentado, \r\n                                    facturas.totalPendiente,\r\n                                    facturas.impuesto1,\r\n                                    facturas.impuesto2,\r\n                                    facturas.impuesto3,\r\n                                    facturas.impuesto4,\r\n                                    facturas.impuesto5,\r\n                                    facturas.porcentajeImpuesto1, \r\n                                    facturas.porcentajeImpuesto2,\r\n                                    facturas.porcentajeImpuesto3,\r\n                                    facturas.porcentajeImpuesto4,\r\n                                    facturas.porcentajeImpuesto5,\r\n                                    facturas.comisionVendedor, \r\n                                    facturas.idTicket,\r\n                                    facturas.folioTicket,\r\n                                    facturas.folioGuias,\r\n                                    facturas.observaciones,\r\n                                    facturas.fechaModificacion,\r\n                                    facturas.idCotizacion,\r\n                                    facturas.folioCotizacion,\r\n                                    facturas.caja,\r\n                                    facturas.idNotaVenta,\r\n                                    facturas.folioNotaVenta,\r\n                                    facturas.folioNotaVentaMasiva\r\n                                    FROM productos \r\n                                    INNER JOIN detallefactura ON productos.Codigo = detallefactura.codigo \r\n                                    INNER JOIN facturas ON detallefactura.idFacturaLinea = facturas.idFactura WHERE " + filtro + " ORDER BY facturas.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable facturaInformePagos(string filtro)
    {
      string str = "SELECT \r\n                            facturas.idFactura,\r\n                            facturas.folio,\r\n                            facturas.fechaEmision,\r\n                            facturas.fechaVencimiento,\r\n                            facturas.idCliente, \r\n                            facturas.rut, \r\n                            facturas.digito, \r\n                            facturas.razonSocial,\r\n                            facturas.direccion, \r\n                            facturas.comuna, \r\n                            facturas.ciudad, \r\n                            facturas.giro, \r\n                            facturas.fono, \r\n                            facturas.fax, \r\n                            facturas.contacto, \r\n                            facturas.diasPlazo, \r\n                            facturas.idMedioPago,                          \r\n                            facturas.medioPago, \r\n                            facturas.idVendedor, \r\n                            facturas.vendedor, \r\n                            facturas.idCentroCosto, \r\n                            facturas.centroCosto, \r\n                            facturas.ordenCompra, \r\n                            facturas.subtotal, \r\n                            facturas.porcentajeDescuento,\r\n                            facturas.descuento, \r\n                            facturas.porcentajeIva, \r\n                            facturas.iva, facturas.neto, \r\n                            facturas.total, \r\n                            facturas.totalPalabras, \r\n                            facturas.estadoPago, \r\n                            facturas.estadoDocumento, \r\n                            facturas.totalPagado,\r\n                            facturas.totalDocumentado,\r\n                            facturas.totalPendiente,\r\n                            facturas.impuesto1,\r\n                            facturas.impuesto2,\r\n                            facturas.impuesto3,\r\n                            facturas.impuesto4,\r\n                            facturas.impuesto5,\r\n                            facturas.porcentajeImpuesto1,\r\n                            facturas.porcentajeImpuesto2,\r\n                            facturas.porcentajeImpuesto3,\r\n                            facturas.porcentajeImpuesto4,\r\n                            facturas.porcentajeImpuesto5,\r\n                            facturas.comisionVendedor,\r\n                            facturas.idTicket,\r\n                            facturas.folioTicket,\r\n                            facturas.folioGuias,\r\n                            facturas.observaciones,\r\n                            facturas.fechaModificacion,\r\n                            facturas.idCotizacion,\r\n                            facturas.folioCotizacion,\r\n                            facturas.caja,\r\n                            facturas.idNotaVenta,\r\n                            facturas.folioNotaVenta,\r\n                            facturas.folioOT,\r\n                            facturas.folioNotaVentaMasiva,\r\n                            pagosventas.medioPagoPV,\r\n                            pagosventas.estadoPagoPV,\r\n                            pagosventas.monto,\r\n                            pagosventas.fechaCobro,\r\n                            pagosventas.fechaIngreso,\r\n                            pagosventas.banco,\r\n                            pagosventas.cuenta,\r\n                            pagosventas.numeroDocumento\r\n                            FROM facturas LEFT JOIN pagosventas \r\n                            ON facturas.idFactura = pagosventas.idDocumento AND pagosventas.tipoDocumento='FACTURA' WHERE " + filtro + " ORDER BY facturas.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
