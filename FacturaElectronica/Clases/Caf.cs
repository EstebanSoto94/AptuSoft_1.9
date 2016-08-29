 
// Type: Aptusoft.FacturaElectronica.Clases.Caf
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class Caf
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaCAF(CafVO caVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO electronica_caf (tipoDocumento, rutaArchivo, desde, hasta, activo)\r\n                                    VALUES(@tipoDocumento, @rutaArchivo, @desde, @hasta, @activo)";
      command.Parameters.AddWithValue("@tipoDocumento", (object) caVO.TipoDocumento);
      command.Parameters.AddWithValue("@rutaArchivo", (object) caVO.RutaArchivo);
      command.Parameters.AddWithValue("@desde", (object) caVO.Desde);
      command.Parameters.AddWithValue("@hasta", (object) caVO.Hasta);
      command.Parameters.AddWithValue("@activo", (caVO.Activo ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<CafVO> listadoCaf(int td)
    {
      List<CafVO> list = new List<CafVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idCaf, tipoDocumento, rutaArchivo, desde, hasta, activo FROM electronica_caf WHERE tipoDocumento=@tipoDocumento ORDER BY idCaf DESC";
      command.Parameters.AddWithValue("@tipoDocumento", (object) td);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        CafVO cafVo = new CafVO();
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 33)
          cafVo.TipoDocumentoNombre = "Factura Electronica";
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 34)
          cafVo.TipoDocumentoNombre = "Factura Exenta Electronica";
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 39)
          cafVo.TipoDocumentoNombre = "Boleta Electronica";
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 41)
          cafVo.TipoDocumentoNombre = "Boleta no afecta o exenta Electronica";
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 61)
          cafVo.TipoDocumentoNombre = "Nota de Credito Electronica";
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 56)
          cafVo.TipoDocumentoNombre = "Nota de Debito Electronica";
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 52)
          cafVo.TipoDocumentoNombre = "Guia de Despacho Electronica";
        cafVo.Desde = Convert.ToInt32(((DbDataReader) mySqlDataReader)["desde"].ToString());
        cafVo.Hasta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["hasta"].ToString());
        cafVo.Activo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["activo"]);
        list.Add(cafVo);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public CafVO buscaCafID(int id)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idCaf, tipoDocumento, rutaArchivo, desde, hasta, activo FROM electronica_caf WHERE idCaf=@id ";
      command.Parameters.AddWithValue("@id", (object) id);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      CafVO cafVo = new CafVO();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        cafVo = new CafVO();
        cafVo.IdCaf = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idCaf"].ToString());
        cafVo.RutaArchivo = ((DbDataReader) mySqlDataReader)["desde"].ToString();
        cafVo.TipoDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString());
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 33)
          cafVo.TipoDocumentoNombre = "Factura Electronica";
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 61)
          cafVo.TipoDocumentoNombre = "Nota de Credito Electronica";
        if (Convert.ToInt32(((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()) == 56)
          cafVo.TipoDocumentoNombre = "Nota de Debito Electronica";
        cafVo.Desde = Convert.ToInt32(((DbDataReader) mySqlDataReader)["desde"].ToString());
        cafVo.Hasta = Convert.ToInt32(((DbDataReader) mySqlDataReader)["hasta"].ToString());
        cafVo.Activo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["activo"]);
      }
      ((DbDataReader) mySqlDataReader).Close();
      return cafVo;
    }

    public string archivoCaf(int td, int folio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT rutaArchivo FROM electronica_caf WHERE tipoDocumento=@tipoDocumento AND desde <= @folio and hasta >= @folio";
      command.Parameters.AddWithValue("@tipoDocumento", (object) td);
      command.Parameters.AddWithValue("@folio", (object) folio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      string str = "";
      while (((DbDataReader) mySqlDataReader).Read())
        str = ((DbDataReader) mySqlDataReader)["rutaArchivo"].ToString();
      ((DbDataReader) mySqlDataReader).Close();
      return str;
    }

    public bool buscaCafArchivoConFolios(int tipoDoc, int desde, int hasta)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT tipoDocumento FROM electronica_caf WHERE tipoDocumento=@tipoDocumento AND desde=@desde AND hasta=@hasta ";
      command.Parameters.AddWithValue("@tipoDocumento", (object) tipoDoc);
      command.Parameters.AddWithValue("@desde", (object) desde);
      command.Parameters.AddWithValue("@hasta", (object) hasta);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }
  }
}
