using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Aptusoft.FacturaElectronica.Formularios
{
    class SubeXMLToDb
    {
        private string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        private String[] Coneccion()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(@"C:\AptuSoft\xml\config.xml");
            XmlNodeList nodelist = xd.SelectNodes("datos/Conexion"); // get all <testcase> nodes
            String[] Con = new String[6];
            foreach (XmlNode node in nodelist) // for each <testcase> node
            {
                if (node.SelectSingleNode("principal").InnerText == "1")
                {
                    try
                    {
                        Con[0] = node.SelectSingleNode("server").InnerText;
                        Con[1] = node.SelectSingleNode("base").InnerText;
                        Con[2]= node.SelectSingleNode("user").InnerText;
                        Con[3] = node.SelectSingleNode("pass").InnerText;
                        Con[4] = node.SelectSingleNode("rutaElectronica").InnerText;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in reading XML", "xmlError", MessageBoxButtons.OK);
                    }
                }
            }
            return Con;
        }
        public void Sube(string TipoDoc, string FolioDoc, string path, string nombre_archivo)
        {
            String[] con = Coneccion();
            if (TipoDoc == "Factura_electronica"){path = path + @"\EFacturaXML\"; }
            if (TipoDoc == "NotaCredito_Electronica") { path = path + @"\ENotaCreditoXML\"; }
            if (TipoDoc == "NotaDebito_Electronica") { path = path + @"\ENotaDebitoXML\"; }
            if (TipoDoc == "GuiaDespacho_Electronica") { path = path + @"\EGuiaXML\"; } 
            if (TipoDoc == "Factura_electronica_exenta") { path = path + @"\EFacturaExentaXML\"; }
            MySqlConnection conexion = new MySqlConnection();
            //string cadenaConexion = "Server=192.168.43.34;port=3306;Database=datos_personales;User id=lin;Password=58521156";
            StreamReader reader = new StreamReader(con[4] + @"\"+path + nombre_archivo +"_"+str + ".xml",System.Text.Encoding.Default);
            string contenido = reader.ReadToEnd();
            reader.Close();
            string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
              conexion.ConnectionString = cadenaConexion;
            try
            {
                conexion.Open();
                MySqlCommand command = conexion.CreateCommand();
                ((DbCommand)command).CommandText = "insert into xml_backup(folio, tipo, contenido) values("
                + "@folio, @tipo,@contenido)";
                command.Parameters.AddWithValue("@folio", FolioDoc);
                command.Parameters.AddWithValue("@tipo", TipoDoc );
                command.Parameters.AddWithValue("@contenido", contenido);
                //command.Parameters.AddWithValue("@iva", iva);
                //command.Parameters.AddWithValue("@exento", exento);
                //command.Parameters.AddWithValue("@total", total);
                ((DbCommand)command).ExecuteNonQuery();
                
               // MessageBox.Show("Conectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No conectado" + ex);
            }
        
        }
        public void SubeArchivoFisico(string TipoDoc,  string path, string folio)
        {
            String[] con = Coneccion();
            if (TipoDoc == "33")
            {
                TipoDoc = "Factura_Electronica";
            }
            if (TipoDoc == "34")
            {
                TipoDoc = "Factura_Exenta_Electronica";
            }
            if (TipoDoc == "39")
            {
                TipoDoc = "Boleta_Electronica";
            }
            if (TipoDoc == "41")
            {
                TipoDoc = "Boleta_no_afecta_o_exenta_Electronica";
            }
            if (TipoDoc == "61")
            {
                TipoDoc = "NotaCredito_Electronica";
            }
            if (TipoDoc == "56")
            {
                TipoDoc = "NotaDebito_Electronica";
            }
            if (TipoDoc == "52")
            {
                TipoDoc = "GuiaDespacho_Electronica";
            }
            if (TipoDoc == "34")
            {
                TipoDoc = "Factura_electronica_exenta";
            }
            //if (TipoDoc == "Factura_Electronica") { path = path + @"\E-Factura\"; }
            //if (TipoDoc == "NotaCredito_Electronica") { path = path + @"\E-NotaCredito\"; }
            //if (TipoDoc == "NotaDebito_Electronica") { path = path + @"\E-NotaDebito\"; }
            //if (TipoDoc == "GuiaDespacho_Electronica") { path = path + @"\E-Guia\"; }

            MySqlConnection conexion = new MySqlConnection();
            //string cadenaConexion = "Server=192.168.43.34;port=3306;Database=datos_personales;User id=lin;Password=58521156";
            StreamReader reader = new StreamReader(path, System.Text.Encoding.Default);//+ ".xml");
            string contenido = reader.ReadToEnd();
            reader.Close();
            string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
            conexion.ConnectionString = cadenaConexion;
            try
            {
                conexion.Open();
                MySqlCommand command = conexion.CreateCommand();
                ((DbCommand)command).CommandText = "insert into xml_backup(folio, tipo, contenido) values("
                 + "@folio, @tipo,@contenido)";
                command.Parameters.AddWithValue("@folio", folio);
                command.Parameters.AddWithValue("@tipo", TipoDoc);
                command.Parameters.AddWithValue("@contenido", contenido);
                //command.Parameters.AddWithValue("@exento", exento);
                //command.Parameters.AddWithValue("@total", total);
                ((DbCommand)command).ExecuteNonQuery();

                // MessageBox.Show("Conectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No conectado" + ex);
            }

        }
        public void SubeCaf(string TipoDoc, string fecha, string path, string nombre_archivo)
        {
            String[] con = Coneccion();
            if (TipoDoc == "33")
            {
                TipoDoc = "Factura_Electronica";
            }
            if (TipoDoc == "34")
            {
                TipoDoc = "Factura_Exenta_Electronica";
            }
            if (TipoDoc == "39")
            {
                TipoDoc = "Boleta_Electronica";
            }
            if (TipoDoc == "41")
            {
                TipoDoc = "Boleta_no_afecta_o_exenta_Electronica";
            }
            if (TipoDoc == "61")
            {
                TipoDoc = "NotaCredito_Electronica";
            }
            if (TipoDoc == "56")
            {
                TipoDoc = "NotaDebito_Electronica";
            }
            if (TipoDoc == "52") { 
                TipoDoc = "GuiaDespacho_Electronica"; 
            }
            if (TipoDoc == "34")
            {
                TipoDoc = "Factura_electronica_exenta";
            }
            if (TipoDoc == "Factura_Electronica") { path = path + @"\E-Factura\"; }
            if (TipoDoc == "NotaCredito_Electronica") { path = path + @"\E-NotaCredito\"; }
            if (TipoDoc == "NotaDebito_Electronica") { path = path + @"\E-NotaDebito\"; }
            if (TipoDoc == "GuiaDespacho_Electronica") { path = path + @"\E-Guia\"; }
            if (TipoDoc == "Boleta_Electronica") { path = path + @"\E-Boleta\"; }
            if (TipoDoc == "Factura_electronica_exenta") { path = path + @"\EFacturaExentaXML\"; }
            MySqlConnection conexion = new MySqlConnection();
            //string cadenaConexion = "Server=192.168.43.34;port=3306;Database=datos_personales;User id=lin;Password=58521156";
            StreamReader reader = new StreamReader(con[4] + @"\" + path + nombre_archivo, System.Text.Encoding.Default);//+ ".xml");
            string contenido = reader.ReadToEnd();
            reader.Close();
            string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
            conexion.ConnectionString = cadenaConexion;
            try
            {
                conexion.Open();
                MySqlCommand command = conexion.CreateCommand();
                ((DbCommand)command).CommandText = "insert into xml_caf(fecha, nombre_archivo, contenido, tipodoc) values("
                + "@fecha, @nombre, @contenido, @tipo)";
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@tipo", TipoDoc);
                command.Parameters.AddWithValue("@contenido", contenido);
                command.Parameters.AddWithValue("@nombre", nombre_archivo);
                //command.Parameters.AddWithValue("@exento", exento);
                //command.Parameters.AddWithValue("@total", total);
                ((DbCommand)command).ExecuteNonQuery();

                // MessageBox.Show("Conectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No conectado" + ex);
            }

        }
        public void RecuperaCaf(string TipoDoc, string path)
        {
            String[] con = Coneccion();
            if (TipoDoc == "33")
            {
                TipoDoc = "Factura_Electronica";
            }
            if (TipoDoc == "34")
            {
                TipoDoc = "Factura_Exenta_Electronica";
            }
            if (TipoDoc == "39")
            {
                TipoDoc = "Boleta_Electronica";
            }
            if (TipoDoc == "41")
            {
                TipoDoc = "Boleta_no_afecta_o_exenta_Electronica";
            }
            if (TipoDoc == "61")
            {
                TipoDoc = "NotaCredito_Electronica";
            }
            if (TipoDoc == "56")
            {
                TipoDoc = "NotaDebito_Electronica";
            }
            if (TipoDoc == "52")
            {
                TipoDoc = "GuiaDespacho_Electronica";
            } 
            if (TipoDoc == "34")
            {
                TipoDoc = "Factura_electronica_exenta";
            }

            if (TipoDoc == "Factura_Electronica") { path = con[4].ToString()+ path + @"\E-Factura\"; }
            if (TipoDoc == "NotaCredito_Electronica") { path = con[4].ToString() + path + @"\E-NotaCredito\"; }
            if (TipoDoc == "NotaDebito_Electronica") { path = con[4].ToString() + path + @"\E-NotaDebito\"; }
            if (TipoDoc == "GuiaDespacho_Electronica") { path = con[4].ToString() + path + @"\E-Guia\"; }
            if (TipoDoc == "Factura_electronica_exenta") { path = con[4].ToString() + path + @"\E-FacturaExenta\"; }
            if (TipoDoc == "Boleta_Electronica") { path = con[4].ToString() + path + @"\E-Boleta\"; }
            MySqlConnection conexion = new MySqlConnection();
            //string cadenaConexion = "Server=192.168.43.34;port=3306;Database=datos_personales;User id=lin;Password=58521156";
            //StreamReader reader = new StreamReader(con[4] + @"\" + path + nombre_archivo);//+ ".xml");
            //string contenido = reader.ReadToEnd();
            //reader.Close();
            string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
            MySqlCommand command = conexion.CreateCommand();
            ((DbCommand)command).CommandText = "Select * from xml_caf where tipodoc = @tipo";
            command.Parameters.AddWithValue("@tipo", TipoDoc);
            conexion.ConnectionString = cadenaConexion;
           try
            {
                conexion.Open();
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (((DbDataReader)mySqlDataReader).Read())
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    StreamWriter wr = new StreamWriter(path + mySqlDataReader["nombre_archivo"].ToString());
                    // ((DbCommand)command).ExecuteNonQuery();
                    wr.WriteLine(mySqlDataReader["contenido"].ToString(), System.Text.Encoding.Default);
                    wr.Close();
                    //textBox1.Text = mySqlDataReader["nombre_archivo"].ToString();
                }

                
                mySqlDataReader.Close();
               // MessageBox.Show("Conectado");
            }
           catch (Exception ex)
           {
               MessageBox.Show( ex.Message);
           }

        }
        public bool existe(string folio, string tipo)
        {
            String[] con = Coneccion();
            String tipoDoc = "";
            string path = "";
            string[] rutas = { "DTE\\E-Factura\\EFacturaXML\\EFactura_", "DTE\\E-FacturaExenta\\EFacturaExentaXML\\EFacturaExenta_", "DTE\\E-NotaCredito\\ENotaCreditoXML\\ENotaCredito_", "DTE\\E-NotaDebito\\ENotaDebitoXML\\ENotaDebito_", "DTE\\E-Guia\\EGuiaXML\\EGuia_", "DTE\\E-Boleta\\EBoletaXML\\EBoleta_" };
            if (tipo == "DTE\\E-Factura\\EFacturaXML\\EFactura_" || tipo == "33") { tipoDoc = "Factura_electronica"; path = con[4] + @"\" + rutas[0]; }
            if (tipo == "DTE\\E-FacturaExenta\\EFacturaExentaXML\\EFacturaExenta_" || tipo == "34") { tipoDoc = ""; path = con[4] + @"\" + rutas[1]; }
            if (tipo == "DTE\\E-NotaCredito\\ENotaCreditoXML\\ENotaCredito_" || tipo == "61") { tipoDoc = "NotaCredito_Electronica"; path = con[4] + @"\" + rutas[2]; }
            if (tipo == "DTE\\E-NotaDebito\\ENotaDebitoXML\\ENotaDebito_" || tipo == "56") { tipoDoc = "NotaDebito_Electronica"; path = con[4] + @"\" + rutas[3]; }
            if (tipo == "DTE\\E-Guia\\EGuiaXML\\EGuia_" || tipo == "52") { tipoDoc = "GuiaDespacho_Electronica"; path = con[4] + @"\" + rutas[4]; }
            if (tipo == "DTE\\E-Boleta\\EBoletaXML\\EBoleta_" || tipo == "39") { tipoDoc = ""; path = con[4] + @"\" + rutas[5]; }

            MySqlConnection conexion = new MySqlConnection();
            string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
            conexion.ConnectionString = cadenaConexion;
            MySqlCommand command = conexion.CreateCommand();
            ((DbCommand)command).CommandText = "select Count(*) as total from xml_backup where folio = \"" + folio + "\" and tipo = \"" + tipoDoc + "\";";
            bool existe = true;
            try
            {
                conexion.Open();
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (((DbDataReader)mySqlDataReader).Read())
                {
                    
                    if ( mySqlDataReader["total"].ToString() == "1")
                    {
                        existe = false;

                    }
                    else if (mySqlDataReader["total"].ToString() == "0")
                    {
                        existe = true;
                    }
                }
             mySqlDataReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No conectado" + ex);
            }
            return existe;
        }
        public void Recupera( string folio, string tipo)
        {
            String[] con = Coneccion();
            String tipoDoc ="";
            string path = "";
            string empresa = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
            string[] rutas = { "DTE\\E-Factura\\EFacturaXML\\EFactura_", "DTE\\E-FacturaExenta\\EFacturaExentaXML\\EFacturaExenta_", "DTE\\E-NotaCredito\\ENotaCreditoXML\\ENotaCredito_",  "DTE\\E-NotaDebito\\ENotaDebitoXML\\ENotaDebito_", "DTE\\E-Guia\\EGuiaXML\\EGuia_", "DTE\\E-Boleta\\EBoletaXML\\EBoleta_" };
            if (tipo == "DTE\\E-Factura\\EFacturaXML\\EFactura_") { tipoDoc = "Factura_electronica"; path = con[4]+@"\"+rutas[0]; }
            if (tipo == "DTE\\E-FacturaExenta\\EFacturaExentaXML\\EFacturaExenta_") { tipoDoc = ""; path = con[4] + @"\" + rutas[1]; }
            if (tipo == "DTE\\E-NotaCredito\\ENotaCreditoXML\\ENotaCredito_") { tipoDoc = "NotaCredito_Electronica"; path = con[4] + @"\" + rutas[2]; }
            if (tipo == "DTE\\E-NotaDebito\\ENotaDebitoXML\\ENotaDebito_") { tipoDoc = "NotaDebito_Electronica"; path = con[4] + @"\" + rutas[3]; }
            if (tipo == "DTE\\E-Guia\\EGuiaXML\\EGuia_") { tipoDoc = "GuiaDespacho_Electronica"; path = con[4] + @"\" + rutas[4]; }
            if (tipo == "DTE\\E-Boleta\\EBoletaXML\\EBoleta_") { tipoDoc = ""; path = con[4] + @"\" + rutas[5]; }
           
            MySqlConnection conexion = new MySqlConnection();
            string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
            conexion.ConnectionString = cadenaConexion;
            MySqlCommand command = conexion.CreateCommand();
            ((DbCommand)command).CommandText = "select * from xml_backup where folio = \"" + folio + "\" and tipo = \""+tipoDoc +"\";";
            if (File.Exists(path + folio + "_" + empresa + ".xml"))
            {
                File.Delete(path + folio + "_" + empresa + ".xml");
            }
            // StreamReader reader = new StreamReader(con[4] + @"\DTE\E-Factura\EFacturaXML\" + nombre_archivo + ".xml");
            
            
            try
            {
                conexion.Open();
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (((DbDataReader)mySqlDataReader).Read())
                {
                    if (File.Exists(path + folio +"_"+empresa+".xml"))
                    {
                        File.Delete(path + folio + "_" + empresa + ".xml");
                    }

                    StreamWriter wr = new StreamWriter(path + folio + "_" + empresa + ".xml");
                    // ((DbCommand)command).ExecuteNonQuery();
                    wr.WriteLine(mySqlDataReader["contenido"].ToString(), System.Text.Encoding.Default);
                    wr.Close();
                    //textBox1.Text = mySqlDataReader["nombre_archivo"].ToString();
                }

                
                mySqlDataReader.Close();
               // MessageBox.Show("Conectado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No conectado" + ex);
            }
           
            
        }
        public void eliminar(string tipoDoc, string folio)
        {
            String[] con = Coneccion();
            MySqlConnection conexion = new MySqlConnection();
            string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
            conexion.ConnectionString = cadenaConexion;
            MySqlCommand command = conexion.CreateCommand();
            try
            {
                conexion.Open();
            //delete from xml_backup where folio = "7" and tipo = "Factura_electronica";
            ((DbCommand)command).CommandText = "delete from xml_backup where folio = @folio and tipo = @tipo ";
            command.Parameters.AddWithValue("@folio", folio );
                 command.Parameters.AddWithValue("@tipo", tipoDoc );
            ((DbCommand)command).ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No conectado" + ex);
            }
        }
        public void Actualizar(string TipoDoc, string FolioDoc, string path, string nombre_archivo)
        {
            String[] con = Coneccion();
            if (TipoDoc == "Factura_electronica") { path = path + @"\EFacturaXML\"; }
            if (TipoDoc == "NotaCredito_Electronica") { path = path + @"\ENotaCreditoXML\"; }
            if (TipoDoc == "NotaDebito_Electronica") { path = path + @"\ENotaDebitoXML\"; }
            if (TipoDoc == "GuiaDespacho_Electronica") { path = path + @"\EGuiaXML\"; }
            if (TipoDoc == "Factura_electronica_exenta") { path = path + @"\EFacturaExentaXML\"; }
            StreamReader reader = new StreamReader(con[4] + @"\" + path + nombre_archivo+"_"+str + ".xml", System.Text.Encoding.Default);
            string contenido = reader.ReadToEnd();
            reader.Close();
            MySqlConnection conexion = new MySqlConnection();
            string cadenaConexion = "Server=" + con[0] + ";Database=" + con[1] + ";User id=" + con[2] + ";Password=" + con[3];
            conexion.ConnectionString = cadenaConexion;
            MySqlCommand command = conexion.CreateCommand();
           // String contenido = "";

            try
            {
                conexion.Open();
                //dUPDATE xml_backup SET contenido = "" WHERE Folio = "" and tipo = "";
                ((DbCommand)command).CommandText = "UPDATE xml_backup SET contenido = @contenido WHERE Folio = @folio  and tipo = @tipo;";
                command.Parameters.AddWithValue("@contenido", contenido);
                command.Parameters.AddWithValue("@folio", FolioDoc);
                command.Parameters.AddWithValue("@tipo", TipoDoc);
                ((DbCommand)command).ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No conectado" + ex);
            }
        }
    }
}
