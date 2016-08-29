 
// Type: Aptusoft.TomaInventario.Clases.TomaInventarioClass
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft.TomaInventario.Clases
{
  public class TomaInventarioClass
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaTomaInventario(TomaInventarioVO ti, List<ProductoVO> lista)
    {
      MySqlCommand command1 = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command1).CommandText = "INSERT INTO toma_inventario (\r\n                                                                fecha, autoriza, bodega, caja, usuario, estado\r\n                                                                ) \r\n                                                           VALUES(\r\n                                                                  @fecha, @autoriza, @bodega, @caja, @usuario, @estado\r\n                                                                 )";
      command1.Parameters.AddWithValue("@fecha",  ti.Fecha);
      command1.Parameters.AddWithValue("@autoriza",  ti.Autoriza);
      command1.Parameters.AddWithValue("@bodega",  ti.BodegaInventario);
      command1.Parameters.AddWithValue("@caja",  ti.Caja);
      command1.Parameters.AddWithValue("@usuario",  ti.Usuario);
      command1.Parameters.AddWithValue("@estado",  ti.Estado);
      ((DbCommand) command1).ExecuteNonQuery();
      MySqlCommand command2 = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command2).CommandText = "SELECT DISTINCT LAST_INSERT_ID() FROM toma_inventario";
      MySqlDataReader mySqlDataReader = command2.ExecuteReader();
      int num = 0;
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      foreach (ProductoVO pro in lista)
      {
        if (pro.Codigo != null)
        {
          pro.IdTomaInventarioLinea = num;
          pro.BodegaTomaInventario = ti.BodegaInventario;
          this.agregaDetalleTomaInventario(pro);
          DatosVentaVO veVO = new DatosVentaVO();
          veVO.Codigo = pro.Codigo;
          veVO.Bodega = pro.BodegaTomaInventario;
          veVO.Cantidad = pro.StockFisico;
          if (ti.Estado.Equals("FINALIZADA"))
          {
            this.actualizaStock(veVO);
            this.controlProducto(pro, "");
          }
        }
      }
    }

    private void agregaDetalleTomaInventario(ProductoVO pro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detalletoma_inventario (\r\n                                                                    idTomaInventario, codigo, descripcion, stockSistema, stockFisico, diferencia, costo, bodega\r\n                                                                ) \r\n                                                           VALUES(\r\n                                                                    @idTomaInventario, @codigo, @descripcion, @stockSistema, @stockFisico, @diferencia, @costo, @bodega\r\n                                                                 )";
      command.Parameters.AddWithValue("@idTomaInventario",  pro.IdTomaInventarioLinea);
      command.Parameters.AddWithValue("@codigo",  pro.Codigo);
      command.Parameters.AddWithValue("@descripcion",  pro.Descripcion);
      command.Parameters.AddWithValue("@stockSistema",  pro.StockSistema);
      command.Parameters.AddWithValue("@stockFisico",  pro.StockFisico);
      command.Parameters.AddWithValue("@diferencia",  pro.Diferencia);
      command.Parameters.AddWithValue("@costo",  pro.ValorCompra);
      command.Parameters.AddWithValue("@bodega",  pro.BodegaTomaInventario);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaStock(DatosVentaVO veVO)
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
      }
      ((DbCommand) command).CommandText = "UPDATE productos SET " + str + "= @stock WHERE Codigo=@codigo";
      command.Parameters.AddWithValue("@stock",  cantidad);
      command.Parameters.AddWithValue("@codigo",  codigo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    private void controlProducto(ProductoVO pro, string textoMovimiento)
    {
      new ControlProducto().agregaControlProducto(new ControlProductoVO()
      {
        CodigoProducto = pro.Codigo,
        DescripcionProducto = pro.Descripcion,
        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        Movimiento = textoMovimiento +  " TOMA DE INVENTARIO N°: " +   pro.IdTomaInventarioLinea.ToString(),
        Bodega = pro.BodegaTomaInventario,
        CantidadAnterior = pro.StockSistema,
        CantidadActual = pro.StockFisico
      });
    }

    public int numeroTomaInventario()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(idTomaInventario)+1 FROM toma_inventario";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public TomaInventarioVO buscaTomaInventarioID(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idTomaInventario, fecha, autoriza, bodega, caja, usuario, estado\r\n                                        FROM toma_inventario WHERE idTomaInventario=@id";
      command.Parameters.AddWithValue("@id",  id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      TomaInventarioVO tomaInventarioVo = new TomaInventarioVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        tomaInventarioVo.IdTomaInventario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTomaInventario"].ToString());
        tomaInventarioVo.Fecha = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fecha"].ToString());
        tomaInventarioVo.Autoriza = ((DbDataReader) mySqlDataReader)["autoriza"].ToString();
        tomaInventarioVo.BodegaInventario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString());
        tomaInventarioVo.Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return tomaInventarioVo;
    }

    public List<ProductoVO> buscaDetalleTomaInventarioID(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idDetalleToma, idTomaInventario, codigo, descripcion, stockSistema, stockFisico, diferencia, costo, bodega\r\n                                        FROM detalletoma_inventario WHERE idTomaInventario=@id ORDER BY idDetalleToma";
      command.Parameters.AddWithValue("@id",  id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      ProductoVO productoVo = new ProductoVO();
      List<ProductoVO> list = new List<ProductoVO>();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ProductoVO()
        {
          IdDetalleTomaInventario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleToma"].ToString()),
          IdTomaInventarioLinea = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTomaInventario"].ToString()),
          Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          StockSistema = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockSistema"].ToString()),
          StockFisico = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["stockFisico"].ToString()),
          Diferencia = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["diferencia"].ToString()),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["costo"].ToString()),
          BodegaTomaInventario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void modificaTomaInventario(TomaInventarioVO ti, List<ProductoVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE toma_inventario SET fecha=@fecha, autoriza=@autoriza, bodega=@bodega, caja=@caja, usuario=@usuario, estado=@estado\r\n                                    WHERE idTomaInventario=@id";
      command.Parameters.AddWithValue("@id",  ti.IdTomaInventario);
      command.Parameters.AddWithValue("@fecha",  ti.Fecha);
      command.Parameters.AddWithValue("@autoriza",  ti.Autoriza);
      command.Parameters.AddWithValue("@bodega",  ti.BodegaInventario);
      command.Parameters.AddWithValue("@caja",  ti.Caja);
      command.Parameters.AddWithValue("@usuario",  ti.Usuario);
      command.Parameters.AddWithValue("@estado",  ti.Estado);
      ((DbCommand) command).ExecuteNonQuery();
      foreach (ProductoVO productoVo in this.buscaDetalleTomaInventarioID(ti.IdTomaInventario))
      {
        if (productoVo.Codigo != null)
          this.actualizaStockModifica(new DatosVentaVO()
          {
            Codigo = productoVo.Codigo,
            Bodega = productoVo.BodegaTomaInventario,
            Cantidad = productoVo.StockFisico
          }, "-");
      }
      this.eliminaDetalleTomaInventario(ti.IdTomaInventario);
      foreach (ProductoVO pro in lista)
      {
        if (pro.Codigo != null)
        {
          pro.IdTomaInventarioLinea = ti.IdTomaInventario;
          pro.BodegaTomaInventario = ti.BodegaInventario;
          this.agregaDetalleTomaInventario(pro);
          this.actualizaStock(new DatosVentaVO()
          {
            Codigo = pro.Codigo,
            Bodega = pro.BodegaTomaInventario,
            Cantidad = pro.StockFisico
          });
          this.controlProducto(pro, "MODIFICA");
        }
      }
    }

    private Decimal buscaStockProducto(string codigo, int bodega)
    {
      Decimal num = new Decimal(0);
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  Bodega" +  bodega + " FROM productos WHERE Codigo=@cod";
      command.Parameters.AddWithValue("@cod",  codigo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      TomaInventarioVO tomaInventarioVo = new TomaInventarioVO();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega" +  bodega].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public void eliminaTomaInventario(int id)
    {
      foreach (ProductoVO productoVo in this.buscaDetalleTomaInventarioID(id))
        this.actualizaStockModifica(new DatosVentaVO()
        {
          Codigo = productoVo.Codigo,
          Bodega = productoVo.BodegaTomaInventario,
          Cantidad = productoVo.StockFisico
        }, "-");
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM toma_inventario WHERE idTomaInventario=@id";
      command.Parameters.AddWithValue("@id",  id);
      ((DbCommand) command).ExecuteNonQuery();
      this.eliminaDetalleTomaInventario(id);
    }

    private void eliminaDetalleTomaInventario(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detalletoma_inventario WHERE idTomaInventario=@id";
      command.Parameters.AddWithValue("@id",  id);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaStockModifica(DatosVentaVO veVO, string signo)
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
      }
      ((DbCommand) command).CommandText = "UPDATE productos SET " + str + " = " + str + " " + signo + " @stock WHERE Codigo=@codigo";
      command.Parameters.AddWithValue("@stock",  cantidad);
      command.Parameters.AddWithValue("@codigo",  codigo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public DataTable muestraTomaInventarioFolio(int folio)
    {
      string str = "SELECT \r\n                                        toma_inventario.idTomaInventario as folio,\r\n                                        toma_inventario.fecha as fechaEmision,\r\n                                        toma_inventario.autoriza as razonSocial,\r\n                                        toma_inventario.bodega,\r\n                                        toma_inventario.caja,\r\n                                        toma_inventario.usuario,\r\n                                        detalletoma_inventario.idDetalleToma as idDetalleBoleta,\r\n                                        detalletoma_inventario.codigo,\r\n                                        detalletoma_inventario.descripcion,\r\n                                        detalletoma_inventario.stockSistema as cantidad,\r\n                                        detalletoma_inventario.stockFisico as totalLinea,\r\n                                        detalletoma_inventario.diferencia as valorVenta,\r\n                                        detalletoma_inventario.costo as netoLinea,\r\n                                        detalletoma_inventario.bodega\r\n                            FROM toma_inventario INNER JOIN detalletoma_inventario \r\n                            ON toma_inventario.idTomaInventario = detalletoma_inventario.idTomaInventario \r\n                            WHERE toma_inventario.idTomaInventario =@folio ORDER BY detalletoma_inventario.idTomaInventario";
      DataTable dataTable = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        command.Parameters.AddWithValue("@folio",  folio);
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      catch (Exception ex)
      {
      }
      return dataTable;
    }

    public DataTable informeTomaInventario(string filtro)
    {
      string str = "SELECT \r\n                                        toma_inventario.idTomaInventario as folio,\r\n                                        toma_inventario.fecha as fechaEmision,\r\n                                        toma_inventario.autoriza as razonSocial,\r\n                                        toma_inventario.bodega,\r\n                                        toma_inventario.caja,\r\n                                        toma_inventario.usuario,\r\n                                        toma_inventario.estado,\r\n                                        detalletoma_inventario.idDetalleToma as idDetalleBoleta,\r\n                                        detalletoma_inventario.codigo,\r\n                                        detalletoma_inventario.descripcion,\r\n                                        detalletoma_inventario.stockSistema as cantidad,\r\n                                        detalletoma_inventario.stockFisico as totalLinea,\r\n                                        detalletoma_inventario.diferencia as valorVenta,\r\n                                        detalletoma_inventario.costo as netoLinea,\r\n                                        detalletoma_inventario.bodega\r\n                            FROM toma_inventario INNER JOIN detalletoma_inventario \r\n                            ON toma_inventario.idTomaInventario = detalletoma_inventario.idTomaInventario \r\n                            WHERE " + filtro + " ORDER BY detalletoma_inventario.idTomaInventario";
      DataTable dataTable = new DataTable();
      try
      {
        MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        ((DbCommand) command).CommandText = str;
        ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      }
      catch (Exception ex)
      {
        string message = ex.Message;
      }
      return dataTable;
    }
  }
}
