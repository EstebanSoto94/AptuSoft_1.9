using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace Aptusoft.Maquinaria
{
    public class Estado
    {
        private Conexion conn = Conexion.getConecta();

        public void agregarEstado(EstadoVO es)
        {
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "INSERT INTO maquinaria_estado (estado) VALUES(@estado)";
            command.Parameters.AddWithValue("@estado", (object)es.estado);
            ((DbCommand)command).ExecuteNonQuery();
        }

        public DataSet listaEstados()
        {
            DataSet dataSet = new DataSet();
            ((DataAdapter)new MySqlDataAdapter("SELECT idEstado, estado FROM maquinaria_estado ORDER BY idEstado", this.conn.ConexionMySql)).Fill(dataSet);
            return dataSet;
        }

        public DataTable listaEstadosMaquinaria()
        {
            DataTable estados = new DataTable();

            try
            {
                Conexion conecta = Conexion.getConecta();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM maquinaria_estado", conecta.ConexionMySql);

                MySqlDataReader Reader;
                Reader = consulta.ExecuteReader();
                estados.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return estados;
        }

        public List<EstadoVO> listaEstadosArriendo()
        {
            List<EstadoVO> list = new List<EstadoVO>();
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "SELECT idEstado, estado FROM maquinaria_estado ORDER BY idEstado";
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            list.Add(new EstadoVO()
            {
                idEstado = 0,
                estado = "[SELECCIONE]"
            });
            while (((DbDataReader)mySqlDataReader).Read())
                list.Add(new EstadoVO()
                {
                    idEstado = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idEstado"].ToString()),
                    estado = ((DbDataReader)mySqlDataReader)["estado"].ToString(),
                });
            ((DbDataReader)mySqlDataReader).Close();
            return list;
        }

        public void modificaEstado(EstadoVO es)
        {
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "UPDATE maquinaria_estado SET estado=@estado WHERE idEstado=@idEstado";
            command.Parameters.AddWithValue("@estado", (object)es.estado);
            command.Parameters.AddWithValue("@idEstado", (object)es.idEstado);
            ((DbCommand)command).ExecuteNonQuery();
        }

        public void eliminaEstado(int _id)
        {
            string format = "DELETE FROM maquinaria_estado WHERE idEstado={0}";
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = string.Format(format, (object)_id);
            ((DbCommand)command).ExecuteNonQuery();
        }

        public EstadoVO buscaEstadoId(int _ides)
        {
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "SELECT idEstado, estado FROM maquinaria_estado WHERE idEstado = @idEstado";
            command.Parameters.AddWithValue("@idEstado", (object)_ides);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            EstadoVO estadoVo = new EstadoVO();
            while (((DbDataReader)mySqlDataReader).Read())
            {
                estadoVo.idEstado = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idEstado"].ToString());
                estadoVo.estado = ((DbDataReader)mySqlDataReader)["estado"].ToString();
            }
            ((DbDataReader)mySqlDataReader).Close();
            return estadoVo;
        }
    }
}
