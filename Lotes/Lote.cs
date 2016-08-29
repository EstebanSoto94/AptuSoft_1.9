 
// Type: Aptusoft.Lotes.Lote
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft.Lotes
{
  public class Lote
  {
    private Conexion conexion = Conexion.getConecta();

    public void RegistraLote(List<LoteVO> lista)
    {
      foreach (LoteVO loteVo1 in lista)
      {
        LoteVO loteVo2 = this.BuscaLote(loteVo1.CodigoProducto, loteVo1.Lote, loteVo1.Bodega);
        if (loteVo2.IdLote == 0)
        {
          int num = this.GuardaLote(loteVo1);
          loteVo1.IdLote = num;
        }
        if (loteVo1.IdLote == 0)
          loteVo1.IdLote = loteVo2.IdLote;
        this.GuardaDetalleLote(loteVo1);
      }
    }

    private int GuardaLote(LoteVO lo)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO lotes (\r\n                                                        lote,\r\n                                                        codigoProducto,                                                        \r\n                                                        bodega,\r\n                                                        fechaCreacion\r\n                                                     ) VALUES\r\n                                                    (\r\n                                                        @lote,\r\n                                                        @codigoProducto,                                                       \r\n                                                        @bodega,\r\n                                                        @fechaCreacion\r\n                                                    )";
      command.Parameters.AddWithValue("@lote", (object) lo.Lote);
      command.Parameters.AddWithValue("@codigoProducto", (object) lo.CodigoProducto);
      command.Parameters.AddWithValue("@bodega", (object) lo.Bodega);
      command.Parameters.AddWithValue("@fechaCreacion", (object) DateTime.Now);
      ((DbCommand) command).ExecuteNonQuery();
      ((DbCommand) command).CommandText = "SELECT DISTINCT LAST_INSERT_ID() FROM lotes";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      int num = 0;
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0].ToString());
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    private void GuardaDetalleLote(LoteVO loD)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO lotes_detalle (\r\n                                                        idLoteLinea,\r\n                                                        lote, codigo,\r\n                                                        documento,\r\n                                                        idDocumento,\r\n                                                        folioDocumento,\r\n                                                        cantidad,\r\n                                                        accion, \r\n                                                        tipoDocumento,\r\n                                                        fechaIngreso\r\n                                                     ) VALUES\r\n                                                    (\r\n                                                        @idLoteLinea,\r\n                                                        @lote, @codigo,\r\n                                                        @documento,\r\n                                                        @idDocumento,\r\n                                                        @folioDocumento,\r\n                                                        @cantidad,\r\n                                                        @accion,\r\n                                                        @tipoDocumento,\r\n                                                        @fechaIngreso\r\n                                                    )";
      command.Parameters.AddWithValue("@idLoteLinea", (object) loD.IdLote);
      command.Parameters.AddWithValue("@lote", (object) loD.Lote);
      command.Parameters.AddWithValue("@codigo", (object) loD.CodigoProducto);
      command.Parameters.AddWithValue("@documento", (object) loD.Documento);
      command.Parameters.AddWithValue("@idDocumento", (object) loD.IdDocumento);
      command.Parameters.AddWithValue("@folioDocumento", (object) loD.FolioDocumento);
      command.Parameters.AddWithValue("@cantidad", (object) loD.Cantidad);
      command.Parameters.AddWithValue("@accion", (object) loD.Accion);
      command.Parameters.AddWithValue("@tipoDocumento", (object) loD.TipoDocumento);
      command.Parameters.AddWithValue("@fechaIngreso", (object) DateTime.Now);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<LoteVO> ListaLotePorDocumento(string tipoDocumento, string documento, int idDocumento)
    {
      List<LoteVO> list = new List<LoteVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT\r\n                                            l.idLote,\r\n                                            l.lote,\r\n                                            l.codigoProducto,                                            \r\n                                            l.bodega,\r\n                                            d.idDetalleLote,                                                                                        \r\n                                            d.documento,\r\n                                            d.idDocumento,\r\n                                            d.folioDocumento,\r\n                                            d.cantidad,\r\n                                            d.accion,\r\n                                            d.tipoDocumento\r\n                                    FROM lotes l INNER JOIN lotes_detalle d ON l.idLote = d.idLoteLinea\r\n                                    WHERE\r\n                                        d.tipoDocumento=@tipoDocumento AND\r\n                                        d.documento=@documento AND\r\n                                        d.idDocumento=@idDocumento\r\n                                    ORDER BY l.idLote";
      command.Parameters.AddWithValue("@tipoDocumento", (object) tipoDocumento);
      command.Parameters.AddWithValue("@documento", (object) documento);
      command.Parameters.AddWithValue("@idDocumento", (object) idDocumento);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      LoteVO loteVo = new LoteVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new LoteVO()
        {
          IdLote = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idLote"].ToString()),
          Lote = ((DbDataReader) mySqlDataReader)["lote"].ToString(),
          CodigoProducto = ((DbDataReader) mySqlDataReader)["codigoProducto"].ToString(),
          Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString()),
          IdDetalleLote = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleLote"].ToString()),
          Documento = ((DbDataReader) mySqlDataReader)["documento"].ToString(),
          IdDocumento = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDocumento"].ToString()),
          FolioDocumento = Convert.ToInt64(((DbDataReader) mySqlDataReader)["folioDocumento"].ToString()),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString()),
          Accion = ((DbDataReader) mySqlDataReader)["accion"].ToString(),
          TipoDocumento = ((DbDataReader) mySqlDataReader)["tipoDocumento"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<LoteVO> ListaDetalleLotePorIdLote(int idLote)
    {
      List<LoteVO> list = new List<LoteVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT  idLoteLinea, \r\n                                            cantidad,\r\n                                            accion                                            \r\n                                    FROM lotes_detalle\r\n                                    WHERE                                        \r\n                                        idLoteLinea=@idLoteLinea";
      command.Parameters.AddWithValue("@idLoteLinea", (object) idLote);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      LoteVO loteVo = new LoteVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new LoteVO()
        {
          IdLote = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idLoteLinea"].ToString()),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString()),
          Accion = ((DbDataReader) mySqlDataReader)["accion"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<LoteVO> ListaLotePorCodigo(string codigo)
    {
      List<LoteVO> list1 = new List<LoteVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT                                           \r\n                                            l.lote,                                                                                        \r\n                                            l.bodega,  \r\n                                            d.idDetalleLote,                                          \r\n                                            d.cantidad,\r\n                                            d.accion                                            \r\n                                    FROM lotes l INNER JOIN lotes_detalle d ON l.idLote = d.idLoteLinea\r\n                                    WHERE\r\n                                        l.codigoProducto=@codigo AND d.documento != 'TICKET'                                       \r\n                                    ORDER BY d.accion";
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      LoteVO loteVo1 = new LoteVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list1.Add(new LoteVO()
        {
          Lote = ((DbDataReader) mySqlDataReader)["lote"].ToString(),
          Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString()),
          IdDetalleLote = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idDetalleLote"].ToString()),
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString()),
          Accion = ((DbDataReader) mySqlDataReader)["accion"].ToString(),
          Valida = false
        });
      ((DbDataReader) mySqlDataReader).Close();
      List<LoteVO> list2 = new List<LoteVO>();
      if (list1.Count > 0)
      {
        foreach (LoteVO loteVo2 in list1)
        {
          if (!loteVo2.Valida)
          {
            foreach (LoteVO loteVo3 in list1)
            {
              if (!loteVo3.Valida && (loteVo2.IdDetalleLote != loteVo3.IdDetalleLote && loteVo2.Lote == loteVo3.Lote && loteVo2.Bodega == loteVo3.Bodega))
              {
                if (loteVo3.Accion.Equals("INGRESA"))
                  loteVo2.Cantidad += loteVo3.Cantidad;
                else
                  loteVo2.Cantidad -= loteVo3.Cantidad;
                loteVo2.Valida = true;
                loteVo3.Valida = true;
              }
            }
            list2.Add(loteVo2);
          }
        }
      }
      return list2;
    }

    public LoteVO BuscaLote(string codigo, string lot, int bod)
    {
      List<LoteVO> list = new List<LoteVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT\r\n                                            idLote,\r\n                                            lote,\r\n                                            codigoProducto,                                            \r\n                                            bodega\r\n                                    FROM lotes\r\n                                WHERE codigoProducto=@codigo AND lote=@lote AND bodega=@bod ORDER BY idLote";
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      command.Parameters.AddWithValue("@lote", (object) lot);
      command.Parameters.AddWithValue("@bod", (object) bod);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      LoteVO loteVo = new LoteVO();
      loteVo.IdLote = 0;
      while (((DbDataReader) mySqlDataReader).Read())
      {
        loteVo = new LoteVO();
        loteVo.IdLote = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idLote"].ToString());
        loteVo.Lote = ((DbDataReader) mySqlDataReader)["lote"].ToString();
        loteVo.CodigoProducto = ((DbDataReader) mySqlDataReader)["codigoProducto"].ToString();
        loteVo.Bodega = Convert.ToInt32(((DbDataReader) mySqlDataReader)["bodega"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      return loteVo;
    }

    public Decimal BuscaLoteDisponible(string codigo, string lot, int bod)
    {
      List<LoteVO> list = new List<LoteVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT\r\n                                            d.cantidad,\r\n                                            d.accion\r\n                                    FROM lotes l INNER JOIN lotes_detalle d ON l.idLote = d.idLoteLinea\r\n                                    WHERE\r\n                                            l.lote=@lote AND\r\n                                            l.codigoProducto=@codigo AND\r\n                                            l.bodega=@bodega\r\n                                    ORDER BY l.idLote";
      command.Parameters.AddWithValue("@lote", (object) lot);
      command.Parameters.AddWithValue("@codigo", (object) codigo);
      command.Parameters.AddWithValue("@bodega", (object) bod);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      new LoteVO().IdLote = 0;
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new LoteVO()
        {
          Cantidad = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["cantidad"].ToString()),
          Accion = ((DbDataReader) mySqlDataReader)["accion"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      Decimal num1 = new Decimal(0);
      if (list.Count > 0)
      {
        Decimal num2 = new Decimal(0);
        Decimal num3 = new Decimal(0);
        foreach (LoteVO loteVo in list)
        {
          if (loteVo.Accion.Equals("INGRESA"))
            num2 += loteVo.Cantidad;
          if (loteVo.Accion.Equals("SALE"))
            num3 += loteVo.Cantidad;
        }
        num1 = num2 - num3;
      }
      return num1;
    }

    public void EliminaDetalleLote(int idLote)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM lotes_detalle\r\n                                                    WHERE idDetalleLote=@idLote";
      command.Parameters.AddWithValue("@idLote", (object) idLote);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public DataTable InformePorLote(string filtro)
    {
      string str = "SELECT\r\n                                            l.idLote,\r\n                                            l.lote,\r\n                                            l.codigoProducto,                                            \r\n                                            l.bodega, l.fechaCreacion,\r\n                                            d.idDetalleLote,                                                                                        \r\n                                            d.documento,\r\n                                            d.idDocumento,\r\n                                            d.folioDocumento,\r\n                                            d.cantidad,\r\n                                            d.accion,\r\n                                            d.tipoDocumento, d.fechaIngreso\r\n                                    FROM lotes l INNER JOIN lotes_detalle d ON l.idLote = d.idLoteLinea\r\n                                    WHERE  " + filtro + " ORDER BY d.idDetalleLote";
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }
  }
}
