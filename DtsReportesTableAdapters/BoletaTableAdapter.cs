 
// Type: Aptusoft.DtsReportesTableAdapters.BoletaTableAdapter
 
 
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
  [HelpKeyword("vs.data.TableAdapter")]
  [DataObject(true)]
  [ToolboxItem(true)]
  [DesignerCategory("code")]
  public class BoletaTableAdapter : Component
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public BoletaTableAdapter()
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
        DataSetTable = "Boleta",
        ColumnMappings = {
          {
            "idBoleta",
            "idBoleta"
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
            "pagaCon",
            "pagaCon"
          },
          {
            "vuelto",
            "vuelto"
          },
          {
            "idDetalleboleta",
            "idDetalleboleta"
          },
          {
            "idBoletaLinea",
            "idBoletaLinea"
          },
          {
            "folioBoleta",
            "folioBoleta"
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    private void InitCommandCollection()
    {
      this._commandCollection = new MySqlCommand[1];
      this._commandCollection[0] = new MySqlCommand();
      this._commandCollection[0].Connection=this.Connection;
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        boletas.idBoleta, boletas.folio, boletas.fechaEmision, boletas.fechaVencimiento, boletas.dia, boletas.mes, boletas.ano, boletas.idCliente, boletas.rut, boletas.digito, \r\n                         boletas.razonSocial, boletas.direccion, boletas.comuna, boletas.ciudad, boletas.giro, boletas.fono, boletas.fax, boletas.contacto, boletas.diasPlazo, \r\n                         boletas.idMedioPago, boletas.medioPago, boletas.idVendedor, boletas.vendedor, boletas.idCentroCosto, boletas.centroCosto, boletas.ordenCompra, \r\n                         boletas.subtotal, boletas.porcentajeDescuento, boletas.descuento, boletas.porcentajeIva, boletas.iva, boletas.neto, boletas.total, boletas.totalPalabras, \r\n                         boletas.estadoPago, boletas.estadoDocumento, boletas.totalPagado, boletas.totalDocumentado, boletas.totalPendiente, boletas.pagaCon, boletas.vuelto, \r\n                         detalleboleta.idDetalleboleta, detalleboleta.idBoletaLinea, detalleboleta.folioBoleta, detalleboleta.codigo, detalleboleta.descripcion, detalleboleta.valorVenta, \r\n                         detalleboleta.cantidad, detalleboleta.porcentajeDescuentoLinea, detalleboleta.descuentoLinea, detalleboleta.subtotalLinea, detalleboleta.totalLinea, \r\n                         detalleboleta.tipoDescuento, detalleboleta.listaPrecio, detalleboleta.bodega\r\nFROM            boletas INNER JOIN\r\n                         detalleboleta ON boletas.idBoleta = detalleboleta.idBoletaLinea AND boletas.folio = detalleboleta.folioBoleta";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(DtsReportes.BoletaDataTable dataTable)
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
    public virtual DtsReportes.BoletaDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.BoletaDataTable boletaDataTable = new DtsReportes.BoletaDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) boletaDataTable);
      return boletaDataTable;
    }
  }
}
