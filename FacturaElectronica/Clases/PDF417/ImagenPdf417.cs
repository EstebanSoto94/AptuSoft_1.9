 
// Type: Aptusoft.FacturaElectronica.Clases.PDF417.ImagenPdf417
 
 
// version 1.8.0

using Aptusoft;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Drawing;

namespace Aptusoft.FacturaElectronica.Clases.PDF417
{
  public class ImagenPdf417
  {
    private Conexion conexion = Conexion.getConecta();

    public void agregaImagenPdf417(ImagenPdf417VO im)
    {
      this.eliminaImagenPdf417(im);
      byte[] numArray = (byte[]) new ImageConverter().ConvertTo((object) im.Imagen, typeof (byte[]));
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO zpdf417 (imagenCodigo, folio, tipoDte) VALUES (@imagenCodigo, @folio, @tipoDte)";
      command.Parameters.AddWithValue("@imagenCodigo", (object) numArray);
      command.Parameters.AddWithValue("@folio", (object) im.FolioDte);
      command.Parameters.AddWithValue("@tipoDte", (object) im.TipoDte);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void eliminaImagenPdf417(ImagenPdf417VO im)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM zpdf417 WHERE folio=@folio AND tipoDte=@tipoDte";
      command.Parameters.AddWithValue("@folio", (object) im.FolioDte);
      command.Parameters.AddWithValue("@tipoDte", (object) im.TipoDte);
      ((DbCommand) command).ExecuteNonQuery();
    }
  }
}
