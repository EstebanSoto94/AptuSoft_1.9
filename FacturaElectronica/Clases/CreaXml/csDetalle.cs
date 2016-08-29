 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csDetalle
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csDetalle
  {
    private csCdgItem _CdgItem = new csCdgItem();

    public int NroLinDet { get; set; }

    public csCdgItem CdgItem
    {
      get
      {
        return this._CdgItem;
      }
      set
      {
        this._CdgItem = value;
      }
    }

    [XmlElement]
    public int IndExe { get; set; }

    public string NmbItem { get; set; }

    public string DscItem { get; set; }

    [XmlElement]
    public Decimal QtyItem { get; set; }

    [XmlElement]
    public string UnmdItem { get; set; }

    [XmlElement]
    public Decimal PrcItem { get; set; }

    [XmlElement]
    public int DescuentoPct { get; set; }

    [XmlElement]
    public Decimal DescuentoMonto { get; set; }

    [XmlElement]
    public string CodImpAdic { get; set; }

    [XmlElement("InfoTicket")]
    public List<Infoticket> InfoTicket { get; set; }

    public Decimal MontoItem { get; set; }


    public bool ShouldSerializeIndExe()
    {
      return this.IndExe != 0;
    }

    public bool ShouldSerializeQtyItem()
    {
      return !(this.QtyItem == new Decimal(0));
    }

    public bool ShouldSerializeUnmdItem()
    {
      return this.UnmdItem.Length != 0;
    }

    public bool ShouldSerializePrcItem()
    {
      return !(this.PrcItem == new Decimal(0));
    }

    public bool ShouldSerializeDescuentoPct()
    {
      return this.DescuentoPct != 0;
    }

    public bool ShouldSerializeDescuentoMonto()
    {
      return !(this.DescuentoMonto == new Decimal(0));
    }

    public bool ShouldSerializeCodImpAdic()
    {
      return !(this.CodImpAdic == string.Empty);
    }

  }

}
