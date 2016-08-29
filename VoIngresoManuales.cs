using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptusoft
{
    class VoIngresoManuales
    {
        private Conexion conexion = Conexion.getConecta();
        public void IngresoManual(string folio, string total, string neto, string iva, string exento, string fecha, string tipo_doc)
        {
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "insert into ingresos_manuales"
            + "(folio, tipo, valor_neto, valor_exento, valor_total, valor_iva, fecha)" +
            "values(@folio,@tipoDocumento, @neto,  @exento, @total, @iva, @fecha );";
            command.Parameters.AddWithValue("@folio", folio);
            command.Parameters.AddWithValue("@tipoDocumento", tipo_doc);
            command.Parameters.AddWithValue("@fecha", fecha);
            command.Parameters.AddWithValue("@neto", neto);
            command.Parameters.AddWithValue("@iva", iva);
            command.Parameters.AddWithValue("@exento", exento);
            command.Parameters.AddWithValue("@total", total);
            ((DbCommand)command).ExecuteNonQuery();
        }
        public void EliminaIngreso(int numero)
        {
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "delete from ingresos_manuales"+
            " where folio = @tipoDocumento;";
            command.Parameters.AddWithValue("@tipoDocumento", numero);
            ((DbCommand)command).ExecuteNonQuery();
        }
        public void ActualizaIngreso(int id, string total, string neto, string iva, string exento, string fecha, string tipo_doc)
        {
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "update ingresos_manuales set "
            + "tipo = @tipoDocumento, valor_neto = @neto, "+
            "valor_exento = @exento, valor_total = @total, valor_iva = @iva, fecha = @fecha" +
            " where folio = @id;";
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@tipoDocumento", tipo_doc);
            command.Parameters.AddWithValue("@fecha", fecha);
            command.Parameters.AddWithValue("@neto", neto);
            command.Parameters.AddWithValue("@iva", iva);
            command.Parameters.AddWithValue("@exento", exento);
            command.Parameters.AddWithValue("@total", total);
            ((DbCommand)command).ExecuteNonQuery();
        }
        public DataTable recuperaIngreso(int id)
        {
            string str = "select * from ingresos_manuales where folio = @id;";
            DataTable dataTable = new DataTable();
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            command.Parameters.AddWithValue("@id", id);
            ((DbCommand)command).CommandText = str;
            ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
            return dataTable;
        }
        public DataTable select(string filtro)
        {
            string str = "select * from ingresos_manuales where "+filtro+";";
            DataTable dataTable = new DataTable();
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = str;
            ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
            return dataTable;
    }
          }
}
