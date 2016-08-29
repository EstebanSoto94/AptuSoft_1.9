 
// Type: Aptusoft.PreCliente
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class PreCliente
  {
    private Conexion conexion = Conexion.getConecta();

    public string agregaCliente(ClienteVO cliVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "INSERT INTO preclientes (\r\n                                                                    comuna,\r\n                                                                    ciudad,\r\n                                                                    razonSocial,\r\n                                                                    rut,\r\n                                                                    digito,\r\n                                                                    nombreFantasia,\r\n                                                                    giro,\r\n                                                                    direccion, \r\n                                                                    telefono,\r\n                                                                    fax,\r\n                                                                    contacto,\r\n                                                                    email,\r\n                                                                    emailContacto,\r\n                                                                    fonoContacto, \r\n                                                                    observaciones,\r\n                                                                    fechaCreacion, \r\n                                                                    fechaUltimaCompra, \r\n                                                                    diasPlazo,\r\n                                                                    listaPrecio, \r\n                                                                    creditoAprobado, \r\n                                                                    estado,\r\n                                                                    idMedioPago, \r\n                                                                    medioPago, \r\n                                                                    motivoBloqueo, \r\n                                                                    inicioSoporte,\r\n                                                                    mesesSoporte,\r\n                                                                    tipoCliente,\r\n                                                                    telefono2,\r\n                                                                    telefono3,\r\n                                                                    email2,\r\n                                                                    email3,\r\n                                                                    vendedor,\r\n                                                                    procedencia,\r\n                                                                    activo\r\n                                                                    ) \r\n                                                                    VALUES(\r\n                                                                    @Comuna,\r\n                                                                    @Ciudad,\r\n                                                                    @Razon,\r\n                                                                    @Rut, \r\n                                                                    @Dig,\r\n                                                                    @Fantasia, \r\n                                                                    @Giro, \r\n                                                                    @Direccion,\r\n                                                                    @Telefono, \r\n                                                                    @Fax, \r\n                                                                    @Contacto, \r\n                                                                    @Email, \r\n                                                                    @EmailContacto,\r\n                                                                    @FonoContacto, \r\n                                                                    @Observaciones,\r\n                                                                    @FechaCreacion,\r\n                                                                    @UltimaCompra,\r\n                                                                    @DiasPlazo,\r\n                                                                    @ListaPrecio,\r\n                                                                    @creditoAprobado, \r\n                                                                    @estado, \r\n                                                                    @idMedioPago, \r\n                                                                    @medioPago, \r\n                                                                    @motivoBloqueo, \r\n                                                                    @inicioSoporte, \r\n                                                                    @mesesSoporte,\r\n                                                                    @tipoCliente,\r\n                                                                    @telefono2,\r\n                                                                    @telefono3,\r\n                                                                    @email2,\r\n                                                                    @email3,\r\n                                                                    @vendedor,\r\n                                                                    @procedencia,\r\n                                                                    @activo\r\n                                                                    )";
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
        command.Parameters.AddWithValue("@DiasPlazo", (object) "0");
        command.Parameters.AddWithValue("@ListaPrecio", (object) cliVO.ListaPrecio);
        command.Parameters.AddWithValue("@creditoAprobado", (object) cliVO.CreditoAprobado);
        command.Parameters.AddWithValue("@estado", (object) cliVO.Estado);
        command.Parameters.AddWithValue("@idMedioPago", (object) cliVO.IdMedioPago);
        command.Parameters.AddWithValue("@medioPago", (object) cliVO.MedioPago);
        command.Parameters.AddWithValue("@motivoBloqueo", (object) cliVO.MotivoBloqueo);
        command.Parameters.AddWithValue("@inicioSoporte", (object) cliVO.InicioSoporte);
        command.Parameters.AddWithValue("@mesesSoporte", (object) cliVO.MesesSoporte);
        command.Parameters.AddWithValue("@tipoCliente", (object) cliVO.TipoCliente);
        command.Parameters.AddWithValue("@telefono2", (object) cliVO.Telefono2);
        command.Parameters.AddWithValue("@telefono3", (object) cliVO.Telefono3);
        command.Parameters.AddWithValue("@email2", (object) cliVO.Email2);
        command.Parameters.AddWithValue("@email3", (object) cliVO.Email3);
        command.Parameters.AddWithValue("@vendedor", (object) cliVO.Vendedor);
        command.Parameters.AddWithValue("@procedencia", (object) cliVO.Procedencia);
        command.Parameters.AddWithValue("@activo", (cliVO.Activo ? 1 : 0));
        ((DbCommand) command).ExecuteNonQuery();
        return "Cliente Ingresado Correctamente";
      }
      catch (Exception ex)
      {
        return "Error al Guardar ..." + ex.ToString();
      }
    }

    public void modificaCliente(ClienteVO cliVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE preclientes SET \r\n                                                                    comuna = @comuna,\r\n                                                                    ciudad = @ciudad,\r\n                                                                    razonSocial = @RazonSocial,\r\n                                                                    rut = @rut,\r\n                                                                    digito = @digito,\r\n                                                                    nombreFantasia = @nombreFantasia,\r\n                                                                    giro = @giro,\r\n                                                                    direccion = @direccion, \r\n                                                                    telefono = @telefono,\r\n                                                                    fax = @fax,\r\n                                                                    contacto = @contacto,\r\n                                                                    email = @email,                                                   \r\n                                                                    tipoCliente = @tipoCliente,\r\n                                                                    telefono2 = @telefono2,\r\n                                                                    telefono3 = @telefono3,\r\n                                                                    email2 = @email2,\r\n                                                                    email3 = @email3,\r\n                                                                    vendedor = @vendedor,\r\n                                                                    procedencia = @procedencia,\r\n                                                                    activo = @activo\r\n                                      WHERE codigo=@Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) cliVO.Codigo);
      command.Parameters.AddWithValue("@Comuna", (object) cliVO.Comuna);
      command.Parameters.AddWithValue("@Ciudad", (object) cliVO.Ciudad);
      command.Parameters.AddWithValue("@RazonSocial", (object) cliVO.RazonSocial);
      command.Parameters.AddWithValue("@Rut", (object) cliVO.Rut);
      command.Parameters.AddWithValue("@digito", (object) cliVO.Digito);
      command.Parameters.AddWithValue("@nombreFantasia", (object) cliVO.NomFantasia);
      command.Parameters.AddWithValue("@Giro", (object) cliVO.Giro);
      command.Parameters.AddWithValue("@Direccion", (object) cliVO.Direccion);
      command.Parameters.AddWithValue("@Telefono", (object) cliVO.Telefono);
      command.Parameters.AddWithValue("@Fax", (object) cliVO.Fax);
      command.Parameters.AddWithValue("@Contacto", (object) cliVO.Contacto);
      command.Parameters.AddWithValue("@Email", (object) cliVO.Email);
      command.Parameters.AddWithValue("@tipoCliente", (object) cliVO.TipoCliente);
      command.Parameters.AddWithValue("@telefono2", (object) cliVO.Telefono2);
      command.Parameters.AddWithValue("@telefono3", (object) cliVO.Telefono3);
      command.Parameters.AddWithValue("@email2", (object) cliVO.Email2);
      command.Parameters.AddWithValue("@email3", (object) cliVO.Email3);
      command.Parameters.AddWithValue("@vendedor", (object) cliVO.Vendedor);
      command.Parameters.AddWithValue("@procedencia", (object) cliVO.Procedencia);
      command.Parameters.AddWithValue("@activo", (cliVO.Activo ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void desactivaCliente(int cod)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE preclientes SET activo = 1\r\n                                      WHERE codigo=@Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) cod);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public string eliminaCliente(int cod)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "DELETE FROM preclientes WHERE Codigo = @Codigo";
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
      ((DbCommand) command).CommandText = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio,  creditoAprobado, estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte FROM preclientes WHERE rut = @rut";
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
          MesesSoporte = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesSoporte"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return arrayList;
    }

    public ClienteVO buscaCodigoCliente(int _cod)
    {
      ClienteVO clienteVo = new ClienteVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio,  creditoAprobado, estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte,  tipoCliente,\r\n                                                                    telefono2,\r\n                                                                    telefono3,\r\n                                                                    email2,\r\n                                                                    email3,\r\n                                                                    vendedor,\r\n                                                                    procedencia,\r\n                                                                    activo FROM preclientes WHERE codigo = @Cod";
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
        clienteVo.Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString();
        clienteVo.Telefono2 = ((DbDataReader) mySqlDataReader)["telefono2"].ToString();
        clienteVo.Telefono3 = ((DbDataReader) mySqlDataReader)["telefono3"].ToString();
        clienteVo.Email2 = ((DbDataReader) mySqlDataReader)["email2"].ToString();
        clienteVo.Email3 = ((DbDataReader) mySqlDataReader)["email3"].ToString();
        clienteVo.Procedencia = ((DbDataReader) mySqlDataReader)["procedencia"].ToString();
        clienteVo.TipoCliente = ((DbDataReader) mySqlDataReader)["tipoCliente"].ToString();
        clienteVo.Activo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["activo"]);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return clienteVo;
    }

    public List<ClienteVO> buscaClienteDato(int _dato, string _busca)
    {
      string str = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, vendedor FROM preclientes ";
      if (_dato == 1)
        str += " WHERE razonSocial LIKE @busca LIMIT 500";
      if (_dato == 2)
        str += " WHERE nombreFantasia LIKE @busca LIMIT 500";
      if (_dato == 3)
        str += " WHERE direccion LIKE @busca LIMIT 500";
      if (_dato == 4)
        str += " WHERE ciudad LIKE @busca LIMIT 500";
      if (_dato == 5)
        str += " WHERE comuna LIKE @busca LIMIT 500";
      if (_dato == 6)
        str += " WHERE telefono LIKE @busca OR fonoContacto LIKE @busca LIMIT 500";
      if (_dato == 7)
        str += " WHERE contacto LIKE @busca LIMIT 500";
      if (_dato == 8)
        str += " WHERE giro LIKE @busca LIMIT 500";
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
          Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString()
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
      string str = "SELECT codigo, comuna, ciudad, razonSocial, rut, digito, nombreFantasia, giro, direccion, telefono, fax, contacto, email, emailContacto, fonoContacto, observaciones, fechaCreacion, fechaUltimaCompra, diasPlazo, listaPrecio, creditoAprobado, estado, idMedioPago, medioPago, motivoBloqueo, inicioSoporte, mesesSoporte FROM preclientes                             \r\n                            ORDER BY codigo";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public List<Venta> ventasCliente(string filtro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT 'BOLETA' as DocumentoVenta, \r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        estadoPago,                                        \r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente                                                                                                                               \r\n                            FROM boletas                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' ORDER BY folio";
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
          EstadoPago = ((DbDataReader) mySqlDataReader1)["estadoPago"].ToString(),
          TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["totalPagado"]),
          TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["totalDocumentado"]),
          TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)["totalPendiente"])
        });
      ((DbDataReader) mySqlDataReader1).Close();
      ((DbCommand) command).CommandText = "SELECT 'FACTURA' as DocumentoVenta, \r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        estadoPago,                                        \r\n                                        totalPagado,\r\n                                        totalDocumentado,\r\n                                        totalPendiente                                                                                                                               \r\n                            FROM facturas                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' ORDER BY folio";
      MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader2).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader2)["DocumentoVenta"].ToString(),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader2)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader2)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["total"]),
          EstadoPago = ((DbDataReader) mySqlDataReader2)["estadoPago"].ToString(),
          TotalPagado = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["totalPagado"]),
          TotalDocumentado = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["totalDocumentado"]),
          TotalPendiente = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)["totalPendiente"])
        });
      ((DbDataReader) mySqlDataReader2).Close();
      return list;
    }

    public List<Venta> notaCreditoCliente(string filtro)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT 'NOTA DE CREDITO' as DocumentoVenta, \r\n                                        folio,\r\n                                        fechaEmision,\r\n                                        total,                                        \r\n                                        montoUsado,\r\n                                        (total-montoUsado) AS 'montoDisponible'                                                                                                                               \r\n                            FROM notacredito                             \r\n                            WHERE " + filtro + " AND estadoDocumento='EMITIDA' AND idTipo=3 AND total > montoUsado ORDER BY fechaEmision DESC";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<Venta> list = new List<Venta>();
      Venta venta = new Venta();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new Venta()
        {
          DocumentoVenta = ((DbDataReader) mySqlDataReader)["DocumentoVenta"].ToString(),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          MontoUsado = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["montoUsado"].ToString()),
          MontoDisponible = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["montoDisponible"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<ClienteVO> buscaClienteFiltro(string _busca)
    {
      string str = "SELECT pre.fechaCreacion, pre.codigo, pre.razonSocial, pre.vendedor, pre.tipoCliente,\r\n                                    (SELECT COUNT(idCliente) FROM orden_preventa op WHERE pre.codigo=op.idCliente ) AS intentos\r\n                            FROM preclientes pre " + _busca + " ORDER BY pre.razonSocial LIMIT 0, 1000";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<ClienteVO> list = new List<ClienteVO>();
      int num = 1;
      while (((DbDataReader) mySqlDataReader).Read())
      {
        list.Add(new ClienteVO()
        {
          FechaCreacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCreacion"]),
          Codigo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigo"]),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString(),
          TipoCliente = ((DbDataReader) mySqlDataReader)["tipoCliente"].ToString(),
          Intentos = Convert.ToInt32(((DbDataReader) mySqlDataReader)["intentos"].ToString()),
          Linea = num
        });
        ++num;
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public string cantidadRegistros(string _busca)
    {
      string str1 = "0";
      string str2 = "SELECT count(*) FROM preclientes pre " + _busca;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str2;
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        str1 = ((DbDataReader) mySqlDataReader)[0].ToString();
      ((DbDataReader) mySqlDataReader).Close();
      return str1;
    }

    public List<ClienteVO> buscaClientePagina(string _busca, string desde)
    {
      string str = "SELECT pre.fechaCreacion, pre.codigo, pre.razonSocial, pre.vendedor, pre.tipoCliente,\r\n                                    (SELECT COUNT(idCliente) FROM orden_preventa op WHERE pre.codigo=op.idCliente ) AS intentos\r\n                            FROM preclientes pre " + _busca + " ORDER BY pre.razonSocial LIMIT " + desde + ", 1000";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      List<ClienteVO> list = new List<ClienteVO>();
      int num = Convert.ToInt32(desde) + 1;
      while (((DbDataReader) mySqlDataReader).Read())
      {
        list.Add(new ClienteVO()
        {
          FechaCreacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCreacion"]),
          Codigo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigo"]),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          Vendedor = ((DbDataReader) mySqlDataReader)["vendedor"].ToString(),
          TipoCliente = ((DbDataReader) mySqlDataReader)["tipoCliente"].ToString(),
          Intentos = Convert.ToInt32(((DbDataReader) mySqlDataReader)["intentos"].ToString()),
          Linea = num
        });
        ++num;
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
