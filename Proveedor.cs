 
// Type: Aptusoft.Proveedor
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Proveedor
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaProveedor(ClienteVO cliVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO proveedores (comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra) \r\n                                                   VALUES(@Comuna, @Ciudad, @Razon, @Rut, @Dig, @Fantasia, @Giro, @Direccion, @Telefono, @Fax, @Contacto, @Email, @EmailContacto, @FonoContacto, @Observaciones, @FechaCreacion, @UltimaCompra)";
        command.Parameters.AddWithValue("@Comuna", (object) cliVO.Comuna);
        command.Parameters.AddWithValue("@Ciudad", (object) cliVO.Ciudad);
        command.Parameters.AddWithValue("@Razon", (object) cliVO.RazonSocial);
        command.Parameters.AddWithValue("@Rut", (object) cliVO.Rut);
        command.Parameters.AddWithValue("@Dig", (object) cliVO.Digito);
        command.Parameters.AddWithValue("@Fantasia", (object) cliVO.NomFantasia);
        command.Parameters.AddWithValue("@Giro", (object) cliVO.Giro);
        command.Parameters.AddWithValue("@Direccion", (object) cliVO.Direccion);
        command.Parameters.AddWithValue("@Telefono", (object) cliVO.Telefono);
        command.Parameters.AddWithValue("@Fax", (object) cliVO.Fax);
        command.Parameters.AddWithValue("@Contacto", (object) cliVO.Contacto);
        command.Parameters.AddWithValue("@Email", (object) cliVO.Email);
        command.Parameters.AddWithValue("@EmailContacto", (object) cliVO.EmailContacto);
        command.Parameters.AddWithValue("@FonoContacto", (object) cliVO.FonoContacto);
        command.Parameters.AddWithValue("@Observaciones", (object) cliVO.Observaciones);
        command.Parameters.AddWithValue("@FechaCreacion", (object) cliVO.FechaCreacion);
        command.Parameters.AddWithValue("@UltimaCompra", (object) cliVO.FechaUltimaCompra);
        ((DbCommand) command).ExecuteNonQuery();
        return "Proveedor Ingresado Correctamente";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public string modificaProveedor(ClienteVO cliVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE proveedores SET comuna=@Comuna, ciudad=@Ciudad, razonSocial=@Razon, nombreFantasia=@Fantasia, \r\n                                        giro=@Giro, direccion=@Direccion, telefono=@Telefono, fax=@Fax, contacto=@Contacto, email=@Email,\r\n                                        emailContacto=@EmailContacto, fonoContacto=@FonoContacto, observaciones=@Observaciones,\r\n                                        fechaCreacion=@FechaCreacion, fechaUltimaCompra=@UltimaCompra\r\n                                      WHERE codigo=@Codigo";
        command.Parameters.AddWithValue("@Codigo", (object) cliVO.Codigo);
        command.Parameters.AddWithValue("@Comuna", (object) cliVO.Comuna);
        command.Parameters.AddWithValue("@Ciudad", (object) cliVO.Ciudad);
        command.Parameters.AddWithValue("@Razon", (object) cliVO.RazonSocial);
        command.Parameters.AddWithValue("@Rut", (object) cliVO.Rut);
        command.Parameters.AddWithValue("@Dig", (object) cliVO.Digito);
        command.Parameters.AddWithValue("@Fantasia", (object) cliVO.NomFantasia);
        command.Parameters.AddWithValue("@Giro", (object) cliVO.Giro);
        command.Parameters.AddWithValue("@Direccion", (object) cliVO.Direccion);
        command.Parameters.AddWithValue("@Telefono", (object) cliVO.Telefono);
        command.Parameters.AddWithValue("@Fax", (object) cliVO.Fax);
        command.Parameters.AddWithValue("@Contacto", (object) cliVO.Contacto);
        command.Parameters.AddWithValue("@Email", (object) cliVO.Email);
        command.Parameters.AddWithValue("@EmailContacto", (object) cliVO.EmailContacto);
        command.Parameters.AddWithValue("@FonoContacto", (object) cliVO.FonoContacto);
        command.Parameters.AddWithValue("@Observaciones", (object) cliVO.Observaciones);
        command.Parameters.AddWithValue("@FechaCreacion", (object) cliVO.FechaCreacion);
        command.Parameters.AddWithValue("@UltimaCompra", (object) cliVO.FechaUltimaCompra);
        ((DbCommand) command).ExecuteNonQuery();
        return "Proveedor Modificado Correctamente";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public string eliminaProveedor(int cod)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM proveedores WHERE Codigo = @Codigo";
        command.Parameters.AddWithValue("@Codigo", (object) cod);
        ((DbCommand) command).ExecuteNonQuery();
        return "Proveedor Eliminado";
      }
      catch (Exception ex)
      {
        return "Error al Eliminar ..." + ex.ToString();
      }
    }

    public ArrayList buscaRutProveedor(string _rut)
    {
      ArrayList arrayList = new ArrayList();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra FROM proveedores WHERE rut = @rut";
      command.Parameters.AddWithValue("@Rut", (object) _rut);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        arrayList.Add((object) new ClienteVO()
        {
          Codigo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigo"]),
          Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString(),
          Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString(),
          Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          NomFantasia = ((DbDataReader) mySqlDataReader)["nombreFantasia"].ToString(),
          Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString(),
          Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString(),
          Telefono = ((DbDataReader) mySqlDataReader)["telefono"].ToString(),
          Fax = ((DbDataReader) mySqlDataReader)["fax"].ToString(),
          Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString(),
          Email = ((DbDataReader) mySqlDataReader)["email"].ToString(),
          EmailContacto = ((DbDataReader) mySqlDataReader)["emailContacto"].ToString(),
          FonoContacto = ((DbDataReader) mySqlDataReader)["fonoContacto"].ToString(),
          Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString(),
          FechaCreacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCreacion"].ToString()),
          FechaUltimaCompra = ((DbDataReader) mySqlDataReader)["fechaUltimaCompra"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return arrayList;
    }

    public ClienteVO buscaCodigoProveedor(int _cod)
    {
      ClienteVO clienteVo = new ClienteVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra FROM proveedores WHERE codigo = @Cod";
      command.Parameters.AddWithValue("@Cod", (object) _cod);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        clienteVo.Codigo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigo"]);
        clienteVo.Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString();
        clienteVo.Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString();
        clienteVo.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        clienteVo.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        clienteVo.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        clienteVo.NomFantasia = ((DbDataReader) mySqlDataReader)["nombreFantasia"].ToString();
        clienteVo.Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString();
        clienteVo.Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString();
        clienteVo.Telefono = ((DbDataReader) mySqlDataReader)["telefono"].ToString();
        clienteVo.Fax = ((DbDataReader) mySqlDataReader)["fax"].ToString();
        clienteVo.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        clienteVo.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        clienteVo.EmailContacto = ((DbDataReader) mySqlDataReader)["emailContacto"].ToString();
        clienteVo.FonoContacto = ((DbDataReader) mySqlDataReader)["fonoContacto"].ToString();
        clienteVo.Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString();
        clienteVo.FechaCreacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCreacion"].ToString());
        clienteVo.FechaUltimaCompra = ((DbDataReader) mySqlDataReader)["fechaUltimaCompra"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return clienteVo;
    }

    public List<ClienteVO> buscaProveedorDato(int _dato, string _busca)
    {
      string str = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra FROM proveedores";
      if (_dato == 1)
        str += " WHERE razonSocial LIKE @busca";
      if (_dato == 2)
        str += " WHERE nombreFantasia LIKE @busca";
      if (_dato == 3)
        str += " WHERE direccion LIKE @busca";
      if (_dato == 4)
        str += " WHERE ciudad LIKE @busca";
      if (_dato == 5)
        str += " WHERE comuna LIKE @busca";
      if (_dato == 6)
        str += " WHERE telefono LIKE @busca OR fonoContacto LIKE @busca";
      if (_dato == 7)
        str += " WHERE contacto LIKE @busca";
      if (_dato == 8)
        str += " WHERE giro LIKE @busca";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      command.Parameters.AddWithValue("@busca", (object) ("%" + _busca + "%"));
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<ClienteVO> list = new List<ClienteVO>();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ClienteVO()
        {
          Codigo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigo"]),
          Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString(),
          Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString(),
          Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          NomFantasia = ((DbDataReader) mySqlDataReader)["nombreFantasia"].ToString(),
          Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString(),
          Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString(),
          Telefono = ((DbDataReader) mySqlDataReader)["telefono"].ToString(),
          Fax = ((DbDataReader) mySqlDataReader)["fax"].ToString(),
          Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString(),
          Email = ((DbDataReader) mySqlDataReader)["email"].ToString(),
          EmailContacto = ((DbDataReader) mySqlDataReader)["emailContacto"].ToString(),
          FonoContacto = ((DbDataReader) mySqlDataReader)["fonoContacto"].ToString(),
          Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString(),
          FechaCreacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCreacion"].ToString()),
          FechaUltimaCompra = ((DbDataReader) mySqlDataReader)["fechaUltimaCompra"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public DateTime fechaUltimaCompra(int idProveedor)
    {
      DateTime dateTime = new DateTime();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(fechaEmision) from compras WHERE idProveedor=@idPro";
      command.Parameters.AddWithValue("@idPro", (object) idProveedor);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        if (((DbDataReader) mySqlDataReader)[0].ToString().Length > 0)
          dateTime = Convert.ToDateTime(((DbDataReader) mySqlDataReader)[0].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      return dateTime;
    }

    public DataTable listadoProveedoresInforme()
    {
      string str = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra FROM proveedores                             \r\n                            ORDER BY codigo";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
