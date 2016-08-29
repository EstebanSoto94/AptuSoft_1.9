 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csDetalleLibro
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csDetalleLibro
  {
    private csIVANoRec _IVANoRec = new csIVANoRec();
    private List<csOtrosImp> _OtrosImp = new List<csOtrosImp>();

    public int TpoDoc { get; set; }

    public int NroDoc { get; set; }

    public int TpoImp { get; set; }

    public Decimal TasaImp { get; set; }

    public string FchDoc { get; set; }

    public string RUTDoc { get; set; }

    public string RznSoc { get; set; }

    [XmlElement]
    public Decimal MntExe { get; set; }

    public Decimal MntNeto { get; set; }

    public Decimal MntIVA { get; set; }

    [XmlElement]
    public Decimal IVAUsoComun { get; set; }

    [XmlElement]
    public Decimal MntSinCred { get; set; }

    [XmlElement]
    public csIVANoRec IVANoRec
    {
      get
      {
        return this._IVANoRec;
      }
      set
      {
        this._IVANoRec = value;
      }
    }

    [XmlElement]
    public List<csOtrosImp> OtrosImp
    {
      get
      {
        return this._OtrosImp;
      }
      set
      {
        this._OtrosImp = value;
      }
    }

    public Decimal MntTotal { get; set; }

    public bool ShouldSerializeMntExe()
    {
      return !(this.MntExe == new Decimal(0));
    }

    public bool ShouldSerializeIVAUsoComun()
    {
      return !(this.IVAUsoComun == new Decimal(0));
    }

    public bool ShouldSerializeMntSinCred()
    {
      return !(this.MntSinCred == new Decimal(0));
    }

    public bool ShouldSerializeIVANoRec()
    {
      return !(this._IVANoRec.MntIVANoRec == new Decimal(0));
    }

    public bool ShouldSerializeOtrosImp()
    {
      return this._OtrosImp.Count != 0;
    }
  }
}
