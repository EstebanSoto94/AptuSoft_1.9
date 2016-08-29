 
// Type: Aptusoft.Promocion.Clases.Promo
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft.Promocion.Clases
{
  public class Promo
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaPromocion(PromocionVO pro, List<DetallePromocionVO> lista)
    {
      this.guardaPromocion(pro);
      int num = this.retornaIdPromocion();
      foreach (DetallePromocionVO dePro in lista)
      {
        dePro.IdPromocion = num;
        this.guardaDetallePromocion(dePro);
      }
    }

    private void guardaPromocion(PromocionVO pro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO promocion (descripcion, cantidad, precio, fechaInicio, fechaFin) VALUES(@descripcion, @cantidad, @precio, @fechaInicio, @fechaFin)";
      command.Parameters.AddWithValue("@descripcion", (object) pro.Descripcion);
      command.Parameters.AddWithValue("@cantidad", (object) pro.Cantidad);
      command.Parameters.AddWithValue("@precio", (object) pro.Precio);
      command.Parameters.AddWithValue("@fechaInicio", (object) pro.Inicio);
      command.Parameters.AddWithValue("@fechaFin", (object) pro.Fin);
      ((DbCommand) command).ExecuteNonQuery();
    }

    private void guardaDetallePromocion(DetallePromocionVO dePro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detallepromocion (idPromocion, codigo, descripcion, cantidad) VALUES (@idPromocion, @codigo, @descripcion, @cantidad)";
      command.Parameters.AddWithValue("@idPromocion", (object) dePro.IdPromocion);
      command.Parameters.AddWithValue("@codigo", (object) dePro.Codigo);
      command.Parameters.AddWithValue("@descripcion", (object) dePro.DescripcionDetalle);
      command.Parameters.AddWithValue("@cantidad", (object) dePro.CantidadDetalle);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public int retornaIdPromocion()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT DISTINCT LAST_INSERT_ID() FROM promocion";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public void modificaPromocion(PromocionVO pro, List<DetallePromocionVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE promocion SET descripcion=@descripcion, cantidad=@cantidad, precio=@precio, fechaInicio=@fechaInicio, fechaFin=@fechaFin WHERE idPromocion=@idPromocion";
      command.Parameters.AddWithValue("@idPromocion", (object) pro.IdPromocion);
      command.Parameters.AddWithValue("@descripcion", (object) pro.Descripcion);
      command.Parameters.AddWithValue("@cantidad", (object) pro.Cantidad);
      command.Parameters.AddWithValue("@precio", (object) pro.Precio);
      command.Parameters.AddWithValue("@fechaInicio", (object) pro.Inicio);
      command.Parameters.AddWithValue("@fechaFin", (object) pro.Fin);
      ((DbCommand) command).ExecuteNonQuery();
      this.eliminaDetallePromocion(pro.IdPromocion);
      foreach (DetallePromocionVO dePro in lista)
      {
        dePro.IdPromocion = pro.IdPromocion;
        this.guardaDetallePromocion(dePro);
      }
    }

    public void eliminaPromocion(int idPromocion)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM promocion WHERE idPromocion=@idPromocion";
      command.Parameters.AddWithValue("@idPromocion", (object) idPromocion);
      ((DbCommand) command).ExecuteNonQuery();
      this.eliminaDetallePromocion(idPromocion);
    }

    private void eliminaDetallePromocion(int idPromocion)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detallepromocion WHERE idPromocion=@idPromocion";
      command.Parameters.AddWithValue("@idPromocion", (object) idPromocion);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<PromocionVO> listaPromocion()
    {
      List<PromocionVO> list = new List<PromocionVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                          idPromocion, descripcion, cantidad, precio, fechaInicio, fechaFin\r\n                                    FROM promocion \r\n                                    WHERE DATE_FORMAT(fechaFin, '%Y-%m-%d') >= DATE_FORMAT(@fechaActual , '%Y-%m-%d') \r\n                                    ORDER BY fechaInicio";
      command.Parameters.AddWithValue("@fechaActual", (object) DateTime.Now);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      PromocionVO promocionVo = new PromocionVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new PromocionVO()
        {
          IdPromocion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPromocion"].ToString()),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString()),
          Precio = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["precio"].ToString()),
          Inicio = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaInicio"].ToString()),
          Fin = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaFin"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<DetallePromocionVO> listaPromocionActivas()
    {
      List<DetallePromocionVO> list = new List<DetallePromocionVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                          p.idPromocion, p.descripcion, p.cantidad, p.precio, d.codigo, d.cantidad as 'cantidadDetalle' \r\n                                    FROM detallepromocion d INNER JOIN \r\n                                    promocion p ON d.idPromocion=p.idPromocion\r\n                                    WHERE DATE_FORMAT(p.fechaFin, '%Y-%m-%d') >= DATE_FORMAT(@fecha , '%Y-%m-%d')";
      command.Parameters.AddWithValue("@fecha", (object) DateTime.Now);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      DetallePromocionVO detallePromocionVo1 = new DetallePromocionVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        DetallePromocionVO detallePromocionVo2 = new DetallePromocionVO();
        detallePromocionVo2.IdPromocion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPromocion"].ToString());
        detallePromocionVo2.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
        detallePromocionVo2.Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString());
        detallePromocionVo2.Precio = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["precio"].ToString());
        detallePromocionVo2.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
        detallePromocionVo2.CantidadDetalle = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidadDetalle"].ToString());
        list.Add(detallePromocionVo2);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public PromocionVO buscaPromocionId(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                          idPromocion, descripcion, cantidad, precio, fechaInicio, fechaFin\r\n                                    FROM promocion \r\n                                    WHERE idPromocion=@idPromocion";
      command.Parameters.AddWithValue("@idPromocion", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      PromocionVO promocionVo = new PromocionVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        promocionVo = new PromocionVO();
        promocionVo.IdPromocion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPromocion"].ToString());
        promocionVo.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
        promocionVo.Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString());
        promocionVo.Precio = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["precio"].ToString());
        promocionVo.Inicio = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaInicio"].ToString());
        promocionVo.Fin = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaFin"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      return promocionVo;
    }

    public List<DetallePromocionVO> buscaDetallePromocionId(int id)
    {
      List<DetallePromocionVO> list = new List<DetallePromocionVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                          idDetallePromocion, idPromocion, codigo, descripcion, cantidad\r\n                                    FROM detallepromocion \r\n                                    WHERE idPromocion=@idPromocion";
      command.Parameters.AddWithValue("@idPromocion", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      DetallePromocionVO detallePromocionVo1 = new DetallePromocionVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        DetallePromocionVO detallePromocionVo2 = new DetallePromocionVO();
        detallePromocionVo2.IdDetallePromocion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetallePromocion"].ToString());
        detallePromocionVo2.IdPromocion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idPromocion"].ToString());
        detallePromocionVo2.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
        detallePromocionVo2.DescripcionDetalle = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
        detallePromocionVo2.CantidadDetalle = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString());
        list.Add(detallePromocionVo2);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
