 
// Type: Aptusoft.DtsReportesTableAdapters.GuiaTableAdapter
 
 
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
  public class GuiaTableAdapter : Component
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
    public GuiaTableAdapter()
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
        DataSetTable = "Guia",
        ColumnMappings = {
          {
            "idGuia",
            "idGuia"
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
            "descuentaInventario",
            "descuentaInventario"
          },
          {
            "tipoGuia",
            "tipoGuia"
          },
          {
            "idDetalleguia",
            "idDetalleguia"
          },
          {
            "idGuiaLinea",
            "idGuiaLinea"
          },
          {
            "folioGuia",
            "folioGuia"
          },
          {
            "codigo",
            "codigo"
          },
          {
            "bodegaDestino",
            "bodegaDestino"
          },
          {
            "bodega",
            "bodega"
          },
          {
            "listaPrecio",
            "listaPrecio"
          },
          {
            "tipoDescuento",
            "tipoDescuento"
          },
          {
            "totalLinea",
            "totalLinea"
          },
          {
            "subtotalLinea",
            "subtotalLinea"
          },
          {
            "descuentoLinea",
            "descuentoLinea"
          },
          {
            "porcentajeDescuentoLinea",
            "porcentajeDescuentoLinea"
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
            "descripcion",
            "descripcion"
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
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        guias.idGuia, guias.folio, guias.fechaEmision, guias.fechaVencimiento, guias.dia, guias.mes, guias.ano, guias.idCliente, guias.rut, guias.digito, guias.razonSocial, \r\n                         guias.direccion, guias.comuna, guias.ciudad, guias.giro, guias.fono, guias.fax, guias.contacto, guias.diasPlazo, guias.idMedioPago, guias.medioPago, \r\n                         guias.idVendedor, guias.vendedor, guias.idCentroCosto, guias.centroCosto, guias.ordenCompra, guias.subtotal, guias.porcentajeDescuento, guias.descuento, \r\n                         guias.porcentajeIva, guias.iva, guias.neto, guias.total, guias.totalPalabras, guias.estadoPago, guias.estadoDocumento, guias.totalPagado, guias.totalDocumentado, \r\n                         guias.totalPendiente, guias.descuentaInventario, guias.tipoGuia, detalleguia.idDetalleguia, detalleguia.idGuiaLinea, detalleguia.folioGuia, detalleguia.codigo, \r\n                         detalleguia.bodegaDestino, detalleguia.bodega, detalleguia.listaPrecio, detalleguia.tipoDescuento, detalleguia.totalLinea, detalleguia.subtotalLinea, \r\n                         detalleguia.descuentoLinea, detalleguia.porcentajeDescuentoLinea, detalleguia.cantidad, detalleguia.valorVenta, detalleguia.descripcion, guias.comisionVendedor, \r\n                         guias.porcentajeImpuesto5, guias.porcentajeImpuesto4, guias.porcentajeImpuesto3, guias.porcentajeImpuesto2, guias.porcentajeImpuesto1, guias.impuesto5, \r\n                         guias.impuesto4, guias.impuesto3, guias.impuesto2, guias.impuesto1, detalleguia.idImpuesto, detalleguia.netoLinea\r\nFROM            guias INNER JOIN\r\n                         detalleguia ON guias.idGuia = detalleguia.idGuiaLinea AND guias.folio = detalleguia.folioGuia";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    public virtual int Fill(DtsReportes.GuiaDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual DtsReportes.GuiaDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.GuiaDataTable guiaDataTable = new DtsReportes.GuiaDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) guiaDataTable);
      return guiaDataTable;
    }
  }
}
