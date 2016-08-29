 
// Type: Aptusoft.OpcionesGeneralesVO
 
 
// version 1.8.0

using System;
using System.Drawing;

namespace Aptusoft
{
  public class OpcionesGeneralesVO
  {
    public int IdOpciones { get; set; }

    public Decimal PorcentajeIva { get; set; }

    public string valoresVentaConIva { get; set; }

    public string RutaImagenLogo { get; set; }

    public Bitmap ImagenLogo { get; set; }

    public bool VerificaCredito { get; set; }

    public bool ImpedirVentasSinCredito { get; set; }

    public bool VerificaFactura { get; set; }

    public bool VerificaFacturaExenta { get; set; }

    public bool VerificaBoleta { get; set; }

    public bool VerificaGuiaSinFacturar { get; set; }

    public int CodigoPesable { get; set; }
  }
}
