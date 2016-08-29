 
// Type: Aptusoft.Credito
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class Credito
  {
    private Conexion conexion = Conexion.getConecta();

    public List<CreditoVO> verificaCredito(int idCliente)
    {
      List<CreditoVO> list = new List<CreditoVO>();
      CreditoVO creditoVo1 = new CreditoVO();
      Calculos calculos = new Calculos();
      Decimal num1 = new Decimal(0);
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT creditoAprobado FROM clientes WHERE codigo=@idClienteCli";
      command.Parameters.AddWithValue("@idClienteCli", (object) idCliente);
      MySqlDataReader mySqlDataReader1 = command.ExecuteReader();
      Decimal num2 = new Decimal(0);
      while (((DbDataReader) mySqlDataReader1).Read())
      {
        CreditoVO creditoVo2 = new CreditoVO();
        creditoVo2.Codigo = 1;
        creditoVo2.Descripcion = "Credito Aprobado           : ";
        num2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)[0].ToString());
        creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader1)[0].ToString());
        creditoVo2.Credito = num2;
        list.Add(creditoVo2);
      }
      ((DbDataReader) mySqlDataReader1).Close();
      if (calculos._verificaFactura)
      {
        ((DbCommand) command).CommandText = "SELECT SUM(totalPendiente) as 'Total' FROM facturas WHERE idCliente=@idCliente AND estadoDocumento='EMITIDA'";
        command.Parameters.AddWithValue("@idCliente", (object) idCliente);
        MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader2).Read())
        {
          CreditoVO creditoVo2 = new CreditoVO();
          if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          {
            creditoVo2.Codigo = 2;
            creditoVo2.Descripcion = "Facturas Pendientes        : ";
            creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
            creditoVo2.Credito = num2;
            num1 += Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
          }
          else
          {
            creditoVo2.Codigo = 2;
            creditoVo2.Descripcion = "Facturas Pendientes        : ";
            creditoVo2.Total = new Decimal(0);
            creditoVo2.Credito = num2;
            num1 = num1;
          }
          list.Add(creditoVo2);
        }
        ((DbDataReader) mySqlDataReader2).Close();
      }
      if (calculos._verificaFactura)
      {
        ((DbCommand) command).CommandText = "SELECT SUM(totalPendiente) as 'Total' FROM electronica_factura WHERE idCliente=@idClienteFE AND estadoDocumento='EMITIDA'";
        command.Parameters.AddWithValue("@idClienteFE", (object) idCliente);
        MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader2).Read())
        {
          CreditoVO creditoVo2 = new CreditoVO();
          if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          {
            creditoVo2.Codigo = 20;
            creditoVo2.Descripcion = "E-Facturas Pendientes        : ";
            creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
            creditoVo2.Credito = num2;
            num1 += Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
          }
          else
          {
            creditoVo2.Codigo = 20;
            creditoVo2.Descripcion = "E-Facturas Pendientes        : ";
            creditoVo2.Total = new Decimal(0);
            creditoVo2.Credito = num2;
            num1 = num1;
          }
          list.Add(creditoVo2);
        }
        ((DbDataReader) mySqlDataReader2).Close();
      }
      if (calculos._verificaFacturaExenta)
      {
        ((DbCommand) command).CommandText = "SELECT SUM(totalPendiente) as 'Pendiente' FROM facturasexentas WHERE idCliente=@idClienteFEX AND estadoDocumento='EMITIDA'";
        command.Parameters.AddWithValue("@idClienteFEX", (object) idCliente);
        MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader2).Read())
        {
          CreditoVO creditoVo2 = new CreditoVO();
          if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          {
            creditoVo2.Codigo = 3;
            creditoVo2.Descripcion = "Facturas Exentas Pendientes: ";
            creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
            creditoVo2.Credito = num2;
            num1 += Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
          }
          else
          {
            creditoVo2.Codigo = 3;
            creditoVo2.Descripcion = "Facturas Exentas Pendientes: ";
            creditoVo2.Total = new Decimal(0);
            creditoVo2.Credito = num2;
            num1 = num1;
          }
          list.Add(creditoVo2);
        }
        ((DbDataReader) mySqlDataReader2).Close();
      }
      if (calculos._verificaFacturaExenta)
      {
        ((DbCommand) command).CommandText = "SELECT SUM(totalPendiente) as 'Pendiente' FROM electronica_factura_exenta WHERE idCliente=@idClienteFEEX AND estadoDocumento='EMITIDA'";
        command.Parameters.AddWithValue("@idClienteFEEX", (object) idCliente);
        MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader2).Read())
        {
          CreditoVO creditoVo2 = new CreditoVO();
          if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          {
            creditoVo2.Codigo = 30;
            creditoVo2.Descripcion = "E-Facturas Exentas Pendientes: ";
            creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
            creditoVo2.Credito = num2;
            num1 += Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
          }
          else
          {
            creditoVo2.Codigo = 30;
            creditoVo2.Descripcion = "E-Facturas Exentas Pendientes: ";
            creditoVo2.Total = new Decimal(0);
            creditoVo2.Credito = num2;
            num1 = num1;
          }
          list.Add(creditoVo2);
        }
        ((DbDataReader) mySqlDataReader2).Close();
      }
      if (calculos._verificaBoleta)
      {
        ((DbCommand) command).CommandText = "SELECT SUM(totalPendiente) as 'Pendiente' FROM boletas WHERE idCliente=@idClienteBol AND estadoDocumento='EMITIDA'";
        command.Parameters.AddWithValue("@idClienteBol", (object) idCliente);
        MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader2).Read())
        {
          CreditoVO creditoVo2 = new CreditoVO();
          if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          {
            creditoVo2.Codigo = 4;
            creditoVo2.Descripcion = "Boletas Pendientes         : ";
            creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
            creditoVo2.Credito = num2;
            num1 += Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
          }
          else
          {
            creditoVo2.Codigo = 4;
            creditoVo2.Descripcion = "Boletas Pendientes         : ";
            creditoVo2.Total = new Decimal(0);
            creditoVo2.Credito = num2;
            num1 = num1;
          }
          list.Add(creditoVo2);
        }
        ((DbDataReader) mySqlDataReader2).Close();
      }
      if (calculos._verificaBoleta)
      {
        ((DbCommand) command).CommandText = "SELECT SUM(totalPendiente) as 'Pendiente' FROM electronica_boleta WHERE idCliente=@idClienteBolE AND estadoDocumento='EMITIDA'";
        command.Parameters.AddWithValue("@idClienteBolE", (object) idCliente);
        MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader2).Read())
        {
          CreditoVO creditoVo2 = new CreditoVO();
          if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          {
            creditoVo2.Codigo = 40;
            creditoVo2.Descripcion = "E-Boletas Pendientes         : ";
            creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
            creditoVo2.Credito = num2;
            num1 += Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
          }
          else
          {
            creditoVo2.Codigo = 40;
            creditoVo2.Descripcion = "E-Boletas Pendientes         : ";
            creditoVo2.Total = new Decimal(0);
            creditoVo2.Credito = num2;
            num1 = num1;
          }
          list.Add(creditoVo2);
        }
        ((DbDataReader) mySqlDataReader2).Close();
      }
      if (calculos._verificaGuiaSinFacturar)
      {
        ((DbCommand) command).CommandText = "SELECT SUM(total) as 'Total' FROM guias WHERE facturada=0 AND idCliente=@idClienteGui AND estadoDocumento='EMITIDA'";
        command.Parameters.AddWithValue("@idClienteGui", (object) idCliente);
        MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader2).Read())
        {
          CreditoVO creditoVo2 = new CreditoVO();
          if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          {
            creditoVo2.Codigo = 5;
            creditoVo2.Descripcion = "Guias Sin Facturar         : ";
            creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
            creditoVo2.Credito = num2;
            num1 += Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
          }
          else
          {
            creditoVo2.Codigo = 5;
            creditoVo2.Descripcion = "Guias Sin Facturar         : ";
            creditoVo2.Total = new Decimal(0);
            creditoVo2.Credito = num2;
            num1 = num1;
          }
          list.Add(creditoVo2);
        }
        ((DbDataReader) mySqlDataReader2).Close();
      }
      if (calculos._verificaGuiaSinFacturar)
      {
        ((DbCommand) command).CommandText = "SELECT SUM(total) as 'Total' FROM electronica_guia \r\n                                                    WHERE\r\n                                                    facturada=0 AND \r\n                                                    idCliente=@idClienteGuiE AND \r\n                                                    estadoDocumento='EMITIDA' AND \r\n                                                    (codigoTipoGuia=1 OR codigoTipoGuia=2 OR codigoTipoGuia=9 )";
        command.Parameters.AddWithValue("@idClienteGuiE", (object) idCliente);
        MySqlDataReader mySqlDataReader2 = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader2).Read())
        {
          CreditoVO creditoVo2 = new CreditoVO();
          if (((DbDataReader) mySqlDataReader2)[0].ToString().Length > 0)
          {
            creditoVo2.Codigo = 50;
            creditoVo2.Descripcion = "E-Guias Sin Facturar         : ";
            creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
            creditoVo2.Credito = num2;
            num1 += Convert.ToDecimal(((DbDataReader) mySqlDataReader2)[0].ToString());
          }
          else
          {
            creditoVo2.Codigo = 50;
            creditoVo2.Descripcion = "E-Guias Sin Facturar         : ";
            creditoVo2.Total = new Decimal(0);
            creditoVo2.Credito = num2;
            num1 = num1;
          }
          list.Add(creditoVo2);
        }
        ((DbDataReader) mySqlDataReader2).Close();
      }
      ((DbCommand) command).CommandText = "SELECT SUM((total-montoUsado)) AS 'Total' FROM notacredito WHERE estadoDocumento='EMITIDA' AND (idTipo=1 OR idTipo=3) AND total > montoUsado AND idCliente=@idCliNC";
      command.Parameters.AddWithValue("@idCliNC", (object) idCliente);
      MySqlDataReader mySqlDataReader3 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader3).Read())
      {
        CreditoVO creditoVo2 = new CreditoVO();
        if (((DbDataReader) mySqlDataReader3)[0].ToString().Length > 0)
        {
          creditoVo2.Codigo = 6;
          creditoVo2.Descripcion = "Nota Credito        : ";
          creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader3)[0].ToString());
          creditoVo2.Credito = num2;
          num1 -= Convert.ToDecimal(((DbDataReader) mySqlDataReader3)[0].ToString());
        }
        else
        {
          creditoVo2.Codigo = 6;
          creditoVo2.Descripcion = "Nota Credito         : ";
          creditoVo2.Total = new Decimal(0);
          creditoVo2.Credito = num2;
        }
        list.Add(creditoVo2);
      }
      ((DbDataReader) mySqlDataReader3).Close();
      ((DbCommand) command).CommandText = "SELECT SUM((total-montoUsado)) AS 'Total' FROM electronica_nota_credito \r\n                                    WHERE \r\n                                        estadoDocumento='EMITIDA' AND \r\n                                        ((tipoAccion1=1 OR tipoAccion1=3) OR\r\n                                        (tipoAccion2=1 OR tipoAccion2=3) OR\r\n                                        (tipoAccion3=1 OR tipoAccion3=3) OR\r\n                                        (tipoAccion4=1 OR tipoAccion4=3) OR\r\n                                        (tipoAccion5=1 OR tipoAccion5=3)) AND\r\n                                        total > montoUsado AND\r\n                                        idCliente=@idCliNCEE";
      command.Parameters.AddWithValue("@idCliNCEE", (object) idCliente);
      MySqlDataReader mySqlDataReader4 = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader4).Read())
      {
        CreditoVO creditoVo2 = new CreditoVO();
        if (((DbDataReader) mySqlDataReader4)[0].ToString().Length > 0)
        {
          creditoVo2.Codigo = 60;
          creditoVo2.Descripcion = "E-Nota Credito        : ";
          creditoVo2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader4)[0].ToString());
          creditoVo2.Credito = num2;
          num1 -= Convert.ToDecimal(((DbDataReader) mySqlDataReader4)[0].ToString());
        }
        else
        {
          creditoVo2.Codigo = 60;
          creditoVo2.Descripcion = "E-Nota Credito         : ";
          creditoVo2.Total = new Decimal(0);
          creditoVo2.Credito = num2;
        }
        list.Add(creditoVo2);
      }
      ((DbDataReader) mySqlDataReader4).Close();
      list.Add(new CreditoVO()
      {
        Codigo = 7,
        Descripcion = "Credito Disponible         : ",
        Total = num2 - num1
      });
      return list;
    }
  }
}
