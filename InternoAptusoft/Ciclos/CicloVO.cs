 
// Type: Aptusoft.InternoAptusoft.Ciclos.CicloVO
 
 
// version 1.8.0

using System;

namespace Aptusoft.InternoAptusoft.Ciclos
{
  public class CicloVO
  {
    public int IdCiclo { get; set; }

    public int CodigoCiclo { get; set; }

    public string Descripcion { get; set; }

    public int DiaFacturacion { get; set; }

    public int DiaVencimiento { get; set; }

    public int DiaCorteServicio { get; set; }

    public int DiaContratacionDesde { get; set; }

    public int DiaContratacionHasta { get; set; }

    public int MesPrimeraFacturacion { get; set; }

    public DateTime FechaFacturacion { get; set; }

    public DateTime FechaVencimiento { get; set; }
  }
}
