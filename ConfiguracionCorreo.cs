using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptusoft
{
    public class ConfiguracionCorreo
    {
        public DataTable traeConf()
        {
            DataTable conf = new DataTable();

            try
            {
                Conexion conecta = Conexion.getConecta();

                MySqlCommand consulta = new MySqlCommand("SELECT id, servidor_correo, correo, contrasena FROM correo", conecta.ConexionMySql);

                MySqlDataReader Reader;
                Reader = consulta.ExecuteReader();
                conf.Load(Reader);
                Reader.Close();
            }
            catch(Exception ex)
            {
                string error = "No se encontró la información de correo";
            }

            return conf;
        }
    }
}
