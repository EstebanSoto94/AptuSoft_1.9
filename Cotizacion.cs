 
// Type: Aptusoft.Cotizacion
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Cotizacion
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaCotizacion(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO cotizacion (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,email,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            caja                                                            \r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,@email,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @documentoVenta,\r\n                                                            @idDocumentoVenta,\r\n                                                            @folioDocumentoVenta,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @caja  \r\n                                                            \r\n                                                   )";
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
        command.Parameters.AddWithValue("@email", (object) veOB.Email);
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
        ((DbCommand) command).ExecuteNonQuery();
        return "Cotizacion Ingresado";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleCotizacion(List<DatosVentaVO> lista)
    {
      foreach (DatosVentaVO veVO in lista)
        this.agregaDetalleCotizacion2(veVO);
    }

    public bool agregaDetalleCotizacion2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = this.retornaIdCotizacion(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detallecotizacion (\r\n                                                            idCotizacionLinea,\r\n                                                            folioCotizacion,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            valorCompra\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idCotizacionLinea,\r\n                                                            @folioCotizacionLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @valorCompra\r\n                                                             )";
        command.Parameters.AddWithValue("@idCotizacionLinea", (object) num);
        command.Parameters.AddWithValue("@folioCotizacionLinea", (object) veVO.FolioFactura);
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
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        string message = ex.Message;
        return false;
      }
    }

    public void actualizaDetalleCotizacion(string codigo, Decimal cantidadFacturada, int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE detallecotizacion SET cantidadFacturada=@cantidadFacturada WHERE folioCotizacion=@folio AND codigo=@codigo";
      command.Parameters.AddWithValue("@folio", (object) folio);
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      command.Parameters.AddWithValue("@cantidadFacturada", (object) cantidadFacturada);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public string anulaCotizacion(int idCotizacion, List<DatosVentaVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE cotizacion SET estadoDocumento = 'ANULADA', razonSocial= 'COTIZACION ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0' WHERE idCotizacion=@idCotizacion";
      command.Parameters.AddWithValue("@idCotizacion", (object) idCotizacion);
      ((DbCommand) command).ExecuteNonQuery();
      return "Cotizacion Anulado!!";
    }

    public int eliminaCotizacion(int idCotizacion)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE cotizacion, detallecotizacion FROM cotizacion, detallecotizacion WHERE cotizacion.idCotizacion = @idCotizacion AND detallecotizacion.idCotizacionLinea=@idCotizacion";
      command.Parameters.AddWithValue("@idCotizacion", (object) idCotizacion);
      return ((DbCommand) command).ExecuteNonQuery();
    }

    public int numeroCotizacion(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM cotizacion WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int numeroCotizacionSinCaja()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM cotizacion";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool cotizacionExiste(int numCotizacion)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM cotizacion WHERE folio=@numCotizacion";
      command.Parameters.AddWithValue("@numCotizacion", (object) numCotizacion);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int retornaIdCotizacion(int numCotizacion)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idCotizacion, folio FROM cotizacion WHERE folio=@numCotizacion";
      command.Parameters.AddWithValue("@numCotizacion", (object) numCotizacion);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaCotizacionFolio(int numCotizacion)
    {
      try
      {
        Venta venta = new Venta();
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT idCotizacion,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,email,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5\r\n                                                                                                                        \r\n\r\n                                        FROM cotizacion WHERE folio=@numCotizacion";
        command.Parameters.AddWithValue("@numCotizacion", (object) numCotizacion);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]);
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
          venta.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
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
        }
        ((DbDataReader) mySqlDataReader).Close();
        return venta;
      }
      catch
      {
        return (Venta) null;
      }
    }

    public List<Venta> buscaCotizacionRazonSocial(string razonSocial)
    {
      Venta venta = new Venta();
      List<Venta> list = new List<Venta>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idCotizacion,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,email,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5                                                                                                                        \r\n\r\n                                        FROM cotizacion WHERE razonSocial=@razonSocial ORDER BY folio";
      command.Parameters.AddWithValue("@razonSocial", (object) razonSocial);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new Venta()
        {
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacion"]),
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
          Email = ((DbDataReader) mySqlDataReader)["email"].ToString(),
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
          DocumentoVenta = ((DbDataReader) mySqlDataReader)["documentoVenta"].ToString(),
          IDDocumentoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDocumentoVenta"]),
          FolioDocumentoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioDocumentoVenta"]),
          Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]),
          Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]),
          Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]),
          Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]),
          Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]),
          PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]),
          PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]),
          PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]),
          PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]),
          PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<DatosVentaVO> buscaDetalleCotizacionIDCotizacion(int idCotizacion)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleCotizacion, \r\n                                                    idCotizacionLinea,\r\n                                                    folioCotizacion,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra, cantidadFacturada\r\n                                                    FROM detallecotizacion WHERE idCotizacionLinea = @idCotizacion ORDER BY idDetalleCotizacion asc";
      command.Parameters.AddWithValue("@idCotizacion", (object) idCotizacion);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleCotizacion"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCotizacionLinea"]),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioCotizacion"]),
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
          CantidadFacturada = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidadFacturada"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaCotizacion(Venta veOB, List<DatosVentaVO> listaNueva)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE cotizacion SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            email=@email,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor                                                            \r\n                                                            \r\n                                           WHERE idCotizacion=@idCotizacion AND folio=@folio";
        command.Parameters.AddWithValue("@idCotizacion", (object) veOB.IdFactura);
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
        command.Parameters.AddWithValue("@email", (object) veOB.Email);
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
        this.buscaDetalleCotizacionIDCotizacion(veOB.IdFactura);
        this.eliminaDetalleCotizacion(veOB);
        foreach (DatosVentaVO veVO in listaNueva)
          this.agregaDetalleCotizacion2(veVO);
        return "Cotizacion Modificado";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool eliminaDetalleCotizacion(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detallecotizacion WHERE idCotizacionLinea=@idCotizacion AND folioCotizacion=@folioCotizacion";
        command.Parameters.AddWithValue("@idCotizacion", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioCotizacion", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public bool modificaTipoDocumentoCotizacion(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE cotizacion SET documentoVenta = @documentoVenta,\r\n                                                          idDocumentoVenta = @idDocumentoVenta,\r\n                                                          folioDocumentoVenta = @folioDocumentoVenta\r\n                                        WHERE idCotizacion=@idCotizacion AND folio=@folio";
        command.Parameters.AddWithValue("@idCotizacion", (object) veOB.IdFactura);
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

    public DataTable muestraCotizacionFolio(int folio)
    {
      string str = "SELECT \r\n                                     cotizacion.idCotizacion,\r\n                                     cotizacion.folio,\r\n                                     cotizacion.fechaEmision,\r\n                                     cotizacion.fechaVencimiento,\r\n                                     cotizacion.dia,\r\n                                     cotizacion.mes,\r\n                                     cotizacion.ano,\r\n                                     cotizacion.idCliente,\r\n                                     cotizacion.rut,\r\n                                     cotizacion.digito,\r\n                                     cotizacion.razonSocial,\r\n                                     cotizacion.direccion,\r\n                                     cotizacion.comuna,\r\n                                     cotizacion.ciudad,\r\n                                     cotizacion.giro,\r\n                                     cotizacion.fono,\r\n                                     cotizacion.fax, \r\n                                     cotizacion.contacto,\r\n                                     cotizacion.email,\r\n                                     cotizacion.diasPlazo,\r\n                                     cotizacion.idMedioPago,\r\n                                     cotizacion.medioPago,\r\n                                     cotizacion.idVendedor,\r\n                                     cotizacion.vendedor,\r\n                                     cotizacion.idCentroCosto,\r\n                                     cotizacion.centroCosto,\r\n                                     cotizacion.ordenCompra,\r\n                                     cotizacion.subtotal,\r\n                                     cotizacion.porcentajeDescuento,\r\n                                     cotizacion.descuento,\r\n                                     cotizacion.porcentajeIva,\r\n                                     cotizacion.iva, \r\n                                     cotizacion.neto,\r\n                                     cotizacion.total,\r\n                                     cotizacion.totalPalabras,\r\n                                     cotizacion.estadoPago,\r\n                                     cotizacion.estadoDocumento, \r\n                                     cotizacion.documentoVenta,\r\n                                     cotizacion.idDocumentoVenta,\r\n                                     cotizacion.folioDocumentoVenta, \r\n                                     cotizacion.comisionVendedor,\r\n                                     cotizacion.porcentajeImpuesto5,\r\n                                     cotizacion.porcentajeImpuesto4, \r\n                                     cotizacion.porcentajeImpuesto3, \r\n                                     cotizacion.porcentajeImpuesto2, \r\n                                     cotizacion.porcentajeImpuesto1,\r\n                                     cotizacion.impuesto5,\r\n                                     cotizacion.impuesto4,\r\n                                     cotizacion.impuesto3,\r\n                                     cotizacion.impuesto2,\r\n                                     cotizacion.impuesto1,\r\n                                     cotizacion.caja,\r\n                                     detallecotizacion.iddetallecotizacion,\r\n                                     detallecotizacion.idcotizacionlinea,\r\n                                     detallecotizacion.folioCotizacion,\r\n                                     detallecotizacion.fechaIngreso,\r\n                                     detallecotizacion.codigo,\r\n                                     detallecotizacion.descripcion,\r\n                                     detallecotizacion.valorventa,\r\n                                     detallecotizacion.cantidad, \r\n                                     detallecotizacion.porcentajedescuentoLinea,\r\n                                     detallecotizacion.descuentoLinea,\r\n                                     detallecotizacion.subtotalLinea,\r\n                                     detallecotizacion.totalLinea, \r\n                                     detallecotizacion.tipoDescuento,\r\n                                     detallecotizacion.listaPrecio,\r\n                                     detallecotizacion.bodega, \r\n                                     detallecotizacion.idImpuesto, \r\n                                     detallecotizacion.netoLinea,\r\n                                     detallecotizacion.valorCompra,\r\n                                     detallecotizacion.cantidadFacturada,\r\n\t\t\t\t\t\t\t\t\t imagenes.imagen1,\r\n\t\t\t\t\t\t\t\t\t imagenes.imagen2,\r\n\t\t\t\t\t\t\t\t\t imagenes.imagen3\r\n                                FROM  cotizacion INNER JOIN detallecotizacion \r\n                                ON cotizacion.idcotizacion = detallecotizacion.idcotizacionlinea \r\n\t\t\t\t\t\t\t\tLEFT JOIN imagenes ON detallecotizacion.codigo=imagenes.codigoproducto\r\n                                WHERE cotizacion.folio=@folio ORDER BY detallecotizacion.iddetallecotizacion";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = str;
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable cotizacionInforme(string filtro)
    {
      string str = "SELECT \r\n                                         cotizacion.idCotizacion,\r\n                                         cotizacion.folio,\r\n                                         cotizacion.fechaEmision,\r\n                                         cotizacion.fechaVencimiento,\r\n                                         cotizacion.dia,\r\n                                         cotizacion.mes,\r\n                                         cotizacion.ano,\r\n                                         cotizacion.idCliente,\r\n                                         cotizacion.rut,\r\n                                         cotizacion.digito,\r\n                                         cotizacion.razonSocial,\r\n                                         cotizacion.direccion,\r\n                                         cotizacion.comuna,\r\n                                         cotizacion.ciudad,\r\n                                         cotizacion.giro,\r\n                                         cotizacion.fono,\r\n                                         cotizacion.fax, \r\n                                         cotizacion.contacto,\r\n                                         cotizacion.email,\r\n                                         cotizacion.diasPlazo,\r\n                                         cotizacion.idMedioPago,\r\n                                         cotizacion.medioPago,\r\n                                         cotizacion.idVendedor,\r\n                                         cotizacion.vendedor,\r\n                                         cotizacion.idCentroCosto,\r\n                                         cotizacion.centroCosto,\r\n                                         cotizacion.ordenCompra,\r\n                                         cotizacion.subtotal,\r\n                                         cotizacion.porcentajeDescuento,\r\n                                         cotizacion.descuento,\r\n                                         cotizacion.porcentajeIva,\r\n                                         cotizacion.iva, \r\n                                         cotizacion.neto,\r\n                                         cotizacion.total,\r\n                                         cotizacion.totalPalabras,\r\n                                         cotizacion.estadoPago,\r\n                                         cotizacion.estadoDocumento, \r\n                                         cotizacion.documentoVenta,\r\n                                         cotizacion.idDocumentoVenta,\r\n                                         cotizacion.folioDocumentoVenta, \r\n                                         cotizacion.comisionVendedor,\r\n                                         cotizacion.porcentajeImpuesto5,\r\n                                         cotizacion.porcentajeImpuesto4, \r\n                                         cotizacion.porcentajeImpuesto3, \r\n                                         cotizacion.porcentajeImpuesto2, \r\n                                         cotizacion.porcentajeImpuesto1,\r\n                                         cotizacion.impuesto5,\r\n                                         cotizacion.impuesto4,\r\n                                         cotizacion.impuesto3,\r\n                                         cotizacion.impuesto2,\r\n                                         cotizacion.impuesto1,\r\n                                         cotizacion.caja                                            \r\n                                FROM cotizacion                             \r\n                                WHERE " + filtro + " ORDER BY cotizacion.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable cotizacionInformeDetalle(string filtro)
    {
      string str = "SELECT \r\n                                     cotizacion.idCotizacion,\r\n                                     cotizacion.folio,\r\n                                     cotizacion.fechaEmision,\r\n                                     cotizacion.fechaVencimiento,\r\n                                     cotizacion.dia,\r\n                                     cotizacion.mes,\r\n                                     cotizacion.ano,\r\n                                     cotizacion.idCliente,\r\n                                     cotizacion.rut,\r\n                                     cotizacion.digito,\r\n                                     cotizacion.razonSocial,\r\n                                     cotizacion.direccion,\r\n                                     cotizacion.comuna,\r\n                                     cotizacion.ciudad,\r\n                                     cotizacion.giro,\r\n                                     cotizacion.fono,\r\n                                     cotizacion.fax, \r\n                                     cotizacion.contacto,\r\n                                     cotizacion.email,\r\n                                     cotizacion.diasPlazo,\r\n                                     cotizacion.idMedioPago,\r\n                                     cotizacion.medioPago,\r\n                                     cotizacion.idVendedor,\r\n                                     cotizacion.vendedor,\r\n                                     cotizacion.idCentroCosto,\r\n                                     cotizacion.centroCosto,\r\n                                     cotizacion.ordenCompra,\r\n                                     cotizacion.subtotal,\r\n                                     cotizacion.porcentajeDescuento,\r\n                                     cotizacion.descuento,\r\n                                     cotizacion.porcentajeIva,\r\n                                     cotizacion.iva, \r\n                                     cotizacion.neto,\r\n                                     cotizacion.total,\r\n                                     cotizacion.totalPalabras,\r\n                                     cotizacion.estadoPago,\r\n                                     cotizacion.estadoDocumento, \r\n                                     cotizacion.documentoVenta,\r\n                                     cotizacion.idDocumentoVenta,\r\n                                     cotizacion.folioDocumentoVenta, \r\n                                     cotizacion.comisionVendedor,\r\n                                     cotizacion.porcentajeImpuesto5,\r\n                                     cotizacion.porcentajeImpuesto4, \r\n                                     cotizacion.porcentajeImpuesto3, \r\n                                     cotizacion.porcentajeImpuesto2, \r\n                                     cotizacion.porcentajeImpuesto1,\r\n                                     cotizacion.impuesto5,\r\n                                     cotizacion.impuesto4,\r\n                                     cotizacion.impuesto3,\r\n                                     cotizacion.impuesto2,\r\n                                     cotizacion.impuesto1,\r\n                                     cotizacion.caja,\r\n                                     detallecotizacion.iddetallecotizacion,\r\n                                     detallecotizacion.idcotizacionlinea,\r\n                                     detallecotizacion.folioCotizacion,\r\n                                     detallecotizacion.fechaIngreso,\r\n                                     detallecotizacion.codigo,\r\n                                     detallecotizacion.descripcion,\r\n                                     detallecotizacion.valorVenta,\r\n                                     detallecotizacion.cantidad, \r\n                                     detallecotizacion.porcentajeDescuentoLinea,\r\n                                     detallecotizacion.descuentoLinea,\r\n                                     detallecotizacion.subtotalLinea,\r\n                                     detallecotizacion.totalLinea, \r\n                                     detallecotizacion.tipoDescuento,\r\n                                     detallecotizacion.listaPrecio,\r\n                                     detallecotizacion.bodega, \r\n                                     detallecotizacion.idImpuesto, \r\n                                     detallecotizacion.netoLinea,\r\n                                     detallecotizacion.valorCompra,\r\n                                     detallecotizacion.cantidadFacturada\t\t\t\t\t\t\t\t\t \r\n                                FROM cotizacion INNER JOIN detallecotizacion \r\n                                ON cotizacion.idcotizacion = detallecotizacion.idcotizacionlinea                             \r\n                                WHERE " + filtro + " ORDER BY cotizacion.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
