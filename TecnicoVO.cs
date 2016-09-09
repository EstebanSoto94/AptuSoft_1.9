using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptusoft
{
    public class TecnicoVO
    {
        public int folio_OT { get; set; }
        public int id_tecnico { get; set; }
        public string nombre { get; set; }
        public string tarea_realizada { get; set; }
        public decimal comision { get; set; }
        public DateTime fecha_ingreso { get; set; }
    }
}
