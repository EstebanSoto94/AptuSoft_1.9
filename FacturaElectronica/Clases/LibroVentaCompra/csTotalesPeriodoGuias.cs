 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csTotalesPeriodoGuias
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csTotalesPeriodoGuias
  {
    private List<csTotTraslado> _TotTraslado = new List<csTotTraslado>();

    public int TotFolAnulado { get; set; }

    public int TotGuiaAnulada { get; set; }

    public int TotGuiaVenta { get; set; }

    public Decimal TotMntGuiaVta { get; set; }

    public Decimal TotMntModificado { get; set; }

    [XmlElement]
    public List<csTotTraslado> TotTraslado
    {
      get
      {
        return this._TotTraslado;
      }
      set
      {
        this._TotTraslado = value;
      }
    }
  }
}
