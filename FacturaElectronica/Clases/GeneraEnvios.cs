 
// Type: Aptusoft.FacturaElectronica.Clases.GeneraEnvios
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class GeneraEnvios
  {
    private Conexion conexion = Conexion.getConecta();

    public List<Venta> buscaDosumentosSinEnviar(bool d33, bool d34, bool d61, bool d56, bool d52)
    {
      List<Venta> lista = new List<Venta>();
      if (d33)
        this.buscaFacturaElectronicas(lista, "ENVIO", "", "");
      if (d34)
        this.buscaFacturaExentaElectronicas(lista, "ENVIO", "", "");
      if (d61)
        this.buscaNotasCreditoElectronicas(lista, "ENVIO", "", "");
      if (d56)
        this.buscaNotasDevitoElectronicas(lista, "ENVIO", "", "");
      if (d52)
        this.buscaGuiaElectronicas(lista, "ENVIO", "", "");
      return lista;
    }

    public List<Venta> buscaDocumentoConsumoFolio()
    {
      List<Venta> lista = new List<Venta>();
      this.buscaBoletaElectronicas(lista, "ENVIO", "", "");
      this.buscaNotasCreditoElectronicas(lista, "CONSUMO_FOLIO", "", "");
      return lista;
    }

    public List<Venta> buscaDosumentosEnviados(string desde, string hasta, bool d33, bool d34, bool d61, bool d56, bool d52, bool f30, bool nc60, bool bol35)
    {
      List<Venta> lista = new List<Venta>();
      if (d33)
        this.buscaFacturaElectronicas(lista, "ENVIADO", desde, hasta);
      if (d34)
        this.buscaFacturaExentaElectronicas(lista, "ENVIADO", desde, hasta);
      if (d61)
        this.buscaNotasCreditoElectronicas(lista, "ENVIADO", desde, hasta);
      if (d56)
        this.buscaNotasDevitoElectronicas(lista, "ENVIADO", desde, hasta);
      if (d52)
        this.buscaGuiaElectronicas(lista, "ENVIADO", desde, hasta);
      if (f30)
        this.buscaFacturaPapel(lista, "ENVIADO", desde, hasta);
      if (nc60)
        this.buscaNotaCreditoPapel(lista, "ENVIADO", desde, hasta);
      if (bol35)
        this.buscaBoletaPapel(lista, "ENVIADO", desde, hasta);
      return lista;
    }

    public List<Venta> buscaDosumentosSinEnviar()
    {
      List<Venta> lista = new List<Venta>();
      this.buscaFacturaElectronicas(lista, "ENVIO", "", "");
      this.buscaNotasCreditoElectronicas(lista, "ENVIO", "", "");
      this.buscaNotasDevitoElectronicas(lista, "ENVIO", "", "");
      this.buscaGuiaElectronicas(lista, "ENVIO", "", "");
      return lista;
    }

    public List<Venta> buscaDosumentosParaLibro(string desde, string hasta, bool f30, bool nc60, bool bol35)
    {
      List<Venta> lista = new List<Venta>();
      this.buscaFacturaElectronicas(lista, "LIBRO", desde, hasta);
      this.buscaFacturaExentaElectronicas(lista, "LIBRO", desde, hasta);
      this.buscaNotasCreditoElectronicas(lista, "LIBRO", desde, hasta);
      this.buscaNotasDevitoElectronicas(lista, "LIBRO", desde, hasta);
      this.buscaBoletaElectronicas(lista, "LIBRO", desde, hasta);
      if (f30)
        this.buscaFacturaPapel(lista, "LIBRO", desde, hasta);
      if (nc60)
        this.buscaNotaCreditoPapel(lista, "LIBRO", desde, hasta);
      if (bol35)
        this.buscaBoletaPapel(lista, "LIBRO", desde, hasta);
      return lista;
    }

    public List<Venta> buscaDosumentosParaLibroGuias(string desde, string hasta)
    {
      List<Venta> lista = new List<Venta>();
      this.buscaGuiaElectronicas(lista, "LIBRO", desde, hasta);
      return lista;
    }

    public List<Venta> buscaDosumentosParaLibroBoletas(string desde, string hasta)
    {
      List<Venta> lista = new List<Venta>();
      this.buscaBoletaElectronicas(lista, "LIBRO", desde, hasta);
      return lista;
    }

    private List<Venta> buscaFacturaElectronicas(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
          str = "enviado_sii=0";
      if (tipo.Equals("ENVIADO"))
          str = "enviado_sii=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
          str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                           idFactura,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial, \r\n                                           neto,\r\n                                           iva,\r\n                                           totalExento,\r\n                                           porcentajeIva,                                                          \r\n                                           total,\r\n                                           porcentajeImpuesto1,\r\n                                           porcentajeImpuesto2,\r\n                                           porcentajeImpuesto3,\r\n                                           porcentajeImpuesto4,\r\n                                           porcentajeImpuesto5,\r\n                                           impuesto1,\r\n                                           impuesto2,\r\n                                           impuesto3,\r\n                                           impuesto4,\r\n                                           impuesto5,\r\n                                           codImpuesto1,\r\n                                           codImpuesto2,\r\n                                           codImpuesto3,\r\n                                           codImpuesto4,\r\n                                           codImpuesto5, trackIDEnvio, trackIDLibro, enviado_sii, enviado_libro \r\n                                   FROM electronica_factura\r\n                                   WHERE " + str + "  ORDER BY folio;";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        lista.Add(new Venta()
        {
          Fe_TipoDTE = 33,
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFactura"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]),
          PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]),
          PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]),
          PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]),
          PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]),
          Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]),
          Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]),
          Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]),
          Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]),
          Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]),
          CodImpuesto1 = ((DbDataReader) mySqlDataReader)["codImpuesto1"].ToString(),
          CodImpuesto2 = ((DbDataReader) mySqlDataReader)["codImpuesto2"].ToString(),
          CodImpuesto3 = ((DbDataReader) mySqlDataReader)["codImpuesto3"].ToString(),
          CodImpuesto4 = ((DbDataReader) mySqlDataReader)["codImpuesto4"].ToString(),
          CodImpuesto5 = ((DbDataReader) mySqlDataReader)["codImpuesto5"].ToString(),
          TrackIDEnvio = ((DbDataReader) mySqlDataReader)["trackIDEnvio"].ToString(),
          TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString(),
          FE_enviado_Sii = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_sii"]),
          FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return lista;
    }

    private List<Venta> buscaFacturaExentaElectronicas(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("ENVIADO"))
        str = "enviado_sii=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                           idFactura,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial, \r\n                                           neto,\r\n                                           iva,\r\n                                           totalExento,\r\n                                           porcentajeIva,                                                          \r\n                                           total,\r\n                                           porcentajeImpuesto1,\r\n                                           porcentajeImpuesto2,\r\n                                           porcentajeImpuesto3,\r\n                                           porcentajeImpuesto4,\r\n                                           porcentajeImpuesto5,\r\n                                           impuesto1,\r\n                                           impuesto2,\r\n                                           impuesto3,\r\n                                           impuesto4,\r\n                                           impuesto5,\r\n                                           codImpuesto1,\r\n                                           codImpuesto2,\r\n                                           codImpuesto3,\r\n                                           codImpuesto4,\r\n                                           codImpuesto5, trackIDEnvio, trackIDLibro  , enviado_sii, enviado_libro \r\n                                   FROM electronica_factura_exenta\r\n                                   WHERE " + str + "  ORDER BY folio";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        lista.Add(new Venta()
        {
          Fe_TipoDTE = 34,
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFactura"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]),
          PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]),
          PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]),
          PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]),
          PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]),
          Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]),
          Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]),
          Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]),
          Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]),
          Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]),
          CodImpuesto1 = ((DbDataReader) mySqlDataReader)["codImpuesto1"].ToString(),
          CodImpuesto2 = ((DbDataReader) mySqlDataReader)["codImpuesto2"].ToString(),
          CodImpuesto3 = ((DbDataReader) mySqlDataReader)["codImpuesto3"].ToString(),
          CodImpuesto4 = ((DbDataReader) mySqlDataReader)["codImpuesto4"].ToString(),
          CodImpuesto5 = ((DbDataReader) mySqlDataReader)["codImpuesto5"].ToString(),
          TrackIDEnvio = ((DbDataReader) mySqlDataReader)["trackIDEnvio"].ToString(),
          TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString(),
          FE_enviado_Sii = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_sii"]),
          FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return lista;
    }

    private List<Venta> buscaNotasCreditoElectronicas(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("CONSUMO_FOLIO"))
        str = "trackIDConsumoFolio=0 AND ((tipoDocumento1=39 || tipoDocumento1=41) || (tipoDocumento2=39 || tipoDocumento2=41) || (tipoDocumento3=39 || tipoDocumento3=41) || (tipoDocumento4=39 || tipoDocumento4=41) || (tipoDocumento5=39 || tipoDocumento5=41))";
      if (tipo.Equals("ENVIADO"))
        str = "enviado_sii=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                           idNotaCredito,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial,  neto, iva,  totalExento,  porcentajeIva,                                                         \r\n                                           total,\r\n                                           porcentajeImpuesto1,\r\n                                           porcentajeImpuesto2,\r\n                                           porcentajeImpuesto3,\r\n                                           porcentajeImpuesto4,\r\n                                           porcentajeImpuesto5,\r\n                                           impuesto1,\r\n                                           impuesto2,\r\n                                           impuesto3,\r\n                                           impuesto4,\r\n                                           impuesto5,\r\n                                           codImpuesto1,\r\n                                           codImpuesto2,\r\n                                           codImpuesto3,\r\n                                           codImpuesto4,\r\n                                           codImpuesto5, trackIDEnvio, trackIDLibro, enviado_sii, enviado_libro                                                                    \r\n                                   FROM electronica_nota_credito\r\n                                   WHERE " + str + "  ORDER BY folio";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        lista.Add(new Venta()
        {
          Fe_TipoDTE = 61,
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaCredito"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]),
          PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]),
          PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]),
          PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]),
          PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]),
          Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]),
          Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]),
          Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]),
          Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]),
          Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]),
          CodImpuesto1 = ((DbDataReader) mySqlDataReader)["codImpuesto1"].ToString(),
          CodImpuesto2 = ((DbDataReader) mySqlDataReader)["codImpuesto2"].ToString(),
          CodImpuesto3 = ((DbDataReader) mySqlDataReader)["codImpuesto3"].ToString(),
          CodImpuesto4 = ((DbDataReader) mySqlDataReader)["codImpuesto4"].ToString(),
          CodImpuesto5 = ((DbDataReader) mySqlDataReader)["codImpuesto5"].ToString(),
          TrackIDEnvio = ((DbDataReader) mySqlDataReader)["trackIDEnvio"].ToString(),
          TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString(),
          FE_enviado_Sii = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_sii"]),
          FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return lista;
    }

    private List<Venta> buscaNotasDevitoElectronicas(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("ENVIADO"))
        str = "enviado_sii=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                           idNotaDebito,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial,  neto, iva, totalExento, porcentajeIva,                                                         \r\n                                           total,\r\n                                           porcentajeImpuesto1,\r\n                                           porcentajeImpuesto2,\r\n                                           porcentajeImpuesto3,\r\n                                           porcentajeImpuesto4,\r\n                                           porcentajeImpuesto5,\r\n                                           impuesto1,\r\n                                           impuesto2,\r\n                                           impuesto3,\r\n                                           impuesto4,\r\n                                           impuesto5,\r\n                                           codImpuesto1,\r\n                                           codImpuesto2,\r\n                                           codImpuesto3,\r\n                                           codImpuesto4,\r\n                                           codImpuesto5, trackIDEnvio, trackIDLibro , enviado_sii, enviado_libro                                                                   \r\n                                   FROM electronica_nota_debito\r\n                                   WHERE  " + str + "  ORDER BY folio";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        lista.Add(new Venta()
        {
          Fe_TipoDTE = 56,
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaDebito"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]),
          PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]),
          PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]),
          PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]),
          PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]),
          Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]),
          Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]),
          Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]),
          Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]),
          Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]),
          CodImpuesto1 = ((DbDataReader) mySqlDataReader)["codImpuesto1"].ToString(),
          CodImpuesto2 = ((DbDataReader) mySqlDataReader)["codImpuesto2"].ToString(),
          CodImpuesto3 = ((DbDataReader) mySqlDataReader)["codImpuesto3"].ToString(),
          CodImpuesto4 = ((DbDataReader) mySqlDataReader)["codImpuesto4"].ToString(),
          CodImpuesto5 = ((DbDataReader) mySqlDataReader)["codImpuesto5"].ToString(),
          TrackIDEnvio = ((DbDataReader) mySqlDataReader)["trackIDEnvio"].ToString(),
          TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString(),
          FE_enviado_Sii = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_sii"]),
          FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return lista;
    }

    private List<Venta> buscaGuiaElectronicas(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("ENVIADO"))
        str = "enviado_sii=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta1 = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                           idGuia,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial, neto, iva, totalExento, porcentajeIva,                                                          \r\n                                           total, estadoDocumento, codigoTipoGuia, facturada, folioFactura,documentoVenta , trackIDEnvio, trackIDLibro , enviado_sii, enviado_libro                                                                \r\n                                   FROM electronica_guia\r\n                                   WHERE " + str + "  ORDER BY folio";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        venta1 = new Venta();
        venta1.Fe_TipoDTE = 52;
        venta1.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idGuia"]);
        venta1.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]);
        venta1.FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]);
        venta1.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString();
        venta1.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        venta1.PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]);
        venta1.Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]);
        venta1.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]);
        venta1.TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]);
        venta1.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]);
        venta1.EstadoDocumento = ((DbDataReader) mySqlDataReader)["estadoDocumento"].ToString();
        venta1.FE_codigoTipoGuia = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoTipoGuia"]);
        venta1.Facturada = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["facturada"]);
        if (venta1.Facturada)
        {
          venta1.FolioFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folioFactura"]);
          venta1.DocumentoVenta = ((DbDataReader) mySqlDataReader)["documentoVenta"].ToString();
        }
        else
        {
          venta1.FolioFactura = 0;
          venta1.DocumentoVenta = "";
        }
        venta1.TrackIDEnvio = ((DbDataReader) mySqlDataReader)["trackIDEnvio"].ToString();
        venta1.TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString();
        venta1.FE_enviado_Sii = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_sii"]);
        venta1.FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"]);
        lista.Add(venta1);
      }
      ((DbDataReader) mySqlDataReader).Close();
      foreach (Venta venta2 in lista)
      {
        if (venta2.Facturada)
          venta2.FechaModificacion = this.ObtieneFechaFacturaElectronica(venta1.FolioFactura);
      }
      return lista;
    }

    private List<Venta> buscaBoletaElectronicas(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("ENVIADO"))
        str = "enviado_sii=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoleta, folio, fechaEmision, fechaVencimiento, rut, digito, razonSocial, neto,                  iva,\r\n                                           totalExento,\r\n                                           porcentajeIva,                                                          \r\n                                           total,\r\n                                           porcentajeImpuesto1,\r\n                                           porcentajeImpuesto2,\r\n                                           porcentajeImpuesto3,\r\n                                           porcentajeImpuesto4,\r\n                                           porcentajeImpuesto5,\r\n                                           impuesto1,\r\n                                           impuesto2,\r\n                                           impuesto3,\r\n                                           impuesto4,\r\n                                           impuesto5,\r\n                                           codImpuesto1,\r\n                                           codImpuesto2,\r\n                                           codImpuesto3,\r\n                                           codImpuesto4,\r\n                                           codImpuesto5, trackIDEnvio, trackIDLibro, enviado_sii, enviado_libro \r\n                                   FROM electronica_boleta\r\n                                   WHERE " + str + "  ORDER BY folio";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        lista.Add(new Venta()
        {
          Fe_TipoDTE = 39,
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString().Length != 0 ? ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString() : "66666666-6",
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          PorcentajeImpuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto1"]),
          PorcentajeImpuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto2"]),
          PorcentajeImpuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto3"]),
          PorcentajeImpuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto4"]),
          PorcentajeImpuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto5"]),
          Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto1"]),
          Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto2"]),
          Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto3"]),
          Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto4"]),
          Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["impuesto5"]),
          CodImpuesto1 = ((DbDataReader) mySqlDataReader)["codImpuesto1"].ToString(),
          CodImpuesto2 = ((DbDataReader) mySqlDataReader)["codImpuesto2"].ToString(),
          CodImpuesto3 = ((DbDataReader) mySqlDataReader)["codImpuesto3"].ToString(),
          CodImpuesto4 = ((DbDataReader) mySqlDataReader)["codImpuesto4"].ToString(),
          CodImpuesto5 = ((DbDataReader) mySqlDataReader)["codImpuesto5"].ToString(),
          TrackIDEnvio = ((DbDataReader) mySqlDataReader)["trackIDEnvio"].ToString(),
          TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString(),
          FE_enviado_Sii = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_sii"]),
          FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return lista;
    }

    public DateTime ObtieneFechaFacturaElectronica(int numFactura)
    {
      DateTime dateTime = new DateTime();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT fechaEmision FROM electronica_factura WHERE folio=@numFactura";
      command.Parameters.AddWithValue("@numFactura", (object) numFactura);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        dateTime = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]);
      ((DbDataReader) mySqlDataReader).Close();
      return dateTime;
    }

    private List<Venta> buscaFacturaPapel(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIADO"))
        str = "enviado_libro=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                           idFactura,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial,\r\n                                           neto,\r\n                                           iva,\r\n                                           '0' AS totalExento,\r\n                                           porcentajeIva,\r\n                                           total, trackIDLibro ,  enviado_libro                                                                  \r\n                                   FROM facturas\r\n                                   WHERE " + str + "  ORDER BY folio";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        lista.Add(new Venta()
        {
          Fe_TipoDTE = 30,
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idFactura"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString(),
          FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return lista;
    }

    private List<Venta> buscaNotaCreditoPapel(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIADO"))
        str = "enviado_libro=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                           idNotaCredito,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial,\r\n                                           neto,\r\n                                           iva,\r\n                                           '0' AS totalExento,\r\n                                           porcentajeIva,\r\n                                           total , trackIDLibro ,  enviado_libro                                                                    \r\n                                   FROM notacredito\r\n                                   WHERE " + str + "  ORDER BY folio";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        lista.Add(new Venta()
        {
          Fe_TipoDTE = 60,
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idNotaCredito"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString(),
          FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return lista;
    }

    private List<Venta> buscaBoletaPapel(List<Venta> lista, string tipo, string desde, string hasta)
    {
      string str = "";
      if (tipo.Equals("ENVIADO"))
        str = "enviado_libro=1 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=0 AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') >= '" + desde + "' AND DATE_FORMAT(fechaEmision, '%Y-%m-%d') <= '" + hasta + "'";
      Venta venta = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                           idBoleta,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial,\r\n                                           neto,\r\n                                           iva,\r\n                                           '0' AS totalExento,\r\n                                           porcentajeIva,\r\n                                           total ,  trackIDLibro ,  enviado_libro                                                                    \r\n                                   FROM boletas\r\n                                   WHERE folio > 0 AND " + str + "  ORDER BY folio";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        lista.Add(new Venta()
        {
          Fe_TipoDTE = 35,
          IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoleta"]),
          Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]),
          FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]),
          Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString(),
          RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString(),
          PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]),
          Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]),
          Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]),
          TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]),
          Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]),
          TrackIDLibro = ((DbDataReader) mySqlDataReader)["trackIDLibro"].ToString(),
          FE_enviado_Libro = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["enviado_libro"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return lista;
    }

    public List<Venta> buscaDocumentosLibroCompra(string filtro)
    {
      List<Venta> list = new List<Venta>();
      string str = filtro;
      Venta venta1 = new Venta();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand)command).CommandText = "SELECT \r\n                                           idCompra,\r\n                                           folio,\r\n                                           fechaEmision,\r\n                                           fechaVencimiento,                                                            \r\n                                           rut,\r\n                                           digito,\r\n                                           razonSocial,\r\n                                           neto, iva, totalExento, porcentajeIva, totalCobrar as total, idTipoDocumentoCompra FROM compras WHERE " + str + " AND enviado_libro=0 AND idTipoDocumentoCompra <> 11 ORDER BY idTipoDocumentoCompra"; /*(idTipoDocumentoCompra = 1 OR idTipoDocumentoCompra = 4 OR idTipoDocumentoCompra = 5 OR idTipoDocumentoCompra = 6 OR idTipoDocumentoCompra = 7 OR idTipoDocumentoCompra = 3)*/
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        Venta venta2 = new Venta();
        venta2.IdFactura = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCompra"]);
        venta2.Folio = Convert.ToInt32(((DbDataReader) mySqlDataReader)["folio"]);
        venta2.FechaEmision = Convert.ToDateTime(((DbDataReader) mySqlDataReader)["fechaEmision"]);
        venta2.Rut = ((DbDataReader) mySqlDataReader)["rut"].ToString() + "-" + ((DbDataReader) mySqlDataReader)["digito"].ToString();
        venta2.RazonSocial = ((DbDataReader) mySqlDataReader)["razonSocial"].ToString();
        venta2.PorcentajeIva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]);
        venta2.Neto = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["neto"]);
        venta2.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["iva"]);
        venta2.TotalExento = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["totalExento"]);
        venta2.Total = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["total"]);
        venta2.IdTipoDocumentoCompra = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTipoDocumentoCompra"]);
        if (venta2.IdTipoDocumentoCompra == 1)
          venta2.Fe_TipoDTE = 30;
        else if (venta2.IdTipoDocumentoCompra == 2)
            venta2.Fe_TipoDTE = 33;
        else if (venta2.IdTipoDocumentoCompra == 3)
            venta2.Fe_TipoDTE = 45;
        else if (venta2.IdTipoDocumentoCompra == 4)
          venta2.Fe_TipoDTE = 46;
        else if (venta2.IdTipoDocumentoCompra == 5)
            venta2.Fe_TipoDTE = 32;
        else if (venta2.IdTipoDocumentoCompra == 6)
          venta2.Fe_TipoDTE = 34;
        else if (venta2.IdTipoDocumentoCompra == 7)
            venta2.Fe_TipoDTE = 60;
        else if (venta2.IdTipoDocumentoCompra == 8)
            venta2.Fe_TipoDTE = 61;
        else if (venta2.IdTipoDocumentoCompra == 9)
            venta2.Fe_TipoDTE = 55;
        else if (venta2.IdTipoDocumentoCompra == 10)
            venta2.Fe_TipoDTE = 56;
        list.Add(venta2);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void actualizaestadoEnvioDTE(List<Venta> lista)
    {
      foreach (Venta venta in lista)
      {
        if (venta.Fe_TipoDTE == 33)
          this.actualizaEstadoEnvioFE(venta.Folio, "ENVIO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 34)
          this.actualizaEstadoEnvioFE_EX(venta.Folio, "ENVIO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 61)
          this.actualizaEstadoEnvioNCE(venta.Folio, "ENVIO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 56)
          this.actualizaEstadoEnvioNDE(venta.Folio, "ENVIO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 52)
          this.actualizaEstadoEnvioGuiaElectronica(venta.Folio, "ENVIO", venta.TrackIDEnvio);
      }
    }

    public void actualizaestadoEnvioConsumoFolios(List<Venta> lista)
    {
      foreach (Venta venta in lista)
      {
        if (venta.Fe_TipoDTE == 61)
          this.actualizaEstadoEnvioNCE(venta.Folio, "CONSUMO_FOLIOS", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 39)
          this.actualizaEstadoEnvioBoletaElectronica(venta.Folio, "ENVIO", venta.TrackIDEnvio);
      }
    }

    public void desactivaEnvioDTE(List<Venta> lista)
    {
      foreach (Venta venta in lista)
      {
        if (venta.Fe_TipoDTE == 33)
          this.actualizaEstadoEnvioFE(venta.Folio, "DESACTIVA_ENVIO", "");
        if (venta.Fe_TipoDTE == 34)
          this.actualizaEstadoEnvioFE_EX(venta.Folio, "DESACTIVA_ENVIO", "");
        if (venta.Fe_TipoDTE == 61)
          this.actualizaEstadoEnvioNCE(venta.Folio, "DESACTIVA_ENVIO", "");
        if (venta.Fe_TipoDTE == 56)
          this.actualizaEstadoEnvioNDE(venta.Folio, "DESACTIVA_ENVIO", "");
        if (venta.Fe_TipoDTE == 52)
          this.actualizaEstadoEnvioGuiaElectronica(venta.Folio, "DESACTIVA_ENVIO", "");
      }
    }

    public void desactivaEnvioLibro(List<Venta> lista)
    {
      foreach (Venta venta in lista)
      {
        if (venta.Fe_TipoDTE == 33)
          this.actualizaEstadoEnvioFE(venta.Folio, "DESACTIVA_LIBRO", "");
        if (venta.Fe_TipoDTE == 34)
          this.actualizaEstadoEnvioFE_EX(venta.Folio, "DESACTIVA_LIBRO", "");
        if (venta.Fe_TipoDTE == 61)
          this.actualizaEstadoEnvioNCE(venta.Folio, "DESACTIVA_LIBRO", "");
        if (venta.Fe_TipoDTE == 56)
          this.actualizaEstadoEnvioNDE(venta.Folio, "DESACTIVA_LIBRO", "");
        if (venta.Fe_TipoDTE == 52)
          this.actualizaEstadoEnvioGuiaElectronica(venta.Folio, "DESACTIVA_LIBRO", "");
        if (venta.Fe_TipoDTE == 30)
          this.actualizaEstadoEnvioFacturaPapel(venta.Folio, "DESACTIVA_LIBRO", "");
        if (venta.Fe_TipoDTE == 35)
          this.actualizaEstadoEnvioBoletaPapel(venta.Folio, "DESACTIVA_LIBRO", "");
        if (venta.Fe_TipoDTE == 60)
          this.actualizaEstadoEnvioNotaCreditoPapel(venta.Folio, "DESACTIVA_LIBRO", "");
        if (venta.Fe_TipoDTE == 39)
          this.actualizaEstadoEnvioBoletaElectronica(venta.Folio, "DESACTIVA_LIBRO", "");
      }
    }

    public void actualizaEstadoLibroDTE(List<Venta> lista)
    {
      foreach (Venta venta in lista)
      {
        if (venta.Fe_TipoDTE == 33)
          this.actualizaEstadoEnvioFE(venta.Folio, "LIBRO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 34)
          this.actualizaEstadoEnvioFE_EX(venta.Folio, "LIBRO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 61)
          this.actualizaEstadoEnvioNCE(venta.Folio, "LIBRO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 56)
          this.actualizaEstadoEnvioNDE(venta.Folio, "LIBRO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 52)
          this.actualizaEstadoEnvioGuiaElectronica(venta.Folio, "LIBRO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 30)
          this.actualizaEstadoEnvioFacturaPapel(venta.Folio, "LIBRO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 35)
          this.actualizaEstadoEnvioBoletaPapel(venta.Folio, "LIBRO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 60)
          this.actualizaEstadoEnvioNotaCreditoPapel(venta.Folio, "LIBRO", venta.TrackIDEnvio);
        if (venta.Fe_TipoDTE == 39)
          this.actualizaEstadoEnvioBoletaElectronica(venta.Folio, "LIBRO", venta.TrackIDEnvio);
      }
    }

    public void actualizaEstadoEnvioFE(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=1, trackIDEnvio='" + trackID + "'";
      if (tipo.Equals("DESACTIVA_ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_factura SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoEnvioBoletaElectronica(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=1, trackIDEnvio='" + trackID + "'";
      if (tipo.Equals("DESACTIVA_ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_boleta SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoEnvioFE_EX(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=1, trackIDEnvio='" + trackID + "'";
      if (tipo.Equals("DESACTIVA_ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_factura_exenta SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoEnvioFacturaPapel(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE facturas SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoEnvioNotaCreditoPapel(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE notacredito SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoEnvioBoletaPapel(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE boletas SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoEnvioNCE(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=1, trackIDEnvio='" + trackID + "'";
      if (tipo.Equals("CONSUMO_FOLIOS"))
        str = "trackIDConsumoFolio='" + trackID + "'";
      if (tipo.Equals("DESACTIVA_ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_nota_credito SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoEnvioNDE(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=1, trackIDEnvio='" + trackID + "'";
      if (tipo.Equals("DESACTIVA_ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_nota_debito SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoEnvioGuiaElectronica(int folio, string tipo, string trackID)
    {
      string str = "";
      if (tipo.Equals("ENVIO"))
        str = "enviado_sii=1, trackIDEnvio='" + trackID + "'";
      if (tipo.Equals("DESACTIVA_ENVIO"))
        str = "enviado_sii=0";
      if (tipo.Equals("DESACTIVA_LIBRO"))
        str = "enviado_libro=0";
      if (tipo.Equals("LIBRO"))
        str = "enviado_libro=1, trackIDLibro='" + trackID + "'";
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE electronica_guia SET " + str + " WHERE folio= @folio";
      command.Parameters.AddWithValue("@folio", (object) folio);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void actualizaEstadoLibroCompra(List<Venta> lista)
    {
      foreach (Venta venta in lista)
        this.actualizaEstadoCompra(venta.IdFactura);
    }

    public void actualizaEstadoCompra(int idCompra)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE compras SET enviado_libro=1 WHERE idCompra=@idCompra";
      command.Parameters.AddWithValue("@idCompra", (object) idCompra);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public int buscaDocumentosSinEnviarParaAlerta()
    {
      return Enumerable.Count<Venta>((IEnumerable<Venta>) this.buscaDosumentosSinEnviar());
    }
  }
}
