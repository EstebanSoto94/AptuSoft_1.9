using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Win32;
using System.Security;
using System.Security.Permissions;

namespace Aptusoft
{
    class respaldo_xml_config
    {
        public void genera_backup()
        {
            if (File.Exists(@"C:\Aptusoft\xml\config.xml"))
            {
                StreamReader reader = new StreamReader(@"C:\Aptusoft\xml\config.xml");
                string temp = reader.ReadToEnd();
                RegistryKey key;
                key = Registry.CurrentUser.CreateSubKey("aptusoft");
                key.SetValue("xml", "");
                key.SetValue("xml", temp);
                key.Close();
                reader.Close();
            }
            if (File.Exists(@"C:\aptusoft\xml\fiscal.xml"))
            {
                StreamReader reader = new StreamReader(@"C:\aptusoft\xml\fiscal.xml");
                string temp = reader.ReadToEnd();
                RegistryKey key;
                key = Registry.CurrentUser.CreateSubKey("aptusoft");
                key.SetValue("fiscal", "");
                key.SetValue("fiscal", temp);
                key.Close();
                reader.Close();
            }
        }
        public void recupera()
        {
            if (!File.Exists(@"C:\Aptusoft\xml\config.xml"))
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"aptusoft");
                string temp = key.GetValue("xml").ToString();
                StreamWriter writer = new StreamWriter(@"C:\aptusoft\xml\config.xml");
                writer.WriteLine(temp);
                writer.Close();
            } if (!File.Exists(@"C:\aptusoft\xml\fiscal.xml"))
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"aptusoft");
                string temp = key.GetValue("fiscal").ToString();
                StreamWriter writer = new StreamWriter(@"C:\aptusoft\xml\fiscal.xml");
                writer.WriteLine(temp);
                writer.Close();
            }
        }
    }
}
