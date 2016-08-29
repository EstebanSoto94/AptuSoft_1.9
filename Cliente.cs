 
// Type: Aptusoft.Cliente
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class Cliente
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaCliente(ClienteVO cliVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO clientes (comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio, creditoAprobado, estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte, rubro) \r\n                                                   VALUES(@Comuna, @Ciudad, @Razon, @Rut, @Dig, @Fantasia, @Giro, @Direccion, @Telefono, @Fax, @Contacto, @Email, @EmailContacto, @FonoContacto, @Observaciones, @FechaCreacion, @UltimaCompra, @DiasPlazo, @ListaPrecio, @creditoAprobado, @estado, @idMedioPago, @medioPago, @motivoBloqueo, @inicioSoporte, @mesesSoporte, @rubro)";
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
        command.Parameters.AddWithValue("@DiasPlazo", (object) cliVO.DiasPlazo);
        command.Parameters.AddWithValue("@ListaPrecio", (object) cliVO.ListaPrecio);
        command.Parameters.AddWithValue("@creditoAprobado", (object) cliVO.CreditoAprobado);
        command.Parameters.AddWithValue("@estado", (object) cliVO.Estado);
        command.Parameters.AddWithValue("@idMedioPago", (object) cliVO.IdMedioPago);
        command.Parameters.AddWithValue("@medioPago", (object) cliVO.MedioPago);
        command.Parameters.AddWithValue("@motivoBloqueo", (object) cliVO.MotivoBloqueo);
        command.Parameters.AddWithValue("@inicioSoporte", (object) cliVO.InicioSoporte);
        command.Parameters.AddWithValue("@mesesSoporte", (object) cliVO.MesesSoporte);
        command.Parameters.AddWithValue("@rubro", (object) cliVO.NombreRubro);
        ((DbCommand) command).ExecuteNonQuery();
        return "Cliente Ingresado Correctamente";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public string modificaCliente(ClienteVO cliVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE clientes SET comuna=@Comuna, ciudad=@Ciudad, razonSocial=@Razon, nombreFantasia=@Fantasia, \r\n                                        giro=@Giro, direccion=@Direccion, telefono=@Telefono, fax=@Fax, contacto=@Contacto, email=@Email,\r\n                                        emailContacto=@EmailContacto, fonoContacto=@FonoContacto, observaciones=@Observaciones,\r\n                                        fechaCreacion=@FechaCreacion, fechaUltimaCompra=@UltimaCompra, diasPlazo=@DiasPlazo, listaPrecio=@ListaPrecio,\r\n                                        creditoAprobado=@creditoAprobado, estado=@estado, idMedioPago=@idMedioPago, medioPago=@medioPago, \r\n                                        motivoBloqueo=@motivoBloqueo, inicioSoporte=@inicioSoporte, mesesSoporte=@mesesSoporte, rubro=@rubro\r\n                                      WHERE codigo=@Codigo";
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
        command.Parameters.AddWithValue("@DiasPlazo", (object) cliVO.DiasPlazo);
        command.Parameters.AddWithValue("@ListaPrecio", (object) cliVO.ListaPrecio);
        command.Parameters.AddWithValue("@creditoAprobado", (object) cliVO.CreditoAprobado);
        command.Parameters.AddWithValue("@estado", (object) cliVO.Estado);
        command.Parameters.AddWithValue("@idMedioPago", (object) cliVO.IdMedioPago);
        command.Parameters.AddWithValue("@medioPago", (object) cliVO.MedioPago);
        command.Parameters.AddWithValue("@motivoBloqueo", (object) cliVO.MotivoBloqueo);
        command.Parameters.AddWithValue("@inicioSoporte", (object) cliVO.InicioSoporte);
        command.Parameters.AddWithValue("@mesesSoporte", (object) cliVO.MesesSoporte);
        command.Parameters.AddWithValue("@rubro", (object) cliVO.NombreRubro);
        ((DbCommand) command).ExecuteNonQuery();
        return "Cliente Modificado Correctamente";
      }
      catch (Exception ex)
      {
        return "Error al Modificar ..." + ex.ToString();
      }
    }

    public string eliminaCliente(int cod)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM clientes WHERE Codigo = @Codigo";
        command.Parameters.AddWithValue("@Codigo", (object) cod);
        ((DbCommand) command).ExecuteNonQuery();
        return "Cliente Eliminado";
      }
      catch (Exception ex)
      {
        return "Error al Eliminar ..." + ex.ToString();
      }
    }

    public ArrayList buscaRutCliente(string _rut)
    {
      ArrayList arrayList = new ArrayList();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio,  creditoAprobado, estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte, rubro FROM clientes WHERE rut = @rut";
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
          FechaUltimaCompra = ((DbDataReader) mySqlDataReader)["fechaUltimaCompra"].ToString(),
          DiasPlazo = ((DbDataReader) mySqlDataReader)["diasPlazo"].ToString(),
          ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"].ToString()),
          CreditoAprobado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["creditoAprobado"]),
          Estado = Convert.ToInt32(((DbDataReader) mySqlDataReader)["estado"].ToString()),
          IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"].ToString()),
          MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString(),
          MotivoBloqueo = ((DbDataReader) mySqlDataReader)["motivoBloqueo"].ToString(),
          InicioSoporte = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["inicioSoporte"].ToString()),
          MesesSoporte = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesSoporte"].ToString()),
          NombreRubro = ((DbDataReader) mySqlDataReader)["rubro"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return arrayList;
    }

    public string buscaEmailCliente(int idCliente)
    {
      string str = "";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT email, emailContacto FROM clientes WHERE codigo = @idCliente";
      command.Parameters.AddWithValue("@idCliente", (object) idCliente);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        str = ((DbDataReader) mySqlDataReader)["email"].ToString();
        if (str.Length == 0)
          str = ((DbDataReader) mySqlDataReader)["emailContacto"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return str;
    }

    public ArrayList buscaFonoCliente(string _fono)
    {
      ArrayList arrayList = new ArrayList();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio,  creditoAprobado, estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte, rubro \r\n                                    FROM clientes \r\n                                    WHERE telefono like @fono OR fonoContacto like @fono";
      command.Parameters.AddWithValue("@fono", (object) ("%" + _fono + "%"));
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
          FechaUltimaCompra = ((DbDataReader) mySqlDataReader)["fechaUltimaCompra"].ToString(),
          DiasPlazo = ((DbDataReader) mySqlDataReader)["diasPlazo"].ToString(),
          ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"].ToString()),
          CreditoAprobado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["creditoAprobado"]),
          Estado = Convert.ToInt32(((DbDataReader) mySqlDataReader)["estado"].ToString()),
          IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"].ToString()),
          MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString(),
          MotivoBloqueo = ((DbDataReader) mySqlDataReader)["motivoBloqueo"].ToString(),
          InicioSoporte = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["inicioSoporte"].ToString()),
          MesesSoporte = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesSoporte"].ToString()),
          NombreRubro = ((DbDataReader) mySqlDataReader)["rubro"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return arrayList;
    }

    public ClienteVO buscaCodigoCliente(int _cod)
    {
      ClienteVO clienteVo = new ClienteVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, \r\n                                    nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, \r\n                                    observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio,  creditoAprobado, \r\n                                    estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte, rubro\r\n                                    FROM clientes WHERE codigo = @Cod";
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
        clienteVo.DiasPlazo = ((DbDataReader) mySqlDataReader)["diasPlazo"].ToString();
        clienteVo.ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"].ToString());
        clienteVo.CreditoAprobado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["creditoAprobado"]);
        clienteVo.Estado = Convert.ToInt32(((DbDataReader) mySqlDataReader)["estado"].ToString());
        clienteVo.IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"].ToString());
        clienteVo.MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString();
        clienteVo.MotivoBloqueo = ((DbDataReader) mySqlDataReader)["motivoBloqueo"].ToString();
        clienteVo.InicioSoporte = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["inicioSoporte"].ToString());
        clienteVo.MesesSoporte = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesSoporte"].ToString());
        clienteVo.NombreRubro = ((DbDataReader) mySqlDataReader)["rubro"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return clienteVo;
    }

    public List<ClienteVO> buscaClienteDato(int _dato, string _busca)
    {
      string str = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio, creditoAprobado, estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte, rubro FROM clientes ";
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
          FechaUltimaCompra = ((DbDataReader) mySqlDataReader)["fechaUltimaCompra"].ToString(),
          DiasPlazo = ((DbDataReader) mySqlDataReader)["diasPlazo"].ToString(),
          ListaPrecio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["listaPrecio"].ToString()),
          CreditoAprobado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["creditoAprobado"]),
          Estado = Convert.ToInt32(((DbDataReader) mySqlDataReader)["estado"].ToString()),
          IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"].ToString()),
          MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString(),
          MotivoBloqueo = ((DbDataReader) mySqlDataReader)["motivoBloqueo"].ToString(),
          InicioSoporte = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["inicioSoporte"].ToString()),
          MesesSoporte = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesSoporte"].ToString()),
          NombreRubro = ((DbDataReader) mySqlDataReader)["rubro"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public DateTime fechaUltimaCompra(int idCliente)
    {
      DateTime dateTime1= new DateTime();
      DateTime dateTime2 = new DateTime();
      DateTime dateTime3 = new DateTime();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(fechaEmision) from facturas WHERE idCliente=@idCli";
      command.Parameters.AddWithValue("@idCli", (object) idCliente);
      MySqlDataReader mySqlDataReader1 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader1).Read())
      {
        if (((DbDataReader) mySqlDataReader1)[0].ToString().Length > 0)
          dateTime1 = Convert.ToDateTime(((DbDataReader) mySqlDataReader1)[0].ToString());
      }
      ((DbDataReader) mySqlDataReader1).Close();
      ((DbCommand) command).CommandText = "SELECT MAX(fechaEmision) from boletas WHERE idCliente=@idCli2";
      command.Parameters.AddWithValue("@idCli2", (object) idCliente);
      MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader2).Read())
      {
        if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          dateTime2 = Convert.ToDateTime(((DbDataReader) mySqlDataReader2)[0].ToString());
      }
      ((DbDataReader) mySqlDataReader2).Close();
      return !(dateTime1 >= dateTime2) ? dateTime2 : dateTime1;
    }

    public DataTable listadoClientesInforme()
    {
      string str = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio, creditoAprobado, estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte, rubro FROM clientes                             \r\n                            ORDER BY codigo";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public List<Venta> ventasCliente(string filtro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT 'BOLETA' as DocumentoVenta, idBoleta, \r\n                                        folio,razonSocial,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        estadoPago,                                        \r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente                                                                                                                               \r\n                            FROM boletas                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' ORDER BY folio";
      MySqlDataReader mySqlDataReader1 = command.ExecuteReader();
      List<Venta> list = new List<Venta>();
      Venta venta = new Venta();
      while (((DbDataReader) mySqlDataReader1).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader1)["DocumentoVenta"].ToString(),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader1)["idBoleta"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader1)["folio"]),
          RazonSocial = ((DbDataReader) mySqlDataReader1)["razonSocial"].ToString(),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader1)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["total"]),
          EstadoPago = ((DbDataReader) mySqlDataReader1)["estadoPago"].ToString(),
          TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["totalPagado"]),
          TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["totalDocumentado"]),
          TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["totalPendiente"])
        });
      ((DbDataReader) mySqlDataReader1).Close();
      ((DbCommand) command).CommandText = "SELECT 'FACTURA' as DocumentoVenta, idFactura, \r\n                                        folio,razonSocial,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        estadoPago,                                        \r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente                                                                                                                               \r\n                            FROM facturas                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' ORDER BY folio";
      MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader2).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader2)["DocumentoVenta"].ToString(),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader2)["idFactura"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader2)["folio"]),
          RazonSocial = ((DbDataReader) mySqlDataReader2)["razonSocial"].ToString(),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader2)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["total"]),
          EstadoPago = ((DbDataReader) mySqlDataReader2)["estadoPago"].ToString(),
          TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["totalPagado"]),
          TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["totalDocumentado"]),
          TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["totalPendiente"])
        });
      ((DbDataReader) mySqlDataReader2).Close();
      ((DbCommand) command).CommandText = "SELECT 'FACTURA_ELECTRONICA' as DocumentoVenta, idFactura,\r\n                                        folio,razonSocial,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        estadoPago,                                        \r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente                                                                                                                               \r\n                            FROM electronica_factura                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' ORDER BY folio";
      MySqlDataReader mySqlDataReader3 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader3).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader3)["DocumentoVenta"].ToString(),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader3)["idFactura"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader3)["folio"]),
          RazonSocial = ((DbDataReader) mySqlDataReader3)["razonSocial"].ToString(),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader3)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader3)["total"]),
          EstadoPago = ((DbDataReader) mySqlDataReader3)["estadoPago"].ToString(),
          TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader3)["totalPagado"]),
          TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader3)["totalDocumentado"]),
          TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader3)["totalPendiente"])
        });
      ((DbDataReader) mySqlDataReader3).Close();
      ((DbCommand) command).CommandText = "SELECT 'FACTURA_EXENTA_ELECTRONICA' as DocumentoVenta, idFactura, \r\n                                        folio,\r\n                                        razonSocial,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        estadoPago,                                        \r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente                                                                                                                               \r\n                            FROM electronica_factura_exenta                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' ORDER BY folio";
      MySqlDataReader mySqlDataReader4 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader4).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader4)["DocumentoVenta"].ToString(),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader4)["idFactura"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader4)["folio"]),
          RazonSocial = ((DbDataReader) mySqlDataReader4)["razonSocial"].ToString(),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader4)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader4)["total"]),
          EstadoPago = ((DbDataReader) mySqlDataReader4)["estadoPago"].ToString(),
          TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader4)["totalPagado"]),
          TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader4)["totalDocumentado"]),
          TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader4)["totalPendiente"])
        });
      ((DbDataReader) mySqlDataReader4).Close();
      ((DbCommand) command).CommandText = "SELECT 'NOTA_DEBITO_ELECTRONICA' as DocumentoVenta, idNotaDebito, \r\n                                        folio,razonSocial,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        estadoPago,                                        \r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente                                                                                                                               \r\n                            FROM electronica_nota_debito                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' AND total > 0 ORDER BY folio";
      MySqlDataReader mySqlDataReader5 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader5).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader5)["DocumentoVenta"].ToString(),
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader5)["idNotaDebito"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader5)["folio"]),
          RazonSocial = ((DbDataReader) mySqlDataReader5)["razonSocial"].ToString(),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader5)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader5)["total"]),
          EstadoPago = ((DbDataReader) mySqlDataReader5)["estadoPago"].ToString(),
          TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader5)["totalPagado"]),
          TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader5)["totalDocumentado"]),
          TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader5)["totalPendiente"])
        });
      ((DbDataReader) mySqlDataReader5).Close();
      return list;
    }

    public List<Venta> notaCreditoCliente(string filtro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT 'NOTA DE CREDITO' as DocumentoVenta, \r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        montoUsado,\r\n                                        (total-montoUsado) AS 'montoDisponible'                                                                                                                               \r\n                            FROM notacredito                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' AND idTipo=3 AND total > montoUsado ORDER BY fechaEmision DESC";
      MySqlDataReader mySqlDataReader1 = command.ExecuteReader();
      List<Venta> list = new List<Venta>();
      Venta venta = new Venta();
      while (((DbDataReader) mySqlDataReader1).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader1)["DocumentoVenta"].ToString(),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader1)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader1)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["total"]),
          MontoUsado = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["montoUsado"].ToString()),
          MontoDisponible = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["montoDisponible"])
        });
      ((DbDataReader) mySqlDataReader1).Close();
      ((DbCommand) command).CommandText = "SELECT 'N. CREDITO ELECTRONICA' as DocumentoVenta, \r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        montoUsado,\r\n                                        (total-montoUsado) AS 'montoDisponible'                                                                                                                               \r\n                            FROM electronica_nota_credito                             \r\n                                        WHERE " + filtro + " \r\n                                        AND estadoDocumento='EMITIDA'\r\n                                        AND ((tipoAccion1=1 OR tipoAccion1=3) OR\r\n                                        (tipoAccion2=1 OR tipoAccion2=3) OR\r\n                                        (tipoAccion3=1 OR tipoAccion3=3) OR\r\n                                        (tipoAccion4=1 OR tipoAccion4=3) OR\r\n                                        (tipoAccion5=1 OR tipoAccion5=3)) \r\n                                        AND total > montoUsado \r\n                                        ORDER BY fechaEmision DESC";
      MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader2).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader2)["DocumentoVenta"].ToString(),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader2)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader2)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["total"]),
          MontoUsado = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["montoUsado"].ToString()),
          MontoDisponible = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["montoDisponible"])
        });
      ((DbDataReader) mySqlDataReader2).Close();
      return list;
    }

    public List<DatosVentaVO> productosCliente(int idCliente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT\r\n                                            f.fechaEmision,\r\n                                            f.folio,\r\n                                            d.codigo,\r\n                                            d.descripcion,\r\n                                            d.cantidad,\r\n                                            d.valorVenta\r\n                                    FROM detallefactura d INNER JOIN facturas f \r\n                                    ON f.idFactura=d.idFacturaLinea and f.folio=d.folioFactura\r\n                                    WHERE f.idCliente=@ID ORDER BY f.folio DESC";
      command.Parameters.AddWithValue("@ID", (object) idCliente);
      MySqlDataReader mySqlDataReader1 = command.ExecuteReader();
      List<DatosVentaVO> list = new List<DatosVentaVO>();
      DatosVentaVO datosVentaVo = new DatosVentaVO();
      while (((DbDataReader) mySqlDataReader1).Read())
        list.Add(new DatosVentaVO()
        {
          TipoDocumentoCompra = "FACTURA",
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader1)["fechaEmision"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader1)["folio"]),
          Codigo = ((DbDataReader) mySqlDataReader1)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader1)["descripcion"].ToString(),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["cantidad"]),
          ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["valorVenta"])
        });
      ((DbDataReader) mySqlDataReader1).Close();
      ((DbCommand) command).CommandText = "SELECT\r\n                                            f.fechaEmision,\r\n                                            f.folio,\r\n                                            d.codigo,\r\n                                            d.descripcion,\r\n                                            d.cantidad,\r\n                                            d.valorVenta\r\n                                    FROM electronica_detalle_factura d INNER JOIN electronica_factura f \r\n                                    ON f.idFactura=d.idFacturaLinea and f.folio=d.folioFactura\r\n                                    WHERE f.idCliente=@ID2 ORDER BY f.folio DESC";
      command.Parameters.AddWithValue("@ID2", (object) idCliente);
      MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader2).Read())
        list.Add(new DatosVentaVO()
        {
          TipoDocumentoCompra = "FACTURA ELECTRONICA",
          FechaIngreso = Convert.ToDateTime(((DbDataReader) mySqlDataReader2)["fechaEmision"]),
          FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader2)["folio"]),
          Codigo = ((DbDataReader) mySqlDataReader2)["codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader2)["descripcion"].ToString(),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["cantidad"]),
          ValorVenta = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["valorVenta"])
        });
      ((DbDataReader) mySqlDataReader2).Close();
      return list;
    }

    public List<PagoVentaVO> pagosCliente(int idCliente)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT\r\n                                            p.folioDocumento,\r\n                                            p.tipoDocumento,\r\n                                            p.medioPagoPV,\r\n                                            p.estadoPagoPV,\r\n                                            p.monto,\r\n                                            p.fechaCobro\r\n                                    FROM pagosventas p INNER JOIN facturas f\r\n                                    ON p.folioDocumento = f.folio AND p.tipoDocumento='FACTURA' \r\n                                    WHERE f.idCliente=@ID ORDER BY p.fechaCobro DESC";
      command.Parameters.AddWithValue("@ID", (object) idCliente);
      MySqlDataReader mySqlDataReader1 = command.ExecuteReader();
      List<PagoVentaVO> list = new List<PagoVentaVO>();
      PagoVentaVO pagoVentaVo = new PagoVentaVO();
      while (((DbDataReader) mySqlDataReader1).Read())
        list.Add(new PagoVentaVO()
        {
          FolioDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader1)["folioDocumento"]),
          TipoDocumento = ((DbDataReader) mySqlDataReader1)["tipoDocumento"].ToString(),
          FormaPago = ((DbDataReader) mySqlDataReader1)["medioPagoPV"].ToString(),
          Estado = ((DbDataReader) mySqlDataReader1)["estadoPagoPV"].ToString(),
          Monto = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["monto"]),
          FechaCobro = Convert.ToDateTime(((DbDataReader) mySqlDataReader1)["fechaCobro"])
        });
      ((DbDataReader) mySqlDataReader1).Close();
      ((DbCommand) command).CommandText = "SELECT\r\n                                            p.folioDocumento,\r\n                                            p.tipoDocumento,\r\n                                            p.medioPagoPV,\r\n                                            p.estadoPagoPV,\r\n                                            p.monto,\r\n                                            p.fechaCobro\r\n                                    FROM pagosventas p INNER JOIN electronica_factura f\r\n                                    ON p.folioDocumento = f.folio AND p.tipoDocumento='FACTURA_ELECTRONICA' \r\n                                    WHERE f.idCliente=@ID2 ORDER BY p.fechaCobro DESC";
      command.Parameters.AddWithValue("@ID2", (object) idCliente);
      MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader2).Read())
        list.Add(new PagoVentaVO()
        {
          FolioDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader2)["folioDocumento"]),
          TipoDocumento = ((DbDataReader) mySqlDataReader2)["tipoDocumento"].ToString(),
          FormaPago = ((DbDataReader) mySqlDataReader2)["medioPagoPV"].ToString(),
          Estado = ((DbDataReader) mySqlDataReader2)["estadoPagoPV"].ToString(),
          Monto = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["monto"]),
          FechaCobro = Convert.ToDateTime(((DbDataReader) mySqlDataReader2)["fechaCobro"])
        });
      ((DbDataReader) mySqlDataReader2).Close();
      return list;
    }
  }
}
