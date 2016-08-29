 
// Type: Aptusoft.DtsReportesTableAdapters.CotizacionTableAdapter
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.Properties;
using MySql.Data.MySqlClient;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;

namespace Aptusoft.DtsReportesTableAdapters
{
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [HelpKeyword("vs.data.TableAdapter")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class CotizacionTableAdapter : Component
  {
    private MySqlDataAdapter _adapter;
    private MySqlConnection _connection;
    private MySqlTransaction _transaction;
    private MySqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected internal MySqlDataAdapter Adapter
    {
      get
      {
        if (this._adapter == null)
          this.InitAdapter();
        return this._adapter;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal MySqlConnection Connection
    {
      get
      {
        if (this._connection == null)
          this.InitConnection();
        return this._connection;
      }
      set
      {
        this._connection = value;
        if (this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Connection=value;
        if (this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Connection=value;
        if (this.Adapter.UpdateCommand != null)
          this.Adapter.UpdateCommand.Connection=value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
        {
          if (this.CommandCollection[index] != null)
            this.CommandCollection[index].Connection=value;
        }
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal MySqlTransaction Transaction
    {
      get
      {
        return this._transaction;
      }
      set
      {
        this._transaction = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
          this.CommandCollection[index].Transaction=this._transaction;
        if (this.Adapter != null && this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Transaction=this._transaction;
        if (this.Adapter != null && this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Transaction=this._transaction;
        if (this.Adapter == null || this.Adapter.UpdateCommand == null)
          return;
        this.Adapter.UpdateCommand.Transaction=this._transaction;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    protected MySqlCommand[] CommandCollection
    {
      get
      {
        if (this._commandCollection == null)
          this.InitCommandCollection();
        return this._commandCollection;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ClearBeforeFill
    {
      get
      {
        return this._clearBeforeFill;
      }
      set
      {
        this._clearBeforeFill = value;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public CotizacionTableAdapter()
    {
      this.ClearBeforeFill = true;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitAdapter()
    {
      this._adapter = new MySqlDataAdapter();
      ((DataAdapter) this._adapter).TableMappings.Add((object) new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "Cotizacion",
        ColumnMappings = {
          {
            "idCotizacion",
            "idCotizacion"
          },
          {
            "folio",
            "folio"
          },
          {
            "fechaEmision",
            "fechaEmision"
          },
          {
            "fechaVencimiento",
            "fechaVencimiento"
          },
          {
            "dia",
            "dia"
          },
          {
            "mes",
            "mes"
          },
          {
            "ano",
            "ano"
          },
          {
            "idCliente",
            "idCliente"
          },
          {
            "rut",
            "rut"
          },
          {
            "digito",
            "digito"
          },
          {
            "razonSocial",
            "razonSocial"
          },
          {
            "direccion",
            "direccion"
          },
          {
            "comuna",
            "comuna"
          },
          {
            "ciudad",
            "ciudad"
          },
          {
            "giro",
            "giro"
          },
          {
            "fono",
            "fono"
          },
          {
            "fax",
            "fax"
          },
          {
            "contacto",
            "contacto"
          },
          {
            "diasPlazo",
            "diasPlazo"
          },
          {
            "idMedioPago",
            "idMedioPago"
          },
          {
            "medioPago",
            "medioPago"
          },
          {
            "idVendedor",
            "idVendedor"
          },
          {
            "vendedor",
            "vendedor"
          },
          {
            "idCentroCosto",
            "idCentroCosto"
          },
          {
            "centroCosto",
            "centroCosto"
          },
          {
            "ordenCompra",
            "ordenCompra"
          },
          {
            "subtotal",
            "subtotal"
          },
          {
            "porcentajeDescuento",
            "porcentajeDescuento"
          },
          {
            "descuento",
            "descuento"
          },
          {
            "porcentajeIva",
            "porcentajeIva"
          },
          {
            "iva",
            "iva"
          },
          {
            "neto",
            "neto"
          },
          {
            "total",
            "total"
          },
          {
            "totalPalabras",
            "totalPalabras"
          },
          {
            "estadoPago",
            "estadoPago"
          },
          {
            "estadoDocumento",
            "estadoDocumento"
          },
          {
            "documentoVenta",
            "documentoVenta"
          },
          {
            "idDocumentoVenta",
            "idDocumentoVenta"
          },
          {
            "folioDocumentoVenta",
            "folioDocumentoVenta"
          },
          {
            "comisionVendedor",
            "comisionVendedor"
          },
          {
            "porcentajeImpuesto5",
            "porcentajeImpuesto5"
          },
          {
            "porcentajeImpuesto4",
            "porcentajeImpuesto4"
          },
          {
            "porcentajeImpuesto3",
            "porcentajeImpuesto3"
          },
          {
            "porcentajeImpuesto2",
            "porcentajeImpuesto2"
          },
          {
            "porcentajeImpuesto1",
            "porcentajeImpuesto1"
          },
          {
            "impuesto5",
            "impuesto5"
          },
          {
            "impuesto4",
            "impuesto4"
          },
          {
            "impuesto3",
            "impuesto3"
          },
          {
            "impuesto2",
            "impuesto2"
          },
          {
            "impuesto1",
            "impuesto1"
          },
          {
            "caja",
            "caja"
          },
          {
            "idDetalleCotizacion",
            "idDetalleCotizacion"
          },
          {
            "idCotizacionLinea",
            "idCotizacionLinea"
          },
          {
            "folioCotizacion",
            "folioCotizacion"
          },
          {
            "codigo",
            "codigo"
          },
          {
            "valorVenta",
            "valorVenta"
          },
          {
            "descripcion",
            "descripcion"
          },
          {
            "cantidad",
            "cantidad"
          },
          {
            "porcentajeDescuentoLinea",
            "porcentajeDescuentoLinea"
          },
          {
            "descuentoLinea",
            "descuentoLinea"
          },
          {
            "subtotalLinea",
            "subtotalLinea"
          },
          {
            "totalLinea",
            "totalLinea"
          },
          {
            "tipoDescuento",
            "tipoDescuento"
          },
          {
            "listaPrecio",
            "listaPrecio"
          },
          {
            "bodega",
            "bodega"
          },
          {
            "idImpuesto",
            "idImpuesto"
          },
          {
            "netoLinea",
            "netoLinea"
          },
          {
            "imagen1",
            "imagen1"
          },
          {
            "imagen2",
            "imagen2"
          },
          {
            "imagen3",
            "imagen3"
          }
        }
      });
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitConnection()
    {
      this._connection = new MySqlConnection();
      ((DbConnection) this._connection).ConnectionString = Settings.Default.AptusoftConnectionString;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitCommandCollection()
    {
      this._commandCollection = new MySqlCommand[1];
      this._commandCollection[0] = new MySqlCommand();
      this._commandCollection[0].Connection=this.Connection;
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        cotizacion.idCotizacion, cotizacion.folio, cotizacion.fechaEmision, cotizacion.fechaVencimiento, cotizacion.dia, cotizacion.mes, cotizacion.ano, cotizacion.idCliente, \r\n                         cotizacion.rut, cotizacion.digito, cotizacion.razonSocial, cotizacion.direccion, cotizacion.comuna, cotizacion.ciudad, cotizacion.giro, cotizacion.fono, cotizacion.fax, \r\n                         cotizacion.contacto, cotizacion.diasPlazo, cotizacion.idMedioPago, cotizacion.medioPago, cotizacion.idVendedor, cotizacion.vendedor, cotizacion.idCentroCosto, \r\n                         cotizacion.centroCosto, cotizacion.ordenCompra, cotizacion.subtotal, cotizacion.porcentajeDescuento, cotizacion.descuento, cotizacion.porcentajeIva, cotizacion.iva, \r\n                         cotizacion.neto, cotizacion.total, cotizacion.totalPalabras, cotizacion.estadoPago, cotizacion.estadoDocumento, cotizacion.documentoVenta, \r\n                         cotizacion.idDocumentoVenta, cotizacion.folioDocumentoVenta, cotizacion.comisionVendedor, cotizacion.porcentajeImpuesto5, cotizacion.porcentajeImpuesto4, \r\n                         cotizacion.porcentajeImpuesto3, cotizacion.porcentajeImpuesto2, cotizacion.porcentajeImpuesto1, cotizacion.impuesto5, cotizacion.impuesto4, \r\n                         cotizacion.impuesto3, cotizacion.impuesto2, cotizacion.impuesto1, cotizacion.caja, detallecotizacion.idDetalleCotizacion, detallecotizacion.idCotizacionLinea, \r\n                         detallecotizacion.folioCotizacion, detallecotizacion.codigo, detallecotizacion.valorVenta, detallecotizacion.descripcion, detallecotizacion.cantidad, \r\n                         detallecotizacion.porcentajeDescuentoLinea, detallecotizacion.descuentoLinea, detallecotizacion.subtotalLinea, detallecotizacion.totalLinea, \r\n                         detallecotizacion.tipoDescuento, detallecotizacion.listaPrecio, detallecotizacion.bodega, detallecotizacion.idImpuesto, detallecotizacion.netoLinea, \r\n                         imagenes.imagen1, imagenes.imagen2, imagenes.imagen3\r\nFROM            cotizacion, detallecotizacion, imagenes";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Fill(DtsReportes.CotizacionDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual DtsReportes.CotizacionDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.CotizacionDataTable cotizacionDataTable = new DtsReportes.CotizacionDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) cotizacionDataTable);
      return cotizacionDataTable;
    }
  }
}
