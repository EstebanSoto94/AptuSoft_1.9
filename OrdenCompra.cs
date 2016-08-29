 
// Type: Aptusoft.OrdenCompra
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class OrdenCompra
  {
    private Conexion conexion = Conexion.getConecta();

    public int numeroOrdenCompra()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM ordencompra";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaOrdenCompraFolio(int folio)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idOrdenCompra,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idProveedor,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,                                                            \r\n                                                            idMedioPago,\r\n                                                            medioPago,                                                            \r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente\r\n                                        FROM ordencompra WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrdenCompra"]);
        venta.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]);
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
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<DatosVentaVO> buscaDetalleOrdenCompraIDCompra(int idOrdenCompra)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleOrdenCompra, \r\n                                                    idOrdenCompraLinea,\r\n                                                    folioOrdenCompra, \r\n                                                    fechaIngreso,                                                   \r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,                                                    \r\n                                                    bodega                                                    \r\n                                                    FROM detalleordencompra WHERE idOrdenCompraLinea = @idOrdenCompra ORDER BY idDetalleOrdenCompra asc";
      command.Parameters.AddWithValue("@idOrdenCompra", (object) idOrdenCompra);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleOrdenCompra"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrdenCompraLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioOrdenCompra"]),
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
          Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string agregaOrdenCompra(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO ordencompra (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idProveedor,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            idMedioPago,\r\n                                                            medioPago,                                                                                                                        \r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente\r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idProveedor,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,                                                            \r\n                                                            @idMedioPago,\r\n                                                            @medioPago,                                                                                                                        \r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @totalPagado,\r\n                                                            @totalDocumentado,\r\n                                                            @totalPendiente\r\n                                                            \r\n                                                   )";
        command.Parameters.AddWithValue("@folio", (object) veOB.Folio);
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
        ((DbCommand) command).ExecuteNonQuery();
        return "Orden de Compra Ingresada";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleOrdenCompra(List<DatosVentaVO> lista)
    {
      foreach (DatosVentaVO veVO in lista)
        this.agregaDetalleOrdenCompra2(veVO);
    }

    public void agregaDetalleOrdenCompra2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = this.retornaIdOrdenCompra(veVO.FolioFactura);
      ((DbCommand) command).CommandText = "INSERT INTO detalleordencompra (\r\n                                                            idOrdenCompraLinea,\r\n                                                            folioOrdenCompra, \r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,                                                            \r\n                                                            bodega\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idCompraLinea,\r\n                                                            @folioCompraLinea, \r\n                                                            @fechaIngreso,                                                           \r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,                                                            \r\n                                                            @bodega\r\n                                                             )";
      command.Parameters.AddWithValue("@idCompraLinea", (object) num);
      command.Parameters.AddWithValue("@folioCompraLinea", (object) veVO.FolioFactura);
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
      command.Parameters.AddWithValue("@bodega", (object) veVO.Bodega);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public bool ordenCompraExiste(int numFactura)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM ordencompra WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int retornaIdOrdenCompra(int numFactura)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idOrdenCompra, folio FROM ordencompra WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int eliminaOrdenCompra(int idOrdenCompra, List<DatosVentaVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE ordencompra, detalleordencompra FROM ordencompra, detalleordencompra WHERE ordencompra.idOrdenCompra = @idOrdenCompra AND detalleordencompra.idOrdenCompraLinea=@idOrdenCompra";
      command.Parameters.AddWithValue("@idOrdenCompra", (object) idOrdenCompra);
      return ((DbCommand) command).ExecuteNonQuery();
    }

    public Venta buscaCompraID(int idCompra)
    {
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idCompra,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idProveedor,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,                                                            \r\n                                                            idMedioPago,\r\n                                                            medioPago,                                                            \r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            totalPagado,\r\n                                                            totalDocumentado,\r\n                                                            totalPendiente,\r\n                                                            idTipoDocumentoCompra,\r\n                                                            tipoDocumentoCompra\r\n                                        FROM compras WHERE idCompra=@idCompra";
      command.Parameters.AddWithValue("@idCompra", (object) idCompra);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCompra"]);
        venta.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]);
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
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public string modificaOrdenCompra(Venta veOB, List<DatosVentaVO> listaNueva)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE ordencompra SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idProveedor=@idProveedor,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,                                                            \r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,                                                            \r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            \r\n                                                            totalPagado=@totalPagado,\r\n                                                            totalDocumentado=@totalDocumentado,\r\n                                                            totalPendiente=@totalPendiente                                                            \r\n\r\n                                           WHERE idOrdenCompra=@idOrdenCompra AND folio=@folio";
        command.Parameters.AddWithValue("@idOrdenCompra", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folio", (object) veOB.Folio);
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
        command.Parameters.AddWithValue("@totalPagado", (object) veOB.TotalPagado);
        command.Parameters.AddWithValue("@totalDocumentado", (object) veOB.TotalDocumentado);
        command.Parameters.AddWithValue("@totalPendiente", (object) veOB.TotalPendiente);
        ((DbCommand) command).ExecuteNonQuery();
        this.buscaDetalleOrdenCompraIDCompra(veOB.IdFactura);
        this.eliminaDetalleOrdenCompra(veOB);
        foreach (DatosVentaVO veVO in listaNueva)
          this.agregaDetalleOrdenCompra2(veVO);
        return "Orden de Compra Modificada";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool eliminaDetalleOrdenCompra(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detalleordencompra WHERE idOrdenCompraLinea=@idOrdenCompra AND folioOrdenCompra=@folioOrdenCompra";
        command.Parameters.AddWithValue("@idOrdenCompra", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioOrdenCompra", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public DataTable muestraOrdenCompraID(int idOrdenCompra)
    {
      string str = "SELECT \r\n                                ordencompra.idOrdenCompra,\r\n                                ordencompra.folio,\r\n                                ordencompra.fechaEmision,\r\n                                ordencompra.fechaVencimiento,\r\n                                ordencompra.dia,\r\n                                ordencompra.mes,\r\n                                ordencompra.ano,\r\n                                ordencompra.idProveedor,\r\n                                ordencompra.rut,\r\n                                ordencompra.digito,\r\n                                ordencompra.razonSocial,\r\n                                ordencompra.direccion,\r\n                                ordencompra.comuna,\r\n                                ordencompra.ciudad,\r\n                                ordencompra.giro,\r\n                                ordencompra.fono,\r\n                                ordencompra.fax,\r\n                                ordencompra.contacto,\r\n                                ordencompra.diasPlazo,\r\n                                ordencompra.idMedioPago,\r\n                                ordencompra.medioPago,\r\n                                ordencompra.idCentroCosto,\r\n                                ordencompra.centroCosto,\r\n                                ordencompra.ordenCompra,\r\n                                ordencompra.subtotal,\r\n                                ordencompra.porcentajeDescuento,\r\n                                ordencompra.descuento,\r\n                                ordencompra.porcentajeIva,\r\n                                ordencompra.iva,\r\n                                ordencompra.neto,\r\n                                ordencompra.total,\r\n                                ordencompra.totalPalabras,\r\n                                ordencompra.estadoPago,\r\n                                ordencompra.estadoDocumento,\r\n                                ordencompra.totalPagado,\r\n                                ordencompra.totalDocumentado,\r\n                                ordencompra.totalPendiente,\r\n                                detalleordencompra.idDetalleOrdenCompra,\r\n                                detalleordencompra.idOrdenCompraLinea,\r\n                                detalleordencompra.folioOrdenCompra,\r\n                                detalleordencompra.fechaIngreso,\r\n                                detalleordencompra.codigo,\r\n                                detalleordencompra.descripcion,\r\n                                detalleordencompra.valorVenta,\r\n                                detalleordencompra.cantidad,\r\n                                detalleordencompra.porcentajeDescuentoLinea,\r\n                                detalleordencompra.descuentoLinea,\r\n                                detalleordencompra.subtotalLinea,\r\n                                detalleordencompra.totalLinea,\r\n                                detalleordencompra.tipoDescuento,\r\n                                detalleordencompra.bodega,\r\n                                productos.UnidadMedida\r\n                                FROM ordencompra INNER JOIN detalleordencompra \r\n                                ON ordencompra.idOrdenCompra = detalleordencompra.idOrdenCompraLinea AND ordencompra.folio = detalleordencompra.folioOrdenCompra\r\n                                LEFT JOIN productos ON detalleordencompra.codigo = productos.codigo\r\n                                WHERE ordencompra.idOrdenCompra=@idOrdenCompra";
      DataTable dataTable = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        command.Parameters.AddWithValue("@idOrdenCompra", (object) idOrdenCompra);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      catch (Exception ex)
      {
      }
      return dataTable;
    }

    public DataTable ordenCompraInforme(string filtro)
    {
      string str = "SELECT \r\n                                        ordencompra.idOrdenCompra,\r\n                                ordencompra.folio,\r\n                                ordencompra.fechaEmision,\r\n                                ordencompra.fechaVencimiento,\r\n                                ordencompra.dia,\r\n                                ordencompra.mes,\r\n                                ordencompra.ano,\r\n                                ordencompra.idProveedor,\r\n                                ordencompra.rut,\r\n                                ordencompra.digito,\r\n                                ordencompra.razonSocial,\r\n                                ordencompra.direccion,\r\n                                ordencompra.comuna,\r\n                                ordencompra.ciudad,\r\n                                ordencompra.giro,\r\n                                ordencompra.fono,\r\n                                ordencompra.fax,\r\n                                ordencompra.contacto,\r\n                                ordencompra.diasPlazo,\r\n                                ordencompra.idMedioPago,\r\n                                ordencompra.medioPago,\r\n                                ordencompra.idCentroCosto,\r\n                                ordencompra.centroCosto,\r\n                                ordencompra.ordenCompra,\r\n                                ordencompra.subtotal,\r\n                                ordencompra.porcentajeDescuento,\r\n                                ordencompra.descuento,\r\n                                ordencompra.porcentajeIva,\r\n                                ordencompra.iva,\r\n                                ordencompra.neto,\r\n                                ordencompra.total,\r\n                                ordencompra.totalPalabras,\r\n                                ordencompra.estadoPago,\r\n                                ordencompra.estadoDocumento,\r\n                                ordencompra.totalPagado,\r\n                                ordencompra.totalDocumentado,\r\n                                ordencompra.totalPendiente                                                                                                                  \r\n                                FROM ordencompra                             \r\n                                WHERE " + filtro + " ORDER BY ordencompra.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable ordenCompraInformeDetalle(string filtro)
    {
      string str = "SELECT \r\n                                        ordencompra.idOrdenCompra,\r\n                                ordencompra.folio,\r\n                                ordencompra.fechaEmision,\r\n                                ordencompra.fechaVencimiento,\r\n                                ordencompra.dia,\r\n                                ordencompra.mes,\r\n                                ordencompra.ano,\r\n                                ordencompra.idProveedor,\r\n                                ordencompra.rut,\r\n                                ordencompra.digito,\r\n                                ordencompra.razonSocial,\r\n                                ordencompra.direccion,\r\n                                ordencompra.comuna,\r\n                                ordencompra.ciudad,\r\n                                ordencompra.giro,\r\n                                ordencompra.fono,\r\n                                ordencompra.fax,\r\n                                ordencompra.contacto,\r\n                                ordencompra.diasPlazo,\r\n                                ordencompra.idMedioPago,\r\n                                ordencompra.medioPago,\r\n                                ordencompra.idCentroCosto,\r\n                                ordencompra.centroCosto,\r\n                                ordencompra.ordenCompra,\r\n                                ordencompra.subtotal,\r\n                                ordencompra.porcentajeDescuento,\r\n                                ordencompra.descuento,\r\n                                ordencompra.porcentajeIva,\r\n                                ordencompra.iva,\r\n                                ordencompra.neto,\r\n                                ordencompra.total,\r\n                                ordencompra.totalPalabras,\r\n                                ordencompra.estadoPago,\r\n                                ordencompra.estadoDocumento,\r\n                                ordencompra.totalPagado,\r\n                                ordencompra.totalDocumentado,\r\n                                ordencompra.totalPendiente,\r\n                                detalleordencompra.idDetalleOrdenCompra,\r\n                                detalleordencompra.idOrdenCompraLinea,\r\n                                detalleordencompra.folioOrdenCompra,\r\n                                detalleordencompra.fechaIngreso,\r\n                                detalleordencompra.codigo,\r\n                                detalleordencompra.descripcion,\r\n                                detalleordencompra.valorVenta,\r\n                                detalleordencompra.cantidad,\r\n                                detalleordencompra.porcentajeDescuentoLinea,\r\n                                detalleordencompra.descuentoLinea,\r\n                                detalleordencompra.subtotalLinea,\r\n                                detalleordencompra.totalLinea,\r\n                                detalleordencompra.tipoDescuento,\r\n                                detalleordencompra.bodega\r\n                                FROM ordencompra INNER JOIN detalleordencompra \r\n                                ON ordencompra.idOrdenCompra = detalleordencompra.idOrdenCompraLinea                             \r\n                                WHERE " + filtro + " ORDER BY ordencompra.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
