 
// Type: Aptusoft.DtsReportesTableAdapters.OrdenCompraTableAdapter
 
 
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
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  [ToolboxItem(true)]
  [DataObject(true)]
  public class OrdenCompraTableAdapter : Component
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public OrdenCompraTableAdapter()
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
        DataSetTable = "OrdenCompra",
        ColumnMappings = {
          {
            "idOrdenCompra",
            "idOrdenCompra"
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
            "idDetalleOrdenCompra",
            "idDetalleOrdenCompra"
          },
          {
            "idOrdenCompraLinea",
            "idOrdenCompraLinea"
          },
          {
            "folioOrdenCompra",
            "folioOrdenCompra"
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
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        ordencompra.idOrdenCompra, ordencompra.folio, ordencompra.fechaEmision, ordencompra.fechaVencimiento, ordencompra.dia, ordencompra.mes, \r\n                         ordencompra.ano, ordencompra.idProveedor, ordencompra.rut, ordencompra.digito, ordencompra.razonSocial, ordencompra.direccion, ordencompra.comuna, \r\n                         ordencompra.ciudad, ordencompra.giro, ordencompra.fono, ordencompra.fax, ordencompra.contacto, ordencompra.diasPlazo, ordencompra.idMedioPago, \r\n                         ordencompra.medioPago, ordencompra.idCentroCosto, ordencompra.centroCosto, ordencompra.ordenCompra, ordencompra.subtotal, \r\n                         ordencompra.porcentajeDescuento, ordencompra.descuento, ordencompra.porcentajeIva, ordencompra.iva, ordencompra.neto, ordencompra.total, \r\n                         ordencompra.totalPalabras, ordencompra.estadoPago, ordencompra.estadoDocumento, ordencompra.totalPagado, ordencompra.totalDocumentado, \r\n                         ordencompra.totalPendiente, detalleordencompra.idDetalleOrdenCompra, detalleordencompra.idOrdenCompraLinea, detalleordencompra.folioOrdenCompra, \r\n                         detalleordencompra.codigo, detalleordencompra.descripcion, detalleordencompra.valorVenta, detalleordencompra.cantidad, \r\n                         detalleordencompra.porcentajeDescuentoLinea, detalleordencompra.descuentoLinea, detalleordencompra.subtotalLinea, detalleordencompra.totalLinea, \r\n                         detalleordencompra.tipoDescuento, detalleordencompra.bodega\r\nFROM            ordencompra INNER JOIN\r\n                         detalleordencompra ON ordencompra.idOrdenCompra = detalleordencompra.idOrdenCompraLinea AND ordencompra.folio = detalleordencompra.folioOrdenCompra";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(DtsReportes.OrdenCompraDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual DtsReportes.OrdenCompraDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.OrdenCompraDataTable ordenCompraDataTable = new DtsReportes.OrdenCompraDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) ordenCompraDataTable);
      return ordenCompraDataTable;
    }
  }
}
