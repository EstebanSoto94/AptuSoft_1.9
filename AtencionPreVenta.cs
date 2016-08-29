 
// Type: Aptusoft.AtencionPreVenta
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class AtencionPreVenta
  {
    private Conexion conexion = Conexion.getConecta();

    public string numeroAtencion()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(idOrden)+1 FROM orden_preventa";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num.ToString();
    }

    public void agregaOrden(OrdenAtencionVO oa)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO orden_preventa (\r\n                                                              fechaIngreso,                                                              \r\n                                                              idCliente,\r\n                                                              rut,\r\n                                                              digito,\r\n                                                              razonSocial,\r\n                                                              contacto,\r\n                                                              email,\r\n                                                              fono,\r\n                                                              email2,\r\n                                                              fono2,\r\n                                                              email3,\r\n                                                              fono3,\r\n                                                              observacion,                                                              \r\n                                                              idVendedor,\r\n                                                              vendedor,\r\n                                                              estado,\r\n                                                              fechaAtencion\r\n                                                              )\r\n                                                        VALUES (\r\n                                                              @fechaIngreso,                                                              \r\n                                                              @idCliente,\r\n                                                              @rut,\r\n                                                              @digito,\r\n                                                              @razonSocial,\r\n                                                              @contacto,\r\n                                                              @email,\r\n                                                              @fono,\r\n                                                              @email2,\r\n                                                              @fono2,\r\n                                                              @email3,\r\n                                                              @fono3,\r\n                                                              @observacion,                                                              \r\n                                                              @idVendedor,\r\n                                                              @vendedor,\r\n                                                              @estado, \r\n                                                              @fechaAtencion\r\n                                                            )";
      command.Parameters.AddWithValue("@fechaIngreso", (object) DateTime.Now);
      command.Parameters.AddWithValue("@idCliente", (object) oa.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) oa.Rut);
      command.Parameters.AddWithValue("@digito", (object) oa.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) oa.RazonSocial);
      command.Parameters.AddWithValue("@contacto", (object) oa.Contacto);
      command.Parameters.AddWithValue("@email", (object) oa.Email);
      command.Parameters.AddWithValue("@fono", (object) oa.Fono);
      command.Parameters.AddWithValue("@email2", (object) oa.Email2);
      command.Parameters.AddWithValue("@fono2", (object) oa.Fono2);
      command.Parameters.AddWithValue("@email3", (object) oa.Email3);
      command.Parameters.AddWithValue("@fono3", (object) oa.Fono3);
      command.Parameters.AddWithValue("@observacion", (object) oa.Requerimiento);
      command.Parameters.AddWithValue("@idVendedor", (object) oa.IdTecnico);
      command.Parameters.AddWithValue("@vendedor", (object) oa.Tecnico);
      command.Parameters.AddWithValue("@estado", (object) oa.Estado);
      command.Parameters.AddWithValue("@fechaAtencion", (object) oa.FechaAtencion);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaOrden(OrdenAtencionVO oa)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE orden_preventa  SET                                                                                                                           \r\n                                                              idCliente = @idCliente,\r\n                                                              rut = @rut,\r\n                                                              digito = @digito,\r\n                                                              razonSocial = @razonSocial,\r\n                                                              contacto = @contacto,\r\n                                                              email = @email,\r\n                                                              fono = @fono,\r\n                                                              email2 = @email2,\r\n                                                              fono2 = @fono2,\r\n                                                              email3 = @email3,\r\n                                                              fono3 = @fono3,\r\n                                                              observacion = @observacion,                                                              \r\n                                                              idVendedor = @idVendedor,\r\n                                                              vendedor = @vendedor,\r\n                                                              estado = @estado, \r\n                                                              fechaModificacion = @fechaModificacion,\r\n                                                              fechaAtencion = @fechaAtencion\r\n                                                        WHERE idOrden = @idOrden";
      command.Parameters.AddWithValue("@idOrden", (object) oa.IdOrdenAtencion);
      command.Parameters.AddWithValue("@fechaModificacion", (object) DateTime.Now);
      command.Parameters.AddWithValue("@idCliente", (object) oa.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) oa.Rut);
      command.Parameters.AddWithValue("@digito", (object) oa.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) oa.RazonSocial);
      command.Parameters.AddWithValue("@contacto", (object) oa.Contacto);
      command.Parameters.AddWithValue("@email", (object) oa.Email);
      command.Parameters.AddWithValue("@fono", (object) oa.Fono);
      command.Parameters.AddWithValue("@email2", (object) oa.Email2);
      command.Parameters.AddWithValue("@fono2", (object) oa.Fono2);
      command.Parameters.AddWithValue("@email3", (object) oa.Email3);
      command.Parameters.AddWithValue("@fono3", (object) oa.Fono3);
      command.Parameters.AddWithValue("@observacion", (object) oa.Requerimiento);
      command.Parameters.AddWithValue("@idVendedor", (object) oa.IdTecnico);
      command.Parameters.AddWithValue("@vendedor", (object) oa.Tecnico);
      command.Parameters.AddWithValue("@estado", (object) oa.Estado);
      command.Parameters.AddWithValue("@fechaAtencion", (object) oa.FechaAtencion);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<OrdenAtencionVO> listaOrden(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idOrden,\r\n                                            fechaIngreso,                                                              \r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            contacto,\r\n                                            email,\r\n                                            fono,\r\n                                            email2,\r\n                                            fono2,\r\n                                            email3,\r\n                                            fono3,\r\n                                            observacion,                                                              \r\n                                            idVendedor,\r\n                                            vendedor,\r\n                                            estado, fechaAtencion\r\n                                    FROM orden_preventa WHERE idCliente=@idCliente ORDER BY idOrden DESC";
      command.Parameters.AddWithValue("@idCliente", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<OrdenAtencionVO> list = new List<OrdenAtencionVO>();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new OrdenAtencionVO()
        {
          IdOrdenAtencion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrden"].ToString()),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString()),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString(),
          Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString(),
          Email = ((DbDataReader) mySqlDataReader)["email"].ToString(),
          Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString(),
          Email2 = ((DbDataReader) mySqlDataReader)["email2"].ToString(),
          Fono2 = ((DbDataReader) mySqlDataReader)["fono2"].ToString(),
          Email3 = ((DbDataReader) mySqlDataReader)["email3"].ToString(),
          Fono3 = ((DbDataReader) mySqlDataReader)["fono3"].ToString(),
          Requerimiento = ((DbDataReader) mySqlDataReader)["observacion"].ToString(),
          IdTecnico = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"].ToString()),
          Tecnico = ((DbDataReader) mySqlDataReader)["vendedor"].ToString(),
          Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString(),
          FechaAtencion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaAtencion"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<OrdenAtencionVO> listaOrdenFiltro(string filtro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idOrden,\r\n                                            fechaIngreso,                                                              \r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            contacto,\r\n                                            email,\r\n                                            fono,\r\n                                            email2,\r\n                                            fono2,\r\n                                            email3,\r\n                                            fono3,\r\n                                            observacion,                                                              \r\n                                            idVendedor,\r\n                                            vendedor,\r\n                                            estado, fechaAtencion\r\n                                    FROM orden_preventa " + filtro + " ORDER BY idOrden DESC";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<OrdenAtencionVO> list = new List<OrdenAtencionVO>();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new OrdenAtencionVO()
        {
          IdOrdenAtencion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrden"].ToString()),
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString()),
          IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString()),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString(),
          Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString(),
          Email = ((DbDataReader) mySqlDataReader)["email"].ToString(),
          Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString(),
          Email2 = ((DbDataReader) mySqlDataReader)["email2"].ToString(),
          Fono2 = ((DbDataReader) mySqlDataReader)["fono2"].ToString(),
          Email3 = ((DbDataReader) mySqlDataReader)["email3"].ToString(),
          Fono3 = ((DbDataReader) mySqlDataReader)["fono3"].ToString(),
          Requerimiento = ((DbDataReader) mySqlDataReader)["observacion"].ToString(),
          IdTecnico = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"].ToString()),
          Tecnico = ((DbDataReader) mySqlDataReader)["vendedor"].ToString(),
          Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString(),
          FechaAtencion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaAtencion"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public OrdenAtencionVO buscaOrdenPreventa(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandTimeout = 0;
      ((DbCommand) command).CommandText = "SELECT  idOrden,\r\n                                            fechaIngreso,                                                              \r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            contacto,\r\n                                            email,\r\n                                            fono,\r\n                                            email2,\r\n                                            fono2,\r\n                                            email3,\r\n                                            fono3,\r\n                                            observacion,                                                              \r\n                                            idVendedor,\r\n                                            vendedor,\r\n                                            estado, fechaAtencion\r\n                                    FROM orden_preventa WHERE idOrden=@idOrden ORDER BY idOrden DESC";
      command.Parameters.AddWithValue("@idOrden", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      OrdenAtencionVO ordenAtencionVo = new OrdenAtencionVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        ordenAtencionVo.IdOrdenAtencion = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOrden"].ToString());
        ordenAtencionVo.FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaIngreso"].ToString());
        ordenAtencionVo.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString());
        ordenAtencionVo.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        ordenAtencionVo.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        ordenAtencionVo.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        ordenAtencionVo.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        ordenAtencionVo.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        ordenAtencionVo.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        ordenAtencionVo.Email2 = ((DbDataReader) mySqlDataReader)["email2"].ToString();
        ordenAtencionVo.Fono2 = ((DbDataReader) mySqlDataReader)["fono2"].ToString();
        ordenAtencionVo.Email3 = ((DbDataReader) mySqlDataReader)["email3"].ToString();
        ordenAtencionVo.Fono3 = ((DbDataReader) mySqlDataReader)["fono3"].ToString();
        ordenAtencionVo.Requerimiento = ((DbDataReader) mySqlDataReader)["observacion"].ToString();
        ordenAtencionVo.IdTecnico = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idVendedor"].ToString());
        ordenAtencionVo.Tecnico = ((DbDataReader) mySqlDataReader)["vendedor"].ToString();
        ordenAtencionVo.Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString();
        ordenAtencionVo.FechaAtencion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaAtencion"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      return ordenAtencionVo;
    }

    public DataTable preventaInforme(string filtro)
    {
      string str = "SELECT \r\n                                            orden_preventa.idOrden,\r\n                                            orden_preventa.fechaIngreso,                                                              \r\n                                            orden_preventa.idCliente,\r\n                                            orden_preventa.rut,\r\n                                            orden_preventa.digito,\r\n                                            orden_preventa.razonSocial,\r\n                                            orden_preventa.contacto,\r\n                                            orden_preventa.email,\r\n                                            orden_preventa.fono,\r\n                                            orden_preventa.email2,\r\n                                            orden_preventa.fono2,\r\n                                            orden_preventa.email3,\r\n                                            orden_preventa.fono3,\r\n                                            orden_preventa.observacion,                                                              \r\n                                            orden_preventa.idVendedor,\r\n                                            orden_preventa.vendedor,\r\n                                            orden_preventa.estado, \r\n                                            orden_preventa.fechaAtencion,                                            \r\n                                            preclientes.codigo,\r\n                                            preclientes.comuna,\r\n                                            preclientes.ciudad,                                           \r\n                                            preclientes.nombreFantasia,\r\n                                            preclientes.giro,\r\n                                            preclientes.direccion,\r\n                                            preclientes.observaciones,\r\n                                            preclientes.fechaCreacion,                                             \r\n                                            preclientes.diasPlazo,\r\n                                            preclientes.listaPrecio, \r\n                                            preclientes.creditoAprobado, \r\n                                            preclientes.estado,\r\n                                            preclientes.idMedioPago, \r\n                                            preclientes.medioPago, \r\n                                            preclientes.motivoBloqueo, \r\n                                            preclientes.inicioSoporte,\r\n                                            preclientes.mesesSoporte,\r\n                                            preclientes.tipoCliente, \r\n                                            preclientes.procedencia,\r\n                                            preclientes.activo\r\n                                FROM orden_preventa INNER JOIN preclientes \r\n                                ON orden_preventa.idCliente = preclientes.codigo \r\n                                WHERE " + filtro + " ORDER BY orden_preventa.idOrden";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
