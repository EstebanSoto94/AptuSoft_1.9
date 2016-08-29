 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csTotales
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csTotales
  {
    private List<csImpuestos> _ImptoReten = new List<csImpuestos>();

    public Decimal MntNeto { get; set; }

    public Decimal MntExe { get; set; }

    [XmlElement]
    public int TasaIVA { get; set; }

    public Decimal IVA { get; set; }

    [XmlElement("ImptoReten")]
    public List<csImpuestos> ImptoReten
    {
      get
      {
        return this._ImptoReten;
      }
      set
      {
        this._ImptoReten = value;
      }
    }

    public Decimal MntTotal { get; set; }

    public bool ShouldSerializeTasaIVA()
    {
      return this.TasaIVA != 0;
    }

    public bool ShouldSerializeImptoReten()
    {
      return this._ImptoReten.Count != 0;
    }
  }
}
