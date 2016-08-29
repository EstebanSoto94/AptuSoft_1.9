 
// Type: Aptusoft.Usuario
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  internal class Usuario
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaUsuario(UsuarioVO usVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO usuario (nombre, clave, idTipoUsuario, bodega, caja, listaPrecio, modificaStock, veInformesCaja)\r\n                                                VALUES(@nombre, @clave, @idTipoUsuario, @bodega, @caja, @listaPrecio, @modificaStock, @veInformesCaja)";
      command.Parameters.AddWithValue("@nombre", (object) usVO.NombreUsuario);
      command.Parameters.AddWithValue("@clave", (object) usVO.Clave);
      command.Parameters.AddWithValue("@idTipoUsuario", (object) usVO.IdTipoUsuario);
      command.Parameters.AddWithValue("@bodega", (object) usVO.IdBodega);
      command.Parameters.AddWithValue("@caja", (object) usVO.IdCaja);
      command.Parameters.AddWithValue("@listaPrecio", (object) usVO.IdListaPrecio);
      command.Parameters.AddWithValue("@modificaStock", (usVO.ModificaStock ? 1 : 0));
      command.Parameters.AddWithValue("@veInformesCaja", (usVO.VerInformCaja ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<UsuarioVO> listaUsuarios()
    {
      List<UsuarioVO> list = new List<UsuarioVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idUsuario, nombre, clave, idTipoUsuario, bodega, caja, listaPrecio, modificaStock, veInformesCaja, \r\n                                            bodegas.descripcion as 'nombreBodega', cajas.descripcion as 'nombreCaja',  listas_precio.descripcion as 'nombreLista'\r\n                                    FROM usuario \r\n                                         LEFT JOIN bodegas ON usuario.bodega = bodegas.codigo\r\n                                         LEFT JOIN cajas ON usuario.caja = cajas.codigo\r\n                                         LEFT JOIN listas_precio ON usuario.listaPrecio = listas_precio.codigo\r\nORDER BY idUsuario";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new UsuarioVO()
        {
          IdUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idUsuario"].ToString()),
          NombreUsuario = ((DbDataReader) mySqlDataReader)["nombre"].ToString(),
          Clave = ((DbDataReader) mySqlDataReader)["clave"].ToString(),
          IdTipoUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoUsuario"].ToString()),
          IdBodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString()),
          IdCaja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["caja"].ToString()),
          IdListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"].ToString()),
          ModificaStock = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["modificaStock"]),
          VerInformCaja = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["veInformesCaja"]),
          Bodega = ((DbDataReader) mySqlDataReader)["nombreBodega"].ToString(),
          Caja = ((DbDataReader) mySqlDataReader)["nombreCaja"].ToString(),
          ListaPrecio = ((DbDataReader) mySqlDataReader)["nombreLista"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public UsuarioVO retornaUsuarioID(int idUsuario)
    {
      UsuarioVO usuarioVo = new UsuarioVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idUsuario, nombre, clave, idTipoUsuario, bodega, caja, listaPrecio, modificaStock, veInformesCaja FROM usuario WHERE idUsuario=@IdUsuario ORDER BY idUsuario";
      command.Parameters.AddWithValue("@IdUsuario", (object) idUsuario);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        usuarioVo = new UsuarioVO();
        usuarioVo.IdUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idUsuario"].ToString());
        usuarioVo.NombreUsuario = ((DbDataReader) mySqlDataReader)["nombre"].ToString();
        usuarioVo.Clave = ((DbDataReader) mySqlDataReader)["clave"].ToString();
        usuarioVo.IdTipoUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoUsuario"].ToString());
        usuarioVo.IdBodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString());
        usuarioVo.IdCaja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["caja"].ToString());
        usuarioVo.IdListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"].ToString());
        usuarioVo.ModificaStock = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["modificaStock"]);
        usuarioVo.VerInformCaja = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["veInformesCaja"]);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return usuarioVo;
    }

    public void modificaUsuario(UsuarioVO usVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE usuario SET nombre=@nombre, clave=@clave, idTipoUsuario=@idTipoUsuario, bodega=@bodega, caja=@caja, listaPrecio=@listaPrecio, modificaStock=@modificaStock, veInformesCaja=@veInformesCaja WHERE idUsuario=@idUsuario";
      command.Parameters.AddWithValue("@nombre", (object) usVO.NombreUsuario);
      command.Parameters.AddWithValue("@clave", (object) usVO.Clave);
      command.Parameters.AddWithValue("@idTipoUsuario", (object) usVO.IdTipoUsuario);
      command.Parameters.AddWithValue("@bodega", (object) usVO.IdBodega);
      command.Parameters.AddWithValue("@caja", (object) usVO.IdCaja);
      command.Parameters.AddWithValue("@listaPrecio", (object) usVO.IdListaPrecio);
      command.Parameters.AddWithValue("@idUsuario", (object) usVO.IdUsuario);
      command.Parameters.AddWithValue("@modificaStock", (usVO.ModificaStock ? 1 : 0));
      command.Parameters.AddWithValue("@veInformesCaja", (usVO.VerInformCaja ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaUsuario(int idUsuario)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM usuario WHERE idUsuario=@idUsuario";
      command.Parameters.AddWithValue("@idUsuario", (object) idUsuario);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public int cuentaTipoUsuario(int idTipo)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT COUNT(idTipoUsuario) FROM usuario WHERE IdTipoUsuario=@idTipo";
      command.Parameters.AddWithValue("@idTipo", (object) idTipo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int loginUsuario(string nombre, string clave)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idUsuario FROM usuario WHERE nombre=@Nombre AND clave=@Clave";
      command.Parameters.AddWithValue("@Nombre", (object) nombre);
      command.Parameters.AddWithValue("@Clave", (object) clave);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public List<UsuarioVO> loginUsuarioDetalleTipo(int idUsuario)
    {
      List<UsuarioVO> list = new List<UsuarioVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                        usuario.idUsuario,\r\n                                        usuario.nombre,\r\n                                        usuario.idTipoUsuario,\r\n                                        usuario.bodega,\r\n                                        usuario.caja,\r\n                                        usuario.listaPrecio,\r\n                                        usuario.modificaStock,\r\n                                        usuario.veInformesCaja,\r\n                                        detalletipousuario.modulo,\r\n                                        detalletipousuario.ingresar, \r\n                                        detalletipousuario.guardar,\r\n                                        detalletipousuario.modificar,\r\n                                        detalletipousuario.eliminar,\r\n                                        detalletipousuario.anular,\r\n                                        detalletipousuario.descuento, \r\n                                        detalletipousuario.cambioPrecio,\r\n                                        detalletipousuario.cambioFecha\r\n                                   FROM usuario INNER JOIN detalletipousuario \r\n                                   ON usuario.idTipoUsuario = detalletipousuario.idTipoUsuario\r\n                                   WHERE usuario.idUsuario = @IdUsuario";
      command.Parameters.AddWithValue("@IdUsuario", (object) idUsuario);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new UsuarioVO()
        {
          IdUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idUsuario"].ToString()),
          NombreUsuario = ((DbDataReader) mySqlDataReader)["nombre"].ToString(),
          IdTipoUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoUsuario"].ToString()),
          IdBodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString()),
          IdCaja = Convert.ToInt32(((DbDataReader) mySqlDataReader)["caja"].ToString()),
          IdListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"].ToString()),
          ModificaStock = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["modificaStock"]),
          VerInformCaja = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["veInformesCaja"]),
          Modulo = ((DbDataReader) mySqlDataReader)["modulo"].ToString(),
          Ingresa = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["ingresar"]),
          Guarda = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["guardar"]),
          Modifica = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["modificar"]),
          Elimina = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["eliminar"]),
          Anula = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["anular"]),
          Descuento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["descuento"]),
          CambioPrecio = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["cambioPrecio"]),
          CambioFecha = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["cambioFecha"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
