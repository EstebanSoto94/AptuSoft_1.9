// Decompiled with JetBrains decompiler
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.TotalesSegmento
 
// MVID: BFAB1123-FE62-48E8-AB20-7C9DA3F6AFD2
// Assembly location: C:\Documents and Settings\Administrador\Escritorio\v195_Electronica.exe

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class TotalesSegmento
  {
    private csTotIVANoRec _TotIVANoRec = new csTotIVANoRec();
    private List<csTotOtrosImp> _TotOtrosImp = new List<csTotOtrosImp>();

    public int TpoDoc { get; set; }

    [XmlElement]
    public int TpoImp { get; set; }

    public int TotDoc { get; set; }

    [XmlElement]
    public int TotOpExe { get; set; }

    public Decimal TotMntExe { get; set; }

    public Decimal TotMntNeto { get; set; }

    [XmlElement]
    public int TotOpIVARec { get; set; }

    public Decimal TotMntIVA { get; set; }

    [XmlElement]
    public int TotOpIVAUsoComun { get; set; }

    [XmlElement]
    public Decimal TotIVAUsoComun { get; set; }

    [XmlElement]
    public Decimal FctProp { get; set; }

    [XmlElement]
    public Decimal TotCredIVAUsoComun { get; set; }

    [XmlElement]
    public Decimal TotImpSinCredito { get; set; }

    [XmlElement]
    public csTotIVANoRec TotIVANoRec
    {
      get
      {
        return this._TotIVANoRec;
      }
      set
      {
        this._TotIVANoRec = value;
      }
    }

    [XmlElement]
    public List<csTotOtrosImp> TotOtrosImp
    {
      get
      {
        return this._TotOtrosImp;
      }
      set
      {
        this._TotOtrosImp = value;
      }
    }

    public Decimal TotMntTotal { get; set; }

    public bool ShouldSerializeTpoImp()
    {
      return this.TpoImp != 0;
    }

    public bool ShouldSerializeTotOpExe()
    {
      return this.TotOpExe != 0;
    }

    public bool ShouldSerializeTotOpIVARec()
    {
      return this.TotOpIVARec != 0;
    }

    public bool ShouldSerializeTotOpIVAUsoComun()
    {
      return this.TotOpIVAUsoComun != 0;
    }

    public bool ShouldSerializeTotIVAUsoComun()
    {
      return !(this.TotIVAUsoComun == Decimal.Zero);
    }

    public bool ShouldSerializeFctProp()
    {
      return !(this.FctProp == Decimal.Zero);
    }

    public bool ShouldSerializeTotCredIVAUsoComun()
    {
      return !(this.TotCredIVAUsoComun == Decimal.Zero);
    }

    public bool ShouldSerializeTotImpSinCredito()
    {
      return !(this.TotImpSinCredito == Decimal.Zero);
    }

    public bool ShouldSerializeTotIVANoRec()
    {
      return !(this._TotIVANoRec.TotMntIVANoRec == Decimal.Zero);
    }

    public bool ShouldSerializeTotOtrosImp()
    {
      return this._TotOtrosImp.Count != 0;
    }
  }
}
