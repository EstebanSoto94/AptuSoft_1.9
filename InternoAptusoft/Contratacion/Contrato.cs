 
// Type: Aptusoft.InternoAptusoft.Contratacion.Contrato
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft.InternoAptusoft.Contratacion
{
  public class Contrato
  {
    private Conexion conexion = Conexion.getConecta();

    public int GuardaContrato(ContratoVO co)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO internos_contratos (\r\n                                                                    fechaContratacion,\r\n                                                                    idCliente,\r\n                                                                    rut,\r\n                                                                    digito,\r\n                                                                    razonSocial,\r\n                                                                    direccion,\r\n                                                                    comuna,\r\n                                                                    ciudad,\r\n                                                                    giro,\r\n                                                                    fono,                                                                    \r\n                                                                    contacto,\r\n                                                                    email,\r\n                                                                    total,\r\n                                                                    estado,\r\n                                                                    codigo,\r\n                                                                    descripcion,\r\n                                                                    codigoCiclo,\r\n                                                                    segundaFacturacion,\r\n                                                                    segundoVencimiento,\r\n                                                                    codigoOferta,\r\n                                                                    descripcionOferta,\r\n                                                                    mesesOferta,\r\n                                                                    descuentoOferta,\r\n                                                                    observaciones                                                                    \r\n                                                                ) \r\n                                                           VALUES(\r\n                                                                    @fechaContratacion,\r\n                                                                    @idCliente,\r\n                                                                    @rut,\r\n                                                                    @digito,\r\n                                                                    @razonSocial,\r\n                                                                    @direccion,\r\n                                                                    @comuna,\r\n                                                                    @ciudad,\r\n                                                                    @giro,\r\n                                                                    @fono,                                                                    \r\n                                                                    @contacto,\r\n                                                                    @email,\r\n                                                                    @total,\r\n                                                                    @estado,\r\n                                                                    @codigo,\r\n                                                                    @descripcion,\r\n                                                                    @codigoCiclo,\r\n                                                                    @segundaFacturacion,\r\n                                                                    @segundoVencimiento,\r\n                                                                    @codigoOferta,\r\n                                                                    @descripcionOferta,\r\n                                                                    @mesesOferta,\r\n                                                                    @descuentoOferta,\r\n                                                                    @observaciones                                                                    \r\n                                                                    )";
      command.Parameters.AddWithValue("@fechaContratacion", (object) co.FechaContratacion);
      command.Parameters.AddWithValue("@idCliente", (object) co.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) co.Rut);
      command.Parameters.AddWithValue("@digito", (object) co.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) co.RazonSocial);
      command.Parameters.AddWithValue("@direccion", (object) co.Direccion);
      command.Parameters.AddWithValue("@comuna", (object) co.Comuna);
      command.Parameters.AddWithValue("@ciudad", (object) co.Ciudad);
      command.Parameters.AddWithValue("@giro", (object) co.Giro);
      command.Parameters.AddWithValue("@fono", (object) co.Fono);
      command.Parameters.AddWithValue("@contacto", (object) co.Contacto);
      command.Parameters.AddWithValue("@email", (object) co.Email);
      command.Parameters.AddWithValue("@total", (object) co.Total);
      command.Parameters.AddWithValue("@estado", (object) co.Estado);
      command.Parameters.AddWithValue("@codigo", (object) co.Codigo);
      command.Parameters.AddWithValue("@descripcion", (object) co.Descripcion);
      command.Parameters.AddWithValue("@codigoCiclo", (object) co.CodigoCiclo);
      command.Parameters.AddWithValue("@segundaFacturacion", (object) co.SegundaFacturacion);
      command.Parameters.AddWithValue("@segundoVencimiento", (object) co.SegundoVencimiento);
      command.Parameters.AddWithValue("@codigoOferta", (object) co.CodigoOferta);
      command.Parameters.AddWithValue("@descripcionOferta", (object) co.DescripcionOferta);
      command.Parameters.AddWithValue("@mesesOferta", (object) co.MesesOferta);
      command.Parameters.AddWithValue("@descuentoOferta", (object) co.DescuentoOferta);
      command.Parameters.AddWithValue("@observaciones", (object) co.Observaciones);
      ((DbCommand) command).ExecuteNonQuery();
      return this.RetornaIdContrato();
    }

    public int GuardaContratoCambioCiclo(ContratoVO co)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO internos_contratos (\r\n                                                                    fechaContratacion,\r\n                                                                    idCliente,\r\n                                                                    rut,\r\n                                                                    digito,\r\n                                                                    razonSocial,\r\n                                                                    direccion,\r\n                                                                    comuna,\r\n                                                                    ciudad,\r\n                                                                    giro,\r\n                                                                    fono,                                                                    \r\n                                                                    contacto,\r\n                                                                    email,\r\n                                                                    total,\r\n                                                                    estado,\r\n                                                                    codigo,\r\n                                                                    descripcion,\r\n                                                                    codigoCiclo,\r\n                                                                    segundaFacturacion,\r\n                                                                    segundoVencimiento,\r\n                                                                    codigoOferta,\r\n                                                                    descripcionOferta,\r\n                                                                    mesesOferta,\r\n                                                                    descuentoOferta,\r\n                                                                    observaciones,\r\n                                                                    cambioCiclo,\r\n                                                                    fechaCambioCiclo\r\n                                                                ) \r\n                                                           VALUES(\r\n                                                                    @fechaContratacion,\r\n                                                                    @idCliente,\r\n                                                                    @rut,\r\n                                                                    @digito,\r\n                                                                    @razonSocial,\r\n                                                                    @direccion,\r\n                                                                    @comuna,\r\n                                                                    @ciudad,\r\n                                                                    @giro,\r\n                                                                    @fono,                                                                    \r\n                                                                    @contacto,\r\n                                                                    @email,\r\n                                                                    @total,\r\n                                                                    @estado,\r\n                                                                    @codigo,\r\n                                                                    @descripcion,\r\n                                                                    @codigoCiclo,\r\n                                                                    @segundaFacturacion,\r\n                                                                    @segundoVencimiento,\r\n                                                                    @codigoOferta,\r\n                                                                    @descripcionOferta,\r\n                                                                    @mesesOferta,\r\n                                                                    @descuentoOferta,\r\n                                                                    @observaciones,\r\n                                                                    @cambioCiclo,\r\n                                                                    @fechaCambioCiclo                                                                    \r\n                                                                    )";
      command.Parameters.AddWithValue("@fechaContratacion", (object) co.FechaContratacion);
      command.Parameters.AddWithValue("@idCliente", (object) co.IdCliente);
      command.Parameters.AddWithValue("@rut", (object) co.Rut);
      command.Parameters.AddWithValue("@digito", (object) co.Digito);
      command.Parameters.AddWithValue("@razonSocial", (object) co.RazonSocial);
      command.Parameters.AddWithValue("@direccion", (object) co.Direccion);
      command.Parameters.AddWithValue("@comuna", (object) co.Comuna);
      command.Parameters.AddWithValue("@ciudad", (object) co.Ciudad);
      command.Parameters.AddWithValue("@giro", (object) co.Giro);
      command.Parameters.AddWithValue("@fono", (object) co.Fono);
      command.Parameters.AddWithValue("@contacto", (object) co.Contacto);
      command.Parameters.AddWithValue("@email", (object) co.Email);
      command.Parameters.AddWithValue("@total", (object) co.Total);
      command.Parameters.AddWithValue("@estado", (object) co.Estado);
      command.Parameters.AddWithValue("@codigo", (object) co.Codigo);
      command.Parameters.AddWithValue("@descripcion", (object) co.Descripcion);
      command.Parameters.AddWithValue("@codigoCiclo", (object) co.CodigoCiclo);
      command.Parameters.AddWithValue("@segundaFacturacion", (object) co.SegundaFacturacion);
      command.Parameters.AddWithValue("@segundoVencimiento", (object) co.SegundoVencimiento);
      command.Parameters.AddWithValue("@codigoOferta", (object) co.CodigoOferta);
      command.Parameters.AddWithValue("@descripcionOferta", (object) co.DescripcionOferta);
      command.Parameters.AddWithValue("@mesesOferta", (object) co.MesesOferta);
      command.Parameters.AddWithValue("@descuentoOferta", (object) co.DescuentoOferta);
      command.Parameters.AddWithValue("@observaciones", (object) co.Observaciones);
      command.Parameters.AddWithValue("@cambioCiclo", (co.CambioCiclo ? 1 : 0));
      command.Parameters.AddWithValue("@fechaCambioCiclo", (object) co.FechaCambioCiclo);
      ((DbCommand) command).ExecuteNonQuery();
      return this.RetornaIdContrato();
    }

    private int RetornaIdContrato()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT DISTINCT LAST_INSERT_ID() FROM internos_contratos";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      int num = 0;
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public void ModificaContrato(ContratoVO co)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE internos_contratos SET \r\n                                            estado=@estado,\r\n                                            observaciones=@observaciones,\r\n                                            fechaModificacion=@fechaModificacion\r\n                                    WHERE idContrato=@idContrato";
      command.Parameters.AddWithValue("@idContrato", (object) co.IdContrato);
      command.Parameters.AddWithValue("@estado", (object) co.Estado);
      command.Parameters.AddWithValue("@observaciones", (object) co.Observaciones);
      command.Parameters.AddWithValue("@fechaModificacion", (object) co.FechaModificacion);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void ModificaContratoCambioCiclo(ContratoVO co)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE internos_contratos SET \r\n                                            cambioCiclo=@cambioCiclo,\r\n                                            fechaCambioCiclo=@fechaCambioCiclo\r\n                                    WHERE idContrato=@idContrato";
      command.Parameters.AddWithValue("@idContrato", (object) co.IdContrato);
      command.Parameters.AddWithValue("@cambioCiclo", (co.CambioCiclo ? 1 : 0));
      command.Parameters.AddWithValue("@fechaCambioCiclo", (object) co.FechaCambioCiclo);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public ContratoVO BuscaContratoActivoIdCliente(int idCliente)
    {
      ContratoVO contratoVo = new ContratoVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idContrato,                                       \r\n                                            fechaContratacion,\r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            direccion,\r\n                                            comuna,\r\n                                            ciudad,\r\n                                            giro,\r\n                                            fono,                                                                    \r\n                                            contacto,\r\n                                            email,\r\n                                            total,\r\n                                            estado,\r\n                                            codigo,\r\n                                            descripcion,\r\n                                            codigoCiclo,\r\n                                            segundaFacturacion,\r\n                                            segundoVencimiento,\r\n                                            codigoOferta,\r\n                                            descripcionOferta,\r\n                                            mesesOferta,\r\n                                            descuentoOferta,\r\n                                            observaciones,\r\n                                            cambioCiclo,\r\n                                            fechaCambioCiclo                                        \r\n                                FROM internos_contratos \r\n                                WHERE idCliente=@idCliente AND estado='ACTIVO'";
      command.Parameters.AddWithValue("@idCliente", (object) idCliente);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        contratoVo = new ContratoVO();
        contratoVo.IdContrato = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idContrato"].ToString());
        contratoVo.FechaContratacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaContratacion"].ToString());
        contratoVo.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString());
        contratoVo.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        contratoVo.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        contratoVo.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        contratoVo.Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString();
        contratoVo.Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString();
        contratoVo.Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString();
        contratoVo.Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString();
        contratoVo.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        contratoVo.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        contratoVo.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        contratoVo.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString());
        contratoVo.Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString();
        contratoVo.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
        contratoVo.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
        contratoVo.CodigoCiclo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoCiclo"].ToString());
        contratoVo.SegundaFacturacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["segundaFacturacion"].ToString());
        contratoVo.SegundoVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["segundoVencimiento"].ToString());
        contratoVo.CodigoOferta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoOferta"].ToString());
        contratoVo.DescripcionOferta = ((DbDataReader) mySqlDataReader)["descripcionOferta"].ToString();
        contratoVo.MesesOferta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesOferta"].ToString());
        contratoVo.DescuentoOferta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoOferta"].ToString());
        contratoVo.Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString();
        contratoVo.CambioCiclo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["cambioCiclo"]);
        if (contratoVo.CambioCiclo)
          contratoVo.FechaCambioCiclo = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCambioCiclo"]);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return contratoVo;
    }

    public List<ContratoVO> BuscaContratoActivoCodigoCiclo(string consulta)
    {
      List<ContratoVO> list = new List<ContratoVO>();
      ContratoVO contratoVo1 = new ContratoVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idContrato,                                       \r\n                                            fechaContratacion,\r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            direccion,\r\n                                            comuna,\r\n                                            ciudad,\r\n                                            giro,\r\n                                            fono,                                                                    \r\n                                            contacto,\r\n                                            email,\r\n                                            total,\r\n                                            estado,\r\n                                            codigo,\r\n                                            descripcion,\r\n                                            codigoCiclo,\r\n                                            segundaFacturacion,\r\n                                            segundoVencimiento,\r\n                                            codigoOferta,\r\n                                            descripcionOferta,\r\n                                            mesesOferta,\r\n                                            mesesOfertaOcupado,\r\n                                            descuentoOferta,\r\n                                            observaciones,\r\n                                            cambioCiclo,\r\n                                            fechaCambioCiclo                                        \r\n                                FROM internos_contratos \r\n                                WHERE " + consulta + " AND estado='ACTIVO'";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        ContratoVO contratoVo2 = new ContratoVO();
        contratoVo2.IdContrato = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idContrato"].ToString());
        contratoVo2.FechaContratacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaContratacion"].ToString());
        contratoVo2.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString());
        contratoVo2.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        contratoVo2.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        contratoVo2.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        contratoVo2.Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString();
        contratoVo2.Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString();
        contratoVo2.Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString();
        contratoVo2.Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString();
        contratoVo2.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        contratoVo2.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        contratoVo2.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        contratoVo2.SubTotal = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString());
        contratoVo2.Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString();
        contratoVo2.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
        contratoVo2.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
        contratoVo2.CodigoCiclo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoCiclo"].ToString());
        contratoVo2.SegundaFacturacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["segundaFacturacion"].ToString());
        contratoVo2.SegundoVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["segundoVencimiento"].ToString());
        contratoVo2.CodigoOferta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoOferta"].ToString());
        contratoVo2.DescripcionOferta = ((DbDataReader) mySqlDataReader)["descripcionOferta"].ToString();
        contratoVo2.MesesOferta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesOferta"].ToString());
        contratoVo2.MesesOfertaOcupado = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesOfertaOcupado"].ToString());
        contratoVo2.DescuentoOferta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoOferta"].ToString());
        contratoVo2.Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString();
        contratoVo2.CambioCiclo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["cambioCiclo"]);
        if (contratoVo2.CambioCiclo)
          contratoVo2.FechaCambioCiclo = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCambioCiclo"]);
        list.Add(contratoVo2);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public DataTable MuestraContratoID(int idContrato)
    {
      string str = "SELECT                                         \r\n                                        fechaContratacion,                                        \r\n                                        rut,\r\n                                        digito,\r\n                                        razonSocial,                                        \r\n                                        total,                                        \r\n                                        codigo,\r\n                                        descripcion                                        \r\n                                FROM internos_contratos \r\n                                WHERE idContrato=@idContrato";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      command.Parameters.AddWithValue("@idContrato", (object) idContrato);
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public List<ContratoVO> BuscaContratoIdCliente(int idCliente)
    {
      List<ContratoVO> list = new List<ContratoVO>();
      ContratoVO contratoVo1 = new ContratoVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idContrato,                                       \r\n                                            fechaContratacion,\r\n                                            idCliente,\r\n                                            rut,\r\n                                            digito,\r\n                                            razonSocial,\r\n                                            direccion,\r\n                                            comuna,\r\n                                            ciudad,\r\n                                            giro,\r\n                                            fono,                                                                    \r\n                                            contacto,\r\n                                            email,\r\n                                            total,\r\n                                            estado,\r\n                                            codigo,\r\n                                            descripcion,\r\n                                            codigoCiclo,\r\n                                            segundaFacturacion,\r\n                                            segundoVencimiento,\r\n                                            codigoOferta,\r\n                                            descripcionOferta,\r\n                                            mesesOferta,\r\n                                            mesesOfertaOcupado,\r\n                                            descuentoOferta,\r\n                                            observaciones,\r\n                                            fechaModificacion,\r\n                                            cambioCiclo,\r\n                                            fechaCambioCiclo                                        \r\n                                FROM internos_contratos \r\n                                WHERE idCliente=@idCliente ORDER BY idContrato DESC";
      command.Parameters.AddWithValue("@idCliente", (object) idCliente);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        ContratoVO contratoVo2 = new ContratoVO();
        contratoVo2.IdContrato = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idContrato"].ToString());
        contratoVo2.FechaContratacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaContratacion"].ToString());
        contratoVo2.IdCliente = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCliente"].ToString());
        contratoVo2.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString();
        contratoVo2.Digito = ((DbDataReader) mySqlDataReader)["digito"].ToString();
        contratoVo2.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        contratoVo2.Direccion = ((DbDataReader) mySqlDataReader)["direccion"].ToString();
        contratoVo2.Comuna = ((DbDataReader) mySqlDataReader)["comuna"].ToString();
        contratoVo2.Ciudad = ((DbDataReader) mySqlDataReader)["ciudad"].ToString();
        contratoVo2.Giro = ((DbDataReader) mySqlDataReader)["giro"].ToString();
        contratoVo2.Fono = ((DbDataReader) mySqlDataReader)["fono"].ToString();
        contratoVo2.Contacto = ((DbDataReader) mySqlDataReader)["contacto"].ToString();
        contratoVo2.Email = ((DbDataReader) mySqlDataReader)["email"].ToString();
        contratoVo2.SubTotal = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"].ToString());
        contratoVo2.Estado = ((DbDataReader) mySqlDataReader)["estado"].ToString();
        contratoVo2.Codigo = ((DbDataReader) mySqlDataReader)["codigo"].ToString();
        contratoVo2.Descripcion = ((DbDataReader) mySqlDataReader)["descripcion"].ToString();
        contratoVo2.CodigoCiclo = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoCiclo"].ToString());
        contratoVo2.SegundaFacturacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["segundaFacturacion"].ToString());
        contratoVo2.SegundoVencimiento = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["segundoVencimiento"].ToString());
        contratoVo2.CodigoOferta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoOferta"].ToString());
        contratoVo2.DescripcionOferta = ((DbDataReader) mySqlDataReader)["descripcionOferta"].ToString();
        contratoVo2.MesesOferta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesOferta"].ToString());
        contratoVo2.MesesOfertaOcupado = Convert.ToInt32(((DbDataReader) mySqlDataReader)["mesesOfertaOcupado"].ToString());
        contratoVo2.DescuentoOferta = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["descuentoOferta"].ToString());
        if (contratoVo2.MesesOferta > 0)
        {
          contratoVo2.MesesOfertaRestante = contratoVo2.MesesOferta - contratoVo2.MesesOfertaOcupado;
          if (contratoVo2.MesesOfertaRestante == 0)
          {
            contratoVo2.Descuento = new Decimal(0);
            contratoVo2.Total = contratoVo2.SubTotal;
            contratoVo2.DescuentoOferta = new Decimal(0);
          }
          else if (contratoVo2.DescuentoOferta > new Decimal(0))
          {
            if (contratoVo2.DescuentoOferta == new Decimal(100))
            {
              contratoVo2.Descuento = contratoVo2.SubTotal;
              contratoVo2.Total = new Decimal(0);
            }
            else
            {
              contratoVo2.Descuento = contratoVo2.SubTotal * contratoVo2.DescuentoOferta / new Decimal(100);
              contratoVo2.Total = contratoVo2.SubTotal - contratoVo2.Descuento;
            }
          }
        }
        else
          contratoVo2.MesesOfertaRestante = 0;
        contratoVo2.Observaciones = ((DbDataReader) mySqlDataReader)["observaciones"].ToString();
        if (((DbDataReader) mySqlDataReader)["fechaModificacion"].ToString().Length > 0)
          contratoVo2.FechaModificacion = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaModificacion"]);
        contratoVo2.CambioCiclo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["cambioCiclo"]);
        if (contratoVo2.CambioCiclo)
          contratoVo2.FechaCambioCiclo = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaCambioCiclo"]);
        list.Add(contratoVo2);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void ModificaMesesOfertaOcupado(int idContrato)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE internos_contratos SET \r\n                                            mesesOfertaOcupado=mesesOfertaOcupado+1\r\n                                    WHERE idContrato=@idContrato";
      command.Parameters.AddWithValue("@idContrato", (object) idContrato);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
