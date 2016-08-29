using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Aptusoft
{
    class CorreoClase
    {
        private Conexion conexion = Conexion.getConecta();

        public DataTable opcionesCorreo()
        {
            DataTable correo = new DataTable();

            try
            {
                Conexion conecta = Conexion.getConecta();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM correo", conecta.ConexionMySql);

                MySqlDataReader Reader;
                Reader = consulta.ExecuteReader();
                correo.Load(Reader);
                Reader.Close();
            }catch (Exception ex)
            {
                throw ex;
            }

            return correo;
        }

        public void guardaCorreo(string servCorreo, string correo, string pass)
        {
            try
            {
                MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
                ((DbCommand)command).CommandText = "UPDATE correo SET servidor_correo = '" + servCorreo + "', correo = '" + correo + "', contrasena = '" + pass + "' WHERE id = 1";

                ((DbCommand)command).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
