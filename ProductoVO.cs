 
// Type: Aptusoft.ProductoVO
 
 
// version 1.8.0

using System;
using System.Drawing;

namespace Aptusoft
{
  public class ProductoVO
  {
    private string _codigo;
    private string _codigoAlternativo;
    private string _descripcion;
    private string _marca;
    private bool _activo;
    private bool _pesable;
    private bool _exento;
    private bool _kit;
    private Decimal _valorVenta1;
    private Decimal _valorVenta2;
    private Decimal _valorVenta3;
    private Decimal _valorVenta4;
    private Decimal _valorVenta5;
    private Decimal _valorCompra;
    private Decimal _porcRentabilidad1;
    private Decimal _porcRentabilidad2;
    private Decimal _porcRentabilidad3;
    private Decimal _porcRentabilidad4;
    private Decimal _porcRentabilidad5;
    private Decimal _stockMinimo;
    private Decimal _bodega1;
    private Decimal _bodega2;
    private Decimal _bodega3;
    private Decimal _bodega4;
    private Decimal _bodega5;
    private Decimal _bodega6;
    private Decimal _bodega7;
    private Decimal _bodega8;
    private Decimal _bodega9;
    private Decimal _bodega10;
    private Decimal _bodega11;
    private Decimal _bodega12;
    private Decimal _bodega13;
    private Decimal _bodega14;
    private Decimal _bodega15;
    private Decimal _bodega16;
    private Decimal _bodega17;
    private Decimal _bodega18;
    private Decimal _bodega19;
    private Decimal _bodega20;
    private int _codCategoria;
    private string _categoria;
    private int _codUnidadMedida;
    private string _unidadMedida;
    private DateTime _fechaCreacion;
    private int _idImpuesto;
    private string _nombreImpuesto;

    public string RutaImg1 { get; set; }

    public string RutaImg2 { get; set; }

    public string RutaImg3 { get; set; }

    public Bitmap Img1 { get; set; }

    public Bitmap Img2 { get; set; }

    public Bitmap Img3 { get; set; }

    public string ResumenDescripcion { get; set; }

    public bool TienePromocion { get; set; }

    public int IdSubCategoria { get; set; }

    public string SubCategoria { get; set; }

    public Decimal StockSistema { get; set; }

    public Decimal StockFisico { get; set; }

    public Decimal Diferencia { get; set; }

    public int Linea { get; set; }

    public int IdDetalleTomaInventario { get; set; }

    public int IdTomaInventarioLinea { get; set; }

    public int BodegaTomaInventario { get; set; }

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

    public string CodigoAlternativo
    {
      get
      {
        return this._codigoAlternativo;
      }
      set
      {
        this._codigoAlternativo = value;
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

    public string Marca
    {
      get
      {
        return this._marca;
      }
      set
      {
        this._marca = value;
      }
    }

    public bool Activo
    {
      get
      {
        return this._activo;
      }
      set
      {
        this._activo = value;
      }
    }

    public bool Pesable
    {
      get
      {
        return this._pesable;
      }
      set
      {
        this._pesable = value;
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

    public bool Kit
    {
      get
      {
        return this._kit;
      }
      set
      {
        this._kit = value;
      }
    }

    public Decimal ValorVenta1
    {
      get
      {
        return this._valorVenta1;
      }
      set
      {
        this._valorVenta1 = value;
      }
    }

    public Decimal ValorVenta2
    {
      get
      {
        return this._valorVenta2;
      }
      set
      {
        this._valorVenta2 = value;
      }
    }

    public Decimal ValorVenta3
    {
      get
      {
        return this._valorVenta3;
      }
      set
      {
        this._valorVenta3 = value;
      }
    }

    public Decimal ValorVenta4
    {
      get
      {
        return this._valorVenta4;
      }
      set
      {
        this._valorVenta4 = value;
      }
    }

    public Decimal ValorVenta5
    {
      get
      {
        return this._valorVenta5;
      }
      set
      {
        this._valorVenta5 = value;
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

    public Decimal PorcRentabilidad1
    {
      get
      {
        return this._porcRentabilidad1;
      }
      set
      {
        this._porcRentabilidad1 = value;
      }
    }

    public Decimal PorcRentabilidad2
    {
      get
      {
        return this._porcRentabilidad2;
      }
      set
      {
        this._porcRentabilidad2 = value;
      }
    }

    public Decimal PorcRentabilidad3
    {
      get
      {
        return this._porcRentabilidad3;
      }
      set
      {
        this._porcRentabilidad3 = value;
      }
    }

    public Decimal PorcRentabilidad4
    {
      get
      {
        return this._porcRentabilidad4;
      }
      set
      {
        this._porcRentabilidad4 = value;
      }
    }

    public Decimal PorcRentabilidad5
    {
      get
      {
        return this._porcRentabilidad5;
      }
      set
      {
        this._porcRentabilidad5 = value;
      }
    }

    public Decimal StockMinimo
    {
      get
      {
        return this._stockMinimo;
      }
      set
      {
        this._stockMinimo = value;
      }
    }

    public Decimal Bodega1
    {
      get
      {
        return this._bodega1;
      }
      set
      {
        this._bodega1 = value;
      }
    }

    public Decimal Bodega2
    {
      get
      {
        return this._bodega2;
      }
      set
      {
        this._bodega2 = value;
      }
    }

    public Decimal Bodega3
    {
      get
      {
        return this._bodega3;
      }
      set
      {
        this._bodega3 = value;
      }
    }

    public Decimal Bodega4
    {
      get
      {
        return this._bodega4;
      }
      set
      {
        this._bodega4 = value;
      }
    }

    public Decimal Bodega5
    {
      get
      {
        return this._bodega5;
      }
      set
      {
        this._bodega5 = value;
      }
    }

    public Decimal Bodega6
    {
      get
      {
        return this._bodega6;
      }
      set
      {
        this._bodega6 = value;
      }
    }

    public Decimal Bodega7
    {
      get
      {
        return this._bodega7;
      }
      set
      {
        this._bodega7 = value;
      }
    }

    public Decimal Bodega8
    {
      get
      {
        return this._bodega8;
      }
      set
      {
        this._bodega8 = value;
      }
    }

    public Decimal Bodega9
    {
      get
      {
        return this._bodega9;
      }
      set
      {
        this._bodega9 = value;
      }
    }

    public Decimal Bodega10
    {
      get
      {
        return this._bodega10;
      }
      set
      {
        this._bodega10 = value;
      }
    }

    public Decimal Bodega11
    {
      get
      {
        return this._bodega11;
      }
      set
      {
        this._bodega11 = value;
      }
    }

    public Decimal Bodega12
    {
      get
      {
        return this._bodega12;
      }
      set
      {
        this._bodega12 = value;
      }
    }

    public Decimal Bodega13
    {
      get
      {
        return this._bodega13;
      }
      set
      {
        this._bodega13 = value;
      }
    }

    public Decimal Bodega14
    {
      get
      {
        return this._bodega14;
      }
      set
      {
        this._bodega14 = value;
      }
    }

    public Decimal Bodega15
    {
      get
      {
        return this._bodega15;
      }
      set
      {
        this._bodega15 = value;
      }
    }

    public Decimal Bodega16
    {
      get
      {
        return this._bodega16;
      }
      set
      {
        this._bodega16 = value;
      }
    }

    public Decimal Bodega17
    {
      get
      {
        return this._bodega17;
      }
      set
      {
        this._bodega17 = value;
      }
    }

    public Decimal Bodega18
    {
      get
      {
        return this._bodega18;
      }
      set
      {
        this._bodega18 = value;
      }
    }

    public Decimal Bodega19
    {
      get
      {
        return this._bodega19;
      }
      set
      {
        this._bodega19 = value;
      }
    }

    public Decimal Bodega20
    {
      get
      {
        return this._bodega20;
      }
      set
      {
        this._bodega20 = value;
      }
    }

    public int CodCategoria
    {
      get
      {
        return this._codCategoria;
      }
      set
      {
        this._codCategoria = value;
      }
    }

    public string Categoria
    {
      get
      {
        return this._categoria;
      }
      set
      {
        this._categoria = value;
      }
    }

    public int CodUnidadMedida
    {
      get
      {
        return this._codUnidadMedida;
      }
      set
      {
        this._codUnidadMedida = value;
      }
    }

    public string UnidadMedida
    {
      get
      {
        return this._unidadMedida;
      }
      set
      {
        this._unidadMedida = value;
      }
    }

    public DateTime FechaCreacion
    {
      get
      {
        return this._fechaCreacion;
      }
      set
      {
        this._fechaCreacion = value;
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

    public string NombreImpuesto
    {
      get
      {
        return this._nombreImpuesto;
      }
      set
      {
        this._nombreImpuesto = value;
      }
    }

    public ProductoVO()
    {
      this._codigo =  null;
      this._codigoAlternativo = null;
      this._descripcion =  null;
      this._marca =  null;
      this._activo = true;
      this._pesable = false;
      this._exento = false;
      this._kit = false;
      this._valorVenta1 = new Decimal(0);
      this._valorVenta2 = new Decimal(0);
      this._valorVenta3 = new Decimal(0);
      this._valorVenta4 = new Decimal(0);
      this._valorVenta5 = new Decimal(0);
      this._valorCompra = new Decimal(0);
      this._porcRentabilidad1 = new Decimal(0);
      this._porcRentabilidad2 = new Decimal(0);
      this._porcRentabilidad3 = new Decimal(0);
      this._porcRentabilidad4 = new Decimal(0);
      this._porcRentabilidad5 = new Decimal(0);
      this._stockMinimo = new Decimal(0);
      this._bodega1 = new Decimal(0);
      this._bodega2 = new Decimal(0);
      this._bodega3 = new Decimal(0);
      this._bodega4 = new Decimal(0);
      this._bodega5 = new Decimal(0);
      this._bodega6 = new Decimal(0);
      this._bodega7 = new Decimal(0);
      this._bodega8 = new Decimal(0);
      this._bodega9 = new Decimal(0);
      this._bodega10 = new Decimal(0);
      this._bodega11 = new Decimal(0);
      this._bodega12 = new Decimal(0);
      this._bodega13 = new Decimal(0);
      this._bodega14 = new Decimal(0);
      this._bodega15 = new Decimal(0);
      this._bodega16 = new Decimal(0);
      this._bodega17 = new Decimal(0);
      this._bodega18 = new Decimal(0);
      this._bodega19 = new Decimal(0);
      this._bodega20 = new Decimal(0);
      this._codCategoria = 0;
      this._codUnidadMedida = 0;
      this._fechaCreacion = DateTime.Now.Date;
      this._idImpuesto = 0;
      this._nombreImpuesto = "SIN IMPUESTO";
    }
  }
}
