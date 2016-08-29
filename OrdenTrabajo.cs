 
// Type: Aptusoft.OrdenTrabajo
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class OrdenTrabajo
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaOT(Venta ot, List<DatosVentaVO> lista)
    {
      this.guardaOT(ot);
      if (lista.Count <= 0)
        return;
      int num = this.retornaIdOC(ot.Folio, ot.Caja);
      foreach (DatosVentaVO dvVO in lista)
      {
        dvVO.IdFactura = num;
        dvVO.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        dvVO.FechaIngreso = ot.FechaEmision;
        this.guardaDetaleOT(dvVO);
      }
    }

    private void guardaOT(Venta ot)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO ordentrabajo (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaEntrega,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax,\r\n                                                            contacto,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento,\r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            estadoDocumento,\r\n                                                            caja,\r\n                                                            datosProducto,\r\n                                                            diagnostico,\r\n                                                            solucion,\r\n                                                            idTecnico,\r\n                                                            tecnico,\r\n                                                            totalCobrado,\r\n                                                            abono,\r\n                                                            saldo,\r\n                                                            idEstadoOT,\r\n                                                            estadoOT, patente \r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaEntrega,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax,\r\n                                                            @contacto,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento,\r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @estadoDocumento,\r\n                                                            @caja,\r\n                                                            @datosProducto,\r\n                                                            @diagnostico,\r\n                                                            @solucion,\r\n                                                            @idTecnico,\r\n                                                            @tecnico,\r\n                                                            @totalCobrado,\r\n                                                            @abono,\r\n                                                            @saldo,\r\n                                                            @idEstadoOT,\r\n                                                            @estadoOT, @patente \r\n                                                   )";
      command.Parameters.AddWithValue("@folio", (object) ot.Folio);
      command.Parameters.AddWithValue("@fechaEmision", (object) ot.FechaEmision);
      command.Parameters.AddWithValue("@fechaEntrega", (object) ot.FechaVencimiento);
      command.Parameters.AddWithValue("@idCliente", (object) ot.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) ot.Rut);
      command.Parameters.AddWithValue("@digito", (object) ot.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) ot.RazonSocial);
      command.Parameters.AddWithValue("@direccion", (object) ot.Direccion);
      command.Parameters.AddWithValue("@comuna", (object) ot.Comuna);
      command.Parameters.AddWithValue("@ciudad", (object) ot.Ciudad);
      command.Parameters.AddWithValue("@giro", (object) ot.Giro);
      command.Parameters.AddWithValue("@fono", (object) ot.Fono);
      command.Parameters.AddWithValue("@fax", (object) ot.Fax);
      command.Parameters.AddWithValue("@contacto", (object) ot.Contacto);
      command.Parameters.AddWithValue("@idVendedor", (object) ot.IdVendedor);
      command.Parameters.AddWithValue("@vendedor", (object) ot.Vendedor);
      command.Parameters.AddWithValue("@subtotal", (object) ot.SubTotal);
      command.Parameters.AddWithValue("@porcentajeDescuento", (object) ot.PorcentajeDescuento);
      command.Parameters.AddWithValue("@descuento", (object) ot.Descuento);
      command.Parameters.AddWithValue("@porcentajeIva", (object) ot.PorcentajeIva);
      command.Parameters.AddWithValue("@iva", (object) ot.Iva);
      command.Parameters.AddWithValue("@neto", (object) ot.Neto);
      command.Parameters.AddWithValue("@total", (object) ot.Total);
      command.Parameters.AddWithValue("@estadoDocumento", (object) ot.EstadoDocumento);
      command.Parameters.AddWithValue("@caja", (object) ot.Caja);
      command.Parameters.AddWithValue("@datosProducto", (object) ot.DatosProducto);
      command.Parameters.AddWithValue("@diagnostico", (object) ot.Diagnostico);
      command.Parameters.AddWithValue("@solucion", (object) ot.Solucion);
      command.Parameters.AddWithValue("@idTecnico", (object) ot.IdTecnicoOT);
      command.Parameters.AddWithValue("@tecnico", (object) ot.TecnicoOT);
      command.Parameters.AddWithValue("@totalCobrado", (object) ot.TotalCobradoOT);
      command.Parameters.AddWithValue("@abono", (object) ot.AbonoOT);
      command.Parameters.AddWithValue("@saldo", (object) ot.SaldoOT);
      command.Parameters.AddWithValue("@idEstadoOT", (object) ot.IdEstadoOT);
      command.Parameters.AddWithValue("@estadoOT", (object) ot.EstadoOT);
      command.Parameters.AddWithValue("@patente", (object) ot.Patente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    private void guardaDetaleOT(DatosVentaVO dvVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detalleordentrabajo (\r\n                                                            idOtLinea,\r\n                                                            folioOt,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idOtLinea,\r\n                                                            @folioOt,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @descuentaInventario,\r\n                                                            @valorCompra\r\n                                                             )";
      command.Parameters.AddWithValue("@idOtLinea", (object) dvVO.IdFactura);
      command.Parameters.AddWithValue("@folioOt", (object) dvVO.FolioFactura);
      command.Parameters.AddWithValue("@fechaIngreso", (object) dvVO.FechaIngreso);
      command.Parameters.AddWithValue("@codigo", (object) dvVO.Codigo);
      command.Parameters.AddWithValue("@descripcion", (object) dvVO.Descripcion);
      command.Parameters.AddWithValue("@valorVenta", (object) dvVO.ValorVenta);
      command.Parameters.AddWithValue("@cantidad", (object) dvVO.Cantidad);
      command.Parameters.AddWithValue("@porcentajeDescuentoLinea", (object) dvVO.PorcDescuento);
      command.Parameters.AddWithValue("@descuentoLinea", (object) dvVO.Descuento);
      command.Parameters.AddWithValue("@subtotalLinea", (object) dvVO.SubTotalLinea);
      command.Parameters.AddWithValue("@totalLinea", (object) dvVO.TotalLinea);
      command.Parameters.AddWithValue("@tipoDescuento", (object) dvVO.TipoDescuento);
      command.Parameters.AddWithValue("@listaPrecio", (object) dvVO.ListaPrecio);
      command.Parameters.AddWithValue("@bodega", (object) dvVO.Bodega);
      command.Parameters.AddWithValue("@idImpuesto", (object) dvVO.IdImpuesto);
      command.Parameters.AddWithValue("@netoLinea", (object) dvVO.NetoLinea);
      command.Parameters.AddWithValue("@descuentaInventario", (dvVO.DescuentaInventario ? 1 : 0));
      command.Parameters.AddWithValue("@valorCompra", (object) dvVO.ValorCompra);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public int obtieneFolioOT(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM ordentrabajo WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int retornaIdOC(int folioOT, int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idOT, folio FROM ordentrabajo WHERE folio=@folioOT AND caja=@caja";
      command.Parameters.AddWithValue("@folioOT", (object) folioOT);
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaOTFolio(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT    idOT, \r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaEntrega,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax,\r\n                                                            contacto,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento,\r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            estadoDocumento,\r\n                                                            caja,\r\n                                                            datosProducto,\r\n                                                            diagnostico,\r\n                                                            solucion,\r\n                                                            idTecnico,\r\n                                                            tecnico,\r\n                                                            totalCobrado,\r\n                                                            abono,\r\n                                                            saldo,\r\n                                                            idEstadoOT,\r\n                                                            estadoOT,\r\n                                                            idDocumentoVenta,\r\n                                                            documentoVenta,\r\n                                                            folioDocumentoVenta, patente  \r\n                                                FROM ordentrabajo WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      Venta venta = new Venta();
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOT"]);
        venta.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]);
        venta.FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]);
        venta.FechaVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEntrega"]);
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
        venta.IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"]);
        venta.Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString();
        venta.SubTotal = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotal"]);
        venta.PorcentajeDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuento"]);
        venta.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuento"]);
        venta.PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]);
        venta.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]);
        venta.Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]);
        venta.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]);
        venta.EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString();
        venta.Caja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["caja"].ToString());
        venta.DatosProducto = ((DbDataReader) mySqlDataReader)["datosProducto"].ToString();
        venta.Diagnostico = ((DbDataReader) mySqlDataReader)["diagnostico"].ToString();
        venta.Solucion = ((DbDataReader) mySqlDataReader)["solucion"].ToString();
        venta.IdTecnicoOT = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTecnico"]);
        venta.TecnicoOT = ((DbDataReader) mySqlDataReader)["tecnico"].ToString();
        venta.TotalCobradoOT = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalCobrado"]);
        venta.AbonoOT = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["abono"]);
        venta.SaldoOT = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["saldo"]);
        venta.IdEstadoOT = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idEstadoOT"]);
        venta.EstadoOT = ((DbDataReader) mySqlDataReader)["estadoOT"].ToString();
        venta.DocumentoVenta = ((DbDataReader) mySqlDataReader)["documentoVenta"].ToString();
        venta.IDDocumentoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDocumentoVenta"]);
        venta.FolioDocumentoVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioDocumentoVenta"]);
        venta.Patente = ((DbDataReader) mySqlDataReader)["patente"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return venta;
    }

    public List<DatosVentaVO> buscaDetalleOTId(int idOT)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleOt, \r\n                                                            idOtLinea,\r\n                                                            folioOt,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            descuentaInventario,\r\n                                                            valorCompra\r\n                                                    FROM detalleordentrabajo WHERE idOtLinea = @idOt ORDER BY idDetalleOt asc";
      command.Parameters.AddWithValue("@idOt", (object) idOT);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleOt"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOtLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioOt"]),
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
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void actualizaOT(Venta ot, List<DatosVentaVO> lista)
    {
      this.modificaOT(ot);
      this.eliminaDetalleOT(ot.IdFactura);
      if (lista.Count <= 0)
        return;
      int idFactura = ot.IdFactura;
      foreach (DatosVentaVO dvVO in lista)
      {
        dvVO.IdFactura = idFactura;
        dvVO.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        dvVO.FechaIngreso = ot.FechaEmision;
        this.guardaDetaleOT(dvVO);
      }
    }

    private void modificaOT(Venta ot)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE ordentrabajo SET                                                            \r\n                                                            fechaEmision=@fechaEmision,\r\n                                                            fechaEntrega=@fechaEntrega,\r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax,\r\n                                                            contacto=@contacto,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento,\r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            estadoDocumento=@estadoDocumento,\r\n                                                            caja=@caja,\r\n                                                            datosProducto=@datosProducto,\r\n                                                            diagnostico=@diagnostico,\r\n                                                            solucion=@solucion,\r\n                                                            idTecnico=@idTecnico,\r\n                                                            tecnico=@tecnico,\r\n                                                            totalCobrado=@totalCobrado,\r\n                                                            abono=@abono,\r\n                                                            saldo=@saldo,\r\n                                                            idEstadoOT=@idEstadoOT,\r\n                                                            estadoOT =@estadoOT ,\r\n                                                            patente =@patente\r\n                                            WHERE idOT=@idOT";
      command.Parameters.AddWithValue("@idOT", (object) ot.IdFactura);
      command.Parameters.AddWithValue("@fechaEmision", (object) ot.FechaEmision);
      command.Parameters.AddWithValue("@fechaEntrega", (object) ot.FechaVencimiento);
      command.Parameters.AddWithValue("@idCliente", (object) ot.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) ot.Rut);
      command.Parameters.AddWithValue("@digito", (object) ot.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) ot.RazonSocial);
      command.Parameters.AddWithValue("@direccion", (object) ot.Direccion);
      command.Parameters.AddWithValue("@comuna", (object) ot.Comuna);
      command.Parameters.AddWithValue("@ciudad", (object) ot.Ciudad);
      command.Parameters.AddWithValue("@giro", (object) ot.Giro);
      command.Parameters.AddWithValue("@fono", (object) ot.Fono);
      command.Parameters.AddWithValue("@fax", (object) ot.Fax);
      command.Parameters.AddWithValue("@contacto", (object) ot.Contacto);
      command.Parameters.AddWithValue("@idVendedor", (object) ot.IdVendedor);
      command.Parameters.AddWithValue("@vendedor", (object) ot.Vendedor);
      command.Parameters.AddWithValue("@subtotal", (object) ot.SubTotal);
      command.Parameters.AddWithValue("@porcentajeDescuento", (object) ot.PorcentajeDescuento);
      command.Parameters.AddWithValue("@descuento", (object) ot.Descuento);
      command.Parameters.AddWithValue("@porcentajeIva", (object) ot.PorcentajeIva);
      command.Parameters.AddWithValue("@iva", (object) ot.Iva);
      command.Parameters.AddWithValue("@neto", (object) ot.Neto);
      command.Parameters.AddWithValue("@total", (object) ot.Total);
      command.Parameters.AddWithValue("@estadoDocumento", (object) ot.EstadoDocumento);
      command.Parameters.AddWithValue("@caja", (object) ot.Caja);
      command.Parameters.AddWithValue("@datosProducto", (object) ot.DatosProducto);
      command.Parameters.AddWithValue("@diagnostico", (object) ot.Diagnostico);
      command.Parameters.AddWithValue("@solucion", (object) ot.Solucion);
      command.Parameters.AddWithValue("@idTecnico", (object) ot.IdTecnicoOT);
      command.Parameters.AddWithValue("@tecnico", (object) ot.TecnicoOT);
      command.Parameters.AddWithValue("@totalCobrado", (object) ot.TotalCobradoOT);
      command.Parameters.AddWithValue("@abono", (object) ot.AbonoOT);
      command.Parameters.AddWithValue("@saldo", (object) ot.SaldoOT);
      command.Parameters.AddWithValue("@idEstadoOT", (object) ot.IdEstadoOT);
      command.Parameters.AddWithValue("@estadoOT", (object) ot.EstadoOT);
      command.Parameters.AddWithValue("@patente", (object) ot.Patente);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaDetalleOT(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detalleordentrabajo WHERE idOtLinea=@id";
      command.Parameters.AddWithValue("@id", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public bool otExiste(int folio)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM ordentrabajo WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void eliminaOT(int idOT)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM ordentrabajo WHERE idOT=@id";
      command.Parameters.AddWithValue("@id", (object) idOT);
      ((DbCommand) command).ExecuteNonQuery();
      this.eliminaDetalleOT(idOT);
    }

    public bool modificaTipoDocumentoOT(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE ordenTrabajo SET documentoVenta = @documentoVenta,\r\n                                                          idDocumentoVenta = @idDocumentoVenta,\r\n                                                          folioDocumentoVenta = @folioDocumentoVenta\r\n                                        WHERE folio=@folio";
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

    public DataTable otInforme(string filtro)
    {
      string str = "SELECT idOT\r\n                                            folio,\r\n                                            fechaEmision,\r\n                                            fechaEntrega,\r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            direccion,\r\n                                            comuna,\r\n                                            ciudad,\r\n                                            giro,\r\n                                            fono,\r\n                                            fax,\r\n                                            contacto,\r\n                                            idVendedor,\r\n                                            vendedor,\r\n                                            subtotal,\r\n                                            porcentajeDescuento,\r\n                                            descuento,\r\n                                            porcentajeIva,\r\n                                            iva,\r\n                                            neto,\r\n                                            total,\r\n                                            estadoDocumento,\r\n                                            caja,\r\n                                            datosProducto,\r\n                                            diagnostico,\r\n                                            solucion,\r\n                                            idTecnico,\r\n                                            tecnico,\r\n                                            totalCobrado,\r\n                                            abono,\r\n                                            saldo,\r\n                                            idEstadoOT,\r\n                                            estadoOT, patente\r\n                                FROM\r\n                                ordentrabajo                                 \r\n                                WHERE " + filtro + " ORDER BY folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable muestraOtFolio(int folio)
    {
      string str = "SELECT\r\n                                        o.idOt,\r\n                                        o.folio,\r\n                                        o.fechaEmision,\r\n                                        o.fechaEntrega,\r\n                                        o.idCliente,\r\n                                        o.rut,\r\n                                        o.digito,\r\n                                        o.razonSocial,\r\n                                        o.direccion,\r\n                                        o.comuna,\r\n                                        o.ciudad,\r\n                                        o.giro,\r\n                                        o.fono,\r\n                                        o.fax,\r\n                                        o.contacto,\r\n                                        o.idVendedor,\r\n                                        o.vendedor,\r\n                                        o.subtotal,\r\n                                        o.porcentajeDescuento,\r\n                                        o.descuento,\r\n                                        o.porcentajeIva,\r\n                                        o.iva,\r\n                                        o.neto,\r\n                                        o.total,\r\n                                        o.estadoDocumento,\r\n                                        o.caja,\r\n                                        o.datosProducto,\r\n                                        o.diagnostico,\r\n                                        o.solucion,\r\n                                        o.idTecnico,\r\n                                        o.tecnico,\r\n                                        o.totalCobrado,\r\n                                        o.abono,\r\n                                        o.saldo,\r\n                                        o.idEstadoOT,\r\n                                        o.estadoOT,o.patente,\r\n                                        d.idDetalleOt,\r\n                                        d.idOtLinea,\r\n                                        d.folioOt,\r\n                                        d.fechaIngreso,\r\n                                        d.codigo,\r\n                                        d.descripcion,\r\n                                        d.valorVenta,\r\n                                        d.cantidad,\r\n                                        d.porcentajeDescuentoLinea,\r\n                                        d.descuentoLinea,\r\n                                        d.subtotalLinea,\r\n                                        d.totalLinea,\r\n                                        d.tipoDescuento,\r\n                                        d.listaPrecio,\r\n                                        d.bodega,\r\n                                        d.idImpuesto,\r\n                                        d.netoLinea,\r\n                                        d.descuentaInventario,\r\n                                        d.valorCompra                                        \r\n                            FROM ordentrabajo o LEFT JOIN detalleordentrabajo d\r\n                            ON o.idOt = d.idOtLinea WHERE o.folio=@folio ORDER BY d.idDetalleOt";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
