 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csDetalleLibroGuias
 
 
// version 1.8.0

using System;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csDetalleLibroGuias
  {
    public int Folio { get; set; }

    [XmlElement]
    public int Anulado { get; set; }

    public int TpoOper { get; set; }

    public string FchDoc { get; set; }

    public string RUTDoc { get; set; }

    public string RznSoc { get; set; }

    public Decimal MntNeto { get; set; }

    public Decimal TasaImp { get; set; }

    public Decimal IVA { get; set; }

    public Decimal MntTotal { get; set; }

    [XmlElement]
    public Decimal MntModificado { get; set; }

    [XmlElement]
    public int TpoDocRef { get; set; }

    [XmlElement]
    public int FolioDocRef { get; set; }

    [XmlElement]
    public string FchDocRef { get; set; }

    public bool ShouldSerializeAnulado()
    {
      return this.Anulado != 0;
    }

    public bool ShouldSerializeMntModificado()
    {
      return !(this.MntModificado == new Decimal(0));
    }

    public bool ShouldSerializeTpoDocRef()
    {
      return this.TpoDocRef != 0;
    }

    public bool ShouldSerializeFolioDocRef()
    {
      return this.FolioDocRef != 0;
    }

    public bool ShouldSerializeFchDocRef()
    {
      return this.FolioDocRef != 0;
    }
  }
}
