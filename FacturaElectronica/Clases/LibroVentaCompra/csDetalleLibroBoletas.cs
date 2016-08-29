 
// Type: Aptusoft.FacturaElectronica.Clases.LibroVentaCompra.csDetalleLibroBoletas
 
 
// version 1.8.0

using System;

namespace Aptusoft.FacturaElectronica.Clases.LibroVentaCompra
{
  public class csDetalleLibroBoletas
  {
    public int TpoDoc { get; set; }

    public int FolioDoc { get; set; }

    public int TpoServ { get; set; }

    public string FchEmiDoc { get; set; }

    public string RUTCliente { get; set; }

    public Decimal MntExe { get; set; }

    public Decimal MntTotal { get; set; }
  }
}
