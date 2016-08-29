 
// Type: Aptusoft.DtsReportesTableAdapters.CompraTableAdapter
 
 
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
  [DataObject(true)]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [HelpKeyword("vs.data.TableAdapter")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class CompraTableAdapter : Component
  {
    private MySqlDataAdapter _adapter;
    private MySqlConnection _connection;
    private MySqlTransaction _transaction;
    private MySqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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
    public CompraTableAdapter()
    {
      this.ClearBeforeFill = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitAdapter()
    {
      this._adapter = new MySqlDataAdapter();
      ((DataAdapter) this._adapter).TableMappings.Add((object) new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "Compra",
        ColumnMappings = {
          {
            "idCompra",
            "idCompra"
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
            "idProveedor",
            "idProveedor"
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
            "totalPagado",
            "totalPagado"
          },
          {
            "totalDocumentado",
            "totalDocumentado"
          },
          {
            "totalPendiente",
            "totalPendiente"
          },
          {
            "idTipoDocumentoCompra",
            "idTipoDocumentoCompra"
          },
          {
            "tipoDocumentoCompra",
            "tipoDocumentoCompra"
          },
          {
            "idDetallecompra",
            "idDetallecompra"
          },
          {
            "idCompraLinea",
            "idCompraLinea"
          },
          {
            "rutProveedor",
            "rutProveedor"
          },
          {
            "folioCompra",
            "folioCompra"
          },
          {
            "codigo",
            "codigo"
          },
          {
            "descripcion",
            "descripcion"
          },
          {
            "valorVenta",
            "valorVenta"
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
            "bodega",
            "bodega"
          },
          {
            "idTipoDocumentoCompraLinea",
            "idTipoDocumentoCompraLinea"
          },
          {
            "tipoDocumentoCompraLinea",
            "tipoDocumentoCompraLinea"
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
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        compras.idCompra, compras.folio, compras.fechaEmision, compras.fechaVencimiento, compras.dia, compras.mes, compras.ano, compras.idProveedor, compras.rut, \r\n                         compras.digito, compras.razonSocial, compras.direccion, compras.comuna, compras.ciudad, compras.giro, compras.fono, compras.fax, compras.contacto, \r\n                         compras.diasPlazo, compras.idMedioPago, compras.medioPago, compras.idCentroCosto, compras.centroCosto, compras.ordenCompra, compras.subtotal, \r\n                         compras.porcentajeDescuento, compras.descuento, compras.porcentajeIva, compras.iva, compras.neto, compras.total, compras.totalPalabras, compras.estadoPago, \r\n                         compras.estadoDocumento, compras.totalPagado, compras.totalDocumentado, compras.totalPendiente, compras.idTipoDocumentoCompra, \r\n                         compras.tipoDocumentoCompra, detallecompra.idDetallecompra, detallecompra.idCompraLinea, detallecompra.rutProveedor, detallecompra.folioCompra, \r\n                         detallecompra.codigo, detallecompra.descripcion, detallecompra.valorVenta, detallecompra.cantidad, detallecompra.porcentajeDescuentoLinea, \r\n                         detallecompra.descuentoLinea, detallecompra.subtotalLinea, detallecompra.totalLinea, detallecompra.tipoDescuento, detallecompra.bodega, \r\n                         detallecompra.idTipoDocumentoCompraLinea, detallecompra.tipoDocumentoCompraLinea\r\nFROM            compras INNER JOIN\r\n                         detallecompra ON compras.idCompra = detallecompra.idCompraLinea AND compras.folio = detallecompra.folioCompra";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int Fill(DtsReportes.CompraDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public virtual DtsReportes.CompraDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.CompraDataTable compraDataTable = new DtsReportes.CompraDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) compraDataTable);
      return compraDataTable;
    }
  }
}
