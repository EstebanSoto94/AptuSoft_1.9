 
// Type: Aptusoft.InventarioGeneral
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  internal class InventarioGeneral
  {
    private Conexion conexion = Conexion.getConecta();

    public DataTable movimientoProductoInforme(string filtro)
    {
      string str1 = "SELECT movimiento as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        idControl as 'folio',\r\n                                        codigoProducto as 'codigo',\r\n                                        descripcionProducto as 'descripcion',\r\n                                        cantidadActual-cantidadAnterior as 'cantidad',                                     \r\n                                        bodega,\r\n                                        usuario,\r\n                                        cantidadActual as 'stockQueda'                                                                                                                              \r\n                            FROM controlproductos \r\n                            WHERE " + filtro.Replace("codigo", "codigoProducto").Replace("fechaEmision", "fechaIngreso");
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str1;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str2 = "SELECT 'BOLETA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioBoleta as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                             \r\n                            FROM detalleboleta INNER JOIN boletas ON detalleboleta.idBoletaLinea = boletas.idBoleta\r\n                            WHERE " + filtro + " AND boletas.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str2;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str3 = "SELECT 'BOLETA FISCAL' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioBoleta as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                             \r\n                            FROM detalleboletafiscal INNER JOIN boletasfiscal ON detalleboletafiscal.idBoletaLinea = boletasfiscal.idBoleta\r\n                            WHERE " + filtro + " AND boletasfiscal.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str3;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str4 = "SELECT 'FACTURA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioFactura as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM detallefactura INNER JOIN facturas ON detallefactura.folioFactura = facturas.folio\r\n                            WHERE " + filtro + " AND facturas.estadoDocumento='EMITIDA' AND detallefactura.descuentaInventario='1'";
      ((DbCommand) command).CommandText = str4;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str5 = "SELECT 'FACTURA EXENTA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioFacturaExenta as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM detallefacturaexenta INNER JOIN facturasexentas ON detallefacturaexenta.folioFacturaExenta = facturasexentas.folio\r\n                            WHERE " + filtro + " AND facturasexentas.estadoDocumento='EMITIDA' AND detallefacturaexenta.descuentaInventario='1'";
      ((DbCommand) command).CommandText = str5;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str6 = "SELECT 'GUIA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioGuia as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                               \r\n                            FROM detalleguia INNER JOIN guias ON detalleguia.folioGuia = guias.folio\r\n                            WHERE " + filtro + " AND guias.estadoDocumento='EMITIDA' AND guias.descuentaInventario='0' AND guias.folioNotaVenta=0";
      ((DbCommand) command).CommandText = str6;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str7 = "SELECT 'GUIA TRASLADO BODEGA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioGuia as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        bodegaDestino as 'bodega',\r\n                                        usuario,\r\n                                        stockQuedaDestino as 'stockQueda'                                                                                                                               \r\n                            FROM detalleguia INNER JOIN guias ON detalleguia.folioGuia = guias.folio \r\n                            WHERE " + filtro.Replace("bodega", "bodegaDestino") + " AND guias.estadoDocumento='EMITIDA' AND guias.descuentaInventario='0' AND bodegaDestino > 0 AND guias.folioNotaVenta=0 ";
      ((DbCommand) command).CommandText = str7;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str8 = "SELECT 'FACTURA ELECTRONICA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioFactura as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                               \r\n                            FROM electronica_detalle_factura INNER JOIN electronica_factura ON electronica_detalle_factura.folioFactura = electronica_factura.folio\r\n                            WHERE " + filtro + " AND electronica_factura.estadoDocumento='EMITIDA'  AND electronica_factura.folioNotaVenta=0";
      ((DbCommand) command).CommandText = str8;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str9 = "SELECT 'GUIA ELECTRONICA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioGuia as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                               \r\n                            FROM electronica_detalle_guia INNER JOIN electronica_guia ON electronica_detalle_guia.folioGuia = electronica_guia.folio\r\n                            WHERE " + filtro + " AND electronica_guia.estadoDocumento='EMITIDA'  AND electronica_guia.folioNotaVenta=0";
      ((DbCommand) command).CommandText = str9;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str10 = "SELECT 'GUIA TRASLADO BODEGA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioGuia as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        bodegaDestino as 'bodega',\r\n                                        usuario,\r\n                                        stockQuedaDestino as 'stockQueda'                                                                                                                               \r\n                            FROM electronica_detalle_guia INNER JOIN electronica_guia ON electronica_detalle_guia.folioGuia = electronica_guia.folio\r\n                            WHERE " + filtro.Replace("bodega", "bodegaDestino") + " AND electronica_guia.estadoDocumento='EMITIDA'  AND electronica_guia.folioNotaVenta=0 AND bodegaDestino > 0  ";
      ((DbCommand) command).CommandText = str10;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str11 = "SELECT 'NOTA DE VENTA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioNotaVenta as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM detallenotaventa INNER JOIN notaventa ON detallenotaventa.folioNotaVenta = notaventa.folio\r\n                            WHERE " + filtro + " AND notaventa.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str11;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str12 = "SELECT 'COMANDA' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioComanda as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                             \r\n                            FROM detallecomanda INNER JOIN comanda ON detallecomanda.idComandaLinea = comanda.idComanda\r\n                            WHERE " + filtro + " AND comanda.estadoDocumento='EMITIDO'";
      ((DbCommand) command).CommandText = str12;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str13 = "SELECT 'NOTA DE CREDITO' as tipoDocumentoVenta,                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioNotaCredito as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                               \r\n                            FROM detallenotacredito INNER JOIN notacredito ON detallenotacredito.folioNotaCredito = notacredito.folio\r\n                            WHERE " + filtro + " AND notacredito.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str13;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str14 = "SELECT    tipoDocumentoCompra as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioCompra as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM detallecompra INNER JOIN compras ON detallecompra.idCompraLinea = compras.idCompra\r\n                            WHERE " + filtro + " AND compras.estadoDocumento='EMITIDA' AND idTipoDocumentoCompra != 4";
      ((DbCommand) command).CommandText = str14;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str15 = "SELECT  'NOTA CREDITO COMPRA' as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioCompra as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM detallecompra INNER JOIN compras ON detallecompra.idCompraLinea = compras.idCompra\r\n                            WHERE " + filtro + " AND compras.estadoDocumento='EMITIDA' AND idTipoDocumentoCompra = 4";
      ((DbCommand) command).CommandText = str15;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str16 = "SELECT  'KIT' as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngresoKit as 'fechaEmision',\r\n                                        folioKit as 'folio',\r\n                                        codigoKit as 'codigo',\r\n                                        descripcionKit as 'descripcion',\r\n                                        cantidadKit as 'cantidad',\r\n                                        bodegaDestino as 'bodega',\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM kitarmado \r\n                            WHERE " + filtro.Replace("codigo", "codigoKit").Replace("bodega", "bodegaDestino").Replace("fechaEmision", "fechaIngresoKit");
      ((DbCommand) command).CommandText = str16;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str17 = "SELECT  'KIT DETALLE' as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioKitArmado as 'folio',\r\n                                        codigoProducto as 'codigo',\r\n                                        descripcionProducto as 'descripcion',\r\n                                        cantidadUsada*-1 as 'cantidad',\r\n                                        bodegaOrigen as 'bodega',\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM detallekitarmado \r\n                            WHERE " + filtro.Replace("codigo", "codigoProducto").Replace("bodega", "bodegaOrigen").Replace("fechaEmision", "fechaIngreso");
      ((DbCommand) command).CommandText = str17;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str18 = "SELECT 'TRASPASO BODEGA - BOD. ORIGEN' as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioLinea as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',                                     \r\n                                        bodegaOrigenLinea as 'bodega',\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                               \r\n                            FROM detalletraspaso \r\n                            WHERE " + filtro.Replace("fechaEmision", "fechaIngreso").Replace("bodega", "bodegaOrigenLinea");
      ((DbCommand) command).CommandText = str18;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str19 = "SELECT 'TRASPASO BODEGA - BOD. DESTINO' as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioLinea as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad as 'cantidad',                                     \r\n                                        bodegaDestinoLinea as 'bodega',\r\n                                        usuario,\r\n                                        stockQuedaDestino as 'stockQueda'                                                                                                                              \r\n                            FROM detalletraspaso \r\n                            WHERE " + filtro.Replace("fechaEmision", "fechaIngreso").Replace("bodega", "bodegaDestinoLinea");
      ((DbCommand) command).CommandText = str19;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str20 = filtro.Replace("fechaEmision", "fechaIngreso");
      string str21 = "SELECT 'DEVOLUCION ENTRA' as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioDevolucion as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,                                     \r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM detalledevolucion \r\n                            WHERE estado='ENTRA' AND " + str20;
      ((DbCommand) command).CommandText = str21;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str22 = "SELECT 'DEVOLUCION SALE' as 'tipoDocumentoVenta',                                       \r\n                                        fechaIngreso as 'fechaEmision',\r\n                                        folioDevolucion as 'folio',\r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',                                     \r\n                                        bodega,\r\n                                        usuario,\r\n                                        stockQueda                                                                                                                              \r\n                            FROM detalledevolucion \r\n                            WHERE estado='SALE' AND " + str20;
      ((DbCommand) command).CommandText = str22;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable rankingProductoInforme(string filtro, int bod)
    {
      string str1 = bod != 0 ? "bodega" : "'0' as bodega";
      string str2 = "SELECT 'BOLETA' as tipoDocumentoVenta,                                       \r\n                                        folioBoleta as 'folio',                                        \r\n                                        fechaIngreso as 'fechaEmision',                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta, valorCompra,\r\n                                        descuentoLinea,\r\n                                        totalLinea," + str1 + " FROM detalleboleta INNER JOIN boletas ON detalleboleta.folioBoleta = boletas.folio\r\n                            WHERE " + filtro + " AND boletas.estadoDocumento='EMITIDA'";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str2;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str3 = "SELECT 'BOLETA FISCAL' as tipoDocumentoVenta,\r\n                                        folioBoleta as 'folio',                                        \r\n                                        fechaIngreso as 'fechaEmision',                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta, valorCompra,\r\n                                        descuentoLinea,\r\n                                        totalLinea," + str1 + " FROM detalleboletafiscal INNER JOIN boletasfiscal ON detalleboletafiscal.folioBoleta = boletasfiscal.folio\r\n                            WHERE " + filtro + " AND boletasfiscal.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str3;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str4 = "SELECT 'FACTURA' as tipoDocumentoVenta,\r\n                                        folioFactura as 'folio',                                          \r\n                                        fechaIngreso as 'fechaEmision',                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta, valorCompra,\r\n                                        descuentoLinea,\r\n                                        totalLinea," + str1 + " FROM detallefactura INNER JOIN facturas ON detallefactura.folioFactura = facturas.folio\r\n                            WHERE " + filtro + " AND facturas.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str4;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str5 = "SELECT 'FACTURA EXENTA' as tipoDocumentoVenta,\r\n                                        folioFacturaExenta as 'folio',                                          \r\n                                        fechaIngreso as 'fechaEmision',                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta, valorCompra,\r\n                                        descuentoLinea,\r\n                                        totalLinea," + str1 + " FROM detallefacturaexenta INNER JOIN facturasexentas ON detallefacturaexenta.folioFacturaExenta = facturasexentas.folio\r\n                            WHERE " + filtro + " AND facturasexentas.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str5;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str6 = "SELECT 'FACTURA ELECTRONICA' as tipoDocumentoVenta,\r\n                                        folioFactura as 'folio',                                          \r\n                                        fechaIngreso as 'fechaEmision',                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta, valorCompra,\r\n                                        descuentoLinea,\r\n                                        totalLinea," + str1 + " FROM electronica_detalle_factura INNER JOIN electronica_factura ON electronica_detalle_factura.folioFactura = electronica_factura.folio\r\n                            WHERE " + filtro + " AND electronica_factura.estadoDocumento='EMITIDA'";
      ((DbCommand)command).CommandText = str6;
      ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable detalleVentaInforme(string filtro)
    {
      string str1 = "SELECT 'BOLETA' as tipoDocumentoVenta,                                       \r\n                                        folioBoleta as 'folio',                                        \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea,\r\n                                        razonSocial, bodega                                                                                                                                                                     \r\n                            FROM detalleboleta INNER JOIN boletas ON detalleboleta.folioBoleta = boletas.folio\r\n                            WHERE " + filtro + " AND boletas.estadoDocumento='EMITIDA'";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str1;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str2 = "SELECT 'BOLETA FISCAL' as tipoDocumentoVenta,                                       \r\n                                        folioBoleta as 'folio',                                        \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea,\r\n                                        razonSocial, bodega                                                                                                                                                                     \r\n                            FROM detalleboletafiscal INNER JOIN boletasfiscal ON detalleboletafiscal.idBoletaLinea = boletasfiscal.idBoleta\r\n                            WHERE " + filtro + " AND boletasfiscal.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str2;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str3 = "SELECT 'FACTURA' as tipoDocumentoVenta,\r\n                                        folioFactura as 'folio',                                          \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea,\r\n                                        razonSocial, bodega                                                                                                                               \r\n                            FROM detallefactura INNER JOIN facturas ON detallefactura.folioFactura = facturas.folio\r\n                            WHERE " + filtro + " AND facturas.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str3;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str4 = "SELECT 'FACTURA EXENTA' as tipoDocumentoVenta,\r\n                                        folioFacturaExenta as 'folio',                                          \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea,\r\n                                        razonSocial, bodega                                                                                                                               \r\n                            FROM detallefacturaexenta INNER JOIN facturasexentas ON detallefacturaexenta.folioFacturaExenta = facturasexentas.folio\r\n                            WHERE " + filtro + " AND facturasexentas.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str4;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str5 = "SELECT 'NOTA VENTA' as tipoDocumentoVenta,\r\n                                        folioNotaVenta as 'folio',                                          \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea,\r\n                                        razonSocial, bodega                                                                                                                               \r\n                            FROM detallenotaventa INNER JOIN notaventa ON detallenotaventa.folioNotaVenta = notaventa.folio\r\n                            WHERE " + filtro + " AND notaventa.estadoDocumento='EMITIDA' AND idDocumentoVenta=0";
      ((DbCommand) command).CommandText = str5;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str6 = "SELECT 'GUIAS' as tipoDocumentoVenta,\r\n                                        folioGuia as 'folio',                                          \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea,\r\n                                        razonSocial, bodega                                                                                                                               \r\n                            FROM detalleguia INNER JOIN guias ON detalleguia.folioGuia = guias.folio\r\n                            WHERE " + filtro + " AND guias.estadoDocumento='EMITIDA' AND guias.folioFactura=0 AND guias.descuentaInventario='0'";
      ((DbCommand) command).CommandText = str6;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str7 = "SELECT 'NOTA CREDITO' as tipoDocumentoVenta,\r\n                                        folioNotaCredito as 'folio',                                          \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad*-1 as 'cantidad',\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea*-1 as 'totalLinea',                                         \r\n                                        razonSocial, bodega                                                                                                                              \r\n                            FROM detallenotacredito INNER JOIN notacredito ON detallenotacredito.folioNotaCredito = notacredito.folio\r\n                            WHERE " + filtro + " AND notacredito.estadoDocumento='EMITIDA'";
      ((DbCommand) command).CommandText = str7;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      string str8 = "SELECT 'FACTURA ELECTRONICA' as tipoDocumentoVenta,\r\n                                        folioFactura as 'folio',                                          \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea,\r\n                                        razonSocial, bodega                                                                                                                               \r\n                             FROM electronica_detalle_factura INNER JOIN electronica_factura ON electronica_detalle_factura.folioFactura = electronica_factura.folio\r\n                            WHERE " + filtro + " AND electronica_factura.estadoDocumento='EMITIDA'"; 
        ((DbCommand)command).CommandText = str8;
      ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable detalleCompraInforme(string filtro)
    {
      string str = "SELECT tipoDocumentoCompra as tipoDocumentoVenta,                                       \r\n                                        folioCompra as 'folio',                                        \r\n                                        fechaEmision,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        descuentoLinea,\r\n                                        totalLinea,\r\n                                        razonSocial,\r\n                                        rut,\r\n                                        digito, bodega                                                                                                                                                                     \r\n                            FROM detallecompra INNER JOIN compras ON detallecompra.folioCompra = compras.folio\r\n                            WHERE " + filtro + " AND compras.estadoDocumento='EMITIDA';";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable entradaStockBodega(string filtro)
    {
      string str = "SELECT tipoDocumentoCompra as tipoDocumentoVenta,                                       \r\n                                        detallecompra.folioCompra as 'folio',                                        \r\n                                        compras.fechaEmision,                                        \r\n                                        detallecompra.codigo,\r\n                                        detallecompra.descripcion,\r\n                                        detallecompra.cantidad,\r\n                                        detallecompra.valorVenta,\r\n                                        detallecompra.descuentoLinea,\r\n                                        detallecompra.totalLinea,\r\n                                        compras.razonSocial,\r\n                                        compras.rut,\r\n                                        compras.digito,  detallecompra.bodega, productos.Categoria, productos.IdSubCategoria, productos.SubCategoria                                                                                                                                                                     \r\n                            FROM detallecompra \r\n                            INNER JOIN compras ON detallecompra.folioCompra = compras.folio\r\n                            LEFT JOIN productos ON detallecompra.codigo = productos.Codigo\r\n                            WHERE " + filtro + " AND compras.estadoDocumento='EMITIDA'";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public List<DatosVentaVO> kardex(string filtro, bool conVentas)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string str1 = "SELECT    fechaIngreso,\r\n                                        folioCompra,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        totalLinea,\r\n                                        tipoDocumentoCompraLinea                                                                                                                                                                     \r\n                            FROM detallecompra WHERE " + filtro + " AND (idTipoDocumentoCompraLinea=1 OR idTipoDocumentoCompraLinea=3 OR idTipoDocumentoCompraLinea=5) ORDER BY fechaIngreso";
      ((DbCommand) command).CommandText = str1;
      MySqlDataReader mySqlDataReader1 = command.ExecuteReader();
      List<DatosVentaVO> list1 = new List<DatosVentaVO>();
      int num1 = 0;
      Decimal num2 = new Decimal(0);
      Decimal num3 = new Decimal(0);
      Decimal num4 = new Decimal(0);
      while (((DbDataReader) mySqlDataReader1).Read())
        list1.Add(new DatosVentaVO()
        {
          TipoDocumentoCompra = "COMPRA",
          TipoDocumento = ((DbDataReader) mySqlDataReader1)["tipoDocumentoCompraLinea"].ToString(),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader1)["folioCompra"]),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader1)["fechaIngreso"].ToString()),
          Codigo = ((DbDataReader) mySqlDataReader1)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader1)["descripcion"].ToString(),
          ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["valorVenta"]),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["cantidad"]),
          TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["totalLinea"])
        });
      ((DbDataReader) mySqlDataReader1).Close();
      string str2 = "SELECT    fechaIngreso,\r\n                                        folioCompra,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        totalLinea,\r\n                                        tipoDocumentoCompraLinea                                                                                                                                                                     \r\n                            FROM detallecompra WHERE " + filtro + " AND (idTipoDocumentoCompraLinea=4) ORDER BY fechaIngreso";
      ((DbCommand) command).CommandText = str2;
      MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader2).Read())
        list1.Add(new DatosVentaVO()
        {
          TipoDocumentoCompra = "COMPRA",
          TipoDocumento = ((DbDataReader) mySqlDataReader2)["tipoDocumentoCompraLinea"].ToString() + " COMPRA ",
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader2)["folioCompra"]),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader2)["fechaIngreso"].ToString()),
          Codigo = ((DbDataReader) mySqlDataReader2)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader2)["descripcion"].ToString(),
          ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["valorVenta"]),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["cantidad"]) * new Decimal(-1),
          TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["totalLinea"]) * new Decimal(-1),
          Exento = true
        });
      ((DbDataReader) mySqlDataReader2).Close();
      if (conVentas)
      {
        string str3 = "SELECT    fechaIngreso,\r\n                                        folioBoleta,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        totalLinea                                                                                                                                                                     \r\n                            FROM detalleboleta WHERE " + filtro + " ORDER BY fechaIngreso";
        ((DbCommand) command).CommandText = str3;
        MySqlDataReader mySqlDataReader3 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader3).Read())
          list1.Add(new DatosVentaVO()
          {
            TipoDocumentoCompra = "VENTA",
            TipoDocumento = "BOLETA",
            FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader3)["folioBoleta"]),
            FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader3)["fechaIngreso"].ToString()),
            Codigo = ((DbDataReader) mySqlDataReader3)["codigo"].ToString(),
            Descripcion = ((DbDataReader) mySqlDataReader3)["descripcion"].ToString(),
            ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader3)["valorVenta"]),
            Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader3)["cantidad"]),
            TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader3)["totalLinea"])
          });
        ((DbDataReader) mySqlDataReader3).Close();
        string str4 = "SELECT    fechaIngreso,\r\n                                        folioBoleta,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        totalLinea                                                                                                                                                                     \r\n                            FROM detalleboletafiscal WHERE " + filtro + " ORDER BY fechaIngreso";
        ((DbCommand) command).CommandText = str4;
        MySqlDataReader mySqlDataReader4 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader4).Read())
          list1.Add(new DatosVentaVO()
          {
            TipoDocumentoCompra = "VENTA",
            TipoDocumento = "BOLETA FISCAL",
            FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader4)["folioBoleta"]),
            FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader4)["fechaIngreso"].ToString()),
            Codigo = ((DbDataReader) mySqlDataReader4)["codigo"].ToString(),
            Descripcion = ((DbDataReader) mySqlDataReader4)["descripcion"].ToString(),
            ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader4)["valorVenta"]),
            Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader4)["cantidad"]),
            TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader4)["totalLinea"])
          });
        ((DbDataReader) mySqlDataReader4).Close();
        string str5 = "SELECT   fechaIngreso,\r\n                                        folioFactura,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        totalLinea                                                                                                                                                                     \r\n                            FROM detallefactura\r\n                            INNER JOIN facturas\r\n                            ON facturas.idFactura = detallefactura.idFacturaLinea WHERE " + filtro + "  AND (length(facturas.folioGuias) = 0 OR facturas.folioGuias IS NULL) ORDER BY fechaIngreso";
        ((DbCommand) command).CommandText = str5;
        MySqlDataReader mySqlDataReader5 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader5).Read())
          list1.Add(new DatosVentaVO()
          {
            TipoDocumentoCompra = "VENTA",
            TipoDocumento = "FACTURA",
            FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader5)["folioFactura"]),
            FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader5)["fechaIngreso"].ToString()),
            Codigo = ((DbDataReader) mySqlDataReader5)["codigo"].ToString(),
            Descripcion = ((DbDataReader) mySqlDataReader5)["descripcion"].ToString(),
            ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader5)["valorVenta"]),
            Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader5)["cantidad"]),
            TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader5)["totalLinea"])
          });
        ((DbDataReader) mySqlDataReader5).Close();
        string str6 = "SELECT      fechaIngreso,\r\n                                        folioGuia,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        totalLinea                                                                                                                                                                     \r\n                            FROM detalleguia WHERE " + filtro + "  ORDER BY fechaIngreso";
        ((DbCommand) command).CommandText = str6;
        MySqlDataReader mySqlDataReader6 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader6).Read())
          list1.Add(new DatosVentaVO()
          {
            TipoDocumentoCompra = "VENTA",
            TipoDocumento = "GUIA",
            FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader6)["folioGuia"]),
            FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader6)["fechaIngreso"].ToString()),
            Codigo = ((DbDataReader) mySqlDataReader6)["codigo"].ToString(),
            Descripcion = ((DbDataReader) mySqlDataReader6)["descripcion"].ToString(),
            ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader6)["valorVenta"]),
            Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader6)["cantidad"]),
            TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader6)["totalLinea"])
          });
        ((DbDataReader) mySqlDataReader6).Close();
        string str7 = "SELECT      fechaIngreso,\r\n                                        folioNotaVenta,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        totalLinea                                                                                                                                                                     \r\n                            FROM detallenotaventa WHERE " + filtro + "  ORDER BY fechaIngreso";
        ((DbCommand) command).CommandText = str7;
        MySqlDataReader mySqlDataReader7 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader7).Read())
          list1.Add(new DatosVentaVO()
          {
            TipoDocumentoCompra = "VENTA",
            TipoDocumento = "NOTA VENTA",
            FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader7)["folioNotaVenta"]),
            FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader7)["fechaIngreso"].ToString()),
            Codigo = ((DbDataReader) mySqlDataReader7)["codigo"].ToString(),
            Descripcion = ((DbDataReader) mySqlDataReader7)["descripcion"].ToString(),
            ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader7)["valorVenta"]),
            Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader7)["cantidad"]),
            TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader7)["totalLinea"])
          });
        ((DbDataReader) mySqlDataReader7).Close();
        string str8 = "SELECT     fechaIngreso,\r\n                                        folioNotaCredito,                                        \r\n                                        codigo,\r\n                                        descripcion,\r\n                                        cantidad,\r\n                                        valorVenta,\r\n                                        totalLinea                                                                                                                                                                     \r\n                            FROM detallenotacredito WHERE " + filtro + "  ORDER BY fechaIngreso";
        ((DbCommand) command).CommandText = str8;
        MySqlDataReader mySqlDataReader8 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader8).Read())
          list1.Add(new DatosVentaVO()
          {
            TipoDocumentoCompra = "VENTA",
            TipoDocumento = "NOTA CREDITO",
            FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader8)["folioNotaCredito"]),
            FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader8)["fechaIngreso"].ToString()),
            Codigo = ((DbDataReader) mySqlDataReader8)["codigo"].ToString(),
            Descripcion = ((DbDataReader) mySqlDataReader8)["descripcion"].ToString(),
            ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader8)["valorVenta"]),
            Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader8)["cantidad"]),
            TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader8)["totalLinea"]),
            Exento = true
          });
        ((DbDataReader) mySqlDataReader8).Close();
      }
      list1.Sort((Comparison<DatosVentaVO>) ((v1, v2) => v1.FechaIngreso.CompareTo(v2.FechaIngreso)));
      List<DatosVentaVO> list2 = new List<DatosVentaVO>();
      foreach (DatosVentaVO datosVentaVo in list1)
      {
        if (datosVentaVo.TipoDocumentoCompra.Equals("COMPRA"))
        {
          if (num1 == 0)
          {
            datosVentaVo.CantidadExistencia = datosVentaVo.Cantidad;
            num2 = datosVentaVo.Cantidad;
            num4 = datosVentaVo.ValorVenta;
            datosVentaVo.ValorExistencia = num4;
            datosVentaVo.TotalExistencia = datosVentaVo.TotalLinea;
            num3 = datosVentaVo.TotalLinea;
          }
          else
          {
            datosVentaVo.CantidadExistencia = num2 + datosVentaVo.Cantidad;
            num2 = datosVentaVo.CantidadExistencia;
            datosVentaVo.TotalExistencia = num3 + datosVentaVo.TotalLinea;
            num3 = datosVentaVo.TotalExistencia;
            num4 = !(num3 > new Decimal(0)) || !(num2 > new Decimal(0)) ? new Decimal(0) : num3 / num2;
            datosVentaVo.ValorExistencia = num4;
          }
        }
        else if (datosVentaVo.Exento)
        {
          datosVentaVo.ValorVenta = num4;
          datosVentaVo.Cantidad = datosVentaVo.Cantidad * new Decimal(-1);
          datosVentaVo.TotalLinea = datosVentaVo.Cantidad * datosVentaVo.ValorVenta;
          datosVentaVo.CantidadExistencia = num2 - datosVentaVo.Cantidad;
          num2 = datosVentaVo.CantidadExistencia;
          datosVentaVo.TotalExistencia = num3 - datosVentaVo.TotalLinea;
          num3 = datosVentaVo.TotalExistencia;
          num4 = !(num3 > new Decimal(0)) || !(num2 > new Decimal(0)) ? new Decimal(0) : num3 / num2;
          datosVentaVo.ValorExistencia = num4;
        }
        else
        {
          datosVentaVo.ValorVenta = num4;
          datosVentaVo.TotalLinea = datosVentaVo.Cantidad * datosVentaVo.ValorVenta;
          datosVentaVo.CantidadExistencia = num2 - datosVentaVo.Cantidad;
          num2 = datosVentaVo.CantidadExistencia;
          datosVentaVo.TotalExistencia = num3 - datosVentaVo.TotalLinea;
          num3 = datosVentaVo.TotalExistencia;
          num4 = !(num3 > new Decimal(0)) || !(num2 > new Decimal(0)) ? new Decimal(0) : num3 / num2;
          datosVentaVo.ValorExistencia = num4;
        }
        list2.Add(datosVentaVo);
        ++num1;
      }
      return list2;
    }
  }
}
