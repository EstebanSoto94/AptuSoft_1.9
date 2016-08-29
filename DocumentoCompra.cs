 
// Type: Aptusoft.DocumentoCompra
 
 
// version 1.8.0

using Aptusoft.Lotes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class DocumentoCompra
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaCompra(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO compras (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idProveedor,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            idMedioPago,\r\n                                                            medioPago,                                                                                                                        \r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            idTipoDocumentoCompra,\r\n                                                            tipoDocumentoCompra,\r\n                                                            folioFacturaNC,\r\n                                                            otrosImpuestos,\r\n                                                            totalExento,\r\n                                                            totalCobrar,\r\n                                                            idPeriodo,\r\n                                                            periodo,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            codImpuesto1,\r\n                                                            codImpuesto2,\r\n                                                            codImpuesto3,\r\n                                                            codImpuesto4,\r\n                                                            codImpuesto5\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idProveedor,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,                                                            \r\n                                                            @idMedioPago,\r\n                                                            @medioPago,                                                                                                                        \r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,\r\n                                                            @idTipoDocumentoCompra,\r\n                                                            @tipoDocumentoCompra,\r\n                                                            @folioFacturaNC,\r\n                                                            @otrosImpuestos,\r\n                                                            @totalExento,\r\n                                                            @totalCobrar,\r\n                                                            @idPeriodo,\r\n                                                            @periodo,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @codImpuesto1,\r\n                                                            @codImpuesto2,\r\n                                                            @codImpuesto3,\r\n                                                            @codImpuesto4,\r\n                                                            @codImpuesto5\r\n                                                   )";
        command.Parameters.AddWithValue("@folio", (object) veOB.FolioIngresoCompra);
        command.Parameters.AddWithValue("@fechaEmision", (object) veOB.FechaEmision);
        command.Parameters.AddWithValue("@fechaVencimiento", (object) veOB.FechaVencimiento);
        command.Parameters.AddWithValue("@dia", (object) veOB.FechaEmision.Day.ToString());
        command.Parameters.AddWithValue("@mes", (object) string.Format("{0:MMMM}", (object) veOB.FechaEmision).ToString().ToUpper());
        command.Parameters.AddWithValue("@ano", (object) veOB.FechaEmision.Year.ToString());
        command.Parameters.AddWithValue("@idProveedor", (object) veOB.IdCliente);
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
        command.Parameters.AddWithValue("@idMedioPago", (object) veOB.IdMedioPago);
        command.Parameters.AddWithValue("@medioPago", (object) veOB.MedioPago);
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
        command.Parameters.AddWithValue("@idTipoDocumentoCompra", (object) veOB.IdTipoDocumentoCompra);
        command.Parameters.AddWithValue("@tipoDocumentoCompra", (object) veOB.TipoDocumentoCompra);
        command.Parameters.AddWithValue("@folioFacturaNC", (object) veOB.FolioFacturaNC);
        command.Parameters.AddWithValue("@otrosImpuestos", (object) veOB.OtrosImpuestos);
        command.Parameters.AddWithValue("@totalExento", (object) veOB.TotalExento);
        command.Parameters.AddWithValue("@totalCobrar", (object) veOB.TotalaCobrar);
        command.Parameters.AddWithValue("@idPeriodo", (object) veOB.IdPeriodo);
        command.Parameters.AddWithValue("@periodo", (object) veOB.Periodo);
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
        command.Parameters.AddWithValue("@codImpuesto1", (object) veOB.CodImpuesto1);
        command.Parameters.AddWithValue("@codImpuesto2", (object) veOB.CodImpuesto2);
        command.Parameters.AddWithValue("@codImpuesto3", (object) veOB.CodImpuesto3);
        command.Parameters.AddWithValue("@codImpuesto4", (object) veOB.CodImpuesto4);
        command.Parameters.AddWithValue("@codImpuesto5", (object) veOB.CodImpuesto5);
        ((DbCommand) command).ExecuteNonQuery();
        return "Compra Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleCompra(List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      int num1 = 0;
      long num2 = 0L;
      string str = "";
      int num3 = 0;
      foreach (DatosVentaVO veVO in lista)
      {
        if (num1 == 0)
        {
          num1 = this.retornaIdCompra(veVO.FolioIngresoCompra, veVO.TipoDocumentoCompra, veVO.RutProveedor);
          num2 = veVO.FolioIngresoCompra;
          str = veVO.TipoDocumentoCompra;
          num3 = veVO.IdTipoDocumentoCompra;
        }
        if (veVO.IdTipoDocumentoCompra != 7 && veVO.IdTipoDocumentoCompra != 8)
        {
          this.modificaValorUltimaCompra(veVO);
          Decimal num4 = this.consultaStock(veVO);
          veVO.StockQueda = num4 + veVO.Cantidad;
          this.actualizaStock(veVO, "+");
        }
        else
        {
          Decimal num4 = this.consultaStock(veVO);
          veVO.StockQueda = num4 - veVO.Cantidad;
          this.actualizaStock(veVO, "-");
        }
        veVO.IdFactura = num1;
        this.agregaDetalleCompra2(veVO);
      }
      if (listaLote.Count <= 0)
        return;
      foreach (LoteVO loteVo in listaLote)
      {
        loteVo.Documento = str;
        loteVo.IdDocumento = num1;
        loteVo.FolioDocumento = num2;
        loteVo.TipoDocumento = "COMPRA";
        int num4 = num3 == 4 ? 1 : (num3 == 6 ? 1 : 0);
        loteVo.Accion = num4 != 0 ? "SALE" : "INGRESA";
      }
      new Lote().RegistraLote(listaLote);
    }

    public void agregaDetalleCompra2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura;
      if (num == 0)
        num = this.retornaIdCompra(veVO.FolioIngresoCompra, veVO.TipoDocumentoCompra, veVO.RutProveedor);
      ((DbCommand) command).CommandText = "INSERT INTO detallecompra (\r\n                                                            idCompraLinea,\r\n                                                            folioCompra,\r\n                                                            fechaIngreso,\r\n                                                            rutProveedor,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,                                                            \r\n                                                            bodega,\r\n                                                            idTipoDocumentoCompraLinea,\r\n                                                            tipoDocumentoCompraLinea,\r\n                                                            usuario,\r\n                                                            stockQueda,\r\n                                                            exento\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idCompraLinea,\r\n                                                            @folioCompraLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @rutProveedor,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,                                                            \r\n                                                            @bodega,\r\n                                                            @idTipoDocumentoCompraLinea,\r\n                                                            @tipoDocumentoCompraLinea,\r\n                                                            @usuario,\r\n                                                            @stockQueda,\r\n                                                            @exento\r\n                                                             )";
      command.Parameters.AddWithValue("@idCompraLinea", (object) num);
      command.Parameters.AddWithValue("@folioCompraLinea", (object) veVO.FolioIngresoCompra);
      command.Parameters.AddWithValue("@fechaIngreso", (object) DateTime.Now.AddSeconds(40.0));
      command.Parameters.AddWithValue("@rutProveedor", (object) veVO.RutProveedor);
      command.Parameters.AddWithValue("@codigo", (object) veVO.Codigo);
      command.Parameters.AddWithValue("@descripcion", (object) veVO.Descripcion);
      command.Parameters.AddWithValue("@valorVenta", (object) veVO.ValorVenta);
      command.Parameters.AddWithValue("@cantidad", (object) veVO.Cantidad);
      command.Parameters.AddWithValue("@porcentajeDescuentoLinea", (object) veVO.PorcDescuento);
      command.Parameters.AddWithValue("@descuentoLinea", (object) veVO.Descuento);
      command.Parameters.AddWithValue("@subtotalLinea", (object) veVO.SubTotalLinea);
      command.Parameters.AddWithValue("@totalLinea", (object) veVO.TotalLinea);
      command.Parameters.AddWithValue("@tipoDescuento", (object) veVO.TipoDescuento);
      command.Parameters.AddWithValue("@bodega", (object) veVO.Bodega);
      command.Parameters.AddWithValue("@idTipoDocumentoCompraLinea", (object) veVO.IdTipoDocumentoCompra);
      command.Parameters.AddWithValue("@tipoDocumentoCompraLinea", (object) veVO.TipoDocumentoCompra);
      command.Parameters.AddWithValue("@usuario", (object) veVO.Usuario);
      command.Parameters.AddWithValue("@stockQueda", (object) veVO.StockQueda);
      command.Parameters.AddWithValue("@exento", (veVO.Exento ? 1 : 0));
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

    public bool compraExiste(long numFactura, string rut, string tipoDoc)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM compras WHERE folio=@numFactura AND rut=@rut AND tipoDocumentoCompra=@tipoDoc";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      command.Parameters.AddWithValue("@rut", (object) rut);
      command.Parameters.AddWithValue("@tipoDoc", (object) tipoDoc);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int retornaIdCompra(long numFactura, string tipoDoc, string rut)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idCompra, folio FROM compras WHERE folio=@numFactura AND tipoDocumentoCompra=@tipoDoc AND rut=@rut";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      command.Parameters.AddWithValue("@tipoDoc", (object) tipoDoc);
      command.Parameters.AddWithValue("@rut", (object) rut);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int eliminaCompra(int idCompra, List<DatosVentaVO> lista, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE compras, detallecompra FROM compras, detallecompra WHERE compras.idCompra = @idCompra AND detallecompra.idcompraLinea=@idCompra";
      command.Parameters.AddWithValue("@idCompra", (object) idCompra);
      int num = ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.IdTipoDocumentoCompra != 7 && datosVentaVo.IdTipoDocumentoCompra != 8)
        {
          new ControlProducto().registroDocumentoNuloNotaCredito(datosVentaVo, datosVentaVo.TipoDocumentoCompra);
          this.actualizaStock(datosVentaVo, "-");
        }
        else
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, datosVentaVo.TipoDocumentoCompra);
          this.actualizaStock(datosVentaVo, "+");
        }
      }
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      return num;
    }

    private void registroCompraElimina(DatosVentaVO vevo)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = string.Concat(new object[4]
      {
        (object) "ELIMINA ",
        (object) vevo.TipoDocumentoCompra,
        (object) " FOLIO: ",
        (object) vevo.FolioIngresoCompra
      });
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = num - vevo.Cantidad;
      controlProducto.agregaControlProducto(cp);
    }

    private void registroNotaCreditoCompraElimina(DatosVentaVO vevo)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ELIMINA NOTA DE CREDITO COMPRA FOLIO: " + (object) vevo.FolioIngresoCompra;
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = num + vevo.Cantidad;
      controlProducto.agregaControlProducto(cp);
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

    public void modificaValorUltimaCompra(DatosVentaVO veVO)
    {
      Decimal num1 = new Decimal(0);
      Decimal num2 = !(veVO.Descuento > new Decimal(0)) ? veVO.ValorVenta : veVO.TotalLinea / veVO.Cantidad;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE productos SET ValorCompra=@v_compra WHERE Codigo=@Codigo";
      command.Parameters.AddWithValue("@v_compra", (object) num2);
      command.Parameters.AddWithValue("@Codigo", (object) veVO.Codigo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void calculaPPP(DatosVentaVO veVO)
    {
      Decimal num1 = new Decimal(0);
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                        Bodega1+Bodega2+Bodega3+Bodega4+Bodega5+Bodega6+Bodega7+Bodega8+Bodega9+Bodega10 as 'STOCK',\r\n                                        ValorCompra\r\n                                    FROM productos WHERE Codigo=@Cod";
      command.Parameters.AddWithValue("@Cod", (object) veVO.Codigo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        num1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["STOCK"].ToString());
        num2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorCompra"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      Decimal num5 = (num2 * num1 + veVO.Cantidad * veVO.ValorVenta) / (veVO.Cantidad + num1);
      ((DbCommand) command).CommandText = "UPDATE productos SET ValorCompra=@ppp WHERE Codigo=@Cod2";
      command.Parameters.AddWithValue("@ppp", (object) num5);
      command.Parameters.AddWithValue("@Cod2", (object) veVO.Codigo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public Venta buscaCompraID(int idCompra)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idCompra,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idProveedor,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,                                                            \r\n                                                            idMedioPago,\r\n                                                            medioPago,                                                            \r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            idTipoDocumentoCompra,\r\n                                                            tipoDocumentoCompra,\r\n                                                            folioFacturaNC,\r\n                                                            otrosImpuestos,\r\n                                                            totalExento,\r\n                                                            totalCobrar,\r\n                                                            idPeriodo,\r\n                                                            periodo,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            codImpuesto1,\r\n                                                            codImpuesto2,\r\n                                                            codImpuesto3,\r\n                                                            codImpuesto4,\r\n                                                            codImpuesto5\r\n                                        FROM compras WHERE idCompra=@idCompra";
      command.Parameters.AddWithValue("@idCompra", (object) idCompra);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCompra"]);
        venta.FolioIngresoCompra = Convert.ToInt64(((DbDataReader) mySqlDataReader)["folio"]);
        venta.FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]);
        venta.FechaVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaVencimiento"]);
        venta.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idProveedor"]);
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
        venta.IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"]);
        venta.MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString();
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
        venta.IdTipoDocumentoCompra = Convert.ToInt32(((DbDataReader) mySqlDataReader)["IdTipoDocumentoCompra"].ToString());
        venta.TipoDocumentoCompra = ((DbDataReader) mySqlDataReader)["tipoDocumentoCompra"].ToString();
        venta.FolioFacturaNC = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioFacturaNC"].ToString());
        venta.OtrosImpuestos = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["otrosImpuestos"]);
        venta.TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]);
        venta.TotalaCobrar = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalCobrar"]);
        venta.IdPeriodo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPeriodo"].ToString());
        venta.Periodo = ((DbDataReader) mySqlDataReader)["periodo"].ToString();
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
        venta.CodImpuesto1 = ((DbDataReader) mySqlDataReader)["codImpuesto1"].ToString();
        venta.CodImpuesto2 = ((DbDataReader) mySqlDataReader)["codImpuesto2"].ToString();
        venta.CodImpuesto3 = ((DbDataReader) mySqlDataReader)["codImpuesto3"].ToString();
        venta.CodImpuesto4 = ((DbDataReader) mySqlDataReader)["codImpuesto4"].ToString();
        venta.CodImpuesto5 = ((DbDataReader) mySqlDataReader)["codImpuesto5"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public DataTable listaDocumentoCompra(DateTime desde, DateTime hasta, string tipoDoc, long folio, string proveedor)
    {
      DataTable dataTable1 = new DataTable();
      string str1 = !tipoDoc.Equals("[TODOS]") ? " AND tipoDocumentoCompra='" + tipoDoc + "'" : "";
      string str2 = folio != 0L ? " AND folio='" + (object) folio + "'" : "";
      string str3 = proveedor.Length != 0 ? " AND razonSocial='" + proveedor + "'" : "";
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT idCompra, tipoDocumentoCompra, folio, fechaEmision, rut, digito, razonSocial, total, estadoPago, totalPagado, totalPendiente, totalDocumentado FROM compras\r\n                                    WHERE DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= DATE_FORMAT(@desde, '%Y-%m-%d') AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= DATE_FORMAT(@hasta, '%Y-%m-%d') " + str2 + str1 + str3 + " ORDER BY fechaEmision DESC";
        command.Parameters.AddWithValue("@desde", (object) desde);
        command.Parameters.AddWithValue("@hasta", (object) hasta);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable1);
      }
      catch (Exception ex)
      {
        DataTable dataTable2;
        return dataTable2 = (DataTable) null;
      }
      return dataTable1;
    }

    public DataTable listaDocumentoCompraPago(DateTime desde, DateTime hasta, string estadoDoc, long folio, string proveedor)
    {
      string str1 = !estadoDoc.Equals("[TODOS]") ? " AND estadoPago='" + estadoDoc + "'" : "";
      string str2;
      string str3;
      if (folio == 0L)
      {
        str2 = "";
        str3 = "";
      }
      else
      {
        str2 = " AND folio='" + (object) folio + "'";
        str3 = " AND folioServicio='" + (object) folio + "'";
      }
      string str4 = proveedor.Length != 0 ? " AND razonSocial='" + proveedor + "'" : "";
      DataTable dataTable1 = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT idCompra, tipoDocumentoCompra, folio, fechaEmision, rut, digito, razonSocial, totalCobrar, estadoPago, totalPagado, totalPendiente, totalDocumentado FROM compras\r\n                                    WHERE DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= DATE_FORMAT(@desde, '%Y-%m-%d') AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= DATE_FORMAT(@hasta, '%Y-%m-%d') " + str2 + str1 + str4 + " AND (idTipoDocumentoCompra=1 OR idTipoDocumentoCompra=5) ORDER BY fechaEmision DESC";
        command.Parameters.AddWithValue("@desde", (object) desde);
        command.Parameters.AddWithValue("@hasta", (object) hasta);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable1);
        ((DbCommand) command).CommandText = "SELECT idServicio as 'idCompra', 'SERVICIO' as 'tipoDocumentoCompra', folioServicio AS 'folio', fechaIngreso as 'fechaEmision', rut, digito, razonSocial, total AS 'totalCobrar', estadoPago, totalPagado, totalPendiente, totalDocumentado FROM servicio\r\n                                    WHERE DATE_FORMAT(fechaIngreso, '%Y-%m-%d') >= DATE_FORMAT(@desde2, '%Y-%m-%d') AND DATE_FORMAT(fechaIngreso, '%Y-%m-%d') <= DATE_FORMAT(@hasta2, '%Y-%m-%d') " + str3 + str1 + str4 + " ORDER BY fechaIngreso DESC";
        command.Parameters.AddWithValue("@desde2", (object) desde);
        command.Parameters.AddWithValue("@hasta2", (object) hasta);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable1);
      }
      catch (Exception ex)
      {
        DataTable dataTable2;
        return dataTable2 = (DataTable) null;
      }
      return dataTable1;
    }

    public List<DatosVentaVO> buscaDetalleCompraIDCompra(int idCompra)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleCompra, \r\n                                                    idCompraLinea,\r\n                                                    folioCompra,\r\n                                                    fechaIngreso,\r\n                                                    rutProveedor,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,                                                    \r\n                                                    bodega,\r\n                                                    idTipoDocumentoCompraLinea,\r\n                                                    tipoDocumentoCompraLinea,\r\n                                                    exento,stockQueda\r\n                                                    \r\n                                                    FROM detallecompra WHERE idCompraLinea = @idCompra ORDER BY idDetalleCompra asc";
      command.Parameters.AddWithValue("@idCompra", (object) idCompra);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleCompra"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCompraLinea"]),
          FolioIngresoCompra = Convert.ToInt64(((DbDataReader) mySqlDataReader)["folioCompra"]),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          RutProveedor = ((DbDataReader) mySqlDataReader)["rutProveedor"].ToString(),
          Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"]),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"]),
          PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuentoLinea"]),
          Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoLinea"]),
          SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"]),
          TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"]),
          TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"]),
          Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"]),
          IdTipoDocumentoCompra = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoDocumentoCompraLinea"]),
          TipoDocumentoCompra = ((DbDataReader) mySqlDataReader)["tipoDocumentoCompraLinea"].ToString(),
          Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]),
          StockQueda = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQueda"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaCompra(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
          string fechaemision = veOB.FechaEmision.ToString("yyyy-MM-dd HH:mm:ss");
        ((DbCommand) command).CommandText = "UPDATE compras SET fechaEmision=@fechaEmision, fechaVencimiento=@fechaVencimiento, dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idProveedor=@idProveedor,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,                                                            \r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,                                                            \r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            folioFacturaNC=@folioFacturaNC,\r\n                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,                                                            \r\n                                                            otrosImpuestos=@otrosImpuestos,\r\n                                                            totalExento=@totalExento,\r\n                                                            totalCobrar=@totalCobrar,\r\n\r\n                                                            idPeriodo=@idPeriodo,\r\n                                                            periodo=@periodo,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            codImpuesto1=@codImpuesto1,\r\n                                                            codImpuesto2=@codImpuesto2,\r\n                                                            codImpuesto3=@codImpuesto3,\r\n                                                            codImpuesto4=@codImpuesto4,\r\n                                                            codImpuesto5=@codImpuesto5  \r\n                                           WHERE idCompra=@idCompra AND folio=@folio AND idTipoDocumentoCompra=@idTipoDocumentoCompra";
        command.Parameters.AddWithValue("@idCompra", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folio", (object) veOB.FolioIngresoCompra);
        command.Parameters.AddWithValue("@fechaEmision", fechaemision);
        command.Parameters.AddWithValue("@fechaVencimiento", (object) veOB.FechaVencimiento);
        command.Parameters.AddWithValue("@dia", (object) veOB.FechaEmision.Day.ToString());
        command.Parameters.AddWithValue("@mes", (object) string.Format("{0:MMMM}", (object) veOB.FechaEmision).ToString().ToUpper());
        command.Parameters.AddWithValue("@ano", (object) veOB.FechaEmision.Year.ToString());
        command.Parameters.AddWithValue("@idProveedor", (object) veOB.IdCliente);
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
        command.Parameters.AddWithValue("@idMedioPago", (object) veOB.IdMedioPago);
        command.Parameters.AddWithValue("@medioPago", (object) veOB.MedioPago);
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
        command.Parameters.AddWithValue("@idTipoDocumentoCompra", (object) veOB.IdTipoDocumentoCompra);
        command.Parameters.AddWithValue("@folioFacturaNC", (object) veOB.FolioFacturaNC);
        command.Parameters.AddWithValue("@otrosImpuestos", (object) veOB.OtrosImpuestos);
        command.Parameters.AddWithValue("@totalExento", (object) veOB.TotalExento);
        command.Parameters.AddWithValue("@totalCobrar", (object) veOB.TotalaCobrar);
        command.Parameters.AddWithValue("@idPeriodo", (object) veOB.IdPeriodo);
        command.Parameters.AddWithValue("@periodo", (object) veOB.Periodo);
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
        command.Parameters.AddWithValue("@codImpuesto1", (object) veOB.CodImpuesto1);
        command.Parameters.AddWithValue("@codImpuesto2", (object) veOB.CodImpuesto2);
        command.Parameters.AddWithValue("@codImpuesto3", (object) veOB.CodImpuesto3);
        command.Parameters.AddWithValue("@codImpuesto4", (object) veOB.CodImpuesto4);
        command.Parameters.AddWithValue("@codImpuesto5", (object) veOB.CodImpuesto5);
        ((DbCommand) command).ExecuteNonQuery();
        foreach (DatosVentaVO datosVentaVo in this.buscaDetalleCompraIDCompra(veOB.IdFactura))
        {
            if (datosVentaVo.IdTipoDocumentoCompra != 7 && datosVentaVo.IdTipoDocumentoCompra != 8)
          {
            new ControlProducto().registroDocumentoModificaNotaCredito(datosVentaVo, datosVentaVo.TipoDocumentoCompra);
            new ControlProducto().registroDocumentoModificaRetornaInventarioNC(datosVentaVo, datosVentaVo.TipoDocumentoCompra);
            this.actualizaStock(datosVentaVo, "-");
          }
          else
          {
            new ControlProducto().registroDocumentoModifica(datosVentaVo, datosVentaVo.TipoDocumentoCompra);
            new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, datosVentaVo.TipoDocumentoCompra);
            this.actualizaStock(datosVentaVo, "+");
          }
        }
        this.eliminaDetalleCompra(veOB);
        if (listaLoteAntigua.Count > 0)
        {
          foreach (LoteVO loteVo in listaLoteAntigua)
            new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
        }
        foreach (DatosVentaVO veVO in listaNueva)
        {
          if (veVO.IdTipoDocumentoCompra != 7 && veVO.IdTipoDocumentoCompra != 8)
          {
            Decimal num = this.consultaStock(veVO);
            veVO.StockQueda = num + veVO.Cantidad;
            this.actualizaStock(veVO, "+");
          }
          else
          {
            Decimal num = this.consultaStock(veVO);
            veVO.StockQueda = num - veVO.Cantidad;
            this.actualizaStock(veVO, "-");
          }
          veVO.FechaIngreso = veVO.FechaIngreso.AddSeconds(40.0);
          veVO.IdFactura = veOB.IdFactura;
          this.agregaDetalleCompra2(veVO);
        }
        if (listaLote.Count > 0)
        {
          int idFactura = veOB.IdFactura;
          long folioIngresoCompra = veOB.FolioIngresoCompra;
          string tipoDocumentoCompra1 = veOB.TipoDocumentoCompra;
          int tipoDocumentoCompra2 = veOB.IdTipoDocumentoCompra;
          foreach (LoteVO loteVo in listaLote)
          {
            loteVo.Documento = tipoDocumentoCompra1;
            loteVo.IdDocumento = idFactura;
            loteVo.FolioDocumento = folioIngresoCompra;
            loteVo.TipoDocumento = "COMPRA";
            int num = tipoDocumentoCompra2 == 7 ? 1 : (tipoDocumentoCompra2 == 8 ? 1 : 0);
            loteVo.Accion = num != 0 ? "SALE" : "INGRESA";
          }
          new Lote().RegistraLote(listaLote);
        }
        return "Compra Modificada";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool eliminaDetalleCompra(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detallecompra WHERE idCompraLinea=@idCompra AND folioCompra=@folioCompra";
        command.Parameters.AddWithValue("@idCompra", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioCompra", (object) veOB.FolioIngresoCompra);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public DataTable muestraCompraID(int idCompra)
    {
      string str = "SELECT  \r\n                                        compras.idCompra,\r\n                                        compras.folio,\r\n                                        compras.fechaEmision,\r\n                                        compras.fechaVencimiento,\r\n                                        compras.dia,\r\n                                        compras.mes,\r\n                                        compras.ano,\r\n                                        compras.idProveedor,\r\n                                        compras.rut,\r\n                                        compras.digito,\r\n                                        compras.razonSocial,\r\n                                        compras.direccion,\r\n                                        compras.comuna,\r\n                                        compras.ciudad,\r\n                                        compras.giro,\r\n                                        compras.fono,\r\n                                        compras.fax,\r\n                                        compras.contacto,\r\n                                        compras.diasPlazo,\r\n                                        compras.idMedioPago,\r\n                                        compras.medioPago,\r\n                                        compras.idCentroCosto,\r\n                                        compras.centroCosto,\r\n                                        compras.ordenCompra,\r\n                                        compras.subtotal,\r\n                                        compras.porcentajeDescuento,\r\n                                        compras.descuento,\r\n                                        compras.porcentajeIva,\r\n                                        compras.iva,\r\n                                        compras.neto,\r\n                                        compras.total,\r\n                                        compras.totalPalabras,\r\n                                        compras.estadoPago,\r\n                                        compras.estadoDocumento,\r\n                                        compras.totalPagado,\r\n                                        compras.totalDocumentado,\r\n                                        compras.totalPendiente,\r\n                                        compras.idTipoDocumentoCompra,\r\n                                        compras.tipoDocumentoCompra,\r\n                                        compras.otrosImpuestos,\r\n                                        compras.totalExento,\r\n                                        compras.totalCobrar,\r\n                                        compras.idPeriodo,\r\n                                        compras.periodo,\r\n                                        compras.impuesto1,\r\n                                        compras.impuesto2,\r\n                                        compras.impuesto3,\r\n                                        compras.impuesto4,\r\n                                        compras.impuesto5,\r\n                                        compras.porcentajeImpuesto1,\r\n                                        compras.porcentajeImpuesto2,\r\n                                        compras.porcentajeImpuesto3,\r\n                                        compras.porcentajeImpuesto4,\r\n                                        compras.porcentajeImpuesto5,\r\n                                        compras.codImpuesto1,\r\n                                        compras.codImpuesto2,\r\n                                        compras.codImpuesto3,\r\n                                        compras.codImpuesto4,\r\n                                        compras.codImpuesto5,\r\n                                        detallecompra.idDetallecompra,\r\n                                        detallecompra.idCompraLinea,\r\n                                        detallecompra.rutProveedor,\r\n                                        detallecompra.folioCompra,\r\n                                        detallecompra.fechaIngreso,\r\n                                        detallecompra.codigo,\r\n                                        detallecompra.descripcion,\r\n                                        detallecompra.valorVenta,\r\n                                        detallecompra.cantidad,\r\n                                        detallecompra.porcentajeDescuentoLinea,\r\n                                        detallecompra.descuentoLinea,\r\n                                        detallecompra.subtotalLinea,\r\n                                        detallecompra.totalLinea,\r\n                                        detallecompra.tipoDescuento,\r\n                                        detallecompra.bodega,\r\n                                        detallecompra.idTipoDocumentoCompraLinea,\r\n                                        detallecompra.tipoDocumentoCompraLinea\r\n                                        FROM compras INNER JOIN detallecompra \r\n                                        ON compras.idCompra = detallecompra.idCompraLinea AND compras.folio = detallecompra.folioCompra\r\n                                        WHERE compras.idCompra=@idCompra";
      DataTable dataTable = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        command.Parameters.AddWithValue("@idCompra", (object) idCompra);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      catch (Exception ex)
      {
      }
      return dataTable;
    }

    public DataTable compraInforme(string filtro)
    {
      string str = "SELECT \r\n                                        compras.idCompra,\r\n                                        compras.folio,\r\n                                        compras.fechaEmision,\r\n                                        compras.fechaVencimiento,\r\n                                        compras.dia,\r\n                                        compras.mes,\r\n                                        compras.ano,\r\n                                        compras.idProveedor,\r\n                                        compras.rut,\r\n                                        compras.digito,\r\n                                        compras.razonSocial,\r\n                                        compras.direccion,\r\n                                        compras.comuna,\r\n                                        compras.ciudad,\r\n                                        compras.giro,\r\n                                        compras.fono,\r\n                                        compras.fax,\r\n                                        compras.contacto,\r\n                                        compras.diasPlazo,\r\n                                        compras.idMedioPago,\r\n                                        compras.medioPago,\r\n                                        compras.idCentroCosto,\r\n                                        compras.centroCosto,\r\n                                        compras.ordenCompra,\r\n                                        compras.subtotal,\r\n                                        compras.porcentajeDescuento,\r\n                                        compras.descuento,\r\n                                        compras.porcentajeIva,\r\n                                        compras.iva,\r\n                                        compras.neto,\r\n                                        compras.total,\r\n                                        compras.totalPalabras,\r\n                                        compras.estadoPago,\r\n                                        compras.estadoDocumento,\r\n                                        compras.totalPagado,\r\n                                        compras.totalDocumentado,\r\n                                        compras.totalPendiente,\r\n                                        compras.idTipoDocumentoCompra,\r\n                                        compras.tipoDocumentoCompra,\r\n                                        compras.otrosImpuestos,\r\n                                        compras.totalExento,\r\n                                        compras.totalCobrar,\r\n                                        compras.impuesto1,\r\n                                        compras.impuesto2,\r\n                                        compras.impuesto3,\r\n                                        compras.impuesto4,\r\n                                        compras.impuesto5,\r\n                                        compras.porcentajeImpuesto1,\r\n                                        compras.porcentajeImpuesto2,\r\n                                        compras.porcentajeImpuesto3,\r\n                                        compras.porcentajeImpuesto4,\r\n                                        compras.porcentajeImpuesto5,\r\n                                        compras.codImpuesto1,\r\n                                        compras.codImpuesto2,\r\n                                        compras.codImpuesto3,\r\n                                        compras.codImpuesto4,\r\n                                        compras.codImpuesto5\r\n                                FROM compras                             \r\n                                WHERE " + filtro + " ORDER BY compras.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable libroCompraInforme(string filtro, string filtroServicio)
    {
      string str1 = "SELECT compras.idCompra, compras.folio, compras.fechaEmision, compras.fechaVencimiento, compras.dia, compras.mes, compras.ano, compras.idProveedor, compras.rut, compras.digito, compras.razonSocial, compras.direccion, compras.comuna, compras.ciudad, compras.giro, compras.fono, compras.fax, compras.contacto, compras.diasPlazo, compras.idMedioPago, compras.medioPago, compras.idCentroCosto, compras.centroCosto, compras.ordenCompra, compras.subtotal, compras.porcentajeDescuento, compras.descuento, compras.porcentajeIva, compras.iva, compras.neto, compras.total, compras.totalPalabras, compras.estadoPago, compras.estadoDocumento, compras.totalPagado, compras.totalDocumentado, compras.totalPendiente, compras.idTipoDocumentoCompra, compras.tipoDocumentoCompra, compras.otrosImpuestos, compras.totalExento, compras.totalCobrar, compras.idPeriodo, compras.periodo, compras.impuesto1, compras.impuesto2, compras.impuesto3, compras.impuesto4, compras.impuesto5, compras.porcentajeImpuesto1, compras.porcentajeImpuesto2, compras.porcentajeImpuesto3, compras.porcentajeImpuesto4, compras.porcentajeImpuesto5, compras.codImpuesto1, compras.codImpuesto2, compras.codImpuesto3, compras.codImpuesto4, compras.codImpuesto5 FROM compras WHERE " + filtro + " ORDER BY compras.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str1;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str2 = "SELECT idServicio, 'GASTOS DE SERVICIOS' as tipoDocumentoCompra, '6' AS idTipoDocumentoCompra, folioServicio AS 'folio', idProveedor, rut, digito, razonSocial, fechaIngreso AS 'fechaEmision', fechaVencimiento,\r\n                                                            neto,\r\n                                                            iva,\r\n                                                            total,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            estadoPago,\r\n                                                            usuario,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idPeriodo,\r\n                                                            periodo                                                                                  \r\n                                FROM servicio                             \r\n                                WHERE " + filtroServicio + " ORDER BY fechaIngreso";
      ((DbCommand) command).CommandText = str2;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
       
      

      return dataTable;
    }

    public DataTable compraInformeDetalle(string filtro)
    {
      string str = "SELECT \r\n                                        compras.idCompra,\r\n                                        compras.folio,\r\n                                        compras.fechaEmision,\r\n                                        compras.fechaVencimiento,\r\n                                        compras.dia,\r\n                                        compras.mes,\r\n                                        compras.ano,\r\n                                        compras.idProveedor,\r\n                                        compras.rut,\r\n                                        compras.digito,\r\n                                        compras.razonSocial,\r\n                                        compras.direccion,\r\n                                        compras.comuna,\r\n                                        compras.ciudad,\r\n                                        compras.giro,\r\n                                        compras.fono,\r\n                                        compras.fax,\r\n                                        compras.contacto,\r\n                                        compras.diasPlazo,\r\n                                        compras.idMedioPago,\r\n                                        compras.medioPago,\r\n                                        compras.idCentroCosto,\r\n                                        compras.centroCosto,\r\n                                        compras.ordenCompra,\r\n                                        compras.subtotal,\r\n                                        compras.porcentajeDescuento,\r\n                                        compras.descuento,\r\n                                        compras.porcentajeIva,\r\n                                        compras.iva,\r\n                                        compras.neto,\r\n                                        compras.total,\r\n                                        compras.totalPalabras,\r\n                                        compras.estadoPago,\r\n                                        compras.estadoDocumento,\r\n                                        compras.totalPagado,\r\n                                        compras.totalDocumentado,\r\n                                        compras.totalPendiente,\r\n                                        compras.idTipoDocumentoCompra,\r\n                                        compras.tipoDocumentoCompra,\r\n                                        compras.otrosImpuestos,\r\n                                        compras.totalExento,\r\n                                        compras.totalCobrar,\r\n                                        compras.idPeriodo,\r\n                                        compras.periodo,\r\n                                        compras.impuesto1,\r\n                                        compras.impuesto2,\r\n                                        compras.impuesto3,\r\n                                        compras.impuesto4,\r\n                                        compras.impuesto5,\r\n                                        compras.porcentajeImpuesto1,\r\n                                        compras.porcentajeImpuesto2,\r\n                                        compras.porcentajeImpuesto3,\r\n                                        compras.porcentajeImpuesto4,\r\n                                        compras.porcentajeImpuesto5,\r\n                                        compras.codImpuesto1,\r\n                                        compras.codImpuesto2,\r\n                                        compras.codImpuesto3,\r\n                                        compras.codImpuesto4,\r\n                                        compras.codImpuesto5, \r\n                                        detallecompra.idDetallecompra,\r\n                                        detallecompra.idCompraLinea,\r\n                                        detallecompra.rutProveedor,\r\n                                        detallecompra.folioCompra,\r\n                                        detallecompra.fechaIngreso,\r\n                                        detallecompra.codigo,\r\n                                        detallecompra.descripcion,\r\n                                        detallecompra.valorVenta,\r\n                                        detallecompra.cantidad,\r\n                                        detallecompra.porcentajeDescuentoLinea,\r\n                                        detallecompra.descuentoLinea,\r\n                                        detallecompra.subtotalLinea,\r\n                                        detallecompra.totalLinea,\r\n                                        detallecompra.tipoDescuento,\r\n                                        detallecompra.bodega,\r\n                                        detallecompra.idTipoDocumentoCompraLinea,\r\n                                        detallecompra.tipoDocumentoCompraLinea\r\n                                FROM compras INNER JOIN detallecompra \r\n                                ON compras.idCompra = detallecompra.idCompraLinea                             \r\n                                WHERE " + filtro + " ORDER BY compras.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
