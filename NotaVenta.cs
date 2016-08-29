 
// Type: Aptusoft.NotaVenta
 
 
// version 1.8.0

using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.Lotes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  internal class NotaVenta
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaNotaVenta(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO notaventa (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            fechaModificacion,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            caja\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @documentoVenta,\r\n                                                            @idDocumentoVenta,\r\n                                                            @folioDocumentoVenta,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @idTicket,\r\n                                                            @folioTicket,\r\n                                                            @folioGuias,\r\n                                                            @observaciones,\r\n                                                            @fechaModificacion,\r\n                                                            @idCotizacion,\r\n                                                            @folioCotizacion,\r\n                                                            @caja\r\n                                                   )";
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
        command.Parameters.AddWithValue("@documentoVenta", (object) "");
        command.Parameters.AddWithValue("@idDocumentoVenta", (object) 0);
        command.Parameters.AddWithValue("@folioDocumentoVenta", (object) 0);
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
        ((DbCommand) command).ExecuteNonQuery();
        return "Nota Venta Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleNotaVenta(List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      int num1 = 0;
      long num2 = 0L;
      foreach (DatosVentaVO veVO in lista)
      {
        if (num1 == 0)
        {
          num1 = this.RetornaIdNotaVenta(veVO.FolioFactura);
          num2 = (long) veVO.FolioFactura;
        }
        veVO.IdFactura = num1;
        if (veVO.DescuentaInventario)
        {
          Decimal num3 = this.consultaStock(veVO);
          veVO.StockQueda = num3 - veVO.Cantidad;
          this.actualizaStock(veVO, "-");
        }
        this.agregaDetalleNotaVenta2(veVO);
      }
      if (listaLote.Count <= 0)
        return;
      string str = "NOTA DE VENTA";
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

    public bool agregaDetalleNotaVenta2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura;
      if (num == 0)
        num = this.RetornaIdNotaVenta(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detallenotaventa (\r\n                                                            idNotaVentaLinea,\r\n                                                            folioNotaVenta,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idFactuLinea,\r\n                                                            @folioNotaVentaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda\r\n                                                             )";
        command.Parameters.AddWithValue("@idFactuLinea", (object) num);
        command.Parameters.AddWithValue("@folioNotaVentaLinea", (object) veVO.FolioFactura);
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

    public string anulaNotaVenta(int idNotaVenta, List<DatosVentaVO> lista, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE notaventa SET estadoDocumento = 'ANULADA', razonSocial= 'NOTA VENTA ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0' WHERE idNotaVenta=@idNotaVenta";
      command.Parameters.AddWithValue("@idNotaVenta", (object) idNotaVenta);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "NOTA DE VENTA");
          this.actualizaStock(datosVentaVo, "+");
        }
      }
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      return "Nota de Venta Anulada!!";
    }

    public int eliminaNotaVenta(int idNotaVenta)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE notaventa, detallenotaventa FROM notaventa, detallenotaventa WHERE notaventa.idNotaVenta = @idNotaVenta AND detallenotaventa.idNotaVentaLinea=@idNotaVenta";
      command.Parameters.AddWithValue("@idNotaVenta", (object) idNotaVenta);
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

    public int numeroNotaVenta(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM notaventa WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int numeroNotaVentaSinCaja()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM notaventa";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool notaVentaExiste(int numNV)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM notaventa WHERE folio=@numNV";
      command.Parameters.AddWithValue("@numNV", (object) numNV);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int RetornaIdNotaVenta(int numNV)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idNotaVenta, folio FROM notaventa WHERE folio=@numNV";
      command.Parameters.AddWithValue("@numNV", (object) numNV);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaNotaVentaFolio(int numFactura)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idNotaVenta,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion     \r\n                                                FROM notaventa WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVenta"]);
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
        venta.DocumentoVenta = ((DbDataReader) mySqlDataReader)["documentoVenta"].ToString();
        venta.IDDocumentoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDocumentoVenta"]);
        venta.FolioDocumentoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioDocumentoVenta"]);
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
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<DatosVentaVO> buscaDetalleNotaVentaIDNotaVenta(int idNotaVenta)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleNotaVenta, \r\n                                                    idNotaVentaLinea,\r\n                                                    folioNotaVenta,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    descuentaInventario,\r\n                                                    valorCompra, stockQueda\r\n                                                    FROM detallenotaventa WHERE idNotaVentaLinea = @idNotaVenta ORDER BY idDetalleNotaVenta asc";
      command.Parameters.AddWithValue("@idNotaVenta", (object) idNotaVenta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleNotaVenta"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVentaLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaVenta"]),
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

    public string modificaNotaVenta(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE notaventa SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor,\r\n                                                            fechaModificacion=@fechaModificacion                                              \r\n\r\n                                           WHERE idNotaVenta=@idNotaVenta AND folio=@folio";
        command.Parameters.AddWithValue("@idNotaVenta", (object) veOB.IdFactura);
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
        command.Parameters.AddWithValue("@fechaModificacion", (object) DateTime.Now);
        ((DbCommand) command).ExecuteNonQuery();
        foreach (DatosVentaVO datosVentaVo in this.buscaDetalleNotaVentaIDNotaVenta(veOB.IdFactura))
        {
          new ControlProducto().registroDocumentoModifica(datosVentaVo, "NOTA VENTA");
          new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "NOTA VENTA");
          this.actualizaStock(datosVentaVo, "+");
        }
        this.eliminaDetalleNotaVenta(veOB);
        if (listaLoteAntigua.Count > 0)
        {
          foreach (LoteVO loteVo in listaLoteAntigua)
            new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
        }
        foreach (DatosVentaVO veVO in listaNueva)
        {
          Decimal num = this.consultaStock(veVO);
          veVO.StockQueda = num - veVO.Cantidad;
          veVO.FechaIngreso = DateTime.Now;
          veVO.FechaIngreso = veVO.FechaIngreso.AddSeconds(40.0);
          this.agregaDetalleNotaVenta2(veVO);
          this.actualizaStock(veVO, "-");
        }
        if (listaLote.Count > 0)
        {
          int idFactura = veOB.IdFactura;
          long num = (long) veOB.Folio;
          string str = "NOTA DE VENTA";
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
        return "Nota de Venta Modificada";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool modificaTipoDocumentoNotaVenta(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE notaventa SET documentoVenta = @documentoVenta,\r\n                                                          idDocumentoVenta = @idDocumentoVenta,\r\n                                                          folioDocumentoVenta = @folioDocumentoVenta\r\n                                        WHERE idNotaVenta=@idNotaVenta AND folio=@folio";
        command.Parameters.AddWithValue("@idNotaVenta", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folio", (object) veOB.Folio);
        command.Parameters.AddWithValue("@documentoVenta", (object) veOB.DocumentoVenta);
        command.Parameters.AddWithValue("@idDocumentoVenta", (object) veOB.IDDocumentoVenta);
        command.Parameters.AddWithValue("@folioDocumentoVenta", (object) veOB.FolioDocumentoVenta);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch
      {
        return false;
      }
    }

    public bool eliminaDetalleNotaVenta(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detallenotaventa WHERE idNotaVentaLinea=@idNotaVenta AND folioNotaVenta=@folioNotaVenta";
        command.Parameters.AddWithValue("@idNotaVenta", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioNotaVenta", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public DataTable muestraNotaVentaFolio(int folio)
    {
      string str = "SELECT \r\n                            notaventa.idNotaVenta,\r\n                            notaventa.folio,\r\n                            notaventa.fechaEmision,\r\n                            notaventa.fechaVencimiento,\r\n                            notaventa.dia,\r\n                            notaventa.mes,\r\n                            notaventa.ano,\r\n                            notaventa.idCliente, \r\n                            notaventa.rut, \r\n                            notaventa.digito, \r\n                            notaventa.razonSocial,\r\n                            notaventa.direccion, \r\n                            notaventa.comuna, \r\n                            notaventa.ciudad, \r\n                            notaventa.giro, \r\n                            notaventa.fono, \r\n                            notaventa.fax, \r\n                            notaventa.contacto, \r\n                            notaventa.diasPlazo, \r\n                            notaventa.idMedioPago,                          \r\n                            notaventa.medioPago, \r\n                            notaventa.idVendedor, \r\n                            notaventa.vendedor, \r\n                            notaventa.idCentroCosto, \r\n                            notaventa.centroCosto, \r\n                            notaventa.ordenCompra, \r\n                            notaventa.subtotal, \r\n                            notaventa.porcentajeDescuento,\r\n                            notaventa.descuento, \r\n                            notaventa.porcentajeIva, \r\n                            notaventa.iva, \r\n                            notaventa.neto, \r\n                            notaventa.total, \r\n                            notaventa.totalPalabras, \r\n                            notaventa.estadoPago, \r\n                            notaventa.estadoDocumento,                            \r\n                            notaventa.documentoVenta,\r\n                            notaventa.idDocumentoVenta,\r\n                            notaventa.folioDocumentoVenta,\r\n                            notaventa.totalPagado,\r\n                            notaventa.totalDocumentado,\r\n                            notaventa.totalPendiente,\r\n                            notaventa.impuesto1,\r\n                            notaventa.impuesto2,\r\n                            notaventa.impuesto3,\r\n                            notaventa.impuesto4,\r\n                            notaventa.impuesto5,\r\n                            notaventa.porcentajeImpuesto1,\r\n                            notaventa.porcentajeImpuesto2,\r\n                            notaventa.porcentajeImpuesto3,\r\n                            notaventa.porcentajeImpuesto4,\r\n                            notaventa.porcentajeImpuesto5,\r\n                            notaventa.comisionVendedor,\r\n                            notaventa.idTicket,\r\n                            notaventa.folioTicket,\r\n                            notaventa.folioGuias,\r\n                            notaventa.observaciones,\r\n                            notaventa.fechaModificacion,\r\n                            notaventa.idCotizacion,\r\n                            notaventa.folioCotizacion,\r\n                            notaventa.caja,\r\n                            detallenotaventa.idDetalleNotaVenta,\r\n                            detallenotaventa.idNotaVentaLinea,\r\n                            detallenotaventa.folioNotaVenta,\r\n                            detallenotaventa.fechaIngreso,\r\n                            detallenotaventa.codigo,\r\n                            detallenotaventa.descripcion,\r\n                            detallenotaventa.valorVenta,\r\n                            detallenotaventa.cantidad,\r\n                            detallenotaventa.porcentajeDescuentoLinea,\r\n                            detallenotaventa.descuentoLinea,\r\n                            detallenotaventa.subtotalLinea, \r\n                            detallenotaventa.totalLinea, \r\n                            detallenotaventa.tipoDescuento, \r\n                            detallenotaventa.listaPrecio, \r\n                            detallenotaventa.bodega, \r\n                            detallenotaventa.idDetalleNotaVenta,                            \r\n                            detallenotaventa.idImpuesto, \r\n                            detallenotaventa.netoLinea,\r\n                            detallenotaventa.valorCompra\r\n\r\n                            FROM notaventa INNER JOIN detallenotaventa \r\n                            ON notaventa.idNotaVenta = detallenotaventa.idNotaVentaLinea WHERE notaventa.folio=@folio ORDER BY detallenotaventa.idDetalleNotaVenta";
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

    public DataTable notaVentaInforme(string filtro)
    {
      string str = "SELECT \r\n                                        notaventa.idNotaVenta,\r\n                                        notaventa.folio,\r\n                                        notaventa.fechaEmision,\r\n                                        notaventa.fechaVencimiento,\r\n                                        notaventa.dia,\r\n                                        notaventa.mes,\r\n                                        notaventa.ano,\r\n                                        notaventa.idCliente, \r\n                                        notaventa.rut, \r\n                                        notaventa.digito, \r\n                                        notaventa.razonSocial,\r\n                                        notaventa.direccion, \r\n                                        notaventa.comuna, \r\n                                        notaventa.ciudad, \r\n                                        notaventa.giro, \r\n                                        notaventa.fono, \r\n                                        notaventa.fax, \r\n                                        notaventa.contacto, \r\n                                        notaventa.diasPlazo, \r\n                                        notaventa.idMedioPago,                          \r\n                                        notaventa.medioPago, \r\n                                        notaventa.idVendedor, \r\n                                        notaventa.vendedor, \r\n                                        notaventa.idCentroCosto, \r\n                                        notaventa.centroCosto, \r\n                                        notaventa.ordenCompra, \r\n                                        notaventa.subtotal, \r\n                                        notaventa.porcentajeDescuento,\r\n                                        notaventa.descuento, \r\n                                        notaventa.porcentajeIva, \r\n                                        notaventa.iva, \r\n                                        notaventa.neto, \r\n                                        notaventa.total, \r\n                                        notaventa.totalPalabras, \r\n                                        notaventa.estadoPago, \r\n                                        notaventa.estadoDocumento,                            \r\n                                        notaventa.documentoVenta,\r\n                                        notaventa.idDocumentoVenta,\r\n                                        notaventa.folioDocumentoVenta,\r\n                                        notaventa.totalPagado,\r\n                                        notaventa.totalDocumentado,\r\n                                        notaventa.totalPendiente,\r\n                                        notaventa.impuesto1,\r\n                                        notaventa.impuesto2,\r\n                                        notaventa.impuesto3,\r\n                                        notaventa.impuesto4,\r\n                                        notaventa.impuesto5,\r\n                                        notaventa.porcentajeImpuesto1,\r\n                                        notaventa.porcentajeImpuesto2,\r\n                                        notaventa.porcentajeImpuesto3,\r\n                                        notaventa.porcentajeImpuesto4,\r\n                                        notaventa.porcentajeImpuesto5,\r\n                                        notaventa.comisionVendedor,\r\n                                        notaventa.idTicket,\r\n                                        notaventa.folioTicket,\r\n                                        notaventa.folioGuias,\r\n                                        notaventa.observaciones,\r\n                                        notaventa.fechaModificacion,\r\n                                        notaventa.idCotizacion,\r\n                                        notaventa.folioCotizacion,\r\n                                        notaventa.caja                                            \r\n                                FROM notaventa                             \r\n                                WHERE " + filtro + " ORDER BY notaventa.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable notaVentaInformeDetalle(string filtro)
    {
      string str = "SELECT \r\n                                        notaventa.idNotaVenta,\r\n                                        notaventa.folio,\r\n                                        notaventa.fechaEmision,\r\n                                        notaventa.fechaVencimiento,\r\n                                        notaventa.dia,\r\n                                        notaventa.mes,\r\n                                        notaventa.ano,\r\n                                        notaventa.idCliente, \r\n                                        notaventa.rut, \r\n                                        notaventa.digito, \r\n                                        notaventa.razonSocial,\r\n                                        notaventa.direccion, \r\n                                        notaventa.comuna, \r\n                                        notaventa.ciudad, \r\n                                        notaventa.giro, \r\n                                        notaventa.fono, \r\n                                        notaventa.fax, \r\n                                        notaventa.contacto, \r\n                                        notaventa.diasPlazo, \r\n                                        notaventa.idMedioPago,                          \r\n                                        notaventa.medioPago, \r\n                                        notaventa.idVendedor, \r\n                                        notaventa.vendedor, \r\n                                        notaventa.idCentroCosto, \r\n                                        notaventa.centroCosto, \r\n                                        notaventa.ordenCompra, \r\n                                        notaventa.subtotal, \r\n                                        notaventa.porcentajeDescuento,\r\n                                        notaventa.descuento, \r\n                                        notaventa.porcentajeIva, \r\n                                        notaventa.iva, \r\n                                        notaventa.neto, \r\n                                        notaventa.total, \r\n                                        notaventa.totalPalabras, \r\n                                        notaventa.estadoPago, \r\n                                        notaventa.estadoDocumento,                            \r\n                                        notaventa.documentoVenta,\r\n                                        notaventa.idDocumentoVenta,\r\n                                        notaventa.folioDocumentoVenta,\r\n                                        notaventa.totalPagado,\r\n                                        notaventa.totalDocumentado,\r\n                                        notaventa.totalPendiente,\r\n                                        notaventa.impuesto1,\r\n                                        notaventa.impuesto2,\r\n                                        notaventa.impuesto3,\r\n                                        notaventa.impuesto4,\r\n                                        notaventa.impuesto5,\r\n                                        notaventa.porcentajeImpuesto1,\r\n                                        notaventa.porcentajeImpuesto2,\r\n                                        notaventa.porcentajeImpuesto3,\r\n                                        notaventa.porcentajeImpuesto4,\r\n                                        notaventa.porcentajeImpuesto5,\r\n                                        notaventa.comisionVendedor,\r\n                                        notaventa.idTicket,\r\n                                        notaventa.folioTicket,\r\n                                        notaventa.folioGuias,\r\n                                        notaventa.observaciones,\r\n                                        notaventa.fechaModificacion,\r\n                                        notaventa.idCotizacion,\r\n                                        notaventa.folioCotizacion,\r\n                                        notaventa.caja,\r\n                                        detallenotaventa.idDetalleNotaVenta,\r\n                                        detallenotaventa.idNotaVentaLinea,\r\n                                        detallenotaventa.folioNotaVenta,\r\n                                        detallenotaventa.fechaIngreso,\r\n                                        detallenotaventa.codigo,\r\n                                        detallenotaventa.descripcion,\r\n                                        detallenotaventa.valorVenta,\r\n                                        detallenotaventa.cantidad,\r\n                                        detallenotaventa.porcentajeDescuentoLinea,\r\n                                        detallenotaventa.descuentoLinea,\r\n                                        detallenotaventa.subtotalLinea, \r\n                                        detallenotaventa.totalLinea, \r\n                                        detallenotaventa.tipoDescuento, \r\n                                        detallenotaventa.listaPrecio, \r\n                                        detallenotaventa.bodega, \r\n                                        detallenotaventa.idDetalleNotaVenta,                            \r\n                                        detallenotaventa.idImpuesto, \r\n                                        detallenotaventa.netoLinea,\r\n                                        detallenotaventa.valorCompra,\r\n                                        productos.CodigoAlternativo\r\n                                        FROM notaventa INNER JOIN detallenotaventa \r\n                                        ON notaventa.idNotaVenta = detalleNotaVenta.idNotaVentaLinea \r\n                                        INNER JOIN productos\r\n                                        ON detalleNotaVenta.codigo = productos.Codigo                                                           \r\n                                WHERE " + filtro + " ORDER BY notaventa.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public List<Venta> buscaNotasDeVentaSinFacturar(int idCliente)
    {
      List<Venta> list = new List<Venta>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idNotaVenta,\r\n                                            folio,\r\n                                            fechaEmision,\r\n                                            idCliente,                                            \r\n                                            total \r\n                                    FROM notaventa WHERE idCliente=@idCliente AND idDocumentoVenta=0 AND folioDocumentoVenta=0 AND estadoDocumento='EMITIDA'";
      command.Parameters.AddWithValue("@idCliente", (object) idCliente);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new Venta()
        {
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVenta"].ToString()),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"].ToString()),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"].ToString()),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString()),
          DocumentoVenta = "NOTA DE VENTA"
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void facturaNotaVentaMasiva(Venta veOB)
    {
      string[] strArray = veOB.FolioNotaVentaMasivas.Split('-');
      int num = 0;
      if (veOB.Folio > 0)
      {
        if (veOB.DocumentoVenta.Equals("FACTURA"))
          num = new Factura().RetornaIdFactura(veOB.Folio);
        if (veOB.DocumentoVenta.Equals("FACTURA ELECTRONICA"))
          num = new EFactura().RetornaIdFactura(veOB.Folio);
      }
      foreach (string str1 in strArray)
      {
        string str2 = str1.Replace(".", "");
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "UPDATE notaventa SET idDocumentoVenta=@idFactura, folioDocumentoVenta=@folioFactura, documentoVenta=@docVenta\r\n                                           WHERE  folio=@folio";
        command.Parameters.AddWithValue("@folio", (object) str2);
        command.Parameters.AddWithValue("@folioFactura", (object) veOB.Folio);
        command.Parameters.AddWithValue("@idFactura", (object) num);
        command.Parameters.AddWithValue("@docVenta", (object) veOB.DocumentoVenta);
        ((DbCommand) command).ExecuteNonQuery();
      }
    }
  }
}
