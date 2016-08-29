 
// Type: Aptusoft.OrdenAtencion
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class OrdenAtencion
  {
    private Conexion conexion = Conexion.getConecta();

    public string numeroAtencion()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "SELECT MAX(idOrdenAtencion)+1 FROM ordenatencion";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num.ToString();
    }

    public void agregaOrdenAtencion(OrdenAtencionVO oa)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "INSERT INTO ordenatencion (\r\n                                                              fechaIngreso,\r\n                                                              fechaAtencion,\r\n                                                              idCliente,\r\n                                                              rut,\r\n                                                              digito,\r\n                                                              razonSocial,\r\n                                                              contacto,\r\n                                                              email,\r\n                                                              fono,\r\n                                                              requerimiento,\r\n                                                              solucion,\r\n                                                              idTecnico,\r\n                                                              tecnico,\r\n                                                              estado,\r\n                                                              usuario, ingresadoPor, tipoSolicitud)\r\n                                                        VALUES (\r\n                                                              @fechaIngreso,\r\n                                                              @fechaAtencion,\r\n                                                              @idCliente,\r\n                                                              @rut,\r\n                                                              @digito,\r\n                                                              @razonSocial,\r\n                                                              @contacto,\r\n                                                              @email,\r\n                                                              @fono,\r\n                                                              @requerimiento,\r\n                                                              @solucion,\r\n                                                              @idTecnico,\r\n                                                              @tecnico,\r\n                                                              @estado,\r\n                                                              @usuario, @ingresadoPor, @tipoSolicitud\r\n                                                            )";
      command.Parameters.AddWithValue("@fechaIngreso", (object) oa.FechaIngreso);
      command.Parameters.AddWithValue("@fechaAtencion", (object) oa.FechaAtencion);
      command.Parameters.AddWithValue("@idCliente", (object) oa.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) oa.Rut);
      command.Parameters.AddWithValue("@digito", (object) oa.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) oa.RazonSocial);
      command.Parameters.AddWithValue("@contacto", (object) oa.Contacto);
      command.Parameters.AddWithValue("@email", (object) oa.Email);
      command.Parameters.AddWithValue("@fono", (object) oa.Fono);
      command.Parameters.AddWithValue("@requerimiento", (object) oa.Requerimiento);
      command.Parameters.AddWithValue("@solucion", (object) oa.Solucion);
      command.Parameters.AddWithValue("@idTecnico", (object) oa.IdTecnico);
      command.Parameters.AddWithValue("@tecnico", (object) oa.Tecnico);
      command.Parameters.AddWithValue("@estado", (object) oa.Estado);
      command.Parameters.AddWithValue("@usuario", (object) oa.Usuario);
      command.Parameters.AddWithValue("@ingresadoPor", (object) oa.IngresadoPor);
      command.Parameters.AddWithValue("@tipoSolicitud", (object) oa.TipoSolicitud);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaOrdenAtencion(OrdenAtencionVO oa)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "UPDATE ordenatencion SET  fechaAtencion=@fechaAtencion,                                                              \r\n                                                              contacto=@contacto,\r\n                                                              email=@email,\r\n                                                              fono=@fono,\r\n                                                              requerimiento=@requerimiento,\r\n                                                              solucion=@solucion,\r\n                                                              idTecnico=@idTecnico,\r\n                                                              tecnico=@tecnico,\r\n                                                              estado=@estado,\r\n                                                              usuario=@usuario,\r\n                                                              ingresadoPor=@ingresadoPor,\r\n                                                              tipoSolicitud=@tipoSolicitud\r\n                                                        WHERE idOrdenAtencion=@idOrdenAtencion";
      command.Parameters.AddWithValue("@idOrdenAtencion", (object) oa.IdOrdenAtencion);
      command.Parameters.AddWithValue("@fechaAtencion", (object) oa.FechaAtencion);
      command.Parameters.AddWithValue("@contacto", (object) oa.Contacto);
      command.Parameters.AddWithValue("@email", (object) oa.Email);
      command.Parameters.AddWithValue("@fono", (object) oa.Fono);
      command.Parameters.AddWithValue("@requerimiento", (object) oa.Requerimiento);
      command.Parameters.AddWithValue("@solucion", (object) oa.Solucion);
      command.Parameters.AddWithValue("@idTecnico", (object) oa.IdTecnico);
      command.Parameters.AddWithValue("@tecnico", (object) oa.Tecnico);
      command.Parameters.AddWithValue("@estado", (object) oa.Estado);
      command.Parameters.AddWithValue("@usuario", (object) oa.Usuario);
      command.Parameters.AddWithValue("@ingresadoPor", (object) oa.IngresadoPor);
      command.Parameters.AddWithValue("@tipoSolicitud", (object) oa.TipoSolicitud);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<OrdenAtencionVO> listaOrdenAtencion(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "SELECT  idOrdenAtencion,\r\n                                            fechaIngreso,\r\n                                            fechaAtencion,\r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            contacto,\r\n                                            email,\r\n                                            fono,\r\n                                            requerimiento,\r\n                                            solucion,\r\n                                            idTecnico,\r\n                                            tecnico,\r\n                                            estado,\r\n                                            usuario, \r\n                                            ingresadoPor,\r\n                                            tipoSolicitud \r\n                                    FROM ordenatencion WHERE idCliente=@idCliente ORDER BY idOrdenAtencion DESC";
      command.Parameters.AddWithValue("@idCliente", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<OrdenAtencionVO> list = new List<OrdenAtencionVO>();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new OrdenAtencionVO()
        {
          IdOrdenAtencion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrdenAtencion"].ToString()),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          FechaAtencion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaAtencion"].ToString()),
          IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString()),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString(),
          Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString(),
          Email = ((DbDataReader) mySqlDataReader)["email"].ToString(),
          Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString(),
          Requerimiento = ((DbDataReader) mySqlDataReader)["requerimiento"].ToString(),
          Solucion = ((DbDataReader) mySqlDataReader)["solucion"].ToString(),
          IdTecnico = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTecnico"].ToString()),
          Tecnico = ((DbDataReader) mySqlDataReader)["tecnico"].ToString(),
          Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString(),
          Usuario = ((DbDataReader) mySqlDataReader)["usuario"].ToString(),
          IngresadoPor = ((DbDataReader) mySqlDataReader)["ingresadoPor"].ToString(),
          TipoSolicitud = ((DbDataReader) mySqlDataReader)["tipoSolicitud"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<OrdenAtencionVO> listaOrdenAtencionFiltro(string desde, string hasta, string estado, string tipoFecha, string tecnico)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "SELECT  idOrdenAtencion,\r\n                                            fechaIngreso,\r\n                                            fechaAtencion,\r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            contacto,\r\n                                            email,\r\n                                            fono,\r\n                                            requerimiento,\r\n                                            solucion,\r\n                                            idTecnico,\r\n                                            tecnico,\r\n                                            estado,\r\n                                            usuario , \r\n                                            ingresadoPor,\r\n                                            tipoSolicitud \r\n                                    FROM ordenatencion WHERE DATE_FORMAT(" + tipoFecha + ", '%Y-%m-%d') >= @desde AND DATE_FORMAT(" + tipoFecha + ", '%Y-%m-%d') <= @hasta " + estado + " " + tecnico + " ORDER BY fechaAtencion ASC";
      command.Parameters.AddWithValue("@desde", (object) desde);
      command.Parameters.AddWithValue("@hasta", (object) hasta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<OrdenAtencionVO> list = new List<OrdenAtencionVO>();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new OrdenAtencionVO()
        {
          IdOrdenAtencion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrdenAtencion"].ToString()),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          FechaAtencion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaAtencion"].ToString()),
          HoraAtencion = ((DbDataReader) mySqlDataReader)["fechaAtencion"].ToString(),
          IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString()),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString(),
          Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString(),
          Email = ((DbDataReader) mySqlDataReader)["email"].ToString(),
          Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString(),
          Requerimiento = ((DbDataReader) mySqlDataReader)["requerimiento"].ToString(),
          Solucion = ((DbDataReader) mySqlDataReader)["solucion"].ToString(),
          IdTecnico = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTecnico"].ToString()),
          Tecnico = ((DbDataReader) mySqlDataReader)["tecnico"].ToString(),
          Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString(),
          Usuario = ((DbDataReader) mySqlDataReader)["usuario"].ToString(),
          IngresadoPor = ((DbDataReader) mySqlDataReader)["ingresadoPor"].ToString(),
          TipoSolicitud = ((DbDataReader) mySqlDataReader)["tipoSolicitud"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public OrdenAtencionVO buscaOrdenAtencion(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "SELECT  idOrdenAtencion,\r\n                                            fechaIngreso,\r\n                                            fechaAtencion,\r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            contacto,\r\n                                            email,\r\n                                            fono,\r\n                                            requerimiento,\r\n                                            solucion,\r\n                                            idTecnico,\r\n                                            tecnico,\r\n                                            estado,\r\n                                            usuario, \r\n                                            ingresadoPor,\r\n                                            tipoSolicitud  \r\n                                    FROM ordenatencion WHERE idOrdenAtencion=@idOrdenAtencion ";
      command.Parameters.AddWithValue("@idOrdenAtencion", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      OrdenAtencionVO ordenAtencionVo = new OrdenAtencionVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        ordenAtencionVo = new OrdenAtencionVO();
        ordenAtencionVo.IdOrdenAtencion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrdenAtencion"].ToString());
        ordenAtencionVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
        ordenAtencionVo.FechaAtencion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaAtencion"].ToString());
        ordenAtencionVo.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString());
        ordenAtencionVo.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        ordenAtencionVo.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        ordenAtencionVo.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        ordenAtencionVo.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        ordenAtencionVo.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        ordenAtencionVo.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        ordenAtencionVo.Requerimiento = ((DbDataReader) mySqlDataReader)["requerimiento"].ToString();
        ordenAtencionVo.Solucion = ((DbDataReader) mySqlDataReader)["solucion"].ToString();
        ordenAtencionVo.IdTecnico = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTecnico"].ToString());
        ordenAtencionVo.Tecnico = ((DbDataReader) mySqlDataReader)["tecnico"].ToString();
        ordenAtencionVo.Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString();
        ordenAtencionVo.Usuario = ((DbDataReader) mySqlDataReader)["usuario"].ToString();
        ordenAtencionVo.IngresadoPor = ((DbDataReader) mySqlDataReader)["ingresadoPor"].ToString();
        ordenAtencionVo.TipoSolicitud = ((DbDataReader) mySqlDataReader)["tipoSolicitud"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return ordenAtencionVo;
    }

    public OrdenAtencionVO buscaOrdenAtencionTecnico(string tecnico)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "SELECT  idOrdenAtencion,\r\n                                            fechaIngreso,\r\n                                            fechaAtencion,\r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            contacto,\r\n                                            email,\r\n                                            fono,\r\n                                            requerimiento,\r\n                                            solucion,\r\n                                            idTecnico,\r\n                                            tecnico,\r\n                                            estado,\r\n                                            usuario, \r\n                                            ingresadoPor,\r\n                                            tipoSolicitud  \r\n                                    FROM ordenatencion WHERE idOrdenAtencion=(select MAX(idOrdenAtencion) from ordenatencion where tecnico=@tecnico AND estado='PENDIENTE')";
      command.Parameters.AddWithValue("@tecnico", (object) tecnico);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      OrdenAtencionVO ordenAtencionVo = new OrdenAtencionVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        ordenAtencionVo = new OrdenAtencionVO();
        ordenAtencionVo.IdOrdenAtencion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrdenAtencion"].ToString());
        ordenAtencionVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
        ordenAtencionVo.FechaAtencion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaAtencion"].ToString());
        ordenAtencionVo.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString());
        ordenAtencionVo.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        ordenAtencionVo.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        ordenAtencionVo.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        ordenAtencionVo.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        ordenAtencionVo.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        ordenAtencionVo.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        ordenAtencionVo.Requerimiento = ((DbDataReader) mySqlDataReader)["requerimiento"].ToString();
        ordenAtencionVo.Solucion = ((DbDataReader) mySqlDataReader)["solucion"].ToString();
        ordenAtencionVo.IdTecnico = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTecnico"].ToString());
        ordenAtencionVo.Tecnico = ((DbDataReader) mySqlDataReader)["tecnico"].ToString();
        ordenAtencionVo.Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString();
        ordenAtencionVo.Usuario = ((DbDataReader) mySqlDataReader)["usuario"].ToString();
        ordenAtencionVo.IngresadoPor = ((DbDataReader) mySqlDataReader)["ingresadoPor"].ToString();
        ordenAtencionVo.TipoSolicitud = ((DbDataReader) mySqlDataReader)["tipoSolicitud"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return ordenAtencionVo;
    }

    public void eliminaOrdenAtencion(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "DELETE  FROM ordenatencion WHERE idOrdenAtencion=@idOrdenAtencion ";
      command.Parameters.AddWithValue("@idOrdenAtencion", (object) id);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
