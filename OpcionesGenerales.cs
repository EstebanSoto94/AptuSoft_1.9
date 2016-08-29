 
// Type: Aptusoft.OpcionesGenerales
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class OpcionesGenerales
  {
    private Conexion conexion = Conexion.getConecta();

    public OpcionesGeneralesVO rescataOpcionesGenerales()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "SELECT \r\n                                                idOpcionesGenerales, porcentajeIva,\r\n                                                valoresVentaConIva, verificaCredito, \r\n                                                impedirVentasSinCredito, verificaFactura,\r\n                                                verificaFacturaExenta, verificaBoleta, \r\n                                                verificaGuiaSinFacturar, codigoPesable\r\n                                        FROM opcionesgenerales";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        OpcionesGeneralesVO opcionesGeneralesVo = new OpcionesGeneralesVO();
        while (((DbDataReader) mySqlDataReader).Read())
        {
          opcionesGeneralesVo.IdOpciones = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idOpcionesGenerales"].ToString());
          opcionesGeneralesVo.PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"].ToString());
          opcionesGeneralesVo.valoresVentaConIva = ((DbDataReader) mySqlDataReader)["valoresVentaConIva"].ToString();
          opcionesGeneralesVo.VerificaCredito = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaCredito"].ToString());
          opcionesGeneralesVo.ImpedirVentasSinCredito = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["impedirVentasSinCredito"].ToString());
          opcionesGeneralesVo.VerificaFactura = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaFactura"].ToString());
          opcionesGeneralesVo.VerificaFacturaExenta = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaFacturaExenta"].ToString());
          opcionesGeneralesVo.VerificaBoleta = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaBoleta"].ToString());
          opcionesGeneralesVo.VerificaGuiaSinFacturar = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaGuiaSinFacturar"].ToString());
          opcionesGeneralesVo.CodigoPesable = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoPesable"].ToString());
        }
        ((DbDataReader) mySqlDataReader).Close();
        return opcionesGeneralesVo;
      }
      catch
      {
        return (OpcionesGeneralesVO) null;
      }
    }

    public short puertoFiscal()
    {
      short num1 = (short) 0;
      DataSet dataSet = new DataSet("datos");
      int num2 = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\fiscal.xml");
      DataTable dataTable = dataSet.Tables["impresora"];
      for (int index = 0; index < dataTable.Rows.Count; ++index)
        num1 = Convert.ToInt16(dataTable.Rows[index]["puerto"].ToString());
      return num1;
    }

    public void guardaOpciones(OpcionesGeneralesVO ogVO, List<OpcionesDocumentosVO> lista)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE opcionesgenerales SET \r\n                                                                    porcentajeIva = @porIva,\r\n                                                                    valoresVentaConIva=@valorVenta,\r\n                                                                    verificaCredito=@verificaCredito,\r\n                                                                    impedirVentasSinCredito=@impedirVentasSinCredito,\r\n                                                                    verificaFactura=@verificaFactura,\r\n                                                                    verificaFacturaExenta=@verificaFacturaExenta,\r\n                                                                    verificaBoleta=@verificaBoleta,\r\n                                                                    verificaGuiaSinFacturar=@verificaGuiaSinFacturar,\r\n                                                                    codigoPesable=@codigoPesable\r\n                                        WHERE idOpcionesGenerales = @id";
        command.Parameters.AddWithValue("@id", (object) ogVO.IdOpciones);
        command.Parameters.AddWithValue("@porIva", (object) ogVO.PorcentajeIva);
        command.Parameters.AddWithValue("@valorVenta", (object) ogVO.valoresVentaConIva);
        command.Parameters.AddWithValue("@verificaCredito", (ogVO.VerificaCredito ? 1 : 0));
        command.Parameters.AddWithValue("@impedirVentasSinCredito", (ogVO.ImpedirVentasSinCredito ? 1 : 0));
        command.Parameters.AddWithValue("@verificaFactura", (ogVO.VerificaFactura ? 1 : 0));
        command.Parameters.AddWithValue("@verificaFacturaExenta", (ogVO.VerificaFacturaExenta ? 1 : 0));
        command.Parameters.AddWithValue("@verificaBoleta", (ogVO.VerificaBoleta ? 1 : 0));
        command.Parameters.AddWithValue("@verificaGuiaSinFacturar", (ogVO.VerificaGuiaSinFacturar ? 1 : 0));
        command.Parameters.AddWithValue("@codigoPesable", (object) ogVO.CodigoPesable);
        ((DbCommand) command).ExecuteNonQuery();
        foreach (OpcionesDocumentosVO odVO in lista)
          this.guardaOpcionesDocumentos(odVO);
      }
      catch
      {
      }
    }

    public void guardaOpcionesDocumentos(OpcionesDocumentosVO odVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      try
      {
        ((DbCommand) command).CommandText = "UPDATE opcionesdocumentos SET\r\n                                            alertaStockInsuficiente = @aleStockIns,\r\n                                            impideVentaSinStock = @impVenSinStock,\r\n                                            cantidadLineasDocumento = @canLineas,\r\n                                            puertoImpresoraFiscal = @puertoImpresoraFiscal,\r\n                                            decimalesValoresVenta = @decimalesVV,\r\n                                            descripcion_resumen=@descripcion_resumen,\r\n                                            iniciarEnNumeroTicket=@iniciarEnNumeroTicket,\r\n                                            facturarCotizacionCompleta=@facturarCotizacionCompleta,\r\n                                            envioAutomaticoSII=@envioAutomaticoSII,\r\n                                            imprimeComprobanteExento=@imprimeComprobanteExento,\r\n                                            medioPago=@medioPago,\r\n                                            permitirMediopago=@permitirMediopago,\r\n                                            busquedaRazonSocial=@busquedaRazonSocial\r\n                                        WHERE nombreDocumento= @nomDoc";
        command.Parameters.AddWithValue("@nomDoc", (object) odVO.NombreDocumento);
        command.Parameters.AddWithValue("@aleStockIns", (object) odVO.AlertaStockInsuficiente);
        command.Parameters.AddWithValue("@impVenSinStock", (object) odVO.ImpideVentasSinStock);
        command.Parameters.AddWithValue("@canLineas", (object) odVO.CantidadLineasDocumento);
        command.Parameters.AddWithValue("@puertoImpresoraFiscal", (object) odVO.PuertoImpresoraFiscal);
        command.Parameters.AddWithValue("@descripcion_resumen", (object) odVO.Descripcion_Resumen);
        command.Parameters.AddWithValue("@decimalesVV", (object) odVO.DecimalesValorVenta);
        command.Parameters.AddWithValue("@iniciarEnNumeroTicket", (object) odVO.iniciarEnNumeroTicket);
        command.Parameters.AddWithValue("@facturarCotizacionCompleta", (object) odVO.FacturarCotizacionCompleta);
        command.Parameters.AddWithValue("@envioAutomaticoSII", (object) odVO.EnvioAutomaticoSII);
        command.Parameters.AddWithValue("@imprimeComprobanteExento", (object) odVO.ComprobanteExentos);
        command.Parameters.AddWithValue("@medioPago", (object) odVO.MedioPago);
        command.Parameters.AddWithValue("@permitirMediopago", (object) odVO.PermitirMedioPago);
        command.Parameters.AddWithValue("@busquedaRazonSocial", (object) odVO.BusquedaRazonSocial);
        ((DbCommand) command).ExecuteNonQuery();
      }
      catch
      {
      }
    }

    public List<OpcionesDocumentosVO> rescataOpcionesDocumentos()
    {
      short num = this.puertoFiscal();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      List<OpcionesDocumentosVO> list = new List<OpcionesDocumentosVO>();
      try
      {
        ((DbCommand) command).CommandText = "SELECT \r\n                                                nombreDocumento, alertaStockInsuficiente,\r\n                                                impideVentaSinStock, cantidadLineasDocumento,\r\n                                                puertoImpresoraFiscal, decimalesValoresVenta, \r\n                                                descripcion_resumen, iniciarEnNumeroTicket, \r\n                                                facturarCotizacionCompleta, \r\n                                                envioAutomaticoSII,\r\n                                                imprimeComprobanteExento,\r\n                                                medioPago, permitirMediopago, busquedaRazonSocial\r\n                                        FROM opcionesdocumentos ORDER BY nombreDocumento";
        MySqlDataReader mySqlDataReader = command.ExecuteReader();
        while (((DbDataReader) mySqlDataReader).Read())
          list.Add(new OpcionesDocumentosVO()
          {
            NombreDocumento = ((DbDataReader) mySqlDataReader)[0].ToString(),
            AlertaStockInsuficiente = ((DbDataReader) mySqlDataReader)[1].ToString(),
            ImpideVentasSinStock = ((DbDataReader) mySqlDataReader)[2].ToString(),
            CantidadLineasDocumento = ((DbDataReader) mySqlDataReader)[3].ToString(),
            PuertoImpresoraFiscal = (int) num,
            DecimalesValorVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)[5].ToString()),
            Descripcion_Resumen = ((DbDataReader) mySqlDataReader)["descripcion_resumen"].ToString(),
            iniciarEnNumeroTicket = ((DbDataReader) mySqlDataReader)["iniciarEnNumeroTicket"].ToString(),
            FacturarCotizacionCompleta = ((DbDataReader) mySqlDataReader)["facturarCotizacionCompleta"].ToString(),
            EnvioAutomaticoSII = ((DbDataReader) mySqlDataReader)["envioAutomaticoSII"].ToString(),
            ComprobanteExentos = ((DbDataReader) mySqlDataReader)["imprimeComprobanteExento"].ToString(),
            MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString(),
            PermitirMedioPago = ((DbDataReader) mySqlDataReader)["permitirMediopago"].ToString(),
            BusquedaRazonSocial = ((DbDataReader) mySqlDataReader)["busquedaRazonSocial"].ToString()
          });
        ((DbDataReader) mySqlDataReader).Close();
        return list;
      }
      catch
      {
        return (List<OpcionesDocumentosVO>) null;
      }
    }

    public OpcionesDocumentosVO rescataOpcionesDocumentosPorNombre(string nombreDoc)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                                nombreDocumento, alertaStockInsuficiente,\r\n                                                impideVentaSinStock, cantidadLineasDocumento,\r\n                                                puertoImpresoraFiscal, decimalesValoresVenta,\r\n                                                descripcion_resumen, iniciarEnNumeroTicket, \r\n                                                facturarCotizacionCompleta, \r\n                                                envioAutomaticoSII, \r\n                                                imprimeComprobanteExento,\r\n                                                medioPago, permitirMediopago, busquedaRazonSocial\r\n                                        FROM opcionesdocumentos WHERE nombreDocumento=@nombreDoc ";
      command.Parameters.AddWithValue("@nombreDoc", (object) nombreDoc);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      OpcionesDocumentosVO opcionesDocumentosVo = new OpcionesDocumentosVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        opcionesDocumentosVo.NombreDocumento = ((DbDataReader) mySqlDataReader)[0].ToString();
        opcionesDocumentosVo.AlertaStockInsuficiente = ((DbDataReader) mySqlDataReader)[1].ToString();
        opcionesDocumentosVo.ImpideVentasSinStock = ((DbDataReader) mySqlDataReader)[2].ToString();
        opcionesDocumentosVo.CantidadLineasDocumento = ((DbDataReader) mySqlDataReader)[3].ToString();
        opcionesDocumentosVo.PuertoImpresoraFiscal = Convert.ToInt32(((DbDataReader) mySqlDataReader)[4].ToString());
        opcionesDocumentosVo.DecimalesValorVenta = Convert.ToInt32(((DbDataReader) mySqlDataReader)[5].ToString());
        opcionesDocumentosVo.Descripcion_Resumen = ((DbDataReader) mySqlDataReader)["descripcion_resumen"].ToString();
        opcionesDocumentosVo.iniciarEnNumeroTicket = ((DbDataReader) mySqlDataReader)["iniciarEnNumeroTicket"].ToString();
        opcionesDocumentosVo.FacturarCotizacionCompleta = ((DbDataReader) mySqlDataReader)["facturarCotizacionCompleta"].ToString();
        opcionesDocumentosVo.EnvioAutomaticoSII = ((DbDataReader) mySqlDataReader)["envioAutomaticoSII"].ToString();
        opcionesDocumentosVo.ComprobanteExentos = ((DbDataReader) mySqlDataReader)["imprimeComprobanteExento"].ToString();
        opcionesDocumentosVo.MedioPago = ((DbDataReader) mySqlDataReader)["medioPago"].ToString();
        opcionesDocumentosVo.PermitirMedioPago = ((DbDataReader) mySqlDataReader)["permitirMediopago"].ToString();
        opcionesDocumentosVo.BusquedaRazonSocial = ((DbDataReader) mySqlDataReader)["busquedaRazonSocial"].ToString();
      }
      ((DbDataReader) mySqlDataReader).Close();
      return opcionesDocumentosVo;
    }
  }
}
