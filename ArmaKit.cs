 
// Type: Aptusoft.ArmaKit
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class ArmaKit
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaArmaKit(KitVO kv, List<KitVO> lista)
    {
      this.agregaArmaKit(kv);
      foreach (KitVO kv1 in lista)
      {
        kv1.FechaIngresoKit = kv.FechaIngresoKit;
        this.agregaDetalleArmaKit(kv1);
      }
    }

    public void modificaArmaKit(KitVO kv, List<KitVO> lista)
    {
      this.actualizaArmaKit(kv);
      foreach (KitVO kv1 in this.buscaDetalleKitFolio(kv.FolioKit))
        this.actualizaStockDetalle(kv1, "+");
      this.eliminaDetalleArmaKit(kv.FolioKit);
      foreach (KitVO kv1 in lista)
      {
        kv1.FechaIngresoKit = kv.FechaIngresoKit;
        this.agregaDetalleArmaKit(kv1);
      }
    }

    public void actualizaArmaKit(KitVO kv)
    {
      Decimal num = this.consultaStock(kv.CodigoProductoKit, Convert.ToInt32(kv.Bodega));
      kv.StockQueda = num - kv.CantidadUsada;
      this.actualizaStock(this.buscaKitFolio(kv.FolioKit), "-");
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE kitarmado SET fechaIngresoKit= @fechaIngresoKit, cantidadKit= @cantidadKit, bodegaDestino=@bodegaDestino, usuario=@usuario, stockQueda=@stockQueda WHERE folioKit=@folioKit";
      command.Parameters.AddWithValue("@folioKit", (object) kv.FolioKit);
      command.Parameters.AddWithValue("@fechaIngresoKit", (object) kv.FechaIngresoKit);
      command.Parameters.AddWithValue("@cantidadKit", (object) kv.Cantidad);
      command.Parameters.AddWithValue("@bodegaDestino", (object) kv.Bodega);
      command.Parameters.AddWithValue("@usuario", (object) kv.Usuario);
      command.Parameters.AddWithValue("@stockQueda", (object) kv.StockQueda);
      ((DbCommand) command).ExecuteNonQuery();
      this.actualizaStock(kv, "+");
    }

    public void agregaArmaKit(KitVO kv)
    {
      Decimal num = this.consultaStock(kv.CodigoProductoKit, Convert.ToInt32(kv.Bodega));
      kv.StockQueda = num + kv.Cantidad;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO kitarmado (folioKit, fechaIngresoKit, codigoKit, descripcionKit, cantidadKit, bodegaDestino, usuario, stockQueda) \r\n                                    VALUES (@folioKit, @fechaIngresoKit, @codigoKit, @descripcionKit, @cantidadKit, @bodegaDestino, @usuario, @stockQueda)";
      command.Parameters.AddWithValue("@folioKit", (object) kv.FolioKit);
      command.Parameters.AddWithValue("@fechaIngresoKit", (object) kv.FechaIngresoKit);
      command.Parameters.AddWithValue("@codigoKit", (object) kv.CodigoProductoKit);
      command.Parameters.AddWithValue("@descripcionKit", (object) kv.Descripcion);
      command.Parameters.AddWithValue("@cantidadKit", (object) kv.Cantidad);
      command.Parameters.AddWithValue("@bodegaDestino", (object) kv.Bodega);
      command.Parameters.AddWithValue("@usuario", (object) kv.Usuario);
      command.Parameters.AddWithValue("@stockQueda", (object) kv.StockQueda);
      ((DbCommand) command).ExecuteNonQuery();
      this.actualizaStock(kv, "+");
    }

    public void agregaDetalleArmaKit(KitVO kv)
    {
      Decimal num = this.consultaStock(kv.CodigoProductoDetalle, Convert.ToInt32(kv.BodegaOrigen));
      kv.StockQueda = num - kv.CantidadUsada;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detallekitarmado (folioKitArmado, codigoProducto, descripcionProducto, cantidadCU, cantidadUsada, bodegaOrigen, fechaIngreso, usuario, stockQueda) \r\n                                    VALUES (@folioKitArmado, @codigoProducto, @descripcionProducto, @cantidadCU, @cantidadUsada, @bodegaOrigen, @fechaIngreso, @usuario, @stockQueda)";
      command.Parameters.AddWithValue("@folioKitArmado", (object) kv.FolioKit);
      command.Parameters.AddWithValue("@codigoProducto", (object) kv.CodigoProductoDetalle);
      command.Parameters.AddWithValue("@descripcionProducto", (object) kv.Descripcion);
      command.Parameters.AddWithValue("@cantidadCU", (object) kv.CantidadCU);
      command.Parameters.AddWithValue("@cantidadUsada", (object) kv.CantidadUsada);
      command.Parameters.AddWithValue("@bodegaOrigen", (object) kv.BodegaOrigen);
      command.Parameters.AddWithValue("@fechaIngreso", (object) kv.FechaIngresoKit);
      command.Parameters.AddWithValue("@usuario", (object) kv.Usuario);
      command.Parameters.AddWithValue("@stockQueda", (object) kv.StockQueda);
      ((DbCommand) command).ExecuteNonQuery();
      kv.CodigoProductoKit = kv.CodigoProductoDetalle;
      kv.Bodega = kv.BodegaOrigen;
      kv.Cantidad = kv.CantidadUsada;
      this.actualizaStock(kv, "-");
    }

    public Decimal consultaStock(string cod, int bod)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string str1 = cod;
      int num1 = bod;
      string str2 = "";
      switch (num1)
      {
        case 1:
          str2 = "Bodega1";
          break;
        case 2:
          str2 = "Bodega2";
          break;
        case 3:
          str2 = "Bodega3";
          break;
        case 4:
          str2 = "Bodega4";
          break;
        case 5:
          str2 = "Bodega5";
          break;
        case 6:
          str2 = "Bodega6";
          break;
        case 7:
          str2 = "Bodega7";
          break;
        case 8:
          str2 = "Bodega8";
          break;
        case 9:
          str2 = "Bodega9";
          break;
        case 10:
          str2 = "Bodega10";
          break;
        case 11:
          str2 = "Bodega11";
          break;
        case 12:
          str2 = "Bodega12";
          break;
        case 13:
          str2 = "Bodega13";
          break;
        case 14:
          str2 = "Bodega14";
          break;
        case 15:
          str2 = "Bodega15";
          break;
        case 16:
          str2 = "Bodega16";
          break;
        case 17:
          str2 = "Bodega17";
          break;
        case 18:
          str2 = "Bodega18";
          break;
        case 19:
          str2 = "Bodega19";
          break;
        case 20:
          str2 = "Bodega20";
          break;
      }
      Decimal num2 = new Decimal(0);
      ((DbCommand) command).CommandText = "SELECT " + str2 + " FROM productos WHERE Codigo=@codigo";
      command.Parameters.AddWithValue("@codigo", (object) str1);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num2;
    }

    public int folioKit()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folioKit)+1 FROM kitarmado";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public KitVO buscaKitFolio(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idKitArmado, folioKit, fechaIngresoKit, codigoKit, descripcionKit, cantidadKit, bodegaDestino FROM kitarmado WHERE folioKit=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      KitVO kitVo = new KitVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        kitVo = new KitVO();
        kitVo.IdKit = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idKitArmado"].ToString());
        kitVo.FolioKit = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioKit"].ToString());
        kitVo.FechaIngresoKit = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngresoKit"].ToString());
        kitVo.CodigoProductoKit = ((DbDataReader) mySqlDataReader)["codigoKit"].ToString();
        kitVo.Descripcion = ((DbDataReader) mySqlDataReader)["descripcionKit"].ToString();
        kitVo.Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidadKit"].ToString());
        kitVo.Bodega = ((DbDataReader) mySqlDataReader)["bodegaDestino"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return kitVo;
    }

    public List<KitVO> buscaDetalleKitFolio(int folio)
    {
      List<KitVO> list = new List<KitVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idDetalleKitArmado, folioKitArmado, codigoProducto, descripcionProducto, cantidadCU, cantidadUsada, bodegaOrigen FROM detallekitarmado WHERE folioKitArmado=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      KitVO kitVo = new KitVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new KitVO()
        {
          IdKit = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleKitArmado"].ToString()),
          FolioKit = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioKitArmado"].ToString()),
          CodigoProductoDetalle = ((DbDataReader) mySqlDataReader)["codigoProducto"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcionProducto"].ToString(),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidadCU"].ToString()),
          CantidadUsada = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidadUsada"].ToString()),
          Bodega = ((DbDataReader) mySqlDataReader)["bodegaOrigen"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void actualizaStock(KitVO kv, string signo)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string codigoProductoKit = kv.CodigoProductoKit;
      int num = Convert.ToInt32(kv.Bodega);
      Decimal cantidad = kv.Cantidad;
      string str = "";
      switch (num)
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
      command.Parameters.AddWithValue("@codigo", (object) codigoProductoKit);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaStockDetalle(KitVO kv, string signo)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string codigoProductoDetalle = kv.CodigoProductoDetalle;
      int num = Convert.ToInt32(kv.Bodega);
      Decimal cantidadUsada = kv.CantidadUsada;
      string str = "";
      switch (num)
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
      command.Parameters.AddWithValue("@stock", (object) cantidadUsada);
      command.Parameters.AddWithValue("@codigo", (object) codigoProductoDetalle);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaDetalleArmaKit(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detallekitarmado WHERE folioKitArmado=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaKidArmado(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM kitarmado WHERE folioKit=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaKidCompleto(int folio)
    {
      KitVO kv1 = this.buscaKitFolio(folio);
      this.registroKitEliminado(kv1);
      this.actualizaStock(kv1, "-");
      this.eliminaKidArmado(folio);
      foreach (KitVO kv2 in this.buscaDetalleKitFolio(folio))
      {
        this.registroDetalleKitEliminado(kv2);
        this.actualizaStockDetalle(kv2, "+");
      }
      this.eliminaDetalleArmaKit(folio);
    }

    private void registroKitEliminado(KitVO kv)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = kv.CodigoProductoKit;
      cp.DescripcionProducto = kv.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ELIMINA KIT FOLIO: " + (object) kv.FolioKit;
      cp.Bodega = Convert.ToInt32(kv.Bodega);
      Decimal num = this.consultaStock(kv.CodigoProductoKit, Convert.ToInt32(kv.Bodega));
      cp.CantidadAnterior = num;
      cp.CantidadActual = num - kv.Cantidad;
      controlProducto.agregaControlProducto(cp);
    }

    private void registroDetalleKitEliminado(KitVO kv)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = kv.CodigoProductoDetalle;
      cp.DescripcionProducto = kv.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ELIMINA DETALLE KIT FOLIO: " + (object) kv.FolioKit;
      cp.Bodega = Convert.ToInt32(kv.Bodega);
      Decimal num = this.consultaStock(kv.CodigoProductoDetalle, Convert.ToInt32(kv.Bodega));
      cp.CantidadAnterior = num;
      cp.CantidadActual = num + kv.CantidadUsada;
      controlProducto.agregaControlProducto(cp);
    }

    public DataTable armaKitInforme(string filtro)
    {
      string str = "SELECT \r\n                                     kitarmado.idKitArmado,\r\n                                     kitarmado.folioKit,\r\n                                     kitarmado.fechaIngresoKit,\r\n                                     kitarmado.codigoKit,\r\n                                     kitarmado.descripcionKit,\r\n                                     kitarmado.cantidadKit,\r\n                                     kitarmado.bodegaDestino,\r\n                                     detallekitarmado.idDetalleKitArmado,\r\n                                     detallekitarmado.folioKitArmado,\r\n                                     detallekitarmado.codigoProducto,\r\n                                     detallekitarmado.descripcionProducto,\r\n                                     detallekitarmado.cantidadCU,\r\n                                     detallekitarmado.cantidadUsada,\r\n                                     detallekitarmado.bodegaOrigen,\r\n                                     detallekitarmado.fechaIngreso\r\n                                FROM kitarmado INNER JOIN detallekitarmado ON kitarmado.folioKit =  detallekitarmado.folioKitArmado                      \r\n                                WHERE " + filtro + " ORDER BY kitarmado.idKitArmado";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
