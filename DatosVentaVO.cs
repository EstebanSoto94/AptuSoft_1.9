 
// Type: Aptusoft.DatosVentaVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class DatosVentaVO
  {
    private int _linea;
    private int _idDetalle;
    private int _idFactura;
    private string _rutProveedor;
    private string _codigo;
    private string _descripcion;
    private Decimal _valorVenta;
    private Decimal _cantidad;
    private Decimal _porcDescuento;
    private Decimal _descuento;
    private int _tipoDescuento;
    private Decimal _subTotalLinea;
    private Decimal _totalLinea;
    private int _listaPrecio;
    private int _bodega;
    private int _bodegaDestino;
    private int _folioFactura;
    private bool _exento;
    private int _idTipoDocumentoCompra;
    private string _tipoDocumentoCompra;
    private int _idImpuesto;
    private Decimal _netoLinea;
    private bool _descuentaInventario;
    private Decimal _valorCompra;
    private DateTime _fechaIngreso;

    public string CatCarne { get; set; }

    public long FolioIngresoCompra { get; set; }

    public string CodigoImpuesto { get; set; }

    public Decimal CantidadExistencia { get; set; }

    public Decimal ValorExistencia { get; set; }

    public Decimal TotalExistencia { get; set; }

    public string Usuario { get; set; }

    public Decimal StockQueda { get; set; }

    public Decimal StockQuedaDestino { get; set; }

    public bool Impreso { get; set; }

    public string ResumenDescripcion { get; set; }

    public int IdPromocion { get; set; }

    public Decimal CantidadFacturada { get; set; }

    public Decimal CantidadPorFacturar { get; set; }

    public string TipoDocumento { get; set; }

    public int Linea
    {
      get
      {
        return this._linea;
      }
      set
      {
        this._linea = value;
      }
    }

    public int IdDetalle
    {
      get
      {
        return this._idDetalle;
      }
      set
      {
        this._idDetalle = value;
      }
    }

    public int IdFactura
    {
      get
      {
        return this._idFactura;
      }
      set
      {
        this._idFactura = value;
      }
    }

    public string Codigo
    {
      get
      {
        return this._codigo;
      }
      set
      {
        this._codigo = value;
      }
    }

    public string Descripcion
    {
      get
      {
        return this._descripcion;
      }
      set
      {
        this._descripcion = value;
      }
    }

    public Decimal ValorVenta
    {
      get
      {
        return this._valorVenta;
      }
      set
      {
        this._valorVenta = value;
      }
    }

    public Decimal Cantidad
    {
      get
      {
        return this._cantidad;
      }
      set
      {
        this._cantidad = value;
      }
    }

    public Decimal PorcDescuento
    {
      get
      {
        return this._porcDescuento;
      }
      set
      {
        this._porcDescuento = value;
      }
    }

    public Decimal Descuento
    {
      get
      {
        return this._descuento;
      }
      set
      {
        this._descuento = value;
      }
    }

    public int TipoDescuento
    {
      get
      {
        return this._tipoDescuento;
      }
      set
      {
        this._tipoDescuento = value;
      }
    }

    public Decimal SubTotalLinea
    {
      get
      {
        return this._subTotalLinea;
      }
      set
      {
        this._subTotalLinea = value;
      }
    }

    public Decimal TotalLinea
    {
      get
      {
        return this._totalLinea;
      }
      set
      {
        this._totalLinea = value;
      }
    }

    public int ListaPrecio
    {
      get
      {
        return this._listaPrecio;
      }
      set
      {
        this._listaPrecio = value;
      }
    }

    public int Bodega
    {
      get
      {
        return this._bodega;
      }
      set
      {
        this._bodega = value;
      }
    }

    public int BodegaDestino
    {
      get
      {
        return this._bodegaDestino;
      }
      set
      {
        this._bodegaDestino = value;
      }
    }

    public int FolioFactura
    {
      get
      {
        return this._folioFactura;
      }
      set
      {
        this._folioFactura = value;
      }
    }

    public bool Exento
    {
      get
      {
        return this._exento;
      }
      set
      {
        this._exento = value;
      }
    }

    public int IdTipoDocumentoCompra
    {
      get
      {
        return this._idTipoDocumentoCompra;
      }
      set
      {
        this._idTipoDocumentoCompra = value;
      }
    }

    public string TipoDocumentoCompra
    {
      get
      {
        return this._tipoDocumentoCompra;
      }
      set
      {
        this._tipoDocumentoCompra = value;
      }
    }

    public string RutProveedor
    {
      get
      {
        return this._rutProveedor;
      }
      set
      {
        this._rutProveedor = value;
      }
    }

    public int IdImpuesto
    {
      get
      {
        return this._idImpuesto;
      }
      set
      {
        this._idImpuesto = value;
      }
    }

    public Decimal NetoLinea
    {
      get
      {
        return this._netoLinea;
      }
      set
      {
        this._netoLinea = value;
      }
    }

    public bool DescuentaInventario
    {
      get
      {
        return this._descuentaInventario;
      }
      set
      {
        this._descuentaInventario = value;
      }
    }

    public Decimal ValorCompra
    {
      get
      {
        return this._valorCompra;
      }
      set
      {
        this._valorCompra = value;
      }
    }

    public DateTime FechaIngreso
    {
      get
      {
        return this._fechaIngreso;
      }
      set
      {
        this._fechaIngreso = value;
      }
    }

    public DatosVentaVO()
    {
      this._linea = 0;
      this._codigo = (string) null;
      this._descripcion = "";
      this._valorVenta = new Decimal(0);
      this._cantidad = new Decimal(0);
      this._descuento = new Decimal(0);
      this._porcDescuento = new Decimal(0);
      this._totalLinea = new Decimal(0);
      this.CalulaTotalLinea();
    }

    private void CalulaTotalLinea()
    {
      this._totalLinea = this._valorVenta * this._cantidad - this._descuento;
    }
  }
}
