 
// Type: Aptusoft.FacturaElectronica.Clases.CargaMaestrosElectronica
 
 
// version 1.8.0

using System.Collections.Generic;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class CargaMaestrosElectronica
  {
    public List<AuxiliarVO> listaDocumentosVenta()
    {
      return new List<AuxiliarVO>()
      {
        new AuxiliarVO()
        {
          Numero = 33,
          Nombre = "FACTURA ELECTRONICA"
        },
        new AuxiliarVO()
        {
          Numero = 34,
          Nombre = "FACTURA EXENTA ELECTRONICA"
        },
        new AuxiliarVO()
        {
          Numero = 39,
          Nombre = "BOLETA ELECTRONICA"
        },
        new AuxiliarVO()
        {
          Numero = 41,
          Nombre = "BOLETA NO AFECTA O EXENTA ELECTRONICA"
        },
        new AuxiliarVO()
        {
          Numero = 52,
          Nombre = "GUIA DE DESPACHO ELECTRONICA"
        },
        new AuxiliarVO()
        {
          Numero = 56,
          Nombre = "NOTA DE DEBITO ELECTRONICA"
        },
        new AuxiliarVO()
        {
          Numero = 61,
          Nombre = "NOTA DE CREDITO ELECTRONICA"
        }
      };
    }
  }
}
