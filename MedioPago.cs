 
// Type: Aptusoft.MedioPago
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Aptusoft
{
  public class MedioPago
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaMedioPago(MedioPagoVO mpVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO mediopago (nombreMedioPago, liquida, codigoFiscal, usaVoucher) VALUES(@Nombre, @Liquida, @CodigoFiscal, @usaVoucher)";
      command.Parameters.AddWithValue("@Nombre", (object) mpVO.NombreMedioPago);
      command.Parameters.AddWithValue("@Liquida", (mpVO.Liquida ? 1 : 0));
      command.Parameters.AddWithValue("@CodigoFiscal", (object) mpVO.CodigoFiscal);
      command.Parameters.AddWithValue("@usaVoucher", (mpVO.UsaVoucher ? 1 : 0));
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();
      }
    }

    public void actualizaMEDIO(MedioPagoVO mpVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE mediopago SET nombreMedioPago=@Nombre, liquida=@Liquida, codigoFiscal=@CodigoFiscal, usaVoucher=@usaVoucher WHERE idMedioPago=@IdMedio";
      command.Parameters.AddWithValue("@Nombre", (object) mpVO.NombreMedioPago);
      command.Parameters.AddWithValue("@Liquida", (mpVO.Liquida ? 1 : 0));
      command.Parameters.AddWithValue("@IdMedio", (object) mpVO.IdMedioPago);
      command.Parameters.AddWithValue("@CodigoFiscal", (object) mpVO.CodigoFiscal);
      command.Parameters.AddWithValue("@usaVoucher", (mpVO.UsaVoucher ? 1 : 0));
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();
      }
    }

    public void eliminaMEDIO(int idMedio)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM mediopago WHERE idMedioPago=@IdMedio";
      command.Parameters.AddWithValue("@IdMedio", (object) idMedio);
      if (conexion.ConexionMySql.State != ConnectionState.Open)
      {
          int con = 0;
          do
          {
              con++;
              try
              {
                  conexion.ConexionMySql.Open();
              }
              catch { conexion.ConexionMySql.Close(); }
          } while (conexion.ConexionMySql.State != ConnectionState.Open && con < 10);
      }
      else
      {
          ((DbCommand)command).ExecuteNonQuery();
      }
    }

    public DataTable listaMediosPago()
    {
      DataTable dataTable = new DataTable();
      ((DbDataAdapter) new MySqlDataAdapter("SELECT idMedioPago, nombreMedioPago FROM mediopago ORDER BY idMedioPago", this.conexion.ConexionMySql)).Fill(dataTable);
      DataRow row = dataTable.NewRow();
      row[0] = (object) 0;
      row[1] = (object) "[SELECCIONE]";
      dataTable.Rows.Add(row);
      dataTable.DefaultView.Sort = "idMedioPago ASC";
      return dataTable;
    }

    public List<MedioPagoVO> listaMediosPagoVenta()
    {
      List<MedioPagoVO> list = new List<MedioPagoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idMedioPago, nombreMedioPago, liquida, usaVoucher FROM mediopago ORDER BY idMedioPago";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new MedioPagoVO()
      {
        IdMedioPago = 0,
        NombreMedioPago = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new MedioPagoVO()
        {
          IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"].ToString()),
          NombreMedioPago = ((DbDataReader) mySqlDataReader)["nombreMedioPago"].ToString(),
          Liquida = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["liquida"]),
          UsaVoucher = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["usaVoucher"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<MedioPagoVO> listaMediosPagoVentaFiscal()
    {
      List<MedioPagoVO> list = new List<MedioPagoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idMedioPago, nombreMedioPago, liquida, codigoFiscal, usaVoucher FROM mediopago ORDER BY idMedioPago";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      list.Add(new MedioPagoVO()
      {
        IdMedioPago = 0,
        NombreMedioPago = "[SELECCIONE]"
      });
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new MedioPagoVO()
        {
          IdMedioPago = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idMedioPago"].ToString()),
          NombreMedioPago = ((DbDataReader) mySqlDataReader)["nombreMedioPago"].ToString(),
          Liquida = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["liquida"]),
          CodigoFiscal = Convert.ToInt32(((DbDataReader) mySqlDataReader)["codigoFiscal"]),
          UsaVoucher = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["usaVoucher"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public DataTable listaMediosPagoGrilla()
    {
      DataTable dataTable = new DataTable();
      ((DbDataAdapter) new MySqlDataAdapter("SELECT idMedioPago, nombreMedioPago, liquida, codigoFiscal, usaVoucher FROM mediopago ORDER BY idMedioPago", this.conexion.ConexionMySql)).Fill(dataTable);
      dataTable.NewRow();
      return dataTable;
    }

    public bool buscaMedioNombre(string _medio)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT nombreMedioPago FROM mediopago WHERE nombreMedioPago = @Medio";
      command.Parameters.AddWithValue("@Medio", (object) _medio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public bool buscaCodigoFiscal(string codigo)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT codigoFiscal FROM mediopago WHERE codigoFiscal = @Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) codigo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        flag = true;
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public int obtenerCodigoFiscal()
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT MAX(codigoFiscal)+1 FROM mediopago";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = ((DbDataReader) mySqlDataReader)[0].ToString().Length <= 0 ? 1 : Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }

    public int obtieneEstadoLiquida(int idMedio)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT liquida FROM mediopago WHERE idMedioPago=@idMedioPago";
      command.Parameters.AddWithValue("@idMedioPago", (object) idMedio);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        num = Convert.ToInt32(((DbDataReader) mySqlDataReader)[0]);
      ((DbDataReader) mySqlDataReader).Close();
      return num;
    }
  }
}
