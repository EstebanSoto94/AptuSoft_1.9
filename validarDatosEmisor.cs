using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml;

namespace Aptusoft
{
    public class validarDatosEmisor
    {
        public bool valUser()
        {
            string path = @"C:\AptuSoft\Electronica\Archivos\SETDTE.XML";
            XmlDocument xd = new XmlDocument();
            xd.Load(path);
            XmlNodeList nodelist = xd.SelectNodes("EnvioDTE/SetDTE/Caratula");
            bool val = false;
            foreach (XmlNode node in nodelist)
            {
                try
                {
                    if (node.SelectSingleNode("RutEmisor").InnerText == "0")
                    {
                        //MessageBox.Show("no hay dato de emisor");

                    }
                    else
                    {
                       // MessageBox.Show("hay datos");
                        val = true;
                    }
                }
                catch (Exception ex)
                {
                   // MessageBox.Show("Error in reading XML", "xmlError");
                }
            }
            return val;
        }
        public bool valUser_caf(int largo)
        {
            string path = @"C:\AptuSoft\Electronica\Archivos\SETDTE.XML";
            XmlDocument xd = new XmlDocument();
            xd.Load(path);
            XmlNodeList nodelist = xd.SelectNodes("EnvioDTE/SetDTE/Caratula");
            bool val = false;
            int largo_original = 0;
            foreach (XmlNode node in nodelist)
            {
                try
                {
                    if (node.SelectSingleNode("RutEmisor").InnerText.Length == 10 )//&& node.SelectSingleNode("RutEmisor").InnerText.Length == 9)
                    {
                        largo_original = node.SelectSingleNode("RutEmisor").InnerText.Length;
                        if (largo == largo_original)
                        {
                            val = true;
                        } }
                }
                catch (Exception ex)
                {// MessageBox.Show("Error in reading XML", "xmlError");
                }
            }
            return val;
        }
    }
}
