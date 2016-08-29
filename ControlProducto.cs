 
// Type: Aptusoft.ControlProducto
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Data.Common;

namespace Aptusoft
{
  internal class ControlProducto
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaControlProducto(ControlProductoVO cp)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO controlproductos \r\n                                    (codigoProducto, descripcionProducto, cantidadActual, cantidadAnterior, fechaIngreso, usuario, bodega, movimiento)\r\n                                    VALUES\r\n                                    (@codigoProducto, @descripcionProducto, @cantidadActual, @cantidadAnterior, @fechaIngreso, @usuario, @bodega, @movimiento)";
      command.Parameters.AddWithValue("@codigoProducto", (object) cp.CodigoProducto);
      command.Parameters.AddWithValue("@descripcionProducto", (object) cp.DescripcionProducto);
      command.Parameters.AddWithValue("@cantidadActual", (object) cp.CantidadActual);
      command.Parameters.AddWithValue("@cantidadAnterior", (object) cp.CantidadAnterior);
      command.Parameters.AddWithValue("@fechaIngreso", (object) DateTime.Now);
      command.Parameters.AddWithValue("@usuario", (object) cp.Usuario);
      command.Parameters.AddWithValue("@bodega", (object) cp.Bodega);
      command.Parameters.AddWithValue("@movimiento", (object) cp.Movimiento);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void agregaControlProductoModificacion(ControlProductoVO cp)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO controlproductos \r\n                                    (codigoProducto, descripcionProducto, cantidadActual, cantidadAnterior, fechaIngreso, usuario, bodega, movimiento)\r\n                                    VALUES\r\n                                    (@codigoProducto, @descripcionProducto, @cantidadActual, @cantidadAnterior, @fechaIngreso, @usuario, @bodega, @movimiento)";
      command.Parameters.AddWithValue("@codigoProducto", (object) cp.CodigoProducto);
      command.Parameters.AddWithValue("@descripcionProducto", (object) cp.DescripcionProducto);
      command.Parameters.AddWithValue("@cantidadActual", (object) cp.CantidadActual);
      command.Parameters.AddWithValue("@cantidadAnterior", (object) cp.CantidadAnterior);
      command.Parameters.AddWithValue("@fechaIngreso", (object) cp.FechaIngreso);
      command.Parameters.AddWithValue("@usuario", (object) cp.Usuario);
      command.Parameters.AddWithValue("@bodega", (object) cp.Bodega);
      command.Parameters.AddWithValue("@movimiento", (object) cp.Movimiento);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void registroDocumentoModifica(DatosVentaVO vevo, string documento)
    {
      this.agregaControlProductoModificacion(new ControlProductoVO()
      {
        CodigoProducto = vevo.Codigo,
        DescripcionProducto = vevo.Descripcion,
        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        Movimiento = string.Concat(new object[4]
        {
          (object) documento,
          (object) " FOLIO: ",
          (object) vevo.FolioFactura,
          (object) "- [MODIFICADA]"
        }),
        Bodega = vevo.Bodega,
        CantidadAnterior = vevo.Cantidad + vevo.StockQueda,
        CantidadActual = vevo.StockQueda,
        FechaIngreso = vevo.FechaIngreso
      });
    }

    public void registroDocumentoModificaRetornaInventario(DatosVentaVO vevo, string documento)
    {
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = string.Concat(new object[4]
      {
        (object) documento,
        (object) " FOLIO: ",
        (object) vevo.FolioFactura,
        (object) "- [MODIFICADA] RETORNA INVENTARIO"
      });
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadActual = vevo.Cantidad + num;
      cp.CantidadAnterior = num;
      cp.FechaIngreso = DateTime.Now;
      this.agregaControlProductoModificacion(cp);
    }

    public void registroDocumentoNulo(DatosVentaVO vevo, string documento)
    {
      ControlProducto controlProducto = new ControlProducto();
      this.agregaControlProductoModificacion(new ControlProductoVO()
      {
        FechaIngreso = vevo.FechaIngreso,
        CodigoProducto = vevo.Codigo,
        DescripcionProducto = vevo.Descripcion,
        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        Movimiento = string.Concat(new object[4]
        {
          (object) documento,
          (object) " FOLIO: ",
          (object) vevo.FolioFactura,
          (object) "- [ANULADO]"
        }),
        Bodega = vevo.Bodega,
        CantidadAnterior = vevo.Cantidad + vevo.StockQueda,
        CantidadActual = vevo.StockQueda
      });
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = string.Concat(new object[4]
      {
        (object) documento,
        (object) " FOLIO: ",
        (object) vevo.FolioFactura,
        (object) "- [ANULADO] RETORNA INVENTARIO"
      });
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = vevo.Cantidad + num;
      this.agregaControlProducto(cp);
    }

    public void registroDocumentoModificaNotaCredito(DatosVentaVO vevo, string documento)
    {
      this.agregaControlProductoModificacion(new ControlProductoVO()
      {
        CodigoProducto = vevo.Codigo,
        DescripcionProducto = vevo.Descripcion,
        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        Movimiento = string.Concat(new object[4]
        {
          (object) documento,
          (object) " FOLIO: ",
          (object) vevo.FolioFactura,
          (object) "- [MODIFICADA]"
        }),
        Bodega = vevo.Bodega,
        CantidadAnterior = vevo.StockQueda - vevo.Cantidad,
        CantidadActual = vevo.StockQueda,
        FechaIngreso = vevo.FechaIngreso
      });
    }

    public void registroDocumentoModificaRetornaInventarioNC(DatosVentaVO vevo, string documento)
    {
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = string.Concat(new object[4]
      {
        (object) documento,
        (object) " FOLIO: ",
        (object) vevo.FolioFactura,
        (object) "- [MODIFICADA] DISMINUYE INVENTARIO"
      });
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadActual = num - vevo.Cantidad;
      cp.CantidadAnterior = cp.CantidadActual + vevo.Cantidad;
      cp.FechaIngreso = DateTime.Now;
      this.agregaControlProductoModificacion(cp);
    }

    public void registroDocumentoNuloNotaCredito(DatosVentaVO vevo, string documento)
    {
      ControlProducto controlProducto = new ControlProducto();
      this.agregaControlProductoModificacion(new ControlProductoVO()
      {
        CodigoProducto = vevo.Codigo,
        DescripcionProducto = vevo.Descripcion,
        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        Movimiento = string.Concat(new object[4]
        {
          (object) documento,
          (object) " FOLIO: ",
          (object) vevo.FolioFactura,
          (object) "- [ANULADO]"
        }),
        Bodega = vevo.Bodega,
        CantidadAnterior = vevo.StockQueda - vevo.Cantidad,
        CantidadActual = vevo.StockQueda,
        FechaIngreso = vevo.FechaIngreso
      });
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = string.Concat(new object[4]
      {
        (object) documento,
        (object) " FOLIO: ",
        (object) vevo.FolioFactura,
        (object) "- [ANULADO] DISMINUYE INVENTARIO"
      });
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadActual = num - vevo.Cantidad;
      cp.CantidadAnterior = cp.CantidadActual + vevo.Cantidad;
      this.agregaControlProducto(cp);
    }

    public void registroDocumentoModificaGuiaTraslado(DatosVentaVO vevo, string documento)
    {
      this.agregaControlProductoModificacion(new ControlProductoVO()
      {
        CodigoProducto = vevo.Codigo,
        DescripcionProducto = vevo.Descripcion,
        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        Movimiento = string.Concat(new object[4]
        {
          (object) documento,
          (object) " TRASLADO FOLIO: ",
          (object) vevo.FolioFactura,
          (object) "- [MODIFICADA]"
        }),
        Bodega = vevo.Bodega,
        CantidadActual = vevo.StockQueda,
        CantidadAnterior = vevo.Cantidad + vevo.StockQueda,
        FechaIngreso = vevo.FechaIngreso
      });
    }

    public void registroDocumentoModificaDisminuyeInventario(DatosVentaVO vevo, string documento)
    {
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = vevo.Codigo;
      cp.DescripcionProducto = vevo.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = string.Concat(new object[4]
      {
        (object) documento,
        (object) " FOLIO: ",
        (object) vevo.FolioFactura,
        (object) "- [MODIFICADA] DISMINUYE INVENTARIO"
      });
      cp.Bodega = vevo.Bodega;
      Decimal num = this.consultaStock(vevo);
      cp.CantidadAnterior = num;
      cp.CantidadActual = vevo.Cantidad + num;
      cp.FechaIngreso = DateTime.Now;
      this.agregaControlProductoModificacion(cp);
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
  }
}
