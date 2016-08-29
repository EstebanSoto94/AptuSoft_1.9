using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data;

namespace Aptusoft
{
    class Odepa
    {
        private Conexion conexion = Conexion.getConecta();

        public void agregaCategoria(OdepaVO od)
        {
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "INSERT INTO odepa (nombre_cat, valor) VALUES(@nombre_cat, @valor)";
            command.Parameters.AddWithValue("@nombre_cat", (object)od.nombre_cat);
            command.Parameters.AddWithValue("@valor", (object)od.valor);
            ((DbCommand)command).ExecuteNonQuery();
        }

        public DataSet listaCategoria()
        {
            DataSet dataSet = new DataSet();
            ((DataAdapter)new MySqlDataAdapter("SELECT id, nombre_cat, valor FROM odepa", this.conexion.ConexionMySql)).Fill(dataSet);
            return dataSet;
        }

        public List<VendedorVO> listaVendedoresVenta()
        {
            List<VendedorVO> list = new List<VendedorVO>();
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "SELECT idVendedor, nombre, comision FROM vendedores ORDER BY idVendedor";
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            list.Add(new VendedorVO()
            {
                IdVendedor = 0,
                Nombre = "[SELECCIONE]"
            });
            while (((DbDataReader)mySqlDataReader).Read())
                list.Add(new VendedorVO()
                {
                    IdVendedor = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idVendedor"].ToString()),
                    Nombre = ((DbDataReader)mySqlDataReader)["nombre"].ToString(),
                    Comision = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["comision"].ToString())
                });
            ((DbDataReader)mySqlDataReader).Close();
            return list;
        }

        public OdepaVO buscaCategoriaId(int _id)
        {
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "SELECT id, nombre_cat,valor FROM odepa WHERE id = @id";
            command.Parameters.AddWithValue("@id", (object)_id);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            OdepaVO odepavo = new OdepaVO();
            while (((DbDataReader)mySqlDataReader).Read())
            {
                odepavo.id = Convert.ToInt32(((DbDataReader)mySqlDataReader)["id"].ToString());
                odepavo.nombre_cat = ((DbDataReader)mySqlDataReader)["nombre_cat"].ToString();
                odepavo.valor = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["valor"].ToString());
            }
            ((DbDataReader)mySqlDataReader).Close();
            return odepavo;
        }

        public void modificaValor(OdepaVO od)
        {
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "UPDATE odepa SET nombre_cat=@nombre_cat, valor=@valor WHERE id=@id";
            command.Parameters.AddWithValue("@nombre_cat", (object)od.nombre_cat);
            command.Parameters.AddWithValue("@valor", (object)od.valor);
            command.Parameters.AddWithValue("@id", (object)od.id);
            ((DbCommand)command).ExecuteNonQuery();
        }

        public void eliminaCategoria(int _id)
        {
            string format = "DELETE FROM odepa WHERE id={0}";
            MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = string.Format(format, (object)_id);
            ((DbCommand)command).ExecuteNonQuery();
        }
    }
}
