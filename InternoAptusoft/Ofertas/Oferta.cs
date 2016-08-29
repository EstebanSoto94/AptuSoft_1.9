 
// Type: Aptusoft.InternoAptusoft.Ofertas.Oferta
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft.InternoAptusoft.Ofertas
{
  public class Oferta
  {
    private Conexion conexion = Conexion.getConecta();

    public void GuardaOferta(OfertaVO of)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO internos_ofertas (codigoOferta, nombre, descripcion, vigente, descuento, cantidadMeses) \r\n                                                           VALUES(@codigoOferta, @nombre, @descripcion, @vigente, @descuento, @cantidadMeses)";
      command.Parameters.AddWithValue("@codigoOferta", (object) of.CodigoOferta);
      command.Parameters.AddWithValue("@nombre", (object) of.Nombre);
      command.Parameters.AddWithValue("@descripcion", (object) of.Descripcion);
      command.Parameters.AddWithValue("@vigente", (of.Vigente ? 1 : 0));
      command.Parameters.AddWithValue("@descuento", (object) of.Descuento);
      command.Parameters.AddWithValue("@cantidadMeses", (object) of.CantidadMeses);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void ModificaOferta(OfertaVO of)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE internos_ofertas SET \r\n                                                codigoOferta=@codigoOferta,\r\n                                                nombre=@nombre,\r\n                                                descripcion=@descripcion,\r\n                                                vigente=@vigente,\r\n                                                descuento=@descuento,\r\n                                                cantidadMeses=@cantidadMeses\r\n                                            WHERE idOferta=@idOferta";
      command.Parameters.AddWithValue("@idOferta", (object) of.IdOferta);
      command.Parameters.AddWithValue("@codigoOferta", (object) of.CodigoOferta);
      command.Parameters.AddWithValue("@nombre", (object) of.Nombre);
      command.Parameters.AddWithValue("@descripcion", (object) of.Descripcion);
      command.Parameters.AddWithValue("@vigente", (of.Vigente ? 1 : 0));
      command.Parameters.AddWithValue("@descuento", (object) of.Descuento);
      command.Parameters.AddWithValue("@cantidadMeses", (object) of.CantidadMeses);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<OfertaVO> ListaOfertas()
    {
      List<OfertaVO> list = new List<OfertaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idOferta, codigoOferta, nombre, descripcion, vigente, descuento, cantidadMeses FROM internos_ofertas ORDER BY nombre";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      OfertaVO ofertaVo = new OfertaVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new OfertaVO()
        {
          IdOferta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOferta"].ToString()),
          CodigoOferta = ((DbDataReader) mySqlDataReader)["codigoOferta"].ToString(),
          Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          Vigente = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["vigente"]),
          Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuento"].ToString()),
          CantidadMeses = Convert.ToInt32(((DbDataReader) mySqlDataReader)["cantidadMeses"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<OfertaVO> ListaOfertasVigentes()
    {
      List<OfertaVO> list = new List<OfertaVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idOferta, codigoOferta, nombre, descripcion, vigente, descuento, cantidadMeses FROM internos_ofertas WHERE vigente=1 ORDER BY nombre";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new OfertaVO()
      {
        IdOferta = 0,
        CodigoOferta = "0",
        Nombre = "[SELECCIONE]",
        Descripcion = "SIN OFERTA",
        Vigente = true
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new OfertaVO()
        {
          IdOferta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOferta"].ToString()),
          CodigoOferta = ((DbDataReader) mySqlDataReader)["codigoOferta"].ToString(),
          Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString(),
          Vigente = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["vigente"]),
          Descuento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuento"].ToString()),
          CantidadMeses = Convert.ToInt32(((DbDataReader) mySqlDataReader)["cantidadMeses"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void EliminaOferta(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM internos_ofertas WHERE idOferta=@Id";
      command.Parameters.AddWithValue("@Id", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
