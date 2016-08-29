 
// Type: Aptusoft.Traspaso
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Traspaso
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaTraspaso(TraspasoVO tVO, List<DetalleTraspaso> lista)
    {
      this.agregaTraspaso(tVO);
      int num = this.retornaIdTraspaso(tVO.Folio);
      foreach (DetalleTraspaso dTra in lista)
      {
        dTra.IdTraspaso = num;
        this.agregaDetalleTraspaso(dTra);
      }
    }

    public void agregaTraspaso(TraspasoVO tVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO traspasos(folio, fechaEmision, bodegaOrigen, bodegaDestino, autoriza, neto, iva, total, observaciones, caja) \r\n                                    VALUES (@folio, @fechaEmision, @bodegaOrigen, @bodegaDestino, @autoriza, @neto, @iva, @total, @observaciones, @caja)";
      command.Parameters.AddWithValue("@folio", (object) tVO.Folio);
      command.Parameters.AddWithValue("@fechaEmision", (object) tVO.FechaEmision);
      command.Parameters.AddWithValue("@bodegaOrigen", (object) tVO.BodegaOrigen);
      command.Parameters.AddWithValue("@bodegaDestino", (object) tVO.BodegaDestino);
      command.Parameters.AddWithValue("@autoriza", (object) tVO.Autoriza);
      command.Parameters.AddWithValue("@neto", (object) tVO.Neto);
      command.Parameters.AddWithValue("@iva", (object) tVO.Iva);
      command.Parameters.AddWithValue("@total", (object) tVO.Total);
      command.Parameters.AddWithValue("@observaciones", (object) tVO.Observaciones);
      command.Parameters.AddWithValue("@caja", (object) tVO.Caja);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void agregaDetalleTraspaso(DetalleTraspaso dTra)
    {
      Decimal num1 = this.consultaStock(dTra.Codigo, dTra.BodegaOrigen);
      dTra.StockQueda = num1 - dTra.Cantidad;
      Decimal num2 = this.consultaStock(dTra.Codigo, dTra.BodegaDestino);
      dTra.StockQuedaDestino = num2 + dTra.Cantidad;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detalletraspaso(folioLinea, idTraspaso, codigo, descripcion, precio, totalLinea, cantidad, fechaIngreso, bodegaOrigenLinea, bodegaDestinoLinea, usuario, stockQueda, stockQuedaDestino) \r\n                                    VALUES (@folioLinea, @idTraspaso, @codigo, @descripcion, @precio, @totalLinea, @cantidad, @fechaIngreso, @bodegaOrigenLinea, @bodegaDestinoLinea, @usuario, @stockQueda, @stockQuedaDestino)";
      command.Parameters.AddWithValue("@folioLinea", (object) dTra.FolioLinea);
      command.Parameters.AddWithValue("@idTraspaso", (object) dTra.IdTraspaso);
      command.Parameters.AddWithValue("@codigo", (object) dTra.Codigo);
      command.Parameters.AddWithValue("@descripcion", (object) dTra.Descripcion);
      command.Parameters.AddWithValue("@precio", (object) dTra.Precio);
      command.Parameters.AddWithValue("@totalLinea", (object) dTra.TotalLinea);
      command.Parameters.AddWithValue("@cantidad", (object) dTra.Cantidad);
      command.Parameters.AddWithValue("@fechaIngreso", (object) dTra.FechaIngreso);
      command.Parameters.AddWithValue("@bodegaOrigenLinea", (object) dTra.BodegaOrigen);
      command.Parameters.AddWithValue("@bodegaDestinoLinea", (object) dTra.BodegaDestino);
      command.Parameters.AddWithValue("@usuario", (object) dTra.Usuario);
      command.Parameters.AddWithValue("@stockQueda", (object) dTra.StockQueda);
      command.Parameters.AddWithValue("@stockQuedaDestino", (object) dTra.StockQuedaDestino);
      ((DbCommand) command).ExecuteNonQuery();
      this.actualizaStock(dTra.Codigo, dTra.BodegaOrigen, "-", dTra.Cantidad);
      this.actualizaStock(dTra.Codigo, dTra.BodegaDestino, "+", dTra.Cantidad);
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

    public int retornaIdTraspaso(int folio)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idTraspaso, folio FROM traspasos WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int folioTraspaso(int caja)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(folio)+1 FROM traspasos WHERE caja=@caja";
      command.Parameters.AddWithValue("@caja", (object) caja);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public bool traspasoExiste(int folio)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT folio FROM traspasos WHERE folio=@folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void actualizaStock(string cod, int bod, string signo, Decimal cant)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      string str1 = cod;
      int num1 = bod;
      Decimal num2 = cant;
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
      }
      ((DbCommand) command).CommandText = "UPDATE productos SET " + str2 + " = " + str2 + " " + signo + " @stock WHERE Codigo=@codigo";
      command.Parameters.AddWithValue("@stock", (object) num2);
      command.Parameters.AddWithValue("@codigo", (object) str1);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public TraspasoVO buscaTraspasoFolio(int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idTraspaso,\r\n                                            folio,\r\n                                            fechaEmision,\r\n                                            bodegaOrigen,\r\n                                            bodegaDestino,\r\n                                            autoriza,\r\n                                            neto,\r\n                                            iva,\r\n                                            total,\r\n                                            observaciones,\r\n                                            caja\r\n                                    FROM traspasos\r\n                                    WHERE folio = @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      TraspasoVO traspasoVo = new TraspasoVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        traspasoVo.IdTraspaso = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTraspaso"].ToString());
        traspasoVo.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"].ToString());
        traspasoVo.FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"].ToString());
        traspasoVo.BodegaOrigen = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodegaOrigen"].ToString());
        traspasoVo.BodegaDestino = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodegaDestino"].ToString());
        traspasoVo.Autoriza = ((DbDataReader) mySqlDataReader)["autoriza"].ToString();
        traspasoVo.Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"].ToString());
        traspasoVo.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"].ToString());
        traspasoVo.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString());
        traspasoVo.Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString();
        traspasoVo.Caja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["caja"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      return traspasoVo;
    }

    public List<DetalleTraspaso> buscaDetalleTraspaso(int idTraspaso)
    {
      List<DetalleTraspaso> list = new List<DetalleTraspaso>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idTraspasoDetalle,\r\n                                            folioLinea,\r\n                                            idTraspaso,\r\n                                            codigo,\r\n                                            descripcion,\r\n                                            precio,\r\n                                            totalLinea,\r\n                                            cantidad,\r\n                                            fechaIngreso,\r\n                                            bodegaOrigenLinea,\r\n                                            bodegaDestinoLinea\r\n                                    FROM detalletraspaso\r\n                                    WHERE idTraspaso = @idTraspaso";
      command.Parameters.AddWithValue("@idTraspaso", (object) idTraspaso);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DetalleTraspaso()
        {
          IdTraspasoDetalle = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTraspasoDetalle"].ToString()),
          FolioLinea = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioLinea"].ToString()),
          IdTraspaso = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTraspaso"].ToString()),
          Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          Precio = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["precio"].ToString()),
          TotalLinea = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalLinea"].ToString()),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString()),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          BodegaOrigen = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodegaOrigenLinea"].ToString()),
          BodegaDestino = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodegaDestinoLinea"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void modificaTraspaso(TraspasoVO tVO, List<DetalleTraspaso> lista)
    {
      this.actualizaTraspaso(tVO);
      foreach (DetalleTraspaso detalleTraspaso in this.buscaDetalleTraspaso(tVO.IdTraspaso))
      {
        this.actualizaStock(detalleTraspaso.Codigo, detalleTraspaso.BodegaOrigen, "+", detalleTraspaso.Cantidad);
        this.actualizaStock(detalleTraspaso.Codigo, detalleTraspaso.BodegaDestino, "-", detalleTraspaso.Cantidad);
      }
      this.eliminaDetalleTraspaso(tVO.IdTraspaso);
      foreach (DetalleTraspaso dTra in lista)
      {
        dTra.FechaIngreso = dTra.FechaIngreso.AddSeconds(40.0);
        this.agregaDetalleTraspaso(dTra);
      }
    }

    public void actualizaTraspaso(TraspasoVO tVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE traspasos SET \r\n                                            fechaEmision=@fechaEmision,\r\n                                            bodegaOrigen=@bodegaOrigen,\r\n                                            bodegaDestino=@bodegaDestino,\r\n                                            autoriza=@autoriza,\r\n                                            neto=@neto,\r\n                                            iva=@iva,\r\n                                            total=@total,\r\n                                            observaciones=@observaciones,\r\n                                            caja=@caja\r\n                                   WHERE idTraspaso=@idTraspaso";
      command.Parameters.AddWithValue("@idTraspaso", (object) tVO.IdTraspaso);
      command.Parameters.AddWithValue("@fechaEmision", (object) tVO.FechaEmision);
      command.Parameters.AddWithValue("@bodegaOrigen", (object) tVO.BodegaOrigen);
      command.Parameters.AddWithValue("@bodegaDestino", (object) tVO.BodegaDestino);
      command.Parameters.AddWithValue("@autoriza", (object) tVO.Autoriza);
      command.Parameters.AddWithValue("@neto", (object) tVO.Neto);
      command.Parameters.AddWithValue("@iva", (object) tVO.Iva);
      command.Parameters.AddWithValue("@total", (object) tVO.Total);
      command.Parameters.AddWithValue("@observaciones", (object) tVO.Observaciones);
      command.Parameters.AddWithValue("@caja", (object) tVO.Caja);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaDetalleTraspaso(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detalletraspaso WHERE idTraspaso=@idTraspaso";
      command.Parameters.AddWithValue("@idTraspaso", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaTraspaso2(int idTraspaso)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM traspasos WHERE idTraspaso=@idTraspaso";
      command.Parameters.AddWithValue("@idTraspaso", (object) idTraspaso);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaTraspaso(int idTraspaso)
    {
      foreach (DetalleTraspaso dt in this.buscaDetalleTraspaso(idTraspaso))
      {
        this.registroEliminaTraspasoOrigen(dt);
        this.actualizaStock(dt.Codigo, dt.BodegaOrigen, "+", dt.Cantidad);
        this.registroEliminaTraspasoDestino(dt);
        this.actualizaStock(dt.Codigo, dt.BodegaDestino, "-", dt.Cantidad);
      }
      this.eliminaTraspaso2(idTraspaso);
      this.eliminaDetalleTraspaso(idTraspaso);
    }

    private void registroEliminaTraspasoDestino(DetalleTraspaso dt)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = dt.Codigo;
      cp.DescripcionProducto = dt.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ELIMINA TRASPASO DESTINO FOLIO: " + (object) dt.FolioLinea;
      cp.Bodega = dt.BodegaDestino;
      Decimal num = this.consultaStock(dt.Codigo, dt.BodegaDestino);
      cp.CantidadAnterior = num;
      cp.CantidadActual = num - dt.Cantidad;
      controlProducto.agregaControlProducto(cp);
    }

    private void registroEliminaTraspasoOrigen(DetalleTraspaso dt)
    {
      ControlProducto controlProducto = new ControlProducto();
      ControlProductoVO cp = new ControlProductoVO();
      cp.CodigoProducto = dt.Codigo;
      cp.DescripcionProducto = dt.Descripcion;
      cp.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      cp.Movimiento = "ELIMINA TRASPASO ORIGEN FOLIO: " + (object) dt.FolioLinea;
      cp.Bodega = dt.BodegaOrigen;
      Decimal num = this.consultaStock(dt.Codigo, dt.BodegaOrigen);
      cp.CantidadAnterior = num;
      cp.CantidadActual = num + dt.Cantidad;
      controlProducto.agregaControlProducto(cp);
    }

    public DataTable muestraTraspasoFolio(int folio)
    {
      string str = "SELECT \r\n                                        traspasos.idTraspaso,\r\n                                        traspasos.folio,\r\n                                        traspasos.fechaEmision,\r\n                                        traspasos.bodegaOrigen,\r\n                                        traspasos.bodegaDestino,\r\n                                        traspasos.autoriza,\r\n                                        traspasos.neto,\r\n                                        traspasos.iva,\r\n                                        traspasos.total,\r\n                                        traspasos.observaciones, \r\n                                        traspasos.caja, \r\n                                        detalletraspaso.idTraspasoDetalle,\r\n                                        detalletraspaso.folioLinea,\r\n                                        detalletraspaso.idTraspaso AS idTraspasoLinea,\r\n                                        detalletraspaso.codigo,\r\n                                        detalletraspaso.descripcion,\r\n                                        detalletraspaso.precio,\r\n                                        detalletraspaso.totalLinea,\r\n                                        detalletraspaso.cantidad,\r\n                                        detalletraspaso.fechaIngreso,\r\n                                        detalletraspaso.bodegaOrigenLinea,\r\n                                        detalletraspaso.bodegaDestinoLinea\r\n                                FROM traspasos \r\n                                INNER JOIN detalletraspaso ON traspasos.idTraspaso = detalletraspaso.idTraspaso\r\n                                WHERE traspasos.folio = @folio ORDER BY detalletraspaso.idTraspasoDetalle";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable traspasoInforme(string filtro)
    {
      string str = "SELECT \r\n                                        traspasos.idTraspaso,\r\n                                        traspasos.folio,\r\n                                        traspasos.fechaEmision,\r\n                                        traspasos.bodegaOrigen,\r\n                                        traspasos.bodegaDestino,\r\n                                        traspasos.autoriza,\r\n                                        traspasos.neto,\r\n                                        traspasos.iva,\r\n                                        traspasos.total,\r\n                                        traspasos.observaciones, \r\n                                        traspasos.caja                                        \r\n                                FROM traspasos\r\n                                WHERE " + filtro;
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public DataTable traspasoInformeDetalle(string filtro)
    {
      string str = "SELECT \r\n                                        traspasos.idTraspaso,\r\n                                        traspasos.folio,\r\n                                        traspasos.fechaEmision,\r\n                                        traspasos.bodegaOrigen,\r\n                                        traspasos.bodegaDestino,\r\n                                        traspasos.autoriza,\r\n                                        traspasos.neto,\r\n                                        traspasos.iva,\r\n                                        traspasos.total,\r\n                                        traspasos.observaciones, \r\n                                        traspasos.caja, \r\n                                        detalletraspaso.idTraspasoDetalle,\r\n                                        detalletraspaso.folioLinea,\r\n                                        detalletraspaso.idTraspaso AS idTraspasoLinea,\r\n                                        detalletraspaso.codigo,\r\n                                        detalletraspaso.descripcion,\r\n                                        detalletraspaso.precio,\r\n                                        detalletraspaso.totalLinea,\r\n                                        detalletraspaso.cantidad,\r\n                                        detalletraspaso.fechaIngreso,\r\n                                        detalletraspaso.bodegaOrigenLinea,\r\n                                        detalletraspaso.bodegaDestinoLinea\r\n                                FROM traspasos \r\n                                INNER JOIN detalletraspaso ON traspasos.idTraspaso = detalletraspaso.idTraspaso\r\n                                WHERE " + filtro;
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
