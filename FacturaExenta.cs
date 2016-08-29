 
// Type: Aptusoft.FacturaExenta
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class FacturaExenta
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaFacturaExenta(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO facturasexentas (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,                                                            \r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,                                                           \r\n                                                            comisionVendedor,\r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            fechaModificacion,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            caja,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,   \r\n                                                            @total,                                                         \r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente,                                                            \r\n                                                            @comisionVendedor,\r\n                                                            @idTicket,\r\n                                                            @folioTicket,\r\n                                                            @folioGuias,\r\n                                                            @observaciones,\r\n                                                            @fechaModificacion,\r\n                                                            @idCotizacion,\r\n                                                            @folioCotizacion,\r\n                                                            @caja,\r\n                                                            @idNotaVenta,\r\n                                                            @folioNotaVenta\r\n\r\n                                                   )";
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
        command.Parameters.AddWithValue("@total", (object) veOB.Total);
        command.Parameters.AddWithValue("@totalPalabras", (object) veOB.TotalPalabras);
        command.Parameters.AddWithValue("@estadoPago", (object) veOB.EstadoPago);
        command.Parameters.AddWithValue("@estadoDocumento", (object) veOB.EstadoDocumento);
        command.Parameters.AddWithValue("@totalPagado", (object) veOB.TotalPagado);
        command.Parameters.AddWithValue("@totalDocumentado", (object) veOB.TotalDocumentado);
        command.Parameters.AddWithValue("@totalPendiente", (object) veOB.TotalPendiente);
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
        ((DbCommand) command).ExecuteNonQuery();
        return "Factura Exenta Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleFacturaExenta(List<DatosVentaVO> lista)
    {
      foreach (DatosVentaVO veVO in lista)
      {
        if (veVO.DescuentaInventario)
        {
          Decimal num = this.consultaStock(veVO);
          veVO.StockQueda = num - veVO.Cantidad;
          this.actualizaStock(veVO, "-");
        }
        this.agregaDetalleFacturaExenta2(veVO);
      }
    }

    public bool agregaDetalleFacturaExenta2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = this.RetornaIdFacturaExenta(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detallefacturaexenta (\r\n                                                            idFacturaExentaLinea,\r\n                                                            folioFacturaExenta,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,                                                            \r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra,\r\n                                                            usuario,\r\n                                                            stockQueda\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idFactuLinea,\r\n                                                            @folioFacturaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,                                                            \r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra,\r\n                                                            @usuario,\r\n                                                            @stockQueda\r\n                                                             )";
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

    public int RetornaIdFacturaExenta(int numFactura)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idFacturaExenta, folio FROM facturasexentas WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool facturaExentaExiste(int numFactura)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM facturasexentas WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int numeroFacturaExenta(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM facturasexentas WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaFacturaExentaFolio(int numFactura)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idFacturaExenta,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,                                                            \r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,                                                            \r\n                                                            idTicket,\r\n                                                            folioTicket,\r\n                                                            folioGuias,\r\n                                                            observaciones,\r\n                                                            idCotizacion,\r\n                                                            folioCotizacion,\r\n                                                            idNotaVenta,\r\n                                                            folioNotaVenta     \r\n                                                FROM facturasexentas WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFacturaExenta"]);
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
        venta.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]);
        venta.TotalPalabras = ((DbDataReader) mySqlDataReader)["totalPalabras"].ToString();
        venta.EstadoPago = ((DbDataReader) mySqlDataReader)["estadoPago"].ToString();
        venta.EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString();
        venta.TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPagado"]);
        venta.TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalDocumentado"]);
        venta.TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalPendiente"]);
        venta.IdTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicket"]);
        venta.FolioTicket = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioTicket"]);
        venta.FolioGuias = ((DbDataReader) mySqlDataReader)["folioGuias"].ToString();
        venta.Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString();
        venta.IdCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]);
        venta.FolioCotizacion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]);
        venta.IdNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaVenta"]);
        venta.FolioNotaVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioNotaVenta"]);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<DatosVentaVO> buscaDetalleFacturaExentaIDFactura(int idFactura)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleFacturaExenta, \r\n                                                    idFacturaExentaLinea,\r\n                                                    folioFacturaExenta,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,                                                    \r\n                                                    netoLinea,\r\n                                                    descuentaInventario,\r\n                                                    valorCompra,stockQueda\r\n                                                    FROM detallefacturaexenta WHERE idFacturaExentaLinea = @idFactura ORDER BY idDetalleFacturaExenta asc";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleFacturaExenta"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFacturaExentaLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioFacturaExenta"]),
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
          NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]),
          DescuentaInventario = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["descuentaInventario"].ToString()),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]),
          StockQueda = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockQueda"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaFacturaExenta(Venta veOB, List<DatosVentaVO> listaNueva)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE facturasexentas SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,                                                            \r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente,\r\n                                                            \r\n                                                            comisionVendedor=@comisionVendedor,\r\n                                                            folioGuias=@folioGuias,\r\n                                                            observaciones=@observaciones,\r\n                                                            fechaModificacion=@fechaModificacion                                              \r\n\r\n                                           WHERE idFacturaExenta=@idFactura AND folio=@folio";
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
      command.Parameters.AddWithValue("@total", (object) veOB.Total);
      command.Parameters.AddWithValue("@totalPalabras", (object) veOB.TotalPalabras);
      command.Parameters.AddWithValue("@estadoPago", (object) veOB.EstadoPago);
      command.Parameters.AddWithValue("@totalPagado", (object) veOB.TotalPagado);
      command.Parameters.AddWithValue("@totalDocumentado", (object) veOB.TotalDocumentado);
      command.Parameters.AddWithValue("@totalPendiente", (object) veOB.TotalPendiente);
      command.Parameters.AddWithValue("@comisionVendedor", (object) veOB.ComisionVendedor);
      command.Parameters.AddWithValue("@folioGuias", (object) veOB.FolioGuias);
      command.Parameters.AddWithValue("@observaciones", (object) veOB.Observaciones);
      command.Parameters.AddWithValue("@fechaModificacion", (object) DateTime.Now);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in this.buscaDetalleFacturaExentaIDFactura(veOB.IdFactura))
      {
        new ControlProducto().registroDocumentoModifica(datosVentaVo, "FACTURA EXENTA");
        new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "FACTURA EXENTA");
        this.actualizaStock(datosVentaVo, "+");
      }
      this.eliminaDetalleFacturaExenta(veOB);
      foreach (DatosVentaVO veVO in listaNueva)
      {
        Decimal num = this.consultaStock(veVO);
        veVO.StockQueda = num - veVO.Cantidad;
        veVO.FechaIngreso = veVO.FechaIngreso.AddSeconds(40.0);
        this.agregaDetalleFacturaExenta2(veVO);
        this.actualizaStock(veVO, "-");
      }
      return "Factura Exenta Modificada";
    }

    public bool eliminaDetalleFacturaExenta(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detallefacturaexenta WHERE idFacturaExentaLinea=@idFactura AND folioFacturaExenta=@folioFactura";
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

    public int eliminaFacturaExenta(int idFactura)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE facturasexentas, detallefacturaexenta FROM facturasexentas, detallefacturaexenta WHERE facturasexentas.idFacturaExenta = @idFactura AND detallefacturaexenta.idFacturaExentaLinea=@idFactura";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      return ((DbCommand) command).ExecuteNonQuery();
    }

    public string anulaFacturaExenta(int idFactura, List<DatosVentaVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE facturasexentas SET estadoDocumento = 'ANULADA', razonSocial= 'FACTURA ANULADA', rut='0', digito='0', subtotal='0', descuento='0',  total='0' WHERE idFacturaExenta=@idFactura";
      command.Parameters.AddWithValue("@idFactura", (object) idFactura);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        if (datosVentaVo.DescuentaInventario)
        {
          new ControlProducto().registroDocumentoNulo(datosVentaVo, "FACTURA EXENTA");
          this.actualizaStock(datosVentaVo, "+");
        }
      }
      return "Factura Exenta Anulada!!";
    }

    private void registroFacturaExentaNula(DatosVentaVO vevo)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ANULA FACTURA EXENTA FOLIO: " + (object) vevo.FolioFactura;
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = vevo.Cantidad + num;
      controlProducto.agregaControlProducto(cp);
    }

    public DataTable muestraFacturaExentaFolio(int folio)
    {
      string str = "SELECT \r\n                            facturasexentas.idFacturaExenta,\r\n                            facturasexentas.folio,\r\n                            facturasexentas.fechaEmision,\r\n                            facturasexentas.fechaVencimiento,\r\n                            facturasexentas.dia,\r\n                            facturasexentas.mes,\r\n                            facturasexentas.ano,\r\n                            facturasexentas.idCliente, \r\n                            facturasexentas.rut, \r\n                            facturasexentas.digito, \r\n                            facturasexentas.razonSocial,\r\n                            facturasexentas.direccion, \r\n                            facturasexentas.comuna, \r\n                            facturasexentas.ciudad, \r\n                            facturasexentas.giro, \r\n                            facturasexentas.fono, \r\n                            facturasexentas.fax, \r\n                            facturasexentas.contacto, \r\n                            facturasexentas.diasPlazo, \r\n                            facturasexentas.idMedioPago,                          \r\n                            facturasexentas.medioPago, \r\n                            facturasexentas.idVendedor, \r\n                            facturasexentas.vendedor, \r\n                            facturasexentas.idCentroCosto, \r\n                            facturasexentas.centroCosto, \r\n                            facturasexentas.ordenCompra, \r\n                            facturasexentas.subtotal, \r\n                            facturasexentas.porcentajeDescuento,\r\n                            facturasexentas.descuento,                             \r\n                            facturasexentas.total, \r\n                            facturasexentas.totalPalabras, \r\n                            facturasexentas.estadoPago, \r\n                            facturasexentas.estadoDocumento, \r\n                            detallefacturaexenta.idFacturaExentaLinea,\r\n                            detallefacturaexenta.folioFacturaExenta,\r\n                            detallefacturaexenta.fechaIngreso,\r\n                            detallefacturaexenta.codigo,\r\n                            detallefacturaexenta.descripcion,\r\n                            detallefacturaexenta.valorVenta,\r\n                            detallefacturaexenta.cantidad,\r\n                            detallefacturaexenta.porcentajeDescuentoLinea,\r\n                            detallefacturaexenta.descuentoLinea,\r\n                            detallefacturaexenta.subtotalLinea, \r\n                            detallefacturaexenta.totalLinea, \r\n                            detallefacturaexenta.tipoDescuento, \r\n                            detallefacturaexenta.listaPrecio, \r\n                            detallefacturaexenta.bodega, \r\n                            detallefacturaexenta.idDetalleFacturaExenta,\r\n                            detallefacturaexenta.netoLinea,\r\n                            detallefacturaexenta.valorCompra\r\n                            FROM facturasexentas INNER JOIN detallefacturaexenta \r\n                            ON facturasexentas.idFacturaExenta = detallefacturaexenta.idFacturaExentaLinea WHERE facturasexentas.folio=@folio ORDER BY detallefacturaexenta.idDetalleFacturaExenta";
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

    public DataTable facturaExentaInforme(string filtro)
    {
      string str = "SELECT\r\n                                    idFacturaExenta,\r\n                                    folio,\r\n                                    fechaEmision,\r\n                                    fechaVencimiento,\r\n                                    dia,\r\n                                    mes,\r\n                                    ano,\r\n                                    idCliente,\r\n                                    rut,\r\n                                    digito,\r\n                                    razonSocial,\r\n                                    direccion,\r\n                                    comuna,\r\n                                    ciudad,\r\n                                    giro,\r\n                                    fono,\r\n                                    fax,\r\n                                    contacto,\r\n                                    diasPlazo,\r\n                                    idMedioPago,\r\n                                    medioPago,\r\n                                    idVendedor,\r\n                                    vendedor,\r\n                                    idCentroCosto,\r\n                                    centroCosto,\r\n                                    ordenCompra,\r\n                                    subtotal,\r\n                                    porcentajeDescuento,\r\n                                    descuento,                                \r\n                                    total,\r\n                                    totalPalabras,\r\n                                    estadoPago,\r\n                                    estadoDocumento,\r\n                                    totalPagado,\r\n                                    totalDocumentado,\r\n                                    totalPendiente,                                \r\n                                    comisionVendedor,\r\n                                    idTicket,\r\n                                    folioTicket,\r\n                                    folioGuias,\r\n                                    observaciones,\r\n                                    fechaModificacion,\r\n                                    idCotizacion,\r\n                                    folioCotizacion,\r\n                                    caja\r\n                                FROM\r\n                                facturasexentas                                 \r\n                                WHERE " + filtro + " ORDER BY folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable facturaExentaInformeDetalle(string filtro)
    {
      string str = "SELECT \r\n                            facturasexentas.idFacturaExenta,\r\n                            facturasexentas.folio,\r\n                            facturasexentas.fechaEmision,\r\n                            facturasexentas.fechaVencimiento,\r\n                            facturasexentas.dia,\r\n                            facturasexentas.mes,\r\n                            facturasexentas.ano,\r\n                            facturasexentas.idCliente, \r\n                            facturasexentas.rut, \r\n                            facturasexentas.digito, \r\n                            facturasexentas.razonSocial,\r\n                            facturasexentas.direccion, \r\n                            facturasexentas.comuna, \r\n                            facturasexentas.ciudad, \r\n                            facturasexentas.giro, \r\n                            facturasexentas.fono, \r\n                            facturasexentas.fax, \r\n                            facturasexentas.contacto, \r\n                            facturasexentas.diasPlazo, \r\n                            facturasexentas.idMedioPago,                          \r\n                            facturasexentas.medioPago, \r\n                            facturasexentas.idVendedor, \r\n                            facturasexentas.vendedor, \r\n                            facturasexentas.idCentroCosto, \r\n                            facturasexentas.centroCosto, \r\n                            facturasexentas.ordenCompra, \r\n                            facturasexentas.subtotal, \r\n                            facturasexentas.porcentajeDescuento,\r\n                            facturasexentas.descuento,                             \r\n                            facturasexentas.total, \r\n                            facturasexentas.totalPalabras, \r\n                            facturasexentas.estadoPago, \r\n                            facturasexentas.estadoDocumento, \r\n                            detallefacturaexenta.idFacturaExentaLinea,\r\n                            detallefacturaexenta.folioFacturaExenta,\r\n                            detallefacturaexenta.fechaIngreso,\r\n                            detallefacturaexenta.codigo,\r\n                            detallefacturaexenta.descripcion,\r\n                            detallefacturaexenta.valorVenta,\r\n                            detallefacturaexenta.cantidad,\r\n                            detallefacturaexenta.porcentajeDescuentoLinea,\r\n                            detallefacturaexenta.descuentoLinea,\r\n                            detallefacturaexenta.subtotalLinea, \r\n                            detallefacturaexenta.totalLinea, \r\n                            detallefacturaexenta.tipoDescuento, \r\n                            detallefacturaexenta.listaPrecio, \r\n                            detallefacturaexenta.bodega, \r\n                            detallefacturaexenta.idDetalleFacturaExenta,\r\n                            detallefacturaexenta.netoLinea,\r\n                            detallefacturaexenta.valorCompra\r\n                            FROM facturasexentas INNER JOIN detallefacturaexenta \r\n                            ON facturasexentas.idFacturaExenta = detallefacturaexenta.idFacturaExentaLinea WHERE " + filtro + " ORDER BY facturasexentas.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
