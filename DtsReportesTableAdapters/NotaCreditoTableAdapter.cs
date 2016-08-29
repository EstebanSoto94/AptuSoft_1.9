 
// Type: Aptusoft.DtsReportesTableAdapters.NotaCreditoTableAdapter
 
 
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
  [HelpKeyword("vs.data.TableAdapter")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class NotaCreditoTableAdapter : Component
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
    public NotaCreditoTableAdapter()
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
        DataSetTable = "NotaCredito",
        ColumnMappings = {
          {
            "idNotaCredito",
            "idNotaCredito"
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
            "folioFactura",
            "folioFactura"
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
            "descuentaInventario",
            "descuentaInventario"
          },
          {
            "idDetallenotaCredito",
            "idDetallenotaCredito"
          },
          {
            "idNotaCreditoLinea",
            "idNotaCreditoLinea"
          },
          {
            "folioNotaCredito",
            "folioNotaCredito"
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
            "cantidad",
            "cantidad"
          },
          {
            "valorVenta",
            "valorVenta"
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
            "impuesto1",
            "impuesto1"
          },
          {
            "impuesto2",
            "impuesto2"
          },
          {
            "impuesto3",
            "impuesto3"
          },
          {
            "impuesto4",
            "impuesto4"
          },
          {
            "impuesto5",
            "impuesto5"
          },
          {
            "porcentajeImpuesto1",
            "porcentajeImpuesto1"
          },
          {
            "porcentajeImpuesto2",
            "porcentajeImpuesto2"
          },
          {
            "porcentajeImpuesto3",
            "porcentajeImpuesto3"
          },
          {
            "porcentajeImpuesto4",
            "porcentajeImpuesto4"
          },
          {
            "porcentajeImpuesto5",
            "porcentajeImpuesto5"
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
            "comisionVendedor",
            "comisionVendedor"
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
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        notacredito.idNotaCredito, notacredito.folio, notacredito.fechaEmision, notacredito.fechaVencimiento, notacredito.dia, notacredito.mes, notacredito.ano, \r\n                         notacredito.idCliente, notacredito.rut, notacredito.digito, notacredito.razonSocial, notacredito.direccion, notacredito.comuna, notacredito.ciudad, notacredito.giro, \r\n                         notacredito.fono, notacredito.fax, notacredito.contacto, notacredito.diasPlazo, notacredito.idMedioPago, notacredito.medioPago, notacredito.idVendedor, \r\n                         notacredito.vendedor, notacredito.idCentroCosto, notacredito.centroCosto, notacredito.folioFactura, notacredito.subtotal, notacredito.porcentajeDescuento, \r\n                         notacredito.descuento, notacredito.porcentajeIva, notacredito.iva, notacredito.neto, notacredito.total, notacredito.totalPalabras, notacredito.estadoPago, \r\n                         notacredito.estadoDocumento, notacredito.totalPagado, notacredito.totalDocumentado, notacredito.totalPendiente, notacredito.descuentaInventario, \r\n                         detallenotacredito.idDetallenotaCredito, detallenotacredito.idNotaCreditoLinea, detallenotacredito.folioNotaCredito, detallenotacredito.codigo, \r\n                         detallenotacredito.descripcion, detallenotacredito.cantidad, detallenotacredito.valorVenta, detallenotacredito.porcentajeDescuentoLinea, \r\n                         detallenotacredito.descuentoLinea, detallenotacredito.subtotalLinea, detallenotacredito.totalLinea, detallenotacredito.tipoDescuento, detallenotacredito.listaPrecio, \r\n                         detallenotacredito.bodega, notacredito.impuesto1, notacredito.impuesto2, notacredito.impuesto3, notacredito.impuesto4, notacredito.impuesto5, \r\n                         notacredito.porcentajeImpuesto1, notacredito.porcentajeImpuesto2, notacredito.porcentajeImpuesto3, notacredito.porcentajeImpuesto4, \r\n                         notacredito.porcentajeImpuesto5, detallenotacredito.idImpuesto, detallenotacredito.netoLinea, notacredito.comisionVendedor\r\nFROM            notacredito INNER JOIN\r\n                         detallenotacredito ON notacredito.idNotaCredito = detallenotacredito.idNotaCreditoLinea AND notacredito.folio = detallenotacredito.folioNotaCredito";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(DtsReportes.NotaCreditoDataTable dataTable)
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
    public virtual DtsReportes.NotaCreditoDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.NotaCreditoDataTable creditoDataTable = new DtsReportes.NotaCreditoDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) creditoDataTable);
      return creditoDataTable;
    }
  }
}
