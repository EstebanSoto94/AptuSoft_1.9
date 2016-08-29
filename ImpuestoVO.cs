 
// Type: Aptusoft.ImpuestoVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  internal class ImpuestoVO
  {
    public int IdImpuesto { get; set; }

    public string CodigoImpuesto { get; set; }

    public string NombreImpuesto { get; set; }

    public Decimal PorcentajeImpuesto { get; set; }

    public Decimal TotalImpuesto { get; set; }
  }
}
