 
// Type: Aptusoft.DtsReportesTableAdapters.FacturasTableAdapter
 
 
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
  public class FacturasTableAdapter : Component
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
    public FacturasTableAdapter()
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
        DataSetTable = "Facturas",
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
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        idFactura, folio, fechaEmision, fechaVencimiento, idCliente, rut, digito, razonSocial, direccion, comuna, ciudad, giro, fono, fax, contacto, diasPlazo, idMedioPago, \r\n                         medioPago, idVendedor, vendedor, idCentroCosto, centroCosto, ordenCompra, subtotal, porcentajeDescuento, descuento, porcentajeIva, iva, neto, total, \r\n                         totalPalabras, estadoPago, estadoDocumento, totalPagado, totalDocumentado, totalPendiente, impuesto1, impuesto2, impuesto3, impuesto4, impuesto5, \r\n                         porcentajeImpuesto2, porcentajeImpuesto1, porcentajeImpuesto3, porcentajeImpuesto4, porcentajeImpuesto5, comisionVendedor\r\nFROM            facturas";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(DtsReportes.FacturasDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual DtsReportes.FacturasDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.FacturasDataTable facturasDataTable = new DtsReportes.FacturasDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) facturasDataTable);
      return facturasDataTable;
    }
  }
}
