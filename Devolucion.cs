 
// Type: Aptusoft.Devolucion
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows;
using System.Xml;

namespace Aptusoft
{
  public class Devolucion
  {
    private Conexion conexion = Conexion.getConecta();

    public int numeroDevolucion(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM devolucion WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public DatosVentaVO buscaProductoEnBoleta(int folioBoleta, string codigo, string documento, int idBoleta)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      DatosVentaVO datosVentaVo = new DatosVentaVO();
      if (documento.Equals("NORMAL"))
      {
        ((DbCommand) command).CommandText = "SELECT idDetalleBoleta, \r\n                                                    idBoletaLinea,\r\n                                                    folioBoleta,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    exento,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra\r\n                                                    FROM detalleboleta WHERE folioBoleta = @folioBoleta AND codigo=@codigo ORDER BY idDetalleBoleta asc";
        command.Parameters.AddWithValue("@folioBoleta", (object) folioBoleta);
        command.Parameters.AddWithValue("@codigo", (object) codigo);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          datosVentaVo.IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleBoleta"]);
          datosVentaVo.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoletaLinea"]);
          datosVentaVo.FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioBoleta"]);
          datosVentaVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
          datosVentaVo.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
          datosVentaVo.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
          datosVentaVo.ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"]);
          datosVentaVo.Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"]);
          datosVentaVo.PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuentoLinea"]);
          datosVentaVo.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoLinea"]);
          datosVentaVo.SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"]);
          datosVentaVo.TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"]);
          datosVentaVo.TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"]);
          datosVentaVo.ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"]);
          datosVentaVo.Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"]);
          datosVentaVo.Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]);
          datosVentaVo.IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]);
          datosVentaVo.NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]);
          datosVentaVo.ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]);
        }
        ((DbDataReader) mySqlDataReader).Close();
      }
      if (documento.Equals("FISCAL"))
      {
        ((DbCommand) command).CommandText = "SELECT idDetalleBoleta, \r\n                                                    idBoletaLinea,\r\n                                                    folioBoleta,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    exento,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra\r\n                                                    FROM detalleboletafiscal WHERE folioBoleta = @folioBoleta AND idBoletaLinea=@idBoleta AND codigo=@codigo ORDER BY idDetalleBoleta asc";
        command.Parameters.AddWithValue("@folioBoleta", (object) folioBoleta);
        command.Parameters.AddWithValue("@codigo", (object) codigo);
        command.Parameters.AddWithValue("@idBoleta", (object) idBoleta);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          datosVentaVo.IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleBoleta"]);
          datosVentaVo.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoletaLinea"]);
          datosVentaVo.FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioBoleta"]);
          datosVentaVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
          datosVentaVo.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
          datosVentaVo.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
          datosVentaVo.ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"]);
          datosVentaVo.Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"]);
          datosVentaVo.PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuentoLinea"]);
          datosVentaVo.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoLinea"]);
          datosVentaVo.SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"]);
          datosVentaVo.TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"]);
          datosVentaVo.TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"]);
          datosVentaVo.ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"]);
          datosVentaVo.Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"]);
          datosVentaVo.Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]);
          datosVentaVo.IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]);
          datosVentaVo.NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]);
          datosVentaVo.ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]);
        }
        ((DbDataReader) mySqlDataReader).Close();
      }
      if (documento.Equals("VOUCHER"))
      {
        ((DbCommand) command).CommandText = "SELECT idDetalleBoleta, \r\n                                                    idBoletaLinea,\r\n                                                    folioBoleta,\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    exento,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra\r\n                                                    FROM detalleboleta WHERE idBoletaLinea = @idBoleta AND codigo=@codigo ORDER BY idDetalleBoleta asc";
        command.Parameters.AddWithValue("@codigo", (object) codigo);
        command.Parameters.AddWithValue("@idBoleta", (object) idBoleta);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          datosVentaVo.IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleBoleta"]);
          datosVentaVo.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoletaLinea"]);
          datosVentaVo.FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioBoleta"]);
          datosVentaVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
          datosVentaVo.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
          datosVentaVo.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
          datosVentaVo.ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"]);
          datosVentaVo.Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"]);
          datosVentaVo.PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuentoLinea"]);
          datosVentaVo.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoLinea"]);
          datosVentaVo.SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"]);
          datosVentaVo.TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"]);
          datosVentaVo.TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"]);
          datosVentaVo.ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"]);
          datosVentaVo.Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"]);
          datosVentaVo.Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]);
          datosVentaVo.IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]);
          datosVentaVo.NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]);
          datosVentaVo.ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]);
        }
        ((DbDataReader) mySqlDataReader).Close();
      }
      if (documento.Equals("FACTURA_ELECTRONICA"))
      {
        ((DbCommand) command).CommandText = "SELECT idDetallefactura AS 'idDetalleBoleta', \r\n                                                    idFacturaLinea AS 'idBoletaLinea',\r\n                                                    folioFactura AS 'folioBoleta',\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    exento,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra\r\n                                                    FROM electronica_detalle_factura WHERE folioFactura = @folioBoleta AND codigo=@codigo ORDER BY idDetallefactura asc";
        command.Parameters.AddWithValue("@codigo", (object) codigo);
        command.Parameters.AddWithValue("@folioBoleta", (object) folioBoleta);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          datosVentaVo.IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleBoleta"]);
          datosVentaVo.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoletaLinea"]);
          datosVentaVo.FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioBoleta"]);
          datosVentaVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
          datosVentaVo.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
          datosVentaVo.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
          datosVentaVo.ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"]);
          datosVentaVo.Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"]);
          datosVentaVo.PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuentoLinea"]);
          datosVentaVo.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoLinea"]);
          datosVentaVo.SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"]);
          datosVentaVo.TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"]);
          datosVentaVo.TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"]);
          datosVentaVo.ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"]);
          datosVentaVo.Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"]);
          datosVentaVo.Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]);
          datosVentaVo.IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]);
          datosVentaVo.NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]);
          datosVentaVo.ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]);
        }
        ((DbDataReader) mySqlDataReader).Close();
      }
      if (documento.Equals("GUIA_ELECTRONICA"))
      {
        ((DbCommand) command).CommandText = "SELECT idDetalleGuia AS 'idDetalleBoleta', \r\n                                                    idGuiaLinea AS 'idBoletaLinea',\r\n                                                    folioGuia AS 'folioBoleta',\r\n                                                    fechaIngreso,\r\n                                                    codigo,\r\n                                                    descripcion,\r\n                                                    valorVenta,\r\n                                                    cantidad,\r\n                                                    porcentajeDescuentoLinea,\r\n                                                    descuentoLinea,\r\n                                                    subtotalLinea,\r\n                                                    totalLinea,\r\n                                                    tipoDescuento,\r\n                                                    listaPrecio,\r\n                                                    bodega,\r\n                                                    exento,\r\n                                                    idImpuesto,\r\n                                                    netoLinea,\r\n                                                    valorCompra\r\n                                                    FROM electronica_detalle_guia WHERE folioGuia = @folioBoleta AND codigo=@codigo ORDER BY idDetalleGuia asc";
        command.Parameters.AddWithValue("@codigo", (object) codigo);
        command.Parameters.AddWithValue("@folioBoleta", (object) folioBoleta);
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          datosVentaVo.IdDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleBoleta"]);
          datosVentaVo.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoletaLinea"]);
          datosVentaVo.FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioBoleta"]);
          datosVentaVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
          datosVentaVo.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
          datosVentaVo.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
          datosVentaVo.ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"]);
          datosVentaVo.Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"]);
          datosVentaVo.PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuentoLinea"]);
          datosVentaVo.Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoLinea"]);
          datosVentaVo.SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"]);
          datosVentaVo.TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"]);
          datosVentaVo.TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"]);
          datosVentaVo.ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"]);
          datosVentaVo.Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"]);
          datosVentaVo.Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["exento"]);
          datosVentaVo.IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idImpuesto"]);
          datosVentaVo.NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"]);
          datosVentaVo.ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"]);
        }
        ((DbDataReader) mySqlDataReader).Close();
      }
      return datosVentaVo;
    }

    public void guardaDevolucion(DevolucionVO dev, List<DatosDevolucionVO> listaRepone, List<DatosDevolucionVO> listaSaca)
    {
      if (!this.agregaDevolucion(dev))
        return;
      int num1 = this.retornaIdDevolucion(dev.Folio);
      foreach (DatosDevolucionVO ddVO in listaRepone)
      {
        ddVO.IdDevolucion = num1;
        ddVO.FechaIngreso = dev.Fecha;
        Decimal num2 = this.consultaStock(ddVO);
        ddVO.StockQueda = num2 + ddVO.Cantidad;
        this.agregaDetalleDevolucion(ddVO);
        this.actualizaStock(ddVO, "+");
      }
      foreach (DatosDevolucionVO ddVO in listaSaca)
      {
        ddVO.IdDevolucion = num1;
        ddVO.FechaIngreso = dev.Fecha;
        Decimal num2 = this.consultaStock(ddVO);
        ddVO.StockQueda = num2 - ddVO.Cantidad;
        this.agregaDetalleDevolucion(ddVO);
        this.actualizaStock(ddVO, "-");
      }
    }
    private String[] Coneccion()
    {
        XmlDocument xd = new XmlDocument();
        xd.Load(@"C:\AptuSoft\xml\config.xml");
        XmlNodeList nodelist = xd.SelectNodes("datos/Conexion"); // get all <testcase> nodes
        String[] Con = new String[6];
        foreach (XmlNode node in nodelist) // for each <testcase> node
        {
            if (node.SelectSingleNode("principal").InnerText == "1")
            {
                try
                {
                    Con[0] = node.SelectSingleNode("server").InnerText;
                    Con[1] = node.SelectSingleNode("base").InnerText;
                    Con[2] = node.SelectSingleNode("user").InnerText;
                    Con[3] = node.SelectSingleNode("pass").InnerText;
                    Con[4] = node.SelectSingleNode("rutaElectronica").InnerText;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error in reading XML", "xmlError");
                }
            }
        }
        return Con;
    }
    public String Total_boleta(int Folio, String TipoDoc)
    {
        String[] con = Coneccion();
        string db = "";
        string campo = "";
        string total = "0";
        if (TipoDoc == "Boleta") { db = "Boletas"; campo = "folio"; }
        else if (TipoDoc == "Boleta Fiscal") { db = "BoletasFiscal"; campo = "folio"; }
        else if (TipoDoc == "Voucher") { db = "Boletas"; campo = "folioTicket"; }
        else if (TipoDoc == "Factura Electronica") { db = "electronica_factura"; campo = "folio"; }
        else if (TipoDoc == "Guia Electronica") { db = "electronica_guia"; campo = "folio"; }
        MySqlConnection conexion = new MySqlConnection();
        string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
        MySqlCommand command = conexion.CreateCommand();
        ((DbCommand)command).CommandText = "Select total from " + db + " where "+campo+" = @tipo";
        command.Parameters.AddWithValue("@tipo", Folio.ToString());
        conexion.ConnectionString = cadenaConexion;
        try
        {
            conexion.Open();
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            while (((DbDataReader)mySqlDataReader).Read())
            {
                total = mySqlDataReader["total"].ToString();
            }


            mySqlDataReader.Close();
            // MessageBox.Show("Conectado");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);


        }
        decimal t = Convert.ToDecimal(total);
        string aux = t.ToString("N0");
        return aux;
    }

    public bool agregaDevolucion(DevolucionVO dev)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO devolucion (\r\n                                                                folio,\r\n                                                                fecha,\r\n                                                                folioBoleta,cajaBoleta,\r\n                                                                idVendedor,\r\n                                                                vendedor,\r\n                                                                total,\r\n                                                                caja,\r\n                                                                documento) \r\n                                                        VALUES (\r\n                                                                @folio,\r\n                                                                @fecha,\r\n                                                                @folioBoleta,@cajaBoleta,\r\n                                                                @idVendedor,\r\n                                                                @vendedor,\r\n                                                                @total,\r\n                                                                @caja,\r\n                                                                @documento\r\n                                                                )";
        command.Parameters.AddWithValue("@folio", (object) dev.Folio);
        command.Parameters.AddWithValue("@fecha", (object) dev.Fecha);
        command.Parameters.AddWithValue("@folioBoleta", (object) dev.FolioBoleta);
        command.Parameters.AddWithValue("@idVendedor", (object) dev.IdVendedor);
        command.Parameters.AddWithValue("@vendedor", (object) dev.Vendedor);
        command.Parameters.AddWithValue("@total", (object) dev.Total);
        command.Parameters.AddWithValue("@caja", (object) dev.Caja);
        command.Parameters.AddWithValue("@cajaBoleta", (object) dev.CajaBoleta);
        command.Parameters.AddWithValue("@documento", (object) dev.Documento);
        ((DbCommand) command).ExecuteNonQuery();
        return true;
      }
      catch
      {
        return false;
      }
    }

    public void agregaDetalleDevolucion(DatosDevolucionVO ddVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detalledevolucion (\r\n                                                                idDevolucion,\r\n                                                                folioDevolucion,\r\n                                                                fechaIngreso,\r\n                                                                estado,\r\n                                                                codigo,\r\n                                                                descripcion,\r\n                                                                valorVenta,\r\n                                                                cantidad,\r\n                                                                porcentajeDescuento,\r\n                                                                descuento,\r\n                                                                subtotalLinea,\r\n                                                                totalLinea,\r\n                                                                tipoDescuento,\r\n                                                                listaPrecio,\r\n                                                                bodega,                                                                \r\n                                                                netoLinea,\r\n                                                                valorCompra,\r\n                                                                usuario,\r\n                                                                stockQueda\r\n                                                                ) \r\n                                                        VALUES (\r\n                                                                @idDevolucion,\r\n                                                                @folioDevolucion,\r\n                                                                @fechaIngreso,\r\n                                                                @estado,\r\n                                                                @codigo,\r\n                                                                @descripcion,\r\n                                                                @valorVenta,\r\n                                                                @cantidad,\r\n                                                                @porcentajeDescuento,\r\n                                                                @descuento,\r\n                                                                @subtotalLinea,\r\n                                                                @totalLinea,\r\n                                                                @tipoDescuento,\r\n                                                                @listaPrecio,\r\n                                                                @bodega,                                                                \r\n                                                                @netoLinea,\r\n                                                                @valorCompra,\r\n                                                                @usuario,\r\n                                                                @stockQueda\r\n                                                                )";
      command.Parameters.AddWithValue("@idDevolucion", (object) ddVO.IdDevolucion);
      command.Parameters.AddWithValue("@folioDevolucion", (object) ddVO.Folio);
      command.Parameters.AddWithValue("@fechaIngreso", (object) ddVO.FechaIngreso);
      command.Parameters.AddWithValue("@estado", (object) ddVO.Estado);
      command.Parameters.AddWithValue("@codigo", (object) ddVO.Codigo);
      command.Parameters.AddWithValue("@descripcion", (object) ddVO.Descripcion);
      command.Parameters.AddWithValue("@valorVenta", (object) ddVO.ValorVenta);
      command.Parameters.AddWithValue("@cantidad", (object) ddVO.Cantidad);
      command.Parameters.AddWithValue("@porcentajeDescuento", (object) ddVO.PorcDescuento);
      command.Parameters.AddWithValue("@descuento", (object) ddVO.Descuento);
      command.Parameters.AddWithValue("@subtotalLinea", (object) ddVO.SubTotalLinea);
      command.Parameters.AddWithValue("@totalLinea", (object) ddVO.TotalLinea);
      command.Parameters.AddWithValue("@tipoDescuento", (object) ddVO.TipoDescuento);
      command.Parameters.AddWithValue("@listaPrecio", (object) ddVO.ListaPrecio);
      command.Parameters.AddWithValue("@bodega", (object) ddVO.Bodega);
      command.Parameters.AddWithValue("@netoLinea", (object) ddVO.NetoLinea);
      command.Parameters.AddWithValue("@valorCompra", (object) ddVO.ValorCompra);
      command.Parameters.AddWithValue("@usuario", (object) ddVO.Usuario);
      command.Parameters.AddWithValue("@stockQueda", (object) ddVO.StockQueda);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public Decimal consultaStock(DatosDevolucionVO ddVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string codigo = ddVO.Codigo;
      int bodega = ddVO.Bodega;
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

    public int retornaIdDevolucion(int folio)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDevolucion, folio FROM devolucion WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public void actualizaStock(DatosDevolucionVO ddVO, string signo)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string codigo = ddVO.Codigo;
      int bodega = ddVO.Bodega;
      Decimal cantidad = ddVO.Cantidad;
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

    public DevolucionVO buscaDevolucion(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDevolucion, folio, fecha, folioBoleta, cajaBoleta, idVendedor, vendedor, total, caja, documento FROM devolucion WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      DevolucionVO devolucionVo = new DevolucionVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        devolucionVo = new DevolucionVO();
        devolucionVo.IdDevolucion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDevolucion"].ToString());
        devolucionVo.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"].ToString());
        devolucionVo.Fecha = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fecha"].ToString());
        devolucionVo.FolioBoleta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioBoleta"].ToString());
        devolucionVo.IdVendedor = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"].ToString());
        devolucionVo.Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString();
        devolucionVo.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString());
        devolucionVo.Caja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["caja"].ToString());
        devolucionVo.Documento = ((DbDataReader) mySqlDataReader)["documento"].ToString();
        devolucionVo.CajaBoleta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["cajaBoleta"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      return devolucionVo;
    }

    public List<DatosDevolucionVO> buscaDetalleDevolucion(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleDevolucion,\r\n                                            idDevolucion,\r\n                                            folioDevolucion,\r\n                                            fechaIngreso,\r\n                                            estado,\r\n                                            codigo,\r\n                                            descripcion,\r\n                                            valorVenta,\r\n                                            cantidad,\r\n                                            porcentajeDescuento,\r\n                                            descuento,\r\n                                            subtotalLinea,\r\n                                            totalLinea,\r\n                                            tipoDescuento,\r\n                                            listaPrecio,\r\n                                            bodega,                                                                \r\n                                            netoLinea,\r\n                                            valorCompra FROM detalledevolucion WHERE folioDevolucion=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      DatosDevolucionVO datosDevolucionVo = new DatosDevolucionVO();
      List<DatosDevolucionVO> list = new List<DatosDevolucionVO>();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DatosDevolucionVO()
        {
          IdDetalleDevolucion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleDevolucion"].ToString()),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioDevolucion"].ToString()),
          IdDevolucion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDevolucion"].ToString()),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString(),
          Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorVenta"].ToString()),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString()),
          PorcDescuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeDescuento"].ToString()),
          Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuento"].ToString()),
          SubTotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["subtotalLinea"].ToString()),
          TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"].ToString()),
          TipoDescuento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDescuento"].ToString()),
          ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"].ToString()),
          Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString()),
          NetoLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["netoLinea"].ToString()),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["valorCompra"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    private void registroEliminaDevolucionRepone(DatosDevolucionVO ddVO)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = ddVO.Codigo;
      cp.DescripcionProducto = ddVO.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ELIMINA DEVOLUCION - REPONE FOLIO: " + (object) ddVO.Folio;
      cp.Bodega = ddVO.Bodega;
      Decimal num = this.consultaStock(ddVO);
      cp.CantidadAnterior = num;
      cp.CantidadActual = num - ddVO.Cantidad;
      controlProducto.agregaControlProducto(cp);
    }

    private void registroEliminaDevolucionSaca(DatosDevolucionVO ddVO)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = ddVO.Codigo;
      cp.DescripcionProducto = ddVO.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ELIMINA DEVOLUCION - SACA FOLIO: " + (object) ddVO.Folio;
      cp.Bodega = ddVO.Bodega;
      Decimal num = this.consultaStock(ddVO);
      cp.CantidadAnterior = num;
      cp.CantidadActual = num + ddVO.Cantidad;
      controlProducto.agregaControlProducto(cp);
    }

    public void eliminaDevolucion(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM devolucion WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaDetalleDevolucion(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detalledevolucion WHERE folioDevolucion=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaDetalleDevolucionLista(int folio, List<DatosDevolucionVO> listaRepone, List<DatosDevolucionVO> listaSaca)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detalledevolucion WHERE folioDevolucion=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosDevolucionVO ddVO in listaRepone)
      {
        this.registroEliminaDevolucionRepone(ddVO);
        this.actualizaStock(ddVO, "-");
      }
      foreach (DatosDevolucionVO ddVO in listaSaca)
      {
        this.registroEliminaDevolucionSaca(ddVO);
        this.actualizaStock(ddVO, "+");
      }
    }

    public void modificaDevolucion(DevolucionVO dev, List<DatosDevolucionVO> listaRepone, List<DatosDevolucionVO> listaSaca)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE devolucion SET fecha=@fecha, idVendedor=@idVendedor, vendedor=@vendedor, total=@total, caja=@caja WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) dev.Folio);
      command.Parameters.AddWithValue("@fecha", (object) dev.Fecha);
      command.Parameters.AddWithValue("@idVendedor", (object) dev.IdVendedor);
      command.Parameters.AddWithValue("@vendedor", (object) dev.Vendedor);
      command.Parameters.AddWithValue("@total", (object) dev.Total);
      command.Parameters.AddWithValue("@caja", (object) dev.Caja);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (DatosDevolucionVO ddVO in this.buscaDetalleDevolucion(dev.Folio))
      {
        if (ddVO.Estado.Equals("ENTRA"))
          this.actualizaStock(ddVO, "-");
        else
          this.actualizaStock(ddVO, "+");
        this.eliminaDetalleDevolucion(dev.Folio);
      }
      foreach (DatosDevolucionVO ddVO in listaRepone)
      {
        ddVO.FechaIngreso = dev.Fecha;
        Decimal num = this.consultaStock(ddVO);
        ddVO.StockQueda = num + ddVO.Cantidad;
        this.agregaDetalleDevolucion(ddVO);
        this.actualizaStock(ddVO, "+");
      }
      foreach (DatosDevolucionVO ddVO in listaSaca)
      {
        ddVO.FechaIngreso = dev.Fecha;
        Decimal num = this.consultaStock(ddVO);
        ddVO.StockQueda = num - ddVO.Cantidad;
        this.agregaDetalleDevolucion(ddVO);
        this.actualizaStock(ddVO, "-");
      }
    }

    public bool buscaBoletaEnDevolucion(string folioBoleta, string caja, string documento)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folioBoleta FROM devolucion WHERE folioBoleta=@folio and documento=@documento AND cajaBoleta=@caja";
      command.Parameters.AddWithValue("@folio", (object) folioBoleta);
      command.Parameters.AddWithValue("@caja", (object) caja);
      command.Parameters.AddWithValue("@documento", (object) documento);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      bool flag = false;
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public DataTable devolucionInforme(string filtro)
    {
      string str = "SELECT * FROM \r\n                                         devolucion INNER JOIN detalledevolucion \r\n                            ON devolucion.idDevolucion = detalledevolucion.idDevolucion \r\n                            WHERE " + filtro + " ORDER BY devolucion.idDevolucion";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
