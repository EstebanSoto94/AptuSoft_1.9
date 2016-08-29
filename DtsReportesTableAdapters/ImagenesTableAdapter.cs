 
// Type: Aptusoft.DtsReportesTableAdapters.ImagenesTableAdapter
 
 
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
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [DataObject(true)]
  public class ImagenesTableAdapter : Component
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
    public ImagenesTableAdapter()
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
        DataSetTable = "Imagenes",
        ColumnMappings = {
          {
            "idImagen",
            "idImagen"
          },
          {
            "codigoProducto",
            "codigoProducto"
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
      this._adapter.DeleteCommand=new MySqlCommand();
      this._adapter.DeleteCommand.Connection=this.Connection;
      ((DbCommand) this._adapter.DeleteCommand).CommandText = "DELETE FROM `imagenes` WHERE ((`idImagen` = @Original_idImagen) AND (`codigoProducto` = @Original_codigoProducto) AND ((@IsNull_imagen1 = 1 AND `imagen1` IS NULL) OR (`imagen1` = @Original_imagen1)) AND ((@IsNull_imagen2 = 1 AND `imagen2` IS NULL) OR (`imagen2` = @Original_imagen2)) AND ((@IsNull_imagen3 = 1 AND `imagen3` IS NULL) OR (`imagen3` = @Original_imagen3)))";
      ((DbCommand) this._adapter.DeleteCommand).CommandType = CommandType.Text;
      MySqlParameter mySqlParameter1 = new MySqlParameter();
      ((DbParameter) mySqlParameter1).ParameterName = "@Original_idImagen";
      ((DbParameter) mySqlParameter1).DbType = DbType.Int32;
      mySqlParameter1.MySqlDbType=(MySqlDbType) 3;
      ((DbParameter) mySqlParameter1).IsNullable = true;
      ((DbParameter) mySqlParameter1).SourceColumn = "idImagen";
      ((DbParameter) mySqlParameter1).SourceVersion = DataRowVersion.Original;
      this._adapter.DeleteCommand.Parameters.Add(mySqlParameter1);
      MySqlParameter mySqlParameter2 = new MySqlParameter();
      ((DbParameter) mySqlParameter2).ParameterName = "@Original_codigoProducto";
      ((DbParameter) mySqlParameter2).DbType = DbType.String;
      mySqlParameter2.MySqlDbType=(MySqlDbType) 253;
      ((DbParameter) mySqlParameter2).IsNullable = true;
      ((DbParameter) mySqlParameter2).SourceColumn = "codigoProducto";
      ((DbParameter) mySqlParameter2).SourceVersion = DataRowVersion.Original;
      this._adapter.DeleteCommand.Parameters.Add(mySqlParameter2);
      MySqlParameter mySqlParameter3 = new MySqlParameter();
      ((DbParameter) mySqlParameter3).ParameterName = "@IsNull_imagen1";
      ((DbParameter) mySqlParameter3).DbType = DbType.Int32;
      mySqlParameter3.MySqlDbType=(MySqlDbType) 3;
      ((DbParameter) mySqlParameter3).IsNullable = true;
      ((DbParameter) mySqlParameter3).SourceColumn = "imagen1";
      ((DbParameter) mySqlParameter3).SourceVersion = DataRowVersion.Original;
      ((DbParameter) mySqlParameter3).SourceColumnNullMapping = true;
      this._adapter.DeleteCommand.Parameters.Add(mySqlParameter3);
      MySqlParameter mySqlParameter4 = new MySqlParameter();
      ((DbParameter) mySqlParameter4).ParameterName = "@Original_imagen1";
      ((DbParameter) mySqlParameter4).DbType = DbType.Object;
      mySqlParameter4.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter4).IsNullable = true;
      ((DbParameter) mySqlParameter4).SourceColumn = "imagen1";
      ((DbParameter) mySqlParameter4).SourceVersion = DataRowVersion.Original;
      this._adapter.DeleteCommand.Parameters.Add(mySqlParameter4);
      MySqlParameter mySqlParameter5 = new MySqlParameter();
      ((DbParameter) mySqlParameter5).ParameterName = "@IsNull_imagen2";
      ((DbParameter) mySqlParameter5).DbType = DbType.Int32;
      mySqlParameter5.MySqlDbType=(MySqlDbType) 3;
      ((DbParameter) mySqlParameter5).IsNullable = true;
      ((DbParameter) mySqlParameter5).SourceColumn = "imagen2";
      ((DbParameter) mySqlParameter5).SourceVersion = DataRowVersion.Original;
      ((DbParameter) mySqlParameter5).SourceColumnNullMapping = true;
      this._adapter.DeleteCommand.Parameters.Add(mySqlParameter5);
      MySqlParameter mySqlParameter6 = new MySqlParameter();
      ((DbParameter) mySqlParameter6).ParameterName = "@Original_imagen2";
      ((DbParameter) mySqlParameter6).DbType = DbType.Object;
      mySqlParameter6.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter6).IsNullable = true;
      ((DbParameter) mySqlParameter6).SourceColumn = "imagen2";
      ((DbParameter) mySqlParameter6).SourceVersion = DataRowVersion.Original;
      this._adapter.DeleteCommand.Parameters.Add(mySqlParameter6);
      MySqlParameter mySqlParameter7 = new MySqlParameter();
      ((DbParameter) mySqlParameter7).ParameterName = "@IsNull_imagen3";
      ((DbParameter) mySqlParameter7).DbType = DbType.Int32;
      mySqlParameter7.MySqlDbType=(MySqlDbType) 3;
      ((DbParameter) mySqlParameter7).IsNullable = true;
      ((DbParameter) mySqlParameter7).SourceColumn = "imagen3";
      ((DbParameter) mySqlParameter7).SourceVersion = DataRowVersion.Original;
      ((DbParameter) mySqlParameter7).SourceColumnNullMapping = true;
      this._adapter.DeleteCommand.Parameters.Add(mySqlParameter7);
      MySqlParameter mySqlParameter8 = new MySqlParameter();
      ((DbParameter) mySqlParameter8).ParameterName = "@Original_imagen3";
      ((DbParameter) mySqlParameter8).DbType = DbType.Object;
      mySqlParameter8.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter8).IsNullable = true;
      ((DbParameter) mySqlParameter8).SourceColumn = "imagen3";
      ((DbParameter) mySqlParameter8).SourceVersion = DataRowVersion.Original;
      this._adapter.DeleteCommand.Parameters.Add(mySqlParameter8);
      this._adapter.InsertCommand=new MySqlCommand();
      this._adapter.InsertCommand.Connection=this.Connection;
      ((DbCommand) this._adapter.InsertCommand).CommandText = "INSERT INTO `imagenes` (`codigoProducto`, `imagen1`, `imagen2`, `imagen3`) VALUES (@codigoProducto, @imagen1, @imagen2, @imagen3)";
      ((DbCommand) this._adapter.InsertCommand).CommandType = CommandType.Text;
      MySqlParameter mySqlParameter9 = new MySqlParameter();
      ((DbParameter) mySqlParameter9).ParameterName = "@codigoProducto";
      ((DbParameter) mySqlParameter9).DbType = DbType.String;
      mySqlParameter9.MySqlDbType=(MySqlDbType) 253;
      ((DbParameter) mySqlParameter9).IsNullable = true;
      ((DbParameter) mySqlParameter9).SourceColumn = "codigoProducto";
      this._adapter.InsertCommand.Parameters.Add(mySqlParameter9);
      MySqlParameter mySqlParameter10 = new MySqlParameter();
      ((DbParameter) mySqlParameter10).ParameterName = "@imagen1";
      ((DbParameter) mySqlParameter10).DbType = DbType.Object;
      mySqlParameter10.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter10).IsNullable = true;
      ((DbParameter) mySqlParameter10).SourceColumn = "imagen1";
      this._adapter.InsertCommand.Parameters.Add(mySqlParameter10);
      MySqlParameter mySqlParameter11 = new MySqlParameter();
      ((DbParameter) mySqlParameter11).ParameterName = "@imagen2";
      ((DbParameter) mySqlParameter11).DbType = DbType.Object;
      mySqlParameter11.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter11).IsNullable = true;
      ((DbParameter) mySqlParameter11).SourceColumn = "imagen2";
      this._adapter.InsertCommand.Parameters.Add(mySqlParameter11);
      MySqlParameter mySqlParameter12 = new MySqlParameter();
      ((DbParameter) mySqlParameter12).ParameterName = "@imagen3";
      ((DbParameter) mySqlParameter12).DbType = DbType.Object;
      mySqlParameter12.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter12).IsNullable = true;
      ((DbParameter) mySqlParameter12).SourceColumn = "imagen3";
      this._adapter.InsertCommand.Parameters.Add(mySqlParameter12);
      this._adapter.UpdateCommand=new MySqlCommand();
      this._adapter.UpdateCommand.Connection=this.Connection;
      ((DbCommand) this._adapter.UpdateCommand).CommandText = "UPDATE `imagenes` SET `codigoProducto` = @codigoProducto, `imagen1` = @imagen1, `imagen2` = @imagen2, `imagen3` = @imagen3 WHERE ((`idImagen` = @Original_idImagen) AND (`codigoProducto` = @Original_codigoProducto) AND ((@IsNull_imagen1 = 1 AND `imagen1` IS NULL) OR (`imagen1` = @Original_imagen1)) AND ((@IsNull_imagen2 = 1 AND `imagen2` IS NULL) OR (`imagen2` = @Original_imagen2)) AND ((@IsNull_imagen3 = 1 AND `imagen3` IS NULL) OR (`imagen3` = @Original_imagen3)))";
      ((DbCommand) this._adapter.UpdateCommand).CommandType = CommandType.Text;
      MySqlParameter mySqlParameter13 = new MySqlParameter();
      ((DbParameter) mySqlParameter13).ParameterName = "@codigoProducto";
      ((DbParameter) mySqlParameter13).DbType = DbType.String;
      mySqlParameter13.MySqlDbType=(MySqlDbType) 253;
      ((DbParameter) mySqlParameter13).IsNullable = true;
      ((DbParameter) mySqlParameter13).SourceColumn = "codigoProducto";
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter13);
      MySqlParameter mySqlParameter14 = new MySqlParameter();
      ((DbParameter) mySqlParameter14).ParameterName = "@imagen1";
      ((DbParameter) mySqlParameter14).DbType = DbType.Object;
      mySqlParameter14.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter14).IsNullable = true;
      ((DbParameter) mySqlParameter14).SourceColumn = "imagen1";
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter14);
      MySqlParameter mySqlParameter15 = new MySqlParameter();
      ((DbParameter) mySqlParameter15).ParameterName = "@imagen2";
      ((DbParameter) mySqlParameter15).DbType = DbType.Object;
      mySqlParameter15.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter15).IsNullable = true;
      ((DbParameter) mySqlParameter15).SourceColumn = "imagen2";
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter15);
      MySqlParameter mySqlParameter16 = new MySqlParameter();
      ((DbParameter) mySqlParameter16).ParameterName = "@imagen3";
      ((DbParameter) mySqlParameter16).DbType = DbType.Object;
      mySqlParameter16.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter16).IsNullable = true;
      ((DbParameter) mySqlParameter16).SourceColumn = "imagen3";
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter16);
      MySqlParameter mySqlParameter17 = new MySqlParameter();
      ((DbParameter) mySqlParameter17).ParameterName = "@Original_idImagen";
      ((DbParameter) mySqlParameter17).DbType = DbType.Int32;
      mySqlParameter17.MySqlDbType=(MySqlDbType) 3;
      ((DbParameter) mySqlParameter17).IsNullable = true;
      ((DbParameter) mySqlParameter17).SourceColumn = "idImagen";
      ((DbParameter) mySqlParameter17).SourceVersion = DataRowVersion.Original;
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter17);
      MySqlParameter mySqlParameter18 = new MySqlParameter();
      ((DbParameter) mySqlParameter18).ParameterName = "@Original_codigoProducto";
      ((DbParameter) mySqlParameter18).DbType = DbType.String;
      mySqlParameter18.MySqlDbType=(MySqlDbType) 253;
      ((DbParameter) mySqlParameter18).IsNullable = true;
      ((DbParameter) mySqlParameter18).SourceColumn = "codigoProducto";
      ((DbParameter) mySqlParameter18).SourceVersion = DataRowVersion.Original;
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter18);
      MySqlParameter mySqlParameter19 = new MySqlParameter();
      ((DbParameter) mySqlParameter19).ParameterName = "@IsNull_imagen1";
      ((DbParameter) mySqlParameter19).DbType = DbType.Int32;
      mySqlParameter19.MySqlDbType=(MySqlDbType) 3;
      ((DbParameter) mySqlParameter19).IsNullable = true;
      ((DbParameter) mySqlParameter19).SourceColumn = "imagen1";
      ((DbParameter) mySqlParameter19).SourceVersion = DataRowVersion.Original;
      ((DbParameter) mySqlParameter19).SourceColumnNullMapping = true;
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter19);
      MySqlParameter mySqlParameter20 = new MySqlParameter();
      ((DbParameter) mySqlParameter20).ParameterName = "@Original_imagen1";
      ((DbParameter) mySqlParameter20).DbType = DbType.Object;
      mySqlParameter20.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter20).IsNullable = true;
      ((DbParameter) mySqlParameter20).SourceColumn = "imagen1";
      ((DbParameter) mySqlParameter20).SourceVersion = DataRowVersion.Original;
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter20);
      MySqlParameter mySqlParameter21 = new MySqlParameter();
      ((DbParameter) mySqlParameter21).ParameterName = "@IsNull_imagen2";
      ((DbParameter) mySqlParameter21).DbType = DbType.Int32;
      mySqlParameter21.MySqlDbType=(MySqlDbType) 3;
      ((DbParameter) mySqlParameter21).IsNullable = true;
      ((DbParameter) mySqlParameter21).SourceColumn = "imagen2";
      ((DbParameter) mySqlParameter21).SourceVersion = DataRowVersion.Original;
      ((DbParameter) mySqlParameter21).SourceColumnNullMapping = true;
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter21);
      MySqlParameter mySqlParameter22 = new MySqlParameter();
      ((DbParameter) mySqlParameter22).ParameterName = "@Original_imagen2";
      ((DbParameter) mySqlParameter22).DbType = DbType.Object;
      mySqlParameter22.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter22).IsNullable = true;
      ((DbParameter) mySqlParameter22).SourceColumn = "imagen2";
      ((DbParameter) mySqlParameter22).SourceVersion = DataRowVersion.Original;
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter22);
      MySqlParameter mySqlParameter23 = new MySqlParameter();
      ((DbParameter) mySqlParameter23).ParameterName = "@IsNull_imagen3";
      ((DbParameter) mySqlParameter23).DbType = DbType.Int32;
      mySqlParameter23.MySqlDbType=(MySqlDbType) 3;
      ((DbParameter) mySqlParameter23).IsNullable = true;
      ((DbParameter) mySqlParameter23).SourceColumn = "imagen3";
      ((DbParameter) mySqlParameter23).SourceVersion = DataRowVersion.Original;
      ((DbParameter) mySqlParameter23).SourceColumnNullMapping = true;
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter23);
      MySqlParameter mySqlParameter24 = new MySqlParameter();
      ((DbParameter) mySqlParameter24).ParameterName = "@Original_imagen3";
      ((DbParameter) mySqlParameter24).DbType = DbType.Object;
      mySqlParameter24.MySqlDbType=(MySqlDbType) 252;
      ((DbParameter) mySqlParameter24).IsNullable = true;
      ((DbParameter) mySqlParameter24).SourceColumn = "imagen3";
      ((DbParameter) mySqlParameter24).SourceVersion = DataRowVersion.Original;
      this._adapter.UpdateCommand.Parameters.Add(mySqlParameter24);
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
      ((DbCommand) this._commandCollection[0]).CommandText = "SELECT        idImagen, codigoProducto, imagen1, imagen2, imagen3\r\nFROM            imagenes";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(DtsReportes.ImagenesDataTable dataTable)
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return ((DbDataAdapter) this.Adapter).Fill((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual DtsReportes.ImagenesDataTable GetData()
    {
      this.Adapter.SelectCommand=this.CommandCollection[0];
      DtsReportes.ImagenesDataTable imagenesDataTable = new DtsReportes.ImagenesDataTable();
      ((DbDataAdapter) this.Adapter).Fill((DataTable) imagenesDataTable);
      return imagenesDataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DtsReportes.ImagenesDataTable dataTable)
    {
      return ((DbDataAdapter) this.Adapter).Update((DataTable) dataTable);
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int Update(DtsReportes dataSet)
    {
      return ((DbDataAdapter) this.Adapter).Update((DataSet) dataSet, "Imagenes");
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow dataRow)
    {
      return ((DbDataAdapter) this.Adapter).Update(new DataRow[1]
      {
        dataRow
      });
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int Update(DataRow[] dataRows)
    {
      return ((DbDataAdapter) this.Adapter).Update(dataRows);
    }
  }
}
