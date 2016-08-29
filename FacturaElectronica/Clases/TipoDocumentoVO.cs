 
// Type: Aptusoft.FacturaElectronica.Clases.TipoDocumentoVO
 
 
// version 1.8.0

using System.Collections.Generic;

namespace Aptusoft.FacturaElectronica.Clases
{
  public class TipoDocumentoVO
  {
    public int CodigoDocumento { get; set; }

    public string NombreDocumento { get; set; }

    public int CodigoAccion { get; set; }

    public string NombreAccion { get; set; }

    public List<TipoDocumentoVO> listaDocumentos()
    {
      return new List<TipoDocumentoVO>()
      {
        new TipoDocumentoVO()
        {
          CodigoDocumento = 30,
          NombreDocumento = "FACTURA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 33,
          NombreDocumento = "FACTURA ELECTRONICA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 32,
          NombreDocumento = "FACTURA EXENTA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 34,
          NombreDocumento = "FACTURA EXENTA ELECTRONICA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 50,
          NombreDocumento = "GUIA DESPACHO"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 52,
          NombreDocumento = "GUIA DESPACHO ELECTRONICA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 60,
          NombreDocumento = "NOTA DE CREDITO"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 61,
          NombreDocumento = "NOTA DE CREDITO ELECTRONICA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 55,
          NombreDocumento = "NOTA DE DEBITO"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 56,
          NombreDocumento = "NOTA DE DEBITO ELECTRONICA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 35,
          NombreDocumento = "BOLETA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 39,
          NombreDocumento = "BOLETA ELECTRONICA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 801,
          NombreDocumento = "ORDEN DE COMPRA"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 48,
          NombreDocumento = "TICKET POS"
        },
        new TipoDocumentoVO()
        {
          CodigoDocumento = 0,
          NombreDocumento = "SET"
        }
      };
    }

    public List<TipoDocumentoVO> listaTipoAccion()
    {
      return new List<TipoDocumentoVO>()
      {
        new TipoDocumentoVO()
        {
          CodigoAccion = 1,
          NombreAccion = "ANULA DOCUMENTO DE REFERENCIA"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 2,
          NombreAccion = "CORRIGE TEXTO DOCUMENTO REFERENCIA"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 3,
          NombreAccion = "CORRIGE MONTOS"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 4,
          NombreAccion = "OTRO"
        }
      };
    }

    public List<TipoDocumentoVO> listaTipoAccionSinAnulaDocumento()
    {
      return new List<TipoDocumentoVO>()
      {
        new TipoDocumentoVO()
        {
          CodigoAccion = 2,
          NombreAccion = "CORRIGE TEXTO DOCUMENTO REFERENCIA"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 3,
          NombreAccion = "CORRIGE MONTOS"
        }
      };
    }

    public List<TipoDocumentoVO> tiposDeTrasladoGuia()
    {
      return new List<TipoDocumentoVO>()
      {
        new TipoDocumentoVO()
        {
          CodigoAccion = 1,
          NombreAccion = "Operación constituye venta"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 2,
          NombreAccion = "Ventas por efectuar"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 3,
          NombreAccion = "Consignaciones"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 4,
          NombreAccion = "Entrega gratuita"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 5,
          NombreAccion = "Traslados internos"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 6,
          NombreAccion = "Otros traslados no venta"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 7,
          NombreAccion = "Guía de devolución"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 8,
          NombreAccion = "Traslado para exportación. (no venta)"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 9,
          NombreAccion = "Venta para exportación"
        }
      };
    }

    public List<TipoDocumentoVO> guiaTrasladadoPor()
    {
      return new List<TipoDocumentoVO>()
      {
        new TipoDocumentoVO()
        {
          CodigoAccion = 0,
          NombreAccion = "Otro"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 1,
          NombreAccion = "Receptor (cliente)"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 2,
          NombreAccion = "Emisor a instalaciones del cliente"
        },
        new TipoDocumentoVO()
        {
          CodigoAccion = 3,
          NombreAccion = "Emisor (entrega en obra)"
        }
      };
    }
  }
}
