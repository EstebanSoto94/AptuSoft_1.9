 
// Type: Aptusoft.FacturaElectronica.Clases.PDF417.CodigoPDF417
 
 
// version 1.8.0

using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace Aptusoft.FacturaElectronica.Clases.PDF417
{
  internal class CodigoPDF417
  {
    public Bitmap creaPdf417(string cod)
    {
      Encoding encoding = Encoding.GetEncoding("ISO-8859-1");
      encoding.GetBytes(cod);
      int num = 1;
      BarcodePDF417 barcodePdF417 = new BarcodePDF417();
      barcodePdF417.Options=32;
      barcodePdF417.CodeColumns=18;
      barcodePdF417.ErrorLevel=5;
      barcodePdF417.Text=encoding.GetBytes(cod);
      Bitmap bitmap1 = new Bitmap(barcodePdF417.CreateDrawingImage(Color.Black, Color.White));
      if (num == 1)
        return bitmap1;
      Bitmap bitmap2 = new Bitmap(Convert.ToInt32(bitmap1.Width * num), Convert.ToInt32(bitmap1.Height * num));
      Graphics graphics = Graphics.FromImage((Image) bitmap2);
      graphics.ScaleTransform((float) num, (float) num);
      graphics.SmoothingMode = SmoothingMode.HighQuality;
      graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
      graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
      graphics.DrawImage((Image) bitmap1, new Point(0, 0));
      return bitmap2;
    }
  }
}
