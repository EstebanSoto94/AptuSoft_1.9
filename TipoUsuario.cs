 
// Type: Aptusoft.TipoUsuario
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  internal class TipoUsuario
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaTipoUsuario(TipoUsuarioVO tuVO, List<DetalleTipoUsuarioVO> lista)
    {
      this.agregaTipoUsuario(tuVO);
      int num = this.retornaIdTipoUsuario(tuVO.NombreTipoUsuario);
      foreach (DetalleTipoUsuarioVO dtuVO in lista)
      {
        dtuVO.IdTipoUsuario = num;
        this.agregaDetalleTipoUsuario(dtuVO);
      }
    }

    private void agregaTipoUsuario(TipoUsuarioVO tuVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO tipousuario (nombreTipoUsuario) VALUES(@nombreTipoUsuario)";
      command.Parameters.AddWithValue("@nombreTipoUsuario", (object) tuVO.NombreTipoUsuario);
      ((DbCommand) command).ExecuteNonQuery();
    }

    private void agregaDetalleTipoUsuario(DetalleTipoUsuarioVO dtuVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO detalletipousuario (\r\n                                                                    idTipoUsuario,\r\n                                                                    modulo,\r\n                                                                    ingresar,\r\n                                                                    guardar,\r\n                                                                    modificar,\r\n                                                                    eliminar,\r\n                                                                    anular,\r\n                                                                    descuento,\r\n                                                                    cambioPrecio,\r\n                                                                    cambioFecha\r\n                                                                    ) \r\n                                                             VALUES(\r\n                                                                    @idTipoUsuario,\r\n                                                                    @modulo,\r\n                                                                    @ingresar,\r\n                                                                    @guardar,\r\n                                                                    @modificar,\r\n                                                                    @eliminar,\r\n                                                                    @anular,\r\n                                                                    @descuento,\r\n                                                                    @cambioPrecio,\r\n                                                                    @cambioFecha\r\n                                                                    )";
      command.Parameters.AddWithValue("@idTipoUsuario", (object) dtuVO.IdTipoUsuario);
      command.Parameters.AddWithValue("@modulo", (object) dtuVO.Modulo);
      command.Parameters.AddWithValue("@ingresar", (dtuVO.Ingresa ? 1 : 0));
      command.Parameters.AddWithValue("@guardar", (dtuVO.Guarda ? 1 : 0));
      command.Parameters.AddWithValue("@modificar", (dtuVO.Modifica ? 1 : 0));
      command.Parameters.AddWithValue("@eliminar", (dtuVO.Elimina ? 1 : 0));
      command.Parameters.AddWithValue("@anular", (dtuVO.Anula ? 1 : 0));
      command.Parameters.AddWithValue("@descuento", (dtuVO.Descuento ? 1 : 0));
      command.Parameters.AddWithValue("@cambioPrecio", (dtuVO.CambioPrecio ? 1 : 0));
      command.Parameters.AddWithValue("@cambioFecha", (dtuVO.CambioFecha ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public int retornaIdTipoUsuario(string nombre)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idTipoUsuario FROM tipousuario WHERE nombreTipoUsuario=@NombreTipoUsuario";
      command.Parameters.AddWithValue("@NombreTipoUsuario", (object) nombre);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public string retornaNombreTipoUsuario(int idTipo)
    {
      string str = "";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT nombreTipoUsuario FROM tipousuario WHERE idTipoUsuario=@IdTipoUsuario";
      command.Parameters.AddWithValue("@IdTipoUsuario", (object) idTipo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        str = ((DbDataReader) mySqlDataReader)[0].ToString();
      ((DbDataReader) mySqlDataReader).Close();
      return str;
    }

    public List<TipoUsuarioVO> listaTiposUsuario()
    {
      List<TipoUsuarioVO> list = new List<TipoUsuarioVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idTipoUsuario, nombreTipoUsuario FROM tipousuario ORDER BY idTipoUsuario";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new TipoUsuarioVO()
        {
          IdTipoUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoUsuario"].ToString()),
          NombreTipoUsuario = ((DbDataReader) mySqlDataReader)["nombreTipoUsuario"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<TipoUsuarioVO> listaTiposUsuarioSinFiltro()
    {
      List<TipoUsuarioVO> list = new List<TipoUsuarioVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idTipoUsuario, nombreTipoUsuario FROM tipousuario ORDER BY idTipoUsuario";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new TipoUsuarioVO()
        {
          IdTipoUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoUsuario"].ToString()),
          NombreTipoUsuario = ((DbDataReader) mySqlDataReader)["nombreTipoUsuario"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<DetalleTipoUsuarioVO> listaDetalleTipoUsuario(int idTipo)
    {
      List<DetalleTipoUsuarioVO> list = new List<DetalleTipoUsuarioVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idDetalleTipoUsuario,\r\n                                            idTipoUsuario,\r\n                                            modulo,\r\n                                            ingresar,\r\n                                            guardar,\r\n                                            modificar,\r\n                                            eliminar,\r\n                                            anular,\r\n                                            descuento,\r\n                                            cambioPrecio,\r\n                                            cambioFecha\r\n                                   FROM detalletipousuario WHERE idTipousuario=@idTipousuario ORDER BY idDetalleTipoUsuario";
      command.Parameters.AddWithValue("@idTipousuario", (object) idTipo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new DetalleTipoUsuarioVO()
        {
          IdDetalleTipoUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleTipoUsuario"].ToString()),
          IdTipoUsuario = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoUsuario"].ToString()),
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

    public void modificarTipoUsuario(TipoUsuarioVO tuVO, List<DetalleTipoUsuarioVO> lista)
    {
      this.modificaTipoUsuario(tuVO);
      this.eliminaDetalleTipoUsuario(tuVO.IdTipoUsuario);
      foreach (DetalleTipoUsuarioVO dtuVO in lista)
        this.agregaDetalleTipoUsuario(dtuVO);
    }

    private void modificaTipoUsuario(TipoUsuarioVO tuVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE tipousuario SET nombreTipoUsuario=@nombreTipoUsuario WHERE idTipousuario=@idTipousuario";
      command.Parameters.AddWithValue("@idTipousuario", (object) tuVO.IdTipoUsuario);
      command.Parameters.AddWithValue("@nombreTipoUsuario", (object) tuVO.NombreTipoUsuario);
      ((DbCommand) command).ExecuteNonQuery();
    }

    private void modificaDetalleTipoUsuario(DetalleTipoUsuarioVO dtuVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE detalletipousuario   SET \r\n                                                                    modulo=@modulo,\r\n                                                                    ingresar=@ingresar,\r\n                                                                    guardar=@guardar,\r\n                                                                    modificar=@modificar,\r\n                                                                    eliminar=@eliminar,\r\n                                                                    anular=@anular,\r\n                                                                    descuento=@descuento,\r\n                                                                    cambioPrecio=@cambioPrecio,\r\n                                                                    cambioFecha=@cambioFecha\r\n                                                                WHERE idDetalleTipoUsuario=@idDetalleTipoUsuario";
      command.Parameters.AddWithValue("@idDetalleTipoUsuario", (object) dtuVO.IdDetalleTipoUsuario);
      command.Parameters.AddWithValue("@modulo", (object) dtuVO.Modulo);
      command.Parameters.AddWithValue("@ingresar", (dtuVO.Ingresa ? 1 : 0));
      command.Parameters.AddWithValue("@guardar", (dtuVO.Guarda ? 1 : 0));
      command.Parameters.AddWithValue("@modificar", (dtuVO.Modifica ? 1 : 0));
      command.Parameters.AddWithValue("@eliminar", (dtuVO.Elimina ? 1 : 0));
      command.Parameters.AddWithValue("@anular", (dtuVO.Anula ? 1 : 0));
      command.Parameters.AddWithValue("@descuento", (dtuVO.Descuento ? 1 : 0));
      command.Parameters.AddWithValue("@cambioPrecio", (dtuVO.CambioPrecio ? 1 : 0));
      command.Parameters.AddWithValue("@cambioFecha", (dtuVO.CambioFecha ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaTipoUsuario(int idTipousuario)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE t, d FROM tipousuario t, detalletipousuario d WHERE t.idTipousuario=@idTipo AND d.idTipoUsuario=@idTipo";
      command.Parameters.AddWithValue("@idTipo", (object) idTipousuario);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaDetalleTipoUsuario(int idTipousuario)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM detalletipousuario WHERE idTipoUsuario=@idTipo";
      command.Parameters.AddWithValue("@idTipo", (object) idTipousuario);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
