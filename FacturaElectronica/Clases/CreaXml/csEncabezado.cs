 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csEncabezado
 
 
// version 1.8.0

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class csEncabezado
  {
    private csIdDoc _idDoc = new csIdDoc();
    private csEmisor _Emisor = new csEmisor();
    private csReceptor _Receptor = new csReceptor();
    private csTotales _Totales = new csTotales();

    public csIdDoc IdDoc
    {
      get
      {
        return this._idDoc;
      }
      set
      {
        this._idDoc = value;
      }
    }

    public csEmisor Emisor
    {
      get
      {
        return this._Emisor;
      }
      set
      {
        this._Emisor = value;
      }
    }

    public csReceptor Receptor
    {
      get
      {
        return this._Receptor;
      }
      set
      {
        this._Receptor = value;
      }
    }

    public csTotales Totales
    {
      get
      {
        return this._Totales;
      }
      set
      {
        this._Totales = value;
      }
    }
  }
}
