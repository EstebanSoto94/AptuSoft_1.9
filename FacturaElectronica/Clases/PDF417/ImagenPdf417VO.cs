 
// Type: Aptusoft.FacturaElectronica.Clases.PDF417.ImagenPdf417VO
 
 
// version 1.8.0

using System.Drawing;

namespace Aptusoft.FacturaElectronica.Clases.PDF417
{
  public class ImagenPdf417VO
  {
    public int IdImagen { get; set; }

    public Bitmap Imagen { get; set; }

    public int FolioDte { get; set; }

    public int TipoDte { get; set; }
  }
}
