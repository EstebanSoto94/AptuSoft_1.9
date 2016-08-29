 
// Type: Aptusoft.DtsReportesTableAdapters.FacturaTableAdapter
 
 
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
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [DataObject(true)]
  [HelpKeyword("vs.data.TableAdapter")]
  [ToolboxItem(true)]
  [DesignerCategory("code")]
  public class FacturaTableAdapter : Component
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
    public FacturaTableAdapter()
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
        DataSetTable = "Factura",
        ColumnMappings = {
          {
            "idFactura",
            "idFactura"
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
            "idFacturaLinea",
            "idFacturaLinea"
          },
          {
            "idDetallefactura",
            "idDetallefactura"
          },
          {
            "folioFactura",
            "folioFactura"
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
            "listaPrecio",
            "listaPrecio"
          },
          {
            "bodega",
            "bodega"
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
            "porcentajeImpuesto2",
            "porcentajeImpuesto2"
          },
          {
            "porcentajeImpuesto1",
            "porcentajeImpuesto1"
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
          }
        }
      });
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitConnection()
    {
      this._connection = new MySqlConnection();
      ((DbConnection) this._connection).ConnectionString = Settings.Default.AptusoftConnectionString;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new MySqlCommand[1];
      this._commandCollection[0] = new MySqlCommand();
      this._commandCollection[0].Connection=this.Connection;
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        facturas.idFactura, facturas.folio, facturas.fechaEmision, facturas.fechaVencimiento, facturas.idCliente, facturas.rut, facturas.digito, facturas.razonSocial, \r\n                         facturas.direccion, facturas.comuna, facturas.ciudad, facturas.giro, facturas.fono, facturas.fax, facturas.contacto, facturas.diasPlazo, facturas.idMedioPago, \r\n                         facturas.medioPago, facturas.idVendedor, facturas.vendedor, facturas.idCentroCosto, facturas.centroCosto, facturas.ordenCompra, facturas.subtotal, \r\n                         facturas.porcentajeDescuento, facturas.descuento, facturas.porcentajeIva, facturas.iva, facturas.neto, facturas.total, facturas.totalPalabras, facturas.estadoPago, \r\n                         facturas.estadoDocumento, detallefactura.idFacturaLinea, detallefactura.idDetallefactura, detallefactura.folioFactura, detallefactura.codigo, detallefactura.descripcion, \r\n                         detallefactura.valorVenta, detallefactura.cantidad, detallefactura.porcentajeDescuentoLinea, detallefactura.descuentoLinea, detallefactura.subtotalLinea, \r\n                         detallefactura.totalLinea, detallefactura.tipoDescuento, detallefactura.listaPrecio, detallefactura.bodega, facturas.totalPagado, facturas.totalDocumentado, \r\n                         facturas.totalPendiente, facturas.impuesto1, facturas.impuesto2, facturas.impuesto3, facturas.impuesto4, facturas.impuesto5, facturas.porcentajeImpuesto2, \r\n                         facturas.porcentajeImpuesto1, facturas.porcentajeImpuesto3, facturas.porcentajeImpuesto4, facturas.porcentajeImpuesto5, detallefactura.idImpuesto, \r\n                         detallefactura.netoLinea\r\nFROM            facturas INNER JOIN\r\n                         detallefactura ON facturas.idFactura = detallefactura.idFacturaLinea";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int Fill(DtsReportes.FacturaDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    public virtual DtsReportes.FacturaDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.FacturaDataTable facturaDataTable = new DtsReportes.FacturaDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) facturaDataTable);
      return facturaDataTable;
    }
  }
}
