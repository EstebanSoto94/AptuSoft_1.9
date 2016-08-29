 
// Type: Aptusoft.DtsReportesTableAdapters.FacturaPagosVentasTableAdapter
 
 
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
  [ToolboxItem(true)]
  [DataObject(true)]
  [HelpKeyword("vs.data.TableAdapter")]
  [DesignerCategory("code")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class FacturaPagosVentasTableAdapter : Component
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
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
    public FacturaPagosVentasTableAdapter()
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
        DataSetTable = "FacturaPagosVentas",
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
            "idPagoVenta",
            "idPagoVenta"
          },
          {
            "tipoDocumento",
            "tipoDocumento"
          },
          {
            "idDocumento",
            "idDocumento"
          },
          {
            "folioDocumento",
            "folioDocumento"
          },
          {
            "idMedioPagoPV",
            "idMedioPagoPV"
          },
          {
            "medioPagoPV",
            "medioPagoPV"
          },
          {
            "estadoPagoPV",
            "estadoPagoPV"
          },
          {
            "monto",
            "monto"
          },
          {
            "fechaCobro",
            "fechaCobro"
          },
          {
            "fechaIngreso",
            "fechaIngreso"
          },
          {
            "banco",
            "banco"
          },
          {
            "cuenta",
            "cuenta"
          },
          {
            "numeroDocumento",
            "numeroDocumento"
          },
          {
            "observaciones",
            "observaciones"
          },
          {
            "totalaCobrar",
            "totalaCobrar"
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

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new MySqlCommand[1];
      this._commandCollection[0] = new MySqlCommand();
      this._commandCollection[0].Connection=this.Connection;
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        facturas.idFactura, facturas.folio, facturas.fechaEmision, facturas.fechaVencimiento, facturas.dia, facturas.mes, facturas.ano, facturas.idCliente, facturas.rut, \r\n                         facturas.digito, facturas.razonSocial, facturas.direccion, facturas.comuna, facturas.ciudad, facturas.giro, facturas.fono, facturas.fax, facturas.contacto, \r\n                         facturas.diasPlazo, facturas.idMedioPago, facturas.medioPago, facturas.idVendedor, facturas.vendedor, facturas.idCentroCosto, facturas.centroCosto, \r\n                         facturas.ordenCompra, facturas.subtotal, facturas.porcentajeDescuento, facturas.descuento, facturas.porcentajeIva, facturas.iva, facturas.neto, facturas.total, \r\n                         facturas.totalPalabras, facturas.estadoPago, facturas.estadoDocumento, facturas.totalPagado, facturas.totalDocumentado, facturas.totalPendiente, \r\n                         pagosventas.idPagoVenta, pagosventas.tipoDocumento, pagosventas.idDocumento, pagosventas.folioDocumento, pagosventas.idMedioPagoPV, \r\n                         pagosventas.medioPagoPV, pagosventas.estadoPagoPV, pagosventas.monto, pagosventas.fechaCobro, pagosventas.fechaIngreso, pagosventas.banco, \r\n                         pagosventas.cuenta, pagosventas.numeroDocumento, pagosventas.observaciones\r\nFROM            facturas INNER JOIN\r\n                         pagosventas ON facturas.idFactura = pagosventas.idDocumento AND facturas.folio = pagosventas.folioDocumento";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(DtsReportes.FacturaPagosVentasDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual DtsReportes.FacturaPagosVentasDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.FacturaPagosVentasDataTable pagosVentasDataTable = new DtsReportes.FacturaPagosVentasDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) pagosVentasDataTable);
      return pagosVentasDataTable;
    }
  }
}
