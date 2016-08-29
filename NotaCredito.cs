 
// Type: Aptusoft.NotaCredito
 
 
// version 1.8.0

using Aptusoft.Lotes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  internal class NotaCredito
  {
    private bool mueveInventario = false;
    private Conexion conexion = Conexion.getConecta();

    public string agregaNotaCredito(Venta veOB)
    {
      this.mueveInventario = Convert.ToBoolean(veOB.DescuentaInventario);
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO notacredito (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            folioFactura,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            descuentaInventario,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            caja,\r\n                                                            idTipo,\r\n                                                            tipoNotaCredito,\r\n                                                            montoUsado,\r\n                                                            documento                                                            \r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @folioFactura,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @descuentaInventario,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @caja,\r\n                                                            @idTipo,\r\n                                                            @tipoNotaCredito,\r\n                                                            @montoUsado,\r\n                                                            @documento                                                                                                                        \r\n                                                   )";
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
        command.Parameters.AddWithValue("@folioFactura", (object) veOB.OrdenCompra);
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
        command.Parameters.AddWithValue("@caja", (object) veOB.Caja);
        command.Parameters.AddWithValue("@idTipo", (object) veOB.IdTipoNotaCredito);
        command.Parameters.AddWithValue("@tipoNotaCredito", (object) veOB.TipoNotaCredito);
        command.Parameters.AddWithValue("@montoUsado", (object) veOB.MontoUsado);
        command.Parameters.AddWithValue("@documento", (object) veOB.DocumentoNotaCredito);
        ((DbCommand) command).ExecuteNonQuery();
        return "Nota Credito Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleNotaCredito(List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      int num1 = 0;
      long num2 = 0L;
      foreach (DatosVentaVO veVO in lista)
      {
        if (num1 == 0)
        {
          num1 = this.retornaIdNotaCredito(veVO.FolioFactura);
          num2 = (long) veVO.FolioFactura;
        }
        veVO.IdFactura = num1;
        if (!this.mueveInventario)
        {
          Decimal num3 = this.consultaStock(veVO);
          veVO.StockQueda = num3 + veVO.Cantidad;
          this.actualizaStock(veVO, "+");
        }
        this.agregaDetalleNotaCredito2(veVO);
      }
      if (listaLote.Count <= 0)
        return;
      string str = "NOTA DE CREDITO";
      foreach (LoteVO loteVo in listaLote)
      {
        loteVo.Documento = str;
        loteVo.IdDocumento = num1;
        loteVo.FolioDocumento = num2;
        loteVo.TipoDocumento = "VENTA";
        loteVo.Accion = "INGRESA";
      }
      new Lote().RegistraLote(listaLote);
    }

    public bool agregaDetalleNotaCredito2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura;
      if (num == 0)
        num = this.retornaIdNotaCredito(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detallenotacredito (\r\n                                                            idNotaCreditoLinea,\r\n                                                            folioNotaCredito,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda                                                            \r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idGuiaLinea,\r\n                                                            @folioGuiaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda \r\n                                                             )";
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

    public string anulaNotaCredito(int idNotaCredito, List<DatosVentaVO> lista, bool aumentaStook, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE notacredito SET estadoDocumento = 'ANULADA', razonSocial= 'NOTA CREDITO ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0' WHERE idNotaCredito=@idNotaCredito";
      command.Parameters.AddWithValue("@idNotaCredito", (object) idNotaCredito);
      ((DbCommand) command).ExecuteNonQuery();
      if (!aumentaStook)
      {
        foreach (DatosVentaVO datosVentaVo in lista)
        {
          new ControlProducto().registroDocumentoNuloNotaCredito(datosVentaVo, "NOTA CREDITO");
          this.actualizaStock(datosVentaVo, "-");
        }
      }
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      return "Nota Credito Anulada!!";
    }

    private void registroNotaCreditoNula(DatosVentaVO vevo)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ANULA NOTA CREDITO FOLIO: " + (object) vevo.FolioFactura;
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = num - vevo.Cantidad;
      controlProducto.agregaControlProducto(cp);
    }

    public int eliminaNotaCredito(int idNotaCredito)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE notacredito, detallenotacredito FROM notacredito, detallenotacredito WHERE notacredito.idNotaCredito = @idNotaCredito AND detallenotacredito.idNotaCreditoLinea=@idNotaCredito";
      command.Parameters.AddWithValue("@idNotaCredito", (object) idNotaCredito);
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

    public int numeroNotaCredito(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM notacredito WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool notaCreditoExiste(int numNotaCredito)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM notacredito WHERE folio=@numNotaCredito";
      command.Parameters.AddWithValue("@numNotaCredito", (object) numNotaCredito);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int retornaIdNotaCredito(int numNotaCredito)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idNotaCredito, folio FROM notacredito WHERE folio=@numNotaCredito";
      command.Parameters.AddWithValue("@numNotaCredito", (object) numNotaCredito);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaNotaCreditoFolio(int numNotaCredito)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idNotaCredito,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            folioFactura,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            descuentaInventario,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            idTipo,\r\n                                                            tipoNotaCredito,\r\n                                                            montoUsado,\r\n                                                            documento\r\n                                        FROM notacredito WHERE folio=@numNotaCredito";
      command.Parameters.AddWithValue("@numNotaCredito", (object) numNotaCredito);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaCredito"]);
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
        venta.OrdenCompra = ((DbDataReader) mySqlDataReader)["folioFactura"].ToString();
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
        venta.IdTipoNotaCredito = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipo"]);
        venta.TipoNotaCredito = ((DbDataReader) mySqlDataReader)["tipoNotaCredito"].ToString();
        venta.MontoUsado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["montoUsado"]);
        venta.DocumentoNotaCredito = ((DbDataReader) mySqlDataReader)["documento"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<Venta> buscaNotaCreditoPago(int idCliente)
    {
      Venta venta = new Venta();
      List<Venta> list = new List<Venta>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idNotaCredito,\r\n                                           folio,\r\n                                           fechaEmision,                                                                                                                                                                 \r\n                                           total,                                                                                                                                                  \r\n                                           montoUsado,\r\n                                           (total-montoUsado) AS 'montoDisponible'\r\n                                        FROM notacredito WHERE idCliente=@idCliente AND (idTipo=1 OR idTipo=3) AND total > montoUsado";
      command.Parameters.AddWithValue("@idCliente", (object) idCliente);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new Venta()
        {
          TipoNotaCredito = "NOTA CREDITO",
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaCredito"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          MontoUsado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["montoUsado"]),
          MontoDisponible = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["montoDisponible"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<DatosVentaVO> buscaDetalleNotaCreditoIDNotaCredito(int idNotaCredito)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetallenotaCredito, \r\n                                                    idNotaCreditoLinea,\r\n                                                    folioNotaCredito,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra,stockQueda\r\n                                                    FROM detallenotacredito WHERE idNotaCreditoLinea = @idNotaCredito ORDER BY idDetallenotaCredito asc";
      command.Parameters.AddWithValue("@idNotaCredito", (object) idNotaCredito);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetallenotaCredito"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaCreditoLinea"]),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaCredito"]),
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
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]),
          StockQueda = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQueda"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaNotaCredito(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      this.mueveInventario = Convert.ToBoolean(veOB.DescuentaInventario);
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE notacredito SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            folioFactura=@folioFactura,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n                                                            descuentaInventario=@descuentaInventario,\r\n                                                            \r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor,\r\n                                                            idTipo=@idTipo,\r\n                                                            tipoNotaCredito=@tipoNotaCredito\r\n                                           WHERE idNotaCredito=@idNotaCredito AND folio=@folio";
        command.Parameters.AddWithValue("@idNotaCredito", (object) veOB.IdFactura);
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
        command.Parameters.AddWithValue("@folioFactura", (object) veOB.OrdenCompra);
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
        command.Parameters.AddWithValue("@idTipo", (object) veOB.IdTipoNotaCredito);
        command.Parameters.AddWithValue("@tipoNotaCredito", (object) veOB.TipoNotaCredito);
        ((DbCommand) command).ExecuteNonQuery();
        foreach (DatosVentaVO datosVentaVo in this.buscaDetalleNotaCreditoIDNotaCredito(veOB.IdFactura))
        {
          new ControlProducto().registroDocumentoModificaNotaCredito(datosVentaVo, "NOTA CREDITO");
          new ControlProducto().registroDocumentoModificaRetornaInventarioNC(datosVentaVo, "NOTA CREDITO");
          this.actualizaStock(datosVentaVo, "-");
        }
        this.eliminaDetalleNotaCredito(veOB);
        if (listaLoteAntigua.Count > 0)
        {
          foreach (LoteVO loteVo in listaLoteAntigua)
            new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
        }
        foreach (DatosVentaVO veVO in listaNueva)
        {
          if (!this.mueveInventario)
          {
            Decimal num = this.consultaStock(veVO);
            veVO.StockQueda = num + veVO.Cantidad;
            this.actualizaStock(veVO, "+");
          }
          veVO.FechaIngreso = veVO.FechaIngreso.AddSeconds(40.0);
          this.agregaDetalleNotaCredito2(veVO);
        }
        if (listaLote.Count > 0)
        {
          int idFactura = veOB.IdFactura;
          long num = (long) veOB.Folio;
          string str = "NOTA DE CREDITO";
          foreach (LoteVO loteVo in listaLote)
          {
            loteVo.Documento = str;
            loteVo.IdDocumento = idFactura;
            loteVo.FolioDocumento = num;
            loteVo.TipoDocumento = "VENTA";
            loteVo.Accion = "INGRESA";
          }
          new Lote().RegistraLote(listaLote);
        }
        return "Nota Credito Modificada";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public void modificaMontoUsadoNotaCredito(string folio, Decimal montoUsado)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE notacredito SET montoUsado = (@montoUsado + montoUsado)                                                          \r\n                                           WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@montoUsado", (object) montoUsado);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public bool eliminaDetalleNotaCredito(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detallenotacredito WHERE idNotaCreditoLinea=@idNotaCredito AND folioNotaCredito=@folioNotaCredito";
        command.Parameters.AddWithValue("@idNotaCredito", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioNotaCredito", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public DataTable muestraNotaCreditoFolio(int folio)
    {
      string str = "SELECT \r\n                                        notacredito.idNotaCredito,\r\n                                        notacredito.folio,\r\n                                        notacredito.fechaEmision,\r\n                                        notacredito.fechaVencimiento,\r\n                                        notacredito.dia,\r\n                                        notacredito.mes,\r\n                                        notacredito.ano,\r\n                                        notacredito.idCliente, \r\n                                        notacredito.rut, \r\n                                        notacredito.digito, \r\n                                        notacredito.razonSocial,\r\n                                        notacredito.direccion, \r\n                                        notacredito.comuna, \r\n                                        notacredito.ciudad, \r\n                                        notacredito.giro, \r\n                                        notacredito.fono, \r\n                                        notacredito.fax, \r\n                                        notacredito.contacto, \r\n                                        notacredito.diasPlazo, \r\n                                        notacredito.idMedioPago,                          \r\n                                        notacredito.medioPago, \r\n                                        notacredito.idVendedor, \r\n                                        notacredito.vendedor, \r\n                                        notacredito.idCentroCosto, \r\n                                        notacredito.centroCosto, \r\n                                        notacredito.folioFactura, \r\n                                        notacredito.subtotal, \r\n                                        notacredito.porcentajeDescuento,\r\n                                        notacredito.descuento, \r\n                                        notacredito.porcentajeIva, \r\n                                        notacredito.iva, \r\n                                        notacredito.neto, \r\n                                        notacredito.total, \r\n                                        notacredito.totalPalabras, \r\n                                        notacredito.estadoPago, \r\n                                        notacredito.estadoDocumento,\r\n                                        notacredito.totalPagado,\r\n                                        notacredito.totalDocumentado,\r\n                                        notacredito.totalPendiente,\r\n                                        notacredito.descuentaInventario,         \r\n                                        notacredito.impuesto1,\r\n                                        notacredito.impuesto2,\r\n                                        notacredito.impuesto3,\r\n                                        notacredito.impuesto4,\r\n                                        notacredito.impuesto5,\r\n                                        notacredito.porcentajeImpuesto1,\r\n                                        notacredito.porcentajeImpuesto2,\r\n                                        notacredito.porcentajeImpuesto3,\r\n                                        notacredito.porcentajeImpuesto4,\r\n                                        notacredito.porcentajeImpuesto5,\r\n                                        notacredito.comisionVendedor,\r\n                                        notacredito.caja,\r\n                                        notacredito.idTipo,\r\n                                        notacredito.tipoNotaCredito,\r\n                                        notacredito.montoUsado,\r\n                                        detallenotacredito.idDetalleNotaCredito,\r\n                                        detallenotacredito.idNotaCreditoLinea,\r\n                                        detallenotacredito.folioNotaCredito,\r\n                                        detallenotacredito.fechaIngreso,\r\n                                        detallenotacredito.codigo,\r\n                                        detallenotacredito.descripcion,\r\n                                        detallenotacredito.valorVenta,\r\n                                        detallenotacredito.cantidad,\r\n                                        detallenotacredito.porcentajeDescuentoLinea,\r\n                                        detallenotacredito.descuentoLinea,\r\n                                        detallenotacredito.subtotalLinea, \r\n                                        detallenotacredito.totalLinea, \r\n                                        detallenotacredito.tipoDescuento, \r\n                                        detallenotacredito.listaPrecio, \r\n                                        detallenotacredito.bodega,                            \r\n                                        detallenotacredito.idImpuesto, \r\n                                        detallenotacredito.netoLinea,\r\n                                        detallenotacredito.valorCompra\r\n\r\n                            FROM notacredito INNER JOIN detallenotacredito \r\n                            ON notacredito.idNotaCredito = detallenotacredito.idNotaCreditoLinea WHERE notacredito.folio=@folio ORDER BY detallenotacredito.idDetalleNotaCredito";
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
        return (DataTable) null;
      }
      return dataTable;
    }

    public DataTable notaCreditoInforme(string filtro)
    {
      string str = "SELECT \r\n                                        notacredito.idNotaCredito,\r\n                                        notacredito.folio,\r\n                                        notacredito.fechaEmision,\r\n                                        notacredito.fechaVencimiento,\r\n                                        notacredito.dia,\r\n                                        notacredito.mes,\r\n                                        notacredito.ano,\r\n                                        notacredito.idCliente, \r\n                                        notacredito.rut, \r\n                                        notacredito.digito, \r\n                                        notacredito.razonSocial,\r\n                                        notacredito.direccion, \r\n                                        notacredito.comuna, \r\n                                        notacredito.ciudad, \r\n                                        notacredito.giro, \r\n                                        notacredito.fono, \r\n                                        notacredito.fax, \r\n                                        notacredito.contacto, \r\n                                        notacredito.diasPlazo, \r\n                                        notacredito.idMedioPago,                          \r\n                                        notacredito.medioPago, \r\n                                        notacredito.idVendedor, \r\n                                        notacredito.vendedor, \r\n                                        notacredito.idCentroCosto, \r\n                                        notacredito.centroCosto, \r\n                                        notacredito.folioFactura, \r\n                                        notacredito.subtotal, \r\n                                        notacredito.porcentajeDescuento,\r\n                                        notacredito.descuento, \r\n                                        notacredito.porcentajeIva, \r\n                                        notacredito.iva, \r\n                                        notacredito.neto, \r\n                                        notacredito.total, \r\n                                        notacredito.totalPalabras, \r\n                                        notacredito.estadoPago, \r\n                                        notacredito.estadoDocumento,\r\n                                        notacredito.totalPagado,\r\n                                        notacredito.totalDocumentado,\r\n                                        notacredito.totalPendiente,\r\n                                        notacredito.descuentaInventario,         \r\n                                        notacredito.impuesto1,\r\n                                        notacredito.impuesto2,\r\n                                        notacredito.impuesto3,\r\n                                        notacredito.impuesto4,\r\n                                        notacredito.impuesto5,\r\n                                        notacredito.porcentajeImpuesto1,\r\n                                        notacredito.porcentajeImpuesto2,\r\n                                        notacredito.porcentajeImpuesto3,\r\n                                        notacredito.porcentajeImpuesto4,\r\n                                        notacredito.porcentajeImpuesto5,\r\n                                        notacredito.comisionVendedor,\r\n                                        notacredito.caja,\r\n                                        notacredito.idTipo,\r\n                                        notacredito.tipoNotaCredito,\r\n                                        notacredito.montoUsado,\r\n                                        (total-montoUsado) AS 'montoDisponible'                                                                                    \r\n                                FROM notacredito                             \r\n                                WHERE " + filtro + " ORDER BY notacredito.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable notaCreditoInformeDetalle(string filtro)
    {
      string str = "SELECT \r\n                                        notacredito.idNotaCredito,\r\n                                        notacredito.folio,\r\n                                        notacredito.fechaEmision,\r\n                                        notacredito.fechaVencimiento,\r\n                                        notacredito.dia,\r\n                                        notacredito.mes,\r\n                                        notacredito.ano,\r\n                                        notacredito.idCliente, \r\n                                        notacredito.rut, \r\n                                        notacredito.digito, \r\n                                        notacredito.razonSocial,\r\n                                        notacredito.direccion, \r\n                                        notacredito.comuna, \r\n                                        notacredito.ciudad, \r\n                                        notacredito.giro, \r\n                                        notacredito.fono, \r\n                                        notacredito.fax, \r\n                                        notacredito.contacto, \r\n                                        notacredito.diasPlazo, \r\n                                        notacredito.idMedioPago,                          \r\n                                        notacredito.medioPago, \r\n                                        notacredito.idVendedor, \r\n                                        notacredito.vendedor, \r\n                                        notacredito.idCentroCosto, \r\n                                        notacredito.centroCosto, \r\n                                        notacredito.folioFactura, \r\n                                        notacredito.subtotal, \r\n                                        notacredito.porcentajeDescuento,\r\n                                        notacredito.descuento, \r\n                                        notacredito.porcentajeIva, \r\n                                        notacredito.iva, \r\n                                        notacredito.neto, \r\n                                        notacredito.total, \r\n                                        notacredito.totalPalabras, \r\n                                        notacredito.estadoPago, \r\n                                        notacredito.estadoDocumento,\r\n                                        notacredito.totalPagado,\r\n                                        notacredito.totalDocumentado,\r\n                                        notacredito.totalPendiente,\r\n                                        notacredito.descuentaInventario,         \r\n                                        notacredito.impuesto1,\r\n                                        notacredito.impuesto2,\r\n                                        notacredito.impuesto3,\r\n                                        notacredito.impuesto4,\r\n                                        notacredito.impuesto5,\r\n                                        notacredito.porcentajeImpuesto1,\r\n                                        notacredito.porcentajeImpuesto2,\r\n                                        notacredito.porcentajeImpuesto3,\r\n                                        notacredito.porcentajeImpuesto4,\r\n                                        notacredito.porcentajeImpuesto5,\r\n                                        notacredito.comisionVendedor,\r\n                                        notacredito.caja,\r\n                                        detallenotacredito.idDetalleNotaCredito,\r\n                                        detallenotacredito.idNotaCreditoLinea,\r\n                                        detallenotacredito.folioNotaCredito,\r\n                                        detallenotacredito.fechaIngreso,\r\n                                        detallenotacredito.codigo,\r\n                                        detallenotacredito.descripcion,\r\n                                        detallenotacredito.valorVenta,\r\n                                        detallenotacredito.cantidad,\r\n                                        detallenotacredito.porcentajeDescuentoLinea,\r\n                                        detallenotacredito.descuentoLinea,\r\n                                        detallenotacredito.subtotalLinea, \r\n                                        detallenotacredito.totalLinea, \r\n                                        detallenotacredito.tipoDescuento, \r\n                                        detallenotacredito.listaPrecio, \r\n                                        detallenotacredito.bodega,                            \r\n                                        detallenotacredito.idImpuesto, \r\n                                        detallenotacredito.netoLinea,\r\n                                        detallenotacredito.valorCompra\r\n                                        FROM notacredito INNER JOIN detallenotacredito \r\n                                        ON notacredito.idNotaCredito = detalleNotaCredito.idNotaCreditoLinea                                                            \r\n                                WHERE " + filtro + " ORDER BY notacredito.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
