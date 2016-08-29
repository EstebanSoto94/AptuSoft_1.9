 
// Type: Aptusoft.Comanda
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Comanda
  {
    private Conexion conexion = Conexion.getConecta();
    private string camposComanda = "comanda.idComanda,\r\n                            comanda.folio,\r\n                            comanda.fechaEmision,                            \r\n                            comanda.dia,\r\n                            comanda.mes,\r\n                            comanda.ano,\r\n                            comanda.idCliente, \r\n                            comanda.rut, \r\n                            comanda.digito, \r\n                            comanda.razonSocial,\r\n                            comanda.direccion, \r\n                            comanda.comuna, \r\n                            comanda.ciudad, \r\n                            comanda.giro, \r\n                            comanda.fono, \r\n                            comanda.fax, \r\n                            comanda.contacto, \r\n                            comanda.diasPlazo, \r\n                            comanda.idMedioPago,                          \r\n                            comanda.medioPago, \r\n                            comanda.idVendedor, \r\n                            comanda.vendedor, \r\n                            comanda.idCentroCosto, \r\n                            comanda.centroCosto, \r\n                            comanda.ordenCompra, \r\n                            comanda.subtotal, \r\n                            comanda.porcentajeDescuento,\r\n                            comanda.descuento, \r\n                            comanda.porcentajeIva, \r\n                            comanda.iva,\r\n                            comanda.neto, \r\n                            comanda.total, \r\n                            comanda.totalPalabras, \r\n                            comanda.estadoPago, \r\n                            comanda.estadoDocumento, \r\n                            comanda.documentoVenta,\r\n                            comanda.idDocumentoVenta,\r\n                            comanda.folioDocumentoVenta,\r\n                            comanda.impuesto1,\r\n                            comanda.impuesto2,\r\n                            comanda.impuesto3,\r\n                            comanda.impuesto4,\r\n                            comanda.impuesto5,\r\n                            comanda.porcentajeImpuesto1,\r\n                            comanda.porcentajeImpuesto2,\r\n                            comanda.porcentajeImpuesto3,\r\n                            comanda.porcentajeImpuesto4,\r\n                            comanda.porcentajeImpuesto5,\r\n                            comanda.comisionVendedor,\r\n                            comanda.caja,comanda.mesa,, comanda.dejaMesa as 'fechaVencimiento',\r\n                            detallecomanda.idDetalleComanda,\r\n                            detallecomanda.idComandaLinea,\r\n                            detallecomanda.folioComanda,\r\n                            detallecomanda.fechaIngreso,\r\n                            detallecomanda.codigo,\r\n                            detallecomanda.descripcion,\r\n                            detallecomanda.valorVenta,\r\n                            detallecomanda.cantidad,\r\n                            detallecomanda.porcentajeDescuentoLinea,\r\n                            detallecomanda.descuentoLinea,\r\n                            detallecomanda.subtotalLinea, \r\n                            detallecomanda.totalLinea, \r\n                            detallecomanda.tipoDescuento, \r\n                            detallecomanda.listaPrecio, \r\n                            detallecomanda.bodega, \r\n                            detallecomanda.idImpuesto, \r\n                            detallecomanda.netoLinea,\r\n                            detallecomanda.valorCompra";

    public string agregaComanda(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO comanda (\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            dia,\r\n                                                            mes,\r\n                                                            ano,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5,\r\n                                                            comisionVendedor,\r\n                                                            caja, mesa                                                            \r\n                                                            ) \r\n                                                   VALUES(                                                            \r\n                                                            @folio,\r\n                                                            @fechaEmision,\r\n                                                            @fechaVencimiento,\r\n                                                            @dia,\r\n                                                            @mes,\r\n                                                            @ano,\r\n                                                            @idCliente,\r\n                                                            @rut,\r\n                                                            @digito,\r\n                                                            @razonSocial,\r\n                                                            @direccion,\r\n                                                            @comuna,\r\n                                                            @ciudad,\r\n                                                            @giro,\r\n                                                            @fono,\r\n                                                            @fax, \r\n                                                            @contacto,\r\n                                                            @diasPlazo,\r\n                                                            @idMedioPago,\r\n                                                            @medioPago,\r\n                                                            @idVendedor,\r\n                                                            @vendedor,\r\n                                                            @idCentroCosto,\r\n                                                            @centroCosto,\r\n                                                            @ordenCompra,\r\n                                                            @subtotal,\r\n                                                            @porcentajeDescuento, \r\n                                                            @descuento,\r\n                                                            @porcentajeIva,\r\n                                                            @iva,\r\n                                                            @neto,\r\n                                                            @total,\r\n                                                            @totalPalabras,\r\n                                                            @estadoPago,\r\n                                                            @estadoDocumento,\r\n                                                            @documentoVenta,\r\n                                                            @idDocumentoVenta,\r\n                                                            @folioDocumentoVenta,\r\n                                                            @impuesto1,\r\n                                                            @impuesto2,\r\n                                                            @impuesto3,\r\n                                                            @impuesto4,\r\n                                                            @impuesto5,\r\n                                                            @porcentajeImpuesto1,\r\n                                                            @porcentajeImpuesto2,\r\n                                                            @porcentajeImpuesto3,\r\n                                                            @porcentajeImpuesto4,\r\n                                                            @porcentajeImpuesto5,\r\n                                                            @comisionVendedor,\r\n                                                            @caja, @mesa\r\n                                                            \r\n                                                   )";
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
        command.Parameters.AddWithValue("@mesa", (object) veOB.Mesa);
        ((DbCommand) command).ExecuteNonQuery();
        return "Comanda Ingresado";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void agregaDetalleComanda(List<DatosVentaVO> lista)
    {
      foreach (DatosVentaVO veVO in lista)
      {
        veVO.Impreso = true;
        Decimal num = this.consultaStock(veVO);
        veVO.StockQueda = num - veVO.Cantidad;
        this.actualizaStock(veVO, "-");
        veVO.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        this.agregaDetalleComanda2(veVO);
      }
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

    public bool agregaDetalleComanda2(DatosVentaVO veVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      int num = this.retornaIdComanda(veVO.FolioFactura);
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO detallecomanda (\r\n                                                            idComandaLinea,\r\n                                                            folioComanda,\r\n                                                            fechaIngreso,\r\n                                                            codigo,\r\n                                                            descripcion,\r\n                                                            valorVenta,\r\n                                                            cantidad,\r\n                                                            porcentajeDescuentoLinea,\r\n                                                            descuentoLinea,\r\n                                                            subtotalLinea,\r\n                                                            totalLinea,\r\n                                                            tipoDescuento,\r\n                                                            listaPrecio,\r\n                                                            bodega,\r\n                                                            idImpuesto,\r\n                                                            netoLinea,\r\n                                                            valorCompra,\r\n                                                            impreso, stockQueda, usuario\r\n                                                             ) \r\n                                                      VALUES(\r\n                                                            @idFactuLinea,\r\n                                                            @folioFacturaLinea,\r\n                                                            @fechaIngreso,\r\n                                                            @codigo,\r\n                                                            @descripcion,\r\n                                                            @valorVenta,\r\n                                                            @cantidad,\r\n                                                            @porcentajeDescuentoLinea,\r\n                                                            @descuentoLinea,\r\n                                                            @subtotalLinea,\r\n                                                            @totalLinea,\r\n                                                            @tipoDescuento,\r\n                                                            @listaPrecio,\r\n                                                            @bodega,\r\n                                                            @idImpuesto,\r\n                                                            @netoLinea,\r\n                                                            @valorCompra,\r\n                                                            @impreso, @stockQueda, @usuario\r\n                                                             )";
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
        command.Parameters.AddWithValue("@impreso", (veVO.Impreso ? 1 : 0));
        command.Parameters.AddWithValue("@stockQueda", (object) veVO.StockQueda);
        command.Parameters.AddWithValue("@usuario", (object) veVO.Usuario);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        string message = ex.Message;
        return false;
      }
    }

    public string anulaComanda(int idComanda, List<DatosVentaVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE comanda SET estadoDocumento = 'ANULADO', razonSocial= 'COMANDA ANULADA', rut='0', digito='0', subtotal='0', descuento='0', neto='0', iva='0',  total='0', impuesto1='0', impuesto2='0',impuesto3='0',impuesto4='0',impuesto5='0' WHERE idComanda=@idComanda";
      command.Parameters.AddWithValue("@idComanda", (object) idComanda);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        new ControlProducto().registroDocumentoNulo(datosVentaVo, "COMANDA");
        this.actualizaStock(datosVentaVo, "+");
      }
      return "Comanda Anulada!!";
    }

    public int eliminaComanda(int idComanda)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE comanda, detallecomanda FROM comanda, detallecomanda WHERE comanda.idComanda = @idComanda AND detallecomanda.idComandaLinea=@idComanda";
      command.Parameters.AddWithValue("@idComanda", (object) idComanda);
      return ((DbCommand) command).ExecuteNonQuery();
    }

    public int numeroComanda(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM comanda WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int numeroComandaSinCaja()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM comanda";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool existeComanda(int numComanda)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM comanda WHERE folio=@numComanda";
      command.Parameters.AddWithValue("@numcomanda", (object) numComanda);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int retornaIdComanda(int numComanda)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idComanda, folio FROM comanda WHERE folio=@numComanda";
      command.Parameters.AddWithValue("@numComanda", (object) numComanda);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public Venta buscaComandaFolio(int numComanda)
    {
      try
      {
        Venta venta = new Venta();
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = "SELECT idComanda,\r\n                                                            folio,\r\n                                                            fechaEmision,\r\n                                                            fechaVencimiento,\r\n                                                            idCliente,\r\n                                                            rut,\r\n                                                            digito,\r\n                                                            razonSocial,\r\n                                                            direccion,\r\n                                                            comuna,\r\n                                                            ciudad,\r\n                                                            giro,\r\n                                                            fono,\r\n                                                            fax, \r\n                                                            contacto,\r\n                                                            diasPlazo,\r\n                                                            idMedioPago,\r\n                                                            medioPago,\r\n                                                            idVendedor,\r\n                                                            vendedor,\r\n                                                            idCentroCosto,\r\n                                                            centroCosto,\r\n                                                            ordenCompra,\r\n                                                            subtotal,\r\n                                                            porcentajeDescuento, \r\n                                                            descuento,\r\n                                                            porcentajeIva,\r\n                                                            iva,\r\n                                                            neto,\r\n                                                            total,\r\n                                                            totalPalabras,\r\n                                                            estadoPago,\r\n                                                            estadoDocumento,\r\n                                                            documentoVenta,\r\n                                                            idDocumentoVenta,\r\n                                                            folioDocumentoVenta,\r\n                                                            impuesto1,\r\n                                                            impuesto2,\r\n                                                            impuesto3,\r\n                                                            impuesto4,\r\n                                                            impuesto5,\r\n                                                            porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5, mesa                                                                                                                        \r\n\r\n                                        FROM comanda WHERE folio=@numComanda";
        command.Parameters.AddWithValue("@numComanda", (object) numComanda);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          venta.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idComanda"]);
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
          venta.Mesa = ((DbDataReader) mySqlDataReader)["mesa"].ToString();
        }
        ((DbDataReader) mySqlDataReader).Close();
        return venta;
      }
      catch
      {
        return (Venta) null;
      }
    }

    public List<DatosVentaVO> buscaDetalleComandaIDComanda(int idComanda)
    {
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleComanda, \r\n                                                    idComandaLinea,\r\n                                                    folioComanda,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra, impreso\r\n                                                    FROM detallecomanda WHERE idComandaLinea = @idComanda ORDER BY idDetalleComanda asc";
      command.Parameters.AddWithValue("@idComanda", (object) idComanda);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosVentaVO()
        {
          IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleComanda"]),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idComandaLinea"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioComanda"]),
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
          Impreso = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["impreso"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string modificaComanda(Venta veOB, List<DatosVentaVO> listaNueva)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE comanda SET fechaEmision=@fechaEmision,\r\n                                                            fechaVencimiento=@fechaVencimiento,\r\n                                                            dia=@dia,\r\n                                                            mes=@mes,\r\n                                                            ano=@ano,                                                            \r\n                                                            idCliente=@idCliente,\r\n                                                            rut=@rut,\r\n                                                            digito=@digito,\r\n                                                            razonSocial=@razonSocial,\r\n                                                            direccion=@direccion,\r\n                                                            comuna=@comuna,\r\n                                                            ciudad=@ciudad,\r\n                                                            giro=@giro,\r\n                                                            fono=@fono,\r\n                                                            fax=@fax, \r\n                                                            contacto=@contacto,\r\n                                                            diasPlazo=@diasPlazo,\r\n                                                            idMedioPago=@idMedioPago,\r\n                                                            medioPago=@medioPago,\r\n                                                            idVendedor=@idVendedor,\r\n                                                            vendedor=@vendedor,\r\n                                                            idCentroCosto=@idCentroCosto,\r\n                                                            centroCosto=@centroCosto,\r\n                                                            ordenCompra=@ordenCompra,\r\n                                                            subtotal=@subtotal,\r\n                                                            porcentajeDescuento=@porcentajeDescuento, \r\n                                                            descuento=@descuento,\r\n                                                            porcentajeIva=@porcentajeIva,\r\n                                                            iva=@iva,\r\n                                                            neto=@neto,\r\n                                                            total=@total,\r\n                                                            totalPalabras=@totalPalabras,\r\n                                                            estadoPago=@estadoPago,\r\n                                                            impuesto1=@impuesto1,\r\n                                                            impuesto2=@impuesto2,\r\n                                                            impuesto3=@impuesto3,\r\n                                                            impuesto4=@impuesto4,\r\n                                                            impuesto5=@impuesto5,\r\n                                                            porcentajeImpuesto1=@porcentajeImpuesto1,\r\n                                                            porcentajeImpuesto2=@porcentajeImpuesto2,\r\n                                                            porcentajeImpuesto3=@porcentajeImpuesto3,\r\n                                                            porcentajeImpuesto4=@porcentajeImpuesto4,\r\n                                                            porcentajeImpuesto5=@porcentajeImpuesto5,\r\n                                                            comisionVendedor=@comisionVendedor,                                                            \r\n                                                            mesa=@mesa\r\n                                           WHERE idComanda=@idComanda AND folio=@folio";
        command.Parameters.AddWithValue("@idComanda", (object) veOB.IdFactura);
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
        command.Parameters.AddWithValue("@mesa", (object) veOB.Mesa);
        ((DbCommand) command).ExecuteNonQuery();
        foreach (DatosVentaVO datosVentaVo in this.buscaDetalleComandaIDComanda(veOB.IdFactura))
        {
          new ControlProducto().registroDocumentoModifica(datosVentaVo, "COMANDA");
          new ControlProducto().registroDocumentoModificaRetornaInventario(datosVentaVo, "COMANDA");
          this.actualizaStock(datosVentaVo, "+");
        }
        this.eliminaDetalleComanda(veOB);
        foreach (DatosVentaVO veVO in listaNueva)
        {
          Decimal num = this.consultaStock(veVO);
          veVO.StockQueda = num - veVO.Cantidad;
          veVO.Impreso = true;
          veVO.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
          this.agregaDetalleComanda2(veVO);
          this.actualizaStock(veVO, "-");
        }
        return "Comanda Modificada";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public bool eliminaDetalleComanda(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM detallecomanda WHERE idComandaLinea=@idComanda AND folioComanda=@folioComanda";
        command.Parameters.AddWithValue("@idComanda", (object) veOB.IdFactura);
        command.Parameters.AddWithValue("@folioComanda", (object) veOB.Folio);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public bool modificaTipoDocumentoComanda(Venta veOB)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE comanda SET documentoVenta = @documentoVenta,\r\n                                                          idDocumentoVenta = @idDocumentoVenta,\r\n                                                          folioDocumentoVenta = @folioDocumentoVenta,\r\n                                                          dejaMesa=@dejaMesa\r\n                                        WHERE folio=@folio";
        command.Parameters.AddWithValue("@folio", (object) veOB.Folio);
        command.Parameters.AddWithValue("@documentoVenta", (object) veOB.DocumentoVenta);
        command.Parameters.AddWithValue("@idDocumentoVenta", (object) veOB.IDDocumentoVenta);
        command.Parameters.AddWithValue("@folioDocumentoVenta", (object) veOB.FolioDocumentoVenta);
        command.Parameters.AddWithValue("@dejaMesa", (object) DateTime.Now);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch
      {
        return false;
      }
    }

    public List<Venta> buscaComandaLlevarDomicilio()
    {
      List<Venta> list = new List<Venta>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio, fechaEmision, razonSocial, mesa\r\n                                                    FROM comanda WHERE (mesa = 'LLEVAR' OR mesa='DOMICILIO') AND folioDocumentoVenta=0 ORDER BY folio asc";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new Venta()
        {
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"].ToString()),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"].ToString()),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Mesa = ((DbDataReader) mySqlDataReader)["mesa"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public DataTable muestraComandaFolio(int folio)
    {
      string str = "SELECT " + this.camposComanda + " FROM comanda INNER JOIN detallecomanda ON comanda.idComanda = detallecomanda.idComandaLinea WHERE comanda.folio=@folio ORDER BY detalleComanda.idDetalleComanda";
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

    public DataTable comandaInforme(string filtro)
    {
      string str = "SELECT \r\n                                        comanda.idComanda,\r\n                                        comanda.folio,\r\n                                        comanda.fechaEmision,                                        \r\n                                        comanda.dia,\r\n                                        comanda.mes,\r\n                                        comanda.ano,\r\n                                        comanda.idCliente, \r\n                                        comanda.rut, \r\n                                        comanda.digito, \r\n                                        comanda.razonSocial,\r\n                                        comanda.direccion, \r\n                                        comanda.comuna, \r\n                                        comanda.ciudad, \r\n                                        comanda.giro, \r\n                                        comanda.fono, \r\n                                        comanda.fax, \r\n                                        comanda.contacto, \r\n                                        comanda.diasPlazo, \r\n                                        comanda.idMedioPago,                          \r\n                                        comanda.medioPago, \r\n                                        comanda.idVendedor, \r\n                                        comanda.vendedor, \r\n                                        comanda.idCentroCosto, \r\n                                        comanda.centroCosto, \r\n                                        comanda.ordenCompra, \r\n                                        comanda.subtotal, \r\n                                        comanda.porcentajeDescuento,\r\n                                        comanda.descuento, \r\n                                        comanda.porcentajeIva, \r\n                                        comanda.iva,\r\n                                        comanda.neto, \r\n                                        comanda.total, \r\n                                        comanda.totalPalabras, \r\n                                        comanda.estadoPago, \r\n                                        comanda.estadoDocumento, \r\n                                        comanda.documentoVenta,\r\n                                        comanda.idDocumentoVenta,\r\n                                        comanda.folioDocumentoVenta,\r\n                                        comanda.impuesto1,\r\n                                        comanda.impuesto2,\r\n                                        comanda.impuesto3,\r\n                                        comanda.impuesto4,\r\n                                        comanda.impuesto5,\r\n                                        comanda.porcentajeImpuesto1,\r\n                                        comanda.porcentajeImpuesto2,\r\n                                        comanda.porcentajeImpuesto3,\r\n                                        comanda.porcentajeImpuesto4,\r\n                                        comanda.porcentajeImpuesto5,\r\n                                        comanda.comisionVendedor,\r\n                                        comanda.caja, comanda.mesa, comanda.dejaMesa as 'fechaVencimiento'                                             \r\n                                FROM comanda                             \r\n                                WHERE " + filtro + " ORDER BY comanda.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable comandaInformeDetalle(string filtro)
    {
      string str = "SELECT " + this.camposComanda + " FROM comanda INNER JOIN detallecomanda \r\n                                ON comanda.idComanda = detalleComanda.idComandaLinea                             \r\n                                WHERE " + filtro + " ORDER BY comanda.folio";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
