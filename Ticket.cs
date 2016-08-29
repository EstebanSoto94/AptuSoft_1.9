 
// Type: Aptusoft.Ticket
 
 
// version 1.8.0

using Aptusoft.Lotes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Ticket
  {
    private Conexion conexion = Conexion.getConecta();
    private string camposTicket = "ticket.idTicket,\r\n                            ticket.folio,\r\n                            ticket.fechaEmision,\r\n                            ticket.fechaVencimiento,\r\n                            ticket.dia,\r\n                            ticket.mes,\r\n                            ticket.ano,\r\n                            ticket.idCliente, \r\n                            ticket.rut, \r\n                            ticket.digito, \r\n                            ticket.razonSocial,\r\n                            ticket.direccion, \r\n                            ticket.comuna, \r\n                            ticket.ciudad, \r\n                            ticket.giro, \r\n                            ticket.fono, \r\n                            ticket.fax, \r\n                            ticket.contacto, \r\n                            ticket.diasPlazo, \r\n                            ticket.idMedioPago,                          \r\n                            ticket.medioPago, \r\n                            ticket.idVendedor, \r\n                            ticket.vendedor, \r\n                            ticket.idCentroCosto, \r\n                            ticket.centroCosto, \r\n                            ticket.ordenCompra, \r\n                            ticket.subtotal, \r\n                            ticket.porcentajeDescuento,\r\n                            ticket.descuento, \r\n                            ticket.porcentajeIva, \r\n                            ticket.iva,\r\n                            ticket.neto, \r\n                            ticket.total, \r\n                            ticket.totalPalabras, \r\n                            ticket.estadoPago, \r\n                            ticket.estadoDocumento, \r\n                            ticket.documentoVenta,\r\n                            ticket.idDocumentoVenta,\r\n                            ticket.folioDocumentoVenta,\r\n                            ticket.impuesto1,\r\n                            ticket.impuesto2,\r\n                            ticket.impuesto3,\r\n                            ticket.impuesto4,\r\n                            ticket.impuesto5,\r\n                            ticket.porcentajeImpuesto1,\r\n                            ticket.porcentajeImpuesto2,\r\n                            ticket.porcentajeImpuesto3,\r\n                            ticket.porcentajeImpuesto4,\r\n                            ticket.porcentajeImpuesto5,\r\n                            ticket.comisionVendedor,\r\n                            ticket.caja,\r\n                            detalleticket.idDetalleTicket,\r\n                            detalleticket.idTicketLinea,\r\n                            detalleticket.folioTicket,\r\n                            detalleticket.fechaIngreso,\r\n                            detalleticket.codigo,\r\n                            detalleticket.descripcion,\r\n                            detalleticket.valorVenta,\r\n                            detalleticket.cantidad,\r\n                            detalleticket.porcentajeDescuentoLinea,\r\n                            detalleticket.descuentoLinea,\r\n                            detalleticket.subtotalLinea, \r\n                            detalleticket.totalLinea, \r\n                            detalleticket.tipoDescuento, \r\n                            detalleticket.listaPrecio, \r\n                            detalleticket.bodega, \r\n                            detalleticket.idImpuesto, \r\n                            detalleticket.netoLinea,\r\n                            detalleticket.valorCompra";

    public string agregaTicket(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO ticket (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            caja                                                            \r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @documentoVenta,\r\n                                                            @idDocumentoVenta,\r\n                                                            @folioDocumentoVenta,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @caja\r\n                                                            \r\n                                                   )";
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
        return "Ticket Ingresado";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleTicket(List<DatosVentaVO> lista, List<LoteVO> listaLote)
    {
      int num1 = 0;
      long num2 = 0L;
      foreach (DatosVentaVO veVO in lista)
      {
        if (num1 == 0)
        {
          num1 = this.retornaIdTicket(veVO.FolioFactura);
          num2 = (long) veVO.FolioFactura;
        }
        veVO.IdFactura = num1;
        this.agregaDetalleTicket2(veVO);
      }
      if (listaLote.Count <= 0)
        return;
      string str = "TICKET";
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

    public bool agregaDetalleTicket2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = veVO.IdFactura;
      if (num == 0)
        num = this.retornaIdTicket(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detalleticket (\r\n                                                            idTicketLinea,\r\n                                                            folioTicket,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            valorCompra\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idFactuLinea,\r\n                                                            @folioFacturaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @valorCompra\r\n                                                             )";
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

    public string anulaTicket(int idTicket, List<DatosVentaVO> lista, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE ticket SET estadoDocumento = 'ANULADO', razonSocial= 'TICKET ANULADO', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0' WHERE idTicket=@idTicket";
      command.Parameters.AddWithValue("@idTicket", (object) idTicket);
      ((DbCommand) command).ExecuteNonQuery();
      if (listaLoteAntigua.Count > 0)
      {
        foreach (LoteVO loteVo in listaLoteAntigua)
          new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
      }
      return "Ticket Anulado!!";
    }

    public int eliminaTicket(int idTicket)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE ticket, detalleticket FROM ticket, detalleticket WHERE ticket.idTicket = @idTicket AND detalleticket.idTicketLinea=@idTicket";
      command.Parameters.AddWithValue("@idTicket", (object) idTicket);
      return ((DbCommand) command).ExecuteNonQuery();
    }

    public int numeroTicket(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM ticket WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int numeroTicketSinCaja()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM ticket";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool ticketExiste(int numTicket)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM ticket WHERE folio=@numTicket";
      command.Parameters.AddWithValue("@numTicket", (object) numTicket);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int retornaIdTicket(int numTicket)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idTicket, folio FROM ticket WHERE folio=@numTicket";
      command.Parameters.AddWithValue("@numTicket", (object) numTicket);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaTicketFolio(int numTicket)
    {
      try
      {
        Venta venta = new Venta();
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT idTicket,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5\r\n                                                                                                                        \r\n\r\n                                        FROM ticket WHERE folio=@numTicket";
        command.Parameters.AddWithValue("@numTicket", (object) numTicket);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicket"]);
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

    public List<DatosVentaVO> buscaDetalleTicketIDTicket(int idTicket)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleTicket, \r\n                                                    idTicketLinea,\r\n                                                    folioTicket,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra\r\n                                                    FROM detalleticket WHERE idTicketLinea = @idTicket ORDER BY idDetalleTicket asc";
      command.Parameters.AddWithValue("@idTicket", (object) idTicket);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleTicket"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicketLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioTicket"]),
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
          IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]),
          NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<DatosVentaVO> buscaDetalleTicketIDTicketBoletaFiscal(int idTicket)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                            d.idDetalleTicket,\r\n                                            d.idTicketLinea,\r\n                                            d.folioTicket,\r\n                                            d.fechaIngreso,\r\n                                            d.codigo,\r\n                                            d.descripcion,\r\n                                            d.valorVenta,\r\n                                            d.cantidad,\r\n                                            d.porcentajeDescuentoLinea,\r\n                                            d.descuentoLinea,\r\n                                            d.subtotalLinea,\r\n                                            d.totalLinea,\r\n                                            d.tipoDescuento,\r\n                                            d.listaPrecio,\r\n                                            d.bodega,\r\n                                            d.idImpuesto,\r\n                                            d.netoLinea,\r\n                                            d.valorCompra,\r\n                                            p.ResumenDescripcion\r\n                                    FROM detalleticket d\r\n                                    LEFT JOIN productos p ON p.Codigo=d.codigo \r\n                                    WHERE d.idTicketLinea = @idTicket ORDER BY d.idDetalleTicket asc";
      command.Parameters.AddWithValue("@idTicket", (object) idTicket);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleTicket"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTicketLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioTicket"]),
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
          IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]),
          NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]),
          ResumenDescripcion = ((DbDataReader) mySqlDataReader)["ResumenDescripcion"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaTicket(Venta veOB, List<DatosVentaVO> listaNueva, List<LoteVO> listaLote, List<LoteVO> listaLoteAntigua)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE ticket SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor                                                            \r\n                                                            \r\n                                           WHERE idTicket=@idTicket AND folio=@folio";
        command.Parameters.AddWithValue("@idTicket", (object) veOB.IdFactura);
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
        this.buscaDetalleTicketIDTicket(veOB.IdFactura);
        this.eliminaDetalleTicket(veOB);
        if (listaLoteAntigua.Count > 0)
        {
          foreach (LoteVO loteVo in listaLoteAntigua)
            new Lote().EliminaDetalleLote(loteVo.IdDetalleLote);
        }
        foreach (DatosVentaVO veVO in listaNueva)
          this.agregaDetalleTicket2(veVO);
        if (listaLote.Count > 0)
        {
          int idFactura = veOB.IdFactura;
          long num = (long) veOB.Folio;
          string str = "TICKET";
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
        return "Ticket Modificado";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool eliminaDetalleTicket(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detalleticket WHERE idTicketLinea=@idTicket AND folioTicket=@folioTicket";
        command.Parameters.AddWithValue("@idTicket", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioTicket", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public bool modificaTipoDocumentoTicket(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE ticket SET documentoVenta = @documentoVenta,\r\n                                                          idDocumentoVenta = @idDocumentoVenta,\r\n                                                          folioDocumentoVenta = @folioDocumentoVenta\r\n                                        WHERE idTicket=@idTicket AND folio=@folio";
        command.Parameters.AddWithValue("@idTicket", (object) veOB.IdFactura);
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

    public DataTable muestraTicketFolio(int folio)
    {
      string str = "SELECT " + this.camposTicket + " FROM ticket INNER JOIN detalleticket ON ticket.idTicket = detalleticket.idTicketLinea WHERE ticket.folio=@folio ORDER BY detalleticket.idDetalleTicket";
      DataTable dataTable1 = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        command.Parameters.AddWithValue("@folio", (object) folio);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable1);
      }
      catch (Exception ex)
      {
        DataTable dataTable2;
        return dataTable2 = (DataTable) null;
      }
      return dataTable1;
    }

    public DataTable ticketInforme(string filtro)
    {
      string str = "SELECT \r\n                                        ticket.idTicket,\r\n                                        ticket.folio,\r\n                                        ticket.fechaEmision,\r\n                                        ticket.fechaVencimiento,\r\n                                        ticket.dia,\r\n                                        ticket.mes,\r\n                                        ticket.ano,\r\n                                        ticket.idCliente, \r\n                                        ticket.rut, \r\n                                        ticket.digito, \r\n                                        ticket.razonSocial,\r\n                                        ticket.direccion, \r\n                                        ticket.comuna, \r\n                                        ticket.ciudad, \r\n                                        ticket.giro, \r\n                                        ticket.fono, \r\n                                        ticket.fax, \r\n                                        ticket.contacto, \r\n                                        ticket.diasPlazo, \r\n                                        ticket.idMedioPago,                          \r\n                                        ticket.medioPago, \r\n                                        ticket.idVendedor, \r\n                                        ticket.vendedor, \r\n                                        ticket.idCentroCosto, \r\n                                        ticket.centroCosto, \r\n                                        ticket.ordenCompra, \r\n                                        ticket.subtotal, \r\n                                        ticket.porcentajeDescuento,\r\n                                        ticket.descuento, \r\n                                        ticket.porcentajeIva, \r\n                                        ticket.iva,\r\n                                        ticket.neto, \r\n                                        ticket.total, \r\n                                        ticket.totalPalabras, \r\n                                        ticket.estadoPago, \r\n                                        ticket.estadoDocumento, \r\n                                        ticket.documentoVenta,\r\n                                        ticket.idDocumentoVenta,\r\n                                        ticket.folioDocumentoVenta,\r\n                                        ticket.impuesto1,\r\n                                        ticket.impuesto2,\r\n                                        ticket.impuesto3,\r\n                                        ticket.impuesto4,\r\n                                        ticket.impuesto5,\r\n                                        ticket.porcentajeImpuesto1,\r\n                                        ticket.porcentajeImpuesto2,\r\n                                        ticket.porcentajeImpuesto3,\r\n                                        ticket.porcentajeImpuesto4,\r\n                                        ticket.porcentajeImpuesto5,\r\n                                        ticket.comisionVendedor,\r\n                                        ticket.caja                                             \r\n                                FROM ticket                             \r\n                                WHERE " + filtro + " ORDER BY ticket.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable ticketInformeDetalle(string filtro)
    {
      string str = "SELECT " + this.camposTicket + " FROM ticket INNER JOIN detalleticket \r\n                                ON ticket.idTicket = detalleticket.idTicketLinea                             \r\n                                WHERE " + filtro + " ORDER BY ticket.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
