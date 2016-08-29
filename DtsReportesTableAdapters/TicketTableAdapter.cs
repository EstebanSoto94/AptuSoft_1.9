 
// Type: Aptusoft.DtsReportesTableAdapters.TicketTableAdapter
 
 
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
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [DataObject(true)]
  public class TicketTableAdapter : Component
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
    public TicketTableAdapter()
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
        DataSetTable = "Ticket",
        ColumnMappings = {
          {
            "idTicket",
            "idTicket"
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
            "idDetalleTicket",
            "idDetalleTicket"
          },
          {
            "idTicketLinea",
            "idTicketLinea"
          },
          {
            "folioTicket",
            "folioTicket"
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
            "tipoDescuento",
            "tipoDescuento"
          },
          {
            "totalLinea",
            "totalLinea"
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
            "idDocumentoVenta",
            "idDocumentoVenta"
          },
          {
            "folioDocumentoVenta",
            "folioDocumentoVenta"
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
            "comisionVendedor",
            "comisionVendedor"
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
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        ticket.idTicket, ticket.folio, ticket.fechaEmision, ticket.fechaVencimiento, ticket.dia, ticket.mes, ticket.ano, ticket.idCliente, ticket.rut, ticket.digito, ticket.razonSocial, \r\n                         ticket.direccion, ticket.comuna, ticket.ciudad, ticket.giro, ticket.fono, ticket.fax, ticket.contacto, ticket.diasPlazo, ticket.idMedioPago, ticket.medioPago, \r\n                         ticket.idVendedor, ticket.vendedor, ticket.idCentroCosto, ticket.centroCosto, ticket.ordenCompra, ticket.subtotal, ticket.porcentajeDescuento, ticket.descuento, \r\n                         ticket.porcentajeIva, ticket.iva, ticket.neto, ticket.total, ticket.totalPalabras, ticket.estadoPago, ticket.estadoDocumento, ticket.documentoVenta, \r\n                         detalleticket.idDetalleTicket, detalleticket.idTicketLinea, detalleticket.folioTicket, detalleticket.codigo, detalleticket.descripcion, detalleticket.valorVenta, \r\n                         detalleticket.cantidad, detalleticket.porcentajeDescuentoLinea, detalleticket.descuentoLinea, detalleticket.subtotalLinea, detalleticket.tipoDescuento, \r\n                         detalleticket.totalLinea, detalleticket.listaPrecio, detalleticket.bodega, ticket.idDocumentoVenta, ticket.folioDocumentoVenta, ticket.impuesto1, ticket.impuesto2, \r\n                         ticket.porcentajeImpuesto2, ticket.porcentajeImpuesto3, ticket.porcentajeImpuesto4, ticket.porcentajeImpuesto5, ticket.comisionVendedor, ticket.porcentajeImpuesto1,\r\n                          ticket.impuesto5, ticket.impuesto4, ticket.impuesto3, detalleticket.idImpuesto, detalleticket.netoLinea\r\nFROM            ticket INNER JOIN\r\n                         detalleticket ON ticket.idTicket = detalleticket.idTicketLinea AND ticket.folio = detalleticket.folioTicket";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int Fill(DtsReportes.TicketDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual DtsReportes.TicketDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.TicketDataTable ticketDataTable = new DtsReportes.TicketDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) ticketDataTable);
      return ticketDataTable;
    }
  }
}
