 
// Type: Aptusoft.Conexion
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Xml;

namespace Aptusoft
{
  public class Conexion
  {
    private static Conexion conecta = (Conexion) null;
    private MySqlConnection conexionMySql;
    private string _server;
    private string _user;
    private string _pass;
    private string _base;
    private static string _empresa;

    public MySqlConnection ConexionMySql
    {
      get
      {
        return this.conexionMySql;
      }
      set
      {
        this.conexionMySql = value;
      }
    }

    private Conexion()
    {
      this.cargarDatos();
      this.conexionMySql = new MySqlConnection("Database=" + this._base + "; Data Source=" + this._server + "; User Id=" + this._user + "; Password=" + this._pass + "; ");
      ((DbConnection) this.conexionMySql).Open();
    }

    private Conexion(string s, string b, string u, string p)
    {
      this.conexionMySql = new MySqlConnection("Database=" + b + "; Data Source=" + s + "; User Id=" + u + "; Password=" + p);
      ((DbConnection) this.conexionMySql).Open();
    }

    private bool cargarDatos()
    {
      try
      {
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        string filterExpression = "principal=1";
        DataRow[] dataRowArray = dataSet.Tables["conexion"].Select(filterExpression);
        for (int index = 0; index < dataRowArray.Length; ++index)
        {
          this._server = dataRowArray[index]["server"].ToString();
          this._base = dataRowArray[index]["base"].ToString();
          this._user = dataRowArray[index]["user"].ToString();
          this._pass = dataRowArray[index]["pass"].ToString();
          Conexion._empresa = dataRowArray[index]["empresa"].ToString();
        }
        return true;
      }
      catch
      {
        this.creaXML();
        return false;
      }
    }

    private void creaXML()
    {
        respaldo_xml_config rp = new respaldo_xml_config();
        rp.recupera();
    }

    public static Conexion getConecta()
    {
      if (Conexion.conecta == null)
        Conexion.conecta = new Conexion();
      if (((DbConnection) Conexion.conecta.conexionMySql).State != ConnectionState.Open)
        Conexion.conecta = new Conexion();
      return Conexion.conecta;
    }

    public static Conexion reconexion()
    {
      Conexion.conecta.cerrarConexion();
      Conexion.conecta = new Conexion();
      return Conexion.conecta;
    }

    public static Conexion pruebaConexion(string s, string b, string u, string p)
    {
      if (Conexion.conecta == null)
        Conexion.conecta = new Conexion(s, b, u, p);
      return Conexion.conecta;
    }

    public void cerrarConexion()
    {
      ((DbConnection) this.conexionMySql).Close();
      Conexion.conecta = (Conexion) null;
    }
  }
}
