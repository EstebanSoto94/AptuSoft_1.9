 
// Type: Aptusoft.Boton
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Aptusoft
{
  public class Boton
  {
    private Conexion conexion = Conexion.getConecta();

    public void registraBotones(List<BotonVO> lista)
    {
      this.eliminaBoton();
      foreach (BotonVO bo in lista)
        this.guardaBoton(bo);
    }

    private void guardaBoton(BotonVO bo)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO botones_comanda (nombre, idTexto, textoBoton) VALUES(@nombre, @idTexto, @textoBoton)";
      command.Parameters.AddWithValue("@nombre", (object) bo.Nombre);
      command.Parameters.AddWithValue("@idTexto", (object) bo.IdTexto);
      command.Parameters.AddWithValue("@textoBoton", (object) bo.TextoBoton);
      ((DbCommand) command).ExecuteNonQuery();
    }

    private void eliminaBoton()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM botones_comanda";
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<BotonVO> listaBotones(string filtro)
    {
      List<BotonVO> list = new List<BotonVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idBoton, nombre, idTexto, textoBoton FROM botones_comanda " + filtro + " ORDER BY idBoton";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      BotonVO botonVo = new BotonVO();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new BotonVO()
        {
          IdBoton = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idBoton"].ToString()),
          Nombre = ((DbDataReader) mySqlDataReader)["nombre"].ToString(),
          IdTexto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["idTexto"].ToString()),
          TextoBoton = ((DbDataReader) mySqlDataReader)["textoBoton"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
