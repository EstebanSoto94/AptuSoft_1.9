using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Aptusoft
{
    public partial class FrmConfSync : Form
    {
        public FrmConfSync()
        {
            InitializeComponent();
        }
        public string contra = "aptusoft";
        private void button1_Click(object sender, EventArgs e)
        {
            //frmPassWord ps = new frmPassWord();
            //ps.ShowDialog();
            //ps.Focus();
            if (prueba())
            {
                write();
                MessageBox.Show("Coneccion Correcta","Listo",MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void FrmConfSync_Load(object sender, EventArgs e)
        {
            //frmPassWord ps = new frmPassWord();
            //ps.ShowDialog();
            //ps.Focus();
            read();
        }
        public bool prueba()
        {
            bool conec = false;
            string server = ip.Text.ToString();
            string puerto = port.Text.ToString();
            string databases = db.Text.ToString();
            string id = user.Text.ToString();
            string key = pass.Text.ToString();
            MySqlConnection conexion = new MySqlConnection();
            //string cadenaConexion = "Server=192.168.43.34;port=3306;Database=datos_personales;User id=lin;Password=58521156";

            string cadenaConexion = "Server=" + server + ";port=" + puerto + ";Database=" + databases + ";User id=" + id + ";Password=" + key;
            conexion.ConnectionString = cadenaConexion;
            try
            {
                conexion.Open();

                conec = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No conectado" );
                MessageBox.Show("Verifique los datos");
            }
            return conec;
        }
        string path = @"c:\AptuSoft\xml\config.xml";
        void read()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(path);
            XmlNodeList nodelist = xd.SelectNodes("datos/reflejo"); // get all <testcase> nodes

            foreach (XmlNode node in nodelist) // for each <testcase> node
            {
               
                    try
                    {
                        ip.Text = node.SelectSingleNode("server").InnerText;
                        db.Text = node.SelectSingleNode("base").InnerText;
                        user.Text = node.SelectSingleNode("user").InnerText;
                        pass.Text = Desencriptar(node.SelectSingleNode("pass").InnerText, contra);
                        string p = node.SelectSingleNode("puerto").InnerText;
                        if (p == "") { port.Text = "3306"; } else { port.Text = node.SelectSingleNode("puerto").InnerText; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in reading XML", "xmlError", MessageBoxButtons.OK);
                    }
                
            }
        }

        void write()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(path);
            
            XmlNode a = CrearNodoXml(xd, ip.Text, db.Text, user.Text, Encriptar( pass.Text, contra), port.Text);
            XmlNode raiz = xd.DocumentElement;
            raiz.RemoveChild(raiz.FirstChild);
            raiz.InsertAfter(a, raiz.SelectNodes("datos").Item(1));
            xd.Save(path);
        }
        public XmlNode CrearNodoXml(XmlDocument documento,string ipa, string dba, string uss, string passs, string port1)
        {
            XmlElement conf = documento.CreateElement("reflejo");

            XmlElement server = documento.CreateElement("server");
            server.InnerText = ipa;
            conf.AppendChild(server);
            XmlElement db = documento.CreateElement("base");
            db.InnerText = dba;
            conf.AppendChild(db);
            XmlElement user = documento.CreateElement("user");
            user.InnerText = uss;
            conf.AppendChild(user);
            XmlElement pass2 = documento.CreateElement("pass");
            pass2.InnerText = passs;
            conf.AppendChild(pass2);
            XmlElement puerto2 = documento.CreateElement("puerto");
            puerto2.InnerText = port1;
            conf.AppendChild(puerto2);


            return conf;
        }
        public static string Desencriptar(string textoEncriptado, string key)
        {
            try
            {
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {

            }
            return textoEncriptado;
        }
        public static string Encriptar(string texto, string key)
        {
            try
            {

                byte[] keyArray;

                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //Se utilizan las clases de encriptación MD5

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return texto;
        }
    }
}
