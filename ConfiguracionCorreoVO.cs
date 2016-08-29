using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptusoft
{
    public class ConfiguracionCorreoVO
    {
        public int id { get; set; }
        public string servidor_correo { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
    }
}
